Imports TALLY.DBControl
Imports System.IO
Imports System.IO.Path

Public Class FrmContainerListSummary
    Inherits System.Windows.Forms.Form

    Dim dsShip As New DataSet() '船舶数据集
    Dim SqlStrShip As String  '船舶条件语句
    Dim FirmShip As String
    Dim SortShip As String
    Dim inoutstr As String

    'Dim ds As New DataSet()
    Dim dsNo As New DataSet()
    Dim dsUnloadPort As New DataSet()
    Dim dsBill As New DataSet()
    Dim dsReefer As New DataSet()
    Dim dsDanger As New DataSet()
    Dim dsCargo As New DataSet()
    Dim dsSum As New DataSet()
    Dim dsPortSum As New DataSet()

    Dim SqlStr As String  '条件语句
    Dim DynaStr As String '可变的条件设计
    Dim FirmStrNo, FirmStrUnloadPort, FirmStrBill, FirmStrReefer, FirmStrDanger, FirmStrCargo As String '不变的条件设计
    Dim ColNum As Integer '不显示的列数
    Dim PrintMark As Boolean
    Dim dwship As New DataView()

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
    Friend WithEvents mnuAdd As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnSearch As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuCompile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.MenuItem
    Friend WithEvents S2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents S4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFind As System.Windows.Forms.MenuItem
    Friend WithEvents mnuQuery As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrint As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExport As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuQuit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnOK As System.Windows.Forms.ToolBarButton
    Friend WithEvents S3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSort As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnEng As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents tbbtnQuit As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    Friend WithEvents tbbtnFind As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnQuery As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnAdd As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnEdit As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnDelete As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnPrint As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnExport As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents GBV As System.Windows.Forms.GroupBox
    Friend WithEvents ToolBarV As System.Windows.Forms.ToolBar
    Friend WithEvents C1DBGV As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents tbpLoadSumary As System.Windows.Forms.TabPage
    Friend WithEvents C1DBGSum As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents tbpNoList As System.Windows.Forms.TabPage
    Friend WithEvents tbpCargoList As System.Windows.Forms.TabPage
    Friend WithEvents C1DBGCargo As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents tbpPortSumary As System.Windows.Forms.TabPage
    Friend WithEvents C1DBGPortSum As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents tbpBillList As System.Windows.Forms.TabPage
    Friend WithEvents C1DBGBill As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents tbpDangerList As System.Windows.Forms.TabPage
    Friend WithEvents C1DBGDanger As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents tbpPortList As System.Windows.Forms.TabPage
    Friend WithEvents C1DBGUnloadPort As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents tbpReeferList As System.Windows.Forms.TabPage
    Friend WithEvents C1DBGReefer As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents C1DBGNo As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btResure As System.Windows.Forms.Button
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents C1DBGSumNew As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents tbpHatchBill As System.Windows.Forms.TabPage
    Friend WithEvents C1DBGH As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmContainerListSummary))
        Me.mnuAdd = New System.Windows.Forms.MenuItem
        Me.tbbtnSearch = New System.Windows.Forms.ToolBarButton
        Me.mnuCompile = New System.Windows.Forms.MenuItem
        Me.mnuEdit = New System.Windows.Forms.MenuItem
        Me.mnuDelete = New System.Windows.Forms.MenuItem
        Me.S2 = New System.Windows.Forms.ToolBarButton
        Me.S4 = New System.Windows.Forms.ToolBarButton
        Me.MainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuFind = New System.Windows.Forms.MenuItem
        Me.mnuQuery = New System.Windows.Forms.MenuItem
        Me.mnuSep1 = New System.Windows.Forms.MenuItem
        Me.mnuPrint = New System.Windows.Forms.MenuItem
        Me.mnuExport = New System.Windows.Forms.MenuItem
        Me.mnuSep2 = New System.Windows.Forms.MenuItem
        Me.mnuQuit = New System.Windows.Forms.MenuItem
        Me.mnuHelp = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.tbbtnOK = New System.Windows.Forms.ToolBarButton
        Me.S3 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSort = New System.Windows.Forms.ToolBarButton
        Me.tbbtnEng = New System.Windows.Forms.ToolBarButton
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.tbbtnQuit = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep2 = New System.Windows.Forms.ToolBarButton
        Me.GB = New System.Windows.Forms.GroupBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tbpLoadSumary = New System.Windows.Forms.TabPage
        Me.C1DBGSumNew = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1DBGSum = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.tbpNoList = New System.Windows.Forms.TabPage
        Me.C1DBGNo = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.tbpPortList = New System.Windows.Forms.TabPage
        Me.C1DBGUnloadPort = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.tbpBillList = New System.Windows.Forms.TabPage
        Me.C1DBGBill = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.tbpReeferList = New System.Windows.Forms.TabPage
        Me.C1DBGReefer = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.tbpDangerList = New System.Windows.Forms.TabPage
        Me.C1DBGDanger = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.tbpCargoList = New System.Windows.Forms.TabPage
        Me.C1DBGCargo = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.tbpPortSumary = New System.Windows.Forms.TabPage
        Me.C1DBGPortSum = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.tbpHatchBill = New System.Windows.Forms.TabPage
        Me.C1DBGH = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label = New System.Windows.Forms.Label
        Me.ToolBar = New System.Windows.Forms.ToolBar
        Me.tbbtnFind = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuery = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep1 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnAdd = New System.Windows.Forms.ToolBarButton
        Me.tbbtnEdit = New System.Windows.Forms.ToolBarButton
        Me.tbbtnDelete = New System.Windows.Forms.ToolBarButton
        Me.tbbtnPrint = New System.Windows.Forms.ToolBarButton
        Me.tbbtnExport = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep3 = New System.Windows.Forms.ToolBarButton
        Me.GBV = New System.Windows.Forms.GroupBox
        Me.btResure = New System.Windows.Forms.Button
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolBarV = New System.Windows.Forms.ToolBar
        Me.C1DBGV = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.GB.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tbpLoadSumary.SuspendLayout()
        CType(Me.C1DBGSumNew, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DBGSum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpNoList.SuspendLayout()
        CType(Me.C1DBGNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpPortList.SuspendLayout()
        CType(Me.C1DBGUnloadPort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpBillList.SuspendLayout()
        CType(Me.C1DBGBill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpReeferList.SuspendLayout()
        CType(Me.C1DBGReefer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpDangerList.SuspendLayout()
        CType(Me.C1DBGDanger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpCargoList.SuspendLayout()
        CType(Me.C1DBGCargo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpPortSumary.SuspendLayout()
        CType(Me.C1DBGPortSum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpHatchBill.SuspendLayout()
        CType(Me.C1DBGH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBV.SuspendLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuAdd
        '
        Me.mnuAdd.Enabled = False
        Me.mnuAdd.Index = 0
        Me.mnuAdd.Text = "处理(&A)"
        '
        'tbbtnSearch
        '
        Me.tbbtnSearch.ImageIndex = 9
        Me.tbbtnSearch.Name = "tbbtnSearch"
        Me.tbbtnSearch.Text = "检索"
        '
        'mnuCompile
        '
        Me.mnuCompile.Index = 1
        Me.mnuCompile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAdd, Me.mnuEdit, Me.mnuDelete})
        Me.mnuCompile.Text = "编辑(&E)"
        '
        'mnuEdit
        '
        Me.mnuEdit.Enabled = False
        Me.mnuEdit.Index = 1
        Me.mnuEdit.Text = "还原(&E)"
        '
        'mnuDelete
        '
        Me.mnuDelete.Enabled = False
        Me.mnuDelete.Index = 2
        Me.mnuDelete.Text = "删除(&D)"
        '
        'S2
        '
        Me.S2.Name = "S2"
        Me.S2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'S4
        '
        Me.S4.Name = "S4"
        Me.S4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuCompile, Me.mnuHelp, Me.MenuItem1})
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
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.Text = "帮助(&H)"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 3
        Me.MenuItem1.Text = ""
        '
        'tbbtnOK
        '
        Me.tbbtnOK.ImageIndex = 8
        Me.tbbtnOK.Name = "tbbtnOK"
        Me.tbbtnOK.Text = "常规"
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
        '
        'tbbtnQuit
        '
        Me.tbbtnQuit.ImageIndex = 7
        Me.tbbtnQuit.Name = "tbbtnQuit"
        Me.tbbtnQuit.Text = "退出"
        Me.tbbtnQuit.ToolTipText = "退出"
        '
        'tbbtnSep2
        '
        Me.tbbtnSep2.Name = "tbbtnSep2"
        Me.tbbtnSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'GB
        '
        Me.GB.Controls.Add(Me.TabControl1)
        Me.GB.Controls.Add(Me.Label)
        Me.GB.Controls.Add(Me.ToolBar)
        Me.GB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB.Location = New System.Drawing.Point(166, 0)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(596, 459)
        Me.GB.TabIndex = 21
        Me.GB.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tbpLoadSumary)
        Me.TabControl1.Controls.Add(Me.tbpNoList)
        Me.TabControl1.Controls.Add(Me.tbpPortList)
        Me.TabControl1.Controls.Add(Me.tbpBillList)
        Me.TabControl1.Controls.Add(Me.tbpReeferList)
        Me.TabControl1.Controls.Add(Me.tbpDangerList)
        Me.TabControl1.Controls.Add(Me.tbpCargoList)
        Me.TabControl1.Controls.Add(Me.tbpPortSumary)
        Me.TabControl1.Controls.Add(Me.tbpHatchBill)
        Me.TabControl1.ItemSize = New System.Drawing.Size(48, 17)
        Me.TabControl1.Location = New System.Drawing.Point(4, 92)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(592, 366)
        Me.TabControl1.TabIndex = 12
        '
        'tbpLoadSumary
        '
        Me.tbpLoadSumary.Controls.Add(Me.C1DBGSumNew)
        Me.tbpLoadSumary.Controls.Add(Me.C1DBGSum)
        Me.tbpLoadSumary.Location = New System.Drawing.Point(4, 21)
        Me.tbpLoadSumary.Name = "tbpLoadSumary"
        Me.tbpLoadSumary.Size = New System.Drawing.Size(584, 341)
        Me.tbpLoadSumary.TabIndex = 0
        Me.tbpLoadSumary.Text = "汇总表"
        '
        'C1DBGSumNew
        '
        Me.C1DBGSumNew.AllowFilter = False
        Me.C1DBGSumNew.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGSumNew.AllowUpdate = False
        Me.C1DBGSumNew.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGSumNew.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGSumNew.Images.Add(CType(resources.GetObject("C1DBGSumNew.Images"), System.Drawing.Image))
        Me.C1DBGSumNew.Location = New System.Drawing.Point(2, 0)
        Me.C1DBGSumNew.Name = "C1DBGSumNew"
        Me.C1DBGSumNew.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGSumNew.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGSumNew.PreviewInfo.ZoomFactor = 75
        Me.C1DBGSumNew.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGSumNew.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGSumNew.Size = New System.Drawing.Size(582, 338)
        Me.C1DBGSumNew.TabIndex = 13
        Me.C1DBGSumNew.Text = "C1TrueDBGrid2"
        Me.C1DBGSumNew.PropBag = resources.GetString("C1DBGSumNew.PropBag")
        '
        'C1DBGSum
        '
        Me.C1DBGSum.AllowFilter = False
        Me.C1DBGSum.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGSum.AllowUpdate = False
        Me.C1DBGSum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGSum.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGSum.Images.Add(CType(resources.GetObject("C1DBGSum.Images"), System.Drawing.Image))
        Me.C1DBGSum.Location = New System.Drawing.Point(2, 168)
        Me.C1DBGSum.Name = "C1DBGSum"
        Me.C1DBGSum.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGSum.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGSum.PreviewInfo.ZoomFactor = 75
        Me.C1DBGSum.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGSum.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGSum.Size = New System.Drawing.Size(582, 172)
        Me.C1DBGSum.TabIndex = 12
        Me.C1DBGSum.Text = "C1TrueDBGrid2"
        Me.C1DBGSum.Visible = False
        Me.C1DBGSum.PropBag = resources.GetString("C1DBGSum.PropBag")
        '
        'tbpNoList
        '
        Me.tbpNoList.Controls.Add(Me.C1DBGNo)
        Me.tbpNoList.Location = New System.Drawing.Point(4, 21)
        Me.tbpNoList.Name = "tbpNoList"
        Me.tbpNoList.Size = New System.Drawing.Size(584, 341)
        Me.tbpNoList.TabIndex = 1
        Me.tbpNoList.Text = "箱号排序表"
        '
        'C1DBGNo
        '
        Me.C1DBGNo.AllowFilter = False
        Me.C1DBGNo.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGNo.AllowUpdate = False
        Me.C1DBGNo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGNo.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGNo.Images.Add(CType(resources.GetObject("C1DBGNo.Images"), System.Drawing.Image))
        Me.C1DBGNo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGNo.Name = "C1DBGNo"
        Me.C1DBGNo.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGNo.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGNo.PreviewInfo.ZoomFactor = 75
        Me.C1DBGNo.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGNo.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGNo.Size = New System.Drawing.Size(582, 340)
        Me.C1DBGNo.TabIndex = 13
        Me.C1DBGNo.Text = "C1TrueDBGrid3"
        Me.C1DBGNo.PropBag = resources.GetString("C1DBGNo.PropBag")
        '
        'tbpPortList
        '
        Me.tbpPortList.Controls.Add(Me.C1DBGUnloadPort)
        Me.tbpPortList.Location = New System.Drawing.Point(4, 21)
        Me.tbpPortList.Name = "tbpPortList"
        Me.tbpPortList.Size = New System.Drawing.Size(584, 341)
        Me.tbpPortList.TabIndex = 2
        Me.tbpPortList.Text = "卸货港排序表"
        '
        'C1DBGUnloadPort
        '
        Me.C1DBGUnloadPort.AllowFilter = False
        Me.C1DBGUnloadPort.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGUnloadPort.AllowUpdate = False
        Me.C1DBGUnloadPort.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGUnloadPort.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGUnloadPort.Images.Add(CType(resources.GetObject("C1DBGUnloadPort.Images"), System.Drawing.Image))
        Me.C1DBGUnloadPort.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGUnloadPort.Name = "C1DBGUnloadPort"
        Me.C1DBGUnloadPort.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGUnloadPort.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGUnloadPort.PreviewInfo.ZoomFactor = 75
        Me.C1DBGUnloadPort.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGUnloadPort.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGUnloadPort.Size = New System.Drawing.Size(582, 340)
        Me.C1DBGUnloadPort.TabIndex = 11
        Me.C1DBGUnloadPort.Text = "C1TrueDBGrid1"
        Me.C1DBGUnloadPort.PropBag = resources.GetString("C1DBGUnloadPort.PropBag")
        '
        'tbpBillList
        '
        Me.tbpBillList.Controls.Add(Me.C1DBGBill)
        Me.tbpBillList.Location = New System.Drawing.Point(4, 21)
        Me.tbpBillList.Name = "tbpBillList"
        Me.tbpBillList.Size = New System.Drawing.Size(584, 341)
        Me.tbpBillList.TabIndex = 3
        Me.tbpBillList.Text = "提单号排序表"
        '
        'C1DBGBill
        '
        Me.C1DBGBill.AllowFilter = False
        Me.C1DBGBill.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGBill.AllowUpdate = False
        Me.C1DBGBill.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGBill.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGBill.Images.Add(CType(resources.GetObject("C1DBGBill.Images"), System.Drawing.Image))
        Me.C1DBGBill.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGBill.Name = "C1DBGBill"
        Me.C1DBGBill.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGBill.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGBill.PreviewInfo.ZoomFactor = 75
        Me.C1DBGBill.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGBill.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGBill.Size = New System.Drawing.Size(582, 340)
        Me.C1DBGBill.TabIndex = 13
        Me.C1DBGBill.Text = "C1TrueDBGrid4"
        Me.C1DBGBill.PropBag = resources.GetString("C1DBGBill.PropBag")
        '
        'tbpReeferList
        '
        Me.tbpReeferList.Controls.Add(Me.C1DBGReefer)
        Me.tbpReeferList.Location = New System.Drawing.Point(4, 21)
        Me.tbpReeferList.Name = "tbpReeferList"
        Me.tbpReeferList.Size = New System.Drawing.Size(584, 341)
        Me.tbpReeferList.TabIndex = 4
        Me.tbpReeferList.Text = "冷藏箱清单"
        '
        'C1DBGReefer
        '
        Me.C1DBGReefer.AllowFilter = False
        Me.C1DBGReefer.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGReefer.AllowUpdate = False
        Me.C1DBGReefer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGReefer.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGReefer.Images.Add(CType(resources.GetObject("C1DBGReefer.Images"), System.Drawing.Image))
        Me.C1DBGReefer.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGReefer.Name = "C1DBGReefer"
        Me.C1DBGReefer.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGReefer.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGReefer.PreviewInfo.ZoomFactor = 75
        Me.C1DBGReefer.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGReefer.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGReefer.Size = New System.Drawing.Size(582, 340)
        Me.C1DBGReefer.TabIndex = 13
        Me.C1DBGReefer.Text = "C1TrueDBGrid5"
        Me.C1DBGReefer.PropBag = resources.GetString("C1DBGReefer.PropBag")
        '
        'tbpDangerList
        '
        Me.tbpDangerList.Controls.Add(Me.C1DBGDanger)
        Me.tbpDangerList.Location = New System.Drawing.Point(4, 21)
        Me.tbpDangerList.Name = "tbpDangerList"
        Me.tbpDangerList.Size = New System.Drawing.Size(584, 341)
        Me.tbpDangerList.TabIndex = 5
        Me.tbpDangerList.Text = "危险品清单"
        '
        'C1DBGDanger
        '
        Me.C1DBGDanger.AllowFilter = False
        Me.C1DBGDanger.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGDanger.AllowUpdate = False
        Me.C1DBGDanger.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGDanger.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGDanger.Images.Add(CType(resources.GetObject("C1DBGDanger.Images"), System.Drawing.Image))
        Me.C1DBGDanger.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGDanger.Name = "C1DBGDanger"
        Me.C1DBGDanger.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGDanger.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGDanger.PreviewInfo.ZoomFactor = 75
        Me.C1DBGDanger.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGDanger.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGDanger.Size = New System.Drawing.Size(582, 340)
        Me.C1DBGDanger.TabIndex = 13
        Me.C1DBGDanger.Text = "C1TrueDBGrid6"
        Me.C1DBGDanger.PropBag = resources.GetString("C1DBGDanger.PropBag")
        '
        'tbpCargoList
        '
        Me.tbpCargoList.Controls.Add(Me.C1DBGCargo)
        Me.tbpCargoList.Location = New System.Drawing.Point(4, 21)
        Me.tbpCargoList.Name = "tbpCargoList"
        Me.tbpCargoList.Size = New System.Drawing.Size(584, 341)
        Me.tbpCargoList.TabIndex = 7
        Me.tbpCargoList.Text = "箱载货清单"
        '
        'C1DBGCargo
        '
        Me.C1DBGCargo.AllowFilter = False
        Me.C1DBGCargo.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGCargo.AllowUpdate = False
        Me.C1DBGCargo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGCargo.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGCargo.Images.Add(CType(resources.GetObject("C1DBGCargo.Images"), System.Drawing.Image))
        Me.C1DBGCargo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGCargo.Name = "C1DBGCargo"
        Me.C1DBGCargo.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGCargo.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGCargo.PreviewInfo.ZoomFactor = 75
        Me.C1DBGCargo.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGCargo.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGCargo.Size = New System.Drawing.Size(582, 340)
        Me.C1DBGCargo.TabIndex = 13
        Me.C1DBGCargo.Text = "C1TrueDBGrid8"
        Me.C1DBGCargo.PropBag = resources.GetString("C1DBGCargo.PropBag")
        '
        'tbpPortSumary
        '
        Me.tbpPortSumary.Controls.Add(Me.C1DBGPortSum)
        Me.tbpPortSumary.Location = New System.Drawing.Point(4, 21)
        Me.tbpPortSumary.Name = "tbpPortSumary"
        Me.tbpPortSumary.Size = New System.Drawing.Size(584, 341)
        Me.tbpPortSumary.TabIndex = 6
        Me.tbpPortSumary.Text = "港口汇总清单"
        '
        'C1DBGPortSum
        '
        Me.C1DBGPortSum.AllowFilter = False
        Me.C1DBGPortSum.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGPortSum.AllowUpdate = False
        Me.C1DBGPortSum.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGPortSum.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGPortSum.Images.Add(CType(resources.GetObject("C1DBGPortSum.Images"), System.Drawing.Image))
        Me.C1DBGPortSum.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGPortSum.Name = "C1DBGPortSum"
        Me.C1DBGPortSum.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGPortSum.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGPortSum.PreviewInfo.ZoomFactor = 75
        Me.C1DBGPortSum.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGPortSum.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGPortSum.Size = New System.Drawing.Size(582, 340)
        Me.C1DBGPortSum.TabIndex = 13
        Me.C1DBGPortSum.Text = "C1TrueDBGrid7"
        Me.C1DBGPortSum.PropBag = resources.GetString("C1DBGPortSum.PropBag")
        '
        'tbpHatchBill
        '
        Me.tbpHatchBill.Controls.Add(Me.C1DBGH)
        Me.tbpHatchBill.Location = New System.Drawing.Point(4, 21)
        Me.tbpHatchBill.Name = "tbpHatchBill"
        Me.tbpHatchBill.Size = New System.Drawing.Size(584, 341)
        Me.tbpHatchBill.TabIndex = 8
        Me.tbpHatchBill.Text = "舱单"
        '
        'C1DBGH
        '
        Me.C1DBGH.AllowFilter = False
        Me.C1DBGH.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGH.AllowUpdate = False
        Me.C1DBGH.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGH.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGH.Images.Add(CType(resources.GetObject("C1DBGH.Images"), System.Drawing.Image))
        Me.C1DBGH.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGH.Name = "C1DBGH"
        Me.C1DBGH.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGH.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGH.PreviewInfo.ZoomFactor = 75
        Me.C1DBGH.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGH.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGH.Size = New System.Drawing.Size(582, 340)
        Me.C1DBGH.TabIndex = 14
        Me.C1DBGH.Text = "C1TrueDBGrid7"
        Me.C1DBGH.PropBag = resources.GetString("C1DBGH.PropBag")
        '
        'Label
        '
        Me.Label.BackColor = System.Drawing.SystemColors.Control
        Me.Label.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label.Location = New System.Drawing.Point(3, 58)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(590, 37)
        Me.Label.TabIndex = 11
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolBar
        '
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnFind, Me.tbbtnQuery, Me.tbbtnSep1, Me.tbbtnAdd, Me.tbbtnEdit, Me.tbbtnDelete, Me.tbbtnSep2, Me.tbbtnPrint, Me.tbbtnExport, Me.tbbtnSep3, Me.tbbtnQuit})
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.Enabled = False
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(3, 17)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(590, 41)
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
        'tbbtnSep1
        '
        Me.tbbtnSep1.Name = "tbbtnSep1"
        Me.tbbtnSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnAdd
        '
        Me.tbbtnAdd.ImageIndex = 2
        Me.tbbtnAdd.Name = "tbbtnAdd"
        Me.tbbtnAdd.Text = "处理"
        Me.tbbtnAdd.ToolTipText = "处理"
        '
        'tbbtnEdit
        '
        Me.tbbtnEdit.ImageIndex = 3
        Me.tbbtnEdit.Name = "tbbtnEdit"
        Me.tbbtnEdit.Text = "还原"
        Me.tbbtnEdit.ToolTipText = "还原"
        '
        'tbbtnDelete
        '
        Me.tbbtnDelete.ImageIndex = 4
        Me.tbbtnDelete.Name = "tbbtnDelete"
        Me.tbbtnDelete.Text = "删除"
        Me.tbbtnDelete.ToolTipText = "删除"
        '
        'tbbtnPrint
        '
        Me.tbbtnPrint.ImageIndex = 5
        Me.tbbtnPrint.Name = "tbbtnPrint"
        Me.tbbtnPrint.Text = "打印"
        Me.tbbtnPrint.ToolTipText = "打印"
        '
        'tbbtnExport
        '
        Me.tbbtnExport.ImageIndex = 6
        Me.tbbtnExport.Name = "tbbtnExport"
        Me.tbbtnExport.Text = "导出"
        Me.tbbtnExport.ToolTipText = "导出Excel"
        '
        'tbbtnSep3
        '
        Me.tbbtnSep3.Name = "tbbtnSep3"
        Me.tbbtnSep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
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
        Me.GBV.Size = New System.Drawing.Size(166, 459)
        Me.GBV.TabIndex = 20
        Me.GBV.TabStop = False
        '
        'btResure
        '
        Me.btResure.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btResure.Location = New System.Drawing.Point(122, 396)
        Me.btResure.Name = "btResure"
        Me.btResure.Size = New System.Drawing.Size(42, 22)
        Me.btResure.TabIndex = 17
        Me.btResure.Text = "查询"
        '
        'txtVoyage
        '
        Me.txtVoyage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVoyage.Location = New System.Drawing.Point(32, 396)
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(88, 21)
        Me.txtVoyage.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(2, 398)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "航次"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShipName
        '
        Me.txtShipName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtShipName.Location = New System.Drawing.Point(32, 374)
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.Size = New System.Drawing.Size(132, 21)
        Me.txtShipName.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(2, 376)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "船名"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolBarV
        '
        Me.ToolBarV.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnOK, Me.S2, Me.tbbtnSearch, Me.S3, Me.tbbtnSort, Me.S4, Me.tbbtnEng})
        Me.ToolBarV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBarV.DropDownArrows = True
        Me.ToolBarV.ImageList = Me.ImageList
        Me.ToolBarV.Location = New System.Drawing.Point(3, 415)
        Me.ToolBarV.Name = "ToolBarV"
        Me.ToolBarV.ShowToolTips = True
        Me.ToolBarV.Size = New System.Drawing.Size(160, 41)
        Me.ToolBarV.TabIndex = 1
        '
        'C1DBGV
        '
        Me.C1DBGV.AllowUpdate = False
        Me.C1DBGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBGV.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGV.Images.Add(CType(resources.GetObject("C1DBGV.Images"), System.Drawing.Image))
        Me.C1DBGV.Location = New System.Drawing.Point(3, 17)
        Me.C1DBGV.Name = "C1DBGV"
        Me.C1DBGV.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGV.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGV.PreviewInfo.ZoomFactor = 75
        Me.C1DBGV.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGV.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGV.Size = New System.Drawing.Size(160, 355)
        Me.C1DBGV.TabIndex = 0
        Me.C1DBGV.Text = "C1TrueDBGrid1"
        Me.C1DBGV.PropBag = resources.GetString("C1DBGV.PropBag")
        '
        'FrmContainerListSummary
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(762, 459)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.GBV)
        Me.Menu = Me.MainMenu
        Me.Name = "FrmContainerListSummary"
        Me.Text = "出口集装箱三表五清单信息"
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tbpLoadSumary.ResumeLayout(False)
        CType(Me.C1DBGSumNew, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DBGSum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpNoList.ResumeLayout(False)
        CType(Me.C1DBGNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpPortList.ResumeLayout(False)
        CType(Me.C1DBGUnloadPort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpBillList.ResumeLayout(False)
        CType(Me.C1DBGBill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpReeferList.ResumeLayout(False)
        CType(Me.C1DBGReefer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpDangerList.ResumeLayout(False)
        CType(Me.C1DBGDanger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpCargoList.ResumeLayout(False)
        CType(Me.C1DBGCargo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpPortSumary.ResumeLayout(False)
        CType(Me.C1DBGPortSum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpHatchBill.ResumeLayout(False)
        CType(Me.C1DBGH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBV.ResumeLayout(False)
        Me.GBV.PerformLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim dsSummary As New DataSet()
    Dim dsCode_port As New DataSet()
    Dim i As Integer = 0
    Dim j As Integer = 0
    Dim row As Integer
    Dim dsshipname As New DataSet()

    Private Sub FrmContainerListSummary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.mnuDelete.Visible = False
        Me.tbbtnDelete.Visible = False
        Me.mnuEdit.Visible = False
        Me.tbbtnEdit.Visible = False
        Me.mnuAdd.Visible = False
        Me.tbbtnAdd.Visible = False
        Me.mnuQuery.Visible = False
        Me.tbbtnQuery.Visible = False

        Me.Text = Me.Text & "_" & G_DeptName

        SortShip = " Order by Ship_Statu,Dept_Code " '默认的排序 

        FirmShip = "where DEPT_CODE LIKE '" & G_DeptCode & "%'" '船舶不变的条件设计
        SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','0')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) "
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
                SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','0')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) " '船舶可变的条件设计

                SortShip = " Order by Ship_Statu,Dept_Code "
                Call myDataGridShip(SqlStrShip & inoutstr & SortShip)


            Case 2
                Dim FrmFind As New FrmFind()
                Table_Name = "SSHIP"
                FrmFind.ShowDialog()

                If Flag = 0 Then
                    Call myDataGridShip(FirmShip & inoutstr & " and (" & Sql_Find & ")  " & SortShip)    '可能要修改
                    SqlStrShip = FirmShip & " and (" & Sql_Find & ")  "    '可能要修改，…………SqlStrShip这个变量根本用不到
                ElseIf Flag = 2 Then    '全选
                    SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','4','0')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) "
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
        Me.ToolBar.Enabled = True
        Me.mnuAdd.Enabled = True
        Me.mnuDelete.Enabled = True
        Me.mnuEdit.Enabled = True
        Me.mnuExport.Enabled = True
        Me.mnuFind.Enabled = True
        Me.mnuPrint.Enabled = True
        Me.mnuQuery.Enabled = True
        Call preview("WL4_16") '*****************权限设计 '*************要修改模块号

        FirmStrNo = " Ship_ID = " & Ship_ID & " and CODE_LOAD_PORT like '%LYG%' order by Container_NO,BillNo,UnloadPort "
        Call myDataGridNo(FirmStrNo)

        FirmStrUnloadPort = " Ship_ID = " & Ship_ID & " and CODE_LOAD_PORT like '%LYG%' order by UnloadPort,Container_NO,BillNo "
        Call myDataGridUnloadPort(FirmStrUnloadPort)

        FirmStrBill = " Ship_ID = " & Ship_ID & " and CODE_LOAD_PORT like '%LYG%' order by BillNo,Container_NO "
        Call myDataGridBill(FirmStrBill)

        FirmStrDanger = " and Ship_ID = " & Ship_ID & " and CODE_LOAD_PORT like '%LYG%'order by BillNo,Container_NO "
        'DynaStr = " ( TypeCon like 'T_' or TypeCon like 'D_') " '设计其它初始条件
        DynaStr = "LEN(DangerGrade) > 0"
        Call myDataGridDanger(DynaStr & FirmStrDanger)

        FirmStrReefer = " and Ship_ID = " & Ship_ID & " and CODE_LOAD_PORT like '%LYG%' order by BillNo,Container_NO "
        DynaStr = " TypeCon like 'R_' "
        Call myDataGridReefer(DynaStr & FirmStrReefer)

        FirmStrCargo = " Ship_ID = " & Ship_ID & " and CODE_LOAD_PORT like '%LYG%' order by BillNo,Container_NO "
        Call myDataGridCargo(FirmStrCargo)

        Call myDataGridSum("")
        Call MyGetGridSumNew()

        Call myDataGridPortSum("")

        Call GetGridHatchBill()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub myDataGridNo(ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            '不显示的列名在最前面
            strsql = "select  *  from View_ContainerNoList  where " & Sql '******要修改

            Me.C1DBGNo.DataSource = Getdata(strsql, dsNo)  ' class dbcontrol getdata fuction
            Table_Name = "View_ContainerNoList" '操作的数据库表名 ''******要修改

            ColNum = 2 '不显示的列数 '******要修改
            For i = 0 To ColNum - 1 '设计不显示的列
                Me.C1DBGNo.Splits(0).DisplayColumns.Item(i).Visible = False
            Next

            Call SetColumnCaptionNo() '设计列标题
            Call SetColumnWidthNo() '设计列宽度
            If dsNo.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumNo(Sql) '设计合计列
            End If
            'Me.C1DBG.FetchRowStyles = True
            Me.C1DBGNo.Refresh()
            Me.C1DBGNo.AllowSort = False
            Me.C1DBGNo.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub myDataGridUnloadPort(ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            '不显示的列名在最前面
            strsql = "select * from View_ContainerNoList  where " & Sql '******要修改

            Me.C1DBGUnloadPort.DataSource = Getdata(strsql, dsUnloadPort)  ' class dbcontrol getdata fuction
            ColNum = 2 '不显示的列数 '******要修改
            Table_Name = "View_ContainerNoList" '操作的数据库表名 ''******要修改

            For i = 0 To ColNum - 1 '设计不显示的列
                Me.C1DBGUnloadPort.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            

            Call SetColumnCaptionUnloadPort() '设计列标题
            Call SetColumnWidthUnloadPort() '设计列宽度
            If dsUnloadPort.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumUnloadPort(Sql) '设计合计列
            End If
            'Me.C1DBG.FetchRowStyles = True
            Me.C1DBGUnloadPort.Refresh()
            Me.C1DBGUnloadPort.AllowSort = False
            Me.C1DBGUnloadPort.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub myDataGridBill(ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            '不显示的列名在最前面
            strsql = "select * from View_ContainerBillList  where " & Sql '******要修改

            Me.C1DBGBill.DataSource = Getdata(strsql, dsBill)  ' class dbcontrol getdata fuction
            ColNum = 2 '不显示的列数 '******要修改
            Table_Name = "View_ContainerBillList" '操作的数据库表名 ''******要修改

            For i = 0 To ColNum - 1 '设计不显示的列
                Me.C1DBGBill.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Me.C1DBGBill.Splits(0).DisplayColumns("DangerGrade").Visible = False
            Me.C1DBGBill.Splits(0).DisplayColumns("ReeferTemp").Visible = False
            Me.C1DBGBill.Splits(0).DisplayColumns("TempUnit").Visible = False

            Call SetColumnCaptionBill() '设计列标题
            Call SetColumnWidthBill() '设计列宽度
            If dsBill.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumBill(Sql) '设计合计列
            End If
            'Me.C1DBG.FetchRowStyles = True
            Me.C1DBGBill.Refresh()
            Me.C1DBGBill.AllowSort = False
            Me.C1DBGBill.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub myDataGridDanger(ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            '不显示的列名在最前面
            strsql = "select * from View_ContainerBillList  where " & Sql '******要修改

            Me.C1DBGDanger.DataSource = Getdata(strsql, dsDanger)  ' class dbcontrol getdata fuction
            ColNum = 2 '不显示的列数 '******要修改
            Table_Name = "View_ContainerBillList" '操作的数据库表名 ''******要修改

            For i = 0 To ColNum - 1 '设计不显示的列
                Me.C1DBGDanger.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Me.C1DBGDanger.Splits(0).DisplayColumns("ReeferTemp").Visible = False
            Me.C1DBGDanger.Splits(0).DisplayColumns("TempUnit").Visible = False

            Call SetColumnCaptionDanger() '设计列标题
            Call SetColumnWidthDanger() '设计列宽度
            If dsDanger.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumDanger(Sql) '设计合计列
            End If
            'Me.C1DBG.FetchRowStyles = True
            Me.C1DBGDanger.Refresh()
            Me.C1DBGDanger.AllowSort = False
            Me.C1DBGDanger.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub myDataGridReefer(ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            '不显示的列名在最前面
            strsql = "select * from View_ContainerBillList  where " & Sql '******要修改

            Me.C1DBGReefer.DataSource = Getdata(strsql, dsReefer)  ' class dbcontrol getdata fuction
            ColNum = 2 '不显示的列数 '******要修改
            Table_Name = "View_ContainerBillList" '操作的数据库表名 ''******要修改

            For i = 0 To ColNum - 1 '设计不显示的列
                Me.C1DBGReefer.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Me.C1DBGReefer.Splits(0).DisplayColumns("DangerGrade").Visible = False

            Call SetColumnCaptionReefer() '设计列标题
            Call SetColumnWidthReefer() '设计列宽度
            If dsReefer.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumReefer(Sql) '设计合计列
            End If
            'Me.C1DBG.FetchRowStyles = True
            Me.C1DBGReefer.Refresh()
            Me.C1DBGReefer.AllowSort = False
            Me.C1DBGReefer.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub myDataGridCargo(ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            '不显示的列名在最前面
            strsql = "select  *  from View_ContainerBillList  where " & Sql '******要修改

            Me.C1DBGCargo.DataSource = Getdata(strsql, dsCargo)  ' class dbcontrol getdata fuction
            ColNum = 2 '不显示的列数 '******要修改
            Table_Name = "View_ContainerBillList" '操作的数据库表名 ''******要修改

            For i = 0 To ColNum - 1 '设计不显示的列
                Me.C1DBGCargo.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Me.C1DBGCargo.Splits(0).DisplayColumns("DangerGrade").Visible = False
            Me.C1DBGCargo.Splits(0).DisplayColumns("ReeferTemp").Visible = False
            Me.C1DBGCargo.Splits(0).DisplayColumns("TempUnit").Visible = False


            Call SetColumnCaptionCargo() '设计列标题
            Call SetColumnWidthCargo() '设计列宽度
            If dsCargo.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumCargo(Sql) '设计合计列
            End If
            'Me.C1DBG.FetchRowStyles = True
            Me.C1DBGCargo.Refresh()
            Me.C1DBGCargo.AllowSort = True
            Me.C1DBGCargo.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub myDataGridSum(ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            '不显示的列名在最前面
            strsql = "SELECT CODE_UNLOAD_PORT, MAX(UNLOAD_PORT) AS UnloadPort, FULLOREMPTY, CONTAINER_TYPE, SIZE_CON, COUNT(*) AS ConNum, SUM(WEIGHT) AS ConWeight FROM View_ContainerLoadingSumary WHERE (CODE_LOAD_PORT like '%LYG%') AND (SHIP_ID = '" & Ship_ID & "') GROUP BY CODE_UNLOAD_PORT, FULLOREMPTY, CONTAINER_TYPE, SIZE_CON ORDER BY CODE_UNLOAD_PORT, FULLOREMPTY, CONTAINER_TYPE, SIZE_CON"

            Me.C1DBGSum.DataSource = Getdata(strsql, dsSum)  ' class dbcontrol getdata fuction
            ColNum = 1 '不显示的列数 '******要修改
            Table_Name = "View_ContainerLoadingSumary" '操作的数据库表名 ''******要修改

            For i = 0 To ColNum - 1 '设计不显示的列
                Me.C1DBGSum.Splits(0).DisplayColumns.Item(i).Visible = False
            Next

            Call SetColumnCaptionSum() '设计列标题
            Call SetColumnWidthSum() '设计列宽度
            If dsSum.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumSum(Sql) '设计合计列
            End If
            'Me.C1DBG.FetchRowStyles = True
            Me.C1DBGSum.Refresh()
            Me.C1DBGSum.AllowSort = True
            Me.C1DBGSum.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub myDataGridPortSum(ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            '不显示的列名在最前面
            strsql = "SELECT CODE_UNLOAD_PORT, MAX(UNLOAD_PORT) AS UnloadPort, FULLOREMPTY, SIZE_CON, COUNT(*) AS ConNum, SUM(AMOUNT) AS ConQuantity, SUM(WEIGHT) AS ConWeight, SUM(VOLUME) AS Size FROM View_ContainerLoadingSumary WHERE (CODE_LOAD_PORT like '%LYG%') AND (SHIP_ID = '" & Ship_ID & "') GROUP BY CODE_UNLOAD_PORT, FULLOREMPTY, SIZE_CON ORDER BY CODE_UNLOAD_PORT, FULLOREMPTY, SIZE_CON"
            Me.C1DBGPortSum.DataSource = Getdata(strsql, dsPortSum)  ' class dbcontrol getdata fuction
            ColNum = 1 '不显示的列数 '******要修改
            Table_Name = "View_ContainerLoadingSumary" '操作的数据库表名 ''******要修改

            For i = 0 To ColNum - 1 '设计不显示的列
                Me.C1DBGPortSum.Splits(0).DisplayColumns.Item(i).Visible = False
            Next

            Call SetColumnCaptionPortSum() '设计列标题
            Call SetColumnWidthPortSum() '设计列宽度
            If dsPortSum.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumPortSum(Sql) '设计合计列
            End If
            'Me.C1DBG.FetchRowStyles = True
            Me.C1DBGPortSum.Refresh()
            Me.C1DBGPortSum.AllowSort = True
            Me.C1DBGPortSum.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub SetColumnCaptionNo()
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

            Do While i < Me.C1DBGNo.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = _
                        Upper(Trim(Me.C1DBGNo.Columns.Item(i).DataField.ToString)) Then
                        Me.C1DBGNo.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
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

    Private Sub SetColumnSumNo(ByVal sql As String)
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
        Me.C1DBGNo.ColumnFooters = True
        Me.C1DBGNo.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGNo.Columns.Item(ColNum).FooterText = "合计 共" & dsNo.Tables(0).Rows.Count & "条"

        Do While i < Me.C1DBGNo.Columns.Count
            j = 0
            For j = 0 To dset.Tables(0).Rows.Count - 1

                If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGNo.Columns.Item(i).DataField.ToString)) _
                    And Upper(Trim(dset.Tables(0).Rows(j)("Field_Type"))) = "N" And Trim(dset.Tables(0).Rows(j)("IsOrNoSum")) = "1" Then

                    num = 0
                    For m = 0 To dsNo.Tables(0).Rows.Count - 1
                        num = num + dsNo.Tables(0).Rows(m)(i)
                    Next
                    Me.C1DBGNo.Columns.Item(i).FooterText = CType(num, String)
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

    Private Sub SetColumnWidthNo()
        Try
            Dim j As Integer
            For j = 0 To Me.C1DBGNo.Columns.Count - 1
                Me.C1DBGNo.Splits(0).DisplayColumns.Item(j).AutoSize()
                Me.C1DBGNo.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                If Me.C1DBGNo.Splits(0).DisplayColumns.Item(j).Width < 65 Then
                    Me.C1DBGNo.Splits(0).DisplayColumns.Item(j).Width = 65
                Else
                    If Me.C1DBGNo.Splits(0).DisplayColumns.Item(j).Width > 130 Then
                        Me.C1DBGNo.Splits(0).DisplayColumns.Item(j).Width = 130
                    End If
                End If
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaptionUnloadPort()
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

            Do While i < Me.C1DBGUnloadPort.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = _
                        Upper(Trim(Me.C1DBGUnloadPort.Columns.Item(i).DataField.ToString)) Then
                        Me.C1DBGUnloadPort.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
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

    Private Sub SetColumnSumUnloadPort(ByVal sql As String)
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
        Me.C1DBGUnloadPort.ColumnFooters = True
        Me.C1DBGUnloadPort.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGUnloadPort.Columns.Item(ColNum).FooterText = "合计 共" & dsUnloadPort.Tables(0).Rows.Count & "条"

        Do While i < Me.C1DBGUnloadPort.Columns.Count
            j = 0
            For j = 0 To dset.Tables(0).Rows.Count - 1

                If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGUnloadPort.Columns.Item(i).DataField.ToString)) _
                    And Upper(Trim(dset.Tables(0).Rows(j)("Field_Type"))) = "N" And Trim(dset.Tables(0).Rows(j)("IsOrNoSum")) = "1" Then

                    num = 0
                    For m = 0 To dsUnloadPort.Tables(0).Rows.Count - 1
                        num = num + dsUnloadPort.Tables(0).Rows(m)(i)
                    Next
                    Me.C1DBGUnloadPort.Columns.Item(i).FooterText = CType(num, String)
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

    Private Sub SetColumnWidthUnloadPort()
        Try
            Dim j As Integer
            For j = 0 To Me.C1DBGUnloadPort.Columns.Count - 1
                Me.C1DBGUnloadPort.Splits(0).DisplayColumns.Item(j).AutoSize()
                Me.C1DBGUnloadPort.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                If Me.C1DBGUnloadPort.Splits(0).DisplayColumns.Item(j).Width < 65 Then
                    Me.C1DBGUnloadPort.Splits(0).DisplayColumns.Item(j).Width = 65
                Else
                    If Me.C1DBGUnloadPort.Splits(0).DisplayColumns.Item(j).Width > 130 Then
                        Me.C1DBGUnloadPort.Splits(0).DisplayColumns.Item(j).Width = 130
                    End If
                End If
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaptionBill()
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

            Do While i < Me.C1DBGBill.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = _
                        Upper(Trim(Me.C1DBGBill.Columns.Item(i).DataField.ToString)) Then
                        Me.C1DBGBill.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
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

    Private Sub SetColumnSumBill(ByVal sql As String)
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
        Me.C1DBGBill.ColumnFooters = True
        Me.C1DBGBill.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGBill.Columns.Item(ColNum).FooterText = "合计 共" & dsBill.Tables(0).Rows.Count & "条"

        Do While i < Me.C1DBGBill.Columns.Count
            j = 0
            For j = 0 To dset.Tables(0).Rows.Count - 1

                If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGBill.Columns.Item(i).DataField.ToString)) _
                    And Upper(Trim(dset.Tables(0).Rows(j)("Field_Type"))) = "N" And Trim(dset.Tables(0).Rows(j)("IsOrNoSum")) = "1" Then

                    num = 0
                    For m = 0 To dsBill.Tables(0).Rows.Count - 1
                        num = num + dsBill.Tables(0).Rows(m)(i)
                    Next
                    Me.C1DBGBill.Columns.Item(i).FooterText = CType(num, String)
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

    Private Sub SetColumnWidthBill()
        Try
            Dim j As Integer
            For j = 0 To Me.C1DBGBill.Columns.Count - 1
                Me.C1DBGBill.Splits(0).DisplayColumns.Item(j).AutoSize()
                Me.C1DBGBill.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                If Me.C1DBGBill.Splits(0).DisplayColumns.Item(j).Width < 65 Then
                    Me.C1DBGBill.Splits(0).DisplayColumns.Item(j).Width = 65
                Else
                    If Me.C1DBGBill.Splits(0).DisplayColumns.Item(j).Width > 130 Then
                        Me.C1DBGBill.Splits(0).DisplayColumns.Item(j).Width = 130
                    End If
                End If
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaptionDanger()
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

            Do While i < Me.C1DBGDanger.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = _
                        Upper(Trim(Me.C1DBGDanger.Columns.Item(i).DataField.ToString)) Then
                        Me.C1DBGDanger.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
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

    Private Sub SetColumnSumDanger(ByVal sql As String)
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
        Me.C1DBGDanger.ColumnFooters = True
        Me.C1DBGDanger.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGDanger.Columns.Item(ColNum).FooterText = "合计 共" & dsDanger.Tables(0).Rows.Count & "条"

        Do While i < Me.C1DBGDanger.Columns.Count
            j = 0
            For j = 0 To dset.Tables(0).Rows.Count - 1

                If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGDanger.Columns.Item(i).DataField.ToString)) _
                    And Upper(Trim(dset.Tables(0).Rows(j)("Field_Type"))) = "N" And Trim(dset.Tables(0).Rows(j)("IsOrNoSum")) = "1" Then

                    num = 0
                    For m = 0 To dsDanger.Tables(0).Rows.Count - 1
                        num = num + dsDanger.Tables(0).Rows(m)(i)
                    Next
                    Me.C1DBGDanger.Columns.Item(i).FooterText = CType(num, String)
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

    Private Sub SetColumnWidthDanger()
        Try
            Dim j As Integer
            For j = 0 To Me.C1DBGDanger.Columns.Count - 1
                Me.C1DBGDanger.Splits(0).DisplayColumns.Item(j).AutoSize()
                Me.C1DBGDanger.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                If Me.C1DBGDanger.Splits(0).DisplayColumns.Item(j).Width < 65 Then
                    Me.C1DBGDanger.Splits(0).DisplayColumns.Item(j).Width = 65
                Else
                    If Me.C1DBGDanger.Splits(0).DisplayColumns.Item(j).Width > 130 Then
                        Me.C1DBGDanger.Splits(0).DisplayColumns.Item(j).Width = 130
                    End If
                End If
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaptionReefer()
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

            Do While i < Me.C1DBGReefer.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = _
                        Upper(Trim(Me.C1DBGReefer.Columns.Item(i).DataField.ToString)) Then
                        Me.C1DBGReefer.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
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

    Private Sub SetColumnSumReefer(ByVal sql As String)
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
        Me.C1DBGReefer.ColumnFooters = True
        Me.C1DBGReefer.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGReefer.Columns.Item(ColNum).FooterText = "合计 共" & dsReefer.Tables(0).Rows.Count & "条"

        Do While i < Me.C1DBGReefer.Columns.Count
            j = 0
            For j = 0 To dset.Tables(0).Rows.Count - 1

                If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGReefer.Columns.Item(i).DataField.ToString)) _
                    And Upper(Trim(dset.Tables(0).Rows(j)("Field_Type"))) = "N" And Trim(dset.Tables(0).Rows(j)("IsOrNoSum")) = "1" Then

                    num = 0
                    For m = 0 To dsReefer.Tables(0).Rows.Count - 1
                        num = num + dsReefer.Tables(0).Rows(m)(i)
                    Next
                    Me.C1DBGReefer.Columns.Item(i).FooterText = CType(num, String)
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

    Private Sub SetColumnWidthReefer()
        Try
            Dim j As Integer
            For j = 0 To Me.C1DBGReefer.Columns.Count - 1
                Me.C1DBGReefer.Splits(0).DisplayColumns.Item(j).AutoSize()
                Me.C1DBGReefer.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                If Me.C1DBGReefer.Splits(0).DisplayColumns.Item(j).Width < 65 Then
                    Me.C1DBGReefer.Splits(0).DisplayColumns.Item(j).Width = 65
                Else
                    If Me.C1DBGReefer.Splits(0).DisplayColumns.Item(j).Width > 130 Then
                        Me.C1DBGReefer.Splits(0).DisplayColumns.Item(j).Width = 130
                    End If
                End If
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaptionCargo()
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

            Do While i < Me.C1DBGCargo.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = _
                        Upper(Trim(Me.C1DBGCargo.Columns.Item(i).DataField.ToString)) Then
                        Me.C1DBGCargo.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
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

    Private Sub SetColumnSumCargo(ByVal sql As String)
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
        Me.C1DBGCargo.ColumnFooters = True
        Me.C1DBGCargo.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGCargo.Columns.Item(ColNum).FooterText = "合计 共" & dsCargo.Tables(0).Rows.Count & "条"

        Do While i < Me.C1DBGCargo.Columns.Count
            j = 0
            For j = 0 To dset.Tables(0).Rows.Count - 1

                If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGCargo.Columns.Item(i).DataField.ToString)) _
                    And Upper(Trim(dset.Tables(0).Rows(j)("Field_Type"))) = "N" And Trim(dset.Tables(0).Rows(j)("IsOrNoSum")) = "1" Then

                    num = 0
                    For m = 0 To dsCargo.Tables(0).Rows.Count - 1
                        num = num + dsCargo.Tables(0).Rows(m)(i)
                    Next
                    Me.C1DBGCargo.Columns.Item(i).FooterText = CType(num, String)
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

    Private Sub SetColumnWidthCargo()
        Try
            Dim j As Integer
            For j = 0 To Me.C1DBGCargo.Columns.Count - 1
                Me.C1DBGCargo.Splits(0).DisplayColumns.Item(j).AutoSize()
                Me.C1DBGCargo.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                If Me.C1DBGCargo.Splits(0).DisplayColumns.Item(j).Width < 65 Then
                    Me.C1DBGCargo.Splits(0).DisplayColumns.Item(j).Width = 65
                Else
                    If Me.C1DBGCargo.Splits(0).DisplayColumns.Item(j).Width > 130 Then
                        Me.C1DBGCargo.Splits(0).DisplayColumns.Item(j).Width = 130
                    End If
                End If
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaptionSum()
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

            Do While i < Me.C1DBGSum.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = _
                        Upper(Trim(Me.C1DBGSum.Columns.Item(i).DataField.ToString)) Then
                        Me.C1DBGSum.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
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

    Private Sub SetColumnSumSum(ByVal sql As String)
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
        Me.C1DBGSum.ColumnFooters = True
        Me.C1DBGSum.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGSum.Columns.Item(ColNum).FooterText = "合计 共" & dsSum.Tables(0).Rows.Count & "条"

        Do While i < Me.C1DBGSum.Columns.Count
            j = 0
            For j = 0 To dset.Tables(0).Rows.Count - 1

                If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGSum.Columns.Item(i).DataField.ToString)) _
                    And Upper(Trim(dset.Tables(0).Rows(j)("Field_Type"))) = "N" And Trim(dset.Tables(0).Rows(j)("IsOrNoSum")) = "1" Then

                    num = 0
                    For m = 0 To dsSum.Tables(0).Rows.Count - 1
                        num = num + dsSum.Tables(0).Rows(m)(i)
                    Next
                    Me.C1DBGSum.Columns.Item(i).FooterText = CType(num, String)
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

    Private Sub SetColumnWidthSum()
        Try
            Dim j As Integer
            For j = 0 To Me.C1DBGSum.Columns.Count - 1
                Me.C1DBGSum.Splits(0).DisplayColumns.Item(j).AutoSize()
                Me.C1DBGSum.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                If Me.C1DBGSum.Splits(0).DisplayColumns.Item(j).Width < 65 Then
                    Me.C1DBGSum.Splits(0).DisplayColumns.Item(j).Width = 65
                Else
                    If Me.C1DBGSum.Splits(0).DisplayColumns.Item(j).Width > 130 Then
                        Me.C1DBGSum.Splits(0).DisplayColumns.Item(j).Width = 130
                    End If
                End If
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaptionPortSum()
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

            Do While i < Me.C1DBGPortSum.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = _
                        Upper(Trim(Me.C1DBGPortSum.Columns.Item(i).DataField.ToString)) Then
                        Me.C1DBGPortSum.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
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

    Private Sub SetColumnSumPortSum(ByVal sql As String)
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
        Me.C1DBGPortSum.ColumnFooters = True
        Me.C1DBGPortSum.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGPortSum.Columns.Item(ColNum).FooterText = "合计 共" & dsPortSum.Tables(0).Rows.Count & "条"

        Do While i < Me.C1DBGPortSum.Columns.Count
            j = 0
            For j = 0 To dset.Tables(0).Rows.Count - 1

                If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.C1DBGPortSum.Columns.Item(i).DataField.ToString)) _
                    And Upper(Trim(dset.Tables(0).Rows(j)("Field_Type"))) = "N" And Trim(dset.Tables(0).Rows(j)("IsOrNoSum")) = "1" Then

                    num = 0
                    For m = 0 To dsPortSum.Tables(0).Rows.Count - 1
                        num = num + dsPortSum.Tables(0).Rows(m)(i)
                    Next
                    Me.C1DBGPortSum.Columns.Item(i).FooterText = CType(num, String)
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

    Private Sub SetColumnWidthPortSum()
        Try
            Dim j As Integer
            For j = 0 To Me.C1DBGPortSum.Columns.Count - 1
                Me.C1DBGPortSum.Splits(0).DisplayColumns.Item(j).AutoSize()
                Me.C1DBGPortSum.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

                If Me.C1DBGPortSum.Splits(0).DisplayColumns.Item(j).Width < 65 Then
                    Me.C1DBGPortSum.Splits(0).DisplayColumns.Item(j).Width = 65
                Else
                    If Me.C1DBGPortSum.Splits(0).DisplayColumns.Item(j).Width > 130 Then
                        Me.C1DBGPortSum.Splits(0).DisplayColumns.Item(j).Width = 130
                    End If
                End If
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim dvHatchBill As New DataView

    Private Sub GetGridHatchBill()
        Dim sqlgetHatchBill As String
        sqlgetHatchBill = "SELECT SHIP_ID, BLNO, CONTAINER_NO, SEALNO, SIZE_CON, CONTAINER_TYPE, AMOUNT, PACK, GrossWEIGHT, WEIGHT, VOLUME, LOAD_DATE, EFL_Name, KEEPER, TempUnit, ReeferTemp, MIN_TEMPERATURE, MAX_TEMPERATURE " & _
                            " FROM View_HatchCargoH WHERE (SHIP_ID = '" & Ship_ID & "') ORDER BY BLNO, CONTAINER_NO"
        dvHatchBill = Filldata(sqlgetHatchBill)
        Me.C1DBGH.DataSource = dvHatchBill
        Dim i As Integer
        For i = 0 To Me.C1DBGH.Columns.Count - 1
            Me.C1DBGH.Splits(0).DisplayColumns(i).Width = 60
        Next
        Me.C1DBGH.Splits(0).DisplayColumns("BLNO").Width = 90
        Me.C1DBGH.Splits(0).DisplayColumns("CONTAINER_NO").Width = 90
        Me.C1DBGH.Splits(0).DisplayColumns("SIZE_CON").Width = 40
        Me.C1DBGH.Splits(0).DisplayColumns("CONTAINER_TYPE").Width = 40
        Me.C1DBGH.Splits(0).DisplayColumns("EFL_Name").Width = 40
        Me.C1DBGH.Splits(0).DisplayColumns("TempUnit").Width = 40

        Me.C1DBGH.Columns("BLNO").Caption = "提单号"
        Me.C1DBGH.Columns("CONTAINER_NO").Caption = "箱号"
        Me.C1DBGH.Columns("SEALNO").Caption = "封号"
        Me.C1DBGH.Columns("SIZE_CON").Caption = "箱尺寸"
        Me.C1DBGH.Columns("CONTAINER_TYPE").Caption = "箱型"
        Me.C1DBGH.Columns("AMOUNT").Caption = "件数"
        Me.C1DBGH.Columns("PACK").Caption = "包装"
        Me.C1DBGH.Columns("GrossWEIGHT").Caption = "毛重"
        Me.C1DBGH.Columns("WEIGHT").Caption = "货重"
        Me.C1DBGH.Columns("VOLUME").Caption = "尺码"
        Me.C1DBGH.Columns("LOAD_DATE").Caption = "装货日期"
        Me.C1DBGH.Columns("EFL_Name").Caption = "箱状态"
        Me.C1DBGH.Columns("KEEPER").Caption = "箱经营人"
        Me.C1DBGH.Columns("TempUnit").Caption = "温标"
        Me.C1DBGH.Columns("ReeferTemp").Caption = "设置温度"
        Me.C1DBGH.Columns("MIN_TEMPERATURE").Caption = "最低温"
        Me.C1DBGH.Columns("MAX_TEMPERATURE").Caption = "最高温"

        Me.C1DBGH.Splits(0).DisplayColumns("Ship_ID").Visible = False
        Me.C1DBGH.AllowSort = False
        Me.C1DBGH.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        Me.C1DBGH.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGH.ColumnFooters = True
        Me.C1DBGH.Columns("Container_No").FooterText = "计" & dvHatchBill.Count & "项"

    End Sub

    Private Sub GetSheetHatchBill()
        Dim strVessel, strVoyage As String
        strVessel = dwship.Item(0)("ENG_VESSEL")
        strVoyage = dwship.Item(0)("Voyage")
        Try
            Dim path As String 
            Dim svPath As New SaveFileDialog
            svPath.RestoreDirectory = True
            svPath.AddExtension = True
            svPath.DefaultExt = "xls"
            svPath.Filter = "Excel文件(*.xls)|*.xls"
            svPath.InitialDirectory = "d:\edi\"
            svPath.FileName = strVessel & strVoyage
            Dim asd As New OpenFileDialog

            If svPath.ShowDialog = DialogResult.OK Then
                path = svPath.FileName
            Else
                Exit Sub
            End If

            Dim PathStr As String
            Dim FilePath As String
            Dim Row As Integer
            Dim Col As Integer
            PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
            PathStr = substr(PathStr)

            File.Copy(PathStr & "中海舱单.xls", path, True)

            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            xlBook = CType(xlApp.Workbooks.Open("" & path & ""), Excel.Workbook)
            xlSheet = CType(xlBook.Worksheets("舱单"), Excel.Worksheet)
            xlBook.Sheets("舱单").select()

            xlApp.DisplayAlerts = False
            xlApp.Visible = False
            'If PrintMark = False Then   '打印不显示，导出显示
            '    xlSheet.Application.Visible = True
            'End If

            Dim i As Integer
            For i = 0 To dvHatchBill.Count - 1
                xlSheet.Cells(i + 8, 1) = Me.C1DBGH.Columns("BLNO").CellText(i)
                xlSheet.Cells(i + 8, 2) = Me.C1DBGH.Columns("CONTAINER_NO").CellText(i)
                xlSheet.Cells(i + 8, 3) = Me.C1DBGH.Columns("SEALNO").CellText(i)
                xlSheet.Cells(i + 8, 4) = Me.C1DBGH.Columns("SIZE_CON").CellText(i) & Me.C1DBGH.Columns("CONTAINER_TYPE").CellText(i)
                'xlSheet.Cells(i + 8, 1) = Me.C1DBGH.Columns("CONTAINER_TYPE").CellText(i)
                If Me.C1DBGH.Columns("AMOUNT").CellText(i) <> "0" Then
                    xlSheet.Cells(i + 8, 5) = Me.C1DBGH.Columns("AMOUNT").CellText(i)
                End If
                xlSheet.Cells(i + 8, 6) = Me.C1DBGH.Columns("PACK").CellText(i)
                'xlSheet.Cells(i + 8, 7) = Me.C1DBGH.Columns("GrossWEIGHT").CellText(i)
                If Me.C1DBGH.Columns("WEIGHT").CellText(i) <> "0" Then
                    xlSheet.Cells(i + 8, 7) = Me.C1DBGH.Columns("WEIGHT").CellText(i)
                End If
                If Me.C1DBGH.Columns("VOLUME").CellText(i) <> "0" Then
                    xlSheet.Cells(i + 8, 8) = Me.C1DBGH.Columns("VOLUME").CellText(i)
                End If
                If IsDate(Me.C1DBGH.Columns("LOAD_DATE").CellText(i)) Then
                    xlSheet.Cells(i + 8, 9) = CDate(Me.C1DBGH.Columns("LOAD_DATE").CellText(i)).Date
                End If
                xlSheet.Cells(i + 8, 10) = Me.C1DBGH.Columns("EFL_Name").CellText(i)
                xlSheet.Cells(i + 8, 11) = Me.C1DBGH.Columns("KEEPER").CellText(i)
                xlSheet.Cells(i + 8, 12) = Me.C1DBGH.Columns("TempUnit").CellText(i)
                xlSheet.Cells(i + 8, 13) = Me.C1DBGH.Columns("ReeferTemp").CellText(i)
                xlSheet.Cells(i + 8, 14) = Me.C1DBGH.Columns("MIN_TEMPERATURE").CellText(i)
                xlSheet.Cells(i + 8, 15) = Me.C1DBGH.Columns("MAX_TEMPERATURE").CellText(i)

            Next
            xlSheet.Cells(4, 2) = strVessel
            xlSheet.Cells(4, 7) = strVoyage
            xlBook.Save()
            xlApp.Quit()

            If PrintMark = True Then   '打印
                xlSheet.PrintOut()
                xlApp.Quit()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GetSheetExcelNo()
        Dim strVessel, strVoyage As String
        Dim ListDate As Date
        strVessel = dwship.Item(0)("ENG_VESSEL")
        strVoyage = dwship.Item(0)("Voyage")
        ListDate = Now.Date
        Dim i, iRemainder, iResult, iRemainderSub, iResultSub As Integer
        'iResult当前页之前有几页 iRemainder当前页第几条记录 iResultSub当前页当前纵列之前有几列 iRemainderSub当前页第几行
        Dim rowNum As Integer   '一页的行数

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
            xlSheet = CType(xlBook.Worksheets(8), Excel.Worksheet)
            xlSheet.Select(8)
            xlApp.DisplayAlerts = False
            If PrintMark = False Then   '打印不显示，导出显示
                xlSheet.Application.Visible = True
            End If

            For i = 0 To dsNo.Tables(0).Rows.Count - 1
                'iResult = (i + 1) / 90
                'iRemainder = (i + 1) - iResult * 90
                'iResultSub = iRemainder / 30
                'iRemainderSub = iRemainder - iResultSub * 30

                'xlSheet.Cells(iResult * 30 + iRemainderSub + 7, iResultSub * 4 + 1) = i + 1
                'xlSheet.Cells(iResult * 30 + iRemainderSub + 7, iResultSub * 4 + 2) = Me.C1DBG.Columns("CONTAINER_NO").CellValue(i)
                'xlSheet.Cells(iResult * 30 + iRemainderSub + 7, iResultSub * 4 + 3) = Me.C1DBG.Columns("BillNo").CellValue(i)
                'xlSheet.Cells(iResult * 30 + iRemainderSub + 7, iResultSub * 4 + 4) = Me.C1DBG.Columns("UnloadPort").CellValue(i)

                If i < Fix(dsNo.Tables(0).Rows.Count / 120) * 120 Then '不是最后一页
                    iResult = Fix(i / 120)       '每页九十条记录，三大纵列，三十行
                    iRemainder = i - iResult * 120
                    iResultSub = Fix(iRemainder / 40)
                    iRemainderSub = iRemainder - iResultSub * 40

                    xlSheet.Cells(iResult * 40 + iRemainderSub + 8, iResultSub * 4 + 1) = i + 1
                    xlSheet.Cells(iResult * 40 + iRemainderSub + 8, iResultSub * 4 + 2) = Me.C1DBGNo.Columns("CONTAINER_NO").CellValue(i)
                    xlSheet.Cells(iResult * 40 + iRemainderSub + 8, iResultSub * 4 + 3) = Me.C1DBGNo.Columns("BillNo").CellValue(i)
                    xlSheet.Cells(iResult * 40 + iRemainderSub + 8, iResultSub * 4 + 4) = Me.C1DBGNo.Columns("UnloadPort").CellValue(i)
                Else    '最后一页
                    If i = Fix(dsNo.Tables(0).Rows.Count / 120) * 120 Then
                        iResult = Fix(i / 120)       '这一页(dsNo.Tables(0).Rows.Count Mod 90)条记录，三大纵列，这一页rowNum行
                        rowNum = Fix((dsNo.Tables(0).Rows.Count Mod 120 + 2) / 3)
                    End If
                    iRemainder = i Mod 120
                    'iRemainder = i - iResult * 90
                    iResultSub = Fix(iRemainder / rowNum)
                    iRemainderSub = iRemainder Mod rowNum
                    'iRemainderSub = iRemainder - iResultSub * colNum

                    xlSheet.Cells(iResult * 40 + iRemainderSub + 8, iResultSub * 4 + 1) = i + 1
                    xlSheet.Cells(iResult * 40 + iRemainderSub + 8, iResultSub * 4 + 2) = Me.C1DBGNo.Columns("CONTAINER_NO").CellValue(i)
                    xlSheet.Cells(iResult * 40 + iRemainderSub + 8, iResultSub * 4 + 3) = Me.C1DBGNo.Columns("BillNo").CellValue(i)
                    xlSheet.Cells(iResult * 40 + iRemainderSub + 8, iResultSub * 4 + 4) = Me.C1DBGNo.Columns("UnloadPort").CellValue(i)

                End If
            Next
            If dsNo.Tables(0).Rows.Count Mod 120 > 0 Then
                i = iResult * 40 + rowNum + 7
            Else
                i = (iResult + 1) * 40 + 7
            End If
            xlSheet.Cells.Range(xlSheet.Cells(i, 1), xlSheet.Cells(i, 12)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
            xlSheet.Cells.Range(xlSheet.Cells(8, 4), xlSheet.Cells(i, 4)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = 2
            xlSheet.Cells.Range(xlSheet.Cells(8, 8), xlSheet.Cells(i, 8)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = 2
            'xlSheet.Cells(iResult * 30 + rowNum + 8, 6) = "———————————————————————————————————————————————————————————————————————————————————————————————————————————"
            xlSheet.Cells(4, 12) = ListDate
            xlSheet.Cells(4, 2) = strVessel
            xlSheet.Cells(4, 5) = strVoyage
            xlSheet.Cells(1, 5) = "CONTAINER  NUMERIC  LIST"
            xlSheet.Cells(2, 5) = "集装箱箱号排序表"
            If PrintMark = True Then   '打印
                xlSheet.PrintOut()
                xlApp.Quit()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub GetSheetExcelUnloadPort()
        Dim strVessel, strVoyage As String
        Dim ListDate As Date
        strVessel = dwship.Item(0)("ENG_VESSEL")
        strVoyage = dwship.Item(0)("Voyage")
        ListDate = Now.Date
        Dim i, iRemainder, iResult, iRemainderSub, iResultSub As Integer
        Dim rowNum As Integer   '一页的行数

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
            xlSheet = CType(xlBook.Worksheets(8), Excel.Worksheet)
            xlSheet.Select(8)
            xlApp.DisplayAlerts = False
            If PrintMark = False Then   '打印不显示，导出显示
                xlSheet.Application.Visible = True
            End If

            For i = 0 To dsUnloadPort.Tables(0).Rows.Count - 1
                If i < Fix(dsUnloadPort.Tables(0).Rows.Count / 120) * 120 Then '不是最后一页
                    iResult = Fix(i / 120)       '每页九十条记录，三大纵列，三十行
                    iRemainder = i - iResult * 120
                    iResultSub = Fix(iRemainder / 40)
                    iRemainderSub = iRemainder - iResultSub * 40

                    xlSheet.Cells(iResult * 40 + iRemainderSub + 8, iResultSub * 4 + 1) = i + 1
                    xlSheet.Cells(iResult * 40 + iRemainderSub + 8, iResultSub * 4 + 2) = Me.C1DBGUnloadPort.Columns("CONTAINER_NO").CellValue(i)
                    xlSheet.Cells(iResult * 40 + iRemainderSub + 8, iResultSub * 4 + 3) = Me.C1DBGUnloadPort.Columns("BillNo").CellValue(i)
                    xlSheet.Cells(iResult * 40 + iRemainderSub + 8, iResultSub * 4 + 4) = Me.C1DBGUnloadPort.Columns("UnloadPort").CellValue(i)
                Else    '最后一页
                    If i = Fix(dsUnloadPort.Tables(0).Rows.Count / 120) * 120 Then
                        iResult = Fix(i / 120)       '这一页(dsNo.Tables(0).Rows.Count Mod 90)条记录，三大纵列，这一页rowNum行
                        rowNum = Fix((dsNo.Tables(0).Rows.Count Mod 120 + 2) / 3)
                    End If
                    iRemainder = i Mod 120
                    'iRemainder = i - iResult * 90
                    iResultSub = Fix(iRemainder / rowNum)
                    iRemainderSub = iRemainder Mod rowNum
                    'iRemainderSub = iRemainder - iResultSub * colNum

                    xlSheet.Cells(iResult * 40 + iRemainderSub + 8, iResultSub * 4 + 1) = i + 1
                    xlSheet.Cells(iResult * 40 + iRemainderSub + 8, iResultSub * 4 + 2) = Me.C1DBGUnloadPort.Columns("CONTAINER_NO").CellValue(i)
                    xlSheet.Cells(iResult * 40 + iRemainderSub + 8, iResultSub * 4 + 3) = Me.C1DBGUnloadPort.Columns("BillNo").CellValue(i)
                    xlSheet.Cells(iResult * 40 + iRemainderSub + 8, iResultSub * 4 + 4) = Me.C1DBGUnloadPort.Columns("UnloadPort").CellValue(i)

                End If
            Next
            If dsUnloadPort.Tables(0).Rows.Count Mod 120 > 0 Then
                i = iResult * 40 + rowNum + 7
            Else
                i = (iResult + 1) * 40 + 7
            End If

            xlSheet.Cells.Range(xlSheet.Cells(i, 1), xlSheet.Cells(i, 12)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
            xlSheet.Cells.Range(xlSheet.Cells(8, 4), xlSheet.Cells(i, 4)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = 2
            xlSheet.Cells.Range(xlSheet.Cells(8, 8), xlSheet.Cells(i, 8)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = 2
            'xlSheet.Cells(iResult * 30 + rowNum + 8, 6) = "———————————————————————————————————————————————————————————————————————————————————————————————————————————"
            xlSheet.Cells(4, 12) = ListDate
            xlSheet.Cells(4, 2) = strVessel
            xlSheet.Cells(4, 5) = strVoyage
            xlSheet.Cells(1, 5) = "CONTAINER  NUMERIC  LIST"
            xlSheet.Cells(2, 5) = "卸货港排序表"

            If PrintMark = True Then   '打印
                xlSheet.PrintOut()
                xlApp.Quit()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub GetSheetExcelBill()
        Dim strVessel, strVoyage As String
        Dim ListDate As Date
        strVessel = dwship.Item(0)("ENG_VESSEL")
        strVoyage = dwship.Item(0)("Voyage")
        ListDate = Now.Date
        Dim Sum20, Sum40, Sum45, Sum58 As Integer
        Dim packAmount As Integer
        Dim Measument, NetWeight, TareWeight, GrossWeight As Decimal
        Dim i As Integer
        Sum20 = 0
        Sum40 = 0
        Sum45 = 0
        Sum58 = 0
        packAmount = 0
        NetWeight = 0.0
        TareWeight = 0.0
        GrossWeight = 0.0
        Measument = 0.0
        For i = 0 To dsBill.Tables(0).Rows.Count - 1
            If Not IsDBNull(C1DBGBill.Columns("SizeCon").CellValue(i)) Then
                If Me.C1DBGBill.Columns("SizeCon").CellValue(i) = 20 Then
                    Sum20 += 1
                ElseIf Me.C1DBGBill.Columns("SizeCon").CellValue(i) = 40 Then
                    Sum40 += 1
                ElseIf Me.C1DBGBill.Columns("SizeCon").CellValue(i) = 45 Then
                    Sum45 += 1
                ElseIf Me.C1DBGBill.Columns("SizeCon").CellValue(i) = 58 Then
                    Sum58 += 1
                End If
                If Not IsDBNull(C1DBGBill.Columns("Amount").CellValue(i)) Then
                    packAmount += Me.C1DBGBill.Columns("Amount").CellValue(i)
                End If
                If Not IsDBNull(C1DBGBill.Columns("NWeight").CellValue(i)) Then
                    If C1DBGBill.Columns("NWeight").CellValue(i) > 0 Then
                        NetWeight += Me.C1DBGBill.Columns("NWeight").CellValue(i)
                    End If
                End If
                If Not IsDBNull(C1DBGBill.Columns("ConWeight").CellValue(i)) Then
                    TareWeight += Me.C1DBGBill.Columns("ConWeight").CellValue(i)
                End If
                If Not IsDBNull(C1DBGBill.Columns("Weight").CellValue(i)) Then
                    GrossWeight += Me.C1DBGBill.Columns("Weight").CellValue(i)
                End If
                If Not IsDBNull(C1DBGBill.Columns("Volume").CellValue(i)) Then
                    Measument += Me.C1DBGBill.Columns("Volume").CellValue(i)
                End If
            End If
        Next

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
            xlSheet = CType(xlBook.Worksheets(7), Excel.Worksheet)
            xlSheet.Select(7)
            xlApp.DisplayAlerts = False
            If PrintMark = False Then   '打印不显示，导出显示
                xlSheet.Application.Visible = True
            End If

            For i = 0 To dsBill.Tables(0).Rows.Count - 1
                xlSheet.Cells(i + 8, 1) = Me.C1DBGBill.Columns("CONTAINER_NO").CellValue(i)
                xlSheet.Cells(i + 8, 2) = Me.C1DBGBill.Columns("SealNo").CellValue(i)
                xlSheet.Cells(i + 8, 3) = Me.C1DBGBill.Columns("SizeCon").CellValue(i)
                xlSheet.Cells(i + 8, 4) = Me.C1DBGBill.Columns("TypeCon").CellValue(i)
                xlSheet.Cells(i + 8, 5) = Me.C1DBGBill.Columns("BillNo").CellValue(i)

                If C1DBGCargo.Columns("Amount").CellText(i) <> "0" Then
                    xlSheet.Cells(i + 8, 6) = Me.C1DBGCargo.Columns("Amount").CellText(i)
                End If
                If IsNumeric(C1DBGCargo.Columns("NWeight").CellText(i)) Then
                    If C1DBGCargo.Columns("NWeight").CellText(i) > 0 Then
                        xlSheet.Cells(i + 8, 7) = Me.C1DBGCargo.Columns("NWeight").CellText(i)
                    End If
                End If
                If C1DBGCargo.Columns("Volume").CellText(i) <> "0" Then
                    xlSheet.Cells(i + 8, 8) = Me.C1DBGCargo.Columns("Volume").CellText(i)
                End If
                If C1DBGCargo.Columns("ConWeight").CellText(i) <> "0" Then
                    xlSheet.Cells(i + 8, 9) = Me.C1DBGCargo.Columns("ConWeight").CellText(i)
                End If
                If C1DBGCargo.Columns("Weight").CellText(i) <> "0" Then
                    xlSheet.Cells(i + 8, 10) = Me.C1DBGCargo.Columns("Weight").CellText(i)
                End If

                xlSheet.Cells(i + 8, 11) = Me.C1DBGBill.Columns("BayNo").CellValue(i)
                xlSheet.Cells(i + 8, 12) = Me.C1DBGBill.Columns("UnloadPort").CellValue(i)
                xlSheet.Cells(i + 8, 13) = Me.C1DBGBill.Columns("Delivery").CellValue(i)
            Next
            xlSheet.Cells.Range(xlSheet.Cells(i + 7, 1), xlSheet.Cells(i + 7, 13)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
            xlSheet.Cells.Range(xlSheet.Cells(i + 8, 1), xlSheet.Cells(i + 8, 13)).RowHeight = 18
            xlSheet.Cells(i + 8, 1) = "Date of List:"
            xlSheet.Cells(i + 8, 2) = ListDate
            xlSheet.Range(xlSheet.Cells(i + 8, 3), xlSheet.Cells(i + 8, 5)).Merge()
            xlSheet.Cells(i + 8, 3) = "Total: (20') " & Sum20 & "  (40') " & Sum40 & "  (45') " & Sum45
            xlSheet.Cells(i + 8, 6) = packAmount
            xlSheet.Cells(i + 8, 7) = NetWeight
            xlSheet.Cells(i + 8, 8) = Measument
            xlSheet.Cells(i + 8, 9) = TareWeight
            xlSheet.Cells(i + 8, 10) = GrossWeight
            'xlSheet.Cells(i + 8, 7) = "————————————————————————————————————————————————————————————————————————————————————"
            'xlSheet.Cells(i + 9, 1) = "Date of List:"
            'xlSheet.Cells(i + 9, 2) = ListDate
            'xlSheet.Cells(i + 9, 3) = "Total:(20')"
            'xlSheet.Cells(i + 9, 4) = Sum20 & "     (40')"
            'xlSheet.Cells(i + 9, 5) = Sum40 & "    (45')   " & Sum45
            'xlSheet.Cells(i + 9, 6) = packAmount
            'xlSheet.Cells(i + 9, 7) = NetWeight
            'xlSheet.Cells(i + 9, 8) = Measument
            'xlSheet.Cells(i + 9, 9) = TareWeight
            'xlSheet.Cells(i + 9, 10) = GrossWeight
            xlSheet.Cells(4, 2) = strVessel
            xlSheet.Cells(4, 7) = strVoyage
            xlSheet.Cells(1, 5) = "CONTAINER  CARGO  LIST"
            xlSheet.Cells(2, 5) = "提单号排序表"

            If PrintMark = True Then   '打印
                xlSheet.PrintOut()
                xlApp.Quit()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub GetSheetExcelDanger()
        Dim strVessel, strVoyage As String
        Dim ListDate As Date
        strVessel = dwship.Item(0)("ENG_VESSEL")
        strVoyage = dwship.Item(0)("Voyage")
        ListDate = Now.Date
        Dim Sum20, Sum40, Sum45, Sum58 As Integer
        Dim packAmount As Integer
        Dim Measument, NetWeight, TareWeight, GrossWeight As Decimal
        Dim i As Integer
        Sum20 = 0
        Sum40 = 0
        Sum45 = 0
        Sum58 = 0
        packAmount = 0
        NetWeight = 0.0
        TareWeight = 0.0
        GrossWeight = 0.0
        Measument = 0.0
        For i = 0 To dsDanger.Tables(0).Rows.Count - 1
            If Not IsDBNull(C1DBGDanger.Columns("SizeCon").CellValue(i)) Then
                If Me.C1DBGDanger.Columns("SizeCon").CellValue(i) = 20 Then
                    Sum20 += 1
                ElseIf Me.C1DBGDanger.Columns("SizeCon").CellValue(i) = 40 Then
                    Sum40 += 1
                ElseIf Me.C1DBGDanger.Columns("SizeCon").CellValue(i) = 45 Then
                    Sum45 += 1
                ElseIf Me.C1DBGDanger.Columns("SizeCon").CellValue(i) = 58 Then
                    Sum58 += 1
                End If
                If Not IsDBNull(C1DBGBill.Columns("Amount").CellValue(i)) Then
                    packAmount += Me.C1DBGBill.Columns("Amount").CellValue(i)
                End If
                If Not IsDBNull(C1DBGBill.Columns("NWeight").CellValue(i)) Then
                    If C1DBGBill.Columns("NWeight").CellValue(i) > 0 Then
                        NetWeight += Me.C1DBGBill.Columns("NWeight").CellValue(i)
                    End If
                End If
                If Not IsDBNull(C1DBGBill.Columns("ConWeight").CellValue(i)) Then
                    TareWeight += Me.C1DBGBill.Columns("ConWeight").CellValue(i)
                End If
                If Not IsDBNull(C1DBGBill.Columns("Weight").CellValue(i)) Then
                    GrossWeight += Me.C1DBGBill.Columns("Weight").CellValue(i)
                End If
                If Not IsDBNull(C1DBGBill.Columns("Volume").CellValue(i)) Then
                    Measument += Me.C1DBGBill.Columns("Volume").CellValue(i)
                End If
            End If
        Next

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
            xlSheet = CType(xlBook.Worksheets(7), Excel.Worksheet)
            xlSheet.Select(7)
            xlApp.DisplayAlerts = False
            If PrintMark = False Then   '打印不显示，导出显示
                xlSheet.Application.Visible = True
            End If

            For i = 0 To dsDanger.Tables(0).Rows.Count - 1
                xlSheet.Cells(i + 8, 1) = Me.C1DBGDanger.Columns("CONTAINER_NO").CellValue(i)
                xlSheet.Cells(i + 8, 2) = Me.C1DBGDanger.Columns("SealNo").CellValue(i)
                xlSheet.Cells(i + 8, 3) = Me.C1DBGDanger.Columns("SizeCon").CellValue(i)
                xlSheet.Cells(i + 8, 4) = Me.C1DBGDanger.Columns("TypeCon").CellValue(i)
                xlSheet.Cells(i + 8, 5) = Me.C1DBGDanger.Columns("BillNo").CellValue(i)

                If C1DBGCargo.Columns("Amount").CellText(i) <> "0" Then
                    xlSheet.Cells(i + 8, 6) = Me.C1DBGCargo.Columns("Amount").CellText(i)
                End If
                If IsNumeric(C1DBGCargo.Columns("NWeight").CellText(i)) Then
                    If C1DBGCargo.Columns("NWeight").CellText(i) > 0 Then
                        xlSheet.Cells(i + 8, 7) = Me.C1DBGCargo.Columns("NWeight").CellText(i)
                    End If
                End If
                If C1DBGCargo.Columns("Volume").CellText(i) <> "0" Then
                    xlSheet.Cells(i + 8, 8) = Me.C1DBGCargo.Columns("Volume").CellText(i)
                End If
                If C1DBGCargo.Columns("ConWeight").CellText(i) <> "0" Then
                    xlSheet.Cells(i + 8, 9) = Me.C1DBGCargo.Columns("ConWeight").CellText(i)
                End If
                If C1DBGCargo.Columns("Weight").CellText(i) <> "0" Then
                    xlSheet.Cells(i + 8, 10) = Me.C1DBGCargo.Columns("Weight").CellText(i)
                End If

                xlSheet.Cells(i + 8, 11) = Me.C1DBGDanger.Columns("BayNo").CellValue(i)
                xlSheet.Cells(i + 8, 12) = Me.C1DBGDanger.Columns("UnloadPort").CellValue(i)
                xlSheet.Cells(i + 8, 13) = Me.C1DBGDanger.Columns("Delivery").CellValue(i)
                xlSheet.Cells(i + 8, "N") = Me.C1DBGDanger.Columns("DangerGrade").CellValue(i)
            Next
            xlSheet.Cells.Range(xlSheet.Cells(i + 7, 1), xlSheet.Cells(i + 7, 14)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 2
            xlSheet.Cells.Range(xlSheet.Cells(i + 8, 1), xlSheet.Cells(i + 8, 14)).RowHeight = 18
            xlSheet.Cells(i + 8, 1) = "Date of List:"
            xlSheet.Cells(i + 8, 2) = ListDate
            xlSheet.Range(xlSheet.Cells(i + 8, 3), xlSheet.Cells(i + 8, 5)).Merge()
            xlSheet.Cells(i + 8, 3) = "Total: (20') " & Sum20 & "  (40') " & Sum40 & "  (45') " & Sum45
            xlSheet.Cells(i + 8, 6) = packAmount
            xlSheet.Cells(i + 8, 7) = NetWeight
            xlSheet.Cells(i + 8, 8) = Measument
            xlSheet.Cells(i + 8, 9) = TareWeight
            xlSheet.Cells(i + 8, 10) = GrossWeight
            xlSheet.Cells(4, 2) = strVessel
            xlSheet.Cells(4, 7) = strVoyage
            xlSheet.Cells(1, 5) = "DANGEROUS  CARGO  LIST"
            xlSheet.Cells(2, 5) = "危险品货物清单"
            xlSheet.Cells(6, "N") = "DANGERGRADE"

            If PrintMark = True Then   '打印
                xlSheet.PrintOut()
                xlApp.Quit()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub GetSheetExcelReefer()
        Dim strVessel, strVoyage As String
        Dim ListDate As Date
        strVessel = dwship.Item(0)("ENG_VESSEL")
        strVoyage = dwship.Item(0)("Voyage")
        ListDate = Now.Date
        Dim Sum20, Sum40, Sum45, Sum58 As Integer
        Dim packAmount As Integer
        Dim Measument, NetWeight, TareWeight, GrossWeight As Decimal
        Dim i As Integer
        Sum20 = 0
        Sum40 = 0
        Sum45 = 0
        Sum58 = 0
        packAmount = 0
        NetWeight = 0.0
        TareWeight = 0.0
        GrossWeight = 0.0
        Measument = 0.0
        For i = 0 To dsReefer.Tables(0).Rows.Count - 1
            If Not IsDBNull(C1DBGReefer.Columns("SizeCon").CellValue(i)) Then
                If Me.C1DBGReefer.Columns("SizeCon").CellValue(i) = 20 Then
                    Sum20 += 1
                ElseIf Me.C1DBGReefer.Columns("SizeCon").CellValue(i) = 40 Then
                    Sum40 += 1
                ElseIf Me.C1DBGReefer.Columns("SizeCon").CellValue(i) = 45 Then
                    Sum45 += 1
                ElseIf Me.C1DBGReefer.Columns("SizeCon").CellValue(i) = 58 Then
                    Sum58 += 1
                End If
                If Not IsDBNull(C1DBGBill.Columns("Amount").CellValue(i)) Then
                    packAmount += Me.C1DBGBill.Columns("Amount").CellValue(i)
                End If
                If Not IsDBNull(C1DBGBill.Columns("NWeight").CellValue(i)) Then
                    If C1DBGBill.Columns("NWeight").CellValue(i) > 0 Then
                        NetWeight += Me.C1DBGBill.Columns("NWeight").CellValue(i)
                    End If
                End If
                If Not IsDBNull(C1DBGBill.Columns("ConWeight").CellValue(i)) Then
                    TareWeight += Me.C1DBGBill.Columns("ConWeight").CellValue(i)
                End If
                If Not IsDBNull(C1DBGBill.Columns("Weight").CellValue(i)) Then
                    GrossWeight += Me.C1DBGBill.Columns("Weight").CellValue(i)
                End If
                If Not IsDBNull(C1DBGBill.Columns("Volume").CellValue(i)) Then
                    Measument += Me.C1DBGBill.Columns("Volume").CellValue(i)
                End If
            End If
        Next

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
            xlSheet = CType(xlBook.Worksheets(7), Excel.Worksheet)
            xlSheet.Select(7)
            xlApp.DisplayAlerts = False
            If PrintMark = False Then   '打印不显示，导出显示
                xlSheet.Application.Visible = True
            End If

            For i = 0 To dsReefer.Tables(0).Rows.Count - 1
                xlSheet.Cells(i + 8, 1) = Me.C1DBGReefer.Columns("CONTAINER_NO").CellValue(i)
                xlSheet.Cells(i + 8, 2) = Me.C1DBGReefer.Columns("SealNo").CellValue(i)
                xlSheet.Cells(i + 8, 3) = Me.C1DBGReefer.Columns("SizeCon").CellValue(i)
                xlSheet.Cells(i + 8, 4) = Me.C1DBGReefer.Columns("TypeCon").CellValue(i)
                xlSheet.Cells(i + 8, 5) = Me.C1DBGReefer.Columns("BillNo").CellValue(i)

                If C1DBGCargo.Columns("Amount").CellText(i) <> "0" Then
                    xlSheet.Cells(i + 8, 6) = Me.C1DBGCargo.Columns("Amount").CellText(i)
                End If
                If IsNumeric(C1DBGCargo.Columns("NWeight").CellText(i)) Then
                    If C1DBGCargo.Columns("NWeight").CellText(i) > 0 Then
                        xlSheet.Cells(i + 8, 7) = Me.C1DBGCargo.Columns("NWeight").CellText(i)
                    End If
                End If
                If C1DBGCargo.Columns("Volume").CellText(i) <> "0" Then
                    xlSheet.Cells(i + 8, 8) = Me.C1DBGCargo.Columns("Volume").CellText(i)
                End If
                If C1DBGCargo.Columns("ConWeight").CellText(i) <> "0" Then
                    xlSheet.Cells(i + 8, 9) = Me.C1DBGCargo.Columns("ConWeight").CellText(i)
                End If
                If C1DBGCargo.Columns("Weight").CellText(i) <> "0" Then
                    xlSheet.Cells(i + 8, 10) = Me.C1DBGCargo.Columns("Weight").CellText(i)
                End If

                xlSheet.Cells(i + 8, 11) = Me.C1DBGReefer.Columns("BayNo").CellValue(i)
                xlSheet.Cells(i + 8, 12) = Me.C1DBGReefer.Columns("UnloadPort").CellValue(i)
                xlSheet.Cells(i + 8, 13) = Me.C1DBGReefer.Columns("Delivery").CellValue(i)
                xlSheet.Cells(i + 8, "N") = Me.C1DBGReefer.Columns("ReeferTemp").CellText(i) & Me.C1DBGReefer.Columns("TempUnit").CellText(i)
            Next
            xlSheet.Cells.Range(xlSheet.Cells(i + 7, 1), xlSheet.Cells(i + 7, 14)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 4
            xlSheet.Cells.Range(xlSheet.Cells(i + 8, 1), xlSheet.Cells(i + 8, 14)).RowHeight = 18
            xlSheet.Cells(i + 8, 1) = "Date of List:"
            xlSheet.Cells(i + 8, 2) = ListDate
            xlSheet.Range(xlSheet.Cells(i + 8, 3), xlSheet.Cells(i + 8, 5)).Merge()
            xlSheet.Cells(i + 8, 3) = "Total: (20') " & Sum20 & "  (40') " & Sum40 & "  (45') " & Sum45
            xlSheet.Cells(i + 8, 6) = packAmount
            xlSheet.Cells(i + 8, 7) = NetWeight
            xlSheet.Cells(i + 8, 8) = Measument
            xlSheet.Cells(i + 8, 9) = TareWeight
            xlSheet.Cells(i + 8, 10) = GrossWeight
            xlSheet.Cells(4, 2) = strVessel
            xlSheet.Cells(4, 7) = strVoyage
            xlSheet.Cells(1, 5) = "REEFER  CARGO  LIST"
            xlSheet.Cells(2, 5) = "冷藏箱货物清单"
            xlSheet.Cells(6, "N") = "REEFERTEMP"

            If PrintMark = True Then   '打印
                xlSheet.PrintOut()
                xlApp.Quit()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub GetSheetExcelCargo()
        Dim strVessel, strVoyage As String
        Dim ListDate As Date
        strVessel = dwship.Item(0)("ENG_VESSEL")
        strVoyage = dwship.Item(0)("Voyage")
        ListDate = Now.Date
        Dim Sum20, Sum40, Sum45, Sum58 As Integer
        Dim packAmount As Integer
        Dim Measument, NetWeight, TareWeight, GrossWeight As Decimal
        Dim i As Integer
        Sum20 = 0
        Sum40 = 0
        Sum45 = 0
        Sum58 = 0
        packAmount = 0
        NetWeight = 0.0
        TareWeight = 0.0
        GrossWeight = 0.0
        Measument = 0.0
        For i = 0 To dsCargo.Tables(0).Rows.Count - 1
            If Not IsDBNull(C1DBGCargo.Columns("SizeCon").CellValue(i)) Then
                If Me.C1DBGCargo.Columns("SizeCon").CellValue(i) = 20 Then
                    Sum20 += 1
                ElseIf Me.C1DBGCargo.Columns("SizeCon").CellValue(i) = 40 Then
                    Sum40 += 1
                ElseIf Me.C1DBGCargo.Columns("SizeCon").CellValue(i) = 45 Then
                    Sum45 += 1
                ElseIf Me.C1DBGCargo.Columns("SizeCon").CellValue(i) = 58 Then
                    Sum58 += 1
                End If
                If Not IsDBNull(C1DBGBill.Columns("Amount").CellValue(i)) Then
                    packAmount += Me.C1DBGBill.Columns("Amount").CellValue(i)
                End If
                If Not IsDBNull(C1DBGBill.Columns("NWeight").CellValue(i)) Then
                    If C1DBGBill.Columns("NWeight").CellValue(i) > 0 Then
                        NetWeight += Me.C1DBGBill.Columns("NWeight").CellValue(i)
                    End If
                End If
                If Not IsDBNull(C1DBGBill.Columns("ConWeight").CellValue(i)) Then
                    TareWeight += Me.C1DBGBill.Columns("ConWeight").CellValue(i)
                End If
                If Not IsDBNull(C1DBGBill.Columns("Weight").CellValue(i)) Then
                    GrossWeight += Me.C1DBGBill.Columns("Weight").CellValue(i)
                End If
                If Not IsDBNull(C1DBGBill.Columns("Volume").CellValue(i)) Then
                    Measument += Me.C1DBGBill.Columns("Volume").CellValue(i)
                End If
            End If
        Next

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
            xlSheet = CType(xlBook.Worksheets(7), Excel.Worksheet)
            xlSheet.Select(7)
            xlApp.DisplayAlerts = False
            If PrintMark = False Then   '打印不显示，导出显示
                xlSheet.Application.Visible = True
            End If

            For i = 0 To dsCargo.Tables(0).Rows.Count - 1
                xlSheet.Cells(i + 8, 1) = Me.C1DBGCargo.Columns("CONTAINER_NO").CellValue(i)
                xlSheet.Cells(i + 8, 2) = Me.C1DBGCargo.Columns("SealNo").CellValue(i)
                xlSheet.Cells(i + 8, 3) = Me.C1DBGCargo.Columns("SizeCon").CellValue(i)
                xlSheet.Cells(i + 8, 4) = Me.C1DBGCargo.Columns("TypeCon").CellValue(i)
                xlSheet.Cells(i + 8, 5) = Me.C1DBGCargo.Columns("BillNo").CellValue(i)

                If C1DBGCargo.Columns("Amount").CellText(i) <> "0" Then
                    xlSheet.Cells(i + 8, 6) = Me.C1DBGCargo.Columns("Amount").CellText(i)
                End If
                If IsNumeric(C1DBGCargo.Columns("NWeight").CellText(i)) Then
                    If C1DBGCargo.Columns("NWeight").CellText(i) > 0 Then
                        xlSheet.Cells(i + 8, 7) = Me.C1DBGCargo.Columns("NWeight").CellText(i)
                    End If
                End If
                If C1DBGCargo.Columns("Volume").CellText(i) <> "0" Then
                    xlSheet.Cells(i + 8, 8) = Me.C1DBGCargo.Columns("Volume").CellText(i)
                End If
                If C1DBGCargo.Columns("ConWeight").CellText(i) <> "0" Then
                    xlSheet.Cells(i + 8, 9) = Me.C1DBGCargo.Columns("ConWeight").CellText(i)
                End If
                If C1DBGCargo.Columns("Weight").CellText(i) <> "0" Then
                    xlSheet.Cells(i + 8, 10) = Me.C1DBGCargo.Columns("Weight").CellText(i)
                End If

                xlSheet.Cells(i + 8, 11) = Me.C1DBGCargo.Columns("BayNo").CellValue(i)
                xlSheet.Cells(i + 8, 12) = Me.C1DBGCargo.Columns("UnloadPort").CellValue(i)
                xlSheet.Cells(i + 8, 13) = Me.C1DBGCargo.Columns("Delivery").CellValue(i)
            Next
            xlSheet.Cells.Range(xlSheet.Cells(i + 7, 1), xlSheet.Cells(i + 7, 13)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 3
            xlSheet.Cells.Range(xlSheet.Cells(i + 8, 1), xlSheet.Cells(i + 8, 13)).RowHeight = 18
            xlSheet.Cells(i + 8, 1) = "Date of List:"
            xlSheet.Cells(i + 8, 2) = ListDate
            xlSheet.Range(xlSheet.Cells(i + 8, 3), xlSheet.Cells(i + 8, 5)).Merge()
            xlSheet.Cells(i + 8, 3) = "Total: (20') " & Sum20 & "  (40') " & Sum40 & "  (45') " & Sum45
            xlSheet.Cells(i + 8, 6) = packAmount
            xlSheet.Cells(i + 8, 7) = NetWeight
            xlSheet.Cells(i + 8, 8) = Measument
            xlSheet.Cells(i + 8, 9) = TareWeight
            xlSheet.Cells(i + 8, 10) = GrossWeight
            xlSheet.Cells(4, 2) = strVessel
            xlSheet.Cells(4, 7) = strVoyage
            xlSheet.Cells(1, 5) = "NUMERICAL  CONTAINER  LIST"
            xlSheet.Cells(2, 5) = "集装箱载货清单"

            If PrintMark = True Then   '打印
                xlSheet.PrintOut()
                xlApp.Quit()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub GetSheetExcelSum()
        Dim strVessel, strVoyage As String
        Dim ListDate As Date
        strVessel = dwship.Item(0)("ENG_VESSEL")
        strVoyage = dwship.Item(0)("Voyage")
        ListDate = Now.Date

        Dim i As Integer
        Dim iAmountE20, iAmountE40, iAmountE45, iAmountE58, iAmountH20, iAmountH40, iAmountH45, iAmountH58 As Integer
        Dim fWeightE20, fWeightE40, fWeightE45, fWeightE58, fWeightH20, fWeightH40, fWeightH45, fWeightH58 As Double
        Dim iAmountE20T, iAmountE40T, iAmountE45T, iAmountE58T, iAmountH20T, iAmountH40T, iAmountH45T, iAmountH58T As Integer
        Dim fWeightE20T, fWeightE40T, fWeightE45T, fWeightE58T, fWeightH20T, fWeightH40T, fWeightH45T, fWeightH58T As Double
        Dim strPortPreCode, strPortNowCode, strPort As String
        Dim sqlStateSumary As String
        Dim dvStateSumary As New DataView
        sqlStateSumary = "SELECT CODE_UNLOAD_PORT, MAX(UNLOAD_PORT) AS UnloadPort, FULLOREMPTY, CONTAINER_TYPE, SIZE_CON, COUNT(*) AS ConNum, SUM(WEIGHT) AS ConWeight FROM View_ContainerLoadingSumary WHERE (CODE_LOAD_PORT = 'LYG') AND (SHIP_ID = '" & Ship_ID & "') GROUP BY CODE_UNLOAD_PORT, FULLOREMPTY, CONTAINER_TYPE, SIZE_CON ORDER BY CODE_UNLOAD_PORT, FULLOREMPTY, CONTAINER_TYPE, SIZE_CON"
        dvStateSumary = Filldata(sqlStateSumary)

        Dim iAmountD20, iAmountD40, iAmountD45, iAmountD58, iAmountR20, iAmountR40, iAmountR45, iAmountR58 As Integer
        Dim fWeightD20, fWeightD40, fWeightD45, fWeightD58, fWeightR20, fWeightR40, fWeightR45, fWeightR58 As Double
        Dim iAmountD20T, iAmountD40T, iAmountD45T, iAmountD58T, iAmountR20T, iAmountR40T, iAmountR45T, iAmountR58T As Integer
        Dim fWeightD20T, fWeightD40T, fWeightD45T, fWeightD58T, fWeightR20T, fWeightR40T, fWeightR45T, fWeightR58T As Double


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
            xlSheet = CType(xlBook.Worksheets(9), Excel.Worksheet)
            xlSheet.Select(9)
            xlApp.DisplayAlerts = False
            If PrintMark = False Then   '打印不显示，导出显示
                xlSheet.Application.Visible = True
            End If

            If dvStateSumary.Count > 0 Then
                If Not IsDBNull(dvStateSumary.Item(0)("CODE_UNLOAD_PORT")) Then
                    strPortPreCode = dvStateSumary.Item(0)("CODE_UNLOAD_PORT")   '记下第一个港口代码
                    If Not IsDBNull(dvStateSumary.Item(Row)("UnloadPort")) Then
                        strPort = dvStateSumary.Item(Row)("UnloadPort")   '记下当前港口名 要改row为0
                    End If
                Else
                    strPortPreCode = "-100"     '第一个港口代码没有
                End If
            End If

            For Row = 0 To dvStateSumary.Count - 1
                If Not IsDBNull(dvStateSumary.Item(Row)("CODE_UNLOAD_PORT")) Then
                    strPortNowCode = dvStateSumary.Item(Row)("CODE_UNLOAD_PORT")    '记下当前港口代码
                Else
                    strPortNowCode = "-100"     '当前港口代码没有
                End If
                If strPortNowCode <> strPortPreCode Then '如果前后港口不同了
                    '先填充数据再重新初始化
                    xlSheet.Cells(7 + 2 * i, 1) = strPort '填充数据
                    If iAmountH20 <> 0 Then
                        xlSheet.Cells(7 + 2 * i, 2) = iAmountH20
                    End If
                    If iAmountH40 <> 0 Then
                        xlSheet.Cells(7 + 2 * i, 3) = iAmountH40
                    End If
                    If iAmountH45 <> 0 Then
                        xlSheet.Cells(7 + 2 * i, 4) = iAmountH45
                    End If
                    If iAmountH58 <> 0 Then
                        xlSheet.Cells(7 + 2 * i, 5) = iAmountH58
                    End If
                    If iAmountE20 <> 0 Then
                        xlSheet.Cells(7 + 2 * i, 6) = iAmountE20
                    End If
                    If iAmountE40 <> 0 Then
                        xlSheet.Cells(7 + 2 * i, 7) = iAmountE40
                    End If
                    If iAmountE45 <> 0 Then
                        xlSheet.Cells(7 + 2 * i, 8) = iAmountE45
                    End If
                    If iAmountE58 <> 0 Then
                        xlSheet.Cells(7 + 2 * i, 9) = iAmountE58
                    End If
                    If iAmountH20 + iAmountE20 <> 0 Then
                        xlSheet.Cells(7 + 2 * i, 10) = iAmountH20 + iAmountE20
                    End If
                    If iAmountH40 + iAmountE40 <> 0 Then
                        xlSheet.Cells(7 + 2 * i, 11) = iAmountH40 + iAmountE40
                    End If
                    If iAmountH45 + iAmountE45 <> 0 Then
                        xlSheet.Cells(7 + 2 * i, 12) = iAmountH45 + iAmountE45
                    End If
                    If iAmountH58 + iAmountE58 <> 0 Then
                        xlSheet.Cells(7 + 2 * i, 13) = iAmountH58 + iAmountE58
                    End If

                    If fWeightH20 <> 0 Then
                        xlSheet.Cells(8 + 2 * i, 2) = fWeightH20
                    End If
                    If fWeightH40 <> 0 Then
                        xlSheet.Cells(8 + 2 * i, 3) = fWeightH40
                    End If
                    If fWeightH45 <> 0 Then
                        xlSheet.Cells(8 + 2 * i, 4) = fWeightH45
                    End If
                    If fWeightH58 <> 0 Then
                        xlSheet.Cells(8 + 2 * i, 5) = fWeightH58
                    End If
                    If fWeightE20 <> 0 Then
                        xlSheet.Cells(8 + 2 * i, 6) = fWeightE20
                    End If
                    If fWeightE40 <> 0 Then
                        xlSheet.Cells(8 + 2 * i, 7) = fWeightE40
                    End If
                    If fWeightE45 <> 0 Then
                        xlSheet.Cells(8 + 2 * i, 8) = fWeightE45
                    End If
                    If fWeightE58 <> 0 Then
                        xlSheet.Cells(8 + 2 * i, 9) = fWeightE58
                    End If
                    If fWeightH20 + fWeightE20 <> 0 Then
                        xlSheet.Cells(8 + 2 * i, 10) = fWeightH20 + fWeightE20
                    End If
                    If fWeightH40 + fWeightE40 <> 0 Then
                        xlSheet.Cells(8 + 2 * i, 11) = fWeightH40 + fWeightE40
                    End If
                    If fWeightH45 + fWeightE45 <> 0 Then
                        xlSheet.Cells(8 + 2 * i, 12) = fWeightH45 + fWeightE45
                    End If
                    If fWeightH58 + fWeightE58 <> 0 Then
                        xlSheet.Cells(8 + 2 * i, 13) = fWeightH58 + fWeightE58
                    End If

                    If iAmountD20 <> 0 Then
                        xlSheet.Cells(7 + 2 * i, 14) = iAmountD20
                    End If
                    If iAmountD40 <> 0 Then
                        xlSheet.Cells(7 + 2 * i, 15) = iAmountD40
                    End If
                    If iAmountD45 <> 0 Then
                        xlSheet.Cells(7 + 2 * i, 16) = iAmountD45
                    End If
                    If iAmountD58 <> 0 Then
                        xlSheet.Cells(7 + 2 * i, 17) = iAmountD58
                    End If
                    If iAmountR20 <> 0 Then
                        xlSheet.Cells(7 + 2 * i, 18) = iAmountR20
                    End If
                    If iAmountR40 <> 0 Then
                        xlSheet.Cells(7 + 2 * i, 19) = iAmountR40
                    End If
                    If iAmountR45 <> 0 Then
                        xlSheet.Cells(7 + 2 * i, 20) = iAmountR45
                    End If
                    If iAmountR58 <> 0 Then
                        xlSheet.Cells(7 + 2 * i, 21) = iAmountR58
                    End If

                    If fWeightD20 <> 0 Then
                        xlSheet.Cells(8 + 2 * i, 14) = fWeightD20
                    End If
                    If fWeightD40 <> 0 Then
                        xlSheet.Cells(8 + 2 * i, 15) = fWeightD40
                    End If
                    If fWeightD45 <> 0 Then
                        xlSheet.Cells(8 + 2 * i, 16) = fWeightD45
                    End If
                    If fWeightD58 <> 0 Then
                        xlSheet.Cells(8 + 2 * i, 17) = fWeightD58
                    End If
                    If fWeightR20 <> 0 Then
                        xlSheet.Cells(8 + 2 * i, 18) = fWeightR20
                    End If
                    If fWeightR40 <> 0 Then
                        xlSheet.Cells(8 + 2 * i, 19) = fWeightR40
                    End If
                    If fWeightR45 <> 0 Then
                        xlSheet.Cells(8 + 2 * i, 20) = fWeightR45
                    End If
                    If fWeightR58 <> 0 Then
                        xlSheet.Cells(8 + 2 * i, 21) = fWeightR58
                    End If

                    i += 1  '计数器自加

                    iAmountE20T += iAmountE20       '记录各项累加和
                    iAmountE40T += iAmountE40
                    iAmountE45T += iAmountE45
                    iAmountE58T += iAmountE58
                    iAmountH20T += iAmountH20
                    iAmountH40T += iAmountH40
                    iAmountH45T += iAmountH45
                    iAmountH58T += iAmountH58
                    fWeightE20T += fWeightE20
                    fWeightE40T += fWeightE40
                    fWeightE45T += fWeightE45
                    fWeightE58T += fWeightE58
                    fWeightH20T += fWeightH20
                    fWeightH40T += fWeightH40
                    fWeightH45T += fWeightH45
                    fWeightH58T += fWeightH58

                    iAmountD20T += iAmountD20       '记录各项累加和 (inclusion)
                    iAmountD40T += iAmountD40
                    iAmountD45T += iAmountD45
                    iAmountD58T += iAmountD58
                    iAmountR20T += iAmountR20
                    iAmountR40T += iAmountR40
                    iAmountR45T += iAmountR45
                    iAmountR58T += iAmountR58
                    fWeightD20T += fWeightD20
                    fWeightD40T += fWeightD40
                    fWeightD45T += fWeightD45
                    fWeightD58T += fWeightD58
                    fWeightR20T += fWeightR20
                    fWeightR40T += fWeightR40
                    fWeightR45T += fWeightR45
                    fWeightR58T += fWeightR58

                    'strPortNowCode = strPortPreCode     '初始化
                    strPortPreCode = strPortNowCode   '初始化
                    If Not IsDBNull(dvStateSumary.Item(Row)("UnloadPort")) Then
                        strPort = dvStateSumary.Item(Row)("UnloadPort")   '记下当前港口名
                    End If
                    iAmountE20 = 0
                    iAmountE40 = 0
                    iAmountE45 = 0
                    iAmountE58 = 0
                    iAmountH20 = 0
                    iAmountH40 = 0
                    iAmountH45 = 0
                    iAmountH58 = 0
                    fWeightE20 = 0.0
                    fWeightE40 = 0.0
                    fWeightE45 = 0.0
                    fWeightE58 = 0.0
                    fWeightH20 = 0.0
                    fWeightH40 = 0.0
                    fWeightH45 = 0.0
                    fWeightH58 = 0.0

                    iAmountD20 = 0
                    iAmountD40 = 0
                    iAmountD45 = 0
                    iAmountD58 = 0
                    iAmountR20 = 0
                    iAmountR40 = 0
                    iAmountR45 = 0
                    iAmountR58 = 0
                    fWeightD20 = 0.0
                    fWeightD40 = 0.0
                    fWeightD45 = 0.0
                    fWeightD58 = 0.0
                    fWeightR20 = 0.0
                    fWeightR40 = 0.0
                    fWeightR45 = 0.0
                    fWeightR58 = 0.0
                End If
                '对重箱空箱的统计
                If Not IsDBNull(dvStateSumary.Item(Row)("FULLOREMPTY")) Then
                    If dvStateSumary.Item(Row)("FULLOREMPTY") = "E" Then    '是空箱时
                        If Not IsDBNull(dvStateSumary.Item(Row)("SIZE_CON")) Then
                            If dvStateSumary.Item(Row)("SIZE_CON") = "20" Then
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConNum")) Then
                                    iAmountE20 += dvStateSumary.Item(Row)("ConNum")  '累计20'箱数量 其实为空箱时也要累计，有不同的箱型就有不同的情况情况
                                End If
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConWeight")) Then
                                    fWeightE20 += dvStateSumary.Item(Row)("ConWeight")  '累计20'箱重量
                                End If
                            ElseIf dvStateSumary.Item(Row)("SIZE_CON") = "40" Then
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConNum")) Then
                                    iAmountE40 += dvStateSumary.Item(Row)("ConNum")  '累计40'箱数量
                                End If
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConWeight")) Then
                                    fWeightE40 += dvStateSumary.Item(Row)("ConWeight")  '累计40'箱重量
                                End If
                            ElseIf dvStateSumary.Item(Row)("SIZE_CON") = "45" Then
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConNum")) Then
                                    iAmountE45 += dvStateSumary.Item(Row)("ConNum")  '累计45'箱数量
                                End If
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConWeight")) Then
                                    fWeightE45 += dvStateSumary.Item(Row)("ConWeight")  '累计45'箱重量
                                End If
                            ElseIf dvStateSumary.Item(Row)("SIZE_CON") = "58" Then
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConNum")) Then
                                    iAmountE58 += dvStateSumary.Item(Row)("ConNum")  '累计58'箱数量
                                End If
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConWeight")) Then
                                    fWeightE58 += dvStateSumary.Item(Row)("ConWeight")  '累计58'箱重量
                                End If
                            End If
                        End If
                    Else             '是重箱时
                        If Not IsDBNull(dvStateSumary.Item(Row)("SIZE_CON")) Then
                            If dvStateSumary.Item(Row)("SIZE_CON") = "20" Then
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConNum")) Then
                                    iAmountH20 += dvStateSumary.Item(Row)("ConNum")  '累计20'箱数量
                                End If
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConWeight")) Then
                                    fWeightH20 += dvStateSumary.Item(Row)("ConWeight")  '累计20'箱重量
                                End If
                            ElseIf dvStateSumary.Item(Row)("SIZE_CON") = "40" Then
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConNum")) Then
                                    iAmountH40 += dvStateSumary.Item(Row)("ConNum")  '累计40'箱数量
                                End If
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConWeight")) Then
                                    fWeightH40 += dvStateSumary.Item(Row)("ConWeight")  '累计40'箱重量
                                End If
                            ElseIf dvStateSumary.Item(Row)("SIZE_CON") = "45" Then
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConNum")) Then
                                    iAmountH45 += dvStateSumary.Item(Row)("ConNum")  '累计45'箱数量
                                End If
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConWeight")) Then
                                    fWeightH45 += dvStateSumary.Item(Row)("ConWeight")  '累计45'箱重量
                                End If
                            ElseIf dvStateSumary.Item(Row)("SIZE_CON") = "58" Then
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConNum")) Then
                                    iAmountH58 += dvStateSumary.Item(Row)("ConNum")  '累计58'箱数量
                                End If
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConWeight")) Then
                                    fWeightH58 += dvStateSumary.Item(Row)("ConWeight")  '累计58'箱重量
                                End If
                            End If
                        End If
                    End If
                End If

                '对危险品冷藏箱的统计
                If Not IsDBNull(dvStateSumary.Item(Row)("CONTAINER_TYPE")) Then
                    If dvStateSumary.Item(Row)("CONTAINER_TYPE") Like "D?" Or dvStateSumary.Item(Row)("CONTAINER_TYPE") Like "T?" Then  '是危险品箱时
                        If Not IsDBNull(dvStateSumary.Item(Row)("SIZE_CON")) Then
                            If dvStateSumary.Item(Row)("SIZE_CON") = "20" Then
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConNum")) Then
                                    iAmountD20 += dvStateSumary.Item(Row)("ConNum")  '累计20'箱数量
                                End If
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConWeight")) Then
                                    fWeightD20 += dvStateSumary.Item(Row)("ConWeight")  '累计20'箱重量
                                End If
                            ElseIf dvStateSumary.Item(Row)("SIZE_CON") = "40" Then
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConNum")) Then
                                    iAmountD40 += dvStateSumary.Item(Row)("ConNum")  '累计40'箱数量
                                End If
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConWeight")) Then
                                    fWeightD40 += dvStateSumary.Item(Row)("ConWeight")  '累计40'箱重量
                                End If
                            ElseIf dvStateSumary.Item(Row)("SIZE_CON") = "45" Then
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConNum")) Then
                                    iAmountD45 += dvStateSumary.Item(Row)("ConNum")  '累计45'箱数量
                                End If
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConWeight")) Then
                                    fWeightD45 += dvStateSumary.Item(Row)("ConWeight")  '累计45'箱重量
                                End If
                            ElseIf dvStateSumary.Item(Row)("SIZE_CON") = "58" Then
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConNum")) Then
                                    iAmountD58 += dvStateSumary.Item(Row)("ConNum")  '累计58'箱数量
                                End If
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConWeight")) Then
                                    fWeightD58 += dvStateSumary.Item(Row)("ConWeight")  '累计58'箱重量
                                End If
                            End If
                        End If
                    ElseIf dvStateSumary.Item(Row)("CONTAINER_TYPE") Like "R?" Then     '是冷藏箱时
                        If Not IsDBNull(dvStateSumary.Item(Row)("SIZE_CON")) Then
                            If dvStateSumary.Item(Row)("SIZE_CON") = "20" Then
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConNum")) Then
                                    iAmountR20 += dvStateSumary.Item(Row)("ConNum")  '累计20'箱数量
                                End If
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConWeight")) Then
                                    fWeightR20 += dvStateSumary.Item(Row)("ConWeight")  '累计20'箱重量
                                End If
                            ElseIf dvStateSumary.Item(Row)("SIZE_CON") = "40" Then
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConNum")) Then
                                    iAmountR40 += dvStateSumary.Item(Row)("ConNum")  '累计40'箱数量
                                End If
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConWeight")) Then
                                    fWeightR40 += dvStateSumary.Item(Row)("ConWeight")  '累计40'箱重量
                                End If
                            ElseIf dvStateSumary.Item(Row)("SIZE_CON") = "45" Then
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConNum")) Then
                                    iAmountR45 += dvStateSumary.Item(Row)("ConNum")  '累计45'箱数量
                                End If
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConWeight")) Then
                                    fWeightR45 += dvStateSumary.Item(Row)("ConWeight")  '累计45'箱重量
                                End If
                            ElseIf dvStateSumary.Item(Row)("SIZE_CON") = "58" Then
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConNum")) Then
                                    iAmountR58 += dvStateSumary.Item(Row)("ConNum")  '累计58'箱数量
                                End If
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConWeight")) Then
                                    fWeightR58 += dvStateSumary.Item(Row)("ConWeight")  '累计58'箱重量
                                End If
                            End If
                        End If
                    End If
                End If
            Next

            If dvStateSumary.Count > 0 Then
                xlSheet.Cells(7 + 2 * i, 1) = strPort '填充最后一项数据
                If iAmountH20 <> 0 Then
                    xlSheet.Cells(7 + 2 * i, 2) = iAmountH20
                End If
                If iAmountH40 <> 0 Then
                    xlSheet.Cells(7 + 2 * i, 3) = iAmountH40
                End If
                If iAmountH45 <> 0 Then
                    xlSheet.Cells(7 + 2 * i, 4) = iAmountH45
                End If
                If iAmountH58 <> 0 Then
                    xlSheet.Cells(7 + 2 * i, 5) = iAmountH58
                End If
                If iAmountE20 <> 0 Then
                    xlSheet.Cells(7 + 2 * i, 6) = iAmountE20
                End If
                If iAmountE40 <> 0 Then
                    xlSheet.Cells(7 + 2 * i, 7) = iAmountE40
                End If
                If iAmountE45 <> 0 Then
                    xlSheet.Cells(7 + 2 * i, 8) = iAmountE45
                End If
                If iAmountE58 <> 0 Then
                    xlSheet.Cells(7 + 2 * i, 9) = iAmountE58
                End If
                If iAmountH20 + iAmountE20 <> 0 Then
                    xlSheet.Cells(7 + 2 * i, 10) = iAmountH20 + iAmountE20
                End If
                If iAmountH40 + iAmountE40 <> 0 Then
                    xlSheet.Cells(7 + 2 * i, 11) = iAmountH40 + iAmountE40
                End If
                If iAmountH45 + iAmountE45 <> 0 Then
                    xlSheet.Cells(7 + 2 * i, 12) = iAmountH45 + iAmountE45
                End If
                If iAmountH58 + iAmountE58 <> 0 Then
                    xlSheet.Cells(7 + 2 * i, 13) = iAmountH58 + iAmountE58
                End If

                If fWeightH20 <> 0 Then
                    xlSheet.Cells(8 + 2 * i, 2) = fWeightH20
                End If
                If fWeightH40 <> 0 Then
                    xlSheet.Cells(8 + 2 * i, 3) = fWeightH40
                End If
                If fWeightH45 <> 0 Then
                    xlSheet.Cells(8 + 2 * i, 4) = fWeightH45
                End If
                If fWeightH58 <> 0 Then
                    xlSheet.Cells(8 + 2 * i, 5) = fWeightH58
                End If
                If fWeightE20 <> 0 Then
                    xlSheet.Cells(8 + 2 * i, 6) = fWeightE20
                End If
                If fWeightE40 <> 0 Then
                    xlSheet.Cells(8 + 2 * i, 7) = fWeightE40
                End If
                If fWeightE45 <> 0 Then
                    xlSheet.Cells(8 + 2 * i, 8) = fWeightE45
                End If
                If fWeightE58 <> 0 Then
                    xlSheet.Cells(8 + 2 * i, 9) = fWeightE58
                End If
                If fWeightH20 + fWeightE20 <> 0 Then
                    xlSheet.Cells(8 + 2 * i, 10) = fWeightH20 + fWeightE20
                End If
                If fWeightH40 + fWeightE40 <> 0 Then
                    xlSheet.Cells(8 + 2 * i, 11) = fWeightH40 + fWeightE40
                End If
                If fWeightH45 + fWeightE45 <> 0 Then
                    xlSheet.Cells(8 + 2 * i, 12) = fWeightH45 + fWeightE45
                End If
                If fWeightH58 + fWeightE58 <> 0 Then
                    xlSheet.Cells(8 + 2 * i, 13) = fWeightH58 + fWeightE58
                End If

                If iAmountD20 <> 0 Then
                    xlSheet.Cells(7 + 2 * i, 14) = iAmountD20
                End If
                If iAmountD40 <> 0 Then
                    xlSheet.Cells(7 + 2 * i, 15) = iAmountD40
                End If
                If iAmountD45 <> 0 Then
                    xlSheet.Cells(7 + 2 * i, 16) = iAmountD45
                End If
                If iAmountD58 <> 0 Then
                    xlSheet.Cells(7 + 2 * i, 17) = iAmountD58
                End If
                If iAmountR20 <> 0 Then
                    xlSheet.Cells(7 + 2 * i, 18) = iAmountR20
                End If
                If iAmountR40 <> 0 Then
                    xlSheet.Cells(7 + 2 * i, 19) = iAmountR40
                End If
                If iAmountR45 <> 0 Then
                    xlSheet.Cells(7 + 2 * i, 20) = iAmountR45
                End If
                If iAmountR58 <> 0 Then
                    xlSheet.Cells(7 + 2 * i, 21) = iAmountR58
                End If

                If fWeightD20 <> 0 Then
                    xlSheet.Cells(8 + 2 * i, 14) = fWeightD20
                End If
                If fWeightD40 <> 0 Then
                    xlSheet.Cells(8 + 2 * i, 15) = fWeightD40
                End If
                If fWeightD45 <> 0 Then
                    xlSheet.Cells(8 + 2 * i, 16) = fWeightD45
                End If
                If fWeightD58 <> 0 Then
                    xlSheet.Cells(8 + 2 * i, 17) = fWeightD58
                End If
                If fWeightR20 <> 0 Then
                    xlSheet.Cells(8 + 2 * i, 18) = fWeightR20
                End If
                If fWeightR40 <> 0 Then
                    xlSheet.Cells(8 + 2 * i, 19) = fWeightR40
                End If
                If fWeightR45 <> 0 Then
                    xlSheet.Cells(8 + 2 * i, 20) = fWeightR45
                End If
                If fWeightR58 <> 0 Then
                    xlSheet.Cells(8 + 2 * i, 21) = fWeightR58
                End If
                'xlSheet.Cells(7 + 2 * i, 2) = iAmountH20
                'xlSheet.Cells(7 + 2 * i, 3) = iAmountH40
                'xlSheet.Cells(7 + 2 * i, 4) = iAmountH45
                'xlSheet.Cells(7 + 2 * i, 5) = iAmountH58
                'xlSheet.Cells(7 + 2 * i, 6) = iAmountE20
                'xlSheet.Cells(7 + 2 * i, 7) = iAmountE40
                'xlSheet.Cells(7 + 2 * i, 8) = iAmountE45
                'xlSheet.Cells(7 + 2 * i, 9) = iAmountE58
                'xlSheet.Cells(7 + 2 * i, 10) = iAmountH20 + iAmountE20
                'xlSheet.Cells(7 + 2 * i, 11) = iAmountH40 + iAmountE40
                'xlSheet.Cells(7 + 2 * i, 12) = iAmountH45 + iAmountE45
                'xlSheet.Cells(7 + 2 * i, 13) = iAmountH58 + iAmountE58

                'xlSheet.Cells(8 + 2 * i, 2) = fWeightH20
                'xlSheet.Cells(8 + 2 * i, 3) = fWeightH40
                'xlSheet.Cells(8 + 2 * i, 4) = fWeightH45
                'xlSheet.Cells(8 + 2 * i, 5) = fWeightH58
                'xlSheet.Cells(8 + 2 * i, 6) = fWeightE20
                'xlSheet.Cells(8 + 2 * i, 7) = fWeightE40
                'xlSheet.Cells(8 + 2 * i, 8) = fWeightE45
                'xlSheet.Cells(8 + 2 * i, 9) = fWeightE58
                'xlSheet.Cells(8 + 2 * i, 10) = fWeightH20 + fWeightE20
                'xlSheet.Cells(8 + 2 * i, 11) = fWeightH40 + fWeightE40
                'xlSheet.Cells(8 + 2 * i, 12) = fWeightH45 + fWeightE45
                'xlSheet.Cells(8 + 2 * i, 13) = fWeightH58 + fWeightE58

                'xlSheet.Cells(7 + 2 * i, 14) = iAmountD20
                'xlSheet.Cells(7 + 2 * i, 15) = iAmountD40
                'xlSheet.Cells(7 + 2 * i, 16) = iAmountD45
                'xlSheet.Cells(7 + 2 * i, 17) = iAmountD58
                'xlSheet.Cells(7 + 2 * i, 18) = iAmountR20
                'xlSheet.Cells(7 + 2 * i, 19) = iAmountR40
                'xlSheet.Cells(7 + 2 * i, 20) = iAmountR45
                'xlSheet.Cells(7 + 2 * i, 21) = iAmountR58

                'xlSheet.Cells(8 + 2 * i, 14) = fWeightD20
                'xlSheet.Cells(8 + 2 * i, 15) = fWeightD40
                'xlSheet.Cells(8 + 2 * i, 16) = fWeightD45
                'xlSheet.Cells(8 + 2 * i, 17) = fWeightD58
                'xlSheet.Cells(8 + 2 * i, 18) = fWeightR20
                'xlSheet.Cells(8 + 2 * i, 19) = fWeightR40
                'xlSheet.Cells(8 + 2 * i, 20) = fWeightR45
                'xlSheet.Cells(8 + 2 * i, 21) = fWeightR58

                i += 1  '计数器自加

                iAmountE20T += iAmountE20       '记录各项累加和
                iAmountE40T += iAmountE40
                iAmountE45T += iAmountE45
                iAmountE58T += iAmountE58
                iAmountH20T += iAmountH20
                iAmountH40T += iAmountH40
                iAmountH45T += iAmountH45
                iAmountH58T += iAmountH58
                fWeightE20T += fWeightE20
                fWeightE40T += fWeightE40
                fWeightE45T += fWeightE45
                fWeightE58T += fWeightE58
                fWeightH20T += fWeightH20
                fWeightH40T += fWeightH40
                fWeightH45T += fWeightH45
                fWeightH58T += fWeightH58

                iAmountD20T += iAmountD20       '记录各项累加和 (inclusion)
                iAmountD40T += iAmountD40
                iAmountD45T += iAmountD45
                iAmountD58T += iAmountD58
                iAmountR20T += iAmountR20
                iAmountR40T += iAmountR40
                iAmountR45T += iAmountR45
                iAmountR58T += iAmountR58
                fWeightD20T += fWeightD20
                fWeightD40T += fWeightD40
                fWeightD45T += fWeightD45
                fWeightD58T += fWeightD58
                fWeightR20T += fWeightR20
                fWeightR40T += fWeightR40
                fWeightR45T += fWeightR45
                fWeightR58T += fWeightR58
            End If
            xlSheet.Cells(7 + 2 * i, 1) = "—————————————————————————————————————————————————————————————————————————"
            xlSheet.Cells(7 + 2 * i + 1, 1) = "TOTAL" '填充总计数据
            If iAmountH20T <> 0 Then
                xlSheet.Cells(7 + 2 * i + 1, 2) = iAmountH20T
            End If
            If iAmountH40T <> 0 Then
                xlSheet.Cells(7 + 2 * i + 1, 3) = iAmountH40T
            End If
            If iAmountH45T <> 0 Then
                xlSheet.Cells(7 + 2 * i + 1, 4) = iAmountH45T
            End If
            If iAmountH58T <> 0 Then
                xlSheet.Cells(7 + 2 * i + 1, 5) = iAmountH58T
            End If
            If iAmountE20T <> 0 Then
                xlSheet.Cells(7 + 2 * i + 1, 6) = iAmountE20T
            End If
            If iAmountE40T <> 0 Then
                xlSheet.Cells(7 + 2 * i + 1, 7) = iAmountE40T
            End If
            If iAmountE45T <> 0 Then
                xlSheet.Cells(7 + 2 * i + 1, 8) = iAmountE45T
            End If
            If iAmountE58T <> 0 Then
                xlSheet.Cells(7 + 2 * i + 1, 9) = iAmountE58T
            End If
            If iAmountH20T + iAmountE20T <> 0 Then
                xlSheet.Cells(7 + 2 * i + 1, 10) = iAmountH20T + iAmountE20T
            End If
            If iAmountH40T + iAmountE40T <> 0 Then
                xlSheet.Cells(7 + 2 * i + 1, 11) = iAmountH40T + iAmountE40T
            End If
            If iAmountH45T + iAmountE45T <> 0 Then
                xlSheet.Cells(7 + 2 * i + 1, 12) = iAmountH45T + iAmountE45T
            End If
            If iAmountH58T + iAmountE58T <> 0 Then
                xlSheet.Cells(7 + 2 * i + 1, 13) = iAmountH58T + iAmountE58T
            End If

            If fWeightH20T <> 0 Then
                xlSheet.Cells(8 + 2 * i + 1, 2) = fWeightH20T
            End If
            If fWeightH40T <> 0 Then
                xlSheet.Cells(8 + 2 * i + 1, 3) = fWeightH40T
            End If
            If fWeightH45T <> 0 Then
                xlSheet.Cells(8 + 2 * i + 1, 4) = fWeightH45T
            End If
            If fWeightH58T <> 0 Then
                xlSheet.Cells(8 + 2 * i + 1, 5) = fWeightH58T
            End If
            If fWeightE20T <> 0 Then
                xlSheet.Cells(8 + 2 * i + 1, 6) = fWeightE20T
            End If
            If fWeightE40T <> 0 Then
                xlSheet.Cells(8 + 2 * i + 1, 7) = fWeightE40T
            End If
            If fWeightE45T <> 0 Then
                xlSheet.Cells(8 + 2 * i + 1, 8) = fWeightE45T
            End If
            If fWeightE58T <> 0 Then
                xlSheet.Cells(8 + 2 * i + 1, 9) = fWeightE58T
            End If
            If fWeightH20T + fWeightE20T <> 0 Then
                xlSheet.Cells(8 + 2 * i + 1, 10) = fWeightH20T + fWeightE20T
            End If
            If fWeightH40T + fWeightE40T <> 0 Then
                xlSheet.Cells(8 + 2 * i + 1, 11) = fWeightH40T + fWeightE40T
            End If
            If fWeightH45T + fWeightE45T <> 0 Then
                xlSheet.Cells(8 + 2 * i + 1, 12) = fWeightH45T + fWeightE45T
            End If
            If fWeightH58T + fWeightE58T <> 0 Then
                xlSheet.Cells(8 + 2 * i + 1, 13) = fWeightH58T + fWeightE58T
            End If

            If iAmountD20T <> 0 Then
                xlSheet.Cells(7 + 2 * i + 1, 14) = iAmountD20T
            End If
            If iAmountD40T <> 0 Then
                xlSheet.Cells(7 + 2 * i + 1, 15) = iAmountD40T
            End If
            If iAmountD45T <> 0 Then
                xlSheet.Cells(7 + 2 * i + 1, 16) = iAmountD45T
            End If
            If iAmountD58T <> 0 Then
                xlSheet.Cells(7 + 2 * i + 1, 17) = iAmountD58T
            End If
            If iAmountR20T <> 0 Then
                xlSheet.Cells(7 + 2 * i + 1, 18) = iAmountR20T
            End If
            If iAmountR40T <> 0 Then
                xlSheet.Cells(7 + 2 * i + 1, 19) = iAmountR40T
            End If
            If iAmountR45T <> 0 Then
                xlSheet.Cells(7 + 2 * i + 1, 20) = iAmountR45T
            End If
            If iAmountR58T <> 0 Then
                xlSheet.Cells(7 + 2 * i + 1, 21) = iAmountR58T
            End If

            If fWeightD20T <> 0 Then
                xlSheet.Cells(8 + 2 * i + 1, 14) = fWeightD20T
            End If
            If fWeightD40T <> 0 Then
                xlSheet.Cells(8 + 2 * i + 1, 15) = fWeightD40T
            End If
            If fWeightD45T <> 0 Then
                xlSheet.Cells(8 + 2 * i + 1, 16) = fWeightD45T
            End If
            If fWeightD58T <> 0 Then
                xlSheet.Cells(8 + 2 * i + 1, 17) = fWeightD58T
            End If
            If fWeightR20T <> 0 Then
                xlSheet.Cells(8 + 2 * i + 1, 18) = fWeightR20T
            End If
            If fWeightR40T <> 0 Then
                xlSheet.Cells(8 + 2 * i + 1, 19) = fWeightR40T
            End If
            If fWeightR45T <> 0 Then
                xlSheet.Cells(8 + 2 * i + 1, 20) = fWeightR45T
            End If
            If fWeightR58T <> 0 Then
                xlSheet.Cells(8 + 2 * i + 1, 21) = fWeightR58T
            End If
            'xlSheet.Cells(7 + 2 * i + 1, 2) = iAmountH20T
            'xlSheet.Cells(7 + 2 * i + 1, 3) = iAmountH40T
            'xlSheet.Cells(7 + 2 * i + 1, 4) = iAmountH45T
            'xlSheet.Cells(7 + 2 * i + 1, 5) = iAmountH58T
            'xlSheet.Cells(7 + 2 * i + 1, 6) = iAmountE20T
            'xlSheet.Cells(7 + 2 * i + 1, 7) = iAmountE40T
            'xlSheet.Cells(7 + 2 * i + 1, 8) = iAmountE45T
            'xlSheet.Cells(7 + 2 * i + 1, 9) = iAmountE58T
            'xlSheet.Cells(7 + 2 * i + 1, 10) = iAmountH20T + iAmountE20T
            'xlSheet.Cells(7 + 2 * i + 1, 11) = iAmountH40T + iAmountE40T
            'xlSheet.Cells(7 + 2 * i + 1, 12) = iAmountH45T + iAmountE45T
            'xlSheet.Cells(7 + 2 * i + 1, 13) = iAmountH58T + iAmountE58T

            'xlSheet.Cells(8 + 2 * i + 1, 2) = fWeightH20T
            'xlSheet.Cells(8 + 2 * i + 1, 3) = fWeightH40T
            'xlSheet.Cells(8 + 2 * i + 1, 4) = fWeightH45T
            'xlSheet.Cells(8 + 2 * i + 1, 5) = fWeightH58T
            'xlSheet.Cells(8 + 2 * i + 1, 6) = fWeightE20T
            'xlSheet.Cells(8 + 2 * i + 1, 7) = fWeightE40T
            'xlSheet.Cells(8 + 2 * i + 1, 8) = fWeightE45T
            'xlSheet.Cells(8 + 2 * i + 1, 9) = fWeightE58T
            'xlSheet.Cells(8 + 2 * i + 1, 10) = fWeightH20T + fWeightE20T
            'xlSheet.Cells(8 + 2 * i + 1, 11) = fWeightH40T + fWeightE40T
            'xlSheet.Cells(8 + 2 * i + 1, 12) = fWeightH45T + fWeightE45T
            'xlSheet.Cells(8 + 2 * i + 1, 13) = fWeightH58T + fWeightE58T

            'xlSheet.Cells(7 + 2 * i + 1, 14) = iAmountD20T
            'xlSheet.Cells(7 + 2 * i + 1, 15) = iAmountD40T
            'xlSheet.Cells(7 + 2 * i + 1, 16) = iAmountD45T
            'xlSheet.Cells(7 + 2 * i + 1, 17) = iAmountD58T
            'xlSheet.Cells(7 + 2 * i + 1, 18) = iAmountR20T
            'xlSheet.Cells(7 + 2 * i + 1, 19) = iAmountR40T
            'xlSheet.Cells(7 + 2 * i + 1, 20) = iAmountR45T
            'xlSheet.Cells(7 + 2 * i + 1, 21) = iAmountR58T

            'xlSheet.Cells(8 + 2 * i + 1, 14) = fWeightD20T
            'xlSheet.Cells(8 + 2 * i + 1, 15) = fWeightD40T
            'xlSheet.Cells(8 + 2 * i + 1, 16) = fWeightD45T
            'xlSheet.Cells(8 + 2 * i + 1, 17) = fWeightD58T
            'xlSheet.Cells(8 + 2 * i + 1, 18) = fWeightR20T
            'xlSheet.Cells(8 + 2 * i + 1, 19) = fWeightR40T
            'xlSheet.Cells(8 + 2 * i + 1, 20) = fWeightR45T
            'xlSheet.Cells(8 + 2 * i + 1, 21) = fWeightR58T

            xlSheet.Cells(3, 4) = strVessel
            xlSheet.Cells(3, 9) = strVoyage
            xlSheet.Cells(3, 18) = ListDate

            xlSheet.Range(xlSheet.Cells(7, 1), xlSheet.Cells(7 + 2 * i - 1, 1)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 1
            xlSheet.Range(xlSheet.Cells(7, 13), xlSheet.Cells(7 + 2 * i - 1, 13)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = 1
            xlSheet.Range(xlSheet.Cells(7, 21), xlSheet.Cells(7 + 2 * i - 1, 21)).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = 1
            For Row = 8 To 7 + 2 * i Step 2
                xlSheet.Range(xlSheet.Cells(Row, 1), xlSheet.Cells(Row, 21)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = 1
            Next

            If PrintMark = True Then   '打印
                xlSheet.PrintOut()
                xlApp.Quit()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub GetSheetExcelPortSum()
        Dim strVessel, strVoyage As String
        Dim ListDate As Date
        strVessel = dwship.Item(0)("ENG_VESSEL")
        strVoyage = dwship.Item(0)("Voyage")
        ListDate = Now.Date

        Dim i As Integer
        Dim iAmountE20, iAmountE40, iAmountE45, iAmountE58, iAmountH20, iAmountH40, iAmountH45, iAmountH58 As Integer
        Dim iQuantityEFL, iTEU_EFL As Integer
        Dim fWeightEFL, fSizeEFL As Double
        Dim iAmountE20T, iAmountE40T, iAmountE45T, iAmountE58T, iAmountH20T, iAmountH40T, iAmountH45T, iAmountH58T As Integer
        Dim iQuantityT, iTEU_T As Integer
        Dim fWeightT, fSizeT As Double

        Dim strPortPreCode, strPortNowCode, strPort As String
        Dim sqlStateSumary As String
        Dim dvStateSumary As New DataView
        sqlStateSumary = "SELECT CODE_UNLOAD_PORT, MAX(UNLOAD_PORT) AS UnloadPort, FULLOREMPTY, SIZE_CON, COUNT(*) AS ConNum, SUM(AMOUNT) AS ConQuantity, SUM(WEIGHT) AS ConWeight, SUM(VOLUME) AS Size FROM View_ContainerLoadingSumary WHERE (CODE_LOAD_PORT = 'LYG') AND (SHIP_ID = '" & Ship_ID & "') GROUP BY CODE_UNLOAD_PORT, FULLOREMPTY, SIZE_CON ORDER BY CODE_UNLOAD_PORT, FULLOREMPTY, SIZE_CON"
        dvStateSumary = Filldata(sqlStateSumary)

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
            xlSheet = CType(xlBook.Worksheets(10), Excel.Worksheet)
            xlSheet.Select(10)
            xlApp.DisplayAlerts = False
            If PrintMark = False Then   '打印不显示，导出显示
                xlSheet.Application.Visible = True
            End If

            If dvStateSumary.Count > 0 Then
                If Not IsDBNull(dvStateSumary.Item(0)("CODE_UNLOAD_PORT")) Then
                    strPortPreCode = dvStateSumary.Item(0)("CODE_UNLOAD_PORT")   '记下第一个港口代码
                    If Not IsDBNull(dvStateSumary.Item(Row)("UnloadPort")) Then
                        strPort = dvStateSumary.Item(Row)("UnloadPort")   '记下当前港口名
                    End If
                Else
                    strPortPreCode = "-100"     '第一个港口代码没有
                End If
            End If

            For Row = 0 To dvStateSumary.Count - 1
                If Not IsDBNull(dvStateSumary.Item(Row)("CODE_UNLOAD_PORT")) Then
                    strPortNowCode = dvStateSumary.Item(Row)("CODE_UNLOAD_PORT")    '记下当前港口代码
                Else
                    strPortNowCode = "-100"     '当前港口代码没有
                End If
                If strPortNowCode <> strPortPreCode Then '如果前后港口不同了
                    '先填充数据再重新初始化
                    xlSheet.Cells(8 + i, 1) = strPort  '填充数据
                    If iAmountH20 <> 0 Then
                        xlSheet.Cells(8 + i, 2) = iAmountH20
                    End If
                    If iAmountH40 <> 0 Then
                        xlSheet.Cells(8 + i, 3) = iAmountH40
                    End If
                    If iAmountH45 <> 0 Then
                        xlSheet.Cells(8 + i, 4) = iAmountH45
                    End If
                    If iAmountH58 <> 0 Then
                        xlSheet.Cells(8 + i, 5) = iAmountH58
                    End If
                    If iAmountE20 <> 0 Then
                        xlSheet.Cells(8 + i, 6) = iAmountE20
                    End If
                    If iAmountE40 <> 0 Then
                        xlSheet.Cells(8 + i, 7) = iAmountE40
                    End If
                    If iAmountE45 <> 0 Then
                        xlSheet.Cells(8 + i, 8) = iAmountE45
                    End If
                    If iAmountE58 <> 0 Then
                        xlSheet.Cells(8 + i, 9) = iAmountE58
                    End If

                    If iQuantityEFL <> 0 Then
                        xlSheet.Cells(8 + i, 10) = iQuantityEFL
                    End If
                    If fWeightEFL <> 0 Then
                        xlSheet.Cells(8 + i, 11) = fWeightEFL
                    End If
                    If fSizeEFL <> 0 Then
                        xlSheet.Cells(8 + i, 12) = fSizeEFL
                    End If
                    iTEU_EFL = iAmountH20 + iAmountH40 * 2 + iAmountH45 * 2.5 + iAmountH58 * 3 + iAmountE20 + iAmountE40 * 2 + iAmountE45 * 2.5 + iAmountE58 * 3
                    If iTEU_EFL <> 0 Then
                        xlSheet.Cells(8 + i, 13) = iTEU_EFL
                    End If

                    i += 1  '计数器自加

                    iAmountE20T += iAmountE20       '记录各项累加和
                    iAmountE40T += iAmountE40
                    iAmountE45T += iAmountE45
                    iAmountE58T += iAmountE58
                    iAmountH20T += iAmountH20
                    iAmountH40T += iAmountH40
                    iAmountH45T += iAmountH45
                    iAmountH58T += iAmountH58

                    iQuantityT += iQuantityEFL
                    fWeightT += fWeightEFL
                    fSizeT += fSizeEFL

                    'strPortNowCode = strPortPreCode     '初始化
                    strPortPreCode = strPortNowCode   '初始化
                    If Not IsDBNull(dvStateSumary.Item(Row)("UnloadPort")) Then
                        strPort = dvStateSumary.Item(Row)("UnloadPort")   '记下当前港口名
                    End If
                    iAmountE20 = 0
                    iAmountE40 = 0
                    iAmountE45 = 0
                    iAmountE58 = 0
                    iAmountH20 = 0
                    iAmountH40 = 0
                    iAmountH45 = 0
                    iAmountH58 = 0

                    iQuantityEFL = 0
                    fWeightEFL = 0.0
                    fSizeEFL = 0.0

                End If
                '对重箱空箱的统计
                If Not IsDBNull(dvStateSumary.Item(Row)("FULLOREMPTY")) Then

                    If dvStateSumary.Item(Row)("FULLOREMPTY") = "E" Then    '是空箱时
                        If Not IsDBNull(dvStateSumary.Item(Row)("SIZE_CON")) Then
                            If dvStateSumary.Item(Row)("SIZE_CON") = "20" Then
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConNum")) Then
                                    iAmountE20 += dvStateSumary.Item(Row)("ConNum")  '累计20'箱数量 
                                End If
                            ElseIf dvStateSumary.Item(Row)("SIZE_CON") = "40" Then
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConNum")) Then
                                    iAmountE40 += dvStateSumary.Item(Row)("ConNum")  '累计40'箱数量
                                End If
                            ElseIf dvStateSumary.Item(Row)("SIZE_CON") = "45" Then
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConNum")) Then
                                    iAmountE45 += dvStateSumary.Item(Row)("ConNum")  '累计45'箱数量
                                End If
                            ElseIf dvStateSumary.Item(Row)("SIZE_CON") = "58" Then
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConNum")) Then
                                    iAmountE58 += dvStateSumary.Item(Row)("ConNum")  '累计58'箱数量
                                End If
                            End If
                        End If
                    Else             '是重箱时
                        If Not IsDBNull(dvStateSumary.Item(Row)("SIZE_CON")) Then
                            If dvStateSumary.Item(Row)("SIZE_CON") = "20" Then
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConNum")) Then
                                    iAmountH20 += dvStateSumary.Item(Row)("ConNum")  '累计20'箱数量
                                End If
                            ElseIf dvStateSumary.Item(Row)("SIZE_CON") = "40" Then
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConNum")) Then
                                    iAmountH40 += dvStateSumary.Item(Row)("ConNum")  '累计40'箱数量
                                End If
                            ElseIf dvStateSumary.Item(Row)("SIZE_CON") = "45" Then
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConNum")) Then
                                    iAmountH45 += dvStateSumary.Item(Row)("ConNum")  '累计45'箱数量
                                End If
                            ElseIf dvStateSumary.Item(Row)("SIZE_CON") = "58" Then
                                If Not IsDBNull(dvStateSumary.Item(Row)("ConNum")) Then
                                    iAmountH58 += dvStateSumary.Item(Row)("ConNum")  '累计58'箱数量
                                End If
                            End If
                        End If
                    End If

                    If Not IsDBNull(dvStateSumary.Item(Row)("ConQuantity")) Then
                        iQuantityEFL += dvStateSumary.Item(Row)("ConQuantity")  '件数
                    End If
                    If Not IsDBNull(dvStateSumary.Item(Row)("ConWeight")) Then
                        fWeightEFL += dvStateSumary.Item(Row)("ConWeight")  '重量
                    End If
                    If Not IsDBNull(dvStateSumary.Item(Row)("Size")) Then
                        fSizeEFL += dvStateSumary.Item(Row)("Size")     '尺码
                    End If
                End If

            Next

            If dvStateSumary.Count > 0 Then
                xlSheet.Cells(8 + i, 1) = strPort  '填充最后一项数据
                If iAmountH20 <> 0 Then
                    xlSheet.Cells(8 + i, 2) = iAmountH20
                End If
                If iAmountH40 <> 0 Then
                    xlSheet.Cells(8 + i, 3) = iAmountH40
                End If
                If iAmountH45 <> 0 Then
                    xlSheet.Cells(8 + i, 4) = iAmountH45
                End If
                If iAmountH58 <> 0 Then
                    xlSheet.Cells(8 + i, 5) = iAmountH58
                End If
                If iAmountE20 <> 0 Then
                    xlSheet.Cells(8 + i, 6) = iAmountE20
                End If
                If iAmountE40 <> 0 Then
                    xlSheet.Cells(8 + i, 7) = iAmountE40
                End If
                If iAmountE45 <> 0 Then
                    xlSheet.Cells(8 + i, 8) = iAmountE45
                End If
                If iAmountE58 <> 0 Then
                    xlSheet.Cells(8 + i, 9) = iAmountE58
                End If

                If iQuantityEFL <> 0 Then
                    xlSheet.Cells(8 + i, 10) = iQuantityEFL
                End If
                If fWeightEFL <> 0 Then
                    xlSheet.Cells(8 + i, 11) = fWeightEFL
                End If
                If fSizeEFL <> 0 Then
                    xlSheet.Cells(8 + i, 12) = fSizeEFL
                End If
                iTEU_EFL = iAmountH20 + iAmountH40 * 2 + iAmountH45 * 2.5 + iAmountH58 * 3 + iAmountE20 + iAmountE40 * 2 + iAmountE45 * 2.5 + iAmountE58 * 3
                If iTEU_EFL <> 0 Then
                    xlSheet.Cells(8 + i, 13) = iTEU_EFL
                End If

                i += 1  '计数器自加

                iAmountE20T += iAmountE20       '记录各项累加和
                iAmountE40T += iAmountE40
                iAmountE45T += iAmountE45
                iAmountE58T += iAmountE58
                iAmountH20T += iAmountH20
                iAmountH40T += iAmountH40
                iAmountH45T += iAmountH45
                iAmountH58T += iAmountH58

                iQuantityT += iQuantityEFL
                fWeightT += fWeightEFL
                fSizeT += fSizeEFL
            End If
            'xlSheet.Cells(8 + i, 1) = "——————————————————————————————————————————————————————————————————————"
            xlSheet.Cells(8 + i + 1, 1) = "合计"  '填充总计数据
            If iAmountH20T <> 0 Then
                xlSheet.Cells(8 + i + 1, 2) = iAmountH20T
            End If
            If iAmountH40T <> 0 Then
                xlSheet.Cells(8 + i + 1, 3) = iAmountH40T
            End If
            If iAmountH45T <> 0 Then
                xlSheet.Cells(8 + i + 1, 4) = iAmountH45T
            End If
            If iAmountH58T <> 0 Then
                xlSheet.Cells(8 + i + 1, 5) = iAmountH58T
            End If
            If iAmountE20T <> 0 Then
                xlSheet.Cells(8 + i + 1, 6) = iAmountE20T
            End If
            If iAmountE40T <> 0 Then
                xlSheet.Cells(8 + i + 1, 7) = iAmountE40T
            End If
            If iAmountE45T <> 0 Then
                xlSheet.Cells(8 + i + 1, 8) = iAmountE45T
            End If
            If iAmountE58T <> 0 Then
                xlSheet.Cells(8 + i + 1, 9) = iAmountE58T
            End If
            If iQuantityT <> 0 Then
                xlSheet.Cells(8 + i + 1, 10) = iQuantityT
            End If
            If fWeightT <> 0 Then
                xlSheet.Cells(8 + i + 1, 11) = fWeightT
            End If
            If fSizeT <> 0 Then
                xlSheet.Cells(8 + i + 1, 12) = fSizeT
            End If
            iTEU_T = iAmountH20T + iAmountH40T * 2 + iAmountH45T * 2.5 + iAmountH58T * 3 + iAmountE20T + iAmountE40T * 2 + iAmountE45T * 2.5 + iAmountE58T * 3
            If iTEU_T <> 0 Then
                xlSheet.Cells(8 + i + 1, 13) = iTEU_T
            End If

            xlSheet.Cells(4, 2) = strVessel
            xlSheet.Cells(4, 5) = strVoyage
            xlSheet.Cells(4, 12) = ListDate

            For Col = 1 To 13 + 1
                xlSheet.Range(xlSheet.Cells(8, Col), xlSheet.Cells(8 + i - 1, Col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 2
                xlSheet.Range(xlSheet.Cells(8 + i + 1, Col), xlSheet.Cells(8 + i + 1, Col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = 2
            Next
            'fgfffff
            xlSheet.Range(xlSheet.Cells(8 + i, 1), xlSheet.Cells(8 + i, 2)).RowHeight = 8
            For Row = 8 To 8 + i + 1
                xlSheet.Range(xlSheet.Cells(Row, 1), xlSheet.Cells(Row, 13)).Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = 2
            Next

            If PrintMark = True Then   '打印
                xlSheet.PrintOut()
                xlApp.Quit()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub MyGetGridSumNew()
        Getdata("exec SP_Summary_LYG_New " & Ship_ID, dsSummary)
        Getdata("select ENG_VESSEL from sship where ship_id=" & Ship_ID, dsshipname)
        Me.C1DBGSumNew.DataSource = dsSummary.Tables(0).DefaultView
        'TOTAL
        Me.C1DBGSumNew.ColumnFooters = True
        Me.C1DBGSumNew.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGSumNew.Columns.Item("code_port").FooterText = "TOTAL"
        Dim sum As Decimal = 0
        For j = 3 To Me.C1DBGSumNew.Columns.Count - 1
            sum = 0
            For i = 3 To dsSummary.Tables(0).Rows.Count - 1 - 4
                sum = sum + IIf(dsSummary.Tables(0).Rows(i).Item(j) Is System.DBNull.Value, 0, dsSummary.Tables(0).Rows(i).Item(j))
            Next
            If sum > 0 Then
                Me.C1DBGSumNew.Columns.Item(j).FooterText = sum
            End If
        Next
        caption()
        columnswidth()
    End Sub

    Private Sub caption()
        Me.C1DBGSumNew.Splits(0).DisplayColumns.Item("number").Visible = False
    End Sub

    Private Sub columnswidth()
        Dim j As Integer
        For j = 0 To Me.C1DBGSumNew.Columns.Count - 1
            Me.C1DBGSumNew.Splits(0).DisplayColumns.Item(j).AutoSize()
        Next
    End Sub

    Private Sub GetSheetExcelSumNew()
        Dim PathStr As String
        Dim FilePath As String
        Dim Row As Integer
        Dim Col As Integer
        PathStr = CurDir()
        Try
            FileCopy(PathStr + "\zhuweixin.xls", PathStr + "\copy_zhuweixin.xls")
            FilePath = PathStr + "\copy_zhuweixin.xls"
            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            xlBook = CType(xlApp.Workbooks.Open("" & FilePath & ""), Excel.Workbook)
            xlSheet = CType(xlBook.Worksheets("summarylyg"), Excel.Worksheet)
            xlApp.DisplayAlerts = False
            If PrintMark = False Then   '打印不显示，导出显示
                xlSheet.Application.Visible = True
            End If
            xlBook.Worksheets("summarylyg").select()
            'MV.
            xlSheet.Cells(2, 3) = dsshipname.Tables(0).Rows(0).Item("ENG_VESSEL")
            'VOY.
            xlSheet.Cells(2, 8) = G_Voyage
            'DATE
            xlSheet.Cells(2, 11) = DatePart(DateInterval.Year, Today()) & " - " & IIf(DatePart(DateInterval.Month, Today()) < 10, "0" & DatePart(DateInterval.Month, Today()), DatePart(DateInterval.Month, Today())) & "-" & IIf(DatePart(DateInterval.Day, Today()) < 10, "0" & DatePart(DateInterval.Day, Today()), DatePart(DateInterval.Day, Today())) & "  " & DatePart(DateInterval.Hour, Now()) & ":" & DatePart(DateInterval.Minute, Now())

            Me.C1DBGSumNew.MoveFirst()
            Me.C1DBGSumNew.MoveNext()
            Me.C1DBGSumNew.MoveNext()
            Me.C1DBGSumNew.MoveNext()
            For Row = 3 To dsSummary.Tables(0).Rows.Count - 1 '数据
                '卸货港
                xlSheet.Cells(Row + 3, 1) = dsSummary.Tables(0).Rows(Row).Item("code_port")
                '数据
                For Col = 3 To Me.C1DBGSumNew.Columns.Count - 1
                    If Len(Trim(Me.C1DBGSumNew.Columns(Col).Text)) = 0 Then

                    Else
                        xlSheet.Cells(Row + 3, Col) = Me.C1DBGSumNew.Columns(Col).Text.ToString
                    End If
                Next Col
                Me.C1DBGSumNew.MoveNext()
            Next Row
            '写合计TOTAL
            For i = 3 To Me.C1DBGSumNew.Columns.Count - 1
                xlSheet.Cells(26, i) = Me.C1DBGSumNew.Columns.Item(i).FooterText
            Next

            If PrintMark = True Then   '打印
                xlSheet.PrintOut()
                xlApp.Quit()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub mnuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrint.Click
        PrintMark = True
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                'GetSheetExcelSum()
                GetSheetExcelSumNew()
            Case 1
                GetSheetExcelNo()
            Case 2
                GetSheetExcelUnloadPort()
            Case 3
                GetSheetExcelBill()
            Case 4
                GetSheetExcelReefer()
            Case 5
                GetSheetExcelDanger()
            Case 6
                GetSheetExcelCargo()
            Case 7
                GetSheetExcelPortSum()

        End Select
    End Sub

    Private Sub mnuExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExport.Click
        PrintMark = False
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                'GetSheetExcelSum()
                GetSheetExcelSumNew()
            Case 1
                GetSheetExcelNo()
            Case 2
                GetSheetExcelUnloadPort()
            Case 3
                GetSheetExcelBill()
            Case 4
                GetSheetExcelReefer()
            Case 5
                GetSheetExcelDanger()
            Case 6
                GetSheetExcelCargo()
            Case 7
                GetSheetExcelPortSum()
            Case 8
                GetSheetHatchBill()
        End Select
    End Sub

    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        TBar = 1
        Mnu = 1
    End Sub

    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
        TBar = 1
        Mnu = 1
        Me.Close()
    End Sub

    Private Sub ToolBar_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar.ButtonClick
        Select Case Me.ToolBar.Buttons.IndexOf(e.Button)
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

    Private Sub btResure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResure.Click
        SqlStrShip = "where (((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','4','0')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) and Voyage like '" & Trim(txtVoyage.Text) & "%' and (ENG_VESSEL Like '" & Trim(txtShipName.Text) & "%' OR CHI_VESSEL like '" & Trim(txtShipName.Text) & "%' )) "
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
End Class
