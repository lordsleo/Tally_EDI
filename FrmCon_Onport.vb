Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FrmCon_Onport
    Inherits System.Windows.Forms.Form

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    '������д dispose ����������б�
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

    'ע��: ���¹����� Windows ����������������
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
    Friend WithEvents tbbtndo As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnQuery As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnAdd As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnEdit As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnDelete As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnPrint As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnExport As System.Windows.Forms.ToolBarButton
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
    Friend WithEvents mnuExportReload As System.Windows.Forms.MenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents tbbtnlist As System.Windows.Forms.ToolBarButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCon_Onport))
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
        Me.mnuExportReload = New System.Windows.Forms.MenuItem
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
        Me.tbbtnFind = New System.Windows.Forms.ToolBarButton
        Me.tbbtndo = New System.Windows.Forms.ToolBarButton
        Me.tbbfind_Container = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuery = New System.Windows.Forms.ToolBarButton
        Me.tbbtnAdd = New System.Windows.Forms.ToolBarButton
        Me.tbbtnEdit = New System.Windows.Forms.ToolBarButton
        Me.tbbtnDelete = New System.Windows.Forms.ToolBarButton
        Me.tbbtnPrint = New System.Windows.Forms.ToolBarButton
        Me.tbbtnExport = New System.Windows.Forms.ToolBarButton
        Me.tbbtnlist = New System.Windows.Forms.ToolBarButton
        Me.tbbtnQuit = New System.Windows.Forms.ToolBarButton
        Me.TabControl1 = New System.Windows.Forms.TabControl
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
        Me.LabREMARKS = New System.Windows.Forms.Label
        Me.Label = New System.Windows.Forms.Label
        Me.GBV.SuspendLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabTALLY_LIST.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.C1DBGTally_List, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabDaily.SuspendLayout()
        CType(Me.C1DBGDaily_report, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCertificate.SuspendLayout()
        CType(Me.C1DBGCertificate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabDailyDx.SuspendLayout()
        CType(Me.C1DBGDaily_report_dx, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mnuFile.Text = "�ļ�(&F)"
        '
        'mnuFind
        '
        Me.mnuFind.Enabled = False
        Me.mnuFind.Index = 0
        Me.mnuFind.Text = "����(&F)"
        '
        'mnuQuery
        '
        Me.mnuQuery.Enabled = False
        Me.mnuQuery.Index = 1
        Me.mnuQuery.Text = "�鿴(&Q)"
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
        Me.mnuPrint.Text = "��ӡ(&P)..."
        '
        'mnuExport
        '
        Me.mnuExport.Enabled = False
        Me.mnuExport.Index = 4
        Me.mnuExport.Text = "����(&E)"
        '
        'mnuSep2
        '
        Me.mnuSep2.Index = 5
        Me.mnuSep2.Text = "-"
        '
        'mnuQuit
        '
        Me.mnuQuit.Index = 6
        Me.mnuQuit.Text = "�˳�(&X)"
        '
        'mnuCompile
        '
        Me.mnuCompile.Index = 1
        Me.mnuCompile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAdd, Me.mnuEdit, Me.mnuDelete, Me.mnuExportReload})
        Me.mnuCompile.Text = "�༭(&E)"
        '
        'mnuAdd
        '
        Me.mnuAdd.Enabled = False
        Me.mnuAdd.Index = 0
        Me.mnuAdd.Text = "����(&A)"
        '
        'mnuEdit
        '
        Me.mnuEdit.Enabled = False
        Me.mnuEdit.Index = 1
        Me.mnuEdit.Text = "�༭(&E)"
        '
        'mnuDelete
        '
        Me.mnuDelete.Enabled = False
        Me.mnuDelete.Index = 2
        Me.mnuDelete.Text = "ɾ��(&D)"
        '
        'mnuExportReload
        '
        Me.mnuExportReload.Index = 3
        Me.mnuExportReload.Text = "����������Ϣ"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.Text = "����(&H)"
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
        Me.GBV.Size = New System.Drawing.Size(174, 424)
        Me.GBV.TabIndex = 6
        Me.GBV.TabStop = False
        '
        'ToolBarV
        '
        Me.ToolBarV.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.S1, Me.tbbtnOK, Me.S2, Me.tbbtnSearch, Me.S3, Me.tbbtnSort, Me.S4, Me.tbbtnEng})
        Me.ToolBarV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBarV.DropDownArrows = True
        Me.ToolBarV.ImageList = Me.ImageList
        Me.ToolBarV.Location = New System.Drawing.Point(3, 380)
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
        Me.tbbtnOK.Text = "����"
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
        Me.tbbtnSearch.Text = "����"
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
        Me.tbbtnSort.Text = "����"
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
        Me.tbbtnEng.Text = "Ӣ��"
        '
        'btResure
        '
        Me.btResure.Location = New System.Drawing.Point(128, 332)
        Me.btResure.Name = "btResure"
        Me.btResure.Size = New System.Drawing.Size(42, 22)
        Me.btResure.TabIndex = 16
        Me.btResure.Text = "��ѯ"
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
        Me.Label2.Text = "����"
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
        Me.Label1.Text = "����"
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
        Me.GB.Size = New System.Drawing.Size(470, 424)
        Me.GB.TabIndex = 7
        Me.GB.TabStop = False
        '
        'ToolBar
        '
        Me.ToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnFind, Me.tbbtndo, Me.tbbfind_Container, Me.tbbtnQuery, Me.tbbtnAdd, Me.tbbtnEdit, Me.tbbtnDelete, Me.tbbtnPrint, Me.tbbtnExport, Me.tbbtnlist, Me.tbbtnQuit})
        Me.ToolBar.DropDownArrows = True
        Me.ToolBar.Enabled = False
        Me.ToolBar.ImageList = Me.ImageList
        Me.ToolBar.Location = New System.Drawing.Point(3, 17)
        Me.ToolBar.Name = "ToolBar"
        Me.ToolBar.ShowToolTips = True
        Me.ToolBar.Size = New System.Drawing.Size(464, 41)
        Me.ToolBar.TabIndex = 16
        '
        'tbbtnFind
        '
        Me.tbbtnFind.ImageIndex = 0
        Me.tbbtnFind.Name = "tbbtnFind"
        Me.tbbtnFind.Text = "����"
        Me.tbbtnFind.ToolTipText = "����"
        '
        'tbbtndo
        '
        Me.tbbtndo.ImageIndex = 8
        Me.tbbtndo.Name = "tbbtndo"
        Me.tbbtndo.Text = "����"
        '
        'tbbfind_Container
        '
        Me.tbbfind_Container.ImageIndex = 9
        Me.tbbfind_Container.Name = "tbbfind_Container"
        Me.tbbfind_Container.Text = "����"
        '
        'tbbtnQuery
        '
        Me.tbbtnQuery.ImageIndex = 1
        Me.tbbtnQuery.Name = "tbbtnQuery"
        Me.tbbtnQuery.Text = "�鿴"
        Me.tbbtnQuery.ToolTipText = "�鿴"
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
        Me.tbbtnEdit.ToolTipText = "�༭"
        '
        'tbbtnDelete
        '
        Me.tbbtnDelete.ImageIndex = 4
        Me.tbbtnDelete.Name = "tbbtnDelete"
        Me.tbbtnDelete.Text = "ɾ��"
        Me.tbbtnDelete.ToolTipText = "ɾ��"
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
        'tbbtnlist
        '
        Me.tbbtnlist.ImageIndex = 10
        Me.tbbtnlist.Name = "tbbtnlist"
        Me.tbbtnlist.Text = "�����嵥"
        Me.tbbtnlist.ToolTipText = "���ر������䵥"
        '
        'tbbtnQuit
        '
        Me.tbbtnQuit.ImageIndex = 7
        Me.tbbtnQuit.Name = "tbbtnQuit"
        Me.tbbtnQuit.Text = "�˳�"
        Me.tbbtnQuit.ToolTipText = "�˳�"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabTALLY_LIST)
        Me.TabControl1.Controls.Add(Me.TabDaily)
        Me.TabControl1.Controls.Add(Me.TabCertificate)
        Me.TabControl1.Controls.Add(Me.TabDailyDx)
        Me.TabControl1.Location = New System.Drawing.Point(6, 124)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(460, 297)
        Me.TabControl1.TabIndex = 15
        '
        'TabTALLY_LIST
        '
        Me.TabTALLY_LIST.Controls.Add(Me.Panel1)
        Me.TabTALLY_LIST.Controls.Add(Me.C1DBGTally_List)
        Me.TabTALLY_LIST.Location = New System.Drawing.Point(4, 22)
        Me.TabTALLY_LIST.Name = "TabTALLY_LIST"
        Me.TabTALLY_LIST.Size = New System.Drawing.Size(452, 271)
        Me.TabTALLY_LIST.TabIndex = 0
        Me.TabTALLY_LIST.Text = "���䵥"
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
        Me.Panel1.Size = New System.Drawing.Size(218, 205)
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
        Me.Label3.Text = "��ʼʱ��"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(97, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "�ڼ�����Ϣ�޸�"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(97, 101)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "ҹ����Ϣ�޸�"
        '
        'chkjjr
        '
        Me.chkjjr.Location = New System.Drawing.Point(15, 66)
        Me.chkjjr.Name = "chkjjr"
        Me.chkjjr.Size = New System.Drawing.Size(62, 24)
        Me.chkjjr.TabIndex = 2
        Me.chkjjr.Text = "�ڼ���"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(131, 164)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 35)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "����"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(97, 135)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "������Ϣ�޸�"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(61, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "����"
        '
        'chkyb
        '
        Me.chkyb.Location = New System.Drawing.Point(17, 101)
        Me.chkyb.Name = "chkyb"
        Me.chkyb.Size = New System.Drawing.Size(62, 24)
        Me.chkyb.TabIndex = 2
        Me.chkyb.Text = "ҹ��"
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
        Me.Label4.Text = "����ʱ��"
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
        Me.C1DBGTally_List.Size = New System.Drawing.Size(452, 271)
        Me.C1DBGTally_List.TabIndex = 11
        Me.C1DBGTally_List.Text = "C1DBG"
        Me.C1DBGTally_List.PropBag = resources.GetString("C1DBGTally_List.PropBag")
        '
        'TabDaily
        '
        Me.TabDaily.Controls.Add(Me.C1DBGDaily_report)
        Me.TabDaily.Location = New System.Drawing.Point(4, 22)
        Me.TabDaily.Name = "TabDaily"
        Me.TabDaily.Size = New System.Drawing.Size(452, 271)
        Me.TabDaily.TabIndex = 4
        Me.TabDaily.Text = "�ձ�"
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
        Me.C1DBGDaily_report.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGDaily_report.Name = "C1DBGDaily_report"
        Me.C1DBGDaily_report.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGDaily_report.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGDaily_report.PreviewInfo.ZoomFactor = 75
        Me.C1DBGDaily_report.PrintInfo.PageSettings = CType(resources.GetObject("C1DBGDaily_report.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBGDaily_report.Size = New System.Drawing.Size(452, 271)
        Me.C1DBGDaily_report.TabIndex = 12
        Me.C1DBGDaily_report.Text = "C1DBG"
        Me.C1DBGDaily_report.PropBag = resources.GetString("C1DBGDaily_report.PropBag")
        '
        'TabCertificate
        '
        Me.TabCertificate.Controls.Add(Me.C1DBGCertificate)
        Me.TabCertificate.Location = New System.Drawing.Point(4, 22)
        Me.TabCertificate.Name = "TabCertificate"
        Me.TabCertificate.Size = New System.Drawing.Size(452, 271)
        Me.TabCertificate.TabIndex = 1
        Me.TabCertificate.Text = "���ҵ��ƾ֤"
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
        Me.C1DBGCertificate.Size = New System.Drawing.Size(452, 271)
        Me.C1DBGCertificate.TabIndex = 12
        Me.C1DBGCertificate.Text = "C1DBG"
        Me.C1DBGCertificate.PropBag = resources.GetString("C1DBGCertificate.PropBag")
        '
        'TabDailyDx
        '
        Me.TabDailyDx.Controls.Add(Me.C1DBGDaily_report_dx)
        Me.TabDailyDx.Location = New System.Drawing.Point(4, 22)
        Me.TabDailyDx.Name = "TabDailyDx"
        Me.TabDailyDx.Size = New System.Drawing.Size(452, 271)
        Me.TabDailyDx.TabIndex = 5
        Me.TabDailyDx.Text = "�����ձ�"
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
        Me.C1DBGDaily_report_dx.Size = New System.Drawing.Size(452, 271)
        Me.C1DBGDaily_report_dx.TabIndex = 13
        Me.C1DBGDaily_report_dx.Text = "C1DBG"
        Me.C1DBGDaily_report_dx.PropBag = resources.GetString("C1DBGDaily_report_dx.PropBag")
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
        'FrmCon_Onport
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(644, 424)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.GBV)
        Me.Menu = Me.MainMenu
        Me.Name = "FrmCon_Onport"
        Me.Text = "��װ������ֳ�����"
        Me.GBV.ResumeLayout(False)
        Me.GBV.PerformLayout()
        CType(Me.C1DBGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB.ResumeLayout(False)
        Me.GB.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
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
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim dsShip As New DataSet   '�������ݼ�
    Dim SqlStrShip As String  '�����������
    'Dim ds_sship As DataSet
    Dim FirmShip As String
    Dim SortShip As String
    Dim inoutstr As String

    Dim dsTally_List As New DataSet  '������
    Dim dsWait As New DataSet        '��ʱ��¼
    Dim dsWork_Record As New DataSet '�ֳ���¼
    Dim dsMeasure As New DataSet     '������ 

    Dim SqlStr As String  '�������
    Dim SelectStr As String
    Dim DynaStr As String '�ɱ���������
    Dim FirmStr As String '������������
    ', FirmTally, FirmWait, FirmWorkRecord, FirmMeasure, FirmDaily
    Dim ColNum As Integer '����ʾ������
    Dim io As String '������
    Dim dvFieldName As DataView '�ֶα��������ͼ

    Private Sub FrmCon_Onport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Text = Me.Text & "_" & G_DeptName
        SortShip = "  Order by Ship_Statu,Dept_Code,id desc "   'Ĭ�ϵ����� 
        FirmShip = "where DEPT_CODE LIKE '" & G_DeptCode & "%'" '����������������
        SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','0')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) "
        Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '*****************���ú�����Ϣ
        Me.C1DBGV.SelectedStyle.BackColor = Color.CornflowerBlue
        txtShipName.Text = G_ShipName
        txtVoyage.Text = G_Voyage
        Call btResure_Click(sender, e)

        Panel1.Top = Panel1.Top + 30
        Panel1.Left = C1DBGTally_List.Width - Panel1.Width - 30
    End Sub

    Private Sub myDataGridShip(ByVal Sql As String) '**************������Ϣ
        Dim strsql As String
        Dim i As Integer
        strsql = "select SHIP_ID as ID ,SHIP_STATU,INOUTPORT,DEPT_CODE,ENG_VESSEL,CHI_VESSEL,VOYAGE,InOutPort_Name,Dept_Short from View_SSHip " '����������� ���Ĳ���
        strsql = strsql & Sql
        Try
            Me.C1DBGV.DataSource = Getdata(strsql, dsShip)
            For i = 0 To 4 '��Ʋ���ʾ����
                Me.C1DBGV.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Call SetColumnCaptionShip()      '����б���
            Call SetColumnWidthShip()        '����п��
            If dsShip.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumShip(5)     '��ƺϼ���
            End If
            Me.C1DBGV.FetchRowStyles = True
            Me.C1DBGV.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnCaptionShip() '*****************���α���
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

    Private Sub SetColumnWidthShip() '************�����п�
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

    Private Sub SetColumnSumShip(ByVal Col As Integer) '****************���λ�����
        Me.C1DBGV.ColumnFooters = True
        Me.C1DBGV.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGV.Columns.Item(Col).FooterText = "�� " & dsShip.Tables(0).Rows.Count & " ��"
    End Sub

    Private Sub ToolBarV_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBarV.ButtonClick
        Select Case Me.ToolBarV.Buttons.IndexOf(e.Button)
            Case 1
                SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','0')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) " '�����ɱ���������
                If G_User_Serial = "WLGCH" Then
                    SqlStrShip = "where DEPT_CODE LIKE '" & G_DeptCode & "%' "
                End If
                SortShip = "  Order by Ship_Statu,Dept_Code,id desc  "
                Call myDataGridShip(SqlStrShip & inoutstr & SortShip)
            Case 3
                Dim FrmFind As New FrmFind
                Table_Name = "SSHIP"
                FrmFind.ShowDialog()
                If Flag = 0 Then
                    Call myDataGridShip(FirmShip & inoutstr & " and (" & Sql_Find & ")  " & SortShip)    '����Ҫ�޸�
                    SqlStrShip = FirmStr & " and (" & Sql_Find & ")  "    '����Ҫ�޸�
                ElseIf Flag = 2 Then
                    SqlStrShip = "where ((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','4','0')) OR (Ship_Statu in ('1') and len(ltrim(BerthNo))=0)) "
                    '����Ҫ�޸�
                    Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '����Ҫ�޸�
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
                    Call SetColumnSumShip(4)  '��ƺϼ���
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

        Panel1.Visible = False
        Ship_ID = CType(Me.C1DBGV.Columns.Item("ID").Text.ToString, Integer)
        strsql = "select * from View_SSHIP where SHIP_ID=" & Ship_ID
        dw = Getdata(strsql, dsShip)
        Label.Text = ""
        If dsShip.Tables(0).DefaultView.Count > 0 Then
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))) > 0 Then
                Label.Text = Label.Text & "���Ĵ���:" & Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL")) & " "
                G_ShipName = Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))
                txtShipName.Text = Trim(dsShip.Tables(0).Rows(0).Item("CHI_VESSEL"))
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL"))) > 0 Then
                Label.Text = Label.Text & "Ӣ�Ĵ���:" & Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL")) & " "
                G_ShipName_Eng = Trim(dsShip.Tables(0).Rows(0).Item("ENG_VESSEL"))
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))) > 0 Then
                Label.Text = Label.Text & "����:" & Trim(dsShip.Tables(0).Rows(0).Item("Voyage")) & " "
                G_Voyage = Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))
                txtVoyage.Text = Trim(dsShip.Tables(0).Rows(0).Item("Voyage"))
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("InOutPort_Name"))) > 0 Then
                Label.Text = Label.Text & "������:" & Trim(dsShip.Tables(0).Rows(0).Item("InOutPort_Name")) & " "
                If dsShip.Tables(0).Rows(0).Item("InOutPort_Name") = "����" Then
                    io = "0"
                    Hatch_in = 0
                Else
                    io = "1"
                    Hatch_in = 1
                End If
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Trade"))) > 0 Then
                Label.Text = Label.Text & "����ó:" & Trim(dsShip.Tables(0).Rows(0).Item("Trade")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("SHIP_TYPE"))) > 0 Then
                Label.Text = Label.Text & "������:" & Trim(dsShip.Tables(0).Rows(0).Item("SHIP_TYPE")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("SHIPAGENT_CHAE"))) > 0 Then
                Label.Text = Label.Text & "����:" & Trim(dsShip.Tables(0).Rows(0).Item("SHIPAGENT_CHA")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("GOODS"))) > 0 Then
                Label.Text = Label.Text & "����:" & Trim(dsShip.Tables(0).Rows(0).Item("GOODS")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("Tons"))) > 0 Then
                Label.Text = Label.Text & "����:" & Trim(dsShip.Tables(0).Rows(0).Item("Tons")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("BerthNo"))) > 0 Then
                Label.Text = Label.Text & "��λ:" & Trim(dsShip.Tables(0).Rows(0).Item("BerthNo")) & " "
            End If
            If Len(Trim(dsShip.Tables(0).Rows(0).Item("File_No"))) > 0 Then
                Label.Text = Label.Text & "������:" & Trim(dsShip.Tables(0).Rows(0).Item("File_No")) & " "
            End If
        End If
        FirmStr = "  Ship_ID=" & Ship_ID & " Order by ID " '��Ƴ�ʼ����  �ڼ����󲻸ı������  '***************Ҫ�޸� �� 2>1
        DynaStr = " 2>1 " '���������ʼ����    �ڼ�������Ҫ������ ***************Ҫ�޸� �� ��������
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
        Call preview("WL4_1") '*****************Ȩ����� '*************Ҫ�޸�ģ���
        'Call TabControl1_TabIndexChanged(sender, e)
        Call TabControl1_Click(sender, e)

        Call getTallylist(FirmStr)    '���䵥
        dsdaily.Reset()               '�ձ�
        dsdailydx.Reset()             '�����ձ�
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
        'dw = Getdata(" exec spcon_certificate_eng '" & Ship_ID & "'", DS_DO)  '���ƾ֤
        'Call getCertificate()
        GetCertificate2015()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub getTallylist(ByVal Sql As String)
        Dim strsql As String
        Dim i As Integer
        Try
            '����ʾ����������ǰ��
            strsql = "select  *  from VIEW_CON_TALLY_LIST  where " & Sql '******Ҫ�޸�

            Me.C1DBGTally_List.DataSource = Getdata(strsql, dsTally_List)  ' class dbcontrol getdata fuction
            ColNum = 2 '����ʾ������ '******Ҫ�޸�
            Table_Name = "VIEW_CON_TALLY_LIST" '���������ݿ���� ''******Ҫ�޸�

            For i = 0 To ColNum - 1 '��Ʋ���ʾ����
                Me.C1DBGTally_List.Splits(0).DisplayColumns.Item(i).Visible = False
            Next

            'For i = ColNum - 1 To C1DBGTally_List.Columns.Count - 1
            '    Me.C1DBGTally_List.Columns(i).FilterDropdown = True
            'Next
            Me.C1DBGTally_List.Columns("team_no").FilterDropdown = True
            Me.C1DBGTally_List.Columns.Item("date").NumberFormat = "yyyy/MM/dd"

            Call SetColumnCaptionTally_List() '����б���
            Call SetColumnWidthTally_list() '����п��
            If dsTally_List.Tables(0).Rows.Count > 0 Then
                Call SetColumnSumTally_List(Sql) '��ƺϼ���
            End If
            ' Me.C1DBG.FetchRowStyles = True
            Me.C1DBGTally_List.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub getCertificate()
    '    Dim strsql As String
    '    Dim i As Integer
    '    Try
    '        C1DBGCertificate.Visible = True
    '        C1DBGCertificate.DataSource = DS_DO.Tables(0).DefaultView
    '        C1DBGCertificate.Refresh()
    '        Me.C1DBGCertificate.Columns.Item("c20f").Caption = "20Ӣ������"
    '        Me.C1DBGCertificate.Columns.Item("c40f").Caption = "40Ӣ������"
    '        Me.C1DBGCertificate.Columns.Item("etcf").Caption = "��������"
    '        Me.C1DBGCertificate.Columns.Item("c20e").Caption = "20Ӣ�߿���"
    '        Me.C1DBGCertificate.Columns.Item("c40e").Caption = "40Ӣ�߿���"
    '        Me.C1DBGCertificate.Columns.Item("etce").Caption = "��������"
    '        Call SetColumnWidthCertificate()
    '        Me.C1DBGCertificate.Refresh()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Dim dsCer As DataSet
    Dim dvCer As DataView
    Dim dvWaitTime As DataView
    ''' <summary>
    ''' 201501���ƾ֤������ó���� ��
    ''' </summary>
    Private Sub GetCertificate2015()
        Dim strsql As String
        Dim i As Integer
        Try
            strsql = "select TradeMark,InOut_Mark,Reload ,Case TradeMark when '1' then '��ó' end TradeDesc," & _
                " Case InOut_Mark+Reload when '10' then 'The Shiftting' when '01' then 'Reload' when '11' then '������װ' end OutReloadDesc," & _
                " FullOrEmpty,Size_Con,Count(*) ConSum,Sum(Cast(Holiday as int)) HolidaySum,Sum(Cast(Night_Mark as int)) NightSum" & _
                " from V_ConTallyForStat where Ship_ID=" & Ship_ID & " group by TradeMark,InOut_Mark,Reload,FullOrEmpty,Size_Con " & _
                " order by TradeMark,InOut_Mark,Reload,FullOrEmpty desc,Size_Con"
            dsCer = New DataSet
            dvCer = DBControl.Getdata2(strsql, dsCer)
            For i = 0 To dvCer.Count - 1
                If dvCer(i)("HolidaySum").ToString() = "0" Then
                    dvCer(i)("HolidaySum") = DBNull.Value
                End If
                If dvCer(i)("NightSum").ToString() = "0" Then
                    dvCer(i)("NightSum") = DBNull.Value
                End If
            Next
            C1DBGCertificate.Visible = True
            C1DBGCertificate.AllowSort = False
            C1DBGCertificate.DataSource = dvCer
            Me.C1DBGCertificate.Splits(0).DisplayColumns("TradeMark").Visible = False
            Me.C1DBGCertificate.Splits(0).DisplayColumns("InOut_Mark").Visible = False
            Me.C1DBGCertificate.Splits(0).DisplayColumns("Reload").Visible = False
            Me.C1DBGCertificate.Columns("ConSum").Caption = "������"
            Me.C1DBGCertificate.Columns("HolidaySum").Caption = "�ڼ���"
            Me.C1DBGCertificate.Columns("NightSum").Caption = "ҹ��"
            Me.C1DBGCertificate.Columns("TradeDesc").Caption = "ó��"
            Me.C1DBGCertificate.Columns("OutReloadDesc").Caption = "���"
            Me.C1DBGCertificate.Columns("FullOrEmpty").Caption = "�����"
            Me.C1DBGCertificate.Columns("Size_Con").Caption = "�����"
            Dim sqlWaitTime As String = "select convert(int,round(" & _
                "sum(" & _
                "datediff(minute," & _
                "convert(varchar(10),STANDBYDATE,102)+' '+left(time_from,2)+':'+right(time_from,2)," & _
                "convert(varchar(10),STANDBYDATE,102)+' '+left(time_to,2)+':'+right(time_to,2))" & _
                ")/60.00+0.49," & _
                "0)) " & _
                "from cargo_waitfor where ship_id=" & Ship_ID
            dvWaitTime = Filldata(sqlWaitTime)
            If dvWaitTime.Count > 0 AndAlso dvWaitTime(0)(0).ToString().Length > 0 Then
                LabREMARKS.Text = "��ʱ��" & dvWaitTime(0)(0).ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub getDaily_Report()
        Dim strsql As String
        Dim i As Integer
        Try
            '����ʾ����������ǰ��
            'strsql = "select " & SelStr & " *  from VIEW_CARGO_WAITFOR  where " & Sql '******Ҫ�޸�
            Me.C1DBGDaily_report.DataSource = dsdaily.Tables(0).DefaultView
            LabREMARKS.Text = REMARKS & "    " & GL_Teu
            'Me.C1DBG.DataSource = Getdata(strsql, ds)  ' class dbcontrol getdata fuction
            ColNum = 0 '����ʾ������ '******Ҫ�޸�
            Table_Name = "SPCON_DAILY_REPORT" '���������ݿ���� ''******Ҫ�޸�

            For i = 0 To ColNum - 1 '��Ʋ���ʾ����
                Me.C1DBGDaily_report.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Me.C1DBGDaily_report.Columns.Item(0).Caption = "��Ŀ"
            Me.C1DBGDaily_report.Columns.Item(1).Caption = "20����"
            Me.C1DBGDaily_report.Columns.Item(2).Caption = "20�ض�"
            Me.C1DBGDaily_report.Columns.Item(3).Caption = "40����"
            Me.C1DBGDaily_report.Columns.Item(4).Caption = "40�ض�"
            Me.C1DBGDaily_report.Columns.Item(5).Caption = "��������"
            Me.C1DBGDaily_report.Columns.Item(6).Caption = "�����ض�"
            Me.C1DBGDaily_report.Columns.Item(7).Caption = "20����"
            Me.C1DBGDaily_report.Columns.Item(8).Caption = "20�ն�"
            Me.C1DBGDaily_report.Columns.Item(9).Caption = "40����"
            Me.C1DBGDaily_report.Columns.Item(10).Caption = "40�ն�"
            Me.C1DBGDaily_report.Columns.Item(11).Caption = "��������"
            Me.C1DBGDaily_report.Columns.Item(12).Caption = "�����ն�"
            Me.C1DBGDaily_report.Columns.Item(13).Caption = "С����"
            Me.C1DBGDaily_report.Columns.Item(14).Caption = "С�ƶ�"

            Call SetColumnWidthDaily_Report() '����п��
            'If dsdaily.Tables(0).Rows.Count > 0 Then
            '    Call SetColumnSum(Sql) '��ƺϼ���
            'End If
            'Me.C1DBG.FetchRowStyles = True
            Me.C1DBGDaily_report.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getDaily_Report_dx()
        Dim strsql As String
        Dim i As Integer
        Try
            '����ʾ����������ǰ��
            'strsql = "select " & SelStr & " *  from VIEW_CARGO_WAITFOR  where " & Sql '******Ҫ�޸�
            Me.C1DBGDaily_report_dx.DataSource = dsdailydx.Tables(0).DefaultView
            LabREMARKS.Text = REMARKSdx & "    " & GL_Teudx
            'Me.C1DBG.DataSource = Getdata(strsql, ds)  ' class dbcontrol getdata fuction
            ColNum = 0 '����ʾ������ '******Ҫ�޸�
            Table_Name = "SPCON_DAILY_REPORT" '���������ݿ���� ''******Ҫ�޸�

            For i = 0 To ColNum - 1 '��Ʋ���ʾ����
                Me.C1DBGDaily_report_dx.Splits(0).DisplayColumns.Item(i).Visible = False
            Next
            Me.C1DBGDaily_report_dx.Columns.Item(0).Caption = "��Ŀ"
            Me.C1DBGDaily_report_dx.Columns.Item(1).Caption = "20����"
            Me.C1DBGDaily_report_dx.Columns.Item(2).Caption = "20�ض�"
            Me.C1DBGDaily_report_dx.Columns.Item(3).Caption = "40����"
            Me.C1DBGDaily_report_dx.Columns.Item(4).Caption = "40�ض�"
            Me.C1DBGDaily_report_dx.Columns.Item(5).Caption = "��������"
            Me.C1DBGDaily_report_dx.Columns.Item(6).Caption = "�����ض�"
            Me.C1DBGDaily_report_dx.Columns.Item(7).Caption = "20����"
            Me.C1DBGDaily_report_dx.Columns.Item(8).Caption = "20�ն�"
            Me.C1DBGDaily_report_dx.Columns.Item(9).Caption = "40����"
            Me.C1DBGDaily_report_dx.Columns.Item(10).Caption = "40�ն�"
            Me.C1DBGDaily_report_dx.Columns.Item(11).Caption = "��������"
            Me.C1DBGDaily_report_dx.Columns.Item(12).Caption = "�����ն�"
            Me.C1DBGDaily_report_dx.Columns.Item(13).Caption = "С����"
            Me.C1DBGDaily_report_dx.Columns.Item(14).Caption = "С�ƶ�"

            Call SetColumnWidthDaily_Reportdx() '����п��
            'If dsdaily.Tables(0).Rows.Count > 0 Then
            '    Call SetColumnSum(Sql) '��ƺϼ���
            'End If
            'Me.C1DBG.FetchRowStyles = True
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
            str = "select Field_Eng,Field_Cha,Field_Type,IsOrNoSum From Field_Att where Table_Name='" & Table_Name & "'"
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
            dvFieldName = dset.Tables(0).DefaultView
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


    Private Sub SetColumnSumTally_List(ByVal sql As String)
        dvFieldName.RowFilter = "Field_Type ='N' and IsOrNoSum='1'"
        Me.C1DBGTally_List.ColumnFooters = True
        Me.C1DBGTally_List.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBGTally_List.Columns.Item(ColNum).FooterText = "�ϼ� "
        Me.C1DBGTally_List.Columns.Item(ColNum + 1).FooterText = "�� " & dsTally_List.Tables(0).Rows.Count & "��"
        Dim i As Integer
        Dim j As Integer
        Dim nSum As Decimal
        For i = 0 To dvFieldName.Count - 1
            For j = ColNum + 2 To dsTally_List.Tables(0).Columns.Count - 1
                If dvFieldName(i)("Field_Eng").ToString().ToUpper() = dsTally_List.Tables(0).Columns(j).ToString().ToUpper() Then
                    nSum = DBControl.GetDataSum(dsTally_List.Tables(0).DefaultView, dsTally_List.Tables(0).Columns(j).Caption)
                    C1DBGTally_List.Columns(j).FooterText = nSum
                End If
            Next
        Next
    End Sub

    Private Sub mnuQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuit.Click
        Me.Close()
    End Sub

    Private Sub ToolBar_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar.ButtonClick
        Select Case Me.ToolBar.Buttons.IndexOf(e.Button)
            Case 0
                Call mnuFind_Click(sender, e)
            Case 1
                Select Case Me.TabControl1.SelectedIndex
                    Case 0
                        Try
                            'Dim frm As New FRMCON_TALLY_LIST_DOPRINT
                            'frm.ShowDialog()

                            'GroupBox1.Visible = Not (GroupBox1.Visible)
                            Panel1.Visible = Not (Panel1.Visible)

                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                    Case 1
                        Dim frm As New FrmCON_DAILY_REPORT_DO
                        frm.ShowDialog()
                        If OKMARK = 1 Then
                            Call getDaily_Report()
                        End If
                    Case 3
                        Dim frm As New FrmCON_DAILY_REPORT_DO_other
                        frm.ShowDialog()
                        If OKMARKdx = 1 Then
                            Call getDaily_Report_dx()
                        End If
                End Select
            Case 2
                Try
                    Dim frm As New FRMCON_TALLY_LIST_FIND
                    frm.ShowDialog()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case 3
                Call mnuQuery_Click(sender, e)
            Case 4
                Call mnuAdd_Click(sender, e)
            Case 5
                Call mnuEdit_Click(sender, e)
            Case 6
                Call mnuDelete_Click(sender, e)
            Case 7
                Call mnuPrint_Click(sender, e)
            Case 8
                Call mnuExport_Click(sender, e)
            Case 9
                exportconlist()
            Case 10
                Me.Close()
        End Select
    End Sub

    Private Sub mnuFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFind.Click
        Dim FrmFind As New FrmFind
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                Table_Name = "VIEW_CON_TALLY_LIST" '����Ҫ�޸�
                FrmFind.ShowDialog()

                If Flag = 0 Then
                    SelectStr = ""
                    Call getTallylist(" (" & Sql_Find & ")  " & FirmStr)   '����Ҫ�޸�
                    SqlStr = " (" & Sql_Find & ")  " & FirmStr '����Ҫ�޸�
                ElseIf Flag = 2 Then
                    SelectStr = ""
                    Call getTallylist(DynaStr & FirmStr)   '����Ҫ�޸�
                    SqlStr = DynaStr & FirmStr '����Ҫ�޸�
                End If
        End Select
    End Sub

    Private Sub mnuDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDelete.Click
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                If dsTally_List.Tables(0).Rows.Count > 0 Then
                    Dim FrmDelete As New FRMCON_TALLY_LIST_DELETE  '***********Ҫ�޸�
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
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                If dsTally_List.Tables(0).Rows.Count > 0 Then
                    Dim FrmEdit As New FRMCON_TALLY_LIST_EDIT  '***********Ҫ�޸�
                    Dim Row As Integer
                    ID = CType(Me.C1DBGTally_List.Columns.Item("ID").Text.ToString, Integer)
                    Row = Me.C1DBGTally_List.Row
                    FrmEdit.ShowDialog()
                    Try
                        Call getTallylist(SqlStr)
                        Me.C1DBGTally_List.Row = Row
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
        End Select
    End Sub

    Private Sub mnuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdd.Click
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                Dim FrmAdd As New FRMCON_TALLY_LIST_ADD   '***********Ҫ�޸�
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
                    Dim FrmQuery As New FRMCON_TALLY_LIST_QUERY  '***********Ҫ�޸�
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
                'If DS_DO.Tables(0).Rows.Count > 0 Then
                '    Call eng_new()
                'End If
                If dvCer.Count > 0 Then
                    DealCertificate()
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
                'If DS_DO.Tables(0).Rows.Count > 0 Then
                '    Call eng_new()
                'End If
                If dvCer.Count > 0 Then
                    DealCertificate()
                End If
            Case 3
                If dsdailydx.Tables(0).Rows.Count > 0 Then
                    Call Daily_Report_eng_dx_new()
                End If
        End Select
        'Call ExportExcel()
    End Sub

    Private Sub ExportExcel() '����Excel        
        Call MakeExcelTally_List()
    End Sub

    Private Sub PrintExcelTally_List() '��ӡ��Excel        
        Dim frm As New FRMCON_TALLY_LIST_PRINT
        frm.ShowDialog()
    End Sub

    Private Sub PrintExcelCertificate() '��ӡ��Excel        
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

    Private Sub PrintExcelDaily_report() '��ӡ��Excel        
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

    '��ӡ���ҵ��ƾ֤
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
                If MsgBox("�Ƿ񵼳�������Ϣ��", MsgBoxStyle.YesNo, "��ʾ") = MsgBoxResult.Yes Then
                    dx = 1
                End If
            End If
            If DS_DO.Tables(4).Rows(0)(0) > 0 Then
                If MsgBox("�Ƿ񵼳�ʵ��������ݣ�", MsgBoxStyle.YesNo, "��ʾ") = MsgBoxResult.Yes Then
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
            xlsheet = CType(xlbook.Worksheets("���ҵ��ƾ֤"), Excel.Worksheet)
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
                If DS_DO.Tables(1).Rows(0)(t) = 1 Then
                    remarks = remarks & DS_DO.Tables(1).Rows(0)(t) & " CONT tallied on SAT/SUN/HOLDY"
                End If
                If DS_DO.Tables(1).Rows(0)(t) > 1 Then
                    remarks = remarks & DS_DO.Tables(1).Rows(0)(t) & " CONTS tallied on SAT/SUN/HOLDY"
                End If
                If DS_DO.Tables(1).Rows(0)(t + 6) = 1 Then
                    remarks = remarks & "   " & DS_DO.Tables(1).Rows(0)(t + 6) & " CONT tallied at night shift"
                End If
                If DS_DO.Tables(1).Rows(0)(t + 6) > 1 Then
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
            '    If MsgBox("�Ƿ񵼳�������Ϣ��", MsgBoxStyle.YesNo, "��ʾ") = MsgBoxResult.Yes Then
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

    '����ҵ��ƾ֤Excel 201501������ó ��
    Private Sub DealCertificate()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim remarks As String
        Dim t, col, row, dx, plan As Integer
        Try
            Dim blInTrade As Boolean = False
            Dim iStart As Integer = 0
            Dim iEnd As Integer = C1DBGCertificate.RowCount
            Dim i, j As Integer
            Dim iOutReloadSum As Integer
            Dim strOutReloadDesc As String
            Dim strOutReloadName As String = ""
            Dim strTemp As String = ""
            Dim strHoliday, strNight As String

            '�����ó������ó��
            If C1DBGCertificate.Columns("TradeMark").Text = "1" Then
                blInTrade = True
            End If
            '��ó��ȷ��ͳ��������ֹλ��
            For i = 0 To C1DBGCertificate.RowCount - 1
                If C1DBGCertificate.Columns("TradeMark").CellText(i) = "1" Then
                    If blInTrade Then
                        iStart = i
                    Else
                        iEnd = i
                    End If
                    Exit For
                End If
            Next
            '��鵷���Ƿ����
            dx = 0
            For i = iStart To iEnd - 1
                If C1DBGCertificate.Columns("OutReloadDesc").CellText(i) <> "" Then
                    dx = 1
                    Exit For
                End If
            Next
            '�Ƿ񵼳�������Ϣ
            If dx > 0 Then
                If MsgBox("�Ƿ񵼳�������Ϣ��", MsgBoxStyle.YesNo, "��ʾ") = MsgBoxResult.Yes Then
                    dx = 1
                Else
                    dx = 0
                End If
            End If
            RecordExcelProcess()
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "Report_gonglei.xls", pathstr + "Report.xls")
            Filepath = pathstr + "report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("���ҵ��ƾ֤"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            If GL_Print = 1 Then
                xlsheet.Application.Visible = False
            Else
                xlsheet.Application.Visible = True
            End If
            xlsheet.Select()

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
            For i = iStart To iEnd - 1
                If dvCer(i)("OutReloadDesc").ToString() = "" Then
                    '�ڼ��� ҹ�����ݴ���
                    strHoliday = ""
                    strNight = ""
                    If dvCer(i)("HolidaySum").ToString() <> "" Then
                        strHoliday = dvCer(i)("HolidaySum").ToString() & " CONTS tallied on SAT/SUN/HOLDY"
                    End If
                    If dvCer(i)("HolidaySum").ToString() = "1" Then
                        strHoliday = strHoliday.Replace("CONTS", "CONT")
                    End If
                    If dvCer(i)("NightSum").ToString() <> "" Then
                        strNight = dvCer(i)("NightSum").ToString() & " CONTS tallied at night shift"
                    End If
                    If dvCer(i)("NightSum").ToString() = "1" Then
                        strNight = strNight.Replace("CONTS", "CONT")
                    End If
                    If strHoliday <> "" Then
                        remarks = strHoliday
                        If strNight <> "" Then
                            remarks &= "  " & strNight
                        End If
                    Else
                        remarks = strNight
                    End If
                    'excel������д
                    If dvCer(i)("FullOrEmpty").ToString() = "F" Then
                        If dvCer(i)("Size_Con").ToString() = "20" Then
                            xlsheet.Cells(20, 7) = dvCer(i)("ConSum").ToString()
                            xlsheet.Cells(20, 8) = "VAN"
                            If remarks <> "" Then xlsheet.Cells(20, "I") = remarks
                        ElseIf dvCer(i)("Size_Con").ToString() = "40" Then
                            xlsheet.Cells(21, 7) = dvCer(i)("ConSum").ToString()
                            xlsheet.Cells(21, 8) = "VAN"
                            If remarks <> "" Then xlsheet.Cells(21, "I") = remarks
                        Else
                            xlsheet.Cells(22, 7) = dvCer(i)("ConSum").ToString()
                            xlsheet.Cells(22, 8) = "VAN"
                            If remarks <> "" Then xlsheet.Cells(22, "I") = remarks
                        End If
                    Else
                        If dvCer(i)("Size_Con").ToString() = "20" Then
                            xlsheet.Cells(23, 7) = dvCer(i)("ConSum").ToString()
                            xlsheet.Cells(23, 8) = "VAN"
                            If remarks <> "" Then xlsheet.Cells(23, "I") = remarks
                        ElseIf dvCer(i)("Size_Con").ToString() = "40" Then
                            xlsheet.Cells(24, 7) = dvCer(i)("ConSum").ToString()
                            xlsheet.Cells(24, 8) = "VAN"
                            If remarks <> "" Then xlsheet.Cells(24, "I") = remarks
                        Else
                            xlsheet.Cells(25, 7) = dvCer(i)("ConSum").ToString()
                            xlsheet.Cells(25, 8) = "VAN"
                            If remarks <> "" Then xlsheet.Cells(25, "I") = remarks
                        End If
                    End If
                Else
                    iOutReloadSum += Convert.ToInt32(dvCer(i)("ConSum"))
                    strOutReloadDesc += dvCer(i)("Size_Con").ToString() & "'" & dvCer(i)("FullOrEmpty").ToString() & "x" & dvCer(i)("ConSum").ToString() & " "
                    If strTemp <> dvCer(i)("OutReloadDesc").ToString() Then
                        strTemp = dvCer(i)("OutReloadDesc").ToString()
                        strOutReloadName &= " " & strTemp
                    End If
                End If
            Next

            If dvWaitTime.Count > 0 AndAlso dvWaitTime(0)(0).ToString().Length > 0 Then
                xlsheet.Cells(32, 7) = dvWaitTime(0)(0).ToString()
            End If
            If dx = 1 Then
                xlsheet.Cells(33, 3) = strOutReloadName
                xlsheet.Cells(33, 7) = iOutReloadSum
                xlsheet.Cells(33, 8) = "VAN"
                xlsheet.Cells(33, 9) = strOutReloadDesc
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
    '��ӡ�ձ�
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
            xlsheet = CType(xlbook.Worksheets("��װ���ձ�"), Excel.Worksheet)
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

    '��ӡ�����ձ�
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
            xlsheet = CType(xlbook.Worksheets("��װ���ձ�"), Excel.Worksheet)
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
            xlsheet = CType(xlbook.Worksheets("���ҵ��ƾ֤"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = True

            xlsheet.Cells(4, 1) = "������ " & ds_sship.Tables(0).Rows(0).Item("CHI_VESSEL")
            xlsheet.Cells(4, 4) = "���Σ� " & ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            xlsheet.Cells(4, 7) = "������ " & ds_sship.Tables(0).Rows(0).Item("NATIONALITY_CHA")
            'xlsheet.Cells(3, 5) = "��λ�� " & ds.Tables(1).Rows(0).Item("berth")
            If IsDBNull(ds_sship.Tables(0).Rows(0).Item("worktime_begin")) Then
            Else
                xlsheet.Cells(5, 1) = "�������ڣ�" & Year(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")) & "��" & Month(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")) & "��" & Day(ds_sship.Tables(0).Rows(0).Item("WORKTIME_BEGIN")) & "��"

            End If
            xlsheet.Cells(5, 6) = "�Ƶ����ڣ�" & Year(Now) & "��" & Month(Now) & "��" & Day(Now) & "��"

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

            xlsheet.Cells(11, 6) = "��"
            xlsheet.Cells(12, 6) = "��"
            xlsheet.Cells(13, 6) = "��"
            xlsheet.Cells(14, 6) = "��"
            xlsheet.Cells(15, 6) = "��"
            xlsheet.Cells(16, 6) = "��"

            xlsheet.Cells(22, 5) = DS_DO.Tables(1).Rows(0)(0)
            'For row = 7 To ds.Tables(1).Rows.Count + 7 '*����
            '    xlsheet.Range(xlsheet.Cells(row, 1), xlsheet.Cells(row, 19)).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = 7
            'Next row
            'For col = 1 To 19 '* ����
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
            xlsheet = CType(xlbook.Worksheets("���ҵ��ƾ֤Ӣ�İ�"), Excel.Worksheet)
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
            xlsheet = CType(xlbook.Worksheets("��װ���ձ���C��"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            xlsheet.Application.Visible = True

            xlsheet.Cells(8, 2) = ds_sship.Tables(0).Rows(0).Item("CHI_VESSEL")
            xlsheet.Cells(8, 6) = ds_sship.Tables(0).Rows(0).Item("VOYAGE")
            xlsheet.Cells(8, 8) = dsdaily.Tables(1).Rows(0).Item("berth")

            xlsheet.Cells(8, 11) = Year(dsdaily.Tables(2).Rows(0).Item("timefrom")) & "��" & dsdaily.Tables(2).Rows(0).Item("monthfrom") & "��" & dsdaily.Tables(2).Rows(0).Item("dayfrom") & "�� " & dsdaily.Tables(2).Rows(0).Item("hourfrom") & "ʱ" & dsdaily.Tables(2).Rows(0).Item("minfrom") & "��"
            xlsheet.Cells(10, 11) = Year(dsdaily.Tables(3).Rows(0).Item("timeto")) & "��" & dsdaily.Tables(3).Rows(0).Item("monthto") & "��" & dsdaily.Tables(3).Rows(0).Item("dayto") & "�� " & dsdaily.Tables(3).Rows(0).Item("hourto") & "ʱ" & dsdaily.Tables(3).Rows(0).Item("minto") & "��"
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
            xlsheet = CType(xlbook.Worksheets("��װ���ձ���E��"), Excel.Worksheet)
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
            xlSheet.Cells(1, 1) = Me.Text() '����

            For Col = ColNum To Me.C1DBGTally_List.Columns.Count - 1 '�б���
                xlSheet.Cells(3, Col - ColNum + 1) = Me.C1DBGTally_List.Columns(Col).Caption

            Next Col
            Me.C1DBGTally_List.MoveFirst()
            For Row = 0 To dsTally_List.Tables(0).Rows.Count - 1 '����
                For Col = ColNum To Me.C1DBGTally_List.Columns.Count - 1
                    xlSheet.Cells(Row + 4, Col - ColNum + 1) = Me.C1DBGTally_List.Columns(Col).Text.ToString      'ds.Tables(0).Rows(Row)(Col)
                Next Col
                Me.C1DBGTally_List.MoveNext()
            Next Row
            If Me.C1DBGTally_List.ColumnFooters = True Then '�ϼ���
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

    Private Sub preview(ByVal Func As String) '***************Ȩ�����
        Dim sqlstr As String
        Dim Previewdv As DataView
        Dim Previewds As New DataSet
        Dim i As Integer
        sqlstr = " select FUNC_CODE_Add,FUNC_CODE_Change,FUNC_CODE_Del from View_UserPreview where PART_ID=" & G_Part_Id & " and FUNC_CODE='" & Upper(Func) & "' "
        Previewdv = Getdata(sqlstr, Previewds)
        If Previewdv.Count > 0 Then
            If Previewdv(i)("FUNC_CODE_Add") = 1 Then 'ADD ��ť�ɼ�
                ToolBar.Buttons.Item(4).Enabled = True
                mnuAdd.Enabled = True
            Else                                      'ADD ��ť���ɼ�
                Me.ToolBar.Buttons.Item(4).Enabled = False
                mnuAdd.Enabled = False
            End If
            If Previewdv(i)("FUNC_CODE_Change") = 1 Then '�޸� ��ť�ɼ�
                Me.ToolBar.Buttons.Item(5).Enabled = True
                mnuEdit.Enabled = True
            Else                                          '�޸� ��ť���ɼ�
                Me.ToolBar.Buttons.Item(5).Enabled = False
                mnuEdit.Enabled = False
            End If
            If Previewdv(i)("FUNC_CODE_Del") = 1 Then 'ɾ�� ��ť�ɼ�
                Me.ToolBar.Buttons.Item(6).Enabled = True
                mnuDelete.Enabled = True
            Else                                     'ɾ����ť���ɼ�
                Me.ToolBar.Buttons.Item(6).Enabled = False
                mnuDelete.Enabled = False
            End If
        End If

    End Sub

    Private Sub exportconlist()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer
        Dim strsql As String
        Dim dslist As New DataSet
        Dim dvlist As New DataView
        Dim dsshipinfo As New DataSet
        Dim dsconinfo As New DataSet
        Dim coninfo As String
        Try
            RecordExcelProcess()
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            FileCopy(pathstr + "Report_gonglei.xls", pathstr + "Report.xls")
            Filepath = pathstr + "report.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("�����嵥"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            'If GL_Print = 1 Then
            xlsheet.Application.Visible = False
            'Else
            '    xlsheet.Application.Visible = True
            'End If
            xlsheet.Select()

            Getdata("select * from  SSHIP where SHIP_ID=" & Ship_ID, dsshipinfo)
            strsql = " select CONTAINER_NO,SIZE_CON,FULLOREMPTY,SEALNO from CON_TALLY_DETAIL WHERE CON_TALLY_LIST_ID in (select CON_TALLY_LIST_ID from CON_TALLY_LIST where ship_id=" & Ship_ID & " and inout_mark=0 and reload=0 ) order by CONTAINER_NO"
            dvlist = Getdata(strsql, dslist)

            Dim i As Integer  '�ƶ�������
            Dim j As Integer  '������
            Dim q As Integer  '����

            If dvlist.Count = 0 Then
                Return
            End If
            If dvlist.Count < 101 Then
                xlsheet.Cells(4, 2) = dsshipinfo.Tables(0).Rows(0).Item("CHI_VESSEL")
                xlsheet.Cells(4, 7) = dsshipinfo.Tables(0).Rows(0).Item("Voyage")
                xlsheet.Cells(4, 11) = dsshipinfo.Tables(0).Rows(0).Item("BerthNo")
                xlsheet.Cells(5, 3) = dsshipinfo.Tables(0).Rows(0).Item("worktime_begin")
                xlsheet.Cells(5, 9) = dsshipinfo.Tables(0).Rows(0).Item("worktime_end")
                If io = 0 Then
                    xlsheet.Cells(2, 1) = "(����)"
                Else
                    xlsheet.Cells(2, 1) = "(����)"
                End If
                xlsheet.Cells(2, 12) = "'1/1"

                If dvlist.Count <= 50 Then
                    For row = 0 To dvlist.Count - 1
                        xlsheet.Cells(9 + row, 1) = dslist.Tables(0).Rows(row)("CONTAINER_NO")
                        'xlsheet.Cells(9 + row, 3) = dslist.Tables(0).Rows(row)("SEALNO")
                        xlsheet.Cells(9 + row, 3) = dslist.Tables(0).Rows(row)("SIZE_CON")
                        xlsheet.Cells(9 + row, 4) = dslist.Tables(0).Rows(row)("FULLOREMPTY")
                        If dslist.Tables(0).Rows(row)("FULLOREMPTY") = "E" Then
                            xlsheet.Cells(9 + row, 5) = "��������"
                        Else
                            xlsheet.Cells(9 + row, 5) = "OK"
                        End If
                    Next row
                Else
                    For row = 0 To 49
                        xlsheet.Cells(9 + row, 1) = dslist.Tables(0).Rows(row)("CONTAINER_NO")
                        'xlsheet.Cells(9 + row, 3) = dslist.Tables(0).Rows(row)("SEALNO")
                        xlsheet.Cells(9 + row, 3) = dslist.Tables(0).Rows(row)("SIZE_CON")
                        xlsheet.Cells(9 + row, 4) = dslist.Tables(0).Rows(row)("FULLOREMPTY")
                        If dslist.Tables(0).Rows(row)("FULLOREMPTY") = "E" Then
                            xlsheet.Cells(9 + row, 5) = "��������"
                        Else
                            xlsheet.Cells(9 + row, 5) = "OK"
                        End If
                    Next row
                    For row = 50 To dvlist.Count - 1
                        xlsheet.Cells(9 + row - 50, 1 + 6) = dslist.Tables(0).Rows(row)("CONTAINER_NO")
                        'xlsheet.Cells(9+row- 50 , 3+ 6) = dslist.Tables(0).Rows(row)("SEALNO")
                        xlsheet.Cells(9 + row - 50, 3 + 6) = dslist.Tables(0).Rows(row)("SIZE_CON")
                        xlsheet.Cells(9 + row - 50, 4 + 6) = dslist.Tables(0).Rows(row)("FULLOREMPTY")
                        If dslist.Tables(0).Rows(row)("FULLOREMPTY") = "E" Then
                            xlsheet.Cells(9 + row - 50, 5 + 6) = "��������"
                        Else
                            xlsheet.Cells(9 + row - 50, 5 + 6) = "OK"
                        End If
                    Next row
                End If
                strsql = " select size_con,count(size_con) sum_con from CON_TALLY_DETAIL WHERE CON_TALLY_LIST_ID in (select CON_TALLY_LIST_ID from CON_TALLY_LIST where ship_id=" & Ship_ID & " and inout_mark=0 and reload=0 ) and fullorempty='E' group by size_con order by size_con "
                Getdata(strsql, dsconinfo)
                coninfo = ""
                For i = 0 To dsconinfo.Tables(0).Rows.Count - 1
                    coninfo = coninfo + dsconinfo.Tables(0).Rows(i)("size_con").ToString() + "'��" + dsconinfo.Tables(0).Rows(i)("sum_con").ToString() + "  "
                Next
                xlsheet.Cells(59, 3) = coninfo

                coninfo = ""
                strsql = " select size_con,count(size_con) sum_con from CON_TALLY_DETAIL WHERE CON_TALLY_LIST_ID in (select CON_TALLY_LIST_ID from CON_TALLY_LIST where ship_id=" & Ship_ID & " and inout_mark=0 and reload=0 ) and fullorempty='F' group by size_con order by size_con "
                Getdata(strsql, dsconinfo)
                coninfo = ""
                For i = 0 To dsconinfo.Tables(0).Rows.Count - 1
                    coninfo = coninfo + dsconinfo.Tables(0).Rows(i)("size_con").ToString() + "'��" + dsconinfo.Tables(0).Rows(i)("sum_con").ToString() + "  "
                Next
                xlsheet.Cells(59, 8) = coninfo
                xlsheet.PrintOut()
            End If

            If dvlist.Count > 100 Then
                Dim t As Integer
                t = (dslist.Tables(0).Rows.Count - dslist.Tables(0).Rows.Count Mod 100) / 100   '������
                q = dslist.Tables(0).Rows.Count - t * 100   '���һ�ŵ�����
               
                For j = 0 To t - 1
                    xlsheet.Cells(4, 2) = dsshipinfo.Tables(0).Rows(0).Item("CHI_VESSEL")
                    xlsheet.Cells(4, 7) = dsshipinfo.Tables(0).Rows(0).Item("Voyage")
                    xlsheet.Cells(4, 11) = dsshipinfo.Tables(0).Rows(0).Item("BerthNo")
                    xlsheet.Cells(5, 3) = dsshipinfo.Tables(0).Rows(0).Item("worktime_begin")
                    xlsheet.Cells(5, 9) = dsshipinfo.Tables(0).Rows(0).Item("worktime_end")
                    If io = 0 Then
                        xlsheet.Cells(2, 1) = "(����)"
                    Else
                        xlsheet.Cells(2, 1) = "(����)"
                    End If
                    If q = 0 Then
                        xlsheet.Cells(2, 12) = "'" & j + 1 & "/" & t
                    Else
                        xlsheet.Cells(2, 12) = "'" & j + 1 & "/" & t + 1
                    End If


                    For row = 0 To 49
                        xlsheet.Cells(9 + row, 1) = dslist.Tables(0).Rows(row + 100 * j)("CONTAINER_NO")
                        'xlsheet.Cells(9 + row, 3) = dslist.Tables(0).Rows(row+ 100 * j)("SEALNO")
                        xlsheet.Cells(9 + row, 3) = dslist.Tables(0).Rows(row + 100 * j)("SIZE_CON")
                        xlsheet.Cells(9 + row, 4) = dslist.Tables(0).Rows(row + 100 * j)("FULLOREMPTY")
                        If dslist.Tables(0).Rows(row + 100 * j)("FULLOREMPTY") = "E" Then
                            xlsheet.Cells(9 + row, 5) = "��������"
                        Else
                            xlsheet.Cells(9 + row, 5) = "OK"
                        End If
                    Next row
                    For row = 50 To 99   ' dvlist.Count - 100 * (t - j) - q + 99 
                        xlsheet.Cells(9 + row - 50, 1 + 6) = dslist.Tables(0).Rows(row + 100 * j)("CONTAINER_NO")
                        'xlsheet.Cells(9+row- 50 , 3+ 6) = dslist.Tables(0).Rows(row+ 100 * j)("SEALNO")
                        xlsheet.Cells(9 + row - 50, 3 + 6) = dslist.Tables(0).Rows(row + 100 * j)("SIZE_CON")
                        xlsheet.Cells(9 + row - 50, 4 + 6) = dslist.Tables(0).Rows(row + 100 * j)("FULLOREMPTY")
                        If dslist.Tables(0).Rows(row + 100 * j)("FULLOREMPTY") = "E" Then
                            xlsheet.Cells(9 + row - 50, 5 + 6) = "��������"
                        Else
                            xlsheet.Cells(9 + row - 50, 5 + 6) = "OK"
                        End If
                    Next row

                    If j < t - 1 Then
                        xlsheet.PrintOut()
                    End If
                    If j = t - 1 Then
                        If q <> 0 Then
                            xlsheet.PrintOut()
                        End If
                    Else

                    End If

                    If j = t - 1 And q = 0 Then
                        strsql = " select size_con,count(size_con) sum_con from CON_TALLY_DETAIL WHERE CON_TALLY_LIST_ID in (select CON_TALLY_LIST_ID from CON_TALLY_LIST where ship_id=" & Ship_ID & " and inout_mark=0 and reload=0 ) and fullorempty='E' group by size_con order by size_con "
                        Getdata(strsql, dsconinfo)
                        coninfo = ""
                        For i = 0 To dsconinfo.Tables(0).Rows.Count - 1
                            coninfo = coninfo + dsconinfo.Tables(0).Rows(i)("size_con").ToString() + "'��" + dsconinfo.Tables(0).Rows(i)("sum_con").ToString() + "  "
                        Next
                        xlsheet.Cells(59, 3) = coninfo
                        coninfo = ""
                        strsql = " select size_con,count(size_con) sum_con from CON_TALLY_DETAIL WHERE CON_TALLY_LIST_ID in (select CON_TALLY_LIST_ID from CON_TALLY_LIST where ship_id=" & Ship_ID & " and inout_mark=0 and reload=0 ) and fullorempty='F' group by size_con order by size_con "
                        Getdata(strsql, dsconinfo)
                        coninfo = ""
                        For i = 0 To dsconinfo.Tables(0).Rows.Count - 1
                            coninfo = coninfo + dsconinfo.Tables(0).Rows(i)("size_con").ToString() + "'��" + dsconinfo.Tables(0).Rows(i)("sum_con").ToString() + "  "
                        Next
                        xlsheet.Cells(59, 8) = coninfo
                        xlsheet.PrintOut()
                    End If
                Next
                If q > 0 Then
                    xlsheet.Cells(4, 2) = dsshipinfo.Tables(0).Rows(0).Item("CHI_VESSEL")
                    xlsheet.Cells(4, 7) = dsshipinfo.Tables(0).Rows(0).Item("Voyage")
                    xlsheet.Cells(4, 11) = dsshipinfo.Tables(0).Rows(0).Item("BerthNo")
                    xlsheet.Cells(5, 3) = dsshipinfo.Tables(0).Rows(0).Item("worktime_begin")
                    xlsheet.Cells(5, 9) = dsshipinfo.Tables(0).Rows(0).Item("worktime_end")
                    If io = 0 Then
                        xlsheet.Cells(2, 1) = "(����)"
                    Else
                        xlsheet.Cells(2, 1) = "(����)"
                    End If
                    xlsheet.Cells(2, 12) = "'" & t + 1 & "/" & t + 1

                    For row = 0 To 49
                        xlsheet.Cells(9 + row, 1) = ""
                        'xlsheet.Cells(9 + row, 3) = ""
                        xlsheet.Cells(9 + row, 3) = ""
                        xlsheet.Cells(9 + row, 4) = ""
                        xlsheet.Cells(9 + row, 5) = ""
                        xlsheet.Cells(9 + row, 1 + 6) = ""
                        'xlsheet.Cells(9+ row, 1 + 6) = ""
                        xlsheet.Cells(9 + row, 3 + 6) = ""
                        xlsheet.Cells(9 + row, 4 + 6) = ""
                        xlsheet.Cells(9 + row, 5 + 6) = ""
                    Next row

                    If q <= 50 Then
                        For row = 0 To q - 1
                            xlsheet.Cells(9 + row, 1) = dslist.Tables(0).Rows(row + 100 * t)("CONTAINER_NO")
                            'xlsheet.Cells(9 + row, 3) = dslist.Tables(0).Rows(row+ 100 * t)("SEALNO")
                            xlsheet.Cells(9 + row, 3) = dslist.Tables(0).Rows(row + 100 * t)("SIZE_CON")
                            xlsheet.Cells(9 + row, 4) = dslist.Tables(0).Rows(row + 100 * t)("FULLOREMPTY")
                            If dslist.Tables(0).Rows(row + 100 * t)("FULLOREMPTY") = "E" Then
                                xlsheet.Cells(9 + row, 5) = "��������"
                            Else
                                xlsheet.Cells(9 + row, 5) = "OK"
                            End If
                        Next row
                    Else
                        For row = 0 To 49
                            xlsheet.Cells(9 + row, 1) = dslist.Tables(0).Rows(row + 100 * t)("CONTAINER_NO")
                            'xlsheet.Cells(9 + row, 3) = dslist.Tables(0).Rows(row+ 100 * t)("SEALNO")
                            xlsheet.Cells(9 + row, 3) = dslist.Tables(0).Rows(row + 100 * t)("SIZE_CON")
                            xlsheet.Cells(9 + row, 4) = dslist.Tables(0).Rows(row + 100 * t)("FULLOREMPTY")
                            If dslist.Tables(0).Rows(row + 100 * t)("FULLOREMPTY") = "E" Then
                                xlsheet.Cells(9 + row, 5) = "��������"
                            Else
                                xlsheet.Cells(9 + row, 5) = "OK"
                            End If
                        Next row
                        For row = 50 To dvlist.Count - 1 - 100 * t
                            xlsheet.Cells(9 + row - 50, 1 + 6) = dslist.Tables(0).Rows(row + 100 * t)("CONTAINER_NO")
                            'xlsheet.Cells(9+row- 50 , 3+ 6) = dslist.Tables(0).Rows(row+ 100 * t)("SEALNO")
                            xlsheet.Cells(9 + row - 50, 3 + 6) = dslist.Tables(0).Rows(row + 100 * t)("SIZE_CON")
                            xlsheet.Cells(9 + row - 50, 4 + 6) = dslist.Tables(0).Rows(row + 100 * t)("FULLOREMPTY")
                            If dslist.Tables(0).Rows(row + 100 * t)("FULLOREMPTY") = "E" Then
                                xlsheet.Cells(9 + row - 50, 5 + 6) = "��������"
                            Else
                                xlsheet.Cells(9 + row - 50, 5 + 6) = "OK"
                            End If
                        Next row
                    End If
                    strsql = " select size_con,count(size_con) sum_con from CON_TALLY_DETAIL WHERE CON_TALLY_LIST_ID in (select CON_TALLY_LIST_ID from CON_TALLY_LIST where ship_id=" & Ship_ID & " and inout_mark=0 and reload=0 ) and fullorempty='E' group by size_con order by size_con "
                    Getdata(strsql, dsconinfo)
                    coninfo = ""
                    For i = 0 To dsconinfo.Tables(0).Rows.Count - 1
                        coninfo = coninfo + dsconinfo.Tables(0).Rows(i)("size_con").ToString() + "'��" + dsconinfo.Tables(0).Rows(i)("sum_con").ToString() + "  "
                    Next
                    xlsheet.Cells(59, 3) = coninfo
                    coninfo = ""
                    strsql = " select size_con,count(size_con) sum_con from CON_TALLY_DETAIL WHERE CON_TALLY_LIST_ID in (select CON_TALLY_LIST_ID from CON_TALLY_LIST where ship_id=" & Ship_ID & " and inout_mark=0 and reload=0 ) and fullorempty='F' group by size_con order by size_con "
                    Getdata(strsql, dsconinfo)
                    coninfo = ""
                    For i = 0 To dsconinfo.Tables(0).Rows.Count - 1
                        coninfo = coninfo + dsconinfo.Tables(0).Rows(i)("size_con").ToString() + "'��" + dsconinfo.Tables(0).Rows(i)("sum_con").ToString() + "  "
                    Next
                    xlsheet.Cells(59, 8) = coninfo
                    xlsheet.PrintOut()
                End If
            End If

            'xlsheet.PrintPreview()
            'If GL_Print = 1 Then
            '    xlsheet.PrintOut()
            KillExcelProcess()
            '    'GL_Print = 0
            'End If
        Catch
            xlapp.Quit()
            SendKeys.Send("n")
            KillExcelProcess()
        End Try
    End Sub
    'Private Sub C1DBG_FetchRowStyle(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
    '    If Me.C1DBG.Columns("Logic").CellValue(e.Row) = 1 Then
    '        e.CellStyle.BackColor = System.Drawing.Color.LemonChiffon
    '    End If
    'End Sub
    'Private Sub C1DBG_FetchRowStyle(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
    '    If Me.C1DBG.Columns("Logic").CellValue(e.Row) = 1 Then
    '        e.CellStyle.BackColor = System.Drawing.Color.LemonChiffon
    '    End If
    'End Sub
    'Private Sub C1DBG_FetchRowStyle(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
    '    If Me.C1DBG.Columns("Logic").CellValue(e.Row) = 1 Then
    '        e.CellStyle.BackColor = System.Drawing.Color.LemonChiffon
    '    End If
    'End Sub
    'Private Sub C1DBG_FetchRowStyle(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
    '    If Me.C1DBG.Columns("Logic").CellValue(e.Row) = 1 Then
    '        e.CellStyle.BackColor = System.Drawing.Color.LemonChiffon
    '    End If
    'End Sub
    'Private Sub C1DBG_FetchRowStyle(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
    '    If Me.C1DBG.Columns("Logic").CellValue(e.Row) = 1 Then
    '        e.CellStyle.BackColor = System.Drawing.Color.LemonChiffon
    '    End If
    'End Sub

    Private Sub Frm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Me.C1DBGV.Height = Me.Height - 140
        Me.C1DBGTally_List.Height = Me.TabTALLY_LIST.Height - 5
        Me.C1DBGTally_List.Width = Me.GB.Width - 15
        Me.Label.Width = Me.C1DBGTally_List.Width - 3
        Me.LabREMARKS.Width = Me.C1DBGTally_List.Width - 3
        Me.C1DBGCertificate.Height = Me.Height - 180
        Me.C1DBGCertificate.Width = Me.GB.Width - 15
        Me.C1DBGDaily_report.Height = Me.Height - 180
        Me.C1DBGDaily_report.Width = Me.GB.Width - 15
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
        SqlStrShip = "where (((DEPT_CODE LIKE '" & G_DeptCode & "%' and SHIP_STATU in ('1','2','3','0'))) and Voyage like '" & Trim(txtVoyage.Text) & "%' and (ENG_VESSEL Like '" & Trim(txtShipName.Text) & "%' OR CHI_VESSEL like '" & Trim(txtShipName.Text) & "%' )) "
        '����Ҫ�޸�
        G_ShipName = Trim(txtShipName.Text)
        G_Voyage = Trim(txtVoyage.Text)
        Call myDataGridShip(SqlStrShip & inoutstr & SortShip)   '����Ҫ�޸�
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

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        Select Case Me.TabControl1.SelectedIndex
            Case 0
                ToolBar.Buttons.Item(0).Enabled = True
                mnuFind.Enabled = True
                ToolBar.Buttons.Item(1).Enabled = True
                ToolBar.Buttons.Item(2).Enabled = True
                ToolBar.Buttons.Item(3).Enabled = True
                mnuQuery.Enabled = True
                ToolBar.Buttons.Item(4).Enabled = True
                mnuAdd.Enabled = True
                ToolBar.Buttons.Item(5).Enabled = True
                mnuEdit.Enabled = True
                ToolBar.Buttons.Item(6).Enabled = True
                mnuDelete.Enabled = True
                ToolBar.Buttons.Item(7).Enabled = True
                mnuPrint.Enabled = True
                ToolBar.Buttons.Item(8).Enabled = True
                mnuExport.Enabled = True
                ToolBar.Buttons.Item(9).Enabled = True
                mnuQuit.Enabled = True
            Case 1
                ToolBar.Buttons.Item(0).Enabled = False
                mnuFind.Enabled = False
                ToolBar.Buttons.Item(1).Enabled = True
                ToolBar.Buttons.Item(2).Enabled = False
                ToolBar.Buttons.Item(3).Enabled = False
                mnuQuery.Enabled = False
                ToolBar.Buttons.Item(4).Enabled = False
                mnuAdd.Enabled = False
                ToolBar.Buttons.Item(5).Enabled = False
                mnuEdit.Enabled = False
                ToolBar.Buttons.Item(6).Enabled = False
                mnuDelete.Enabled = False
                ToolBar.Buttons.Item(7).Enabled = True
                mnuPrint.Enabled = True
                ToolBar.Buttons.Item(8).Enabled = True
                mnuExport.Enabled = False
                ToolBar.Buttons.Item(9).Enabled = True
                mnuQuit.Enabled = True
                LabREMARKS.Text = REMARKS & "    " & GL_Teu
                LabREMARKS.Refresh()
            Case 2
                ToolBar.Buttons.Item(0).Enabled = False
                mnuFind.Enabled = False
                ToolBar.Buttons.Item(1).Enabled = False
                ToolBar.Buttons.Item(2).Enabled = False
                ToolBar.Buttons.Item(3).Enabled = False
                mnuQuery.Enabled = False
                ToolBar.Buttons.Item(4).Enabled = False
                mnuAdd.Enabled = False
                ToolBar.Buttons.Item(5).Enabled = False
                mnuEdit.Enabled = False
                ToolBar.Buttons.Item(6).Enabled = False
                mnuDelete.Enabled = False
                ToolBar.Buttons.Item(7).Enabled = True
                mnuPrint.Enabled = True
                ToolBar.Buttons.Item(8).Enabled = True
                mnuExport.Enabled = False
                ToolBar.Buttons.Item(9).Enabled = True
                mnuQuit.Enabled = True
            Case 3
                ToolBar.Buttons.Item(0).Enabled = False
                mnuFind.Enabled = False
                ToolBar.Buttons.Item(1).Enabled = True
                ToolBar.Buttons.Item(2).Enabled = False
                ToolBar.Buttons.Item(3).Enabled = False
                mnuQuery.Enabled = False
                ToolBar.Buttons.Item(4).Enabled = False
                mnuAdd.Enabled = False
                ToolBar.Buttons.Item(5).Enabled = False
                mnuEdit.Enabled = False
                ToolBar.Buttons.Item(6).Enabled = False
                mnuDelete.Enabled = False
                ToolBar.Buttons.Item(7).Enabled = True
                mnuPrint.Enabled = True
                ToolBar.Buttons.Item(8).Enabled = True
                mnuExport.Enabled = False
                ToolBar.Buttons.Item(9).Enabled = True
                mnuQuit.Enabled = True
                LabREMARKS.Text = REMARKSdx & "    " & GL_Teudx
                LabREMARKS.Refresh()
        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim jjr As String
            If chkjjr.Checked = True Then
                jjr = 1
            Else
                jjr = 0
            End If
            If MsgBox("�Ƿ�ȷ��Ҫ�޸�:" & DateTimePicker1.Value.ToString() & " �� " & DateTimePicker2.Value.ToString() & " �ڼ�����Ϣ��", MsgBoxStyle.YesNo, "��ʾ") = MsgBoxResult.Yes Then
                'д�������־�ļ�
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
                MsgBox("�ڼ�����Ϣ�޸ĳɹ���")
                Refresh()
                Call getTallylist(FirmStr)    '���䵥
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
            If MsgBox("�Ƿ�ȷ��Ҫ�޸�:" & DateTimePicker1.Value.ToString() & " �� " & DateTimePicker2.Value.ToString() & " ҹ����Ϣ��", MsgBoxStyle.YesNo, "��ʾ") = MsgBoxResult.Yes Then
                'д�������־�ļ�
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
                MsgBox("ҹ����Ϣ�޸ĳɹ���")
                Refresh()
                Call getTallylist(FirmStr)    '���䵥
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
                MsgBox("����ȷ����2λ�����")
                Exit Sub
            End If
            If MsgBox("�Ƿ�ȷ��Ҫ�޸�:" & DateTimePicker1.Value.ToString() & " �� " & DateTimePicker2.Value.ToString() & " �Ĺ�����Ϣ��", MsgBoxStyle.YesNo, "��ʾ") = MsgBoxResult.Yes Then
                'д�������־�ļ�
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
                MsgBox("������Ϣ�޸ĳɹ���")
                Refresh()
                Call getTallylist(FirmStr)    '���䵥
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub C1DBGTally_List_AfterFilter(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FilterEventArgs) Handles C1DBGTally_List.AfterFilter
        Me.C1DBGTally_List.Columns.Item(ColNum + 1).FooterText = "�� " & C1DBGTally_List.Splits(0).Rows.Count & " ��"
    End Sub


    Private Sub mnuExportReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExportReload.Click
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
