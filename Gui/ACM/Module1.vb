Option Strict Off
Option Explicit On
Imports System
Imports System.IO.Ports
Imports System.Threading
Module Module1

    Public _serialPort As New SerialPort
    Public _continue As Boolean


    Public Const GUI_Version As String = "Version 1.0"

    Public Declare Function Sleep Lib "Kernel32" (ByVal Milliseconds As Short) As Integer

    Public readThread As Thread = New Thread(AddressOf Read)
    Public Message As Byte
    Public ValidMessage As Boolean
    Public AcmMessageLength = 278
    Public AcmMessage(AcmMessageLength) As Byte


    Public Sub Read()
        While (_continue)
            Try
                Message = _serialPort.ReadByte()
                ValidMessage = True
            Catch ex As TimeoutException
                ' Do nothing
            End Try
        End While
    End Sub

End Module