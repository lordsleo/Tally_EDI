Imports TALLY.DBControl
Imports System.Web.Mail
Imports System.IO
Imports Microsoft.VisualBasic
Public Class FrmConLoadTallyNew_Edit
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        AddHandler txtNO.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler txtTallyClerk.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler txtMark.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler ccbGoods.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler txtGoodsSpec.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler txtAmount.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler txtTotalNetWeight.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler txtSize.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler cbState.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler ccbConsign.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler cbInOutPort.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler cbLoadPort.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler cbUnloadPort.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler cbWorkType.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler cbConLoadType.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler dtpTimeBegin.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler dtpListDate.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler ckbInTrade.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler txtNewShip.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler txtNewShipName.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler txtNewVoyage.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown
        AddHandler txtNewBill.KeyDown, AddressOf FrmConLoadTallyNew_Add_KeyDown

        AddHandler txtNewBill.Leave, AddressOf FrmConLoadTallyNew_Edit_Leave
        AddHandler txtNewBill.Leave, AddressOf FrmConLoadTallyNew_Edit_Leave
        AddHandler txtNewBill.Leave, AddressOf FrmConLoadTallyNew_Edit_Leave
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
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnConDelete As System.Windows.Forms.Button
    Friend WithEvents labShipName As System.Windows.Forms.Label
    Friend WithEvents txtTallyClerk As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtMark As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNO As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtGoodsSpec As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cbState As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtTotalNetWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtSize As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cbInOutPort As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbUnloadPort As System.Windows.Forms.ComboBox
    Friend WithEvents cbLoadPort As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents cbWorkType As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cbConLoadType As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpListDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNewShipName As System.Windows.Forms.TextBox
    Friend WithEvents txtNewVoyage As System.Windows.Forms.TextBox
    Friend WithEvents txtNewBill As System.Windows.Forms.TextBox
    Friend WithEvents txtNewShip As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents ccbConsign As C1.Win.C1List.C1Combo
    Friend WithEvents ccbGoods As C1.Win.C1List.C1Combo
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ckbInTrade As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOldShipName As System.Windows.Forms.TextBox
    Friend WithEvents txtOldBlno As System.Windows.Forms.TextBox
    Friend WithEvents txtOldShip As System.Windows.Forms.TextBox
    Friend WithEvents txtOldVoyage As System.Windows.Forms.TextBox
    Friend WithEvents cbPlace As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtShip As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rbnDetailed As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents rbnUsual As System.Windows.Forms.RadioButton
    Friend WithEvents txtBillNO As System.Windows.Forms.TextBox
    Friend WithEvents btnGetData As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnExportEdit As System.Windows.Forms.Button
    Friend WithEvents btnExportSave As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConLoadTallyNew_Edit))
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btnConDelete = New System.Windows.Forms.Button
        Me.labShipName = New System.Windows.Forms.Label
        Me.txtTallyClerk = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtMark = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtNO = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtGoodsSpec = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.cbState = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtTotalNetWeight = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtSize = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.cbInOutPort = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cbUnloadPort = New System.Windows.Forms.ComboBox
        Me.cbLoadPort = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.cbWorkType = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.cbConLoadType = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpListDate = New System.Windows.Forms.DateTimePicker
        Me.Label14 = New System.Windows.Forms.Label
        Me.dtpTimeBegin = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtNewShipName = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtNewVoyage = New System.Windows.Forms.TextBox
        Me.txtNewBill = New System.Windows.Forms.TextBox
        Me.txtNewShip = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.dtpTimeEnd = New System.Windows.Forms.DateTimePicker
        Me.Label26 = New System.Windows.Forms.Label
        Me.ccbConsign = New C1.Win.C1List.C1Combo
        Me.ccbGoods = New C1.Win.C1List.C1Combo
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ckbInTrade = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtOldShipName = New System.Windows.Forms.TextBox
        Me.txtOldBlno = New System.Windows.Forms.TextBox
        Me.txtOldShip = New System.Windows.Forms.TextBox
        Me.txtOldVoyage = New System.Windows.Forms.TextBox
        Me.cbPlace = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtShip = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.rbnDetailed = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.rbnUsual = New System.Windows.Forms.RadioButton
        Me.txtBillNO = New System.Windows.Forms.TextBox
        Me.btnGetData = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnExportEdit = New System.Windows.Forms.Button
        Me.btnExportSave = New System.Windows.Forms.Button
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccbConsign, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccbGoods, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btQuit.Location = New System.Drawing.Point(700, 528)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 21
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btSave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btSave.Font = New System.Drawing.Font("新宋体", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btSave.Location = New System.Drawing.Point(380, 528)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 20
        Me.btSave.Text = "确认"
        '
        'C1DBG
        '
        Me.C1DBG.AllowAddNew = True
        Me.C1DBG.AllowDelete = True
        Me.C1DBG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("C1DBG.Images"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(2, 242)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.PageSettings = CType(resources.GetObject("C1DBG.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBG.RowHeight = 18
        Me.C1DBG.Size = New System.Drawing.Size(856, 282)
        Me.C1DBG.TabIndex = 18
        Me.C1DBG.PropBag = resources.GetString("C1DBG.PropBag")
        '
        'btnConDelete
        '
        Me.btnConDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnConDelete.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnConDelete.Location = New System.Drawing.Point(190, 530)
        Me.btnConDelete.Name = "btnConDelete"
        Me.btnConDelete.Size = New System.Drawing.Size(65, 24)
        Me.btnConDelete.TabIndex = 19
        Me.btnConDelete.Text = "箱删除"
        '
        'labShipName
        '
        Me.labShipName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labShipName.BackColor = System.Drawing.Color.Lavender
        Me.labShipName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labShipName.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.labShipName.Location = New System.Drawing.Point(0, 530)
        Me.labShipName.Name = "labShipName"
        Me.labShipName.Size = New System.Drawing.Size(188, 23)
        Me.labShipName.TabIndex = 341
        Me.labShipName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTallyClerk
        '
        Me.txtTallyClerk.Location = New System.Drawing.Point(636, 520)
        Me.txtTallyClerk.MaxLength = 10
        Me.txtTallyClerk.Name = "txtTallyClerk"
        Me.txtTallyClerk.Size = New System.Drawing.Size(130, 22)
        Me.txtTallyClerk.TabIndex = 7
        Me.txtTallyClerk.Visible = False
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(562, 522)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 18)
        Me.Label15.TabIndex = 648
        Me.Label15.Text = "理货员"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label15.Visible = False
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(86, 134)
        Me.txtMark.MaxLength = 20
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(130, 22)
        Me.txtMark.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(12, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 646
        Me.Label9.Text = "标志"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNO
        '
        Me.txtNO.Location = New System.Drawing.Point(86, 108)
        Me.txtNO.MaxLength = 20
        Me.txtNO.Name = "txtNO"
        Me.txtNO.ReadOnly = True
        Me.txtNO.Size = New System.Drawing.Size(130, 22)
        Me.txtNO.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 18)
        Me.Label5.TabIndex = 644
        Me.Label5.Text = "理货单编号"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGoodsSpec
        '
        Me.txtGoodsSpec.Location = New System.Drawing.Point(86, 186)
        Me.txtGoodsSpec.MaxLength = 50
        Me.txtGoodsSpec.Name = "txtGoodsSpec"
        Me.txtGoodsSpec.Size = New System.Drawing.Size(130, 22)
        Me.txtGoodsSpec.TabIndex = 10
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(12, 186)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(72, 18)
        Me.Label37.TabIndex = 652
        Me.Label37.Text = "规格"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(12, 162)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 18)
        Me.Label17.TabIndex = 650
        Me.Label17.Text = "货名"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(434, 110)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 18)
        Me.Label22.TabIndex = 664
        Me.Label22.Text = "委托单位"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbState
        '
        Me.cbState.Items.AddRange(New Object() {"", "全已装箱", "部分装箱", "拆箱"})
        Me.cbState.Location = New System.Drawing.Point(296, 186)
        Me.cbState.MaxDropDownItems = 20
        Me.cbState.Name = "cbState"
        Me.cbState.Size = New System.Drawing.Size(130, 21)
        Me.cbState.TabIndex = 16
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(222, 188)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 18)
        Me.Label21.TabIndex = 663
        Me.Label21.Text = "货物处于"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(396, 136)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(49, 20)
        Me.Label28.TabIndex = 660
        Me.Label28.Text = "公斤"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalNetWeight
        '
        Me.txtTotalNetWeight.Location = New System.Drawing.Point(296, 134)
        Me.txtTotalNetWeight.MaxLength = 10
        Me.txtTotalNetWeight.Name = "txtTotalNetWeight"
        Me.txtTotalNetWeight.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalNetWeight.TabIndex = 14
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(222, 136)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 18)
        Me.Label29.TabIndex = 659
        Me.Label29.Text = "总货重"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(396, 160)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 22)
        Me.Label13.TabIndex = 658
        Me.Label13.Text = "立方"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(296, 160)
        Me.txtSize.MaxLength = 10
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(100, 22)
        Me.txtSize.TabIndex = 15
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(222, 162)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 18)
        Me.Label19.TabIndex = 657
        Me.Label19.Text = "总尺码"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(296, 108)
        Me.txtAmount.MaxLength = 10
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(130, 22)
        Me.txtAmount.TabIndex = 13
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(222, 110)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 18)
        Me.Label25.TabIndex = 656
        Me.Label25.Text = "总件数"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbInOutPort
        '
        Me.cbInOutPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbInOutPort.Location = New System.Drawing.Point(508, 134)
        Me.cbInOutPort.MaxDropDownItems = 20
        Me.cbInOutPort.Name = "cbInOutPort"
        Me.cbInOutPort.Size = New System.Drawing.Size(130, 21)
        Me.cbInOutPort.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(434, 136)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 18)
        Me.Label12.TabIndex = 674
        Me.Label12.Text = "进出口"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbUnloadPort
        '
        Me.cbUnloadPort.Location = New System.Drawing.Point(508, 186)
        Me.cbUnloadPort.MaxDropDownItems = 20
        Me.cbUnloadPort.Name = "cbUnloadPort"
        Me.cbUnloadPort.Size = New System.Drawing.Size(130, 21)
        Me.cbUnloadPort.TabIndex = 4
        '
        'cbLoadPort
        '
        Me.cbLoadPort.Location = New System.Drawing.Point(508, 160)
        Me.cbLoadPort.MaxDropDownItems = 20
        Me.cbLoadPort.Name = "cbLoadPort"
        Me.cbLoadPort.Size = New System.Drawing.Size(130, 21)
        Me.cbLoadPort.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(434, 162)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 18)
        Me.Label11.TabIndex = 673
        Me.Label11.Text = "装货港"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(434, 188)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(72, 18)
        Me.Label32.TabIndex = 672
        Me.Label32.Text = "卸货港"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbWorkType
        '
        Me.cbWorkType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbWorkType.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbWorkType.Location = New System.Drawing.Point(720, 108)
        Me.cbWorkType.Name = "cbWorkType"
        Me.cbWorkType.Size = New System.Drawing.Size(130, 21)
        Me.cbWorkType.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(646, 110)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 18)
        Me.Label18.TabIndex = 671
        Me.Label18.Text = "工作类别"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbConLoadType
        '
        Me.cbConLoadType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConLoadType.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbConLoadType.Location = New System.Drawing.Point(720, 134)
        Me.cbConLoadType.MaxDropDownItems = 20
        Me.cbConLoadType.Name = "cbConLoadType"
        Me.cbConLoadType.Size = New System.Drawing.Size(130, 21)
        Me.cbConLoadType.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(646, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 670
        Me.Label6.Text = "折装箱类别"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpListDate
        '
        Me.dtpListDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpListDate.Location = New System.Drawing.Point(720, 212)
        Me.dtpListDate.Name = "dtpListDate"
        Me.dtpListDate.Size = New System.Drawing.Size(130, 22)
        Me.dtpListDate.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(646, 214)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 18)
        Me.Label14.TabIndex = 678
        Me.Label14.Text = "制单日期"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeBegin
        '
        Me.dtpTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeBegin.Location = New System.Drawing.Point(720, 160)
        Me.dtpTimeBegin.Name = "dtpTimeBegin"
        Me.dtpTimeBegin.Size = New System.Drawing.Size(130, 22)
        Me.dtpTimeBegin.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(646, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 676
        Me.Label7.Text = "开始时间"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("新宋体", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Location = New System.Drawing.Point(574, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 18)
        Me.Label10.TabIndex = 687
        Me.Label10.Text = "提单号"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("新宋体", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label16.Location = New System.Drawing.Point(44, 78)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 18)
        Me.Label16.TabIndex = 684
        Me.Label16.Text = "船码"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNewShipName
        '
        Me.txtNewShipName.BackColor = System.Drawing.Color.Lavender
        Me.txtNewShipName.Font = New System.Drawing.Font("新宋体", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.txtNewShipName.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtNewShipName.Location = New System.Drawing.Point(228, 76)
        Me.txtNewShipName.MaxLength = 40
        Me.txtNewShipName.Name = "txtNewShipName"
        Me.txtNewShipName.ReadOnly = True
        Me.txtNewShipName.Size = New System.Drawing.Size(180, 22)
        Me.txtNewShipName.TabIndex = 681
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("新宋体", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label20.Location = New System.Drawing.Point(414, 78)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(54, 18)
        Me.Label20.TabIndex = 685
        Me.Label20.Text = "航次"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("新宋体", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label23.Location = New System.Drawing.Point(190, 78)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(38, 18)
        Me.Label23.TabIndex = 686
        Me.Label23.Text = "船名"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNewVoyage
        '
        Me.txtNewVoyage.Font = New System.Drawing.Font("新宋体", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.txtNewVoyage.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtNewVoyage.Location = New System.Drawing.Point(468, 76)
        Me.txtNewVoyage.MaxLength = 6
        Me.txtNewVoyage.Name = "txtNewVoyage"
        Me.txtNewVoyage.Size = New System.Drawing.Size(100, 22)
        Me.txtNewVoyage.TabIndex = 682
        '
        'txtNewBill
        '
        Me.txtNewBill.Font = New System.Drawing.Font("新宋体", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.txtNewBill.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtNewBill.Location = New System.Drawing.Point(628, 76)
        Me.txtNewBill.MaxLength = 120
        Me.txtNewBill.Name = "txtNewBill"
        Me.txtNewBill.Size = New System.Drawing.Size(150, 22)
        Me.txtNewBill.TabIndex = 683
        '
        'txtNewShip
        '
        Me.txtNewShip.Font = New System.Drawing.Font("新宋体", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.txtNewShip.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtNewShip.Location = New System.Drawing.Point(86, 76)
        Me.txtNewShip.MaxLength = 40
        Me.txtNewShip.Name = "txtNewShip"
        Me.txtNewShip.Size = New System.Drawing.Size(100, 22)
        Me.txtNewShip.TabIndex = 680
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(2, 102)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(856, 3)
        Me.GroupBox3.TabIndex = 688
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("新宋体", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(134, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(6, 78)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(39, 18)
        Me.Label24.TabIndex = 689
        Me.Label24.Text = "修改"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpTimeEnd
        '
        Me.dtpTimeEnd.Enabled = False
        Me.dtpTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTimeEnd.Location = New System.Drawing.Point(720, 186)
        Me.dtpTimeEnd.Name = "dtpTimeEnd"
        Me.dtpTimeEnd.Size = New System.Drawing.Size(130, 22)
        Me.dtpTimeEnd.TabIndex = 690
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(646, 188)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 18)
        Me.Label26.TabIndex = 691
        Me.Label26.Text = "结束时间"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ccbConsign
        '
        Me.ccbConsign.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.ccbConsign.AutoDropDown = True
        Me.ccbConsign.Caption = ""
        Me.ccbConsign.CaptionHeight = 17
        Me.ccbConsign.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ccbConsign.ColumnCaptionHeight = 18
        Me.ccbConsign.ColumnFooterHeight = 18
        Me.ccbConsign.ContentHeight = 18
        Me.ccbConsign.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.ccbConsign.EditorBackColor = System.Drawing.SystemColors.Window
        Me.ccbConsign.EditorFont = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ccbConsign.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.ccbConsign.EditorHeight = 18
        Me.ccbConsign.Images.Add(CType(resources.GetObject("ccbConsign.Images"), System.Drawing.Image))
        Me.ccbConsign.ItemHeight = 15
        Me.ccbConsign.Location = New System.Drawing.Point(508, 108)
        Me.ccbConsign.MatchEntryTimeout = CType(2000, Long)
        Me.ccbConsign.MaxDropDownItems = CType(20, Short)
        Me.ccbConsign.MaxLength = 32767
        Me.ccbConsign.MouseCursor = System.Windows.Forms.Cursors.Hand
        Me.ccbConsign.Name = "ccbConsign"
        Me.ccbConsign.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.ccbConsign.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.ccbConsign.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.ccbConsign.Size = New System.Drawing.Size(130, 24)
        Me.ccbConsign.TabIndex = 693
        Me.ccbConsign.PropBag = resources.GetString("ccbConsign.PropBag")
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
        Me.ccbGoods.ContentHeight = 18
        Me.ccbGoods.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.ccbGoods.EditorBackColor = System.Drawing.SystemColors.Window
        Me.ccbGoods.EditorFont = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ccbGoods.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.ccbGoods.EditorHeight = 18
        Me.ccbGoods.Images.Add(CType(resources.GetObject("ccbGoods.Images"), System.Drawing.Image))
        Me.ccbGoods.ItemHeight = 15
        Me.ccbGoods.Location = New System.Drawing.Point(86, 160)
        Me.ccbGoods.MatchEntryTimeout = CType(2000, Long)
        Me.ccbGoods.MaxDropDownItems = CType(20, Short)
        Me.ccbGoods.MaxLength = 32767
        Me.ccbGoods.MouseCursor = System.Windows.Forms.Cursors.Hand
        Me.ccbGoods.Name = "ccbGoods"
        Me.ccbGoods.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.ccbGoods.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.ccbGoods.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.ccbGoods.Size = New System.Drawing.Size(130, 24)
        Me.ccbGoods.TabIndex = 692
        Me.ccbGoods.PropBag = resources.GetString("ccbGoods.PropBag")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ckbInTrade)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(12, 208)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(228, 34)
        Me.GroupBox2.TabIndex = 694
        Me.GroupBox2.TabStop = False
        '
        'ckbInTrade
        '
        Me.ckbInTrade.Location = New System.Drawing.Point(8, 12)
        Me.ckbInTrade.Name = "ckbInTrade"
        Me.ckbInTrade.Size = New System.Drawing.Size(212, 20)
        Me.ckbInTrade.TabIndex = 0
        Me.ckbInTrade.Text = "内贸箱或不需出证箱请勾选"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtOldShipName)
        Me.GroupBox1.Controls.Add(Me.txtOldBlno)
        Me.GroupBox1.Controls.Add(Me.txtOldShip)
        Me.GroupBox1.Controls.Add(Me.txtOldVoyage)
        Me.GroupBox1.Controls.Add(Me.cbPlace)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtVoyage)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtShip)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.rbnDetailed)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtShipName)
        Me.GroupBox1.Controls.Add(Me.rbnUsual)
        Me.GroupBox1.Controls.Add(Me.txtBillNO)
        Me.GroupBox1.Controls.Add(Me.btnGetData)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(854, 70)
        Me.GroupBox1.TabIndex = 695
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查找"
        '
        'txtOldShipName
        '
        Me.txtOldShipName.BackColor = System.Drawing.Color.Lavender
        Me.txtOldShipName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOldShipName.Location = New System.Drawing.Point(730, 22)
        Me.txtOldShipName.MaxLength = 40
        Me.txtOldShipName.Name = "txtOldShipName"
        Me.txtOldShipName.ReadOnly = True
        Me.txtOldShipName.Size = New System.Drawing.Size(116, 15)
        Me.txtOldShipName.TabIndex = 644
        '
        'txtOldBlno
        '
        Me.txtOldBlno.BackColor = System.Drawing.Color.Lavender
        Me.txtOldBlno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOldBlno.Location = New System.Drawing.Point(730, 46)
        Me.txtOldBlno.MaxLength = 40
        Me.txtOldBlno.Name = "txtOldBlno"
        Me.txtOldBlno.ReadOnly = True
        Me.txtOldBlno.Size = New System.Drawing.Size(116, 15)
        Me.txtOldBlno.TabIndex = 643
        '
        'txtOldShip
        '
        Me.txtOldShip.BackColor = System.Drawing.Color.Lavender
        Me.txtOldShip.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOldShip.Location = New System.Drawing.Point(642, 22)
        Me.txtOldShip.MaxLength = 40
        Me.txtOldShip.Name = "txtOldShip"
        Me.txtOldShip.ReadOnly = True
        Me.txtOldShip.Size = New System.Drawing.Size(86, 15)
        Me.txtOldShip.TabIndex = 642
        '
        'txtOldVoyage
        '
        Me.txtOldVoyage.BackColor = System.Drawing.Color.Lavender
        Me.txtOldVoyage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOldVoyage.Location = New System.Drawing.Point(642, 46)
        Me.txtOldVoyage.MaxLength = 40
        Me.txtOldVoyage.Name = "txtOldVoyage"
        Me.txtOldVoyage.ReadOnly = True
        Me.txtOldVoyage.Size = New System.Drawing.Size(86, 15)
        Me.txtOldVoyage.TabIndex = 641
        '
        'cbPlace
        '
        Me.cbPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlace.Location = New System.Drawing.Point(342, 42)
        Me.cbPlace.Name = "cbPlace"
        Me.cbPlace.Size = New System.Drawing.Size(138, 21)
        Me.cbPlace.TabIndex = 484
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(284, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 487
        Me.Label8.Text = "工作地点"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(178, 18)
        Me.txtVoyage.MaxLength = 6
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(100, 22)
        Me.txtVoyage.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(146, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 308
        Me.Label1.Text = "航次"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShip
        '
        Me.txtShip.Location = New System.Drawing.Point(40, 18)
        Me.txtShip.MaxLength = 40
        Me.txtShip.Name = "txtShip"
        Me.txtShip.Size = New System.Drawing.Size(100, 22)
        Me.txtShip.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 307
        Me.Label2.Text = "船码"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rbnDetailed
        '
        Me.rbnDetailed.Location = New System.Drawing.Point(558, 18)
        Me.rbnDetailed.Name = "rbnDetailed"
        Me.rbnDetailed.Size = New System.Drawing.Size(82, 22)
        Me.rbnDetailed.TabIndex = 344
        Me.rbnDetailed.Text = "详细提单"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(284, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 343
        Me.Label4.Text = "提单号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShipName
        '
        Me.txtShipName.BackColor = System.Drawing.Color.Lavender
        Me.txtShipName.Location = New System.Drawing.Point(40, 42)
        Me.txtShipName.MaxLength = 40
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.ReadOnly = True
        Me.txtShipName.Size = New System.Drawing.Size(200, 22)
        Me.txtShipName.TabIndex = 2
        '
        'rbnUsual
        '
        Me.rbnUsual.Checked = True
        Me.rbnUsual.Location = New System.Drawing.Point(558, 44)
        Me.rbnUsual.Name = "rbnUsual"
        Me.rbnUsual.Size = New System.Drawing.Size(82, 22)
        Me.rbnUsual.TabIndex = 345
        Me.rbnUsual.TabStop = True
        Me.rbnUsual.Text = "一般提单"
        '
        'txtBillNO
        '
        Me.txtBillNO.Font = New System.Drawing.Font("新宋体", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtBillNO.Location = New System.Drawing.Point(330, 18)
        Me.txtBillNO.MaxLength = 120
        Me.txtBillNO.Name = "txtBillNO"
        Me.txtBillNO.Size = New System.Drawing.Size(150, 22)
        Me.txtBillNO.TabIndex = 3
        '
        'btnGetData
        '
        Me.btnGetData.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnGetData.Location = New System.Drawing.Point(486, 26)
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.Size = New System.Drawing.Size(65, 24)
        Me.btnGetData.TabIndex = 640
        Me.btnGetData.Text = "查找"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 330
        Me.Label3.Text = "船名"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExportEdit
        '
        Me.btnExportEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExportEdit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExportEdit.Location = New System.Drawing.Point(498, 528)
        Me.btnExportEdit.Name = "btnExportEdit"
        Me.btnExportEdit.Size = New System.Drawing.Size(65, 24)
        Me.btnExportEdit.TabIndex = 696
        Me.btnExportEdit.Text = "导出编辑"
        '
        'btnExportSave
        '
        Me.btnExportSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnExportSave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExportSave.Location = New System.Drawing.Point(566, 528)
        Me.btnExportSave.Name = "btnExportSave"
        Me.btnExportSave.Size = New System.Drawing.Size(65, 24)
        Me.btnExportSave.TabIndex = 697
        Me.btnExportSave.Text = "导出保存"
        '
        'FrmConLoadTallyNew_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(860, 555)
        Me.Controls.Add(Me.btnExportSave)
        Me.Controls.Add(Me.btnExportEdit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.ccbConsign)
        Me.Controls.Add(Me.ccbGoods)
        Me.Controls.Add(Me.dtpTimeEnd)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtNewVoyage)
        Me.Controls.Add(Me.txtNewBill)
        Me.Controls.Add(Me.txtNewShip)
        Me.Controls.Add(Me.dtpListDate)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dtpTimeBegin)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbInOutPort)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbUnloadPort)
        Me.Controls.Add(Me.cbLoadPort)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.cbWorkType)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cbConLoadType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cbState)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtTotalNetWeight)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtSize)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtGoodsSpec)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtTallyClerk)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtMark)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnConDelete)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.labShipName)
        Me.Controls.Add(Me.txtNewShipName)
        Me.Font = New System.Drawing.Font("新宋体", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConLoadTallyNew_Edit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "装拆箱箱信息 修改删除"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccbConsign, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccbGoods, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public strFindConNo As String   '查找定位用
    Dim dsSubTable As New DataSet
    Dim sqlSubTableda As New SqlClient.SqlDataAdapter
    Public Shared strShip, strVoyage, strBillNo, strYCode As String
    Public strOldShip, strOldVoyage, strOldBillNo As String
    Public Shared dvcodeYard As New DataView
    Dim Count, delSum As Integer

    Dim sqlConsign As String
    Dim dvConsign As DataView
    Dim sqlShipCode As String
    Dim dvShipCode As New DataView
    Public Shared EditMark As Boolean

    Dim strPrint As String = 0

    Dim sqlBill As String
    Dim dsBill As New DataSet
    Dim dvBill As New DataView
    Dim daBill As New SqlClient.SqlDataAdapter


    Private Sub FrmConLoadTallyNew_Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sqlYard As String
        sqlYard = "SELECT Code_Yard_ID, Code_Yard_Name, CodePrefix,DeptCode FROM Code_Yard where DeptCode like '" & G_DeptCode & "%' ORDER BY Code_Yard_ID"
        cbPlace.DataSource = Filldata(sqlYard)
        cbPlace.DisplayMember = "Code_Yard_Name"
        cbPlace.ValueMember = "Code_Yard_ID"

        EditMark = False
        strShip = FrmConLoadTally.strShip
        strVoyage = FrmConLoadTally.strVoyage
        strBillNo = FrmConLoadTally.strBillNo
        strYCode = FrmConLoadTally.strCodeYard
        Me.txtShip.Text = strShip
        Me.txtVoyage.Text = strVoyage
        Me.txtBillNO.Text = strBillNo
        Me.cbPlace.SelectedValue = strYCode

        sqlShipCode = "SELECT SPCODE, CHI_VESSEL,ENG_VESSEL FROM Code_SHIPNAME WHERE SPCODE = '" & strShip & "'"
        dvShipCode = Filldata(sqlShipCode)
        If dvShipCode.Count > 0 Then
            strShip = dvShipCode(0)("SPCODE")
            Me.txtShip.Text = strShip
            If Not IsDBNull(dvShipCode(0)("CHI_VESSEL")) Then
                Me.txtShipName.Text = dvShipCode(0)("CHI_VESSEL")
            End If
            If Not IsDBNull(dvShipCode(0)("ENG_VESSEL")) Then
                Me.txtShipName.Text += "/" & dvShipCode(0)("ENG_VESSEL")
            End If
        End If
        strOldShip = strShip
        strOldVoyage = strVoyage
        strOldBillNo = strBillNo    '记录原来的船名码航次提单号

        'Dim sqlCodeYard As String
        'sqlCodeYard = "SELECT Code_Yard_ID, Code_Yard_Name, CodePrefix, CodeMax, CodeYear, DeptCode FROM Code_Yard WHERE DeptCode = '" & G_DeptCode & "'"
        'dvcodeYard = Filldata(sqlCodeYard)
        'If dvcodeYard.Count > 0 Then
        '    strYCode = dvcodeYard(0)("Code_Yard_ID")
        'End If

        Me.C1DBG.AllowAddNew = False
        Me.txtShip.Focus()
        Call InitBill()  '顺序不能错
        FillBill()
        Call InitSubTable()
        SetC1CurrentCellStyle(Me.C1DBG)
        SetC1SelectedRowStyle(Me.C1DBG)
    End Sub

    Dim dvLoadPort As New DataView
    Dim dvUnloadPort As New DataView
    Private Sub InitBill()
        dtpListDate.CustomFormat = "yy-MM-dd"
        dtpTimeBegin.CustomFormat = "yy-MM-dd HH:mm"
        dtpTimeEnd.CustomFormat = "yy-MM-dd HH:mm"

        Dim dvWorkType As New DataView
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

        sqlConsign = "SELECT CODE_SHIP_AGENT, SHIPAGENT_SHORT, SHIPAGENT_ENG FROM CODE_SHIP_AGENT where Mark <> '1' OR Mark IS NULL ORDER BY SHIPAGENT_SHORT"
        dvConsign = Filldata(sqlConsign)
        ccbConsign.DataSource = dvConsign
        ccbConsign.DisplayMember = "SHIPAGENT_SHORT"
        ccbConsign.ValueMember = "CODE_SHIP_AGENT"
        Me.ccbConsign.ColumnHeaders = False
        Me.ccbConsign.Splits(0).DisplayColumns("CODE_SHIP_AGENT").Visible = False
        Me.ccbConsign.Splits(0).DisplayColumns("SHIPAGENT_SHORT").AutoSize()
        Me.ccbConsign.Splits(0).DisplayColumns("SHIPAGENT_ENG").AutoSize()
        Me.ccbConsign.DropDownWidth = Me.ccbConsign.Splits(0).DisplayColumns("SHIPAGENT_SHORT").Width + Me.ccbConsign.Splits(0).DisplayColumns("SHIPAGENT_ENG").Width + 20

        Dim dvCodeGoods As New DataView
        Dim sqlCodeGoods As String
        sqlCodeGoods = "select Code,Goods from CodeGoods where ConLoadMark='1' order by Goods"
        dvCodeGoods = Filldata(sqlCodeGoods)
        ccbGoods.DataSource = dvCodeGoods
        ccbGoods.DisplayMember = "Goods"
        ccbGoods.ValueMember = "Code"
        Me.ccbGoods.ColumnHeaders = False

        Me.ccbGoods.Splits(0).DisplayColumns("Code").Visible = False
        Me.ccbGoods.Splits(0).DisplayColumns("Goods").AutoSize()
        Me.ccbGoods.DropDownWidth = Me.ccbGoods.Splits(0).DisplayColumns("Goods").Width + 20

        Dim sqlCodePort As String
        sqlCodePort = "SELECT CODE_PORT, PORT_CHA, PORT_ENG FROM CODE_PORT ORDER BY PORT_CHA"

        dvLoadPort = Filldata(sqlCodePort)
        Me.cbLoadPort.DataSource = dvLoadPort
        Me.cbLoadPort.DisplayMember = "PORT_CHA"
        Me.cbLoadPort.ValueMember = "CODE_PORT"

        dvUnloadPort = Filldata(sqlCodePort)
        Me.cbUnloadPort.DataSource = dvUnloadPort
        Me.cbUnloadPort.DisplayMember = "PORT_CHA"
        Me.cbUnloadPort.ValueMember = "CODE_PORT"

        Dim dvInOutPort As New DataView
        Dim sqlInOutPort As String
        sqlInOutPort = "SELECT InOutPort, InOutPort_Name FROM Code_InOutPort"
        dvInOutPort = Filldata(sqlInOutPort)
        Me.cbInOutPort.DataSource = dvInOutPort
        Me.cbInOutPort.DisplayMember = "InOutPort_Name"
        Me.cbInOutPort.ValueMember = "InOutPort"

    End Sub

    Dim billEnable As Boolean
    Dim BillSign As Boolean

    Public Sub FillBill()
        On Error Resume Next
        '根据船名航次提单号场站确定提单是否存在，若存在显示，否则不管并使'详细提单'有效
        sqlBill = "SELECT * FROM CON_LOAD_TALLY WHERE CHI_VESSEL = '" & strShip & "' AND Voyage = '" & strVoyage & "' AND BLNO = '" & strBillNo & "' AND WORK_PLACE = '" & strYCode & "'"
        dvBill = Updatedata(daBill, sqlBill, dsBill)

        If dvBill.Count > 0 Then
            ID = dvBill(0)("CON_LOAD_TALLY_ID")
            Me.txtNewShip.Text = strShip
            Me.txtNewVoyage.Text = strVoyage
            Me.txtNewBill.Text = strBillNo
            Me.txtNewShipName.Text = Me.txtShipName.Text

            If dsBill.Tables(0).Rows(0)("TradeMark") = "1" Then '是内贸箱
                Me.ckbInTrade.Checked = True
            Else
                Me.ckbInTrade.Checked = False
            End If
            'cbPlace.SelectedValue = dsBill.Tables(0).Rows(0).Item("WORK_PLACE")
            txtNO.Text = dsBill.Tables(0).Rows(0).Item("NO")
            txtTallyClerk.Text = dsBill.Tables(0).Rows(0).Item("TALLY_CLERK").ToString
            txtMark.Text = dsBill.Tables(0).Rows(0).Item("MARK").ToString

            '先将Value置空，防止对于不在数据源中的数据无法赋值的问题
            'cbGoodsCode.SelectedValue = DBNull.Value    '直接赋空值
            'ccbGoods.SelectedIndex = -1              '让Index=-1
            'cbGoodsCode.SelectedValue = ""              '赋一个不存在的值
            '三个办法中前两个为好，使用Index最简洁。不能用Nothing，没有作用
            ccbGoods.Text = dsBill.Tables(0).Rows(0).Item("GoodsCha").ToString
            Me.txtGoodsSpec.Text = dsBill.Tables(0).Rows(0).Item("GoodsSpec").ToString
            txtAmount.Text = dsBill.Tables(0).Rows(0).Item("AMOUNT").ToString
            txtTotalNetWeight.Text = dsBill.Tables(0).Rows(0)("TOTALNetWEIGHT").ToString
            txtSize.Text = dsBill.Tables(0).Rows(0).Item("SIZE_MEASURE").ToString

            cbState.Text = dsBill.Tables(0).Rows(0).Item("STATE").ToString
            ccbConsign.SelectedValue = dsBill.Tables(0).Rows(0).Item("CODE_CON_CONSIGN")
            Me.cbInOutPort.SelectedValue = dsBill.Tables(0).Rows(0)("InOutPort")
            Me.cbLoadPort.SelectedValue = dsBill.Tables(0).Rows(0)("CodeLoadPort")
            Me.cbUnloadPort.SelectedValue = dsBill.Tables(0).Rows(0)("CodeUnloadPort")
            cbWorkType.SelectedValue = dsBill.Tables(0).Rows(0).Item("WORKTYPE")
            cbConLoadType.SelectedValue = dsBill.Tables(0).Rows(0).Item("CODE_TALLY_TYPE")
            dtpTimeBegin.Value = dsBill.Tables(0).Rows(0).Item("TIME_FROM")
            dtpTimeEnd.Value = dtpTimeBegin.Value
            dtpListDate.Value = dsBill.Tables(0).Rows(0).Item("LISTDATE")
            billEnable = True
            rbnDetailed.Enabled = True
            rbnUsual.Enabled = True

            'strYCode = Me.cbPlace.SelectedValue
            If dvBill(0)("StateB") <> "0" And dvBill(0)("StateB") <> "1" Then
                If dvBill(0)("CODE_TALLY_TYPE") <> "8" Then  '非拼箱货时
                    If G_DeptCode <> "26.11.30" Then    '如果理货单状态是打印过的，且操作部门不是查验中心，不允许操作
                        MessageBox.Show("该理货单已打印过，非海关查验中心不可修改", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.btnConDelete.Enabled = False
                        Me.btSave.Enabled = False
                        billEnable = False
                    End If
                End If
            End If
        Else
            billEnable = True
            rbnDetailed.Enabled = False
            rbnUsual.Enabled = False

            ID = 0
            'If (Count > 0) Then
            '    MessageBox.Show("提单信息异常丢失！箱信息无效！", "警告")
            'End If
        End If
    End Sub

    Private Sub InitSubTable()
        Try
            Dim sqlSubTable As String
            'sqlSubTable = "select * from Con_Load_Tally_List where CodeYard = '" & strYCode & "' AND CHI_VESSEL ='" & strShip & "' and Voyage = '" & strVoyage & "'"
            sqlSubTable = "select CON_LOAD_TALLY_LIST_ID,CON_LOAD_TALLY_ID,SHIP_ID,CHI_VESSEL,Voyage,BLNO,CONTAINER_NO,SIZE_CON,CONTAINER_TYPE,Clerk,NEWSEALNO,SealType,SealPerson,PACK_CHA,AMOUNT,WEIGHT,NetWeight,VOLUME,OutStorage,ConTime,DAMAGED_AMOUNT,DAMAGED_PACK,SecSealNO,ReasonOpenSeal,ReeferTemp,TempUnit,DangerGrade,DangerMark,USER_NAME,CodeYard,Checked,CheckTime,Printed,PrintTime,PrintPerson,StateC,FullOrEmpty " & _
                " from Con_Load_Tally_List where  CHI_VESSEL ='" & strShip & "' and Voyage = '" & strVoyage & "' and blno= '" & strBillNo & "' and CodeYard = '" & strYCode & "' order by CON_LOAD_TALLY_LIST_ID"
            Updatedata(sqlSubTableda, sqlSubTable, dsSubTable)
            Dim dgColumn As New DataColumn("Valid", Type.GetType("System.String"))
            dsSubTable.Tables(0).Columns.Add(dgColumn)
            dgColumn = New DataColumn("ClerkValid", Type.GetType("System.String"))
            dsSubTable.Tables(0).Columns.Add(dgColumn)

            Me.C1DBG.DataSource = dsSubTable.Tables(0).DefaultView

            Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
            Me.C1DBG.ColumnFooters = True
            Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
            Me.C1DBG.Columns("CONTAINER_NO").FooterText = "合计" & dsSubTable.Tables(0).Rows.Count & "箱"
            Count = dsSubTable.Tables(0).Rows.Count
            If Count > 0 Then
                'Dim i As Integer
                'For i = 0 To Count - 1
                '    If Me.C1DBG.Columns("Printed").CellText(i) = "1" Then
                '        strPrint = "1"
                '        Exit For
                '    End If
                'Next
                'If strPrint = "1" Then
                '    Me.btnConDelete.Enabled = False
                '    Me.btSave.Enabled = False
                '    MessageBox.Show("海关处理过不可操作", "警示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'End If
            End If
            Me.C1DBG.Splits(0).DisplayColumns.Item(0).Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item(1).Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("SHIP_ID").Visible = False
            'Me.C1DBG.Splits(0).DisplayColumns("CHI_VESSEL").Visible = False
            'Me.C1DBG.Splits(0).DisplayColumns("VOYAGE").Visible = False
            'Me.C1DBG.Splits(0).DisplayColumns("BLNO").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("CodeYard").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("USER_NAME").Visible = False

            Me.C1DBG.Splits(0).DisplayColumns.Item("Checked").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("CheckTime").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("Printed").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("PrintTime").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("PrintPerson").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("StateC").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("FullOrEmpty").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns("Valid").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns("ClerkValid").Visible = False

            Me.C1DBG.Splits(0).DisplayColumns(0).Locked = True
            Me.C1DBG.Splits(0).DisplayColumns(1).Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("SHIP_ID").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("CodeYard").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("USER_NAME").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("Checked").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("CheckTime").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("Printed").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("PrintTime").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("PrintPerson").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("StateC").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("FullOrEmpty").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("Valid").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("ClerkValid").Locked = True
            cbConLoadType_SelectedIndexChanged(New Object(), New EventArgs())

            Me.C1DBG.Columns.Item("CHI_VESSEL").Caption = "船码"
            Me.C1DBG.Columns.Item("VOYAGE").Caption = "航次"
            Me.C1DBG.Columns.Item("BLNO").Caption = "提单号"
            Me.C1DBG.Columns.Item("CONTAINER_NO").Caption = "集装箱号"
            Me.C1DBG.Columns.Item("NEWSEALNO").Caption = "铅封号"
            Me.C1DBG.Columns.Item("SealType").Caption = "封别"
            Me.C1DBG.Columns.Item("SealPerson").Caption = "施封人"
            Me.C1DBG.Columns.Item("SIZE_CON").Caption = "箱尺"
            Me.C1DBG.Columns.Item("CONTAINER_TYPE").Caption = "箱型"
            Me.C1DBG.Columns.Item("AMOUNT").Caption = "件数"
            Me.C1DBG.Columns.Item("PACK_CHA").Caption = "包装"
            Me.C1DBG.Columns.Item("WEIGHT").Caption = "毛重kg"
            Me.C1DBG.Columns.Item("NetWeight").Caption = "货重kg"
            Me.C1DBG.Columns.Item("VOLUME").Caption = "尺码M3"
            Me.C1DBG.Columns.Item("DAMAGED_AMOUNT").Caption = "残损件数"
            Me.C1DBG.Columns.Item("DAMAGED_PACK").Caption = "残损情况"
            Me.C1DBG.Columns.Item("SecSealNO").Caption = "备注封"
            Me.C1DBG.Columns.Item("ReasonOpenSeal").Caption = "开封原因"
            Me.C1DBG.Columns.Item("ReeferTemp").Caption = "冷藏温度"
            Me.C1DBG.Columns.Item("TempUnit").Caption = "温标"
            Me.C1DBG.Columns.Item("DangerGrade").Caption = "危品等级"
            Me.C1DBG.Columns.Item("DangerMark").Caption = "危品标签"
            Me.C1DBG.Columns.Item("Clerk").Caption = "理货员"
            Me.C1DBG.Columns.Item("OutStorage").Caption = "转外场"
            Me.C1DBG.Columns.Item("ConTime").Caption = "作业时间"

            Me.C1DBG.Columns("ConTime").NumberFormat = "yyMMdd HHmm"
            'Me.C1DBG.Columns.Item("CON_LOAD_TALLY_ID").DefaultValue = ID
            'Me.C1DBG.Columns.Item("USER_NAME").DefaultValue = G_User
            'Me.C1DBG.Columns.Item("CHI_VESSEL").DefaultValue = strShip
            'Me.C1DBG.Columns.Item("VOYAGE").DefaultValue = strVoyage
            'Me.C1DBG.Columns.Item("CodeYard").DefaultValue = strYCode

            'Me.C1DBG.Splits(0).DisplayColumns("BLNO").Locked = True
            Call FieldFill()
            SetDGWidth3(Me.C1DBG)
            Me.C1DBG.Splits(0).DisplayColumns("Clerk").AutoDropDown = True
            Me.C1DBG.Splits(0).DisplayColumns("NewSealNo").AutoDropDown = True
            Me.C1DBG.Splits(0).DisplayColumns("SealType").AutoDropDown = True
            Me.C1DBG.Splits(0).DisplayColumns("SealPerson").AutoDropDown = True
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_TYPE").AutoDropDown = True
            Me.C1DBG.Splits(0).DisplayColumns("PACK_CHA").AutoDropDown = True
            Me.C1DBG.Splits(0).DisplayColumns("TempUnit").AutoDropDown = True
            Me.C1DBG.Splits(0).DisplayColumns("OutStorage").AutoDropDown = True

            Me.C1DBG.Splits(0).DisplayColumns("Clerk").FetchStyle = True
            Me.C1DBG.Splits(0).DisplayColumns("NewSealNo").FetchStyle = True
            Me.C1DBG.Splits(0).ColumnCaptionHeight = 20
            Me.C1DBG.RowHeight = 18

            Dim iFindConIndex As Integer = -1 '定位箱号位置
            Dim i As Integer
            For i = 0 To dsSubTable.Tables(0).Rows.Count - 1
                Me.C1DBG.Row = i
                '结束时间为最后作业箱时间
                If Not IsDBNull(Me.C1DBG.Columns("ConTime").CellValue(i)) Then
                    If Me.dtpTimeEnd.Value < Me.C1DBG.Columns("ConTime").CellValue(i) Then
                        Me.dtpTimeEnd.Value = Me.C1DBG.Columns("ConTime").CellValue(i)
                    End If
                End If
                RefreshClerkMark()
                '更新铅封号下拉框数据
                Dim strNewFilter As String
                strNewFilter = "User_Person='" & Me.C1DBG.Columns("Clerk").Text & "'"
                dvSealNo.RowFilter = strNewFilter
                'RefreshDropDownSealNo(strNewFilter)
                RefreshSealNoMark()
                '查找箱号定位
                If iFindConIndex = -1 AndAlso Me.C1DBG.Columns("Container_No").Text = strFindConNo Then
                    iFindConIndex = i
                End If
            Next
            If iFindConIndex >= 0 Then
                Me.C1DBG.Row = iFindConIndex
                Me.C1DBG.SelectedRows.Add(Me.C1DBG.Row)
            Else

            End If

            Me.C1DBG.UpdateData()
            Me.C1DBG.Columns("AMOUNT").FooterText = GetDataSum(dsSubTable.Tables(0).DefaultView, "AMOUNT")
            Me.C1DBG.Columns("NetWeight").FooterText = GetDataSum(dsSubTable.Tables(0).DefaultView, "NetWeight")
            Me.C1DBG.Columns("VOLUME").FooterText = GetDataSum(dsSubTable.Tables(0).DefaultView, "VOLUME")
        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Dim sqlClerk As String
    Dim dvClerk As DataView
    Dim sqlPack As String
    Dim dvPack As DataView
    Dim sqlOutStorage As String
    Dim dvOutStorage As DataView
    Dim sqlSealNo As String
    Dim dvSealNo As DataView

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

            sqlPack = "SELECT CODE_PACK, PACK_CHA, PACK_ENG,Pack_Short FROM CODE_PACK ORDER BY px"
            dvPack = Filldata(sqlPack)
            Me.C1DBG.Columns("PACK_CHA").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("PACK_CHA").ValueItems.Translate = True
            Me.C1DBG.Columns("PACK_CHA").ValueItems.MaxComboItems = 20
            For i = 0 To dvPack.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = dvPack(i)("PACK_CHA")
                vi.Value = dvPack(i)("CODE_PACK")
                Me.C1DBG.Columns.Item("PACK_CHA").ValueItems.Values.Add(vi)
            Next

            sqlOutStorage = "SELECT Code_WorkPlace,WorkPlace FROM tb_Code_WorkPlace where Using_ConLoad='1' order by WorkPlace"
            dvOutStorage = Filldata(sqlOutStorage)
            C1DBG.Columns("OutStorage").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            C1DBG.Columns("OutStorage").ValueItems.Translate = True
            C1DBG.Columns("OutStorage").ValueItems.MaxComboItems = 20
            For i = 0 To dvOutStorage.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = dvOutStorage(i)("WorkPlace")
                vi.Value = dvOutStorage(i)("WorkPlace")
                Me.C1DBG.Columns.Item("OutStorage").ValueItems.Values.Add(vi)
            Next

            Me.C1DBG.Columns("Clerk").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("Clerk").ValueItems.MaxComboItems = 20
            'sqlClerk = "select A.Serial_Nam,A.Name,B.Work_No,B.Tally_Short from System_User_Table A join Tally_Clerk B on A.Name=B.Name where A.Dept_Code='" & G_DeptCode & "' order by A.Name"
            ''sqlClerk = "select Name,Work_No,Tally_Short from Tally_Clerk B where Dept_Code='" & G_DeptCode & "' order by Name"
            '选出理货人员
            'sqlClerk = "select Name,Work_No,Tally_Short from Tally_Clerk where DEPT_CODE LIKE '26.12%' ORDER BY NAME, DEPT_CODE"
            sqlClerk = "select Name,Work_No,Tally_Short,DEPT_CODE from Tally_Clerk where Dept_Code like '2[69].12%' " & _
                " and SubString(Dept_Code,3,6) in (select ClerkDept from DepartMent where Dept_Code='" & G_DeptCode & "') ORDER BY NAME,DEPT_CODE"
            dvClerk = Filldata(sqlClerk)
            For i = 0 To dvClerk.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = dvClerk(i)("Name")
                vi.Value = dvClerk(i)("Name")
                Me.C1DBG.Columns("Clerk").ValueItems.Values.Add(vi)
            Next

            Me.C1DBG.Columns("NEWSEALNO").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("NEWSEALNO").ValueItems.MaxComboItems = 20
            '铅封和理货员属于场站一二三四五部。与各理货场站不同，因此不能按部门选择
            'sqlSealNo = "SELECT SealNo,Seal_State,Dept_Code,Use_Mark,Logout_Mark,User_Person FROM SEAL_RECORD WHERE Seal_State='2' and (Use_Mark='0' or Ship_Code='" & strShip & "' and Voyage='" & strVoyage & "') and Logout_Mark='0'"
            'sqlSealNo = "SELECT SealNo,Seal_State,A.Dept_Code,Use_Mark,Logout_Mark,User_Person FROM SEAL_RECORD A left join DepartMent B on (subString(A.Dept_Code,3,6)=B.ClerkDept or subString(A.Dept_Code,3,3)=B.ClerkDept) WHERE Seal_State='2' and Logout_Mark='0' and (Use_Mark='0' or Ship_Code='" & strShip & "' and Voyage='" & strVoyage & "' and CONTAINER_NO in (select CONTAINER_NO from Con_Load_Tally_List where Chi_Vessel='" & strShip & "' and Voyage='" & strVoyage & "' and Blno='" & strBillNo & "')) "
            sqlSealNo = "SELECT SealNo,Seal_State,Dept_Code,Use_Mark,Logout_Mark,User_Person FROM SEAL_RECORD " & _
                " WHERE Seal_State='2' and Logout_Mark='0' " & _
                " and (Use_Mark='0' or Ship_Code='" & strShip & "' and Voyage='" & strVoyage & "' and CONTAINER_NO in (select CONTAINER_NO from Con_Load_Tally_List where Chi_Vessel='" & strShip & "' and Voyage='" & strVoyage & "' and Blno='" & strBillNo & "')) " & _
                " and SubString(Dept_Code,3,6) in (select ClerkDept from DepartMent where Dept_Code='" & G_DeptCode & "')"
            dvSealNo = Filldata(sqlSealNo)
            Dim a As Integer = dvSealNo.Table.Rows.Count

            Me.C1DBG.Columns("SealType").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("SealType").ValueItems.MaxComboItems = 20
            Dim sqlSealType As String
            Dim dvSealType As DataView
            sqlSealType = "SELECT ID, Code, KindDesc FROM Code_SealKind ORDER BY ID"
            dvSealType = Filldata(sqlSealType)
            For i = 0 To dvSealType.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = dvSealType(i)("Code")
                vi.Value = dvSealType(i)("Code")
                Me.C1DBG.Columns("SealType").ValueItems.Values.Add(vi)
            Next
            Me.C1DBG.Columns("SealPerson").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("SealPerson").ValueItems.MaxComboItems = 20
            Dim sqlSealPerson As String
            Dim dvSealPerson As DataView
            sqlSealPerson = "SELECT ID, Code, PersonDesc FROM Code_SealPerson ORDER BY ID"
            dvSealPerson = Filldata(sqlSealPerson)
            For i = 0 To dvSealPerson.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = dvSealPerson(i)("Code")
                vi.Value = dvSealPerson(i)("Code")
                Me.C1DBG.Columns("SealPerson").ValueItems.Values.Add(vi)
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
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Width = 60
                i = i + 1
            Loop
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Width = 80
            Me.C1DBG.Splits(0).DisplayColumns("NEWSEALNO").Width = 80
            Me.C1DBG.Splits(0).DisplayColumns("BLNO").Width = 90
            Me.C1DBG.Splits(0).DisplayColumns("SIZE_CON").Width = 30
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_TYPE").Width = 40
            Me.C1DBG.Splits(0).DisplayColumns("ReeferTemp").Width = 40
            Me.C1DBG.Splits(0).DisplayColumns("TempUnit").Width = 40
            Me.C1DBG.Splits(0).DisplayColumns("ConTime").Width = 95
            For i = 0 To Me.C1DBG.Columns.Count - 1
                Me.C1DBG.Splits(0).DisplayColumns(i).Width *= 1.1
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
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

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            Dim blEmptyCon As Boolean   '空箱标志 不查铅封
            If Me.cbConLoadType.SelectedValue = "4" Then
                blEmptyCon = True
            Else
                blEmptyCon = False
            End If

            Dim i, j As Integer
            Count = Count - delSum
            Me.C1DBG.Focus()
            For i = 0 To Count - 1  '提单号可改，船名航次也可改
                Me.C1DBG.Row = i
                Me.C1DBG.Columns("CHI_VESSEL").Text = Me.C1DBG.Columns("CHI_VESSEL").Text.Trim().ToUpper
                Me.C1DBG.Columns("Voyage").Text = Me.C1DBG.Columns("Voyage").Text.Trim().ToUpper
                Me.C1DBG.Columns("BLNO").Text = Me.C1DBG.Columns("BLNO").Text.Trim().ToUpper
                Me.C1DBG.Columns("CONTAINER_NO").Text = Me.C1DBG.Columns("CONTAINER_NO").Text.Trim().ToUpper
                Me.C1DBG.Columns("NEWSEALNO").Text = Me.C1DBG.Columns("NEWSEALNO").Text.Trim().ToUpper
                Me.C1DBG.Columns("CONTAINER_TYPE").Text = Me.C1DBG.Columns("CONTAINER_TYPE").Text.Trim().ToUpper
                Me.C1DBG.Columns("DAMAGED_PACK").Text = Me.C1DBG.Columns("DAMAGED_PACK").Text.Trim()
                Me.C1DBG.Columns("DangerGrade").Text = Me.C1DBG.Columns("DangerGrade").Text.Trim()
                Me.C1DBG.Columns("DangerMark").Text = Me.C1DBG.Columns("DangerMark").Text.Trim()

                'Me.C1DBG.Columns("CHI_VESSEL").Text = strShip
                'Me.C1DBG.Columns("Voyage").Text = strVoyage
            Next
            Me.btQuit.Focus()

            '检查船次提单是否重复
            If Me.txtNewShip.Text <> strOldShip OrElse Me.txtNewVoyage.Text <> strOldShip OrElse Me.txtNewBill.Text <> strOldBillNo Then
                Dim sqlBillExist As String
                Dim dvBillExist As DataView
                sqlBillExist = "select Blno from Con_Load_Tally where CHI_VESSEL = '" & txtNewShip.Text & "' AND Voyage = '" & txtNewVoyage.Text & "' AND BLNO = '" & txtNewBill.Text & "' and WORK_PLACE='" & strYCode & "' and Con_Load_Tally_ID<>" & ID
                dvBillExist = Filldata(sqlBillExist)
                If dvBillExist.Count > 0 Then
                    Me.txtNewShip.Focus()
                    MessageBox.Show("船码航次提单号修改不可重复！", "提示")
                    Exit Sub
                End If
            End If

            Dim iConCheck, iConBeing As Integer
            Dim sqlBeing As String

            For i = 0 To Count - 1    '界面上检查箱号提单号 船名航次
                strShip = Me.C1DBG.Columns("CHI_VESSEL").CellText(i)
                strVoyage = Me.C1DBG.Columns("Voyage").CellText(i)
                strBillNo = Me.C1DBG.Columns("BLNO").CellText(i)
                If strShip <> "" Then
                    If strVoyage <> "" Then
                        If strBillNo <> "" Then
                            If Me.C1DBG.Columns("CONTAINER_NO").CellText(i) <> "" Then
                                iConCheck = CheckConNO(Me.C1DBG.Columns("CONTAINER_NO").CellText(i))
                                '箱号没有通过检验时
                                If iConCheck = 1 Or iConCheck = 0 Then
                                    sqlBeing = "SELECT CONTAINER_NO FROM CON_CRITERION WHERE CONTAINER_NO = '" & C1DBG.Columns("CONTAINER_NO").CellText(i) & "' or CONTAINER_NO = '" & GetConOtherMode(C1DBG.Columns("CONTAINER_NO").CellText(i)) & "'"
                                    iConBeing = Filldata(sqlBeing).Count
                                    If iConBeing = 0 Then    '箱规范中不存在
                                        Me.C1DBG.Row = i
                                        Me.C1DBG.SelectedRows.Clear()
                                        Me.C1DBG.SelectedRows.Add(i)
                                        If MessageBox.Show("集装箱号 " & C1DBG.Columns("CONTAINER_NO").CellText(i) & " 校验不正确且在不存在于箱规范中！确定存在吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
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
                                '检查船码
                                'sqlShipCode = "SELECT SPCODE, CHI_VESSEL FROM Code_SHIPNAME WHERE SPCODE = '" & strShip & "'"
                                'dvShipCode = Filldata(sqlShipCode)
                                'If dvShipCode.Count > 0 Then
                                '    'Me.C1DBG.Columns("CHI_VESSEL").Text = dvShipCode(0)("SPCODE")
                                'Else
                                '    Me.C1DBG.Row = i
                                '    Me.C1DBG.SelectedRows.Clear()
                                '    Me.C1DBG.SelectedRows.Add(i)
                                '    MessageBox.Show("船码 " & strShip & " 不存在，请重新输入", "提示")
                                '    Exit For
                                'End If
                                '检查重复
                                For j = 0 To i - 1
                                    If IsEqualConNo(Me.C1DBG.Columns("CONTAINER_NO").CellText(i), Me.C1DBG.Columns("CONTAINER_NO").CellText(j)) Then
                                        If String.Equals(Me.C1DBG.Columns("BLNO").CellText(j), strBillNo) And _
                                           String.Equals(Me.C1DBG.Columns("CHI_VESSEL").CellText(j), strShip) And String.Equals(Me.C1DBG.Columns("Voyage").CellText(j), strVoyage) Then
                                            Me.C1DBG.Row = i
                                            Me.C1DBG.SelectedRows.Clear()
                                            Me.C1DBG.SelectedRows.Add(i)
                                            Me.C1DBG.SelectedRows.Add(j)
                                            MessageBox.Show("第" & j + 1 & "行和第" & i + 1 & "行 同一船次提单下集装箱号重复！", "提示")
                                            Exit Sub
                                        End If
                                    End If
                                Next
                            Else
                                Me.C1DBG.Row = i
                                Me.C1DBG.SelectedRows.Clear()
                                Me.C1DBG.SelectedRows.Add(i)
                                MessageBox.Show("集装箱号不能为空！", "提示")
                                Exit For
                            End If
                        Else
                            Me.C1DBG.Row = i
                            Me.C1DBG.SelectedRows.Clear()
                            Me.C1DBG.SelectedRows.Add(i)
                            MessageBox.Show("提单号不能为空！", "提示")
                            Exit For
                        End If
                    Else
                        Me.C1DBG.Row = i
                        Me.C1DBG.SelectedRows.Clear()
                        Me.C1DBG.SelectedRows.Add(i)
                        MessageBox.Show("航次不能为空！", "提示")
                        Exit For
                    End If
                Else
                    Me.C1DBG.Row = i
                    Me.C1DBG.SelectedRows.Clear()
                    Me.C1DBG.SelectedRows.Add(i)
                    MessageBox.Show("船名码不能为空！", "提示")
                    Exit For
                End If
                If blEmptyCon = False Then   '空箱不检查铅封
                    For j = 0 To i - 1
                        If Me.C1DBG.Columns("NEWSEALNO").CellText(i) = Me.C1DBG.Columns("NEWSEALNO").CellText(j) Then
                            Me.C1DBG.Row = i
                            Me.C1DBG.SelectedRows.Clear()
                            Me.C1DBG.SelectedRows.Add(i)
                            Me.C1DBG.SelectedRows.Add(j)
                            If MessageBox.Show("第" & j + 1 & "行和第" & i + 1 & "行 封号重复！是否忽略?", "提示", MessageBoxButtons.OKCancel) = DialogResult.Cancel Then
                                Exit Sub
                            End If
                        End If
                    Next
                End If
            Next


            '检查箱号是否与数据库中数据重复，同提单下箱号不可重复，此船次下可重复（当作拼箱）
            Dim sqlRepeat As String
            Dim dvRepeat As New DataView
            If i >= Count Then    '界面检查无误
                For i = 0 To Count - 1    '数据库检查 本提单下的箱不能检查
                    strShip = Me.C1DBG.Columns("CHI_VESSEL").CellText(i)
                    strVoyage = Me.C1DBG.Columns("Voyage").CellText(i)
                    strBillNo = Me.C1DBG.Columns("blno").CellText(i)
                    If strShip <> strOldShip Or strVoyage <> strOldVoyage Or strBillNo <> strOldBillNo Then    '只要查修改了船名码航次提单的箱子
                        sqlRepeat = "SELECT CHI_VESSEL, Voyage, BLNO, CONTAINER_NO FROM CON_LOAD_TALLY_LIST WHERE CHI_VESSEL = '" & strShip & "' AND Voyage = '" & strVoyage & "' AND BLNO = '" & strBillNo & _
                                               "' AND ( CONTAINER_NO = '" & Me.C1DBG.Columns("CONTAINER_NO").CellText(i) & "'  or CONTAINER_NO = '" & GetConOtherMode(C1DBG.Columns("CONTAINER_NO").CellText(i)) & "')"
                        dvRepeat = Filldata(sqlRepeat)
                        If dvRepeat.Count > 0 Then  '如果有重复
                            Me.C1DBG.Row = i
                            Me.C1DBG.SelectedRows().Clear()
                            Me.C1DBG.SelectedRows.Add(i)
                            MessageBox.Show("该船次提单" & strBillNo & "下已存在箱号" & Me.C1DBG.Columns("CONTAINER_NO").CellText(i) & "，不能修改", "提示")
                            Exit For
                        End If
                    End If
                Next
            End If

            '检查铅封号重复
            If blEmptyCon = False Then   '空箱不检查铅封
                Dim sqlSealCheck As String
                Dim dvSealCheck As DataView
                If i >= dsSubTable.Tables(0).Rows.Count Then
                    For i = 0 To dsSubTable.Tables(0).Rows.Count - 1    '数据库检查'可以改一下，不要循环
                        sqlSealCheck = "SELECT CHI_VESSEL, Voyage, BLNO, CONTAINER_NO,NEWSEALNO FROM CON_LOAD_TALLY_LIST WHERE " & _
                            " NEWSEALNO = '" & C1DBG.Columns("NEWSEALNO").CellText(i) & "' and CON_LOAD_TALLY_LIST_ID<>" & Me.C1DBG.Columns("CON_LOAD_TALLY_LIST_ID").CellValue(i)
                        dvSealCheck = Filldata(sqlSealCheck)
                        If dvSealCheck.Count > 0 Then  '如果有重复
                            Me.C1DBG.Row = i
                            Me.C1DBG.SelectedRows().Clear()
                            Me.C1DBG.SelectedRows.Add(i)
                            If MessageBox.Show("该封号重复,是否忽略,继续保存?", "提示", MessageBoxButtons.OKCancel) = DialogResult.Cancel Then
                                Exit For
                            End If
                        End If
                    Next
                End If
            End If

            Dim sqlBillNo As String
            Dim dvBillNo As New DataView
            If i >= Count Then
                Me.C1DBG.Focus()
                For i = 0 To Count - 1
                    strShip = Me.C1DBG.Columns("CHI_VESSEL").CellText(i)
                    strVoyage = Me.C1DBG.Columns("Voyage").CellText(i)
                    strBillNo = Me.C1DBG.Columns("blno").CellText(i)
                    If strShip <> strOldShip Or strVoyage <> strOldVoyage Or strBillNo <> strOldBillNo Then  '只查修改了船名码航次提单的箱子的本场站提单号是否存在
                        sqlBillNo = "SELECT BLNO,WORK_PLACE FROM CON_LOAD_TALLY WHERE CHI_VESSEL = '" & strShip & "' AND Voyage = '" & strVoyage & "' AND BLNO = '" & strBillNo & "' AND WORK_PLACE = '" & strYCode & "'"
                        dvBillNo = Filldata(sqlBillNo)
                        If dvBillNo.Count = 0 Then   '没有提单场站信息 加
                            Me.C1DBG.Row = i
                            Me.C1DBG.SelectedRows().Clear()
                            Me.C1DBG.SelectedRows.Add(i)

                            Dim FrmBillAdd As New FrmConLoadTallyReceipt_Add
                            FrmBillAdd.ShowDialog()
                            If FrmBillAdd.flag = False Then     '如果没有增加提单信息，退出循环，不增加箱信息

                                Exit For
                            End If
                        Else            '有提单信息,将此箱的场站代码改掉，与提单保持一致
                            Me.C1DBG.Row = i
                            Me.C1DBG.Columns("CodeYard").Text = dvBillNo(0)("WORK_PLACE")
                        End If
                    End If
                Next
                Me.btQuit.Focus()
            End If

            If i >= Count Then     '全部通过检验且增加了该加的提单
                If Count > 0 Then
                    If MessageBox.Show("确定对以上信息的修改删除么？", "警示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                        ExecSql("Exec sp_ConLoadTallyListOperPre '" & G_DeptName & "','" & Now & "','" & G_User & "'")
                        sqlSubTableda.Update(dsSubTable)
                        If rbnUsual.Checked Then    '常用信息
                            Call EditUsualBill()
                            If BillSign = False Then
                                Exit Sub
                            End If
                        Else    '全部信息
                            Dim FrmBillEdit As New FrmConLoadTallyReceipt_Edit
                            FrmBillEdit.txtShip.ReadOnly = True
                            FrmBillEdit.txtVoyage.ReadOnly = True
                            FrmBillEdit.txtBillNO.ReadOnly = True
                            FrmBillEdit.ShowDialog()
                        End If

                        '记录操作日志
                        'Dim sqlUpdateOperTemp As String
                        'sqlUpdateOperTemp = "delete from OperTemp insert into OperTemp(Dept_Name, OperateTime, OperateWorker) values('" & G_DeptName & "','" & Now & "','" & G_User & "') "
                        'ExecSql(sqlUpdateOperTemp)

                        EditMark = True
                        Call MakeCONLOADEDI(txtShip.Text.Trim(), txtVoyage.Text.Trim(), txtBillNO.Text.Trim())
                        Me.Close()
                    End If
                ElseIf dvBill.Count > 0 Then
                    If MessageBox.Show("确定删除该提单全部信息么？", "警示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                        '记录操作日志
                        ExecSql("Exec sp_ConLoadTallyListOperPre '" & G_DeptName & "','" & Now & "','" & G_User & "'")
                        sqlSubTableda.Update(dsSubTable)
                        Call OperateHistory(G_DeptName, Now, G_User, "全部删除", "CON_LOAD_TALLY", ID, "CON_LOAD_TALLY_ID")
                        Dim sqlDelBill As String
                        sqlDelBill = "delete from Con_Load_Tally where CON_LOAD_TALLY_ID=" & ID
                        ExecSql(sqlDelBill)
                        EditMark = True
                        Me.Close()
                    End If
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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

    Private Function EditNumValue(ByVal strNumColumn As String, ByVal strNumValue As String, Optional ByVal message As String = "数据") As Boolean
        Dim flag As Boolean = True
        If Trim(strNumValue) <> "" Then
            If IsNumeric(Trim(strNumValue)) Then
                dvBill(0)(strNumColumn) = Trim(strNumValue)
            Else
                MessageBox.Show(message + "应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                flag = False
            End If
        Else    '此列留空
            dvBill(0)(strNumColumn) = DBNull.Value
        End If
        Return flag
    End Function

    Private Sub EditUsualBill()
        If Me.EditNumValue("AMOUNT", txtAmount.Text, "总件数") = False Then
            txtAmount.Focus()
            Exit Sub
        ElseIf Me.EditNumValue("TotalNetWeight", txtTotalNetWeight.Text, "总净重") = False Then
            Me.txtTotalNetWeight.Focus()
            Exit Sub
        End If

        If Not IsNothing(Me.cbLoadPort.SelectedValue) Then  '港口代码能取到
            dvBill(0)("CodeLoadPort") = Me.cbLoadPort.SelectedValue
        Else
            If IsCode(Me.cbLoadPort.Text.Trim()) Then     '判断是代码的形式
                dvBill(0)("CodeLoadPort") = Trim(Me.cbLoadPort.Text.ToUpper)
            Else
                Me.cbLoadPort.Focus()
                MessageBox.Show("装货港名不能取得时，必须输入港口代码才能保存。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        If Not IsNothing(Me.cbUnloadPort.SelectedValue) Then  '港口代码能取到
            dvBill(0)("CodeUnloadPort") = Me.cbUnloadPort.SelectedValue
        Else
            If IsCode(Me.cbUnloadPort.Text.Trim()) Then     '判断是代码的形式
                dvBill(0)("CodeUnloadPort") = Trim(Me.cbUnloadPort.Text.ToUpper)
            Else
                Me.cbUnloadPort.Focus()
                MessageBox.Show("卸货港名不能取得时，必须输入港口代码才能保存。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If
        If Me.ckbInTrade.Checked Then
            dvBill(0)("TradeMark") = "1"
        Else
            dvBill(0)("TradeMark") = "0"
        End If
        dvBill(0)("CHI_VESSEL") = Me.txtNewShip.Text
        dvBill(0)("VOYAGE") = Me.txtNewVoyage.Text
        dvBill(0)("BLNO") = Me.txtNewBill.Text
        'dvBill(0)("WORK_PLACE") = cbPlace.SelectedValue

        dvBill(0)("TALLY_CLERK") = Trim(txtTallyClerk.Text)
        dvBill(0)("InOutPort") = Me.cbInOutPort.SelectedValue
        dvBill(0)("WORKTYPE") = cbWorkType.SelectedValue
        dvBill(0)("CODE_TALLY_TYPE") = cbConLoadType.SelectedValue
        dvBill(0)("TIME_FROM") = dtpTimeBegin.Value
        dvBill(0)("TIME_TO") = dtpTimeEnd.Value
        dvBill(0)("LISTDATE") = dtpListDate.Value

        dvBill(0)("MARK") = Trim(txtMark.Text).ToUpper
        dvBill(0)("GoodsCha") = ccbGoods.Text.Trim
        dvBill(0)("GoodsSpec") = Me.txtGoodsSpec.Text.Trim.ToUpper
        dvBill(0)("STATE") = Trim(cbState.Text)
        dvBill(0)("CODE_CON_CONSIGN") = ccbConsign.SelectedValue
        dvBill(0)("SIZE_MEASURE") = txtSize.Text.Trim

        'dvBill(0)("USER_NAME") = G_User

        daBill.Update(dsBill)

        BillSign = True '提单保存成功
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub btnConDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConDelete.Click
        Try
            Me.C1DBG.Delete()
            Call C1DBG_AfterDelete(sender, e)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub C1DBG_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.AfterDelete
        delSum += 1
        Me.C1DBG.Columns("CONTAINER_NO").FooterText = "合计" & Count - delSum & "箱"
        Me.C1DBG.Columns("AMOUNT").FooterText = GetDataSum(dsSubTable.Tables(0).DefaultView, "AMOUNT")
        Me.C1DBG.Columns("NetWeight").FooterText = GetDataSum(dsSubTable.Tables(0).DefaultView, "NetWeight")
        Me.C1DBG.Columns("VOLUME").FooterText = GetDataSum(dsSubTable.Tables(0).DefaultView, "VOLUME")
    End Sub

    Private Sub C1DBG_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles C1DBG.RowColChange
        If Me.C1DBG.Row <> e.LastRow Then
            Me.C1DBG.Columns("SIZE_CON").FooterText = "第" & (Me.C1DBG.Row + 1) & "行"
        End If
        'Me.C1DBG.EditDropDown = True

        If Me.C1DBG.Columns(Me.C1DBG.Col).DataField = "NEWSEALNO" Then
            '更新铅封号下拉框数据
            Dim strNewFilter As String
            strNewFilter = "User_Person='" & Me.C1DBG.Columns("Clerk").Text & "'"
            RefreshDropDownSealNo(strNewFilter)
        End If
        If Me.C1DBG.Columns(Me.C1DBG.Col).DataField = "PACK_CHA" Then
        End If
        If Me.C1DBG.Columns(Me.C1DBG.Col).DataField = "Clerk" Then
            'Me.C1DBG.Columns("Clerk").DropDown.Select()
        End If

    End Sub

    Private Sub C1DBG_AfterColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles C1DBG.AfterColEdit
        If e.Column.DataColumn.DataField = "ReeferTemp" Then '冷藏温度
            If IsNumeric(Me.C1DBG.Columns("ReeferTemp").Text) Then
                If Me.C1DBG.Columns("TempUnit").Text <> "C" AndAlso Me.C1DBG.Columns("TempUnit").Text <> "F" Then
                    Me.C1DBG.Columns("TempUnit").Text = "C"
                End If
            End If
        ElseIf e.Column.DataColumn.DataField = "TempUnit" Then '温标
            If Me.C1DBG.Columns("TempUnit").Text <> Me.C1DBG.Columns("TempUnit").Text.Trim.ToUpper Then
                Me.C1DBG.Columns("TempUnit").Text = Me.C1DBG.Columns("TempUnit").Text.Trim.ToUpper
            End If
        ElseIf e.Column.DataColumn.DataField = "CONTAINER_NO" Then
            Dim sb As New System.Text.StringBuilder
            Dim sqlCheckExist As String
            Dim dvCheckExist As DataView
            sqlCheckExist = "select Container_No,CHI_VESSEL,ShipName,Voyage,BLNO,NO,Code_Yard_Name,InputTime from View_ConLoadTally where ID<>" & ID & " and Container_No='" & Me.C1DBG.Columns("CONTAINER_NO").Text & "' and InputTime>DateAdd(dd,-31,GetDate())"
            dvCheckExist = Filldata(sqlCheckExist)
            If dvCheckExist.Count > 0 Then
                sb.Append("箱号:" & dvCheckExist(0)("Container_No") & " 近期出现过" & vbLf)
                sb.Append("船码:" & dvCheckExist(0)("CHI_VESSEL") & " ")
                sb.Append("船名:" & dvCheckExist(0)("ShipName") & " ")
                sb.Append("航次:" & dvCheckExist(0)("Voyage") & vbLf)
                sb.Append("提单:" & dvCheckExist(0)("BLNO") & " ")
                sb.Append("编号:" & dvCheckExist(0)("NO") & vbLf)
                sb.Append("部门:" & dvCheckExist(0)("Code_Yard_Name") & " ")
                sb.Append("时间:" & dvCheckExist(0)("InputTime"))
                MessageBox.Show(sb.ToString(), "提示")
            End If
        End If
        If e.ColIndex = 3 Then
            Me.C1DBG.Columns("CHI_VESSEL").Text = Me.C1DBG.Columns("CHI_VESSEL").Text.Trim.ToUpper
            sqlShipCode = "SELECT SPCODE, CHI_VESSEL,ENG_VESSEL FROM Code_SHIPNAME WHERE (SPCODE = '" & Me.C1DBG.Columns("CHI_VESSEL").Text & "' or CHI_VESSEL = '" & Me.C1DBG.Columns("CHI_VESSEL").Text & "')"
            dvShipCode = Filldata(sqlShipCode)
            Me.labShipName.Text = ""
            If dvShipCode.Count > 0 Then
                Me.C1DBG.Columns("CHI_VESSEL").Text = dvShipCode(0)("SPCODE")
                If Not IsDBNull(dvShipCode(0)("CHI_VESSEL")) Then
                    Me.labShipName.Text = dvShipCode(0)("CHI_VESSEL")
                End If
                If Not IsDBNull(dvShipCode(0)("ENG_VESSEL")) Then
                    Me.labShipName.Text += "/" & dvShipCode(0)("ENG_VESSEL")
                End If
            Else
                Me.labShipName.Text = ""
                MessageBox.Show("船码 " & Me.C1DBG.Columns("CHI_VESSEL").Text & " 不存在，请重新输入", "提示")
            End If
        End If
    End Sub

    Private Sub RefreshClerkMark()
        Dim i As Integer
        '输入数据如果不在下拉数据中，按助记码匹配 IndexOf无效 都是找不到
        If Me.C1DBG.Columns("Clerk").Text <> Me.C1DBG.Columns("Clerk").Text.Trim.ToUpper Then
            Me.C1DBG.Columns("Clerk").Text = Me.C1DBG.Columns("Clerk").Text.Trim.ToUpper
        End If
        If Me.C1DBG.Columns("Clerk").Text <> "" Then
            '匹配姓名或者助记码
            For i = 0 To dvClerk.Count - 1
                If Me.C1DBG.Columns("Clerk").Text = Convert.ToString(dvClerk(i)("Name")) Then
                    Exit For
                ElseIf Me.C1DBG.Columns("Clerk").Text = Convert.ToString(dvClerk(i)("Tally_Short")).ToUpper Then
                    Me.C1DBG.Columns("Clerk").Value = dvClerk(i)("Name")
                    Exit For
                End If
            Next
            If i < dvClerk.Count Then
                Me.C1DBG.Columns("ClerkValid").Value = DBNull.Value
            Else
                Me.C1DBG.Columns("ClerkValid").Value = -1
            End If
        Else    '不可空
            Me.C1DBG.Columns("ClerkValid").Value = -1
        End If
    End Sub

    Private Sub RefreshDropDownSealNo(ByVal strNewFilter As String)
        '刷新铅封号下拉框数据
        If dvSealNo.RowFilter <> strNewFilter Then
            dvSealNo.RowFilter = strNewFilter
            Me.C1DBG.Columns("NEWSEALNO").ValueItems.Values.Clear()
            Dim vi As C1.Win.C1TrueDBGrid.ValueItem
            Dim i As Integer
            For i = 0 To dvSealNo.Count - 1
                vi = New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = dvSealNo(i)("SealNo")
                vi.Value = dvSealNo(i)("SealNo")
                Me.C1DBG.Columns("NEWSEALNO").ValueItems.Values.Add(vi)
            Next
        End If
    End Sub

    Private Sub RefreshSealNoMark()
        If Me.C1DBG.Columns("NEWSEALNO").Text <> Me.C1DBG.Columns("NEWSEALNO").Text.Trim.ToUpper Then
            Me.C1DBG.Columns("NEWSEALNO").Text = Me.C1DBG.Columns("NEWSEALNO").Text.Trim.ToUpper
        End If
        Dim i As Integer
        If Me.C1DBG.Columns("NEWSEALNO").Text <> "" Then
            For i = 0 To dvSealNo.Count - 1
                If Me.C1DBG.Columns("NEWSEALNO").Text = Convert.ToString(dvSealNo(i)("SealNo")) Then
                    Exit For
                End If
            Next
            If i < dvSealNo.Count Then  '找到 正常 可用
                Me.C1DBG.Columns("Valid").Value = DBNull.Value
            Else    '没有找到
                Dim strFilterTemp As String
                strFilterTemp = dvSealNo.RowFilter
                dvSealNo.RowFilter = strFilterTemp.Replace("=", "<>")
                For i = 0 To dvSealNo.Count - 1
                    If Me.C1DBG.Columns("NEWSEALNO").Text = Convert.ToString(dvSealNo(i)("SealNo")) Then
                        Exit For
                    End If
                Next
                If i < dvSealNo.Count Then  '属于其他理货员所有
                    Me.C1DBG.Columns("Valid").Value = 5
                Else    '否则，要么是高保封，要么是未出库，未领用，已用，注销的
                    Dim sqlSealCheck As String
                    Dim dvSealCheck As DataView
                    sqlSealCheck = "SELECT SEALNO,SEAL_STATE,Use_Mark,Logout_Mark,B.Dept_Code,USER_PERSON FROM SEAL_RECORD A left join DepartMent B on (subString(A.Dept_Code,3,6)=B.ClerkDept or subString(A.Dept_Code,3,3)=B.ClerkDept) where SealNo='" & Me.C1DBG.Columns("NewSealNo").Text & "'"
                    dvSealCheck = Filldata(sqlSealCheck)
                    If dvSealCheck.Count > 0 Then
                        '其它部门，注销，已用，未领用，未出库。
                        Select Case dvSealCheck(0)("SEAL_STATE")
                            Case "0"    '未出库
                                Me.C1DBG.Columns("Valid").Value = 0
                            Case "1"    '未领用
                                Me.C1DBG.Columns("Valid").Value = 1
                            Case "2"
                                If dvSealCheck(0)("Use_Mark") <> "0" Then    '在用
                                    Me.C1DBG.Columns("Valid").Value = 2
                                Else
                                    If dvSealCheck(0)("Logout_Mark") <> "0" Then '注销
                                        Me.C1DBG.Columns("Valid").Value = 3
                                    Else    '领用，未注销
                                        If dvSealCheck(0)("Dept_Code") <> G_DeptCode Then '非本部所有
                                            Me.C1DBG.Columns("Valid").Value = 4
                                        Else
                                            '正常不会执行到这里的代码
                                            If dvSealCheck(0)("USER_PERSON") <> Me.C1DBG.Columns("Clerk").Text Then  '非此理货员所有
                                                Me.C1DBG.Columns("Valid").Value = 5
                                            Else
                                                '正常，本部本人可用 
                                                Me.C1DBG.Columns("Valid").Value = DBNull.Value
                                            End If
                                        End If
                                    End If
                                End If
                            Case Else
                                Exit Select
                        End Select
                    Else    '不存在，正常，应是高保封
                        Me.C1DBG.Columns("Valid").Value = -1
                    End If
                End If
                dvSealNo.RowFilter = strFilterTemp
            End If
        Else    '空则空
            Me.C1DBG.Columns("Valid").Value = DBNull.Value
        End If
    End Sub

    Private Sub C1DBG_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles C1DBG.AfterColUpdate
        If e.ColIndex = 6 Then  '箱号
            Dim sqlBeing As String = "SELECT * FROM CON_CRITERION WHERE CONTAINER_NO = '" & Me.C1DBG.Columns("CONTAINER_NO").Text.Trim.ToUpper & "' or CONTAINER_NO = '" & GetConOtherMode(Me.C1DBG.Columns("CONTAINER_NO").Text) & "'"
            Dim dvBeing As New DataView
            dvBeing = Filldata(sqlBeing)
            If dvBeing.Count >= 1 Then
                Me.C1DBG.Columns("SIZE_CON").Value = dvBeing.Item(0)("SIZE_CON")
                Me.C1DBG.Columns("CONTAINER_TYPE").Value = dvBeing.Item(0)("CONTAINER_TYPE")
            End If
        ElseIf e.Column.DataColumn.DataField = "PACK_CHA" Then
            If Me.C1DBG.Columns("PACK_CHA").Text <> "" AndAlso Me.C1DBG.Columns("PACK_CHA").Text = Me.C1DBG.Columns("PACK_CHA").Value Then
                Me.C1DBG.Columns("PACK_CHA").Text = Me.C1DBG.Columns("PACK_CHA").Text.Trim.ToUpper
                Dim i As Integer
                For i = 0 To dvPack.Count - 1   '要区分大小写 空格
                    If Me.C1DBG.Columns("PACK_CHA").Text.Trim.ToUpper = Convert.ToString(dvPack(i)("Pack_Short")) Then
                        Me.C1DBG.Columns("PACK_CHA").Value = dvPack(i)("CODE_PACK")
                        Exit For
                    End If
                Next
            End If
        ElseIf e.Column.DataColumn.DataField = "Clerk" Then
            RefreshClerkMark()
            '更新铅封号下拉框数据
            Dim strNewFilter As String
            strNewFilter = "User_Person='" & Me.C1DBG.Columns("Clerk").Text & "'"
            RefreshDropDownSealNo(strNewFilter)
        ElseIf e.Column.DataColumn.DataField = "NEWSEALNO" Then
            '如果铅封不在下拉列表即该理货员所领铅封中，则检查铅封号是否在系统铅封号中
            RefreshSealNoMark()
        ElseIf e.Column.DataColumn.DataField = "ConTime" Then
            If Me.dtpTimeEnd.Value < Me.C1DBG.Columns("ConTime").Value Then
                Me.dtpTimeEnd.Value = Me.C1DBG.Columns("ConTime").Value
            End If
        ElseIf e.Column.DataColumn.DataField = "AMOUNT" Then
            Me.C1DBG.Columns("AMOUNT").FooterText = GetDataSum(dsSubTable.Tables(0).DefaultView, "AMOUNT")
        ElseIf e.Column.DataColumn.DataField = "NetWeight" Then
            Me.C1DBG.Columns("NetWeight").FooterText = GetDataSum(dsSubTable.Tables(0).DefaultView, "NetWeight")
        ElseIf e.Column.DataColumn.DataField = "VOLUME" Then
            Me.C1DBG.Columns("VOLUME").FooterText = GetDataSum(dsSubTable.Tables(0).DefaultView, "VOLUME")
        End If
    End Sub

    Private Sub C1DBG_FetchCellStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs) Handles C1DBG.FetchCellStyle
        If e.Column.DataColumn.DataField = "Clerk" Then
            If Me.C1DBG.Columns("ClerkValid").CellText(e.Row) = "-1" Then
                e.CellStyle.BackColor = Color.Yellow
                e.CellStyle.ForeColor = Color.DarkSlateGray
            End If
        ElseIf e.Column.DataColumn.DataField = "NEWSEALNO" Then
            If Not IsDBNull(Me.C1DBG.Columns("Valid").CellValue(e.Row)) Then
                If Me.C1DBG.Columns("Valid").CellText(e.Row) = "-1" Then
                    e.CellStyle.BackColor = Color.Pink
                Else
                    e.CellStyle.BackColor = Color.Red
                End If
                e.CellStyle.ForeColor = Color.DarkSlateGray
            End If
        End If
    End Sub

    Private Sub C1DBG_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1DBG.KeyDown
        If e.KeyCode = Keys.Return And (Me.C1DBG.Col = 17 + 2 OrElse Me.C1DBG.Col = 25 + 2) Then
            Me.C1DBG.Row += 1
            Me.C1DBG.Col = 3
            SendKeys.Send("{LEFT}")
        End If
    End Sub

    Private Sub txtShip_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtShip.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtVoyage.Focus()
        End If
    End Sub

    Private Sub txtVoyage_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVoyage.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtBillNO.Focus()
        End If
    End Sub

    Private Sub txtBillNO_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBillNO.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.cbPlace.Focus()
        End If
    End Sub

    Private Sub cbPlace_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbPlace.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnGetData_Click(sender, e)
        End If
    End Sub

    Private Sub txtBillNO_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBillNO.Leave
        Me.txtBillNO.Text = Me.txtBillNO.Text.Trim.ToUpper
    End Sub

    Private Sub btnGetData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetData.Click
        strBillNo = Me.txtBillNO.Text
        strVoyage = Me.txtVoyage.Text
        strShip = Me.txtShip.Text
        strYCode = Me.cbPlace.SelectedValue
        strOldShip = strShip
        strOldVoyage = strVoyage
        strOldBillNo = strBillNo    '记录原来的船名码航次提单号
        Me.txtOldShip.Text = strShip
        Me.txtOldShipName.Text = Me.txtShipName.Text
        Me.txtOldVoyage.Text = strVoyage
        Me.txtOldBlno.Text = strBillNo
        If strBillNo <> "" And strShip <> "" And strVoyage <> "" Then
            FillBill()
            Call InitSubTable()
            Me.txtNewShip.Focus()
        End If
    End Sub

    Private Sub txtVoyage_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVoyage.Leave
        Me.txtVoyage.Text = Me.txtVoyage.Text.Trim.ToUpper
    End Sub

    Private Function GetShipName(ByVal strShipCode As String)
        Dim strShipName As String
        If strShipCode.Length > 0 Then
            Dim sqlTemp As String
            Dim dvTemp As DataView
            sqlTemp = "SELECT SPCODE,CHI_VESSEL,Eng_VESSEL FROM Code_SHIPNAME WHERE SPCODE = '" & strShipCode & "'"
            dvTemp = Filldata(sqlTemp)
            If dvTemp.Count > 0 Then
                If Not IsDBNull(dvTemp(0)("CHI_VESSEL")) Then
                    strShipName = dvTemp(0)("CHI_VESSEL")
                End If
                If Not IsDBNull(dvTemp(0)("Eng_VESSEL")) Then
                    strShipName += "/" & dvTemp(0)("Eng_VESSEL")
                End If
            End If
        End If
        Return strShipName
    End Function

    Private Sub txtShip_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtShip.Leave
        Me.txtShip.Text = Me.txtShip.Text.Trim.ToUpper
        Me.txtShipName.Text = GetShipName(Me.txtShip.Text)
    End Sub

    Private Sub txtNewShip_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNewShip.Leave
        Me.txtNewShip.Text = Me.txtNewShip.Text.Trim.ToUpper
        Me.txtNewShipName.Text = GetShipName(Me.txtNewShip.Text)
    End Sub

    Private Sub FrmConLoadTallyNew_Edit_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        strBillNo = Nothing
    End Sub

    Private Sub FrmConLoadTallyNew_Add_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtNewShip.Focused Then
                Me.txtNewVoyage.Focus()
            ElseIf Me.txtNewVoyage.Focused Then
                Me.txtNewBill.Focus()
            ElseIf Me.txtNewBill.Focused Then
                Me.txtMark.Focus()
            ElseIf Me.txtNO.Focused Then
                Me.txtMark.Focus()
            ElseIf Me.txtMark.Focused Then
                Me.ccbGoods.Focus()
            ElseIf Me.ccbGoods.Focused Then
                Me.txtGoodsSpec.Focus()
            ElseIf Me.txtGoodsSpec.Focused Then
                Me.txtAmount.Focus()
            ElseIf Me.txtAmount.Focused Then
                Me.txtTotalNetWeight.Focus()
            ElseIf Me.txtTotalNetWeight.Focused Then
                Me.txtSize.Focus()
            ElseIf Me.txtSize.Focused Then
                Me.cbState.Focus()
            ElseIf Me.cbState.Focused Then
                Me.ccbConsign.Focus()
            ElseIf Me.ccbConsign.Focused Then
                cbInOutPort.Focus()
            ElseIf Me.cbInOutPort.Focused Then
                Me.cbLoadPort.Focus()
            ElseIf Me.cbLoadPort.Focused Then
                Me.cbUnloadPort.Focus()
            ElseIf Me.cbUnloadPort.Focused Then
                Me.cbWorkType.Focus()
            ElseIf Me.cbWorkType.Focused Then
                Me.cbConLoadType.Focus()
            ElseIf Me.cbConLoadType.Focused Then
                Me.dtpTimeBegin.Focus()
            ElseIf Me.dtpTimeBegin.Focused Then
                Me.dtpListDate.Focus()
            ElseIf Me.dtpListDate.Focused Then
                Me.ckbInTrade.Focus()
            ElseIf Me.ckbInTrade.Focused Then
                Me.C1DBG.Focus()
            End If
        End If
    End Sub

    Private Sub MakeCONLOADEDI(ByVal CVessel As String, ByVal Voyage As String, ByVal BLNO As String)
        On Error GoTo Err
        Dim FilePath As String
        Dim str As String
        Dim PathStr As String

        Dim sqlstr As String
        Dim strFile As String
        Dim txtline As String
        Dim ShipOwner As String
        Dim s As String
        Dim dss As New DataSet
        Dim dsm As New DataSet
        Dim dst As New DataSet
        Dim i As Integer = 0 '记录行数
        Dim j As Integer
        Dim k As Integer
        Dim nnnn As String
        Dim Pack As String
        Dim TallyType As String
        Dim Temp As String
        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)

        FilePath = PathStr + "EDIINI.INI"
        Dim sr As New StreamReader(FilePath) '打开报文文件
        FilePath = sr.ReadLine()
        sr.Close()

        '*****************************************报文开始
        strFile = FilePath & UCase(CVessel) & UCase(Voyage) & UCase(BLNO) & "4.txt"
        File.Delete(strFile)
        Dim sw As New StreamWriter(strFile, FileMode.OpenOrCreate) '打开报文文件
        txtline = "00:COSTCO:CONTAINER LOADING LIST:4:LYGWL:LYGXDF:" & Trim(CType(Year(Now), String))
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
        txtline = "10:" & UCase(CVessel) & "::" & UCase(Voyage) & "::::'"
        sw.WriteLine(txtline)
        i = 2
        j = 1
        TallyType = ""
        sqlstr = "select DISTINCT BLNO,CODE_TALLY_TYPE  from CON_LOAD_TALLY where CHI_VESSEL='" & Trim(CVessel) & "' and VOYAGE='" & Trim(Voyage) & "' and BLNO='" & Trim(BLNO) & "'"
        dss.Reset()
        If Getdata(sqlstr, dss).Count > 0 Then
            If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("CODE_TALLY_TYPE")) Then
                If Trim(dss.Tables(0).Rows(j - 1).Item("CODE_TALLY_TYPE")).Length() > 0 Then
                    If Trim(dss.Tables(0).Rows(j - 1).Item("CODE_TALLY_TYPE")) = "4" Then
                        TallyType = "E"
                    ElseIf Trim(dss.Tables(0).Rows(j - 1).Item("CODE_TALLY_TYPE")) = "2" Then
                        TallyType = "L"
                    Else
                        TallyType = "F"
                    End If
                End If
            Else
                TallyType = "F"
            End If
        Else
            TallyType = "F"
        End If
        '*******************************50
        Pack = ""
        sqlstr = "select DISTINCT CONTAINER_NO,SIZE_CON,PACK_CHA,CONTAINER_TYPE,FULLOREMPTY,CheckTime,NEWSEALNO  from CON_LOAD_TALLY_LIST where CHI_VESSEL='" & Trim(CVessel) & "' and VOYAGE='" & Trim(Voyage) & "' and BLNO='" & Trim(BLNO) & "' ORDER BY CONTAINER_NO"
        dsm.Reset()
        If Getdata(sqlstr, dsm).Count > 0 Then
            nnnn = ""
            Do While j <= dsm.Tables(0).Rows.Count
                If Trim(dsm.Tables(0).Rows(j - 1).Item("CONTAINER_NO")) <> nnnn Then
                    txtline = "50:" & Trim(dsm.Tables(0).Rows(j - 1).Item("CONTAINER_NO")) & ":"
                    txtline = txtline & Trim(dsm.Tables(0).Rows(j - 1).Item("SIZE_CON"))
                    txtline = txtline & Trim(dsm.Tables(0).Rows(j - 1).Item("CONTAINER_TYPE"))
                    If Not IsDBNull(TallyType) Then
                        If Trim(TallyType).Length() > 0 Then
                            txtline = txtline & ":" & Trim(TallyType) & ":0:"
                        Else

                            txtline = txtline & "::0:"
                        End If
                    Else
                        txtline = txtline & "::0:"
                    End If
                    txtline = txtline & Trim(CType(Year(dsm.Tables(0).Rows(j - 1).Item("CheckTime")), String))
                    s = Mid("0" & Trim(CType(Month(dsm.Tables(0).Rows(j - 1).Item("CheckTime")), String)), Len("0" & Trim(CType(Month(dsm.Tables(0).Rows(j - 1).Item("CheckTime")), String))) - 1, 2)
                    txtline = txtline & s
                    s = Mid("0" & Trim(CType(Day(dsm.Tables(0).Rows(j - 1).Item("CheckTime")), String)), Len("0" & Trim(CType(Day(dsm.Tables(0).Rows(j - 1).Item("CheckTime")), String))) - 1, 2)
                    txtline = txtline & s
                    s = Mid("0" & Trim(CType(Hour(dsm.Tables(0).Rows(j - 1).Item("CheckTime")), String)), Len("0" & Trim(CType(Hour(dsm.Tables(0).Rows(j - 1).Item("CheckTime")), String))) - 1, 2)
                    txtline = txtline & s
                    s = Mid("0" & Trim(CType(Minute(dsm.Tables(0).Rows(j - 1).Item("CheckTime")), String)), Len("0" & Trim(CType(Minute(dsm.Tables(0).Rows(j - 1).Item("CheckTime")), String))) - 1, 2)
                    txtline = txtline & s
                    txtline = txtline & ":" & Trim(dss.Tables(0).Rows(j - 1).Item("NEWSEALNO")) & ":"
                    txtline = txtline & ":" '& Trim(dss.Tables(0).Rows(j - 1).Item("CODE_KEEPER"))
                    txtline = txtline & "::::::'"
                    sw.WriteLine(txtline)
                    i = i + 1
                    nnnn = Trim(dsm.Tables(0).Rows(j - 1).Item("CONTAINER_NO"))
                End If
                If Trim(dsm.Tables(0).Rows(j - 1).Item("PACK_CHA")).Length > 0 Then
                    Pack = Trim(dsm.Tables(0).Rows(j - 1).Item("PACK_CHA"))
                End If
                j = j + 1
            Loop
        End If
        '***************************** 提单循环
        sqlstr = "select DISTINCT BLNO,AMOUNT,TOTALNETWEIGHT,SIZE_MEASURE,GOODSCHA,REEFERTEMP,TEMPUNIT,MARK,DANGERGRADE,DANGERMARK,CODELOADPORT,CODEUNLOADPORT,CODEDELIVERY  from CON_LOAD_TALLY where CHI_VESSEL='" & Trim(CVessel) & "' and VOYAGE='" & Trim(Voyage) & "' and BLNO='" & Trim(BLNO) & "'"
        dss.Reset()
        If Getdata(sqlstr, dss).Count > 0 Then
            j = 1
            Do While j <= dss.Tables(0).Rows.Count
                '************************************51
                txtline = "51:" & Trim(dss.Tables(0).Rows(j - 1).Item("BLNO"))

                txtline = txtline & ":"
                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("CODEUNLOADPORT")) Then
                    If Trim(dss.Tables(0).Rows(j - 1).Item("CODEUNLOADPORT")).Length() > 0 Then
                        txtline = txtline & Trim(dss.Tables(0).Rows(j - 1).Item("CODEUNLOADPORT")) & ":" & FindPort(Trim(dss.Tables(0).Rows(j - 1).Item("CODEUNLOADPORT"))) & ":"
                    Else
                        txtline = txtline & "::"
                    End If
                Else
                    txtline = txtline & "::"
                End If
                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("CODELOADPORT")) Then
                    If Trim(dss.Tables(0).Rows(j - 1).Item("CODELOADPORT")).Length() > 0 Then
                        txtline = txtline & Trim(dss.Tables(0).Rows(j - 1).Item("CODELOADPORT")) & ":" & FindPort(Trim(dss.Tables(0).Rows(j - 1).Item("CODELOADPORT"))) & ":"
                    Else
                        txtline = txtline & "::"
                    End If
                Else
                    txtline = txtline & "::"
                End If
                txtline = txtline & "::"
                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("CODEDELIVERY")) Then
                    If Trim(dss.Tables(0).Rows(j - 1).Item("CODEDELIVERY")).Length() > 0 Then
                        txtline = txtline & Trim(dss.Tables(0).Rows(j - 1).Item("CODEDELIVERY")) & ":" & FindPort(Trim(dss.Tables(0).Rows(j - 1).Item("CODEDELIVERY")))
                    Else
                        txtline = txtline & "::"
                    End If
                Else
                    txtline = txtline & "::"
                End If

                txtline = txtline & "'"
                sw.WriteLine(txtline)
                i = i + 1
                '************************************52
                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("AMOUNT")) Then
                    txtline = "52:" & j.ToString() & ":" & Trim(dss.Tables(0).Rows(j - 1).Item("AMOUNT")) & "::" & Trim(Pack) & ":"
                Else
                    txtline = "52:" & j.ToString() & ":::" & Trim(Pack) & ":"
                End If
                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("TOTALNETWEIGHT")) Then
                    If Trim(dss.Tables(0).Rows(j - 1).Item("TOTALNETWEIGHT")).Length() > 0 Then
                        txtline = txtline & Trim(CType(dss.Tables(0).Rows(j - 1).Item("TOTALNETWEIGHT"), Single).ToString()) & ":"
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

                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("TEMPUNIT")) Then
                    If Trim(dss.Tables(0).Rows(j - 1).Item("TEMPUNIT")).Length() > 0 Then
                        'If dss.Tables(0).Rows(j - 1).Item("Refrigerate_Temperature") <> 0 Then
                        '要零上温度加正号
                        Dim strTemp As String
                        strTemp = dss.Tables(0).Rows(j - 1).Item("REEFERTEMP")
                        If strTemp Like "#*" Then
                            strTemp = "+" & strTemp
                        End If
                        txtline = txtline & Trim(dss.Tables(0).Rows(j - 1).Item("TEMPUNIT")) & ":" & strTemp & "::'"
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
                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("GOODSCHA")) Then

                    txtline = "53" '& Trim(dss.Tables(0).Rows(j - 1).Item("GOODSCHA")) & "'"
                    Temp = Trim(dss.Tables(0).Rows(j - 1).Item("GOODSCHA"))
                    Do While Temp.Length > 70
                        txtline = txtline & ":" & Mid(Temp, 1, 70)
                        Temp = Mid(Temp, 71)
                    Loop
                    txtline = txtline & ":" & Temp & "'"
                Else
                    txtline = "53:'"
                End If
                sw.WriteLine(txtline)
                i = i + 1
                '************************************54
                If Not IsDBNull(dss.Tables(0).Rows(j - 1).Item("MARK")) Then
                    txtline = "54:" ' & Trim(dss.Tables(0).Rows(j - 1).Item("MARK")) & "'"
                    Temp = Trim(dss.Tables(0).Rows(j - 1).Item("MARK"))
                    Do While Temp.Length > 70
                        txtline = txtline & ":" & Mid(Temp, 1, 70)
                        Temp = Mid(Temp, 71)
                    Loop
                    txtline = txtline & ":" & Temp & "'"
                Else
                    txtline = "54:'"
                End If
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
                sqlstr = "select CONTAINER_NO,SIZE_CON,AMOUNT,WEIGHT,NETWEIGHT,VOLUME from CON_LOAD_TALLY_LIST where CHI_VESSEL='" & Trim(CVessel) & "' and VOYAGE='" & Trim(Voyage) & "' and BLNO='" & Trim(BLNO) & "' ORDER BY CONTAINER_NO"
                If Getdata(sqlstr, dst).Count > 0 Then
                    k = 1
                    Do While k <= dst.Tables(0).Rows.Count
                        txtline = "56:" & Trim(dst.Tables(0).Rows(k - 1).Item("CONTAINER_NO")) & ":"
                        If Not IsDBNull(dst.Tables(0).Rows(k - 1).Item("AMOUNT")) Then
                            If Trim(dst.Tables(0).Rows(k - 1).Item("AMOUNT")).Length() > 0 Then
                                txtline = txtline & Trim(dst.Tables(0).Rows(k - 1).Item("AMOUNT")) & ":"
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
                        If Not IsDBNull(dst.Tables(0).Rows(k - 1).Item("NETWEIGHT")) Then
                            If Trim(dst.Tables(0).Rows(k - 1).Item("NETWEIGHT")).Length() > 0 Then
                                txtline = txtline & Trim(CType(dst.Tables(0).Rows(k - 1).Item("NETWEIGHT"), Single).ToString()) & ":"
                            Else
                                txtline = txtline & ":"
                            End If
                        Else
                            txtline = txtline & ":"
                        End If


                        If Not IsDBNull(dst.Tables(0).Rows(k - 1).Item("VOLUME")) Then
                            If Trim(dst.Tables(0).Rows(k - 1).Item("VOLUME")).Length() > 0 Then
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

                j = dss.Tables(0).Rows.Count + 1
            Loop

        End If
        txtline = "99:" & i + 1 & "'"
        sw.WriteLine(txtline)
        MsgBox("报文已生成完毕，共 " & i + 1 & " 行 ")
        sw.Close()
        Exit Sub
Err:
        'MsgBox("报文生成出错在：" & Trim(dss.Tables(0).Rows(j - 1).Item("CONTAINER_NO")))
        Resume Next


    End Sub
    Private Function FindPort(ByVal Port As String) As String
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
    End Function

    Private Sub ccbConsign_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ccbConsign.Leave
        If dvConsign.RowFilter <> "" Then
            Dim strValue As String
            If Me.ccbConsign.SelectedIndex = -1 Then
                Me.ccbConsign.Text = Me.ccbConsign.Text.Trim.ToUpper    '这个赋值语句必须在RowFilter之前写，否则会导致RowFilter还原
            End If
            strValue = Me.ccbConsign.Text   '必须在修改RowFilter之前，因为修改RowFilter将令SelectedIndex为-1
            dvConsign.RowFilter = ""
            Me.ccbConsign.Text = strValue
            If Me.ccbConsign.SelectedIndex < 0 Then
                Dim i As Integer
                i = Me.ccbConsign.FindString(Me.ccbConsign.Text, 0, "SHIPAGENT_ENG")
                Me.ccbConsign.SelectedIndex = i
            End If
        Else
            If Me.ccbConsign.SelectedIndex = -1 Then
                Me.ccbConsign.Text = Me.ccbConsign.Text.Trim.ToUpper
                If Me.ccbConsign.SelectedIndex < 0 Then
                    Dim i As Integer
                    'For i = 0 To dvConsign.Count - 1
                    '    If Me.ccbConsign.Text = Me.ccbConsign.Columns("SHIPAGENT_ENG").CellText(i) Then
                    '        '下面三个方法都可以。C1的控件就是好用，取第二种，写法简洁并和MS的方法兼容
                    '        'Me.ccbConsign.Row = i
                    '        Me.ccbConsign.SelectedIndex = i
                    '        'Me.ccbConsign.SelectedValue = Me.ccbConsign.Columns("CODE_SHIP_AGENT").CellText(i)
                    '    End If
                    'Next
                    'C1的Combox的FindString方法可以和不同字段匹配，这就好了，不需要写循环了
                    i = Me.ccbConsign.FindString(Me.ccbConsign.Text, 0, "SHIPAGENT_ENG")
                    Me.ccbConsign.SelectedIndex = i
                End If
            End If
        End If
    End Sub

    Private Sub ccbConsign_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ccbConsign.TextChanged
        If Me.ccbConsign.SelectedIndex < 0 Then
            If Me.ccbConsign.Text Like "[a-zA-Z]*" Then
                dvConsign.RowFilter = "SHIPAGENT_ENG like '" & Me.ccbConsign.Text.Trim.ToUpper & "%'"
            Else
                dvConsign.RowFilter = ""
            End If
        End If
    End Sub

    Private Sub cbLoadPort_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbLoadPort.Leave
        If Me.cbLoadPort.SelectedIndex < 0 Then
            Me.cbLoadPort.Text = Me.cbLoadPort.Text.Trim.ToUpper
            If Me.cbLoadPort.SelectedIndex < 0 Then
                Dim i As Integer
                For i = 0 To dvLoadPort.Count - 1
                    If Me.cbLoadPort.Text = Convert.ToString(dvLoadPort(i)("CODE_PORT")) Then
                        Me.cbLoadPort.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub cbUnloadPort_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbUnloadPort.Leave
        If Me.cbUnloadPort.SelectedIndex < 0 Then
            Me.cbUnloadPort.Text = Me.cbUnloadPort.Text.Trim.ToUpper
            If Me.cbUnloadPort.SelectedIndex < 0 Then
                Dim i As Integer
                For i = 0 To dvUnloadPort.Count - 1
                    If Me.cbUnloadPort.Text = Convert.ToString(dvUnloadPort(i)("CODE_PORT")) Then
                        Me.cbUnloadPort.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub FrmConLoadTallyNew_Edit_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        If sender Is Me.txtNewShip Then
            Me.txtNewShip.Text = Me.txtNewShip.Text.Trim.ToUpper
        ElseIf sender Is Me.txtNewVoyage Then
            Me.txtNewVoyage.Text = Me.txtNewVoyage.Text.Trim.ToUpper
        ElseIf sender Is Me.txtNewBill Then
            Me.txtNewBill.Text = Me.txtNewBill.Text.Trim.ToUpper
        End If
    End Sub

    Public Enum Oper
        None
        Edit
        Save
        Print
    End Enum
    Dim excelOper As Oper = Oper.None   '操作名

    Private Sub btnExportEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportEdit.Click
        excelOper = Oper.Edit
        DealExcel()
        GC.Collect()
    End Sub

    Private Sub btnExportSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportSave.Click
        excelOper = Oper.Save
        DealExcel()
        GC.Collect()
    End Sub

    Dim PathStr As String = System.Reflection.Assembly.GetExecutingAssembly.Location
    Private Sub DealExcel()
        Dim xlApp As Excel.Application
        xlApp = New Excel.ApplicationClass
        Try
            Dim xlBook As Excel.Workbook
            Dim xlSheet As Excel.Worksheet
            PathStr = substr(PathStr)
            'DealReport
            DealReport(xlApp, xlBook, xlSheet)

            If excelOper = Oper.Edit Then   '导出编辑
                xlApp.Visible = True
            ElseIf excelOper = Oper.Save Then '导出保存
                Dim sfDialog As SaveFileDialog = New SaveFileDialog
                sfDialog.FileName = ""
                sfDialog.InitialDirectory = PathStr & "report\"
                If System.IO.Directory.Exists(sfDialog.InitialDirectory) = False Then
                    System.IO.Directory.CreateDirectory(sfDialog.InitialDirectory)
                End If
                sfDialog.RestoreDirectory = True
                sfDialog.AddExtension = True
                sfDialog.DefaultExt = ".xls"
                sfDialog.Filter = "Excel文件(*.xls)|*.xls"
                If sfDialog.ShowDialog() = DialogResult.OK Then
                    xlBook.SaveCopyAs(sfDialog.FileName)
                End If
                xlBook.Close(False, Type.Missing, Type.Missing) '关闭工作簿
                xlApp.Quit()
            ElseIf excelOper = Oper.Print Then '打印
                xlSheet.PrintOut(1, Type.Missing, 1, False, Type.Missing, Type.Missing, Type.Missing, Type.Missing)
                xlBook.Close(False, Type.Missing, Type.Missing) '关闭工作簿
                xlApp.Quit()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            xlApp.DisplayAlerts = False
            xlApp.Quit()
        End Try
    End Sub

    Private Sub DealReport(ByRef xlApp As Excel.Application, ByRef xlBook As Excel.Workbook, ByRef xlSheet As Excel.Worksheet)
        Dim i, j As Integer
        Dim dvSubTable As DataView = dsSubTable.Tables(0).DefaultView
        Me.cbPlace.SelectedValue = strYCode
        Me.cbWorkType.SelectedValue = dvBill(0)("WORKTYPE")
        Me.ccbGoods.Text = dvBill(0)("GoodsCha").ToString
        Me.dtpTimeBegin.Value = dvBill(0)("TIME_FROM")
        For i = 0 To dvSubTable.Count - 1
            '结束时间为最后作业箱时间
            If Not IsDBNull(Me.C1DBG.Columns("ConTime").CellValue(i)) Then
                If Me.dtpTimeEnd.Value < Me.C1DBG.Columns("ConTime").CellValue(i) Then
                    Me.dtpTimeEnd.Value = Me.C1DBG.Columns("ConTime").CellValue(i)
                End If
            End If
        Next

        Dim strExcelName As String = "装拆箱理货单.xls"
        Dim strPath As String = PathStr & strExcelName
        Dim strSheetName As String = "装拆箱理货单"
        xlBook = xlApp.Workbooks.Add(strPath)
        'xlBook = xlApp.Workbooks.Open(strPath)  'Open,Add之别。Open是打开原有的文件，Add是新建一个副本。还是用Add为好
        'xlBook = xlApp.Workbooks.Item(strExcelName)
        'xlBook = xlApp.Workbooks(0) '这种写法不对，要用xls名称
        'xlSheet=(Excel.Worksheet)xlBook.Worksheets(strSheetName)
        Dim iMaxPage As Integer = 10     '最大页数
        Dim iRowNum As Integer = 20     '最大行数
        Dim iFactPage As Integer    '实际页数
        Dim iFactRow As Integer     '实际行数
        If dvSubTable.Count <= iMaxPage * iRowNum Then
            iFactPage = Fix((dvSubTable.Count - 1) / iRowNum) + 1
        Else
            iFactPage = iMaxPage
            MessageBox.Show("记录超过" & iMaxPage * iRowNum & "条部分无法导出", "提示")
        End If

        For j = 0 To iFactPage - 1
            xlSheet = xlBook.Worksheets(strSheetName & (j + 1))
            xlSheet.Activate()
            xlSheet.Cells(3, "B") = Me.txtNewShipName.Text.Substring(0, Me.txtNewShipName.Text.IndexOf("/"))
            xlSheet.Cells(3, "I") = Me.txtNewVoyage.Text
            xlSheet.Cells(3, "P") = Me.txtNO.Text
            xlSheet.Cells(4, "B") = Me.txtNewBill.Text
            xlSheet.Cells(4, "P") = Me.cbPlace.Text
            xlSheet.Cells(5, "P") = Me.cbWorkType.Text
            xlSheet.Cells(6, "M") = Me.ccbGoods.Text
            xlSheet.Cells(5, "D") = Me.dtpTimeBegin.Value.ToString("yyyy年MM月dd日 HH时mm分")
            xlSheet.Cells(6, "D") = Me.dtpTimeEnd.Value.ToString("yyyy年MM月dd日 HH时mm分")
            Dim sum20, sum40, sumElse As Integer
            sum20 = 0   'VB中必须清零，否则下个循环将会累加
            sum40 = 0
            sumElse = 0
            Dim rowStart As Integer = 10 'Excel中循环起始行位置   
            If j < iFactPage - 1 Then
                iFactRow = iRowNum
            Else
                iFactRow = dvSubTable.Count - iRowNum * (iFactPage - 1)
            End If
            For i = 0 To iFactRow - 1
                xlSheet.Cells(rowStart + i, "A") = Me.C1DBG.Columns("CONTAINER_NO").CellText(i + j * iRowNum)
                xlSheet.Cells(rowStart + i, "B") = Me.C1DBG.Columns("SIZE_CON").CellText(i + j * iRowNum) & C1DBG.Columns("CONTAINER_TYPE").CellText(i + j * iRowNum)
                xlSheet.Cells(rowStart + i, "C") = Me.C1DBG.Columns("NEWSEALNO").CellText(i + j * iRowNum)
                'xlSheet.Cells(rowStart + i, "F") = Me.C1DBG.Columns("CONTAINER_NO").CellText(i)
                xlSheet.Cells(rowStart + i, "I") = Me.C1DBG.Columns("PACK_CHA").CellText(i + j * iRowNum)
                'xlSheet.Cells(rowStart + i, "J") = Me.C1DBG.Columns("CONTAINER_NO").CellText(i)
                xlSheet.Cells(rowStart + i, "K") = Me.C1DBG.Columns("AMOUNT").CellText(i + j * iRowNum)
                xlSheet.Cells(rowStart + i, "N") = Me.C1DBG.Columns("NetWeight").CellText(i + j * iRowNum)
                xlSheet.Cells(rowStart + i, "Q") = Me.C1DBG.Columns("Clerk").CellText(i + j * iRowNum)
                Select Case Me.C1DBG.Columns("SIZE_CON").CellText(i + j * iRowNum)
                    Case "20"
                        sum20 += 1
                    Case "40"
                        sum40 += 1
                    Case Else
                        sumElse += 1
                End Select
            Next
            xlSheet.Cells(30, "B") = sum20
            xlSheet.Cells(30, "D") = sum40
            xlSheet.Cells(30, "F") = sumElse
        Next
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
End Class
