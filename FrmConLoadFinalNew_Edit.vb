Imports TALLY.DBControl
Public Class FrmConLoadFinalNew_Edit
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        AddHandler txtBillNO.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler cbLoadPort.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler cbLoadPortEng.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler cbUnloadPort.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler cbUnloadPortEng.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler cbReceivePlace.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler cbReceivePlaceEng.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler cbEMPTY_MARK.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler cbCONTAINER_MARK.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler dtpLoadDate.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler txtMark.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler txtGOODS_CHA.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler txtGOODS_ENG.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler cbPack.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler txtAmount.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler txtGROSS_WEIGHT.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler txtNETWEIGHT.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler txtPIECE_WEIGHT.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler txtSIZE_MEASURE.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler txtREFRIGERATE_TEMPERATURE.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler cbTempUnit.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler txtDANGER_GRADE.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler txtDANGER_NO.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler txtDANGER_PAGENO.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler txtDANGER_MARK.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler txtRECEIVER.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
        AddHandler txtNOTIFY_PERSON.KeyDown, AddressOf FrmConHatchCargo_Add_KeyDown
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
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtShipName As System.Windows.Forms.TextBox
    Friend WithEvents txtVoyage As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents cbUnloadPortEng As System.Windows.Forms.ComboBox
    Friend WithEvents cbLoadPortEng As System.Windows.Forms.ComboBox
    Friend WithEvents cbReceivePlaceEng As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cbTempUnit As System.Windows.Forms.ComboBox
    Friend WithEvents cbPack As System.Windows.Forms.ComboBox
    Friend WithEvents cbUnloadPort As System.Windows.Forms.ComboBox
    Friend WithEvents cbLoadPort As System.Windows.Forms.ComboBox
    Friend WithEvents cbReceivePlace As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtDANGER_MARK As System.Windows.Forms.TextBox
    Friend WithEvents txtPIECE_WEIGHT As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSIZE_MEASURE As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCONTAINER As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGROSS_WEIGHT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNETWEIGHT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtDANGER_GRADE As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtDANGER_NO As System.Windows.Forms.TextBox
    Friend WithEvents txtDANGER_PAGENO As System.Windows.Forms.TextBox
    Friend WithEvents txtREFRIGERATE_TEMPERATURE As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents cbEMPTY_MARK As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dtpLoadDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtMark As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbCONTAINER_MARK As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBillNO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtGOODS_CHA As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtGOODS_ENG As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtNOTIFY_PERSON As System.Windows.Forms.TextBox
    Friend WithEvents txtRECEIVER As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConLoadFinalNew_Edit))
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.btSave = New System.Windows.Forms.Button
        Me.btQuit = New System.Windows.Forms.Button
        Me.cbUnloadPortEng = New System.Windows.Forms.ComboBox
        Me.cbLoadPortEng = New System.Windows.Forms.ComboBox
        Me.cbReceivePlaceEng = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cbTempUnit = New System.Windows.Forms.ComboBox
        Me.cbPack = New System.Windows.Forms.ComboBox
        Me.cbUnloadPort = New System.Windows.Forms.ComboBox
        Me.cbLoadPort = New System.Windows.Forms.ComboBox
        Me.cbReceivePlace = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.txtDANGER_MARK = New System.Windows.Forms.TextBox
        Me.txtPIECE_WEIGHT = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtSIZE_MEASURE = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCONTAINER = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtGROSS_WEIGHT = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNETWEIGHT = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtDANGER_GRADE = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtDANGER_NO = New System.Windows.Forms.TextBox
        Me.txtDANGER_PAGENO = New System.Windows.Forms.TextBox
        Me.txtREFRIGERATE_TEMPERATURE = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.cbEMPTY_MARK = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.dtpLoadDate = New System.Windows.Forms.DateTimePicker
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtMark = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cbCONTAINER_MARK = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtBillNO = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtGOODS_CHA = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtGOODS_ENG = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtNOTIFY_PERSON = New System.Windows.Forms.TextBox
        Me.txtRECEIVER = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btnDelete = New System.Windows.Forms.Button
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(2, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 18)
        Me.Label12.TabIndex = 779
        Me.Label12.Text = "中文船名"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShipName
        '
        Me.txtShipName.Location = New System.Drawing.Point(76, 8)
        Me.txtShipName.MaxLength = 40
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.ReadOnly = True
        Me.txtShipName.Size = New System.Drawing.Size(130, 21)
        Me.txtShipName.TabIndex = 778
        Me.txtShipName.Text = ""
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(76, 32)
        Me.txtVoyage.MaxLength = 6
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.ReadOnly = True
        Me.txtVoyage.Size = New System.Drawing.Size(130, 21)
        Me.txtVoyage.TabIndex = 776
        Me.txtVoyage.Text = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(2, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 18)
        Me.Label13.TabIndex = 777
        Me.Label13.Text = "航次"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(258, 514)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 29
        Me.btSave.Text = "确定"
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(328, 514)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 30
        Me.btQuit.Text = "退出"
        '
        'cbUnloadPortEng
        '
        Me.cbUnloadPortEng.Location = New System.Drawing.Point(76, 152)
        Me.cbUnloadPortEng.MaxDropDownItems = 20
        Me.cbUnloadPortEng.Name = "cbUnloadPortEng"
        Me.cbUnloadPortEng.Size = New System.Drawing.Size(130, 20)
        Me.cbUnloadPortEng.TabIndex = 4
        '
        'cbLoadPortEng
        '
        Me.cbLoadPortEng.Location = New System.Drawing.Point(76, 104)
        Me.cbLoadPortEng.MaxDropDownItems = 20
        Me.cbLoadPortEng.Name = "cbLoadPortEng"
        Me.cbLoadPortEng.Size = New System.Drawing.Size(130, 20)
        Me.cbLoadPortEng.TabIndex = 2
        '
        'cbReceivePlaceEng
        '
        Me.cbReceivePlaceEng.Location = New System.Drawing.Point(76, 200)
        Me.cbReceivePlaceEng.MaxDropDownItems = 20
        Me.cbReceivePlaceEng.Name = "cbReceivePlaceEng"
        Me.cbReceivePlaceEng.Size = New System.Drawing.Size(130, 20)
        Me.cbReceivePlaceEng.TabIndex = 6
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(2, 202)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 18)
        Me.Label21.TabIndex = 773
        Me.Label21.Text = "收货地英文"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(2, 154)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 18)
        Me.Label22.TabIndex = 774
        Me.Label22.Text = "卸货港英文"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(2, 106)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 18)
        Me.Label23.TabIndex = 772
        Me.Label23.Text = "装货港英文"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(596, 56)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(30, 20)
        Me.Label37.TabIndex = 771
        Me.Label37.Text = "公斤"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(596, 32)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(30, 20)
        Me.Label36.TabIndex = 770
        Me.Label36.Text = "公斤"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(596, 8)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(30, 20)
        Me.Label35.TabIndex = 769
        Me.Label35.Text = "公斤"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(596, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 20)
        Me.Label11.TabIndex = 768
        Me.Label11.Text = "立方"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbTempUnit
        '
        Me.cbTempUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTempUnit.ItemHeight = 12
        Me.cbTempUnit.Items.AddRange(New Object() {"", "C", "F"})
        Me.cbTempUnit.Location = New System.Drawing.Point(578, 102)
        Me.cbTempUnit.Name = "cbTempUnit"
        Me.cbTempUnit.Size = New System.Drawing.Size(48, 20)
        Me.cbTempUnit.TabIndex = 20
        '
        'cbPack
        '
        Me.cbPack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPack.ItemHeight = 12
        Me.cbPack.Location = New System.Drawing.Point(286, 198)
        Me.cbPack.MaxDropDownItems = 20
        Me.cbPack.Name = "cbPack"
        Me.cbPack.Size = New System.Drawing.Size(130, 20)
        Me.cbPack.TabIndex = 13
        '
        'cbUnloadPort
        '
        Me.cbUnloadPort.Location = New System.Drawing.Point(76, 128)
        Me.cbUnloadPort.MaxDropDownItems = 20
        Me.cbUnloadPort.Name = "cbUnloadPort"
        Me.cbUnloadPort.Size = New System.Drawing.Size(130, 20)
        Me.cbUnloadPort.TabIndex = 3
        '
        'cbLoadPort
        '
        Me.cbLoadPort.Location = New System.Drawing.Point(76, 80)
        Me.cbLoadPort.MaxDropDownItems = 20
        Me.cbLoadPort.Name = "cbLoadPort"
        Me.cbLoadPort.Size = New System.Drawing.Size(130, 20)
        Me.cbLoadPort.TabIndex = 1
        '
        'cbReceivePlace
        '
        Me.cbReceivePlace.Location = New System.Drawing.Point(76, 176)
        Me.cbReceivePlace.MaxDropDownItems = 20
        Me.cbReceivePlace.Name = "cbReceivePlace"
        Me.cbReceivePlace.Size = New System.Drawing.Size(130, 20)
        Me.cbReceivePlace.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(2, 178)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 18)
        Me.Label20.TabIndex = 764
        Me.Label20.Text = "收货地"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(2, 82)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 18)
        Me.Label24.TabIndex = 765
        Me.Label24.Text = "装货港"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(2, 130)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(72, 18)
        Me.Label32.TabIndex = 763
        Me.Label32.Text = "卸货港"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(422, 200)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(72, 18)
        Me.Label34.TabIndex = 762
        Me.Label34.Text = "危险品标签"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDANGER_MARK
        '
        Me.txtDANGER_MARK.Location = New System.Drawing.Point(496, 198)
        Me.txtDANGER_MARK.MaxLength = 10
        Me.txtDANGER_MARK.Name = "txtDANGER_MARK"
        Me.txtDANGER_MARK.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_MARK.TabIndex = 24
        Me.txtDANGER_MARK.Text = ""
        '
        'txtPIECE_WEIGHT
        '
        Me.txtPIECE_WEIGHT.Location = New System.Drawing.Point(496, 54)
        Me.txtPIECE_WEIGHT.MaxLength = 20
        Me.txtPIECE_WEIGHT.Name = "txtPIECE_WEIGHT"
        Me.txtPIECE_WEIGHT.TabIndex = 17
        Me.txtPIECE_WEIGHT.Text = ""
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(422, 56)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 18)
        Me.Label16.TabIndex = 760
        Me.Label16.Text = "件重"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(212, 200)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 18)
        Me.Label15.TabIndex = 755
        Me.Label15.Text = "包装"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(286, 246)
        Me.txtAmount.MaxLength = 20
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(130, 21)
        Me.txtAmount.TabIndex = 14
        Me.txtAmount.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(212, 248)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 751
        Me.Label10.Text = "总件数"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSIZE_MEASURE
        '
        Me.txtSIZE_MEASURE.Location = New System.Drawing.Point(496, 78)
        Me.txtSIZE_MEASURE.MaxLength = 20
        Me.txtSIZE_MEASURE.Name = "txtSIZE_MEASURE"
        Me.txtSIZE_MEASURE.TabIndex = 18
        Me.txtSIZE_MEASURE.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(422, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 747
        Me.Label5.Text = "体积尺寸"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCONTAINER
        '
        Me.txtCONTAINER.Location = New System.Drawing.Point(286, 222)
        Me.txtCONTAINER.MaxLength = 20
        Me.txtCONTAINER.Name = "txtCONTAINER"
        Me.txtCONTAINER.ReadOnly = True
        Me.txtCONTAINER.Size = New System.Drawing.Size(130, 21)
        Me.txtCONTAINER.TabIndex = 31
        Me.txtCONTAINER.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(212, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 746
        Me.Label3.Text = "集装箱数"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGROSS_WEIGHT
        '
        Me.txtGROSS_WEIGHT.Location = New System.Drawing.Point(496, 6)
        Me.txtGROSS_WEIGHT.MaxLength = 20
        Me.txtGROSS_WEIGHT.Name = "txtGROSS_WEIGHT"
        Me.txtGROSS_WEIGHT.TabIndex = 15
        Me.txtGROSS_WEIGHT.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(422, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 743
        Me.Label1.Text = "毛重"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNETWEIGHT
        '
        Me.txtNETWEIGHT.Location = New System.Drawing.Point(496, 30)
        Me.txtNETWEIGHT.MaxLength = 20
        Me.txtNETWEIGHT.Name = "txtNETWEIGHT"
        Me.txtNETWEIGHT.TabIndex = 16
        Me.txtNETWEIGHT.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(422, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 742
        Me.Label2.Text = "净重"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(422, 152)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 18)
        Me.Label26.TabIndex = 756
        Me.Label26.Text = "危险品编号"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(422, 176)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 18)
        Me.Label27.TabIndex = 758
        Me.Label27.Text = "危险品页号"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDANGER_GRADE
        '
        Me.txtDANGER_GRADE.Location = New System.Drawing.Point(496, 126)
        Me.txtDANGER_GRADE.MaxLength = 10
        Me.txtDANGER_GRADE.Name = "txtDANGER_GRADE"
        Me.txtDANGER_GRADE.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_GRADE.TabIndex = 21
        Me.txtDANGER_GRADE.Text = ""
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(422, 128)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(72, 18)
        Me.Label30.TabIndex = 745
        Me.Label30.Text = "危险品等级"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDANGER_NO
        '
        Me.txtDANGER_NO.Location = New System.Drawing.Point(496, 150)
        Me.txtDANGER_NO.MaxLength = 10
        Me.txtDANGER_NO.Name = "txtDANGER_NO"
        Me.txtDANGER_NO.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_NO.TabIndex = 22
        Me.txtDANGER_NO.Text = ""
        '
        'txtDANGER_PAGENO
        '
        Me.txtDANGER_PAGENO.Location = New System.Drawing.Point(496, 174)
        Me.txtDANGER_PAGENO.MaxLength = 20
        Me.txtDANGER_PAGENO.Name = "txtDANGER_PAGENO"
        Me.txtDANGER_PAGENO.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_PAGENO.TabIndex = 23
        Me.txtDANGER_PAGENO.Text = ""
        '
        'txtREFRIGERATE_TEMPERATURE
        '
        Me.txtREFRIGERATE_TEMPERATURE.Location = New System.Drawing.Point(496, 102)
        Me.txtREFRIGERATE_TEMPERATURE.MaxLength = 20
        Me.txtREFRIGERATE_TEMPERATURE.Name = "txtREFRIGERATE_TEMPERATURE"
        Me.txtREFRIGERATE_TEMPERATURE.Size = New System.Drawing.Size(82, 21)
        Me.txtREFRIGERATE_TEMPERATURE.TabIndex = 19
        Me.txtREFRIGERATE_TEMPERATURE.Text = ""
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(422, 104)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(72, 18)
        Me.Label31.TabIndex = 753
        Me.Label31.Text = "冷冻温度"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbEMPTY_MARK
        '
        Me.cbEMPTY_MARK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEMPTY_MARK.ItemHeight = 12
        Me.cbEMPTY_MARK.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbEMPTY_MARK.Location = New System.Drawing.Point(76, 224)
        Me.cbEMPTY_MARK.Name = "cbEMPTY_MARK"
        Me.cbEMPTY_MARK.Size = New System.Drawing.Size(130, 20)
        Me.cbEMPTY_MARK.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(2, 226)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 18)
        Me.Label18.TabIndex = 761
        Me.Label18.Text = "空箱单标识"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpLoadDate
        '
        Me.dtpLoadDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLoadDate.Location = New System.Drawing.Point(286, 8)
        Me.dtpLoadDate.Name = "dtpLoadDate"
        Me.dtpLoadDate.Size = New System.Drawing.Size(130, 21)
        Me.dtpLoadDate.TabIndex = 9
        Me.dtpLoadDate.Value = New Date(2004, 7, 17, 15, 37, 55, 144)
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(212, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 18)
        Me.Label14.TabIndex = 754
        Me.Label14.Text = "装货日期"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(286, 30)
        Me.txtMark.MaxLength = 35
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(130, 21)
        Me.txtMark.TabIndex = 10
        Me.txtMark.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(212, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 750
        Me.Label9.Text = "标志"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbCONTAINER_MARK
        '
        Me.cbCONTAINER_MARK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCONTAINER_MARK.ItemHeight = 12
        Me.cbCONTAINER_MARK.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbCONTAINER_MARK.Location = New System.Drawing.Point(76, 248)
        Me.cbCONTAINER_MARK.Name = "cbCONTAINER_MARK"
        Me.cbCONTAINER_MARK.Size = New System.Drawing.Size(130, 20)
        Me.cbCONTAINER_MARK.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(2, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 749
        Me.Label6.Text = "整拼箱标记"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBillNO
        '
        Me.txtBillNO.Location = New System.Drawing.Point(76, 56)
        Me.txtBillNO.MaxLength = 120
        Me.txtBillNO.Name = "txtBillNO"
        Me.txtBillNO.Size = New System.Drawing.Size(130, 21)
        Me.txtBillNO.TabIndex = 0
        Me.txtBillNO.Text = ""
        '
        'Label4
        '
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(2, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 748
        Me.Label4.Text = "提单号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(0, 4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 741
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(212, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 18)
        Me.Label7.TabIndex = 759
        Me.Label7.Text = "货物中文描述"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGOODS_CHA
        '
        Me.txtGOODS_CHA.Location = New System.Drawing.Point(216, 74)
        Me.txtGOODS_CHA.MaxLength = 100
        Me.txtGOODS_CHA.Multiline = True
        Me.txtGOODS_CHA.Name = "txtGOODS_CHA"
        Me.txtGOODS_CHA.Size = New System.Drawing.Size(200, 48)
        Me.txtGOODS_CHA.TabIndex = 11
        Me.txtGOODS_CHA.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(212, 126)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 18)
        Me.Label8.TabIndex = 757
        Me.Label8.Text = "货物英文描述"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGOODS_ENG
        '
        Me.txtGOODS_ENG.Location = New System.Drawing.Point(216, 146)
        Me.txtGOODS_ENG.MaxLength = 200
        Me.txtGOODS_ENG.Multiline = True
        Me.txtGOODS_ENG.Name = "txtGOODS_ENG"
        Me.txtGOODS_ENG.Size = New System.Drawing.Size(200, 48)
        Me.txtGOODS_ENG.TabIndex = 12
        Me.txtGOODS_ENG.Text = ""
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(422, 248)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(72, 18)
        Me.Label28.TabIndex = 752
        Me.Label28.Text = "通知方"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNOTIFY_PERSON
        '
        Me.txtNOTIFY_PERSON.Location = New System.Drawing.Point(496, 246)
        Me.txtNOTIFY_PERSON.MaxLength = 30
        Me.txtNOTIFY_PERSON.Name = "txtNOTIFY_PERSON"
        Me.txtNOTIFY_PERSON.Size = New System.Drawing.Size(130, 21)
        Me.txtNOTIFY_PERSON.TabIndex = 26
        Me.txtNOTIFY_PERSON.Text = ""
        '
        'txtRECEIVER
        '
        Me.txtRECEIVER.Location = New System.Drawing.Point(496, 222)
        Me.txtRECEIVER.MaxLength = 30
        Me.txtRECEIVER.Name = "txtRECEIVER"
        Me.txtRECEIVER.Size = New System.Drawing.Size(130, 21)
        Me.txtRECEIVER.TabIndex = 25
        Me.txtRECEIVER.Text = ""
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(422, 224)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(72, 18)
        Me.Label33.TabIndex = 744
        Me.Label33.Text = "受货人"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C1DBG
        '
        Me.C1DBG.AllowAddNew = True
        Me.C1DBG.AllowDelete = True
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 274)
        Me.C1DBG.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.RecordSelectorWidth = 17
        Me.C1DBG.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1DBG.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG.RowHeight = 16
        Me.C1DBG.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG.Size = New System.Drawing.Size(634, 232)
        Me.C1DBG.TabIndex = 27
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Back" & _
        "Color:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSele" & _
        "ctorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><ClientRect>0, 0, 630, 228</ClientRect><BorderSide>0</BorderSide><CaptionSt" & _
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
        ">1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth><" & _
        "ClientArea>0, 0, 630, 228</ClientArea><PrintPageHeaderStyle parent="""" me=""Style1" & _
        "4"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(116, 514)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(65, 24)
        Me.btnDelete.TabIndex = 28
        Me.btnDelete.Text = "箱删除"
        '
        'FrmConLoadFinalNew_Edit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(634, 545)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtShipName)
        Me.Controls.Add(Me.txtVoyage)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.cbUnloadPortEng)
        Me.Controls.Add(Me.cbLoadPortEng)
        Me.Controls.Add(Me.cbReceivePlaceEng)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbTempUnit)
        Me.Controls.Add(Me.cbPack)
        Me.Controls.Add(Me.cbUnloadPort)
        Me.Controls.Add(Me.cbLoadPort)
        Me.Controls.Add(Me.cbReceivePlace)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.txtDANGER_MARK)
        Me.Controls.Add(Me.txtPIECE_WEIGHT)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSIZE_MEASURE)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCONTAINER)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtGROSS_WEIGHT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNETWEIGHT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.txtDANGER_GRADE)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.txtDANGER_NO)
        Me.Controls.Add(Me.txtDANGER_PAGENO)
        Me.Controls.Add(Me.txtREFRIGERATE_TEMPERATURE)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.cbEMPTY_MARK)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.dtpLoadDate)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtMark)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbCONTAINER_MARK)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBillNO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtGOODS_CHA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtGOODS_ENG)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.txtNOTIFY_PERSON)
        Me.Controls.Add(Me.txtRECEIVER)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.C1DBG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConLoadFinalNew_Edit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "出口舱单信息 修改"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As New DataSet
    Dim sqlda As New SqlClient.SqlDataAdapter
    Dim adContainer As New SqlClient.SqlDataAdapter
    Dim dsContainer As New DataSet

    Dim dvLoadPort As New DataView
    Dim dvUnloadPort As New DataView
    Dim dvReceivePlace As New DataView
    Dim dvPack As New DataView
    Dim Mark1 As Boolean

    Dim strPinContainerNo(500) As String
    Dim max As Short = -1
    Dim sqlCondition As String
    Dim strFirstConNo(2500) As String
    Dim Amount As Short = -1

    Dim id(500), ship(500), consize(500), sum(500) As String
    Dim weight(500), volume(500) As String
    Dim containerno(500), conType(500), overheight(500), fullorempty(500), sealno(500), bayno(500), manufactno(500), manufact(500), keepercode(500), keeper(500), position(500), passmark(500), shortunload(500), unloadmark(500), user(500) As String
    Dim t As Short = -1
    Dim Count, delSum As Integer
    Public blSave As Boolean

    Private Sub FrmConLoadFinalNew_Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView
        Dim sqlstr As String
        Dim dwCodeGoods As New DataView
        Dim sqlCodeGoods, sqlEmptyMark, sqlContainerMark As String
        Dim dwEmptyMark As New DataView
        Dim dwContainerMark As New DataView
        Dim sqlCondition As String

        sqlContainerMark = "SELECT EFL_Code, EFL_Name FROM Code_ConEFLType"
        dwContainerMark = Filldata(sqlContainerMark)
        Me.cbCONTAINER_MARK.DataSource = dwContainerMark
        Me.cbCONTAINER_MARK.DisplayMember = "EFL_Name"
        Me.cbCONTAINER_MARK.ValueMember = "EFL_Code"

        sqlEmptyMark = "SELECT EFL_Code, EFL_Name FROM Code_ConEFLType"
        dwEmptyMark = Filldata(sqlEmptyMark)
        Me.cbEMPTY_MARK.DataSource = dwEmptyMark
        Me.cbEMPTY_MARK.DisplayMember = "EFL_Name"
        Me.cbEMPTY_MARK.ValueMember = "EFL_Code"

        Dim strPort, strPack As String
        strPort = "SELECT CODE_PORT, PORT_CHA, PORT_ENG FROM CODE_PORT ORDER BY PORT_ENG"
        strPack = "SELECT CODE_PACK, PACK_CHA, PACK_ENG FROM CODE_PACK ORDER BY CODE_PACK"
        dvLoadPort = Filldata(strPort)
        dvUnloadPort = Filldata(strPort)
        dvReceivePlace = Filldata(strPort)
        dvPack = Filldata(strPack)
        Me.cbLoadPort.DataSource = dvLoadPort
        Me.cbLoadPort.DisplayMember = "PORT_CHA"
        Me.cbLoadPort.ValueMember = "CODE_PORT"
        Me.cbUnloadPort.DataSource = dvUnloadPort
        Me.cbUnloadPort.DisplayMember = "PORT_CHA"
        Me.cbUnloadPort.ValueMember = "CODE_PORT"
        Me.cbReceivePlace.DataSource = dvReceivePlace
        Me.cbReceivePlace.DisplayMember = "PORT_CHA"
        Me.cbReceivePlace.ValueMember = "CODE_PORT"
        Me.cbPack.DataSource = dvPack
        Me.cbPack.ValueMember = "PACK_CHA"
        Me.cbPack.ValueMember = "CODE_PACK"

        Me.cbLoadPortEng.DataSource = dvLoadPort
        Me.cbLoadPortEng.DisplayMember = "PORT_ENG"
        Me.cbLoadPortEng.ValueMember = "CODE_PORT"
        Me.cbUnloadPortEng.DataSource = dvUnloadPort
        Me.cbUnloadPortEng.DisplayMember = "PORT_ENG"
        Me.cbUnloadPortEng.ValueMember = "CODE_PORT"
        Me.cbReceivePlaceEng.DataSource = dvReceivePlace
        Me.cbReceivePlaceEng.DisplayMember = "PORT_ENG"
        Me.cbReceivePlaceEng.ValueMember = "CODE_PORT"

        sqlstr = "SELECT * FROM CON_HATCH_LIST WHERE SHIP_ID = '" & Ship_ID & "' AND BLNO = '" & FrmConLoadFinalNew.strBill & "'"
        dw = Updatedata(sqlda, sqlstr, ds)


        If dw.Count > 0 Then
            'Dim sqlGetShipVoyage As String
            'Dim dvGetShipVoyage As New DataView
            'sqlGetShipVoyage = "SELECT ENG_VESSEL, CHI_VESSEL, VOYAGE FROM SSHIP WHERE (SHIP_ID = '" & Ship_ID & "')"
            'dvGetShipVoyage = Filldata(sqlGetShipVoyage)
            'If dvGetShipVoyage.Count > 0 Then
            '    Me.txtShipName.Text = dvGetShipVoyage(0)("CHI_VESSEL")
            '    Me.txtVoyage.Text = dvGetShipVoyage(0)("VOYAGE")
            'End If
            Me.txtShipName.Text = FrmConLoadFinalNew.strShipName
            Me.txtVoyage.Text = FrmConLoadFinalNew.strVoyage

            txtID.Text = ds.Tables(0).Rows(0).Item("CON_HATCH_LIST_ID")
            txtBillNO.Text = ds.Tables(0).Rows(0).Item("BLNO")
            dtpLoadDate.Value = ds.Tables(0).Rows(0).Item("LOAD_DATE")
            cbEMPTY_MARK.SelectedValue = ds.Tables(0).Rows(0).Item("EMPTY_MARK")
            txtMark.Text = ds.Tables(0).Rows(0).Item("MARK")
            txtGOODS_ENG.Text = ds.Tables(0).Rows(0).Item("GOODS_ENG")
            txtGOODS_CHA.Text = ds.Tables(0).Rows(0).Item("GOODS_CHA")
            cbCONTAINER_MARK.SelectedValue = ds.Tables(0).Rows(0).Item("CONTAINER_MARK")

            Me.cbLoadPort.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_LOAD_PORT")
            Me.cbUnloadPort.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT")
            Me.cbReceivePlace.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_PLACE_RECEIVE")
            Me.cbPack.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_PACK")

            If Not IsDBNull(ds.Tables(0).Rows(0).Item("TEMPERATURE")) Then
                Me.cbTempUnit.Text = ds.Tables(0).Rows(0).Item("TEMPERATURE")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("CONTAINER")) Then
                txtCONTAINER.Text = ds.Tables(0).Rows(0).Item("CONTAINER")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("AMOUNT")) Then
                txtAmount.Text = ds.Tables(0).Rows(0).Item("AMOUNT")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("PIECE_WEIGHT")) Then
                txtPIECE_WEIGHT.Text = ds.Tables(0).Rows(0).Item("PIECE_WEIGHT")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("NETWEIGHT")) Then
                txtNETWEIGHT.Text = ds.Tables(0).Rows(0).Item("NETWEIGHT")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("GROSS_WEIGHT")) Then
                txtGROSS_WEIGHT.Text = ds.Tables(0).Rows(0).Item("GROSS_WEIGHT")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("SIZE_MEASURE")) Then
                txtSIZE_MEASURE.Text = ds.Tables(0).Rows(0).Item("SIZE_MEASURE")
            End If
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("REFRIGERATE_TEMPERATURE")) Then
                txtREFRIGERATE_TEMPERATURE.Text = ds.Tables(0).Rows(0).Item("REFRIGERATE_TEMPERATURE")
            End If
            txtRECEIVER.Text = ds.Tables(0).Rows(0).Item("RECEIVER")
            txtNOTIFY_PERSON.Text = ds.Tables(0).Rows(0).Item("NOTIFY_PERSON")
            txtDANGER_GRADE.Text = ds.Tables(0).Rows(0).Item("DANGER_GRADE")
            txtDANGER_NO.Text = ds.Tables(0).Rows(0).Item("DANGER_NO")
            If Not IsDBNull(ds.Tables(0).Rows(0).Item("DANGER_PAGENO")) Then
                txtDANGER_PAGENO.Text = ds.Tables(0).Rows(0).Item("DANGER_PAGENO")
            End If
            txtDANGER_MARK.Text = ds.Tables(0).Rows(0).Item("DANGER_MARK")

            If Me.cbLoadPort.SelectedValue Is Nothing Then
                cbLoadPort.Text = ds.Tables(0).Rows(0).Item("CODE_LOAD_PORT")
            End If
            If Me.cbUnloadPort.SelectedValue Is Nothing Then
                cbUnloadPort.Text = ds.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT")
            End If
            If Me.cbReceivePlace.SelectedValue Is Nothing Then
                Me.cbReceivePlace.Text = ds.Tables(0).Rows(0).Item("CODE_PLACE_RECEIVE")
            End If
        End If

        sqlCondition = " CON_HATCH_CARGO.SHIP_ID =  '" & Ship_ID & "' AND CON_HATCH_CARGO.BLNO = '" & FrmConLoadFinalNew.strBill & "'"
        'Dim sqlCondition As String = " SHIP_ID =  '" & Ship_ID & "' AND Expr1 = '" & FrmConHatchCargo.Bill_ID & "' AND Expr2 = '" & FrmConHatchCargo.Mark_ID & "'"
        InitSubTable(sqlCondition)     '初始化子表c1grid

        Amount = dsContainer.Tables(0).Rows.Count
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
            Me.C1DBG.Splits(0).DisplayColumns.Item("USER_CODE").Visible = False

            Me.C1DBG.Splits(0).DisplayColumns.Item("Code_MANUFACTURER").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("MANUFACTURER").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("KEEPER").Visible = False

            'Me.C1DBG.Splits(0).DisplayColumns.Item("AMOUNT").Visible = False
            'Me.C1DBG.Splits(0).DisplayColumns.Item("WEIGHT").Visible = False
            'Me.C1DBG.Splits(0).DisplayColumns.Item("VOLUME").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("Unload_Mark").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("BAYNO").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("OVER_HEIGHT").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("SealCheck").Visible = False

            Me.C1DBG.Columns.Item("CONTAINER_NO").Caption = "集装箱号"
            Me.C1DBG.Columns.Item("SIZE_CON").Caption = "箱尺寸"
            Me.C1DBG.Columns.Item("CONTAINER_TYPE").Caption = "箱型"
            Me.C1DBG.Columns.Item("FULLOREMPTY").Caption = "箱状态"
            Me.C1DBG.Columns.Item("SEALNO").Caption = "铅封号"
            Me.C1DBG.Columns.Item("CODE_KEEPER").Caption = "箱经营人"
            'Me.C1DBG.Columns.Item("SealCheck").Caption = "查封"
            Me.C1DBG.Columns.Item("AMOUNT").Caption = "件数"
            Me.C1DBG.Columns.Item("WEIGHT").Caption = "重量"
            Me.C1DBG.Columns.Item("VOLUME").Caption = "体积"
            Me.C1DBG.Columns.Item("CODE_KEEPER").Caption = "箱经营人"
            Me.C1DBG.Columns.Item("ReeferTemp").Caption = "冷藏温度"
            Me.C1DBG.Columns.Item("TempUnit").Caption = "温标"
            Me.C1DBG.Columns.Item("DangerGrade").Caption = "危品等级"
            Me.C1DBG.Columns.Item("DangerMark").Caption = "危品标签"

            'Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Locked = True
            'Me.C1DBG.Splits(0).DisplayColumns("FULLOREMPTY").Locked = True

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
        Dim sqla As New SqlClient.SqlDataAdapter
        Dim sqlc As New SqlClient.SqlCommand
        Dim dsItem As New DataSet
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
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = dsItem.Tables(0).Rows(i)("EFL_Name")
                vi.Value = dsItem.Tables(0).Rows(i)("EFL_Code")
                Me.C1DBG.Columns.Item("FULLOREMPTY").ValueItems.Values.Add(vi)
            Next

            Me.C1DBG.Columns("OVER_HEIGHT").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("OVER_HEIGHT").ValueItems.Translate = True

            Dim vi2 As New C1.Win.C1TrueDBGrid.ValueItem
            vi2.DisplayValue = "正常"
            vi2.Value = "0"
            Me.C1DBG.Columns.Item("OVER_HEIGHT").ValueItems.Values.Add(vi2)
            Dim vi1 As New C1.Win.C1TrueDBGrid.ValueItem
            vi1.DisplayValue = "超高"
            vi1.Value = "1"
            Me.C1DBG.Columns.Item("OVER_HEIGHT").ValueItems.Values.Add(vi1)

            Dim sqlConKind As String = "SELECT CODE_CON_KIND, CON_KIND_ENG FROM CODE_CON_KIND ORDER BY CODE_CON_KIND"
            Dim dvConKind As New DataView
            dvConKind = Filldata(sqlConKind)
            Me.C1DBG.Columns("CONTAINER_TYPE").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("CONTAINER_TYPE").ValueItems.Translate = True
            For i = 0 To dvConKind.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = dvConKind(i)("CON_KIND_ENG")
                vi.Value = dvConKind(i)("CODE_CON_KIND")
                Me.C1DBG.Columns.Item("CONTAINER_TYPE").ValueItems.Values.Add(vi)
            Next

            Dim sqlKeeper, sqlCompany As String
            Dim dvKeeper As New DataView
            Dim dvCompany As New DataView
            sqlKeeper = "SELECT Code_Con_Company, Con_Company_CHI, Con_Company_ENG FROM Code_Con_Company ORDER BY Con_Company_CHI"
            sqlCompany = "SELECT Code_Con_Company, Con_Company_CHI, Con_Company_ENG FROM Code_Con_Company ORDER BY Con_Company_CHI"
            dvKeeper = Filldata(sqlKeeper)
            dvCompany = Filldata(sqlCompany)
            Me.C1DBG.Columns("CODE_KEEPER").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("CODE_KEEPER").ValueItems.Translate = True
            Me.C1DBG.Columns("Code_MANUFACTURER").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("Code_MANUFACTURER").ValueItems.Translate = True
            For i = 0 To dvKeeper.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = dvKeeper(i)("Con_Company_CHI")
                vi.Value = dvKeeper(i)("Code_Con_Company")
                Me.C1DBG.Columns.Item("CODE_KEEPER").ValueItems.Values.Add(vi)
            Next
            For i = 0 To dvCompany.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
                vi.DisplayValue = dvCompany(i)("Con_Company_CHI")
                vi.Value = dvCompany(i)("Code_Con_Company")
                Me.C1DBG.Columns.Item("Code_MANUFACTURER").ValueItems.Values.Add(vi)
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

            Me.C1DBG.Splits(0).DisplayColumns("SIZE_CON").Width = 35
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_TYPE").Width = 35
            Me.C1DBG.Splits(0).DisplayColumns("FULLOREMPTY").Width = 35

            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Width = 85
            Me.C1DBG.Splits(0).DisplayColumns("SEALNO").Width = 90
            Me.C1DBG.Splits(0).DisplayColumns("CODE_KEEPER").Width = 100
            Me.C1DBG.Splits(0).DisplayColumns("Code_MANUFACTURER").Width = 100
            Me.C1DBG.Splits(0).DisplayColumns("ReeferTemp").Width = 40
            Me.C1DBG.Splits(0).DisplayColumns("TempUnit").Width = 40
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
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

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        txtGOODS_CHA.Text = txtGOODS_CHA.Text.Trim()
        txtGOODS_CHA.Text = TrimReturn(txtGOODS_CHA.Text)
        txtGOODS_ENG.Text = txtGOODS_ENG.Text.Trim()
        txtGOODS_ENG.Text = TrimReturn(txtGOODS_ENG.Text)
        Try
            If Trim(Me.txtBillNO.Text) <> "" Then

                If Me.SetNumValue("AMOUNT", txtAmount.Text, "件数") = False Then
                    txtAmount.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("GROSS_WEIGHT", txtGROSS_WEIGHT.Text, "总毛重") = False Then
                    Me.txtGROSS_WEIGHT.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("NETWEIGHT", txtNETWEIGHT.Text, "总净重") = False Then
                    Me.txtNETWEIGHT.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("PIECE_WEIGHT", Me.txtPIECE_WEIGHT.Text, "件重") = False Then
                    Me.txtPIECE_WEIGHT.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("SIZE_MEASURE", Me.txtSIZE_MEASURE.Text, "体积尺寸") = False Then
                    Me.txtSIZE_MEASURE.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("REFRIGERATE_TEMPERATURE", Me.txtREFRIGERATE_TEMPERATURE.Text, "冷藏温度") = False Then
                    Me.txtREFRIGERATE_TEMPERATURE.Focus()
                    Exit Sub
                End If

                If Not IsNothing(Me.cbLoadPort.SelectedValue) Then  '港口代码能取到
                    ds.Tables(0).Rows(0).Item("CODE_LOAD_PORT") = Me.cbLoadPort.SelectedValue
                    ds.Tables(0).Rows(0).Item("LOAD_PORT") = Me.dvLoadPort(Me.cbLoadPort.SelectedIndex)("PORT_ENG")
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
                    ds.Tables(0).Rows(0).Item("UNLOAD_PORT") = Me.dvUnloadPort(Me.cbUnloadPort.SelectedIndex)("PORT_ENG")
                Else
                    If IsCode(Me.cbUnloadPort.Text.Trim()) Then     '判断是代码的形式
                        ds.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT") = Trim(Me.cbUnloadPort.Text.ToUpper)
                    Else
                        MessageBox.Show("卸货港中文名不能取得时，必须输入港口代码才能保存。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.cbUnloadPort.Focus()
                        Exit Sub
                    End If
                End If
                If Not IsNothing(Me.cbReceivePlace.SelectedValue) Then  '港口代码能取到
                    ds.Tables(0).Rows(0).Item("CODE_PLACE_RECEIVE") = Me.cbReceivePlace.SelectedValue
                    ds.Tables(0).Rows(0).Item("PLACE_RECEIVE") = Me.dvReceivePlace(Me.cbReceivePlace.SelectedIndex)("PORT_ENG")
                Else
                    If IsCode(Me.cbReceivePlace.Text.Trim()) Then     '判断是代码的形式
                        ds.Tables(0).Rows(0).Item("CODE_PLACE_RECEIVE") = Trim(Me.cbReceivePlace.Text.ToUpper)
                    Else
                        MessageBox.Show("交货地中文名不能取得时，必须输入港口代码才能保存。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.cbReceivePlace.Focus()
                        Exit Sub
                    End If
                End If

                Dim sqlBillExist As String
                sqlBillExist = "SELECT BLNO FROM CON_HATCH_LIST WHERE SHIP_ID = '" & Ship_ID & "' AND BLNO = '" & Me.txtBillNO.Text & "'and BLNO <> '" & FrmConLoadFinalNew.strBill & "'"
                Dim dvBillExist As New DataView
                dvBillExist = Filldata(sqlBillExist)

                If dvBillExist.Count = 0 Then
                    ds.Tables(0).Rows(0).Item("BLNO") = Trim(Me.txtBillNO.Text).ToUpper
                    ds.Tables(0).Rows(0).Item("Mark") = Me.txtMark.Text.Trim
                    ds.Tables(0).Rows(0).Item("GOODS_CHA") = Me.txtGOODS_CHA.Text.Trim
                    ds.Tables(0).Rows(0).Item("GOODS_ENG") = Me.txtGOODS_ENG.Text.Trim
                    ds.Tables(0).Rows(0).Item("DANGER_GRADE") = Me.txtDANGER_GRADE.Text.Trim
                    ds.Tables(0).Rows(0).Item("DANGER_PAGENO") = Me.txtDANGER_PAGENO.Text.Trim
                    ds.Tables(0).Rows(0).Item("DANGER_NO") = Me.txtDANGER_NO.Text.Trim
                    ds.Tables(0).Rows(0).Item("DANGER_MARK") = Me.txtDANGER_MARK.Text.Trim
                    ds.Tables(0).Rows(0).Item("RECEIVER") = Me.txtRECEIVER.Text.Trim
                    ds.Tables(0).Rows(0).Item("NOTIFY_PERSON") = Me.txtNOTIFY_PERSON.Text.Trim

                    ds.Tables(0).Rows(0).Item("EMPTY_MARK") = Me.cbEMPTY_MARK.SelectedValue
                    ds.Tables(0).Rows(0).Item("CONTAINER_MARK") = Me.cbCONTAINER_MARK.SelectedValue
                    ds.Tables(0).Rows(0).Item("CODE_PACK") = Me.cbPack.SelectedValue
                    ds.Tables(0).Rows(0).Item("PACK") = Me.dvPack(Me.cbPack.SelectedIndex)("PACK_ENG")
                    ds.Tables(0).Rows(0).Item("TEMPERATURE") = Me.cbTempUnit.Text

                    ds.Tables(0).Rows(0).Item("LOAD_DATE") = Me.dtpLoadDate.Value

                    Call OperateSubTable()
                Else
                    Me.txtBillNO.Focus()
                    MessageBox.Show("同一船次 提单号不可重复", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                Me.txtBillNO.Focus()
                MessageBox.Show("提单号不可为空", "提示")
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

    Private Sub OperateSubTable()
        Dim sqlEditRelation, sqlInsertRelation, sqlDeleteRelation, sqlConExist, sqlBayExist, sqlBeing As String
        Dim strContainer, strSealNO, strBayNO, strConState As String
        Dim i, j As Short
        Dim dv As New DataView
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
                    If iConCheck = 1 Or iConCheck = 0 Then       '箱号没有通过检验时
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

                        sqlConExist = "SELECT * FROM CON_HATCH_RECORD where ship_id = '" & Ship_ID & "' and  container_no = '" & Me.C1DBG.Columns("CONTAINER_NO").CellText(i) & "' and fullorempty <> 'L' and container_no in (select con_hatch_cargo.container_no from con_hatch_cargo where  CON_HATCH_CARGO.SHIP_ID =  '" & Ship_ID & "' AND not (CON_HATCH_CARGO.BLNO = '" & FrmConLoadFinalNew.strBill & "'))"
                        '要判断该船次中 不属于现提单的 所有非拼箱的箱号或贝位号 是否与当前箱号贝位号重复
                        '非拼箱不可共享，要检查。拼箱可共享，不用检查
                        If Filldata(sqlConExist).Count > 0 Then
                            Me.C1DBG.Row = i
                            Me.C1DBG.SelectedRows.Clear()
                            Me.C1DBG.SelectedRows.Add(i)
                            MessageBox.Show("当前船次该集装箱号已存在，不能重复！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit For
                        Else
                            sqlConExist = "SELECT * FROM CON_HATCH_RECORD where ship_id = '" & Ship_ID & "' and  dbo.ConOtherMode(CONTAINER_NO) = '" & Me.C1DBG.Columns("CONTAINER_NO").CellText(i) & "' and fullorempty <> 'L' and dbo.ConOtherMode(CONTAINER_NO) in (select con_hatch_cargo.container_no from con_hatch_cargo where  CON_HATCH_CARGO.SHIP_ID =  '" & Ship_ID & "' AND not (CON_HATCH_CARGO.BLNO = '" & FrmConLoadFinalNew.strBill & "'))"
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
                    If Trim(Me.txtBillNO.Text) <> FrmConLoadFinalNew.strBill Then
                        sqlEditRelation = "update CON_HATCH_CARGO set BLNO = '" & Trim(Me.txtBillNO.Text) & "' where SHIP_ID = '" & Ship_ID & "' and BLNO = '" & FrmConLoadFinalNew.strBill & "' "
                        ExecSql(sqlEditRelation)    '原提单唛头已修改，更新所有的关系
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
                    blSave = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmConHatchCargo_Add_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If Me.txtBillNO.Focused Then
                Me.cbUnloadPort.Focus()
            ElseIf Me.cbLoadPort.Focused = True Then
                'Call cbLoadPort_TextChanged(sender, e)
                'If Mark1 = False Then
                '    Me.cbLoadPortEng.Text = ""
                'End If
                Me.cbLoadPortEng.Focus()
            ElseIf Me.cbLoadPortEng.Focused = True Then
                Me.cbUnloadPort.Focus()
            ElseIf Me.cbUnloadPort.Focused = True Then
                'Call cbUnloadPort_TextChanged(sender, e)
                'If Mark1 = False Then
                '    Me.cbUnloadPortEng.Text = ""
                'End If
                Me.cbUnloadPortEng.Focus()
            ElseIf Me.cbUnloadPortEng.Focused = True Then
                Me.cbReceivePlace.Focus()
            ElseIf Me.cbReceivePlace.Focused Then
                'Call cbDelivery_TextChanged(sender, e)
                'If Mark1 = False Then
                '    Me.cbReceivePlaceEng.Text = ""
                'End If
                Me.cbReceivePlaceEng.Focus()
            ElseIf Me.cbReceivePlaceEng.Focused = True Then
                Me.cbEMPTY_MARK.Focus()
            ElseIf Me.cbEMPTY_MARK.Focused = True Then
                Me.cbCONTAINER_MARK.Focus()
            ElseIf Me.cbCONTAINER_MARK.Focused = True Then
                Me.dtpLoadDate.Focus()
            ElseIf Me.dtpLoadDate.Focused Then
                Me.txtMark.Focus()
            ElseIf Me.txtMark.Focused Then
                Me.txtGOODS_CHA.Focus()
            ElseIf Me.txtGOODS_CHA.Focused Then
                Me.txtGOODS_ENG.Focus()
            ElseIf Me.txtGOODS_ENG.Focused Then
                Me.cbPack.Focus()
            ElseIf Me.cbPack.Focused Then
                Me.txtAmount.Focus()
            ElseIf Me.txtAmount.Focused Then
                Me.txtGROSS_WEIGHT.Focus()
            ElseIf Me.txtGROSS_WEIGHT.Focused Then
                Me.txtNETWEIGHT.Focus()
            ElseIf Me.txtNETWEIGHT.Focused Then
                Me.txtPIECE_WEIGHT.Focus()
            ElseIf Me.txtPIECE_WEIGHT.Focused Then
                Me.txtSIZE_MEASURE.Focus()
            ElseIf Me.txtSIZE_MEASURE.Focused Then
                Me.txtREFRIGERATE_TEMPERATURE.Focus()
            ElseIf Me.txtREFRIGERATE_TEMPERATURE.Focused Then
                Me.cbTempUnit.Focus()
            ElseIf Me.cbTempUnit.Focused Then
                Me.txtDANGER_GRADE.Focus()
            ElseIf Me.txtDANGER_GRADE.Focused Then
                Me.txtDANGER_NO.Focus()
            ElseIf Me.txtDANGER_NO.Focused Then
                Me.txtDANGER_PAGENO.Focus()
            ElseIf Me.txtDANGER_PAGENO.Focused Then
                Me.txtDANGER_MARK.Focus()
            ElseIf Me.txtDANGER_MARK.Focused Then
                Me.txtRECEIVER.Focus()
            ElseIf Me.txtRECEIVER.Focused Then
                Me.txtNOTIFY_PERSON.Focus()
            ElseIf Me.txtNOTIFY_PERSON.Focused Then
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
            'Dim sqlBeing As String
            'sqlBeing = "SELECT * FROM CON_CRITERION WHERE CONTAINER_NO = '" & Trim(Me.C1DBG.Columns("CONTAINER_NO").Text.ToUpper) & "' or CONTAINER_NO = '" & GetConOtherMode(Me.C1DBG.Columns("CONTAINER_NO").Text) & "'"
            'Dim dvBeing As New DataView
            'dvBeing = Filldata(sqlBeing)
            'If dvBeing.Count = 1 Then
            '    Me.C1DBG.Columns("SIZE_CON").Value = dvBeing.Item(0)("SIZE_CON")
            '    Me.C1DBG.Columns("CONTAINER_TYPE").Value = dvBeing.Item(0)("CONTAINER_TYPE")
            '    Me.C1DBG.Columns("CODE_KEEPER").Value = dvBeing.Item(0)("CODE_SHIP_OWNER")

            '    Me.C1DBG.Columns("KEEPER").Value = Me.C1DBG.Columns("CODE_KEEPER").Text
            'End If
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
                If dvLoadPort(i)("CODE_PORT") = Me.cbLoadPort.Text.ToUpper.Trim() Then
                    Me.cbLoadPort.SelectedValue = dvLoadPort(i)("CODE_PORT")
                    Mark1 = True
                    Exit For
                End If
            Next
            'For i = 0 To dvLoadPort.Count - 1
            '    If Not IsDBNull(dvLoadPort(i)("PORT_CHA")) Then
            '        If dvLoadPort(i)("CODE_PORT") Like Me.cbLoadPort.Text.ToUpper.Trim() & "*" Or dvLoadPort(i)("PORT_CHA") Like Me.cbLoadPort.Text.ToUpper.Trim() & "*" Then
            '            Me.cbLoadPort.SelectedValue = dvLoadPort(i)("CODE_PORT")
            '            Mark1 = True
            '            Exit For
            '        End If
            '    Else
            '        If dvLoadPort(i)("CODE_PORT") Like Me.cbLoadPort.Text.ToUpper.Trim() & "*" Then
            '            Me.cbLoadPort.SelectedValue = dvLoadPort(i)("CODE_PORT")
            '            Mark1 = True
            '            Exit For
            '        End If
            '    End If
            'Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbUnloadPort_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Mark1 = False
            Dim i As Integer
            For i = 0 To dvUnloadPort.Count - 1
                If dvUnloadPort(i)("CODE_PORT") = Me.cbUnloadPort.Text.ToUpper.Trim() Then
                    Me.cbUnloadPort.SelectedValue = dvUnloadPort(i)("CODE_PORT")
                    Mark1 = True
                    Exit For
                End If
            Next
            'For i = 0 To dvUnloadPort.Count - 1
            '    If Not IsDBNull(dvUnloadPort(i)("PORT_CHA")) Then
            '        If dvUnloadPort(i)("CODE_PORT") Like Me.cbUnloadPort.Text.ToUpper.Trim() & "*" Or dvUnloadPort(i)("PORT_CHA") Like Me.cbUnloadPort.Text.ToUpper.Trim() & "*" Then
            '            Me.cbUnloadPort.SelectedValue = dvUnloadPort(i)("CODE_PORT")
            '            Mark1 = True
            '            Exit For
            '        End If
            '    Else
            '        If dvUnloadPort(i)("CODE_PORT") Like Me.cbUnloadPort.Text.ToUpper.Trim() & "*" Then
            '            Me.cbUnloadPort.SelectedValue = dvUnloadPort(i)("CODE_PORT")
            '            Mark1 = True
            '            Exit For
            '        End If
            '    End If
            'Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbDelivery_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Mark1 = False
            Dim i As Integer
            For i = 0 To dvReceivePlace.Count - 1
                If dvReceivePlace(i)("CODE_PORT") = Me.cbReceivePlace.Text.Trim.ToUpper Then
                    Me.cbReceivePlace.SelectedValue = dvReceivePlace(i)("CODE_PORT")
                    Mark1 = True
                    Exit For
                End If
            Next
            'For i = 0 To dvReceivePlace.Count - 1
            '    If Not IsDBNull(dvReceivePlace(i)("PORT_CHA")) Then
            '        If dvReceivePlace(i)("CODE_PORT") Like Me.cbReceivePlace.Text.Trim.ToUpper & "*" Or dvReceivePlace(i)("PORT_CHA") Like Me.cbReceivePlace.Text.Trim.ToUpper & "*" Then
            '            Me.cbReceivePlace.SelectedValue = dvReceivePlace(i)("CODE_PORT")
            '            Mark1 = True
            '            Exit For
            '        End If
            '    Else
            '        If dvReceivePlace(i)("CODE_PORT") Like Me.cbReceivePlace.Text.Trim.ToUpper & "*" Then
            '            Me.cbReceivePlace.SelectedValue = dvReceivePlace(i)("CODE_PORT")
            '            Mark1 = True
            '            Exit For
            '        End If
            '    End If
            'Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function TrimReturn(ByVal str As String)  ' 去除回车换行符
        Dim i As Integer
        Dim ch As Char

        i = 0
        While i < str.Length - 1
            ch = str.Substring(i, 1)
            If ch.Equals(Chr(13)) Then
                str = String.Concat(str.Substring(0, i), str.Substring(i + 2))
            Else
                i += 1
            End If
        End While
        Return str
    End Function

    Private Sub txtGOODS_CHA_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGOODS_CHA.Leave
        txtGOODS_CHA.Text = txtGOODS_CHA.Text.Trim()
        txtGOODS_CHA.Text = TrimReturn(txtGOODS_CHA.Text)
    End Sub

    Private Sub txtGOODS_ENG_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGOODS_ENG.Leave
        txtGOODS_ENG.Text = txtGOODS_ENG.Text.Trim()
        txtGOODS_ENG.Text = TrimReturn(txtGOODS_ENG.Text)
    End Sub

    Private Sub txtBillNO_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBillNO.Leave
        txtBillNO.Text = txtBillNO.Text.Trim.ToUpper
        'Dim i As Integer
        'Me.C1DBG.Focus()
        'For i = 0 To dsContainer.Tables(0).Rows.Count - 1
        '    Me.C1DBG.Row = i
        '    Me.C1DBG.Columns("BLNO").Text = Me.txtBillNO.Text
        'Next
        'Me.btQuit.Focus()
        'Me.cbLoadPort.Focus()
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

    Private Sub DelSave()
        Dim sqlPin As String
        Dim dvPin As New DataView
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

    Private Sub C1DBG_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles C1DBG.RowColChange
        '当前做法要求对 c1grid控件 
        If e.LastCol = 2 And e.LastRow = Me.C1DBG.Row Then
            Dim sqlGetContainer As String = "SELECT CON_HATCH_RECORD_ID,SHIP_ID,CONTAINER_NO,SEALNO,SealCheck,SIZE_CON,CONTAINER_TYPE,OVER_HEIGHT,FULLOREMPTY,BAYNO,BLNO,CODE_GOODS,AMOUNT,WEIGHT,VOLUME,Code_MANUFACTURER,MANUFACTURER,CODE_KEEPER,KEEPER,ReeferTemp,TempUnit,DangerGrade,DangerMark,POSITION_CONTAINER,PASS_MARK,SHORT_UNLOAD,Unload_Mark,USER_NAME,USER_CODE " & _
                " FROM CON_HATCH_RECORD WHERE SHIP_ID = '" & Ship_ID & "' AND ( CONTAINER_NO = '" & Me.C1DBG.Columns("CONTAINER_NO").CellText(e.LastRow).Trim.ToUpper & "' or CONTAINER_NO = '" & GetConOtherMode(Me.C1DBG.Columns("CONTAINER_NO").CellText(e.LastRow)) & "') AND FULLOREMPTY = 'L'"
            Dim dvGetContainer As New DataView
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

    Private Sub txtReeferTemp_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtREFRIGERATE_TEMPERATURE.Leave
        If IsNumeric(txtREFRIGERATE_TEMPERATURE.Text) Then
            Me.cbTempUnit.SelectedIndex = 1
        Else
            Me.cbTempUnit.SelectedIndex = 0
        End If
    End Sub

    Private Sub cbLoadPort_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbLoadPort.Leave
        Try
            If Me.cbLoadPort.SelectedValue Is Nothing Then
                Dim i As Integer
                For i = 0 To dvLoadPort.Count - 1
                    If dvLoadPort(i)("CODE_PORT") Like "*" & Me.cbLoadPort.Text.ToUpper.Trim() & "*" Then
                        Me.cbLoadPort.SelectedValue = dvLoadPort(i)("CODE_PORT")
                        Exit For
                    End If
                Next
            End If
            If Me.cbLoadPort.SelectedValue Is Nothing Then
                Me.cbLoadPortEng.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbUnloadPort_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbUnloadPort.Leave
        Try
            If Me.cbUnloadPort.SelectedValue Is Nothing Then
                Dim i As Integer
                For i = 0 To dvUnloadPort.Count - 1
                    If dvUnloadPort(i)("CODE_PORT") Like "*" & Me.cbUnloadPort.Text.ToUpper.Trim() & "*" Then
                        Me.cbUnloadPort.SelectedValue = dvUnloadPort(i)("CODE_PORT")
                        Exit For
                    End If
                Next
            End If
            If Me.cbUnloadPort.SelectedValue Is Nothing Then
                Me.cbUnloadPortEng.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbReceivePlace_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbReceivePlace.Leave
        Try
            If Me.cbReceivePlace.SelectedValue Is Nothing Then
                Dim i As Integer
                For i = 0 To dvReceivePlace.Count - 1
                    If dvReceivePlace(i)("CODE_PORT") Like "*" & Me.cbReceivePlace.Text.ToUpper.Trim() & "*" Then
                        Me.cbReceivePlace.SelectedValue = dvReceivePlace(i)("CODE_PORT")
                        Exit For
                    End If
                Next
            End If
            If Me.cbReceivePlace.SelectedValue Is Nothing Then
                Me.cbReceivePlaceEng.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Private Sub cbLoadPortEng_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbLoadPortEng.Leave
    '    Try
    '        If Me.cbLoadPortEng.SelectedValue Is Nothing Then
    '            Dim i As Integer
    '            For i = 0 To dvLoadPort.Count - 1
    '                If dvLoadPort(i)("PORT_ENG") Like "*" & Me.cbLoadPortEng.Text.ToUpper.Trim() & "*" Then
    '                    Me.cbLoadPortEng.SelectedValue = dvLoadPort(i)("CODE_PORT")
    '                    Exit For
    '                End If
    '            Next
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    'Private Sub cbUnloadPortEng_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbUnloadPortEng.Leave
    '    Try
    '        If Me.cbUnloadPortEng.SelectedValue Is Nothing Then
    '            Dim i As Integer
    '            For i = 0 To dvUnloadPort.Count - 1
    '                If dvUnloadPort(i)("PORT_ENG") Like "*" & Me.cbUnloadPortEng.Text.ToUpper.Trim() & "*" Then
    '                    Me.cbUnloadPortEng.SelectedValue = dvUnloadPort(i)("CODE_PORT")
    '                    Exit For
    '                End If
    '            Next
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    'Private Sub cbReceivePlaceEng_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbReceivePlaceEng.Leave
    '    Try
    '        If Me.cbReceivePlaceEng.SelectedValue Is Nothing Then
    '            Dim i As Integer
    '            For i = 0 To dvReceivePlace.Count - 1
    '                If dvReceivePlace(i)("PORT_ENG") Like "*" & Me.cbReceivePlaceEng.Text.ToUpper.Trim() & "*" Then
    '                    Me.cbReceivePlaceEng.SelectedValue = dvReceivePlace(i)("CODE_PORT")
    '                    Exit For
    '                End If
    '            Next
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub
End Class
