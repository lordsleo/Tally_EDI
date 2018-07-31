Imports TALLY.DBControl
Imports System.Web.Mail
Imports System.IO
Imports Microsoft.VisualBasic
Public Class FrmConLoadTallyNew_Add
    Inherits System.Windows.Forms.Form

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

        AddHandler txtNO.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler txtTallyClerk.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler txtMark.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler ccbGoods.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler txtGoodsSpec.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler txtAmount.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler txtTotalNetWeight.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler txtSize.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler cbState.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler ccbConsign.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler cbInOutPort.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler cbLoadPort.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler cbUnloadPort.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler cbWorkType.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler cbConLoadType.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler dtpTimeBegin.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler dtpListDate.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler ckbInTrade.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
    End Sub

    '������д��������������б�
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows ����������������
    Private components As System.ComponentModel.IContainer

    'ע�⣺���¹����� Windows ����������������
    '����ʹ�� Windows ����������޸Ĵ˹��̡�
    '��Ҫʹ�ô���༭���޸�����
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtShip As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBillNO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents C1DBGE As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents rbnDetailed As System.Windows.Forms.RadioButton
    Friend WithEvents txtNO As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtTotalNetWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSize As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cbGoodsCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtMark As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbConsign As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cbState As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cbInOutPort As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbUnloadPort As System.Windows.Forms.ComboBox
    Friend WithEvents cbLoadPort As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents cbWorkType As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbConLoadType As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbPlace As System.Windows.Forms.ComboBox
    Friend WithEvents dtpListDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTallyClerk As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rbnUsual As System.Windows.Forms.RadioButton
    Friend WithEvents txtGoodsSpec As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents btnGetData As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ckbInTrade As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOldVoyage As System.Windows.Forms.TextBox
    Friend WithEvents txtOldShip As System.Windows.Forms.TextBox
    Friend WithEvents txtOldShipName As System.Windows.Forms.TextBox
    Friend WithEvents txtOldBlno As System.Windows.Forms.TextBox
    Friend WithEvents C1DBD As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents ccbGoods As C1.Win.C1List.C1Combo
    Friend WithEvents ccbConsign As C1.Win.C1List.C1Combo
    Friend WithEvents Label10 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConLoadTallyNew_Add))
        Dim Style17 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style18 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style19 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style20 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style21 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style22 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style23 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style24 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtShip = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtBillNO = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.C1DBGE = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.rbnDetailed = New System.Windows.Forms.RadioButton
        Me.rbnUsual = New System.Windows.Forms.RadioButton
        Me.txtNO = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtTotalNetWeight = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtSize = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.cbGoodsCode = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtMark = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cbConsign = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.cbState = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.cbInOutPort = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cbUnloadPort = New System.Windows.Forms.ComboBox
        Me.cbLoadPort = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.cbWorkType = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.dtpTimeBegin = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbConLoadType = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbPlace = New System.Windows.Forms.ComboBox
        Me.dtpListDate = New System.Windows.Forms.DateTimePicker
        Me.txtTallyClerk = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtGoodsSpec = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.btnGetData = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ckbInTrade = New System.Windows.Forms.CheckBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtOldShipName = New System.Windows.Forms.TextBox
        Me.txtOldBlno = New System.Windows.Forms.TextBox
        Me.txtOldShip = New System.Windows.Forms.TextBox
        Me.txtOldVoyage = New System.Windows.Forms.TextBox
        Me.C1DBD = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.ccbGoods = New C1.Win.C1List.C1Combo
        Me.ccbConsign = New C1.Win.C1List.C1Combo
        Me.Label10 = New System.Windows.Forms.Label
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DBGE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.C1DBD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccbGoods, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccbConsign, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DBG
        '
        Me.C1DBG.AllowAddNew = True
        Me.C1DBG.AllowDelete = True
        Me.C1DBG.AllowSort = False
        Me.C1DBG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("C1DBG.Images"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 141)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.PageSettings = CType(resources.GetObject("C1DBG.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBG.RowHeight = 18
        Me.C1DBG.Size = New System.Drawing.Size(858, 177)
        Me.C1DBG.TabIndex = 5
        Me.C1DBG.PropBag = resources.GetString("C1DBG.PropBag")
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(178, 18)
        Me.txtVoyage.MaxLength = 6
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(100, 22)
        Me.txtVoyage.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(146, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 308
        Me.Label1.Text = "����"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShip
        '
        Me.txtShip.Location = New System.Drawing.Point(40, 18)
        Me.txtShip.MaxLength = 40
        Me.txtShip.Name = "txtShip"
        Me.txtShip.Size = New System.Drawing.Size(100, 22)
        Me.txtShip.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 307
        Me.Label2.Text = "����"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btQuit.Location = New System.Drawing.Point(694, 532)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 327
        Me.btQuit.Text = "�˳�"
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btSave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btSave.Font = New System.Drawing.Font("������", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btSave.Location = New System.Drawing.Point(428, 532)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 6
        Me.btSave.Text = "����"
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClear.Location = New System.Drawing.Point(142, 532)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(65, 24)
        Me.btnClear.TabIndex = 328
        Me.btnClear.Text = "���"
        '
        'txtShipName
        '
        Me.txtShipName.BackColor = System.Drawing.Color.Lavender
        Me.txtShipName.Location = New System.Drawing.Point(40, 42)
        Me.txtShipName.MaxLength = 40
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.ReadOnly = True
        Me.txtShipName.Size = New System.Drawing.Size(200, 22)
        Me.txtShipName.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 330
        Me.Label3.Text = "����"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBillNO
        '
        Me.txtBillNO.Location = New System.Drawing.Point(330, 18)
        Me.txtBillNO.MaxLength = 120
        Me.txtBillNO.Name = "txtBillNO"
        Me.txtBillNO.Size = New System.Drawing.Size(150, 22)
        Me.txtBillNO.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(284, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 343
        Me.Label4.Text = "�ᵥ��"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C1DBGE
        '
        Me.C1DBGE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1DBGE.CaptionHeight = 18
        Me.C1DBGE.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1DBGE.FetchRowStyles = True
        Me.C1DBGE.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.System
        Me.C1DBGE.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGE.Images.Add(CType(resources.GetObject("C1DBGE.Images"), System.Drawing.Image))
        Me.C1DBGE.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGE.Name = "C1DBGE"
        Me.C1DBGE.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGE.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGE.PreviewInfo.ZoomFactor = 75
        Me.C1DBGE.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGE.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGE.RowHeight = 18
        Me.C1DBGE.Size = New System.Drawing.Size(858, 138)
        Me.C1DBGE.TabIndex = 4
        Me.C1DBGE.PropBag = resources.GetString("C1DBGE.PropBag")
        '
        'rbnDetailed
        '
        Me.rbnDetailed.Location = New System.Drawing.Point(558, 18)
        Me.rbnDetailed.Name = "rbnDetailed"
        Me.rbnDetailed.Size = New System.Drawing.Size(82, 22)
        Me.rbnDetailed.TabIndex = 344
        Me.rbnDetailed.Text = "��ϸ�ᵥ"
        '
        'rbnUsual
        '
        Me.rbnUsual.Checked = True
        Me.rbnUsual.Location = New System.Drawing.Point(558, 44)
        Me.rbnUsual.Name = "rbnUsual"
        Me.rbnUsual.Size = New System.Drawing.Size(82, 22)
        Me.rbnUsual.TabIndex = 345
        Me.rbnUsual.TabStop = True
        Me.rbnUsual.Text = "һ���ᵥ"
        '
        'txtNO
        '
        Me.txtNO.Location = New System.Drawing.Point(78, 76)
        Me.txtNO.MaxLength = 20
        Me.txtNO.Name = "txtNO"
        Me.txtNO.ReadOnly = True
        Me.txtNO.Size = New System.Drawing.Size(130, 22)
        Me.txtNO.TabIndex = 411
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(-2, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 18)
        Me.Label5.TabIndex = 412
        Me.Label5.Text = "��������"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(390, 104)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(34, 20)
        Me.Label28.TabIndex = 467
        Me.Label28.Text = "����"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalNetWeight
        '
        Me.txtTotalNetWeight.Location = New System.Drawing.Point(290, 102)
        Me.txtTotalNetWeight.MaxLength = 10
        Me.txtTotalNetWeight.Name = "txtTotalNetWeight"
        Me.txtTotalNetWeight.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalNetWeight.TabIndex = 459
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(216, 104)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 18)
        Me.Label29.TabIndex = 466
        Me.Label29.Text = "�ܻ���"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(390, 130)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 20)
        Me.Label13.TabIndex = 465
        Me.Label13.Text = "����"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(290, 128)
        Me.txtSize.MaxLength = 10
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(100, 22)
        Me.txtSize.TabIndex = 460
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(216, 130)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 18)
        Me.Label19.TabIndex = 464
        Me.Label19.Text = "�ܳ���"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(290, 76)
        Me.txtAmount.MaxLength = 10
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(130, 22)
        Me.txtAmount.TabIndex = 458
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(216, 78)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 18)
        Me.Label25.TabIndex = 463
        Me.Label25.Text = "�ܼ���"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbGoodsCode
        '
        Me.cbGoodsCode.Location = New System.Drawing.Point(172, 180)
        Me.cbGoodsCode.MaxDropDownItems = 20
        Me.cbGoodsCode.MaxLength = 60
        Me.cbGoodsCode.Name = "cbGoodsCode"
        Me.cbGoodsCode.Size = New System.Drawing.Size(130, 21)
        Me.cbGoodsCode.TabIndex = 457
        Me.cbGoodsCode.Visible = False
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(4, 130)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 18)
        Me.Label17.TabIndex = 462
        Me.Label17.Text = "����"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(78, 102)
        Me.txtMark.MaxLength = 20
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(130, 22)
        Me.txtMark.TabIndex = 456
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(4, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 461
        Me.Label9.Text = "��־"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbConsign
        '
        Me.cbConsign.Location = New System.Drawing.Point(634, 182)
        Me.cbConsign.MaxDropDownItems = 20
        Me.cbConsign.Name = "cbConsign"
        Me.cbConsign.Size = New System.Drawing.Size(130, 21)
        Me.cbConsign.TabIndex = 469
        Me.cbConsign.Visible = False
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(428, 80)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 18)
        Me.Label22.TabIndex = 471
        Me.Label22.Text = "ί�е�λ"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbState
        '
        Me.cbState.Items.AddRange(New Object() {"", "ȫ��װ��", "����װ��", "����"})
        Me.cbState.Location = New System.Drawing.Point(290, 154)
        Me.cbState.MaxDropDownItems = 20
        Me.cbState.Name = "cbState"
        Me.cbState.Size = New System.Drawing.Size(130, 21)
        Me.cbState.TabIndex = 468
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(216, 156)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 18)
        Me.Label21.TabIndex = 470
        Me.Label21.Text = "���ﴦ��"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbInOutPort
        '
        Me.cbInOutPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbInOutPort.Location = New System.Drawing.Point(502, 104)
        Me.cbInOutPort.MaxDropDownItems = 20
        Me.cbInOutPort.Name = "cbInOutPort"
        Me.cbInOutPort.Size = New System.Drawing.Size(130, 21)
        Me.cbInOutPort.TabIndex = 472
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(428, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 18)
        Me.Label12.TabIndex = 483
        Me.Label12.Text = "������"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbUnloadPort
        '
        Me.cbUnloadPort.Location = New System.Drawing.Point(502, 154)
        Me.cbUnloadPort.MaxDropDownItems = 20
        Me.cbUnloadPort.Name = "cbUnloadPort"
        Me.cbUnloadPort.Size = New System.Drawing.Size(130, 21)
        Me.cbUnloadPort.TabIndex = 474
        '
        'cbLoadPort
        '
        Me.cbLoadPort.Location = New System.Drawing.Point(502, 130)
        Me.cbLoadPort.MaxDropDownItems = 20
        Me.cbLoadPort.Name = "cbLoadPort"
        Me.cbLoadPort.Size = New System.Drawing.Size(130, 21)
        Me.cbLoadPort.TabIndex = 473
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(428, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 18)
        Me.Label11.TabIndex = 482
        Me.Label11.Text = "װ����"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(428, 156)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(72, 18)
        Me.Label32.TabIndex = 481
        Me.Label32.Text = "ж����"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbWorkType
        '
        Me.cbWorkType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWorkType.Items.AddRange(New Object() {"����״̬", "�ڿ�", "����", "����", "ע��"})
        Me.cbWorkType.Location = New System.Drawing.Point(712, 78)
        Me.cbWorkType.Name = "cbWorkType"
        Me.cbWorkType.Size = New System.Drawing.Size(130, 21)
        Me.cbWorkType.TabIndex = 475
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(638, 80)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 18)
        Me.Label18.TabIndex = 480
        Me.Label18.Text = "�������"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeBegin
        '
        Me.dtpTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeBegin.Location = New System.Drawing.Point(712, 126)
        Me.dtpTimeBegin.Name = "dtpTimeBegin"
        Me.dtpTimeBegin.Size = New System.Drawing.Size(130, 22)
        Me.dtpTimeBegin.TabIndex = 477
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(638, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 479
        Me.Label7.Text = "��ʼʱ��"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbConLoadType
        '
        Me.cbConLoadType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConLoadType.Items.AddRange(New Object() {"����״̬", "�ڿ�", "����", "����", "ע��"})
        Me.cbConLoadType.Location = New System.Drawing.Point(712, 102)
        Me.cbConLoadType.MaxDropDownItems = 20
        Me.cbConLoadType.Name = "cbConLoadType"
        Me.cbConLoadType.Size = New System.Drawing.Size(130, 21)
        Me.cbConLoadType.TabIndex = 476
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(638, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 478
        Me.Label6.Text = "��װ�����"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbPlace
        '
        Me.cbPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlace.Location = New System.Drawing.Point(342, 42)
        Me.cbPlace.Name = "cbPlace"
        Me.cbPlace.Size = New System.Drawing.Size(138, 21)
        Me.cbPlace.TabIndex = 484
        '
        'dtpListDate
        '
        Me.dtpListDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpListDate.Location = New System.Drawing.Point(712, 152)
        Me.dtpListDate.Name = "dtpListDate"
        Me.dtpListDate.Size = New System.Drawing.Size(130, 22)
        Me.dtpListDate.TabIndex = 486
        '
        'txtTallyClerk
        '
        Me.txtTallyClerk.Location = New System.Drawing.Point(502, 178)
        Me.txtTallyClerk.MaxLength = 10
        Me.txtTallyClerk.Name = "txtTallyClerk"
        Me.txtTallyClerk.Size = New System.Drawing.Size(130, 22)
        Me.txtTallyClerk.TabIndex = 485
        Me.txtTallyClerk.Visible = False
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("BatangChe", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(374, 180)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(126, 20)
        Me.Label15.TabIndex = 489
        Me.Label15.Text = "���ԱIAaBbOo10"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label15.Visible = False
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(638, 154)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 18)
        Me.Label14.TabIndex = 488
        Me.Label14.Text = "�Ƶ�����"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(284, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 487
        Me.Label8.Text = "�����ص�"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGoodsSpec
        '
        Me.txtGoodsSpec.Location = New System.Drawing.Point(78, 152)
        Me.txtGoodsSpec.MaxLength = 50
        Me.txtGoodsSpec.Name = "txtGoodsSpec"
        Me.txtGoodsSpec.Size = New System.Drawing.Size(130, 22)
        Me.txtGoodsSpec.TabIndex = 638
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(4, 154)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(72, 18)
        Me.Label37.TabIndex = 639
        Me.Label37.Text = "���"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnGetData
        '
        Me.btnGetData.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnGetData.Location = New System.Drawing.Point(486, 26)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New System.Drawing.Size(65, 24)
        Me.btnGetData.TabIndex = 640
        Me.btnGetData.Text = "����"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ckbInTrade)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(44, 174)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 34)
        Me.GroupBox1.TabIndex = 641
        Me.GroupBox1.TabStop = False
        '
        'ckbInTrade
        '
        Me.ckbInTrade.ForeColor = System.Drawing.Color.Red
        Me.ckbInTrade.Location = New System.Drawing.Point(8, 10)
        Me.ckbInTrade.Name = "ckbInTrade"
        Me.ckbInTrade.Size = New System.Drawing.Size(210, 22)
        Me.ckbInTrade.TabIndex = 0
        Me.ckbInTrade.Text = "��ó������֤���빴ѡ"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.C1DBG)
        Me.Panel1.Controls.Add(Me.Splitter1)
        Me.Panel1.Controls.Add(Me.C1DBGE)
        Me.Panel1.Location = New System.Drawing.Point(0, 208)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(858, 318)
        Me.Panel1.TabIndex = 642
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 138)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(858, 3)
        Me.Splitter1.TabIndex = 5
        Me.Splitter1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtOldShipName)
        Me.GroupBox2.Controls.Add(Me.txtOldBlno)
        Me.GroupBox2.Controls.Add(Me.txtOldShip)
        Me.GroupBox2.Controls.Add(Me.txtOldVoyage)
        Me.GroupBox2.Controls.Add(Me.cbPlace)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtVoyage)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtShip)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.rbnDetailed)
        Me.GroupBox2.Controls.Add(Me.txtShipName)
        Me.GroupBox2.Controls.Add(Me.rbnUsual)
        Me.GroupBox2.Controls.Add(Me.txtBillNO)
        Me.GroupBox2.Controls.Add(Me.btnGetData)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(854, 70)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "����"
        '
        'txtOldShipName
        '
        Me.txtOldShipName.BackColor = System.Drawing.Color.Lavender
        Me.txtOldShipName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOldShipName.Location = New System.Drawing.Point(730, 22)
        Me.txtOldShipName.MaxLength = 40
        Me.txtOldShipName.Name = "txtOldShipName"
        Me.txtOldShipName.ReadOnly = True
        Me.txtOldShipName.Size = New System.Drawing.Size(116, 15)
        Me.txtOldShipName.TabIndex = 644
        '
        'txtOldBlno
        '
        Me.txtOldBlno.BackColor = System.Drawing.Color.Lavender
        Me.txtOldBlno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOldBlno.Location = New System.Drawing.Point(730, 46)
        Me.txtOldBlno.MaxLength = 40
        Me.txtOldBlno.Name = "txtOldBlno"
        Me.txtOldBlno.ReadOnly = True
        Me.txtOldBlno.Size = New System.Drawing.Size(116, 15)
        Me.txtOldBlno.TabIndex = 643
        '
        'txtOldShip
        '
        Me.txtOldShip.BackColor = System.Drawing.Color.Lavender
        Me.txtOldShip.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOldShip.Location = New System.Drawing.Point(642, 22)
        Me.txtOldShip.MaxLength = 40
        Me.txtOldShip.Name = "txtOldShip"
        Me.txtOldShip.ReadOnly = True
        Me.txtOldShip.Size = New System.Drawing.Size(86, 15)
        Me.txtOldShip.TabIndex = 642
        '
        'txtOldVoyage
        '
        Me.txtOldVoyage.BackColor = System.Drawing.Color.Lavender
        Me.txtOldVoyage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOldVoyage.Location = New System.Drawing.Point(642, 46)
        Me.txtOldVoyage.MaxLength = 40
        Me.txtOldVoyage.Name = "txtOldVoyage"
        Me.txtOldVoyage.ReadOnly = True
        Me.txtOldVoyage.Size = New System.Drawing.Size(86, 15)
        Me.txtOldVoyage.TabIndex = 641
        '
        'C1DBD
        '
        Me.C1DBD.AllowColMove = True
        Me.C1DBD.AllowColSelect = True
        Me.C1DBD.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1DBD.AlternatingRows = False
        Me.C1DBD.CaptionHeight = 18
        Me.C1DBD.CaptionStyle = Style17
        Me.C1DBD.ColumnCaptionHeight = 18
        Me.C1DBD.ColumnFooterHeight = 18
        Me.C1DBD.EvenRowStyle = Style18
        Me.C1DBD.FetchRowStyles = False
        Me.C1DBD.FooterStyle = Style19
        Me.C1DBD.HeadingStyle = Style20
        Me.C1DBD.HighLightRowStyle = Style21
        Me.C1DBD.Images.Add(CType(resources.GetObject("C1DBD.Images"), System.Drawing.Image))
        Me.C1DBD.Location = New System.Drawing.Point(210, 176)
        Me.C1DBD.Name = "C1DBD"
        Me.C1DBD.OddRowStyle = Style22
        Me.C1DBD.RecordSelectorStyle = Style23
        Me.C1DBD.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1DBD.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.C1DBD.RowHeight = 16
        Me.C1DBD.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBD.ScrollTips = False
        Me.C1DBD.Size = New System.Drawing.Size(216, 142)
        Me.C1DBD.Style = Style24
        Me.C1DBD.TabIndex = 644
        Me.C1DBD.Text = "C1DBD"
        Me.C1DBD.Visible = False
        Me.C1DBD.PropBag = resources.GetString("C1DBD.PropBag")
        '
        'ccbGoods
        '
        Me.ccbGoods.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.ccbGoods.AutoDropDown = True
        Me.ccbGoods.Caption = ""
        Me.ccbGoods.CaptionHeight = 17
        Me.ccbGoods.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ccbGoods.ColumnCaptionHeight = 18
        Me.ccbGoods.ColumnFooterHeight = 18
        Me.ccbGoods.ContentHeight = 18
        Me.ccbGoods.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.ccbGoods.EditorBackColor = System.Drawing.SystemColors.Window
        Me.ccbGoods.EditorFont = New System.Drawing.Font("����", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ccbGoods.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.ccbGoods.EditorHeight = 18
        Me.ccbGoods.Images.Add(CType(resources.GetObject("ccbGoods.Images"), System.Drawing.Image))
        Me.ccbGoods.ItemHeight = 15
        Me.ccbGoods.Location = New System.Drawing.Point(78, 128)
        Me.ccbGoods.MatchEntryTimeout = CType(2000, Long)
        Me.ccbGoods.MaxDropDownItems = CType(20, Short)
        Me.ccbGoods.MaxLength = 32767
        Me.ccbGoods.MouseCursor = System.Windows.Forms.Cursors.Hand
        Me.ccbGoods.Name = "ccbGoods"
        Me.ccbGoods.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.ccbGoods.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.ccbGoods.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.ccbGoods.Size = New System.Drawing.Size(130, 24)
        Me.ccbGoods.TabIndex = 645
        Me.ccbGoods.PropBag = resources.GetString("ccbGoods.PropBag")
        '
        'ccbConsign
        '
        Me.ccbConsign.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.ccbConsign.AutoDropDown = True
        Me.ccbConsign.Caption = ""
        Me.ccbConsign.CaptionHeight = 17
        Me.ccbConsign.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ccbConsign.ColumnCaptionHeight = 18
        Me.ccbConsign.ColumnFooterHeight = 18
        Me.ccbConsign.ContentHeight = 18
        Me.ccbConsign.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.ccbConsign.EditorBackColor = System.Drawing.SystemColors.Window
        Me.ccbConsign.EditorFont = New System.Drawing.Font("����", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ccbConsign.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.ccbConsign.EditorHeight = 18
        Me.ccbConsign.Images.Add(CType(resources.GetObject("ccbConsign.Images"), System.Drawing.Image))
        Me.ccbConsign.ItemHeight = 15
        Me.ccbConsign.Location = New System.Drawing.Point(502, 78)
        Me.ccbConsign.MatchEntryTimeout = CType(2000, Long)
        Me.ccbConsign.MaxDropDownItems = CType(20, Short)
        Me.ccbConsign.MaxLength = 32767
        Me.ccbConsign.MouseCursor = System.Windows.Forms.Cursors.Hand
        Me.ccbConsign.Name = "ccbConsign"
        Me.ccbConsign.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.ccbConsign.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.ccbConsign.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.ccbConsign.Size = New System.Drawing.Size(130, 24)
        Me.ccbConsign.TabIndex = 646
        Me.ccbConsign.PropBag = resources.GetString("ccbConsign.PropBag")
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Bisque
        Me.Label10.Font = New System.Drawing.Font("����", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.Label10.Location = New System.Drawing.Point(376, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 20)
        Me.Label10.TabIndex = 647
        Me.Label10.Text = "���ԱAaBbOo10"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Visible = False
        '
        'FrmConLoadTallyNew_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(858, 559)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cbGoodsCode)
        Me.Controls.Add(Me.ccbConsign)
        Me.Controls.Add(Me.ccbGoods)
        Me.Controls.Add(Me.C1DBD)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtGoodsSpec)
        Me.Controls.Add(Me.txtTallyClerk)
        Me.Controls.Add(Me.txtTotalNetWeight)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtMark)
        Me.Controls.Add(Me.txtNO)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.dtpListDate)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cbInOutPort)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbUnloadPort)
        Me.Controls.Add(Me.cbLoadPort)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.cbWorkType)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.dtpTimeBegin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbConLoadType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbConsign)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cbState)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label10)
        Me.Font = New System.Drawing.Font("������", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConLoadTallyNew_Add"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "װ��������Ϣ ����"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DBGE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.C1DBD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccbGoods, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccbConsign, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim dsSubTable As New DataSet()
    Dim sqlSubTableda As New SqlClient.SqlDataAdapter()
    Public Shared strShip, strVoyage, strBillNo, strYCode As String 'strbillno �ǽ����½��ǣ��˳�ʱҪ���� Nothing 
    Public Shared dvcodeYard As New DataView()

    Dim sqlShipCode As String
    Dim dvShipCode As New DataView
    Dim shipMark As Boolean

    Dim sqlConsign As String
    Dim dvConsign As DataView
    Dim dvLoadPort As New DataView
    Dim dvUnloadPort As New DataView
    Dim sqlBill As String
    Dim dsBill As New DataSet
    Dim dvBill As New DataView
    Dim daBill As New SqlClient.SqlDataAdapter

    Dim row As DataRow
    Dim BillSign As Boolean
    Dim billEnable As Boolean
    Public blSave As Boolean

    Private Sub FrmConLoadTallyNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sqlYard As String
        sqlYard = "SELECT Code_Yard_ID, Code_Yard_Name, CodePrefix,DeptCode FROM Code_Yard where DeptCode like '" & G_DeptCode & "%' ORDER BY Code_Yard_ID"
        cbPlace.DataSource = Filldata(sqlYard)
        cbPlace.DisplayMember = "Code_Yard_Name"
        cbPlace.ValueMember = "Code_Yard_ID"

        strShip = FrmConLoadTally.strShip.ToUpper
        strVoyage = FrmConLoadTally.strVoyage
        strBillNo = FrmConLoadTally.strBillNo
        strYCode = FrmConLoadTally.strCodeYard
        Me.txtShip.Text = strShip
        Me.txtVoyage.Text = strVoyage
        Me.txtBillNO.Text = strBillNo
        Me.cbPlace.SelectedValue = strYCode

        sqlShipCode = "SELECT SPCODE, CHI_VESSEL,ENG_VESSEL FROM Code_SHIPNAME WHERE SPCODE = '" & strShip & "'"
        dvShipCode = Filldata(sqlShipCode)
        If dvShipCode.Count > 0 Then
            strShip = dvShipCode(0)("SPCODE")
            Me.txtShip.Text = strShip
            If Not IsDBNull(dvShipCode(0)("CHI_VESSEL")) Then
                Me.txtShipName.Text = dvShipCode(0)("CHI_VESSEL")
            End If
            If Not IsDBNull(dvShipCode(0)("ENG_VESSEL")) Then
                Me.txtShipName.Text += "/" & dvShipCode(0)("ENG_VESSEL")
            End If
            shipMark = True
        End If

        'Dim sqlCodeYard As String = "" '�ݲ��Ŵ���õ���վ����
        'sqlCodeYard = "SELECT Code_Yard_ID, Code_Yard_Name, CodePrefix, CodeMax, CodeYear, DeptCode FROM Code_Yard WHERE DeptCode = '" & G_DeptCode & "'"
        'dvcodeYard = Filldata(sqlCodeYard)
        'If dvcodeYard.Count > 0 Then
        '    strYCode = dvcodeYard(0)("Code_Yard_ID")
        'End If
        Call InitBill()  '˳���ܴ�
        Call FillBill()
        Call GetConExist()
        Call InitSubTable()
        Me.txtShip.Focus()
        SetC1CurrentCellStyle(Me.C1DBG)
        SetC1CurrentCellStyle(Me.C1DBGE)
        SetC1SelectedRowStyle(Me.C1DBG)
        SetC1SelectedRowStyle(Me.C1DBGE)
    End Sub

    Private Sub InitBill()
        dtpListDate.CustomFormat = "yy-MM-dd"
        dtpTimeBegin.CustomFormat = "yy-MM-dd HH:mm"

        Dim dvWorkType As New DataView
        Dim sqlWorkType As String
        sqlWorkType = "SELECT WorkType_ID, WorkType_Name FROM Code_ConLoadContainer_Type"
        dvWorkType = Filldata(sqlWorkType)
        cbWorkType.DataSource = dvWorkType
        cbWorkType.DisplayMember = "WorkType_Name"
        cbWorkType.ValueMember = "WorkType_ID"

        Dim sqlConLoadType As String
        sqlConLoadType = "select Code_Tally_Type,Name_Tally_Type from Code_Tally_Type "
        cbConLoadType.DataSource = Filldata(sqlConLoadType)
        cbConLoadType.DisplayMember = "Name_Tally_Type"
        cbConLoadType.ValueMember = "Code_Tally_Type"

        sqlConsign = "SELECT CODE_SHIP_AGENT, SHIPAGENT_SHORT, SHIPAGENT_ENG FROM CODE_SHIP_AGENT where Mark <> '1' OR Mark IS NULL ORDER BY SHIPAGENT_SHORT"
        dvConsign = Filldata(sqlConsign)
        ccbConsign.DataSource = dvConsign
        ccbConsign.DisplayMember = "SHIPAGENT_SHORT"
        ccbConsign.ValueMember = "CODE_SHIP_AGENT"
        Me.ccbConsign.ColumnHeaders = False
        Me.ccbConsign.Splits(0).DisplayColumns("CODE_SHIP_AGENT").Visible = False
        Me.ccbConsign.Splits(0).DisplayColumns("SHIPAGENT_SHORT").AutoSize()
        Me.ccbConsign.Splits(0).DisplayColumns("SHIPAGENT_ENG").AutoSize()
        Me.ccbConsign.DropDownWidth = Me.ccbConsign.Splits(0).DisplayColumns("SHIPAGENT_SHORT").Width + Me.ccbConsign.Splits(0).DisplayColumns("SHIPAGENT_ENG").Width + 20

        Dim dvCodeGoods As New DataView
        Dim sqlCodeGoods As String
        sqlCodeGoods = "select Code,Goods from CodeGoods where ConLoadMark='1' order by Goods"
        dvCodeGoods = Filldata(sqlCodeGoods)
        Me.ccbGoods.DataSource = dvCodeGoods
        Me.ccbGoods.DisplayMember = "Goods"
        Me.ccbGoods.ValueMember = "Code"
        Me.ccbGoods.ColumnHeaders = False
        Me.ccbGoods.Splits(0).DisplayColumns("Code").Visible = False
        Me.ccbGoods.Splits(0).DisplayColumns("Goods").AutoSize()
        Me.ccbGoods.DropDownWidth = Me.ccbGoods.Splits(0).DisplayColumns("Goods").Width + 20

        Dim sqlCodePort As String
        sqlCodePort = "SELECT CODE_PORT, PORT_CHA, PORT_Short FROM CODE_PORT ORDER BY PORT_CHA"

        dvLoadPort = Filldata(sqlCodePort)
        Me.cbLoadPort.DataSource = dvLoadPort
        Me.cbLoadPort.DisplayMember = "PORT_CHA"
        Me.cbLoadPort.ValueMember = "CODE_PORT"

        dvUnloadPort = Filldata(sqlCodePort)
        Me.cbUnloadPort.DataSource = dvUnloadPort
        Me.cbUnloadPort.DisplayMember = "PORT_CHA"
        Me.cbUnloadPort.ValueMember = "CODE_PORT"

        Dim dvInOutPort As New DataView
        Dim sqlInOutPort As String
        sqlInOutPort = "SELECT InOutPort, InOutPort_Name FROM Code_InOutPort"
        dvInOutPort = Filldata(sqlInOutPort)
        Me.cbInOutPort.DataSource = dvInOutPort
        Me.cbInOutPort.DisplayMember = "InOutPort_Name"
        Me.cbInOutPort.ValueMember = "InOutPort"

    End Sub

    Public Sub FillBill()
        On Error Resume Next
        '���ݴ��������ᵥ�ų�վȷ���ᵥ�Ƿ���ڣ���������ʾ�����򲻹ܲ�ʹ'��ϸ�ᵥ'��Ч
        sqlBill = "SELECT * FROM CON_LOAD_TALLY WHERE CHI_VESSEL = '" & strShip & "' AND Voyage = '" & strVoyage & "' AND BLNO = '" & strBillNo & "' AND WORK_PLACE = '" & strYCode & "'"
        dvBill = Updatedata(daBill, sqlBill, dsBill)

        If dvBill.Count > 0 Then
            If dvBill(0)("StateB") <= 1 Then
                If dsBill.Tables(0).Rows(0)("TradeMark") = "1" Then '����ó��
                    Me.ckbInTrade.Checked = True
                Else
                    Me.ckbInTrade.Checked = False
                End If
                'cbPlace.SelectedValue = dsBill.Tables(0).Rows(0).Item("WORK_PLACE")
                txtNO.Text = dsBill.Tables(0).Rows(0).Item("NO")
                txtTallyClerk.Text = dsBill.Tables(0).Rows(0).Item("TALLY_CLERK").ToString

                txtMark.Text = dsBill.Tables(0).Rows(0).Item("MARK").ToString

                'ԭ��Ϊ�˱��Ᵽ�����ݲ�������ComBox��Value��Ա��ʱ��ÿ���޸�ȴ�����һ����Ա��������ԭ����ֵ
                '����C1��Combo�������������⣬����ȡ�����á�
                Me.ccbGoods.SelectedIndex = -1
                Me.ccbGoods.Text = dsBill.Tables(0).Rows(0).Item("GoodsCha").ToString
                Me.txtGoodsSpec.Text = dsBill.Tables(0).Rows(0).Item("GoodsSpec").ToString
                txtAmount.Text = dsBill.Tables(0).Rows(0).Item("AMOUNT").ToString
                txtTotalNetWeight.Text = dsBill.Tables(0).Rows(0)("TOTALNetWEIGHT").ToString
                txtSize.Text = dsBill.Tables(0).Rows(0).Item("SIZE_MEASURE").ToString

                cbState.Text = dsBill.Tables(0).Rows(0).Item("STATE").ToString
                ccbConsign.SelectedValue = dsBill.Tables(0).Rows(0).Item("CODE_CON_CONSIGN")
                Me.cbInOutPort.SelectedValue = dsBill.Tables(0).Rows(0)("InOutPort")
                Me.cbLoadPort.SelectedValue = dsBill.Tables(0).Rows(0)("CodeLoadPort")
                Me.cbUnloadPort.SelectedValue = dsBill.Tables(0).Rows(0)("CodeUnloadPort")
                cbWorkType.SelectedValue = dsBill.Tables(0).Rows(0).Item("WORKTYPE")
                cbConLoadType.SelectedValue = dsBill.Tables(0).Rows(0).Item("CODE_TALLY_TYPE")
                dtpTimeBegin.Value = dsBill.Tables(0).Rows(0).Item("TIME_FROM")
                dtpListDate.Value = dsBill.Tables(0).Rows(0).Item("LISTDATE")
                billEnable = True
                rbnDetailed.Enabled = False
                rbnUsual.Enabled = False

                'strYCode = Me.cbPlace.SelectedValue
            Else
                billEnable = False
                MessageBox.Show("���ᵥ�ѳ�֤����������", "��ʾ")
            End If
        Else
            billEnable = True
            rbnDetailed.Enabled = True
            rbnUsual.Enabled = True

            Me.ckbInTrade.Checked = False
            Me.dtpTimeBegin.Value = Now
            Me.ccbGoods.Text = ""
            Me.txtGoodsSpec.Clear()
            Me.txtAmount.Clear()
            Me.txtSize.Clear()

            Me.cbState.Text = ""
            Me.dtpListDate.Value = Now
            Me.ccbConsign.SelectedValue = "000"

            Me.cbUnloadPort.SelectedValue = "00"
            Me.txtTotalNetWeight.Clear()
            Me.txtMark.Text = ""
            Me.txtTallyClerk.Text = G_User
            Me.cbInOutPort.SelectedValue = "1"
            Me.cbWorkType.SelectedValue = "2"
            Me.cbConLoadType.SelectedValue = "1"
            Me.cbLoadPort.SelectedValue = "CNLYG"
            If Me.cbLoadPort.SelectedValue Is Nothing Then
                Me.cbLoadPort.SelectedValue = "LYG"
            End If

            Dim sqlAutoNO, strAutoNo As String
            Dim iYear, iMaxNo As Integer
            Dim dvAutoNO As New DataView
            'sqlAutoNO = "SELECT Code_Yard_ID, Code_Yard_Name, CodePrefix, CodeMax, CodeYear, DeptCode FROM Code_Yard WHERE DeptCode = '" & G_DeptCode & "'"
            sqlAutoNO = "SELECT Code_Yard_ID,Code_Yard_Name,CodePrefix,CodeMax,CodeYear,DeptCode FROM Code_Yard WHERE Code_Yard_ID='" & strYCode & "'"
            dvAutoNO = Filldata(sqlAutoNO)
            If dvAutoNO.Count > 0 Then
                iYear = dvAutoNO(0)("CodeYear")
                iMaxNo = dvAutoNO(0)("CodeMax")
                If iYear + 1 = Now.Year Then    '���������һ�� ��ݼ�һ �������
                    iYear = Now.Year
                    iMaxNo = 0
                Else    '�����ż�һ
                    iMaxNo = iMaxNo + 1
                End If
                strAutoNo = String.Concat(dvAutoNO(0)("CodePrefix"), iYear.ToString, Microsoft.VisualBasic.Right(String.Concat("00000", iMaxNo.ToString), 6))
                Me.txtNO.Text = strAutoNo
                Me.cbPlace.SelectedValue = dvAutoNO(0)("Code_Yard_ID")

                strYCode = dvAutoNO(0)("Code_Yard_ID")
            Else
                Me.txtNO.Text = "00"
                Me.cbPlace.SelectedValue = "00"
            End If      '��������Ԥ����ʵ�ʱ�ſ��ܾ��Ǵ˱�ţ�����һ����ʵ�ʱ�ű���ʱ����
        End If
    End Sub

    Dim sqlGetConExist As String
    Dim dvGetConExist As New DataView
    Private Sub GetConExist()
        sqlGetConExist = "select CodeYard,CHI_VESSEL,VOYAGE,BLNO,CONTAINER_NO,NEWSEALNO,SIZE_CON,CONTAINER_TYPE,AMOUNT,NetWeight,VOLUME,OutStorage,Clerk,ConTime,Cast(ReeferTemp as Varchar(6))+TempUnit Reefer,DangerGrade,Code_Yard_Name from Con_Load_Tally_List A left join Code_Yard B on A.CodeYard=B.Code_Yard_ID  where CHI_VESSEL ='" & strShip & "' and Voyage = '" & strVoyage & "' and blno = '" & strBillNo & "'"
        dvGetConExist = Filldata(sqlGetConExist)
        Me.C1DBGE.DataSource = dvGetConExist
        Me.C1DBGE.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        Me.C1DBGE.ColumnFooters = True
        Me.C1DBGE.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGE.Columns("CONTAINER_NO").FooterText = "����" & dvGetConExist.Count & "��"

        Me.C1DBGE.Columns.Item("CHI_VESSEL").Caption = "������"
        Me.C1DBGE.Columns.Item("VOYAGE").Caption = "����"
        Me.C1DBGE.Columns.Item("BLNO").Caption = "�ᵥ��"
        Me.C1DBGE.Columns.Item("CONTAINER_NO").Caption = "��װ���"
        Me.C1DBGE.Columns.Item("NEWSEALNO").Caption = "Ǧ���"
        Me.C1DBGE.Columns.Item("SIZE_CON").Caption = "��ߴ�"
        Me.C1DBGE.Columns.Item("CONTAINER_TYPE").Caption = "����"
        Me.C1DBGE.Columns.Item("AMOUNT").Caption = "����"
        'Me.C1DBGE.Columns.Item("WEIGHT").Caption = "ë��(kg)"
        Me.C1DBGE.Columns.Item("NetWeight").Caption = "����kg"
        Me.C1DBGE.Columns.Item("VOLUME").Caption = "����M3"
        Me.C1DBGE.Columns.Item("OutStorage").Caption = "ת�ⳡ"
        Me.C1DBGE.Columns.Item("Clerk").Caption = "���Ա"
        Me.C1DBGE.Columns.Item("ConTime").Caption = "��ҵʱ��"
        Me.C1DBGE.Columns.Item("Reefer").Caption = "����¶�"
        Me.C1DBGE.Columns.Item("DangerGrade").Caption = "ΣƷ�ȼ�"
        Me.C1DBGE.Columns.Item("Code_Yard_Name").Caption = "װ��ص�"
        Me.C1DBGE.Columns("ConTime").NumberFormat = "yyMMdd HHmm"
        Me.C1DBGE.Splits(0).DisplayColumns("CodeYard").Visible = False
        Me.C1DBGE.Splits(0).DisplayColumns("CHI_VESSEL").Visible = False
        Me.C1DBGE.Splits(0).DisplayColumns("VOYAGE").Visible = False
        Me.C1DBGE.Splits(0).DisplayColumns("BLNO").Visible = False
        Me.C1DBGE.Splits(0).ColumnCaptionHeight = 20    '����ͷ�߶�
        Me.C1DBGE.Splits(0).ColumnFooterHeight = 18
        Me.C1DBGE.RowHeight = 18
        SetDGWidth(Me.C1DBGE, 2)
        Me.C1DBGE.Columns("AMOUNT").FooterText = GetDataSum(dvGetConExist, "AMOUNT")
        Me.C1DBGE.Columns("NetWeight").FooterText = GetDataSum(dvGetConExist, "NetWeight")
        Me.C1DBGE.Columns("VOLUME").FooterText = GetDataSum(dvGetConExist, "VOLUME")
        dvGetConExist.Sort = "ConTime"

    End Sub

    Private Sub InitSubTable()
        Try
            Dim sqlSubTable As String
            'sqlSubTable = "select * from Con_Load_Tally_List where CodeYard = '" & strYCode & "' AND CHI_VESSEL ='" & strShip & "' and Voyage = '" & strVoyage & "'"
            sqlSubTable = "select CON_LOAD_TALLY_LIST_ID,CON_LOAD_TALLY_ID,SHIP_ID,CHI_VESSEL,Voyage,BLNO,CONTAINER_NO,SIZE_CON,CONTAINER_TYPE,Clerk,NEWSEALNO,SealType,SealPerson,PACK_CHA,AMOUNT,WEIGHT,NetWeight,VOLUME,OutStorage,ConTime,DAMAGED_AMOUNT,DAMAGED_PACK,SecSealNO,ReasonOpenSeal,ReeferTemp,TempUnit,DangerGrade,DangerMark,USER_NAME,CodeYard,Checked,CheckTime,Printed,PrintTime,PrintPerson,StateC,FullOrEmpty " & _
                " from Con_Load_Tally_List where CHI_VESSEL ='0' and Voyage = '0' and blno = '0' and CodeYard = ''"
            'conTime = 16
            Updatedata(sqlSubTableda, sqlSubTable, dsSubTable)
            Dim dgColumn As New DataColumn("Valid", Type.GetType("System.String"))
            dsSubTable.Tables(0).Columns.Add(dgColumn)
            dgColumn = New DataColumn("ClerkValid", Type.GetType("System.String"))
            dsSubTable.Tables(0).Columns.Add(dgColumn)

            Me.C1DBG.DataSource = dsSubTable.Tables(0).DefaultView

            'C1�������û�ã�������Ч�����ܱ�������
            'Dim c1Column As New C1.Win.C1TrueDBGrid.C1DataColumn("Valid", System.Type.GetType("System.Int32"))
            'Me.C1DBG.Columns.Insert(Me.C1DBG.Columns.IndexOf(Me.C1DBG.Columns("NewSealNo")), c1Column)

            Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
            Me.C1DBG.ColumnFooters = True
            Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
            Me.C1DBG.Columns("CONTAINER_NO").FooterText = "�¼�" & dsSubTable.Tables(0).Rows.Count & "��"

            Me.C1DBG.Splits(0).DisplayColumns(0).Visible = False
            Me.C1DBG.Splits(0).DisplayColumns(1).Visible = False
            Me.C1DBG.Splits(0).DisplayColumns("SHIP_ID").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns("CHI_VESSEL").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns("VOYAGE").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns("BLNO").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns("WEIGHT").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns("CodeYard").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns("USER_NAME").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns("Checked").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns("CheckTime").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns("Printed").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns("PrintTime").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns("PrintPerson").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns("StateC").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns("FullOrEmpty").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns("Valid").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns("ClerkValid").Visible = False

            Me.C1DBG.Splits(0).DisplayColumns(0).Locked = True
            Me.C1DBG.Splits(0).DisplayColumns(1).Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("SHIP_ID").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("CHI_VESSEL").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("VOYAGE").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("BLNO").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("CodeYard").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("USER_NAME").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("Checked").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("CheckTime").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("Printed").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("PrintTime").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("PrintPerson").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("StateC").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("FullOrEmpty").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("Valid").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("ClerkValid").Locked = True
            cbConLoadType_SelectedIndexChanged(New Object(), New EventArgs())

            Me.C1DBG.Columns.Item("CHI_VESSEL").Caption = "����"
            Me.C1DBG.Columns.Item("VOYAGE").Caption = "����"
            Me.C1DBG.Columns.Item("BLNO").Caption = "�ᵥ��"
            Me.C1DBG.Columns.Item("CONTAINER_NO").Caption = "��װ���"
            Me.C1DBG.Columns.Item("NEWSEALNO").Caption = "Ǧ���"
            Me.C1DBG.Columns.Item("SealType").Caption = "���"
            Me.C1DBG.Columns.Item("SealPerson").Caption = "ʩ����"
            Me.C1DBG.Columns.Item("SIZE_CON").Caption = "���"
            Me.C1DBG.Columns.Item("CONTAINER_TYPE").Caption = "����"
            Me.C1DBG.Columns.Item("AMOUNT").Caption = "����"
            Me.C1DBG.Columns.Item("PACK_CHA").Caption = "��װ"
            Me.C1DBG.Columns.Item("WEIGHT").Caption = "����kg"
            Me.C1DBG.Columns.Item("NetWeight").Caption = "����kg"
            Me.C1DBG.Columns.Item("VOLUME").Caption = "����M3"
            Me.C1DBG.Columns.Item("DAMAGED_AMOUNT").Caption = "�������"
            Me.C1DBG.Columns.Item("DAMAGED_PACK").Caption = "�������"
            Me.C1DBG.Columns.Item("SecSealNO").Caption = "��ע��"
            Me.C1DBG.Columns.Item("ReasonOpenSeal").Caption = "����ԭ��"
            Me.C1DBG.Columns.Item("ReeferTemp").Caption = "����¶�"
            Me.C1DBG.Columns.Item("TempUnit").Caption = "�±�"
            Me.C1DBG.Columns.Item("DangerGrade").Caption = "ΣƷ�ȼ�"
            Me.C1DBG.Columns.Item("DangerMark").Caption = "ΣƷ��ǩ"
            Me.C1DBG.Columns.Item("Clerk").Caption = "���Ա"
            Me.C1DBG.Columns.Item("ConTime").Caption = "��ҵʱ��"
            Me.C1DBG.Columns.Item("OutStorage").Caption = "ת�ⳡ"


            Me.C1DBG.Columns("ConTime").NumberFormat = "yyMMdd HHmm"
            Me.C1DBG.Columns("ConTime").EditMask = "000000 0000"
            'Me.C1DBG.Columns("ConTime").EditMaskUpdate = True
            Me.C1DBG.Columns("USER_NAME").DefaultValue = G_User
            Me.C1DBG.Columns("BLNO").DefaultValue = strBillNo
            Me.C1DBG.Columns("CHI_VESSEL").DefaultValue = strShip
            Me.C1DBG.Columns("VOYAGE").DefaultValue = strVoyage
            Me.C1DBG.Columns("CodeYard").DefaultValue = strYCode
            Me.C1DBG.Columns("Printed").DefaultValue = "0"
            If strYCode = "01" Then '�������� ��������ţ������Ѿ������
                Me.C1DBG.Columns.Item("Checked").DefaultValue = "1"
                Me.C1DBG.Columns.Item("CheckTime").DefaultValue = Now
            Else
                Me.C1DBG.Columns.Item("Checked").DefaultValue = "0"
            End If
            If strShip = "HCHE" And strVoyage = "001" Then
                Me.C1DBG.Columns.Item("StateC").DefaultValue = "0"
            Else
                Me.C1DBG.Columns.Item("StateC").DefaultValue = "1"
            End If
            'Me.C1DBG.Columns.Item("ConTime").DefaultValue = Me.dtpTimeBegin.Value
            Me.C1DBG.Columns("SealType").DefaultValue = "M"     'Ĭ�ϻ�е��
            Me.C1DBG.Columns("SealPerson").DefaultValue = "SH"  'Ĭ�Ϸ�����

            Call FieldFill()
            SetColumnWidth()
            Me.C1DBG.Splits(0).DisplayColumns("Clerk").AutoDropDown = True
            Me.C1DBG.Splits(0).DisplayColumns("NewSealNo").AutoDropDown = True
            Me.C1DBG.Splits(0).DisplayColumns("SealType").AutoDropDown = True
            Me.C1DBG.Splits(0).DisplayColumns("SealPerson").AutoDropDown = True
            'Me.C1DBG.Splits(0).DisplayColumns("Clerk").AutoComplete = True
            'Me.C1DBG.Splits(0).DisplayColumns("Clerk").Button = True
            'Me.C1DBG.Splits(0).DisplayColumns("Clerk").ButtonAlways = True
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_TYPE").AutoDropDown = True
            Me.C1DBG.Splits(0).DisplayColumns("PACK_CHA").AutoDropDown = True
            Me.C1DBG.Splits(0).DisplayColumns("TempUnit").AutoDropDown = True
            Me.C1DBG.Splits(0).DisplayColumns("OutStorage").AutoDropDown = True
            Me.C1DBG.Splits(0).DisplayColumns("ConTime").AutoComplete = True


            Me.C1DBG.Splits(0).DisplayColumns("Clerk").FetchStyle = True
            Me.C1DBG.Splits(0).DisplayColumns("NewSealNo").FetchStyle = True
            Me.C1DBG.Splits(0).ColumnCaptionHeight = 20    '����ͷ�߶�
            Me.C1DBG.Splits(0).ColumnFooterHeight = 18
            Me.C1DBG.RowHeight = 18
        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Dim c1DropDown As New C1.Win.C1TrueDBGrid.C1TrueDBDropdown

    Dim sqlPack As String
    Dim dvPack As DataView
    Dim sqlOutStorage As String
    Dim dvOutStorage As DataView
    Dim sqlClerk As String
    Dim dvClerk As DataView
    Dim sqlSealNo As String
    Dim dvSealNo As DataView
    Private Sub FieldFill()
        Dim i As Integer
        Try
            Dim sqlConKind As String = "SELECT CODE_CON_KIND, CON_KIND_ENG FROM CODE_CON_KIND ORDER BY CODE_CON_KIND"
            Dim dvConKind As New DataView
            dvConKind = Filldata(sqlConKind)
            Me.C1DBG.Columns("CONTAINER_TYPE").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("CONTAINER_TYPE").ValueItems.Translate = True
            Me.C1DBG.Columns("CONTAINER_TYPE").ValueItems.MaxComboItems = 20
            For i = 0 To dvConKind.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = dvConKind(i)("CON_KIND_ENG")
                vi.Value = dvConKind(i)("CODE_CON_KIND")
                Me.C1DBG.Columns.Item("CONTAINER_TYPE").ValueItems.Values.Add(vi)
            Next
            '������C1TrueDBDropdown�������鷳����ʵ�֡����һ�Ҫ�ؼ����У���̬����Ļ�û��
            'c1DropDown.DataSource = dvConKind
            'c1DropDown.ColumnHeaders = False
            'c1DropDown.DisplayColumns("CON_KIND_ENG").Visible = False
            ''c1DropDown.DataMember = "CODE_CON_KIND"
            'c1DropDown.DataField = "CODE_CON_KIND"
            'c1DropDown.DisplayColumns("CODE_CON_KIND").AutoSize()
            'c1DropDown.DisplayColumns("CODE_CON_KIND").AutoDropDown = True
            'c1DropDown.DropdownWidth = C1.Win.C1TrueDBGrid.DropdownWidthEnum.Column
            'Me.C1DBG.Columns("CONTAINER_TYPE").DropDown = c1DropDown


            sqlPack = "SELECT CODE_PACK, PACK_CHA, PACK_ENG,Pack_Short FROM CODE_PACK ORDER BY px"
            dvPack = Filldata(sqlPack)
            Me.C1DBG.Columns("PACK_CHA").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("PACK_CHA").ValueItems.Translate = True
            Me.C1DBG.Columns("PACK_CHA").ValueItems.MaxComboItems = 20
            For i = 0 To dvPack.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = dvPack(i)("PACK_CHA")
                vi.Value = dvPack(i)("CODE_PACK")
                Me.C1DBG.Columns.Item("PACK_CHA").ValueItems.Values.Add(vi)
            Next

            sqlOutStorage = "SELECT Code_WorkPlace,WorkPlace FROM tb_Code_WorkPlace where Using_ConLoad='1' order by WorkPlace"
            dvOutStorage = Filldata(sqlOutStorage)
            C1DBG.Columns("OutStorage").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            C1DBG.Columns("OutStorage").ValueItems.Translate = True
            C1DBG.Columns("OutStorage").ValueItems.MaxComboItems = 20
            For i = 0 To dvOutStorage.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = dvOutStorage(i)("WorkPlace")
                vi.Value = dvOutStorage(i)("WorkPlace")
                Me.C1DBG.Columns.Item("OutStorage").ValueItems.Values.Add(vi)
            Next

            Me.C1DBG.Columns("Clerk").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("Clerk").ValueItems.MaxComboItems = 20
            'sqlClerk = "select A.Serial_Nam,A.Name,B.Work_No,B.Tally_Short from System_User_Table A join Tally_Clerk B on A.Name=B.Name where A.Dept_Code='" & G_DeptCode & "' order by A.Name"
            ''sqlClerk = "select Name,Work_No,Tally_Short from Tally_Clerk B where Dept_Code='" & G_DeptCode & "' order by Name"
            'ѡ�������Ա
            sqlClerk = "select Name,Work_No,Tally_Short,DEPT_CODE from Tally_Clerk where Dept_Code like '2[69].12%' " & _
                " and SubString(Dept_Code,3,6) in (select ClerkDept from DepartMent where Dept_Code='" & G_DeptCode & "') ORDER BY NAME,DEPT_CODE"
            dvClerk = Filldata(sqlClerk)
            For i = 0 To dvClerk.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = dvClerk(i)("Name")
                vi.Value = dvClerk(i)("Name")
                Me.C1DBG.Columns("Clerk").ValueItems.Values.Add(vi)
            Next
            '����
            'Me.C1DBD.DataSource = dvClerk
            ''Me.C1DBD.DataMember = "Serial_Nam"
            'Me.C1DBD.DataField = "Serial_Nam"
            'Me.C1DBD.DisplayColumns("Name").Visible = False
            'Me.C1DBD.DisplayColumns("Work_No").Visible = False
            'Me.C1DBD.DisplayColumns("Tally_Short").Visible = False
            'Me.C1DBD.ColumnHeaders = False
            'Me.C1DBD.DisplayColumns("Serial_Nam").AutoSize()
            'Me.C1DBD.DisplayColumns("Serial_Nam").AutoDropDown = True
            'Me.C1DBD.DropdownWidth = C1.Win.C1TrueDBGrid.DropdownWidthEnum.Column
            'Me.C1DBG.Columns("Clerk").DropDown = Me.C1DBD

            Me.C1DBG.Columns("NEWSEALNO").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("NEWSEALNO").ValueItems.MaxComboItems = 20
            'Ǧ������Ա���ڳ�վһ�������岿����������վ��ͬ����˲���ֱ�Ӱ�����ѡ�� ͨ�����Ա����ת��
            sqlSealNo = "SELECT SealNo,Seal_State,Dept_Code,Use_Mark,Logout_Mark,User_Person FROM SEAL_RECORD " & _
                " WHERE Seal_State='2' and Logout_Mark='0' and Use_Mark='0' " & _
                " and SubString(Dept_Code,3,6) in (select ClerkDept from DepartMent where Dept_Code='" & G_DeptCode & "')"
            dvSealNo = Filldata(sqlSealNo)
            'dvSealNo.RowFilter = "User_Person='" & Me.C1DBG.Columns("Clerk").Text & "'"

            'Dim aa As C1.Win.C1TrueDBGrid.ValueItems
            'Dim bb As C1.Win.C1TrueDBGrid.ValueItemCollection

            Me.C1DBG.Columns("SealType").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("SealType").ValueItems.MaxComboItems = 20
            Dim sqlSealType As String
            Dim dvSealType As DataView
            sqlSealType = "SELECT ID, Code, KindDesc FROM Code_SealKind ORDER BY ID"
            dvSealType = Filldata(sqlSealType)
            For i = 0 To dvSealType.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = dvSealType(i)("Code")
                vi.Value = dvSealType(i)("Code")
                Me.C1DBG.Columns("SealType").ValueItems.Values.Add(vi)
            Next
            Me.C1DBG.Columns("SealPerson").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("SealPerson").ValueItems.MaxComboItems = 20
            Dim sqlSealPerson As String
            Dim dvSealPerson As DataView
            sqlSealPerson = "SELECT ID, Code, PersonDesc FROM Code_SealPerson ORDER BY ID"
            dvSealPerson = Filldata(sqlSealPerson)
            For i = 0 To dvSealPerson.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = dvSealPerson(i)("Code")
                vi.Value = dvSealPerson(i)("Code")
                Me.C1DBG.Columns("SealPerson").ValueItems.Values.Add(vi)
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnWidth()
        Dim i As Integer
        Try
            i = 2
            Do While i < Me.C1DBG.Columns.Count
                Me.C1DBG.Splits(0).DisplayColumns(i).Width = 60
                i = i + 1
            Loop
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Width = 80
            Me.C1DBG.Splits(0).DisplayColumns("NEWSEALNO").Width = 80
            Me.C1DBG.Splits(0).DisplayColumns("SealType").AutoSize()
            Me.C1DBG.Splits(0).DisplayColumns("SealPerson").AutoSize()
            Me.C1DBG.Splits(0).DisplayColumns("BLNO").Width = 90
            Me.C1DBG.Splits(0).DisplayColumns("SIZE_CON").Width = 40
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_TYPE").Width = 40
            Me.C1DBG.Splits(0).DisplayColumns("ReeferTemp").Width = 40
            Me.C1DBG.Splits(0).DisplayColumns("TempUnit").Width = 40
            Me.C1DBG.Splits(0).DisplayColumns("ConTime").Width = 95
            For i = 0 To Me.C1DBG.Columns.Count - 1
                Me.C1DBG.Splits(0).DisplayColumns(i).Width *= 1.1
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function CheckConNO(ByVal sm As String) As Integer 'return 0 ����д� 1 У���д� 2 У����ȷ
        Dim S() As Integer = {10, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 34, 35, 36, 37, 38}
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim l As Integer
        i = 0
        str = UCase(sm)
        If Len(Trim(str)) = 12 And Mid(Trim(str), 5, 1) = " " Then
            str = Mid(Trim(str), 1, 4) & Mid(Trim(str), 6, 7)
        ElseIf Len(Trim(str)) <> 11 Then
            Return 0
        End If
        k = 1
        For j = 1 To 4
            If Asc(Mid(Trim(str), j, 1)) >= Asc("A") And Asc(Mid(Trim(str), j, 1)) <= Asc("Z") Then
                i = i + S(Asc(Mid(Trim(str), j, 1).ToUpper) - Asc("A")) * System.Math.Pow(2, k - 1)
            Else
                Return 0
            End If

            k = k + 1
        Next

        For j = 5 To 10
            If Asc(Mid(Trim(str), j, 1)) >= Asc("0") And Asc(Mid(Trim(str), j, 1)) <= Asc("9") Then
                i = i + CInt(Mid(Trim(str), j, 1)) * System.Math.Pow(2, k - 1)
            Else
                Return 0
            End If

            k = k + 1
        Next
        If i Mod 11 = CInt(Mid(Trim(str), 11, 1)) Or (i Mod 11) - 10 = CInt(Mid(Trim(str), 11, 1)) Then
            Return 2
        Else
            Return 1
        End If
    End Function

    Private Function IsEqualConNo(ByVal ConOne As String, ByVal ConTwo As String) As Boolean    '�ж�����Ƿ����
        Dim Flag As Boolean
        ConOne = ConOne.Trim.ToUpper
        ConTwo = ConTwo.Trim.ToUpper
        If ConOne.Length = ConTwo.Length Then
            If String.Equals(ConOne, ConTwo) Then
                Flag = True
            End If
        Else
            If String.Equals(ConOne, GetConOtherMode(ConTwo)) Then
                Flag = True
            End If
        End If
        Return Flag
    End Function

    Private Function GetConOtherMode(ByVal ConNo As String) As String   '�õ���ŵ���һ���޿ջ��п���ʽ
        ConNo = ConNo.Trim.ToUpper
        If ConNo.Length = 11 Then
            ConNo = ConNo.Insert(4, " ")
        ElseIf ConNo.Length = 12 Then
            ConNo = ConNo.Remove(4, 1)
        End If
        Return ConNo
    End Function

    Private Sub TrimGrid()
        Dim i As Integer
        Me.C1DBG.Focus()
        For i = 0 To dsSubTable.Tables(0).Rows.Count - 1
            Me.C1DBG.Row = i
            'Me.C1DBG.Columns("BLNO").Text = Me.C1DBG.Columns("BLNO").Text.Trim().ToUpper
            Me.C1DBG.Columns("CONTAINER_NO").Text = Me.C1DBG.Columns("CONTAINER_NO").Text.Trim().ToUpper
            Me.C1DBG.Columns("NEWSEALNO").Text = Me.C1DBG.Columns("NEWSEALNO").Text.Trim().ToUpper
            Me.C1DBG.Columns("CONTAINER_TYPE").Text = Me.C1DBG.Columns("CONTAINER_TYPE").Text.Trim().ToUpper
            Me.C1DBG.Columns("DAMAGED_PACK").Text = Me.C1DBG.Columns("DAMAGED_PACK").Text.Trim()
            Me.C1DBG.Columns("DangerGrade").Text = Me.C1DBG.Columns("DangerGrade").Text.Trim()
            Me.C1DBG.Columns("DangerMark").Text = Me.C1DBG.Columns("DangerMark").Text.Trim()

            Me.C1DBG.Columns("CHI_VESSEL").Text = strShip
            Me.C1DBG.Columns("Voyage").Text = strVoyage
            Me.C1DBG.Columns("BLNO").Text = strBillNo
            Me.C1DBG.Columns("CodeYard").Text = strYCode
        Next
        Me.btQuit.Focus()
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        If billEnable = False Then
            MessageBox.Show("���ᵥ�ѳ�֤����������", "��ʾ")
            Exit Sub
        End If
        Dim blEmptyCon As Boolean   '�����־ ����Ǧ��
        If Me.cbConLoadType.SelectedValue = "4" Then
            blEmptyCon = True
        Else
            blEmptyCon = False
        End If
        Try
            Call TrimGrid()

            Dim i, j As Integer
            Dim iConCheck, iConBeing As Integer
            Dim sqlBeing As String

            If shipMark = False Then
                Me.txtShip.Focus()
                MessageBox.Show("���� " & strShip & " �����ڣ�����������", "��ʾ")
                Exit Sub
            End If

            For i = 0 To dsSubTable.Tables(0).Rows.Count - 1    '�����ϼ�����
                'If Me.C1DBG.Columns("BLNO").CellText(i) <> "" Then
                If Me.C1DBG.Columns("CONTAINER_NO").CellText(i) <> "" Then
                    iConCheck = CheckConNO(Me.C1DBG.Columns("CONTAINER_NO").CellText(i))
                    '���û��ͨ������ʱ
                    If iConCheck = 1 Or iConCheck = 0 Then
                        sqlBeing = "SELECT CONTAINER_NO FROM CON_CRITERION WHERE CONTAINER_NO = '" & C1DBG.Columns("CONTAINER_NO").CellText(i) & "' or CONTAINER_NO = '" & GetConOtherMode(C1DBG.Columns("CONTAINER_NO").CellText(i)) & "'"
                        iConBeing = Filldata(sqlBeing).Count
                        If iConBeing = 0 Then    '��淶�в�����
                            Me.C1DBG.Row = i
                            Me.C1DBG.Col = 2
                            Me.C1DBG.SelectedRows.Clear()
                            Me.C1DBG.SelectedRows.Add(i)
                            If MessageBox.Show("��װ��� " & C1DBG.Columns("CONTAINER_NO").CellText(i) & " У�鲻��ȷ���ڲ���������淶�У�ȷ��������", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                Exit For
                            End If
                        End If
                    ElseIf iConCheck = 0 Then
                        Me.C1DBG.Row = i
                        Me.C1DBG.Col = 2
                        Me.C1DBG.SelectedRows.Clear()
                        Me.C1DBG.SelectedRows.Add(i)
                        Me.C1DBG.SelectedCols.Clear()
                        Me.C1DBG.Columns("CONTAINER_NO").CellText(i)
                        MessageBox.Show("��װ��Ų��淶��", "��ʾ")
                        Exit For
                    End If

                    For j = 0 To i - 1
                        If IsEqualConNo(Me.C1DBG.Columns("CONTAINER_NO").CellText(i), Me.C1DBG.Columns("CONTAINER_NO").CellText(j)) Then
                            'If String.Equals(Me.C1DBG.Columns("BLNO").CellText(i), Me.C1DBG.Columns("BLNO").CellText(j)) Then
                            Me.C1DBG.Row = i
                            Me.C1DBG.SelectedRows.Clear()
                            Me.C1DBG.SelectedRows.Add(i)
                            Me.C1DBG.SelectedRows.Add(j)
                            MessageBox.Show("��" & j + 1 & "�к͵�" & i + 1 & "�� ͬһ�ᵥ�¼�װ����ظ���", "��ʾ")
                            Exit Sub
                            'End If
                        End If
                    Next
                Else
                    Me.C1DBG.Row = i
                    Me.C1DBG.Col = 2
                    Me.C1DBG.SelectedRows.Clear()
                    Me.C1DBG.SelectedRows.Add(i)
                    MessageBox.Show("��װ��Ų���Ϊ�գ�", "��ʾ")
                    Exit For
                End If
                'Else
                'Me.C1DBG.Row = i
                'Me.C1DBG.Col = 1
                'Me.C1DBG.SelectedRows().Clear()
                'Me.C1DBG.SelectedRows.Add(i)
                'MessageBox.Show("�ᵥ�Ų���Ϊ�գ�", "��ʾ")
                'Exit For
                'End If
                '�ȽϿ�ʼʱ�������ҵʱ��
                If Me.rbnUsual.Checked Then
                    Dim dtTemp As DateTime
                    If Not Me.C1DBG.Columns("ConTime").CellValue(i) Is DBNull.Value AndAlso Me.dtpTimeBegin.Value > Me.C1DBG.Columns("ConTime").CellValue(i) Then
                        Me.C1DBG.Row = i
                        Me.C1DBG.Col = Me.C1DBG.Splits(0).DisplayColumns.IndexOf(Me.C1DBG.Columns("ConTime"))
                        'Me.C1DBG.SelectedRows.Clear()
                        'Me.C1DBG.SelectedRows.Add(i)
                        If MessageBox.Show("������ҵʱ�����ڿ�ʼʱ�䣬ȷ����", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.Cancel Then
                            Exit For
                        End If
                    End If
                End If
                If blEmptyCon = False Then   '���䲻���Ǧ��
                    For j = 0 To i - 1
                        If Me.C1DBG.Columns("NEWSEALNO").CellText(i) = Me.C1DBG.Columns("NEWSEALNO").CellText(j) Then
                            Me.C1DBG.Row = i
                            Me.C1DBG.SelectedRows.Clear()
                            Me.C1DBG.SelectedRows.Add(i)
                            Me.C1DBG.SelectedRows.Add(j)
                            If MessageBox.Show("��" & j + 1 & "�к͵�" & i + 1 & "�� ����ظ����Ƿ����?", "��ʾ", MessageBoxButtons.OKCancel) = DialogResult.Cancel Then
                                Exit Sub
                            End If
                        End If
                    Next
                End If
            Next

            '�������Ƿ������ݿ��������ظ���ͬ�ᵥ����Ų����ظ����˴����¿��ظ�������ƴ�䣩
            Dim sqlRepeat As String
            Dim dvRepeat As New DataView
            If i >= dsSubTable.Tables(0).Rows.Count Then    '����������
                For i = 0 To dsSubTable.Tables(0).Rows.Count - 1    '���ݿ���'���Ը�һ�£���Ҫѭ��
                    sqlRepeat = "SELECT CHI_VESSEL, Voyage, BLNO, CONTAINER_NO,NEWSEALNO FROM CON_LOAD_TALLY_LIST WHERE CHI_VESSEL = '" & strShip & "' AND Voyage = '" & strVoyage & "' AND BLNO = '" & strBillNo & _
                        "' AND CONTAINER_NO = '" & Me.C1DBG.Columns("CONTAINER_NO").CellText(i) & "'"
                    dvRepeat = Filldata(sqlRepeat)
                    If dvRepeat.Count > 0 Then  '������ظ�
                        Me.C1DBG.Row = i
                        Me.C1DBG.SelectedRows().Clear()
                        Me.C1DBG.SelectedRows.Add(i)
                        MessageBox.Show("�ô���ͬһ�ᵥ�´�������ظ�����������", "��ʾ")
                        Exit For
                    End If
                Next
            End If
            '���Ǧ����ظ�
            If blEmptyCon = False Then   '���䲻���Ǧ��
                Dim sqlSealCheck As String
                Dim dvSealCheck As DataView
                If i >= dsSubTable.Tables(0).Rows.Count Then
                    For i = 0 To dsSubTable.Tables(0).Rows.Count - 1    '���ݿ���'���Ը�һ�£���Ҫѭ��
                        sqlSealCheck = "SELECT CHI_VESSEL, Voyage, BLNO, CONTAINER_NO,NEWSEALNO FROM CON_LOAD_TALLY_LIST WHERE " & _
                            " NEWSEALNO = '" & C1DBG.Columns("NEWSEALNO").CellText(i) & "'"
                        dvSealCheck = Filldata(sqlSealCheck)
                        If dvSealCheck.Count > 0 Then  '������ظ�
                            Me.C1DBG.Row = i
                            Me.C1DBG.SelectedRows().Clear()
                            Me.C1DBG.SelectedRows.Add(i)
                            If MessageBox.Show("�÷���ظ�,�Ƿ����,��������?", "��ʾ", MessageBoxButtons.OKCancel) = DialogResult.Cancel Then
                                Exit For
                            End If
                        End If
                    Next
                End If
            End If

            Dim sqlBillNo As String
            If i >= dsSubTable.Tables(0).Rows.Count Then
                'sqlBillNo = "SELECT BLNO FROM CON_LOAD_TALLY WHERE CHI_VESSEL = '" & strShip & "' AND Voyage = '" & strVoyage & "' AND BLNO = '" & strBillNo & "'"
                'If Filldata(sqlBillNo).Count = 0 Then   'û���ᵥ��վ��Ϣ ��   
                If rbnUsual.Enabled = True Then 'û���ᵥ��Ϣ
                    If rbnUsual.Checked = True Then
                        '��ͨ��Ϣ
                        Call SaveUsualBill()
                        If BillSign = False Then    'û��ͨ���ᵥ��飬����
                            Exit Sub
                        End If
                    Else    '��ϸ��Ϣ
                        If strShip <> "HCHE" Then
                            Dim FrmBillAdd As New FrmConLoadTallyReceipt_Add
                            FrmBillAdd.ShowDialog()
                            If FrmBillAdd.flag = False Then     '���û�������ᵥ��Ϣ���˳�������������Ϣ
                                Exit Sub
                            End If
                        Else
                            Dim strNewNo As String
                            strNewNo = GetAutoNo(strYCode)
                            Dim sqlInsertBill As String
                            sqlInsertBill = "INSERT INTO CON_LOAD_TALLY (CHI_VESSEL, Voyage, InOutPort, CodeLoadPort, NO, WORK_PLACE, TIME_FROM, BLNO, WORKTYPE, CODE_TALLY_TYPE, USER_NAME, TALLY_CLERK, CODE_CON_CONSIGN, StateB) " & _
                                        "VALUES ('" & strShip & "', '" & strVoyage & "', '1', 'CNLYG', '" & strNewNo & "', '" & strYCode & "', '" & Now & "', '" & strBillNo & "', '2', '3', '" & G_User & "', '" & G_User & "', '00', '0')"
                            ExecSql(sqlInsertBill)
                        End If
                    End If
                Else    '���ᵥ��Ϣ
                    Call EditUsualBill()
                    If BillSign = False Then
                        Exit Sub
                    End If
                End If

                sqlSubTableda.Update(dsSubTable)
                MessageBox.Show("����ɹ���", "��ʾ")
                blSave = True
                BillSign = False
                Call MakeCONLOADEDI(txtShip.Text.Trim(), txtVoyage.Text.Trim(), txtBillNO.Text.Trim())
                Call GetConExist()
                Call InitSubTable()
                Call FillBill()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Function IsCode(ByVal str As String) As Boolean    ' ��ͷ����
        Dim i As Integer
        Dim ch As Char
        str = str.ToUpper
        If str.Length <= 5 Then
            For i = 1 To str.Length
                ch = Mid(str, i, 1)
                If Not (ch Like "[A-Z]" Or ch = " ") Then
                    Exit For
                End If
            Next
        End If
        If i > str.Length Then
            Return True     '���λ���м�ɿ�
        Else
            Return False
        End If
    End Function

    Private Function SetNumValue(ByVal strNumColumn As String, ByVal strNumValue As String, Optional ByVal message As String = "����") As Boolean
        Dim flag As Boolean = True
        If Trim(strNumValue) <> "" Then
            If IsNumeric(Trim(strNumValue)) Then
                row.Item(strNumColumn) = Trim(strNumValue)
            Else
                MessageBox.Show(message + "ӦΪ���֣�", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                flag = False
            End If
        Else    '��������
        End If
        Return flag
    End Function

    Private Sub SaveUsualBill()
        row = dsBill.Tables(0).NewRow

        If Me.SetNumValue("AMOUNT", txtAmount.Text, "�ܼ���") = False Then
            txtAmount.Focus()
            Exit Sub
        ElseIf Me.SetNumValue("TotalNetWeight", txtTotalNetWeight.Text, "�ܾ���") = False Then
            Me.txtTotalNetWeight.Focus()
            Exit Sub
        End If

        If Not IsNothing(Me.cbLoadPort.SelectedValue) Then  '�ۿڴ�����ȡ��
            row.Item("CodeLoadPort") = Me.cbLoadPort.SelectedValue
        Else
            If IsCode(Me.cbLoadPort.Text.Trim()) Then     '�ж��Ǵ������ʽ
                row.Item("CodeLoadPort") = Trim(Me.cbLoadPort.Text.ToUpper)
            Else
                Me.cbLoadPort.Focus()
                MessageBox.Show("װ����������ȡ��ʱ����������ۿڴ�����ܱ��档", "����", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        If Not IsNothing(Me.cbUnloadPort.SelectedValue) Then  '�ۿڴ�����ȡ��
            row.Item("CodeUnloadPort") = Me.cbUnloadPort.SelectedValue
        Else
            If IsCode(Me.cbUnloadPort.Text.Trim()) Then     '�ж��Ǵ������ʽ
                row.Item("CodeUnloadPort") = Trim(Me.cbUnloadPort.Text.ToUpper)
            Else
                Me.cbUnloadPort.Focus()
                MessageBox.Show("ж����������ȡ��ʱ����������ۿڴ�����ܱ��档", "����", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        row.Item("CHI_VESSEL") = strShip
        row.Item("VOYAGE") = strVoyage
        row.Item("BLNO") = strBillNo
        If Me.ckbInTrade.Checked Then   '��ó�䲻��֤
            row("TradeMark") = "1"
        End If

        row.Item("WORK_PLACE") = cbPlace.SelectedValue
        row.Item("TALLY_CLERK") = Trim(txtTallyClerk.Text)
        'row.Item("CodeLoadPort") = Me.cbLoadPort.SelectedValue
        'row.Item("CodeUnloadPort") = Me.cbUnloadPort.SelectedValue
        row.Item("InOutPort") = Me.cbInOutPort.SelectedValue
        row.Item("WORKTYPE") = cbWorkType.SelectedValue
        row.Item("CODE_TALLY_TYPE") = cbConLoadType.SelectedValue
        row.Item("TIME_FROM") = dtpTimeBegin.Value
        row.Item("LISTDATE") = dtpListDate.Value

        row.Item("MARK") = Trim(txtMark.Text).ToUpper
        row.Item("GoodsCha") = Me.ccbGoods.Text.Trim
        row.Item("GoodsSpec") = Me.txtGoodsSpec.Text.Trim.ToUpper
        row.Item("STATE") = Trim(cbState.Text)
        row.Item("CODE_CON_CONSIGN") = ccbConsign.SelectedValue
        row.Item("SIZE_MEASURE") = txtSize.Text.Trim

        row.Item("USER_NAME") = G_User
        row.Item("StateB") = "1"    '��Ϊ��վ״̬

        Dim strNewNo As String
        strNewNo = GetAutoNo(strYCode)    '������������
        row.Item("NO") = strNewNo
        Me.txtNO.Text = strNewNo
        dsBill.Tables(0).Rows.Add(row)
        daBill.Update(dsBill)

        BillSign = True '�ᵥ����ɹ�

    End Sub

    Private Function EditNumValue(ByVal strNumColumn As String, ByVal strNumValue As String, Optional ByVal message As String = "����") As Boolean
        Dim flag As Boolean = True
        If Trim(strNumValue) <> "" Then
            If IsNumeric(Trim(strNumValue)) Then
                dvBill(0)(strNumColumn) = Trim(strNumValue)
            Else
                MessageBox.Show(message + "ӦΪ���֣�", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                flag = False
            End If
        Else    '��������
            dvBill(0)(strNumColumn) = DBNull.Value
        End If
        Return flag
    End Function

    Private Sub EditUsualBill()
        If Me.EditNumValue("AMOUNT", txtAmount.Text, "�ܼ���") = False Then
            txtAmount.Focus()
            Exit Sub
        ElseIf Me.EditNumValue("TotalNetWeight", txtTotalNetWeight.Text, "�ܾ���") = False Then
            Me.txtTotalNetWeight.Focus()
            Exit Sub
        End If

        If Not IsNothing(Me.cbLoadPort.SelectedValue) Then  '�ۿڴ�����ȡ��
            dvBill(0)("CodeLoadPort") = Me.cbLoadPort.SelectedValue
        Else
            If IsCode(Me.cbLoadPort.Text.Trim()) Then     '�ж��Ǵ������ʽ
                dvBill(0)("CodeLoadPort") = Trim(Me.cbLoadPort.Text.ToUpper)
            Else
                Me.cbLoadPort.Focus()
                MessageBox.Show("װ����������ȡ��ʱ����������ۿڴ�����ܱ��档", "����", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        If Not IsNothing(Me.cbUnloadPort.SelectedValue) Then  '�ۿڴ�����ȡ��
            dvBill(0)("CodeUnloadPort") = Me.cbUnloadPort.SelectedValue
        Else
            If IsCode(Me.cbUnloadPort.Text.Trim()) Then     '�ж��Ǵ������ʽ
                dvBill(0)("CodeUnloadPort") = Trim(Me.cbUnloadPort.Text.ToUpper)
            Else
                Me.cbUnloadPort.Focus()
                MessageBox.Show("ж����������ȡ��ʱ����������ۿڴ�����ܱ��档", "����", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        dvBill(0)("CHI_VESSEL") = strShip
        dvBill(0)("VOYAGE") = strVoyage
        dvBill(0)("BLNO") = strBillNo
        If Me.ckbInTrade.Checked Then
            dvBill(0)("TradeMark") = "1"
        Else
            dvBill(0)("TradeMark") = "0"
        End If
        'dvBill(0)("WORK_PLACE") = cbPlace.SelectedValue
        dvBill(0)("TALLY_CLERK") = Trim(txtTallyClerk.Text)
        dvBill(0)("InOutPort") = Me.cbInOutPort.SelectedValue
        dvBill(0)("WORKTYPE") = cbWorkType.SelectedValue
        dvBill(0)("CODE_TALLY_TYPE") = cbConLoadType.SelectedValue
        dvBill(0)("TIME_FROM") = dtpTimeBegin.Value
        dvBill(0)("LISTDATE") = dtpListDate.Value

        dvBill(0)("MARK") = Trim(txtMark.Text).ToUpper
        dvBill(0)("GoodsCha") = Me.ccbGoods.Text.Trim
        dvBill(0)("GoodsSpec") = Me.txtGoodsSpec.Text.Trim.ToUpper
        dvBill(0)("STATE") = Trim(cbState.Text)
        dvBill(0)("CODE_CON_CONSIGN") = ccbConsign.SelectedValue
        dvBill(0)("SIZE_MEASURE") = txtSize.Text.Trim

        dvBill(0)("USER_NAME") = G_User

        daBill.Update(dsBill)

        BillSign = True '�ᵥ����ɹ�
    End Sub

    Private Sub txtShip_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtShip.Leave
        Me.txtShip.Text = Me.txtShip.Text.Trim.ToUpper

        sqlShipCode = "SELECT SPCODE, CHI_VESSEL,ENG_VESSEL FROM Code_SHIPNAME WHERE (SPCODE = '" & Me.txtShip.Text & "' or CHI_VESSEL = '" & Me.txtShip.Text & "')"
        dvShipCode = Filldata(sqlShipCode)
        txtShipName.Clear()
        If dvShipCode.Count > 0 Then
            Me.txtShip.Text = dvShipCode(0)("SPCODE")
            If Not IsDBNull(dvShipCode(0)("CHI_VESSEL")) Then
                Me.txtShipName.Text = dvShipCode(0)("CHI_VESSEL")
            End If
            If Not IsDBNull(dvShipCode(0)("ENG_VESSEL")) Then
                Me.txtShipName.Text += "/" & dvShipCode(0)("ENG_VESSEL")
            End If
            shipMark = True
        Else
            shipMark = False
            'Me.txtShip.Focus()
            MessageBox.Show("���� " & Me.txtShip.Text & " �����ڣ�����������", "��ʾ")
        End If
    End Sub

    Private Sub txtVoyage_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVoyage.Leave
        Me.txtVoyage.Text = Me.txtVoyage.Text.Trim.ToUpper
    End Sub

    Private Sub txtBillNO_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBillNO.Leave
        Me.txtBillNO.Text = Me.txtBillNO.Text.Trim.ToUpper
    End Sub

    Private Sub btnGetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetData.Click
        strBillNo = Me.txtBillNO.Text
        strVoyage = Me.txtVoyage.Text
        strShip = Me.txtShip.Text
        strYCode = Me.cbPlace.SelectedValue
        Me.txtOldShip.Text = strShip
        Me.txtOldShipName.Text = Me.txtShipName.Text
        Me.txtOldVoyage.Text = strVoyage
        Me.txtOldBlno.Text = strBillNo

        If strBillNo <> "" And strShip <> "" And strVoyage <> "" Then
            FillBill()
            Call GetConExist()
            Call InitSubTable()
            Me.txtMark.Focus()
        End If
    End Sub
    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        strBillNo = Nothing
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.txtShip.Clear()
        Me.txtVoyage.Clear()
        Me.txtBillNO.Clear()
        Me.cbPlace.SelectedIndex = 0
        strShip = ""
        strVoyage = ""
        strBillNo = ""
        strYCode = ""
        Me.txtOldShip.Clear()
        Me.txtOldShipName.Clear()
        Me.txtOldVoyage.Clear()
        Me.txtOldBlno.Clear()
        Call GetConExist()
        Call InitSubTable()

        Me.rbnUsual.Checked = True
        Me.ckbInTrade.Checked = False
        Me.cbWorkType.SelectedValue = "0"
        Me.cbConLoadType.SelectedValue = "0"
        Me.dtpTimeBegin.Value = Now
        Me.txtMark.Clear()
        Me.ccbGoods.Text = ""
        Me.txtGoodsSpec.Clear()
        Me.txtAmount.Clear()
        Me.txtSize.Clear()

        Me.cbState.Text = ""
        Me.dtpListDate.Value = Now
        Me.txtTallyClerk.Clear()
        Me.ccbConsign.SelectedValue = "000"

        Me.cbInOutPort.SelectedValue = " "
        Me.cbLoadPort.SelectedValue = "00"
        Me.cbUnloadPort.SelectedValue = "00"
        Me.txtTotalNetWeight.Clear()
    End Sub

    Private Sub RefreshDropDownSealNo(ByVal strNewFilter As String)
        'ˢ��Ǧ�������������
        If dvSealNo.RowFilter <> strNewFilter Then
            dvSealNo.RowFilter = strNewFilter
            Me.C1DBG.Columns("NEWSEALNO").ValueItems.Values.Clear()
            Dim vi As C1.Win.C1TrueDBGrid.ValueItem
            Dim i As Integer
            For i = 0 To dvSealNo.Count - 1
                vi = New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = dvSealNo(i)("SealNo")
                vi.Value = dvSealNo(i)("SealNo")
                Me.C1DBG.Columns("NEWSEALNO").ValueItems.Values.Add(vi)
            Next
        End If
    End Sub

    Private Sub C1DBG_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles C1DBG.RowColChange
        'Me.C1DBG.EditDropDown = True
        If Me.C1DBG.Row <> e.LastRow Then
            Me.C1DBG.Columns("SIZE_CON").FooterText = "��" & (Me.C1DBG.Row + 1) & "��"
        End If
        If Me.C1DBG.Columns(Me.C1DBG.Col).DataField = "NEWSEALNO" Then
            '����Ǧ�������������
            Dim strNewFilter As String
            strNewFilter = "User_Person='" & Me.C1DBG.Columns("Clerk").Text & "'"
            RefreshDropDownSealNo(strNewFilter)
        End If
        If Me.C1DBG.Columns(Me.C1DBG.Col).DataField = "PACK_CHA" Then
        End If
        If Me.C1DBG.Columns(Me.C1DBG.Col).DataField = "Clerk" Then
            'Me.C1DBG.Columns("Clerk").DropDown.Select()
        End If
    End Sub

    Private Sub C1DBG_AfterColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles C1DBG.AfterColEdit
        If e.Column.DataColumn.DataField = "CONTAINER_NO" Then
            If Me.C1DBG.Columns("Container_No").Text <> Me.C1DBG.Columns("Container_No").Text.Trim.ToUpper Then
                Me.C1DBG.Columns("Container_No").Text = Me.C1DBG.Columns("Container_No").Text.Trim.ToUpper
            End If
            Dim sb As New System.Text.StringBuilder
            Dim sqlCheckExist As String
            Dim dvCheckExist As DataView
            sqlCheckExist = "select Container_No,CHI_VESSEL,ShipName,Voyage,BLNO,NO,Code_Yard_Name,InputTime from View_ConLoadTally where Container_No='" & Me.C1DBG.Columns("CONTAINER_NO").Text & "' and InputTime>DateAdd(dd,-31,GetDate())"
            dvCheckExist = Filldata(sqlCheckExist)
            If dvCheckExist.Count > 0 Then
                sb.Append("���:" & dvCheckExist(0)("Container_No") & " ���ڳ��ֹ�" & vbLf)
                sb.Append("����:" & dvCheckExist(0)("CHI_VESSEL") & " ")
                sb.Append("����:" & dvCheckExist(0)("ShipName") & " ")
                sb.Append("����:" & dvCheckExist(0)("Voyage") & vbLf)
                sb.Append("�ᵥ:" & dvCheckExist(0)("BLNO") & " ")
                sb.Append("���:" & dvCheckExist(0)("NO") & vbLf)
                sb.Append("����:" & dvCheckExist(0)("Code_Yard_Name") & " ")
                sb.Append("ʱ��:" & dvCheckExist(0)("InputTime"))
                MessageBox.Show(sb.ToString(), "��ʾ")
            End If
        ElseIf e.Column.DataColumn.DataField = "NEWSEALNO" Then
            If Me.C1DBG.Columns("NEWSEALNO").Text <> Me.C1DBG.Columns("NEWSEALNO").Text.Trim.ToUpper Then
                Me.C1DBG.Columns("NEWSEALNO").Text = Me.C1DBG.Columns("NEWSEALNO").Text.Trim.ToUpper
            End If
        ElseIf e.Column.DataColumn.DataField = "ReeferTemp" Then '����¶�
            If IsNumeric(Me.C1DBG.Columns("ReeferTemp").Text) Then
                If Me.C1DBG.Columns("TempUnit").Text <> "C" AndAlso Me.C1DBG.Columns("TempUnit").Text <> "F" Then
                    Me.C1DBG.Columns("TempUnit").Text = "C"
                End If
            End If
        ElseIf e.Column.DataColumn.DataField = "TempUnit" Then '�±�
            If Me.C1DBG.Columns("TempUnit").Text <> Me.C1DBG.Columns("TempUnit").Text.Trim.ToUpper Then
                Me.C1DBG.Columns("TempUnit").Text = Me.C1DBG.Columns("TempUnit").Text.Trim.ToUpper
            End If

        End If
    End Sub

    Private Sub RefreshClerkMark()
        Dim i As Integer
        '������������������������У���������ƥ�� IndexOf��Ч �����Ҳ���
        'Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
        'vi.DisplayValue = Me.C1DBG.Columns("Clerk").Text
        'vi.Value = Me.C1DBG.Columns("Clerk").Text
        'If Me.C1DBG.Columns("Clerk").ValueItems.Values.IndexOf(vi) < 0 Then
        '    Me.C1DBG.Columns("Clerk").Text = Me.C1DBG.Columns("Clerk").Text.Trim.ToUpper
        '    For i = 0 To dvClerk.Count - 1
        '        If Me.C1DBG.Columns("Clerk").Text = Convert.ToString(dvClerk(i)("Tally_Short")).ToUpper Then
        '            Me.C1DBG.Columns("Clerk").Text = dvClerk(i)("Name")
        '            Exit For
        '        End If
        '    Next
        'End If
        If Me.C1DBG.Columns("Clerk").Text <> Me.C1DBG.Columns("Clerk").Text.Trim.ToUpper Then
            Me.C1DBG.Columns("Clerk").Text = Me.C1DBG.Columns("Clerk").Text.Trim.ToUpper
        End If
        If Me.C1DBG.Columns("Clerk").Text <> "" Then
            'ƥ����������������
            For i = 0 To dvClerk.Count - 1
                If Me.C1DBG.Columns("Clerk").Text = Convert.ToString(dvClerk(i)("Name")) Then
                    Exit For
                ElseIf Me.C1DBG.Columns("Clerk").Text = Convert.ToString(dvClerk(i)("Tally_Short")).ToUpper Then
                    Me.C1DBG.Columns("Clerk").Value = dvClerk(i)("Name")
                    Exit For
                End If
            Next
            If i < dvClerk.Count Then
                Me.C1DBG.Columns("ClerkValid").Value = DBNull.Value
            Else
                Me.C1DBG.Columns("ClerkValid").Value = -1
            End If
        Else    '���ɿ�
            Me.C1DBG.Columns("ClerkValid").Value = -1
        End If
    End Sub

    Private Sub RefreshSealNoMark()

        Dim i As Integer
        If Me.C1DBG.Columns("NEWSEALNO").Text <> "" Then
            For i = 0 To dvSealNo.Count - 1
                If Me.C1DBG.Columns("NEWSEALNO").Text = Convert.ToString(dvSealNo(i)("SealNo")) Then
                    Exit For
                End If
            Next
            If i < dvSealNo.Count Then  '�ҵ� ���� ����
                Me.C1DBG.Columns("Valid").Value = DBNull.Value
            Else    'û���ҵ�
                Dim strFilterTemp As String
                strFilterTemp = dvSealNo.RowFilter
                dvSealNo.RowFilter = strFilterTemp.Replace("=", "<>")
                For i = 0 To dvSealNo.Count - 1
                    If Me.C1DBG.Columns("NEWSEALNO").Text = Convert.ToString(dvSealNo(i)("SealNo")) Then
                        Exit For
                    End If
                Next
                If i < dvSealNo.Count Then  '�����������Ա����
                    Me.C1DBG.Columns("Valid").Value = 5
                Else    '����Ҫô�Ǹ߱��⣬Ҫô��δ���⣬δ���ã����ã�ע����
                    Dim sqlSealCheck As String
                    Dim dvSealCheck As DataView
                    sqlSealCheck = "SELECT SEALNO,SEAL_STATE,Use_Mark,Logout_Mark,B.Dept_Code,USER_PERSON FROM SEAL_RECORD A left join DepartMent B on (subString(A.Dept_Code,3,6)=B.ClerkDept or subString(A.Dept_Code,3,3)=B.ClerkDept) where SealNo='" & Me.C1DBG.Columns("NewSealNo").Text & "'"
                    dvSealCheck = Filldata(sqlSealCheck)
                    If dvSealCheck.Count > 0 Then
                        '�������ţ�ע�������ã�δ���ã�δ���⡣
                        Select Case dvSealCheck(0)("SEAL_STATE")
                            Case "0"    'δ����
                                Me.C1DBG.Columns("Valid").Value = 0
                            Case "1"    'δ����
                                Me.C1DBG.Columns("Valid").Value = 1
                            Case "2"
                                If dvSealCheck(0)("Use_Mark") <> "0" Then    '����
                                    Me.C1DBG.Columns("Valid").Value = 2
                                Else
                                    If dvSealCheck(0)("Logout_Mark") <> "0" Then 'ע��
                                        Me.C1DBG.Columns("Valid").Value = 3
                                    Else    '���ã�δע��
                                        If dvSealCheck(0)("Dept_Code") Is DBNull.Value OrElse dvSealCheck(0)("Dept_Code") <> G_DeptCode Then  '�Ǳ�������
                                            Me.C1DBG.Columns("Valid").Value = 4
                                        Else
                                            '��������ִ�е�����Ĵ���
                                            If IsDBNull(dvSealCheck(0)("USER_PERSON")) OrElse dvSealCheck(0)("USER_PERSON") <> Me.C1DBG.Columns("Clerk").Text Then  '�Ǵ����Ա����
                                                Me.C1DBG.Columns("Valid").Value = 5
                                            Else
                                                '�������������˿��� 
                                                Me.C1DBG.Columns("Valid").Value = DBNull.Value
                                            End If
                                        End If
                                    End If
                                End If
                            Case Else
                                Exit Select
                        End Select
                    Else    '�����ڣ�������Ӧ�Ǹ߱���
                        Me.C1DBG.Columns("Valid").Value = -1
                    End If
                End If
                dvSealNo.RowFilter = strFilterTemp
            End If
        Else    '�����
            Me.C1DBG.Columns("Valid").Value = DBNull.Value
        End If
    End Sub

    Private Sub C1DBG_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles C1DBG.AfterColUpdate
        If e.ColIndex = 6 Then  '���
            Dim sqlBeing As String = "SELECT * FROM CON_CRITERION WHERE CONTAINER_NO = '" & Me.C1DBG.Columns("CONTAINER_NO").Text & "' or CONTAINER_NO = '" & GetConOtherMode(Me.C1DBG.Columns("CONTAINER_NO").Text) & "'"
            Dim dvBeing As New DataView
            dvBeing = Filldata(sqlBeing)
            If dvBeing.Count >= 1 Then
                Me.C1DBG.Columns("SIZE_CON").Value = dvBeing.Item(0)("SIZE_CON")
                Me.C1DBG.Columns("CONTAINER_TYPE").Value = dvBeing.Item(0)("CONTAINER_TYPE")
            End If
            
        ElseIf e.Column.DataColumn.DataField = "PACK_CHA" Then
            If Me.C1DBG.Columns("PACK_CHA").Text <> "" AndAlso Me.C1DBG.Columns("PACK_CHA").Text = Me.C1DBG.Columns("PACK_CHA").Value Then
                Me.C1DBG.Columns("PACK_CHA").Text = Me.C1DBG.Columns("PACK_CHA").Text.Trim.ToUpper
                Dim i As Integer
                For i = 0 To dvPack.Count - 1   'Ҫ���ִ�Сд �ո�
                    If Me.C1DBG.Columns("PACK_CHA").Text.Trim.ToUpper = Convert.ToString(dvPack(i)("Pack_Short")) Then
                        Me.C1DBG.Columns("PACK_CHA").Value = dvPack(i)("CODE_PACK")
                        Exit For
                    End If
                Next
            End If
        ElseIf e.Column.DataColumn.DataField = "OutStorage" Then
            
        ElseIf e.Column.DataColumn.DataField = "Clerk" Then
            RefreshClerkMark()
            '����Ǧ�������������
            Dim strNewFilter As String
            strNewFilter = "User_Person='" & Me.C1DBG.Columns("Clerk").Text & "'"
            RefreshDropDownSealNo(strNewFilter)
        ElseIf e.Column.DataColumn.DataField = "NEWSEALNO" Then
            '���Ǧ�ⲻ�������б������Ա����Ǧ���У�����Ǧ����Ƿ���ϵͳǦ�����
            'Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
            'vi.Value = Me.C1DBG.Columns("NewSealNo").Text
            'If Me.C1DBG.Columns("NewSealNo").ValueItems.Values.IndexOf(vi) < 0 Then

            'Else    '�������������˿���
            '    Me.C1DBG.Columns("Valid").Value = DBNull.Value
            'End If
            RefreshSealNoMark()
        ElseIf e.Column.DataColumn.DataField = "AMOUNT" Then
            Me.C1DBG.Columns("AMOUNT").FooterText = GetDataSum(dsSubTable.Tables(0).DefaultView, "AMOUNT")
        ElseIf e.Column.DataColumn.DataField = "NetWeight" Then
            Me.C1DBG.Columns("NetWeight").FooterText = GetDataSum(dsSubTable.Tables(0).DefaultView, "NetWeight")
        ElseIf e.Column.DataColumn.DataField = "VOLUME" Then
            Me.C1DBG.Columns("VOLUME").FooterText = GetDataSum(dsSubTable.Tables(0).DefaultView, "VOLUME")
        End If
    End Sub

    Private Sub C1DBG_FetchCellStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs) Handles C1DBG.FetchCellStyle
        If e.Row <= dsSubTable.Tables(0).Rows.Count Then '�����¼���δ���У�����String���ͣ���Ϊ������Ҫ�ر���
            If e.Column.DataColumn.DataField = "Clerk" Then
                If Me.C1DBG.Columns("ClerkValid").CellText(e.Row) = "-1" Then
                    e.CellStyle.BackColor = Color.Yellow
                    e.CellStyle.ForeColor = Color.DarkSlateGray
                End If
                'Dim vi As New C1.Win.C1TrueDBGrid.ValueItem    'IndexOf��Ч
                'vi.Value = Me.C1DBG.Columns("Clerk").CellText(e.Row)
                'If Me.C1DBG.Columns("Clerk").ValueItems.Values.IndexOf(vi) < 0 Then
                '    e.CellStyle.BackColor = Color.Yellow
                'End If
            ElseIf e.Column.DataColumn.DataField = "NEWSEALNO" Then
                If Not IsDBNull(Me.C1DBG.Columns("Valid").CellValue(e.Row)) AndAlso Me.C1DBG.Columns("Valid").CellValue(e.Row) <> "" Then
                    If Me.C1DBG.Columns("Valid").CellText(e.Row) = "-1" Then
                        e.CellStyle.BackColor = Color.Pink
                    Else
                        e.CellStyle.BackColor = Color.Red
                    End If
                    e.CellStyle.ForeColor = Color.DarkSlateGray
                End If
            End If
        End If
    End Sub

    Private Sub C1DBG_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1DBG.KeyDown
        If e.KeyCode = Keys.Return Then
            If Me.C1DBG.Row < dsSubTable.Tables(0).Rows.Count - 1 Then
                If Me.C1DBG.Col = 17 + 2 OrElse Me.C1DBG.Col = 25 + 2 Then
                    Me.C1DBG.Row += 1
                    Me.C1DBG.Col = 6
                    SendKeys.Send("{LEFT}")
                End If
            Else    '�¼��л������һ��
                If Me.C1DBG.Col = 18 + 2 OrElse Me.C1DBG.Col = 25 + 2 Then
                    Me.C1DBG.Row += 1
                    Me.C1DBG.Columns("BLNO").Text = Me.C1DBG.Columns("BLNO").CellText(Me.C1DBG.Row - 1)
                    Me.C1DBG.Columns("SIZE_CON").Text = Me.C1DBG.Columns("SIZE_CON").CellText(Me.C1DBG.Row - 1)
                    Me.C1DBG.Columns("CONTAINER_TYPE").Value = Me.C1DBG.Columns("CONTAINER_TYPE").CellValue(Me.C1DBG.Row - 1)
                    Me.C1DBG.Columns("AMOUNT").Text = Me.C1DBG.Columns("AMOUNT").CellText(Me.C1DBG.Row - 1)
                    Me.C1DBG.Columns("PACK_CHA").Value = Me.C1DBG.Columns("PACK_CHA").CellValue(Me.C1DBG.Row - 1)
                    Me.C1DBG.Columns("NetWeight").Text = Me.C1DBG.Columns("NetWeight").CellText(Me.C1DBG.Row - 1)
                    Me.C1DBG.Columns("VOLUME").Text = Me.C1DBG.Columns("VOLUME").CellText(Me.C1DBG.Row - 1)
                    Me.C1DBG.Columns("Clerk").Text = Me.C1DBG.Columns("Clerk").CellText(Me.C1DBG.Row - 1)
                    If cbConLoadType.SelectedValue = "B" Then
                        Me.C1DBG.Columns("OutStorage").Value = Me.C1DBG.Columns("OutStorage").CellValue(Me.C1DBG.Row - 1)
                    End If
                    'Me.C1DBG.Columns("ConTime").Value = Me.C1DBG.Columns("ConTime").CellValue(Me.C1DBG.Row - 1)
                    Me.C1DBG.Columns("ConTime").Value = Now
                    RefreshClerkMark()
                    Me.C1DBG.Col = 6
                    SendKeys.Send("{LEFT}")
                    Me.C1DBG_AfterInsert(sender, e)
                    Me.C1DBG.UpdateData()
                ElseIf Me.C1DBG.Columns(Me.C1DBG.Col).DataField = "ConTime" Then
                    If Me.C1DBG.Columns("ConTime").Value Is DBNull.Value Then
                        If Me.C1DBG.Row = 0 Then
                            If dvGetConExist.Count = 0 Then '����״�����
                                Me.C1DBG.Columns("ConTime").Value = Me.dtpTimeBegin.Value   '�״�����ȡ��ʼʱ�� 
                            Else
                                Me.C1DBG.Columns("ConTime").Value = Now 'һ���õ�ǰʱ��
                            End If
                        Else    '���ڻ���ʱ������һ��ʱ�䣬���������������䲻��ִ��
                            Me.C1DBG.Columns("ConTime").Value = Me.C1DBG.Columns("ConTime").CellValue(Me.C1DBG.Row - 1)
                        End If
                    End If
                    '���EditActive �����ڿ�ֵ�ж�֮��.��Ϊʹ��EditActive֮��ͷǿ���
                    Me.C1DBG.EditActive = True
                End If
            End If
        End If
    End Sub

    Private Sub txtShip_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtShip.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtVoyage.Focus()
        End If
    End Sub

    Private Sub txtVoyage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVoyage.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtBillNO.Focus()
        End If
    End Sub

    Private Sub txtBillNO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBillNO.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.cbPlace.Focus()
        End If
    End Sub

    Private Sub cbPlace_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbPlace.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnGetData_Click(sender, e)
        End If
    End Sub

    Private Sub ccbConsign_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ccbConsign.Leave
        If dvConsign.RowFilter <> "" Then
            Dim strValue As String
            If Me.ccbConsign.SelectedIndex = -1 Then
                Me.ccbConsign.Text = Me.ccbConsign.Text.Trim.ToUpper    '�����ֵ��������RowFilter֮ǰд������ᵼ��RowFilter��ԭ
            End If
            strValue = Me.ccbConsign.Text
            dvConsign.RowFilter = ""
            Me.ccbConsign.Text = strValue
            If Me.ccbConsign.SelectedIndex < 0 Then
                Dim i As Integer
                i = Me.ccbConsign.FindString(Me.ccbConsign.Text, 0, "SHIPAGENT_ENG")
                Me.ccbConsign.SelectedIndex = i
            End If
        Else
            If Me.ccbConsign.SelectedIndex = -1 Then
                Me.ccbConsign.Text = Me.ccbConsign.Text.Trim.ToUpper
                If Me.ccbConsign.SelectedIndex < 0 Then
                    Dim i As Integer
                    'For i = 0 To dvConsign.Count - 1
                    '    If Me.ccbConsign.Text = Me.ccbConsign.Columns("SHIPAGENT_ENG").CellText(i) Then
                    '        '�����������������ԡ�C1�Ŀؼ����Ǻ��ã�ȡ�ڶ��֣�д����ಢ��MS�ķ�������
                    '        'Me.ccbConsign.Row = i
                    '        Me.ccbConsign.SelectedIndex = i
                    '        'Me.ccbConsign.SelectedValue = Me.ccbConsign.Columns("CODE_SHIP_AGENT").CellText(i)
                    '    End If
                    'Next
                    'C1��Combox��FindString�������ԺͲ�ͬ�ֶ�ƥ�䣬��ͺ��ˣ�����Ҫдѭ����
                    i = Me.ccbConsign.FindString(Me.ccbConsign.Text, 0, "SHIPAGENT_ENG")
                    Me.ccbConsign.SelectedIndex = i
                End If
            End If
        End If
    End Sub

    Private Sub ccbConsign_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ccbConsign.TextChanged
        If Me.ccbConsign.SelectedIndex < 0 Then
            If Me.ccbConsign.Text Like "[a-zA-Z]*" Then
                dvConsign.RowFilter = "SHIPAGENT_ENG like '" & Me.ccbConsign.Text.Trim.ToUpper & "%'"
            Else
                dvConsign.RowFilter = ""
            End If
        End If
    End Sub
    Private Sub cbLoadPort_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbLoadPort.Leave
        If Me.cbLoadPort.SelectedIndex < 0 Then
            Me.cbLoadPort.Text = Me.cbLoadPort.Text.Trim.ToUpper
            If Me.cbLoadPort.SelectedIndex < 0 Then
                Dim i As Integer
                For i = 0 To dvLoadPort.Count - 1
                    If Me.cbLoadPort.Text = Convert.ToString(dvLoadPort(i)("CODE_PORT")) Then
                        Me.cbLoadPort.SelectedIndex = i
                        Exit For
                    End If
                Next
                'FindString�Լ�FindStringExact�������ִ�Сд��������ƥ��DisplayMember�Ŀ�ͷ�ַ�
                'i = Me.cbLoadPort.FindString(Me.cbLoadPort.Text)
                ''i = Me.cbLoadPort.FindStringExact(Me.cbLoadPort.Text)
                'Me.cbLoadPort.SelectedIndex = i
            End If
        End If
    End Sub

    Private Sub cbUnloadPort_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbUnloadPort.Leave
        If Me.cbUnloadPort.SelectedIndex < 0 Then
            Me.cbUnloadPort.Text = Me.cbUnloadPort.Text.Trim.ToUpper
            If Me.cbUnloadPort.SelectedIndex < 0 Then
                Dim i As Integer
                For i = 0 To dvUnloadPort.Count - 1
                    If Me.cbUnloadPort.Text = Convert.ToString(dvUnloadPort(i)("CODE_PORT")) Then
                        Me.cbUnloadPort.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub C1DBG_AfterInsert(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.AfterInsert
        Me.C1DBG.Columns("CONTAINER_NO").FooterText = "�¼�" & dsSubTable.Tables(0).DefaultView.Count & "��"
        Me.C1DBG.Columns("AMOUNT").FooterText = GetDataSum(dsSubTable.Tables(0).DefaultView, "AMOUNT")
        Me.C1DBG.Columns("NetWeight").FooterText = GetDataSum(dsSubTable.Tables(0).DefaultView, "NetWeight")
        Me.C1DBG.Columns("VOLUME").FooterText = GetDataSum(dsSubTable.Tables(0).DefaultView, "VOLUME")
    End Sub

    Private Sub C1DBG_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.AfterDelete
        Me.C1DBG_AfterInsert(sender, e)
    End Sub

    Private Sub FrmConLoadTallyNew_Add_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        strBillNo = Nothing
    End Sub

    Private Sub cbInOutPort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbInOutPort.SelectedIndexChanged
        If Me.cbInOutPort.SelectedValue.GetType Is GetType(String) Then
            If Me.cbInOutPort.SelectedValue = "0" Then      '����
                Me.cbUnloadPort.SelectedValue = "CNLYG"
                If Me.cbUnloadPort.SelectedValue Is Nothing Then
                    Me.cbUnloadPort.SelectedValue = "LYG"
                End If
                Me.cbWorkType.SelectedValue = "1"
            ElseIf Me.cbInOutPort.SelectedValue = "1" Then  '����
                Me.cbLoadPort.SelectedValue = "CNLYG"
                If Me.cbLoadPort.SelectedValue Is Nothing Then
                    Me.cbLoadPort.SelectedValue = "LYG"
                End If
                Me.cbWorkType.SelectedValue = "2"
            End If
        End If
    End Sub

    Private Sub FrmConLoadTallyNew_Add_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtNO.Focused Then
                '    Me.txtTallyClerk.Focus()
                'ElseIf Me.txtTallyClerk.Focused Then
                Me.txtMark.Focus()
            ElseIf Me.txtMark.Focused Then
                Me.ccbGoods.Focus()
            ElseIf Me.ccbGoods.Focused Then
                Me.txtGoodsSpec.Focus()
            ElseIf Me.txtGoodsSpec.Focused Then
                Me.txtAmount.Focus()
            ElseIf Me.txtAmount.Focused Then
                Me.txtTotalNetWeight.Focus()
            ElseIf Me.txtTotalNetWeight.Focused Then
                Me.txtSize.Focus()
            ElseIf Me.txtSize.Focused Then
                Me.cbState.Focus()
            ElseIf Me.cbState.Focused Then
                Me.ccbConsign.Focus()
            ElseIf Me.ccbConsign.Focused Then
                cbInOutPort.Focus()
            ElseIf Me.cbInOutPort.Focused Then
                Me.cbLoadPort.Focus()
            ElseIf Me.cbLoadPort.Focused Then
                Me.cbUnloadPort.Focus()
            ElseIf Me.cbUnloadPort.Focused Then
                Me.cbWorkType.Focus()
            ElseIf Me.cbWorkType.Focused Then
                Me.cbConLoadType.Focus()
            ElseIf Me.cbConLoadType.Focused Then
                Me.dtpTimeBegin.Focus()
            ElseIf Me.dtpTimeBegin.Focused Then
                Me.dtpListDate.Focus()
            ElseIf Me.dtpListDate.Focused Then
                Me.ckbInTrade.Focus()
            ElseIf Me.ckbInTrade.Focused Then
                Me.C1DBG.Focus()
            End If
        End If
    End Sub

    Private Sub MakeCONLOADEDI(ByVal CVessel As String, ByVal Voyage As String, ByVal BLNO As String)
        On Error GoTo Err
        Dim FilePath As String
        Dim str As String
        Dim PathStr As String

        Dim sqlstr As String
        Dim strFile As String
        Dim txtline As String
        Dim ShipOwner As String
        Dim s As String
        Dim dss As New DataSet
        Dim dsm As New DataSet
        Dim dst As New DataSet
        Dim i As Integer = 0 '��¼����
        Dim j As Integer
        Dim k As Integer
        Dim nnnn As String
        Dim Pack As String
        Dim TallyType As String
        Dim Temp As String
        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)

        FilePath = PathStr + "EDIINI.INI"
        Dim sr As New StreamReader(FilePath) '�򿪱����ļ�
        FilePath = sr.ReadLine()
        sr.Close()

        '*****************************************���Ŀ�ʼ
        strFile = FilePath & UCase(CVessel) & UCase(Voyage) & UCase(BLNO) & "9.txt"
        File.Delete(strFile)
        Dim sw As New StreamWriter(strFile, FileMode.OpenOrCreate) '�򿪱����ļ�
        txtline = "00:COSTCO:CONTAINER LOADING LIST:9:LYGWL:LYGXDF:" & Trim(CType(Year(Now), String))
        s = Mid("0" & Trim(CType(Month(Now), String)), Len("0" & Trim(CType(Month(Now), String))) - 1, 2)
        txtline = txtline & s
        s = Mid("0" & Trim(CType(Day(Now), String)), Len("0" & Trim(CType(Day(Now), String))) - 1, 2)
        txtline = txtline & s
        s = Mid("0" & Trim(CType(Hour(Now), String)), Len("0" & Trim(CType(Hour(Now), String))) - 1, 2)
        txtline = txtline & s
        s = Mid("0" & Trim(CType(Minute(Now), String)), Len("0" & Trim(CType(Minute(Now), String))) - 1, 2)
        txtline = txtline & s & "'"
        sw.WriteLine(txtline)
        '*******************************10
        txtline = "10:" & UCase(CVessel) & "::" & UCase(Voyage) & "::::'"
        sw.WriteLine(txtline)
        i = 2
        j = 1
        TallyType = ""
        sqlstr = "select DISTINCT BLNO,CODE_TALLY_TYPE  from CON_LOAD_TALLY where CHI_VESSEL='" & Trim(CVessel) & "' and VOYAGE='" & Trim(Voyage) & "' and BLNO='" & Trim(BLNO) & "'"
        dss.Reset()
        If Getdata(sqlstr, dss).Count > 0 Then
            If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("CODE_TALLY_TYPE")) Then
                If Trim(dss.Tables(0).Rows(j - 1).Item("CODE_TALLY_TYPE")).Length() > 0 Then
                    If Trim(dss.Tables(0).Rows(j - 1).Item("CODE_TALLY_TYPE")) = "4" Then
                        TallyType = "E"
                    ElseIf Trim(dss.Tables(0).Rows(j - 1).Item("CODE_TALLY_TYPE")) = "2" Then
                        TallyType = "L"
                    Else
                        TallyType = "F"
                    End If
                End If
            Else
                TallyType = "F"
            End If
        Else
            TallyType = "F"
        End If
        '*******************************50
        Pack = ""
        sqlstr = "select DISTINCT CONTAINER_NO,SIZE_CON,PACK_CHA,CONTAINER_TYPE,FULLOREMPTY,CheckTime,NEWSEALNO  from CON_LOAD_TALLY_LIST where CHI_VESSEL='" & Trim(CVessel) & "' and VOYAGE='" & Trim(Voyage) & "' and BLNO='" & Trim(BLNO) & "' ORDER BY CONTAINER_NO"
        dsm.Reset()
        If Getdata(sqlstr, dsm).Count > 0 Then
            nnnn = ""
            Do While j <= dsm.Tables(0).Rows.Count
                If Trim(dsm.Tables(0).Rows(j - 1).Item("CONTAINER_NO")) <> nnnn Then
                    txtline = "50:" & Trim(dsm.Tables(0).Rows(j - 1).Item("CONTAINER_NO")) & ":"
                    txtline = txtline & Trim(dsm.Tables(0).Rows(j - 1).Item("SIZE_CON"))
                    txtline = txtline & Trim(dsm.Tables(0).Rows(j - 1).Item("CONTAINER_TYPE"))
                    If Not IsDBNull(TallyType) Then
                        If Trim(TallyType).Length() > 0 Then
                            txtline = txtline & ":" & Trim(TallyType) & ":0:"
                        Else

                            txtline = txtline & "::0:"
                        End If
                    Else
                        txtline = txtline & "::0:"
                    End If
                    txtline = txtline & Trim(CType(Year(dsm.Tables(0).Rows(j - 1).Item("CheckTime")), String))
                    s = Mid("0" & Trim(CType(Month(dsm.Tables(0).Rows(j - 1).Item("CheckTime")), String)), Len("0" & Trim(CType(Month(dsm.Tables(0).Rows(j - 1).Item("CheckTime")), String))) - 1, 2)
                    txtline = txtline & s
                    s = Mid("0" & Trim(CType(Day(dsm.Tables(0).Rows(j - 1).Item("CheckTime")), String)), Len("0" & Trim(CType(Day(dsm.Tables(0).Rows(j - 1).Item("CheckTime")), String))) - 1, 2)
                    txtline = txtline & s
                    s = Mid("0" & Trim(CType(Hour(dsm.Tables(0).Rows(j - 1).Item("CheckTime")), String)), Len("0" & Trim(CType(Hour(dsm.Tables(0).Rows(j - 1).Item("CheckTime")), String))) - 1, 2)
                    txtline = txtline & s
                    s = Mid("0" & Trim(CType(Minute(dsm.Tables(0).Rows(j - 1).Item("CheckTime")), String)), Len("0" & Trim(CType(Minute(dsm.Tables(0).Rows(j - 1).Item("CheckTime")), String))) - 1, 2)
                    txtline = txtline & s
                    txtline = txtline & ":" & Trim(dss.Tables(0).Rows(j - 1).Item("NEWSEALNO")) & ":"
                    txtline = txtline & ":" '& Trim(dss.Tables(0).Rows(j - 1).Item("CODE_KEEPER"))
                    txtline = txtline & "::::::'"
                    sw.WriteLine(txtline)
                    i = i + 1
                    nnnn = Trim(dsm.Tables(0).Rows(j - 1).Item("CONTAINER_NO"))
                End If
                If Trim(dsm.Tables(0).Rows(j - 1).Item("PACK_CHA")).Length > 0 Then
                    Pack = Trim(dsm.Tables(0).Rows(j - 1).Item("PACK_CHA"))
                End If
                j = j + 1
            Loop
        End If
        '***************************** �ᵥѭ��
        sqlstr = "select DISTINCT BLNO,AMOUNT,TOTALNETWEIGHT,SIZE_MEASURE,GOODSCHA,REEFERTEMP,TEMPUNIT,MARK,DANGERGRADE,DANGERMARK,CODELOADPORT,CODEUNLOADPORT,CODEDELIVERY  from CON_LOAD_TALLY where CHI_VESSEL='" & Trim(CVessel) & "' and VOYAGE='" & Trim(Voyage) & "' and BLNO='" & Trim(BLNO) & "'"
        dss.Reset()
        If Getdata(sqlstr, dss).Count > 0 Then
            j = 1
            Do While j <= dss.Tables(0).Rows.Count
                '************************************51
                txtline = "51:" & Trim(dss.Tables(0).Rows(j - 1).Item("BLNO"))

                txtline = txtline & ":"
                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("CODEUNLOADPORT")) Then
                    If Trim(dss.Tables(0).Rows(j - 1).Item("CODEUNLOADPORT")).Length() > 0 Then
                        txtline = txtline & Trim(dss.Tables(0).Rows(j - 1).Item("CODEUNLOADPORT")) & ":" & FindPort(Trim(dss.Tables(0).Rows(j - 1).Item("CODEUNLOADPORT"))) & ":"
                    Else
                        txtline = txtline & "::"
                    End If
                Else
                    txtline = txtline & "::"
                End If
                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("CODELOADPORT")) Then
                    If Trim(dss.Tables(0).Rows(j - 1).Item("CODELOADPORT")).Length() > 0 Then
                        txtline = txtline & Trim(dss.Tables(0).Rows(j - 1).Item("CODELOADPORT")) & ":" & FindPort(Trim(dss.Tables(0).Rows(j - 1).Item("CODELOADPORT"))) & ":"
                    Else
                        txtline = txtline & "::"
                    End If
                Else
                    txtline = txtline & "::"
                End If
                txtline = txtline & "::"
                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("CODEDELIVERY")) Then
                    If Trim(dss.Tables(0).Rows(j - 1).Item("CODEDELIVERY")).Length() > 0 Then
                        txtline = txtline & Trim(dss.Tables(0).Rows(j - 1).Item("CODEDELIVERY")) & ":" & FindPort(Trim(dss.Tables(0).Rows(j - 1).Item("CODEDELIVERY")))
                    Else
                        txtline = txtline & ":"
                    End If
                Else
                    txtline = txtline & ":"
                End If

                txtline = txtline & "'"
                sw.WriteLine(txtline)
                i = i + 1
                '************************************52
                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("AMOUNT")) Then
                    txtline = "52:" & j.ToString() & ":" & Trim(dss.Tables(0).Rows(j - 1).Item("AMOUNT")) & "::" & Trim(Pack) & ":"
                Else
                    txtline = "52:" & j.ToString() & ":::" & Trim(Pack) & ":"
                End If
                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("TOTALNETWEIGHT")) Then
                    If Trim(dss.Tables(0).Rows(j - 1).Item("TOTALNETWEIGHT")).Length() > 0 Then
                        txtline = txtline & Trim(CType(dss.Tables(0).Rows(j - 1).Item("TOTALNETWEIGHT"), Single).ToString()) & ":"
                    Else
                        txtline = txtline & ":"
                    End If
                Else
                    txtline = txtline & ":"
                End If
                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("SIZE_MEASURE")) Then
                    If Trim(dss.Tables(0).Rows(j - 1).Item("SIZE_MEASURE")).Length() > 0 Then
                        txtline = txtline & Trim(CType(dss.Tables(0).Rows(j - 1).Item("SIZE_MEASURE"), Single).ToString()) & ":"
                    Else
                        txtline = txtline & ":"
                    End If
                Else
                    txtline = txtline & ":"
                End If

                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("TEMPUNIT")) Then
                    If Trim(dss.Tables(0).Rows(j - 1).Item("TEMPUNIT")).Length() > 0 Then
                        'If dss.Tables(0).Rows(j - 1).Item("Refrigerate_Temperature") <> 0 Then
                        'Ҫ�����¶ȼ�����
                        Dim strTemp As String
                        strTemp = dss.Tables(0).Rows(j - 1).Item("REEFERTEMP")
                        If strTemp Like "#*" Then
                            strTemp = "+" & strTemp
                        End If
                        txtline = txtline & Trim(dss.Tables(0).Rows(j - 1).Item("TEMPUNIT")) & ":" & strTemp & "::'"
                        'txtline = txtline & "C:" & Trim(CType(dss.Tables(0).Rows(j - 1).Item("Refrigerate_Temperature"), Single).ToString()) & "::'"
                    Else
                        txtline = txtline & ":::'"
                    End If
                Else
                    txtline = txtline & ":::'"
                End If
                sw.WriteLine(txtline)
                i = i + 1
                '************************************53
                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("GOODSCHA")) Then
                    'txtline = "53:" '& Trim(dss.Tables(0).Rows(j - 1).Item("GOODSCHA")) & "'"
                    txtline = "53" '& Trim(dss.Tables(0).Rows(j - 1).Item("GOODSCHA")) & "'"
                    Temp = Trim(dss.Tables(0).Rows(j - 1).Item("GOODSCHA"))
                    Do While Temp.Length > 70
                        txtline = txtline & ":" & Mid(Temp, 1, 70)
                        Temp = Mid(Temp, 71)
                    Loop
                    txtline = txtline & ":" & Temp & "'"
                Else
                    txtline = "53:'"
                End If
                sw.WriteLine(txtline)
                i = i + 1
                '************************************54
                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("MARK")) Then
                    'txtline = "54:" & Trim(dss.Tables(0).Rows(j - 1).Item("MARK")) & "'"
                    txtline = "54" '& Trim(dss.Tables(0).Rows(j - 1).Item("GOODSCHA")) & "'"
                    Temp = Trim(dss.Tables(0).Rows(j - 1).Item("MARKS"))
                    Do While Temp.Length > 70
                        txtline = txtline & ":" & Mid(Temp, 1, 70)
                        Temp = Mid(Temp, 71)
                    Loop
                    txtline = txtline & ":" & Temp & "'"
                Else
                    txtline = "54:'"
                End If
                sw.WriteLine(txtline)
                i = i + 1
                '************************************55
                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("DANGERGRADE")) Then
                    If Trim(dss.Tables(0).Rows(j - 1).Item("DANGERGRADE")).Length() > 0 Then
                        txtline = "55:" & Trim(dss.Tables(0).Rows(j - 1).Item("DANGERGRADE")) & ":"
                        txtline = txtline & ":"
                        txtline = txtline & ":"
                        txtline = txtline & Trim(dss.Tables(0).Rows(j - 1).Item("DANGERMARK")) & "::::'"
                        sw.WriteLine(txtline)
                        i = i + 1
                    End If
                End If

                '************************************56
                dst.Reset()
                sqlstr = "select CONTAINER_NO,SIZE_CON,AMOUNT,WEIGHT,NETWEIGHT,VOLUME from CON_LOAD_TALLY_LIST where CHI_VESSEL='" & Trim(CVessel) & "' and VOYAGE='" & Trim(Voyage) & "' and BLNO='" & Trim(BLNO) & "' ORDER BY CONTAINER_NO"
                If Getdata(sqlstr, dst).Count > 0 Then
                    k = 1
                    Do While k <= dst.Tables(0).Rows.Count
                        txtline = "56:" & Trim(dst.Tables(0).Rows(k - 1).Item("CONTAINER_NO")) & ":"
                        If Not IsDBNull(dst.Tables(0).Rows(k - 1).Item("AMOUNT")) Then
                            If Trim(dst.Tables(0).Rows(k - 1).Item("AMOUNT")).Length() > 0 Then
                                txtline = txtline & Trim(dst.Tables(0).Rows(k - 1).Item("AMOUNT")) & ":"
                            Else
                                txtline = txtline & ":"
                            End If
                        Else
                            txtline = txtline & ":"
                        End If
                        If Trim(dst.Tables(0).Rows(k - 1).Item("SIZE_CON")) = "20" Then
                            txtline = txtline & "2300:" '***************Ƥ��
                        ElseIf Trim(dst.Tables(0).Rows(k - 1).Item("SIZE_CON")) = "40" Then
                            txtline = txtline & "3800:" '***************Ƥ��
                        ElseIf Trim(dst.Tables(0).Rows(k - 1).Item("SIZE_CON")) = "45" Then
                            txtline = txtline & "4700:" '***************Ƥ��
                        Else
                            txtline = txtline & ":"
                        End If
                        If Not IsDBNull(dst.Tables(0).Rows(k - 1).Item("NETWEIGHT")) Then
                            If Trim(dst.Tables(0).Rows(k - 1).Item("NETWEIGHT")).Length() > 0 Then
                                txtline = txtline & Trim(CType(dst.Tables(0).Rows(k - 1).Item("NETWEIGHT"), Single).ToString()) & ":"
                            Else
                                txtline = txtline & ":"
                            End If
                        Else
                            txtline = txtline & ":"
                        End If


                        If Not IsDBNull(dst.Tables(0).Rows(k - 1).Item("VOLUME")) Then
                            If Trim(dst.Tables(0).Rows(k - 1).Item("VOLUME")).Length() > 0 Then
                                txtline = txtline & Trim(CType(dst.Tables(0).Rows(k - 1).Item("VOLUME"), Single).ToString())
                            Else
                                txtline = txtline
                            End If
                        Else
                            txtline = txtline
                        End If
                        txtline = txtline & "'"
                        sw.WriteLine(txtline)
                        i = i + 1
                        k = k + 1
                    Loop
                End If

                j = j + 1
            Loop

        End If
        txtline = "99:" & i + 1 & "'"
        sw.WriteLine(txtline)
        MsgBox("������������ϣ��� " & i + 1 & " �� ")
        sw.Close()
        Exit Sub
Err:
        'MsgBox("�������ɳ����ڣ�" & Trim(dss.Tables(0).Rows(j - 1).Item("CONTAINER_NO")))
        Resume Next

    End Sub

    Private Function FindPort(ByVal Port As String) As String
        Dim dsPort As New DataSet
        Dim dwPort As New DataView
        Dim str As String
        str = "select * from Code_Port where Code_Port='" & Port & "'"
        dsPort.Reset()
        dwPort = Getdata(str, dsPort)
        If dwPort.Count > 0 Then
            FindPort = dsPort.Tables(0).Rows(0).Item("PORT_ENG")
        Else
            FindPort = Port
        End If
    End Function

    Private Sub C1DBGE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1DBGE.KeyDown
        If e.KeyCode = Keys.Enter AndAlso Me.C1DBGE.Col = 13 Then
            Me.C1DBGE.Row += 1
            Me.C1DBGE.Col = 1
            SendKeys.Send("{Left}")
        End If
    End Sub

    Private Sub C1DBGE_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles C1DBGE.RowColChange
        If Not Me.C1DBGE.DataSource Is Nothing AndAlso Me.C1DBGE.Row <> e.LastRow Then
            Me.C1DBGE.Columns("SIZE_CON").FooterText = "��" & (Me.C1DBGE.Row + 1) & "��"
        End If
    End Sub

    Private Sub C1DBGE_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBGE.FetchRowStyle
        If Me.C1DBGE.Columns("CodeYard").CellValue(e.Row) <> strYCode Then
            e.CellStyle.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub cbConLoadType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbConLoadType.SelectedIndexChanged
        If Not C1DBG.DataSource Is Nothing Then
            If Not cbConLoadType.DataSource Is Nothing Then
                If cbConLoadType.SelectedValue = "B" Then
                    C1DBG.Splits(0).DisplayColumns("OutStorage").Visible = True
                Else
                    C1DBG.Splits(0).DisplayColumns("OutStorage").Visible = False
                End If
                C1DBGE.Splits(0).DisplayColumns("OutStorage").Visible = C1DBG.Splits(0).DisplayColumns("OutStorage").Visible
            End If
        End If
    End Sub
End Class
