Imports TALLY.DBControl
Public Class FrmConLoadFinalNew
    Inherits System.Windows.Forms.Form

    Dim dsT As New DataSet
    Dim dsH As New DataSet
    Dim SqlStr As String  '条件语句
    Dim SelectStr As String
    Dim DynaStr As String '可变的条件设计
    Dim FirmStr As String '不变的条件设计
    Dim ColNum As Integer '不显示的列数
    Const strPrefix As String = " Top 200 " 'Sql语句可选前缀
    Dim sqlSelectT, sqlSelectH As String '完整查询语句

    Dim iClickCount As Integer

    Public Shared amount As Integer
    Public Shared weight, volume As Decimal
    Public Shared strShip, strShipName, strVoyage, strBill As String
    Friend WithEvents mnuAllConvert As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Public Shared strOperateMark As String  '控制放行处理时操作 ，“0”查看，“1”放行，“2”退关，“3”退关时放行


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
    Friend WithEvents tbpConLoad As System.Windows.Forms.TabPage
    Friend WithEvents tbpConHatch As System.Windows.Forms.TabPage
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFind As System.Windows.Forms.MenuItem
    Friend WithEvents mnuQuery As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuQuit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAdd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuNow As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFinish As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBack As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents mnuState As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOperate As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReport As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    Friend WithEvents tbbtnFind As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnQuery As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnAdd As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnEdit As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnReport As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnPrint As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnExport As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbnsp1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnNow As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnFinish As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnBack As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbnsp2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnQuit As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuConLoad As System.Windows.Forms.MenuItem
    Friend WithEvents mnuConHatch As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDeal As System.Windows.Forms.MenuItem
    Friend WithEvents tbnConLoad As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbnConHatch As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbnDeal As System.Windows.Forms.ToolBarButton
    Friend WithEvents C1DBGT As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1DBGH As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents tbcUse As System.Windows.Forms.TabControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConLoadFinalNew))
        Me.tbcUse = New System.Windows.Forms.TabControl
        Me.tbpConLoad = New System.Windows.Forms.TabPage
        Me.C1DBGT = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.tbpConHatch = New System.Windows.Forms.TabPage
        Me.C1DBGH = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.MainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuFind = New System.Windows.Forms.MenuItem
        Me.mnuQuery = New System.Windows.Forms.MenuItem
        Me.mnuSep1 = New System.Windows.Forms.MenuItem
        Me.mnuConLoad = New System.Windows.Forms.MenuItem
        Me.mnuConHatch = New System.Windows.Forms.MenuItem
        Me.mnuSep2 = New System.Windows.Forms.MenuItem
        Me.mnuQuit = New System.Windows.Forms.MenuItem
        Me.mnuOperate = New System.Windows.Forms.MenuItem
        Me.mnuAdd = New System.Windows.Forms.MenuItem
        Me.mnuEdit = New System.Windows.Forms.MenuItem
        Me.mnuReport = New System.Windows.Forms.MenuItem
        Me.mnuDeal = New System.Windows.Forms.MenuItem
        Me.mnuState = New System.Windows.Forms.MenuItem
        Me.mnuNow = New System.Windows.Forms.MenuItem
        Me.mnuFinish = New System.Windows.Forms.MenuItem
        Me.mnuBack = New System.Windows.Forms.MenuItem
        Me.mnuHelp = New System.Windows.Forms.MenuItem
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar = New System.Windows.Forms.ToolBar
        Me.tbbtnFind = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuery = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep1 = New System.Windows.Forms.ToolBarButton
        Me.tbnConLoad = New System.Windows.Forms.ToolBarButton
        Me.tbnConHatch = New System.Windows.Forms.ToolBarButton
        Me.tbnsp1 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnAdd = New System.Windows.Forms.ToolBarButton
        Me.tbbtnEdit = New System.Windows.Forms.ToolBarButton
        Me.tbbtnReport = New System.Windows.Forms.ToolBarButton
        Me.tbnDeal = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep2 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnPrint = New System.Windows.Forms.ToolBarButton
        Me.tbbtnExport = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep3 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnNow = New System.Windows.Forms.ToolBarButton
        Me.tbbtnFinish = New System.Windows.Forms.ToolBarButton
        Me.tbbtnBack = New System.Windows.Forms.ToolBarButton
        Me.tbnsp2 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuit = New System.Windows.Forms.ToolBarButton
        Me.mnuAllConvert = New System.Windows.Forms.MenuItem
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.tbcUse.SuspendLayout()
        Me.tbpConLoad.SuspendLayout()
        CType(Me.C1DBGT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpConHatch.SuspendLayout()
        CType(Me.C1DBGH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcUse
        '
        Me.tbcUse.Controls.Add(Me.tbpConLoad)
        Me.tbcUse.Controls.Add(Me.tbpConHatch)
        Me.tbcUse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcUse.Location = New System.Drawing.Point(0, 42)
        Me.tbcUse.Name = "tbcUse"
        Me.tbcUse.SelectedIndex = 0
        Me.tbcUse.Size = New System.Drawing.Size(712, 425)
        Me.tbcUse.TabIndex = 0
        '
        'tbpConLoad
        '
        Me.tbpConLoad.Controls.Add(Me.C1DBGT)
        Me.tbpConLoad.Location = New System.Drawing.Point(4, 22)
        Me.tbpConLoad.Name = "tbpConLoad"
        Me.tbpConLoad.Size = New System.Drawing.Size(704, 399)
        Me.tbpConLoad.TabIndex = 0
        Me.tbpConLoad.Text = "理货单信息 放行处理"
        '
        'C1DBGT
        '
        Me.C1DBGT.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGT.AllowUpdate = False
        Me.C1DBGT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DBGT.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.C1DBGT.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGT.Images.Add(CType(resources.GetObject("C1DBGT.Images"), System.Drawing.Image))
        Me.C1DBGT.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGT.Name = "C1DBGT"
        Me.C1DBGT.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGT.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGT.PreviewInfo.ZoomFactor = 75
        Me.C1DBGT.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGT.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGT.Size = New System.Drawing.Size(704, 399)
        Me.C1DBGT.TabIndex = 0
        Me.C1DBGT.Text = "C1DBG"
        Me.C1DBGT.PropBag = resources.GetString("C1DBGT.PropBag")
        '
        'tbpConHatch
        '
        Me.tbpConHatch.Controls.Add(Me.C1DBGH)
        Me.tbpConHatch.Location = New System.Drawing.Point(4, 21)
        Me.tbpConHatch.Name = "tbpConHatch"
        Me.tbpConHatch.Size = New System.Drawing.Size(704, 400)
        Me.tbpConHatch.TabIndex = 1
        Me.tbpConHatch.Text = "舱单信息 报文处理"
        '
        'C1DBGH
        '
        Me.C1DBGH.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBGH.AllowUpdate = False
        Me.C1DBGH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DBGH.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.C1DBGH.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGH.Images.Add(CType(resources.GetObject("C1DBGH.Images"), System.Drawing.Image))
        Me.C1DBGH.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGH.Name = "C1DBGH"
        Me.C1DBGH.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGH.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGH.PreviewInfo.ZoomFactor = 75
        Me.C1DBGH.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGH.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGH.Size = New System.Drawing.Size(704, 400)
        Me.C1DBGH.TabIndex = 0
        Me.C1DBGH.Text = "C1DBG"
        Me.C1DBGH.PropBag = resources.GetString("C1DBGH.PropBag")
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuOperate, Me.mnuState, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFind, Me.mnuQuery, Me.mnuSep1, Me.mnuConLoad, Me.mnuConHatch, Me.mnuSep2, Me.mnuQuit})
        Me.mnuFile.Text = "文件(&F)"
        '
        'mnuFind
        '
        Me.mnuFind.Index = 0
        Me.mnuFind.Text = "检索(&F)"
        '
        'mnuQuery
        '
        Me.mnuQuery.Index = 1
        Me.mnuQuery.Text = "查找(&Q)"
        '
        'mnuSep1
        '
        Me.mnuSep1.Index = 2
        Me.mnuSep1.Text = "-"
        '
        'mnuConLoad
        '
        Me.mnuConLoad.Checked = True
        Me.mnuConLoad.Index = 3
        Me.mnuConLoad.Text = "理货放行"
        '
        'mnuConHatch
        '
        Me.mnuConHatch.Index = 4
        Me.mnuConHatch.Text = "舱单报文"
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
        'mnuOperate
        '
        Me.mnuOperate.Index = 1
        Me.mnuOperate.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAdd, Me.mnuEdit, Me.mnuReport, Me.mnuDeal, Me.mnuAllConvert})
        Me.mnuOperate.Text = "操作(&O)"
        '
        'mnuAdd
        '
        Me.mnuAdd.Index = 0
        Me.mnuAdd.Text = "增加(&A)"
        '
        'mnuEdit
        '
        Me.mnuEdit.Index = 1
        Me.mnuEdit.Text = "修改(&E)"
        '
        'mnuReport
        '
        Me.mnuReport.Index = 2
        Me.mnuReport.Text = "报文(&P)"
        '
        'mnuDeal
        '
        Me.mnuDeal.Index = 3
        Me.mnuDeal.Text = "处理（&M）"
        '
        'mnuState
        '
        Me.mnuState.Index = 2
        Me.mnuState.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuNow, Me.mnuFinish, Me.mnuBack})
        Me.mnuState.Text = "状态(&S)"
        '
        'mnuNow
        '
        Me.mnuNow.Checked = True
        Me.mnuNow.Index = 0
        Me.mnuNow.Text = "当前(&N)"
        '
        'mnuFinish
        '
        Me.mnuFinish.Index = 1
        Me.mnuFinish.Text = "完成(&C)"
        '
        'mnuBack
        '
        Me.mnuBack.Index = 2
        Me.mnuBack.Text = "退关区(&B)"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 3
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
        Me.ImageList.Images.SetKeyName(20, "")
        Me.ImageList.Images.SetKeyName(21, "")
        '
        'ToolBar
        '
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnFind, Me.tbbtnQuery, Me.tbbtnSep1, Me.tbnConLoad, Me.tbnConHatch, Me.tbnsp1, Me.tbbtnAdd, Me.tbbtnEdit, Me.tbbtnReport, Me.tbnDeal, Me.tbbtnSep2, Me.tbbtnPrint, Me.tbbtnExport, Me.tbbtnSep3, Me.tbbtnNow, Me.tbbtnFinish, Me.tbbtnBack, Me.tbnsp2, Me.ToolBarButton1, Me.tbbtnQuit})
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(712, 42)
        Me.ToolBar.TabIndex = 17
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
        Me.tbbtnQuery.Text = "查找"
        Me.tbbtnQuery.ToolTipText = "查找"
        '
        'tbbtnSep1
        '
        Me.tbbtnSep1.Name = "tbbtnSep1"
        Me.tbbtnSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbnConLoad
        '
        Me.tbnConLoad.ImageIndex = 13
        Me.tbnConLoad.Name = "tbnConLoad"
        Me.tbnConLoad.Pushed = True
        Me.tbnConLoad.Tag = "123"
        Me.tbnConLoad.Text = "理货放行"
        '
        'tbnConHatch
        '
        Me.tbnConHatch.ImageIndex = 21
        Me.tbnConHatch.Name = "tbnConHatch"
        Me.tbnConHatch.Text = "舱单报文"
        '
        'tbnsp1
        '
        Me.tbnsp1.Name = "tbnsp1"
        Me.tbnsp1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnAdd
        '
        Me.tbbtnAdd.ImageIndex = 2
        Me.tbbtnAdd.Name = "tbbtnAdd"
        Me.tbbtnAdd.Text = "增加"
        Me.tbbtnAdd.ToolTipText = "增加"
        '
        'tbbtnEdit
        '
        Me.tbbtnEdit.ImageIndex = 3
        Me.tbbtnEdit.Name = "tbbtnEdit"
        Me.tbbtnEdit.Text = "修改"
        Me.tbbtnEdit.ToolTipText = "修改"
        '
        'tbbtnReport
        '
        Me.tbbtnReport.ImageIndex = 15
        Me.tbbtnReport.Name = "tbbtnReport"
        Me.tbbtnReport.Text = "报文"
        Me.tbbtnReport.ToolTipText = "报文"
        '
        'tbnDeal
        '
        Me.tbnDeal.ImageIndex = 18
        Me.tbnDeal.Name = "tbnDeal"
        Me.tbnDeal.Text = "处理"
        Me.tbnDeal.ToolTipText = "放行退关处理"
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
        Me.tbbtnPrint.Visible = False
        '
        'tbbtnExport
        '
        Me.tbbtnExport.ImageIndex = 6
        Me.tbbtnExport.Name = "tbbtnExport"
        Me.tbbtnExport.Text = "导出"
        Me.tbbtnExport.ToolTipText = "导出Excel"
        Me.tbbtnExport.Visible = False
        '
        'tbbtnSep3
        '
        Me.tbbtnSep3.Name = "tbbtnSep3"
        Me.tbbtnSep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnNow
        '
        Me.tbbtnNow.ImageIndex = 10
        Me.tbbtnNow.Name = "tbbtnNow"
        Me.tbbtnNow.Pushed = True
        Me.tbbtnNow.Text = "当前"
        Me.tbbtnNow.ToolTipText = "当前未放行的信息"
        '
        'tbbtnFinish
        '
        Me.tbbtnFinish.ImageIndex = 11
        Me.tbbtnFinish.Name = "tbbtnFinish"
        Me.tbbtnFinish.Text = "完成"
        Me.tbbtnFinish.ToolTipText = "完成"
        '
        'tbbtnBack
        '
        Me.tbbtnBack.ImageIndex = 8
        Me.tbbtnBack.Name = "tbbtnBack"
        Me.tbbtnBack.Text = "退关区"
        Me.tbbtnBack.ToolTipText = "退关箱记录"
        '
        'tbnsp2
        '
        Me.tbnsp2.Name = "tbnsp2"
        Me.tbnsp2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnQuit
        '
        Me.tbbtnQuit.ImageIndex = 7
        Me.tbbtnQuit.Name = "tbbtnQuit"
        Me.tbbtnQuit.Text = "退出"
        Me.tbbtnQuit.ToolTipText = "退出"
        '
        'mnuAllConvert
        '
        Me.mnuAllConvert.Index = 4
        Me.mnuAllConvert.Text = "换船（&H）"
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 12
        Me.ToolBarButton1.Name = "ToolBarButton1"
        Me.ToolBarButton1.Text = "换船"
        Me.ToolBarButton1.ToolTipText = "放行数据整船调整"
        '
        'FrmConLoadFinalNew
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.ClientSize = New System.Drawing.Size(712, 467)
        Me.Controls.Add(Me.tbcUse)
        Me.Controls.Add(Me.ToolBar)
        Me.Font = New System.Drawing.Font("新宋体", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Menu = Me.MainMenu
        Me.Name = "FrmConLoadFinalNew"
        Me.Text = "出口集装箱放行核查"
        Me.tbcUse.ResumeLayout(False)
        Me.tbpConLoad.ResumeLayout(False)
        CType(Me.C1DBGT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpConHatch.ResumeLayout(False)
        CType(Me.C1DBGH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub FrmConLoadFinalNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Text = Me.Text & "_" & G_DeptName
        Dim i As Integer

        '得到一个Ship_ID 这里得不到
        'For i = 0 To dsT.Tables(0).Rows.Count - 1
        '    If Not IsDBNull(dsT.Tables(0).Rows(i)("Ship_ID")) Then
        '        Ship_ID = dsT.Tables(0).Rows(i)("Ship_ID")
        '        Exit For
        '    End If
        'Next

        '显示舱单报文界面
        Me.C1DBGH.InsertHorizontalSplit(0)
        ColNum = 8 '不显示的列数
        '须是出口在港船且在连云港装的箱
        FirmStr = " INOUTPORT = '1' and SHIP_STATU <>'4' and CODE_LOAD_PORT  like '%LYG%' Order by Ship_ID, ID DESC"
        DynaStr = "1<>1"    '是不是改为永假式
        SelectStr = strPrefix
        SqlStr = DynaStr & " and " & FirmStr
        Table_Name = "View_HatchCargo"
        sqlSelectH = "select " & SelectStr & " * from " & Table_Name & " where " & SqlStr
        Getdata2(sqlSelectH, dsH)
        Me.C1DBGH.DataSource = dsH.Tables(0).DefaultView
        Me.C1DBGH.Columns("ENG_VESSEL").FooterText = "合计" & dsH.Tables(0).Rows.Count & "条"

        Me.C1DBGH.ColumnFooters = True
        Me.C1DBGH.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGH.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        Me.C1DBGH.FetchRowStyles = True
        Call SetColumnCaption(Me.C1DBGH, Table_Name)
        Call SetDGWidth(C1DBGH, 4)
        For i = 0 To 19
            Me.C1DBGH.Splits(1).DisplayColumns(i).Visible = False
        Next
        For i = 0 To ColNum - 1 '设定不显示的列数
            C1DBGH.Splits(0).DisplayColumns.Item(i).Visible = False
        Next
        For i = 20 To Me.C1DBGH.Columns.Count - 1
            Me.C1DBGH.Splits(0).DisplayColumns(i).Visible = False
        Next
        Me.C1DBGH.RowHeight = 18
        Me.C1DBGH.Splits(0).ColumnCaptionHeight = 20

        '显示放行理货单界面，当前状态记录的条件
        ColNum = 16 '不显示的列数
        FirmStr = " InOutPort = '1' and TradeMark = '0' and (StateC ='2' or StateC ='1') Order by ID DESC"
        DynaStr = ""
        SelectStr = strPrefix
        SqlStr = FirmStr
        Table_Name = "View_ConLoadTally"
        sqlSelectT = "select " & SelectStr & " * from " & Table_Name & " where " & SqlStr
        Getdata2(sqlSelectT, dsT)
        Me.C1DBGT.DataSource = dsT.Tables(0).DefaultView
        Me.C1DBGT.Columns("Code_Yard_Name").FooterText = "合计" & dsT.Tables(0).Rows.Count & "条"

        Me.C1DBGT.ColumnFooters = True
        Me.C1DBGT.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGT.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        Me.C1DBGT.FetchRowStyles = True
        Me.C1DBGT.Columns("InputTime").NumberFormat = "yy-MM-dd HH:mm"
        Me.C1DBGT.Columns("CheckTime").NumberFormat = "yy-MM-dd HH:mm"
        Me.C1DBGT.Columns("PrintTime").NumberFormat = "yy-MM-dd HH:mm"
        Me.C1DBGT.Columns("ConTime").NumberFormat = "yy-MM-dd HH:mm"
        Call SetColumnCaption(Me.C1DBGT, Table_Name)
        'Call SetDGWidth(C1DBGT, 2)
        Call SetDGWidth3(C1DBGT)
        For i = 0 To ColNum - 1 '设定不显示的列数
            C1DBGT.Splits(0).DisplayColumns.Item(i).Visible = False
        Next
        Me.C1DBGT.RowHeight = 18
        Me.C1DBGT.Splits(0).ColumnCaptionHeight = 20
        Me.tbcUse.SelectedIndex = 0
        Call Me.AlterFaceLoad()
    End Sub

    Private Sub myDataGrid(ByVal SelStr As String, ByVal Sql As String)
        Try
            If mnuConLoad.Checked Then
                sqlSelectT = "select " & SelStr & " * from " & Table_Name & " where " & Sql
                Getdata2(sqlSelectT, dsT)
                Me.C1DBGT.Columns("Code_Yard_Name").FooterText = "合计" & dsT.Tables(0).Rows.Count & "条"
            ElseIf mnuConHatch.Checked Then
                sqlSelectH = "select " & SelStr & " * from " & Table_Name & " where " & Sql
                Getdata2(sqlSelectH, dsH)
                Me.C1DBGH.Columns("ENG_VESSEL").FooterText = "合计" & dsH.Tables(0).Rows.Count & "条"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaption(ByRef C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid, ByVal strTableName As String)
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dset As New DataSet
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Try
            str = "select Field_Eng,Field_Cha From Field_Att where Table_Name='" & strTableName & "'"
            sqlconn.ConnectionString = conn
            sqlc.Connection = sqlconn
            sqlc.CommandText = str
            sqla.SelectCommand = sqlc
            dset.Reset()
            sqla.Fill(dset)
            i = ColNum

            Do While i < C1DBG.Columns.Count
                j = 0
                For j = 0 To dset.Tables(0).Rows.Count - 1

                    If Upper(Trim(dset.Tables(0).Rows(j)("Field_Eng"))) = _
                        Upper(Trim(C1DBG.Columns.Item(i).DataField.ToString)) Then
                        C1DBG.Columns.Item(i).Caption = Trim(dset.Tables(0).Rows(j)("Field_Cha"))
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

    Private Sub mnuFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFind.Click
        Dim FrmFind As New FrmFind
        FrmFind.ShowDialog()
        If Flag = 0 Then
            SelectStr = ""
            DynaStr = Sql_Find
            SqlStr = DynaStr & " and " & FirmStr
            myDataGrid(SelectStr, SqlStr)
        ElseIf Flag = 2 Then
            myDataGrid("", FirmStr)
        End If
        'If mnuConLoad.Checked Then
        'ElseIf mnuConHatch.Checked Then
        'End If
    End Sub

    Private Sub mnuQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuery.Click
        If mnuConLoad.Checked Then
            Dim FrmSelect As New FrmContainerOutPort_Select
            FrmSelect.ShowDialog()
            If FrmSelect.flag = True Then
                SelectStr = ""
                DynaStr = FrmSelect.strSelect
                SqlStr = DynaStr & " and " & FirmStr
                myDataGrid(SelectStr, SqlStr)
                Call mnuDeal_Click(sender, e)
            Else
                SelectStr = strPrefix
                DynaStr = ""
                SqlStr = FirmStr
                Call myDataGrid(SelectStr, SqlStr)
            End If
        ElseIf mnuConHatch.Checked Then
            Dim FrmSelect As New FrmConLoadFinalCheck_Select
            FrmSelect.ShowDialog()
            If FrmSelect.flag = True Then
                SelectStr = ""
                DynaStr = FrmSelect.strSelect
                SqlStr = DynaStr & " and " & FirmStr
                myDataGrid(SelectStr, SqlStr)
            End If
        End If

    End Sub

    Private Sub mnuNow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNow.Click
        '当前状态记录的条件
        Try
            FirmStr = " InOutPort = '1' and TradeMark = '0' and (StateC ='2' or StateC ='1') Order by ID DESC"
            DynaStr = ""
            SelectStr = strPrefix
            SqlStr = FirmStr
            mnuNow.Checked = True
            mnuFinish.Checked = False
            mnuBack.Checked = False
            Me.tbbtnNow.Pushed = True
            Me.tbbtnFinish.Pushed = False
            Me.tbbtnBack.Pushed = False
            Table_Name = "View_ConLoadTally"
            myDataGrid(SelectStr, SqlStr)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub mnuFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFinish.Click
        '完成状态记录的条件
        FirmStr = " InOutPort = '1' and TradeMark = '0' and StateC ='3' Order by ID DESC"
        DynaStr = ""
        SelectStr = strPrefix
        SqlStr = FirmStr
        mnuNow.Checked = False
        mnuFinish.Checked = True
        mnuBack.Checked = False
        Me.tbbtnNow.Pushed = False
        Me.tbbtnFinish.Pushed = True
        Me.tbbtnBack.Pushed = False
        Table_Name = "View_ConLoadTally"
        myDataGrid(SelectStr, SqlStr)
    End Sub

    Private Sub mnuBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBack.Click
        '退关状态记录的条件
        FirmStr = " InOutPort = '1' and TradeMark = '0' and StateC ='4' Order by ID DESC"
        DynaStr = ""
        SelectStr = ""
        SqlStr = FirmStr
        mnuNow.Checked = False
        mnuFinish.Checked = False
        mnuBack.Checked = True
        Me.tbbtnNow.Pushed = False
        Me.tbbtnFinish.Pushed = False
        Me.tbbtnBack.Pushed = True
        Table_Name = "View_ConLoadTally"
        myDataGrid(SelectStr, SqlStr)
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbcUse.SelectedIndexChanged
        If Me.tbcUse.SelectedTab Is Me.tbpConLoad Then
            Call AlterFaceLoad()
            '变更显示的表条件
            '默认当前记录界面()
            If mnuNow.Checked Then
                Call Me.mnuNow_Click(sender, e)
            ElseIf mnuFinish.Checked Then
                Call Me.mnuFinish_Click(sender, e)
            ElseIf mnuBack.Checked Then
                Call Me.mnuBack_Click(sender, e)
            End If
        ElseIf Me.tbcUse.SelectedTab Is Me.tbpConHatch Then
            Call AlterFaceHatch()
            '变更显示的表条件
            If Me.C1DBGT.Columns("Ship_ID").Text <> "" Then
                Ship_ID = Me.C1DBGT.Columns("Ship_ID").Text
            End If
            FirmStr = " INOUTPORT = '1' and SHIP_STATU <>'4' and CODE_LOAD_PORT  like '%LYG%' Order by Ship_ID, ID DESC"
            DynaStr = " Ship_ID = " & Ship_ID
            SelectStr = ""
            SqlStr = DynaStr & " and " & FirmStr
            Table_Name = "View_HatchCargo"
            myDataGrid(SelectStr, SqlStr)
        End If
    End Sub

    Private Sub AlterFaceLoad()
        mnuDeal.Visible = True
        mnuAdd.Visible = False
        mnuEdit.Visible = False
        mnuReport.Visible = False
        mnuState.Visible = True

        Me.tbnDeal.Visible = True
        Me.tbbtnAdd.Visible = False
        Me.tbbtnEdit.Visible = False
        Me.tbbtnReport.Visible = False
        Me.tbbtnNow.Visible = True
        Me.tbbtnFinish.Visible = True
        Me.tbbtnBack.Visible = True

        mnuConLoad.Checked = True
        mnuConHatch.Checked = False

        Me.tbnConLoad.Pushed = True
        Me.tbnConHatch.Pushed = False
    End Sub

    Private Sub AlterFaceHatch()
        mnuDeal.Visible = False
        mnuAdd.Visible = True
        mnuEdit.Visible = True
        mnuReport.Visible = True
        mnuState.Visible = False

        Me.tbnDeal.Visible = False
        Me.tbbtnAdd.Visible = True
        Me.tbbtnEdit.Visible = True
        Me.tbbtnReport.Visible = True
        Me.tbbtnNow.Visible = False
        Me.tbbtnFinish.Visible = False
        Me.tbbtnBack.Visible = False

        mnuConHatch.Checked = True
        mnuConLoad.Checked = False

        Me.tbnConLoad.Pushed = False
        Me.tbnConHatch.Pushed = True
    End Sub

    Private Sub mnuConLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConLoad.Click
        Me.tbcUse.SelectedTab = Me.tbpConLoad
        'Call TabControl1_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub mnuConHatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConHatch.Click
        Me.tbcUse.SelectedTab = Me.tbpConHatch
        'Call TabControl1_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub ToolBar_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar.ButtonClick
        Select Case e.Button.Text
            Case "检索"
                mnuFind_Click(sender, e)
            Case "查找"
                Call mnuQuery_Click(sender, e)
            Case "增加"
                Call mnuAdd_Click(sender, e)
            Case "修改"
                Call mnuEdit_Click(sender, e)
            Case "报文"
                Call mnuReport_Click(sender, e)
            Case "退出"
                Call mnuQuit_Click(sender, e)
            Case "当前"
                Call mnuNow_Click(sender, e)
            Case "完成"
                Call mnuFinish_Click(sender, e)
            Case "退关区"
                Call mnuBack_Click(sender, e)
            Case "处理"
                Call mnuDeal_Click(sender, e)
            Case "理货放行"
                Call mnuConLoad_Click(sender, e)
            Case "舱单报文"
                Call mnuConHatch_Click(sender, e)
            Case "换船"
                Call FrmConLoadTally.mnuAllConvert_Click(sender, e)
        End Select
    End Sub

    Private Sub C1DBGT_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBGT.FetchRowStyle
        If Me.C1DBGT.Columns("checked").CellValue(e.Row) = "1" Then
            e.CellStyle.ForeColor = System.Drawing.Color.DarkGreen
            e.CellStyle.Font = New Font("DotumChe", 13, FontStyle.Bold, GraphicsUnit.Pixel)
        End If
        If Me.C1DBGT.Columns("TradeMark").CellValue(e.Row) = "1" Then
            e.CellStyle.Font = New Font("新宋体", 13, FontStyle.Underline, GraphicsUnit.Pixel)
        End If
        Select Case Me.C1DBGT.Columns("StateC").CellText(e.Row)
            Case "1"
            Case "2"
                e.CellStyle.BackColor = System.Drawing.Color.Lavender
            Case "3"
                e.CellStyle.BackColor = System.Drawing.Color.Wheat
            Case "4"
                e.CellStyle.BackColor = System.Drawing.Color.Lime
            Case "0"
                e.CellStyle.BackColor = System.Drawing.Color.Olive
        End Select

    End Sub

    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        TBar = 1
        Mnu = 1
    End Sub

    Private Sub mnuDeal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDeal.Click
        If dsT.Tables(0).Rows.Count > 0 Then
            Dim FrmDeal As New FrmConLoadFinalCheck_Deal
            ID = CType(Me.C1DBGT.Columns.Item("ID").Text.ToString, Integer)
            If mnuNow.Checked Then
                strOperateMark = "1"    '正常放行
            ElseIf mnuFinish.Checked Then
                strOperateMark = "2"    '完成后处理
            ElseIf mnuBack.Checked Then
                strOperateMark = "3"    '退关记录处理
            End If
            FrmDeal.ShowDialog()
            If FrmDeal.passMark Then
                '此时Ship_ID 必定存在
                '不要每次放行完后转到舱单报文界面
                'Me.tbcUse.SelectedTab = Me.tbpConHatch
            ElseIf FrmDeal.backMark Then
                Call Me.mnuBack_Click(sender, e)
            ElseIf FrmDeal.revertMark Then
                Call Me.mnuNow_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub mnuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdd.Click
        If dsH.Tables(0).Rows.Count > 0 Then
            Ship_ID = Me.C1DBGH.Columns("SHIP_ID").Text
        End If
        strShipName = Me.C1DBGH.Columns("Chi_Vessel").Text
        strVoyage = Me.C1DBGH.Columns("Voyage").Text
        strBill = Me.C1DBGH.Columns("BLNO").Text
        Dim FrmAdd As New FrmConLoadFinalNew_Add
        FrmAdd.ShowDialog()
        If FrmAdd.AddFlag Then
            myDataGrid(SelectStr, SqlStr)
        End If
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        If dsH.Tables(0).Rows.Count > 0 Then
            Ship_ID = Me.C1DBGH.Columns("SHIP_ID").Text
            strShipName = Me.C1DBGH.Columns("Chi_Vessel").Text
            strVoyage = Me.C1DBGH.Columns("Voyage").Text
            strBill = Me.C1DBGH.Columns("BLNO").Text
            Dim FrmEdit As New FrmConLoadFinalNew_Edit
            FrmEdit.ShowDialog()
            If FrmEdit.blSave Then
                myDataGrid(SelectStr, SqlStr)
            End If
        End If
    End Sub

    Private Sub mnuReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReport.Click
        If Me.C1DBGH.Columns("SHIP_ID").Text <> "" Then
            Ship_ID = Me.C1DBGH.Columns("SHIP_ID").Text
        Else
            Ship_ID = 0
        End If
        '这里得到的船次肯定是出口的，导报文只要把装货港是连云港的提单选出即可
        'strShip = Me.C1DBGH.Columns("CHI_VESSEL").Text
        'strShipName = Me.C1DBGH.Columns("ShipName").Text
        'strVoyage = Me.C1DBGH.Columns("Voyage").Text
        'strBill = Me.C1DBGH.Columns("BLNO").Text

        Dim FrmRePort As New FrmConLoadFinal_Report
        FrmRePort.ShowDialog()

    End Sub

    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
        Me.Close()
    End Sub

    Private Sub C1DBGT_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBGT.DoubleClick
        If dsT.Tables(0).Rows.Count > 0 Then
            Dim FrmDeal As New FrmConLoadFinalCheck_Deal
            ID = CType(Me.C1DBGT.Columns.Item("ID").Text.ToString, Integer)
            strOperateMark = "0"    '仅查看
            FrmDeal.ShowDialog()
        End If
    End Sub

    Private Sub C1DBGH_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBGH.DoubleClick
        If dsH.Tables(0).Rows.Count > 0 Then
            Dim FrmEdit As New FrmConLoadFinalNew_Edit
            ID = CType(Me.C1DBGH.Columns.Item("ID").Text.ToString, Integer)
            Ship_ID = Me.C1DBGH.Columns("SHIP_ID").Text
            strShipName = Me.C1DBGH.Columns("Chi_Vessel").Text
            strVoyage = Me.C1DBGH.Columns("Voyage").Text
            strBill = Me.C1DBGH.Columns("BLNO").Text
            FrmEdit.btnDelete.Visible = False
            FrmEdit.btSave.Visible = False
            FrmEdit.btQuit.Left = FrmEdit.btQuit.Left - 34
            FrmEdit.Text = "出口舱单信息 查看"
            FrmEdit.ShowDialog()
        End If
    End Sub

    Friend Sub mnuAllConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAllConvert.Click
        Dim frm As New FrmConLoadTally_AllConvert
        frm.Show()
        'If frm.blSave Then
        '    mnuRefresh_Click(sender, e)
        'End If
    End Sub
End Class
