Imports TALLY.DBControl
Imports System.Web.Mail
Imports System.IO
Imports Microsoft.VisualBasic
Public Class FrmContainerOutPort_Query
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dsSubTable As New DataSet()
    Dim sqlSubTableda As New SqlClient.SqlDataAdapter()
    Dim strShip, strVoyage, strBillNo, strYCode As String
    Dim strNewBillNo, strNewShip, strNewVoyage, strNewYard As String
    Dim strOldShipName, strOldVoyage, strOldAccountNo As String
    Dim iAccountID As Integer = -1   '账单ID
    Dim iAccountType As Integer = -1 '账单收费方式：转账/现金
    Dim dvSubTable As DataView
    'Dim sqlYardInfo As String
    'Dim dvYardInfo As New DataView()
    'Dim strPackCode As String
    'Dim dvCodeYard As New DataView()
    Dim Count, delSum As Integer
    Dim strConsign As String
    Dim sqlShipCode As String
    Dim dvShipCode As New DataView()
    Dim sqlConsign As String
    Dim dvConsign As New DataView()
    Dim shipmark As Boolean
    Public Shared EditMark As Boolean
    Dim CreateAccountMark, PrintMark As Boolean
    Dim ClosingMark As Boolean

    Const conPage As Integer = 20   '每页打印箱数

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
    Friend WithEvents cbPlace As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSize As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cbConsign As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cbState As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cbDescribe As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtMark As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbConLoadType As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBillNO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNO As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtShip As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents txtTotalNetWeight As System.Windows.Forms.TextBox
    Friend WithEvents btnCallBill As System.Windows.Forms.Button
    Friend WithEvents btnSelectPrint As System.Windows.Forms.Button
    Friend WithEvents btEdit As System.Windows.Forms.Button
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnEditEnable As System.Windows.Forms.Button
    Friend WithEvents btnAddShipCode As System.Windows.Forms.Button
    Friend WithEvents btnAddConsign As System.Windows.Forms.Button
    Friend WithEvents cktransfer As System.Windows.Forms.CheckBox
    Friend WithEvents btnGetOg As System.Windows.Forms.Button
    Friend WithEvents ckbEditBill As System.Windows.Forms.CheckBox
    Friend WithEvents txtGoodsSpec As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents ccbGoods As C1.Win.C1List.C1Combo
    Friend WithEvents btnPrintBill As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmContainerOutPort_Query))
        Me.cbPlace = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtSize = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtTotalNetWeight = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.cbConsign = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.cbState = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.cbDescribe = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.btQuit = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtMark = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtpTimeBegin = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbConLoadType = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtBillNO = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNO = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtShip = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnCallBill = New System.Windows.Forms.Button
        Me.btnSelectPrint = New System.Windows.Forms.Button
        Me.btEdit = New System.Windows.Forms.Button
        Me.Label35 = New System.Windows.Forms.Label
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.btnExport = New System.Windows.Forms.Button
        Me.btnEditEnable = New System.Windows.Forms.Button
        Me.btnAddShipCode = New System.Windows.Forms.Button
        Me.btnAddConsign = New System.Windows.Forms.Button
        Me.cktransfer = New System.Windows.Forms.CheckBox
        Me.btnGetOg = New System.Windows.Forms.Button
        Me.ckbEditBill = New System.Windows.Forms.CheckBox
        Me.txtGoodsSpec = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.ccbGoods = New C1.Win.C1List.C1Combo
        Me.btnPrintBill = New System.Windows.Forms.Button
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccbGoods, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbPlace
        '
        Me.cbPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlace.Enabled = False
        Me.cbPlace.Location = New System.Drawing.Point(82, 32)
        Me.cbPlace.Name = "cbPlace"
        Me.cbPlace.Size = New System.Drawing.Size(130, 20)
        Me.cbPlace.TabIndex = 443
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(614, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 20)
        Me.Label13.TabIndex = 438
        Me.Label13.Text = "立方"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSize
        '
        Me.txtSize.Enabled = False
        Me.txtSize.Location = New System.Drawing.Point(514, 10)
        Me.txtSize.MaxLength = 10
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(100, 21)
        Me.txtSize.TabIndex = 436
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(440, 12)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 18)
        Me.Label19.TabIndex = 437
        Me.Label19.Text = "总尺码"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(398, 130)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(30, 20)
        Me.Label23.TabIndex = 435
        Me.Label23.Text = "公斤"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalNetWeight
        '
        Me.txtTotalNetWeight.Enabled = False
        Me.txtTotalNetWeight.Location = New System.Drawing.Point(298, 128)
        Me.txtTotalNetWeight.MaxLength = 10
        Me.txtTotalNetWeight.Name = "txtTotalNetWeight"
        Me.txtTotalNetWeight.Size = New System.Drawing.Size(100, 21)
        Me.txtTotalNetWeight.TabIndex = 432
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(224, 130)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 18)
        Me.Label24.TabIndex = 434
        Me.Label24.Text = "总货重"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmount
        '
        Me.txtAmount.Enabled = False
        Me.txtAmount.Location = New System.Drawing.Point(298, 104)
        Me.txtAmount.MaxLength = 10
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(130, 21)
        Me.txtAmount.TabIndex = 431
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(224, 106)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 18)
        Me.Label25.TabIndex = 433
        Me.Label25.Text = "总件数"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbConsign
        '
        Me.cbConsign.Enabled = False
        Me.cbConsign.Location = New System.Drawing.Point(514, 108)
        Me.cbConsign.MaxDropDownItems = 20
        Me.cbConsign.Name = "cbConsign"
        Me.cbConsign.Size = New System.Drawing.Size(130, 20)
        Me.cbConsign.TabIndex = 429
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(440, 110)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 18)
        Me.Label22.TabIndex = 430
        Me.Label22.Text = "委托单位"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbState
        '
        Me.cbState.Enabled = False
        Me.cbState.Items.AddRange(New Object() {"", "全已装箱", "部分装箱", "拆箱"})
        Me.cbState.Location = New System.Drawing.Point(514, 84)
        Me.cbState.MaxDropDownItems = 20
        Me.cbState.Name = "cbState"
        Me.cbState.Size = New System.Drawing.Size(130, 20)
        Me.cbState.TabIndex = 427
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(440, 86)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 18)
        Me.Label21.TabIndex = 428
        Me.Label21.Text = "货物处于"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbDescribe
        '
        Me.cbDescribe.Enabled = False
        Me.cbDescribe.Items.AddRange(New Object() {"", "全部抵运", "部分抵运"})
        Me.cbDescribe.Location = New System.Drawing.Point(514, 60)
        Me.cbDescribe.MaxDropDownItems = 20
        Me.cbDescribe.Name = "cbDescribe"
        Me.cbDescribe.Size = New System.Drawing.Size(130, 20)
        Me.cbDescribe.TabIndex = 425
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(440, 62)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 18)
        Me.Label20.TabIndex = 426
        Me.Label20.Text = "货箱抵运"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(332, 534)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 422
        Me.btQuit.Text = "退出"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(224, 58)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 18)
        Me.Label17.TabIndex = 420
        Me.Label17.Text = "货名"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMark
        '
        Me.txtMark.Enabled = False
        Me.txtMark.Location = New System.Drawing.Point(298, 32)
        Me.txtMark.MaxLength = 20
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(130, 21)
        Me.txtMark.TabIndex = 401
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(224, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 416
        Me.Label9.Text = "标志"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeBegin
        '
        Me.dtpTimeBegin.Enabled = False
        Me.dtpTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeBegin.Location = New System.Drawing.Point(514, 34)
        Me.dtpTimeBegin.Name = "dtpTimeBegin"
        Me.dtpTimeBegin.Size = New System.Drawing.Size(130, 21)
        Me.dtpTimeBegin.TabIndex = 398
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(440, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 414
        Me.Label7.Text = "装箱时间"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbConLoadType
        '
        Me.cbConLoadType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConLoadType.Enabled = False
        Me.cbConLoadType.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbConLoadType.Location = New System.Drawing.Point(82, 128)
        Me.cbConLoadType.MaxDropDownItems = 20
        Me.cbConLoadType.Name = "cbConLoadType"
        Me.cbConLoadType.Size = New System.Drawing.Size(130, 20)
        Me.cbConLoadType.TabIndex = 397
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 413
        Me.Label6.Text = "装箱类别"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBillNO
        '
        Me.txtBillNO.Enabled = False
        Me.txtBillNO.Location = New System.Drawing.Point(298, 8)
        Me.txtBillNO.MaxLength = 120
        Me.txtBillNO.Name = "txtBillNO"
        Me.txtBillNO.Size = New System.Drawing.Size(130, 21)
        Me.txtBillNO.TabIndex = 400
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(224, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 412
        Me.Label4.Text = "提单号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 411
        Me.Label5.Text = "场站名"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNO
        '
        Me.txtNO.Enabled = False
        Me.txtNO.Location = New System.Drawing.Point(82, 8)
        Me.txtNO.MaxLength = 20
        Me.txtNO.Name = "txtNO"
        Me.txtNO.Size = New System.Drawing.Size(130, 21)
        Me.txtNO.TabIndex = 403
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 410
        Me.Label3.Text = "理货单编号"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVoyage
        '
        Me.txtVoyage.Enabled = False
        Me.txtVoyage.Location = New System.Drawing.Point(82, 104)
        Me.txtVoyage.MaxLength = 6
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(130, 21)
        Me.txtVoyage.TabIndex = 396
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 409
        Me.Label1.Text = "航次"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShip
        '
        Me.txtShip.Enabled = False
        Me.txtShip.Location = New System.Drawing.Point(82, 56)
        Me.txtShip.MaxLength = 40
        Me.txtShip.Name = "txtShip"
        Me.txtShip.Size = New System.Drawing.Size(130, 21)
        Me.txtShip.TabIndex = 395
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 408
        Me.Label2.Text = "船名码"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 407
        Me.txtID.Visible = False
        '
        'C1DBG
        '
        Me.C1DBG.AllowSort = False
        Me.C1DBG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("C1DBG.Images"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 162)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.PageSettings = CType(resources.GetObject("C1DBG.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBG.Size = New System.Drawing.Size(652, 364)
        Me.C1DBG.TabIndex = 421
        Me.C1DBG.PropBag = resources.GetString("C1DBG.PropBag")
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(258, 534)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(65, 24)
        Me.btnPrint.TabIndex = 444
        Me.btnPrint.Text = "打印"
        '
        'btnCallBill
        '
        Me.btnCallBill.Location = New System.Drawing.Point(512, 534)
        Me.btnCallBill.Name = "btnCallBill"
        Me.btnCallBill.Size = New System.Drawing.Size(66, 24)
        Me.btnCallBill.TabIndex = 446
        Me.btnCallBill.Text = "生成账单"
        '
        'btnSelectPrint
        '
        Me.btnSelectPrint.Location = New System.Drawing.Point(396, 544)
        Me.btnSelectPrint.Name = "btnSelectPrint"
        Me.btnSelectPrint.Size = New System.Drawing.Size(65, 24)
        Me.btnSelectPrint.TabIndex = 447
        Me.btnSelectPrint.Text = "选择打印"
        Me.btnSelectPrint.Visible = False
        '
        'btEdit
        '
        Me.btEdit.Enabled = False
        Me.btEdit.Location = New System.Drawing.Point(100, 534)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(65, 24)
        Me.btEdit.TabIndex = 448
        Me.btEdit.Text = "保存"
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(8, 82)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(72, 18)
        Me.Label35.TabIndex = 469
        Me.Label35.Text = "船名"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShipName
        '
        Me.txtShipName.BackColor = System.Drawing.Color.Lavender
        Me.txtShipName.Location = New System.Drawing.Point(82, 80)
        Me.txtShipName.MaxLength = 40
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.ReadOnly = True
        Me.txtShipName.Size = New System.Drawing.Size(130, 21)
        Me.txtShipName.TabIndex = 468
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(0, 524)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(65, 24)
        Me.btnExport.TabIndex = 445
        Me.btnExport.Text = "导出"
        Me.btnExport.Visible = False
        '
        'btnEditEnable
        '
        Me.btnEditEnable.Location = New System.Drawing.Point(32, 534)
        Me.btnEditEnable.Name = "btnEditEnable"
        Me.btnEditEnable.Size = New System.Drawing.Size(65, 24)
        Me.btnEditEnable.TabIndex = 470
        Me.btnEditEnable.Text = "修改"
        '
        'btnAddShipCode
        '
        Me.btnAddShipCode.Location = New System.Drawing.Point(438, 134)
        Me.btnAddShipCode.Name = "btnAddShipCode"
        Me.btnAddShipCode.Size = New System.Drawing.Size(65, 24)
        Me.btnAddShipCode.TabIndex = 471
        Me.btnAddShipCode.Text = "新加船码"
        '
        'btnAddConsign
        '
        Me.btnAddConsign.Location = New System.Drawing.Point(504, 134)
        Me.btnAddConsign.Name = "btnAddConsign"
        Me.btnAddConsign.Size = New System.Drawing.Size(65, 24)
        Me.btnAddConsign.TabIndex = 472
        Me.btnAddConsign.Text = "新加委托"
        '
        'cktransfer
        '
        Me.cktransfer.Location = New System.Drawing.Point(454, 534)
        Me.cktransfer.Name = "cktransfer"
        Me.cktransfer.Size = New System.Drawing.Size(52, 24)
        Me.cktransfer.TabIndex = 473
        Me.cktransfer.Text = "转账"
        '
        'btnGetOg
        '
        Me.btnGetOg.Location = New System.Drawing.Point(578, 134)
        Me.btnGetOg.Name = "btnGetOg"
        Me.btnGetOg.Size = New System.Drawing.Size(65, 24)
        Me.btnGetOg.TabIndex = 474
        Me.btnGetOg.Text = "原始"
        '
        'ckbEditBill
        '
        Me.ckbEditBill.Checked = True
        Me.ckbEditBill.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.ckbEditBill.Location = New System.Drawing.Point(198, 534)
        Me.ckbEditBill.Name = "ckbEditBill"
        Me.ckbEditBill.Size = New System.Drawing.Size(52, 24)
        Me.ckbEditBill.TabIndex = 475
        Me.ckbEditBill.Text = "改单"
        '
        'txtGoodsSpec
        '
        Me.txtGoodsSpec.Enabled = False
        Me.txtGoodsSpec.Location = New System.Drawing.Point(298, 80)
        Me.txtGoodsSpec.MaxLength = 50
        Me.txtGoodsSpec.Name = "txtGoodsSpec"
        Me.txtGoodsSpec.Size = New System.Drawing.Size(130, 21)
        Me.txtGoodsSpec.TabIndex = 638
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(224, 82)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(72, 18)
        Me.Label37.TabIndex = 639
        Me.Label37.Text = "规格"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ccbGoods
        '
        Me.ccbGoods.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.ccbGoods.AutoDropDown = True
        Me.ccbGoods.Caption = ""
        Me.ccbGoods.CaptionHeight = 17
        Me.ccbGoods.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ccbGoods.ColumnCaptionHeight = 18
        Me.ccbGoods.ColumnFooterHeight = 18
        Me.ccbGoods.ContentHeight = 16
        Me.ccbGoods.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.ccbGoods.EditorBackColor = System.Drawing.SystemColors.Window
        Me.ccbGoods.EditorFont = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ccbGoods.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.ccbGoods.EditorHeight = 16
        Me.ccbGoods.Images.Add(CType(resources.GetObject("ccbGoods.Images"), System.Drawing.Image))
        Me.ccbGoods.ItemHeight = 15
        Me.ccbGoods.Location = New System.Drawing.Point(298, 56)
        Me.ccbGoods.MatchEntryTimeout = CType(2000, Long)
        Me.ccbGoods.MaxDropDownItems = CType(20, Short)
        Me.ccbGoods.MaxLength = 32767
        Me.ccbGoods.MouseCursor = System.Windows.Forms.Cursors.Hand
        Me.ccbGoods.Name = "ccbGoods"
        Me.ccbGoods.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.ccbGoods.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.ccbGoods.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.ccbGoods.Size = New System.Drawing.Size(130, 22)
        Me.ccbGoods.TabIndex = 646
        Me.ccbGoods.PropBag = resources.GetString("ccbGoods.PropBag")
        '
        'btnPrintBill
        '
        Me.btnPrintBill.Location = New System.Drawing.Point(582, 534)
        Me.btnPrintBill.Name = "btnPrintBill"
        Me.btnPrintBill.Size = New System.Drawing.Size(66, 24)
        Me.btnPrintBill.TabIndex = 647
        Me.btnPrintBill.Text = "打印账单"
        '
        'FrmContainerOutPort_Query
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(652, 568)
        Me.Controls.Add(Me.btnPrintBill)
        Me.Controls.Add(Me.ccbGoods)
        Me.Controls.Add(Me.txtGoodsSpec)
        Me.Controls.Add(Me.ckbEditBill)
        Me.Controls.Add(Me.txtShipName)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.txtTotalNetWeight)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtMark)
        Me.Controls.Add(Me.txtBillNO)
        Me.Controls.Add(Me.txtNO)
        Me.Controls.Add(Me.txtVoyage)
        Me.Controls.Add(Me.txtShip)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.btnGetOg)
        Me.Controls.Add(Me.cktransfer)
        Me.Controls.Add(Me.btnAddConsign)
        Me.Controls.Add(Me.btnAddShipCode)
        Me.Controls.Add(Me.btnEditEnable)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.btEdit)
        Me.Controls.Add(Me.btnSelectPrint)
        Me.Controls.Add(Me.btnCallBill)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.cbPlace)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.cbConsign)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cbState)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.cbDescribe)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtpTimeBegin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbConLoadType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.C1DBG)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmContainerOutPort_Query"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "出口集装箱理货单信息 查看修改打印"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccbGoods, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub FrmContainerOutPort_Query_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EditMark = False
        PrintMark = False
        CreateAccountMark = False
        ClosingMark = False
        Me.ckbEditBill.CheckState = CheckState.Checked
        On Error GoTo Err
        Dim dw As New DataView()
        Dim dvCodeGoods As New DataView()
        Dim sqlstr, sqlCodeGoods As String
        Me.StartPosition = FormStartPosition.CenterScreen

        'Dim dvWorkType As New DataView()
        'Dim sqlWorkType As String
        'sqlWorkType = "SELECT WorkType_ID, WorkType_Name FROM Code_ConLoadContainer_Type"
        'dvWorkType = Filldata(sqlWorkType)
        'cbWorkType.DataSource = dvWorkType
        'cbWorkType.DisplayMember = "WorkType_Name"
        'cbWorkType.ValueMember = "WorkType_ID"

        Dim sqlConLoadType As String
        sqlConLoadType = "select Code_Tally_Type,Name_Tally_Type from Code_Tally_Type "
        cbConLoadType.DataSource = Filldata(sqlConLoadType)
        cbConLoadType.DisplayMember = "Name_Tally_Type"
        cbConLoadType.ValueMember = "Code_Tally_Type"

        sqlConsign = "SELECT CODE_SHIP_AGENT, SHIPAGENT_SHORT, SHIPAGENT_ENG FROM CODE_SHIP_AGENT where Mark <> '1' OR Mark IS NULL ORDER BY SHIPAGENT_SHORT"
        dvConsign = Filldata(sqlConsign)
        cbConsign.DataSource = dvConsign
        cbConsign.DisplayMember = "SHIPAGENT_SHORT"
        cbConsign.ValueMember = "CODE_SHIP_AGENT"

        'sqlCodeGoods = "select Code,Goods from CodeGoods "
        'dvCodeGoods = Filldata(sqlCodeGoods)
        'cbGoodsCode.DataSource = dvCodeGoods
        'cbGoodsCode.DisplayMember = "Goods"
        'cbGoodsCode.ValueMember = "Code"

        sqlCodeGoods = "select Code,Goods from CodeGoods where ConLoadMark='1' order by Goods"
        dvCodeGoods = Filldata(sqlCodeGoods)
        Me.ccbGoods.DataSource = dvCodeGoods
        Me.ccbGoods.DisplayMember = "Goods"
        Me.ccbGoods.ValueMember = "Code"
        Me.ccbGoods.ColumnHeaders = False
        Me.ccbGoods.Splits(0).DisplayColumns("Code").Visible = False
        Me.ccbGoods.Splits(0).DisplayColumns("Goods").AutoSize()

        Dim sqlCodeYard As String
        sqlCodeYard = "SELECT Code_Yard_ID, Code_Yard_Name, CodePrefix FROM Code_Yard  where Code_Yard_ID <> '00' ORDER BY Code_Yard_ID"
        cbPlace.DataSource = Filldata(sqlCodeYard)
        cbPlace.DisplayMember = "Code_Yard_Name"
        cbPlace.ValueMember = "Code_Yard_ID"

        sqlstr = "select * from Con_Load_Tally where Con_Load_Tally_ID =" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        'dtpTimeBegin.CustomFormat = "yyyy'-'MM'-'dd' 'HH':'mm"
        dtpTimeBegin.CustomFormat = "yyyy-MM-dd HH:mm"
        If dw.Count > 0 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("Con_Load_Tally_ID")
            txtShip.Text = ds.Tables(0).Rows(0).Item("CHI_VESSEL")
            txtVoyage.Text = ds.Tables(0).Rows(0).Item("VOYAGE")
            cbPlace.SelectedValue = ds.Tables(0).Rows(0).Item("WORK_PLACE")
            txtBillNO.Text = ds.Tables(0).Rows(0).Item("BLNO")
            txtMark.Text = ds.Tables(0).Rows(0).Item("MARK")
            txtNO.Text = ds.Tables(0).Rows(0).Item("NO")
            cbDescribe.Text = ds.Tables(0).Rows(0).Item("DESCR")
            cbState.Text = ds.Tables(0).Rows(0).Item("STATE")

            cbConLoadType.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_TALLY_TYPE")
            'cbGoodsCode.SelectedValue = DBNull.Value    '直接赋空值
            'ccbGoods.SelectedIndex = -1              '让Index=-1
            'cbGoodsCode.SelectedValue = ""              '赋一个不存在的值
            ccbGoods.Text = ds.Tables(0).Rows(0).Item("GoodsCha")
            Me.txtGoodsSpec.Text = ds.Tables(0).Rows(0).Item("GoodsSpec")
            cbConsign.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_CON_CONSIGN")
            strConsign = cbConsign.SelectedValue
            dtpTimeBegin.Value = ds.Tables(0).Rows(0).Item("TIME_FROM")

            txtAmount.Text = ds.Tables(0).Rows(0).Item("AMOUNT")
            txtTotalNetWeight.Text = ds.Tables(0).Rows(0).Item("TotalNetWeight")
            txtSize.Text = ds.Tables(0).Rows(0).Item("SIZE_MEASURE")

            strYCode = Me.cbPlace.SelectedValue
            strShip = txtShip.Text
            strVoyage = txtVoyage.Text
            strBillNo = txtBillNO.Text

            sqlShipCode = "SELECT SPCODE, CHI_VESSEL FROM Code_SHIPNAME WHERE SPCODE = '" & strShip & "'"
            dvShipCode = Filldata(sqlShipCode)
            If dvShipCode.Count > 0 Then
                strShip = dvShipCode(0)("SPCODE")
                Me.txtShip.Text = strShip
                If Not IsDBNull(dvShipCode(0)("CHI_VESSEL")) Then
                    Me.txtShipName.Text = dvShipCode(0)("CHI_VESSEL")
                End If
                shipmark = True
            Else
                shipmark = False
            End If

            strOldShipName = Me.txtShipName.Text
            strOldVoyage = Me.txtVoyage.Text
            If Not IsDBNull(ds.Tables(0).Rows(0)("AccountNo")) Then
                strOldAccountNo = ds.Tables(0).Rows(0)("AccountNo")
            Else
                strOldAccountNo = ""
                Me.ckbEditBill.Visible = False
            End If
            GetAccountID()              '获得账单ID，收费方式
            If iAccountType > 0 Then    '设置显示收费方式
                If iAccountType = 1 Then
                    Me.cktransfer.Checked = True
                Else
                    Me.cktransfer.Checked = False
                End If
            End If
            InitSubTable(ID)     '初始化子表c1grid
            delSum = -1
            Call Me.C1DBG_AfterDelete(sender, e)
            'Me.C1DBG.AllowSort = True
            Me.C1DBG.AllowUpdate = False
        End If
        btQuit.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub

    '从提单信息获得账单No
    Private Sub GetAccountNo()
        ds.Clear()
        sqlda.Fill(ds)
        strOldAccountNo = ds.Tables(0).Rows(0)("AccountNo").ToString()
    End Sub

    '根据账单No以及船名航次、ID倒序方式获得账单ID，收费方式
    Private Sub GetAccountID()
        If strOldAccountNo <> "" Then
            Dim sqlAccountBill As String
            Dim dvAccountBill As DataView
            sqlAccountBill = "select ACCOUNT_LIST_ID,Transfer,CHI_VESSEL,Voyage,LISTDATE from Bill_List " & _
                " where No='" & strOldAccountNo & "' and Voyage='" & strVoyage & "' order by ACCOUNT_LIST_ID Desc"
            dvAccountBill = Filldata(sqlAccountBill)
            If dvAccountBill.Count > 0 Then
                iAccountID = dvAccountBill(0)("ACCOUNT_LIST_ID")    '非空
                iAccountType = dvAccountBill(0)("Transfer")         '非空
            Else
                iAccountID = -1
                iAccountType = -1
            End If
        End If
    End Sub

    Private Sub InitSubTable(ByVal sqlID As String)
        Try
            Dim sqlSubTable As String
            'sqlSubTable = "select * from Con_Load_Tally_List where CodeYard = '" & strYCode & "' AND CHI_VESSEL ='" & strShip & "' and Voyage = '" & strVoyage & "' and BLNO = '" & strBillNo & "'"
            sqlSubTable = "select CON_LOAD_TALLY_LIST_ID,CON_LOAD_TALLY_ID,SHIP_ID,CHI_VESSEL,Voyage,BLNO,CONTAINER_NO,NEWSEALNO,SIZE_CON,CONTAINER_TYPE,PACK_CHA,PACK_ENG,AMOUNT,WEIGHT,NetWeight,VOLUME,OutStorage,DAMAGED_AMOUNT,DAMAGED_PACK,SecSealNO,ReasonOpenSeal,USER_NAME,CodeYard,ReeferTemp,TempUnit,DangerGrade,DangerMark,Checked,CheckTime,Printed,PrintTime,PrintPerson,StateC,FullOrEmpty " & _
                " from Con_Load_Tally_List where CHI_VESSEL ='" & strShip & "' and Voyage = '" & strVoyage & "' and BLNO = '" & strBillNo & "' and  CodeYard= '" & strYCode & "' order by CONTAINER_NO"
            dvSubTable = Updatedata(sqlSubTableda, sqlSubTable, dsSubTable)
            Me.C1DBG.DataSource = dvSubTable

            Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
            Me.C1DBG.ColumnFooters = True
            Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
            Me.C1DBG.Columns("CONTAINER_NO").FooterText = "合计" & dsSubTable.Tables(0).Rows.Count & "箱"
            Count = dsSubTable.Tables(0).Rows.Count

            Me.C1DBG.Splits(0).DisplayColumns.Item(0).Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item(1).Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item(2).Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("USER_NAME").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("PACK_ENG").Visible = False

            Me.C1DBG.Splits(0).DisplayColumns.Item("CHI_VESSEL").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("VOYAGE").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("BLNO").Visible = False
            'Me.C1DBG.Splits(0).DisplayColumns.Item("CodeYard").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("WEIGHT").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("DAMAGED_AMOUNT").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("DAMAGED_PACK").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("Checked").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("CheckTime").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("Printed").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("PrintTime").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("PrintPerson").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("StateC").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("FullOrEmpty").Visible = False
            cbConLoadType_SelectedIndexChanged(New Object(), New EventArgs())

            Me.C1DBG.Columns.Item("CHI_VESSEL").Caption = "船名"
            Me.C1DBG.Columns.Item("VOYAGE").Caption = "航次"
            Me.C1DBG.Columns.Item("BLNO").Caption = "提单号"
            Me.C1DBG.Columns.Item("CONTAINER_NO").Caption = "箱号"
            Me.C1DBG.Columns.Item("NEWSEALNO").Caption = "铅封号"
            Me.C1DBG.Columns.Item("SIZE_CON").Caption = "尺寸"
            Me.C1DBG.Columns.Item("CONTAINER_TYPE").Caption = "箱型"
            Me.C1DBG.Columns.Item("AMOUNT").Caption = "件数"
            Me.C1DBG.Columns.Item("PACK_CHA").Caption = "包装"
            Me.C1DBG.Columns.Item("WEIGHT").Caption = "毛重kg"
            Me.C1DBG.Columns.Item("NetWeight").Caption = "货重kg"
            Me.C1DBG.Columns.Item("VOLUME").Caption = "体积M3"
            Me.C1DBG.Columns.Item("OutStorage").Caption = "转外场"

            If Me.cbConLoadType.SelectedValue = "9" Then
                Me.C1DBG.Columns.Item("ReasonOpenSeal").Caption = "车号"
            Else
                Me.C1DBG.Columns.Item("ReasonOpenSeal").Caption = "开封原因"
            End If
            Me.C1DBG.Columns.Item("SecSealNO").Caption = "备注封"
            Me.C1DBG.Columns.Item("CodeYard").Caption = "装箱地点"
            Me.C1DBG.Columns.Item("ReeferTemp").Caption = "冷藏温度"
            Me.C1DBG.Columns.Item("TempUnit").Caption = "温标"
            Me.C1DBG.Columns.Item("DangerGrade").Caption = "危品等级"
            Me.C1DBG.Columns.Item("DangerMark").Caption = "标签"

            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_TYPE").AutoDropDown = True
            Me.C1DBG.Splits(0).DisplayColumns("PACK_CHA").AutoDropDown = True
            'Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("CodeYard").Locked = True
            'ds.Tables(0).Rows(0)("StateB") = "2" Or ds.Tables(0).Rows(0)("StateB") = "3"
            If Not IsDBNull(ds.Tables(0).Rows(0)("AccountNo")) Then
                Me.C1DBG.Splits(0).DisplayColumns.Item("PrintTime").Visible = True
                Me.C1DBG.Splits(0).DisplayColumns.Item("PrintPerson").Visible = True
                Me.C1DBG.Columns.Item("PrintTime").Caption = "出证时间"
                Me.C1DBG.Columns.Item("PrintPerson").Caption = "出证人"
                Me.C1DBG.Splits(0).DisplayColumns("PrintPerson").Locked = True
            End If

            Call FieldFill()
            SetDGWidth3(Me.C1DBG)
        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbConLoadType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbConLoadType.SelectedIndexChanged
        If Not C1DBG.DataSource Is Nothing Then
            If Not cbConLoadType.DataSource Is Nothing Then
                If cbConLoadType.SelectedValue = "B" Then
                    C1DBG.Splits(0).DisplayColumns("OutStorage").Visible = True
                Else
                    C1DBG.Splits(0).DisplayColumns("OutStorage").Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub FieldFill()
        Dim i As Integer
        Try
            Dim sqlConKind As String = "SELECT CODE_CON_KIND, CON_KIND_ENG FROM CODE_CON_KIND ORDER BY CODE_CON_KIND"
            Dim dvConKind As New DataView
            dvConKind = Filldata(sqlConKind)
            Me.C1DBG.Columns("CONTAINER_TYPE").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("CONTAINER_TYPE").ValueItems.Translate = True
            Me.C1DBG.Columns("CONTAINER_TYPE").ValueItems.MaxComboItems = 20
            For i = 0 To dvConKind.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = dvConKind(i)("CON_KIND_ENG")
                vi.Value = dvConKind(i)("CODE_CON_KIND")
                Me.C1DBG.Columns.Item("CONTAINER_TYPE").ValueItems.Values.Add(vi)
            Next

            Dim sqlPack As String = "SELECT CODE_PACK, PACK_CHA, PACK_ENG FROM CODE_PACK ORDER BY px"
            Dim dvPack As New DataView
            dvPack = Filldata(sqlPack)
            Me.C1DBG.Columns("PACK_CHA").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("PACK_CHA").ValueItems.Translate = True
            Me.C1DBG.Columns("PACK_CHA").ValueItems.MaxComboItems = 20
            For i = 0 To dvPack.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = dvPack(i)("PACK_CHA") & "/" & dvPack(i)("PACK_ENG")
                vi.Value = dvPack(i)("CODE_PACK")
                Me.C1DBG.Columns.Item("PACK_CHA").ValueItems.Values.Add(vi)
            Next

            Dim sqlYcode As String
            Dim dvYcode As New DataView
            sqlYcode = "SELECT Code_Yard_ID, Code_Yard_Name FROM Code_Yard where Code_Yard_ID <> '00' ORDER BY Code_Yard_ID"
            dvYcode = Filldata(sqlYcode)
            Me.C1DBG.Columns("CodeYard").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("CodeYard").ValueItems.Translate = True
            For i = 0 To dvYcode.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = dvYcode(i)("Code_Yard_Name")
                vi.Value = dvYcode(i)("Code_Yard_ID")
                Me.C1DBG.Columns.Item("CodeYard").ValueItems.Values.Add(vi)
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
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Width = 55
                i = i + 1
            Loop
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Width = 80
            Me.C1DBG.Splits(0).DisplayColumns("NEWSEALNO").Width = 90
            Me.C1DBG.Splits(0).DisplayColumns("SIZE_CON").Width = 25
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_TYPE").Width = 35
            Me.C1DBG.Splits(0).DisplayColumns("CodeYard").Width = 65
            Me.C1DBG.Splits(0).DisplayColumns("PrintTime").Width = 65
            Me.C1DBG.Splits(0).DisplayColumns("ReeferTemp").Width = 40
            Me.C1DBG.Splits(0).DisplayColumns("TempUnit").Width = 40
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Try
            'Call GetExcel()
            Call GetSelectExcel()
            xlSheet.Application.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            xlApp.Quit()
            SendKeys.Send("N")
        End Try
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim i As Integer
        If ds.Tables(0).Rows(0)("StateB") = "0" Then
            If MessageBox.Show("该提单为指示状态，请确定是否装箱或进码头。", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                Exit Sub
            End If
        End If
        If Me.cbPlace.SelectedValue = "08" Then
            MessageBox.Show("场站名称不可以是 监管信息中心，请修改。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        'If dvSubTable.Count > 20 Then
        '    Call btnSelectPrint_Click(sender, e)
        '    Exit Sub
        'End If
        For i = 0 To dvSubTable.Count - 1
            If Me.C1DBG.Columns("SecSealNO").CellText(i).Trim <> "" Then
                Me.C1DBG.Row = i
                Exit For
            End If
        Next
        If i < dvSubTable.Count Then
            If MessageBox.Show("存在备注铅封，仍然继续？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = DialogResult.Cancel Then
                Exit Sub
            End If
        End If

        If ds.Tables(0).Rows(0)("StateB") >= "2" Then     '是重复打印
            If ckbEditBill.CheckState = CheckState.Indeterminate Then
                Me.ckbEditBill.Focus()
                MessageBox.Show("再次打印理货单 请确定是否改单。", "提示")
                Exit Sub
            End If
        End If

        For i = 0 To Count - delSum - 1
            If Me.C1DBG.Columns("SIZE_CON").CellText(i) <> "" Then
            Else
                Me.C1DBG.Row = i
                MessageBox.Show("请输入箱尺寸", "提示")
                Exit Sub
            End If
        Next
        If Me.cbConsign.SelectedValue = "00" Or Me.cbConsign.SelectedValue Is Nothing Then
            cbConsign.Focus()
            MessageBox.Show("请选择委托单位", "提示")
            Exit Sub
        End If

        Call GetExcel()
        System.GC.Collect()


        Dim sqlIsBackUp As String      '判断是否已做过备份
        Dim dvIsBackUp As New DataView
        sqlIsBackUp = "select Con_Load_Tally_ID from CON_LOAD_TALLYtwo where Con_Load_Tally_ID =" & ID & ""
        dvIsBackUp = Filldata(sqlIsBackUp)
        If dvIsBackUp.Count = 0 Then    '未曾备份，现在备份
            Dim sqlBackUpBill, sqlBackUpCon As String
            sqlBackUpBill = "insert into CON_LOAD_TALLYtwo select * from CON_LOAD_TALLY where Con_Load_Tally_ID =" & ID & ""
            sqlBackUpCon = "insert into CON_LOAD_TALLY_LISTtwo select * from CON_LOAD_TALLY_LIST where CHI_VESSEL = '" & strShip & "' AND Voyage = '" & strVoyage & "' AND BLNO = '" & strBillNo & "' AND CodeYard = '" & strYCode & "'"
            ExecSql(sqlBackUpBill)
            ExecSql(sqlBackUpCon)
        End If

        Dim sqlPrinted, sqlPrintedB As String   '打印过后修改状态
        If ds.Tables(0).Rows(0)("StateB") = "0" Or ds.Tables(0).Rows(0)("StateB") = "1" Then    '是首次打印
            sqlPrinted = "update CON_LOAD_TALLY_LIST set StateC='2', printed='1', PrintTime='" & Now & "', PrintPerson='" & G_User & "' where CHI_VESSEL ='" & strShip & "' and Voyage = '" & strVoyage & "' and BLNO = '" & strBillNo & "' AND CodeYard = '" & strYCode & "'"
            sqlPrintedB = "update CON_LOAD_TALLY set StateB='2' where Con_Load_Tally_ID =" & ID & ""
            ExecSql(sqlPrinted)
            ExecSql(sqlPrintedB)
        Else    '是重复打印
            sqlPrinted = "update CON_LOAD_TALLY_LIST set StateC='2', printed='1', PrintTime='" & Now & "', PrintPerson='" & G_User & "' where CHI_VESSEL ='" & strShip & "' and Voyage = '" & strVoyage & "' and BLNO = '" & strBillNo & "' AND CodeYard = '" & strYCode & "'"
            For i = 0 To dvSubTable.Count - 1
                If Me.C1DBG.Columns("printed").CellText(i) = "0" Then
                    Exit For
                End If
            Next
            '发现有没打印的箱子（可能是在改提单首次打印过后加入的），要更新状态
            If i < dvSubTable.Count Then
                ExecSql(sqlPrinted)
            Else
                If ckbEditBill.Checked = True Then      '改单不管，不要更新出单时间
                Else
                    ExecSql(sqlPrinted)
                End If
            End If
        End If

        PrintMark = True

        Me.btnCallBill.Focus()

        MakeReportFile()
    End Sub

    Private Sub GetExcel()
        Dim PathStr As String
        Dim FilePath As String
        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        FilePath = PathStr + "ReportCopy.xls"
        FileCopy(PathStr & "Report_Pan.xls", FilePath)
        Try
            Dim xlApp As Excel.Application
            Dim xlBook As Excel.Workbook
            Dim xlSheet As Excel.Worksheet
            xlApp = CType(CreateObject("Excel.Application"), Excel.Application)

            xlBook = CType(xlApp.Workbooks.Open("" & FilePath & ""), Excel.Workbook)
            xlSheet = CType(xlBook.Worksheets("Sheet2"), Excel.Worksheet)
            xlSheet.Select()
            'xlApp.DisplayAlerts = False
            'xlSheet.Application.Visible = True

            xlSheet.Cells(7, 4) = Me.txtShipName.Text
            xlSheet.Cells(7, 8) = Me.txtVoyage.Text
            If Microsoft.VisualBasic.Right(Me.txtBillNO.Text, 2).Equals("##") Then  '处理特殊提单的打印，去除末尾特殊字符
                xlSheet.Cells(6, 4) = Mid(Me.txtBillNO.Text, 1, Me.txtBillNO.Text.Length - 2)
            Else
                xlSheet.Cells(6, 4) = Me.txtBillNO.Text
            End If
            xlSheet.Cells(8, 4) = Me.txtMark.Text

            If Me.cbConLoadType.SelectedValue = "3" OrElse Me.cbConLoadType.SelectedValue = "5" OrElse cbConLoadType.SelectedValue = "9" Then    '外托箱 验箱 转关箱
                xlSheet.Cells(8, 8) = ""
                xlSheet.Cells(9, 4) = ""
                xlSheet.Cells(9, 8) = ""
                If cbConLoadType.SelectedValue = "9" Then
                    xlSheet.Cells(11, 12) = "车 号"
                End If
            Else
                If Me.txtGoodsSpec.Text.Length > 0 Then
                    xlSheet.Cells(8, 8) = Me.ccbGoods.Text & "-" & Me.txtGoodsSpec.Text
                Else
                    xlSheet.Cells(8, 8) = Me.ccbGoods.Text
                End If
                xlSheet.Cells(9, 4) = Me.txtAmount.Text
                xlSheet.Cells(9, 8) = Me.txtTotalNetWeight.Text
            End If
            xlSheet.Cells(10, 4) = Me.cbDescribe.Text
            xlSheet.Cells(10, 8) = Me.cbState.Text

            xlSheet.Cells(2, 10) = Me.txtNO.Text
            xlSheet.Cells(4, 10) = Me.cbConLoadType.Text
            xlSheet.Cells(4, 4) = Me.cbPlace.Text

            xlSheet.Cells(36, 9) = Me.cbConsign.Text
            xlSheet.Cells(36, 4) = G_User

            Dim TimeBegin As Date = Me.dtpTimeBegin.Value
            xlSheet.Cells(6, 8) = TimeBegin.Year & "年 " & TimeBegin.Month & "月 " & TimeBegin.Day & "日 " & TimeBegin.Hour & "时"

            Dim iCount20, iCount40, iCount45, iCount58, iCountOther As Integer
            Dim i, j As Integer
            Count = Count - delSum
            Dim pageNum, p As Integer
            pageNum = Fix((Count - 1) / conPage) + 1 '20条记录一页,一共pageNum页

            For p = 0 To pageNum - 1
                Dim limitP As Integer
                limitP = conPage      '默认每页20条记录
                If p = pageNum - 1 Then
                    limitP = Count - p * conPage
                End If

                For j = 0 To 6  '清空备注栏
                    xlSheet.Cells(41 + j, 9) = ""
                Next
                j = 0
                iCount20 = 0
                iCount40 = 0
                iCount45 = 0
                iCount58 = 0
                iCountOther = 0

                For i = 0 To limitP - 1  ' limitP 即将打印页有多少箱
                    xlSheet.Cells(13 + i, 1) = Me.C1DBG.Columns("CONTAINER_NO").CellText(i + p * conPage)
                    xlSheet.Cells(13 + i, 4) = Me.C1DBG.Columns("NEWSEALNO").CellText(i + p * conPage)
                    xlSheet.Cells(13 + i, 5) = Me.C1DBG.Columns("SIZE_CON").CellText(i + p * conPage)
                    xlSheet.Cells(13 + i, 6) = Me.C1DBG.Columns("CONTAINER_TYPE").CellText(i + p * conPage)
                    If Me.cbConLoadType.SelectedValue = "3" OrElse Me.cbConLoadType.SelectedValue = "5" OrElse cbConLoadType.SelectedValue = "9" Then    '外托箱 验箱 转关箱
                        xlSheet.Cells(13 + i, 7) = ""
                        xlSheet.Cells(13 + i, 8) = ""
                        xlSheet.Cells(13 + i, 10) = ""
                        If Me.cbConLoadType.SelectedValue = "9" AndAlso C1DBG.Columns("ReasonOpenSeal").CellText(i + p * conPage).Trim <> "" Then
                            xlSheet.Cells(13 + i, 12) = Me.C1DBG.Columns("ReasonOpenSeal").CellText(i + p * conPage).Trim
                        Else
                            xlSheet.Cells(13 + i, 12) = ""
                        End If
                    Else
                        xlSheet.Cells(13 + i, 7) = Me.C1DBG.Columns("AMOUNT").CellText(i + p * conPage)
                        xlSheet.Cells(13 + i, 8) = Me.C1DBG.Columns("PACK_CHA").CellText(i + p * conPage)
                        xlSheet.Cells(13 + i, 10) = Me.C1DBG.Columns("NetWeight").CellText(i + p * conPage)
                        xlSheet.Cells(13 + i, 12) = Me.C1DBG.Columns("VOLUME").CellText(i + p * conPage)
                        
                    End If

                    If Me.C1DBG.Columns("SecSealNO").CellText(i + p * conPage).Trim <> "" Then
                        xlSheet.Cells(41 + j, 9) = Me.C1DBG.Columns("CONTAINER_NO").CellText(i + p * conPage) & "/" & Me.C1DBG.Columns("SecSealNO").CellText(i + p * conPage).Trim
                        j += 1
                    End If

                    Select Case Me.C1DBG.Columns("SIZE_CON").CellText(i + p * conPage)
                        Case "20"
                            iCount20 += 1
                        Case "40"
                            iCount40 += 1
                        Case "45"
                            iCount45 += 1
                        Case "58"
                            iCount58 += 1
                        Case Else
                            iCountOther += 1
                    End Select
                Next
                If p = pageNum - 1 Then  '最后一页操作
                    For i = limitP To conPage - 1
                        xlSheet.Cells(13 + i, 1) = ""
                        xlSheet.Cells(13 + i, 4) = ""
                        xlSheet.Cells(13 + i, 5) = ""
                        xlSheet.Cells(13 + i, 6) = ""
                        xlSheet.Cells(13 + i, 7) = ""
                        xlSheet.Cells(13 + i, 8) = ""
                        xlSheet.Cells(13 + i, 10) = ""
                        xlSheet.Cells(13 + i, 12) = ""
                    Next
                End If
                Dim strTotal As String
                strTotal = limitP & "箱"
                If iCount20 <> 0 Then
                    strTotal = strTotal & " 其中 20 X " & iCount20
                End If
                If iCount40 <> 0 Then
                    strTotal = strTotal & " , 40 X " & iCount40
                End If
                If iCount45 <> 0 Then
                    strTotal = strTotal & " , 45 X " & iCount45
                End If
                If iCount58 <> 0 Then
                    strTotal = strTotal & " , 58 X " & iCount58
                End If
                If iCountOther <> 0 Then
                    strTotal = strTotal & " , 其它 X " & iCountOther
                End If
                xlSheet.Cells(33, 4) = strTotal
                xlSheet.PrintOut()
            Next
            xlBook.Close(False)
            xlApp.Quit()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            xlApp.Quit()
        End Try
    End Sub

    Private Sub C1DBG_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.AfterDelete
        delSum += 1
        Me.C1DBG.Columns("CONTAINER_NO").FooterText = "合计" & Count - delSum & "箱"
        Dim i As Integer
        Dim totalAmount As Integer
        Dim totalNetWeight As Decimal
        For i = 0 To Count - delSum - 1
            If Me.C1DBG.Columns("AMOUNT").CellText(i) <> "" Then
                totalAmount += Me.C1DBG.Columns("AMOUNT").CellText(i)
            End If
            If Me.C1DBG.Columns("NetWeight").CellText(i) <> "" Then
                totalNetWeight += Me.C1DBG.Columns("NetWeight").CellText(i)
            End If
        Next
        If Me.txtAmount.Text = "" Then
            Me.txtAmount.Text = totalAmount
        End If
        If Me.txtTotalNetWeight.Text = "" Then
            Me.txtTotalNetWeight.Text = totalNetWeight
        End If
    End Sub

    Private Sub FrmContainerOutPort_Query_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'If PrintMark = True Then    '如果打印
        '    If CreateAccountMark = False Then     '但没有生成账单
        '        If ds.Tables(0).Rows(0)("StateB") = "0" Or ds.Tables(0).Rows(0)("StateB") = "1" Then    '是首次打印，原先无账单
        '            MessageBox.Show("首次打印理货单，请生成账单！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '            If MessageBox.Show("转账吗？", "疑问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        '                Me.cktransfer.Checked = True
        '            Else
        '                Me.cktransfer.Checked = False
        '            End If
        '            ClosingMark = True
        '            Call Me.btnCallBill_Click(sender, e)
        '        Else    '以前打印过，原来有账单
        '            If EditMark = True Then
        '                MessageBox.Show("再次打印理货单，如果修改数据必须重新生成账单！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '                If MessageBox.Show("转账吗？", "疑问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        '                    Me.cktransfer.Checked = True
        '                Else
        '                    Me.cktransfer.Checked = False
        '                End If
        '                ClosingMark = True
        '                Call Me.btnCallBill_Click(sender, e)
        '            End If
        '            '没有修改不用从新生成账单
        '        End If
        '    End If
        'End If

        If CreateAccountMark = False Then     '没有生成账单
            If strOldAccountNo = "" Then    '是首次，原先无账单
                If PrintMark = True Then    '如果打印
                    MessageBox.Show("首次打印理货单，请生成账单！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    If MessageBox.Show("转账吗？", "疑问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Me.cktransfer.Checked = True
                    Else
                        Me.cktransfer.Checked = False
                    End If
                    ClosingMark = True
                    Call CreateAccount()
                End If
            Else    '以前打印过，原来有账单
                If EditMark = True Or PrintMark = True Then    '修改过或打印过的要重新生成账单
                    MessageBox.Show("再次打印或修改理货单必须重新生成账单！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    If MessageBox.Show("转账吗？", "疑问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        Me.cktransfer.Checked = True
                    Else
                        Me.cktransfer.Checked = False
                    End If
                    ClosingMark = True
                    Call CreateAccount()
                End If
            End If
        End If
    End Sub

    Private Sub btnCallBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCallBill.Click
        'If PrintMark = True Then    '打印过理货单才可以操作账单
        '    If ClosingMark = False Then
        '        If Me.cktransfer.Checked = False Then
        '            Dim result As DialogResult
        '            result = MessageBox.Show("确定是现金么？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        '            If result = DialogResult.Yes Then
        '                '不变
        '            ElseIf result = DialogResult.No Then
        '                Me.cktransfer.Checked = True
        '            ElseIf result = DialogResult.Cancel Then
        '                Exit Sub
        '            End If
        '        End If
        '    End If

        '    '在生成帐单旁边加一个checkbox，命名为cktransfer  
        '    '判断委托人是否为空 & strShip & "' and Voyage = '" & strVoyage & "' and BLNO = '" & strBillNo & "'"
        '    Dim dsConsign As New DataSet   '
        '    Dim transfer As Integer = 0
        '    If Me.cktransfer.Checked = True Then
        '        transfer = 1
        '    End If
        '    Getdata("select code_con_consign from con_load_tally where CHI_VESSEL ='" & strShip & "' and Voyage = '" & strVoyage & "' and BLNO = '" & strBillNo & "'", dsConsign)
        '    'If dsConsign.Tables(0).Rows.Count = 0 Then
        '    '    MsgBox("委托人不能为空！", MsgBoxStyle.OKOnly, "提示")
        '    'End If
        '    If dsConsign.Tables(0).Rows.Count > 1 Then
        '        MsgBox("存在同船名航次同提单的情况，请查验！", MsgBoxStyle.OKOnly, "提示")
        '    End If
        '    If dsConsign.Tables(0).Rows.Count = 1 Then
        '        'If (Trim(dsConsign.Tables(0).Rows(0)(0)) <> "00") Then
        '        Try

        '            If strOldAccountNo = "" Then   '如果原无账单
        '                '只新生成账单
        '                ExecSql("exec SP_ConLoadTallyFeeStat  '" & strShip & "', '" & strVoyage & "', '" & strBillNo & "' , '" & transfer & "','" & G_User & "'")
        '            Else   '如果原生成过账单
        '                If EditMark = True Then     '而且修改了理货单
        '                    '删除原账单，生成新账单
        '                    Call DelOldAccout()
        '                    ExecSql("exec SP_ConLoadTallyFeeStat  '" & strShip & "', '" & strVoyage & "', '" & strBillNo & "' , '" & transfer & "','" & G_User & "'")
        '                Else   '没有修改不用重新生成账单
        '                    If ClosingMark = False Then     '但如果用户确实要重新生成账单（对已完成的理货单不修改直接打印后点生成账单），可能变化了账单类型
        '                        '删除原账单，生成新账单
        '                        Call DelOldAccout()
        '                        ExecSql("exec SP_ConLoadTallyFeeStat  '" & strShip & "', '" & strVoyage & "', '" & strBillNo & "' , '" & transfer & "','" & G_User & "'")
        '                    End If
        '                End If
        '            End If
        '            CreateAccountMark = True

        '            Me.Close()
        '        Catch ex As System.Exception
        '            MsgBox(ex.Message)
        '        End Try
        '        'Else
        '        '    MsgBox("委托人不能为空！", MsgBoxStyle.OKOnly, "提示")
        '        'End If
        '    End If
        'Else
        '    MessageBox.Show("未对理货单操作不可生成账单！", "警示", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        'End If

        If strOldAccountNo = "" Then    '无帐单，是首次
            If PrintMark = True Then    '打印
                '必须生成账单
                CreateAccount()
            Else
                MessageBox.Show("请先打印理货单。", "提示")
            End If
        Else    '有账单，是再次
            If EditMark = True Or PrintMark = True Then     '修改或打印了理货单
                '修改时必须，打印时可以（此按钮被点击） 重新生成账单
                CreateAccount()
            Else
                MessageBox.Show("请先修改或打印理货单。", "提示")
            End If
        End If
    End Sub

    Private Sub CreateAccount()     '账单处理
        If ClosingMark = False Then '正常情况（从生成账单按钮进入）
            If Me.cktransfer.Checked = False Then
                Dim result As DialogResult
                result = MessageBox.Show("确定是现金么？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    '不变
                ElseIf result = DialogResult.No Then
                    Me.cktransfer.Checked = True
                ElseIf result = DialogResult.Cancel Then
                    Exit Sub
                End If
            End If
        End If

        Dim transfer As Integer = 0
        If Me.cktransfer.Checked = True Then
            transfer = 1
        End If
        'Dim dsConsign As New DataSet   '
        'Getdata("select code_con_consign from con_load_tally where CHI_VESSEL ='" & strShip & "' and Voyage = '" & strVoyage & "' and BLNO = '" & strBillNo & "'", dsConsign)
        'If dsConsign.Tables(0).Rows.Count > 1 Then
        '    MsgBox("存在同船名航次同提单的情况，请查验！", MsgBoxStyle.OKOnly, "提示")
        'End If
        'If dsConsign.Tables(0).Rows.Count = 1 Then

        'End If
        Try
            If strOldAccountNo = "" Then   '原无账单
                '只新生成账单
                ExecSql("exec SP_ConLoadTallyFeeStat  '" & strShip & "', '" & strVoyage & "', '" & strBillNo & "' ,'" & strYCode & "' , '" & transfer & "','" & G_User & "'")
            Else   '原有账单
                '删除原账单，生成新账单
                Call DelOldAccout()
                ExecSql("exec SP_ConLoadTallyFeeStat  '" & strShip & "', '" & strVoyage & "', '" & strBillNo & "' ,'" & strYCode & "' , '" & transfer & "','" & G_User & "'")
            End If
            CreateAccountMark = True
            '先从提单信息中获得账单编号
            GetAccountNo()
            If strOldAccountNo <> "" Then
                GetAccountID()
                If iAccountID >= 0 Then
                    If Me.cktransfer.Checked = False Then
                        ShowBill()
                    End If
                    Me.Close()
                Else
                    MessageBox.Show("账单未能获取", "提示")
                End If
            Else
                MessageBox.Show("账单编号没有生成", "提示")
            End If


        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ShowBill()  '显示修改打印账单界面
        If iAccountID >= 0 Then
            Dim tempID As Integer
            tempID = ID
            ID = iAccountID
            Dim frmBillEdit As New frm_conload_edit
            frmBillEdit.strBillNo = strBillNo
            frmBillEdit.ShowDialog()
            ID = tempID
        End If
    End Sub

    Private Sub btnPrintBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintBill.Click
        ShowBill()
    End Sub

    Private Sub DelOldAccout() '删除原账单
        Dim sqlGetBill, sqlDelBillList, sqlDelBillDetail As String
        Dim dvGetBill As New DataView
        sqlGetBill = "SELECT ACCOUNT_LIST_ID, CHI_VESSEL, VOYAGE, [NO], BILL_ID FROM BILL_LIST WHERE (CHI_VESSEL = '" & strOldShipName & "') AND (VOYAGE = '" & strOldVoyage & "') AND ([NO] = '" & strOldAccountNo & "')"
        dvGetBill = Filldata(sqlGetBill)
        If dvGetBill.Count > 0 Then     '如果有账单
            If IsDBNull(dvGetBill(0)("BILL_ID")) Then '无发票ＩＤ，可删除
                Dim accountNo As Integer
                If dvGetBill.Count > 0 Then
                    accountNo = dvGetBill(0)("ACCOUNT_LIST_ID")
                End If
                sqlDelBillList = "delete from bill_list where ACCOUNT_LIST_ID= " & accountNo & ""
                sqlDelBillDetail = "delete from bill_detail where ACCOUNT_LIST_ID= " & accountNo & ""
                ExecSql(sqlDelBillList)
                ExecSql(sqlDelBillDetail)
            End If
        End If
    End Sub

    Private Sub btnSelectPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectPrint.Click
        Dim i As Integer
        If Me.C1DBG.SelectedRows.Count > 0 Then
            If ds.Tables(0).Rows(0)("StateB") = "0" Then
                If MessageBox.Show("该提单为指示状态，请确定是否装箱或进码头。", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                    Exit Sub
                End If
            End If
            If Me.cbPlace.SelectedValue = "08" Then
                MessageBox.Show("场站名称不可以是 监管信息中心，请修改。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
            Try
                Me.C1DBG.Focus()
                For i = 0 To Me.C1DBG.SelectedRows.Count - 1
                    If Me.C1DBG.Columns("SIZE_CON").CellText(i) <> "" Then
                        Me.C1DBG.Row = Me.C1DBG.SelectedRows(i)
                        Me.C1DBG.Columns("StateC").Text = "2"
                        Me.C1DBG.Columns("printed").Text = "1"
                        Me.C1DBG.Columns("PrintTime").Text = Now
                        Me.C1DBG.Columns("PrintPerson").Text = G_User
                    Else
                        Me.C1DBG.Row = i
                        MessageBox.Show("请输入箱尺寸", "提示")
                        Exit Sub
                    End If
                Next
                Me.btQuit.Focus()
                If Me.cbConsign.SelectedValue = "00" Or Me.cbConsign.SelectedValue Is Nothing Then
                    cbConsign.Focus()
                    MessageBox.Show("请选择委托单位", "提示")
                    Exit Sub
                End If

                Call GetSelectExcel()
                'xlSheet.Application.Visible = True
                'xlSheet.PrintOut()
                'xlApp.Quit()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                xlApp.Quit()
                SendKeys.Send("N")
            End Try

            sqlSubTableda.Update(dsSubTable)
            PrintMark = True
            Me.btnCallBill.Focus()
        Else
            MessageBox.Show("请选择要打印的箱子，鼠标选择使其颜色变化即可", "提示")
        End If
    End Sub

    Private Sub GetSelectExcel()
        Dim PathStr As String
        Dim FilePath As String
        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        FilePath = PathStr + "ReportCopy.xls"
        FileCopy(PathStr & "Report_Pan.xls", FilePath)

        xlApp = CType(CreateObject("Excel.Application"), Excel.Application)
        xlBook = CType(xlApp.Workbooks.Open("" & FilePath & ""), Excel.Workbook)
        xlSheet = CType(xlBook.Worksheets(2), Excel.Worksheet)
        xlSheet.Select(2)
        xlApp.DisplayAlerts = False

        xlSheet.Cells(7, 4) = Me.txtShipName.Text
        xlSheet.Cells(7, 8) = Me.txtVoyage.Text
        If Microsoft.VisualBasic.Right(Me.txtBillNO.Text, 2).Equals("##") Then  '处理特殊提单的打印，去除末尾特殊字符
            xlSheet.Cells(6, 4) = Mid(Me.txtBillNO.Text, 1, Me.txtBillNO.Text.Length - 2)
        Else
            xlSheet.Cells(6, 4) = Me.txtBillNO.Text
        End If
        xlSheet.Cells(8, 4) = Me.txtMark.Text
        xlSheet.Cells(8, 8) = Me.ccbGoods.Text
        xlSheet.Cells(9, 4) = Me.txtAmount.Text
        xlSheet.Cells(9, 8) = Me.txtTotalNetWeight.Text
        xlSheet.Cells(10, 4) = Me.cbDescribe.Text
        xlSheet.Cells(10, 8) = Me.cbState.Text

        xlSheet.Cells(2, 10) = Me.txtNO.Text
        xlSheet.Cells(4, 10) = Me.cbConLoadType.Text
        xlSheet.Cells(4, 4) = Me.cbPlace.Text

        Dim TimeBegin As Date = Me.dtpTimeBegin.Value
        xlSheet.Cells(6, 8) = TimeBegin.Year & "年 " & TimeBegin.Month & "月 " & TimeBegin.Day & "日 " & TimeBegin.Hour & "时"

        Dim iCount20, iCount40, iCount45, iCount58, iCountOther As Integer
        Dim i, j As Integer
        Count = Me.C1DBG.SelectedRows.Count

        Dim pageNum, p As Integer
        pageNum = Fix((Count - 1) / conPage) + 1 '20条记录一页,一共pageNum页

        For p = 0 To pageNum - 1
            Dim limitP As Integer
            limitP = conPage      '默认每页20条记录
            If p = pageNum - 1 Then
                limitP = Count - p * conPage
            End If

            For j = 0 To 6  '清空备注栏
                xlSheet.Cells(41 + j, 9) = ""
            Next
            j = 0
            iCount20 = 0
            iCount40 = 0
            iCount45 = 0
            iCount58 = 0
            iCountOther = 0

            For i = 0 To limitP - 1
                Me.C1DBG.Row = Me.C1DBG.SelectedRows(i + p * conPage)
                xlSheet.Cells(13 + i, 1) = Me.C1DBG.Columns("CONTAINER_NO").Text
                xlSheet.Cells(13 + i, 4) = Me.C1DBG.Columns("NEWSEALNO").Text
                xlSheet.Cells(13 + i, 5) = Me.C1DBG.Columns("SIZE_CON").Text
                xlSheet.Cells(13 + i, 6) = Me.C1DBG.Columns("CONTAINER_TYPE").Text
                xlSheet.Cells(13 + i, 7) = Me.C1DBG.Columns("AMOUNT").Text
                xlSheet.Cells(13 + i, 8) = Me.C1DBG.Columns("PACK_CHA").Text
                xlSheet.Cells(13 + i, 10) = Me.C1DBG.Columns("NetWeight").Text
                xlSheet.Cells(13 + i, 12) = Me.C1DBG.Columns("VOLUME").Text
                If Me.C1DBG.Columns("SecSealNO").Text <> "" Then
                    xlSheet.Cells(41 + j, 9) = Me.C1DBG.Columns("CONTAINER_NO").Text & "/" & Me.C1DBG.Columns("SecSealNO").Text
                    j += 1
                End If

                Select Case Me.C1DBG.Columns("SIZE_CON").Text
                    Case "20"
                        iCount20 += 1
                    Case "40"
                        iCount40 += 1
                    Case "45"
                        iCount45 += 1
                    Case "58"
                        iCount58 += 1
                    Case Else
                        iCountOther += 1
                End Select
            Next
            If p = pageNum - 1 Then  '最后一页操作
                For i = limitP To conPage - 1
                    xlSheet.Cells(13 + i, 1) = ""
                    xlSheet.Cells(13 + i, 4) = ""
                    xlSheet.Cells(13 + i, 5) = ""
                    xlSheet.Cells(13 + i, 6) = ""
                    xlSheet.Cells(13 + i, 7) = ""
                    xlSheet.Cells(13 + i, 8) = ""
                    xlSheet.Cells(13 + i, 10) = ""
                    xlSheet.Cells(13 + i, 12) = ""
                Next
            End If
            Dim strTotal As String
            strTotal = limitP & "箱"
            If iCount20 <> 0 Then
                strTotal = strTotal & " 其中 20 X " & iCount20
            End If
            If iCount40 <> 0 Then
                strTotal = strTotal & " , 40 X " & iCount40
            End If
            If iCount45 <> 0 Then
                strTotal = strTotal & " , 45 X " & iCount45
            End If
            If iCount58 <> 0 Then
                strTotal = strTotal & " , 58 X " & iCount58
            End If
            If iCountOther <> 0 Then
                strTotal = strTotal & " , 其它 X " & iCountOther
            End If
            xlSheet.Cells(33, 4) = strTotal

            xlSheet.PrintOut()
        Next
        xlApp.Quit()
    End Sub

    Private Sub cbConsign_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbConsign.Leave
        Dim i As Integer
        Try
            For i = 0 To Me.cbConsign.Items.Count - 1
                If cbConsign.Text.Trim = Me.dvConsign(i)("SHIPAGENT_SHORT") Then
                    Me.cbConsign.SelectedValue = Me.dvConsign(i)("CODE_SHIP_AGENT")
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEdit.Click

        Me.txtBillNO.Text = Me.txtBillNO.Text.Trim.ToUpper
        Me.txtVoyage.Text = Me.txtVoyage.Text.Trim.ToUpper

        strNewBillNo = Me.txtBillNO.Text
        strNewShip = Me.txtShip.Text
        strNewVoyage = Me.txtVoyage.Text
        strNewYard = Me.cbPlace.SelectedValue

        Dim beSure As Boolean

        '箱信息检查
        Dim i, j, iConCheck, iConBeing As Integer
        Dim strContainer, sqlBeing As String
        Call TrimGrid()

        For i = 0 To dvSubTable.Count - 1
            strContainer = Me.C1DBG.Columns("CONTAINER_NO").CellText(i)
            If strContainer <> "" Then
                If IsNumeric(Me.C1DBG.Columns("SIZE_CON").CellText(i)) Then
                    iConCheck = CheckConNO(strContainer)
                    '箱号没有通过检验时
                    If iConCheck = 1 Or iConCheck = 0 Then
                        sqlBeing = "SELECT CONTAINER_NO FROM CON_CRITERION WHERE CONTAINER_NO = '" & strContainer & "' or CONTAINER_NO = '" & GetConOtherMode(strContainer) & "'"
                        iConBeing = Filldata(sqlBeing).Count
                        If iConBeing = 0 Then    '箱规范中不存在
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
                    For j = 0 To i - 1
                        If IsEqualConNo(strContainer, Me.C1DBG.Columns("CONTAINER_NO").CellText(j)) Then
                            Me.C1DBG.Row = i
                            Me.C1DBG.SelectedRows.Clear()
                            Me.C1DBG.SelectedRows.Add(i)
                            Me.C1DBG.SelectedRows.Add(j)
                            MessageBox.Show("第" & j + 1 & "行和第" & i + 1 & "行 同一提单下集装箱号重复！", "提示")
                            Exit Sub
                        End If
                    Next
                Else
                    Me.C1DBG.Row = i
                    Me.C1DBG.SelectedRows.Clear()
                    Me.C1DBG.SelectedRows.Add(i)
                    MessageBox.Show("箱尺寸不能为空！", "提示")
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

        '提单信息检查
        Dim sqlUpdateBill As String
        Dim strNewNo As String
        Dim sqlBillExist As String
        Dim iAmount As Integer
        Dim fWeight As Decimal
        If i >= dvSubTable.Count Then
            If Me.cbConsign.SelectedValue <> "00" And Not IsNothing(Me.cbConsign.SelectedValue) Then
                If Me.cbConLoadType.SelectedValue <> "0" Then

                    If IsNumeric(Me.txtAmount.Text.Trim) Then
                        iAmount = Me.txtAmount.Text.Trim
                    Else
                        If Me.txtAmount.Text.Trim <> "" Then
                            Me.txtAmount.Focus()
                            MessageBox.Show("总件数应为数字", "提示")
                            Exit Sub
                        End If
                    End If
                    If IsNumeric(Me.txtTotalNetWeight.Text.Trim) Then
                        fWeight = Me.txtTotalNetWeight.Text.Trim
                    Else
                        If Me.txtTotalNetWeight.Text.Trim <> "" Then
                            Me.txtTotalNetWeight.Focus()
                            MessageBox.Show("总货重应为数字", "提示")
                            Exit Sub
                        End If
                    End If

                    If strNewShip <> strShip OrElse strNewVoyage <> strVoyage OrElse strNewBillNo <> strBillNo OrElse strNewYard <> strYCode Then
                        '只要改变了船码航次提单号场站中任何一个，就要检查数据库
                        If shipmark = False Then
                            Me.txtShip.Focus()
                            MessageBox.Show("船码 " & strNewShip & " 不存在，请重新输入", "提示")
                            Exit Sub
                        End If
                        sqlBillExist = "select CHI_VESSEL, VOYAGE, BLNO from CON_LOAD_Tally where BLNO = '" & strNewBillNo & _
                                                "' and CHI_VESSEL = '" & strNewShip & _
                                                "' and VOYAGE = '" & strNewVoyage & "' and Work_Place = '" & strNewYard & "' and CON_LOAD_TALLY_ID <> '" & ID & "'"
                        If Filldata(sqlBillExist).Count = 0 Then
                            If MessageBox.Show("确定对以上信息的修改么？", "警示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                                beSure = True
                                If strNewYard <> strYCode Then      '改变场站时，也改理货单编号
                                    strNewNo = GetAutoNo(strNewYard)    '生成理货单编号
                                    Me.txtNO.Text = strNewNo
                                    sqlUpdateBill = "update CON_LOAD_TALLY set CHI_VESSEL='" & strNewShip & "', Voyage='" & strNewVoyage & "', BLNO='" & strNewBillNo & "', NO='" & strNewNo & "', WORK_PLACE='" & strNewYard & "', CODE_TALLY_TYPE='" & Me.cbConLoadType.SelectedValue & "', MARK='" & Me.txtMark.Text.Trim.ToUpper & "', GoodsCha='" & Me.ccbGoods.Text & "', GoodsSpec='" & Me.txtGoodsSpec.Text & "', AMOUNT= " & iAmount & ", TotalNetWeight= " & fWeight & ", SIZE_MEASURE='" & Me.txtSize.Text.Trim & "', TIME_FROM='" & Me.dtpTimeBegin.Value & "', DESCR='" & Me.cbDescribe.Text & "', STATE='" & Me.cbState.Text & "',  CODE_CON_CONSIGN='" & Me.cbConsign.SelectedValue & "' where CHI_VESSEL='" & strShip & "' and Voyage='" & strVoyage & "' and BLNO='" & strBillNo & "'and Work_Place = '" & strYCode & "'"
                                Else    '未改变场站时，不改理货单编号
                                    sqlUpdateBill = "update CON_LOAD_TALLY set CHI_VESSEL='" & strNewShip & "', Voyage='" & strNewVoyage & "', BLNO='" & strNewBillNo & "', CODE_TALLY_TYPE='" & Me.cbConLoadType.SelectedValue & "', MARK='" & Me.txtMark.Text.Trim.ToUpper & "', GoodsCha='" & Me.ccbGoods.Text & "', GoodsSpec='" & Me.txtGoodsSpec.Text & "', AMOUNT= " & iAmount & ", TotalNetWeight= " & fWeight & ", SIZE_MEASURE='" & Me.txtSize.Text.Trim & "', TIME_FROM='" & Me.dtpTimeBegin.Value & "', DESCR='" & Me.cbDescribe.Text & "', STATE='" & Me.cbState.Text & "',  CODE_CON_CONSIGN='" & Me.cbConsign.SelectedValue & "' where CHI_VESSEL='" & strShip & "' and Voyage='" & strVoyage & "' and BLNO='" & strBillNo & "' and Work_Place = '" & strYCode & "'"
                                End If
                            End If
                        Else
                            Me.txtShip.Focus()
                            MessageBox.Show("船名码 航次 提单号不可重复！", "提示")
                            Exit Sub
                        End If
                    Else    '未改变船名航次提单号时，不检查
                        If MessageBox.Show("确定对以上信息的修改么？", "警示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                            beSure = True
                            'If strNewYard <> strYCode Then      '改变场站时，也改理货单编号
                            '    strNewNo = GetAutoNo(strNewYard)    '生成理货单编号
                            '    Me.txtNO.Text = strNewNo
                            '    sqlUpdateBill = "update CON_LOAD_TALLY set NO='" & strNewNo & "', WORK_PLACE='" & strNewYard & "', CODE_TALLY_TYPE='" & Me.cbConLoadType.SelectedValue & "', MARK='" & Me.txtMark.Text.Trim.ToUpper & "', GoodsCha='" & Me.cbGoodsCode.Text & "', GoodsSpec='" & Me.txtGoodsSpec.Text & "', AMOUNT= " & iAmount & ", TotalNetWeight= " & fWeight & ", SIZE_MEASURE='" & Me.txtSize.Text.Trim & "', TIME_FROM='" & Me.dtpTimeBegin.Value & "', DESCR='" & Me.cbDescribe.Text & "', STATE='" & Me.cbState.Text & "',  CODE_CON_CONSIGN='" & Me.cbConsign.SelectedValue & "' where CHI_VESSEL='" & strShip & "' and Voyage='" & strVoyage & "' and BLNO='" & strBillNo & "'"
                            'Else    '未改变场站时，不改理货单编号 最简单
                            '    sqlUpdateBill = "update CON_LOAD_TALLY set CODE_TALLY_TYPE='" & Me.cbConLoadType.SelectedValue & "', MARK='" & Me.txtMark.Text.Trim.ToUpper & "', GoodsCha='" & Me.cbGoodsCode.Text & "', GoodsSpec='" & Me.txtGoodsSpec.Text & "', AMOUNT= " & iAmount & ", TotalNetWeight= " & fWeight & ", SIZE_MEASURE='" & Me.txtSize.Text.Trim & "', TIME_FROM='" & Me.dtpTimeBegin.Value & "', DESCR='" & Me.cbDescribe.Text & "', STATE='" & Me.cbState.Text & "',  CODE_CON_CONSIGN='" & Me.cbConsign.SelectedValue & "' where CHI_VESSEL='" & strShip & "' and Voyage='" & strVoyage & "' and BLNO='" & strBillNo & "'"
                            'End If
                            sqlUpdateBill = "update CON_LOAD_TALLY set CODE_TALLY_TYPE='" & Me.cbConLoadType.SelectedValue & "', MARK='" & Me.txtMark.Text.Trim.ToUpper & "', GoodsCha='" & Me.ccbGoods.Text & "', GoodsSpec='" & Me.txtGoodsSpec.Text & "', AMOUNT= " & iAmount & ", TotalNetWeight= " & fWeight & ", SIZE_MEASURE='" & Me.txtSize.Text.Trim & "', TIME_FROM='" & Me.dtpTimeBegin.Value & "', DESCR='" & Me.cbDescribe.Text & "', STATE='" & Me.cbState.Text & "',  CODE_CON_CONSIGN='" & Me.cbConsign.SelectedValue & "' where CHI_VESSEL='" & strShip & "' and Voyage='" & strVoyage & "' and BLNO='" & strBillNo & "' and Work_Place = '" & strYCode & "'"
                        End If
                    End If

                Else
                    cbConLoadType.Focus()
                    MessageBox.Show("请选择装箱类别", "提示")
                    Exit Sub
                End If
            Else
                cbConsign.Focus()
                MessageBox.Show("请选择委托单位", "提示")
                Exit Sub
            End If
        End If

        Try
            If i >= dvSubTable.Count And beSure = True Then    '全部通过检验
                Dim sqlIsBackUp As String      '判断是否已做过备份
                Dim dvIsBackUp As New DataView
                sqlIsBackUp = "select Con_Load_Tally_ID from CON_LOAD_TALLYtwo where Con_Load_Tally_ID =" & ID & ""
                dvIsBackUp = Filldata(sqlIsBackUp)
                If dvIsBackUp.Count = 0 Then    '未曾备份，现在备份
                    Dim sqlBackUpBill, sqlBackUpCon As String
                    sqlBackUpBill = "insert into CON_LOAD_TALLYtwo select * from CON_LOAD_TALLY where Con_Load_Tally_ID =" & ID & ""
                    sqlBackUpCon = "insert into CON_LOAD_TALLY_LISTtwo select * from CON_LOAD_TALLY_LIST where CHI_VESSEL = '" & strShip & "' AND Voyage = '" & strVoyage & "' AND BLNO = '" & strBillNo & "' and CodeYard = '" & strYCode & "'"
                    ExecSql(sqlBackUpBill)
                    ExecSql(sqlBackUpCon)
                End If

                '记录操作日志
                Call OperateHistory(G_DeptName, Now, G_User, "出证修改", "CON_LOAD_Tally", Trim(txtID.Text), "CON_LOAD_Tally_ID")
                ExecSql("Exec sp_ConLoadTallyListOperPre '" & G_DeptName & "','" & Now & "','" & G_User & "'")

                sqlSubTableda.Update(dsSubTable)
                ExecSql(sqlUpdateBill)
                EditMark = True

                strYCode = strNewYard   '为重复修改保存准备
                strShip = strNewShip
                strVoyage = strNewVoyage
                strBillNo = strNewBillNo

                Me.btnPrint.Enabled = True
                Me.btnSelectPrint.Enabled = True
                MessageBox.Show("修改成功！", "")
                Me.btnPrint.Focus()

                Me.txtShip.Enabled = False
                Me.txtVoyage.Enabled = False
                Me.txtBillNO.Enabled = False
                Me.txtMark.Enabled = False
                Me.txtGoodsSpec.Enabled = False
                Me.txtAmount.Enabled = False
                Me.txtTotalNetWeight.Enabled = False
                Me.txtSize.Enabled = False

                Me.cbPlace.Enabled = False
                Me.cbConLoadType.Enabled = False
                Me.ccbGoods.Enabled = False
                Me.cbConsign.Enabled = False
                Me.cbDescribe.Enabled = False
                Me.cbState.Enabled = False

                Me.dtpTimeBegin.Enabled = False

                Me.C1DBG.AllowUpdate = False

                Me.btEdit.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TrimGrid()
        Dim i As Integer
        Me.C1DBG.Focus()
        For i = 0 To dvSubTable.Count - 1
            Me.C1DBG.Row = i
            Me.C1DBG.Columns("CONTAINER_NO").Text = Me.C1DBG.Columns("CONTAINER_NO").Text.Trim().ToUpper
            Me.C1DBG.Columns("NEWSEALNO").Text = Me.C1DBG.Columns("NEWSEALNO").Text.Trim().ToUpper
            Me.C1DBG.Columns("CONTAINER_TYPE").Text = Me.C1DBG.Columns("CONTAINER_TYPE").Text.Trim().ToUpper
            Me.C1DBG.Columns("SecSealNO").Text = Me.C1DBG.Columns("SecSealNO").Text.Trim().ToUpper
            Me.C1DBG.Columns("ReasonOpenSeal").Text = Me.C1DBG.Columns("ReasonOpenSeal").Text.Trim()
            Me.C1DBG.Columns("DangerGrade").Text = Me.C1DBG.Columns("DangerGrade").Text.Trim()
            Me.C1DBG.Columns("DangerMark").Text = Me.C1DBG.Columns("DangerMark").Text.Trim()

            Me.C1DBG.Columns("CHI_VESSEL").Text = strNewShip
            Me.C1DBG.Columns("Voyage").Text = strNewVoyage
            Me.C1DBG.Columns("BLNO").Text = strNewBillNo
            Me.C1DBG.Columns("CodeYard").Text = strNewYard
        Next
        Me.btQuit.Focus()
    End Sub

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

    Private Function GetAutoNo(ByVal strYardValue As String) As String  '得到理货单编号，场站代码为参数
        Dim strAutoNo, sqlAutoNO, sqlUpdateYard As String
        Dim dvAutoNO As New DataView
        Dim iYear, iMaxNo As Integer
        strAutoNo = ""
        sqlAutoNO = "SELECT Code_Yard_ID, Code_Yard_Name, CodePrefix, CodeMax, CodeYear, DeptCode FROM Code_Yard where Code_Yard_ID = '" & strYardValue & "'"
        dvAutoNO = Filldata(sqlAutoNO)
        If dvAutoNO.Count > 0 Then
            iYear = dvAutoNO(0)("CodeYear")
            iMaxNo = dvAutoNO(0)("CodeMax")
            If iYear + 1 = Now.Year Then    '如果到了下一年 年份加一 编号重置
                iYear = Now.Year
                iMaxNo = 1         '是否可以有0编号？不要
            Else    '否则编号加一
                iMaxNo = iMaxNo + 1
            End If
            '及时更新场站代码表最值、年值 减少冲突
            sqlUpdateYard = "update Code_Yard set CodeMax='" & iMaxNo & "', CodeYear='" & iYear & "' where Code_Yard_ID='" & strYardValue & "'"
            ExecSql(sqlUpdateYard)
            '生成编号
            strAutoNo = String.Concat(dvAutoNO(0)("CodePrefix"), iYear.ToString, Microsoft.VisualBasic.Right(String.Concat("00000", iMaxNo.ToString), 6))
        End If
        Return strAutoNo
    End Function

    Private Sub txtShip_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtShip.Leave
        Me.txtShip.Text = Me.txtShip.Text.Trim.ToUpper
        If strShip.Equals(Me.txtShip.Text) = False Then
            strNewShip = Me.txtShip.Text
            sqlShipCode = "SELECT SPCODE, CHI_VESSEL FROM Code_SHIPNAME WHERE (SPCODE = '" & Me.txtShip.Text & "' or CHI_VESSEL = '" & Me.txtShip.Text & "')"
            dvShipCode = Filldata(sqlShipCode)
            txtShipName.Clear()
            If dvShipCode.Count > 0 Then
                Me.txtShip.Text = dvShipCode(0)("SPCODE")
                strNewShip = Me.txtShip.Text
                If Not IsDBNull(dvShipCode(0)("CHI_VESSEL")) Then
                    Me.txtShipName.Text = dvShipCode(0)("CHI_VESSEL")
                End If
                shipmark = True
            Else
                shipmark = False
                MessageBox.Show("船码 " & Me.txtShip.Text & " 不存在，请重新输入", "提示")
            End If
        End If

    End Sub

    Private Sub btnEditEnable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditEnable.Click
        Me.txtShip.Enabled = True
        Me.txtVoyage.Enabled = True
        Me.txtBillNO.Enabled = True
        Me.txtMark.Enabled = True
        Me.txtGoodsSpec.Enabled = True
        Me.txtAmount.Enabled = True
        Me.txtTotalNetWeight.Enabled = True
        Me.txtSize.Enabled = True

        Me.cbPlace.Enabled = True
        Me.cbConLoadType.Enabled = True
        Me.ccbGoods.Enabled = True
        Me.cbConsign.Enabled = True
        Me.cbDescribe.Enabled = True
        Me.cbState.Enabled = True

        Me.dtpTimeBegin.Enabled = True

        Me.C1DBG.AllowUpdate = True

        Me.btEdit.Enabled = True
        Me.btnPrint.Enabled = False
        Me.btnSelectPrint.Enabled = False
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub btnAddShipCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddShipCode.Click
        Dim FrmAddShipCode As New FrmShipName_Add   '***********要修改
        FrmAddShipCode.ShowDialog()
    End Sub

    Private Sub btnAddConsign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddConsign.Click
        Dim FrmAddConsign As New FrmShipAgent_Add    '***********要修改
        FrmAddConsign.ShowDialog()
        dvConsign = Filldata(sqlConsign)
        cbConsign.DataSource = dvConsign
        cbConsign.DisplayMember = "SHIPAGENT_SHORT"
        cbConsign.ValueMember = "CODE_SHIP_AGENT"
        Me.cbConsign.SelectedValue = strConsign
    End Sub

    Private Sub btnGetOg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetOg.Click
        If ds.Tables(0).Rows(0)("StateB") >= 2 Then
            Dim FrmBillOg As New FrmContainerOutPortog_Query
            FrmBillOg.Show()
        End If
    End Sub

    Private Sub MakeReportFile()
        On Error GoTo Err
        Dim sqlstr As String
        Dim strFile As String
        Dim txtline As String
        Dim ShipOwner As String
        Dim s As String
        Dim dss As New DataSet
        Dim dst As New DataSet
        Dim i As Integer = 0 '记录行数
        Dim j As Integer
        Dim k As Integer
        Dim nnnn As String

        Dim BLNO As String
        Dim PathStr As String
        Dim FilePath As String
        Dim BackUpFile As String
        Dim EDIPATH As String
        Dim FullOrEmpty As String
        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)

        FilePath = PathStr + "EDIINI.INI"
        Dim sr As New StreamReader(FilePath) '打开报文文件
        EDIPATH = sr.ReadLine()
        BackUpFile = sr.ReadLine()
        BackUpFile = sr.ReadLine()
        sr.Close()

        BLNO = txtBillNO.Text.Trim()
        If BLNO Like "*[#][#]" Then
            BLNO = BLNO.Substring(0, BLNO.Length - 2)

        End If
        sqlstr = "select Code_ShipOwner from SSHIP where ship_id=" & Ship_ID
        If Getdata(sqlstr, dss).Count > 0 Then
            If Not IsDBNull(dss.Tables(0).Rows(0).Item(0)) Then
                ShipOwner = Trim(dss.Tables(0).Rows(0).Item(0))
            Else
                ShipOwner = ""
            End If
        Else
            ShipOwner = ""
        End If

        strFile = EDIPATH & UCase(txtShip.Text) & UCase(txtVoyage.Text) & Trim(CType(Year(Now), String)) & Trim(CType(Month(Now), String)) & Trim(CType(Day(Now), String)) & Trim(CType(Hour(Now), String)) & Trim(CType(Minute(Now), String)) & ".txt"
        File.Delete(strFile)
        Dim sw As New StreamWriter(strFile, FileMode.OpenOrCreate, System.Text.Encoding.ASCII()) '打开报文文件
        '********************************00
        txtline = "00:WLCOST:WL CONTAINER LOADING LIST:9:LYGWL:LYGHG:" & Trim(CType(Year(Now), String))
        s = Mid("0" & Trim(CType(Month(Now), String)), Len("0" & Trim(CType(Month(Now), String))) - 1, 2)
        txtline = txtline & s
        s = Mid("0" & Trim(CType(Day(Now), String)), Len("0" & Trim(CType(Day(Now), String))) - 1, 2)
        txtline = txtline & s
        s = Mid("0" & Trim(CType(Hour(Now), String)), Len("0" & Trim(CType(Hour(Now), String))) - 1, 2)
        txtline = txtline & s
        s = Mid("0" & Trim(CType(Minute(Now), String)), Len("0" & Trim(CType(Minute(Now), String))) - 1, 2)
        txtline = txtline & s & "'"
        sw.WriteLine(txtline)
        '*******************************10
        txtline = "10:" & UCase(txtShip.Text) & "::" & UCase(txtVoyage.Text) & ":" & ShipOwner & ":::'"
        sw.WriteLine(txtline)
        i = 2
        j = 1
        '*******************************50
        sqlstr = "select DISTINCT CONTAINER_NO,SIZE_CON,CONTAINER_TYPE,Code_Tally_Type,CodeYard,Code_Yard_Name,TIME_FROM,NEWSEALNO  from VIEW_CONLOADTALLYLXJ where ShipName='" & txtShipName.Text.Trim() & "' and  Voyage='" & txtVoyage.Text & "' and BLNO='" & txtBillNO.Text.Trim() & "' order by CONTAINER_NO"
        dss.Reset()
        If Getdata(sqlstr, dss).Count > 0 Then
            nnnn = ""
            Do While j <= dss.Tables(0).Rows.Count
                If Trim(dss.Tables(0).Rows(j - 1).Item("CONTAINER_NO")) <> nnnn Then
                    txtline = "50:" & Trim(dss.Tables(0).Rows(j - 1).Item("CONTAINER_NO")) & ":"
                    txtline = txtline & Trim(dss.Tables(0).Rows(j - 1).Item("SIZE_CON"))
                    txtline = txtline & Trim(dss.Tables(0).Rows(j - 1).Item("CONTAINER_TYPE"))
                    If (Trim(dss.Tables(0).Rows(j - 1).Item("Code_Tally_Type")) = "1") Then
                        FullOrEmpty = "F"
                    ElseIf (Trim(dss.Tables(0).Rows(j - 1).Item("Code_Tally_Type")) = "2") Then
                        FullOrEmpty = "L"
                    Else
                        FullOrEmpty = "F"
                    End If
                    txtline = txtline & ":" & FullOrEmpty & ":0"
                    txtline = txtline & ":" & Trim(dss.Tables(0).Rows(j - 1).Item("CodeYard")) & ":" & Trim(dss.Tables(0).Rows(j - 1).Item("Code_Yard_Name")) & ":"
                    txtline = txtline & Trim(CType(Year(dss.Tables(0).Rows(j - 1).Item("TIME_FROM")), String))
                    s = Mid("0" & Trim(CType(Month(dss.Tables(0).Rows(j - 1).Item("TIME_FROM")), String)), Len("0" & Trim(CType(Month(dss.Tables(0).Rows(j - 1).Item("TIME_FROM")), String))) - 1, 2)
                    txtline = txtline & s
                    s = Mid("0" & Trim(CType(Day(dss.Tables(0).Rows(j - 1).Item("TIME_FROM")), String)), Len("0" & Trim(CType(Day(dss.Tables(0).Rows(j - 1).Item("TIME_FROM")), String))) - 1, 2)
                    txtline = txtline & s
                    s = Mid("0" & Trim(CType(Hour(dss.Tables(0).Rows(j - 1).Item("TIME_FROM")), String)), Len("0" & Trim(CType(Hour(dss.Tables(0).Rows(j - 1).Item("TIME_FROM")), String))) - 1, 2)
                    txtline = txtline & s
                    s = Mid("0" & Trim(CType(Minute(dss.Tables(0).Rows(j - 1).Item("TIME_FROM")), String)), Len("0" & Trim(CType(Minute(dss.Tables(0).Rows(j - 1).Item("TIME_FROM")), String))) - 1, 2)
                    txtline = txtline & s
                    txtline = txtline & ":" & Trim(dss.Tables(0).Rows(j - 1).Item("NEWSEALNO")) & ":"
                    txtline = txtline & ":"
                    txtline = txtline & "::::::'"
                    sw.WriteLine(txtline)
                    i = i + 1
                    nnnn = Trim(dss.Tables(0).Rows(j - 1).Item("CONTAINER_NO"))
                End If
                j = j + 1
            Loop
        End If

        '***************************** 提单循环
        sqlstr = "select DISTINCT BLNO,AMOUNT,PACK_CHA,TotalNetWeight,SIZE_MEASURE,GOODSCHA,TEMPUnit,MARK,DANGERGRADE,DANGERMARK,CODELOADPORT,CODEUNLOADPORT,CODEDELIVERY, ReeferTemp  from VIEW_CONLOADTALLYLXJ where ShipName='" & txtShipName.Text.Trim() & "' and  Voyage='" & txtVoyage.Text & "' and BLNO='" & txtBillNO.Text.Trim() & "'"
        dss.Reset()
        If Getdata(sqlstr, dss).Count > 0 Then
            j = 1
            Do While j <= dss.Tables(0).Rows.Count
                '************************************51
                txtline = "51:" & BLNO & ":"
                If (Trim(dss.Tables(0).Rows(j - 1).Item("CODEUNLOADPORT")).Length > 0) Then
                    txtline = txtline & Trim(dss.Tables(0).Rows(j - 1).Item("CODEUNLOADPORT")) & ":" & FindPort(Trim(dss.Tables(0).Rows(j - 1).Item("CODEUNLOADPORT"))) & ":"
                Else
                    txtline = txtline & "::"
                End If
                If (Trim(dss.Tables(0).Rows(j - 1).Item("CODELOADPORT")).Length > 0) Then
                    txtline = txtline & Trim(dss.Tables(0).Rows(j - 1).Item("CODELOADPORT")) & ":" & FindPort(Trim(dss.Tables(0).Rows(j - 1).Item("CODELOADPORT"))) & ":"
                Else
                    txtline = txtline & "::"
                End If
                txtline = txtline & "::"
                If (Trim(dss.Tables(0).Rows(j - 1).Item("CODEDELIVERY")).Length > 0) Then
                    txtline = txtline & Trim(dss.Tables(0).Rows(j - 1).Item("CODEDELIVERY")) & ":" & FindPort(Trim(dss.Tables(0).Rows(j - 1).Item("CODEDELIVERY"))) & ""
                Else
                    txtline = txtline & ":"
                End If
                txtline = txtline & "'"
                sw.WriteLine(txtline)
                i = i + 1
                '************************************52
                txtline = "52:1:"
                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("AMOUNT")) Then
                    If Trim(dss.Tables(0).Rows(j - 1).Item("AMOUNT")).Length() > 0 Then
                        txtline = txtline & Trim(CType(dss.Tables(0).Rows(j - 1).Item("AMOUNT"), Single).ToString()) & ":"
                    Else
                        txtline = txtline & ":"
                    End If
                Else
                    txtline = txtline & ":"
                End If
                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("PACK_CHA")) Then
                    If Trim(dss.Tables(0).Rows(j - 1).Item("PACK_CHA")).Length() > 0 Then
                        txtline = txtline & Trim(CType(dss.Tables(0).Rows(j - 1).Item("PACK_CHA"), Single).ToString()) & ":"
                    Else
                        txtline = txtline & ":"
                    End If
                Else
                    txtline = txtline & ":"
                End If

                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("TotalNetWeight")) Then
                    If Trim(dss.Tables(0).Rows(j - 1).Item("TotalNetWeight")).Length() > 0 Then
                        txtline = txtline & Trim(CType(dss.Tables(0).Rows(j - 1).Item("TotalNetWeight"), Single).ToString()) & ":"
                    Else
                        txtline = txtline & ":"
                    End If
                Else
                    txtline = txtline & ":"
                End If
                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("SIZE_MEASURE")) Then
                    If Trim(dss.Tables(0).Rows(j - 1).Item("SIZE_MEASURE")).Length() > 0 Then
                        txtline = txtline & Trim(CType(dss.Tables(0).Rows(j - 1).Item("SIZE_MEASURE"), Single).ToString()) & ":"
                    Else
                        txtline = txtline & ":"
                    End If
                Else
                    txtline = txtline & ":"
                End If

                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("TEMPUnit")) Then
                    If Trim(dss.Tables(0).Rows(j - 1).Item("TEMPUnit")).Length() > 0 Then
                        'If dss.Tables(0).Rows(j - 1).Item("Refrigerate_Temperature") <> 0 Then
                        '要零上温度加正号
                        Dim strTemp As String
                        strTemp = dss.Tables(0).Rows(j - 1).Item("ReeferTemp")
                        If strTemp Like "#*" Then
                            strTemp = "+" & strTemp
                        End If
                        txtline = txtline & "C:" & strTemp & "::'"
                        'txtline = txtline & "C:" & Trim(CType(dss.Tables(0).Rows(j - 1).Item("Refrigerate_Temperature"), Single).ToString()) & "::'"
                    Else
                        txtline = txtline & ":::'"
                    End If
                Else
                    txtline = txtline & ":::'"
                End If
                sw.WriteLine(txtline)
                i = i + 1
                '************************************53
                txtline = "53:" & Trim(dss.Tables(0).Rows(j - 1).Item("GOODSCHA")) & "'"
                sw.WriteLine(txtline)
                i = i + 1
                '************************************54
                txtline = "54:" & Trim(dss.Tables(0).Rows(j - 1).Item("MARK")) & "'"
                sw.WriteLine(txtline)
                i = i + 1
                '************************************55
                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("DANGERGRADE")) Then
                    If Trim(dss.Tables(0).Rows(j - 1).Item("DANGERGRADE")).Length() > 0 Then
                        txtline = "55:" & Trim(dss.Tables(0).Rows(j - 1).Item("DANGERGRADE")) & ":"
                        txtline = txtline & ":"
                        txtline = txtline & ":"
                        txtline = txtline & Trim(dss.Tables(0).Rows(j - 1).Item("DANGERMARK")) & "::::'"
                        sw.WriteLine(txtline)
                        i = i + 1
                    End If
                End If

                '************************************56
                dst.Reset()
                sqlstr = "select CONTAINER_NO,SIZE_CON,CONAMOUNT,NETWEIGHT,VOLUME from VIEW_CONLOADTALLYLXJ where ShipName='" & txtShipName.Text.Trim() & "' and  Voyage='" & txtVoyage.Text & "' and BLNO='" & txtBillNO.Text.Trim() & "' order by CONTAINER_NO"
                If Getdata(sqlstr, dst).Count > 0 Then
                    k = 1
                    Do While k <= dst.Tables(0).Rows.Count
                        txtline = "56:" & Trim(dst.Tables(0).Rows(k - 1).Item("CONTAINER_NO")) & ":"
                        If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("CONAMOUNT")) Then
                            If Trim(dss.Tables(0).Rows(j - 1).Item("CONAMOUNT")).Length() > 0 Then
                                txtline = txtline & Trim(dst.Tables(0).Rows(k - 1).Item("CONAMOUNT")) & ":"
                            Else
                                txtline = txtline & ":"
                            End If
                        Else
                            txtline = txtline & ":"
                        End If
                        If Trim(dst.Tables(0).Rows(k - 1).Item("SIZE_CON")) = "20" Then
                            txtline = txtline & "2300:" '***************皮重
                        ElseIf Trim(dst.Tables(0).Rows(k - 1).Item("SIZE_CON")) = "40" Then
                            txtline = txtline & "3800:" '***************皮重
                        ElseIf Trim(dst.Tables(0).Rows(k - 1).Item("SIZE_CON")) = "45" Then
                            txtline = txtline & "4700:" '***************皮重
                        Else
                            txtline = txtline & ":"
                        End If
                        If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("NETWEIGHT")) Then
                            If Trim(dss.Tables(0).Rows(j - 1).Item("NETWEIGHT")).Length() > 0 Then
                                txtline = txtline & Trim(CType(dst.Tables(0).Rows(k - 1).Item("NETWEIGHT"), Single).ToString()) & ":"
                            Else
                                txtline = txtline & ":"
                            End If
                        Else
                            txtline = txtline & ":"
                        End If

                        'If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("VOLUME")) Then
                        '    If Trim(dss.Tables(0).Rows(j - 1).Item("VOLUME")).Length() > 0 Then
                        '        txtline = txtline & Trim(CType(dst.Tables(0).Rows(k - 1).Item("VOLUME"), Single).ToString()) & "'"
                        '    Else
                        '        txtline = txtline & "'"
                        '    End If
                        'Else
                        '    txtline = txtline & "'"
                        'End If
                        If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("VOLUME")) Then
                            If Trim(dss.Tables(0).Rows(j - 1).Item("VOLUME")).Length() > 0 Then
                                txtline = txtline & Trim(CType(dst.Tables(0).Rows(k - 1).Item("VOLUME"), Single).ToString())
                            Else
                                txtline = txtline
                            End If
                        Else
                            txtline = txtline
                        End If
                        txtline = txtline & "'"
                        sw.WriteLine(txtline)
                        i = i + 1
                        k = k + 1
                    Loop
                End If

                j = j + 1
            Loop

        End If
        txtline = "99:" & i + 1 & "'"
        sw.WriteLine(txtline)

        sw.Close()
        Exit Sub
Err:
        'MsgBox("报文生成出错在：" & Trim(dss.Tables(0).Rows(j - 1).Item("CONTAINER_NO")))
        Resume Next
    End Sub
    Private Function FindPort(ByVal Port As String) As String
        On Error GoTo Err
        Dim dsPort As New DataSet
        Dim dwPort As New DataView
        Dim str As String
        str = "select * from Code_Port where Code_Port='" & Port & "'"
        dsPort.Reset()
        dwPort = Getdata(str, dsPort)
        If dwPort.Count > 0 Then
            FindPort = dsPort.Tables(0).Rows(0).Item("PORT_ENG")
        Else
            FindPort = Port
        End If
        Exit Function
Err:
        FindPort = Port
    End Function

    Private Sub cbConLoadType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbConLoadType.SelectedValueChanged
        If Not dvSubTable Is Nothing Then
            If Me.cbConLoadType.SelectedValue = "9" Then
                Me.C1DBG.Columns.Item("ReasonOpenSeal").Caption = "车号"
            Else
                Me.C1DBG.Columns.Item("ReasonOpenSeal").Caption = "开封原因"
            End If
        End If
        
    End Sub
End Class
