Imports TALLY.DBControl
Public Class FrmConLoadFinalNew_Add
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
    Friend WithEvents C1DBGOG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConLoadFinalNew_Add))
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtShipName = New System.Windows.Forms.TextBox
        Me.txtVoyage = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
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
        Me.C1DBGOG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.btAdd = New System.Windows.Forms.Button
        Me.btnCommit = New System.Windows.Forms.Button
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DBGOG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(2, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 18)
        Me.Label12.TabIndex = 844
        Me.Label12.Text = "中文船名"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtShipName
        '
        Me.txtShipName.Location = New System.Drawing.Point(76, 6)
        Me.txtShipName.MaxLength = 40
        Me.txtShipName.Name = "txtShipName"
        Me.txtShipName.ReadOnly = True
        Me.txtShipName.Size = New System.Drawing.Size(130, 21)
        Me.txtShipName.TabIndex = 843
        Me.txtShipName.Text = ""
        '
        'txtVoyage
        '
        Me.txtVoyage.Location = New System.Drawing.Point(76, 30)
        Me.txtVoyage.MaxLength = 6
        Me.txtVoyage.Name = "txtVoyage"
        Me.txtVoyage.ReadOnly = True
        Me.txtVoyage.Size = New System.Drawing.Size(130, 21)
        Me.txtVoyage.TabIndex = 841
        Me.txtVoyage.Text = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(2, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 18)
        Me.Label13.TabIndex = 842
        Me.Label13.Text = "航次"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbUnloadPortEng
        '
        Me.cbUnloadPortEng.Location = New System.Drawing.Point(76, 150)
        Me.cbUnloadPortEng.MaxDropDownItems = 20
        Me.cbUnloadPortEng.Name = "cbUnloadPortEng"
        Me.cbUnloadPortEng.Size = New System.Drawing.Size(130, 20)
        Me.cbUnloadPortEng.TabIndex = 4
        '
        'cbLoadPortEng
        '
        Me.cbLoadPortEng.Location = New System.Drawing.Point(76, 102)
        Me.cbLoadPortEng.MaxDropDownItems = 20
        Me.cbLoadPortEng.Name = "cbLoadPortEng"
        Me.cbLoadPortEng.Size = New System.Drawing.Size(130, 20)
        Me.cbLoadPortEng.TabIndex = 2
        '
        'cbReceivePlaceEng
        '
        Me.cbReceivePlaceEng.Location = New System.Drawing.Point(76, 198)
        Me.cbReceivePlaceEng.MaxDropDownItems = 20
        Me.cbReceivePlaceEng.Name = "cbReceivePlaceEng"
        Me.cbReceivePlaceEng.Size = New System.Drawing.Size(130, 20)
        Me.cbReceivePlaceEng.TabIndex = 6
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(2, 200)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 18)
        Me.Label21.TabIndex = 839
        Me.Label21.Text = "收货地英文"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(2, 152)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 18)
        Me.Label22.TabIndex = 840
        Me.Label22.Text = "卸货港英文"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(2, 104)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 18)
        Me.Label23.TabIndex = 838
        Me.Label23.Text = "装货港英文"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(596, 54)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(30, 20)
        Me.Label37.TabIndex = 837
        Me.Label37.Text = "公斤"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(596, 30)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(30, 20)
        Me.Label36.TabIndex = 836
        Me.Label36.Text = "公斤"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(596, 6)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(30, 20)
        Me.Label35.TabIndex = 835
        Me.Label35.Text = "公斤"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(596, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 20)
        Me.Label11.TabIndex = 834
        Me.Label11.Text = "立方"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbTempUnit
        '
        Me.cbTempUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTempUnit.ItemHeight = 12
        Me.cbTempUnit.Items.AddRange(New Object() {"", "C", "F"})
        Me.cbTempUnit.Location = New System.Drawing.Point(578, 100)
        Me.cbTempUnit.Name = "cbTempUnit"
        Me.cbTempUnit.Size = New System.Drawing.Size(48, 20)
        Me.cbTempUnit.TabIndex = 20
        '
        'cbPack
        '
        Me.cbPack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPack.ItemHeight = 12
        Me.cbPack.Location = New System.Drawing.Point(286, 196)
        Me.cbPack.MaxDropDownItems = 20
        Me.cbPack.Name = "cbPack"
        Me.cbPack.Size = New System.Drawing.Size(130, 20)
        Me.cbPack.TabIndex = 13
        '
        'cbUnloadPort
        '
        Me.cbUnloadPort.Location = New System.Drawing.Point(76, 126)
        Me.cbUnloadPort.MaxDropDownItems = 20
        Me.cbUnloadPort.Name = "cbUnloadPort"
        Me.cbUnloadPort.Size = New System.Drawing.Size(130, 20)
        Me.cbUnloadPort.TabIndex = 3
        '
        'cbLoadPort
        '
        Me.cbLoadPort.Location = New System.Drawing.Point(76, 78)
        Me.cbLoadPort.MaxDropDownItems = 20
        Me.cbLoadPort.Name = "cbLoadPort"
        Me.cbLoadPort.Size = New System.Drawing.Size(130, 20)
        Me.cbLoadPort.TabIndex = 1
        '
        'cbReceivePlace
        '
        Me.cbReceivePlace.Location = New System.Drawing.Point(76, 174)
        Me.cbReceivePlace.MaxDropDownItems = 20
        Me.cbReceivePlace.Name = "cbReceivePlace"
        Me.cbReceivePlace.Size = New System.Drawing.Size(130, 20)
        Me.cbReceivePlace.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(2, 176)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 18)
        Me.Label20.TabIndex = 830
        Me.Label20.Text = "收货地"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(2, 80)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 18)
        Me.Label24.TabIndex = 831
        Me.Label24.Text = "装货港"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(2, 128)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(72, 18)
        Me.Label32.TabIndex = 829
        Me.Label32.Text = "卸货港"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(422, 198)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(72, 18)
        Me.Label34.TabIndex = 828
        Me.Label34.Text = "危险品标签"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDANGER_MARK
        '
        Me.txtDANGER_MARK.Location = New System.Drawing.Point(496, 196)
        Me.txtDANGER_MARK.MaxLength = 10
        Me.txtDANGER_MARK.Name = "txtDANGER_MARK"
        Me.txtDANGER_MARK.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_MARK.TabIndex = 24
        Me.txtDANGER_MARK.Text = ""
        '
        'txtPIECE_WEIGHT
        '
        Me.txtPIECE_WEIGHT.Location = New System.Drawing.Point(496, 52)
        Me.txtPIECE_WEIGHT.MaxLength = 20
        Me.txtPIECE_WEIGHT.Name = "txtPIECE_WEIGHT"
        Me.txtPIECE_WEIGHT.TabIndex = 17
        Me.txtPIECE_WEIGHT.Text = ""
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(422, 54)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 18)
        Me.Label16.TabIndex = 826
        Me.Label16.Text = "件重"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(212, 198)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 18)
        Me.Label15.TabIndex = 821
        Me.Label15.Text = "包装"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(286, 244)
        Me.txtAmount.MaxLength = 20
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(130, 21)
        Me.txtAmount.TabIndex = 14
        Me.txtAmount.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(212, 246)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 817
        Me.Label10.Text = "总件数"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSIZE_MEASURE
        '
        Me.txtSIZE_MEASURE.Location = New System.Drawing.Point(496, 76)
        Me.txtSIZE_MEASURE.MaxLength = 20
        Me.txtSIZE_MEASURE.Name = "txtSIZE_MEASURE"
        Me.txtSIZE_MEASURE.TabIndex = 18
        Me.txtSIZE_MEASURE.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(422, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 813
        Me.Label5.Text = "体积尺寸"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCONTAINER
        '
        Me.txtCONTAINER.Location = New System.Drawing.Point(286, 220)
        Me.txtCONTAINER.MaxLength = 20
        Me.txtCONTAINER.Name = "txtCONTAINER"
        Me.txtCONTAINER.ReadOnly = True
        Me.txtCONTAINER.Size = New System.Drawing.Size(130, 21)
        Me.txtCONTAINER.TabIndex = 796
        Me.txtCONTAINER.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(212, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 812
        Me.Label3.Text = "集装箱数"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGROSS_WEIGHT
        '
        Me.txtGROSS_WEIGHT.Location = New System.Drawing.Point(496, 4)
        Me.txtGROSS_WEIGHT.MaxLength = 20
        Me.txtGROSS_WEIGHT.Name = "txtGROSS_WEIGHT"
        Me.txtGROSS_WEIGHT.TabIndex = 15
        Me.txtGROSS_WEIGHT.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(422, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 809
        Me.Label1.Text = "毛重"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNETWEIGHT
        '
        Me.txtNETWEIGHT.Location = New System.Drawing.Point(496, 28)
        Me.txtNETWEIGHT.MaxLength = 20
        Me.txtNETWEIGHT.Name = "txtNETWEIGHT"
        Me.txtNETWEIGHT.TabIndex = 16
        Me.txtNETWEIGHT.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(422, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 808
        Me.Label2.Text = "净重"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(422, 150)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 18)
        Me.Label26.TabIndex = 822
        Me.Label26.Text = "危险品编号"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(422, 174)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 18)
        Me.Label27.TabIndex = 824
        Me.Label27.Text = "危险品页号"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDANGER_GRADE
        '
        Me.txtDANGER_GRADE.Location = New System.Drawing.Point(496, 124)
        Me.txtDANGER_GRADE.MaxLength = 10
        Me.txtDANGER_GRADE.Name = "txtDANGER_GRADE"
        Me.txtDANGER_GRADE.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_GRADE.TabIndex = 21
        Me.txtDANGER_GRADE.Text = ""
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(422, 126)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(72, 18)
        Me.Label30.TabIndex = 811
        Me.Label30.Text = "危险品等级"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDANGER_NO
        '
        Me.txtDANGER_NO.Location = New System.Drawing.Point(496, 148)
        Me.txtDANGER_NO.MaxLength = 10
        Me.txtDANGER_NO.Name = "txtDANGER_NO"
        Me.txtDANGER_NO.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_NO.TabIndex = 22
        Me.txtDANGER_NO.Text = ""
        '
        'txtDANGER_PAGENO
        '
        Me.txtDANGER_PAGENO.Location = New System.Drawing.Point(496, 172)
        Me.txtDANGER_PAGENO.MaxLength = 20
        Me.txtDANGER_PAGENO.Name = "txtDANGER_PAGENO"
        Me.txtDANGER_PAGENO.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_PAGENO.TabIndex = 23
        Me.txtDANGER_PAGENO.Text = ""
        '
        'txtREFRIGERATE_TEMPERATURE
        '
        Me.txtREFRIGERATE_TEMPERATURE.Location = New System.Drawing.Point(496, 100)
        Me.txtREFRIGERATE_TEMPERATURE.MaxLength = 20
        Me.txtREFRIGERATE_TEMPERATURE.Name = "txtREFRIGERATE_TEMPERATURE"
        Me.txtREFRIGERATE_TEMPERATURE.Size = New System.Drawing.Size(82, 21)
        Me.txtREFRIGERATE_TEMPERATURE.TabIndex = 19
        Me.txtREFRIGERATE_TEMPERATURE.Text = ""
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(422, 102)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(72, 18)
        Me.Label31.TabIndex = 819
        Me.Label31.Text = "冷冻温度"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbEMPTY_MARK
        '
        Me.cbEMPTY_MARK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEMPTY_MARK.ItemHeight = 12
        Me.cbEMPTY_MARK.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbEMPTY_MARK.Location = New System.Drawing.Point(76, 222)
        Me.cbEMPTY_MARK.Name = "cbEMPTY_MARK"
        Me.cbEMPTY_MARK.Size = New System.Drawing.Size(130, 20)
        Me.cbEMPTY_MARK.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(2, 224)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 18)
        Me.Label18.TabIndex = 827
        Me.Label18.Text = "空箱单标识"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpLoadDate
        '
        Me.dtpLoadDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpLoadDate.Location = New System.Drawing.Point(286, 6)
        Me.dtpLoadDate.Name = "dtpLoadDate"
        Me.dtpLoadDate.Size = New System.Drawing.Size(130, 21)
        Me.dtpLoadDate.TabIndex = 9
        Me.dtpLoadDate.Value = New Date(2004, 7, 17, 15, 37, 55, 144)
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(212, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 18)
        Me.Label14.TabIndex = 820
        Me.Label14.Text = "装货日期"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(286, 28)
        Me.txtMark.MaxLength = 35
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(130, 21)
        Me.txtMark.TabIndex = 10
        Me.txtMark.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(212, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 816
        Me.Label9.Text = "标志"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbCONTAINER_MARK
        '
        Me.cbCONTAINER_MARK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCONTAINER_MARK.ItemHeight = 12
        Me.cbCONTAINER_MARK.Items.AddRange(New Object() {"所有状态", "在库", "出库", "在用", "注销"})
        Me.cbCONTAINER_MARK.Location = New System.Drawing.Point(76, 246)
        Me.cbCONTAINER_MARK.Name = "cbCONTAINER_MARK"
        Me.cbCONTAINER_MARK.Size = New System.Drawing.Size(130, 20)
        Me.cbCONTAINER_MARK.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(2, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 815
        Me.Label6.Text = "整拼箱标记"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBillNO
        '
        Me.txtBillNO.Location = New System.Drawing.Point(76, 54)
        Me.txtBillNO.MaxLength = 120
        Me.txtBillNO.Name = "txtBillNO"
        Me.txtBillNO.Size = New System.Drawing.Size(130, 21)
        Me.txtBillNO.TabIndex = 0
        Me.txtBillNO.Text = ""
        '
        'Label4
        '
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(2, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 814
        Me.Label4.Text = "提单号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(0, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 807
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(212, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 18)
        Me.Label7.TabIndex = 825
        Me.Label7.Text = "货物中文描述"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGOODS_CHA
        '
        Me.txtGOODS_CHA.Location = New System.Drawing.Point(216, 72)
        Me.txtGOODS_CHA.MaxLength = 100
        Me.txtGOODS_CHA.Multiline = True
        Me.txtGOODS_CHA.Name = "txtGOODS_CHA"
        Me.txtGOODS_CHA.Size = New System.Drawing.Size(200, 48)
        Me.txtGOODS_CHA.TabIndex = 11
        Me.txtGOODS_CHA.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(212, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 18)
        Me.Label8.TabIndex = 823
        Me.Label8.Text = "货物英文描述"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGOODS_ENG
        '
        Me.txtGOODS_ENG.Location = New System.Drawing.Point(216, 144)
        Me.txtGOODS_ENG.MaxLength = 200
        Me.txtGOODS_ENG.Multiline = True
        Me.txtGOODS_ENG.Name = "txtGOODS_ENG"
        Me.txtGOODS_ENG.Size = New System.Drawing.Size(200, 48)
        Me.txtGOODS_ENG.TabIndex = 12
        Me.txtGOODS_ENG.Text = ""
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(422, 246)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(72, 18)
        Me.Label28.TabIndex = 818
        Me.Label28.Text = "通知方"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNOTIFY_PERSON
        '
        Me.txtNOTIFY_PERSON.Location = New System.Drawing.Point(496, 244)
        Me.txtNOTIFY_PERSON.MaxLength = 30
        Me.txtNOTIFY_PERSON.Name = "txtNOTIFY_PERSON"
        Me.txtNOTIFY_PERSON.Size = New System.Drawing.Size(130, 21)
        Me.txtNOTIFY_PERSON.TabIndex = 26
        Me.txtNOTIFY_PERSON.Text = ""
        '
        'txtRECEIVER
        '
        Me.txtRECEIVER.Location = New System.Drawing.Point(496, 220)
        Me.txtRECEIVER.MaxLength = 30
        Me.txtRECEIVER.Name = "txtRECEIVER"
        Me.txtRECEIVER.Size = New System.Drawing.Size(130, 21)
        Me.txtRECEIVER.TabIndex = 25
        Me.txtRECEIVER.Text = ""
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(422, 222)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(72, 18)
        Me.Label33.TabIndex = 810
        Me.Label33.Text = "受货人"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C1DBG
        '
        Me.C1DBG.AllowAddNew = True
        Me.C1DBG.AllowDelete = True
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 488)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.Size = New System.Drawing.Size(634, 200)
        Me.C1DBG.TabIndex = 30
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Alig" & _
        "nVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSele" & _
        "ctorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><Height>196</Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorSty" & _
        "le parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><F" & _
        "ilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=" & _
        """Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Headi" & _
        "ng"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><Inacti" & _
        "veStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9""" & _
        " /><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle pa" & _
        "rent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0" & _
        ", 0, 630, 196</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderS" & _
        "tyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""" & _
        "Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Foot" & _
        "er"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactiv" & _
        "e"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /" & _
        "><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" " & _
        "/><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelecto" & _
        "r"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" " & _
        "/></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None" & _
        "</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 630, 196</" & _
        "ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle " & _
        "parent="""" me=""Style15"" /></Blob>"
        '
        'C1DBGOG
        '
        Me.C1DBGOG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBGOG.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.C1DBGOG.Location = New System.Drawing.Point(0, 300)
        Me.C1DBGOG.Name = "C1DBGOG"
        Me.C1DBGOG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBGOG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBGOG.PreviewInfo.ZoomFactor = 75
        Me.C1DBGOG.Size = New System.Drawing.Size(634, 185)
        Me.C1DBGOG.TabIndex = 845
        Me.C1DBGOG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
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
        "ctorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><Height>181</Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorSty" & _
        "le parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><F" & _
        "ilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=" & _
        """Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Headi" & _
        "ng"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><Inacti" & _
        "veStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9""" & _
        " /><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle pa" & _
        "rent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0" & _
        ", 0, 630, 181</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderS" & _
        "tyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""" & _
        "Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Foot" & _
        "er"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactiv" & _
        "e"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /" & _
        "><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" " & _
        "/><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelecto" & _
        "r"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" " & _
        "/></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None" & _
        "</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 630, 181</" & _
        "ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle " & _
        "parent="""" me=""Style15"" /></Blob>"
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(346, 272)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 29
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(278, 272)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 28
        Me.btSave.Text = "确认"
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(210, 272)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(65, 24)
        Me.btAdd.TabIndex = 27
        Me.btAdd.Text = "清空"
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(284, 692)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(65, 24)
        Me.btnCommit.TabIndex = 31
        Me.btnCommit.Text = "保存"
        '
        'FrmConLoadFinalNew_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(634, 719)
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.C1DBGOG)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtShipName)
        Me.Controls.Add(Me.txtVoyage)
        Me.Controls.Add(Me.Label13)
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
        Me.Name = "FrmConLoadFinalNew_Add"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "出口舱单信息 增加"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DBGOG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ds As New DataSet
    Dim sqlda As New SqlClient.SqlDataAdapter
    Dim dw As New DataView
    Dim sqlstr As String
    Dim adContainer As New SqlClient.SqlDataAdapter
    Dim dsContainer As New DataSet
    Dim dvGetConExist As New DataView

    Dim row As DataRow
    Dim iLocal(500) As Short
    Dim strPinContainerNo(500) As String
    Dim max As Short = -1
    Dim sqlCondition As String
    Dim strBillNoOg As String

    Dim dvLoadPort As New DataView
    Dim dvUnloadPort As New DataView
    Dim dvReceivePlace As New DataView
    Dim dvPack As New DataView
    Dim Mark1 As Boolean
    Dim addAllYesNo As Boolean
    Public Shared AddFlag As Boolean

    Private Sub FrmConLoadFinalNew_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        addAllYesNo = False  '默认情况有提单 为False 不全加
        AddFlag = False

        Me.btSave.Enabled = False
        Me.C1DBG.Enabled = True
        Me.btnCommit.Enabled = True

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
        strPort = "SELECT CODE_PORT, PORT_CHA, PORT_ENG FROM CODE_PORT ORDER BY PORT_CHA"
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
        strBillNoOg = FrmConLoadFinalNew.strBill
        If dw.Count >= 1 Then
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

            Me.cbLoadPort.SelectedValue = "CNLYG"
            If Me.cbLoadPort.SelectedValue Is Nothing Then
                Me.cbLoadPort.SelectedValue = "LYG"
                If Me.cbLoadPort.SelectedValue Is Nothing Then
                    cbLoadPort.Text = ds.Tables(0).Rows(0).Item("CODE_LOAD_PORT")
                End If
            End If
            If Me.cbUnloadPort.SelectedValue Is Nothing Then
                cbUnloadPort.Text = ds.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT")
            End If
            If Me.cbReceivePlace.SelectedValue Is Nothing Then
                Me.cbReceivePlace.Text = ds.Tables(0).Rows(0).Item("CODE_PLACE_RECEIVE")
            End If
        End If

        sqlCondition = " CON_HATCH_CARGO.SHIP_ID =  '" & Ship_ID & "' AND CON_HATCH_CARGO.BLNO = '--q'"

        Call GetConExist()  '显示原有箱信息
        Call InitSubTable("1=0")
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub GetConExist()
        Try
            Dim sqlGetConExist As String
            sqlGetConExist = "SELECT CONTAINER_NO,SEALNO,SealCheck,SIZE_CON,CON_KIND_ENG,EFL_Name,BAYNO,KEEPER,Reefer,DangerGrade FROM View_ConHatchConExist WHERE (SHIP_ID = '" & Ship_ID & "') AND (BLNO = '" & Me.txtBillNO.Text & "') ORDER BY CONTAINER_NO"
            dvGetConExist = Filldata(sqlGetConExist)
            Me.C1DBGOG.DataSource = dvGetConExist
            Me.C1DBGOG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue

            Me.C1DBGOG.Columns.Item("CONTAINER_NO").Caption = "集装箱号"
            Me.C1DBGOG.Columns.Item("SEALNO").Caption = "铅封号"
            Me.C1DBGOG.Columns.Item("SealCheck").Caption = "查封"
            Me.C1DBGOG.Columns.Item("SIZE_CON").Caption = "箱尺寸"
            Me.C1DBGOG.Columns.Item("CON_KIND_ENG").Caption = "箱型"
            Me.C1DBGOG.Columns.Item("EFL_Name").Caption = "箱状态"
            Me.C1DBGOG.Columns.Item("BAYNO").Caption = "贝位号"
            Me.C1DBGOG.Columns.Item("KEEPER").Caption = "箱经营人"
            Me.C1DBGOG.Columns.Item("Reefer").Caption = "冷藏"
            Me.C1DBGOG.Columns.Item("DangerGrade").Caption = "危品等级"

            Dim i As Integer = 0
            Do While i < Me.C1DBGOG.Columns.Count
                Me.C1DBGOG.Splits(0).DisplayColumns.Item(i).Width = 70
                i = i + 1
            Loop
            Me.C1DBGOG.Splits(0).DisplayColumns("CONTAINER_NO").Width = 90
            Me.C1DBGOG.Splits(0).DisplayColumns("SEALNO").Width = 90
            Me.C1DBGOG.Splits(0).DisplayColumns("KEEPER").Width = 100
            Me.C1DBGOG.Splits(0).DisplayColumns("SealCheck").Width = 20
            Me.C1DBGOG.Splits(0).DisplayColumns("Reefer").Width = 30
            Me.C1DBGOG.Splits(0).DisplayColumns("DangerGrade").Width = 50
            Me.C1DBGOG.ColumnFooters = True
            Me.C1DBGOG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
            Me.C1DBGOG.Columns.Item("CONTAINER_NO").FooterText = "原有" & dvGetConExist.Count & "条"
        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub InitSubTable(ByVal sqlCondition As String)
        Try
            Dim sqlContainer As String
            'sqlContainer = "SELECT CON_HATCH_RECORD.* FROM CON_HATCH_RECORD INNER JOIN CON_HATCH_CARGO ON CON_HATCH_RECORD.SHIP_ID = CON_HATCH_CARGO.SHIP_ID AND CON_HATCH_RECORD.CONTAINER_NO = CON_HATCH_CARGO.CONTAINER_NO WHERE " & sqlCondition
            'sqlContainer = "SELECT * FROM CON_HATCH_RECORD where 1=0 "
            sqlContainer = "SELECT CON_HATCH_RECORD_ID,SHIP_ID,CONTAINER_NO,SEALNO,SealCheck,SIZE_CON,CONTAINER_TYPE,OVER_HEIGHT,FULLOREMPTY,BAYNO,BLNO,CODE_GOODS,AMOUNT,WEIGHT,VOLUME,Code_MANUFACTURER,MANUFACTURER,CODE_KEEPER,KEEPER,ReeferTemp,TempUnit,DangerGrade,DangerMark,POSITION_CONTAINER,PASS_MARK,SHORT_UNLOAD,Unload_Mark,USER_NAME,USER_CODE " & _
                " FROM CON_HATCH_RECORD where ship_id = '" & Ship_ID & "' and container_no in (select con_hatch_cargo.container_no from con_hatch_cargo where " & sqlCondition & " )"
            '要改，加上箱号的另外形式
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
            Me.C1DBG.Splits(0).DisplayColumns.Item("USER_Code").Visible = False

            Me.C1DBG.Splits(0).DisplayColumns.Item("Code_MANUFACTURER").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("MANUFACTURER").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("KEEPER").Visible = False

            Me.C1DBG.Splits(0).DisplayColumns.Item("Unload_Mark").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("BAYNO").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("OVER_HEIGHT").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("SealCheck").Visible = False

            Me.C1DBG.Columns.Item("CONTAINER_NO").Caption = "集装箱号"
            Me.C1DBG.Columns.Item("SIZE_CON").Caption = "箱尺寸"
            Me.C1DBG.Columns.Item("CONTAINER_TYPE").Caption = "箱型"
            Me.C1DBG.Columns.Item("FULLOREMPTY").Caption = "箱状态"
            Me.C1DBG.Columns.Item("SEALNO").Caption = "铅封号"
            Me.C1DBG.Columns.Item("AMOUNT").Caption = "件数"
            Me.C1DBG.Columns.Item("WEIGHT").Caption = "重量"
            Me.C1DBG.Columns.Item("VOLUME").Caption = "体积"
            Me.C1DBG.Columns.Item("CODE_KEEPER").Caption = "箱经营人"
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
            Me.C1DBG.Columns.Item("CONTAINER_NO").FooterText = "新加" & dsContainer.Tables(0).Rows.Count & "条"
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
            sqlKeeper = "SELECT Code_Con_Company, Con_Company_CHI, Con_Company_ENG FROM Code_Con_Company ORDER BY Con_Company_CHI"

            dvKeeper = Filldata(sqlKeeper)
            Me.C1DBG.Columns("CODE_KEEPER").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("CODE_KEEPER").ValueItems.Translate = True

            For i = 0 To dvKeeper.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem
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
            Me.C1DBG.Splits(0).DisplayColumns("SIZE_CON").Width = 35
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_TYPE").Width = 35
            Me.C1DBG.Splits(0).DisplayColumns("FULLOREMPTY").Width = 35

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

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        Me.txtBillNO.Clear()
        Me.cbEMPTY_MARK.SelectedValue = "0"
        Me.cbCONTAINER_MARK.SelectedValue = "0"
        Me.dtpLoadDate.Value = Now
        Me.txtMark.Clear()
        Me.txtGOODS_CHA.Clear()
        Me.txtGOODS_ENG.Clear()
        Me.txtAmount.Clear()
        Me.txtCONTAINER.Clear()
        Me.txtPIECE_WEIGHT.Clear()
        Me.txtNETWEIGHT.Clear()
        Me.txtGROSS_WEIGHT.Clear()
        Me.txtSIZE_MEASURE.Clear()
        Me.txtREFRIGERATE_TEMPERATURE.Clear()
        Me.cbTempUnit.Text = ""
        Me.txtDANGER_NO.Clear()
        Me.txtDANGER_PAGENO.Clear()
        Me.txtDANGER_MARK.Clear()
        Me.txtDANGER_GRADE.Clear()
        Me.txtRECEIVER.Clear()
        Me.txtNOTIFY_PERSON.Clear()
        Me.cbLoadPort.SelectedValue = "CNLYG"
        If Me.cbLoadPort.SelectedValue Is Nothing Then
            Me.cbLoadPort.SelectedValue = "LYG"
        End If
        Me.cbUnloadPort.SelectedValue = "00"
        Me.cbReceivePlace.SelectedValue = "00"
        Me.cbPack.SelectedValue = "00"

        'Me.btSave.Enabled = True
        Call GetConExist()
        Call InitSubTable("1=0")

    End Sub

    Private Sub C1DBG_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles C1DBG.RowColChange
        '当前做法要求对 c1grid控件
        If e.LastCol = 2 And e.LastRow = Me.C1DBG.Row Then
            Dim sqlGetContainer As String = "SELECT * FROM CON_HATCH_RECORD WHERE SHIP_ID = '" & Ship_ID & "' AND ( CONTAINER_NO = '" & Me.C1DBG.Columns("CONTAINER_NO").CellText(e.LastRow).Trim.ToUpper & "' or CONTAINER_NO = '" & GetConOtherMode(Me.C1DBG.Columns("CONTAINER_NO").CellText(e.LastRow)) & "') AND FULLOREMPTY = 'L'"
            Dim dvGetContainer As New DataView
            dvGetContainer = Filldata(sqlGetContainer)
            Me.C1DBG.Row = e.LastRow        '将当前行位置强行拉回
            Try
                If dvGetContainer.Count = 1 Then
                    Dim i As Short
                    For i = 3 To dvGetContainer.Table.Columns.Count - 1
                        Me.C1DBG.Columns(i).Value = dvGetContainer.Item(0)(i)      '调出数据填充 c1grid
                    Next
                    'If max >= 0 Then    '如果已有标记
                    '    Dim l As Short
                    '    For l = 0 To max
                    '        If Me.C1DBG.Row = iLocal(l) Then Exit Sub '如果当前行已被标记 不重复标记
                    '    Next
                    'End If
                    'max += 1
                    'iLocal(max) = Me.C1DBG.Row  '标记当前行为非首次输入拼箱
                    If max >= 0 Then   '如果已有记录
                        Dim j As Short
                        For j = 0 To max
                            If Trim(Me.C1DBG.Columns("CONTAINER_NO").CellText(e.LastRow).ToUpper) = strPinContainerNo(j) Then
                                '如果当前拼箱号已被记录，不重复记录
                                Exit Try
                            End If
                        Next
                    End If
                    max += 1        '记录当前拼箱号
                    strPinContainerNo(max) = Trim(Me.C1DBG.Columns("CONTAINER_NO").CellText(e.LastRow).ToUpper)
                    If max > 99 Then
                        MessageBox.Show("同一船次 同一提单 同一唛头不可能有100条拼箱信息吧？")
                    End If
                ElseIf dvGetContainer.Count = 0 Then
                    'If max >= 0 Then
                    '    Dim l As Short
                    '    For l = 0 To max
                    '        If Me.C1DBG.Row = iLocal(l) Then
                    '            iLocal(l) = -100    '如果当前行已被标记 原标记无效
                    '            Exit For
                    '        End If
                    '    Next
                    'End If
                End If  '这样做，记录箱号没有重复，但原先被记录箱号如果被删除或更改，记录仍然存在，这是多余的记录
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

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
        For i = 0 To dsContainer.Tables(0).Rows.Count - 1
            Me.C1DBG.Row = i
            Me.C1DBG.Columns("CONTAINER_NO").Text = Me.C1DBG.Columns("CONTAINER_NO").CellText(i).Trim.ToUpper
            Me.C1DBG.Columns("SEALNO").Text = Me.C1DBG.Columns("SEALNO").CellText(i).Trim().ToUpper
            Me.C1DBG.Columns("CONTAINER_TYPE").Text = Me.C1DBG.Columns("CONTAINER_TYPE").CellText(i).Trim().ToUpper
            Me.C1DBG.Columns("FULLOREMPTY").Text = Me.C1DBG.Columns("FULLOREMPTY").CellText(i).Trim().ToUpper
            'Me.C1DBG.Columns("BAYNO").Text = Me.C1DBG.Columns("BAYNO").Text.Trim()
        Next
        Me.btQuit.Focus()
    End Sub

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        Dim sqlInsertRelation, sqlConExist, sqlBayExist, sqlBeing As String
        Dim strContainer, strSealNO, strBayNO, strConState As String
        Dim i, j, count As Short
        Dim iConCheck, iBeingCount As Integer
        Dim dv As New DataView

        Try
            Call TrimGrid()     '去空格，转大写

            count = Me.C1DBG.Row
            Me.C1DBG.Row = Me.C1DBG.Row + 1
            While count <> Me.C1DBG.Row     '计算c1grid当前行数
                count = Me.C1DBG.Row
                Me.C1DBG.Row = Me.C1DBG.Row + 1
            End While
            count = Me.C1DBG.Row

            For i = 0 To count - 1          '检验箱号、贝位号 以及箱状态
                strContainer = C1DBG.Columns("CONTAINER_NO").CellText(i)
                strSealNO = C1DBG.Columns("SEALNO").CellText(i)
                strBayNO = C1DBG.Columns("BAYNO").CellText(i)
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
                            If MessageBox.Show("集装箱号 " & strContainer & " 校验不正确且不存在于箱规范中！确定存在吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
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
                        'If strBayNO <> "" Then      '贝位号不空时
                        '    If strBayNO Like "######" Then      '贝位号基本规范
                        '        For j = 0 To i - 1
                        '            If IsEqualConNo(strContainer, Me.C1DBG.Columns("CONTAINER_NO").CellText(j)) Then
                        '                Me.C1DBG.Row = i
                        '                Me.C1DBG.SelectedRows.Clear()
                        '                Me.C1DBG.SelectedRows.Add(i)
                        '                Me.C1DBG.SelectedRows.Add(j)
                        '                MessageBox.Show("第" & j + 1 & "行和第" & i + 1 & "行 集装箱号重复！", "提示")
                        '                Exit Sub
                        '            End If
                        '            If Me.C1DBG.Columns("BAYNO").CellText(j) <> "" Then     '贝位号重复检查
                        '                If IsEqualBayNo(strBayNO, Me.C1DBG.Columns("BAYNO").CellText(j)) Then
                        '                    Me.C1DBG.Row = i
                        '                    Me.C1DBG.SelectedRows.Clear()
                        '                    Me.C1DBG.SelectedRows.Add(i)
                        '                    Me.C1DBG.SelectedRows.Add(j)
                        '                    MessageBox.Show("第" & j + 1 & "行和第" & i + 1 & "行 贝位号重复！", "提示")
                        '                    Exit Sub
                        '                End If
                        '            End If
                        '        Next
                        '    Else
                        '        Me.C1DBG.Row = i
                        '        Me.C1DBG.SelectedRows.Clear()
                        '        Me.C1DBG.SelectedRows.Add(i)
                        '        MessageBox.Show("贝位号不规范！", "提示")
                        '        Exit For
                        '    End If
                        'Else        '贝位号为空时
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
                        'End If
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

            '后补界面检查
            If i >= count Then
                For i = 0 To count - 1
                    strContainer = C1DBG.Columns("CONTAINER_NO").CellText(i)
                    For j = 0 To dvGetConExist.Count - 1
                        If IsEqualConNo(strContainer, Me.C1DBGOG.Columns("CONTAINER_NO").CellText(j)) Then
                            Me.C1DBG.Row = i
                            Me.C1DBGOG.Row = j
                            Me.C1DBG.SelectedRows.Clear()
                            Me.C1DBGOG.SelectedRows.Clear()
                            Me.C1DBG.SelectedRows.Add(i)
                            Me.C1DBGOG.SelectedRows.Add(j)
                            MessageBox.Show("当前提单下此集装箱号" & strContainer & "已存在！", "提示")
                            Exit Sub
                        End If
                    Next
                Next
            End If

            If i >= count Then      '检查箱号 贝位号是否与数据库中重复
                For i = 0 To count - 1
                    'For j = 0 To max
                    '    If i = iLocal(j) Then Exit For
                    'Next
                    For j = 0 To max
                        If Trim(Me.C1DBG.Columns("CONTAINER_NO").CellText(i)) = strPinContainerNo(j) Then
                            Exit For    '如果箱号被记录，不检验
                        End If
                    Next
                    If j > max Then     '此箱号未被记录，要检查数据库中是否存在
                        'sqlConExist = "SELECT CONTAINER_NO FROM CON_HATCH_RECORD WHERE ship_id = '" & Ship_ID & "' AND ( CONTAINER_NO = '" & Me.C1DBG.Columns(2).CellText(i) & "' or BAYNO = '" & Me.C1DBG.Columns(7).CellText(i) & "')"
                        sqlConExist = "SELECT CONTAINER_NO FROM CON_HATCH_RECORD WHERE ship_id = '" & Ship_ID & "' AND ( CONTAINER_NO = '" & Me.C1DBG.Columns("CONTAINER_NO").CellText(i) & "' or CONTAINER_NO = '" & GetConOtherMode(Me.C1DBG.Columns("CONTAINER_NO").CellText(i)) & "')"
                        If Filldata(sqlConExist).Count > 0 Then
                            Me.C1DBG.Row = i
                            Me.C1DBG.SelectedRows.Clear()
                            Me.C1DBG.SelectedRows.Add(i)
                            MessageBox.Show("当前船次该集装箱号已存在，不能重复！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit For
                        End If
                        'If Me.C1DBG.Columns("BAYNO").CellText(i) <> "" Then     '贝位号不空时检查贝位号
                        '    sqlBayExist = "SELECT CONTAINER_NO, BAYNO FROM CON_HATCH_RECORD WHERE ship_id = '" & Ship_ID & "' AND ( BAYNO = '" & Me.C1DBG.Columns("BAYNO").CellText(i) & "' or BAYNO = '" & TongBayNoFont(Me.C1DBG.Columns("BAYNO").CellText(i)) & "' or BAYNO = '" & TongBayNoLater(Me.C1DBG.Columns("BAYNO").CellText(i)) & "')"
                        '    If Filldata(sqlBayExist).Count > 0 Then
                        '        Me.C1DBG.Row = i
                        '        Me.C1DBG.SelectedRows.Clear()
                        '        Me.C1DBG.SelectedRows.Add(i)
                        '        MessageBox.Show("当前船次该贝位号已被使用，不能重复！", "提示")
                        '        Exit For
                        '    End If
                        'End If
                    End If
                Next
            End If

            If i >= count Then        '如果检验全部成功，更新数据库表

                If addAllYesNo = True Then  '全加时
                    row.Item("CONTAINER") = dsContainer.Tables(0).Rows.Count
                    ds.Tables(0).Rows.Add(row)
                    sqlda.Update(ds)        '插入提单信息
                Else    '不加提单时，修改箱数
                    Dim sqlConSumUpdate As String
                    sqlConSumUpdate = "update CON_HATCH_LIST set CONTAINER = CONTAINER + " & dsContainer.Tables(0).Rows.Count & "  where SHIP_ID='" & Ship_ID & "' and BLNO='" & Me.txtBillNO.Text.Trim & "'"
                    ExecSql(sqlConSumUpdate)
                End If

                For i = 0 To count - 1      '插入关系表信息
                    sqlInsertRelation = "insert into CON_HATCH_CARGO (SHIP_ID,BLNO,USER_NAME,CONTAINER_NO) values ('" & Ship_ID & "','" & Trim(txtBillNO.Text) & "','" & G_User & "','" & Me.C1DBG.Columns("CONTAINER_NO").CellText(i) & "')"
                    Call ExecSql(sqlInsertRelation)
                Next

                'i = max
                'While i >= 0
                '    If iLocal(i) >= 0 Then '如果标记有效
                '        Me.C1DBG.Row = iLocal(i)
                '        Me.C1DBG.Delete()   '删除标记行，不进行插入箱信息表操作，但插入关系表
                '    End If
                '    i -= 1
                'End While
                For i = 0 To max
                    For j = 0 To count - 1
                        If strPinContainerNo(i) = Me.C1DBG.Columns("CONTAINER_NO").CellText(j) Then  '如果标记箱号与当前箱号同
                            Me.C1DBG.Row = j
                            Me.C1DBG.Delete()  '删除此行，不进行插入箱信息表操作，但插入关系表
                            Exit For        '因为到此已不存在重复箱号，就不会有第二个标记箱号，可以提前退出内循环
                        End If
                    Next
                Next

                Me.adContainer.Update(Me.dsContainer)   '插入所有 非拼箱 和 首次拼箱 信息
                AddFlag = True  '为继续打开增加界面标记
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function SetNumValue(ByVal strNumColumn As String, ByVal strNumValue As String, Optional ByVal message As String = "数据") As Boolean
        Dim flag As Boolean = True
        If Trim(strNumValue) <> "" Then
            If IsNumeric(Trim(strNumValue)) Then
                row.Item(strNumColumn) = Trim(strNumValue)
            Else
                MessageBox.Show(message + "应为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                flag = False
            End If
        Else    '此列留空
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

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim sqlUnique As String
        Try
            If Trim(Me.txtBillNO.Text) <> "" Then
                row = ds.Tables(0).NewRow()

                If Me.SetNumValue("AMOUNT", txtAmount.Text, "件数") = False Then
                    txtAmount.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("PIECE_WEIGHT", txtPIECE_WEIGHT.Text, "件重") = False Then
                    Me.txtPIECE_WEIGHT.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("NETWEIGHT", txtNETWEIGHT.Text, "净重") = False Then
                    Me.txtNETWEIGHT.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("GROSS_WEIGHT", txtGROSS_WEIGHT.Text, "毛重") = False Then
                    Me.txtGROSS_WEIGHT.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("SIZE_MEASURE", txtSIZE_MEASURE.Text, "体积尺寸") = False Then
                    Me.txtSIZE_MEASURE.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("REFRIGERATE_TEMPERATURE", txtREFRIGERATE_TEMPERATURE.Text, "冷冻温度") = False Then
                    Me.txtREFRIGERATE_TEMPERATURE.Focus()
                    Exit Sub
                End If

                If Not IsNothing(Me.cbLoadPort.SelectedValue) Then  '港口代码能取到
                    row.Item("CODE_LOAD_PORT") = Me.cbLoadPort.SelectedValue
                    row.Item("LOAD_PORT") = Me.dvLoadPort(Me.cbLoadPort.SelectedIndex)("PORT_ENG")
                Else
                    If IsCode(Me.cbLoadPort.Text.Trim()) Then     '判断是代码的形式
                        row.Item("CODE_LOAD_PORT") = Trim(Me.cbLoadPort.Text.ToUpper)
                    Else
                        MessageBox.Show("装货港中文名不能取得时，必须输入港口代码才能保存。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.cbLoadPort.Focus()
                        Exit Sub
                    End If
                End If
                If Not IsNothing(Me.cbUnloadPort.SelectedValue) Then  '港口代码能取到
                    row.Item("CODE_UNLOAD_PORT") = Me.cbUnloadPort.SelectedValue
                    row.Item("UNLOAD_PORT") = Me.dvUnloadPort(Me.cbUnloadPort.SelectedIndex)("PORT_ENG")
                Else
                    If IsCode(Me.cbUnloadPort.Text.Trim()) Then     '判断是代码的形式
                        row.Item("CODE_UNLOAD_PORT") = Trim(Me.cbUnloadPort.Text.ToUpper)
                    Else
                        MessageBox.Show("卸货港中文名不能取得时，必须输入港口代码才能保存。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.cbUnloadPort.Focus()
                        Exit Sub
                    End If
                End If
                If Not IsNothing(Me.cbReceivePlace.SelectedValue) Then  '港口代码能取到
                    row.Item("CODE_PLACE_RECEIVE") = Me.cbReceivePlace.SelectedValue
                    row.Item("PLACE_RECEIVE") = Me.dvReceivePlace(Me.cbReceivePlace.SelectedIndex)("PORT_ENG")
                Else
                    If IsCode(Me.cbReceivePlace.Text.Trim()) Then     '判断是代码的形式
                        row.Item("CODE_PLACE_RECEIVE") = Trim(Me.cbReceivePlace.Text.ToUpper)
                    Else
                        MessageBox.Show("交货地中文名不能取得时，必须输入港口代码才能保存。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.cbReceivePlace.Focus()
                        Exit Sub
                    End If
                End If

                sqlUnique = "SELECT * FROM CON_HATCH_LIST WHERE SHIP_ID = '" & Ship_ID & "' AND BLNO = '" & Trim(Me.txtBillNO.Text) & "'"
                If Filldata(sqlUnique).Count = 0 Then
                    '这里就是检查作用，使数据表格保存按钮有效
                    Me.C1DBG.Enabled = True
                    Me.btnCommit.Enabled = True
                    sqlCondition = " CON_HATCH_CARGO.SHIP_ID =  '" & Ship_ID & "' AND CON_HATCH_CARGO.BLNO = '" & Trim(Me.txtBillNO.Text) & "'"
                    Call InitSubTable(sqlCondition)
                    Me.C1DBG.Focus()

                    row.Item("BLNO") = Trim(Me.txtBillNO.Text).ToUpper
                    row.Item("Mark") = Me.txtMark.Text.Trim
                    row.Item("GOODS_CHA") = Me.txtGOODS_CHA.Text.Trim
                    row.Item("GOODS_ENG") = Me.txtGOODS_ENG.Text.Trim
                    row.Item("DANGER_GRADE") = Me.txtDANGER_GRADE.Text.Trim
                    row.Item("DANGER_PAGENO") = Me.txtDANGER_PAGENO.Text.Trim
                    row.Item("DANGER_NO") = Me.txtDANGER_NO.Text.Trim
                    row.Item("DANGER_MARK") = Me.txtDANGER_MARK.Text.Trim
                    row.Item("RECEIVER") = Me.txtRECEIVER.Text.Trim
                    row.Item("NOTIFY_PERSON") = Me.txtNOTIFY_PERSON.Text.Trim

                    row.Item("EMPTY_MARK") = Me.cbEMPTY_MARK.SelectedValue
                    row.Item("CONTAINER_MARK") = Me.cbCONTAINER_MARK.SelectedValue
                    row.Item("CODE_PACK") = Me.cbPack.SelectedValue
                    row.Item("PACK") = Me.dvPack(Me.cbPack.SelectedIndex)("PACK_ENG")
                    row.Item("TEMPERATURE") = Me.cbTempUnit.Text
                    row.Item("LOAD_DATE") = Me.dtpLoadDate.Value

                    row.Item("SHIP_ID") = Ship_ID
                    row.Item("USER_NAME") = G_User
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

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
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
            Dim iConCheck As Integer
            Dim sqlBeing As String
            Dim dvBeing As New DataView
            Dim strConNo As String
            Me.C1DBG.Columns("CONTAINER_NO").Text = Me.C1DBG.Columns("CONTAINER_NO").Text.Trim.ToUpper
            strConNo = Me.C1DBG.Columns("CONTAINER_NO").Text
            iConCheck = CheckConNO(strConNo)    '箱号检验
            If iConCheck = 1 Or iConCheck = 2 Or iConCheck = 0 Then
                sqlBeing = "SELECT * FROM CON_CRITERION WHERE CONTAINER_NO = '" & strConNo & "' or CONTAINER_NO = '" & GetConOtherMode(strConNo) & "'"
                dvBeing = Filldata(sqlBeing)
                If dvBeing.Count >= 1 Then   '箱规范中存在
                    Me.C1DBG.Columns("SIZE_CON").Value = dvBeing.Item(0)("SIZE_CON")
                    Me.C1DBG.Columns("CONTAINER_TYPE").Value = dvBeing.Item(0)("CONTAINER_TYPE")
                    Me.C1DBG.Columns("CODE_KEEPER").Value = dvBeing.Item(0)("CODE_SHIP_OWNER")

                    Me.C1DBG.Columns("KEEPER").Value = Me.C1DBG.Columns("CODE_KEEPER").Text
                Else
                    If iConCheck = 2 Then   '箱号检验无错，但规范中没有。
                        Me.C1DBG.Columns("SIZE_CON").Value = Me.C1DBG.Columns("SIZE_CON").CellValue(Me.C1DBG.Row - 1)
                        Me.C1DBG.Columns("CONTAINER_TYPE").Value = Me.C1DBG.Columns("CONTAINER_TYPE").CellValue(Me.C1DBG.Row - 1)
                    Else
                        Me.C1DBG.SelectedRows.Clear()
                        Me.C1DBG.SelectedRows.Add(Me.C1DBG.Row)
                        If MessageBox.Show("集装箱号 " & strConNo & " 校验不正确且不存在于箱规范中！确定存在吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                            Me.C1DBG.Columns("SIZE_CON").Value = Me.C1DBG.Columns("SIZE_CON").CellValue(Me.C1DBG.Row - 1)
                            Me.C1DBG.Columns("CONTAINER_TYPE").Value = Me.C1DBG.Columns("CONTAINER_TYPE").CellValue(Me.C1DBG.Row - 1)
                        End If
                    End If
                End If
            ElseIf iConCheck = 0 Then
                Me.C1DBG.SelectedRows.Clear()
                Me.C1DBG.SelectedRows.Add(Me.C1DBG.Row)
                MessageBox.Show("集装箱号不规范！", "提示")
            End If
            If Me.txtDANGER_GRADE.Text <> "" Then
                Me.C1DBG.Columns("DangerGrade").Text = Me.txtDANGER_GRADE.Text
            End If
            If Me.txtDANGER_MARK.Text <> "" Then
                Me.C1DBG.Columns("DangerMark").Text = Me.txtDANGER_MARK.Text
            End If
            'sqlBeing = "SELECT * FROM CON_CRITERION WHERE CONTAINER_NO = '" & Trim(Me.C1DBG.Columns("CONTAINER_NO").Text.ToUpper) & "' or CONTAINER_NO = '" & GetConOtherMode(Me.C1DBG.Columns("CONTAINER_NO").Text) & "'"
            'dvBeing = Filldata(sqlBeing)
            'If dvBeing.Count >= 1 Then
            '    Me.C1DBG.Columns("SIZE_CON").Value = dvBeing.Item(0)("SIZE_CON")
            '    Me.C1DBG.Columns("CONTAINER_TYPE").Value = dvBeing.Item(0)("CONTAINER_TYPE")
            '    Me.C1DBG.Columns("CODE_KEEPER").Value = dvBeing.Item(0)("CODE_SHIP_OWNER")

            '    Me.C1DBG.Columns("KEEPER").Value = Me.C1DBG.Columns("CODE_KEEPER").Text
            'Else
            '    Me.C1DBG.Columns("SIZE_CON").Value = Me.C1DBG.Columns("SIZE_CON").CellValue(Me.C1DBG.Row - 1)
            '    Me.C1DBG.Columns("CONTAINER_TYPE").Value = Me.C1DBG.Columns("CONTAINER_TYPE").CellValue(Me.C1DBG.Row - 1)
            'End If
        End If
    End Sub

    Private Sub C1DBG_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1DBG.KeyDown
        If e.KeyCode = Keys.Return And (Me.C1DBG.Col = 17 OrElse Me.C1DBG.Col = 22) Then
            Me.C1DBG.Row += 1
            Me.C1DBG.Col = 1
            SendKeys.Send("{LEFT}")

            Dim ConTemp As String
            ConTemp = Me.C1DBG.Columns("CONTAINER_NO").CellText(Me.C1DBG.Row - 1)
            If ConTemp.Length = 11 Or ConTemp.Length = 12 Then
                Me.C1DBG.Columns("CONTAINER_NO").Text = ConTemp.Trim.Substring(0, 4).ToUpper
                Me.C1DBG.EditActive = True
                SendKeys.Send("{RIGHT}")
                Me.C1DBG.Columns("FULLOREMPTY").Value = Me.C1DBG.Columns("FULLOREMPTY").CellValue(Me.C1DBG.Row - 1)
                Me.C1DBG.Columns("CODE_KEEPER").Value = Me.C1DBG.Columns("CODE_KEEPER").CellValue(Me.C1DBG.Row - 1)
                Me.C1DBG.Columns("KEEPER").Text = Me.C1DBG.Columns("KEEPER").CellText(Me.C1DBG.Row - 1)
            End If
        End If
    End Sub

    Private Sub C1DBG_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.AfterDelete
        Me.C1DBG.Columns.Item("CONTAINER_NO").FooterText = "新加" & dsContainer.Tables(0).Rows.Count & "条"
    End Sub

    Private Sub C1DBG_AfterInsert(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.AfterInsert
        Me.C1DBG.Columns.Item("CONTAINER_NO").FooterText = "新加" & dsContainer.Tables(0).Rows.Count & "条"
    End Sub

    Private Sub txtBillNO_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBillNO.Leave
        Try
            Me.txtBillNO.Text = Me.txtBillNO.Text.Trim.ToUpper
            If Me.txtBillNO.Text <> strBillNoOg Then
                strBillNoOg = Me.txtBillNO.Text
                sqlstr = "SELECT * FROM CON_HATCH_LIST WHERE SHIP_ID = '" & Ship_ID & "' AND BLNO = '" & Me.txtBillNO.Text & "'"
                dw = Updatedata(sqlda, sqlstr, ds)
                If dw.Count > 0 Then    '已有此提单号，显示数据，不加提单信息，加箱信息和关系信息
                    txtID.Text = ds.Tables(0).Rows(0).Item("CON_HATCH_LIST_ID")
                    'ID = txtID.Text
                    'txtBillNO.Text = ds.Tables(0).Rows(0).Item("BLNO")
                    dtpLoadDate.Value = ds.Tables(0).Rows(0).Item("LOAD_DATE")
                    cbEMPTY_MARK.SelectedValue = ds.Tables(0).Rows(0).Item("EMPTY_MARK")
                    txtMark.Text = ds.Tables(0).Rows(0).Item("MARK")
                    txtGOODS_ENG.Text = ds.Tables(0).Rows(0).Item("GOODS_ENG")
                    txtGOODS_CHA.Text = ds.Tables(0).Rows(0).Item("GOODS_CHA")
                    Me.cbLoadPort.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_LOAD_PORT")
                    Me.cbUnloadPort.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT")
                    Me.cbReceivePlace.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_PLACE_RECEIVE")
                    Me.cbPack.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_PACK")
                    cbCONTAINER_MARK.SelectedValue = ds.Tables(0).Rows(0).Item("CONTAINER_MARK")

                    If Not IsDBNull(ds.Tables(0).Rows(0).Item("CONTAINER")) Then
                        txtCONTAINER.Text = ds.Tables(0).Rows(0).Item("CONTAINER")
                    End If
                    If Not IsDBNull(ds.Tables(0).Rows(0).Item("AMOUNT")) Then
                        txtAmount.Text = ds.Tables(0).Rows(0).Item("AMOUNT")
                    End If
                    If Not IsDBNull(ds.Tables(0).Rows(0).Item("GROSS_WEIGHT")) Then
                        txtGROSS_WEIGHT.Text = ds.Tables(0).Rows(0).Item("GROSS_WEIGHT")
                    End If
                    If Not IsDBNull(ds.Tables(0).Rows(0).Item("PIECE_WEIGHT")) Then
                        txtPIECE_WEIGHT.Text = ds.Tables(0).Rows(0).Item("PIECE_WEIGHT")
                    End If
                    If Not IsDBNull(ds.Tables(0).Rows(0).Item("NETWEIGHT")) Then
                        txtNETWEIGHT.Text = ds.Tables(0).Rows(0).Item("NETWEIGHT")
                    End If
                    If Not IsDBNull(ds.Tables(0).Rows(0).Item("SIZE_MEASURE")) Then
                        txtSIZE_MEASURE.Text = ds.Tables(0).Rows(0).Item("SIZE_MEASURE")
                    End If
                    If Not IsDBNull(ds.Tables(0).Rows(0).Item("REFRIGERATE_TEMPERATURE")) Then
                        txtREFRIGERATE_TEMPERATURE.Text = ds.Tables(0).Rows(0).Item("REFRIGERATE_TEMPERATURE")
                    End If
                    If Not IsDBNull(ds.Tables(0).Rows(0).Item("TEMPERATURE")) Then
                        Me.cbTempUnit.Text = ds.Tables(0).Rows(0).Item("TEMPERATURE")
                    End If
                    If Me.cbLoadPort.SelectedValue Is Nothing Then  '如果港口代码表中没有此港口代码，如此显示
                        cbLoadPort.Text = ds.Tables(0).Rows(0).Item("CODE_LOAD_PORT")
                    End If
                    If Me.cbUnloadPort.SelectedValue Is Nothing Then
                        cbUnloadPort.Text = ds.Tables(0).Rows(0).Item("CODE_UNLOAD_PORT")
                    End If
                    If Me.cbReceivePlace.SelectedValue Is Nothing Then
                        Me.cbReceivePlace.Text = ds.Tables(0).Rows(0).Item("CODE_PLACE_RECEIVE")
                    End If
                    txtRECEIVER.Text = ds.Tables(0).Rows(0).Item("RECEIVER")
                    txtNOTIFY_PERSON.Text = ds.Tables(0).Rows(0).Item("NOTIFY_PERSON")
                    txtDANGER_GRADE.Text = ds.Tables(0).Rows(0).Item("DANGER_GRADE")
                    txtDANGER_NO.Text = ds.Tables(0).Rows(0).Item("DANGER_NO")
                    If Not IsDBNull(ds.Tables(0).Rows(0).Item("DANGER_PAGENO")) Then
                        txtDANGER_PAGENO.Text = ds.Tables(0).Rows(0).Item("DANGER_PAGENO")
                    End If
                    txtDANGER_MARK.Text = ds.Tables(0).Rows(0).Item("DANGER_MARK")

                    addAllYesNo = False
                Else        '这是一新提单
                    'Me.txtGOODS_CHA.Clear()
                    'Me.txtAmount.Clear()
                    'Me.txtCONTAINER.Clear()
                    'Me.txtGROSS_WEIGHT.Clear()

                    addAllYesNo = True
                End If
                Call GetConExist()
                Call InitSubTable("1=0")
                If addAllYesNo = True Then
                    Me.btSave.Enabled = True
                    Me.C1DBG.Enabled = False
                    Me.btnCommit.Enabled = False
                Else
                    Me.btSave.Enabled = False
                    Me.C1DBG.Enabled = True
                    Me.btnCommit.Enabled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtReeferTemp_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtREFRIGERATE_TEMPERATURE.Leave
        If IsNumeric(txtREFRIGERATE_TEMPERATURE.Text) Then
            Me.cbTempUnit.SelectedIndex = 1
        Else
            Me.cbTempUnit.SelectedIndex = 0
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
