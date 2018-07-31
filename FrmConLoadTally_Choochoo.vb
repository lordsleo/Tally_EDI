Imports TALLY.DBControl
Public Class FrmConLoadTally_Choochoo
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

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
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtShip As System.Windows.Forms.TextBox
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cbPlace As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents C1DBGE As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents C1DBGI As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSelectAll As System.Windows.Forms.Button
    Friend WithEvents btnClearAll As System.Windows.Forms.Button
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents ccbGoods As C1.Win.C1List.C1Combo
    Friend WithEvents lbVoyage As System.Windows.Forms.Label
    Friend WithEvents lbShipName As System.Windows.Forms.Label
    Friend WithEvents lbShip As System.Windows.Forms.Label
    Friend WithEvents txtBlno As System.Windows.Forms.TextBox
    Friend WithEvents lbOuter As System.Windows.Forms.Label
    Friend WithEvents lbNo As System.Windows.Forms.Label
    Friend WithEvents cbConsign As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConLoadTally_Choochoo))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtShip = New System.Windows.Forms.TextBox
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBlno = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnFind = New System.Windows.Forms.Button
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.cbPlace = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.C1DBGE = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.C1DBGI = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.btnSelectAll = New System.Windows.Forms.Button
        Me.btnClearAll = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnImport = New System.Windows.Forms.Button
        Me.ccbGoods = New C1.Win.C1List.C1Combo
        Me.lbVoyage = New System.Windows.Forms.Label
        Me.lbShipName = New System.Windows.Forms.Label
        Me.lbShip = New System.Windows.Forms.Label
        Me.lbOuter = New System.Windows.Forms.Label
        Me.lbNo = New System.Windows.Forms.Label
        Me.cbConsign = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.GroupBox4.SuspendLayout()
        CType(Me.C1DBGE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.C1DBGI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccbGoods, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtShip)
        Me.GroupBox4.Controls.Add(Me.txtVoyage)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtBlno)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.btnFind)
        Me.GroupBox4.Controls.Add(Me.txtShipName)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox4.Location = New System.Drawing.Point(4, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(674, 40)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "数据查找"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "船码"
        '
        'txtShip
        '
        Me.txtShip.Location = New System.Drawing.Point(40, 14)
        Me.txtShip.Name = "txtShip"
        Me.txtShip.TabIndex = 2
        Me.txtShip.Text = ""
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(342, 14)
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.TabIndex = 3
        Me.txtVoyage.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(310, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "航次"
        '
        'txtBlno
        '
        Me.txtBlno.Location = New System.Drawing.Point(478, 14)
        Me.txtBlno.Name = "txtBlno"
        Me.txtBlno.TabIndex = 0
        Me.txtBlno.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(446, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "提单"
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(598, 12)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(60, 22)
        Me.btnFind.TabIndex = 1
        Me.btnFind.Text = "查找"
        '
        'txtShipName
        '
        Me.txtShipName.BackColor = System.Drawing.Color.Lavender
        Me.txtShipName.Location = New System.Drawing.Point(176, 14)
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.ReadOnly = True
        Me.txtShipName.Size = New System.Drawing.Size(130, 21)
        Me.txtShipName.TabIndex = 3
        Me.txtShipName.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(144, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "船名"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(418, 74)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(30, 18)
        Me.Label17.TabIndex = 464
        Me.Label17.Text = "货名"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbPlace
        '
        Me.cbPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlace.Enabled = False
        Me.cbPlace.Location = New System.Drawing.Point(68, 72)
        Me.cbPlace.Name = "cbPlace"
        Me.cbPlace.Size = New System.Drawing.Size(120, 20)
        Me.cbPlace.TabIndex = 488
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(12, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 18)
        Me.Label8.TabIndex = 489
        Me.Label8.Text = "工作地点"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C1DBGE
        '
        Me.C1DBGE.AllowColMove = False
        Me.C1DBGE.CaptionHeight = 18
        Me.C1DBGE.ColumnFooters = True
        Me.C1DBGE.Dock = System.Windows.Forms.DockStyle.Left
        Me.C1DBGE.FetchRowStyles = True
        Me.C1DBGE.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGE.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBGE.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGE.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBGE.Name = "C1DBGE"
        Me.C1DBGE.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGE.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGE.PreviewInfo.ZoomFactor = 75
        Me.C1DBGE.RecordSelectorWidth = 16
        Me.C1DBGE.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1DBGE.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBGE.RowHeight = 16
        Me.C1DBGE.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBGE.Size = New System.Drawing.Size(362, 360)
        Me.C1DBGE.TabIndex = 490
        Me.C1DBGE.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{BackColor:Window;}Footer{}Capti" & _
        "on{AlignHorz:Center;}Style9{}Normal{}HighlightRow{ForeColor:HighlightText;BackCo" & _
        "lor:Highlight;}Style14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Headi" & _
        "ng{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;Ba" & _
        "ckColor:Control;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Styl" & _
        "e1{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView AllowColMove=""False"" " & _
        "Name="""" CaptionHeight=""18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" Fetc" & _
        "hRowStyles=""True"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" DefRe" & _
        "cSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRect>0, " & _
        "0, 358, 356</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style2"" " & _
        "me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""" & _
        "EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><Footer" & _
        "Style parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><H" & _
        "eadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightR" & _
        "ow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle pa" & _
        "rent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Sty" & _
        "le11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me" & _
        "=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent=" & _
        """"" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" m" & _
        "e=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""" & _
        "Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Ed" & _
        "itor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""Ev" & _
        "enRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""Record" & _
        "Selector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""" & _
        "Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layo" & _
        "ut>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 358" & _
        ", 356</ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFoote" & _
        "rStyle parent="""" me=""Style15"" /></Blob>"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.C1DBGI)
        Me.Panel1.Controls.Add(Me.Splitter1)
        Me.Panel1.Controls.Add(Me.C1DBGE)
        Me.Panel1.Location = New System.Drawing.Point(2, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(682, 360)
        Me.Panel1.TabIndex = 491
        '
        'C1DBGI
        '
        Me.C1DBGI.AllowColMove = False
        Me.C1DBGI.AllowUpdate = False
        Me.C1DBGI.CaptionHeight = 18
        Me.C1DBGI.ColumnFooters = True
        Me.C1DBGI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DBGI.FetchRowStyles = True
        Me.C1DBGI.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGI.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.C1DBGI.Location = New System.Drawing.Point(365, 0)
        Me.C1DBGI.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBGI.Name = "C1DBGI"
        Me.C1DBGI.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGI.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGI.PreviewInfo.ZoomFactor = 75
        Me.C1DBGI.RecordSelectorWidth = 16
        Me.C1DBGI.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1DBGI.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBGI.RowHeight = 16
        Me.C1DBGI.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBGI.Size = New System.Drawing.Size(317, 360)
        Me.C1DBGI.TabIndex = 492
        Me.C1DBGI.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{BackColor:Window;}Footer{}Capti" & _
        "on{AlignHorz:Center;}Style9{}Normal{}HighlightRow{ForeColor:HighlightText;BackCo" & _
        "lor:Highlight;}Style14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Headi" & _
        "ng{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;Ba" & _
        "ckColor:Control;}Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Styl" & _
        "e1{}</Data></Styles><Splits><C1.Win.C1TrueDBGrid.MergeView AllowColMove=""False"" " & _
        "Name="""" CaptionHeight=""18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" Fetc" & _
        "hRowStyles=""True"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""16"" DefRe" & _
        "cSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRect>0, " & _
        "0, 313, 356</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style2"" " & _
        "me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""" & _
        "EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><Footer" & _
        "Style parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><H" & _
        "eadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightR" & _
        "ow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle pa" & _
        "rent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Sty" & _
        "le11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me" & _
        "=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent=" & _
        """"" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" m" & _
        "e=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""" & _
        "Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Ed" & _
        "itor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""Ev" & _
        "enRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""Record" & _
        "Selector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""" & _
        "Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layo" & _
        "ut>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 313" & _
        ", 356</ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFoote" & _
        "rStyle parent="""" me=""Style15"" /></Blob>"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(362, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 360)
        Me.Splitter1.TabIndex = 491
        Me.Splitter1.TabStop = False
        '
        'btnSelectAll
        '
        Me.btnSelectAll.Location = New System.Drawing.Point(12, 466)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(60, 22)
        Me.btnSelectAll.TabIndex = 492
        Me.btnSelectAll.Text = "全选"
        '
        'btnClearAll
        '
        Me.btnClearAll.Location = New System.Drawing.Point(78, 466)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(60, 22)
        Me.btnClearAll.TabIndex = 493
        Me.btnClearAll.Text = "全清"
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(384, 468)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(70, 22)
        Me.btnExit.TabIndex = 594
        Me.btnExit.Text = "退出(&X)"
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(300, 468)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(75, 22)
        Me.btnImport.TabIndex = 595
        Me.btnImport.Text = "确认导入"
        '
        'ccbGoods
        '
        Me.ccbGoods.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.ccbGoods.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows
        Me.ccbGoods.Caption = ""
        Me.ccbGoods.CaptionHeight = 17
        Me.ccbGoods.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ccbGoods.ColumnCaptionHeight = 18
        Me.ccbGoods.ColumnFooterHeight = 18
        Me.ccbGoods.ContentHeight = 16
        Me.ccbGoods.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.ccbGoods.EditorBackColor = System.Drawing.SystemColors.Window
        Me.ccbGoods.EditorFont = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ccbGoods.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.ccbGoods.EditorHeight = 16
        Me.ccbGoods.GapHeight = 2
        Me.ccbGoods.Images.Add(CType(resources.GetObject("resource2"), System.Drawing.Image))
        Me.ccbGoods.ItemHeight = 15
        Me.ccbGoods.Location = New System.Drawing.Point(450, 72)
        Me.ccbGoods.MatchEntryTimeout = CType(2000, Long)
        Me.ccbGoods.MaxDropDownItems = CType(20, Short)
        Me.ccbGoods.MaxLength = 32767
        Me.ccbGoods.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.ccbGoods.Name = "ccbGoods"
        Me.ccbGoods.PartialRightColumn = False
        Me.ccbGoods.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.ccbGoods.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.ccbGoods.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.ccbGoods.Size = New System.Drawing.Size(200, 22)
        Me.ccbGoods.TabIndex = 642
        Me.ccbGoods.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
        "ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{BackColor:Wind" & _
        "ow;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{AlignHorz:N" & _
        "ear;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Cente" & _
        "r;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Sty" & _
        "le10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowC" & _
        "olSelect=""False"" Name="""" CaptionHeight=""18"" ColumnCaptionHeight=""18"" ColumnFoote" & _
        "rHeight=""18"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRect>0, 0," & _
        " 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar><HScrollBar><Hei" & _
        "ght>17</Height></HScrollBar><CaptionStyle parent=""Style2"" me=""Style9"" /><EvenRow" & _
        "Style parent=""EvenRow"" me=""Style7"" /><FooterStyle parent=""Footer"" me=""Style3"" />" & _
        "<GroupStyle parent=""Group"" me=""Style11"" /><HeadingStyle parent=""Heading"" me=""Sty" & _
        "le2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style6"" /><InactiveStyle par" & _
        "ent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style8"" /><RecordS" & _
        "electorStyle parent=""RecordSelector"" me=""Style10"" /><SelectedStyle parent=""Selec" & _
        "ted"" me=""Style5"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1List.ListBoxV" & _
        "iew></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" " & _
        "me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=" & _
        """Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""S" & _
        "elected"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=" & _
        """EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""Rec" & _
        "ordSelector"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1<" & _
        "/vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout><DefaultRecSelWid" & _
        "th>16</DefaultRecSelWidth></Blob>"
        '
        'lbVoyage
        '
        Me.lbVoyage.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbVoyage.ForeColor = System.Drawing.Color.Black
        Me.lbVoyage.Location = New System.Drawing.Point(284, 50)
        Me.lbVoyage.Name = "lbVoyage"
        Me.lbVoyage.Size = New System.Drawing.Size(100, 17)
        Me.lbVoyage.TabIndex = 645
        '
        'lbShipName
        '
        Me.lbShipName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbShipName.ForeColor = System.Drawing.Color.Black
        Me.lbShipName.Location = New System.Drawing.Point(148, 50)
        Me.lbShipName.Name = "lbShipName"
        Me.lbShipName.Size = New System.Drawing.Size(100, 17)
        Me.lbShipName.TabIndex = 644
        '
        'lbShip
        '
        Me.lbShip.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbShip.ForeColor = System.Drawing.Color.Black
        Me.lbShip.Location = New System.Drawing.Point(12, 50)
        Me.lbShip.Name = "lbShip"
        Me.lbShip.Size = New System.Drawing.Size(100, 17)
        Me.lbShip.TabIndex = 643
        '
        'lbOuter
        '
        Me.lbOuter.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbOuter.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbOuter.Location = New System.Drawing.Point(418, 50)
        Me.lbOuter.Name = "lbOuter"
        Me.lbOuter.Size = New System.Drawing.Size(132, 17)
        Me.lbOuter.TabIndex = 646
        '
        'lbNo
        '
        Me.lbNo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbNo.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbNo.Location = New System.Drawing.Point(554, 50)
        Me.lbNo.Name = "lbNo"
        Me.lbNo.Size = New System.Drawing.Size(128, 17)
        Me.lbNo.TabIndex = 647
        '
        'cbConsign
        '
        Me.cbConsign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConsign.Location = New System.Drawing.Point(266, 72)
        Me.cbConsign.MaxDropDownItems = 20
        Me.cbConsign.Name = "cbConsign"
        Me.cbConsign.Size = New System.Drawing.Size(130, 20)
        Me.cbConsign.TabIndex = 648
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(210, 74)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(54, 18)
        Me.Label22.TabIndex = 649
        Me.Label22.Text = "原货代"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmConLoadTally_Choochoo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(686, 498)
        Me.Controls.Add(Me.cbConsign)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.lbNo)
        Me.Controls.Add(Me.lbOuter)
        Me.Controls.Add(Me.lbVoyage)
        Me.Controls.Add(Me.lbShipName)
        Me.Controls.Add(Me.lbShip)
        Me.Controls.Add(Me.ccbGoods)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClearAll)
        Me.Controls.Add(Me.btnSelectAll)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cbPlace)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConLoadTally_Choochoo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "装拆箱外部数据火车大列导入"
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.C1DBGE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.C1DBGI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccbGoods, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim strEdiID, strBlno As String '查找关键数据
    Dim sqlConsign As String
    Dim dvConsign As DataView
    Public blSave As Boolean

    Private Sub FrmConLoadTally_Choochoo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbConsign.Enabled = False
        sqlConsign = "SELECT TB_Code,CODE_SHIP_AGENT,SHIPAGENT_SHORT,SHIPAGENT_ENG FROM CODE_SHIP_AGENT where Mark <> '1' OR Mark IS NULL ORDER BY SHIPAGENT_SHORT"
        dvConsign = Filldata(sqlConsign)
        cbConsign.DataSource = dvConsign
        cbConsign.DisplayMember = "SHIPAGENT_SHORT"
        cbConsign.ValueMember = "TB_Code"
        Dim sqlCodeGoods As String
        sqlCodeGoods = "select Goods from CodeGoods order by Goods"
        Me.ccbGoods.DataSource = Filldata(sqlCodeGoods)
        Me.ccbGoods.DisplayMember = "Goods"
        Me.ccbGoods.ValueMember = "Goods"
        Me.ccbGoods.AutoSize = True
        Dim sqlYard As String
        Dim dvYard As DataView
        sqlYard = "SELECT Code_Yard_ID, Code_Yard_Name, CodePrefix,DeptCode FROM Code_Yard where DeptCode like '" & G_DeptCode & "%' ORDER BY Code_Yard_ID"
        dvYard = Filldata(sqlYard)
        Me.cbPlace.DataSource = dvYard
        Me.cbPlace.DisplayMember = "Code_Yard_Name"
        Me.cbPlace.ValueMember = "Code_Yard_ID"
        Me.cbPlace.SelectedValue = "01" '只有港内场站操作
        If Me.cbPlace.SelectedIndex = -1 OrElse G_DeptCode > dvYard(Me.cbPlace.SelectedIndex)("DeptCode") Then
            Me.btnImport.Enabled = False
        End If
        InitGridE()
        InitGridI()
    End Sub

    Dim sqlOutCon As String
    Dim dvOutCon As DataView
    Dim dsOutCon As New DataSet

    Private Sub InitGridE()
        sqlOutCon = "SELECT DISTINCT '0' Mark,A.CTN_NO,B.CTN_SIZETYPE,B.CTN_STATUS,B.CTN_SRALNO,B.CTN_PKGSNUM,B.CTN_NETWEIGHT,B.CARGO_MEASUREMENT " & _
                    " FROM TB_CONLOAD_REL A INNER JOIN TB_CONLOAD_CON B ON A.EDIID = B.EDIID AND A.CTN_NO = B.CTN_NO" & _
                    " WHERE A.BLNO = '" & strBlno & "' AND A.EDIID = '" & strEdiID & "'"
        dvOutCon = Getdata2(sqlOutCon, dsOutCon)
        Me.C1DBGE.DataSource = dvOutCon
        Me.C1DBGE.Columns("Mark").Caption = "选择"
        Me.C1DBGE.Columns("CTN_NO").Caption = "箱号"
        Me.C1DBGE.Columns("CTN_SIZETYPE").Caption = "箱型尺寸"
        Me.C1DBGE.Columns("CTN_STATUS").Caption = "状态"
        Me.C1DBGE.Columns("CTN_SRALNO").Caption = "铅封号"
        Me.C1DBGE.Columns("CTN_PKGSNUM").Caption = "件数"
        Me.C1DBGE.Columns("CTN_NETWEIGHT").Caption = "货重"
        Me.C1DBGE.Columns("CARGO_MEASUREMENT").Caption = "尺码"
        SetDGWidth(Me.C1DBGE)
        Me.C1DBGE.Columns("Mark").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
        Me.C1DBGE.Columns("Mark").ValueItems.Translate = True
        Dim vi As C1.Win.C1TrueDBGrid.ValueItem
        vi = New C1.Win.C1TrueDBGrid.ValueItem("0", False)
        Me.C1DBGE.Columns("Mark").ValueItems.Values.Add(vi)
        vi = New C1.Win.C1TrueDBGrid.ValueItem("1", True)
        Me.C1DBGE.Columns("Mark").ValueItems.Values.Add(vi)
        Dim i As Integer
        For i = 1 To dvOutCon.Table.Columns.Count - 1
            Me.C1DBGE.Splits(0).DisplayColumns(i).Locked = True
        Next
        Me.C1DBGE.Columns("CTN_NO").FooterText = "计" & dvOutCon.Count & "箱"
    End Sub

    Dim sqlInCon As String
    Dim dvInCon As DataView
    Dim dsInCon As New DataSet

    Private Sub InitGridI()
        sqlInCon = "SELECT CONTAINER_NO,NEWSEALNO,SIZE_CON,CONTAINER_TYPE,AMOUNT,NetWeight,VOLUME,StateC FROM CON_LOAD_TALLY_LIST WHERE CHI_VESSEL = '" & Me.lbShip.Text & "' AND Voyage = '" & Me.lbVoyage.Text & "' AND CodeYard = '" & Me.cbPlace.SelectedValue & "' AND BLNO = '" & strBlno & "'"
        dvInCon = Getdata2(sqlInCon, dsInCon)
        Me.C1DBGI.DataSource = dvInCon
        Me.C1DBGI.Columns("CONTAINER_NO").Caption = "箱号"
        Me.C1DBGI.Columns("NEWSEALNO").Caption = "铅封号"
        Me.C1DBGI.Columns("SIZE_CON").Caption = "尺寸"
        Me.C1DBGI.Columns("CONTAINER_TYPE").Caption = "箱型"
        Me.C1DBGI.Columns("AMOUNT").Caption = "件数"
        Me.C1DBGI.Columns("NetWeight").Caption = "货重"
        Me.C1DBGI.Columns("VOLUME").Caption = "体积"
        SetDGWidth(Me.C1DBGI)
        Me.C1DBGI.Splits(0).DisplayColumns("StateC").Visible = False
        Me.C1DBGI.Columns("CONTAINER_NO").FooterText = "计" & dvInCon.Count & "箱"
    End Sub

    Dim sqlBillExist As String
    Dim dvBillExist As DataView
    Dim blOutFind, blInFind As Boolean  '内外数据查找标志

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Me.lbOuter.Text = "开始查找……"
        blOutFind = False
        If Me.txtBlno.Text <> "" Then
            sqlBillExist = "select EDIID,BLNO,CODE_VESSEL,VOYAGE,CODE_DISCHARGEPORT,CODE_DELIVERY from TB_CONLOAD where BLNO = '" & Me.txtBlno.Text & "' and CODE_CONLOADPLACE = 'HC' order by EDIID desc"
            '测试
            'sqlBillExist = "select EDIID,BLNO,CODE_VESSEL,VOYAGE from TB_CONLOAD where BLNO = '" & Me.txtBlno.Text & "' order by EDIID desc"
            dvBillExist = Filldata(sqlBillExist)
            Me.lbOuter.Text = ""
            If dvBillExist.Count = 1 Then
                '正常找到
                OutData()
                blOutFind = True
            ElseIf dvBillExist.Count > 1 Then
                dvBillExist.RowFilter = "CODE_VESSEL='" & dvBillExist(0)("CODE_VESSEL") & "' and VOYAGE='" & dvBillExist(0)("VOYAGE") & "'"
                If dvBillExist.Count = 1 Then
                    '不同船次的重复
                    If Me.txtShip.Text <> "" OrElse Me.txtVoyage.Text <> "" Then
                        sqlBillExist = "select EDIID,BLNO,CODE_VESSEL,VOYAGE from TB_CONLOAD where (CODE_VESSEL = '" & Me.txtShip.Text & "' or VOYAGE = '" & Me.txtVoyage.Text & "') and BLNO = '" & Me.txtBlno.Text & "' and CODE_CONLOADPLACE = 'HC' order by EDIID desc"
                        dvBillExist = Filldata(sqlBillExist)
                        If dvBillExist.Count > 0 Then
                            '这时只要找到就可以
                            OutData()
                            blOutFind = True
                        Else
                            Me.lbOuter.Text = "外部查找失败"
                            Me.txtBlno.Focus()
                        End If
                    Else
                        Me.lbOuter.Text = "提单重复，可以确定船次精确查找"
                        OutData()
                        blOutFind = True
                    End If
                Else
                    '数据重复，不影响
                    OutData()
                    blOutFind = True
                End If
            Else
                Me.lbOuter.Text = "外部查找失败"
                Me.txtBlno.Focus()
            End If
            InData()
        Else
            Me.txtBlno.Focus()
            MessageBox.Show("请确定提单号", "提示")
        End If
    End Sub

    Private Sub OutData()
        strEdiID = dvBillExist(0)("EDIID")
        strBlno = dvBillExist(0)("BLNO")
        Me.lbShip.Text = dvBillExist(0)("CODE_VESSEL")
        Me.lbShipName.Text = GetShipChaName(Me.lbShip.Text)
        Me.lbVoyage.Text = dvBillExist(0)("VOYAGE")
        '报文箱记录
        sqlOutCon = "SELECT DISTINCT '0' Mark,A.CTN_NO,B.CTN_SIZETYPE,B.CTN_STATUS,B.CTN_SRALNO,B.CTN_PKGSNUM,B.CTN_NETWEIGHT,B.CARGO_MEASUREMENT " & _
            " FROM TB_CONLOAD_REL A INNER JOIN TB_CONLOAD_CON B ON A.EDIID = B.EDIID AND A.CTN_NO = B.CTN_NO" & _
            " WHERE A.BLNO = '" & strBlno & "' AND A.EDIID = '" & strEdiID & "'"
        dvOutCon = Getdata2(sqlOutCon, dsOutCon)
        SetDGWidth(Me.C1DBGE, 2)
        Me.C1DBGE.Columns("CTN_NO").FooterText = "计" & dvOutCon.Count & "箱"
        '货物信息
        Dim sqlOutCargo As String
        Dim dvOutCargo As DataView
        sqlOutCargo = "SELECT CARGOSEQUENCENO,CARGODESCR,AgentCode FROM TB_CONLOAD_CARGO where BLNO = '" & strBlno & "' AND EDIID = '" & strEdiID & "'"
        dvOutCargo = Filldata(sqlOutCargo)
        Me.ccbGoods.SelectedIndex = -1
        Me.cbConsign.SelectedIndex = -1
        If dvOutCargo.Count > 0 Then
            If Not IsDBNull(dvOutCargo(0)("CARGODESCR")) Then
                Me.ccbGoods.Text = dvOutCargo(0)("CARGODESCR")
            End If
            If Not IsDBNull(dvOutCargo(0)("AgentCode")) Then
                Me.cbConsign.SelectedValue = dvOutCargo(0)("AgentCode")
            End If
        End If
    End Sub

    Dim blSure As Boolean   '内部提单是否可导
    Private Sub InData()
        blInFind = False
        blSure = False
        Dim sqlInBill As String
        Dim dvInBill As DataView
        sqlInBill = "SELECT NO,GoodsCha,StateB FROM CON_LOAD_TALLY WHERE BLNO = '" & strBlno & "' AND WORK_PLACE = '" & Me.cbPlace.SelectedValue & "' AND CHI_VESSEL = '" & Me.lbShip.Text & "' AND Voyage = '" & Me.lbVoyage.Text & "'"
        dvInBill = Filldata(sqlInBill)
        If dvInBill.Count > 0 Then
            If dvInBill(0)("StateB") <= "1" Then
                Me.lbNo.Text = dvInBill(0)("NO")
                If Not IsDBNull(dvInBill(0)("GoodsCha")) Then
                    Me.ccbGoods.Text = dvInBill(0)("GoodsCha")
                End If
                blSure = True
            Else
                Me.lbNo.Text = "提单已出证，不可导"
            End If
            blInFind = True
        Else
            Me.lbNo.Text = ""
            blSure = True
        End If
        '提单箱数据
        sqlInCon = "SELECT CONTAINER_NO,NEWSEALNO,SIZE_CON,CONTAINER_TYPE,AMOUNT,NetWeight,VOLUME,StateC FROM CON_LOAD_TALLY_LIST WHERE CHI_VESSEL = '" & Me.lbShip.Text & "' AND Voyage = '" & Me.lbVoyage.Text & "' AND CodeYard = '" & Me.cbPlace.SelectedValue & "' AND BLNO = '" & strBlno & "'"
        dvInCon = Getdata2(sqlInCon, dsInCon)
        SetDGWidth(Me.C1DBGI, 2)
        Me.C1DBGI.Columns("CONTAINER_NO").FooterText = "计" & dvInCon.Count & "箱"
    End Sub
    Private Function GetShipChaName(ByVal strShipCode As String)
        Dim strShipName As String
        If strShipCode.Length > 0 Then
            Dim sqlTemp As String
            Dim dvTemp As DataView
            sqlTemp = "SELECT SPCODE,CHI_VESSEL,Eng_VESSEL FROM Code_SHIPNAME WHERE SPCODE = '" & strShipCode & "'"
            dvTemp = Filldata(sqlTemp)
            If dvTemp.Count > 0 Then
                If Not IsDBNull(dvTemp(0)("CHI_VESSEL")) Then
                    strShipName = dvTemp(0)("CHI_VESSEL")
                End If
                If Not IsDBNull(dvTemp(0)("Eng_VESSEL")) Then
                    strShipName += "/" & dvTemp(0)("Eng_VESSEL")
                End If
            End If
        End If
        Return strShipName
    End Function

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        If blOutFind AndAlso blSure Then
            '箱信息保存准备
            Dim sqlUpdateIn As String
            Dim dsUpdateIn As New DataSet
            Dim daUpdateIn As New SqlClient.SqlDataAdapter
            Dim dvUpdateIn As DataView
            Dim newRow As DataRow
            sqlUpdateIn = "SELECT CON_LOAD_TALLY_LIST_ID,CHI_VESSEL,Voyage,BLNO,CodeYard, CONTAINER_NO,NEWSEALNO,SIZE_CON,CONTAINER_TYPE,AMOUNT,NetWeight,VOLUME,Checked,CheckTime,StateC,USER_NAME FROM CON_LOAD_TALLY_LIST WHERE CHI_VESSEL = '" & Me.lbShip.Text & "' AND Voyage = '" & Me.lbVoyage.Text & "' AND CodeYard = '" & Me.cbPlace.SelectedValue & "' AND BLNO = '" & strBlno & "'"
            dvUpdateIn = Updatedata(daUpdateIn, sqlUpdateIn, dsUpdateIn)
            dvUpdateIn.Table.Columns("CHI_VESSEL").DefaultValue = Me.lbShip.Text
            dvUpdateIn.Table.Columns("Voyage").DefaultValue = Me.lbVoyage.Text
            dvUpdateIn.Table.Columns("BLNO").DefaultValue = strBlno
            dvUpdateIn.Table.Columns("CodeYard").DefaultValue = Me.cbPlace.SelectedValue
            dvUpdateIn.Table.Columns("Checked").DefaultValue = "1"  '查验过
            dvUpdateIn.Table.Columns("CheckTime").DefaultValue = Now
            dvUpdateIn.Table.Columns("StateC").DefaultValue = "1"   '场站状态
            dvUpdateIn.Table.Columns("USER_NAME").DefaultValue = G_User
            Getdata2(sqlInCon, dsInCon)
            Me.C1DBGI.Columns("CONTAINER_NO").FooterText = "计" & dvInCon.Count & "箱"
            '导入外部数据的箱信息
            Dim i, j As Integer
            If dvInCon.Count = 0 Then   '内部无箱，不检查
                For i = 0 To dvOutCon.Count - 1
                    Me.C1DBGE.Row = i
                    If Me.C1DBGE.Columns("Mark").Value = "1" Then
                        newRow = dvUpdateIn.Table.NewRow
                        newRow("CONTAINER_NO") = Me.C1DBGE.Columns("CTN_NO").Text
                        newRow("NEWSEALNO") = Me.C1DBGE.Columns("CTN_SRALNO").Text
                        If Me.C1DBGE.Columns("CTN_SIZETYPE").Text Like "##[A-Z][A-Z]" Then
                            newRow("SIZE_CON") = Me.C1DBGE.Columns("CTN_SIZETYPE").Text.Substring(0, 2)
                            newRow("CONTAINER_TYPE") = Me.C1DBGE.Columns("CTN_SIZETYPE").Text.Substring(2)
                        End If
                        newRow("AMOUNT") = Me.C1DBGE.Columns("CTN_PKGSNUM").Value
                        newRow("NetWeight") = Me.C1DBGE.Columns("CTN_NETWEIGHT").Value
                        newRow("VOLUME") = Me.C1DBGE.Columns("CARGO_MEASUREMENT").Value
                        dvUpdateIn.Table.Rows.Add(newRow)
                    End If
                Next
            Else    '内部有箱，要检查
                For i = 0 To dvOutCon.Count - 1
                    Me.C1DBGE.Row = i
                    If Me.C1DBGE.Columns("Mark").Value = "1" Then
                        For j = 0 To dvInCon.Count - 1
                            Me.C1DBGI.Row = j
                            If Me.C1DBGI.Columns("CONTAINER_NO").Text = Me.C1DBGE.Columns("CTN_NO").Text Then
                                Exit For
                            End If
                        Next
                        If j >= dvInCon.Count Then  '不重复，可导
                            newRow = dvUpdateIn.Table.NewRow
                            newRow("CONTAINER_NO") = Me.C1DBGE.Columns("CTN_NO").Text
                            newRow("NEWSEALNO") = Me.C1DBGE.Columns("CTN_SRALNO").Text
                            If Me.C1DBGE.Columns("CTN_SIZETYPE").Text Like "##[A-Z][A-Z]" Then
                                newRow("SIZE_CON") = Me.C1DBGE.Columns("CTN_SIZETYPE").Text.Substring(0, 2)
                                newRow("CONTAINER_TYPE") = Me.C1DBGE.Columns("CTN_SIZETYPE").Text.Substring(2)
                            End If
                            newRow("AMOUNT") = Me.C1DBGE.Columns("CTN_PKGSNUM").Value
                            newRow("NetWeight") = Me.C1DBGE.Columns("CTN_NETWEIGHT").Value
                            newRow("VOLUME") = Me.C1DBGE.Columns("CARGO_MEASUREMENT").Value
                            dvUpdateIn.Table.Rows.Add(newRow)
                        End If
                    End If
                Next
            End If
            '保存导入数据
            If dvUpdateIn.Count > dvInCon.Count Then    '增加了箱号
                If MessageBox.Show("确定导入箱数据吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                    If blInFind = False Then
                        '需要新加提单
                        Dim strUnloadPort, strDelivery As String
                        If Not IsDBNull(dvBillExist(0)("CODE_DISCHARGEPORT")) Then
                            strUnloadPort = dvBillExist(0)("CODE_DISCHARGEPORT")
                        End If
                        If Not IsDBNull(dvBillExist(0)("CODE_DELIVERY")) Then
                            strDelivery = dvBillExist(0)("CODE_DELIVERY")
                        End If
                        Dim strNewNo As String
                        Dim sqlGetBill As String
                        strNewNo = GetAutoNo(Me.cbPlace.SelectedValue)    '生成理货单编号
                        sqlGetBill = "INSERT INTO CON_LOAD_TALLY (CHI_VESSEL, Voyage, InOutPort, NO, WORK_PLACE, TIME_FROM, BLNO,CodeLoadPort,CodeUnloadPort,CodeDelivery,GoodsCha,WORKTYPE,CODE_TALLY_TYPE, USER_NAME, CODE_CON_CONSIGN, StateB) " & _
                                                   "VALUES ('" & Me.lbShip.Text & "', '" & Me.lbVoyage.Text & "', '1','" & strNewNo & "', '" & Me.cbPlace.SelectedValue & "', '" & Now & "', '" & strBlno & "','CNLYG','" & strUnloadPort & "','" & strDelivery & "','" & Me.ccbGoods.Text & "', '2', '7', '" & G_User & "', '" & dvConsign(Me.cbConsign.SelectedIndex)("CODE_SHIP_AGENT") & "', '1')"
                        ExecSql(sqlGetBill)
                    Else
                        '提单不管
                    End If
                    daUpdateIn.Update(dsUpdateIn)
                    '删除外部数据
                    Dim sqlClearOut As String
                    sqlClearOut = "Exec Sp_TbConLoad_Bill_Del '" & Me.lbShip.Text & "','" & Me.lbVoyage.Text & "','" & strBlno & "'"
                    ExecSql(sqlClearOut)
                    '更新界面
                    Me.btnFind_Click(sender, e)
                    blSave = True
                End If
            End If
        End If

    End Sub

    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click
        Dim i As Integer
        Me.C1DBGE.Focus()
        For i = 0 To dvOutCon.Count - 1
            Me.C1DBGE.Row = i
            Me.C1DBGE.Columns("Mark").Value = "1"
        Next
        Me.btnSelectAll.Focus()
    End Sub

    Private Sub btnClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearAll.Click
        Dim i As Integer
        Me.C1DBGE.Focus()
        For i = 0 To dvOutCon.Count - 1
            Me.C1DBGE.Row = i
            Me.C1DBGE.Columns("Mark").Value = "0"
        Next
        Me.btnClearAll.Focus()
    End Sub

    Private Sub txtBlno_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBlno.Leave
        Me.txtBlno.Text = Me.txtBlno.Text.Trim().ToUpper()
    End Sub

    Private Sub txtShip_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtShip.Leave
        Me.txtShip.Text = Me.txtShip.Text.Trim().ToUpper()
        Me.txtShipName.Text = GetShipChaName(Me.txtShip.Text)
    End Sub

    Private Sub txtVoyage_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVoyage.Leave
        Me.txtVoyage.Text = Me.txtVoyage.Text.Trim().ToUpper
    End Sub

    Private Sub txtShip_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtShip.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtVoyage.Focus()
        End If
    End Sub

    Private Sub txtVoyage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVoyage.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtBlno.Focus()
        End If
    End Sub

    Private Sub txtBlno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBlno.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnFind.Focus()
            Me.btnFind_Click(sender, e)
        End If
    End Sub
End Class