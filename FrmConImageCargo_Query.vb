Imports TALLY.DBControl
Public Class FrmConImageCargo_Query
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()

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
    Friend WithEvents cbPassMark As System.Windows.Forms.ComboBox
    Friend WithEvents cbShortUnload As System.Windows.Forms.ComboBox
    Friend WithEvents cbKeeperCode As System.Windows.Forms.ComboBox
    Friend WithEvents txtKeeper As System.Windows.Forms.TextBox
    Friend WithEvents cbCompanyCode As System.Windows.Forms.ComboBox
    Friend WithEvents txtOverBehind As System.Windows.Forms.TextBox
    Friend WithEvents txtDANGER_MARK As System.Windows.Forms.TextBox
    Friend WithEvents txtOverBefore As System.Windows.Forms.TextBox
    Friend WithEvents txtDANGER_GRADE As System.Windows.Forms.TextBox
    Friend WithEvents txtDANGER_NO As System.Windows.Forms.TextBox
    Friend WithEvents txtDANGER_PAGENO As System.Windows.Forms.TextBox
    Friend WithEvents txtOverRight As System.Windows.Forms.TextBox
    Friend WithEvents txtOverLeft As System.Windows.Forms.TextBox
    Friend WithEvents txtOverHeight As System.Windows.Forms.TextBox
    Friend WithEvents cbTempUnit As System.Windows.Forms.ComboBox
    Friend WithEvents txtBayNo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbState As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbDeliveryCode As System.Windows.Forms.ComboBox
    Friend WithEvents cbUnloadPortCode As System.Windows.Forms.ComboBox
    Friend WithEvents cbLoadPortCode As System.Windows.Forms.ComboBox
    Friend WithEvents txtContainerSize As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSealNo As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtContainerNo As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtVolume As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTempMax As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGROSSWEIGHT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTAREWEIGHT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtTempMin As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtTempSet As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents cbGoodsCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtMark As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBillNO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtGOODS_CHA As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtGOODS_ENG As System.Windows.Forms.TextBox
    Friend WithEvents txtDelivery As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtLOAD_PORT As System.Windows.Forms.TextBox
    Friend WithEvents txtUNLOAD_PORT As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cbPassMark = New System.Windows.Forms.ComboBox()
        Me.cbShortUnload = New System.Windows.Forms.ComboBox()
        Me.cbKeeperCode = New System.Windows.Forms.ComboBox()
        Me.txtKeeper = New System.Windows.Forms.TextBox()
        Me.cbCompanyCode = New System.Windows.Forms.ComboBox()
        Me.txtOverBehind = New System.Windows.Forms.TextBox()
        Me.txtDANGER_MARK = New System.Windows.Forms.TextBox()
        Me.txtOverBefore = New System.Windows.Forms.TextBox()
        Me.txtDANGER_GRADE = New System.Windows.Forms.TextBox()
        Me.txtDANGER_NO = New System.Windows.Forms.TextBox()
        Me.txtDANGER_PAGENO = New System.Windows.Forms.TextBox()
        Me.txtOverRight = New System.Windows.Forms.TextBox()
        Me.txtOverLeft = New System.Windows.Forms.TextBox()
        Me.txtOverHeight = New System.Windows.Forms.TextBox()
        Me.cbTempUnit = New System.Windows.Forms.ComboBox()
        Me.txtBayNo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbState = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbDeliveryCode = New System.Windows.Forms.ComboBox()
        Me.cbUnloadPortCode = New System.Windows.Forms.ComboBox()
        Me.cbLoadPortCode = New System.Windows.Forms.ComboBox()
        Me.txtContainerSize = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSealNo = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtContainerNo = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtVolume = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTempMax = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGROSSWEIGHT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTAREWEIGHT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtTempMin = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtTempSet = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.cbGoodsCode = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtMark = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBillNO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtGOODS_CHA = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtGOODS_ENG = New System.Windows.Forms.TextBox()
        Me.txtDelivery = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtLOAD_PORT = New System.Windows.Forms.TextBox()
        Me.txtUNLOAD_PORT = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cbPassMark
        '
        Me.cbPassMark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbPassMark.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbPassMark.Location = New System.Drawing.Point(498, 296)
        Me.cbPassMark.MaxLength = 1
        Me.cbPassMark.Name = "cbPassMark"
        Me.cbPassMark.Size = New System.Drawing.Size(130, 20)
        Me.cbPassMark.TabIndex = 457
        '
        'cbShortUnload
        '
        Me.cbShortUnload.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbShortUnload.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbShortUnload.Location = New System.Drawing.Point(498, 320)
        Me.cbShortUnload.MaxLength = 2
        Me.cbShortUnload.Name = "cbShortUnload"
        Me.cbShortUnload.Size = New System.Drawing.Size(130, 20)
        Me.cbShortUnload.TabIndex = 458
        '
        'cbKeeperCode
        '
        Me.cbKeeperCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbKeeperCode.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbKeeperCode.Location = New System.Drawing.Point(498, 250)
        Me.cbKeeperCode.MaxLength = 2
        Me.cbKeeperCode.Name = "cbKeeperCode"
        Me.cbKeeperCode.Size = New System.Drawing.Size(130, 20)
        Me.cbKeeperCode.TabIndex = 455
        '
        'txtKeeper
        '
        Me.txtKeeper.Location = New System.Drawing.Point(498, 272)
        Me.txtKeeper.MaxLength = 20
        Me.txtKeeper.Name = "txtKeeper"
        Me.txtKeeper.Size = New System.Drawing.Size(130, 21)
        Me.txtKeeper.TabIndex = 456
        Me.txtKeeper.Text = ""
        '
        'cbCompanyCode
        '
        Me.cbCompanyCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbCompanyCode.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbCompanyCode.Location = New System.Drawing.Point(498, 208)
        Me.cbCompanyCode.MaxLength = 30
        Me.cbCompanyCode.Name = "cbCompanyCode"
        Me.cbCompanyCode.Size = New System.Drawing.Size(130, 20)
        Me.cbCompanyCode.TabIndex = 453
        '
        'txtOverBehind
        '
        Me.txtOverBehind.Location = New System.Drawing.Point(498, 94)
        Me.txtOverBehind.MaxLength = 20
        Me.txtOverBehind.Name = "txtOverBehind"
        Me.txtOverBehind.Size = New System.Drawing.Size(130, 21)
        Me.txtOverBehind.TabIndex = 448
        Me.txtOverBehind.Text = ""
        '
        'txtDANGER_MARK
        '
        Me.txtDANGER_MARK.Location = New System.Drawing.Point(498, 184)
        Me.txtDANGER_MARK.MaxLength = 32
        Me.txtDANGER_MARK.Name = "txtDANGER_MARK"
        Me.txtDANGER_MARK.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_MARK.TabIndex = 452
        Me.txtDANGER_MARK.Text = ""
        '
        'txtOverBefore
        '
        Me.txtOverBefore.Location = New System.Drawing.Point(498, 72)
        Me.txtOverBefore.MaxLength = 20
        Me.txtOverBefore.Name = "txtOverBefore"
        Me.txtOverBefore.Size = New System.Drawing.Size(130, 21)
        Me.txtOverBefore.TabIndex = 447
        Me.txtOverBefore.Text = ""
        '
        'txtDANGER_GRADE
        '
        Me.txtDANGER_GRADE.Location = New System.Drawing.Point(498, 118)
        Me.txtDANGER_GRADE.MaxLength = 10
        Me.txtDANGER_GRADE.Name = "txtDANGER_GRADE"
        Me.txtDANGER_GRADE.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_GRADE.TabIndex = 449
        Me.txtDANGER_GRADE.Text = ""
        '
        'txtDANGER_NO
        '
        Me.txtDANGER_NO.Location = New System.Drawing.Point(498, 162)
        Me.txtDANGER_NO.MaxLength = 10
        Me.txtDANGER_NO.Name = "txtDANGER_NO"
        Me.txtDANGER_NO.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_NO.TabIndex = 451
        Me.txtDANGER_NO.Text = ""
        '
        'txtDANGER_PAGENO
        '
        Me.txtDANGER_PAGENO.Location = New System.Drawing.Point(498, 140)
        Me.txtDANGER_PAGENO.MaxLength = 20
        Me.txtDANGER_PAGENO.Name = "txtDANGER_PAGENO"
        Me.txtDANGER_PAGENO.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_PAGENO.TabIndex = 450
        Me.txtDANGER_PAGENO.Text = ""
        '
        'txtOverRight
        '
        Me.txtOverRight.Location = New System.Drawing.Point(498, 50)
        Me.txtOverRight.MaxLength = 20
        Me.txtOverRight.Name = "txtOverRight"
        Me.txtOverRight.Size = New System.Drawing.Size(130, 21)
        Me.txtOverRight.TabIndex = 446
        Me.txtOverRight.Text = ""
        '
        'txtOverLeft
        '
        Me.txtOverLeft.Location = New System.Drawing.Point(498, 28)
        Me.txtOverLeft.MaxLength = 20
        Me.txtOverLeft.Name = "txtOverLeft"
        Me.txtOverLeft.Size = New System.Drawing.Size(130, 21)
        Me.txtOverLeft.TabIndex = 445
        Me.txtOverLeft.Text = ""
        '
        'txtOverHeight
        '
        Me.txtOverHeight.Location = New System.Drawing.Point(498, 6)
        Me.txtOverHeight.MaxLength = 20
        Me.txtOverHeight.Name = "txtOverHeight"
        Me.txtOverHeight.Size = New System.Drawing.Size(130, 21)
        Me.txtOverHeight.TabIndex = 444
        Me.txtOverHeight.Text = ""
        '
        'cbTempUnit
        '
        Me.cbTempUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTempUnit.Items.AddRange(New Object() {"", "C", "H"})
        Me.cbTempUnit.Location = New System.Drawing.Point(288, 246)
        Me.cbTempUnit.Name = "cbTempUnit"
        Me.cbTempUnit.Size = New System.Drawing.Size(130, 20)
        Me.cbTempUnit.TabIndex = 440
        '
        'txtBayNo
        '
        Me.txtBayNo.Location = New System.Drawing.Point(78, 102)
        Me.txtBayNo.MaxLength = 7
        Me.txtBayNo.Name = "txtBayNo"
        Me.txtBayNo.Size = New System.Drawing.Size(130, 21)
        Me.txtBayNo.TabIndex = 424
        Me.txtBayNo.Text = ""
        '
        'Label14
        '
        Me.Label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label14.Location = New System.Drawing.Point(4, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 18)
        Me.Label14.TabIndex = 500
        Me.Label14.Text = "贝位号"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbState
        '
        Me.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbState.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbState.Location = New System.Drawing.Point(78, 54)
        Me.cbState.Name = "cbState"
        Me.cbState.Size = New System.Drawing.Size(130, 20)
        Me.cbState.TabIndex = 422
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(4, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 499
        Me.Label6.Text = "箱状态"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbDeliveryCode
        '
        Me.cbDeliveryCode.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbDeliveryCode.Location = New System.Drawing.Point(288, 102)
        Me.cbDeliveryCode.MaxDropDownItems = 20
        Me.cbDeliveryCode.Name = "cbDeliveryCode"
        Me.cbDeliveryCode.Size = New System.Drawing.Size(130, 20)
        Me.cbDeliveryCode.TabIndex = 434
        '
        'cbUnloadPortCode
        '
        Me.cbUnloadPortCode.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbUnloadPortCode.Location = New System.Drawing.Point(288, 54)
        Me.cbUnloadPortCode.MaxDropDownItems = 20
        Me.cbUnloadPortCode.Name = "cbUnloadPortCode"
        Me.cbUnloadPortCode.Size = New System.Drawing.Size(130, 20)
        Me.cbUnloadPortCode.TabIndex = 432
        '
        'cbLoadPortCode
        '
        Me.cbLoadPortCode.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbLoadPortCode.Location = New System.Drawing.Point(288, 6)
        Me.cbLoadPortCode.MaxDropDownItems = 20
        Me.cbLoadPortCode.Name = "cbLoadPortCode"
        Me.cbLoadPortCode.Size = New System.Drawing.Size(130, 20)
        Me.cbLoadPortCode.TabIndex = 430
        '
        'txtContainerSize
        '
        Me.txtContainerSize.Location = New System.Drawing.Point(78, 30)
        Me.txtContainerSize.MaxLength = 20
        Me.txtContainerSize.Name = "txtContainerSize"
        Me.txtContainerSize.Size = New System.Drawing.Size(130, 21)
        Me.txtContainerSize.TabIndex = 421
        Me.txtContainerSize.Text = ""
        '
        'Label11
        '
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.Location = New System.Drawing.Point(4, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 18)
        Me.Label11.TabIndex = 492
        Me.Label11.Text = "箱尺寸"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSealNo
        '
        Me.txtSealNo.Location = New System.Drawing.Point(78, 78)
        Me.txtSealNo.MaxLength = 20
        Me.txtSealNo.Name = "txtSealNo"
        Me.txtSealNo.Size = New System.Drawing.Size(130, 21)
        Me.txtSealNo.TabIndex = 423
        Me.txtSealNo.Text = ""
        '
        'Label35
        '
        Me.Label35.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label35.Location = New System.Drawing.Point(4, 80)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(72, 18)
        Me.Label35.TabIndex = 490
        Me.Label35.Text = "铅封号"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtContainerNo
        '
        Me.txtContainerNo.Location = New System.Drawing.Point(78, 6)
        Me.txtContainerNo.MaxLength = 11
        Me.txtContainerNo.Name = "txtContainerNo"
        Me.txtContainerNo.Size = New System.Drawing.Size(130, 21)
        Me.txtContainerNo.TabIndex = 420
        Me.txtContainerNo.Text = ""
        '
        'Label36
        '
        Me.Label36.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label36.Location = New System.Drawing.Point(4, 8)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 18)
        Me.Label36.TabIndex = 494
        Me.Label36.Text = "集装箱号"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label43
        '
        Me.Label43.Location = New System.Drawing.Point(424, 96)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(72, 18)
        Me.Label43.TabIndex = 498
        Me.Label43.Text = "后超"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label42
        '
        Me.Label42.Location = New System.Drawing.Point(424, 298)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(72, 18)
        Me.Label42.TabIndex = 497
        Me.Label42.Text = "通关标识"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label41
        '
        Me.Label41.Location = New System.Drawing.Point(424, 322)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(72, 18)
        Me.Label41.TabIndex = 496
        Me.Label41.Text = "甩箱短卸"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label40
        '
        Me.Label40.Location = New System.Drawing.Point(424, 252)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(72, 18)
        Me.Label40.TabIndex = 495
        Me.Label40.Text = "箱经营人码"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(214, 296)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 18)
        Me.Label29.TabIndex = 478
        Me.Label29.Text = "冷藏最低温"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(424, 186)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(72, 18)
        Me.Label34.TabIndex = 488
        Me.Label34.Text = "危险品标签"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(424, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 18)
        Me.Label16.TabIndex = 486
        Me.Label16.Text = "前超"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(214, 248)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 18)
        Me.Label15.TabIndex = 482
        Me.Label15.Text = "温度单位"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(288, 150)
        Me.txtAmount.MaxLength = 20
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(130, 21)
        Me.txtAmount.TabIndex = 436
        Me.txtAmount.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(214, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 472
        Me.Label10.Text = "件数"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVolume
        '
        Me.txtVolume.Location = New System.Drawing.Point(288, 222)
        Me.txtVolume.MaxLength = 20
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(130, 21)
        Me.txtVolume.TabIndex = 439
        Me.txtVolume.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(214, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 468
        Me.Label5.Text = "体积尺寸"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTempMax
        '
        Me.txtTempMax.Location = New System.Drawing.Point(288, 318)
        Me.txtTempMax.MaxLength = 20
        Me.txtTempMax.Name = "txtTempMax"
        Me.txtTempMax.Size = New System.Drawing.Size(130, 21)
        Me.txtTempMax.TabIndex = 443
        Me.txtTempMax.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(214, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 467
        Me.Label3.Text = "冷藏最高温"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGROSSWEIGHT
        '
        Me.txtGROSSWEIGHT.Location = New System.Drawing.Point(288, 174)
        Me.txtGROSSWEIGHT.MaxLength = 20
        Me.txtGROSSWEIGHT.Name = "txtGROSSWEIGHT"
        Me.txtGROSSWEIGHT.Size = New System.Drawing.Size(130, 21)
        Me.txtGROSSWEIGHT.TabIndex = 437
        Me.txtGROSSWEIGHT.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(214, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 463
        Me.Label1.Text = "箱毛重"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTAREWEIGHT
        '
        Me.txtTAREWEIGHT.Location = New System.Drawing.Point(288, 198)
        Me.txtTAREWEIGHT.MaxLength = 20
        Me.txtTAREWEIGHT.Name = "txtTAREWEIGHT"
        Me.txtTAREWEIGHT.Size = New System.Drawing.Size(130, 21)
        Me.txtTAREWEIGHT.TabIndex = 438
        Me.txtTAREWEIGHT.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(214, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 462
        Me.Label2.Text = "箱皮重"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(424, 164)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 18)
        Me.Label26.TabIndex = 480
        Me.Label26.Text = "危险品编号"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(424, 142)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 18)
        Me.Label27.TabIndex = 483
        Me.Label27.Text = "危险品页号"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTempMin
        '
        Me.txtTempMin.Location = New System.Drawing.Point(288, 294)
        Me.txtTempMin.MaxLength = 20
        Me.txtTempMin.Name = "txtTempMin"
        Me.txtTempMin.Size = New System.Drawing.Size(130, 21)
        Me.txtTempMin.TabIndex = 442
        Me.txtTempMin.Text = ""
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(424, 120)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(72, 18)
        Me.Label30.TabIndex = 466
        Me.Label30.Text = "危险品等级"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTempSet
        '
        Me.txtTempSet.Location = New System.Drawing.Point(288, 270)
        Me.txtTempSet.MaxLength = 20
        Me.txtTempSet.Name = "txtTempSet"
        Me.txtTempSet.Size = New System.Drawing.Size(130, 21)
        Me.txtTempSet.TabIndex = 441
        Me.txtTempSet.Text = ""
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(214, 272)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(72, 18)
        Me.Label31.TabIndex = 476
        Me.Label31.Text = "设置温度"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(288, 346)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 460
        Me.btQuit.Text = "返回"
        '
        'cbGoodsCode
        '
        Me.cbGoodsCode.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbGoodsCode.Location = New System.Drawing.Point(78, 150)
        Me.cbGoodsCode.MaxDropDownItems = 20
        Me.cbGoodsCode.Name = "cbGoodsCode"
        Me.cbGoodsCode.Size = New System.Drawing.Size(130, 20)
        Me.cbGoodsCode.TabIndex = 426
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(4, 152)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 18)
        Me.Label17.TabIndex = 487
        Me.Label17.Text = "货名代码"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(78, 174)
        Me.txtMark.MaxLength = 35
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(130, 21)
        Me.txtMark.TabIndex = 427
        Me.txtMark.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(4, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 470
        Me.Label9.Text = "标志"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBillNO
        '
        Me.txtBillNO.Location = New System.Drawing.Point(78, 126)
        Me.txtBillNO.MaxLength = 20
        Me.txtBillNO.Name = "txtBillNO"
        Me.txtBillNO.Size = New System.Drawing.Size(130, 21)
        Me.txtBillNO.TabIndex = 425
        Me.txtBillNO.Text = ""
        '
        'Label4
        '
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(4, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 469
        Me.Label4.Text = "提单号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(2, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 18)
        Me.Label7.TabIndex = 484
        Me.Label7.Text = "货物中文描述"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGOODS_CHA
        '
        Me.txtGOODS_CHA.Location = New System.Drawing.Point(6, 218)
        Me.txtGOODS_CHA.MaxLength = 30
        Me.txtGOODS_CHA.Multiline = True
        Me.txtGOODS_CHA.Name = "txtGOODS_CHA"
        Me.txtGOODS_CHA.Size = New System.Drawing.Size(200, 48)
        Me.txtGOODS_CHA.TabIndex = 428
        Me.txtGOODS_CHA.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(2, 270)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 18)
        Me.Label8.TabIndex = 481
        Me.Label8.Text = "货物英文描述"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(424, 230)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 18)
        Me.Label12.TabIndex = 477
        Me.Label12.Text = "箱公司名称"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(424, 208)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 18)
        Me.Label13.TabIndex = 473
        Me.Label13.Text = "箱公司代码"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(424, 274)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 18)
        Me.Label19.TabIndex = 464
        Me.Label19.Text = "箱经营人"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGOODS_ENG
        '
        Me.txtGOODS_ENG.Location = New System.Drawing.Point(6, 290)
        Me.txtGOODS_ENG.MaxLength = 30
        Me.txtGOODS_ENG.Multiline = True
        Me.txtGOODS_ENG.Name = "txtGOODS_ENG"
        Me.txtGOODS_ENG.Size = New System.Drawing.Size(200, 48)
        Me.txtGOODS_ENG.TabIndex = 429
        Me.txtGOODS_ENG.Text = ""
        '
        'txtDelivery
        '
        Me.txtDelivery.Location = New System.Drawing.Point(288, 126)
        Me.txtDelivery.MaxLength = 70
        Me.txtDelivery.Name = "txtDelivery"
        Me.txtDelivery.Size = New System.Drawing.Size(130, 21)
        Me.txtDelivery.TabIndex = 435
        Me.txtDelivery.Text = ""
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(214, 128)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 18)
        Me.Label20.TabIndex = 475
        Me.Label20.Text = "交货地"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(214, 104)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 18)
        Me.Label21.TabIndex = 471
        Me.Label21.Text = "交货地代码"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(214, 56)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 18)
        Me.Label22.TabIndex = 485
        Me.Label22.Text = "卸货港代码"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(214, 8)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 18)
        Me.Label23.TabIndex = 465
        Me.Label23.Text = "装货港代码"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(214, 32)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 18)
        Me.Label24.TabIndex = 479
        Me.Label24.Text = "装货港"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLOAD_PORT
        '
        Me.txtLOAD_PORT.Location = New System.Drawing.Point(288, 30)
        Me.txtLOAD_PORT.MaxLength = 35
        Me.txtLOAD_PORT.Name = "txtLOAD_PORT"
        Me.txtLOAD_PORT.Size = New System.Drawing.Size(130, 21)
        Me.txtLOAD_PORT.TabIndex = 431
        Me.txtLOAD_PORT.Text = ""
        '
        'txtUNLOAD_PORT
        '
        Me.txtUNLOAD_PORT.Location = New System.Drawing.Point(288, 78)
        Me.txtUNLOAD_PORT.MaxLength = 35
        Me.txtUNLOAD_PORT.Name = "txtUNLOAD_PORT"
        Me.txtUNLOAD_PORT.Size = New System.Drawing.Size(130, 21)
        Me.txtUNLOAD_PORT.TabIndex = 433
        Me.txtUNLOAD_PORT.Text = ""
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(214, 80)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(72, 18)
        Me.Label32.TabIndex = 474
        Me.Label32.Text = "卸货港"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label37
        '
        Me.Label37.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label37.Location = New System.Drawing.Point(424, 30)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(72, 18)
        Me.Label37.TabIndex = 489
        Me.Label37.Text = "左超"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label38
        '
        Me.Label38.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label38.Location = New System.Drawing.Point(424, 8)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(72, 18)
        Me.Label38.TabIndex = 491
        Me.Label38.Text = "超高"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label39
        '
        Me.Label39.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label39.Location = New System.Drawing.Point(424, 52)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(72, 18)
        Me.Label39.TabIndex = 493
        Me.Label39.Text = "右超"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 461
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(498, 228)
        Me.txtCompany.MaxLength = 30
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(130, 21)
        Me.txtCompany.TabIndex = 454
        Me.txtCompany.Text = ""
        '
        'FrmConImageCargo_Query
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(634, 375)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbPassMark, Me.cbShortUnload, Me.cbKeeperCode, Me.txtKeeper, Me.cbCompanyCode, Me.txtOverBehind, Me.txtDANGER_MARK, Me.txtOverBefore, Me.txtDANGER_GRADE, Me.txtDANGER_NO, Me.txtDANGER_PAGENO, Me.txtOverRight, Me.txtOverLeft, Me.txtOverHeight, Me.cbTempUnit, Me.txtBayNo, Me.Label14, Me.cbState, Me.Label6, Me.cbDeliveryCode, Me.cbUnloadPortCode, Me.cbLoadPortCode, Me.txtContainerSize, Me.Label11, Me.txtSealNo, Me.Label35, Me.txtContainerNo, Me.Label36, Me.Label43, Me.Label42, Me.Label41, Me.Label40, Me.Label29, Me.Label34, Me.Label16, Me.Label15, Me.txtAmount, Me.Label10, Me.txtVolume, Me.Label5, Me.txtTempMax, Me.Label3, Me.txtGROSSWEIGHT, Me.Label1, Me.txtTAREWEIGHT, Me.Label2, Me.Label26, Me.Label27, Me.txtTempMin, Me.Label30, Me.txtTempSet, Me.Label31, Me.btQuit, Me.cbGoodsCode, Me.Label17, Me.txtMark, Me.Label9, Me.txtBillNO, Me.Label4, Me.Label7, Me.txtGOODS_CHA, Me.Label8, Me.Label12, Me.Label13, Me.Label19, Me.txtGOODS_ENG, Me.txtDelivery, Me.Label20, Me.Label21, Me.Label22, Me.Label23, Me.Label24, Me.txtLOAD_PORT, Me.txtUNLOAD_PORT, Me.Label32, Me.Label37, Me.Label38, Me.Label39, Me.txtID, Me.txtCompany})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConImageCargo_Query"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "集装箱进口船图信息 查看"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmConImageCargo_Query_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dw As New DataView()
        Dim sqlstr As String
        Dim dwCodeGoods As New DataView()
        Dim sqlCodeGoods As String

        Dim dvState As New DataView()
        Dim dvLoadPort As New DataView()
        Dim dvUnloadPort As New DataView()
        Dim dvDelivery As New DataView()
        Dim sqlConState, sqlPort, sqlDelivery As String

        Try
            sqlConState = "SELECT EFL_Code, EFL_Name FROM Code_ConEFLType"
            dvState = Filldata(sqlConState)
            Me.cbState.DataSource = dvState
            Me.cbState.DisplayMember = "EFL_Name"
            Me.cbState.ValueMember = "EFL_Code"

            sqlCodeGoods = "SELECT CODE, GOODS FROM CODEGOODS"
            dwCodeGoods = Filldata(sqlCodeGoods)
            Me.cbGoodsCode.DataSource = dwCodeGoods
            Me.cbGoodsCode.DisplayMember = "GOODS"
            Me.cbGoodsCode.ValueMember = "CODE"

            sqlPort = "SELECT CODE_PORT, PORT_CHA, PORT_ENG FROM CODE_PORT ORDER BY CODE_PORT"
            dvLoadPort = Filldata(sqlPort)
            Me.cbLoadPortCode.DataSource = dvLoadPort
            Me.cbLoadPortCode.DisplayMember = "CODE_PORT"
            Me.cbLoadPortCode.ValueMember = "CODE_PORT"

            dvUnloadPort = Filldata(sqlPort)
            Me.cbUnloadPortCode.DataSource = dvUnloadPort
            Me.cbUnloadPortCode.DisplayMember = "CODE_PORT"
            Me.cbUnloadPortCode.ValueMember = "CODE_PORT"

            sqlDelivery = "SELECT CODE_PORT, PORT_CHA, PORT_ENG FROM CODE_PORT ORDER BY CODE_PORT"
            dvDelivery = Filldata(sqlDelivery)
            Me.cbDeliveryCode.DataSource = dvDelivery
            Me.cbDeliveryCode.DisplayMember = "CODE_PORT"
            Me.cbDeliveryCode.ValueMember = "CODE_PORT"


            sqlstr = "SELECT * FROM CON_IMAGE_RECORD WHERE CON_IMAGE_RECORD_ID = '" & ID & "'"
            dw = Updatedata(sqlda, sqlstr, ds)

            If dw.Count = 1 Then
                txtID.Text = ds.Tables(0).Rows(0).Item("CON_IMAGE_RECORD_ID")
                txtContainerNo.Text = ds.Tables(0).Rows(0).Item("CONTAINER_NO")
                txtSealNo.Text = ds.Tables(0).Rows(0).Item("SealNo")
                txtBayNo.Text = ds.Tables(0).Rows(0).Item("BayNo")
                txtBillNO.Text = ds.Tables(0).Rows(0).Item("BLNO")
                txtMark.Text = ds.Tables(0).Rows(0).Item("MARK")
                txtGOODS_ENG.Text = ds.Tables(0).Rows(0).Item("GOODS_ENG")
                txtGOODS_CHA.Text = ds.Tables(0).Rows(0).Item("GOODS_CHA")
                txtLOAD_PORT.Text = ds.Tables(0).Rows(0).Item("LOAD_PORT")
                txtUNLOAD_PORT.Text = ds.Tables(0).Rows(0).Item("UNLOAD_PORT")
                txtDelivery.Text = ds.Tables(0).Rows(0).Item("DELIVERY")

                If Not IsDBNull(ds.Tables(0).Rows(0).Item("SIZE_CON")) Then
                    txtContainerSize.Text = ds.Tables(0).Rows(0).Item("SIZE_CON")
                End If
                If Not IsDBNull(ds.Tables(0).Rows(0).Item("AMOUNT")) Then
                    txtAmount.Text = ds.Tables(0).Rows(0).Item("AMOUNT")
                End If
                If Not IsDBNull(ds.Tables(0).Rows(0).Item("GROSSWEIGHT")) Then
                    Me.txtGROSSWEIGHT.Text = ds.Tables(0).Rows(0).Item("GROSSWEIGHT")
                End If
                If Not IsDBNull(ds.Tables(0).Rows(0).Item("TAREWEIGHT")) Then
                    Me.txtTAREWEIGHT.Text = ds.Tables(0).Rows(0).Item("TAREWEIGHT")
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
                If Not IsDBNull(ds.Tables(0).Rows(0).Item("OVER_HEIGHT")) Then
                    Me.txtOverHeight.Text = ds.Tables(0).Rows(0).Item("OVER_HEIGHT")
                End If
                If Not IsDBNull(ds.Tables(0).Rows(0).Item("OVER_LEFT")) Then
                    txtOverLeft.Text = ds.Tables(0).Rows(0).Item("OVER_LEFT")
                End If
                If Not IsDBNull(ds.Tables(0).Rows(0).Item("OVER_RIGHT")) Then
                    txtOverRight.Text = ds.Tables(0).Rows(0).Item("OVER_RIGHT")
                End If
                If Not IsDBNull(ds.Tables(0).Rows(0).Item("OVER_BEFORE")) Then
                    txtOverBefore.Text = ds.Tables(0).Rows(0).Item("OVER_BEFORE")
                End If
                If Not IsDBNull(ds.Tables(0).Rows(0).Item("OVER_BEHIND")) Then
                    txtOverBehind.Text = ds.Tables(0).Rows(0).Item("OVER_BEHIND")
                End If
                If Not IsDBNull(ds.Tables(0).Rows(0).Item("DANGER_PAGENO")) Then
                    txtDANGER_PAGENO.Text = ds.Tables(0).Rows(0).Item("DANGER_PAGENO")
                End If
                txtDANGER_GRADE.Text = ds.Tables(0).Rows(0).Item("DANGER_GRADE")
                txtDANGER_NO.Text = ds.Tables(0).Rows(0).Item("DANGER_NO")
                txtDANGER_MARK.Text = ds.Tables(0).Rows(0).Item("DANGER_MARK")
                Me.txtCompany.Text = ds.Tables(0).Rows(0).Item("MANUFACTURER")
                Me.txtKeeper.Text = ds.Tables(0).Rows(0).Item("KEEPER")

                Me.cbCompanyCode.Text = ds.Tables(0).Rows(0).Item("CODE_MANUFACTURER")
                Me.cbKeeperCode.Text = ds.Tables(0).Rows(0).Item("CODE_KEEPER")
                Me.cbPassMark.Text = ds.Tables(0).Rows(0).Item("PASS_MARK")
                Me.cbShortUnload.Text = ds.Tables(0).Rows(0).Item("SHORT_UNLOAD")

                Me.cbState.SelectedValue = ds.Tables(0).Rows(0).Item("FULLOREMPTY")
                Me.cbLoadPortCode.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_LOAD_PORT")
                Me.cbUnloadPortCode.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT")
                Me.cbDeliveryCode.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_DELIVERY")
                cbGoodsCode.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_GOODS")
                Me.cbTempUnit.Text = ds.Tables(0).Rows(0).Item("TEMPERATURE_UNIT")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class
