Imports TALLY.DBControl
Public Class FrmConType_Add
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
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtShipOwner As System.Windows.Forms.ComboBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtShipOwner = New System.Windows.Forms.ComboBox()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtShipOwner
        '
        Me.txtShipOwner.Location = New System.Drawing.Point(80, 36)
        Me.txtShipOwner.Name = "txtShipOwner"
        Me.txtShipOwner.Size = New System.Drawing.Size(150, 20)
        Me.txtShipOwner.TabIndex = 112
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(152, 92)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 110
        Me.btQuit.Text = "ȡ��"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(84, 92)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 109
        Me.btSave.Text = "ȷ��"
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(16, 92)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(65, 24)
        Me.btAdd.TabIndex = 108
        Me.btAdd.Text = "���"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(80, 64)
        Me.txtCode.MaxLength = 12
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(150, 21)
        Me.txtCode.TabIndex = 107
        Me.txtCode.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(4, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 18)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "��Ӧ����"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(4, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 18)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "����˾"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(80, 6)
        Me.txtType.MaxLength = 12
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(150, 21)
        Me.txtType.TabIndex = 104
        Me.txtType.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 18)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "���ʹ���"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 111
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'FrmConType_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(232, 119)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtShipOwner, Me.btQuit, Me.btSave, Me.btAdd, Me.txtCode, Me.Label5, Me.Label4, Me.txtType, Me.Label3, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConType_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "��װ��������Ϣ_����"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub txtType_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtType.KeyPress
        If e.KeyChar = Chr(13) Then
            txtShipOwner.Focus()
        End If
    End Sub

    Private Sub txtShipOwner_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtShipOwner.KeyPress
        If e.KeyChar = Chr(13) Then
            txtCode.Focus()
        End If
    End Sub

    Private Sub txtCode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call btSave_Click(sender, e)
            txtType.Focus()
        End If
    End Sub

    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim ds1 As New DataSet()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen
        sqlstr = "select CODE_SHIPOWNER,SHIPOWNER_SHORT from CODE_SHIP_OWNER Order by SHIPOWNER_SHORT"
        dw = Getdata(sqlstr, ds1)
        txtShipOwner.DataSource = ds1.Tables(0).DefaultView
        txtShipOwner.DisplayMember = "SHIPOWNER_SHORT"
        txtShipOwner.ValueMember = "CODE_SHIPOWNER"

        sqlstr = "select * from code_Con_Type where code_Con_Type_ID=" & ID & ""

        dw = Updatedata(sqlda, sqlstr, ds)
        If dw.Count > 0 Then

            txtID.Text = ds.Tables(0).Rows(0).Item("CODE_CON_TYPE_ID")
            txtType.Text = ds.Tables(0).Rows(0).Item("CODE_CON_TYPE")
            txtShipOwner.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_SHIP_OWNER")
            txtCode.Text = ds.Tables(0).Rows(0).Item("CODE_SHIP_TYPE")
        End If


        txtCode.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        txtType.Text = ""
        txtCode.Text = ""
        
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            Dim dsSave As New DataSet()
            If Getdata("select * from Code_Con_Type where Code_Con_Type='" & Trim(txtType.Text) & "' and CODE_SHIP_OWNER='" & Trim(txtShipOwner.SelectedValue) & "' and Code_Ship_Type='" & txtCode.Text & "'", dsSave).Count > 0 Then
                MsgBox("�����Ѵ��ڴ�������Ϣ,��ע����!")
                Exit Sub
            End If
            If Len(Trim(txtCode.Text)) > 0 And Len(Trim(txtType.Text)) > 0 And Len(Trim(txtShipOwner.Text)) > 0 Then
                Dim row As DataRow
                row = ds.Tables(0).NewRow()

                row("Code_Con_Type") = Trim(txtType.Text)
                row("CODE_SHIP_TYPE") = Trim(txtCode.Text)
                row("Code_Ship_Owner") = Trim(txtShipOwner.SelectedValue)
                row("User_Name") = Trim(G_User)


                ds.Tables(0).Rows.Add(row)
                sqlda.Update(ds)
                Me.Close()
            Else
                MsgBox("���ʹ���,����˾����Ӧ���벻��Ϊ��!", MsgBoxStyle.Critical, "��ʾ")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class
