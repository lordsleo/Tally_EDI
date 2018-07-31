Imports TALLY.DBControl
Public Class FrmFinishShipStatistics
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim SqlStr As String  '条件语句
    Dim SelectStr As String
    Dim DynaStr As String '可变的条件设计
    Dim FirmStr As String '不变的条件设计
    Dim ColNum As Integer '不显示的列数

    Dim strDept As String
    Dim statDate As Date
    Dim OffsetTime As Integer = 6   '时间偏移量（小时）

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
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    Friend WithEvents tbbtnFind As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnQuery As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnAdd As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnEdit As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnDelete As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnPrint As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnExport As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnQuit As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents mnuQuery As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrint As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExport As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAdd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuQuit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFind As System.Windows.Forms.MenuItem
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCompile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbnNew As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents C1Arch As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmFinishShipStatistics))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Dim GridLines2 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Me.ToolBar = New System.Windows.Forms.ToolBar
        Me.tbbtnFind = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuery = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep1 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnAdd = New System.Windows.Forms.ToolBarButton
        Me.tbbtnEdit = New System.Windows.Forms.ToolBarButton
        Me.tbbtnDelete = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep2 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnPrint = New System.Windows.Forms.ToolBarButton
        Me.tbbtnExport = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep3 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuit = New System.Windows.Forms.ToolBarButton
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.mnuQuery = New System.Windows.Forms.MenuItem
        Me.mnuEdit = New System.Windows.Forms.MenuItem
        Me.mnuSep1 = New System.Windows.Forms.MenuItem
        Me.mnuPrint = New System.Windows.Forms.MenuItem
        Me.mnuExport = New System.Windows.Forms.MenuItem
        Me.mnuSep2 = New System.Windows.Forms.MenuItem
        Me.mnuAdd = New System.Windows.Forms.MenuItem
        Me.mnuQuit = New System.Windows.Forms.MenuItem
        Me.mnuFind = New System.Windows.Forms.MenuItem
        Me.MainMenu = New System.Windows.Forms.MainMenu
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuCompile = New System.Windows.Forms.MenuItem
        Me.mnuDelete = New System.Windows.Forms.MenuItem
        Me.mnuHelp = New System.Windows.Forms.MenuItem
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.rbnNew = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.C1Arch = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.C1Arch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar
        '
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnFind, Me.tbbtnQuery, Me.tbbtnSep1, Me.tbbtnAdd, Me.tbbtnEdit, Me.tbbtnDelete, Me.tbbtnSep2, Me.tbbtnPrint, Me.tbbtnExport, Me.tbbtnSep3, Me.tbbtnQuit})
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(712, 41)
        Me.ToolBar.TabIndex = 16
        '
        'tbbtnFind
        '
        Me.tbbtnFind.ImageIndex = 0
        Me.tbbtnFind.Text = "检索"
        Me.tbbtnFind.ToolTipText = "检索"
        '
        'tbbtnQuery
        '
        Me.tbbtnQuery.ImageIndex = 1
        Me.tbbtnQuery.Text = "查看"
        Me.tbbtnQuery.ToolTipText = "查看"
        Me.tbbtnQuery.Visible = False
        '
        'tbbtnSep1
        '
        Me.tbbtnSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnAdd
        '
        Me.tbbtnAdd.ImageIndex = 2
        Me.tbbtnAdd.Text = "处理"
        Me.tbbtnAdd.ToolTipText = "处理"
        '
        'tbbtnEdit
        '
        Me.tbbtnEdit.ImageIndex = 3
        Me.tbbtnEdit.Text = "保存"
        Me.tbbtnEdit.ToolTipText = "保存统计数据"
        '
        'tbbtnDelete
        '
        Me.tbbtnDelete.ImageIndex = 4
        Me.tbbtnDelete.Text = "删除"
        Me.tbbtnDelete.ToolTipText = "删除"
        Me.tbbtnDelete.Visible = False
        '
        'tbbtnSep2
        '
        Me.tbbtnSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnPrint
        '
        Me.tbbtnPrint.ImageIndex = 5
        Me.tbbtnPrint.Text = "打印"
        Me.tbbtnPrint.ToolTipText = "打印"
        '
        'tbbtnExport
        '
        Me.tbbtnExport.ImageIndex = 6
        Me.tbbtnExport.Text = "导出"
        Me.tbbtnExport.ToolTipText = "导出Excel"
        '
        'tbbtnSep3
        '
        Me.tbbtnSep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnQuit
        '
        Me.tbbtnQuit.ImageIndex = 7
        Me.tbbtnQuit.Text = "退出"
        Me.tbbtnQuit.ToolTipText = "退出"
        '
        'ImageList
        '
        Me.ImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'mnuQuery
        '
        Me.mnuQuery.Index = 1
        Me.mnuQuery.Text = "查看(&Q)"
        Me.mnuQuery.Visible = False
        '
        'mnuEdit
        '
        Me.mnuEdit.Index = 1
        Me.mnuEdit.Text = "保存(&S)"
        '
        'mnuSep1
        '
        Me.mnuSep1.Index = 2
        Me.mnuSep1.Text = "-"
        '
        'mnuPrint
        '
        Me.mnuPrint.Index = 3
        Me.mnuPrint.Text = "打印(&P)..."
        '
        'mnuExport
        '
        Me.mnuExport.Index = 4
        Me.mnuExport.Text = "导出(&E)"
        '
        'mnuSep2
        '
        Me.mnuSep2.Index = 5
        Me.mnuSep2.Text = "-"
        '
        'mnuAdd
        '
        Me.mnuAdd.Index = 0
        Me.mnuAdd.Text = "处理(&D)"
        '
        'mnuQuit
        '
        Me.mnuQuit.Index = 6
        Me.mnuQuit.Text = "退出(&X)"
        '
        'mnuFind
        '
        Me.mnuFind.Index = 0
        Me.mnuFind.Text = "检索(&F)"
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuCompile, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFind, Me.mnuQuery, Me.mnuSep1, Me.mnuPrint, Me.mnuExport, Me.mnuSep2, Me.mnuQuit})
        Me.mnuFile.Text = "文件(&F)"
        '
        'mnuCompile
        '
        Me.mnuCompile.Index = 1
        Me.mnuCompile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAdd, Me.mnuEdit, Me.mnuDelete})
        Me.mnuCompile.Text = "编辑(&E)"
        '
        'mnuDelete
        '
        Me.mnuDelete.Index = 2
        Me.mnuDelete.Text = "删除(&D)"
        Me.mnuDelete.Visible = False
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.Text = "帮助(&H)"
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.AllowSort = True
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.CollapseColor = System.Drawing.Color.Black
        Me.C1DBG.DataChanged = False
        Me.C1DBG.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DBG.ExpandColor = System.Drawing.Color.Black
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.ShowOptionsDialog = False
        Me.C1DBG.RecordSelectorWidth = 16
        GridLines1.Color = System.Drawing.Color.DarkGray
        GridLines1.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG.RowDivider = GridLines1
        Me.C1DBG.RowHeight = 16
        Me.C1DBG.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG.ScrollTips = False
        Me.C1DBG.Size = New System.Drawing.Size(180, 345)
        Me.C1DBG.TabIndex = 17
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{}Od" & _
        "dRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Center;Borde" & _
        "r:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Style10{Al" & _
        "ignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.MergeView Name="""" AllowRowSizing=""None"" CaptionHeight=""18"" ColumnC" & _
        "aptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" Record" & _
        "SelectorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollG" & _
        "roup=""1""><ClientRect>0, 0, 176, 341</ClientRect><BorderSide>0</BorderSide><Capti" & _
        "onStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" " & _
        "/><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar" & _
        """ me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""" & _
        "Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRow" & _
        "Style parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""S" & _
        "tyle4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=" & _
        """RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><" & _
        "Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><Na" & _
        "medStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><" & _
        "Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Sty" & _
        "le parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Styl" & _
        "e parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Styl" & _
        "e parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style par" & _
        "ent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Sty" & _
        "le parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSp" & _
        "lits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWid" & _
        "th><ClientArea>0, 0, 176, 341</ClientArea></Blob>"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.rbnNew)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(712, 31)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'RadioButton1
        '
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton1.Location = New System.Drawing.Point(504, 8)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadioButton1.Size = New System.Drawing.Size(134, 20)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.Text = "打印导出原有统计表"
        Me.RadioButton1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'rbnNew
        '
        Me.rbnNew.Checked = True
        Me.rbnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbnNew.Location = New System.Drawing.Point(6, 8)
        Me.rbnNew.Name = "rbnNew"
        Me.rbnNew.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rbnNew.Size = New System.Drawing.Size(134, 20)
        Me.rbnNew.TabIndex = 0
        Me.rbnNew.TabStop = True
        Me.rbnNew.Text = "打印导出最新统计表"
        Me.rbnNew.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.C1DBG)
        Me.Panel1.Controls.Add(Me.Splitter1)
        Me.Panel1.Controls.Add(Me.C1Arch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(712, 345)
        Me.Panel1.TabIndex = 21
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter1.Location = New System.Drawing.Point(180, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Splitter1.Size = New System.Drawing.Size(2, 345)
        Me.Splitter1.TabIndex = 19
        Me.Splitter1.TabStop = False
        '
        'C1Arch
        '
        Me.C1Arch.AllowFilter = False
        Me.C1Arch.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1Arch.AllowSort = True
        Me.C1Arch.AllowUpdate = False
        Me.C1Arch.CaptionHeight = 18
        Me.C1Arch.CollapseColor = System.Drawing.Color.Black
        Me.C1Arch.DataChanged = False
        Me.C1Arch.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1Arch.Dock = System.Windows.Forms.DockStyle.Right
        Me.C1Arch.ExpandColor = System.Drawing.Color.Black
        Me.C1Arch.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1Arch.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.C1Arch.Location = New System.Drawing.Point(182, 0)
        Me.C1Arch.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1Arch.Name = "C1Arch"
        Me.C1Arch.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1Arch.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1Arch.PreviewInfo.ZoomFactor = 75
        Me.C1Arch.PrintInfo.ShowOptionsDialog = False
        Me.C1Arch.RecordSelectorWidth = 16
        GridLines2.Color = System.Drawing.Color.DarkGray
        GridLines2.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1Arch.RowDivider = GridLines2
        Me.C1Arch.RowHeight = 16
        Me.C1Arch.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Arch.ScrollTips = False
        Me.C1Arch.Size = New System.Drawing.Size(530, 345)
        Me.C1Arch.TabIndex = 18
        Me.C1Arch.Text = "C1TrueDBGrid1"
        Me.C1Arch.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}Od" & _
        "dRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Bord" & _
        "er:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{Al" & _
        "ignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.MergeView Name="""" AllowRowSizing=""None"" CaptionHeight=""18"" ColumnC" & _
        "aptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" Record" & _
        "SelectorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollG" & _
        "roup=""1""><ClientRect>0, 0, 526, 341</ClientRect><BorderSide>0</BorderSide><Capti" & _
        "onStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" " & _
        "/><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar" & _
        """ me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""" & _
        "Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRow" & _
        "Style parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""S" & _
        "tyle4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=" & _
        """RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><" & _
        "Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><Na" & _
        "medStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><" & _
        "Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Sty" & _
        "le parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Styl" & _
        "e parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Styl" & _
        "e parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style par" & _
        "ent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Sty" & _
        "le parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSp" & _
        "lits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWid" & _
        "th><ClientArea>0, 0, 526, 341</ClientArea></Blob>"
        '
        'FrmFinishShipStatistics
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 417)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolBar)
        Me.Menu = Me.MainMenu
        Me.Name = "FrmFinishShipStatistics"
        Me.Text = "分部门完船情况统计表信息"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.C1Arch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim dsArch As New DataSet
    Dim sqlArch As String
    Dim printMark As Boolean

    Private Sub FrmFinishShipStatistics_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call preview("WL10_8") '*****************权限设计 '*************要修改模块号
        Me.Text = Me.Text & "_" & G_DeptName
        'FirmStr = " Order by ID DESC"  '" Use_Comp Like '" & Trim(G_DeptCode) & "%' and Hide_Company Like '" & Trim(G_Company) & "%' order by ID DESC" 
        DynaStr = " 2>1 " '设计其它初始条件    在检索后不需要的条件 ***************要修改 或 其它条件
        strDept = G_DeptName
        statDate = DateAdd(DateInterval.Month, -1, Now)
        DynaStr = " DEPT_CODE like '" & G_DeptCode & "%' and datediff(yy, '" & statDate & "', dateAdd(hh, " & OffsetTime & ", WORKTIME_END))=0 and datediff(mm, '" & statDate & "', dateAdd(hh, " & OffsetTime & ", WORKTIME_END))=0 order by DEPT_CODE, WORKTIME_END "
        'DynaStr = "1=1 order by DEPT_CODE, WORKTIME_END "   '默认的排序规则
        Call myDataGrid()

        Me.C1DBG.Caption = "最新统计数据"
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色

        Me.C1Arch.Caption = "原有统计数据"
        Me.C1Arch.ColumnFooters = True
        Me.C1Arch.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1Arch.SelectedStyle.BackColor = System.Drawing.Color.BlueViolet   '设计选择纪录底色
    End Sub

    Private Sub myDataGrid()
        Dim strsql As String
        Dim i As Integer
        Dim strsql2 As String
        Try
            '不显示的列名在最前面
            strsql = "select * from View_FinishVessel where " & DynaStr '******要修改

            Me.C1DBG.DataSource = Getdata(strsql, ds)  ' class dbcontrol getdata fuction
            ColNum = 6 '不显示的列数 '******要修改
            Table_Name = "View_FinishVessel" '操作的数据库表名 ''******要修改

            For i = 0 To ColNum - 1 '设定不显示的列数
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Visible = False
            Next

            Call SetColumnCaption(C1DBG) '设计列标题
            Call SetColumnWidth(C1DBG) '设计列宽度
            'If ds.Tables(0).Rows.Count > 0 Then
            '    Call SetColumnSum("1=1") '设计合计列
            'End If
            Me.C1DBG.Columns.Item(ColNum).FooterText = "合计" & ds.Tables(0).Rows.Count & "条"

            strsql2 = "select * from Statis_FinishShip where " & DynaStr
            Me.C1Arch.DataSource = Getdata(strsql2, dsArch)
            For i = 0 To ColNum - 1 '设定不显示的列数
                Me.C1Arch.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Call SetColumnCaption(Me.C1Arch)   '设计列标题
            Call SetColumnWidth(Me.C1Arch)   '设计列宽度
            Me.C1Arch.Columns.Item(ColNum).FooterText = "合计" & dsArch.Tables(0).Rows.Count & "条"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaption(ByRef CompOne As C1.Win.C1TrueDBGrid.C1TrueDBGrid)

        CompOne.Columns("SHIPAGENT_CHA").Caption = "船代公司"
        CompOne.Columns("Trade").Caption = "内外贸"
        CompOne.Columns("StatDate").Caption = "统计年月"
        CompOne.Columns("FILE_NO").Caption = "编号"
        CompOne.Columns("BERTHNO").Caption = "泊位号"
        CompOne.Columns("CHI_VESSEL").Caption = "船名"
        CompOne.Columns("NATIONALITY_CHA").Caption = "国籍"
        CompOne.Columns("GOODS").Caption = "货名"
        CompOne.Columns("InOutPort_Name").Caption = "进出口"
        CompOne.Columns("FromPort").Caption = "上一港名"
        CompOne.Columns("ToPort").Caption = "下一港名"
        CompOne.Columns("YuanPeiAmount1").Caption = "集装箱原配件数"
        CompOne.Columns("YuanPeiAmount2").Caption = "件杂货原配件数"

        CompOne.Columns("YuanPeiTons1").Caption = "集装箱原配吨数"
        CompOne.Columns("YuanPeiTons2").Caption = "件杂货原配吨数"
        CompOne.Columns("YuanPeiTons3").Caption = "散化原配吨数"
        CompOne.Columns("WanChuanAmount1").Caption = "集装箱完船件数"
        CompOne.Columns("WanChuanAmount2").Caption = "件杂货完船件数"
        CompOne.Columns("WanChuanAmount3").Caption = "散化完船件数"

        CompOne.Columns("WanChuanTons2").Caption = "件杂货完船吨数"
        CompOne.Columns("WanChuanTons3").Caption = "散化完船吨数"
        CompOne.Columns("WORKTIME_BEGIN").Caption = "进船时间"
        CompOne.Columns("WORKTIME_END").Caption = "完船时间"
        CompOne.Columns("Money").Caption = "收入"
        CompOne.Columns("DEPT_NAME").Caption = "理货部门"

        'Dim sqla As New SqlClient.SqlDataAdapter()
        'Dim sqlc As New SqlClient.SqlCommand()
        'Dim dset As New DataSet()
        'Dim str As String
        'Dim i As Integer
        'Dim j As Integer
        'Try
        '    str = "select Field_Eng,Field_Cha From Field_Att where Table_Name='" & Table_Name & "'"
        '    sqlconn.ConnectionString = conn
        '    sqlc.Connection = sqlconn
        '    sqlc.CommandText = str
        '    sqla.SelectCommand = sqlc
        '    dset.Reset()
        '    sqla.Fill(dset)
        '    i = ColNum

        '    Do While i < Me.C1DBG.Columns.Count
        '        j = 0
        '        For j = 0 To dset.Tables(0).Rows.Count - 1

        '            If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = _
        '                Upper(Trim(Me.C1DBG.Columns.Item(i).DataField.ToString)) Then
        '                Me.C1DBG.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
        '                Exit For
        '            End If
        '        Next
        '        i = i + 1
        '    Loop
        '    sqlconn.Close()
        'Catch ex As System.Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub SetColumnSum(ByVal sql As String)
        On Error GoTo Err
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
        Dim dset2 As New DataSet
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Dim m As Integer
        Dim num As Double
        str = "select Field_Eng,Field_Type,IsOrNoSum From Field_Att where Table_Name='" & Trim(Table_Name) & "'"
        sqlconn.ConnectionString = conn
        sqlc.Connection = sqlconn
        sqlc.CommandText = str
        sqla.SelectCommand = sqlc
        dset.Reset()
        sqla.Fill(dset)

        i = ColNum
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBG.Columns.Item(ColNum).FooterText = "合计 共" & ds.Tables(0).Rows.Count & "条"
        Do While i < Me.C1DBG.Columns.Count
            j = 0
            For j = 0 To dset.Tables(0).Rows.Count - 1

                If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBG.Columns.Item(i).DataField.ToString)) _
                    And Upper(Trim(dset.Tables(0).Rows(j)("Field_Type"))) = "N" And Trim(dset.Tables(0).Rows(j)("IsOrNoSum")) = "1" Then

                    num = 0
                    For m = 0 To ds.Tables(0).Rows.Count - 1
                        num = num + ds.Tables(0).Rows(m)(i)
                    Next
                    Me.C1DBG.Columns.Item(i).FooterText = CType(num, String)
                    Exit For
                End If
            Next
            i = i + 1
        Loop

        sqlconn.Close()
        Exit Sub
Err:
        Resume Next

    End Sub

    Private Sub mnuFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFind.Click
        'Dim FrmFind As New FrmFind()
        'FrmFind.ShowDialog()
        'If Flag = 0 Then
        '    SelectStr = ""
        '    Call myDataGrid(SelectStr, " (" & Sql_Find & ")  " & FirmStr)  '可能要修改
        '    SqlStr = " (" & Sql_Find & ")  " & FirmStr '可能要修改
        'ElseIf Flag = 2 Then
        '    SelectStr = ""
        '    Call myDataGrid(SelectStr, DynaStr & FirmStr)  '可能要修改
        '    SqlStr = DynaStr & FirmStr '可能要修改
        'End If
    End Sub

    Private Sub mnuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdd.Click
        Dim FrmDeal As New FrmFinishShipStatistics_Deal    '***********要修改
        Try
            FrmDeal.ShowDialog()
            If FrmDeal.Flag = True Then
                DynaStr = " DEPT_CODE='" & FrmDeal.cbDepart.SelectedValue & "' and datediff(yy, '" & FrmDeal.dtpTime.Value & "', dateAdd(hh, " & OffsetTime & ", WORKTIME_END))=0 and datediff(mm, '" & FrmDeal.dtpTime.Value & "', dateAdd(hh, " & OffsetTime & ", WORKTIME_END))=0 order by DEPT_CODE, WORKTIME_END "
                statDate = FrmDeal.dtpTime.Value
                strDept = FrmDeal.cbDepart.Text

                Call myDataGrid()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrint.Click
        'Call PrintExcel()
        printMark = False
        If Me.rbnNew.Checked = True Then
            Call GetSheetExcel(ds.Tables(0).Rows.Count, Me.C1DBG)
        Else
            Call GetSheetExcel(dsArch.Tables(0).Rows.Count, Me.C1Arch)
        End If
    End Sub

    Private Sub PrintExcel() '打印到Excel        

        Dim Row As Integer
        Dim Col As Integer

        Try
            Call MakeExcel()

            Row = ds.Tables(0).Rows.Count + 4
            Col = Me.C1DBG.Columns.Count - ColNum
            '**************画边框
            For Row = 2 To ds.Tables(0).Rows.Count + 4 '画列
                xlSheet.Range(xlSheet.Cells(Row, 1), xlSheet.Cells(Row, C1DBG.Columns.Count - ColNum)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = 7
            Next Row
            For Col = 1 To C1DBG.Columns.Count - ColNum + 1 '画行
                xlSheet.Range(xlSheet.Cells(3, Col), xlSheet.Cells(ds.Tables(0).Rows.Count + 4, Col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7
            Next Col

        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try

    End Sub

    Private Sub GetSheetExcel(ByVal RecordCount As Integer, ByRef CompOne As C1.Win.C1TrueDBGrid.C1TrueDBGrid)
        Dim PathStr As String
        Dim FilePath As String
        Dim Row As Integer
        Dim Col As Integer
        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        Try
            FilePath = PathStr + "ReportCopy.xls"
            FileCopy(PathStr & "Report_Pan.xls", FilePath)

            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            xlBook = CType(xlApp.Workbooks.Open("" & FilePath & ""), Excel.Workbook)
            xlSheet = CType(xlBook.Worksheets(14), Excel.Worksheet)
            xlSheet.Select(14)
            xlApp.DisplayAlerts = False
            If printMark = False Then   '导出时显示
                xlSheet.Application.Visible = True
            End If

            Dim i As Integer = 0

            For Row = 0 To RecordCount - 1  '集装箱的
                If IsNumeric(CompOne.Columns("YuanPeiAmount1").CellText(Row)) Or IsNumeric(CompOne.Columns("YuanPeiTons1").CellText(Row)) Or IsNumeric(CompOne.Columns("WanChuanAmount1").CellText(Row)) Then
                    xlSheet.Cells(6 + i, 2) = CompOne.Columns("FILE_NO").CellText(Row)
                    xlSheet.Cells(6 + i, 3) = CompOne.Columns("BERTHNO").CellText(Row)
                    xlSheet.Cells(6 + i, 4) = CompOne.Columns("CHI_VESSEL").CellText(Row)
                    xlSheet.Cells(6 + i, 5) = CompOne.Columns("NATIONALITY_CHA").CellText(Row)
                    xlSheet.Cells(6 + i, 6) = CompOne.Columns("GOODS").CellText(Row)
                    xlSheet.Cells(6 + i, 7) = CompOne.Columns("InOutPort_Name").CellText(Row)
                    If CompOne.Columns("InOutPort_Name").CellText(Row) = "出口" Then
                        xlSheet.Cells(6 + i, 8) = CompOne.Columns("ToPort").CellText(Row)
                    Else
                        xlSheet.Cells(6 + i, 8) = CompOne.Columns("FromPort").CellText(Row)
                    End If
                    xlSheet.Cells(6 + i, 9) = CompOne.Columns("YuanPeiAmount1").CellText(Row)
                    xlSheet.Cells(6 + i, 10) = CompOne.Columns("YuanPeiTons1").CellText(Row)
                    xlSheet.Cells(6 + i, 11) = CompOne.Columns("WanChuanAmount1").CellText(Row)
                    xlSheet.Cells(6 + i, 13) = CompOne.Columns("WORKTIME_BEGIN").CellText(Row)
                    xlSheet.Cells(6 + i, 14) = CompOne.Columns("WORKTIME_END").CellText(Row)
                    xlSheet.Cells(6 + i, 15) = CompOne.Columns("SHIPAGENT_CHA").CellText(Row)
                    xlSheet.Cells(6 + i, 16) = CompOne.Columns("Money").CellText(Row)

                    xlSheet.Cells(6 + i, 1) = i + 1
                    i += 1
                End If
            Next
            For Row = 0 To RecordCount - 1      '件杂货的
                If IsNumeric(CompOne.Columns("YuanPeiAmount2").CellText(Row)) Or IsNumeric(CompOne.Columns("YuanPeiTons2").CellText(Row)) Or IsNumeric(CompOne.Columns("WanChuanAmount2").CellText(Row)) Or IsNumeric(CompOne.Columns("WanChuanTons2").CellText(Row)) Then
                    xlSheet.Cells(6 + i, 2) = CompOne.Columns("FILE_NO").CellText(Row)
                    xlSheet.Cells(6 + i, 3) = CompOne.Columns("BERTHNO").CellText(Row)
                    xlSheet.Cells(6 + i, 4) = CompOne.Columns("CHI_VESSEL").CellText(Row)
                    xlSheet.Cells(6 + i, 5) = CompOne.Columns("NATIONALITY_CHA").CellText(Row)
                    xlSheet.Cells(6 + i, 6) = CompOne.Columns("GOODS").CellText(Row)
                    xlSheet.Cells(6 + i, 7) = CompOne.Columns("InOutPort_Name").CellText(Row)
                    If CompOne.Columns("InOutPort_Name").CellText(Row) = "出口" Then
                        xlSheet.Cells(6 + i, 8) = CompOne.Columns("ToPort").CellText(Row)
                    Else
                        xlSheet.Cells(6 + i, 8) = CompOne.Columns("FromPort").CellText(Row)
                    End If
                    xlSheet.Cells(6 + i, 9) = CompOne.Columns("YuanPeiAmount2").CellText(Row)
                    xlSheet.Cells(6 + i, 10) = CompOne.Columns("YuanPeiTons2").CellText(Row)
                    xlSheet.Cells(6 + i, 11) = CompOne.Columns("WanChuanAmount2").CellText(Row)
                    xlSheet.Cells(6 + i, 12) = CompOne.Columns("WanChuanTons2").CellText(Row)
                    xlSheet.Cells(6 + i, 13) = CompOne.Columns("WORKTIME_BEGIN").CellText(Row)
                    xlSheet.Cells(6 + i, 14) = CompOne.Columns("WORKTIME_END").CellText(Row)
                    xlSheet.Cells(6 + i, 15) = CompOne.Columns("SHIPAGENT_CHA").CellText(Row)
                    xlSheet.Cells(6 + i, 16) = CompOne.Columns("Money").CellText(Row)

                    xlSheet.Cells(6 + i, 1) = i + 1
                    i += 1
                End If
            Next
            For Row = 0 To RecordCount - 1      '散化的
                If IsNumeric(CompOne.Columns("YuanPeiTons3").CellText(Row)) Or IsNumeric(CompOne.Columns("WanChuanAmount3").CellText(Row)) Or IsNumeric(CompOne.Columns("WanChuanTons3").CellText(Row)) Then
                    xlSheet.Cells(6 + i, 2) = CompOne.Columns("FILE_NO").CellText(Row)
                    xlSheet.Cells(6 + i, 3) = CompOne.Columns("BERTHNO").CellText(Row)
                    xlSheet.Cells(6 + i, 4) = CompOne.Columns("CHI_VESSEL").CellText(Row)
                    xlSheet.Cells(6 + i, 5) = CompOne.Columns("NATIONALITY_CHA").CellText(Row)
                    xlSheet.Cells(6 + i, 6) = CompOne.Columns("GOODS").CellText(Row)
                    xlSheet.Cells(6 + i, 7) = CompOne.Columns("InOutPort_Name").CellText(Row)
                    If CompOne.Columns("InOutPort_Name").CellText(Row) = "出口" Then
                        xlSheet.Cells(6 + i, 8) = CompOne.Columns("ToPort").CellText(Row)
                    Else
                        xlSheet.Cells(6 + i, 8) = CompOne.Columns("FromPort").CellText(Row)
                    End If
                    xlSheet.Cells(6 + i, 10) = CompOne.Columns("YuanPeiTons3").CellText(Row)
                    xlSheet.Cells(6 + i, 11) = CompOne.Columns("WanChuanAmount3").CellText(Row)
                    xlSheet.Cells(6 + i, 12) = CompOne.Columns("WanChuanTons3").CellText(Row)
                    xlSheet.Cells(6 + i, 13) = CompOne.Columns("WORKTIME_BEGIN").CellText(Row)
                    xlSheet.Cells(6 + i, 14) = CompOne.Columns("WORKTIME_END").CellText(Row)
                    xlSheet.Cells(6 + i, 15) = CompOne.Columns("SHIPAGENT_CHA").CellText(Row)
                    xlSheet.Cells(6 + i, 16) = CompOne.Columns("Money").CellText(Row)

                    xlSheet.Cells(6 + i, 1) = i + 1
                    i += 1
                End If
            Next
            For Row = 0 To RecordCount - 1      '全空的
                If Not IsNumeric(CompOne.Columns("YuanPeiAmount1").CellText(Row)) And Not IsNumeric(CompOne.Columns("YuanPeiTons1").CellText(Row)) And Not IsNumeric(CompOne.Columns("WanChuanAmount1").CellText(Row)) And Not IsNumeric(CompOne.Columns("YuanPeiAmount2").CellText(Row)) And Not IsNumeric(CompOne.Columns("YuanPeiTons2").CellText(Row)) And Not IsNumeric(CompOne.Columns("WanChuanAmount2").CellText(Row)) And Not IsNumeric(CompOne.Columns("WanChuanTons2").CellText(Row)) And Not IsNumeric(CompOne.Columns("YuanPeiTons3").CellText(Row)) And Not IsNumeric(CompOne.Columns("WanChuanAmount3").CellText(Row)) And Not IsNumeric(CompOne.Columns("WanChuanTons3").CellText(Row)) Then
                    xlSheet.Cells(6 + i, 2) = CompOne.Columns("FILE_NO").CellText(Row)
                    xlSheet.Cells(6 + i, 3) = CompOne.Columns("BERTHNO").CellText(Row)
                    xlSheet.Cells(6 + i, 4) = CompOne.Columns("CHI_VESSEL").CellText(Row)
                    xlSheet.Cells(6 + i, 5) = CompOne.Columns("NATIONALITY_CHA").CellText(Row)
                    xlSheet.Cells(6 + i, 6) = CompOne.Columns("GOODS").CellText(Row)
                    xlSheet.Cells(6 + i, 7) = CompOne.Columns("InOutPort_Name").CellText(Row)
                    If CompOne.Columns("InOutPort_Name").CellText(Row) = "出口" Then
                        xlSheet.Cells(6 + i, 8) = CompOne.Columns("ToPort").CellText(Row)
                    Else
                        xlSheet.Cells(6 + i, 8) = CompOne.Columns("FromPort").CellText(Row)
                    End If

                    xlSheet.Cells(6 + i, 13) = CompOne.Columns("WORKTIME_BEGIN").CellText(Row)
                    xlSheet.Cells(6 + i, 14) = CompOne.Columns("WORKTIME_END").CellText(Row)
                    xlSheet.Cells(6 + i, 15) = CompOne.Columns("SHIPAGENT_CHA").CellText(Row)
                    xlSheet.Cells(6 + i, 16) = CompOne.Columns("Money").CellText(Row)

                    xlSheet.Cells(6 + i, 1) = i + 1
                    i += 1
                End If
            Next

            For Row = 1 To i    '画行线
                If Row Mod 15 = 0 Or Row = i Then
                    xlSheet.Range(xlSheet.Cells(Row + 5, 1), xlSheet.Cells(Row + 5, 17)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = 12
                Else
                    xlSheet.Range(xlSheet.Cells(Row + 5, 1), xlSheet.Cells(Row + 5, 17)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = 1
                End If
            Next
            For Col = 1 To 18       '画列线
                If Col = 1 Or Col = 18 Then
                    xlSheet.Range(xlSheet.Cells(6, Col), xlSheet.Cells(i + 5, Col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 12
                Else
                    xlSheet.Range(xlSheet.Cells(6, Col), xlSheet.Cells(i + 5, Col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 1
                End If
            Next
            xlSheet.Cells(2, 1) = strDept
            Dim strDate As String
            strDate = statDate.Year & "年 " & statDate.Month & "月"
            xlSheet.Cells(2, 6) = strDate
            If printMark = True Then '打印时打印
                xlSheet.PrintOut()
                xlApp.Quit()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub mnuExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExport.Click
        'Call ExportExcel()
        printMark = False
        If Me.rbnNew.Checked = True Then
            Call GetSheetExcel(ds.Tables(0).Rows.Count, Me.C1DBG)
        Else
            Call GetSheetExcel(dsArch.Tables(0).Rows.Count, Me.C1Arch)
        End If
    End Sub

    Private Sub ExportExcel() '导出Excel        
        Call MakeExcel()
    End Sub

    Private Sub MakeExcel()
        Dim PathStr As String
        Dim FilePath As String
        Dim Row As Integer
        Dim Col As Integer
        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        Try
            FilePath = PathStr + "Report.xls"
            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            xlBook = CType(xlApp.Workbooks.Open("" & FilePath & ""), Excel.Workbook)
            xlSheet = CType(xlBook.Worksheets(1), Excel.Worksheet)
            xlApp.DisplayAlerts = False
            xlSheet.Application.Visible = True

            xlSheet.Cells(1, 1) = Me.Text() '标题

            For Col = ColNum To Me.C1DBG.Columns.Count - 1 '列标题
                xlSheet.Cells(3, Col - ColNum + 1) = Me.C1DBG.Columns(Col).Caption

            Next Col
            Me.C1DBG.MoveFirst()
            For Row = 0 To ds.Tables(0).Rows.Count - 1 '数据
                For Col = ColNum To Me.C1DBG.Columns.Count - 1
                    xlSheet.Cells(Row + 4, Col - ColNum + 1) = Me.C1DBG.Columns(Col).Text.ToString      'ds.Tables(0).Rows(Row)(Col)
                Next Col
                Me.C1DBG.MoveNext()
            Next Row
            If Me.C1DBG.ColumnFooters = True Then '合计项
                For Col = ColNum To Me.C1DBG.Columns.Count - 1
                    xlSheet.Cells(ds.Tables(0).Rows.Count + 4, Col - ColNum + 1) = Me.C1DBG.Columns(Col).FooterText
                Next Col
            End If
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try

    End Sub

    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
        TBar = 1
        Mnu = 1
        Me.Close()
    End Sub

    Private Sub ToolBar_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar.ButtonClick
        Select Case Me.ToolBar.Buttons.IndexOf(e.Button)
            Case 0
                mnuFind_Click(sender, e)
                'Case 1
                '    Call mnuQuery_Click(sender, e)
            Case 2

            Case 3
                Call mnuAdd_Click(sender, e)
            Case 4
                Call mnuEdit_Click(sender, e)
                'Case 5
                '    Call mnuDelete_Click(sender, e)
            Case 6

            Case 7
                Call mnuPrint_Click(sender, e)
            Case 8
                Call mnuExport_Click(sender, e)
            Case 9

            Case 10
                Call mnuQuit_Click(sender, e)
        End Select
    End Sub

    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        TBar = 1
        Mnu = 1
    End Sub

    Private Sub SetColumnWidth(ByRef CompOne As C1.Win.C1TrueDBGrid.C1TrueDBGrid)
        Try
            Dim j As Integer
            For j = 0 To CompOne.Columns.Count - 1
                CompOne.Splits(0).DisplayColumns.Item(j).AutoSize()
                CompOne.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                If CompOne.Splits(0).DisplayColumns.Item(j).Width < 65 Then
                    CompOne.Splits(0).DisplayColumns.Item(j).Width = 65
                Else
                    If CompOne.Splits(0).DisplayColumns.Item(j).Width > 130 Then
                        CompOne.Splits(0).DisplayColumns.Item(j).Width = 130
                    End If
                End If
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub preview(ByVal Func As String) '***************权限设计
        Dim sqlstr As String
        Dim Previewdv As DataView
        Dim Previewds As New DataSet
        Dim i As Integer
        sqlstr = " select FUNC_CODE_Add,FUNC_CODE_Change,FUNC_CODE_Del from View_UserPreview where PART_ID=" & G_Part_Id & " and FUNC_CODE='" & Upper(Func) & "' "
        Previewdv = Getdata(sqlstr, Previewds)
        If Previewdv.Count > 0 Then
            If Previewdv(i)("FUNC_CODE_Add") = 1 Then 'ADD 按钮可见
                ToolBar.Buttons.Item(3).Enabled = True
                mnuAdd.Enabled = True
            Else                                      'ADD 按钮不可见
                Me.ToolBar.Buttons.Item(3).Enabled = False
                mnuAdd.Enabled = False
            End If
            If Previewdv(i)("FUNC_CODE_Change") = 1 Then '修改 按钮可见
                Me.ToolBar.Buttons.Item(4).Enabled = True
                mnuEdit.Enabled = True
            Else                                          '修改 按钮不可见
                Me.ToolBar.Buttons.Item(4).Enabled = False
                mnuEdit.Enabled = False
            End If
            If Previewdv(i)("FUNC_CODE_Del") = 1 Then '删除 按钮可见
                Me.ToolBar.Buttons.Item(5).Enabled = True
                mnuDelete.Enabled = True
            Else                                     '删除 按钮不可见
                Me.ToolBar.Buttons.Item(5).Enabled = False
                mnuDelete.Enabled = False
            End If
        End If

    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        Dim sqlInsertStatis, sqlDelStatis As String
        If DynaStr <> "1=1" Then
            sqlDelStatis = "delete Statis_FinishShip where " & DynaStr
            sqlInsertStatis = "insert into Statis_FinishShip select * from View_FinishVessel where " & DynaStr
            If dsArch.Tables(0).Rows.Count > 0 Then
                If MessageBox.Show("原有的相关统计数据将更新为最新的，确定吗？", "警示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) Then
                    'ExecSql(sqlDelStatis)
                    'ExecSql(sqlInsertStatis)
                    ExecSql(sqlDelStatis & "  " & sqlInsertStatis)
                End If
            Else
                ExecSql(sqlInsertStatis)
            End If
            Call myDataGrid()
            MessageBox.Show("数据保存更新成功。", "提示")
        Else
            MessageBox.Show("请先处理统计数据", "提示")
        End If
    End Sub
End Class
