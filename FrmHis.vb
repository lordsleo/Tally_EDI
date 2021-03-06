Imports TALLY.DBControl
Public Class FrmHis
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
    Friend WithEvents tbbtnQuit As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnFind As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnDelete As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnAdd As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnEdit As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuSep1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrint As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExport As System.Windows.Forms.MenuItem
    Friend WithEvents mnuQuery As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnPrint As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFind As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep2 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuQuit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAdd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCompile As System.Windows.Forms.MenuItem
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents tbbtnExport As System.Windows.Forms.ToolBarButton
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    Friend WithEvents tbbtnQuery As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents mnuSelect As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnSelect As System.Windows.Forms.ToolBarButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmHis))
        Me.tbbtnQuit = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep2 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnFind = New System.Windows.Forms.ToolBarButton
        Me.tbbtnDelete = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep1 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnAdd = New System.Windows.Forms.ToolBarButton
        Me.tbbtnEdit = New System.Windows.Forms.ToolBarButton
        Me.mnuSep1 = New System.Windows.Forms.MenuItem
        Me.mnuPrint = New System.Windows.Forms.MenuItem
        Me.mnuExport = New System.Windows.Forms.MenuItem
        Me.mnuQuery = New System.Windows.Forms.MenuItem
        Me.tbbtnPrint = New System.Windows.Forms.ToolBarButton
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuFind = New System.Windows.Forms.MenuItem
        Me.mnuSelect = New System.Windows.Forms.MenuItem
        Me.mnuSep2 = New System.Windows.Forms.MenuItem
        Me.mnuQuit = New System.Windows.Forms.MenuItem
        Me.mnuEdit = New System.Windows.Forms.MenuItem
        Me.mnuDelete = New System.Windows.Forms.MenuItem
        Me.mnuHelp = New System.Windows.Forms.MenuItem
        Me.mnuAdd = New System.Windows.Forms.MenuItem
        Me.mnuCompile = New System.Windows.Forms.MenuItem
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.tbbtnExport = New System.Windows.Forms.ToolBarButton
        Me.MainMenu = New System.Windows.Forms.MainMenu
        Me.ToolBar = New System.Windows.Forms.ToolBar
        Me.tbbtnQuery = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSelect = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep3 = New System.Windows.Forms.ToolBarButton
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbbtnQuit
        '
        Me.tbbtnQuit.ImageIndex = 7
        Me.tbbtnQuit.Text = "退出"
        Me.tbbtnQuit.ToolTipText = "退出"
        '
        'tbbtnSep2
        '
        Me.tbbtnSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnFind
        '
        Me.tbbtnFind.ImageIndex = 0
        Me.tbbtnFind.Text = "检索"
        Me.tbbtnFind.ToolTipText = "检索"
        '
        'tbbtnDelete
        '
        Me.tbbtnDelete.ImageIndex = 4
        Me.tbbtnDelete.Text = "删除"
        Me.tbbtnDelete.ToolTipText = "删除"
        Me.tbbtnDelete.Visible = False
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
        Me.tbbtnAdd.Visible = False
        '
        'tbbtnEdit
        '
        Me.tbbtnEdit.ImageIndex = 3
        Me.tbbtnEdit.Text = "编辑"
        Me.tbbtnEdit.ToolTipText = "编辑"
        Me.tbbtnEdit.Visible = False
        '
        'mnuSep1
        '
        Me.mnuSep1.Index = 3
        Me.mnuSep1.Text = "-"
        '
        'mnuPrint
        '
        Me.mnuPrint.Index = 4
        Me.mnuPrint.Text = "打印(&P)..."
        '
        'mnuExport
        '
        Me.mnuExport.Index = 5
        Me.mnuExport.Text = "导出(&E)"
        '
        'mnuQuery
        '
        Me.mnuQuery.Index = 1
        Me.mnuQuery.Text = "查看(&Q)"
        '
        'tbbtnPrint
        '
        Me.tbbtnPrint.ImageIndex = 5
        Me.tbbtnPrint.Text = "打印"
        Me.tbbtnPrint.ToolTipText = "打印"
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFind, Me.mnuQuery, Me.mnuSelect, Me.mnuSep1, Me.mnuPrint, Me.mnuExport, Me.mnuSep2, Me.mnuQuit})
        Me.mnuFile.Text = "文件(&F)"
        '
        'mnuFind
        '
        Me.mnuFind.Index = 0
        Me.mnuFind.Text = "检索(&F)"
        '
        'mnuSelect
        '
        Me.mnuSelect.Index = 2
        Me.mnuSelect.Text = "查找"
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
        'mnuEdit
        '
        Me.mnuEdit.Index = 1
        Me.mnuEdit.Text = "编辑(&E)"
        '
        'mnuDelete
        '
        Me.mnuDelete.Index = 2
        Me.mnuDelete.Text = "删除(&D)"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.Text = "帮助(&H)"
        '
        'mnuAdd
        '
        Me.mnuAdd.Index = 0
        Me.mnuAdd.Text = "增加(&A)"
        '
        'mnuCompile
        '
        Me.mnuCompile.Index = 1
        Me.mnuCompile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAdd, Me.mnuEdit, Me.mnuDelete})
        Me.mnuCompile.Text = "编辑(&E)"
        Me.mnuCompile.Visible = False
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.C1DBG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 41)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.Size = New System.Drawing.Size(664, 365)
        Me.C1DBG.TabIndex = 14
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle12{}OddRow{}RecordSelector{AlignImage:Center;}Style13{}Heading{Wrap:True;Alig" & _
        "nVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style14{}Style15{}Style1{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" AllowRowSizing=""None"" CaptionH" & _
        "eight=""18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""Dotted" & _
        "CellBorder"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1""" & _
        " HorizontalScrollGroup=""1""><Height>361</Height><CaptionStyle parent=""Style2"" me=" & _
        """Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""Eve" & _
        "nRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterSty" & _
        "le parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><Head" & _
        "ingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow""" & _
        " me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle paren" & _
        "t=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style1" & _
        "1"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""S" & _
        "tyle1"" /><ClientRect>0, 0, 660, 361</ClientRect><BorderSide>0</BorderSide><Borde" & _
        "rStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles" & _
        "><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style par" & _
        "ent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style parent" & _
        "=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=" & _
        """Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=" & _
        """Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Head" & _
        "ing"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent" & _
        "=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</h" & _
        "orzSplits><Layout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><Clien" & _
        "tArea>0, 0, 660, 361</ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" />" & _
        "<PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'tbbtnExport
        '
        Me.tbbtnExport.ImageIndex = 6
        Me.tbbtnExport.Text = "导出"
        Me.tbbtnExport.ToolTipText = "导出Excel"
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuCompile, Me.mnuHelp})
        '
        'ToolBar
        '
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnFind, Me.tbbtnQuery, Me.tbbtnSep1, Me.tbbtnSelect, Me.tbbtnAdd, Me.tbbtnEdit, Me.tbbtnDelete, Me.tbbtnSep2, Me.tbbtnPrint, Me.tbbtnExport, Me.tbbtnSep3, Me.tbbtnQuit})
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(664, 41)
        Me.ToolBar.TabIndex = 13
        '
        'tbbtnQuery
        '
        Me.tbbtnQuery.ImageIndex = 1
        Me.tbbtnQuery.Text = "查看"
        Me.tbbtnQuery.ToolTipText = "查看"
        '
        'tbbtnSelect
        '
        Me.tbbtnSelect.Text = "查找"
        '
        'tbbtnSep3
        '
        Me.tbbtnSep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ImageList
        '
        Me.ImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'FrmHis
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(664, 406)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.ToolBar)
        Me.Menu = Me.MainMenu
        Me.Name = "FrmHis"
        Me.Text = "操作日志"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds As New DataSet
    Dim SqlStr As String  '条件语句
    Dim SelectStr As String
    Dim DynaStr As String '可变的条件设计
    Dim FirmStr As String '不变的条件设计
    Dim ColNum As Integer '不显示的列数

    Private Sub preview(ByVal Func As String) '***************权限设计
        Dim sqlstr As String
        Dim Previewdv As DataView
        Dim Previewds As New DataSet
        Dim i As Integer
        sqlstr = " select FUNC_CODE_View,FUNC_CODE_Add,FUNC_CODE_Change,FUNC_CODE_Del from View_UserPreview where PART_ID=" & G_Part_Id & " and FUNC_CODE='" & Upper(Func) & "' "
        Previewdv = Getdata(sqlstr, Previewds)
        If Previewdv.Count > 0 Then
            If Previewdv(i)("FUNC_CODE_View") = 1 Then  '可以查看
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
            Else
                '不可进入
                Me.C1DBG.Visible = False
                Me.ToolBar.Visible = False
                Me.mnuCompile.Visible = False
                Me.mnuFile.Visible = False
            End If
            '不控制权限
        End If
    End Sub

    Private Sub FrmHis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call preview("mnuConLoadOper")
        Me.Text = Me.Text & "_" & G_DeptName
        'FirmStr = " and DEPT_CODE like '" & G_DeptCode & "%' and OperateTable like 'CON_LOAD_TALLY%' Order by ID Desc" '只选装拆箱的记录
        FirmStr = " and DEPT_CODE like '" & G_DeptCode & "%'   Order by ID Desc"
        DynaStr = " 1=1 "
        SelectStr = " Top 200 "
        SqlStr = " (" & DynaStr & ")  " & FirmStr
        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '设计选择纪录底色
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBG.FetchRowStyles = True
        Call myDataGrid(SelectStr, SqlStr)
        
    End Sub

    Private Sub myDataGrid(ByVal SelStr As String, ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            '不显示的列名在最前面
            strsql = "select " & SelStr & " ID,A.Dept_Name,OperateTime,OperateWorker,OperateType,OperateTable,OperateDemo from OperateHistory A left join DepartMent B on A.Dept_Name=B.Dept_Name where " & Sql '******要修改

            Me.C1DBG.DataSource = Getdata(strsql, ds)  ' class dbcontrol getdata fuction
            ColNum = 0 '不显示的列数 '******要修改
            Table_Name = "View_ConLoadTally" '操作的数据库表名 ''******要修改

            For i = 0 To ColNum - 1 '设定不显示的列数
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Translate = True
            'Me.C1DBG.Columns.Item("Logic").ValueItems.Validate = True
            'Me.C1DBG.Splits(0).DisplayColumns.Item("Logic").Visible = False

            Me.C1DBG.Columns.Item("OperateTime").NumberFormat = "yy-MM-dd HH:mm"
            Me.C1DBG.Columns("Dept_Name").Caption = "操作部门"
            Me.C1DBG.Columns("OperateTime").Caption = "操作时间"
            Me.C1DBG.Columns("OperateWorker").Caption = "操作员"
            Me.C1DBG.Columns("OperateType").Caption = "操作"
            Me.C1DBG.Columns("OperateDemo").Caption = "操作前数据"
            Me.C1DBG.Columns("OperateTable").Caption = "操作表名"

            SetColumnWidth() '设计列宽度
            Me.C1DBG.Refresh()
            Me.C1DBG.Columns.Item("Dept_Name").FooterText = "合计" & ds.Tables(0).Rows.Count & "条"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnWidth()
        Try
            Dim j As Integer
            For j = 0 To Me.C1DBG.Columns.Count - 1
                Me.C1DBG.Splits(0).DisplayColumns.Item(j).AutoSize()
                Me.C1DBG.Splits(0).DisplayColumns.Item(j).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
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
        Dim FrmFind As New FrmFind
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
        Call ExportExcel()
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

    Private Sub ToolBar_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar.ButtonClick
        Select Case e.Button.Text
            Case "检索"
                mnuFind_Click(sender, e)
            Case "查看"
                mnuQuery_Click(sender, e)

            Case "打印"
                Call mnuPrint_Click(sender, e)
            Case "导出"
                Call mnuExport_Click(sender, e)
            Case "退出"
                Call mnuQuit_Click(sender, e)

            Case "查找"
                mnuSelect_Click(sender, e)
        End Select
    End Sub

    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
        Me.Close()
    End Sub

    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        TBar = 1
        Mnu = 1
        fm.Close()
    End Sub
    Dim fm As New FrmHis_Query

    Private Sub mnuQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuery.Click
        If ds.Tables(0).Rows.Count > 0 Then
            fm.txtDept.Text = Me.C1DBG.Columns("Dept_Name").Text
            fm.txtTime.Text = Me.C1DBG.Columns("OperateTime").Text
            fm.txtWorker.Text = Me.C1DBG.Columns("OperateWorker").Text
            fm.txtOper.Text = Me.C1DBG.Columns("OperateType").Text
            fm.txtTable.Text = Me.C1DBG.Columns("OperateTable").Text
            fm.txtOldData.Text = Me.C1DBG.Columns("OperateDemo").Text
            fm.txtNowData.Clear()
            Try
                '查找当前数据
                If Not (fm.txtOper.Text Like "*删除*") OrElse fm.txtOper.Text Like "*修改*" Then
                    Dim strTemp As String
                    strTemp = fm.txtOldData.Text
                    Dim strDataID As String
                    strDataID = strTemp.Substring(0, strTemp.IndexOf(","))
                    Dim sqlGetNowData As String
                    Dim dvGetNowData As DataView
                    sqlGetNowData = "select * from " & fm.txtTable.Text & " where " & fm.txtTable.Text & "_ID" & "= " & strDataID
                    dvGetNowData = Filldata(sqlGetNowData)
                    If dvGetNowData.Count > 0 Then  '找到当前数据 串接
                        strTemp = ""
                        Dim i As Integer
                        For i = 0 To dvGetNowData.Table.Columns.Count - 1
                            strTemp += IIf(IsDBNull(dvGetNowData(0)(i)), "", dvGetNowData(0)(i)) & ","
                        Next
                        fm.txtNowData.Text = strTemp
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            fm.Show()
            fm.Focus()

        End If
    End Sub

    Private Sub C1DBG_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.DoubleClick
        mnuQuery_Click(sender, e)
    End Sub

    Private Sub mnuSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSelect.Click
        Dim FrmSelect As New FrmHis_Select
        FrmSelect.ShowDialog()

        If FrmSelect.flag = True Then
            If FrmSelect.strSelect.Length <= 6 Then
                Call myDataGrid(SelectStr, " (" & FrmSelect.strSelect & ")  " & FirmStr)   '可能要修改
            Else
                Call myDataGrid("", " (" & FrmSelect.strSelect & ")  " & FirmStr)   '可能要修改
            End If
            SqlStr = " (" & FrmSelect.strSelect & ")  " & FirmStr
            Call mnuQuery_Click(sender, e)
        End If
    End Sub
End Class
