Imports TALLY.DBControl
Public Class FrmConTypeRelation_Add
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
    Friend WithEvents txtShipOwner As System.Windows.Forms.ComboBox
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtCon As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtShipOwner = New System.Windows.Forms.ComboBox()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.txtCon = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtShipOwner
        '
        Me.txtShipOwner.Location = New System.Drawing.Point(96, 2)
        Me.txtShipOwner.Name = "txtShipOwner"
        Me.txtShipOwner.Size = New System.Drawing.Size(136, 20)
        Me.txtShipOwner.TabIndex = 132
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(152, 86)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 130
        Me.btQuit.Text = "ȡ��"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(84, 86)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 129
        Me.btSave.Text = "ȷ��"
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(16, 86)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(65, 24)
        Me.btAdd.TabIndex = 128
        Me.btAdd.Text = "���"
        '
        'txtCon
        '
        Me.txtCon.Location = New System.Drawing.Point(96, 58)
        Me.txtCon.MaxLength = 12
        Me.txtCon.Name = "txtCon"
        Me.txtCon.Size = New System.Drawing.Size(136, 21)
        Me.txtCon.TabIndex = 127
        Me.txtCon.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(4, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 18)
        Me.Label5.TabIndex = 126
        Me.Label5.Text = "��׼���ʹ���"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 18)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "����˾"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(96, 30)
        Me.txtCode.MaxLength = 12
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(136, 21)
        Me.txtCode.TabIndex = 124
        Me.txtCode.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 18)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "����˾���ʹ���"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(0, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 131
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'FrmConTypeRelation_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(234, 111)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtShipOwner, Me.btQuit, Me.btSave, Me.btAdd, Me.txtCon, Me.Label5, Me.Label4, Me.txtCode, Me.Label3, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConTypeRelation_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "����˾�����ͱ�׼������_����"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub txtShipOwner_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtShipOwner.KeyPress
        If e.KeyChar = Chr(13) Then
            txtCode.Focus()
        End If
    End Sub

    Private Sub txtCode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        If e.KeyChar = Chr(13) Then
            txtCon.Focus()
        End If
    End Sub



    Private Sub txtCon_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCon.KeyPress
        If e.KeyChar = Chr(13) Then
            Call btSave_Click(sender, e)
            txtShipOwner.Focus()
        End If
    End Sub

    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim ds1 As New DataSet()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen
        sqlstr = "select CODE_SHIPOWNER,ShipOWNER_CHA from CODE_SHIP_OWNER Order by CODE_SHIPOWNER"
        dw = Getdata(sqlstr, ds1)
        txtShipOwner.DataSource = ds1.Tables(0).DefaultView
        txtShipOwner.DisplayMember = "ShipOWNER_CHA"
        txtShipOwner.ValueMember = "CODE_SHIPOWNER"

        sqlstr = "select * from CODE_CON_TYPE_RELATION where CODE_CON_TYPE_RELATION_ID=" & ID & ""

        dw = Updatedata(sqlda, sqlstr, ds)
        If dw.Count > 0 Then

            txtID.Text = ds.Tables(0).Rows(0).Item("CODE_CON_TYPE_RELATION_ID")
            txtShipOwner.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_SHIP_OWNER")
            txtCode.Text = ds.Tables(0).Rows(0).Item("CODE_CON_SHIP_TYPE")
            txtCon.Text = ds.Tables(0).Rows(0).Item("CODE_CON_TYPE_STANDARD")
        End If


        txtCode.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        txtCon.Text = ""
        txtCode.Text = ""

    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            Dim dsSave As New DataSet()
            If Getdata("select * from CODE_CON_TYPE_RELATION where CODE_CON_SHIP_TYPE='" & Trim(txtCode.Text) & "' and CODE_SHIP_OWNER='" & Trim(txtShipOwner.SelectedValue) & "'", dsSave).Count > 0 Then
                MsgBox("�����Ѵ��ڴ����ʹ���,����˾��Ϣ,��ע����!")
                Exit Sub
            End If
            If Len(Trim(txtCode.Text)) > 0 And Len(Trim(txtCon.Text)) > 0 And Len(Trim(txtShipOwner.Text)) > 0 Then
                Dim row As DataRow
                row = ds.Tables(0).NewRow()

                row("Code_Ship_Owner") = Trim(txtShipOwner.SelectedValue)
                row("CODE_CON_SHIP_TYPE") = Trim(txtCode.Text)
                row("CODE_CON_TYPE_STANDARD") = Trim(txtCon.Text)


                row("User_Name") = Trim(G_User)


                ds.Tables(0).Rows.Add(row)
                sqlda.Update(ds)
                Me.Close()
            Else
                MsgBox("����,��׼���벻��Ϊ��!", MsgBoxStyle.Critical, "��ʾ")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class
