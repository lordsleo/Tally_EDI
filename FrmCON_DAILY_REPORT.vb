Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FrmCON_DAILY_REPORT
    Inherits System.Windows.Forms.Form
    Dim dsShip As New DataSet() '�������ݼ�
    Dim SqlStrShip As String  '�����������
    Dim FirmShip As String
    Dim SortShip As String
    Dim inoutstr As String

    'Dim ds As New DataSet()
    Dim SqlStr As String  '�������
    Dim SelectStr As String
    Dim DynaStr As String '�ɱ���������
    Dim FirmStr As String '������������
    Dim ColNum As Integer '����ʾ������
#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮�������κγ�ʼ��

    End Sub

    '������д��������������б���
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows ����������������
    Private components As System.ComponentModel.IContainer

    'ע�⣺���¹����� Windows ����������������
    '����ʹ�� Windows ����������޸Ĵ˹��̡�
    '��Ҫʹ�ô���༭���޸�����
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFind As System.Windows.Forms.MenuItem
    Friend WithEvents mnuQuery As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrint As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExport As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuQuit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCompile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAdd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents GBV As System.Windows.Forms.GroupBox
    Friend WithEvents ToolBarV As System.Windows.Forms.ToolBar
    Friend WithEvents C1DBGV As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents S1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnOK As System.Windows.Forms.ToolBarButton
    Friend WithEvents S2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSearch As System.Windows.Forms.ToolBarButton
    Friend WithEvents S3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSort As System.Windows.Forms.ToolBarButton
    Friend WithEvents S4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnEng As System.Windows.Forms.ToolBarButton
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents LabREMARKS As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    Friend WithEvents tbbtnDO As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnPrint As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnExport As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnQuit As System.Windows.Forms.ToolBarButton
    Friend WithEvents btResure As System.Windows.Forms.Button
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCON_DAILY_REPORT))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Dim GridLines2 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Me.MainMenu = New System.Windows.Forms.MainMenu
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuFind = New System.Windows.Forms.MenuItem
        Me.mnuQuery = New System.Windows.Forms.MenuItem
        Me.mnuSep1 = New System.Windows.Forms.MenuItem
        Me.mnuPrint = New System.Windows.Forms.MenuItem
        Me.mnuExport = New System.Windows.Forms.MenuItem
        Me.mnuSep2 = New System.Windows.Forms.MenuItem
        Me.mnuQuit = New System.Windows.Forms.MenuItem
        Me.mnuCompile = New System.Windows.Forms.MenuItem
        Me.mnuAdd = New System.Windows.Forms.MenuItem
        Me.mnuEdit = New System.Windows.Forms.MenuItem
        Me.mnuDelete = New System.Windows.Forms.MenuItem
        Me.mnuHelp = New System.Windows.Forms.MenuItem
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.GBV = New System.Windows.Forms.GroupBox
        Me.btResure = New System.Windows.Forms.Button
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolBarV = New System.Windows.Forms.ToolBar
        Me.S1 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnOK = New System.Windows.Forms.ToolBarButton
        Me.S2 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSearch = New System.Windows.Forms.ToolBarButton
        Me.S3 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSort = New System.Windows.Forms.ToolBarButton
        Me.S4 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnEng = New System.Windows.Forms.ToolBarButton
        Me.C1DBGV = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.GB = New System.Windows.Forms.GroupBox
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.LabREMARKS = New System.Windows.Forms.Label
        Me.Label = New System.Windows.Forms.Label
        Me.ToolBar = New System.Windows.Forms.ToolBar
        Me.tbbtnDO = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep1 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnPrint = New System.Windows.Forms.ToolBarButton
        Me.tbbtnExport = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep3 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuit = New System.Windows.Forms.ToolBarButton
        Me.GBV.SuspendLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB.SuspendLayout()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuCompile, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFind, Me.mnuQuery, Me.mnuSep1, Me.mnuPrint, Me.mnuExport, Me.mnuSep2, Me.mnuQuit})
        Me.mnuFile.Text = "�ļ�(&F)"
        '
        'mnuFind
        '
        Me.mnuFind.Enabled = False
        Me.mnuFind.Index = 0
        Me.mnuFind.Text = "����(&F)"
        '
        'mnuQuery
        '
        Me.mnuQuery.Enabled = False
        Me.mnuQuery.Index = 1
        Me.mnuQuery.Text = "�鿴(&Q)"
        '
        'mnuSep1
        '
        Me.mnuSep1.Index = 2
        Me.mnuSep1.Text = "-"
        '
        'mnuPrint
        '
        Me.mnuPrint.Enabled = False
        Me.mnuPrint.Index = 3
        Me.mnuPrint.Text = "��ӡ(&P)..."
        '
        'mnuExport
        '
        Me.mnuExport.Enabled = False
        Me.mnuExport.Index = 4
        Me.mnuExport.Text = "����(&E)"
        '
        'mnuSep2
        '
        Me.mnuSep2.Index = 5
        Me.mnuSep2.Text = "-"
        '
        'mnuQuit
        '
        Me.mnuQuit.Index = 6
        Me.mnuQuit.Text = "�˳�(&X)"
        '
        'mnuCompile
        '
        Me.mnuCompile.Index = 1
        Me.mnuCompile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAdd, Me.mnuEdit, Me.mnuDelete})
        Me.mnuCompile.Text = "�༭(&E)"
        '
        'mnuAdd
        '
        Me.mnuAdd.Enabled = False
        Me.mnuAdd.Index = 0
        Me.mnuAdd.Text = "����(&A)"
        '
        'mnuEdit
        '
        Me.mnuEdit.Enabled = False
        Me.mnuEdit.Index = 1
        Me.mnuEdit.Text = "�༭(&E)"
        '
        'mnuDelete
        '
        Me.mnuDelete.Enabled = False
        Me.mnuDelete.Index = 2
        Me.mnuDelete.Text = "ɾ��(&D)"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.Text = "����(&H)"
        '
        'ImageList
        '
        Me.ImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
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
        Me.GBV.Size = New System.Drawing.Size(174, 433)
        Me.GBV.TabIndex = 4
        Me.GBV.TabStop = False
        '
        'btResure
        '
        Me.btResure.Location = New System.Drawing.Point(128, 368)
        Me.btResure.Name = "btResure"
        Me.btResure.Size = New System.Drawing.Size(42, 22)
        Me.btResure.TabIndex = 21
        Me.btResure.Text = "��ѯ"
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(38, 368)
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(88, 21)
        Me.txtVoyage.TabIndex = 20
        Me.txtVoyage.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 372)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 14)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "����"
        '
        'txtShipName
        '
        Me.txtShipName.Location = New System.Drawing.Point(38, 344)
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.Size = New System.Drawing.Size(132, 21)
        Me.txtShipName.TabIndex = 18
        Me.txtShipName.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 346)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "����"
        '
        'ToolBarV
        '
        Me.ToolBarV.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.S1, Me.tbbtnOK, Me.S2, Me.tbbtnSearch, Me.S3, Me.tbbtnSort, Me.S4, Me.tbbtnEng})
        Me.ToolBarV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBarV.DropDownArrows = True
        Me.ToolBarV.ImageList = Me.ImageList
        Me.ToolBarV.Location = New System.Drawing.Point(3, 389)
        Me.ToolBarV.Name = "ToolBarV"
        Me.ToolBarV.ShowToolTips = True
        Me.ToolBarV.Size = New System.Drawing.Size(168, 41)
        Me.ToolBarV.TabIndex = 1
        '
        'S1
        '
        Me.S1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnOK
        '
        Me.tbbtnOK.ImageIndex = 8
        Me.tbbtnOK.Text = "����"
        '
        'S2
        '
        Me.S2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnSearch
        '
        Me.tbbtnSearch.ImageIndex = 9
        Me.tbbtnSearch.Text = "����"
        '
        'S3
        '
        Me.S3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnSort
        '
        Me.tbbtnSort.ImageIndex = 10
        Me.tbbtnSort.Text = "����"
        '
        'S4
        '
        Me.S4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnEng
        '
        Me.tbbtnEng.ImageIndex = 11
        Me.tbbtnEng.Text = "Ӣ��"
        '
        'C1DBGV
        '
        Me.C1DBGV.AllowFilter = True
        Me.C1DBGV.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1DBGV.AllowSort = True
        Me.C1DBGV.AllowUpdate = False
        Me.C1DBGV.CaptionHeight = 18
        Me.C1DBGV.CollapseColor = System.Drawing.Color.Black
        Me.C1DBGV.DataChanged = False
        Me.C1DBGV.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBGV.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1DBGV.ExpandColor = System.Drawing.Color.Black
        Me.C1DBGV.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGV.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBGV.Location = New System.Drawing.Point(3, 17)
        Me.C1DBGV.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBGV.Name = "C1DBGV"
        Me.C1DBGV.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGV.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGV.PreviewInfo.ZoomFactor = 75
        Me.C1DBGV.PrintInfo.ShowOptionsDialog = False
        Me.C1DBGV.RecordSelectorWidth = 17
        GridLines1.Color = System.Drawing.Color.DarkGray
        GridLines1.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBGV.RowDivider = GridLines1
        Me.C1DBGV.RowHeight = 16
        Me.C1DBGV.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBGV.ScrollTips = False
        Me.C1DBGV.Size = New System.Drawing.Size(168, 325)
        Me.C1DBGV.TabIndex = 0
        Me.C1DBGV.Text = "C1TrueDBGrid1"
        Me.C1DBGV.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style9{}Od" & _
        "dRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Center;Borde" & _
        "r:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Style10{Al" & _
        "ignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCaptionHeight=""18"" Colu" & _
        "mnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSelectorWidth=""17"" Def" & _
        "RecSelWidth=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRect>0" & _
        ", 0, 164, 321</ClientRect><BorderSide>0</BorderSide><CaptionStyle parent=""Style2" & _
        """ me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle parent" & _
        "=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><Foot" & _
        "erStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" />" & _
        "<HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""Highligh" & _
        "tRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle " & _
        "parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""S" & _
        "tyle11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style parent=""Normal"" " & _
        "me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style paren" & _
        "t="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading""" & _
        " me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me" & _
        "=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""" & _
        "Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""" & _
        "EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""Reco" & _
        "rdSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me" & _
        "=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><La" & _
        "yout>None</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth><ClientArea>0, 0, 1" & _
        "64, 321</ClientArea></Blob>"
        '
        'GB
        '
        Me.GB.Controls.Add(Me.C1DBG)
        Me.GB.Controls.Add(Me.LabREMARKS)
        Me.GB.Controls.Add(Me.Label)
        Me.GB.Controls.Add(Me.ToolBar)
        Me.GB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB.Location = New System.Drawing.Point(174, 0)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(540, 433)
        Me.GB.TabIndex = 5
        Me.GB.TabStop = False
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
        Me.C1DBG.ExpandColor = System.Drawing.Color.Black
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(6, 126)
        Me.C1DBG.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.ShowOptionsDialog = False
        Me.C1DBG.RecordSelectorWidth = 17
        GridLines2.Color = System.Drawing.Color.DarkGray
        GridLines2.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG.RowDivider = GridLines2
        Me.C1DBG.RowHeight = 16
        Me.C1DBG.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG.ScrollTips = False
        Me.C1DBG.Size = New System.Drawing.Size(532, 304)
        Me.C1DBG.TabIndex = 13
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
        "SelectorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" HorizontalScrollG" & _
        "roup=""1""><ClientRect>0, 0, 528, 300</ClientRect><BorderSide>0</BorderSide><Capti" & _
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
        "lits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</DefaultRecSelWid" & _
        "th><ClientArea>0, 0, 528, 300</ClientArea></Blob>"
        '
        'LabREMARKS
        '
        Me.LabREMARKS.Location = New System.Drawing.Point(6, 98)
        Me.LabREMARKS.Name = "LabREMARKS"
        Me.LabREMARKS.Size = New System.Drawing.Size(530, 24)
        Me.LabREMARKS.TabIndex = 12
        '
        'Label
        '
        Me.Label.BackColor = System.Drawing.SystemColors.Control
        Me.Label.Location = New System.Drawing.Point(6, 60)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(530, 34)
        Me.Label.TabIndex = 11
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolBar
        '
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnDO, Me.tbbtnSep1, Me.tbbtnPrint, Me.tbbtnExport, Me.tbbtnSep3, Me.tbbtnQuit})
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.Enabled = False
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(3, 17)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(534, 41)
        Me.ToolBar.TabIndex = 9
        '
        'tbbtnDO
        '
        Me.tbbtnDO.ImageIndex = 1
        Me.tbbtnDO.Text = "����"
        Me.tbbtnDO.ToolTipText = "����"
        '
        'tbbtnSep1
        '
        Me.tbbtnSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnPrint
        '
        Me.tbbtnPrint.ImageIndex = 5
        Me.tbbtnPrint.Text = "��ӡ"
        Me.tbbtnPrint.ToolTipText = "��ӡ"
        '
        'tbbtnExport
        '
        Me.tbbtnExport.ImageIndex = 6
        Me.tbbtnExport.Text = "����"
        Me.tbbtnExport.ToolTipText = "����Excel"
        '
        'tbbtnSep3
        '
        Me.tbbtnSep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnQuit
        '
        Me.tbbtnQuit.ImageIndex = 7
        Me.tbbtnQuit.Text = "�˳�"
        Me.tbbtnQuit.ToolTipText = "�˳�"
        '
        'FrmCON_DAILY_REPORT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(714, 433)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.GBV)
        Me.Menu = Me.MainMenu
        Me.Name = "FrmCON_DAILY_REPORT"
        Me.Text = "��װ���ձ�"
        Me.GBV.ResumeLayout(False)
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB.ResumeLayout(False)
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCON_DAILY_REPORT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Text = Me.Text & "_" & G_DeptName

        SortShip = " Order by Ship_Statu,Dept_Code,id desc " 'Ĭ�ϵ����� 

        FirmShip = "where DEPT_CODE LIKE '" & G_DeptCode & "%'" '����������������
        SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) "
        Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '*****************���ú�����Ϣ
        Me.C1DBGV.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        txtShipName.Text = G_ShipName
        txtVoyage.Text = G_Voyage
        Call btResure_Click(sender, e)
    End Sub
    Private Sub myDataGridShip(ByVal Sql As String) '**************������Ϣ
        Dim strsql As String
        Dim i As Integer
        strsql = "select SHIP_ID as ID ,SHIP_STATU,INOUTPORT,DEPT_CODE,ENG_VESSEL,CHI_VESSEL,VOYAGE,InOutPort_Name,Dept_Short from View_SSHip " '����������� ���Ĳ���
        strsql = strsql & Sql
        Try
            Me.C1DBGV.DataSource = Getdata(strsql, dsShip)
            For i = 0 To 4 '��Ʋ���ʾ����
                Me.C1DBGV.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Call SetColumnCaptionShip() '����б���
            Call SetColumnWidthShip() '����п���
            If dsShip.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumShip(5)  '��ƺϼ���
            End If
            Me.C1DBGV.FetchRowStyles = True
            Me.C1DBGV.Refresh()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SetColumnCaptionShip() '*****************���α���
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
    Private Sub SetColumnWidthShip() '************�����п�
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

    Private Sub SetColumnSumShip(ByVal Col As Integer) '****************���λ�����

        Me.C1DBGV.ColumnFooters = True
        Me.C1DBGV.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGV.Columns.Item(Col).FooterText = "�� " & dsShip.Tables(0).Rows.Count & " ��"

    End Sub
    Private Sub ToolBarV_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBarV.ButtonClick
        Select Case Me.ToolBarV.Buttons.IndexOf(e.Button)
            Case 1
                SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','0')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) " '�����ɱ���������

                SortShip = " Order by Ship_Statu,Dept_Code,id desc "
                Call myDataGridShip(SqlStrShip & inoutstr & SortShip)
            Case 3
                Dim FrmFind As New FrmFind()
                Table_Name = "SSHIP"
                FrmFind.ShowDialog()

                If Flag = 0 Then
                    Call myDataGridShip(FirmShip & inoutstr & " and (" & Sql_Find & ")  " & SortShip)    '����Ҫ�޸�
                    SqlStrShip = FirmStr & " and (" & Sql_Find & ")  "    '����Ҫ�޸�
                ElseIf Flag = 2 Then
                    SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','4')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) "
                    '����Ҫ�޸�
                    Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '����Ҫ�޸�
                End If
            Case 5
                Dim FrmSort As New FrmSort()
                FrmSort.ShowDialog()
                If Len(Trim(SortStr)) > 0 Then
                    SortShip = " Order by " & SortStr
                End If
                Call myDataGridShip(SqlStrShip & inoutstr & SortShip)
            Case 7
                Me.C1DBGV.Splits(0).DisplayColumns.Item(4).Visible = True
                Me.C1DBGV.Splits(0).DisplayColumns.Item(5).Visible = False
                If dsShip.Tables(0).Rows.Count > 0 Then
                    Call SetColumnSumShip(4)  '��ƺϼ���
                End If
                Me.C1DBGV.FetchRowStyles = True
                Me.C1DBGV.Refresh()
        End Select
    End Sub

    Private Sub C1DBGV_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBGV.FetchRowStyle
        If Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 1 Then
            e.CellStyle.BackColor = System.Drawing.Color.White
        ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 2 Then
            e.CellStyle.BackColor = System.Drawing.Color.PaleGreen
        ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 3 Then
            e.CellStyle.BackColor = System.Drawing.Color.LemonChiffon
        ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 4 Then
            e.CellStyle.BackColor = System.Drawing.Color.Pink
        ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 0 Then
            e.CellStyle.BackColor = System.Drawing.Color.Cyan
        End If
    End Sub
    Private Sub C1DBGV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBGV.DoubleClick
        On Error GoTo Err
        Dim dsShip As New DataSet()
        Dim strsql As String
        Dim dw As New DataView()
        Ship_ID = CType(Me.C1DBGV.Columns.Item("ID").Text.ToString, Integer)
        strsql = "select * from View_SSHIP where SHIP_ID=" & Ship_ID
        dw = Getdata(strsql, dsShip)
        Label.Text = ""
        If dsShip.Tables(0).DefaultView.Count > 0 Then
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))) > 0 Then
                Label.Text = Label.Text & "���Ĵ���:" & Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL")) & " "
                G_ShipName = Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))
                txtShipName.Text = Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL"))) > 0 Then
                Label.Text = Label.Text & "Ӣ�Ĵ���:" & Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))) > 0 Then
                Label.Text = Label.Text & "����:" & Trim(dsShip.Tables(0).Rows(0).Item("Voyage")) & " "
                G_Voyage = Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))
                txtVoyage.Text = Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("InOutPort_Name"))) > 0 Then
                Label.Text = Label.Text & "������:" & Trim(dsShip.Tables(0).Rows(0).Item("InOutPort_Name")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Trade"))) > 0 Then
                Label.Text = Label.Text & "����ó:" & Trim(dsShip.Tables(0).Rows(0).Item("Trade")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("SHIP_TYPE"))) > 0 Then
                Label.Text = Label.Text & "������:" & Trim(dsShip.Tables(0).Rows(0).Item("SHIP_TYPE")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("SHIPAGENT_CHAE"))) > 0 Then
                Label.Text = Label.Text & "����:" & Trim(dsShip.Tables(0).Rows(0).Item("SHIPAGENT_CHA")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("GOODS"))) > 0 Then
                Label.Text = Label.Text & "����:" & Trim(dsShip.Tables(0).Rows(0).Item("GOODS")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Tons"))) > 0 Then
                Label.Text = Label.Text & "����:" & Trim(dsShip.Tables(0).Rows(0).Item("Tons")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("BerthNo"))) > 0 Then
                Label.Text = Label.Text & "��λ:" & Trim(dsShip.Tables(0).Rows(0).Item("BerthNo")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("File_No"))) > 0 Then
                Label.Text = Label.Text & "������:" & Trim(dsShip.Tables(0).Rows(0).Item("File_No")) & " "
            End If
        End If
        FirmStr = " and Ship_ID=" & Ship_ID & " Order by ID " '��Ƴ�ʼ����  �ڼ����󲻸ı������  '***************Ҫ�޸� �� 2>1
        DynaStr = " 2>1 " '���������ʼ����    �ڼ�������Ҫ������ ***************Ҫ�޸� �� ��������
        SelectStr = " " ' " Top 20 "
        SqlStr = " (" & DynaStr & ")  " & FirmStr

        Me.ToolBar.Enabled = True
        Me.mnuAdd.Enabled = True
        Me.mnuDelete.Enabled = True
        Me.mnuEdit.Enabled = True
        Me.mnuExport.Enabled = True
        Me.mnuFind.Enabled = True
        Me.mnuPrint.Enabled = True
        Me.mnuQuery.Enabled = True
        dsdaily.Reset()
        OKMARK = "0"
        LabREMARKS.Text = ""
        REMARKS = ""

        Call preview("WL4_1") '*****************Ȩ����� '*************Ҫ�޸�ģ���
        'Call myDataGrid(SelectStr, SqlStr)
        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '���ѡ���¼��ɫ
        ds_sship.Reset()
        dw = Getdata("select * from view_outhatch_sship where ship_id='" & Ship_ID & "'", ds_sship)
        If ds_sship.Tables(0).Rows.Count > 0 Then
            trade = ds_sship.Tables(0).Rows(0).Item("s_trade")
        End If
        Exit Sub
Err:
        Resume Next
    End Sub
    Private Sub myDataGrid(ByVal SelStr As String, ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            '����ʾ����������ǰ��
            'strsql = "select " & SelStr & " *  from VIEW_CARGO_WAITFOR  where " & Sql '******Ҫ�޸�
            Me.C1DBG.DataSource = dsdaily.Tables(0).DefaultView
            LabREMARKS.Text = REMARKS
            'Me.C1DBG.DataSource = Getdata(strsql, ds)  ' class dbcontrol getdata fuction
            ColNum = 0 '����ʾ������ '******Ҫ�޸�
            Table_Name = "SPCON_DAILY_REPORT" '���������ݿ���� ''******Ҫ�޸�

            For i = 0 To ColNum - 1 '��Ʋ���ʾ����
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Me.C1DBG.Columns.Item(0).Caption = "��Ŀ"
            Me.C1DBG.Columns.Item(1).Caption = "20����"
            Me.C1DBG.Columns.Item(2).Caption = "20�ض�"
            Me.C1DBG.Columns.Item(3).Caption = "40����"
            Me.C1DBG.Columns.Item(4).Caption = "40�ض�"
            Me.C1DBG.Columns.Item(5).Caption = "��������"
            Me.C1DBG.Columns.Item(6).Caption = "�����ض�"
            Me.C1DBG.Columns.Item(7).Caption = "20����"
            Me.C1DBG.Columns.Item(8).Caption = "20�ն�"
            Me.C1DBG.Columns.Item(9).Caption = "40����"
            Me.C1DBG.Columns.Item(10).Caption = "40�ն�"
            Me.C1DBG.Columns.Item(11).Caption = "��������"
            Me.C1DBG.Columns.Item(12).Caption = "�����ն�"
            Me.C1DBG.Columns.Item(13).Caption = "С����"
            Me.C1DBG.Columns.Item(14).Caption = "С�ƶ�"
           
            Call SetColumnCaption() '����б���
            Call SetColumnWidth() '����п���
            'If dsdaily.Tables(0).Rows.Count > 0 Then
            '    Call SetColumnSum(Sql) '��ƺϼ���
            'End If
            'Me.C1DBG.FetchRowStyles = True
            Me.C1DBG.Refresh()

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

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBG.Columns.Item(i).DataField.ToString)) Then
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

    Private Sub SetColumnWidth()
        Dim j As Integer
        For j = 0 To Me.C1DBG.Columns.Count - 1
            Me.C1DBG.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.C1DBG.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width < 40 Then
                Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width = 40
            Else
                If Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.C1DBG.Splits(0).DisplayColumns.Item(j).Width = 120
                End If
            End If

        Next
    End Sub
    '    Private Sub SetColumnSum(ByVal sql As String)
    '        On Error GoTo Err
    '        Dim sqla As New SqlClient.SqlDataAdapter()
    '        Dim sqlc As New SqlClient.SqlCommand()
    '        Dim dset As New DataSet()
    '        Dim dset2 As New DataSet()
    '        Dim str As String
    '        Dim i As Integer
    '        Dim j As Integer
    '        Dim m As Integer
    '        Dim num As Double
    '        str = "select Field_Eng,Field_Type,IsOrNoSum From Field_Att where Table_Name='" & Trim(Table_Name) & "'"
    '        sqlconn.ConnectionString = conn
    '        sqlc.Connection = sqlconn
    '        sqlc.CommandText = str
    '        sqla.SelectCommand = sqlc
    '        dset.Reset()
    '        sqla.Fill(dset)

    '        i = ColNum
    '        Me.C1DBG.ColumnFooters = True
    '        Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
    '        Me.C1DBG.Columns.Item(ColNum).FooterText = "�ϼ� ��" & dsdaily.Tables(0).Rows.Count & "��"
    '        Do While i < Me.C1DBG.Columns.Count
    '            j = 0
    '            For j = 0 To dset.Tables(0).Rows.Count - 1

    '                If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBG.Columns.Item(i).DataField.ToString)) And Upper(Trim(dset.Tables(0).Rows(j)("Field_Type"))) = "N" And Trim(dset.Tables(0).Rows(j)("IsOrNoSum")) = "1" Then

    '                    num = 0
    '                    For m = 0 To ds.Tables(0).Rows.Count - 1
    '                        num = num + ds.Tables(0).Rows(m)(i)
    '                    Next
    '                    Me.C1DBG.Columns.Item(i).FooterText = CType(num, String)
    '                    Exit For
    '                End If
    '            Next
    '            i = i + 1
    '        Loop

    '        sqlconn.Close()
    '        Exit Sub
    'Err:
    '        Resume Next


    '    End Sub

    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
        Me.Close()
    End Sub

    Private Sub ToolBar_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar.ButtonClick
        Select Case Me.ToolBar.Buttons.IndexOf(e.Button)
            Case 0
                Dim frm As New FrmCON_DAILY_REPORT_DO()
                frm.ShowDialog()
                If OKMARK = 1 Then
                    Call myDataGrid(SelectStr, SqlStr)
                End If

            Case 1

            Case 2
                Call mnuPrint_Click(sender, e)
            Case 3
                Call mnuExport_Click(sender, e)
            Case 4
                'Call mnuEdit_Click(sender, e)
            Case 5
                Me.Close()
            Case 6

            Case 7

            Case 8

            Case 9

            Case 10

        End Select
    End Sub
    'Private Sub mnuFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFind.Click
    '    Dim FrmFind As New FrmFind()
    '    Table_Name = "VIEW_CARGO_WAITFOR" '����Ҫ�޸�
    '    FrmFind.ShowDialog()

    '    If Flag = 0 Then
    '        SelectStr = ""
    '        Call myDataGrid(SelectStr, " (" & Sql_Find & ")  " & FirmStr)  '����Ҫ�޸�
    '        SqlStr = " (" & Sql_Find & ")  " & FirmStr '����Ҫ�޸�
    '    ElseIf Flag = 2 Then
    '        SelectStr = ""
    '        Call myDataGrid(SelectStr, DynaStr & FirmStr)  '����Ҫ�޸�
    '        SqlStr = DynaStr & FirmStr '����Ҫ�޸�
    '    End If
    'End Sub

    'Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
    '    If ds.Tables(0).Rows.Count > 0 Then
    '        Dim FrmDelete As New FrmCARGO_WAITFOR_DELETE() '***********Ҫ�޸�

    '        ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
    '        FrmDelete.ShowDialog()
    '        Try
    '            Call myDataGrid(SelectStr, SqlStr)


    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End If
    'End Sub

    'Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
    '    If ds.Tables(0).Rows.Count > 0 Then
    '        Dim FrmEdit As New FrmCARGO_WAITFOR_EDIT() '***********Ҫ�޸�

    '        Dim Row As Integer

    '        ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
    '        Row = Me.C1DBG.Row
    '        FrmEdit.ShowDialog()
    '        Try
    '            Call myDataGrid(SelectStr, SqlStr)
    '            Me.C1DBG.Row = Row

    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '        End Try
    '    End If
    'End Sub

    'Private Sub mnuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdd.Click
    '    Dim FrmAdd As New FrmCARGO_WAITFOR_ADD() '***********Ҫ�޸�
    '    If ds.Tables(0).Rows.Count > 0 Then
    '        ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
    '    Else
    '        ID = -1
    '    End If
    '    FrmAdd.ShowDialog()
    '    Try
    '        Call myDataGrid(SelectStr, SqlStr)

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    'End Sub
    'Private Sub C1DBG_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.DoubleClick
    '    Call mnuQuery_Click(sender, e)
    'End Sub

    'Private Sub C1DBG_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If e.KeyChar = Chr(13) Then
    '        If Me.C1DBG.Col = Me.C1DBG.Columns.Count - 1 And Me.C1DBG.Row < ds.Tables(0).Rows.Count - 1 Then
    '            Me.C1DBG.Row = Me.C1DBG.Row + 1
    '            Me.C1DBG.Col = ColNum
    '        End If
    '    End If
    'End Sub

    'Private Sub mnuQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuery.Click
    '    If ds.Tables(0).Rows.Count > 0 Then
    '        Dim FrmQuery As New FrmCARGO_WAITFOR_QUERY() '***********Ҫ�޸�
    '        ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
    '        FrmQuery.ShowDialog()
    '    End If
    'End Sub


    Private Sub mnuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrint.Click
        Call PrintExcel()
    End Sub

    Private Sub mnuExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExport.Click
        Call ExportExcel()
    End Sub
    Private Sub ExportExcel() '����Excel        
        'Call MakeExcel()
    End Sub
    Private Sub PrintExcel() '��ӡ��Excel        
        Try
            If mark = "CHA" Then
                Call china()
            ElseIf mark = "ENG" Then
                Call eng()
            End If
        Catch
            xlApp.Quit()
            SendKeys.Send("n")
        End Try
    End Sub
    Private Sub china()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer


        Try

            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "Report_zlp3.xls", pathstr + "Report.xls")
            Filepath = pathstr + "report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("��װ���ձ���C��"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = True

            xlsheet.Cells(8, 2) = ds_sship.Tables(0).Rows(0).Item("CHI_VESSEL")
            xlsheet.Cells(8, 6) = ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            xlsheet.Cells(8, 8) = dsdaily.Tables(1).Rows(0).Item("berth")

            xlsheet.Cells(8, 11) = Year(dsdaily.Tables(2).Rows(0).Item("timefrom")) & "��" & dsdaily.Tables(2).Rows(0).Item("monthfrom") & "��" & dsdaily.Tables(2).Rows(0).Item("dayfrom") & "�� " & dsdaily.Tables(2).Rows(0).Item("hourfrom") & "ʱ" & dsdaily.Tables(2).Rows(0).Item("minfrom") & "��"
            xlsheet.Cells(10, 11) = Year(dsdaily.Tables(3).Rows(0).Item("timeto")) & "��" & dsdaily.Tables(3).Rows(0).Item("monthto") & "��" & dsdaily.Tables(3).Rows(0).Item("dayto") & "�� " & dsdaily.Tables(3).Rows(0).Item("hourto") & "ʱ" & dsdaily.Tables(3).Rows(0).Item("minto") & "��"
            If dsdaily.Tables(0).Rows.Count >= 4 Then
                row = 0
                xlsheet.Cells(15, 1) = dsdaily.Tables(0).Rows(0)(0)
                xlsheet.Cells(15, 2) = dsdaily.Tables(0).Rows(0)(1)
                xlsheet.Cells(16, 3) = dsdaily.Tables(0).Rows(0)(2)
                xlsheet.Cells(15, 4) = dsdaily.Tables(0).Rows(0)(3)
                xlsheet.Cells(16, 5) = dsdaily.Tables(0).Rows(0)(4)
                xlsheet.Cells(15, 6) = dsdaily.Tables(0).Rows(0)(5)
                xlsheet.Cells(16, 7) = dsdaily.Tables(0).Rows(0)(6)
                xlsheet.Cells(15, 8) = dsdaily.Tables(0).Rows(0)(7)
                xlsheet.Cells(16, 9) = dsdaily.Tables(0).Rows(0)(8)
                xlsheet.Cells(15, 10) = dsdaily.Tables(0).Rows(0)(9)
                xlsheet.Cells(16, 11) = dsdaily.Tables(0).Rows(0)(10)
                xlsheet.Cells(15, 12) = dsdaily.Tables(0).Rows(0)(11)
                xlsheet.Cells(16, 13) = dsdaily.Tables(0).Rows(0)(12)
                xlsheet.Cells(15, 14) = dsdaily.Tables(0).Rows(0)(13)
                xlsheet.Cells(16, 15) = dsdaily.Tables(0).Rows(0)(14)
                row = 1
                xlsheet.Cells(25, 2) = dsdaily.Tables(0).Rows(row)(1)
                xlsheet.Cells(26, 3) = dsdaily.Tables(0).Rows(row)(2)
                xlsheet.Cells(25, 4) = dsdaily.Tables(0).Rows(row)(3)
                xlsheet.Cells(26, 5) = dsdaily.Tables(0).Rows(row)(4)
                xlsheet.Cells(25, 6) = dsdaily.Tables(0).Rows(row)(5)
                xlsheet.Cells(26, 7) = dsdaily.Tables(0).Rows(row)(6)
                xlsheet.Cells(25, 8) = dsdaily.Tables(0).Rows(row)(7)
                xlsheet.Cells(26, 9) = dsdaily.Tables(0).Rows(row)(8)
                xlsheet.Cells(25, 10) = dsdaily.Tables(0).Rows(row)(9)
                xlsheet.Cells(26, 11) = dsdaily.Tables(0).Rows(row)(10)
                xlsheet.Cells(25, 12) = dsdaily.Tables(0).Rows(row)(11)
                xlsheet.Cells(26, 13) = dsdaily.Tables(0).Rows(row)(12)
                xlsheet.Cells(25, 14) = dsdaily.Tables(0).Rows(row)(13)
                xlsheet.Cells(26, 15) = dsdaily.Tables(0).Rows(row)(14)

                row = 2
                xlsheet.Cells(27, 2) = dsdaily.Tables(0).Rows(row)(1)
                xlsheet.Cells(28, 3) = dsdaily.Tables(0).Rows(row)(2)
                xlsheet.Cells(27, 4) = dsdaily.Tables(0).Rows(row)(3)
                xlsheet.Cells(28, 5) = dsdaily.Tables(0).Rows(row)(4)
                xlsheet.Cells(27, 6) = dsdaily.Tables(0).Rows(row)(5)
                xlsheet.Cells(28, 7) = dsdaily.Tables(0).Rows(row)(6)
                xlsheet.Cells(27, 8) = dsdaily.Tables(0).Rows(row)(7)
                xlsheet.Cells(28, 9) = dsdaily.Tables(0).Rows(row)(8)
                xlsheet.Cells(27, 10) = dsdaily.Tables(0).Rows(row)(9)
                xlsheet.Cells(28, 11) = dsdaily.Tables(0).Rows(row)(10)
                xlsheet.Cells(27, 12) = dsdaily.Tables(0).Rows(row)(11)
                xlsheet.Cells(28, 13) = dsdaily.Tables(0).Rows(row)(12)
                xlsheet.Cells(27, 14) = dsdaily.Tables(0).Rows(row)(13)
                xlsheet.Cells(28, 15) = dsdaily.Tables(0).Rows(row)(14)

                row = 3
                xlsheet.Cells(29, 2) = dsdaily.Tables(0).Rows(row)(1)
                xlsheet.Cells(30, 3) = dsdaily.Tables(0).Rows(row)(2)
                xlsheet.Cells(29, 4) = dsdaily.Tables(0).Rows(row)(3)
                xlsheet.Cells(30, 5) = dsdaily.Tables(0).Rows(row)(4)
                xlsheet.Cells(29, 6) = dsdaily.Tables(0).Rows(row)(5)
                xlsheet.Cells(30, 7) = dsdaily.Tables(0).Rows(row)(6)
                xlsheet.Cells(29, 8) = dsdaily.Tables(0).Rows(row)(7)
                xlsheet.Cells(30, 9) = dsdaily.Tables(0).Rows(row)(8)
                xlsheet.Cells(29, 10) = dsdaily.Tables(0).Rows(row)(9)
                xlsheet.Cells(30, 11) = dsdaily.Tables(0).Rows(row)(10)
                xlsheet.Cells(29, 12) = dsdaily.Tables(0).Rows(row)(11)
                xlsheet.Cells(30, 13) = dsdaily.Tables(0).Rows(row)(12)
                xlsheet.Cells(29, 14) = dsdaily.Tables(0).Rows(row)(13)
                xlsheet.Cells(30, 15) = dsdaily.Tables(0).Rows(row)(14)

            End If
            xlsheet.Cells(31, 2) = REMARKS
            xlsheet.Cells(32, 12) = LIST_MAN
            xlsheet.PrintPreview()
        Catch
            xlapp.Quit()
            SendKeys.Send("n")
        End Try
    End Sub
    Private Sub eng()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer

        Try
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "Report_zlp3.xls", pathstr + "Report.xls")
            Filepath = pathstr + "report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("��װ���ձ���E��"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = True

            xlsheet.Cells(10, 2) = ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
            xlsheet.Cells(10, 5) = ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            xlsheet.Cells(10, 7) = dsdaily.Tables(1).Rows(0).Item("berth")
            xlsheet.Cells(10, 10) = dsdaily.Tables(2).Rows(0).Item("hourfrom") & ":" & dsdaily.Tables(2).Rows(0).Item("minfrom")
            xlsheet.Cells(10, 12) = dsdaily.Tables(3).Rows(0).Item("hourto") & ":" & dsdaily.Tables(3).Rows(0).Item("minto")
            If Year(dsdaily.Tables(2).Rows(0).Item("timefrom")) = Year(dsdaily.Tables(3).Rows(0).Item("timeto")) And Month(dsdaily.Tables(2).Rows(0).Item("timefrom")) = Month(dsdaily.Tables(3).Rows(0).Item("timeto")) And Day(dsdaily.Tables(2).Rows(0).Item("timefrom")) = Day(dsdaily.Tables(3).Rows(0).Item("timeto")) Then
                xlsheet.Cells(10, 14) = dsdaily.Tables(2).Rows(0).Item("dayfrom") & "-" & dsdaily.Tables(2).Rows(0).Item("monthfrom") & "-" & Year(dsdaily.Tables(2).Rows(0).Item("timefrom"))
            Else
                xlsheet.Cells(10, 14) = dsdaily.Tables(2).Rows(0).Item("dayfrom") & "/" & dsdaily.Tables(3).Rows(0).Item("dayto") & "-" & dsdaily.Tables(2).Rows(0).Item("monthfrom") & "-" & Year(dsdaily.Tables(2).Rows(0).Item("timefrom"))
            End If
            If dsdaily.Tables(0).Rows.Count >= 4 Then
                row = 0
                xlsheet.Cells(15, 1) = dsdaily.Tables(0).Rows(0)(0)
                xlsheet.Cells(15, 2) = dsdaily.Tables(0).Rows(0)(1)
                xlsheet.Cells(16, 3) = dsdaily.Tables(0).Rows(0)(2)
                xlsheet.Cells(15, 4) = dsdaily.Tables(0).Rows(0)(3)
                xlsheet.Cells(16, 5) = dsdaily.Tables(0).Rows(0)(4)
                xlsheet.Cells(15, 6) = dsdaily.Tables(0).Rows(0)(5)
                xlsheet.Cells(16, 7) = dsdaily.Tables(0).Rows(0)(6)
                xlsheet.Cells(15, 8) = dsdaily.Tables(0).Rows(0)(7)
                xlsheet.Cells(16, 9) = dsdaily.Tables(0).Rows(0)(8)
                xlsheet.Cells(15, 10) = dsdaily.Tables(0).Rows(0)(9)
                xlsheet.Cells(16, 11) = dsdaily.Tables(0).Rows(0)(10)
                xlsheet.Cells(15, 12) = dsdaily.Tables(0).Rows(0)(11)
                xlsheet.Cells(16, 13) = dsdaily.Tables(0).Rows(0)(12)
                xlsheet.Cells(15, 14) = dsdaily.Tables(0).Rows(0)(13)
                xlsheet.Cells(16, 15) = dsdaily.Tables(0).Rows(0)(14)
                row = 1
                xlsheet.Cells(25, 2) = dsdaily.Tables(0).Rows(row)(1)
                xlsheet.Cells(26, 3) = dsdaily.Tables(0).Rows(row)(2)
                xlsheet.Cells(25, 4) = dsdaily.Tables(0).Rows(row)(3)
                xlsheet.Cells(26, 5) = dsdaily.Tables(0).Rows(row)(4)
                xlsheet.Cells(25, 6) = dsdaily.Tables(0).Rows(row)(5)
                xlsheet.Cells(26, 7) = dsdaily.Tables(0).Rows(row)(6)
                xlsheet.Cells(25, 8) = dsdaily.Tables(0).Rows(row)(7)
                xlsheet.Cells(26, 9) = dsdaily.Tables(0).Rows(row)(8)
                xlsheet.Cells(25, 10) = dsdaily.Tables(0).Rows(row)(9)
                xlsheet.Cells(26, 11) = dsdaily.Tables(0).Rows(row)(10)
                xlsheet.Cells(25, 12) = dsdaily.Tables(0).Rows(row)(11)
                xlsheet.Cells(26, 13) = dsdaily.Tables(0).Rows(row)(12)
                xlsheet.Cells(25, 14) = dsdaily.Tables(0).Rows(row)(13)
                xlsheet.Cells(26, 15) = dsdaily.Tables(0).Rows(row)(14)

                row = 2
                xlsheet.Cells(27, 2) = dsdaily.Tables(0).Rows(row)(1)
                xlsheet.Cells(28, 3) = dsdaily.Tables(0).Rows(row)(2)
                xlsheet.Cells(27, 4) = dsdaily.Tables(0).Rows(row)(3)
                xlsheet.Cells(28, 5) = dsdaily.Tables(0).Rows(row)(4)
                xlsheet.Cells(27, 6) = dsdaily.Tables(0).Rows(row)(5)
                xlsheet.Cells(28, 7) = dsdaily.Tables(0).Rows(row)(6)
                xlsheet.Cells(27, 8) = dsdaily.Tables(0).Rows(row)(7)
                xlsheet.Cells(28, 9) = dsdaily.Tables(0).Rows(row)(8)
                xlsheet.Cells(27, 10) = dsdaily.Tables(0).Rows(row)(9)
                xlsheet.Cells(28, 11) = dsdaily.Tables(0).Rows(row)(10)
                xlsheet.Cells(27, 12) = dsdaily.Tables(0).Rows(row)(11)
                xlsheet.Cells(28, 13) = dsdaily.Tables(0).Rows(row)(12)
                xlsheet.Cells(27, 14) = dsdaily.Tables(0).Rows(row)(13)
                xlsheet.Cells(28, 15) = dsdaily.Tables(0).Rows(row)(14)

                row = 3
                xlsheet.Cells(29, 2) = dsdaily.Tables(0).Rows(row)(1)
                xlsheet.Cells(30, 3) = dsdaily.Tables(0).Rows(row)(2)
                xlsheet.Cells(29, 4) = dsdaily.Tables(0).Rows(row)(3)
                xlsheet.Cells(30, 5) = dsdaily.Tables(0).Rows(row)(4)
                xlsheet.Cells(29, 6) = dsdaily.Tables(0).Rows(row)(5)
                xlsheet.Cells(30, 7) = dsdaily.Tables(0).Rows(row)(6)
                xlsheet.Cells(29, 8) = dsdaily.Tables(0).Rows(row)(7)
                xlsheet.Cells(30, 9) = dsdaily.Tables(0).Rows(row)(8)
                xlsheet.Cells(29, 10) = dsdaily.Tables(0).Rows(row)(9)
                xlsheet.Cells(30, 11) = dsdaily.Tables(0).Rows(row)(10)
                xlsheet.Cells(29, 12) = dsdaily.Tables(0).Rows(row)(11)
                xlsheet.Cells(30, 13) = dsdaily.Tables(0).Rows(row)(12)
                xlsheet.Cells(29, 14) = dsdaily.Tables(0).Rows(row)(13)
                xlsheet.Cells(30, 15) = dsdaily.Tables(0).Rows(row)(14)
            End If

            xlsheet.Cells(32, 12) = LIST_MAN

            xlsheet.Cells(31, 2) = REMARKS
            xlsheet.PrintPreview()
        Catch
            xlapp.Quit()
            SendKeys.Send("n")
        End Try
    End Sub
    'Private Sub MakeExcel()
    '    Dim PathStr As String
    '    Dim FilePath As String
    '    Dim Row As Integer
    '    Dim Col As Integer
    '    PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
    '    PathStr = substr(PathStr)
    '    Try
    '        FilePath = PathStr + "Report.xls"
    '        xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
    '        xlBook = CType(xlApp.Workbooks.Open("" & FilePath & ""), Excel.Workbook)
    '        xlSheet = CType(xlBook.Worksheets(1), Excel.Worksheet)
    '        xlApp.DisplayAlerts = False
    '        xlSheet.Application.Visible = True

    '        xlSheet.Cells(1, 1) = Me.Text() '����

    '        For Col = ColNum To Me.C1DBG.Columns.Count - 1 '�б���
    '            xlSheet.Cells(3, Col - ColNum + 1) = Me.C1DBG.Columns(Col).Caption

    '        Next Col
    '        Me.C1DBG.MoveFirst()
    '        For Row = 0 To ds.Tables(0).Rows.Count - 1 '����
    '            For Col = ColNum To Me.C1DBG.Columns.Count - 1
    '                xlSheet.Cells(Row + 4, Col - ColNum + 1) = Me.C1DBG.Columns(Col).Text.ToString      'ds.Tables(0).Rows(Row)(Col)
    '            Next Col
    '            Me.C1DBG.MoveNext()
    '        Next Row
    '        If Me.C1DBG.ColumnFooters = True Then '�ϼ���
    '            For Col = ColNum To Me.C1DBG.Columns.Count - 1
    '                xlSheet.Cells(ds.Tables(0).Rows.Count + 4, Col - ColNum + 1) = Me.C1DBG.Columns(Col).FooterText
    '            Next Col
    '        End If
    '    Catch
    '        xlApp.Quit()
    '        SendKeys.Send("N")
    '    End Try

    'End Sub

    Private Sub preview(ByVal Func As String) '***************Ȩ�����
        Dim sqlstr As String
        Dim Previewdv As DataView
        Dim Previewds As New DataSet()
        Dim i As Integer
        sqlstr = " select FUNC_CODE_Add,FUNC_CODE_Change,FUNC_CODE_Del from View_UserPreview where PART_ID=" & G_Part_Id & " and FUNC_CODE='" & Upper(Func) & "' "
        Previewdv = Getdata(sqlstr, Previewds)
        If Previewdv.Count > 0 Then
            If Previewdv(i)("FUNC_CODE_Add") = 1 Then 'ADD ��ť�ɼ�
                ToolBar.Buttons.Item(3).Enabled = True
                mnuAdd.Enabled = True
            Else                                      'ADD ��ť���ɼ�
                Me.ToolBar.Buttons.Item(3).Enabled = False
                mnuAdd.Enabled = False
            End If
            If Previewdv(i)("FUNC_CODE_Change") = 1 Then '�޸� ��ť�ɼ�
                Me.ToolBar.Buttons.Item(4).Enabled = True
                mnuEdit.Enabled = True
            Else                                          '�޸� ��ť���ɼ�
                Me.ToolBar.Buttons.Item(4).Enabled = False
                mnuEdit.Enabled = False
            End If
            If Previewdv(i)("FUNC_CODE_Del") = 1 Then 'ɾ�� ��ť�ɼ�
                Me.ToolBar.Buttons.Item(5).Enabled = True
                mnuDelete.Enabled = True
            Else                                     'ɾ����ť���ɼ�
                Me.ToolBar.Buttons.Item(5).Enabled = False
                mnuDelete.Enabled = False
            End If
        End If

    End Sub
    Private Sub C1DBG_FetchRowStyle(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs)
        If Me.C1DBG.Columns("Logic").CellValue(e.Row) = 1 Then
            e.CellStyle.BackColor = System.Drawing.Color.LemonChiffon
        End If

    End Sub

    Private Sub Frm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.C1DBGV.Height = Me.Height - 130
        Me.C1DBG.Height = Me.Height - 120
        Me.C1DBG.Width = Me.GB.Width - 5
        Me.Label.Width = Me.C1DBG.Width - 3
        Me.Label1.Top = Me.C1DBGV.Height + 20
        Me.txtShipName.Top = Me.C1DBGV.Height + 20
        Me.Label2.Top = Me.C1DBGV.Height + 40
        Me.txtVoyage.Top = Me.C1DBGV.Height + 40
        Me.btResure.Top = Me.C1DBGV.Height + 40
    End Sub

    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        TBar = 1
        Mnu = 1
    End Sub

    Private Sub btResure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResure.Click
        SqlStrShip = "where (((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','4')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) and Voyage like '" & Trim(txtVoyage.Text) & "%' and (ENG_VESSEL Like '" & Trim(txtShipName.Text) & "%' OR CHI_VESSEL like '" & Trim(txtShipName.Text) & "%' )) "
        '����Ҫ�޸�
        G_ShipName = Trim(txtShipName.Text)
        G_Voyage = Trim(txtVoyage.Text)
        Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '����Ҫ�޸�
        Call C1DBGV_DoubleClick(sender, e)
    End Sub

    Private Sub txtShipName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtShipName.KeyPress
        If e.KeyChar = Chr(13) Then
            txtVoyage.Focus()
        End If
    End Sub
    Private Sub txtVoyage_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVoyage.KeyPress
        If e.KeyChar = Chr(13) Then
            Call btResure_Click(sender, e)
        End If
    End Sub
End Class