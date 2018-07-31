Imports TALLY.DBControl
Public Class FrmConLoadBuildConsign
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCHI_VESSEL As System.Windows.Forms.TextBox
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents txtBLNO As System.Windows.Forms.TextBox
    Friend WithEvents txtMARK As System.Windows.Forms.TextBox
    Friend WithEvents cbCODE_CON_CONSIGN As System.Windows.Forms.ComboBox
    Friend WithEvents btn_enter As System.Windows.Forms.Button
    Friend WithEvents btn_cancle As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_work_place As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCHI_VESSEL = New System.Windows.Forms.TextBox()
        Me.txtVoyage = New System.Windows.Forms.TextBox()
        Me.txtBLNO = New System.Windows.Forms.TextBox()
        Me.txtMARK = New System.Windows.Forms.TextBox()
        Me.cbCODE_CON_CONSIGN = New System.Windows.Forms.ComboBox()
        Me.btn_enter = New System.Windows.Forms.Button()
        Me.btn_cancle = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_work_place = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(20, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " 船名"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(20, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "航次"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(202, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "MARK"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(202, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "提单号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(202, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "委托人"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCHI_VESSEL
        '
        Me.txtCHI_VESSEL.Location = New System.Drawing.Point(74, 11)
        Me.txtCHI_VESSEL.Name = "txtCHI_VESSEL"
        Me.txtCHI_VESSEL.ReadOnly = True
        Me.txtCHI_VESSEL.TabIndex = 1
        Me.txtCHI_VESSEL.Text = ""
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(74, 52)
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.ReadOnly = True
        Me.txtVoyage.TabIndex = 1
        Me.txtVoyage.Text = ""
        '
        'txtBLNO
        '
        Me.txtBLNO.Location = New System.Drawing.Point(254, 11)
        Me.txtBLNO.Name = "txtBLNO"
        Me.txtBLNO.ReadOnly = True
        Me.txtBLNO.TabIndex = 1
        Me.txtBLNO.Text = ""
        '
        'txtMARK
        '
        Me.txtMARK.Location = New System.Drawing.Point(254, 52)
        Me.txtMARK.Name = "txtMARK"
        Me.txtMARK.ReadOnly = True
        Me.txtMARK.TabIndex = 1
        Me.txtMARK.Text = ""
        '
        'cbCODE_CON_CONSIGN
        '
        Me.cbCODE_CON_CONSIGN.Location = New System.Drawing.Point(254, 93)
        Me.cbCODE_CON_CONSIGN.Name = "cbCODE_CON_CONSIGN"
        Me.cbCODE_CON_CONSIGN.Size = New System.Drawing.Size(100, 20)
        Me.cbCODE_CON_CONSIGN.TabIndex = 2
        '
        'btn_enter
        '
        Me.btn_enter.Location = New System.Drawing.Point(115, 144)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(65, 24)
        Me.btn_enter.TabIndex = 3
        Me.btn_enter.Text = "确定"
        '
        'btn_cancle
        '
        Me.btn_cancle.Location = New System.Drawing.Point(195, 144)
        Me.btn_cancle.Name = "btn_cancle"
        Me.btn_cancle.Size = New System.Drawing.Size(65, 24)
        Me.btn_cancle.TabIndex = 3
        Me.btn_cancle.Text = "取消"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(20, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "场站"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_work_place
        '
        Me.txt_work_place.Location = New System.Drawing.Point(74, 93)
        Me.txt_work_place.Name = "txt_work_place"
        Me.txt_work_place.ReadOnly = True
        Me.txt_work_place.TabIndex = 1
        Me.txt_work_place.Text = ""
        '
        'FrmConLoadBuildConsign
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(374, 217)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btn_enter, Me.cbCODE_CON_CONSIGN, Me.txtCHI_VESSEL, Me.Label1, Me.Label2, Me.Label3, Me.Label4, Me.Label6, Me.txtVoyage, Me.txtBLNO, Me.txtMARK, Me.btn_cancle, Me.Label5, Me.txt_work_place})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConLoadBuildConsign"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "修改委托人"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dsConsign As New DataSet()
    Dim ds_work_place As New DataSet()
    Private Sub FrmConLoadBuildConsign_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '委托人 
        Getdata("select code_ship_agent,shipagent_cha from code_ship_agent", dsConsign)
        Me.cbCODE_CON_CONSIGN.DataSource = dsConsign.Tables(0).DefaultView
        Me.cbCODE_CON_CONSIGN.DisplayMember = "shipagent_cha"
        Me.cbCODE_CON_CONSIGN.ValueMember = "code_ship_agent"
        '场站
        If Getdata("select code_yard_name from code_yard,con_load_tally where code_yard.code_yard_id=con_load_tally.work_place and  con_load_tally.con_load_tally_id=" & ID, ds_work_place).Count > 0 Then
            Me.txt_work_place.Text = ds_work_place.Tables(0).Rows(0).Item("code_yard_name")
        End If

        Updatedata(sqlda, "select * from con_load_tally where con_load_tally_id=" & ID, ds)
        If ds.Tables(0).Rows.Count > 0 Then
            On Error GoTo rr
            Me.txtCHI_VESSEL.Text = ds.Tables(0).Rows(0).Item("CHI_VESSEL")
            Me.txtVoyage.Text = ds.Tables(0).Rows(0).Item("Voyage")
            Me.txtBLNO.Text = ds.Tables(0).Rows(0).Item("BLNO")
            Me.txtMARK.Text = ds.Tables(0).Rows(0).Item("mark")
            Me.cbCODE_CON_CONSIGN.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_CON_CONSIGN")

rr:
            Resume Next
        End If
    End Sub

    Private Sub btn_enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enter.Click
        ds.Tables(0).Rows(0).Item("code_con_consign") = Me.cbCODE_CON_CONSIGN.SelectedValue
        sqlda.Update(ds)
        Me.Close()
    End Sub

    Private Sub btn_cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancle.Click
        Me.Close()
    End Sub
End Class
