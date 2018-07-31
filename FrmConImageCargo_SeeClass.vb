Imports TALLY.DBControl
Public Class FrmConImageCargo_SeeClass
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNull As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents txtHeight20 As System.Windows.Forms.TextBox
    Friend WithEvents txtChill20 As System.Windows.Forms.TextBox
    Friend WithEvents txtDanger20 As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpty20 As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpty40 As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpty45 As System.Windows.Forms.TextBox
    Friend WithEvents txtFull45 As System.Windows.Forms.TextBox
    Friend WithEvents txtFull40 As System.Windows.Forms.TextBox
    Friend WithEvents txtFull20 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtChill40 As System.Windows.Forms.TextBox
    Friend WithEvents txtChill45 As System.Windows.Forms.TextBox
    Friend WithEvents txtDanger40 As System.Windows.Forms.TextBox
    Friend WithEvents txtDanger45 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtNull = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.btQuit = New System.Windows.Forms.Button
        Me.txtHeight20 = New System.Windows.Forms.TextBox
        Me.txtChill20 = New System.Windows.Forms.TextBox
        Me.txtDanger20 = New System.Windows.Forms.TextBox
        Me.txtEmpty20 = New System.Windows.Forms.TextBox
        Me.txtEmpty40 = New System.Windows.Forms.TextBox
        Me.txtEmpty45 = New System.Windows.Forms.TextBox
        Me.txtFull45 = New System.Windows.Forms.TextBox
        Me.txtFull40 = New System.Windows.Forms.TextBox
        Me.txtFull20 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtChill40 = New System.Windows.Forms.TextBox
        Me.txtChill45 = New System.Windows.Forms.TextBox
        Me.txtDanger40 = New System.Windows.Forms.TextBox
        Me.txtDanger45 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(136, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 20)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "空箱"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNull
        '
        Me.txtNull.Location = New System.Drawing.Point(136, 106)
        Me.txtNull.Name = "txtNull"
        Me.txtNull.Size = New System.Drawing.Size(60, 21)
        Me.txtNull.TabIndex = 59
        Me.txtNull.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(72, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 20)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "无尺寸箱"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(162, 142)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 57
        Me.btQuit.Text = "返回"
        '
        'txtHeight20
        '
        Me.txtHeight20.Location = New System.Drawing.Point(264, 106)
        Me.txtHeight20.Name = "txtHeight20"
        Me.txtHeight20.Size = New System.Drawing.Size(60, 21)
        Me.txtHeight20.TabIndex = 56
        Me.txtHeight20.Text = ""
        '
        'txtChill20
        '
        Me.txtChill20.Location = New System.Drawing.Point(200, 30)
        Me.txtChill20.Name = "txtChill20"
        Me.txtChill20.Size = New System.Drawing.Size(60, 21)
        Me.txtChill20.TabIndex = 55
        Me.txtChill20.Text = ""
        '
        'txtDanger20
        '
        Me.txtDanger20.Location = New System.Drawing.Point(264, 30)
        Me.txtDanger20.Name = "txtDanger20"
        Me.txtDanger20.Size = New System.Drawing.Size(60, 21)
        Me.txtDanger20.TabIndex = 54
        Me.txtDanger20.Text = ""
        '
        'txtEmpty20
        '
        Me.txtEmpty20.Location = New System.Drawing.Point(136, 30)
        Me.txtEmpty20.Name = "txtEmpty20"
        Me.txtEmpty20.Size = New System.Drawing.Size(60, 21)
        Me.txtEmpty20.TabIndex = 53
        Me.txtEmpty20.Text = ""
        '
        'txtEmpty40
        '
        Me.txtEmpty40.Location = New System.Drawing.Point(136, 54)
        Me.txtEmpty40.Name = "txtEmpty40"
        Me.txtEmpty40.Size = New System.Drawing.Size(60, 21)
        Me.txtEmpty40.TabIndex = 52
        Me.txtEmpty40.Text = ""
        '
        'txtEmpty45
        '
        Me.txtEmpty45.Location = New System.Drawing.Point(136, 78)
        Me.txtEmpty45.Name = "txtEmpty45"
        Me.txtEmpty45.Size = New System.Drawing.Size(60, 21)
        Me.txtEmpty45.TabIndex = 51
        Me.txtEmpty45.Text = ""
        '
        'txtFull45
        '
        Me.txtFull45.Location = New System.Drawing.Point(72, 78)
        Me.txtFull45.Name = "txtFull45"
        Me.txtFull45.Size = New System.Drawing.Size(60, 21)
        Me.txtFull45.TabIndex = 50
        Me.txtFull45.Text = ""
        '
        'txtFull40
        '
        Me.txtFull40.Location = New System.Drawing.Point(72, 54)
        Me.txtFull40.Name = "txtFull40"
        Me.txtFull40.Size = New System.Drawing.Size(60, 21)
        Me.txtFull40.TabIndex = 49
        Me.txtFull40.Text = ""
        '
        'txtFull20
        '
        Me.txtFull20.Location = New System.Drawing.Point(72, 30)
        Me.txtFull20.Name = "txtFull20"
        Me.txtFull20.Size = New System.Drawing.Size(60, 21)
        Me.txtFull20.TabIndex = 48
        Me.txtFull20.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 20)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "20英尺"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 20)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "40英尺"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 20)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "45英尺"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(200, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "超高箱"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(264, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "危险品箱"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(200, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "冷藏箱"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(72, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "重箱"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtChill40
        '
        Me.txtChill40.Location = New System.Drawing.Point(200, 54)
        Me.txtChill40.Name = "txtChill40"
        Me.txtChill40.Size = New System.Drawing.Size(60, 21)
        Me.txtChill40.TabIndex = 64
        Me.txtChill40.Text = ""
        '
        'txtChill45
        '
        Me.txtChill45.Location = New System.Drawing.Point(200, 78)
        Me.txtChill45.Name = "txtChill45"
        Me.txtChill45.Size = New System.Drawing.Size(60, 21)
        Me.txtChill45.TabIndex = 65
        Me.txtChill45.Text = ""
        '
        'txtDanger40
        '
        Me.txtDanger40.Location = New System.Drawing.Point(264, 54)
        Me.txtDanger40.Name = "txtDanger40"
        Me.txtDanger40.Size = New System.Drawing.Size(60, 21)
        Me.txtDanger40.TabIndex = 66
        Me.txtDanger40.Text = ""
        '
        'txtDanger45
        '
        Me.txtDanger45.Location = New System.Drawing.Point(264, 78)
        Me.txtDanger45.Name = "txtDanger45"
        Me.txtDanger45.Size = New System.Drawing.Size(60, 21)
        Me.txtDanger45.TabIndex = 67
        Me.txtDanger45.Text = ""
        '
        'FrmConImageCargo_SeeClass
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(334, 175)
        Me.Controls.Add(Me.txtDanger45)
        Me.Controls.Add(Me.txtDanger40)
        Me.Controls.Add(Me.txtChill45)
        Me.Controls.Add(Me.txtChill40)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtNull)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.txtHeight20)
        Me.Controls.Add(Me.txtChill20)
        Me.Controls.Add(Me.txtDanger20)
        Me.Controls.Add(Me.txtEmpty20)
        Me.Controls.Add(Me.txtEmpty40)
        Me.Controls.Add(Me.txtEmpty45)
        Me.Controls.Add(Me.txtFull45)
        Me.Controls.Add(Me.txtFull40)
        Me.Controls.Add(Me.txtFull20)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConImageCargo_SeeClass"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "集装箱船图信息 总览"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Sum20, Sum40, Sum45 As Integer

    Private Sub FrmConImageCargo_SeeClass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i, j As Integer
        Dim sqlFull, sqlEmpty, sqlChill, SqlDanger, sqlHeight, sqlNull As String
        Dim dvFull As New DataView
        Dim dvEmpty As New DataView
        Dim dvChill As New DataView
        Dim dvDanger As New DataView
        Dim dvHeight As New DataView
        Dim dvNull As New DataView

        sqlFull = "SELECT COUNT(CON_IMAGE.CONTAINER_NO) AS ConSum, SIZE_CON " & _
            "FROM CON_IMAGE LEFT OUTER JOIN CON_CRITERION ON CON_IMAGE.CONTAINER_NO = CON_CRITERION.CONTAINER_NO " & _
            "WHERE (SHIP_ID = '" & Ship_ID & "') AND (FULLOREMPTY = 'F' OR FULLOREMPTY = 'L') GROUP BY SIZE_CON ORDER BY SIZE_CON "

        sqlEmpty = "SELECT COUNT(CON_IMAGE.CONTAINER_NO) AS ConSum, SIZE_CON " & _
            "FROM CON_IMAGE LEFT OUTER JOIN CON_CRITERION ON CON_IMAGE.CONTAINER_NO = CON_CRITERION.CONTAINER_NO " & _
            "WHERE (SHIP_ID = '" & Ship_ID & "') AND (FULLOREMPTY <> 'F' AND FULLOREMPTY <> 'L') GROUP BY SIZE_CON ORDER BY SIZE_CON "

        sqlChill = "SELECT COUNT(CON_IMAGE.CONTAINER_NO) AS ConSum, SIZE_CON FROM CON_IMAGE LEFT OUTER JOIN CON_CRITERION ON CON_IMAGE.CONTAINER_NO = CON_CRITERION.CONTAINER_NO WHERE SHIP_ID = '" & Ship_ID & "' AND CONTAINER_TYPE LIKE 'R%' AND (FULLOREMPTY = 'F' OR FULLOREMPTY = 'L')  GROUP BY SIZE_CON ORDER BY SIZE_CON "

        SqlDanger = "SELECT COUNT(CON_IMAGE.CONTAINER_NO) AS ConSum, SIZE_CON FROM CON_IMAGE LEFT OUTER JOIN CON_CRITERION ON CON_IMAGE.CONTAINER_NO = CON_CRITERION.CONTAINER_NO WHERE SHIP_ID = '" & Ship_ID & "' AND LEN(DANGER_GRADE) > 0 AND (FULLOREMPTY = 'F' OR FULLOREMPTY = 'L')  GROUP BY SIZE_CON ORDER BY SIZE_CON "

        sqlHeight = "SELECT COUNT(CON_IMAGE.CONTAINER_NO) AS ConSum FROM CON_IMAGE LEFT OUTER JOIN CON_CRITERION ON CON_IMAGE.CONTAINER_NO = CON_CRITERION.CONTAINER_NO WHERE SHIP_ID = '" & Ship_ID & "' AND OVER_Height > 0 "

        sqlNull = "SELECT COUNT(CON_IMAGE.CONTAINER_NO) AS ConSum FROM CON_IMAGE LEFT OUTER JOIN CON_CRITERION ON CON_IMAGE.CONTAINER_NO = CON_CRITERION.CONTAINER_NO WHERE SHIP_ID = '" & Ship_ID & "' AND SIZE_CON IS NULL "

        Try
            dvFull = Filldata(sqlFull)
            dvEmpty = Filldata(sqlEmpty)
            dvChill = Filldata(sqlChill)
            dvDanger = Filldata(SqlDanger)
            dvHeight = Filldata(sqlHeight)
            dvNull = Filldata(sqlNull)

            If dvNull.Count > 0 Then
                If dvNull(0)(0) > 0 Then
                    Me.txtNull.Text = dvNull(0)(0)
                End If
            End If
            If dvHeight.Count > 0 Then
                If dvHeight(0)(0) > 0 Then
                    Me.txtHeight20.Text = dvHeight(0)(0)
                End If
            End If
            'If dvDanger.Count > 0 Then
            '    If dvDanger(0)(0) > 0 Then
            '        Me.txtDanger20.Text = dvDanger(0)(0)
            '    End If
            'End If
            'If dvChill.Count > 0 Then
            '    If dvChill(0)(0) > 0 Then
            '        Me.txtChill20.Text = dvChill(0)(0)
            '    End If
            'End If

            Call Statistics(dvFull)
            Me.txtFull20.Text = Sum20
            Me.txtFull40.Text = Sum40
            Me.txtFull45.Text = Sum45

            Call Statistics(dvEmpty)
            Me.txtEmpty20.Text = Sum20
            Me.txtEmpty40.Text = Sum40
            Me.txtEmpty45.Text = Sum45

            Call Statistics(dvChill)
            Me.txtChill20.Text = Sum20
            Me.txtChill40.Text = Sum40
            Me.txtChill45.Text = Sum45

            Call Statistics(dvDanger)
            Me.txtDanger20.Text = Sum20
            Me.txtDanger40.Text = Sum40
            Me.txtDanger45.Text = Sum45

            Me.txtFull20.Text = Me.txtFull20.Text - Me.txtChill20.Text - Me.txtDanger20.Text
            Me.txtFull40.Text = Me.txtFull40.Text - Me.txtChill40.Text - Me.txtDanger40.Text
            Me.txtFull45.Text = Me.txtFull45.Text - Me.txtChill45.Text - Me.txtDanger45.Text

            If Me.txtFull20.Text = "0" Then Me.txtFull20.Text = ""
            If Me.txtFull40.Text = "0" Then Me.txtFull40.Text = ""
            If Me.txtFull45.Text = "0" Then Me.txtFull45.Text = ""

            If Me.txtEmpty20.Text = "0" Then Me.txtEmpty20.Text = ""
            If Me.txtEmpty40.Text = "0" Then Me.txtEmpty40.Text = ""
            If Me.txtEmpty45.Text = "0" Then Me.txtEmpty45.Text = ""

            If Me.txtChill20.Text = "0" Then Me.txtChill20.Text = ""
            If Me.txtChill40.Text = "0" Then Me.txtChill40.Text = ""
            If Me.txtChill45.Text = "0" Then Me.txtChill45.Text = ""

            If Me.txtDanger20.Text = "0" Then Me.txtDanger20.Text = ""
            If Me.txtDanger40.Text = "0" Then Me.txtDanger40.Text = ""
            If Me.txtDanger45.Text = "0" Then Me.txtDanger45.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Statistics(ByVal dvTemp As DataView)
        Sum20 = 0 : Sum40 = 0 : Sum45 = 0
        Dim i As Integer
        For i = 0 To dvTemp.Count - 1
            If Not IsDBNull(dvTemp(i)("SIZE_CON")) Then
                If dvTemp(i)("SIZE_CON") = 20 Then
                    Sum20 = dvTemp(i)("ConSum")
                ElseIf dvTemp(i)("SIZE_CON") = 40 Then
                    Sum40 = dvTemp(i)("ConSum")
                Else
                    Sum45 += dvTemp(i)("ConSum")
                End If
            End If
        Next
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class
