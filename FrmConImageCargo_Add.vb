Imports TALLY.DBControl
Public Class FrmConImageCargo_Add
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim row As DataRow

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

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
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtDANGER_MARK As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtDANGER_GRADE As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtDANGER_NO As System.Windows.Forms.TextBox
    Friend WithEvents txtDANGER_PAGENO As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents cbGoodsCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtMark As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBillNO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtGOODS_CHA As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtGOODS_ENG As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtGROSSWEIGHT As System.Windows.Forms.TextBox
    Friend WithEvents txtTAREWEIGHT As System.Windows.Forms.TextBox
    Friend WithEvents txtContainerSize As System.Windows.Forms.TextBox
    Friend WithEvents txtSealNo As System.Windows.Forms.TextBox
    Friend WithEvents txtContainerNo As System.Windows.Forms.TextBox
    Friend WithEvents cbLoadPortCode As System.Windows.Forms.ComboBox
    Friend WithEvents cbUnloadPortCode As System.Windows.Forms.ComboBox
    Friend WithEvents cbDeliveryCode As System.Windows.Forms.ComboBox
    Friend WithEvents cbState As System.Windows.Forms.ComboBox
    Friend WithEvents txtBayNo As System.Windows.Forms.TextBox
    Friend WithEvents txtOverBefore As System.Windows.Forms.TextBox
    Friend WithEvents txtVolume As System.Windows.Forms.TextBox
    Friend WithEvents txtTempMax As System.Windows.Forms.TextBox
    Friend WithEvents txtTempMin As System.Windows.Forms.TextBox
    Friend WithEvents txtTempSet As System.Windows.Forms.TextBox
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents txtKeeper As System.Windows.Forms.TextBox
    Friend WithEvents txtOverRight As System.Windows.Forms.TextBox
    Friend WithEvents txtOverLeft As System.Windows.Forms.TextBox
    Friend WithEvents txtOverHeight As System.Windows.Forms.TextBox
    Friend WithEvents cbKeeperCode As System.Windows.Forms.ComboBox
    Friend WithEvents cbShortUnload As System.Windows.Forms.ComboBox
    Friend WithEvents cbPassMark As System.Windows.Forms.ComboBox
    Friend WithEvents txtOverBehind As System.Windows.Forms.TextBox
    Friend WithEvents cbTempUnit As System.Windows.Forms.ComboBox
    Friend WithEvents cbCompanyCode As System.Windows.Forms.ComboBox
    Friend WithEvents txtLOAD_PORT As System.Windows.Forms.TextBox
    Friend WithEvents txtUNLOAD_PORT As System.Windows.Forms.TextBox
    Friend WithEvents txtDelivery As System.Windows.Forms.TextBox
    Friend WithEvents cbUnloadPort As System.Windows.Forms.ComboBox
    Friend WithEvents cbLoadPort As System.Windows.Forms.ComboBox
    Friend WithEvents cbReceivePlace As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtDANGER_MARK = New System.Windows.Forms.TextBox()
        Me.txtOverBefore = New System.Windows.Forms.TextBox()
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
        Me.txtDANGER_GRADE = New System.Windows.Forms.TextBox()
        Me.txtTempMin = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtDANGER_NO = New System.Windows.Forms.TextBox()
        Me.txtDANGER_PAGENO = New System.Windows.Forms.TextBox()
        Me.txtTempSet = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.cbGoodsCode = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtMark = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBillNO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtGOODS_CHA = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtKeeper = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtGOODS_ENG = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtContainerSize = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSealNo = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtContainerNo = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtOverRight = New System.Windows.Forms.TextBox()
        Me.txtOverLeft = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtOverHeight = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.cbKeeperCode = New System.Windows.Forms.ComboBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.cbShortUnload = New System.Windows.Forms.ComboBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.cbPassMark = New System.Windows.Forms.ComboBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtOverBehind = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.cbLoadPortCode = New System.Windows.Forms.ComboBox()
        Me.cbUnloadPortCode = New System.Windows.Forms.ComboBox()
        Me.cbDeliveryCode = New System.Windows.Forms.ComboBox()
        Me.cbState = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBayNo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbTempUnit = New System.Windows.Forms.ComboBox()
        Me.cbCompanyCode = New System.Windows.Forms.ComboBox()
        Me.txtLOAD_PORT = New System.Windows.Forms.TextBox()
        Me.txtUNLOAD_PORT = New System.Windows.Forms.TextBox()
        Me.txtDelivery = New System.Windows.Forms.TextBox()
        Me.cbUnloadPort = New System.Windows.Forms.ComboBox()
        Me.cbLoadPort = New System.Windows.Forms.ComboBox()
        Me.cbReceivePlace = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(214, 296)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 18)
        Me.Label29.TabIndex = 389
        Me.Label29.Text = "��������"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(424, 186)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(72, 18)
        Me.Label34.TabIndex = 402
        Me.Label34.Text = "Σ��Ʒ��ǩ"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDANGER_MARK
        '
        Me.txtDANGER_MARK.Location = New System.Drawing.Point(498, 184)
        Me.txtDANGER_MARK.MaxLength = 32
        Me.txtDANGER_MARK.Name = "txtDANGER_MARK"
        Me.txtDANGER_MARK.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_MARK.TabIndex = 32
        Me.txtDANGER_MARK.Text = ""
        '
        'txtOverBefore
        '
        Me.txtOverBefore.Location = New System.Drawing.Point(498, 72)
        Me.txtOverBefore.MaxLength = 20
        Me.txtOverBefore.Name = "txtOverBefore"
        Me.txtOverBefore.Size = New System.Drawing.Size(130, 21)
        Me.txtOverBefore.TabIndex = 27
        Me.txtOverBefore.Text = ""
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(424, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 18)
        Me.Label16.TabIndex = 398
        Me.Label16.Text = "ǰ��"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(214, 248)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 18)
        Me.Label15.TabIndex = 394
        Me.Label15.Text = "�¶ȵ�λ"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(288, 150)
        Me.txtAmount.MaxLength = 20
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(130, 21)
        Me.txtAmount.TabIndex = 16
        Me.txtAmount.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(214, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 382
        Me.Label10.Text = "����"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVolume
        '
        Me.txtVolume.Location = New System.Drawing.Point(288, 222)
        Me.txtVolume.MaxLength = 20
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.Size = New System.Drawing.Size(130, 21)
        Me.txtVolume.TabIndex = 19
        Me.txtVolume.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(214, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 377
        Me.Label5.Text = "����ߴ�"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTempMax
        '
        Me.txtTempMax.Location = New System.Drawing.Point(288, 318)
        Me.txtTempMax.MaxLength = 20
        Me.txtTempMax.Name = "txtTempMax"
        Me.txtTempMax.Size = New System.Drawing.Size(130, 21)
        Me.txtTempMax.TabIndex = 23
        Me.txtTempMax.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(214, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 376
        Me.Label3.Text = "��������"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGROSSWEIGHT
        '
        Me.txtGROSSWEIGHT.Location = New System.Drawing.Point(288, 174)
        Me.txtGROSSWEIGHT.MaxLength = 20
        Me.txtGROSSWEIGHT.Name = "txtGROSSWEIGHT"
        Me.txtGROSSWEIGHT.Size = New System.Drawing.Size(130, 21)
        Me.txtGROSSWEIGHT.TabIndex = 17
        Me.txtGROSSWEIGHT.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(214, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 371
        Me.Label1.Text = "��ë��"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTAREWEIGHT
        '
        Me.txtTAREWEIGHT.Location = New System.Drawing.Point(288, 198)
        Me.txtTAREWEIGHT.MaxLength = 20
        Me.txtTAREWEIGHT.Name = "txtTAREWEIGHT"
        Me.txtTAREWEIGHT.Size = New System.Drawing.Size(130, 21)
        Me.txtTAREWEIGHT.TabIndex = 18
        Me.txtTAREWEIGHT.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(214, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 370
        Me.Label2.Text = "��Ƥ��"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(424, 164)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 18)
        Me.Label26.TabIndex = 392
        Me.Label26.Text = "Σ��Ʒ���"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(424, 142)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 18)
        Me.Label27.TabIndex = 395
        Me.Label27.Text = "Σ��Ʒҳ��"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDANGER_GRADE
        '
        Me.txtDANGER_GRADE.Location = New System.Drawing.Point(498, 118)
        Me.txtDANGER_GRADE.MaxLength = 10
        Me.txtDANGER_GRADE.Name = "txtDANGER_GRADE"
        Me.txtDANGER_GRADE.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_GRADE.TabIndex = 29
        Me.txtDANGER_GRADE.Text = ""
        '
        'txtTempMin
        '
        Me.txtTempMin.Location = New System.Drawing.Point(288, 294)
        Me.txtTempMin.MaxLength = 20
        Me.txtTempMin.Name = "txtTempMin"
        Me.txtTempMin.Size = New System.Drawing.Size(130, 21)
        Me.txtTempMin.TabIndex = 22
        Me.txtTempMin.Text = ""
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(424, 120)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(72, 18)
        Me.Label30.TabIndex = 375
        Me.Label30.Text = "Σ��Ʒ�ȼ�"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtDANGER_NO
        '
        Me.txtDANGER_NO.Location = New System.Drawing.Point(498, 162)
        Me.txtDANGER_NO.MaxLength = 10
        Me.txtDANGER_NO.Name = "txtDANGER_NO"
        Me.txtDANGER_NO.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_NO.TabIndex = 31
        Me.txtDANGER_NO.Text = ""
        '
        'txtDANGER_PAGENO
        '
        Me.txtDANGER_PAGENO.Location = New System.Drawing.Point(498, 140)
        Me.txtDANGER_PAGENO.MaxLength = 20
        Me.txtDANGER_PAGENO.Name = "txtDANGER_PAGENO"
        Me.txtDANGER_PAGENO.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_PAGENO.TabIndex = 30
        Me.txtDANGER_PAGENO.Text = ""
        '
        'txtTempSet
        '
        Me.txtTempSet.Location = New System.Drawing.Point(288, 270)
        Me.txtTempSet.MaxLength = 20
        Me.txtTempSet.Name = "txtTempSet"
        Me.txtTempSet.Size = New System.Drawing.Size(130, 21)
        Me.txtTempSet.TabIndex = 21
        Me.txtTempSet.Text = ""
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(214, 272)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(72, 18)
        Me.Label31.TabIndex = 387
        Me.Label31.Text = "�����¶�"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(354, 346)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 41
        Me.btQuit.Text = "ȡ��"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(286, 346)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 40
        Me.btSave.Text = "ȷ��"
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(218, 346)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(65, 24)
        Me.btAdd.TabIndex = 39
        Me.btAdd.Text = "���"
        '
        'cbGoodsCode
        '
        Me.cbGoodsCode.Items.AddRange(New Object() {"����״̬", "�ڿ�", "����", "����", "ע��"})
        Me.cbGoodsCode.Location = New System.Drawing.Point(78, 150)
        Me.cbGoodsCode.MaxDropDownItems = 20
        Me.cbGoodsCode.Name = "cbGoodsCode"
        Me.cbGoodsCode.Size = New System.Drawing.Size(130, 20)
        Me.cbGoodsCode.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(4, 152)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 18)
        Me.Label17.TabIndex = 399
        Me.Label17.Text = "��������"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(78, 174)
        Me.txtMark.MaxLength = 35
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(130, 21)
        Me.txtMark.TabIndex = 7
        Me.txtMark.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(4, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 380
        Me.Label9.Text = "��־"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBillNO
        '
        Me.txtBillNO.Location = New System.Drawing.Point(78, 126)
        Me.txtBillNO.MaxLength = 20
        Me.txtBillNO.Name = "txtBillNO"
        Me.txtBillNO.Size = New System.Drawing.Size(130, 21)
        Me.txtBillNO.TabIndex = 5
        Me.txtBillNO.Text = ""
        '
        'Label4
        '
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(4, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 378
        Me.Label4.Text = "�ᵥ��"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 369
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(2, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 18)
        Me.Label7.TabIndex = 396
        Me.Label7.Text = "������������"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGOODS_CHA
        '
        Me.txtGOODS_CHA.Location = New System.Drawing.Point(6, 218)
        Me.txtGOODS_CHA.MaxLength = 30
        Me.txtGOODS_CHA.Multiline = True
        Me.txtGOODS_CHA.Name = "txtGOODS_CHA"
        Me.txtGOODS_CHA.Size = New System.Drawing.Size(200, 48)
        Me.txtGOODS_CHA.TabIndex = 8
        Me.txtGOODS_CHA.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(2, 270)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 18)
        Me.Label8.TabIndex = 393
        Me.Label8.Text = "����Ӣ������"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(498, 228)
        Me.txtCompany.MaxLength = 30
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(130, 21)
        Me.txtCompany.TabIndex = 34
        Me.txtCompany.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(424, 230)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 18)
        Me.Label12.TabIndex = 388
        Me.Label12.Text = "�乫˾����"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(424, 208)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 18)
        Me.Label13.TabIndex = 383
        Me.Label13.Text = "�乫˾����"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtKeeper
        '
        Me.txtKeeper.Location = New System.Drawing.Point(498, 272)
        Me.txtKeeper.MaxLength = 20
        Me.txtKeeper.Name = "txtKeeper"
        Me.txtKeeper.Size = New System.Drawing.Size(130, 21)
        Me.txtKeeper.TabIndex = 36
        Me.txtKeeper.Text = ""
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(424, 274)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 18)
        Me.Label19.TabIndex = 373
        Me.Label19.Text = "�侭Ӫ��"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGOODS_ENG
        '
        Me.txtGOODS_ENG.Location = New System.Drawing.Point(6, 290)
        Me.txtGOODS_ENG.MaxLength = 30
        Me.txtGOODS_ENG.Multiline = True
        Me.txtGOODS_ENG.Name = "txtGOODS_ENG"
        Me.txtGOODS_ENG.Size = New System.Drawing.Size(200, 48)
        Me.txtGOODS_ENG.TabIndex = 9
        Me.txtGOODS_ENG.Text = ""
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(214, 128)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 18)
        Me.Label20.TabIndex = 386
        Me.Label20.Text = "������"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(214, 104)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 18)
        Me.Label21.TabIndex = 381
        Me.Label21.Text = "�����ش���"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(214, 56)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 18)
        Me.Label22.TabIndex = 397
        Me.Label22.Text = "ж���۴���"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(214, 8)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 18)
        Me.Label23.TabIndex = 374
        Me.Label23.Text = "װ���۴���"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(214, 32)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 18)
        Me.Label24.TabIndex = 391
        Me.Label24.Text = "װ����"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(214, 80)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(72, 18)
        Me.Label32.TabIndex = 385
        Me.Label32.Text = "ж����"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtContainerSize
        '
        Me.txtContainerSize.Location = New System.Drawing.Point(78, 30)
        Me.txtContainerSize.MaxLength = 20
        Me.txtContainerSize.Name = "txtContainerSize"
        Me.txtContainerSize.Size = New System.Drawing.Size(130, 21)
        Me.txtContainerSize.TabIndex = 1
        Me.txtContainerSize.Text = ""
        '
        'Label11
        '
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.Location = New System.Drawing.Point(4, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 18)
        Me.Label11.TabIndex = 404
        Me.Label11.Text = "��ߴ�"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSealNo
        '
        Me.txtSealNo.Location = New System.Drawing.Point(78, 78)
        Me.txtSealNo.MaxLength = 20
        Me.txtSealNo.Name = "txtSealNo"
        Me.txtSealNo.Size = New System.Drawing.Size(130, 21)
        Me.txtSealNo.TabIndex = 3
        Me.txtSealNo.Text = ""
        '
        'Label35
        '
        Me.Label35.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label35.Location = New System.Drawing.Point(4, 80)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(72, 18)
        Me.Label35.TabIndex = 404
        Me.Label35.Text = "Ǧ���"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtContainerNo
        '
        Me.txtContainerNo.Location = New System.Drawing.Point(78, 6)
        Me.txtContainerNo.MaxLength = 11
        Me.txtContainerNo.Name = "txtContainerNo"
        Me.txtContainerNo.Size = New System.Drawing.Size(130, 21)
        Me.txtContainerNo.TabIndex = 0
        Me.txtContainerNo.Text = ""
        '
        'Label36
        '
        Me.Label36.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label36.Location = New System.Drawing.Point(4, 8)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 18)
        Me.Label36.TabIndex = 404
        Me.Label36.Text = "��װ���"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOverRight
        '
        Me.txtOverRight.Location = New System.Drawing.Point(498, 50)
        Me.txtOverRight.MaxLength = 20
        Me.txtOverRight.Name = "txtOverRight"
        Me.txtOverRight.Size = New System.Drawing.Size(130, 21)
        Me.txtOverRight.TabIndex = 26
        Me.txtOverRight.Text = ""
        '
        'txtOverLeft
        '
        Me.txtOverLeft.Location = New System.Drawing.Point(498, 28)
        Me.txtOverLeft.MaxLength = 20
        Me.txtOverLeft.Name = "txtOverLeft"
        Me.txtOverLeft.Size = New System.Drawing.Size(130, 21)
        Me.txtOverLeft.TabIndex = 25
        Me.txtOverLeft.Text = ""
        '
        'Label37
        '
        Me.Label37.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label37.Location = New System.Drawing.Point(424, 30)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(72, 18)
        Me.Label37.TabIndex = 404
        Me.Label37.Text = "��"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOverHeight
        '
        Me.txtOverHeight.Location = New System.Drawing.Point(498, 6)
        Me.txtOverHeight.MaxLength = 20
        Me.txtOverHeight.Name = "txtOverHeight"
        Me.txtOverHeight.Size = New System.Drawing.Size(130, 21)
        Me.txtOverHeight.TabIndex = 24
        Me.txtOverHeight.Text = ""
        '
        'Label38
        '
        Me.Label38.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label38.Location = New System.Drawing.Point(424, 8)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(72, 18)
        Me.Label38.TabIndex = 404
        Me.Label38.Text = "����"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label39
        '
        Me.Label39.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label39.Location = New System.Drawing.Point(424, 52)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(72, 18)
        Me.Label39.TabIndex = 404
        Me.Label39.Text = "�ҳ�"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbKeeperCode
        '
        Me.cbKeeperCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbKeeperCode.Items.AddRange(New Object() {"����״̬", "�ڿ�", "����", "����", "ע��"})
        Me.cbKeeperCode.Location = New System.Drawing.Point(498, 250)
        Me.cbKeeperCode.MaxLength = 2
        Me.cbKeeperCode.Name = "cbKeeperCode"
        Me.cbKeeperCode.Size = New System.Drawing.Size(130, 20)
        Me.cbKeeperCode.TabIndex = 35
        '
        'Label40
        '
        Me.Label40.Location = New System.Drawing.Point(424, 252)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(72, 18)
        Me.Label40.TabIndex = 406
        Me.Label40.Text = "�侭Ӫ����"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbShortUnload
        '
        Me.cbShortUnload.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbShortUnload.Items.AddRange(New Object() {"����״̬", "�ڿ�", "����", "����", "ע��"})
        Me.cbShortUnload.Location = New System.Drawing.Point(498, 320)
        Me.cbShortUnload.MaxLength = 2
        Me.cbShortUnload.Name = "cbShortUnload"
        Me.cbShortUnload.Size = New System.Drawing.Size(130, 20)
        Me.cbShortUnload.TabIndex = 38
        '
        'Label41
        '
        Me.Label41.Location = New System.Drawing.Point(424, 322)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(72, 18)
        Me.Label41.TabIndex = 408
        Me.Label41.Text = "˦���ж"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbPassMark
        '
        Me.cbPassMark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbPassMark.Items.AddRange(New Object() {"����״̬", "�ڿ�", "����", "����", "ע��"})
        Me.cbPassMark.Location = New System.Drawing.Point(498, 296)
        Me.cbPassMark.MaxLength = 1
        Me.cbPassMark.Name = "cbPassMark"
        Me.cbPassMark.Size = New System.Drawing.Size(130, 20)
        Me.cbPassMark.TabIndex = 37
        '
        'Label42
        '
        Me.Label42.Location = New System.Drawing.Point(424, 298)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(72, 18)
        Me.Label42.TabIndex = 410
        Me.Label42.Text = "ͨ�ر�ʶ"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtOverBehind
        '
        Me.txtOverBehind.Location = New System.Drawing.Point(498, 94)
        Me.txtOverBehind.MaxLength = 20
        Me.txtOverBehind.Name = "txtOverBehind"
        Me.txtOverBehind.Size = New System.Drawing.Size(130, 21)
        Me.txtOverBehind.TabIndex = 28
        Me.txtOverBehind.Text = ""
        '
        'Label43
        '
        Me.Label43.Location = New System.Drawing.Point(424, 96)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(72, 18)
        Me.Label43.TabIndex = 412
        Me.Label43.Text = "��"
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbLoadPortCode
        '
        Me.cbLoadPortCode.Items.AddRange(New Object() {"����״̬", "�ڿ�", "����", "����", "ע��"})
        Me.cbLoadPortCode.Location = New System.Drawing.Point(288, 6)
        Me.cbLoadPortCode.MaxDropDownItems = 20
        Me.cbLoadPortCode.Name = "cbLoadPortCode"
        Me.cbLoadPortCode.Size = New System.Drawing.Size(130, 20)
        Me.cbLoadPortCode.TabIndex = 10
        '
        'cbUnloadPortCode
        '
        Me.cbUnloadPortCode.Items.AddRange(New Object() {"����״̬", "�ڿ�", "����", "����", "ע��"})
        Me.cbUnloadPortCode.Location = New System.Drawing.Point(288, 54)
        Me.cbUnloadPortCode.MaxDropDownItems = 20
        Me.cbUnloadPortCode.Name = "cbUnloadPortCode"
        Me.cbUnloadPortCode.Size = New System.Drawing.Size(130, 20)
        Me.cbUnloadPortCode.TabIndex = 12
        '
        'cbDeliveryCode
        '
        Me.cbDeliveryCode.Items.AddRange(New Object() {"����״̬", "�ڿ�", "����", "����", "ע��"})
        Me.cbDeliveryCode.Location = New System.Drawing.Point(288, 102)
        Me.cbDeliveryCode.MaxDropDownItems = 20
        Me.cbDeliveryCode.Name = "cbDeliveryCode"
        Me.cbDeliveryCode.Size = New System.Drawing.Size(130, 20)
        Me.cbDeliveryCode.TabIndex = 14
        '
        'cbState
        '
        Me.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbState.Items.AddRange(New Object() {"����״̬", "�ڿ�", "����", "����", "ע��"})
        Me.cbState.Location = New System.Drawing.Point(78, 54)
        Me.cbState.Name = "cbState"
        Me.cbState.Size = New System.Drawing.Size(130, 20)
        Me.cbState.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(4, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 416
        Me.Label6.Text = "��״̬"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBayNo
        '
        Me.txtBayNo.Location = New System.Drawing.Point(78, 102)
        Me.txtBayNo.MaxLength = 7
        Me.txtBayNo.Name = "txtBayNo"
        Me.txtBayNo.Size = New System.Drawing.Size(130, 21)
        Me.txtBayNo.TabIndex = 4
        Me.txtBayNo.Text = ""
        '
        'Label14
        '
        Me.Label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label14.Location = New System.Drawing.Point(4, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 18)
        Me.Label14.TabIndex = 419
        Me.Label14.Text = "��λ��"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbTempUnit
        '
        Me.cbTempUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTempUnit.Items.AddRange(New Object() {"", "C", "H"})
        Me.cbTempUnit.Location = New System.Drawing.Point(288, 246)
        Me.cbTempUnit.Name = "cbTempUnit"
        Me.cbTempUnit.Size = New System.Drawing.Size(130, 20)
        Me.cbTempUnit.TabIndex = 20
        '
        'cbCompanyCode
        '
        Me.cbCompanyCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbCompanyCode.Items.AddRange(New Object() {"����״̬", "�ڿ�", "����", "����", "ע��"})
        Me.cbCompanyCode.Location = New System.Drawing.Point(498, 208)
        Me.cbCompanyCode.MaxLength = 30
        Me.cbCompanyCode.Name = "cbCompanyCode"
        Me.cbCompanyCode.Size = New System.Drawing.Size(130, 20)
        Me.cbCompanyCode.TabIndex = 33
        '
        'txtLOAD_PORT
        '
        Me.txtLOAD_PORT.Location = New System.Drawing.Point(70, 238)
        Me.txtLOAD_PORT.MaxLength = 35
        Me.txtLOAD_PORT.Name = "txtLOAD_PORT"
        Me.txtLOAD_PORT.Size = New System.Drawing.Size(130, 21)
        Me.txtLOAD_PORT.TabIndex = 11
        Me.txtLOAD_PORT.Text = ""
        Me.txtLOAD_PORT.Visible = False
        '
        'txtUNLOAD_PORT
        '
        Me.txtUNLOAD_PORT.Location = New System.Drawing.Point(70, 286)
        Me.txtUNLOAD_PORT.MaxLength = 35
        Me.txtUNLOAD_PORT.Name = "txtUNLOAD_PORT"
        Me.txtUNLOAD_PORT.Size = New System.Drawing.Size(130, 21)
        Me.txtUNLOAD_PORT.TabIndex = 13
        Me.txtUNLOAD_PORT.Text = ""
        Me.txtUNLOAD_PORT.Visible = False
        '
        'txtDelivery
        '
        Me.txtDelivery.Location = New System.Drawing.Point(70, 334)
        Me.txtDelivery.MaxLength = 70
        Me.txtDelivery.Name = "txtDelivery"
        Me.txtDelivery.Size = New System.Drawing.Size(130, 21)
        Me.txtDelivery.TabIndex = 15
        Me.txtDelivery.Text = ""
        Me.txtDelivery.Visible = False
        '
        'cbUnloadPort
        '
        Me.cbUnloadPort.Location = New System.Drawing.Point(288, 78)
        Me.cbUnloadPort.MaxDropDownItems = 20
        Me.cbUnloadPort.Name = "cbUnloadPort"
        Me.cbUnloadPort.Size = New System.Drawing.Size(130, 20)
        Me.cbUnloadPort.TabIndex = 422
        '
        'cbLoadPort
        '
        Me.cbLoadPort.Location = New System.Drawing.Point(288, 30)
        Me.cbLoadPort.MaxDropDownItems = 20
        Me.cbLoadPort.Name = "cbLoadPort"
        Me.cbLoadPort.Size = New System.Drawing.Size(130, 20)
        Me.cbLoadPort.TabIndex = 421
        '
        'cbReceivePlace
        '
        Me.cbReceivePlace.Location = New System.Drawing.Point(288, 126)
        Me.cbReceivePlace.MaxDropDownItems = 20
        Me.cbReceivePlace.Name = "cbReceivePlace"
        Me.cbReceivePlace.Size = New System.Drawing.Size(130, 20)
        Me.cbReceivePlace.TabIndex = 420
        '
        'FrmConImageCargo_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(634, 375)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbUnloadPort, Me.cbLoadPort, Me.cbReceivePlace, Me.cbPassMark, Me.cbShortUnload, Me.cbKeeperCode, Me.txtKeeper, Me.cbCompanyCode, Me.txtOverBehind, Me.txtDANGER_MARK, Me.txtOverBefore, Me.txtDANGER_GRADE, Me.txtDANGER_NO, Me.txtDANGER_PAGENO, Me.txtOverRight, Me.txtOverLeft, Me.txtOverHeight, Me.cbTempUnit, Me.txtBayNo, Me.Label14, Me.cbState, Me.Label6, Me.cbDeliveryCode, Me.cbUnloadPortCode, Me.cbLoadPortCode, Me.txtContainerSize, Me.Label11, Me.txtSealNo, Me.Label35, Me.txtContainerNo, Me.Label36, Me.Label43, Me.Label42, Me.Label41, Me.Label40, Me.Label29, Me.Label34, Me.Label16, Me.Label15, Me.txtAmount, Me.Label10, Me.txtVolume, Me.Label5, Me.txtTempMax, Me.Label3, Me.txtGROSSWEIGHT, Me.Label1, Me.txtTAREWEIGHT, Me.Label2, Me.Label26, Me.Label27, Me.txtTempMin, Me.Label30, Me.txtTempSet, Me.Label31, Me.btQuit, Me.btSave, Me.btAdd, Me.cbGoodsCode, Me.Label17, Me.txtMark, Me.Label9, Me.txtBillNO, Me.Label4, Me.Label7, Me.Label8, Me.Label12, Me.Label13, Me.Label19, Me.txtDelivery, Me.Label20, Me.Label21, Me.Label22, Me.Label23, Me.Label24, Me.txtLOAD_PORT, Me.txtUNLOAD_PORT, Me.Label32, Me.Label37, Me.Label38, Me.Label39, Me.txtID, Me.txtCompany, Me.txtGOODS_ENG, Me.txtGOODS_CHA})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConImageCargo_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "��װ����ڴ�ͼ��Ϣ ����"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim sqlGetPortName As String
    Dim dvTemp As New DataView()

    Private Sub FrmConImageCargo_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Dim dwCodeGoods As New DataView()
        Dim sqlCodeGoods As String

        Dim dvState As New DataView()
        Dim dvLoadPort As New DataView()
        Dim dvUnloadPort As New DataView()
        Dim dvDelivery As New DataView()
        Dim sqlConState, sqlPort, sqlDelivery As String

        sqlConState = "SELECT EFL_Code, EFL_Name FROM Code_ConEFLType"
            dvState = Filldata(sqlConState)
            Me.cbState.DataSource = dvState
            Me.cbState.DisplayMember = "EFL_Name"
            Me.cbState.ValueMember = "EFL_Code"
            'Me.cbState.Items.Add("aaa")

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
            If FrmConHatchCargo.InOutCode = "0" Then    'in
                Me.cbUnloadPort.SelectedValue = "LYG"
            ElseIf FrmConHatchCargo.InOutCode = "1" Then    'out
                Me.cbLoadPort.SelectedValue = "LYG"
            End If

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim sqlUnique As String
        Try
            If Trim(Me.txtContainerNo.Text) <> "" And Trim(Me.txtBayNo.Text) <> "" And Me.cbState.SelectedValue <> "0" Then
                row = ds.Tables(0).NewRow()

                If Me.SetNumValue("CONTAINER", txtContainerSize.Text, "��ߴ�") = False Then
                    txtContainerSize.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("AMOUNT", txtAmount.Text, "����") = False Then
                    txtAmount.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("GROSSWEIGHT", txtGROSSWEIGHT.Text, "��ë��") = False Then
                    Me.txtGROSSWEIGHT.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("TAREWEIGHT", txtTAREWEIGHT.Text, "��Ƥ��") = False Then
                    Me.txtTAREWEIGHT.Focus()
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
                ElseIf Me.SetNumValue("OVER_HEIGHT", txtOverHeight.Text, "����") = False Then
                    Me.txtOverHeight.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("OVER_LEFT", txtOverLeft.Text, "��") = False Then
                    Me.txtOverLeft.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("OVER_RIGHT", txtOverRight.Text, "�ҳ�") = False Then
                    Me.txtOverRight.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("OVER_BEFORE", txtOverBefore.Text, "ǰ��") = False Then
                    Me.txtOverBefore.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("OVER_BEHIND", txtOverBehind.Text, "��") = False Then
                    Me.txtOverBehind.Focus()
                    Exit Sub
                ElseIf Me.SetNumValue("DANGER_PAGENO", txtDANGER_PAGENO.Text, "Σ��Ʒҳ��") = False Then
                    Me.txtDANGER_PAGENO.Focus()
                    Exit Sub
                End If

                sqlUnique = "SELECT * FROM CON_IMAGE_RECORD WHERE SHIP_ID = '" & Ship_ID & "' AND ( CONTAINER_NO = '" & Trim(Me.txtContainerNo.Text) & "' or BAYNO = '" & Trim(Me.txtBayNo.Text) & "' )"
                If Filldata(sqlUnique).Count = 0 Then
                    row.Item("CONTAINER_NO") = Trim(Me.txtContainerNo.Text)
                    row.Item("SEALNO") = Trim(Me.txtSealNo.Text)
                    row.Item("BAYNO") = Trim(Me.txtBayNo.Text)
                    row.Item("BLNO") = Trim(Me.txtBillNO.Text)
                    row.Item("MARK") = Trim(Me.txtMark.Text)
                    row.Item("GOODS_ENG") = Trim(Me.txtGOODS_ENG.Text)
                    row.Item("GOODS_CHA") = Trim(Me.txtGOODS_CHA.Text)
                    row.Item("LOAD_PORT") = Trim(Me.txtLOAD_PORT.Text)
                    row.Item("UNLOAD_PORT") = Trim(Me.txtUNLOAD_PORT.Text)
                    row.Item("DELIVERY") = Trim(Me.txtDelivery.Text)


                    row.Item("DANGER_GRADE") = Trim(Me.txtDANGER_GRADE.Text)
                    row.Item("DANGER_NO") = Trim(Me.txtDANGER_NO.Text)
                    row.Item("DANGER_MARK") = Trim(Me.txtDANGER_MARK.Text)
                    row.Item("MANUFACTURER") = Trim(Me.txtCompany.Text)
                    row.Item("KEEPER") = Trim(Me.txtKeeper.Text)

                    row.Item("FULLOREMPTY") = Me.cbState.SelectedValue
                    row.Item("CODE_GOODS") = Me.cbGoodsCode.SelectedValue
                    row.Item("CODE_LOAD_PORT") = Me.cbLoadPortCode.SelectedValue
                    row.Item("CODE_UNLOAD_PORT") = Me.cbUnloadPortCode.SelectedValue
                    row.Item("CODE_DELIVERY") = Me.cbDeliveryCode.SelectedValue
                    row.Item("TEMPERATURE_UNIT") = Trim(Me.cbTempUnit.Text)
                    row.Item("CODE_MANUFACTURER") = Trim(Me.cbCompanyCode.Text)
                    row.Item("CODE_KEEPER") = Trim(Me.cbKeeperCode.Text)
                    row.Item("PASS_MARK") = Trim(Me.cbPassMark.Text)
                    row.Item("SHORT_UNLOAD") = Trim(Me.cbShortUnload.Text)

                    row.Item("SHIP_ID") = Ship_ID
                    row.Item("USER_NAME") = G_User

                    ds.Tables(0).Rows.Add(row)
                    sqlda.Update(ds)
                    Me.Close()
                Else
                    MessageBox.Show("ͬһ���� ��װ��� ��λ�� �����ظ�", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("��װ��� ��״̬ ��λ�� ����Ϊ��", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function CheckConNO(ByVal sm As String) As Integer 'return 0 ����д� 1 У���д� 2 У����ȷ
        Dim S() As Integer = {10, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 34, 35, 36, 37, 38}
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim l As Integer
        i = 0
        str = sm
        If Len(Trim(sm)) = 12 And Mid(Trim(sm), 5, 1) = " " Then
            str = Mid(Trim(sm), 1, 4) & Mid(Trim(sm), 6, 7)
        ElseIf Len(Trim(sm)) <> 11 Then
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
        Me.txtCompany.Clear()
        Me.txtContainerNo.Clear()
        Me.txtContainerSize.Clear()
        Me.txtDANGER_GRADE.Clear()
        Me.txtDANGER_MARK.Clear()
        Me.txtDANGER_NO.Clear()
        Me.txtDANGER_PAGENO.Clear()
        Me.txtDelivery.Clear()
        Me.txtGOODS_CHA.Clear()
        Me.txtGOODS_ENG.Clear()
        Me.txtGROSSWEIGHT.Clear()
        Me.txtKeeper.Clear()
        Me.txtLOAD_PORT.Clear()
        Me.txtMark.Clear()
        Me.txtOverBefore.Clear()
        Me.txtOverBehind.Clear()
        Me.txtOverHeight.Clear()
        Me.txtOverLeft.Clear()
        Me.txtOverRight.Clear()
        Me.txtSealNo.Clear()
        Me.txtTAREWEIGHT.Clear()
        Me.txtTempMax.Clear()
        Me.txtTempMin.Clear()
        Me.txtTempSet.Clear()
        Me.txtUNLOAD_PORT.Clear()
        Me.txtVolume.Clear()

        Me.cbDeliveryCode.SelectedValue = ""
        Me.cbGoodsCode.SelectedValue = ""
        Me.cbUnloadPortCode.SelectedValue = ""
        Me.cbLoadPortCode.SelectedValue = ""
        Me.cbState.SelectedValue = ""

        Me.cbCompanyCode.Text = ""
        Me.cbPassMark.Text = ""
        Me.cbShortUnload.Text = ""
        Me.cbTempUnit.Text = ""
        Me.cbKeeperCode.Text = ""
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub cbLoadPortCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbLoadPortCode.SelectedIndexChanged
        Try
            If TypeName(Me.cbLoadPortCode.SelectedValue) = "String" Then
                sqlGetPortName = "SELECT CODE_PORT, PORT_CHA FROM CODE_PORT where CODE_PORT = '" & Me.cbLoadPortCode.SelectedValue & "'"
                dvTemp = Filldata(sqlGetPortName)
                If dvTemp.Count > 0 Then
                    Me.txtLOAD_PORT.Text = dvTemp.Item(0)(1)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbUnloadPortCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbUnloadPortCode.SelectedIndexChanged
        Try
            If TypeName(Me.cbUnloadPortCode.SelectedValue) = "String" Then
                sqlGetPortName = "SELECT CODE_PORT, PORT_CHA FROM CODE_PORT where CODE_PORT = '" & Me.cbUnloadPortCode.SelectedValue & "'"
                dvTemp = Filldata(sqlGetPortName)
                If dvTemp.Count > 0 Then
                    Me.txtUNLOAD_PORT.Text = dvTemp.Item(0)(1)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbDeliveryCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDeliveryCode.SelectedIndexChanged
        Try
            If TypeName(Me.cbDeliveryCode.SelectedValue) = "String" Then
                sqlGetPortName = "SELECT CODE_PORT, PORT_CHA FROM CODE_PORT where CODE_PORT = '" & Me.cbDeliveryCode.SelectedValue & "'"
                dvTemp = Filldata(sqlGetPortName)
                If dvTemp.Count > 0 Then
                    Me.txtDelivery.Text = dvTemp.Item(0)(1)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
