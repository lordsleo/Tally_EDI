Imports TALLY.DBControl
Public Class FrmConImageCargo_Deleteg
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()

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
        Me.SuspendLayout()
        '
        'txtDANGER_MARK
        '
        Me.txtDANGER_MARK.Location = New System.Drawing.Point(288, 246)
        Me.txtDANGER_MARK.MaxLength = 32
        Me.txtDANGER_MARK.Name = "txtDANGER_MARK"
        Me.txtDANGER_MARK.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_MARK.TabIndex = 571
        Me.txtDANGER_MARK.Text = ""
        '
        'txtDANGER_GRADE
        '
        Me.txtDANGER_GRADE.Location = New System.Drawing.Point(288, 174)
        Me.txtDANGER_GRADE.MaxLength = 10
        Me.txtDANGER_GRADE.Name = "txtDANGER_GRADE"
        Me.txtDANGER_GRADE.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_GRADE.TabIndex = 568
        Me.txtDANGER_GRADE.Text = ""
        '
        'txtDANGER_NO
        '
        Me.txtDANGER_NO.Location = New System.Drawing.Point(288, 222)
        Me.txtDANGER_NO.MaxLength = 10
        Me.txtDANGER_NO.Name = "txtDANGER_NO"
        Me.txtDANGER_NO.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_NO.TabIndex = 570
        Me.txtDANGER_NO.Text = ""
        '
        'txtDANGER_PAGENO
        '
        Me.txtDANGER_PAGENO.Location = New System.Drawing.Point(288, 198)
        Me.txtDANGER_PAGENO.MaxLength = 20
        Me.txtDANGER_PAGENO.Name = "txtDANGER_PAGENO"
        Me.txtDANGER_PAGENO.Size = New System.Drawing.Size(130, 21)
        Me.txtDANGER_PAGENO.TabIndex = 569
        Me.txtDANGER_PAGENO.Text = ""
        '
        'cbTempUnit
        '
        Me.cbTempUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTempUnit.Items.AddRange(New Object() {"", "C", "F"})
        Me.cbTempUnit.Location = New System.Drawing.Point(288, 78)
        Me.cbTempUnit.Name = "cbTempUnit"
        Me.cbTempUnit.Size = New System.Drawing.Size(130, 20)
        Me.cbTempUnit.TabIndex = 564
        '
        'txtBayNo
        '
        Me.txtBayNo.Location = New System.Drawing.Point(78, 78)
        Me.txtBayNo.MaxLength = 7
        Me.txtBayNo.Name = "txtBayNo"
        Me.txtBayNo.Size = New System.Drawing.Size(130, 21)
        Me.txtBayNo.TabIndex = 553
        Me.txtBayNo.Text = ""
        '
        'Label14
        '
        Me.Label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label14.Location = New System.Drawing.Point(4, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 18)
        Me.Label14.TabIndex = 596
        Me.Label14.Text = "��λ��"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbState
        '
        Me.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbState.Items.AddRange(New Object() {"����״̬", "�ڿ�", "����", "����", "ע��"})
        Me.cbState.Location = New System.Drawing.Point(78, 30)
        Me.cbState.Name = "cbState"
        Me.cbState.Size = New System.Drawing.Size(130, 20)
        Me.cbState.TabIndex = 551
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(4, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 595
        Me.Label6.Text = "��״̬"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbDelivery
        '
        Me.cbDelivery.Items.AddRange(New Object() {"����״̬", "�ڿ�", "����", "����", "ע��"})
        Me.cbDelivery.Location = New System.Drawing.Point(78, 222)
        Me.cbDelivery.MaxDropDownItems = 20
        Me.cbDelivery.Name = "cbDelivery"
        Me.cbDelivery.Size = New System.Drawing.Size(130, 20)
        Me.cbDelivery.TabIndex = 559
        '
        'cbUnloadPort
        '
        Me.cbUnloadPort.Items.AddRange(New Object() {"����״̬", "�ڿ�", "����", "����", "ע��"})
        Me.cbUnloadPort.Location = New System.Drawing.Point(78, 174)
        Me.cbUnloadPort.MaxDropDownItems = 20
        Me.cbUnloadPort.Name = "cbUnloadPort"
        Me.cbUnloadPort.Size = New System.Drawing.Size(130, 20)
        Me.cbUnloadPort.TabIndex = 557
        '
        'cbLoadPort
        '
        Me.cbLoadPort.Items.AddRange(New Object() {"����״̬", "�ڿ�", "����", "����", "ע��"})
        Me.cbLoadPort.Location = New System.Drawing.Point(78, 126)
        Me.cbLoadPort.MaxDropDownItems = 20
        Me.cbLoadPort.Name = "cbLoadPort"
        Me.cbLoadPort.Size = New System.Drawing.Size(130, 20)
        Me.cbLoadPort.TabIndex = 555
        '
        'txtSealNo
        '
        Me.txtSealNo.Location = New System.Drawing.Point(78, 54)
        Me.txtSealNo.MaxLength = 20
        Me.txtSealNo.Name = "txtSealNo"
        Me.txtSealNo.Size = New System.Drawing.Size(130, 21)
        Me.txtSealNo.TabIndex = 552
        Me.txtSealNo.Text = ""
        '
        'Label35
        '
        Me.Label35.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label35.Location = New System.Drawing.Point(4, 56)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(72, 18)
        Me.Label35.TabIndex = 593
        Me.Label35.Text = "Ǧ���"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtContainerNo
        '
        Me.txtContainerNo.Location = New System.Drawing.Point(78, 6)
        Me.txtContainerNo.MaxLength = 12
        Me.txtContainerNo.Name = "txtContainerNo"
        Me.txtContainerNo.Size = New System.Drawing.Size(130, 21)
        Me.txtContainerNo.TabIndex = 550
        Me.txtContainerNo.Text = ""
        '
        'Label36
        '
        Me.Label36.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label36.Location = New System.Drawing.Point(4, 8)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 18)
        Me.Label36.TabIndex = 594
        Me.Label36.Text = "��װ���"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(214, 128)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 18)
        Me.Label29.TabIndex = 586
        Me.Label29.Text = "��������"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(214, 248)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(72, 18)
        Me.Label34.TabIndex = 592
        Me.Label34.Text = "Σ��Ʒ��ǩ"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(214, 80)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 18)
        Me.Label15.TabIndex = 589
        Me.Label15.Text = "�¶ȵ�λ"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(288, 6)
        Me.txtAmount.MaxLength = 20
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(130, 21)
        Me.txtAmount.TabIndex = 561
        Me.txtAmount.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(214, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 18)
        Me.Label10.TabIndex = 582
        Me.Label10.Text = "����"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVolume
        '
        Me.txtVolume.Location = New System.Drawing.Point(288, 54)
        Me.txtVolume.MaxLength = 20
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.TabIndex = 563
        Me.txtVolume.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(214, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 579
        Me.Label5.Text = "����ߴ�"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTempMax
        '
        Me.txtTempMax.Location = New System.Drawing.Point(288, 150)
        Me.txtTempMax.MaxLength = 20
        Me.txtTempMax.Name = "txtTempMax"
        Me.txtTempMax.Size = New System.Drawing.Size(130, 21)
        Me.txtTempMax.TabIndex = 567
        Me.txtTempMax.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(214, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 578
        Me.Label3.Text = "��������"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGROSSWEIGHT
        '
        Me.txtGROSSWEIGHT.Location = New System.Drawing.Point(288, 30)
        Me.txtGROSSWEIGHT.MaxLength = 20
        Me.txtGROSSWEIGHT.Name = "txtGROSSWEIGHT"
        Me.txtGROSSWEIGHT.TabIndex = 562
        Me.txtGROSSWEIGHT.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(214, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 575
        Me.Label1.Text = "��ë��"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(214, 224)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(72, 18)
        Me.Label26.TabIndex = 588
        Me.Label26.Text = "Σ��Ʒ���"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(214, 200)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 18)
        Me.Label27.TabIndex = 590
        Me.Label27.Text = "Σ��Ʒҳ��"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTempMin
        '
        Me.txtTempMin.Location = New System.Drawing.Point(288, 126)
        Me.txtTempMin.MaxLength = 20
        Me.txtTempMin.Name = "txtTempMin"
        Me.txtTempMin.Size = New System.Drawing.Size(130, 21)
        Me.txtTempMin.TabIndex = 566
        Me.txtTempMin.Text = ""
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(214, 176)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(72, 18)
        Me.Label30.TabIndex = 577
        Me.Label30.Text = "Σ��Ʒ�ȼ�"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTempSet
        '
        Me.txtTempSet.Location = New System.Drawing.Point(288, 102)
        Me.txtTempSet.MaxLength = 20
        Me.txtTempSet.Name = "txtTempSet"
        Me.txtTempSet.Size = New System.Drawing.Size(130, 21)
        Me.txtTempSet.TabIndex = 565
        Me.txtTempSet.Text = ""
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(214, 104)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(72, 18)
        Me.Label31.TabIndex = 585
        Me.Label31.Text = "�����¶�"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(216, 276)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 573
        Me.btQuit.Text = "ȡ��"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(148, 276)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 572
        Me.btSave.Text = "ȷ��"
        '
        'txtBillNO
        '
        Me.txtBillNO.Location = New System.Drawing.Point(78, 102)
        Me.txtBillNO.MaxLength = 20
        Me.txtBillNO.Name = "txtBillNO"
        Me.txtBillNO.Size = New System.Drawing.Size(130, 21)
        Me.txtBillNO.TabIndex = 554
        Me.txtBillNO.Text = ""
        '
        'Label4
        '
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(4, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 580
        Me.Label4.Text = "�ᵥ��"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(4, 248)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 18)
        Me.Label20.TabIndex = 584
        Me.Label20.Text = "������Ӣ��"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(4, 224)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 18)
        Me.Label21.TabIndex = 581
        Me.Label21.Text = "������"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(4, 176)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 18)
        Me.Label22.TabIndex = 591
        Me.Label22.Text = "ж����"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(4, 128)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 18)
        Me.Label23.TabIndex = 576
        Me.Label23.Text = "װ����"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(4, 152)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 18)
        Me.Label24.TabIndex = 587
        Me.Label24.Text = "װ����Ӣ��"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(4, 200)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(72, 18)
        Me.Label32.TabIndex = 583
        Me.Label32.Text = "ж����Ӣ��"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(0, 0)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 574
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(388, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 20)
        Me.Label2.TabIndex = 598
        Me.Label2.Text = "����"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(388, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 20)
        Me.Label11.TabIndex = 597
        Me.Label11.Text = "����"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbUnloadPortEng
        '
        Me.cbUnloadPortEng.Location = New System.Drawing.Point(78, 198)
        Me.cbUnloadPortEng.MaxDropDownItems = 20
        Me.cbUnloadPortEng.Name = "cbUnloadPortEng"
        Me.cbUnloadPortEng.Size = New System.Drawing.Size(130, 20)
        Me.cbUnloadPortEng.TabIndex = 601
        '
        'cbLoadPortEng
        '
        Me.cbLoadPortEng.Location = New System.Drawing.Point(78, 150)
        Me.cbLoadPortEng.MaxDropDownItems = 20
        Me.cbLoadPortEng.Name = "cbLoadPortEng"
        Me.cbLoadPortEng.Size = New System.Drawing.Size(130, 20)
        Me.cbLoadPortEng.TabIndex = 600
        '
        'cbReceivePlaceEng
        '
        Me.cbReceivePlaceEng.Location = New System.Drawing.Point(78, 246)
        Me.cbReceivePlaceEng.MaxDropDownItems = 20
        Me.cbReceivePlaceEng.Name = "cbReceivePlaceEng"
        Me.cbReceivePlaceEng.Size = New System.Drawing.Size(130, 20)
        Me.cbReceivePlaceEng.TabIndex = 599
        '
        'ckbMoved
        '
        Me.ckbMoved.Location = New System.Drawing.Point(344, 270)
        Me.ckbMoved.Name = "ckbMoved"
        Me.ckbMoved.Size = New System.Drawing.Size(74, 24)
        Me.ckbMoved.TabIndex = 602
        Me.ckbMoved.Text = "������"
        '
        'FrmConImageCargo_Deleteg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(426, 305)
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
        Me.Name = "FrmConImageCargo_Deleteg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "��װ�䴬ͼ��Ϣ ɾ��"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmConImageCargo_Deleteg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr As String
        Dim dvState As New DataView()
        Dim dvLoadPort As New DataView()
        Dim dvUnloadPort As New DataView()
        Dim dvDelivery As New DataView()
        Dim sqlConState, sqlPort, sqlDelivery As String

        'Me.txtLOAD_PORT.Enabled = False
        'Me.txtUNLOAD_PORT.Enabled = False
        'Me.txtDelivery.Enabled = False

        Me.txtContainerNo.Enabled = False
        Me.txtBayNo.Enabled = False
        Me.cbState.Enabled = False

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

        If ds.Tables(0).Rows(0).Item("unload_mark") = 1 Then
            MessageBox.Show("��������ҵ���޷�ɾ����", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            btSave.Enabled = False
        End If

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            If MessageBox.Show("ȷ��Ҫɾ����", "������ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
                '��¼������־
                Call OperateHistory(G_DeptName, Now, G_User, "ɾ��", "CON_IMAGE", Trim(txtID.Text), "CON_IMAGE_ID")
                ds.Tables(0).Rows(0).Delete()
                sqlda.Update(ds)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class
