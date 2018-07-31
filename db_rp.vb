Public Class db_rp  '外理报文专用
    Public Shared connstr As String

    '填充DATASET,不对数据做增、删、改操作
    Public Shared Function Filldata(ByVal sqlstr As String) As DataView
        Dim sqlcmd As New SqlClient.SqlCommand
        Dim sqlad As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet()
        sqlcmd.Connection = New SqlClient.SqlConnection(connstr)
        sqlcmd.CommandText = sqlstr
        sqlcmd.CommandTimeout = 300
        sqlad.SelectCommand = sqlcmd
        sqlad.Fill(ds)
        Return ds.Tables(0).DefaultView
    End Function

    '获取数据,与RunUpdata配合使用可以实现对DataGrid的数据更新
    Public Shared Function Getdata(ByVal sqlstr As String, ByVal ds As DataSet) As DataView
        Dim sqlcmd As New SqlClient.SqlCommand
        Dim sqlad As New SqlClient.SqlDataAdapter
        ds.Reset()
        sqlcmd.Connection = New SqlClient.SqlConnection(connstr)
        sqlcmd.CommandTimeout = 300
        sqlcmd.CommandText = sqlstr
        sqlad.SelectCommand = sqlcmd
        sqlad.Fill(ds)
        Return ds.Tables(0).DefaultView
    End Function

    '与GetData配合使用可以实现对DataGrid的数据更新
    Public Shared sub RunUpdata(ByVal sqlstr As String, ByVal ds As DataSet)
        Dim sqlcmd As New SqlClient.SqlCommand
        Dim sqlad As New SqlClient.SqlDataAdapter
        sqlcmd.Connection = New SqlClient.SqlConnection(connstr)
        sqlcmd.CommandText = sqlstr
        sqlcmd.CommandTimeout = 300
        sqlad.SelectCommand = sqlcmd
        Dim sqlcmdbuild As New SqlClient.SqlCommandBuilder(sqlad)
        sqlcmdbuild.RefreshSchema()
        sqlad.Update(ds)
    End Sub

    '使用DATATABLE,主要用于单记录
    Public Shared Function Updatedata(ByVal sqlad As SqlClient.SqlDataAdapter, ByVal sqlstr As String, ByVal ds As DataSet) As DataView
        Dim sqlcmd As New SqlClient.SqlCommand
        ds.Reset()
        sqlcmd.Connection = New SqlClient.SqlConnection(connstr)
        sqlcmd.CommandText = sqlstr
        sqlcmd.CommandTimeout = 300
        sqlad.SelectCommand = sqlcmd
        Dim sqlcmdbuild As New SqlClient.SqlCommandBuilder(sqlad)
        sqlcmdbuild.RefreshSchema()
        sqlad.Fill(ds)
        Return ds.Tables(0).DefaultView
    End Function


    '执行SQL语句，也可执行存储过程
    Public Shared Sub ExecSql(ByVal sqlstr As String)
        Dim sqlcmd As New SqlClient.SqlCommand(sqlstr, New SqlClient.SqlConnection(connstr))
        sqlcmd.CommandTimeout = 300
        Try
            sqlcmd.Connection.Open()
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        sqlcmd.Connection.Close()
    End Sub

End Class
