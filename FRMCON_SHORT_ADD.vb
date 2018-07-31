Imports TALLY.DBControl
Public Class FRMCON_SHORT_ADD
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dw As New DataView()
    Dim dsdamaged_code As New DataSet()
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CombDAMAGED_TYPE1 As System.Windows.Forms.ComboBox
    Dim dsdamaged_type As New DataSet()
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbcsfw As System.Windows.Forms.ComboBox
    Dim dsdamaged_code1 As New DataSet()
    Dim dsdamaged_type1 As New DataSet()

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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtDAMAGED_CONDITION As System.Windows.Forms.TextBox
    Friend WithEvents BTADD As System.Windows.Forms.Button
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents BTOK As System.Windows.Forms.Button
    Friend WithEvents TxtCONTAINER_NO As System.Windows.Forms.TextBox
    Friend WithEvents TxtSEALNO As System.Windows.Forms.TextBox
    Friend WithEvents CombDAMAGED_CODE As System.Windows.Forms.ComboBox
    Friend WithEvents CombDAMAGED_TYPE As System.Windows.Forms.ComboBox
    Friend WithEvents TxtDAMAGE_OVER_SHORT_TYPE As System.Windows.Forms.TextBox
    Friend WithEvents TxtREMARK As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TxtSEALNO = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtDAMAGED_CONDITION = New System.Windows.Forms.TextBox
        Me.BTADD = New System.Windows.Forms.Button
        Me.BTQUIT = New System.Windows.Forms.Button
        Me.BTOK = New System.Windows.Forms.Button
        Me.TxtCONTAINER_NO = New System.Windows.Forms.TextBox
        Me.CombDAMAGED_CODE = New System.Windows.Forms.ComboBox
        Me.CombDAMAGED_TYPE = New System.Windows.Forms.ComboBox
        Me.TxtDAMAGE_OVER_SHORT_TYPE = New System.Windows.Forms.TextBox
        Me.TxtREMARK = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.CombDAMAGED_TYPE1 = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbcsfw = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'TxtSEALNO
        '
        Me.TxtSEALNO.Location = New System.Drawing.Point(328, 11)
        Me.TxtSEALNO.MaxLength = 20
        Me.TxtSEALNO.Name = "TxtSEALNO"
        Me.TxtSEALNO.Size = New System.Drawing.Size(104, 21)
        Me.TxtSEALNO.TabIndex = 80
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 20)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "箱号"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "残损位置"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "残损类型"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "残损情况"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(256, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "铅封号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(256, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "溢短标志"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 242)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 20)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "备注"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDAMAGED_CONDITION
        '
        Me.TxtDAMAGED_CONDITION.Location = New System.Drawing.Point(72, 154)
        Me.TxtDAMAGED_CONDITION.MaxLength = 200
        Me.TxtDAMAGED_CONDITION.Multiline = True
        Me.TxtDAMAGED_CONDITION.Name = "TxtDAMAGED_CONDITION"
        Me.TxtDAMAGED_CONDITION.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtDAMAGED_CONDITION.Size = New System.Drawing.Size(432, 56)
        Me.TxtDAMAGED_CONDITION.TabIndex = 89
        '
        'BTADD
        '
        Me.BTADD.Location = New System.Drawing.Point(153, 298)
        Me.BTADD.Name = "BTADD"
        Me.BTADD.Size = New System.Drawing.Size(65, 24)
        Me.BTADD.TabIndex = 92
        Me.BTADD.Text = "清空"
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(297, 298)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 91
        Me.BTQUIT.Text = "取消"
        '
        'BTOK
        '
        Me.BTOK.Location = New System.Drawing.Point(225, 298)
        Me.BTOK.Name = "BTOK"
        Me.BTOK.Size = New System.Drawing.Size(65, 24)
        Me.BTOK.TabIndex = 90
        Me.BTOK.Text = "确认"
        '
        'TxtCONTAINER_NO
        '
        Me.TxtCONTAINER_NO.Location = New System.Drawing.Point(72, 11)
        Me.TxtCONTAINER_NO.MaxLength = 11
        Me.TxtCONTAINER_NO.Name = "TxtCONTAINER_NO"
        Me.TxtCONTAINER_NO.Size = New System.Drawing.Size(112, 21)
        Me.TxtCONTAINER_NO.TabIndex = 93
        '
        'CombDAMAGED_CODE
        '
        Me.CombDAMAGED_CODE.Location = New System.Drawing.Point(72, 48)
        Me.CombDAMAGED_CODE.Name = "CombDAMAGED_CODE"
        Me.CombDAMAGED_CODE.Size = New System.Drawing.Size(112, 20)
        Me.CombDAMAGED_CODE.TabIndex = 94
        '
        'CombDAMAGED_TYPE
        '
        Me.CombDAMAGED_TYPE.Location = New System.Drawing.Point(72, 84)
        Me.CombDAMAGED_TYPE.Name = "CombDAMAGED_TYPE"
        Me.CombDAMAGED_TYPE.Size = New System.Drawing.Size(112, 20)
        Me.CombDAMAGED_TYPE.TabIndex = 95
        '
        'TxtDAMAGE_OVER_SHORT_TYPE
        '
        Me.TxtDAMAGE_OVER_SHORT_TYPE.Location = New System.Drawing.Point(328, 47)
        Me.TxtDAMAGE_OVER_SHORT_TYPE.MaxLength = 20
        Me.TxtDAMAGE_OVER_SHORT_TYPE.Name = "TxtDAMAGE_OVER_SHORT_TYPE"
        Me.TxtDAMAGE_OVER_SHORT_TYPE.Size = New System.Drawing.Size(104, 21)
        Me.TxtDAMAGE_OVER_SHORT_TYPE.TabIndex = 96
        '
        'TxtREMARK
        '
        Me.TxtREMARK.Location = New System.Drawing.Point(72, 226)
        Me.TxtREMARK.MaxLength = 100
        Me.TxtREMARK.Multiline = True
        Me.TxtREMARK.Name = "TxtREMARK"
        Me.TxtREMARK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtREMARK.Size = New System.Drawing.Size(432, 56)
        Me.TxtREMARK.TabIndex = 97
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(225, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 20)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "海关残损类型"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CombDAMAGED_TYPE1
        '
        Me.CombDAMAGED_TYPE1.Location = New System.Drawing.Point(328, 85)
        Me.CombDAMAGED_TYPE1.Name = "CombDAMAGED_TYPE1"
        Me.CombDAMAGED_TYPE1.Size = New System.Drawing.Size(104, 20)
        Me.CombDAMAGED_TYPE1.TabIndex = 95
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(225, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 20)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "海关残损位置"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbcsfw
        '
        Me.cmbcsfw.Location = New System.Drawing.Point(328, 120)
        Me.cmbcsfw.Name = "cmbcsfw"
        Me.cmbcsfw.Size = New System.Drawing.Size(104, 20)
        Me.cmbcsfw.TabIndex = 95
        '
        'FRMCON_SHORT_ADD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(514, 340)
        Me.Controls.Add(Me.TxtREMARK)
        Me.Controls.Add(Me.TxtDAMAGE_OVER_SHORT_TYPE)
        Me.Controls.Add(Me.cmbcsfw)
        Me.Controls.Add(Me.CombDAMAGED_TYPE1)
        Me.Controls.Add(Me.CombDAMAGED_TYPE)
        Me.Controls.Add(Me.CombDAMAGED_CODE)
        Me.Controls.Add(Me.TxtCONTAINER_NO)
        Me.Controls.Add(Me.BTADD)
        Me.Controls.Add(Me.BTQUIT)
        Me.Controls.Add(Me.BTOK)
        Me.Controls.Add(Me.TxtDAMAGED_CONDITION)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtSEALNO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMCON_SHORT_ADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "集装箱残损溢短_增加"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub FRMCON_SHORT_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        'dw = Getdata("select CODE_DAMAGE,NAME_DAMAGE from damage", dsdamaged_code)
        dw = Getdata("select CODE_CON_POSITION, POSITION_CHA from View_ConPosition", dsdamaged_code)
        CombDAMAGED_CODE.DataSource = dsdamaged_code.Tables(0).DefaultView
        CombDAMAGED_CODE.DisplayMember = "POSITION_CHA"
        CombDAMAGED_CODE.ValueMember = "CODE_CON_POSITION"

        dw = Getdata("select CON_DAMAGED_TYPE,CON_DAMAGED_TYPE_CHA from con_damaged_type", dsdamaged_type)
        CombDAMAGED_TYPE.DataSource = dsdamaged_type.Tables(0).DefaultView
        CombDAMAGED_TYPE.DisplayMember = "CON_DAMAGED_TYPE_CHA"
        CombDAMAGED_TYPE.ValueMember = "CON_DAMAGED_TYPE"

        dw = Getdata("select csdm_chi,csdm_code from hg_csdm order by csdm_chi", dsdamaged_type1)
        CombDAMAGED_TYPE1.DataSource = dsdamaged_type1.Tables(0).DefaultView
        CombDAMAGED_TYPE1.DisplayMember = "csdm_chi"
        CombDAMAGED_TYPE1.ValueMember = "csdm_code"

        dw = Getdata("select csfw_code, csfw_chi from hg_csfw", dsdamaged_code1)
        cmbcsfw.DataSource = dsdamaged_code1.Tables(0).DefaultView
        cmbcsfw.DisplayMember = "csfw_chi"
        cmbcsfw.ValueMember = "csfw_code"

        dw = Updatedata(sqlda, "select * from CON_SHORT where CON_SHORT_ID='" & ID & "'", ds)
        If ds.Tables(0).Rows.Count > 0 Then
            TxtCONTAINER_NO.Text = ds.Tables(0).Rows(0).Item("CONTAINER_NO")
            TxtDAMAGED_CONDITION.Text = ds.Tables(0).Rows(0).Item("DAMAGED_CONDITION")
            CombDAMAGED_CODE.SelectedValue = ds.Tables(0).Rows(0).Item("DAMAGED_CODE")
            TxtSEALNO.Text = ds.Tables(0).Rows(0).Item("SEALNO")
            'TxtDAMAGE_OVER_SHORT_TYPE.Text = ds.Tables(0).Rows(0).Item("DAMAGE_OVER_SHORT_TYPE")
            CombDAMAGED_TYPE.SelectedValue = ds.Tables(0).Rows(0).Item("DAMAGED_TYPE")
            TxtREMARK.Text = ds.Tables(0).Rows(0).Item("REMARK")
        End If

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub BTADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTADD.Click
        TxtCONTAINER_NO.Text = ""
        TxtDAMAGED_CONDITION.Text = ""
        CombDAMAGED_CODE.SelectedValue = "00"
        TxtSEALNO.Text = ""
        TxtDAMAGE_OVER_SHORT_TYPE.Text = ""
        CombDAMAGED_TYPE.SelectedValue = "00"
        TxtREMARK.Text = ""
    End Sub

    Private Sub BTOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTOK.Click
        Try
            If Len(Trim(TxtCONTAINER_NO.Text)) > 0 Then
                Dim dskey As New DataSet()
                'dw = Getdata("select * from CARGO_DAMAGED_List where  blno='" & Trim(TxtBLNO.Text) & "' and mark='" & Trim(TxtMARK.Text) & "' and ship_id='" & Ship_ID & "' and CODE_GOODS='" & CombCODE_GOODS.SelectedValue & "' and DAMAGED_CONDITION='" & TxtDAMAGED_CONDITION.Text & "' and CODE_PACK='" & CombCODE_PACK.SelectedValue & "' and DAMAGED_AMOUNT='" & TxtDAMAGED_AMOUNT.Text & "' ", dskey)
                '        If dskey.Tables(0).Rows.Count > 0 Then
                '            MsgBox("此残损单在数据库中已存在！")
                '        Else
                Dim row As DataRow
                row = ds.Tables(0).NewRow
                row("SHIP_ID") = Trim(Ship_ID)
                row("CONTAINER_NO") = Trim(TxtCONTAINER_NO.Text)
                row("DAMAGED_CONDITION") = Trim(TxtDAMAGED_CONDITION.Text)
                row("DAMAGED_CODE") = IIf(Len(Trim(CombDAMAGED_CODE.SelectedValue)) > 0, Trim(CombDAMAGED_CODE.SelectedValue), "00")
                row("SEALNO") = IIf(Len(Trim(TxtSEALNO.Text)) > 0, Trim(TxtSEALNO.Text), "")
                row("DAMAGE_OVER_SHORT_TYPE") = Trim(TxtDAMAGE_OVER_SHORT_TYPE.Text)
                row("DAMAGED_TYPE") = IIf(Len(Trim(CombDAMAGED_TYPE.SelectedValue)) > 0, Trim(CombDAMAGED_TYPE.SelectedValue), "00")
                row("REMARK") = IIf(Len(Trim(TxtREMARK.Text)) > 0, Trim(TxtREMARK.Text), "")
                row("csdm") = IIf(Len(Trim(CombDAMAGED_TYPE1.SelectedValue)) > 0, Trim(CombDAMAGED_TYPE1.SelectedValue), "00")
                row("csfw") = IIf(Len(Trim(cmbcsfw.SelectedValue)) > 0, Trim(cmbcsfw.SelectedValue), "00")
                row("USER_NAME") = Trim(G_User)

                ds.Tables(0).Rows.Add(row)
                sqlda.Update(ds)
                Call BTQUIT_Click(sender, e)
                'End If

            Else
                MsgBox("箱号不能为空！")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub
    Private Sub TxtCONTAINER_NO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCONTAINER_NO.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtSEALNO.Focus()
        End If
    End Sub

    Private Sub TxtSEALNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSEALNO.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtDAMAGE_OVER_SHORT_TYPE.Focus()
        End If
    End Sub
    Private Sub TxtDAMAGE_OVER_SHORT_TYPE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDAMAGE_OVER_SHORT_TYPE.KeyPress
        If e.KeyChar = Chr(13) Then
            CombDAMAGED_CODE.Focus()
        End If
    End Sub
    Private Sub CombDAMAGED_CODE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombDAMAGED_CODE.KeyPress
        If e.KeyChar = Chr(13) Then
            CombDAMAGED_TYPE.Focus()
        End If
    End Sub
    Private Sub CombDAMAGED_TYPE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombDAMAGED_TYPE.KeyPress, CombDAMAGED_TYPE1.KeyPress, cmbcsfw.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtDAMAGED_CONDITION.Focus()
        End If
    End Sub
    Private Sub TxtDAMAGED_CONDITION_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDAMAGED_CONDITION.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtREMARK.Focus()
        End If
    End Sub
    Private Sub TxtREMARK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtREMARK.KeyPress
        If e.KeyChar = Chr(13) Then
            BTOK.Focus()
        End If
    End Sub
End Class
