Imports TALLY.DBControl
Public Class FrmConImageCargo_Editg
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim Mark1 As Boolean

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        AddHandler txtContainerNo.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress
        AddHandler txtAmount.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress
        AddHandler txtBayNo.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress
        AddHandler txtBillNO.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress
        AddHandler txtDANGER_GRADE.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress
        AddHandler txtDANGER_MARK.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress
        AddHandler txtDANGER_NO.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress
        AddHandler txtDANGER_PAGENO.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress
        AddHandler txtGROSSWEIGHT.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress
        AddHandler txtSealNo.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress
        AddHandler txtTempMax.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress
        AddHandler txtTempMin.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress
        AddHandler txtTempSet.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress
        AddHandler txtVolume.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress
        AddHandler cbDelivery.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress
        AddHandler cbLoadPort.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress
        AddHandler cbState.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress
        AddHandler cbTempUnit.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress
        AddHandler cbUnloadPort.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress

        'AddHandler txtLOAD_PORT.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress
        'AddHandler txtUNLOAD_PORT.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress
        'AddHandler txtDelivery.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress

        AddHandler cbReceivePlaceEng.KeyPress, AddressOf FrmConImageCargo_Addg_KeyPress
        AddHandler cbLoadPortEng.KeyPress, AddressOf FrmConImageCargo_Addg_KeyPress
        AddHandler cbUnloadPortEng.KeyPress, AddressOf FrmConImageCargo_Addg_KeyPress
        AddHandler txtConSize.KeyPress, AddressOf FrmConImageCargo_Addg_KeyPress
        AddHandler txtConType.KeyPress, AddressOf FrmConImageCargo_Addg_KeyPress
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
    Friend WithEvents txtDANGER_MARK As System.Windows.Forms.TextBox
    Friend WithEvents txtDANGER_GRADE As System.Windows.Forms.TextBox
    Friend WithEvents txtDANGER_NO As System.Windows.Forms.TextBox
    Friend WithEvents txtDANGER_PAGENO As System.Windows.Forms.TextBox
    Friend WithEvents cbTempUnit As System.Windows.Forms.ComboBox
    Friend WithEvents txtBayNo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbState As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSealNo As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtContainerNo As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtVolume As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTempMax As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGROSSWEIGHT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtTempMin As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtTempSet As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents txtBillNO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents cbDelivery As System.Windows.Forms.ComboBox
    Friend WithEvents cbUnloadPort As System.Windows.Forms.ComboBox
    Friend WithEvents cbLoadPort As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbUnloadPortEng As System.Windows.Forms.ComboBox
    Friend WithEvents cbLoadPortEng As System.Windows.Forms.ComboBox
    Friend WithEvents cbReceivePlaceEng As System.Windows.Forms.ComboBox
    Friend WithEvents ckbMoved As System.Windows.Forms.CheckBox
    Friend WithEvents txtConType As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtConSize As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtDANGER_MARK = New System.Windows.Forms.TextBox
        Me.txtDANGER_GRADE = New System.Windows.Forms.TextBox
        Me.txtDANGER_NO = New System.Windows.Forms.TextBox
        Me.txtDANGER_PAGENO = New System.Windows.Forms.TextBox
        Me.cbTempUnit = New System.Windows.Forms.ComboBox
        Me.txtBayNo = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.cbState = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbDelivery = New System.Windows.Forms.ComboBox
        Me.cbUnloadPort = New System.Windows.Forms.ComboBox
        Me.cbLoadPort = New System.Windows.Forms.ComboBox
        Me.txtSealNo = New System.Windows.Forms.TextBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.txtContainerNo = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtVolume = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtTempMax = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtGROSSWEIGHT = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtTempMin = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtTempSet = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.txtBillNO = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cbUnloadPortEng = New System.Windows.Forms.ComboBox
        Me.cbLoadPortEng = New System.Windows.Forms.ComboBox
        Me.cbReceivePlaceEng = New System.Windows.Forms.ComboBox
        Me.ckbMoved = New System.Windows.Forms.CheckBox
        Me.txtConType = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtConSize = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtDANGER_MARK
        '
        Me.txtDANGER_MARK.Location = New System.Drawing.Point(288, 246)
        Me.txtDANGER_MARK.MaxLength = 32
        Me.txtDANGER_MARK.Name = "txtDANGER_MARK"
        Me.txtDANGER_MARK.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_MARK.TabIndex = 523
        Me.txtDANGER_MARK.Text = ""
        '
        'txtDANGER_GRADE
        '
        Me.txtDANGER_GRADE.Location = New System.Drawing.Point(288, 174)
        Me.txtDANGER_GRADE.MaxLength = 10
        Me.txtDANGER_GRADE.Name = "txtDANGER_GRADE"
        Me.txtDANGER_GRADE.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_GRADE.TabIndex = 520
        Me.txtDANGER_GRADE.Text = ""
        '
        'txtDANGER_NO
        '
        Me.txtDANGER_NO.Location = New System.Drawing.Point(288, 222)
        Me.txtDANGER_NO.MaxLength = 10
        Me.txtDANGER_NO.Name = "txtDANGER_NO"
        Me.txtDANGER_NO.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_NO.TabIndex = 522
        Me.txtDANGER_NO.Text = ""
        '
        'txtDANGER_PAGENO
        '
        Me.txtDANGER_PAGENO.Location = New System.Drawing.Point(288, 198)
        Me.txtDANGER_PAGENO.MaxLength = 20
        Me.txtDANGER_PAGENO.Name = "txtDANGER_PAGENO"
        Me.txtDANGER_PAGENO.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_PAGENO.TabIndex = 521
        Me.txtDANGER_PAGENO.Text = ""
        '
        'cbTempUnit
        '
        Me.cbTempUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTempUnit.Items.AddRange(New Object() {"", "C", "F"})
        Me.cbTempUnit.Location = New System.Drawing.Point(288, 78)
        Me.cbTempUnit.Name = "cbTempUnit"
        Me.cbTempUnit.Size = New System.Drawing.Size(130, 20)
        Me.cbTempUnit.TabIndex = 516
        '
        'txtBayNo
        '
        Me.txtBayNo.Location = New System.Drawing.Point(78, 124)
        Me.txtBayNo.MaxLength = 7
        Me.txtBayNo.Name = "txtBayNo"
        Me.txtBayNo.Size = New System.Drawing.Size(130, 21)
        Me.txtBayNo.TabIndex = 505
        Me.txtBayNo.Text = ""
        '
        'Label14
        '
        Me.Label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label14.Location = New System.Drawing.Point(4, 126)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 18)
        Me.Label14.TabIndex = 549
        Me.Label14.Text = "贝位号"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbState
        '
        Me.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbState.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbState.Location = New System.Drawing.Point(78, 78)
        Me.cbState.Name = "cbState"
        Me.cbState.Size = New System.Drawing.Size(130, 20)
        Me.cbState.TabIndex = 503
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(4, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 548
        Me.Label6.Text = "箱状态"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbDelivery
        '
        Me.cbDelivery.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbDelivery.Location = New System.Drawing.Point(78, 260)
        Me.cbDelivery.MaxDropDownItems = 20
        Me.cbDelivery.Name = "cbDelivery"
        Me.cbDelivery.Size = New System.Drawing.Size(130, 20)
        Me.cbDelivery.TabIndex = 511
        '
        'cbUnloadPort
        '
        Me.cbUnloadPort.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbUnloadPort.Location = New System.Drawing.Point(78, 216)
        Me.cbUnloadPort.MaxDropDownItems = 20
        Me.cbUnloadPort.Name = "cbUnloadPort"
        Me.cbUnloadPort.Size = New System.Drawing.Size(130, 20)
        Me.cbUnloadPort.TabIndex = 509
        '
        'cbLoadPort
        '
        Me.cbLoadPort.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbLoadPort.Location = New System.Drawing.Point(78, 172)
        Me.cbLoadPort.MaxDropDownItems = 20
        Me.cbLoadPort.Name = "cbLoadPort"
        Me.cbLoadPort.Size = New System.Drawing.Size(130, 20)
        Me.cbLoadPort.TabIndex = 507
        '
        'txtSealNo
        '
        Me.txtSealNo.Location = New System.Drawing.Point(78, 100)
        Me.txtSealNo.MaxLength = 20
        Me.txtSealNo.Name = "txtSealNo"
        Me.txtSealNo.Size = New System.Drawing.Size(130, 21)
        Me.txtSealNo.TabIndex = 504
        Me.txtSealNo.Text = ""
        '
        'Label35
        '
        Me.Label35.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label35.Location = New System.Drawing.Point(4, 102)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(72, 18)
        Me.Label35.TabIndex = 546
        Me.Label35.Text = "铅封号"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtContainerNo
        '
        Me.txtContainerNo.Location = New System.Drawing.Point(78, 6)
        Me.txtContainerNo.MaxLength = 12
        Me.txtContainerNo.Name = "txtContainerNo"
        Me.txtContainerNo.Size = New System.Drawing.Size(130, 21)
        Me.txtContainerNo.TabIndex = 502
        Me.txtContainerNo.Text = ""
        '
        'Label36
        '
        Me.Label36.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label36.Location = New System.Drawing.Point(4, 8)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 18)
        Me.Label36.TabIndex = 547
        Me.Label36.Text = "集装箱号"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(214, 128)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 18)
        Me.Label29.TabIndex = 539
        Me.Label29.Text = "冷藏最低温"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(214, 248)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(72, 18)
        Me.Label34.TabIndex = 545
        Me.Label34.Text = "危险品标签"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(214, 80)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 18)
        Me.Label15.TabIndex = 542
        Me.Label15.Text = "温度单位"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(288, 6)
        Me.txtAmount.MaxLength = 20
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(130, 21)
        Me.txtAmount.TabIndex = 513
        Me.txtAmount.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(214, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 535
        Me.Label10.Text = "件数"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVolume
        '
        Me.txtVolume.Location = New System.Drawing.Point(288, 54)
        Me.txtVolume.MaxLength = 20
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.TabIndex = 515
        Me.txtVolume.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(214, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 532
        Me.Label5.Text = "体积尺寸"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTempMax
        '
        Me.txtTempMax.Location = New System.Drawing.Point(288, 150)
        Me.txtTempMax.MaxLength = 20
        Me.txtTempMax.Name = "txtTempMax"
        Me.txtTempMax.Size = New System.Drawing.Size(130, 21)
        Me.txtTempMax.TabIndex = 519
        Me.txtTempMax.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(214, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 531
        Me.Label3.Text = "冷藏最高温"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGROSSWEIGHT
        '
        Me.txtGROSSWEIGHT.Location = New System.Drawing.Point(288, 30)
        Me.txtGROSSWEIGHT.MaxLength = 20
        Me.txtGROSSWEIGHT.Name = "txtGROSSWEIGHT"
        Me.txtGROSSWEIGHT.TabIndex = 514
        Me.txtGROSSWEIGHT.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(214, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 528
        Me.Label1.Text = "箱毛重"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(214, 224)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 18)
        Me.Label26.TabIndex = 541
        Me.Label26.Text = "危险品编号"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(214, 200)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 18)
        Me.Label27.TabIndex = 543
        Me.Label27.Text = "危险品页号"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTempMin
        '
        Me.txtTempMin.Location = New System.Drawing.Point(288, 126)
        Me.txtTempMin.MaxLength = 20
        Me.txtTempMin.Name = "txtTempMin"
        Me.txtTempMin.Size = New System.Drawing.Size(130, 21)
        Me.txtTempMin.TabIndex = 518
        Me.txtTempMin.Text = ""
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(214, 176)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(72, 18)
        Me.Label30.TabIndex = 530
        Me.Label30.Text = "危险品等级"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTempSet
        '
        Me.txtTempSet.Location = New System.Drawing.Point(288, 102)
        Me.txtTempSet.MaxLength = 20
        Me.txtTempSet.Name = "txtTempSet"
        Me.txtTempSet.Size = New System.Drawing.Size(130, 21)
        Me.txtTempSet.TabIndex = 517
        Me.txtTempSet.Text = ""
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(214, 104)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(72, 18)
        Me.Label31.TabIndex = 538
        Me.Label31.Text = "设置温度"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(216, 310)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 526
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(148, 310)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 525
        Me.btSave.Text = "确认"
        '
        'txtBillNO
        '
        Me.txtBillNO.Location = New System.Drawing.Point(78, 148)
        Me.txtBillNO.MaxLength = 20
        Me.txtBillNO.Name = "txtBillNO"
        Me.txtBillNO.Size = New System.Drawing.Size(130, 21)
        Me.txtBillNO.TabIndex = 506
        Me.txtBillNO.Text = ""
        '
        'Label4
        '
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(4, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 533
        Me.Label4.Text = "提单号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(4, 284)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 18)
        Me.Label20.TabIndex = 537
        Me.Label20.Text = "交货地英文"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(4, 262)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 18)
        Me.Label21.TabIndex = 534
        Me.Label21.Text = "交货地"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(4, 218)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 18)
        Me.Label22.TabIndex = 544
        Me.Label22.Text = "卸货港"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(4, 174)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 18)
        Me.Label23.TabIndex = 529
        Me.Label23.Text = "装货港"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(4, 196)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 18)
        Me.Label24.TabIndex = 540
        Me.Label24.Text = "装货港英文"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(4, 240)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(72, 18)
        Me.Label32.TabIndex = 536
        Me.Label32.Text = "卸货港英文"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(0, 0)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 527
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(388, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 20)
        Me.Label2.TabIndex = 551
        Me.Label2.Text = "公斤"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(388, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 20)
        Me.Label11.TabIndex = 550
        Me.Label11.Text = "立方"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbUnloadPortEng
        '
        Me.cbUnloadPortEng.Location = New System.Drawing.Point(78, 238)
        Me.cbUnloadPortEng.MaxDropDownItems = 20
        Me.cbUnloadPortEng.Name = "cbUnloadPortEng"
        Me.cbUnloadPortEng.Size = New System.Drawing.Size(130, 20)
        Me.cbUnloadPortEng.TabIndex = 554
        '
        'cbLoadPortEng
        '
        Me.cbLoadPortEng.Location = New System.Drawing.Point(78, 194)
        Me.cbLoadPortEng.MaxDropDownItems = 20
        Me.cbLoadPortEng.Name = "cbLoadPortEng"
        Me.cbLoadPortEng.Size = New System.Drawing.Size(130, 20)
        Me.cbLoadPortEng.TabIndex = 553
        '
        'cbReceivePlaceEng
        '
        Me.cbReceivePlaceEng.Location = New System.Drawing.Point(78, 282)
        Me.cbReceivePlaceEng.MaxDropDownItems = 20
        Me.cbReceivePlaceEng.Name = "cbReceivePlaceEng"
        Me.cbReceivePlaceEng.Size = New System.Drawing.Size(130, 20)
        Me.cbReceivePlaceEng.TabIndex = 552
        '
        'ckbMoved
        '
        Me.ckbMoved.Location = New System.Drawing.Point(342, 276)
        Me.ckbMoved.Name = "ckbMoved"
        Me.ckbMoved.Size = New System.Drawing.Size(74, 24)
        Me.ckbMoved.TabIndex = 555
        Me.ckbMoved.Text = "捣箱标记"
        '
        'txtConType
        '
        Me.txtConType.Location = New System.Drawing.Point(78, 54)
        Me.txtConType.MaxLength = 2
        Me.txtConType.Name = "txtConType"
        Me.txtConType.Size = New System.Drawing.Size(130, 21)
        Me.txtConType.TabIndex = 558
        Me.txtConType.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(4, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 18)
        Me.Label8.TabIndex = 559
        Me.Label8.Text = "箱型"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtConSize
        '
        Me.txtConSize.Location = New System.Drawing.Point(78, 30)
        Me.txtConSize.MaxLength = 2
        Me.txtConSize.Name = "txtConSize"
        Me.txtConSize.Size = New System.Drawing.Size(130, 21)
        Me.txtConSize.TabIndex = 556
        Me.txtConSize.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(4, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 557
        Me.Label7.Text = "箱尺寸"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmConImageCargo_Editg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(426, 343)
        Me.Controls.Add(Me.txtConType)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtConSize)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ckbMoved)
        Me.Controls.Add(Me.cbUnloadPortEng)
        Me.Controls.Add(Me.cbLoadPortEng)
        Me.Controls.Add(Me.cbReceivePlaceEng)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtDANGER_MARK)
        Me.Controls.Add(Me.txtDANGER_GRADE)
        Me.Controls.Add(Me.txtDANGER_NO)
        Me.Controls.Add(Me.txtDANGER_PAGENO)
        Me.Controls.Add(Me.cbTempUnit)
        Me.Controls.Add(Me.txtBayNo)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cbState)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbDelivery)
        Me.Controls.Add(Me.cbUnloadPort)
        Me.Controls.Add(Me.cbLoadPort)
        Me.Controls.Add(Me.txtSealNo)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.txtContainerNo)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtVolume)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTempMax)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtGROSSWEIGHT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtTempMin)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.txtTempSet)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.txtBillNO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.txtID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConImageCargo_Editg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "集装箱船图信息 修改"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim sqlGetPortName As String
    'Dim dvTemp As New DataView()
    Dim dvLoadPort As New DataView()
    Dim dvUnloadPort As New DataView()
    Dim dvDelivery As New DataView
    Dim conSizeOg, conTypeOg As String

    Private Sub FrmConImageCargo_Editg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Dim dvState As New DataView()
    
        Dim sqlConState, sqlPort, sqlDelivery As String

        'Me.txtLOAD_PORT.Enabled = False
        'Me.txtUNLOAD_PORT.Enabled = False
        'Me.txtDelivery.Enabled = False
        conSizeOg = 0
        conTypeOg = ""

        sqlConState = "SELECT EFL_Code, EFL_Name FROM Code_ConEFLType"
            dvState = Filldata(sqlConState)
            Me.cbState.DataSource = dvState
            Me.cbState.DisplayMember = "EFL_Name"
            Me.cbState.ValueMember = "EFL_Code"

        sqlPort = "SELECT CODE_PORT, PORT_CHA, PORT_ENG FROM CODE_PORT ORDER BY PORT_ENG"
            dvLoadPort = Filldata(sqlPort)
            Me.cbLoadPort.DataSource = dvLoadPort
            Me.cbLoadPort.DisplayMember = "PORT_CHA"
            Me.cbLoadPort.ValueMember = "CODE_PORT"

            dvUnloadPort = Filldata(sqlPort)
            Me.cbUnloadPort.DataSource = dvUnloadPort
            Me.cbUnloadPort.DisplayMember = "PORT_CHA"
            Me.cbUnloadPort.ValueMember = "CODE_PORT"

        sqlDelivery = "SELECT CODE_PORT, PORT_CHA, PORT_ENG FROM CODE_PORT ORDER BY PORT_ENG"
            dvDelivery = Filldata(sqlDelivery)
            Me.cbDelivery.DataSource = dvDelivery
            Me.cbDelivery.DisplayMember = "PORT_CHA"
            Me.cbDelivery.ValueMember = "CODE_PORT"

            Me.cbLoadPortEng.DataSource = dvLoadPort
            Me.cbLoadPortEng.DisplayMember = "PORT_ENG"
            Me.cbLoadPortEng.ValueMember = "CODE_PORT"
            Me.cbUnloadPortEng.DataSource = dvUnloadPort
            Me.cbUnloadPortEng.DisplayMember = "PORT_ENG"
            Me.cbUnloadPortEng.ValueMember = "CODE_PORT"
            Me.cbReceivePlaceEng.DataSource = dvDelivery
            Me.cbReceivePlaceEng.DisplayMember = "PORT_ENG"
            Me.cbReceivePlaceEng.ValueMember = "CODE_PORT"

            sqlstr = "SELECT * FROM CON_IMAGE WHERE CON_IMAGE_ID = '" & ID & "'"
            dw = Updatedata(sqlda, sqlstr, ds)

        If dw.Count = 1 Then
            txtID.Text = ds.Tables(0).Rows(0).Item("CON_IMAGE_ID")
            txtContainerNo.Text = ds.Tables(0).Rows(0).Item("CONTAINER_NO")
            txtSealNo.Text = ds.Tables(0).Rows(0).Item("SealNo")
            txtBayNo.Text = ds.Tables(0).Rows(0).Item("BayNo")
            txtBillNO.Text = ds.Tables(0).Rows(0).Item("BLNO")

            'txtLOAD_PORT.Text = ds.Tables(0).Rows(0).Item("LOAD_PORT")
            'txtUNLOAD_PORT.Text = ds.Tables(0).Rows(0).Item("UNLOAD_PORT")
            'txtDelivery.Text = ds.Tables(0).Rows(0).Item("DELIVERY")

            If Not IsDBNull(ds.Tables(0).Rows(0).Item("AMOUNT")) Then
                txtAmount.Text = ds.Tables(0).Rows(0).Item("AMOUNT")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("GROSSWEIGHT")) Then
                Me.txtGROSSWEIGHT.Text = ds.Tables(0).Rows(0).Item("GROSSWEIGHT")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("VOLUME")) Then
                Me.txtVolume.Text = ds.Tables(0).Rows(0).Item("VOLUME")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("TEMPERATURE_SETTING")) Then
                Me.txtTempSet.Text = ds.Tables(0).Rows(0).Item("TEMPERATURE_SETTING")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("MAX_TEMPERATURE")) Then
                Me.txtTempMax.Text = ds.Tables(0).Rows(0).Item("MAX_TEMPERATURE")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("MIN_TEMPERATURE")) Then
                Me.txtTempMin.Text = ds.Tables(0).Rows(0).Item("MIN_TEMPERATURE")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("DANGER_PAGENO")) Then
                txtDANGER_PAGENO.Text = ds.Tables(0).Rows(0).Item("DANGER_PAGENO")
            End If
            txtDANGER_GRADE.Text = ds.Tables(0).Rows(0).Item("DANGER_GRADE")
            txtDANGER_NO.Text = ds.Tables(0).Rows(0).Item("DANGER_NO")
            txtDANGER_MARK.Text = ds.Tables(0).Rows(0).Item("DANGER_MARK")

            Me.cbState.SelectedValue = ds.Tables(0).Rows(0).Item("FULLOREMPTY")
            Me.cbLoadPort.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_LOAD_PORT")
            Me.cbUnloadPort.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT")
            Me.cbDelivery.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_DELIVERY")
            Me.cbTempUnit.Text = ds.Tables(0).Rows(0).Item("TEMPERATURE_UNIT")

            If Me.cbLoadPort.SelectedValue Is Nothing Then
                cbLoadPort.Text = ds.Tables(0).Rows(0).Item("CODE_LOAD_PORT")
            End If
            If Me.cbUnloadPort.SelectedValue Is Nothing Then
                cbUnloadPort.Text = ds.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT")
            End If
            If Me.cbDelivery.SelectedValue Is Nothing Then
                Me.cbDelivery.Text = ds.Tables(0).Rows(0).Item("CODE_DELIVERY")
            End If
            Me.ckbMoved.Checked = ds.Tables(0).Rows(0)("Moved")
        End If
        txtContainerNo_Leave(sender, e)
        Exit Sub
Err:
        Resume Next
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

    Function IsCode(ByVal str As String) As Boolean    '不对要改 两头不空
        Dim i As Integer
        Dim ch As Char
        str = str.ToUpper
        If str.Length <= 5 Then
            For i = 1 To str.Length
                ch = Mid(str, i, 1)
                If Not (ch Like "[A-Z]" Or ch = " ") Then
                    Exit For
                End If
                'If Not Char.IsLetter(Mid(str, i, 1)) Then
                '    Exit For
                'End If
            Next
        End If
        If i > str.Length Then
            Return True     '最长五位，中间可空
        Else
            Return False
        End If
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
        Dim sqlUnique, sqlBeing As String
        Try
            If Trim(Me.txtContainerNo.Text) <> "" And Trim(Me.txtBayNo.Text) <> "" And Me.cbState.SelectedValue <> "0" Then

                If Me.SetNumValue("AMOUNT", txtAmount.Text, "件数") = False Then
                    txtAmount.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("GROSSWEIGHT", txtGROSSWEIGHT.Text, "箱毛重") = False Then
                    Me.txtGROSSWEIGHT.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("VOLUME", txtVolume.Text, "体积") = False Then
                    Me.txtVolume.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("TEMPERATURE_SETTING", txtTempSet.Text, "设置温度") = False Then
                    Me.txtTempSet.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("MIN_TEMPERATURE", txtTempMax.Text, "冷藏最高温度") = False Then
                    Me.txtTempMax.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("MAX_TEMPERATURE", txtTempMin.Text, "冷藏最低温度") = False Then
                    Me.txtTempMin.Focus()
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
                If Not IsNothing(Me.cbDelivery.SelectedValue) Then  '港口代码能取到
                    ds.Tables(0).Rows(0).Item("CODE_DELIVERY") = Me.cbDelivery.SelectedValue
                    ds.Tables(0).Rows(0).Item("DELIVERY") = Trim(Me.cbDelivery.Text.ToUpper)
                Else
                    If IsCode(Me.cbDelivery.Text.Trim()) Then     '判断是代码的形式
                        ds.Tables(0).Rows(0).Item("CODE_DELIVERY") = Trim(Me.cbDelivery.Text.ToUpper)
                    Else
                        MessageBox.Show("交货港中文名不能取得时，必须输入港口代码才能保存。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.cbDelivery.Focus()
                        Exit Sub
                    End If
                End If

                ds.Tables(0).Rows(0).Item("CONTAINER_NO") = Trim(Me.txtContainerNo.Text.ToUpper)
                ds.Tables(0).Rows(0).Item("SEALNO") = Trim(Me.txtSealNo.Text)
                ds.Tables(0).Rows(0).Item("BAYNO") = Trim(Me.txtBayNo.Text)
                ds.Tables(0).Rows(0).Item("BLNO") = Trim(Me.txtBillNO.Text).ToUpper
                ds.Tables(0).Rows(0).Item("DANGER_GRADE") = Trim(Me.txtDANGER_GRADE.Text)
                ds.Tables(0).Rows(0).Item("DANGER_NO") = Trim(Me.txtDANGER_NO.Text)
                ds.Tables(0).Rows(0).Item("DANGER_MARK") = Trim(Me.txtDANGER_MARK.Text)
                ds.Tables(0).Rows(0).Item("DANGER_PAGENO") = Trim(Me.txtDANGER_PAGENO.Text)

                'ds.Tables(0).Rows(0).Item("LOAD_PORT") = Trim(Me.txtLOAD_PORT.Text)
                'ds.Tables(0).Rows(0).Item("UNLOAD_PORT") = Trim(Me.txtUNLOAD_PORT.Text)
                'ds.Tables(0).Rows(0).Item("DELIVERY") = Trim(Me.txtDelivery.Text)

                ds.Tables(0).Rows(0).Item("FULLOREMPTY") = Me.cbState.SelectedValue
                ds.Tables(0).Rows(0).Item("TEMPERATURE_UNIT") = Trim(Me.cbTempUnit.Text)
                ds.Tables(0).Rows(0)("Moved") = Me.ckbMoved.Checked

                If Trim(Me.txtBayNo.Text) Like "######" Then
                    If MessageBox.Show("确定对进口船图的修改吗？", "警告提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                        sqlUnique = "SELECT * FROM CON_IMAGE WHERE SHIP_ID = '" & Ship_ID & "' and TPMark='0' AND ( CONTAINER_NO = '" & Trim(Me.txtContainerNo.Text.ToUpper) & "' or CONTAINER_NO = '" & GetConOtherMode(Me.txtContainerNo.Text) & "'  or ( BAYNO = '" & Trim(Me.txtBayNo.Text) & "' " & _
                        "or substring(cast('2'+substring(BAYNO,1,2)+1 as char(3))+right(BAYNO,4),2,6) = '" & Trim(Me.txtBayNo.Text) & "' or substring(cast('2'+substring(BAYNO,1,2)-1 as char(3))+right(BAYNO,4),2,6) = '" & Trim(Me.txtBayNo.Text) & "'))  and CON_IMAGE_ID <> '" & ID & "'"

                        If Filldata(sqlUnique).Count = 0 Then
                            Dim iConCheck, iBeingCount As Integer
                            iConCheck = CheckConNO(Trim(Me.txtContainerNo.Text))
                            sqlBeing = "SELECT CONTAINER_NO FROM CON_CRITERION WHERE CONTAINER_NO = '" & Trim(Me.txtContainerNo.Text.ToUpper) & "' or CONTAINER_NO = '" & GetConOtherMode(Me.txtContainerNo.Text) & "'"
                            iBeingCount = Filldata(sqlBeing).Count
                            If iBeingCount >= 1 Or iConCheck = 2 Or iConCheck = 1 Then   '箱号可能通过检验
                                If iBeingCount = 0 Then    '不存在 ,要添加
                                    If iConCheck = 1 Then   '又没通过校验 ，给提示
                                        If MessageBox.Show("集装箱号校验不正确！确定存在吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                                            Exit Sub
                                        End If
                                    End If
                                    If Me.txtConSize.Text Like "##" Then
                                        If Me.txtConType.Text.ToUpper Like "[A-Z][A-Z]" Then
                                            Dim sqlAddCon As String
                                            sqlAddCon = "INSERT INTO CON_CRITERION(CONTAINER_NO, SIZE_CON, CONTAINER_TYPE, USER_NAME) VALUES ('" & Me.txtContainerNo.Text & "', '" & Me.txtConSize.Text & "', '" & Me.txtConType.Text.ToUpper & "', '" & G_User & "')"
                                            ExecSql(sqlAddCon)
                                        Else
                                            Me.txtConType.Focus()
                                            MessageBox.Show("箱型不合规范", "提示")
                                            Exit Sub
                                        End If
                                    Else
                                        Me.txtConSize.Focus()
                                        MessageBox.Show("箱尺寸不合规范", "提示")
                                        Exit Sub
                                    End If
                                Else    '存在 ,要修改
                                    If Me.txtConSize.Text <> conSizeOg Or Me.txtConType.Text.ToUpper <> conTypeOg Then
                                        '修改了箱型尺寸，要更新
                                        If Me.txtConSize.Text Like "##" Then
                                            If Me.txtConType.Text.ToUpper Like "[A-Z][A-Z]" Then
                                                Dim sqlEditCon As String
                                                sqlEditCon = "Update CON_CRITERION Set SIZE_CON= '" & Me.txtConSize.Text & "', CONTAINER_TYPE= '" & Me.txtConType.Text.ToUpper & "' where CONTAINER_NO='" & Me.txtContainerNo.Text & "'"
                                                ExecSql(sqlEditCon)
                                            Else
                                                Me.txtConType.Focus()
                                                MessageBox.Show("箱型不合规范", "提示")
                                                Exit Sub
                                            End If
                                        Else
                                            Me.txtConSize.Focus()
                                            MessageBox.Show("箱尺寸不合规范", "提示")
                                            Exit Sub
                                        End If
                                    End If
                                End If
                                '记录操作日志
                                Call OperateHistory(G_DeptName, Now, G_User, "修改", "CON_IMAGE", Trim(txtID.Text), "CON_IMAGE_ID")

                                sqlda.Update(ds)
                                Me.Close()
                            Else
                            MessageBox.Show("该集装箱号在箱规范中不存在或者箱号不规范，不能增加", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        End If
                    Else
                        MessageBox.Show("同一船次 集装箱号 贝位号 不可重复", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MessageBox.Show("请输入规范的贝位号", "提示")
            End If
            Else
            MessageBox.Show("集装箱号 箱状态 贝位号 不可为空", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    'Private Sub cbLoadPort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbLoadPort.SelectedIndexChanged
    '    Try
    '        If TypeName(Me.cbLoadPort.SelectedValue) = "String" Then
    '            'Me.txtLOAD_PORT.Text = Me.cbLoadPort.SelectedValue
    '            Dim i As Integer
    '            For i = 0 To Me.dvLoadPort.Count - 1
    '                If Me.cbLoadPort.SelectedValue = Me.dvLoadPort(i)("CODE_PORT") Then
    '                    Me.txtLOAD_PORT.Text = Me.dvLoadPort(i)("PORT_ENG")
    '                End If
    '            Next
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    'Private Sub cbUnloadPort_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbUnloadPort.SelectedIndexChanged
    '    Try
    '        If TypeName(Me.cbUnloadPort.SelectedValue) = "String" Then
    '            'Me.txtUNLOAD_PORT.Text = Me.cbUnloadPort.SelectedValue
    '            Dim i As Integer
    '            For i = 0 To Me.dvUnloadPort.Count - 1
    '                If Me.cbUnloadPort.SelectedValue = Me.dvUnloadPort(i)("CODE_PORT") Then
    '                    Me.txtUNLOAD_PORT.Text = Me.dvUnloadPort(i)("PORT_ENG")
    '                End If
    '            Next
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    'Private Sub cbDelivery_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDelivery.SelectedIndexChanged
    '    Try
    '        If TypeName(Me.cbDelivery.SelectedValue) = "String" Then
    '            'Me.txtDelivery.Text = Me.cbDelivery.SelectedValue
    '            Dim i As Integer
    '            For i = 0 To Me.dvDelivery.Count - 1
    '                If Me.cbDelivery.SelectedValue = Me.dvDelivery(i)("CODE_PORT") Then
    '                    Me.txtDelivery.Text = Me.dvDelivery(i)("PORT_ENG")
    '                End If
    '            Next
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub FrmConImageCargo_Addg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Select Case True
                Case Me.txtContainerNo.Focused()
                    Me.txtConSize.Focus()
                Case Me.txtConSize.Focused
                    Me.txtConType.Focus()
                Case Me.txtConType.Focused
                    Me.cbState.Focus()
                Case Me.cbState.Focused()
                    Me.txtSealNo.Focus()
                Case Me.txtSealNo.Focused
                    Me.txtBayNo.Focus()
                Case Me.txtBayNo.Focused
                    Me.txtBillNO.Focus()
                Case Me.txtBillNO.Focused
                    Me.cbLoadPort.Focus()
                Case Me.cbLoadPort.Focused
                    Call cbLoadPort_TextChanged(sender, e)
                    If Mark1 = False Then
                        Me.cbLoadPortEng.Text = ""
                    End If
                    Me.cbLoadPortEng.Focus()
                Case Me.cbLoadPortEng.Focused
                    Me.cbUnloadPort.Focus()
                Case Me.cbUnloadPort.Focused
                    Call cbUnloadPort_TextChanged(sender, e)
                    If Mark1 = False Then
                        Me.cbUnloadPortEng.Text = ""
                    End If
                    Me.cbUnloadPortEng.Focus()
                Case Me.cbUnloadPortEng.Focused
                    Me.cbDelivery.Focus()
                Case Me.cbDelivery.Focused
                    Call cbDelivery_TextChanged(sender, e)
                    If Mark1 = False Then
                        Me.cbReceivePlaceEng.Text = ""
                    End If
                    Me.cbReceivePlaceEng.Focus()
                Case Me.cbReceivePlaceEng.Focused
                    Me.txtAmount.Focus()
                Case Me.txtAmount.Focused
                    Me.txtGROSSWEIGHT.Focus()
                Case Me.txtGROSSWEIGHT.Focused
                    Me.txtVolume.Focus()
                Case Me.txtVolume.Focused
                    Me.cbTempUnit.Focus()
                Case Me.cbTempUnit.Focused
                    Me.txtTempSet.Focus()
                Case Me.txtTempSet.Focused
                    Me.txtTempMin.Focus()
                Case Me.txtTempMin.Focused
                    Me.txtTempMax.Focus()
                Case Me.txtTempMax.Focused
                    Me.txtDANGER_GRADE.Focus()
                Case Me.txtDANGER_GRADE.Focused
                    Me.txtDANGER_PAGENO.Focus()
                Case Me.txtDANGER_PAGENO.Focused
                    Me.txtDANGER_NO.Focus()
                Case Me.txtDANGER_NO.Focused
                    Me.txtDANGER_MARK.Focus()
                Case Me.txtDANGER_MARK.Focused
                    Me.btSave.Focus()
            End Select
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

    Private Sub cbDelivery_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Mark1 = False
            Dim i As Integer
            For i = 0 To dvDelivery.Count - 1
                If Not IsDBNull(dvDelivery(i)("PORT_CHA")) Then
                    If dvDelivery(i)("CODE_PORT") Like Me.cbDelivery.Text.Trim.ToUpper & "*" Or dvDelivery(i)("PORT_CHA") Like Me.cbDelivery.Text.Trim.ToUpper & "*" Then
                        Me.cbDelivery.SelectedValue = dvDelivery(i)("CODE_PORT")
                        Mark1 = True
                        Exit For
                    End If
                Else
                    If dvDelivery(i)("CODE_PORT") Like Me.cbDelivery.Text.Trim.ToUpper & "*" Then
                        Me.cbDelivery.SelectedValue = dvDelivery(i)("CODE_PORT")
                        Mark1 = True
                        Exit For
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtContainerNo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtContainerNo.Leave
        Me.txtContainerNo.Text = Me.txtContainerNo.Text.Trim.ToUpper
        Me.txtConSize.Clear()
        Me.txtConType.Clear()

        Dim iConCheck As Integer
        Dim sqlConBeing As String
        Dim dvConBeing As New DataView
        iConCheck = CheckConNO(Me.txtContainerNo.Text)
        sqlConBeing = "SELECT CONTAINER_NO, SIZE_CON, CONTAINER_TYPE FROM CON_CRITERION WHERE CONTAINER_NO = '" & Me.txtContainerNo.Text & "' or CONTAINER_NO = '" & GetConOtherMode(Me.txtContainerNo.Text) & "'"
        If iConCheck = 2 Then
            dvConBeing = Filldata(sqlConBeing)
            If dvConBeing.Count > 0 Then
                Me.txtContainerNo.Text = dvConBeing(0)("CONTAINER_NO")
                If Not IsDBNull(dvConBeing(0)("SIZE_CON")) Then
                    Me.txtConSize.Text = dvConBeing(0)("SIZE_CON")
                    conSizeOg = dvConBeing(0)("SIZE_CON")
                End If
                If Not IsDBNull(dvConBeing(0)("CONTAINER_TYPE")) Then
                    Me.txtConType.Text = dvConBeing(0)("CONTAINER_TYPE")
                    conTypeOg = dvConBeing(0)("CONTAINER_TYPE")
                End If
            Else

            End If
        ElseIf iConCheck = 1 Then
            dvConBeing = Filldata(sqlConBeing)
            If dvConBeing.Count > 0 Then
                Me.txtContainerNo.Text = dvConBeing(0)("CONTAINER_NO")
                If Not IsDBNull(dvConBeing(0)("SIZE_CON")) Then
                    Me.txtConSize.Text = dvConBeing(0)("SIZE_CON")
                    conSizeOg = dvConBeing(0)("SIZE_CON")
                End If
                If Not IsDBNull(dvConBeing(0)("CONTAINER_TYPE")) Then
                    Me.txtConType.Text = dvConBeing(0)("CONTAINER_TYPE")
                    conTypeOg = dvConBeing(0)("CONTAINER_TYPE")
                End If
            Else
                MessageBox.Show("箱号校验不正确且箱规范中不存在", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else
            MessageBox.Show("箱号不合规范", "提示")
        End If
    End Sub
End Class
