Imports TALLY.DBControl
Public Class FrmSealInquire_Select
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        AddHandler txtSealNOBegin.Leave, AddressOf FrmSealInquire_Select_Leave
        AddHandler txtSealNOEnd.Leave, AddressOf FrmSealInquire_Select_Leave
        AddHandler txtDealPerson.Leave, AddressOf FrmSealInquire_Select_Leave
        AddHandler txtDrawPerson.Leave, AddressOf FrmSealInquire_Select_Leave
        AddHandler txtSubPerson.Leave, AddressOf FrmSealInquire_Select_Leave
        AddHandler txtUsePerson.Leave, AddressOf FrmSealInquire_Select_Leave
        AddHandler txtOperPerson.Leave, AddressOf FrmSealInquire_Select_Leave
        AddHandler txtShip.Leave, AddressOf FrmSealInquire_Select_Leave
        AddHandler txtVoyage.Leave, AddressOf FrmSealInquire_Select_Leave
        AddHandler txtContainer.Leave, AddressOf FrmSealInquire_Select_Leave

        AddHandler txtSealNOBegin.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler txtSealNOEnd.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler cbSealState.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler cbSub.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler cbUse.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler cbLogoff.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler cbDept.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler txtDealPerson.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler ckbDealTime.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler ckbDealBegin.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler ckbDealEnd.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler dtpDealBegin.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler dtpDealEnd.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler ckbInTime.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler ckbInBegin.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler ckbInEnd.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler dtpInBegin.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler dtpInEnd.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler cbDrawDept.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler txtDrawPerson.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler cbSubDept.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler txtSubPerson.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler txtUsePerson.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler txtOperPerson.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler ckbOtherTime.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler cbOtherTime.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler ckbOtherBegin.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler ckbOtherEnd.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler dtpOtherBegin.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler dtpOtherEnd.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler txtShip.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler txtVoyage.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler txtContainer.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler ckbSealTime.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler ckbSealBegin.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler ckbSealEnd.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler dtpSealBegin.KeyDown, AddressOf FrmSealInquire_Select_KeyDown
        AddHandler dtpSealEnd.KeyDown, AddressOf FrmSealInquire_Select_KeyDown

    End Sub

    '窗体重写 dispose 以清理组件列表。
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

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
    Friend WithEvents txtSealNOEnd As System.Windows.Forms.TextBox
    Friend WithEvents txtSealNOBegin As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbDept As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbSealState As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ckbInTime As System.Windows.Forms.CheckBox
    Friend WithEvents gbInTime As System.Windows.Forms.GroupBox
    Friend WithEvents dtpInBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpInEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents ckbInBegin As System.Windows.Forms.CheckBox
    Friend WithEvents ckbInEnd As System.Windows.Forms.CheckBox
    Friend WithEvents ckbDealTime As System.Windows.Forms.CheckBox
    Friend WithEvents gbDealTime As System.Windows.Forms.GroupBox
    Friend WithEvents dtpDealBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDealEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents ckbDealBegin As System.Windows.Forms.CheckBox
    Friend WithEvents ckbDealEnd As System.Windows.Forms.CheckBox
    Friend WithEvents ckbOtherTime As System.Windows.Forms.CheckBox
    Friend WithEvents gbOtherTime As System.Windows.Forms.GroupBox
    Friend WithEvents dtpOtherBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpOtherEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents ckbOtherBegin As System.Windows.Forms.CheckBox
    Friend WithEvents ckbOtherEnd As System.Windows.Forms.CheckBox
    Friend WithEvents cbOtherTime As System.Windows.Forms.ComboBox
    Friend WithEvents txtDealPerson As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtUsePerson As System.Windows.Forms.TextBox
    Friend WithEvents txtDrawPerson As System.Windows.Forms.TextBox
    Friend WithEvents cbDrawDept As System.Windows.Forms.ComboBox
    Friend WithEvents txtSubPerson As System.Windows.Forms.TextBox
    Friend WithEvents cbSubDept As System.Windows.Forms.ComboBox
    Friend WithEvents txtOperPerson As System.Windows.Forms.TextBox
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents cbUse As System.Windows.Forms.ComboBox
    Friend WithEvents cbLogoff As System.Windows.Forms.ComboBox
    Friend WithEvents cbSub As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtContainer As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtShip As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ckbSealTime As System.Windows.Forms.CheckBox
    Friend WithEvents dtpSealBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpSealEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents ckbSealBegin As System.Windows.Forms.CheckBox
    Friend WithEvents ckbSealEnd As System.Windows.Forms.CheckBox
    Friend WithEvents gbSealTime As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtSealNOEnd = New System.Windows.Forms.TextBox
        Me.txtSealNOBegin = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbDept = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbSealState = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbUse = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbLogoff = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbSub = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ckbInTime = New System.Windows.Forms.CheckBox
        Me.gbInTime = New System.Windows.Forms.GroupBox
        Me.dtpInBegin = New System.Windows.Forms.DateTimePicker
        Me.dtpInEnd = New System.Windows.Forms.DateTimePicker
        Me.ckbInBegin = New System.Windows.Forms.CheckBox
        Me.ckbInEnd = New System.Windows.Forms.CheckBox
        Me.ckbDealTime = New System.Windows.Forms.CheckBox
        Me.gbDealTime = New System.Windows.Forms.GroupBox
        Me.dtpDealBegin = New System.Windows.Forms.DateTimePicker
        Me.dtpDealEnd = New System.Windows.Forms.DateTimePicker
        Me.ckbDealBegin = New System.Windows.Forms.CheckBox
        Me.ckbDealEnd = New System.Windows.Forms.CheckBox
        Me.ckbOtherTime = New System.Windows.Forms.CheckBox
        Me.gbOtherTime = New System.Windows.Forms.GroupBox
        Me.dtpOtherBegin = New System.Windows.Forms.DateTimePicker
        Me.dtpOtherEnd = New System.Windows.Forms.DateTimePicker
        Me.ckbOtherBegin = New System.Windows.Forms.CheckBox
        Me.ckbOtherEnd = New System.Windows.Forms.CheckBox
        Me.cbOtherTime = New System.Windows.Forms.ComboBox
        Me.txtDealPerson = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtUsePerson = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtDrawPerson = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cbDrawDept = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtSubPerson = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cbSubDept = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtOperPerson = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ckbSealTime = New System.Windows.Forms.CheckBox
        Me.gbSealTime = New System.Windows.Forms.GroupBox
        Me.dtpSealBegin = New System.Windows.Forms.DateTimePicker
        Me.dtpSealEnd = New System.Windows.Forms.DateTimePicker
        Me.ckbSealBegin = New System.Windows.Forms.CheckBox
        Me.ckbSealEnd = New System.Windows.Forms.CheckBox
        Me.txtContainer = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtShip = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.gbInTime.SuspendLayout()
        Me.gbDealTime.SuspendLayout()
        Me.gbOtherTime.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbSealTime.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSealNOEnd
        '
        Me.txtSealNOEnd.Location = New System.Drawing.Point(84, 44)
        Me.txtSealNOEnd.MaxLength = 20
        Me.txtSealNOEnd.Name = "txtSealNOEnd"
        Me.txtSealNOEnd.Size = New System.Drawing.Size(130, 21)
        Me.txtSealNOEnd.TabIndex = 1
        Me.txtSealNOEnd.Text = ""
        '
        'txtSealNOBegin
        '
        Me.txtSealNOBegin.Location = New System.Drawing.Point(84, 16)
        Me.txtSealNOBegin.MaxLength = 20
        Me.txtSealNOBegin.Name = "txtSealNOBegin"
        Me.txtSealNOBegin.Size = New System.Drawing.Size(130, 21)
        Me.txtSealNOBegin.TabIndex = 0
        Me.txtSealNOBegin.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 20)
        Me.Label4.TabIndex = 209
        Me.Label4.Text = "铅封止号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 208
        Me.Label5.Text = "铅封起号"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbDept
        '
        Me.cbDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDept.Location = New System.Drawing.Point(84, 184)
        Me.cbDept.MaxDropDownItems = 20
        Me.cbDept.Name = "cbDept"
        Me.cbDept.Size = New System.Drawing.Size(130, 20)
        Me.cbDept.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(12, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 20)
        Me.Label7.TabIndex = 214
        Me.Label7.Text = "所属部门"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbSealState
        '
        Me.cbSealState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSealState.Items.AddRange(New Object() {"全部", "入库", "出库", "发放"})
        Me.cbSealState.Location = New System.Drawing.Point(84, 72)
        Me.cbSealState.MaxDropDownItems = 20
        Me.cbSealState.Name = "cbSealState"
        Me.cbSealState.Size = New System.Drawing.Size(130, 20)
        Me.cbSealState.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(12, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 212
        Me.Label6.Text = "发放状态"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbUse
        '
        Me.cbUse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUse.Items.AddRange(New Object() {"全部", "未用", "在用"})
        Me.cbUse.Location = New System.Drawing.Point(84, 128)
        Me.cbUse.MaxDropDownItems = 20
        Me.cbUse.Name = "cbUse"
        Me.cbUse.Size = New System.Drawing.Size(130, 20)
        Me.cbUse.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 216
        Me.Label1.Text = "使用状态"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbLogoff
        '
        Me.cbLogoff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLogoff.Items.AddRange(New Object() {"全部", "正常", "注销"})
        Me.cbLogoff.Location = New System.Drawing.Point(84, 156)
        Me.cbLogoff.MaxDropDownItems = 20
        Me.cbLogoff.Name = "cbLogoff"
        Me.cbLogoff.Size = New System.Drawing.Size(130, 20)
        Me.cbLogoff.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 218
        Me.Label2.Text = "注销状态"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbSub
        '
        Me.cbSub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSub.Items.AddRange(New Object() {"全部", "是", "否"})
        Me.cbSub.Location = New System.Drawing.Point(84, 100)
        Me.cbSub.MaxDropDownItems = 20
        Me.cbSub.Name = "cbSub"
        Me.cbSub.Size = New System.Drawing.Size(130, 20)
        Me.cbSub.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 220
        Me.Label3.Text = "是否转借"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ckbInTime
        '
        Me.ckbInTime.Location = New System.Drawing.Point(244, 16)
        Me.ckbInTime.Name = "ckbInTime"
        Me.ckbInTime.Size = New System.Drawing.Size(98, 20)
        Me.ckbInTime.TabIndex = 10
        Me.ckbInTime.Text = "确定入库时间"
        Me.ckbInTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbInTime
        '
        Me.gbInTime.Controls.Add(Me.dtpInBegin)
        Me.gbInTime.Controls.Add(Me.dtpInEnd)
        Me.gbInTime.Controls.Add(Me.ckbInBegin)
        Me.gbInTime.Controls.Add(Me.ckbInEnd)
        Me.gbInTime.Enabled = False
        Me.gbInTime.Location = New System.Drawing.Point(240, 32)
        Me.gbInTime.Name = "gbInTime"
        Me.gbInTime.Size = New System.Drawing.Size(184, 60)
        Me.gbInTime.TabIndex = 11
        Me.gbInTime.TabStop = False
        '
        'dtpInBegin
        '
        Me.dtpInBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpInBegin.Location = New System.Drawing.Point(60, 10)
        Me.dtpInBegin.Name = "dtpInBegin"
        Me.dtpInBegin.Size = New System.Drawing.Size(120, 21)
        Me.dtpInBegin.TabIndex = 1
        '
        'dtpInEnd
        '
        Me.dtpInEnd.CustomFormat = "yyyy-MM-dd"
        Me.dtpInEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpInEnd.Location = New System.Drawing.Point(60, 34)
        Me.dtpInEnd.Name = "dtpInEnd"
        Me.dtpInEnd.Size = New System.Drawing.Size(120, 21)
        Me.dtpInEnd.TabIndex = 3
        '
        'ckbInBegin
        '
        Me.ckbInBegin.Checked = True
        Me.ckbInBegin.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbInBegin.Location = New System.Drawing.Point(6, 10)
        Me.ckbInBegin.Name = "ckbInBegin"
        Me.ckbInBegin.Size = New System.Drawing.Size(50, 20)
        Me.ckbInBegin.TabIndex = 0
        Me.ckbInBegin.Text = "最早"
        Me.ckbInBegin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ckbInEnd
        '
        Me.ckbInEnd.Checked = True
        Me.ckbInEnd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbInEnd.Location = New System.Drawing.Point(6, 34)
        Me.ckbInEnd.Name = "ckbInEnd"
        Me.ckbInEnd.Size = New System.Drawing.Size(50, 20)
        Me.ckbInEnd.TabIndex = 2
        Me.ckbInEnd.Text = "最晚"
        Me.ckbInEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ckbDealTime
        '
        Me.ckbDealTime.Location = New System.Drawing.Point(32, 240)
        Me.ckbDealTime.Name = "ckbDealTime"
        Me.ckbDealTime.Size = New System.Drawing.Size(98, 20)
        Me.ckbDealTime.TabIndex = 8
        Me.ckbDealTime.Text = "确定经办时间"
        Me.ckbDealTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbDealTime
        '
        Me.gbDealTime.Controls.Add(Me.dtpDealBegin)
        Me.gbDealTime.Controls.Add(Me.dtpDealEnd)
        Me.gbDealTime.Controls.Add(Me.ckbDealBegin)
        Me.gbDealTime.Controls.Add(Me.ckbDealEnd)
        Me.gbDealTime.Enabled = False
        Me.gbDealTime.Location = New System.Drawing.Point(28, 260)
        Me.gbDealTime.Name = "gbDealTime"
        Me.gbDealTime.Size = New System.Drawing.Size(184, 60)
        Me.gbDealTime.TabIndex = 9
        Me.gbDealTime.TabStop = False
        '
        'dtpDealBegin
        '
        Me.dtpDealBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDealBegin.Location = New System.Drawing.Point(60, 10)
        Me.dtpDealBegin.Name = "dtpDealBegin"
        Me.dtpDealBegin.Size = New System.Drawing.Size(120, 21)
        Me.dtpDealBegin.TabIndex = 1
        '
        'dtpDealEnd
        '
        Me.dtpDealEnd.CustomFormat = "yyyy-MM-dd"
        Me.dtpDealEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDealEnd.Location = New System.Drawing.Point(60, 34)
        Me.dtpDealEnd.Name = "dtpDealEnd"
        Me.dtpDealEnd.Size = New System.Drawing.Size(120, 21)
        Me.dtpDealEnd.TabIndex = 3
        '
        'ckbDealBegin
        '
        Me.ckbDealBegin.Checked = True
        Me.ckbDealBegin.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbDealBegin.Location = New System.Drawing.Point(6, 10)
        Me.ckbDealBegin.Name = "ckbDealBegin"
        Me.ckbDealBegin.Size = New System.Drawing.Size(50, 20)
        Me.ckbDealBegin.TabIndex = 0
        Me.ckbDealBegin.Text = "最早"
        Me.ckbDealBegin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ckbDealEnd
        '
        Me.ckbDealEnd.Checked = True
        Me.ckbDealEnd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbDealEnd.Location = New System.Drawing.Point(6, 34)
        Me.ckbDealEnd.Name = "ckbDealEnd"
        Me.ckbDealEnd.Size = New System.Drawing.Size(50, 20)
        Me.ckbDealEnd.TabIndex = 2
        Me.ckbDealEnd.Text = "最晚"
        Me.ckbDealEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ckbOtherTime
        '
        Me.ckbOtherTime.Location = New System.Drawing.Point(244, 240)
        Me.ckbOtherTime.Name = "ckbOtherTime"
        Me.ckbOtherTime.Size = New System.Drawing.Size(76, 20)
        Me.ckbOtherTime.TabIndex = 18
        Me.ckbOtherTime.Text = "其他时间"
        '
        'gbOtherTime
        '
        Me.gbOtherTime.Controls.Add(Me.dtpOtherBegin)
        Me.gbOtherTime.Controls.Add(Me.dtpOtherEnd)
        Me.gbOtherTime.Controls.Add(Me.ckbOtherBegin)
        Me.gbOtherTime.Controls.Add(Me.ckbOtherEnd)
        Me.gbOtherTime.Enabled = False
        Me.gbOtherTime.Location = New System.Drawing.Point(244, 260)
        Me.gbOtherTime.Name = "gbOtherTime"
        Me.gbOtherTime.Size = New System.Drawing.Size(184, 60)
        Me.gbOtherTime.TabIndex = 20
        Me.gbOtherTime.TabStop = False
        '
        'dtpOtherBegin
        '
        Me.dtpOtherBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpOtherBegin.Location = New System.Drawing.Point(60, 10)
        Me.dtpOtherBegin.Name = "dtpOtherBegin"
        Me.dtpOtherBegin.Size = New System.Drawing.Size(120, 21)
        Me.dtpOtherBegin.TabIndex = 1
        '
        'dtpOtherEnd
        '
        Me.dtpOtherEnd.CustomFormat = "yyyy-MM-dd"
        Me.dtpOtherEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpOtherEnd.Location = New System.Drawing.Point(60, 34)
        Me.dtpOtherEnd.Name = "dtpOtherEnd"
        Me.dtpOtherEnd.Size = New System.Drawing.Size(120, 21)
        Me.dtpOtherEnd.TabIndex = 3
        '
        'ckbOtherBegin
        '
        Me.ckbOtherBegin.Checked = True
        Me.ckbOtherBegin.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbOtherBegin.Location = New System.Drawing.Point(6, 10)
        Me.ckbOtherBegin.Name = "ckbOtherBegin"
        Me.ckbOtherBegin.Size = New System.Drawing.Size(50, 20)
        Me.ckbOtherBegin.TabIndex = 0
        Me.ckbOtherBegin.Text = "最早"
        Me.ckbOtherBegin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ckbOtherEnd
        '
        Me.ckbOtherEnd.Checked = True
        Me.ckbOtherEnd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbOtherEnd.Location = New System.Drawing.Point(6, 34)
        Me.ckbOtherEnd.Name = "ckbOtherEnd"
        Me.ckbOtherEnd.Size = New System.Drawing.Size(50, 20)
        Me.ckbOtherEnd.TabIndex = 2
        Me.ckbOtherEnd.Text = "最晚"
        Me.ckbOtherEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbOtherTime
        '
        Me.cbOtherTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOtherTime.Items.AddRange(New Object() {"出库时间", "转借时间", "发放时间", "操作时间"})
        Me.cbOtherTime.Location = New System.Drawing.Point(316, 240)
        Me.cbOtherTime.MaxDropDownItems = 20
        Me.cbOtherTime.Name = "cbOtherTime"
        Me.cbOtherTime.Size = New System.Drawing.Size(108, 20)
        Me.cbOtherTime.TabIndex = 19
        '
        'txtDealPerson
        '
        Me.txtDealPerson.Location = New System.Drawing.Point(84, 212)
        Me.txtDealPerson.MaxLength = 20
        Me.txtDealPerson.Name = "txtDealPerson"
        Me.txtDealPerson.Size = New System.Drawing.Size(130, 21)
        Me.txtDealPerson.TabIndex = 7
        Me.txtDealPerson.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(12, 212)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 229
        Me.Label8.Text = "经办人"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUsePerson
        '
        Me.txtUsePerson.Location = New System.Drawing.Point(292, 188)
        Me.txtUsePerson.MaxLength = 20
        Me.txtUsePerson.Name = "txtUsePerson"
        Me.txtUsePerson.Size = New System.Drawing.Size(130, 21)
        Me.txtUsePerson.TabIndex = 16
        Me.txtUsePerson.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(220, 188)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 20)
        Me.Label9.TabIndex = 231
        Me.Label9.Text = "使用人"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDrawPerson
        '
        Me.txtDrawPerson.Location = New System.Drawing.Point(292, 116)
        Me.txtDrawPerson.MaxLength = 20
        Me.txtDrawPerson.Name = "txtDrawPerson"
        Me.txtDrawPerson.Size = New System.Drawing.Size(130, 21)
        Me.txtDrawPerson.TabIndex = 13
        Me.txtDrawPerson.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(220, 116)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 20)
        Me.Label10.TabIndex = 235
        Me.Label10.Text = "领用人"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbDrawDept
        '
        Me.cbDrawDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDrawDept.Location = New System.Drawing.Point(292, 92)
        Me.cbDrawDept.MaxDropDownItems = 20
        Me.cbDrawDept.Name = "cbDrawDept"
        Me.cbDrawDept.Size = New System.Drawing.Size(130, 20)
        Me.cbDrawDept.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(220, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 20)
        Me.Label11.TabIndex = 233
        Me.Label11.Text = "领用部门"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSubPerson
        '
        Me.txtSubPerson.Location = New System.Drawing.Point(292, 164)
        Me.txtSubPerson.MaxLength = 20
        Me.txtSubPerson.Name = "txtSubPerson"
        Me.txtSubPerson.Size = New System.Drawing.Size(130, 21)
        Me.txtSubPerson.TabIndex = 15
        Me.txtSubPerson.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(220, 164)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 20)
        Me.Label12.TabIndex = 239
        Me.Label12.Text = "转借人"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbSubDept
        '
        Me.cbSubDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSubDept.Location = New System.Drawing.Point(292, 140)
        Me.cbSubDept.MaxDropDownItems = 20
        Me.cbSubDept.Name = "cbSubDept"
        Me.cbSubDept.Size = New System.Drawing.Size(130, 20)
        Me.cbSubDept.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(220, 140)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 20)
        Me.Label13.TabIndex = 237
        Me.Label13.Text = "转借部门"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOperPerson
        '
        Me.txtOperPerson.Location = New System.Drawing.Point(292, 212)
        Me.txtOperPerson.MaxLength = 20
        Me.txtOperPerson.Name = "txtOperPerson"
        Me.txtOperPerson.Size = New System.Drawing.Size(130, 21)
        Me.txtOperPerson.TabIndex = 17
        Me.txtOperPerson.Text = ""
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(220, 212)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 20)
        Me.Label14.TabIndex = 241
        Me.Label14.Text = "操作人"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(252, 436)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 23
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(184, 436)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 22
        Me.btSave.Text = "确定"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ckbSealTime)
        Me.GroupBox1.Controls.Add(Me.gbSealTime)
        Me.GroupBox1.Controls.Add(Me.txtContainer)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtVoyage)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtShip)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 328)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(424, 100)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "施封情况"
        '
        'ckbSealTime
        '
        Me.ckbSealTime.Location = New System.Drawing.Point(236, 16)
        Me.ckbSealTime.Name = "ckbSealTime"
        Me.ckbSealTime.Size = New System.Drawing.Size(80, 20)
        Me.ckbSealTime.TabIndex = 3
        Me.ckbSealTime.Text = "确定时间"
        Me.ckbSealTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbSealTime
        '
        Me.gbSealTime.Controls.Add(Me.dtpSealBegin)
        Me.gbSealTime.Controls.Add(Me.dtpSealEnd)
        Me.gbSealTime.Controls.Add(Me.ckbSealBegin)
        Me.gbSealTime.Controls.Add(Me.ckbSealEnd)
        Me.gbSealTime.Enabled = False
        Me.gbSealTime.Location = New System.Drawing.Point(232, 36)
        Me.gbSealTime.Name = "gbSealTime"
        Me.gbSealTime.Size = New System.Drawing.Size(184, 60)
        Me.gbSealTime.TabIndex = 4
        Me.gbSealTime.TabStop = False
        '
        'dtpSealBegin
        '
        Me.dtpSealBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSealBegin.Location = New System.Drawing.Point(60, 10)
        Me.dtpSealBegin.Name = "dtpSealBegin"
        Me.dtpSealBegin.Size = New System.Drawing.Size(120, 21)
        Me.dtpSealBegin.TabIndex = 1
        '
        'dtpSealEnd
        '
        Me.dtpSealEnd.CustomFormat = "yyyy-MM-dd"
        Me.dtpSealEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSealEnd.Location = New System.Drawing.Point(60, 34)
        Me.dtpSealEnd.Name = "dtpSealEnd"
        Me.dtpSealEnd.Size = New System.Drawing.Size(120, 21)
        Me.dtpSealEnd.TabIndex = 3
        '
        'ckbSealBegin
        '
        Me.ckbSealBegin.Checked = True
        Me.ckbSealBegin.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbSealBegin.Location = New System.Drawing.Point(6, 10)
        Me.ckbSealBegin.Name = "ckbSealBegin"
        Me.ckbSealBegin.Size = New System.Drawing.Size(50, 20)
        Me.ckbSealBegin.TabIndex = 0
        Me.ckbSealBegin.Text = "最早"
        Me.ckbSealBegin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ckbSealEnd
        '
        Me.ckbSealEnd.Checked = True
        Me.ckbSealEnd.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbSealEnd.Location = New System.Drawing.Point(6, 34)
        Me.ckbSealEnd.Name = "ckbSealEnd"
        Me.ckbSealEnd.Size = New System.Drawing.Size(50, 20)
        Me.ckbSealEnd.TabIndex = 2
        Me.ckbSealEnd.Text = "最晚"
        Me.ckbSealEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtContainer
        '
        Me.txtContainer.Location = New System.Drawing.Point(72, 72)
        Me.txtContainer.MaxLength = 11
        Me.txtContainer.Name = "txtContainer"
        Me.txtContainer.Size = New System.Drawing.Size(130, 21)
        Me.txtContainer.TabIndex = 2
        Me.txtContainer.Text = ""
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(8, 76)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 18)
        Me.Label15.TabIndex = 208
        Me.Label15.Text = "箱号舱号"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(72, 44)
        Me.txtVoyage.MaxLength = 6
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(130, 21)
        Me.txtVoyage.TabIndex = 1
        Me.txtVoyage.Text = ""
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(8, 44)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 18)
        Me.Label16.TabIndex = 206
        Me.Label16.Text = "航次"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShip
        '
        Me.txtShip.Location = New System.Drawing.Point(72, 16)
        Me.txtShip.MaxLength = 40
        Me.txtShip.Name = "txtShip"
        Me.txtShip.Size = New System.Drawing.Size(130, 21)
        Me.txtShip.TabIndex = 0
        Me.txtShip.Text = ""
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(8, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 18)
        Me.Label17.TabIndex = 204
        Me.Label17.Text = "船码船名"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmSealInquire_Select
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(450, 467)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.txtOperPerson)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtSubPerson)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbSubDept)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtDrawPerson)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbDrawDept)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtUsePerson)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDealPerson)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbOtherTime)
        Me.Controls.Add(Me.ckbOtherTime)
        Me.Controls.Add(Me.gbOtherTime)
        Me.Controls.Add(Me.ckbDealTime)
        Me.Controls.Add(Me.gbDealTime)
        Me.Controls.Add(Me.ckbInTime)
        Me.Controls.Add(Me.gbInTime)
        Me.Controls.Add(Me.cbSub)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbLogoff)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbUse)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbDept)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbSealState)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSealNOEnd)
        Me.Controls.Add(Me.txtSealNOBegin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSealInquire_Select"
        Me.ShowInTaskbar = False
        Me.Text = "铅封查询 条件"
        Me.gbInTime.ResumeLayout(False)
        Me.gbDealTime.ResumeLayout(False)
        Me.gbOtherTime.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.gbSealTime.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public blFlag As Boolean
    Public strCondition As String  '查询条件

    Private Sub FrmSealInquire_Select_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sqlDept As String
        Dim dvDept As DataView
        Dim dvDrawDept As DataView
        Dim dvSubDept As DataView
        sqlDept = "select dept_code,dept_name from department where dept_code = '" & G_Dept_Oper & "' or dept_code='00' or Dept_Code like '26.1[12].1[1-5]'"
        dvDept = Filldata(sqlDept)
        dvDrawDept = dvDept.Table.Copy().DefaultView
        dvSubDept = dvDept.Table.Copy().DefaultView
        Me.cbDept.DataSource = dvDept
        Me.cbDept.DisplayMember = "dept_name"
        Me.cbDept.ValueMember = "dept_code"
        Me.cbDrawDept.DataSource = dvDrawDept
        Me.cbDrawDept.DisplayMember = "dept_name"
        Me.cbDrawDept.ValueMember = "dept_code"
        Me.cbSubDept.DataSource = dvSubDept
        Me.cbSubDept.DisplayMember = "dept_name"
        Me.cbSubDept.ValueMember = "dept_code"
        If G_DeptCode = G_Dept_Oper OrElse G_DeptCode = "26" OrElse G_DeptCode = "26.01" OrElse G_DeptCode = "26.13" Then
            Me.cbDept.Enabled = True
            Me.cbDrawDept.Enabled = True
            Me.cbSubDept.Enabled = True
        Else
            Me.cbDept.Enabled = False
            Me.cbDrawDept.Enabled = False
            Me.cbSubDept.Enabled = False
        End If
        Me.cbSealState.SelectedIndex = 0
        Me.cbSub.SelectedIndex = 0
        Me.cbUse.SelectedIndex = 0
        Me.cbLogoff.SelectedIndex = 0
        Me.cbOtherTime.SelectedIndex = 0

        strCondition = "1=1"
    End Sub

    Private Function VerifySealNOInput(ByVal strSealNOBegin As String, ByVal strSealNOEnd As String) As Boolean
        '铅封号格式验证
        Dim i, j, iLength1, iLength2 As Short
        Dim strSealNO, strNOBegin, strNOEnd As String
        Dim c1, c2 As Char
        Dim flag As Boolean = False
        iLength1 = Len(strSealNOBegin)
        iLength2 = Len(strSealNOEnd)

        If iLength1 = iLength2 And iLength1 > 0 Then
            For i = iLength1 To 1 Step -1
                c1 = Mid(strSealNOBegin, i, 1)
                c2 = Mid(strSealNOEnd, i, 1)
                If (c1 >= "0" And c1 <= "9") And (c2 >= "0" And c2 <= "9") Then

                Else
                    If (c1 >= "A" And c1 <= "Z") And (c2 >= "A" And c2 <= "Z") Then
                        Exit For
                    Else
                        MessageBox.Show("铅封号不合法！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        Return False
                        Exit Function
                    End If
                End If
            Next

            If i >= 0 And i < iLength1 Then
                If Mid(strSealNOBegin, i + 1) <= Mid(strSealNOEnd, i + 1) Then
                    '后部通过验证
                Else
                    MessageBox.Show("铅封起号必须位于止号之前！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Return False
                    Exit Function
                End If
                'ElseIf i < 1 Then
                '    MessageBox.Show("铅封号不能全为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                '    Return False
                '    Exit Function
            ElseIf i = iLength1 Then
                MessageBox.Show("铅封号后部不能为字母！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Return False
                Exit Function
            End If

            For j = 1 To i
                c1 = Mid(strSealNOBegin, j, 1)
                c2 = Mid(strSealNOEnd, j, 1)
                If (c1 >= "A" And c1 <= "Z") And (c2 >= "A" And c2 <= "Z") Then

                Else
                    If (c1 >= "0" And c1 <= "9") And (c2 >= "0" And c2 <= "9") Then

                    Else
                        MessageBox.Show("铅封号不合法！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        Return False
                        Exit Function
                    End If
                End If
            Next

            If StrComp(Mid(strSealNOBegin, 1, i), Mid(strSealNOEnd, 1, i), CompareMethod.Text) = 0 Then
                flag = True             '全部通过验证
                Return flag
            Else
                MessageBox.Show("铅封起止号前部不一致！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Return False
                Exit Function
            End If
        Else
            If iLength1 <> iLength2 Then
                MessageBox.Show("铅封起止号长度不一致！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
            If iLength1 <= 0 Then
                MessageBox.Show("铅封起号不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
            Return False
            Exit Function
        End If

    End Function

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim strSealNoBegin, strSealNoEnd As String
        strSealNOBegin = UCase(Trim(txtSealNOBegin.Text))
        strSealNOEnd = UCase(Trim(txtSealNOEnd.Text))
        If strSealNOBegin <> "" Then
            If strSealNOEnd <> "" Then
                If StrComp(strSealNOBegin, strSealNOEnd, CompareMethod.Text) <> 0 Then  '一段铅封号
                    If VerifySealNOInput(strSealNOBegin, strSealNOEnd) Then     '铅封起止号通过验证
                        strCondition = strCondition & " and SEALNO >= '" & strSealNoBegin & "' and SEALNO <= '" & strSealNoEnd & "'"
                    Else            '铅封起止号不能通过验证
                        Exit Sub
                    End If
                Else        '单个铅封号
                    strCondition = strCondition & " and SEALNO = '" & strSealNoBegin & "'"
                End If
            Else    '单个铅封号
                strCondition = strCondition & " and SEALNO = '" & strSealNoBegin & "'"
            End If
        Else
            If strSealNOEnd = "" Then   '不从铅封号查询
            Else
                Me.txtSealNOEnd.Focus()
                MessageBox.Show("单号铅封应在铅封起号文本框中。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If
        Dim strState As String
        If Me.cbSealState.SelectedIndex > 0 Then    '发放状态
            Select Case Me.cbSealState.SelectedIndex
                Case 1
                    strState = "0"
                Case 2
                    strState = "1"
                Case 3
                    strState = "2"
                Case Else
                    Exit Select
            End Select
            strCondition = strCondition & " and SEAL_STATE='" & strState & "'"
        End If
        If Me.cbSub.SelectedIndex > 0 Then  '是否转借
            Select Case Me.cbSub.SelectedIndex
                Case 1
                    strState = "1"
                Case Else
                    strState = "0"
            End Select
            strCondition = strCondition & " and Subtenancy_Mark='" & strState & "'"
        End If
        If Me.cbUse.SelectedIndex > 0 Then  '使用状态
            Select Case Me.cbUse.SelectedIndex
                Case 1
                    strState = "0"
                Case Else
                    strState = "1"
            End Select
            strCondition = strCondition & " and Use_Mark='" & strState & "'"
        End If
        If Me.cbLogoff.SelectedIndex > 0 Then   '注销状态
            Select Case Me.cbLogoff.SelectedIndex
                Case 1
                    strState = "0"
                Case Else
                    strState = "1"
            End Select
            strCondition = strCondition & " and Logout_Mark='" & strState & "'"
        End If
        If Me.cbDept.Enabled AndAlso Me.cbDept.SelectedValue <> "00" Then
            strCondition = strCondition & " and Dept_Code='" & Me.cbDept.SelectedValue & "'"
        End If
        If Me.txtDealPerson.Text.Length > 0 Then
            strCondition = strCondition & " and USER_PERSON='" & Me.txtDealPerson.Text & "'"
        End If
        If Me.ckbDealTime.Checked Then  '经办时间
            If Me.ckbDealBegin.Checked Then
                strCondition = strCondition & " and Out_Time>='" & Me.dtpDealBegin.Value.Date() & "'"
            End If
            If Me.ckbDealEnd.Checked Then
                strCondition = strCondition & " and Out_Time<'" & Me.dtpDealEnd.Value.Date().AddDays(1) & "'"
            End If
        End If
        If Me.ckbInTime.Checked Then    '入库时间
            If Me.ckbInBegin.Checked Then
                strCondition = strCondition & " and TIME_IN>='" & Me.dtpInBegin.Value.Date() & "'"
            End If
            If Me.ckbInEnd.Checked Then
                strCondition = strCondition & " and TIME_IN<'" & Me.dtpInEnd.Value.Date().AddDays(1) & "'"
            End If
        End If
        If Me.cbDrawDept.Enabled AndAlso Me.cbDrawDept.SelectedValue <> "00" Then
            strCondition = strCondition & " and Out_Dept='" & Me.cbDrawDept.Text & "'"
        End If
        If Me.txtDrawPerson.Text.Length > 0 Then
            strCondition = strCondition & " and LEAD_PERSON='" & Me.txtDrawPerson.Text & "'"
        End If
        If Me.cbSubDept.Enabled AndAlso Me.cbSubDept.SelectedValue <> "00" Then
            strCondition = strCondition & " and Sub_deptName='" & Me.cbSubDept.Text & "'"
        End If
        If Me.txtSubPerson.Text.Length > 0 Then
            strCondition = strCondition & " and Sub_Man='" & Me.txtSubPerson.Text & "'"
        End If
        If Me.txtUsePerson.Text.Length > 0 Then
            strCondition = strCondition & " and Two_Man='" & Me.txtUsePerson.Text & "'"
        End If
        If Me.txtOperPerson.Text.Length > 0 Then
            strCondition = strCondition & " and USER_NAME='" & Me.txtOperPerson.Text & "'"
        End If
        If Me.ckbOtherTime.Checked Then    '其他时间
            Dim strOtherTimeName As String
            Select Case Me.cbOtherTime.SelectedIndex
                Case 0
                    strOtherTimeName = "TIME_OUT"
                Case 1
                    strOtherTimeName = "Sub_Time"
                Case 2
                    strOtherTimeName = "Two_Time"
                Case 3
                    strOtherTimeName = "Oper_Time"
            End Select
            If Me.ckbOtherBegin.Checked Then
                strCondition = strCondition & " and " & strOtherTimeName & ">='" & Me.dtpOtherBegin.Value.Date() & "'"
            End If
            If Me.ckbOtherEnd.Checked Then
                strCondition = strCondition & " and " & strOtherTimeName & "<'" & Me.dtpOtherEnd.Value.Date().AddDays(1) & "'"
            End If
        End If
        If Me.txtShip.Text <> "" Then
            strCondition = strCondition & " and ShipName like '%" & Me.txtShip.Text & "%'"
        End If
        If Me.txtVoyage.Text <> "" Then
            strCondition = strCondition & " and Voyage = '" & Me.txtVoyage.Text & "'"
        End If
        If Me.txtContainer.Text <> "" Then
            strCondition = strCondition & " and Container_No like '%" & Me.txtContainer.Text & "%'"
        End If
        If Me.ckbSealTime.Checked Then    '施封时间
            If Me.ckbSealBegin.Checked Then
                strCondition = strCondition & " and SEALDATE>='" & Me.dtpSealBegin.Value.Date() & "'"
            End If
            If Me.ckbSealEnd.Checked Then
                strCondition = strCondition & " and SEALDATE<'" & Me.dtpSealEnd.Value.Date().AddDays(1) & "'"
            End If
        End If
        blFlag = True
        Me.Close()
    End Sub

    Private Sub ckbDealTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbDealTime.CheckedChanged
        Me.gbDealTime.Enabled = Me.ckbDealTime.Checked
    End Sub

    Private Sub ckbDealBegin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbDealBegin.CheckedChanged
        Me.dtpDealBegin.Enabled = Me.ckbDealBegin.Checked
    End Sub

    Private Sub ckbDealEnd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbDealEnd.CheckedChanged
        Me.dtpDealEnd.Enabled = Me.ckbDealEnd.Checked
    End Sub

    Private Sub ckbInTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbInTime.CheckedChanged
        Me.gbInTime.Enabled = Me.ckbInTime.Checked
    End Sub

    Private Sub ckbInBegin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbInBegin.CheckedChanged
        Me.dtpInBegin.Enabled = Me.ckbInBegin.Checked
    End Sub

    Private Sub ckbInEnd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbInEnd.CheckedChanged
        Me.dtpInEnd.Enabled = Me.ckbInEnd.Checked
    End Sub

    Private Sub ckbOtherTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbOtherTime.CheckedChanged
        Me.gbOtherTime.Enabled = Me.ckbOtherTime.Checked
    End Sub

    Private Sub ckbOtherBegin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbOtherBegin.CheckedChanged
        Me.dtpOtherBegin.Enabled = Me.ckbOtherBegin.Checked
    End Sub

    Private Sub ckbOtherEnd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbOtherEnd.CheckedChanged
        Me.dtpOtherEnd.Enabled = Me.ckbOtherEnd.Checked
    End Sub

    Private Sub ckbSealTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbSealTime.CheckedChanged
        Me.gbSealTime.Enabled = Me.ckbSealTime.Checked
    End Sub

    Private Sub ckbSealBegin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbSealBegin.CheckedChanged
        Me.dtpSealBegin.Enabled = Me.ckbSealBegin.Checked
    End Sub

    Private Sub ckbSealEnd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbSealEnd.CheckedChanged
        Me.dtpSealEnd.Enabled = Me.ckbSealEnd.Checked
    End Sub

    Private Sub FrmSealInquire_Select_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        If sender Is Me.txtSealNOBegin Then
            Me.txtSealNOBegin.Text = Me.txtSealNOBegin.Text.Trim.ToUpper
        ElseIf sender Is Me.txtSealNOEnd Then
            Me.txtSealNOEnd.Text = Me.txtSealNOEnd.Text.Trim.ToUpper
        ElseIf sender Is Me.txtDealPerson Then
            Me.txtDealPerson.Text = Me.txtDealPerson.Text.Trim.ToUpper
        ElseIf sender Is Me.txtDrawPerson Then
            Me.txtDrawPerson.Text = Me.txtDrawPerson.Text.Trim.ToUpper
        ElseIf sender Is Me.txtSubPerson Then
            Me.txtSubPerson.Text = Me.txtSubPerson.Text.Trim.ToUpper
        ElseIf sender Is Me.txtUsePerson Then
            Me.txtUsePerson.Text = Me.txtUsePerson.Text.Trim.ToUpper
        ElseIf sender Is Me.txtOperPerson Then
            Me.txtOperPerson.Text = Me.txtOperPerson.Text.Trim.ToUpper
        ElseIf sender Is Me.txtShip Then
            Me.txtShip.Text = Me.txtShip.Text.Trim.ToUpper
        ElseIf sender Is Me.txtVoyage Then
            Me.txtVoyage.Text = Me.txtVoyage.Text.Trim.ToUpper
        ElseIf sender Is Me.txtContainer Then
            Me.txtContainer.Text = Me.txtContainer.Text.Trim.ToUpper
        End If
    End Sub

    Private Sub FrmSealInquire_Select_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtSealNOBegin.Focused Then
                Me.txtSealNOEnd.Focus()
            ElseIf Me.txtSealNOEnd.Focused Then
                Me.cbSealState.Focus()
            ElseIf Me.cbSealState.Focused Then
                Me.cbSub.Focus()
            ElseIf Me.cbSub.Focused Then
                Me.cbUse.Focus()
            ElseIf Me.cbUse.Focused Then
                Me.cbLogoff.Focus()
            ElseIf Me.cbLogoff.Focused Then
                Me.cbDept.Focus()
            ElseIf Me.cbDept.Focused Then
                Me.txtDealPerson.Focus()
            ElseIf Me.txtDealPerson.Focused Then
                Me.ckbDealTime.Focus()

            ElseIf Me.ckbDealTime.Focused Then
                If Me.ckbDealTime.Checked Then
                    Me.ckbDealBegin.Focus()
                Else
                    Me.ckbInTime.Focus()
                End If
            ElseIf Me.ckbDealBegin.Focused Then
                If Me.ckbDealBegin.Checked Then
                    Me.dtpDealBegin.Focus()
                Else
                    Me.ckbDealEnd.Focus()
                End If
            ElseIf Me.dtpDealBegin.Focused Then
                Me.ckbDealEnd.Focus()
            ElseIf Me.ckbDealEnd.Focused Then
                If Me.ckbDealEnd.Checked Then
                    Me.dtpDealEnd.Focus()
                Else
                    Me.ckbInTime.Focus()
                End If
            ElseIf Me.dtpDealEnd.Focused Then
                Me.ckbInTime.Focus()

            ElseIf Me.ckbInTime.Focused Then
                If Me.ckbInTime.Checked Then
                    Me.ckbInBegin.Focus()
                Else
                    Me.cbDrawDept.Focus()
                End If
            ElseIf Me.ckbInBegin.Focused Then
                If Me.ckbInBegin.Checked Then
                    Me.dtpInBegin.Focus()
                Else
                    Me.ckbInEnd.Focus()
                End If
            ElseIf Me.dtpInBegin.Focused Then
                Me.ckbInEnd.Focus()
            ElseIf Me.ckbInEnd.Focused Then
                If Me.ckbInEnd.Checked Then
                    Me.dtpInEnd.Focus()
                Else
                    Me.cbDrawDept.Focus()
                End If
            ElseIf Me.dtpInEnd.Focused Then
                Me.cbDrawDept.Focus()

            ElseIf Me.cbDrawDept.Focused Then
                Me.txtDrawPerson.Focus()
            ElseIf Me.txtDrawPerson.Focused Then
                Me.cbSubDept.Focus()
            ElseIf Me.cbSubDept.Focused Then
                Me.txtSubPerson.Focus()
            ElseIf Me.txtSubPerson.Focused Then
                Me.txtUsePerson.Focus()
            ElseIf Me.txtUsePerson.Focused Then
                Me.txtOperPerson.Focus()
            ElseIf Me.txtOperPerson.Focused Then
                Me.ckbOtherTime.Focus()

            ElseIf Me.ckbOtherTime.Focused Then
                If Me.ckbOtherTime.Checked Then
                    Me.cbOtherTime.Focus()
                Else
                    Me.txtShip.Focus()
                End If
            ElseIf Me.cbOtherTime.Focused Then
                If Me.ckbOtherTime.Checked Then
                    Me.ckbOtherBegin.Focus()
                Else
                    Me.txtShip.Focus()
                End If
            ElseIf Me.ckbOtherBegin.Focused Then
                If Me.ckbOtherBegin.Checked Then
                    Me.dtpOtherBegin.Focus()
                Else
                    Me.ckbOtherEnd.Focus()
                End If
            ElseIf Me.dtpOtherBegin.Focused Then
                Me.ckbOtherEnd.Focus()
            ElseIf Me.ckbOtherEnd.Focused Then
                If Me.ckbOtherEnd.Checked Then
                    Me.dtpOtherEnd.Focus()
                Else
                    Me.txtShip.Focus()
                End If
            ElseIf Me.dtpOtherEnd.Focused Then
                Me.txtShip.Focus()

            ElseIf Me.txtShip.Focused Then
                Me.txtVoyage.Focus()
            ElseIf Me.txtVoyage.Focused Then
                Me.txtContainer.Focus()
            ElseIf Me.txtContainer.Focused Then
                Me.ckbSealTime.Focus()

            ElseIf Me.ckbSealTime.Focused Then
                If Me.ckbSealTime.Checked Then
                    Me.ckbSealBegin.Focus()
                Else
                    Me.btSave.Focus()
                    Me.btSave_Click(sender, e)
                End If
            ElseIf Me.ckbSealBegin.Focused Then
                If Me.ckbSealBegin.Checked Then
                    Me.dtpSealBegin.Focus()
                Else
                    Me.ckbSealEnd.Focus()
                End If
            ElseIf Me.dtpSealBegin.Focused Then
                Me.ckbSealEnd.Focus()
            ElseIf Me.ckbSealEnd.Focused Then
                If Me.ckbSealEnd.Checked Then
                    Me.dtpSealEnd.Focus()
                Else
                    Me.btSave.Focus()
                    Me.btSave_Click(sender, e)
                End If
            ElseIf Me.dtpSealEnd.Focused Then
                Me.btSave.Focus()
                Me.btSave_Click(sender, e)
            End If
        End If
    End Sub
End Class
