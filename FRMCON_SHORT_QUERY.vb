Imports TALLY.DBControl
Public Class FRMCON_SHORT_QUERY
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
    Friend WithEvents TxtDAMAGED_CONDITION As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtSEALNO As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TxtREMARK = New System.Windows.Forms.TextBox()
        Me.TxtDAMAGE_OVER_SHORT_TYPE = New System.Windows.Forms.TextBox()
        Me.CombDAMAGED_TYPE = New System.Windows.Forms.ComboBox()
        Me.CombDAMAGED_CODE = New System.Windows.Forms.ComboBox()
        Me.TxtCONTAINER_NO = New System.Windows.Forms.TextBox()
        Me.BTQUIT = New System.Windows.Forms.Button()
        Me.TxtDAMAGED_CONDITION = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSEALNO = New System.Windows.Forms.TextBox()
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
        Me.TxtREMARK.TabIndex = 130
        Me.TxtREMARK.Text = ""
        '
        'TxtDAMAGE_OVER_SHORT_TYPE
        '
        Me.TxtDAMAGE_OVER_SHORT_TYPE.Enabled = False
        Me.TxtDAMAGE_OVER_SHORT_TYPE.Location = New System.Drawing.Point(70, 58)
        Me.TxtDAMAGE_OVER_SHORT_TYPE.MaxLength = 20
        Me.TxtDAMAGE_OVER_SHORT_TYPE.Name = "TxtDAMAGE_OVER_SHORT_TYPE"
        Me.TxtDAMAGE_OVER_SHORT_TYPE.Size = New System.Drawing.Size(112, 21)
        Me.TxtDAMAGE_OVER_SHORT_TYPE.TabIndex = 129
        Me.TxtDAMAGE_OVER_SHORT_TYPE.Text = ""
        '
        'CombDAMAGED_TYPE
        '
        Me.CombDAMAGED_TYPE.Enabled = False
        Me.CombDAMAGED_TYPE.Location = New System.Drawing.Point(70, 108)
        Me.CombDAMAGED_TYPE.Name = "CombDAMAGED_TYPE"
        Me.CombDAMAGED_TYPE.Size = New System.Drawing.Size(112, 20)
        Me.CombDAMAGED_TYPE.TabIndex = 128
        '
        'CombDAMAGED_CODE
        '
        Me.CombDAMAGED_CODE.Enabled = False
        Me.CombDAMAGED_CODE.Location = New System.Drawing.Point(70, 84)
        Me.CombDAMAGED_CODE.Name = "CombDAMAGED_CODE"
        Me.CombDAMAGED_CODE.Size = New System.Drawing.Size(112, 20)
        Me.CombDAMAGED_CODE.TabIndex = 127
        '
        'TxtCONTAINER_NO
        '
        Me.TxtCONTAINER_NO.Enabled = False
        Me.TxtCONTAINER_NO.Location = New System.Drawing.Point(70, 10)
        Me.TxtCONTAINER_NO.MaxLength = 11
        Me.TxtCONTAINER_NO.Name = "TxtCONTAINER_NO"
        Me.TxtCONTAINER_NO.Size = New System.Drawing.Size(112, 21)
        Me.TxtCONTAINER_NO.TabIndex = 126
        Me.TxtCONTAINER_NO.Text = ""
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(204, 148)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 125
        Me.BTQUIT.Text = "取消"
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
        Me.TxtDAMAGED_CONDITION.TabIndex = 123
        Me.TxtDAMAGED_CONDITION.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(192, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 20)
        Me.Label7.TabIndex = 122
        Me.Label7.Text = "备注"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 20)
        Me.Label6.TabIndex = 121
        Me.Label6.Text = "溢短标志"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "铅封号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(192, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "残损情况"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "残损类型"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "残损位置"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 20)
        Me.Label5.TabIndex = 116
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
        Me.TxtSEALNO.TabIndex = 115
        Me.TxtSEALNO.Text = ""
        '
        'FRMCON_SHORT_QUERY
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(472, 193)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TxtREMARK, Me.TxtDAMAGE_OVER_SHORT_TYPE, Me.CombDAMAGED_TYPE, Me.CombDAMAGED_CODE, Me.TxtCONTAINER_NO, Me.BTQUIT, Me.TxtDAMAGED_CONDITION, Me.Label7, Me.Label6, Me.Label4, Me.Label3, Me.Label2, Me.Label1, Me.Label5, Me.TxtSEALNO})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMCON_SHORT_QUERY"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "集装箱残损溢短_查看"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FRMCON_SHORT_QUERY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
End Class
