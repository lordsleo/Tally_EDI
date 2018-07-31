Imports TALLY.DBControl
Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.Math
Public Class Frm_bay_map
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
    Friend WithEvents GB As System.Windows.Forms.GroupBox
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
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents ptbox_board As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_bay As System.Windows.Forms.ComboBox
    Friend WithEvents ptbox_cabin As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_copy As System.Windows.Forms.ComboBox
    Friend WithEvents ptbox_result_board As System.Windows.Forms.PictureBox
    Friend WithEvents ptbox_result_cabin As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ckb_joint As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_unuse_col As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_unuse_col_cabin As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmb_exist_bay As System.Windows.Forms.ComboBox
    Friend WithEvents btResure As System.Windows.Forms.Button
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents werwer As System.Windows.Forms.Label
    Friend WithEvents ToolBarV As System.Windows.Forms.ToolBar
    Friend WithEvents tbbtnOK As System.Windows.Forms.ToolBarButton
    Friend WithEvents S2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSearch As System.Windows.Forms.ToolBarButton
    Friend WithEvents S3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSort As System.Windows.Forms.ToolBarButton
    Friend WithEvents S4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnEng As System.Windows.Forms.ToolBarButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_bay_map))
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
        Me.GB = New System.Windows.Forms.GroupBox
        Me.cmb_exist_bay = New System.Windows.Forms.ComboBox
        Me.cmb_unuse_col = New System.Windows.Forms.ComboBox
        Me.ckb_joint = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ptbox_result_board = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ptbox_cabin = New System.Windows.Forms.PictureBox
        Me.cmb_bay = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ptbox_board = New System.Windows.Forms.PictureBox
        Me.Label = New System.Windows.Forms.Label
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
        Me.cmb_copy = New System.Windows.Forms.ComboBox
        Me.ptbox_result_cabin = New System.Windows.Forms.PictureBox
        Me.cmb_unuse_col_cabin = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.werwer = New System.Windows.Forms.Label
        Me.GBV = New System.Windows.Forms.GroupBox
        Me.ToolBarV = New System.Windows.Forms.ToolBar
        Me.tbbtnOK = New System.Windows.Forms.ToolBarButton
        Me.S2 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSearch = New System.Windows.Forms.ToolBarButton
        Me.S3 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSort = New System.Windows.Forms.ToolBarButton
        Me.S4 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnEng = New System.Windows.Forms.ToolBarButton
        Me.C1DBGV = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btResure = New System.Windows.Forms.Button
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GB.SuspendLayout()
        CType(Me.ptbox_result_board, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbox_cabin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbox_board, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptbox_result_cabin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBV.SuspendLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'GB
        '
        Me.GB.Controls.Add(Me.cmb_exist_bay)
        Me.GB.Controls.Add(Me.cmb_unuse_col)
        Me.GB.Controls.Add(Me.ckb_joint)
        Me.GB.Controls.Add(Me.Label4)
        Me.GB.Controls.Add(Me.ptbox_result_board)
        Me.GB.Controls.Add(Me.Label3)
        Me.GB.Controls.Add(Me.ptbox_cabin)
        Me.GB.Controls.Add(Me.cmb_bay)
        Me.GB.Controls.Add(Me.Label1)
        Me.GB.Controls.Add(Me.ptbox_board)
        Me.GB.Controls.Add(Me.Label)
        Me.GB.Controls.Add(Me.ToolBar)
        Me.GB.Controls.Add(Me.cmb_copy)
        Me.GB.Controls.Add(Me.ptbox_result_cabin)
        Me.GB.Controls.Add(Me.cmb_unuse_col_cabin)
        Me.GB.Controls.Add(Me.Label5)
        Me.GB.Controls.Add(Me.Label6)
        Me.GB.Controls.Add(Me.werwer)
        Me.GB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GB.Location = New System.Drawing.Point(186, 0)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(844, 685)
        Me.GB.TabIndex = 3
        Me.GB.TabStop = False
        '
        'cmb_exist_bay
        '
        Me.cmb_exist_bay.Enabled = False
        Me.cmb_exist_bay.Location = New System.Drawing.Point(180, 121)
        Me.cmb_exist_bay.Name = "cmb_exist_bay"
        Me.cmb_exist_bay.Size = New System.Drawing.Size(54, 20)
        Me.cmb_exist_bay.TabIndex = 25
        '
        'cmb_unuse_col
        '
        Me.cmb_unuse_col.Enabled = False
        Me.cmb_unuse_col.Items.AddRange(New Object() {"", "左边", "右边"})
        Me.cmb_unuse_col.Location = New System.Drawing.Point(352, 121)
        Me.cmb_unuse_col.Name = "cmb_unuse_col"
        Me.cmb_unuse_col.Size = New System.Drawing.Size(62, 20)
        Me.cmb_unuse_col.TabIndex = 24
        '
        'ckb_joint
        '
        Me.ckb_joint.Enabled = False
        Me.ckb_joint.Location = New System.Drawing.Point(238, 119)
        Me.ckb_joint.Name = "ckb_joint"
        Me.ckb_joint.Size = New System.Drawing.Size(52, 24)
        Me.ckb_joint.TabIndex = 22
        Me.ckb_joint.Text = "通贝"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(-6, 400)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(850, 12)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "…………………………………………………………………………………………………………………………………………………………………………………………"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ptbox_result_board
        '
        Me.ptbox_result_board.Enabled = False
        Me.ptbox_result_board.Location = New System.Drawing.Point(422, 174)
        Me.ptbox_result_board.Name = "ptbox_result_board"
        Me.ptbox_result_board.Size = New System.Drawing.Size(421, 221)
        Me.ptbox_result_board.TabIndex = 20
        Me.ptbox_result_board.TabStop = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(538, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 23)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "复制BAY"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ptbox_cabin
        '
        Me.ptbox_cabin.Enabled = False
        Me.ptbox_cabin.Location = New System.Drawing.Point(0, 416)
        Me.ptbox_cabin.Name = "ptbox_cabin"
        Me.ptbox_cabin.Size = New System.Drawing.Size(421, 221)
        Me.ptbox_cabin.TabIndex = 18
        Me.ptbox_cabin.TabStop = False
        '
        'cmb_bay
        '
        Me.cmb_bay.Enabled = False
        Me.cmb_bay.Items.AddRange(New Object() {"01", "03", "05", "07", "09", "11", "13", "15", "17", "19", "21", "23", "25", "27", "29", "31", "33", "35", "37", "39", "41", "43", "45", "47", "49", "51", "53", "55", "57", "59", "61", "63", "65", "67", "69", "71", "73", "75", "77", "79", "81", "83", "85", "87", "89", "91", "93", "95", "97", "99"})
        Me.cmb_bay.Location = New System.Drawing.Point(66, 121)
        Me.cmb_bay.Name = "cmb_bay"
        Me.cmb_bay.Size = New System.Drawing.Size(54, 20)
        Me.cmb_bay.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "定义BAY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ptbox_board
        '
        Me.ptbox_board.Enabled = False
        Me.ptbox_board.Location = New System.Drawing.Point(0, 154)
        Me.ptbox_board.Name = "ptbox_board"
        Me.ptbox_board.Size = New System.Drawing.Size(421, 221)
        Me.ptbox_board.TabIndex = 14
        Me.ptbox_board.TabStop = False
        '
        'Label
        '
        Me.Label.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label.BackColor = System.Drawing.SystemColors.Control
        Me.Label.Location = New System.Drawing.Point(8, 64)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(828, 44)
        Me.Label.TabIndex = 13
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
        Me.ToolBar.Size = New System.Drawing.Size(838, 41)
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
        Me.tbbtnQuery.Text = "定义"
        Me.tbbtnQuery.ToolTipText = "定义"
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
        Me.tbbtnAdd.Text = "确认"
        Me.tbbtnAdd.ToolTipText = "确认"
        '
        'tbbtnEdit
        '
        Me.tbbtnEdit.ImageIndex = 3
        Me.tbbtnEdit.Name = "tbbtnEdit"
        Me.tbbtnEdit.Text = "编辑"
        Me.tbbtnEdit.ToolTipText = "编辑"
        '
        'tbbtnDelete
        '
        Me.tbbtnDelete.ImageIndex = 4
        Me.tbbtnDelete.Name = "tbbtnDelete"
        Me.tbbtnDelete.Text = "删除"
        Me.tbbtnDelete.ToolTipText = "删除"
        '
        'tbbtnSep2
        '
        Me.tbbtnSep2.Name = "tbbtnSep2"
        Me.tbbtnSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
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
        Me.tbbtnExport.Text = "面图"
        Me.tbbtnExport.ToolTipText = "面图"
        '
        'tbbtnSep3
        '
        Me.tbbtnSep3.Name = "tbbtnSep3"
        Me.tbbtnSep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnQuit
        '
        Me.tbbtnQuit.ImageIndex = 7
        Me.tbbtnQuit.Name = "tbbtnQuit"
        Me.tbbtnQuit.Text = "退出"
        Me.tbbtnQuit.ToolTipText = "退出"
        '
        'cmb_copy
        '
        Me.cmb_copy.Enabled = False
        Me.cmb_copy.Location = New System.Drawing.Point(596, 121)
        Me.cmb_copy.Name = "cmb_copy"
        Me.cmb_copy.Size = New System.Drawing.Size(54, 20)
        Me.cmb_copy.TabIndex = 16
        '
        'ptbox_result_cabin
        '
        Me.ptbox_result_cabin.Enabled = False
        Me.ptbox_result_cabin.Location = New System.Drawing.Point(422, 436)
        Me.ptbox_result_cabin.Name = "ptbox_result_cabin"
        Me.ptbox_result_cabin.Size = New System.Drawing.Size(421, 221)
        Me.ptbox_result_cabin.TabIndex = 18
        Me.ptbox_result_cabin.TabStop = False
        '
        'cmb_unuse_col_cabin
        '
        Me.cmb_unuse_col_cabin.Enabled = False
        Me.cmb_unuse_col_cabin.Items.AddRange(New Object() {"", "左边", "右边"})
        Me.cmb_unuse_col_cabin.Location = New System.Drawing.Point(472, 121)
        Me.cmb_unuse_col_cabin.Name = "cmb_unuse_col_cabin"
        Me.cmb_unuse_col_cabin.Size = New System.Drawing.Size(62, 20)
        Me.cmb_unuse_col_cabin.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(416, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 23)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "舱内空列"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(124, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 23)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "修改BAY"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'werwer
        '
        Me.werwer.Location = New System.Drawing.Point(296, 120)
        Me.werwer.Name = "werwer"
        Me.werwer.Size = New System.Drawing.Size(54, 23)
        Me.werwer.TabIndex = 23
        Me.werwer.Text = "甲板空列"
        Me.werwer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GBV
        '
        Me.GBV.Controls.Add(Me.ToolBarV)
        Me.GBV.Controls.Add(Me.C1DBGV)
        Me.GBV.Controls.Add(Me.btResure)
        Me.GBV.Controls.Add(Me.txtVoyage)
        Me.GBV.Controls.Add(Me.Label7)
        Me.GBV.Controls.Add(Me.txtShipName)
        Me.GBV.Controls.Add(Me.Label8)
        Me.GBV.Dock = System.Windows.Forms.DockStyle.Left
        Me.GBV.Location = New System.Drawing.Point(0, 0)
        Me.GBV.Name = "GBV"
        Me.GBV.Size = New System.Drawing.Size(186, 685)
        Me.GBV.TabIndex = 2
        Me.GBV.TabStop = False
        '
        'ToolBarV
        '
        Me.ToolBarV.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnOK, Me.S2, Me.tbbtnSearch, Me.S3, Me.tbbtnSort, Me.S4, Me.tbbtnEng})
        Me.ToolBarV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBarV.DropDownArrows = True
        Me.ToolBarV.ImageList = Me.ImageList
        Me.ToolBarV.Location = New System.Drawing.Point(3, 641)
        Me.ToolBarV.Name = "ToolBarV"
        Me.ToolBarV.ShowToolTips = True
        Me.ToolBarV.Size = New System.Drawing.Size(180, 41)
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
        Me.C1DBGV.PreviewInfo.ZoomFactor = 75
        Me.C1DBGV.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGV.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGV.Size = New System.Drawing.Size(180, 571)
        Me.C1DBGV.TabIndex = 0
        Me.C1DBGV.Text = "C1TrueDBGrid1"
        Me.C1DBGV.PropBag = resources.GetString("C1DBGV.PropBag")
        '
        'btResure
        '
        Me.btResure.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btResure.Location = New System.Drawing.Point(138, 622)
        Me.btResure.Name = "btResure"
        Me.btResure.Size = New System.Drawing.Size(42, 22)
        Me.btResure.TabIndex = 17
        Me.btResure.Text = "查询"
        '
        'txtVoyage
        '
        Me.txtVoyage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVoyage.Location = New System.Drawing.Point(36, 622)
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(100, 21)
        Me.txtVoyage.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.Location = New System.Drawing.Point(2, 622)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 20)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "航次"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShipName
        '
        Me.txtShipName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtShipName.Location = New System.Drawing.Point(36, 598)
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.Size = New System.Drawing.Size(144, 21)
        Me.txtShipName.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Location = New System.Drawing.Point(2, 598)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "船名"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Frm_bay_map
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(1030, 685)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.GBV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Menu = Me.MainMenu
        Me.Name = "Frm_bay_map"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "集装箱bay图"
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout()
        CType(Me.ptbox_result_board, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbox_cabin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbox_board, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptbox_result_cabin, System.ComponentModel.ISupportInitialize).EndInit()
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

    '*********4.2 '***************要修改
    Dim g_line As Graphics
    Dim pen_line As New Pen(Color.Black, 1)
    Dim i, j As Integer
    Dim rbmp As Bitmap
    Dim rbmpgraphics As Graphics
    Dim m, n, k As Integer
    Dim point1 As Point
    Dim point2 As Point
    Dim color1 As Color
    Dim color2 As Color
    Dim bru_sys As SolidBrush
    Dim bru_fill As New SolidBrush(Color.Blue)
    Dim bru_first As New SolidBrush(Color.Red)
    Dim mark As Integer
    Dim rectx As Single
    Dim recty As Single
    Dim rect1_x As Single
    Dim rect1_y As Single
    Dim rect2_x As Single
    Dim rect2_y As Single
    Dim p As Point
    '''''''''''''''''''舱内
    Dim bmp_cabin As Bitmap
    Dim bmpgraphics_cabin As Graphics
    Dim point1_cabin As Point
    Dim point2_cabin As Point
    Dim color1_cabin As Color
    Dim color2_cabin As Color
    Dim mark_cabin As Integer
    Dim rectx_cabin As Single
    Dim recty_cabin As Single
    Dim rect1_x_cabin As Single
    Dim rect1_y_cabin As Single
    Dim rect2_x_cabin As Single
    Dim rect2_y_cabin As Single
    Dim p_cabin As Point
    Dim small_row_cabin As Integer '舱内最小战位屏行
    Dim small_col_cabin As Integer '舱内最小战位屏列
    Dim big_row_cabin As Integer '舱内最大战位屏行
    Dim big_col_cabin As Integer '舱内最大战位屏列
    Dim bay_row_cabin As String  '舱内贝行
    Dim bay_col_cabin As String  '舱内贝列
    '''''''''''''''''''''''结果
    Dim col_count As Integer '甲板上列数和舱内的差额
    Dim color_result As Color
    ''''''''''''''''结果图
    Dim bmp_result_board As Bitmap '甲板
    Dim bmpgraphics_result_board As Graphics '甲板
    Dim bmp_result_cabin As Bitmap '舱内
    Dim bmpgraphics_result_cabin As Graphics '舱内
    Dim str_copy As String '复制贝
    '''''''''''''''船信息
    Dim v_id As Integer
    Dim ENG_VESSEL As String
    Dim CHI_VESSEL As String
    Dim ds_board As New DataSet() '甲板图形
    Dim ds_board_char As New DataSet() '甲板结果图
    Dim ds_cabin As New DataSet() '舱内图形
    Dim ds_cabin_char As New DataSet() '舱内结果图
    ''''''''''''''''''''
    Dim small_row As Integer = 0 '甲板最小战位屏行
    Dim small_col As Integer = 0 '甲板最小战位屏列
    Dim big_row As Integer = 0 '甲板最大战位屏行
    Dim big_col As Integer = 0 '甲板最大战位屏列
    Dim bay_row As Integer '甲板贝行
    Dim bay_col As String '甲板贝列
    ''''''''''''''''''''''''''' 集装箱船贝属性
    Dim ds_unuse_col As New DataSet()
    Dim ds_bay As New DataSet()
    Dim sqlda_bay As New SqlClient.SqlDataAdapter()
    Dim bool_col_row As Boolean
    Dim ds_exist_bay As New DataSet() ''填充已存在和可复制的贝
    Private Sub Frm_bay_map_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call preview("WL4_2") '*****************权限设计 '*************要修改模块号
        Me.Text = Me.Text & "_" & G_DeptName

        SortShip = " Order by Ship_Statu,Dept_Code,id desc " '默认的排序 

        FirmShip = "where DEPT_CODE LIKE '" & G_DeptCode & "%'" '船舶不变的条件设计

        SqlStrShip = "where (DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','0')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0) "
        Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '*****************调用航次信息
        Me.C1DBGV.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue

        txtShipName.Text = G_ShipName
        txtVoyage.Text = G_Voyage
        txtShipName.Focus()
        '''''''''''''''''''''''''甲板
        pen_line.DashStyle = DashStyle.Solid
        rbmp = New Bitmap(ptbox_board.Width, ptbox_board.Height)
        rbmpgraphics = Graphics.FromImage(rbmp)
        ptbox_board.Image = rbmp
        bru_sys = New SolidBrush(Me.BackColor)
        mark = 0
        '舱内
        bmp_cabin = New Bitmap(ptbox_cabin.Width, ptbox_cabin.Height)
        bmpgraphics_cabin = Graphics.FromImage(bmp_cabin)
        Me.ptbox_cabin.Image = bmp_cabin
        mark_cabin = 0
        ''''''''''''甲板结果图
        bmp_result_board = New Bitmap(ptbox_result_board.Width, ptbox_result_board.Height)
        bmpgraphics_result_board = Graphics.FromImage(bmp_result_board)
        Me.ptbox_result_board.Image = bmp_result_board
        '''''''''''''''''''''''''舱内结果图
        bmp_result_cabin = New Bitmap(ptbox_result_cabin.Width, ptbox_result_cabin.Height)
        bmpgraphics_result_cabin = Graphics.FromImage(bmp_result_cabin)
        Me.ptbox_result_cabin.Image = bmp_result_cabin
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

                SortShip = " Order by Ship_Statu,Dept_Code,id desc "
                Call myDataGridShip(SqlStrShip & inoutstr & SortShip)

            Case 2
                Dim FrmFind As New FrmFind()
                Table_Name = "SSHIP"
                FrmFind.ShowDialog()
                If Flag = 0 Then
                    Call myDataGridShip(FirmShip & inoutstr & " and (" & Sql_Find & ")  " & SortShip)    '可能要修改
                    SqlStrShip = FirmStr & " and (" & Sql_Find & ")  "    '可能要修改
                ElseIf Flag = 2 Then
                    SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','4')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) "
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
        'If Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 1 Then
        '    e.CellStyle.BackColor = System.Drawing.Color.White
        'ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 2 Then
        '    e.CellStyle.BackColor = System.Drawing.Color.PaleGreen
        'ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 3 Then
        '    e.CellStyle.BackColor = System.Drawing.Color.LemonChiffon
        'ElseIf Me.C1DBGV.Columns("SHIP_STATU").CellValue(e.Row) = 4 Then
        '    e.CellStyle.BackColor = System.Drawing.Color.Pink
        'End If
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
        Dim dsShip As New DataSet()
        Dim strsql As String
        Dim dw As New DataView()
        Ship_ID = CType(Me.C1DBGV.Columns.Item("ID").Text.ToString, Integer)
        Dim ds_map As New DataSet()
        Getdata("select * from sship where ship_id=" & Ship_ID, ds_map)
        strsql = "select * from View_SSHIP where SHIP_ID=" & Ship_ID
        dw = Getdata(strsql, dsShip)
        Label.Text = ""
        If dsShip.Tables(0).DefaultView.Count > 0 Then
            v_id = CType(ds_map.Tables(0).Rows(0).Item("V_ID"), Integer) '''VESSEL_ID
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))) > 0 Then
                CHI_VESSEL = ds_map.Tables(0).Rows(0).Item("CHI_VESSEL") ''''''中文船名
                Label.Text = Label.Text & "中文船名:" & Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL")) & " "
                G_ShipName = Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))
                txtShipName.Text = G_ShipName
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL"))) > 0 Then
                ENG_VESSEL = ds_map.Tables(0).Rows(0).Item("ENG_VESSEL") ''''''ENG_VESSEL
                Label.Text = Label.Text & "英文船名:" & Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))) > 0 Then
                Label.Text = Label.Text & "航次:" & Trim(dsShip.Tables(0).Rows(0).Item("Voyage")) & " "
                G_Voyage = Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))
                txtVoyage.Text = G_Voyage
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
        Me.cmb_bay.Enabled = True '定义贝
        Me.ckb_joint.Enabled = True '通贝
        Me.cmb_copy.Enabled = True '复制贝
        Me.cmb_exist_bay.Enabled = True '已存在的贝
        Me.cmb_unuse_col.Enabled = True '甲板空列
        Me.cmb_unuse_col_cabin.Enabled = True '舱内空列
        ''填充已存在和可复制的贝
        exist_copy_bay()
        cmb_bay_TextChanged(sender, e)
        Call preview("WL4_1") '*****************权限设计 '*************要修改模块号
        'Call myDataGrid(SelectStr, SqlStr)
        'Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色
        Exit Sub
Err:
        Resume Next
    End Sub


    ''填充已存在和可复制的贝
    Private Sub exist_copy_bay()
        'Me.cmb_exist_bay.Text = ""
        'Me.cmb_copy.Text = ""
        Me.cmb_copy.Items.Clear()
        Me.cmb_exist_bay.Items.Clear()
        If Getdata("select bay_num from con_map where v_id='" & v_id & "'group by bay_num order by bay_num ", ds_exist_bay).Count > 0 Then
            Me.cmb_exist_bay.Items.Add("")
            Me.cmb_copy.Items.Add("")
            For i = 0 To ds_exist_bay.Tables(0).Rows.Count - 1
                Me.cmb_exist_bay.Items.Add(ds_exist_bay.Tables(0).Rows(i).Item("bay_num"))
                Me.cmb_copy.Items.Add(ds_exist_bay.Tables(0).Rows(i).Item("bay_num"))
            Next
        End If
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

            Case 3
                Call mnuAdd_Click(sender, e)
            Case 4
                Call mnuEdit_Click(sender, e)
            Case 5
                Call mnuDelete_Click(sender, e)
            Case 6

            Case 7
                Call mnuPrint_Click(sender, e)
            Case 8
                Call mnuExport_Click(sender, e)
            Case 9

            Case 10
                Me.Close()
        End Select
    End Sub
    Private Sub mnuFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFind.Click

    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        If MsgBox("确认要删除吗？", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
            '删除图形表con_map
            Dim strdel As String
            strdel = "delete from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_bay.Text) & "'"
            ExecSql(strdel)
            '删除集装箱船贝位属性
            Dim strdel_bay As String
            strdel_bay = "delete from con_bay where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_bay.Text) & "'"
            ExecSql(strdel_bay)
            '清空甲板和舱内在界面上的图形
            rbmpgraphics.Clear(Me.BackColor) '甲板图
            bmpgraphics_cabin.Clear(Me.BackColor) '舱内图
            bmpgraphics_result_board.Clear(Me.BackColor) '甲板结果图
            bmpgraphics_result_cabin.Clear(Me.BackColor) '舱内结果图
            '刷新
            Me.ptbox_board.Refresh() '甲板图刷新
            Me.ptbox_cabin.Refresh() '舱内图刷新
            Me.ptbox_result_board.Refresh() '甲板结果图刷新
            Me.ptbox_result_cabin.Refresh() '舱内结果图刷新
        End If

    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click

    End Sub

    Private Sub mnuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdd.Click
        '甲板开始
        '数据库中存在的话就清空
        If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_bay.Text) & "' and location='board'", ds_board).Count > 0 Then
            ExecSql("delete from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_bay.Text) & "'and location='board'")
        End If
        small_row = 0 '最小行至零
        small_col = 0 '最小列至零
        big_row = 0 '最大行至零
        big_col = 0 '最大列至零
        Dim n, k As Integer '最大列宽
        Dim sqlstr As String
        For j = 9 To 0 Step -1 '取屏行，按行读,行坐标先变
            For i = 0 To 19
                color_result = rbmp.GetPixel(20 + 20 * i + 5, 20 + 20 * j + 5)
                If color_result.ToArgb = Color.Blue.ToArgb Then
                    big_row = 10 - j '战位屏行
                    If small_row = 0 Then
                        small_row = 10 - j
                    End If
                End If
            Next i
        Next j
        For i = 0 To 19 '取屏列，按列读，纵坐标先变
            For j = 0 To 9
                color_result = rbmp.GetPixel(20 + 20 * i + 5, 20 + 20 * j + 5)
                If color_result.ToArgb = Color.Blue.ToArgb Then
                    big_col = i + 1 '战位屏列
                    If small_col = 0 Then
                        small_col = i + 1
                    End If
                End If
            Next
        Next
        '''''处理时否存在占位不可用的列
        If Trim(Me.cmb_unuse_col.Text) = "左边" Then
            If small_col > 1 Then
                small_col = small_col - 1
            End If
        Else
            If Trim(Me.cmb_unuse_col.Text) = "右边" Then
                If big_col > 0 Then
                    big_col = big_col + 1
                End If
            End If
        End If
        If big_row > 0 And big_col > 0 Then
            n = big_col - small_col + 1
            For i = small_row To big_row '战位最大屏行,按行读，行坐标先变
                bay_row = 78 + i * 2
                For j = small_col To big_col '战位最大屏列
                    If n Mod 2 = 0 Then
                        k = small_col + Fix(n / 2) - j
                        If k > 0 Then
                            If k < 5 Then
                                bay_col = "0" & k * 2
                            Else
                                bay_col = k * 2
                            End If
                        Else
                            If Abs(k) * 2 + 1 < 10 Then
                                bay_col = "0" & Abs(k) * 2 + 1
                            Else
                                bay_col = Abs(k) * 2 + 1
                            End If
                        End If
                    Else
                        k = small_col + Fix(n / 2) - j
                        If k = 0 Then
                            bay_col = "00"
                        Else
                            If k > 0 Then
                                If k * 2 < 10 Then
                                    bay_col = "0" & k * 2
                                Else
                                    bay_col = k * 2
                                End If
                            Else
                                If Abs(k) * 2 - 1 < 10 Then
                                    bay_col = "0" & Abs(k) * 2 - 1
                                Else
                                    bay_col = Abs(k) * 2 - 1
                                End If
                            End If
                        End If
                    End If
                    Try
                        color_result = rbmp.GetPixel(20 * j + 5, 220 + 5 - 20 * i)
                    Catch
                    End Try
                    If color_result.ToArgb = Color.Blue.ToArgb Then
                        sqlstr = "insert con_map(v_id,ENG_VESSEL,CHI_VESSEL,location,screen_row,screen_col,bay_num,bay_row,bay_col,occupy,user_char) values (" & v_id & ",'" & ENG_VESSEL & "','" & CHI_VESSEL & "','board','" & i & "','" & j & "','" & Trim(Me.cmb_bay.Text) & "','" & bay_row & "','" & bay_col & "',1,1)"
                        ExecSql(sqlstr)
                    Else
                        sqlstr = "insert con_map(v_id,ENG_VESSEL,CHI_VESSEL,location,screen_row,screen_col,bay_num,bay_row,bay_col,occupy,user_char) values (" & v_id & ",'" & ENG_VESSEL & "','" & CHI_VESSEL & "','board','" & i & "','" & j & "','" & Trim(Me.cmb_bay.Text) & "','" & bay_row & "','" & bay_col & "',1,0)"
                        ExecSql(sqlstr)
                    End If
                Next
            Next

            'result_map() '画甲板结果图
        Else
            bmpgraphics_result_board.Clear(Me.BackColor)
            Me.ptbox_result_board.Refresh()
        End If
        '甲板结束

        '舱内
        '检查甲板上是否有数据
        'If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_bay.Text) & "' and location='board'", ds_board).Count > 0 Then
        '数据库中存在的话就清空
        If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_bay.Text) & "' and location='cabin'", ds_cabin).Count > 0 Then
            ExecSql("delete from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_bay.Text) & "'and location='cabin'")
        End If
        small_row_cabin = 0 '最小行至零
        small_col_cabin = 0 '最小列至零
        big_row_cabin = 0 '最大行至零
        big_col_cabin = 0 '最大列至零
        'Dim n, k As Integer '最大列宽
        'Dim sqlstr As String
        For j = 9 To 0 Step -1 '取屏行，按行读,行坐标先变
            For i = 0 To 19
                color_result = bmp_cabin.GetPixel(20 + 20 * i + 5, 20 + 20 * j + 5)
                If color_result.ToArgb = Color.Blue.ToArgb Then
                    big_row_cabin = 10 - j '战位屏行
                    If small_row_cabin = 0 Then
                        small_row_cabin = 10 - j
                    End If
                End If
            Next i
        Next j
        For i = 0 To 19 '取屏列，按列读，纵坐标先变
            For j = 0 To 9
                color_result = bmp_cabin.GetPixel(20 + 20 * i + 5, 20 + 20 * j + 5)
                If color_result.ToArgb = Color.Blue.ToArgb Then
                    big_col_cabin = i + 1 '战位屏列
                    If small_col_cabin = 0 Then
                        small_col_cabin = i + 1
                    End If
                End If
            Next
        Next
        '''''处理时否存在占位不可用的列
        If Trim(Me.cmb_unuse_col_cabin.Text) = "左边" Then
            If small_col_cabin > 1 Then
                small_col_cabin = small_col_cabin - 1
            End If
        Else
            If Trim(Me.cmb_unuse_col_cabin.Text) = "右边" Then
                If big_col_cabin > 0 Then
                    big_col_cabin = big_col_cabin + 1
                End If
            End If
        End If
        If big_row_cabin > 0 And big_col_cabin > 0 Then ' And (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) >= 0满足舱内列数小于甲板列数
            n = big_col_cabin - small_col_cabin + 1
            For i = small_row_cabin To big_row_cabin '战位最大屏行,按行读，行坐标先变
                If i * 2 < 10 Then
                    bay_row_cabin = "0" & i * 2
                Else
                    bay_row_cabin = i * 2
                End If
                For j = small_col_cabin To big_col_cabin '战位最大屏列
                    If n Mod 2 = 0 Then
                        k = small_col_cabin + Fix(n / 2) - j
                        If k > 0 Then
                            If k < 5 Then
                                bay_col_cabin = "0" & k * 2
                            Else
                                bay_col_cabin = k * 2
                            End If
                        Else
                            If Abs(k) * 2 + 1 < 10 Then
                                bay_col_cabin = "0" & Abs(k) * 2 + 1
                            Else
                                bay_col_cabin = Abs(k) * 2 + 1
                            End If
                        End If
                    Else
                        k = small_col_cabin + Fix(n / 2) - j
                        If k = 0 Then
                            bay_col_cabin = "00"
                        Else
                            If k > 0 Then
                                If k * 2 < 10 Then
                                    bay_col_cabin = "0" & k * 2
                                Else
                                    bay_col_cabin = k * 2
                                End If
                            Else
                                If Abs(k) * 2 - 1 < 10 Then
                                    bay_col_cabin = "0" & Abs(k) * 2 - 1
                                Else
                                    bay_col_cabin = Abs(k) * 2 - 1
                                End If
                            End If
                        End If
                    End If
                    Try
                        color_result = bmp_cabin.GetPixel(20 * j + 5, 220 + 5 - 20 * i)
                    Catch
                    End Try
                    If color_result.ToArgb = Color.Blue.ToArgb Then
                        sqlstr = "insert con_map(v_id,ENG_VESSEL,CHI_VESSEL,location,screen_row,screen_col,bay_num,bay_row,bay_col,occupy,user_char) values (" & v_id & ",'" & ENG_VESSEL & "','" & CHI_VESSEL & "','cabin','" & i & "','" & j & "','" & Trim(Me.cmb_bay.Text) & "','" & bay_row_cabin & "','" & bay_col_cabin & "',1,1)"
                        ExecSql(sqlstr)
                    Else
                        sqlstr = "insert con_map(v_id,ENG_VESSEL,CHI_VESSEL,location,screen_row,screen_col,bay_num,bay_row,bay_col,occupy,user_char) values (" & v_id & ",'" & ENG_VESSEL & "','" & CHI_VESSEL & "','cabin','" & i & "','" & j & "','" & Trim(Me.cmb_bay.Text) & "','" & bay_row_cabin & "','" & bay_col_cabin & "',1,0)"
                        ExecSql(sqlstr)
                    End If
                Next
            Next
            'result_map_cabin() '画舱内结果图
        Else
            bmpgraphics_result_cabin.Clear(Me.BackColor)
            Me.ptbox_result_cabin.Refresh()
        End If
        exist_copy_bay()  ''填充已存在和可复制的贝
        ship_bay()    '''集装箱船贝属性
        result_map() '画甲板结果图
        result_map_cabin() '画舱内结果图

    End Sub

    Private Sub ship_bay()    '''集装箱船贝属性
        '数据库中存在的话就删除____甲板
        If Updatedata(sqlda_bay, "select * from con_bay where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_bay.Text) & "'", ds_bay).Count > 0 Then
            ds_bay.Tables(0).Rows(0).Item("v_id") = v_id
            ds_bay.Tables(0).Rows(0).Item("ENG_VESSEL") = ENG_VESSEL
            ds_bay.Tables(0).Rows(0).Item("CHI_VESSEL") = CHI_VESSEL
            ds_bay.Tables(0).Rows(0).Item("bay_num") = Trim(Me.cmb_bay.Text) '贝号
            If (big_row > 0 And big_col > 0) Then '甲板
                ds_bay.Tables(0).Rows(0).Item("board_col_count") = big_col - small_col + 1  '甲板列数
                ds_bay.Tables(0).Rows(0).Item("board_col_mark") = (big_col - small_col + 1) Mod 2 '甲板列数几偶
                ds_bay.Tables(0).Rows(0).Item("board_row_count") = big_row - small_row + 1 '甲板层数
            Else
                ds_bay.Tables(0).Rows(0).Item("board_col_count") = System.DBNull.Value '甲板列数
                ds_bay.Tables(0).Rows(0).Item("board_col_mark") = System.DBNull.Value  '甲板列数几偶
                ds_bay.Tables(0).Rows(0).Item("board_row_count") = System.DBNull.Value '甲板层数
            End If
            If (big_row_cabin > 0 And big_col_cabin > 0) Then '舱内
                ds_bay.Tables(0).Rows(0).Item("cabin_col_count") = big_col_cabin - small_col_cabin + 1  '舱内列数
                ds_bay.Tables(0).Rows(0).Item("cabin_col_mark") = (big_col_cabin - small_col_cabin + 1) Mod 2 '舱内列数几偶
                ds_bay.Tables(0).Rows(0).Item("cabin_row_count") = big_row_cabin - small_row_cabin + 1  '舱内层数
            Else
                ds_bay.Tables(0).Rows(0).Item("cabin_col_count") = System.DBNull.Value  '舱内列数
                ds_bay.Tables(0).Rows(0).Item("cabin_col_mark") = System.DBNull.Value  '舱内列数几偶
                ds_bay.Tables(0).Rows(0).Item("cabin_row_count") = System.DBNull.Value  '舱内层数
            End If

            If Me.ckb_joint.Checked Then     '通贝方向
                ds_bay.Tables(0).Rows(0).Item("joint") = 1
            Else
                ds_bay.Tables(0).Rows(0).Item("joint") = 0
            End If
            If small_row = 1 Then   '有无80层
                ds_bay.Tables(0).Rows(0).Item("low_row_mark") = 1
            Else
                ds_bay.Tables(0).Rows(0).Item("low_row_mark") = 0
            End If   '有无80层
            If Len(Trim(Me.cmb_unuse_col.Text)) > 0 Then '甲板占位不可用的列的位置
                ds_bay.Tables(0).Rows(0).Item("board_unuse_col") = Trim(Me.cmb_unuse_col.Text)
            Else
                ds_bay.Tables(0).Rows(0).Item("board_unuse_col") = System.DBNull.Value '甲板占位不可用的列的位置
            End If
            If Len(Trim(Me.cmb_unuse_col_cabin.Text)) > 0 Then
                ds_bay.Tables(0).Rows(0).Item("cabin_unuse_col") = Trim(Me.cmb_unuse_col_cabin.Text)   '舱内占位不可用的列的位置
            Else
                ds_bay.Tables(0).Rows(0).Item("cabin_unuse_col") = System.DBNull.Value '舱内占位不可用的列的位置
            End If
            Try
                sqlda_bay.Update(ds_bay)
            Catch ex As System.Exception
                MsgBox(ex)
            End Try
        Else
            If (big_row > 0 And big_col > 0) Or (big_row_cabin > 0 And big_col_cabin > 0) Then
                Dim row As DataRow
                row = ds_bay.Tables(0).NewRow
                row("v_id") = v_id
                row("ENG_VESSEL") = ENG_VESSEL
                row("CHI_VESSEL") = CHI_VESSEL
                row("bay_num") = Trim(Me.cmb_bay.Text) '贝号
                If (big_row > 0 And big_col > 0) Then '甲板
                    row("board_col_count") = big_col - small_col + 1 '甲板列数
                    row("board_col_mark") = (big_col - small_col + 1) Mod 2 '甲板列数几偶
                    row("board_row_count") = big_row - small_row + 1 '甲板层数
                End If
                If (big_row_cabin > 0 And big_col_cabin > 0) Then '舱内
                    row("cabin_col_count") = big_col_cabin - small_col_cabin + 1 '舱内列数
                    row("cabin_col_mark") = (big_col_cabin - small_col_cabin + 1) Mod 2 '舱内列数几偶
                    row("cabin_row_count") = big_row_cabin - small_row_cabin + 1 '舱内层数
                End If
                If Me.ckb_joint.Checked Then   '通贝方向
                    row("joint") = 1
                Else
                    row("joint") = 0
                End If
                If small_row = 1 Then   '有无80层
                    row("low_row_mark") = 1
                Else
                    row("low_row_mark") = 0
                End If
                If Len(Trim(Me.cmb_unuse_col.Text)) > 0 Then
                    row("board_unuse_col") = Trim(Me.cmb_unuse_col.Text)   '甲板占位不可用的列的位置
                End If
                If Len(Trim(Me.cmb_unuse_col_cabin.Text)) > 0 Then
                    row("cabin_unuse_col") = Trim(Me.cmb_unuse_col_cabin.Text)   '舱内占位不可用的列的位置
                End If
                ds_bay.Tables(0).Rows.Add(row)
                Try
                    sqlda_bay.Update(ds_bay)
                Catch ex As System.Exception
                    MsgBox(ex)
                End Try
            End If
        End If
    End Sub
    Private Sub result_map()  '画甲板结果图
        bmpgraphics_result_board.Clear(Me.BackColor)
        If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_bay.Text) & "' and location='board' order by id", ds_board).Count > 0 Then
            Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_bay.Text) & "' and location='board'", ds_board_char)
            small_row = ds_board_char.Tables(0).Rows(0).Item("small_row") '取屏幕的最小行
            big_row = ds_board_char.Tables(0).Rows(0).Item("big_row") '取屏幕的最大行
            small_col = ds_board_char.Tables(0).Rows(0).Item("small_col") '取屏幕的最小列
            big_col = ds_board_char.Tables(0).Rows(0).Item("big_col") '取屏幕的最大列
            '取舱内的列数
            small_col_cabin = 0
            big_col_cabin = 0
            If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_bay.Text) & "' and location='cabin' order by id", ds_cabin).Count > 0 Then
                Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_bay.Text) & "' and location='cabin'", ds_cabin_char)
                small_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_col") '取舱内屏幕的最小列
                big_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_col") '取舱内屏幕的最大列
            End If

            '计算甲板结果图的顶点位置
            If (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) >= 0 Then '比较甲板和舱内的列数
                col_count = (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) ''甲板上列数和舱内的差额
            Else
                col_count = 0
            End If

            ''画矩形
            For i = small_row To big_row
                For j = small_col To big_col
                    If ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("user_char") = 1 Then
                        bmpgraphics_result_board.DrawRectangle(pen_line, col_count * 10 + 20 * (j - small_col + 1), 200 - 20 * (i - small_row + 1), 20, 20)
                    End If
                Next
            Next
            '画贝层
            For i = small_row To big_row '战位最大屏列,按行读，行坐标先变
                bay_row = 78 + i * 2
                bmpgraphics_result_board.DrawString(bay_row, Me.Font, Brushes.Black, 2, 220 - 20 * (i - small_row + 1) - 20 + 5) '贝层
            Next
            ''写贝列
            n = big_col - small_col + 1
            'bay_row = 78 + i * 2
            Dim strcon As Integer
            strcon = 1
            Dim strsmallcol As Integer
            strsmallcol = small_col
            Dim strbigcol As Integer
            strbigcol = big_col
            If Getdata("select * from con_bay where  v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_bay.Text) & "'", ds_unuse_col).Count > 0 Then
                If ds_unuse_col.Tables(0).Rows(0).Item("board_unuse_col") Is System.DBNull.Value Then

                Else
                    If ds_unuse_col.Tables(0).Rows(0).Item("board_unuse_col") = "右边" Then
                        strbigcol = strbigcol - 1
                    Else
                        If ds_unuse_col.Tables(0).Rows(0).Item("board_unuse_col") = "左边" Then
                            strsmallcol = strsmallcol + 1
                            strcon = 2
                        End If
                    End If
                End If
            End If
            For j = strsmallcol To strbigcol   '战位最大屏列
                If n Mod 2 = 0 Then
                    k = small_col + Fix(n / 2) - j
                    If k > 0 Then
                        If k < 5 Then
                            bay_col = "0" & k * 2
                        Else
                            bay_col = k * 2
                        End If
                    Else
                        If Abs(k) * 2 + 1 < 10 Then
                            bay_col = "0" & Abs(k) * 2 + 1
                        Else
                            bay_col = Abs(k) * 2 + 1
                        End If
                    End If
                Else
                    k = small_col + Fix(n / 2) - j
                    If k = 0 Then
                        bay_col = "00"
                    Else
                        If k > 0 Then
                            If k * 2 < 10 Then
                                bay_col = "0" & k * 2
                            Else
                                bay_col = k * 2
                            End If
                        Else
                            If Abs(k) * 2 - 1 < 10 Then
                                bay_col = "0" & Abs(k) * 2 - 1
                            Else
                                bay_col = Abs(k) * 2 - 1
                            End If
                        End If
                    End If
                End If
                bmpgraphics_result_board.DrawString(bay_col, Me.Font, Brushes.Black, col_count * 10 + 20 * (j - strsmallcol + strcon) + 4, 200 + 2) '贝列
            Next

            Me.ptbox_result_board.Refresh()
        End If
    End Sub

    Private Sub result_map_cabin() '画舱内结果图
        bmpgraphics_result_cabin.Clear(Me.BackColor)
        If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_bay.Text) & "' and location='cabin' order by id", ds_cabin).Count > 0 Then
            '取甲板的列数
            small_col = 0
            big_col = 0
            If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_bay.Text) & "' and location='board' order by id", ds_board).Count > 0 Then
                Getdata("select min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_bay.Text) & "' and location='board'", ds_board_char)
                small_col = ds_board_char.Tables(0).Rows(0).Item("small_col") '取甲板屏幕的最小列
                big_col = ds_board_char.Tables(0).Rows(0).Item("big_col") '取甲板屏幕的最大列
            End If
            Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_bay.Text) & "' and location='cabin'", ds_cabin_char)
            small_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_row") '取舱内屏幕的最小行
            big_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_row") '取舱内屏幕的最大行
            small_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_col") '取舱内屏幕的最小列
            big_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_col") '取舱内屏幕的最大列
            '计算舱内结果图的顶点位置
            If (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) >= 0 Then
                col_count = (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) ''甲板上列数和舱内的差额
            Else
                col_count = 0
            End If
            'cabin_times = col_count Mod 2 ''取差额分配到左边的部分
            'If col_count >= 0 Then
            ''画矩形
            For i = small_row_cabin To big_row_cabin
                For j = small_col_cabin To big_col_cabin
                    If ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("user_char") = 1 Then
                        bmpgraphics_result_cabin.DrawRectangle(pen_line, col_count * 10 + 20 * (j - small_col_cabin + 1), (big_row_cabin - small_row_cabin + 1) * 20 - 20 * (i - small_row_cabin + 1), 20, 20) '   bmpgraphics_result_cabin.DrawRectangle(pen_line, 20 * (j - small_col_cabin + 1), 200 - 20 * (i - small_row_cabin + 1), 20, 20
                    End If
                Next
            Next
            '画贝层
            For i = small_row_cabin To big_row_cabin '战位最大屏列,按行读，行坐标先变
                If i * 2 < 10 Then
                    bay_row_cabin = "0" & i * 2
                Else
                    bay_row_cabin = i * 2
                End If
                bmpgraphics_result_cabin.DrawString(bay_row_cabin, Me.Font, Brushes.Black, 2, (big_row_cabin - small_row_cabin + 1 + 1) * 20 - 20 * (i - small_row_cabin + 1) - 20 + 5) '贝层
            Next
            ''写贝列
            n = big_col_cabin - small_col_cabin + 1
            'bay_row_cabin = 78 + i * 2
            Dim strcon As Integer
            strcon = 1
            Dim strsmallcol As Integer
            strsmallcol = small_col_cabin
            Dim strbigcol As Integer
            strbigcol = big_col_cabin
            If Getdata("select * from con_bay where  v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_bay.Text) & "'", ds_unuse_col).Count > 0 Then
                If ds_unuse_col.Tables(0).Rows(0).Item("cabin_unuse_col") Is System.DBNull.Value Then

                Else
                    If ds_unuse_col.Tables(0).Rows(0).Item("cabin_unuse_col") = "右边" Then
                        strbigcol = strbigcol - 1
                    Else
                        If ds_unuse_col.Tables(0).Rows(0).Item("cabin_unuse_col") = "左边" Then
                            strsmallcol = strsmallcol + 1
                            strcon = 2
                        End If
                    End If
                End If
            End If
            For j = strsmallcol To strbigcol   '战位最大屏列
                'For j = small_col_cabin To big_col_cabin '战位最大屏列
                If n Mod 2 = 0 Then
                    k = small_col_cabin + Fix(n / 2) - j
                    If k > 0 Then
                        If k < 5 Then
                            bay_col_cabin = "0" & k * 2
                        Else
                            bay_col_cabin = k * 2
                        End If
                    Else
                        If Abs(k) * 2 + 1 < 10 Then
                            bay_col_cabin = "0" & Abs(k) * 2 + 1
                        Else
                            bay_col_cabin = Abs(k) * 2 + 1
                        End If
                    End If
                Else
                    k = small_col_cabin + Fix(n / 2) - j
                    If k = 0 Then
                        bay_col_cabin = "00"
                    Else
                        If k > 0 Then
                            If k * 2 < 10 Then
                                bay_col_cabin = "0" & k * 2
                            Else
                                bay_col_cabin = k * 2
                            End If
                        Else
                            If Abs(k) * 2 - 1 < 10 Then
                                bay_col_cabin = "0" & Abs(k) * 2 - 1
                            Else
                                bay_col_cabin = Abs(k) * 2 - 1
                            End If
                        End If
                    End If
                End If
                bmpgraphics_result_cabin.DrawString(bay_col_cabin, Me.Font, Brushes.Black, col_count * 10 + 20 * (j - strsmallcol + strcon) + 4, (big_row_cabin - small_row_cabin + 1) * 20 + 2)   '贝列
            Next

            Me.ptbox_result_cabin.Refresh()
        End If

        'End If
    End Sub
    Private Sub cmb_bay_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_bay.TextChanged
        '填充空列文本
        Me.cmb_unuse_col.Text = ""
        Me.cmb_unuse_col_cabin.Text = ""
        Me.ckb_joint.Checked = False
        If Getdata("select * from con_bay where  v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_bay.Text) & "'", ds_unuse_col).Count > 0 Then
            '通贝？
            If ds_unuse_col.Tables(0).Rows(0).Item("joint") = 1 Then
                Me.ckb_joint.Checked = True
            End If

            If ds_unuse_col.Tables(0).Rows(0).Item("board_unuse_col") Is System.DBNull.Value Then
                Me.cmb_unuse_col.Text = ""
            Else
                Me.cmb_unuse_col.Text = ds_unuse_col.Tables(0).Rows(0).Item("board_unuse_col")
            End If
            If ds_unuse_col.Tables(0).Rows(0).Item("cabin_unuse_col") Is System.DBNull.Value Then
                Me.cmb_unuse_col_cabin.Text = ""
            Else
                Me.cmb_unuse_col_cabin.Text = ds_unuse_col.Tables(0).Rows(0).Item("cabin_unuse_col")
            End If
        End If
        ''甲板开始
        Me.ptbox_board.Enabled = True
        '清空颜色
        For j = 1 To 10
            For k = 1 To 20
                rbmpgraphics.FillRectangle(bru_sys, 20 * k + 1, 220 - 20 * j + 1, 19, 19)
            Next
        Next
        ''清空贝位图
        bmpgraphics_result_board.Clear(Me.BackColor)
        If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_bay.Text) & "' and location='board' order by id", ds_board).Count > 0 Then
            Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_bay.Text) & "' and location='board'", ds_board_char)
            small_row = ds_board_char.Tables(0).Rows(0).Item("small_row")
            big_row = ds_board_char.Tables(0).Rows(0).Item("big_row")
            small_col = ds_board_char.Tables(0).Rows(0).Item("small_col")
            big_col = ds_board_char.Tables(0).Rows(0).Item("big_col")
            '''填充颜色
            For i = small_row To big_row
                For j = small_col To big_col
                    If ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("user_char") = 1 Then 'big_col * (i - 1) + j - 1
                        rbmpgraphics.FillRectangle(bru_fill, 20 * (j) + 1, 220 - 20 * i + 1, 19, 19)
                    End If
                Next
            Next
            '’画结果贝位图
            result_map()
            'Else
            '    cmb_copy_TextChanged(sender, e)
        End If
        ptbox_board.Refresh()
        ptbox_result_board.Refresh()
        '‘甲板结束
        ''舱内开始
        Me.ptbox_cabin.Enabled = True
        '清空颜色
        For j = 1 To 10
            For k = 1 To 20
                bmpgraphics_cabin.FillRectangle(bru_sys, 20 * k + 1, 220 - 20 * j + 1, 19, 19)
            Next
        Next
        ''清空贝位图
        bmpgraphics_result_cabin.Clear(Me.BackColor)
        If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_bay.Text) & "' and location='cabin' order by id", ds_cabin).Count > 0 Then
            Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_bay.Text) & "' and location='cabin'", ds_cabin_char)
            small_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_row")
            big_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_row")
            small_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_col")
            big_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_col")
            '''填充颜色
            For i = small_row_cabin To big_row_cabin
                For j = small_col_cabin To big_col_cabin
                    If ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("user_char") = 1 Then 'big_col * (i - 1) + j - 1
                        bmpgraphics_cabin.FillRectangle(bru_fill, 20 * (j) + 1, 220 - 20 * i + 1, 19, 19)
                    End If
                Next
            Next
            '’画结果贝位图
            result_map_cabin()
        End If
        ptbox_cabin.Refresh()
        ptbox_result_cabin.Refresh()
        '‘舱内结束

    End Sub

    Private Sub cmb_copy_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_copy.TextChanged
        '填充空列文本
        Me.cmb_unuse_col.Text = ""
        Me.cmb_unuse_col_cabin.Text = ""
        Me.ckb_joint.Checked = False
        If Getdata("select * from con_bay where  v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_copy.Text) & "'", ds_unuse_col).Count > 0 Then
            '通贝？
            If ds_unuse_col.Tables(0).Rows(0).Item("joint") = 1 Then
                Me.ckb_joint.Checked = True
            End If

            If ds_unuse_col.Tables(0).Rows(0).Item("board_unuse_col") Is System.DBNull.Value Then
                Me.cmb_unuse_col.Text = ""
            Else
                Me.cmb_unuse_col.Text = ds_unuse_col.Tables(0).Rows(0).Item("board_unuse_col")
            End If
            If ds_unuse_col.Tables(0).Rows(0).Item("cabin_unuse_col") Is System.DBNull.Value Then
                Me.cmb_unuse_col_cabin.Text = ""
            Else
                Me.cmb_unuse_col_cabin.Text = ds_unuse_col.Tables(0).Rows(0).Item("cabin_unuse_col")
            End If
        End If
        ''甲板开始
        Me.ptbox_board.Enabled = True
        '清空颜色
        For j = 1 To 10
            For k = 1 To 20
                rbmpgraphics.FillRectangle(bru_sys, 20 * k + 1, 220 - 20 * j + 1, 19, 19)
            Next
        Next
        ''清空贝位图
        bmpgraphics_result_board.Clear(Me.BackColor)
        If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_copy.Text) & "' and location='board' order by id", ds_board).Count > 0 Then
            Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_copy.Text) & "' and location='board'", ds_board_char)
            small_row = ds_board_char.Tables(0).Rows(0).Item("small_row")
            big_row = ds_board_char.Tables(0).Rows(0).Item("big_row")
            small_col = ds_board_char.Tables(0).Rows(0).Item("small_col")
            big_col = ds_board_char.Tables(0).Rows(0).Item("big_col")
            '''填充颜色
            For i = small_row To big_row
                For j = small_col To big_col
                    If ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("user_char") = 1 Then 'big_col * (i - 1) + j - 1
                        rbmpgraphics.FillRectangle(bru_fill, 20 * (j) + 1, 220 - 20 * i + 1, 19, 19)
                    End If
                Next
            Next
            '’画结果贝位图
            result_map()
        End If
        ptbox_board.Refresh()
        ptbox_result_board.Refresh()
        '‘甲板结束

        ''舱内开始
        Me.ptbox_cabin.Enabled = True
        '清空颜色
        For j = 1 To 10
            For k = 1 To 20
                bmpgraphics_cabin.FillRectangle(bru_sys, 20 * k + 1, 220 - 20 * j + 1, 19, 19)
            Next
        Next
        ''清空贝位图
        bmpgraphics_result_cabin.Clear(Me.BackColor)
        If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_copy.Text) & "' and location='cabin' order by id", ds_cabin).Count > 0 Then
            Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_copy.Text) & "' and location='cabin'", ds_cabin_char)
            small_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_row")
            big_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_row")
            small_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_col")
            big_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_col")
            '''填充颜色
            For i = small_row_cabin To big_row_cabin
                For j = small_col_cabin To big_col_cabin
                    If ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("user_char") = 1 Then 'big_col * (i - 1) + j - 1
                        bmpgraphics_cabin.FillRectangle(bru_fill, 20 * (j) + 1, 220 - 20 * i + 1, 19, 19)
                    End If
                Next
            Next
            '’画结果贝位图
            result_map_cabin()
        End If
        ptbox_cabin.Refresh()
        ptbox_result_cabin.Refresh()
        '‘舱内结束
    End Sub

    Private Sub mnuQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuery.Click

    End Sub

    Private Sub mnuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrint.Click
        Dim frm As New Frm_bay_print()
        frm.ShowDialog()
    End Sub

    Private Sub mnuExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExport.Click
        Dim frm As New Frm_con_facemap()
        frm.ShowDialog()
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


    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        TBar = 1
        Mnu = 1
    End Sub


    Private Sub ptbox_board_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ptbox_board.Paint
        g_line = e.Graphics
        For j = 0 To 9
            For i = 0 To 19
                g_line.DrawRectangle(pen_line, 20 + 20 * i, 20 + 20 * j, 20, 20)
            Next
        Next
        For i = 1 To 20
            If i < 10 Then
                g_line.DrawString(i, Me.Font, Brushes.Black, 20 * i + 6, 6)
            Else
                g_line.DrawString(i, Me.Font, Brushes.Black, 20 * i + 2, 6)
            End If
        Next
        For j = 0 To 9
            g_line.DrawString(80 + j * 2, Me.Font, Brushes.Black, 2, 20 * 10 + 5 - 20 * j)
        Next
        ptbox_board.Width = 20 * 20 + 1 + 20
        ptbox_board.Height = 10 * 20 + 1 + 20
    End Sub

    Private Sub ptbox_board_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ptbox_board.MouseDown
        p.X = e.X
        p.Y = e.Y
        rectx = p.X / 20
        recty = p.Y / 20
        rectx = Fix(rectx) * 20
        recty = Fix(recty) * 20
        If rectx <> 0 And recty <> 0 Then
            If e.Button = MouseButtons.Left Then
                mark = mark + 1
                If mark Mod 2 = 1 Then
                    point1.X = e.X
                    point1.Y = e.Y
                    color1 = rbmp.GetPixel(e.X, e.Y)
                    rect1_x = point1.X / 20
                    rect1_y = point1.Y / 20
                    rect1_x = Fix(rect1_x) * 20
                    rect1_y = Fix(rect1_y) * 20
                    rbmpgraphics.FillRectangle(bru_first, rect1_x + 1, rect1_y + 1, 19, 19)
                    ptbox_board.Refresh()
                Else
                    mark = 0
                    point2.X = e.X
                    point2.Y = e.Y
                    color2 = rbmp.GetPixel(e.X, e.Y)
                    rect1_x = point1.X / 20
                    rect1_x = Fix(rect1_x) * 20
                    rect1_y = point1.Y / 20
                    rect1_y = Fix(rect1_y) * 20
                    rect2_x = point2.X / 20
                    rect2_x = Fix(rect2_x) * 20
                    rect2_y = point2.Y / 20
                    rect2_y = Fix(rect2_y) * 20
                    m = (rect2_x - rect1_x) / 20
                    n = (rect2_y - rect1_y) / 20
                    If color2.ToArgb <> Color.Blue.ToArgb And color1.ToArgb <> Color.Blue.ToArgb Then
                        For j = 0 To m
                            For k = 0 To n
                                rbmpgraphics.FillRectangle(bru_fill, rect1_x + 20 * j + 1, rect1_y + 20 * k + 1, 19, 19)
                                '  ptbox_board.Refresh()
                            Next
                        Next
                        ptbox_board.Refresh()
                    Else
                        If color1.ToArgb = color2.ToArgb And color1.ToArgb = Color.Blue.ToArgb Then
                            For j = 0 To m
                                For k = 0 To n
                                    rbmpgraphics.FillRectangle(bru_sys, rect1_x + 20 * j + 1, rect1_y + 20 * k + 1, 19, 19)
                                    '  ptbox_board.Refresh()
                                Next
                            Next
                            ptbox_board.Refresh()
                        End If
                    End If
                    If color1.ToArgb = Color.Blue.ToArgb And color2.ToArgb = Color.Red.ToArgb Then
                        rbmpgraphics.FillRectangle(bru_sys, rect1_x + 1, rect1_y + 1, 19, 19)
                        ptbox_board.Refresh()
                    End If
                    If color1.ToArgb = Color.Blue.ToArgb And color2.ToArgb <> Color.Blue.ToArgb And color2.ToArgb <> Color.Red.ToArgb Then
                        rbmpgraphics.FillRectangle(bru_fill, rect1_x + 1, rect1_y + 1, 19, 19)
                        ptbox_board.Refresh()
                    End If
                    If color1.ToArgb <> Color.Blue.ToArgb And color2.ToArgb = Color.Blue.ToArgb Then
                        rbmpgraphics.FillRectangle(bru_sys, rect1_x + 1, rect1_y + 1, 19, 19)
                        ptbox_board.Refresh()
                    End If
                    If (m < 0 Or n < 0) Then
                        If color1.ToArgb = Color.Blue.ToArgb Then
                            rbmpgraphics.FillRectangle(bru_fill, rect1_x + 1, rect1_y + 1, 19, 19)
                            ptbox_board.Refresh()
                        Else
                            rbmpgraphics.FillRectangle(bru_sys, rect1_x + 1, rect1_y + 1, 19, 19)
                            ptbox_board.Refresh()
                        End If
                    End If
                End If
            End If
        End If
    End Sub



    Private Sub ptbox_cabin_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ptbox_cabin.Paint
        g_line = e.Graphics
        For j = 0 To 9
            For i = 0 To 19
                g_line.DrawRectangle(pen_line, 20 + 20 * i, 20 + 20 * j, 20, 20)
            Next
        Next
        For i = 1 To 20
            If i < 10 Then
                g_line.DrawString(i, Me.Font, Brushes.Black, 20 * i + 6, 6)
            Else
                g_line.DrawString(i, Me.Font, Brushes.Black, 20 * i + 2, 6)
            End If
        Next
        g_line.DrawString("02", Me.Font, Brushes.Black, 2, 20 * 10 + 5)
        g_line.DrawString("04", Me.Font, Brushes.Black, 2, 20 * 10 + 5 - 20 * 1)
        g_line.DrawString("06", Me.Font, Brushes.Black, 2, 20 * 10 + 5 - 20 * 2)
        g_line.DrawString("08", Me.Font, Brushes.Black, 2, 20 * 10 + 5 - 20 * 3)
        For j = 0 To 5
            g_line.DrawString(10 + 2 * j, Me.Font, Brushes.Black, 2, 20 * 10 + 5 - 20 * (j + 4))
        Next
        ptbox_cabin.Width = 20 * 20 + 1 + 20
        ptbox_cabin.Height = 10 * 20 + 1 + 20
    End Sub

    Private Sub ptbox_cabin_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ptbox_cabin.MouseDown
        p_cabin.X = e.X
        p_cabin.Y = e.Y
        rectx_cabin = p_cabin.X / 20
        recty_cabin = p_cabin.Y / 20
        rectx_cabin = Fix(rectx_cabin) * 20
        recty_cabin = Fix(recty_cabin) * 20
        If rectx_cabin <> 0 And recty_cabin <> 0 Then
            If e.Button = MouseButtons.Left Then
                mark_cabin = mark_cabin + 1
                If mark_cabin Mod 2 = 1 Then
                    point1_cabin.X = e.X
                    point1_cabin.Y = e.Y
                    color1_cabin = bmp_cabin.GetPixel(e.X, e.Y)
                    rect1_x_cabin = point1_cabin.X / 20
                    rect1_y_cabin = point1_cabin.Y / 20
                    rect1_x_cabin = Fix(rect1_x_cabin) * 20
                    rect1_y_cabin = Fix(rect1_y_cabin) * 20
                    bmpgraphics_cabin.FillRectangle(bru_first, rect1_x_cabin + 1, rect1_y_cabin + 1, 19, 19)
                    ptbox_cabin.Refresh()
                Else
                    mark_cabin = 0
                    point2_cabin.X = e.X
                    point2_cabin.Y = e.Y
                    color2_cabin = bmp_cabin.GetPixel(e.X, e.Y)
                    rect1_x_cabin = point1_cabin.X / 20
                    rect1_x_cabin = Fix(rect1_x_cabin) * 20
                    rect1_y_cabin = point1_cabin.Y / 20
                    rect1_y_cabin = Fix(rect1_y_cabin) * 20
                    rect2_x_cabin = point2_cabin.X / 20
                    rect2_x_cabin = Fix(rect2_x_cabin) * 20
                    rect2_y_cabin = point2_cabin.Y / 20
                    rect2_y_cabin = Fix(rect2_y_cabin) * 20
                    m = (rect2_x_cabin - rect1_x_cabin) / 20
                    n = (rect2_y_cabin - rect1_y_cabin) / 20
                    If color2_cabin.ToArgb <> Color.Blue.ToArgb And color1_cabin.ToArgb <> Color.Blue.ToArgb Then
                        For j = 0 To m
                            For k = 0 To n
                                bmpgraphics_cabin.FillRectangle(bru_fill, rect1_x_cabin + 20 * j + 1, rect1_y_cabin + 20 * k + 1, 19, 19)
                                '  ptbox_board.Refresh()
                            Next
                        Next
                        ptbox_cabin.Refresh()
                    Else
                        If color1_cabin.ToArgb = color2_cabin.ToArgb And color1_cabin.ToArgb = Color.Blue.ToArgb Then
                            For j = 0 To m
                                For k = 0 To n
                                    bmpgraphics_cabin.FillRectangle(bru_sys, rect1_x_cabin + 20 * j + 1, rect1_y_cabin + 20 * k + 1, 19, 19)
                                    '  ptbox_board.Refresh()
                                Next
                            Next
                            ptbox_cabin.Refresh()
                        End If
                    End If
                    If color1_cabin.ToArgb = Color.Blue.ToArgb And color2_cabin.ToArgb = Color.Red.ToArgb Then
                        bmpgraphics_cabin.FillRectangle(bru_sys, rect1_x_cabin + 1, rect1_y_cabin + 1, 19, 19)
                        ptbox_cabin.Refresh()
                    End If
                    If color1_cabin.ToArgb = Color.Blue.ToArgb And color2_cabin.ToArgb <> Color.Blue.ToArgb And color2_cabin.ToArgb <> Color.Red.ToArgb Then
                        bmpgraphics_cabin.FillRectangle(bru_fill, rect1_x_cabin + 1, rect1_y_cabin + 1, 19, 19)
                        ptbox_cabin.Refresh()
                    End If
                    If color1_cabin.ToArgb <> Color.Blue.ToArgb And color2_cabin.ToArgb = Color.Blue.ToArgb Then
                        bmpgraphics_cabin.FillRectangle(bru_sys, rect1_x_cabin + 1, rect1_y_cabin + 1, 19, 19)
                        ptbox_cabin.Refresh()
                    End If
                    If (m < 0 Or n < 0) Then
                        If color1_cabin.ToArgb = Color.Blue.ToArgb Then
                            bmpgraphics_cabin.FillRectangle(bru_fill, rect1_x_cabin + 1, rect1_y_cabin + 1, 19, 19)
                            ptbox_cabin.Refresh()
                        Else
                            bmpgraphics_cabin.FillRectangle(bru_sys, rect1_x_cabin + 1, rect1_y_cabin + 1, 19, 19)
                            ptbox_cabin.Refresh()
                        End If
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub cmb_exist_bay_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_exist_bay.TextChanged
        'Me.cmb_copy.Text = ""
        Me.cmb_bay.Text = Me.cmb_exist_bay.Text
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
            Else                                     '删除按钮不可见
                Me.ToolBar.Buttons.Item(5).Enabled = False
                mnuDelete.Enabled = False
            End If
        End If

    End Sub

    Private Sub btResure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResure.Click
        SqlStrShip = "where (((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','4')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) and Voyage like '" & Trim(txtVoyage.Text) & "%' and (ENG_VESSEL Like '" & Trim(txtShipName.Text) & "%' OR CHI_VESSEL like '" & Trim(txtShipName.Text) & "%' )) "
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

    Private Sub Frm_bay_map_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.C1DBGV.Height = Me.Height - 140
        Me.Label8.Top = Me.C1DBGV.Height + 20
        Me.txtShipName.Top = Me.C1DBGV.Height + 20
        Me.Label7.Top = Me.C1DBGV.Height + 40
        Me.txtVoyage.Top = Me.C1DBGV.Height + 40
        Me.btResure.Top = Me.C1DBGV.Height + 40
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub C1DBGV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1DBGV.Click

    End Sub
End Class
