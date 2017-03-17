Option Strict Off
Option Explicit On
Imports System
Imports System.IO.Ports
Imports System.Threading

Friend Class frm_PAC
	Inherits System.Windows.Forms.Form
	
	
	
	Private Sub Cmd_Clr_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_Clr.Click
		RichTextBox1.Text = ""
	End Sub
	
	
	Private Sub Cmd_EnPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_EnPrint.Click
		EnablePrint = Not (EnablePrint)
		If (EnablePrint) Then
			Cmd_EnPrint.Text = "Disable Print"
		Else
			Cmd_EnPrint.Text = "Enable Print"
		End If
	End Sub
	
	
	
	Private Sub Cmd_IQ_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_IQ.Click
		Frm_IQ.Show()
	End Sub
	
	Private Sub Cmd_PAC_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Cmd_PAC.Click
		frm_PACDisplay.Show()
	End Sub
	
	
    Private Sub Combo_ComPort_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Combo_ComPort.SelectedIndexChanged

        'RichTextBox1.Text += "Available Ports:" & vbNewLine
        'RichTextBox1.Text += Combo_ComPort.SelectedItem & vbNewLine
        'Dim s As String
        'For Each s In [Enum].GetNames(GetType(Handshake))
        '    RichTextBox1.Text += s & vbNewLine
        'Next s
        'MsgBox("stopped")

        ' Allow the user to set the appropriate properties.
        _serialPort.PortName = Combo_ComPort.SelectedItem
        _serialPort.BaudRate = 9600
        _serialPort.Parity = CType([Enum].Parse(GetType(Parity), "None"), Parity)
        _serialPort.DataBits = "8"
        _serialPort.StopBits = "1"
        _serialPort.Handshake = CType([Enum].Parse(GetType(Handshake), "None"), Parity)

        ' Set the read/write timeouts
        _serialPort.ReadTimeout = 500
        _serialPort.WriteTimeout = 500

        _serialPort.Open()
        _continue = True
        readThread.Start()


    End Sub
	
	Private Sub frm_PAC_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim s As String
        For Each s In SerialPort.GetPortNames()
            Combo_ComPort.Items.Add(s)
        Next s
		InitDone = False
		EnablePrint = True
		EnableTest = False
		'    EnablePrint = False
		
		
		escCount = 0
		InputString_Renamed = ""
		
		
		Me.Text = "PAC " & GUI_Version
		
		'    frm_GCBRegs.Show
		'    Frm_DiagCntl.Show
	End Sub
	
	Private Sub frm_PAC_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        frm_PACDisplay.Close()
		'    Unload Frm_Plot
	End Sub


	Private Sub Text1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Text1.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If (Val(CStr(KeyAscii)) = 13) Then
			Call Write_Renamed_Click(Write_Renamed, New System.EventArgs())
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	
	Private Sub Write_Renamed_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Write_Renamed.Click
        _serialPort.Write(Text1.Text)
	End Sub
	
	
	


End Class