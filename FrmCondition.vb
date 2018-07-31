Imports TALLY.DBControl
Public Class FrmCondition
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
    Friend WithEvents txt_cheap_rate As System.Windows.Forms.TextBox
    Friend WithEvents ckb_holiday As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_tally_result As System.Windows.Forms.Button
    Friend WithEvents btn_generate As System.Windows.Forms.Button
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dt_LISTDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_PREPAREDMAN As System.Windows.Forms.TextBox
    Friend WithEvents btn_enter As System.Windows.Forms.Button
    Friend WithEvents txt_rude_fee As System.Windows.Forms.TextBox
    Friend WithEvents txt_cheap_fee As System.Windows.Forms.TextBox
    Friend WithEvents ckb_basic_fee As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_basic_fee As System.Windows.Forms.TextBox
    Friend WithEvents gpb_cargo_fee As System.Windows.Forms.GroupBox
    Friend WithEvents ckb_single_fee As System.Windows.Forms.CheckBox
    Friend WithEvents ckb_triffice_fee As System.Windows.Forms.CheckBox
    Friend WithEvents ckb_wait_fee As System.Windows.Forms.CheckBox
    Friend WithEvents ckb_SEAL_EXAM_fee As System.Windows.Forms.CheckBox
    Friend WithEvents gpb_con_fee As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_cargo_fee As System.Windows.Forms.RadioButton
    Friend WithEvents rb_con_fee As System.Windows.Forms.RadioButton
    Friend WithEvents ckb_con_wait_fee As System.Windows.Forms.CheckBox
    Friend WithEvents ckb_con_basic_fee As System.Windows.Forms.CheckBox
    Friend WithEvents txt_con_cheap_rate As System.Windows.Forms.TextBox
    Friend WithEvents ckb_con_triffice_fee As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ckb_con_holiday As System.Windows.Forms.CheckBox
    Friend WithEvents txt_con_basic_fee As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_con_cheap_fee As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ckb_con_SEAL_EXAM_fee As System.Windows.Forms.CheckBox
    Friend WithEvents ckb_con_single_fee As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cb_agent As System.Windows.Forms.ComboBox
    Friend WithEvents txt_con_rude_fee As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cb_check As System.Windows.Forms.ComboBox
    Friend WithEvents cb_INCHARGER As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ckb_basic_fee = New System.Windows.Forms.CheckBox()
        Me.txt_cheap_rate = New System.Windows.Forms.TextBox()
        Me.ckb_holiday = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_tally_result = New System.Windows.Forms.Button()
        Me.btn_generate = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dt_LISTDATE = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_PREPAREDMAN = New System.Windows.Forms.TextBox()
        Me.gpb_cargo_fee = New System.Windows.Forms.GroupBox()
        Me.ckb_SEAL_EXAM_fee = New System.Windows.Forms.CheckBox()
        Me.ckb_wait_fee = New System.Windows.Forms.CheckBox()
        Me.ckb_triffice_fee = New System.Windows.Forms.CheckBox()
        Me.ckb_single_fee = New System.Windows.Forms.CheckBox()
        Me.txt_basic_fee = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_cheap_fee = New System.Windows.Forms.TextBox()
        Me.txt_rude_fee = New System.Windows.Forms.TextBox()
        Me.btn_enter = New System.Windows.Forms.Button()
        Me.gpb_con_fee = New System.Windows.Forms.GroupBox()
        Me.cb_agent = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ckb_con_basic_fee = New System.Windows.Forms.CheckBox()
        Me.txt_con_cheap_rate = New System.Windows.Forms.TextBox()
        Me.ckb_con_triffice_fee = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ckb_con_holiday = New System.Windows.Forms.CheckBox()
        Me.txt_con_basic_fee = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_con_cheap_fee = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ckb_con_single_fee = New System.Windows.Forms.CheckBox()
        Me.txt_con_rude_fee = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ckb_con_wait_fee = New System.Windows.Forms.CheckBox()
        Me.ckb_con_SEAL_EXAM_fee = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rb_con_fee = New System.Windows.Forms.RadioButton()
        Me.rb_cargo_fee = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cb_check = New System.Windows.Forms.ComboBox()
        Me.cb_INCHARGER = New System.Windows.Forms.ComboBox()
        Me.gpb_cargo_fee.SuspendLayout()
        Me.gpb_con_fee.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(42, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "无优惠无豁免理货费："
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(42, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "优惠率："
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ckb_basic_fee
        '
        Me.ckb_basic_fee.Location = New System.Drawing.Point(42, 138)
        Me.ckb_basic_fee.Name = "ckb_basic_fee"
        Me.ckb_basic_fee.Size = New System.Drawing.Size(128, 23)
        Me.ckb_basic_fee.TabIndex = 3
        Me.ckb_basic_fee.Text = "收起码理货费"
        '
        'txt_cheap_rate
        '
        Me.txt_cheap_rate.Location = New System.Drawing.Point(100, 111)
        Me.txt_cheap_rate.Name = "txt_cheap_rate"
        Me.txt_cheap_rate.Size = New System.Drawing.Size(70, 21)
        Me.txt_cheap_rate.TabIndex = 4
        Me.txt_cheap_rate.Text = ""
        '
        'ckb_holiday
        '
        Me.ckb_holiday.Location = New System.Drawing.Point(172, 109)
        Me.ckb_holiday.Name = "ckb_holiday"
        Me.ckb_holiday.Size = New System.Drawing.Size(110, 24)
        Me.ckb_holiday.TabIndex = 5
        Me.ckb_holiday.Text = "节假日夜班豁免"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(42, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "优惠总费用："
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_tally_result
        '
        Me.btn_tally_result.Location = New System.Drawing.Point(114, 226)
        Me.btn_tally_result.Name = "btn_tally_result"
        Me.btn_tally_result.Size = New System.Drawing.Size(96, 24)
        Me.btn_tally_result.TabIndex = 8
        Me.btn_tally_result.Text = "修改计费货类"
        '
        'btn_generate
        '
        Me.btn_generate.Location = New System.Drawing.Point(245, 388)
        Me.btn_generate.Name = "btn_generate"
        Me.btn_generate.Size = New System.Drawing.Size(65, 24)
        Me.btn_generate.TabIndex = 9
        Me.btn_generate.Text = "生成"
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(375, 388)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(65, 24)
        Me.btn_exit.TabIndex = 10
        Me.btn_exit.Text = "退出"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(17, 354)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "制单日期"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dt_LISTDATE
        '
        Me.dt_LISTDATE.CustomFormat = "yyyy/MM/dd"
        Me.dt_LISTDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_LISTDATE.Location = New System.Drawing.Point(75, 355)
        Me.dt_LISTDATE.Name = "dt_LISTDATE"
        Me.dt_LISTDATE.Size = New System.Drawing.Size(100, 21)
        Me.dt_LISTDATE.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(181, 354)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 23)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "主管人"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(510, 354)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 23)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "制单人"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_PREPAREDMAN
        '
        Me.txt_PREPAREDMAN.Enabled = False
        Me.txt_PREPAREDMAN.Location = New System.Drawing.Point(568, 355)
        Me.txt_PREPAREDMAN.Name = "txt_PREPAREDMAN"
        Me.txt_PREPAREDMAN.TabIndex = 18
        Me.txt_PREPAREDMAN.Text = ""
        '
        'gpb_cargo_fee
        '
        Me.gpb_cargo_fee.Controls.AddRange(New System.Windows.Forms.Control() {Me.ckb_SEAL_EXAM_fee, Me.ckb_wait_fee, Me.ckb_triffice_fee, Me.ckb_single_fee, Me.txt_basic_fee, Me.Label10, Me.txt_cheap_fee, Me.txt_rude_fee, Me.Label2, Me.Label1, Me.ckb_basic_fee, Me.ckb_holiday, Me.Label3, Me.txt_cheap_rate, Me.btn_tally_result})
        Me.gpb_cargo_fee.Enabled = False
        Me.gpb_cargo_fee.Location = New System.Drawing.Point(18, 78)
        Me.gpb_cargo_fee.Name = "gpb_cargo_fee"
        Me.gpb_cargo_fee.Size = New System.Drawing.Size(325, 262)
        Me.gpb_cargo_fee.TabIndex = 24
        Me.gpb_cargo_fee.TabStop = False
        Me.gpb_cargo_fee.Text = "件杂货收费"
        '
        'ckb_SEAL_EXAM_fee
        '
        Me.ckb_SEAL_EXAM_fee.Checked = True
        Me.ckb_SEAL_EXAM_fee.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckb_SEAL_EXAM_fee.Location = New System.Drawing.Point(172, 81)
        Me.ckb_SEAL_EXAM_fee.Name = "ckb_SEAL_EXAM_fee"
        Me.ckb_SEAL_EXAM_fee.Size = New System.Drawing.Size(110, 24)
        Me.ckb_SEAL_EXAM_fee.TabIndex = 31
        Me.ckb_SEAL_EXAM_fee.Text = "施封费"
        '
        'ckb_wait_fee
        '
        Me.ckb_wait_fee.Checked = True
        Me.ckb_wait_fee.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckb_wait_fee.Location = New System.Drawing.Point(42, 82)
        Me.ckb_wait_fee.Name = "ckb_wait_fee"
        Me.ckb_wait_fee.Size = New System.Drawing.Size(128, 23)
        Me.ckb_wait_fee.TabIndex = 30
        Me.ckb_wait_fee.Text = "待时费"
        '
        'ckb_triffice_fee
        '
        Me.ckb_triffice_fee.Checked = True
        Me.ckb_triffice_fee.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckb_triffice_fee.Location = New System.Drawing.Point(172, 53)
        Me.ckb_triffice_fee.Name = "ckb_triffice_fee"
        Me.ckb_triffice_fee.Size = New System.Drawing.Size(110, 24)
        Me.ckb_triffice_fee.TabIndex = 29
        Me.ckb_triffice_fee.Text = "交通费"
        '
        'ckb_single_fee
        '
        Me.ckb_single_fee.Checked = True
        Me.ckb_single_fee.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckb_single_fee.Location = New System.Drawing.Point(42, 54)
        Me.ckb_single_fee.Name = "ckb_single_fee"
        Me.ckb_single_fee.Size = New System.Drawing.Size(128, 23)
        Me.ckb_single_fee.TabIndex = 28
        Me.ckb_single_fee.Text = "单正费"
        '
        'txt_basic_fee
        '
        Me.txt_basic_fee.Location = New System.Drawing.Point(172, 167)
        Me.txt_basic_fee.Name = "txt_basic_fee"
        Me.txt_basic_fee.ReadOnly = True
        Me.txt_basic_fee.Size = New System.Drawing.Size(110, 21)
        Me.txt_basic_fee.TabIndex = 27
        Me.txt_basic_fee.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(42, 166)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 23)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "起码理货费："
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_cheap_fee
        '
        Me.txt_cheap_fee.Location = New System.Drawing.Point(172, 195)
        Me.txt_cheap_fee.Name = "txt_cheap_fee"
        Me.txt_cheap_fee.ReadOnly = True
        Me.txt_cheap_fee.Size = New System.Drawing.Size(110, 21)
        Me.txt_cheap_fee.TabIndex = 25
        Me.txt_cheap_fee.Text = ""
        '
        'txt_rude_fee
        '
        Me.txt_rude_fee.Location = New System.Drawing.Point(172, 27)
        Me.txt_rude_fee.Name = "txt_rude_fee"
        Me.txt_rude_fee.ReadOnly = True
        Me.txt_rude_fee.Size = New System.Drawing.Size(110, 21)
        Me.txt_rude_fee.TabIndex = 24
        Me.txt_rude_fee.Text = ""
        '
        'btn_enter
        '
        Me.btn_enter.Location = New System.Drawing.Point(310, 388)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(65, 24)
        Me.btn_enter.TabIndex = 25
        Me.btn_enter.Text = "确认"
        '
        'gpb_con_fee
        '
        Me.gpb_con_fee.Controls.AddRange(New System.Windows.Forms.Control() {Me.cb_agent, Me.Label11, Me.ckb_con_basic_fee, Me.txt_con_cheap_rate, Me.ckb_con_triffice_fee, Me.Label6, Me.ckb_con_holiday, Me.txt_con_basic_fee, Me.Label8, Me.txt_con_cheap_fee, Me.Label9, Me.ckb_con_single_fee, Me.txt_con_rude_fee, Me.Label12, Me.ckb_con_wait_fee, Me.ckb_con_SEAL_EXAM_fee})
        Me.gpb_con_fee.Enabled = False
        Me.gpb_con_fee.Location = New System.Drawing.Point(342, 78)
        Me.gpb_con_fee.Name = "gpb_con_fee"
        Me.gpb_con_fee.Size = New System.Drawing.Size(325, 262)
        Me.gpb_con_fee.TabIndex = 26
        Me.gpb_con_fee.TabStop = False
        Me.gpb_con_fee.Text = "集装箱收费"
        '
        'cb_agent
        '
        Me.cb_agent.Location = New System.Drawing.Point(172, 224)
        Me.cb_agent.Name = "cb_agent"
        Me.cb_agent.Size = New System.Drawing.Size(110, 20)
        Me.cb_agent.TabIndex = 33
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(41, 224)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 23)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "船舶代理公司："
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ckb_con_basic_fee
        '
        Me.ckb_con_basic_fee.Location = New System.Drawing.Point(41, 140)
        Me.ckb_con_basic_fee.Name = "ckb_con_basic_fee"
        Me.ckb_con_basic_fee.Size = New System.Drawing.Size(128, 23)
        Me.ckb_con_basic_fee.TabIndex = 3
        Me.ckb_con_basic_fee.Text = "收起码理货费"
        '
        'txt_con_cheap_rate
        '
        Me.txt_con_cheap_rate.Location = New System.Drawing.Point(100, 112)
        Me.txt_con_cheap_rate.Name = "txt_con_cheap_rate"
        Me.txt_con_cheap_rate.Size = New System.Drawing.Size(70, 21)
        Me.txt_con_cheap_rate.TabIndex = 4
        Me.txt_con_cheap_rate.Text = ""
        '
        'ckb_con_triffice_fee
        '
        Me.ckb_con_triffice_fee.Checked = True
        Me.ckb_con_triffice_fee.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckb_con_triffice_fee.Location = New System.Drawing.Point(172, 53)
        Me.ckb_con_triffice_fee.Name = "ckb_con_triffice_fee"
        Me.ckb_con_triffice_fee.Size = New System.Drawing.Size(110, 24)
        Me.ckb_con_triffice_fee.TabIndex = 29
        Me.ckb_con_triffice_fee.Text = "交通费"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(41, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 23)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "优惠率："
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ckb_con_holiday
        '
        Me.ckb_con_holiday.Location = New System.Drawing.Point(172, 110)
        Me.ckb_con_holiday.Name = "ckb_con_holiday"
        Me.ckb_con_holiday.Size = New System.Drawing.Size(110, 24)
        Me.ckb_con_holiday.TabIndex = 5
        Me.ckb_con_holiday.Text = "节假日夜班豁免"
        '
        'txt_con_basic_fee
        '
        Me.txt_con_basic_fee.Location = New System.Drawing.Point(172, 168)
        Me.txt_con_basic_fee.Name = "txt_con_basic_fee"
        Me.txt_con_basic_fee.ReadOnly = True
        Me.txt_con_basic_fee.Size = New System.Drawing.Size(110, 21)
        Me.txt_con_basic_fee.TabIndex = 27
        Me.txt_con_basic_fee.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(41, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 23)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "起码理货费："
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_con_cheap_fee
        '
        Me.txt_con_cheap_fee.Location = New System.Drawing.Point(172, 196)
        Me.txt_con_cheap_fee.Name = "txt_con_cheap_fee"
        Me.txt_con_cheap_fee.ReadOnly = True
        Me.txt_con_cheap_fee.Size = New System.Drawing.Size(110, 21)
        Me.txt_con_cheap_fee.TabIndex = 25
        Me.txt_con_cheap_fee.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(41, 196)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 23)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "优惠总费用："
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ckb_con_single_fee
        '
        Me.ckb_con_single_fee.Checked = True
        Me.ckb_con_single_fee.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckb_con_single_fee.Location = New System.Drawing.Point(41, 54)
        Me.ckb_con_single_fee.Name = "ckb_con_single_fee"
        Me.ckb_con_single_fee.Size = New System.Drawing.Size(128, 23)
        Me.ckb_con_single_fee.TabIndex = 28
        Me.ckb_con_single_fee.Text = "单正费"
        '
        'txt_con_rude_fee
        '
        Me.txt_con_rude_fee.Location = New System.Drawing.Point(172, 27)
        Me.txt_con_rude_fee.Name = "txt_con_rude_fee"
        Me.txt_con_rude_fee.ReadOnly = True
        Me.txt_con_rude_fee.Size = New System.Drawing.Size(110, 21)
        Me.txt_con_rude_fee.TabIndex = 24
        Me.txt_con_rude_fee.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(41, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(128, 23)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "无优惠无豁免理货费："
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ckb_con_wait_fee
        '
        Me.ckb_con_wait_fee.Checked = True
        Me.ckb_con_wait_fee.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckb_con_wait_fee.Location = New System.Drawing.Point(41, 82)
        Me.ckb_con_wait_fee.Name = "ckb_con_wait_fee"
        Me.ckb_con_wait_fee.Size = New System.Drawing.Size(128, 23)
        Me.ckb_con_wait_fee.TabIndex = 30
        Me.ckb_con_wait_fee.Text = "待时费"
        '
        'ckb_con_SEAL_EXAM_fee
        '
        Me.ckb_con_SEAL_EXAM_fee.Checked = True
        Me.ckb_con_SEAL_EXAM_fee.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckb_con_SEAL_EXAM_fee.Location = New System.Drawing.Point(172, 82)
        Me.ckb_con_SEAL_EXAM_fee.Name = "ckb_con_SEAL_EXAM_fee"
        Me.ckb_con_SEAL_EXAM_fee.Size = New System.Drawing.Size(110, 24)
        Me.ckb_con_SEAL_EXAM_fee.TabIndex = 31
        Me.ckb_con_SEAL_EXAM_fee.Text = "施封费"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.rb_con_fee, Me.rb_cargo_fee})
        Me.GroupBox3.Location = New System.Drawing.Point(18, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(648, 62)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "收费方式"
        '
        'rb_con_fee
        '
        Me.rb_con_fee.Location = New System.Drawing.Point(334, 30)
        Me.rb_con_fee.Name = "rb_con_fee"
        Me.rb_con_fee.TabIndex = 29
        Me.rb_con_fee.Text = "集装箱收费"
        '
        'rb_cargo_fee
        '
        Me.rb_cargo_fee.Location = New System.Drawing.Point(12, 30)
        Me.rb_cargo_fee.Name = "rb_cargo_fee"
        Me.rb_cargo_fee.TabIndex = 28
        Me.rb_cargo_fee.Text = "件杂货收费"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(346, 354)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 23)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "审核人"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cb_check
        '
        Me.cb_check.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_check.Location = New System.Drawing.Point(404, 355)
        Me.cb_check.Name = "cb_check"
        Me.cb_check.Size = New System.Drawing.Size(100, 20)
        Me.cb_check.TabIndex = 29
        '
        'cb_INCHARGER
        '
        Me.cb_INCHARGER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_INCHARGER.Location = New System.Drawing.Point(240, 355)
        Me.cb_INCHARGER.Name = "cb_INCHARGER"
        Me.cb_INCHARGER.Size = New System.Drawing.Size(100, 20)
        Me.cb_INCHARGER.TabIndex = 29
        '
        'FrmCondition
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(684, 431)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cb_check, Me.Label13, Me.GroupBox3, Me.gpb_con_fee, Me.btn_enter, Me.gpb_cargo_fee, Me.txt_PREPAREDMAN, Me.Label7, Me.Label5, Me.dt_LISTDATE, Me.Label4, Me.btn_exit, Me.btn_generate, Me.cb_INCHARGER})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCondition"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "计费帐单＿生成"
        Me.gpb_cargo_fee.ResumeLayout(False)
        Me.gpb_con_fee.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds_rude_fee As New DataSet() '无优惠无豁免理货费
    Dim str_rude_fee As String = "select sum(money_pre) from account_work where money_pre<>0 and ship_id=" & Ship_ID
    Dim ds_cheap_fee As New DataSet()
    Dim ds_bill_list As New DataSet()
    Dim sqlda_bill_list As New SqlClient.SqlDataAdapter()
    Dim str_bill_list As String
    Dim ds_agent As New DataSet()
    Dim ds_agent1 As New DataSet()

    Dim sqlconn As New SqlClient.SqlConnection(connstr)
    Dim sqlcmd As New SqlClient.SqlCommand()
    Dim sqlad As New SqlClient.SqlDataAdapter()

    Dim ds_ship_statu As New DataSet() '船舶状态
    Dim ds_manager As New DataSet() ' '填充主官人
    Dim ds_check As New DataSet()   '填充审核人
    Dim ds_file_No As New DataSet() '档案号
    Dim i As Integer
    'str_rude_fee
    Private Sub FrmCondition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '填写制单人
        Me.txt_PREPAREDMAN.Text = G_User
        '填充主官人
        Getdata("select name from code_manager", ds_manager)
        For i = 0 To ds_manager.Tables(0).Rows.Count - 1
            Me.cb_INCHARGER.Items.Add(ds_manager.Tables(0).Rows(i).Item(0))
        Next
        Me.cb_INCHARGER.Text = ds_manager.Tables(0).Rows(0).Item(0)
        '填充审核人
        For i = 0 To Getdata("select name from code_check", ds_check).Count - 1
            Me.cb_check.Items.Add(ds_check.Tables(0).Rows(i).Item(0))
        Next
        Me.cb_check.Text = ds_check.Tables(0).Rows(0).Item(0)

        Try
            Getdata(str_rude_fee, ds_rude_fee)
            txt_rude_fee.Text = ds_rude_fee.Tables(0).Rows(0).Item(0)
        Catch
        End Try
        Dim sqlcomm1 As New SqlClient.SqlCommand()
        Dim sqlpa1 As New SqlClient.SqlParameter()
        sqlcomm1.Connection = sqlconn
        sqlcomm1.CommandType = CommandType.StoredProcedure
        sqlcomm1.CommandText = "sp_con_fee_stat"
        sqlpa1.ParameterName = "@ship_id"
        sqlpa1.Value = Ship_ID
        sqlcomm1.Parameters.Add(sqlpa1)
        Try
            sqlconn.Open()
        Catch

        End Try
        Try
            sqlcomm1.CommandTimeout = 300
            sqlcomm1.ExecuteNonQuery()
        Catch er As System.Exception
            MsgBox(er)
        End Try
        Try
            sqlconn.Close()
        Catch
        End Try
        Try
            Getdata(str_rude_fee, ds_rude_fee)
            txt_con_rude_fee.Text = ds_rude_fee.Tables(0).Rows(0).Item(0)
        Catch
        End Try
        '船舶代理公司
        sqlcmd.CommandTimeout = 300
        sqlcmd.Connection = sqlconn
        sqlcmd.CommandText = "select agent,SHIPAGENT_CHA from view_ship_agent where ship_id=" & Ship_ID
        sqlad.SelectCommand = sqlcmd
        sqlad.Fill(ds_agent)
        sqlcmd.CommandText = "select agent,SHIPAGENT_CHA from view_con_hire_agent where ship_id=" & Ship_ID
        sqlad.Fill(ds_agent)
        Me.cb_agent.DataSource = ds_agent.Tables(0).DefaultView
        Me.cb_agent.DisplayMember = "SHIPAGENT_CHA"
        Me.cb_agent.ValueMember = "agent"


    End Sub

    Private Sub btn_tally_result_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_tally_result.Click
        Dim frm As New Frm_modify_goodtype()
        frm.ShowDialog()
        'sub2
        Dim sqlcomm1 As New SqlClient.SqlCommand()
        Dim sqlpa1 As New SqlClient.SqlParameter()
        sqlcomm1.Connection = sqlconn
        sqlcomm1.CommandType = CommandType.StoredProcedure
        sqlcomm1.CommandText = "sp_tally_result"
        sqlpa1.ParameterName = "@ship_id"
        sqlpa1.Value = Ship_ID
        sqlcomm1.Parameters.Add(sqlpa1)
        Try
            sqlconn.Open()
        Catch

        End Try
        Try
            sqlcomm1.CommandTimeout = 300
            sqlcomm1.ExecuteNonQuery()
        Catch er As System.Exception
            MsgBox(er.Message)
        End Try
        Try
            sqlconn.Close()
        Catch
        End Try
        sp_cargo_fee_stat() 'sub3
        'sub3
        Getdata(str_rude_fee, ds_rude_fee)
        txt_rude_fee.Text = ds_rude_fee.Tables(0).Rows(0).Item(0)

        txt_basic_fee.Text = ""
        Me.txt_cheap_fee.Text = ""
    End Sub

    Private Sub btn_generate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_generate.Click
        If Me.rb_cargo_fee.Checked = True Then
            If Me.ckb_basic_fee.Checked = True Then
                basic_tally_fee_stat() 'sub4  
                Getdata(str_rude_fee, ds_rude_fee)
                txt_basic_fee.Text = ds_rude_fee.Tables(0).Rows(0).Item(0)
                Me.txt_cheap_fee.Text = ""
            Else
                sp_cargo_fee_stat() 'sub3
                Getdata(str_rude_fee, ds_cheap_fee)
                txt_cheap_fee.Text = ds_cheap_fee.Tables(0).Rows(0).Item(0)
                Me.txt_basic_fee.Text = ""
            End If
        Else
            If Me.rb_con_fee.Checked = True Then
                If Me.ckb_con_basic_fee.Checked = True Then
                    basic_con_tally_fee_stat() 'sub5
                    Getdata(str_rude_fee, ds_rude_fee)
                    txt_con_basic_fee.Text = ds_rude_fee.Tables(0).Rows(0).Item(0)
                    Me.txt_con_cheap_fee.Text = ""
                Else
                    sp_con_fee_stat_agent()
                    Getdata(str_rude_fee, ds_cheap_fee)
                    Try
                        txt_con_cheap_fee.Text = ds_cheap_fee.Tables(0).Rows(0).Item(0)
                    Catch
                    End Try
                    Me.txt_con_basic_fee.Text = ""
                End If
            End If
        End If

    End Sub

    Private Sub btn_enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enter.Click
        '件杂货计费
        If Me.rb_cargo_fee.Checked = True Then
            If txt_basic_fee.Text <> "" Or Me.txt_cheap_fee.Text <> "" Then
                '帐单开始
                Dim ds_code_pay_men As New DataSet()
                Dim str_code_pay_men As String

                str_code_pay_men = "select CHI_VESSEL,VOYAGE,AGENT from sship where ship_id=" & Ship_ID
                Getdata(str_code_pay_men, ds_code_pay_men)

                str_bill_list = "select * from bill_list where ship_id=" & Ship_ID
                Updatedata(sqlda_bill_list, str_bill_list, ds_bill_list)
                Dim s As Integer
                s = ds_bill_list.Tables(0).Rows.Count

                Dim row As DataRow
                row = ds_bill_list.Tables(0).NewRow
                row("SHIP_ID") = Ship_ID
                row("CHI_VESSEL") = ds_code_pay_men.Tables(0).Rows(0).Item("CHI_VESSEL")
                row("VOYAGE") = ds_code_pay_men.Tables(0).Rows(0).Item("VOYAGE")
                row("LISTDATE") = Me.dt_LISTDATE.Value
                '由档案号写帐单编号
                Dim maxno As Integer
                Dim bill_No As Integer = 0 '帐单-后面的数字
                maxno = Getdata("select ltrim(rtrim(file_No)) from sship where ship_id=" & Ship_ID, ds_file_No).Count - 1

                If s > 0 Then
                    If s = 1 Then
                        '有一条帐单
                        row("no") = ds_file_No.Tables(0).Rows(0).Item(0) & "_1"
                    Else
                        '有多条帐单
                        For i = 0 To ds_bill_list.Tables(0).Rows.Count - 1
                            If InStr(ds_bill_list.Tables(0).Rows(i).Item("no"), "_", CompareMethod.Text) > 0 Then
                                If Strings.Right(ds_bill_list.Tables(0).Rows(i).Item("no"), Len(ds_bill_list.Tables(0).Rows(i).Item("no")) - InStr(ds_bill_list.Tables(0).Rows(i).Item("no"), "_", CompareMethod.Text)) > bill_No Then
                                    bill_No = Strings.Right(ds_bill_list.Tables(0).Rows(i).Item("no"), Len(ds_bill_list.Tables(0).Rows(i).Item("no")) - InStr(ds_bill_list.Tables(0).Rows(i).Item("no"), "_", CompareMethod.Text))
                                End If
                            End If
                        Next
                        row("no") = ds_file_No.Tables(0).Rows(0).Item(0) & "_" & bill_No + 1
                    End If

                Else
                    '无帐单
                    row("no") = ds_file_No.Tables(0).Rows(0).Item(0)
                End If


                If txt_basic_fee.Text <> "" Then
                    row("TOTAL_MONEY") = txt_basic_fee.Text
                Else
                    row("TOTAL_MONEY") = Me.txt_cheap_fee.Text
                End If
                row("INCHARGER") = Me.cb_INCHARGER.Text
                row("CHECKEDMAN") = Me.cb_check.Text
                row("PREPAREDMAN") = Me.txt_PREPAREDMAN.Text
                row("FEE_TYPE") = 1 '件杂货Code_Cargo_Type
                row("ACCOUNT_TYPE") = 1
                'row("MARK_MODIFY") = 0
                '船舶状态
                Getdata("select ship_statu from sship where ship_id=" & Ship_ID, ds_ship_statu)
                If ds_ship_statu.Tables(0).Rows(0).Item(0) = 4 Then
                    row("MARK_MODIFY") = 0
                Else
                    row("MARK_MODIFY") = 1
                End If
                row("DEPT_CODE") = G_DeptCode
                row("CODE_PAY_MEN") = ds_code_pay_men.Tables(0).Rows(0).Item("AGENT")
                ds_bill_list.Tables(0).Rows.Add(row)
                sqlda_bill_list.Update(ds_bill_list)
                '帐单结束
                '帐单明细开始
                Dim ds_ACCOUNT_LIST_ID As New DataSet()
                Dim str_ACCOUNT_LIST_ID As String
                bill_No = 0
                If s > 0 Then
                    If s = 1 Then
                        '有一条帐单
                        str_ACCOUNT_LIST_ID = "select ACCOUNT_LIST_ID,PREPAREDMAN from bill_list where no='" & ds_file_No.Tables(0).Rows(0).Item(0) & "_1'" & " And Ship_ID = " & Ship_ID
                    Else
                        '有多条帐单
                        For i = 0 To ds_bill_list.Tables(0).Rows.Count - 1
                            If InStr(ds_bill_list.Tables(0).Rows(i).Item("no"), "_", CompareMethod.Text) > 0 Then
                                If Strings.Right(ds_bill_list.Tables(0).Rows(i).Item("no"), Len(ds_bill_list.Tables(0).Rows(i).Item("no")) - InStr(ds_bill_list.Tables(0).Rows(i).Item("no"), "_", CompareMethod.Text)) > bill_No Then
                                    bill_No = Strings.Right(ds_bill_list.Tables(0).Rows(i).Item("no"), Len(ds_bill_list.Tables(0).Rows(i).Item("no")) - InStr(ds_bill_list.Tables(0).Rows(i).Item("no"), "_", CompareMethod.Text))
                                End If
                            End If
                        Next
                        str_ACCOUNT_LIST_ID = ds_file_No.Tables(0).Rows(0).Item(0) & "_" & bill_No
                        str_ACCOUNT_LIST_ID = "select ACCOUNT_LIST_ID,PREPAREDMAN from bill_list where no='" & str_ACCOUNT_LIST_ID & "' And Ship_ID = " & Ship_ID
                    End If

                Else
                    '无帐单
                    str_ACCOUNT_LIST_ID = "select ACCOUNT_LIST_ID,PREPAREDMAN from bill_list where no='" & ds_file_No.Tables(0).Rows(0).Item(0) & "' And Ship_ID = " & Ship_ID
                End If

                'If bill_No > 0 Then
                '    str_ACCOUNT_LIST_ID = "select ACCOUNT_LIST_ID,PREPAREDMAN from bill_list where no=(select no from bill_list where  ship_id=" & Ship_ID & ") and ship_id=" & Ship_ID
                'End If
                'str_ACCOUNT_LIST_ID = "select ACCOUNT_LIST_ID,PREPAREDMAN from bill_list where no=(select no from bill_list where  ship_id=" & Ship_ID & ") and ship_id=" & Ship_ID
                Getdata(str_ACCOUNT_LIST_ID, ds_ACCOUNT_LIST_ID)

                Dim ssst As String
                ssst = "insert bill_detail(ACCOUNT_LIST_ID,FEE_CODE,FEE_AMOUNT,UNIT,FEE_RATE,MONEY,USER_NAME) select '" & ds_ACCOUNT_LIST_ID.Tables(0).Rows(0).Item(0) & "',FEE_CODE,AMOUNT,UNIT,PRICE_PRE,MONEY_PRE,'" & ds_ACCOUNT_LIST_ID.Tables(0).Rows(0).Item(1) & "' from account_work where MONEY_PRE<>0 and ship_id='" & Ship_ID & "'"
                ExecSql(ssst)

                Me.Close()
            Else
                MsgBox("请生成起码理货费或者优惠费用！", MsgBoxStyle.OKOnly, "提示！")
            End If
        End If
        '集装箱计费
        If Me.rb_con_fee.Checked = True Then
            If txt_con_basic_fee.Text <> "" Or Me.txt_con_cheap_fee.Text <> "" Then
                '帐单开始
                Dim ds_code_pay_men As New DataSet()
                Dim str_code_pay_men As String

                str_code_pay_men = "select CHI_VESSEL,VOYAGE,AGENT from sship where ship_id=" & Ship_ID
                Getdata(str_code_pay_men, ds_code_pay_men)

                str_bill_list = "select * from bill_list where ship_id=" & Ship_ID
                Updatedata(sqlda_bill_list, str_bill_list, ds_bill_list)
                Dim s As Integer
                s = ds_bill_list.Tables(0).Rows.Count

                Dim row As DataRow
                row = ds_bill_list.Tables(0).NewRow
                row("SHIP_ID") = Ship_ID
                row("CHI_VESSEL") = ds_code_pay_men.Tables(0).Rows(0).Item("CHI_VESSEL")
                row("VOYAGE") = ds_code_pay_men.Tables(0).Rows(0).Item("VOYAGE")
                row("LISTDATE") = Me.dt_LISTDATE.Value
                If s > 0 Then
                    row("no") = s + 1
                Else
                    row("no") = 1
                End If
                If txt_con_basic_fee.Text <> "" Then
                    row("TOTAL_MONEY") = txt_con_basic_fee.Text
                Else
                    row("TOTAL_MONEY") = Me.txt_con_cheap_fee.Text
                End If
                row("INCHARGER") = Me.cb_INCHARGER.Text
                row("CHECKEDMAN") = Me.cb_check.Text
                row("PREPAREDMAN") = Me.txt_PREPAREDMAN.Text
                row("FEE_TYPE") = 2 '集装箱Code_Cargo_Type
                row("ACCOUNT_TYPE") = 1 '本部
                'row("MARK_MODIFY") = 0
                '船舶状态
                Getdata("select ship_statu from sship where ship_id=" & Ship_ID, ds_ship_statu)
                If ds_ship_statu.Tables(0).Rows(0).Item(0) = 4 Then
                    row("MARK_MODIFY") = 0
                Else
                    row("MARK_MODIFY") = 1
                End If
                row("DEPT_CODE") = G_DeptCode
                row("CODE_PAY_MEN") = Me.cb_agent.SelectedValue
                ds_bill_list.Tables(0).Rows.Add(row)
                sqlda_bill_list.Update(ds_bill_list)
                '帐单结束
                '帐单明细开始
                Dim ds_ACCOUNT_LIST_ID As New DataSet()
                Dim str_ACCOUNT_LIST_ID As String
                str_ACCOUNT_LIST_ID = "select ACCOUNT_LIST_ID,PREPAREDMAN from bill_list where no=(select max(no) from bill_list where ship_id=" & Ship_ID & ") and ship_id=" & Ship_ID
                Getdata(str_ACCOUNT_LIST_ID, ds_ACCOUNT_LIST_ID)

                Dim ssst As String
                ssst = "insert bill_detail(ACCOUNT_LIST_ID,FEE_CODE,FEE_AMOUNT,UNIT,FEE_RATE,MONEY,USER_NAME) select '" & ds_ACCOUNT_LIST_ID.Tables(0).Rows(0).Item(0) & "',FEE_CODE,AMOUNT,UNIT,PRICE_PRE,MONEY_PRE,'" & ds_ACCOUNT_LIST_ID.Tables(0).Rows(0).Item(1) & "' from account_work where MONEY_PRE<>0 and ship_id='" & Ship_ID & "'"
                ExecSql(ssst)

                Me.Close()
            Else
                MsgBox("请生成起码理货费或者优惠费用！", MsgBoxStyle.OKOnly, "提示！")
            End If
        End If
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub rb_cargo_fee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_cargo_fee.CheckedChanged
        Me.gpb_cargo_fee.Enabled = True
        Me.gpb_con_fee.Enabled = False
    End Sub

    Private Sub rb_con_fee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_con_fee.CheckedChanged
        Me.gpb_cargo_fee.Enabled = False
        Me.gpb_con_fee.Enabled = True

        'Dim sqlcomm1 As New SqlClient.SqlCommand()
        'Dim sqlpa1 As New SqlClient.SqlParameter()
        'sqlcomm1.Connection = sqlconn
        'sqlcomm1.CommandType = CommandType.StoredProcedure
        'sqlcomm1.CommandText = "sp_con_fee_stat"
        'sqlpa1.ParameterName = "@ship_id"
        'sqlpa1.Value = Ship_ID
        'sqlcomm1.Parameters.Add(sqlpa1)
        'Try
        '    sqlconn.Open()
        'Catch

        'End Try
        'Try
        '    sqlcomm1.CommandTimeout = 300
        '    sqlcomm1.ExecuteNonQuery()
        'Catch er As System.Exception
        '    MsgBox(er)
        'End Try
        'Try
        '    sqlconn.Close()
        'Catch
        'End Try
        'Getdata(str_rude_fee, ds_rude_fee)
        'txt_con_rude_fee.Text = ds_rude_fee.Tables(0).Rows(0).Item(0)

    End Sub

    Private Sub basic_tally_fee_stat() 'sub4
        Dim sqlcomm4 As New SqlClient.SqlCommand()
        Dim sqlpa5 As New SqlClient.SqlParameter()
        Dim sqlpa6 As New SqlClient.SqlParameter()
        sqlcomm4.Connection = sqlconn
        sqlcomm4.CommandType = CommandType.StoredProcedure
        sqlcomm4.CommandText = "basic_tally_fee_stat"
        sqlpa5.ParameterName = "@ship_id"
        sqlpa5.Value = Ship_ID
        sqlcomm4.Parameters.Add(sqlpa5)

        sqlpa6.ParameterName = "@cheap_rate"
        If Me.txt_cheap_rate.Text <> "" Then
            sqlpa6.Value = CType(LTrim(RTrim(Me.txt_cheap_rate.Text)), Double)
        Else
            sqlpa6.Value = 1
        End If
        sqlcomm4.Parameters.Add(sqlpa6)
        Try
            sqlconn.Open()
        Catch

        End Try
        Try
            sqlcomm4.CommandTimeout = 300
            sqlcomm4.ExecuteNonQuery()
        Catch er As System.Exception
            MsgBox(er.Message)
        End Try
        Try
            sqlconn.Close()
        Catch
        End Try
        'Getdata(str_rude_fee, ds_rude_fee)
        'txt_basic_fee.Text = ds_rude_fee.Tables(0).Rows(0).Item(0)
        'Me.txt_cheap_fee.Text = ""
    End Sub
    Private Sub basic_con_tally_fee_stat() 'sub5
        Dim sqlcomm4 As New SqlClient.SqlCommand()
        Dim sqlpa5 As New SqlClient.SqlParameter()
        Dim sqlpa6 As New SqlClient.SqlParameter()
        sqlcomm4.Connection = sqlconn
        sqlcomm4.CommandType = CommandType.StoredProcedure
        sqlcomm4.CommandText = "basic_con_tally_fee_stat"

        sqlpa5.ParameterName = "@ship_id"
        sqlpa5.Value = Ship_ID
        sqlcomm4.Parameters.Add(sqlpa5)

        sqlpa6.ParameterName = "@cheap_rate"
        If Me.txt_con_cheap_rate.Text <> "" Then
            sqlpa6.Value = CType(LTrim(RTrim(Me.txt_con_cheap_rate.Text)), Double)
        Else
            sqlpa6.Value = 1
        End If
        sqlcomm4.Parameters.Add(sqlpa6)
        Try
            sqlconn.Open()
        Catch

        End Try
        Try
            sqlcomm4.CommandTimeout = 300
            sqlcomm4.ExecuteNonQuery()
        Catch er As System.Exception
            MsgBox(er.Message)
        End Try
        Try
            sqlconn.Close()
        Catch
        End Try
    End Sub
    Private Sub sp_cargo_fee_stat() 'sub3
        Try
            sqlconn.Open()
        Catch
        End Try
        'sub3
        Dim sqlcomm2 As New SqlClient.SqlCommand()
        Dim sqlpa2 As New SqlClient.SqlParameter()
        Dim sqlpa3 As New SqlClient.SqlParameter()
        Dim sqlpa4 As New SqlClient.SqlParameter()

        Dim sqlpa5 As New SqlClient.SqlParameter()
        Dim sqlpa6 As New SqlClient.SqlParameter()
        Dim sqlpa7 As New SqlClient.SqlParameter()
        Dim sqlpa8 As New SqlClient.SqlParameter()

        sqlcomm2.Connection = sqlconn
        sqlcomm2.CommandType = CommandType.StoredProcedure
        sqlcomm2.CommandText = "sp_cargo_fee_stat"

        sqlpa2.ParameterName = "@ship_id"
        sqlpa2.Value = Ship_ID
        sqlcomm2.Parameters.Add(sqlpa2)

        sqlpa3.ParameterName = "@cheap_rate"
        If Me.txt_cheap_rate.Text <> "" Then
            sqlpa3.Value = CType(LTrim(RTrim(Me.txt_cheap_rate.Text)), Double)
        Else
            sqlpa3.Value = 1
        End If
        sqlcomm2.Parameters.Add(sqlpa3)

        sqlpa4.ParameterName = "@holiday"
        If Me.ckb_holiday.Checked = True Then
            sqlpa4.Value = 1
        Else
            sqlpa4.Value = 0
        End If
        sqlcomm2.Parameters.Add(sqlpa4)


        sqlpa5.ParameterName = "@single_fee"
        If Me.ckb_single_fee.Checked = True Then
            sqlpa5.Value = 1
        Else
            sqlpa5.Value = 0
        End If
        sqlcomm2.Parameters.Add(sqlpa5)

        sqlpa6.ParameterName = "@triffice_fee"
        If Me.ckb_triffice_fee.Checked = True Then
            sqlpa6.Value = 1
        Else
            sqlpa6.Value = 0
        End If
        sqlcomm2.Parameters.Add(sqlpa6)
        '待使费
        sqlpa7.ParameterName = "@wait_fee"
        If Me.ckb_wait_fee.Checked = True Then
            sqlpa7.Value = 1
        Else
            sqlpa7.Value = 0
        End If
        sqlcomm2.Parameters.Add(sqlpa7)
        '侍奉费
        sqlpa8.ParameterName = "@SEAL_EXAM_fee"
        If Me.ckb_SEAL_EXAM_fee.Checked = True Then
            sqlpa8.Value = 1
        Else
            sqlpa8.Value = 0
        End If
        sqlcomm2.Parameters.Add(sqlpa8)

        Try
            sqlcomm2.CommandTimeout = 300
            sqlcomm2.ExecuteNonQuery()
        Catch er As System.Exception
            MsgBox(er.Message)
        End Try
        Try
            sqlconn.Close()
        Catch
        End Try
        'Getdata(str_rude_fee, ds_cheap_fee)
        'txt_cheap_fee.Text = ds_cheap_fee.Tables(0).Rows(0).Item(0)
        'Me.txt_basic_fee.Text = ""
    End Sub
    Private Sub sp_con_fee_stat_agent() '集装箱收费
        Try
            sqlconn.Open()
        Catch
        End Try
        Dim sqlcomm2 As New SqlClient.SqlCommand()
        Dim sqlpa2 As New SqlClient.SqlParameter()
        Dim sqlpa3 As New SqlClient.SqlParameter()
        Dim sqlpa4 As New SqlClient.SqlParameter()

        Dim sqlpa5 As New SqlClient.SqlParameter()
        Dim sqlpa6 As New SqlClient.SqlParameter()
        Dim sqlpa7 As New SqlClient.SqlParameter()
        Dim sqlpa8 As New SqlClient.SqlParameter()
        Dim sqlpa9 As New SqlClient.SqlParameter()

        sqlcomm2.Connection = sqlconn
        sqlcomm2.CommandType = CommandType.StoredProcedure
        sqlcomm2.CommandText = "sp_con_fee_stat_agent"

        sqlpa2.ParameterName = "@ship_id"
        sqlpa2.Value = Ship_ID
        sqlcomm2.Parameters.Add(sqlpa2)

        sqlpa3.ParameterName = "@cheap_rate"
        If Me.txt_con_cheap_rate.Text <> "" Then
            sqlpa3.Value = CType(LTrim(RTrim(Me.txt_con_cheap_rate.Text)), Double)
        Else
            sqlpa3.Value = 1
        End If
        sqlcomm2.Parameters.Add(sqlpa3)

        sqlpa4.ParameterName = "@holiday_night"
        If Me.ckb_con_holiday.Checked = True Then
            sqlpa4.Value = 1
        Else
            sqlpa4.Value = 0
        End If
        sqlcomm2.Parameters.Add(sqlpa4)


        sqlpa5.ParameterName = "@single_fee"
        If Me.ckb_con_single_fee.Checked = True Then
            sqlpa5.Value = 1
        Else
            sqlpa5.Value = 0
        End If
        sqlcomm2.Parameters.Add(sqlpa5)

        sqlpa6.ParameterName = "@triffice_fee"
        If Me.ckb_con_triffice_fee.Checked = True Then
            sqlpa6.Value = 1
        Else
            sqlpa6.Value = 0
        End If
        sqlcomm2.Parameters.Add(sqlpa6)
        '待使费
        sqlpa7.ParameterName = "@wait_fee"
        If Me.ckb_con_wait_fee.Checked = True Then
            sqlpa7.Value = 1
        Else
            sqlpa7.Value = 0
        End If
        sqlcomm2.Parameters.Add(sqlpa7)
        '侍奉费
        sqlpa8.ParameterName = "@SEAL_EXAM_fee"
        If Me.ckb_con_SEAL_EXAM_fee.Checked = True Then
            sqlpa8.Value = 1
        Else
            sqlpa8.Value = 0
        End If
        sqlcomm2.Parameters.Add(sqlpa8)

        sqlpa9.ParameterName = "@hire_company"
        sqlpa9.Value = Me.cb_agent.SelectedValue
        sqlcomm2.Parameters.Add(sqlpa9)

        Try
            sqlcomm2.CommandTimeout = 300
            sqlcomm2.ExecuteNonQuery()
        Catch er As System.Exception
            MsgBox(er.Message)
        End Try
        Try
            sqlconn.Close()
        Catch
        End Try
    End Sub
End Class
