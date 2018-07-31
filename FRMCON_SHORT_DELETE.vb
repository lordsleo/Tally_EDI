Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FRMCON_SHORT_DELETE
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dw As New DataView()
    Dim dsdamaged_code As New DataSet()
    Dim dsdamaged_type As New DataSet()
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
    Friend WithEvents TxtREMARK As System.Windows.Forms.TextBox
    Friend WithEvents TxtDAMAGE_OVER_SHORT_TYPE As System.Windows.Forms.TextBox
    Friend WithEvents CombDAMAGED_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents CombDAMAGED_CODE As System.Windows.Forms.ComboBox
    Friend WithEvents TxtCONTAINER_NO As System.Windows.Forms.TextBox
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents BTDELETE As System.Windows.Forms.Button
    Friend WithEvents TxtDAMAGED_CONDITION As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtSEALNO As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BTBLOK As System.Windows.Forms.Button
    Friend WithEvents BTBLQUIT As System.Windows.Forms.Button
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents Txtblno As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TxtREMARK = New System.Windows.Forms.TextBox()
        Me.TxtDAMAGE_OVER_SHORT_TYPE = New System.Windows.Forms.TextBox()
        Me.CombDAMAGED_TYPE = New System.Windows.Forms.ComboBox()
        Me.CombDAMAGED_CODE = New System.Windows.Forms.ComboBox()
        Me.TxtCONTAINER_NO = New System.Windows.Forms.TextBox()
        Me.BTQUIT = New System.Windows.Forms.Button()
        Me.BTDELETE = New System.Windows.Forms.Button()
        Me.TxtDAMAGED_CONDITION = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSEALNO = New System.Windows.Forms.TextBox()
        Me.GB = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txtblno = New System.Windows.Forms.TextBox()
        Me.BTBLOK = New System.Windows.Forms.Button()
        Me.BTBLQUIT = New System.Windows.Forms.Button()
        Me.GB.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtREMARK
        '
        Me.TxtREMARK.Enabled = False
        Me.TxtREMARK.Location = New System.Drawing.Point(254, 70)
        Me.TxtREMARK.MaxLength = 100
        Me.TxtREMARK.Multiline = True
        Me.TxtREMARK.Name = "TxtREMARK"
        Me.TxtREMARK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtREMARK.Size = New System.Drawing.Size(206, 56)
        Me.TxtREMARK.TabIndex = 114
        Me.TxtREMARK.Text = ""
        '
        'TxtDAMAGE_OVER_SHORT_TYPE
        '
        Me.TxtDAMAGE_OVER_SHORT_TYPE.Enabled = False
        Me.TxtDAMAGE_OVER_SHORT_TYPE.Location = New System.Drawing.Point(70, 58)
        Me.TxtDAMAGE_OVER_SHORT_TYPE.MaxLength = 20
        Me.TxtDAMAGE_OVER_SHORT_TYPE.Name = "TxtDAMAGE_OVER_SHORT_TYPE"
        Me.TxtDAMAGE_OVER_SHORT_TYPE.Size = New System.Drawing.Size(112, 21)
        Me.TxtDAMAGE_OVER_SHORT_TYPE.TabIndex = 113
        Me.TxtDAMAGE_OVER_SHORT_TYPE.Text = ""
        '
        'CombDAMAGED_TYPE
        '
        Me.CombDAMAGED_TYPE.Enabled = False
        Me.CombDAMAGED_TYPE.Location = New System.Drawing.Point(70, 108)
        Me.CombDAMAGED_TYPE.Name = "CombDAMAGED_TYPE"
        Me.CombDAMAGED_TYPE.Size = New System.Drawing.Size(112, 20)
        Me.CombDAMAGED_TYPE.TabIndex = 112
        '
        'CombDAMAGED_CODE
        '
        Me.CombDAMAGED_CODE.Enabled = False
        Me.CombDAMAGED_CODE.Location = New System.Drawing.Point(70, 84)
        Me.CombDAMAGED_CODE.Name = "CombDAMAGED_CODE"
        Me.CombDAMAGED_CODE.Size = New System.Drawing.Size(112, 20)
        Me.CombDAMAGED_CODE.TabIndex = 111
        '
        'TxtCONTAINER_NO
        '
        Me.TxtCONTAINER_NO.Enabled = False
        Me.TxtCONTAINER_NO.Location = New System.Drawing.Point(70, 10)
        Me.TxtCONTAINER_NO.MaxLength = 11
        Me.TxtCONTAINER_NO.Name = "TxtCONTAINER_NO"
        Me.TxtCONTAINER_NO.Size = New System.Drawing.Size(112, 21)
        Me.TxtCONTAINER_NO.TabIndex = 110
        Me.TxtCONTAINER_NO.Text = ""
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(240, 148)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 108
        Me.BTQUIT.Text = "取消"
        '
        'BTDELETE
        '
        Me.BTDELETE.Location = New System.Drawing.Point(168, 148)
        Me.BTDELETE.Name = "BTDELETE"
        Me.BTDELETE.Size = New System.Drawing.Size(65, 24)
        Me.BTDELETE.TabIndex = 107
        Me.BTDELETE.Text = "确认"
        '
        'TxtDAMAGED_CONDITION
        '
        Me.TxtDAMAGED_CONDITION.Enabled = False
        Me.TxtDAMAGED_CONDITION.Location = New System.Drawing.Point(254, 10)
        Me.TxtDAMAGED_CONDITION.MaxLength = 40
        Me.TxtDAMAGED_CONDITION.Multiline = True
        Me.TxtDAMAGED_CONDITION.Name = "TxtDAMAGED_CONDITION"
        Me.TxtDAMAGED_CONDITION.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDAMAGED_CONDITION.Size = New System.Drawing.Size(206, 56)
        Me.TxtDAMAGED_CONDITION.TabIndex = 106
        Me.TxtDAMAGED_CONDITION.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(192, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 20)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "备注"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "溢短标志"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "铅封号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(192, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 102
        Me.Label3.Text = "残损情况"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "残损类型"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "残损位置"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 20)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "箱号"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtSEALNO
        '
        Me.TxtSEALNO.Enabled = False
        Me.TxtSEALNO.Location = New System.Drawing.Point(70, 34)
        Me.TxtSEALNO.MaxLength = 20
        Me.TxtSEALNO.Name = "TxtSEALNO"
        Me.TxtSEALNO.Size = New System.Drawing.Size(112, 21)
        Me.TxtSEALNO.TabIndex = 98
        Me.TxtSEALNO.Text = ""
        '
        'GB
        '
        Me.GB.Controls.AddRange(New System.Windows.Forms.Control() {Me.BTBLQUIT, Me.BTBLOK, Me.Label8, Me.Txtblno})
        Me.GB.Location = New System.Drawing.Point(10, 10)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(450, 162)
        Me.GB.TabIndex = 115
        Me.GB.TabStop = False
        Me.GB.Text = "舱单数据录入"
        Me.GB.Visible = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(120, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 20)
        Me.Label8.TabIndex = 105
        Me.Label8.Text = "请输入提单号："
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Txtblno
        '
        Me.Txtblno.Location = New System.Drawing.Point(118, 86)
        Me.Txtblno.MaxLength = 20
        Me.Txtblno.Name = "Txtblno"
        Me.Txtblno.Size = New System.Drawing.Size(106, 21)
        Me.Txtblno.TabIndex = 104
        Me.Txtblno.Text = ""
        '
        'BTBLOK
        '
        Me.BTBLOK.Location = New System.Drawing.Point(258, 52)
        Me.BTBLOK.Name = "BTBLOK"
        Me.BTBLOK.Size = New System.Drawing.Size(65, 24)
        Me.BTBLOK.TabIndex = 108
        Me.BTBLOK.Text = "确认"
        '
        'BTBLQUIT
        '
        Me.BTBLQUIT.Location = New System.Drawing.Point(260, 86)
        Me.BTBLQUIT.Name = "BTBLQUIT"
        Me.BTBLQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTBLQUIT.TabIndex = 109
        Me.BTBLQUIT.Text = "取消"
        '
        'FRMCON_SHORT_DELETE
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(470, 185)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GB, Me.TxtREMARK, Me.TxtDAMAGE_OVER_SHORT_TYPE, Me.CombDAMAGED_TYPE, Me.CombDAMAGED_CODE, Me.TxtCONTAINER_NO, Me.BTQUIT, Me.BTDELETE, Me.TxtDAMAGED_CONDITION, Me.Label7, Me.Label6, Me.Label4, Me.Label3, Me.Label2, Me.Label1, Me.Label5, Me.TxtSEALNO})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMCON_SHORT_DELETE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "集装箱残损溢短_删除"
        Me.GB.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FRMCON_SHORT_DELETE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        dw = Getdata("select CODE_CON_POSITION, POSITION_CHA from View_ConPosition", dsdamaged_code)
        CombDAMAGED_CODE.DataSource = dsdamaged_code.Tables(0).DefaultView
        CombDAMAGED_CODE.DisplayMember = "POSITION_CHA"
        CombDAMAGED_CODE.ValueMember = "CODE_CON_POSITION"

        dw = Getdata("select CON_DAMAGED_TYPE,CON_DAMAGED_TYPE_CHA from con_damaged_type", dsdamaged_type)
        CombDAMAGED_TYPE.DataSource = dsdamaged_type.Tables(0).DefaultView
        CombDAMAGED_TYPE.DisplayMember = "CON_DAMAGED_TYPE_CHA"
        CombDAMAGED_TYPE.ValueMember = "CON_DAMAGED_TYPE"

        dw = Updatedata(sqlda, "select * from CON_SHORT where CON_SHORT_ID='" & ID & "'", ds)
        If ds.Tables(0).Rows.Count > 0 Then
            TxtCONTAINER_NO.Text = ds.Tables(0).Rows(0).Item("CONTAINER_NO")
            TxtDAMAGED_CONDITION.Text = ds.Tables(0).Rows(0).Item("DAMAGED_CONDITION")
            CombDAMAGED_CODE.SelectedValue = ds.Tables(0).Rows(0).Item("DAMAGED_CODE")
            TxtSEALNO.Text = ds.Tables(0).Rows(0).Item("SEALNO")
            TxtDAMAGE_OVER_SHORT_TYPE.Text = ds.Tables(0).Rows(0).Item("DAMAGE_OVER_SHORT_TYPE")
            CombDAMAGED_TYPE.SelectedValue = ds.Tables(0).Rows(0).Item("DAMAGED_TYPE")
            TxtREMARK.Text = ds.Tables(0).Rows(0).Item("REMARK")
        End If

        Exit Sub
Err:
        Resume Next
    End Sub
    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub

    Private Sub BTDELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTDELETE.Click
        Try
            If MsgBox("确认要删除吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                'Call INSERT()
                DELETE()
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DELETE()
        Try
            Call OperateHistory(G_DeptName, Now, G_User, "删除", "CON_SHORT", ID, "CON_SHORT_ID")
            ds.Tables(0).Rows(0).Delete()
            sqlda.Update(ds)
            Me.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub INSERT()
        Dim DSINSERT As New DataSet
        Dim LISTNO As Integer
        Dim FROM As String
        Dim DSLIST As New DataSet

        Try
            FROM = CType(Microsoft.VisualBasic.Right("0" & Hour(Now), 2), String) & CType(Microsoft.VisualBasic.Right("0" & Minute(Now), 2), String)

            If Len(Trim(TxtCONTAINER_NO.Text)) > 0 Then
                If Trim(TxtDAMAGE_OVER_SHORT_TYPE.Text) = "溢" Then
                    GB.Visible = True

                ElseIf Trim(TxtDAMAGE_OVER_SHORT_TYPE.Text) = "短" Then
                    dw = Getdata("SELECT MAX(NO) AS NO FROM CON_TALLY_LIST WHERE SHIP_ID='" & Ship_ID & "'  ", DSINSERT)
                    If DSINSERT.Tables(0).Rows.Count > 0 Then
                        LISTNO = CType(DSINSERT.Tables(0).Rows(0).Item("NO"), Integer) + 1
                        ExecSql("insert CON_TALLY_LIST(SHIP_ID,NO,DATE,TIME_FROM,TIME_TO,USER_NAME) select '" & Ship_ID & "','" & LISTNO & "','" & Now & " ','" & FROM & "','" & FROM & "','" & G_User & "' ")
                        dw = Getdata("SELECT MAX(CON_TALLY_LIST_ID) AS CON_TALLY_LIST_ID  FROM CON_TALLY_LIST WHERE SHIP_ID ='" & Ship_ID & "' AND NO='" & LISTNO & "'", DSLIST)
                        If DSLIST.Tables(0).Rows.Count > 0 Then
                            ExecSql("insert CON_TALLY_DETAIL(CON_TALLY_LIST_ID,CONTAINER_NO) select '" & DSLIST.Tables(0).Rows(0).Item("CON_TALLY_LIST_ID") & "','" & Trim(TxtCONTAINER_NO.Text) & "' ")
                            Call DELETE()
                        End If
                    Else
                        LISTNO = "1"
                        ExecSql("insert CON_TALLY_LIST(SHIP_ID,NO,DATE,TIME_FROM,TIME_TO,USER_NAME) select '" & Ship_ID & "','" & LISTNO & "','" & Now & " ','" & FROM & "','" & FROM & "','" & G_User & "' ")
                        dw = Getdata("SELECT MAX(CON_TALLY_LIST_ID)  AS CON_TALLY_LIST_ID FROM CON_TALLY_LIST WHERE SHIP_ID ='" & Ship_ID & "' AND NO='" & LISTNO & "'", DSLIST)
                        If DSLIST.Tables(0).Rows.Count > 0 Then
                            ExecSql("insert CON_TALLY_DETAIL(CON_TALLY_LIST_ID,CONTAINER_NO) select '" & DSLIST.Tables(0).Rows(0).Item("CON_TALLY_LIST_ID") & "','" & Trim(TxtCONTAINER_NO.Text) & "' ")
                            Call DELETE()
                        End If
                    End If

                End If
            Else
                MsgBox("箱号格式不正确，不能输入理箱单或者舱单！")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTBLOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTBLOK.Click
        Try
            If Len(Trim(Txtblno.Text)) > 0 Then
                ExecSql("insert CON_HATCH_LIST(SHIP_ID,BLNO,MARK,USER_NAME) select '" & Ship_ID & "','" & Trim(Txtblno.Text) & "','N/M','" & G_User & "' ")
                ExecSql("insert CON_HATCH_RECORD(SHIP_ID,CONTAINER_NO,USER_NAME) select '" & Ship_ID & "','" & Trim(TxtCONTAINER_NO.Text) & "','" & G_User & "' ")
                ExecSql("insert CON_HATCH_CARGO(SHIP_ID,CONTAINER_NO,BLNO,mark,USER_NAME) select '" & Ship_ID & "','" & Trim(TxtCONTAINER_NO.Text) & "','" & Trim(Txtblno.Text) & "','N/M','" & G_User & "' ")
                Call DELETE()
            Else
                MsgBox("请输入提单号！")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTBLQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTBLQUIT.Click
        Txtblno.Text = ""
        GB.Visible = False
    End Sub
End Class
