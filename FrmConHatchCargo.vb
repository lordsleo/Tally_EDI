Imports TALLY.DBControl
Public Class FrmConHatchCargo
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

    Public Shared Bill_ID As String
    Public Shared Container_ID As String
    Public Shared Mark_ID As String
    Public Shared InOutCode As String
    Friend WithEvents mnuInOut As System.Windows.Forms.MenuItem
    Friend WithEvents tbnInOut As System.Windows.Forms.ToolBarButton
    Dim strAgent As String  '船代代码

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
    Friend WithEvents tbbtnSep1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnOK As System.Windows.Forms.ToolBarButton
    Friend WithEvents S2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSearch As System.Windows.Forms.ToolBarButton
    Friend WithEvents S3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSort As System.Windows.Forms.ToolBarButton
    Friend WithEvents S4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnEng As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents tbbtnAdd As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnPrint As System.Windows.Forms.ToolBarButton
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
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    Friend WithEvents tbbtnFind As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnQuery As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnEdit As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnDelete As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnExport As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnQuit As System.Windows.Forms.ToolBarButton
    Friend WithEvents GBV As System.Windows.Forms.GroupBox
    Friend WithEvents ToolBarV As System.Windows.Forms.ToolBar
    Friend WithEvents C1DBGV As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btResure As System.Windows.Forms.Button
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbbClearAll As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbStep4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuClearAll As System.Windows.Forms.MenuItem
    Friend WithEvents tbbModiAllCon As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuModiAllCon As System.Windows.Forms.MenuItem
    Friend WithEvents tbbSeeClass As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuSeeClass As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTransRelation As System.Windows.Forms.MenuItem
    Friend WithEvents tbbTransRelation As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSelect As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuLookUp As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCheck As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnCheck As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuRent As System.Windows.Forms.MenuItem
    Friend WithEvents tbbnRent As System.Windows.Forms.ToolBarButton
    Friend WithEvents Splitter3 As System.Windows.Forms.Splitter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConHatchCargo))
        Me.tbbtnSep1 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnOK = New System.Windows.Forms.ToolBarButton
        Me.S2 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSearch = New System.Windows.Forms.ToolBarButton
        Me.S3 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSort = New System.Windows.Forms.ToolBarButton
        Me.S4 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnEng = New System.Windows.Forms.ToolBarButton
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.tbbtnAdd = New System.Windows.Forms.ToolBarButton
        Me.tbbtnPrint = New System.Windows.Forms.ToolBarButton
        Me.MainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuFind = New System.Windows.Forms.MenuItem
        Me.mnuQuery = New System.Windows.Forms.MenuItem
        Me.mnuLookUp = New System.Windows.Forms.MenuItem
        Me.mnuSeeClass = New System.Windows.Forms.MenuItem
        Me.mnuCheck = New System.Windows.Forms.MenuItem
        Me.mnuSep1 = New System.Windows.Forms.MenuItem
        Me.mnuPrint = New System.Windows.Forms.MenuItem
        Me.mnuExport = New System.Windows.Forms.MenuItem
        Me.mnuSep2 = New System.Windows.Forms.MenuItem
        Me.mnuQuit = New System.Windows.Forms.MenuItem
        Me.mnuCompile = New System.Windows.Forms.MenuItem
        Me.mnuAdd = New System.Windows.Forms.MenuItem
        Me.mnuEdit = New System.Windows.Forms.MenuItem
        Me.mnuModiAllCon = New System.Windows.Forms.MenuItem
        Me.mnuTransRelation = New System.Windows.Forms.MenuItem
        Me.mnuDelete = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.mnuClearAll = New System.Windows.Forms.MenuItem
        Me.mnuRent = New System.Windows.Forms.MenuItem
        Me.mnuInOut = New System.Windows.Forms.MenuItem
        Me.mnuHelp = New System.Windows.Forms.MenuItem
        Me.GB = New System.Windows.Forms.GroupBox
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label = New System.Windows.Forms.Label
        Me.ToolBar = New System.Windows.Forms.ToolBar
        Me.tbbtnFind = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuery = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSelect = New System.Windows.Forms.ToolBarButton
        Me.tbbSeeClass = New System.Windows.Forms.ToolBarButton
        Me.tbbtnEdit = New System.Windows.Forms.ToolBarButton
        Me.tbbModiAllCon = New System.Windows.Forms.ToolBarButton
        Me.tbbTransRelation = New System.Windows.Forms.ToolBarButton
        Me.tbbnRent = New System.Windows.Forms.ToolBarButton
        Me.tbbtnDelete = New System.Windows.Forms.ToolBarButton
        Me.tbbStep4 = New System.Windows.Forms.ToolBarButton
        Me.tbbClearAll = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep2 = New System.Windows.Forms.ToolBarButton
        Me.tbnInOut = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep3 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnCheck = New System.Windows.Forms.ToolBarButton
        Me.tbbtnExport = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuit = New System.Windows.Forms.ToolBarButton
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
        'tbbtnSep1
        '
        Me.tbbtnSep1.Name = "tbbtnSep1"
        Me.tbbtnSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnOK
        '
        Me.tbbtnOK.ImageIndex = 8
        Me.tbbtnOK.Name = "tbbtnOK"
        Me.tbbtnOK.Text = "常规"
        '
        'S2
        '
        Me.S2.Name = "S2"
        Me.S2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnSearch
        '
        Me.tbbtnSearch.ImageIndex = 9
        Me.tbbtnSearch.Name = "tbbtnSearch"
        Me.tbbtnSearch.Text = "检索"
        '
        'S3
        '
        Me.S3.Name = "S3"
        Me.S3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnSort
        '
        Me.tbbtnSort.ImageIndex = 10
        Me.tbbtnSort.Name = "tbbtnSort"
        Me.tbbtnSort.Text = "排序"
        '
        'S4
        '
        Me.S4.Name = "S4"
        Me.S4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnEng
        '
        Me.tbbtnEng.ImageIndex = 11
        Me.tbbtnEng.Name = "tbbtnEng"
        Me.tbbtnEng.Text = "英文"
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "")
        Me.ImageList.Images.SetKeyName(1, "")
        Me.ImageList.Images.SetKeyName(2, "")
        Me.ImageList.Images.SetKeyName(3, "")
        Me.ImageList.Images.SetKeyName(4, "")
        Me.ImageList.Images.SetKeyName(5, "")
        Me.ImageList.Images.SetKeyName(6, "")
        Me.ImageList.Images.SetKeyName(7, "")
        Me.ImageList.Images.SetKeyName(8, "")
        Me.ImageList.Images.SetKeyName(9, "")
        Me.ImageList.Images.SetKeyName(10, "")
        Me.ImageList.Images.SetKeyName(11, "")
        Me.ImageList.Images.SetKeyName(12, "Start_Icon_WinLive.png")
        Me.ImageList.Images.SetKeyName(13, "00002.ico")
        Me.ImageList.Images.SetKeyName(14, "0013.GIF")
        Me.ImageList.Images.SetKeyName(15, "314966.gif")
        Me.ImageList.Images.SetKeyName(16, "200641474216228.png")
        Me.ImageList.Images.SetKeyName(17, "AUTHOR.ICO")
        Me.ImageList.Images.SetKeyName(18, "BOOK1.ICO")
        Me.ImageList.Images.SetKeyName(19, "BOOK06.ICO")
        Me.ImageList.Images.SetKeyName(20, "Calendar.png")
        Me.ImageList.Images.SetKeyName(21, "character3.ico")
        Me.ImageList.Images.SetKeyName(22, "CHome_WindowsLive_Search.png")
        Me.ImageList.Images.SetKeyName(23, "CHome_WindowsLive_SignIn.png")
        Me.ImageList.Images.SetKeyName(24, "CHome_WindowsLive_Sync.png")
        Me.ImageList.Images.SetKeyName(25, "cy_rbful.ico")
        Me.ImageList.Images.SetKeyName(26, "EYE1.ICO")
        Me.ImageList.Images.SetKeyName(27, "Fax1.ico")
        Me.ImageList.Images.SetKeyName(28, "Find.gif")
        Me.ImageList.Images.SetKeyName(29, "FINDE.ICO")
        Me.ImageList.Images.SetKeyName(30, "FINDER2.ICO")
        Me.ImageList.Images.SetKeyName(31, "FINDER.ICO")
        Me.ImageList.Images.SetKeyName(32, "FONT02.ICO")
        Me.ImageList.Images.SetKeyName(33, "FORMATED.ICO")
        Me.ImageList.Images.SetKeyName(34, "GLOBE1.ICO")
        Me.ImageList.Images.SetKeyName(35, "hct.jpg")
        Me.ImageList.Images.SetKeyName(36, "INKJET.ICO")
        Me.ImageList.Images.SetKeyName(37, "INSPECT.ICO")
        Me.ImageList.Images.SetKeyName(38, "login2.gif")
        Me.ImageList.Images.SetKeyName(39, "LS_Alarm.png")
        Me.ImageList.Images.SetKeyName(40, "LS_LockSlider.PNG")
        Me.ImageList.Images.SetKeyName(41, "MYBOOK.ICO")
        Me.ImageList.Images.SetKeyName(42, "NEWT~328.ICO")
        Me.ImageList.Images.SetKeyName(43, "NOTEPA~1.ICO")
        Me.ImageList.Images.SetKeyName(44, "NOTEPA~2.ICO")
        Me.ImageList.Images.SetKeyName(45, "pic_ywzx.gif")
        Me.ImageList.Images.SetKeyName(46, "PRINT3.ICO")
        Me.ImageList.Images.SetKeyName(47, "PRINT6.ICO")
        Me.ImageList.Images.SetKeyName(48, "PRINT.ICO")
        Me.ImageList.Images.SetKeyName(49, "Printers.bmp")
        Me.ImageList.Images.SetKeyName(50, "RECYCLE.ICO")
        Me.ImageList.Images.SetKeyName(51, "RECYCLIN.ICO")
        Me.ImageList.Images.SetKeyName(52, "SETTINGS.ICO")
        Me.ImageList.Images.SetKeyName(53, "Start_Icon_AdobeReader.png")
        Me.ImageList.Images.SetKeyName(54, "Start_Icon_Ali.png")
        Me.ImageList.Images.SetKeyName(55, "Start_Icon_Async.png")
        Me.ImageList.Images.SetKeyName(56, "Start_Icon_Beam.png")
        Me.ImageList.Images.SetKeyName(57, "Start_Icon_BeeLineGPS.png")
        Me.ImageList.Images.SetKeyName(58, "Start_Icon_CareLand.png")
        Me.ImageList.Images.SetKeyName(59, "Start_Icon_Clock.png")
        Me.ImageList.Images.SetKeyName(60, "Start_Icon_Fetion.png")
        Me.ImageList.Images.SetKeyName(61, "Start_Icon_GoogleMaps.png")
        Me.ImageList.Images.SetKeyName(62, "Start_Icon_GPS.png")
        Me.ImageList.Images.SetKeyName(63, "Start_Icon_IS.png")
        Me.ImageList.Images.SetKeyName(64, "Start_Icon_JPSKB.png")
        Me.ImageList.Images.SetKeyName(65, "Start_Icon_KuGou.png")
        Me.ImageList.Images.SetKeyName(66, "Start_Icon_Lock2.png")
        Me.ImageList.Images.SetKeyName(67, "Start_Icon_MicrophoneAGC.png")
        Me.ImageList.Images.SetKeyName(68, "Start_Icon_Notepad.png")
        Me.ImageList.Images.SetKeyName(69, "Start_Icon_Office.png")
        Me.ImageList.Images.SetKeyName(70, "Start_Icon_Opera.png")
        Me.ImageList.Images.SetKeyName(71, "Start_Icon_Owner.png")
        Me.ImageList.Images.SetKeyName(72, "Start_Icon_Quick.png")
        Me.ImageList.Images.SetKeyName(73, "Start_Icon_TodaySet.png")
        Me.ImageList.Images.SetKeyName(74, "Start_Icon_VoiceSpeedDial.png")
        Me.ImageList.Images.SetKeyName(75, "PRINT6.ICO")
        Me.ImageList.Images.SetKeyName(76, "200641474216228.png")
        Me.ImageList.Images.SetKeyName(77, "11513160465535804.jpg")
        Me.ImageList.Images.SetKeyName(78, "AUTHOR.ICO")
        Me.ImageList.Images.SetKeyName(79, "BOOK1.ICO")
        Me.ImageList.Images.SetKeyName(80, "BOOK06.ICO")
        Me.ImageList.Images.SetKeyName(81, "character3.ico")
        Me.ImageList.Images.SetKeyName(82, "cy_rbemp.ico")
        Me.ImageList.Images.SetKeyName(83, "cy_rbful.ico")
        Me.ImageList.Images.SetKeyName(84, "EMAIL11.png")
        Me.ImageList.Images.SetKeyName(85, "EXIT1.ICO")
        Me.ImageList.Images.SetKeyName(86, "EYE1.ICO")
        Me.ImageList.Images.SetKeyName(87, "FONT02.ICO")
        Me.ImageList.Images.SetKeyName(88, "FORMATED.ICO")
        Me.ImageList.Images.SetKeyName(89, "GLOBE1.ICO")
        Me.ImageList.Images.SetKeyName(90, "hct.jpg")
        Me.ImageList.Images.SetKeyName(91, "hg6.ICO")
        Me.ImageList.Images.SetKeyName(92, "kq1.ico")
        Me.ImageList.Images.SetKeyName(93, "MACOS~1.ICO")
        Me.ImageList.Images.SetKeyName(94, "NOTEPA~1.ICO")
        Me.ImageList.Images.SetKeyName(95, "NOTEPA~2.ICO")
        Me.ImageList.Images.SetKeyName(96, "pic_ywzx.gif")
        Me.ImageList.Images.SetKeyName(97, "PRINT3.ICO")
        Me.ImageList.Images.SetKeyName(98, "SETTINGS.ICO")
        Me.ImageList.Images.SetKeyName(99, "PRINT.ICO")
        Me.ImageList.Images.SetKeyName(100, "RECYCLE.ICO")
        Me.ImageList.Images.SetKeyName(101, "RECYCLIN.ICO")
        Me.ImageList.Images.SetKeyName(102, "WRITE3.ICO")
        Me.ImageList.Images.SetKeyName(103, "VIEWER1.ICO")
        Me.ImageList.Images.SetKeyName(104, "VIEWER2.ICO")
        Me.ImageList.Images.SetKeyName(105, "VIEWER3.ICO")
        Me.ImageList.Images.SetKeyName(106, "VIEWER4.ICO")
        Me.ImageList.Images.SetKeyName(107, "Windows.ico")
        Me.ImageList.Images.SetKeyName(108, "WORD~216.ICO")
        Me.ImageList.Images.SetKeyName(109, "winxfile.ico")
        Me.ImageList.Images.SetKeyName(110, "Start_Icon_Fetion.png")
        '
        'tbbtnAdd
        '
        Me.tbbtnAdd.ImageIndex = 2
        Me.tbbtnAdd.Name = "tbbtnAdd"
        Me.tbbtnAdd.Text = "增加"
        Me.tbbtnAdd.ToolTipText = "增加"
        '
        'tbbtnPrint
        '
        Me.tbbtnPrint.ImageIndex = 5
        Me.tbbtnPrint.Name = "tbbtnPrint"
        Me.tbbtnPrint.Text = "打印"
        Me.tbbtnPrint.ToolTipText = "打印"
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuCompile, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFind, Me.mnuQuery, Me.mnuLookUp, Me.mnuSeeClass, Me.mnuCheck, Me.mnuSep1, Me.mnuPrint, Me.mnuExport, Me.mnuSep2, Me.mnuQuit})
        Me.mnuFile.Text = "文件(&F)"
        '
        'mnuFind
        '
        Me.mnuFind.Enabled = False
        Me.mnuFind.Index = 0
        Me.mnuFind.Text = "检索(&F)"
        '
        'mnuQuery
        '
        Me.mnuQuery.Enabled = False
        Me.mnuQuery.Index = 1
        Me.mnuQuery.Text = "查看(&Q)"
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
        'mnuCheck
        '
        Me.mnuCheck.Index = 4
        Me.mnuCheck.Text = "核对"
        '
        'mnuSep1
        '
        Me.mnuSep1.Index = 5
        Me.mnuSep1.Text = "-"
        '
        'mnuPrint
        '
        Me.mnuPrint.Enabled = False
        Me.mnuPrint.Index = 6
        Me.mnuPrint.Text = "打印(&P)..."
        '
        'mnuExport
        '
        Me.mnuExport.Enabled = False
        Me.mnuExport.Index = 7
        Me.mnuExport.Text = "导出(&E)"
        '
        'mnuSep2
        '
        Me.mnuSep2.Index = 8
        Me.mnuSep2.Text = "-"
        '
        'mnuQuit
        '
        Me.mnuQuit.Index = 9
        Me.mnuQuit.Text = "退出(&X)"
        '
        'mnuCompile
        '
        Me.mnuCompile.Index = 1
        Me.mnuCompile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAdd, Me.mnuEdit, Me.mnuModiAllCon, Me.mnuTransRelation, Me.mnuDelete, Me.MenuItem1, Me.mnuClearAll, Me.mnuRent, Me.mnuInOut})
        Me.mnuCompile.Text = "编辑(&E)"
        '
        'mnuAdd
        '
        Me.mnuAdd.Enabled = False
        Me.mnuAdd.Index = 0
        Me.mnuAdd.Text = "增加(&A)"
        '
        'mnuEdit
        '
        Me.mnuEdit.Enabled = False
        Me.mnuEdit.Index = 1
        Me.mnuEdit.Text = "编辑(&E)"
        '
        'mnuModiAllCon
        '
        Me.mnuModiAllCon.Index = 2
        Me.mnuModiAllCon.Text = "全箱改(&M)"
        '
        'mnuTransRelation
        '
        Me.mnuTransRelation.Index = 3
        Me.mnuTransRelation.Text = "关系(&R)"
        '
        'mnuDelete
        '
        Me.mnuDelete.Enabled = False
        Me.mnuDelete.Index = 4
        Me.mnuDelete.Text = "删除(&D)"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 5
        Me.MenuItem1.Text = "-"
        '
        'mnuClearAll
        '
        Me.mnuClearAll.Index = 6
        Me.mnuClearAll.Text = "全部清除(&C)"
        '
        'mnuRent
        '
        Me.mnuRent.Index = 7
        Me.mnuRent.Text = "互租箱位"
        '
        'mnuInOut
        '
        Me.mnuInOut.Index = 8
        Me.mnuInOut.Text = "内外贸"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.Text = "帮助(&H)"
        '
        'GB
        '
        Me.GB.Controls.Add(Me.C1DBG)
        Me.GB.Controls.Add(Me.Label)
        Me.GB.Controls.Add(Me.ToolBar)
        Me.GB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB.Location = New System.Drawing.Point(182, 0)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(830, 417)
        Me.GB.TabIndex = 7
        Me.GB.TabStop = False
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("C1DBG.Images"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(3, 95)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.PageSettings = CType(resources.GetObject("C1DBG.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBG.Size = New System.Drawing.Size(824, 319)
        Me.C1DBG.TabIndex = 10
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = resources.GetString("C1DBG.PropBag")
        '
        'Label
        '
        Me.Label.BackColor = System.Drawing.SystemColors.Control
        Me.Label.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label.Location = New System.Drawing.Point(3, 58)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(824, 37)
        Me.Label.TabIndex = 11
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolBar
        '
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnFind, Me.tbbtnQuery, Me.tbbtnSelect, Me.tbbSeeClass, Me.tbbtnSep1, Me.tbbtnAdd, Me.tbbtnEdit, Me.tbbModiAllCon, Me.tbbTransRelation, Me.tbbnRent, Me.tbbtnDelete, Me.tbbStep4, Me.tbbClearAll, Me.tbbtnSep2, Me.tbnInOut, Me.tbbtnSep3, Me.tbbtnCheck, Me.tbbtnExport, Me.tbbtnPrint, Me.tbbtnQuit})
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.Enabled = False
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(3, 17)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(824, 41)
        Me.ToolBar.TabIndex = 9
        '
        'tbbtnFind
        '
        Me.tbbtnFind.ImageIndex = 0
        Me.tbbtnFind.Name = "tbbtnFind"
        Me.tbbtnFind.Text = "检索"
        Me.tbbtnFind.ToolTipText = "检索"
        '
        'tbbtnQuery
        '
        Me.tbbtnQuery.ImageIndex = 1
        Me.tbbtnQuery.Name = "tbbtnQuery"
        Me.tbbtnQuery.Text = "查看"
        Me.tbbtnQuery.ToolTipText = "查看"
        '
        'tbbtnSelect
        '
        Me.tbbtnSelect.ImageIndex = 105
        Me.tbbtnSelect.Name = "tbbtnSelect"
        Me.tbbtnSelect.Text = "查找"
        Me.tbbtnSelect.ToolTipText = "查找"
        '
        'tbbSeeClass
        '
        Me.tbbSeeClass.ImageIndex = 86
        Me.tbbSeeClass.Name = "tbbSeeClass"
        Me.tbbSeeClass.Text = "总览"
        Me.tbbSeeClass.ToolTipText = "总览"
        '
        'tbbtnEdit
        '
        Me.tbbtnEdit.ImageIndex = 3
        Me.tbbtnEdit.Name = "tbbtnEdit"
        Me.tbbtnEdit.Text = "编辑"
        Me.tbbtnEdit.ToolTipText = "编辑"
        '
        'tbbModiAllCon
        '
        Me.tbbModiAllCon.ImageIndex = 88
        Me.tbbModiAllCon.Name = "tbbModiAllCon"
        Me.tbbModiAllCon.Text = "全箱改"
        Me.tbbModiAllCon.ToolTipText = "修改全部箱信息"
        '
        'tbbTransRelation
        '
        Me.tbbTransRelation.ImageIndex = 110
        Me.tbbTransRelation.Name = "tbbTransRelation"
        Me.tbbTransRelation.Text = "关系"
        Me.tbbTransRelation.ToolTipText = "更改箱提单关系"
        '
        'tbbnRent
        '
        Me.tbbnRent.ImageIndex = 74
        Me.tbbnRent.Name = "tbbnRent"
        Me.tbbnRent.Text = "互租"
        Me.tbbnRent.ToolTipText = "互租箱位 按提单处理"
        '
        'tbbtnDelete
        '
        Me.tbbtnDelete.ImageIndex = 4
        Me.tbbtnDelete.Name = "tbbtnDelete"
        Me.tbbtnDelete.Text = "删除"
        Me.tbbtnDelete.ToolTipText = "删除"
        '
        'tbbStep4
        '
        Me.tbbStep4.Name = "tbbStep4"
        Me.tbbStep4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbClearAll
        '
        Me.tbbClearAll.ImageIndex = 87
        Me.tbbClearAll.Name = "tbbClearAll"
        Me.tbbClearAll.Text = "全部清除"
        Me.tbbClearAll.ToolTipText = "清除当前所有信息"
        '
        'tbbtnSep2
        '
        Me.tbbtnSep2.Name = "tbbtnSep2"
        Me.tbbtnSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbnInOut
        '
        Me.tbnInOut.ImageIndex = 93
        Me.tbnInOut.Name = "tbnInOut"
        Me.tbnInOut.Text = "内外贸"
        Me.tbnInOut.ToolTipText = "内外贸处理"
        '
        'tbbtnSep3
        '
        Me.tbbtnSep3.Name = "tbbtnSep3"
        Me.tbbtnSep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnCheck
        '
        Me.tbbtnCheck.ImageIndex = 94
        Me.tbbtnCheck.Name = "tbbtnCheck"
        Me.tbbtnCheck.Text = "核对"
        Me.tbbtnCheck.ToolTipText = "核对舱单船图"
        '
        'tbbtnExport
        '
        Me.tbbtnExport.ImageIndex = 6
        Me.tbbtnExport.Name = "tbbtnExport"
        Me.tbbtnExport.Text = "导出"
        Me.tbbtnExport.ToolTipText = "导出Excel"
        '
        'tbbtnQuit
        '
        Me.tbbtnQuit.ImageIndex = 7
        Me.tbbtnQuit.Name = "tbbtnQuit"
        Me.tbbtnQuit.Text = "退出"
        Me.tbbtnQuit.ToolTipText = "退出"
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
        Me.GBV.Size = New System.Drawing.Size(182, 417)
        Me.GBV.TabIndex = 6
        Me.GBV.TabStop = False
        '
        'btResure
        '
        Me.btResure.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btResure.Location = New System.Drawing.Point(122, 354)
        Me.btResure.Name = "btResure"
        Me.btResure.Size = New System.Drawing.Size(56, 22)
        Me.btResure.TabIndex = 2
        Me.btResure.Text = "查询"
        '
        'txtVoyage
        '
        Me.txtVoyage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtVoyage.Location = New System.Drawing.Point(46, 354)
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(88, 21)
        Me.txtVoyage.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(2, 356)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "航次"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShipName
        '
        Me.txtShipName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtShipName.Location = New System.Drawing.Point(46, 332)
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.Size = New System.Drawing.Size(132, 21)
        Me.txtShipName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(2, 334)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "船名"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolBarV
        '
        Me.ToolBarV.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnOK, Me.S2, Me.tbbtnSearch, Me.S3, Me.tbbtnSort, Me.S4, Me.tbbtnEng})
        Me.ToolBarV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBarV.DropDownArrows = True
        Me.ToolBarV.ImageList = Me.ImageList
        Me.ToolBarV.Location = New System.Drawing.Point(3, 373)
        Me.ToolBarV.Name = "ToolBarV"
        Me.ToolBarV.ShowToolTips = True
        Me.ToolBarV.Size = New System.Drawing.Size(176, 41)
        Me.ToolBarV.TabIndex = 4
        '
        'C1DBGV
        '
        Me.C1DBGV.AllowUpdate = False
        Me.C1DBGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGV.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGV.Images.Add(CType(resources.GetObject("C1DBGV.Images"), System.Drawing.Image))
        Me.C1DBGV.Location = New System.Drawing.Point(2, 17)
        Me.C1DBGV.Name = "C1DBGV"
        Me.C1DBGV.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGV.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGV.PreviewInfo.ZoomFactor = 75
        Me.C1DBGV.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGV.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGV.Size = New System.Drawing.Size(178, 313)
        Me.C1DBGV.TabIndex = 3
        Me.C1DBGV.Text = "C1TrueDBGrid1"
        Me.C1DBGV.PropBag = resources.GetString("C1DBGV.PropBag")
        '
        'Splitter3
        '
        Me.Splitter3.BackColor = System.Drawing.Color.Maroon
        Me.Splitter3.Location = New System.Drawing.Point(182, 0)
        Me.Splitter3.Name = "Splitter3"
        Me.Splitter3.Size = New System.Drawing.Size(3, 417)
        Me.Splitter3.TabIndex = 15
        Me.Splitter3.TabStop = False
        '
        'FrmConHatchCargo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(1012, 417)
        Me.Controls.Add(Me.Splitter3)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.GBV)
        Me.Menu = Me.MainMenu
        Me.Name = "FrmConHatchCargo"
        Me.Text = "集装箱舱单信息"
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBV.ResumeLayout(False)
        Me.GBV.PerformLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmConHatchCargo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Text = Me.Text & "_" & G_DeptName

        SortShip = " Order by Ship_Statu,Dept_Code " '默认的排序 

        FirmShip = "where DEPT_CODE LIKE '" & G_DeptCode & "%'" '船舶不变的条件设计
        SqlStrShip = "where (DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','0')) "
        Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '*****************调用航次信息
        Me.C1DBGV.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue

        Me.C1DBG.InsertHorizontalSplit(0)

        Me.mnuExport.Text = "校验(&E)"
        Me.tbbtnExport.Text = "校验"
        Me.tbbtnExport.ToolTipText = "舱单船图校验"

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
                SqlStrShip = "where (DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','0')) " '船舶可变的条件设计

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
                    SqlStrShip = "where (DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','0')) "
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
        Select Case C1DBGV.Columns("SHIP_STATU").CellText(e.Row)
            Case "0"
                e.CellStyle.BackColor = Color.Cyan
            Case "2"
                e.CellStyle.BackColor = Color.PaleGreen
            Case "3"
                e.CellStyle.BackColor = Color.LemonChiffon
            Case "4"
                e.CellStyle.BackColor = Color.Pink
            Case "5"
                e.CellStyle.BackColor = Color.Peru
            Case Else
        End Select
    End Sub

    Private Sub C1DBGV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBGV.DoubleClick
        On Error GoTo Err
        G_ShipName = Me.C1DBGV.Columns("CHI_VESSEL").Text
        G_Voyage = Me.C1DBGV.Columns("Voyage").Text
        Me.txtShipName.Text = Me.C1DBGV.Columns("CHI_VESSEL").Text
        Me.txtVoyage.Text = Me.C1DBGV.Columns("Voyage").Text

        Dim dsShip As New DataSet() '与前面的dsShip重名，不大好，
        Dim strsql As String
        Dim dw As New DataView()
        Ship_ID = CType(Me.C1DBGV.Columns.Item("ID").Text.ToString, Integer)
        strsql = "select * from View_SSHIP where SHIP_ID=" & Ship_ID
        dw = Getdata(strsql, dsShip)
        Label.Text = ""
        If dsShip.Tables(0).DefaultView.Count > 0 Then

            If Len(Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))) > 0 Then
                Label.Text = Label.Text & "中文船名:" & Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL"))) > 0 Then
                Label.Text = Label.Text & "英文船名:" & Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))) > 0 Then
                Label.Text = Label.Text & "航次:" & Trim(dsShip.Tables(0).Rows(0).Item("Voyage")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("InOutPort_Name"))) > 0 Then
                Label.Text = Label.Text & "进出口:" & Trim(dsShip.Tables(0).Rows(0).Item("InOutPort_Name")) & " "
            End If
            If dsShip.Tables(0).Rows(0).Item("InOutPort") = "0" Then
                InOutCode = "0"
            ElseIf dsShip.Tables(0).Rows(0).Item("InOutPort") = "1" Then
                InOutCode = "1"
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
            If Not IsDBNull(dw(0)("AGENT")) Then
                strAgent = Trim(dw(0)("AGENT"))
            Else
                strAgent = ""
            End If
        End If
        'FirmStr = " and Ship_ID=" & Ship_ID & " Order by BlNo " '设计初始条件  在检索后不改变的条件
        FirmStr = " and Ship_ID=" & Ship_ID & " Order by ID DESC " '设计初始条件  在检索后不改变的条件 
        'FirmStr = " and Ship_ID=" & Ship_ID & ""
        DynaStr = " 2>1 " '设计其它初始条件    在检索后不需要的条件 ***************要修改 或 其它条件
        'SelectStr = " Top 20 "
        SqlStr = DynaStr & FirmStr

        Me.ToolBar.Enabled = True
        Me.mnuAdd.Enabled = True
        Me.mnuDelete.Enabled = True
        Me.mnuEdit.Enabled = True
        Me.mnuExport.Enabled = True
        Me.mnuFind.Enabled = True
        Me.mnuPrint.Enabled = True
        Me.mnuQuery.Enabled = True

        Call preview("WL4_3") '*****************权限设计 '*************要修改模块号
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
            strsql = "select " & SelStr & " *  from View_HatchCargo  where " & Sql '******要修改

            Me.C1DBG.DataSource = Getdata(strsql, ds)  ' class dbcontrol getdata fuction
            ColNum = 12 '不显示的列数 '******要修改
            Table_Name = "View_HatchCargo" '操作的数据库表名 ''******要修改

            For i = 0 To ColNum - 1 '设计不显示的列
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Visible = False
            Next

            Call SetColumnCaption() '设计列标题
            Call SetColumnWidth() '设计列宽度
            If ds.Tables(0).Rows.Count > 0 Then
                Call SetColumnSum(Sql) '设计合计列
            End If

            For i = 0 To 19
                Me.C1DBG.Splits(1).DisplayColumns(i).Visible = False
            Next
            For i = 20 To Me.C1DBG.Columns.Count - 1
                Me.C1DBG.Splits(0).DisplayColumns(i).Visible = False
            Next
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
            SelectStr = ""
            Call myDataGrid(SelectStr, " (" & Sql_Find & ")  " & FirmStr)  '可能要修改
            SqlStr = " (" & Sql_Find & ")  " & FirmStr '可能要修改
        ElseIf Flag = 2 Then
            SelectStr = ""
            Call myDataGrid(SelectStr, DynaStr & FirmStr)  '可能要修改
            SqlStr = DynaStr & FirmStr '可能要修改
        End If
    End Sub

    Private Sub mnuQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuery.Click
        Try
            If ds.Tables(0).Rows.Count > 0 Then
                Dim FrmQuery As New FrmConHatchCargo_Query()      '***********要修改
                ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
                Bill_ID = Me.C1DBG.Columns.Item("blno").Text
                'Container_ID = Me.C1DBG.Columns.Item("container_no").Text
                'Mark_ID = Me.C1DBG.Columns.Item("mark").Text
                FrmQuery.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show("请先选船名航次")
        End Try
    End Sub

    Private Sub mnuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdd.Click
        Dim FrmAdd As New FrmConHatchCargo_Add        '***********要修改
        Try
            Do
                If ds.Tables(0).Rows.Count > 0 Then
                    ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
                    Bill_ID = Me.C1DBG.Columns.Item("blno").Text
                    'Container_ID = Me.C1DBG.Columns.Item("container_no").Text
                Else
                    ID = -1
                End If
                FrmAdd.ShowDialog()
                Call myDataGrid(SelectStr, SqlStr)
            Loop While FrmAdd.AddFlag = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        If ds.Tables(0).Rows.Count > 0 Then
            Dim FrmEdit As New FrmConHatchCargo_Edit()     '***********要修改
            Dim Row As Integer
            ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
            Bill_ID = Me.C1DBG.Columns.Item("blno").Text
            'Container_ID = Me.C1DBG.Columns.Item("container_no").Text
            'Mark_ID = Me.C1DBG.Columns.Item("mark").Text
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
            Dim FrmDelete As New FrmConHatchCargo_Delete()     '***********要修改

            ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
            Bill_ID = Me.C1DBG.Columns.Item("blno").Text
            'Container_ID = Me.C1DBG.Columns.Item("container_no").Text
            'Mark_ID = Me.C1DBG.Columns.Item("mark").Text
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
        'Call ExportExcel()
        Dim FrmVerify As New FrmConHatchCargo_Verify()
        FrmVerify.ShowDialog()
        Try
            Call myDataGrid(SelectStr, SqlStr)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
            Case "删除"
                Call mnuDelete_Click(sender, e)
            Case "打印"
                Call mnuPrint_Click(sender, e)
            Case "校验"
                Call mnuExport_Click(sender, e)
            Case "退出"
                Call mnuQuit_Click(sender, e)
            Case "全部清除"
                Call mnuClearAll_Click(sender, e)
            Case "全箱改"
                Call mnuModiAllCon_Click(sender, e)
            Case "总览"
                Call mnuSeeClass_Click(sender, e)
            Case "关系"
                Call mnuTransRelation_Click(sender, e)
            Case "查找"
                Call mnuLookUp_Click(sender, e)
            Case "核对"
                Call mnuCheck_Click(sender, e)
            Case "互租"
                Call mnuRent_Click(sender, e)
            Case "内外贸"
                Call mnuInOut_Click(sender, e)

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
            For j = 0 To Me.C1DBG.Columns.Count - 1
                Me.C1DBG.Splits(1).DisplayColumns.Item(j).AutoSize()
                Me.C1DBG.Splits(1).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                If Me.C1DBG.Splits(1).DisplayColumns.Item(j).Width < 65 Then
                    Me.C1DBG.Splits(1).DisplayColumns.Item(j).Width = 65
                Else
                    If Me.C1DBG.Splits(1).DisplayColumns.Item(j).Width > 130 Then
                        Me.C1DBG.Splits(1).DisplayColumns.Item(j).Width = 130
                    End If
                End If
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btResure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResure.Click
        SqlStrShip = "where (((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','0')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) and Voyage like '" & Trim(txtVoyage.Text) & "%' and (ENG_VESSEL Like '" & Trim(txtShipName.Text) & "%' OR CHI_VESSEL like '" & Trim(txtShipName.Text) & "%' )) "
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

    Private Sub mnuClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClearAll.Click
        If ds.Tables(0).Rows.Count > 0 Then
            If MessageBox.Show("此操作将清除当前船次所有的提单信息箱信息(作业完数据除外)，一旦执行，数据全部清除，不可恢复。请慎用此功能。", "严重警示", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                Dim sqlDeleteBill, sqlDeleteCon As String
                sqlDeleteCon = "delete from CON_HATCH_RECORD where ship_id='" & Ship_ID & "' and Unload_Mark='0' "
                sqlDeleteBill = "delete from CON_HATCH_LIST where ship_id='" & Ship_ID & "' and BLNO not in (select A.BLNO from Con_Hatch_Cargo A join Con_Hatch_Record B on A.Ship_ID=B.Ship_ID and A.Container_No=B.Container_No where B.Ship_ID=" & Ship_ID & " and Unload_Mark<>'0')"
                '关系表信息用提单表的触发器删除
                Try
                    ExecSql(sqlDeleteCon & " " & sqlDeleteBill)
                    Dim sqlDelRecord As String
                    sqlDelRecord = "insert into OperateHistory (Dept_Name,OperateTime,OperateWorker,OperateType,OperateDemo,OperateTable) values('" & G_DeptName & "','" & Now & "','" & G_User & "','全部清除','" & Ship_ID & " " & G_ShipName & " " & G_Voyage & "','CON_HATCH_LIST') "
                    ExecSql(sqlDelRecord)
                    Call myDataGrid(SelectStr, SqlStr)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub mnuModiAllCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuModiAllCon.Click
        If ds.Tables(0).Rows.Count > 0 Then
            Dim FrmModiAllCon As New FrmConHatchCargo_ModiAllCon()
            FrmModiAllCon.ShowDialog()
            Try
                Call myDataGrid(SelectStr, SqlStr)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub mnuSeeClass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSeeClass.Click
        If ds.Tables(0).Rows.Count > 0 Then
            Dim FrmSeeClass As New FrmConHatchCargo_SeeClass()
            FrmSeeClass.ShowDialog()
        End If
    End Sub

    Private Sub mnuTransRelation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTransRelation.Click
        Try
            If ds.Tables(0).Rows.Count > 0 Then
                Bill_ID = Me.C1DBG.Columns.Item("blno").Text
                Dim FrmTransRelation As New FrmConHatchCargo_TransRelation()
                FrmTransRelation.ShowDialog()
                Call myDataGrid(SelectStr, SqlStr)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub mnuLookUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuLookUp.Click
        Bill_ID = Me.C1DBG.Columns.Item("blno").Text
        Dim FrmLookUp As New FrmContainer_Select
        FrmLookUp.ShowDialog()
        If FrmLookUp.flag = True Then
            Call myDataGrid("", " (" & FrmLookUp.strSelect & ")  " & FirmStr)   '可能要修改
            SqlStr = " (" & FrmLookUp.strSelect & ")  " & FirmStr
            Call mnuQuery_Click(sender, e)
        Else
            Call myDataGrid(SelectStr, DynaStr & FirmStr)   '可能要修改
            SqlStr = DynaStr & FirmStr
        End If
    End Sub

    Private Sub mnuCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCheck.Click
        Dim FrmCheck As New FrmConHatchCargo_Check
        FrmCheck.strInOut = InOutCode
        FrmCheck.ShowDialog()
        Try
            Call myDataGrid(SelectStr, SqlStr)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuRent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRent.Click
        Dim sqlCheck As String
        Dim dvCheck As DataView
        sqlCheck = "select Count(*) from View_ConTallyDetail where Ship_ID=" & Ship_ID
        dvCheck = Filldata(sqlCheck)
        If dvCheck(0)(0) > 0 Then
            Dim fmRentDeal As New FrmConRent_BillNew
            fmRentDeal.strAgent = strAgent
            fmRentDeal.ShowDialog()
        Else
            MessageBox.Show("对不起，尚无理箱数据", "提示")
        End If
    End Sub

    Private Sub C1DBG_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles C1DBG.RowColChange
        If e.LastRow <> -1 AndAlso Me.C1DBG.Row <> e.LastRow Then
            '作业完不可删除
            If Me.C1DBG.Columns("Unload_Mark").Text = "1" Then
                Me.mnuDelete.Enabled = False
                Me.tbbtnDelete.Enabled = False
            Else
                Me.mnuDelete.Enabled = True
                Me.tbbtnDelete.Enabled = True
            End If
        End If
    End Sub

    Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        If Me.C1DBG.Columns("Unload_Mark").CellText(e.Row) = "1" Then
            e.CellStyle.BackColor = System.Drawing.Color.Wheat
        End If
    End Sub

    Private Sub mnuInOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInOut.Click
        Dim fm As New FrmConHatchCargo_InOut
        fm.ShowDialog()
        If fm.blSave Then
            myDataGrid(SelectStr, SqlStr)
        End If
    End Sub
End Class
