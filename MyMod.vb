Imports System.Data.SqlClient
Imports System.Security.Cryptography

Module MyMod
    Public myCommand As New System.Data.OracleClient.OracleCommand
    Public myAdapter As New System.Data.OracleClient.OracleDataAdapter

    Public myData As New DataTable

    Public DR As System.Data.OracleClient.OracleDataReader

    Public SQL As String

    Public conn As New System.Data.OracleClient.OracleConnection

    Public cn As New Connection

    Public users_baru As Boolean
    Public oUsers As New User

    Public login_valid As Boolean = False

    Public Sub DBConnect()
        cn.DataSource = "xe"
        cn.UserID = "peserta"
        cn.Password = "123"

        cn.Connect()
    End Sub

    Public Sub DBDisconnect()
        cn.Disconnect()
    End Sub
    Public Function getMD5Hash(ByVal strToHash As String) As String

        Dim md5Obj As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
        bytesToHash = md5Obj.ComputeHash(bytesToHash)
        Dim strResult As String = ""
        Dim b As Byte
        For Each b In bytesToHash
            strResult += b.ToString("x2")
        Next
        Return strResult
    End Function
End Module
