Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FrmConPayer
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btResure As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents C1_con_hatch_list As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cbShipAgent As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents C1_Payer As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents C1_Blno As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents OpenFile As System.Windows.Forms.Button
    Friend WithEvents txtpayer As System.Windows.Forms.TextBox
    Friend WithEvents btreadpayer As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents C1readpayer As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btC1readpayer As System.Windows.Forms.Button
    Friend WithEvents btClose As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConPayer))
        Me.Label1 = New System.Windows.Forms.Label
        Me.btResure = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.C1_con_hatch_list = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btClose = New System.Windows.Forms.Button
        Me.cbShipAgent = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.C1_Payer = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.C1_Blno = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.OpenFile = New System.Windows.Forms.Button
        Me.txtpayer = New System.Windows.Forms.TextBox
        Me.btreadpayer = New System.Windows.Forms.Button
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.C1readpayer = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btC1readpayer = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.C1_con_hatch_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.C1_Payer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.C1_Blno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1readpayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "船代："
        '
        'btResure
        '
        Me.btResure.Location = New System.Drawing.Point(198, 48)
        Me.btResure.Name = "btResure"
        Me.btResure.Size = New System.Drawing.Size(69, 24)
        Me.btResure.TabIndex = 1
        Me.btResure.Text = "确认"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(417, 535)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(82, 30)
        Me.btSave.TabIndex = 5
        Me.btSave.Text = "保存"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.C1_con_hatch_list)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 438)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'C1_con_hatch_list
        '
        Me.C1_con_hatch_list.AllowColMove = False
        Me.C1_con_hatch_list.Caption = "本港所有提单"
        Me.C1_con_hatch_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1_con_hatch_list.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1_con_hatch_list.Images.Add(CType(resources.GetObject("C1_con_hatch_list.Images"), System.Drawing.Image))
        Me.C1_con_hatch_list.Location = New System.Drawing.Point(3, 17)
        Me.C1_con_hatch_list.Name = "C1_con_hatch_list"
        Me.C1_con_hatch_list.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1_con_hatch_list.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1_con_hatch_list.PreviewInfo.ZoomFactor = 75
        Me.C1_con_hatch_list.PrintInfo.PageSettings = CType(resources.GetObject("C1_con_hatch_list.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1_con_hatch_list.Size = New System.Drawing.Size(260, 418)
        Me.C1_con_hatch_list.TabIndex = 0
        Me.C1_con_hatch_list.PropBag = resources.GetString("C1_con_hatch_list.PropBag")
        '
        'btClose
        '
        Me.btClose.Location = New System.Drawing.Point(554, 535)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(83, 30)
        Me.btClose.TabIndex = 6
        Me.btClose.Text = "返回"
        '
        'cbShipAgent
        '
        Me.cbShipAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbShipAgent.Location = New System.Drawing.Point(63, 52)
        Me.cbShipAgent.MaxDropDownItems = 20
        Me.cbShipAgent.Name = "cbShipAgent"
        Me.cbShipAgent.Size = New System.Drawing.Size(120, 20)
        Me.cbShipAgent.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.C1_Payer)
        Me.GroupBox2.Location = New System.Drawing.Point(679, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(379, 438)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'C1_Payer
        '
        Me.C1_Payer.AllowFilter = False
        Me.C1_Payer.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1_Payer.AllowUpdate = False
        Me.C1_Payer.Caption = "付款人分类统计"
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
        Me.C1_Payer.Size = New System.Drawing.Size(373, 418)
        Me.C1_Payer.TabIndex = 0
        Me.C1_Payer.Text = "C1DBG"
        Me.C1_Payer.PropBag = resources.GetString("C1_Payer.PropBag")
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.C1_Blno)
        Me.GroupBox3.Location = New System.Drawing.Point(273, 75)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(403, 438)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'C1_Blno
        '
        Me.C1_Blno.AllowFilter = False
        Me.C1_Blno.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1_Blno.AllowUpdate = False
        Me.C1_Blno.Caption = "提单分类统计"
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
        Me.C1_Blno.Size = New System.Drawing.Size(397, 418)
        Me.C1_Blno.TabIndex = 0
        Me.C1_Blno.Text = "C1DBG"
        Me.C1_Blno.PropBag = resources.GetString("C1_Blno.PropBag")
        '
        'OpenFile
        '
        Me.OpenFile.Location = New System.Drawing.Point(681, 14)
        Me.OpenFile.Name = "OpenFile"
        Me.OpenFile.Size = New System.Drawing.Size(23, 21)
        Me.OpenFile.TabIndex = 20
        Me.OpenFile.Text = "…"
        '
        'txtpayer
        '
        Me.txtpayer.Location = New System.Drawing.Point(169, 14)
        Me.txtpayer.Name = "txtpayer"
        Me.txtpayer.Size = New System.Drawing.Size(535, 21)
        Me.txtpayer.TabIndex = 19
        '
        'btreadpayer
        '
        Me.btreadpayer.Location = New System.Drawing.Point(730, 12)
        Me.btreadpayer.Name = "btreadpayer"
        Me.btreadpayer.Size = New System.Drawing.Size(78, 24)
        Me.btreadpayer.TabIndex = 18
        Me.btreadpayer.Text = "导入"
        '
        'C1readpayer
        '
        Me.C1readpayer.AllowFilter = False
        Me.C1readpayer.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1readpayer.AllowUpdate = False
        Me.C1readpayer.Caption = "提单数据读入"
        Me.C1readpayer.ColumnFooters = True
        Me.C1readpayer.FetchRowStyles = True
        Me.C1readpayer.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1readpayer.Images.Add(CType(resources.GetObject("C1readpayer.Images"), System.Drawing.Image))
        Me.C1readpayer.Location = New System.Drawing.Point(283, 91)
        Me.C1readpayer.Name = "C1readpayer"
        Me.C1readpayer.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1readpayer.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1readpayer.PreviewInfo.ZoomFactor = 75
        Me.C1readpayer.PrintInfo.PageSettings = CType(resources.GetObject("C1readpayer.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1readpayer.Size = New System.Drawing.Size(409, 422)
        Me.C1readpayer.TabIndex = 1
        Me.C1readpayer.Text = "C1DBG"
        Me.C1readpayer.Visible = False
        Me.C1readpayer.PropBag = resources.GetString("C1readpayer.PropBag")
        '
        'btC1readpayer
        '
        Me.btC1readpayer.Location = New System.Drawing.Point(730, 52)
        Me.btC1readpayer.Name = "btC1readpayer"
        Me.btC1readpayer.Size = New System.Drawing.Size(78, 24)
        Me.btC1readpayer.TabIndex = 18
        Me.btC1readpayer.Text = "文件数据集"
        '
        'FrmConPayer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(1061, 577)
        Me.Controls.Add(Me.C1readpayer)
        Me.Controls.Add(Me.OpenFile)
        Me.Controls.Add(Me.txtpayer)
        Me.Controls.Add(Me.btC1readpayer)
        Me.Controls.Add(Me.btreadpayer)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cbShipAgent)
        Me.Controls.Add(Me.btClose)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btResure)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmConPayer"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "互租信息"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.C1_con_hatch_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.C1_Payer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.C1_Blno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1readpayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim sqlstr As String
    Dim dsship As New DataSet
    Dim dspayer As New DataSet
    Dim dwpayer As New DataView
    Dim sqladpayer As New SqlClient.SqlDataAdapter

    Private Sub FrmConPayer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillShipAgent()
        sqlstr = " select agent from sship where ship_id =" & Ship_ID
        Getdata(sqlstr, dsship)
        Me.cbShipAgent.SelectedValue = dsship.Tables(0).Rows(0)(0).ToString()
        FillHatchlist()
    End Sub

    Private Sub FillShipAgent()
        Dim sqldc As String
        Dim dvc As New DataView
        Dim dsc As New DataSet
        sqldc = "SELECT CODE_SHIP_AGENT, SHIPAGENT_SHORT FROM CODE_SHIP_AGENT where Mark='1' or Mark is Null ORDER BY SHIPAGENT_SHORT"
        Me.cbShipAgent.DataSource = DBControl.Getdata(sqldc, dsc)
        Me.cbShipAgent.DisplayMember = "SHIPAGENT_SHORT"
        Me.cbShipAgent.ValueMember = "CODE_SHIP_AGENT"
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
            Me.C1_con_hatch_list.Columns.Item("blno").Caption = "提单"
            Me.C1_con_hatch_list.Columns.Item("code_payer").Caption = "付费人"
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
            Me.C1_con_hatch_list.Columns("blno").FooterText = "合计 " & C1_con_hatch_list.RowCount & " 条"
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
            Me.C1_Payer.Columns("CODE_PAYER").Caption = "付费人"
            Me.C1_Payer.Columns("SIZE_CON").Caption = "尺寸"
            Me.C1_Payer.Columns("FULLOREMPTY").Caption = "箱型"
            Me.C1_Payer.Columns("hj").Caption = "箱数"
            Me.C1_Payer.Columns("NIGHT_MARK").Caption = "夜班"
            Me.C1_Payer.Columns("HOLIDAY").Caption = "节假日"
            Me.C1_Payer.Columns("INOUT_MARK").Caption = "出仓"
            Me.C1_Payer.Columns("RELOAD").Caption = "重装"
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
        Me.C1_Payer.Columns("CODE_PAYER").FooterText = "共" & C1_Payer.RowCount & " 条"
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
            Me.C1_Blno.Columns("BLNO").Caption = "提单"
            Me.C1_Blno.Columns("SIZE_CON").Caption = "尺寸"
            Me.C1_Blno.Columns("FULLOREMPTY").Caption = "箱型"
            Me.C1_Blno.Columns("hj").Caption = "箱数"
            Me.C1_Blno.Columns("NIGHT_MARK").Caption = "夜班"
            Me.C1_Blno.Columns("HOLIDAY").Caption = "节假日"
            Me.C1_Blno.Columns("INOUT_MARK").Caption = "出仓"
            Me.C1_Blno.Columns("RELOAD").Caption = "重装"
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
        Me.C1_Blno.Columns("BLNO").FooterText = "共" & C1_Blno.RowCount & " 条"
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
            'Me.C1_Blno.Columns.Item("hj").FooterText = CType(hj, String)
            Me.C1_Blno.Columns.Item("NIGHT_MARK").FooterText = CType(NIGHT_MARK, String)
            Me.C1_Blno.Columns.Item("HOLIDAY").FooterText = CType(HOLIDAY, String)
            Me.C1_Blno.Columns.Item("INOUT_MARK").FooterText = CType(INOUT_MARK, String)
            Me.C1_Blno.Columns.Item("RELOAD").FooterText = CType(RELOAD, String)
            Exit For
        Next

    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            If MsgBox("确认要保存吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then
                sqladpayer.Update(dspayer)
                FillHatchlist()
                '生成标准账单
                Dim str_sql As String
                str_sql = String.Format("sp_fee_standard  {0},'{1}','{2}'", Ship_ID, G_DeptCode, G_User)
                ExecSql(str_sql)
                '生成审核数据库的标准账单
                str_sql = String.Format("sp_fee_standard  {0},'{1}','{2}'", Ship_ID, G_DeptCode, G_User)
                ExecSql_ver(str_sql)
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btClose.Click
        Me.Close()
    End Sub

    Private Sub btResure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btResure.Click
        Try
            If MsgBox("确认要更改全部提单的船代信息吗？", MsgBoxStyle.YesNo + vbExclamation, "提示") = MsgBoxResult.Yes Then
                sqlstr = " update CON_HATCH_LIST set code_payer='" & cbShipAgent.SelectedValue & "' where ship_id=" & Ship_ID
                ExecSql(sqlstr)
                sqlstr = " update CON_TALLY_DETAIL set code_ship_agent='" & cbShipAgent.SelectedValue & "' where con_tally_list_id in (select con_tally_list_id from con_tally_list where ship_id=" & Ship_ID & ")"
                ExecSql(sqlstr)
                FillHatchlist()
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Data_Conn As New System.Data.OleDb.OleDbConnection

    Private Sub btreadpayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btreadpayer.Click
        Dim Str0 As String
        Dim k1 As Integer
        Try
            If txtpayer.Text.Trim.Length > 0 Then
                Dim Ds As New DataSet
                Dim dv As New DataView
                Dim FilePath As String
                Dim ad As New System.Data.OleDb.OleDbDataAdapter

                FilePath = txtpayer.Text
                Data_Conn.ConnectionString = "provider=Microsoft.Jet.OLEDB.4.0; data source=" & FilePath & ";Extended Properties=Excel 8.0;" ';password=DWDD"
                'Str0 = "select * from [Sheet1$]"
                Str0 = "select * from [中理$]"
                ad.SelectCommand = New System.Data.OleDb.OleDbCommand(Str0, Data_Conn)
                ad.Fill(Ds)
                k1 = Ds.Tables(0).Rows.Count

                C1readpayer.DataSource = Ds.Tables(0).DefaultView
                Me.C1readpayer.Splits(0).DisplayColumns(0).Width = 100
                Me.C1readpayer.Splits(0).DisplayColumns(1).Width = 120
                Me.C1readpayer.Visible = True
                Me.C1readpayer.Columns(0).FooterText = "共" & C1readpayer.RowCount & " 条"

                Dim i As Integer
                Dim payer As String
                Dim c_payer As String
                Dim blno As String
                Dim ds_codepayer As New DataSet
                For i = 0 To k1 - 1
                    payer = Ds.Tables(0).Rows(i)(0).ToString()
                    blno = Ds.Tables(0).Rows(i)(1).ToString()
                    If i = 48 Then
                        Dim j As Integer
                        j = 0
                    End If
                    'If blno = "SITRLYNG024952" Then
                    '    Dim j As Integer
                    '    j = 0
                    'End If
                    Getdata("select CODE_SHIP_AGENT FROM CODE_SHIP_AGENT where SHIPAGENT_SHORT='" & payer & "'", ds_codepayer)
                    If ds_codepayer.Tables(0).Rows.Count > 0 Then
                        c_payer = ds_codepayer.Tables(0).Rows(0)(0)
                        ExecSql("update CON_HATCH_LIST set code_payer='" & c_payer & "' where ship_id=" & Ship_ID & " and blno='" & blno & "'")
                    End If
                Next

                '写入操作日志文件 
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
                st_log = String.Format("insert into con_info(worktype, shipid, cntr, bayno, truckno, ioport, workno, instime, message, dx) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}') ", "ImportConPayer", Ship_ID, "", "", " ", GL_IOPORT, G_WorkNo, Now.ToString(), "ImportConPayer" + "." + "filepath." + txtpayer.Text + "." + myname + "." + ip, " ")
                ExecSql(st_log)

                C1readpayer.Visible = False
                FillHatchlist()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "提示")
        End Try

    End Sub

    Private Sub OpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFile.Click
        OpenFileDialog.AddExtension = True
        OpenFileDialog.DefaultExt = "*.*"
        OpenFileDialog.InitialDirectory = "D:\"
        OpenFileDialog.ShowDialog()
        txtpayer.Text = OpenFileDialog.FileName
    End Sub

    Private Sub btC1readpayer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btC1readpayer.Click
        C1readpayer.Visible = Not (C1readpayer.Visible)
    End Sub
End Class
