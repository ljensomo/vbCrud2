Imports System.Data.Odbc
Module moConnection

    Public con As New Odbc.OdbcConnection

    Public Sub connect()
        con = New Odbc.OdbcConnection("DSN=crud2")

        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If

            ' MsgBox("Connected Successfully!")
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

End Module
