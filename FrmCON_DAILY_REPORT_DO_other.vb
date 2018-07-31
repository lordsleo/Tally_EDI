Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FrmCON_DAILY_REPORT_DO_other
    Inherits System.Windows.Forms.Form
    Dim dw As New DataView()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim dswork_time As New DataSet()
    Dim dschief As New DataSet
    Dim dsteam As New DataSet

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
    Friend WithEvents RBeng As System.Windows.Forms.RadioButton
    Friend WithEvents RBchina As System.Windows.Forms.RadioButton
    Friend WithEvents BTQUIT As System.Windows.Forms.Button
    Friend WithEvents BTOK As System.Windows.Forms.Button
    Friend WithEvents CombCHIEF_TALLY As System.Windows.Forms.ComboBox
    Friend WithEvents CombWORK_TIME As System.Windows.Forms.ComboBox
    Friend WithEvents DTPdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbteamno As System.Windows.Forms.ComboBox
    Friend WithEvents rbcc As System.Windows.Forms.RadioButton
    Friend WithEvents rbcz As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.RBeng = New System.Windows.Forms.RadioButton
        Me.RBchina = New System.Windows.Forms.RadioButton
        Me.BTQUIT = New System.Windows.Forms.Button
        Me.BTOK = New System.Windows.Forms.Button
        Me.CombCHIEF_TALLY = New System.Windows.Forms.ComboBox
        Me.CombWORK_TIME = New System.Windows.Forms.ComboBox
        Me.DTPdate = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbteamno = New System.Windows.Forms.ComboBox
        Me.rbcc = New System.Windows.Forms.RadioButton
        Me.rbcz = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RBeng
        '
        Me.RBeng.Checked = True
        Me.RBeng.Location = New System.Drawing.Point(112, 208)
        Me.RBeng.Name = "RBeng"
        Me.RBeng.Size = New System.Drawing.Size(74, 20)
        Me.RBeng.TabIndex = 53
        Me.RBeng.TabStop = True
        Me.RBeng.Text = "Ӣ�ĸ�ʽ"
        Me.RBeng.Visible = False
        '
        'RBchina
        '
        Me.RBchina.Location = New System.Drawing.Point(32, 208)
        Me.RBchina.Name = "RBchina"
        Me.RBchina.Size = New System.Drawing.Size(74, 20)
        Me.RBchina.TabIndex = 52
        Me.RBchina.Text = "���ĸ�ʽ"
        Me.RBchina.Visible = False
        '
        'BTQUIT
        '
        Me.BTQUIT.Location = New System.Drawing.Point(113, 184)
        Me.BTQUIT.Name = "BTQUIT"
        Me.BTQUIT.Size = New System.Drawing.Size(65, 24)
        Me.BTQUIT.TabIndex = 51
        Me.BTQUIT.Text = "ȡ��"
        '
        'BTOK
        '
        Me.BTOK.Location = New System.Drawing.Point(33, 184)
        Me.BTOK.Name = "BTOK"
        Me.BTOK.Size = New System.Drawing.Size(65, 24)
        Me.BTOK.TabIndex = 50
        Me.BTOK.Text = "ȷ��"
        '
        'CombCHIEF_TALLY
        '
        Me.CombCHIEF_TALLY.Location = New System.Drawing.Point(88, 120)
        Me.CombCHIEF_TALLY.Name = "CombCHIEF_TALLY"
        Me.CombCHIEF_TALLY.Size = New System.Drawing.Size(108, 20)
        Me.CombCHIEF_TALLY.TabIndex = 49
        '
        'CombWORK_TIME
        '
        Me.CombWORK_TIME.Location = New System.Drawing.Point(88, 56)
        Me.CombWORK_TIME.Name = "CombWORK_TIME"
        Me.CombWORK_TIME.Size = New System.Drawing.Size(108, 20)
        Me.CombWORK_TIME.TabIndex = 48
        '
        'DTPdate
        '
        Me.DTPdate.CustomFormat = "yyyy-MM-dd"
        Me.DTPdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPdate.Location = New System.Drawing.Point(88, 24)
        Me.DTPdate.Name = "DTPdate"
        Me.DTPdate.Size = New System.Drawing.Size(108, 21)
        Me.DTPdate.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 24)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "����鳤"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 24)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "���"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 24)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "�ձ�����"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 24)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "����"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbteamno
        '
        Me.cmbteamno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbteamno.Location = New System.Drawing.Point(88, 88)
        Me.cmbteamno.Name = "cmbteamno"
        Me.cmbteamno.Size = New System.Drawing.Size(108, 20)
        Me.cmbteamno.TabIndex = 54
        '
        'rbcc
        '
        Me.rbcc.Location = New System.Drawing.Point(16, 8)
        Me.rbcc.Name = "rbcc"
        Me.rbcc.Size = New System.Drawing.Size(56, 20)
        Me.rbcc.TabIndex = 52
        Me.rbcc.Text = "����"
        '
        'rbcz
        '
        Me.rbcz.Location = New System.Drawing.Point(96, 8)
        Me.rbcz.Name = "rbcz"
        Me.rbcz.Size = New System.Drawing.Size(56, 20)
        Me.rbcz.TabIndex = 53
        Me.rbcz.Text = "��װ"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbcz)
        Me.GroupBox1.Controls.Add(Me.rbcc)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(160, 32)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        '
        'FrmCON_DAILY_REPORT_DO_other
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(210, 223)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTQUIT)
        Me.Controls.Add(Me.BTOK)
        Me.Controls.Add(Me.cmbteamno)
        Me.Controls.Add(Me.RBeng)
        Me.Controls.Add(Me.RBchina)
        Me.Controls.Add(Me.CombCHIEF_TALLY)
        Me.Controls.Add(Me.CombWORK_TIME)
        Me.Controls.Add(Me.DTPdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCON_DAILY_REPORT_DO_other"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "��װ�䵷���ձ�_����"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCON_DAILY_REPORT_DO_other_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RBeng.Checked = True
        If Hatch_in = 0 Then
            rbcc.Checked = True
        Else
            rbcz.Checked = True
        End If

        dw = Getdata("select Code_WorkTime,WorkTime from Code_WorkTime where Code_WorkTime<>'00'", dswork_time)
        CombWORK_TIME.DataSource = dswork_time.Tables(0).DefaultView
        CombWORK_TIME.DisplayMember = "WorkTime"
        CombWORK_TIME.ValueMember = "Code_WorkTime"

        'dw = Getdata("select work_no,name from tally_clerk", dschief)
        'CombCHIEF_TALLY.DataSource = dschief.Tables(0).DefaultView
        'CombCHIEF_TALLY.DisplayMember = "name"
        'CombCHIEF_TALLY.ValueMember = "work_no"
        teamno()
        RBeng.Checked = True
        OKMARK = 0
    End Sub

    Private Sub chief()
        dw = Getdata("exec sp_chief_tally '" & Ship_ID & "', '" & G_DeptCode & "','" & DTPdate.Value & "','" & CombWORK_TIME.SelectedValue & "'", dschief)
        CombCHIEF_TALLY.DataSource = dschief.Tables(0).DefaultView
        CombCHIEF_TALLY.DisplayMember = "name"
        CombCHIEF_TALLY.ValueMember = "work_no"
        CombCHIEF_TALLY.Refresh()
    End Sub

    Private Sub teamno()
        Dim st As String
        dw = Getdata(" select team_no from CON_TALLY_LIST where SHIP_ID='" & Ship_ID & "' and (inout_mark=1 or reload=1) group by team_no ", dsteam)
        cmbteamno.DataSource = dsteam.Tables(0).DefaultView
        cmbteamno.DisplayMember = "team_no"
        cmbteamno.ValueMember = "team_no"
        cmbteamno.Refresh()
    End Sub

    Private Sub DTPDATE_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTPdate.Leave
        CombCHIEF_TALLY.ValueMember = ""
        Call chief()
    End Sub

    Private Sub CombWORK_TIME_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles CombWORK_TIME.Leave
        CombCHIEF_TALLY.ValueMember = ""
        Call chief()
    End Sub

    Private Sub BTOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTOK.Click
        Dim q As Integer
        Dim t As Integer
        
        If cmbteamno.Text.Length > 0 Then
            If RBeng.Checked = True Then
                dsdailydx.Reset()
                If rbcc.Checked = True Then
                    dw = Getdata("exec SPCON_DAILY_REPORT_OUT '" & Ship_ID & "','" & DTPdate.Value & "','" & CombWORK_TIME.SelectedValue & "', '" & cmbteamno.Text & "'", dsdailydx)
                Else
                    dw = Getdata("exec SPCON_DAILY_REPORT_RELOAD '" & Ship_ID & "','" & DTPdate.Value & "','" & CombWORK_TIME.SelectedValue & "', '" & cmbteamno.Text & "'", dsdailydx)
                End If
                REMARKSdx = ""
                If dsdailydx.Tables(4).Rows.Count > 0 Then
                    If dsdailydx.Tables(4).Rows(0).Item("HOLIDAY") <> 0 Then
                        If dsdailydx.Tables(4).Rows(0).Item("HOLIDAY") = dsdailydx.Tables(5).Rows(dsdailydx.Tables(5).Rows.Count - 1).Item("jjr") Then
                            REMARKSdx = REMARKSdx & "ALL TALLIED ON SAT/SUN/HOLDY��"
                        Else
                            REMARKSdx = REMARKSdx & "TALLIED ON SAT/SUN/HOLDY " & dsdailydx.Tables(4).Rows(0).Item("HOLIDAY") & " CONTS��"
                        End If
                    End If
                    If dsdailydx.Tables(4).Rows(0).Item("NIGHT") <> 0 Then
                        REMARKSdx = REMARKSdx & " NIGHT SHIFT: " & dsdailydx.Tables(4).Rows(0).Item("NIGHT") & " CONTS ( "
                        For t = 0 To dsdailydx.Tables(5).Rows.Count - 2
                            If dsdailydx.Tables(5).Rows(t)(3) <> 0 Then
                                REMARKSdx = REMARKSdx & dsdailydx.Tables(5).Rows(t)(0) & "'" & dsdailydx.Tables(5).Rows(t)(1) & "x" & dsdailydx.Tables(5).Rows(t)(3) & "  "
                            End If
                            If t = dsdailydx.Tables(5).Rows.Count - 2 Then
                                REMARKSdx = REMARKSdx & ")"
                            End If
                        Next
                    End If
                    If dsdailydx.Tables(4).Rows(0).Item("inout_mark") <> 0 Then
                        REMARKSdx = REMARKSdx & "RELOAD " & dsdailydx.Tables(4).Rows(0).Item("inout_mark") & " CONTAINERS��"
                    End If
                    If dsdailydx.Tables(4).Rows(0).Item("STANDBY_time") <> 0 Then
                        REMARKSdx = REMARKSdx & "STANDBY_time " & dsdailydx.Tables(4).Rows(0).Item("STANDBY_time") & " CONTAINERS��"
                    End If
                    q = 0
                    q = dsdailydx.Tables(0).Rows(0).Item(1) * 1 + dsdailydx.Tables(0).Rows(0).Item(3) * 2 + Math.Round(dsdailydx.Tables(0).Rows(0).Item(5) * 2.5 + 0.49) + dsdailydx.Tables(0).Rows(0).Item(7) * 1 + dsdailydx.Tables(0).Rows(0).Item(9) * 2 + Math.Round(dsdailydx.Tables(0).Rows(0).Item(11) * 2.5 + 0.49)
                    GL_Teudx = "<" & q & " TEU>"
                End If
                OKMARKdx = 1
                mark = "ENG"
                'LIST_MAN = CombCHIEF_TALLY.Text
                Call BTQUIT_Click(sender, e)
            End If
        Else
            MsgBox("�����빤��ţ�")
        End If
    End Sub

    Private Sub BTQUIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTQUIT.Click
        Me.Close()
    End Sub
    Private Sub DTPdate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DTPdate.KeyPress
        If e.KeyChar = Chr(13) Then
            CombWORK_TIME.Focus()
        End If
    End Sub
    Private Sub CombWORK_TIME_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombWORK_TIME.KeyPress
        If e.KeyChar = Chr(13) Then
            CombCHIEF_TALLY.Focus()
        End If
    End Sub
    Private Sub CombCHIEF_TALLY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CombCHIEF_TALLY.KeyPress
        If e.KeyChar = Chr(13) Then
            BTOK.Focus()
        End If
    End Sub
End Class
