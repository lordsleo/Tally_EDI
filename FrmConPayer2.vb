Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FrmConPayer2
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents C1_con_hatch_list As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents C1_Payer As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents C1_Blno As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents C1readpayer As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btClose As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConPayer2))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.C1_con_hatch_list = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btClose = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.C1_Payer = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.C1_Blno = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.C1readpayer = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.GroupBox1.SuspendLayout()
        CType(Me.C1_con_hatch_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.C1_Payer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.C1_Blno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1readpayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.C1_con_hatch_list)
        Me.GroupBox1.Location = New System.Drawing.Point(4, -4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 517)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'C1_con_hatch_list
        '
        Me.C1_con_hatch_list.AllowColMove = False
        Me.C1_con_hatch_list.Caption = "���������ᵥ"
        Me.C1_con_hatch_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1_con_hatch_list.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1_con_hatch_list.Images.Add(CType(resources.GetObject("C1_con_hatch_list.Images"), System.Drawing.Image))
        Me.C1_con_hatch_list.Location = New System.Drawing.Point(3, 17)
        Me.C1_con_hatch_list.Name = "C1_con_hatch_list"
        Me.C1_con_hatch_list.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1_con_hatch_list.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1_con_hatch_list.PreviewInfo.ZoomFactor = 75
        Me.C1_con_hatch_list.PrintInfo.PageSettings = CType(resources.GetObject("C1_con_hatch_list.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1_con_hatch_list.Size = New System.Drawing.Size(260, 497)
        Me.C1_con_hatch_list.TabIndex = 0
        Me.C1_con_hatch_list.PropBag = resources.GetString("C1_con_hatch_list.PropBag")
        '
        'btClose
        '
        Me.btClose.Location = New System.Drawing.Point(489, 535)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 30)
        Me.btClose.TabIndex = 6
        Me.btClose.Text = "����"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.C1_Payer)
        Me.GroupBox2.Location = New System.Drawing.Point(679, -4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(379, 517)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'C1_Payer
        '
        Me.C1_Payer.AllowFilter = False
        Me.C1_Payer.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1_Payer.AllowUpdate = False
        Me.C1_Payer.Caption = "�����˷���ͳ��"
        Me.C1_Payer.ColumnFooters = True
        Me.C1_Payer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1_Payer.FetchRowStyles = True
        Me.C1_Payer.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1_Payer.Images.Add(CType(resources.GetObject("C1_Payer.Images"), System.Drawing.Image))
        Me.C1_Payer.Location = New System.Drawing.Point(3, 17)
        Me.C1_Payer.Name = "C1_Payer"
        Me.C1_Payer.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1_Payer.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1_Payer.PreviewInfo.ZoomFactor = 75
        Me.C1_Payer.PrintInfo.PageSettings = CType(resources.GetObject("C1_Payer.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1_Payer.Size = New System.Drawing.Size(373, 497)
        Me.C1_Payer.TabIndex = 0
        Me.C1_Payer.Text = "C1DBG"
        Me.C1_Payer.PropBag = resources.GetString("C1_Payer.PropBag")
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.C1_Blno)
        Me.GroupBox3.Location = New System.Drawing.Point(273, -4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(403, 517)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'C1_Blno
        '
        Me.C1_Blno.AllowFilter = False
        Me.C1_Blno.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1_Blno.AllowUpdate = False
        Me.C1_Blno.Caption = "�ᵥ����ͳ��"
        Me.C1_Blno.ColumnFooters = True
        Me.C1_Blno.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1_Blno.FetchRowStyles = True
        Me.C1_Blno.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1_Blno.Images.Add(CType(resources.GetObject("C1_Blno.Images"), System.Drawing.Image))
        Me.C1_Blno.Location = New System.Drawing.Point(3, 17)
        Me.C1_Blno.Name = "C1_Blno"
        Me.C1_Blno.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1_Blno.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1_Blno.PreviewInfo.ZoomFactor = 75
        Me.C1_Blno.PrintInfo.PageSettings = CType(resources.GetObject("C1_Blno.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1_Blno.Size = New System.Drawing.Size(397, 497)
        Me.C1_Blno.TabIndex = 0
        Me.C1_Blno.Text = "C1DBG"
        Me.C1_Blno.PropBag = resources.GetString("C1_Blno.PropBag")
        '
        'C1readpayer
        '
        Me.C1readpayer.AllowFilter = False
        Me.C1readpayer.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1readpayer.AllowUpdate = False
        Me.C1readpayer.Caption = "�ᵥ���ݶ���"
        Me.C1readpayer.ColumnFooters = True
        Me.C1readpayer.FetchRowStyles = True
        Me.C1readpayer.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1readpayer.Images.Add(CType(resources.GetObject("C1readpayer.Images"), System.Drawing.Image))
        Me.C1readpayer.Location = New System.Drawing.Point(283, 12)
        Me.C1readpayer.Name = "C1readpayer"
        Me.C1readpayer.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1readpayer.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1readpayer.PreviewInfo.ZoomFactor = 75
        Me.C1readpayer.PrintInfo.PageSettings = CType(resources.GetObject("C1readpayer.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1readpayer.Size = New System.Drawing.Size(409, 501)
        Me.C1readpayer.TabIndex = 1
        Me.C1readpayer.Text = "C1DBG"
        Me.C1readpayer.Visible = False
        Me.C1readpayer.PropBag = resources.GetString("C1readpayer.PropBag")
        '
        'FrmConPayer2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(1061, 577)
        Me.Controls.Add(Me.C1readpayer)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmConPayer2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "������Ϣ"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.C1_con_hatch_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.C1_Payer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.C1_Blno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1readpayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim sqlstr As String
    Dim dsship As New DataSet
    Dim dspayer As New DataSet
    Dim dwpayer As New DataView
    Dim sqladpayer As New SqlClient.SqlDataAdapter

    Private Sub FrmConPayer2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlstr = " select agent from sship where ship_id =" & Ship_ID
        Getdata(sqlstr, dsship)
        FillHatchlist()
    End Sub

    Private Sub FillHatchlist()
        On Error GoTo Err
        sqlstr = "select con_hatch_list_id,blno,code_payer from CON_HATCH_LIST where ship_id=" & Ship_ID
        dwpayer = Updatedata(sqladpayer, sqlstr, dspayer)
        If dwpayer.Count > 0 Then
            Dim i As Integer
            Dim dst As New DataSet
            Dim sqla As New SqlClient.SqlDataAdapter
            Dim sqlc As New SqlClient.SqlCommand
            Me.C1_con_hatch_list.DataSource = dwpayer
            Me.C1_con_hatch_list.Columns.Item("blno").Caption = "�ᵥ"
            Me.C1_con_hatch_list.Columns.Item("code_payer").Caption = "������"
            Me.C1_con_hatch_list.Splits(0).DisplayColumns.Item("con_hatch_list_id").Visible = False
            Me.C1_con_hatch_list.Splits(0).DisplayColumns("blno").Width = 100
            Me.C1_con_hatch_list.Splits(0).DisplayColumns("code_payer").Width = 80
            Me.C1_con_hatch_list.Refresh()
            Me.C1_con_hatch_list.Columns.Item("code_payer").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1_con_hatch_list.Columns.Item("code_payer").ValueItems.Translate = True
            Me.C1_con_hatch_list.Columns.Item("code_payer").ValueItems.Validate = True
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT CODE_SHIP_AGENT, SHIPAGENT_SHORT FROM CODE_SHIP_AGENT where Mark='1' or Mark is Null ORDER BY SHIPAGENT_SHORT"
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("SHIPAGENT_SHORT"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("CODE_SHIP_AGENT"))
                Me.C1_con_hatch_list.Columns.Item("code_payer").ValueItems.Values.Add(vi)
            Next
            Me.C1_con_hatch_list.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
            Me.C1_con_hatch_list.ColumnFooters = True
            Me.C1_con_hatch_list.FooterStyle.BackColor = System.Drawing.Color.PaleTurquoise
            Me.C1_con_hatch_list.Columns("blno").FooterText = "�ϼ� " & C1_con_hatch_list.RowCount & " ��"
        End If
        FillHatchlistbyblno()
        FillHatchlistbyagent()
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub FillHatchlistbyagent()
        Dim sqlGetAgent As String
        Dim dvGetAgent As New DataView
        Dim dsGetAgent As New DataSet

        'sqlGetAgent = "SELECT CODE_PAYER,SIZE_CON, FULLOREMPTY,count(1) hj, sum(CAST(NIGHT_MARK as int)) NIGHT_MARK,sum(CAST(HOLIDAY as int)) HOLIDAY, sum(CAST(INOUT_MARK as int)) INOUT_MARK, sum(CAST(RELOAD as int)) RELOAD FROM VIEW_con_list_payer where ship_id= " & Ship_ID & " group by CODE_PAYER,SIZE_CON,FULLOREMPTY order by CODE_PAYER,SIZE_CON,FULLOREMPTY"
        sqlGetAgent = "SELECT CODE_PAYER,SIZE_CON, FULLOREMPTY,count(1) hj, sum(CAST(NIGHT_MARK as int)) NIGHT_MARK,sum(CAST(HOLIDAY as int)) HOLIDAY, sum(CAST(INOUT_MARK as int)) INOUT_MARK, sum(CAST(RELOAD as int)) RELOAD FROM VIEW_con_list_payer_new where ship_id= " & Ship_ID & " group by CODE_PAYER,SIZE_CON,FULLOREMPTY order by CODE_PAYER,SIZE_CON,FULLOREMPTY"
        dvGetAgent = Getdata(sqlGetAgent, dsGetAgent)
        If dvGetAgent.Count > 0 Then
            Dim i As Integer
            Dim dst As New DataSet
            Dim sqla As New SqlClient.SqlDataAdapter
            Dim sqlc As New SqlClient.SqlCommand
            Me.C1_Payer.DataSource = dvGetAgent
            Me.C1_Payer.Columns("CODE_PAYER").Caption = "������"
            Me.C1_Payer.Columns("SIZE_CON").Caption = "�ߴ�"
            Me.C1_Payer.Columns("FULLOREMPTY").Caption = "����"
            Me.C1_Payer.Columns("hj").Caption = "����"
            Me.C1_Payer.Columns("NIGHT_MARK").Caption = "ҹ��"
            Me.C1_Payer.Columns("HOLIDAY").Caption = "�ڼ���"
            Me.C1_Payer.Columns("INOUT_MARK").Caption = "����"
            Me.C1_Payer.Columns("RELOAD").Caption = "��װ"
            Me.C1_Payer.Splits(0).DisplayColumns("CODE_PAYER").Width = 100
            Me.C1_Payer.Splits(0).DisplayColumns("SIZE_CON").AutoSize()
            Me.C1_Payer.Splits(0).DisplayColumns("FULLOREMPTY").AutoSize()
            Me.C1_Payer.Splits(0).DisplayColumns("hj").AutoSize()
            Me.C1_Payer.Splits(0).DisplayColumns("NIGHT_MARK").AutoSize()
            Me.C1_Payer.Splits(0).DisplayColumns("HOLIDAY").AutoSize()
            Me.C1_Payer.Splits(0).DisplayColumns("INOUT_MARK").AutoSize()
            Me.C1_Payer.Splits(0).DisplayColumns("RELOAD").AutoSize()
            Me.C1_Payer.Columns.Item("code_payer").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1_Payer.Columns.Item("code_payer").ValueItems.Translate = True
            Me.C1_Payer.Columns.Item("code_payer").ValueItems.Validate = True
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT CODE_SHIP_AGENT, SHIPAGENT_SHORT FROM CODE_SHIP_AGENT where Mark='1' or Mark is Null ORDER BY SHIPAGENT_SHORT"
            sqla.SelectCommand = sqlc
            dst.Reset()
            sqla.Fill(dst)
            For i = 0 To dst.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = Trim(dst.Tables(0).Rows(i)("SHIPAGENT_SHORT"))
                vi.Value = Trim(dst.Tables(0).Rows(i)("CODE_SHIP_AGENT"))
                Me.C1_Payer.Columns.Item("code_payer").ValueItems.Values.Add(vi)
            Next
        End If
        Me.C1_Payer.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        Me.C1_Payer.ColumnFooters = True
        Me.C1_Payer.FooterStyle.BackColor = System.Drawing.Color.PaleTurquoise
        Me.C1_Payer.Columns("CODE_PAYER").FooterText = "��" & C1_Payer.RowCount & " ��"
        Dim m, j, hj, NIGHT_MARK, HOLIDAY, INOUT_MARK, RELOAD As Integer
        For j = 0 To dsGetAgent.Tables(0).Rows.Count - 1
            hj = 0
            NIGHT_MARK = 0
            HOLIDAY = 0
            INOUT_MARK = 0
            RELOAD = 0
            For m = 0 To dsGetAgent.Tables(0).Rows.Count - 1
                hj = hj + dsGetAgent.Tables(0).Rows(m)("hj")
                NIGHT_MARK = NIGHT_MARK + dsGetAgent.Tables(0).Rows(m)("NIGHT_MARK")
                HOLIDAY = HOLIDAY + dsGetAgent.Tables(0).Rows(m)("HOLIDAY")
                INOUT_MARK = INOUT_MARK + dsGetAgent.Tables(0).Rows(m)("INOUT_MARK")
                RELOAD = RELOAD + dsGetAgent.Tables(0).Rows(m)("RELOAD")
            Next
            Me.C1_Payer.Columns.Item("hj").FooterText = CType(hj, String)
            Me.C1_Payer.Columns.Item("NIGHT_MARK").FooterText = CType(NIGHT_MARK, String)
            Me.C1_Payer.Columns.Item("HOLIDAY").FooterText = CType(HOLIDAY, String)
            Me.C1_Payer.Columns.Item("INOUT_MARK").FooterText = CType(INOUT_MARK, String)
            Me.C1_Payer.Columns.Item("RELOAD").FooterText = CType(RELOAD, String)
            Exit For
        Next
    End Sub

    Private Sub FillHatchlistbyblno()
        Dim sqlGetBlno As String
        Dim dvGetBlno As New DataView
        Dim dsGetBlno As New DataSet

        sqlGetBlno = "SELECT BLNO,SIZE_CON, FULLOREMPTY,count(1) hj, sum(CAST(NIGHT_MARK as int)) NIGHT_MARK,sum(CAST(HOLIDAY as int)) HOLIDAY, sum(CAST(INOUT_MARK as int)) INOUT_MARK, sum(CAST(RELOAD as int)) RELOAD FROM VIEW_con_list_blno where ship_id= " & Ship_ID & " group by BLNO,SIZE_CON,FULLOREMPTY order by BLNO,SIZE_CON,FULLOREMPTY"
        dvGetBlno = Getdata(sqlGetBlno, dsGetBlno)
        If dvGetBlno.Count > 0 Then
            Dim i As Integer
            Dim dst As New DataSet
            Dim sqla As New SqlClient.SqlDataAdapter
            Dim sqlc As New SqlClient.SqlCommand
            Me.C1_Blno.DataSource = dvGetBlno
            Me.C1_Blno.Columns("BLNO").Caption = "�ᵥ"
            Me.C1_Blno.Columns("SIZE_CON").Caption = "�ߴ�"
            Me.C1_Blno.Columns("FULLOREMPTY").Caption = "����"
            Me.C1_Blno.Columns("hj").Caption = "����"
            Me.C1_Blno.Columns("NIGHT_MARK").Caption = "ҹ��"
            Me.C1_Blno.Columns("HOLIDAY").Caption = "�ڼ���"
            Me.C1_Blno.Columns("INOUT_MARK").Caption = "����"
            Me.C1_Blno.Columns("RELOAD").Caption = "��װ"
            Me.C1_Blno.Splits(0).DisplayColumns("BLNO").Width = 110
            Me.C1_Blno.Splits(0).DisplayColumns("SIZE_CON").AutoSize()
            Me.C1_Blno.Splits(0).DisplayColumns("FULLOREMPTY").AutoSize()
            Me.C1_Blno.Splits(0).DisplayColumns("hj").AutoSize()
            Me.C1_Blno.Splits(0).DisplayColumns("NIGHT_MARK").AutoSize()
            Me.C1_Blno.Splits(0).DisplayColumns("HOLIDAY").AutoSize()
            Me.C1_Blno.Splits(0).DisplayColumns("INOUT_MARK").AutoSize()
            Me.C1_Blno.Splits(0).DisplayColumns("RELOAD").AutoSize()
        End If
        Me.C1_Blno.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        Me.C1_Blno.ColumnFooters = True
        Me.C1_Blno.FooterStyle.BackColor = System.Drawing.Color.PaleTurquoise
        Me.C1_Blno.Columns("BLNO").FooterText = "��" & C1_Blno.RowCount & " ��"
        Dim m, j, hj, NIGHT_MARK, HOLIDAY, INOUT_MARK, RELOAD As Integer
        For j = 0 To dsGetBlno.Tables(0).Rows.Count - 1
            hj = 0
            NIGHT_MARK = 0
            HOLIDAY = 0
            INOUT_MARK = 0
            RELOAD = 0
            For m = 0 To dsGetBlno.Tables(0).Rows.Count - 1
                hj = hj + dsGetBlno.Tables(0).Rows(m)("hj")
                NIGHT_MARK = NIGHT_MARK + dsGetBlno.Tables(0).Rows(m)("NIGHT_MARK")
                HOLIDAY = HOLIDAY + dsGetBlno.Tables(0).Rows(m)("HOLIDAY")
                INOUT_MARK = INOUT_MARK + dsGetBlno.Tables(0).Rows(m)("INOUT_MARK")
                RELOAD = RELOAD + dsGetBlno.Tables(0).Rows(m)("RELOAD")
            Next
            Me.C1_Blno.Columns.Item("hj").FooterText = CType(hj, String)
            Me.C1_Blno.Columns.Item("NIGHT_MARK").FooterText = CType(NIGHT_MARK, String)
            Me.C1_Blno.Columns.Item("HOLIDAY").FooterText = CType(HOLIDAY, String)
            Me.C1_Blno.Columns.Item("INOUT_MARK").FooterText = CType(INOUT_MARK, String)
            Me.C1_Blno.Columns.Item("RELOAD").FooterText = CType(RELOAD, String)
            Exit For
        Next

    End Sub 

    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        Me.Close()
    End Sub  
End Class
