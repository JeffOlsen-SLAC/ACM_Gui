<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frm_PAC
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents Print_Renamed As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents File As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	Public WithEvents Cmd_IQ As System.Windows.Forms.Button
	Public WithEvents Combo_ComPort As System.Windows.Forms.ComboBox
	Public WithEvents Cmd_PAC As System.Windows.Forms.Button
	Public WithEvents Cmd_Clr As System.Windows.Forms.Button
	Public WithEvents Cmd_EnPrint As System.Windows.Forms.Button
	Public WithEvents CmdBaud As System.Windows.Forms.Button
	Public CommonDialog1Open As System.Windows.Forms.OpenFileDialog
	Public CommonDialog1Save As System.Windows.Forms.SaveFileDialog
	Public CommonDialog1Font As System.Windows.Forms.FontDialog
	Public CommonDialog1Color As System.Windows.Forms.ColorDialog
	Public CommonDialog1Print As System.Windows.Forms.PrintDialog
	Public WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
	Public WithEvents Write_Renamed As System.Windows.Forms.Button
	Public WithEvents Text1 As System.Windows.Forms.TextBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_PAC))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip
        Me.File = New System.Windows.Forms.ToolStripMenuItem
        Me.Print_Renamed = New System.Windows.Forms.ToolStripMenuItem
        Me.Cmd_IQ = New System.Windows.Forms.Button
        Me.Combo_ComPort = New System.Windows.Forms.ComboBox
        Me.Cmd_PAC = New System.Windows.Forms.Button
        Me.Cmd_Clr = New System.Windows.Forms.Button
        Me.Cmd_EnPrint = New System.Windows.Forms.Button
        Me.CmdBaud = New System.Windows.Forms.Button
        Me.CommonDialog1Open = New System.Windows.Forms.OpenFileDialog
        Me.CommonDialog1Save = New System.Windows.Forms.SaveFileDialog
        Me.CommonDialog1Font = New System.Windows.Forms.FontDialog
        Me.CommonDialog1Color = New System.Windows.Forms.ColorDialog
        Me.CommonDialog1Print = New System.Windows.Forms.PrintDialog
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Write_Renamed = New System.Windows.Forms.Button
        Me.Text1 = New System.Windows.Forms.TextBox
        Me.MainMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.File})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(378, 24)
        Me.MainMenu1.TabIndex = 10
        '
        'File
        '
        Me.File.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Print_Renamed})
        Me.File.Name = "File"
        Me.File.Size = New System.Drawing.Size(35, 20)
        Me.File.Text = "File"
        '
        'Print_Renamed
        '
        Me.Print_Renamed.Name = "Print_Renamed"
        Me.Print_Renamed.Size = New System.Drawing.Size(107, 22)
        Me.Print_Renamed.Text = "Print"
        '
        'Cmd_IQ
        '
        Me.Cmd_IQ.BackColor = System.Drawing.SystemColors.Control
        Me.Cmd_IQ.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_IQ.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_IQ.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_IQ.Location = New System.Drawing.Point(304, 160)
        Me.Cmd_IQ.Name = "Cmd_IQ"
        Me.Cmd_IQ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_IQ.Size = New System.Drawing.Size(49, 33)
        Me.Cmd_IQ.TabIndex = 8
        Me.Cmd_IQ.Text = "IQ"
        Me.Cmd_IQ.UseVisualStyleBackColor = False
        '
        'Combo_ComPort
        '
        Me.Combo_ComPort.BackColor = System.Drawing.SystemColors.Window
        Me.Combo_ComPort.Cursor = System.Windows.Forms.Cursors.Default
        Me.Combo_ComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_ComPort.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_ComPort.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Combo_ComPort.Location = New System.Drawing.Point(304, 72)
        Me.Combo_ComPort.Name = "Combo_ComPort"
        Me.Combo_ComPort.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Combo_ComPort.Size = New System.Drawing.Size(57, 22)
        Me.Combo_ComPort.TabIndex = 7
        '
        'Cmd_PAC
        '
        Me.Cmd_PAC.BackColor = System.Drawing.SystemColors.Control
        Me.Cmd_PAC.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_PAC.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_PAC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_PAC.Location = New System.Drawing.Point(304, 112)
        Me.Cmd_PAC.Name = "Cmd_PAC"
        Me.Cmd_PAC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_PAC.Size = New System.Drawing.Size(49, 33)
        Me.Cmd_PAC.TabIndex = 6
        Me.Cmd_PAC.Text = "PAC"
        Me.Cmd_PAC.UseVisualStyleBackColor = False
        '
        'Cmd_Clr
        '
        Me.Cmd_Clr.BackColor = System.Drawing.SystemColors.Control
        Me.Cmd_Clr.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Clr.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Clr.Location = New System.Drawing.Point(312, 456)
        Me.Cmd_Clr.Name = "Cmd_Clr"
        Me.Cmd_Clr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Clr.Size = New System.Drawing.Size(49, 25)
        Me.Cmd_Clr.TabIndex = 5
        Me.Cmd_Clr.Text = "Clear"
        Me.Cmd_Clr.UseVisualStyleBackColor = False
        '
        'Cmd_EnPrint
        '
        Me.Cmd_EnPrint.BackColor = System.Drawing.SystemColors.Control
        Me.Cmd_EnPrint.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_EnPrint.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_EnPrint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_EnPrint.Location = New System.Drawing.Point(312, 488)
        Me.Cmd_EnPrint.Name = "Cmd_EnPrint"
        Me.Cmd_EnPrint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_EnPrint.Size = New System.Drawing.Size(49, 33)
        Me.Cmd_EnPrint.TabIndex = 4
        Me.Cmd_EnPrint.Text = "Disable Print"
        Me.Cmd_EnPrint.UseVisualStyleBackColor = False
        '
        'CmdBaud
        '
        Me.CmdBaud.BackColor = System.Drawing.SystemColors.Control
        Me.CmdBaud.Cursor = System.Windows.Forms.Cursors.Default
        Me.CmdBaud.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdBaud.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CmdBaud.Location = New System.Drawing.Point(312, 528)
        Me.CmdBaud.Name = "CmdBaud"
        Me.CmdBaud.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CmdBaud.Size = New System.Drawing.Size(49, 25)
        Me.CmdBaud.TabIndex = 3
        Me.CmdBaud.Text = "Baud"
        Me.CmdBaud.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(8, 72)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBox1.Size = New System.Drawing.Size(273, 489)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = "RichTextBox1"
        '
        'Write_Renamed
        '
        Me.Write_Renamed.BackColor = System.Drawing.SystemColors.Control
        Me.Write_Renamed.Cursor = System.Windows.Forms.Cursors.Default
        Me.Write_Renamed.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Write_Renamed.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Write_Renamed.Location = New System.Drawing.Point(216, 32)
        Me.Write_Renamed.Name = "Write_Renamed"
        Me.Write_Renamed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Write_Renamed.Size = New System.Drawing.Size(57, 25)
        Me.Write_Renamed.TabIndex = 1
        Me.Write_Renamed.Text = "Write"
        Me.Write_Renamed.UseVisualStyleBackColor = False
        '
        'Text1
        '
        Me.Text1.AcceptsReturn = True
        Me.Text1.BackColor = System.Drawing.SystemColors.Window
        Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Text1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.Location = New System.Drawing.Point(8, 32)
        Me.Text1.MaxLength = 0
        Me.Text1.Name = "Text1"
        Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text1.Size = New System.Drawing.Size(201, 20)
        Me.Text1.TabIndex = 0
        Me.Text1.Text = "go"
        '
        'frm_PAC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(378, 580)
        Me.Controls.Add(Me.Cmd_IQ)
        Me.Controls.Add(Me.Combo_ComPort)
        Me.Controls.Add(Me.Cmd_PAC)
        Me.Controls.Add(Me.Cmd_Clr)
        Me.Controls.Add(Me.Cmd_EnPrint)
        Me.Controls.Add(Me.CmdBaud)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Write_Renamed)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(11, 49)
        Me.Name = "frm_PAC"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "MARX "
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region
End Class