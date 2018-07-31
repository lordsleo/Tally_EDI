Imports TALLY.DBControl
Public Class FrmContainerOutPortog_Query
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet
    Dim sqlda As New SqlClient.SqlDataAdapter
    Dim dsSubTable As New DataSet
    Dim sqlSubTableda As New SqlClient.SqlDataAdapter
    Dim strShip, strVoyage, strBillNo, strYCode As String
    Dim strNewBillNo, strNewShip, strNewVoyage, strNewYard As String
    Dim dvSubTable As New DataView
    Dim Count, delSum As Integer
    Dim strConsign As String
    Dim sqlShipCode As String
    Dim dvShipCode As New DataView
    Dim sqlConsign As String
    Dim dvConsign As New DataView

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
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents cbPlace As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSize As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtTotalNetWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cbConsign As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cbState As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cbDescribe As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents cbGoodsCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
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
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmContainerOutPortog_Query))
        Me.Label35 = New System.Windows.Forms.Label
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.cbPlace = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtSize = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtTotalNetWeight = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.cbConsign = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.cbState = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.cbDescribe = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.btQuit = New System.Windows.Forms.Button
        Me.cbGoodsCode = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
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
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(8, 82)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(72, 18)
        Me.Label35.TabIndex = 516
        Me.Label35.Text = "船名"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShipName
        '
        Me.txtShipName.BackColor = System.Drawing.Color.Lavender
        Me.txtShipName.Location = New System.Drawing.Point(82, 80)
        Me.txtShipName.MaxLength = 40
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.ReadOnly = True
        Me.txtShipName.Size = New System.Drawing.Size(130, 21)
        Me.txtShipName.TabIndex = 515
        Me.txtShipName.Text = ""
        '
        'cbPlace
        '
        Me.cbPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlace.Enabled = False
        Me.cbPlace.Location = New System.Drawing.Point(82, 34)
        Me.cbPlace.Name = "cbPlace"
        Me.cbPlace.Size = New System.Drawing.Size(130, 20)
        Me.cbPlace.TabIndex = 509
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(398, 130)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 20)
        Me.Label13.TabIndex = 508
        Me.Label13.Text = "立方"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSize
        '
        Me.txtSize.Enabled = False
        Me.txtSize.Location = New System.Drawing.Point(298, 128)
        Me.txtSize.MaxLength = 10
        Me.txtSize.Name = "txtSize"
        Me.txtSize.TabIndex = 506
        Me.txtSize.Text = ""
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(224, 130)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 18)
        Me.Label19.TabIndex = 507
        Me.Label19.Text = "总尺码"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(398, 106)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(30, 20)
        Me.Label23.TabIndex = 505
        Me.Label23.Text = "公斤"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalNetWeight
        '
        Me.txtTotalNetWeight.Enabled = False
        Me.txtTotalNetWeight.Location = New System.Drawing.Point(298, 104)
        Me.txtTotalNetWeight.MaxLength = 10
        Me.txtTotalNetWeight.Name = "txtTotalNetWeight"
        Me.txtTotalNetWeight.TabIndex = 502
        Me.txtTotalNetWeight.Text = ""
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(224, 106)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 18)
        Me.Label24.TabIndex = 504
        Me.Label24.Text = "总货重"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmount
        '
        Me.txtAmount.Enabled = False
        Me.txtAmount.Location = New System.Drawing.Point(298, 80)
        Me.txtAmount.MaxLength = 10
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(130, 21)
        Me.txtAmount.TabIndex = 501
        Me.txtAmount.Text = ""
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(224, 82)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 18)
        Me.Label25.TabIndex = 503
        Me.Label25.Text = "总件数"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbConsign
        '
        Me.cbConsign.Enabled = False
        Me.cbConsign.Location = New System.Drawing.Point(514, 84)
        Me.cbConsign.MaxDropDownItems = 20
        Me.cbConsign.Name = "cbConsign"
        Me.cbConsign.Size = New System.Drawing.Size(130, 20)
        Me.cbConsign.TabIndex = 499
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(440, 86)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 18)
        Me.Label22.TabIndex = 500
        Me.Label22.Text = "委托单位"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbState
        '
        Me.cbState.Enabled = False
        Me.cbState.Items.AddRange(New Object() {"", "全已装箱", "部分装箱"})
        Me.cbState.Location = New System.Drawing.Point(514, 60)
        Me.cbState.MaxDropDownItems = 20
        Me.cbState.Name = "cbState"
        Me.cbState.Size = New System.Drawing.Size(130, 20)
        Me.cbState.TabIndex = 497
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(440, 62)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 18)
        Me.Label21.TabIndex = 498
        Me.Label21.Text = "货物处于"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbDescribe
        '
        Me.cbDescribe.Enabled = False
        Me.cbDescribe.Items.AddRange(New Object() {"", "全部抵运", "部分抵运"})
        Me.cbDescribe.Location = New System.Drawing.Point(514, 36)
        Me.cbDescribe.MaxDropDownItems = 20
        Me.cbDescribe.Name = "cbDescribe"
        Me.cbDescribe.Size = New System.Drawing.Size(130, 20)
        Me.cbDescribe.TabIndex = 495
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(440, 38)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 18)
        Me.Label20.TabIndex = 496
        Me.Label20.Text = "货箱抵运"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(294, 526)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 494
        Me.btQuit.Text = "返回"
        '
        'cbGoodsCode
        '
        Me.cbGoodsCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbGoodsCode.Enabled = False
        Me.cbGoodsCode.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbGoodsCode.Location = New System.Drawing.Point(298, 58)
        Me.cbGoodsCode.MaxDropDownItems = 20
        Me.cbGoodsCode.MaxLength = 30
        Me.cbGoodsCode.Name = "cbGoodsCode"
        Me.cbGoodsCode.Size = New System.Drawing.Size(130, 20)
        Me.cbGoodsCode.TabIndex = 481
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(224, 60)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 18)
        Me.Label17.TabIndex = 492
        Me.Label17.Text = "货名/规格"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMark
        '
        Me.txtMark.Enabled = False
        Me.txtMark.Location = New System.Drawing.Point(298, 34)
        Me.txtMark.MaxLength = 20
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(130, 21)
        Me.txtMark.TabIndex = 480
        Me.txtMark.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(224, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 491
        Me.Label9.Text = "标志"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeBegin
        '
        Me.dtpTimeBegin.Enabled = False
        Me.dtpTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeBegin.Location = New System.Drawing.Point(514, 10)
        Me.dtpTimeBegin.Name = "dtpTimeBegin"
        Me.dtpTimeBegin.Size = New System.Drawing.Size(130, 21)
        Me.dtpTimeBegin.TabIndex = 478
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(440, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 490
        Me.Label7.Text = "装箱时间"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbConLoadType
        '
        Me.cbConLoadType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConLoadType.Enabled = False
        Me.cbConLoadType.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbConLoadType.Location = New System.Drawing.Point(82, 128)
        Me.cbConLoadType.Name = "cbConLoadType"
        Me.cbConLoadType.Size = New System.Drawing.Size(130, 20)
        Me.cbConLoadType.TabIndex = 477
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 489
        Me.Label6.Text = "装箱类别"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBillNO
        '
        Me.txtBillNO.Enabled = False
        Me.txtBillNO.Location = New System.Drawing.Point(298, 10)
        Me.txtBillNO.MaxLength = 120
        Me.txtBillNO.Name = "txtBillNO"
        Me.txtBillNO.Size = New System.Drawing.Size(130, 21)
        Me.txtBillNO.TabIndex = 479
        Me.txtBillNO.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(224, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 488
        Me.Label4.Text = "提单号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 487
        Me.Label5.Text = "场站名"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNO
        '
        Me.txtNO.Enabled = False
        Me.txtNO.Location = New System.Drawing.Point(82, 10)
        Me.txtNO.MaxLength = 20
        Me.txtNO.Name = "txtNO"
        Me.txtNO.Size = New System.Drawing.Size(130, 21)
        Me.txtNO.TabIndex = 482
        Me.txtNO.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 486
        Me.Label3.Text = "理货单编号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVoyage
        '
        Me.txtVoyage.Enabled = False
        Me.txtVoyage.Location = New System.Drawing.Point(82, 104)
        Me.txtVoyage.MaxLength = 6
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(130, 21)
        Me.txtVoyage.TabIndex = 476
        Me.txtVoyage.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 485
        Me.Label1.Text = "航次"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShip
        '
        Me.txtShip.Enabled = False
        Me.txtShip.Location = New System.Drawing.Point(82, 56)
        Me.txtShip.MaxLength = 40
        Me.txtShip.Name = "txtShip"
        Me.txtShip.Size = New System.Drawing.Size(130, 21)
        Me.txtShip.TabIndex = 475
        Me.txtShip.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 484
        Me.Label2.Text = "船名码"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 483
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'C1DBG
        '
        Me.C1DBG.AllowSort = False
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 156)
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
        Me.C1DBG.Size = New System.Drawing.Size(652, 364)
        Me.C1DBG.TabIndex = 493
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Back" & _
        "Color:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSele" & _
        "ctorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><ClientRect>0, 0, 648, 360</ClientRect><BorderSide>0</BorderSide><CaptionSt" & _
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
        "ClientArea>0, 0, 648, 360</ClientArea><PrintPageHeaderStyle parent="""" me=""Style1" & _
        "4"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'FrmContainerOutPortog_Query
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(652, 555)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.txtShipName)
        Me.Controls.Add(Me.cbPlace)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtTotalNetWeight)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.cbConsign)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cbState)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.cbDescribe)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.cbGoodsCode)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtMark)
        Me.Controls.Add(Me.Label9)
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
        Me.Controls.Add(Me.C1DBG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmContainerOutPortog_Query"
        Me.ShowInTaskbar = False
        Me.Text = "出口集装箱理货单原始信息 查看"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmContainerOutPort_Query_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView
        Dim dvCodeGoods As New DataView
        Dim sqlstr, sqlCodeGoods As String
        Me.StartPosition = FormStartPosition.CenterScreen

        Dim sqlConLoadType As String
        sqlConLoadType = "select Code_Tally_Type,Name_Tally_Type from Code_Tally_Type "
        cbConLoadType.DataSource = Filldata(sqlConLoadType)
        cbConLoadType.DisplayMember = "Name_Tally_Type"
        cbConLoadType.ValueMember = "Code_Tally_Type"

        sqlConsign = "SELECT CODE_SHIP_AGENT, SHIPAGENT_SHORT, SHIPAGENT_ENG FROM CODE_SHIP_AGENT where Mark <> '1' OR Mark IS NULL ORDER BY SHIPAGENT_SHORT"
        dvConsign = Filldata(sqlConsign)
        cbConsign.DataSource = dvConsign
        cbConsign.DisplayMember = "SHIPAGENT_SHORT"
        cbConsign.ValueMember = "CODE_SHIP_AGENT"

        Dim sqlCodeYard As String
        sqlCodeYard = "SELECT Code_Yard_ID, Code_Yard_Name, CodePrefix FROM Code_Yard  where Code_Yard_ID <> '00' ORDER BY Code_Yard_ID"
        cbPlace.DataSource = Filldata(sqlCodeYard)
        cbPlace.DisplayMember = "Code_Yard_Name"
        cbPlace.ValueMember = "Code_Yard_ID"

        sqlstr = "select * from Con_Load_Tallytwo where Con_Load_Tally_ID =" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        dtpTimeBegin.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"
        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("Con_Load_Tally_ID")
            txtShip.Text = ds.Tables(0).Rows(0).Item("CHI_VESSEL")
            txtVoyage.Text = ds.Tables(0).Rows(0).Item("VOYAGE")
            cbPlace.SelectedValue = ds.Tables(0).Rows(0).Item("WORK_PLACE")
            txtBillNO.Text = ds.Tables(0).Rows(0).Item("BLNO")
            txtMark.Text = ds.Tables(0).Rows(0).Item("MARK")
            txtNO.Text = ds.Tables(0).Rows(0).Item("NO")
            cbDescribe.Text = ds.Tables(0).Rows(0).Item("DESCR")
            cbState.Text = ds.Tables(0).Rows(0).Item("STATE")

            cbConLoadType.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_TALLY_TYPE")
            cbGoodsCode.Text = ds.Tables(0).Rows(0).Item("GoodsCha")
            cbGoodsCode.Text = ds.Tables(0).Rows(0).Item("GoodsCha")
            cbConsign.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_CON_CONSIGN")
            strConsign = cbConsign.SelectedValue
            dtpTimeBegin.Value = ds.Tables(0).Rows(0).Item("TIME_FROM")

            txtAmount.Text = ds.Tables(0).Rows(0).Item("AMOUNT")
            txtTotalNetWeight.Text = ds.Tables(0).Rows(0).Item("TotalNetWeight")
            txtSize.Text = ds.Tables(0).Rows(0).Item("SIZE_MEASURE")

            strYCode = Me.cbPlace.SelectedValue
            strShip = txtShip.Text
            strVoyage = txtVoyage.Text
            strBillNo = txtBillNO.Text

            sqlShipCode = "SELECT SPCODE, CHI_VESSEL FROM Code_SHIPNAME WHERE SPCODE = '" & strShip & "'"
            dvShipCode = Filldata(sqlShipCode)
            If dvShipCode.Count > 0 Then
                strShip = dvShipCode(0)("SPCODE")
                Me.txtShip.Text = strShip
                If Not IsDBNull(dvShipCode(0)("CHI_VESSEL")) Then
                    Me.txtShipName.Text = dvShipCode(0)("CHI_VESSEL")
                End If
            Else
            End If
            InitSubTable(ID)     '初始化子表c1grid
            delSum = -1
            'Call Me.C1DBG_AfterDelete(sender, e)
            'Me.C1DBG.AllowSort = True
            Me.C1DBG.AllowUpdate = False
        End If
        btQuit.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub InitSubTable(ByVal sqlID As String)
        Try
            Dim sqlSubTable As String
            'sqlSubTable = "select * from Con_Load_Tally_List where CodeYard = '" & strYCode & "' AND CHI_VESSEL ='" & strShip & "' and Voyage = '" & strVoyage & "' and BLNO = '" & strBillNo & "'"
            sqlSubTable = "select * from Con_Load_Tally_Listtwo where CHI_VESSEL ='" & strShip & "' and Voyage = '" & strVoyage & "' and BLNO = '" & strBillNo & "' and  CodeYard= '" & strYCode & "' order by CONTAINER_NO"
            dvSubTable = Updatedata(sqlSubTableda, sqlSubTable, dsSubTable)
            Me.C1DBG.DataSource = dvSubTable

            Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
            Me.C1DBG.ColumnFooters = True
            Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
            Me.C1DBG.Columns("CONTAINER_NO").FooterText = "合计" & dsSubTable.Tables(0).Rows.Count & "箱"
            Count = dsSubTable.Tables(0).Rows.Count

            Me.C1DBG.Splits(0).DisplayColumns.Item(0).Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item(1).Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item(2).Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("USER_NAME").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("PACK_ENG").Visible = False

            Me.C1DBG.Splits(0).DisplayColumns.Item("CHI_VESSEL").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("VOYAGE").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("BLNO").Visible = False
            'Me.C1DBG.Splits(0).DisplayColumns.Item("CodeYard").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("WEIGHT").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("DAMAGED_AMOUNT").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("DAMAGED_PACK").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("Checked").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("CheckTime").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("Printed").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("PrintTime").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("PrintPerson").Visible = False

            Me.C1DBG.Columns.Item("CHI_VESSEL").Caption = "船名"
            Me.C1DBG.Columns.Item("VOYAGE").Caption = "航次"
            Me.C1DBG.Columns.Item("BLNO").Caption = "提单号"
            Me.C1DBG.Columns.Item("CONTAINER_NO").Caption = "集装箱号"
            Me.C1DBG.Columns.Item("NEWSEALNO").Caption = "货单铅封号"
            Me.C1DBG.Columns.Item("SIZE_CON").Caption = "箱尺寸"
            Me.C1DBG.Columns.Item("CONTAINER_TYPE").Caption = "箱型"
            Me.C1DBG.Columns.Item("AMOUNT").Caption = "件数"
            Me.C1DBG.Columns.Item("PACK_CHA").Caption = "包装"
            Me.C1DBG.Columns.Item("WEIGHT").Caption = "毛重(kg)"
            Me.C1DBG.Columns.Item("NetWeight").Caption = "货重(kg)"

            Me.C1DBG.Columns.Item("VOLUME").Caption = "体积(M3)"
            Me.C1DBG.Columns.Item("SecSealNO").Caption = "备注铅封号"
            Me.C1DBG.Columns.Item("ReasonOpenSeal").Caption = "开封原因"
            Me.C1DBG.Columns.Item("CodeYard").Caption = "装箱地点"

            'Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("CodeYard").Locked = True
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
                vi.DisplayValue = dvPack(i)("PACK_CHA") & "/" & dvPack(i)("PACK_ENG")
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
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Width = 55
                i = i + 1
            Loop
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Width = 80
            Me.C1DBG.Splits(0).DisplayColumns("NEWSEALNO").Width = 90
            Me.C1DBG.Splits(0).DisplayColumns("SIZE_CON").Width = 25
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_TYPE").Width = 35
            Me.C1DBG.Splits(0).DisplayColumns("CodeYard").Width = 65
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class
