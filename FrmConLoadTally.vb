Imports TALLY.DBControl
Public Class FrmConLoadTally
    Inherits System.Windows.Forms.Form

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    '������д��������������б�
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
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents tbbtnTotal As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuTotal As System.Windows.Forms.MenuItem
    Friend WithEvents mnuPass As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnPass As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSelect As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuSelect As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHche As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnHche As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuAlterReport As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnAlterReport As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuClearOut As System.Windows.Forms.MenuItem
    Friend WithEvents mnuChoochoo As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAllConvert As System.Windows.Forms.MenuItem
    Friend WithEvents mnuRefresh As System.Windows.Forms.MenuItem
    Friend WithEvents tbbtnAllConvert As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnRefresh As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnChoochoo As System.Windows.Forms.ToolBarButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConLoadTally))
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.MainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuFind = New System.Windows.Forms.MenuItem
        Me.mnuQuery = New System.Windows.Forms.MenuItem
        Me.mnuTotal = New System.Windows.Forms.MenuItem
        Me.mnuPass = New System.Windows.Forms.MenuItem
        Me.mnuRefresh = New System.Windows.Forms.MenuItem
        Me.mnuSep1 = New System.Windows.Forms.MenuItem
        Me.mnuPrint = New System.Windows.Forms.MenuItem
        Me.mnuExport = New System.Windows.Forms.MenuItem
        Me.mnuSep2 = New System.Windows.Forms.MenuItem
        Me.mnuQuit = New System.Windows.Forms.MenuItem
        Me.mnuCompile = New System.Windows.Forms.MenuItem
        Me.mnuAdd = New System.Windows.Forms.MenuItem
        Me.mnuEdit = New System.Windows.Forms.MenuItem
        Me.mnuDelete = New System.Windows.Forms.MenuItem
        Me.mnuSelect = New System.Windows.Forms.MenuItem
        Me.mnuHche = New System.Windows.Forms.MenuItem
        Me.mnuAlterReport = New System.Windows.Forms.MenuItem
        Me.mnuChoochoo = New System.Windows.Forms.MenuItem
        Me.mnuClearOut = New System.Windows.Forms.MenuItem
        Me.mnuAllConvert = New System.Windows.Forms.MenuItem
        Me.mnuHelp = New System.Windows.Forms.MenuItem
        Me.ToolBar = New System.Windows.Forms.ToolBar
        Me.tbbtnFind = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuery = New System.Windows.Forms.ToolBarButton
        Me.tbbtnTotal = New System.Windows.Forms.ToolBarButton
        Me.tbbtnRefresh = New System.Windows.Forms.ToolBarButton
        Me.tbbtnPass = New System.Windows.Forms.ToolBarButton
        Me.tbbtnAlterReport = New System.Windows.Forms.ToolBarButton
        Me.tbbtnChoochoo = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep1 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnAdd = New System.Windows.Forms.ToolBarButton
        Me.tbbtnEdit = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSelect = New System.Windows.Forms.ToolBarButton
        Me.tbbtnHche = New System.Windows.Forms.ToolBarButton
        Me.tbbtnAllConvert = New System.Windows.Forms.ToolBarButton
        Me.tbbtnDelete = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep2 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnPrint = New System.Windows.Forms.ToolBarButton
        Me.tbbtnExport = New System.Windows.Forms.ToolBarButton
        Me.tbbtnSep3 = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuit = New System.Windows.Forms.ToolBarButton
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ImageList.Images.SetKeyName(8, "BOOK1.ICO")
        Me.ImageList.Images.SetKeyName(9, "ANCHOR.ICO")
        Me.ImageList.Images.SetKeyName(10, "AUTHOR.ICO")
        Me.ImageList.Images.SetKeyName(11, "BEMAGN~1.ICO")
        Me.ImageList.Images.SetKeyName(12, "MACOS~1.ICO")
        Me.ImageList.Images.SetKeyName(13, "MISC1056.ICO")
        Me.ImageList.Images.SetKeyName(14, "MYBOOK.ICO")
        Me.ImageList.Images.SetKeyName(15, "BOOK06.ICO")
        Me.ImageList.Images.SetKeyName(16, "character3.ico")
        Me.ImageList.Images.SetKeyName(17, "FINDER2.ICO")
        Me.ImageList.Images.SetKeyName(18, "FONT02.ICO")
        Me.ImageList.Images.SetKeyName(19, "kq1.ico")
        Me.ImageList.Images.SetKeyName(20, "kq2.ico")
        Me.ImageList.Images.SetKeyName(21, "kq.ico")
        Me.ImageList.Images.SetKeyName(22, "Windows.ico")
        Me.ImageList.Images.SetKeyName(23, "winxfile.ico")
        Me.ImageList.Images.SetKeyName(24, "WORD~216.ICO")
        Me.ImageList.Images.SetKeyName(25, "WRITE3.ICO")
        Me.ImageList.Images.SetKeyName(26, "WYH168.ICO")
        Me.ImageList.Images.SetKeyName(27, "0023.GIF")
        Me.ImageList.Images.SetKeyName(28, "cy_rbemp.ico")
        Me.ImageList.Images.SetKeyName(29, "cy_rbful.ico")
        Me.ImageList.Images.SetKeyName(30, "Dodge Viper.ico")
        Me.ImageList.Images.SetKeyName(31, "314966.gif")
        Me.ImageList.Images.SetKeyName(32, "200641474216228.png")
        Me.ImageList.Images.SetKeyName(33, "AUTHOR.ICO")
        Me.ImageList.Images.SetKeyName(34, "EYE1.ICO")
        Me.ImageList.Images.SetKeyName(35, "FORMATED.ICO")
        Me.ImageList.Images.SetKeyName(36, "GLOBE1.ICO")
        Me.ImageList.Images.SetKeyName(37, "hct.jpg")
        Me.ImageList.Images.SetKeyName(38, "kq1.ico")
        Me.ImageList.Images.SetKeyName(39, "NOTEPA~1.ICO")
        Me.ImageList.Images.SetKeyName(40, "NOTEPA~2.ICO")
        Me.ImageList.Images.SetKeyName(41, "pic_ywzx.gif")
        Me.ImageList.Images.SetKeyName(42, "RECYCLIN.ICO")
        Me.ImageList.Images.SetKeyName(43, "SETTINGS.ICO")
        Me.ImageList.Images.SetKeyName(44, "VIEWER1.ICO")
        Me.ImageList.Images.SetKeyName(45, "VIEWER2.ICO")
        Me.ImageList.Images.SetKeyName(46, "VIEWER3.ICO")
        Me.ImageList.Images.SetKeyName(47, "VIEWER4.ICO")
        Me.ImageList.Images.SetKeyName(48, "1200CC 6.GIF")
        Me.ImageList.Images.SetKeyName(49, "www6Lucn0005.gif")
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuCompile, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFind, Me.mnuQuery, Me.mnuTotal, Me.mnuPass, Me.mnuRefresh, Me.mnuSep1, Me.mnuPrint, Me.mnuExport, Me.mnuSep2, Me.mnuQuit})
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
        'mnuTotal
        '
        Me.mnuTotal.Index = 2
        Me.mnuTotal.Text = "ͳ��(&T)"
        '
        'mnuPass
        '
        Me.mnuPass.Index = 3
        Me.mnuPass.Text = "���(&C)"
        '
        'mnuRefresh
        '
        Me.mnuRefresh.Index = 4
        Me.mnuRefresh.Text = "ˢ��(&R)"
        '
        'mnuSep1
        '
        Me.mnuSep1.Index = 5
        Me.mnuSep1.Text = "-"
        '
        'mnuPrint
        '
        Me.mnuPrint.Index = 6
        Me.mnuPrint.Text = "��ӡ(&P)..."
        '
        'mnuExport
        '
        Me.mnuExport.Index = 7
        Me.mnuExport.Text = "����(&E)"
        '
        'mnuSep2
        '
        Me.mnuSep2.Index = 8
        Me.mnuSep2.Text = "-"
        '
        'mnuQuit
        '
        Me.mnuQuit.Index = 9
        Me.mnuQuit.Text = "�˳�(&X)"
        '
        'mnuCompile
        '
        Me.mnuCompile.Index = 1
        Me.mnuCompile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAdd, Me.mnuEdit, Me.mnuDelete, Me.mnuSelect, Me.mnuHche, Me.mnuAlterReport, Me.mnuChoochoo, Me.mnuClearOut, Me.mnuAllConvert})
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
        'mnuDelete
        '
        Me.mnuDelete.Index = 2
        Me.mnuDelete.Text = "ɾ��(&D)"
        '
        'mnuSelect
        '
        Me.mnuSelect.Index = 3
        Me.mnuSelect.Text = "����(&S)"
        '
        'mnuHche
        '
        Me.mnuHche.Index = 4
        Me.mnuHche.Text = "��(&H)"
        Me.mnuHche.Visible = False
        '
        'mnuAlterReport
        '
        Me.mnuAlterReport.Index = 5
        Me.mnuAlterReport.Text = "�ĵ�����"
        Me.mnuAlterReport.Visible = False
        '
        'mnuChoochoo
        '
        Me.mnuChoochoo.Index = 6
        Me.mnuChoochoo.Text = "�𳵵���"
        Me.mnuChoochoo.Visible = False
        '
        'mnuClearOut
        '
        Me.mnuClearOut.Index = 7
        Me.mnuClearOut.Text = "����ⲿ����"
        Me.mnuClearOut.Visible = False
        '
        'mnuAllConvert
        '
        Me.mnuAllConvert.Index = 8
        Me.mnuAllConvert.Text = "���廻��"
        Me.mnuAllConvert.Visible = False
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.Text = "����(&H)"
        '
        'ToolBar
        '
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnFind, Me.tbbtnQuery, Me.tbbtnTotal, Me.tbbtnRefresh, Me.tbbtnPass, Me.tbbtnAlterReport, Me.tbbtnChoochoo, Me.tbbtnSep1, Me.tbbtnAdd, Me.tbbtnEdit, Me.tbbtnSelect, Me.tbbtnHche, Me.tbbtnAllConvert, Me.tbbtnDelete, Me.tbbtnSep2, Me.tbbtnPrint, Me.tbbtnExport, Me.tbbtnSep3, Me.tbbtnQuit})
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(606, 42)
        Me.ToolBar.TabIndex = 12
        '
        'tbbtnFind
        '
        Me.tbbtnFind.ImageIndex = 0
        Me.tbbtnFind.Name = "tbbtnFind"
        Me.tbbtnFind.Tag = ""
        Me.tbbtnFind.Text = "����"
        Me.tbbtnFind.ToolTipText = "����"
        '
        'tbbtnQuery
        '
        Me.tbbtnQuery.ImageIndex = 1
        Me.tbbtnQuery.Name = "tbbtnQuery"
        Me.tbbtnQuery.Text = "�鿴"
        Me.tbbtnQuery.ToolTipText = "�鿴"
        '
        'tbbtnTotal
        '
        Me.tbbtnTotal.ImageIndex = 16
        Me.tbbtnTotal.Name = "tbbtnTotal"
        Me.tbbtnTotal.Text = "ͳ��"
        Me.tbbtnTotal.ToolTipText = "����ͳ��"
        '
        'tbbtnRefresh
        '
        Me.tbbtnRefresh.ImageIndex = 43
        Me.tbbtnRefresh.Name = "tbbtnRefresh"
        Me.tbbtnRefresh.Text = "ˢ��"
        '
        'tbbtnPass
        '
        Me.tbbtnPass.ImageIndex = 28
        Me.tbbtnPass.Name = "tbbtnPass"
        Me.tbbtnPass.Text = "���"
        Me.tbbtnPass.ToolTipText = "�������"
        '
        'tbbtnAlterReport
        '
        Me.tbbtnAlterReport.ImageIndex = 42
        Me.tbbtnAlterReport.Name = "tbbtnAlterReport"
        Me.tbbtnAlterReport.Text = "�����䵥"
        Me.tbbtnAlterReport.ToolTipText = "����װ�䵥����"
        '
        'tbbtnChoochoo
        '
        Me.tbbtnChoochoo.ImageIndex = 48
        Me.tbbtnChoochoo.Name = "tbbtnChoochoo"
        Me.tbbtnChoochoo.Text = "�𳵵���"
        Me.tbbtnChoochoo.Visible = False
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
        Me.tbbtnAdd.Text = "����"
        Me.tbbtnAdd.ToolTipText = "����"
        '
        'tbbtnEdit
        '
        Me.tbbtnEdit.ImageIndex = 3
        Me.tbbtnEdit.Name = "tbbtnEdit"
        Me.tbbtnEdit.Text = "�༭"
        Me.tbbtnEdit.ToolTipText = "�༭ɾ���鿴"
        '
        'tbbtnSelect
        '
        Me.tbbtnSelect.ImageIndex = 46
        Me.tbbtnSelect.Name = "tbbtnSelect"
        Me.tbbtnSelect.Text = "����"
        Me.tbbtnSelect.ToolTipText = "����"
        '
        'tbbtnHche
        '
        Me.tbbtnHche.ImageIndex = 37
        Me.tbbtnHche.Name = "tbbtnHche"
        Me.tbbtnHche.Text = "��"
        Me.tbbtnHche.ToolTipText = "�𳵴��м��"
        Me.tbbtnHche.Visible = False
        '
        'tbbtnAllConvert
        '
        Me.tbbtnAllConvert.ImageIndex = 9
        Me.tbbtnAllConvert.Name = "tbbtnAllConvert"
        Me.tbbtnAllConvert.Text = "����"
        Me.tbbtnAllConvert.ToolTipText = "������������"
        Me.tbbtnAllConvert.Visible = False
        '
        'tbbtnDelete
        '
        Me.tbbtnDelete.ImageIndex = 4
        Me.tbbtnDelete.Name = "tbbtnDelete"
        Me.tbbtnDelete.Text = "ɾ��"
        Me.tbbtnDelete.ToolTipText = "ɾ��"
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
        Me.tbbtnPrint.Text = "��ӡ"
        Me.tbbtnPrint.ToolTipText = "��ӡ"
        '
        'tbbtnExport
        '
        Me.tbbtnExport.ImageIndex = 6
        Me.tbbtnExport.Name = "tbbtnExport"
        Me.tbbtnExport.Text = "����"
        Me.tbbtnExport.ToolTipText = "����Excel"
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
        Me.tbbtnQuit.Text = "�˳�"
        Me.tbbtnQuit.ToolTipText = "�˳�"
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
        Me.C1DBG.RowHeight = 18
        Me.C1DBG.Size = New System.Drawing.Size(606, 337)
        Me.C1DBG.TabIndex = 13
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = resources.GetString("C1DBG.PropBag")
        '
        'FrmConLoadTally
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.ClientSize = New System.Drawing.Size(606, 379)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.ToolBar)
        Me.Font = New System.Drawing.Font("������", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Menu = Me.MainMenu
        Me.Name = "FrmConLoadTally"
        Me.Text = "װ��������Ϣ"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim ds As New DataSet()
    Dim SqlStr As String  '�������
    Dim SelectStr As String
    Dim DynaStr As String '�ɱ���������
    Dim FirmStr As String '������������
    Dim ColNum As Integer '����ʾ������
    Const strPrefix As String = " Top 200 " 'Sql����ѡǰ׺
    Public Shared strShip, strVoyage, strCodeYard, strNameYard, strBillNo As String

    Dim iClickCount As Integer

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

    Private Sub FrmConLoadTally_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call preview("WL5_1") '*****************Ȩ����� '
        Me.Text = Me.Text & "_" & G_DeptName
        FirmStr = " (DeptCode like '" & G_DeptCode & "%' or CodeYard = '99') and StateC<= '1' and TradeMark='0' Order by ID DESC"
        SelectStr = strPrefix
        DynaStr = " InputTime>DateAdd(mm,-2,Getdate()) "
        SqlStr = DynaStr & " and " & FirmStr
        Call myDataGrid(SelectStr, SqlStr)
        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue  '���ѡ���¼��ɫ

        Me.tbbtnDelete.Visible = False
        Me.mnuDelete.Visible = False
        Me.tbbtnQuery.Visible = False
        Me.mnuQuery.Visible = False
        If G_DeptCode <> "26.11.30.01" And G_DeptCode <> "26" Then '�Ǹ��ڳ�վ
            Me.mnuHche.Visible = False
            Me.tbbtnHche.Visible = False
        End If
        If G_DeptCode = "26.11.30.09" Then  '�����
            Me.mnuAlterReport.Visible = False
            Me.tbbtnAlterReport.Visible = False
        End If
        Me.C1DBG.Splits(0).ColumnCaptionHeight = 20
        Me.C1DBG.Splits(0).ColumnFooterHeight = 20
        Me.C1DBG.RowHeight = 18
        Me.C1DBG.FetchRowStyles = True
    End Sub

    Private Sub myDataGrid(ByVal SelStr As String, ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            strsql = "select " & SelStr & " * from View_ConLoadTally where " & Sql
            Me.C1DBG.DataSource = Getdata(strsql, ds)
            If G_DeptCode.Length <= 8 Then
                ColNum = 16
            Else
                ColNum = 17
            End If
            Table_Name = "View_ConLoadTally" '���������ݿ����
            For i = 0 To ColNum - 1 '�趨����ʾ������
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Me.C1DBG.Columns("InputTime").NumberFormat = "yy-MM-dd HH:mm"
            Me.C1DBG.Columns("CheckTime").NumberFormat = "yy-MM-dd HH:mm"
            Me.C1DBG.Columns("PrintTime").NumberFormat = "yy-MM-dd HH:mm"
            Me.C1DBG.Columns("ConTime").NumberFormat = "yy-MM-dd HH:mm"
            Call SetColumnCaption() '����б���
            Call SetDGWidth3(C1DBG)
            'Me.C1DBG.Splits(0).DisplayColumns("BLNO").Width = 100
            'Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Width = 100

            If ds.Tables(0).Rows.Count > 0 Then
                Call SetColumnSum(Sql) '��ƺϼ���
            End If
            Me.C1DBG.Refresh()
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
        Dim FrmFind As New FrmFind
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
        'If ds.Tables(0).Rows.Count > 0 Then
        '    Dim FrmQuery As New FrmConLoadTallyNew_Query()    '***********Ҫ�޸�
        '    ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
        '    strShip = Me.C1DBG.Columns("CHI_VESSEL").Text
        '    strVoyage = Me.C1DBG.Columns("VOYAGE").Text
        '    strCodeYard = Me.C1DBG.Columns("CodeYard").Text
        '    strBillNo = Me.C1DBG.Columns("blno").Text
        '    FrmQuery.ShowDialog()
        'End If
        If ds.Tables(0).Rows.Count > 0 Then
            Dim FrmQuery As New FrmConLoadTallyReceipt_Query      '***********Ҫ�޸�
            ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
            'If Me.C1DBG.Columns("WORK_PLACE").Text = "99" Then
            '    'FrmQuery.bt()
            'End If
            FrmQuery.ShowDialog()
            Dim Row As Integer
            Row = Me.C1DBG.Row
            If FrmQuery.CheckMark = True Then
                Call myDataGrid(SelectStr, SqlStr)
                Me.C1DBG.Row = Row
            End If
        End If
    End Sub

    Private Sub mnuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdd.Click
        Dim FrmAdd As New FrmConLoadTallyNew_Add      '***********Ҫ�޸�

        'ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
        strShip = Me.C1DBG.Columns("CHI_VESSEL").Text
        strVoyage = Me.C1DBG.Columns("VOYAGE").Text
        strCodeYard = Me.C1DBG.Columns("CodeYard").Text
        strBillNo = Me.C1DBG.Columns("blno").Text
        FrmAdd.ShowDialog()
        If FrmAdd.blSave Then
            myDataGrid(strPrefix, FirmStr)
        End If
    End Sub

    Private Sub mnuEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEdit.Click
        If ds.Tables(0).Rows.Count > 0 Then
            Dim FrmEdit As New FrmConLoadTallyNew_Edit    '***********Ҫ�޸�
            Dim Row As Integer

            ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
            Row = Me.C1DBG.Row
            strShip = Me.C1DBG.Columns("CHI_VESSEL").Text
            strVoyage = Me.C1DBG.Columns("VOYAGE").Text
            strCodeYard = Me.C1DBG.Columns("CodeYard").Text
            strBillNo = Me.C1DBG.Columns("blno").Text
            FrmEdit.strFindConNo = Me.C1DBG.Columns("Container_No").Text
            FrmEdit.ShowDialog()
            Try
                If FrmEdit.EditMark = True Then
                    Call myDataGrid(SelectStr, SqlStr)
                    Me.C1DBG.Row = Row
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        'If ds.Tables(0).Rows.Count > 0 Then
        '    Dim FrmDelete As New FrmConLoadTally_Delete()    '***********Ҫ�޸�

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
            Dim FrmQuery As New FrmConLoadTally_Query      '***********Ҫ�޸�
            ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
            FrmQuery.btQuit.Text = "ȷ��"
            FrmQuery.ShowDialog()
            Call GetConLoadContainerReport()
        End If
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
        'Call ExportExcel()
        If ds.Tables(0).Rows.Count > 0 Then
            Dim FrmQuery As New FrmConLoadTally_Query      '***********Ҫ�޸�
            ID = CType(Me.C1DBG.Columns.Item("ID").Text.ToString, Integer)
            FrmQuery.btQuit.Text = "ȷ��"
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
            xlSheet.Cells(12, 4) = TimeBegin.Year & " �� "
            xlSheet.Cells(12, 5) = TimeBegin.Month
            xlSheet.Cells(12, 7) = TimeBegin.Day
            xlSheet.Cells(12, 10) = TimeBegin.Hour
            xlSheet.Cells(13, 4) = TimeEnd.Year & " �� "
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
                    xlSheet.Cells(16 + i, 13) = dvSubTable.Item(i)("DAMAGED_AMOUNT") & "�� " & dvSubTable.Item(i)("DAMAGED_PACK")
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
            '    strTotal = strTotal & " , ���� X " & iCountOther
            'End If
            'xlSheet.Cells(23, 3) = strTotal
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
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
            Case "ͳ��"
                Call mnuTotal_Click(sender, e)
            Case "����"
                Call mnuAdd_Click(sender, e)
            Case "�༭"
                Call mnuEdit_Click(sender, e)
            Case "ɾ��"
                Call mnuDelete_Click(sender, e)
            Case "��ӡ"
                Call mnuPrint_Click(sender, e)
            Case "����"
                Call mnuExport_Click(sender, e)
            Case "�˳�"
                Call mnuQuit_Click(sender, e)
            Case "���"
                Call mnuPass_Click(sender, e)
            Case "����"
                Call mnuPass_Click(sender, e)
            Case "����"
                Call mnuSelect_Click(sender, e)
            Case "��"
                Call mnuHche_Click(sender, e)
            Case "�����䵥"
                Call mnuAlterReport_Click(sender, e)
            Case "�𳵵���"
                Call mnuChoochoo_Click(sender, e)
            Case "����"
                Call mnuAllConvert_Click(sender, e)
            Case "ˢ��"
                Call mnuRefresh_Click(sender, e)
        End Select
    End Sub

    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        strCodeYard = Nothing
        TBar = 1
        Mnu = 1
    End Sub

    Private Sub C1DBG_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1DBG.DoubleClick
        'Call mnuQuery_Click(sender, e)
        mnuEdit_Click(sender, e)
    End Sub

    Private Sub mnuTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTotal.Click
        If ds.Tables(0).Rows.Count > 0 Then
            strCodeYard = Me.C1DBG.Columns("CodeYard").Text
            strNameYard = Me.C1DBG.Columns("Code_Yard_Name").Text
            Dim FrmTotal As New FrmConLoadTallyNew_Total
            FrmTotal.ShowDialog()
        End If
    End Sub

    Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        If Me.C1DBG.Columns("checked").CellValue(e.Row) = "1" Then
            'e.CellStyle.BackColor = System.Drawing.Color.Cyan
            e.CellStyle.ForeColor = System.Drawing.Color.DarkGreen
            'e.CellStyle.Borders.BorderType = C1.Win.C1TrueDBGrid.BorderTypeEnum.Flat
            'e.CellStyle.Borders.Color = System.Drawing.Color.PaleTurquoise
            'e.CellStyle.Borders.Bottom = 1
            'e.CellStyle.Borders.Right = 1
            'e.CellStyle.Borders.Left = 1
            'e.CellStyle.Borders.Top = 1
            e.CellStyle.Font = New Font("DotumChe", 13, FontStyle.Bold, GraphicsUnit.Pixel)
        End If
        If Me.C1DBG.Columns("TradeMark").CellValue(e.Row) = "1" Then
            e.CellStyle.Font = New Font("������", 13, FontStyle.Underline, GraphicsUnit.Pixel)
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

    Private Sub mnuPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPass.Click
        iClickCount += 1
        If iClickCount Mod 2 = 1 Then
            FirmStr = " (DeptCode like '" & G_DeptCode & "%' or CodeYard = '99') and (StateC >='2' or TradeMark='1') Order by ID DESC"
            Me.mnuPass.Text = "����(&R)"
            Me.tbbtnPass.Text = "����"
            Me.tbbtnPass.ToolTipText = "����"
        Else
            FirmStr = " (DeptCode like '" & G_DeptCode & "%' or CodeYard = '99') and StateC <='1' and TradeMark='0' Order by ID DESC"
            Me.mnuPass.Text = "���(&C)"
            Me.tbbtnPass.Text = "���"
            Me.tbbtnPass.ToolTipText = "�������"
        End If
        SelectStr = strPrefix
        DynaStr = " InputTime>DateAdd(mm,-2,Getdate()) "
        SqlStr = DynaStr & " and " & FirmStr
        Call myDataGrid(SelectStr, SqlStr)
    End Sub

    Private Sub mnuSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSelect.Click
        Dim FrmSelect As New FrmContainerOutPort_Select
        FrmSelect.ShowDialog()
        If FrmSelect.flag = True Then
            SelectStr = ""
            DynaStr = FrmSelect.strSelect
            SqlStr = DynaStr & " and " & FirmStr
            Call myDataGrid(SelectStr, SqlStr)
        Else
            SelectStr = strPrefix
            DynaStr = ""
            SqlStr = FirmStr
            Call myDataGrid(SelectStr, SqlStr)
        End If
    End Sub

    Private Sub mnuHche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHche.Click
        Dim FrmHche As New FrmConLoadTally_Train
        FrmHche.btnCallPrint.Visible = False
        FrmHche.ShowDialog()
        If FrmHche.blSave Then
            Call myDataGrid(SelectStr, SqlStr)
        End If
    End Sub

    Private Sub mnuAlterReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAlterReport.Click
        Dim FrmExtract As New FrmConLoadTally_Extract
        FrmExtract.blEditImport = 3
        FrmExtract.ShowDialog()
        If FrmExtract.blSave Then
            Call myDataGrid(strPrefix, FirmStr)
        End If
    End Sub

    Private Sub mnuClearOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuClearOut.Click
        Dim FrmClearOut As New FrmConLoadTally_ClearOut
        FrmClearOut.ShowDialog()
    End Sub

    Private Sub mnuChoochoo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChoochoo.Click
        Dim FrmChoochoo As New FrmConLoadTally_Choochoo
        FrmChoochoo.ShowDialog()
        If FrmChoochoo.blSave Then
            Call myDataGrid(strPrefix, FirmStr)
        End If
    End Sub

    Friend Sub mnuAllConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAllConvert.Click
        Dim frm As New FrmConLoadTally_AllConvert
        frm.Show()
        If frm.blSave Then
            mnuRefresh_Click(sender, e)
        End If
    End Sub

    Friend Sub mnuRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRefresh.Click
        myDataGrid(strPrefix, FirmStr)
    End Sub
End Class
