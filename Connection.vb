Public Class Connection
    Private _datasource As String = "xe"
    Private _uname As String
    Private _pwd As String
    Private _datareader As System.Data.OracleClient.OracleDataReader


    Public Property DataReader() As Object
        Get
            Return _datareader
        End Get
        Set(ByVal value As Object)
            _datareader = value
        End Set
    End Property


    Public Property DataSource() As String
        Get
            Return _datasource
        End Get
        Set(ByVal value As String)
            _datasource = value
        End Set
    End Property


    Public Property UserID() As String
        Get
            Return _uname
        End Get
        Set(ByVal value As String)
            _uname = value
        End Set
    End Property


    Public Property Password() As String
        Get
            Return _pwd
        End Get
        Set(ByVal value As String)
            _pwd = value
        End Set
    End Property




    Public Sub Connect()
        Try
            conn.Close()
            conn.ConnectionString = "Data Source=" & _datasource & ";User Id=" & _uname & ";Password=" & _pwd & ";"
            conn.Open()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally

        End Try
    End Sub


    Public Sub Disconnect()
        If (conn.State = True) Then
            conn.Close()
            conn.Dispose()

        End If
    End Sub

End Class
