Imports TALLY.DBControl
Public Class FrmConImageCargo
    Inherits System.Windows.Forms.Form

    Dim dsShip As New DataSet() '船舶数据集
    Dim SqlStrShip As String  '船舶条件语句
    Dim FirmShip As String
    Dim SortShip As String
    Dim inoutstr As String

    Dim ds As New DataSet()
    Dim SqlStr As String  '条件语句
    Dim SelectStr As String
    Dim DynaStr As String '可变的条件设计
    Dim FirmStr As String '不变的条件设计
    Dim ColNum As Integer '不显示的列数

    Dim dwship As New DataView()
    Public Shared icount As Integer
    Public Shared InOutCode As String
    Dim strPort As String
    Dim strEngShipName As String

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
    Friend WithEvents S2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnOK As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSearch As System.Windows.Forms.ToolBarButton
    Friend WithEvents S3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuQuery As System.Windows.Forms.MenuItem
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
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
    Friend WithEvents mnuExport As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnEng As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuFind As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrint As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuQuit As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnSort As System.Windows.Forms.ToolBarButton
    Friend WithEvents S4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents mnuCompile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAdd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents GBV As System.Windows.Forms.GroupBox
    Friend WithEvents ToolBarV As System.Windows.Forms.ToolBar
    Friend WithEvents C1DBGV As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btResure As System.Windows.Forms.Button
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbbModiSeal As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuModiSeal As System.Windows.Forms.MenuItem
    Friend WithEvents tbbClearAll As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbSep4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuClearAll As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSeeClass As System.Windows.Forms.MenuItem
    Friend WithEvents tbbSeeClass As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuListAdd As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnListAdd As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSelect As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuLookUp As System.Windows.Forms.MenuItem
    Friend WithEvents mnuUnloadPort As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnUnloadPort As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbClearNull As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbnEditBayNo As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuBayNo As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExcelImage As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTray As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDiv As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnDiv As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuUnion As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnUnion As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuDelBill As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnDelBill As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnAccord As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuAccord As System.Windows.Forms.MenuItem
    Friend WithEvents mnuKeeper As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnKeeper As System.Windows.Forms.ToolBarButton
    Friend WithEvents Splitter3 As System.Windows.Forms.Splitter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConImageCargo))
        Me.S2 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnOK = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSearch = New System.Windows.Forms.ToolBarButton
        Me.S3 = New System.Windows.Forms.ToolBarButton
        Me.mnuQuery = New System.Windows.Forms.MenuItem
        Me.GB = New System.Windows.Forms.GroupBox
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label = New System.Windows.Forms.Label
        Me.ToolBar = New System.Windows.Forms.ToolBar
        Me.tbbtnFind = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuery = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSelect = New System.Windows.Forms.ToolBarButton
        Me.tbbSeeClass = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep1 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnAdd = New System.Windows.Forms.ToolBarButton
        Me.tbbtnListAdd = New System.Windows.Forms.ToolBarButton
        Me.tbbtnEdit = New System.Windows.Forms.ToolBarButton
        Me.tbbtnUnloadPort = New System.Windows.Forms.ToolBarButton
        Me.tbbtnAccord = New System.Windows.Forms.ToolBarButton
        Me.tbnEditBayNo = New System.Windows.Forms.ToolBarButton
        Me.tbbtnKeeper = New System.Windows.Forms.ToolBarButton
        Me.tbbModiSeal = New System.Windows.Forms.ToolBarButton
        Me.tbbtnDiv = New System.Windows.Forms.ToolBarButton
        Me.tbbtnUnion = New System.Windows.Forms.ToolBarButton
        Me.tbbtnExport = New System.Windows.Forms.ToolBarButton
        Me.tbbSep4 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnDelete = New System.Windows.Forms.ToolBarButton
        Me.tbbtnDelBill = New System.Windows.Forms.ToolBarButton
        Me.tbbClearAll = New System.Windows.Forms.ToolBarButton
        Me.tbbClearNull = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep2 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnPrint = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep3 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuit = New System.Windows.Forms.ToolBarButton
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.mnuExport = New System.Windows.Forms.MenuItem
        Me.tbbtnEng = New System.Windows.Forms.ToolBarButton
        Me.mnuFind = New System.Windows.Forms.MenuItem
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuLookUp = New System.Windows.Forms.MenuItem
        Me.mnuSeeClass = New System.Windows.Forms.MenuItem
        Me.mnuSep1 = New System.Windows.Forms.MenuItem
        Me.mnuPrint = New System.Windows.Forms.MenuItem
        Me.mnuSep2 = New System.Windows.Forms.MenuItem
        Me.mnuQuit = New System.Windows.Forms.MenuItem
        Me.tbbtnSort = New System.Windows.Forms.ToolBarButton
        Me.S4 = New System.Windows.Forms.ToolBarButton
        Me.MainMenu = New System.Windows.Forms.MainMenu
        Me.mnuCompile = New System.Windows.Forms.MenuItem
        Me.mnuAdd = New System.Windows.Forms.MenuItem
        Me.mnuListAdd = New System.Windows.Forms.MenuItem
        Me.mnuEdit = New System.Windows.Forms.MenuItem
        Me.mnuUnloadPort = New System.Windows.Forms.MenuItem
        Me.mnuAccord = New System.Windows.Forms.MenuItem
        Me.mnuModiSeal = New System.Windows.Forms.MenuItem
        Me.mnuDiv = New System.Windows.Forms.MenuItem
        Me.mnuUnion = New System.Windows.Forms.MenuItem
        Me.mnuDelete = New System.Windows.Forms.MenuItem
        Me.mnuClearAll = New System.Windows.Forms.MenuItem
        Me.mnuDelBill = New System.Windows.Forms.MenuItem
        Me.mnuBayNo = New System.Windows.Forms.MenuItem
        Me.mnuExcelImage = New System.Windows.Forms.MenuItem
        Me.mnuTray = New System.Windows.Forms.MenuItem
        Me.mnuKeeper = New System.Windows.Forms.MenuItem
        Me.mnuHelp = New System.Windows.Forms.MenuItem
        Me.GBV = New System.Windows.Forms.GroupBox
        Me.btResure = New System.Windows.Forms.Button
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolBarV = New System.Windows.Forms.ToolBar
        Me.C1DBGV = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Splitter3 = New System.Windows.Forms.Splitter
        Me.GB.SuspendLayout()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBV.SuspendLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'S2
        '
        Me.S2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnOK
        '
        Me.tbbtnOK.ImageIndex = 8
        Me.tbbtnOK.Text = "常规"
        '
        'tbbtnSearch
        '
        Me.tbbtnSearch.ImageIndex = 9
        Me.tbbtnSearch.Text = "检索"
        '
        'S3
        '
        Me.S3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'mnuQuery
        '
        Me.mnuQuery.Enabled = False
        Me.mnuQuery.Index = 1
        Me.mnuQuery.Text = "查看(&Q)"
        '
        'GB
        '
        Me.GB.Controls.Add(Me.C1DBG)
        Me.GB.Controls.Add(Me.Label)
        Me.GB.Controls.Add(Me.ToolBar)
        Me.GB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB.Location = New System.Drawing.Point(186, 0)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(842, 397)
        Me.GB.TabIndex = 9
        Me.GB.TabStop = False
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(3, 133)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.Size = New System.Drawing.Size(836, 261)
        Me.C1DBG.TabIndex = 10
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Back" & _
        "Color:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" AllowRowSizing=""None"" CaptionH" & _
        "eight=""18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""Dotted" & _
        "CellBorder"" RecordSelectorWidth=""21"" DefRecSelWidth=""21"" VerticalScrollGroup=""1""" & _
        " HorizontalScrollGroup=""1""><Height>257</Height><CaptionStyle parent=""Style2"" me=" & _
        """Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""Eve" & _
        "nRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterSty" & _
        "le parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><Head" & _
        "ingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow""" & _
        " me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle paren" & _
        "t=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style1" & _
        "1"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""S" & _
        "tyle1"" /><ClientRect>0, 0, 832, 257</ClientRect><BorderSide>0</BorderSide><Borde" & _
        "rStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles" & _
        "><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style par" & _
        "ent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style parent" & _
        "=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=" & _
        """Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=" & _
        """Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Head" & _
        "ing"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent" & _
        "=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</h" & _
        "orzSplits><Layout>None</Layout><DefaultRecSelWidth>21</DefaultRecSelWidth><Clien" & _
        "tArea>0, 0, 832, 257</ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" />" & _
        "<PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'Label
        '
        Me.Label.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label.Location = New System.Drawing.Point(3, 96)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(836, 37)
        Me.Label.TabIndex = 11
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolBar
        '
        Me.ToolBar.AutoSize = False
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnFind, Me.tbbtnQuery, Me.tbbtnSelect, Me.tbbSeeClass, Me.tbbtnSep1, Me.tbbtnAdd, Me.tbbtnListAdd, Me.tbbtnEdit, Me.tbbtnUnloadPort, Me.tbbtnAccord, Me.tbnEditBayNo, Me.tbbtnKeeper, Me.tbbModiSeal, Me.tbbtnDiv, Me.tbbtnUnion, Me.tbbtnExport, Me.tbbSep4, Me.tbbtnDelete, Me.tbbtnDelBill, Me.tbbClearAll, Me.tbbClearNull, Me.tbbtnSep2, Me.tbbtnPrint, Me.tbbtnSep3, Me.tbbtnQuit})
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.Enabled = False
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(3, 17)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(836, 79)
        Me.ToolBar.TabIndex = 9
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
        '
        'tbbtnSelect
        '
        Me.tbbtnSelect.ImageIndex = 9
        Me.tbbtnSelect.Text = "查找"
        Me.tbbtnSelect.ToolTipText = "查找"
        '
        'tbbSeeClass
        '
        Me.tbbSeeClass.ImageIndex = 21
        Me.tbbSeeClass.Text = "总览"
        Me.tbbSeeClass.ToolTipText = "总览"
        '
        'tbbtnSep1
        '
        Me.tbbtnSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnAdd
        '
        Me.tbbtnAdd.ImageIndex = 2
        Me.tbbtnAdd.Text = "增加"
        Me.tbbtnAdd.ToolTipText = "增加"
        '
        'tbbtnListAdd
        '
        Me.tbbtnListAdd.ImageIndex = 16
        Me.tbbtnListAdd.Text = "列表增加"
        Me.tbbtnListAdd.ToolTipText = "列表增加"
        '
        'tbbtnEdit
        '
        Me.tbbtnEdit.ImageIndex = 3
        Me.tbbtnEdit.Text = "编辑"
        Me.tbbtnEdit.ToolTipText = "编辑"
        '
        'tbbtnUnloadPort
        '
        Me.tbbtnUnloadPort.ImageIndex = 19
        Me.tbbtnUnloadPort.Text = "卸货港"
        Me.tbbtnUnloadPort.ToolTipText = "卸货港变更"
        '
        'tbbtnAccord
        '
        Me.tbbtnAccord.ImageIndex = 13
        Me.tbbtnAccord.Text = "同步"
        Me.tbbtnAccord.ToolTipText = "同步卸港目的地"
        '
        'tbnEditBayNo
        '
        Me.tbnEditBayNo.ImageIndex = 18
        Me.tbnEditBayNo.Text = "改贝位"
        Me.tbnEditBayNo.ToolTipText = "修改贝位号"
        '
        'tbbtnKeeper
        '
        Me.tbbtnKeeper.ImageIndex = 24
        Me.tbbtnKeeper.Text = "箱主复核"
        '
        'tbbModiSeal
        '
        Me.tbbModiSeal.ImageIndex = 12
        Me.tbbModiSeal.Text = "集中修改"
        Me.tbbModiSeal.ToolTipText = "集中修改"
        '
        'tbbtnDiv
        '
        Me.tbbtnDiv.ImageIndex = 27
        Me.tbbtnDiv.Text = "分船"
        Me.tbbtnDiv.ToolTipText = "将部分箱分至本船另一航次"
        '
        'tbbtnUnion
        '
        Me.tbbtnUnion.ImageIndex = 30
        Me.tbbtnUnion.Text = "并船"
        Me.tbbtnUnion.ToolTipText = "将该船箱信息并入另一航次"
        '
        'tbbtnExport
        '
        Me.tbbtnExport.ImageIndex = 33
        Me.tbbtnExport.Text = "转换"
        Me.tbbtnExport.ToolTipText = "进出口转换"
        '
        'tbbSep4
        '
        Me.tbbSep4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnDelete
        '
        Me.tbbtnDelete.ImageIndex = 4
        Me.tbbtnDelete.Text = "删除"
        Me.tbbtnDelete.ToolTipText = "删除"
        '
        'tbbtnDelBill
        '
        Me.tbbtnDelBill.ImageIndex = 25
        Me.tbbtnDelBill.Text = "删提单"
        Me.tbbtnDelBill.ToolTipText = "提单删除"
        '
        'tbbClearAll
        '
        Me.tbbClearAll.ImageIndex = 23
        Me.tbbClearAll.Text = "全清除"
        Me.tbbClearAll.ToolTipText = "清除当前所有信息"
        '
        'tbbClearNull
        '
        Me.tbbClearNull.ImageIndex = 22
        Me.tbbClearNull.Text = "删空箱"
        Me.tbbClearNull.ToolTipText = "删除所有空箱"
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
        'mnuExport
        '
        Me.mnuExport.Enabled = False
        Me.mnuExport.Index = 8
        Me.mnuExport.Text = "转换(&T)"
        '
        'tbbtnEng
        '
        Me.tbbtnEng.ImageIndex = 11
        Me.tbbtnEng.Text = "英文"
        '
        'mnuFind
        '
        Me.mnuFind.Enabled = False
        Me.mnuFind.Index = 0
        Me.mnuFind.Text = "检索(&F)"
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFind, Me.mnuQuery, Me.mnuLookUp, Me.mnuSeeClass, Me.mnuSep1, Me.mnuPrint, Me.mnuSep2, Me.mnuQuit})
        Me.mnuFile.Text = "文件(&F)"
        '
        'mnuLookUp
        '
        Me.mnuLookUp.Index = 2
        Me.mnuLookUp.Text = "查找(&L)"
        '
        'mnuSeeClass
        '
        Me.mnuSeeClass.Index = 3
        Me.mnuSeeClass.Text = "总览(&S)"
        '
        'mnuSep1
        '
        Me.mnuSep1.Index = 4
        Me.mnuSep1.Text = "-"
        '
        'mnuPrint
        '
        Me.mnuPrint.Enabled = False
        Me.mnuPrint.Index = 5
        Me.mnuPrint.Text = "打印(&P)..."
        '
        'mnuSep2
        '
        Me.mnuSep2.Index = 6
        Me.mnuSep2.Text = "-"
        '
        'mnuQuit
        '
        Me.mnuQuit.Index = 7
        Me.mnuQuit.Text = "退出(&X)"
        '
        'tbbtnSort
        '
        Me.tbbtnSort.ImageIndex = 10
        Me.tbbtnSort.Text = "排序"
        '
        'S4
        '
        Me.S4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuCompile, Me.mnuHelp})
        '
        'mnuCompile
        '
        Me.mnuCompile.Index = 1
        Me.mnuCompile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAdd, Me.mnuListAdd, Me.mnuEdit, Me.mnuUnloadPort, Me.mnuAccord, Me.mnuModiSeal, Me.mnuDiv, Me.mnuUnion, Me.mnuExport, Me.mnuDelete, Me.mnuClearAll, Me.mnuDelBill, Me.mnuBayNo, Me.mnuExcelImage, Me.mnuTray, Me.mnuKeeper})
        Me.mnuCompile.Text = "编辑(&E)"
        '
        'mnuAdd
        '
        Me.mnuAdd.Enabled = False
        Me.mnuAdd.Index = 0
        Me.mnuAdd.Text = "增加(&A)"
        '
        'mnuListAdd
        '
        Me.mnuListAdd.Index = 1
        Me.mnuListAdd.Text = "列表增加(&L)"
        '
        'mnuEdit
        '
        Me.mnuEdit.Enabled = False
        Me.mnuEdit.Index = 2
        Me.mnuEdit.Text = "编辑(&E)"
        '
        'mnuUnloadPort
        '
        Me.mnuUnloadPort.Index = 3
        Me.mnuUnloadPort.Text = "卸货港(&U)"
        '
        'mnuAccord
        '
        Me.mnuAccord.Index = 4
        Me.mnuAccord.Text = "同步卸港"
        '
        'mnuModiSeal
        '
        Me.mnuModiSeal.Index = 5
        Me.mnuModiSeal.Text = "集中修改(&M)"
        '
        'mnuDiv
        '
        Me.mnuDiv.Index = 6
        Me.mnuDiv.Text = "分船"
        '
        'mnuUnion
        '
        Me.mnuUnion.Index = 7
        Me.mnuUnion.Text = "并船"
        '
        'mnuDelete
        '
        Me.mnuDelete.Enabled = False
        Me.mnuDelete.Index = 9
        Me.mnuDelete.Text = "删除(&D)"
        '
        'mnuClearAll
        '
        Me.mnuClearAll.Index = 10
        Me.mnuClearAll.Text = "全部清除(&C)"
        '
        'mnuDelBill
        '
        Me.mnuDelBill.Index = 11
        Me.mnuDelBill.Text = "提单删除"
        '
        'mnuBayNo
        '
        Me.mnuBayNo.Index = 12
        Me.mnuBayNo.Text = "改贝位"
        '
        'mnuExcelImage
        '
        Me.mnuExcelImage.Index = 13
        Me.mnuExcelImage.Text = "导出Excel船图"
        '
        'mnuTray
        '
        Me.mnuTray.Index = 14
        Me.mnuTray.Text = "托盘处理"
        '
        'mnuKeeper
        '
        Me.mnuKeeper.Index = 15
        Me.mnuKeeper.Text = "经营人审查"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.Text = "帮助(&H)"
        '
        'GBV
        '
        Me.GBV.Controls.Add(Me.btResure)
        Me.GBV.Controls.Add(Me.txtVoyage)
        Me.GBV.Controls.Add(Me.Label2)
        Me.GBV.Controls.Add(Me.txtShipName)
        Me.GBV.Controls.Add(Me.Label1)
        Me.GBV.Controls.Add(Me.ToolBarV)
        Me.GBV.Controls.Add(Me.C1DBGV)
        Me.GBV.Dock = System.Windows.Forms.DockStyle.Left
        Me.GBV.Location = New System.Drawing.Point(0, 0)
        Me.GBV.Name = "GBV"
        Me.GBV.Size = New System.Drawing.Size(186, 397)
        Me.GBV.TabIndex = 8
        Me.GBV.TabStop = False
        '
        'btResure
        '
        Me.btResure.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btResure.Location = New System.Drawing.Point(122, 334)
        Me.btResure.Name = "btResure"
        Me.btResure.Size = New System.Drawing.Size(60, 22)
        Me.btResure.TabIndex = 12
        Me.btResure.Text = "查询"
        '
        'txtVoyage
        '
        Me.txtVoyage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtVoyage.Location = New System.Drawing.Point(50, 334)
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(88, 21)
        Me.txtVoyage.TabIndex = 11
        Me.txtVoyage.Text = ""
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(2, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "航次"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShipName
        '
        Me.txtShipName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtShipName.Location = New System.Drawing.Point(50, 312)
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.Size = New System.Drawing.Size(132, 21)
        Me.txtShipName.TabIndex = 10
        Me.txtShipName.Text = ""
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(2, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "船名"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolBarV
        '
        Me.ToolBarV.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnOK, Me.S2, Me.tbbtnSearch, Me.S3, Me.tbbtnSort, Me.S4, Me.tbbtnEng})
        Me.ToolBarV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBarV.DropDownArrows = True
        Me.ToolBarV.ImageList = Me.ImageList
        Me.ToolBarV.Location = New System.Drawing.Point(3, 353)
        Me.ToolBarV.Name = "ToolBarV"
        Me.ToolBarV.ShowToolTips = True
        Me.ToolBarV.Size = New System.Drawing.Size(180, 41)
        Me.ToolBarV.TabIndex = 1
        '
        'C1DBGV
        '
        Me.C1DBGV.AllowUpdate = False
        Me.C1DBGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGV.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGV.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.C1DBGV.Location = New System.Drawing.Point(2, 17)
        Me.C1DBGV.Name = "C1DBGV"
        Me.C1DBGV.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGV.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGV.PreviewInfo.ZoomFactor = 75
        Me.C1DBGV.Size = New System.Drawing.Size(182, 293)
        Me.C1DBGV.TabIndex = 0
        Me.C1DBGV.Text = "C1TrueDBGrid1"
        Me.C1DBGV.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
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
        "ctorWidth=""21"" DefRecSelWidth=""21"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><Height>289</Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorSty" & _
        "le parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><F" & _
        "ilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=" & _
        """Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Headi" & _
        "ng"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><Inacti" & _
        "veStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9""" & _
        " /><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle pa" & _
        "rent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0" & _
        ", 0, 178, 289</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderS" & _
        "tyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""" & _
        "Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Foot" & _
        "er"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactiv" & _
        "e"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /" & _
        "><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" " & _
        "/><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelecto" & _
        "r"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" " & _
        "/></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None" & _
        "</Layout><DefaultRecSelWidth>21</DefaultRecSelWidth><ClientArea>0, 0, 178, 289</" & _
        "ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle " & _
        "parent="""" me=""Style15"" /></Blob>"
        '
        'Splitter3
        '
        Me.Splitter3.BackColor = System.Drawing.Color.Maroon
        Me.Splitter3.Location = New System.Drawing.Point(186, 0)
        Me.Splitter3.Name = "Splitter3"
        Me.Splitter3.Size = New System.Drawing.Size(3, 397)
        Me.Splitter3.TabIndex = 15
        Me.Splitter3.TabStop = False
        '
        'FrmConImageCargo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(1028, 397)
        Me.Controls.Add(Me.Splitter3)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.GBV)
        Me.Menu = Me.MainMenu
        Me.Name = "FrmConImageCargo"
        Me.Text = "集装箱船图信息"
        Me.GB.ResumeLayout(False)
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBV.ResumeLayout(False)
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmConImageCargo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Text = Me.Text & "_" & G_DeptName
        SortShip = " Order by Ship_Statu,Dept_Code " '默认的排序 
        FirmShip = "where DEPT_CODE LIKE '" & G_DeptCode & "%'" '船舶不变的条件设计
        SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('0','1','2','3')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) "
        If G_User_Serial = "WLGCH" Then
            SqlStrShip = "where (DEPT_CODE LIKE '" & G_DeptCode & "%') "
        End If
        Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '*****************调用航次信息
        Me.C1DBGV.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue

        txtShipName.Text = G_ShipName
        txtVoyage.Text = G_Voyage
        txtShipName.Focus()
        Call btResure_Click(sender, e)

    End Sub

    Private Sub myDataGridShip(ByVal Sql As String) '**************航次信息
        Dim strsql As String
        Dim i As Integer
        strsql = "select SHIP_ID as ID ,SHIP_STATU,INOUTPORT,DEPT_CODE,ENG_VESSEL,CHI_VESSEL,VOYAGE,InOutPort_Name,Dept_Short from View_SSHip " '船舶条件语句 不改部分
        strsql = strsql & Sql
        Try
            Me.C1DBGV.DataSource = Getdata(strsql, dsShip)
            For i = 0 To 4 '设计部显示的列
                Me.C1DBGV.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Call SetColumnCaptionShip() '设计列标题
            Call SetColumnWidthShip() '设计列宽度
            If dsShip.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumShip(5)  '设计合计列
            End If
            Me.C1DBGV.FetchRowStyles = True
            Me.C1DBGV.Refresh()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaptionShip() '*****************航次标题
        Dim sqla As New SqlClient.SqlDataAdapter()
        Dim sqlc As New SqlClient.SqlCommand()
        Dim dset As New DataSet()
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Try
            str = "select Field_Eng,Field_Cha From Field_Att where Table_Name='View_SSHip'"
            sqlconn.ConnectionString = conn
            sqlc.Connection = sqlconn
            sqlc.CommandText = str
            sqla.SelectCommand = sqlc
            dset.Reset()
            sqla.Fill(dset)
            i = 4

            Do While i < Me.C1DBGV.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGV.Columns.Item(i).DataField.ToString)) Then
                        Me.C1DBGV.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
                        Exit For
                    End If
                Next
                i = i + 1
            Loop
            sqlconn.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnWidthShip() '************航次列宽
        Dim i As Integer
        Try

            Me.C1DBGV.Splits(0).DisplayColumns.Item(4).Width = Me.C1DBGV.Width / 2 - 25
            Me.C1DBGV.Splits(0).DisplayColumns.Item(5).Width = Me.C1DBGV.Width / 2 - 25
            Me.C1DBGV.Splits(0).DisplayColumns.Item(6).Width = 35
            Me.C1DBGV.Splits(0).DisplayColumns.Item(7).Width = 24
            Me.C1DBGV.Splits(0).DisplayColumns.Item(8).Width = 18

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnSumShip(ByVal Col As Integer) '****************航次汇总行

        Me.C1DBGV.ColumnFooters = True
        Me.C1DBGV.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGV.Columns.Item(Col).FooterText = "共 " & dsShip.Tables(0).Rows.Count & " 条"

    End Sub

    Private Sub ToolBarV_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBarV.ButtonClick
        Select Case Me.ToolBarV.Buttons.IndexOf(e.Button)

            Case 0
                SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('0','1','2','3')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) " '船舶可变的条件设计

                SortShip = " Order by Ship_Statu,Dept_Code "
                Call myDataGridShip(SqlStrShip & inoutstr & SortShip)


            Case 2
                Dim FrmFind As New FrmFind()
                Table_Name = "SSHIP"
                FrmFind.ShowDialog()

                If Flag = 0 Then
                    Call myDataGridShip(FirmShip & inoutstr & " and (" & Sql_Find & ")  " & SortShip)    '可能要修改
                    SqlStrShip = FirmStr & " and (" & Sql_Find & ")  "    '可能要修改
                ElseIf Flag = 2 Then
                    SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('0','1','2','3','4')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) "
                    '可能要修改
                    Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '可能要修改

                End If

            Case 4
                Dim FrmSort As New FrmSort()
                FrmSort.ShowDialog()
                If Len(Trim(SortStr)) > 0 Then
                    SortShip = " Order by " & SortStr
                End If
                Call myDataGridShip(SqlStrShip & inoutstr & SortShip)

            Case 6
                Me.C1DBGV.Splits(0).DisplayColumns.Item(4).Visible = True
                Me.C1DBGV.Splits(0).DisplayColumns.Item(5).Visible = False
                If dsShip.Tables(0).Rows.Count > 0 Then
                    Call SetColumnSumShip(4)  '设计合计列
                End If
                Me.C1DBGV.FetchRowStyles = True
                Me.C1DBGV.Refresh()
        End Select
    End Sub

    Private Sub C1DBGV_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBGV.FetchRowStyle
        Try
            If Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 1 Then
                e.CellStyle.BackColor = Color.White
            ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 2 Then
                e.CellStyle.BackColor = Color.PaleGreen
            ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 3 Then
                e.CellStyle.BackColor = Color.LemonChiffon
            ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 4 Then
                e.CellStyle.BackColor = Color.Pink
            ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 5 Then
                e.CellStyle.BackColor = Color.Red
            ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 0 Then
                e.CellStyle.BackColor = Color.Cyan
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub C1DBGV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBGV.DoubleClick
        On Error GoTo Err
        G_ShipName = Me.C1DBGV.Columns("CHI_VESSEL").Text
        G_Voyage = Me.C1DBGV.Columns("Voyage").Text
        Me.txtShipName.Text = Me.C1DBGV.Columns("CHI_VESSEL").Text
        Me.txtVoyage.Text = Me.C1DBGV.Columns("Voyage").Text

        Dim dsShip As New DataSet() '与前面的dsShip重名，不大好，
        Dim strsql As String

        Ship_ID = CType(Me.C1DBGV.Columns.Item("ID").Text.ToString, Integer)
        strsql = "select * from View_SSHIP where SHIP_ID=" & Ship_ID
        dwship = Getdata(strsql, dsShip)
        Label.Text = ""
        icount = dwship.Count

        If dsShip.Tables(0).DefaultView.Count > 0 Then
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))) > 0 Then
                Label.Text = Label.Text & "中文船名:" & Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL"))) > 0 Then
                Label.Text = Label.Text & "英文船名:" & Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL")) & " "
                strEngShipName = dsShip.Tables(0).Rows(0)("ENG_VESSEL")
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))) > 0 Then
                Label.Text = Label.Text & "航次:" & Trim(dsShip.Tables(0).Rows(0).Item("Voyage")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("InOutPort_Name"))) > 0 Then
                Label.Text = Label.Text & "进出口:" & Trim(dsShip.Tables(0).Rows(0).Item("InOutPort_Name")) & " "
            End If
            If dsShip.Tables(0).Rows(0).Item("InOutPort") = "0" Then
                InOutCode = "0"
                strPort = "CODE_LOAD_PORT"
            ElseIf dsShip.Tables(0).Rows(0).Item("InOutPort") = "1" Then
                InOutCode = "1"
                strPort = "CODE_UNLOAD_PORT"
            End If
           
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Trade"))) > 0 Then
                Label.Text = Label.Text & "内外贸:" & Trim(dsShip.Tables(0).Rows(0).Item("Trade")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("SHIP_TYPE"))) > 0 Then
                Label.Text = Label.Text & "国外轮:" & Trim(dsShip.Tables(0).Rows(0).Item("SHIP_TYPE")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("SHIPAGENT_CHA"))) > 0 Then
                Label.Text = Label.Text & "船代:" & Trim(dsShip.Tables(0).Rows(0).Item("SHIPAGENT_CHA")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("GOODS"))) > 0 Then
                Label.Text = Label.Text & "货名:" & Trim(dsShip.Tables(0).Rows(0).Item("GOODS")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Tons"))) > 0 Then
                Label.Text = Label.Text & "吨数:" & Trim(dsShip.Tables(0).Rows(0).Item("Tons")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("BerthNo"))) > 0 Then
                Label.Text = Label.Text & "泊位:" & Trim(dsShip.Tables(0).Rows(0).Item("BerthNo")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("File_No"))) > 0 Then
                Label.Text = Label.Text & "档案号:" & Trim(dsShip.Tables(0).Rows(0).Item("File_No")) & " "
            End If
        End If
        FirmStr = " and Ship_ID=" & Ship_ID & " Order by ID desc" '设计初始条件  在检索后不改变的条件  '***************要修改 或 2>1
        'FirmStr = " and Ship_ID=" & Ship_ID & ""
        DynaStr = " 2>1 " '设计其它初始条件    在检索后不需要的条件 ***************要修改 或 其它条件
        'SelectStr = " Top 20 * "
        'SelectStr = " ID, SHIP_ID, OVER_Height, Load_Port, Unload_Port, DELIVERY, FULLOREMPTY, " & _
        '    "USER_NAME, CHI_VESSEL, VOYAGE, CONTAINER_NO, SEALNO, EFL_Name, CODE_LOAD_PORT, CODE_UNLOAD_PORT, CODE_DELIVERY, " & _
        '    "BAYNO, SIZE_CON, CONTAINER_TYPE, BLNO, AMOUNT, " & _
        '    "GROSSWEIGHT, TEMPERATURE_SETTING, MIN_TEMPERATURE, " & _
        '    "MAX_TEMPERATURE, DANGER_MARK, DANGER_GRADE, Demo, ConDemo "
        SelectStr = " ID, SHIP_ID, OVER_Height, Load_Port, Unload_Port, DELIVERY, FULLOREMPTY,unload_mark, Moved," & _
            "USER_NAME, CHI_VESSEL, VOYAGE, CONTAINER_NO, BAYNO, SIZE_CON, CONTAINER_TYPE, EFL_Name, TEMPERATURE_SETTING, SEALNO, BLNO, CODE_LOAD_PORT, CODE_UNLOAD_PORT, CODE_DELIVERY, " & _
            "GROSSWEIGHT, CON_WEIGHT, DANGER_GRADE, TEMPERATURE_UNIT, MIN_TEMPERATURE, MAX_TEMPERATURE,Case Unload_Mark when '1' then '完' end 作业, Case Moved when '1' then '捣' end 捣箱 "
        SqlStr = DynaStr & FirmStr
        

        Me.ToolBar.Enabled = True
        Me.mnuAdd.Enabled = True
        Me.mnuDelete.Enabled = True
        Me.mnuEdit.Enabled = True
        Me.mnuFind.Enabled = True
        Me.mnuPrint.Enabled = True
        Me.mnuQuery.Enabled = True

        If InOutCode = "0" Then     '只能从进口导出到出口航次
            Me.mnuExport.Enabled = True
            Me.tbbtnExport.Enabled = True
        Else
            Me.mnuExport.Enabled = False
            Me.tbbtnExport.Enabled = False
        End If
        Call preview("WL4_4") '*****************权限设计 '*************要修改模块号
        Call myDataGrid(SelectStr, SqlStr)
        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色
        Me.C1DBG.FetchRowStyles = True
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub myDataGrid(ByVal SelStr As String, ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            '不显示的列名在最前面
            strsql = "select " & SelStr & "  from View_ConImage  where " & Sql '******要修改

            Me.C1DBG.DataSource = Getdata(strsql, ds)  ' class dbcontrol getdata fuction
            ColNum = 12 '不显示的列数 '******要修改
            Table_Name = "View_ConImage" '操作的数据库表名 ''******要修改

            For i = 0 To ColNum - 1 '设计不显示的列
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Visible = False
            Next

            Call SetColumnCaption() '设计列标题
            Call SetColumnWidth() '设计列宽度
            If ds.Tables(0).Rows.Count > 0 Then
                Call SetColumnSum(Sql) '设计合计列
            End If
            
            '作业完不可删除
            If Me.C1DBG.Columns("Unload_Mark").Text = "0" Then
                Me.mnuDelete.Enabled = True
                Me.tbbtnDelete.Enabled = True
            Else
                Me.mnuDelete.Enabled = False
                Me.tbbtnDelete.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaption()
        Dim sqla As New SqlClient.SqlDataAdapter()
        Dim sqlc As New SqlClient.SqlCommand()
        Dim dset As New DataSet()
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Try
            str = "select Field_Eng,Field_Cha From Field_Att where Table_Name='" & Table_Name & "'"
            sqlconn.ConnectionString = conn
            sqlc.Connection = sqlconn
            sqlc.CommandText = str
            sqla.SelectCommand = sqlc
            dset.Reset()
            sqla.Fill(dset)
            i = ColNum

            Do While i < Me.C1DBG.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = _
                        Upper(Trim(Me.C1DBG.Columns.Item(i).DataField.ToString)) Then
                        Me.C1DBG.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
                        Exit For
                    End If
                Next
                i = i + 1
            Loop
            sqlconn.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnSum(ByVal sql As String)
        On Error GoTo Err
        Dim sqla As New SqlClient.SqlDataAdapter()
        Dim sqlc As New SqlClient.SqlCommand()
        Dim dset As New DataSet()
        Dim dset2 As New DataSet()
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
        Dim FrmFind As New FrmFind()
        FrmFind.ShowDialog()
        If Flag = 0 Then
            'SelectStr = ""
            Call myDataGrid(SelectStr, " (" & Sql_Find & ")  " & FirmStr)  '可能要修改
            SqlStr = " (" & Sql_Find & ")  " & FirmStr '可能要修改
        ElseIf Flag = 2 Then
            'SelectStr = ""
            Call myDataGrid(SelectStr, DynaStr & FirmStr)  '可能要修改
            SqlStr = DynaStr & FirmStr '可能要修改
        End If
    End Sub

    Private Sub mnuQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuery.Click
        Try
            If ds.Tables(0).Rows.Count > 0 Then
                Dim FrmQuery As New FrmConImageCargo_Queryg()    '***********要修改
                ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
                FrmQuery.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show("请先选船名航次")
        End Try
    End Sub

    Private Sub mnuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdd.Click
        Try
            Dim FrmAdd As New FrmConImageCargo_Addg()      '***********要修改
            Do
                If ds.Tables(0).Rows.Count > 0 Then
                    ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
                Else
                    ID = -1
                End If
                FrmAdd.ShowDialog()
                Call myDataGrid(SelectStr, SqlStr)
                Me.C1DBG.Row = 0
            Loop While FrmAdd.Sign = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        If ds.Tables(0).Rows.Count > 0 Then
            Dim FrmEdit As New FrmConImageCargo_Editg()   '***********要修改
            Dim Row As Integer

            ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
            Row = Me.C1DBG.Row
            FrmEdit.ShowDialog()
            Try
                Call myDataGrid(SelectStr, SqlStr)
                Me.C1DBG.Row = Row

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        If ds.Tables(0).Rows.Count > 0 Then
            Dim FrmDelete As New FrmConImageCargo_Deleteg()    '***********要修改

            ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
            FrmDelete.ShowDialog()
            Try
                Call myDataGrid(SelectStr, SqlStr)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub mnuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrint.Click
        Call PrintExcel()
        ' Call GetSheetExcel()
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

    Private Sub mnuExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExport.Click
        If ds.Tables(0).Rows.Count > 0 Then
            Dim FrmDeal As New FrmConImageCargo_Deal       '***********要修改

            ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
            FrmDeal.ShowDialog()
            Try
                Call myDataGrid(SelectStr, SqlStr)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
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
            FilePath = PathStr + "CargoWater.xls"
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
        'Select Case Me.ToolBar.Buttons.IndexOf(e.Button)
        '    Case 0
        '        mnuFind_Click(sender, e)
        '    Case 1
        '        Call mnuQuery_Click(sender, e)
        '    Case 2

        '    Case 3
        '        Call mnuAdd_Click(sender, e)
        '    Case 4
        '        Call mnuEdit_Click(sender, e)
        '    Case 5
        '        Call mnuDelete_Click(sender, e)
        '    Case 6

        '    Case 7
        '        Call mnuPrint_Click(sender, e)
        '    Case 8
        '        Call mnuExport_Click(sender, e)
        '    Case 9

        '    Case 10
        '        Call mnuQuit_Click(sender, e)
        'End Select
        Select Case e.Button.Text
            Case "检索"
                mnuFind_Click(sender, e)
            Case "查看"
                Call mnuQuery_Click(sender, e)
            Case "增加"
                Call mnuAdd_Click(sender, e)
            Case "编辑"
                Call mnuEdit_Click(sender, e)
            Case "改贝位"
                mnuBayNo_Click(sender, e)
            Case "集中修改"
                mnuModiSeal_Click(sender, e)
            Case "删除"
                Call mnuDelete_Click(sender, e)
            Case "打印"
                Call mnuPrint_Click(sender, e)
            Case "转换"
                Call mnuExport_Click(sender, e)
            Case "退出"
                Call mnuQuit_Click(sender, e)
            Case "全清除"
                Call mnuClearAll_Click(sender, e)
            Case "删空箱"
                Call DeleteNullCon()
            Case "总览"
                Call mnuSeeClass_Click(sender, e)
            Case "列表增加"
                Call mnuListAdd_Click(sender, e)
            Case "查找"
                Call mnuLookUp_Click(sender, e)
            Case "卸货港"
                Call mnuUnloadPort_Click(sender, e)
            Case "分船"
                Call mnuDiv_Click(sender, e)
            Case "并船"
                Call mnuUnion_Click(sender, e)
            Case "删提单"
                Call mnuDelBill_Click(sender, e)
            Case "同步"
                Call mnuAccord_Click(sender, e)
            Case "箱主复核"
                Call mnuKeeper_Click(sender, e)
        End Select
    End Sub

    Private Sub preview(ByVal Func As String) '***************权限设计
        Dim sqlstr As String
        Dim Previewdv As DataView
        Dim Previewds As New DataSet()
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
    Private Sub DeleteNullCon()
        If ds.Tables(0).Rows.Count > 0 Then
            If InOutCode = "1" Then
                If MessageBox.Show("此操作将清除当前船次所有的空箱信息，一旦执行，数据全部清除，不可恢复。请慎用此功能。", "严重警示", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                    Dim sqlDeleteCon As String
                    sqlDeleteCon = "delete from CON_IMAGE where ship_id='" & Ship_ID & "' and FULLOREMPTY = 'E'"
                    Try
                        ExecSql(sqlDeleteCon)
                        Call myDataGrid(SelectStr, SqlStr)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
            Else
                MessageBox.Show("该船次进口 不得删除", "严重警示")
            End If
        End If
    End Sub
    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        TBar = 1
        Mnu = 1
    End Sub

    Private Sub C1DBG_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1DBG.DoubleClick
        Call mnuQuery_Click(sender, e)
    End Sub

    Private Sub SetColumnWidth()
        Try
            Dim j As Integer
            For j = 0 To Me.C1DBG.Columns.Count - 1
                Me.C1DBG.Splits(0).DisplayColumns.Item(j).AutoSize()
                Me.C1DBG.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                If Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width < 65 Then
                    Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width = 65
                Else
                    If Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width > 130 Then
                        Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width = 130
                    End If
                End If
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btResure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResure.Click
        SqlStrShip = "where (((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('0','1','2','3','4')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) and Voyage like '" & Trim(txtVoyage.Text) & "%' and (ENG_VESSEL Like '" & Trim(txtShipName.Text) & "%' OR CHI_VESSEL like '" & Trim(txtShipName.Text) & "%' )) "
        If G_User_Serial = "WLGCH" Then
            SqlStrShip = "where (DEPT_CODE LIKE '" & G_DeptCode & "%') "
        End If
        '可能要修改
        'G_ShipName = Trim(txtShipName.Text)
        'G_Voyage = Trim(txtVoyage.Text)
        Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '可能要修改
        If dsShip.Tables(0).Rows.Count > 0 Then
            C1DBGV_DoubleClick(sender, e)
        End If
    End Sub

    Private Sub txtShipName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtShipName.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtVoyage.Focus()
        End If
    End Sub

    Private Sub txtVoyage_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVoyage.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btResure.Focus()
        End If
    End Sub

    Private Sub mnuModiSeal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuModiSeal.Click
        If ds.Tables(0).Rows.Count > 0 Then
            Dim FrmSealModi As New FrmConImageCargo_ModiSeal       '***********要修改
            FrmSealModi.ShowDialog()
            Try
                Call myDataGrid(SelectStr, SqlStr)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub mnuClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClearAll.Click
        If ds.Tables(0).Rows.Count > 0 Then
            If MessageBox.Show("此操作将清除当前船次所有的箱信息(作业完数据除外)，不可恢复。请慎用此功能。", "严重警示", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                Dim sqlDeleteCon As String
                sqlDeleteCon = "delete from CON_IMAGE where ship_id='" & Ship_ID & "' and Unload_Mark='0' "
                Try
                    ExecSql(sqlDeleteCon)
                    Dim sqlDelRecord As String
                    sqlDelRecord = "insert into OperateHistory (Dept_Name,OperateTime,OperateWorker,OperateType,OperateDemo,OperateTable) values('" & G_DeptName & "',GetDate(),'" & G_User & "','全部清除','" & Ship_ID & " " & G_ShipName & " " & G_Voyage & "','CON_IMAGE') "
                    ExecSql(sqlDelRecord)
                    Call myDataGrid(SelectStr, SqlStr)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub mnuSeeClass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSeeClass.Click
        If ds.Tables(0).Rows.Count > 0 Then
            Dim FrmSeeClass As New FrmConImageCargo_SeeClass
            FrmSeeClass.ShowDialog()
        End If
    End Sub

    Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        If Me.C1DBG.Columns("Unload_Mark").CellText(e.Row) = "1" Then
            e.CellStyle.BackColor = System.Drawing.Color.Wheat
        End If
        If C1DBG.Columns("Moved").CellText(e.Row) = "1" Then
            e.CellStyle.ForeColor = System.Drawing.Color.Crimson
        End If
    End Sub

    Private Sub mnuListAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuListAdd.Click
        Dim FrmListAdd As New FrmConImageCargo_Add2
        FrmListAdd.ShowDialog()
        Call myDataGrid(SelectStr, SqlStr)
    End Sub

    Private Sub mnuLookUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLookUp.Click
        Dim FrmLookUp As New FrmContainer_Select
        FrmLookUp.ShowDialog()
        If FrmLookUp.flag = True Then
            Call myDataGrid(SelectStr, " (" & FrmLookUp.strSelect & ")  " & FirmStr)   '可能要修改
            SqlStr = " (" & FrmLookUp.strSelect & ")  " & FirmStr
            Call mnuQuery_Click(sender, e)
        Else
            Call myDataGrid(SelectStr, DynaStr & FirmStr)   '可能要修改
            SqlStr = DynaStr & FirmStr
        End If
    End Sub

    Private Sub mnuUnloadPort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUnloadPort.Click
        Try
            Dim FrmUnLoadPort As New FrmConImageCargo_UnloadPort
            FrmUnLoadPort.ShowDialog()
            Call myDataGrid(SelectStr, DynaStr & FirmStr)   '可能要修改
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub mnuBayNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBayNo.Click
        Dim fmEditBay As New FrmConImageCargo_BayNo
        fmEditBay.ShowDialog()
        Call myDataGrid(SelectStr, DynaStr & FirmStr)   '可能要修改
    End Sub

    Private Sub mnuExcelImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExcelImage.Click
        myDataGrid(SelectStr, DynaStr & FirmStr)
        If ds.Tables(0).Rows.Count > 0 Then
            MakeExcel(G_ShipName & "贝位规范")
            GC.Collect()
        End If
    End Sub

    Private Sub MakeExcel(ByVal strExcelName As String)
        Dim a, b As Integer 'Excel行列
        Dim i, j As Integer
        Dim PathStr As String = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        Dim strPath As String = PathStr & strExcelName & ".xls"
        Dim strSheetName As String
        Try
            Dim xlApp As Excel.Application
            xlApp = New Excel.ApplicationClass
            Dim xlBook As Excel.Workbook
            Dim xlSheet As Excel.Worksheet
            xlBook = xlApp.Workbooks.Add(strPath)
            'ORIGINAL面图
            strSheetName = "ORIGINAL"
            xlSheet = xlBook.Worksheets(strSheetName)
            xlSheet.Activate()
            xlSheet.Cells(2, "O") = strEngShipName
            xlSheet.Cells(2, "S") = G_Voyage
            xlSheet.Cells(2, "AF") = Now.Date

            'ClearCell(xlSheet, 11, 30, 4, 11)
            'ClearCell(xlSheet, 11, 30, 38, 45)
            'ClearCell(xlSheet, 5, 94, 13, 36)
            For i = 0 To ds.Tables(0).Rows.Count - 1
                FillOriginalCell(xlSheet, i)
            Next

            ds.Tables(0).DefaultView.RowFilter = "Substring(BayNo,5,1) >='8'"     '选出MAIN DECK上面的记录
            'MAIN DECK面图
            strSheetName = "MAIN DECK"
            xlSheet = xlBook.Worksheets(strSheetName)
            xlSheet.Activate()
            xlSheet.Cells(2, "O") = strEngShipName
            xlSheet.Cells(2, "S") = G_Voyage
            xlSheet.Cells(2, "AF") = Now.Date
            'ClearCell(xlSheet, 11, 30, 4, 11)
            'ClearCell(xlSheet, 11, 30, 38, 45)
            'ClearCell(xlSheet, 5, 38, 13, 36)
            For i = 0 To ds.Tables(0).DefaultView.Count - 1
                FillMainDeckCell(xlSheet, i)
            Next

            ds.Tables(0).DefaultView.RowFilter = "Substring(BayNo,5,1) <'8'"     '选出MAIN DECK下面的记录
            'CAR DECK面图
            strSheetName = "CAR DECK"
            xlSheet = xlBook.Worksheets(strSheetName)
            xlSheet.Activate()
            xlSheet.Cells(2, "K") = strEngShipName
            xlSheet.Cells(2, "O") = G_Voyage
            xlSheet.Cells(2, "AB") = Now.Date
            'ClearCell(xlSheet, 7, 16, 9, 32)
            For i = 0 To ds.Tables(0).DefaultView.Count - 1
                FillCarDeckCell(xlSheet, i)
            Next

            'FREEBOARD DECK面图
            strSheetName = "FREEBOARD DECK"
            xlSheet = xlBook.Worksheets(strSheetName)
            xlSheet.Activate()
            xlSheet.Cells(2, "K") = strEngShipName
            xlSheet.Cells(2, "O") = G_Voyage
            xlSheet.Cells(2, "AB") = Now.Date
            'ClearCell(xlSheet, 7, 26, 9, 32)
            For i = 0 To ds.Tables(0).DefaultView.Count - 1
                FillFreeBoardDeckCell(xlSheet, i)
            Next

            'LOWER HOLD面图
            strSheetName = "LOWER HOLD"
            xlSheet = xlBook.Worksheets(strSheetName)
            xlSheet.Activate()
            xlSheet.Cells(2, "K") = strEngShipName
            xlSheet.Cells(2, "O") = G_Voyage
            xlSheet.Cells(2, "AB") = Now.Date
            'ClearCell(xlSheet, 7, 26, 9, 32)
            For i = 0 To ds.Tables(0).DefaultView.Count - 1
                FillLowerHoldCell(xlSheet, i)
            Next

            ds.Tables(0).DefaultView.RowFilter = ""     '取消筛选   
            xlSheet = xlBook.Worksheets("ORIGINAL")
            xlSheet.Activate()
            Dim sfDialog As SaveFileDialog = New SaveFileDialog
            sfDialog.FileName = G_ShipName & G_Voyage & "船图"
            sfDialog.InitialDirectory = PathStr & "\report\"
            If System.IO.Directory.Exists(sfDialog.InitialDirectory) = False Then
                System.IO.Directory.CreateDirectory(sfDialog.InitialDirectory)
            End If
            sfDialog.RestoreDirectory = True
            sfDialog.AddExtension = True
            sfDialog.DefaultExt = ".xls"
            sfDialog.Filter = "Excel文件(*.xls)|*.xls"
            If sfDialog.ShowDialog() = DialogResult.OK Then
                xlBook.SaveAs(sfDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange, True, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
            End If
            xlApp.Visible = True
            'xlBook.Close(False, Type.Missing, Type.Missing) '关闭工作簿
            'xlApp.Quit()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '首尾纵向贝位
    Private Sub FillVerCell(ByVal xlSheet As Excel.Worksheet, ByVal a As Integer, ByVal b As Integer, ByVal i As Integer)
        xlSheet.Cells(a, b) = Me.C1DBG.Columns("CONTAINER_NO").CellText(i)
        If Not IsDBNull(Me.C1DBG.Columns("GROSSWEIGHT").CellValue(i)) Then
            xlSheet.Cells(a + 8, b) = Format(Me.C1DBG.Columns("GROSSWEIGHT").CellValue(i) / 1000, "0.##")
        End If
        xlSheet.Cells(a, b + 1) = Me.C1DBG.Columns("CODE_LOAD_PORT").CellText(i) & "/" & Me.C1DBG.Columns("CODE_UNLOAD_PORT").CellText(i) & "/" & Me.C1DBG.Columns("SIZE_CON").CellText(i) & Me.C1DBG.Columns("CONTAINER_TYPE").CellText(i)
        If Me.C1DBG.Columns("DANGER_GRADE").CellText(i).Length > 0 OrElse Me.C1DBG.Columns("CONTAINER_TYPE").CellText(i) Like "R?" Then
            xlSheet.Cells(a + 8, b + 1) = Me.C1DBG.Columns("CONTAINER_TYPE").CellText(i)
        Else
            xlSheet.Cells(a + 8, b + 1) = Me.C1DBG.Columns("FULLOREMPTY").CellText(i)
        End If
    End Sub

    '中间横向贝位
    Private Sub FillHorCell(ByVal xlSheet As Excel.Worksheet, ByVal a As Integer, ByVal b As Integer, ByVal i As Integer)
        xlSheet.Cells(a, b) = Me.C1DBG.Columns("CONTAINER_NO").CellText(i)
        If Not IsDBNull(Me.C1DBG.Columns("GROSSWEIGHT").CellValue(i)) Then
            xlSheet.Cells(a, b + 1) = Format(Me.C1DBG.Columns("GROSSWEIGHT").CellValue(i) / 1000, "0.##")
        End If
        xlSheet.Cells(a - 1, b) = Me.C1DBG.Columns("CODE_LOAD_PORT").CellText(i) & "/" & Me.C1DBG.Columns("CODE_UNLOAD_PORT").CellText(i) & " " & Me.C1DBG.Columns("SIZE_CON").CellText(i) & Me.C1DBG.Columns("CONTAINER_TYPE").CellText(i)
        If Me.C1DBG.Columns("DANGER_GRADE").CellText(i).Length > 0 OrElse Me.C1DBG.Columns("CONTAINER_TYPE").CellText(i) Like "R?" Then
            xlSheet.Cells(a - 1, b + 1) = Me.C1DBG.Columns("CONTAINER_TYPE").CellText(i)
        Else
            xlSheet.Cells(a - 1, b + 1) = Me.C1DBG.Columns("FULLOREMPTY").CellText(i)
        End If
    End Sub
    '清空指定区域内容
    Private Sub ClearCell(ByVal xlSheet As Excel.Worksheet, ByVal iBegin As Integer, ByVal iEnd As Integer, ByVal jBegin As Integer, ByVal jEnd As Integer)
        Dim i, j As Integer
        For i = iBegin To iEnd
            For j = jBegin To jEnd
                xlSheet.Cells(i, j) = ""
            Next
        Next
    End Sub

    '填写ORIGINAL面图单元格
    Private Sub FillOriginalCell(ByVal xlSheet As Excel.Worksheet, ByVal i As Integer)
        Select Case Me.C1DBG.Columns("BayNo").CellText(i)
            Case "030284"   '首尾纵向
                FillVerCell(xlSheet, 11, 44, i)
            Case "050684"   '中间横向
                FillHorCell(xlSheet, 11, 35, i)
                '''
                '添加各个贝位
                '''
        End Select
    End Sub
    '填写MainDeck面图单元格
    Private Sub FillMainDeckCell(ByVal xlSheet As Excel.Worksheet, ByVal i As Integer)
        Select Case Me.C1DBG.Columns("BayNo").CellText(i)
            Case "030284"   '首尾纵向
                FillVerCell(xlSheet, 11, 44, i)
            Case "050684"   '中间横向
                FillHorCell(xlSheet, 11, 35, i)
                '''
                '添加各个贝位
                '''
        End Select
    End Sub
    '填写CarDeck面图单元格
    Private Sub FillCarDeckCell(ByVal xlSheet As Excel.Worksheet, ByVal i As Integer)
        Select Case Me.C1DBG.Columns("BayNo").CellText(i)
            '''
            '添加各个贝位
            '''
        End Select
    End Sub
    '填写FreeBoardDeck面图单元格
    Private Sub FillFreeBoardDeckCell(ByVal xlSheet As Excel.Worksheet, ByVal i As Integer)
        Select Case Me.C1DBG.Columns("BayNo").CellText(i)
            '''
            '添加各个贝位
            '''
        End Select
    End Sub
    '填写LowerHold面图单元格
    Private Sub FillLowerHoldCell(ByVal xlSheet As Excel.Worksheet, ByVal i As Integer)
        Select Case Me.C1DBG.Columns("BayNo").CellText(i)
            '''
            '添加各个贝位
            '''
        End Select
    End Sub

    Private Sub mnuTray_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTray.Click
        Dim FrmTray As New FrmConImageCargo_Tray
        FrmTray.ShowDialog()
        Call myDataGrid(SelectStr, SqlStr)
    End Sub

    Private Sub mnuDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDiv.Click
        Dim FrmDiv As New FrmConImageCargo_Div
        FrmDiv.ShowDialog()
        Call myDataGrid(SelectStr, SqlStr)
    End Sub

    Private Sub mnuUnion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUnion.Click
        Dim FrmUnion As New FrmConImageCargo_Union
        FrmUnion.ShowDialog()
    End Sub

    Private Sub C1DBG_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles C1DBG.RowColChange
        If Me.C1DBG.Row <> e.LastRow Then
            '作业完不可删除
            If Me.C1DBG.Columns("Unload_Mark").Text = "0" Then
                Me.mnuDelete.Enabled = True
                Me.tbbtnDelete.Enabled = True
            Else
                Me.mnuDelete.Enabled = False
                Me.tbbtnDelete.Enabled = False
            End If
        End If
    End Sub

    Private Sub mnuDelBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelBill.Click
        Dim fm As New FrmConImageCargo_DelBill
        fm.txtBillNo.Text = Me.C1DBG.Columns("BLNO").Text
        fm.ShowDialog()
        myDataGrid(SelectStr, SqlStr)
    End Sub

    Private Sub mnuAccord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAccord.Click
        Dim FrmAccord As New FrmConImageCargo_PortAccord
        FrmAccord.ShowDialog()
        If FrmAccord.blSave Then
            myDataGrid(SelectStr, DynaStr & FirmStr)
        End If
    End Sub

    Private Sub mnuKeeper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuKeeper.Click
        Dim FrmKeeper As New FrmConImage_Keeper
        FrmKeeper.ShowDialog()
    End Sub
End Class
