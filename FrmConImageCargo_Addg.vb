Imports TALLY.DBControl
Public Class FrmConImageCargo_Addg
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim row As DataRow
    Dim Mark1 As Boolean

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��
        AddHandler txtContainerNo.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress
        AddHandler txtConSize.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress
        AddHandler txtConType.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress
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

        AddHandler txtLOAD_PORT.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress
        AddHandler txtUNLOAD_PORT.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress
        AddHandler txtDelivery.KeyPress, AddressOf Me.FrmConImageCargo_Addg_KeyPress

        AddHandler cbReceivePlaceEng.KeyPress, AddressOf FrmConImageCargo_Addg_KeyPress
        AddHandler cbLoadPortEng.KeyPress, AddressOf FrmConImageCargo_Addg_KeyPress
        AddHandler cbUnloadPortEng.KeyPress, AddressOf FrmConImageCargo_Addg_KeyPress
        AddHandler txtConSize.KeyPress, AddressOf FrmConImageCargo_Addg_KeyPress
        AddHandler txtConType.KeyPress, AddressOf FrmConImageCargo_Addg_KeyPress
    End Sub

    '������д��������������б�
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows ����������������
    Private components As System.ComponentModel.IContainer

    'ע�⣺���¹����� Windows ����������������
    '����ʹ�� Windows ����������޸Ĵ˹��̡�
    '��Ҫʹ�ô���༭���޸�����
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
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents txtBillNO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDelivery As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtLOAD_PORT As System.Windows.Forms.TextBox
    Friend WithEvents txtUNLOAD_PORT As System.Windows.Forms.TextBox
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
    Friend WithEvents txtConSize As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtConType As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
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
        Me.btAdd = New System.Windows.Forms.Button
        Me.txtBillNO = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDelivery = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtLOAD_PORT = New System.Windows.Forms.TextBox
        Me.txtUNLOAD_PORT = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cbUnloadPortEng = New System.Windows.Forms.ComboBox
        Me.cbLoadPortEng = New System.Windows.Forms.ComboBox
        Me.cbReceivePlaceEng = New System.Windows.Forms.ComboBox
        Me.ckbMoved = New System.Windows.Forms.CheckBox
        Me.txtConSize = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtConType = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtDANGER_MARK
        '
        Me.txtDANGER_MARK.Location = New System.Drawing.Point(288, 246)
        Me.txtDANGER_MARK.MaxLength = 32
        Me.txtDANGER_MARK.Name = "txtDANGER_MARK"
        Me.txtDANGER_MARK.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_MARK.TabIndex = 18
        Me.txtDANGER_MARK.Text = ""
        '
        'txtDANGER_GRADE
        '
        Me.txtDANGER_GRADE.Location = New System.Drawing.Point(288, 174)
        Me.txtDANGER_GRADE.MaxLength = 10
        Me.txtDANGER_GRADE.Name = "txtDANGER_GRADE"
        Me.txtDANGER_GRADE.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_GRADE.TabIndex = 15
        Me.txtDANGER_GRADE.Text = ""
        '
        'txtDANGER_NO
        '
        Me.txtDANGER_NO.Location = New System.Drawing.Point(288, 222)
        Me.txtDANGER_NO.MaxLength = 10
        Me.txtDANGER_NO.Name = "txtDANGER_NO"
        Me.txtDANGER_NO.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_NO.TabIndex = 17
        Me.txtDANGER_NO.Text = ""
        '
        'txtDANGER_PAGENO
        '
        Me.txtDANGER_PAGENO.Location = New System.Drawing.Point(288, 198)
        Me.txtDANGER_PAGENO.MaxLength = 20
        Me.txtDANGER_PAGENO.Name = "txtDANGER_PAGENO"
        Me.txtDANGER_PAGENO.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_PAGENO.TabIndex = 16
        Me.txtDANGER_PAGENO.Text = ""
        '
        'cbTempUnit
        '
        Me.cbTempUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTempUnit.Items.AddRange(New Object() {"", "C", "F"})
        Me.cbTempUnit.Location = New System.Drawing.Point(288, 80)
        Me.cbTempUnit.Name = "cbTempUnit"
        Me.cbTempUnit.Size = New System.Drawing.Size(130, 20)
        Me.cbTempUnit.TabIndex = 11
        '
        'txtBayNo
        '
        Me.txtBayNo.Location = New System.Drawing.Point(78, 128)
        Me.txtBayNo.MaxLength = 7
        Me.txtBayNo.Name = "txtBayNo"
        Me.txtBayNo.Size = New System.Drawing.Size(130, 21)
        Me.txtBayNo.TabIndex = 3
        Me.txtBayNo.Text = ""
        '
        'Label14
        '
        Me.Label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label14.Location = New System.Drawing.Point(4, 130)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 18)
        Me.Label14.TabIndex = 501
        Me.Label14.Text = "��λ��"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbState
        '
        Me.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbState.Items.AddRange(New Object() {"����״̬", "�ڿ�", "����", "����", "ע��"})
        Me.cbState.Location = New System.Drawing.Point(78, 80)
        Me.cbState.Name = "cbState"
        Me.cbState.Size = New System.Drawing.Size(130, 20)
        Me.cbState.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(4, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 500
        Me.Label6.Text = "��״̬"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbDelivery
        '
        Me.cbDelivery.Items.AddRange(New Object() {"����״̬", "�ڿ�", "����", "����", "ע��"})
        Me.cbDelivery.Location = New System.Drawing.Point(78, 266)
        Me.cbDelivery.MaxDropDownItems = 20
        Me.cbDelivery.Name = "cbDelivery"
        Me.cbDelivery.Size = New System.Drawing.Size(130, 20)
        Me.cbDelivery.TabIndex = 7
        '
        'cbUnloadPort
        '
        Me.cbUnloadPort.Items.AddRange(New Object() {"����״̬", "�ڿ�", "����", "����", "ע��"})
        Me.cbUnloadPort.Location = New System.Drawing.Point(78, 222)
        Me.cbUnloadPort.MaxDropDownItems = 20
        Me.cbUnloadPort.Name = "cbUnloadPort"
        Me.cbUnloadPort.Size = New System.Drawing.Size(130, 20)
        Me.cbUnloadPort.TabIndex = 6
        '
        'cbLoadPort
        '
        Me.cbLoadPort.Items.AddRange(New Object() {"����״̬", "�ڿ�", "����", "����", "ע��"})
        Me.cbLoadPort.Location = New System.Drawing.Point(78, 176)
        Me.cbLoadPort.MaxDropDownItems = 20
        Me.cbLoadPort.Name = "cbLoadPort"
        Me.cbLoadPort.Size = New System.Drawing.Size(130, 20)
        Me.cbLoadPort.TabIndex = 5
        '
        'txtSealNo
        '
        Me.txtSealNo.Location = New System.Drawing.Point(78, 104)
        Me.txtSealNo.MaxLength = 20
        Me.txtSealNo.Name = "txtSealNo"
        Me.txtSealNo.Size = New System.Drawing.Size(130, 21)
        Me.txtSealNo.TabIndex = 2
        Me.txtSealNo.Text = ""
        '
        'Label35
        '
        Me.Label35.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label35.Location = New System.Drawing.Point(4, 106)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(72, 18)
        Me.Label35.TabIndex = 491
        Me.Label35.Text = "Ǧ���"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtContainerNo
        '
        Me.txtContainerNo.Location = New System.Drawing.Point(78, 8)
        Me.txtContainerNo.MaxLength = 12
        Me.txtContainerNo.Name = "txtContainerNo"
        Me.txtContainerNo.Size = New System.Drawing.Size(130, 21)
        Me.txtContainerNo.TabIndex = 0
        Me.txtContainerNo.Text = ""
        '
        'Label36
        '
        Me.Label36.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label36.Location = New System.Drawing.Point(4, 10)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 18)
        Me.Label36.TabIndex = 495
        Me.Label36.Text = "��װ���"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(214, 128)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 18)
        Me.Label29.TabIndex = 479
        Me.Label29.Text = "��������"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(214, 248)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(72, 18)
        Me.Label34.TabIndex = 489
        Me.Label34.Text = "Σ��Ʒ��ǩ"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(214, 82)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 18)
        Me.Label15.TabIndex = 483
        Me.Label15.Text = "�¶ȵ�λ"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(288, 8)
        Me.txtAmount.MaxLength = 20
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(130, 21)
        Me.txtAmount.TabIndex = 8
        Me.txtAmount.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(214, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 473
        Me.Label10.Text = "����"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVolume
        '
        Me.txtVolume.Location = New System.Drawing.Point(288, 56)
        Me.txtVolume.MaxLength = 20
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.TabIndex = 10
        Me.txtVolume.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(214, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 469
        Me.Label5.Text = "����ߴ�"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTempMax
        '
        Me.txtTempMax.Location = New System.Drawing.Point(288, 150)
        Me.txtTempMax.MaxLength = 20
        Me.txtTempMax.Name = "txtTempMax"
        Me.txtTempMax.Size = New System.Drawing.Size(130, 21)
        Me.txtTempMax.TabIndex = 14
        Me.txtTempMax.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(214, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 468
        Me.Label3.Text = "��������"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGROSSWEIGHT
        '
        Me.txtGROSSWEIGHT.Location = New System.Drawing.Point(288, 32)
        Me.txtGROSSWEIGHT.MaxLength = 20
        Me.txtGROSSWEIGHT.Name = "txtGROSSWEIGHT"
        Me.txtGROSSWEIGHT.TabIndex = 9
        Me.txtGROSSWEIGHT.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(214, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 464
        Me.Label1.Text = "��ë��"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(214, 224)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 18)
        Me.Label26.TabIndex = 481
        Me.Label26.Text = "Σ��Ʒ���"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(214, 200)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 18)
        Me.Label27.TabIndex = 484
        Me.Label27.Text = "Σ��Ʒҳ��"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTempMin
        '
        Me.txtTempMin.Location = New System.Drawing.Point(288, 126)
        Me.txtTempMin.MaxLength = 20
        Me.txtTempMin.Name = "txtTempMin"
        Me.txtTempMin.Size = New System.Drawing.Size(130, 21)
        Me.txtTempMin.TabIndex = 13
        Me.txtTempMin.Text = ""
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(214, 176)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(72, 18)
        Me.Label30.TabIndex = 467
        Me.Label30.Text = "Σ��Ʒ�ȼ�"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTempSet
        '
        Me.txtTempSet.Location = New System.Drawing.Point(288, 102)
        Me.txtTempSet.MaxLength = 20
        Me.txtTempSet.Name = "txtTempSet"
        Me.txtTempSet.Size = New System.Drawing.Size(130, 21)
        Me.txtTempSet.TabIndex = 12
        Me.txtTempSet.Text = ""
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(214, 104)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(72, 18)
        Me.Label31.TabIndex = 477
        Me.Label31.Text = "�����¶�"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(246, 316)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 461
        Me.btQuit.Text = "�˳�"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(178, 316)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 19
        Me.btSave.Text = "ȷ��"
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(110, 316)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(65, 24)
        Me.btAdd.TabIndex = 459
        Me.btAdd.Text = "���"
        '
        'txtBillNO
        '
        Me.txtBillNO.Location = New System.Drawing.Point(78, 152)
        Me.txtBillNO.MaxLength = 20
        Me.txtBillNO.Name = "txtBillNO"
        Me.txtBillNO.Size = New System.Drawing.Size(130, 21)
        Me.txtBillNO.TabIndex = 4
        Me.txtBillNO.Text = ""
        '
        'Label4
        '
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(4, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 470
        Me.Label4.Text = "�ᵥ��"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDelivery
        '
        Me.txtDelivery.Location = New System.Drawing.Point(-34, 306)
        Me.txtDelivery.MaxLength = 70
        Me.txtDelivery.Name = "txtDelivery"
        Me.txtDelivery.Size = New System.Drawing.Size(130, 21)
        Me.txtDelivery.TabIndex = 435
        Me.txtDelivery.Text = ""
        Me.txtDelivery.Visible = False
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(4, 290)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 18)
        Me.Label20.TabIndex = 476
        Me.Label20.Text = "������Ӣ��"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(4, 268)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 18)
        Me.Label21.TabIndex = 472
        Me.Label21.Text = "������"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(4, 224)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 18)
        Me.Label22.TabIndex = 486
        Me.Label22.Text = "ж����"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(4, 178)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 18)
        Me.Label23.TabIndex = 466
        Me.Label23.Text = "װ����"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(4, 202)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 18)
        Me.Label24.TabIndex = 480
        Me.Label24.Text = "װ����Ӣ��"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLOAD_PORT
        '
        Me.txtLOAD_PORT.Location = New System.Drawing.Point(-34, 216)
        Me.txtLOAD_PORT.MaxLength = 35
        Me.txtLOAD_PORT.Name = "txtLOAD_PORT"
        Me.txtLOAD_PORT.Size = New System.Drawing.Size(130, 21)
        Me.txtLOAD_PORT.TabIndex = 431
        Me.txtLOAD_PORT.Text = ""
        Me.txtLOAD_PORT.Visible = False
        '
        'txtUNLOAD_PORT
        '
        Me.txtUNLOAD_PORT.Location = New System.Drawing.Point(-34, 260)
        Me.txtUNLOAD_PORT.MaxLength = 35
        Me.txtUNLOAD_PORT.Name = "txtUNLOAD_PORT"
        Me.txtUNLOAD_PORT.Size = New System.Drawing.Size(130, 21)
        Me.txtUNLOAD_PORT.TabIndex = 433
        Me.txtUNLOAD_PORT.Text = ""
        Me.txtUNLOAD_PORT.Visible = False
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(4, 246)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(72, 18)
        Me.Label32.TabIndex = 475
        Me.Label32.Text = "ж����Ӣ��"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(0, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 462
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(388, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 20)
        Me.Label2.TabIndex = 503
        Me.Label2.Text = "����"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(388, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 20)
        Me.Label11.TabIndex = 502
        Me.Label11.Text = "����"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbUnloadPortEng
        '
        Me.cbUnloadPortEng.Location = New System.Drawing.Point(78, 244)
        Me.cbUnloadPortEng.MaxDropDownItems = 20
        Me.cbUnloadPortEng.Name = "cbUnloadPortEng"
        Me.cbUnloadPortEng.Size = New System.Drawing.Size(130, 20)
        Me.cbUnloadPortEng.TabIndex = 506
        '
        'cbLoadPortEng
        '
        Me.cbLoadPortEng.Location = New System.Drawing.Point(78, 200)
        Me.cbLoadPortEng.MaxDropDownItems = 20
        Me.cbLoadPortEng.Name = "cbLoadPortEng"
        Me.cbLoadPortEng.Size = New System.Drawing.Size(130, 20)
        Me.cbLoadPortEng.TabIndex = 505
        '
        'cbReceivePlaceEng
        '
        Me.cbReceivePlaceEng.Location = New System.Drawing.Point(78, 288)
        Me.cbReceivePlaceEng.MaxDropDownItems = 20
        Me.cbReceivePlaceEng.Name = "cbReceivePlaceEng"
        Me.cbReceivePlaceEng.Size = New System.Drawing.Size(130, 20)
        Me.cbReceivePlaceEng.TabIndex = 504
        '
        'ckbMoved
        '
        Me.ckbMoved.Location = New System.Drawing.Point(344, 274)
        Me.ckbMoved.Name = "ckbMoved"
        Me.ckbMoved.Size = New System.Drawing.Size(74, 24)
        Me.ckbMoved.TabIndex = 508
        Me.ckbMoved.Text = "������"
        '
        'txtConSize
        '
        Me.txtConSize.Location = New System.Drawing.Point(78, 32)
        Me.txtConSize.MaxLength = 2
        Me.txtConSize.Name = "txtConSize"
        Me.txtConSize.Size = New System.Drawing.Size(130, 21)
        Me.txtConSize.TabIndex = 509
        Me.txtConSize.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(4, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 510
        Me.Label7.Text = "��ߴ�"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtConType
        '
        Me.txtConType.Location = New System.Drawing.Point(78, 56)
        Me.txtConType.MaxLength = 2
        Me.txtConType.Name = "txtConType"
        Me.txtConType.Size = New System.Drawing.Size(130, 21)
        Me.txtConType.TabIndex = 511
        Me.txtConType.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(4, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 18)
        Me.Label8.TabIndex = 512
        Me.Label8.Text = "����"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmConImageCargo_Addg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(426, 347)
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
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.txtBillNO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtDelivery)
        Me.Controls.Add(Me.txtLOAD_PORT)
        Me.Controls.Add(Me.txtUNLOAD_PORT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConImageCargo_Addg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "��װ�䴬ͼ��Ϣ ����"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim sqlGetPortName As String
    'Dim dvTemp As New DataView()
    Public Shared Sign As Boolean = False
    Dim dvLoadPort As New DataView()
    Dim dvUnloadPort As New DataView()
    Dim dvDelivery As New DataView()

    Private Sub FrmConImageCargo_Addg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Dim dvState As New DataView()

        Dim sqlConState, sqlPort, sqlDelivery As String

        'Me.txtLOAD_PORT.Enabled = False
        'Me.txtUNLOAD_PORT.Enabled = False
        'Me.txtDelivery.Enabled = False

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

            txtLOAD_PORT.Text = ds.Tables(0).Rows(0).Item("LOAD_PORT")
            txtUNLOAD_PORT.Text = ds.Tables(0).Rows(0).Item("UNLOAD_PORT")
            txtDelivery.Text = ds.Tables(0).Rows(0).Item("DELIVERY")

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

        If FrmConImageCargo.InOutCode = "0" Then    'in
            Me.cbUnloadPort.SelectedValue = "CNLYG"
            If Me.cbUnloadPort.SelectedValue Is Nothing Then
                Me.cbUnloadPort.SelectedValue = "LYG"
            End If
        ElseIf FrmConImageCargo.InOutCode = "1" Then    'out
            Me.cbLoadPort.SelectedValue = "CNLYG"
            If Me.cbLoadPort.SelectedValue Is Nothing Then
                Me.cbLoadPort.SelectedValue = "LYG"
            End If
        End If
        txtContainerNo_Leave(sender, e)
        Exit Sub
Err:
        Resume Next
    End Sub

    Private Function CheckConNO(ByVal sm As String) As Integer 'return 0 ����д� 1 У���д� 2 У����ȷ
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

    Function IsCode(ByVal str As String) As Boolean    ' ��ͷ����
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
            Return True     '���λ���м�ɿ�
        Else
            Return False
        End If
    End Function

    Private Function GetConOtherMode(ByVal ConNo As String) As String   '�õ���ŵ���һ���޿ջ��п���ʽ
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
                row = ds.Tables(0).NewRow()

                If Me.SetNumValue("AMOUNT", txtAmount.Text, "����") = False Then
                    txtAmount.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("GROSSWEIGHT", txtGROSSWEIGHT.Text, "��ë��") = False Then
                    Me.txtGROSSWEIGHT.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("VOLUME", txtVolume.Text, "���") = False Then
                    Me.txtVolume.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("TEMPERATURE_SETTING", txtTempSet.Text, "�����¶�") = False Then
                    Me.txtTempSet.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("MIN_TEMPERATURE", txtTempMax.Text, "�������¶�") = False Then
                    Me.txtTempMax.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("MAX_TEMPERATURE", txtTempMin.Text, "�������¶�") = False Then
                    Me.txtTempMin.Focus()
                    Exit Sub
                End If

                If Not IsNothing(Me.cbLoadPort.SelectedValue) Then  '�ۿڴ�����ȡ��
                    row.Item("CODE_LOAD_PORT") = Me.cbLoadPort.SelectedValue
                    row.Item("LOAD_PORT") = Trim(Me.cbLoadPort.Text.ToUpper)
                Else
                    If IsCode(Me.cbLoadPort.Text.Trim()) Then     '�ж��Ǵ������ʽ
                        row.Item("CODE_LOAD_PORT") = Trim(Me.cbLoadPort.Text.ToUpper)
                    Else
                        MessageBox.Show("װ��������������ȡ��ʱ����������ۿڴ�����ܱ��档", "����", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.cbLoadPort.Focus()
                        Exit Sub
                    End If
                End If
                If Not IsNothing(Me.cbUnloadPort.SelectedValue) Then  '�ۿڴ�����ȡ��
                    row.Item("CODE_UNLOAD_PORT") = Me.cbUnloadPort.SelectedValue
                    row.Item("UNLOAD_PORT") = Trim(Me.cbUnloadPort.Text.ToUpper)
                Else
                    If IsCode(Me.cbUnloadPort.Text.Trim()) Then     '�ж��Ǵ������ʽ
                        row.Item("CODE_UNLOAD_PORT") = Trim(Me.cbUnloadPort.Text.ToUpper)
                    Else
                        MessageBox.Show("ж��������������ȡ��ʱ����������ۿڴ�����ܱ��档", "����", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.cbUnloadPort.Focus()
                        Exit Sub
                    End If
                End If
                If Not IsNothing(Me.cbDelivery.SelectedValue) Then  '�ۿڴ�����ȡ��
                    row.Item("CODE_DELIVERY") = Me.cbDelivery.SelectedValue
                    row.Item("DELIVERY") = Trim(Me.cbDelivery.Text.ToUpper)
                Else
                    If IsCode(Me.cbDelivery.Text.Trim()) Then     '�ж��Ǵ������ʽ
                        row.Item("CODE_DELIVERY") = Trim(Me.cbDelivery.Text.ToUpper)
                    Else
                        MessageBox.Show("����������������ȡ��ʱ����������ۿڴ�����ܱ��档", "����", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.cbDelivery.Focus()
                        Exit Sub
                    End If
                End If

                If Trim(Me.txtBayNo.Text) Like "######" Then
                    sqlUnique = "SELECT * FROM CON_IMAGE WHERE SHIP_ID = '" & Ship_ID & "' and TPMark='0' AND ( CONTAINER_NO = '" & Trim(Me.txtContainerNo.Text.ToUpper) & "' or CONTAINER_NO = '" & GetConOtherMode(Me.txtContainerNo.Text) & "' or ( BAYNO = '" & Trim(Me.txtBayNo.Text) & "' " & _
                    "or substring(cast('2'+substring(BAYNO,1,2)+1 as char(3))+right(BAYNO,4),2,6) = '" & Trim(Me.txtBayNo.Text) & "' or substring(cast('2'+substring(BAYNO,1,2)-1 as char(3))+right(BAYNO,4),2,6) = '" & Trim(Me.txtBayNo.Text) & "')) "

                    If Filldata(sqlUnique).Count = 0 Then
                        Dim iConCheck, iBeingCount As Integer
                        iConCheck = CheckConNO(Trim(Me.txtContainerNo.Text))
                        sqlBeing = "SELECT CONTAINER_NO FROM CON_CRITERION WHERE CONTAINER_NO = '" & Trim(Me.txtContainerNo.Text.ToUpper) & "' or CONTAINER_NO = '" & GetConOtherMode(Me.txtContainerNo.Text) & "'"
                        iBeingCount = Filldata(sqlBeing).Count
                        If iBeingCount >= 1 Or iConCheck = 2 Or iConCheck = 1 Then   '��ſ���ͨ������
                            If iBeingCount = 0 Then    '������
                                If iConCheck = 1 Then   '��ûͨ��У�� ������ʾ
                                    If MessageBox.Show("��װ���У�鲻��ȷ��ȷ��������", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
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
                                        MessageBox.Show("���Ͳ��Ϲ淶", "��ʾ")
                                        Exit Sub
                                    End If
                                Else
                                    Me.txtConSize.Focus()
                                    MessageBox.Show("��ߴ粻�Ϲ淶", "��ʾ")
                                    Exit Sub
                                End If
                            End If

                            row.Item("CONTAINER_NO") = Trim(Me.txtContainerNo.Text.ToUpper)
                            row.Item("SEALNO") = Trim(Me.txtSealNo.Text)
                            row.Item("BAYNO") = Trim(Me.txtBayNo.Text)
                            row.Item("BLNO") = Trim(Me.txtBillNO.Text).ToUpper

                            'row.Item("LOAD_PORT") = Trim(Me.txtLOAD_PORT.Text)
                            'row.Item("UNLOAD_PORT") = Trim(Me.txtUNLOAD_PORT.Text)
                            'row.Item("DELIVERY") = Trim(Me.txtDelivery.Text)

                            row.Item("DANGER_GRADE") = Trim(Me.txtDANGER_GRADE.Text)
                            row.Item("DANGER_NO") = Trim(Me.txtDANGER_NO.Text)
                            row.Item("DANGER_MARK") = Trim(Me.txtDANGER_MARK.Text)
                            row.Item("DANGER_PAGENO") = Trim(Me.txtDANGER_PAGENO.Text)

                            row.Item("FULLOREMPTY") = Me.cbState.SelectedValue
                            row.Item("TEMPERATURE_UNIT") = Trim(Me.cbTempUnit.Text)

                            row.Item("Moved") = Me.ckbMoved.Checked

                            row.Item("SHIP_ID") = Ship_ID
                            row.Item("USER_NAME") = G_User

                            ds.Tables(0).Rows.Add(row)
                            sqlda.Update(ds)

                            'If MessageBox.Show("�Ƿ�������һ����", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            '    Me.txtContainerNo.Focus()
                            '    Me.txtContainerNo.SelectAll()
                            'Else
                            '    Me.Close()
                            'End If
                            Sign = True
                            Me.txtContainerNo.Focus()
                            Me.txtContainerNo.SelectAll()
                            Me.Close()
                        Else
                            MessageBox.Show("�ü�װ��Ų��淶����������", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        End If
                    Else
                        MessageBox.Show("ͬһ���� ��װ��Ų����ظ� ��λ�Ų����ظ�������ͨ����", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("������淶�ı�λ��", "��ʾ")
                End If
            Else
                MessageBox.Show("��װ��� ��״̬ ��λ�� ����Ϊ��", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function SetNumValue(ByVal strNumColumn As String, ByVal strNumValue As String, Optional ByVal message As String = "����") As Boolean
        Dim flag As Boolean = True
        If Trim(strNumValue) <> "" Then
            If IsNumeric(Trim(strNumValue)) Then
                row.Item(strNumColumn) = Trim(strNumValue)
            Else
                MessageBox.Show(message + "ӦΪ���֣�", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                flag = False
            End If
        Else    '��������
        End If
        Return flag
    End Function

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        Me.txtAmount.Clear()
        Me.txtBayNo.Clear()
        Me.txtBillNO.Clear()
        Me.txtContainerNo.Clear()
        Me.txtDANGER_GRADE.Clear()
        Me.txtDANGER_MARK.Clear()
        Me.txtDANGER_NO.Clear()
        Me.txtDANGER_PAGENO.Clear()
        Me.txtDelivery.Clear()
        Me.txtGROSSWEIGHT.Clear()
        Me.txtLOAD_PORT.Clear()
        Me.txtSealNo.Clear()
        Me.txtTempMax.Clear()
        Me.txtTempMin.Clear()
        Me.txtTempSet.Clear()
        Me.txtUNLOAD_PORT.Clear()
        Me.txtVolume.Clear()

        Me.txtLOAD_PORT.Clear()
        Me.txtUNLOAD_PORT.Clear()
        Me.txtDelivery.Clear()

        Me.cbDelivery.SelectedValue = ""
        Me.cbUnloadPort.SelectedValue = ""
        Me.cbLoadPort.SelectedValue = ""
        Me.cbState.SelectedValue = ""
        Me.cbTempUnit.SelectedIndex = 0
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Sign = False
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
            'Me.SelectNextControl(Me.txtContainerNo, False, False, True, False)
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
                If Not IsDBNull(dvConBeing(0)("SIZE_CON")) Then
                    Me.txtConSize.Text = dvConBeing(0)("SIZE_CON")
                End If
                If Not IsDBNull(dvConBeing(0)("CONTAINER_TYPE")) Then
                    Me.txtConType.Text = dvConBeing(0)("CONTAINER_TYPE")
                End If
            Else

            End If
        ElseIf iConCheck = 1 Then
            dvConBeing = Filldata(sqlConBeing)
            If dvConBeing.Count > 0 Then
                If Not IsDBNull(dvConBeing(0)("SIZE_CON")) Then
                    Me.txtConSize.Text = dvConBeing(0)("SIZE_CON")
                End If
                If Not IsDBNull(dvConBeing(0)("CONTAINER_TYPE")) Then
                    Me.txtConType.Text = dvConBeing(0)("CONTAINER_TYPE")
                End If
            Else
                MessageBox.Show("���У�鲻��ȷ����淶�в�����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else
            MessageBox.Show("��Ų��Ϲ淶", "��ʾ")
        End If
    End Sub
End Class
