Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FrmCon_Verify
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
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
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabTALLY_LIST As System.Windows.Forms.TabPage
    Friend WithEvents TabDaily As System.Windows.Forms.TabPage
    Friend WithEvents C1DBGDaily_report As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents LabREMARKS As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents tbbtnFind As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnPrint As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnQuit As System.Windows.Forms.ToolBarButton
    Friend WithEvents TabCertificate As System.Windows.Forms.TabPage
    Friend WithEvents C1DBGTally_List As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1DBGCertificate As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents tbbfind_Container As System.Windows.Forms.ToolBarButton
    Friend WithEvents TabDailyDx As System.Windows.Forms.TabPage
    Friend WithEvents C1DBGDaily_report_dx As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkjjr As System.Windows.Forms.CheckBox
    Friend WithEvents chkyb As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Infozxg As System.Windows.Forms.Label
    Friend WithEvents Infops As System.Windows.Forms.Label
    Friend WithEvents Infosjds As System.Windows.Forms.Label
    Friend WithEvents Infohm As System.Windows.Forms.Label
    Friend WithEvents Infoqdds As System.Windows.Forms.Label
    Friend WithEvents Infosjjs As System.Windows.Forms.Label
    Friend WithEvents Infoqdjs As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Infobw As System.Windows.Forms.Label
    Friend WithEvents Infojck As System.Windows.Forms.Label
    Friend WithEvents Infohc As System.Windows.Forms.Label
    Friend WithEvents Infoywgj As System.Windows.Forms.Label
    Friend WithEvents Infoywcm As System.Windows.Forms.Label
    Friend WithEvents Infocd As System.Windows.Forms.Label
    Friend WithEvents Infozwgj As System.Windows.Forms.Label
    Friend WithEvents Infozwcm As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Infowgsj As System.Windows.Forms.Label
    Friend WithEvents Infokgsj As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents TabShort As System.Windows.Forms.TabPage
    Friend WithEvents C1DBGShort As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents TabFee As System.Windows.Forms.TabPage
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCon_Verify))
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.C1DBGV = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.GB = New System.Windows.Forms.GroupBox
        Me.ToolBar = New System.Windows.Forms.ToolBar
        Me.tbbfind_Container = New System.Windows.Forms.ToolBarButton
        Me.tbbtnFind = New System.Windows.Forms.ToolBarButton
        Me.tbbtnPrint = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuit = New System.Windows.Forms.ToolBarButton
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Infowgsj = New System.Windows.Forms.Label
        Me.Infokgsj = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.TabTALLY_LIST = New System.Windows.Forms.TabPage
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.chkjjr = New System.Windows.Forms.CheckBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.chkyb = New System.Windows.Forms.CheckBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.C1DBGTally_List = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TabDaily = New System.Windows.Forms.TabPage
        Me.C1DBGDaily_report = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TabCertificate = New System.Windows.Forms.TabPage
        Me.C1DBGCertificate = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TabDailyDx = New System.Windows.Forms.TabPage
        Me.C1DBGDaily_report_dx = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TabShort = New System.Windows.Forms.TabPage
        Me.C1DBGShort = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TabFee = New System.Windows.Forms.TabPage
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.LabREMARKS = New System.Windows.Forms.Label
        Me.Label = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Infozxg = New System.Windows.Forms.Label
        Me.Infops = New System.Windows.Forms.Label
        Me.Infosjds = New System.Windows.Forms.Label
        Me.Infohm = New System.Windows.Forms.Label
        Me.Infoqdds = New System.Windows.Forms.Label
        Me.Infosjjs = New System.Windows.Forms.Label
        Me.Infoqdjs = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Infobw = New System.Windows.Forms.Label
        Me.Infojck = New System.Windows.Forms.Label
        Me.Infohc = New System.Windows.Forms.Label
        Me.Infoywgj = New System.Windows.Forms.Label
        Me.Infoywcm = New System.Windows.Forms.Label
        Me.Infocd = New System.Windows.Forms.Label
        Me.Infozwgj = New System.Windows.Forms.Label
        Me.Infozwcm = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.GBV.SuspendLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TabTALLY_LIST.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.C1DBGTally_List, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabDaily.SuspendLayout()
        CType(Me.C1DBGDaily_report, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCertificate.SuspendLayout()
        CType(Me.C1DBGCertificate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabDailyDx.SuspendLayout()
        CType(Me.C1DBGDaily_report_dx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabShort.SuspendLayout()
        CType(Me.C1DBGShort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabFee.SuspendLayout()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuCompile, Me.mnuHelp})
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
        Me.mnuHelp.Text = "帮助(&H)"
        '
        'GBV
        '
        Me.GBV.Controls.Add(Me.ToolBarV)
        Me.GBV.Controls.Add(Me.btResure)
        Me.GBV.Controls.Add(Me.txtVoyage)
        Me.GBV.Controls.Add(Me.Label2)
        Me.GBV.Controls.Add(Me.txtShipName)
        Me.GBV.Controls.Add(Me.Label1)
        Me.GBV.Controls.Add(Me.C1DBGV)
        Me.GBV.Dock = System.Windows.Forms.DockStyle.Left
        Me.GBV.Location = New System.Drawing.Point(0, 0)
        Me.GBV.Name = "GBV"
        Me.GBV.Size = New System.Drawing.Size(174, 449)
        Me.GBV.TabIndex = 6
        Me.GBV.TabStop = False
        '
        'ToolBarV
        '
        Me.ToolBarV.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.S1, Me.tbbtnOK, Me.S2, Me.tbbtnSearch, Me.S3, Me.tbbtnSort, Me.S4, Me.tbbtnEng})
        Me.ToolBarV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBarV.DropDownArrows = True
        Me.ToolBarV.ImageList = Me.ImageList
        Me.ToolBarV.Location = New System.Drawing.Point(3, 405)
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
        Me.btResure.Location = New System.Drawing.Point(128, 332)
        Me.btResure.Name = "btResure"
        Me.btResure.Size = New System.Drawing.Size(42, 22)
        Me.btResure.TabIndex = 16
        Me.btResure.Text = "查询"
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(38, 332)
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(88, 21)
        Me.txtVoyage.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 14)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "航次"
        '
        'txtShipName
        '
        Me.txtShipName.Location = New System.Drawing.Point(38, 308)
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.Size = New System.Drawing.Size(132, 21)
        Me.txtShipName.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 310)
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
        Me.C1DBGV.Size = New System.Drawing.Size(168, 289)
        Me.C1DBGV.TabIndex = 0
        Me.C1DBGV.Text = "C1TrueDBGrid1"
        Me.C1DBGV.PropBag = resources.GetString("C1DBGV.PropBag")
        '
        'GB
        '
        Me.GB.Controls.Add(Me.ToolBar)
        Me.GB.Controls.Add(Me.TabControl1)
        Me.GB.Controls.Add(Me.LabREMARKS)
        Me.GB.Controls.Add(Me.Label)
        Me.GB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB.Location = New System.Drawing.Point(174, 0)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(720, 449)
        Me.GB.TabIndex = 7
        Me.GB.TabStop = False
        '
        'ToolBar
        '
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbfind_Container, Me.tbbtnFind, Me.tbbtnPrint, Me.tbbtnQuit})
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.Enabled = False
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(3, 17)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(714, 41)
        Me.ToolBar.TabIndex = 16
        '
        'tbbfind_Container
        '
        Me.tbbfind_Container.ImageIndex = 9
        Me.tbbfind_Container.Name = "tbbfind_Container"
        Me.tbbfind_Container.Text = "互租"
        Me.tbbfind_Container.ToolTipText = "互租箱信息"
        '
        'tbbtnFind
        '
        Me.tbbtnFind.ImageIndex = 0
        Me.tbbtnFind.Name = "tbbtnFind"
        Me.tbbtnFind.Text = "审核"
        Me.tbbtnFind.ToolTipText = "审核"
        '
        'tbbtnPrint
        '
        Me.tbbtnPrint.ImageIndex = 5
        Me.tbbtnPrint.Name = "tbbtnPrint"
        Me.tbbtnPrint.Text = "反审"
        Me.tbbtnPrint.ToolTipText = "撤销审核信息"
        '
        'tbbtnQuit
        '
        Me.tbbtnQuit.ImageIndex = 7
        Me.tbbtnQuit.Name = "tbbtnQuit"
        Me.tbbtnQuit.Text = "退出"
        Me.tbbtnQuit.ToolTipText = "退出"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabTALLY_LIST)
        Me.TabControl1.Controls.Add(Me.TabDaily)
        Me.TabControl1.Controls.Add(Me.TabCertificate)
        Me.TabControl1.Controls.Add(Me.TabDailyDx)
        Me.TabControl1.Controls.Add(Me.TabShort)
        Me.TabControl1.Controls.Add(Me.TabFee)
        Me.TabControl1.Location = New System.Drawing.Point(6, 124)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(710, 322)
        Me.TabControl1.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Controls.Add(Me.Panel5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 21)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(702, 297)
        Me.TabPage1.TabIndex = 6
        Me.TabPage1.Text = "理货记录簿"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Infowgsj)
        Me.Panel4.Controls.Add(Me.Infokgsj)
        Me.Panel4.Controls.Add(Me.Label53)
        Me.Panel4.Controls.Add(Me.Label54)
        Me.Panel4.Controls.Add(Me.Label51)
        Me.Panel4.Controls.Add(Me.Label21)
        Me.Panel4.Controls.Add(Me.Label22)
        Me.Panel4.Controls.Add(Me.Label23)
        Me.Panel4.Controls.Add(Me.Label24)
        Me.Panel4.Controls.Add(Me.Label25)
        Me.Panel4.Controls.Add(Me.Label26)
        Me.Panel4.Controls.Add(Me.Label27)
        Me.Panel4.Controls.Add(Me.Label52)
        Me.Panel4.Controls.Add(Me.Label28)
        Me.Panel4.Controls.Add(Me.Label29)
        Me.Panel4.Controls.Add(Me.Label30)
        Me.Panel4.Controls.Add(Me.Label31)
        Me.Panel4.Controls.Add(Me.Label32)
        Me.Panel4.Controls.Add(Me.Label33)
        Me.Panel4.Controls.Add(Me.Label34)
        Me.Panel4.Location = New System.Drawing.Point(8, 128)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(640, 147)
        Me.Panel4.TabIndex = 3
        '
        'Infowgsj
        '
        Me.Infowgsj.AutoSize = True
        Me.Infowgsj.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Infowgsj.ForeColor = System.Drawing.Color.ForestGreen
        Me.Infowgsj.Location = New System.Drawing.Point(109, 114)
        Me.Infowgsj.Name = "Infowgsj"
        Me.Infowgsj.Size = New System.Drawing.Size(0, 16)
        Me.Infowgsj.TabIndex = 4
        '
        'Infokgsj
        '
        Me.Infokgsj.AutoSize = True
        Me.Infokgsj.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Infokgsj.ForeColor = System.Drawing.Color.ForestGreen
        Me.Infokgsj.Location = New System.Drawing.Point(109, 90)
        Me.Infokgsj.Name = "Infokgsj"
        Me.Infokgsj.Size = New System.Drawing.Size(0, 16)
        Me.Infokgsj.TabIndex = 5
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label53.Location = New System.Drawing.Point(23, 114)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(72, 16)
        Me.Label53.TabIndex = 2
        Me.Label53.Text = "完工时间"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label54.Location = New System.Drawing.Point(23, 90)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(72, 16)
        Me.Label54.TabIndex = 3
        Me.Label54.Text = "开工时间"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label51.Location = New System.Drawing.Point(392, 117)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(56, 16)
        Me.Label51.TabIndex = 0
        Me.Label51.Text = "标箱数"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label21.Location = New System.Drawing.Point(392, 90)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 16)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "装卸港"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label22.Location = New System.Drawing.Point(408, 63)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(40, 16)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "票数"
        Me.Label22.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label23.Location = New System.Drawing.Point(55, 63)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(40, 16)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "货名"
        Me.Label23.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label24.Location = New System.Drawing.Point(376, 39)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 16)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "实际吨数"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label25.Location = New System.Drawing.Point(23, 39)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 16)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "实际箱数"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label26.Location = New System.Drawing.Point(376, 13)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 16)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "清单吨数"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label27.Location = New System.Drawing.Point(23, 13)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 16)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "清单箱数"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label52.Location = New System.Drawing.Point(462, 117)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(0, 16)
        Me.Label52.TabIndex = 0
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label28.Location = New System.Drawing.Point(462, 90)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(0, 16)
        Me.Label28.TabIndex = 0
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label29.Location = New System.Drawing.Point(462, 63)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(0, 16)
        Me.Label29.TabIndex = 0
        Me.Label29.Visible = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label30.Location = New System.Drawing.Point(462, 39)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(0, 16)
        Me.Label30.TabIndex = 0
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label31.Location = New System.Drawing.Point(109, 63)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(0, 16)
        Me.Label31.TabIndex = 0
        Me.Label31.Visible = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label32.Location = New System.Drawing.Point(462, 13)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(0, 16)
        Me.Label32.TabIndex = 0
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label33.Location = New System.Drawing.Point(109, 39)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(0, 16)
        Me.Label33.TabIndex = 0
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label34.Location = New System.Drawing.Point(109, 13)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(0, 16)
        Me.Label34.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label35)
        Me.Panel5.Controls.Add(Me.Label36)
        Me.Panel5.Controls.Add(Me.Label37)
        Me.Panel5.Controls.Add(Me.Label38)
        Me.Panel5.Controls.Add(Me.Label39)
        Me.Panel5.Controls.Add(Me.Label40)
        Me.Panel5.Controls.Add(Me.Label41)
        Me.Panel5.Controls.Add(Me.Label42)
        Me.Panel5.Controls.Add(Me.Label43)
        Me.Panel5.Controls.Add(Me.Label44)
        Me.Panel5.Controls.Add(Me.Label45)
        Me.Panel5.Controls.Add(Me.Label46)
        Me.Panel5.Controls.Add(Me.Label47)
        Me.Panel5.Controls.Add(Me.Label48)
        Me.Panel5.Controls.Add(Me.Label49)
        Me.Panel5.Controls.Add(Me.Label50)
        Me.Panel5.Location = New System.Drawing.Point(8, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(640, 125)
        Me.Panel5.TabIndex = 2
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label35.Location = New System.Drawing.Point(54, 92)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(40, 16)
        Me.Label35.TabIndex = 0
        Me.Label35.Text = "航次"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label36.Location = New System.Drawing.Point(39, 66)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(56, 16)
        Me.Label36.TabIndex = 0
        Me.Label36.Text = "进出口"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label37.Location = New System.Drawing.Point(408, 66)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(40, 16)
        Me.Label37.TabIndex = 0
        Me.Label37.Text = "泊位"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label38.Location = New System.Drawing.Point(376, 40)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(72, 16)
        Me.Label38.TabIndex = 0
        Me.Label38.Text = "英文国籍"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label39.Location = New System.Drawing.Point(23, 40)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(72, 16)
        Me.Label39.TabIndex = 0
        Me.Label39.Text = "英文船名"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label40.Location = New System.Drawing.Point(408, 92)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(40, 16)
        Me.Label40.TabIndex = 0
        Me.Label40.Text = "船代"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label41.Location = New System.Drawing.Point(376, 15)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(72, 16)
        Me.Label41.TabIndex = 0
        Me.Label41.Text = "中文国籍"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label42.Location = New System.Drawing.Point(462, 66)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(0, 16)
        Me.Label42.TabIndex = 0
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label43.Location = New System.Drawing.Point(110, 66)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(0, 16)
        Me.Label43.TabIndex = 0
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label44.Location = New System.Drawing.Point(110, 92)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(0, 16)
        Me.Label44.TabIndex = 0
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label45.Location = New System.Drawing.Point(462, 40)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(0, 16)
        Me.Label45.TabIndex = 0
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label46.Location = New System.Drawing.Point(110, 40)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(0, 16)
        Me.Label46.TabIndex = 0
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label47.Location = New System.Drawing.Point(462, 92)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(0, 16)
        Me.Label47.TabIndex = 0
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label48.Location = New System.Drawing.Point(462, 15)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(0, 16)
        Me.Label48.TabIndex = 0
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label49.Location = New System.Drawing.Point(110, 15)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(0, 16)
        Me.Label49.TabIndex = 0
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label50.Location = New System.Drawing.Point(23, 15)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(72, 16)
        Me.Label50.TabIndex = 0
        Me.Label50.Text = "中文船名"
        '
        'TabTALLY_LIST
        '
        Me.TabTALLY_LIST.Controls.Add(Me.Panel1)
        Me.TabTALLY_LIST.Controls.Add(Me.C1DBGTally_List)
        Me.TabTALLY_LIST.Location = New System.Drawing.Point(4, 21)
        Me.TabTALLY_LIST.Name = "TabTALLY_LIST"
        Me.TabTALLY_LIST.Size = New System.Drawing.Size(675, 297)
        Me.TabTALLY_LIST.TabIndex = 0
        Me.TabTALLY_LIST.Text = "理箱单"
        Me.TabTALLY_LIST.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.chkjjr)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.chkyb)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(230, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(24, 21)
        Me.Panel1.TabIndex = 13
        Me.Panel1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(13, 135)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(42, 21)
        Me.TextBox1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(15, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "开始时间"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(97, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "节假日信息修改"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(97, 101)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "夜班信息修改"
        '
        'chkjjr
        '
        Me.chkjjr.Location = New System.Drawing.Point(15, 66)
        Me.chkjjr.Name = "chkjjr"
        Me.chkjjr.Size = New System.Drawing.Size(62, 24)
        Me.chkjjr.TabIndex = 2
        Me.chkjjr.Text = "节假日"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(131, 164)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 35)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "隐藏"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(97, 135)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "工班信息修改"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(61, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "工班"
        '
        'chkyb
        '
        Me.chkyb.Location = New System.Drawing.Point(17, 101)
        Me.chkyb.Name = "chkyb"
        Me.chkyb.Size = New System.Drawing.Size(62, 24)
        Me.chkyb.TabIndex = 2
        Me.chkyb.Text = "夜班"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(73, 36)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(132, 21)
        Me.DateTimePicker2.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy/MM/dd HH:mm"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(73, 8)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(132, 21)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(15, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "结束时间"
        '
        'C1DBGTally_List
        '
        Me.C1DBGTally_List.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGTally_List.AllowUpdate = False
        Me.C1DBGTally_List.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGTally_List.FilterBar = True
        Me.C1DBGTally_List.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGTally_List.Images.Add(CType(resources.GetObject("C1DBGTally_List.Images"), System.Drawing.Image))
        Me.C1DBGTally_List.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGTally_List.Name = "C1DBGTally_List"
        Me.C1DBGTally_List.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGTally_List.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGTally_List.PreviewInfo.ZoomFactor = 75
        Me.C1DBGTally_List.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGTally_List.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGTally_List.Size = New System.Drawing.Size(637, 296)
        Me.C1DBGTally_List.TabIndex = 11
        Me.C1DBGTally_List.Text = "C1DBG"
        Me.C1DBGTally_List.PropBag = resources.GetString("C1DBGTally_List.PropBag")
        '
        'TabDaily
        '
        Me.TabDaily.BackColor = System.Drawing.Color.Transparent
        Me.TabDaily.Controls.Add(Me.C1DBGDaily_report)
        Me.TabDaily.Location = New System.Drawing.Point(4, 21)
        Me.TabDaily.Name = "TabDaily"
        Me.TabDaily.Size = New System.Drawing.Size(675, 297)
        Me.TabDaily.TabIndex = 4
        Me.TabDaily.Text = "日报"
        Me.TabDaily.UseVisualStyleBackColor = True
        Me.TabDaily.Visible = False
        '
        'C1DBGDaily_report
        '
        Me.C1DBGDaily_report.AllowFilter = False
        Me.C1DBGDaily_report.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGDaily_report.AllowUpdate = False
        Me.C1DBGDaily_report.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGDaily_report.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGDaily_report.Images.Add(CType(resources.GetObject("C1DBGDaily_report.Images"), System.Drawing.Image))
        Me.C1DBGDaily_report.Location = New System.Drawing.Point(0, 1)
        Me.C1DBGDaily_report.Name = "C1DBGDaily_report"
        Me.C1DBGDaily_report.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGDaily_report.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGDaily_report.PreviewInfo.ZoomFactor = 75
        Me.C1DBGDaily_report.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGDaily_report.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGDaily_report.Size = New System.Drawing.Size(671, 296)
        Me.C1DBGDaily_report.TabIndex = 12
        Me.C1DBGDaily_report.Text = "C1DBG"
        Me.C1DBGDaily_report.PropBag = resources.GetString("C1DBGDaily_report.PropBag")
        '
        'TabCertificate
        '
        Me.TabCertificate.Controls.Add(Me.C1DBGCertificate)
        Me.TabCertificate.Location = New System.Drawing.Point(4, 21)
        Me.TabCertificate.Name = "TabCertificate"
        Me.TabCertificate.Size = New System.Drawing.Size(675, 297)
        Me.TabCertificate.TabIndex = 1
        Me.TabCertificate.Text = "理货业务凭证"
        Me.TabCertificate.UseVisualStyleBackColor = True
        Me.TabCertificate.Visible = False
        '
        'C1DBGCertificate
        '
        Me.C1DBGCertificate.AllowFilter = False
        Me.C1DBGCertificate.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGCertificate.AllowUpdate = False
        Me.C1DBGCertificate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGCertificate.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGCertificate.Images.Add(CType(resources.GetObject("C1DBGCertificate.Images"), System.Drawing.Image))
        Me.C1DBGCertificate.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGCertificate.Name = "C1DBGCertificate"
        Me.C1DBGCertificate.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGCertificate.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGCertificate.PreviewInfo.ZoomFactor = 75
        Me.C1DBGCertificate.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGCertificate.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGCertificate.Size = New System.Drawing.Size(675, 297)
        Me.C1DBGCertificate.TabIndex = 12
        Me.C1DBGCertificate.Text = "C1DBG"
        Me.C1DBGCertificate.PropBag = resources.GetString("C1DBGCertificate.PropBag")
        '
        'TabDailyDx
        '
        Me.TabDailyDx.Controls.Add(Me.C1DBGDaily_report_dx)
        Me.TabDailyDx.Location = New System.Drawing.Point(4, 21)
        Me.TabDailyDx.Name = "TabDailyDx"
        Me.TabDailyDx.Size = New System.Drawing.Size(675, 297)
        Me.TabDailyDx.TabIndex = 5
        Me.TabDailyDx.Text = "捣箱日报"
        Me.TabDailyDx.UseVisualStyleBackColor = True
        '
        'C1DBGDaily_report_dx
        '
        Me.C1DBGDaily_report_dx.AllowFilter = False
        Me.C1DBGDaily_report_dx.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGDaily_report_dx.AllowUpdate = False
        Me.C1DBGDaily_report_dx.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGDaily_report_dx.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGDaily_report_dx.Images.Add(CType(resources.GetObject("C1DBGDaily_report_dx.Images"), System.Drawing.Image))
        Me.C1DBGDaily_report_dx.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGDaily_report_dx.Name = "C1DBGDaily_report_dx"
        Me.C1DBGDaily_report_dx.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGDaily_report_dx.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGDaily_report_dx.PreviewInfo.ZoomFactor = 75
        Me.C1DBGDaily_report_dx.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGDaily_report_dx.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGDaily_report_dx.Size = New System.Drawing.Size(675, 296)
        Me.C1DBGDaily_report_dx.TabIndex = 13
        Me.C1DBGDaily_report_dx.Text = "C1DBG"
        Me.C1DBGDaily_report_dx.PropBag = resources.GetString("C1DBGDaily_report_dx.PropBag")
        '
        'TabShort
        '
        Me.TabShort.BackColor = System.Drawing.Color.Transparent
        Me.TabShort.Controls.Add(Me.C1DBGShort)
        Me.TabShort.Location = New System.Drawing.Point(4, 21)
        Me.TabShort.Name = "TabShort"
        Me.TabShort.Size = New System.Drawing.Size(675, 297)
        Me.TabShort.TabIndex = 7
        Me.TabShort.Text = "残损溢短"
        Me.TabShort.UseVisualStyleBackColor = True
        '
        'C1DBGShort
        '
        Me.C1DBGShort.AllowFilter = False
        Me.C1DBGShort.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGShort.AllowUpdate = False
        Me.C1DBGShort.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGShort.Images.Add(CType(resources.GetObject("C1DBGShort.Images"), System.Drawing.Image))
        Me.C1DBGShort.Location = New System.Drawing.Point(3, 3)
        Me.C1DBGShort.Name = "C1DBGShort"
        Me.C1DBGShort.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGShort.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGShort.PreviewInfo.ZoomFactor = 75
        Me.C1DBGShort.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGShort.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGShort.Size = New System.Drawing.Size(669, 291)
        Me.C1DBGShort.TabIndex = 11
        Me.C1DBGShort.Text = "C1DBG"
        Me.C1DBGShort.PropBag = resources.GetString("C1DBGShort.PropBag")
        '
        'TabFee
        '
        Me.TabFee.Controls.Add(Me.C1DBG)
        Me.TabFee.Location = New System.Drawing.Point(4, 21)
        Me.TabFee.Name = "TabFee"
        Me.TabFee.Size = New System.Drawing.Size(675, 297)
        Me.TabFee.TabIndex = 8
        Me.TabFee.Text = "标准账单"
        Me.TabFee.UseVisualStyleBackColor = True
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("C1DBG.Images"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.PageSettings = CType(resources.GetObject("C1DBG.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBG.Size = New System.Drawing.Size(675, 297)
        Me.C1DBG.TabIndex = 1
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = resources.GetString("C1DBG.PropBag")
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Infozxg)
        Me.Panel2.Controls.Add(Me.Infops)
        Me.Panel2.Controls.Add(Me.Infosjds)
        Me.Panel2.Controls.Add(Me.Infohm)
        Me.Panel2.Controls.Add(Me.Infoqdds)
        Me.Panel2.Controls.Add(Me.Infosjjs)
        Me.Panel2.Controls.Add(Me.Infoqdjs)
        Me.Panel2.Location = New System.Drawing.Point(3, 112)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(556, 121)
        Me.Panel2.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(211, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 12)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "装卸港"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(47, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 12)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "票数"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(47, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 12)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "货名"
        Me.Label11.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(199, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 12)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "实际吨数"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 12)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "实际件数"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(199, 38)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 12)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "清单吨数"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 38)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 12)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "清单件数"
        '
        'Infozxg
        '
        Me.Infozxg.AutoSize = True
        Me.Infozxg.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infozxg.Location = New System.Drawing.Point(285, 15)
        Me.Infozxg.Name = "Infozxg"
        Me.Infozxg.Size = New System.Drawing.Size(41, 12)
        Me.Infozxg.TabIndex = 0
        Me.Infozxg.Text = "装卸港"
        '
        'Infops
        '
        Me.Infops.AutoSize = True
        Me.Infops.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infops.Location = New System.Drawing.Point(92, 15)
        Me.Infops.Name = "Infops"
        Me.Infops.Size = New System.Drawing.Size(29, 12)
        Me.Infops.TabIndex = 0
        Me.Infops.Text = "票数"
        '
        'Infosjds
        '
        Me.Infosjds.AutoSize = True
        Me.Infosjds.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infosjds.Location = New System.Drawing.Point(285, 64)
        Me.Infosjds.Name = "Infosjds"
        Me.Infosjds.Size = New System.Drawing.Size(53, 12)
        Me.Infosjds.TabIndex = 0
        Me.Infosjds.Text = "实际吨数"
        '
        'Infohm
        '
        Me.Infohm.AutoSize = True
        Me.Infohm.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infohm.Location = New System.Drawing.Point(92, 85)
        Me.Infohm.Name = "Infohm"
        Me.Infohm.Size = New System.Drawing.Size(29, 12)
        Me.Infohm.TabIndex = 0
        Me.Infohm.Text = "货名"
        Me.Infohm.Visible = False
        '
        'Infoqdds
        '
        Me.Infoqdds.AutoSize = True
        Me.Infoqdds.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infoqdds.Location = New System.Drawing.Point(285, 38)
        Me.Infoqdds.Name = "Infoqdds"
        Me.Infoqdds.Size = New System.Drawing.Size(53, 12)
        Me.Infoqdds.TabIndex = 0
        Me.Infoqdds.Text = "清单吨数"
        '
        'Infosjjs
        '
        Me.Infosjjs.AutoSize = True
        Me.Infosjjs.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infosjjs.Location = New System.Drawing.Point(92, 64)
        Me.Infosjjs.Name = "Infosjjs"
        Me.Infosjjs.Size = New System.Drawing.Size(53, 12)
        Me.Infosjjs.TabIndex = 0
        Me.Infosjjs.Text = "实际件数"
        '
        'Infoqdjs
        '
        Me.Infoqdjs.AutoSize = True
        Me.Infoqdjs.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infoqdjs.Location = New System.Drawing.Point(92, 38)
        Me.Infoqdjs.Name = "Infoqdjs"
        Me.Infoqdjs.Size = New System.Drawing.Size(53, 12)
        Me.Infoqdjs.TabIndex = 0
        Me.Infoqdjs.Text = "清单件数"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Infobw)
        Me.Panel3.Controls.Add(Me.Infojck)
        Me.Panel3.Controls.Add(Me.Infohc)
        Me.Panel3.Controls.Add(Me.Infoywgj)
        Me.Panel3.Controls.Add(Me.Infoywcm)
        Me.Panel3.Controls.Add(Me.Infocd)
        Me.Panel3.Controls.Add(Me.Infozwgj)
        Me.Panel3.Controls.Add(Me.Infozwcm)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Location = New System.Drawing.Point(3, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(556, 103)
        Me.Panel3.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(359, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 12)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "航次"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 12)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "进出口"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(223, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 12)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "泊位"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(199, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "英文国籍"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "英文船名"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(359, 30)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(29, 12)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "船代"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(199, 30)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 12)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "中文国籍"
        '
        'Infobw
        '
        Me.Infobw.AutoSize = True
        Me.Infobw.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infobw.Location = New System.Drawing.Point(285, 80)
        Me.Infobw.Name = "Infobw"
        Me.Infobw.Size = New System.Drawing.Size(29, 12)
        Me.Infobw.TabIndex = 0
        Me.Infobw.Text = "泊位"
        '
        'Infojck
        '
        Me.Infojck.AutoSize = True
        Me.Infojck.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infojck.Location = New System.Drawing.Point(92, 80)
        Me.Infojck.Name = "Infojck"
        Me.Infojck.Size = New System.Drawing.Size(41, 12)
        Me.Infojck.TabIndex = 0
        Me.Infojck.Text = "进出口"
        '
        'Infohc
        '
        Me.Infohc.AutoSize = True
        Me.Infohc.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infohc.Location = New System.Drawing.Point(405, 54)
        Me.Infohc.Name = "Infohc"
        Me.Infohc.Size = New System.Drawing.Size(29, 12)
        Me.Infohc.TabIndex = 0
        Me.Infohc.Text = "航次"
        '
        'Infoywgj
        '
        Me.Infoywgj.AutoSize = True
        Me.Infoywgj.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infoywgj.Location = New System.Drawing.Point(285, 54)
        Me.Infoywgj.Name = "Infoywgj"
        Me.Infoywgj.Size = New System.Drawing.Size(53, 12)
        Me.Infoywgj.TabIndex = 0
        Me.Infoywgj.Text = "英文国籍"
        '
        'Infoywcm
        '
        Me.Infoywcm.AutoSize = True
        Me.Infoywcm.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infoywcm.Location = New System.Drawing.Point(92, 54)
        Me.Infoywcm.Name = "Infoywcm"
        Me.Infoywcm.Size = New System.Drawing.Size(53, 12)
        Me.Infoywcm.TabIndex = 0
        Me.Infoywcm.Text = "英文船名"
        '
        'Infocd
        '
        Me.Infocd.AutoSize = True
        Me.Infocd.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infocd.Location = New System.Drawing.Point(405, 30)
        Me.Infocd.Name = "Infocd"
        Me.Infocd.Size = New System.Drawing.Size(29, 12)
        Me.Infocd.TabIndex = 0
        Me.Infocd.Text = "船代"
        '
        'Infozwgj
        '
        Me.Infozwgj.AutoSize = True
        Me.Infozwgj.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Infozwgj.Location = New System.Drawing.Point(285, 30)
        Me.Infozwgj.Name = "Infozwgj"
        Me.Infozwgj.Size = New System.Drawing.Size(53, 12)
        Me.Infozwgj.TabIndex = 0
        Me.Infozwgj.Text = "中文国籍"
        '
        'Infozwcm
        '
        Me.Infozwcm.Location = New System.Drawing.Point(0, 0)
        Me.Infozwcm.Name = "Infozwcm"
        Me.Infozwcm.Size = New System.Drawing.Size(100, 23)
        Me.Infozwcm.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(23, 30)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 12)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "中文船名"
        '
        'FrmCon_Verify
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(894, 449)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.GBV)
        Me.Menu = Me.MainMenu
        Me.Name = "FrmCon_Verify"
        Me.Text = "数据审核"
        Me.GBV.ResumeLayout(False)
        Me.GBV.PerformLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.TabTALLY_LIST.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.C1DBGTally_List, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabDaily.ResumeLayout(False)
        CType(Me.C1DBGDaily_report, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCertificate.ResumeLayout(False)
        CType(Me.C1DBGCertificate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabDailyDx.ResumeLayout(False)
        CType(Me.C1DBGDaily_report_dx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabShort.ResumeLayout(False)
        CType(Me.C1DBGShort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabFee.ResumeLayout(False)
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim dsShip As New DataSet   '船舶数据集
    Dim SqlStrShip As String    '船舶条件语句
    'Dim ds_sship As DataSet
    Dim FirmShip As String
    Dim SortShip As String
    Dim inoutstr As String

    Dim dsTally_List As New DataSet  '计数单
    Dim dsWait As New DataSet        '待时记录
    Dim dsWork_Record As New DataSet '现场记录
    Dim dsMeasure As New DataSet     '丈量单 
    Dim dsreport As New DataSet
    Dim dsfee As New DataSet

    Dim SqlStr As String  '条件语句
    Dim SelectStr As String
    Dim DynaStr As String '可变的条件设计
    Dim FirmStr As String '不变的条件设计
    ', FirmTally, FirmWait, FirmWorkRecord, FirmMeasure, FirmDaily
    Dim ColNum As Integer '不显示的列数
    Dim io As String '进出口

    Dim shipstatu As String
    Dim shiptrade As String

    Private Sub FrmCon_Verify_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Text = Me.Text & "_" & G_DeptName
        SortShip = "  Order by Ship_Statu,Dept_Code,id desc "
        FirmShip = "where DEPT_CODE LIKE '" & G_DeptCode & "%'"
        SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('0','3')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) "
        'SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) "
        Call myDataGridShip(SqlStrShip & inoutstr & SortShip)
        Me.C1DBGV.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        txtShipName.Text = G_ShipName
        txtVoyage.Text = G_Voyage
        'Call btResure_Click(sender, e)

        Panel1.Top = Panel1.Top + 30
        Panel1.Left = C1DBGTally_List.Width - Panel1.Width - 30
    End Sub

    Private Sub myDataGridShip(ByVal Sql As String) '**************航次信息
        Dim strsql As String
        Dim i As Integer
        strsql = "select SHIP_ID as ID,SHIP_STATU,INOUTPORT,DEPT_CODE,ENG_VESSEL,CHI_VESSEL,VOYAGE,InOutPort_Name,Dept_Short from View_SSHip " '船舶条件语句 不改部分
        strsql = strsql & Sql
        Try
            Me.C1DBGV.DataSource = Getdata(strsql, dsShip)
            For i = 0 To 4 '设计部显示的列
                Me.C1DBGV.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Call SetColumnCaptionShip()      '设计列标题
            Call SetColumnWidthShip()        '设计列宽度
            If dsShip.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumShip(5)     '设计合计列
            End If
            Me.C1DBGV.FetchRowStyles = True
            Me.C1DBGV.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaptionShip() '*****************航次标题
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
            Case 1
                SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('0','3')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) " '船舶可变的条件设计
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
                    SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('0','1','2','3','4')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) "
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
        Dim dsShip As New DataSet
        Dim strsql As String
        Dim dw As New DataView

        Panel1.Visible = False
        Ship_ID = CType(Me.C1DBGV.Columns.Item("ID").Text.ToString, Integer)
        strsql = "select * from View_SSHIP where SHIP_ID=" & Ship_ID
        dw = Getdata(strsql, dsShip)
        Label.Text = ""
        If dsShip.Tables(0).DefaultView.Count > 0 Then
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))) > 0 Then
                Label.Text = Label.Text & "中文船名:" & Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL")) & " "
                G_ShipName = Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))
                txtShipName.Text = Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL"))) > 0 Then
                Label.Text = Label.Text & "英文船名:" & Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL")) & " "
                G_ShipName_Eng = Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL"))
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))) > 0 Then
                Label.Text = Label.Text & "航次:" & Trim(dsShip.Tables(0).Rows(0).Item("Voyage")) & " "
                G_Voyage = Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))
                txtVoyage.Text = Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("InOutPort_Name"))) > 0 Then
                Label.Text = Label.Text & "进出口:" & Trim(dsShip.Tables(0).Rows(0).Item("InOutPort_Name")) & " "
                If dsShip.Tables(0).Rows(0).Item("InOutPort_Name") = "进口" Then
                    io = "0"
                    Hatch_in = 0
                Else
                    io = "1"
                    Hatch_in = 1
                End If
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Trade"))) > 0 Then
                Label.Text = Label.Text & "内外贸:" & Trim(dsShip.Tables(0).Rows(0).Item("Trade")) & " "
                shiptrade = Trim(dsShip.Tables(0).Rows(0).Item("Trade"))
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
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("File_No"))) > 0 Then
                Label.Text = Label.Text & "档案号:" & Trim(dsShip.Tables(0).Rows(0).Item("File_No")) & " "
            End If
            shipstatu = dsShip.Tables(0).Rows(0).Item("ship_statu")
        End If
        FirmStr = "  Ship_ID=" & Ship_ID & " Order by ID " '设计初始条件  在检索后不改变的条件  '***************要修改 或 2>1
        DynaStr = " 2>1 " '设计其它初始条件    在检索后不需要的条件 ***************要修改 或 其它条件
        SelectStr = " " ' " Top 20 "
        SqlStr = " (" & DynaStr & ")  " & " and " & FirmStr
        Dim dsinoutport As New DataSet
        Dim dwinoutport As New DataView
        dwinoutport = Getdata("select inoutport from sship where ship_id='" & Ship_ID & "'", dsinoutport)
        If dsinoutport.Tables(0).Rows.Count > 0 Then
            Hatch_in = dsinoutport.Tables(0).Rows(0).Item("inoutport")
        End If
        Me.ToolBar.Enabled = True
        Me.mnuAdd.Enabled = True
        Me.mnuDelete.Enabled = True
        Me.mnuEdit.Enabled = True
        Me.mnuExport.Enabled = True
        Me.mnuFind.Enabled = True
        Me.mnuPrint.Enabled = True
        Me.mnuQuery.Enabled = True
        Call preview("WL4_1") '*****************权限设计 '*************要修改模块号

        'Call TabControl1_Click(sender, e)
        Call getlhjl()
        Call getTallylist(FirmStr)    '理箱单
        dsdaily.Reset()               '日报
        dsdailydx.Reset()             '捣箱日报
        OKMARK = "0"
        OKMARKdx = "0"
        LabREMARKS.Text = ""
        REMARKS = ""
        REMARKSdx = ""
        trade = ""

        ds_sship.Reset()
        Getdata("select * from view_outhatch_sship where ship_id='" & Ship_ID & "'", ds_sship)

        'If ds_sship.Tables(0).Rows.Count > 0 Then
        '    trade = ds_sship.Tables(0).Rows(0).Item("s_trade")
        '    If trade = "1" Then
        '        dw = Getdata("exec spcon_certificate '" & Ship_ID & "'", DS_DO)
        '    ElseIf trade = "2" Then
        '        dw = Getdata("exec spcon_certificate_eng '" & Ship_ID & "'", DS_DO)
        '    End If
        'End If
        dw = Getdata(" exec spcon_certificate_eng '" & Ship_ID & "'", DS_DO)  '理货凭证
        getCertificate()
        Dim str_sql As String
        str_sql = String.Format("exec SPCON_DAILY_REPORT_query {0}", Ship_ID)
        ExecSql(str_sql)
        getDaily_Report()
        getDaily_Report_dx()
        getshort()
        getfee()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub getlhjl()
        On Error GoTo Err
        clearinfo()
        Dim dsinfoverify As New DataSet
        Getdata("infoverify " & Ship_ID, dsinfoverify)
        Label49.Text = Trim(dsinfoverify.Tables(1).Rows(0).Item("zwcm"))
        Label46.Text = Trim(dsinfoverify.Tables(1).Rows(0).Item("ywcm"))
        Label43.Text = Trim(dsinfoverify.Tables(1).Rows(0).Item("jck"))
        Label48.Text = Trim(dsinfoverify.Tables(1).Rows(0).Item("zwgj"))
        Label45.Text = Trim(dsinfoverify.Tables(1).Rows(0).Item("ywgj"))
        Label42.Text = Trim(dsinfoverify.Tables(1).Rows(0).Item("bw"))
        Label47.Text = Trim(dsinfoverify.Tables(1).Rows(0).Item("cd"))
        Label44.Text = Trim(dsinfoverify.Tables(1).Rows(0).Item("hc"))
        Label52.Text = Trim(dsinfoverify.Tables(1).Rows(0).Item("ps"))
        Label34.Text = Trim(dsinfoverify.Tables(0).Rows(0).Item("qdjs"))
        Label32.Text = Trim(dsinfoverify.Tables(0).Rows(0).Item("qdds"))
        Label33.Text = Trim(dsinfoverify.Tables(0).Rows(0).Item("sjjs"))
        Label30.Text = Trim(dsinfoverify.Tables(0).Rows(0).Item("sjds"))
        Label28.Text = IIf(Len(Trim(dsinfoverify.Tables(1).Rows(0).Item("zxg"))) > 0, Trim(dsinfoverify.Tables(1).Rows(0).Item("zxg")), "")
        Infokgsj.Text = dsinfoverify.Tables(1).Rows(0).Item("worktime_begin")
        Infowgsj.Text = dsinfoverify.Tables(1).Rows(0).Item("worktime_end")
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub clearinfo()
        Label49.Text = ""
        Label46.Text = ""
        Label43.Text = ""
        Label48.Text = ""
        Label45.Text = ""
        Label42.Text = ""
        Label47.Text = ""
        Label44.Text = ""
        Label52.Text = ""
        Label34.Text = ""
        Label32.Text = ""
        Label33.Text = ""
        Label30.Text = ""
        Label28.Text = ""
        Infokgsj.Text = ""
        Infowgsj.Text = ""
    End Sub

    Private Sub getTallylist(ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            '不显示的列名在最前面
            strsql = "select  *  from VIEW_CON_TALLY_LIST  where " & Sql '******要修改

            Me.C1DBGTally_List.DataSource = Getdata(strsql, dsTally_List)  ' class dbcontrol getdata fuction
            ColNum = 2 '不显示的列数 '******要修改
            Table_Name = "VIEW_CON_TALLY_LIST" '操作的数据库表名 ''******要修改

            For i = 0 To ColNum - 1 '设计部显示的列
                Me.C1DBGTally_List.Splits(0).DisplayColumns.Item(i).Visible = False
            Next

            'For i = ColNum - 1 To C1DBGTally_List.Columns.Count - 1
            '    Me.C1DBGTally_List.Columns(i).FilterDropdown = True
            'Next
            Me.C1DBGTally_List.Columns("team_no").FilterDropdown = True
            Me.C1DBGTally_List.Columns.Item("date").NumberFormat = "yyyy/MM/dd"

            Call SetColumnCaptionTally_List() '设计列标题
            Call SetColumnWidthTally_list() '设计列宽度
            If dsTally_List.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumTally_List(Sql) '设计合计列
            End If
            ' Me.C1DBG.FetchRowStyles = True
            Me.C1DBGTally_List.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getCertificate()
        Dim strsql As String
        Dim i As Integer
        Try
            C1DBGCertificate.Visible = True
            C1DBGCertificate.DataSource = DS_DO.Tables(5).DefaultView
            C1DBGCertificate.Refresh()
            Me.C1DBGCertificate.Columns.Item("name").Caption = "名称"
            Me.C1DBGCertificate.Columns.Item("amount").Caption = "理箱数量"
            Me.C1DBGCertificate.Columns.Item("jjr").Caption = "节假日"
            Me.C1DBGCertificate.Columns.Item("yb").Caption = "夜班"
            Call SetColumnWidthCertificate()
            Me.C1DBGCertificate.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getDaily_Report()
        Dim strsql As String
        Dim i As Integer
        Try
            strsql = "select * from CON_DAILY_REPORT where ship_id=" & Ship_ID & " and mark=0 "
            Getdata(strsql, dsdaily)
            Me.C1DBGDaily_report.DataSource = dsdaily.Tables(0).DefaultView
            LabREMARKS.Text = REMARKS & "    " & GL_Teu
            For i = 0 To 1
                Me.C1DBGDaily_report.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Me.C1DBGDaily_report.Splits(0).DisplayColumns.Item(17).Visible = False
            Me.C1DBGDaily_report.Columns.Item(2).Caption = "项目"
            Me.C1DBGDaily_report.Columns.Item(3).Caption = "20重数"
            Me.C1DBGDaily_report.Columns.Item(4).Caption = "20重吨"
            Me.C1DBGDaily_report.Columns.Item(5).Caption = "40重数"
            Me.C1DBGDaily_report.Columns.Item(6).Caption = "40重吨"
            Me.C1DBGDaily_report.Columns.Item(7).Caption = "其它重数"
            Me.C1DBGDaily_report.Columns.Item(8).Caption = "其它重吨"
            Me.C1DBGDaily_report.Columns.Item(9).Caption = "20空数"
            Me.C1DBGDaily_report.Columns.Item(10).Caption = "20空吨"
            Me.C1DBGDaily_report.Columns.Item(11).Caption = "40空数"
            Me.C1DBGDaily_report.Columns.Item(12).Caption = "40空吨"
            Me.C1DBGDaily_report.Columns.Item(13).Caption = "其它空数"
            Me.C1DBGDaily_report.Columns.Item(14).Caption = "其它空吨"
            Me.C1DBGDaily_report.Columns.Item(15).Caption = "小计数"
            Me.C1DBGDaily_report.Columns.Item(16).Caption = "小计吨"

            Call SetColumnWidthDaily_Report()
            Me.C1DBGDaily_report.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
  
    Private Sub getshort()
        Dim strsql As String
        Dim i As Integer
        Dim dsshort As New DataSet
        Try
            strsql = "select  *  from VIEWCON_SHORT where " & FirmStr
            Me.C1DBGShort.DataSource = Getdata(strsql, dsshort)
            ColNum = 2
            Table_Name = "VIEWCON_SHORT"
            For i = 0 To ColNum - 1
                Me.C1DBGShort.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Call SetColumnCaption() '设计列标题

            Me.C1DBGShort.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getfee()
        Dim strsql As String
        Dim i As Integer
        Try 
            strsql = "select id,ACCOUNT_DETAIL_ID,SHIP_ID,Clear,BILL_ID,Fee_Code,NO,Tally_items_CHA,FEE_AMOUNT,UNIT_cha,cast(FEE_RATE as numeric(10,2)) as fee_rate,cast(MONEY as numeric(10,2)) as money,Descri,Account_Type,SHIPAGENT_CHA,Clear_Name from VIEW_Bill_List_New_standard where Dept_code = '" & G_DeptCode & "' and Ship_ID=" & Ship_ID & " Order by ID desc,Fee_Code" '******要修改
            Me.C1DBG.DataSource = Getdata(strsql, dsfee)  ' class dbcontrol getdata fuction
            ColNum = 6 '不显示的列数 '******要修改
            Table_Name = "VIEW_Bill_List_New" '操作的数据库表名 ''******要修改

            For i = 0 To ColNum - 1 '设计不显示的列
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Call SetColumnCaption_fee() '设计列标题
            Call SetColumnWidth_fee() '设计列宽度
            If dsfee.Tables(0).Rows.Count > 0 Then
                Call SetColumnSum_fee() '设计合计列
            End If
            C1DBG.FetchRowStyles = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaption_fee()
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
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

    Private Sub SetColumnWidth_fee()
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

    Private Sub SetColumnSum_fee()
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
        Me.C1DBG.Columns.Item(ColNum).FooterText = "合计 共" & dsfee.Tables(0).Rows.Count & "条"

        Do While i < Me.C1DBG.Columns.Count
            j = 0
            For j = 0 To dset.Tables(0).Rows.Count - 1

                If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBG.Columns.Item(i).DataField.ToString)) _
                    And Upper(Trim(dset.Tables(0).Rows(j)("Field_Type"))) = "N" And Trim(dset.Tables(0).Rows(j)("IsOrNoSum")) = "1" Then

                    num = 0
                    For m = 0 To dsfee.Tables(0).Rows.Count - 1
                        num = num + dsfee.Tables(0).Rows(m)(i)
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
 
    Private Sub getDaily_Report_dx()
        Dim strsql As String
        Dim i As Integer
        Try
            strsql = "select * from CON_DAILY_REPORT where ship_id=" & Ship_ID & " and mark<>0 "
            Getdata(strsql, dsdailydx)
            Me.C1DBGDaily_report_dx.DataSource = dsdailydx.Tables(0).DefaultView
            LabREMARKS.Text = REMARKSdx & "    " & GL_Teudx
            For i = 0 To 1
                Me.C1DBGDaily_report_dx.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Me.C1DBGDaily_report_dx.Splits(0).DisplayColumns.Item(17).Visible = False
            Me.C1DBGDaily_report_dx.Columns.Item(2).Caption = "项目"
            Me.C1DBGDaily_report_dx.Columns.Item(3).Caption = "20重数"
            Me.C1DBGDaily_report_dx.Columns.Item(4).Caption = "20重吨"
            Me.C1DBGDaily_report_dx.Columns.Item(5).Caption = "40重数"
            Me.C1DBGDaily_report_dx.Columns.Item(6).Caption = "40重吨"
            Me.C1DBGDaily_report_dx.Columns.Item(7).Caption = "其它重数"
            Me.C1DBGDaily_report_dx.Columns.Item(8).Caption = "其它重吨"
            Me.C1DBGDaily_report_dx.Columns.Item(9).Caption = "20空数"
            Me.C1DBGDaily_report_dx.Columns.Item(10).Caption = "20空吨"
            Me.C1DBGDaily_report_dx.Columns.Item(11).Caption = "40空数"
            Me.C1DBGDaily_report_dx.Columns.Item(12).Caption = "40空吨"
            Me.C1DBGDaily_report_dx.Columns.Item(13).Caption = "其它空数"
            Me.C1DBGDaily_report_dx.Columns.Item(14).Caption = "其它空吨"
            Me.C1DBGDaily_report_dx.Columns.Item(15).Caption = "小计数"
            Me.C1DBGDaily_report_dx.Columns.Item(16).Caption = "小计吨"

            Call SetColumnWidthDaily_Reportdx()
            Me.C1DBGDaily_report_dx.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaptionTally_List()
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
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

            Do While i < Me.C1DBGTally_List.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGTally_List.Columns.Item(i).DataField.ToString)) Then
                        Me.C1DBGTally_List.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
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

    Private Sub SetColumnWidthTally_list()
        Dim j As Integer
        For j = 0 To Me.C1DBGTally_List.Columns.Count - 1
            Me.C1DBGTally_List.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.C1DBGTally_List.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.C1DBGTally_List.Splits(0).DisplayColumns.Item(j).Width < 30 Then
                Me.C1DBGTally_List.Splits(0).DisplayColumns.Item(j).Width = 30
            Else
                If Me.C1DBGTally_List.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.C1DBGTally_List.Splits(0).DisplayColumns.Item(j).Width = 120
                End If
            End If
        Next
    End Sub

    Private Sub SetColumnWidthDaily_Report()
        Dim j As Integer
        For j = 0 To Me.C1DBGDaily_report.Columns.Count - 1
            Me.C1DBGDaily_report.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.C1DBGDaily_report.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.C1DBGDaily_report.Splits(0).DisplayColumns.Item(j).Width < 40 Then
                Me.C1DBGDaily_report.Splits(0).DisplayColumns.Item(j).Width = 40
            Else
                If Me.C1DBGDaily_report.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.C1DBGDaily_report.Splits(0).DisplayColumns.Item(j).Width = 120
                End If
            End If
        Next
    End Sub

    Private Sub SetColumnWidthDaily_Reportdx()
        Dim j As Integer
        For j = 0 To Me.C1DBGDaily_report_dx.Columns.Count - 1
            Me.C1DBGDaily_report_dx.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.C1DBGDaily_report_dx.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.C1DBGDaily_report_dx.Splits(0).DisplayColumns.Item(j).Width < 40 Then
                Me.C1DBGDaily_report_dx.Splits(0).DisplayColumns.Item(j).Width = 40
            Else
                If Me.C1DBGDaily_report_dx.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.C1DBGDaily_report_dx.Splits(0).DisplayColumns.Item(j).Width = 120
                End If
            End If
        Next
    End Sub

    Private Sub SetColumnWidthCertificate()
        Dim j As Integer
        For j = 0 To Me.C1DBGCertificate.Columns.Count - 1
            Me.C1DBGCertificate.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.C1DBGCertificate.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.C1DBGCertificate.Splits(0).DisplayColumns.Item(j).Width < 40 Then
                Me.C1DBGCertificate.Splits(0).DisplayColumns.Item(j).Width = 40
            Else
                If Me.C1DBGCertificate.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.C1DBGCertificate.Splits(0).DisplayColumns.Item(j).Width = 120
                End If
            End If

        Next
    End Sub

    Private Sub SetColumnSumTally_List(ByVal sql As String)
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
        Me.C1DBGTally_List.ColumnFooters = True
        Me.C1DBGTally_List.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGTally_List.Columns.Item(ColNum).FooterText = "合计 "
        Me.C1DBGTally_List.Columns.Item(ColNum + 1).FooterText = "共 " & dsTally_List.Tables(0).Rows.Count & "条"
        Do While i < Me.C1DBGTally_List.Columns.Count
            j = 0
            For j = 0 To dset.Tables(0).Rows.Count - 1

                If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGTally_List.Columns.Item(i).DataField.ToString)) And Upper(Trim(dset.Tables(0).Rows(j)("Field_Type"))) = "N" And Trim(dset.Tables(0).Rows(j)("IsOrNoSum")) = "1" Then

                    num = 0
                    For m = 0 To dsTally_List.Tables(0).Rows.Count - 1
                        num = num + dsTally_List.Tables(0).Rows(m)(i)
                    Next
                    Me.C1DBGTally_List.Columns.Item(i).FooterText = CType(num, String)
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

    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
        Me.Close()
    End Sub

    Private Sub ToolBar_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar.ButtonClick
        Select Case Me.ToolBar.Buttons.IndexOf(e.Button)
            Case 0
                Try
                    If G_User_Serial = "WLGCH" Then
                        Dim frm As New FrmConPayer
                        frm.ShowDialog()
                        getfee()
                        Return
                    End If
                    If shipstatu = 0 Then
                        Dim frm As New FrmConPayer
                        frm.ShowDialog()
                        getfee()
                    Else
                        Dim frm As New FrmConPayer2
                        frm.ShowDialog()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case 1
                Call mnuFind_Click(sender, e)
            Case 2
                sshipverify_rollbak(sender, e)
            Case 3 
                Me.Close()
        End Select
    End Sub

    Private Sub mnuFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFind.Click
        Try
            If shipstatu <> 0 Then
                MsgBox("只能处理待审核航次！", MsgBoxStyle.OkOnly, "提示")
                Return
            End If
            Dim str_sql2 As String
            Dim dsship2 As New DataSet()
            str_sql2 = String.Format(" select ship_statu from tally_verify..sship where ship_id={0}", Ship_ID)
            Getdata(str_sql2, dsship2)
            If dsship2.Tables(0).Rows.Count > 0 Then
                MsgBox("本航次数据已审核完毕！", MsgBoxStyle.OkOnly, "提示")
                Return
            End If
            If MsgBox("确认通过本航次数据审核？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                '增加审核记录
                Dim str_sql As String
                str_sql = String.Format("insert into tally..SSHIP_verify select SHIP_ID, V_ID, ENG_VESSEL, CHI_VESSEL, VOYAGE, INOUTPORT,'{0}',getdate(),'初审2','{2}' from sship where ship_id={1}", G_User, Ship_ID, G_DeptCode)
                ExecSql(str_sql)
                str_sql = String.Format("sshipverify {0},'{1}','{2}'", Ship_ID, G_DeptCode, G_User)
                ExecSql(str_sql)

                str_sql = String.Format("sp_fee_standard  {0},'{1}','{2}'", Ship_ID, G_DeptCode, G_User)
                '生成标准账单 
                ExecSql(str_sql)
                '生成审核数据库的标准账单 
                ExecSql_ver(str_sql)
                Call btResure_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub sshipverify_rollbak(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If shipstatu <> 3 Then
                MsgBox("只能处理审核完的航次！", MsgBoxStyle.OkOnly, "提示")
                Return
            End If
            Dim str_sql2 As String
            Dim dsship2 As New DataSet()
            str_sql2 = String.Format(" select ship_statu from tally_verify..sship where ship_id={0}", Ship_ID)
            Getdata(str_sql2, dsship2)
            If dsship2.Tables(0).Rows.Count = 0 Then
                MsgBox("本航次数据未审核！", MsgBoxStyle.OkOnly, "提示")
                Return
            ElseIf dsship2.Tables(0).Rows(0)(0) = 4 Then
                MsgBox("该航次已复审完，无法撤销审核！", MsgBoxStyle.OkOnly, "提示")
                Return
            End If

            If MsgBox("确认删除本航次数据审核信息？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                '增加审核记录
                Dim str_sql As String
                str_sql = String.Format("insert into tally..SSHIP_verify select SHIP_ID, V_ID, ENG_VESSEL, CHI_VESSEL, VOYAGE, INOUTPORT,'{0}',getdate(),'撤销初审2','{2}' from sship where ship_id={1}", G_User, Ship_ID, G_DeptCode)
                ExecSql(str_sql)
                str_sql = String.Format("exec tally_verify..sshipverify_rollbak {0},'{1}','{2}'", Ship_ID, G_DeptCode, G_User)
                ExecSql(str_sql)
                Call btResure_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                If dsTally_List.Tables(0).Rows.Count > 0 Then
                    Dim FrmDelete As New FRMCON_TALLY_LIST_DELETE  '***********要修改
                    ID = CType(Me.C1DBGTally_List.Columns.Item("ID").Text.ToString, Integer)
                    FrmDelete.ShowDialog()
                    Try
                        Call getTallylist(SqlStr)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
        End Select
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        Try
            If shipstatu <> 3 Then
                MsgBox("请先执行数据审核！", MsgBoxStyle.OkOnly, "提示")
                Return
            End If
            If MsgBox("你确认要将本航次完船吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                ExecSql("update sship set ship_statu='4' where ship_id=" & Ship_ID)
                Call btResure_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub mnuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdd.Click
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                Dim FrmAdd As New FRMCON_TALLY_LIST_ADD   '***********要修改
                If dsTally_List.Tables(0).Rows.Count > 0 Then
                    ID = CType(Me.C1DBGTally_List.Columns.Item("ID").Text.ToString, Integer)
                Else
                    ID = -1
                End If
                FrmAdd.ShowDialog()
                Try
                    Call getTallylist(SqlStr)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
        End Select
    End Sub

    Private Sub C1DBGTALLY_LIST_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1DBGTally_List.DoubleClick
        Call mnuQuery_Click(sender, e)
    End Sub

    Private Sub C1DBGWAIT_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1DBGCertificate.DoubleClick
        Call mnuQuery_Click(sender, e)
    End Sub

    Private Sub C1DBGTALLY_LIST_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C1DBGTally_List.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.C1DBGTally_List.Col = Me.C1DBGTally_List.Columns.Count - 1 And Me.C1DBGTally_List.Row < dsTally_List.Tables(0).Rows.Count - 1 Then
                Me.C1DBGTally_List.Row = Me.C1DBGTally_List.Row + 1
                Me.C1DBGTally_List.Col = ColNum
            End If
        End If
    End Sub

    Private Sub mnuQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuery.Click
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                If dsTally_List.Tables(0).Rows.Count > 0 Then
                    Dim FrmQuery As New FRMCON_TALLY_LIST_QUERY  '***********要修改
                    ID = CType(Me.C1DBGTally_List.Columns.Item("ID").Text.ToString, Integer)
                    FrmQuery.ShowDialog()
                End If
        End Select
    End Sub

    Private Sub mnuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrint.Click
        GL_Print = 1
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                If dsTally_List.Tables(0).Rows.Count > 0 Then
                    Call PrintExcelTally_List()
                End If
            Case 1
                If dsdaily.Tables(0).Rows.Count > 0 Then
                    Call Daily_Report_eng_new()
                End If
            Case 2
                If DS_DO.Tables(0).Rows.Count > 0 Then
                    Call eng_new()
                End If
            Case 3
                If dsdailydx.Tables(0).Rows.Count > 0 Then
                    Call Daily_Report_eng_dx_new()
                End If
        End Select
    End Sub

    Private Sub mnuExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExport.Click
        GL_Print = 0
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                If dsTally_List.Tables(0).Rows.Count > 0 Then
                    Call PrintExcelTally_List()
                End If
            Case 1
                If dsdaily.Tables(0).Rows.Count > 0 Then
                    Call Daily_Report_eng_new()
                End If
            Case 2
                If DS_DO.Tables(0).Rows.Count > 0 Then
                    Call eng_new()
                End If
            Case 3
                If dsdailydx.Tables(0).Rows.Count > 0 Then
                    Call Daily_Report_eng_dx_new()
                End If
        End Select
        'Call ExportExcel()
    End Sub

    Private Sub ExportExcel() '导出Excel        
        Call MakeExcelTally_List()
    End Sub

    Private Sub PrintExcelTally_List() '打印到Excel        
        Dim frm As New FRMCON_TALLY_LIST_PRINT
        frm.ShowDialog()
    End Sub

    Private Sub PrintExcelCertificate() '打印到Excel        
        Try
            Call eng_new()
            'If trade = "1" Then
            '    Call china()
            'ElseIf trade = "2" Then
            '    Call eng()
            'End If
        Catch
            xlApp.Quit()
            SendKeys.Send("n")
            KillExcelProcess()
        End Try
    End Sub

    Private Sub PrintExcelDaily_report() '打印到Excel        
        Try
            Call Daily_Report_eng_new()

            'If trade = "1" Then
            '    Call Daily_Report_china()
            'ElseIf trade = "2" Then
            '    Call Daily_Report_eng()
            'End If
        Catch
            xlApp.Quit()
            SendKeys.Send("n")
            KillExcelProcess()
        End Try
    End Sub

    '打印理货业务凭证
    Private Sub eng_new()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim remarks As String
        Dim t, col, row, dx, plan As Integer
        Try
            dx = 0
            plan = 0
            If DS_DO.Tables(3).Rows(0)(0) > 0 Then
                If MsgBox("是否导出捣箱信息？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                    dx = 1
                End If
            End If
            If DS_DO.Tables(4).Rows(0)(0) > 0 Then
                If MsgBox("是否导出实际理货数据？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                    plan = 1
                End If
            End If
            RecordExcelProcess()
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "Report_gonglei.xls", pathstr + "Report.xls")
            Filepath = pathstr + "report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("理货业务凭证"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            If GL_Print = 1 Then
                xlsheet.Application.Visible = False
            Else
                xlsheet.Application.Visible = True
            End If
            xlsheet.Select()

            'If io = "0" Then
            '    xlsheet.Cells(10, 1) = "Inward"
            'Else
            '    xlsheet.Cells(10, 1) = "Outward"
            'End If
            xlsheet.Cells(11, 5) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
            xlsheet.Cells(11, 9) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            xlsheet.Cells(11, 13) = "'" & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
            xlsheet.Cells(8, 14) = "ONLY"

            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) Then
                xlsheet.Cells(12, 7) = "'" & Now().Day.ToString().PadLeft(2, "0") & "-" & Now().Month.ToString().PadLeft(2, "0") & "-" & Now().Year.ToString()
            Else
                xlsheet.Cells(12, 7) = "'" & System.Convert.ToString(Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))).PadLeft(2, "0") & "-" & System.Convert.ToString(Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))).PadLeft(2, "0") & "-" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
            End If
            'xlsheet.Cells(12, 12) = "'" & System.Convert.ToString(Day(Now)).PadLeft(2, "0") & "-" & System.Convert.ToString(Month(Now)).PadLeft(2, "0") & "-" & Year(Now)
            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_end")) Then
                xlsheet.Cells(12, 12) = "'" & Now().Day.ToString().PadLeft(2, "0") & "-" & Now().Month.ToString().PadLeft(2, "0") & "-" & Now().Year.ToString()
            Else
                xlsheet.Cells(12, 12) = "'" & System.Convert.ToString(Day(ds_sship.Tables(0).Rows(0).Item("worktime_end"))).PadLeft(2, "0") & "-" & System.Convert.ToString(Month(ds_sship.Tables(0).Rows(0).Item("worktime_end"))).PadLeft(2, "0") & "-" & Year(ds_sship.Tables(0).Rows(0).Item("worktime_end"))
            End If

            If plan = 1 Then
                If DS_DO.Tables(0).Rows(0)(0) > 0 Then
                    xlsheet.Cells(20, 7) = DS_DO.Tables(0).Rows(0)(0)
                    xlsheet.Cells(20, 8) = "VAN"
                End If
                If DS_DO.Tables(0).Rows(0)(1) > 0 Then
                    xlsheet.Cells(21, 7) = DS_DO.Tables(0).Rows(0)(1)
                    xlsheet.Cells(21, 8) = "VAN"
                End If
                If DS_DO.Tables(0).Rows(0)(2) > 0 Then
                    xlsheet.Cells(22, 7) = DS_DO.Tables(0).Rows(0)(2)
                    xlsheet.Cells(22, 8) = "VAN"
                End If
                If DS_DO.Tables(0).Rows(0)(3) > 0 Then
                    xlsheet.Cells(23, 7) = DS_DO.Tables(0).Rows(0)(3)
                    xlsheet.Cells(23, 8) = "VAN"
                End If
                If DS_DO.Tables(0).Rows(0)(4) > 0 Then
                    xlsheet.Cells(24, 7) = DS_DO.Tables(0).Rows(0)(4)
                    xlsheet.Cells(24, 8) = "VAN"
                End If
                If DS_DO.Tables(0).Rows(0)(5) > 0 Then
                    xlsheet.Cells(25, 7) = DS_DO.Tables(0).Rows(0)(5)
                    xlsheet.Cells(25, 8) = "VAN"
                End If
            Else
                If DS_DO.Tables(4).Rows(0)(0) > 0 Then
                    xlsheet.Cells(20, 7) = DS_DO.Tables(4).Rows(0)(0)
                    xlsheet.Cells(20, 8) = "VAN"
                End If
                If DS_DO.Tables(4).Rows(0)(1) > 0 Then
                    xlsheet.Cells(21, 7) = DS_DO.Tables(4).Rows(0)(1)
                    xlsheet.Cells(21, 8) = "VAN"
                End If
                If DS_DO.Tables(4).Rows(0)(2) > 0 Then
                    xlsheet.Cells(22, 7) = DS_DO.Tables(4).Rows(0)(2)
                    xlsheet.Cells(22, 8) = "VAN"
                End If
                If DS_DO.Tables(4).Rows(0)(3) > 0 Then
                    xlsheet.Cells(23, 7) = DS_DO.Tables(4).Rows(0)(3)
                    xlsheet.Cells(23, 8) = "VAN"
                End If
                If DS_DO.Tables(4).Rows(0)(4) > 0 Then
                    xlsheet.Cells(24, 7) = DS_DO.Tables(4).Rows(0)(4)
                    xlsheet.Cells(24, 8) = "VAN"
                End If
                If DS_DO.Tables(4).Rows(0)(5) > 0 Then
                    xlsheet.Cells(25, 7) = DS_DO.Tables(4).Rows(0)(5)
                    xlsheet.Cells(25, 8) = "VAN"
                End If
            End If

            For t = 0 To 5
                remarks = ""
                If DS_DO.Tables(1).Rows(0)(t) > 0 Then
                    remarks = remarks & DS_DO.Tables(1).Rows(0)(t) & " CONTS tallied on SAT/SUN/HOLDY"
                End If
                If DS_DO.Tables(1).Rows(0)(t + 6) > 0 Then
                    remarks = remarks & "   " & DS_DO.Tables(1).Rows(0)(t + 6) & " CONTS tallied at night shift"
                End If
                If remarks.Length > 0 Then
                    xlsheet.Cells(20 + t, 9) = remarks
                End If
            Next t

            If DS_DO.Tables(2).Rows(0)(0) > 0 Then
                xlsheet.Cells(32, 7) = DS_DO.Tables(2).Rows(0)(0)
            End If

            'If DS_DO.Tables(3).Rows(0)(0) > 0 Then
            '    If MsgBox("是否导出捣箱信息？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
            '        xlsheet.Cells(33, 3) = "Shiftting with in/outside the hold"
            '        xlsheet.Cells(33, 7) = DS_DO.Tables(3).Rows(0)(0)
            '        xlsheet.Cells(33, 8) = "VAN"
            '        xlsheet.Cells(33, 9) = DS_DO.Tables(3).Rows(0)(1)
            '    End If
            'End If
            If dx = 1 Then
                'xlsheet.Cells(33, 3) = "Shiftting with in/outside the hold"
                If io = "0" Then
                    xlsheet.Cells(33, 3) = "The Shiftting"
                Else
                    xlsheet.Cells(33, 3) = "Reload"
                End If
                xlsheet.Cells(33, 7) = DS_DO.Tables(3).Rows(0)(0)
                xlsheet.Cells(33, 8) = "VAN"
                xlsheet.Cells(33, 9) = DS_DO.Tables(3).Rows(0)(1)
            End If

            If GL_Print = 1 Then
                'xlsheet.PrintPreview()
                xlsheet.PrintOut()
                KillExcelProcess()
                GL_Print = 0
            End If
        Catch
            xlapp.Quit()
            SendKeys.Send("n")
            KillExcelProcess()
        End Try
    End Sub

    '打印日报
    Private Sub Daily_Report_eng_new()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer
        Try
            RecordExcelProcess()
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "Report_gonglei.xls", pathstr + "Report.xls")
            Filepath = pathstr + "report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("集装箱日报"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            If GL_Print = 1 Then
                xlsheet.Application.Visible = False
            Else
                xlsheet.Application.Visible = True
            End If
            xlsheet.Select()

            'If io = "0" Then
            '    xlsheet.Cells(9, 1) = "Inward"
            'Else
            '    xlsheet.Cells(9, 1) = "Outward"
            'End If
            xlsheet.Cells(10, 2) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
            xlsheet.Cells(10, 5) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            xlsheet.Cells(10, 7) = "'NO." & dsdaily.Tables(1).Rows(0).Item("berth")
            xlsheet.Cells(10, 10) = "'" & dsdaily.Tables(2).Rows(0).Item("hourfrom") & ":" & dsdaily.Tables(2).Rows(0).Item("minfrom")
            xlsheet.Cells(10, 12) = "'" & dsdaily.Tables(3).Rows(0).Item("hourto") & ":" & dsdaily.Tables(3).Rows(0).Item("minto")

            'If Year(dsdaily.Tables(2).Rows(0).Item("timefrom")) = Year(dsdaily.Tables(3).Rows(0).Item("timeto")) And Month(dsdaily.Tables(2).Rows(0).Item("timefrom")) = Month(dsdaily.Tables(3).Rows(0).Item("timeto")) And Day(dsdaily.Tables(2).Rows(0).Item("timefrom")) = Day(dsdaily.Tables(3).Rows(0).Item("timeto")) Then
            '    xlsheet.Cells(10, 14) = dsdaily.Tables(2).Rows(0).Item("dayfrom") & "-" & dsdaily.Tables(2).Rows(0).Item("monthfrom") & "-" & Year(dsdaily.Tables(2).Rows(0).Item("timefrom"))
            'ElseIf Year(dsdaily.Tables(2).Rows(0).Item("timefrom")) = Year(dsdaily.Tables(3).Rows(0).Item("timeto")) And Month(dsdaily.Tables(2).Rows(0).Item("timefrom")) = Month(dsdaily.Tables(3).Rows(0).Item("timeto")) And Day(dsdaily.Tables(2).Rows(0).Item("timefrom")) <> Day(dsdaily.Tables(3).Rows(0).Item("timeto")) Then
            '    xlsheet.Cells(10, 14) = dsdaily.Tables(2).Rows(0).Item("dayfrom") & "/" & dsdaily.Tables(3).Rows(0).Item("dayto") & "-" & dsdaily.Tables(2).Rows(0).Item("monthfrom") & "-" & Year(dsdaily.Tables(2).Rows(0).Item("timefrom"))
            'Else
            '    xlsheet.Cells(10, 14) = dsdaily.Tables(2).Rows(0).Item("dayfrom") & "/" & dsdaily.Tables(3).Rows(0).Item("dayto") & "-" & dsdaily.Tables(2).Rows(0).Item("monthfrom") & "-" & Year(dsdaily.Tables(2).Rows(0).Item("timefrom"))
            'End If

            If Day(dsdaily.Tables(2).Rows(0).Item("timefrom")) = Day(dsdaily.Tables(3).Rows(0).Item("timeto")) Then
                xlsheet.Cells(10, 14) = dsdaily.Tables(2).Rows(0).Item("dayfrom") & "-" & dsdaily.Tables(2).Rows(0).Item("monthfrom") & "-" & Year(dsdaily.Tables(2).Rows(0).Item("timefrom"))
            ElseIf Month(dsdaily.Tables(2).Rows(0).Item("timefrom")) = Month(dsdaily.Tables(3).Rows(0).Item("timeto")) And Day(dsdaily.Tables(2).Rows(0).Item("timefrom")) <> Day(dsdaily.Tables(3).Rows(0).Item("timeto")) Then
                xlsheet.Cells(10, 14) = dsdaily.Tables(2).Rows(0).Item("dayfrom") & "/" & dsdaily.Tables(3).Rows(0).Item("dayto") & "-" & dsdaily.Tables(2).Rows(0).Item("monthfrom") & "-" & Year(dsdaily.Tables(2).Rows(0).Item("timefrom"))
            ElseIf Year(dsdaily.Tables(2).Rows(0).Item("timefrom")) = Year(dsdaily.Tables(3).Rows(0).Item("timeto")) And Month(dsdaily.Tables(2).Rows(0).Item("timefrom")) <> Month(dsdaily.Tables(3).Rows(0).Item("timeto")) Then
                xlsheet.Cells(10, 14) = dsdaily.Tables(2).Rows(0).Item("dayfrom") & "/" & dsdaily.Tables(3).Rows(0).Item("dayto") & "-" & dsdaily.Tables(2).Rows(0).Item("monthfrom") & "/" & dsdaily.Tables(3).Rows(0).Item("monthto") & "-" & Year(dsdaily.Tables(2).Rows(0).Item("timefrom"))
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
            xlsheet.Cells(31, 2) = REMARKS
            xlsheet.Cells(31, 14) = GL_Teu
            If GL_Print = 1 Then
                'xlsheet.PrintPreview()
                xlsheet.PrintOut()
                KillExcelProcess()
                GL_Print = 0
            End If
        Catch
            xlapp.Quit()
            SendKeys.Send("n")
            KillExcelProcess()
        End Try
    End Sub

    '打印翻舱日报
    Private Sub Daily_Report_eng_dx_new()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer
        Try
            RecordExcelProcess()
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "Report_gonglei.xls", pathstr + "Report.xls")
            Filepath = pathstr + "report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("集装箱日报"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            If GL_Print = 1 Then
                xlsheet.Application.Visible = False
            Else
                xlsheet.Application.Visible = True
            End If
            xlsheet.Select()

            'If io = "0" Then
            '    xlsheet.Cells(9, 1) = "Inward"
            'Else
            '    xlsheet.Cells(9, 1) = "Outward"
            'End If
            xlsheet.Cells(10, 2) = "'" & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
            xlsheet.Cells(10, 5) = "'" & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            xlsheet.Cells(10, 7) = "'NO." & dsdailydx.Tables(1).Rows(0).Item("berth")
            xlsheet.Cells(10, 10) = "'" & dsdailydx.Tables(2).Rows(0).Item("hourfrom") & ":" & dsdailydx.Tables(2).Rows(0).Item("minfrom")
            xlsheet.Cells(10, 12) = "'" & dsdailydx.Tables(3).Rows(0).Item("hourto") & ":" & dsdailydx.Tables(3).Rows(0).Item("minto")
            'If Year(dsdailydx.Tables(2).Rows(0).Item("timefrom")) = Year(dsdailydx.Tables(3).Rows(0).Item("timeto")) And Month(dsdailydx.Tables(2).Rows(0).Item("timefrom")) = Month(dsdailydx.Tables(3).Rows(0).Item("timeto")) And Day(dsdailydx.Tables(2).Rows(0).Item("timefrom")) = Day(dsdailydx.Tables(3).Rows(0).Item("timeto")) Then
            '    xlsheet.Cells(10, 14) = dsdailydx.Tables(2).Rows(0).Item("dayfrom") & "-" & dsdailydx.Tables(2).Rows(0).Item("monthfrom") & "-" & Year(dsdailydx.Tables(2).Rows(0).Item("timefrom"))
            'Else
            '    xlsheet.Cells(10, 14) = dsdailydx.Tables(2).Rows(0).Item("dayfrom") & "/" & dsdailydx.Tables(3).Rows(0).Item("dayto") & "-" & dsdailydx.Tables(2).Rows(0).Item("monthfrom") & "-" & Year(dsdailydx.Tables(2).Rows(0).Item("timefrom"))
            'End If

            If Day(dsdailydx.Tables(2).Rows(0).Item("timefrom")) = Day(dsdailydx.Tables(3).Rows(0).Item("timeto")) Then
                xlsheet.Cells(10, 14) = dsdailydx.Tables(2).Rows(0).Item("dayfrom") & "-" & dsdailydx.Tables(2).Rows(0).Item("monthfrom") & "-" & Year(dsdailydx.Tables(2).Rows(0).Item("timefrom"))
            ElseIf Month(dsdailydx.Tables(2).Rows(0).Item("timefrom")) = Month(dsdailydx.Tables(3).Rows(0).Item("timeto")) And Day(dsdailydx.Tables(2).Rows(0).Item("timefrom")) <> Day(dsdailydx.Tables(3).Rows(0).Item("timeto")) Then
                xlsheet.Cells(10, 14) = dsdailydx.Tables(2).Rows(0).Item("dayfrom") & "/" & dsdailydx.Tables(3).Rows(0).Item("dayto") & "-" & dsdailydx.Tables(2).Rows(0).Item("monthfrom") & "-" & Year(dsdailydx.Tables(2).Rows(0).Item("timefrom"))
            ElseIf Year(dsdailydx.Tables(2).Rows(0).Item("timefrom")) = Year(dsdailydx.Tables(3).Rows(0).Item("timeto")) And Month(dsdailydx.Tables(2).Rows(0).Item("timefrom")) <> Month(dsdailydx.Tables(3).Rows(0).Item("timeto")) Then
                xlsheet.Cells(10, 14) = dsdailydx.Tables(2).Rows(0).Item("dayfrom") & "/" & dsdailydx.Tables(3).Rows(0).Item("dayto") & "-" & dsdailydx.Tables(2).Rows(0).Item("monthfrom") & "/" & dsdailydx.Tables(3).Rows(0).Item("monthto") & "-" & Year(dsdailydx.Tables(2).Rows(0).Item("timefrom"))
            Else
                xlsheet.Cells(10, 14) = dsdailydx.Tables(2).Rows(0).Item("dayfrom") & "/" & dsdailydx.Tables(3).Rows(0).Item("dayto") & "-" & dsdailydx.Tables(2).Rows(0).Item("monthfrom") & "-" & Year(dsdailydx.Tables(2).Rows(0).Item("timefrom"))
            End If

            If dsdailydx.Tables(0).Rows.Count >= 4 Then
                row = 0
                xlsheet.Cells(15, 1) = dsdailydx.Tables(0).Rows(0)(0)
                xlsheet.Cells(15, 2) = dsdailydx.Tables(0).Rows(0)(1)
                xlsheet.Cells(16, 3) = dsdailydx.Tables(0).Rows(0)(2)
                xlsheet.Cells(15, 4) = dsdailydx.Tables(0).Rows(0)(3)
                xlsheet.Cells(16, 5) = dsdailydx.Tables(0).Rows(0)(4)
                xlsheet.Cells(15, 6) = dsdailydx.Tables(0).Rows(0)(5)
                xlsheet.Cells(16, 7) = dsdailydx.Tables(0).Rows(0)(6)
                xlsheet.Cells(15, 8) = dsdailydx.Tables(0).Rows(0)(7)
                xlsheet.Cells(16, 9) = dsdailydx.Tables(0).Rows(0)(8)
                xlsheet.Cells(15, 10) = dsdailydx.Tables(0).Rows(0)(9)
                xlsheet.Cells(16, 11) = dsdailydx.Tables(0).Rows(0)(10)
                xlsheet.Cells(15, 12) = dsdailydx.Tables(0).Rows(0)(11)
                xlsheet.Cells(16, 13) = dsdailydx.Tables(0).Rows(0)(12)
                xlsheet.Cells(15, 14) = dsdailydx.Tables(0).Rows(0)(13)
                xlsheet.Cells(16, 15) = dsdailydx.Tables(0).Rows(0)(14)
                row = 1
                xlsheet.Cells(25, 2) = dsdailydx.Tables(0).Rows(row)(1)
                xlsheet.Cells(26, 3) = dsdailydx.Tables(0).Rows(row)(2)
                xlsheet.Cells(25, 4) = dsdailydx.Tables(0).Rows(row)(3)
                xlsheet.Cells(26, 5) = dsdailydx.Tables(0).Rows(row)(4)
                xlsheet.Cells(25, 6) = dsdailydx.Tables(0).Rows(row)(5)
                xlsheet.Cells(26, 7) = dsdailydx.Tables(0).Rows(row)(6)
                xlsheet.Cells(25, 8) = dsdailydx.Tables(0).Rows(row)(7)
                xlsheet.Cells(26, 9) = dsdailydx.Tables(0).Rows(row)(8)
                xlsheet.Cells(25, 10) = dsdailydx.Tables(0).Rows(row)(9)
                xlsheet.Cells(26, 11) = dsdailydx.Tables(0).Rows(row)(10)
                xlsheet.Cells(25, 12) = dsdailydx.Tables(0).Rows(row)(11)
                xlsheet.Cells(26, 13) = dsdailydx.Tables(0).Rows(row)(12)
                xlsheet.Cells(25, 14) = dsdailydx.Tables(0).Rows(row)(13)
                xlsheet.Cells(26, 15) = dsdailydx.Tables(0).Rows(row)(14)

                row = 2
                xlsheet.Cells(27, 2) = dsdailydx.Tables(0).Rows(row)(1)
                xlsheet.Cells(28, 3) = dsdailydx.Tables(0).Rows(row)(2)
                xlsheet.Cells(27, 4) = dsdailydx.Tables(0).Rows(row)(3)
                xlsheet.Cells(28, 5) = dsdailydx.Tables(0).Rows(row)(4)
                xlsheet.Cells(27, 6) = dsdailydx.Tables(0).Rows(row)(5)
                xlsheet.Cells(28, 7) = dsdailydx.Tables(0).Rows(row)(6)
                xlsheet.Cells(27, 8) = dsdailydx.Tables(0).Rows(row)(7)
                xlsheet.Cells(28, 9) = dsdailydx.Tables(0).Rows(row)(8)
                xlsheet.Cells(27, 10) = dsdailydx.Tables(0).Rows(row)(9)
                xlsheet.Cells(28, 11) = dsdailydx.Tables(0).Rows(row)(10)
                xlsheet.Cells(27, 12) = dsdailydx.Tables(0).Rows(row)(11)
                xlsheet.Cells(28, 13) = dsdailydx.Tables(0).Rows(row)(12)
                xlsheet.Cells(27, 14) = dsdailydx.Tables(0).Rows(row)(13)
                xlsheet.Cells(28, 15) = dsdailydx.Tables(0).Rows(row)(14)

                row = 3
                xlsheet.Cells(29, 2) = dsdailydx.Tables(0).Rows(row)(1)
                xlsheet.Cells(30, 3) = dsdailydx.Tables(0).Rows(row)(2)
                xlsheet.Cells(29, 4) = dsdailydx.Tables(0).Rows(row)(3)
                xlsheet.Cells(30, 5) = dsdailydx.Tables(0).Rows(row)(4)
                xlsheet.Cells(29, 6) = dsdailydx.Tables(0).Rows(row)(5)
                xlsheet.Cells(30, 7) = dsdailydx.Tables(0).Rows(row)(6)
                xlsheet.Cells(29, 8) = dsdailydx.Tables(0).Rows(row)(7)
                xlsheet.Cells(30, 9) = dsdailydx.Tables(0).Rows(row)(8)
                xlsheet.Cells(29, 10) = dsdailydx.Tables(0).Rows(row)(9)
                xlsheet.Cells(30, 11) = dsdailydx.Tables(0).Rows(row)(10)
                xlsheet.Cells(29, 12) = dsdailydx.Tables(0).Rows(row)(11)
                xlsheet.Cells(30, 13) = dsdailydx.Tables(0).Rows(row)(12)
                xlsheet.Cells(29, 14) = dsdailydx.Tables(0).Rows(row)(13)
                xlsheet.Cells(30, 15) = dsdailydx.Tables(0).Rows(row)(14)
            End If
            'xlsheet.Cells(31, 2) = "RESTOW       " & REMARKSdx
            If io = "0" Then
                xlsheet.Cells(31, 2) = "THE SHIFTTING     " & REMARKSdx
            Else
                xlsheet.Cells(31, 2) = "RELOAD     " & REMARKSdx
            End If
            xlsheet.Cells(31, 14) = GL_Teudx
            If GL_Print = 1 Then
                'xlsheet.PrintPreview()
                xlsheet.PrintOut()
                KillExcelProcess()
                GL_Print = 0
            End If
        Catch
            xlapp.Quit()
            SendKeys.Send("n")
            KillExcelProcess()
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
            FileCopy(pathstr + "Report_zlp.xls", pathstr + "Report.xls")
            Filepath = pathstr + "report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("理货业务凭证"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = True

            xlsheet.Cells(4, 1) = "船名： " & ds_sship.Tables(0).Rows(0).Item("CHI_VESSEL")
            xlsheet.Cells(4, 4) = "航次： " & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            xlsheet.Cells(4, 7) = "国籍： " & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_CHA")
            'xlsheet.Cells(3, 5) = "泊位： " & ds.Tables(1).Rows(0).Item("berth")
            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) Then
            Else
                xlsheet.Cells(5, 1) = "开工日期：" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")) & "年" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")) & "月" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")) & "日"

            End If
            xlsheet.Cells(5, 6) = "制单日期：" & Year(Now) & "年" & Month(Now) & "月" & Day(Now) & "日"

            'For row = 0 To ds.Tables(0).Rows.Count - 1
            '    For col = 0 To 7
            '        xlsheet.Cells(6 + row, col + 1) = ds.Tables(0).Rows(row)(col)
            '    Next col
            'Next row
            xlsheet.Cells(11, 5) = DS_DO.Tables(0).Rows(0)(0)
            xlsheet.Cells(12, 5) = DS_DO.Tables(0).Rows(0)(1)
            xlsheet.Cells(13, 5) = DS_DO.Tables(0).Rows(0)(2)
            xlsheet.Cells(14, 5) = DS_DO.Tables(0).Rows(0)(3)
            xlsheet.Cells(15, 5) = DS_DO.Tables(0).Rows(0)(4)
            xlsheet.Cells(16, 5) = DS_DO.Tables(0).Rows(0)(5)

            xlsheet.Cells(11, 6) = "箱"
            xlsheet.Cells(12, 6) = "箱"
            xlsheet.Cells(13, 6) = "箱"
            xlsheet.Cells(14, 6) = "箱"
            xlsheet.Cells(15, 6) = "箱"
            xlsheet.Cells(16, 6) = "箱"

            xlsheet.Cells(22, 5) = DS_DO.Tables(1).Rows(0)(0)
            'For row = 7 To ds.Tables(1).Rows.Count + 7 '*画行
            '    xlsheet.Range(xlsheet.Cells(row, 1), xlsheet.Cells(row, 19)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = 7
            'Next row
            'For col = 1 To 19 '* 画列
            '    xlsheet.Range(xlsheet.Cells(7, col), xlsheet.Cells(ds.Tables(1).Rows.Count + 7, col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7
            'Next col
            'xlsheet.Range(xlsheet.Cells(ds.Tables(1).Rows.Count + 4, 1), xlsheet.Cells(ds.Tables(1).Rows.Count + 4, 1)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7
            'xlsheet.Range(xlsheet.Cells(ds.Tables(1).Rows.Count + 4, 10), xlsheet.Cells(ds.Tables(1).Rows.Count + 4, 10)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7

            xlsheet.PrintPreview()

        Catch
            xlapp.Quit()
            SendKeys.Send("n")
            KillExcelProcess()
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
            FileCopy(pathstr + "Report_zlp.xls", pathstr + "Report.xls")
            Filepath = pathstr + "report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("理货业务凭证英文版"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = True

            xlsheet.Cells(4, 1) = "Vessel: " & ds_sship.Tables(0).Rows(0).Item("ENG_VESSEL")
            xlsheet.Cells(4, 4) = "Voy.No: " & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            xlsheet.Cells(4, 7) = "Nationality: " & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_English")
            'xlsheet.Cells(3, 5) = "Berth: " & ds.Tables(1).Rows(0).Item("berth")
            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) Then
            Else
                xlsheet.Cells(5, 1) = "Tally commenced on:" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")) & "-" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")) & "-" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN"))
            End If

            xlsheet.Cells(5, 6) = "Date of list:" & Year(Now) & "-" & Month(Now) & "-" & Day(Now)

            xlsheet.Cells(11, 5) = DS_DO.Tables(0).Rows(0)(0)
            xlsheet.Cells(12, 5) = DS_DO.Tables(0).Rows(0)(1)
            xlsheet.Cells(13, 5) = DS_DO.Tables(0).Rows(0)(2)
            xlsheet.Cells(14, 5) = DS_DO.Tables(0).Rows(0)(3)
            xlsheet.Cells(15, 5) = DS_DO.Tables(0).Rows(0)(4)
            xlsheet.Cells(16, 5) = DS_DO.Tables(0).Rows(0)(5)

            xlsheet.Cells(11, 6) = "Container"
            xlsheet.Cells(12, 6) = "Container"
            xlsheet.Cells(13, 6) = "Container"
            xlsheet.Cells(14, 6) = "Container"
            xlsheet.Cells(15, 6) = "Container"
            xlsheet.Cells(16, 6) = "Container"
            xlsheet.Cells(22, 5) = DS_DO.Tables(1).Rows(0)(0)
            xlsheet.PrintPreview()

        Catch
            xlapp.Quit()
            SendKeys.Send("n")
            KillExcelProcess()
        End Try
    End Sub

    Private Sub Daily_Report_china()
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
            xlsheet = CType(xlbook.Worksheets("集装箱日报（C）"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = True

            xlsheet.Cells(8, 2) = ds_sship.Tables(0).Rows(0).Item("CHI_VESSEL")
            xlsheet.Cells(8, 6) = ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            xlsheet.Cells(8, 8) = dsdaily.Tables(1).Rows(0).Item("berth")

            xlsheet.Cells(8, 11) = Year(dsdaily.Tables(2).Rows(0).Item("timefrom")) & "年" & dsdaily.Tables(2).Rows(0).Item("monthfrom") & "月" & dsdaily.Tables(2).Rows(0).Item("dayfrom") & "日 " & dsdaily.Tables(2).Rows(0).Item("hourfrom") & "时" & dsdaily.Tables(2).Rows(0).Item("minfrom") & "分"
            xlsheet.Cells(10, 11) = Year(dsdaily.Tables(3).Rows(0).Item("timeto")) & "年" & dsdaily.Tables(3).Rows(0).Item("monthto") & "月" & dsdaily.Tables(3).Rows(0).Item("dayto") & "日 " & dsdaily.Tables(3).Rows(0).Item("hourto") & "时" & dsdaily.Tables(3).Rows(0).Item("minto") & "分"
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
            KillExcelProcess()
        End Try
    End Sub

    Private Sub Daily_Report_eng()
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
            xlsheet = CType(xlbook.Worksheets("集装箱日报（E）"), Excel.Worksheet)
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
            KillExcelProcess()
        End Try
    End Sub

    Private Sub MakeExcelTally_List()
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
            xlBook.Worksheets("sheet1").select()
            xlSheet.Cells(1, 1) = Me.Text() '标题

            For Col = ColNum To Me.C1DBGTally_List.Columns.Count - 1 '列标题
                xlSheet.Cells(3, Col - ColNum + 1) = Me.C1DBGTally_List.Columns(Col).Caption

            Next Col
            Me.C1DBGTally_List.MoveFirst()
            For Row = 0 To dsTally_List.Tables(0).Rows.Count - 1 '数据
                For Col = ColNum To Me.C1DBGTally_List.Columns.Count - 1
                    xlSheet.Cells(Row + 4, Col - ColNum + 1) = Me.C1DBGTally_List.Columns(Col).Text.ToString      'ds.Tables(0).Rows(Row)(Col)
                Next Col
                Me.C1DBGTally_List.MoveNext()
            Next Row
            If Me.C1DBGTally_List.ColumnFooters = True Then '合计项
                For Col = ColNum To Me.C1DBGTally_List.Columns.Count - 1
                    xlSheet.Cells(dsTally_List.Tables(0).Rows.Count + 4, Col - ColNum + 1) = Me.C1DBGTally_List.Columns(Col).FooterText
                Next Col
            End If
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
            KillExcelProcess()
        End Try
    End Sub

    Private Sub SetColumnCaption()
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
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

            Do While i < Me.C1DBGShort.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGShort.Columns.Item(i).DataField.ToString)) Then
                        Me.C1DBGShort.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
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

    Private Sub preview(ByVal Func As String) '***************权限设计
        Dim sqlstr As String
        Dim Previewdv As DataView
        Dim Previewds As New DataSet
        Dim i As Integer
        sqlstr = " select FUNC_CODE_Add,FUNC_CODE_Change,FUNC_CODE_Del from View_UserPreview where PART_ID=" & G_Part_Id & " and FUNC_CODE='" & Upper(Func) & "' "
        Previewdv = Getdata(sqlstr, Previewds)
        If Previewdv.Count > 0 Then
            If Previewdv(i)("FUNC_CODE_Add") = 1 Then 'ADD 按钮可见
                ToolBar.Buttons.Item(4).Enabled = True
                mnuAdd.Enabled = True
            Else                                      'ADD 按钮不可见
                Me.ToolBar.Buttons.Item(4).Enabled = False
                mnuAdd.Enabled = False
            End If
            If Previewdv(i)("FUNC_CODE_Change") = 1 Then '修改 按钮可见
                Me.ToolBar.Buttons.Item(5).Enabled = True
                mnuEdit.Enabled = True
            Else                                          '修改 按钮不可见
                Me.ToolBar.Buttons.Item(5).Enabled = False
                mnuEdit.Enabled = False
            End If
            If Previewdv(i)("FUNC_CODE_Del") = 1 Then '删除 按钮可见
                Me.ToolBar.Buttons.Item(6).Enabled = True
                mnuDelete.Enabled = True
            Else                                     '删除按钮不可见
                Me.ToolBar.Buttons.Item(6).Enabled = False
                mnuDelete.Enabled = False
            End If
        End If
    End Sub
     
    Private Sub Frm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.C1DBGV.Height = Me.Height - 140
        Me.C1DBGTally_List.Height = Me.TabTALLY_LIST.Height - 5
        Me.C1DBGTally_List.Width = Me.GB.Width - 15
        Me.Label.Width = Me.C1DBGTally_List.Width - 3
        Me.LabREMARKS.Width = Me.C1DBGTally_List.Width - 3
        Me.C1DBGCertificate.Height = Me.Height - 190
        Me.C1DBGCertificate.Width = Me.GB.Width - 15
        Me.C1DBGDaily_report.Height = Me.Height - 190
        Me.C1DBGDaily_report.Width = Me.GB.Width - 15
        Me.C1DBGShort.Height = Me.Height - 190
        Me.C1DBGShort.Width = Me.GB.Width - 15
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
        'SqlStrShip = "where (((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','4')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) and Voyage like '" & Trim(txtVoyage.Text) & "%' and (ENG_VESSEL Like '" & Trim(txtShipName.Text) & "%' OR CHI_VESSEL like '" & Trim(txtShipName.Text) & "%' )) "
        SqlStrShip = "where (((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('0','3'))) and Voyage like '" & Trim(txtVoyage.Text) & "%' and (ENG_VESSEL Like '" & Trim(txtShipName.Text) & "%' OR CHI_VESSEL like '" & Trim(txtShipName.Text) & "%' )) "
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim jjr As String
            If chkjjr.Checked = True Then
                jjr = 1
            Else
                jjr = 0
            End If
            If MsgBox("是否确认要修改:" & DateTimePicker1.Value.ToString() & " 到 " & DateTimePicker2.Value.ToString() & " 节假日信息？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
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
                st_log = String.Format("insert into con_info(worktype, shipid, workno, instime, message, dx) values('{0}','{1}','{2}','{3}','{4}','{5}') ", "tally", Ship_ID, G_WorkNo, Now.ToString(), DateTimePicker1.Value.ToString() + "." + DateTimePicker2.Value.ToString() + "." + jjr + "." + myname + "." + ip, "jjr")
                ExecSql(st_log)

                ExecSql("update con_tally_list set holiday='" & jjr & "' where ship_id=" & Ship_ID & " and date between '" & DateTimePicker1.Value.ToString() & "' and  '" & DateTimePicker2.Value.ToString() & "'")
                MsgBox("节假日信息修改成功！")
                Refresh()
                Call getTallylist(FirmStr)    '理箱单
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim yb As String
            If chkyb.Checked = True Then
                yb = 1
            Else
                yb = 0
            End If
            If MsgBox("是否确认要修改:" & DateTimePicker1.Value.ToString() & " 到 " & DateTimePicker2.Value.ToString() & " 夜班信息？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
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
                st_log = String.Format("insert into con_info(worktype, shipid, workno, instime, message, dx) values('{0}','{1}','{2}','{3}','{4}','{5}') ", "tally", Ship_ID, G_WorkNo, Now.ToString(), DateTimePicker1.Value.ToString() + "." + DateTimePicker2.Value.ToString() + "." + yb + "." + myname + "." + ip, "yb")
                ExecSql(st_log)

                ExecSql("update con_tally_list set night_mark='" & yb & "' where ship_id=" & Ship_ID & " and date between '" & DateTimePicker1.Value.ToString() & "' and  '" & DateTimePicker2.Value.ToString() & "'")
                MsgBox("夜班信息修改成功！")
                Refresh()
                Call getTallylist(FirmStr)    '理箱单
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim gb As String
            gb = TextBox1.Text.Trim()
            If gb.Length <> 2 Then
                MsgBox("请正确设置2位工班号")
                Exit Sub
            End If
            If MsgBox("是否确认要修改:" & DateTimePicker1.Value.ToString() & " 到 " & DateTimePicker2.Value.ToString() & " 的工班信息？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
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
                st_log = String.Format("insert into con_info(worktype, shipid, workno, instime, message, dx) values('{0}','{1}','{2}','{3}','{4}','{5}') ", "tally", Ship_ID, G_WorkNo, Now.ToString(), DateTimePicker1.Value.ToString() + "." + DateTimePicker2.Value.ToString() + "." + gb + "." + myname + "." + ip, "gb")
                ExecSql(st_log)

                ExecSql("update con_tally_list set team_no='" & gb & "' where ship_id=" & Ship_ID & " and date between '" & DateTimePicker1.Value.ToString() & "' and  '" & DateTimePicker2.Value.ToString() & "'")
                MsgBox("工班信息修改成功！")
                Refresh()
                Call getTallylist(FirmStr)    '理箱单
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub C1DBGTally_List_AfterFilter(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FilterEventArgs) Handles C1DBGTally_List.AfterFilter
        Me.C1DBGTally_List.Columns.Item(ColNum + 1).FooterText = "共 " & C1DBGTally_List.Splits(0).Rows.Count & " 条"
    End Sub

    Private Sub mnuExportReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New FrmConReload
        frm.ShowDialog()
    End Sub

    Dim plMove As Boolean = False
    Dim plPoint As New Point
    Dim plOldPoint As New Point

    Private Sub Panel1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        plMove = True
        plPoint.X = e.X
        plPoint.Y = e.Y
        plOldPoint.X = Me.Panel1.Location.X
        plOldPoint.Y = Me.Panel1.Location.Y
    End Sub

    Private Sub Panel1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel1.MouseEnter
        Me.Cursor = Cursors.SizeAll
    End Sub

    Private Sub Panel1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel1.MouseLeave
        Cursor = Cursors.Default
    End Sub

    Private Sub Panel1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        If plMove = True Then
            Me.Panel1.Location = New Point(plOldPoint.X + (e.X - plPoint.X), plOldPoint.Y + (e.Y - plPoint.Y))
        End If
        plMove = False
        Me.Panel1.BringToFront()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Panel1.Visible = False
    End Sub

End Class
