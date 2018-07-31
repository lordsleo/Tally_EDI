Imports TALLY.DBControl
Imports Microsoft.VisualBasic

Public Class FrmCon_Monitor
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
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
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
    Friend WithEvents GBV As System.Windows.Forms.GroupBox
    Friend WithEvents ToolBarV As System.Windows.Forms.ToolBar
    Friend WithEvents btResure As System.Windows.Forms.Button
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents C1IMAGE As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents TxtCONTAINERNO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtseachbay As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtrefr As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbWORK_NAME As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbgb As System.Windows.Forms.ComboBox
    Friend WithEvents btbox As System.Windows.Forms.Button
    Friend WithEvents chkjjr As System.Windows.Forms.CheckBox
    Friend WithEvents chkyb As System.Windows.Forms.CheckBox
    Friend WithEvents txtwork_no As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Txtseachcol As System.Windows.Forms.TextBox
    Friend WithEvents Txtseachrow As System.Windows.Forms.TextBox
    Friend WithEvents ybinfo As System.Windows.Forms.Label
    Friend WithEvents holinfo As System.Windows.Forms.Label
    Friend WithEvents btboxall As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents bterror As System.Windows.Forms.Button
    Friend WithEvents c1error As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents c1tally As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1err As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents chkcc As System.Windows.Forms.CheckBox
    Friend WithEvents chkcz As System.Windows.Forms.CheckBox
    Friend WithEvents btxdforacle As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btname As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btrefr As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents c1tallydx As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents ListBoxydinfo As System.Windows.Forms.ListBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents C1port As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents ListBoxbay As System.Windows.Forms.ListBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents C1nwm As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents mnuSMS As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCon_Monitor))
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.MainMenu = New System.Windows.Forms.MainMenu(Me.components)
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
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.mnuSMS = New System.Windows.Forms.MenuItem
        Me.GBV = New System.Windows.Forms.GroupBox
        Me.ToolBarV = New System.Windows.Forms.ToolBar
        Me.S1 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnOK = New System.Windows.Forms.ToolBarButton
        Me.S2 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSearch = New System.Windows.Forms.ToolBarButton
        Me.S3 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSort = New System.Windows.Forms.ToolBarButton
        Me.S4 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnEng = New System.Windows.Forms.ToolBarButton
        Me.btResure = New System.Windows.Forms.Button
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.C1DBGV = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.GB = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Txtseachrow = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Txtseachcol = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Txtseachbay = New System.Windows.Forms.TextBox
        Me.TxtCONTAINERNO = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btrefr = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.btxdforacle = New System.Windows.Forms.Button
        Me.C1err = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ListBoxbay = New System.Windows.Forms.ListBox
        Me.ListBoxydinfo = New System.Windows.Forms.ListBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.c1tally = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.c1tallydx = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.C1port = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.C1nwm = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.ybinfo = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.holinfo = New System.Windows.Forms.Label
        Me.btname = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.chkcz = New System.Windows.Forms.CheckBox
        Me.txtwork_no = New System.Windows.Forms.TextBox
        Me.chkjjr = New System.Windows.Forms.CheckBox
        Me.CmbWORK_NAME = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmbgb = New System.Windows.Forms.ComboBox
        Me.btbox = New System.Windows.Forms.Button
        Me.chkyb = New System.Windows.Forms.CheckBox
        Me.chkcc = New System.Windows.Forms.CheckBox
        Me.btboxall = New System.Windows.Forms.Button
        Me.txtrefr = New System.Windows.Forms.TextBox
        Me.C1IMAGE = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.bterror = New System.Windows.Forms.Button
        Me.c1error = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GBV.SuspendLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.C1err, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.c1tally, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.c1tallydx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.C1port, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.C1nwm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.C1IMAGE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1error, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuCompile, Me.mnuHelp, Me.mnuSMS})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFind, Me.mnuQuery, Me.mnuSep1, Me.mnuPrint, Me.mnuExport, Me.mnuSep2, Me.mnuQuit})
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
        'mnuSep1
        '
        Me.mnuSep1.Index = 2
        Me.mnuSep1.Text = "-"
        '
        'mnuPrint
        '
        Me.mnuPrint.Enabled = False
        Me.mnuPrint.Index = 3
        Me.mnuPrint.Text = "打印(&P)..."
        '
        'mnuExport
        '
        Me.mnuExport.Enabled = False
        Me.mnuExport.Index = 4
        Me.mnuExport.Text = "导出(&E)"
        '
        'mnuSep2
        '
        Me.mnuSep2.Index = 5
        Me.mnuSep2.Text = "-"
        '
        'mnuQuit
        '
        Me.mnuQuit.Index = 6
        Me.mnuQuit.Text = "退出(&X)"
        '
        'mnuCompile
        '
        Me.mnuCompile.Index = 1
        Me.mnuCompile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAdd, Me.mnuEdit, Me.mnuDelete})
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
        'mnuDelete
        '
        Me.mnuDelete.Enabled = False
        Me.mnuDelete.Index = 2
        Me.mnuDelete.Text = "删除(&D)"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem3, Me.MenuItem2, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6, Me.MenuItem7})
        Me.mnuHelp.Text = "帮助(&H)"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Text = "查询重复箱号"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "查询重复贝位"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 2
        Me.MenuItem2.Text = "图形化查询"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "操作记录"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 4
        Me.MenuItem5.Text = "指令"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 5
        Me.MenuItem6.Text = "配载"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 6
        Me.MenuItem7.Text = "撤消未作业箱"
        '
        'mnuSMS
        '
        Me.mnuSMS.Index = 3
        Me.mnuSMS.Text = "短信平台"
        '
        'GBV
        '
        Me.GBV.Controls.Add(Me.ToolBarV)
        Me.GBV.Controls.Add(Me.btResure)
        Me.GBV.Controls.Add(Me.txtVoyage)
        Me.GBV.Controls.Add(Me.Label8)
        Me.GBV.Controls.Add(Me.txtShipName)
        Me.GBV.Controls.Add(Me.Label1)
        Me.GBV.Controls.Add(Me.C1DBGV)
        Me.GBV.Dock = System.Windows.Forms.DockStyle.Left
        Me.GBV.Location = New System.Drawing.Point(0, 0)
        Me.GBV.Name = "GBV"
        Me.GBV.Size = New System.Drawing.Size(174, 672)
        Me.GBV.TabIndex = 6
        Me.GBV.TabStop = False
        '
        'ToolBarV
        '
        Me.ToolBarV.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.S1, Me.tbbtnOK, Me.S2, Me.tbbtnSearch, Me.S3, Me.tbbtnSort, Me.S4, Me.tbbtnEng})
        Me.ToolBarV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBarV.DropDownArrows = True
        Me.ToolBarV.ImageList = Me.ImageList
        Me.ToolBarV.Location = New System.Drawing.Point(3, 628)
        Me.ToolBarV.Name = "ToolBarV"
        Me.ToolBarV.ShowToolTips = True
        Me.ToolBarV.Size = New System.Drawing.Size(168, 41)
        Me.ToolBarV.TabIndex = 17
        '
        'S1
        '
        Me.S1.Name = "S1"
        Me.S1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
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
        'btResure
        '
        Me.btResure.Location = New System.Drawing.Point(128, 328)
        Me.btResure.Name = "btResure"
        Me.btResure.Size = New System.Drawing.Size(42, 22)
        Me.btResure.TabIndex = 16
        Me.btResure.Text = "查询"
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(38, 328)
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(88, 21)
        Me.txtVoyage.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 332)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 14)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "航次"
        '
        'txtShipName
        '
        Me.txtShipName.Location = New System.Drawing.Point(38, 302)
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.Size = New System.Drawing.Size(132, 21)
        Me.txtShipName.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 306)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "船名"
        '
        'C1DBGV
        '
        Me.C1DBGV.AllowUpdate = False
        Me.C1DBGV.Dock = System.Windows.Forms.DockStyle.Top
        Me.C1DBGV.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGV.Images.Add(CType(resources.GetObject("C1DBGV.Images"), System.Drawing.Image))
        Me.C1DBGV.Location = New System.Drawing.Point(3, 17)
        Me.C1DBGV.Name = "C1DBGV"
        Me.C1DBGV.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGV.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGV.PreviewInfo.ZoomFactor = 75
        Me.C1DBGV.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGV.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGV.Size = New System.Drawing.Size(168, 283)
        Me.C1DBGV.TabIndex = 0
        Me.C1DBGV.Text = "C1TrueDBGrid1"
        Me.C1DBGV.PropBag = resources.GetString("C1DBGV.PropBag")
        '
        'GB
        '
        Me.GB.Controls.Add(Me.GroupBox5)
        Me.GB.Controls.Add(Me.btrefr)
        Me.GB.Controls.Add(Me.GroupBox4)
        Me.GB.Controls.Add(Me.C1err)
        Me.GB.Controls.Add(Me.GroupBox3)
        Me.GB.Controls.Add(Me.GroupBox2)
        Me.GB.Controls.Add(Me.txtrefr)
        Me.GB.Controls.Add(Me.C1IMAGE)
        Me.GB.Controls.Add(Me.Label)
        Me.GB.Controls.Add(Me.Label6)
        Me.GB.Controls.Add(Me.Label9)
        Me.GB.Controls.Add(Me.Button1)
        Me.GB.Controls.Add(Me.Button2)
        Me.GB.Controls.Add(Me.bterror)
        Me.GB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB.Location = New System.Drawing.Point(174, 0)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(796, 672)
        Me.GB.TabIndex = 7
        Me.GB.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CheckBox1)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Txtseachrow)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Txtseachcol)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Txtseachbay)
        Me.GroupBox5.Controls.Add(Me.TxtCONTAINERNO)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 58)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(104, 152)
        Me.GroupBox5.TabIndex = 231
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "查询条件设置"
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(6, 88)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(94, 18)
        Me.CheckBox1.TabIndex = 224
        Me.CheckBox1.Text = "捣箱信息"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(6, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 22)
        Me.Label10.TabIndex = 216
        Me.Label10.Text = "贝："
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Visible = False
        '
        'Txtseachrow
        '
        Me.Txtseachrow.Location = New System.Drawing.Point(52, 64)
        Me.Txtseachrow.MaxLength = 2
        Me.Txtseachrow.Name = "Txtseachrow"
        Me.Txtseachrow.Size = New System.Drawing.Size(48, 21)
        Me.Txtseachrow.TabIndex = 217
        Me.Txtseachrow.Visible = False
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(6, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 22)
        Me.Label15.TabIndex = 216
        Me.Label15.Text = "层："
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label15.Visible = False
        '
        'Txtseachcol
        '
        Me.Txtseachcol.Location = New System.Drawing.Point(52, 40)
        Me.Txtseachcol.MaxLength = 2
        Me.Txtseachcol.Name = "Txtseachcol"
        Me.Txtseachcol.Size = New System.Drawing.Size(48, 21)
        Me.Txtseachcol.TabIndex = 217
        Me.Txtseachcol.Visible = False
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(6, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 22)
        Me.Label14.TabIndex = 216
        Me.Label14.Text = "列："
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label14.Visible = False
        '
        'Txtseachbay
        '
        Me.Txtseachbay.Location = New System.Drawing.Point(52, 16)
        Me.Txtseachbay.MaxLength = 2
        Me.Txtseachbay.Name = "Txtseachbay"
        Me.Txtseachbay.Size = New System.Drawing.Size(48, 21)
        Me.Txtseachbay.TabIndex = 217
        Me.Txtseachbay.Visible = False
        '
        'TxtCONTAINERNO
        '
        Me.TxtCONTAINERNO.Location = New System.Drawing.Point(4, 126)
        Me.TxtCONTAINERNO.MaxLength = 20
        Me.TxtCONTAINERNO.Name = "TxtCONTAINERNO"
        Me.TxtCONTAINERNO.Size = New System.Drawing.Size(96, 21)
        Me.TxtCONTAINERNO.TabIndex = 219
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(4, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 22)
        Me.Label4.TabIndex = 218
        Me.Label4.Text = "箱号："
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btrefr
        '
        Me.btrefr.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btrefr.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btrefr.Location = New System.Drawing.Point(68, 212)
        Me.btrefr.Name = "btrefr"
        Me.btrefr.Size = New System.Drawing.Size(42, 40)
        Me.btrefr.TabIndex = 230
        Me.btrefr.Text = "刷新"
        Me.btrefr.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Controls.Add(Me.btxdforacle)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 517)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(100, 100)
        Me.GroupBox4.TabIndex = 229
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "未执行指令"
        Me.GroupBox4.Visible = False
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(6, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 20)
        Me.Label16.TabIndex = 227
        Me.Label16.Text = "装船位置："
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 42)
        Me.TextBox1.MaxLength = 20
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(88, 21)
        Me.TextBox1.TabIndex = 226
        '
        'btxdforacle
        '
        Me.btxdforacle.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btxdforacle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btxdforacle.Image = CType(resources.GetObject("btxdforacle.Image"), System.Drawing.Image)
        Me.btxdforacle.Location = New System.Drawing.Point(8, 66)
        Me.btxdforacle.Name = "btxdforacle"
        Me.btxdforacle.Size = New System.Drawing.Size(76, 30)
        Me.btxdforacle.TabIndex = 16
        Me.btxdforacle.Text = "执行指令"
        '
        'C1err
        '
        Me.C1err.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1err.Images.Add(CType(resources.GetObject("C1err.Images"), System.Drawing.Image))
        Me.C1err.Location = New System.Drawing.Point(112, 332)
        Me.C1err.Name = "C1err"
        Me.C1err.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1err.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1err.PreviewInfo.ZoomFactor = 75
        Me.C1err.PrintInfo.PageSettings = CType(resources.GetObject("C1err.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1err.Size = New System.Drawing.Size(470, 144)
        Me.C1err.TabIndex = 228
        Me.C1err.Visible = False
        Me.C1err.PropBag = resources.GetString("C1err.PropBag")
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListBoxbay)
        Me.GroupBox3.Controls.Add(Me.ListBoxydinfo)
        Me.GroupBox3.Controls.Add(Me.TabControl1)
        Me.GroupBox3.Controls.Add(Me.ybinfo)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.holinfo)
        Me.GroupBox3.Controls.Add(Me.btname)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Location = New System.Drawing.Point(114, 478)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(676, 164)
        Me.GroupBox3.TabIndex = 227
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "理货统计"
        '
        'ListBoxbay
        '
        Me.ListBoxbay.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ListBoxbay.ItemHeight = 12
        Me.ListBoxbay.Location = New System.Drawing.Point(576, 20)
        Me.ListBoxbay.Name = "ListBoxbay"
        Me.ListBoxbay.Size = New System.Drawing.Size(74, 64)
        Me.ListBoxbay.TabIndex = 230
        Me.ListBoxbay.Visible = False
        '
        'ListBoxydinfo
        '
        Me.ListBoxydinfo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ListBoxydinfo.ItemHeight = 12
        Me.ListBoxydinfo.Location = New System.Drawing.Point(496, 20)
        Me.ListBoxydinfo.Name = "ListBoxydinfo"
        Me.ListBoxydinfo.Size = New System.Drawing.Size(74, 64)
        Me.ListBoxydinfo.TabIndex = 230
        Me.ListBoxydinfo.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(102, 10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(366, 148)
        Me.TabControl1.TabIndex = 229
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.c1tally)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(358, 122)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "普通"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'c1tally
        '
        Me.c1tally.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1tally.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1tally.Images.Add(CType(resources.GetObject("c1tally.Images"), System.Drawing.Image))
        Me.c1tally.Location = New System.Drawing.Point(0, 0)
        Me.c1tally.Name = "c1tally"
        Me.c1tally.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1tally.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1tally.PreviewInfo.ZoomFactor = 75
        Me.c1tally.PrintInfo.PageSettings = CType(resources.GetObject("c1tally.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1tally.Size = New System.Drawing.Size(358, 122)
        Me.c1tally.TabIndex = 228
        Me.c1tally.Text = "C1TrueDBGrid1"
        Me.c1tally.PropBag = resources.GetString("c1tally.PropBag")
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.c1tallydx)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(358, 122)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "捣箱"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'c1tallydx
        '
        Me.c1tallydx.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1tallydx.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1tallydx.Images.Add(CType(resources.GetObject("c1tallydx.Images"), System.Drawing.Image))
        Me.c1tallydx.Location = New System.Drawing.Point(0, 0)
        Me.c1tallydx.Name = "c1tallydx"
        Me.c1tallydx.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1tallydx.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1tallydx.PreviewInfo.ZoomFactor = 75
        Me.c1tallydx.PrintInfo.PageSettings = CType(resources.GetObject("c1tallydx.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1tallydx.Size = New System.Drawing.Size(358, 122)
        Me.c1tallydx.TabIndex = 229
        Me.c1tallydx.Text = "C1TrueDBGrid1"
        Me.c1tallydx.PropBag = resources.GetString("c1tallydx.PropBag")
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.C1port)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(358, 122)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "出口分港信息"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'C1port
        '
        Me.C1port.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1port.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1port.Images.Add(CType(resources.GetObject("C1port.Images"), System.Drawing.Image))
        Me.C1port.Location = New System.Drawing.Point(0, 0)
        Me.C1port.Name = "C1port"
        Me.C1port.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1port.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1port.PreviewInfo.ZoomFactor = 75
        Me.C1port.PrintInfo.PageSettings = CType(resources.GetObject("C1port.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1port.Size = New System.Drawing.Size(358, 122)
        Me.C1port.TabIndex = 229
        Me.C1port.Text = "C1TrueDBGrid1"
        Me.C1port.PropBag = resources.GetString("C1port.PropBag")
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.C1nwm)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(358, 122)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "内外贸"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'C1nwm
        '
        Me.C1nwm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1nwm.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1nwm.Images.Add(CType(resources.GetObject("C1nwm.Images"), System.Drawing.Image))
        Me.C1nwm.Location = New System.Drawing.Point(0, 0)
        Me.C1nwm.Name = "C1nwm"
        Me.C1nwm.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1nwm.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1nwm.PreviewInfo.ZoomFactor = 75
        Me.C1nwm.PrintInfo.PageSettings = CType(resources.GetObject("C1nwm.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1nwm.Size = New System.Drawing.Size(358, 122)
        Me.C1nwm.TabIndex = 229
        Me.C1nwm.Text = "C1TrueDBGrid1"
        Me.C1nwm.PropBag = resources.GetString("C1nwm.PropBag")
        '
        'ybinfo
        '
        Me.ybinfo.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ybinfo.Location = New System.Drawing.Point(130, 134)
        Me.ybinfo.Name = "ybinfo"
        Me.ybinfo.Size = New System.Drawing.Size(18, 24)
        Me.ybinfo.TabIndex = 226
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label11.Location = New System.Drawing.Point(52, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 20)
        Me.Label11.TabIndex = 224
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(52, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 222
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(4, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 20)
        Me.Label7.TabIndex = 221
        Me.Label7.Text = "舱单："
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(4, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 20)
        Me.Label12.TabIndex = 223
        Me.Label12.Text = "溢短："
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.PaleGreen
        Me.Label5.Location = New System.Drawing.Point(52, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 224
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 20)
        Me.Label3.TabIndex = 223
        Me.Label3.Text = "已理："
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'holinfo
        '
        Me.holinfo.Location = New System.Drawing.Point(150, 134)
        Me.holinfo.Name = "holinfo"
        Me.holinfo.Size = New System.Drawing.Size(18, 24)
        Me.holinfo.TabIndex = 226
        '
        'btname
        '
        Me.btname.Font = New System.Drawing.Font("Arial", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btname.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btname.Image = CType(resources.GetObject("btname.Image"), System.Drawing.Image)
        Me.btname.Location = New System.Drawing.Point(6, 130)
        Me.btname.Name = "btname"
        Me.btname.Size = New System.Drawing.Size(94, 30)
        Me.btname.TabIndex = 16
        Me.btname.Text = "分人员统计"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(4, 84)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 20)
        Me.Label17.TabIndex = 223
        Me.Label17.Text = "捣箱："
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(52, 84)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 20)
        Me.Label18.TabIndex = 224
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkcz)
        Me.GroupBox2.Controls.Add(Me.txtwork_no)
        Me.GroupBox2.Controls.Add(Me.chkjjr)
        Me.GroupBox2.Controls.Add(Me.CmbWORK_NAME)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cmbgb)
        Me.GroupBox2.Controls.Add(Me.btbox)
        Me.GroupBox2.Controls.Add(Me.chkyb)
        Me.GroupBox2.Controls.Add(Me.chkcc)
        Me.GroupBox2.Controls.Add(Me.btboxall)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 256)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(104, 178)
        Me.GroupBox2.TabIndex = 226
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "作业条件设置"
        '
        'chkcz
        '
        Me.chkcz.Location = New System.Drawing.Point(54, 56)
        Me.chkcz.Name = "chkcz"
        Me.chkcz.Size = New System.Drawing.Size(48, 18)
        Me.chkcz.TabIndex = 224
        Me.chkcz.Text = "重装"
        '
        'txtwork_no
        '
        Me.txtwork_no.Location = New System.Drawing.Point(4, 98)
        Me.txtwork_no.MaxLength = 6
        Me.txtwork_no.Name = "txtwork_no"
        Me.txtwork_no.Size = New System.Drawing.Size(92, 21)
        Me.txtwork_no.TabIndex = 225
        '
        'chkjjr
        '
        Me.chkjjr.Location = New System.Drawing.Point(6, 16)
        Me.chkjjr.Name = "chkjjr"
        Me.chkjjr.Size = New System.Drawing.Size(66, 18)
        Me.chkjjr.TabIndex = 224
        Me.chkjjr.Text = "节假日"
        '
        'CmbWORK_NAME
        '
        Me.CmbWORK_NAME.Location = New System.Drawing.Point(4, 122)
        Me.CmbWORK_NAME.Name = "CmbWORK_NAME"
        Me.CmbWORK_NAME.Size = New System.Drawing.Size(94, 20)
        Me.CmbWORK_NAME.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(60, 76)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 20)
        Me.Label13.TabIndex = 223
        Me.Label13.Text = "工班"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbgb
        '
        Me.cmbgb.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10"})
        Me.cmbgb.Location = New System.Drawing.Point(4, 76)
        Me.cmbgb.Name = "cmbgb"
        Me.cmbgb.Size = New System.Drawing.Size(54, 20)
        Me.cmbgb.TabIndex = 1
        '
        'btbox
        '
        Me.btbox.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbox.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btbox.Image = CType(resources.GetObject("btbox.Image"), System.Drawing.Image)
        Me.btbox.Location = New System.Drawing.Point(12, 144)
        Me.btbox.Name = "btbox"
        Me.btbox.Size = New System.Drawing.Size(76, 30)
        Me.btbox.TabIndex = 16
        Me.btbox.Text = "装 箱"
        '
        'chkyb
        '
        Me.chkyb.Location = New System.Drawing.Point(6, 36)
        Me.chkyb.Name = "chkyb"
        Me.chkyb.Size = New System.Drawing.Size(66, 18)
        Me.chkyb.TabIndex = 224
        Me.chkyb.Text = "夜班"
        '
        'chkcc
        '
        Me.chkcc.Location = New System.Drawing.Point(6, 56)
        Me.chkcc.Name = "chkcc"
        Me.chkcc.Size = New System.Drawing.Size(48, 18)
        Me.chkcc.TabIndex = 224
        Me.chkcc.Text = "出舱"
        '
        'btboxall
        '
        Me.btboxall.Location = New System.Drawing.Point(40, 146)
        Me.btboxall.Name = "btboxall"
        Me.btboxall.Size = New System.Drawing.Size(62, 22)
        Me.btboxall.TabIndex = 16
        Me.btboxall.Text = "全船"
        Me.btboxall.Visible = False
        '
        'txtrefr
        '
        Me.txtrefr.Location = New System.Drawing.Point(4, 232)
        Me.txtrefr.MaxLength = 4
        Me.txtrefr.Name = "txtrefr"
        Me.txtrefr.Size = New System.Drawing.Size(28, 21)
        Me.txtrefr.TabIndex = 225
        '
        'C1IMAGE
        '
        Me.C1IMAGE.FetchRowStyles = True
        Me.C1IMAGE.FilterBar = True
        Me.C1IMAGE.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1IMAGE.Images.Add(CType(resources.GetObject("C1IMAGE.Images"), System.Drawing.Image))
        Me.C1IMAGE.Location = New System.Drawing.Point(112, 58)
        Me.C1IMAGE.Name = "C1IMAGE"
        Me.C1IMAGE.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1IMAGE.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1IMAGE.PreviewInfo.ZoomFactor = 75
        Me.C1IMAGE.PrintInfo.PageSettings = CType(resources.GetObject("C1IMAGE.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1IMAGE.Size = New System.Drawing.Size(625, 414)
        Me.C1IMAGE.TabIndex = 153
        Me.C1IMAGE.Text = "C1TrueDBGrid1"
        Me.C1IMAGE.PropBag = resources.GetString("C1IMAGE.PropBag")
        '
        'Label
        '
        Me.Label.BackColor = System.Drawing.SystemColors.Control
        Me.Label.Location = New System.Drawing.Point(8, 14)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(528, 44)
        Me.Label.TabIndex = 11
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(2, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 20)
        Me.Label6.TabIndex = 223
        Me.Label6.Text = "刷新时间："
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(32, 234)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 20)
        Me.Label9.TabIndex = 223
        Me.Label9.Text = "分钟"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(16, 621)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 30)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "    退出"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(18, 476)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 30)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "贝位校验"
        '
        'bterror
        '
        Me.bterror.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bterror.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.bterror.Image = CType(resources.GetObject("bterror.Image"), System.Drawing.Image)
        Me.bterror.Location = New System.Drawing.Point(18, 440)
        Me.bterror.Name = "bterror"
        Me.bterror.Size = New System.Drawing.Size(76, 30)
        Me.bterror.TabIndex = 16
        Me.bterror.Text = "错误指令"
        '
        'c1error
        '
        Me.c1error.BackColor = System.Drawing.Color.Blue
        Me.c1error.BackgroundImage = CType(resources.GetObject("c1error.BackgroundImage"), System.Drawing.Image)
        Me.c1error.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.c1error.FetchRowStyles = True
        Me.c1error.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1error.Images.Add(CType(resources.GetObject("c1error.Images"), System.Drawing.Image))
        Me.c1error.Location = New System.Drawing.Point(14, 16)
        Me.c1error.Name = "c1error"
        Me.c1error.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1error.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1error.PreviewInfo.ZoomFactor = 75
        Me.c1error.PrintInfo.PageSettings = CType(resources.GetObject("c1error.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1error.Size = New System.Drawing.Size(23, 23)
        Me.c1error.TabIndex = 225
        Me.c1error.Visible = False
        Me.c1error.PropBag = resources.GetString("c1error.PropBag")
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'FrmCon_Monitor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(970, 672)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.GBV)
        Me.Menu = Me.MainMenu
        Me.Name = "FrmCon_Monitor"
        Me.Text = "集装箱理箱控制中心"
        Me.GBV.ResumeLayout(False)
        Me.GBV.PerformLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.C1err, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.c1tally, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.c1tallydx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.C1port, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.C1nwm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.C1IMAGE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1error, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim dsShip As New DataSet   '船舶数据集
    Dim SqlStrShip As String  '船舶条件语句
    Dim FirmShip As String
    Dim SortShip As String
    Dim inoutstr As String

    Dim t As Double
    Dim st As String
    Dim ber As String
    Dim dsTally_List As New DataSet '计数单
    Dim dsWait As New DataSet        '待时记录
    Dim dsWork_Record As New DataSet '现场记录
    Dim dsMeasure As New DataSet     '丈量单 
    Dim dsxdf As New DataSet

    Dim SqlStr As String  '条件语句
    Dim SelectStr As String
    Dim DynaStr As String '可变的条件设计
    Dim FirmStr As String '不变的条件设计
    Dim OrderStr As String
    ', FirmTally, FirmWait, FirmWorkRecord, FirmMeasure, FirmDaily
    Dim ColNum As Integer '不显示的列数
    Dim ds As New DataSet
    Dim dw As New DataView
    Dim dsload As New DataSet
    Dim dsunload As New DataSet
    Dim dwload As New DataView
    Dim dwunload As New DataView
    Dim dsoutload As New DataSet
    Dim dwoutload As New DataView
    Dim dsdx As New DataSet
    Dim dwdx As New DataView
    Dim dstally As New DataSet
    Dim dwtally As New DataView
    Dim dsouttally As New DataSet
    Dim dwouttally As New DataView
    Dim bayno As String
    Dim tjtype As Boolean
    Dim dsbay As New DataSet

    Private Sub FrmCon_Monitor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Text = Me.Text & "_" & G_DeptName
        tjtype = True
        SortShip = " Order by Ship_Statu, Dept_Code, id desc " '默认的排序 
        FirmShip = " where DEPT_CODE LIKE '" & G_DeptCode & "%'" '船舶不变的条件设计 
        'SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) "
        SqlStrShip = "where DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('0','1','2','3') "
        Call myDataGridShip(SqlStrShip & inoutstr & SortShip)
        Me.C1DBGV.SelectedStyle.BackColor = Color.CornflowerBlue
        txtShipName.Text = G_ShipName
        txtVoyage.Text = G_Voyage
        Call btResure_Click(sender, e)
    End Sub

    Private Sub myDataGridShip(ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        strsql = "select SHIP_ID as ID,SHIP_STATU,INOUTPORT,DEPT_CODE,ENG_VESSEL,CHI_VESSEL,VOYAGE,InOutPort_Name,Dept_Short from View_SSHip " '船舶条件语句 不改部分
        strsql = strsql & Sql
        Try
            Me.C1DBGV.DataSource = Getdata(strsql, dsShip)
            For i = 0 To 4
                Me.C1DBGV.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Call SetColumnCaptionShip()
            Call SetColumnWidthShip()
            If dsShip.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumShip(5)
            End If
            Me.C1DBGV.FetchRowStyles = True
            Me.C1DBGV.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaptionShip()
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnWidthShip()
        Dim i As Integer
        Try
            Me.C1DBGV.Splits(0).DisplayColumns.Item(4).Width = Me.C1DBGV.Width / 2 - 25
            Me.C1DBGV.Splits(0).DisplayColumns.Item(5).Width = Me.C1DBGV.Width / 2 - 25
            Me.C1DBGV.Splits(0).DisplayColumns.Item(6).Width = 35
            Me.C1DBGV.Splits(0).DisplayColumns.Item(7).Width = 24
            Me.C1DBGV.Splits(0).DisplayColumns.Item(8).Width = 18
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnSumShip(ByVal Col As Integer)
        Me.C1DBGV.ColumnFooters = True
        Me.C1DBGV.FooterStyle.BackColor = Color.CadetBlue
        Me.C1DBGV.Columns.Item(Col).FooterText = "共 " & dsShip.Tables(0).Rows.Count & " 条"
    End Sub

    Private Sub ToolBarV_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBarV.ButtonClick
        Select Case Me.ToolBarV.Buttons.IndexOf(e.Button)
            Case 1
                'SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) " '船舶可变的条件设计
                SqlStrShip = "where DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('0','1','2','3') " '船舶可变的条件设计
                If G_User_Serial = "WLGCH" Then
                    SqlStrShip = "where DEPT_CODE LIKE '" & G_DeptCode & "%' "
                End If
                SortShip = " Order by Ship_Statu,Dept_Code,id desc "
                Call myDataGridShip(SqlStrShip & inoutstr & SortShip)
            Case 3
                Dim FrmFind As New FrmFind
                Table_Name = "SSHIP"
                FrmFind.ShowDialog()

                If Flag = 0 Then
                    Call myDataGridShip(FirmShip & inoutstr & " and (" & Sql_Find & ")  " & SortShip)    '可能要修改
                    SqlStrShip = FirmStr & " and (" & Sql_Find & ")  "    '可能要修改
                ElseIf Flag = 2 Then
                    SqlStrShip = "where DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('2','3') "
                    '可能要修改
                    Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '可能要修改
                End If
            Case 5
                Dim FrmSort As New FrmSort
                FrmSort.ShowDialog()
                If Len(Trim(SortStr)) > 0 Then
                    SortShip = " Order by " & SortStr
                End If
                Call myDataGridShip(SqlStrShip & inoutstr & SortShip)
            Case 7
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

    Private Sub C1DBGV_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles C1DBGV.DoubleClick
        On Error GoTo Err
        Dim dsShip As New DataSet
        Dim strsql As String
        Dim dw As New DataView
        Dim strioport As String
        Ship_ID = CType(Me.C1DBGV.Columns.Item("ID").Text.ToString, Integer)
        strsql = "select * from View_SSHIP where SHIP_ID=" & Ship_ID
        dw = Getdata(strsql, dsShip)
        Label.Text = ""
        st = ""
        If dsShip.Tables(0).DefaultView.Count > 0 Then
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))) > 0 Then
                Label.Text = Label.Text & "中文船名:" & Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL")) & " "
                G_ShipName = Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))
                txtShipName.Text = Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))
                If G_ShipName = "中韩之星" Then
                    bterror.Text = "拖盘作业"
                Else
                    bterror.Text = "错误指令"
                End If
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL"))) > 0 Then
                Label.Text = Label.Text & "英文船名:" & Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))) > 0 Then
                Label.Text = Label.Text & "航次:" & Trim(dsShip.Tables(0).Rows(0).Item("Voyage")) & " "
                G_Voyage = Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))
                txtVoyage.Text = Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("InOutPort_Name"))) > 0 Then
                Label.Text = Label.Text & "进出口:" & Trim(dsShip.Tables(0).Rows(0).Item("InOutPort_Name")) & " "
                If dsShip.Tables(0).Rows(0).Item("INOUTPORT") = "0" Then
                    GL_IOPORT = 0
                    strioport = "I"
                    st = " and (code_unload_port like '%LYG' or UNLOAD_MARK=1) "
                    btbox.Text = "卸箱"
                    Label16.Text = "卸箱车号："
                    OrderStr = " order by bayno,bayrow desc,baycol "
                ElseIf dsShip.Tables(0).Rows(0).Item("InOutPort") = "1" Then
                    GL_IOPORT = 1
                    strioport = "E"
                    st = " and (code_load_port like '%LYG' or UNLOAD_MARK=1)  "
                    btbox.Text = "装箱"
                    Label16.Text = "装船位置："
                    OrderStr = " order by bayno,bayrow,baycol "
                End If
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Trade"))) > 0 Then
                Label.Text = Label.Text & "内外贸:" & Trim(dsShip.Tables(0).Rows(0).Item("Trade")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("SHIP_TYPE"))) > 0 Then
                Label.Text = Label.Text & "国外轮:" & Trim(dsShip.Tables(0).Rows(0).Item("SHIP_TYPE")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("SHIPAGENT_CHAE"))) > 0 Then
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
                ber = Trim(dsShip.Tables(0).Rows(0).Item("BerthNo"))
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("File_No"))) > 0 Then
                Label.Text = Label.Text & "档案号:" & Trim(dsShip.Tables(0).Rows(0).Item("File_No")) & " "
            End If
            If G_User_Serial = "WLGCH" Then
                Label.Text = Label.Text & "                                            Ship_ID:" & Ship_ID
            End If
            Me.txtrefr.Text = 5
        End If
        FirmStr = "  Ship_ID=" & Ship_ID & " Order by ID " '设计初始条件  在检索后不改变的条件  '***************要修改 或 2>1
        DynaStr = " 2>1 " '设计其它初始条件    在检索后不需要的条件 ***************要修改 或 其它条件
        SelectStr = " " ' " Top 20 "
        SqlStr = " (" & DynaStr & ")  " & " and " & FirmStr
        'Call preview("WL4_1") '*****************权限设计
        If CheckBox1.Checked = True Then
            'chkdx.Checked = True
            st = " and moved='y' "
        Else
            'chkdx.Checked = False
            If GL_IOPORT = 0 Then
                st = " and (code_unload_port like '%LYG' or UNLOAD_MARK=1) "
            ElseIf GL_IOPORT = 1 Then
                st = " and (code_load_port like '%LYG' or UNLOAD_MARK=1)  "
            End If
        End If

        'GETIMAGE()
        CheckBox1_CheckedChanged(sender, e)
        Me.Timer1.Start()
        Me.Timer1.Interval = 5 * 60.0 * 1000
        'Me.RBBAY.Checked = True
        Call FillWORK_NAME()
        CmbWORK_NAME.SelectedValue = G_WorkNo
        '分港贝位汇总
        tjbay()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub FillWORK_NAME()
        Dim sqldc As String
        Dim dvc As New DataView
        Dim dsc As New DataSet

        If G_DeptCode = "26.11.12" Then
            sqldc = "SELECT NAME, WORK_NO FROM TALLY_CLERK WHERE DEPT_CODE ='" & G_DeptCode & "' or DEPT_CODE='29.11.12' order by NAME  "
        Else
            sqldc = "SELECT NAME, WORK_NO FROM TALLY_CLERK WHERE DEPT_CODE ='" & G_DeptCode & "' or DEPT_CODE='29.11.11' order by NAME "
        End If

        'sqldc = "SELECT NAME, WORK_NO FROM TALLY_CLERK WHERE DEPT_CODE='" & G_DeptCode & "' order by NAME "

        Me.CmbWORK_NAME.DataSource = DBControl.Getdata(sqldc, dsc)
        Me.CmbWORK_NAME.DisplayMember = "NAME"
        Me.CmbWORK_NAME.ValueMember = "WORK_NO"
    End Sub

    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
        Me.Close()
    End Sub

    Private Sub preview(ByVal Func As String) '***************权限设计
        Dim sqlstr As String
        Dim Previewdv As DataView
        Dim Previewds As New DataSet
        Dim i As Integer
        sqlstr = " select FUNC_CODE_Add,FUNC_CODE_Change,FUNC_CODE_Del from View_UserPreview where PART_ID=" & G_Part_Id & " and FUNC_CODE='" & Upper(Func) & "' "
        Previewdv = Getdata(sqlstr, Previewds)
        'If Previewdv.Count > 0 Then
        '    If Previewdv(i)("FUNC_CODE_Add") = 1 Then 'ADD 按钮可见
        '        ToolBar.Buttons.Item(4).Enabled = True
        '        mnuAdd.Enabled = True
        '    Else                                      'ADD 按钮不可见
        '        Me.ToolBar.Buttons.Item(4).Enabled = False
        '        mnuAdd.Enabled = False
        '    End If
        '    If Previewdv(i)("FUNC_CODE_Change") = 1 Then '修改 按钮可见
        '        Me.ToolBar.Buttons.Item(5).Enabled = True
        '        mnuEdit.Enabled = True
        '    Else                                          '修改 按钮不可见
        '        Me.ToolBar.Buttons.Item(5).Enabled = False
        '        mnuEdit.Enabled = False
        '    End If
        '    If Previewdv(i)("FUNC_CODE_Del") = 1 Then '删除 按钮可见
        '        Me.ToolBar.Buttons.Item(6).Enabled = True
        '        mnuDelete.Enabled = True
        '    Else                                     '删除按钮不可见
        '        Me.ToolBar.Buttons.Item(6).Enabled = False
        '        mnuDelete.Enabled = False
        '    End If
        'End If
    End Sub

    Private Sub GETIMAGE()
        Try
            'dw = Getdata("select * from VIEW_Monitor_new where ship_id='" & Ship_ID & "' " & st & OrderStr, ds)
            dw = Getdata("select * from VIEW_Monitor_Inoutmark where ship_id='" & Ship_ID & "' " & st & OrderStr, ds)
            C1IMAGE.DataSource = dw
            SetC1IMAGE_Fromat()
            count()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetC1IMAGE_Fromat()
        Dim i As Integer

        For i = 7 To C1IMAGE.Columns.Count - 1
            Me.C1IMAGE.Columns(i).FilterDropdown = True
        Next
        Me.C1IMAGE.Columns("CONTAINER_NO").FilterDropdown = False
        Me.C1IMAGE.Columns("work_date").FilterDropdown = False

        C1IMAGE.Splits(0).DisplayColumns.Item("CON_IMAGE_ID").Visible = False
        C1IMAGE.Splits(0).DisplayColumns.Item("SHIP_ID").Visible = False
        C1IMAGE.Splits(0).DisplayColumns.Item("WORK_NO").Visible = False
        C1IMAGE.Splits(0).DisplayColumns.Item("CODE_LOAD_PORT").Visible = False
        C1IMAGE.Splits(0).DisplayColumns.Item("CODE_UNLOAD_PORT").Visible = False
        C1IMAGE.Splits(0).DisplayColumns.Item("unload_mark").Visible = False
        C1IMAGE.Splits(0).DisplayColumns.Item("pos").Visible = False
        C1IMAGE.Splits(0).DisplayColumns.Item("SEALNO").Visible = False
        If G_ShipName = "中韩之星" Then
            C1IMAGE.Splits(0).DisplayColumns.Item("tray").Visible = True
            C1IMAGE.Columns.Item("tray").Caption = "拖车"
            C1IMAGE.Splits(0).DisplayColumns.Item("tray").Width = 40
        Else
            C1IMAGE.Splits(0).DisplayColumns.Item("tray").Visible = False
        End If

        C1IMAGE.Columns.Item("BAYNO").Caption = "贝"
        C1IMAGE.Columns.Item("baycol").Caption = "列"
        C1IMAGE.Columns.Item("bayrow").Caption = "层"
        C1IMAGE.Columns.Item("CONTAINER_NO").Caption = "箱号"
        C1IMAGE.Columns.Item("SIZE_CON").Caption = "尺寸"
        C1IMAGE.Columns.Item("CONTAINER_TYPE").Caption = "箱型"
        C1IMAGE.Columns.Item("FULLOREMPTY").Caption = "空/重"
        C1IMAGE.Columns.Item("WEIGHT").Caption = "重量"
        C1IMAGE.Columns.Item("MOVED").Caption = "捣箱标志"
        C1IMAGE.Columns.Item("NAME").Caption = "理货员"
        C1IMAGE.Columns.Item("work_date").Caption = "作业时间"
        C1IMAGE.Columns.Item("USER_update").Caption = "编辑人员"
        C1IMAGE.Columns.Item("yb").Caption = "夜班"
        C1IMAGE.Columns.Item("jjr").Caption = "节假日"
        C1IMAGE.Columns.Item("inoutmark").Caption = "内外贸（0外/1内)"

        C1IMAGE.Columns.Item("work_date").NumberFormat = "MM-dd HH:mm"

        C1IMAGE.Splits(0).DisplayColumns.Item("BAYNO").Width = 30
        C1IMAGE.Splits(0).DisplayColumns.Item("baycol").Width = 30
        C1IMAGE.Splits(0).DisplayColumns.Item("bayrow").Width = 30
        C1IMAGE.Splits(0).DisplayColumns.Item("CONTAINER_NO").Width = 85
        C1IMAGE.Splits(0).DisplayColumns.Item("SIZE_CON").Width = 35
        C1IMAGE.Splits(0).DisplayColumns.Item("CONTAINER_TYPE").Width = 35
        C1IMAGE.Splits(0).DisplayColumns.Item("FULLOREMPTY").Width = 40
        C1IMAGE.Splits(0).DisplayColumns.Item("WEIGHT").Width = 55
        C1IMAGE.Splits(0).DisplayColumns.Item("MOVED").Width = 60
        C1IMAGE.Splits(0).DisplayColumns.Item("NAME").Width = 50
        C1IMAGE.Splits(0).DisplayColumns.Item("work_date").Width = 75
        C1IMAGE.Splits(0).DisplayColumns.Item("USER_update").Width = 60
        C1IMAGE.Splits(0).DisplayColumns.Item("yb").Width = 40
        C1IMAGE.Splits(0).DisplayColumns.Item("jjr").Width = 40
        C1IMAGE.Splits(0).DisplayColumns.Item("inoutmark").Width = 110

        'Dim j As Integer
        'For j = 0 To Me.C1IMAGE.Columns.Count - 1
        '    Me.C1IMAGE.Splits(0).DisplayColumns.Item(j).AutoSize()
        '    Me.C1IMAGE.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

        '    If Me.C1IMAGE.Splits(0).DisplayColumns.Item(j).Width < 30 Then
        '        Me.C1IMAGE.Splits(0).DisplayColumns.Item(j).Width = 30
        '    Else
        '        If Me.C1IMAGE.Splits(0).DisplayColumns.Item(j).Width > 120 Then
        '            Me.C1IMAGE.Splits(0).DisplayColumns.Item(j).Width = 120
        '        End If
        '    End If
        'Next

        Me.C1IMAGE.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        Me.C1IMAGE.ColumnFooters = True
        Me.C1IMAGE.FooterStyle.BackColor = System.Drawing.Color.PaleTurquoise
        Me.C1IMAGE.Columns("CONTAINER_NO").FooterText = "合计 " & C1IMAGE.RowCount & " 条"
        'If RBCOL.Checked = True Then
        '    dw.Sort = "baycol,bayrow"
        'ElseIf RBROW.Checked = True Then
        '    dw.Sort = "bayrow,baycol"
        'End If
        orderbypos()
        C1IMAGE.Refresh()
    End Sub

    Private Sub C1IMAGE_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1IMAGE.FetchRowStyle

        'If GL_IOPORT = 0 Then
        '    If Me.C1IMAGE.Columns("UNLOAD_MARK").CellValue(e.Row) = 0 Then
        '    e.CellStyle.BackColor = System.Drawing.Color.White CODE_LOAD_PORT
        '    ElseIf Me.C1IMAGE.Columns("UNLOAD_MARK").CellValue(e.Row) = 1 And Me.C1IMAGE.Columns("UNLOAD_MARK").CellValue(e.Row) = 1 Then
        '        e.CellStyle.BackColor = System.Drawing.Color.PaleGreen
        '    End If
        'ElseIf GL_IOPORT = 1 Then
        '    st = " and code_load_port like '%LYG' "
        'End If

        If Me.C1IMAGE.Columns("UNLOAD_MARK").CellValue(e.Row) = 0 Then
            e.CellStyle.BackColor = Color.White
        ElseIf Me.C1IMAGE.Columns("UNLOAD_MARK").CellValue(e.Row) = 1 Then
            e.CellStyle.BackColor = Color.PaleGreen
            If Me.C1IMAGE.Columns("moved").CellValue(e.Row) = "1" Then
                e.CellStyle.BackColor = Color.Red
            End If
            If GL_IOPORT = 0 Then
                If Me.C1IMAGE.Columns("code_unload_port").CellValue(e.Row) <> "CNLYG" And Me.C1IMAGE.Columns("moved").CellValue(e.Row) <> "1" Then
                    e.CellStyle.BackColor = Color.RoyalBlue
                End If
            ElseIf GL_IOPORT = 1 Then
                'If Me.C1IMAGE.Columns("code_load_port").CellValue(e.Row) <> "LYG" Or Me.C1IMAGE.Columns("code_load_port").CellValue(e.Row) <> "CNLYG" Then
                If Me.C1IMAGE.Columns("code_load_port").CellValue(e.Row) <> "CNLYG" And Me.C1IMAGE.Columns("moved").CellValue(e.Row) <> "1" Then
                    e.CellStyle.BackColor = Color.RoyalBlue
                End If
            End If
        End If
    End Sub

    Private Sub TxtCONTAINERNO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCONTAINERNO.TextChanged
        Dim dsquery As New DataSet
        Try
            If Len(Trim(TxtCONTAINERNO.Text)) > 0 Then
                dw = Getdata("select * from VIEW_Monitor_Inoutmark where ship_id='" & Ship_ID & "' " & st & " and CONTAINER_NO like '%" & Trim(TxtCONTAINERNO.Text) & "%' and bayno like '" & Txtseachbay.Text & "%' " & OrderStr, ds)
                C1IMAGE.DataSource = dw
                SetC1IMAGE_Fromat()
            ElseIf Len(Trim(Txtseachbay.Text)) > 0 Then
                Call Txtseachbay_TextChanged(sender, e)
            Else
                Call GETIMAGE()
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Frm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.C1DBGV.Height = Me.Height - 140
        Me.C1IMAGE.Height = Me.Height - 130 - Me.GroupBox3.Height
        Me.C1IMAGE.Width = Me.GB.Width - 130
        Me.Label.Width = Me.GB.Width - 20
        Me.Label1.Top = Me.C1DBGV.Height + 20
        Me.txtShipName.Top = Me.C1DBGV.Height + 20
        Me.Label8.Top = Me.C1DBGV.Height + 40
        Me.txtVoyage.Top = Me.C1DBGV.Height + 40
        Me.btResure.Top = Me.C1DBGV.Height + 40
        Me.GroupBox3.Top = Me.C1IMAGE.Top + Me.C1IMAGE.Height + 10
        Me.GroupBox3.Width = Me.C1IMAGE.Width
        Me.GroupBox3.Height = 200
        Me.Button1.Top = Me.GroupBox3.Top + Me.GroupBox3.Height - Me.Button1.Height
        Me.bterror.Top = Me.GroupBox2.Top + Me.GroupBox2.Height + 10
        Me.GroupBox4.Top = Me.bterror.Top + Me.bterror.Height + 20
        Me.TabControl1.Width = Me.GroupBox3.Width - 330 - 170
        Me.TabControl1.Height = Me.GroupBox3.Height - 15

        Me.ListBoxydinfo.Top = Me.Label2.Location.Y
        Me.ListBoxydinfo.Left = Me.TabControl1.Width + 120
        Me.ListBoxydinfo.Width = 150
        Me.ListBoxydinfo.Height = Me.TabControl1.Height - 10

        Me.ListBoxbay.Top = Me.Label2.Location.Y
        Me.ListBoxbay.Left = Me.TabControl1.Width + 130 + ListBoxydinfo.Width
        Me.ListBoxbay.Width = 150
        Me.ListBoxbay.Height = Me.TabControl1.Height - 10

        'Me.c1tally.Width = Me.GroupBox3.Width - 250
        'Me.c1tally.Height = Me.GroupBox3.Height - 15
        C1err.Width = C1IMAGE.Width - 50
        C1err.Top = GroupBox3.Top - C1err.Height - 15
        'Me.ybinfo.Top = Me.GroupBox3.Top
        'Me.ybinfo.Dock = DockStyle.Right
        'Me.holinfo.Dock = DockStyle.Right
    End Sub

    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        TBar = 1
        Mnu = 1
    End Sub

    Private Sub btResure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResure.Click
        'SqlStrShip = "where (((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','4')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) and Voyage like '" & Trim(txtVoyage.Text) & "%' and (ENG_VESSEL Like '" & Trim(txtShipName.Text) & "%' OR CHI_VESSEL like '" & Trim(txtShipName.Text) & "%' )) "
        SqlStrShip = "where (((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('0','1','2','3'))) and Voyage like '" & Trim(txtVoyage.Text) & "%' and (ENG_VESSEL Like '" & Trim(txtShipName.Text) & "%' OR CHI_VESSEL like '" & Trim(txtShipName.Text) & "%' )) "
        '可能要修改
        G_ShipName = Trim(txtShipName.Text)
        G_Voyage = Trim(txtVoyage.Text)
        Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '可能要修改
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If (txtrefr.Text.Trim.Length > 0) Then
                Me.Timer1.Start()
                t = System.Convert.ToDouble(txtrefr.Text)
                Me.Timer1.Interval = t * 60.0 * 1000
            Else
                Me.Timer1.Stop()
                t = 0
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtrefr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrefr.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                Txtseachbay.Focus()
                If (txtrefr.Text.Trim.Length > 0) Then
                    t = System.Convert.ToDouble(txtrefr.Text)
                    If (t > 0) Then
                        Me.Timer1.Start()
                        Me.Timer1.Interval = t * 60.0 * 1000
                    End If
                Else
                    Me.Timer1.Stop()
                    t = 0
                End If
            End If
        Catch ex As System.Exception
            'MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Wait()
        'If TimeOfDay >= #11:59:55 PM# Then
        '    MsgBox("The current time is within 5 seconds of midnight" & _
        '       vbCrLf & "The timer returns to 0.0 at midnight")
        '    Return
        'End If
        Dim Start, Finish, TotalTime As Double
        'If (MsgBox("Press Yes to pause for 5 seconds", MsgBoxStyle.YesNo)) = _
        '   MsgBoxResult.Yes Then
        Start = Microsoft.VisualBasic.DateAndTime.Timer
        Finish = Start + t * 60.0 ' Set end time for 5-second duration.
        Do While Microsoft.VisualBasic.DateAndTime.Timer < Finish
            ' Do other processing while waiting for 5 seconds to elapse.
        Loop
        TotalTime = Microsoft.VisualBasic.DateAndTime.Timer - Start
        'MsgBox("Paused for " & TotalTime & " seconds")
        'End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            Dim tt As String
            tt = C1IMAGE.Row
            If (Txtseachbay.Text.Length > 0 Or Txtseachcol.Text.Length > 0 Or Txtseachrow.Text.Length > 0) Then
                Txtseachbay_TextChanged(sender, e)
            End If
            If TxtCONTAINERNO.Text.Length > 0 Then
                TxtCONTAINERNO_TextChanged(sender, e)
            End If
            CheckBox1_CheckedChanged(sender, e)
            C1IMAGE.Select()
            C1IMAGE.MoveFirst()
            'If tt > 11 Then
            '    C1IMAGE.Row = tt - 11
            'Else
            C1IMAGE.Row = tt
            'End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RBBAY_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        orderbypos()
    End Sub

    Private Sub RBCOL_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        orderbypos()
    End Sub

    Private Sub RBROW_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        orderbypos()
    End Sub

    Private Sub orderbypos()
        'If RBBAY.Checked = True Then
        '    dw.Sort = "bayno,baycol,bayrow"
        'End If
        'If RBCOL.Checked = True Then
        '    dw.Sort = "baycol,bayno,bayrow"
        'End If
        'If RBROW.Checked = True Then
        '    dw.Sort = "bayrow,bayno,baycol"
        'End If
    End Sub

    Private Sub count()
        ''未理------------舱单中未作业箱数  
        'dwunload = Getdata("select * from con_hatch_record where ship_id='" & Ship_ID & "' and unload_mark='0'", dsunload)
        'Label2.Text = dsunload.Tables(0).Rows.Count
        ''已理------------船图中已经作业箱数
        'dwload = Getdata("select * from con_image where ship_id='" & Ship_ID & "' and unload_mark='1'", dsload)
        'Label5.Text = dsload.Tables(0).Rows.Count
        ''溢卸------------船图中已经作业箱－舱单中已经作业箱  Label12
        'dwoutload = Getdata("select * from con_hatch_record where ship_id='" & Ship_ID & "' and unload_mark='1'", dsoutload)

        '舱单------------舱单中放行箱数  
        dwunload = Getdata("select * from con_hatch_record where ship_id='" & Ship_ID & "' ", dsunload)
        Label2.Text = dsunload.Tables(0).Rows.Count
        '已理------------船图中已经作业箱数
        dwload = Getdata("select * from con_image where ship_id='" & Ship_ID & "' and unload_mark='1' and  moved='0' ", dsload)
        Label5.Text = dsload.Tables(0).Rows.Count
        '溢卸------------船图中已经作业箱－舱单中已经作业箱  Label12
        dwoutload = Getdata("select * from con_hatch_record where ship_id='" & Ship_ID & "' and unload_mark='1' ", dsoutload)
        '捣箱------------船图   Label18
        dwdx = Getdata("select * from con_image where ship_id='" & Ship_ID & "' and moved='1' and unload_mark='1' ", dsdx)
        Label18.Text = dsdx.Tables(0).Rows.Count

        ListBoxydinfo.Visible = False
        ListBoxydinfo.Items.Clear()
        ListBoxydinfo.Items.Add("溢短箱号信息：")
        If dsoutload.Tables(0).Rows.Count <> dsload.Tables(0).Rows.Count Then
            If GL_IOPORT = 0 Then
                ListBoxydinfo.Visible = True
                Dim t As Integer
                Dim dsydinfo As New DataSet
                If dsoutload.Tables(0).Rows.Count > dsload.Tables(0).Rows.Count Then
                    Label12.Text = "短卸："
                    Label11.Text = dsoutload.Tables(0).Rows.Count - dsload.Tables(0).Rows.Count
                    Getdata("select container_no from con_hatch_record where ship_id='" & Ship_ID & "' and unload_mark='1' and container_no not in ( select container_no from con_image where ship_id='" & Ship_ID & "' and unload_mark='1' and  moved='0')", dsydinfo)
                    For t = 0 To dsydinfo.Tables(0).Rows.Count - 1
                        ListBoxydinfo.Items.Add(dsydinfo.Tables(0).Rows(t)(0))
                    Next
                Else
                    Label12.Text = "溢卸："
                    Label11.Text = dsload.Tables(0).Rows.Count - dsoutload.Tables(0).Rows.Count
                    Getdata("select container_no from con_image where ship_id='" & Ship_ID & "' and unload_mark='1' and  moved='0' and container_no not in (select container_no from con_hatch_record where ship_id='" & Ship_ID & "' and unload_mark='1' )", dsydinfo)
                    For t = 0 To dsydinfo.Tables(0).Rows.Count - 1
                        ListBoxydinfo.Items.Add(dsydinfo.Tables(0).Rows(t)(0))
                    Next
                End If
            Else
                'If dsoutload.Tables(0).Rows.Count > dsload.Tables(0).Rows.Count Then
                '    Label12.Text = "短装："
                '    Label11.Text = dsoutload.Tables(0).Rows.Count - dsload.Tables(0).Rows.Count
                'Else
                '    'Label12.Text = "溢装："
                '    'Label11.Text = dsload.Tables(0).Rows.Count - dsoutload.Tables(0).Rows.Count
                '    Label12.Text = "溢短："
                '    Label11.Text = "0"
                'End If
                Label12.Text = "溢短："
                Label11.Text = "0"
            End If
        Else
            Label12.Text = "溢短："
            Label11.Text = "0"
        End If
        '2010-12-20 14:00:36
        '张远康提出现场监控速度慢，暂停自动贝位校验，改为手动触发
        'checkbay()
        tj()

        'ybinfo.Text = ""
        'ybinfo.Text = dstally.Tables(0).Rows(dstally.Tables(0).Rows.Count)(3)
        'holinfo.Text = dstally.Tables(0).Rows(dstally.Tables(0).Rows.Count)(4)

        'dwoutload = Getdata("select * from CON_TALLY_LIST where ship_id='" & Ship_ID & "' and NIGHT_MARK=1 and con_total<>0 ", dsoutload)
        'If dsoutload.Tables(0).Rows.Count > 0 Then
        '    ybinfo.Text = ybinfo.Text + " 夜班： " + System.Convert.ToString(dsoutload.Tables(0).Rows.Count) + "      "
        'End If

        'dwoutload = Getdata("select * from CON_TALLY_LIST where ship_id='" & Ship_ID & "' and HOLIDAY=1 and con_total<>0 ", dsoutload)
        'If dsoutload.Tables(0).Rows.Count > 0 Then
        '    ybinfo.Text = ybinfo.Text + " 节假日： " + System.Convert.ToString(dsoutload.Tables(0).Rows.Count)
        'End If
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub checkbay()
        ListBoxbay.Visible = False
        ListBoxbay.Items.Clear()

        Dim t As Integer
        Dim checksql As String
        Dim dsshipinfo As New DataSet
        Dim dsbayinfo As New DataSet
        Getdata("select v_id from sship where ship_id='" & Ship_ID & "'", dsshipinfo)

        checksql = "select container_no from CON_TALLY_DETAIL where con_tally_list_id in ( select con_tally_list_id from con_tally_list where ship_id='" & Ship_ID & "') and (bayno not in (select bay_num+bay_col+bay_row from con_map where v_id='" & dsshipinfo.Tables(0).Rows(0)(0) & "' and user_char=1) and bayno not in (select right(replicate('0',10)+convert(varchar,cast(cast(bay_num as int)+1 as varchar)+bay_col+bay_row),6) from con_map where v_id='" & dsshipinfo.Tables(0).Rows(0)(0) & "' and user_char=1))"
        Getdata(checksql, dsbayinfo)
        If dsbayinfo.Tables(0).Rows.Count > 0 Then
            ListBoxbay.Items.Add("贝位规范校验：")
            For t = 0 To dsbayinfo.Tables(0).Rows.Count - 1
                ListBoxbay.Items.Add(dsbayinfo.Tables(0).Rows(t)(0))
            Next
            ListBoxbay.Visible = True
        End If

    End Sub

    Private Sub btbox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbox.Click
        Try
            Dim t As String
            Dim ttt As String
            Dim jjr As String
            Dim yb As String
            Dim cc As String
            Dim cz As String

            If cmbgb.Text.Length = 0 Then
                MsgBox("请输入工班号！")
                Return
            End If
            If GL_IOPORT = 1 Then
                If C1IMAGE.Columns("pos").CellText(C1IMAGE.Row) = "" Then
                    MsgBox("请输入贝位号！")
                    Return
                End If
            End If
            If chkjjr.Checked = True Then
                jjr = "1"
            Else
                jjr = "0"
            End If
            If chkyb.Checked = True Then
                yb = "1"
            Else
                yb = "0"
            End If
            If chkcc.Checked = True Then
                cc = "1"
            Else
                cc = "0"
            End If
            If chkcz.Checked = True Then
                cz = "1"
            Else
                cz = "0"
            End If

            t = C1IMAGE.Row

            If Me.C1IMAGE.Item(C1IMAGE.Row, "UNLOAD_MARK") <> 0 Then
                ' MsgBox("本箱已作业！") 
                If MsgBox("本箱已作业,确认要修改吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                    ExecSql("update CON_TALLY_LIST set inout_mark='" & cc & "', reload='" & cz & "',NIGHT_MARK='" & yb & "' ,HOLIDAY='" & jjr & "' ,Tally_Clerk2='" & CmbWORK_NAME.SelectedValue & "',USER_NAME='" & G_WorkNo & "' where CON_TALLY_LIST_ID in (select CON_TALLY_LIST_ID from CON_TALLY_LIST  where ship_id='" & Ship_ID & "' and con_tally_list_id in (select con_tally_list_id from CON_TALLY_detail where container_no='" & C1IMAGE.Columns("CONTAINER_NO").CellText(t) & "'))")
                    ExecSql("update con_image set work_no='" & CmbWORK_NAME.SelectedValue & "',USER_update='" & G_User & "' where con_image_id='" & C1IMAGE.Columns(0).CellText(t) & "'")
                    ExecSql("update con_hatch_record set unload_mark='1' where ship_id='" & Ship_ID & "' and container_no='" & C1IMAGE.Columns("CONTAINER_NO").CellText(t) & "'")
                    '如果船图作业时间已经存在，则不更新时间
                    '加功能
                    If Me.C1IMAGE.Item(C1IMAGE.Row, "work_date") Is System.DBNull.Value Then
                        ExecSql("update con_image set  work_date='" & Now & "' where con_image_id='" & C1IMAGE.Columns(0).CellText(t) & "'")
                    End If

                    If cc = "1" Or cz = "1" Then
                        ExecSql("update con_image set MOVED=1,USER_update='" & G_User & "' where con_image_id='" & C1IMAGE.Columns(0).CellText(t) & "'")
                    Else
                        ExecSql("update con_image set MOVED=0,USER_update='" & G_User & "' where con_image_id='" & C1IMAGE.Columns(0).CellText(t) & "'")
                    End If

                    GETIMAGE()
                    bayno_TextChanged()
                End If
                Exit Sub
            End If

            Me.btbox.Enabled = False

            ExecSql("update con_hatch_record set unload_mark='1' where ship_id='" & Ship_ID & "' and container_no='" & C1IMAGE.Columns("CONTAINER_NO").CellText(t) & "'")
            ExecSql("update con_image set unload_mark='1',work_no='" & CmbWORK_NAME.SelectedValue & "',user_name='" & G_User & "',USER_update='" & G_User & "',user_code='" & G_WorkNo & "',work_date='" & Date.Now & "' where con_image_id='" & C1IMAGE.Columns(0).CellText(t) & "'")
            'ttt = "update con_hatch_record set unload_mark='1' where ship_id='" & Ship_ID & "' and container_no='" & C1IMAGE.Columns(9).CellText(t) & "'"
            'ttt = "update con_image set unload_mark='1',work_no='" & CmbWORK_NAME.SelectedValue & "',user_name='" & G_User & "',user_code='" & G_WorkNo & "',work_date='" & Date.Today & "' where con_image_id='" & C1IMAGE.Columns(0).CellText(t) & "'"

            Dim bhno As String
            Dim bh As String
            Dim str_query As String
            Dim dsbox As New DataSet
            Dim dscontally As New DataSet
            Dim dsboxtemp As New DataSet
            Dim dsno As New DataSet
            Dim tt As DateTime
            Dim endtime As String
            Dim demo As String = ""

            'Dim dx As String

            tt = Date.Now
            endtime = tt.Hour.ToString().PadLeft(2, "0") + tt.Minute.ToString().PadLeft(2, "0")

            If chkcc.Checked = True Or chkcz.Checked = True Then
                ExecSql("update con_image set moved='1' where con_image_id='" & C1IMAGE.Columns(0).CellText(t) & "'")
                str_query = "SELECT max(NO) from CON_TALLY_LIST where ship_id='" & Ship_ID & "' and TEAM_NO='" & cmbgb.Text & "' AND TALLY_CLERK1='" & CmbWORK_NAME.SelectedValue & "' and (inout_mark='1' or RELOAD='1') "
                Getdata(str_query, dsbox)

                If (dsbox.Tables(0).Rows(0)(0) Is System.DBNull.Value) Then
                    bhno = "dx" + CmbWORK_NAME.SelectedValue & cmbgb.Text & "0001"
                Else
                    Dim bhlen As Integer
                    bhlen = System.Convert.ToString(dsbox.Tables(0).Rows(0)(0)).Length
                    bh = System.Convert.ToInt64(System.Convert.ToString(dsbox.Tables(0).Rows(0)(0)).Substring(8)) + 1
                    bhno = System.Convert.ToString(dsbox.Tables(0).Rows(0)(0)).Substring(0, 8) + System.Convert.ToString(bh).PadLeft(bhlen - 8, "0")
                End If

                str_query = " INSERT INTO CON_TALLY_LIST(SHIP_ID, TEAM_NO, NO, DATE, TIME_FROM, TIME_TO, BerthNO, NIGHT_MARK, HOLIDAY, INOUT_MARK, RELOAD, ANCHORAGE_REMARK, SEA_AFFAIRE_CARGO, Tally_Clerk1, USER_NAME) VALUES('" & Ship_ID & "','" & cmbgb.Text & "','" & bhno & "','" & tt & "','" & endtime & "','" & endtime & "','" & ber & "','" & yb & "','" & jjr & "','" & cc & "','" & cz & "','0','0','" & CmbWORK_NAME.SelectedValue & "','" & G_WorkNo & "')"
                ExecSql(str_query)
                str_query = "select con_tally_list_id from CON_TALLY_LIST where ship_id='" & Ship_ID & "' and no='" & bhno & "'"
                Getdata(str_query, dscontally)

                str_query = "SELECT * from VIEW_Monitor where CON_IMAGE_ID='" & C1IMAGE.Columns(0).CellText(t) & "'"
                Getdata(str_query, dsboxtemp)
                str_query = "INSERT INTO CON_TALLY_DETAIL(CON_TALLY_LIST_ID, CONTAINER_NO, SIZE_CON, FULLOREMPTY, BAYNO, UnLoad_Mark, WEIGHT) VALUES ('" & dscontally.Tables(0).Rows(0)(0) & "','" & dsboxtemp.Tables(0).Rows(0)("CONTAINER_NO") & "','" & dsboxtemp.Tables(0).Rows(0)("SIZE_CON") & "','" & dsboxtemp.Tables(0).Rows(0)("FULLOREMPTY") & "','" & dsboxtemp.Tables(0).Rows(0)("POS") & "','1','" & dsboxtemp.Tables(0).Rows(0)("WEIGHT") / 1000 & "')"
                ExecSql(str_query)
                'btResure_Click(sender, e)
            Else
                str_query = "SELECT max(NO) from CON_TALLY_LIST where ship_id='" & Ship_ID & "' and TEAM_NO='" & cmbgb.Text & "' AND TALLY_CLERK1='" & CmbWORK_NAME.SelectedValue & "' and inout_mark='0' and reload='0'"
                Getdata(str_query, dsbox)

                If (dsbox.Tables(0).Rows(0)(0) Is System.DBNull.Value) Then
                    bhno = CmbWORK_NAME.SelectedValue & cmbgb.Text & "0001"
                Else
                    bh = System.Convert.ToString(System.Convert.ToInt64(dsbox.Tables(0).Rows(0)(0)) + 1)
                    bhno = bh.PadLeft(12, "0")
                End If

                str_query = " INSERT INTO CON_TALLY_LIST(SHIP_ID, TEAM_NO, NO, DATE, TIME_FROM, TIME_TO, BerthNO, NIGHT_MARK, HOLIDAY, INOUT_MARK, RELOAD, ANCHORAGE_REMARK, SEA_AFFAIRE_CARGO, Tally_Clerk1, USER_NAME) VALUES('" & Ship_ID & "','" & cmbgb.Text & "','" & bhno & "','" & tt & "','" & endtime & "','" & endtime & "','" & ber & "','" & yb & "','" & jjr & "','0','0','0','0','" & CmbWORK_NAME.SelectedValue & "','" & G_WorkNo & "')"
                ExecSql(str_query)
                str_query = "select con_tally_list_id from CON_TALLY_LIST where ship_id='" & Ship_ID & "' and no='" & bhno & "'"
                Getdata(str_query, dscontally)

                str_query = "SELECT * from VIEW_Monitor where CON_IMAGE_ID='" & C1IMAGE.Columns(0).CellText(t) & "'"
                Getdata(str_query, dsboxtemp)
                str_query = "INSERT INTO CON_TALLY_DETAIL(CON_TALLY_LIST_ID, CONTAINER_NO, SIZE_CON, FULLOREMPTY, BAYNO, UnLoad_Mark, WEIGHT) VALUES ('" & dscontally.Tables(0).Rows(0)(0) & "','" & dsboxtemp.Tables(0).Rows(0)("CONTAINER_NO") & "','" & dsboxtemp.Tables(0).Rows(0)("SIZE_CON") & "','" & dsboxtemp.Tables(0).Rows(0)("FULLOREMPTY") & "','" & dsboxtemp.Tables(0).Rows(0)("POS") & "','1','" & dsboxtemp.Tables(0).Rows(0)("WEIGHT") / 1000 & "')"
                demo = str_query
                ExecSql(str_query)
            End If

            Call OperateHistory(G_DeptName, Now, G_User, "增加", "con_tally_detail", dscontally.Tables(0).Rows(0)(0), "con_tally_list_id")

            If G_ShipName = "中韩之星" Then
                If chkcc.Checked = True Or chkcz.Checked = True Then
                    str_query = "SELECT max(NO) from CON_TALLY_LIST where ship_id='" & Ship_ID & "' and TEAM_NO='" & cmbgb.Text & "' AND TALLY_CLERK1='" & CmbWORK_NAME.SelectedValue & "' and (inout_mark='4' or reload='4') "
                    Getdata(str_query, dsbox)
                    If (dsbox.Tables(0).Rows(0)(0) Is System.DBNull.Value) Then
                        bhno = "td" + CmbWORK_NAME.SelectedValue & cmbgb.Text & "0001"
                    Else
                        Dim bhlen As Integer
                        bhlen = System.Convert.ToString(dsbox.Tables(0).Rows(0)(0)).Length
                        bh = System.Convert.ToInt64(System.Convert.ToString(dsbox.Tables(0).Rows(0)(0)).Substring(8)) + 1
                        bhno = System.Convert.ToString(dsbox.Tables(0).Rows(0)(0)).Substring(0, 8) + System.Convert.ToString(bh).PadLeft(bhlen - 8, "0")
                    End If
                    If chkcc.Checked = True Then
                        str_query = " INSERT INTO CON_TALLY_LIST(SHIP_ID, TEAM_NO, NO, DATE, TIME_FROM, TIME_TO, BerthNO, NIGHT_MARK, HOLIDAY, INOUT_MARK, RELOAD, ANCHORAGE_REMARK, SEA_AFFAIRE_CARGO, Tally_Clerk1, USER_NAME) VALUES('" & Ship_ID & "','" & cmbgb.Text & "','" & bhno & "','" & tt & "','" & endtime & "','" & endtime & "','" & ber & "','" & yb & "','" & jjr & "','4','3','0','0','" & CmbWORK_NAME.SelectedValue & "','" & G_WorkNo & "')"
                        ExecSql(str_query)
                    End If
                    If chkcz.Checked = True Then
                        str_query = " INSERT INTO CON_TALLY_LIST(SHIP_ID, TEAM_NO, NO, DATE, TIME_FROM, TIME_TO, BerthNO, NIGHT_MARK, HOLIDAY, INOUT_MARK, RELOAD, ANCHORAGE_REMARK, SEA_AFFAIRE_CARGO, Tally_Clerk1, USER_NAME) VALUES('" & Ship_ID & "','" & cmbgb.Text & "','" & bhno & "','" & tt & "','" & endtime & "','" & endtime & "','" & ber & "','" & yb & "','" & jjr & "','3','4','0','0','" & CmbWORK_NAME.SelectedValue & "','" & G_WorkNo & "')"
                        ExecSql(str_query)
                    End If
                    str_query = "select con_tally_list_id from CON_TALLY_LIST where ship_id='" & Ship_ID & "' and no='" & bhno & "'"
                    Getdata(str_query, dscontally)
                    str_query = "SELECT * from VIEW_Monitor_gzc where CON_IMAGE_ID='" & C1IMAGE.Columns(0).CellText(t) & "'"
                    Getdata(str_query, dsboxtemp)
                    str_query = "INSERT INTO CON_TALLY_DETAIL(CON_TALLY_LIST_ID, CONTAINER_NO, BAYNO, UnLoad_Mark) VALUES ('" & dscontally.Tables(0).Rows(0)(0) & "','" & dsboxtemp.Tables(0).Rows(0)("tray") & "','" & dsboxtemp.Tables(0).Rows(0)("POS") & "','1')"
                    ExecSql(str_query)

                    str_query = "SELECT * from CON_IMAGE_TRAY where ship_id='" & Ship_ID & "' and tray='" & dsboxtemp.Tables(0).Rows(0)("tray") & "' and BAYNO='" & dsboxtemp.Tables(0).Rows(0)("POS") & "'"
                    Getdata(str_query, dsno)
                    If dsno.Tables(0).Rows.Count > 0 Then
                        ExecSql("update con_image_tray set unload_mark='1',CLERK='" & G_WorkNo & "',CLERKTIME='" & Date.Today & "' where ship_id='" & Ship_ID & "' and tray='" & dsboxtemp.Tables(0).Rows(0)("tray") & "' and BAYNO='" & dsboxtemp.Tables(0).Rows(0)("POS") & "' ")
                    Else
                        'str_query = "insert into con_image_tray(SHIP_ID, TRAY, BAYNO, CLERK, USER_NAME, unload_mark, CLERKTIME) VALUES ('" & Ship_ID & "','" & dsboxtemp.Tables(0).Rows(0)("tray") & "','" & dsboxtemp.Tables(0).Rows(0)("POS") & "','" & G_WorkNo & "','1','" & Date.Today & "')"
                        'ExecSql(str_query)
                    End If
                Else
                    str_query = "SELECT max(NO) from CON_TALLY_LIST where ship_id='" & Ship_ID & "' and TEAM_NO='" & cmbgb.Text & "' AND TALLY_CLERK1='" & CmbWORK_NAME.SelectedValue & "' and inout_mark='3' and reload='3'"
                    Getdata(str_query, dsbox)
                    If (dsbox.Tables(0).Rows(0)(0) Is System.DBNull.Value) Then
                        bhno = "tc" + CmbWORK_NAME.SelectedValue & cmbgb.Text & "0001"
                    Else
                        Dim bhlen As Integer
                        bhlen = System.Convert.ToString(dsbox.Tables(0).Rows(0)(0)).Length
                        bh = System.Convert.ToInt64(System.Convert.ToString(dsbox.Tables(0).Rows(0)(0)).Substring(10)) + 1
                        bhno = System.Convert.ToString(dsbox.Tables(0).Rows(0)(0)).Substring(0, 10) + System.Convert.ToString(bh).PadLeft(bhlen - 10, "0")
                    End If
                    str_query = " INSERT INTO CON_TALLY_LIST(SHIP_ID, TEAM_NO, NO, DATE, TIME_FROM, TIME_TO, BerthNO, NIGHT_MARK, HOLIDAY, INOUT_MARK, RELOAD, ANCHORAGE_REMARK, SEA_AFFAIRE_CARGO, Tally_Clerk1, USER_NAME) VALUES('" & Ship_ID & "','" & cmbgb.Text & "','" & bhno & "','" & tt & "','" & endtime & "','" & endtime & "','" & ber & "','" & yb & "','" & jjr & "','3','3','0','0','" & CmbWORK_NAME.SelectedValue & "','" & G_WorkNo & "')"
                    ExecSql(str_query)
                    str_query = "select con_tally_list_id from CON_TALLY_LIST where ship_id='" & Ship_ID & "' and no='" & bhno & "'"
                    Getdata(str_query, dscontally)
                    str_query = "SELECT * from VIEW_Monitor_gzc where CON_IMAGE_ID='" & C1IMAGE.Columns(0).CellText(t) & "'"
                    Getdata(str_query, dsboxtemp)
                    str_query = "INSERT INTO CON_TALLY_DETAIL(CON_TALLY_LIST_ID, CONTAINER_NO, BAYNO, UnLoad_Mark) VALUES ('" & dscontally.Tables(0).Rows(0)(0) & "','" & dsboxtemp.Tables(0).Rows(0)("tray") & "','" & dsboxtemp.Tables(0).Rows(0)("POS") & "','1')"
                    ExecSql(str_query)

                    'If dsboxtemp.Tables(0).Rows(0)("tray") Is null Then
                    '    MsgBox("请输入贝位号！")
                    '    Return
                    'End If

                    str_query = "SELECT * from CON_IMAGE_TRAY where ship_id='" & Ship_ID & "' and tray='" & dsboxtemp.Tables(0).Rows(0)("tray") & "' and BAYNO='" & dsboxtemp.Tables(0).Rows(0)("POS") & "' "
                    Getdata(str_query, dsno)
                    If dsno.Tables(0).Rows.Count > 0 Then
                        ExecSql("update con_image_tray set unload_mark='1',CLERK='" & G_WorkNo & "',CLERKTIME='" & Date.Today & "' where ship_id='" & Ship_ID & "' and tray='" & dsboxtemp.Tables(0).Rows(0)("tray") & "' and BAYNO='" & dsboxtemp.Tables(0).Rows(0)("POS") & "' ")
                    Else
                        'str_query = "insert into con_image_tray(SHIP_ID, TRAY, BAYNO, CLERK, USER_NAME, unload_mark, CLERKTIME) VALUES ('" & Ship_ID & "','" & dsboxtemp.Tables(0).Rows(0)("tray") & "','" & dsboxtemp.Tables(0).Rows(0)("POS") & "','" & G_WorkNo & "','1','" & Date.Today & "')"
                        'ExecSql(str_query)
                    End If

                End If
            End If

            '写入操作日志文件
            Dim Address() As System.Net.IPAddress
            Dim st_log As String
            Dim a As Integer
            Dim myname As String
            Dim ip As String
            Address = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName()).AddressList
            myname = System.Net.Dns.GetHostName().ToString()
            For a = 0 To UBound(Address)
                ip = ip & Chr(13) & Address(a).ToString()
            Next
            st_log = String.Format("insert into con_info(worktype, shipid, cntr, bayno, truckno, ioport, workno, instime, message, dx) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}') ", "tally", Ship_ID, C1IMAGE.Columns("CONTAINER_NO").CellText(t), dsboxtemp.Tables(0).Rows(0)("POS"), " ", GL_IOPORT, G_WorkNo, Now.ToString(), "tally_ok" + "." + "gb." + cmbgb.Text + ".jjr." + jjr + ".yb." + yb + "." + myname + "." + ip, " ")
            ExecSql(st_log)

            GETIMAGE()
            Call bayno_TextChanged()
            C1IMAGE.Select()
            C1IMAGE.MoveFirst()
            C1IMAGE.Row = t + 1
            Me.btbox.Enabled = True
        Catch ex As Exception
            Me.btbox.Enabled = True
        End Try
    End Sub

    Private Sub btboxall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btboxall.Click
        Dim t As String
        Dim ttt As String
        Dim jjr As String
        Dim yb As String
        Dim bhno As String
        Dim bh As String
        Dim str_query As String
        Dim dsbox As New DataSet
        Dim dscontally As New DataSet
        Dim dsboxtemp As New DataSet
        Dim tt As DateTime
        Dim endtime As String

        If cmbgb.Text.Length = 0 Then
            MsgBox("请输入工班号！")
            Return
        End If

        Me.C1IMAGE.SelectedRows.Count.ToString()

        If Me.C1IMAGE.Item(C1IMAGE.Row, "UNLOAD_MARK") <> 0 Then
            MsgBox("该箱已作业！")
            'If MsgBox("本箱已作业,确认要修改吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
            '    ExecSql("update CON_TALLY_LIST set NIGHT_MARK='" & yb & "' ,HOLIDAY='" & jjr & "' ,Tally_Clerk1='" & CmbWORK_NAME.SelectedValue & "',USER_NAME='" & G_WorkNo & "' where CON_TALLY_LIST_ID in (select CON_TALLY_LIST_ID from CON_TALLY_LIST  where ship_id='" & Ship_ID & "' and con_tally_list_id in (select con_tally_list_id from CON_TALLY_detail where container_no='" & C1IMAGE.Columns("CONTAINER_NO").CellText(t) & "'))")
            '    Call count()
            'End If
            Return
        End If

        If chkjjr.Checked = True Then
            jjr = "1"
        Else
            jjr = "0"
        End If
        If chkyb.Checked = True Then
            yb = "1"
        Else
            yb = "0"
        End If
        t = C1IMAGE.Row
        'ExecSql("update con_hatch_record set unload_mark='1' where ship_id='" & Ship_ID & "' and container_no='" & C1IMAGE.Columns("CONTAINER_NO").CellText(t) & "' and unload_mark='0' ")
        'ExecSql("update con_image set unload_mark='1',work_no='" & CmbWORK_NAME.SelectedValue & "',user_name='" & G_User & "',user_code='" & G_WorkNo & "',work_date='" & Date.Today & "' where con_image_id='" & C1IMAGE.Columns(0).CellText(t) & "' and unload_mark='0' ")
    End Sub

    Private Sub txtwork_no_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtwork_no.KeyPress
        If e.KeyChar = Chr(13) Then
            If txtwork_no.Text.Trim().Length = 6 Then
                bayno = txtwork_no.Text.Trim()
            End If
        End If
    End Sub

    Private Sub bayno_TextChanged()
        Try
            If Len(Trim(Txtseachbay.Text)) > 0 Then
                dw.RowFilter = " bayno like '" & Txtseachbay.Text & "%'"
                If Len(Trim(Txtseachcol.Text)) > 0 Then
                    dw.RowFilter = " bayno like '" & Txtseachbay.Text & "%' and baycol like '" & Txtseachcol.Text & "%'  "
                End If
                If Len(Trim(Txtseachrow.Text)) > 0 Then
                    dw.RowFilter = " bayno like '" & Txtseachbay.Text & "%' and bayrow like '" & Txtseachrow.Text & "%' and baycol like '" & Txtseachcol.Text & "%'  "
                End If
            End If
            If Len(Trim(Txtseachbay.Text)) = 0 And Len(Trim(Txtseachcol.Text)) > 0 Then
                dw.RowFilter = " baycol like '" & Txtseachcol.Text & "%'"
                If Len(Trim(Txtseachrow.Text)) > 0 Then
                    dw.RowFilter = " bayrow like '" & Txtseachrow.Text & "%' and baycol like '" & Txtseachcol.Text & "%'  "
                End If
            End If
            If Len(Trim(Txtseachbay.Text)) = 0 And Len(Trim(Txtseachcol.Text)) = 0 And Len(Trim(Txtseachrow.Text)) > 0 Then
                dw.RowFilter = "bayrow like '" & Txtseachrow.Text & "%'"
            End If

            If Len(Trim(Txtseachbay.Text)) = 0 And Len(Trim(Txtseachcol.Text)) = 0 And Len(Trim(Txtseachrow.Text)) = 0 Then
                dw.RowFilter = " 1=1 "
            End If
            orderbypos()
            Me.C1IMAGE.Columns("CONTAINER_NO").FooterText = "合计 " & C1IMAGE.RowCount & " 条"
            C1IMAGE.Refresh()

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Txtseachbay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtseachbay.TextChanged
        Dim dsquery As New DataSet
        Try
            Call bayno_TextChanged()
            'If Len(Trim(Txtseachbay.Text)) > 0 Then
            '    dw.RowFilter = "bayno like '" & Txtseachbay.Text & "%' and baycol like '" & Txtseachcol.Text & "%'  "
            'Else
            '    dw.RowFilter = "1=1"
            'End If
            'orderbypos()

            'dw.RowFilter = "bayno like '" & Txtseachbay.Text & "%'"
            'dw.Sort = "baycol asc"
            'C1IMAGE.Refresh()
            'ElseIf Len(Trim(Txtseachbay.Text)) > 0 And RBROW.Checked = True Then
            'dw.RowFilter = "bayno like '" & Txtseachbay.Text & "%' "
            'dw.Sort = "bayrow asc"
            'C1IMAGE.Refresh()
            'Else
            'dw.RowFilter = "1=1"
            'If RBCOL.Checked = True Then
            '    dw.Sort = "baycol asc"
            'Else
            '    dw.Sort = "bayrow asc"
            'End If
            'End If
            'C1IMAGE.Refresh()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Txtseachcol_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtseachcol.TextChanged
        Try
            Call bayno_TextChanged()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Txtseachrow_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txtseachrow.TextChanged
        Try
            Call bayno_TextChanged()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            'chkdx.Checked = True 
            st = " and moved='1' "
        Else
            'chkdx.Checked = False
            If GL_IOPORT = 0 Then
                st = " and (code_unload_port like '%LYG' or UNLOAD_MARK=1) "
            ElseIf GL_IOPORT = 1 Then
                st = " and (code_load_port like '%LYG' or UNLOAD_MARK=1)  "
            End If
        End If
        GETIMAGE()
    End Sub

    Private Sub bterror_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bterror.Click
        If G_ShipName = "中韩之星" Then
            Dim Frm As New FrmCon_Monitor_TrayOnly
            Frm.ShowDialog()
        Else
            C1err.Visible = Not (C1err.Visible)
            If C1err.Visible = True Then
                C1errDisplay()
            Else
                Me.GroupBox4.Visible = False
            End If
        End If
    End Sub

    Private Sub C1err_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1err.DoubleClick
        Dim st As String
        st = "update tb_CON_INSTRUCTION set Error_Descr='99' where id=" & dsxdf.Tables(0).Rows(C1err.Row).Item("ID")
        DBControl.ExecSql(st)
        C1errDisplay()
    End Sub

    Private Sub C1errDisplay()
        Try
            Dim st As String
            st = "select ID, VESSEL, VOYAGE, CTN_NO, Error_Descr from tb_CON_INSTRUCTION where Complete_Mark=1 and Error_Descr is not null and Error_Descr <>'' and Error_Descr <>'99' order by id desc "
            C1err.DataSource = Getdata(st, dsxdf)
            If dsxdf.Tables(0).Rows.Count > 0 Then
                C1err.Visible = True
                Me.GroupBox4.Visible = True
                If GL_IOPORT = 0 Then
                    Label16.Text = "卸箱车号："
                Else
                    Label16.Text = "装船位置："
                End If

                Me.C1err.Splits(0).DisplayColumns.Item(0).Visible = False
                'Me.C1err.Splits(0).DisplayColumns.Item(0).Width = 0
                Me.C1err.Splits(0).DisplayColumns.Item(1).Width = 60
                Me.C1err.Splits(0).DisplayColumns.Item(2).Width = 50
                Me.C1err.Splits(0).DisplayColumns.Item(3).Width = 80
                Me.C1err.Splits(0).DisplayColumns.Item(4).Width = 300
                C1err.Columns.Item("VESSEL").Caption = "船名"
                C1err.Columns.Item("VOYAGE").Caption = "航次"
                C1err.Columns.Item("CTN_NO").Caption = "箱号"
                C1err.Columns.Item("Error_Descr").Caption = "错误说明"
            Else
                C1err.Visible = False
                Me.GroupBox4.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btxdforacle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btxdforacle.Click
        'Dim st As String
        'st = "update tb_CON_INSTRUCTION set Error_Descr='99' where id=" & dsxdf.Tables(0).Rows(C1err.Row).Item("ID")
        'DBControl.ExecSql(st)
        'C1errDisplay()
    End Sub

    Private Sub C1IMAGE_HeadClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles C1IMAGE.HeadClick
        OrderStr = " order by " + C1IMAGE.Columns(e.ColIndex).DataField.ToString() + " desc "
    End Sub

    Private Sub btname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btname.Click
        tjtype = Not (tjtype)
        tj()
    End Sub

    Private Sub tj()
        btname.Enabled = False
        If tjtype = True Then
            btname.Text = "分人员统计"
            Getdata("exec sp_tally_pda '" & Ship_ID & "','" & GL_IOPORT & "'", dstally)
            c1tally.DataSource = dstally.Tables(0).DefaultView
            Me.c1tally.Splits(0).DisplayColumns.Item(0).Width = 50
            Me.c1tally.Splits(0).DisplayColumns.Item(1).Width = 50
            Me.c1tally.Splits(0).DisplayColumns.Item(2).Width = 80
            Me.c1tally.Splits(0).DisplayColumns.Item(3).Width = 50
            Me.c1tally.Splits(0).DisplayColumns.Item(4).Width = 50
            '统计捣箱数据
            c1tallydx.DataSource = dstally.Tables(1).DefaultView
            Me.c1tallydx.Splits(0).DisplayColumns.Item(0).Width = 50
            Me.c1tallydx.Splits(0).DisplayColumns.Item(1).Width = 50
            Me.c1tallydx.Splits(0).DisplayColumns.Item(2).Width = 80
            Me.c1tallydx.Splits(0).DisplayColumns.Item(3).Width = 50
            Me.c1tallydx.Splits(0).DisplayColumns.Item(4).Width = 50
            '统计内外贸数据
            C1nwm.DataSource = dstally.Tables(2).DefaultView
            Me.C1nwm.Splits(0).DisplayColumns.Item(0).Width = 50
            Me.C1nwm.Splits(0).DisplayColumns.Item(1).Width = 50
            Me.C1nwm.Splits(0).DisplayColumns.Item(2).Width = 80
            Me.C1nwm.Splits(0).DisplayColumns.Item(3).Width = 50
            Me.C1nwm.Splits(0).DisplayColumns.Item(4).Width = 50
            Me.C1nwm.Splits(0).DisplayColumns.Item(5).Width = 100
        Else
            btname.Text = "全船统计"
            Getdata("exec sp_tally_pda_by_workno '" & Ship_ID & "','" & GL_IOPORT & "'", dstally)
            c1tally.DataSource = dstally.Tables(0).DefaultView
            Me.c1tally.Splits(0).DisplayColumns.Item(0).Width = 50
            Me.c1tally.Splits(0).DisplayColumns.Item(1).Width = 50
            Me.c1tally.Splits(0).DisplayColumns.Item(2).Width = 50
            Me.c1tally.Splits(0).DisplayColumns.Item(3).Width = 80
            Me.c1tally.Splits(0).DisplayColumns.Item(4).Width = 50
            Me.c1tally.Splits(0).DisplayColumns.Item(5).Width = 50
            '统计捣箱数据 
            c1tallydx.DataSource = dstally.Tables(1).DefaultView
            Me.c1tallydx.Splits(0).DisplayColumns.Item(0).Width = 50
            Me.c1tallydx.Splits(0).DisplayColumns.Item(1).Width = 50
            Me.c1tallydx.Splits(0).DisplayColumns.Item(2).Width = 50
            Me.c1tallydx.Splits(0).DisplayColumns.Item(3).Width = 80
            Me.c1tallydx.Splits(0).DisplayColumns.Item(4).Width = 50
            Me.c1tallydx.Splits(0).DisplayColumns.Item(5).Width = 50
        End If
        btname.Enabled = True
    End Sub

    Private Sub tjbay()
        dsbay.Reset()
        Getdata("select distinct bayno, code_unload_port from VIEW_Monitor_new where ship_id=" & Ship_ID & " and code_load_port='CNLYG' group by bayno,code_unload_port order by code_unload_port,bayno", dsbay)
        C1port.DataSource = dsbay.Tables(0).DefaultView
        Me.C1port.Splits(0).DisplayColumns.Item(0).Width = 50
        Me.C1port.Splits(0).DisplayColumns.Item(1).Width = 80
        C1port.Columns.Item("bayno").Caption = "贝位"
        C1port.Columns.Item("code_unload_port").Caption = "卸货港"
    End Sub

    Private Sub btrefr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btrefr.Click
        Timer1_Tick(sender, e)
        If (txtrefr.Text.Trim.Length > 0) Then
            t = Convert.ToDouble(txtrefr.Text)
            If (t > 0) Then
                Me.Timer1.Start()
                Me.Timer1.Interval = t * 60.0 * 1000
            End If
        Else
            Me.Timer1.Stop()
            t = 0
        End If
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim dscntr As New DataSet
        Getdata("select   container_no   from   VIEW_Monitor_new  where ship_id='" & Ship_ID & "' group   by   container_no    having(count(container_no) > 1) ", dscntr)
        If dscntr.Tables(0).Rows.Count > 0 Then
            MsgBox("第一个箱 " & dscntr.Tables(0).Rows(0)(0) & " 共 " & dscntr.Tables(0).Rows.Count & " 个箱") ', MsgBoxStyle.OKOnly, "重复箱号")
        Else
            MsgBox("无重箱号！") ', MsgBoxStyle.OKOnly, "重复箱号")
        End If
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Dim frm As New Frm_bay_workabout
        frm.ShowDialog()
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Dim dscntr As New DataSet
        Getdata("SELECT BAYNO,CONTAINER_NO FROM CON_IMAGE WHERE SHIP_ID = " & Ship_ID & " " & _
                 "and BAYNO in (SELECT BAYNO FROM CON_IMAGE WHERE SHIP_ID = " & Ship_ID & " group by BAYNO having count(*)>1) ", dscntr)

        If dscntr.Tables(0).Rows.Count > 0 Then
            MsgBox("第一个箱 " & dscntr.Tables(0).Rows(0)(1) & " 在 " & dscntr.Tables(0).Rows(0)(0) & " 共 " & dscntr.Tables(0).Rows.Count & " 个重贝位箱")      ', MsgBoxStyle.OKOnly, "重复箱号")
        Else
            MsgBox("无重复贝位！") ', MsgBoxStyle.OKOnly, "重复箱号")
        End If
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim frm As New Form1
        frm.ShowDialog()
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Dim fm As New SMS.Form2
        ReceiveParameters()
        fm.ShowDialog()
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        Dim fm As New SMS.Form3
        ReceiveParameters()
        fm.ShowDialog()
    End Sub

    Private Sub C1IMAGE_AfterFilter(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FilterEventArgs) Handles C1IMAGE.AfterFilter
        Me.C1IMAGE.Columns.Item("CONTAINER_NO").FooterText = "共 " & C1IMAGE.Splits(0).Rows.Count & " 条"
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        ExecSql("update con_image set unload_mark=0 where ship_id=" & Ship_ID & " and container_no not in (select CONTAINER_NO from CON_TALLY_DETAIL where CON_TALLY_LIST_ID in ( select CON_TALLY_LIST_ID from CON_TALLY_LIST where ship_id=" & Ship_ID & "))")
        ExecSql("update con_hatch_record set unload_mark=0 where ship_id=" & Ship_ID & " and container_no not in (select CONTAINER_NO from CON_TALLY_DETAIL where CON_TALLY_LIST_ID in ( select CON_TALLY_LIST_ID from CON_TALLY_LIST where ship_id=" & Ship_ID & "))")

        '写入操作日志文件
        Dim Address() As Net.IPAddress
        Dim st_log As String
        Dim a As Integer
        Dim myname As String
        Dim ip As String
        Address = Net.Dns.GetHostByName(Net.Dns.GetHostName()).AddressList
        myname = Net.Dns.GetHostName().ToString()
        For a = 0 To UBound(Address)
            ip = ip & Chr(13) & Address(a).ToString()
        Next
        st_log = String.Format("insert into con_info(worktype, shipid, cntr, bayno, truckno, ioport, workno, instime, message, dx) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}') ", "tally_rolback_con", Ship_ID, "", "", " ", GL_IOPORT, G_WorkNo, Now.ToString(), myname + "." + ip, "撤消未作业箱")
        ExecSql(st_log)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Cursor = Cursors.WaitCursor
        checkbay()
        Cursor = Cursors.Default
    End Sub

    Private Sub mnuSMS_Click(sender As System.Object, e As System.EventArgs) Handles mnuSMS.Click
        Dim fm As New SMS.MessageSend
        'fm.Controls.Add(Me.stb)
        'Hide()
        ReceiveParameters()
        fm.ShowDialog()
        'Controls.Add(stb)
        'Show()
    End Sub

    ''' <summary>
    ''' 动态链接库接收参数
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ReceiveParameters()
        SMS.G_User = G_User
        SMS.G_User_Serial = G_User_Serial
        SMS.G_DeptCode = G_DeptCode
        SMS.G_DeptName = G_DeptName
        SMS.G_Part_Id = G_Part_Id
        SMS.G_Part = G_Part
        SMS.G_ShipName = G_ShipName
        SMS.G_Voyage = G_Voyage
        SMS.Ship_ID = Ship_ID
    End Sub
   
End Class
