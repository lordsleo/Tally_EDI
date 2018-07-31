Imports TALLY.DBControl
Public Class FrmConHatchCargo_Edit
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim adContainer As New SqlClient.SqlDataAdapter()
    Dim dsContainer As New DataSet()

    Dim strPinContainerNo(500) As String
    Dim max As Short = -1
    Dim sqlCondition As String
    Dim strFirstConNo(2500) As String
    Dim Amount As Short = -1

    Dim id(500), ship(500), consize(500), sum(500) As String
    Dim weight(500), volume(500) As String
    Dim containerno(500), conType(500), overheight(500), fullorempty(500), sealno(500), bayno(500), manufactno(500), manufact(500), keepercode(500), keeper(500), position(500), passmark(500), shortunload(500), unloadmark(500), user(500) As String
    Dim t As Short = -1

    Dim dvLoadPort As New DataView()
    Dim dvUnloadPort As New DataView()
    Dim dvReceivePlace As New DataView()
    Dim Mark1 As Boolean
    Dim Count, delSum As Integer
    Friend WithEvents txtPayerCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        AddHandler txtBillNO.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler cbLoadPort.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler cbUnloadPort.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler txtGOODS_CHA.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler txtAmount.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler txtCONTAINER.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler txtGROSS_WEIGHT.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler cbLoadPortEng.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler cbUnloadPortEng.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler txtPayerCode.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
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
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCONTAINER As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGROSS_WEIGHT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents txtBillNO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtGOODS_CHA As System.Windows.Forms.TextBox
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents cbUnloadPort As System.Windows.Forms.ComboBox
    Friend WithEvents cbLoadPort As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents cbUnloadPortEng As System.Windows.Forms.ComboBox
    Friend WithEvents cbLoadPortEng As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConHatchCargo_Edit))
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtCONTAINER = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtGROSS_WEIGHT = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCommit = New System.Windows.Forms.Button
        Me.btQuit = New System.Windows.Forms.Button
        Me.txtBillNO = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtGOODS_CHA = New System.Windows.Forms.TextBox
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btnDelete = New System.Windows.Forms.Button
        Me.cbUnloadPort = New System.Windows.Forms.ComboBox
        Me.cbLoadPort = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.cbUnloadPortEng = New System.Windows.Forms.ComboBox
        Me.cbLoadPortEng = New System.Windows.Forms.ComboBox
        Me.txtPayerCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(498, 6)
        Me.txtAmount.MaxLength = 20
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(130, 21)
        Me.txtAmount.TabIndex = 353
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(424, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 383
        Me.Label10.Text = "总件数"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCONTAINER
        '
        Me.txtCONTAINER.Enabled = False
        Me.txtCONTAINER.Location = New System.Drawing.Point(498, 54)
        Me.txtCONTAINER.MaxLength = 20
        Me.txtCONTAINER.Name = "txtCONTAINER"
        Me.txtCONTAINER.Size = New System.Drawing.Size(130, 21)
        Me.txtCONTAINER.TabIndex = 354
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(424, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 378
        Me.Label3.Text = "集装箱数"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGROSS_WEIGHT
        '
        Me.txtGROSS_WEIGHT.Location = New System.Drawing.Point(498, 30)
        Me.txtGROSS_WEIGHT.MaxLength = 20
        Me.txtGROSS_WEIGHT.Name = "txtGROSS_WEIGHT"
        Me.txtGROSS_WEIGHT.Size = New System.Drawing.Size(100, 21)
        Me.txtGROSS_WEIGHT.TabIndex = 358
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(424, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 373
        Me.Label1.Text = "毛重"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(254, 330)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(65, 24)
        Me.btnCommit.TabIndex = 370
        Me.btnCommit.Text = "保存"
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(322, 330)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 368
        Me.btQuit.Text = "取消"
        '
        'txtBillNO
        '
        Me.txtBillNO.Location = New System.Drawing.Point(78, 6)
        Me.txtBillNO.MaxLength = 20
        Me.txtBillNO.Name = "txtBillNO"
        Me.txtBillNO.Size = New System.Drawing.Size(130, 21)
        Me.txtBillNO.TabIndex = 333
        '
        'Label4
        '
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(4, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 380
        Me.Label4.Text = "提单号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(0, 0)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 371
        Me.txtID.Visible = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(4, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 398
        Me.Label7.Text = "货物描述"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGOODS_CHA
        '
        Me.txtGOODS_CHA.Location = New System.Drawing.Point(8, 50)
        Me.txtGOODS_CHA.MaxLength = 200
        Me.txtGOODS_CHA.Multiline = True
        Me.txtGOODS_CHA.Name = "txtGOODS_CHA"
        Me.txtGOODS_CHA.Size = New System.Drawing.Size(200, 48)
        Me.txtGOODS_CHA.TabIndex = 351
        '
        'C1DBG
        '
        Me.C1DBG.AllowAddNew = True
        Me.C1DBG.AllowDelete = True
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("C1DBG.Images"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 106)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.PageSettings = CType(resources.GetObject("C1DBG.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBG.Size = New System.Drawing.Size(634, 218)
        Me.C1DBG.TabIndex = 369
        Me.C1DBG.PropBag = resources.GetString("C1DBG.PropBag")
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(104, 330)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(65, 24)
        Me.btnDelete.TabIndex = 405
        Me.btnDelete.Text = "箱删除"
        '
        'cbUnloadPort
        '
        Me.cbUnloadPort.Location = New System.Drawing.Point(288, 56)
        Me.cbUnloadPort.MaxDropDownItems = 20
        Me.cbUnloadPort.Name = "cbUnloadPort"
        Me.cbUnloadPort.Size = New System.Drawing.Size(130, 20)
        Me.cbUnloadPort.TabIndex = 417
        '
        'cbLoadPort
        '
        Me.cbLoadPort.Location = New System.Drawing.Point(288, 8)
        Me.cbLoadPort.MaxDropDownItems = 20
        Me.cbLoadPort.Name = "cbLoadPort"
        Me.cbLoadPort.Size = New System.Drawing.Size(130, 20)
        Me.cbLoadPort.TabIndex = 416
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(214, 82)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 18)
        Me.Label22.TabIndex = 414
        Me.Label22.Text = "卸货港英文"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(214, 34)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 18)
        Me.Label23.TabIndex = 409
        Me.Label23.Text = "装货港英文"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(214, 10)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 18)
        Me.Label24.TabIndex = 413
        Me.Label24.Text = "装货港"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(214, 58)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(72, 18)
        Me.Label32.TabIndex = 410
        Me.Label32.Text = "卸货港"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(598, 32)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(30, 20)
        Me.Label35.TabIndex = 421
        Me.Label35.Text = "公斤"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbUnloadPortEng
        '
        Me.cbUnloadPortEng.Location = New System.Drawing.Point(288, 80)
        Me.cbUnloadPortEng.MaxDropDownItems = 20
        Me.cbUnloadPortEng.Name = "cbUnloadPortEng"
        Me.cbUnloadPortEng.Size = New System.Drawing.Size(130, 20)
        Me.cbUnloadPortEng.TabIndex = 426
        '
        'cbLoadPortEng
        '
        Me.cbLoadPortEng.Location = New System.Drawing.Point(288, 32)
        Me.cbLoadPortEng.MaxDropDownItems = 20
        Me.cbLoadPortEng.Name = "cbLoadPortEng"
        Me.cbLoadPortEng.Size = New System.Drawing.Size(130, 20)
        Me.cbLoadPortEng.TabIndex = 425
        '
        'txtPayerCode
        '
        Me.txtPayerCode.Location = New System.Drawing.Point(498, 79)
        Me.txtPayerCode.MaxLength = 20
        Me.txtPayerCode.Name = "txtPayerCode"
        Me.txtPayerCode.Size = New System.Drawing.Size(130, 21)
        Me.txtPayerCode.TabIndex = 427
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(424, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 428
        Me.Label2.Text = "收费对象码"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmConHatchCargo_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(634, 359)
        Me.Controls.Add(Me.txtPayerCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbUnloadPortEng)
        Me.Controls.Add(Me.cbLoadPortEng)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.cbUnloadPort)
        Me.Controls.Add(Me.cbLoadPort)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCONTAINER)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtGROSS_WEIGHT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.txtBillNO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtGOODS_CHA)
        Me.Controls.Add(Me.C1DBG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConHatchCargo_Edit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "集装箱舱单信息 修改"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub FrmConHatchCargo_Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Dim dwCodeGoods As New DataView()
        Dim sqlCodeGoods, sqlEmptyMark, sqlContainerMark As String
        Dim dwEmptyMark As New DataView()
        Dim dwContainerMark As New DataView()
        dvLoadPort.RowFilter = ""

        'sqlstr = "SELECT * FROM CON_HATCH_LIST WHERE SHIP_ID = '" & Ship_ID & "' AND BLNO = '" & FrmConHatchCargo.Bill_ID & "' AND MARK = '" & FrmConHatchCargo.Mark_ID & "'"
        sqlstr = "SELECT * FROM CON_HATCH_LIST WHERE SHIP_ID = '" & Ship_ID & "' AND BLNO = '" & FrmConHatchCargo.Bill_ID & "'"
        dw = Updatedata(sqlda, sqlstr, ds)

        Dim strPort As String
        strPort = "SELECT CODE_PORT, PORT_CHA, PORT_ENG FROM CODE_PORT ORDER BY CODE_PORT"
        dvLoadPort = Filldata(strPort)
        dvUnloadPort = Filldata(strPort)
        Me.cbLoadPort.DataSource = dvLoadPort
        Me.cbLoadPort.DisplayMember = "PORT_CHA"
        Me.cbLoadPort.ValueMember = "CODE_PORT"
        Me.cbUnloadPort.DataSource = dvUnloadPort
        Me.cbUnloadPort.DisplayMember = "PORT_CHA"
        Me.cbUnloadPort.ValueMember = "CODE_PORT"
 

        Me.cbLoadPortEng.DataSource = dvLoadPort
        Me.cbLoadPortEng.DisplayMember = "PORT_ENG"
        Me.cbLoadPortEng.ValueMember = "CODE_PORT"
        Me.cbUnloadPortEng.DataSource = dvUnloadPort
        Me.cbUnloadPortEng.DisplayMember = "PORT_ENG"
        Me.cbUnloadPortEng.ValueMember = "CODE_PORT"

        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("CON_HATCH_LIST_ID")
            txtBillNO.Text = ds.Tables(0).Rows(0).Item("BLNO")
            txtGOODS_CHA.Text = ds.Tables(0).Rows(0).Item("GOODS_CHA")
            Me.cbLoadPort.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_LOAD_PORT")
            Me.cbUnloadPort.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT")
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("CONTAINER")) Then
                txtCONTAINER.Text = ds.Tables(0).Rows(0).Item("CONTAINER")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("AMOUNT")) Then
                txtAmount.Text = ds.Tables(0).Rows(0).Item("AMOUNT")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("GROSS_WEIGHT")) Then
                txtGROSS_WEIGHT.Text = ds.Tables(0).Rows(0).Item("GROSS_WEIGHT")
            End If

            If Me.cbLoadPort.SelectedValue Is Nothing Then
                cbLoadPort.Text = ds.Tables(0).Rows(0).Item("CODE_LOAD_PORT")
            End If
            If Me.cbUnloadPort.SelectedValue Is Nothing Then
                cbUnloadPort.Text = ds.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT")
            End If
        End If
        sqlCondition = " CON_HATCH_CARGO.SHIP_ID =  '" & Ship_ID & "' AND CON_HATCH_CARGO.BLNO = '" & FrmConHatchCargo.Bill_ID & "' "
        'Dim sqlCondition As String = " SHIP_ID =  '" & Ship_ID & "' AND Expr1 = '" & FrmConHatchCargo.Bill_ID & "' AND Expr2 = '" & FrmConHatchCargo.Mark_ID & "'"
        InitSubTable(sqlCondition)     '初始化子表c1grid
        If Count > 0 Then
            txtPayerCode.Text = dsContainer.Tables(0).Rows(0)("CODE_PAYER").ToString()
        End If
        Amount = Me.C1DBG.Row
        Me.C1DBG.Row += 1
        While Me.C1DBG.Row <> Amount    '计算原箱数
            Amount = Me.C1DBG.Row
            Me.C1DBG.Row += 1
        End While
        Dim i As Short
        For i = 0 To Amount - 1   '记录原箱号
            strFirstConNo(i) = Me.C1DBG.Columns("CONTAINER_NO").CellText(i)
        Next

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub InitSubTable(ByVal sqlCondition As String)
        Try
            Dim sqlContainer As String
            'sqlContainer = "SELECT CON_HATCH_RECORD.* FROM CON_HATCH_RECORD INNER JOIN CON_HATCH_CARGO ON CON_HATCH_RECORD.SHIP_ID = CON_HATCH_CARGO.SHIP_ID AND CON_HATCH_RECORD.CONTAINER_NO = CON_HATCH_CARGO.CONTAINER_NO WHERE " & sqlCondition
            'sqlContainer = "SELECT * FROM CON_HATCH_RECORD where 1=0 "
            sqlContainer = "SELECT CON_HATCH_RECORD_ID,SHIP_ID,CONTAINER_NO,SEALNO,SealCheck,SIZE_CON,CONTAINER_TYPE,OVER_HEIGHT,FULLOREMPTY,BAYNO,BLNO,CODE_GOODS,AMOUNT,WEIGHT,VOLUME," & _
                " Code_MANUFACTURER,MANUFACTURER,CODE_KEEPER,KEEPER,ReeferTemp,TempUnit,DangerGrade,DangerMark,POSITION_CONTAINER,PASS_MARK,SHORT_UNLOAD,Unload_Mark,USER_NAME,USER_CODE,CODE_PAYER " & _
                " FROM CON_HATCH_RECORD where ship_id = '" & Ship_ID & "' and container_no in (select con_hatch_cargo.container_no from con_hatch_cargo where " & sqlCondition & " )"
            Me.C1DBG.DataSource = Updatedata(adContainer, sqlContainer, dsContainer)

            Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue

            Me.C1DBG.Splits(0).DisplayColumns.Item("CON_HATCH_RECORD_ID").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("SHIP_ID").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("BLNO").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("CODE_GOODS").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("POSITION_CONTAINER").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("PASS_MARK").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("SHORT_UNLOAD").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("USER_NAME").Visible = False

            Me.C1DBG.Splits(0).DisplayColumns.Item("Code_MANUFACTURER").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("MANUFACTURER").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("KEEPER").Visible = False

            Me.C1DBG.Splits(0).DisplayColumns.Item("AMOUNT").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("WEIGHT").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("VOLUME").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("Unload_Mark").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("BAYNO").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("OVER_HEIGHT").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("USER_CODE").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("CODE_PAYER").Visible = False

            Me.C1DBG.Columns.Item("CONTAINER_NO").Caption = "集装箱号"
            Me.C1DBG.Columns.Item("SIZE_CON").Caption = "箱尺寸"
            Me.C1DBG.Columns.Item("CONTAINER_TYPE").Caption = "箱型"
            Me.C1DBG.Columns.Item("FULLOREMPTY").Caption = "箱状态"
            Me.C1DBG.Columns.Item("SEALNO").Caption = "铅封号"
            Me.C1DBG.Columns.Item("CODE_KEEPER").Caption = "箱经营人"
            Me.C1DBG.Columns.Item("SealCheck").Caption = "查封"
            Me.C1DBG.Columns.Item("ReeferTemp").Caption = "冷藏温度"
            Me.C1DBG.Columns.Item("TempUnit").Caption = "温标"
            Me.C1DBG.Columns.Item("DangerGrade").Caption = "危品等级"
            Me.C1DBG.Columns.Item("DangerMark").Caption = "危品标签"

            Call FiledFill()
            SetColumnWidth()
            dsContainer.Tables(0).Columns("USER_NAME").DefaultValue = G_User
            dsContainer.Tables(0).Columns("SHIP_ID").DefaultValue = Ship_ID

            Me.C1DBG.ColumnFooters = True
            Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
            Me.C1DBG.Columns.Item("CONTAINER_NO").FooterText = "合计" & dsContainer.Tables(0).Rows.Count & "条"
            Count = dsContainer.Tables(0).Rows.Count
            delSum = 0
        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FiledFill()
        Dim sqla As New SqlClient.SqlDataAdapter()
        Dim sqlc As New SqlClient.SqlCommand()
        Dim dsItem As New DataSet()
        Dim i As Integer
        Try
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT EFL_Code, EFL_Name FROM Code_ConEFLType"
            sqla.SelectCommand = sqlc
            dsItem.Reset()
            sqla.Fill(dsItem)
            Me.C1DBG.Columns("FULLOREMPTY").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            'Me.C1DBG.Columns("FULLOREMPTY").ValueItems.Translate = True

            For i = 0 To dsItem.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
                vi.DisplayValue = dsItem.Tables(0).Rows(i)("EFL_Name")
                vi.Value = dsItem.Tables(0).Rows(i)("EFL_Code")
                Me.C1DBG.Columns.Item("FULLOREMPTY").ValueItems.Values.Add(vi)
            Next

            Dim sqlConKind As String = "SELECT CODE_CON_KIND, CON_KIND_ENG FROM CODE_CON_KIND ORDER BY CODE_CON_KIND"
            Dim dvConKind As New DataView()
            dvConKind = Filldata(sqlConKind)
            Me.C1DBG.Columns("CONTAINER_TYPE").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("CONTAINER_TYPE").ValueItems.Translate = True
            For i = 0 To dvConKind.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
                vi.DisplayValue = dvConKind(i)("CON_KIND_ENG")
                vi.Value = dvConKind(i)("CODE_CON_KIND")
                Me.C1DBG.Columns.Item("CONTAINER_TYPE").ValueItems.Values.Add(vi)
            Next

            Dim sqlKeeper As String
            Dim dvKeeper As New DataView()
            sqlKeeper = "SELECT Code_Con_Company, Con_Company_CHI, Con_Company_ENG FROM Code_Con_Company ORDER BY Con_Company_CHI"
            dvKeeper = Filldata(sqlKeeper)
            Me.C1DBG.Columns("CODE_KEEPER").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("CODE_KEEPER").ValueItems.Translate = True
            For i = 0 To dvKeeper.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
                vi.DisplayValue = dvKeeper(i)("Con_Company_CHI")
                vi.Value = dvKeeper(i)("Code_Con_Company")
                Me.C1DBG.Columns.Item("CODE_KEEPER").ValueItems.Values.Add(vi)
            Next

        Catch ex As System.Exception
            MsgBox(ex.Message)
        Finally
            sqlconn.Close()
        End Try
    End Sub

    Private Sub SetColumnWidth()
        Dim i As Integer
        Try
            i = 2
            Do While i < Me.C1DBG.Columns.Count
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Width = 70
                i = i + 1
            Loop
            Me.C1DBG.Splits(0).DisplayColumns("SIZE_CON").Width = 40
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_TYPE").Width = 40
            Me.C1DBG.Splits(0).DisplayColumns("FULLOREMPTY").Width = 40
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Width = 90
            Me.C1DBG.Splits(0).DisplayColumns("SEALNO").Width = 90
            Me.C1DBG.Splits(0).DisplayColumns("CODE_KEEPER").Width = 100
            Me.C1DBG.Splits(0).DisplayColumns("SealCheck").Width = 20
            Me.C1DBG.Splits(0).DisplayColumns("ReeferTemp").Width = 40
            Me.C1DBG.Splits(0).DisplayColumns("TempUnit").Width = 40

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub C1DBG_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles C1DBG.RowColChange
        '当前做法要求对 c1grid控件 
        If e.LastCol = 2 And e.LastRow = Me.C1DBG.Row Then
            Dim sqlGetContainer As String = "SELECT * FROM CON_HATCH_RECORD WHERE SHIP_ID = '" & Ship_ID & "' AND ( CONTAINER_NO = '" & Me.C1DBG.Columns("CONTAINER_NO").CellText(e.LastRow).Trim.ToUpper & "' or CONTAINER_NO = '" & GetConOtherMode(Me.C1DBG.Columns("CONTAINER_NO").CellText(e.LastRow)) & "') AND FULLOREMPTY = 'L'"
            Dim dvGetContainer As New DataView()
            Dim j As Short = 0
            Dim i As Short
            dvGetContainer = Filldata(sqlGetContainer)
            Me.C1DBG.Row = e.LastRow        '将当前行位置强行拉回
            Try
                If dvGetContainer.Count = 1 Then
                    For i = 3 To dvGetContainer.Table.Columns.Count - 1
                        Me.C1DBG.Columns(i).Value = dvGetContainer.Item(0)(i)      '调出数据填充 c1grid
                    Next
                    If max >= 0 Then   '如果已有记录
                        For j = 0 To max
                            If Trim(Me.C1DBG.Columns("CONTAINER_NO").CellText(e.LastRow).ToUpper) = strPinContainerNo(j) Then
                                '如果当前拼箱号已被记录，不重复记录
                                Exit For
                            End If
                        Next
                    End If
                    If j > max Then
                        For j = 0 To Amount - 1
                            If Me.C1DBG.Columns("CONTAINER_NO").CellText(e.LastRow).Trim.ToUpper = strFirstConNo(j) Then
                                Exit For    '如果此箱号与该提单唛头其他箱号重复，不记录
                            End If
                        Next
                    End If
                    If j >= Amount Then
                        max += 1        '记录当前拼箱号
                        strPinContainerNo(max) = Trim(Me.C1DBG.Columns("CONTAINER_NO").CellText(e.LastRow).ToUpper)
                    End If

                    If max > 99 Then
                        MessageBox.Show("同一船次 同一提单 同一唛头不可能有100条拼箱信息吧？")
                    End If
                ElseIf dvGetContainer.Count = 0 Then
                End If  '这样做，记录箱号没有重复，但原先被记录箱号如果被删除或更改，记录仍然存在，这是多余的记录

                If e.LastCol = 11 Then

                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Function IsCode(ByVal str As String) As Boolean    ' 两头不空
        Dim i As Integer
        Dim ch As Char
        str = str.ToUpper
        If str.Length <= 5 Then
            For i = 1 To str.Length
                ch = Mid(str, i, 1)
                If Not (ch Like "[A-Z]" Or ch = " ") Then
                    Exit For
                End If
            Next
        End If
        If i > str.Length Then
            Return True     '最长五位，中间可空
        Else
            Return False
        End If
    End Function

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        Dim sqlUnique As String
        Try
            If Trim(Me.txtBillNO.Text) <> "" Then
                If Me.SetNumValue("AMOUNT", txtAmount.Text, "件数") = False Then
                    txtAmount.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("GROSS_WEIGHT", txtGROSS_WEIGHT.Text, "总重量") = False Then
                    Me.txtGROSS_WEIGHT.Focus()
                    Exit Sub
                End If

                If Not IsNothing(Me.cbLoadPort.SelectedValue) Then  '港口代码能取到
                    ds.Tables(0).Rows(0).Item("CODE_LOAD_PORT") = Me.cbLoadPort.SelectedValue
                    ds.Tables(0).Rows(0).Item("LOAD_PORT") = Trim(Me.cbLoadPort.Text.ToUpper)
                Else
                    If IsCode(Me.cbLoadPort.Text.Trim()) Then     '判断是代码的形式
                        ds.Tables(0).Rows(0).Item("CODE_LOAD_PORT") = Trim(Me.cbLoadPort.Text.ToUpper)
                    Else
                        MessageBox.Show("装货港中文名不能取得时，必须输入港口代码才能保存。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.cbLoadPort.Focus()
                        Exit Sub
                    End If
                End If
                If Not IsNothing(Me.cbUnloadPort.SelectedValue) Then  '港口代码能取到
                    ds.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT") = Me.cbUnloadPort.SelectedValue
                    ds.Tables(0).Rows(0).Item("UNLOAD_PORT") = Trim(Me.cbUnloadPort.Text.ToUpper)
                Else
                    If IsCode(Me.cbUnloadPort.Text.Trim()) Then     '判断是代码的形式
                        ds.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT") = Trim(Me.cbUnloadPort.Text.ToUpper)
                    Else
                        MessageBox.Show("卸货港中文名不能取得时，必须输入港口代码才能保存。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.cbUnloadPort.Focus()
                        Exit Sub
                    End If
                End If

                'sqlUnique = "SELECT * FROM CON_HATCH_LIST WHERE SHIP_ID = '" & Ship_ID & "' AND BLNO = '" & Trim(Me.txtBillNO.Text) & "' AND MARK = '" & Trim(Me.txtMark.Text) & _
                '            "' and CON_HATCH_LIST_ID <> '" & Trim(txtID.Text) & "'"
                sqlUnique = "SELECT * FROM CON_HATCH_LIST WHERE SHIP_ID = '" & Ship_ID & "' AND BLNO = '" & Trim(Me.txtBillNO.Text) & _
                            "' and CON_HATCH_LIST_ID <> '" & Trim(txtID.Text) & "'"
                If Filldata(sqlUnique).Count = 0 Then
                    'sqlCondition = " CON_HATCH_CARGO.SHIP_ID =  '" & Ship_ID & "' AND CON_HATCH_CARGO.BLNO = '" & Trim(Me.txtBillNO.Text) & "' "

                    ds.Tables(0).Rows(0).Item("BLNO") = Trim(Me.txtBillNO.Text).ToUpper
                    ds.Tables(0).Rows(0).Item("GOODS_CHA") = Trim(Me.txtGOODS_CHA.Text)
                    ds.Tables(0).Rows(0).Item("CONTAINER") = Count - delSum
                    'ds.Tables(0).Rows(0).Item("SHIP_ID") = Ship_ID
                    'ds.Tables(0).Rows(0).Item("USER_NAME") = G_User
                    Call OperateSubTable()
                Else
                    MessageBox.Show("同一船次 提单号 不可重复", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("提单号不可为空", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function SetNumValue(ByVal strNumColumn As String, ByVal strNumValue As String, Optional ByVal message As String = "数据") As Boolean
        Dim flag As Boolean = True
        If Trim(strNumValue) <> "" Then
            If IsNumeric(Trim(strNumValue)) Then
                ds.Tables(0).Rows(0).Item(strNumColumn) = Trim(strNumValue)
            Else
                MessageBox.Show(message + "应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                flag = False
            End If
        Else    '此列留空
            ds.Tables(0).Rows(0).Item(strNumColumn) = DBNull.Value
        End If
        Return flag
    End Function

    Private Function CheckConNO(ByVal sm As String) As Integer 'return 0 箱号有错 1 校验有错 2 校验正确
        Dim S() As Integer = {10, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 34, 35, 36, 37, 38}
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim l As Integer
        i = 0
        str = UCase(sm)
        If Len(Trim(str)) = 12 And Mid(Trim(str), 5, 1) = " " Then
            str = Mid(Trim(str), 1, 4) & Mid(Trim(str), 6, 7)
        ElseIf Len(Trim(str)) <> 11 Then
            Return 0
        End If
        k = 1
        For j = 1 To 4
            If Asc(Mid(Trim(str), j, 1)) >= Asc("A") And Asc(Mid(Trim(str), j, 1)) <= Asc("Z") Then
                i = i + S(Asc(Mid(Trim(str), j, 1).ToUpper) - Asc("A")) * System.Math.Pow(2, k - 1)
            Else
                Return 0
            End If

            k = k + 1
        Next

        For j = 5 To 10
            If Asc(Mid(Trim(str), j, 1)) >= Asc("0") And Asc(Mid(Trim(str), j, 1)) <= Asc("9") Then
                i = i + CInt(Mid(Trim(str), j, 1)) * System.Math.Pow(2, k - 1)
            Else
                Return 0
            End If

            k = k + 1
        Next
        If i Mod 11 = CInt(Mid(Trim(str), 11, 1)) Or (i Mod 11) - 10 = CInt(Mid(Trim(str), 11, 1)) Then
            Return 2
        Else
            Return 1
        End If
    End Function

    Private Function IsEqualConNo(ByVal ConOne As String, ByVal ConTwo As String) As Boolean    '判断箱号是否箱等
        Dim Flag As Boolean
        ConOne = ConOne.Trim.ToUpper
        ConTwo = ConTwo.Trim.ToUpper
        If ConOne.Length = ConTwo.Length Then
            If String.Equals(ConOne, ConTwo) Then
                Flag = True
            End If
        Else
            If String.Equals(ConOne, GetConOtherMode(ConTwo)) Then
                Flag = True
            End If
        End If
        Return Flag
    End Function

    Private Function GetConOtherMode(ByVal ConNo As String) As String   '得到箱号的另一种无空或有空形式
        ConNo = ConNo.Trim.ToUpper
        If ConNo.Length = 11 Then
            ConNo = ConNo.Insert(4, " ")
        ElseIf ConNo.Length = 12 Then
            ConNo = ConNo.Remove(4, 1)
        End If
        Return ConNo
    End Function

    Private Sub TrimGrid()
        Dim i As Integer
        Me.C1DBG.Focus()
        For i = 0 To Count - delSum - 1
            Me.C1DBG.Row = i
            Me.C1DBG.Columns("CONTAINER_NO").Text = Me.C1DBG.Columns("CONTAINER_NO").Text.Trim.ToUpper
            Me.C1DBG.Columns("SEALNO").Text = Me.C1DBG.Columns("SEALNO").Text.Trim().ToUpper
            Me.C1DBG.Columns("CONTAINER_TYPE").Text = Me.C1DBG.Columns("CONTAINER_TYPE").Text.Trim().ToUpper
            Me.C1DBG.Columns("FULLOREMPTY").Text = Me.C1DBG.Columns("FULLOREMPTY").Text.Trim().ToUpper
            'Me.C1DBG.Columns("BAYNO").Text = Me.C1DBG.Columns("BAYNO").Text.Trim()
        Next
        Me.btQuit.Focus()
    End Sub

    Private Function IsEqualBayNo(ByVal strBayNo1 As String, ByVal strBayNo2 As String) As Boolean
        Dim Sign As Boolean                                 '比较贝位号是否重复
        strBayNo1 = strBayNo1.Trim
        strBayNo2 = strBayNo2.Trim
        If String.Equals(strBayNo1, strBayNo2) Or String.Equals(strBayNo1, TongBayNoFont(strBayNo2)) Or String.Equals(strBayNo1, TongBayNoLater(strBayNo2)) Then
        Else
            Sign = True
        End If
        Return Sign
    End Function

    Private Function TongBayNoFont(ByVal strBayNo As String) As String  '得到“前通贝号”
        Dim strBayNoFont As String
        strBayNoFont = strBayNo.Trim
        strBayNoFont = String.Concat(CStr(CInt(String.Concat("2", strBayNoFont.Substring(0, 2))) - 1), strBayNoFont.Substring(2, 4)).Substring(1, 6)
        Return strBayNoFont
    End Function

    Private Function TongBayNoLater(ByVal strBayNo As String) As String  '得到“后通贝号”
        Dim strBayNoLater As String
        strBayNoLater = strBayNo.Trim
        strBayNoLater = String.Concat(CStr(CInt(String.Concat("2", strBayNoLater.Substring(0, 2))) + 1), strBayNoLater.Substring(2, 4)).Substring(1, 6)
        Return strBayNoLater
    End Function

    Private Sub OperateSubTable()
        Dim sqlEditRelation, sqlInsertRelation, sqlDeleteRelation, sqlConExist, sqlBayExist, sqlBeing As String
        Dim strContainer, strSealNO, strBayNO, strConState As String
        Dim i, j As Short
        Dim dv As New DataView()
        Dim iConCheck, iBeingCount As Integer
        Try
            Call TrimGrid()

            'count = Me.C1DBG.Row
            'Me.C1DBG.Row = Me.C1DBG.Row + 1
            'While count <> Me.C1DBG.Row     '计算c1grid当前行数
            '    count = Me.C1DBG.Row
            '    Me.C1DBG.Row = Me.C1DBG.Row + 1
            'End While
            'count = Me.C1DBG.Row
            '收费对象代码
            If System.Text.ASCIIEncoding.Default.GetByteCount(txtPayerCode.Text) <= 10 Then
                If (txtPayerCode.Text <> "") Then
                    For i = 0 To dsContainer.Tables(0).DefaultView.Count - 1
                        dsContainer.Tables(0).DefaultView(i)("CODE_PAYER") = txtPayerCode.Text
                    Next
                Else
                    For i = 0 To dsContainer.Tables(0).DefaultView.Count - 1
                        dsContainer.Tables(0).DefaultView(i)("CODE_PAYER") = DBNull.Value
                    Next
                End If
            Else
                txtPayerCode.Focus()
                MessageBox.Show("收费对象码过长", "提示")
                Return
            End If

            Count = Count - delSum
            delSum = 0
            For i = 0 To Count - 1           '检验箱号、 以及箱状态
                strContainer = C1DBG.Columns("CONTAINER_NO").CellText(i)
                strSealNO = C1DBG.Columns("SEALNO").CellText(i)
                If Not IsDBNull(C1DBG.Columns("FULLOREMPTY").CellValue(i)) Then
                    If C1DBG.Columns("FULLOREMPTY").CellValue(i) = "E" Or C1DBG.Columns("FULLOREMPTY").CellValue(i) = "F" Or C1DBG.Columns("FULLOREMPTY").CellValue(i) = "L" Then
                        strConState = Me.C1DBG.Columns("FULLOREMPTY").CellValue(i)
                    Else
                        strConState = "0"
                    End If
                Else
                    strConState = "0"
                End If

                If strContainer <> "" Then
                    iConCheck = CheckConNO(strContainer)    '箱号检验
                    If iConCheck = 1 Or iConCheck = 0 Then      '箱号没有通过检验时
                        sqlBeing = "SELECT CONTAINER_NO FROM CON_CRITERION WHERE CONTAINER_NO = '" & strContainer & "' or CONTAINER_NO = '" & GetConOtherMode(strContainer) & "'"
                        iBeingCount = Filldata(sqlBeing).Count
                        If iBeingCount = 0 Then    '箱规范中不存在
                            Me.C1DBG.Row = i
                            Me.C1DBG.SelectedRows.Clear()
                            Me.C1DBG.SelectedRows.Add(i)
                            If MessageBox.Show("集装箱号 " & strContainer & " 校验不正确且在不存在于箱规范中！确定存在吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                Exit For
                            End If
                        End If
                    ElseIf iConCheck = 0 Then
                        Me.C1DBG.Row = i
                        Me.C1DBG.SelectedRows.Clear()
                        Me.C1DBG.SelectedRows.Add(i)
                        MessageBox.Show("集装箱号不规范！", "提示")
                        Exit For
                    End If

                    If strConState <> "0" Then
                        For j = 0 To i - 1
                            If IsEqualConNo(strContainer, Me.C1DBG.Columns("CONTAINER_NO").CellText(j)) Then
                                Me.C1DBG.Row = i
                                Me.C1DBG.SelectedRows.Clear()
                                Me.C1DBG.SelectedRows.Add(i)
                                Me.C1DBG.SelectedRows.Add(j)
                                MessageBox.Show("第" & j + 1 & "行和第" & i + 1 & "行 集装箱号重复！", "提示")
                                Exit Sub
                            End If
                        Next
                    Else
                        Me.C1DBG.Row = i
                        Me.C1DBG.SelectedRows.Clear()
                        Me.C1DBG.SelectedRows.Add(i)
                        MessageBox.Show("箱状态不能为空！", "提示")
                        Exit For
                    End If
                Else
                    Me.C1DBG.Row = i
                    Me.C1DBG.SelectedRows.Clear()
                    Me.C1DBG.SelectedRows.Add(i)
                    MessageBox.Show("集装箱号不能为空！", "提示")
                    Exit For
                End If
            Next

            If i >= Count Then      '检查箱号 贝位号是否与数据库中重复
                For i = 0 To Count - 1
                    'For j = 0 To max
                    '    If i = iLocal(j) Then Exit For
                    'Next
                    For j = 0 To max
                        If Trim(Me.C1DBG.Columns("CONTAINER_NO").CellText(i)) = strPinContainerNo(j) Then
                            Exit For  '如果箱号是拼箱被记录，不检验。其实如果再检查是否是原来所有的箱号，是 不检验，这样下面检验就很容易了
                        End If
                    Next
                    If j > max Then     '此箱号未被记录，要检查数据库中是否存在

                        sqlConExist = "SELECT * FROM CON_HATCH_RECORD where ship_id = '" & Ship_ID & "' and  container_no = '" & Me.C1DBG.Columns("CONTAINER_NO").CellText(i) & "' and fullorempty <> 'L' and container_no in (select con_hatch_cargo.container_no from con_hatch_cargo where  CON_HATCH_CARGO.SHIP_ID =  '" & Ship_ID & "' AND not (CON_HATCH_CARGO.BLNO = '" & Trim(FrmConHatchCargo.Bill_ID) & "'))"
                        '要判断该船次中 不属于现提单的 所有非拼箱的箱号或贝位号 是否与当前箱号贝位号重复
                        '非拼箱不可共享，要检查。拼箱可共享，不用检查
                        If Filldata(sqlConExist).Count > 0 Then
                            Me.C1DBG.Row = i
                            Me.C1DBG.SelectedRows.Clear()
                            Me.C1DBG.SelectedRows.Add(i)
                            MessageBox.Show("当前船次该集装箱号已存在，不能重复！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit For
                        Else
                            sqlConExist = "SELECT * FROM CON_HATCH_RECORD where ship_id = '" & Ship_ID & "' and  dbo.ConOtherMode(CONTAINER_NO) = '" & Me.C1DBG.Columns("CONTAINER_NO").CellText(i) & "' and fullorempty <> 'L' and dbo.ConOtherMode(CONTAINER_NO) in (select con_hatch_cargo.container_no from con_hatch_cargo where  CON_HATCH_CARGO.SHIP_ID =  '" & Ship_ID & "' AND not (CON_HATCH_CARGO.BLNO = '" & Trim(FrmConHatchCargo.Bill_ID) & "'))"
                            If Filldata(sqlConExist).Count > 0 Then
                                Me.C1DBG.Row = i
                                Me.C1DBG.SelectedRows.Clear()
                                Me.C1DBG.SelectedRows.Add(i)
                                MessageBox.Show("当前船次该集装箱号已存在，不能重复！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Exit For
                            End If
                        End If
                    End If
                Next
            End If

            If i >= Count Then      '如果检验全部成功，更新数据库表
                If MessageBox.Show("确定以上对进口舱单的修改操作吗？", "警告提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                    '记录操作日志
                    Call OperateHistory(G_DeptName, Now, G_User, "修改", "CON_HATCH_LIST", Trim(txtID.Text), "CON_HATCH_LIST_ID")
                    sqlda.Update(ds)        '更新提单信息

                    '更新关系表信息 有增加 删除 修改
                    If Trim(Me.txtBillNO.Text) <> FrmConHatchCargo.Bill_ID Then
                        'sqlEditRelation = "update CON_HATCH_CARGO set BLNO = '" & Trim(Me.txtBillNO.Text) & "' where SHIP_ID = '" & Ship_ID & "' and BLNO = '" & FrmConHatchCargo.Bill_ID & "' "
                        'ExecSql(sqlEditRelation)    '原提单唛头已修改，更新所有的关系
                        '改用触发器修改
                    End If
                    For i = 0 To Count - 1
                        For j = 0 To Amount - 1
                            If Me.C1DBG.Columns("CONTAINER_NO").CellText(i) = strFirstConNo(j) Then
                                Exit For '不做任何操作
                            Else
                                '继续检查
                            End If
                        Next
                        If j >= Amount Then     '原箱号没有，是新增的 '添加此关系
                            sqlInsertRelation = "insert into CON_HATCH_CARGO (SHIP_ID,BLNO,USER_NAME,CONTAINER_NO) values ('" & Ship_ID & "','" & Trim(txtBillNO.Text) & "','" & G_User & "','" & Me.C1DBG.Columns("CONTAINER_NO").CellText(i) & "')"
                            Call ExecSql(sqlInsertRelation)
                        End If
                    Next
                    For i = 0 To Amount - 1
                        For j = 0 To Count - 1
                            If strFirstConNo(i) = Me.C1DBG.Columns("CONTAINER_NO").CellText(j) Then
                                Exit For
                            Else
                                '继续检查
                            End If
                        Next
                        If j >= Count Then      '当前箱号没有 原箱号已被删改  '删除此关系
                            sqlDeleteRelation = "delete from CON_HATCH_CARGO where SHIP_ID = '" & Ship_ID & "' and BLNO = '" & Trim(txtBillNO.Text) & "' and CONTAINER_NO = '" & strFirstConNo(i) & "'"
                            Call ExecSql(sqlDeleteRelation)
                        End If
                    Next

                    For i = 0 To max
                        For j = 0 To Count - 1
                            If strPinContainerNo(i) = Trim(Me.C1DBG.Columns("CONTAINER_NO").CellText(j)) Then  '如果标记箱号与当前箱号同
                                Me.C1DBG.Row = j
                                Me.C1DBG.Delete()  '删除此行，不进行更新箱信息表操作，但更新关系表
                                delSum += 1
                                Exit For        '因为到此已不存在重复箱号，就不会有第二个标记箱号，可以提前退出内循环
                            End If
                        Next
                    Next
                    If t >= 0 Then  '回填共享拼箱信息，以免被删除
                        Me.C1DBG.Row = Count - delSum
                        For i = 0 To t
                            Me.C1DBG.Columns("CON_HATCH_RECORD_ID").Text = id(i)
                            Me.C1DBG.Columns("Ship_ID").Text = ship(i)
                            Me.C1DBG.Columns("CONTAINER_NO").Text = containerno(i)
                            If consize(i) <> "" Then
                                Me.C1DBG.Columns("SIZE_CON").Text = consize(i)
                            End If
                            If conType(i) <> "" Then
                                Me.C1DBG.Columns("CONTAINER_TYPE").Text = conType(i)
                            End If
                            If overheight(i) <> "" Then
                                Me.C1DBG.Columns("OVER_HEIGHT").Text = overheight(i)
                            End If
                            If fullorempty(i) <> "" Then
                                Me.C1DBG.Columns("fullorempty").Text = fullorempty(i)
                            End If
                            If sealno(i) <> "" Then
                                Me.C1DBG.Columns("sealno").Text = sealno(i)
                            End If
                            If bayno(i) <> "" Then
                                Me.C1DBG.Columns("bayno").Text = bayno(i)
                            End If
                            If sum(i) <> "" Then
                                Me.C1DBG.Columns("Amount").Text = sum(i)
                            End If
                            If weight(i) <> "" Then
                                Me.C1DBG.Columns("weight").Text = weight(i)
                            End If
                            If volume(i) <> "" Then
                                Me.C1DBG.Columns("volume").Text = volume(i)
                            End If
                            If manufactno(i) <> "" Then
                                Me.C1DBG.Columns("Code_MANUFACTURER").Text = manufactno(i)
                            End If
                            If manufact(i) <> "" Then
                                Me.C1DBG.Columns("MANUFACTURER").Text = manufact(i)
                            End If
                            If keepercode(i) <> "" Then
                                Me.C1DBG.Columns("CODE_KEEPER").Text = keepercode(i)
                            End If
                            If keeper(i) <> "" Then
                                Me.C1DBG.Columns("keeper").Text = keeper(i)
                            End If
                            If position(i) <> "" Then
                                Me.C1DBG.Columns("POSITION_CONTAINER").Text = position(i)
                            End If
                            If passmark(i) <> "" Then
                                Me.C1DBG.Columns("PASS_MARK").Text = passmark(i)
                            End If
                            If shortunload(i) <> "" Then
                                Me.C1DBG.Columns("SHORT_UNLOAD").Text = shortunload(i)
                            End If
                            If unloadmark(i) <> "" Then
                                Me.C1DBG.Columns("Unload_Mark").Text = unloadmark(i)
                            End If
                            Me.C1DBG.Columns("USER_NAME").Text = user(i)

                            Me.C1DBG.Row += 1
                        Next
                    End If

                    Me.adContainer.Update(Me.dsContainer)   '更新所有 非拼箱 和 首次拼箱 信息
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function verifySealSingle(ByVal strSeal As String) As Boolean
        Dim i As Short
        Dim c As Char
        If Len(strSeal) >= 2 Then   '只判断大写字符
            For i = Len(strSeal) To 1 Step -1
                c = Mid(strSeal, i, 1)
                If c >= "0" And c <= "9" Then

                Else
                    If c >= "A" And c <= "Z" Then
                        Exit For
                    Else
                        MessageBox.Show("存在非法字符", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                        Exit Function
                    End If
                End If
            Next

            If i >= 1 And i < Len(strSeal) Then ' 从exit for 来
                For i = i - 1 To 1 Step -1
                    c = Mid(strSeal, i, 1)
                    If (c >= "A" And c <= "Z") Or (c >= "0" And c <= "9") Then

                    Else
                        Exit For
                    End If
                Next
                If i < 1 Then
                    Return True
                    Exit Function
                Else
                    MessageBox.Show("存在非法字符", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("字符串非法", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf Len(strSeal) = 1 Then
            MessageBox.Show("字符串长度不足", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If      '为空不判断，直接返回 false
        Return False
        Exit Function
    End Function

    Private Sub FrmConHatchCargo_Add_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If Me.txtBillNO.Focused = True Then
                Me.txtGOODS_CHA.Focus()
            ElseIf Me.txtGOODS_CHA.Focused = True Then
                Me.cbLoadPort.Focus()
            ElseIf Me.cbLoadPort.Focused = True Then
                Call cbLoadPort_TextChanged(sender, e)
                If Mark1 = False Then
                    Me.cbLoadPortEng.Text = ""
                End If
                Me.cbLoadPortEng.Focus()
            ElseIf Me.cbLoadPortEng.Focused = True Then
                Me.cbUnloadPort.Focus()
            ElseIf Me.cbUnloadPort.Focused = True Then
                Call cbUnloadPort_TextChanged(sender, e)
                If Mark1 = False Then
                    Me.cbUnloadPortEng.Text = ""
                End If
                Me.cbUnloadPortEng.Focus()
            ElseIf Me.cbUnloadPortEng.Focused = True Then
                Me.txtAmount.Focus()
            ElseIf Me.txtAmount.Focused = True Then
                Me.txtGROSS_WEIGHT.Focus()
            ElseIf Me.txtGROSS_WEIGHT.Focused = True Then
                Me.txtPayerCode.Focus()
            ElseIf Me.txtPayerCode.Focused Then
                Me.C1DBG.Focus()
            End If
        End If
    End Sub

    Private Sub C1DBG_AfterColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles C1DBG.AfterColEdit
        If e.ColIndex = 17 Then
            Me.C1DBG.Columns("KEEPER").Text = Me.C1DBG.Columns("CODE_KEEPER").Text
        ElseIf e.ColIndex = 19 Then
            If IsNumeric(Me.C1DBG.Columns("ReeferTemp").Text) Then
                If Me.C1DBG.Columns("TempUnit").Text <> "C" AndAlso Me.C1DBG.Columns("TempUnit").Text <> "F" Then
                    Me.C1DBG.Columns("TempUnit").Text = "C"
                End If
            End If
        ElseIf e.ColIndex = 20 Then
            If Me.C1DBG.Columns("TempUnit").Text <> Me.C1DBG.Columns("TempUnit").Text.Trim.ToUpper Then
                Me.C1DBG.Columns("TempUnit").Text = Me.C1DBG.Columns("TempUnit").Text.Trim.ToUpper
            End If
        ElseIf e.ColIndex = 2 Then
            Dim sqlBeing As String
            sqlBeing = "SELECT * FROM CON_CRITERION WHERE CONTAINER_NO = '" & Trim(Me.C1DBG.Columns("CONTAINER_NO").Text.ToUpper) & "' or CONTAINER_NO = '" & GetConOtherMode(Me.C1DBG.Columns("CONTAINER_NO").Text) & "'"
            Dim dvBeing As New DataView
            dvBeing = Filldata(sqlBeing)
            If dvBeing.Count = 1 Then
                Me.C1DBG.Columns("SIZE_CON").Value = dvBeing.Item(0)("SIZE_CON")
                Me.C1DBG.Columns("CONTAINER_TYPE").Value = dvBeing.Item(0)("CONTAINER_TYPE")
                Me.C1DBG.Columns("CODE_KEEPER").Value = dvBeing.Item(0)("CODE_SHIP_OWNER")

                Me.C1DBG.Columns("KEEPER").Value = Me.C1DBG.Columns("CODE_KEEPER").Text
            End If
        End If
    End Sub

    Private Sub C1DBG_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1DBG.KeyDown
        If e.KeyCode = Keys.Return And (Me.C1DBG.Col = 17 OrElse Me.C1DBG.Col = 22) Then
            Me.C1DBG.Row += 1
            Me.C1DBG.Col = 2
            SendKeys.Send("{LEFT}")
        End If
    End Sub

    Private Sub cbLoadPort_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Mark1 = False
            Dim i As Integer
            For i = 0 To dvLoadPort.Count - 1
                If Not IsDBNull(dvLoadPort(i)("PORT_CHA")) Then
                    If dvLoadPort(i)("CODE_PORT") Like Me.cbLoadPort.Text.ToUpper.Trim() & "*" Or dvLoadPort(i)("PORT_CHA") Like Me.cbLoadPort.Text.ToUpper.Trim() & "*" Then
                        Me.cbLoadPort.SelectedValue = dvLoadPort(i)("CODE_PORT")
                        Mark1 = True
                        Exit For
                    End If
                Else
                    If dvLoadPort(i)("CODE_PORT") Like Me.cbLoadPort.Text.ToUpper.Trim() & "*" Then
                        Me.cbLoadPort.SelectedValue = dvLoadPort(i)("CODE_PORT")
                        Mark1 = True
                        Exit For
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbUnloadPort_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Mark1 = False
            Dim i As Integer
            For i = 0 To dvUnloadPort.Count - 1
                If Not IsDBNull(dvUnloadPort(i)("PORT_CHA")) Then
                    If dvUnloadPort(i)("CODE_PORT") Like Me.cbUnloadPort.Text.ToUpper.Trim() & "*" Or dvUnloadPort(i)("PORT_CHA") Like Me.cbUnloadPort.Text.ToUpper.Trim() & "*" Then
                        Me.cbUnloadPort.SelectedValue = dvUnloadPort(i)("CODE_PORT")
                        Mark1 = True
                        Exit For
                    End If
                Else
                    If dvUnloadPort(i)("CODE_PORT") Like Me.cbUnloadPort.Text.ToUpper.Trim() & "*" Then
                        Me.cbUnloadPort.SelectedValue = dvUnloadPort(i)("CODE_PORT")
                        Mark1 = True
                        Exit For
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DelSave()
        Dim sqlPin As String
        Dim dvPin As New DataView()
        Dim TempMark As Boolean = False

        If Me.C1DBG.Columns("CONTAINER_NO").Text.Trim <> "" Then
            sqlPin = "SELECT * FROM CON_HATCH_RECORD where ship_id = '" & Ship_ID & "' and container_no = '" & Me.C1DBG.Columns("CONTAINER_NO").Text.Trim & "' and fullorempty = 'L' and container_no in (select con_hatch_cargo.container_no from con_hatch_cargo where  CON_HATCH_CARGO.SHIP_ID =  '" & Ship_ID & "' AND not (CON_HATCH_CARGO.BLNO = '" & Trim(Me.txtBillNO.Text) & "' ))"
            '检查当前箱是否是共享的拼箱（看其它货单中有没有该箱号）。如是返回值大于0 ，要记录保存；如不是返回值为0，直接删除
            dvPin = Filldata(sqlPin)
            If dvPin.Count > 0 Then
                TempMark = True
            Else
                sqlPin = "SELECT * FROM CON_HATCH_RECORD where ship_id = '" & Ship_ID & "' and dbo.ConOtherMode(CONTAINER_NO) = '" & Me.C1DBG.Columns("CONTAINER_NO").Text.Trim & "' and fullorempty = 'L' and dbo.ConOtherMode(CONTAINER_NO) in (select con_hatch_cargo.container_no from con_hatch_cargo where  CON_HATCH_CARGO.SHIP_ID =  '" & Ship_ID & "' AND not (CON_HATCH_CARGO.BLNO = '" & Trim(Me.txtBillNO.Text) & "' ))"
                dvPin = Filldata(sqlPin)
                If dvPin.Count > 0 Then
                    TempMark = True
                End If
            End If
        End If
        If TempMark = True Then
            t += 1
            id(t) = dvPin.Item(0)("CON_HATCH_RECORD_ID")
            ship(t) = dvPin.Item(0)("SHIP_ID")
            containerno(t) = dvPin.Item(0)("CONTAINER_NO")
            If Not IsDBNull(dvPin.Item(0)("SIZE_CON")) Then
                consize(t) = dvPin.Item(0)("SIZE_CON")
            Else
                consize(t) = ""
            End If
            If Not IsDBNull(dvPin.Item(0)("CONTAINER_TYPE")) Then
                conType(t) = dvPin.Item(0)("CONTAINER_TYPE")
            Else
                conType(t) = ""
            End If
            If Not IsDBNull(dvPin.Item(0)("OVER_HEIGHT")) Then
                overheight(t) = dvPin.Item(0)("OVER_HEIGHT")
            Else
                overheight(t) = ""
            End If
            If Not IsDBNull(dvPin.Item(0)("FULLOREMPTY")) Then
                fullorempty(t) = dvPin.Item(0)("FULLOREMPTY")
            Else
                fullorempty(t) = ""
            End If
            If Not IsDBNull(dvPin.Item(0)("SEALNO")) Then
                sealno(t) = dvPin.Item(0)("SEALNO")
            Else
                sealno(t) = ""
            End If
            If Not IsDBNull(dvPin.Item(0)("BAYNO")) Then
                bayno(t) = dvPin.Item(0)("BAYNO")
            Else
                bayno(t) = ""
            End If
            If Not IsDBNull(dvPin.Item(0)("AMOUNT")) Then
                sum(t) = dvPin.Item(0)("AMOUNT")
            Else
                sum(t) = ""
            End If
            If Not IsDBNull(dvPin.Item(0)("WEIGHT")) Then
                weight(t) = dvPin.Item(0)("WEIGHT")
            Else
                weight(t) = ""
            End If
            If Not IsDBNull(dvPin.Item(0)("VOLUME")) Then
                volume(t) = dvPin.Item(0)("VOLUME")
            Else
                volume(t) = ""
            End If
            If Not IsDBNull(dvPin.Item(0)("Code_MANUFACTURER")) Then
                manufactno(t) = dvPin.Item(0)("Code_MANUFACTURER")
            Else
                manufactno(t) = ""
            End If
            If Not IsDBNull(dvPin(0)("MANUFACTURER")) Then
                manufact(t) = dvPin(0)("MANUFACTURER")
            Else
                manufact(t) = ""
            End If
            If Not IsDBNull(dvPin.Item(0)("CODE_KEEPER")) Then
                keepercode(t) = dvPin.Item(0)("CODE_KEEPER")
            Else
                keepercode(t) = ""
            End If
            If Not IsDBNull(dvPin.Item(0)("KEEPER")) Then
                keeper(t) = dvPin.Item(0)("KEEPER")
            Else
                keeper(t) = ""
            End If
            If Not IsDBNull(dvPin.Item(0)("POSITION_CONTAINER")) Then
                position(t) = dvPin.Item(0)("POSITION_CONTAINER")
            Else
                position(t) = ""
            End If
            If Not IsDBNull(dvPin.Item(0)("PASS_MARK")) Then
                passmark(t) = dvPin.Item(0)("PASS_MARK")
            Else
                passmark(t) = ""
            End If
            If Not IsDBNull(dvPin.Item(0)("SHORT_UNLOAD")) Then
                shortunload(t) = dvPin.Item(0)("SHORT_UNLOAD")
            Else
                shortunload(t) = ""
            End If
            If Not IsDBNull(dvPin(0)("Unload_Mark")) Then
                unloadmark(t) = dvPin(0)("Unload_Mark")
            Else
                unloadmark(t) = ""
            End If
            If Not IsDBNull(dvPin.Item(0)("USER_NAME")) Then
                user(t) = dvPin.Item(0)("USER_NAME")
            Else
                user(t) = ""
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If Count - delSum > 0 Then
                DelSave()
                Me.C1DBG.Delete()
                Call Me.C1DBG_AfterDelete(sender, e)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub C1DBG_BeforeDelete(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles C1DBG.BeforeDelete
        DelSave()
    End Sub

    Private Sub C1DBG_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.AfterDelete
        delSum += 1
        Me.C1DBG.Columns.Item("CONTAINER_NO").FooterText = "合计" & Count - delSum & "条"
    End Sub

    Private Sub C1DBG_AfterInsert(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.AfterInsert
        delSum -= 1
        Me.C1DBG.Columns.Item("CONTAINER_NO").FooterText = "合计" & Count - delSum & "条"
    End Sub

    Private Sub txtPayerCode_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPayerCode.Leave
        txtPayerCode.Text = txtPayerCode.Text.Trim.ToUpper
    End Sub
End Class
