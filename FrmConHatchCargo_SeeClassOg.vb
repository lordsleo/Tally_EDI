Imports TALLY.DBControl
Public Class FrmConHatchCargo_SeeClassOg
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFull20 As System.Windows.Forms.TextBox
    Friend WithEvents txtFull40 As System.Windows.Forms.TextBox
    Friend WithEvents txtFull45 As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpty20 As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpty40 As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpty45 As System.Windows.Forms.TextBox
    Friend WithEvents txtChill20 As System.Windows.Forms.TextBox
    Friend WithEvents txtDanger20 As System.Windows.Forms.TextBox
    Friend WithEvents txtHeight20 As System.Windows.Forms.TextBox
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNull As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtFull20 = New System.Windows.Forms.TextBox
        Me.txtFull40 = New System.Windows.Forms.TextBox
        Me.txtFull45 = New System.Windows.Forms.TextBox
        Me.txtEmpty20 = New System.Windows.Forms.TextBox
        Me.txtEmpty40 = New System.Windows.Forms.TextBox
        Me.txtEmpty45 = New System.Windows.Forms.TextBox
        Me.txtChill20 = New System.Windows.Forms.TextBox
        Me.txtDanger20 = New System.Windows.Forms.TextBox
        Me.txtHeight20 = New System.Windows.Forms.TextBox
        Me.btQuit = New System.Windows.Forms.Button
        Me.txtNull = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(22, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "冷藏箱"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(112, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "危险品箱"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(202, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "超高箱"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(22, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "20英尺重箱"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(112, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "40英尺重箱"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(202, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 20)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "45英尺重箱"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFull20
        '
        Me.txtFull20.Location = New System.Drawing.Point(20, 30)
        Me.txtFull20.Name = "txtFull20"
        Me.txtFull20.Size = New System.Drawing.Size(90, 21)
        Me.txtFull20.TabIndex = 8
        Me.txtFull20.Text = ""
        '
        'txtFull40
        '
        Me.txtFull40.Location = New System.Drawing.Point(110, 30)
        Me.txtFull40.Name = "txtFull40"
        Me.txtFull40.Size = New System.Drawing.Size(90, 21)
        Me.txtFull40.TabIndex = 9
        Me.txtFull40.Text = ""
        '
        'txtFull45
        '
        Me.txtFull45.Location = New System.Drawing.Point(200, 30)
        Me.txtFull45.Name = "txtFull45"
        Me.txtFull45.Size = New System.Drawing.Size(90, 21)
        Me.txtFull45.TabIndex = 10
        Me.txtFull45.Text = ""
        '
        'txtEmpty20
        '
        Me.txtEmpty20.Location = New System.Drawing.Point(20, 78)
        Me.txtEmpty20.Name = "txtEmpty20"
        Me.txtEmpty20.Size = New System.Drawing.Size(90, 21)
        Me.txtEmpty20.TabIndex = 13
        Me.txtEmpty20.Text = ""
        '
        'txtEmpty40
        '
        Me.txtEmpty40.Location = New System.Drawing.Point(110, 78)
        Me.txtEmpty40.Name = "txtEmpty40"
        Me.txtEmpty40.Size = New System.Drawing.Size(90, 21)
        Me.txtEmpty40.TabIndex = 12
        Me.txtEmpty40.Text = ""
        '
        'txtEmpty45
        '
        Me.txtEmpty45.Location = New System.Drawing.Point(200, 78)
        Me.txtEmpty45.Name = "txtEmpty45"
        Me.txtEmpty45.Size = New System.Drawing.Size(90, 21)
        Me.txtEmpty45.TabIndex = 11
        Me.txtEmpty45.Text = ""
        '
        'txtChill20
        '
        Me.txtChill20.Location = New System.Drawing.Point(20, 134)
        Me.txtChill20.Name = "txtChill20"
        Me.txtChill20.Size = New System.Drawing.Size(90, 21)
        Me.txtChill20.TabIndex = 17
        Me.txtChill20.Text = ""
        '
        'txtDanger20
        '
        Me.txtDanger20.Location = New System.Drawing.Point(110, 134)
        Me.txtDanger20.Name = "txtDanger20"
        Me.txtDanger20.Size = New System.Drawing.Size(90, 21)
        Me.txtDanger20.TabIndex = 16
        Me.txtDanger20.Text = ""
        '
        'txtHeight20
        '
        Me.txtHeight20.Location = New System.Drawing.Point(200, 134)
        Me.txtHeight20.Name = "txtHeight20"
        Me.txtHeight20.Size = New System.Drawing.Size(90, 21)
        Me.txtHeight20.TabIndex = 22
        Me.txtHeight20.Text = ""
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(124, 192)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 36
        Me.btQuit.Text = "返回"
        '
        'txtNull
        '
        Me.txtNull.Location = New System.Drawing.Point(200, 164)
        Me.txtNull.Name = "txtNull"
        Me.txtNull.Size = New System.Drawing.Size(90, 21)
        Me.txtNull.TabIndex = 38
        Me.txtNull.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(112, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 20)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "无尺寸箱"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(22, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 20)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "20英尺空箱"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(112, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 20)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "40英尺空箱"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(202, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 20)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "45英尺空箱"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmConHatchCargo_SeeClassOg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(310, 223)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
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
        Me.Name = "FrmConHatchCargo_SeeClassOg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "集装箱舱单信息 总览"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmConHatchCargo_SeeClass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i, j As Integer
        Dim sqlFull, sqlEmpty, sqlChill, SqlDanger, sqlHeight, sqlNull As String
        Dim dvFull As New DataView
        Dim dvEmpty As New DataView
        Dim dvChill As New DataView
        Dim dvDanger As New DataView
        Dim dvHeight As New DataView
        Dim dvNull As New DataView

        sqlFull = "SELECT COUNT(*) AS ConSum, CON_HATCH_RECORD.SIZE_CON, CON_CRITERION.SIZE_CON AS SizeCon2 " & _
            "FROM CON_HATCH_RECORD LEFT OUTER JOIN CON_CRITERION ON CON_HATCH_RECORD.CONTAINER_NO = CON_CRITERION.CONTAINER_NO " & _
            "WHERE (CON_HATCH_RECORD.SHIP_ID = '" & Ship_ID & "') AND (CON_HATCH_RECORD.FULLOREMPTY = 'F' OR CON_HATCH_RECORD.FULLOREMPTY = 'L') " & _
            "GROUP BY CON_HATCH_RECORD.SIZE_CON, CON_CRITERION.SIZE_CON ORDER BY CON_HATCH_RECORD.SIZE_CON, CON_CRITERION.SIZE_CON "

        sqlEmpty = "SELECT COUNT(*) AS ConSum, CON_HATCH_RECORD.SIZE_CON, CON_CRITERION.SIZE_CON AS SizeCon2 " & _
            "FROM CON_HATCH_RECORD LEFT OUTER JOIN CON_CRITERION ON CON_HATCH_RECORD.CONTAINER_NO = CON_CRITERION.CONTAINER_NO " & _
            "WHERE (CON_HATCH_RECORD.SHIP_ID = '" & Ship_ID & "') AND (CON_HATCH_RECORD.FULLOREMPTY <> 'F') and (CON_HATCH_RECORD.FULLOREMPTY <> 'L') " & _
            "GROUP BY CON_HATCH_RECORD.SIZE_CON, CON_CRITERION.SIZE_CON ORDER BY CON_HATCH_RECORD.SIZE_CON, CON_CRITERION.SIZE_CON "

        sqlChill = "SELECT COUNT(*) AS ConSum FROM CON_HATCH_RECORD LEFT OUTER JOIN CON_CRITERION ON CON_HATCH_RECORD.CONTAINER_NO = CON_CRITERION.CONTAINER_NO WHERE (SHIP_ID = '" & Ship_ID & "') AND (CON_CRITERION.CONTAINER_TYPE LIKE 'R%') "

        SqlDanger = "SELECT count(CON_HATCH_RECORD.CONTAINER_NO) as ConSum " & _
            "FROM CON_HATCH_RECORD INNER JOIN CON_HATCH_CARGO ON CON_HATCH_RECORD.SHIP_ID = CON_HATCH_CARGO.SHIP_ID AND CON_HATCH_RECORD.CONTAINER_NO = CON_HATCH_CARGO.CONTAINER_NO INNER JOIN CON_HATCH_LIST ON CON_HATCH_CARGO.SHIP_ID = CON_HATCH_LIST.SHIP_ID AND CON_HATCH_CARGO.BLNO = CON_HATCH_LIST.BLNO " & _
            "WHERE (CON_HATCH_RECORD.SHIP_ID = '" & Ship_ID & "') AND (LEN(CON_HATCH_LIST.DANGER_GRADE) > 0) "

        sqlHeight = "SELECT COUNT(*) AS ConSum FROM CON_HATCH_RECORD LEFT OUTER JOIN CON_CRITERION ON CON_HATCH_RECORD.CONTAINER_NO = CON_CRITERION.CONTAINER_NO " & _
            "WHERE (SHIP_ID = '" & Ship_ID & "') AND ( (CON_HATCH_RECORD.OVER_HEIGHT = '1') OR (CON_HATCH_RECORD.OVER_HEIGHT <> '1') and (CON_HATCH_RECORD.OVER_HEIGHT <> '0') and (CON_CRITERION.OVER_Height > 0) ) "

        sqlNull = "SELECT COUNT(CON_HATCH_RECORD.CONTAINER_NO) AS ConSum " & _
            "FROM CON_HATCH_RECORD LEFT OUTER JOIN CON_CRITERION ON CON_HATCH_RECORD.CONTAINER_NO = CON_CRITERION.CONTAINER_NO " & _
            "WHERE (CON_HATCH_RECORD.SHIP_ID = '" & Ship_ID & "') AND (CON_HATCH_RECORD.SIZE_CON IS NULL) AND (CON_CRITERION.SIZE_CON IS NULL) " & _
            "GROUP BY CON_HATCH_RECORD.SIZE_CON, CON_CRITERION.SIZE_CON "
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
            If dvDanger.Count > 0 Then
                If dvDanger(0)(0) > 0 Then
                    Me.txtDanger20.Text = dvDanger(0)(0)
                End If
            End If
            If dvChill.Count > 0 Then
                If dvChill(0)(0) > 0 Then
                    Me.txtChill20.Text = dvChill(0)(0)
                End If
            End If

            Dim Sum20, Sum40, Sum45 As Integer
            For i = 0 To dvFull.Count - 1
                If Not IsDBNull(dvFull(i)("SIZE_CON")) Then
                    If dvFull(i)("SIZE_CON") = 20 Then
                        Sum20 += dvFull(i)("ConSum")
                    ElseIf dvFull(i)("SIZE_CON") = 40 Then
                        Sum40 += dvFull(i)("ConSum")
                    Else
                        Sum45 += dvFull(i)("ConSum")
                    End If
                Else
                    If Not IsDBNull(dvFull(i)("SizeCon2")) Then
                        If dvFull(i)("SizeCon2") = 20 Then
                            Sum20 += dvFull(i)("ConSum")
                        ElseIf dvFull(i)("SizeCon2") = 40 Then
                            Sum40 += dvFull(i)("ConSum")
                        Else
                            Sum45 += dvFull(i)("ConSum")
                        End If
                    End If
                End If
            Next

            If Sum20 > 0 Then
                Me.txtFull20.Text = Sum20
            End If
            If Sum40 > 0 Then
                Me.txtFull40.Text = Sum40
            End If
            If Sum45 > 0 Then
                Me.txtFull45.Text = Sum45
            End If

            Sum20 = 0 : Sum40 = 0 : Sum45 = 0
            For i = 0 To dvEmpty.Count - 1
                If Not IsDBNull(dvEmpty(i)("SIZE_CON")) Then
                    If dvEmpty(i)("SIZE_CON") = 20 Then
                        Sum20 += dvEmpty(i)("ConSum")
                    ElseIf dvEmpty(i)("SIZE_CON") = 40 Then
                        Sum40 += dvEmpty(i)("ConSum")
                    Else
                        Sum45 += dvEmpty(i)("ConSum")
                    End If
                Else
                    If Not IsDBNull(dvEmpty(i)("SizeCon2")) Then
                        If dvEmpty(i)("SizeCon2") = 20 Then
                            Sum20 += dvEmpty(i)("ConSum")
                        ElseIf dvEmpty(i)("SizeCon2") = 40 Then
                            Sum40 += dvEmpty(i)("ConSum")
                        Else
                            Sum45 += dvEmpty(i)("ConSum")
                        End If
                    End If
                End If
            Next

            If Sum20 > 0 Then
                Me.txtEmpty20.Text = Sum20
            End If
            If Sum40 > 0 Then
                Me.txtEmpty40.Text = Sum40
            End If
            If Sum45 > 0 Then
                Me.txtEmpty45.Text = Sum45
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub
End Class
