Imports TALLY.DBControl
Public Class FrmConLoadTally_DivideUnite
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
    Friend WithEvents btnTrans As System.Windows.Forms.Button
    Friend WithEvents lbCon As System.Windows.Forms.ListBox
    Friend WithEvents btnReturn As System.Windows.Forms.Button
    Friend WithEvents btnGet As System.Windows.Forms.Button
    Friend WithEvents C1DBGH As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents txtContainerNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBillNO As System.Windows.Forms.TextBox
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtShip As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbCount As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCallPrint As System.Windows.Forms.Button
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents C1DBGB As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents cbPlace As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnGetData As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConLoadTally_DivideUnite))
        Me.btnTrans = New System.Windows.Forms.Button
        Me.lbCon = New System.Windows.Forms.ListBox
        Me.btnReturn = New System.Windows.Forms.Button
        Me.btnGet = New System.Windows.Forms.Button
        Me.C1DBGH = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btSave = New System.Windows.Forms.Button
        Me.txtContainerNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtBillNO = New System.Windows.Forms.TextBox
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtShip = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnGetData = New System.Windows.Forms.Button
        Me.cbPlace = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnShow = New System.Windows.Forms.Button
        Me.C1DBGB = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.lbCount = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btQuit = New System.Windows.Forms.Button
        Me.btnCallPrint = New System.Windows.Forms.Button
        CType(Me.C1DBGH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.C1DBGB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTrans
        '
        Me.btnTrans.Location = New System.Drawing.Point(240, 506)
        Me.btnTrans.Name = "btnTrans"
        Me.btnTrans.Size = New System.Drawing.Size(64, 24)
        Me.btnTrans.TabIndex = 10
        Me.btnTrans.Text = "确定"
        '
        'lbCon
        '
        Me.lbCon.ItemHeight = 12
        Me.lbCon.Location = New System.Drawing.Point(300, 182)
        Me.lbCon.Name = "lbCon"
        Me.lbCon.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbCon.Size = New System.Drawing.Size(124, 316)
        Me.lbCon.Sorted = True
        Me.lbCon.TabIndex = 7
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(252, 276)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(42, 24)
        Me.btnReturn.TabIndex = 2
        Me.btnReturn.Text = "<"
        '
        'btnGet
        '
        Me.btnGet.Location = New System.Drawing.Point(252, 186)
        Me.btnGet.Name = "btnGet"
        Me.btnGet.Size = New System.Drawing.Size(42, 24)
        Me.btnGet.TabIndex = 1
        Me.btnGet.Text = ">"
        '
        'C1DBGH
        '
        Me.C1DBGH.AllowUpdate = False
        Me.C1DBGH.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGH.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBGH.Location = New System.Drawing.Point(4, 156)
        Me.C1DBGH.Name = "C1DBGH"
        Me.C1DBGH.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGH.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGH.PreviewInfo.ZoomFactor = 75
        Me.C1DBGH.Size = New System.Drawing.Size(240, 340)
        Me.C1DBGH.TabIndex = 3
        Me.C1DBGH.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
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
        "=""1""><Height>336</Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorSty" & _
        "le parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><F" & _
        "ilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=" & _
        """Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Headi" & _
        "ng"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><Inacti" & _
        "veStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9""" & _
        " /><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle pa" & _
        "rent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0" & _
        ", 0, 236, 336</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderS" & _
        "tyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""" & _
        "Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Foot" & _
        "er"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactiv" & _
        "e"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /" & _
        "><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" " & _
        "/><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelecto" & _
        "r"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" " & _
        "/></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None" & _
        "</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 236, 336</" & _
        "ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle " & _
        "parent="""" me=""Style15"" /></Blob>"
        '
        'C1DBG
        '
        Me.C1DBG.AllowAddNew = True
        Me.C1DBG.AllowDelete = True
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(432, 20)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.Size = New System.Drawing.Size(496, 478)
        Me.C1DBG.TabIndex = 11
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
        "=""1""><Height>474</Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorSty" & _
        "le parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><F" & _
        "ilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=" & _
        """Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Headi" & _
        "ng"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><Inacti" & _
        "veStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9""" & _
        " /><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle pa" & _
        "rent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0" & _
        ", 0, 492, 474</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderS" & _
        "tyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""" & _
        "Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Foot" & _
        "er"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactiv" & _
        "e"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /" & _
        "><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" " & _
        "/><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelecto" & _
        "r"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" " & _
        "/></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None" & _
        "</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 492, 474</" & _
        "ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle " & _
        "parent="""" me=""Style15"" /></Blob>"
        '
        'txtShipName
        '
        Me.txtShipName.BackColor = System.Drawing.Color.Lavender
        Me.txtShipName.Location = New System.Drawing.Point(300, 38)
        Me.txtShipName.MaxLength = 40
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.ReadOnly = True
        Me.txtShipName.Size = New System.Drawing.Size(124, 21)
        Me.txtShipName.TabIndex = 4
        Me.txtShipName.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(254, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 18)
        Me.Label5.TabIndex = 602
        Me.Label5.Text = "船名"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(686, 508)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 12
        Me.btSave.Text = "修改保存"
        '
        'txtContainerNo
        '
        Me.txtContainerNo.Location = New System.Drawing.Point(78, 14)
        Me.txtContainerNo.MaxLength = 12
        Me.txtContainerNo.Name = "txtContainerNo"
        Me.txtContainerNo.Size = New System.Drawing.Size(130, 21)
        Me.txtContainerNo.TabIndex = 0
        Me.txtContainerNo.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 599
        Me.Label3.Text = "集装箱号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBillNO
        '
        Me.txtBillNO.Location = New System.Drawing.Point(300, 86)
        Me.txtBillNO.MaxLength = 120
        Me.txtBillNO.Name = "txtBillNO"
        Me.txtBillNO.Size = New System.Drawing.Size(124, 21)
        Me.txtBillNO.TabIndex = 6
        Me.txtBillNO.Text = ""
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(300, 62)
        Me.txtVoyage.MaxLength = 6
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(124, 21)
        Me.txtVoyage.TabIndex = 5
        Me.txtVoyage.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(254, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 18)
        Me.Label4.TabIndex = 597
        Me.Label4.Text = "提单号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(254, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 18)
        Me.Label1.TabIndex = 596
        Me.Label1.Text = "航次"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShip
        '
        Me.txtShip.Location = New System.Drawing.Point(300, 14)
        Me.txtShip.MaxLength = 10
        Me.txtShip.Name = "txtShip"
        Me.txtShip.Size = New System.Drawing.Size(124, 21)
        Me.txtShip.TabIndex = 3
        Me.txtShip.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(254, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 18)
        Me.Label2.TabIndex = 595
        Me.Label2.Text = "船名码"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnGetData)
        Me.GroupBox1.Controls.Add(Me.cbPlace)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnShow)
        Me.GroupBox1.Controls.Add(Me.C1DBGB)
        Me.GroupBox1.Controls.Add(Me.lbCount)
        Me.GroupBox1.Controls.Add(Me.C1DBGH)
        Me.GroupBox1.Controls.Add(Me.txtContainerNo)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 540)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnGetData
        '
        Me.btnGetData.Location = New System.Drawing.Point(312, 132)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New System.Drawing.Size(65, 22)
        Me.btnGetData.TabIndex = 642
        Me.btnGetData.Text = "查找"
        '
        'cbPlace
        '
        Me.cbPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlace.Location = New System.Drawing.Point(304, 108)
        Me.cbPlace.Name = "cbPlace"
        Me.cbPlace.Size = New System.Drawing.Size(120, 20)
        Me.cbPlace.TabIndex = 597
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(248, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 18)
        Me.Label8.TabIndex = 598
        Me.Label8.Text = "工作地点"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(94, 130)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(64, 24)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "显示"
        '
        'C1DBGB
        '
        Me.C1DBGB.AllowUpdate = False
        Me.C1DBGB.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGB.Images.Add(CType(resources.GetObject("resource2"), System.Drawing.Image))
        Me.C1DBGB.Location = New System.Drawing.Point(4, 36)
        Me.C1DBGB.Name = "C1DBGB"
        Me.C1DBGB.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGB.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGB.PreviewInfo.ZoomFactor = 75
        Me.C1DBGB.Size = New System.Drawing.Size(242, 92)
        Me.C1DBGB.TabIndex = 1
        Me.C1DBGB.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
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
        "=""1""><Height>88</Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyl" & _
        "e parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><Fi" & _
        "lterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""" & _
        "Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Headin" & _
        "g"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><Inactiv" & _
        "eStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" " & _
        "/><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle par" & _
        "ent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0," & _
        " 0, 238, 88</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderSty" & _
        "le></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""No" & _
        "rmal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer" & _
        """ /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive""" & _
        " /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /><" & _
        "Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" />" & _
        "<Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelector""" & _
        " /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" />" & _
        "</NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None</" & _
        "Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 238, 88</Cli" & _
        "entArea><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle par" & _
        "ent="""" me=""Style15"" /></Blob>"
        '
        'lbCount
        '
        Me.lbCount.Location = New System.Drawing.Point(300, 160)
        Me.lbCount.Name = "lbCount"
        Me.lbCount.Size = New System.Drawing.Size(124, 18)
        Me.lbCount.TabIndex = 596
        Me.lbCount.Text = "计0条"
        Me.lbCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btQuit)
        Me.GroupBox2.Controls.Add(Me.btnCallPrint)
        Me.GroupBox2.Location = New System.Drawing.Point(428, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(502, 540)
        Me.GroupBox2.TabIndex = 610
        Me.GroupBox2.TabStop = False
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(336, 506)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 1
        Me.btQuit.Text = "退出"
        '
        'btnCallPrint
        '
        Me.btnCallPrint.Location = New System.Drawing.Point(164, 506)
        Me.btnCallPrint.Name = "btnCallPrint"
        Me.btnCallPrint.Size = New System.Drawing.Size(64, 24)
        Me.btnCallPrint.TabIndex = 0
        Me.btnCallPrint.Text = "打印"
        '
        'FrmConLoadTally_DivideUnite
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(930, 543)
        Me.Controls.Add(Me.txtBillNO)
        Me.Controls.Add(Me.txtShipName)
        Me.Controls.Add(Me.txtVoyage)
        Me.Controls.Add(Me.txtShip)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.btnTrans)
        Me.Controls.Add(Me.lbCon)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnGet)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConLoadTally_DivideUnite"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "装拆箱分单合单处理"
        CType(Me.C1DBGH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.C1DBGB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim sqlContainer As String
    Dim dsContainer As New DataSet()
    Dim daContainer As New SqlClient.SqlDataAdapter()
    Dim strShip, strVoyage, strBillNo As String
    Dim strOgID As String
    Dim strOgYard, strOgShip, strOgVoyage, strOgBillNo As String

    Dim dvCodeYard As New DataView()

    Dim sqlShipCode As String
    Dim dvShipCode As New DataView()
    Dim shipMark As Boolean
    Dim i, j As Integer

    Dim sqlConDeal As String
    Dim dvConDeal As New DataView()
    Dim dsConDeal As New DataSet()
    Dim daConDeal As New SqlClient.SqlDataAdapter()

    Dim Count, delSum As Integer
    Dim strYard, sqlYard As String
    Dim dvYard As New DataView()

    Dim sqlBillDeal As String
    Dim dvBillDeal As New DataView()

    Dim strOperYard As String '操作的场站
    Public blSave As Boolean

    Private Sub FrmConLoadTally_DivideUnite_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sqlYard As String
        sqlYard = "SELECT Code_Yard_ID, Code_Yard_Name, CodePrefix,DeptCode FROM Code_Yard where DeptCode like '" & G_DeptCode & "%' ORDER BY Code_Yard_ID"
        cbPlace.DataSource = Filldata(sqlYard)
        cbPlace.DisplayMember = "Code_Yard_Name"
        cbPlace.ValueMember = "Code_Yard_ID"

        sqlYard = "SELECT Code_Yard_ID, Code_Yard_Name, CodePrefix, CodeMax, CodeYear, DeptCode FROM Code_Yard WHERE DeptCode = '" & G_DeptCode & "'"
        dvYard = Filldata(sqlYard)
        If dvYard.Count > 0 Then
            strYard = dvYard(0)("Code_Yard_ID")
        Else
            strYard = ""
        End If
        Me.cbPlace.SelectedValue = strYard
        strOperYard = strYard
        strShip = ""
        strVoyage = ""
        strBillNo = ""

        strOgYard = ""
        strOgShip = ""
        strOgVoyage = ""
        strOgBillNo = ""

        Me.C1DBGB.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        'Me.C1DBGB.ColumnFooters = True
        'Me.C1DBGB.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        'Me.C1DBGB.FetchRowStyles = True

        Me.C1DBGH.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        Me.C1DBGH.ColumnFooters = True
        Me.C1DBGH.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGH.FetchRowStyles = True
        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBG.FetchRowStyles = True
        Me.txtContainerNo.Focus()

        'sqlContainer = "SELECT * FROM CON_LOAD_TALLY_LIST WHERE CHI_VESSEL = '" & strShip & "' AND Voyage = '" & strVoyage & "' AND BLNO = '" & strBillNo & "' order by CONTAINER_NO "
        'Call GetContainer(sqlContainer)
    End Sub

    Private Sub GetContainer(ByVal sqlSelect)
        Me.C1DBG.AllowAddNew = False
        Try
            Me.C1DBG.DataSource = Updatedata(daContainer, sqlContainer, dsContainer)
            Me.C1DBG.Columns("CONTAINER_NO").FooterText = "合计" & dsContainer.Tables(0).Rows.Count & "箱"
            Count = dsContainer.Tables(0).Rows.Count
            delSum = 0
            Me.C1DBG.Splits(0).DisplayColumns.Item(0).Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item(1).Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("SHIP_ID").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("USER_NAME").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("PACK_ENG").Visible = False

            Me.C1DBG.Splits(0).DisplayColumns.Item("CHI_VESSEL").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("VOYAGE").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("CodeYard").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("Checked").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("CheckTime").Visible = False
            'Me.C1DBG.Splits(0).DisplayColumns.Item("SecSealNO").Visible = False
            'Me.C1DBG.Splits(0).DisplayColumns.Item("ReasonOpenSeal").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("Printed").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("BLNO").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("DAMAGED_AMOUNT").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("DAMAGED_PACK").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("WEIGHT").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("PrintTime").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("PrintPerson").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("StateC").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("FullOrEmpty").Visible = False

            Me.C1DBG.Columns.Item("CHI_VESSEL").Caption = "船名"
            Me.C1DBG.Columns.Item("VOYAGE").Caption = "航次"
            Me.C1DBG.Columns.Item("BLNO").Caption = "提单号"
            Me.C1DBG.Columns.Item("CONTAINER_NO").Caption = "集装箱号"
            Me.C1DBG.Columns.Item("NEWSEALNO").Caption = "货单铅封号"
            Me.C1DBG.Columns.Item("SIZE_CON").Caption = "箱尺寸"
            Me.C1DBG.Columns.Item("CONTAINER_TYPE").Caption = "箱型"
            Me.C1DBG.Columns.Item("AMOUNT").Caption = "件数"
            Me.C1DBG.Columns.Item("PACK_CHA").Caption = "包装"
            Me.C1DBG.Columns.Item("NetWeight").Caption = "货重(kg)"
            Me.C1DBG.Columns.Item("VOLUME").Caption = "体积(M3)"
            Me.C1DBG.Columns.Item("SecSealNO").Caption = "备注铅封号"
            Me.C1DBG.Columns.Item("ReasonOpenSeal").Caption = "开封原因"
            Me.C1DBG.Columns.Item("ReeferTemp").Caption = "冷藏温度"
            Me.C1DBG.Columns.Item("TempUnit").Caption = "温标"
            Me.C1DBG.Columns.Item("DangerGrade").Caption = "危品等级"
            Me.C1DBG.Columns.Item("DangerMark").Caption = "危品标签"

            'Me.C1DBG.Columns.Item("CON_LOAD_TALLY_ID").DefaultValue = ID
            'Me.C1DBG.Columns.Item("USER_NAME").DefaultValue = G_User
            'Me.C1DBG.Columns.Item("CHI_VESSEL").DefaultValue = strShip
            'Me.C1DBG.Columns.Item("VOYAGE").DefaultValue = strVoyage
            'Me.C1DBG.Columns.Item("CodeYard").DefaultValue = strYCode

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
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Width = 80
            Me.C1DBG.Splits(0).DisplayColumns("NEWSEALNO").Width = 90
            Me.C1DBG.Splits(0).DisplayColumns("BLNO").Width = 90
            Me.C1DBG.Splits(0).DisplayColumns("SIZE_CON").Width = 30
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_TYPE").Width = 40
            Me.C1DBG.Splits(0).DisplayColumns("ReeferTemp").Width = 40
            Me.C1DBG.Splits(0).DisplayColumns("TempUnit").Width = 40
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtContainerNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContainerNo.Leave
        Me.txtContainerNo.Text = Me.txtContainerNo.Text.Trim.ToUpper
        If CheckConNO(Me.txtContainerNo.Text) <> 0 Then
        Else
            MessageBox.Show("箱号不规范！", "提示")
        End If
        sqlBillDeal = "SELECT ID,ShipName,Voyage,BLNO,NO,Code_Yard_Name,CHI_VESSEL,CodeYard FROM View_ConLoadTally WHERE (CONTAINER_NO='" & Me.txtContainerNo.Text & "' or CONTAINER_NO='" & Me.GetConOtherMode(Me.txtContainerNo.Text) & "') AND InOutPort='1'"
        If strOperYard = "08" Then  '监管信息中心可改全部
        Else
            sqlBillDeal += " and StateC <=1 "
        End If
        dvBillDeal = Filldata(sqlBillDeal)
        Me.C1DBGB.DataSource = dvBillDeal
        'Me.C1DBGB.Columns.Item("CHI_VESSEL").Caption = "船名码"
        Me.C1DBGB.Columns.Item("ShipName").Caption = "船名"
        Me.C1DBGB.Columns.Item("VOYAGE").Caption = "航次"
        Me.C1DBGB.Columns.Item("BLNO").Caption = "提单号"
        Me.C1DBGB.Columns.Item("NO").Caption = "编号"
        Me.C1DBGB.Columns.Item("Code_Yard_Name").Caption = "场站名"

        DBControl.SetDGWidth(Me.C1DBGB)

        Me.C1DBGB.Splits(0).DisplayColumns("ID").Visible = False
        Me.C1DBGB.Splits(0).DisplayColumns("CodeYard").Visible = False
        Me.C1DBGB.Splits(0).DisplayColumns("CHI_VESSEL").Visible = False
        If dvBillDeal.Count = 1 Then
            Call btnShow_Click(sender, e)
        End If
       
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        If dvBillDeal.Count > 0 Then
            strOgID = Me.C1DBGB.Columns("ID").Text
            strOgShip = Me.C1DBGB.Columns("CHI_VESSEL").Text
            strOgVoyage = Me.C1DBGB.Columns("VOYAGE").Text
            strOgBillNo = Me.C1DBGB.Columns("BLNO").Text    '记录原船名码 航次 提单号
            strOgYard = Me.C1DBGB.Columns("CodeYard").Text
            Call GetConDeal()
            Me.txtShip.Text = strOgShip
            Me.txtVoyage.Text = strOgVoyage
            Me.txtBillNO.Text = strOgBillNo
            Me.cbPlace.SelectedValue = strOgYard
            Me.txtShip_Leave(sender, e)
            Me.txtVoyage_Leave(sender, e)
            Me.txtBillNO_Leave(sender, e)
            Me.cbPlace_Leave(sender, e)
        End If
    End Sub

    Private Sub GetConDeal()
        sqlConDeal = "SELECT CON_LOAD_TALLY_LIST_ID, CONTAINER_NO, BLNO, CHI_VESSEL,VOYAGE,CodeYard FROM CON_LOAD_TALLY_LIST WHERE CHI_VESSEL = '" & strOgShip & "' AND Voyage = '" & strOgVoyage & "' AND BLNO = '" & strOgBillNo & "' AND CodeYard = '" & strOgYard & "' order by CONTAINER_NO "
        dvConDeal = Updatedata(daConDeal, sqlConDeal, dsConDeal)
        Me.C1DBGH.DataSource = dvConDeal
        Me.C1DBGH.Columns.Item("CHI_VESSEL").Caption = "船名码"
        Me.C1DBGH.Columns.Item("VOYAGE").Caption = "航次"
        Me.C1DBGH.Columns.Item("BLNO").Caption = "提单号"
        Me.C1DBGH.Columns.Item("CONTAINER_NO").Caption = "集装箱号"
        Me.C1DBGH.Splits(0).DisplayColumns("CON_LOAD_TALLY_LIST_ID").Visible = False
        Me.C1DBGH.Splits(0).DisplayColumns("CodeYard").Visible = False
        Me.C1DBGH.Splits(0).DisplayColumns("CHI_VESSEL").Width = 45
        Me.C1DBGH.Splits(0).DisplayColumns("VOYAGE").Width = 45
        Me.C1DBGH.Splits(0).DisplayColumns("BLNO").Width = 90
        Me.C1DBGH.Splits(0).DisplayColumns("CONTAINER_NO").Width = 80
        Me.C1DBGH.Columns("CONTAINER_NO").FooterText = "合计" & dvConDeal.Count & "箱"
    End Sub

    Private Sub btnGet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGet.Click
        Me.C1DBGH.Focus()
        For i = 0 To Me.C1DBGH.SelectedRows.Count - 1
            Me.C1DBGH.Row = Me.C1DBGH.SelectedRows(i)
            If Me.C1DBGH.Columns("CHI_VESSEL").Text = strOgShip AndAlso Me.C1DBGH.Columns("Voyage").Text = strOgVoyage AndAlso Me.C1DBGH.Columns("BLNO").Text = strOgBillNo AndAlso Me.C1DBGH.Columns("CodeYard").Text = strOgYard Then
                Me.C1DBGH.Columns("CHI_VESSEL").Text = strShip
                Me.C1DBGH.Columns("Voyage").Text = strVoyage
                Me.C1DBGH.Columns("BLNO").Text = strBillNo
                Me.C1DBGH.Columns("CodeYard").Text = strYard
                Me.lbCon.Items.Add(Me.C1DBGH.Columns("CONTAINER_NO").Text)
            End If
        Next
        Me.btQuit.Focus()
        Me.C1DBGH.Focus()
        lbCount.Text = "计" & Me.lbCon.Items.Count & "条"
    End Sub

    Private Sub btnReturn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturn.Click
        Me.C1DBGH.Focus()
        For i = 0 To Me.lbCon.SelectedItems.Count - 1
            For j = 0 To dvConDeal.Count - 1
                Me.C1DBGH.Row = j
                If Me.lbCon.SelectedItems.Item(0) = Me.C1DBGH.Columns("CONTAINER_NO").Text Then
                    Me.C1DBGH.Columns("CHI_VESSEL").Text = strOgShip
                    Me.C1DBGH.Columns("Voyage").Text = strOgVoyage
                    Me.C1DBGH.Columns("BLNO").Text = strOgBillNo
                    Me.C1DBGH.Columns("CodeYard").Text = strOgYard
                    Exit For
                End If
            Next
            Me.lbCon.Items.Remove(Me.lbCon.SelectedItems.Item(0))
        Next
        Me.lbCon.Focus()
        lbCount.Text = "计" & Me.lbCon.Items.Count & "条"
    End Sub

    Private Sub C1DBGH_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBGH.FetchRowStyle
        If Me.C1DBGH.Columns("CHI_VESSEL").CellText(e.Row) = strShip AndAlso Me.C1DBGH.Columns("Voyage").CellText(e.Row) = strVoyage AndAlso Me.C1DBGH.Columns("BLNO").CellText(e.Row) = strBillNo AndAlso Me.C1DBGH.Columns("CodeYard").CellText(e.Row) = strYard Then
            e.CellStyle.BackColor = System.Drawing.Color.DarkSlateBlue
        End If
    End Sub

    Private Sub btnTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrans.Click
        Dim strNewNo As String
        Try
            If strShip <> strOgShip OrElse strVoyage <> strOgVoyage OrElse strBillNo <> strOgBillNo OrElse strYard <> strOgYard Then '非同一提单时可导，否则不可导
                If lbCon.Items.Count > 0 Then
                    If shipMark = True Then
                        If strVoyage <> "" And strBillNo <> "" Then
                            Me.C1DBGH.Focus()
                            For i = 0 To dvConDeal.Count - 1
                                Me.C1DBGH.Row = i
                                If Me.C1DBGH.Columns("CHI_VESSEL").Text <> strOgShip OrElse Me.C1DBGH.Columns("Voyage").Text <> strOgVoyage OrElse Me.C1DBGH.Columns("BLNO").Text <> strOgBillNo OrElse Me.C1DBGH.Columns("CodeYard").Text <> strOgYard Then
                                    Me.C1DBGH.Columns("CHI_VESSEL").Text = strShip
                                    Me.C1DBGH.Columns("Voyage").Text = strVoyage
                                    Me.C1DBGH.Columns("BLNO").Text = strBillNo
                                    Me.C1DBGH.Columns("CodeYard").Text = strYard
                                End If
                            Next
                            Me.btQuit.Focus()
                        Else
                            Me.txtVoyage.Focus()
                            MessageBox.Show("航次提单号不能为空", "提示")
                            Exit Sub
                        End If
                    Else
                        Me.txtShip.Focus()
                        MessageBox.Show("船码 " & strShip & " 不存在，请重新输入", "提示")
                        Exit Sub
                    End If
                Else
                    MessageBox.Show("请选择要处理的箱号", "提示")
                    Exit Sub
                End If

                If MessageBox.Show("确定检查无误，更改关系么？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                    Dim sqlExistBill, sqlGetBill, sqlDelBill As String
                    sqlExistBill = "SELECT BLNO FROM CON_LOAD_TALLY WHERE CHI_VESSEL = '" & strShip & "' AND Voyage = '" & strVoyage & "' AND BLNO = '" & strBillNo & "' AND WORK_PLACE = '" & strYard & "'"
                    If Filldata(sqlExistBill).Count = 0 Then   '没有提单场站信息 加  
                        'strOgYard = Me.C1DBGB.Columns("CodeYard").Text  '新提单场站与原提单箱一致
                        strNewNo = GetAutoNo(strYard)    '生成理货单编号
                        'sqlGetBill = "INSERT INTO CON_LOAD_TALLY (CHI_VESSEL, Voyage, InOutPort, CodeLoadPort, NO, WORK_PLACE, TIME_FROM, BLNO, WORKTYPE, CODE_TALLY_TYPE, USER_NAME, CODE_CON_CONSIGN) " & _
                        '                           "VALUES ('" & strShip & "', '" & strVoyage & "', '1', 'LYG', '" & strNewNo & "', '" & strYard & "', '" & Now & "', '" & strBillNo & "', '2', '3', '" & G_User & "', '00')"

                        sqlGetBill = "INSERT INTO CON_LOAD_TALLY(SHIP_ID,CHI_VESSEL,Voyage,InOutPort,CodeLoadPort,CodeUnloadPort,CodeDelivery,NO,WORK_PLACE,TIME_FROM,TIME_TO,BLNO,MARK,WORKTYPE,CODE_TALLY_TYPE,CODE_GOODS,GoodsCha,GoodsEng,GoodsSpec,AMOUNT,TOTAL_WEIGHT,TotalNetWeight,SIZE_MEASURE,ReeferTemp,TempUnit,DangerGrade,DangerMark,DESCR,STATE,CONTRACT_NO,AccountNo,Shipper,RECEIVER,Notify,LISTDATE,TALLY_CLERK,CROSS_PERSON,CODE_CON_CONSIGN,USER_NAME,checked,StateB,Report,TradeMark) " & _
                                "SELECT SHIP_ID, '" & strShip & "', '" & strVoyage & "', InOutPort, CodeLoadPort, CodeUnloadPort, CodeDelivery, '" & strNewNo & "', '" & strYard & "', TIME_FROM, TIME_TO, '" & strBillNo & "', MARK, WORKTYPE, CODE_TALLY_TYPE, CODE_GOODS, GoodsCha, GoodsEng,GoodsSpec,AMOUNT, TOTAL_WEIGHT, TotalNetWeight, SIZE_MEASURE,ReeferTemp, TempUnit, DangerGrade, DangerMark, DESCR, STATE, CONTRACT_NO, null, Shipper, RECEIVER, Notify, LISTDATE,TALLY_CLERK, CROSS_PERSON, CODE_CON_CONSIGN, '" & G_User & "', '0', '1', Report,TradeMark " & _
                                "FROM CON_LOAD_TALLY " & _
                                "WHERE CON_LOAD_TALLY_ID=" & strOgID
                        ExecSql(sqlGetBill)
                    End If
                    daConDeal.Update(dsConDeal)     '更改箱关系
                    If dvConDeal.Count = lbCon.Items.Count Then     '如果原提单箱子全被导出，删除
                        'Dim sqlConExist As String
                        'Dim dvConExist As DataView
                        'sqlConExist = "select CON_LOAD_Tally_ID,(Select Count(*) from CON_LOAD_Tally_List where )"
                        'dvConExist = Filldata(sqlConExist)
                        '记录操作日志
                        Call OperateHistory(G_DeptName, Now, G_User, "分单合单删除", "CON_LOAD_Tally", strOgID, "CON_LOAD_Tally_ID")
                        ExecSql("Exec sp_ConLoadTallyListOperPre '" & G_DeptName & "','" & Now & "','" & G_User & "'")

                        sqlDelBill = "DELETE FROM CON_LOAD_TALLY WHERE CHI_VESSEL='" & strOgShip & "' AND Voyage='" & strOgVoyage & "' AND BLNO='" & strOgBillNo & "' AND WORK_PLACE='" & strOgYard & "'"
                        ExecSql(sqlDelBill)
                    End If
                    Call GetConDeal()
                    sqlContainer = "SELECT CON_LOAD_TALLY_LIST_ID,CON_LOAD_TALLY_ID,SHIP_ID,CHI_VESSEL,Voyage,BLNO,CONTAINER_NO,NEWSEALNO,SIZE_CON,CONTAINER_TYPE,PACK_CHA,PACK_ENG,AMOUNT,WEIGHT,NetWeight,VOLUME,DAMAGED_AMOUNT,DAMAGED_PACK,SecSealNO,ReasonOpenSeal,USER_NAME,CodeYard,ReeferTemp,TempUnit,DangerGrade,DangerMark,Checked,CheckTime,Printed,PrintTime,PrintPerson,StateC,FullOrEmpty " & _
                        " FROM CON_LOAD_TALLY_LIST WHERE CHI_VESSEL = '" & strShip & "' AND Voyage = '" & strVoyage & "' AND BLNO = '" & strBillNo & "' AND CodeYard = '" & strYard & "' order by CONTAINER_NO "
                    Call GetContainer(sqlContainer)
                    Me.lbCon.Items.Clear()
                    Me.lbCount.Text = "计0条"
                    blSave = True
                End If
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

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            Dim i, j As Integer

            Count = Count - delSum
            Me.C1DBG.Focus()
            For i = 0 To Count - 1
                Me.C1DBG.Row = i
                'Me.C1DBG.Columns("BLNO").Text = Me.C1DBG.Columns("BLNO").Text.Trim().ToUpper
                Me.C1DBG.Columns("CONTAINER_NO").Text = Me.C1DBG.Columns("CONTAINER_NO").Text.Trim().ToUpper
                Me.C1DBG.Columns("NEWSEALNO").Text = Me.C1DBG.Columns("NEWSEALNO").Text.Trim().ToUpper
                Me.C1DBG.Columns("CONTAINER_TYPE").Text = Me.C1DBG.Columns("CONTAINER_TYPE").Text.Trim().ToUpper
                Me.C1DBG.Columns("SecSealNO").Text = Me.C1DBG.Columns("SecSealNO").Text.Trim().ToUpper
                Me.C1DBG.Columns("ReasonOpenSeal").Text = Me.C1DBG.Columns("ReasonOpenSeal").Text.Trim()
                Me.C1DBG.Columns("VOLUME").Text = Me.C1DBG.Columns("VOLUME").Text.Trim()
                Me.C1DBG.Columns("DangerGrade").Text = Me.C1DBG.Columns("DangerGrade").Text.Trim()
                Me.C1DBG.Columns("DangerMark").Text = Me.C1DBG.Columns("DangerMark").Text.Trim()
                'Me.C1DBG.Columns("CHI_VESSEL").Text = strShip
                'Me.C1DBG.Columns("Voyage").Text = strVoyage VOLUME
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
                            Me.C1DBG.Col = 2
                            Me.C1DBG.SelectedRows.Clear()
                            Me.C1DBG.SelectedRows.Add(i)
                            If MessageBox.Show("集装箱号 " & C1DBG.Columns("CONTAINER_NO").CellText(i) & " 校验不正确且在不存在于箱规范中！确定存在吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                Exit For
                            End If
                        End If
                    ElseIf iConCheck = 0 Then
                        Me.C1DBG.Row = i
                        Me.C1DBG.Col = 2
                        Me.C1DBG.SelectedRows.Clear()
                        Me.C1DBG.SelectedRows.Add(i)
                        MessageBox.Show("集装箱号不规范！", "提示")
                        Exit For
                    End If

                    For j = 0 To i - 1
                        If IsEqualConNo(Me.C1DBG.Columns("CONTAINER_NO").CellText(i), Me.C1DBG.Columns("CONTAINER_NO").CellText(j)) Then
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
                    Me.C1DBG.Col = 2
                    Me.C1DBG.SelectedRows.Clear()
                    Me.C1DBG.SelectedRows.Add(i)
                    MessageBox.Show("集装箱号不能为空！", "提示")
                    Exit For
                End If
            Next

            If Not IsNothing(Me.C1DBG.DataSource) Then
                If i >= Count Then     '全部通过检验
                    If MessageBox.Show("确定对以上箱信息的修改删除么？", "警示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                        '记录操作日志
                        ExecSql("Exec sp_ConLoadTallyListOperPre '" & G_DeptName & "','" & Now & "','" & G_User & "'")

                        daContainer.Update(dsContainer)
                        MessageBox.Show("修改成功！", "")
                        Me.btnCallPrint.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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

    Private Sub C1DBG_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1DBG.KeyDown
        If e.KeyCode = Keys.Return And (Me.C1DBG.Col = 19 OrElse Me.C1DBG.Col = 25) Then
            Me.C1DBG.Row += 1
            Me.C1DBG.Col = 2
            SendKeys.Send("{LEFT}")
        End If
    End Sub

    Private Sub C1DBG_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.AfterDelete
        delSum += 1
        Me.C1DBG.Columns("CONTAINER_NO").FooterText = "合计" & Count - delSum & "箱"
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
            Me.btnGetData.Focus()
        End If
    End Sub

    Private Sub cbPlace_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbPlace.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnGetData.Focus()
        End If
    End Sub

    Private Sub txtContainerNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtContainerNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.C1DBGH.Focus()
        End If
    End Sub

    Private Sub txtShip_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtShip.Leave
        Me.txtShip.Text = Me.txtShip.Text.Trim.ToUpper
        strShip = Me.txtShip.Text
        sqlShipCode = "SELECT SPCODE, CHI_VESSEL,ENG_VESSEL FROM Code_SHIPNAME WHERE (SPCODE = '" & strShip & "' or CHI_VESSEL = '" & strShip & "')"
        dvShipCode = Filldata(sqlShipCode)
        Me.txtShipName.Clear()
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
        Else
            shipMark = False
            MessageBox.Show("船码 " & strShip & " 不存在，请重新输入", "提示")
        End If
    End Sub

    Private Sub txtVoyage_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVoyage.Leave
        Me.txtVoyage.Text = Me.txtVoyage.Text.Trim.ToUpper
        strVoyage = Me.txtVoyage.Text
    End Sub

    Private Sub txtBillNO_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBillNO.Leave
        Me.txtBillNO.Text = Me.txtBillNO.Text.Trim.ToUpper
        strBillNo = Me.txtBillNO.Text
    End Sub

    Private Sub cbPlace_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPlace.Leave
        strYard = Me.cbPlace.SelectedValue
    End Sub

    Private Sub btnGetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetData.Click

        If shipMark = True And strBillNo <> "" And strVoyage <> "" Then
            If strOperYard = "08" Then  '监管信息中心可改全部
                sqlContainer = "SELECT CON_LOAD_TALLY_LIST_ID,CON_LOAD_TALLY_ID,SHIP_ID,CHI_VESSEL,Voyage,BLNO,CONTAINER_NO,NEWSEALNO,SIZE_CON,CONTAINER_TYPE,PACK_CHA,PACK_ENG,AMOUNT,WEIGHT,NetWeight,VOLUME,DAMAGED_AMOUNT,DAMAGED_PACK,SecSealNO,ReasonOpenSeal,USER_NAME,CodeYard,ReeferTemp,TempUnit,DangerGrade,DangerMark,Checked,CheckTime,Printed,PrintTime,PrintPerson,StateC,FullOrEmpty " & _
                    " FROM CON_LOAD_TALLY_LIST WHERE CHI_VESSEL = '" & strShip & "' AND Voyage = '" & strVoyage & "' AND BLNO = '" & strBillNo & "' AND CodeYard = '" & strYard & "' order by CONTAINER_NO "
            Else
                sqlContainer = "SELECT CON_LOAD_TALLY_LIST_ID,CON_LOAD_TALLY_ID,SHIP_ID,CHI_VESSEL,Voyage,BLNO,CONTAINER_NO,NEWSEALNO,SIZE_CON,CONTAINER_TYPE,PACK_CHA,PACK_ENG,AMOUNT,WEIGHT,NetWeight,VOLUME,DAMAGED_AMOUNT,DAMAGED_PACK,SecSealNO,ReasonOpenSeal,USER_NAME,CodeYard,ReeferTemp,TempUnit,DangerGrade,DangerMark,Checked,CheckTime,Printed,PrintTime,PrintPerson,StateC,FullOrEmpty " & _
                    " FROM CON_LOAD_TALLY_LIST WHERE CHI_VESSEL = '" & strShip & "' AND Voyage = '" & strVoyage & "' AND BLNO = '" & strBillNo & "' AND CodeYard = '" & strYard & "' and StateC <=1 order by CONTAINER_NO "
            End If
            Call GetContainer(sqlContainer)
        End If
    End Sub

    Private Sub btnCallPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCallPrint.Click
        Dim sqlGetID As String
        Dim dvGetID As New DataView
        sqlGetID = "select CON_LOAD_TALLY_ID, CHI_VESSEL, VOYAGE, BLNO from CON_LOAD_Tally where BLNO = '" & strBillNo & _
                                            "' and CHI_VESSEL = '" & strShip & _
                                            "' and VOYAGE = '" & strVoyage & "' AND Work_Place = '" & strYard & "'"
        ID = 0
        Try
            dvGetID = Filldata(sqlGetID)
            If dvGetID.Count > 0 Then
                ID = dvGetID(0)("CON_LOAD_TALLY_ID")
                Dim FrmPrint As New FrmContainerOutPort_Query
                FrmPrint.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub C1DBGB_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBGB.DoubleClick
        btnShow_Click(sender, e)
    End Sub
End Class
