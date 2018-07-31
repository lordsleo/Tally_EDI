Imports TALLY.DBControl
Public Class FrmConLoadTally_Query
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
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cbConsign As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cbState As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cbDescribe As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtDescEng As System.Windows.Forms.TextBox
    Friend WithEvents txtDescCha As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbWorkType As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dtpListDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbGoodsCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCrossPerson As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtTallyClerk As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtMark As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbConLoadType As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBillNO As System.Windows.Forms.TextBox
    Friend WithEvents txtPlace As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNO As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtShip As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConLoadTally_Query))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cbConsign = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbState = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cbDescribe = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtDescEng = New System.Windows.Forms.TextBox()
        Me.txtDescCha = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbWorkType = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dtpListDate = New System.Windows.Forms.DateTimePicker()
        Me.cbGoodsCode = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCrossPerson = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTallyClerk = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtMark = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpTimeEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpTimeBegin = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbConLoadType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBillNO = New System.Windows.Forms.TextBox()
        Me.txtPlace = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtVoyage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtShip = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(288, 394)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 400
        Me.btQuit.Text = "返回"
        '
        'C1DBG
        '
        Me.C1DBG.AllowDelete = True
        Me.C1DBG.AllowFilter = True
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1DBG.AllowSort = True
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.CollapseColor = System.Drawing.Color.Black
        Me.C1DBG.DataChanged = False
        Me.C1DBG.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBG.ExpandColor = System.Drawing.Color.Black
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.C1DBG.Location = New System.Drawing.Point(2, 202)
        Me.C1DBG.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.ShowOptionsDialog = False
        Me.C1DBG.RecordSelectorWidth = 16
        GridLines1.Color = System.Drawing.Color.DarkGray
        GridLines1.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG.RowDivider = GridLines1
        Me.C1DBG.RowHeight = 16
        Me.C1DBG.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG.ScrollTips = False
        Me.C1DBG.Size = New System.Drawing.Size(634, 186)
        Me.C1DBG.TabIndex = 399
        Me.C1DBG.PropBag = CType(resources.GetObject("C1DBG.PropBag"), String)
        '
        'cbConsign
        '
        Me.cbConsign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConsign.Location = New System.Drawing.Point(502, 134)
        Me.cbConsign.MaxDropDownItems = 20
        Me.cbConsign.Name = "cbConsign"
        Me.cbConsign.Size = New System.Drawing.Size(130, 20)
        Me.cbConsign.TabIndex = 438
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(428, 136)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 18)
        Me.Label22.TabIndex = 439
        Me.Label22.Text = "委托单位"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbState
        '
        Me.cbState.Items.AddRange(New Object() {"", "全已装箱", "尚未装箱"})
        Me.cbState.Location = New System.Drawing.Point(502, 32)
        Me.cbState.MaxDropDownItems = 20
        Me.cbState.Name = "cbState"
        Me.cbState.Size = New System.Drawing.Size(130, 20)
        Me.cbState.TabIndex = 436
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(428, 34)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 18)
        Me.Label21.TabIndex = 437
        Me.Label21.Text = "货物处于"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbDescribe
        '
        Me.cbDescribe.Items.AddRange(New Object() {"", "全部抵运", "尚未抵运"})
        Me.cbDescribe.Location = New System.Drawing.Point(502, 8)
        Me.cbDescribe.MaxDropDownItems = 20
        Me.cbDescribe.Name = "cbDescribe"
        Me.cbDescribe.Size = New System.Drawing.Size(130, 20)
        Me.cbDescribe.TabIndex = 434
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(428, 10)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 18)
        Me.Label20.TabIndex = 435
        Me.Label20.Text = "货箱抵运"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDescEng
        '
        Me.txtDescEng.Location = New System.Drawing.Point(220, 156)
        Me.txtDescEng.MaxLength = 50
        Me.txtDescEng.Multiline = True
        Me.txtDescEng.Name = "txtDescEng"
        Me.txtDescEng.Size = New System.Drawing.Size(202, 38)
        Me.txtDescEng.TabIndex = 431
        Me.txtDescEng.Text = ""
        '
        'txtDescCha
        '
        Me.txtDescCha.Location = New System.Drawing.Point(220, 98)
        Me.txtDescCha.MaxLength = 50
        Me.txtDescCha.Multiline = True
        Me.txtDescCha.Name = "txtDescCha"
        Me.txtDescCha.Size = New System.Drawing.Size(202, 38)
        Me.txtDescCha.TabIndex = 430
        Me.txtDescCha.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(212, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 18)
        Me.Label12.TabIndex = 432
        Me.Label12.Text = "货物中文描述"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(210, 138)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 18)
        Me.Label13.TabIndex = 433
        Me.Label13.Text = "货物英文描述"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbWorkType
        '
        Me.cbWorkType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWorkType.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbWorkType.Location = New System.Drawing.Point(82, 152)
        Me.cbWorkType.Name = "cbWorkType"
        Me.cbWorkType.Size = New System.Drawing.Size(130, 20)
        Me.cbWorkType.TabIndex = 428
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(8, 154)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 18)
        Me.Label18.TabIndex = 429
        Me.Label18.Text = "工作类别"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpListDate
        '
        Me.dtpListDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpListDate.Location = New System.Drawing.Point(502, 56)
        Me.dtpListDate.Name = "dtpListDate"
        Me.dtpListDate.Size = New System.Drawing.Size(130, 21)
        Me.dtpListDate.TabIndex = 411
        '
        'cbGoodsCode
        '
        Me.cbGoodsCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGoodsCode.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbGoodsCode.Location = New System.Drawing.Point(292, 56)
        Me.cbGoodsCode.MaxDropDownItems = 20
        Me.cbGoodsCode.Name = "cbGoodsCode"
        Me.cbGoodsCode.Size = New System.Drawing.Size(130, 20)
        Me.cbGoodsCode.TabIndex = 409
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(218, 58)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 18)
        Me.Label17.TabIndex = 427
        Me.Label17.Text = "货名代码"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCrossPerson
        '
        Me.txtCrossPerson.Location = New System.Drawing.Point(502, 108)
        Me.txtCrossPerson.MaxLength = 10
        Me.txtCrossPerson.Name = "txtCrossPerson"
        Me.txtCrossPerson.Size = New System.Drawing.Size(130, 21)
        Me.txtCrossPerson.TabIndex = 413
        Me.txtCrossPerson.Text = ""
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(428, 110)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 18)
        Me.Label16.TabIndex = 426
        Me.Label16.Text = "交接人员"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTallyClerk
        '
        Me.txtTallyClerk.Location = New System.Drawing.Point(502, 82)
        Me.txtTallyClerk.MaxLength = 10
        Me.txtTallyClerk.Name = "txtTallyClerk"
        Me.txtTallyClerk.Size = New System.Drawing.Size(130, 21)
        Me.txtTallyClerk.TabIndex = 412
        Me.txtTallyClerk.Text = ""
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(428, 84)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 18)
        Me.Label15.TabIndex = 425
        Me.Label15.Text = "理货员"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(428, 58)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 18)
        Me.Label14.TabIndex = 424
        Me.Label14.Text = "制单日期"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(82, 104)
        Me.txtMark.MaxLength = 20
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(130, 21)
        Me.txtMark.TabIndex = 408
        Me.txtMark.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 423
        Me.Label9.Text = "标志"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeEnd
        '
        Me.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeEnd.Location = New System.Drawing.Point(292, 32)
        Me.dtpTimeEnd.Name = "dtpTimeEnd"
        Me.dtpTimeEnd.Size = New System.Drawing.Size(130, 21)
        Me.dtpTimeEnd.TabIndex = 406
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(218, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 18)
        Me.Label8.TabIndex = 422
        Me.Label8.Text = "结束时间"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeBegin
        '
        Me.dtpTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeBegin.Location = New System.Drawing.Point(292, 8)
        Me.dtpTimeBegin.Name = "dtpTimeBegin"
        Me.dtpTimeBegin.Size = New System.Drawing.Size(130, 21)
        Me.dtpTimeBegin.TabIndex = 405
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(218, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 421
        Me.Label7.Text = "开始时间"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbConLoadType
        '
        Me.cbConLoadType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConLoadType.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbConLoadType.Location = New System.Drawing.Point(82, 174)
        Me.cbConLoadType.Name = "cbConLoadType"
        Me.cbConLoadType.Size = New System.Drawing.Size(130, 20)
        Me.cbConLoadType.TabIndex = 404
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 420
        Me.Label6.Text = "折装箱类别"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBillNO
        '
        Me.txtBillNO.Location = New System.Drawing.Point(82, 80)
        Me.txtBillNO.MaxLength = 20
        Me.txtBillNO.Name = "txtBillNO"
        Me.txtBillNO.Size = New System.Drawing.Size(130, 21)
        Me.txtBillNO.TabIndex = 407
        Me.txtBillNO.Text = ""
        '
        'txtPlace
        '
        Me.txtPlace.Location = New System.Drawing.Point(82, 128)
        Me.txtPlace.MaxLength = 50
        Me.txtPlace.Name = "txtPlace"
        Me.txtPlace.Size = New System.Drawing.Size(130, 21)
        Me.txtPlace.TabIndex = 403
        Me.txtPlace.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 419
        Me.Label4.Text = "提单号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 418
        Me.Label5.Text = "工作地点"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNO
        '
        Me.txtNO.Location = New System.Drawing.Point(82, 56)
        Me.txtNO.MaxLength = 20
        Me.txtNO.Name = "txtNO"
        Me.txtNO.Size = New System.Drawing.Size(130, 21)
        Me.txtNO.TabIndex = 410
        Me.txtNO.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 417
        Me.Label3.Text = "理货单编号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(82, 32)
        Me.txtVoyage.MaxLength = 6
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(130, 21)
        Me.txtVoyage.TabIndex = 402
        Me.txtVoyage.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 416
        Me.Label1.Text = "航次"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShip
        '
        Me.txtShip.Location = New System.Drawing.Point(82, 8)
        Me.txtShip.MaxLength = 40
        Me.txtShip.Name = "txtShip"
        Me.txtShip.Size = New System.Drawing.Size(130, 21)
        Me.txtShip.TabIndex = 401
        Me.txtShip.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 415
        Me.Label2.Text = "中文船名"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 414
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'FrmConLoadTally_Query
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(638, 423)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbConsign, Me.Label22, Me.cbState, Me.Label21, Me.cbDescribe, Me.Label20, Me.txtDescEng, Me.txtDescCha, Me.Label12, Me.Label13, Me.cbWorkType, Me.Label18, Me.dtpListDate, Me.cbGoodsCode, Me.Label17, Me.txtCrossPerson, Me.Label16, Me.txtTallyClerk, Me.Label15, Me.Label14, Me.txtMark, Me.Label9, Me.dtpTimeEnd, Me.Label8, Me.dtpTimeBegin, Me.Label7, Me.cbConLoadType, Me.Label6, Me.txtBillNO, Me.txtPlace, Me.Label4, Me.Label5, Me.txtNO, Me.Label3, Me.txtVoyage, Me.Label1, Me.txtShip, Me.Label2, Me.txtID, Me.btQuit, Me.C1DBG})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConLoadTally_Query"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "集装箱货物理货单 查看"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As New DataSet()
    'Dim sqlda As New SqlClient.SqlDataAdapter()
    'Dim dsSubTable As New DataSet()
    'Dim sqlSubTableda As New SqlClient.SqlDataAdapter()

    Private Sub FrmConLoadTally_Query_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim dvCodeGoods As New DataView()
        Dim sqlstr, sqlCodeGoods As String
        Me.StartPosition = FormStartPosition.CenterScreen

        Dim dvWorkType As New DataView()
        Dim sqlWorkType As String
        sqlWorkType = "SELECT WorkType_ID, WorkType_Name FROM Code_ConLoadContainer_Type"
        dvWorkType = Filldata(sqlWorkType)
        cbWorkType.DataSource = dvWorkType
        cbWorkType.DisplayMember = "WorkType_Name"
        cbWorkType.ValueMember = "WorkType_ID"

        Dim sqlConLoadType As String
        sqlConLoadType = "select Code_Tally_Type,Name_Tally_Type from Code_Tally_Type "
        cbConLoadType.DataSource = Filldata(sqlConLoadType)
        cbConLoadType.DisplayMember = "Name_Tally_Type"
        cbConLoadType.ValueMember = "Code_Tally_Type"

        Dim sqlConsign As String '= "SELECT CODE_CONSIGN_CON, CONSIGN_CON FROM CODE_CONSIGN_CON ORDER BY CONSIGN_CON"
        sqlConsign = "SELECT CODE_SHIP_AGENT, SHIPAGENT_CHA, SHIPAGENT_ENG FROM CODE_SHIP_AGENT ORDER BY CODE_SHIP_AGENT"
        cbConsign.DataSource = Filldata(sqlConsign)
        'cbConsign.DisplayMember = "CONSIGN_CON"
        'cbConsign.ValueMember = "CODE_CONSIGN_CON"
        cbConsign.DisplayMember = "SHIPAGENT_CHA"
        cbConsign.ValueMember = "CODE_SHIP_AGENT"

        sqlCodeGoods = "select Code,Goods from CodeGoods "
        dvCodeGoods = Filldata(sqlCodeGoods)
        cbGoodsCode.DataSource = dvCodeGoods
        cbGoodsCode.DisplayMember = "Goods"
        cbGoodsCode.ValueMember = "Code"

        sqlstr = "select * from Con_Load_Tally where Con_Load_Tally_ID =" & ID & ""
        dw = Getdata(sqlstr, ds)

        dtpListDate.CustomFormat = "yyyy'-'MM'-'dd"
        dtpTimeBegin.CustomFormat = "yyyy'-'MM'-'dd' 'hh':'mm"
        dtpTimeEnd.CustomFormat = "yyyy'-'MM'-'dd' 'hh':'mm"
        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("Con_Load_Tally_ID")
            txtShip.Text = ds.Tables(0).Rows(0).Item("CHI_VESSEL")
            txtVoyage.Text = ds.Tables(0).Rows(0).Item("VOYAGE")
            txtPlace.Text = ds.Tables(0).Rows(0).Item("WORK_PLACE")
            txtBillNO.Text = ds.Tables(0).Rows(0).Item("BLNO")
            txtMark.Text = ds.Tables(0).Rows(0).Item("MARK")
            txtNO.Text = ds.Tables(0).Rows(0).Item("NO")
            txtTallyClerk.Text = ds.Tables(0).Rows(0).Item("TALLY_CLERK")
            txtCrossPerson.Text = ds.Tables(0).Rows(0).Item("CROSS_PERSON")
            cbDescribe.Text = ds.Tables(0).Rows(0).Item("DESCR")
            cbState.Text = ds.Tables(0).Rows(0).Item("STATE")
            txtDescCha.Text = ds.Tables(0).Rows(0).Item("GoodsCha")
            txtDescEng.Text = ds.Tables(0).Rows(0).Item("GoodsEng")

            cbWorkType.SelectedValue = ds.Tables(0).Rows(0).Item("WORKTYPE")
            cbConLoadType.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_TALLY_TYPE")
            cbGoodsCode.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_GOODS")
            cbConsign.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_CON_CONSIGN")

            dtpTimeBegin.Value = ds.Tables(0).Rows(0).Item("TIME_FROM")
            dtpTimeEnd.Value = ds.Tables(0).Rows(0).Item("TIME_TO")
            dtpListDate.Value = ds.Tables(0).Rows(0).Item("LISTDATE")
        End If
        btQuit.Focus()
        InitSubTable(ID)     '初始化子表c1grid
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub InitSubTable(ByVal sqlID As String)
        Try
            Dim sqlSubTable As String
            sqlSubTable = "select * from Con_Load_Tally_List where CON_LOAD_TALLY_ID =" & sqlID & ""
            Me.C1DBG.DataSource = Filldata(sqlSubTable)

            Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue

            Me.C1DBG.Splits(0).DisplayColumns.Item(0).Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item(1).Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("USER_NAME").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("PACK_ENG").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("WEIGHT").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("VOLUME").Visible = False

            Me.C1DBG.Columns.Item("CONTAINER_NO").Caption = "集装箱号"
            Me.C1DBG.Columns.Item("NEWSEALNO").Caption = "铅封号"
            Me.C1DBG.Columns.Item("SIZE_CON").Caption = "箱尺寸"
            Me.C1DBG.Columns.Item("CONTAINER_TYPE").Caption = "箱型"
            Me.C1DBG.Columns.Item("AMOUNT").Caption = "件数"
            Me.C1DBG.Columns.Item("PACK_CHA").Caption = "包装"
            Me.C1DBG.Columns.Item("PACK_ENG").Caption = "包装英文"
            Me.C1DBG.Columns.Item("WEIGHT").Caption = "货重(kg)"
            Me.C1DBG.Columns.Item("VOLUME").Caption = "货物体积(M3)"
            Me.C1DBG.Columns.Item("DAMAGED_AMOUNT").Caption = "残损件数"
            Me.C1DBG.Columns.Item("DAMAGED_PACK").Caption = "残损情况"
            Call FieldFill()
            SetColumnWidth()
        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FieldFill()
        Dim i As Integer
        Try
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

            Dim sqlPack As String = "SELECT CODE_PACK, PACK_CHA, PACK_ENG FROM CODE_PACK ORDER BY CODE_PACK"
            Dim dvPack As New DataView()
            dvPack = Filldata(sqlPack)
            Me.C1DBG.Columns("PACK_CHA").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("PACK_CHA").ValueItems.Translate = True
            For i = 0 To dvPack.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
                vi.DisplayValue = dvPack(i)("PACK_CHA")
                vi.Value = dvPack(i)("CODE_PACK")
                Me.C1DBG.Columns.Item("PACK_CHA").ValueItems.Values.Add(vi)
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnWidth()
        Dim i As Integer
        Try
            i = 2
            Do While i < Me.C1DBG.Columns.Count
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Width = ((Me.C1DBG.Width - 25) / (Me.C1DBG.Columns.Count - 4))
                i = i + 1
            Loop
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Width = 80
            Me.C1DBG.Splits(0).DisplayColumns("NEWSEALNO").Width = 80
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class
