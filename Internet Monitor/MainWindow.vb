Imports System.Net
Imports System.Net.NetworkInformation
Public Class MainWindow
    ' >>> FONT RULES
    ' - default: Segoe UI 10pt
    ' - titles: Segoe UI 12pt bold
    ' - buttons: Segoe UI 8pt
    '
    ' >>> COLOUR PALETTE: refer to https://www.hexcolortool.com/
    ' --- DARK THEME (default) ---
    ' BackColour           : 500 #212121, 400 #3B3B3B, 300 #545454, 200 #6E6E6E, 100 #878787
    ' Primary ForeColour   : 500 #FFFFFF, 600 #E6E6E6, 700 #CCCCCC, 800 #B3B3B3, 900 #999999
    ' Secondary ForeColour : 500 #FFFF00, 600 #E6E600, 700 #CCCC00, 800 #B3B300, 900 #999900
    '
    ' --- LIGHT THEME ---
    ' BackColour           : 500 #EDEDED, 600 #D4D4D4, 700 #BABABA, 800 #A1A1A1, 900 #878787
    ' Primary ForeColour   : 500 #000000, 400 #1A1A1A, 300 #333333, 200 #4D4D4D, 100 #666666
    ' Secondary ForeColour : 500 #0000FF, 400 #1A1AFF, 300 #3333FF, 200 #4D4DFF, 100 #6666FF

    Dim Adapters As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
    Private IECurrent As NetworkInterface
    Private StartStatistics As Boolean = False
    Delegate Sub FuncCallBack(ByRef obj As Object, ByVal text As String)
    Dim Thread As Threading.Thread = Nothing
    Dim IEConnection As New Connection
    Event IEChangeHandler As NetworkInformation.NetworkAvailabilityChangedEventHandler
    ' Stvari za graf
    Private SubtractIndex As Integer
    Private TotalTime As Integer
    Private Upload As Long
    Private Download As Long
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Nalaganje uporabnikovih nastavitev.
        ColourThemeComboBox.SelectedIndex = My.Settings.ColourTheme
        TimespanComboBox.SelectedIndex = My.Settings.ChartTimespan
        YAxisUnitComboBox.SelectedIndex = My.Settings.YAxisUnit
        ' Startup drugih programskih funkcij.
        LoadInterfaceBox()
        UpdateExternalIP()
        Thread = New Threading.Thread(AddressOf UpdateExternalIP)
        Thread.IsBackground = True
        Thread.Start()
        IEComboBox.DisplayMember = "Name"
        IEComboBox.ValueMember = "Id"
        AddHandler NetworkChange.NetworkAvailabilityChanged, AddressOf NetworkChanged_Event
        AddHandler NetworkChange.NetworkAddressChanged, AddressOf NetworkAddressChanged_Event
        ' Aktiviranje grafa.
        InitialiseChart(TimespanComboBox.SelectedIndex)
    End Sub
    Private Sub LoadInterfaceBox()
        Adapters = NetworkInterface.GetAllNetworkInterfaces
        Dim IEFilter As NetworkInterfaceType() = {NetworkInterfaceType.Ethernet, NetworkInterfaceType.Ppp, NetworkInterfaceType.Wireless80211}
        If IEComboBox.InvokeRequired Then
            Dim d As New FuncCallBack(AddressOf LoadInterfaceBox)
            Me.Invoke(d, New Object() {Nothing, Nothing})
        Else
            IEComboBox.Items.Clear()
            For Each networkIE As NetworkInterface In IEConnection.GetInterface ' Nalozi vse primerne adapterje v ComboBox.
                IEComboBox.Items.Add(networkIE)
            Next
            For Each adapter As NetworkInterface In IEComboBox.Items
                If adapter.Name.Equals(My.Settings.LastAdapter) Then ' Ce je user zadnjic ze izbral adapter, izbere tega avtomatsko.
                    IEComboBox.SelectedItem = adapter
                End If
            Next
        End If
    End Sub
    Private Sub IEComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IEComboBox.SelectedIndexChanged
        If IEComboBox.SelectedIndex > -1 Then
            IECurrent = IEComboBox.SelectedItem
            Dim InterfaceIP As IPInterfaceProperties = IECurrent.GetIPProperties
            Dim IPAddress As UnicastIPAddressInformationCollection = InterfaceIP.UnicastAddresses
            If IPAddress.Count > 1 Then
                InternalIPLabel.Text = IPAddress(1).Address.ToString()
            Else
                InternalIPLabel.Text = IPAddress(0).Address.ToString()
            End If
            My.Settings.LastAdapter = IECurrent.Name
            StartStatistics = False
        End If
    End Sub
    Private Sub UpdateExternalIP()
        ExternalIPLabel.Text = IEConnection.FetchExternalIP ' Prejme external IP naslov iz podatkov o povezavi.
    End Sub
    Private Sub NetworkChanged_Event(ByVal sender As Object, ByVal e As NetworkInformation.NetworkAvailabilityEventArgs)
        LoadInterfaceBox() ' Ob spremembi networka se ComboBox na novo napolni z adapterji.
    End Sub
    Private Sub NetworkAddressChanged_Event(ByVal sender As Object, ByVal e As EventArgs)
        LoadInterfaceBox() ' Ob spremembi IP naslova se ComboBox na novo napolni z adapterji.
        Invoke(New MethodInvoker(Sub()
                                     If IEComboBox.SelectedIndex > -1 Then
                                         Dim IPAddress = (CType(IEComboBox.SelectedItem, NetworkInterface)).GetIPProperties.UnicastAddresses(0).Address.ToString
                                         InternalIPLabel.Text = IPAddress ' Izpise se nov IP.
                                     End If
                                 End Sub))
    End Sub
    Public Function ByteConvert(ByVal bytes As Long) As String ' Pretvarjanje med kB, MB, GB, TB ...
        Dim kB As Long = 1024
        Dim MB As Long = kB * kB
        Dim GB As Long = kB * kB * kB
        Dim TB As Long = kB * kB * kB * kB
        Dim ByteValue As String = "0 B" ' Zacetni string / kolicina podatkov je 0 B.

        Select Case bytes
            Case Is <= kB
                ByteValue = bytes & " B"
            Case Is > TB
                ByteValue = (bytes / TB).ToString("0.00") & " TB"
            Case Is > GB
                ByteValue = (bytes / GB).ToString("0.00") & " GB"
            Case Is > MB
                ByteValue = (bytes / MB).ToString("0.00") & " MB"
            Case Is > kB
                ByteValue = (bytes / kB).ToString("0.00") & " kB"
        End Select

        Return ByteValue.ToString ' Vrne kolicino podatkov pretvorjeno v kB, MB, GB, TB ...
    End Function
    Private Sub ComputeSpeed() ' Racunanje trenutne hitrosti in skupnega prenosa.
        Try
            Dim IEStats As IPv4InterfaceStatistics = IEComboBox.SelectedItem.GetIPv4Statistics
            Static LastUpload As Long = IEStats.BytesSent
            Static LastDownload As Long = IEStats.BytesReceived

            If StartStatistics = True Then
                Upload = IEStats.BytesSent - LastUpload ' Upload v zadnji sekundi.
                Download = IEStats.BytesReceived - LastDownload ' Download v zadnji sekundi.
                UploadSpeedLabel.Text = ByteConvert(If(Upload < 0, 0, Upload)) & "/s"
                DownloadSpeedLabel.Text = ByteConvert(If(Download < 0, 0, Download)) & "/s"
            End If

            LastUpload = IEStats.BytesSent
            LastDownload = IEStats.BytesReceived
            TotalUploadLabel.Text = ByteConvert(IEStats.BytesSent) ' Skupen upload v seji iz IPv4 statistike.
            TotalDownloadLabel.Text = ByteConvert(IEStats.BytesReceived) ' Skupen download v seji iz IPv4 statistike.

            StartStatistics = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SamplingTimer_Tick(sender As Object, e As EventArgs) Handles SamplingTimer.Tick
        If IEComboBox.SelectedIndex >= 0 Then ' Preveri, ce je sploh izbran kateri adapter.
            ComputeSpeed() ' Ce je, racuna hitrost, prenos itd.
        End If
        If EnableChartCheckBox.Checked = True Then ' Ce je graf omogocen, ga inicializira in zacne risati.
            InitialiseChart(TimespanComboBox.SelectedIndex)
            DrawChart(TotalTime)
        End If
    End Sub
    Private Sub RefreshIPBtn_Click(sender As Object, e As EventArgs) Handles RefreshIPBtn.Click
        Try
            If Not Thread.IsAlive Then
                Thread = New Threading.Thread(AddressOf UpdateExternalIP)
                Thread.IsBackground = True
                Thread.Start()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Me_Closing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            Thread.Abort()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CopyInternalIPButton_Click(sender As Object, e As EventArgs) Handles CopyInternalIPButton.Click
        Clipboard.SetText(InternalIPLabel.Text) ' Kopira internal IP v uporabnikov clipboard.
    End Sub
    Private Sub CopyExternalIPButton_Click(sender As Object, e As EventArgs) Handles CopyExternalIPButton.Click
        Clipboard.SetText(ExternalIPLabel.Text) ' Kopira external IP v uporabnikov clipboard.
    End Sub
    ' Koda za graf od tu naprej >>>
    Private Sub InitialiseChart(TimespanIndex As Integer) ' Inicializacija dinamicnega grafa.
        If EnableChartCheckBox.Checked = True Then ' SubtractIndex se uporabi za dinamicno premikanje grafa (nastavljanje min/max vrednosti na X osi).
            Select Case TimespanIndex
                Case 0
                    SubtractIndex = 10 ' 10 s
                    SpeedChart.ChartAreas(0).AxisX.Interval = 1
                Case 1
                    SubtractIndex = 20 ' 20 s
                    SpeedChart.ChartAreas(0).AxisX.Interval = 2
                Case 2
                    SubtractIndex = 30 ' 30 s
                    SpeedChart.ChartAreas(0).AxisX.Interval = 5
                Case 3
                    SubtractIndex = 60 ' 60 s
                    SpeedChart.ChartAreas(0).AxisX.Interval = 10
                Case 4
                    SubtractIndex = 300 ' 300 s = 5 min
                    SpeedChart.ChartAreas(0).AxisX.Interval = 30
                Case 5
                    SubtractIndex = 600 ' 600 s = 10 min
                    SpeedChart.ChartAreas(0).AxisX.Interval = 60
            End Select
        End If
    End Sub
    Private Sub DrawChart(TimeSeconds As Integer) ' Dinamicni graf.
        If TimeSeconds > SubtractIndex Then
            SpeedChart.ChartAreas(0).AxisX.Minimum = TimeSeconds - SubtractIndex ' Ce je pretecen cas vecji od indeksa za izbran casovni interval,
            SpeedChart.ChartAreas(0).AxisX.Maximum = TimeSeconds ' se minimalni cas in maksimalni cas dinamicno premikata.
        Else
            SpeedChart.ChartAreas(0).AxisX.Minimum = 0 ' Ce je pretecen cas manjsi od indeksa za izbran casovni interval,
            SpeedChart.ChartAreas(0).AxisX.Maximum = TimeSeconds ' je minimalni cas enak 0, maksimalni pa trenutnemu pretecenemu casu.
        End If

        ' Risanje grafa .. hitrost kaze v kB/s ali MB/s, glede na izbiro uporabnika.
        Dim kB As Long = 1024
        Dim MB As Long = kB * kB

        Dim UploadValue As Double
        Dim DownloadValue As Double
        Dim UploadValueMB As Double
        Dim DownloadValueMB As Double

        If Upload >= kB Then
            UploadValue = Upload / kB
            UploadValueMB = Upload / MB
        Else
            UploadValue = 0
            UploadValueMB = 0
        End If

        If Download >= kB Then
            DownloadValue = Download / kB
            DownloadValueMB = Download / MB
        Else
            DownloadValue = 0
            DownloadValueMB = 0
        End If

        SpeedChart.Series("SeriesDownload").Points.AddXY(TimeSeconds, DownloadValue)
        SpeedChart.Series("SeriesDownloadMB").Points.AddXY(TimeSeconds, DownloadValueMB)
        SpeedChart.Series("SeriesUpload").Points.AddXY(TimeSeconds, UploadValue)
        SpeedChart.Series("SeriesUploadMB").Points.AddXY(TimeSeconds, UploadValueMB)

        TotalTime += 1
    End Sub
    Private Sub TimespanComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TimespanComboBox.SelectedIndexChanged
        My.Settings.ChartTimespan = TimespanComboBox.SelectedIndex ' Shrani timespan za graf v nastavitve, ki se ohranijo za nov startup.
        My.Settings.Save()
    End Sub
    Private Sub EnableChartCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles EnableChartCheckBox.CheckedChanged
        Select Case EnableChartCheckBox.Checked
            Case True
                InitialiseChart(TimespanComboBox.SelectedIndex)
            Case False
                SpeedChart.Series("SeriesDownload").Points.Clear() ' Ce graf ni (vec) omogocen, pocisti vse tocke download in upload grafa
                SpeedChart.Series("SeriesUpload").Points.Clear()
                SpeedChart.Series("SeriesDownloadMB").Points.Clear()
                SpeedChart.Series("SeriesUploadMB").Points.Clear()
                TotalTime = 0 ' in ponastavi skupni cas (za risanje na X os) na default vrednost 0.
        End Select
    End Sub
    ' Koda za colour theme od tu naprej >>>
    Private Sub UpdateColourTheme(theme As Integer)
        Dim BackColour(,) As String = {{"#212121", "#EDEDED"}, {"#3B3B3B", "#D4D4D4"}, {"#545454", "#BABABA"}, {"#6E6E6E", "#A1A1A1"}, {"#878787", "#878787"}}
        Dim PrimaryForeColour(,) As String = {{"#FFFFFF", "#000000"}, {"#E6E6E6", "#1A1A1A"}, {"#CCCCCC", "#333333"}, {"#B3B3B3", "#4D4D4D"}, {"#999999", "#666666"}}
        Dim SecondaryForeColour(,) As String = {{"#FFFF00", "#0000FF"}, {"#E6E600", "#1A1AFF"}, {"#CCCC00", "#3333FF"}, {"#B3B300", "#4D4DFF"}, {"#999900", "#6666FF"}}
        Dim ChartLineColour(,) As Color = {{Color.Lime, Color.DarkRed}, {Color.DeepSkyBlue, Color.DarkBlue}}

        Me.BackColor = ColorTranslator.FromHtml(BackColour.GetValue(0, theme))
        For Each ctl As Control In Me.Controls
            Select Case ctl.Tag
                Case "TitleLabel"
                    ctl.ForeColor = ColorTranslator.FromHtml(PrimaryForeColour.GetValue(0, theme))
                Case "PermanentLabel"
                    ctl.ForeColor = ColorTranslator.FromHtml(PrimaryForeColour.GetValue(0, theme))
                Case "ModifiableLabel"
                    ctl.ForeColor = ColorTranslator.FromHtml(SecondaryForeColour.GetValue(0, theme))
                Case "ComboBoxCT"
                    ctl.BackColor = ColorTranslator.FromHtml(BackColour.GetValue(1, theme))
                    ctl.ForeColor = ColorTranslator.FromHtml(SecondaryForeColour.GetValue(1, theme))
                Case "ButtonCT"
                    ctl.BackColor = ColorTranslator.FromHtml(BackColour.GetValue(1, theme))
                    ctl.ForeColor = ColorTranslator.FromHtml(PrimaryForeColour.GetValue(1, theme))
                Case "CheckBoxCT"
                    ctl.ForeColor = ColorTranslator.FromHtml(PrimaryForeColour.GetValue(0, theme))
            End Select
        Next
        With SpeedChart
            .BackColor = ColorTranslator.FromHtml(BackColour.GetValue(1, theme))
            .Legends(0).BackColor = ColorTranslator.FromHtml(BackColour.GetValue(1, theme))
            .Legends(0).ForeColor = ColorTranslator.FromHtml(PrimaryForeColour.GetValue(1, theme))
            .ChartAreas(0).BackColor = ColorTranslator.FromHtml(BackColour.GetValue(1, theme))
            .ChartAreas(0).AxisX.LineColor = ColorTranslator.FromHtml(PrimaryForeColour.GetValue(1, theme))
            .ChartAreas(0).AxisY.LineColor = ColorTranslator.FromHtml(PrimaryForeColour.GetValue(1, theme))
            .ChartAreas(0).AxisX.TitleForeColor = ColorTranslator.FromHtml(PrimaryForeColour.GetValue(1, theme))
            .ChartAreas(0).AxisY.TitleForeColor = ColorTranslator.FromHtml(PrimaryForeColour.GetValue(1, theme))
            .ChartAreas(0).AxisX.MajorTickMark.LineColor = ColorTranslator.FromHtml(PrimaryForeColour.GetValue(1, theme))
            .ChartAreas(0).AxisY.MajorTickMark.LineColor = ColorTranslator.FromHtml(PrimaryForeColour.GetValue(1, theme))
            .ChartAreas(0).AxisX.LabelStyle.ForeColor = ColorTranslator.FromHtml(PrimaryForeColour.GetValue(1, theme))
            .ChartAreas(0).AxisY.LabelStyle.ForeColor = ColorTranslator.FromHtml(PrimaryForeColour.GetValue(1, theme))
            .Series(0).Color = ChartLineColour.GetValue(0, theme)
            .Series(2).Color = ChartLineColour.GetValue(0, theme)
            .Series(1).Color = ChartLineColour.GetValue(1, theme)
            .Series(3).Color = ChartLineColour.GetValue(1, theme)
        End With
    End Sub
    Private Sub ColourThemeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ColourThemeComboBox.SelectedIndexChanged
        If ColourThemeComboBox.SelectedIndex >= 0 Then
            UpdateColourTheme(ColourThemeComboBox.SelectedIndex)
            My.Settings.ColourTheme = ColourThemeComboBox.SelectedIndex
            My.Settings.Save()
        End If
    End Sub
    Private Sub YAxisUnitComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles YAxisUnitComboBox.SelectedIndexChanged
        Select Case YAxisUnitComboBox.SelectedIndex
            Case 0
                SpeedChart.Series("SeriesDownload").Enabled = True
                SpeedChart.Series("SeriesUpload").Enabled = True
                SpeedChart.ChartAreas(0).AxisY.Title = "Speed [kB/s]"
                SpeedChart.Series("SeriesDownloadMB").Enabled = False
                SpeedChart.Series("SeriesUploadMB").Enabled = False
                My.Settings.YAxisUnit = YAxisUnitComboBox.SelectedIndex
            Case 1
                SpeedChart.Series("SeriesDownload").Enabled = False
                SpeedChart.Series("SeriesUpload").Enabled = False
                SpeedChart.ChartAreas(0).AxisY.Title = "Speed [MB/s]"
                SpeedChart.Series("SeriesDownloadMB").Enabled = True
                SpeedChart.Series("SeriesUploadMB").Enabled = True
                My.Settings.YAxisUnit = YAxisUnitComboBox.SelectedIndex
        End Select
        My.Settings.Save()
    End Sub
End Class
