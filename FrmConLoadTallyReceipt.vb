Imports TALLY.DBControl
Public Class FrmConLoadTallyReceipt
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim SqlStr As String  '�������
    Dim SelectStr As String '��̬ǰ׺
    Dim DynaStr As String '�ɱ���������
    Dim FirmStr As String '������������
    Dim ColNum As Integer '����ʾ������
    Const strPrefix As String = " Top 200 " 'Sql����ѡǰ׺

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
    Friend WithEvents mnuDelete As System.Windows.Forms.MenuItem
    Friend WithEvents mnuQuit As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnEdit As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuSep2 As System.Windows.Forms.MenuItem
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents tbbtnSep2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnFind As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuCompile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAdd As System.Windows.Forms.MenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFind As System.Windows.Forms.MenuItem
    Friend WithEvents mnuQuery As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSep1 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPrint As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExport As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnQuery As System.Windows.Forms.ToolBarButton
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents tbbtnDelete As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnExport As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnAdd As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnQuit As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnPrint As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBar As System.Windows.Forms.ToolBar
    Friend WithEvents mnuSelect As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnSelect As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnDivide As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuDivide As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConLoadTallyReceipt))
        Me.mnuDelete = New System.Windows.Forms.MenuItem
        Me.mnuQuit = New System.Windows.Forms.MenuItem
        Me.tbbtnEdit = New System.Windows.Forms.ToolBarButton
        Me.mnuSep2 = New System.Windows.Forms.MenuItem
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.tbbtnSep2 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnFind = New System.Windows.Forms.ToolBarButton
        Me.mnuCompile = New System.Windows.Forms.MenuItem
        Me.mnuAdd = New System.Windows.Forms.MenuItem
        Me.mnuEdit = New System.Windows.Forms.MenuItem
        Me.mnuDivide = New System.Windows.Forms.MenuItem
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuFind = New System.Windows.Forms.MenuItem
        Me.mnuQuery = New System.Windows.Forms.MenuItem
        Me.mnuSelect = New System.Windows.Forms.MenuItem
        Me.mnuSep1 = New System.Windows.Forms.MenuItem
        Me.mnuPrint = New System.Windows.Forms.MenuItem
        Me.mnuExport = New System.Windows.Forms.MenuItem
        Me.mnuHelp = New System.Windows.Forms.MenuItem
        Me.tbbtnQuery = New System.Windows.Forms.ToolBarButton
        Me.MainMenu = New System.Windows.Forms.MainMenu
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.tbbtnDelete = New System.Windows.Forms.ToolBarButton
        Me.tbbtnExport = New System.Windows.Forms.ToolBarButton
        Me.tbbtnAdd = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuit = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep3 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep1 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnPrint = New System.Windows.Forms.ToolBarButton
        Me.ToolBar = New System.Windows.Forms.ToolBar
        Me.tbbtnSelect = New System.Windows.Forms.ToolBarButton
        Me.tbbtnDivide = New System.Windows.Forms.ToolBarButton
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuDelete
        '
        Me.mnuDelete.Index = 2
        Me.mnuDelete.Text = "ɾ��(&D)"
        '
        'mnuQuit
        '
        Me.mnuQuit.Index = 7
        Me.mnuQuit.Text = "�˳�(&X)"
        '
        'tbbtnEdit
        '
        Me.tbbtnEdit.ImageIndex = 3
        Me.tbbtnEdit.Text = "�༭"
        Me.tbbtnEdit.ToolTipText = "�༭"
        '
        'mnuSep2
        '
        Me.mnuSep2.Index = 6
        Me.mnuSep2.Text = "-"
        '
        'ImageList
        '
        Me.ImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'tbbtnSep2
        '
        Me.tbbtnSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnFind
        '
        Me.tbbtnFind.ImageIndex = 0
        Me.tbbtnFind.Text = "����"
        Me.tbbtnFind.ToolTipText = "����"
        '
        'mnuCompile
        '
        Me.mnuCompile.Index = 1
        Me.mnuCompile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAdd, Me.mnuEdit, Me.mnuDelete, Me.mnuDivide})
        Me.mnuCompile.Text = "�༭(&E)"
        '
        'mnuAdd
        '
        Me.mnuAdd.Index = 0
        Me.mnuAdd.Text = "����(&A)"
        '
        'mnuEdit
        '
        Me.mnuEdit.Index = 1
        Me.mnuEdit.Text = "�༭(&E)"
        '
        'mnuDivide
        '
        Me.mnuDivide.Index = 3
        Me.mnuDivide.Text = "�ֵ��ϵ�(S)"
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFind, Me.mnuQuery, Me.mnuSelect, Me.mnuSep1, Me.mnuPrint, Me.mnuExport, Me.mnuSep2, Me.mnuQuit})
        Me.mnuFile.Text = "�ļ�(&F)"
        '
        'mnuFind
        '
        Me.mnuFind.Index = 0
        Me.mnuFind.Text = "����(&F)"
        '
        'mnuQuery
        '
        Me.mnuQuery.Index = 1
        Me.mnuQuery.Text = "�鿴(&Q)"
        '
        'mnuSelect
        '
        Me.mnuSelect.Index = 2
        Me.mnuSelect.Text = "����(&S)"
        '
        'mnuSep1
        '
        Me.mnuSep1.Index = 3
        Me.mnuSep1.Text = "-"
        '
        'mnuPrint
        '
        Me.mnuPrint.Index = 4
        Me.mnuPrint.Text = "��ӡ(&P)..."
        '
        'mnuExport
        '
        Me.mnuExport.Index = 5
        Me.mnuExport.Text = "����(&E)"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.Text = "����(&H)"
        '
        'tbbtnQuery
        '
        Me.tbbtnQuery.ImageIndex = 1
        Me.tbbtnQuery.Text = "�鿴"
        Me.tbbtnQuery.ToolTipText = "�鿴"
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuCompile, Me.mnuHelp})
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 41)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.Size = New System.Drawing.Size(606, 332)
        Me.C1DBG.TabIndex = 15
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style14{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" & _
        "tyle9{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Alig" & _
        "nVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" AllowRowSizing=""None"" CaptionH" & _
        "eight=""18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""Dotted" & _
        "CellBorder"" RecordSelectorWidth=""21"" DefRecSelWidth=""21"" VerticalScrollGroup=""1""" & _
        " HorizontalScrollGroup=""1""><Height>328</Height><CaptionStyle parent=""Style2"" me=" & _
        """Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""Eve" & _
        "nRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterSty" & _
        "le parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><Head" & _
        "ingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow""" & _
        " me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle paren" & _
        "t=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style1" & _
        "1"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""S" & _
        "tyle1"" /><ClientRect>0, 0, 602, 328</ClientRect><BorderSide>0</BorderSide><Borde" & _
        "rStyle>Sunken</BorderStyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles" & _
        "><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style par" & _
        "ent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style parent" & _
        "=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=" & _
        """Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=" & _
        """Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Head" & _
        "ing"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent" & _
        "=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</h" & _
        "orzSplits><Layout>None</Layout><DefaultRecSelWidth>21</DefaultRecSelWidth><Clien" & _
        "tArea>0, 0, 602, 328</ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" />" & _
        "<PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'tbbtnDelete
        '
        Me.tbbtnDelete.ImageIndex = 4
        Me.tbbtnDelete.Text = "ɾ��"
        Me.tbbtnDelete.ToolTipText = "ɾ��"
        '
        'tbbtnExport
        '
        Me.tbbtnExport.ImageIndex = 6
        Me.tbbtnExport.Text = "����"
        Me.tbbtnExport.ToolTipText = "����Excel"
        '
        'tbbtnAdd
        '
        Me.tbbtnAdd.ImageIndex = 2
        Me.tbbtnAdd.Text = "����"
        Me.tbbtnAdd.ToolTipText = "����"
        '
        'tbbtnQuit
        '
        Me.tbbtnQuit.ImageIndex = 7
        Me.tbbtnQuit.Text = "�˳�"
        Me.tbbtnQuit.ToolTipText = "�˳�"
        '
        'tbbtnSep3
        '
        Me.tbbtnSep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
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
        'ToolBar
        '
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnFind, Me.tbbtnQuery, Me.tbbtnSelect, Me.tbbtnSep1, Me.tbbtnAdd, Me.tbbtnEdit, Me.tbbtnDelete, Me.tbbtnDivide, Me.tbbtnSep2, Me.tbbtnPrint, Me.tbbtnExport, Me.tbbtnSep3, Me.tbbtnQuit})
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(606, 41)
        Me.ToolBar.TabIndex = 14
        '
        'tbbtnSelect
        '
        Me.tbbtnSelect.ImageIndex = 12
        Me.tbbtnSelect.Text = "����"
        Me.tbbtnSelect.ToolTipText = "����"
        '
        'tbbtnDivide
        '
        Me.tbbtnDivide.ImageIndex = 9
        Me.tbbtnDivide.Text = "�ֵ��ϵ�"
        Me.tbbtnDivide.ToolTipText = "�ֵ��ϵ�"
        '
        'FrmConLoadTallyReceipt
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(606, 373)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.ToolBar)
        Me.Menu = Me.MainMenu
        Me.Name = "FrmConLoadTallyReceipt"
        Me.Text = "װ�����ᵥ��վ��Ϣ"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmConLoadTallyReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call preview("WL5_7") '*****************Ȩ����� '*************Ҫ�޸�ģ���
        Me.Text = Me.Text & "_" & G_DeptName
        FirmStr = " (DeptCode like '" & G_DeptCode & "%' or DeptCode = '99') Order by ID DESC"
        DynaStr = "" '���������ʼ����    �ڼ�������Ҫ������
        SelectStr = strPrefix
        SqlStr = FirmStr
        Call myDataGrid(SelectStr, SqlStr)
        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '���ѡ���¼��ɫ
    End Sub

    Private Sub myDataGrid(ByVal SelStr As String, ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            '����ʾ����������ǰ��
            strsql = "select " & SelStr & " * from View_ConLoadTallyReceipt where " & Sql '******Ҫ�޸�
            'strsql = "select  * from View_ConLoadTallyReceipt " '******Ҫ�޸�

            Me.C1DBG.DataSource = Getdata(strsql, ds)  ' class dbcontrol getdata fuction
            ColNum = 10 '����ʾ������ '******Ҫ�޸�
            Table_Name = "View_ConLoadTallyReceipt" '���������ݿ���� ''******Ҫ�޸�

            For i = 0 To ColNum - 1 '�趨����ʾ������
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Visible = False
            Next

            Call SetColumnCaption() '����б���
            Call SetColumnWidth() '����п���
            If ds.Tables(0).Rows.Count > 0 Then
                Call SetColumnSum(Sql) '��ƺϼ���
            End If
            Me.C1DBG.FetchRowStyles = True
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
        Me.C1DBG.Columns.Item(ColNum).FooterText = "�ϼ� ��" & ds.Tables(0).Rows.Count & "��"
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
        If Flag = 0 Then    '������ѡ�� �ı��˶�̬���� ȥ�� Top 200
            SelectStr = ""
            DynaStr = Sql_Find
            SqlStr = DynaStr & " and " & FirmStr
            myDataGrid(SelectStr, SqlStr)
        ElseIf Flag = 2 Then    'ȫѡ һ���Ե� ������Ҫ��
            myDataGrid("", FirmStr)
        End If
    End Sub

    Private Sub mnuQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuery.Click
        If ds.Tables(0).Rows.Count > 0 Then
            Dim FrmQuery As New FrmConLoadTallyReceipt_Query()    '***********Ҫ�޸�
            ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
            If Me.C1DBG.Columns("WORK_PLACE").Text = "99" Then
                'FrmQuery.bt()
            End If
            Dim Row As Integer
            Row = Me.C1DBG.Row
            FrmQuery.ShowDialog()
            If FrmQuery.CheckMark = True Then
                myDataGrid(SelectStr, SqlStr)
                Me.C1DBG.Row = Row
            End If
        End If
    End Sub

    Private Sub mnuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdd.Click
        Dim FrmAdd As New FrmConLoadTallyReceipt_Add       '***********Ҫ�޸�
        If ds.Tables(0).Rows.Count > 0 Then
            ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
        Else
            ID = -1
        End If
        FrmAdd.ShowDialog()
        If FrmAdd.flag Then
            myDataGrid(strPrefix, FirmStr)
        End If
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        If ds.Tables(0).Rows.Count > 0 Then
            Dim FrmEdit As New FrmConLoadTallyReceipt_Edit()  '***********Ҫ�޸�
            Dim Row As Integer

            ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
            Row = Me.C1DBG.Row
            FrmEdit.ShowDialog()
            If FrmEdit.blSave Then
                myDataGrid(SelectStr, SqlStr)
                Me.C1DBG.Row = Row
            End If
        End If
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        If ds.Tables(0).Rows.Count > 0 Then
            Dim FrmDelete As New FrmConLoadTallyReceipt_Delete()     '***********Ҫ�޸�

            ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
            FrmDelete.ShowDialog()
            If FrmDelete.blSave Then
                myDataGrid(SelectStr, SqlStr)
            End If
        End If
    End Sub

    Private Sub mnuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrint.Click
        Call PrintExcel()
    End Sub

    Private Sub PrintExcel() '��ӡ��Excel        

        Dim Row As Integer
        Dim Col As Integer

        Try
            Call MakeExcel()

            Row = ds.Tables(0).Rows.Count + 4
            Col = Me.C1DBG.Columns.Count - ColNum
            '**************���߿�
            For Row = 2 To ds.Tables(0).Rows.Count + 4 '����
                xlSheet.Range(xlSheet.Cells(Row, 1), xlSheet.Cells(Row, C1DBG.Columns.Count - ColNum)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = 7
            Next Row
            For Col = 1 To C1DBG.Columns.Count - ColNum + 1 '����
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

    Private Sub ExportExcel() '����Excel        
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

            xlSheet.Cells(1, 1) = Me.Text() '����

            For Col = ColNum To Me.C1DBG.Columns.Count - 1 '�б���
                xlSheet.Cells(3, Col - ColNum + 1) = Me.C1DBG.Columns(Col).Caption

            Next Col
            Me.C1DBG.MoveFirst()
            For Row = 0 To ds.Tables(0).Rows.Count - 1 '����
                For Col = ColNum To Me.C1DBG.Columns.Count - 1
                    xlSheet.Cells(Row + 4, Col - ColNum + 1) = Me.C1DBG.Columns(Col).Text.ToString      'ds.Tables(0).Rows(Row)(Col)
                Next Col
                Me.C1DBG.MoveNext()
            Next Row
            If Me.C1DBG.ColumnFooters = True Then '�ϼ���
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
            Case "����"
                mnuFind_Click(sender, e)
            Case "�鿴"
                Call mnuQuery_Click(sender, e)
            Case "����"
                Call mnuSelect_Click(sender, e)
            Case "����"
                Call mnuAdd_Click(sender, e)
            Case "�༭"
                Call mnuEdit_Click(sender, e)
            Case "ɾ��"
                Call mnuDelete_Click(sender, e)
            Case "�ֵ��ϵ�"
                Call mnuDivide_Click(sender, e)
            Case "��ӡ"
                Call mnuPrint_Click(sender, e)
            Case "����"
                Call mnuExport_Click(sender, e)
            Case 9

            Case "�˳�"
                Call mnuQuit_Click(sender, e)
        End Select
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
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

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
            Else                                     'ɾ�� ��ť���ɼ�
                Me.ToolBar.Buttons.Item(5).Enabled = False
                mnuDelete.Enabled = False
            End If
        End If
    End Sub

    Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        If Me.C1DBG.Columns("StateB").CellValue(e.Row) = "0" Then
            e.CellStyle.BackColor = System.Drawing.Color.Olive
        End If
        If Not IsDBNull(Me.C1DBG.Columns("AccountNo").CellValue(e.Row)) Then
            e.CellStyle.BackColor = System.Drawing.Color.PaleTurquoise
        End If
    End Sub

    Private Sub mnuSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSelect.Click
        Dim FrmSelect As New FrmConLoadTallyReceipt_Select()
        FrmSelect.ShowDialog()
        If FrmSelect.flag = True Then
            SelectStr = ""
            DynaStr = FrmSelect.strSelect
            SqlStr = DynaStr & " and " & FirmStr
            Call myDataGrid(SelectStr, SqlStr)
            Call mnuQuery_Click(sender, e)
        Else    'ˢ�½���
            SelectStr = strPrefix
            DynaStr = ""
            SqlStr = FirmStr
            Call myDataGrid(SelectStr, SqlStr)
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