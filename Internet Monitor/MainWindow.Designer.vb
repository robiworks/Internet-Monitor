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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
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
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
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
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RefreshIPBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SamplingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.SpeedChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Adapter Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 17)
        Me.Label2.TabIndex = 1
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
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 3
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
        Me.ExternalIPLbl.Text = "External IP:"
        Me.ExternalIPLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'InternalIPLabel
        '
        Me.InternalIPLabel.AutoSize = True
        Me.InternalIPLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.InternalIPLabel.ForeColor = System.Drawing.Color.Yellow
        Me.InternalIPLabel.Location = New System.Drawing.Point(129, 75)
        Me.InternalIPLabel.Name = "InternalIPLabel"
        Me.InternalIPLabel.Size = New System.Drawing.Size(87, 17)
        Me.InternalIPLabel.TabIndex = 5
        Me.InternalIPLabel.Tag = ""
        Me.InternalIPLabel.Text = "192.168.0.100"
        Me.InternalIPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ExternalIPLabel
        '
        Me.ExternalIPLabel.AutoSize = True
        Me.ExternalIPLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ExternalIPLabel.ForeColor = System.Drawing.Color.Yellow
        Me.ExternalIPLabel.Location = New System.Drawing.Point(129, 110)
        Me.ExternalIPLabel.Name = "ExternalIPLabel"
        Me.ExternalIPLabel.Size = New System.Drawing.Size(45, 17)
        Me.ExternalIPLabel.TabIndex = 6
        Me.ExternalIPLabel.Text = "1.2.3.4"
        Me.ExternalIPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CopyInternalIPButton
        '
        Me.CopyInternalIPButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.CopyInternalIPButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.CopyInternalIPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CopyInternalIPButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CopyInternalIPButton.Location = New System.Drawing.Point(304, 71)
        Me.CopyInternalIPButton.Name = "CopyInternalIPButton"
        Me.CopyInternalIPButton.Size = New System.Drawing.Size(75, 25)
        Me.CopyInternalIPButton.TabIndex = 7
        Me.CopyInternalIPButton.Text = "Copy"
        Me.CopyInternalIPButton.UseVisualStyleBackColor = False
        '
        'CopyExternalIPButton
        '
        Me.CopyExternalIPButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.CopyExternalIPButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.CopyExternalIPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CopyExternalIPButton.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.CopyExternalIPButton.Location = New System.Drawing.Point(304, 106)
        Me.CopyExternalIPButton.Name = "CopyExternalIPButton"
        Me.CopyExternalIPButton.Size = New System.Drawing.Size(75, 25)
        Me.CopyExternalIPButton.TabIndex = 8
        Me.CopyExternalIPButton.Text = "Copy"
        Me.CopyExternalIPButton.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.Location = New System.Drawing.Point(814, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 21)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "App Settings"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Dark (default)", "Light"})
        Me.ComboBox2.Location = New System.Drawing.Point(771, 36)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(150, 25)
        Me.ComboBox2.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(682, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Color theme:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 21)
        Me.Label9.TabIndex = 12
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
        Me.Label11.Text = "Upload speed:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DownloadSpeedLabel
        '
        Me.DownloadSpeedLabel.AutoSize = True
        Me.DownloadSpeedLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.DownloadSpeedLabel.ForeColor = System.Drawing.Color.Yellow
        Me.DownloadSpeedLabel.Location = New System.Drawing.Point(129, 220)
        Me.DownloadSpeedLabel.Name = "DownloadSpeedLabel"
        Me.DownloadSpeedLabel.Size = New System.Drawing.Size(36, 17)
        Me.DownloadSpeedLabel.TabIndex = 15
        Me.DownloadSpeedLabel.Text = "0 B/s"
        Me.DownloadSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UploadSpeedLabel
        '
        Me.UploadSpeedLabel.AutoSize = True
        Me.UploadSpeedLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.UploadSpeedLabel.ForeColor = System.Drawing.Color.Yellow
        Me.UploadSpeedLabel.Location = New System.Drawing.Point(129, 255)
        Me.UploadSpeedLabel.Name = "UploadSpeedLabel"
        Me.UploadSpeedLabel.Size = New System.Drawing.Size(36, 17)
        Me.UploadSpeedLabel.TabIndex = 16
        Me.UploadSpeedLabel.Text = "0 B/s"
        Me.UploadSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 303)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(149, 21)
        Me.Label14.TabIndex = 17
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
        Me.Label16.Text = "Total upload:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TotalDownloadLabel
        '
        Me.TotalDownloadLabel.AutoSize = True
        Me.TotalDownloadLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TotalDownloadLabel.ForeColor = System.Drawing.Color.Yellow
        Me.TotalDownloadLabel.Location = New System.Drawing.Point(129, 333)
        Me.TotalDownloadLabel.Name = "TotalDownloadLabel"
        Me.TotalDownloadLabel.Size = New System.Drawing.Size(37, 17)
        Me.TotalDownloadLabel.TabIndex = 20
        Me.TotalDownloadLabel.Text = "0 MB"
        Me.TotalDownloadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TotalUploadLabel
        '
        Me.TotalUploadLabel.AutoSize = True
        Me.TotalUploadLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TotalUploadLabel.ForeColor = System.Drawing.Color.Yellow
        Me.TotalUploadLabel.Location = New System.Drawing.Point(129, 368)
        Me.TotalUploadLabel.Name = "TotalUploadLabel"
        Me.TotalUploadLabel.Size = New System.Drawing.Size(37, 17)
        Me.TotalUploadLabel.TabIndex = 21
        Me.TotalUploadLabel.Text = "0 MB"
        Me.TotalUploadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SpeedChart
        '
        Me.SpeedChart.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        ChartArea3.AxisX.IsLabelAutoFit = False
        ChartArea3.AxisX.LabelStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        ChartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        ChartArea3.AxisX.LineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        ChartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        ChartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        ChartArea3.AxisY.IsLabelAutoFit = False
        ChartArea3.AxisY.LabelStyle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        ChartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        ChartArea3.AxisY.LineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        ChartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        ChartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        ChartArea3.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        ChartArea3.Name = "ChartArea1"
        Me.SpeedChart.ChartAreas.Add(ChartArea3)
        Legend3.Alignment = System.Drawing.StringAlignment.Center
        Legend3.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(84, Byte), Integer))
        Legend3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet
        Legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Legend3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Legend3.ForeColor = System.Drawing.Color.White
        Legend3.IsTextAutoFit = False
        Legend3.Name = "Legend1"
        Me.SpeedChart.Legends.Add(Legend3)
        Me.SpeedChart.Location = New System.Drawing.Point(440, 228)
        Me.SpeedChart.Name = "SpeedChart"
        Series5.BorderWidth = 2
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series5.Color = System.Drawing.Color.Lime
        Series5.Legend = "Legend1"
        Series5.LegendText = "Download"
        Series5.Name = "SeriesDownload"
        Series6.BorderWidth = 2
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series6.Color = System.Drawing.Color.DeepSkyBlue
        Series6.Legend = "Legend1"
        Series6.LegendText = "Upload"
        Series6.Name = "SeriesUpload"
        Me.SpeedChart.Series.Add(Series5)
        Me.SpeedChart.Series.Add(Series6)
        Me.SpeedChart.Size = New System.Drawing.Size(481, 348)
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
        Me.Label19.Text = "Language:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox3
        '
        Me.ComboBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"English", "Slovenian"})
        Me.ComboBox3.Location = New System.Drawing.Point(771, 71)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(150, 25)
        Me.ComboBox3.TabIndex = 24
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.Location = New System.Drawing.Point(154, 413)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(96, 21)
        Me.CheckBox1.TabIndex = 25
        Me.CheckBox1.Text = "Enable chart"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RefreshIPBtn
        '
        Me.RefreshIPBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.RefreshIPBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshIPBtn.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.RefreshIPBtn.Location = New System.Drawing.Point(16, 140)
        Me.RefreshIPBtn.Name = "RefreshIPBtn"
        Me.RefreshIPBtn.Size = New System.Drawing.Size(363, 30)
        Me.RefreshIPBtn.TabIndex = 26
        Me.RefreshIPBtn.Text = "Refresh IP"
        Me.RefreshIPBtn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(758, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 21)
        Me.Label4.TabIndex = 28
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
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 412)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 21)
        Me.Label5.TabIndex = 29
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
        Me.Label6.Text = "Chart timespan:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"10 s", "20 s", "30 s", "1 min", "5 min", "10 min"})
        Me.ComboBox1.Location = New System.Drawing.Point(129, 443)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 25)
        Me.ComboBox1.TabIndex = 31
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(933, 588)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RefreshIPBtn)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ComboBox3)
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
        Me.Controls.Add(Me.ComboBox2)
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
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MainWindow"
        Me.Text = "Form1"
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
    Friend WithEvents ComboBox2 As ComboBox
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
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents RefreshIPBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents SamplingTimer As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
