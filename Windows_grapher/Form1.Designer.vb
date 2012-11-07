<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Graph = New ZedGraph.ZedGraphControl()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmbBaud = New System.Windows.Forms.ComboBox()
        Me.cmbComPorts = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkPolling = New System.Windows.Forms.CheckBox()
        Me.chkAutoScale = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTimeMax = New System.Windows.Forms.TextBox()
        Me.txtTimeMin = New System.Windows.Forms.TextBox()
        Me.txtSigAMax = New System.Windows.Forms.TextBox()
        Me.txtSigAMin = New System.Windows.Forms.TextBox()
        Me.txtSigBMax = New System.Windows.Forms.TextBox()
        Me.txtSigCMax = New System.Windows.Forms.TextBox()
        Me.txtSigC = New System.Windows.Forms.TextBox()
        Me.txtSigBMin = New System.Windows.Forms.TextBox()
        Me.txtSigCMin = New System.Windows.Forms.TextBox()
        Me.txtSigB = New System.Windows.Forms.TextBox()
        Me.txtSigA = New System.Windows.Forms.TextBox()
        Me.chkSigA = New System.Windows.Forms.CheckBox()
        Me.chkSigB = New System.Windows.Forms.CheckBox()
        Me.chkSigC = New System.Windows.Forms.CheckBox()
        Me.Debug = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Graph
        '
        Me.Graph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Graph.Location = New System.Drawing.Point(434, 51)
        Me.Graph.Name = "Graph"
        Me.Graph.ScrollGrace = 0.0R
        Me.Graph.ScrollMaxX = 0.0R
        Me.Graph.ScrollMaxY = 0.0R
        Me.Graph.ScrollMaxY2 = 0.0R
        Me.Graph.ScrollMinX = 0.0R
        Me.Graph.ScrollMinY = 0.0R
        Me.Graph.ScrollMinY2 = 0.0R
        Me.Graph.Size = New System.Drawing.Size(933, 598)
        Me.Graph.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(48, 160)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Connect"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'cmbBaud
        '
        Me.cmbBaud.FormattingEnabled = True
        Me.cmbBaud.Items.AddRange(New Object() {"2400", "4800", "9600", "19200", "38400", "57600", "115200"})
        Me.cmbBaud.Location = New System.Drawing.Point(48, 133)
        Me.cmbBaud.Name = "cmbBaud"
        Me.cmbBaud.Size = New System.Drawing.Size(121, 21)
        Me.cmbBaud.TabIndex = 2
        '
        'cmbComPorts
        '
        Me.cmbComPorts.FormattingEnabled = True
        Me.cmbComPorts.Location = New System.Drawing.Point(48, 106)
        Me.cmbComPorts.Name = "cmbComPorts"
        Me.cmbComPorts.Size = New System.Drawing.Size(121, 21)
        Me.cmbComPorts.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "COM:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Baud:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkPolling)
        Me.GroupBox1.Controls.Add(Me.chkAutoScale)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtTimeMax)
        Me.GroupBox1.Controls.Add(Me.txtTimeMin)
        Me.GroupBox1.Controls.Add(Me.txtSigAMax)
        Me.GroupBox1.Controls.Add(Me.txtSigAMin)
        Me.GroupBox1.Controls.Add(Me.txtSigBMax)
        Me.GroupBox1.Controls.Add(Me.txtSigCMax)
        Me.GroupBox1.Controls.Add(Me.txtSigC)
        Me.GroupBox1.Controls.Add(Me.txtSigBMin)
        Me.GroupBox1.Controls.Add(Me.txtSigCMin)
        Me.GroupBox1.Controls.Add(Me.txtSigB)
        Me.GroupBox1.Controls.Add(Me.txtSigA)
        Me.GroupBox1.Controls.Add(Me.chkSigA)
        Me.GroupBox1.Controls.Add(Me.chkSigB)
        Me.GroupBox1.Controls.Add(Me.chkSigC)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 244)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 257)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Signal configuration"
        '
        'chkPolling
        '
        Me.chkPolling.AutoSize = True
        Me.chkPolling.Location = New System.Drawing.Point(11, 225)
        Me.chkPolling.Name = "chkPolling"
        Me.chkPolling.Size = New System.Drawing.Size(57, 17)
        Me.chkPolling.TabIndex = 20
        Me.chkPolling.Text = "Polling"
        Me.chkPolling.UseVisualStyleBackColor = True
        '
        'chkAutoScale
        '
        Me.chkAutoScale.AutoSize = True
        Me.chkAutoScale.Checked = True
        Me.chkAutoScale.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoScale.Location = New System.Drawing.Point(11, 201)
        Me.chkAutoScale.Name = "chkAutoScale"
        Me.chkAutoScale.Size = New System.Drawing.Size(78, 17)
        Me.chkAutoScale.TabIndex = 19
        Me.chkAutoScale.Text = "Auto Scale"
        Me.chkAutoScale.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(245, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Max"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(201, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Min"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(95, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Label "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Enable"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(141, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "TimeScale"
        '
        'txtTimeMax
        '
        Me.txtTimeMax.Location = New System.Drawing.Point(248, 167)
        Me.txtTimeMax.Name = "txtTimeMax"
        Me.txtTimeMax.Size = New System.Drawing.Size(38, 20)
        Me.txtTimeMax.TabIndex = 17
        Me.txtTimeMax.Text = "100"
        '
        'txtTimeMin
        '
        Me.txtTimeMin.Location = New System.Drawing.Point(204, 167)
        Me.txtTimeMin.Name = "txtTimeMin"
        Me.txtTimeMin.Size = New System.Drawing.Size(38, 20)
        Me.txtTimeMin.TabIndex = 16
        Me.txtTimeMin.Text = "0"
        '
        'txtSigAMax
        '
        Me.txtSigAMax.Location = New System.Drawing.Point(248, 89)
        Me.txtSigAMax.Name = "txtSigAMax"
        Me.txtSigAMax.Size = New System.Drawing.Size(38, 20)
        Me.txtSigAMax.TabIndex = 6
        Me.txtSigAMax.Text = "100"
        '
        'txtSigAMin
        '
        Me.txtSigAMin.Location = New System.Drawing.Point(204, 89)
        Me.txtSigAMin.Name = "txtSigAMin"
        Me.txtSigAMin.Size = New System.Drawing.Size(38, 20)
        Me.txtSigAMin.TabIndex = 5
        Me.txtSigAMin.Text = "0"
        '
        'txtSigBMax
        '
        Me.txtSigBMax.Location = New System.Drawing.Point(248, 115)
        Me.txtSigBMax.Name = "txtSigBMax"
        Me.txtSigBMax.Size = New System.Drawing.Size(38, 20)
        Me.txtSigBMax.TabIndex = 10
        Me.txtSigBMax.Text = "100"
        '
        'txtSigCMax
        '
        Me.txtSigCMax.Location = New System.Drawing.Point(248, 141)
        Me.txtSigCMax.Name = "txtSigCMax"
        Me.txtSigCMax.Size = New System.Drawing.Size(38, 20)
        Me.txtSigCMax.TabIndex = 15
        Me.txtSigCMax.Text = "100"
        '
        'txtSigC
        '
        Me.txtSigC.Location = New System.Drawing.Point(98, 141)
        Me.txtSigC.Name = "txtSigC"
        Me.txtSigC.Size = New System.Drawing.Size(100, 20)
        Me.txtSigC.TabIndex = 12
        Me.txtSigC.Text = "Signal C"
        '
        'txtSigBMin
        '
        Me.txtSigBMin.Location = New System.Drawing.Point(204, 115)
        Me.txtSigBMin.Name = "txtSigBMin"
        Me.txtSigBMin.Size = New System.Drawing.Size(38, 20)
        Me.txtSigBMin.TabIndex = 9
        Me.txtSigBMin.Text = "0"
        '
        'txtSigCMin
        '
        Me.txtSigCMin.Location = New System.Drawing.Point(204, 141)
        Me.txtSigCMin.Name = "txtSigCMin"
        Me.txtSigCMin.Size = New System.Drawing.Size(38, 20)
        Me.txtSigCMin.TabIndex = 13
        Me.txtSigCMin.Text = "0"
        '
        'txtSigB
        '
        Me.txtSigB.Location = New System.Drawing.Point(98, 115)
        Me.txtSigB.Name = "txtSigB"
        Me.txtSigB.Size = New System.Drawing.Size(100, 20)
        Me.txtSigB.TabIndex = 8
        Me.txtSigB.Text = "Signal B"
        '
        'txtSigA
        '
        Me.txtSigA.Location = New System.Drawing.Point(98, 89)
        Me.txtSigA.Name = "txtSigA"
        Me.txtSigA.Size = New System.Drawing.Size(100, 20)
        Me.txtSigA.TabIndex = 4
        Me.txtSigA.Text = "Signal A"
        '
        'chkSigA
        '
        Me.chkSigA.AutoSize = True
        Me.chkSigA.Location = New System.Drawing.Point(11, 92)
        Me.chkSigA.Name = "chkSigA"
        Me.chkSigA.Size = New System.Drawing.Size(65, 17)
        Me.chkSigA.TabIndex = 3
        Me.chkSigA.Text = "Signal A"
        Me.chkSigA.UseVisualStyleBackColor = True
        '
        'chkSigB
        '
        Me.chkSigB.AutoSize = True
        Me.chkSigB.Location = New System.Drawing.Point(11, 115)
        Me.chkSigB.Name = "chkSigB"
        Me.chkSigB.Size = New System.Drawing.Size(65, 17)
        Me.chkSigB.TabIndex = 7
        Me.chkSigB.Text = "Signal B"
        Me.chkSigB.UseVisualStyleBackColor = True
        '
        'chkSigC
        '
        Me.chkSigC.AutoSize = True
        Me.chkSigC.Location = New System.Drawing.Point(11, 138)
        Me.chkSigC.Name = "chkSigC"
        Me.chkSigC.Size = New System.Drawing.Size(65, 17)
        Me.chkSigC.TabIndex = 11
        Me.chkSigC.Text = "Signal C"
        Me.chkSigC.UseVisualStyleBackColor = True
        '
        'Debug
        '
        Me.Debug.AutoSize = True
        Me.Debug.Location = New System.Drawing.Point(232, 29)
        Me.Debug.Name = "Debug"
        Me.Debug.Size = New System.Drawing.Size(39, 13)
        Me.Debug.TabIndex = 21
        Me.Debug.Text = "Label8"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(156, 160)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.ReceivedBytesThreshold = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1379, 661)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Debug)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbComPorts)
        Me.Controls.Add(Me.cmbBaud)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Graph)
        Me.Name = "Form1"
        Me.Text = "Arduino Grapher"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Graph As ZedGraph.ZedGraphControl
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmbBaud As System.Windows.Forms.ComboBox
    Friend WithEvents cmbComPorts As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTimeMax As System.Windows.Forms.TextBox
    Friend WithEvents txtTimeMin As System.Windows.Forms.TextBox
    Friend WithEvents txtSigAMax As System.Windows.Forms.TextBox
    Friend WithEvents txtSigAMin As System.Windows.Forms.TextBox
    Friend WithEvents txtSigBMax As System.Windows.Forms.TextBox
    Friend WithEvents txtSigCMax As System.Windows.Forms.TextBox
    Friend WithEvents txtSigC As System.Windows.Forms.TextBox
    Friend WithEvents txtSigBMin As System.Windows.Forms.TextBox
    Friend WithEvents txtSigCMin As System.Windows.Forms.TextBox
    Friend WithEvents txtSigB As System.Windows.Forms.TextBox
    Friend WithEvents txtSigA As System.Windows.Forms.TextBox
    Friend WithEvents chkSigA As System.Windows.Forms.CheckBox
    Friend WithEvents chkSigB As System.Windows.Forms.CheckBox
    Friend WithEvents chkSigC As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkAutoScale As System.Windows.Forms.CheckBox
    Friend WithEvents chkPolling As System.Windows.Forms.CheckBox
    Friend WithEvents Debug As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort

End Class
