Imports TALLY.DBControl
Public Class FrmConHatchCargo_Delete
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim adContainer As New SqlClient.SqlDataAdapter()
    Dim dsContainer As New DataSet()

    Dim strDelContainerNo(500) As String
    Dim max As Short = -1
    Dim sqlCondition As String

    Dim id(500), ship(500), consize(500), sum(500) As String
    Dim weight(500), volume(500) As String
    Dim containerno(500), conType(500), overheight(500), fullorempty(500), sealno(500), bayno(500), manufactno(500), manufact(500), keepercode(500), keeper(500), position(500), passmark(500), shortunload(500), unloadmark(500), user(500) As String
    Dim t As Short = -1

    Dim dvLoadPort As New DataView()
    Dim dvUnloadPort As New DataView()
    Dim dvReceivePlace As New DataView()
    Dim Mark1 As Boolean
    Dim Count, DelSum As Integer

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
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCONTAINER As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGROSS_WEIGHT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents txtBillNO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtGOODS_CHA As System.Windows.Forms.TextBox
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents cbUnloadPort As System.Windows.Forms.ComboBox
    Friend WithEvents cbLoadPort As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents cbUnloadPortEng As System.Windows.Forms.ComboBox
    Friend WithEvents cbLoadPortEng As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConHatchCargo_Delete))
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtCONTAINER = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtGROSS_WEIGHT = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCommit = New System.Windows.Forms.Button
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.txtBillNO = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtGOODS_CHA = New System.Windows.Forms.TextBox
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btnDelete = New System.Windows.Forms.Button
        Me.cbUnloadPort = New System.Windows.Forms.ComboBox
        Me.cbLoadPort = New System.Windows.Forms.ComboBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.cbUnloadPortEng = New System.Windows.Forms.ComboBox
        Me.cbLoadPortEng = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
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
        Me.txtAmount.Text = ""
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
        Me.txtCONTAINER.Text = ""
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
        Me.txtGROSS_WEIGHT.TabIndex = 358
        Me.txtGROSS_WEIGHT.Text = ""
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
        Me.btnCommit.Location = New System.Drawing.Point(286, 346)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(65, 24)
        Me.btnCommit.TabIndex = 370
        Me.btnCommit.Text = "确认"
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(354, 346)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 368
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(122, 346)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 367
        Me.btSave.Text = "全部删除"
        '
        'txtBillNO
        '
        Me.txtBillNO.Location = New System.Drawing.Point(78, 6)
        Me.txtBillNO.MaxLength = 20
        Me.txtBillNO.Name = "txtBillNO"
        Me.txtBillNO.Size = New System.Drawing.Size(130, 21)
        Me.txtBillNO.TabIndex = 333
        Me.txtBillNO.Text = ""
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
        Me.txtID.Location = New System.Drawing.Point(0, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 371
        Me.txtID.Text = ""
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
        Me.txtGOODS_CHA.MaxLength = 20
        Me.txtGOODS_CHA.Multiline = True
        Me.txtGOODS_CHA.Name = "txtGOODS_CHA"
        Me.txtGOODS_CHA.Size = New System.Drawing.Size(200, 48)
        Me.txtGOODS_CHA.TabIndex = 351
        Me.txtGOODS_CHA.Text = ""
        '
        'C1DBG
        '
        Me.C1DBG.AllowAddNew = True
        Me.C1DBG.AllowDelete = True
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 104)
        Me.C1DBG.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.RecordSelectorWidth = 16
        Me.C1DBG.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1DBG.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG.RowHeight = 16
        Me.C1DBG.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG.Size = New System.Drawing.Size(634, 236)
        Me.C1DBG.TabIndex = 369
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style14{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" & _
        "tyle1{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Back" & _
        "Color:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSele" & _
        "ctorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><ClientRect>0, 0, 630, 232</ClientRect><BorderSide>0</BorderSide><CaptionSt" & _
        "yle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><E" & _
        "venRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me" & _
        "=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Grou" & _
        "p"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyl" & _
        "e parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style" & _
        "4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""Rec" & _
        "ordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Styl" & _
        "e parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedS" & _
        "tyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Styl" & _
        "e parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style p" & _
        "arent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style pa" & _
        "rent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style pa" & _
        "rent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=" & _
        """Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style p" & _
        "arent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits" & _
        ">1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><" & _
        "ClientArea>0, 0, 630, 232</ClientArea><PrintPageHeaderStyle parent="""" me=""Style1" & _
        "4"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(218, 346)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(65, 24)
        Me.btnDelete.TabIndex = 405
        Me.btnDelete.Text = "箱删除"
        '
        'cbUnloadPort
        '
        Me.cbUnloadPort.Location = New System.Drawing.Point(286, 54)
        Me.cbUnloadPort.MaxDropDownItems = 20
        Me.cbUnloadPort.Name = "cbUnloadPort"
        Me.cbUnloadPort.Size = New System.Drawing.Size(130, 20)
        Me.cbUnloadPort.TabIndex = 419
        '
        'cbLoadPort
        '
        Me.cbLoadPort.Location = New System.Drawing.Point(286, 6)
        Me.cbLoadPort.MaxDropDownItems = 20
        Me.cbLoadPort.Name = "cbLoadPort"
        Me.cbLoadPort.Size = New System.Drawing.Size(130, 20)
        Me.cbLoadPort.TabIndex = 418
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(212, 8)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 18)
        Me.Label24.TabIndex = 415
        Me.Label24.Text = "装货港"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(212, 56)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(72, 18)
        Me.Label32.TabIndex = 412
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
        Me.cbUnloadPortEng.Location = New System.Drawing.Point(286, 78)
        Me.cbUnloadPortEng.MaxDropDownItems = 20
        Me.cbUnloadPortEng.Name = "cbUnloadPortEng"
        Me.cbUnloadPortEng.Size = New System.Drawing.Size(130, 20)
        Me.cbUnloadPortEng.TabIndex = 429
        '
        'cbLoadPortEng
        '
        Me.cbLoadPortEng.Location = New System.Drawing.Point(286, 30)
        Me.cbLoadPortEng.MaxDropDownItems = 20
        Me.cbLoadPortEng.Name = "cbLoadPortEng"
        Me.cbLoadPortEng.Size = New System.Drawing.Size(130, 20)
        Me.cbLoadPortEng.TabIndex = 428
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(212, 80)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 18)
        Me.Label22.TabIndex = 426
        Me.Label22.Text = "卸货港英文"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(212, 32)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 18)
        Me.Label23.TabIndex = 424
        Me.Label23.Text = "装货港英文"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmConHatchCargo_Delete
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(634, 375)
        Me.Controls.Add(Me.cbUnloadPortEng)
        Me.Controls.Add(Me.cbLoadPortEng)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.cbUnloadPort)
        Me.Controls.Add(Me.cbLoadPort)
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
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.txtBillNO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtGOODS_CHA)
        Me.Controls.Add(Me.C1DBG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConHatchCargo_Delete"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "集装箱舱单信息 删除"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmConHatchCargo_Delete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Dim dwCodeGoods As New DataView()
        Dim sqlCodeGoods, sqlEmptyMark, sqlContainerMark As String
        Dim dwEmptyMark As New DataView()
        Dim dwContainerMark As New DataView()

        Me.txtBillNO.Enabled = False

        Dim strPort As String
        strPort = "SELECT CODE_PORT, PORT_CHA, PORT_ENG FROM CODE_PORT ORDER BY PORT_ENG"
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

        'sqlstr = "SELECT * FROM CON_HATCH_LIST WHERE SHIP_ID = '" & Ship_ID & "' AND BLNO = '" & FrmConHatchCargo.Bill_ID & "' AND MARK = '" & FrmConHatchCargo.Mark_ID & "'"
        sqlstr = "SELECT * FROM CON_HATCH_LIST WHERE SHIP_ID = '" & Ship_ID & "' AND BLNO = '" & FrmConHatchCargo.Bill_ID & "'"
        dw = Updatedata(sqlda, sqlstr, ds)

        If dw.Count >= 1 Then
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
        sqlCondition = " CON_HATCH_CARGO.SHIP_ID =  '" & Ship_ID & "' AND CON_HATCH_CARGO.BLNO = '" & FrmConHatchCargo.Bill_ID & "'"
        'Dim sqlCondition As String = " SHIP_ID =  '" & Ship_ID & "' AND Expr1 = '" & FrmConHatchCargo.Bill_ID & "' AND Expr2 = '" & FrmConHatchCargo.Mark_ID & "'"
        InitSubTable(sqlCondition)     '初始化子表c1grid
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim sqlDelCont As String
        Try
            If MessageBox.Show("此操作将同时删除与当前记录关联的箱信息表数据，确定要删除吗？", "警告提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                '记录操作日志
                Call OperateHistory(G_DeptName, Now, G_User, "删除", "CON_HATCH_LIST", Trim(txtID.Text), "CON_HATCH_LIST_ID")
                '要改不属于的
                sqlDelCont = "delete from CON_HATCH_RECORD where  ship_id = '" & Ship_ID & "' and " & _
                                   " container_no in (select container_no from con_hatch_cargo where  SHIP_ID =  '" & Ship_ID & "' AND BLNO = '" & Trim(Me.txtBillNO.Text) & "')" & _
                                   " and container_no not in (select container_no from con_hatch_cargo where  SHIP_ID =  '" & Ship_ID & "' AND not (BLNO = '" & Trim(Me.txtBillNO.Text) & "'))"
                '找出所有该船次提单唛头下的箱号（不包括与其它提单唛头共享的拼箱号）删除
                ExecSql(sqlDelCont)
                ds.Tables(0).Rows(0).Delete()
                sqlda.Update(ds)

                '关系信息用触发器删除
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        Dim sqlDeleteRelation As String
        Dim i As Short
        Try
            If MessageBox.Show("确定以上对箱信息的删除操作吗？", "警告提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.OK Then

                For i = 0 To max    '删除相应的关系
                    sqlDeleteRelation = "delete from CON_HATCH_CARGO where SHIP_ID = '" & Ship_ID & "' and BLNO = '" & Trim(txtBillNO.Text) & "' and CONTAINER_NO = '" & strDelContainerNo(i) & "'"
                    ExecSql(sqlDeleteRelation)
                Next
                If t >= 0 Then  '回填共享拼箱信息，以免箱记录被删除
                    Me.C1DBG.Row = Count - DelSum
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

                adContainer.Update(dsContainer)    '更新子表
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub InitSubTable(ByVal sqlCondition As String)
        Try
            Dim sqlContainer As String
            'sqlContainer = "SELECT CON_HATCH_RECORD.* FROM CON_HATCH_RECORD INNER JOIN CON_HATCH_CARGO ON CON_HATCH_RECORD.SHIP_ID = CON_HATCH_CARGO.SHIP_ID AND CON_HATCH_RECORD.CONTAINER_NO = CON_HATCH_CARGO.CONTAINER_NO WHERE " & sqlCondition
            'sqlContainer = "SELECT * FROM CON_HATCH_RECORD where 1=0 "
            sqlContainer = "SELECT CON_HATCH_RECORD_ID,SHIP_ID,CONTAINER_NO,SEALNO,SealCheck,SIZE_CON,CONTAINER_TYPE,OVER_HEIGHT,FULLOREMPTY,BAYNO,BLNO,CODE_GOODS,AMOUNT,WEIGHT,VOLUME,Code_MANUFACTURER,MANUFACTURER,CODE_KEEPER,KEEPER,ReeferTemp,TempUnit,DangerGrade,DangerMark,POSITION_CONTAINER,PASS_MARK,SHORT_UNLOAD,Unload_Mark,USER_NAME,USER_CODE " & _
                " FROM CON_HATCH_RECORD where ship_id = '" & Ship_ID & "' and container_no in (select con_hatch_cargo.container_no from con_hatch_cargo where " & sqlCondition & " )"
            'con_hatch_cargo.blno=4 and con_hatch_cargo.ship_id=0 and con_hatch_cargo.mark=24)"
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
            'dsContainer.Tables(0).Columns("USER_NAME").DefaultValue = G_User
            'dsContainer.Tables(0).Columns("SHIP_ID").DefaultValue = Ship_ID
            Me.C1DBG.ColumnFooters = True
            Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
            Me.C1DBG.Columns.Item("CONTAINER_NO").FooterText = "合计" & dsContainer.Tables(0).Rows.Count & "条"
            Count = dsContainer.Tables(0).Rows.Count
            DelSum = 0
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

        max += 1
        strDelContainerNo(max) = Me.C1DBG.Columns("CONTAINER_NO").Text.Trim

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
            If Count - DelSum > 0 Then
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

End Class
