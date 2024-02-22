Imports System.Data.SqlClient
Module DataBaseConnectors
    Public CONNECTION As String = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RMS_DB;Integrated Security=True;Connect Timeout=0;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    Public Command As SqlCommand
    Public Reader As SqlDataReader
    Public Adapter As SqlDataAdapter
    Public Data_Table As DataTable
End Module
