Imports TALLY.DBControl
Imports System.IO
Imports VBMethod = Microsoft.VisualBasic
Public Class FrmConLoadTally_Extract
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        AddHandler txtShip.KeyDown, AddressOf FrmConLoadTally_Extract_KeyDown
        AddHandler txtVoyage.KeyDown, AddressOf FrmConLoadTally_Extract_KeyDown
        AddHandler txtContainer.KeyDown, AddressOf FrmConLoadTally_Extract_KeyDown
        AddHandler txtMyShip.KeyDown, AddressOf FrmConLoadTally_Extract_KeyDown
        AddHandler txtMyVoyage.KeyDown, AddressOf FrmConLoadTally_Extract_KeyDown
        AddHandler txtConSize.KeyDown, AddressOf FrmConLoadTally_Extract_KeyDown
        AddHandler txtConType.KeyDown, AddressOf FrmConLoadTally_Extract_KeyDown
        AddHandler txtState.KeyDown, AddressOf FrmConLoadTally_Extract_KeyDown
        AddHandler txtSealNo.KeyDown, AddressOf FrmConLoadTally_Extract_KeyDown
        AddHandler dtpLoadDate.KeyDown, AddressOf FrmConLoadTally_Extract_KeyDown
        AddHandler txtConOperCode.KeyDown, AddressOf FrmConLoadTally_Extract_KeyDown
        AddHandler txtConOper.KeyDown, AddressOf FrmConLoadTally_Extract_KeyDown
        AddHandler txtFront.KeyDown, AddressOf FrmConLoadTally_Extract_KeyDown
        AddHandler txtBack.KeyDown, AddressOf FrmConLoadTally_Extract_KeyDown
        AddHandler txtLeft.KeyDown, AddressOf FrmConLoadTally_Extract_KeyDown
        AddHandler txtRight.KeyDown, AddressOf FrmConLoadTally_Extract_KeyDown
        AddHandler txtTop.KeyDown, AddressOf FrmConLoadTally_Extract_KeyDown
        AddHandler txtAmount.KeyDown, AddressOf FrmConLoadTally_Extract_KeyDown
        AddHandler txtTareWeight.KeyDown, AddressOf FrmConLoadTally_Extract_KeyDown
        AddHandler txtNetWeight.KeyDown, AddressOf FrmConLoadTally_Extract_KeyDown
        AddHandler txtMeasure.KeyDown, AddressOf FrmConLoadTally_Extract_KeyDown
        AddHandler txtDamageAmount.KeyDown, AddressOf FrmConLoadTally_Extract_KeyDown
        AddHandler txtDamageDesc.KeyDown, AddressOf FrmConLoadTally_Extract_KeyDown
        AddHandler txtSecSealNo.KeyDown, AddressOf FrmConLoadTally_Extract_KeyDown
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtShip As System.Windows.Forms.TextBox
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents txtContainer As System.Windows.Forms.TextBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtConType As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtConSize As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSealNo As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpLoadDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbPlace As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents C1Goods As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1Relation As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents C1Bill As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents cbConLoadType As System.Windows.Forms.ComboBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents cbState As System.Windows.Forms.ComboBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents cbDescribe As System.Windows.Forms.ComboBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents txtMeasure As System.Windows.Forms.TextBox
    Friend WithEvents txtNetWeight As System.Windows.Forms.TextBox
    Friend WithEvents txtTareWeight As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtTop As System.Windows.Forms.TextBox
    Friend WithEvents txtRight As System.Windows.Forms.TextBox
    Friend WithEvents txtLeft As System.Windows.Forms.TextBox
    Friend WithEvents txtFront As System.Windows.Forms.TextBox
    Friend WithEvents txtBack As System.Windows.Forms.TextBox
    Friend WithEvents txtConOper As System.Windows.Forms.TextBox
    Friend WithEvents txtConOperCode As System.Windows.Forms.TextBox
    Friend WithEvents txtDamageDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtDamageAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtSecSealNo As System.Windows.Forms.TextBox
    Friend WithEvents txtOpenSealReason As System.Windows.Forms.TextBox
    Friend WithEvents lbShow As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCreateReport As System.Windows.Forms.Button
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents lbShip As System.Windows.Forms.Label
    Friend WithEvents lbShipName As System.Windows.Forms.Label
    Friend WithEvents lbVoyage As System.Windows.Forms.Label
    Friend WithEvents lbOuter As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents lbContainer As System.Windows.Forms.Label
    Friend WithEvents txtGoodsSpec As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents ccbGoods As C1.Win.C1List.C1Combo
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents C1MyBill As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMyShip As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents txtMyVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents btnMyFind As System.Windows.Forms.Button
    Friend WithEvents txtMyShipName As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lbMyContainer As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents lbYard As System.Windows.Forms.Label
    Friend WithEvents ckbReImportBill As System.Windows.Forms.CheckBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents lbCheck As System.Windows.Forms.Label
    Friend WithEvents cbPlace2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents txtVehicle As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConLoadTally_Extract))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtShip = New System.Windows.Forms.TextBox
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtContainer = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnFind = New System.Windows.Forms.Button
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.txtSealNo = New System.Windows.Forms.TextBox
        Me.txtConOper = New System.Windows.Forms.TextBox
        Me.txtConOperCode = New System.Windows.Forms.TextBox
        Me.lbContainer = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.lbVoyage = New System.Windows.Forms.Label
        Me.lbShipName = New System.Windows.Forms.Label
        Me.lbShip = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtTareWeight = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtMeasure = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtNetWeight = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtTop = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtRight = New System.Windows.Forms.TextBox
        Me.txtLeft = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtFront = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtBack = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtState = New System.Windows.Forms.TextBox
        Me.txtConType = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtConSize = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.dtpLoadDate = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbOuter = New System.Windows.Forms.Label
        Me.cbPlace = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.C1Goods = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1Relation = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.C1Bill = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.txtDamageDesc = New System.Windows.Forms.TextBox
        Me.txtDamageAmount = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtSecSealNo = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.txtOpenSealReason = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.lbShow = New System.Windows.Forms.Label
        Me.cbConLoadType = New System.Windows.Forms.ComboBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.cbState = New System.Windows.Forms.ComboBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.cbDescribe = New System.Windows.Forms.ComboBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label56 = New System.Windows.Forms.Label
        Me.txtVehicle = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label42 = New System.Windows.Forms.Label
        Me.ccbGoods = New C1.Win.C1List.C1Combo
        Me.Label40 = New System.Windows.Forms.Label
        Me.txtGoodsSpec = New System.Windows.Forms.TextBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCreateReport = New System.Windows.Forms.Button
        Me.btnImport = New System.Windows.Forms.Button
        Me.ckbReImportBill = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.C1MyBill = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label43 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cbPlace2 = New System.Windows.Forms.ComboBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.lbMyContainer = New System.Windows.Forms.Label
        Me.txtMyShip = New System.Windows.Forms.TextBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.txtMyVoyage = New System.Windows.Forms.TextBox
        Me.Label46 = New System.Windows.Forms.Label
        Me.btnMyFind = New System.Windows.Forms.Button
        Me.txtMyShipName = New System.Windows.Forms.TextBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.lbYard = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.lbCheck = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.Panel1.SuspendLayout()
        CType(Me.C1Goods, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Relation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Bill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ccbGoods, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1MyBill, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(214, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "船码"
        '
        'txtShip
        '
        Me.txtShip.Location = New System.Drawing.Point(246, 16)
        Me.txtShip.Name = "txtShip"
        Me.txtShip.Size = New System.Drawing.Size(76, 21)
        Me.txtShip.TabIndex = 2
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(494, 16)
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.Size = New System.Drawing.Size(100, 21)
        Me.txtVoyage.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(462, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "航次"
        '
        'txtContainer
        '
        Me.txtContainer.Location = New System.Drawing.Point(38, 16)
        Me.txtContainer.Name = "txtContainer"
        Me.txtContainer.Size = New System.Drawing.Size(100, 21)
        Me.txtContainer.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(6, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "箱号"
        '
        'btnFind
        '
        Me.btnFind.BackColor = System.Drawing.SystemColors.Control
        Me.btnFind.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnFind.Location = New System.Drawing.Point(146, 16)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(60, 22)
        Me.btnFind.TabIndex = 1
        Me.btnFind.Text = "查找"
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'txtShipName
        '
        Me.txtShipName.Location = New System.Drawing.Point(358, 16)
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.ReadOnly = True
        Me.txtShipName.Size = New System.Drawing.Size(100, 21)
        Me.txtShipName.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(326, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "船名"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtAmount)
        Me.Panel1.Controls.Add(Me.txtSealNo)
        Me.Panel1.Controls.Add(Me.txtConOper)
        Me.Panel1.Controls.Add(Me.txtConOperCode)
        Me.Panel1.Controls.Add(Me.lbContainer)
        Me.Panel1.Controls.Add(Me.Label41)
        Me.Panel1.Controls.Add(Me.lbVoyage)
        Me.Panel1.Controls.Add(Me.lbShipName)
        Me.Panel1.Controls.Add(Me.lbShip)
        Me.Panel1.Controls.Add(Me.Label39)
        Me.Panel1.Controls.Add(Me.Label33)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.txtTareWeight)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.txtMeasure)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.txtNetWeight)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.txtTop)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.txtRight)
        Me.Panel1.Controls.Add(Me.txtLeft)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtFront)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.txtBack)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtState)
        Me.Panel1.Controls.Add(Me.txtConType)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtConSize)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label35)
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Location = New System.Drawing.Point(4, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(828, 164)
        Me.Panel1.TabIndex = 7
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(222, 136)
        Me.txtAmount.MaxLength = 20
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(120, 21)
        Me.txtAmount.TabIndex = 545
        '
        'txtSealNo
        '
        Me.txtSealNo.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtSealNo.Location = New System.Drawing.Point(222, 112)
        Me.txtSealNo.MaxLength = 20
        Me.txtSealNo.Name = "txtSealNo"
        Me.txtSealNo.Size = New System.Drawing.Size(120, 21)
        Me.txtSealNo.TabIndex = 514
        '
        'txtConOper
        '
        Me.txtConOper.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtConOper.Location = New System.Drawing.Point(572, 114)
        Me.txtConOper.MaxLength = 20
        Me.txtConOper.Name = "txtConOper"
        Me.txtConOper.Size = New System.Drawing.Size(100, 21)
        Me.txtConOper.TabIndex = 532
        '
        'txtConOperCode
        '
        Me.txtConOperCode.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtConOperCode.Location = New System.Drawing.Point(572, 90)
        Me.txtConOperCode.MaxLength = 10
        Me.txtConOperCode.Name = "txtConOperCode"
        Me.txtConOperCode.Size = New System.Drawing.Size(100, 21)
        Me.txtConOperCode.TabIndex = 530
        '
        'lbContainer
        '
        Me.lbContainer.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbContainer.ForeColor = System.Drawing.Color.Crimson
        Me.lbContainer.Location = New System.Drawing.Point(36, 24)
        Me.lbContainer.Name = "lbContainer"
        Me.lbContainer.Size = New System.Drawing.Size(150, 17)
        Me.lbContainer.TabIndex = 562
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Navy
        Me.Label41.Location = New System.Drawing.Point(4, 28)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(38, 12)
        Me.Label41.TabIndex = 561
        Me.Label41.Text = "箱号:"
        '
        'lbVoyage
        '
        Me.lbVoyage.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lbVoyage.Location = New System.Drawing.Point(42, 110)
        Me.lbVoyage.Name = "lbVoyage"
        Me.lbVoyage.Size = New System.Drawing.Size(120, 17)
        Me.lbVoyage.TabIndex = 560
        '
        'lbShipName
        '
        Me.lbShipName.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lbShipName.Location = New System.Drawing.Point(42, 90)
        Me.lbShipName.Name = "lbShipName"
        Me.lbShipName.Size = New System.Drawing.Size(120, 17)
        Me.lbShipName.TabIndex = 559
        '
        'lbShip
        '
        Me.lbShip.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lbShip.Location = New System.Drawing.Point(42, 70)
        Me.lbShip.Name = "lbShip"
        Me.lbShip.Size = New System.Drawing.Size(120, 17)
        Me.lbShip.TabIndex = 558
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(10, 110)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(29, 12)
        Me.Label39.TabIndex = 557
        Me.Label39.Text = "航次"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(10, 90)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(29, 12)
        Me.Label33.TabIndex = 556
        Me.Label33.Text = "船名"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(10, 70)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(29, 12)
        Me.Label27.TabIndex = 555
        Me.Label27.Text = "船码"
        '
        'txtTareWeight
        '
        Me.txtTareWeight.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtTareWeight.Location = New System.Drawing.Point(396, 88)
        Me.txtTareWeight.MaxLength = 20
        Me.txtTareWeight.Name = "txtTareWeight"
        Me.txtTareWeight.Size = New System.Drawing.Size(74, 21)
        Me.txtTareWeight.TabIndex = 547
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(470, 140)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(29, 12)
        Me.Label26.TabIndex = 554
        Me.Label26.Text = "立方"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(470, 116)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(29, 12)
        Me.Label25.TabIndex = 553
        Me.Label25.Text = "公斤"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(470, 92)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(29, 12)
        Me.Label24.TabIndex = 552
        Me.Label24.Text = "公斤"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMeasure
        '
        Me.txtMeasure.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtMeasure.Location = New System.Drawing.Point(396, 136)
        Me.txtMeasure.MaxLength = 20
        Me.txtMeasure.Name = "txtMeasure"
        Me.txtMeasure.Size = New System.Drawing.Size(74, 21)
        Me.txtMeasure.TabIndex = 551
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(364, 138)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(29, 12)
        Me.Label22.TabIndex = 550
        Me.Label22.Text = "尺码"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNetWeight
        '
        Me.txtNetWeight.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtNetWeight.Location = New System.Drawing.Point(396, 112)
        Me.txtNetWeight.MaxLength = 20
        Me.txtNetWeight.Name = "txtNetWeight"
        Me.txtNetWeight.Size = New System.Drawing.Size(74, 21)
        Me.txtNetWeight.TabIndex = 549
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(364, 114)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(29, 12)
        Me.Label19.TabIndex = 548
        Me.Label19.Text = "毛重"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(178, 138)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(41, 12)
        Me.Label20.TabIndex = 546
        Me.Label20.Text = "件  数"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(364, 90)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(29, 12)
        Me.Label21.TabIndex = 544
        Me.Label21.Text = "皮重"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTop
        '
        Me.txtTop.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtTop.Location = New System.Drawing.Point(720, 40)
        Me.txtTop.MaxLength = 20
        Me.txtTop.Name = "txtTop"
        Me.txtTop.Size = New System.Drawing.Size(100, 21)
        Me.txtTop.TabIndex = 543
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(688, 44)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(29, 12)
        Me.Label18.TabIndex = 542
        Me.Label18.Text = "超高"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRight
        '
        Me.txtRight.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtRight.Location = New System.Drawing.Point(720, 136)
        Me.txtRight.MaxLength = 20
        Me.txtRight.Name = "txtRight"
        Me.txtRight.Size = New System.Drawing.Size(100, 21)
        Me.txtRight.TabIndex = 541
        '
        'txtLeft
        '
        Me.txtLeft.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtLeft.Location = New System.Drawing.Point(720, 112)
        Me.txtLeft.MaxLength = 20
        Me.txtLeft.Name = "txtLeft"
        Me.txtLeft.Size = New System.Drawing.Size(100, 21)
        Me.txtLeft.TabIndex = 539
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(688, 116)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 12)
        Me.Label14.TabIndex = 540
        Me.Label14.Text = "左超"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFront
        '
        Me.txtFront.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtFront.Location = New System.Drawing.Point(720, 64)
        Me.txtFront.MaxLength = 20
        Me.txtFront.Name = "txtFront"
        Me.txtFront.Size = New System.Drawing.Size(100, 21)
        Me.txtFront.TabIndex = 537
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(688, 68)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 12)
        Me.Label15.TabIndex = 538
        Me.Label15.Text = "前超"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(688, 140)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(29, 12)
        Me.Label16.TabIndex = 536
        Me.Label16.Text = "右超"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBack
        '
        Me.txtBack.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtBack.Location = New System.Drawing.Point(720, 88)
        Me.txtBack.MaxLength = 20
        Me.txtBack.Name = "txtBack"
        Me.txtBack.Size = New System.Drawing.Size(100, 21)
        Me.txtBack.TabIndex = 534
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label17.Location = New System.Drawing.Point(688, 92)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(29, 12)
        Me.Label17.TabIndex = 535
        Me.Label17.Text = "后超"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label12.Location = New System.Drawing.Point(528, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 12)
        Me.Label12.TabIndex = 533
        Me.Label12.Text = "经营人"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label13.Location = New System.Drawing.Point(516, 92)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 12)
        Me.Label13.TabIndex = 531
        Me.Label13.Text = "经营人码"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtState
        '
        Me.txtState.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtState.Location = New System.Drawing.Point(320, 88)
        Me.txtState.MaxLength = 1
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(22, 21)
        Me.txtState.TabIndex = 521
        '
        'txtConType
        '
        Me.txtConType.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtConType.Location = New System.Drawing.Point(294, 88)
        Me.txtConType.MaxLength = 2
        Me.txtConType.Name = "txtConType"
        Me.txtConType.Size = New System.Drawing.Size(26, 21)
        Me.txtConType.TabIndex = 519
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(894, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 12)
        Me.Label8.TabIndex = 520
        Me.Label8.Text = "箱型"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtConSize
        '
        Me.txtConSize.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtConSize.Location = New System.Drawing.Point(272, 88)
        Me.txtConSize.MaxLength = 2
        Me.txtConSize.Name = "txtConSize"
        Me.txtConSize.Size = New System.Drawing.Size(24, 21)
        Me.txtConSize.TabIndex = 517
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(178, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 12)
        Me.Label7.TabIndex = 518
        Me.Label7.Text = "尺寸|箱型|状态"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(880, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 516
        Me.Label6.Text = "箱状态"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label35.Location = New System.Drawing.Point(178, 114)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(41, 12)
        Me.Label35.TabIndex = 515
        Me.Label35.Text = "铅封号"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox5
        '
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(4, 50)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(162, 82)
        Me.GroupBox5.TabIndex = 563
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "航次信息"
        '
        'dtpLoadDate
        '
        Me.dtpLoadDate.CalendarTitleBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.dtpLoadDate.CalendarTrailingForeColor = System.Drawing.SystemColors.HotTrack
        Me.dtpLoadDate.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.dtpLoadDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpLoadDate.Location = New System.Drawing.Point(68, 196)
        Me.dtpLoadDate.Name = "dtpLoadDate"
        Me.dtpLoadDate.Size = New System.Drawing.Size(100, 21)
        Me.dtpLoadDate.TabIndex = 525
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Location = New System.Drawing.Point(12, 198)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 12)
        Me.Label9.TabIndex = 524
        Me.Label9.Text = "装箱日期"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbOuter
        '
        Me.lbOuter.BackColor = System.Drawing.Color.Transparent
        Me.lbOuter.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbOuter.Location = New System.Drawing.Point(676, 18)
        Me.lbOuter.Name = "lbOuter"
        Me.lbOuter.Size = New System.Drawing.Size(146, 18)
        Me.lbOuter.TabIndex = 577
        Me.lbOuter.Text = "该箱数据未导入"
        '
        'cbPlace
        '
        Me.cbPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlace.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cbPlace.Location = New System.Drawing.Point(64, 64)
        Me.cbPlace.MaxDropDownItems = 20
        Me.cbPlace.Name = "cbPlace"
        Me.cbPlace.Size = New System.Drawing.Size(106, 20)
        Me.cbPlace.TabIndex = 528
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(10, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 12)
        Me.Label11.TabIndex = 529
        Me.Label11.Text = "装箱地点"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C1Goods
        '
        Me.C1Goods.AllowColMove = False
        Me.C1Goods.AllowSort = False
        Me.C1Goods.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1Goods.Images.Add(CType(resources.GetObject("C1Goods.Images"), System.Drawing.Image))
        Me.C1Goods.Location = New System.Drawing.Point(12, 354)
        Me.C1Goods.Name = "C1Goods"
        Me.C1Goods.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1Goods.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1Goods.PreviewInfo.ZoomFactor = 75
        Me.C1Goods.PrintInfo.PageSettings = CType(resources.GetObject("C1Goods.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1Goods.Size = New System.Drawing.Size(456, 90)
        Me.C1Goods.TabIndex = 554
        Me.C1Goods.Text = "C1TrueDBGrid1"
        Me.C1Goods.PropBag = resources.GetString("C1Goods.PropBag")
        '
        'C1Relation
        '
        Me.C1Relation.AllowColMove = False
        Me.C1Relation.AllowSort = False
        Me.C1Relation.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1Relation.Images.Add(CType(resources.GetObject("C1Relation.Images"), System.Drawing.Image))
        Me.C1Relation.Location = New System.Drawing.Point(478, 354)
        Me.C1Relation.Name = "C1Relation"
        Me.C1Relation.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1Relation.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1Relation.PreviewInfo.ZoomFactor = 75
        Me.C1Relation.PrintInfo.PageSettings = CType(resources.GetObject("C1Relation.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1Relation.Size = New System.Drawing.Size(348, 90)
        Me.C1Relation.TabIndex = 563
        Me.C1Relation.Text = "C1TrueDBGrid1"
        Me.C1Relation.PropBag = resources.GetString("C1Relation.PropBag")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Location = New System.Drawing.Point(856, 462)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 12)
        Me.Label10.TabIndex = 564
        Me.Label10.Text = "箱中各提单货物数量"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label23.Location = New System.Drawing.Point(856, 480)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(101, 12)
        Me.Label23.TabIndex = 565
        Me.Label23.Text = "有关提单货物信息"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label28.Location = New System.Drawing.Point(856, 20)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(77, 12)
        Me.Label28.TabIndex = 567
        Me.Label28.Text = "有关提单信息"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C1Bill
        '
        Me.C1Bill.AllowColMove = False
        Me.C1Bill.AllowSort = False
        Me.C1Bill.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1Bill.Images.Add(CType(resources.GetObject("C1Bill.Images"), System.Drawing.Image))
        Me.C1Bill.Location = New System.Drawing.Point(10, 248)
        Me.C1Bill.Name = "C1Bill"
        Me.C1Bill.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1Bill.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1Bill.PreviewInfo.ZoomFactor = 75
        Me.C1Bill.PrintInfo.PageSettings = CType(resources.GetObject("C1Bill.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1Bill.Size = New System.Drawing.Size(816, 80)
        Me.C1Bill.TabIndex = 566
        Me.C1Bill.Text = "C1TrueDBGrid1"
        Me.C1Bill.PropBag = resources.GetString("C1Bill.PropBag")
        '
        'txtDamageDesc
        '
        Me.txtDamageDesc.Location = New System.Drawing.Point(200, 16)
        Me.txtDamageDesc.MaxLength = 50
        Me.txtDamageDesc.Name = "txtDamageDesc"
        Me.txtDamageDesc.Size = New System.Drawing.Size(164, 21)
        Me.txtDamageDesc.TabIndex = 571
        '
        'txtDamageAmount
        '
        Me.txtDamageAmount.Location = New System.Drawing.Point(62, 16)
        Me.txtDamageAmount.MaxLength = 5
        Me.txtDamageAmount.Name = "txtDamageAmount"
        Me.txtDamageAmount.Size = New System.Drawing.Size(80, 21)
        Me.txtDamageAmount.TabIndex = 569
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(8, 20)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(53, 12)
        Me.Label29.TabIndex = 570
        Me.Label29.Text = "残损件数"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(146, 20)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(53, 12)
        Me.Label30.TabIndex = 568
        Me.Label30.Text = "残损情况"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSecSealNo
        '
        Me.txtSecSealNo.Location = New System.Drawing.Point(424, 16)
        Me.txtSecSealNo.MaxLength = 20
        Me.txtSecSealNo.Name = "txtSecSealNo"
        Me.txtSecSealNo.Size = New System.Drawing.Size(124, 21)
        Me.txtSecSealNo.TabIndex = 573
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(370, 20)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(53, 12)
        Me.Label31.TabIndex = 572
        Me.Label31.Text = "备注铅封"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOpenSealReason
        '
        Me.txtOpenSealReason.Location = New System.Drawing.Point(672, 16)
        Me.txtOpenSealReason.MaxLength = 50
        Me.txtOpenSealReason.Name = "txtOpenSealReason"
        Me.txtOpenSealReason.Size = New System.Drawing.Size(148, 21)
        Me.txtOpenSealReason.TabIndex = 575
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(557, 20)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(113, 12)
        Me.Label32.TabIndex = 574
        Me.Label32.Text = "开封原因或集卡车号"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbShow
        '
        Me.lbShow.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lbShow.Location = New System.Drawing.Point(510, 18)
        Me.lbShow.Name = "lbShow"
        Me.lbShow.Size = New System.Drawing.Size(242, 16)
        Me.lbShow.TabIndex = 576
        Me.lbShow.Text = "提单不存在箱号不存在"
        '
        'cbConLoadType
        '
        Me.cbConLoadType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConLoadType.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbConLoadType.Location = New System.Drawing.Point(62, 104)
        Me.cbConLoadType.Name = "cbConLoadType"
        Me.cbConLoadType.Size = New System.Drawing.Size(100, 20)
        Me.cbConLoadType.TabIndex = 578
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(6, 106)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(53, 12)
        Me.Label36.TabIndex = 579
        Me.Label36.Text = "折装箱别"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbState
        '
        Me.cbState.Items.AddRange(New Object() {"", "全已装箱", "部分装箱", "拆箱"})
        Me.cbState.Location = New System.Drawing.Point(62, 152)
        Me.cbState.MaxDropDownItems = 20
        Me.cbState.Name = "cbState"
        Me.cbState.Size = New System.Drawing.Size(100, 20)
        Me.cbState.TabIndex = 581
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(6, 154)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(53, 12)
        Me.Label37.TabIndex = 583
        Me.Label37.Text = "货物处于"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbDescribe
        '
        Me.cbDescribe.Enabled = False
        Me.cbDescribe.Items.AddRange(New Object() {"", "全部抵运", "部分抵运"})
        Me.cbDescribe.Location = New System.Drawing.Point(62, 128)
        Me.cbDescribe.MaxDropDownItems = 20
        Me.cbDescribe.Name = "cbDescribe"
        Me.cbDescribe.Size = New System.Drawing.Size(100, 20)
        Me.cbDescribe.TabIndex = 580
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(6, 130)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(53, 12)
        Me.Label38.TabIndex = 582
        Me.Label38.Text = "货箱抵运"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label56)
        Me.GroupBox1.Controls.Add(Me.txtVehicle)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.txtOpenSealReason)
        Me.GroupBox1.Controls.Add(Me.txtSecSealNo)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.txtDamageAmount)
        Me.GroupBox1.Controls.Add(Me.txtDamageDesc)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 614)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(826, 44)
        Me.GroupBox1.TabIndex = 584
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "箱补充信息"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(845, 20)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(29, 12)
        Me.Label56.TabIndex = 578
        Me.Label56.Text = "车号"
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVehicle
        '
        Me.txtVehicle.Location = New System.Drawing.Point(875, 15)
        Me.txtVehicle.MaxLength = 20
        Me.txtVehicle.Name = "txtVehicle"
        Me.txtVehicle.Size = New System.Drawing.Size(101, 21)
        Me.txtVehicle.TabIndex = 579
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label42)
        Me.GroupBox2.Controls.Add(Me.ccbGoods)
        Me.GroupBox2.Controls.Add(Me.Label40)
        Me.GroupBox2.Controls.Add(Me.txtGoodsSpec)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.cbState)
        Me.GroupBox2.Controls.Add(Me.cbDescribe)
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.cbConLoadType)
        Me.GroupBox2.Location = New System.Drawing.Point(858, 206)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 180)
        Me.GroupBox2.TabIndex = 585
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "提单补充"
        Me.GroupBox2.Visible = False
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(8, 18)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(29, 12)
        Me.Label42.TabIndex = 642
        Me.Label42.Text = "货名"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ccbGoods
        '
        Me.ccbGoods.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
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
        Me.ccbGoods.Location = New System.Drawing.Point(8, 36)
        Me.ccbGoods.MatchEntryTimeout = CType(2000, Long)
        Me.ccbGoods.MaxDropDownItems = CType(20, Short)
        Me.ccbGoods.MaxLength = 32767
        Me.ccbGoods.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.ccbGoods.Name = "ccbGoods"
        Me.ccbGoods.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.ccbGoods.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.ccbGoods.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.ccbGoods.Size = New System.Drawing.Size(154, 22)
        Me.ccbGoods.TabIndex = 641
        Me.ccbGoods.PropBag = resources.GetString("ccbGoods.PropBag")
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(8, 60)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(29, 12)
        Me.Label40.TabIndex = 640
        Me.Label40.Text = "规格"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGoodsSpec
        '
        Me.txtGoodsSpec.Location = New System.Drawing.Point(8, 78)
        Me.txtGoodsSpec.MaxLength = 50
        Me.txtGoodsSpec.Name = "txtGoodsSpec"
        Me.txtGoodsSpec.Size = New System.Drawing.Size(154, 21)
        Me.txtGoodsSpec.TabIndex = 639
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Navy
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(174, 664)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(92, 32)
        Me.btnSave.TabIndex = 586
        Me.btnSave.Text = "报文(&B)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCreateReport
        '
        Me.btnCreateReport.Location = New System.Drawing.Point(196, 746)
        Me.btnCreateReport.Name = "btnCreateReport"
        Me.btnCreateReport.Size = New System.Drawing.Size(75, 22)
        Me.btnCreateReport.TabIndex = 587
        Me.btnCreateReport.Text = "生成报文"
        '
        'btnImport
        '
        Me.btnImport.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImport.ForeColor = System.Drawing.Color.Navy
        Me.btnImport.Image = CType(resources.GetObject("btnImport.Image"), System.Drawing.Image)
        Me.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImport.Location = New System.Drawing.Point(374, 664)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(92, 32)
        Me.btnImport.TabIndex = 588
        Me.btnImport.Text = "确认(&G)"
        Me.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ckbReImportBill
        '
        Me.ckbReImportBill.ForeColor = System.Drawing.Color.Navy
        Me.ckbReImportBill.Location = New System.Drawing.Point(272, 672)
        Me.ckbReImportBill.Name = "ckbReImportBill"
        Me.ckbReImportBill.Size = New System.Drawing.Size(98, 18)
        Me.ckbReImportBill.TabIndex = 589
        Me.ckbReImportBill.Text = "是否重导提单"
        '
        'CheckBox2
        '
        Me.CheckBox2.Location = New System.Drawing.Point(878, 402)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(122, 24)
        Me.CheckBox2.TabIndex = 590
        Me.CheckBox2.Text = "是否保存改单"
        Me.CheckBox2.Visible = False
        '
        'CheckBox3
        '
        Me.CheckBox3.Location = New System.Drawing.Point(878, 428)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(122, 24)
        Me.CheckBox3.TabIndex = 591
        Me.CheckBox3.Text = "是否生成报文"
        Me.CheckBox3.Visible = False
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Navy
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(524, 664)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 32)
        Me.btnExit.TabIndex = 593
        Me.btnExit.Text = "退出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C1MyBill
        '
        Me.C1MyBill.AllowColMove = False
        Me.C1MyBill.AllowSort = False
        Me.C1MyBill.FetchRowStyles = True
        Me.C1MyBill.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1MyBill.Images.Add(CType(resources.GetObject("C1MyBill.Images"), System.Drawing.Image))
        Me.C1MyBill.Location = New System.Drawing.Point(12, 534)
        Me.C1MyBill.Name = "C1MyBill"
        Me.C1MyBill.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1MyBill.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1MyBill.PreviewInfo.ZoomFactor = 75
        Me.C1MyBill.PrintInfo.PageSettings = CType(resources.GetObject("C1MyBill.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1MyBill.Size = New System.Drawing.Size(816, 74)
        Me.C1MyBill.TabIndex = 596
        Me.C1MyBill.Text = "C1TrueDBGrid1"
        Me.C1MyBill.PropBag = resources.GetString("C1MyBill.PropBag")
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Location = New System.Drawing.Point(2, 450)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(838, 4)
        Me.Panel2.TabIndex = 597
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label43.Location = New System.Drawing.Point(858, 606)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(53, 12)
        Me.Label43.TabIndex = 598
        Me.Label43.Text = "提单补充"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbPlace2)
        Me.GroupBox3.Controls.Add(Me.Label34)
        Me.GroupBox3.Controls.Add(Me.lbMyContainer)
        Me.GroupBox3.Controls.Add(Me.txtMyShip)
        Me.GroupBox3.Controls.Add(Me.Label44)
        Me.GroupBox3.Controls.Add(Me.Label45)
        Me.GroupBox3.Controls.Add(Me.txtMyVoyage)
        Me.GroupBox3.Controls.Add(Me.Label46)
        Me.GroupBox3.Controls.Add(Me.btnMyFind)
        Me.GroupBox3.Controls.Add(Me.txtMyShipName)
        Me.GroupBox3.Controls.Add(Me.Label47)
        Me.GroupBox3.Controls.Add(Me.lbYard)
        Me.GroupBox3.Controls.Add(Me.Label55)
        Me.GroupBox3.Controls.Add(Me.lbCheck)
        Me.GroupBox3.Controls.Add(Me.lbShow)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(6, 458)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(826, 58)
        Me.GroupBox3.TabIndex = 599
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "修改船码航次"
        '
        'cbPlace2
        '
        Me.cbPlace2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlace2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cbPlace2.Location = New System.Drawing.Point(266, 14)
        Me.cbPlace2.MaxDropDownItems = 20
        Me.cbPlace2.Name = "cbPlace2"
        Me.cbPlace2.Size = New System.Drawing.Size(102, 20)
        Me.cbPlace2.TabIndex = 566
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.Color.Navy
        Me.Label34.Location = New System.Drawing.Point(236, 16)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(29, 12)
        Me.Label34.TabIndex = 564
        Me.Label34.Text = "场站"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbMyContainer
        '
        Me.lbMyContainer.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lbMyContainer.Location = New System.Drawing.Point(268, 36)
        Me.lbMyContainer.Name = "lbMyContainer"
        Me.lbMyContainer.Size = New System.Drawing.Size(100, 17)
        Me.lbMyContainer.TabIndex = 563
        '
        'txtMyShip
        '
        Me.txtMyShip.Location = New System.Drawing.Point(38, 12)
        Me.txtMyShip.Name = "txtMyShip"
        Me.txtMyShip.Size = New System.Drawing.Size(100, 21)
        Me.txtMyShip.TabIndex = 10
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.ForeColor = System.Drawing.Color.Navy
        Me.Label44.Location = New System.Drawing.Point(236, 36)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(29, 12)
        Me.Label44.TabIndex = 13
        Me.Label44.Text = "箱号"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.ForeColor = System.Drawing.Color.Navy
        Me.Label45.Location = New System.Drawing.Point(8, 14)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(29, 12)
        Me.Label45.TabIndex = 5
        Me.Label45.Text = "船码"
        '
        'txtMyVoyage
        '
        Me.txtMyVoyage.Location = New System.Drawing.Point(172, 12)
        Me.txtMyVoyage.Name = "txtMyVoyage"
        Me.txtMyVoyage.Size = New System.Drawing.Size(60, 21)
        Me.txtMyVoyage.TabIndex = 12
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.ForeColor = System.Drawing.Color.Navy
        Me.Label46.Location = New System.Drawing.Point(142, 14)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(29, 12)
        Me.Label46.TabIndex = 8
        Me.Label46.Text = "航次"
        '
        'btnMyFind
        '
        Me.btnMyFind.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnMyFind.Location = New System.Drawing.Point(150, 34)
        Me.btnMyFind.Name = "btnMyFind"
        Me.btnMyFind.Size = New System.Drawing.Size(76, 22)
        Me.btnMyFind.TabIndex = 7
        Me.btnMyFind.Text = "本系统查找"
        '
        'txtMyShipName
        '
        Me.txtMyShipName.Location = New System.Drawing.Point(38, 34)
        Me.txtMyShipName.Name = "txtMyShipName"
        Me.txtMyShipName.ReadOnly = True
        Me.txtMyShipName.Size = New System.Drawing.Size(100, 21)
        Me.txtMyShipName.TabIndex = 11
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.ForeColor = System.Drawing.Color.Navy
        Me.Label47.Location = New System.Drawing.Point(8, 36)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(29, 12)
        Me.Label47.TabIndex = 9
        Me.Label47.Text = "船名"
        '
        'lbYard
        '
        Me.lbYard.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbYard.Location = New System.Drawing.Point(266, 16)
        Me.lbYard.Name = "lbYard"
        Me.lbYard.Size = New System.Drawing.Size(100, 17)
        Me.lbYard.TabIndex = 565
        '
        'Label55
        '
        Me.Label55.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.Red
        Me.Label55.Location = New System.Drawing.Point(422, 22)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(88, 20)
        Me.Label55.TabIndex = 618
        Me.Label55.Text = "友情提醒！"
        '
        'lbCheck
        '
        Me.lbCheck.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lbCheck.Location = New System.Drawing.Point(510, 36)
        Me.lbCheck.Name = "lbCheck"
        Me.lbCheck.Size = New System.Drawing.Size(242, 17)
        Me.lbCheck.TabIndex = 602
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox4.Controls.Add(Me.Label54)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtShip)
        Me.GroupBox4.Controls.Add(Me.txtVoyage)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtShipName)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtContainer)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.btnFind)
        Me.GroupBox4.Controls.Add(Me.lbOuter)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(4, 14)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(828, 44)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "外部数据查找"
        '
        'Label54
        '
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Red
        Me.Label54.Location = New System.Drawing.Point(598, 18)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(78, 18)
        Me.Label54.TabIndex = 580
        Me.Label54.Text = "友情提醒！"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label48.Location = New System.Drawing.Point(938, 20)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(41, 12)
        Me.Label48.TabIndex = 600
        Me.Label48.Text = "改提单"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label49.Location = New System.Drawing.Point(962, 480)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(41, 12)
        Me.Label49.TabIndex = 601
        Me.Label49.Text = "改货号"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label53
        '
        Me.Label53.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label53.Location = New System.Drawing.Point(690, 80)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(128, 16)
        Me.Label53.TabIndex = 610
        Me.Label53.Text = "COSTACO  LYG"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label52
        '
        Me.Label52.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label52.Location = New System.Drawing.Point(690, 66)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(128, 14)
        Me.Label52.TabIndex = 611
        Me.Label52.Text = "连云港中理"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label51
        '
        Me.Label51.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label51.Location = New System.Drawing.Point(304, 106)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(274, 22)
        Me.Label51.TabIndex = 614
        Me.Label51.Text = "CONTAINER LOAD PLAN"
        '
        'Label50
        '
        Me.Label50.Font = New System.Drawing.Font("黑体", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label50.Location = New System.Drawing.Point(338, 70)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(206, 36)
        Me.Label50.TabIndex = 613
        Me.Label50.Text = "装   箱   单"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(190, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(488, 82)
        Me.Label5.TabIndex = 612
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label28)
        Me.GroupBox6.Controls.Add(Me.Label48)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox6.Location = New System.Drawing.Point(4, 228)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(828, 104)
        Me.GroupBox6.TabIndex = 615
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "提单信息更改"
        '
        'GroupBox7
        '
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(6, 336)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(466, 112)
        Me.GroupBox7.TabIndex = 616
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "单货信息更改"
        '
        'GroupBox8
        '
        Me.GroupBox8.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox8.Location = New System.Drawing.Point(474, 336)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(358, 112)
        Me.GroupBox8.TabIndex = 617
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "箱货信息更改"
        '
        'GroupBox9
        '
        Me.GroupBox9.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox9.Location = New System.Drawing.Point(6, 516)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(826, 96)
        Me.GroupBox9.TabIndex = 618
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "提单补充信息"
        '
        'FrmConLoadTally_Extract
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(838, 704)
        Me.Controls.Add(Me.dtpLoadDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cbPlace)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.ckbReImportBill)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnCreateReport)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.C1Bill)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.C1Relation)
        Me.Controls.Add(Me.C1Goods)
        Me.Controls.Add(Me.C1MyBill)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConLoadTally_Extract"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "装拆箱外部数据修改导入发送"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.C1Goods, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Relation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Bill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ccbGoods, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1MyBill, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Public blEditImport As Integer    '是改单还是导入操作还是全部操作
    Dim sqlShipCode As String
    Dim dvShipCode As New DataView
    Dim shipMark As Boolean
    Dim blFind As Boolean   '是否找到外部数据
    Dim blMyFind As Boolean '是否找到本系统数据
    Dim strEdiID, strShip, strCasualShipEng, strFindShipEng, strVoyage, strContainer As String  '外部数据
    Dim strMyShip, strMyShipName, strMyVoyage, strMyYard As String   '本系统数据
    Dim strDefaultYard As String    '操作员所属场站代码
    Dim strTempShipEng, strNewShipEng As String '保存修改的英文船名
    Const strCheckDept As String = "26.11.30.09" '检查桥部门登陆代码
    Const strCheckDept2 As String = "26.11.12"
    Dim strYard As String = "01"

    Dim sqlConsign As String
    Dim dvConsign As DataView
    Dim dvAllYard As DataView

    Dim sqlTbCon As String
    Dim daTbCon As New SqlClient.SqlDataAdapter
    Dim dsTbCon As New DataSet
    Dim dvTbCon As DataView
    Dim sqlTbRelation As String
    Dim daTbRelation As New SqlClient.SqlDataAdapter
    Dim dsTbRelation As New DataSet
    Dim dvTbRelation As DataView
    Dim sqlTbGoods As String
    Dim daTbGoods As New SqlClient.SqlDataAdapter
    Dim dsTbGoods As New DataSet
    Dim dvTbGoods As DataView
    Dim sqlTbBill As String
    Dim daTbBill As New SqlClient.SqlDataAdapter
    Dim dsTbBill As New DataSet
    Dim dvTbBill As DataView
    Dim dvMyBill As DataView

    Dim PathStr As String
    Dim FilePath As String
    Dim FilePathStr As String
    Public blSave As Boolean

    Private Sub FrmConLoadTally_Extract_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        db_rp.connstr = conn_rp '外理报文用
        If G_DeptCode = strCheckDept Then
            strYard = "07"
        ElseIf G_DeptCode = strCheckDept2 Then
            strYard = "21"
        End If

        Dim sqlAllYard As String
        sqlAllYard = "SELECT Code_Yard_ID, Code_Yard_Name, CodePrefix,DeptCode FROM Code_Yard"
        dvAllYard = Filldata(sqlAllYard)

        Dim sqlYard As String
        Dim dvYard As DataView
        sqlYard = "SELECT Code_Yard_ID, Code_Yard_Name, CodePrefix,DeptCode FROM Code_Yard where DeptCode like '" & G_DeptCode & "%' ORDER BY Code_Yard_ID"
        If blEditImport = 1 Then  '改单
            Me.btnImport.Enabled = False
        ElseIf blEditImport = 2 Then '导入
            'Me.Panel1.Enabled = False
            Me.txtConSize.ReadOnly = True
            Me.txtConType.ReadOnly = True
            Me.txtState.ReadOnly = True
            Me.txtSealNo.ReadOnly = True
            Me.dtpLoadDate.Enabled = False
            Me.txtConOperCode.ReadOnly = True
            Me.txtConOper.ReadOnly = True
            Me.txtFront.ReadOnly = True
            Me.txtBack.ReadOnly = True
            Me.txtLeft.ReadOnly = True
            Me.txtRight.ReadOnly = True
            Me.txtTop.ReadOnly = True
            Me.txtAmount.ReadOnly = True
            Me.txtTareWeight.ReadOnly = True
            Me.txtNetWeight.ReadOnly = True
            Me.txtMeasure.ReadOnly = True

            Me.C1Relation.AllowUpdate = False
            Me.C1Goods.AllowUpdate = False
            Me.C1Bill.AllowUpdate = False
            Me.btnCreateReport.Enabled = False
        Else    '全部开放

        End If
        If G_DeptCode = strCheckDept OrElse G_DeptCode = strCheckDept2 Then  '检查桥特殊
            sqlYard = "SELECT Code_Yard_ID, Code_Yard_Name, CodePrefix,DeptCode FROM Code_Yard where DeptCode <> '00' ORDER BY Code_Yard_ID"
            Me.btnImport.Text = "查验导入"
            Me.ckbReImportBill.Enabled = False
        Else
            sqlYard = "SELECT Code_Yard_ID, Code_Yard_Name, CodePrefix,DeptCode FROM Code_Yard where DeptCode like '" & G_DeptCode & "%' ORDER BY Code_Yard_ID"
            Me.lbCheck.Visible = False
        End If
        dvYard = Filldata(sqlYard)
        cbPlace.DataSource = dvYard
        cbPlace.DisplayMember = "Code_Yard_Name"
        cbPlace.ValueMember = "Code_Yard_ID"
        cbPlace2.DataSource = dvYard
        cbPlace2.DisplayMember = "Code_Yard_Name"
        cbPlace2.ValueMember = "Code_Yard_ID"

        Dim sqlConLoadType As String
        sqlConLoadType = "select Code_Tally_Type,Name_Tally_Type from Code_Tally_Type "
        cbConLoadType.DataSource = Filldata(sqlConLoadType)
        cbConLoadType.DisplayMember = "Name_Tally_Type"
        cbConLoadType.ValueMember = "Code_Tally_Type"
        Dim sqlCodeGoods As String
        sqlCodeGoods = "select Goods from CodeGoods where ConLoadMark='1' order by Goods"
        Me.ccbGoods.DataSource = Filldata(sqlCodeGoods)
        Me.ccbGoods.DisplayMember = "Goods"
        Me.ccbGoods.ValueMember = "Goods"
        Me.ccbGoods.AutoSize = True
        Dim i As Integer
        For i = 0 To dvYard.Count - 1
            If dvYard(i)("DeptCode") = G_DeptCode Then
                Exit For
            End If
        Next
        If i < dvYard.Count Then
            Me.cbPlace.SelectedValue = dvYard(i)("Code_Yard_ID")
        End If
        strDefaultYard = Me.cbPlace.SelectedValue

        sqlConsign = "SELECT TB_Code,CODE_SHIP_AGENT FROM CODE_SHIP_AGENT where Mark <> '1' OR Mark IS NULL"
        dvConsign = Filldata(sqlConsign)

        '//读取报文设置路径
        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        Try
            FilePath = PathStr + "EDIINI.INI"
            Dim sr As New StreamReader(FilePath) '打开报文文件
            FilePathStr = sr.ReadLine()
            If FilePathStr.Trim().Substring(FilePathStr.Trim().Length, 1).Trim() <> "\" Then
                FilePathStr = FilePathStr.Trim() + "\"
            End If
            sr.ReadLine()
            sr.ReadLine()
            sr.Close()
        Catch
        End Try
    End Sub

    Private Sub txtShip_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtShip.Leave
        Me.txtShip.Text = Me.txtShip.Text.Trim.ToUpper
        sqlShipCode = "SELECT SPCODE, CHI_VESSEL,Eng_VESSEL FROM Code_SHIPNAME WHERE (SPCODE = '" & Me.txtShip.Text & "' or CHI_VESSEL = '" & Me.txtShip.Text & "')"
        dvShipCode = Filldata(sqlShipCode)
        txtShipName.Clear()
        If dvShipCode.Count > 0 Then
            Me.txtShip.Text = dvShipCode(0)("SPCODE")
            If Not IsDBNull(dvShipCode(0)("CHI_VESSEL")) Then
                Me.txtShipName.Text = dvShipCode(0)("CHI_VESSEL")
            End If
            If Not IsDBNull(dvShipCode(0)("Eng_VESSEL")) Then
                strCasualShipEng = dvShipCode(0)("Eng_VESSEL")
                Me.txtShipName.Text += "/" & dvShipCode(0)("ENG_VESSEL")
            End If
        End If
    End Sub

    Private Sub txtVoyage_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVoyage.Leave
        txtVoyage.Text = txtVoyage.Text.Trim.ToUpper
    End Sub

    Private Sub txtContainer_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContainer.Leave
        txtContainer.Text = txtContainer.Text.Trim.ToUpper
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Me.lbOuter.Text = "准备查找……"
        If Me.txtContainer.Text <> "" Then
            Dim sqlConExist As String
            Dim dvConExist As DataView
            If Me.txtShip.Text = "" AndAlso Me.txtVoyage.Text = "" Then
                '只用箱号判断重复存在
                sqlConExist = "SELECT DISTINCT CODE_VESSEL,VOYAGE,CTN_NO,ImportMark FROM TB_CONLOAD_CON WHERE CTN_NO='" & Me.txtContainer.Text & "'"
                dvConExist = db_rp.Filldata(sqlConExist)
                If dvConExist.Count = 1 Then
                    '不管状态，直接找
                    sqlTbCon = "SELECT * FROM TB_CONLOAD_CON WHERE CTN_NO = '" & Me.txtContainer.Text & "' ORDER BY AutoID DESC"
                    FindData()
                ElseIf dvConExist.Count > 1 Then    '可能多船次多状态
                    dvConExist.RowFilter = "ImportMark='0'"   '先找当前状态
                    If dvConExist.Count = 1 Then
                        '找当前的
                        sqlTbCon = "SELECT * FROM TB_CONLOAD_CON WHERE CTN_NO = '" & Me.txtContainer.Text & "' and ImportMark = '0' ORDER BY AutoID DESC"
                        FindData()
                        'ElseIf dvConExist.Count > 1 Then
                        '    Me.txtShip.Focus()
                        '    MessageBox.Show("请确定船名航次", "提示")
                    Else
                        'dvConExist.RowFilter = ""   '当前没有，再找完成的
                        'If dvConExist.Count = 1 Then     '这种情况其实不存在
                        '    sqlTbCon = ""   '找完成的
                        '    FindData()
                        'ElseIf dvConExist.Count > 1 Then
                        '    Me.txtShip.Focus()
                        '    MessageBox.Show("请确定船名航次", "提示")
                        'End If
                        Me.txtShip.Focus()
                        MessageBox.Show("请确定船名航次", "提示")
                    End If
                Else
                    Me.txtContainer.Focus()
                    MessageBox.Show("该箱号不存在", "提示")
                End If
            ElseIf Me.txtShip.Text <> "" AndAlso Me.txtVoyage.Text <> "" Then
                '用船次箱号判断重复存在
                sqlConExist = "SELECT DISTINCT CODE_VESSEL,VOYAGE,CTN_NO,ImportMark FROM TB_CONLOAD_CON WHERE CODE_VESSEL='" & Me.txtShip.Text & "' and VOYAGE='" & Me.txtVoyage.Text & "' and CTN_NO='" & Me.txtContainer.Text & "'"
                dvConExist = db_rp.Filldata(sqlConExist)
                If dvConExist.Count = 1 Then
                    '不管状态，直接找
                    sqlTbCon = "SELECT * FROM TB_CONLOAD_CON WHERE CODE_VESSEL='" & Me.txtShip.Text & "' and VOYAGE='" & Me.txtVoyage.Text & "' and CTN_NO = '" & Me.txtContainer.Text & "' ORDER BY AutoID DESC"
                    FindData()
                ElseIf dvConExist.Count > 1 Then    '必定是一种当前的一种完成的
                    '只找当前的
                    sqlTbCon = "SELECT * FROM TB_CONLOAD_CON WHERE CODE_VESSEL='" & Me.txtShip.Text & "' and VOYAGE='" & Me.txtVoyage.Text & "' and CTN_NO = '" & Me.txtContainer.Text & "' and ImportMark = '0' ORDER BY AutoID DESC"
                    FindData()
                Else
                    Me.txtShip.Focus()
                    MessageBox.Show("该船次箱号不存在", "提示")
                End If
            End If
        Else
            Me.txtContainer.Focus()
            MessageBox.Show("请输入箱号", "提示")
        End If
        If blFind = False Then
            Me.lbOuter.Text = "查找失败！"
        End If
    End Sub

    Private Sub FindData()
        On Error Resume Next
        blFind = False
        dvTbCon = db_rp.Updatedata(daTbCon, sqlTbCon, dsTbCon)
        If dvTbCon.Count > 0 Then
            ClearWindow()
            '填数据
            strEdiID = dvTbCon(0)("EDIID")
            strShip = dvTbCon(0)("CODE_VESSEL")
            strFindShipEng = dvTbCon(0)("VESSEL")
            strVoyage = dvTbCon(0)("VOYAGE")
            strContainer = dvTbCon(0)("CTN_NO")
            FillCon()
            FillRelation()
            FillGoods()
            FillBill()
            blFind = True
            MarkOper = 0
            Me.txtMyShip.Text = strShip
            Me.txtMyVoyage.Text = strVoyage
            Me.lbMyContainer.Text = strContainer

            Me.txtMyShip.Focus()
            Me.btnMyFind.Focus()
            'SendKeys.Send("{Enter}")
            btnMyFind_Click(New Object(), New EventArgs())
        Else
            MessageBox.Show("意外的错误,重新来吧!", "提示")
        End If
    End Sub

    Private Sub ClearWindow()
        Me.lbShipName.Text = ""
        Me.txtConSize.Clear()
        Me.txtConType.Clear()
        Me.txtState.Clear()
        Me.txtSealNo.Clear()
        Me.dtpLoadDate.Value = Now
        Me.txtConOperCode.Clear()
        Me.txtConOper.Clear()
        Me.txtFront.Clear()
        Me.txtBack.Clear()
        Me.txtLeft.Clear()
        Me.txtRight.Clear()
        Me.txtTop.Clear()
        Me.txtAmount.Clear()
        Me.txtTareWeight.Clear()
        Me.txtNetWeight.Clear()
        Me.txtMeasure.Clear()

        Me.txtDamageAmount.Clear()
        Me.txtDamageDesc.Clear()
        Me.txtSecSealNo.Clear()
        Me.txtOpenSealReason.Clear()
        Me.ccbGoods.SelectedIndex = 0
        Me.txtGoodsSpec.Clear()
        Me.cbDescribe.SelectedIndex = 0
        Me.cbState.SelectedIndex = 0
        Me.cbConLoadType.SelectedIndex = 0
    End Sub

    Private Sub FillCon()   '填箱数据
        On Error Resume Next
        Me.lbShip.Text = strShip
        Me.lbShipName.Text = dvTbCon(0)("VESSEL")
        Me.lbVoyage.Text = strVoyage
        Me.lbContainer.Text = strContainer
        If dvTbCon(0)("ImportMark") = "0" Then
            Me.lbOuter.Text = "该箱数据未曾导入"
        Else
            Me.lbOuter.Text = "该箱数据已导入过"
        End If
        If Not IsDBNull(dvTbCon(0)("CTN_SIZETYPE")) Then
            Dim str As String = dvTbCon(0)("CTN_SIZETYPE")
            Me.txtConSize.Text = str.Substring(0, 2)
            Me.txtConType.Text = str.Substring(2, 2)
        End If
        Me.txtState.Text = dvTbCon(0)("CTN_STATUS")
        Me.txtSealNo.Text = dvTbCon(0)("CTN_SRALNO")
        Me.dtpLoadDate.Value = dvTbCon(0)("CTN_STUFFINGTIME")
        Me.txtConOperCode.Text = dvTbCon(0)("CODE_OPERATOR")
        Me.txtConOper.Text = dvTbCon(0)("OPERATOR")
        Me.txtFront.Text = dvTbCon(0)("OVER_FRONT")
        Me.txtBack.Text = dvTbCon(0)("OVER_BACK")
        Me.txtLeft.Text = dvTbCon(0)("OVER_LEFT")
        Me.txtRight.Text = dvTbCon(0)("OVER_RIGHT")
        Me.txtTop.Text = dvTbCon(0)("OVER_HEIGHT")
        Me.txtAmount.Text = dvTbCon(0)("CTN_PKGSNUM")
        Me.txtTareWeight.Text = dvTbCon(0)("CTN_TAREWEIGHT")
        Me.txtNetWeight.Text = dvTbCon(0)("CTN_NETWEIGHT")
        Me.txtMeasure.Text = dvTbCon(0)("CARGO_MEASUREMENT")
        Me.cbPlace.SelectedValue = dvTbCon(0)("CODE_CONLOADPLACE")
        If Me.cbPlace.SelectedIndex = 0 Then
            Me.cbPlace.SelectedValue = dvTbCon(0)("CODE_CONLOADPLACE")
        End If
        If Me.cbPlace.SelectedIndex = -1 Then
            MessageBox.Show("场站代码无效!", "提示")
            Me.cbPlace.SelectedValue = strDefaultYard
        End If
        '检查桥防错处理
        If G_DeptCode = strCheckDept OrElse G_DeptCode = strCheckDept2 Then
            '港内 凯远 外运 院前 物流 冷库
            If Me.cbPlace.SelectedValue = "01" OrElse Me.cbPlace.SelectedValue = "02" OrElse Me.cbPlace.SelectedValue = "04" _
                OrElse Me.cbPlace.SelectedValue = "05" OrElse Me.cbPlace.SelectedValue = "06" OrElse Me.cbPlace.SelectedValue = "09" Then

            Else
                Me.cbPlace.SelectedValue = strYard
            End If
        End If
    End Sub

    Private Sub FillRelation()
        '同一EDIID必定同船次
        sqlTbRelation = "select AutoID,BLNO,CARGOSEQUENCENO,CTN_PKGSNUM,CTN_TAREWEIGHT,CTN_NETWEIGHT,CARGO_MEASUREMENT from Tb_ConLoad_Rel where EDIID='" & strEdiID & "' and CTN_NO='" & strContainer & "' order by BLNO,CARGOSEQUENCENO"
        dvTbRelation = db_rp.Updatedata(daTbRelation, sqlTbRelation, dsTbRelation)
        Me.C1Relation.DataSource = dvTbRelation
        Me.C1Relation.Columns("BLNO").Caption = "提单号"
        Me.C1Relation.Columns("CARGOSEQUENCENO").Caption = "货号"
        Me.C1Relation.Columns("CTN_PKGSNUM").Caption = "件数"
        Me.C1Relation.Columns("CTN_TAREWEIGHT").Caption = "皮重"
        Me.C1Relation.Columns("CTN_NETWEIGHT").Caption = "货重"
        Me.C1Relation.Columns("CARGO_MEASUREMENT").Caption = "尺码"
        Me.C1Relation.Splits(0).DisplayColumns("BLNO").Locked = True
        Me.C1Relation.Splits(0).DisplayColumns("CARGOSEQUENCENO").Locked = True
        Me.C1Relation.Splits(0).DisplayColumns("AutoID").Visible = False
        SetDGWidth(Me.C1Relation)
    End Sub

    Private Sub FillGoods()
        sqlTbGoods = "SELECT AutoID,BLNO,CARGOSEQUENCENO,MARKS,CODE_CARGOHS,CARGO_SPECIFICATION,CARGODESCR,PKGSNUM,CODE_PKGS,PACKAGES,CARGO_GROSSWEIGHT,CARGO_MEASUREMENT,TEMP_ID,TEMP_SETTING,TEMP_MAX,TEMP_MIN,DANGEROUS_CLASS,DANGEROUS_PAGE,DANGEROUS_UNNO,DANGEROUS_LABEL,DANGEROUS_FLASHPOINT,DANGEROUS_EMSNO,DANGEROUS_MFAGNO,DANGEROUS_MPT,DANGEROUS_EMERGENCYCONTACT,AgentCode,AgentName,ShiperCode,Shiper,ReceiverCode,Receiver FROM TB_CONLOAD_CARGO " & _
            " where EDIID='" & strEdiID & "' and BLNO+CARGOSEQUENCENO in (select BLNO+CARGOSEQUENCENO from Tb_ConLoad_Rel where EDIID='" & strEdiID & "' and CTN_NO='" & strContainer & "') order by BLNO,CARGOSEQUENCENO"
        dvTbGoods = db_rp.Updatedata(daTbGoods, sqlTbGoods, dsTbGoods)
        Me.C1Goods.DataSource = dvTbGoods
        Me.C1Goods.Columns("BLNO").Caption = "提单号"
        Me.C1Goods.Columns("CARGOSEQUENCENO").Caption = "货号"
        Me.C1Goods.Columns("MARKS").Caption = "标志"
        Me.C1Goods.Columns("CODE_CARGOHS").Caption = "海关货码"
        Me.C1Goods.Columns("CARGO_SPECIFICATION").Caption = "货物规格"
        Me.C1Goods.Columns("CARGODESCR").Caption = "货物描述"
        Me.C1Goods.Columns("PKGSNUM").Caption = "件数"
        Me.C1Goods.Columns("CODE_PKGS").Caption = "包装代码"    '要
        Me.C1Goods.Columns("PACKAGES").Caption = "包装名称"
        Me.C1Goods.Columns("CARGO_GROSSWEIGHT").Caption = "货毛重"
        Me.C1Goods.Columns("CARGO_MEASUREMENT").Caption = "货尺码"
        Me.C1Goods.Columns("TEMP_ID").Caption = "温标"
        Me.C1Goods.Columns("TEMP_SETTING").Caption = "冷藏温度"
        Me.C1Goods.Columns("TEMP_MAX").Caption = "最大温度"
        Me.C1Goods.Columns("TEMP_MIN").Caption = "最小温度"
        Me.C1Goods.Columns("DANGEROUS_CLASS").Caption = "危品等级"
        Me.C1Goods.Columns("DANGEROUS_PAGE").Caption = "危品页号"
        Me.C1Goods.Columns("DANGEROUS_UNNO").Caption = "危品编号"
        Me.C1Goods.Columns("DANGEROUS_LABEL").Caption = "危品标签"
        Me.C1Goods.Columns("DANGEROUS_FLASHPOINT").Caption = "危品闪点"
        Me.C1Goods.Columns("DANGEROUS_EMSNO").Caption = "危品措施号"
        Me.C1Goods.Columns("DANGEROUS_MFAGNO").Caption = "急救指南号"
        Me.C1Goods.Columns("DANGEROUS_MPT").Caption = "海运污染"
        Me.C1Goods.Columns("DANGEROUS_EMERGENCYCONTACT").Caption = "应急措施"
        Me.C1Goods.Columns("AgentCode").Caption = "委托单位代码"    '要
        Me.C1Goods.Columns("AgentName").Caption = "委托单位名称"
        Me.C1Goods.Columns("ShiperCode").Caption = "发货人代码"
        Me.C1Goods.Columns("Shiper").Caption = "发货人"
        Me.C1Goods.Columns("ReceiverCode").Caption = "收货人代码"
        Me.C1Goods.Columns("Receiver").Caption = "收货人"
        Me.C1Goods.Splits(0).DisplayColumns("BLNO").Locked = True
        'Me.C1Goods.Splits(0).DisplayColumns("CARGOSEQUENCENO").Locked = True
        Me.C1Goods.Splits(0).DisplayColumns("AutoID").Visible = False
        SetDGWidth2(Me.C1Goods)

        Dim sqlPack As String = "SELECT CODE_PACK,PACK_ENG FROM CODE_PACK WHERE CODE_PACK <> '000'"
        SetDGCombox(Me.C1Goods, "CODE_PKGS", sqlPack)
        Dim sqlAgent As String = "SELECT TB_Code,SHIPAGENT_SHORT FROM CODE_SHIP_AGENT where Mark <> '1' OR Mark IS NULL ORDER BY SHIPAGENT_SHORT"
        SetDGCombox(Me.C1Goods, "AgentCode", sqlAgent, True, 20)
        Dim sqlAgentName As String = "SELECT SHIPAGENT_CHA,SHIPAGENT_SHORT FROM CODE_SHIP_AGENT where Mark <> '1' OR Mark IS NULL ORDER BY SHIPAGENT_CHA"
        SetDGCombox(Me.C1Goods, "AgentName", sqlAgentName, False, 20)
    End Sub

    Private Sub FillBill()
        sqlTbBill = "SELECT autoid,BLNO,CODE_SHIPPINGLINE,SHIPPINGLINE,LINERID,CODE_NATIONALITY,CODE_LOADPORT,LOADPORT,CODE_DISCHARGEPORT,DISCHARGEPORT,CODE_TRANSFERPORT,TRANSFERPORT,CODE_DELIVERY,DELIVERY FROM TB_CONLOAD " & _
            " where EDIID='" & strEdiID & "'and BLNO in (select distinct BLNO from Tb_ConLoad_Rel where EDIID='" & strEdiID & "' and CTN_NO='" & strContainer & "') order by BLNO"
        dvTbBill = db_rp.Updatedata(daTbBill, sqlTbBill, dsTbBill)
        Me.C1Bill.DataSource = dvTbBill
        Me.C1Bill.Columns("BLNO").Caption = "提单号"
        Me.C1Bill.Columns("CODE_SHIPPINGLINE").Caption = "船公司码"
        Me.C1Bill.Columns("SHIPPINGLINE").Caption = "船公司"
        Me.C1Bill.Columns("LINERID").Caption = "班轮"
        Me.C1Bill.Columns("CODE_NATIONALITY").Caption = "国籍代码"
        Me.C1Bill.Columns("CODE_LOADPORT").Caption = "装港代码"
        Me.C1Bill.Columns("LOADPORT").Caption = "装货港"
        Me.C1Bill.Columns("CODE_DISCHARGEPORT").Caption = "卸港代码"
        Me.C1Bill.Columns("DISCHARGEPORT").Caption = "卸货港"
        Me.C1Bill.Columns("CODE_TRANSFERPORT").Caption = "中转港代码"
        Me.C1Bill.Columns("TRANSFERPORT").Caption = "中转港"
        Me.C1Bill.Columns("CODE_DELIVERY").Caption = "交货地代码"
        Me.C1Bill.Columns("DELIVERY").Caption = "交货地"
        'Me.C1Bill.Splits(0).DisplayColumns("BLNO").Locked = True
        Me.C1Bill.Splits(0).DisplayColumns("AutoID").Visible = False
        SetDGWidth2(Me.C1Bill)

        Dim sqlNational As String = "SELECT NATIONALITY_ENG,NATIONALITY_CHA FROM CODE_NATIONALITY WHERE NATIONALITY_ENG <> '00' ORDER BY NATIONALITY_CHA"
        SetDGCombox(Me.C1Bill, "CODE_NATIONALITY", sqlNational)
        Dim sqlPort As String = "SELECT CODE_PORT,PORT_ENG,PORT_CHA FROM CODE_PORT WHERE CODE_PORT <> '00' ORDER BY PORT_CHA"
        SetDGCombox(Me.C1Bill, "CODE_LOADPORT", sqlPort, False, 20)
        SetDGCombox(Me.C1Bill, "CODE_DISCHARGEPORT", sqlPort, False, 20)
        SetDGCombox(Me.C1Bill, "CODE_TRANSFERPORT", sqlPort, False, 20)
        SetDGCombox(Me.C1Bill, "CODE_DELIVERY", sqlPort, False, 20)
        Dim sqlPortEng As String = "SELECT PORT_ENG,PORT_ENG PORT_ENG2 FROM CODE_PORT WHERE CODE_PORT <> '00' ORDER BY PORT_ENG"
        SetDGCombox(Me.C1Bill, "LOADPORT", sqlPortEng, False, 20)
        SetDGCombox(Me.C1Bill, "DISCHARGEPORT", sqlPortEng, False, 20)
        SetDGCombox(Me.C1Bill, "TRANSFERPORT", sqlPortEng, False, 20)
        SetDGCombox(Me.C1Bill, "DELIVERY", sqlPortEng, False, 20)
        Dim sqlShipName As String = "SELECT SHIPOWNER_SHORT, SHIPOWNER_SHORT AS Shipowner_short2 FROM CODE_SHIP_OWNER ORDER BY SHIPOWNER_SHORT"
        SetDGCombox(Me.C1Bill, "SHIPPINGLINE", sqlShipName, False, 20)
        Dim sqlShipCode As String = "SELECT CODE_SHIPOWNER, SHIPOWNER_SHORT FROM CODE_SHIP_OWNER ORDER BY SHIPOWNER_SHORT"
        SetDGCombox(Me.C1Bill, "CODE_SHIPPINGLINE", sqlShipCode, False, 20)
    End Sub

    Private Sub C1Goods_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles C1Goods.AfterColUpdate
        If e.ColIndex = 8 Then
            Me.C1Goods.Columns("PACKAGES").Text = Me.C1Goods.Columns("CODE_PKGS").Text
        ElseIf e.ColIndex = 12 Then
            If Me.C1Goods.Columns("TEMP_ID").Text <> Me.C1Goods.Columns("TEMP_ID").Text.Trim().ToUpper() Then
                Me.C1Goods.Columns("TEMP_ID").Text = Me.C1Goods.Columns("TEMP_ID").Text.Trim().ToUpper()
                If Me.C1Goods.Columns("TEMP_ID").Text <> "C" AndAlso Me.C1Goods.Columns("TEMP_ID").Text <> "F" Then
                    Me.C1Goods.Columns("TEMP_ID").Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub C1Bill_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles C1Bill.AfterColUpdate
        'If e.ColIndex = 6 Then
        '    Me.C1Bill.Columns("LOADPORT").Text = Me.C1Bill.Columns("CODE_LOADPORT").Text
        'ElseIf e.ColIndex = 8 Then
        '    Me.C1Bill.Columns("DISCHARGEPORT").Text = Me.C1Bill.Columns("CODE_DISCHARGEPORT").Text
        'ElseIf e.ColIndex = 10 Then
        '    Me.C1Bill.Columns("TRANSFERPORT").Text = Me.C1Bill.Columns("CODE_TRANSFERPORT").Text
        'ElseIf e.ColIndex = 12 Then
        '    Me.C1Bill.Columns("DELIVERY").Text = Me.C1Bill.Columns("CODE_DELIVERY").Text
        'End If
    End Sub

    Private Sub C1Relation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1Relation.KeyDown
        If Me.C1Relation.Col = 6 AndAlso e.KeyCode = Keys.Enter Then
            Me.C1Relation.Row += 1
        End If
    End Sub

    Private Sub C1Goods_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1Goods.KeyDown
        If Me.C1Goods.Col = 30 AndAlso e.KeyCode = Keys.Enter Then
            Me.C1Goods.Row += 1
        End If
    End Sub

    Private Sub C1Bill_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1Bill.KeyDown
        If Me.C1Bill.Col = 13 AndAlso e.KeyCode = Keys.Enter Then
            Me.C1Bill.Row += 1
        End If
    End Sub

    Dim strReportShip, strReportShipName, strReportVoyage As String
    Private Sub btnCreateReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateReport.Click
        If blFind = False Then  '没有找到不执行
            Exit Sub
        End If
        If MarkOper = 0 OrElse MarkOper = 1 Then
            strReportShip = strShip
            strReportShipName = strFindShipEng
            strReportVoyage = strVoyage
        ElseIf MarkOper = 2 Then
            strReportShip = strMyShip
            strReportShipName = strNewShipEng
            strReportVoyage = strMyVoyage
        End If
        On Error GoTo Err
        Dim sqlstr As String
        Dim strFile As String
        Dim txtline As String
        Dim ShipOwner As String
        Dim s As String
        Dim str1, str2 As String
        Dim ds As New DataSet
        Dim dss As New DataSet
        Dim dst As New DataSet
        Dim i As Integer = 0 '记录行数
        Dim j As Integer
        Dim k As Integer
        Dim L As Integer
        Dim nnnn As String
        Dim Temp As String

        If strEdiID.Trim().Length() > 0 Then
            strFile = FilePathStr.Trim() & UCase(strReportShip) & UCase(strReportVoyage) & UCase(strContainer) & ".txt"
            File.Delete(strFile)
            Dim sw As New StreamWriter(strFile, FileMode.OpenOrCreate, System.Text.Encoding.Default()) '打开报文文件
            '********************************00
            txtline = "00:COSTCO:CONTAINER LOAD PLAN:9:LYGWL:LYGXDF:" & Trim(CType(Year(Now), String))
            s = Mid("0" & Trim(CType(Month(Now), String)), Len("0" & Trim(CType(Month(Now), String))) - 1, 2)
            txtline = txtline & s
            s = Mid("0" & Trim(CType(VBMethod.Day(Now), String)), Len("0" & Trim(CType(VBMethod.Day(Now), String))) - 1, 2)
            txtline = txtline & s
            s = Mid("0" & Trim(CType(Hour(Now), String)), Len("0" & Trim(CType(Hour(Now), String))) - 1, 2)
            txtline = txtline & s
            s = Mid("0" & Trim(CType(Minute(Now), String)), Len("0" & Trim(CType(Minute(Now), String))) - 1, 2)
            txtline = txtline & s & "'"
            sw.WriteLine(txtline)
            '*******************************10
            sqlstr = "select * from TB_CONLOAD where EDIID=" & strEdiID.Trim()
            ds.Reset()
            If db_rp.Getdata(sqlstr, ds).Count = 0 Then
                txtline = "10:" & UCase(strReportShip) & ":" & UCase(strReportShipName) & ":" & UCase(strReportVoyage) & "::::'"
            Else
                txtline = "10:" & UCase(strReportShip) & ":" & UCase(strReportShipName) & ":" & UCase(strReportVoyage) & ":" & Trim(ds.Tables(0).Rows(0)("CODE_SHIPPINGLINE")) & ":" & Trim(ds.Tables(0).Rows(0)("SHIPPINGLINE")) & "::'"
            End If
            sw.WriteLine(txtline)
            i = 2
            j = 1
            '*******************************50
            sqlstr = "select * from TB_CONLOAD_CON where EDIID =" & strEdiID.Trim() & " and CTN_NO='" & strContainer.Trim() & "'"
            dss.Reset()
            If db_rp.Getdata(sqlstr, dss).Count > 0 Then

                Do While j <= dss.Tables(0).Rows.Count

                    txtline = "50:" & Trim(dss.Tables(0).Rows(j - 1).Item("CTN_NO")) & ":"
                    txtline = txtline & Trim(dss.Tables(0).Rows(j - 1).Item("CTN_SIZETYPE"))
                    txtline = txtline & ":" & Trim(dss.Tables(0).Rows(j - 1).Item("CTN_STATUS")) & ":0:" & Trim(dss.Tables(0).Rows(j - 1).Item("CODE_CONLOADPLACE")) & "::"
                    txtline = txtline & Trim(CType(Year(dss.Tables(0).Rows(j - 1).Item("CTN_STUFFINGTIME")), String))
                    s = Mid("0" & Trim(CType(Month(dss.Tables(0).Rows(j - 1).Item("CTN_STUFFINGTIME")), String)), Len("0" & Trim(CType(Month(dss.Tables(0).Rows(j - 1).Item("CTN_STUFFINGTIME")), String))) - 1, 2)
                    txtline = txtline & s
                    s = Mid("0" & Trim(CType(VBMethod.Day(dss.Tables(0).Rows(j - 1).Item("CTN_STUFFINGTIME")), String)), Len("0" & Trim(CType(VBMethod.Day(dss.Tables(0).Rows(j - 1).Item("CTN_STUFFINGTIME")), String))) - 1, 2)
                    txtline = txtline & s
                    s = Mid("0" & Trim(CType(Hour(dss.Tables(0).Rows(j - 1).Item("CTN_STUFFINGTIME")), String)), Len("0" & Trim(CType(Hour(dss.Tables(0).Rows(j - 1).Item("CTN_STUFFINGTIME")), String))) - 1, 2)
                    txtline = txtline & s
                    s = Mid("0" & Trim(CType(Minute(dss.Tables(0).Rows(j - 1).Item("CTN_STUFFINGTIME")), String)), Len("0" & Trim(CType(Minute(dss.Tables(0).Rows(j - 1).Item("CTN_STUFFINGTIME")), String))) - 1, 2)
                    txtline = txtline & s
                    txtline = txtline & ":" & Trim(dss.Tables(0).Rows(j - 1).Item("CTN_SRALNO"))
                    txtline = txtline & ":" & Trim(dss.Tables(0).Rows(j - 1).Item("CODE_OPERATOR"))
                    txtline = txtline & ":" & Trim(dss.Tables(0).Rows(j - 1).Item("OPERATOR"))

                    txtline = txtline & ":" & Trim(dss.Tables(0).Rows(j - 1).Item("OVER_FRONT"))
                    txtline = txtline & ":" & Trim(dss.Tables(0).Rows(j - 1).Item("OVER_BACK"))
                    txtline = txtline & ":" & Trim(dss.Tables(0).Rows(j - 1).Item("OVER_RIGHT"))
                    txtline = txtline & ":" & Trim(dss.Tables(0).Rows(j - 1).Item("OVER_LEFT"))
                    txtline = txtline & ":" & Trim(dss.Tables(0).Rows(j - 1).Item("OVER_HEIGHT"))
                    txtline = txtline & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                    j = j + 1
                Loop
            End If

            '***************************** 提单循环
            sqlstr = " select * from TB_CONLOAD_REL where EDIID =" & strEdiID.Trim() & " and CTN_NO='" & strContainer.Trim() & "'"
            dss.Reset()
            If db_rp.Getdata(sqlstr, dss).Count > 0 Then
                j = 1
                str1 = ""
                str2 = ""
                Do While j <= dss.Tables(0).Rows.Count
                    str1 = "'" & Trim(dss.Tables(0).Rows(j - 1).Item("BLNO")) & "',"
                    str2 = "'" & Trim(dss.Tables(0).Rows(j - 1).Item("CARGOSEQUENCENO")) & "',"
                    j = j + 1
                Loop
            End If

            str1 = str1.Trim().Substring(0, str1.Trim().Length() - 1)

            str2 = str2.Trim().Substring(0, str2.Trim().Length() - 1)

            sqlstr = "select *  from TB_CONLOAD where EDIID=" & strEdiID & " and UPPER(BLNO) IN (" & str1 & ") "
            ds.Reset()
            If db_rp.Getdata(sqlstr, ds).Count > 0 Then
                j = 1
                Do While j <= ds.Tables(0).Rows.Count
                    '************************************51
                    txtline = "51:" & Trim(ds.Tables(0).Rows(j - 1).Item("BLNO"))
                    txtline = txtline & ":" & Trim(ds.Tables(0).Rows(j - 1).Item("CODE_DISCHARGEPORT"))
                    txtline = txtline & ":" & Trim(ds.Tables(0).Rows(j - 1).Item("DISCHARGEPORT"))
                    txtline = txtline & ":" & Trim(ds.Tables(0).Rows(j - 1).Item("CODE_LOADPORT"))
                    txtline = txtline & ":" & Trim(ds.Tables(0).Rows(j - 1).Item("LOADPORT"))
                    txtline = txtline & ":" & Trim(ds.Tables(0).Rows(j - 1).Item("CODE_TRANSFERPORT"))
                    txtline = txtline & ":" & Trim(ds.Tables(0).Rows(j - 1).Item("TRANSFERPORT"))
                    txtline = txtline & ":" & Trim(ds.Tables(0).Rows(j - 1).Item("CODE_DELIVERY"))
                    txtline = txtline & ":" & Trim(ds.Tables(0).Rows(j - 1).Item("DELIVERY"))
                    sqlstr = "select *  from TB_CONLOAD_CARGO where EDIID=" & strEdiID & " and BLNO='" & Trim(ds.Tables(0).Rows(j - 1).Item("BLNO")) & "' "
                    dss.Reset()
                    If db_rp.Getdata(sqlstr, dss).Count > 0 Then
                        '*******************************************
                        txtline = txtline & ":" & Trim(dss.Tables(0).Rows(0).Item("AgentCode"))
                        txtline = txtline & ":" & Trim(dss.Tables(0).Rows(0).Item("AgentName"))
                    Else
                        txtline = txtline & "::"
                    End If
                    txtline = txtline & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                    '***********************************16
                    sqlstr = "select *  from TB_CONLOAD_CARGO where EDIID=" & strEdiID & " and BLNO='" & Trim(ds.Tables(0).Rows(j - 1).Item("BLNO")) & "' "
                    dss.Reset()
                    If db_rp.Getdata(sqlstr, dss).Count > 0 Then
                        '*******************************************
                        txtline = "16:" & Trim(dss.Tables(0).Rows(0).Item("ShiperCode"))
                        txtline = txtline & ":" & Trim(dss.Tables(0).Rows(0).Item("Shiper"))

                        txtline = txtline & "'"
                        sw.WriteLine(txtline)
                        i = i + 1
                    End If
                    '***********************************17
                    dss.Reset()
                    sqlstr = "select *  from TB_CONLOAD_CARGO where EDIID=" & strEdiID & " and BLNO='" & Trim(ds.Tables(0).Rows(j - 1).Item("BLNO")) & "' "
                    If db_rp.Getdata(sqlstr, dss).Count > 0 Then
                        '*******************************************
                        txtline = "17:" & Trim(dss.Tables(0).Rows(0).Item("ReceiverCode"))
                        txtline = txtline & ":" & Trim(dss.Tables(0).Rows(0).Item("Receiver"))
                        txtline = txtline & "'"
                        sw.WriteLine(txtline)
                        i = i + 1
                    End If
                    '************************************52
                    dss.Reset()
                    sqlstr = "select *  from TB_CONLOAD_CARGO where EDIID=" & strEdiID & " and BLNO='" & Trim(ds.Tables(0).Rows(j - 1).Item("BLNO")) & "' "

                    If db_rp.Getdata(sqlstr, dss).Count > 0 Then
                        L = 1
                        Do While L <= dss.Tables(0).Rows.Count
                            txtline = "52:" & Trim(dss.Tables(0).Rows(L - 1).Item("CARGOSEQUENCENO")) & ":" & Trim(dss.Tables(0).Rows(L - 1).Item("CODE_CARGOHS")) & ":" & Trim(dss.Tables(0).Rows(L - 1).Item("CARGO_SPECIFICATION")) & ":"
                            dst.Reset()
                            sqlstr = "select DISTINCT EDIID,BLNO,CARGOSEQUENCENO,CTN_NO,CTN_PKGSNUM,CTN_TAREWEIGHT,CTN_NETWEIGHT,CARGO_MEASUREMENT from TB_CONLOAD_REL where EDIID=" & strEdiID & " and BLNO= '" & Trim(ds.Tables(0).Rows(j - 1).Item("BLNO")) & "' and CARGOSEQUENCENO='" + Trim(dss.Tables(0).Rows(L - 1).Item("CARGOSEQUENCENO")) + "' and CTN_NO='" & strContainer.Trim() & "'"
                            If db_rp.Getdata(sqlstr, dst).Count > 0 Then
                                txtline = txtline & Trim(dst.Tables(0).Rows(0).Item("CTN_PKGSNUM")) & ":"
                                txtline = txtline & Trim(dss.Tables(0).Rows(L - 1).Item("CODE_PKGS")) & ":" & Trim(dss.Tables(0).Rows(L - 1).Item("PACKAGES")) & ":"
                                txtline = txtline & Trim(dst.Tables(0).Rows(0).Item("CTN_NETWEIGHT")) & ":"
                                txtline = txtline & Trim(dst.Tables(0).Rows(0).Item("CARGO_MEASUREMENT")) & ":"
                            Else
                                txtline = txtline & Trim(dss.Tables(0).Rows(L - 1).Item("PKGSNUM")) & ":"
                                txtline = txtline & Trim(dss.Tables(0).Rows(L - 1).Item("CODE_PKGS")) & ":" & Trim(dss.Tables(0).Rows(L - 1).Item("PACKAGES")) & ":"
                                txtline = txtline & Trim(dss.Tables(0).Rows(L - 1).Item("CARGO_GROSSWEIGHT")) & ":"
                                txtline = txtline & Trim(dss.Tables(0).Rows(L - 1).Item("CARGO_MEASUREMENT")) & ":"
                            End If
                            txtline = txtline & Trim(dss.Tables(0).Rows(L - 1).Item("TEMP_ID")) & ":"
                            txtline = txtline & Trim(dss.Tables(0).Rows(L - 1).Item("TEMP_SETTING")) & ":"
                            txtline = txtline & Trim(dss.Tables(0).Rows(L - 1).Item("TEMP_MAX")) & ":"
                            txtline = txtline & Trim(dss.Tables(0).Rows(L - 1).Item("TEMP_MIN")) & ""
                            txtline = txtline & "'"

                            sw.WriteLine(txtline)
                            i = i + 1
                            '************************************53
                            'txtline = "53:" & Trim(dss.Tables(0).Rows(L - 1).Item("CARGODESCR")) & "'"
                            If Not IsDBNull(dss.Tables(0).Rows(L - 1).Item("CARGODESCR")) Then

                                txtline = "53" '& Trim(dss.Tables(0).Rows(j - 1).Item("GOODSCHA")) & "'"
                                Temp = Trim(dss.Tables(0).Rows(L - 1).Item("CARGODESCR"))
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
                            'txtline = "54:" & Trim(dss.Tables(0).Rows(L - 1).Item("MARKS")) & "'"
                            If Not IsDBNull(dss.Tables(0).Rows(L - 1).Item("MARKS")) Then

                                txtline = "54" '& Trim(dss.Tables(0).Rows(j - 1).Item("GOODSCHA")) & "'"
                                Temp = Trim(dss.Tables(0).Rows(L - 1).Item("MARKS"))
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
                            If Trim(dss.Tables(0).Rows(L - 1).Item("DANGEROUS_CLASS")).Length() > 0 Then

                                txtline = "55:" & Trim(dss.Tables(0).Rows(L - 1).Item("DANGEROUS_CLASS")) & ":"
                                txtline = txtline & ":"
                                txtline = txtline & ":"
                                txtline = txtline & ":'"
                                txtline = txtline & ":"
                                txtline = txtline & ":"
                                txtline = txtline & ":"
                                txtline = txtline & "'"

                                sw.WriteLine(txtline)
                                i = i + 1

                            End If

                            '************************************56
                            dst.Reset()
                            sqlstr = "select DISTINCT EDIID,BLNO,CARGOSEQUENCENO,CTN_NO,CTN_PKGSNUM,CTN_TAREWEIGHT,CTN_NETWEIGHT,CARGO_MEASUREMENT from TB_CONLOAD_REL where EDIID=" & strEdiID & " and BLNO= '" & Trim(ds.Tables(0).Rows(j - 1).Item("BLNO")) & "' and CARGOSEQUENCENO='" + Trim(dss.Tables(0).Rows(L - 1).Item("CARGOSEQUENCENO")) + "' and CTN_NO='" & strContainer.Trim() & "'"
                            If db_rp.Getdata(sqlstr, dst).Count > 0 Then
                                k = 1
                                Do While k <= dst.Tables(0).Rows.Count
                                    txtline = "56:" & Trim(dst.Tables(0).Rows(k - 1).Item("CTN_NO")) & ":"
                                    txtline = txtline & Trim(dst.Tables(0).Rows(k - 1).Item("CTN_PKGSNUM")) & ":"
                                    txtline = txtline & Trim(dst.Tables(0).Rows(k - 1).Item("CTN_TAREWEIGHT")) & ":"
                                    txtline = txtline & Trim(dst.Tables(0).Rows(k - 1).Item("CTN_NETWEIGHT")) & ":"
                                    txtline = txtline & Trim(dst.Tables(0).Rows(k - 1).Item("CARGO_MEASUREMENT"))

                                    txtline = txtline & "'"
                                    sw.WriteLine(txtline)
                                    i = i + 1
                                    k = k + 1
                                Loop
                            End If
                            L = L + 1
                        Loop
                    End If
                    j = j + 1
                Loop

            End If
            txtline = "99:" & i + 1 & "'"
            sw.WriteLine(txtline)
            MsgBox("报文已生成完毕，共 " & i + 1 & " 行 ")
            sw.Close()
        Else
            MsgBox(" 箱子未找到！")
        End If
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

    Dim MarkOper As Integer = -1 '表示最后的操作 0 查找,1 保存,2 导入
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Dim blNext As Boolean
            Dim i, j As Integer
            If blFind Then
                blNext = True
            Else
                Me.txtContainer.Focus()
                MessageBox.Show("请查找外部数据确定箱信息", "提示")
            End If
            '船次不空
            If blNext Then
                If Me.txtMyShip.Text = "" OrElse Me.txtMyVoyage.Text = "" Then
                    Me.txtMyShip.Focus()
                    MessageBox.Show("修改船次不可空", "提示")
                    blNext = False
                End If
            End If
            '检查提单
            '检查不空
            If blNext Then
                blNext = Not ColHasEmpty(Me.C1Bill, dvTbBill, "BLNO")
            End If
            '检查提单界面重复
            If blNext Then
                blNext = Not ColHasRepeat(Me.C1Bill, dvTbBill, "BLNO")
            End If
            '检查提单数据库中同一EDIID中重复
            Dim sqlBillExist As String
            Dim dvBillExist As DataView
            If blNext Then
                For i = 0 To dvTbBill.Count - 1
                    sqlBillExist = "select BLNO from TB_CONLOAD where EDIID='" & strEdiID & "' and BLNO='" & Me.C1Bill.Columns("BLNO").CellValue(i) & "' and autoid<>" & Me.C1Bill.Columns("autoid").CellValue(i)
                    dvBillExist = db_rp.Filldata(sqlBillExist)
                    If dvBillExist.Count > 0 Then
                        Exit For
                    End If
                Next
                If i < dvTbBill.Count Then
                    Me.C1Bill.Row = i
                    Me.C1Bill.SelectedRows.Clear()
                    Me.C1Bill.SelectedRows.Add(Me.C1Bill.Row)
                    MessageBox.Show("该提单号在该报文中已存在,不可重复", "提示")
                    blNext = False
                End If
            End If

            '检查提单中货号
            '检查不空
            If blNext Then
                blNext = Not ColHasEmpty(Me.C1Goods, dvTbGoods, "CARGOSEQUENCENO")
            End If
            '检查界面重复
            If blNext Then
                For i = 0 To dvTbGoods.Count - 1
                    C1Goods.Row = i
                    For j = i + 1 To dvTbGoods.Count - 1
                        If C1Goods.Columns("BLNO").Text = C1Goods.Columns("BLNO").CellText(j) AndAlso C1Goods.Columns("CARGOSEQUENCENO").Text = C1Goods.Columns("CARGOSEQUENCENO").CellText(j) Then
                            Exit For
                        End If
                    Next
                    If j < dvTbGoods.Count Then
                        Exit For
                    End If
                Next
                If i < dvTbGoods.Count Then
                    C1Goods.Focus()
                    C1Goods.SelectedRows.Clear()
                    C1Goods.SelectedRows.Add(i)
                    C1Goods.SelectedRows.Add(j)
                    MessageBox.Show("第" & (i + 1) & "第" & (j + 1) & "行同一提单下货号重复", "提示")
                    blNext = False
                End If
            End If
            '检查数据库中同一EdiID同一提单中重复
            Dim sqlGoodsNoExist As String
            Dim dvGoodsNoExist As DataView
            If blNext Then
                For i = 0 To dvTbGoods.Count - 1
                    sqlGoodsNoExist = "select BLNO from TB_CONLOAD_CARGO where EDIID='" & strEdiID & "' and BLNO='" & Me.C1Goods.Columns("BLNO").CellValue(i) & "' and CARGOSEQUENCENO='" & Me.C1Goods.Columns("CARGOSEQUENCENO").CellValue(i) & "' and autoid<>" & Me.C1Goods.Columns("autoid").CellValue(i)
                    dvGoodsNoExist = db_rp.Filldata(sqlGoodsNoExist)
                    If dvGoodsNoExist.Count > 0 Then
                        Exit For
                    End If
                Next
                If i < dvTbGoods.Count Then
                    Me.C1Goods.Row = i
                    Me.C1Goods.SelectedRows.Clear()
                    Me.C1Goods.SelectedRows.Add(Me.C1Goods.Row)
                    MessageBox.Show("该提单此货号在该报文中已存在,不可重复", "提示")
                    blNext = False
                End If
            End If

            If blNext Then
                dvTbCon(0)("CTN_SIZETYPE") = Me.txtConSize.Text & Me.txtConType.Text
                dvTbCon(0)("CTN_STATUS") = Me.txtState.Text
                dvTbCon(0)("CTN_STUFFINGTIME") = Me.dtpLoadDate.Value
                dvTbCon(0)("CTN_SRALNO") = Me.txtSealNo.Text
                dvTbCon(0)("CODE_OPERATOR") = Me.txtConOperCode.Text
                dvTbCon(0)("OPERATOR") = Me.txtConOper.Text
                If IsNumeric(Me.txtFront.Text) Then
                    dvTbCon(0)("OVER_FRONT") = Me.txtFront.Text
                Else
                    dvTbCon(0)("OVER_FRONT") = DBNull.Value
                End If
                If IsNumeric(Me.txtBack.Text) Then
                    dvTbCon(0)("OVER_BACK") = Me.txtBack.Text
                Else
                    dvTbCon(0)("OVER_BACK") = DBNull.Value
                End If
                If IsNumeric(Me.txtRight.Text) Then
                    dvTbCon(0)("OVER_RIGHT") = Me.txtRight.Text
                Else
                    dvTbCon(0)("OVER_RIGHT") = DBNull.Value
                End If
                If IsNumeric(Me.txtLeft.Text) Then
                    dvTbCon(0)("OVER_LEFT") = Me.txtLeft.Text
                Else
                    dvTbCon(0)("OVER_LEFT") = DBNull.Value
                End If
                If IsNumeric(Me.txtTop.Text) Then
                    dvTbCon(0)("OVER_HEIGHT") = Me.txtTop.Text
                Else
                    dvTbCon(0)("OVER_HEIGHT") = DBNull.Value
                End If
                If IsNumeric(Me.txtAmount.Text) Then
                    dvTbCon(0)("CTN_PKGSNUM") = Me.txtAmount.Text
                Else
                    dvTbCon(0)("CTN_PKGSNUM") = DBNull.Value
                End If
                If IsNumeric(Me.txtTareWeight.Text) Then
                    dvTbCon(0)("CTN_TAREWEIGHT") = Me.txtTareWeight.Text
                Else
                    dvTbCon(0)("CTN_TAREWEIGHT") = DBNull.Value
                End If
                If IsNumeric(Me.txtNetWeight.Text) Then
                    dvTbCon(0)("CTN_NETWEIGHT") = Me.txtNetWeight.Text
                Else
                    dvTbCon(0)("CTN_NETWEIGHT") = DBNull.Value
                End If
                If IsNumeric(Me.txtMeasure.Text) Then
                    dvTbCon(0)("CARGO_MEASUREMENT") = Me.txtMeasure.Text
                Else
                    dvTbCon(0)("CARGO_MEASUREMENT") = DBNull.Value
                End If
                dvTbCon(0)("CODE_CONLOADPLACE") = Me.cbPlace.SelectedValue
                dvTbCon(0)("User_Name") = G_User

                '更新顺序不可变
                daTbCon.Update(dsTbCon)
                daTbRelation.Update(dsTbRelation)

                daTbGoods.Update(dsTbGoods)
                daTbBill.Update(dsTbBill)

                Me.txtContainer.Text = strContainer
                Me.txtShip.Text = Me.txtMyShip.Text
                Me.txtVoyage.Text = Me.txtMyVoyage.Text
                If Me.txtMyShip.Text <> strShip OrElse Me.txtMyVoyage.Text <> strVoyage Then    '改单修改船次
                    Dim sqlUpdateTbVessel As String = "Exec Sp_TbConLoad_Edit '" & Me.txtMyShip.Text & "','" & strTempShipEng & "','" & Me.txtMyVoyage.Text & "','" & strShip & "','" & strVoyage & "'"
                    'sqlUpdateTbVessel = "update TB_CONLOAD set CODE_VESSEL='" & Me.txtMyShip.Text & "',VESSEL='" & strTempShipEng & "',VOYAGE='" & Me.txtMyVoyage.Text & "' where CODE_VESSEL='" & strShip & "' and VOYAGE='" & strVoyage & "'"
                    db_rp.ExecSql(sqlUpdateTbVessel)
                    '日志
                    Dim strEditData As String
                    strEditData = strEdiID & "," & strShip & "," & strFindShipEng & "," & strVoyage & "<->" & txtMyShip.Text & "," & txtMyShipName.Text & "," & txtMyVoyage.Text
                    Dim sqlRecordLog As String
                    sqlRecordLog = "insert into OperateHistory (Dept_Name,OperateTime,OperateWorker,OperateType,OperateDemo,OperateTable) " & _
                        " values('" & G_DeptName & "',GetDate(),'" & G_User & "','导箱修改','" & strEditData & "','TB_CONLOAD')"
                    ExecSql(sqlRecordLog)
                    '更新界面
                    btnFind_Click(sender, e)
                Else
                    btnFind_Click(sender, e)
                End If
                MessageBox.Show("数据保存", "提示")
                MarkOper = 1
                Call Me.btnCreateReport_Click(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtMyShip_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMyShip.Leave
        txtMyShip.Text = txtMyShip.Text.Trim.ToUpper
        sqlShipCode = "SELECT SPCODE, CHI_VESSEL,Eng_VESSEL FROM Code_SHIPNAME WHERE (SPCODE = '" & Me.txtMyShip.Text & "' or CHI_VESSEL = '" & Me.txtMyShip.Text & "')"
        dvShipCode = Filldata(sqlShipCode)
        txtMyShipName.Clear()
        If dvShipCode.Count > 0 Then
            Me.txtMyShip.Text = dvShipCode(0)("SPCODE")
            If Not IsDBNull(dvShipCode(0)("CHI_VESSEL")) Then
                Me.txtMyShipName.Text = dvShipCode(0)("CHI_VESSEL")
            End If
            If Not IsDBNull(dvShipCode(0)("Eng_VESSEL")) Then
                strTempShipEng = dvShipCode(0)("Eng_VESSEL")
                Me.txtMyShipName.Text += "/" & dvShipCode(0)("ENG_VESSEL")
            Else
                strTempShipEng = ""
            End If
            shipMark = True
        Else
            shipMark = False
            MessageBox.Show("船码 " & Me.txtMyShip.Text & " 不存在，请重新输入", "提示")
        End If
    End Sub

    Private Sub txtMyVoyage_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMyVoyage.Leave
        txtMyVoyage.Text = txtMyVoyage.Text.Trim.ToUpper
    End Sub

    Private Sub cbPlace_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPlace.Leave
        If Not blMyConExist Then    '如果查找本系统箱号不存在就可以修改工作场站
            strMyYard = Me.cbPlace.SelectedValue
            Me.lbYard.Text = Me.cbPlace.Text
        End If
    End Sub

    Private Sub cbPlace2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPlace2.Leave
        cbPlace_Leave(sender, e)
    End Sub

    Dim blImport As Boolean '表示是否可以导入箱信息
    Dim blCheck As Boolean  '查验过标志 
    Dim blMyConExist As Boolean
    Dim sqlMyCon As String
    Dim dvMyCon As DataView '本系统箱信息

    Private Function GetYardName(ByVal strCode As String) As String   '得到场站名称
        Dim i As Integer
        For i = 0 To dvAllYard.Count - 1
            If Not IsDBNull(dvAllYard(i)("Code_Yard_ID")) Then
                If strCode = dvAllYard(i)("Code_Yard_ID") Then
                    Exit For
                End If
            End If
        Next
        If i < dvAllYard.Count Then
            Return dvAllYard(i)("Code_Yard_Name")
        Else
            Return ""
        End If
    End Function

    Dim blFirst As Boolean = True
    Dim sqlGoods As String
    Dim dvGoods As New DataView
    Dim sqlConLoadType As String
    Dim dvConLoadType As New DataView

    Private Sub btnMyFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMyFind.Click
        Try
            blMyFind = False
            Me.lbShow.Text = "开始查找……"
            '外部数据找到，船码有效，航次不空，查找
            If blFind And shipMark And txtMyVoyage.Text <> "" Then
                'sqlMyCon = "SELECT DAMAGED_AMOUNT,DAMAGED_PACK,SecSealNO,ReasonOpenSeal,StateC,BLNO,IsNull(AMOUNT,0) AMOUNT,IsNull(WEIGHT,0) WEIGHT,IsNull(NetWeight,0) NetWeight,VOLUME,CodeYard FROM CON_LOAD_TALLY_LIST WHERE CHI_VESSEL = '" & Me.txtMyShip.Text & "' AND Voyage = '" & Me.txtMyVoyage.Text & "' AND CONTAINER_NO = '" & strContainer & "' AND CodeYard = '" & Me.cbPlace.SelectedValue & "'"
                sqlMyCon = "SELECT DAMAGED_AMOUNT,DAMAGED_PACK,SecSealNO,ReasonOpenSeal,StateC,Checked,BLNO,IsNull(AMOUNT,0) AMOUNT,IsNull(WEIGHT,0) WEIGHT,IsNull(NetWeight,0) NetWeight,VOLUME,CodeYard FROM CON_LOAD_TALLY_LIST WHERE CHI_VESSEL = '" & Me.txtMyShip.Text & "' AND Voyage = '" & Me.txtMyVoyage.Text & "' AND CONTAINER_NO = '" & strContainer & "' order by StateC desc"
                '查箱信息不用场站条件，隐藏的问题就是这样任何场站都可以查任何的箱信息了，只要知道箱号以及船次。
                '或者控制如果检查桥就采用这种方式，否则就用原来用场站条件的方式。
                '现在不控制问题也不大，只要各场站的用户不知道互相的箱号，就没有问题。
                dvMyCon = Filldata(sqlMyCon)
                If dvMyCon.Count > 0 Then   '修改
                    Me.txtDamageAmount.Text = IIf(IsDBNull(dvMyCon(0)("DAMAGED_AMOUNT")), "", dvMyCon(0)("DAMAGED_AMOUNT"))
                    Me.txtDamageDesc.Text = IIf(IsDBNull(dvMyCon(0)("DAMAGED_PACK")), "", dvMyCon(0)("DAMAGED_PACK"))
                    Me.txtSecSealNo.Text = IIf(IsDBNull(dvMyCon(0)("SecSealNO")), "", dvMyCon(0)("SecSealNO"))
                    Me.txtOpenSealReason.Text = IIf(IsDBNull(dvMyCon(0)("ReasonOpenSeal")), "", dvMyCon(0)("ReasonOpenSeal"))
                    blMyConExist = True
                    If dvMyCon(0)("StateC") < "2" Then '如果出证后不可导入
                        blImport = True
                        Me.lbShow.Text = "该箱信息已存在"
                    Else
                        blImport = False   '不可导，但是可以查验
                        Me.lbShow.Text = "该箱信息已出证"
                    End If
                    If dvMyCon(0)("Checked") = "0" Then
                        blCheck = False
                        Me.lbCheck.Text = "该箱未查验"
                    Else
                        blCheck = True
                        Me.lbCheck.Text = "该箱查验过"
                    End If
                    strMyYard = dvMyCon(0)("CodeYard")  '存在，就用其场站。这种情况用户这里的查找不能选择场站
                    Me.lbYard.Text = GetYardName(strMyYard)
                    Me.cbPlace2.Visible = False
                Else    '新加
                    Me.txtDamageAmount.Clear()
                    Me.txtDamageDesc.Clear()
                    Me.txtSecSealNo.Clear()
                    Me.txtOpenSealReason.Clear()
                    blImport = True
                    blMyConExist = False
                    Me.lbShow.Text = "该箱信息不存在"
                    Me.lbCheck.Text = ""
                    strMyYard = Me.cbPlace.SelectedValue    '不存在，就用上面可选的场站代码。
                    Me.lbYard.Text = Me.cbPlace.Text
                    Me.cbPlace2.Visible = True
                End If

                Dim sqlSetMyBill As String
                'Con_Load_Tally中也有船码航次场站，何必要用In在Con_Load_Tally_List中查找。
                'sqlSetMyBill = "select MyBLNO,StateB,BLNO OldBLNO,BLNO,GoodsCha,GoodsSpec,CODE_TALLY_TYPE,DESCR,STATE,(Case when MyBLNO<>'' then '存在' else '不存在' end) Being,(Case when StateB>'1' then '不可导' else '可导' end) Import,0 Amount,0.0 Gross,0.0 Net,0.0 Measure from (SELECT BLNO FROM TB_CONLOAD where EDIID='" & strEdiID & "'and BLNO in (select distinct BLNO from Tb_ConLoad_Rel where EDIID='" & strEdiID & "' and CTN_NO='" & strContainer & "')) A " & _
                '    " left join (select BLNO MyBLNO,StateB,GoodsCha,GoodsSpec,CODE_TALLY_TYPE,DESCR,STATE from CON_LOAD_TALLY where CHI_VESSEL+Voyage+BLNO+WORK_PLACE in (select CHI_VESSEL+Voyage+BLNO+CodeYard from CON_LOAD_TALLY_LIST where CHI_VESSEL = '" & Me.txtMyShip.Text & "' AND Voyage = '" & Me.txtMyVoyage.Text & "' AND CodeYard = '" & strMyYard & "')) B " & _
                '    " on A.BLNO=B.MyBLNO order by BLNO"
                '20070517修改，改为完全外连接，可以发现提单号不一致的情况
                sqlSetMyBill = "select MyBLNO,StateB,BLNO OldBLNO,Case when BLNO is null then MyBLNO else BLNO end BLNO,GoodsCha,GoodsSpec,CODE_TALLY_TYPE,DESCR,STATE,(Case when MyBLNO<>'' then '存在' else '不存在' end) Being,(Case when StateB>'1' then '不可导' else '可导' end) Import,0 Amount,0.0 Gross,0.0 Net,0.0 Measure from (SELECT BLNO FROM TB_CONLOAD where EDIID='" & strEdiID & "'and BLNO in (select distinct BLNO from Tb_ConLoad_Rel where EDIID='" & strEdiID & "' and CTN_NO='" & strContainer & "')) A " & _
                    " full join (select BLNO MyBLNO,StateB,GoodsCha,GoodsSpec,CODE_TALLY_TYPE,DESCR,STATE from CON_LOAD_TALLY where CHI_VESSEL+Voyage+BLNO+WORK_PLACE in(select CHI_VESSEL+Voyage+BLNO+CodeYard from CON_LOAD_TALLY_List where  CHI_VESSEL = '" & Me.txtMyShip.Text & "' AND Voyage = '" & Me.txtMyVoyage.Text & "' AND  CodeYard= '" & strMyYard & "' and Container_NO='" & strContainer & "')) B " & _
                    " on A.BLNO=B.MyBLNO order by BLNO"
                '但是判断提单是否存在，则一定要用到场站代码，因为提单是分场站的。
                '20090608这里有个漏洞，就是对于GoodsCha,GoodsSpec等信息，当第一次操作时没有数据，这里没有将原数据带出
                sqlSetMyBill = "SP_ConLoadExtract_SetBill  '" & strEdiID & "','" & strContainer & "','" & Me.txtMyShip.Text & "','" & Me.txtMyVoyage.Text & "','" & strMyYard & "'"
                dvMyBill = Filldata(sqlSetMyBill)
                If strMyYard = "07" OrElse strMyYard = "21" Then    '检查桥的箱提单如果不存在默认为外托箱
                    Dim i As Integer
                    For i = 0 To dvMyBill.Count - 1
                        If IsDBNull(dvMyBill(i)("MyBLNO")) OrElse dvMyBill(i)("MyBLNO") = "" Then
                            dvMyBill(i)("CODE_TALLY_TYPE") = "3"
                        End If
                    Next
                End If
                Me.C1MyBill.DataSource = dvMyBill
                Me.C1MyBill.Columns("OldBLNO").Caption = "外部提单"
                Me.C1MyBill.Columns("BLNO").Caption = "内部提单"
                Me.C1MyBill.Columns("GoodsCha").Caption = "货物描述"
                Me.C1MyBill.Columns("GoodsSpec").Caption = "货物规格"
                Me.C1MyBill.Columns("CODE_TALLY_TYPE").Caption = "装拆箱别"
                Me.C1MyBill.Columns("DESCR").Caption = "货箱抵运"
                Me.C1MyBill.Columns("STATE").Caption = "货物处于"
                Me.C1MyBill.Columns("Being").Caption = "是否存在"
                Me.C1MyBill.Columns("Import").Caption = "是否可导"
                Me.C1MyBill.Splits(0).DisplayColumns("MyBLNO").Visible = False
                Me.C1MyBill.Splits(0).DisplayColumns("StateB").Visible = False
                Me.C1MyBill.Splits(0).DisplayColumns("Amount").Visible = False
                Me.C1MyBill.Splits(0).DisplayColumns("Gross").Visible = False
                Me.C1MyBill.Splits(0).DisplayColumns("Net").Visible = False
                Me.C1MyBill.Splits(0).DisplayColumns("Measure").Visible = False
                Me.C1MyBill.Splits(0).DisplayColumns("OldBLNO").Locked = True
                Me.C1MyBill.Splits(0).DisplayColumns("Being").Locked = True
                Me.C1MyBill.Splits(0).DisplayColumns("Import").Locked = True

                '根据操作性质确定提单号和内容的可改性

                SetDGWidth(Me.C1MyBill, 0)
                Me.C1MyBill.Splits(0).DisplayColumns("GoodsCha").Width = 140
                Me.C1MyBill.Splits(0).DisplayColumns("GoodsSpec").Width = 130

                If blFirst Then
                    sqlGoods = "select Goods,Goods Goods2 from CodeGoods WHERE CODE <> '0000' and ConLoadMark='1' "
                    dvGoods = Filldata(sqlGoods)
                    sqlConLoadType = "select Code_Tally_Type,Name_Tally_Type from Code_Tally_Type "
                    dvConLoadType = Filldata(sqlConLoadType)
                    blFirst = False
                End If
                SetDGCombox(Me.C1MyBill, "GoodsCha", dvGoods, False, 20)
                SetDGCombox(Me.C1MyBill, "CODE_TALLY_TYPE", dvConLoadType)

                Dim vi As C1.Win.C1TrueDBGrid.ValueItem
                Me.C1MyBill.Columns("DESCR").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
                vi = New C1.Win.C1TrueDBGrid.ValueItem
                vi.Value = "全部抵运"
                Me.C1MyBill.Columns("DESCR").ValueItems.Values.Add(vi)
                vi = New C1.Win.C1TrueDBGrid.ValueItem
                vi.Value = "部分抵运"
                Me.C1MyBill.Columns("DESCR").ValueItems.Values.Add(vi)
                Me.C1MyBill.Columns("STATE").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
                vi = New C1.Win.C1TrueDBGrid.ValueItem
                vi.Value = "全已装箱"
                Me.C1MyBill.Columns("STATE").ValueItems.Values.Add(vi)
                vi = New C1.Win.C1TrueDBGrid.ValueItem
                vi.Value = "部分装箱"
                Me.C1MyBill.Columns("STATE").ValueItems.Values.Add(vi)
                vi = New C1.Win.C1TrueDBGrid.ValueItem
                vi.Value = "拆箱"
                Me.C1MyBill.Columns("STATE").ValueItems.Values.Add(vi)

                blMyFind = True
                strMyShip = Me.txtMyShip.Text
                strMyShipName = Me.txtMyShipName.Text
                strNewShipEng = strTempShipEng
                strMyVoyage = Me.txtMyVoyage.Text
                If blEditImport Then
                    Me.txtConSize.Focus()
                Else
                    Me.txtDamageAmount.Focus()
                End If
            End If
            If blMyFind = False Then
                Me.lbShow.Text = "查找失败！"
                Me.txtMyShip.Focus()
            Else
                Me.btnImport.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub C1MyBill_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles C1MyBill.AfterColUpdate
        If e.ColIndex = 3 Then
            '查找本系统提单信息
            Dim sqlGetMyBill As String
            Dim dvGetMyBill As DataView
            sqlGetMyBill = "select BLNO,GoodsCha,GoodsSpec,CODE_TALLY_TYPE,DESCR,STATE,StateB from CON_LOAD_TALLY where CHI_VESSEL = '" & strMyShip & "' AND Voyage = '" & strMyVoyage & "' AND Work_Place = '" & strMyYard & "' and BLNO='" & Me.C1MyBill.Columns("BLNO").Text & "'"
            dvGetMyBill = Filldata(sqlGetMyBill)
            If dvGetMyBill.Count > 0 Then
                Me.C1MyBill.Columns("GoodsCha").Value = dvGetMyBill(0)("GoodsCha")
                Me.C1MyBill.Columns("GoodsSpec").Value = dvGetMyBill(0)("GoodsSpec")
                Me.C1MyBill.Columns("CODE_TALLY_TYPE").Value = dvGetMyBill(0)("CODE_TALLY_TYPE")
                Me.C1MyBill.Columns("DESCR").Value = dvGetMyBill(0)("DESCR")
                Me.C1MyBill.Columns("STATE").Value = dvGetMyBill(0)("STATE")
                Me.C1MyBill.Columns("MyBLNO").Value = dvGetMyBill(0)("BLNO")
                Me.C1MyBill.Columns("StateB").Value = dvGetMyBill(0)("StateB")
                Me.C1MyBill.Columns("Being").Text = "存在"
                If Me.C1MyBill.Columns("StateB").Text <= "1" Then
                    Me.C1MyBill.Columns("Import").Text = "可导"
                Else
                    Me.C1MyBill.Columns("Import").Text = "不可导"
                End If
            Else
                Me.C1MyBill.Columns("GoodsCha").Value = DBNull.Value
                Me.C1MyBill.Columns("GoodsSpec").Value = DBNull.Value
                Me.C1MyBill.Columns("CODE_TALLY_TYPE").Value = DBNull.Value
                Me.C1MyBill.Columns("DESCR").Value = DBNull.Value
                Me.C1MyBill.Columns("STATE").Value = DBNull.Value
                Me.C1MyBill.Columns("MyBLNO").Value = DBNull.Value
                Me.C1MyBill.Columns("StateB").Value = DBNull.Value
                Me.C1MyBill.Columns("Being").Text = "不存在"
                Me.C1MyBill.Columns("Import").Text = "不可导"
            End If
        End If
    End Sub

    Private Sub C1MyBill_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1MyBill.FetchRowStyle
        If Me.C1MyBill.Columns("MyBLNO").CellText(e.Row) <> "" Then '内部提单存在
            e.CellStyle.BackColor = System.Drawing.Color.PaleTurquoise
        End If
        If Me.C1MyBill.Columns("StateB").CellText(e.Row) > "1" Then '出证过不可改
            e.CellStyle.BackColor = System.Drawing.Color.Wheat
        End If
    End Sub

    Private Sub GetBillConData()    '计算箱中各提单的货物数量
        Dim a, b, c, d As Decimal
        Dim i, j As Integer
        Me.C1MyBill.Focus()
        For i = 0 To Me.dvMyBill.Count - 1
            Me.C1MyBill.Row = i
            For j = 0 To Me.dvTbRelation.Count - 1
                If Me.C1MyBill.Columns("OldBLNO").Text = Me.C1Relation.Columns("BLNO").CellText(j) Then
                    If IsNumeric(Me.C1Relation.Columns("CTN_PKGSNUM").CellText(j)) Then
                        a += Me.C1Relation.Columns("CTN_PKGSNUM").CellText(j)
                    End If
                    If IsNumeric(Me.C1Relation.Columns("CTN_TAREWEIGHT").CellText(j)) Then
                        b += Me.C1Relation.Columns("CTN_TAREWEIGHT").CellText(j)
                    End If
                    If IsNumeric(Me.C1Relation.Columns("CTN_NETWEIGHT").CellText(j)) Then
                        c += Me.C1Relation.Columns("CTN_NETWEIGHT").CellText(j)
                    End If
                    If IsNumeric(Me.C1Relation.Columns("CARGO_MEASUREMENT").CellText(j)) Then
                        d += Me.C1Relation.Columns("CARGO_MEASUREMENT").CellText(j)
                    End If
                End If
            Next
            'If a <> 0 Then
            '    Me.C1MyBill.Columns("Amount").Text = a
            'End If
            'If b <> 0 Then
            '    Me.C1MyBill.Columns("Gross").Text = b
            'End If
            'If c <> 0 Then
            '    Me.C1MyBill.Columns("Net").Text = c
            'End If
            'If d <> 0 Then
            '    Me.C1MyBill.Columns("Measure").Text = d
            'End If
            '如此确保每个都是数字
            Me.C1MyBill.Columns("Amount").Text = a
            Me.C1MyBill.Columns("Gross").Text = b
            Me.C1MyBill.Columns("Net").Text = c
            Me.C1MyBill.Columns("Measure").Text = d
        Next
        Me.btnExit.Focus()
    End Sub

    Private Function GetConsignCode(ByVal strTB_Code As String) As String   '委托单位代码转换
        Dim i As Integer
        For i = 0 To dvConsign.Count - 1
            If Not IsDBNull(dvConsign(i)("TB_Code")) Then
                If strTB_Code = dvConsign(i)("TB_Code") Then
                    Exit For
                End If
            End If
        Next
        If i < dvConsign.Count Then
            Return dvConsign(i)("CODE_SHIP_AGENT")
        Else
            Return "00"
        End If
    End Function

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        Try
            Dim blNext As Boolean
            If blFind Then
                If blMyFind Then
                    Dim strTemp As String = Me.lbYard.Text & " 作业的 " & strMyShipName & " " & strMyVoyage
                    Dim strMsg As String
                    If G_DeptCode = strCheckDept OrElse G_DeptCode = strCheckDept2 Then
                        '对于检查桥操作，对场站所属箱查而不导，对本部出证箱不可重复导入
                        '对所有出证箱不可增加导入。
                        If blMyConExist Then
                            If blCheck Then
                                strMsg = "该箱已查验，是否重新查验导入 " & strTemp & " 中？"
                            Else
                                strMsg = "该箱存在，确定要查验导入该箱到 " & strTemp & " 中吗?"
                            End If
                        Else

                            strMsg = "确定要查验导入该箱到 " & strTemp & " 中吗?"
                        End If
                        If MessageBox.Show(strMsg, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                            blNext = True
                        End If
                    Else    '对于一般场站，出证箱不可重复导入
                        If blImport Then
                            If blMyConExist Then
                                strMsg = "确定再次导入该箱信息到 " & strTemp & " 中吗?"
                            Else
                                strMsg = "确定导入该箱信息到 " & strTemp & " 中吗?"
                            End If
                            If MessageBox.Show(strMsg, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                                blNext = True
                            End If
                        Else
                            Me.txtContainer.Focus()
                            MessageBox.Show("该箱信息已出证,不可导入", "提示")
                        End If
                    End If
                Else
                    Me.txtMyShip.Focus()
                    MessageBox.Show("请查找内部数据确定航次提单", "提示")
                End If
            Else
                Me.txtContainer.Focus()
                MessageBox.Show("请查找外部数据确定箱信息", "提示")
            End If
            If blNext Then
                GetBillConData()    '计算分单货物数量
                Dim strCheck, strState, strEF As String   '确定状态
                If G_DeptCode = strCheckDept OrElse G_DeptCode = strCheckDept2 OrElse strMyYard = "01" OrElse strMyYard = "07" OrElse strMyYard = "21" Then
                    strCheck = "1"  '检查桥查验
                Else
                    strCheck = "0"
                End If
                If strMyShip = "HCHE" And strMyVoyage = "001" Then
                    strState = "0"
                Else
                    strState = "1"
                End If
                If Me.txtState.Text = "E" OrElse Me.txtState.Text = "F" Then
                    strEF = Me.txtState.Text
                ElseIf Me.txtState.Text = "L" Then
                    strEF = "F"
                Else
                    strEF = ""
                End If
                Dim strTemp, strBadAmount, strConSize As String '处理部分数值型
                strBadAmount = IIf(IsNumeric(Me.txtDamageAmount.Text), Me.txtDamageAmount.Text, "null")
                strConSize = IIf(Me.txtConSize.Text Like "##", Me.txtConSize.Text, "null")

                Dim sqlImportBill, sqlImportCon As String
                Dim i As Integer
                For i = 0 To dvMyBill.Count - 1
                    Me.C1MyBill.Row = i
                    Dim j As Integer    '查找外部数据提单位置
                    For j = 0 To dvTbGoods.Count - 1
                        If Me.C1MyBill.Columns("OldBLNO").CellText(i) = Me.C1Goods.Columns("BLNO").CellText(j) Then
                            Exit For
                        End If
                    Next
                    strTemp = IIf(IsNumeric(Me.C1Goods.Columns("TEMP_SETTING").CellValue(j)), Me.C1Goods.Columns("TEMP_SETTING").CellValue(j), "null")

                    '检查提单是否可以找到箱号
                    Dim k As Integer
                    For k = 0 To dvMyCon.Count - 1
                        If Me.C1MyBill.Columns("BLNO").CellText(i) = dvMyCon(k)("BLNO") Then
                            Exit For
                        End If
                    Next
                    '对箱信息
                    '箱号存在并找到     改提单数量/加单 重导箱
                    '箱号存在却找不到   加提单数量/加单 加箱
                    '箱号没有必定找不到 加提单数量/加单 加箱
                    If k >= dvMyCon.Count Then  '加新箱
                        If Me.C1MyBill.Columns("StateB").Text <= "1" Then   '且提单未出证。出证提单不可增加
                            Dim strSub As String
                            If strCheck = "1" Then  '同时查验，全写 理货员暂用操作员替代 CheckTime,CheckMan,ConTime,Clerk
                                Dim dtConTime As Date
                                If G_DeptCode = strCheckDept OrElse G_DeptCode = strCheckDept2 OrElse strMyYard = "07" OrElse strMyYard = "21" Then
                                    '如果检查桥 取查验时间 即当前系统时间
                                    dtConTime = Now
                                Else
                                    '否则 港内场站 取报文装箱时间 
                                    dtConTime = Me.dtpLoadDate.Value
                                End If
                                strSub = ",'" & Now & "','" & G_User & "','" & dtConTime & "','" & G_User & "'"
                            Else    '只装箱，只写作业时间理货员
                                strSub = ",null,null,'" & Me.dtpLoadDate.Value & "','" & G_User & "'"
                            End If
                            sqlImportCon = "Insert into CON_LOAD_TALLY_LIST(CHI_VESSEL,Voyage,BLNO,CONTAINER_NO,NEWSEALNO,SIZE_CON,CONTAINER_TYPE,PACK_CHA,AMOUNT,WEIGHT,NetWeight,VOLUME," & _
                                " DAMAGED_AMOUNT,DAMAGED_PACK,SecSealNO,ReasonOpenSeal,USER_NAME,CodeYard,ReeferTemp,TempUnit,DangerGrade,DangerMark," & _
                                " Checked,CheckTime,CheckMan,ConTime,Clerk,StateC,FullOrEmpty) " & _
                                " Values('" & strMyShip & "','" & strMyVoyage & "','" & Me.C1MyBill.Columns("BLNO").CellText(i) & "','" & strContainer & "','" & Me.txtSealNo.Text & "'," & strConSize & ",'" & Me.txtConType.Text & "','" & Me.C1Goods.Columns("CODE_PKGS").CellValue(j) & "',NullIf(" & Me.C1MyBill.Columns("Amount").CellValue(i) & ",0),NullIf(" & Me.C1MyBill.Columns("Gross").CellValue(i) & ",0)," & _
                                " NullIf(" & Me.C1MyBill.Columns("Net").CellValue(i) & ",0),NullIf(" & Me.C1MyBill.Columns("Measure").CellValue(i) & ",0)," & _
                                 strBadAmount & ",'" & Me.txtDamageDesc.Text & "','" & Me.txtSecSealNo.Text & "','" & Me.txtOpenSealReason.Text & "','" & G_User & "','" & strMyYard & "'," & strTemp & ",'" & Me.C1Goods.Columns("TEMP_ID").CellValue(j) & "','" & Me.C1Goods.Columns("DANGEROUS_CLASS").CellValue(j) & "','" & Me.C1Goods.Columns("DANGEROUS_LABEL").CellValue(j) & "', " & _
                                 "'" & strCheck & "'" & strSub & "," & strState & ",'" & strEF & "')"
                        Else
                            MessageBox.Show("该箱所在提单已出证，不可导入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        End If
                    Else    '箱号存在找到,只更新数量
                        '如果是检查桥，就要查验，变更Check状态 时间 操作人
                        '20091207对于查验场站箱数据不作修改。
                        Dim strA, strB, strCondition, strSetUser, strCheckAlter As String
                        Dim strHead As String
                        Dim strComn As String
                        strHead = "update CON_LOAD_TALLY_LIST set "
                        strComn = " NEWSEALNO='" & txtSealNo.Text & "',SIZE_CON=" & strConSize & ",CONTAINER_TYPE='" & txtConType.Text & "', SecSealNO='" & txtSecSealNo.Text & "',ReasonOpenSeal='" & txtOpenSealReason.Text & "',FullOrEmpty='" & strEF & "' "

                        strA = " PACK_CHA='" & Me.C1Goods.Columns("CODE_PKGS").CellValue(j) & "',AMOUNT=NullIf(" & Me.C1MyBill.Columns("Amount").CellValue(i) & ",0),WEIGHT=NullIf(" & Me.C1MyBill.Columns("Gross").CellValue(i) & ",0),NetWeight=NullIf(" & Me.C1MyBill.Columns("Net").CellValue(i) & ",0),VOLUME=NullIf(" & Me.C1MyBill.Columns("Measure").CellValue(i) & ",0)," & _
                            " DAMAGED_AMOUNT=" & strBadAmount & ",DAMAGED_PACK='" & Me.txtDamageDesc.Text & "',ReeferTemp=" & strTemp & ",TempUnit='" & Me.C1Goods.Columns("TEMP_ID").CellValue(j) & "',DangerGrade='" & Me.C1Goods.Columns("DANGEROUS_CLASS").CellValue(j) & "',DangerMark='" & Me.C1Goods.Columns("DANGEROUS_LABEL").CellValue(j) & "' "
                        strSetUser = " ConTime='" & Me.dtpLoadDate.Value & "',USER_NAME='" & G_User & "' "

                        strCheckAlter = " Checked='" & strCheck & "',CheckTime='" & Now & "',CheckMan='" & G_User & "' "
                        strCondition = " where CHI_VESSEL='" & strMyShip & "' and Voyage='" & strMyVoyage & "' and BLNO='" & Me.C1MyBill.Columns("BLNO").CellValue(i) & "' and CodeYard='" & strMyYard & "' and CONTAINER_NO='" & strContainer & "'"
                        If G_DeptCode = strCheckDept OrElse G_DeptCode = strCheckDept2 Then
                            If strMyYard = "07" OrElse strMyYard = "21" Then
                                sqlImportCon = strHead & strComn & "," & strCheckAlter & strCondition
                            Else
                                sqlImportCon = strHead & strCheckAlter & strCondition
                            End If
                        Else
                            sqlImportCon = strHead & strA & "," & strComn & "," & strSetUser & strCondition
                        End If
                    End If
                    '对提单信息
                    If Me.C1MyBill.Columns("StateB").Text <= "1" Then   '可导
                        If Me.C1MyBill.Columns("MyBLNO").Text = "" Then '新加
                            sqlImportBill = "Insert into CON_LOAD_TALLY(CHI_VESSEL,Voyage,InOutPort,CodeLoadPort,CodeDelivery,[NO],WORK_PLACE,TIME_FROM,BLNO,MARK," & _
                                " WORKTYPE,CODE_TALLY_TYPE,GoodsCha,GoodsSpec,AMOUNT,TOTAL_WEIGHT,TotalNetWeight,SIZE_MEASURE,ReeferTemp,TempUnit, " & _
                                " DangerGrade,DangerMark,DESCR,STATE,Shipper,RECEIVER,LISTDATE,TALLY_CLERK,CODE_CON_CONSIGN,USER_NAME,StateB) " & _
                                " Values('" & strMyShip & "','" & strMyVoyage & "','1','" & Me.C1Bill.Columns("CODE_LOADPORT").CellValue(i) & "','" & Me.C1Bill.Columns("CODE_DISCHARGEPORT").CellValue(i) & "','" & GetAutoNo(strMyYard) & "','" & strMyYard & "','" & Now & "','" & Me.C1MyBill.Columns("BLNO").CellValue(i) & "','" & VBMethod.Left(Me.C1Goods.Columns("MARKS").CellText(j), 120) & "', " & _
                                " '2','" & Me.C1MyBill.Columns("CODE_TALLY_TYPE").CellValue(i) & "','" & Me.C1MyBill.Columns("GoodsCha").CellText(i) & "','" & Me.C1MyBill.Columns("GoodsSpec").CellValue(i) & "',NullIf(" & Me.C1MyBill.Columns("Amount").CellValue(i) & ",0),NullIf(" & Me.C1MyBill.Columns("Gross").CellValue(i) & ",0),NullIf(" & Me.C1MyBill.Columns("Net").CellValue(i) & ",0),NullIf(" & Me.C1MyBill.Columns("Measure").CellValue(i) & ",0)," & strTemp & ",'" & Me.C1Goods.Columns("TEMP_ID").CellValue(j) & "', " & _
                                " '" & Me.C1Goods.Columns("DANGEROUS_CLASS").CellValue(j) & "','" & Me.C1Goods.Columns("DANGEROUS_LABEL").CellValue(j) & "','" & Me.C1MyBill.Columns("DESCR").CellValue(i) & "','" & Me.C1MyBill.Columns("STATE").CellValue(i) & "','" & VBMethod.Left(Me.C1Goods.Columns("Shiper").CellText(j), 100) & "','" & VBMethod.Left(Me.C1Goods.Columns("Receiver").CellText(j), 100) & "','" & Now & "',null,'" & GetConsignCode(Me.C1Goods.Columns("AgentCode").CellValue(j)) & "','" & G_User & "'," & strState & ")"
                        Else
                            '该提单中原来是否有该箱，如有，要修改提单数量，否则增加提单数量
                            '在GetBillConData()中保证各项都是数字
                            Dim a, b, c, d As String
                            If k >= dvMyCon.Count Then  '累加
                                a = "NullIf(IsNull(Amount,0)+" & Me.C1MyBill.Columns("Amount").CellValue(i) & ",0)"
                                b = "NullIf(IsNull(TOTAL_WEIGHT,0)+" & Me.C1MyBill.Columns("Gross").CellValue(i) & ",0)"
                                c = "NullIf(IsNull(TotalNetWeight,0)+" & Me.C1MyBill.Columns("Net").CellValue(i) & ",0)"
                                d = "NullIf(Case When SIZE_MEASURE Is Null or SIZE_MEASURE='' then " & Me.C1MyBill.Columns("Measure").CellValue(i) & " When Isnumeric(SIZE_MEASURE)=1 then cast(SIZE_MEASURE as numeric(9,2))+" & Me.C1MyBill.Columns("Measure").CellValue(i) & " else SIZE_MEASURE End,0)"
                            Else    '修改
                                '在dvMyCon中确定前三项都非空
                                a = "NullIf(IsNull(Amount,0)+" & Me.C1MyBill.Columns("Amount").CellValue(i) - dvMyCon(k)("AMOUNT") & ",0)"
                                b = "NullIf(IsNull(TOTAL_WEIGHT,0)+" & Me.C1MyBill.Columns("Gross").CellValue(i) - dvMyCon(k)("WEIGHT") & ",0)"
                                c = "NullIf(IsNull(TotalNetWeight,0)+" & Me.C1MyBill.Columns("Net").CellValue(i) - dvMyCon(k)("NetWeight") & ",0)"
                                Dim dSize As Decimal
                                If IsNumeric(dvMyCon(k)("VOLUME")) Then
                                    dSize = Me.C1MyBill.Columns("Measure").CellValue(i) - dvMyCon(k)("VOLUME")
                                Else
                                    dSize = Me.C1MyBill.Columns("Measure").CellValue(i)
                                End If
                                d = "NullIf(Case When SIZE_MEASURE Is Null or SIZE_MEASURE='' then " & dSize & " When Isnumeric(SIZE_MEASURE)=1 then cast(SIZE_MEASURE as numeric(9,2))+" & dSize & " else SIZE_MEASURE End,0)"
                            End If
                            If G_DeptCode <> strCheckDept AndAlso G_DeptCode <> strCheckDept2 OrElse k >= dvMyCon.Count Then '非检查桥,或者检查桥导入时可以,检查桥查验时不可更新
                                If Me.ckbReImportBill.Checked Then  '重导
                                    sqlImportBill = "update CON_LOAD_TALLY set CodeLoadPort='" & Me.C1Bill.Columns("CODE_LOADPORT").CellValue(i) & "',CodeDelivery='" & Me.C1Bill.Columns("CODE_DISCHARGEPORT").CellValue(i) & "',TIME_FROM='" & Now & "',MARK='" & VBMethod.Left(Me.C1Goods.Columns("MARKS").CellText(j), 120) & "',CODE_TALLY_TYPE='" & Me.C1MyBill.Columns("CODE_TALLY_TYPE").CellValue(i) & "', " & _
                                        " GoodsCha='" & Me.C1MyBill.Columns("GoodsCha").CellText(i) & "',GoodsSpec='" & Me.C1MyBill.Columns("GoodsSpec").CellValue(i) & "',AMOUNT=" & a & ",TOTAL_WEIGHT=" & b & ",TotalNetWeight=" & c & ",SIZE_MEASURE=" & d & ",ReeferTemp=" & strTemp & ",TempUnit='" & Me.C1Goods.Columns("TEMP_ID").CellValue(j) & "', " & _
                                        " DangerGrade='" & Me.C1Goods.Columns("DANGEROUS_CLASS").CellValue(j) & "',DangerMark='" & Me.C1Goods.Columns("DANGEROUS_LABEL").CellValue(j) & "',DESCR='" & Me.C1MyBill.Columns("DESCR").CellValue(i) & "',STATE='" & Me.C1MyBill.Columns("STATE").CellValue(i) & "',Shipper='" & VBMethod.Left(Me.C1Goods.Columns("Shiper").CellText(j), 100) & "',RECEIVER='" & VBMethod.Left(Me.C1Goods.Columns("Receiver").CellText(j), 100) & "',LISTDATE='" & Now & "',CODE_CON_CONSIGN='" & GetConsignCode(Me.C1Goods.Columns("AgentCode").CellValue(j)) & "',USER_NAME='" & G_User & "' " & _
                                        " where CHI_VESSEL='" & strMyShip & "' and Voyage='" & strMyVoyage & "' and BLNO='" & Me.C1MyBill.Columns("BLNO").CellValue(i) & "' and WORK_PLACE='" & strMyYard & "'"
                                Else    '不重导，只更新数量
                                    sqlImportBill = "update CON_LOAD_TALLY set AMOUNT=" & a & ",TOTAL_WEIGHT=" & b & ",TotalNetWeight=" & c & ",SIZE_MEASURE=" & d & " where CHI_VESSEL='" & strMyShip & "' and Voyage='" & strMyVoyage & "' and BLNO='" & Me.C1MyBill.Columns("BLNO").CellValue(i) & "' and WORK_PLACE='" & strMyYard & "'"
                                End If
                            End If

                        End If
                    End If

                    '2006-11-9修改10日再改，由于存在一箱多单分次导入的情况，对应的数据关系中就是拼箱但是却不在同一个报文中
                    '之前改过临时数据的导入状态写法，使得可以每次导入后可以继续查到其他的未导提单。但是出现新问题，
                    '如此每次第一个导过后，再继续导第二个时，可以查到本系统中存在箱，但是不存在提单，导入后确实加了提单
                    '但是没有加新的箱，这样不对，如果是正常的拼箱，在一个报文中，会按提单数增加每个箱信息就没问题。
                    '解决办法就是，不能简单地根据箱号是否存在，统一增加还是修改。要依据对应提单的存在与否决定箱号的增改

                    'If blMyConExist = False Then   '新加
                    '    sqlImportCon = "Insert into CON_LOAD_TALLY_LIST(CHI_VESSEL,Voyage,BLNO,CONTAINER_NO,NEWSEALNO,SIZE_CON,CONTAINER_TYPE,PACK_CHA,AMOUNT,WEIGHT,NetWeight,VOLUME," & _
                    '        " DAMAGED_AMOUNT,DAMAGED_PACK,SecSealNO,ReasonOpenSeal,USER_NAME,CodeYard,ReeferTemp,TempUnit,DangerGrade,DangerMark,Checked,CheckTime,StateC,FullOrEmpty) " & _
                    '        " Values('" & strMyShip & "','" & strMyVoyage & "','" & Me.C1MyBill.Columns("BLNO").CellText(i) & "','" & strContainer & "','" & Me.txtSealNo.Text & "'," & strConSize & ",'" & Me.txtConType.Text & "','" & Me.C1Goods.Columns("CODE_PKGS").CellValue(j) & "',NullIf(" & Me.C1MyBill.Columns("Amount").CellValue(i) & ",0),NullIf(" & Me.C1MyBill.Columns("Gross").CellValue(i) & ",0),NullIf(" & Me.C1MyBill.Columns("Net").CellValue(i) & ",0),NullIf(" & Me.C1MyBill.Columns("Measure").CellValue(i) & ",0)," & _
                    '         strBadAmount & ",'" & Me.txtDamageDesc.Text & "','" & Me.txtSecSealNo.Text & "','" & Me.txtOpenSealReason.Text & "','" & G_User & "','" & strMyYard & "'," & strTemp & ",'" & Me.C1Goods.Columns("TEMP_ID").CellValue(j) & "','" & Me.C1Goods.Columns("DANGEROUS_CLASS").CellValue(j) & "','" & Me.C1Goods.Columns("DANGEROUS_LABEL").CellValue(j) & "','" & strCheck & "','" & Now & "'," & strState & ",'" & strEF & "')"
                    'Else    '重导更新
                    '    '如果是检查桥，就要查验，变更Check状态
                    '    Dim strA, strB, strSetUser, strCheckAlter As String
                    '    strA = "update CON_LOAD_TALLY_LIST set NEWSEALNO='" & Me.txtSealNo.Text & "',SIZE_CON=" & strConSize & ",CONTAINER_TYPE='" & Me.txtConType.Text & "',PACK_CHA='" & Me.C1Goods.Columns("CODE_PKGS").CellValue(j) & "',AMOUNT=NullIf(" & Me.C1MyBill.Columns("Amount").CellValue(i) & ",0),WEIGHT=NullIf(" & Me.C1MyBill.Columns("Gross").CellValue(i) & ",0),NetWeight=NullIf(" & Me.C1MyBill.Columns("Net").CellValue(i) & ",0),VOLUME=NullIf(" & Me.C1MyBill.Columns("Measure").CellValue(i) & ",0)," & _
                    '        " DAMAGED_AMOUNT=" & strBadAmount & ",DAMAGED_PACK='" & Me.txtDamageDesc.Text & "',SecSealNO='" & Me.txtSecSealNo.Text & "',ReasonOpenSeal='" & Me.txtOpenSealReason.Text & "',ReeferTemp=" & strTemp & ",TempUnit='" & Me.C1Goods.Columns("TEMP_ID").CellValue(j) & "',DangerGrade='" & Me.C1Goods.Columns("DANGEROUS_CLASS").CellValue(j) & "',DangerMark='" & Me.C1Goods.Columns("DANGEROUS_LABEL").CellValue(j) & "',CheckTime='" & Now & "',FullOrEmpty='" & strEF & "' "
                    '    strSetUser = ",USER_NAME='" & G_User & "' "
                    '    strCheckAlter = ",Checked='" & strCheck & "' "
                    '    strB = " where CHI_VESSEL='" & strMyShip & "' and Voyage='" & strMyVoyage & "' and BLNO='" & Me.C1MyBill.Columns("BLNO").CellValue(i) & "' and CodeYard='" & strMyYard & "' and CONTAINER_NO='" & strContainer & "'"
                    '    If G_DeptCode = strCheckDept Then
                    '        sqlImportCon = strA & strCheckAlter & strB
                    '    Else
                    '        sqlImportCon = strA & strSetUser & strB
                    '    End If
                    'End If
                    If sqlImportBill <> "" Then
                        ExecSql(sqlImportBill)
                    End If
                    If sqlImportCon <> "" Then
                        ExecSql(sqlImportCon)
                    End If
                Next
                Dim sqlUpdateTbCon, sqlUpdateTbData As String
                '变更外部数据箱的状态
                '只改变当前EDIID下的该箱状态，为的是不同EDIID下的拼箱可以一个一个的查找导入。
                '否则就对于这种情况只能处理最新的箱记录。
                '存在的问题就是原来可以避免的问题：对于完全重复的报文数据，每次导过后，
                '仍然可以查到其他没导过的重复数据，可能会造成误解。
                sqlUpdateTbCon = "update TB_CONLOAD_CON set ImportMark='1',CODE_CONLOADPLACE='" & Me.cbPlace.SelectedValue & "' where EDIID=" & strEdiID & " and CODE_VESSEL='" & strShip & "' and VOYAGE='" & strVoyage & "' and CTN_NO='" & strContainer & "'"
                db_rp.ExecSql(sqlUpdateTbCon)
                If strShip <> strMyShip OrElse strVoyage <> strMyVoyage Then    '导入修改船次
                    'sqlUpdateTbData = "update TB_CONLOAD set CODE_VESSEL='" & strMyShip & "',VESSEL='" & strNewShipEng & "',VOYAGE='" & strMyVoyage & "' where CODE_VESSEL='" & strShip & "' and VOYAGE='" & strVoyage & "'"
                    sqlUpdateTbData = "Exec Sp_TbConLoad_Edit '" & strMyShip & "','" & strNewShipEng & "','" & strMyVoyage & "','" & strShip & "','" & strVoyage & "'"
                    db_rp.ExecSql(sqlUpdateTbData)
                End If
                MarkOper = 2
                Me.btnMyFind_Click(sender, e)
                Me.txtContainer.Focus()
                Me.txtContainer.SelectAll()
                blSave = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmConLoadTally_Extract_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtShip.Focused Then
                Me.txtVoyage.Focus()
            ElseIf Me.txtVoyage.Focused Then
                Me.txtContainer.Focus()
            ElseIf Me.txtContainer.Focused Then
                Me.btnFind.Focus()
                Me.btnFind_Click(sender, e)
            ElseIf Me.txtMyShip.Focused Then
                Me.txtMyVoyage.Focus()
            ElseIf Me.txtMyVoyage.Focused Then
                Me.btnMyFind.Focus()
                Me.btnMyFind_Click(sender, e)
            ElseIf Me.txtConSize.Focused Then
                Me.txtConType.Focus()
            ElseIf Me.txtConType.Focused Then
                Me.txtState.Focus()
            ElseIf Me.txtState.Focused Then
                Me.txtSealNo.Focus()
            ElseIf Me.txtSealNo.Focused Then
                Me.dtpLoadDate.Focus()
            ElseIf Me.dtpLoadDate.Focused Then
                Me.txtConOperCode.Focus()
            ElseIf Me.txtConOperCode.Focused Then
                Me.txtConOper.Focus()
            ElseIf Me.txtConOper.Focused Then
                Me.txtFront.Focus()
            ElseIf Me.txtFront.Focused() Then
                Me.txtBack.Focus()
            ElseIf Me.txtBack.Focused Then
                Me.txtLeft.Focus()
            ElseIf Me.txtLeft.Focused Then
                Me.txtRight.Focus()
            ElseIf Me.txtRight.Focused Then
                Me.txtTop.Focus()
            ElseIf Me.txtTop.Focused Then
                Me.txtAmount.Focus()
            ElseIf Me.txtAmount.Focused Then
                Me.txtTareWeight.Focus()
            ElseIf Me.txtTareWeight.Focused Then
                Me.txtNetWeight.Focus()
            ElseIf Me.txtNetWeight.Focused Then
                Me.txtMeasure.Focus()
            ElseIf Me.txtMeasure.Focused Then
                Me.cbPlace.Focus()
            ElseIf Me.txtDamageAmount.Focused Then
                Me.txtDamageDesc.Focus()
            ElseIf Me.txtDamageDesc.Focused Then
                Me.txtSecSealNo.Focus()
            ElseIf Me.txtSecSealNo.Focused Then
                Me.txtOpenSealReason.Focus()
            ElseIf txtOpenSealReason.Focused Then
                C1MyBill.Focus()
            End If
        End If
    End Sub

    Private Sub txtOpenSealReason_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOpenSealReason.Leave
        txtOpenSealReason.Text = txtOpenSealReason.Text.Trim.ToUpper
    End Sub
End Class

