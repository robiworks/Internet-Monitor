<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IEComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ExternalIPLbl = New System.Windows.Forms.Label()
        Me.InternalIPLabel = New System.Windows.Forms.Label()
        Me.ExternalIPLabel = New System.Windows.Forms.Label()
        Me.CopyInternalIPButton = New System.Windows.Forms.Button()
        Me.CopyExternalIPButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ColourThemeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DownloadSpeedLabel = New System.Windows.Forms.Label()
        Me.UploadSpeedLabel = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TotalDownloadLabel = New System.Windows.Forms.Label()
        Me.TotalUploadLabel = New System.Windows.Forms.Label()
        Me.SpeedChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.LanguageComboBox = New System.Windows.Forms.ComboBox()
        Me.EnableChartCheckBox = New System.Windows.Forms.CheckBox()
        Me.RefreshIPBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SamplingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TimespanComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.SpeedChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Tag = "TitleLabel"
        Me.Label1.Text = "Adapter Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Tag = "PermanentLabel"
        Me.Label2.Text = "Network adapter:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IEComboBox
        '
        Me.IEComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.IEComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IEComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IEComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.IEComboBox.FormattingEnabled = True
        Me.IEComboBox.ItemHeight = 17
        Me.IEComboBox.Items.AddRange(New Object() {"Test 1", "Test 2"})
        Me.IEComboBox.Location = New System.Drawing.Point(129, 36)
        Me.IEComboBox.Name = "IEComboBox"
        Me.IEComboBox.Size = New System.Drawing.Size(250, 25)
        Me.IEComboBox.TabIndex = 2
        Me.IEComboBox.Tag = "ComboBoxCT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Tag = "PermanentLabel"
        Me.Label3.Text = "Internal IP:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ExternalIPLbl
        '
        Me.ExternalIPLbl.AutoSize = True
        Me.ExternalIPLbl.Location = New System.Drawing.Point(51, 110)
        Me.ExternalIPLbl.Name = "ExternalIPLbl"
        Me.ExternalIPLbl.Size = New System.Drawing.Size(71, 17)
        Me.ExternalIPLbl.TabIndex = 4
        Me.ExternalIPLbl.Tag = "PermanentLabel"
        Me.ExternalIPLbl.Text = "External IP:"
        Me.ExternalIPLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'InternalIPLabel
        '
        Me.InternalIPLabel.AutoSize = True
        Me.InternalIPLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic)
        Me.InternalIPLabel.ForeColor = System.Drawing.Color.Yellow
        Me.InternalIPLabel.Location = New System.Drawing.Point(129, 75)
        Me.InternalIPLabel.Name = "InternalIPLabel"
        Me.InternalIPLabel.Size = New System.Drawing.Size(87, 17)
        Me.InternalIPLabel.TabIndex = 5
        Me.InternalIPLabel.Tag = "ModifiableLabel"
        Me.InternalIPLabel.Text = "192.168.0.100"
        Me.InternalIPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ExternalIPLabel
        '
        Me.ExternalIPLabel.AutoSize = True
        Me.ExternalIPLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic)
        Me.ExternalIPLabel.ForeColor = System.Drawing.Color.Yellow
        Me.ExternalIPLabel.Location = New System.Drawing.Point(129, 110)
        Me.ExternalIPLabel.Name = "ExternalIPLabel"
        Me.ExternalIPLabel.Size = New System.Drawing.Size(45, 17)
        Me.ExternalIPLabel.TabIndex = 6
        Me.ExternalIPLabel.Tag = "ModifiableLabel"
        Me.ExternalIPLabel.Text = "1.2.3.4"
        Me.ExternalIPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CopyInternalIPButton
        '
        Me.CopyInternalIPButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.CopyInternalIPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CopyInternalIPButton.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.CopyInternalIPButton.Location = New System.Drawing.Point(304, 71)
        Me.CopyInternalIPButton.Name = "CopyInternalIPButton"
        Me.CopyInternalIPButton.Size = New System.Drawing.Size(75, 25)
        Me.CopyInternalIPButton.TabIndex = 7
        Me.CopyInternalIPButton.Tag = "ButtonCT"
        Me.CopyInternalIPButton.Text = "Copy"
        Me.CopyInternalIPButton.UseVisualStyleBackColor = False
        '
        'CopyExternalIPButton
        '
        Me.CopyExternalIPButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.CopyExternalIPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CopyExternalIPButton.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.CopyExternalIPButton.Location = New System.Drawing.Point(304, 106)
        Me.CopyExternalIPButton.Name = "CopyExternalIPButton"
        Me.CopyExternalIPButton.Size = New System.Drawing.Size(75, 25)
        Me.CopyExternalIPButton.TabIndex = 8
        Me.CopyExternalIPButton.Tag = "ButtonCT"
        Me.CopyExternalIPButton.Text = "Copy"
        Me.CopyExternalIPButton.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(814, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 21)
        Me.Label7.TabIndex = 9
        Me.Label7.Tag = "TitleLabel"
        Me.Label7.Text = "App Settings"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ColourThemeComboBox
        '
        Me.ColourThemeComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ColourThemeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ColourThemeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ColourThemeComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ColourThemeComboBox.FormattingEnabled = True
        Me.ColourThemeComboBox.Items.AddRange(New Object() {"Dark (default)", "Light"})
        Me.ColourThemeComboBox.Location = New System.Drawing.Point(771, 36)
        Me.ColourThemeComboBox.Name = "ColourThemeComboBox"
        Me.ColourThemeComboBox.Size = New System.Drawing.Size(150, 25)
        Me.ColourThemeComboBox.TabIndex = 10
        Me.ColourThemeComboBox.Tag = "ComboBoxCT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(682, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Tag = "PermanentLabel"
        Me.Label8.Text = "Color theme:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(12, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 21)
        Me.Label9.TabIndex = 12
        Me.Label9.Tag = "TitleLabel"
        Me.Label9.Text = "Current Properties"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 220)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 17)
        Me.Label10.TabIndex = 13
        Me.Label10.Tag = "PermanentLabel"
        Me.Label10.Text = "Download speed:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(28, 255)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 17)
        Me.Label11.TabIndex = 14
        Me.Label11.Tag = "PermanentLabel"
        Me.Label11.Text = "Upload speed:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DownloadSpeedLabel
        '
        Me.DownloadSpeedLabel.AutoSize = True
        Me.DownloadSpeedLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic)
        Me.DownloadSpeedLabel.ForeColor = System.Drawing.Color.Yellow
        Me.DownloadSpeedLabel.Location = New System.Drawing.Point(129, 220)
        Me.DownloadSpeedLabel.Name = "DownloadSpeedLabel"
        Me.DownloadSpeedLabel.Size = New System.Drawing.Size(36, 17)
        Me.DownloadSpeedLabel.TabIndex = 15
        Me.DownloadSpeedLabel.Tag = "ModifiableLabel"
        Me.DownloadSpeedLabel.Text = "0 B/s"
        Me.DownloadSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UploadSpeedLabel
        '
        Me.UploadSpeedLabel.AutoSize = True
        Me.UploadSpeedLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic)
        Me.UploadSpeedLabel.ForeColor = System.Drawing.Color.Yellow
        Me.UploadSpeedLabel.Location = New System.Drawing.Point(129, 255)
        Me.UploadSpeedLabel.Name = "UploadSpeedLabel"
        Me.UploadSpeedLabel.Size = New System.Drawing.Size(36, 17)
        Me.UploadSpeedLabel.TabIndex = 16
        Me.UploadSpeedLabel.Tag = "ModifiableLabel"
        Me.UploadSpeedLabel.Text = "0 B/s"
        Me.UploadSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(12, 303)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(149, 21)
        Me.Label14.TabIndex = 17
        Me.Label14.Tag = "TitleLabel"
        Me.Label14.Text = "Session Properties"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 333)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 17)
        Me.Label15.TabIndex = 18
        Me.Label15.Tag = "PermanentLabel"
        Me.Label15.Text = "Total download:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(37, 368)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 17)
        Me.Label16.TabIndex = 19
        Me.Label16.Tag = "PermanentLabel"
        Me.Label16.Text = "Total upload:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalDownloadLabel
        '
        Me.TotalDownloadLabel.AutoSize = True
        Me.TotalDownloadLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic)
        Me.TotalDownloadLabel.ForeColor = System.Drawing.Color.Yellow
        Me.TotalDownloadLabel.Location = New System.Drawing.Point(129, 333)
        Me.TotalDownloadLabel.Name = "TotalDownloadLabel"
        Me.TotalDownloadLabel.Size = New System.Drawing.Size(37, 17)
        Me.TotalDownloadLabel.TabIndex = 20
        Me.TotalDownloadLabel.Tag = "ModifiableLabel"
        Me.TotalDownloadLabel.Text = "0 MB"
        Me.TotalDownloadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalUploadLabel
        '
        Me.TotalUploadLabel.AutoSize = True
        Me.TotalUploadLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic)
        Me.TotalUploadLabel.ForeColor = System.Drawing.Color.Yellow
        Me.TotalUploadLabel.Location = New System.Drawing.Point(129, 368)
        Me.TotalUploadLabel.Name = "TotalUploadLabel"
        Me.TotalUploadLabel.Size = New System.Drawing.Size(37, 17)
        Me.TotalUploadLabel.TabIndex = 21
        Me.TotalUploadLabel.Tag = "ModifiableLabel"
        Me.TotalUploadLabel.Text = "0 MB"
        Me.TotalUploadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SpeedChart
        '
        Me.SpeedChart.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        ChartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        ChartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        ChartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        ChartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        ChartArea1.AxisX.Title = "Time elapsed [s]"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        ChartArea1.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        ChartArea1.AxisY.IsLabelAutoFit = False
        ChartArea1.AxisY.LabelStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        ChartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        ChartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        ChartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        ChartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        ChartArea1.AxisY.Title = "Speed [kB/s]"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        ChartArea1.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        ChartArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        ChartArea1.Name = "ChartArea1"
        Me.SpeedChart.ChartAreas.Add(ChartArea1)
        Legend1.Alignment = System.Drawing.StringAlignment.Center
        Legend1.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Legend1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Legend1.ForeColor = System.Drawing.Color.White
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.SpeedChart.Legends.Add(Legend1)
        Me.SpeedChart.Location = New System.Drawing.Point(304, 190)
        Me.SpeedChart.Name = "SpeedChart"
        Series1.BorderWidth = 2
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Color = System.Drawing.Color.Lime
        Series1.Legend = "Legend1"
        Series1.LegendText = "Download"
        Series1.Name = "SeriesDownload"
        Series2.BorderWidth = 2
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Color = System.Drawing.Color.DeepSkyBlue
        Series2.Legend = "Legend1"
        Series2.LegendText = "Upload"
        Series2.Name = "SeriesUpload"
        Me.SpeedChart.Series.Add(Series1)
        Me.SpeedChart.Series.Add(Series2)
        Me.SpeedChart.Size = New System.Drawing.Size(617, 356)
        Me.SpeedChart.TabIndex = 22
        Me.SpeedChart.Text = "Chart1"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(697, 74)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 17)
        Me.Label19.TabIndex = 23
        Me.Label19.Tag = "PermanentLabel"
        Me.Label19.Text = "Language:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LanguageComboBox
        '
        Me.LanguageComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.LanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LanguageComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LanguageComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LanguageComboBox.FormattingEnabled = True
        Me.LanguageComboBox.Items.AddRange(New Object() {"English", "Slovenian"})
        Me.LanguageComboBox.Location = New System.Drawing.Point(771, 71)
        Me.LanguageComboBox.Name = "LanguageComboBox"
        Me.LanguageComboBox.Size = New System.Drawing.Size(150, 25)
        Me.LanguageComboBox.TabIndex = 24
        Me.LanguageComboBox.Tag = "ComboBoxCT"
        '
        'EnableChartCheckBox
        '
        Me.EnableChartCheckBox.AutoSize = True
        Me.EnableChartCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EnableChartCheckBox.Location = New System.Drawing.Point(154, 413)
        Me.EnableChartCheckBox.Name = "EnableChartCheckBox"
        Me.EnableChartCheckBox.Size = New System.Drawing.Size(96, 21)
        Me.EnableChartCheckBox.TabIndex = 25
        Me.EnableChartCheckBox.Tag = "CheckBoxCT"
        Me.EnableChartCheckBox.Text = "Enable chart"
        Me.EnableChartCheckBox.UseVisualStyleBackColor = True
        '
        'RefreshIPBtn
        '
        Me.RefreshIPBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.RefreshIPBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshIPBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RefreshIPBtn.Location = New System.Drawing.Point(16, 140)
        Me.RefreshIPBtn.Name = "RefreshIPBtn"
        Me.RefreshIPBtn.Size = New System.Drawing.Size(363, 30)
        Me.RefreshIPBtn.TabIndex = 26
        Me.RefreshIPBtn.Tag = "ButtonCT"
        Me.RefreshIPBtn.Text = "Refresh IP"
        Me.RefreshIPBtn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(758, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 21)
        Me.Label4.TabIndex = 28
        Me.Label4.Tag = "TitleLabel"
        Me.Label4.Text = "Internet speed chart"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SamplingTimer
        '
        Me.SamplingTimer.Enabled = True
        Me.SamplingTimer.Interval = 1000
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(12, 412)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 21)
        Me.Label5.TabIndex = 29
        Me.Label5.Tag = "TitleLabel"
        Me.Label5.Text = "Chart Settings"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 446)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 17)
        Me.Label6.TabIndex = 30
        Me.Label6.Tag = "PermanentLabel"
        Me.Label6.Text = "Chart timespan:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TimespanComboBox
        '
        Me.TimespanComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.TimespanComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TimespanComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TimespanComboBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TimespanComboBox.FormattingEnabled = True
        Me.TimespanComboBox.Items.AddRange(New Object() {"10 s", "20 s", "30 s", "1 min", "5 min", "10 min"})
        Me.TimespanComboBox.Location = New System.Drawing.Point(129, 443)
        Me.TimespanComboBox.Name = "TimespanComboBox"
        Me.TimespanComboBox.Size = New System.Drawing.Size(121, 25)
        Me.TimespanComboBox.TabIndex = 31
        Me.TimespanComboBox.Tag = "ComboBoxCT"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(933, 560)
        Me.Controls.Add(Me.TimespanComboBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RefreshIPBtn)
        Me.Controls.Add(Me.EnableChartCheckBox)
        Me.Controls.Add(Me.LanguageComboBox)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.SpeedChart)
        Me.Controls.Add(Me.TotalUploadLabel)
        Me.Controls.Add(Me.TotalDownloadLabel)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.UploadSpeedLabel)
        Me.Controls.Add(Me.DownloadSpeedLabel)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ColourThemeComboBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CopyExternalIPButton)
        Me.Controls.Add(Me.CopyInternalIPButton)
        Me.Controls.Add(Me.ExternalIPLabel)
        Me.Controls.Add(Me.InternalIPLabel)
        Me.Controls.Add(Me.ExternalIPLbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.IEComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainWindow"
        Me.Text = "Internet Monitor"
        CType(Me.SpeedChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents IEComboBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ExternalIPLbl As Label
    Friend WithEvents InternalIPLabel As Label
    Friend WithEvents ExternalIPLabel As Label
    Friend WithEvents CopyInternalIPButton As Button
    Friend WithEvents CopyExternalIPButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents ColourThemeComboBox As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents DownloadSpeedLabel As Label
    Friend WithEvents UploadSpeedLabel As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TotalDownloadLabel As Label
    Friend WithEvents TotalUploadLabel As Label
    Friend WithEvents SpeedChart As DataVisualization.Charting.Chart
    Friend WithEvents Label19 As Label
    Friend WithEvents LanguageComboBox As ComboBox
    Friend WithEvents EnableChartCheckBox As CheckBox
    Friend WithEvents RefreshIPBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents SamplingTimer As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TimespanComboBox As ComboBox
End Class
