Imports TALLY.DBControl
Public Class Frm_con_operate_map
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
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents Label As System.Windows.Forms.Label
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
    Friend WithEvents GBV As System.Windows.Forms.GroupBox
    Friend WithEvents C1DBGV As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btResure As System.Windows.Forms.Button
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolBarV As System.Windows.Forms.ToolBar
    Friend WithEvents tbbtnOK As System.Windows.Forms.ToolBarButton
    Friend WithEvents S2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSearch As System.Windows.Forms.ToolBarButton
    Friend WithEvents S3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSort As System.Windows.Forms.ToolBarButton
    Friend WithEvents S4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnEng As System.Windows.Forms.ToolBarButton
    Friend WithEvents c1dbg As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents tbbtnsummary As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_con_operate_map))
        Me.MainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuFind = New System.Windows.Forms.MenuItem()
        Me.mnuQuery = New System.Windows.Forms.MenuItem()
        Me.mnuSep1 = New System.Windows.Forms.MenuItem()
        Me.mnuPrint = New System.Windows.Forms.MenuItem()
        Me.mnuExport = New System.Windows.Forms.MenuItem()
        Me.mnuSep2 = New System.Windows.Forms.MenuItem()
        Me.mnuQuit = New System.Windows.Forms.MenuItem()
        Me.mnuCompile = New System.Windows.Forms.MenuItem()
        Me.mnuAdd = New System.Windows.Forms.MenuItem()
        Me.mnuEdit = New System.Windows.Forms.MenuItem()
        Me.mnuDelete = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.mnuHelp = New System.Windows.Forms.MenuItem()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.GB = New System.Windows.Forms.GroupBox()
        Me.c1dbg = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label = New System.Windows.Forms.Label()
        Me.ToolBar = New System.Windows.Forms.ToolBar()
        Me.tbbtnFind = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnQuery = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnSep1 = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnAdd = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnEdit = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnDelete = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnSep2 = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnPrint = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnExport = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnSep3 = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnsummary = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnQuit = New System.Windows.Forms.ToolBarButton()
        Me.GBV = New System.Windows.Forms.GroupBox()
        Me.ToolBarV = New System.Windows.Forms.ToolBar()
        Me.tbbtnOK = New System.Windows.Forms.ToolBarButton()
        Me.S2 = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnSearch = New System.Windows.Forms.ToolBarButton()
        Me.S3 = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnSort = New System.Windows.Forms.ToolBarButton()
        Me.S4 = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnEng = New System.Windows.Forms.ToolBarButton()
        Me.C1DBGV = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.txtVoyage = New System.Windows.Forms.TextBox()
        Me.txtShipName = New System.Windows.Forms.TextBox()
        Me.btResure = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GB.SuspendLayout()
        CType(Me.c1dbg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBV.SuspendLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mnuCompile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAdd, Me.mnuEdit, Me.mnuDelete, Me.MenuItem2, Me.MenuItem1})
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
        'MenuItem2
        '
        Me.MenuItem2.Index = 3
        Me.MenuItem2.Text = "-"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 4
        Me.MenuItem1.Text = "滚装船图打印"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.Text = "帮助(&H)"
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
        Me.ImageList.Images.SetKeyName(12, "")
        Me.ImageList.Images.SetKeyName(13, "")
        Me.ImageList.Images.SetKeyName(14, "")
        Me.ImageList.Images.SetKeyName(15, "")
        Me.ImageList.Images.SetKeyName(16, "")
        Me.ImageList.Images.SetKeyName(17, "")
        Me.ImageList.Images.SetKeyName(18, "")
        Me.ImageList.Images.SetKeyName(19, "")
        '
        'GB
        '
        Me.GB.Controls.Add(Me.c1dbg)
        Me.GB.Controls.Add(Me.Label)
        Me.GB.Controls.Add(Me.ToolBar)
        Me.GB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB.Location = New System.Drawing.Point(176, 0)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(592, 397)
        Me.GB.TabIndex = 3
        Me.GB.TabStop = False
        '
        'c1dbg
        '
        Me.c1dbg.AllowHorizontalSplit = True
        Me.c1dbg.AllowVerticalSplit = True
        Me.c1dbg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1dbg.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1dbg.Images.Add(CType(resources.GetObject("c1dbg.Images"), System.Drawing.Image))
        Me.c1dbg.Location = New System.Drawing.Point(3, 93)
        Me.c1dbg.Name = "c1dbg"
        Me.c1dbg.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1dbg.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1dbg.PreviewInfo.ZoomFactor = 75.0R
        Me.c1dbg.PrintInfo.PageSettings = CType(resources.GetObject("c1dbg.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1dbg.Size = New System.Drawing.Size(586, 301)
        Me.c1dbg.TabIndex = 12
        Me.c1dbg.Text = "C1TrueDBGrid1"
        Me.c1dbg.PropBag = resources.GetString("c1dbg.PropBag")
        '
        'Label
        '
        Me.Label.BackColor = System.Drawing.SystemColors.Control
        Me.Label.Location = New System.Drawing.Point(6, 62)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(530, 44)
        Me.Label.TabIndex = 11
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolBar
        '
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnFind, Me.tbbtnQuery, Me.tbbtnSep1, Me.tbbtnAdd, Me.tbbtnEdit, Me.tbbtnDelete, Me.tbbtnSep2, Me.tbbtnPrint, Me.tbbtnExport, Me.tbbtnSep3, Me.tbbtnsummary, Me.ToolBarButton1, Me.tbbtnQuit})
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.Enabled = False
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(3, 17)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(586, 76)
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
        Me.tbbtnQuery.Text = "调箱"
        Me.tbbtnQuery.ToolTipText = "调箱"
        '
        'tbbtnSep1
        '
        Me.tbbtnSep1.ImageIndex = 9
        Me.tbbtnSep1.Name = "tbbtnSep1"
        Me.tbbtnSep1.Text = "查箱"
        Me.tbbtnSep1.ToolTipText = "查箱"
        '
        'tbbtnAdd
        '
        Me.tbbtnAdd.ImageIndex = 14
        Me.tbbtnAdd.Name = "tbbtnAdd"
        Me.tbbtnAdd.Text = "总BAY图"
        Me.tbbtnAdd.ToolTipText = "总BAY图"
        '
        'tbbtnEdit
        '
        Me.tbbtnEdit.ImageIndex = 17
        Me.tbbtnEdit.Name = "tbbtnEdit"
        Me.tbbtnEdit.Text = "总面图"
        Me.tbbtnEdit.ToolTipText = "总面图"
        '
        'tbbtnDelete
        '
        Me.tbbtnDelete.ImageIndex = 15
        Me.tbbtnDelete.Name = "tbbtnDelete"
        Me.tbbtnDelete.Text = "本港BAY图"
        Me.tbbtnDelete.ToolTipText = "本港BAY图"
        '
        'tbbtnSep2
        '
        Me.tbbtnSep2.ImageIndex = 16
        Me.tbbtnSep2.Name = "tbbtnSep2"
        Me.tbbtnSep2.Text = "本港面图"
        Me.tbbtnSep2.ToolTipText = "本港面图"
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
        Me.tbbtnExport.ToolTipText = "导出"
        '
        'tbbtnSep3
        '
        Me.tbbtnSep3.ImageIndex = 18
        Me.tbbtnSep3.Name = "tbbtnSep3"
        Me.tbbtnSep3.Text = "SUMMARY"
        Me.tbbtnSep3.ToolTipText = "SUMMARY"
        '
        'tbbtnsummary
        '
        Me.tbbtnsummary.ImageIndex = 11
        Me.tbbtnsummary.Name = "tbbtnsummary"
        Me.tbbtnsummary.Text = "summary"
        Me.tbbtnsummary.ToolTipText = "summary"
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 14
        Me.ToolBarButton1.Name = "ToolBarButton1"
        Me.ToolBarButton1.Text = "滚装船图"
        Me.ToolBarButton1.ToolTipText = "滚装船图打印"
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
        Me.GBV.Controls.Add(Me.ToolBarV)
        Me.GBV.Controls.Add(Me.C1DBGV)
        Me.GBV.Controls.Add(Me.txtVoyage)
        Me.GBV.Controls.Add(Me.txtShipName)
        Me.GBV.Controls.Add(Me.btResure)
        Me.GBV.Controls.Add(Me.Label2)
        Me.GBV.Controls.Add(Me.Label1)
        Me.GBV.Dock = System.Windows.Forms.DockStyle.Left
        Me.GBV.Location = New System.Drawing.Point(0, 0)
        Me.GBV.Name = "GBV"
        Me.GBV.Size = New System.Drawing.Size(176, 397)
        Me.GBV.TabIndex = 2
        Me.GBV.TabStop = False
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
        Me.ToolBarV.Size = New System.Drawing.Size(170, 41)
        Me.ToolBarV.TabIndex = 20
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
        Me.C1DBGV.PreviewInfo.ZoomFactor = 75.0R
        Me.C1DBGV.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGV.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGV.Size = New System.Drawing.Size(170, 289)
        Me.C1DBGV.TabIndex = 0
        Me.C1DBGV.Text = "C1TrueDBGrid1"
        Me.C1DBGV.PropBag = resources.GetString("C1DBGV.PropBag")
        '
        'txtVoyage
        '
        Me.txtVoyage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVoyage.Location = New System.Drawing.Point(38, 334)
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(88, 21)
        Me.txtVoyage.TabIndex = 16
        '
        'txtShipName
        '
        Me.txtShipName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtShipName.Location = New System.Drawing.Point(38, 310)
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.Size = New System.Drawing.Size(134, 21)
        Me.txtShipName.TabIndex = 15
        '
        'btResure
        '
        Me.btResure.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btResure.Location = New System.Drawing.Point(130, 333)
        Me.btResure.Name = "btResure"
        Me.btResure.Size = New System.Drawing.Size(42, 22)
        Me.btResure.TabIndex = 17
        Me.btResure.Text = "查询"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(7, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "航次"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(7, 310)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "船名"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Frm_con_operate_map
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(768, 397)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.GBV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Menu = Me.MainMenu
        Me.Name = "Frm_con_operate_map"
        Me.Text = "集装箱船图"
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout()
        CType(Me.c1dbg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBV.ResumeLayout(False)
        Me.GBV.PerformLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
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
    Dim strEngShipName As String

    '*********4.1 '***************要修改
    Private Sub Frm_con_operate_map_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call preview("WL4_5") '*****************权限设计 '*************要修改模块号
        Me.Text = Me.Text & "_" & G_DeptName
        SortShip = " Order by Ship_Statu,Dept_Code,id desc " '默认的排序 
        FirmShip = "where DEPT_CODE LIKE '" & G_DeptCode & "%'" '船舶不变的条件设计
        SqlStrShip = "where (DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('0','1','2','3')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0) "
        If G_User_Serial = "WLGCH" Then
            SqlStrShip = "where (DEPT_CODE LIKE '" & G_DeptCode & "%') "
        End If
        Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '*****************调用航次信息
        Me.C1DBGV.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        txtShipName.Text = G_ShipName
        txtVoyage.Text = G_Voyage
        txtShipName.Focus()
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
            Case 0
                SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('0','1','2','3')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) " '船舶可变的条件设计

                SortShip = " Order by Ship_Statu,Dept_Code,id desc "
                Call myDataGridShip(SqlStrShip & inoutstr & SortShip)

            Case 2
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

            Case 4
                Dim FrmSort As New FrmSort
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
        Dim dsShip As New DataSet
        Dim strsql As String
        Dim dw As New DataView
        Dim sqlRepeat As String
        Dim dvRepeat As New DataView
        Dim dsRepeat As New DataSet

        Ship_ID = CType(Me.C1DBGV.Columns.Item("ID").Text.ToString, Integer)

        '执行处理卸货港首字母的存储过程
        ExecSql("exec SP_UNLOAD_PORT_SUBSTITUTE " & Ship_ID)

        strsql = "select * from View_SSHIP where SHIP_ID=" & Ship_ID
        dw = Getdata(strsql, dsShip)
        Label.Text = ""
        If dsShip.Tables(0).DefaultView.Count > 0 Then
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))) > 0 Then
                Label.Text = Label.Text & "中文船名:" & Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL")) & " "
                G_ShipName = Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))
                txtShipName.Text = G_ShipName
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL"))) > 0 Then
                Label.Text = Label.Text & "英文船名:" & Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))) > 0 Then
                Label.Text = Label.Text & "航次:" & Trim(dsShip.Tables(0).Rows(0).Item("Voyage")) & " "
                G_Voyage = Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))
                txtVoyage.Text = G_Voyage
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("InOutPort_Name"))) > 0 Then
                Label.Text = Label.Text & "进出口:" & Trim(dsShip.Tables(0).Rows(0).Item("InOutPort_Name")) & " "
                If dsShip.Tables(0).Rows(0).Item("InOutPort_Name") = "进口" Then
                    GL_IOPORT = "0"
                Else
                    GL_IOPORT = "1"
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
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("File_No"))) > 0 Then
                Label.Text = Label.Text & "档案号:" & Trim(dsShip.Tables(0).Rows(0).Item("File_No")) & " "
            End If
        End If
        FirmStr = " and Ship_ID=" & Ship_ID & " Order by ID " '设计初始条件  在检索后不改变的条件  '***************要修改 或 2>1
        DynaStr = " 2>1 " '设计其它初始条件    在检索后不需要的条件 ***************要修改 或 其它条件
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
        Call preview("WL4_1") '*****************权限设计 '*************要修改模块号
        Call myDataGrid(SelectStr, SqlStr)
        Me.c1dbg.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色

        '显示重复贝位
        sqlRepeat = "SELECT BAYNO,CONTAINER_NO FROM CON_IMAGE WHERE SHIP_ID = " & Ship_ID & " " & _
                   "and BAYNO in (SELECT BAYNO FROM CON_IMAGE WHERE SHIP_ID = " & Ship_ID & " group by BAYNO having count(*)>1)"
        dvRepeat = Getdata(sqlRepeat, dsRepeat)
        If dvRepeat.Count > 0 Then
            MessageBox.Show("本航次有重复贝位的箱子，在打船图前请调整贝位！！！")
        End If

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub myDataGrid(ByVal SelStr As String, ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            '不显示的列名在最前面
            strsql = "select " & SelStr & " CONTAINER_NO,EFL_Name,SIZE_CON,CONTAINER_TYPE,TEMPERATURE_SETTING,SEALNO,BAYNO,CODE_LOAD_PORT,CODE_UNLOAD_PORT,CODE_DELIVERY,BLNO,AMOUNT,GROSSWEIGHT,VOLUME,TEMPERATURE_UNIT,MIN_TEMPERATURE,MAX_TEMPERATURE,DANGER_GRADE,DANGER_PAGENO,DANGER_NO,DANGER_MARK,Demo,ConDemo from view_conimage where " & Sql '******要修改

            Me.c1dbg.DataSource = Getdata(strsql, ds)  ' class dbcontrol getdata fuction
            ColNum = 0 '不显示的列数 '******要修改
            Table_Name = "view_conimage" '操作的数据库表名 ''******要修改

            For i = 0 To ColNum - 1 '设计部显示的列
                Me.c1dbg.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Translate = True
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Validate = True
            'Me.C1DBG.Splits(0).DisplayColumns.Item("Logic").Visible = False
            'Me.C1DBG.Columns.Item("Make_Date").NumberFormat = "yyyy/MM/dd"

            Call SetColumnCaption() '设计列标题
            Call SetColumnWidth() '设计列宽度
            If ds.Tables(0).Rows.Count > 0 Then
                Call SetColumnSum(Sql) '设计合计列
            End If
            'Me.C1DBG.FetchRowStyles = True
            Me.c1dbg.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
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

            Do While i < Me.c1dbg.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.c1dbg.Columns.Item(i).DataField.ToString)) Then
                        Me.c1dbg.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
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
        For j = 0 To Me.c1dbg.Columns.Count - 1
            Me.c1dbg.Splits(0).DisplayColumns.Item(j).AutoSize()
            Me.c1dbg.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If Me.c1dbg.Splits(0).DisplayColumns.Item(j).Width < 60 Then
                Me.c1dbg.Splits(0).DisplayColumns.Item(j).Width = 60
            Else
                If Me.c1dbg.Splits(0).DisplayColumns.Item(j).Width > 120 Then
                    Me.c1dbg.Splits(0).DisplayColumns.Item(j).Width = 120
                End If
            End If

        Next
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
        Me.c1dbg.ColumnFooters = True
        Me.c1dbg.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.c1dbg.Columns.Item(ColNum).FooterText = "合计 共" & ds.Tables(0).Rows.Count & "条"
        Do While i < Me.c1dbg.Columns.Count
            j = 0
            For j = 0 To dset.Tables(0).Rows.Count - 1

                If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = Upper(Trim(Me.c1dbg.Columns.Item(i).DataField.ToString)) And Upper(Trim(dset.Tables(0).Rows(j)("Field_Type"))) = "N" And Trim(dset.Tables(0).Rows(j)("IsOrNoSum")) = "1" Then

                    num = 0
                    For m = 0 To ds.Tables(0).Rows.Count - 1
                        num = num + ds.Tables(0).Rows(m)(i)
                    Next
                    Me.c1dbg.Columns.Item(i).FooterText = CType(num, String)
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
                Call mnuFind_Click(sender, e)
            Case 1
                Call mnuQuery_Click(sender, e)
            Case 2
                '查找箱号
                Dim frm As New Frm_find_container
                frm.ShowDialog()
                Call myDataGrid(SelectStr, SqlStr)
            Case 3
                Call mnuAdd_Click(sender, e)
            Case 4
                Call mnuEdit_Click(sender, e)
            Case 5
                Call mnuDelete_Click(sender, e)
            Case 6 '连云港面图
                Dim frm As New Frm_con_facemap_lyg
                frm.ShowDialog()

            Case 7
                Call mnuPrint_Click(sender, e)
            Case 8
                Call mnuExport_Click(sender, e)
            Case 9
                ''summary
                Dim frm As New Frm_con_summary
                frm.ShowDialog()

            Case 10
                ''summary
                Dim frm As New Frm_con_summary_lyg
                frm.ShowDialog()
            Case 11
                Call MenuItem1_Click(sender, e)
            Case 12
                Me.Close()
        End Select
    End Sub
    Private Sub mnuFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFind.Click
        Dim FrmFind As New FrmFind
        Table_Name = "view_conimage" '可能要修改
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

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        'Dim frm As New Frm_single_bay_movebox()
        'frm.ShowDialog()
        Dim frm As New Frm_bay_compl_print_lyg
        frm.ShowDialog()
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        Dim frm As New Frm_con_facemap_compl
        frm.ShowDialog()
        'frm.Show()
    End Sub

    Private Sub mnuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdd.Click
        'Dim FrmAdd As New FrmCargo_hatch_list_add() '***********要修改
        'If ds.Tables(0).Rows.Count > 0 Then
        '    ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
        'Else
        '    ID = -1
        'End If
        'FrmAdd.ShowDialog()
        'Try
        '    Call myDataGrid(SelectStr, SqlStr)

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        Dim frm As New Frm_bay_compl_print
        frm.ShowDialog()
        'frm.Show()
    End Sub

    Private Sub C1DBG_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Call mnuQuery_Click(sender, e)
    End Sub

    Private Sub C1DBG_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            If Me.c1dbg.Col = Me.c1dbg.Columns.Count - 1 And Me.c1dbg.Row < ds.Tables(0).Rows.Count - 1 Then
                Me.c1dbg.Row = Me.c1dbg.Row + 1
                Me.c1dbg.Col = ColNum
            End If
        End If
    End Sub

    Private Sub mnuQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuery.Click
        'If ds.Tables(0).Rows.Count > 0 Then
        '    Dim FrmQuery As New FrmCargo_hatch_list_query() '***********要修改
        '    ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
        '    FrmQuery.ShowDialog()
        'End If
        Dim frm As New Frm_double_bay_movebox
        frm.ShowDialog()
    End Sub


    Private Sub mnuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrint.Click
        Call PrintExcel()
    End Sub

    Private Sub mnuExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExport.Click
        Call ExportExcel()
    End Sub
    Private Sub ExportExcel() '导出Excel        
        Call MakeExcel()
    End Sub
    Private Sub PrintExcel() '打印到Excel        

        Dim Row As Integer
        Dim Col As Integer

        Try
            Call MakeExcel()

            Row = ds.Tables(0).Rows.Count + 4
            Col = Me.c1dbg.Columns.Count - ColNum
            '**************画边框
            For Row = 2 To ds.Tables(0).Rows.Count + 4 '画列
                xlSheet.Range(xlSheet.Cells(Row, 1), xlSheet.Cells(Row, c1dbg.Columns.Count - ColNum)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = 7
            Next Row
            For Col = 1 To c1dbg.Columns.Count - ColNum + 1 '画行
                xlSheet.Range(xlSheet.Cells(3, Col), xlSheet.Cells(ds.Tables(0).Rows.Count + 4, Col)).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = 7
            Next Col

        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try

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

            For Col = ColNum To Me.c1dbg.Columns.Count - 1 '列标题
                xlSheet.Cells(3, Col - ColNum + 1) = Me.c1dbg.Columns(Col).Caption

            Next Col
            Me.c1dbg.MoveFirst()
            For Row = 0 To ds.Tables(0).Rows.Count - 1 '数据
                For Col = ColNum To Me.c1dbg.Columns.Count - 1
                    xlSheet.Cells(Row + 4, Col - ColNum + 1) = Me.c1dbg.Columns(Col).Text.ToString      'ds.Tables(0).Rows(Row)(Col)
                Next Col
                Me.c1dbg.MoveNext()
            Next Row
            If Me.c1dbg.ColumnFooters = True Then '合计项
                For Col = ColNum To Me.c1dbg.Columns.Count - 1
                    xlSheet.Cells(ds.Tables(0).Rows.Count + 4, Col - ColNum + 1) = Me.c1dbg.Columns(Col).FooterText
                Next Col
            End If
        Catch
            xlApp.Quit()
            SendKeys.Send("N")
        End Try

    End Sub

    'Private Sub preview(ByVal Func As String) '***************权限设计
    '    Dim sqlstr As String
    '    Dim Previewdv As DataView
    '    Dim Previewds As New DataSet()
    '    Dim i As Integer
    '    sqlstr = " select FUNC_CODE_Add,FUNC_CODE_Change,FUNC_CODE_Del from View_UserPreview where PART_ID=" & G_Part_Id & " and FUNC_CODE='" & Upper(Func) & "' "
    '    Previewdv = Getdata(sqlstr, Previewds)
    '    If Previewdv.Count > 0 Then
    '        If Previewdv(i)("FUNC_CODE_Add") = 1 Then 'ADD 按钮可见
    '            ToolBar.Buttons.Item(3).Enabled = True
    '            mnuAdd.Enabled = True
    '        Else                                      'ADD 按钮不可见
    '            Me.ToolBar.Buttons.Item(3).Enabled = False
    '            mnuAdd.Enabled = False
    '        End If
    '        If Previewdv(i)("FUNC_CODE_Change") = 1 Then '修改 按钮可见
    '            Me.ToolBar.Buttons.Item(4).Enabled = True
    '            mnuEdit.Enabled = True
    '        Else                                          '修改 按钮不可见
    '            Me.ToolBar.Buttons.Item(4).Enabled = False
    '            mnuEdit.Enabled = False
    '        End If
    '        If Previewdv(i)("FUNC_CODE_Del") = 1 Then '删除 按钮可见
    '            Me.ToolBar.Buttons.Item(5).Enabled = True
    '            mnuDelete.Enabled = True
    '        Else                                     '删除按钮不可见
    '            Me.ToolBar.Buttons.Item(5).Enabled = False
    '            mnuDelete.Enabled = False
    '        End If
    '    End If

    'End Sub
    Private Sub C1DBG_FetchRowStyle(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs)
        If Me.c1dbg.Columns("Logic").CellValue(e.Row) = 1 Then
            e.CellStyle.BackColor = System.Drawing.Color.LemonChiffon
        End If

    End Sub

    Private Sub Frm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.C1DBGV.Height = Me.Height - 140
        Me.c1dbg.Height = Me.Height - 135
        Me.c1dbg.Width = Me.GB.Width - 5
        Me.Label.Width = Me.c1dbg.Width - 3
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
            Else                                     '删除按钮不可见
                Me.ToolBar.Buttons.Item(5).Enabled = False
                mnuDelete.Enabled = False
            End If
        End If

    End Sub

    Private Sub btResure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResure.Click
        SqlStrShip = "where (((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('0','1','2','3','4')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) and Voyage like '" & Trim(txtVoyage.Text) & "%' and (ENG_VESSEL Like '" & Trim(txtShipName.Text) & "%' OR CHI_VESSEL like '" & Trim(txtShipName.Text) & "%' )) "
        '可能要修改
        G_ShipName = Trim(txtShipName.Text)
        G_Voyage = Trim(txtVoyage.Text)
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

    Private Sub GB_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GB.Enter

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub C1DBGV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1DBGV.Click

    End Sub

    Enum ExcelShipName
        猎鹰
        中韩之星
    End Enum
    Dim esShip As ExcelShipName

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Select Case G_ShipName
            Case "猎鹰"
                myDataGrid(SelectStr, DynaStr & FirmStr)
                If ds.Tables(0).Rows.Count > 0 Then
                    MakeExcel(G_ShipName & "贝位规范", ds)
                End If
            Case "中韩之星"
                Dim sqlConTray As String
                Dim dsConTray As New DataSet
                sqlConTray = "ConImage_TrayFull " & Ship_ID
                Getdata(sqlConTray, dsConTray)
                If dsConTray.Tables(0).Rows.Count > 0 Then
                    MakeExcel(G_ShipName & "贝位规范", dsConTray)
                End If
        End Select
        GC.Collect()
    End Sub

    Private Sub MakeExcel(ByVal strExcelName As String, ByVal ds As DataSet)
        Dim a, b As Integer 'Excel行列
        Dim i, j As Integer
        Dim PathStr As String = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        Dim strPath As String = PathStr & strExcelName & ".xls"
        Dim xlApp As Excel.Application
        Try
            xlApp = New Excel.ApplicationClass
            Dim xlBook As Excel.Workbook
            xlBook = xlApp.Workbooks.Add(strPath)
            Select Case G_ShipName
                Case "猎鹰"
                    Fill_Falcon(xlBook)
                Case "中韩之星"
                    Fill_CKStar(xlBook, ds)
            End Select

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
            xlApp.Quit()
        End Try
    End Sub

    '绘制猎鹰船图
    Private Sub Fill_Falcon(ByVal xlBook As Excel.Workbook)
        Dim xlSheet As Excel.Worksheet
        Dim strSheetName As String
        Dim i As Integer

        FillImageCell.c1dbg = Me.c1dbg
        ds.Tables(0).DefaultView.RowFilter = "len(BayNo)>=6"     '选出贝位不空的数据
        'ORIGINAL面图
        strSheetName = "ORIGINAL"
        xlSheet = xlBook.Worksheets(strSheetName)
        xlSheet.Activate()
        xlSheet.Cells(2, "O") = strEngShipName
        xlSheet.Cells(2, "S") = G_Voyage
        xlSheet.Cells(2, "AF") = Now.Date
        FillImageCell.xlSheet = xlSheet
        For i = 0 To ds.Tables(0).DefaultView.Count - 1
            FillImageCell_Falcon.FillOriginalCell(i)
        Next

        ds.Tables(0).DefaultView.RowFilter = "len(BayNo)>=6 and Substring(BayNo,len(BayNo)-1,1) >='8'"     '选出MAIN DECK上面的记录
        'MAIN DECK面图
        strSheetName = "MAIN DECK"
        xlSheet = xlBook.Worksheets(strSheetName)
        'xlSheet.Activate()
        xlSheet.Cells(2, "O") = strEngShipName
        xlSheet.Cells(2, "S") = G_Voyage
        xlSheet.Cells(2, "AF") = Now.Date
        FillImageCell.xlSheet = xlSheet
        For i = 0 To ds.Tables(0).DefaultView.Count - 1
            FillImageCell_Falcon.FillMainDeckCell(i)
        Next

        ds.Tables(0).DefaultView.RowFilter = "len(BayNo)>=6 and Substring(BayNo,len(BayNo)-1,1) <'8'"     '选出MAIN DECK下面的记录
        'CAR DECK面图
        strSheetName = "CAR DECK"
        xlSheet = xlBook.Worksheets(strSheetName)
        'xlSheet.Activate()
        xlSheet.Cells(2, "K") = strEngShipName
        xlSheet.Cells(2, "O") = G_Voyage
        xlSheet.Cells(2, "AB") = Now.Date
        FillImageCell.xlSheet = xlSheet
        For i = 0 To ds.Tables(0).DefaultView.Count - 1
            FillImageCell_Falcon.FillCarDeckCell(i)
        Next

        'FREEBOARD DECK面图
        strSheetName = "FREEBOARD DECK"
        xlSheet = xlBook.Worksheets(strSheetName)
        'xlSheet.Activate()
        xlSheet.Cells(2, "K") = strEngShipName
        xlSheet.Cells(2, "O") = G_Voyage
        xlSheet.Cells(2, "AB") = Now.Date
        FillImageCell.xlSheet = xlSheet
        For i = 0 To ds.Tables(0).DefaultView.Count - 1
            FillImageCell_Falcon.FillFreeBoardDeckCell(i)
        Next

        'LOWER HOLD面图
        strSheetName = "LOWER HOLD"
        xlSheet = xlBook.Worksheets(strSheetName)
        'xlSheet.Activate()
        xlSheet.Cells(2, "K") = strEngShipName
        xlSheet.Cells(2, "O") = G_Voyage
        xlSheet.Cells(2, "AB") = Now.Date
        FillImageCell.xlSheet = xlSheet
        For i = 0 To ds.Tables(0).DefaultView.Count - 1
            FillImageCell_Falcon.FillLowerHoldCell(i)
        Next

        ds.Tables(0).DefaultView.RowFilter = ""     '取消筛选   
        'xlSheet = xlBook.Worksheets("ORIGINAL")
        'xlSheet.Activate()
    End Sub

    '中韩之星船图统计
    Private Sub MapCKStat(ByVal xlSheet As Excel.Worksheet, ByVal dvStat As DataView, ByVal iStartRow As Integer)
        Dim i As Integer
        For i = 0 To dvStat.Count - 1
            xlSheet.Cells(iStartRow + i, "AH") = dvStat(i)("A20Con")
            xlSheet.Cells(iStartRow + i, "AP") = dvStat(i)("A20Weight")
            xlSheet.Cells(iStartRow + i, "AZ") = dvStat(i)("A40Con")
            xlSheet.Cells(iStartRow + i, "BH") = dvStat(i)("A40Weight")
        Next
    End Sub
    '绘制中韩之星船图
    Private Sub Fill_CKStar(ByVal xlBook As Excel.Workbook, ByVal ds As DataSet)
        Dim xlSheet As Excel.Worksheet
        Dim strSheetName As String
        Dim i As Integer

        Dim sqlStat As String   '箱数统计
        Dim dvStat As DataView
        Dim sqlTray As String   '托盘数统计
        Dim dvTray As DataView
        sqlTray = "select Tray,Left(Tray,1) TraySize,Max(BayNo) BayNo from Con_Image_Tray where Ship_ID=" & Ship_ID & " Group by Tray"
        dvTray = Filldata(sqlTray)

        FillImageCell.dv = ds.Tables(0).DefaultView
        ds.Tables(0).DefaultView.RowFilter = "len(BayNo)>=6"     '选出贝位不空的数据
        'ORIGINAL面图
        strSheetName = "ORIGINAL"
        xlSheet = xlBook.Worksheets(strSheetName)
        xlSheet.Activate()
        'xlSheet.Cells(6, "N") = strEngShipName
        xlSheet.Cells(6, "BT") = G_Voyage
        FillImageCell.xlSheet = xlSheet
        For i = 0 To ds.Tables(0).DefaultView.Count - 1
            FillImageCell_CKStar.FillOriginalCell(i)
        Next
        'Original统计
        sqlStat = "ConImage_TrayTotal " & Ship_ID & ",'" & FillImageCell.dv.RowFilter & "'"
        dvStat = Filldata(sqlStat)
        MapCKStat(xlSheet, dvStat, 130)
        dvTray.RowFilter = FillImageCell.dv.RowFilter & " and TraySize='S'"
        If dvTray.Count > 0 Then xlSheet.Cells(130, "CJ") = dvTray.Count
        dvTray.RowFilter = FillImageCell.dv.RowFilter & " and TraySize<>'S'"
        If dvTray.Count > 0 Then xlSheet.Cells(130, "CU") = dvTray.Count

        ds.Tables(0).DefaultView.RowFilter = "len(BayNo)>=6 and Substring(BayNo,len(BayNo)-1,1) >='8'"     '选出C-DECK的记录
        'C-DECK面图
        strSheetName = "C-DECK"
        xlSheet = xlBook.Worksheets(strSheetName)
        'xlSheet.Activate()
        xlSheet.Cells(6, "BT") = G_Voyage
        FillImageCell.xlSheet = xlSheet
        For i = 0 To ds.Tables(0).DefaultView.Count - 1
            FillImageCell_CKStar.FillCDeckCell(i)
        Next
        '统计
        sqlStat = "ConImage_TrayTotal " & Ship_ID & ",""" & FillImageCell.dv.RowFilter & """"   '字符串中遇到双引号用两个双引号转换，而不是什么转义字符
        dvStat = Filldata(sqlStat)
        MapCKStat(xlSheet, dvStat, 130)
        dvTray.RowFilter = FillImageCell.dv.RowFilter & " and TraySize='S'"
        If dvTray.Count > 0 Then xlSheet.Cells(130, "CJ") = dvTray.Count
        dvTray.RowFilter = FillImageCell.dv.RowFilter & " and TraySize<>'S'"
        If dvTray.Count > 0 Then xlSheet.Cells(130, "CU") = dvTray.Count

        ds.Tables(0).DefaultView.RowFilter = "len(BayNo)>=6 and Substring(BayNo,len(BayNo)-1,1) <'8'"     '选出D-DECK的记录
        'D-DECK面图
        strSheetName = "D-DECK"
        xlSheet = xlBook.Worksheets(strSheetName)
        'xlSheet.Activate()
        xlSheet.Cells(6, "BT") = G_Voyage
        FillImageCell.xlSheet = xlSheet
        For i = 0 To ds.Tables(0).DefaultView.Count - 1
            FillImageCell_CKStar.FillDDeckCell(i)
        Next
        '统计
        sqlStat = "ConImage_TrayTotal " & Ship_ID & ",""" & FillImageCell.dv.RowFilter & """"
        dvStat = Filldata(sqlStat)
        MapCKStat(xlSheet, dvStat, 130)
        dvTray.RowFilter = FillImageCell.dv.RowFilter & " and TraySize='S'"
        If dvTray.Count > 0 Then xlSheet.Cells(130, "CJ") = dvTray.Count
        dvTray.RowFilter = FillImageCell.dv.RowFilter & " and TraySize<>'S'"
        If dvTray.Count > 0 Then xlSheet.Cells(130, "CU") = dvTray.Count

        ds.Tables(0).DefaultView.RowFilter = ""     '取消筛选   
    End Sub
End Class

