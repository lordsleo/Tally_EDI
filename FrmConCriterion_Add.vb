Imports TALLY.DBControl
Public Class FrmConCriterion_Add
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter()
#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写处置以清理组件列表。
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

    '注意：以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btAdd As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbNat As System.Windows.Forms.ComboBox
    Friend WithEvents cbShip As System.Windows.Forms.ComboBox
    Friend WithEvents cbCon As System.Windows.Forms.ComboBox
    Friend WithEvents txtLeft As System.Windows.Forms.TextBox
    Friend WithEvents txtSequence As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtBehind As System.Windows.Forms.TextBox
    Friend WithEvents txtBefore As System.Windows.Forms.TextBox
    Friend WithEvents txtRight As System.Windows.Forms.TextBox
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents txtSize As System.Windows.Forms.TextBox
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtLeft = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSequence = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBehind = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBefore = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRight = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.btQuit = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSize = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cbNat = New System.Windows.Forms.ComboBox()
        Me.cbShip = New System.Windows.Forms.ComboBox()
        Me.cbCon = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtLeft
        '
        Me.txtLeft.Location = New System.Drawing.Point(260, 28)
        Me.txtLeft.Name = "txtLeft"
        Me.txtLeft.Size = New System.Drawing.Size(152, 21)
        Me.txtLeft.TabIndex = 176
        Me.txtLeft.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(208, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 20)
        Me.Label11.TabIndex = 175
        Me.Label11.Text = "左超"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSequence
        '
        Me.txtSequence.Location = New System.Drawing.Point(260, 134)
        Me.txtSequence.MaxLength = 40
        Me.txtSequence.Name = "txtSequence"
        Me.txtSequence.Size = New System.Drawing.Size(152, 21)
        Me.txtSequence.TabIndex = 174
        Me.txtSequence.Text = ""
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(260, 162)
        Me.txtAmount.MaxLength = 10
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(152, 21)
        Me.txtAmount.TabIndex = 173
        Me.txtAmount.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(208, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 18)
        Me.Label6.TabIndex = 172
        Me.Label6.Text = "核对数"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(208, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 18)
        Me.Label7.TabIndex = 171
        Me.Label7.Text = "顺序号"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBehind
        '
        Me.txtBehind.Location = New System.Drawing.Point(260, 106)
        Me.txtBehind.MaxLength = 40
        Me.txtBehind.Name = "txtBehind"
        Me.txtBehind.Size = New System.Drawing.Size(152, 21)
        Me.txtBehind.TabIndex = 170
        Me.txtBehind.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(208, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 18)
        Me.Label8.TabIndex = 169
        Me.Label8.Text = "后超"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBefore
        '
        Me.txtBefore.Location = New System.Drawing.Point(260, 80)
        Me.txtBefore.MaxLength = 40
        Me.txtBefore.Name = "txtBefore"
        Me.txtBefore.Size = New System.Drawing.Size(152, 21)
        Me.txtBefore.TabIndex = 168
        Me.txtBefore.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(208, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 18)
        Me.Label9.TabIndex = 167
        Me.Label9.Text = "前超"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRight
        '
        Me.txtRight.Location = New System.Drawing.Point(260, 54)
        Me.txtRight.MaxLength = 20
        Me.txtRight.Name = "txtRight"
        Me.txtRight.Size = New System.Drawing.Size(152, 21)
        Me.txtRight.TabIndex = 166
        Me.txtRight.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(208, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 18)
        Me.Label10.TabIndex = 165
        Me.Label10.Text = "右超"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(62, 162)
        Me.txtWeight.MaxLength = 40
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(144, 21)
        Me.txtWeight.TabIndex = 164
        Me.txtWeight.Text = ""
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(243, 194)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 162
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(175, 194)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 161
        Me.btSave.Text = "确认"
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(107, 194)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(65, 24)
        Me.btAdd.TabIndex = 160
        Me.btAdd.Text = "清空"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(260, 2)
        Me.txtHeight.MaxLength = 40
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(152, 21)
        Me.txtHeight.TabIndex = 159
        Me.txtHeight.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(208, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 18)
        Me.Label5.TabIndex = 158
        Me.Label5.Text = "超高"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(2, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 18)
        Me.Label4.TabIndex = 157
        Me.Label4.Text = "箱皮重"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(62, 134)
        Me.txtType.MaxLength = 40
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(144, 21)
        Me.txtType.TabIndex = 156
        Me.txtType.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 18)
        Me.Label3.TabIndex = 155
        Me.Label3.Text = "箱类别"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(62, 104)
        Me.txtSize.MaxLength = 40
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(144, 21)
        Me.txtSize.TabIndex = 154
        Me.txtSize.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 18)
        Me.Label2.TabIndex = 153
        Me.Label2.Text = "箱尺寸"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(62, 2)
        Me.txtNo.MaxLength = 2
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(144, 21)
        Me.txtNo.TabIndex = 152
        Me.txtNo.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 18)
        Me.Label1.TabIndex = 151
        Me.Label1.Text = "箱号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 163
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'cbNat
        '
        Me.cbNat.Location = New System.Drawing.Point(64, 28)
        Me.cbNat.Name = "cbNat"
        Me.cbNat.Size = New System.Drawing.Size(142, 20)
        Me.cbNat.TabIndex = 177
        '
        'cbShip
        '
        Me.cbShip.Location = New System.Drawing.Point(64, 54)
        Me.cbShip.Name = "cbShip"
        Me.cbShip.Size = New System.Drawing.Size(142, 20)
        Me.cbShip.TabIndex = 178
        '
        'cbCon
        '
        Me.cbCon.Location = New System.Drawing.Point(64, 80)
        Me.cbCon.Name = "cbCon"
        Me.cbCon.Size = New System.Drawing.Size(142, 20)
        Me.cbCon.TabIndex = 179
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(2, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 14)
        Me.Label12.TabIndex = 180
        Me.Label12.Text = "国籍"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(2, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 16)
        Me.Label13.TabIndex = 181
        Me.Label13.Text = "船公司"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(2, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 16)
        Me.Label14.TabIndex = 182
        Me.Label14.Text = "箱公司"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmConCriterion_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(414, 221)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label14, Me.Label13, Me.Label12, Me.cbCon, Me.cbShip, Me.cbNat, Me.txtLeft, Me.Label11, Me.txtSequence, Me.txtAmount, Me.Label6, Me.Label7, Me.txtBehind, Me.Label8, Me.txtBefore, Me.Label9, Me.txtRight, Me.Label10, Me.txtWeight, Me.btQuit, Me.btSave, Me.btAdd, Me.txtHeight, Me.Label5, Me.Label4, Me.txtType, Me.Label3, Me.txtSize, Me.Label2, Me.txtNo, Me.Label1, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConCriterion_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "集装箱箱规范信息_增加"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub txtNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNo.KeyPress
        If e.KeyChar = Chr(13) Then
            cbNat.Focus()
        End If
    End Sub

    Private Sub cbNat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbNat.KeyPress
        If e.KeyChar = Chr(13) Then
            cbShip.Focus()
        End If
    End Sub
    Private Sub cbShip_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbShip.KeyPress
        If e.KeyChar = Chr(13) Then
            cbCon.Focus()
        End If
    End Sub
    Private Sub cbCon_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbCon.KeyPress
        If e.KeyChar = Chr(13) Then
            txtSize.Focus()
        End If
    End Sub
    Private Sub txtSize_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSize.KeyPress
        If e.KeyChar = Chr(13) Then
            txtType.Focus()
        End If
    End Sub
    Private Sub txtType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtType.KeyPress
        If e.KeyChar = Chr(13) Then
            txtWeight.Focus()
        End If
    End Sub
    Private Sub txtWeight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWeight.KeyPress
        If e.KeyChar = Chr(13) Then
            txtHeight.Focus()
        End If
    End Sub
    Private Sub txtHeight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHeight.KeyPress
        If e.KeyChar = Chr(13) Then
            txtLeft.Focus()
        End If
    End Sub
    Private Sub txtLeft_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLeft.KeyPress
        If e.KeyChar = Chr(13) Then
            txtRight.Focus()
        End If
    End Sub
    Private Sub txtRight_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRight.KeyPress
        If e.KeyChar = Chr(13) Then
            txtBefore.Focus()
        End If
    End Sub
    Private Sub txtBefore_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBefore.KeyPress
        If e.KeyChar = Chr(13) Then
            txtBehind.Focus()
        End If
    End Sub
    Private Sub txtBehind_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBehind.KeyPress
        If e.KeyChar = Chr(13) Then
            txtSequence.Focus()
        End If
    End Sub
    Private Sub txtSequence_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSequence.KeyPress
        If e.KeyChar = Chr(13) Then
            txtAmount.Focus()
        End If
    End Sub

    Private Sub txtAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        If e.KeyChar = Chr(13) Then
            btSave.Focus()
        End If
    End Sub

    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim ds1 As New DataSet()
        Dim ds2 As New DataSet()
        Dim ds3 As New DataSet()
        Dim sqlstr As String
        Me.StartPosition = FormStartPosition.CenterScreen

        sqlstr = "select NATIONALITY_ENG,NATIONALITY_CHA from CODE_NATIONALITY Order by NATIONALITY_ENG"
        dw = Getdata(sqlstr, ds1)
        cbNat.DataSource = ds1.Tables(0).DefaultView
        cbNat.DisplayMember = "NATIONALITY_CHA"
        cbNat.ValueMember = "NATIONALITY_ENG"

        sqlstr = "select CODE_SHIPOWNER,ShipOWNER_CHA from CODE_SHIP_OWNER Order by CODE_SHIPOWNER"
        dw = Getdata(sqlstr, ds2)
        cbShip.DataSource = ds2.Tables(0).DefaultView
        cbShip.DisplayMember = "ShipOWNER_CHA"
        cbShip.ValueMember = "CODE_SHIPOWNER"

        sqlstr = "select CODE_SHIPOWNER,ShipOWNER_CHA from CODE_SHIP_OWNER Order by CODE_SHIPOWNER"
        dw = Getdata(sqlstr, ds3)
        cbCon.DataSource = ds3.Tables(0).DefaultView
        cbCon.DisplayMember = "ShipOWNER_CHA"
        cbCon.ValueMember = "CODE_SHIPOWNER"

        sqlstr = "select * from CON_CRITERION where CON_CRITERION_ID=" & ID & ""

        dw = Updatedata(sqlda, sqlstr, ds)
        If dw.Count > 0 Then

            txtID.Text = ds.Tables(0).Rows(0).Item("CON_CRITERION_ID")
            txtNo.Text = ds.Tables(0).Rows(0).Item("CONTAINER_NO")
            cbNat.SelectedValue = ds.Tables(0).Rows(0).Item("NATIONALITY_CODE")
            txtSize.Text = ds.Tables(0).Rows(0).Item("SIZE_CON")
            txtType.Text = ds.Tables(0).Rows(0).Item("CONTAINER_TYPE")
            cbCon.SelectedValue = ds.Tables(0).Rows(0).Item("Code_Con_Company")
            cbShip.SelectedValue = ds.Tables(0).Rows(0).Item("CODE_SHIP_OWNER")
            txtWeight.Text = ds.Tables(0).Rows(0).Item("CON_WEIGHT")
            txtHeight.Text = ds.Tables(0).Rows(0).Item("OVER_Height")
            txtLeft.Text = ds.Tables(0).Rows(0).Item("OVER_LEFT")
            txtRight.Text = ds.Tables(0).Rows(0).Item("OVER_RIGHT")
            txtBefore.Text = ds.Tables(0).Rows(0).Item("OVER_BEFORE")
            txtBehind.Text = ds.Tables(0).Rows(0).Item("OVER_BEHIND")
            txtSequence.Text = ds.Tables(0).Rows(0).Item("SEQUENCE_NO")
            txtAmount.Text = ds.Tables(0).Rows(0).Item("CHECK_AMOUNT")
        End If


        txtNo.Focus()

        Exit Sub
Err:
        Resume Next
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        txtSize.Text = ""
        txtNo.Text = ""
        txtType.Text = ""
        txtHeight.Text = ""
        txtLeft.Text = ""
        txtWeight.Text = ""
        txtRight.Text = ""
        txtBefore.Text = ""
        txtBehind.Text = ""
        txtSequence.Text = ""
        txtAmount.Text = ""
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            Dim dsSave As New DataSet()
            If Getdata("select * from CON_CRITERION where CONTAINER_NO='" & Trim(txtNo.Text) & "'", dsSave).Count > 0 Then
                MsgBox("可能已存在此箱号信息,请注意检查!")
                Exit Sub
            End If
            If Len(Trim(txtNo.Text)) > 0 Then
                Dim row As DataRow
                row = ds.Tables(0).NewRow()

                row("CONTAINER_NO") = txtNo.Text
                row("NATIONALITY_CODE") = cbNat.SelectedValue
                If Len(Trim(txtSize.Text)) > 0 Then
                    row("SIZE_CON") = txtSize.Text
                End If
                row("CONTAINER_TYPE") = txtType.Text
                row("Code_Con_Company") = cbCon.SelectedValue
                row("CODE_SHIP_OWNER") = cbShip.SelectedValue
                If Len(Trim(txtWeight.Text)) > 0 Then
                    row("CON_WEIGHT") = txtWeight.Text
                End If
                If Len(Trim(txtHeight.Text)) > 0 Then
                    row("OVER_Height") = txtHeight.Text
                End If
                If Len(Trim(txtLeft.Text)) > 0 Then
                    row("OVER_LEFT") = txtLeft.Text
                End If
                If Len(Trim(txtRight.Text)) > 0 Then
                    row("OVER_RIGHT") = txtRight.Text
                End If
                If Len(Trim(txtBefore.Text)) > 0 Then
                    row("OVER_BEFORE") = txtBefore.Text
                End If
                If Len(Trim(txtBehind.Text)) > 0 Then
                    row("OVER_BEHIND") = txtBehind.Text
                End If
                If Len(Trim(txtSequence.Text)) > 0 Then
                    row("SEQUENCE_NO") = txtSequence.Text
                End If
                If Len(Trim(txtAmount.Text)) > 0 Then
                    row("CHECK_AMOUNT") = txtAmount.Text
                End If
                ds.Tables(0).Rows.Add(row)
                sqlda.Update(ds)
                Me.Close()
            Else
                MsgBox("箱号不能为空!", MsgBoxStyle.Critical, "提示")
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

End Class
