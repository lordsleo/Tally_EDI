Imports TALLY.DBControl
Public Class FrmPort_Add
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
    Dim sqlda_sub As New SqlClient.SqlDataAdapter()
    Dim ds_sub As New DataSet()
    Dim dw As New DataView()
#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮�������κγ�ʼ��

    End Sub

    '������д��������������б���
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
    Friend WithEvents txtNationality As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtENG As System.Windows.Forms.TextBox
    Friend WithEvents txtCHA As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtShort As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnResume As System.Windows.Forms.Button
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPort_Add))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines()
        Me.txtNationality = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtENG = New System.Windows.Forms.TextBox()
        Me.txtCHA = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtShort = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.btnResume = New System.Windows.Forms.Button()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNationality
        '
        Me.txtNationality.Location = New System.Drawing.Point(84, 76)
        Me.txtNationality.Name = "txtNationality"
        Me.txtNationality.Size = New System.Drawing.Size(258, 20)
        Me.txtNationality.TabIndex = 118
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "��������"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtENG
        '
        Me.txtENG.Location = New System.Drawing.Point(84, 52)
        Me.txtENG.MaxLength = 20
        Me.txtENG.Name = "txtENG"
        Me.txtENG.Size = New System.Drawing.Size(258, 21)
        Me.txtENG.TabIndex = 115
        Me.txtENG.Text = ""
        '
        'txtCHA
        '
        Me.txtCHA.Location = New System.Drawing.Point(84, 28)
        Me.txtCHA.MaxLength = 20
        Me.txtCHA.Name = "txtCHA"
        Me.txtCHA.Size = New System.Drawing.Size(258, 21)
        Me.txtCHA.TabIndex = 114
        Me.txtCHA.Text = ""
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(84, 4)
        Me.txtCode.MaxLength = 6
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(258, 21)
        Me.txtCode.TabIndex = 113
        Me.txtCode.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 18)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "�ۿ�Ӣ������"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "�ۿ���������"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "�ۿڴ���"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(210, 124)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 108
        Me.btQuit.Text = "ȡ��"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(142, 124)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 107
        Me.btSave.Text = "ȷ��"
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(74, 124)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(65, 24)
        Me.btAdd.TabIndex = 106
        Me.btAdd.Text = "���"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 105
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'txtShort
        '
        Me.txtShort.Location = New System.Drawing.Point(84, 98)
        Me.txtShort.MaxLength = 4
        Me.txtShort.Name = "txtShort"
        Me.txtShort.Size = New System.Drawing.Size(258, 21)
        Me.txtShort.TabIndex = 124
        Me.txtShort.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 18)
        Me.Label6.TabIndex = 121
        Me.Label6.Text = "������"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C1DBG
        '
        Me.C1DBG.AllowAddNew = True
        Me.C1DBG.AllowDelete = True
        Me.C1DBG.AllowFilter = True
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1DBG.AllowSort = True
        Me.C1DBG.Caption = "��ش���˾�ۿڴ����"
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.CollapseColor = System.Drawing.Color.Black
        Me.C1DBG.DataChanged = False
        Me.C1DBG.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1DBG.ExpandColor = System.Drawing.Color.Black
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource.Images"), System.Drawing.Bitmap))
        Me.C1DBG.Location = New System.Drawing.Point(0, 152)
        Me.C1DBG.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.ShowOptionsDialog = False
        Me.C1DBG.RecordSelectorWidth = 16
        GridLines1.Color = System.Drawing.Color.DarkGray
        GridLines1.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG.RowDivider = GridLines1
        Me.C1DBG.RowHeight = 16
        Me.C1DBG.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG.ScrollTips = False
        Me.C1DBG.Size = New System.Drawing.Size(344, 150)
        Me.C1DBG.TabIndex = 125
        Me.C1DBG.Text = "C1TrueDBGrid1"
        Me.C1DBG.PropBag = CType(resources.GetObject("C1DBG.PropBag"), String)
        '
        'btnResume
        '
        Me.btnResume.Location = New System.Drawing.Point(128, 306)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(65, 24)
        Me.btnResume.TabIndex = 126
        Me.btnResume.Text = "ȷ��"
        '
        'FrmPort_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(346, 333)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnResume, Me.C1DBG, Me.txtShort, Me.Label6, Me.txtNationality, Me.Label5, Me.txtENG, Me.txtCHA, Me.txtCode, Me.Label3, Me.Label2, Me.Label1, Me.btQuit, Me.btSave, Me.btAdd, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPort_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "�ۿ���Ϣ_����"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub txtCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        If e.KeyChar = Chr(13) Then
            txtCHA.Focus()
        End If
    End Sub
    Private Sub txtCHA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCHA.KeyPress
        If e.KeyChar = Chr(13) Then
            txtENG.Focus()
        End If
    End Sub
    Private Sub txtENG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtENG.KeyPress
        If e.KeyChar = Chr(13) Then
            txtNationality.Focus()
        End If
    End Sub

    Private Sub txtNationality_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNationality.KeyPress
        If e.KeyChar = Chr(13) Then
            txtShort.Focus()
        End If
    End Sub

    Private Sub txtShort_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtShort.KeyPress
        If e.KeyChar = Chr(13) Then
            btSave.Focus()
        End If
    End Sub

    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim ds1 As New DataSet()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen
        sqlstr = "select NATIONALITY_ENG,NATIONALITY_CHA from Code_Nationality Order by NATIONALITY_CHA"
        dw = Getdata(sqlstr, ds1)
        txtNationality.DataSource = ds1.Tables(0).DefaultView
        txtNationality.DisplayMember = "NATIONALITY_CHA"
        txtNationality.ValueMember = "NATIONALITY_ENG"

        sqlstr = "select * from code_Port where Port_ID=" & ID & ""

        dw = Updatedata(sqlda, sqlstr, ds)
        If dw.Count > 0 Then

            txtID.Text = ds.Tables(0).Rows(0).Item("Port_ID")
            txtCode.Text = ds.Tables(0).Rows(0).Item("code_port")
            txtCHA.Text = ds.Tables(0).Rows(0).Item("Port_Cha")
            txtENG.Text = ds.Tables(0).Rows(0).Item("Port_Eng")
            txtNationality.SelectedValue = ds.Tables(0).Rows(0).Item("Code_Nationality")
            txtShort.Text = ds.Tables(0).Rows(0).Item("Port_Short")
        End If


        txtCode.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        txtCode.Enabled = True
        txtCHA.Text = ""
        txtENG.Text = ""
        txtCode.Text = ""
        txtShort.Text = ""
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            Dim dsSave As New DataSet()
            Dim str As String
            Dim sqla As New SqlClient.SqlDataAdapter()
            Dim sqlc As New SqlClient.SqlCommand()
            Dim ds1 As New DataSet()
            Dim i As Integer
            If Getdata("select * from Code_Port where Code_Port='" & Trim(txtCode.Text) & "'", dsSave).Count > 0 Then
                MsgBox("�����Ѵ��ڴ˸ۿ���Ϣ,��ע����!")
                Exit Sub
            End If
            If Len(Trim(txtCode.Text)) > 0 And Len(Trim(txtCHA.Text)) > 0 Then
                Dim row As DataRow
                row = ds.Tables(0).NewRow()

                row("Code_Port") = Trim(txtCode.Text)
                row("port_cha") = Trim(txtCHA.Text)
                row("port_eng") = Trim(txtENG.Text)
                row("Code_Nationality") = Trim(txtNationality.SelectedValue)
                row("Port_Short") = Trim(txtShort.Text)
                row("User_Name") = Trim(G_User)


                ds.Tables(0).Rows.Add(row)
                sqlda.Update(ds)
                txtCode.Enabled = False

                '****************��ش���˾�ۿڴ����
                Str = "select * from Code_Port_Relation where Code_Port='" & Trim(txtCode.Text) & "'"
                ds_sub.Reset()
                dw = Updatedata(sqlda_sub, str, ds_sub)
                Me.C1DBG.DataSource = dw
                Me.C1DBG.Refresh()
                If ds_sub.Tables(0).Rows.Count = 0 Then
                    Me.C1DBG.Select()
                    Me.C1DBG.Row = Me.C1DBG.Row + 1
                    Me.C1DBG.Columns.Item("Code_Port").Value = Trim(txtCode.Text)
                End If
                '************����˾����
                Me.C1DBG.Columns.Item(2).ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
                Me.C1DBG.Columns.Item(2).ValueItems.Translate = True
                Me.C1DBG.Columns.Item(2).ValueItems.Validate = True

                sqlc.Connection = sqlconn

                sqlc.CommandText = "select * from CODE_SHIP_OWNER order by SHIPOWNER_SHORT"

                sqla.SelectCommand = sqlc
                ds1.Reset()
                sqla.Fill(ds1)
                For i = 0 To ds1.Tables(0).Rows.Count - 1
                    Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
                    vi.DisplayValue = Trim(ds1.Tables(0).Rows(i)("SHIPOWNER_SHORT"))
                    vi.Value = Trim(ds1.Tables(0).Rows(i)("CODE_SHIPOWNER"))

                    Me.C1DBG.Columns.Item(2).ValueItems.Values.Add(vi)
                Next
                '***************��ʼ��
                Me.C1DBG.Splits(0).DisplayColumns.Item(0).Visible = False
                Me.C1DBG.Splits(0).DisplayColumns.Item(1).Visible = False
                Me.C1DBG.Columns.Item(2).Caption = "����˾"
                Me.C1DBG.Columns.Item(3).Caption = "�ۿڴ���"
                Me.C1DBG.Columns.Item(4).Caption = "�ۿ�����"

                Me.C1DBG.Refresh()
            Else
                MsgBox("����,���Ʋ���Ϊ��!", MsgBoxStyle.Critical, "��ʾ")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub btnResume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResume.Click
        Try
            sqlda_sub.Update(ds_sub)
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
        Me.Close()
    End Sub

    Private Sub C1DBG_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles C1DBG.RowColChange
        Try
            If Me.C1DBG.Columns.Item("Code_Port").Text = "" Then
                Me.C1DBG.Columns.Item("Code_Port").Value = Trim(txtCode.Text)
                Me.C1DBG.Refresh()
            End If
        Catch ex As System.Exception
        End Try
    End Sub
End Class