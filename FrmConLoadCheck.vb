Imports TALLY.DBControl
Public Class FrmConLoadCheck
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
    Friend WithEvents tbbtnQuery As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuCompile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAdd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnSep1 As System.Windows.Forms.ToolBarButton
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
    Friend WithEvents tbbtnExport As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnDelete As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnEdit As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnAdd As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnFind As System.Windows.Forms.ToolBarButton
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents tbbtnPrint As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    Friend WithEvents tbbtnSep3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnQuit As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents mnuTotal As System.Windows.Forms.MenuItem
    Friend WithEvents tbbnTotal As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuFinish As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnFinish As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnHche As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuHche As System.Windows.Forms.MenuItem
    Friend WithEvents tbbnTongCheck As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuTongCheck As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAlterReport As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExtract As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnAlterReport As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuDivide As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnDivide As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnAllConvert As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbttnExtract As System.Windows.Forms.ToolBarButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConLoadCheck))
        Me.tbbtnQuery = New System.Windows.Forms.ToolBarButton
        Me.mnuCompile = New System.Windows.Forms.MenuItem
        Me.mnuAdd = New System.Windows.Forms.MenuItem
        Me.mnuTongCheck = New System.Windows.Forms.MenuItem
        Me.mnuHche = New System.Windows.Forms.MenuItem
        Me.mnuEdit = New System.Windows.Forms.MenuItem
        Me.mnuDelete = New System.Windows.Forms.MenuItem
        Me.mnuAlterReport = New System.Windows.Forms.MenuItem
        Me.mnuExtract = New System.Windows.Forms.MenuItem
        Me.mnuDivide = New System.Windows.Forms.MenuItem
        Me.tbbtnSep1 = New System.Windows.Forms.ToolBarButton
        Me.MainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuFind = New System.Windows.Forms.MenuItem
        Me.mnuQuery = New System.Windows.Forms.MenuItem
        Me.mnuTotal = New System.Windows.Forms.MenuItem
        Me.mnuFinish = New System.Windows.Forms.MenuItem
        Me.mnuSep1 = New System.Windows.Forms.MenuItem
        Me.mnuPrint = New System.Windows.Forms.MenuItem
        Me.mnuExport = New System.Windows.Forms.MenuItem
        Me.mnuSep2 = New System.Windows.Forms.MenuItem
        Me.mnuQuit = New System.Windows.Forms.MenuItem
        Me.mnuHelp = New System.Windows.Forms.MenuItem
        Me.tbbtnExport = New System.Windows.Forms.ToolBarButton
        Me.tbbtnDelete = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep2 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnEdit = New System.Windows.Forms.ToolBarButton
        Me.tbbtnAdd = New System.Windows.Forms.ToolBarButton
        Me.tbbtnFind = New System.Windows.Forms.ToolBarButton
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.tbbtnPrint = New System.Windows.Forms.ToolBarButton
        Me.ToolBar = New System.Windows.Forms.ToolBar
        Me.tbbnTotal = New System.Windows.Forms.ToolBarButton
        Me.tbbtnFinish = New System.Windows.Forms.ToolBarButton
        Me.tbbtnAlterReport = New System.Windows.Forms.ToolBarButton
        Me.tbttnExtract = New System.Windows.Forms.ToolBarButton
        Me.tbbnTongCheck = New System.Windows.Forms.ToolBarButton
        Me.tbbtnHche = New System.Windows.Forms.ToolBarButton
        Me.tbbtnDivide = New System.Windows.Forms.ToolBarButton
        Me.tbbtnAllConvert = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep3 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuit = New System.Windows.Forms.ToolBarButton
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbbtnQuery
        '
        Me.tbbtnQuery.ImageIndex = 1
        Me.tbbtnQuery.Name = "tbbtnQuery"
        Me.tbbtnQuery.Text = "查看"
        Me.tbbtnQuery.ToolTipText = "查看修改"
        '
        'mnuCompile
        '
        Me.mnuCompile.Index = 1
        Me.mnuCompile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAdd, Me.mnuTongCheck, Me.mnuHche, Me.mnuEdit, Me.mnuDelete, Me.mnuAlterReport, Me.mnuExtract, Me.mnuDivide})
        Me.mnuCompile.Text = "编辑(&E)"
        '
        'mnuAdd
        '
        Me.mnuAdd.Index = 0
        Me.mnuAdd.Text = "查验(&C)"
        '
        'mnuTongCheck
        '
        Me.mnuTongCheck.Index = 1
        Me.mnuTongCheck.Text = "同单查验(&T)"
        '
        'mnuHche
        '
        Me.mnuHche.Index = 2
        Me.mnuHche.Text = "火车(&H)"
        '
        'mnuEdit
        '
        Me.mnuEdit.Index = 3
        Me.mnuEdit.Text = "查找(&S)"
        '
        'mnuDelete
        '
        Me.mnuDelete.Index = 4
        Me.mnuDelete.Text = "删除(&D)"
        Me.mnuDelete.Visible = False
        '
        'mnuAlterReport
        '
        Me.mnuAlterReport.Index = 5
        Me.mnuAlterReport.Text = "改单报文"
        '
        'mnuExtract
        '
        Me.mnuExtract.Index = 6
        Me.mnuExtract.Text = "导箱确认"
        '
        'mnuDivide
        '
        Me.mnuDivide.Index = 7
        Me.mnuDivide.Text = "分单合单(S)"
        '
        'tbbtnSep1
        '
        Me.tbbtnSep1.Name = "tbbtnSep1"
        Me.tbbtnSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuCompile, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFind, Me.mnuQuery, Me.mnuTotal, Me.mnuFinish, Me.mnuSep1, Me.mnuPrint, Me.mnuExport, Me.mnuSep2, Me.mnuQuit})
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
        Me.mnuQuery.Text = "查看(&Q)"
        '
        'mnuTotal
        '
        Me.mnuTotal.Index = 2
        Me.mnuTotal.Text = "统计(&T)"
        '
        'mnuFinish
        '
        Me.mnuFinish.Index = 3
        Me.mnuFinish.Text = "完成(&C)"
        '
        'mnuSep1
        '
        Me.mnuSep1.Index = 4
        Me.mnuSep1.Text = "-"
        '
        'mnuPrint
        '
        Me.mnuPrint.Index = 5
        Me.mnuPrint.Text = "打印(&P)..."
        Me.mnuPrint.Visible = False
        '
        'mnuExport
        '
        Me.mnuExport.Index = 6
        Me.mnuExport.Text = "导出(&E)"
        Me.mnuExport.Visible = False
        '
        'mnuSep2
        '
        Me.mnuSep2.Index = 7
        Me.mnuSep2.Text = "-"
        '
        'mnuQuit
        '
        Me.mnuQuit.Index = 8
        Me.mnuQuit.Text = "退出(&X)"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.Text = "帮助(&H)"
        '
        'tbbtnExport
        '
        Me.tbbtnExport.ImageIndex = 6
        Me.tbbtnExport.Name = "tbbtnExport"
        Me.tbbtnExport.Text = "导出"
        Me.tbbtnExport.ToolTipText = "导出Excel"
        Me.tbbtnExport.Visible = False
        '
        'tbbtnDelete
        '
        Me.tbbtnDelete.ImageIndex = 4
        Me.tbbtnDelete.Name = "tbbtnDelete"
        Me.tbbtnDelete.Text = "删除"
        Me.tbbtnDelete.ToolTipText = "删除"
        Me.tbbtnDelete.Visible = False
        '
        'tbbtnSep2
        '
        Me.tbbtnSep2.Name = "tbbtnSep2"
        Me.tbbtnSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnEdit
        '
        Me.tbbtnEdit.ImageIndex = 19
        Me.tbbtnEdit.Name = "tbbtnEdit"
        Me.tbbtnEdit.Text = "查找"
        Me.tbbtnEdit.ToolTipText = "查找"
        '
        'tbbtnAdd
        '
        Me.tbbtnAdd.ImageIndex = 2
        Me.tbbtnAdd.Name = "tbbtnAdd"
        Me.tbbtnAdd.Text = "查验"
        Me.tbbtnAdd.ToolTipText = "查验 "
        '
        'tbbtnFind
        '
        Me.tbbtnFind.ImageIndex = 0
        Me.tbbtnFind.Name = "tbbtnFind"
        Me.tbbtnFind.Text = "检索"
        Me.tbbtnFind.ToolTipText = "检索"
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("C1DBG.Images"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 42)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.PageSettings = CType(resources.GetObject("C1DBG.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBG.RowHeight = 16
        Me.C1DBG.Size = New System.Drawing.Size(920, 335)
        Me.C1DBG.TabIndex = 15
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = resources.GetString("C1DBG.PropBag")
        '
        'tbbtnPrint
        '
        Me.tbbtnPrint.ImageIndex = 5
        Me.tbbtnPrint.Name = "tbbtnPrint"
        Me.tbbtnPrint.Text = "打印"
        Me.tbbtnPrint.ToolTipText = "打印"
        Me.tbbtnPrint.Visible = False
        '
        'ToolBar
        '
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnFind, Me.tbbtnQuery, Me.tbbnTotal, Me.tbbtnFinish, Me.tbbtnSep1, Me.tbbtnEdit, Me.tbbtnAlterReport, Me.tbttnExtract, Me.tbbtnAdd, Me.tbbnTongCheck, Me.tbbtnHche, Me.tbbtnDelete, Me.tbbtnDivide, Me.tbbtnAllConvert, Me.tbbtnSep2, Me.tbbtnPrint, Me.tbbtnExport, Me.tbbtnSep3, Me.tbbtnQuit})
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(920, 42)
        Me.ToolBar.TabIndex = 14
        '
        'tbbnTotal
        '
        Me.tbbnTotal.ImageIndex = 40
        Me.tbbnTotal.Name = "tbbnTotal"
        Me.tbbnTotal.Text = "统计"
        Me.tbbnTotal.ToolTipText = "箱数统计"
        '
        'tbbtnFinish
        '
        Me.tbbtnFinish.ImageIndex = 30
        Me.tbbtnFinish.Name = "tbbtnFinish"
        Me.tbbtnFinish.Text = "完成"
        Me.tbbtnFinish.ToolTipText = "完成"
        '
        'tbbtnAlterReport
        '
        Me.tbbtnAlterReport.ImageIndex = 28
        Me.tbbtnAlterReport.Name = "tbbtnAlterReport"
        Me.tbbtnAlterReport.Text = "改单报文"
        Me.tbbtnAlterReport.ToolTipText = "改单生成报文"
        '
        'tbttnExtract
        '
        Me.tbttnExtract.ImageIndex = 25
        Me.tbttnExtract.Name = "tbttnExtract"
        Me.tbttnExtract.Text = "导箱确认"
        '
        'tbbnTongCheck
        '
        Me.tbbnTongCheck.ImageIndex = 39
        Me.tbbnTongCheck.Name = "tbbnTongCheck"
        Me.tbbnTongCheck.Text = "同单查验"
        Me.tbbnTongCheck.ToolTipText = "同提单查验"
        '
        'tbbtnHche
        '
        Me.tbbtnHche.ImageIndex = 23
        Me.tbbtnHche.Name = "tbbtnHche"
        Me.tbbtnHche.Text = "火车"
        Me.tbbtnHche.ToolTipText = "火车大列处理"
        '
        'tbbtnDivide
        '
        Me.tbbtnDivide.ImageIndex = 11
        Me.tbbtnDivide.Name = "tbbtnDivide"
        Me.tbbtnDivide.Text = "分单合单"
        Me.tbbtnDivide.ToolTipText = "调整箱信息"
        '
        'tbbtnAllConvert
        '
        Me.tbbtnAllConvert.ImageIndex = 16
        Me.tbbtnAllConvert.Name = "tbbtnAllConvert"
        Me.tbbtnAllConvert.Text = "换船"
        Me.tbbtnAllConvert.ToolTipText = "整船船次更改"
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
        Me.ImageList.Images.SetKeyName(8, "314966.gif")
        Me.ImageList.Images.SetKeyName(9, "200641474216228.png")
        Me.ImageList.Images.SetKeyName(10, "11513160465535804.jpg")
        Me.ImageList.Images.SetKeyName(11, "AUTHOR.ICO")
        Me.ImageList.Images.SetKeyName(12, "BOOK1.ICO")
        Me.ImageList.Images.SetKeyName(13, "BOOK06.ICO")
        Me.ImageList.Images.SetKeyName(14, "character3.ico")
        Me.ImageList.Images.SetKeyName(15, "cy_rbemp.ico")
        Me.ImageList.Images.SetKeyName(16, "cy_rbful.ico")
        Me.ImageList.Images.SetKeyName(17, "EMAIL11.png")
        Me.ImageList.Images.SetKeyName(18, "EXIT1.ICO")
        Me.ImageList.Images.SetKeyName(19, "EYE1.ICO")
        Me.ImageList.Images.SetKeyName(20, "FONT02.ICO")
        Me.ImageList.Images.SetKeyName(21, "FORMATED.ICO")
        Me.ImageList.Images.SetKeyName(22, "GLOBE1.ICO")
        Me.ImageList.Images.SetKeyName(23, "hct.jpg")
        Me.ImageList.Images.SetKeyName(24, "hg6.ICO")
        Me.ImageList.Images.SetKeyName(25, "kq1.ico")
        Me.ImageList.Images.SetKeyName(26, "MACOS~1.ICO")
        Me.ImageList.Images.SetKeyName(27, "NOTEPA~1.ICO")
        Me.ImageList.Images.SetKeyName(28, "NOTEPA~2.ICO")
        Me.ImageList.Images.SetKeyName(29, "pic_ywzx.gif")
        Me.ImageList.Images.SetKeyName(30, "RECYCLE.ICO")
        Me.ImageList.Images.SetKeyName(31, "RECYCLIN.ICO")
        Me.ImageList.Images.SetKeyName(32, "SETTINGS.ICO")
        Me.ImageList.Images.SetKeyName(33, "VIEWER1.ICO")
        Me.ImageList.Images.SetKeyName(34, "VIEWER2.ICO")
        Me.ImageList.Images.SetKeyName(35, "VIEWER3.ICO")
        Me.ImageList.Images.SetKeyName(36, "VIEWER4.ICO")
        Me.ImageList.Images.SetKeyName(37, "Windows.ico")
        Me.ImageList.Images.SetKeyName(38, "winxfile.ico")
        Me.ImageList.Images.SetKeyName(39, "WORD~216.ICO")
        Me.ImageList.Images.SetKeyName(40, "WRITE3.ICO")
        '
        'FrmConLoadCheck
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.ClientSize = New System.Drawing.Size(920, 377)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.ToolBar)
        Me.Font = New System.Drawing.Font("新宋体", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Menu = Me.MainMenu
        Me.Name = "FrmConLoadCheck"
        Me.Text = "装拆箱检查桥查验"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim ds As New DataSet()
    Dim SqlStr As String  '条件语句
    Dim SelectStr As String
    Dim DynaStr As String '可变的条件设计
    Dim FirmStr As String '不变的条件设计
    Dim ColNum As Integer '不显示的列数
    Const strPrefix As String = " Top 200 " 'Sql语句可选前缀
    Public Shared strShip, strVoyage, strBillNo, strCodeYard As String

    Dim iClickCount As Integer

    Private Sub FrmConLoadCheck_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call preview("WL5_8") '*****************权限设计 
        Me.Text = Me.Text & "_" & G_DeptName
        'FirmStr = " and DeptCode like '" & G_DeptCode & "%' and InOutPort = '1' and AccountNo is null  Order by ID DESC"  '" Use_Comp Like '" & Trim(G_DeptCode) & "%' and Hide_Company Like '" & Trim(G_Company) & "%' order by ID DESC" 
        FirmStr = " (DeptCode like '26%' or CodeYard = '99') and InOutPort = '1' and StateC<= '1'  Order by ID DESC"  '要改部门限制的
        SelectStr = strPrefix
        DynaStr = " InputTime>DateAdd(mm,-2,Getdate()) "
        SqlStr = DynaStr & " and " & FirmStr
        Call myDataGrid(SelectStr, SqlStr)
        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色

        Me.tbbtnDelete.Visible = False
        Me.mnuDelete.Visible = False
        Me.mnuHche.Visible = False
        Me.tbbtnHche.Visible = False
        Me.C1DBG.Splits(0).ColumnCaptionHeight = 20
        Me.C1DBG.Splits(0).ColumnFooterHeight = 20
        Me.C1DBG.RowHeight = 18
        Me.C1DBG.FetchRowStyles = True
    End Sub

    Private Sub myDataGrid(ByVal SelStr As String, ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            '不显示的列名在最前面
            strsql = "select " & SelStr & " * from View_ConLoadTally where " & Sql '

            Me.C1DBG.DataSource = Getdata(strsql, ds)
            ColNum = 16 '不显示的列数
            Table_Name = "View_ConLoadTally" '操作的数据库表名 '

            For i = 0 To ColNum - 1 '设定不显示的列数
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Me.C1DBG.Columns("InputTime").NumberFormat = "yy-MM-dd HH:mm"
            Me.C1DBG.Columns("CheckTime").NumberFormat = "yy-MM-dd HH:mm"
            Me.C1DBG.Columns("PrintTime").NumberFormat = "yy-MM-dd HH:mm"
            Me.C1DBG.Columns("ConTime").NumberFormat = "yy-MM-dd HH:mm"

            Call SetColumnCaption()
            Call SetDGWidth3(C1DBG)
            If ds.Tables(0).Rows.Count > 0 Then
                Call SetColumnSum(Sql) '设计合计列
            End If
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
        If Flag = 0 Then    '有条件选择 改变了动态条件 去掉 Top 200
            SelectStr = ""
            DynaStr = Sql_Find
            SqlStr = DynaStr & " and " & FirmStr
            myDataGrid(SelectStr, SqlStr)
        ElseIf Flag = 2 Then    '全选 一次性的 条件不要变
            myDataGrid("", FirmStr)
        End If
    End Sub

    Private Sub mnuQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuery.Click
        If ds.Tables(0).Rows.Count > 0 Then
            Dim FrmCheckEdit As New FrmConLoadCheck_Dealog()
            ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
            strShip = Me.C1DBG.Columns("CHI_VESSEL").Text
            strVoyage = Me.C1DBG.Columns("VOYAGE").Text
            strBillNo = Me.C1DBG.Columns("BLNO").Text
            strCodeYard = Me.C1DBG.Columns("CodeYard").Text
            FrmCheckEdit.strFindConNo = Me.C1DBG.Columns("Container_No").Text
            Dim row As Integer
            row = Me.C1DBG.Row
            FrmCheckEdit.ShowDialog()
            If FrmCheckEdit.EditMark = True Then
                Call myDataGrid(SelectStr, SqlStr)
                Me.C1DBG.Row = row
            End If
        End If

    End Sub

    Private Sub mnuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdd.Click
        Dim FrmAdd As New FrmConLoadCheck_Deal()     '***********要修改
        'ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
        'strShip = Me.C1DBG.Columns("CHI_VESSEL").Text
        'strVoyage = Me.C1DBG.Columns("VOYAGE").Text
        'strCodeYard = Me.C1DBG.Columns("CodeYard").Text

        FrmAdd.ShowDialog()
        If FrmAdd.blSave Then
            Call myDataGrid(strPrefix, FirmStr)
        End If
    End Sub

    '改成查找了
    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        Dim FrmSelect As New FrmContainerOutPort_Select
        FrmSelect.ShowDialog()
        If FrmSelect.flag = True Then
            SelectStr = ""
            DynaStr = FrmSelect.strSelect
            SqlStr = DynaStr & " and " & FirmStr
            Call myDataGrid(SelectStr, SqlStr)
            Call mnuQuery_Click(sender, e)
        Else
            SelectStr = strPrefix
            DynaStr = ""
            SqlStr = FirmStr
            Call myDataGrid(SelectStr, SqlStr)
        End If
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        'If ds.Tables(0).Rows.Count > 0 Then
        '    Dim FrmDelete As New FrmConLoadTally_Delete()    '***********要修改

        '    ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
        '    FrmDelete.ShowDialog()
        '    Try
        '        Call myDataGrid(SelectStr, SqlStr)
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
        'End If
    End Sub

    Private Sub mnuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrint.Click
        'Call PrintExcel()
        If ds.Tables(0).Rows.Count > 0 Then
            Dim FrmQuery As New FrmConLoadTally_Query      '***********要修改
            ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
            FrmQuery.btQuit.Text = "确定"
            FrmQuery.ShowDialog()
            Call GetConLoadContainerReport()
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

    Private Sub mnuExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExport.Click
        'Call ExportExcel()
        If ds.Tables(0).Rows.Count > 0 Then
            Dim FrmQuery As New FrmConLoadTally_Query      '***********要修改
            ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
            FrmQuery.btQuit.Text = "确定"
            FrmQuery.ShowDialog()
            Call GetConLoadContainerReport()
        End If
    End Sub

    Private Sub GetConLoadContainerReport()
        Dim sqlSubTable As String
        Dim dvSubTable As New DataView
        sqlSubTable = "SELECT CON_LOAD_TALLY_LIST_ID, CON_LOAD_TALLY_ID, CONTAINER_NO, NEWSEALNO, SIZE_CON, CONTAINER_TYPE, CON_LOAD_TALLY_LIST.PACK_CHA AS Pack_Code, CODE_PACK.PACK_CHA, CODE_PACK.PACK_ENG, AMOUNT, WEIGHT, VOLUME, DAMAGED_AMOUNT, DAMAGED_PACK FROM CON_LOAD_TALLY_LIST LEFT OUTER JOIN CODE_PACK ON CON_LOAD_TALLY_LIST.PACK_CHA = CODE_PACK.CODE_PACK where CON_LOAD_TALLY_ID =" & Me.C1DBG.Columns.Item("ID").Text & ""
        Try
            dvSubTable = Filldata(sqlSubTable)

            Dim PathStr As String
            Dim FilePath As String
            Dim Row As Integer
            Dim Col As Integer
            PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
            PathStr = substr(PathStr)

            FilePath = PathStr + "ReportCopy.xls"
            FileCopy(PathStr & "Report_Pan.xls", FilePath)

            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
            xlBook = CType(xlApp.Workbooks.Open("" & FilePath & ""), Excel.Workbook)
            xlSheet = CType(xlBook.Worksheets(3), Excel.Worksheet)
            xlSheet.Select(3)
            xlApp.DisplayAlerts = False
            xlSheet.Application.Visible = True

            'xlSheet.Cells(3, 9) = Me.C1DBG.Columns("NAME_TALLY_TYPE")
            'xlSheet.Cells(4, 9) = Me.C1DBG.Columns("NO")

            'xlSheet.Cells(6, 3) = Me.C1DBG.Columns("BLNO")
            'xlSheet.Cells(8, 3) = Me.C1DBG.Columns("MARK")
            'xlSheet.Cells(8, 7) = Me.C1DBG.Columns("GOODS")
            'xlSheet.Cells(9, 3) = Me.C1DBG.Columns("AMOUNT")
            'xlSheet.Cells(9, 7) = Me.C1DBG.Columns("TOTAL_WEIGHT")
            'xlSheet.Cells(10, 3) = Me.C1DBG.Columns("DESCR")
            'xlSheet.Cells(10, 7) = Me.C1DBG.Columns("STATE")

            xlSheet.Cells(11, 2) = Me.C1DBG.Columns("CHI_VESSEL")
            xlSheet.Cells(11, 6) = Me.C1DBG.Columns("VOYAGE")
            xlSheet.Cells(11, 12) = Me.C1DBG.Columns("WORK_PLACE")

            Dim TimeBegin, TimeEnd As Date
            TimeBegin = Me.C1DBG.Columns("TIME_FROM").Text
            TimeEnd = Me.C1DBG.Columns("TIME_TO").Text
            xlSheet.Cells(12, 4) = TimeBegin.Year & " 年 "
            xlSheet.Cells(12, 5) = TimeBegin.Month
            xlSheet.Cells(12, 7) = TimeBegin.Day
            xlSheet.Cells(12, 10) = TimeBegin.Hour
            xlSheet.Cells(13, 4) = TimeEnd.Year & " 年 "
            xlSheet.Cells(13, 5) = TimeEnd.Month
            xlSheet.Cells(13, 7) = TimeEnd.Day
            xlSheet.Cells(13, 10) = TimeEnd.Hour

            xlSheet.Cells(38, 3) = Me.C1DBG.Columns("TALLY_CLERK")
            xlSheet.Cells(38, 8) = Me.C1DBG.Columns("CROSS_PERSON")
            'Dim iCount20, iCount40, iCount45, iCount58, iCountOther As Integer
            Dim i As Short
            For i = 0 To dvSubTable.Count - 1
                xlSheet.Cells(16 + i, 1) = dvSubTable.Item(i)("CONTAINER_NO")
                xlSheet.Cells(16 + i, 2) = dvSubTable.Item(i)("SIZE_CON")
                xlSheet.Cells(16 + i, 3) = dvSubTable.Item(i)("NEWSEALNO")
                'xlSheet.Cells(15 + i, 5) = dvSubTable.Item(i)("CONTAINER_TYPE")
                xlSheet.Cells(16 + i, 7) = dvSubTable.Item(i)("AMOUNT")
                xlSheet.Cells(16 + i, 12) = dvSubTable.Item(i)("AMOUNT")
                'xlSheet.Cells(13 + i, 7) = dvSubTable.Item(i)("PACK_ENG")
                xlSheet.Cells(16 + i, 6) = dvSubTable.Item(i)("PACK_CHA")
                'xlSheet.Cells(13 + i, 9) = dvSubTable.Item(i)("WEIGHT")
                'xlSheet.Cells(13 + i, 10) = dvSubTable.Item(i)("VOLUME")
                If Not IsDBNull(dvSubTable.Item(i)("DAMAGED_AMOUNT")) Then
                    xlSheet.Cells(16 + i, 13) = dvSubTable.Item(i)("DAMAGED_AMOUNT") & "件 " & dvSubTable.Item(i)("DAMAGED_PACK")
                Else
                    xlSheet.Cells(16 + i, 13) = dvSubTable.Item(i)("DAMAGED_PACK")
                End If

                xlSheet.Cells(16 + i, 4) = Me.C1DBG.Columns("BLNO")
                xlSheet.Cells(16 + i, 5) = Me.C1DBG.Columns("MARK")

                'If Not IsDBNull(dvSubTable.Item(i)("SIZE_CON")) Then
                '    Select Case dvSubTable.Item(i)("SIZE_CON")
                '        Case "20"
                '            iCount20 += 1
                '        Case "40"
                '            iCount40 += 1
                '        Case "45"
                '            iCount45 += 1
                '        Case "58"
                '            iCount58 += 1
                '        Case Else
                '            iCountOther += 1
                '    End Select
                'End If
            Next
            'Dim strTotal As String
            'If iCount20 <> 0 Then
            '    strTotal = " 20 X " & iCount20
            'End If
            'If iCount40 <> 0 Then
            '    strTotal = strTotal & " , 40 X " & iCount40
            'End If
            'If iCount45 <> 0 Then
            '    strTotal = strTotal & " , 45 X " & iCount45
            'End If
            'If iCount58 <> 0 Then
            '    strTotal = strTotal & " , 58 X " & iCount58
            'End If
            'If iCountOther <> 0 Then
            '    strTotal = strTotal & " , 其它 X " & iCountOther
            'End If
            'xlSheet.Cells(23, 3) = strTotal
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            xlApp.Quit()
            SendKeys.Send("N")
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
        Select Case e.Button.Text
            Case "检索"
                mnuFind_Click(sender, e)
            Case "查看"
                Call mnuQuery_Click(sender, e)
            Case "统计"
                Call mnuTotal_Click(sender, e)
            Case "查验"
                Call mnuAdd_Click(sender, e)
            Case "查找"
                Call mnuEdit_Click(sender, e)
            Case "删除"
                Call mnuDelete_Click(sender, e)
            Case "打印"
                Call mnuPrint_Click(sender, e)
            Case "导出"
                Call mnuExport_Click(sender, e)
            Case "退出"
                Call mnuQuit_Click(sender, e)
            Case "完成"
                Call mnuFinish_Click(sender, e)
            Case "返回"
                Call mnuFinish_Click(sender, e)
            Case "火车"
                Call mnuHche_Click(sender, e)
            Case "同单查验"
                Call mnuTongCheck_Click(sender, e)
            Case "改单报文"
                Call mnuAlterReport_Click(sender, e)
            Case "导箱确认"
                Call mnuExtract_Click(sender, e)
            Case "分单合单"
                Call mnuDivide_Click(sender, e)
            Case "换船"
                Call FrmConLoadTally.mnuAllConvert_Click(sender, e)
        End Select
    End Sub

    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        strCodeYard = Nothing
        TBar = 1
        Mnu = 1
    End Sub

    Private Sub C1DBG_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1DBG.DoubleClick
        Call mnuQuery_Click(sender, e)
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

    Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        If Me.C1DBG.Columns("checked").CellValue(e.Row) = "1" Then
            'e.CellStyle.BackColor = System.Drawing.Color.Cyan
            e.CellStyle.ForeColor = System.Drawing.Color.DarkGreen
            e.CellStyle.Borders.BorderType = C1.Win.C1TrueDBGrid.BorderTypeEnum.Flat
            'e.CellStyle.Borders.Color = System.Drawing.Color.Cyan
            'e.CellStyle.Borders.Bottom = 1
            'e.CellStyle.Borders.Right = 1
            'e.CellStyle.Borders.Left = 1
            'e.CellStyle.Borders.Top = 1
            e.CellStyle.Font = New Font("DotumChe", 13, FontStyle.Bold, GraphicsUnit.Pixel)
        End If
        If Me.C1DBG.Columns("TradeMark").CellValue(e.Row) = "1" Then
            e.CellStyle.Font = New Font("新宋体", 13, FontStyle.Underline, GraphicsUnit.Pixel)
        End If
        Select Case Me.C1DBG.Columns("StateC").CellText(e.Row)
            Case "1", "2"

            Case "3"
                e.CellStyle.BackColor = System.Drawing.Color.Wheat
            Case "4"
                e.CellStyle.BackColor = System.Drawing.Color.Lime
            Case "0"
                e.CellStyle.BackColor = System.Drawing.Color.Olive
        End Select
    End Sub

    Private Sub mnuTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTotal.Click
        If ds.Tables(0).Rows.Count > 0 Then
            strCodeYard = Me.C1DBG.Columns("CodeYard").Text
            'Dim FrmTotal As New FrmConLoadCheck_Total()
            Dim FrmTotal As New FrmConLoadTallyNew_Total
            FrmTotal.ShowDialog()
        End If
    End Sub

    Private Sub mnuFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFinish.Click
        iClickCount += 1
        If iClickCount Mod 2 = 1 Then
            FirmStr = " (DeptCode like '26%' or CodeYard = '99') and InOutPort = '1' and StateC >='2' Order by ID DESC"
            Me.mnuFinish.Text = "返回(&R)"
            Me.tbbtnFinish.Text = "返回"
            Me.tbbtnFinish.ToolTipText = "返回"
        Else
            FirmStr = " (DeptCode like '26%' or CodeYard = '99') and InOutPort = '1' and StateC <='1' Order by ID DESC"
            Me.mnuFinish.Text = "完成(&C)"
            Me.tbbtnFinish.Text = "完成"
            Me.tbbtnFinish.ToolTipText = "完成"
        End If
        SelectStr = strPrefix
        DynaStr = " InputTime>DateAdd(mm,-2,Getdate()) "
        SqlStr = DynaStr & " and " & FirmStr
        Call myDataGrid(SelectStr, SqlStr)
    End Sub

    Private Sub mnuHche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHche.Click
        Dim FrmHche As New FrmConLoadTally_Train
        FrmHche.btnCallPrint.Visible = False
        FrmHche.ShowDialog()
        If FrmHche.blSave Then
            Call myDataGrid(SelectStr, SqlStr)
        End If
    End Sub

    Private Sub mnuTongCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTongCheck.Click
        Dim FrmTong As New FrmConLoadCheck_TongDeal
        FrmTong.ShowDialog()
        If FrmTong.blSave Then
            Call myDataGrid(strPrefix, FirmStr)
        End If
    End Sub

    Private Sub mnuAlterReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAlterReport.Click
        Dim FrmExtract As New FrmConLoadTally_Extract
        FrmExtract.blEditImport = 1
        FrmExtract.ShowDialog()
        If FrmExtract.blSave Then
            Call myDataGrid(SelectStr, SqlStr)
        End If
    End Sub

    Private Sub mnuExtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExtract.Click
        Dim FrmExtract As New FrmConLoadTally_Extract
        FrmExtract.blEditImport = 2
        FrmExtract.ShowDialog()
        If FrmExtract.blSave Then
            Call myDataGrid(strPrefix, FirmStr)
        End If
    End Sub

    Private Sub mnuDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDivide.Click
        Dim FrmDeal As New FrmConLoadTally_DivideUnite
        FrmDeal.btnCallPrint.Visible = False
        FrmDeal.ShowDialog()
        If FrmDeal.blSave Then
            Call myDataGrid(SelectStr, SqlStr)
        End If
    End Sub
End Class
