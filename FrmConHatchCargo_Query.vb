Imports TALLY.DBControl
Public Class FrmConHatchCargo_Query
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim adContainer As New SqlClient.SqlDataAdapter()
    Dim dsContainer As New DataSet()

    Dim dvLoadPort As New DataView()
    Dim dvUnloadPort As New DataView()
    Dim dvReceivePlace As New DataView()
    Dim Mark1 As Boolean

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
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCONTAINER As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGROSS_WEIGHT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents txtBillNO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtGOODS_CHA As System.Windows.Forms.TextBox
    Friend WithEvents txtPRE_SHIPNAME As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPRE_SHIPCODE As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPRE_VOYAGE As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cbUnloadPort As System.Windows.Forms.ComboBox
    Friend WithEvents cbLoadPort As System.Windows.Forms.ComboBox
    Friend WithEvents cbReceivePlace As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents cbUnloadPortEng As System.Windows.Forms.ComboBox
    Friend WithEvents cbLoadPortEng As System.Windows.Forms.ComboBox
    Friend WithEvents cbReceivePlaceEng As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbCONTAINER_MARK As System.Windows.Forms.ComboBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents cbEMPTY_MARK As System.Windows.Forms.ComboBox
    Friend WithEvents txtMark As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtRECEIVER As System.Windows.Forms.TextBox
    Friend WithEvents dtpLoadDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtNOTIFY_PERSON As System.Windows.Forms.TextBox
    Friend WithEvents cbGoodsCode As System.Windows.Forms.ComboBox
    Friend WithEvents cbPack As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtNETWEIGHT As System.Windows.Forms.TextBox
    Friend WithEvents txtPIECE_WEIGHT As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDANGER_GRADE As System.Windows.Forms.TextBox
    Friend WithEvents cbTempUnit As System.Windows.Forms.ComboBox
    Friend WithEvents txtREFRIGERATE_TEMPERATURE As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtSIZE_MEASURE As System.Windows.Forms.TextBox
    Friend WithEvents txtDANGER_NO As System.Windows.Forms.TextBox
    Friend WithEvents txtDANGER_PAGENO As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtGOODS_ENG As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtDANGER_MARK As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConHatchCargo_Query))
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtCONTAINER = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtGROSS_WEIGHT = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btQuit = New System.Windows.Forms.Button
        Me.txtBillNO = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtGOODS_CHA = New System.Windows.Forms.TextBox
        Me.txtPRE_SHIPNAME = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtPRE_SHIPCODE = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtPRE_VOYAGE = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.cbUnloadPort = New System.Windows.Forms.ComboBox
        Me.cbLoadPort = New System.Windows.Forms.ComboBox
        Me.cbReceivePlace = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.cbUnloadPortEng = New System.Windows.Forms.ComboBox
        Me.cbLoadPortEng = New System.Windows.Forms.ComboBox
        Me.cbReceivePlaceEng = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.cbCONTAINER_MARK = New System.Windows.Forms.ComboBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.cbEMPTY_MARK = New System.Windows.Forms.ComboBox
        Me.txtMark = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtRECEIVER = New System.Windows.Forms.TextBox
        Me.dtpLoadDate = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.txtNOTIFY_PERSON = New System.Windows.Forms.TextBox
        Me.cbGoodsCode = New System.Windows.Forms.ComboBox
        Me.cbPack = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtNETWEIGHT = New System.Windows.Forms.TextBox
        Me.txtPIECE_WEIGHT = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtDANGER_GRADE = New System.Windows.Forms.TextBox
        Me.cbTempUnit = New System.Windows.Forms.ComboBox
        Me.txtREFRIGERATE_TEMPERATURE = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtSIZE_MEASURE = New System.Windows.Forms.TextBox
        Me.txtDANGER_NO = New System.Windows.Forms.TextBox
        Me.txtDANGER_PAGENO = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtGOODS_ENG = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtDANGER_MARK = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(500, 8)
        Me.txtAmount.MaxLength = 20
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(130, 21)
        Me.txtAmount.TabIndex = 426
        Me.txtAmount.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(426, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 454
        Me.Label10.Text = "总件数"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCONTAINER
        '
        Me.txtCONTAINER.Location = New System.Drawing.Point(500, 56)
        Me.txtCONTAINER.MaxLength = 20
        Me.txtCONTAINER.Name = "txtCONTAINER"
        Me.txtCONTAINER.Size = New System.Drawing.Size(130, 21)
        Me.txtCONTAINER.TabIndex = 427
        Me.txtCONTAINER.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(426, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 449
        Me.Label3.Text = "集装箱数"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGROSS_WEIGHT
        '
        Me.txtGROSS_WEIGHT.Location = New System.Drawing.Point(500, 32)
        Me.txtGROSS_WEIGHT.MaxLength = 20
        Me.txtGROSS_WEIGHT.Name = "txtGROSS_WEIGHT"
        Me.txtGROSS_WEIGHT.TabIndex = 431
        Me.txtGROSS_WEIGHT.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(426, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 444
        Me.Label1.Text = "毛重"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(284, 296)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 439
        Me.btQuit.Text = "返回"
        '
        'txtBillNO
        '
        Me.txtBillNO.Location = New System.Drawing.Point(78, 6)
        Me.txtBillNO.MaxLength = 20
        Me.txtBillNO.Name = "txtBillNO"
        Me.txtBillNO.Size = New System.Drawing.Size(130, 21)
        Me.txtBillNO.TabIndex = 406
        Me.txtBillNO.Text = ""
        '
        'Label4
        '
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(4, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 451
        Me.Label4.Text = "提单号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(0, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 442
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(2, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 469
        Me.Label7.Text = "货物描述"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGOODS_CHA
        '
        Me.txtGOODS_CHA.Location = New System.Drawing.Point(6, 50)
        Me.txtGOODS_CHA.MaxLength = 20
        Me.txtGOODS_CHA.Multiline = True
        Me.txtGOODS_CHA.Name = "txtGOODS_CHA"
        Me.txtGOODS_CHA.Size = New System.Drawing.Size(200, 48)
        Me.txtGOODS_CHA.TabIndex = 424
        Me.txtGOODS_CHA.Text = ""
        '
        'txtPRE_SHIPNAME
        '
        Me.txtPRE_SHIPNAME.Location = New System.Drawing.Point(106, 448)
        Me.txtPRE_SHIPNAME.MaxLength = 30
        Me.txtPRE_SHIPNAME.Name = "txtPRE_SHIPNAME"
        Me.txtPRE_SHIPNAME.Size = New System.Drawing.Size(130, 21)
        Me.txtPRE_SHIPNAME.TabIndex = 408
        Me.txtPRE_SHIPNAME.Text = ""
        Me.txtPRE_SHIPNAME.Visible = False
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(32, 450)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 18)
        Me.Label12.TabIndex = 462
        Me.Label12.Text = "前程船名"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label12.Visible = False
        '
        'txtPRE_SHIPCODE
        '
        Me.txtPRE_SHIPCODE.Location = New System.Drawing.Point(106, 424)
        Me.txtPRE_SHIPCODE.MaxLength = 10
        Me.txtPRE_SHIPCODE.Name = "txtPRE_SHIPCODE"
        Me.txtPRE_SHIPCODE.Size = New System.Drawing.Size(130, 21)
        Me.txtPRE_SHIPCODE.TabIndex = 407
        Me.txtPRE_SHIPCODE.Text = ""
        Me.txtPRE_SHIPCODE.Visible = False
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(32, 426)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 18)
        Me.Label13.TabIndex = 458
        Me.Label13.Text = "前程船名码"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label13.Visible = False
        '
        'txtPRE_VOYAGE
        '
        Me.txtPRE_VOYAGE.Location = New System.Drawing.Point(106, 472)
        Me.txtPRE_VOYAGE.MaxLength = 10
        Me.txtPRE_VOYAGE.Name = "txtPRE_VOYAGE"
        Me.txtPRE_VOYAGE.Size = New System.Drawing.Size(130, 21)
        Me.txtPRE_VOYAGE.TabIndex = 409
        Me.txtPRE_VOYAGE.Text = ""
        Me.txtPRE_VOYAGE.Visible = False
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(32, 474)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 18)
        Me.Label19.TabIndex = 446
        Me.Label19.Text = "前程航次"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label19.Visible = False
        '
        'C1DBG
        '
        Me.C1DBG.AllowAddNew = True
        Me.C1DBG.AllowDelete = True
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 104)
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
        Me.C1DBG.Size = New System.Drawing.Size(634, 186)
        Me.C1DBG.TabIndex = 440
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style14{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" & _
        "tyle1{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Back" & _
        "Color:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSele" & _
        "ctorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><ClientRect>0, 0, 630, 182</ClientRect><BorderSide>0</BorderSide><CaptionSt" & _
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
        "ClientArea>0, 0, 630, 182</ClientArea><PrintPageHeaderStyle parent="""" me=""Style1" & _
        "4"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'cbUnloadPort
        '
        Me.cbUnloadPort.Location = New System.Drawing.Point(290, 54)
        Me.cbUnloadPort.MaxDropDownItems = 20
        Me.cbUnloadPort.Name = "cbUnloadPort"
        Me.cbUnloadPort.Size = New System.Drawing.Size(130, 20)
        Me.cbUnloadPort.TabIndex = 487
        '
        'cbLoadPort
        '
        Me.cbLoadPort.Location = New System.Drawing.Point(290, 6)
        Me.cbLoadPort.MaxDropDownItems = 20
        Me.cbLoadPort.Name = "cbLoadPort"
        Me.cbLoadPort.Size = New System.Drawing.Size(130, 20)
        Me.cbLoadPort.TabIndex = 486
        '
        'cbReceivePlace
        '
        Me.cbReceivePlace.Location = New System.Drawing.Point(106, 496)
        Me.cbReceivePlace.MaxDropDownItems = 20
        Me.cbReceivePlace.Name = "cbReceivePlace"
        Me.cbReceivePlace.Size = New System.Drawing.Size(130, 20)
        Me.cbReceivePlace.TabIndex = 485
        Me.cbReceivePlace.Visible = False
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(32, 498)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 18)
        Me.Label20.TabIndex = 482
        Me.Label20.Text = "收货地"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label20.Visible = False
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(216, 8)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 18)
        Me.Label24.TabIndex = 483
        Me.Label24.Text = "装货港"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(216, 56)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(72, 18)
        Me.Label32.TabIndex = 480
        Me.Label32.Text = "卸货港"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(600, 34)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(30, 20)
        Me.Label35.TabIndex = 491
        Me.Label35.Text = "公斤"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbUnloadPortEng
        '
        Me.cbUnloadPortEng.Location = New System.Drawing.Point(290, 78)
        Me.cbUnloadPortEng.MaxDropDownItems = 20
        Me.cbUnloadPortEng.Name = "cbUnloadPortEng"
        Me.cbUnloadPortEng.Size = New System.Drawing.Size(130, 20)
        Me.cbUnloadPortEng.TabIndex = 499
        '
        'cbLoadPortEng
        '
        Me.cbLoadPortEng.Location = New System.Drawing.Point(290, 30)
        Me.cbLoadPortEng.MaxDropDownItems = 20
        Me.cbLoadPortEng.Name = "cbLoadPortEng"
        Me.cbLoadPortEng.Size = New System.Drawing.Size(130, 20)
        Me.cbLoadPortEng.TabIndex = 498
        '
        'cbReceivePlaceEng
        '
        Me.cbReceivePlaceEng.Location = New System.Drawing.Point(106, 520)
        Me.cbReceivePlaceEng.MaxDropDownItems = 20
        Me.cbReceivePlaceEng.Name = "cbReceivePlaceEng"
        Me.cbReceivePlaceEng.Size = New System.Drawing.Size(130, 20)
        Me.cbReceivePlaceEng.TabIndex = 497
        Me.cbReceivePlaceEng.Visible = False
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(32, 522)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 18)
        Me.Label21.TabIndex = 495
        Me.Label21.Text = "收货地英文"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label21.Visible = False
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(216, 80)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 18)
        Me.Label22.TabIndex = 496
        Me.Label22.Text = "卸货港英文"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(216, 32)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 18)
        Me.Label23.TabIndex = 494
        Me.Label23.Text = "装货港英文"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(220, 332)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 452
        Me.Label6.Text = "整拼箱标记"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label6.Visible = False
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(220, 356)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 18)
        Me.Label14.TabIndex = 463
        Me.Label14.Text = "装货日期"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label14.Visible = False
        '
        'cbCONTAINER_MARK
        '
        Me.cbCONTAINER_MARK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCONTAINER_MARK.ItemHeight = 12
        Me.cbCONTAINER_MARK.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbCONTAINER_MARK.Location = New System.Drawing.Point(294, 330)
        Me.cbCONTAINER_MARK.Name = "cbCONTAINER_MARK"
        Me.cbCONTAINER_MARK.Size = New System.Drawing.Size(130, 20)
        Me.cbCONTAINER_MARK.TabIndex = 418
        Me.cbCONTAINER_MARK.Visible = False
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(220, 404)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(72, 18)
        Me.Label28.TabIndex = 455
        Me.Label28.Text = "通知方"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label28.Visible = False
        '
        'cbEMPTY_MARK
        '
        Me.cbEMPTY_MARK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEMPTY_MARK.ItemHeight = 12
        Me.cbEMPTY_MARK.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbEMPTY_MARK.Location = New System.Drawing.Point(294, 306)
        Me.cbEMPTY_MARK.Name = "cbEMPTY_MARK"
        Me.cbEMPTY_MARK.Size = New System.Drawing.Size(130, 20)
        Me.cbEMPTY_MARK.TabIndex = 417
        Me.cbEMPTY_MARK.Visible = False
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(294, 426)
        Me.txtMark.MaxLength = 35
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(130, 21)
        Me.txtMark.TabIndex = 422
        Me.txtMark.Text = ""
        Me.txtMark.Visible = False
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(220, 308)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 18)
        Me.Label18.TabIndex = 473
        Me.Label18.Text = "空箱单标识"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label18.Visible = False
        '
        'txtRECEIVER
        '
        Me.txtRECEIVER.Location = New System.Drawing.Point(294, 378)
        Me.txtRECEIVER.MaxLength = 30
        Me.txtRECEIVER.Name = "txtRECEIVER"
        Me.txtRECEIVER.Size = New System.Drawing.Size(130, 21)
        Me.txtRECEIVER.TabIndex = 420
        Me.txtRECEIVER.Text = ""
        Me.txtRECEIVER.Visible = False
        '
        'dtpLoadDate
        '
        Me.dtpLoadDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLoadDate.Location = New System.Drawing.Point(294, 354)
        Me.dtpLoadDate.Name = "dtpLoadDate"
        Me.dtpLoadDate.Size = New System.Drawing.Size(130, 21)
        Me.dtpLoadDate.TabIndex = 419
        Me.dtpLoadDate.Value = New Date(2004, 7, 17, 15, 37, 55, 144)
        Me.dtpLoadDate.Visible = False
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(220, 428)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 453
        Me.Label9.Text = "标志"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Visible = False
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(220, 452)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 18)
        Me.Label17.TabIndex = 472
        Me.Label17.Text = "货名代码"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label17.Visible = False
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(220, 380)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(72, 18)
        Me.Label33.TabIndex = 445
        Me.Label33.Text = "受货人"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label33.Visible = False
        '
        'txtNOTIFY_PERSON
        '
        Me.txtNOTIFY_PERSON.Location = New System.Drawing.Point(294, 402)
        Me.txtNOTIFY_PERSON.MaxLength = 30
        Me.txtNOTIFY_PERSON.Name = "txtNOTIFY_PERSON"
        Me.txtNOTIFY_PERSON.Size = New System.Drawing.Size(130, 21)
        Me.txtNOTIFY_PERSON.TabIndex = 421
        Me.txtNOTIFY_PERSON.Text = ""
        Me.txtNOTIFY_PERSON.Visible = False
        '
        'cbGoodsCode
        '
        Me.cbGoodsCode.ItemHeight = 12
        Me.cbGoodsCode.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbGoodsCode.Location = New System.Drawing.Point(294, 450)
        Me.cbGoodsCode.Name = "cbGoodsCode"
        Me.cbGoodsCode.Size = New System.Drawing.Size(130, 20)
        Me.cbGoodsCode.TabIndex = 423
        Me.cbGoodsCode.Visible = False
        '
        'cbPack
        '
        Me.cbPack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPack.ItemHeight = 12
        Me.cbPack.Location = New System.Drawing.Point(502, 306)
        Me.cbPack.Name = "cbPack"
        Me.cbPack.Size = New System.Drawing.Size(130, 20)
        Me.cbPack.TabIndex = 488
        Me.cbPack.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(428, 356)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 443
        Me.Label2.Text = "净重"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Visible = False
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(602, 332)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(30, 20)
        Me.Label37.TabIndex = 493
        Me.Label37.Text = "公斤"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label37.Visible = False
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(428, 308)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 18)
        Me.Label15.TabIndex = 465
        Me.Label15.Text = "包装"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label15.Visible = False
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(602, 356)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(30, 20)
        Me.Label36.TabIndex = 492
        Me.Label36.Text = "公斤"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label36.Visible = False
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(428, 332)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 18)
        Me.Label16.TabIndex = 471
        Me.Label16.Text = "件重"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label16.Visible = False
        '
        'txtNETWEIGHT
        '
        Me.txtNETWEIGHT.Location = New System.Drawing.Point(502, 354)
        Me.txtNETWEIGHT.MaxLength = 20
        Me.txtNETWEIGHT.Name = "txtNETWEIGHT"
        Me.txtNETWEIGHT.TabIndex = 430
        Me.txtNETWEIGHT.Text = ""
        Me.txtNETWEIGHT.Visible = False
        '
        'txtPIECE_WEIGHT
        '
        Me.txtPIECE_WEIGHT.Location = New System.Drawing.Point(502, 330)
        Me.txtPIECE_WEIGHT.MaxLength = 20
        Me.txtPIECE_WEIGHT.Name = "txtPIECE_WEIGHT"
        Me.txtPIECE_WEIGHT.TabIndex = 429
        Me.txtPIECE_WEIGHT.Text = ""
        Me.txtPIECE_WEIGHT.Visible = False
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(428, 402)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(72, 18)
        Me.Label31.TabIndex = 459
        Me.Label31.Text = "冷冻温度"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label31.Visible = False
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(428, 426)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 18)
        Me.Label29.TabIndex = 461
        Me.Label29.Text = "温标"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label29.Visible = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(428, 378)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 450
        Me.Label5.Text = "体积尺寸"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Visible = False
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(602, 378)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 20)
        Me.Label11.TabIndex = 490
        Me.Label11.Text = "立方"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label11.Visible = False
        '
        'txtDANGER_GRADE
        '
        Me.txtDANGER_GRADE.Location = New System.Drawing.Point(502, 448)
        Me.txtDANGER_GRADE.MaxLength = 10
        Me.txtDANGER_GRADE.Name = "txtDANGER_GRADE"
        Me.txtDANGER_GRADE.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_GRADE.TabIndex = 435
        Me.txtDANGER_GRADE.Text = ""
        Me.txtDANGER_GRADE.Visible = False
        '
        'cbTempUnit
        '
        Me.cbTempUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTempUnit.ItemHeight = 12
        Me.cbTempUnit.Items.AddRange(New Object() {"", "C", "F"})
        Me.cbTempUnit.Location = New System.Drawing.Point(502, 424)
        Me.cbTempUnit.Name = "cbTempUnit"
        Me.cbTempUnit.Size = New System.Drawing.Size(130, 20)
        Me.cbTempUnit.TabIndex = 489
        Me.cbTempUnit.Visible = False
        '
        'txtREFRIGERATE_TEMPERATURE
        '
        Me.txtREFRIGERATE_TEMPERATURE.Location = New System.Drawing.Point(502, 400)
        Me.txtREFRIGERATE_TEMPERATURE.MaxLength = 20
        Me.txtREFRIGERATE_TEMPERATURE.Name = "txtREFRIGERATE_TEMPERATURE"
        Me.txtREFRIGERATE_TEMPERATURE.Size = New System.Drawing.Size(130, 21)
        Me.txtREFRIGERATE_TEMPERATURE.TabIndex = 433
        Me.txtREFRIGERATE_TEMPERATURE.Text = ""
        Me.txtREFRIGERATE_TEMPERATURE.Visible = False
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(428, 450)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(72, 18)
        Me.Label30.TabIndex = 447
        Me.Label30.Text = "危险品等级"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label30.Visible = False
        '
        'txtSIZE_MEASURE
        '
        Me.txtSIZE_MEASURE.Location = New System.Drawing.Point(502, 376)
        Me.txtSIZE_MEASURE.MaxLength = 20
        Me.txtSIZE_MEASURE.Name = "txtSIZE_MEASURE"
        Me.txtSIZE_MEASURE.TabIndex = 432
        Me.txtSIZE_MEASURE.Text = ""
        Me.txtSIZE_MEASURE.Visible = False
        '
        'txtDANGER_NO
        '
        Me.txtDANGER_NO.Location = New System.Drawing.Point(502, 472)
        Me.txtDANGER_NO.MaxLength = 10
        Me.txtDANGER_NO.Name = "txtDANGER_NO"
        Me.txtDANGER_NO.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_NO.TabIndex = 436
        Me.txtDANGER_NO.Text = ""
        Me.txtDANGER_NO.Visible = False
        '
        'txtDANGER_PAGENO
        '
        Me.txtDANGER_PAGENO.Location = New System.Drawing.Point(502, 496)
        Me.txtDANGER_PAGENO.MaxLength = 20
        Me.txtDANGER_PAGENO.Name = "txtDANGER_PAGENO"
        Me.txtDANGER_PAGENO.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_PAGENO.TabIndex = 437
        Me.txtDANGER_PAGENO.Text = ""
        Me.txtDANGER_PAGENO.Visible = False
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(428, 522)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(72, 18)
        Me.Label34.TabIndex = 475
        Me.Label34.Text = "危险品标签"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label34.Visible = False
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(428, 474)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 18)
        Me.Label26.TabIndex = 466
        Me.Label26.Text = "危险品编号"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label26.Visible = False
        '
        'txtGOODS_ENG
        '
        Me.txtGOODS_ENG.Location = New System.Drawing.Point(222, 492)
        Me.txtGOODS_ENG.MaxLength = 30
        Me.txtGOODS_ENG.Multiline = True
        Me.txtGOODS_ENG.Name = "txtGOODS_ENG"
        Me.txtGOODS_ENG.Size = New System.Drawing.Size(200, 48)
        Me.txtGOODS_ENG.TabIndex = 425
        Me.txtGOODS_ENG.Text = ""
        Me.txtGOODS_ENG.Visible = False
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(428, 498)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 18)
        Me.Label27.TabIndex = 468
        Me.Label27.Text = "危险品页号"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label27.Visible = False
        '
        'txtDANGER_MARK
        '
        Me.txtDANGER_MARK.Location = New System.Drawing.Point(502, 520)
        Me.txtDANGER_MARK.MaxLength = 10
        Me.txtDANGER_MARK.Name = "txtDANGER_MARK"
        Me.txtDANGER_MARK.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_MARK.TabIndex = 438
        Me.txtDANGER_MARK.Text = ""
        Me.txtDANGER_MARK.Visible = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(218, 472)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 18)
        Me.Label8.TabIndex = 467
        Me.Label8.Text = "货物英文描述"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Visible = False
        '
        'FrmConHatchCargo_Query
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(634, 325)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.cbUnloadPortEng)
        Me.Controls.Add(Me.cbLoadPortEng)
        Me.Controls.Add(Me.cbReceivePlaceEng)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbTempUnit)
        Me.Controls.Add(Me.cbPack)
        Me.Controls.Add(Me.cbUnloadPort)
        Me.Controls.Add(Me.cbLoadPort)
        Me.Controls.Add(Me.cbReceivePlace)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.txtDANGER_MARK)
        Me.Controls.Add(Me.txtPIECE_WEIGHT)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSIZE_MEASURE)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCONTAINER)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtGROSS_WEIGHT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNETWEIGHT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtDANGER_GRADE)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.txtDANGER_NO)
        Me.Controls.Add(Me.txtDANGER_PAGENO)
        Me.Controls.Add(Me.txtREFRIGERATE_TEMPERATURE)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.cbEMPTY_MARK)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.dtpLoadDate)
        Me.Controls.Add(Me.cbGoodsCode)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtMark)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbCONTAINER_MARK)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBillNO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtGOODS_CHA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPRE_SHIPNAME)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPRE_SHIPCODE)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtPRE_VOYAGE)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtGOODS_ENG)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtNOTIFY_PERSON)
        Me.Controls.Add(Me.txtRECEIVER)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.C1DBG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConHatchCargo_Query"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "集装箱舱单信息 查看"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmConHatchCargo_Query_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Dim dwCodeGoods As New DataView()
        Dim sqlCodeGoods, sqlEmptyMark, sqlContainerMark As String
        Dim dwEmptyMark As New DataView()
        Dim dwContainerMark As New DataView()
        Dim sqlCondition As String

        sqlContainerMark = "SELECT EFL_Code, EFL_Name FROM Code_ConEFLType"
            dwContainerMark = Filldata(sqlContainerMark)
            Me.cbCONTAINER_MARK.DataSource = dwContainerMark
            Me.cbCONTAINER_MARK.DisplayMember = "EFL_Name"
            Me.cbCONTAINER_MARK.ValueMember = "EFL_Code"

            sqlCodeGoods = "SELECT CODE, GOODS FROM CODEGOODS"
            dwCodeGoods = Filldata(sqlCodeGoods)
            Me.cbGoodsCode.DataSource = dwCodeGoods
            Me.cbGoodsCode.DisplayMember = "GOODS"
            Me.cbGoodsCode.ValueMember = "CODE"

            sqlEmptyMark = "SELECT EFL_Code, EFL_Name FROM Code_ConEFLType"
            dwEmptyMark = Filldata(sqlEmptyMark)
            Me.cbEMPTY_MARK.DataSource = dwEmptyMark
            Me.cbEMPTY_MARK.DisplayMember = "EFL_Name"
            Me.cbEMPTY_MARK.ValueMember = "EFL_Code"

            Dim strPort, strPack As String
            Dim dvPack As New DataView()
        strPort = "SELECT CODE_PORT, PORT_CHA, PORT_ENG FROM CODE_PORT ORDER BY PORT_ENG"
            strPack = "SELECT CODE_PACK, PACK_CHA, PACK_ENG FROM CODE_PACK ORDER BY CODE_PACK"
            dvLoadPort = Filldata(strPort)
            dvUnloadPort = Filldata(strPort)
            dvReceivePlace = Filldata(strPort)
            dvPack = Filldata(strPack)
            Me.cbLoadPort.DataSource = dvLoadPort
            Me.cbLoadPort.DisplayMember = "PORT_CHA"
            Me.cbLoadPort.ValueMember = "CODE_PORT"
            Me.cbUnloadPort.DataSource = dvUnloadPort
            Me.cbUnloadPort.DisplayMember = "PORT_CHA"
            Me.cbUnloadPort.ValueMember = "CODE_PORT"
            Me.cbReceivePlace.DataSource = dvReceivePlace
            Me.cbReceivePlace.DisplayMember = "PORT_CHA"
            Me.cbReceivePlace.ValueMember = "CODE_PORT"
            Me.cbPack.DataSource = dvPack
            Me.cbPack.ValueMember = "PACK_CHA"
            Me.cbPack.ValueMember = "CODE_PACK"

            Me.cbLoadPortEng.DataSource = dvLoadPort
            Me.cbLoadPortEng.DisplayMember = "PORT_ENG"
            Me.cbLoadPortEng.ValueMember = "CODE_PORT"
            Me.cbUnloadPortEng.DataSource = dvUnloadPort
            Me.cbUnloadPortEng.DisplayMember = "PORT_ENG"
            Me.cbUnloadPortEng.ValueMember = "CODE_PORT"
            Me.cbReceivePlaceEng.DataSource = dvReceivePlace
            Me.cbReceivePlaceEng.DisplayMember = "PORT_ENG"
            Me.cbReceivePlaceEng.ValueMember = "CODE_PORT"

        'sqlstr = "SELECT * FROM CON_HATCH_LIST WHERE SHIP_ID = '" & Ship_ID & "' AND BLNO = '" & FrmConHatchCargo.Bill_ID & "' AND MARK = '" & FrmConHatchCargo.Mark_ID & "'"
        sqlstr = "SELECT * FROM CON_HATCH_LIST WHERE SHIP_ID = '" & Ship_ID & "' AND BLNO = '" & FrmConHatchCargo.Bill_ID & "'"
        dw = Updatedata(sqlda, sqlstr, ds)

        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("CON_HATCH_LIST_ID")
            txtBillNO.Text = ds.Tables(0).Rows(0).Item("BLNO")
            txtPRE_SHIPCODE.Text = ds.Tables(0).Rows(0).Item("PRE_SHIPCODE")
            txtPRE_SHIPNAME.Text = ds.Tables(0).Rows(0).Item("PRE_SHIPNAME")
            txtPRE_VOYAGE.Text = ds.Tables(0).Rows(0).Item("PRE_VOYAGE")
            dtpLoadDate.Value = ds.Tables(0).Rows(0).Item("LOAD_DATE")
            cbEMPTY_MARK.SelectedValue = ds.Tables(0).Rows(0).Item("EMPTY_MARK")
            txtMark.Text = ds.Tables(0).Rows(0).Item("MARK")
            cbGoodsCode.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_GOODS")
            txtGOODS_ENG.Text = ds.Tables(0).Rows(0).Item("GOODS_ENG")
            txtGOODS_CHA.Text = ds.Tables(0).Rows(0).Item("GOODS_CHA")
            cbCONTAINER_MARK.SelectedValue = ds.Tables(0).Rows(0).Item("CONTAINER_MARK")

            Me.cbLoadPort.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_LOAD_PORT")
            Me.cbUnloadPort.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT")
            Me.cbReceivePlace.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_PLACE_RECEIVE")
            Me.cbPack.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_PACK")

            If Not IsDBNull(ds.Tables(0).Rows(0).Item("TEMPERATURE")) Then
                Me.cbTempUnit.Text = ds.Tables(0).Rows(0).Item("TEMPERATURE")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("CONTAINER")) Then
                txtCONTAINER.Text = ds.Tables(0).Rows(0).Item("CONTAINER")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("AMOUNT")) Then
                txtAmount.Text = ds.Tables(0).Rows(0).Item("AMOUNT")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("PIECE_WEIGHT")) Then
                txtPIECE_WEIGHT.Text = ds.Tables(0).Rows(0).Item("PIECE_WEIGHT")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("NETWEIGHT")) Then
                txtNETWEIGHT.Text = ds.Tables(0).Rows(0).Item("NETWEIGHT")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("GROSS_WEIGHT")) Then
                txtGROSS_WEIGHT.Text = ds.Tables(0).Rows(0).Item("GROSS_WEIGHT")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("SIZE_MEASURE")) Then
                txtSIZE_MEASURE.Text = ds.Tables(0).Rows(0).Item("SIZE_MEASURE")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("REFRIGERATE_TEMPERATURE")) Then
                txtREFRIGERATE_TEMPERATURE.Text = ds.Tables(0).Rows(0).Item("REFRIGERATE_TEMPERATURE")
            End If
            txtRECEIVER.Text = ds.Tables(0).Rows(0).Item("RECEIVER")
            txtNOTIFY_PERSON.Text = ds.Tables(0).Rows(0).Item("NOTIFY_PERSON")
            txtDANGER_GRADE.Text = ds.Tables(0).Rows(0).Item("DANGER_GRADE")
            txtDANGER_NO.Text = ds.Tables(0).Rows(0).Item("DANGER_NO")
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("DANGER_PAGENO")) Then
                txtDANGER_PAGENO.Text = ds.Tables(0).Rows(0).Item("DANGER_PAGENO")
            End If
            txtDANGER_MARK.Text = ds.Tables(0).Rows(0).Item("DANGER_MARK")

            If Me.cbLoadPort.SelectedValue Is Nothing Then
                cbLoadPort.Text = ds.Tables(0).Rows(0).Item("CODE_LOAD_PORT")
            End If
            If Me.cbUnloadPort.SelectedValue Is Nothing Then
                cbUnloadPort.Text = ds.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT")
            End If
            If Me.cbReceivePlace.SelectedValue Is Nothing Then
                Me.cbReceivePlace.Text = ds.Tables(0).Rows(0).Item("CODE_PLACE_RECEIVE")
            End If
        End If
        sqlCondition = " CON_HATCH_CARGO.SHIP_ID =  '" & Ship_ID & "' AND CON_HATCH_CARGO.BLNO = '" & FrmConHatchCargo.Bill_ID & "'"
        'Dim sqlCondition As String = " SHIP_ID =  '" & Ship_ID & "' AND Expr1 = '" & FrmConHatchCargo.Bill_ID & "' AND Expr2 = '" & FrmConHatchCargo.Mark_ID & "'"
        InitSubTable(sqlCondition)     '初始化子表c1grid

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub InitSubTable(ByVal sqlCondition As String)
        Try
            Dim sqlContainer As String
            'sqlContainer = "SELECT CON_HATCH_RECORD.* FROM CON_HATCH_RECORD INNER JOIN CON_HATCH_CARGO ON CON_HATCH_RECORD.SHIP_ID = CON_HATCH_CARGO.SHIP_ID AND CON_HATCH_RECORD.CONTAINER_NO = CON_HATCH_CARGO.CONTAINER_NO WHERE " & sqlCondition
            'sqlContainer = "SELECT * FROM CON_HATCH_RECORD where 1=0 "
            sqlContainer = "SELECT CON_HATCH_RECORD_ID,SHIP_ID,CONTAINER_NO,SEALNO,SealCheck,SIZE_CON,CONTAINER_TYPE,OVER_HEIGHT,FULLOREMPTY,BAYNO,BLNO,CODE_GOODS,AMOUNT,WEIGHT,VOLUME,Code_MANUFACTURER,MANUFACTURER,CODE_KEEPER,KEEPER,ReeferTemp,TempUnit,DangerGrade,DangerMark,POSITION_CONTAINER,PASS_MARK,SHORT_UNLOAD,Unload_Mark,USER_NAME,USER_CODE " & _
                " FROM CON_HATCH_RECORD where ship_id = '" & Ship_ID & "' and container_no in (select con_hatch_cargo.container_no from con_hatch_cargo where " & sqlCondition & " )"
            'con_hatch_cargo.blno=4 and con_hatch_cargo.ship_id=0 and con_hatch_cargo.mark=24)"
            Me.C1DBG.DataSource = Updatedata(adContainer, sqlContainer, dsContainer)

            Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue

            Me.C1DBG.Splits(0).DisplayColumns.Item("CON_HATCH_RECORD_ID").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("SHIP_ID").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("BLNO").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("CODE_GOODS").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("POSITION_CONTAINER").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("PASS_MARK").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("SHORT_UNLOAD").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("USER_NAME").Visible = False

            Me.C1DBG.Splits(0).DisplayColumns.Item("Code_MANUFACTURER").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("MANUFACTURER").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("KEEPER").Visible = False

            Me.C1DBG.Splits(0).DisplayColumns.Item("AMOUNT").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("WEIGHT").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("VOLUME").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("Unload_Mark").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("BAYNO").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("OVER_HEIGHT").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("USER_CODE").Visible = False

            Me.C1DBG.Columns.Item("CONTAINER_NO").Caption = "集装箱号"
            Me.C1DBG.Columns.Item("SIZE_CON").Caption = "箱尺寸"
            Me.C1DBG.Columns.Item("CONTAINER_TYPE").Caption = "箱型"
            Me.C1DBG.Columns.Item("FULLOREMPTY").Caption = "箱状态"
            Me.C1DBG.Columns.Item("SEALNO").Caption = "铅封号"
            Me.C1DBG.Columns.Item("CODE_KEEPER").Caption = "箱经营人"
            Me.C1DBG.Columns.Item("SealCheck").Caption = "查封"
            Me.C1DBG.Columns.Item("ReeferTemp").Caption = "冷藏温度"
            Me.C1DBG.Columns.Item("TempUnit").Caption = "温标"
            Me.C1DBG.Columns.Item("DangerGrade").Caption = "危品等级"
            Me.C1DBG.Columns.Item("DangerMark").Caption = "危品标签"
            Call FiledFill()
            SetColumnWidth()
            dsContainer.Tables(0).Columns("USER_NAME").DefaultValue = G_User
            dsContainer.Tables(0).Columns("SHIP_ID").DefaultValue = Ship_ID

            Me.C1DBG.ColumnFooters = True
            Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
            Me.C1DBG.Columns.Item("CONTAINER_NO").FooterText = "合计" & dsContainer.Tables(0).Rows.Count & "条"
        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FiledFill()
        Dim sqla As New SqlClient.SqlDataAdapter()
        Dim sqlc As New SqlClient.SqlCommand()
        Dim dsItem As New DataSet()
        Dim i As Integer
        Try
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT EFL_Code, EFL_Name FROM Code_ConEFLType"
            sqla.SelectCommand = sqlc
            dsItem.Reset()
            sqla.Fill(dsItem)
            Me.C1DBG.Columns("FULLOREMPTY").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("FULLOREMPTY").ValueItems.Translate = True

            For i = 0 To dsItem.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
                vi.DisplayValue = dsItem.Tables(0).Rows(i)("EFL_Name")
                vi.Value = dsItem.Tables(0).Rows(i)("EFL_Code")
                Me.C1DBG.Columns.Item("FULLOREMPTY").ValueItems.Values.Add(vi)
            Next

            Me.C1DBG.Columns("OVER_HEIGHT").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("OVER_HEIGHT").ValueItems.Translate = True

            Dim vi2 As New C1.Win.C1TrueDBGrid.ValueItem()
            vi2.DisplayValue = "正常"
            vi2.Value = "0"
            Me.C1DBG.Columns.Item("OVER_HEIGHT").ValueItems.Values.Add(vi2)
            Dim vi1 As New C1.Win.C1TrueDBGrid.ValueItem()
            vi1.DisplayValue = "超高"
            vi1.Value = "1"
            Me.C1DBG.Columns.Item("OVER_HEIGHT").ValueItems.Values.Add(vi1)

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

            Dim sqlKeeper, sqlCompany As String
            Dim dvKeeper As New DataView()
            Dim dvCompany As New DataView()
            sqlKeeper = "SELECT Code_Con_Company, Con_Company_CHI, Con_Company_ENG FROM Code_Con_Company ORDER BY Con_Company_CHI"
            sqlCompany = "SELECT Code_Con_Company, Con_Company_CHI, Con_Company_ENG FROM Code_Con_Company ORDER BY Con_Company_CHI"
            dvKeeper = Filldata(sqlKeeper)
            dvCompany = Filldata(sqlCompany)
            Me.C1DBG.Columns("CODE_KEEPER").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("CODE_KEEPER").ValueItems.Translate = True
            Me.C1DBG.Columns("Code_MANUFACTURER").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("Code_MANUFACTURER").ValueItems.Translate = True
            For i = 0 To dvKeeper.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
                vi.DisplayValue = dvKeeper(i)("Con_Company_CHI")
                vi.Value = dvKeeper(i)("Code_Con_Company")
                Me.C1DBG.Columns.Item("CODE_KEEPER").ValueItems.Values.Add(vi)
            Next
            For i = 0 To dvCompany.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
                vi.DisplayValue = dvCompany(i)("Con_Company_CHI")
                vi.Value = dvCompany(i)("Code_Con_Company")
                Me.C1DBG.Columns.Item("Code_MANUFACTURER").ValueItems.Values.Add(vi)
            Next

        Catch ex As System.Exception
            MsgBox(ex.Message)
        Finally
            sqlconn.Close()
        End Try
    End Sub

    Private Sub SetColumnWidth()
        Dim i As Integer
        Try
            i = 2
            Do While i < Me.C1DBG.Columns.Count
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Width = 70
                i = i + 1
            Loop
            Me.C1DBG.Splits(0).DisplayColumns("SIZE_CON").Width = 40
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_TYPE").Width = 40
            Me.C1DBG.Splits(0).DisplayColumns("FULLOREMPTY").Width = 40
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Width = 90
            Me.C1DBG.Splits(0).DisplayColumns("SEALNO").Width = 90
            Me.C1DBG.Splits(0).DisplayColumns("CODE_KEEPER").Width = 100
            Me.C1DBG.Splits(0).DisplayColumns("SealCheck").Width = 20
            Me.C1DBG.Splits(0).DisplayColumns("ReeferTemp").Width = 40
            Me.C1DBG.Splits(0).DisplayColumns("TempUnit").Width = 40

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

End Class
