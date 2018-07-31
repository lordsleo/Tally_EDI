Imports TALLY.DBControl
Imports System.Data.SqlClient
Public Class FrmFeeSelect
    Inherits System.Windows.Forms.Form
    'Dim mybmbase As BindingManagerBas
    Dim sqlcon As New SqlClient.SqlConnection()
    Dim nodexkey As String
    Dim sqlad As New SqlClient.SqlDataAdapter()
    Dim sqlad1 As New SqlClient.SqlDataAdapter()
#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写处置以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意：以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
    Friend WithEvents tv As System.Windows.Forms.TreeView
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tv = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'tv
        '
        Me.tv.ImageIndex = -1
        Me.tv.ItemHeight = 20
        Me.tv.Location = New System.Drawing.Point(4, 4)
        Me.tv.Name = "tv"
        Me.tv.SelectedImageIndex = -1
        Me.tv.Size = New System.Drawing.Size(288, 464)
        Me.tv.TabIndex = 18
        '
        'FrmFeeSelect
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(296, 471)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.tv})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFeeSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "选择费率代码"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Function FindDotInStr(ByVal FInputStr As String) As Integer
        Dim BeginPos, CurrentPos As Integer
        Dim InputStr As String
        Dim SearchStr As String
        Dim DotNum As Integer  '计数"."字符个数
        SearchStr = "."
        InputStr = FInputStr
        BeginPos = 1
        DotNum = 0
        Do While True
            CurrentPos = InStr(BeginPos, InputStr, SearchStr)
            '碰到一个"."字符,DotNum加一,直到无"."字符退出
            If CurrentPos > 0 Then
                BeginPos = CurrentPos + 1
                DotNum = DotNum + 1
            Else
                Exit Do
            End If
        Loop
        FindDotInStr = DotNum
    End Function
    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim nodexroot As New System.Windows.Forms.TreeNode()
        Dim nodex As New System.Windows.Forms.TreeNode()
        Dim aaa As New System.Windows.Forms.TreeNode()
        Dim bbb As New System.Windows.Forms.TreeNode()
        Dim ds1 As New DataSet()
        Dim i As Int16
        Dim j As Int16
        Dim sqlstr As String
        Dim sqlcmd As New SqlClient.SqlDataAdapter()
        Dim sqlcmdbuild As New SqlClient.SqlCommandBuilder(sqlad)
        Dim sqlconn As New SqlClient.SqlConnection(conn)
        Try
            nodexroot = tv.Nodes.Add("费率代码选择")
            nodexroot.Tag = "mm"
            i = 0
            sqlcon.Close()
            connstr = conn
            sqlstr = "select * from Code_Fee  order by Fee_Code"
            ds1 = New DataSet("Code_Fee")
            DBControl.Updatedata(sqlad, sqlstr, ds1)
            sqlad.Fill(ds1, "kkk")
            Me.BindingContext(ds1, "kkk").Position = 0
            For i = 0 To ds1.Tables(0).Rows.Count - 1
                If FindDotInStr(ds1.Tables("kkk").Rows(i).Item("Fee_Code")) = 0 And Len(Trim(ds1.Tables("kkk").Rows(i).Item("Fee_Code"))) = 1 Then
                    nodex = nodexroot.Nodes.Add(ds1.Tables("kkk").Rows(i).Item("Tally_items_CHA"))
                    nodex.Tag = ds1.Tables("kkk").Rows(i).Item("Fee_Code")
                    Dim ds2 As New DataSet()
                    sqlstr = "select * from Code_Fee where Fee_Code Like '" & ds1.Tables("kkk").Rows(i).Item("Fee_Code") & "%'  and len(ltrim(rtrim(Fee_Code)))=3 order by Fee_Code "
                    DBControl.Updatedata(sqlad, sqlstr, ds2)
                    sqlad.Fill(ds2, "kkk1")
                    Me.BindingContext(ds2, "kkk1").Position = 0
                    ' Next i
                    '填写第一层节点
                    For j = 0 To ds2.Tables(0).Rows.Count - 1
                        If FindDotInStr(ds2.Tables("kkk1").Rows(j).Item("Fee_Code")) = 0 Then
                            aaa = nodex.Nodes.Add(ds2.Tables("kkk1").Rows(j).Item("Tally_items_CHA"))
                            aaa.Tag = ds2.Tables("kkk1").Rows(j).Item("Fee_Code")
                        End If
                    Next j
                End If
            Next i
            sqlcon.Close()
        Catch ex As SqlException
            MsgBox("sql exception:" & ex.Message)
        Catch ex As Exception
            MsgBox("general exception:" & ex.Message)
        End Try
    End Sub

    Private Sub TV_AfterExpand(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tv.AfterExpand
        Dim i As Int16
        Dim aaa As New System.Windows.Forms.TreeNode()
        Dim bbb As New System.Windows.Forms.TreeNode()
        Dim sqladapter1 As SqlDataAdapter
        Dim ds1 As New DataSet()
        Dim DotNum As Integer
        Dim ChildSqlAdapter As New SqlClient.SqlDataAdapter()
        Dim DsChild As New DataSet()
        Dim SelectDept As String
        Dim sqlstr As String
        DotNum = FindDotInStr(e.Node.Tag)
        i = 0
        sqlcon.Close()
        sqlcon.ConnectionString = conn
        If Mid(e.Node.Tag, InStr(e.Node.Tag, " ", CompareMethod.Text) + 1) = "mm" Then

        Else

            Try
                sqlcon.Open()
                sqladapter1 = New SqlDataAdapter()
                '取出点开节点的下一级代码
                If Len(Trim(e.Node.Tag)) = 1 Then
                    sqladapter1.SelectCommand = New SqlCommand("select * from Code_Fee where Fee_Code like @Pdept and len(ltrim(rtrim(Fee_Code)))=3 order by Fee_Code", sqlcon)
                    SelectDept = e.Node.Tag + "%"
                    sqladapter1.SelectCommand.Parameters.Add("@Pdept", SqlDbType.VarChar, 15).Value = SelectDept
                    ds1 = New DataSet("Code_Fee")
                    sqladapter1.Fill(ds1, "kkk")
                    e.Node.Nodes.Clear()
                    Me.BindingContext(ds1, "kkk").Position = 0
                    Do
                        'If FindDotInStr(ds1.Tables("kkk").Rows(i).Item("Fee_Code")) = DotNum + 1 Then
                        aaa = e.Node.Nodes.Add(ds1.Tables("kkk").Rows(i).Item("Tally_Items_CHA"))
                        aaa.Tag = ds1.Tables("kkk").Rows(i).Item("Fee_Code")
                        ChildSqlAdapter = New SqlDataAdapter()
                        '判断下一级的节点是否有子节点，若有，添加一个假节点nothing，为了显示出“+”
                        ChildSqlAdapter.SelectCommand = New SqlCommand("select * from Code_Fee where Fee_Code like @Pdeptcode", sqlcon)
                        SelectDept = ds1.Tables("kkk").Rows(i).Item("Fee_Code") + "%"
                        DsChild = New DataSet("child")
                        ChildSqlAdapter.SelectCommand.Parameters.Add("@Pdeptcode", SqlDbType.VarChar, 15).Value = SelectDept
                        ChildSqlAdapter.Fill(DsChild, "childrecord")

                        If DsChild.Tables("childrecord").Rows.Count > 1 Then
                            bbb = aaa.Nodes.Add("nothing")
                        End If
                        DsChild.Tables("childrecord").Clear()
                        'End If
                        Me.BindingContext(ds1, "kkk").Position += 1
                        i = i + 1
                    Loop While i <= Me.BindingContext(ds1, "kkk").Count - 1
                    ds1.Tables("kkk").Clear()
                    sqlcon.Close()
                Else
                    sqladapter1.SelectCommand = New SqlCommand("select * from Code_Fee where Fee_Code like @Pdept order by Fee_Code", sqlcon)
                    SelectDept = e.Node.Tag + "%"
                    sqladapter1.SelectCommand.Parameters.Add("@Pdept", SqlDbType.VarChar, 15).Value = SelectDept

                ds1 = New DataSet("Code_Fee")
                sqladapter1.Fill(ds1, "kkk")
                e.Node.Nodes.Clear()
                Me.BindingContext(ds1, "kkk").Position = 0
                Do
                    If FindDotInStr(ds1.Tables("kkk").Rows(i).Item("Fee_Code")) = DotNum + 1 Then
                        aaa = e.Node.Nodes.Add(ds1.Tables("kkk").Rows(i).Item("Tally_Items_CHA"))
                        aaa.Tag = ds1.Tables("kkk").Rows(i).Item("Fee_Code")
                        ChildSqlAdapter = New SqlDataAdapter()
                        '判断下一级的节点是否有子节点，若有，添加一个假节点nothing，为了显示出“+”
                        ChildSqlAdapter.SelectCommand = New SqlCommand("select * from Code_Fee where Fee_Code like @Pdeptcode", sqlcon)
                        SelectDept = ds1.Tables("kkk").Rows(i).Item("Fee_Code") + "%"
                        DsChild = New DataSet("child")
                        ChildSqlAdapter.SelectCommand.Parameters.Add("@Pdeptcode", SqlDbType.VarChar, 15).Value = SelectDept
                        ChildSqlAdapter.Fill(DsChild, "childrecord")

                        If DsChild.Tables("childrecord").Rows.Count > 1 Then
                            bbb = aaa.Nodes.Add("nothing")
                        End If
                        DsChild.Tables("childrecord").Clear()
                    End If
                    Me.BindingContext(ds1, "kkk").Position += 1
                    i = i + 1
                Loop While i <= Me.BindingContext(ds1, "kkk").Count - 1
                ds1.Tables("kkk").Clear()
                    sqlcon.Close()
                End If
            Catch ex As SqlException
                MsgBox("sql exception:" & ex.Message)
            Catch ex As Exception
                MsgBox("general exception:" & ex.Message)
            End Try
        End If
    End Sub

    Private Sub tv_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tv.AfterSelect
        Dim i As Integer
        Dim nodex As New System.Windows.Forms.TreeNode()
        Dim ds As DataSet
        Dim code As String
        nodexkey = e.Node.Tag
        G_SelectCode = nodexkey
        G_SelectStr = e.Node.Text
    End Sub

    Private Sub tv_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tv.DoubleClick
        Me.Close()
    End Sub

End Class
