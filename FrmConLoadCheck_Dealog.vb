Imports TALLY.DBControl
Public Class FrmConLoadCheck_Dealog
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
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBillNO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents cbDescribe As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbPlace As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents txtNO As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSize As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cbConLoadType As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtTotalNetWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cbGoodsCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtMark As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbConsign As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtShip As System.Windows.Forms.TextBox
    Friend WithEvents btnConDelete As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ckbInTrade As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConLoadCheck_Dealog))
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBillNO = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btQuit = New System.Windows.Forms.Button
        Me.btnCommit = New System.Windows.Forms.Button
        Me.cbDescribe = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtShip = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbPlace = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtNO = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtSize = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.cbConLoadType = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtTotalNetWeight = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.cbGoodsCode = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtMark = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtpTimeBegin = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.cbConsign = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.btnConDelete = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ckbInTrade = New System.Windows.Forms.CheckBox
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(74, 102)
        Me.txtVoyage.MaxLength = 6
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(130, 21)
        Me.txtVoyage.TabIndex = 4
        Me.txtVoyage.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(18, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 18)
        Me.Label1.TabIndex = 259
        Me.Label1.Text = "航次"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShipName
        '
        Me.txtShipName.BackColor = System.Drawing.Color.Lavender
        Me.txtShipName.Location = New System.Drawing.Point(74, 78)
        Me.txtShipName.MaxLength = 40
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.ReadOnly = True
        Me.txtShipName.Size = New System.Drawing.Size(130, 21)
        Me.txtShipName.TabIndex = 3
        Me.txtShipName.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(18, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 258
        Me.Label2.Text = "船名"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBillNO
        '
        Me.txtBillNO.Location = New System.Drawing.Point(282, 10)
        Me.txtBillNO.MaxLength = 20
        Me.txtBillNO.Name = "txtBillNO"
        Me.txtBillNO.Size = New System.Drawing.Size(130, 21)
        Me.txtBillNO.TabIndex = 5
        Me.txtBillNO.Text = ""
        '
        'Label4
        '
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(226, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 18)
        Me.Label4.TabIndex = 261
        Me.Label4.Text = "提单号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C1DBG
        '
        Me.C1DBG.AllowDelete = True
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 168)
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
        Me.C1DBG.Size = New System.Drawing.Size(638, 336)
        Me.C1DBG.TabIndex = 15
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Alig" & _
        "nVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSele" & _
        "ctorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><ClientRect>0, 0, 634, 332</ClientRect><BorderSide>0</BorderSide><CaptionSt" & _
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
        "ClientArea>0, 0, 634, 332</ClientArea><PrintPageHeaderStyle parent="""" me=""Style1" & _
        "4"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(324, 512)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 17
        Me.btQuit.Text = "取消"
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(254, 512)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(65, 24)
        Me.btnCommit.TabIndex = 16
        Me.btnCommit.Text = "保存"
        '
        'cbDescribe
        '
        Me.cbDescribe.Items.AddRange(New Object() {"", "全部抵运", "部分抵运"})
        Me.cbDescribe.Location = New System.Drawing.Point(496, 82)
        Me.cbDescribe.MaxDropDownItems = 20
        Me.cbDescribe.Name = "cbDescribe"
        Me.cbDescribe.Size = New System.Drawing.Size(130, 20)
        Me.cbDescribe.TabIndex = 13
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(438, 84)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 18)
        Me.Label20.TabIndex = 333
        Me.Label20.Text = "货箱抵运"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShip
        '
        Me.txtShip.Location = New System.Drawing.Point(74, 54)
        Me.txtShip.MaxLength = 40
        Me.txtShip.Name = "txtShip"
        Me.txtShip.Size = New System.Drawing.Size(130, 21)
        Me.txtShip.TabIndex = 2
        Me.txtShip.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(18, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 18)
        Me.Label3.TabIndex = 335
        Me.Label3.Text = "船码"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbPlace
        '
        Me.cbPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlace.Location = New System.Drawing.Point(74, 32)
        Me.cbPlace.MaxLength = 30
        Me.cbPlace.Name = "cbPlace"
        Me.cbPlace.Size = New System.Drawing.Size(130, 20)
        Me.cbPlace.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(18, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 18)
        Me.Label6.TabIndex = 415
        Me.Label6.Text = "场站名"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNO
        '
        Me.txtNO.Enabled = False
        Me.txtNO.Location = New System.Drawing.Point(74, 8)
        Me.txtNO.MaxLength = 20
        Me.txtNO.Name = "txtNO"
        Me.txtNO.Size = New System.Drawing.Size(130, 21)
        Me.txtNO.TabIndex = 0
        Me.txtNO.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(2, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 418
        Me.Label5.Text = "理货单编号"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 417
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(382, 106)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 20)
        Me.Label13.TabIndex = 443
        Me.Label13.Text = "立方"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(282, 104)
        Me.txtSize.MaxLength = 10
        Me.txtSize.Name = "txtSize"
        Me.txtSize.TabIndex = 9
        Me.txtSize.Text = ""
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(210, 106)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 18)
        Me.Label19.TabIndex = 442
        Me.Label19.Text = "总尺码"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbConLoadType
        '
        Me.cbConLoadType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConLoadType.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbConLoadType.Location = New System.Drawing.Point(496, 34)
        Me.cbConLoadType.Name = "cbConLoadType"
        Me.cbConLoadType.Size = New System.Drawing.Size(130, 20)
        Me.cbConLoadType.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(422, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 440
        Me.Label7.Text = "装箱类别"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(382, 82)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(30, 20)
        Me.Label23.TabIndex = 452
        Me.Label23.Text = "公斤"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalNetWeight
        '
        Me.txtTotalNetWeight.Location = New System.Drawing.Point(282, 80)
        Me.txtTotalNetWeight.MaxLength = 10
        Me.txtTotalNetWeight.Name = "txtTotalNetWeight"
        Me.txtTotalNetWeight.TabIndex = 8
        Me.txtTotalNetWeight.Text = ""
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(210, 82)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 18)
        Me.Label24.TabIndex = 451
        Me.Label24.Text = "总货重"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(282, 56)
        Me.txtAmount.MaxLength = 10
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(130, 21)
        Me.txtAmount.TabIndex = 7
        Me.txtAmount.Text = ""
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(210, 58)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 18)
        Me.Label25.TabIndex = 450
        Me.Label25.Text = "总件数"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbGoodsCode
        '
        Me.cbGoodsCode.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbGoodsCode.Location = New System.Drawing.Point(282, 34)
        Me.cbGoodsCode.MaxDropDownItems = 20
        Me.cbGoodsCode.MaxLength = 30
        Me.cbGoodsCode.Name = "cbGoodsCode"
        Me.cbGoodsCode.Size = New System.Drawing.Size(130, 20)
        Me.cbGoodsCode.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(210, 36)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 18)
        Me.Label17.TabIndex = 447
        Me.Label17.Text = "货名/规格"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(496, 10)
        Me.txtMark.MaxLength = 20
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(130, 21)
        Me.txtMark.TabIndex = 10
        Me.txtMark.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(422, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 446
        Me.Label9.Text = "标志"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeBegin
        '
        Me.dtpTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeBegin.Location = New System.Drawing.Point(496, 58)
        Me.dtpTimeBegin.Name = "dtpTimeBegin"
        Me.dtpTimeBegin.Size = New System.Drawing.Size(130, 21)
        Me.dtpTimeBegin.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(422, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 18)
        Me.Label8.TabIndex = 454
        Me.Label8.Text = "装箱时间"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbConsign
        '
        Me.cbConsign.Location = New System.Drawing.Point(496, 106)
        Me.cbConsign.MaxDropDownItems = 20
        Me.cbConsign.Name = "cbConsign"
        Me.cbConsign.Size = New System.Drawing.Size(130, 20)
        Me.cbConsign.TabIndex = 14
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(422, 108)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 18)
        Me.Label22.TabIndex = 456
        Me.Label22.Text = "委托单位"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnConDelete
        '
        Me.btnConDelete.Location = New System.Drawing.Point(106, 512)
        Me.btnConDelete.Name = "btnConDelete"
        Me.btnConDelete.Size = New System.Drawing.Size(65, 24)
        Me.btnConDelete.TabIndex = 457
        Me.btnConDelete.Text = "箱删除"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ckbInTrade)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(512, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(112, 34)
        Me.GroupBox2.TabIndex = 682
        Me.GroupBox2.TabStop = False
        '
        'ckbInTrade
        '
        Me.ckbInTrade.Location = New System.Drawing.Point(8, 8)
        Me.ckbInTrade.Name = "ckbInTrade"
        Me.ckbInTrade.Size = New System.Drawing.Size(100, 24)
        Me.ckbInTrade.TabIndex = 0
        Me.ckbInTrade.Text = "内贸箱不出证"
        '
        'FrmConLoadCheck_Dealog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(638, 543)
        Me.Controls.Add(Me.btnConDelete)
        Me.Controls.Add(Me.cbConsign)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.dtpTimeBegin)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtTotalNetWeight)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.cbGoodsCode)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtMark)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cbConLoadType)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.cbPlace)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtShip)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbDescribe)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.txtBillNO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtVoyage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtShipName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConLoadCheck_Dealog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "装拆箱检查桥查验 查看修改"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public strFindConNo As String   '查找定位用
    Dim ds As New DataSet
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dsSubTable As New DataSet()
    Dim sqlSubTableda As New SqlClient.SqlDataAdapter()
    Dim sqlSubTable As String
    Dim strShip, strVoyage, strBillNo, strYCode As String
    Dim strNewBillNo, strNewShip, strNewVoyage, strNewYard As String
    Dim sqlShipCode As String
    Dim dvShipCode As New DataView()
    Dim dvConsign As New DataView()
    Dim Count, delSum As Integer
    Dim shipmark As Boolean
    Dim strGoodsName As String
    Dim blLimitMark As Integer '修改限制标志，0 可改，1提示，2不可改
    Public Shared EditMark As Boolean

    Private Sub FrmConLoadCheck_Deal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen
        EditMark = False
        Dim sqlConLoadType As String
        sqlConLoadType = "select Code_Tally_Type,Name_Tally_Type from Code_Tally_Type "
        cbConLoadType.DataSource = Filldata(sqlConLoadType)
        cbConLoadType.DisplayMember = "Name_Tally_Type"
        cbConLoadType.ValueMember = "Code_Tally_Type"

        Dim sqlConsign As String
        sqlConsign = "SELECT CODE_SHIP_AGENT, SHIPAGENT_SHORT, SHIPAGENT_ENG FROM CODE_SHIP_AGENT where Mark <> '1' OR Mark IS NULL ORDER BY SHIPAGENT_SHORT"
        dvConsign = Filldata(sqlConsign)
        cbConsign.DataSource = dvConsign
        cbConsign.DisplayMember = "SHIPAGENT_SHORT"
        cbConsign.ValueMember = "CODE_SHIP_AGENT"

        Dim sqlCodeGoods As String
        Dim dvCodeGoods As New DataView()
        sqlCodeGoods = "select Code,Goods from CodeGoods order by goods"
        dvCodeGoods = Filldata(sqlCodeGoods)
        cbGoodsCode.DataSource = dvCodeGoods
        cbGoodsCode.DisplayMember = "Goods"
        cbGoodsCode.ValueMember = "Code"

        Dim sqlCodeYard As String
        sqlCodeYard = "SELECT Code_Yard_ID, Code_Yard_Name, CodePrefix FROM Code_Yard  where Code_Yard_ID <> '00' ORDER BY Code_Yard_ID"
        cbPlace.DataSource = Filldata(sqlCodeYard)
        cbPlace.DisplayMember = "Code_Yard_Name"
        cbPlace.ValueMember = "Code_Yard_ID"

        strYCode = FrmConLoadCheck.strCodeYard
        strShip = FrmConLoadCheck.strShip
        strVoyage = FrmConLoadCheck.strVoyage
        strBillNo = FrmConLoadCheck.strBillNo
        sqlstr = "select * from Con_Load_Tally where CHI_VESSEL ='" & strShip & "' and VOYAGE ='" & strVoyage & "' and BLNO = '" & strBillNo & "' and WORK_PLACE='" & strYCode & "'"
        dw = Updatedata(sqlda, sqlstr, ds)

        dtpTimeBegin.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"
        If dw.Count > 0 Then
            If dw(0)("TradeMark") = "1" Then
                Me.ckbInTrade.Checked = True
            Else
                Me.ckbInTrade.Checked = False
            End If
            txtID.Text = ds.Tables(0).Rows(0).Item("Con_Load_Tally_ID")
            txtShip.Text = ds.Tables(0).Rows(0).Item("CHI_VESSEL")
            txtVoyage.Text = ds.Tables(0).Rows(0).Item("VOYAGE")
            cbPlace.SelectedValue = ds.Tables(0).Rows(0).Item("WORK_PLACE")
            txtBillNO.Text = ds.Tables(0).Rows(0).Item("BLNO")
            txtMark.Text = ds.Tables(0).Rows(0).Item("MARK")
            txtNO.Text = ds.Tables(0).Rows(0).Item("NO")
            cbDescribe.Text = ds.Tables(0).Rows(0).Item("DESCR")
            'cbState.Text = ds.Tables(0).Rows(0).Item("STATE")

            cbConLoadType.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_TALLY_TYPE")
            cbGoodsCode.SelectedIndex = -1
            cbGoodsCode.Text = ds.Tables(0).Rows(0).Item("GoodsCha")
            strGoodsName = ds.Tables(0).Rows(0).Item("GoodsCha")
            cbConsign.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_CON_CONSIGN")

            dtpTimeBegin.Value = ds.Tables(0).Rows(0).Item("TIME_FROM")

            txtAmount.Text = ds.Tables(0).Rows(0).Item("AMOUNT")
            txtTotalNetWeight.Text = ds.Tables(0).Rows(0).Item("TotalNetWeight")
            txtSize.Text = ds.Tables(0).Rows(0).Item("SIZE_MEASURE")

            sqlShipCode = "SELECT SPCODE, CHI_VESSEL,Eng_VESSEL FROM Code_SHIPNAME WHERE SPCODE = '" & strShip & "'"
            dvShipCode = Filldata(sqlShipCode)
            If dvShipCode.Count > 0 Then
                strShip = dvShipCode(0)("SPCODE")
                Me.txtShip.Text = strShip
                If Not IsDBNull(dvShipCode(0)("CHI_VESSEL")) Then
                    Me.txtShipName.Text = dvShipCode(0)("CHI_VESSEL")
                End If
                If Not IsDBNull(dvShipCode(0)("Eng_VESSEL")) Then
                    Me.txtShipName.Text += "/" & dvShipCode(0)("Eng_VESSEL")
                End If
                shipmark = True
            Else
                shipmark = False
            End If
            InitSubTable()     '初始化子表c1grid
            delSum = -1
            Call Me.C1DBG_AfterDelete(sender, e)
            If Me.cbPlace.SelectedValue = "07" Then   '检查桥的可以改成场站
                Me.cbPlace.Enabled = True
            Else
                Me.cbPlace.Enabled = False
            End If
            Me.cbPlace.Enabled = False
            'Me.C1DBG.AllowSort = True

        End If
        btQuit.Focus()
        '判断是否可以修改。当为StateB小于2时可改，当大于等于2时，判断StateC存在小于2的可以修改。
        If ds.Tables(0).Rows(0)("StateB") < "2" Then
            blLimitMark = 0
        Else
            blLimitMark = 2  '原则上不可改
            Dim i As Integer
            For i = 0 To dsSubTable.Tables(0).Rows.Count - 1
                If dsSubTable.Tables(0).Rows(i)("StateC").ToString < "2" Then
                    blLimitMark = 1
                    Exit For
                End If
            Next
        End If
        '保存时，结合部门判断是否可以保存

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub InitSubTable()
        Try
            'sqlSubTable = "select * from Con_Load_Tally_List where  CHI_VESSEL ='" & strShip & "' and Voyage = '" & strVoyage & "' and blno= '" & strBillNo & "' and CodeYard = '" & strYCode & "'"

            sqlSubTable = "select CON_LOAD_TALLY_LIST_ID,CON_LOAD_TALLY_ID,SHIP_ID,CHI_VESSEL,Voyage,BLNO " & _
                " ,CONTAINER_NO,SIZE_CON,CONTAINER_TYPE,Clerk,NEWSEALNO,SealType,SealPerson,PACK_CHA,AMOUNT,WEIGHT,NetWeight,VOLUME " & _
                " ,ConTime,DAMAGED_AMOUNT,DAMAGED_PACK,SecSealNO,ReasonOpenSeal,ReeferTemp,TempUnit,DangerGrade,DangerMark " & _
                " ,USER_NAME,CodeYard,Checked,CheckTime,Printed,PrintTime,PrintPerson,StateC,FullOrEmpty " & _
                " ,CASE StateC WHEN '1' THEN '场站' WHEN '2' THEN '出证' WHEN '3' THEN '放行' WHEN '0' THEN '指示' WHEN '4' THEN '退关' END AS StateDesc " & _
                " from Con_Load_Tally_List where  CHI_VESSEL ='" & strShip & "' and Voyage = '" & strVoyage & "' and blno= '" & strBillNo & "' and CodeYard = '" & strYCode & "'"
            Me.C1DBG.DataSource = Updatedata(sqlSubTableda, sqlSubTable, dsSubTable)

            Me.C1DBG.FetchRowStyles = True
            Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
            Me.C1DBG.ColumnFooters = True
            Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
            Me.C1DBG.Columns("CONTAINER_NO").FooterText = "合计" & dsSubTable.Tables(0).Rows.Count & "箱"
            Count = dsSubTable.Tables(0).Rows.Count

            Me.C1DBG.Splits(0).DisplayColumns.Item(0).Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item(1).Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("SHIP_ID").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("USER_NAME").Visible = False

            Me.C1DBG.Splits(0).DisplayColumns.Item("CHI_VESSEL").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("VOYAGE").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("BLNO").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("CodeYard").Visible = False

            Me.C1DBG.Splits(0).DisplayColumns.Item("Clerk").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("ConTime").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("SealType").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("SealPerson").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("WEIGHT").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("DAMAGED_AMOUNT").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("DAMAGED_PACK").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("ReeferTemp").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("TempUnit").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("DangerGrade").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("DangerMark").Visible = False

            Me.C1DBG.Splits(0).DisplayColumns.Item("CheckTime").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("Printed").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("PrintTime").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("PrintPerson").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("StateC").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("FullOrEmpty").Visible = False

            Me.C1DBG.Columns.Item("CONTAINER_NO").Caption = "集装箱号"
            Me.C1DBG.Columns.Item("NEWSEALNO").Caption = "铅封号"
            Me.C1DBG.Columns.Item("SIZE_CON").Caption = "箱尺寸"
            Me.C1DBG.Columns.Item("CONTAINER_TYPE").Caption = "箱型"
            Me.C1DBG.Columns.Item("AMOUNT").Caption = "件数"
            Me.C1DBG.Columns.Item("PACK_CHA").Caption = "包装"
            Me.C1DBG.Columns.Item("NetWeight").Caption = "货重kg"
            Me.C1DBG.Columns.Item("VOLUME").Caption = "体积M3"
            Me.C1DBG.Columns.Item("SecSealNO").Caption = "备注封"
            Me.C1DBG.Columns.Item("ReasonOpenSeal").Caption = "开封原因"
            Me.C1DBG.Columns.Item("Checked").Caption = "查验"
            Me.C1DBG.Columns.Item("StateDesc").Caption = "状态"
            Me.C1DBG.Splits(0).DisplayColumns("Checked").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("StateDesc").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_TYPE").AutoDropDown = True
            Me.C1DBG.Splits(0).DisplayColumns("PACK_CHA").AutoDropDown = True
            Call FieldFill()
            SetDGWidth3(Me.C1DBG)
            Dim iFindConIndex As Integer = -1 '定位箱号位置
            Dim i As Integer
            For i = 0 To dsSubTable.Tables(0).Rows.Count - 1
                '查找箱号定位
                If Me.C1DBG.Columns("Container_No").CellText(i) = strFindConNo Then
                    iFindConIndex = i
                    Exit For
                End If
            Next
            If iFindConIndex >= 0 Then
                Me.C1DBG.Row = iFindConIndex
                Me.C1DBG.SelectedRows.Add(Me.C1DBG.Row)
            Else
            End If
            Me.C1DBG.Columns("AMOUNT").FooterText = GetDataSum(dsSubTable.Tables(0).DefaultView, "AMOUNT")
            Me.C1DBG.Columns("NetWeight").FooterText = GetDataSum(dsSubTable.Tables(0).DefaultView, "NetWeight")
            Me.C1DBG.Columns("VOLUME").FooterText = GetDataSum(dsSubTable.Tables(0).DefaultView, "VOLUME")
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
            Me.C1DBG.Columns("CONTAINER_TYPE").ValueItems.MaxComboItems = 20
            For i = 0 To dvConKind.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = dvConKind(i)("CON_KIND_ENG")
                vi.Value = dvConKind(i)("CODE_CON_KIND")
                Me.C1DBG.Columns.Item("CONTAINER_TYPE").ValueItems.Values.Add(vi)
            Next

            Dim sqlPack As String = "SELECT CODE_PACK, PACK_CHA, PACK_ENG FROM CODE_PACK ORDER BY px"
            Dim dvPack As New DataView
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
            Me.C1DBG.Columns("Checked").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub SetColumnWidth()
    '    Dim i As Integer
    '    Try
    '        i = 2
    '        Do While i < Me.C1DBG.Columns.Count
    '            Me.C1DBG.Splits(0).DisplayColumns.Item(i).Width = 60
    '            i = i + 1
    '        Loop
    '        Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Width = 90
    '        Me.C1DBG.Splits(0).DisplayColumns("NEWSEALNO").Width = 90
    '        Me.C1DBG.Splits(0).DisplayColumns("BLNO").Width = 90
    '        Me.C1DBG.Splits(0).DisplayColumns("SIZE_CON").Width = 30
    '        Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_TYPE").Width = 40
    '    Catch ex As System.Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub C1DBG_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.AfterDelete
        delSum += 1
        Me.C1DBG.Columns("CONTAINER_NO").FooterText = "合计" & Count - delSum & "箱"
        Dim i As Integer
        Dim totalAmount As Integer
        Dim totalNetWeight As Decimal
        For i = 0 To Count - delSum - 1
            If Me.C1DBG.Columns("AMOUNT").CellText(i) <> "" Then
                totalAmount += Me.C1DBG.Columns("AMOUNT").CellText(i)
            End If
            If Me.C1DBG.Columns("NetWeight").CellText(i) <> "" Then
                totalNetWeight += Me.C1DBG.Columns("NetWeight").CellText(i)
            End If
        Next
        If Me.txtAmount.Text = "" Then
            Me.txtAmount.Text = totalAmount
        End If
        If Me.txtTotalNetWeight.Text = "" Then
            Me.txtTotalNetWeight.Text = totalNetWeight
        End If
    End Sub

    Private Sub txtShipCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtShip.KeyDown
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

        End If
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        EditMark = False
        Me.Close()
    End Sub

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

    Private Function GetAutoNo(ByVal strYardValue As String) As String  '得到理货单编号，场站代码为参数
        Dim strAutoNo, sqlAutoNO, sqlUpdateYard As String
        Dim dvAutoNO As New DataView()
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

    Private Sub TrimGrid()
        Dim i As Integer
        Me.C1DBG.Focus()
        For i = 0 To Count - delSum - 1
            Me.C1DBG.Row = i
            Me.C1DBG.Columns("CONTAINER_NO").Text = Me.C1DBG.Columns("CONTAINER_NO").Text.Trim().ToUpper
            Me.C1DBG.Columns("NEWSEALNO").Text = Me.C1DBG.Columns("NEWSEALNO").Text.Trim().ToUpper
            Me.C1DBG.Columns("CONTAINER_TYPE").Text = Me.C1DBG.Columns("CONTAINER_TYPE").Text.Trim().ToUpper
            Me.C1DBG.Columns("SecSealNO").Text = Me.C1DBG.Columns("SecSealNO").Text.Trim().ToUpper
            Me.C1DBG.Columns("ReasonOpenSeal").Text = Me.C1DBG.Columns("ReasonOpenSeal").Text.Trim()

            Me.C1DBG.Columns("CHI_VESSEL").Text = strNewShip
            Me.C1DBG.Columns("Voyage").Text = strNewVoyage
            Me.C1DBG.Columns("BLNO").Text = strNewBillNo
            Me.C1DBG.Columns("CodeYard").Text = strNewYard
        Next
        Me.btQuit.Focus()
    End Sub

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        strNewBillNo = Me.txtBillNO.Text.Trim.ToUpper
        strNewShip = Me.txtShip.Text
        strNewVoyage = Me.txtVoyage.Text.Trim.ToUpper
        strNewYard = Me.cbPlace.SelectedValue

        Dim beSure As Boolean
        If G_DeptCode <> "26.11.30" Then
            If blLimitMark = 1 Then
                MessageBox.Show("该理货单已出证，但存在未出证箱", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ElseIf blLimitMark = 2 Then
                MessageBox.Show("该理货单已完全出证，非查验中心不可操作", "警示", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
        End If

        '箱信息检查
        Dim i, j, iConCheck, iConBeing As Integer
        Dim strContainer, sqlBeing As String
        Call TrimGrid()

        For i = 0 To Count - delSum - 1
            strContainer = Me.C1DBG.Columns("CONTAINER_NO").CellText(i)
            If strContainer <> "" Then
                iConCheck = CheckConNO(strContainer)
                '箱号没有通过检验时
                If iConCheck = 1 Or iConCheck = 0 Then
                    sqlBeing = "SELECT CONTAINER_NO FROM CON_CRITERION WHERE CONTAINER_NO = '" & strContainer & "' or CONTAINER_NO = '" & GetConOtherMode(strContainer) & "'"
                    iConBeing = Filldata(sqlBeing).Count
                    If iConBeing = 0 Then    '箱规范中不存在
                        Me.C1DBG.Row = i
                        Me.C1DBG.SelectedRows.Clear()
                        Me.C1DBG.SelectedRows.Add(i)
                        If MessageBox.Show("集装箱号 " & strContainer & " 校验不正确且不存在于箱规范中！确定存在吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                            Exit For
                        End If
                    End If
                ElseIf iConCheck = 0 Then
                    Me.C1DBG.Row = i
                    Me.C1DBG.SelectedRows.Clear()
                    Me.C1DBG.SelectedRows.Add(i)
                    MessageBox.Show("集装箱号不规范！", "提示")
                    Exit For
                End If
                For j = 0 To i - 1
                    If IsEqualConNo(strContainer, Me.C1DBG.Columns("CONTAINER_NO").CellText(j)) Then
                        Me.C1DBG.Row = i
                        Me.C1DBG.SelectedRows.Clear()
                        Me.C1DBG.SelectedRows.Add(i)
                        Me.C1DBG.SelectedRows.Add(j)
                        MessageBox.Show("第" & j + 1 & "行和第" & i + 1 & "行 同一提单下集装箱号重复！", "提示")
                        Exit Sub
                    End If
                Next
            Else
                Me.C1DBG.Row = i
                Me.C1DBG.SelectedRows.Clear()
                Me.C1DBG.SelectedRows.Add(i)
                MessageBox.Show("集装箱号不能为空！", "提示")
                Exit For
            End If
        Next

        '提单信息检查
        Dim sqlUpdateBill As String
        Dim strNewNo As String
        Dim sqlBillExist As String
        Dim iAmount As Integer
        Dim fWeight As Decimal
        If i >= Count - delSum Then
            If IsNumeric(Me.txtAmount.Text.Trim) Then
                iAmount = Me.txtAmount.Text.Trim
            Else
                If Me.txtAmount.Text.Trim <> "" Then
                    Me.txtAmount.Focus()
                    MessageBox.Show("总件数应为数字", "提示")
                    Exit Sub
                End If
            End If
            If IsNumeric(Me.txtTotalNetWeight.Text.Trim) Then
                fWeight = Me.txtTotalNetWeight.Text.Trim
            Else
                If Me.txtTotalNetWeight.Text.Trim <> "" Then
                    Me.txtTotalNetWeight.Focus()
                    MessageBox.Show("总货重应为数字", "提示")
                    Exit Sub
                End If
            End If
            strGoodsName = cbGoodsCode.Text.Trim

            If strNewShip <> strShip OrElse strNewVoyage <> strVoyage OrElse strNewBillNo <> strBillNo OrElse strNewYard <> strYCode Then
                '只要改变了船码航次提单号中任何一个，就要检查数据库
                If shipmark = False Then
                    Me.txtShip.Focus()
                    MessageBox.Show("船码 " & strNewShip & " 不存在，请重新输入", "提示")
                    Exit Sub
                End If
                sqlBillExist = "select CHI_VESSEL, VOYAGE, BLNO from CON_LOAD_Tally where WORK_PLACE='" & strNewYard & "' and BLNO = '" & strNewBillNo & _
                                                "' and CHI_VESSEL = '" & strNewShip & _
                                                "' and VOYAGE = '" & strNewVoyage & "' and CON_LOAD_TALLY_ID <> '" & ID & "'"
                If Filldata(sqlBillExist).Count = 0 Then
                    If MessageBox.Show("确定对以上信息的修改么？", "警示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                        beSure = True
                        Dim strTradeMark As String
                        If Me.ckbInTrade.Checked Then
                            strTradeMark = "1"
                        Else
                            strTradeMark = "0"
                        End If
                        If strNewYard <> strYCode Then      '改变场站时，也改理货单编号
                            strNewNo = GetAutoNo(strNewYard)    '生成理货单编号
                            Me.txtNO.Text = strNewNo

                            sqlUpdateBill = "update CON_LOAD_TALLY set TradeMark='" & strTradeMark & "',CHI_VESSEL='" & strNewShip & "', Voyage='" & strNewVoyage & "', BLNO='" & strNewBillNo & "', NO='" & strNewNo & "', WORK_PLACE='" & strNewYard & "', CODE_TALLY_TYPE='" & Me.cbConLoadType.SelectedValue & "', MARK='" & Me.txtMark.Text.Trim.ToUpper & "', GoodsCha='" & strGoodsName & "', AMOUNT= " & iAmount & ", TotalNetWeight= " & fWeight & ", SIZE_MEASURE='" & Me.txtSize.Text.Trim & "', TIME_FROM='" & Me.dtpTimeBegin.Value & "', DESCR='" & Me.cbDescribe.Text & "', CODE_CON_CONSIGN='" & Me.cbConsign.SelectedValue & "' where CHI_VESSEL='" & strShip & "' and Voyage='" & strVoyage & "' and BLNO='" & strBillNo & "' and WORK_PLACE='" & strYCode & "'"
                        Else    '未改变场站时，不改理货单编号
                            sqlUpdateBill = "update CON_LOAD_TALLY set TradeMark='" & strTradeMark & "',CHI_VESSEL='" & strNewShip & "', Voyage='" & strNewVoyage & "', BLNO='" & strNewBillNo & "', CODE_TALLY_TYPE='" & Me.cbConLoadType.SelectedValue & "', MARK='" & Me.txtMark.Text.Trim.ToUpper & "', GoodsCha='" & strGoodsName & "', AMOUNT= " & iAmount & ", TotalNetWeight= " & fWeight & ", SIZE_MEASURE='" & Me.txtSize.Text.Trim & "', TIME_FROM='" & Me.dtpTimeBegin.Value & "', DESCR='" & Me.cbDescribe.Text & "',  CODE_CON_CONSIGN='" & Me.cbConsign.SelectedValue & "' where CHI_VESSEL='" & strShip & "' and Voyage='" & strVoyage & "' and BLNO='" & strBillNo & "' and WORK_PLACE='" & strYCode & "'"
                        End If
                    End If
                Else
                    Me.txtShip.Focus()
                    MessageBox.Show("船名码 航次 提单号 场站不可重复！", "提示")
                    Exit Sub
                End If
            Else    '未改变船名航次提单号时，不检查
                If MessageBox.Show("确定对以上信息的修改么？", "警示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                    beSure = True
                    'If strNewYard <> strYCode Then      '改变场站时，也改理货单编号
                    '    strNewNo = GetAutoNo(strNewYard)    '生成理货单编号
                    '    Me.txtNO.Text = strNewNo
                    '    sqlUpdateBill = "update CON_LOAD_TALLY set NO='" & strNewNo & "', WORK_PLACE='" & strNewYard & "', CODE_TALLY_TYPE='" & Me.cbConLoadType.SelectedValue & "', MARK='" & Me.txtMark.Text.Trim.ToUpper & "', GoodsCha='" & strGoodsName & "', AMOUNT= " & iAmount & ", TotalNetWeight= " & fWeight & ", SIZE_MEASURE='" & Me.txtSize.Text.Trim & "', TIME_FROM='" & Me.dtpTimeBegin.Value & "', DESCR='" & Me.cbDescribe.Text & "', CODE_CON_CONSIGN='" & Me.cbConsign.SelectedValue & "' where CHI_VESSEL='" & strShip & "' and Voyage='" & strVoyage & "' and BLNO='" & strBillNo & "'"
                    'Else    '未改变场站时，不改理货单编号 最简单
                    'End If
                    sqlUpdateBill = "update CON_LOAD_TALLY set CODE_TALLY_TYPE='" & Me.cbConLoadType.SelectedValue & "', MARK='" & Me.txtMark.Text.Trim.ToUpper & "', GoodsCha='" & strGoodsName & "', AMOUNT= " & iAmount & ", TotalNetWeight= " & fWeight & ", SIZE_MEASURE='" & Me.txtSize.Text.Trim & "', TIME_FROM='" & Me.dtpTimeBegin.Value & "', DESCR='" & Me.cbDescribe.Text & "',  CODE_CON_CONSIGN='" & Me.cbConsign.SelectedValue & "' where CHI_VESSEL='" & strShip & "' and Voyage='" & strVoyage & "' and BLNO='" & strBillNo & "' and WORK_PLACE='" & strYCode & "'"
                End If
            End If
        End If

        If i >= Count - delSum And beSure = True Then    '全部通过检验
            '记录操作日志
            Call OperateHistory(G_DeptName, Now, G_User, "修改", "CON_LOAD_Tally", Trim(txtID.Text), "CON_LOAD_Tally_ID")
            Dim sqlUpdateOperTemp As String
            'sqlUpdateOperTemp = "delete from OperTemp   insert into OperTemp(Dept_Name, OperateTime, OperateWorker) values('" & G_DeptName & "','" & Now & "','" & G_User & "') "
            sqlUpdateOperTemp = "Exec sp_ConLoadTallyListOperPre '" & G_DeptName & "','" & Now & "','" & G_User & "'"
            ExecSql(sqlUpdateOperTemp)
            sqlSubTableda.Update(dsSubTable)
            ExecSql(sqlUpdateBill)
            EditMark = True
            Me.Close()
        End If
    End Sub

    Private Sub txtShip_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtShip.Leave
        Me.txtShip.Text = Me.txtShip.Text.Trim.ToUpper
        If strShip.Equals(Me.txtShip.Text) = False Then
            strNewShip = Me.txtShip.Text
            sqlShipCode = "SELECT SPCODE, CHI_VESSEL,Eng_VESSEL FROM Code_SHIPNAME WHERE (SPCODE = '" & Me.txtShip.Text & "' or CHI_VESSEL = '" & Me.txtShip.Text & "')"
            dvShipCode = Filldata(sqlShipCode)
            txtShipName.Clear()
            If dvShipCode.Count > 0 Then
                Me.txtShip.Text = dvShipCode(0)("SPCODE")
                strNewShip = Me.txtShip.Text
                If Not IsDBNull(dvShipCode(0)("CHI_VESSEL")) Then
                    Me.txtShipName.Text = dvShipCode(0)("CHI_VESSEL")
                End If
                If Not IsDBNull(dvShipCode(0)("Eng_VESSEL")) Then
                    Me.txtShipName.Text += "/" & dvShipCode(0)("Eng_VESSEL")
                End If
                shipmark = True
            Else
                shipmark = False
                MessageBox.Show("船码 " & Me.txtShip.Text & " 不存在，请重新输入", "提示")
            End If
        End If
    End Sub

    Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        If Me.C1DBG.Columns("checked").CellValue(e.Row) = "1" Then
            e.CellStyle.BackColor = System.Drawing.Color.Cyan
        End If
    End Sub

    Private Sub cbConsign_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbConsign.Leave
        Dim i As Integer
        Try
            For i = 0 To Me.cbConsign.Items.Count - 1
                If cbConsign.Text.Trim = Me.dvConsign(i)("SHIPAGENT_SHORT") Then
                    Me.cbConsign.SelectedValue = Me.dvConsign(i)("CODE_SHIP_AGENT")
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnConDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConDelete.Click
        Try
            Me.C1DBG.Delete()
            Call C1DBG_AfterDelete(sender, e)
        Catch ex As Exception
        End Try
    End Sub
End Class
