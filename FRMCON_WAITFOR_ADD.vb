Imports TALLY.DBControl
Public Class FRMCON_WAITFOR_ADD
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dw As New DataView()
    Dim dsberth As New DataSet()
    ' Dim dshatch_no As New DataSet()
    Dim dsclerk As New DataSet()
    Dim dsclerk2 As New DataSet()
    Dim dsclerk3 As New DataSet()
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
    Friend WithEvents BTADD As System.Windows.Forms.Button
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents BTOK As System.Windows.Forms.Button
    Friend WithEvents TxtCAUSE As System.Windows.Forms.TextBox
    Friend WithEvents TxtSHIP_WATCH As System.Windows.Forms.TextBox
    Friend WithEvents TxtPERSON As System.Windows.Forms.TextBox
    Friend WithEvents TxtWORK_TYPE As System.Windows.Forms.TextBox
    Friend WithEvents TxtTime_from As System.Windows.Forms.TextBox
    Friend WithEvents Txttime_to As System.Windows.Forms.TextBox
    Friend WithEvents DTPSTANDBYDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents CombTALLY_CLERK3 As System.Windows.Forms.ComboBox
    Friend WithEvents CombTALLY_CLERK2 As System.Windows.Forms.ComboBox
    Friend WithEvents CombTALLY_CLERK1 As System.Windows.Forms.ComboBox
    Friend WithEvents CombBERTHNO As System.Windows.Forms.ComboBox
    Friend WithEvents CBMANAGER_DS As System.Windows.Forms.CheckBox
    Friend WithEvents CBNIGHT_MARK As System.Windows.Forms.CheckBox
    Friend WithEvents CBHOLIDAY As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtHATCH_NO As System.Windows.Forms.TextBox
    Friend WithEvents TxtNO As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BTADD = New System.Windows.Forms.Button()
        Me.BTQUIT = New System.Windows.Forms.Button()
        Me.BTOK = New System.Windows.Forms.Button()
        Me.TxtCAUSE = New System.Windows.Forms.TextBox()
        Me.TxtSHIP_WATCH = New System.Windows.Forms.TextBox()
        Me.TxtPERSON = New System.Windows.Forms.TextBox()
        Me.TxtWORK_TYPE = New System.Windows.Forms.TextBox()
        Me.TxtTime_from = New System.Windows.Forms.TextBox()
        Me.Txttime_to = New System.Windows.Forms.TextBox()
        Me.DTPSTANDBYDATE = New System.Windows.Forms.DateTimePicker()
        Me.CombTALLY_CLERK3 = New System.Windows.Forms.ComboBox()
        Me.CombTALLY_CLERK2 = New System.Windows.Forms.ComboBox()
        Me.CombTALLY_CLERK1 = New System.Windows.Forms.ComboBox()
        Me.CombBERTHNO = New System.Windows.Forms.ComboBox()
        Me.CBMANAGER_DS = New System.Windows.Forms.CheckBox()
        Me.CBNIGHT_MARK = New System.Windows.Forms.CheckBox()
        Me.CBHOLIDAY = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtHATCH_NO = New System.Windows.Forms.TextBox()
        Me.TxtNO = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTADD
        '
        Me.BTADD.Location = New System.Drawing.Point(144, 212)
        Me.BTADD.Name = "BTADD"
        Me.BTADD.Size = New System.Drawing.Size(65, 24)
        Me.BTADD.TabIndex = 84
        Me.BTADD.Text = "���"
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(290, 212)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 83
        Me.BTQUIT.Text = "ȡ��"
        '
        'BTOK
        '
        Me.BTOK.Location = New System.Drawing.Point(218, 212)
        Me.BTOK.Name = "BTOK"
        Me.BTOK.Size = New System.Drawing.Size(65, 24)
        Me.BTOK.TabIndex = 82
        Me.BTOK.Text = "ȷ��"
        '
        'TxtCAUSE
        '
        Me.TxtCAUSE.Location = New System.Drawing.Point(280, 150)
        Me.TxtCAUSE.MaxLength = 100
        Me.TxtCAUSE.Multiline = True
        Me.TxtCAUSE.Name = "TxtCAUSE"
        Me.TxtCAUSE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtCAUSE.Size = New System.Drawing.Size(210, 46)
        Me.TxtCAUSE.TabIndex = 81
        Me.TxtCAUSE.Text = ""
        '
        'TxtSHIP_WATCH
        '
        Me.TxtSHIP_WATCH.Location = New System.Drawing.Point(280, 122)
        Me.TxtSHIP_WATCH.MaxLength = 10
        Me.TxtSHIP_WATCH.Name = "TxtSHIP_WATCH"
        Me.TxtSHIP_WATCH.Size = New System.Drawing.Size(102, 21)
        Me.TxtSHIP_WATCH.TabIndex = 80
        Me.TxtSHIP_WATCH.Text = ""
        '
        'TxtPERSON
        '
        Me.TxtPERSON.Location = New System.Drawing.Point(280, 10)
        Me.TxtPERSON.Name = "TxtPERSON"
        Me.TxtPERSON.Size = New System.Drawing.Size(102, 21)
        Me.TxtPERSON.TabIndex = 79
        Me.TxtPERSON.Text = ""
        '
        'TxtWORK_TYPE
        '
        Me.TxtWORK_TYPE.Location = New System.Drawing.Point(92, 178)
        Me.TxtWORK_TYPE.MaxLength = 2
        Me.TxtWORK_TYPE.Name = "TxtWORK_TYPE"
        Me.TxtWORK_TYPE.Size = New System.Drawing.Size(108, 21)
        Me.TxtWORK_TYPE.TabIndex = 78
        Me.TxtWORK_TYPE.Text = ""
        '
        'TxtTime_from
        '
        Me.TxtTime_from.Location = New System.Drawing.Point(92, 122)
        Me.TxtTime_from.MaxLength = 4
        Me.TxtTime_from.Name = "TxtTime_from"
        Me.TxtTime_from.Size = New System.Drawing.Size(108, 21)
        Me.TxtTime_from.TabIndex = 77
        Me.TxtTime_from.Text = ""
        '
        'Txttime_to
        '
        Me.Txttime_to.Location = New System.Drawing.Point(92, 150)
        Me.Txttime_to.MaxLength = 4
        Me.Txttime_to.Name = "Txttime_to"
        Me.Txttime_to.Size = New System.Drawing.Size(108, 21)
        Me.Txttime_to.TabIndex = 76
        Me.Txttime_to.Text = ""
        '
        'DTPSTANDBYDATE
        '
        Me.DTPSTANDBYDATE.CustomFormat = "yyyy-MM-dd"
        Me.DTPSTANDBYDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPSTANDBYDATE.Location = New System.Drawing.Point(92, 94)
        Me.DTPSTANDBYDATE.Name = "DTPSTANDBYDATE"
        Me.DTPSTANDBYDATE.Size = New System.Drawing.Size(108, 21)
        Me.DTPSTANDBYDATE.TabIndex = 75
        Me.DTPSTANDBYDATE.Value = New Date(2004, 4, 23, 0, 0, 0, 0)
        '
        'CombTALLY_CLERK3
        '
        Me.CombTALLY_CLERK3.Location = New System.Drawing.Point(280, 94)
        Me.CombTALLY_CLERK3.Name = "CombTALLY_CLERK3"
        Me.CombTALLY_CLERK3.Size = New System.Drawing.Size(102, 20)
        Me.CombTALLY_CLERK3.TabIndex = 74
        '
        'CombTALLY_CLERK2
        '
        Me.CombTALLY_CLERK2.Location = New System.Drawing.Point(280, 66)
        Me.CombTALLY_CLERK2.Name = "CombTALLY_CLERK2"
        Me.CombTALLY_CLERK2.Size = New System.Drawing.Size(102, 20)
        Me.CombTALLY_CLERK2.TabIndex = 73
        '
        'CombTALLY_CLERK1
        '
        Me.CombTALLY_CLERK1.Location = New System.Drawing.Point(280, 38)
        Me.CombTALLY_CLERK1.Name = "CombTALLY_CLERK1"
        Me.CombTALLY_CLERK1.Size = New System.Drawing.Size(102, 20)
        Me.CombTALLY_CLERK1.TabIndex = 72
        '
        'CombBERTHNO
        '
        Me.CombBERTHNO.Location = New System.Drawing.Point(92, 38)
        Me.CombBERTHNO.Name = "CombBERTHNO"
        Me.CombBERTHNO.Size = New System.Drawing.Size(108, 20)
        Me.CombBERTHNO.TabIndex = 70
        '
        'CBMANAGER_DS
        '
        Me.CBMANAGER_DS.Location = New System.Drawing.Point(392, 90)
        Me.CBMANAGER_DS.Name = "CBMANAGER_DS"
        Me.CBMANAGER_DS.Size = New System.Drawing.Size(98, 20)
        Me.CBMANAGER_DS.TabIndex = 69
        Me.CBMANAGER_DS.Text = "����鳤��ʱ"
        Me.CBMANAGER_DS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CBNIGHT_MARK
        '
        Me.CBNIGHT_MARK.Location = New System.Drawing.Point(392, 50)
        Me.CBNIGHT_MARK.Name = "CBNIGHT_MARK"
        Me.CBNIGHT_MARK.Size = New System.Drawing.Size(98, 20)
        Me.CBNIGHT_MARK.TabIndex = 67
        Me.CBNIGHT_MARK.Text = "ҹ��"
        Me.CBNIGHT_MARK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CBHOLIDAY
        '
        Me.CBHOLIDAY.Location = New System.Drawing.Point(392, 10)
        Me.CBHOLIDAY.Name = "CBHOLIDAY"
        Me.CBHOLIDAY.Size = New System.Drawing.Size(98, 20)
        Me.CBHOLIDAY.TabIndex = 66
        Me.CBHOLIDAY.Text = "�ڼ���"
        Me.CBHOLIDAY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(206, 122)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 22)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "����ֵ��Ա"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(206, 94)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 22)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "���Ա3"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(206, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 22)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "���Ա2"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(206, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 22)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "���Ա1"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(206, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 22)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "ԭ��"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(206, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 22)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "��ʱ����"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 22)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "���"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 22)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "��ʱ����ʱ��"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 22)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "��ʱ��ʼʱ��"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 22)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "��ʱ����"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 22)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "����"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 22)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "��λ��"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtHATCH_NO
        '
        Me.TxtHATCH_NO.Location = New System.Drawing.Point(92, 66)
        Me.TxtHATCH_NO.Name = "TxtHATCH_NO"
        Me.TxtHATCH_NO.Size = New System.Drawing.Size(108, 21)
        Me.TxtHATCH_NO.TabIndex = 76
        Me.TxtHATCH_NO.Text = ""
        '
        'TxtNO
        '
        Me.TxtNO.Location = New System.Drawing.Point(92, 10)
        Me.TxtNO.MaxLength = 5
        Me.TxtNO.Name = "TxtNO"
        Me.TxtNO.Size = New System.Drawing.Size(108, 21)
        Me.TxtNO.TabIndex = 86
        Me.TxtNO.Text = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 22)
        Me.Label13.TabIndex = 85
        Me.Label13.Text = "���"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FRMCON_WAITFOR_ADD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(498, 251)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TxtNO, Me.Label13, Me.BTADD, Me.BTQUIT, Me.BTOK, Me.TxtCAUSE, Me.TxtSHIP_WATCH, Me.TxtPERSON, Me.TxtWORK_TYPE, Me.TxtTime_from, Me.Txttime_to, Me.DTPSTANDBYDATE, Me.CombTALLY_CLERK3, Me.CombTALLY_CLERK2, Me.CombTALLY_CLERK1, Me.CombBERTHNO, Me.CBMANAGER_DS, Me.CBNIGHT_MARK, Me.CBHOLIDAY, Me.Label12, Me.Label11, Me.Label10, Me.Label9, Me.Label8, Me.Label7, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.Label1, Me.TxtHATCH_NO})
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMCON_WAITFOR_ADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "��װ���ʱ��¼_����"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FRMCON_WAITFOR_ADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        dw = Getdata("select CODE_BERTH,NAME_BERTH from CODE_BERTH ", dsberth)
        CombBERTHNO.DataSource = dsberth.Tables(0).DefaultView
        CombBERTHNO.DisplayMember = "NAME_BERTH"
        CombBERTHNO.ValueMember = "CODE_BERTH"

        'dw = Getdata("select value,descr from codecabin", dshatch_no)
        'CombHATCH_NO.DataSource = dshatch_no.Tables(0).DefaultView
        'CombHATCH_NO.DisplayMember = "descr"
        'CombHATCH_NO.ValueMember = "value"

        'dw = Getdata("select work_no,name from TALLY_CLERK", dsclerk)
        'CombTALLY_CLERK1.DataSource = dsclerk.Tables(0).DefaultView
        'CombTALLY_CLERK1.DisplayMember = "name"
        'CombTALLY_CLERK1.ValueMember = "work_no"

        'dw = Getdata("select work_no,name from TALLY_CLERK", dsclerk2)
        'CombTALLY_CLERK2.DataSource = dsclerk2.Tables(0).DefaultView
        'CombTALLY_CLERK2.DisplayMember = "name"
        'CombTALLY_CLERK2.ValueMember = "work_no"

        'dw = Getdata("select work_no,name from TALLY_CLERK", dsclerk3)
        'CombTALLY_CLERK3.DataSource = dsclerk3.Tables(0).DefaultView
        'CombTALLY_CLERK3.DisplayMember = "name"
        'CombTALLY_CLERK3.ValueMember = "work_no"


        dw = Updatedata(sqlda, "select * from cargo_waitfor where CARGO_WAITFOR_ID='" & ID & "'", ds)
        If ds.Tables(0).DefaultView.Count > 0 Then
            TxtTime_from.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("time_from"))), "", Trim(ds.Tables(0).Rows(0).Item("time_from")))
            Txttime_to.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("time_to"))), "", Trim(ds.Tables(0).Rows(0).Item("time_to")))
            TxtHATCH_NO.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("hatch_no"))), "", Trim(ds.Tables(0).Rows(0).Item("hatch_no")))
            CombBERTHNO.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("BERTHNO"))), "", Trim(ds.Tables(0).Rows(0).Item("BERTHNO")))
            TxtSHIP_WATCH.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("SHIP_WATCH"))), "", Trim(ds.Tables(0).Rows(0).Item("SHIP_WATCH")))
            DTPSTANDBYDATE.Value = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("STANDBYDATE"))), Now, Trim(ds.Tables(0).Rows(0).Item("STANDBYDATE")))
            TxtPERSON.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("PERSON"))), Now, Trim(ds.Tables(0).Rows(0).Item("PERSON")))
            TxtWORK_TYPE.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("WORK_TYPE"))), "", Trim(ds.Tables(0).Rows(0).Item("WORK_TYPE")))
            TxtSHIP_WATCH.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("SHIP_WATCH"))), "", Trim(ds.Tables(0).Rows(0).Item("SHIP_WATCH")))
            TxtCAUSE.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("CAUSE"))), "", Trim(ds.Tables(0).Rows(0).Item("CAUSE")))
            TxtNO.Text = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("no"))), "", Trim(ds.Tables(0).Rows(0).Item("no")))
            Call clerk()

            CombTALLY_CLERK1.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk1"))), "00", Trim(ds.Tables(0).Rows(0).Item("tally_clerk1")))
            CombTALLY_CLERK2.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk2"))), "00", Trim(ds.Tables(0).Rows(0).Item("tally_clerk2")))
            CombTALLY_CLERK3.SelectedValue = IIf(IsDBNull(Trim(ds.Tables(0).Rows(0).Item("tally_clerk3"))), "00", Trim(ds.Tables(0).Rows(0).Item("tally_clerk3")))
            If ds.Tables(0).Rows(0).Item("HOLIDAY") = 1 Then
                CBHOLIDAY.Checked = True
            End If
            If ds.Tables(0).Rows(0).Item("NIGHT_MARK") = 1 Then
                CBNIGHT_MARK.Checked = True
            End If
            If ds.Tables(0).Rows(0).Item("MANAGER_DS") = 1 Then
                CBMANAGER_DS.Checked = True
            End If

        End If


        Exit Sub
Err:
        Resume Next
    End Sub
    Private Sub clerk()
        Try

            dw = Getdata("exec sp_waitfor_clerk '" & G_DeptCode & "','" & Ship_ID & "','" & TxtTime_from.Text & "','" & DTPSTANDBYDATE.Value & "'", dsclerk)
            CombTALLY_CLERK1.DataSource = dsclerk.Tables(0).DefaultView
            CombTALLY_CLERK1.DisplayMember = "name"
            CombTALLY_CLERK1.ValueMember = "work_no"


            dw = Getdata("exec sp_waitfor_clerk '" & G_DeptCode & "','" & Ship_ID & "','" & TxtTime_from.Text & "','" & DTPSTANDBYDATE.Value & "'", dsclerk2)
            CombTALLY_CLERK2.DataSource = dsclerk2.Tables(0).DefaultView
            CombTALLY_CLERK2.DisplayMember = "name"
            CombTALLY_CLERK2.ValueMember = "work_no"

            dw = Getdata("exec sp_waitfor_clerk '" & G_DeptCode & "','" & Ship_ID & "','" & TxtTime_from.Text & "','" & DTPSTANDBYDATE.Value & "'", dsclerk3)
            CombTALLY_CLERK3.DataSource = dsclerk3.Tables(0).DefaultView
            CombTALLY_CLERK3.DisplayMember = "name"
            CombTALLY_CLERK3.ValueMember = "work_no"

        Catch ex As System.Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub CombBERTHNO_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CombBERTHNO.Leave
        Dim DSSELECT As New DataSet()
        Try
            If Len(Trim(CombBERTHNO.Text)) > 0 Then
                If Mid(Trim(CombBERTHNO.Text), 1, 1) = "0" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "1" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "2" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "3" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "4" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "5" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "6" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "7" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "8" Or Mid(Trim(CombBERTHNO.Text), 1, 1) = "9" Then
                    dw = Getdata("SELECT * FROM CODE_BERTH WHERE CODE_BERTH='" & Trim(CombBERTHNO.Text) & "'", DSSELECT)
                    If DSSELECT.Tables(0).Rows.Count > 0 Then
                        CombBERTHNO.SelectedValue = Trim(CombBERTHNO.Text)
                    Else
                        MsgBox("û�иò�λ�ţ����������Ƿ���ȷ��")
                        CombBERTHNO.Focus()
                    End If
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CBNIGHT_SELECT()
        CBNIGHT_MARK.Enabled = True
        If Len(Trim(TxtTime_from.Text)) = 4 Then
            If CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) < 24 And CType(Mid(Trim(TxtTime_from.Text), 3, 2), Integer) < 60 Then
                If CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) >= 6 And CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) < 22 Then
                    CBNIGHT_MARK.Checked = False
                    CBNIGHT_MARK.Enabled = False
                End If
                If CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) < 6 Or CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) = 22 Or CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) = 23 Then
                    CBNIGHT_MARK.Checked = True
                    CBNIGHT_MARK.Enabled = True
                End If
            Else
                MsgBox("��ʼʱ����������")
                TxtTime_from.Focus()
            End If
        Else
            MsgBox("��ʼʱ����������")
            TxtTime_from.Focus()
        End If
    End Sub

    Private Sub DTPSTANDBYDATE_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTPSTANDBYDATE.Leave

        Call clerk()
        CombTALLY_CLERK1.SelectedValue = ""
        CombTALLY_CLERK2.SelectedValue = ""
        CombTALLY_CLERK3.SelectedValue = ""
        If dsclerk.Tables(0).Rows.Count > 0 Then
            TxtWORK_TYPE.Text = dsclerk.Tables(0).Rows(0).Item("work_type")
        End If

    End Sub

    Private Sub TxtTime_from_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtTime_from.Leave

        Call clerk()
        CombTALLY_CLERK1.SelectedValue = ""
        CombTALLY_CLERK2.SelectedValue = ""
        CombTALLY_CLERK3.SelectedValue = ""
        If dsclerk.Tables(0).Rows.Count > 0 Then
            TxtWORK_TYPE.Text = dsclerk.Tables(0).Rows(0).Item("work_type")
        End If
        Call CBNIGHT_SELECT()

    End Sub



    Private Sub BTADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTADD.Click
        TxtTime_from.Text = ""
        Txttime_to.Text = ""
        TxtWORK_TYPE.Text = ""
        TxtPERSON.Text = ""
        TxtSHIP_WATCH.Text = ""
        TxtCAUSE.Text = ""
        CBHOLIDAY.Checked = False
        CBNIGHT_MARK.Checked = False
        CBMANAGER_DS.Checked = False

    End Sub

    Private Sub BTOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTOK.Click
        Try
            If Len(Trim(TxtTime_from.Text)) = 4 And CType(Mid(Trim(TxtTime_from.Text), 1, 2), Integer) < 24 And CType(Mid(Trim(TxtTime_from.Text), 3, 2), Integer) < 60 Then
                If Len(Trim(Txttime_to.Text)) = 4 And CType(Mid(Trim(Txttime_to.Text), 1, 2), Integer) < 24 And CType(Mid(Trim(Txttime_to.Text), 3, 2), Integer) < 60 Then
                    If Len(Trim(DTPSTANDBYDATE.Value)) > 0 Then
                        Dim row As DataRow
                        row = ds.Tables(0).NewRow
                        row("SHIP_ID") = Trim(Ship_ID)
                        row("no") = Trim(TxtNO.Text)
                        row("berthno") = IIf(Len(Trim(CombBERTHNO.SelectedValue)) > 0, Trim(CombBERTHNO.SelectedValue), "")
                        row("HATCH_NO") = IIf(Len(Trim(TxtHATCH_NO.Text)) > 0, Trim(TxtHATCH_NO.Text), "")
                        row("STANDBYDATE") = DTPSTANDBYDATE.Value
                        row("time_from") = TxtTime_from.Text
                        row("time_to") = Txttime_to.Text
                        row("TALLY_CLERK1") = IIf(Len(Trim(CombTALLY_CLERK1.SelectedValue)) > 0, Trim(CombTALLY_CLERK1.SelectedValue), "00")
                        row("TALLY_CLERK2") = IIf(Len(Trim(CombTALLY_CLERK2.SelectedValue)) > 0, Trim(CombTALLY_CLERK2.SelectedValue), "00")
                        row("TALLY_CLERK3") = IIf(Len(Trim(CombTALLY_CLERK3.SelectedValue)) > 0, Trim(CombTALLY_CLERK3.SelectedValue), "00")
                        row("SHIP_WATCH") = IIf(Len(Trim(TxtSHIP_WATCH.Text)) > 0, Trim(TxtSHIP_WATCH.Text), "")
                        row("WORK_TYPE") = TxtWORK_TYPE.Text
                        row("PERSON") = IIf(Len(Trim(TxtPERSON.Text)) > 0, Trim(TxtPERSON.Text), 0)
                        row("CAUSE") = IIf(Len(Trim(TxtCAUSE.Text)) > 0, Trim(TxtCAUSE.Text), "")
                        row("user_name") = Trim(G_User)
                        If CBHOLIDAY.Checked = True Then
                            row("holiday") = "1"
                        Else
                            row("holiday") = "0"
                        End If
                        If CBNIGHT_MARK.Checked = True Then
                            row("NIGHT_MARK") = "1"
                        Else
                            row("NIGHT_MARK") = "0"
                        End If
                        If CBMANAGER_DS.Checked = True Then
                            row("MANAGER_DS") = "1"
                        Else
                            row("MANAGER_DS") = "0"
                        End If

                        ds.Tables(0).Rows.Add(row)
                        sqlda.Update(ds)
                        Call BTQUIT_Click(sender, e)

                    Else
                        MsgBox("��ʱ���ڲ���Ϊ�գ�")
                    End If

                Else
                    MsgBox("��ʱ����ʱ����д��������д4λ���֣�����ð�š�")
                End If
            Else
                MsgBox("��ʱ��ʼʱ����д��������д4λ���֣�����ð�š�")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()

    End Sub

    Private Sub txtno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNO.KeyPress
        If e.KeyChar = Chr(13) Then
            CombBERTHNO.Focus()
        End If
    End Sub
    Private Sub CombBERTHNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombBERTHNO.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtHATCH_NO.Focus()
        End If
    End Sub
    Private Sub txtHATCH_NO_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtHATCH_NO.KeyPress
        If e.KeyChar = Chr(13) Then
            DTPSTANDBYDATE.Focus()
        End If
    End Sub
    Private Sub DTPSTANDBYDATE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DTPSTANDBYDATE.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtTime_from.Focus()
        End If
    End Sub
    Private Sub TxtTime_from_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTime_from.KeyPress
        If e.KeyChar = Chr(13) Then
            Txttime_to.Focus()
        End If
    End Sub
    Private Sub TxtTime_to_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txttime_to.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtWORK_TYPE.Focus()
        End If
    End Sub
    Private Sub TxtWORK_TYPE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtWORK_TYPE.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtPERSON.Focus()
        End If
    End Sub
    Private Sub TxtPERSON_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPERSON.KeyPress
        If e.KeyChar = Chr(13) Then
            CombTALLY_CLERK1.Focus()
        End If
    End Sub
    Private Sub CombTALLY_CLERK1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombTALLY_CLERK1.KeyPress
        If e.KeyChar = Chr(13) Then
            CombTALLY_CLERK2.Focus()
        End If
    End Sub
    Private Sub CombTALLY_CLERK2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombTALLY_CLERK2.KeyPress
        If e.KeyChar = Chr(13) Then
            CombTALLY_CLERK3.Focus()
        End If
    End Sub
    Private Sub CombTALLY_CLERK3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombTALLY_CLERK3.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtSHIP_WATCH.Focus()
        End If
    End Sub
    Private Sub TxtSHIP_WATCH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSHIP_WATCH.KeyPress
        If e.KeyChar = Chr(13) Then
            CBHOLIDAY.Focus()
        End If
    End Sub
    Private Sub CBHOLIDAY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBHOLIDAY.KeyPress
        If e.KeyChar = Chr(13) Then
            CBNIGHT_MARK.Focus()
        End If
    End Sub
    Private Sub CBNIGHT_MARK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBNIGHT_MARK.KeyPress
        If e.KeyChar = Chr(13) Then
            CBMANAGER_DS.Focus()
        End If
    End Sub
    Private Sub CBMANAGER_DS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBMANAGER_DS.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtCAUSE.Focus()
        End If
    End Sub
    Private Sub TxtCAUSE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCAUSE.KeyPress
        If e.KeyChar = Chr(13) Then
            BTOK.Focus()
        End If
    End Sub
End Class
