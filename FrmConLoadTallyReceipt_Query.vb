Imports TALLY.DBControl
Public Class FrmConLoadTallyReceipt_Query
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dsSubTable As New DataSet()
    Dim sqlSubTableda As New SqlClient.SqlDataAdapter()
    Dim dw As New DataView
    Dim sqlSubTable As String
    Dim dvSubTable As New DataView

    Dim sqlCodeYard As String
    Dim dvCodeYard As New DataView()
    Dim strGoodsName As String
    Dim Count, DelSum As Integer

    Dim strShipCodeOg, strVoyageOg, strBillNoOg, strCodeYardOg As String
    Dim shipMark As Boolean

    Dim sqlShipCode As String
    Dim dvShipCode As New DataView
    Dim GetDataSure As Boolean = True
    Public Shared CheckMark As Boolean

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        AddHandler txtShip.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler txtVoyage.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler cbInOutPort.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler cbLoadPort.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler cbUnloadPort.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler cbDelivery.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler cbWorkType.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler cbConLoadType.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler dtpTimeBegin.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler txtBillNO.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler txtMark.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler cbGoodsCode.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler txtGoodsSpec.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler txtAmount.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler txtTotalWeight.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler txtTotalNetWeight.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler txtSize.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler txtReeferTemp.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler cbTempUnit.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler txtDangerGrade.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler txtDangerMark.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler cbDescribe.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler cbState.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler txtBargainNO.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler txtShiper.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler txtReceiver.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler txtNotify.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler txtTallyClerk.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler txtCrossPerson.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler cbConsign.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
        AddHandler dtpListDate.KeyDown, AddressOf FrmConLoadTallyReceipt_Query_KeyDown
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
    Friend WithEvents cbTempUnit As System.Windows.Forms.ComboBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtNotify As System.Windows.Forms.TextBox
    Friend WithEvents txtShiper As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtDangerMark As System.Windows.Forms.TextBox
    Friend WithEvents txtDangerGrade As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtTotalNetWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cbInOutPort As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbUnloadPort As System.Windows.Forms.ComboBox
    Friend WithEvents cbLoadPort As System.Windows.Forms.ComboBox
    Friend WithEvents cbDelivery As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents cbPlace As System.Windows.Forms.ComboBox
    Friend WithEvents txtBargainNO As System.Windows.Forms.TextBox
    Friend WithEvents txtReceiver As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSize As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtTotalWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cbConsign As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cbState As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cbDescribe As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cbWorkType As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dtpListDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbGoodsCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCrossPerson As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtTallyClerk As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtMark As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbConLoadType As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBillNO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNO As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtShip As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents txtReeferTemp As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btnGetData As System.Windows.Forms.Button
    Friend WithEvents txtGoodsSpec As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConLoadTallyReceipt_Query))
        Me.cbTempUnit = New System.Windows.Forms.ComboBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.txtNotify = New System.Windows.Forms.TextBox
        Me.txtShiper = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.txtDangerMark = New System.Windows.Forms.TextBox
        Me.txtDangerGrade = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtTotalNetWeight = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.cbInOutPort = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cbUnloadPort = New System.Windows.Forms.ComboBox
        Me.cbLoadPort = New System.Windows.Forms.ComboBox
        Me.cbDelivery = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.cbPlace = New System.Windows.Forms.ComboBox
        Me.txtBargainNO = New System.Windows.Forms.TextBox
        Me.txtReceiver = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtSize = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtTotalWeight = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.cbConsign = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.cbState = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.cbDescribe = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.cbWorkType = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.dtpListDate = New System.Windows.Forms.DateTimePicker
        Me.cbGoodsCode = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtCrossPerson = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtTallyClerk = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtMark = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtpTimeBegin = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbConLoadType = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtBillNO = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNO = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtShip = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.btQuit = New System.Windows.Forms.Button
        Me.txtReeferTemp = New System.Windows.Forms.TextBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btSave = New System.Windows.Forms.Button
        Me.btnGetData = New System.Windows.Forms.Button
        Me.txtGoodsSpec = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbTempUnit
        '
        Me.cbTempUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTempUnit.Items.AddRange(New Object() {"", "C", "F"})
        Me.cbTempUnit.Location = New System.Drawing.Point(380, 248)
        Me.cbTempUnit.Name = "cbTempUnit"
        Me.cbTempUnit.Size = New System.Drawing.Size(42, 20)
        Me.cbTempUnit.TabIndex = 18
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(218, 248)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 18)
        Me.Label36.TabIndex = 633
        Me.Label36.Text = "冷藏温度"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(430, 176)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(72, 18)
        Me.Label31.TabIndex = 632
        Me.Label31.Text = "通知方"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNotify
        '
        Me.txtNotify.Location = New System.Drawing.Point(504, 174)
        Me.txtNotify.MaxLength = 30
        Me.txtNotify.Name = "txtNotify"
        Me.txtNotify.Size = New System.Drawing.Size(130, 21)
        Me.txtNotify.TabIndex = 25
        Me.txtNotify.Text = ""
        '
        'txtShiper
        '
        Me.txtShiper.Location = New System.Drawing.Point(504, 126)
        Me.txtShiper.MaxLength = 30
        Me.txtShiper.Name = "txtShiper"
        Me.txtShiper.Size = New System.Drawing.Size(130, 21)
        Me.txtShiper.TabIndex = 23
        Me.txtShiper.Text = ""
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(430, 128)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(72, 18)
        Me.Label33.TabIndex = 631
        Me.Label33.Text = "发货人"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(430, 32)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(72, 18)
        Me.Label34.TabIndex = 630
        Me.Label34.Text = "危险品标签"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDangerMark
        '
        Me.txtDangerMark.Location = New System.Drawing.Point(504, 30)
        Me.txtDangerMark.MaxLength = 32
        Me.txtDangerMark.Name = "txtDangerMark"
        Me.txtDangerMark.Size = New System.Drawing.Size(130, 21)
        Me.txtDangerMark.TabIndex = 20
        Me.txtDangerMark.Text = ""
        '
        'txtDangerGrade
        '
        Me.txtDangerGrade.Location = New System.Drawing.Point(292, 270)
        Me.txtDangerGrade.MaxLength = 10
        Me.txtDangerGrade.Name = "txtDangerGrade"
        Me.txtDangerGrade.Size = New System.Drawing.Size(130, 21)
        Me.txtDangerGrade.TabIndex = 19
        Me.txtDangerGrade.Text = ""
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(218, 272)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(72, 18)
        Me.Label30.TabIndex = 629
        Me.Label30.Text = "危险品等级"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(392, 200)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(30, 20)
        Me.Label28.TabIndex = 628
        Me.Label28.Text = "公斤"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalNetWeight
        '
        Me.txtTotalNetWeight.Location = New System.Drawing.Point(292, 198)
        Me.txtTotalNetWeight.MaxLength = 10
        Me.txtTotalNetWeight.Name = "txtTotalNetWeight"
        Me.txtTotalNetWeight.TabIndex = 15
        Me.txtTotalNetWeight.Text = ""
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(218, 200)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 18)
        Me.Label29.TabIndex = 627
        Me.Label29.Text = "总货重"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbInOutPort
        '
        Me.cbInOutPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbInOutPort.Location = New System.Drawing.Point(80, 174)
        Me.cbInOutPort.MaxDropDownItems = 20
        Me.cbInOutPort.Name = "cbInOutPort"
        Me.cbInOutPort.Size = New System.Drawing.Size(130, 20)
        Me.cbInOutPort.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(6, 176)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 18)
        Me.Label12.TabIndex = 626
        Me.Label12.Text = "进出口"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbUnloadPort
        '
        Me.cbUnloadPort.Location = New System.Drawing.Point(80, 222)
        Me.cbUnloadPort.MaxDropDownItems = 20
        Me.cbUnloadPort.Name = "cbUnloadPort"
        Me.cbUnloadPort.Size = New System.Drawing.Size(130, 20)
        Me.cbUnloadPort.TabIndex = 6
        '
        'cbLoadPort
        '
        Me.cbLoadPort.Location = New System.Drawing.Point(80, 198)
        Me.cbLoadPort.MaxDropDownItems = 20
        Me.cbLoadPort.Name = "cbLoadPort"
        Me.cbLoadPort.Size = New System.Drawing.Size(130, 20)
        Me.cbLoadPort.TabIndex = 5
        '
        'cbDelivery
        '
        Me.cbDelivery.Location = New System.Drawing.Point(80, 246)
        Me.cbDelivery.MaxDropDownItems = 20
        Me.cbDelivery.Name = "cbDelivery"
        Me.cbDelivery.Size = New System.Drawing.Size(130, 20)
        Me.cbDelivery.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(6, 248)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 624
        Me.Label10.Text = "收货地"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(6, 200)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 18)
        Me.Label11.TabIndex = 625
        Me.Label11.Text = "装货港"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(6, 224)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(72, 18)
        Me.Label32.TabIndex = 623
        Me.Label32.Text = "卸货港"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbPlace
        '
        Me.cbPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlace.Location = New System.Drawing.Point(80, 126)
        Me.cbPlace.Name = "cbPlace"
        Me.cbPlace.Size = New System.Drawing.Size(130, 20)
        Me.cbPlace.TabIndex = 566
        '
        'txtBargainNO
        '
        Me.txtBargainNO.Location = New System.Drawing.Point(504, 102)
        Me.txtBargainNO.MaxLength = 20
        Me.txtBargainNO.Name = "txtBargainNO"
        Me.txtBargainNO.Size = New System.Drawing.Size(130, 21)
        Me.txtBargainNO.TabIndex = 22
        Me.txtBargainNO.Text = ""
        '
        'txtReceiver
        '
        Me.txtReceiver.Location = New System.Drawing.Point(504, 150)
        Me.txtReceiver.MaxLength = 30
        Me.txtReceiver.Name = "txtReceiver"
        Me.txtReceiver.Size = New System.Drawing.Size(130, 21)
        Me.txtReceiver.TabIndex = 24
        Me.txtReceiver.Text = ""
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(430, 152)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 18)
        Me.Label26.TabIndex = 622
        Me.Label26.Text = "收货人"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(430, 104)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 18)
        Me.Label27.TabIndex = 621
        Me.Label27.Text = "合同编号"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(392, 224)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 20)
        Me.Label13.TabIndex = 620
        Me.Label13.Text = "立方"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(292, 222)
        Me.txtSize.MaxLength = 40
        Me.txtSize.Name = "txtSize"
        Me.txtSize.TabIndex = 16
        Me.txtSize.Text = ""
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(218, 224)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 18)
        Me.Label19.TabIndex = 619
        Me.Label19.Text = "总尺码"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(392, 176)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(30, 20)
        Me.Label23.TabIndex = 618
        Me.Label23.Text = "公斤"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalWeight
        '
        Me.txtTotalWeight.Location = New System.Drawing.Point(292, 174)
        Me.txtTotalWeight.MaxLength = 10
        Me.txtTotalWeight.Name = "txtTotalWeight"
        Me.txtTotalWeight.TabIndex = 14
        Me.txtTotalWeight.Text = ""
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(210, 176)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 18)
        Me.Label24.TabIndex = 617
        Me.Label24.Text = "总重(含箱皮)"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(292, 150)
        Me.txtAmount.MaxLength = 10
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(130, 21)
        Me.txtAmount.TabIndex = 13
        Me.txtAmount.Text = ""
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(218, 152)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 18)
        Me.Label25.TabIndex = 616
        Me.Label25.Text = "总件数"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbConsign
        '
        Me.cbConsign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConsign.Location = New System.Drawing.Point(504, 246)
        Me.cbConsign.MaxDropDownItems = 20
        Me.cbConsign.Name = "cbConsign"
        Me.cbConsign.Size = New System.Drawing.Size(130, 20)
        Me.cbConsign.TabIndex = 28
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(430, 248)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 18)
        Me.Label22.TabIndex = 615
        Me.Label22.Text = "委托单位"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbState
        '
        Me.cbState.Items.AddRange(New Object() {"", "全已装箱", "部分装箱", "拆箱"})
        Me.cbState.Location = New System.Drawing.Point(504, 78)
        Me.cbState.MaxDropDownItems = 20
        Me.cbState.Name = "cbState"
        Me.cbState.Size = New System.Drawing.Size(130, 20)
        Me.cbState.TabIndex = 21
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(430, 80)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 18)
        Me.Label21.TabIndex = 614
        Me.Label21.Text = "货物处于"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbDescribe
        '
        Me.cbDescribe.Enabled = False
        Me.cbDescribe.Items.AddRange(New Object() {"", "全部抵运", "部分抵运"})
        Me.cbDescribe.Location = New System.Drawing.Point(504, 54)
        Me.cbDescribe.MaxDropDownItems = 20
        Me.cbDescribe.Name = "cbDescribe"
        Me.cbDescribe.Size = New System.Drawing.Size(130, 20)
        Me.cbDescribe.TabIndex = 588
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(430, 56)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 18)
        Me.Label20.TabIndex = 613
        Me.Label20.Text = "货箱抵运"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbWorkType
        '
        Me.cbWorkType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWorkType.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbWorkType.Location = New System.Drawing.Point(292, 30)
        Me.cbWorkType.Name = "cbWorkType"
        Me.cbWorkType.Size = New System.Drawing.Size(130, 20)
        Me.cbWorkType.TabIndex = 9
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(218, 32)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 18)
        Me.Label18.TabIndex = 612
        Me.Label18.Text = "工作类别"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpListDate
        '
        Me.dtpListDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpListDate.Location = New System.Drawing.Point(504, 270)
        Me.dtpListDate.Name = "dtpListDate"
        Me.dtpListDate.Size = New System.Drawing.Size(130, 21)
        Me.dtpListDate.TabIndex = 29
        '
        'cbGoodsCode
        '
        Me.cbGoodsCode.Location = New System.Drawing.Point(292, 102)
        Me.cbGoodsCode.MaxDropDownItems = 20
        Me.cbGoodsCode.MaxLength = 60
        Me.cbGoodsCode.Name = "cbGoodsCode"
        Me.cbGoodsCode.Size = New System.Drawing.Size(130, 20)
        Me.cbGoodsCode.TabIndex = 12
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(218, 104)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 18)
        Me.Label17.TabIndex = 611
        Me.Label17.Text = "货名"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCrossPerson
        '
        Me.txtCrossPerson.Location = New System.Drawing.Point(504, 222)
        Me.txtCrossPerson.MaxLength = 10
        Me.txtCrossPerson.Name = "txtCrossPerson"
        Me.txtCrossPerson.Size = New System.Drawing.Size(130, 21)
        Me.txtCrossPerson.TabIndex = 27
        Me.txtCrossPerson.Text = ""
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(430, 224)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 18)
        Me.Label16.TabIndex = 610
        Me.Label16.Text = "交接人员"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTallyClerk
        '
        Me.txtTallyClerk.Location = New System.Drawing.Point(504, 198)
        Me.txtTallyClerk.MaxLength = 10
        Me.txtTallyClerk.Name = "txtTallyClerk"
        Me.txtTallyClerk.Size = New System.Drawing.Size(130, 21)
        Me.txtTallyClerk.TabIndex = 26
        Me.txtTallyClerk.Text = ""
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(430, 200)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 18)
        Me.Label15.TabIndex = 609
        Me.Label15.Text = "理货员"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(430, 272)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 18)
        Me.Label14.TabIndex = 608
        Me.Label14.Text = "制单日期"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(292, 78)
        Me.txtMark.MaxLength = 20
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(130, 21)
        Me.txtMark.TabIndex = 11
        Me.txtMark.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(218, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 607
        Me.Label9.Text = "标志"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeBegin
        '
        Me.dtpTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeBegin.Location = New System.Drawing.Point(80, 270)
        Me.dtpTimeBegin.Name = "dtpTimeBegin"
        Me.dtpTimeBegin.Size = New System.Drawing.Size(130, 21)
        Me.dtpTimeBegin.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 272)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 605
        Me.Label7.Text = "装箱时间"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbConLoadType
        '
        Me.cbConLoadType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConLoadType.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbConLoadType.Location = New System.Drawing.Point(292, 54)
        Me.cbConLoadType.Name = "cbConLoadType"
        Me.cbConLoadType.Size = New System.Drawing.Size(130, 20)
        Me.cbConLoadType.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(218, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 604
        Me.Label6.Text = "折装箱类别"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBillNO
        '
        Me.txtBillNO.Location = New System.Drawing.Point(80, 102)
        Me.txtBillNO.MaxLength = 120
        Me.txtBillNO.Name = "txtBillNO"
        Me.txtBillNO.Size = New System.Drawing.Size(130, 21)
        Me.txtBillNO.TabIndex = 2
        Me.txtBillNO.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 603
        Me.Label4.Text = "提单号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 602
        Me.Label5.Text = "工作地点"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNO
        '
        Me.txtNO.Enabled = False
        Me.txtNO.Location = New System.Drawing.Point(80, 4)
        Me.txtNO.MaxLength = 20
        Me.txtNO.Name = "txtNO"
        Me.txtNO.Size = New System.Drawing.Size(130, 21)
        Me.txtNO.TabIndex = 565
        Me.txtNO.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 601
        Me.Label3.Text = "理货单编号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(80, 78)
        Me.txtVoyage.MaxLength = 6
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(130, 21)
        Me.txtVoyage.TabIndex = 1
        Me.txtVoyage.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 600
        Me.Label1.Text = "航次"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShip
        '
        Me.txtShip.Location = New System.Drawing.Point(80, 30)
        Me.txtShip.MaxLength = 40
        Me.txtShip.Name = "txtShip"
        Me.txtShip.Size = New System.Drawing.Size(130, 21)
        Me.txtShip.TabIndex = 0
        Me.txtShip.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 599
        Me.Label2.Text = "船名码"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(0, 0)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 598
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(322, 572)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 32
        Me.btQuit.Text = "返回"
        '
        'txtReeferTemp
        '
        Me.txtReeferTemp.Location = New System.Drawing.Point(292, 246)
        Me.txtReeferTemp.MaxLength = 10
        Me.txtReeferTemp.Name = "txtReeferTemp"
        Me.txtReeferTemp.Size = New System.Drawing.Size(88, 21)
        Me.txtReeferTemp.TabIndex = 17
        Me.txtReeferTemp.Text = ""
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(6, 56)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(72, 18)
        Me.Label35.TabIndex = 635
        Me.Label35.Text = "船名"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShipName
        '
        Me.txtShipName.BackColor = System.Drawing.Color.Lavender
        Me.txtShipName.Location = New System.Drawing.Point(80, 54)
        Me.txtShipName.MaxLength = 40
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.ReadOnly = True
        Me.txtShipName.Size = New System.Drawing.Size(130, 21)
        Me.txtShipName.TabIndex = 634
        Me.txtShipName.Text = ""
        '
        'C1DBG
        '
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 296)
        Me.C1DBG.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.RecordSelectorWidth = 16
        Me.C1DBG.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1DBG.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG.RowHeight = 16
        Me.C1DBG.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG.Size = New System.Drawing.Size(638, 270)
        Me.C1DBG.TabIndex = 30
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle12{}OddRow{}RecordSelector{AlignImage:Center;}Style13{}Heading{Wrap:True;Back" & _
        "Color:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style14{}Style15{}Style9{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSele" & _
        "ctorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><ClientRect>0, 0, 634, 266</ClientRect><BorderSide>0</BorderSide><CaptionSt" & _
        "yle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><E" & _
        "venRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me" & _
        "=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Grou" & _
        "p"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyl" & _
        "e parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style" & _
        "4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""Rec" & _
        "ordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Styl" & _
        "e parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedS" & _
        "tyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Styl" & _
        "e parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style p" & _
        "arent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style pa" & _
        "rent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style pa" & _
        "rent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=" & _
        """Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style p" & _
        "arent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits" & _
        ">1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><" & _
        "ClientArea>0, 0, 634, 266</ClientArea><PrintPageHeaderStyle parent="""" me=""Style1" & _
        "4"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(250, 572)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 31
        Me.btSave.Text = "装箱确认"
        '
        'btnGetData
        '
        Me.btnGetData.Location = New System.Drawing.Point(88, 148)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New System.Drawing.Size(65, 24)
        Me.btnGetData.TabIndex = 3
        Me.btnGetData.Text = "查找"
        '
        'txtGoodsSpec
        '
        Me.txtGoodsSpec.Location = New System.Drawing.Point(292, 126)
        Me.txtGoodsSpec.MaxLength = 50
        Me.txtGoodsSpec.Name = "txtGoodsSpec"
        Me.txtGoodsSpec.Size = New System.Drawing.Size(130, 21)
        Me.txtGoodsSpec.TabIndex = 636
        Me.txtGoodsSpec.Text = ""
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(218, 128)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(72, 18)
        Me.Label37.TabIndex = 637
        Me.Label37.Text = "规格"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmConLoadTallyReceipt_Query
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(638, 600)
        Me.Controls.Add(Me.txtGoodsSpec)
        Me.Controls.Add(Me.txtShipName)
        Me.Controls.Add(Me.txtNotify)
        Me.Controls.Add(Me.txtShiper)
        Me.Controls.Add(Me.txtDangerMark)
        Me.Controls.Add(Me.txtDangerGrade)
        Me.Controls.Add(Me.txtTotalNetWeight)
        Me.Controls.Add(Me.txtBargainNO)
        Me.Controls.Add(Me.txtReceiver)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.txtTotalWeight)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtCrossPerson)
        Me.Controls.Add(Me.txtTallyClerk)
        Me.Controls.Add(Me.txtMark)
        Me.Controls.Add(Me.txtBillNO)
        Me.Controls.Add(Me.txtNO)
        Me.Controls.Add(Me.txtVoyage)
        Me.Controls.Add(Me.txtShip)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtReeferTemp)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.btnGetData)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.cbTempUnit)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.cbInOutPort)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbUnloadPort)
        Me.Controls.Add(Me.cbLoadPort)
        Me.Controls.Add(Me.cbDelivery)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.cbPlace)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.cbConsign)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cbState)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.cbDescribe)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cbWorkType)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.dtpListDate)
        Me.Controls.Add(Me.cbGoodsCode)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtpTimeBegin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbConLoadType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btQuit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConLoadTallyReceipt_Query"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "装拆箱提单场站信息 查看"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmConLoadTallyReceipt_Query_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckMark = False
        On Error GoTo Err
        Dim dvCodeGoods As New DataView
        Dim sqlstr, sqlCodeGoods As String
        Me.StartPosition = FormStartPosition.CenterScreen

        Dim dvWorkType As New DataView()
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

        Dim sqlConsign As String
        sqlConsign = "SELECT CODE_SHIP_AGENT, SHIPAGENT_SHORT, SHIPAGENT_ENG FROM CODE_SHIP_AGENT where Mark <> '1' OR Mark IS NULL ORDER BY SHIPAGENT_SHORT"
        cbConsign.DataSource = Filldata(sqlConsign)
        cbConsign.DisplayMember = "SHIPAGENT_SHORT"
        cbConsign.ValueMember = "CODE_SHIP_AGENT"

        sqlCodeGoods = "select Code,Goods from CodeGoods where ConLoadMark='1' "
        dvCodeGoods = Filldata(sqlCodeGoods)
        cbGoodsCode.DataSource = dvCodeGoods
        cbGoodsCode.DisplayMember = "Goods"
        cbGoodsCode.ValueMember = "Code"

        '只取出本部门以及下属部门的
        sqlCodeYard = "SELECT Code_Yard_ID, Code_Yard_Name, CodePrefix,DeptCode FROM Code_Yard where DeptCode like '" & G_DeptCode & "%' ORDER BY Code_Yard_ID"
        cbPlace.DataSource = Filldata(sqlCodeYard)
        cbPlace.DisplayMember = "Code_Yard_Name"
        cbPlace.ValueMember = "Code_Yard_ID"

        Dim sqlCodePort As String
        sqlCodePort = "SELECT CODE_PORT, PORT_CHA, PORT_ENG FROM CODE_PORT ORDER BY PORT_ENG"
        Dim dvLoadPort As New DataView()
        Dim dvUnloadPort As New DataView()
        Dim dvDelivery As New DataView()

        dvLoadPort = Filldata(sqlCodePort)
        Me.cbLoadPort.DataSource = dvLoadPort
        Me.cbLoadPort.DisplayMember = "PORT_CHA"
        Me.cbLoadPort.ValueMember = "CODE_PORT"

        dvUnloadPort = Filldata(sqlCodePort)
        Me.cbUnloadPort.DataSource = dvUnloadPort
        Me.cbUnloadPort.DisplayMember = "PORT_CHA"
        Me.cbUnloadPort.ValueMember = "CODE_PORT"

        dvDelivery = Filldata(sqlCodePort)
        Me.cbDelivery.DataSource = dvDelivery
        Me.cbDelivery.DisplayMember = "PORT_CHA"
        Me.cbDelivery.ValueMember = "CODE_PORT"

        Dim sqlInOutPort As String
        sqlInOutPort = "SELECT InOutPort, InOutPort_Name FROM Code_InOutPort"
        Dim dvInOutPort As New DataView()
        dvInOutPort = Filldata(sqlInOutPort)
        Me.cbInOutPort.DataSource = dvInOutPort
        Me.cbInOutPort.DisplayMember = "InOutPort_Name"
        Me.cbInOutPort.ValueMember = "InOutPort"

        Me.txtNO.Enabled = False
        Me.txtTallyClerk.Enabled = False
        Me.txtTallyClerk.Text = G_User

        sqlstr = "select * from Con_Load_Tally where Con_Load_Tally_ID =" & ID
        dw = Updatedata(sqlda, sqlstr, ds)

        dtpListDate.CustomFormat = "yyyy'-'MM'-'dd"
        dtpTimeBegin.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"
        If dw.Count > 0 Then
            cbPlace.SelectedValue = ds.Tables(0).Rows(0).Item("WORK_PLACE")
            txtNO.Text = ds.Tables(0).Rows(0).Item("NO")
            txtID.Text = ds.Tables(0).Rows(0).Item("Con_Load_Tally_ID")

            txtShip.Text = ds.Tables(0).Rows(0).Item("CHI_VESSEL")
            txtVoyage.Text = ds.Tables(0).Rows(0).Item("VOYAGE")
            Me.cbInOutPort.SelectedValue = ds.Tables(0).Rows(0)("InOutPort")
            Me.cbLoadPort.SelectedValue = ds.Tables(0).Rows(0)("CodeLoadPort")
            Me.cbUnloadPort.SelectedValue = ds.Tables(0).Rows(0)("CodeUnloadPort")
            Me.cbDelivery.SelectedValue = ds.Tables(0).Rows(0)("CodeDelivery")
            cbWorkType.SelectedValue = ds.Tables(0).Rows(0).Item("WORKTYPE")
            cbConLoadType.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_TALLY_TYPE")
            dtpTimeBegin.Value = ds.Tables(0).Rows(0).Item("TIME_FROM")

            txtBillNO.Text = ds.Tables(0).Rows(0).Item("BLNO")
            txtMark.Text = ds.Tables(0).Rows(0).Item("MARK")
            cbGoodsCode.Text = ds.Tables(0).Rows(0).Item("GoodsCha")
            strGoodsName = ds.Tables(0).Rows(0).Item("GoodsCha")
            Me.txtGoodsSpec.Text = ds.Tables(0).Rows(0).Item("GoodsSpec")

            txtAmount.Text = ds.Tables(0).Rows(0).Item("AMOUNT")
            txtTotalWeight.Text = ds.Tables(0).Rows(0).Item("TOTAL_WEIGHT")
            txtTotalNetWeight.Text = ds.Tables(0).Rows(0)("TOTALNetWEIGHT")
            txtSize.Text = ds.Tables(0).Rows(0).Item("SIZE_MEASURE")
            Me.txtReeferTemp.Text = ds.Tables(0).Rows(0)("ReeferTemp")
            Me.cbTempUnit.Text = ds.Tables(0).Rows(0)("TempUnit")
            Me.txtDangerGrade.Text = ds.Tables(0).Rows(0)("DangerGrade")
            Me.txtDangerMark.Text = ds.Tables(0).Rows(0)("DangerMark")

            cbDescribe.Text = ds.Tables(0).Rows(0).Item("DESCR")
            cbState.Text = ds.Tables(0).Rows(0).Item("STATE")
            txtBargainNO.Text = ds.Tables(0).Rows(0).Item("CONTRACT_NO")
            Me.txtShiper.Text = ds.Tables(0).Rows(0)("Shipper")
            txtReceiver.Text = ds.Tables(0).Rows(0).Item("RECEIVER")
            Me.txtNotify.Text = ds.Tables(0).Rows(0)("Notify")
            txtTallyClerk.Text = ds.Tables(0).Rows(0).Item("TALLY_CLERK")
            txtCrossPerson.Text = ds.Tables(0).Rows(0).Item("CROSS_PERSON")
            cbConsign.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_CON_CONSIGN")
            dtpListDate.Value = ds.Tables(0).Rows(0).Item("LISTDATE")

            sqlShipCode = "SELECT SPCODE, CHI_VESSEL,ENG_VESSEL FROM Code_SHIPNAME WHERE SPCODE = '" & Me.txtShip.Text & "'"
            dvShipCode = Filldata(sqlShipCode)
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
            End If
            strShipCodeOg = Me.txtShip.Text
            strVoyageOg = Me.txtVoyage.Text
            strBillNoOg = Me.txtBillNO.Text
            strCodeYardOg = Me.cbPlace.SelectedValue
            sqlSubTable = "select CON_LOAD_TALLY_LIST_ID,CON_LOAD_TALLY_ID,SHIP_ID,CHI_VESSEL,Voyage,BLNO,CONTAINER_NO,NEWSEALNO,SIZE_CON,CONTAINER_TYPE,PACK_CHA,PACK_ENG,AMOUNT,WEIGHT,NetWeight,VOLUME,DAMAGED_AMOUNT,DAMAGED_PACK,SecSealNO,ReasonOpenSeal,USER_NAME,CodeYard,ReeferTemp,TempUnit,DangerGrade,DangerMark,Checked,CheckTime,Printed,PrintTime,PrintPerson,StateC,FullOrEmpty " & _
                " from Con_Load_Tally_List where  CHI_VESSEL ='" & Me.txtShip.Text & "' and Voyage = '" & Me.txtVoyage.Text & "' and blno= '" & Me.txtBillNO.Text & "' and CodeYard = '" & Me.cbPlace.SelectedValue & "'"
            InitSubTable()     '初始化子表c1grid
        End If
        Me.btnGetData.Focus()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub InitSubTable()
        Try
           dvSubTable = Updatedata(sqlSubTableda, sqlSubTable, dsSubTable)
            Me.C1DBG.DataSource = dvSubTable
            DelSum = 0
            Count = dvSubTable.Count

            Me.C1DBG.FetchRowStyles = True
            Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
            Me.C1DBG.ColumnFooters = True
            Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
            Me.C1DBG.Columns("CONTAINER_NO").FooterText = "合计" & dvSubTable.Count & "箱"

            Me.C1DBG.Splits(0).DisplayColumns.Item(0).Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item(1).Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("SHIP_ID").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("USER_NAME").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("PACK_ENG").Visible = False

            Me.C1DBG.Splits(0).DisplayColumns.Item("CHI_VESSEL").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("VOYAGE").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("BLNO").Visible = False
            'Me.C1DBG.Splits(0).DisplayColumns.Item("CodeYard").Visible = False

            'Me.C1DBG.Splits(0).DisplayColumns.Item("WEIGHT").Visible = False

            'Me.C1DBG.Splits(0).DisplayColumns.Item("DAMAGED_AMOUNT").Visible = False
            'Me.C1DBG.Splits(0).DisplayColumns.Item("DAMAGED_PACK").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("CheckTime").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("Checked").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("Printed").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("PrintTime").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("PrintPerson").Visible = False

            Me.C1DBG.Columns.Item("CONTAINER_NO").Caption = "集装箱号"
            Me.C1DBG.Columns.Item("NEWSEALNO").Caption = "货单铅封号"
            Me.C1DBG.Columns.Item("SIZE_CON").Caption = "箱尺寸"
            Me.C1DBG.Columns.Item("CONTAINER_TYPE").Caption = "箱型"
            Me.C1DBG.Columns.Item("AMOUNT").Caption = "件数"
            Me.C1DBG.Columns.Item("PACK_CHA").Caption = "包装"
            Me.C1DBG.Columns.Item("WEIGHT").Caption = "总重(kg)"
            Me.C1DBG.Columns.Item("NetWeight").Caption = "货重(kg)"
            Me.C1DBG.Columns.Item("VOLUME").Caption = "体积(M3)"
            Me.C1DBG.Columns.Item("SecSealNO").Caption = "备注铅封号"
            Me.C1DBG.Columns.Item("ReasonOpenSeal").Caption = "开封原因"
            Me.C1DBG.Columns.Item("DAMAGED_AMOUNT").Caption = "残损件数"
            Me.C1DBG.Columns.Item("DAMAGED_PACK").Caption = "残损情况"
            Me.C1DBG.Columns.Item("CodeYard").Caption = "装箱地点"
            Me.C1DBG.Columns.Item("ReeferTemp").Caption = "冷藏温度"
            Me.C1DBG.Columns.Item("TempUnit").Caption = "温标"
            Me.C1DBG.Columns.Item("DangerGrade").Caption = "危品等级"
            Me.C1DBG.Columns.Item("DangerMark").Caption = "危品标签"

            'Me.C1DBG.Columns("PACK_ENG").DefaultValue = "1"     '对于已有的数据默认值无效   
            Me.C1DBG.Splits(0).DisplayColumns("CodeYard").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns.Item("StateC").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("FullOrEmpty").Visible = False
            Call FieldFill()
            SetColumnWidth()
        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FieldFill()
        Dim i As Integer
        Try
            Dim sqlConKind As String = "SELECT CODE_CON_KIND, CON_KIND_ENG FROM CODE_CON_KIND ORDER BY CODE_CON_KIND"
            Dim dvConKind As New DataView()
            dvConKind = Filldata(sqlConKind)
            Me.C1DBG.Columns("CONTAINER_TYPE").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("CONTAINER_TYPE").ValueItems.Translate = True
            For i = 0 To dvConKind.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
                vi.DisplayValue = dvConKind(i)("CON_KIND_ENG")
                vi.Value = dvConKind(i)("CODE_CON_KIND")
                Me.C1DBG.Columns.Item("CONTAINER_TYPE").ValueItems.Values.Add(vi)
            Next

            Dim sqlPack As String = "SELECT CODE_PACK, PACK_CHA, PACK_ENG FROM CODE_PACK ORDER BY CODE_PACK"
            Dim dvPack As New DataView()
            dvPack = Filldata(sqlPack)
            Me.C1DBG.Columns("PACK_CHA").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("PACK_CHA").ValueItems.Translate = True
            For i = 0 To dvPack.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
                vi.DisplayValue = dvPack(i)("PACK_CHA")
                vi.Value = dvPack(i)("CODE_PACK")
                Me.C1DBG.Columns.Item("PACK_CHA").ValueItems.Values.Add(vi)
            Next

            Dim sqlYcode As String
            Dim dvYcode As New DataView
            sqlYcode = "SELECT Code_Yard_ID, Code_Yard_Name FROM Code_Yard where Code_Yard_ID <> '00' ORDER BY Code_Yard_ID"
            dvYcode = Filldata(sqlYcode)
            Me.C1DBG.Columns("CodeYard").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("CodeYard").ValueItems.Translate = True
            For i = 0 To dvYcode.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = dvYcode(i)("Code_Yard_Name")
                vi.Value = dvYcode(i)("Code_Yard_ID")
                Me.C1DBG.Columns.Item("CodeYard").ValueItems.Values.Add(vi)
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
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Width = 60
                i = i + 1
            Loop
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Width = 90
            Me.C1DBG.Splits(0).DisplayColumns("NEWSEALNO").Width = 90
            Me.C1DBG.Splits(0).DisplayColumns("BLNO").Width = 90
            Me.C1DBG.Splits(0).DisplayColumns("SIZE_CON").Width = 30
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_TYPE").Width = 40
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
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
            MessageBox.Show("船码 " & Me.txtShip.Text & " 不存在，请重新输入", "提示")
        End If
        If Me.txtShip.Text <> strShipCodeOg Then
            GetDataSure = False
        End If
    End Sub

    Private Sub txtVoyage_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVoyage.Leave
        Me.txtVoyage.Text = Me.txtVoyage.Text.Trim.ToUpper
        If Me.txtVoyage.Text <> strVoyageOg Then
            GetDataSure = False
        End If
    End Sub

    Private Sub txtBillNO_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBillNO.Leave
        Me.txtBillNO.Text = Me.txtBillNO.Text.Trim.ToUpper
        If Me.txtBillNO.Text <> strBillNoOg Then
            GetDataSure = False
        End If
        Call btnGetData_Click(sender, e)
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub FillBill()
        MessageBox.Show("得到另一提单信息")
        cbPlace.SelectedValue = ds.Tables(0).Rows(0).Item("WORK_PLACE")
        txtNO.Text = ds.Tables(0).Rows(0).Item("NO")
        txtID.Text = ds.Tables(0).Rows(0).Item("Con_Load_Tally_ID")
        ID = txtID.Text
        Me.cbInOutPort.SelectedValue = ds.Tables(0).Rows(0)("InOutPort")
        Me.cbLoadPort.SelectedValue = ds.Tables(0).Rows(0)("CodeLoadPort")
        Me.cbUnloadPort.SelectedValue = ds.Tables(0).Rows(0)("CodeUnloadPort")
        Me.cbDelivery.SelectedValue = ds.Tables(0).Rows(0)("CodeDelivery")
        cbWorkType.SelectedValue = ds.Tables(0).Rows(0).Item("WORKTYPE")
        cbConLoadType.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_TALLY_TYPE")
        dtpTimeBegin.Value = ds.Tables(0).Rows(0).Item("TIME_FROM")

        txtBillNO.Text = ds.Tables(0).Rows(0).Item("BLNO")
        txtMark.Text = ds.Tables(0).Rows(0).Item("MARK")
        cbGoodsCode.Text = ds.Tables(0).Rows(0).Item("GoodsCha")
        Me.txtGoodsSpec.Text = ds.Tables(0).Rows(0).Item("GoodsSpec")
        txtAmount.Text = ds.Tables(0).Rows(0).Item("AMOUNT")
        txtTotalWeight.Text = ds.Tables(0).Rows(0).Item("TOTAL_WEIGHT")
        txtTotalNetWeight.Text = ds.Tables(0).Rows(0)("TOTALNetWEIGHT")
        txtSize.Text = ds.Tables(0).Rows(0).Item("SIZE_MEASURE")
        Me.txtReeferTemp.Text = ds.Tables(0).Rows(0)("ReeferTemp")
        Me.cbTempUnit.Text = ds.Tables(0).Rows(0)("TempUnit")
        Me.txtDangerGrade.Text = ds.Tables(0).Rows(0)("DangerGrade")
        Me.txtDangerMark.Text = ds.Tables(0).Rows(0)("DangerMark")

        cbDescribe.Text = ds.Tables(0).Rows(0).Item("DESCR")
        cbState.Text = ds.Tables(0).Rows(0).Item("STATE")
        txtBargainNO.Text = ds.Tables(0).Rows(0).Item("CONTRACT_NO")
        Me.txtShiper.Text = ds.Tables(0).Rows(0)("Shipper")
        txtReceiver.Text = ds.Tables(0).Rows(0).Item("RECEIVER")
        Me.txtNotify.Text = ds.Tables(0).Rows(0)("Notify")


        txtTallyClerk.Text = ds.Tables(0).Rows(0).Item("TALLY_CLERK")

        txtCrossPerson.Text = ds.Tables(0).Rows(0).Item("CROSS_PERSON")
        cbConsign.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_CON_CONSIGN")
        dtpListDate.Value = ds.Tables(0).Rows(0).Item("LISTDATE")

        sqlSubTable = "select * from Con_Load_Tally_List where  CHI_VESSEL ='" & Me.txtShip.Text & "' and Voyage = '" & Me.txtVoyage.Text & "' and blno= '" & Me.txtBillNO.Text & "' order by Container_No "
        InitSubTable()     '初始化子表c1grid
    End Sub

    Private Sub btnGetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetData.Click
        Dim sqlBillExist As String
        Dim dvBillExist As New DataView
        On Error GoTo ErrorDeal
        GetDataSure = True
        Dim markDirect As Integer = 0   '为1直接查，为2分步查，为0不查
        If Me.cbPlace.Items.Count = 1 Then
            If Me.txtShip.Text <> strShipCodeOg OrElse Me.txtVoyage.Text <> strVoyageOg OrElse Me.txtBillNO.Text <> strBillNoOg Then
                markDirect = 1
                strShipCodeOg = Me.txtShip.Text
                strVoyageOg = Me.txtVoyage.Text
                strBillNoOg = Me.txtBillNO.Text
            End If
        ElseIf Me.cbPlace.Items.Count > 1 Then
            If Me.txtShip.Text <> strShipCodeOg OrElse Me.txtVoyage.Text <> strVoyageOg OrElse Me.txtBillNO.Text <> strBillNoOg Then
                markDirect = 2
                strShipCodeOg = Me.txtShip.Text
                strVoyageOg = Me.txtVoyage.Text
                strBillNoOg = Me.txtBillNO.Text
            Else
                If Me.cbPlace.SelectedValue <> strCodeYardOg Then
                    markDirect = 1
                    strCodeYardOg = Me.cbPlace.SelectedValue
                End If
            End If
        End If

        If markDirect = 1 Then
            sqlBillExist = "SELECT * FROM CON_LOAD_TALLY WHERE CHI_VESSEL = '" & Me.txtShip.Text & "' AND Voyage = '" & Me.txtVoyage.Text & "' AND BLNO = '" & Me.txtBillNO.Text & "' and WORK_PLACE = '" & Me.cbPlace.SelectedValue & "'"
            dvBillExist = Updatedata(sqlda, sqlBillExist, ds)
            If dvBillExist.Count = 1 Then
                FillBill()
            Else
                MessageBox.Show("无此提单信息，可将现有信息修改为此提单")
            End If
        ElseIf markDirect = 2 Then
            sqlBillExist = "SELECT * FROM CON_LOAD_TALLY WHERE CHI_VESSEL = '" & Me.txtShip.Text & "' AND Voyage = '" & Me.txtVoyage.Text & "' AND BLNO = '" & Me.txtBillNO.Text & "' "
            dvBillExist = Updatedata(sqlda, sqlBillExist, ds)
            If dvBillExist.Count = 1 Then
                FillBill()
            ElseIf dvBillExist.Count > 1 Then
                '用场站查 与 markDirect = 1 时相同
                strCodeYardOg = Me.cbPlace.SelectedValue
                sqlBillExist = "SELECT * FROM CON_LOAD_TALLY WHERE CHI_VESSEL = '" & Me.txtShip.Text & "' AND Voyage = '" & Me.txtVoyage.Text & "' AND BLNO = '" & Me.txtBillNO.Text & "' and WORK_PLACE = '" & Me.cbPlace.SelectedValue & "'"
                dvBillExist = Updatedata(sqlda, sqlBillExist, ds)
                If dvBillExist.Count = 1 Then
                    FillBill()
                Else
                    MessageBox.Show("无此提单信息，可将现有信息修改为此提单")
                End If
            Else
                MessageBox.Show("仍然是当前提单信息")
            End If
        End If

        Exit Sub
ErrorDeal:
        Resume Next
    End Sub

    Function IsCode(ByVal str As String) As Boolean    ' 两头不空
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
            Return True     '最长五位，中间可空
        Else
            Return False
        End If
    End Function

    Private Function SetNumValue(ByVal strNumColumn As String, ByVal strNumValue As String, Optional ByVal message As String = "数据") As Boolean
        Dim flag As Boolean = True
        If Trim(strNumValue) <> "" Then
            If IsNumeric(Trim(strNumValue)) Then
                ds.Tables(0).Rows(0).Item(strNumColumn) = Trim(strNumValue)
            Else
                MessageBox.Show(message + "应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                flag = False
            End If
        Else    '此列留空
            ds.Tables(0).Rows(0).Item(strNumColumn) = DBNull.Value
        End If
        Return flag
    End Function

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim sqlExist As String
        sqlExist = "select * from CON_LOAD_Tally where BLNO = '" & txtBillNO.Text & _
                        "' and CHI_VESSEL = '" & txtShip.Text & _
                        "' and VOYAGE = '" & txtVoyage.Text & "' and CON_LOAD_TALLY_ID <> '" & ID & "'"
        Try
            If ds.Tables(0).Rows(0)("StateB") <> "0" Then '判断状态是否正确
                MessageBox.Show("此提单不是指示状态，不可处理。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim i As Integer
            'For i = 0 To dvSubTable.Count - 1
            '    If Me.C1DBG.Columns("StateC").CellText(i) <> "0" Then
            '        Exit For
            '    End If
            'Next
            'If i < dvSubTable.Count Then
            '    If MessageBox.Show("部分箱信息不是指示状态，不可处理，请确定情况：是货代分批录入不影响，选 是 继续；是部分箱检查桥已查验，选 否 退出 先行分单操作 ", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            '        Exit Sub
            '    End If
            'End If

            If GetDataSure = True Then
                If txtShip.Text <> "" And txtVoyage.Text <> "" And Me.cbConsign.SelectedValue <> Nothing _
                                   And txtBillNO.Text <> "" And Me.cbWorkType.SelectedValue <> "0" And Me.cbInOutPort.SelectedValue <> " " Then

                    If shipMark = False Then
                        Me.txtShip.Focus()
                        MessageBox.Show("船码 " & Me.txtShip.Text & " 不存在，请重新输入", "提示")
                        Exit Sub
                    End If

                    If Me.SetNumValue("AMOUNT", txtAmount.Text, "总件数") = False Then
                        txtAmount.Focus()
                        Exit Sub
                    ElseIf Me.SetNumValue("TOTAL_WEIGHT", txtTotalWeight.Text, "总毛重") = False Then
                        Me.txtTotalWeight.Focus()
                        Exit Sub
                    ElseIf Me.SetNumValue("TotalNetWeight", txtTotalNetWeight.Text, "总净重") = False Then
                        Me.txtTotalNetWeight.Focus()
                        Exit Sub
                    ElseIf Me.SetNumValue("ReeferTemp", txtReeferTemp.Text, "冷藏温度") = False Then
                        Me.txtReeferTemp.Focus()
                        Exit Sub
                    End If

                    If Not IsNothing(Me.cbLoadPort.SelectedValue) Then  '港口代码能取到
                        ds.Tables(0).Rows(0).Item("CodeLoadPort") = Me.cbLoadPort.SelectedValue
                    Else
                        If IsCode(Me.cbLoadPort.Text.Trim()) Then     '判断是代码的形式
                            ds.Tables(0).Rows(0).Item("CodeLoadPort") = Trim(Me.cbLoadPort.Text.ToUpper)
                        Else
                            Me.cbLoadPort.Focus()
                            MessageBox.Show("装货港名不能取得时，必须输入港口代码才能保存。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If
                    If Not IsNothing(Me.cbUnloadPort.SelectedValue) Then  '港口代码能取到
                        ds.Tables(0).Rows(0).Item("CodeUnloadPort") = Me.cbUnloadPort.SelectedValue
                    Else
                        If IsCode(Me.cbUnloadPort.Text.Trim()) Then     '判断是代码的形式
                            ds.Tables(0).Rows(0).Item("CodeUnloadPort") = Trim(Me.cbUnloadPort.Text.ToUpper)
                        Else
                            Me.cbUnloadPort.Focus()
                            MessageBox.Show("卸货港名不能取得时，必须输入港口代码才能保存。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If
                    If Not IsNothing(Me.cbDelivery.SelectedValue) Then  '港口代码能取到
                        ds.Tables(0).Rows(0).Item("CodeDelivery") = Me.cbDelivery.SelectedValue
                    Else
                        If IsCode(Me.cbDelivery.Text.Trim()) Then     '判断是代码的形式
                            ds.Tables(0).Rows(0).Item("CodeDelivery") = Trim(Me.cbDelivery.Text.ToUpper)
                        Else
                            Me.cbDelivery.Focus()
                            MessageBox.Show("交货港名不能取得时，必须输入港口代码才能保存。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If

                    If Filldata(sqlExist).Count = 0 Then
                        ds.Tables(0).Rows(0).Item("CHI_VESSEL") = Trim(txtShip.Text).ToUpper
                        ds.Tables(0).Rows(0).Item("VOYAGE") = Trim(txtVoyage.Text).ToUpper
                        ds.Tables(0).Rows(0).Item("InOutPort") = Me.cbInOutPort.SelectedValue
                        ds.Tables(0).Rows(0).Item("WORKTYPE") = cbWorkType.SelectedValue
                        ds.Tables(0).Rows(0).Item("CODE_TALLY_TYPE") = cbConLoadType.SelectedValue
                        ds.Tables(0).Rows(0).Item("TIME_FROM") = dtpTimeBegin.Value

                        ds.Tables(0).Rows(0).Item("BLNO") = Trim(txtBillNO.Text).ToUpper
                        ds.Tables(0).Rows(0).Item("MARK") = Trim(txtMark.Text).ToUpper
                        If Me.cbGoodsCode.Text.Trim = "" Then
                            ds.Tables(0).Rows(0).Item("GoodsCha") = strGoodsName
                        Else
                            ds.Tables(0).Rows(0).Item("GoodsCha") = cbGoodsCode.Text.Trim
                        End If
                        ds.Tables(0).Rows(0).Item("GoodsSpec") = Me.txtGoodsSpec.Text.Trim.ToUpper
                        ds.Tables(0).Rows(0).Item("TempUnit") = Me.cbTempUnit.Text
                        ds.Tables(0).Rows(0).Item("DangerGrade") = Me.txtDangerGrade.Text.Trim
                        ds.Tables(0).Rows(0).Item("DangerMark") = Me.txtDangerMark.Text.Trim

                        ds.Tables(0).Rows(0).Item("DESCR") = Trim(cbDescribe.Text)
                        ds.Tables(0).Rows(0).Item("STATE") = Trim(cbState.Text)
                        ds.Tables(0).Rows(0).Item("CONTRACT_NO") = Trim(txtBargainNO.Text)
                        ds.Tables(0).Rows(0).Item("Shipper") = Trim(Me.txtShiper.Text)
                        ds.Tables(0).Rows(0).Item("RECEIVER") = Trim(txtReceiver.Text)
                        ds.Tables(0).Rows(0).Item("Notify") = Trim(Me.txtNotify.Text)

                        Me.txtTallyClerk.Text = G_User
                        ds.Tables(0).Rows(0).Item("TALLY_CLERK") = Trim(txtTallyClerk.Text)

                        ds.Tables(0).Rows(0).Item("CROSS_PERSON") = Trim(txtCrossPerson.Text)
                        ds.Tables(0).Rows(0).Item("CODE_CON_CONSIGN") = cbConsign.SelectedValue
                        ds.Tables(0).Rows(0).Item("LISTDATE") = dtpListDate.Value
                        ds.Tables(0).Rows(0).Item("SIZE_MEASURE") = txtSize.Text.Trim

                        Call ConDeal()

                    Else
                        MessageBox.Show("船名 航次 提单号不可重复！", "提示")
                    End If
                Else
                    MessageBox.Show("船名 航次 进出口 工作类别 提单号 委托单位 不能为空。", "提示")
                End If
            Else
                MessageBox.Show("请先点击查找按钮", "提示")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function GetAutoNo(ByVal strYardValue As String) As String  '得到理货单编号，场站代码为参数
        Dim strAutoNo, sqlAutoNO, sqlUpdateYard As String
        Dim dvAutoNO As New DataView
        Dim iYear, iMaxNo As Integer
        strAutoNo = ""
        sqlAutoNO = "SELECT Code_Yard_ID, Code_Yard_Name, CodePrefix, CodeMax, CodeYear, DeptCode FROM Code_Yard where Code_Yard_ID = '" & strYardValue & "'"
        dvAutoNO = Filldata(sqlAutoNO)
        If dvAutoNO.Count > 0 Then
            iYear = dvAutoNO(0)("CodeYear")
            iMaxNo = dvAutoNO(0)("CodeMax")
            If iYear + 1 = Now.Year Then    '如果到了下一年 年份加一 编号重置
                iYear = Now.Year
                iMaxNo = 1          '是否可以有0编号？不要
            Else    '否则编号加一
                iMaxNo = iMaxNo + 1
            End If
            '及时更新场站代码表最值、年值 减少冲突
            sqlUpdateYard = "update Code_Yard set CodeMax='" & iMaxNo & "', CodeYear='" & iYear & "' where Code_Yard_ID='" & strYardValue & "'"
            ExecSql(sqlUpdateYard)
            '生成编号
            strAutoNo = String.Concat(dvAutoNO(0)("CodePrefix"), iYear.ToString, Microsoft.VisualBasic.Right(String.Concat("00000", iMaxNo.ToString), 6))
        End If
        Return strAutoNo
    End Function

    Private Function CheckConNO(ByVal sm As String) As Integer 'return 0 箱号有错 1 校验有错 2 校验正确
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

    Private Function IsEqualConNo(ByVal ConOne As String, ByVal ConTwo As String) As Boolean    '判断箱号是否箱等
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

    Private Function GetConOtherMode(ByVal ConNo As String) As String   '得到箱号的另一种无空或有空形式
        ConNo = ConNo.Trim.ToUpper
        If ConNo.Length = 11 Then
            ConNo = ConNo.Insert(4, " ")
        ElseIf ConNo.Length = 12 Then
            ConNo = ConNo.Remove(4, 1)
        End If
        Return ConNo
    End Function

    Private Sub ConDeal()
        Dim i, j As Integer
        DelSum = 0
        Count = dvSubTable.Count
        Count = Count - DelSum

        Me.C1DBG.Focus()
        For i = 0 To Count - 1
            Me.C1DBG.Row = i
            Me.C1DBG.Columns("CONTAINER_NO").Text = Me.C1DBG.Columns("CONTAINER_NO").Text.Trim().ToUpper
            Me.C1DBG.Columns("NEWSEALNO").Text = Me.C1DBG.Columns("NEWSEALNO").Text.Trim().ToUpper
            Me.C1DBG.Columns("CONTAINER_TYPE").Text = Me.C1DBG.Columns("CONTAINER_TYPE").Text.Trim().ToUpper
            Me.C1DBG.Columns("SecSealNO").Text = Me.C1DBG.Columns("SecSealNO").Text.Trim().ToUpper
            Me.C1DBG.Columns("ReasonOpenSeal").Text = Me.C1DBG.Columns("ReasonOpenSeal").Text.Trim()
            Me.C1DBG.Columns("VOLUME").Text = Me.C1DBG.Columns("VOLUME").Text.Trim()
            Me.C1DBG.Columns("DAMAGED_PACK").Text = Me.C1DBG.Columns("DAMAGED_PACK").Text.Trim()

            Me.C1DBG.Columns("CHI_VESSEL").Text = Me.txtShip.Text
            Me.C1DBG.Columns("Voyage").Text = Me.txtVoyage.Text
            Me.C1DBG.Columns("BLNO").Text = Me.txtBillNO.Text
            'Me.C1DBG.Columns("CodeYard").Text = Me.cbPlace.SelectedValue
        Next
        Me.btQuit.Focus()

        Dim iConCheck, iConBeing As Integer
        Dim sqlBeing As String

        For i = 0 To Count - 1    '界面上检查箱号
            If Me.C1DBG.Columns("CONTAINER_NO").CellText(i) <> "" Then
                iConCheck = CheckConNO(Me.C1DBG.Columns("CONTAINER_NO").CellText(i))
                '箱号没有通过检验时
                If iConCheck = 1 Or iConCheck = 0 Then
                    sqlBeing = "SELECT CONTAINER_NO FROM CON_CRITERION WHERE CONTAINER_NO = '" & C1DBG.Columns("CONTAINER_NO").CellText(i) & "' or CONTAINER_NO = '" & GetConOtherMode(C1DBG.Columns("CONTAINER_NO").CellText(i)) & "'"
                    iConBeing = Filldata(sqlBeing).Count
                    If iConBeing = 0 Then    '箱规范中不存在
                        Me.C1DBG.Row = i
                        'Me.C1DBG.SelectedRows.Clear()
                        'Me.C1DBG.SelectedRows.Add(i)
                        If MessageBox.Show("集装箱号 " & C1DBG.Columns("CONTAINER_NO").CellText(i) & " 校验不正确且在不存在于箱规范中！确定存在吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                            Exit For
                        End If
                    End If
                ElseIf iConCheck = 0 Then
                    Me.C1DBG.Row = i
                    'Me.C1DBG.SelectedRows.Clear()
                    'Me.C1DBG.SelectedRows.Add(i)
                    MessageBox.Show("集装箱号不规范！", "提示")
                    Exit For
                End If

                For j = 0 To i - 1
                    If IsEqualConNo(Me.C1DBG.Columns("CONTAINER_NO").CellText(i), Me.C1DBG.Columns("CONTAINER_NO").CellText(j)) Then
                        Me.C1DBG.Row = i
                        'Me.C1DBG.SelectedRows.Clear()
                        'Me.C1DBG.SelectedRows.Add(i)
                        'Me.C1DBG.SelectedRows.Add(j)
                        MessageBox.Show("第" & j + 1 & "行和第" & i + 1 & "行 同一提单下集装箱号重复！", "提示")
                        Exit Sub
                    End If
                Next
            Else
                Me.C1DBG.Row = i
                'Me.C1DBG.SelectedRows.Clear()
                'Me.C1DBG.SelectedRows.Add(i)
                MessageBox.Show("集装箱号不能为空！", "提示")
                Exit For
            End If
        Next

        '箱信息不和数据库检查，但如果有增加则要检查
        Dim strNewNo As String
        If i >= Count Then
            If MessageBox.Show("确定对所选箱信息的修改装箱吗？", "提示", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                '记录操作日志
                Call OperateHistory(G_DeptName, Now, G_User, "装箱修改", "CON_LOAD_Tally", Trim(txtID.Text), "CON_LOAD_Tally_ID")
                ExecSql("Exec sp_ConLoadTallyListOperPre '" & G_DeptName & "','" & Now & "','" & G_User & "'")

                Dim sqlGetYard, strGetYard As String
                Dim dvGetYard As New DataView
                sqlGetYard = "SELECT Code_Yard_ID, Code_Yard_Name, CodePrefix, CodeMax, CodeYear, DeptCode FROM Code_Yard WHERE DeptCode = '" & G_DeptCode & "'"
                dvGetYard = Filldata(sqlGetYard)
                If dvGetYard.Count > 0 Then
                    If String.Compare(Me.cbPlace.SelectedValue, dvGetYard(0)("Code_Yard_ID"), True) <> 0 Then   '不是本场站的，要改为本场站的
                        strGetYard = dvGetYard(0)("Code_Yard_ID")
                    End If
                End If
                Me.C1DBG.Focus()
                For i = 0 To Me.C1DBG.SelectedRows.Count - 1
                    Me.C1DBG.Row = Me.C1DBG.SelectedRows.Item(i)
                    Me.C1DBG.Columns("StateC").Text = "1"
                    Me.C1DBG.Columns("CodeYard").Text = strGetYard
                Next
                Me.btQuit.Focus()

                sqlSubTableda.Update(dsSubTable)

                Dim sqlCheckComplete As String
                Dim dvCheckComplete As New DataView
                sqlCheckComplete = "SELECT StateC FROM CON_LOAD_TALLY_LIST WHERE CHI_VESSEL = '" & Me.txtShip.Text & "' AND Voyage = '" & Me.txtVoyage.Text & "' AND BLNO = '" & Me.txtBillNO.Text & "' GROUP BY StateC "
                dvCheckComplete = Filldata(sqlCheckComplete)
                If dvCheckComplete.Count = 1 Then   '全箱状态为1,修改提单状态
                    If dvCheckComplete(0)("StateC") = "1" Then
                        strNewNo = GetAutoNo(strGetYard)    '生成理货单编号
                        ds.Tables(0).Rows(0).Item("NO") = strNewNo
                        ds.Tables(0).Rows(0).Item("WORK_PLACE") = strGetYard
                        ds.Tables(0).Rows(0).Item("StateB") = "1"
                    End If
                End If
                'If strGetYard <> strCodeYardOg Then
                '    strNewNo = GetAutoNo(Me.cbPlace.SelectedValue)    '生成理货单编号
                '    ds.Tables(0).Rows(0).Item("NO") = strNewNo
                '    ds.Tables(0).Rows(0).Item("WORK_PLACE") = Me.cbPlace.SelectedValue
                'End If
                'ds.Tables(0).Rows(0).Item("StateB") = "1"
                sqlda.Update(ds)

                CheckMark = True
                Me.Close()
            End If
        End If
    End Sub

    Private Sub FrmConLoadTallyReceipt_Query_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtShip.Focused Then
                txtVoyage.Focus()
            ElseIf Me.txtVoyage.Focused Then
                Me.txtBillNO.Focus()
            ElseIf Me.txtBillNO.Focused Then
                cbInOutPort.Focus()
            ElseIf Me.cbInOutPort.Focused Then
                Me.cbLoadPort.Focus()
            ElseIf Me.cbLoadPort.Focused Then
                Me.cbUnloadPort.Focus()
            ElseIf Me.cbUnloadPort.Focused Then
                Me.cbDelivery.Focus()
            ElseIf Me.cbDelivery.Focused Then
                Me.dtpTimeBegin.Focus()
            ElseIf Me.dtpTimeBegin.Focused Then
                Me.cbWorkType.Focus()
            ElseIf Me.cbWorkType.Focused Then
                Me.cbConLoadType.Focus()
            ElseIf Me.cbConLoadType.Focused Then
                Me.txtMark.Focus()
            ElseIf Me.txtMark.Focused Then
                Me.cbGoodsCode.Focus()
            ElseIf Me.cbGoodsCode.Focused Then
                Me.txtGoodsSpec.Focus()
            ElseIf Me.txtGoodsSpec.Focused Then
                Me.txtAmount.Focus()
            ElseIf Me.txtAmount.Focused Then
                Me.txtTotalWeight.Focus()
            ElseIf Me.txtTotalWeight.Focused Then
                Me.txtTotalNetWeight.Focus()
            ElseIf Me.txtTotalNetWeight.Focused Then
                Me.txtSize.Focus()
            ElseIf Me.txtSize.Focused Then
                Me.txtReeferTemp.Focus()
            ElseIf Me.txtReeferTemp.Focused Then
                Me.cbTempUnit.Focus()
            ElseIf Me.cbTempUnit.Focused Then
                Me.txtDangerGrade.Focus()
            ElseIf Me.txtDangerGrade.Focused Then
                Me.txtDangerMark.Focus()
            ElseIf Me.txtDangerMark.Focused Then
                '    Me.cbDescribe.Focus()
                'ElseIf Me.cbDescribe.Focused Then
                Me.cbState.Focus()
            ElseIf Me.cbState.Focused Then
                Me.txtBargainNO.Focus()
            ElseIf Me.txtBargainNO.Focused Then
                Me.txtShiper.Focus()
            ElseIf Me.txtShiper.Focused Then
                Me.txtReceiver.Focus()
            ElseIf Me.txtReceiver.Focused Then
                Me.txtNotify.Focus()
            ElseIf Me.txtNotify.Focused Then
                '    Me.txtTallyClerk.Focus()
                'ElseIf Me.txtTallyClerk.Focused Then
                Me.txtCrossPerson.Focus()
            ElseIf Me.txtCrossPerson.Focused Then
                Me.cbConsign.Focus()
            ElseIf Me.cbConsign.Focused Then
                Me.dtpListDate.Focus()
            ElseIf Me.dtpListDate.Focused Then
                Me.C1DBG.Focus()
            End If
        End If
    End Sub

    Private Sub C1DBG_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1DBG.KeyDown
        If e.KeyCode = Keys.Enter And (Me.C1DBG.Col = 19 OrElse Me.C1DBG.Col = 25) Then
            Me.C1DBG.Row += 1
            Me.C1DBG.Col = 2
            SendKeys.Send("{LEFT}")
        End If
    End Sub

    Private Sub C1DBG_AfterColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles C1DBG.AfterColEdit
        If e.ColIndex = 6 Then
            Dim sqlBeing As String = "SELECT * FROM CON_CRITERION WHERE CONTAINER_NO = '" & Me.C1DBG.Columns("CONTAINER_NO").Text.Trim.ToUpper & "' or CONTAINER_NO = '" & GetConOtherMode(Me.C1DBG.Columns("CONTAINER_NO").Text) & "'"
            Dim dvBeing As New DataView
            dvBeing = Filldata(sqlBeing)
            If dvBeing.Count >= 1 Then
                Me.C1DBG.Columns("SIZE_CON").Value = dvBeing.Item(0)("SIZE_CON")
                Me.C1DBG.Columns("CONTAINER_TYPE").Value = dvBeing.Item(0)("CONTAINER_TYPE")
            End If
        ElseIf e.ColIndex = 23 Then
            If IsNumeric(Me.C1DBG.Columns("ReeferTemp").Text) Then
                If Me.C1DBG.Columns("TempUnit").Text <> "C" AndAlso Me.C1DBG.Columns("TempUnit").Text <> "F" Then
                    Me.C1DBG.Columns("TempUnit").Text = "C"
                End If
            End If
        ElseIf e.ColIndex = 24 Then
            If Me.C1DBG.Columns("TempUnit").Text <> Me.C1DBG.Columns("TempUnit").Text.Trim.ToUpper Then
                Me.C1DBG.Columns("TempUnit").Text = Me.C1DBG.Columns("TempUnit").Text.Trim.ToUpper
            End If
        End If
    End Sub

    Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        If Me.C1DBG.Columns("StateC").CellText(e.Row) <> "0" Then
            e.CellStyle.BackColor = System.Drawing.Color.MediumOrchid
        End If
    End Sub
End Class
