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
    ' Secondary ForeColour :

    Dim Adapters As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
    Private IECurrent As NetworkInterface
    Private StartStatistics As Boolean = False
    Delegate Sub FuncCallBack(ByRef obj As Object, ByVal text As String)
    Dim Thread As Threading.Thread = Nothing
    Dim IEConnection As New Connection
    Event IEChangeHandler As NetworkInformation.NetworkAvailabilityChangedEventHandler
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInterfaceBox()
        UpdateExternalIP()
        Thread = New Threading.Thread(AddressOf UpdateExternalIP)
        Thread.IsBackground = True
        Thread.Start()
        IEComboBox.DisplayMember = "Name"
        IEComboBox.ValueMember = "Id"
        AddHandler NetworkChange.NetworkAvailabilityChanged, AddressOf NetworkChanged_Event
        AddHandler NetworkChange.NetworkAddressChanged, AddressOf NetworkAddressChanged_Event
    End Sub
    Private Sub LoadInterfaceBox()
        Adapters = NetworkInterface.GetAllNetworkInterfaces
        Dim IEFilter As NetworkInterfaceType() = {NetworkInterfaceType.Ethernet, NetworkInterfaceType.Ppp, NetworkInterfaceType.Wireless80211}
        If IEComboBox.InvokeRequired Then
            Dim d As New FuncCallBack(AddressOf LoadInterfaceBox)
            Me.Invoke(d, New Object() {Nothing, Nothing})
        Else
            IEComboBox.Items.Clear()
            For Each networkIE As NetworkInterface In IEConnection.GetInterface ' Nalozi vse primerne adapterje v ComboBox
                IEComboBox.Items.Add(networkIE)
            Next
            For Each adapter As NetworkInterface In IEComboBox.Items
                If adapter.Name.Equals(My.Settings.LastAdapter) Then ' Ce je user zadnjic ze izbral adapter, izbere tega avtomatsko
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
        ExternalIPLabel.Text = IEConnection.FetchExternalIP ' Prejme external IP naslov iz podatkov o povezavi
    End Sub
    Private Sub NetworkChanged_Event(ByVal sender As Object, ByVal e As NetworkInformation.NetworkAvailabilityEventArgs)
        LoadInterfaceBox() ' Ob spremembi networka se ComboBox na novo napolni z adapterji
    End Sub
    Private Sub NetworkAddressChanged_Event(ByVal sender As Object, ByVal e As EventArgs)
        LoadInterfaceBox()
        Invoke(New MethodInvoker(Sub()
                                     If IEComboBox.SelectedIndex > -1 Then
                                         Dim IPAddress = (CType(IEComboBox.SelectedItem, NetworkInterface)).GetIPProperties.UnicastAddresses(0).Address.ToString
                                         InternalIPLabel.Text = IPAddress
                                     End If
                                 End Sub))
    End Sub
    Public Function ByteConvert(ByVal bytes As Long) As String ' Pretvarjanje med kB, MB, GB, TB ...
        Dim kB As Long = 1024
        Dim MB As Long = kB * kB
        Dim GB As Long = kB * kB * kB
        Dim TB As Long = kB * kB * kB * kB
        Dim ByteValue As String = "0 B" ' Zacetni string / kolicina podatkov je 0 B

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
    Private Sub ComputeSpeed() ' Racunanje trenutne hitrosti in skupnega prenosa
        Try
            Dim IEStats As IPv4InterfaceStatistics = IEComboBox.SelectedItem.GetIPv4Statistics
            Static LastUpload As Long = IEStats.BytesSent
            Static LastDownload As Long = IEStats.BytesReceived

            If StartStatistics = True Then
                Dim Upload = IEStats.BytesSent - LastUpload ' Upload v zadnji sekundi
                Dim Download = IEStats.BytesReceived - LastDownload ' Download v zadnji sekundi
                UploadSpeedLabel.Text = ByteConvert(If(Upload < 0, 0, Upload)) & "/s"
                DownloadSpeedLabel.Text = ByteConvert(If(Download < 0, 0, Download)) & "/s"
            End If

            LastUpload = IEStats.BytesSent
            LastDownload = IEStats.BytesReceived
            TotalUploadLabel.Text = ByteConvert(IEStats.BytesSent) ' Skupen upload v seji iz IPv4 statistike
            TotalDownloadLabel.Text = ByteConvert(IEStats.BytesReceived) ' Skupen download v seji iz IPv4 statistike

            StartStatistics = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SamplingTimer_Tick(sender As Object, e As EventArgs) Handles SamplingTimer.Tick
        If IEComboBox.SelectedIndex >= 0 Then ' Preveri, ce je sploh izbran kateri adapter
            ComputeSpeed() ' Ce je, racuna hitrost, prenos itd.
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
        Clipboard.SetText(InternalIPLabel.Text)
    End Sub
    Private Sub CopyExternalIPButton_Click(sender As Object, e As EventArgs) Handles CopyExternalIPButton.Click
        Clipboard.SetText(ExternalIPLabel.Text)
    End Sub
End Class
