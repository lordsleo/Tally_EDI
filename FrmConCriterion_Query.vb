Imports TALLY.DBControl
Public Class FrmConCriterion_Query
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
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
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbCon As System.Windows.Forms.ComboBox
    Friend WithEvents cbShip As System.Windows.Forms.ComboBox
    Friend WithEvents cbNat As System.Windows.Forms.ComboBox
    Friend WithEvents txtLeft As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSequence As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBehind As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBefore As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtRight As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents txtHeight As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSize As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbCon = New System.Windows.Forms.ComboBox()
        Me.cbShip = New System.Windows.Forms.ComboBox()
        Me.cbNat = New System.Windows.Forms.ComboBox()
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
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(2, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 16)
        Me.Label14.TabIndex = 245
        Me.Label14.Text = "箱公司"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(2, 52)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 16)
        Me.Label13.TabIndex = 244
        Me.Label13.Text = "船公司"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(2, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 14)
        Me.Label12.TabIndex = 243
        Me.Label12.Text = "国籍"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbCon
        '
        Me.cbCon.Location = New System.Drawing.Point(64, 78)
        Me.cbCon.Name = "cbCon"
        Me.cbCon.Size = New System.Drawing.Size(142, 20)
        Me.cbCon.TabIndex = 242
        '
        'cbShip
        '
        Me.cbShip.Location = New System.Drawing.Point(64, 52)
        Me.cbShip.Name = "cbShip"
        Me.cbShip.Size = New System.Drawing.Size(142, 20)
        Me.cbShip.TabIndex = 241
        '
        'cbNat
        '
        Me.cbNat.Location = New System.Drawing.Point(64, 26)
        Me.cbNat.Name = "cbNat"
        Me.cbNat.Size = New System.Drawing.Size(142, 20)
        Me.cbNat.TabIndex = 240
        '
        'txtLeft
        '
        Me.txtLeft.Location = New System.Drawing.Point(260, 26)
        Me.txtLeft.Name = "txtLeft"
        Me.txtLeft.Size = New System.Drawing.Size(152, 21)
        Me.txtLeft.TabIndex = 239
        Me.txtLeft.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(208, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 20)
        Me.Label11.TabIndex = 238
        Me.Label11.Text = "左超"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSequence
        '
        Me.txtSequence.Location = New System.Drawing.Point(260, 132)
        Me.txtSequence.MaxLength = 40
        Me.txtSequence.Name = "txtSequence"
        Me.txtSequence.Size = New System.Drawing.Size(152, 21)
        Me.txtSequence.TabIndex = 237
        Me.txtSequence.Text = ""
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(260, 160)
        Me.txtAmount.MaxLength = 10
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(152, 21)
        Me.txtAmount.TabIndex = 236
        Me.txtAmount.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(208, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 18)
        Me.Label6.TabIndex = 235
        Me.Label6.Text = "核对数"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(208, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 18)
        Me.Label7.TabIndex = 234
        Me.Label7.Text = "顺序号"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBehind
        '
        Me.txtBehind.Location = New System.Drawing.Point(260, 104)
        Me.txtBehind.MaxLength = 40
        Me.txtBehind.Name = "txtBehind"
        Me.txtBehind.Size = New System.Drawing.Size(152, 21)
        Me.txtBehind.TabIndex = 233
        Me.txtBehind.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(208, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 18)
        Me.Label8.TabIndex = 232
        Me.Label8.Text = "后超"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBefore
        '
        Me.txtBefore.Location = New System.Drawing.Point(260, 78)
        Me.txtBefore.MaxLength = 40
        Me.txtBefore.Name = "txtBefore"
        Me.txtBefore.Size = New System.Drawing.Size(152, 21)
        Me.txtBefore.TabIndex = 231
        Me.txtBefore.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(208, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 18)
        Me.Label9.TabIndex = 230
        Me.Label9.Text = "前超"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtRight
        '
        Me.txtRight.Location = New System.Drawing.Point(260, 52)
        Me.txtRight.MaxLength = 20
        Me.txtRight.Name = "txtRight"
        Me.txtRight.Size = New System.Drawing.Size(152, 21)
        Me.txtRight.TabIndex = 229
        Me.txtRight.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(208, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 18)
        Me.Label10.TabIndex = 228
        Me.Label10.Text = "右超"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(62, 160)
        Me.txtWeight.MaxLength = 40
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(144, 21)
        Me.txtWeight.TabIndex = 227
        Me.txtWeight.Text = ""
        '
        'btQuit
        '
        Me.btQuit.Location = New System.Drawing.Point(172, 196)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 225
        Me.btQuit.Text = "返回"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(260, 0)
        Me.txtHeight.MaxLength = 40
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(152, 21)
        Me.txtHeight.TabIndex = 223
        Me.txtHeight.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(208, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 18)
        Me.Label5.TabIndex = 222
        Me.Label5.Text = "超高"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(2, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 18)
        Me.Label4.TabIndex = 221
        Me.Label4.Text = "箱皮重"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(62, 132)
        Me.txtType.MaxLength = 40
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(144, 21)
        Me.txtType.TabIndex = 220
        Me.txtType.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 18)
        Me.Label3.TabIndex = 219
        Me.Label3.Text = "箱类别"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSize
        '
        Me.txtSize.Location = New System.Drawing.Point(62, 102)
        Me.txtSize.MaxLength = 40
        Me.txtSize.Name = "txtSize"
        Me.txtSize.Size = New System.Drawing.Size(144, 21)
        Me.txtSize.TabIndex = 218
        Me.txtSize.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 18)
        Me.Label2.TabIndex = 217
        Me.Label2.Text = "箱尺寸"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(62, 0)
        Me.txtNo.MaxLength = 2
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(144, 21)
        Me.txtNo.TabIndex = 216
        Me.txtNo.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 18)
        Me.Label1.TabIndex = 215
        Me.Label1.Text = "箱号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(2, 0)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 226
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'FrmConCriterion_Query
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(414, 221)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label14, Me.Label13, Me.Label12, Me.cbCon, Me.cbShip, Me.cbNat, Me.txtLeft, Me.Label11, Me.txtSequence, Me.txtAmount, Me.Label6, Me.Label7, Me.txtBehind, Me.Label8, Me.txtBefore, Me.Label9, Me.txtRight, Me.Label10, Me.txtWeight, Me.btQuit, Me.txtHeight, Me.Label5, Me.Label4, Me.txtType, Me.Label3, Me.txtSize, Me.Label2, Me.txtNo, Me.Label1, Me.txtID})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConCriterion_Query"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "集装箱箱规范信息_查询"
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

        dw = Getdata(sqlstr, ds)
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

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

End Class
