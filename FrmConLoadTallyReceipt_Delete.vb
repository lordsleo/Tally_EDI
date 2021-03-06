Imports TALLY.DBControl
Public Class FrmConLoadTallyReceipt_Delete
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()

    Dim sqlYardInfo As String
    Dim dvYardInfo As New DataView()
    Dim strPackCode As String
    Dim sqlCodeYard As String
    Dim dvCodeYard As New DataView()
    Dim strShipOg, strVoyageOg, strBillNoOg As String

    Dim sqlShipCode, strShipCode As String
    Dim dvShipCode As New DataView()
    Public blSave As Boolean

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
    Friend WithEvents dtpTimeEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
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
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents txtReeferTemp As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents txtGoodsSpec As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ckbInTrade As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
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
        Me.dtpTimeEnd = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
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
        Me.btSave = New System.Windows.Forms.Button
        Me.txtReeferTemp = New System.Windows.Forms.TextBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.txtGoodsSpec = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ckbInTrade = New System.Windows.Forms.CheckBox
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbTempUnit
        '
        Me.cbTempUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTempUnit.Items.AddRange(New Object() {"", "C", "F"})
        Me.cbTempUnit.Location = New System.Drawing.Point(378, 228)
        Me.cbTempUnit.Name = "cbTempUnit"
        Me.cbTempUnit.Size = New System.Drawing.Size(42, 20)
        Me.cbTempUnit.TabIndex = 585
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(216, 228)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 18)
        Me.Label36.TabIndex = 633
        Me.Label36.Text = "冷藏温度"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(426, 154)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(72, 18)
        Me.Label31.TabIndex = 632
        Me.Label31.Text = "通知方"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNotify
        '
        Me.txtNotify.Location = New System.Drawing.Point(500, 152)
        Me.txtNotify.MaxLength = 30
        Me.txtNotify.Name = "txtNotify"
        Me.txtNotify.Size = New System.Drawing.Size(130, 21)
        Me.txtNotify.TabIndex = 593
        Me.txtNotify.Text = ""
        '
        'txtShiper
        '
        Me.txtShiper.Location = New System.Drawing.Point(500, 104)
        Me.txtShiper.MaxLength = 30
        Me.txtShiper.Name = "txtShiper"
        Me.txtShiper.Size = New System.Drawing.Size(130, 21)
        Me.txtShiper.TabIndex = 591
        Me.txtShiper.Text = ""
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(426, 106)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(72, 18)
        Me.Label33.TabIndex = 631
        Me.Label33.Text = "发货人"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(216, 276)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(72, 18)
        Me.Label34.TabIndex = 630
        Me.Label34.Text = "危险品标签"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDangerMark
        '
        Me.txtDangerMark.Location = New System.Drawing.Point(290, 274)
        Me.txtDangerMark.MaxLength = 32
        Me.txtDangerMark.Name = "txtDangerMark"
        Me.txtDangerMark.Size = New System.Drawing.Size(130, 21)
        Me.txtDangerMark.TabIndex = 587
        Me.txtDangerMark.Text = ""
        '
        'txtDangerGrade
        '
        Me.txtDangerGrade.Location = New System.Drawing.Point(290, 250)
        Me.txtDangerGrade.MaxLength = 10
        Me.txtDangerGrade.Name = "txtDangerGrade"
        Me.txtDangerGrade.Size = New System.Drawing.Size(130, 21)
        Me.txtDangerGrade.TabIndex = 586
        Me.txtDangerGrade.Text = ""
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(216, 252)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(72, 18)
        Me.Label30.TabIndex = 629
        Me.Label30.Text = "危险品等级"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(390, 180)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(30, 20)
        Me.Label28.TabIndex = 628
        Me.Label28.Text = "公斤"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalNetWeight
        '
        Me.txtTotalNetWeight.Location = New System.Drawing.Point(290, 178)
        Me.txtTotalNetWeight.MaxLength = 10
        Me.txtTotalNetWeight.Name = "txtTotalNetWeight"
        Me.txtTotalNetWeight.TabIndex = 582
        Me.txtTotalNetWeight.Text = ""
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(216, 180)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 18)
        Me.Label29.TabIndex = 627
        Me.Label29.Text = "总货重"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbInOutPort
        '
        Me.cbInOutPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbInOutPort.Location = New System.Drawing.Point(80, 104)
        Me.cbInOutPort.MaxDropDownItems = 20
        Me.cbInOutPort.Name = "cbInOutPort"
        Me.cbInOutPort.Size = New System.Drawing.Size(130, 20)
        Me.cbInOutPort.TabIndex = 569
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(6, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 18)
        Me.Label12.TabIndex = 626
        Me.Label12.Text = "进出口"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbUnloadPort
        '
        Me.cbUnloadPort.Location = New System.Drawing.Point(80, 152)
        Me.cbUnloadPort.MaxDropDownItems = 20
        Me.cbUnloadPort.Name = "cbUnloadPort"
        Me.cbUnloadPort.Size = New System.Drawing.Size(130, 20)
        Me.cbUnloadPort.TabIndex = 571
        '
        'cbLoadPort
        '
        Me.cbLoadPort.Location = New System.Drawing.Point(80, 128)
        Me.cbLoadPort.MaxDropDownItems = 20
        Me.cbLoadPort.Name = "cbLoadPort"
        Me.cbLoadPort.Size = New System.Drawing.Size(130, 20)
        Me.cbLoadPort.TabIndex = 570
        '
        'cbDelivery
        '
        Me.cbDelivery.Location = New System.Drawing.Point(80, 176)
        Me.cbDelivery.MaxDropDownItems = 20
        Me.cbDelivery.Name = "cbDelivery"
        Me.cbDelivery.Size = New System.Drawing.Size(130, 20)
        Me.cbDelivery.TabIndex = 572
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(6, 178)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 624
        Me.Label10.Text = "收货地"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(6, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 18)
        Me.Label11.TabIndex = 625
        Me.Label11.Text = "装货港"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(6, 154)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(72, 18)
        Me.Label32.TabIndex = 623
        Me.Label32.Text = "卸货港"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbPlace
        '
        Me.cbPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlace.Location = New System.Drawing.Point(500, 4)
        Me.cbPlace.Name = "cbPlace"
        Me.cbPlace.Size = New System.Drawing.Size(130, 20)
        Me.cbPlace.TabIndex = 566
        '
        'txtBargainNO
        '
        Me.txtBargainNO.Location = New System.Drawing.Point(500, 80)
        Me.txtBargainNO.MaxLength = 20
        Me.txtBargainNO.Name = "txtBargainNO"
        Me.txtBargainNO.Size = New System.Drawing.Size(130, 21)
        Me.txtBargainNO.TabIndex = 590
        Me.txtBargainNO.Text = ""
        '
        'txtReceiver
        '
        Me.txtReceiver.Location = New System.Drawing.Point(500, 128)
        Me.txtReceiver.MaxLength = 30
        Me.txtReceiver.Name = "txtReceiver"
        Me.txtReceiver.Size = New System.Drawing.Size(130, 21)
        Me.txtReceiver.TabIndex = 592
        Me.txtReceiver.Text = ""
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(426, 130)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 18)
        Me.Label26.TabIndex = 622
        Me.Label26.Text = "收货人"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(426, 82)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 18)
        Me.Label27.TabIndex = 621
        Me.Label27.Text = "合同编号"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(390, 204)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 20)
        Me.Label13.TabIndex = 620
        Me.Label13.Text = "立方"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(290, 202)
        Me.txtSize.MaxLength = 40
        Me.txtSize.Name = "txtSize"
        Me.txtSize.TabIndex = 583
        Me.txtSize.Text = ""
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(216, 204)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 18)
        Me.Label19.TabIndex = 619
        Me.Label19.Text = "总尺码"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(390, 156)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(30, 20)
        Me.Label23.TabIndex = 618
        Me.Label23.Text = "公斤"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalWeight
        '
        Me.txtTotalWeight.Location = New System.Drawing.Point(290, 154)
        Me.txtTotalWeight.MaxLength = 10
        Me.txtTotalWeight.Name = "txtTotalWeight"
        Me.txtTotalWeight.TabIndex = 581
        Me.txtTotalWeight.Text = ""
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(208, 156)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 18)
        Me.Label24.TabIndex = 617
        Me.Label24.Text = "总重(含箱皮)"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(290, 130)
        Me.txtAmount.MaxLength = 10
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(130, 21)
        Me.txtAmount.TabIndex = 580
        Me.txtAmount.Text = ""
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(216, 132)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 18)
        Me.Label25.TabIndex = 616
        Me.Label25.Text = "总件数"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbConsign
        '
        Me.cbConsign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConsign.Location = New System.Drawing.Point(500, 224)
        Me.cbConsign.MaxDropDownItems = 20
        Me.cbConsign.Name = "cbConsign"
        Me.cbConsign.Size = New System.Drawing.Size(130, 20)
        Me.cbConsign.TabIndex = 596
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(426, 226)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 18)
        Me.Label22.TabIndex = 615
        Me.Label22.Text = "委托单位"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbState
        '
        Me.cbState.Items.AddRange(New Object() {"", "全已装箱", "部分装箱", "拆箱"})
        Me.cbState.Location = New System.Drawing.Point(500, 56)
        Me.cbState.MaxDropDownItems = 20
        Me.cbState.Name = "cbState"
        Me.cbState.Size = New System.Drawing.Size(130, 20)
        Me.cbState.TabIndex = 589
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(426, 58)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 18)
        Me.Label21.TabIndex = 614
        Me.Label21.Text = "货物处于"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbDescribe
        '
        Me.cbDescribe.Items.AddRange(New Object() {"", "全部抵运", "部分抵运"})
        Me.cbDescribe.Location = New System.Drawing.Point(500, 32)
        Me.cbDescribe.MaxDropDownItems = 20
        Me.cbDescribe.Name = "cbDescribe"
        Me.cbDescribe.Size = New System.Drawing.Size(130, 20)
        Me.cbDescribe.TabIndex = 588
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(426, 34)
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
        Me.cbWorkType.Location = New System.Drawing.Point(80, 200)
        Me.cbWorkType.Name = "cbWorkType"
        Me.cbWorkType.Size = New System.Drawing.Size(130, 20)
        Me.cbWorkType.TabIndex = 573
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(6, 202)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 18)
        Me.Label18.TabIndex = 612
        Me.Label18.Text = "工作类别"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpListDate
        '
        Me.dtpListDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpListDate.Location = New System.Drawing.Point(500, 248)
        Me.dtpListDate.Name = "dtpListDate"
        Me.dtpListDate.Size = New System.Drawing.Size(130, 21)
        Me.dtpListDate.TabIndex = 597
        '
        'cbGoodsCode
        '
        Me.cbGoodsCode.Location = New System.Drawing.Point(290, 80)
        Me.cbGoodsCode.MaxDropDownItems = 20
        Me.cbGoodsCode.MaxLength = 60
        Me.cbGoodsCode.Name = "cbGoodsCode"
        Me.cbGoodsCode.Size = New System.Drawing.Size(130, 20)
        Me.cbGoodsCode.TabIndex = 579
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(216, 82)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 18)
        Me.Label17.TabIndex = 611
        Me.Label17.Text = "货名"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCrossPerson
        '
        Me.txtCrossPerson.Location = New System.Drawing.Point(500, 200)
        Me.txtCrossPerson.MaxLength = 10
        Me.txtCrossPerson.Name = "txtCrossPerson"
        Me.txtCrossPerson.Size = New System.Drawing.Size(130, 21)
        Me.txtCrossPerson.TabIndex = 595
        Me.txtCrossPerson.Text = ""
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(426, 202)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 18)
        Me.Label16.TabIndex = 610
        Me.Label16.Text = "交接人员"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTallyClerk
        '
        Me.txtTallyClerk.Location = New System.Drawing.Point(500, 176)
        Me.txtTallyClerk.MaxLength = 10
        Me.txtTallyClerk.Name = "txtTallyClerk"
        Me.txtTallyClerk.Size = New System.Drawing.Size(130, 21)
        Me.txtTallyClerk.TabIndex = 594
        Me.txtTallyClerk.Text = ""
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(426, 178)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 18)
        Me.Label15.TabIndex = 609
        Me.Label15.Text = "理货员"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(426, 250)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 18)
        Me.Label14.TabIndex = 608
        Me.Label14.Text = "制单日期"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(290, 56)
        Me.txtMark.MaxLength = 20
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(130, 21)
        Me.txtMark.TabIndex = 578
        Me.txtMark.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(216, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 607
        Me.Label9.Text = "标志"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeEnd
        '
        Me.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeEnd.Location = New System.Drawing.Point(80, 290)
        Me.dtpTimeEnd.Name = "dtpTimeEnd"
        Me.dtpTimeEnd.Size = New System.Drawing.Size(130, 21)
        Me.dtpTimeEnd.TabIndex = 576
        Me.dtpTimeEnd.Visible = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 292)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 18)
        Me.Label8.TabIndex = 606
        Me.Label8.Text = "结束时间"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Visible = False
        '
        'dtpTimeBegin
        '
        Me.dtpTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeBegin.Location = New System.Drawing.Point(80, 248)
        Me.dtpTimeBegin.Name = "dtpTimeBegin"
        Me.dtpTimeBegin.Size = New System.Drawing.Size(130, 21)
        Me.dtpTimeBegin.TabIndex = 575
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 250)
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
        Me.cbConLoadType.Location = New System.Drawing.Point(80, 224)
        Me.cbConLoadType.Name = "cbConLoadType"
        Me.cbConLoadType.Size = New System.Drawing.Size(130, 20)
        Me.cbConLoadType.TabIndex = 574
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 604
        Me.Label6.Text = "折装箱类别"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBillNO
        '
        Me.txtBillNO.Location = New System.Drawing.Point(290, 32)
        Me.txtBillNO.MaxLength = 120
        Me.txtBillNO.Name = "txtBillNO"
        Me.txtBillNO.Size = New System.Drawing.Size(130, 21)
        Me.txtBillNO.TabIndex = 577
        Me.txtBillNO.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(216, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 603
        Me.Label4.Text = "提单号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(426, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 602
        Me.Label5.Text = "工作地点"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNO
        '
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
        Me.txtVoyage.Location = New System.Drawing.Point(80, 80)
        Me.txtVoyage.MaxLength = 6
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(130, 21)
        Me.txtVoyage.TabIndex = 568
        Me.txtVoyage.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 600
        Me.Label1.Text = "航次"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShip
        '
        Me.txtShip.Location = New System.Drawing.Point(80, 32)
        Me.txtShip.MaxLength = 40
        Me.txtShip.Name = "txtShip"
        Me.txtShip.Size = New System.Drawing.Size(130, 21)
        Me.txtShip.TabIndex = 567
        Me.txtShip.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 34)
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
        Me.btQuit.Location = New System.Drawing.Point(322, 304)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 564
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(254, 304)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 563
        Me.btSave.Text = "确认"
        '
        'txtReeferTemp
        '
        Me.txtReeferTemp.Location = New System.Drawing.Point(290, 226)
        Me.txtReeferTemp.MaxLength = 10
        Me.txtReeferTemp.Name = "txtReeferTemp"
        Me.txtReeferTemp.Size = New System.Drawing.Size(88, 21)
        Me.txtReeferTemp.TabIndex = 584
        Me.txtReeferTemp.Text = ""
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(6, 58)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(72, 18)
        Me.Label35.TabIndex = 635
        Me.Label35.Text = "中文船名"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShipName
        '
        Me.txtShipName.Enabled = False
        Me.txtShipName.Location = New System.Drawing.Point(80, 56)
        Me.txtShipName.MaxLength = 40
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.Size = New System.Drawing.Size(130, 21)
        Me.txtShipName.TabIndex = 634
        Me.txtShipName.Text = ""
        '
        'txtGoodsSpec
        '
        Me.txtGoodsSpec.Location = New System.Drawing.Point(290, 104)
        Me.txtGoodsSpec.MaxLength = 50
        Me.txtGoodsSpec.Name = "txtGoodsSpec"
        Me.txtGoodsSpec.Size = New System.Drawing.Size(130, 21)
        Me.txtGoodsSpec.TabIndex = 636
        Me.txtGoodsSpec.Text = ""
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(216, 106)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(72, 18)
        Me.Label37.TabIndex = 637
        Me.Label37.Text = "规格"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ckbInTrade)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(516, 274)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(112, 40)
        Me.GroupBox2.TabIndex = 681
        Me.GroupBox2.TabStop = False
        '
        'ckbInTrade
        '
        Me.ckbInTrade.Location = New System.Drawing.Point(8, 12)
        Me.ckbInTrade.Name = "ckbInTrade"
        Me.ckbInTrade.Size = New System.Drawing.Size(100, 24)
        Me.ckbInTrade.TabIndex = 0
        Me.ckbInTrade.Text = "内贸箱不出证"
        '
        'FrmConLoadTallyReceipt_Delete
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(638, 336)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtGoodsSpec)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.txtShipName)
        Me.Controls.Add(Me.cbTempUnit)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.txtNotify)
        Me.Controls.Add(Me.txtShiper)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.txtDangerMark)
        Me.Controls.Add(Me.txtDangerGrade)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtTotalNetWeight)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.cbInOutPort)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbUnloadPort)
        Me.Controls.Add(Me.cbLoadPort)
        Me.Controls.Add(Me.cbDelivery)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.cbPlace)
        Me.Controls.Add(Me.txtBargainNO)
        Me.Controls.Add(Me.txtReceiver)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtTotalWeight)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtAmount)
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
        Me.Controls.Add(Me.txtCrossPerson)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtTallyClerk)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtMark)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtpTimeEnd)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpTimeBegin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbConLoadType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBillNO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNO)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtVoyage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtShip)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.txtReeferTemp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConLoadTallyReceipt_Delete"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "装拆箱提单场站信息 删除"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmConLoadTallyReceipt_Delete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView
        Dim dvCodeGoods As New DataView
        Dim sqlstr, sqlCodeGoods As String
        Me.StartPosition = FormStartPosition.CenterScreen

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

        sqlCodeYard = "SELECT Code_Yard_ID, Code_Yard_Name, CodePrefix FROM Code_Yard ORDER BY Code_Yard_ID"
        cbPlace.DataSource = Filldata(sqlCodeYard)
        cbPlace.DisplayMember = "Code_Yard_Name"
        cbPlace.ValueMember = "Code_Yard_ID"

        Dim sqlCodePort As String
        sqlCodePort = "SELECT CODE_PORT, PORT_CHA, PORT_ENG FROM CODE_PORT ORDER BY PORT_ENG"
        Dim dvLoadPort As New DataView
        Dim dvUnloadPort As New DataView
        Dim dvDelivery As New DataView

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
        Dim dvInOutPort As New DataView
        dvInOutPort = Filldata(sqlInOutPort)
        Me.cbInOutPort.DataSource = dvInOutPort
        Me.cbInOutPort.DisplayMember = "InOutPort_Name"
        Me.cbInOutPort.ValueMember = "InOutPort"

        Me.txtNO.Enabled = False
        Me.cbPlace.Enabled = False

        sqlstr = "select * from Con_Load_Tally where Con_Load_Tally_ID =" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        dtpListDate.CustomFormat = "yyyy'-'MM'-'dd"
        dtpTimeBegin.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"
        dtpTimeEnd.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"
        If dw.Count > 0 Then
            If dw(0)("TradeMark") = "1" Then
                Me.ckbInTrade.Checked = True
            Else
                Me.ckbInTrade.Checked = False
            End If
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
            dtpTimeEnd.Value = ds.Tables(0).Rows(0).Item("TIME_TO")

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

            strShipOg = txtShip.Text
            strVoyageOg = txtVoyage.Text
            strBillNoOg = txtBillNO.Text

            strShipCode = Me.txtShip.Text.Trim.ToUpper
            sqlShipCode = "SELECT SPCODE, CHI_VESSEL FROM Code_SHIPNAME WHERE SPCODE = '" & strShipCode & "'"
            dvShipCode = Filldata(sqlShipCode)
            If dvShipCode.Count > 0 Then
                Me.txtShip.Text = dvShipCode(0)("SPCODE")
                If Not IsDBNull(dvShipCode(0)("CHI_VESSEL")) Then
                    Me.txtShipName.Text = dvShipCode(0)("CHI_VESSEL")
                End If
            End If
        End If
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            If Me.ds.Tables(0).Rows(0)("StateB") <> "0" And Me.ds.Tables(0).Rows(0)("StateB") <> "1" Then
                If G_DeptCode <> "26.11.30" Then    '如果理货单状态是打印过的，且操作部门不是查验中心，不允许操作
                    MessageBox.Show("该理货单已打印过，非海关查验中心不可操作。", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            End If
            If MessageBox.Show("此操作将同时删除与当前记录关联的箱信息数据，确定要删除吗？", "警告提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                '记录操作日志
                Call OperateHistory(G_DeptName, Now, G_User, "删除", "CON_LOAD_TALLY", Trim(txtID.Text), "CON_LOAD_TALLY_ID")
                '为子表删除记录日志用
                Dim sqlUpdateOperTemp As String
                sqlUpdateOperTemp = "Exec sp_ConLoadTallyListOperPre '" & G_DeptName & "','" & Now & "','" & G_User & "'"
                ExecSql(sqlUpdateOperTemp)
                ds.Tables(0).Rows(0).Delete()
                sqlda.Update(ds)
                '触发器删除子表
                Me.Close()
                blSave = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
