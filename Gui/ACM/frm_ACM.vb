Option Strict Off
Option Explicit On
Imports System
Imports System.IO.Ports
Imports System.Threading

Friend Class frm_ACM
    Inherits System.Windows.Forms.Form

    Public SerialEnabled As Boolean

    Private Sub Cmd_Clr_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Rtxbx_Main.Text = ""
    End Sub


    Private Sub Combo_ComPort_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Combo_ComPort.SelectedIndexChanged

        'RichTextBox1.Text += "Available Ports:" & vbNewLine
        'RichTextBox1.Text += Combo_ComPort.SelectedItem & vbNewLine
        'Dim s As String
        'For Each s In [Enum].GetNames(GetType(Handshake))
        '    RichTextBox1.Text += s & vbNewLine
        'Next s
        'MsgBox("stopped")

        MsgBox(Combo_ComPort.SelectedItem)

        ' Allow the user to set the appropriate properties.
        '       _serialPort.PortName = Combo_ComPort.SelectedItem
        _serialPort.PortName = "com8"
        _serialPort.BaudRate = 9600
        _serialPort.Parity = CType([Enum].Parse(GetType(Parity), "None"), Parity)
        _serialPort.DataBits = "8"
        _serialPort.StopBits = "1"
        _serialPort.Handshake = CType([Enum].Parse(GetType(Handshake), "None"), Parity)

        ' Set the read/write timeouts
        _serialPort.ReadTimeout = 1000
        _serialPort.WriteTimeout = 1000

        _serialPort.Open()
        _continue = True
        '        readThread.Start()

    End Sub

    Private Sub frm_ACM_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        readThread.Abort()
        _serialPort.Close()
    End Sub

    Private Sub FindHeader()
        Dim HeaderFound As Boolean
        ' Wait for AA header
        HeaderFound = False
        While Not HeaderFound
            'Wait for data in serial port
            While (_serialPort.BytesToRead = 0)
            End While
            If (_serialPort.ReadByte = &HAA) Then
                HeaderFound = True
            End If
        End While
    End Sub

    Private Sub GetMessage()
        Dim InputByte As Byte
        Dim Data As UInt16

        FindHeader()
        Rtxbx_Main.Clear()

        For i = 1 To (AcmMessageLength / 2) - 1
            'Rtxbx_Main.Text += "Byte " & i & vbNewLine
            For j = 1 To 3
                While (_serialPort.BytesToRead = 0)
                    Application.DoEvents()
                End While

                InputByte = _serialPort.ReadByte
                'Rtxbx_Main.Text += ((InputByte And &HE0) >> 5).ToString("X2") & "  " & InputByte.ToString("X2") & "   " & ChrW(InputByte) & vbNewLine
                ' Rtxbx_Main.Text += ChrW(InputByte)
                Select Case j
                    Case 1
                        Data = InputByte And &H3F
                        If ((InputByte And &HC0) <> &H0) Then
                            Rtxbx_Main.Text += "ERROR" & vbNewLine
                        End If
                    Case 2
                        Data = Data Or ((InputByte And &H1F) << 6)
                        If ((InputByte And &HE0) <> &H40) Then
                            Rtxbx_Main.Text += "ERROR" & vbNewLine
                        End If
                    Case 3
                        Data = Data Or ((InputByte And &H1F) << 11)
                        If ((InputByte And &HE0) <> &H60) Then
                            Rtxbx_Main.Text += "ERROR" & vbNewLine
                        End If
                End Select

            Next j
            AcmMessage(i * 2) = Data And &HFF
            AcmMessage((i * 2) + 1) = (Data >> 8) And &HFF
            ''Rtxbx_Main.Text += AcmMessage(i * 2).ToString("X2") & "  " & AcmMessage(i * 2 + 1).ToString("X2") & vbNewLine
            ''Rtxbx_Main.Text += vbNewLine
        Next i

    End Sub

    Private Sub frm_ACM_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim s As String
        Dim i As Integer

        _continue = False
        _serialPort.PortName = "COM8"
        _serialPort.BaudRate = 9600
        _serialPort.Parity = CType([Enum].Parse(GetType(Parity), "None"), Parity)
        _serialPort.DataBits = "8"
        _serialPort.StopBits = "1"
        _serialPort.Handshake = CType([Enum].Parse(GetType(Handshake), "None"), Parity)

        ' Set the read/write timeouts
        _serialPort.ReadTimeout = 1000
        _serialPort.WriteTimeout = 1000

        _serialPort.Open()
        '       _continue = True
        '      readThread.Start()

        'For Each s In SerialPort.GetPortNames()
        '    Combo_ComPort.Items.Add(s)
        'Next s


        Me.Text = "ACM " & GUI_Version


        '        readThread.Abort()
        '       _serialPort.Close()
    End Sub


    Private Sub btn_Go_Click(sender As System.Object, e As System.EventArgs) Handles btn_Go.Click
        GetMessage()

        For i = 1 To AcmMessageLength
            Rtxbx_Main.Text += AcmMessage(i).ToString("x2") & "   " & ChrW(AcmMessage(i)) & vbNewLine
        Next

    End Sub
End Class