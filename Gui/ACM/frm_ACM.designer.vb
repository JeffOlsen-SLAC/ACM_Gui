<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frm_ACM
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
    Public WithEvents Combo_ComPort As System.Windows.Forms.ComboBox
    Public WithEvents Rtxbx_Main As System.Windows.Forms.RichTextBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Combo_ComPort = New System.Windows.Forms.ComboBox()
        Me.Rtxbx_Main = New System.Windows.Forms.RichTextBox()
        Me.btn_Go = New System.Windows.Forms.Button()
        Me.SuspendLayout()
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
        'Rtxbx_Main
        '
        Me.Rtxbx_Main.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rtxbx_Main.Location = New System.Drawing.Point(8, 72)
        Me.Rtxbx_Main.Name = "Rtxbx_Main"
        Me.Rtxbx_Main.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.Rtxbx_Main.Size = New System.Drawing.Size(273, 489)
        Me.Rtxbx_Main.TabIndex = 2
        Me.Rtxbx_Main.Text = "RichTextBox1"
        '
        'btn_Go
        '
        Me.btn_Go.Location = New System.Drawing.Point(308, 110)
        Me.btn_Go.Name = "btn_Go"
        Me.btn_Go.Size = New System.Drawing.Size(52, 23)
        Me.btn_Go.TabIndex = 8
        Me.btn_Go.Text = "Go"
        Me.btn_Go.UseVisualStyleBackColor = True
        '
        'frm_ACM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(378, 580)
        Me.Controls.Add(Me.btn_Go)
        Me.Controls.Add(Me.Combo_ComPort)
        Me.Controls.Add(Me.Rtxbx_Main)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(11, 49)
        Me.Name = "frm_ACM"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "ACM"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Go As System.Windows.Forms.Button
#End Region
End Class