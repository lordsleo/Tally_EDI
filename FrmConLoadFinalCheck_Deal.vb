Imports TALLY.DBControl
Public Class FrmConLoadFinalCheck_Deal
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet
    Dim sqlda As New SqlClient.SqlDataAdapter
    Dim dsSubTable As New DataSet
    Dim sqlSubTableda As New SqlClient.SqlDataAdapter
    Dim sqlSubTable As String
    Dim dvSubTable As New DataView

    Dim sqlYardInfo As String
    Dim dvYardInfo As New DataView
    Dim strPackCode As String
    Dim sqlCodeYard As String
    Dim dvCodeYard As New DataView
    Dim strShipOg, strVoyageOg, strBillNoOg As String
    Dim Count, DelSum As Integer

    Dim dvLoadPort As New DataView
    Dim dvUnloadPort As New DataView
    Dim dvDelivery As New DataView

    Dim sqlShipCode, strShipCode As String
    Dim dvShipCode As New DataView
    Dim shipMark As Boolean

    Dim sqlResultShip As String
    Dim dvResultShip As New DataView
    Dim strGoodsName As String

    Dim dvPack As New DataView
    Dim BillMark As Boolean
    '放行 退关 还原标志
    Dim strOldShip As String
    Public passMark As Boolean
    Public backMark As Boolean
    Public revertMark As Boolean
    Dim dw As New DataView


#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        AddHandler txtBillNO.KeyDown, AddressOf FrmConLoadFinalCheck_Deal_KeyDown
        AddHandler cbLoadPort.KeyDown, AddressOf FrmConLoadFinalCheck_Deal_KeyDown
        AddHandler cbUnloadPort.KeyDown, AddressOf FrmConLoadFinalCheck_Deal_KeyDown
        AddHandler cbDelivery.KeyDown, AddressOf FrmConLoadFinalCheck_Deal_KeyDown
        AddHandler cbConLoadType.KeyDown, AddressOf FrmConLoadFinalCheck_Deal_KeyDown
        AddHandler dtpTimeBegin.KeyDown, AddressOf FrmConLoadFinalCheck_Deal_KeyDown
        AddHandler txtMark.KeyDown, AddressOf FrmConLoadFinalCheck_Deal_KeyDown
        AddHandler txtGoodsName.KeyDown, AddressOf FrmConLoadFinalCheck_Deal_KeyDown
        AddHandler txtGoodsEng.KeyDown, AddressOf FrmConLoadFinalCheck_Deal_KeyDown
        AddHandler txtShiper.KeyDown, AddressOf FrmConLoadFinalCheck_Deal_KeyDown
        AddHandler txtReceiver.KeyDown, AddressOf FrmConLoadFinalCheck_Deal_KeyDown
        AddHandler txtNotify.KeyDown, AddressOf FrmConLoadFinalCheck_Deal_KeyDown
        AddHandler cbPack.KeyDown, AddressOf FrmConLoadFinalCheck_Deal_KeyDown
        AddHandler txtAmount.KeyDown, AddressOf FrmConLoadFinalCheck_Deal_KeyDown
        AddHandler txtTotalNetWeight.KeyDown, AddressOf FrmConLoadFinalCheck_Deal_KeyDown
        AddHandler txtNetWeight.KeyDown, AddressOf FrmConLoadFinalCheck_Deal_KeyDown
        AddHandler txtSize.KeyDown, AddressOf FrmConLoadFinalCheck_Deal_KeyDown
        AddHandler txtReeferTemp.KeyDown, AddressOf FrmConLoadFinalCheck_Deal_KeyDown
        AddHandler cbTempUnit.KeyDown, AddressOf FrmConLoadFinalCheck_Deal_KeyDown
        AddHandler txtDangerGrade.KeyDown, AddressOf FrmConLoadFinalCheck_Deal_KeyDown
        AddHandler txtDangerMark.KeyDown, AddressOf FrmConLoadFinalCheck_Deal_KeyDown
        AddHandler txtDangerPageNo.KeyDown, AddressOf FrmConLoadFinalCheck_Deal_KeyDown
        AddHandler txtDangerCodeNO.KeyDown, AddressOf FrmConLoadFinalCheck_Deal_KeyDown

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
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
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
    Friend WithEvents txtReceiver As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSize As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cbConsign As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cbState As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cbDescribe As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtTallyClerk As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
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
    Friend WithEvents txtGoodsEng As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCreateMessage As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtDangerCodeNO As System.Windows.Forms.TextBox
    Friend WithEvents txtDangerPageNo As System.Windows.Forms.TextBox
    Friend WithEvents cbPack As System.Windows.Forms.ComboBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtGoodsName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbResultShip As System.Windows.Forms.Label
    Friend WithEvents txtNetWeight As System.Windows.Forms.TextBox
    Friend WithEvents btnRevert As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lbOldShip As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtFindNo As System.Windows.Forms.TextBox
    Friend WithEvents txtFindBill As System.Windows.Forms.TextBox
    Friend WithEvents txtFindVoyage As System.Windows.Forms.TextBox
    Friend WithEvents txtFindShip As System.Windows.Forms.TextBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents txtContainerNo As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents bt1 As System.Windows.Forms.Button
    Friend WithEvents bt2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConLoadFinalCheck_Deal))
        Me.btSave = New System.Windows.Forms.Button
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label35 = New System.Windows.Forms.Label
        Me.txtShipName = New System.Windows.Forms.TextBox
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
        Me.txtReceiver = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtSize = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtNetWeight = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.cbConsign = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.cbState = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.cbDescribe = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtTallyClerk = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
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
        Me.txtGoodsEng = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnCreateMessage = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtDangerCodeNO = New System.Windows.Forms.TextBox
        Me.txtDangerPageNo = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.cbPack = New System.Windows.Forms.ComboBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.txtGoodsName = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.lbResultShip = New System.Windows.Forms.Label
        Me.btnRevert = New System.Windows.Forms.Button
        Me.btnBack = New System.Windows.Forms.Button
        Me.lbOldShip = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtFindNo = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtFindBill = New System.Windows.Forms.TextBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.txtFindVoyage = New System.Windows.Forms.TextBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.txtFindShip = New System.Windows.Forms.TextBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.btnFind = New System.Windows.Forms.Button
        Me.txtContainerNo = New System.Windows.Forms.TextBox
        Me.Label42 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.bt1 = New System.Windows.Forms.Button
        Me.bt2 = New System.Windows.Forms.Button
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btSave.Location = New System.Drawing.Point(324, 678)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 26
        Me.btSave.Text = "放行(&S)"
        '
        'C1DBG
        '
        Me.C1DBG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 402)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.Size = New System.Drawing.Size(706, 270)
        Me.C1DBG.TabIndex = 25
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle12{}OddRow{}RecordSelector{AlignImage:Center;}Style13{}Heading{Wrap:True;Back" & _
        "Color:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style14{}Style15{}Style16{}Style17{}Sty" & _
        "le9{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeigh" & _
        "t=""18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCell" & _
        "Border"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" Hor" & _
        "izontalScrollGroup=""1""><Height>266</Height><CaptionStyle parent=""Style2"" me=""Sty" & _
        "le10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow" & _
        """ me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle p" & _
        "arent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingS" & _
        "tyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=" & _
        """Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""O" & _
        "ddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /" & _
        "><SelectedStyle parent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style" & _
        "1"" /><ClientRect>0, 0, 702, 266</ClientRect><BorderSide>0</BorderSide><BorderSty" & _
        "le>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><St" & _
        "yle parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=" & _
        """Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""He" & _
        "ading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Nor" & _
        "mal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Nor" & _
        "mal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading""" & _
        " me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Ca" & _
        "ption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzS" & _
        "plits><Layout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientAre" & _
        "a>0, 0, 702, 266</ClientArea><PrintPageHeaderStyle parent="""" me=""Style16"" /><Pri" & _
        "ntPageFooterStyle parent="""" me=""Style17"" /></Blob>"
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(6, 40)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(72, 18)
        Me.Label35.TabIndex = 708
        Me.Label35.Text = "中文船名"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShipName
        '
        Me.txtShipName.BackColor = System.Drawing.Color.Lavender
        Me.txtShipName.Location = New System.Drawing.Point(80, 38)
        Me.txtShipName.MaxLength = 40
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.ReadOnly = True
        Me.txtShipName.Size = New System.Drawing.Size(130, 21)
        Me.txtShipName.TabIndex = 6
        Me.txtShipName.Text = ""
        '
        'cbTempUnit
        '
        Me.cbTempUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTempUnit.Items.AddRange(New Object() {"", "C", "F"})
        Me.cbTempUnit.Location = New System.Drawing.Point(610, 232)
        Me.cbTempUnit.Name = "cbTempUnit"
        Me.cbTempUnit.Size = New System.Drawing.Size(42, 20)
        Me.cbTempUnit.TabIndex = 20
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(448, 232)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 18)
        Me.Label36.TabIndex = 706
        Me.Label36.Text = "冷藏温度"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(6, 88)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(72, 18)
        Me.Label31.TabIndex = 705
        Me.Label31.Text = "通知方"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNotify
        '
        Me.txtNotify.Location = New System.Drawing.Point(80, 86)
        Me.txtNotify.MaxLength = 30
        Me.txtNotify.Name = "txtNotify"
        Me.txtNotify.Size = New System.Drawing.Size(130, 21)
        Me.txtNotify.TabIndex = 13
        Me.txtNotify.Text = ""
        '
        'txtShiper
        '
        Me.txtShiper.Location = New System.Drawing.Point(80, 38)
        Me.txtShiper.MaxLength = 30
        Me.txtShiper.Name = "txtShiper"
        Me.txtShiper.Size = New System.Drawing.Size(130, 21)
        Me.txtShiper.TabIndex = 11
        Me.txtShiper.Text = ""
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(6, 40)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(72, 18)
        Me.Label33.TabIndex = 704
        Me.Label33.Text = "发货人"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(444, 40)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(72, 18)
        Me.Label34.TabIndex = 703
        Me.Label34.Text = "危险品标签"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDangerMark
        '
        Me.txtDangerMark.Location = New System.Drawing.Point(518, 38)
        Me.txtDangerMark.MaxLength = 32
        Me.txtDangerMark.Name = "txtDangerMark"
        Me.txtDangerMark.Size = New System.Drawing.Size(130, 21)
        Me.txtDangerMark.TabIndex = 22
        Me.txtDangerMark.Text = ""
        '
        'txtDangerGrade
        '
        Me.txtDangerGrade.Location = New System.Drawing.Point(522, 256)
        Me.txtDangerGrade.MaxLength = 10
        Me.txtDangerGrade.Name = "txtDangerGrade"
        Me.txtDangerGrade.Size = New System.Drawing.Size(130, 21)
        Me.txtDangerGrade.TabIndex = 21
        Me.txtDangerGrade.Text = ""
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(448, 258)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(72, 18)
        Me.Label30.TabIndex = 702
        Me.Label30.Text = "危险品等级"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(622, 180)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(30, 20)
        Me.Label28.TabIndex = 701
        Me.Label28.Text = "公斤"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalNetWeight
        '
        Me.txtTotalNetWeight.Location = New System.Drawing.Point(302, 266)
        Me.txtTotalNetWeight.MaxLength = 10
        Me.txtTotalNetWeight.Name = "txtTotalNetWeight"
        Me.txtTotalNetWeight.TabIndex = 16
        Me.txtTotalNetWeight.Text = ""
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(448, 180)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 18)
        Me.Label29.TabIndex = 700
        Me.Label29.Text = "净重"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbInOutPort
        '
        Me.cbInOutPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbInOutPort.Enabled = False
        Me.cbInOutPort.Location = New System.Drawing.Point(614, 0)
        Me.cbInOutPort.MaxDropDownItems = 20
        Me.cbInOutPort.Name = "cbInOutPort"
        Me.cbInOutPort.Size = New System.Drawing.Size(130, 20)
        Me.cbInOutPort.TabIndex = 9
        Me.cbInOutPort.Visible = False
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(540, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 18)
        Me.Label12.TabIndex = 699
        Me.Label12.Text = "进出口"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label12.Visible = False
        '
        'cbUnloadPort
        '
        Me.cbUnloadPort.Location = New System.Drawing.Point(80, 222)
        Me.cbUnloadPort.MaxDropDownItems = 20
        Me.cbUnloadPort.Name = "cbUnloadPort"
        Me.cbUnloadPort.Size = New System.Drawing.Size(104, 20)
        Me.cbUnloadPort.TabIndex = 4
        '
        'cbLoadPort
        '
        Me.cbLoadPort.Location = New System.Drawing.Point(80, 200)
        Me.cbLoadPort.MaxDropDownItems = 20
        Me.cbLoadPort.Name = "cbLoadPort"
        Me.cbLoadPort.Size = New System.Drawing.Size(130, 20)
        Me.cbLoadPort.TabIndex = 10
        '
        'cbDelivery
        '
        Me.cbDelivery.Location = New System.Drawing.Point(80, 244)
        Me.cbDelivery.MaxDropDownItems = 20
        Me.cbDelivery.Name = "cbDelivery"
        Me.cbDelivery.Size = New System.Drawing.Size(104, 20)
        Me.cbDelivery.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(6, 246)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 697
        Me.Label10.Text = "收货地"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(6, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 18)
        Me.Label11.TabIndex = 698
        Me.Label11.Text = "装货港"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(6, 224)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(72, 18)
        Me.Label32.TabIndex = 696
        Me.Label32.Text = "卸货港"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbPlace
        '
        Me.cbPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlace.Enabled = False
        Me.cbPlace.Location = New System.Drawing.Point(298, 38)
        Me.cbPlace.Name = "cbPlace"
        Me.cbPlace.Size = New System.Drawing.Size(130, 20)
        Me.cbPlace.TabIndex = 670
        '
        'txtReceiver
        '
        Me.txtReceiver.Location = New System.Drawing.Point(80, 62)
        Me.txtReceiver.MaxLength = 30
        Me.txtReceiver.Name = "txtReceiver"
        Me.txtReceiver.Size = New System.Drawing.Size(130, 21)
        Me.txtReceiver.TabIndex = 12
        Me.txtReceiver.Text = ""
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(6, 64)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 18)
        Me.Label26.TabIndex = 695
        Me.Label26.Text = "收货人"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(622, 206)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 20)
        Me.Label13.TabIndex = 693
        Me.Label13.Text = "立方"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(522, 204)
        Me.txtSize.MaxLength = 10
        Me.txtSize.Name = "txtSize"
        Me.txtSize.TabIndex = 18
        Me.txtSize.Text = ""
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(448, 206)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 18)
        Me.Label19.TabIndex = 692
        Me.Label19.Text = "总尺码"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(402, 268)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(30, 20)
        Me.Label23.TabIndex = 691
        Me.Label23.Text = "公斤"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNetWeight
        '
        Me.txtNetWeight.Location = New System.Drawing.Point(522, 178)
        Me.txtNetWeight.MaxLength = 10
        Me.txtNetWeight.Name = "txtNetWeight"
        Me.txtNetWeight.TabIndex = 17
        Me.txtNetWeight.Text = ""
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(228, 268)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 18)
        Me.Label24.TabIndex = 690
        Me.Label24.Text = "毛重"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(302, 242)
        Me.txtAmount.MaxLength = 10
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(130, 21)
        Me.txtAmount.TabIndex = 15
        Me.txtAmount.Text = ""
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(228, 244)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 18)
        Me.Label25.TabIndex = 689
        Me.Label25.Text = "总件数"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbConsign
        '
        Me.cbConsign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConsign.Location = New System.Drawing.Point(298, 62)
        Me.cbConsign.MaxDropDownItems = 20
        Me.cbConsign.Name = "cbConsign"
        Me.cbConsign.Size = New System.Drawing.Size(130, 20)
        Me.cbConsign.TabIndex = 664
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(224, 64)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 18)
        Me.Label22.TabIndex = 688
        Me.Label22.Text = "委托单位"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbState
        '
        Me.cbState.Items.AddRange(New Object() {"", "全已装箱", "部分装箱", "拆箱"})
        Me.cbState.Location = New System.Drawing.Point(518, 62)
        Me.cbState.MaxDropDownItems = 20
        Me.cbState.Name = "cbState"
        Me.cbState.Size = New System.Drawing.Size(130, 20)
        Me.cbState.TabIndex = 657
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(444, 64)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 18)
        Me.Label21.TabIndex = 687
        Me.Label21.Text = "货物处于"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbDescribe
        '
        Me.cbDescribe.Items.AddRange(New Object() {"", "全部抵运", "部分抵运"})
        Me.cbDescribe.Location = New System.Drawing.Point(518, 38)
        Me.cbDescribe.MaxDropDownItems = 20
        Me.cbDescribe.Name = "cbDescribe"
        Me.cbDescribe.Size = New System.Drawing.Size(130, 20)
        Me.cbDescribe.TabIndex = 671
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(444, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 18)
        Me.Label20.TabIndex = 686
        Me.Label20.Text = "货箱抵运"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(224, 40)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 18)
        Me.Label17.TabIndex = 684
        Me.Label17.Text = "货名/规格"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTallyClerk
        '
        Me.txtTallyClerk.Location = New System.Drawing.Point(518, 14)
        Me.txtTallyClerk.MaxLength = 10
        Me.txtTallyClerk.Name = "txtTallyClerk"
        Me.txtTallyClerk.Size = New System.Drawing.Size(130, 21)
        Me.txtTallyClerk.TabIndex = 662
        Me.txtTallyClerk.Text = ""
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(444, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 18)
        Me.Label15.TabIndex = 682
        Me.Label15.Text = "理货员"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(298, 16)
        Me.txtMark.MaxLength = 20
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(130, 21)
        Me.txtMark.TabIndex = 8
        Me.txtMark.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(224, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 680
        Me.Label9.Text = "标志"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeBegin
        '
        Me.dtpTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeBegin.Location = New System.Drawing.Point(518, 14)
        Me.dtpTimeBegin.Name = "dtpTimeBegin"
        Me.dtpTimeBegin.Size = New System.Drawing.Size(130, 21)
        Me.dtpTimeBegin.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(444, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 679
        Me.Label7.Text = "装箱时间"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbConLoadType
        '
        Me.cbConLoadType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConLoadType.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbConLoadType.Location = New System.Drawing.Point(80, 16)
        Me.cbConLoadType.Name = "cbConLoadType"
        Me.cbConLoadType.Size = New System.Drawing.Size(130, 20)
        Me.cbConLoadType.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 678
        Me.Label6.Text = "折装箱类别"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBillNO
        '
        Me.txtBillNO.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillNO.Location = New System.Drawing.Point(80, 176)
        Me.txtBillNO.MaxLength = 120
        Me.txtBillNO.Name = "txtBillNO"
        Me.txtBillNO.Size = New System.Drawing.Size(130, 21)
        Me.txtBillNO.TabIndex = 3
        Me.txtBillNO.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 677
        Me.Label4.Text = "提单号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(224, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 676
        Me.Label5.Text = "工作地点"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNO
        '
        Me.txtNO.Location = New System.Drawing.Point(298, 14)
        Me.txtNO.MaxLength = 20
        Me.txtNO.Name = "txtNO"
        Me.txtNO.Size = New System.Drawing.Size(130, 21)
        Me.txtNO.TabIndex = 669
        Me.txtNO.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(224, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 675
        Me.Label3.Text = "理货单编号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVoyage
        '
        Me.txtVoyage.BackColor = System.Drawing.Color.Lavender
        Me.txtVoyage.Location = New System.Drawing.Point(80, 62)
        Me.txtVoyage.MaxLength = 6
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.ReadOnly = True
        Me.txtVoyage.Size = New System.Drawing.Size(130, 21)
        Me.txtVoyage.TabIndex = 7
        Me.txtVoyage.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 674
        Me.Label1.Text = "航次"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShip
        '
        Me.txtShip.BackColor = System.Drawing.Color.Lavender
        Me.txtShip.Location = New System.Drawing.Point(80, 14)
        Me.txtShip.MaxLength = 40
        Me.txtShip.Name = "txtShip"
        Me.txtShip.ReadOnly = True
        Me.txtShip.Size = New System.Drawing.Size(130, 21)
        Me.txtShip.TabIndex = 5
        Me.txtShip.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 673
        Me.Label2.Text = "船名码"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(6, 4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 672
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'btQuit
        '
        Me.btQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(400, 678)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 29
        Me.btQuit.Text = "返回"
        '
        'txtReeferTemp
        '
        Me.txtReeferTemp.Location = New System.Drawing.Point(522, 230)
        Me.txtReeferTemp.MaxLength = 10
        Me.txtReeferTemp.Name = "txtReeferTemp"
        Me.txtReeferTemp.Size = New System.Drawing.Size(88, 21)
        Me.txtReeferTemp.TabIndex = 19
        Me.txtReeferTemp.Text = ""
        '
        'txtGoodsEng
        '
        Me.txtGoodsEng.Location = New System.Drawing.Point(226, 194)
        Me.txtGoodsEng.MaxLength = 200
        Me.txtGoodsEng.Multiline = True
        Me.txtGoodsEng.Name = "txtGoodsEng"
        Me.txtGoodsEng.Size = New System.Drawing.Size(206, 46)
        Me.txtGoodsEng.TabIndex = 10
        Me.txtGoodsEng.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(228, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 18)
        Me.Label8.TabIndex = 710
        Me.Label8.Text = "英文货名"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCreateMessage
        '
        Me.btnCreateMessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCreateMessage.Location = New System.Drawing.Point(486, 678)
        Me.btnCreateMessage.Name = "btnCreateMessage"
        Me.btnCreateMessage.Size = New System.Drawing.Size(65, 24)
        Me.btnCreateMessage.TabIndex = 711
        Me.btnCreateMessage.Text = "报文生成"
        Me.btnCreateMessage.Visible = False
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(444, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 18)
        Me.Label16.TabIndex = 715
        Me.Label16.Text = "危险品编号 "
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDangerCodeNO
        '
        Me.txtDangerCodeNO.Location = New System.Drawing.Point(518, 62)
        Me.txtDangerCodeNO.MaxLength = 10
        Me.txtDangerCodeNO.Name = "txtDangerCodeNO"
        Me.txtDangerCodeNO.Size = New System.Drawing.Size(130, 21)
        Me.txtDangerCodeNO.TabIndex = 23
        Me.txtDangerCodeNO.Text = ""
        '
        'txtDangerPageNo
        '
        Me.txtDangerPageNo.Location = New System.Drawing.Point(518, 86)
        Me.txtDangerPageNo.MaxLength = 10
        Me.txtDangerPageNo.Name = "txtDangerPageNo"
        Me.txtDangerPageNo.Size = New System.Drawing.Size(130, 21)
        Me.txtDangerPageNo.TabIndex = 24
        Me.txtDangerPageNo.Text = ""
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(444, 88)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(72, 18)
        Me.Label37.TabIndex = 714
        Me.Label37.Text = "危险品页号"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbPack
        '
        Me.cbPack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPack.Location = New System.Drawing.Point(80, 266)
        Me.cbPack.MaxDropDownItems = 20
        Me.cbPack.Name = "cbPack"
        Me.cbPack.Size = New System.Drawing.Size(130, 20)
        Me.cbPack.TabIndex = 14
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(6, 268)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(72, 18)
        Me.Label38.TabIndex = 717
        Me.Label38.Text = "包装"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGoodsName
        '
        Me.txtGoodsName.Location = New System.Drawing.Point(224, 60)
        Me.txtGoodsName.MaxLength = 100
        Me.txtGoodsName.Multiline = True
        Me.txtGoodsName.Name = "txtGoodsName"
        Me.txtGoodsName.Size = New System.Drawing.Size(204, 48)
        Me.txtGoodsName.TabIndex = 9
        Me.txtGoodsName.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbState)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.cbDescribe)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtTallyClerk)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtNO)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbPlace)
        Me.GroupBox1.Controls.Add(Me.cbConsign)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtVoyage)
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Controls.Add(Me.txtShipName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtShip)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(700, 88)
        Me.GroupBox1.TabIndex = 719
        Me.GroupBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Lavender
        Me.Label14.Location = New System.Drawing.Point(70, 152)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 22)
        Me.Label14.TabIndex = 720
        Me.Label14.Text = "将导入的船次："
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbResultShip
        '
        Me.lbResultShip.BackColor = System.Drawing.Color.Lavender
        Me.lbResultShip.Location = New System.Drawing.Point(164, 152)
        Me.lbResultShip.Name = "lbResultShip"
        Me.lbResultShip.Size = New System.Drawing.Size(138, 22)
        Me.lbResultShip.TabIndex = 721
        Me.lbResultShip.Text = "无"
        Me.lbResultShip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnRevert
        '
        Me.btnRevert.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRevert.Location = New System.Drawing.Point(248, 678)
        Me.btnRevert.Name = "btnRevert"
        Me.btnRevert.Size = New System.Drawing.Size(65, 24)
        Me.btnRevert.TabIndex = 28
        Me.btnRevert.Text = "还原"
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBack.Location = New System.Drawing.Point(172, 678)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(65, 24)
        Me.btnBack.TabIndex = 27
        Me.btnBack.Text = "退关"
        '
        'lbOldShip
        '
        Me.lbOldShip.BackColor = System.Drawing.Color.Lavender
        Me.lbOldShip.Location = New System.Drawing.Point(404, 152)
        Me.lbOldShip.Name = "lbOldShip"
        Me.lbOldShip.Size = New System.Drawing.Size(138, 22)
        Me.lbOldShip.TabIndex = 725
        Me.lbOldShip.Text = "无"
        Me.lbOldShip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.Lavender
        Me.Label27.Location = New System.Drawing.Point(310, 152)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(92, 22)
        Me.Label27.TabIndex = 724
        Me.Label27.Text = "曾导入的船次："
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFindNo
        '
        Me.txtFindNo.Location = New System.Drawing.Point(102, 34)
        Me.txtFindNo.MaxLength = 20
        Me.txtFindNo.Name = "txtFindNo"
        Me.txtFindNo.Size = New System.Drawing.Size(130, 21)
        Me.txtFindNo.TabIndex = 3
        Me.txtFindNo.Text = ""
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(36, 36)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 18)
        Me.Label18.TabIndex = 733
        Me.Label18.Text = "理货单编号"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFindBill
        '
        Me.txtFindBill.Location = New System.Drawing.Point(406, 6)
        Me.txtFindBill.MaxLength = 120
        Me.txtFindBill.Name = "txtFindBill"
        Me.txtFindBill.Size = New System.Drawing.Size(130, 21)
        Me.txtFindBill.TabIndex = 0
        Me.txtFindBill.Text = ""
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(364, 8)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(42, 18)
        Me.Label39.TabIndex = 732
        Me.Label39.Text = "提单号"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFindVoyage
        '
        Me.txtFindVoyage.Location = New System.Drawing.Point(232, 6)
        Me.txtFindVoyage.MaxLength = 6
        Me.txtFindVoyage.Name = "txtFindVoyage"
        Me.txtFindVoyage.Size = New System.Drawing.Size(130, 21)
        Me.txtFindVoyage.TabIndex = 1
        Me.txtFindVoyage.Text = ""
        '
        'Label40
        '
        Me.Label40.Location = New System.Drawing.Point(202, 8)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(30, 18)
        Me.Label40.TabIndex = 731
        Me.Label40.Text = "航次"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFindShip
        '
        Me.txtFindShip.Location = New System.Drawing.Point(66, 6)
        Me.txtFindShip.MaxLength = 40
        Me.txtFindShip.Name = "txtFindShip"
        Me.txtFindShip.Size = New System.Drawing.Size(130, 21)
        Me.txtFindShip.TabIndex = 0
        Me.txtFindShip.Text = ""
        '
        'Label41
        '
        Me.Label41.Location = New System.Drawing.Point(36, 8)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(30, 18)
        Me.Label41.TabIndex = 730
        Me.Label41.Text = "船码"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(446, 32)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(90, 26)
        Me.btnFind.TabIndex = 2
        Me.btnFind.Text = "查   找"
        '
        'txtContainerNo
        '
        Me.txtContainerNo.Location = New System.Drawing.Point(310, 34)
        Me.txtContainerNo.MaxLength = 20
        Me.txtContainerNo.Name = "txtContainerNo"
        Me.txtContainerNo.Size = New System.Drawing.Size(130, 21)
        Me.txtContainerNo.TabIndex = 1
        Me.txtContainerNo.Text = ""
        '
        'Label42
        '
        Me.Label42.Location = New System.Drawing.Point(236, 36)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(72, 18)
        Me.Label42.TabIndex = 735
        Me.Label42.Text = "箱号"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtReceiver)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtMark)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.dtpTimeBegin)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtDangerCodeNO)
        Me.GroupBox2.Controls.Add(Me.txtDangerPageNo)
        Me.GroupBox2.Controls.Add(Me.txtGoodsName)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.txtNotify)
        Me.GroupBox2.Controls.Add(Me.txtShiper)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.txtDangerMark)
        Me.GroupBox2.Controls.Add(Me.cbConLoadType)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(4, 288)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(698, 114)
        Me.GroupBox2.TabIndex = 736
        Me.GroupBox2.TabStop = False
        '
        'bt1
        '
        Me.bt1.Location = New System.Drawing.Point(188, 224)
        Me.bt1.Name = "bt1"
        Me.bt1.Size = New System.Drawing.Size(22, 14)
        Me.bt1.TabIndex = 737
        Me.bt1.Text = "..."
        '
        'bt2
        '
        Me.bt2.Location = New System.Drawing.Point(188, 246)
        Me.bt2.Name = "bt2"
        Me.bt2.Size = New System.Drawing.Size(22, 14)
        Me.bt2.TabIndex = 738
        Me.bt2.Text = "..."
        '
        'FrmConLoadFinalCheck_Deal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(706, 707)
        Me.Controls.Add(Me.bt2)
        Me.Controls.Add(Me.bt1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtContainerNo)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txtFindNo)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtFindBill)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.txtFindVoyage)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.txtFindShip)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.lbOldShip)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRevert)
        Me.Controls.Add(Me.lbResultShip)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cbPack)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.btnCreateMessage)
        Me.Controls.Add(Me.txtGoodsEng)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.cbTempUnit)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.txtDangerGrade)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtTotalNetWeight)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.cbUnloadPort)
        Me.Controls.Add(Me.cbLoadPort)
        Me.Controls.Add(Me.cbDelivery)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtNetWeight)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtBillNO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.txtReeferTemp)
        Me.Controls.Add(Me.cbInOutPort)
        Me.Controls.Add(Me.Label12)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConLoadFinalCheck_Deal"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "出口集装箱放行核查 处理"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmConLoadFinalCheck_Deal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dvCodeGoods As New DataView
        Dim sqlstr, sqlCodeGoods As String
        Me.StartPosition = FormStartPosition.CenterScreen

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


        sqlCodeYard = "SELECT Code_Yard_ID, Code_Yard_Name, CodePrefix FROM Code_Yard ORDER BY Code_Yard_ID"
        cbPlace.DataSource = Filldata(sqlCodeYard)
        cbPlace.DisplayMember = "Code_Yard_Name"
        cbPlace.ValueMember = "Code_Yard_ID"

        Dim sqlCodePort As String
        sqlCodePort = "SELECT CODE_PORT, PORT_CHA, PORT_ENG FROM CODE_PORT ORDER BY PORT_ENG"

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

        Dim sqlPack As String
        sqlPack = "SELECT CODE_PACK, PACK_CHA, PACK_ENG FROM CODE_PACK ORDER BY CODE_PACK"
        dvPack = Filldata(sqlPack)
        Me.cbPack.DataSource = dvPack
        Me.cbPack.DisplayMember = "PACK_CHA"
        Me.cbPack.ValueMember = "CODE_PACK"
        Me.txtNO.Enabled = False
        Me.cbPlace.Enabled = False
        Me.txtTallyClerk.Enabled = False

        sqlstr = "select * from Con_Load_Tally where Con_Load_Tally_ID =" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        dtpTimeBegin.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"
        cbConsign.SelectedValue = "00"
        If dw.Count > 0 Then
            cbPlace.SelectedValue = ds.Tables(0).Rows(0).Item("WORK_PLACE")
            txtNO.Text = ds.Tables(0).Rows(0).Item("NO")
            txtID.Text = ds.Tables(0).Rows(0).Item("Con_Load_Tally_ID")

            txtShip.Text = ds.Tables(0).Rows(0).Item("CHI_VESSEL")
            txtVoyage.Text = ds.Tables(0).Rows(0).Item("VOYAGE")
            Me.cbInOutPort.SelectedValue = ds.Tables(0).Rows(0)("InOutPort")
            '写两遍，不是废话。当值不存在时，使SelectedValue为空
            Me.cbLoadPort.SelectedValue = ds.Tables(0).Rows(0)("CodeLoadPort")
            If Me.cbLoadPort.SelectedIndex = 0 Then
                Me.cbLoadPort.SelectedValue = ds.Tables(0).Rows(0)("CodeLoadPort")
            End If
            Me.cbUnloadPort.SelectedValue = ds.Tables(0).Rows(0)("CodeUnloadPort")
            Me.cbDelivery.SelectedValue = ds.Tables(0).Rows(0)("CodeDelivery")
            cbConLoadType.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_TALLY_TYPE")
            dtpTimeBegin.Value = ds.Tables(0).Rows(0).Item("TIME_FROM")

            txtBillNO.Text = ds.Tables(0).Rows(0).Item("BLNO")

            txtMark.Text = ds.Tables(0).Rows(0).Item("MARK")
            Me.txtGoodsName.Text = ds.Tables(0).Rows(0).Item("GoodsCha")
            strGoodsName = ds.Tables(0).Rows(0).Item("GoodsCha")
            txtAmount.Text = ds.Tables(0).Rows(0).Item("AMOUNT")
            'txtTotalWeight.Text = ds.Tables(0).Rows(0).Item("TOTAL_WEIGHT")
            txtTotalNetWeight.Text = ds.Tables(0).Rows(0)("TOTALNetWEIGHT")
            txtSize.Text = ds.Tables(0).Rows(0).Item("SIZE_MEASURE")
            Me.txtReeferTemp.Text = ds.Tables(0).Rows(0)("ReeferTemp")
            Me.cbTempUnit.Text = ds.Tables(0).Rows(0)("TempUnit")
            Me.txtDangerGrade.Text = ds.Tables(0).Rows(0)("DangerGrade")
            Me.txtDangerMark.Text = ds.Tables(0).Rows(0)("DangerMark")

            cbDescribe.Text = ds.Tables(0).Rows(0).Item("DESCR")
            cbState.Text = ds.Tables(0).Rows(0).Item("STATE")
            Me.txtShiper.Text = ds.Tables(0).Rows(0)("Shipper")
            txtReceiver.Text = ds.Tables(0).Rows(0).Item("RECEIVER")
            Me.txtNotify.Text = ds.Tables(0).Rows(0)("Notify")
            txtTallyClerk.Text = ds.Tables(0).Rows(0).Item("TALLY_CLERK")
            'txtCrossPerson.Text = ds.Tables(0).Rows(0).Item("CROSS_PERSON")
            cbConsign.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_CON_CONSIGN")

            strShipOg = txtShip.Text
            strVoyageOg = txtVoyage.Text
            strBillNoOg = txtBillNO.Text

            strShipCode = Me.txtShip.Text.Trim.ToUpper
            sqlShipCode = "SELECT SPCODE, CHI_VESSEL,ENG_VESSEL FROM Code_SHIPNAME WHERE SPCODE = '" & strShipCode & "'"
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
            End If
            sqlSubTable = "SELECT A.CONTAINER_NO,A.SIZE_CON,A.CONTAINER_TYPE,A.NEWSEALNO,SealType,SealPerson,A.PACK_CHA,A.AMOUNT,A.WEIGHT,A.NetWeight,A.VOLUME,A.DAMAGED_AMOUNT,A.DAMAGED_PACK,A.SecSealNO,A.ReasonOpenSeal,A.CodeYard,A.ReeferTemp,A.TempUnit,A.DangerGrade,A.DangerMark,A.Checked,A.StateC,A.FullOrEmpty " & _
                ", CON_CRITERION.CODE_SHIP_OWNER, CODE_SHIP_OWNER.ShipOWNER_CHA, A.OVER_HEIGHT,A.OVER_FRONT,A.OVER_BACK,A.OVER_LEFT,A.OVER_RIGHT " & _
                " FROM CODE_SHIP_OWNER RIGHT OUTER JOIN CON_CRITERION ON CODE_SHIP_OWNER.CODE_SHIPOWNER = CON_CRITERION.CODE_SHIP_OWNER RIGHT OUTER JOIN CON_LOAD_TALLY_LIST  A ON CON_CRITERION.CONTAINER_NO = A.CONTAINER_NO " & _
                " where  CHI_VESSEL ='" & Me.txtShip.Text & "' and Voyage = '" & Me.txtVoyage.Text & "' and blno= '" & Me.txtBillNO.Text & "' and CodeYard= '" & Me.cbPlace.SelectedValue & "'"
            InitSubTable()     '初始化子表c1grid

            '处理包装，取第一个箱包装
            Me.cbPack.SelectedValue = Me.C1DBG.Columns("PACK_CHA").Value

            '得到将要导出入的船次
            sqlResultShip = "SELECT SHIP_ID, V_ID, Vessel_Code, SSHIP.CHI_VESSEL, SSHIP.ENG_VESSEL, VOYAGE, INOUTPORT FROM SSHIP INNER JOIN VESSEL ON V_ID = VESSEL_ID " & _
                            " where Vessel_Code='" & Me.txtShip.Text & "' and voyage='" & Me.txtVoyage.Text & "' "
            dvResultShip = Filldata(sqlResultShip)
            If dvResultShip.Count = 1 Then
                If Not IsDBNull(dvResultShip(0)("CHI_VESSEL")) Then
                    Me.lbResultShip.Text = dvResultShip(0)("CHI_VESSEL")
                End If
                If Not IsDBNull(dvResultShip(0)("VOYAGE")) Then
                    Me.lbResultShip.Text = Me.lbResultShip.Text & " " & dvResultShip(0)("VOYAGE")
                End If
                Ship_ID = dvResultShip(0)("SHIP_ID")
            Else
                Me.lbResultShip.Text = "无"
                Ship_ID = 0
            End If

            '找出原先导入的船次
            If IsDBNull(ds.Tables(0).Rows(0)("SHIP_ID")) Then
                strOldShip = "0"
            Else
                strOldShip = ds.Tables(0).Rows(0)("SHIP_ID")
            End If
            Dim sqlOldShip As String
            sqlOldShip = "SELECT ENG_VESSEL, CHI_VESSEL, VOYAGE FROM SSHIP WHERE (SHIP_ID = '" & strOldShip & "')"
            Dim dvOldShip As New DataView
            dvOldShip = Filldata(sqlOldShip)
            If dvOldShip.Count = 1 Then
                If Not IsDBNull(dvOldShip(0)("CHI_VESSEL")) Then
                    Me.lbOldShip.Text = dvOldShip(0)("CHI_VESSEL")
                End If
                If Not IsDBNull(dvOldShip(0)("VOYAGE")) Then
                    Me.lbOldShip.Text = Me.lbOldShip.Text & " " & dvOldShip(0)("VOYAGE")
                End If
            End If

            If ds.Tables(0).Rows(0).Item("StateB") = "1" Then
                MessageBox.Show("该理货单尚未出证，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            If txtBillNO.Text Like "*[#][#]" Then
                txtBillNO.Text = Mid(txtBillNO.Text, 1, txtBillNO.Text.Length - 2)
            End If

            If Me.cbLoadPort.SelectedValue Is Nothing Then
                Me.cbLoadPort.SelectedValue = "CNLYG"
                If Me.cbLoadPort.SelectedValue Is Nothing Then
                    Me.cbLoadPort.SelectedValue = "LYG"
                    If Me.cbLoadPort.SelectedValue Is Nothing Then
                        Me.cbLoadPort.SelectedIndex = 0
                    End If
                End If
            End If
        End If

        Select Case FrmConLoadFinalNew.strOperateMark
            Case "0"
                Me.btSave.Visible = False
                Me.btnRevert.Visible = False
                Me.btnBack.Visible = False
                Me.btQuit.Location = Me.btSave.Location
            Case "1"
                Me.btnRevert.Visible = False
                Me.btnBack.Visible = False
                Me.btSave.Text = "放行(&S)"
            Case "2"
                Me.btSave.Visible = False
                Me.btnBack.Text = "退关"
                Me.btnRevert.Text = "还原"
                Me.btnBack.Location = Me.btSave.Location
                Me.txtBillNO.ReadOnly = True
            Case "3"
                Me.btnBack.Visible = False
                Me.btSave.Text = "放行(&S)"
                Me.btnRevert.Text = "还原"
                'Me.txtBillNO.ReadOnly = True
        End Select
        Me.txtFindBill.Focus()
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
            
            Me.C1DBG.Splits(0).DisplayColumns.Item("Checked").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("StateC").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("FullOrEmpty").Visible = False

            Me.C1DBG.Columns.Item("CONTAINER_NO").Caption = "集装箱号"
            Me.C1DBG.Columns.Item("SIZE_CON").Caption = "箱尺"
            Me.C1DBG.Columns.Item("CONTAINER_TYPE").Caption = "箱型"
            Me.C1DBG.Columns.Item("NEWSEALNO").Caption = "铅封号"
            Me.C1DBG.Columns.Item("SealType").Caption = "类型"
            Me.C1DBG.Columns.Item("SealPerson").Caption = "施封人"
            Me.C1DBG.Columns.Item("AMOUNT").Caption = "件数"
            Me.C1DBG.Columns.Item("PACK_CHA").Caption = "包装"
            Me.C1DBG.Columns.Item("WEIGHT").Caption = "总重kg"
            Me.C1DBG.Columns.Item("NetWeight").Caption = "货重kg"
            Me.C1DBG.Columns.Item("VOLUME").Caption = "体积M3"
            Me.C1DBG.Columns.Item("SecSealNO").Caption = "备注封"
            Me.C1DBG.Columns.Item("ReasonOpenSeal").Caption = "开封原因"
            Me.C1DBG.Columns.Item("DAMAGED_AMOUNT").Caption = "残损件数"
            Me.C1DBG.Columns.Item("DAMAGED_PACK").Caption = "残损情况"
            Me.C1DBG.Columns.Item("CodeYard").Caption = "装箱地点"
            Me.C1DBG.Columns.Item("ReeferTemp").Caption = "冷藏温度"
            Me.C1DBG.Columns.Item("TempUnit").Caption = "温标"
            Me.C1DBG.Columns.Item("DangerGrade").Caption = "危品等级"
            Me.C1DBG.Columns.Item("DangerMark").Caption = "危品标签"
            Me.C1DBG.Columns.Item("FullOrEmpty").Caption = "空重箱"
            Me.C1DBG.Columns.Item("CODE_SHIP_OWNER").Caption = "经营人码"
            Me.C1DBG.Columns.Item("ShipOWNER_CHA").Caption = "经营人"
            Me.C1DBG.Columns.Item("OVER_HEIGHT").Caption = "超高"
            Me.C1DBG.Columns.Item("OVER_FRONT").Caption = "前超"
            Me.C1DBG.Columns.Item("OVER_BACK").Caption = "后超"
            Me.C1DBG.Columns.Item("OVER_LEFT").Caption = "左超"
            Me.C1DBG.Columns.Item("OVER_RIGHT").Caption = "右超"

            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("CodeYard").Locked = True
            Call FieldFill()
            SetDGWidth2(Me.C1DBG)

            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_TYPE").AutoDropDown = True
            Me.C1DBG.Splits(0).DisplayColumns("SealType").AutoDropDown = True
            Me.C1DBG.Splits(0).DisplayColumns("SealPerson").AutoDropDown = True
            Me.C1DBG.Splits(0).DisplayColumns("PACK_CHA").AutoDropDown = True

        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FieldFill()
        Dim i As Integer
        Try
            Dim sqlConKind As String = "SELECT CODE_CON_KIND, CON_KIND_ENG FROM CODE_CON_KIND ORDER BY CODE_CON_KIND"
            Dim dvConKind As New DataView
            dvConKind = Filldata(sqlConKind)
            Me.C1DBG.Columns("CONTAINER_TYPE").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("CONTAINER_TYPE").ValueItems.Translate = True
            For i = 0 To dvConKind.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = dvConKind(i)("CON_KIND_ENG")
                vi.Value = dvConKind(i)("CODE_CON_KIND")
                Me.C1DBG.Columns.Item("CONTAINER_TYPE").ValueItems.Values.Add(vi)
            Next

            Dim sqlPack As String = "SELECT CODE_PACK, PACK_CHA, PACK_ENG FROM CODE_PACK ORDER BY CODE_PACK"
            Dim dvPack As New DataView
            dvPack = Filldata(sqlPack)
            Me.C1DBG.Columns("PACK_CHA").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("PACK_CHA").ValueItems.Translate = True
            For i = 0 To dvPack.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
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
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Width = 60
                i = i + 1
            Loop
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Width = 90
            Me.C1DBG.Splits(0).DisplayColumns("NEWSEALNO").Width = 90
            Me.C1DBG.Splits(0).DisplayColumns("SIZE_CON").Width = 30
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_TYPE").Width = 40
            Me.C1DBG.Splits(0).DisplayColumns("ReeferTemp").Width = 40
            Me.C1DBG.Splits(0).DisplayColumns("TempUnit").Width = 40
            Me.C1DBG.Splits(0).DisplayColumns("OVER_HEIGHT").Width = 30
            Me.C1DBG.Splits(0).DisplayColumns("OVER_FRONT").Width = 30
            Me.C1DBG.Splits(0).DisplayColumns("OVER_BACK").Width = 30
            Me.C1DBG.Splits(0).DisplayColumns("OVER_LEFT").Width = 30
            Me.C1DBG.Splits(0).DisplayColumns("OVER_Right").Width = 30
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim i As Integer
        Const strNull As String = "null"

        txtGoodsName.Text = txtGoodsName.Text.Trim()
        txtGoodsName.Text = TrimReturn(txtGoodsName.Text)
        txtGoodsEng.Text = txtGoodsEng.Text.Trim()
        txtGoodsEng.Text = TrimReturn(txtGoodsEng.Text)

        If Me.cbUnloadPort.SelectedIndex < 0 Then
            Me.cbUnloadPort.SelectedIndex = 0
        End If
        If Me.cbDelivery.SelectedIndex < 0 Then
            Me.cbDelivery.SelectedIndex = 0
        End If
        If (Me.txtAmount.Text.Trim.Length > 0) Then
            If Not IsNumeric(Me.txtAmount.Text) Then
                Me.txtAmount.Focus()
                MessageBox.Show("总件数应为非零数字", "提示")
                Exit Sub
            End If
        End If
        If (Me.txtTotalNetWeight.Text.Trim.Length > 0) Then
            If Not IsNumeric(Me.txtTotalNetWeight.Text) Then
                Me.txtTotalNetWeight.Focus()
                MessageBox.Show("毛重应为非零数字", "提示")
                Exit Sub
            End If
        End If
        If Me.txtNetWeight.Text.Trim.Length > 0 Then
            If Not IsNumeric(Me.txtNetWeight.Text) Then
                Me.txtNetWeight.Focus()
                MessageBox.Show("净重应为非零数字", "提示")
                Exit Sub
            End If
        End If
        'If Not IsNumeric(Me.txtSize.Text) Then
        '    Me.txtSize.Focus()
        '    MessageBox.Show("总尺码应为非零数字", "提示")
        '    Exit Sub
        'End If
        If Me.txtReeferTemp.Text.Trim.Length > 0 Then
            If Not IsNumeric(Me.txtReeferTemp.Text) Then
                Me.txtReeferTemp.Focus()
                MessageBox.Show("冷冻温度应为非零数字", "提示")
                Exit Sub
            End If
        End If

        For i = 0 To dvSubTable.Count - 1
            Me.C1DBG.Row = i
            If Not Me.C1DBG.Columns("SIZE_CON").Text Like "##" Then
                Me.C1DBG.Row = i
                MessageBox.Show("箱尺寸应为非零两位数字", "提示")
                Exit Sub
            End If
            Me.C1DBG.Columns("CONTAINER_TYPE").Text = Me.C1DBG.Columns("CONTAINER_TYPE").Text.Trim.ToUpper
            If Not Me.C1DBG.Columns("CONTAINER_TYPE").Text Like "[A-Z][A-Z]" Then
                Me.C1DBG.Row = i
                MessageBox.Show("箱型应为两位字母", "提示")
                Exit Sub
            End If
            'If Not IsNumeric(Me.C1DBG.Columns("AMOUNT").Text) Then
            '    Me.C1DBG.Row = i
            '    MessageBox.Show("箱件数应为非零数字", "提示")
            '    Exit Sub
            'End If
            'If Not IsNumeric(Me.C1DBG.Columns("NetWeight").Text) Then
            '    Me.C1DBG.Row = i
            '    MessageBox.Show("箱货重应为非零数字", "提示")
            '    Exit Sub
            'End If
            'If Not IsNumeric(Me.C1DBG.Columns("VOLUME").Text) Then
            '    Me.C1DBG.Row = i
            '    MessageBox.Show("箱内体积应为非零数字", "提示")
            '    Exit Sub
            'End If
        Next

        Try
            If BillMark = True Then '修改了提单号
                Dim sqlExist As String
                sqlExist = "select * from CON_LOAD_Tally where BLNO = '" & txtBillNO.Text & _
                            "' and CHI_VESSEL = '" & txtShip.Text & _
                            "' and VOYAGE = '" & txtVoyage.Text & "' and Work_Place = '" & Me.cbPlace.SelectedValue & "' and CON_LOAD_TALLY_ID <> '" & ID & "'"
                Dim dvExist As New DataView
                dvExist = Filldata(sqlExist)
                If dvExist.Count = 0 Then

                Else
                    Me.txtBillNO.Focus()
                    MessageBox.Show("同船次提单号不可重复", "提示")
                    Exit Sub
                End If
            End If

            Dim dgResult As DialogResult
            If Ship_ID > 0 Then
                dgResult = MessageBox.Show("即将导入该船次：" & Me.lbResultShip.Text & "，确定么？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
            Else
                dgResult = DialogResult.No
            End If
            If dgResult = DialogResult.Yes Then
                '直接导就可以
            ElseIf dgResult = DialogResult.No Then
                '列出船次供其选择
                Dim FrmSelShip As New FrmConLoadFinal_SelectShip
                FrmSelShip.ShowDialog()
                If FrmSelShip.beSureMark = True Then
                    '确定选过船了，继续
                Else    '否则，退出
                    Exit Sub
                End If
            Else
                '取消操作
                Exit Sub
            End If

            Dim sqlBillExist As String
            Dim dvBillExist As New DataView
            Dim sqlAddBill As String
            sqlBillExist = "SELECT Ship_ID, BLNO FROM CON_HATCH_LIST WHERE SHIP_ID = '" & Ship_ID & "' AND BLNO = '" & Me.txtBillNO.Text & "'"
            dvBillExist = Filldata(sqlBillExist)
            If dvBillExist.Count = 0 Then
                Dim strEmpty As String
                If Me.cbConLoadType.SelectedValue <> "4" Then
                    strEmpty = "F"
                Else
                    strEmpty = "E"
                End If

                Dim strAmount, strWeight, strMeasure, strTemp As String
                If IsNumeric(Trim(Me.txtSize.Text)) Then
                    strMeasure = Trim(Me.txtSize.Text)
                Else
                    strMeasure = strNull
                End If
                If IsNumeric(Trim(Me.txtAmount.Text)) Then
                    strAmount = Trim(Me.txtAmount.Text)
                Else
                    strAmount = strNull
                End If
                If IsNumeric(Trim(Me.txtNetWeight.Text)) Then
                    strWeight = Trim(Me.txtNetWeight.Text)
                Else
                    strWeight = strNull
                End If
                If IsNumeric(Trim(Me.txtReeferTemp.Text)) Then
                    strTemp = Trim(Me.txtReeferTemp.Text)
                Else
                    strTemp = strNull
                End If
                Dim strGrossWeight As String
                If IsNumeric(Trim(Me.txtTotalNetWeight.Text)) Then
                    strGrossWeight = Trim(Me.txtTotalNetWeight.Text)
                Else
                    strGrossWeight = strNull
                End If

                '现在对于不存在的港口代码导不出
                If Me.cbLoadPort.SelectedValue Is Nothing Then
                    Me.cbLoadPort.SelectedValue = "CNLYG"
                    If Me.cbLoadPort.SelectedValue Is Nothing Then
                        Me.cbLoadPort.SelectedValue = "LYG"
                        If Me.cbLoadPort.SelectedValue Is Nothing Then
                            Me.cbLoadPort.SelectedIndex = 0
                        End If
                    End If
                End If
                If Me.cbUnloadPort.SelectedValue Is Nothing Then
                    Me.cbUnloadPort.SelectedIndex = 0
                End If
                If Me.cbDelivery.SelectedValue Is Nothing Then
                    Me.cbDelivery.SelectedIndex = 0
                End If
                If Me.cbPack.SelectedValue Is Nothing Then
                    Me.cbPack.SelectedIndex = 0
                End If
                sqlAddBill = "INSERT INTO CON_HATCH_LIST (SHIP_ID, BLNO, CODE_LOAD_PORT, LOAD_PORT, CODE_UNLOAD_PORT, UNLOAD_PORT, CODE_PLACE_RECEIVE, PLACE_RECEIVE, LOAD_DATE, EMPTY_MARK, MARK, GOODS_CHA, GOODS_ENG, " & _
                                    "CONTAINER_MARK, CODE_PACK, PACK, CONTAINER, AMOUNT, NETWEIGHT, GROSS_WEIGHT, SIZE_MEASURE, REFRIGERATE_TEMPERATURE, TEMPERATURE, DANGER_GRADE, DANGER_NO, DANGER_PAGENO, DANGER_MARK, RECEIVER, NOTIFY_PERSON, USER_NAME) " & _
                "VALUES ('" & Ship_ID & "', '" & Me.txtBillNO.Text & "', '" & Me.cbLoadPort.SelectedValue & "', '" & Me.dvLoadPort(Me.cbLoadPort.SelectedIndex)("PORT_ENG") & "', '" & Me.cbUnloadPort.SelectedValue & "', '" & Me.dvUnloadPort(Me.cbUnloadPort.SelectedIndex)("PORT_ENG") & "'," & _
                "'" & Me.cbDelivery.SelectedValue & "', '" & Me.dvDelivery(Me.cbDelivery.SelectedIndex)("PORT_ENG") & "', '" & Me.dtpTimeBegin.Value & "', '" & strEmpty & "', '" & Me.txtMark.Text & "', '" & Me.txtGoodsName.Text & "', '" & Me.txtGoodsEng.Text & "', '" & strEmpty & "', '" & Me.cbPack.SelectedValue & "', '" & Me.dvPack(Me.cbPack.SelectedIndex)("PACK_ENG") & "', " & _
                "" & Me.dvSubTable.Count & ", " & strAmount & ", " & strWeight & ", " & strGrossWeight & ", " & strMeasure & ", " & strTemp & ", '" & Me.cbTempUnit.Text & "', '" & Me.txtDangerGrade.Text & "', '" & Me.txtDangerCodeNO.Text & "', '" & Me.txtDangerPageNo.Text & "', '" & Me.txtDangerMark.Text & "', '" & Me.txtReceiver.Text & "', '" & Me.txtNotify.Text & "', '" & G_User & "') "
                ExecSql(sqlAddBill)
            Else
                MessageBox.Show("该船次该提单号已存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            Dim sqlRelationExist As String
            Dim dvRelationExist As New DataView
            Dim sqlAddRelation As String
            For i = 0 To dvSubTable.Count - 1
                sqlRelationExist = "SELECT SHIP_ID, BLNO, CONTAINER_NO FROM CON_HATCH_CARGO WHERE (SHIP_ID = '" & Ship_ID & "') AND (BLNO = '" & Me.txtBillNO.Text & "') AND (CONTAINER_NO = '" & Me.C1DBG.Columns("CONTAINER_NO").CellText(i) & "')"
                dvRelationExist = Filldata(sqlRelationExist)
                If dvRelationExist.Count = 0 Then
                    sqlAddRelation = "INSERT INTO CON_HATCH_CARGO (SHIP_ID, BLNO, CONTAINER_NO, USER_NAME) VALUES ('" & Ship_ID & "', '" & Me.txtBillNO.Text & "', '" & Me.C1DBG.Columns("CONTAINER_NO").CellText(i) & "', '" & G_User & "')"
                    ExecSql(sqlAddRelation)
                End If
            Next

            Dim sqlConExist As String
            Dim dvConExist As New DataView
            Dim sqlAddCon As String
            Dim sqlConPin As String
            Dim dvConPin As DataView
            Dim strPinCode As String
            For i = 0 To dvSubTable.Count - 1
                sqlConExist = "SELECT SHIP_ID, CONTAINER_NO FROM CON_HATCH_RECORD WHERE (SHIP_ID = '" & Ship_ID & "') AND (CONTAINER_NO = '" & Me.C1DBG.Columns("CONTAINER_NO").CellText(i) & "')"
                dvConExist = Filldata(sqlConExist)
                If dvConExist.Count = 0 Then
                    sqlConPin = "SELECT * FROM View_ConLoadTally WHERE (CHI_VESSEL = '" & Me.txtShip.Text & "') AND (Voyage = '" & Me.txtVoyage.Text & "') AND (CONTAINER_NO = '" & Me.C1DBG.Columns("CONTAINER_NO").CellText(i) & "')"
                    dvConPin = Filldata(sqlConPin)
                    If dvConPin.Count = 1 Then
                        If Me.C1DBG.Columns("FullOrEmpty").Text = "E" Then  '检查桥的空箱
                            strPinCode = "E"
                        Else
                            If dvConPin(0)("CODE_TALLY_TYPE") = "4" Then   '是空箱
                                strPinCode = "E"
                            Else
                                strPinCode = "F"
                            End If
                        End If
                    ElseIf dvConPin.Count > 1 Then
                        strPinCode = "L"
                    End If
                    Dim strConSize, strAmount As String
                    Dim strWeight, strVolume As String
                    Dim strReefer As String
                    If IsNumeric(Me.C1DBG.Columns("SIZE_CON").CellText(i)) Then
                        strConSize = Me.C1DBG.Columns("SIZE_CON").CellText(i)
                    Else
                        strConSize = strNull
                    End If
                    If IsNumeric(Me.C1DBG.Columns("AMOUNT").CellText(i)) Then
                        strAmount = Me.C1DBG.Columns("AMOUNT").CellText(i)
                    Else
                        strAmount = strNull
                    End If
                    If IsNumeric(Me.C1DBG.Columns("NetWeight").CellText(i)) Then
                        strWeight = Me.C1DBG.Columns("NetWeight").CellText(i)
                    Else
                        strWeight = 0   '就它例外
                    End If
                    If IsNumeric(Me.C1DBG.Columns("VOLUME").CellText(i)) Then
                        strVolume = Me.C1DBG.Columns("VOLUME").CellText(i)
                    Else
                        strVolume = strNull
                    End If
                    If IsNumeric(Me.C1DBG.Columns("ReeferTemp").CellText(i)) Then
                        strReefer = Me.C1DBG.Columns("ReeferTemp").CellText(i)
                    Else
                        strReefer = strNull
                    End If
                    Dim strTop, strFront, strBack, strLeft, strRight As String
                    strTop = IIf(IsNumeric(Me.C1DBG.Columns("OVER_HEIGHT").CellText(i)), Me.C1DBG.Columns("OVER_HEIGHT").CellText(i), strNull)
                    strFront = IIf(IsNumeric(Me.C1DBG.Columns("OVER_FRONT").CellText(i)), Me.C1DBG.Columns("OVER_FRONT").CellText(i), strNull)
                    strBack = IIf(IsNumeric(Me.C1DBG.Columns("OVER_BACK").CellText(i)), Me.C1DBG.Columns("OVER_BACK").CellText(i), strNull)
                    strLeft = IIf(IsNumeric(Me.C1DBG.Columns("OVER_LEFT").CellText(i)), Me.C1DBG.Columns("OVER_LEFT").CellText(i), strNull)
                    strRight = IIf(IsNumeric(Me.C1DBG.Columns("OVER_RIGHT").CellText(i)), Me.C1DBG.Columns("OVER_RIGHT").CellText(i), strNull)
                    sqlAddCon = "INSERT INTO CON_HATCH_RECORD(SHIP_ID, CONTAINER_NO, SEALNO, SIZE_CON, CONTAINER_TYPE, FULLOREMPTY, AMOUNT, WEIGHT, VOLUME, CODE_KEEPER, KEEPER, ReeferTemp,TempUnit,DangerGrade,DangerMark, USER_NAME " & _
                                ", OVER_HEIGHT, OVER_FRONT, OVER_BACK, OVER_LEFT, OVER_RIGHT,SealType,SealPerson,SealMark) " & _
                                " VALUES ('" & Ship_ID & "', '" & Me.C1DBG.Columns("CONTAINER_NO").CellText(i) & "', '" & Me.C1DBG.Columns("NEWSEALNO").CellText(i) & "', " & strConSize & ", " & _
                                "'" & Me.C1DBG.Columns("CONTAINER_TYPE").CellText(i) & "', '" & strPinCode & "', " & strAmount & ", " & strWeight & ", " & _
                                "" & strVolume & ", '" & Me.C1DBG.Columns("CODE_SHIP_OWNER").CellText(i) & "', '" & Me.C1DBG.Columns("ShipOWNER_CHA").CellText(i) & "'," & strReefer & ",'" & Me.C1DBG.Columns("TempUnit").CellText(i) & "','" & Me.C1DBG.Columns("DangerGrade").CellText(i) & "','" & Me.C1DBG.Columns("DangerMark").CellText(i) & "', '" & G_User & _
                                "'," & strTop & "," & strFront & "," & strBack & "," & strLeft & "," & strRight & ",'" & Me.C1DBG.Columns("SealType").CellText(i) & "','" & Me.C1DBG.Columns("SealPerson").CellText(i) & "'," & IIf(Me.C1DBG.Columns("SealType").CellText(i).Trim() = "", 0, 1) & ")"
                    ExecSql(sqlAddCon)
                Else
                    MessageBox.Show("该船次集装箱号 " & Me.C1DBG.Columns("CONTAINER_NO").CellText(i) & " 已存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Next
            '改变状态为出口放行,填写 SHIP_ID ,以供后用，提单号同步修改，保持数据一致
            Dim sqlAlterStateB, sqlAlterStateC As String
            If BillMark = False Then
                sqlAlterStateC = "update CON_LOAD_TALLY_LIST set StateC='3' where CHI_VESSEL ='" & Me.txtShip.Text & "' and Voyage = '" & Me.txtVoyage.Text & "' and BLNO = '" & Me.strBillNoOg & "' and CodeYard = '" & Me.cbPlace.SelectedValue & "'"
                sqlAlterStateB = "update CON_LOAD_TALLY set SHIP_ID='" & Ship_ID & "', StateB='3' where Con_Load_Tally_ID =" & ID & ""
            Else    '改变了提单号
                sqlAlterStateC = "update CON_LOAD_TALLY_LIST set StateC='3', BLNO = '" & Me.txtBillNO.Text & "' where CHI_VESSEL ='" & Me.txtShip.Text & "' and Voyage = '" & Me.txtVoyage.Text & "' and BLNO = '" & Me.strBillNoOg & "' and CodeYard = '" & Me.cbPlace.SelectedValue & "'"
                sqlAlterStateB = "update CON_LOAD_TALLY set SHIP_ID='" & Ship_ID & "', BLNO = '" & Me.txtBillNO.Text & "', StateB='3' where Con_Load_Tally_ID =" & ID & ""
            End If
            'sqlAlterStateC = "update CON_LOAD_TALLY_LIST set StateC='3' where CHI_VESSEL ='" & Me.txtShip.Text & "' and Voyage = '" & Me.txtVoyage.Text & "' and BLNO = '" & Me.strBillNoOg & "'"
            'sqlAlterStateB = "update CON_LOAD_TALLY set SHIP_ID='" & Ship_ID & "', StateB='3' where Con_Load_Tally_ID =" & ID & ""
            ExecSql(sqlAlterStateC)
            ExecSql(sqlAlterStateB)
            passMark = True
            revertMark = False
            backMark = True
            MessageBox.Show("放行成功", "提示")
            Me.btSave.Visible = False
            Me.btnRevert.Visible = False
            Me.btnBack.Visible = False
            Me.txtFindBill.Focus()
            'Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Ship_ID = 0
        End Try
    End Sub

    Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        If Me.C1DBG.Columns("Checked").CellValue(e.Row) = "1" Then
            e.CellStyle.BackColor = System.Drawing.Color.Cyan
        End If
        If Me.C1DBG.Columns("StateC").CellValue(e.Row) = "3" Then
            e.CellStyle.BackColor = System.Drawing.Color.Wheat
        End If
    End Sub

    Private Sub btnCreateMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateMessage.Click
        If Trim(Me.cbLoadPort.Text) = "" Or Me.cbLoadPort.Text Is Nothing Then
            Me.cbLoadPort.Focus()
            MessageBox.Show("装货港不可为空", "提示")
            Exit Sub
        End If
        If Trim(Me.cbUnloadPort.Text) = "" Or Me.cbUnloadPort.Text Is Nothing Then
            Me.cbUnloadPort.Focus()
            MessageBox.Show("卸货港不可为空", "提示")
            Exit Sub
        End If
        If Trim(Me.cbDelivery.Text) = "" Or Me.cbDelivery.Text Is Nothing Then
            Me.cbDelivery.Focus()
            MessageBox.Show("交货地不可为空", "提示")
            Exit Sub
        End If
        If Trim(Me.txtMark.Text) = "" Then
            Me.txtMark.Focus()
            MessageBox.Show("标识不可为空", "提示")
            Exit Sub
        End If
        If Trim(Me.txtGoodsEng.Text) = "" Then
            Me.txtGoodsEng.Focus()
            MessageBox.Show("英文货名不可为空", "提示")
            Exit Sub
        End If
        If Trim(Me.txtDangerGrade.Text) <> "" Then
            If Trim(Me.txtDangerMark.Text) = "" Then
                Me.txtDangerMark.Focus()
                MessageBox.Show("是危险品时，危险品标签不可为空", "提示")
                Exit Sub
            End If
            If Trim(Me.txtDangerPageNo.Text) = "" Then
                Me.txtDangerPageNo.Focus()
                MessageBox.Show("是危险品时，危险品页号不可为空", "提示")
                Exit Sub
            End If
            If Trim(Me.txtDangerCodeNO.Text) = "" Then
                Me.txtDangerCodeNO.Focus()
                MessageBox.Show("是危险品时，危险品编号不可为空", "提示")
                Exit Sub
            End If
        End If
        
        If Not IsNumeric(Me.txtAmount.Text) Then
            Me.txtAmount.Focus()
            MessageBox.Show("总件数应为非零数字", "提示")
            Exit Sub
        End If
        If Not IsNumeric(Me.txtTotalNetWeight.Text) Then
            Me.txtTotalNetWeight.Focus()
            MessageBox.Show("毛重应为非零数字", "提示")
            Exit Sub
        End If
        If Not IsNumeric(Me.txtNetWeight.Text) Then
            Me.txtNetWeight.Focus()
            MessageBox.Show("净重应为非零数字", "提示")
            Exit Sub
        End If
        If Not IsNumeric(Me.txtSize.Text) Then
            Me.txtSize.Focus()
            MessageBox.Show("总尺码应为非零数字", "提示")
            Exit Sub
        End If
        If Me.txtReeferTemp.Text.Trim.Length > 0 Then
            If Not IsNumeric(Me.txtReeferTemp.Text) Then
                Me.txtReeferTemp.Focus()
                MessageBox.Show("冷冻温度应为非零数字", "提示")
                Exit Sub
            End If
        End If

        If Me.cbPack.Text.Trim = "" Then
            Me.cbPack.Focus()
            MessageBox.Show("包装必要", "提示")
            Exit Sub
        End If

        Dim i As Integer
        For i = 0 To dvSubTable.Count - 1
            If Not Me.C1DBG.Columns("SIZE_CON").Text Like "##" Then
                Me.C1DBG.Row = i
                MessageBox.Show("箱尺寸应为非零两位数字", "提示")
                Exit Sub
            End If
            Me.C1DBG.Columns("CONTAINER_TYPE").Text = Me.C1DBG.Columns("CONTAINER_TYPE").Text.Trim.ToUpper
            If Not Me.C1DBG.Columns("CONTAINER_TYPE").Text Like "[A-Z][A-Z]" Then
                Me.C1DBG.Row = i
                MessageBox.Show("箱型应为两位字母", "提示")
                Exit Sub
            End If
            If Not IsNumeric(Me.C1DBG.Columns("AMOUNT").Text) Then
                Me.C1DBG.Row = i
                MessageBox.Show("箱件数应为非零数字", "提示")
                Exit Sub
            End If
            If Not IsNumeric(Me.C1DBG.Columns("NetWeight").Text) Then
                Me.C1DBG.Row = i
                MessageBox.Show("箱货重应为非零数字", "提示")
                Exit Sub
            End If
            If Not IsNumeric(Me.C1DBG.Columns("VOLUME").Text) Then
                Me.C1DBG.Row = i
                MessageBox.Show("箱内体积应为非零数字", "提示")
                Exit Sub
            End If
            If Me.C1DBG.Columns("CODE_SHIP_OWNER").Text.Trim = "" Then
                Me.C1DBG.Row = i
                MessageBox.Show("必要箱经营人码", "提示")
                Exit Sub
            End If
            If Me.C1DBG.Columns("ShipOWNER_CHA").Text.Trim = "" Then
                Me.C1DBG.Row = i
                MessageBox.Show("必要箱经营人", "提示")
                Exit Sub
            End If
        Next

    End Sub

    Private Sub cbLoadPort_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbLoadPort.Leave
        Try
            If Me.cbLoadPort.SelectedValue Is Nothing Then
                Dim i As Integer
                For i = 0 To dvLoadPort.Count - 1
                    If dvLoadPort(i)("CODE_PORT") Like "*" & Me.cbLoadPort.Text.ToUpper.Trim() & "*" Then
                        Me.cbLoadPort.SelectedValue = dvLoadPort(i)("CODE_PORT")
                        Exit For
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbUnloadPort_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbUnloadPort.Leave
        Try
            If Me.cbUnloadPort.SelectedValue Is Nothing Then
                Dim i As Integer
                For i = 0 To dvUnloadPort.Count - 1
                    If dvUnloadPort(i)("CODE_PORT") Like "*" & Me.cbUnloadPort.Text.ToUpper.Trim() & "*" Then
                        Me.cbUnloadPort.SelectedValue = dvUnloadPort(i)("CODE_PORT")
                        Exit For
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbDelivery_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDelivery.Leave
        Try
            If Me.cbDelivery.SelectedValue Is Nothing Then
                Dim i As Integer
                For i = 0 To dvDelivery.Count - 1
                    If dvDelivery(i)("CODE_PORT") Like "*" & Me.cbDelivery.Text.Trim.ToUpper & "*" Then
                        Me.cbDelivery.SelectedValue = dvDelivery(i)("CODE_PORT")
                        Exit For
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub FrmConLoadFinalCheck_Deal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtBillNO.Focused Then
                Me.cbLoadPort.Focus()
            ElseIf Me.cbLoadPort.Focused Then
                Me.cbUnloadPort.Focus()
            ElseIf Me.cbUnloadPort.Focused Then
                Me.cbDelivery.Focus()
            ElseIf Me.cbDelivery.Focused Then
                Me.cbPack.Focus()
            ElseIf Me.cbPack.Focused Then
                Me.txtGoodsEng.Focus()
            ElseIf Me.txtGoodsEng.Focused Then
                Me.txtAmount.Focus()
            ElseIf Me.txtAmount.Focused Then
                Me.txtTotalNetWeight.Focus()
            ElseIf Me.txtTotalNetWeight.Focused Then
                Me.txtNetWeight.Focus()
            ElseIf Me.txtNetWeight.Focused Then
                Me.txtSize.Focus()
            ElseIf Me.txtSize.Focused Then
                Me.txtReeferTemp.Focus()
            ElseIf Me.txtReeferTemp.Focused Then
                '    Me.cbTempUnit.Focus()
                'ElseIf Me.cbTempUnit.Focused Then
                Me.txtDangerGrade.Focus()
            ElseIf Me.txtDangerGrade.Focused Then
                Me.btSave.Focus()
            End If
        ElseIf e.KeyCode = Keys.Left Then
            If Me.cbLoadPort.Focused Then
                Me.txtBillNO.Focus()
            ElseIf Me.cbUnloadPort.Focused Then
                Me.cbLoadPort.Focus()
            ElseIf Me.cbDelivery.Focused Then
                Me.cbUnloadPort.Focus()
            ElseIf Me.cbPack.Focused Then
                Me.cbDelivery.Focus()
            ElseIf Me.txtGoodsEng.Focused Then
                Me.cbPack.Focus()
            ElseIf Me.txtAmount.Focused Then
                Me.txtGoodsEng.Focus()
            ElseIf Me.txtTotalNetWeight.Focused Then
                Me.txtAmount.Focus()
            ElseIf Me.txtNetWeight.Focused Then
                Me.txtTotalNetWeight.Focus()
            ElseIf Me.txtSize.Focused Then
                Me.txtNetWeight.Focus()
            ElseIf Me.txtReeferTemp.Focused Then
                Me.txtSize.Focus()
            ElseIf Me.txtDangerGrade.Focused Then
                Me.txtReeferTemp.Focus()
            ElseIf Me.btSave.Focused Then
                Me.txtDangerGrade.Focus()
            End If
        End If
        'Me.cbConLoadType.Focus()
        '    ElseIf Me.cbConLoadType.Focused Then
        'Me.dtpTimeBegin.Focus()
        '    ElseIf Me.dtpTimeBegin.Focused Then
        'Me.txtMark.Focus()
        '    ElseIf Me.txtMark.Focused Then
        'Me.txtGoodsName.Focus()
        '    ElseIf Me.txtGoodsName.Focused Then
        'Me.txtShiper.Focus()
        '    ElseIf Me.txtShiper.Focused Then
        'Me.txtReceiver.Focus()
        '    ElseIf Me.txtReceiver.Focused Then
        'Me.txtNotify.Focus()
        '    ElseIf Me.txtNotify.Focused Then
        'Me.txtDangerMark.Focus()
        '    ElseIf Me.txtDangerMark.Focused Then
        'Me.txtDangerCodeNO.Focus()
        '    ElseIf Me.txtDangerCodeNO.Focused Then
        'Me.txtDangerPageNo.Focus()
        '    ElseIf Me.txtDangerPageNo.Focused Then
    End Sub

    Private Function TrimReturn(ByVal str As String)  ' 去除回车换行符
        Dim i As Integer
        Dim ch As Char

        i = 0
        While i < str.Length - 1
            ch = str.Substring(i, 1)
            If ch.Equals(Chr(13)) Then
                str = String.Concat(str.Substring(0, i), str.Substring(i + 2))
            Else
                i += 1
            End If
        End While
        Return str
    End Function

    Private Sub txtBillNO_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBillNO.Leave
        txtBillNO.Text = txtBillNO.Text.Trim.ToUpper
        If txtBillNO.Text <> strBillNoOg Then
            BillMark = True
        Else
            BillMark = False
        End If
        'Dim i As Integer
        'Me.C1DBG.Focus()
        'For i = 0 To dsContainer.Tables(0).Rows.Count - 1
        '    Me.C1DBG.Row = i
        '    Me.C1DBG.Columns("BLNO").Text = Me.txtBillNO.Text
        'Next
        'Me.btQuit.Focus()
        'Me.cbLoadPort.Focus()
    End Sub

    Private Sub txtReeferTemp_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtReeferTemp.Leave
        If IsNumeric(txtReeferTemp.Text) Then
            Me.cbTempUnit.SelectedIndex = 1
        Else
            Me.cbTempUnit.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnRevert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRevert.Click
        If MessageBox.Show("确实要还原么？", "确定", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            Dim sqlAlterStateB, sqlAlterStateC As String
            sqlAlterStateC = "update CON_LOAD_TALLY_LIST set StateC='2' where CHI_VESSEL ='" & Me.txtShip.Text & "' and Voyage = '" & Me.txtVoyage.Text & "' and BLNO = '" & Me.strBillNoOg & "' and CodeYard = '" & Me.cbPlace.SelectedValue & "'"
            sqlAlterStateB = "update CON_LOAD_TALLY set StateB='2' where Con_Load_Tally_ID =" & ID & ""
            ExecSql(sqlAlterStateC)
            ExecSql(sqlAlterStateB)
            '当状态是完成时，要删除
            If ds.Tables(0).Rows(0)("StateB") = "3" Then
                '删除已在舱单中生成的数据 用原来导过的Ship_ID
                Call DelConHatchBill()
            End If
            passMark = False
            revertMark = True
            backMark = False
            MessageBox.Show("还原成功", "提示")
            Me.btSave.Visible = False
            Me.btnRevert.Visible = False
            Me.btnBack.Visible = False
            Me.txtFindBill.Focus()
            'Me.Close()
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        If MessageBox.Show("确实要退关么？", "确定", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            Dim sqlAlterStateB, sqlAlterStateC As String
            sqlAlterStateC = "update CON_LOAD_TALLY_LIST set StateC='4' where CHI_VESSEL ='" & Me.txtShip.Text & "' and Voyage = '" & Me.txtVoyage.Text & "' and BLNO = '" & Me.strBillNoOg & "' and CodeYard = '" & Me.cbPlace.SelectedValue & "'"
            sqlAlterStateB = "update CON_LOAD_TALLY set StateB='4' where Con_Load_Tally_ID =" & ID & ""
            ExecSql(sqlAlterStateC)
            ExecSql(sqlAlterStateB)
            '删除已在舱单中生成的数据 用原来导过的Ship_ID
            Call DelConHatchBill()
            passMark = False
            revertMark = False
            backMark = True
            MessageBox.Show("退关成功", "提示")
            Me.btSave.Visible = False
            Me.btnRevert.Visible = False
            Me.btnBack.Visible = False
            Me.txtFindBill.Focus()
            'Me.Close()
        End If
    End Sub
    Private Sub DelConHatchBill()
        Dim sqlDelCont As String
        Dim sqlDelBill As String
        '要改不属于的 
        sqlDelCont = "delete from CON_HATCH_RECORD where  ship_id = '" & strOldShip & "' and " & _
        " container_no in (select container_no from con_hatch_cargo where  SHIP_ID =  '" & strOldShip & "' AND BLNO = '" & Me.txtBillNO.Text & "')" & _
        " and container_no not in (select container_no from con_hatch_cargo where  SHIP_ID =  '" & strOldShip & "' AND not (BLNO = '" & Me.txtBillNO.Text & "'))"
        '找出所有该船次提单唛头下的箱号（不包括与其它提单唛头共享的拼箱号）删除
        ExecSql(sqlDelCont)
        sqlDelBill = "delete from CON_HATCH_LIST where ship_id = '" & strOldShip & "' and BlNo ='" & Me.txtBillNO.Text & "'"
        ExecSql(sqlDelBill)
        '关系信息用触发器删除
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Me.txtFindShip.Text = Me.txtFindShip.Text.Trim.ToUpper
        Me.txtFindVoyage.Text = Me.txtFindVoyage.Text.Trim.ToUpper
        Me.txtFindBill.Text = Me.txtFindBill.Text.Trim.ToUpper
        Me.txtFindNo.Text = Me.txtFindNo.Text.Trim.ToUpper
        Me.txtContainerNo.Text = Me.txtContainerNo.Text.Trim.ToUpper

        If Me.txtFindShip.Text = "" And Me.txtFindVoyage.Text = "" And Me.txtFindBill.Text = "" And Me.txtFindNo.Text = "" And Me.txtContainerNo.Text = "" Then
            Me.txtFindBill.Focus()
            MessageBox.Show("请输入查找内容！", "提示")
            Exit Sub
        End If

        On Error Resume Next

        Dim sqlBillInfo As String
        Dim sqlFind As String
        Dim dvFind As New DataView
        sqlFind = "select * from View_ConLoadTally where chi_vessel like '%" & Me.txtFindShip.Text & "%' and voyage like '%" & Me.txtFindVoyage.Text & "%' and blno like '%" & Me.txtFindBill.Text & "%' and NO like '%" & Me.txtFindNo.Text & "%' and Container_No like '%" & Me.txtContainerNo.Text & "%'  and InOutPort = '1' Order by ID DESC "
        dvFind = Filldata(sqlFind)
        If dvFind.Count > 0 Then
            ID = dvFind(0)("ID")
            sqlBillInfo = "select * from Con_Load_Tally where Con_Load_Tally_ID =" & ID & " and StateB in ('1','2','3','4') "
            dw = Updatedata(sqlda, sqlBillInfo, ds)

            If dw.Count > 0 Then
                cbPlace.SelectedValue = ds.Tables(0).Rows(0).Item("WORK_PLACE")
                txtNO.Text = ds.Tables(0).Rows(0).Item("NO")
                txtID.Text = ds.Tables(0).Rows(0).Item("Con_Load_Tally_ID")

                txtShip.Text = ds.Tables(0).Rows(0).Item("CHI_VESSEL")
                txtVoyage.Text = ds.Tables(0).Rows(0).Item("VOYAGE")
                Me.cbInOutPort.SelectedValue = ds.Tables(0).Rows(0)("InOutPort")
                '写两遍，不是废话。当值不存在时，使SelectedValue为空
                Me.cbLoadPort.SelectedValue = ds.Tables(0).Rows(0)("CodeLoadPort")
                If Me.cbLoadPort.SelectedIndex = 0 Then
                    Me.cbLoadPort.SelectedValue = ds.Tables(0).Rows(0)("CodeLoadPort")
                End If
                dtpTimeBegin.Value = ds.Tables(0).Rows(0).Item("TIME_FROM")
                txtBillNO.Text = ds.Tables(0).Rows(0).Item("BLNO")
                cbConsign.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_CON_CONSIGN")

                cbUnloadPort.SelectedValue = "00"
                Me.cbDelivery.SelectedValue = "00"
                cbConLoadType.SelectedValue = "0"
                txtMark.Clear()
                txtGoodsName.Clear()
                txtAmount.Clear()
                txtTotalNetWeight.Clear()
                txtNetWeight.Clear()
                txtSize.Clear()
                txtReeferTemp.Clear()
                cbTempUnit.Text = ""
                txtDangerGrade.Clear()
                txtDangerMark.Clear()
                txtDangerPageNo.Clear()
                Me.txtDangerCodeNO.Clear()
                Me.cbDescribe.Text = ""
                Me.cbState.Text = ""
                Me.txtShiper.Clear()
                Me.txtReceiver.Clear()
                Me.txtNotify.Clear()
                Me.txtTallyClerk.Clear()
                'Me.cbPack.SelectedValue = "000"
                Me.txtGoodsEng.Clear()

                Me.cbUnloadPort.SelectedValue = ds.Tables(0).Rows(0)("CodeUnloadPort")
                Me.cbDelivery.SelectedValue = ds.Tables(0).Rows(0)("CodeDelivery")
                cbConLoadType.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_TALLY_TYPE")

                txtMark.Text = ds.Tables(0).Rows(0).Item("MARK")
                Me.txtGoodsName.Text = ds.Tables(0).Rows(0).Item("GoodsCha")
                strGoodsName = ds.Tables(0).Rows(0).Item("GoodsCha")
                txtAmount.Text = ds.Tables(0).Rows(0).Item("AMOUNT")
                'txtTotalWeight.Text = ds.Tables(0).Rows(0).Item("TOTAL_WEIGHT")
                txtTotalNetWeight.Text = ds.Tables(0).Rows(0)("TOTALNetWEIGHT")
                txtSize.Text = ds.Tables(0).Rows(0).Item("SIZE_MEASURE")
                Me.txtReeferTemp.Text = ds.Tables(0).Rows(0)("ReeferTemp")
                Me.cbTempUnit.Text = ds.Tables(0).Rows(0)("TempUnit")
                Me.txtDangerGrade.Text = ds.Tables(0).Rows(0)("DangerGrade")
                Me.txtDangerMark.Text = ds.Tables(0).Rows(0)("DangerMark")

                cbDescribe.Text = ds.Tables(0).Rows(0).Item("DESCR")
                cbState.Text = ds.Tables(0).Rows(0).Item("STATE")
                Me.txtShiper.Text = ds.Tables(0).Rows(0)("Shipper")
                txtReceiver.Text = ds.Tables(0).Rows(0).Item("RECEIVER")
                Me.txtNotify.Text = ds.Tables(0).Rows(0)("Notify")
                txtTallyClerk.Text = ds.Tables(0).Rows(0).Item("TALLY_CLERK")

                strShipOg = txtShip.Text
                strVoyageOg = txtVoyage.Text
                strBillNoOg = txtBillNO.Text

                strShipCode = Me.txtShip.Text.Trim.ToUpper
                sqlShipCode = "SELECT SPCODE, CHI_VESSEL,ENG_VESSEL FROM Code_SHIPNAME WHERE SPCODE = '" & strShipCode & "'"
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

                sqlSubTable = "SELECT A.CONTAINER_NO,A.SIZE_CON,A.CONTAINER_TYPE,A.NEWSEALNO,SealType,SealPerson,A.PACK_CHA,A.AMOUNT,A.WEIGHT,A.NetWeight,A.VOLUME,A.DAMAGED_AMOUNT,A.DAMAGED_PACK,A.SecSealNO,A.ReasonOpenSeal,A.CodeYard,A.ReeferTemp,A.TempUnit,A.DangerGrade,A.DangerMark,A.Checked,A.StateC,A.FullOrEmpty " & _
                    ", CON_CRITERION.CODE_SHIP_OWNER, CODE_SHIP_OWNER.ShipOWNER_CHA, A.OVER_HEIGHT,A.OVER_FRONT,A.OVER_BACK,A.OVER_LEFT,A.OVER_RIGHT " & _
                    " FROM CODE_SHIP_OWNER RIGHT OUTER JOIN CON_CRITERION ON CODE_SHIP_OWNER.CODE_SHIPOWNER = CON_CRITERION.CODE_SHIP_OWNER RIGHT OUTER JOIN CON_LOAD_TALLY_LIST  A ON CON_CRITERION.CONTAINER_NO = A.CONTAINER_NO " & _
                    " where  CHI_VESSEL ='" & Me.txtShip.Text & "' and Voyage = '" & Me.txtVoyage.Text & "' and blno= '" & Me.txtBillNO.Text & "' and CodeYard= '" & Me.cbPlace.SelectedValue & "'"
                InitSubTable()     '初始化子表c1grid

                '得到将要导出入的船次
                sqlResultShip = "SELECT SHIP_ID, V_ID, Vessel_Code, SSHIP.CHI_VESSEL, SSHIP.ENG_VESSEL, VOYAGE, INOUTPORT FROM SSHIP INNER JOIN VESSEL ON V_ID = VESSEL_ID " & _
                                " where Vessel_Code='" & Me.txtShip.Text & "' and voyage='" & Me.txtVoyage.Text & "' "
                dvResultShip = Filldata(sqlResultShip)
                If dvResultShip.Count = 1 Then
                    If Not IsDBNull(dvResultShip(0)("CHI_VESSEL")) Then
                        Me.lbResultShip.Text = dvResultShip(0)("CHI_VESSEL")
                    End If
                    If Not IsDBNull(dvResultShip(0)("VOYAGE")) Then
                        Me.lbResultShip.Text = Me.lbResultShip.Text & " " & dvResultShip(0)("VOYAGE")
                    End If
                    Ship_ID = dvResultShip(0)("SHIP_ID")
                Else
                    Me.lbResultShip.Text = "无"
                    Ship_ID = 0
                End If

                '找出原先导入的船次
                If IsDBNull(ds.Tables(0).Rows(0)("SHIP_ID")) Then
                    strOldShip = "0"
                Else
                    strOldShip = ds.Tables(0).Rows(0)("SHIP_ID")
                End If
                Dim sqlOldShip As String
                sqlOldShip = "SELECT ENG_VESSEL, CHI_VESSEL, VOYAGE FROM SSHIP WHERE (SHIP_ID = '" & strOldShip & "')"
                Dim dvOldShip As New DataView
                dvOldShip = Filldata(sqlOldShip)
                If dvOldShip.Count = 1 Then
                    If Not IsDBNull(dvOldShip(0)("CHI_VESSEL")) Then
                        Me.lbOldShip.Text = dvOldShip(0)("CHI_VESSEL")
                    End If
                    If Not IsDBNull(dvOldShip(0)("VOYAGE")) Then
                        Me.lbOldShip.Text = Me.lbOldShip.Text & " " & dvOldShip(0)("VOYAGE")
                    End If
                End If

                'If ds.Tables(0).Rows(0).Item("StateB") = "1" Then
                '    MessageBox.Show("该理货单尚未出证，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'End If

                If txtBillNO.Text Like "*[#][#]" Then
                    txtBillNO.Text = Mid(txtBillNO.Text, 1, txtBillNO.Text.Length - 2)
                End If

                If Me.cbLoadPort.SelectedValue Is Nothing Then
                    Me.cbLoadPort.SelectedValue = "CNLYG"
                    If Me.cbLoadPort.SelectedValue Is Nothing Then
                        Me.cbLoadPort.SelectedValue = "LYG"
                        If Me.cbLoadPort.SelectedValue Is Nothing Then
                            Me.cbLoadPort.SelectedIndex = 0
                        End If
                    End If
                End If

                If FrmConLoadFinalNew.strOperateMark <> "0" Then
                    '查看界面不管，别的要据提单状态确定做何操作
                    Select Case ds.Tables(0).Rows(0).Item("StateB")
                        Case "1"    '当前区 暂时
                            Me.btSave.Visible = True
                            Me.btnRevert.Visible = False
                            Me.btnBack.Visible = False
                            Me.btSave.Text = "放行(&S)"
                            MessageBox.Show("该理货单尚未出证，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Case "2"    '当前区
                            Me.btSave.Visible = True
                            Me.btnRevert.Visible = False
                            Me.btnBack.Visible = False
                            Me.btSave.Text = "放行(&S)"
                        Case "3"    '完成区
                            Me.btSave.Visible = False
                            Me.btnRevert.Visible = True
                            Me.btnBack.Visible = True
                            Me.btnBack.Text = "退关"
                            Me.btnRevert.Text = "还原"
                            Me.btnBack.Location = Me.btSave.Location
                            Me.txtBillNO.ReadOnly = True
                        Case "4"    '退关区
                            Me.btSave.Visible = True
                            Me.btnRevert.Visible = True
                            Me.btnBack.Visible = False
                            Me.btSave.Text = "放行(&S)"
                            Me.btnRevert.Text = "还原"
                            Me.txtBillNO.ReadOnly = True
                    End Select
                End If
                'ElseIf dw.Count = 0 Then
                '    MessageBox.Show("找不到该理货单", "提示")
                'ElseIf dw.Count > 1 Then
                '    MessageBox.Show("找到不止一份理货单，无法处理", "提示")
            End If
            Me.txtFindShip.Clear()
            Me.txtFindVoyage.Clear()
            Me.txtFindBill.Clear()
            Me.txtFindNo.Clear()
            Me.txtContainerNo.Clear()
            Me.cbUnloadPort.Focus()
        Else
            MessageBox.Show("找不到该理货单", "提示")
        End If
    End Sub

    Private Sub txtFindShip_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFindShip.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtFindVoyage.Focus()
        End If
    End Sub

    Private Sub txtFindVoyage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFindVoyage.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtFindBill.Focus()
        End If
    End Sub

    Private Sub txtFindBill_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFindBill.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtContainerNo.Focus()
        End If
    End Sub

    Private Sub txtFindNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFindNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtContainerNo.Focus()
        End If
    End Sub

    Private Sub txtContainerNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContainerNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnFind.Focus()
        End If
    End Sub

    Private Sub bt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt1.Click
        Dim Frm As New FrmFindPort
        Frm.ShowDialog()
        cbUnloadPort.SelectedValue = PortCode
    End Sub

    Private Sub bt2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt2.Click
        Dim Frm As New FrmFindPort
        Frm.ShowDialog()
        cbDelivery.SelectedValue = PortCode
    End Sub

    Private Sub txtDangerGrade_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDangerGrade.Leave
        Me.txtDangerGrade.Text = Me.txtDangerGrade.Text.Trim.ToUpper
        If dvSubTable.Count > 0 Then
            Dim i As Integer
            For i = 0 To dvSubTable.Count - 1
                Me.C1DBG.Row = i
                If Me.C1DBG.Columns("DangerGrade").Text <> Me.txtDangerGrade.Text Then
                    Me.C1DBG.Columns("DangerGrade").Text = Me.txtDangerGrade.Text
                End If
            Next
            dvSubTable(i - 1)("DangerGrade") = Me.txtDangerGrade.Text
        End If
    End Sub

    Private Sub txtDangerMark_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDangerMark.Leave
        Me.txtDangerMark.Text = Me.txtDangerMark.Text.Trim.ToUpper
        If dvSubTable.Count > 0 Then
            Dim i As Integer
            For i = 0 To dvSubTable.Count - 1
                Me.C1DBG.Row = i
                If Me.C1DBG.Columns("DangerMark").Text <> Me.txtDangerMark.Text Then
                    Me.C1DBG.Columns("DangerMark").Text = Me.txtDangerMark.Text
                End If
            Next
            dvSubTable(i - 1)("DangerMark") = Me.txtDangerMark.Text
        End If
    End Sub
End Class
