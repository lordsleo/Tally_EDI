Imports System.Web.Mail
Imports System.IO
Imports TALLY.DBControl
Public Class FrmReadMail
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim dw As New DataView()
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
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFile As System.Windows.Forms.Button
    Friend WithEvents btReadNew As System.Windows.Forms.Button
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LChina As System.Windows.Forms.Label
    Friend WithEvents LEnglish As System.Windows.Forms.Label
    Friend WithEvents LVoyage As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LJinChu As System.Windows.Forms.Label
    Friend WithEvents PB As System.Windows.Forms.ProgressBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFile = New System.Windows.Forms.Button()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.btReadNew = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LChina = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LEnglish = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LVoyage = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LJinChu = New System.Windows.Forms.Label()
        Me.PB = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'OpenFile
        '
        Me.OpenFile.Location = New System.Drawing.Point(308, 42)
        Me.OpenFile.Name = "OpenFile"
        Me.OpenFile.Size = New System.Drawing.Size(62, 20)
        Me.OpenFile.TabIndex = 1
        Me.OpenFile.Text = "打开文件"
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(2, 42)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(304, 21)
        Me.txtFile.TabIndex = 3
        Me.txtFile.Text = ""
        '
        'btReadNew
        '
        Me.btReadNew.Location = New System.Drawing.Point(150, 70)
        Me.btReadNew.Name = "btReadNew"
        Me.btReadNew.Size = New System.Drawing.Size(66, 24)
        Me.btReadNew.TabIndex = 4
        Me.btReadNew.Text = "读取报文"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "中文船名"
        '
        'LChina
        '
        Me.LChina.Location = New System.Drawing.Point(58, 6)
        Me.LChina.Name = "LChina"
        Me.LChina.Size = New System.Drawing.Size(124, 16)
        Me.LChina.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(184, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "英文船名"
        '
        'LEnglish
        '
        Me.LEnglish.Location = New System.Drawing.Point(240, 6)
        Me.LEnglish.Name = "LEnglish"
        Me.LEnglish.Size = New System.Drawing.Size(128, 16)
        Me.LEnglish.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(2, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 14)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "航次"
        '
        'LVoyage
        '
        Me.LVoyage.Location = New System.Drawing.Point(58, 26)
        Me.LVoyage.Name = "LVoyage"
        Me.LVoyage.Size = New System.Drawing.Size(124, 14)
        Me.LVoyage.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(184, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 14)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "进出口"
        '
        'LJinChu
        '
        Me.LJinChu.Location = New System.Drawing.Point(240, 26)
        Me.LJinChu.Name = "LJinChu"
        Me.LJinChu.Size = New System.Drawing.Size(128, 14)
        Me.LJinChu.TabIndex = 13
        '
        'PB
        '
        Me.PB.Location = New System.Drawing.Point(0, 100)
        Me.PB.Maximum = 2000
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(368, 20)
        Me.PB.TabIndex = 14
        '
        'FrmReadMail
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(372, 121)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.PB, Me.LJinChu, Me.Label2, Me.LVoyage, Me.Label5, Me.LEnglish, Me.Label3, Me.LChina, Me.Label1, Me.btReadNew, Me.txtFile, Me.OpenFile})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReadMail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "船图报文读取"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub OpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFile.Click
        OpenFileDialog.AddExtension = True
        OpenFileDialog.DefaultExt = "*.*"
        OpenFileDialog.InitialDirectory = "D:\EDI\Read\"
        OpenFileDialog.ShowDialog()
        txtFile.Text = OpenFileDialog.FileName
    End Sub


    Private Function CheckConNO(ByVal CNO As String) As Integer 'return 0 箱号有错 1 校验有错 2 校验正确
        Dim S() As Integer = {10, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 34, 35, 36, 37, 38}
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim l As Integer
        i = 0
        str = UCase(CNO)
        If Len(Trim(UCase(CNO))) = 12 And Mid(Trim(UCase(CNO)), 5, 1) = " " Then
            str = Mid(Trim(UCase(CNO)), 1, 4) & Mid(Trim(UCase(CNO)), 6, 7)
        Else
            Return 0
        End If
        k = 1
        For j = 1 To 4
            If Asc(Mid(Trim(str), j, 1)) >= Asc("A") And Asc(Mid(Trim(str), j, 1)) <= Asc("Z") Then
                i = i + S(Asc(Mid(Trim(str), j, 1)) - Asc("A")) * System.Math.Pow(2, k - 1)
            Else
                Return 0
            End If

            k = k + 1
        Next

        For j = 5 To 10
            If Asc(Mid(Trim(str), j, 1)) >= Asc("0") And Asc(Mid(Trim(str), j, 1)) <= Asc("9") Then
                i = i + CInt(Mid(Trim(str), j, 1)) * System.Math.Pow(2, k - 1)
            Else
                Return 0
            End If

            k = k + 1
        Next
        If i Mod 11 = CInt(Mid(Trim(str), 11, 1)) Or (i Mod 11) - 10 = CInt(Mid(Trim(str), 11, 1)) Then
            Return 2
        Else
            Return 1
        End If
    End Function

    Private Function EditFetch(ByVal str As String) As String
        Dim s As String
        Dim se As String
        Dim j As Integer
        s = ""
        j = 1
        Do While j <= Len(str)
            se = Mid(str, j, 1)
            If se = "?" Then
                j = j + 1
                Do While se = "?"
                    se = Mid(str, j, 1)
                    j = j + 1
                Loop
                If se = ":" Or se = "'" Or se = "?" Then
                    s = s & se
                Else
                    s = s & "?" & se
                End If
            End If
            If se = ":" Or se = "'" Then
                Exit Do
            Else
                s = s & se
            End If
            j = j + 1
        Loop
        EditFetch = s
    End Function

    Private Function FindLOC(ByVal FilePath As String) As Integer
        Dim i As Integer
        Dim j As Integer
        Dim FileStr As String
        i = 0
        j = 0
        FileStr = FilePath
        Do While InStr(FileStr, "\") > 0
            i = i + InStr(FileStr, "\")
            j = InStr(FileStr, "\")
            FileStr = Mid(FileStr, j + 1, Len(FileStr) - j)
        Loop
        FindLOC = i
    End Function

    Private Function FetchStr(ByVal str As String) As String
        Dim s As String
        Dim se As String
        Dim j As Integer
        s = ""
        j = 1
        Do While j <= Len(str)
            se = Mid(str, j, 1)
            If se = "?" Then
                j = j + 1
                Do While se = "?"
                    se = Mid(str, j, 1)
                    j = j + 1
                Loop
                If se = "+" Or se = "'" Or se = "?" Then
                    s = s & se
                Else
                    s = s & "?" & se
                End If
            End If
            If se = "+" Or se = "'" Then
                Exit Do
            Else
                s = s & se
            End If
            j = j + 1
        Loop
        FetchStr = s
    End Function

    Private Sub btReadNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReadNew.Click
        Dim sr As New StreamReader(txtFile.Text) '打开报文文件
        Dim txtLine(3) As Char
        Dim sqlstr As String
        Dim ds1 As New DataSet()
        Dim dw1 As New DataView()
        Dim sqlda1 As New SqlClient.SqlDataAdapter()

        sr.Read(txtLine, 0, 3) '读取一行
        sr.Close()
        If txtLine(0) = "0" And txtLine(1) = "0" And txtLine(2) = ":" Then '****交通部
            Call ReadZH()
        ElseIf txtLine(0) = "0" And txtLine(1) = "0" And txtLine(2) = "B" Then '*****中远
            Call ReadZY()
        ElseIf txtLine(0) = "U" And txtLine(1) = "N" And txtLine(2) = "B" Then '******UN
            Call ReadUN()
        End If

        sqlstr = "select * from OperateHistory where 1>2"
        dw1 = Updatedata(sqlda1, sqlstr, ds1)
        Dim row As DataRow
        row = ds1.Tables(0).NewRow()
        row("Dept_Name") = G_DeptName
        row("OperateTime") = System.DateTime.Now
        row("OperateWorker") = G_User
        row("OperateType") = "读船图报文"
        row("OperateDemo") = txtFile.Text
        row("OperateTable") = Ship_ID
        ds1.Tables(0).Rows.Add(row)



        sqlda1.Update(ds1)
    End Sub
    Private Sub ReadUN()
        Dim sr As New StreamReader(txtFile.Text) '打开读报文文件
        Dim i As Long
        Dim s As String
        Dim txtline As String
        Dim strFile As String
        strFile = Mid(txtFile.Text, 1, FindLOC(txtFile.Text) - 1) & "\UnTemp.txt"
        File.Delete(strFile)
        Dim sw As New StreamWriter(strFile, FileMode.OpenOrCreate) '打开写报文文件
        Dim txtChr(1) As Char
        txtline = ""
        sr.Read(txtChr, 0, 1)

        Do While (1 = 1)

            If txtChr(0) = "?" Then
                Do While txtChr(0) = "?"
                    sr.Read(txtChr, 0, 1)
                Loop
                sr.Read(txtChr, 0, 1)
                txtline = txtline & txtChr(0)
            ElseIf txtChr(0) = "'" Then
                txtline = txtline & txtChr(0)
                sw.WriteLine(txtline)
                If Mid(UCase(txtline), 1, 3) = "UNZ" Then
                    Exit Do
                End If
                txtline = ""
            Else
                If Asc(txtChr(0)) <> 13 And Asc(txtChr(0)) <> 10 Then
                    txtline = txtline & txtChr(0)
                End If
            End If
            sr.Read(txtChr, 0, 1)
        Loop
        sr.Close()
        sw.Close()
        Call ReadUNFile(strFile)
    End Sub
    Private Sub ReadUNFile(ByVal strFile As String)
        Dim sr As New StreamReader(Mid(txtFile.Text, 1, FindLOC(txtFile.Text) - 1) & "\UnTemp.txt") '打开报文文件
        Dim txtLine As String
        Dim sTemp As String
        Dim Str As String
        Dim ShipLineCode As String = "" '船公司代码
        Dim i As Integer = 0 '记录行数
        '**************读报文头
        txtLine = Trim(sr.ReadLine()) '按行方式读取一行

        '***********处理记录 文件 头记录
        If txtLine = Nothing Then
            MsgBox("报文出错!")
            Exit Sub
        Else
            Str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(Str) + 2)
            If Trim(Str) <> "UNB" Then
                MsgBox("报文出错 " & Str & " ,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                Str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(Str) + 2)
                If Trim(Str) <> "UNOA:1" And Trim(Str) <> "UNOA:2" And Trim(Str) <> "UNOA:3" Then                       '船图标识
                    MsgBox("报文出错 " & Str & " ,语法标识符或版本号错误,错误在" & i + 1 & "行!")
                    Exit Sub
                Else
                    'Str = FetchStr(txtLine)
                    'txtLine = Mid(txtLine, Len(Str) + 2)
                    'If Len(Trim(Str)) = 0 Then              '发送方标识
                    '    'MsgBox("报文出错 " & Str & " ,不是船图报文,错误在" & i + 1 & "行!")
                    '    'Exit Sub
                    'End If
                    'Str = FetchStr(txtLine)
                    'txtLine = Mid(txtLine, Len(Str) + 2)
                    'If Len(Trim(Str)) = 0 Then              '接受方标识
                    '    'MsgBox("报文出错 " & Str & " ,不是船图报文,错误在" & i + 1 & "行!")
                    '    'Exit Sub
                    'End If
                    'Str = FetchStr(txtLine)
                    'txtLine = Mid(txtLine, Len(Str) + 2)
                    'If Len(Trim(Str)) = 0 Then              '日期时间标识
                    '    MsgBox("报文出错 " & Str & " ,不是船图报文,错误在" & i + 1 & "行!")
                    '    Exit Sub
                    'End If
                    'Str = FetchStr(txtLine)
                    'txtLine = Mid(txtLine, Len(Str) + 2)
                    'If Len(Trim(Str)) = 0 Then              '日期时间标识
                    '    MsgBox("报文出错 " & Str & " ,不是船图报文,错误在" & i + 1 & "行!")
                    '    Exit Sub
                    'End If
                    'Str = FetchStr(txtLine)
                    'txtLine = Mid(txtLine, Len(Str) + 2)
                    'Str = FetchStr(txtLine)
                    'txtLine = Mid(txtLine, Len(Str) + 2)
                    'Str = FetchStr(txtLine)
                    'txtLine = Mid(txtLine, Len(Str) + 2)
                    'Str = FetchStr(txtLine)
                    'txtLine = Mid(txtLine, Len(Str) + 2)
                    'Str = FetchStr(txtLine)
                    'txtLine = Mid(txtLine, Len(Str) + 2)
                    'If Len(Trim(Str)) = 0 Then              '船公司标识
                    '    'MsgBox("报文出错 "& str &" ,不是船图报文!")
                    '    'Exit Sub
                    'Else
                    '    ShipLineCode = Trim(Str)
                    'End If
                End If
            End If
        End If
        '*************处理记录 报文头记录
        txtLine = Trim(sr.ReadLine()) '按行方式读取一行
        If txtLine = Nothing Then
            MsgBox("报文出错!")
            Exit Sub
        Else
            i = i + 1
            Str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(Str) + 2)
            If Trim(Str) <> "UNH" Then                        '报文头记录
                MsgBox("报文出错 " & Str & " ,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                Str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(Str) + 2)
                If Len(Trim(Str)) = 0 Then                    '时间标识
                    MsgBox("报文出错 " & Str & " ,错误在" & i + 1 & "行!")
                    Exit Sub
                End If
                Str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(Str) + 2)
                If Len(Trim(Str)) <> 0 Then
                    If InStr(UCase(Trim(Str)), "911") > 0 And InStr(UCase(Trim(Str)), "BAPLIE") > 0 Then           '船图标识 
                        Call ReadUNFile911(strFile)
                        Exit Sub
                    ElseIf InStr(UCase(Trim(Str)), "95B") > 0 And InStr(UCase(Trim(Str)), "BAPLIE") > 0 Then        '船图标识 
                        Call ReadUNFile95B(strFile)
                        Exit Sub
                    Else
                        MsgBox("报文版本错误" & Str & " ,错误在" & i + 1 & "行!")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ReadUNFile911(ByVal strFile As String)
        Dim sr As New StreamReader(Mid(txtFile.Text, 1, FindLOC(txtFile.Text) - 1) & "\UnTemp.txt") '打开报文文件
        Dim txtLine As String
        Dim sTemp As String
        Dim i As Integer = 0 '记录行数
        Dim j As Integer = 0 '取箱信息循环
        Dim i99 As Integer '判断结束
        Dim str As String
        Dim s As String
        Dim Mark As Integer = 0 '**********标识某行是否处理完 1表示处理完 0表示未处理完

        Dim ShipName As String = "" '船名
        Dim ShipCode As String = "" '船名码
        Dim Voyage As String = "" '航次
        Dim ShipLineCode As String = "" '船公司代码
        Dim ShipLine As String = "" '船公司
        Dim ConNo As String = "" '箱号
        Dim ConType As String = "" '箱尺寸类型
        Dim ConStatus As String = "" '箱状态
        Dim ConBay As String = "" '箱贝位号
        Dim ConTempUnit As String = "" '温度计量单位
        Dim ConTempSet As String = "" '设置温度
        Dim ConTempMax As String = "" '冷藏最高温度
        Dim ConTempMin As String = "" '冷藏最低温度
        Dim ConOverFront As String = "" '前超
        Dim ConOverBack As String = "" '后超
        Dim ConOverLeft As String = "" '左超
        Dim ConOverRight As String = "" '右超
        Dim ConOverHeight As String = "" '超高
        Dim ConGrossWeight As String = "" '箱毛重
        Dim ConTareWeight As String = "" '箱皮重
        Dim ConOperatorCode As String = "" '箱经营人代码
        Dim ConOperator As String = "" '箱经营人
        Dim BLNO As String = "" '提单号
        Dim LoadPortCode As String = "" '装货港代码
        Dim LoadPort As String = "" '装货港
        Dim unLoadPortCode As String = "" '卸货港代码
        Dim unLoadPort As String = "" '卸货港
        Dim DeliveryPlaceCode As String = "" '交货地代码
        Dim DeliveryPlace As String = "" '交货地
        Dim DangerousClass As String = "" '危险品分类
        Dim DangerousPage As String = "" '危险品页号
        Dim DangerousUNNO As String = "" '联合国危险品编号
        Dim DangerousLabel As String = "" '危险品标签
        Dim CargoDescr As String = "" '货物描述
        Dim ConDescr As String = ""
        Dim sign As String = ""
        Dim Length As String = ""
        Dim width As String = ""
        Dim Height As String = ""
        '**************读报文头
        txtLine = Trim(sr.ReadLine()) '按行方式读取一行

        '***********处理记录 文件 头记录
        If txtLine = Nothing Then
            MsgBox("报文出错!")
            Exit Sub
        Else
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "UNB" Then
                MsgBox("报文出错 " & str & " ,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) <> "UNOA:1" And Trim(str) <> "UNOA:2" And Trim(str) <> "UNOA:3" Then                      '船图标识
                    'MsgBox("报文出错 " & str & " ,语法标识符或版本号错误,错误在" & i + 1 & "行!")
                    'Exit Sub
                Else
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then              '发送方标识
                        'MsgBox("报文出错 " & str & " ,不是船图报文,错误在" & i + 1 & "行!")
                        'Exit Sub
                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then              '接受方标识
                        'MsgBox("报文出错 " & str & " ,不是船图报文,错误在" & i + 1 & "行!")
                        'Exit Sub
                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then              '日期时间标识
                        'MsgBox("报文出错 " & str & " ,不是船图报文,错误在" & i + 1 & "行!")
                        'Exit Sub
                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then              '日期时间标识
                        'MsgBox("报文出错 " & str & " ,不是船图报文,错误在" & i + 1 & "行!")
                        'Exit Sub
                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then              '船公司标识
                        'MsgBox("报文出错 "& str &" ,不是船图报文!")
                        'Exit Sub
                    Else
                        ShipLineCode = Trim(str)
                    End If
                End If
            End If
        End If
        '*************处理记录 报文头记录
        txtLine = Trim(sr.ReadLine()) '按行方式读取一行
        If txtLine = Nothing Then
            MsgBox("报文出错!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "UNH" Then                        '报文头记录
                MsgBox("报文出错 " & str & " ,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) = 0 Then                    '时间标识
                    'MsgBox("报文出错 " & str & " ,错误在" & i + 1 & "行!")
                    'Exit Sub
                End If
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) <> 0 Then
                    If InStr(UCase(Trim(str)), "911") = 0 And InStr(UCase(Trim(str)), "BAPLIE") = 0 Then      '船图标识 
                        MsgBox("报文出错 " & str & " ,船图标识 报文版本号出错,错误在" & i + 1 & "行!")
                        Exit Sub
                    End If
                End If
            End If
        End If
        '*************处理记录 报文开始记录
        txtLine = Trim(sr.ReadLine()) '按行方式读取一行
        If txtLine = Nothing Then
            MsgBox("报文出错!报文开始记录 ,错误在" & i + 1 & "行!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "BGM" Then                        '报文头记录
                MsgBox("报文报文开始记录BGM出错 " & str & " ,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) = 0 Then                    '时间标识 
                    'MsgBox("报文时间标识出错 " & str & " ,错误在" & i + 1 & "行!")
                    'Exit Sub
                End If

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) <> "2" And Trim(str) <> "4" And Trim(str) <> "5" And Trim(str) <> "9" And Trim(str) <> "22" Then                     '报文功能标识 
                    'MsgBox("报文报文功能标识出错 " & str & " ,错误在" & i + 1 & "行!")
                    'Exit Sub
                Else

                End If
            End If
        End If
        '*************处理记录 报文开始时间记录
        txtLine = Trim(sr.ReadLine()) '按行方式读取一行
        If txtLine = Nothing Then
            MsgBox("报文开始时间记录出错,错误在" & i + 1 & "行!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "DTM" Then                        '报文头记录
                MsgBox("报文DTM出错 " & str & " ,错误在" & i + 1 & "行!")
                Exit Sub
            Else

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) = 0 Then                    '时间标识 
                    'MsgBox("报文时间标识 出错 " & str & " ,错误在" & i + 1 & "行!")
                    'Exit Sub
                Else
                    If Mid(Trim(str), 1, 3) <> "137" Then
                        'MsgBox("报文137出错 " & str & " ,错误在" & i + 1 & "行!")
                        'Exit Sub
                    End If
                End If


            End If
        End If

        '*************处理记录 船舶有关的基本数据项目
        txtLine = Trim(sr.ReadLine()) '按行方式读取一行
        If txtLine = Nothing Then
            MsgBox("报文出错,错误在" & i + 1 & "行!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "TDT" Then                        '报文头记录
                MsgBox("报文头记录TDT出错 " & str & " ,错误在" & i + 1 & "行!")
                Exit Sub
            Else

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) <> "20" Then                    '限定符 
                    'MsgBox("报文限定符20出错 " & str & " ,错误在" & i + 1 & "行!")
                    'Exit Sub
                End If

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) = 0 Then                  '航次 
                    'MsgBox("报文航次出错 " & str & " ,错误在" & i + 1 & "行!")
                    'Exit Sub
                Else
                    Voyage = str
                End If
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) = 0 Then                  '呼号 船名
                    'MsgBox("报文呼号 船名出错 " & str & " ,错误在" & i + 1 & "行!")
                    'Exit Sub
                Else
                    If Mid(Trim(str), 1, 1) <> ":" Then
                        sign = Mid(Trim(str), 1, InStr(Trim(str), ":") - 1)
                    End If
                    If Mid(Trim(str), InStr(Trim(str), ":") + 1, 3) <> "103" Then
                        'MsgBox("报文103出错 " & str & " ,错误在" & i + 1 & "行!")
                        'Exit Sub
                    End If
                    str = Mid(Trim(str), InStr(Trim(str), ":") + 6)
                    If InStr(Trim(str), ":") > 0 Then
                        ShipName = Mid(Trim(str), 1, InStr(Trim(str), ":") - 1)
                    Else
                        ShipName = Trim(str)
                    End If
                End If
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) = 0 Then                  '承运人
                    'MsgBox("报文承运人出错 " & str & " ,错误在" & i + 1 & "行!")
                    'Exit Sub
                Else
                    If Mid(Trim(str), Len(Trim(str)) - 5, 6) <> "172:20" Then
                        'MsgBox("报文172:20出错 " & str & " ,错误在" & i + 1 & "行!")
                        'Exit Sub
                    End If
                End If


            End If
        End If
        '*************处理记录 装货港
        txtLine = Trim(sr.ReadLine()) '按行方式读取一行
        If txtLine = Nothing Then
            MsgBox("报文装货港出错,错误在" & i + 1 & "行!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "LOC" Then                        '报文头记录
                MsgBox("报文头记录LOC出错 " & str & " ,错误在" & i + 1 & "行!")
                Exit Sub
            Else

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) <> "5" Then                      '装货港标识 
                    MsgBox("装货港标识5出错 " & str & " ,错误在" & i + 1 & "行!")
                    Exit Sub
                End If

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) = 0 Then                     '装货港
                    'MsgBox("报文出错 "& str &" ,错误在" & i + 1 & "行!")
                    'Dim Frm As New FrmReadTemp
                    'G_SelectStr = "此报文 " & "  装货港空错误"
                    'Frm.ShowDialog()
                    'LoadPortCode = Trim(G_SelectCode)
                Else
                    LoadPortCode = Trim(str)
                End If
            End If
        End If
        '*************处理记录 卸货港
        txtLine = Trim(sr.ReadLine()) '按行方式读取一行
        s = txtLine
        If txtLine = Nothing Then
            MsgBox("报文卸货港出错,错误在" & i + 1 & "行!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "LOC" Then                        '报文头记录
                'MsgBox("报文头记录LOC出错 " & str & " ,错误在" & i + 1 & "行!")
                Mark = 0
                'Exit Sub
            Else
                Mark = 1
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) <> "61" Then                      '卸货港标识 
                    MsgBox("报文卸货港标识61出错 " & str & " ,错误在" & i + 1 & "行!")
                    Exit Sub
                End If

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) = 0 Then                     '卸货港
                    'MsgBox("报文出错 "& str &" ,错误在" & i + 1 & "行!")
                    'Dim Frm As New FrmReadTemp
                    'G_SelectStr = "此报文 " & "  卸货港空错误"
                    'Frm.ShowDialog()
                    'unLoadPortCode = Trim(G_SelectCode)
                Else
                    unLoadPortCode = Trim(str)
                End If
            End If
        End If

        '*************处理记录 报文178时间记录
        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '按行方式读取一行
            s = txtLine
        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("报文178or 132 时间记录出错,错误在" & i + 1 & "行!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "DTM" Then                        '报文头记录
                MsgBox("报文头记录DTM出错 " & str & " ,错误在" & i + 1 & "行!")
                Exit Sub
            Else

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Mid(Trim(str), 1, 3) = "178" Or Mid(Trim(str), 1, 3) = "132" Then                  '时间标识 
                    Mark = 1
                Else
                    Mark = 0
                End If
            End If
        End If
        '*************处理记录 报文136时间记录
        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '按行方式读取一行
            s = txtLine
        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("报文136 or 133时间记录出错,错误在" & i + 1 & "行!")
            Exit Sub
        Else
            If Mark = 1 Then i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "DTM" Then                        '报文头记录
                Mark = 0
                'MsgBox("报文头记录DTM出错 " & str & " ,错误在" & i + 1 & "行!")
                'Exit Sub
            Else
                Mark = 1
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Mid(Trim(str), 1, 3) = "136" Or Mid(Trim(str), 1, 3) = "133" Then                   '时间标识 
                    Mark = 1
                Else
                    Mark = 0
                    'MsgBox("报文时间标识 136 或 133出错 " & str & " ,错误在" & i + 1 & "行!")
                    'Exit Sub
                End If
            End If
        End If
        '*************处理记录 报文132时间记录

        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '按行方式读取一行
            s = txtLine
        Else
            txtLine = s
        End If

        If txtLine = Nothing Then
            MsgBox("报文132时间记录出错,错误在" & i + 1 & "行!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "DTM" Then                '报文头记录
                Mark = 0
                'MsgBox("报文头记录DTM出错 " & str & " ,错误在" & i + 1 & "行!")
                'Exit Sub
            Else
                Mark = 1
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Mid(Trim(str), 1, 3) = "132" Then                  '时间标识 
                    Mark = 1
                Else
                    Mark = 0
                    'MsgBox("报文时间标识132出错 " & str & " ,错误在" & i + 1 & "行!")
                    'Exit Sub
                End If
            End If
        End If
        '*************处理记录 报文RFF时间记录

        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '按行方式读取一行
            s = txtLine
        Else
            txtLine = s
        End If

        If txtLine = Nothing Then
            MsgBox("报文RFF时间记录出错,错误在" & i + 1 & "行!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "RFF" Then                        '报文头记录
                Mark = 0
                'MsgBox("报文头记录RFF出错 " & str & " ,错误在" & i + 1 & "行!")
                'Exit Sub
            Else
                Mark = 1
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Mid(Trim(str), 1, 3) = "VON" Then                 '装货航次
                    Mark = 1
                Else
                    Mark = 1
                    'MsgBox("报文装货航次VON出错 " & str & " ,错误在" & i + 1 & "行!")
                    'Exit Sub
                End If


            End If
        End If
        '*************处理记录 报文FTX时间记录

        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '按行方式读取一行
            s = txtLine
        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("报文FTX时间记录出错,错误在" & i + 1 & "行!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If UCase(Trim(str)) = "FTX" Then                        '报文头记录
                Mark = 1
            Else
                Mark = 0
            End If
        End If

        '*****************集装箱信息 (开始循环)
        Do While j < 9999
            If j < 2000 Then
                PB.Value = j
            End If
            ConNo = ""
            ConType = ""
            ConStatus = ""
            ConBay = ""  '箱贝位号
            ConTempUnit = ""  '温度计量单位
            ConTempSet = "" '设置温度
            ConTempMax = ""  '冷藏最高温度
            ConTempMin = ""  '冷藏最低温度
            ConOverFront = ""  '前超
            ConOverBack = ""  '后超
            ConOverLeft = ""  '左超
            ConOverRight = "" '右超
            ConOverHeight = ""  '超高
            ConGrossWeight = ""  '箱毛重
            ConTareWeight = ""  '箱皮重
            ConOperatorCode = ""  '箱经营人代码
            ConOperator = ""  '箱经营人
            BLNO = ""  '提单号
            LoadPortCode = ""  '装货港代码
            LoadPort = ""  '装货港
            unLoadPortCode = ""  '卸货港代码
            unLoadPort = ""  '卸货港
            DeliveryPlaceCode = ""  '交货地代码
            DeliveryPlace = ""  '交货地
            DangerousClass = ""  '危险品分类
            DangerousPage = ""  '危险品页号
            DangerousUNNO = ""  '联合国危险品编号
            DangerousLabel = ""  '危险品标签
            CargoDescr = ""  '货物描述
            ConDescr = ""
            Length = ""
            width = ""
            Height = ""
            i99 = 0
            '*************处理记录  描述集装箱信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())             '********贝位号
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错处理记录  描述集装箱信息!,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "147" Then           '******贝位限定符出错
                        MsgBox("报文贝位限定符LOC147出错 " & str & " ,错误在" & i + 1 & "行!")
                        Exit Sub
                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then
                        'MsgBox("报文出错 " & str & " ,错误在" & i + 1 & "行!")
                        ConBay = ""
                    Else
                        ConBay = Mid(Trim(str), 1, 7)   '******贝位号
                        If Len(Trim(ConBay)) = 6 Then
                            ConBay = "0" & ConBay
                        End If
                    End If
                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())             '********GID 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错GID 段!,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                '*******GID
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "GID" Then
                    i99 = 1
                    Mark = 1
                Else
                    Mark = 0
                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())             '********GDS 货物性质段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错GDS 货物性质段!,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                '*******GDS 货物性质
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "GDS" Then
                    i99 = 1
                    Mark = 1
                Else
                    Mark = 0
                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())             '********FTX 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错FTX 段!,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                '*******FTX
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "FTX" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If str = "AAA" Then
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        CargoDescr = str
                    ElseIf str = "CLR" Then
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        ConDescr = str

                    End If
                Else
                    Mark = 0
                End If
            End If

            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())             '********FTX 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错FTX 段!,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                '*******FTX
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "FTX" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If str = "AAA" Then
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        CargoDescr = str
                    ElseIf str = "CLR" Then
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        ConDescr = str

                    End If
                Else
                    Mark = 0
                End If
            End If


            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())             '********MEA 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错MEA 段!,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                '*******MEA
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "MEA" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "WT" Then               '*****重量限定符
                        MsgBox("报文重量限定符WT出错 " & str & " ,错误在" & i + 1 & "行!")
                        Exit Sub
                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then             '*****重量限定符
                        'MsgBox("报文重量限定符KGM LBR出错 " & str & " ,错误在" & i + 1 & "行!")
                        'Exit Sub
                    Else
                        If Mid(Trim(str), 1, 3) = "KGM" Then
                            ConGrossWeight = Mid(Trim(str), 5)
                        ElseIf Mid(Trim(str), 1, 3) = "LBR" Then
                            If Len(Trim(Mid(Trim(str), 5))) > 0 Then
                                ConGrossWeight = Trim(CStr(CType(Mid(Trim(str), 5), Int32) * 0.45))
                            Else
                                ConGrossWeight = ""
                            End If

                        End If
                    End If
                Else
                    Mark = 0

                End If
            End If
            Dim TTTT As Integer
            TTTT = 0
            Do While TTTT < 9
                If Mark = 1 Then
                    txtLine = Trim(sr.ReadLine())                 '********DIM 段
                    s = txtLine
                Else
                    txtLine = s
                End If
                If txtLine = Nothing Then
                    MsgBox("报文出错DIM 段!,错误在" & i + 1 & "行!")
                    Exit Sub
                Else
                    If Mark = 1 Then i = i + 1
                    str = FetchStr(txtLine)                      '*******DIM
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) = "DIM" Then
                        i99 = 1
                        Mark = 1
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Trim(str) <> "1" And Trim(str) <> "5" And Trim(str) <> "6" And Trim(str) <> "7" And Trim(str) <> "8" And Trim(str) <> "9" Then                 '*****重量限定符
                            'MsgBox("报文重量限定符1 5 6 7 8 9出错 " & str & " ,错误在" & i + 1 & "行!")
                            'Exit Sub
                        Else
                            sTemp = Trim(str)
                        End If
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) = 0 Then             '*****超大箱定符
                            'MsgBox("报文超大箱定符CMT 出错 " & str & " ,错误在" & i + 1 & "行!")
                            'Exit Sub
                        Else
                            If (Mid(Trim(str), 1, 3) = "CNT" Or Mid(Trim(str), 1, 3) = "CMT" Or Mid(Trim(str), 1, 2) = "CM") Then

                                If sTemp = "5" Then
                                    'str = Mid(Trim(str), 5)
                                    str = Mid(str, InStr(str, ":") + 1)
                                    Do While Mid(str, 1, 1) = ":"
                                        str = Mid(str, 2)
                                    Loop
                                    If InStr(str, ":") > 0 Then
                                        str = Mid(str, 1, InStr(str, ":") - 1)
                                    Else
                                        str = str
                                    End If
                                    ConOverFront = str
                                End If
                                If sTemp = "6" Then
                                    'str = Mid(Trim(str), 5)
                                    str = Mid(str, InStr(str, ":") + 1)
                                    Do While Mid(str, 1, 1) = ":"
                                        str = Mid(str, 2)
                                    Loop
                                    If InStr(str, ":") > 0 Then
                                        str = Mid(str, 1, InStr(str, ":") - 1)
                                    Else
                                        str = str
                                    End If
                                    ConOverBack = str
                                End If
                                If sTemp = "7" Then
                                    'str = Mid(Trim(str), 5)
                                    str = Mid(str, InStr(str, ":") + 1)
                                    Do While Mid(str, 1, 1) = ":"
                                        str = Mid(str, 2)
                                    Loop
                                    If InStr(str, ":") > 0 Then
                                        str = Mid(str, 1, InStr(str, ":") - 1)
                                    Else
                                        str = str
                                    End If
                                    ConOverRight = str
                                End If
                                If sTemp = "8" Then
                                    'str = Mid(Trim(str), 5)
                                    str = Mid(str, InStr(str, ":") + 1)
                                    Do While Mid(str, 1, 1) = ":"
                                        str = Mid(str, 2)
                                    Loop
                                    If InStr(str, ":") > 0 Then
                                        str = Mid(str, 1, InStr(str, ":") - 1)
                                    Else
                                        str = str
                                    End If
                                    ConOverLeft = str
                                End If
                                If sTemp = "9" Then
                                    'str = Mid(Trim(str), 5)
                                    str = Mid(str, InStr(str, ":") + 1)
                                    Do While Mid(str, 1, 1) = ":"
                                        str = Mid(str, 2)
                                    Loop
                                    If InStr(str, ":") > 0 Then
                                        str = Mid(str, 1, InStr(str, ":") - 1)
                                    Else
                                        str = str
                                    End If
                                    ConOverHeight = str

                                End If
                                If sTemp = "1" Then
                                    str = Mid(Trim(str), 5)
                                    Length = Mid(str, 1, InStr(str, ":") - 1)
                                    'str = Mid(Trim(str), 5)
                                    str = Mid(str, InStr(str, ":") + 1)
                                    width = Mid(str, 1, InStr(str, ":") - 1)
                                    'str = Mid(Trim(str), 5)
                                    str = Mid(str, InStr(str, ":") + 1)
                                    Height = Mid(str, InStr(str, ":") + 1)
                                End If
                            ElseIf Mid(Trim(str), 1, 3) = "INH" Then
                                'ConGrossWeight = Trim(CStr(CType(Mid(Mid(Trim(str), 5), 1, Len(Mid(Trim(str), 5)) - 1), Int32) * 0.45))
                                If sTemp = "1" Then
                                    str = Mid(Trim(str), 5)
                                    Length = Mid(str, 1, InStr(str, ":") - 1)
                                    'str = Mid(Trim(str), 5)
                                    str = Mid(str, InStr(str, ":") + 1)
                                    width = Mid(str, 1, InStr(str, ":") - 1)
                                    'str = Mid(Trim(str), 5)
                                    str = Mid(str, InStr(str, ":") + 1)
                                    Height = Mid(str, InStr(str, ":") + 1)
                                End If
                                If sTemp = "5" Then
                                    'str = Mid(Trim(str), 5)
                                    str = Mid(str, InStr(str, ":") + 1)
                                    Do While Mid(str, 1, 1) = ":"
                                        str = Mid(str, 2)
                                    Loop
                                    If InStr(str, ":") > 0 Then
                                        str = Mid(str, 1, InStr(str, ":") - 1)
                                    Else
                                        str = str
                                    End If
                                    ConOverFront = CType(str, Double) * 2.5
                                End If
                                If sTemp = "6" Then
                                    'str = Mid(Trim(str), 5)
                                    str = Mid(str, InStr(str, ":") + 1)
                                    Do While Mid(str, 1, 1) = ":"
                                        str = Mid(str, 2)
                                    Loop
                                    If InStr(str, ":") > 0 Then
                                        str = Mid(str, 1, InStr(str, ":") - 1)
                                    Else
                                        str = str
                                    End If
                                    ConOverBack = CType(str, Double) * 2.5
                                End If
                                If sTemp = "7" Then
                                    'str = Mid(Trim(str), 5)
                                    str = Mid(str, InStr(str, ":") + 1)
                                    Do While Mid(str, 1, 1) = ":"
                                        str = Mid(str, 2)
                                    Loop
                                    If InStr(str, ":") > 0 Then
                                        str = Mid(str, 1, InStr(str, ":") - 1)
                                    Else
                                        str = str
                                    End If
                                    ConOverRight = CType(str, Double) * 2.5
                                End If
                                If sTemp = "8" Then
                                    'str = Mid(Trim(str), 5)
                                    str = Mid(str, InStr(str, ":") + 1)
                                    Do While Mid(str, 1, 1) = ":"
                                        str = Mid(str, 2)
                                    Loop
                                    If InStr(str, ":") > 0 Then
                                        str = Mid(str, 1, InStr(str, ":") - 1)
                                    Else
                                        str = str
                                    End If
                                    ConOverLeft = CType(str, Double) * 2.5
                                End If
                                If sTemp = "9" Then
                                    'str = Mid(Trim(str), 5)
                                    str = Mid(str, InStr(str, ":") + 1)
                                    Do While Mid(str, 1, 1) = ":"
                                        str = Mid(str, 2)
                                    Loop
                                    If InStr(str, ":") > 0 Then
                                        str = Mid(str, 1, InStr(str, ":") - 1)
                                    Else
                                        str = str
                                    End If
                                    ConOverHeight = CType(str, Double) * 2.5

                                End If

                            End If
                        End If
                    Else
                        Mark = 0
                    End If
                End If
                TTTT = TTTT + 1
            Loop
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********TMP 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错TMP 段!,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******TMP
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "TMP" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "1" And Trim(str) <> "2" Then                 '*****冷藏箱
                        'MsgBox("报文冷藏箱出错 " & str & " ,错误在" & i + 1 & "行!")
                        'Exit Sub

                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then             '*****冷藏箱
                        'MsgBox("报文冷藏箱出错 " & str & " ,错误在" & i + 1 & "行!")
                        'Exit Sub
                    Else
                        ConTempSet = Mid(Trim(str), 1, InStr(Trim(str), ":") - 1)
                        ConTempUnit = Mid(Trim(str), InStr(Trim(str), ":") + 1, 1)
                    End If
                Else
                    Mark = 0
                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********RNG 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错RNG 段!,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******RNG
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "RNG" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "ZZZ" Then                  '*****冷藏箱温度范围
                        'MsgBox("报文冷藏箱温度范围出错 " & str & " ,错误在" & i + 1 & "行!")
                        'Exit Sub

                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then             '*****冷藏箱
                        'MsgBox("报文冷藏箱出错 " & str & " ,错误在" & i + 1 & "行!")
                        'Exit Sub
                    Else
                        ConTempUnit = Mid(Trim(str), 1, 1)
                        sTemp = Mid(Trim(str), 5)
                        ConTempMin = Mid(sTemp, 1, InStr(Trim(sTemp), ":") - 1)
                        ConTempMax = Mid(sTemp, InStr(Trim(sTemp), ":") + 1)
                    End If
                Else
                    Mark = 0
                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********装货港 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错装货港 段!,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******装货港
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "6" Then                  '*****装货港
                        MsgBox("报文出错 " & str & " ,错误在" & i + 1 & "行!")
                        Exit Sub

                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then             '*****装货港
                        LoadPortCode = ""
                    Else
                        LoadPortCode = Trim(str)
                    End If
                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********卸货港 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错卸货港 段!,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******卸货港 
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "12" Then                   '*****卸货港 
                        MsgBox("报文出错 " & str & " ,错误在" & i + 1 & "行!")
                        Exit Sub

                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then             '*****卸货港 
                        unLoadPortCode = ""
                    Else
                        unLoadPortCode = Trim(str)
                    End If
                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********可选卸货港 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错!,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******可选卸货港 段
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "97" Then                   '*****可选卸货港 段
                        Mark = 0
                    Else
                        Mark = 1
                    End If

                Else
                    Mark = 0
                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********目的港 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错目的港 段!,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******目的港
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "83" Then                   '*****目的港
                        MsgBox("报文出错目的港 " & str & " ,错误在" & i + 1 & "行!")
                        Exit Sub

                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then             '*****目的港                        
                        DeliveryPlaceCode = Trim(str)
                    End If
                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********可选目的港1 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! ,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******可选目的港
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "63" Then                   '*****可选目的港
                        Mark = 0
                    Else
                        Mark = 1
                    End If

                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********可选目的港2 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! ,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******可选目的港
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "65" Then                   '*****可选目的港
                        Mark = 0
                    Else
                        Mark = 1
                    End If

                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********可选目的港3 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! ,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******可选目的港
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "69" Then                   '*****可选目的港
                        Mark = 0
                    Else
                        Mark = 1
                    End If

                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********可选目的港4 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! ,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******可选目的港
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "71" Then                   '*****可选目的港
                        Mark = 0
                    Else
                        Mark = 1
                    End If

                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********可选目的港5 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! ,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******可选目的港
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "74" Then                   '*****可选目的港
                        Mark = 0
                    Else
                        Mark = 1
                    End If

                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********提单号 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错提单号 段! ,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******提单号 
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "RFF" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Mid(Trim(str), 1, 2) <> "BM" Then                      '*****提单号 
                        'MsgBox("报文出错提单号 段 " & str & " ,错误在" & i + 1 & "行!")
                        'Exit Sub
                        'Mark = 0
                    Else
                        BLNO = Mid(Trim(str), 4)                '*****提单号 
                        Mark = 1
                    End If

                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********箱信息 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错箱信息 段!,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******箱信息
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "EQD" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "CN" And Trim(str) <> "BB" And Trim(str) <> "ZZZ" Then                         '*****箱信息
                        'MsgBox("报文出错 CN BB ZZZ" & str & " ,错误在" & i + 1 & "行!")
                        'Exit Sub
                        'Mark = 0
                    Else
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) = 0 Then
                            ConNo = ""
                        Else
                            Mark = 1
                            ConNo = str
                            Dim TTTTT As String
                            Dim TTTTTT As Int16
                            Dim Ti As Int16

                            Ti = 1
                            TTTTTT = Len(Trim(ConNo))
                            TTTTT = ""
                            Do While Ti <= TTTTTT
                                If (Trim(Mid(Trim(ConNo), Ti, 1)) <> "") Then
                                    TTTTT = TTTTT & Trim(Mid(Trim(ConNo), Ti, 1))
                                End If
                                Ti = Ti + 1
                                'If Len(Trim(ConNo)) = 12 Then
                                '    ConNo = Mid(Trim(ConNo), 1, 4) & Mid(Trim(ConNo), 6, 7)
                                'ElseIf Len(Trim(ConNo)) = 13 Then
                                '    ConNo = Mid(Trim(ConNo), 1, 4) & Mid(Trim(ConNo), 7, 7)
                                'End If

                            Loop
                            ConNo = TTTTT
                        End If
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) = 0 Then
                            ConType = ""
                        Else
                            Mark = 1
                            ConType = str
                        End If
                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then
                        ConStatus = ""
                    ElseIf Trim(str) = "5" Then
                        ConStatus = "F"
                    ElseIf Trim(str) = "4" Then
                        ConStatus = "E"
                    ElseIf Trim(str) = "7" Then
                        ConStatus = "L"
                    End If
                Else
                    Mark = 0

                End If
            End If
            Do While 1 = 1
                If Mark = 1 Then
                    txtLine = Trim(sr.ReadLine())                 '********EQA 资产对属 段
                    s = txtLine
                Else
                    txtLine = s
                End If
                If txtLine = Nothing Then
                    MsgBox("报文出错EQA 资产对属 段!,错误在" & i + 1 & "行!")
                    Exit Sub
                Else
                    If Mark = 1 Then i = i + 1
                    str = FetchStr(txtLine)                      '*******EQA 资产对属 段
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) = "EQA" Then
                        i99 = 1
                        Mark = 1
                    Else
                        Mark = 0
                        Exit Do
                    End If
                End If
            Loop
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********箱经营人 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错 箱经营人 段!,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******箱经营人
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "NAD" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "CA" Then                          '*****箱经营人
                        'MsgBox("报文出错箱经营人CA " & str & " ,错误在" & i + 1 & "行!")
                        'Exit Sub
                        'Mark = 0
                    Else
                        Mark = 1
                        If Len(Trim(txtLine)) > 0 Then
                            str = FetchStr(txtLine)
                            txtLine = Mid(txtLine, Len(str) + 2)
                            If Len(Trim(str)) = 0 Then
                                ConOperatorCode = ""
                                Mark = 0
                            Else
                                Mark = 1
                                ConOperatorCode = Mid(str, 1, InStr(str, ":") - 1)
                            End If
                            'If Mid(str, 5) <> "172:20" And Mid(str, 5) <> "172:ZZZ" And Mid(str, 5) <> "172" Then
                            '    'MsgBox("报文出错 172:20 172:ZZZ" & str & " ,错误在" & i + 1 & "行!")
                            '    'Exit Sub
                            '    Mark = 0
                            'End If
                        End If
                    End If
                Else

                        Mark = 0

                End If
            End If
            '*************************校验
            If i99 = 1 Then
                If Len(Trim(ConNo)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "报文  箱号空错误,错误在" & i & "行!"
                    Frm.ShowDialog()
                    ConNo = Trim(G_SelectCode)
                    If Len(Trim(ConNo)) = 12 Then
                        ConNo = Mid(Trim(ConNo), 1, 4) & Mid(Trim(ConNo), 6, 7)
                    End If
                End If
                If Len(Trim(ConType)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "箱 " & ConNo & " 箱型代码空错误"
                    Frm.ShowDialog()
                    ConType = Trim(G_SelectCode)
                End If
                If Len(Trim(ConStatus)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "箱 " & ConNo & " 箱空重空错误"
                    Frm.ShowDialog()
                    ConStatus = Trim(G_SelectCode)
                End If
                If Len(Trim(LoadPortCode)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "箱 " & ConNo & " 装货港代码空错误"
                    Frm.ShowDialog()
                    LoadPortCode = Trim(G_SelectCode)
                End If
                If Len(Trim(unLoadPortCode)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "箱 " & ConNo & " 卸货港代码空错误"
                    Frm.ShowDialog()
                    unLoadPortCode = Trim(G_SelectCode)
                End If
                If Len(Trim(ConBay)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "箱 " & ConNo & "  Bay 号 空错误"
                    Frm.ShowDialog()
                    ConBay = Trim(G_SelectCode)
                End If
                If Len(Trim(ConGrossWeight)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "箱 " & ConNo & "  箱毛重 空错误"
                    Frm.ShowDialog()
                    ConGrossWeight = Trim(G_SelectCode)
                End If
                'If Len(Trim(ConOperatorCode)) = 0 Then
                'Dim Frm As New FrmReadTemp
                'G_SelectStr = "箱 " & ConNo & " 箱经营人代码空错误"
                'Frm.ShowDialog()
                'ConOperatorCode = Trim(G_SelectCode)
                'End If
            End If
            '*************************
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********危险品 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******危险品
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "DGS" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "IMD" And Trim(str) <> "IMO" And Trim(str) <> "IMDG" Then                          '*****危险品
                        'MsgBox("报文出错 危险品IMD 标识错误 " & str & " ,错误在" & i + 1 & "行!")
                        'Exit Sub
                        'Mark = 0
                    Else
                        Mark = 1
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If InStr(str, ":") > 0 Then
                            DangerousClass = Mid(Trim(str), 1, InStr(Trim(str), ":") - 1)
                            If Len(Trim(DangerousClass)) = 0 Then
                                Dim Frm As New FrmReadTemp
                                G_SelectStr = "箱 " & ConNo & " 危险品等级空错误"
                                Frm.ShowDialog()
                                DangerousClass = Trim(G_SelectCode)
                            End If
                            DangerousPage = Mid(Trim(str), InStr(Trim(str), ":") + 1)
                            str = FetchStr(txtLine)
                            txtLine = Mid(txtLine, Len(str) + 2)
                            If Len(Trim(str)) > 0 Then
                                DangerousUNNO = Trim(str)
                            End If
                        Else
                            DangerousClass = Trim(str)
                            str = FetchStr(txtLine)
                            'txtLine = Mid(txtLine, Len(str) + 2)
                            If Len(Trim(str)) > 0 Then
                                DangerousUNNO = Trim(str)
                            End If
                        End If
                    End If
                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********危险品FTX 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******危险品FTX
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "FTX" Then
                    i99 = 1
                    Mark = 1

                Else
                    Mark = 0

                End If
            End If

            '********************************************************
            If i99 = 0 Then
                Exit Do
            Else
                '*****************写入箱信息
                Dim Size As String = "0"
                Dim Type As String = "0"
                Dim sqlstr As String
                Dim SSSS As String = "0"
                '*****************取箱型
                ds.Reset()
                sqlstr = "select * from Code_Con_Type where  Code_Ship_Type='" & ConType & "'"
                dw = Getdata(sqlstr, ds)
                If dw.Count > 0 Then
                    Size = Mid(Trim(ds.Tables(0).Rows(0).Item("Code_Con_Type")), 1, 2)
                    Type = Mid(Trim(ds.Tables(0).Rows(0).Item("Code_Con_Type")), 3, 2)
                    SSSS = Size
                Else
                    If IsNumeric(Mid(ConType, 1, 2)) Then
                        Size = Mid(ConType, 1, 2)
                    Else
                        'MsgBox("报文箱型尺寸 " & ConType & " 出错,错误在" & i + 1 & "行周围的箱子上!")
                        'Dim Frm As New FrmReadTemp
                        'G_SelectStr = "箱 " & ConNo & "  箱型错误" & ConType
                        'Frm.ShowDialog()
                        'ConType = Trim(G_SelectCode)
                        Size = Mid(ConType, 1, 2)
                    End If
                    SSSS = "0"
                    Type = Mid(ConType, 3, 2)
                End If
                ds.Dispose()
                dw.Dispose()

                '箱皮重 毛重
                If (Len(Trim(ConTareWeight)) <= 1) Then
                    If ConStatus = "E" Then
                        If Trim(Size) = "20" Then
                            ConTareWeight = "2300"
                            ConGrossWeight = "2300"
                        ElseIf Trim(Size) = "40" Then
                            ConTareWeight = "4000"
                            ConGrossWeight = "4000"
                        ElseIf Trim(Size) = "45" Then
                            ConTareWeight = "4600"
                            ConGrossWeight = "4600"
                        Else
                            ConTareWeight = "1200"
                            ConGrossWeight = "1200"
                        End If
                    End If
                End If
                '*********************写入集装箱箱号与船公司箱型代码对照表

                ds.Reset()

                sqlstr = "select * from Code_Type_Ship_Relation where CONTAINER_NO='" & Trim(ConNo) & "' and CODE_SHIP_OWNER='CMA'"
                dw = Updatedata(sqlda, sqlstr, ds)
                If dw.Count = 0 Then
                    Dim row As DataRow
                    row = ds.Tables(0).NewRow()
                    row("CONTAINER_NO") = Trim(ConNo)
                    row("CODE_SHIP_OWNER") = "CMA"
                    row("CODE_CON_TYPE") = ConType
                    ds.Tables(0).Rows.Add(row)
                    sqlda.Update(ds)
                End If
                ds.Dispose()
                dw.Dispose()
                sqlda.Dispose()
                '*********************写入船图临时表信息
                ds.Reset()

                sqlstr = "select * from CON_IMAGE_RECORD where CONTAINER_NO='" & ConNo & "' and BayNo='" & Mid(Trim(ConBay), 2, 6) & "' and Ship_ID=" & Ship_ID
                dw = Updatedata(sqlda, sqlstr, ds)
                If dw.Count = 0 Then
                    Dim row As DataRow
                    row = ds.Tables(0).NewRow()
                    row("Ship_ID") = Ship_ID
                    row("CONTAINER_NO") = Trim(ConNo)
                    row("Size_Con") = CInt(SSSS)
                    '******************未转换的代码
                    row("CodeConType") = ConType
                    row("CodeLoadPort") = LoadPortCode
                    row("CodeUnLoadPort") = unLoadPortCode
                    row("CodeDelivery") = DeliveryPlaceCode
                    '******************
                    row("FULLOREMPTY") = ConStatus
                    row("SEALNO") = ""
                    row("BAYNO") = Mid(Trim(ConBay), 2, 6)
                    row("BLNO") = BLNO
                    row("Mark") = ""
                    row("CODE_CON_KIND") = Type
                    row("CODE_CON_Type") = Size & Type
                    row("CODE_GOODS") = ""
                    row("Goods_Eng") = Mid(CargoDescr, 1, 35)
                    row("Goods_CHA") = Mid(CargoDescr, 1, 35)
                    row("CODE_LOAD_PORT") = LoadPortCode
                    row("LOAD_PORT") = LoadPort
                    row("CODE_UnLOAD_PORT") = unLoadPortCode
                    row("UnLOAD_PORT") = unLoadPort
                    row("CODE_DELIVERY") = DeliveryPlaceCode
                    row("DELIVERY") = DeliveryPlace
                    row("AMOUNT") = 0
                    If Len(Trim(ConGrossWeight)) > 0 Then
                        row("GrossWEIGHT") = CType(ConGrossWeight, Double)
                    End If
                    If Len(Trim(ConTareWeight)) > 0 Then
                        row("TareWeight") = CType(ConTareWeight, Double)
                    End If
                    row("VOLUME") = 0
                    row("TEMPERATURE_UNIT") = ConTempUnit
                    If Len(Trim(ConTempSet)) > 0 Then
                        row("TEMPERATURE_SETTING") = CType(ConTempSet, Double)
                    End If
                    If Len(Trim(ConTempMax)) > 0 Then
                        row("MAX_TEMPERATURE") = CType(ConTempMax, Double)
                    End If
                    If Len(Trim(ConTempMin)) > 0 Then
                        row("MIN_TEMPERATURE") = CType(ConTempMin, Double)
                    End If
                    If Len(Trim(ConOverHeight)) > 0 Then
                        row("OVER_HEIGHT") = CType(ConOverHeight, Double)
                    End If
                    If Len(Trim(ConOverLeft)) > 0 Then
                        row("OVER_LEFT") = CType(ConOverLeft, Double)
                    End If
                    If Len(Trim(ConOverRight)) > 0 Then
                        row("OVER_RIGHT") = CType(ConOverRight, Double)
                    End If
                    If Len(Trim(ConOverFront)) > 0 Then
                        row("OVER_BEFORE") = CType(ConOverFront, Double)
                    End If
                    If Len(Trim(ConOverBack)) > 0 Then
                        row("OVER_BEHIND") = CType(ConOverBack, Double)
                    End If
                    row("DANGER_GRADE") = DangerousClass
                    row("DANGER_PAGENO") = DangerousPage
                    row("DANGER_NO") = DangerousUNNO
                    row("DANGER_MARK") = DangerousLabel
                    row("CODE_MANUFACTURER") = ShipLineCode
                    row("MANUFACTURER") = ShipLine
                    row("CODE_KEEPER") = ConOperatorCode
                    row("KEEPER") = ConOperator
                    row("Demo") = CargoDescr
                    row("ConDemo") = ConDescr
                    If Len(Length) > 0 Then
                        row("Length") = CType(Length, Int32)
                    End If
                    If Len(width) > 0 Then
                        row("width") = CType(width, Int32)
                    End If
                    If Len(Height) > 0 Then
                        row("height") = CType(Height, Int32)
                    End If
                    ds.Tables(0).Rows.Add(row)
                    sqlda.Update(ds)
                End If
                ds.Dispose()
                dw.Dispose()
                sqlda.Dispose()
            End If
            j = j + 1
        Loop
        '*************处理 UNT
        PB.Value = 2000
        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '按行方式读取一行
            s = txtLine
        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("报文出错!处理 UNT,错误在" & i + 1 & "行!")
            Exit Sub
        Else
            If Mark = 1 Then i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) = "UNT" Then
                Mark = 1
                str = FetchStr(txtLine)
                If i <> CInt(str) Then
                    MsgBox("报文行数不对,错误在" & i + 1 & "行!")
                Else

                End If
            Else
                MsgBox("报文读取出错,错误在" & i + 1 & "行!")
                Exit Sub
            End If
        End If
        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '按行方式读取一行
            s = txtLine

        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("报文出错!处理 UNZ,错误在" & i + 2 & "行!")
            Exit Sub
        Else

            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) = "UNZ" Then
                str = FetchStr(txtLine)
                If Trim(str) <> "1" Then
                    MsgBox("报文读取出错,错误在" & i + 2 & "行!")
                    Exit Sub
                Else
                    MsgBox("报文读取正确! 共读到 " & i & " 行")
                End If
            Else
                MsgBox("报文读取出错,错误在" & i + 2 & "行!")
                Exit Sub
            End If
        End If

        sr.Close()
        Me.Close()

    End Sub
    Private Sub ReadUNFile95B(ByVal strFile As String)
        Dim sr As New StreamReader(Mid(txtFile.Text, 1, FindLOC(txtFile.Text) - 1) & "\UnTemp.txt") '打开报文文件
        Dim txtLine As String
        Dim sTemp As String
        Dim i As Integer = 0 '记录行数
        Dim j As Integer = 0 '取箱信息循环
        Dim i99 As Integer '判断结束
        Dim str As String
        Dim s As String
        Dim Mark As Integer = 0 '**********标识某行是否处理完 1表示处理完 0表示未处理完

        Dim ShipName As String = "" '船名
        Dim ShipCode As String = "" '船名码
        Dim Voyage As String = "" '航次
        Dim ShipLineCode As String = "" '船公司代码
        Dim ShipLine As String = "" '船公司
        Dim ConNo As String = "" '箱号
        Dim ConType As String = "" '箱尺寸类型
        Dim ConStatus As String = "" '箱状态
        Dim ConBay As String = "" '箱贝位号
        Dim ConTempUnit As String = "" '温度计量单位
        Dim ConTempSet As String = "" '设置温度
        Dim ConTempMax As String = "" '冷藏最高温度
        Dim ConTempMin As String = "" '冷藏最低温度
        Dim ConOverFront As String = "" '前超
        Dim ConOverBack As String = "" '后超
        Dim ConOverLeft As String = "" '左超
        Dim ConOverRight As String = "" '右超
        Dim ConOverHeight As String = "" '超高
        Dim ConGrossWeight As String = "" '箱毛重
        Dim ConTareWeight As String = "" '箱皮重
        Dim ConOperatorCode As String = "" '箱经营人代码
        Dim ConOperator As String = "" '箱经营人
        Dim BLNO As String = "" '提单号
        Dim LoadPortCode As String = "" '装货港代码
        Dim LoadPort As String = "" '装货港
        Dim unLoadPortCode As String = "" '卸货港代码
        Dim unLoadPort As String = "" '卸货港
        Dim DeliveryPlaceCode As String = "" '交货地代码
        Dim DeliveryPlace As String = "" '交货地
        Dim DangerousClass As String = "" '危险品分类
        Dim DangerousPage As String = "" '危险品页号
        Dim DangerousUNNO As String = "" '联合国危险品编号
        Dim DangerousLabel As String = "" '危险品标签
        Dim CargoDescr As String = "" '货物描述
        Dim ConDescr As String = ""
        Dim sign As String = ""
        Dim Length As String = ""
        Dim width As String = ""
        Dim Height As String = ""

        '**************读报文头
        txtLine = Trim(sr.ReadLine()) '按行方式读取一行

        '***********处理记录 文件 头记录
        If txtLine = Nothing Then
            MsgBox("报文出错!")
            Exit Sub
        Else
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "UNB" Then
                MsgBox("报文出错 " & str & " ,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) <> "UNOA:1" And Trim(str) <> "UNOA:2" And Trim(str) <> "UNOA:3" Then                       '船图标识
                    'MsgBox("报文出错 " & str & " ,语法标识符或版本号错误,错误在" & i + 1 & "行!")
                    'Exit Sub
                Else
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then              '发送方标识
                        'MsgBox("报文出错 " & str & " ,不是船图报文,错误在" & i + 1 & "行!")
                        'Exit Sub
                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then              '接受方标识
                        'MsgBox("报文出错 " & str & " ,不是船图报文,错误在" & i + 1 & "行!")
                        'Exit Sub
                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then              '日期时间标识
                        'MsgBox("报文出错 " & str & " ,不是船图报文,错误在" & i + 1 & "行!")
                        'Exit Sub
                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then              '日期时间标识
                        'MsgBox("报文出错 " & str & " ,不是船图报文,错误在" & i + 1 & "行!")
                        'Exit Sub
                    End If
                    'str = FetchStr(txtLine)
                    'txtLine = Mid(txtLine, Len(str) + 2)
                    'str = FetchStr(txtLine)
                    'txtLine = Mid(txtLine, Len(str) + 2)
                    'str = FetchStr(txtLine)
                    'txtLine = Mid(txtLine, Len(str) + 2)
                    'str = FetchStr(txtLine)
                    'txtLine = Mid(txtLine, Len(str) + 2)
                    'str = FetchStr(txtLine)
                    'txtLine = Mid(txtLine, Len(str) + 2)
                    'If Len(Trim(str)) = 0 Then              '船公司标识
                    '    'MsgBox("报文出错 "& str &" ,不是船图报文!")
                    '    'Exit Sub
                    'Else
                    '    ShipLineCode = Trim(str)
                    'End If
                End If
            End If
        End If
        '*************处理记录 报文头记录
        txtLine = Trim(sr.ReadLine()) '按行方式读取一行
        If txtLine = Nothing Then
            MsgBox("报文出错!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "UNH" Then                        '报文头记录
                MsgBox("报文出错 " & str & " ,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) = 0 Then                    '时间标识
                    'MsgBox("报文出错 " & str & " ,错误在" & i + 1 & "行!")
                    'Exit Sub
                End If
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) <> 0 Then
                    If InStr(UCase(Trim(str)), "BAPLIE") = 0 And InStr(UCase(Trim(str)), "95B") = 0 Then   '船图标识 
                        MsgBox("报文出错 " & str & " ,船图标识 报文版本号出错,错误在" & i + 1 & "行!")
                        Exit Sub
                    End If
                End If
            End If
        End If
        '*************处理记录 报文开始记录
        txtLine = Trim(sr.ReadLine()) '按行方式读取一行
        If txtLine = Nothing Then
            MsgBox("报文出错!报文开始记录 ,错误在" & i + 1 & "行!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "BGM" Then                        '报文头记录
                MsgBox("报文报文开始记录BGM出错 " & str & " ,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) <> "2" And Trim(str) <> "4" And Trim(str) <> "5" And Trim(str) <> "9" And Trim(str) <> "22" Then                     '报文功能标识 
                    'MsgBox("报文报文功能标识出错 " & str & " ,错误在" & i + 1 & "行!")
                    'Exit Sub
                Else

                End If
            End If
        End If
        '*************处理记录 报文开始时间记录
        txtLine = Trim(sr.ReadLine()) '按行方式读取一行
        If txtLine = Nothing Then
            MsgBox("报文开始时间记录出错,错误在" & i + 1 & "行!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "DTM" Then                        '报文头记录
                MsgBox("报文DTM出错 " & str & " ,错误在" & i + 1 & "行!")
                Exit Sub
            Else

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) = 0 Then                    '时间标识 
                    'MsgBox("报文时间标识 出错 " & str & " ,错误在" & i + 1 & "行!")
                    'Exit Sub
                Else
                    If Mid(Trim(str), 1, 3) <> "137" Then
                        'MsgBox("报文137出错 " & str & " ,错误在" & i + 1 & "行!")
                        'Exit Sub
                    End If
                End If


            End If
        End If
        Mark = 1
        '*************处理记录 船舶有关的基本数据项目
TT:     If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '按行方式读取一行
        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("报文出错,错误在" & i + 1 & "行!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "TDT" Then                        '报文头记录
                MsgBox("报文头记录TDT出错 " & str & " ,错误在" & i + 1 & "行!")
                Exit Sub
            Else

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) <> "20" Then                    '限定符 
                    MsgBox("报文限定符20出错 " & str & " ,错误在" & i + 1 & "行!")
                    Exit Sub
                End If

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) = 0 Then                  '航次 
                    'MsgBox("报文航次出错 " & str & " ,错误在" & i + 1 & "行!")
                    'Exit Sub
                Else
                    Voyage = str
                End If
            End If
        End If
        '*************处理记录 装货港
        txtLine = Trim(sr.ReadLine()) '按行方式读取一行
        If txtLine = Nothing Then
            MsgBox("报文装货港出错,错误在" & i + 1 & "行!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "LOC" Then                        '报文头记录
                MsgBox("报文头记录LOC出错 " & str & " ,错误在" & i + 1 & "行!")
                Exit Sub
            Else

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) <> "5" Then                      '装货港标识 
                    MsgBox("装货港标识5出错 " & str & " ,错误在" & i + 1 & "行!")
                    Exit Sub
                End If

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) = 0 Then                     '装货港
                    'MsgBox("报文出错 "& str &" ,错误在" & i + 1 & "行!")
                    'Dim Frm As New FrmReadTemp
                    'G_SelectStr = "此报文 " & "  装货港空错误"
                    'Frm.ShowDialog()
                    'LoadPortCode = Trim(G_SelectCode)
                Else
                    LoadPortCode = Trim(str)
                End If
            End If
        End If
        '*************处理记录 卸货港
        txtLine = Trim(sr.ReadLine()) '按行方式读取一行
        s = txtLine
        If txtLine = Nothing Then
            MsgBox("报文卸货港出错,错误在" & i + 1 & "行!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "LOC" Then                        '报文头记录
                'MsgBox("报文头记录LOC出错 " & str & " ,错误在" & i + 1 & "行!")
                Mark = 0
                'Exit Sub
            Else
                Mark = 1
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) <> "61" Then                      '卸货港标识 
                    MsgBox("报文卸货港标识61出错 " & str & " ,错误在" & i + 1 & "行!")
                    Exit Sub
                End If

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) = 0 Then                     '卸货港
                    'MsgBox("报文出错 "& str &" ,错误在" & i + 1 & "行!")
                    'Dim Frm As New FrmReadTemp
                    'G_SelectStr = "此报文 " & "  卸货港空错误"
                    'Frm.ShowDialog()
                    'unLoadPortCode = Trim(G_SelectCode)
                Else
                    unLoadPortCode = Trim(str)
                End If
            End If
        End If

        '*************处理记录 报文178时间记录
        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '按行方式 读取一行()
            s = txtLine
        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("报文178 Or 132 时间记录出错,错误在" & i + 1 & "行!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "DTM" Then                        '报文头记录
                MsgBox("报文头记录DTM出错 " & str & " ,错误在" & i + 1 & "行!")
                Exit Sub
            Else

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Mid(Trim(str), 1, 3) = "178" Or Mid(Trim(str), 1, 3) = "132" Then                  '时间标识 
                    Mark = 1
                Else
                    Mark = 0
                End If
            End If
        End If
        '*************处理记录 报文136时间记录
        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '按行方式读取一行
            s = txtLine
        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("报文136 OR 133 时间记录出错,错误在" & i + 1 & "行!")
            Exit Sub
        Else
            If Mark = 1 Then i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "DTM" Then                        '报文头记录
                'MsgBox("报文头记录DTM出错 " & str & " ,错误在" & i + 1 & "行!")
                'Exit Sub
                Mark = 0
            Else
                Mark = 1
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Mid(Trim(str), 1, 3) = "136" Or Mid(Trim(str), 1, 3) = "133" Then                   '时间标识 
                    Mark = 1
                Else
                    Mark = 0
                    'MsgBox("报文时间标识 136 或 133出错 " & str & " ,错误在" & i + 1 & "行!")
                    'Exit Sub
                End If
            End If
        End If
        '*************处理记录 报文132时间记录

        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '按行方式读取一行
            s = txtLine
        Else
            txtLine = s
        End If

        If txtLine = Nothing Then
            MsgBox("报文132时间记录出错,错误在" & i + 1 & "行!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "DTM" Then                        '报文头记录
                'MsgBox("报文头记录DTM出错 " & str & " ,错误在" & i + 1 & "行!")
                'Exit Sub
                Mark = 0
            Else

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Mid(Trim(str), 1, 3) = "132" Then                  '时间标识 
                    Mark = 1
                Else
                    Mark = 0
                    'MsgBox("报文时间标识132出错 " & str & " ,错误在" & i + 1 & "行!")
                    'Exit Sub
                End If
            End If
        End If
        '*************处理记录 报文RFF时间记录

        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '按行方式读取一行
            s = txtLine
        Else
            txtLine = s
        End If

        If txtLine = Nothing Then
            MsgBox("报文RFF时间记录出错,错误在" & i + 1 & "行!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "RFF" Then                        '报文头记录
                'MsgBox("报文头记录RFF出错 " & str & " ,错误在" & i + 1 & "行!")
                'Exit Sub
                Mark = 0
            Else
                Mark = 1
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Mid(Trim(str), 1, 3) = "VON" Or Mid(Trim(str), 1, 3) = "ZZZ" Then                 '装货航次
                    Mark = 1
                Else
                    Mark = 1
                    'MsgBox("报文装货航次VON出错 " & str & " ,错误在" & i + 1 & "行!")
                    'Exit Sub
                End If


            End If
        End If
        '*************处理记录 报文FTX时间记录

        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '按行方式读取一行
            s = txtLine
        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("报文FTX时间记录出错,错误在" & i + 1 & "行!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If UCase(Trim(str)) = "FTX" Then                        '报文头记录
                Mark = 1
            Else
                Mark = 0
            End If
        End If

        '*****************集装箱信息 (开始循环)
        Do While j < 9999
            If j < 2000 Then
                PB.Value = j
            End If
            ConNo = ""
            ConType = ""
            ConStatus = ""
            ConBay = ""  '箱贝位号
            ConTempUnit = ""  '温度计量单位
            ConTempSet = "" '设置温度
            ConTempMax = ""  '冷藏最高温度
            ConTempMin = ""  '冷藏最低温度
            ConOverFront = ""  '前超
            ConOverBack = ""  '后超
            ConOverLeft = ""  '左超
            ConOverRight = "" '右超
            ConOverHeight = ""  '超高
            ConGrossWeight = ""  '箱毛重
            ConTareWeight = ""  '箱皮重
            ConOperatorCode = ""  '箱经营人代码
            ConOperator = ""  '箱经营人
            BLNO = ""  '提单号
            LoadPortCode = ""  '装货港代码
            LoadPort = ""  '装货港
            unLoadPortCode = ""  '卸货港代码
            unLoadPort = ""  '卸货港
            DeliveryPlaceCode = ""  '交货地代码
            DeliveryPlace = ""  '交货地
            DangerousClass = ""  '危险品分类
            DangerousPage = ""  '危险品页号
            DangerousUNNO = ""  '联合国危险品编号
            DangerousLabel = ""  '危险品标签
            CargoDescr = ""  '货物描述
            ConDescr = ""
            Length = ""
            width = ""
            Height = ""

            i99 = 0
            '*************处理记录  描述集装箱信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())             '********贝位号
                s = txtLine
            Else
                txtLine = s
            End If
            If Mid(txtLine, 1, 3) = "TDT" Then   '*********跳转循环
                Mark = 0
                GoTo TT
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错处理记录  描述集装箱信息!,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "147" Then           '******贝位限定符出错
                        MsgBox("报文贝位限定符LOC147出错 " & str & " ,错误在" & i + 1 & "行!")
                        Exit Sub
                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then
                        'MsgBox("报文出错 " & str & " ,错误在" & i + 1 & "行!")
                        ConBay = ""
                    Else
                        ConBay = Mid(Trim(str), 1, 7)   '******贝位号
                        If Len(Trim(ConBay)) = 6 Then
                            ConBay = "0" & ConBay
                        End If
                    End If
                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())             '********GID 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错GID 段!,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                '*******GID
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "GID" Then
                    i99 = 1
                    Mark = 1
                Else
                    Mark = 0
                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())             '********GDS 货物性质段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错GDS 货物性质段!,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                '*******GDS 货物性质
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "GDS" Then
                    i99 = 1
                    Mark = 1
                Else
                    Mark = 0
                End If
            End If
            CargoDescr = ""
            Dim mm As Integer
            mm = 0
            Do While mm < 9
                If Mark = 1 Then
                    txtLine = Trim(sr.ReadLine())             '********FTX 段
                    s = txtLine
                Else
                    txtLine = s
                End If

                If txtLine = Nothing Then
                    MsgBox("报文出错FTX 段!,错误在" & i + 1 & "行!")
                    Exit Sub
                Else
                    If Mark = 1 Then i = i + 1
                    str = FetchStr(txtLine)                '*******FTX
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) = "FTX" Then
                        i99 = 1
                        Mark = 1
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If str = "AAA" Then
                            str = FetchStr(txtLine)
                            txtLine = Mid(txtLine, Len(str) + 2)
                            str = FetchStr(txtLine)
                            txtLine = Mid(txtLine, Len(str) + 2)
                            str = FetchStr(txtLine)
                            txtLine = Mid(txtLine, Len(str) + 2)
                            CargoDescr = CargoDescr & str
                        ElseIf str = "CLR" Then
                            str = FetchStr(txtLine)
                            txtLine = Mid(txtLine, Len(str) + 2)
                            str = FetchStr(txtLine)
                            txtLine = Mid(txtLine, Len(str) + 2)
                            str = FetchStr(txtLine)
                            txtLine = Mid(txtLine, Len(str) + 2)
                            CargoDescr = CargoDescr & str

                        End If
                    Else
                        Mark = 0
                    End If
                End If
                mm = mm + 1
            Loop

            Dim TTT As Integer
            TTT = 0
            Do While TTT < 9
                If Mark = 1 Then
                    txtLine = Trim(sr.ReadLine())             '********MEA 段
                    s = txtLine
                Else
                    txtLine = s
                End If
                If txtLine = Nothing Then
                    MsgBox("报文出错MEA 段!,错误在" & i + 1 & "行!")
                    Exit Sub
                Else
                    If Mark = 1 Then i = i + 1
                    str = FetchStr(txtLine)                '*******MEA
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) = "MEA" Then
                        i99 = 1
                        Mark = 1
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Trim(str) <> "WT" Then               '*****重量限定符
                            MsgBox("报文重量限定符WT出错 " & str & " ,错误在" & i + 1 & "行!")
                            Exit Sub
                        End If
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) = 0 Then             '*****重量限定符
                            MsgBox("报文重量限定符KGM LBR出错 " & str & " ,错误在" & i + 1 & "行!")
                            Exit Sub
                        Else
                            If Mid(Trim(str), 1, 3) = "KGM" Then
                                ConGrossWeight = Mid(Trim(str), 5)
                            ElseIf Mid(Trim(str), 1, 3) = "LBR" Then
                                If Len(Trim(Mid(Trim(str), 5))) > 0 Then
                                    ConGrossWeight = Trim(CStr(CType(Mid(Trim(str), 5), Int32) * 0.45))
                                Else
                                    ConGrossWeight = ""
                                End If

                            End If
                        End If
                    Else
                        Mark = 0

                    End If
                End If
                TTT = TTT + 1
            Loop

            Dim TTTT As Integer
            TTTT = 0
            Do While TTTT < 9
                If Mark = 1 Then
                    txtLine = Trim(sr.ReadLine())                 '********DIM 段
                    s = txtLine
                Else
                    txtLine = s
                End If
                If txtLine = Nothing Then
                    MsgBox("报文出错DIM 段!,错误在" & i + 1 & "行!")
                    Exit Sub
                Else
                    If Mark = 1 Then i = i + 1
                    str = FetchStr(txtLine)                      '*******DIM
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) = "DIM" Then
                        i99 = 1
                        Mark = 1
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Trim(str) <> "1" And Trim(str) <> "5" And Trim(str) <> "6" And Trim(str) <> "7" And Trim(str) <> "8" And Trim(str) <> "9" Then                 '*****重量限定符
                            MsgBox("报文重量限定符1 5 6 7 8 9出错 " & str & " ,错误在" & i + 1 & "行!")
                            Exit Sub
                        Else
                            sTemp = Trim(str)
                        End If
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        
                        If Len(Trim(str)) = 0 Then             '*****超大箱定符
                            MsgBox("报文超大箱定符CMT 出错 " & str & " ,错误在" & i + 1 & "行!")
                            Exit Sub
                        Else
                            If (Mid(Trim(str), 1, 3) = "CNT" Or Mid(Trim(str), 1, 3) = "CMT" Or Mid(Trim(str), 1, 2) = "CM") Then

                                If sTemp = "5" Then
                                    'str = Mid(Trim(str), 5)
                                    str = Mid(str, InStr(str, ":") + 1)
                                    Do While Mid(str, 1, 1) = ":"
                                        str = Mid(str, 2)
                                    Loop
                                    If InStr(str, ":") > 0 Then
                                        str = Mid(str, 1, InStr(str, ":") - 1)
                                    Else
                                        str = str
                                    End If
                                    ConOverFront = str
                                End If
                                If sTemp = "6" Then
                                    'str = Mid(Trim(str), 5)
                                    str = Mid(str, InStr(str, ":") + 1)
                                    Do While Mid(str, 1, 1) = ":"
                                        str = Mid(str, 2)
                                    Loop
                                    If InStr(str, ":") > 0 Then
                                        str = Mid(str, 1, InStr(str, ":") - 1)
                                    Else
                                        str = str
                                    End If
                                    ConOverBack = str
                                End If
                                If sTemp = "7" Then
                                    'str = Mid(Trim(str), 5)
                                    str = Mid(str, InStr(str, ":") + 1)
                                    Do While Mid(str, 1, 1) = ":"
                                        str = Mid(str, 2)
                                    Loop
                                    If InStr(str, ":") > 0 Then
                                        str = Mid(str, 1, InStr(str, ":") - 1)
                                    Else
                                        str = str
                                    End If
                                    ConOverRight = str
                                End If
                                If sTemp = "8" Then
                                    'str = Mid(Trim(str), 5)
                                    str = Mid(str, InStr(str, ":") + 1)
                                    Do While Mid(str, 1, 1) = ":"
                                        str = Mid(str, 2)
                                    Loop
                                    If InStr(str, ":") > 0 Then
                                        str = Mid(str, 1, InStr(str, ":") - 1)
                                    Else
                                        str = str
                                    End If
                                    ConOverLeft = str
                                End If
                                If sTemp = "9" Then
                                    'str = Mid(Trim(str), 5)
                                    str = Mid(str, InStr(str, ":") + 1)
                                    Do While Mid(str, 1, 1) = ":"
                                        str = Mid(str, 2)
                                    Loop
                                    If InStr(str, ":") > 0 Then
                                        str = Mid(str, 1, InStr(str, ":") - 1)
                                    Else
                                        str = str
                                    End If
                                    ConOverHeight = str

                                End If
                                If sTemp = "1" Then
                                    str = Mid(Trim(str), 5)
                                    Length = Mid(str, 1, InStr(str, ":") - 1)
                                    'str = Mid(Trim(str), 5)
                                    str = Mid(str, InStr(str, ":") + 1)
                                    width = Mid(str, 1, InStr(str, ":") - 1)
                                    'str = Mid(Trim(str), 5)
                                    str = Mid(str, InStr(str, ":") + 1)
                                    Height = Mid(str, InStr(str, ":") + 1)
                                End If
                            ElseIf Mid(Trim(str), 1, 3) = "INH" Then
                                    'ConGrossWeight = Trim(CStr(CType(Mid(Mid(Trim(str), 5), 1, Len(Mid(Trim(str), 5)) - 1), Int32) * 0.45))
                                    If sTemp = "1" Then
                                        str = Mid(Trim(str), 5)
                                        Length = Mid(str, 1, InStr(str, ":") - 1)
                                        'str = Mid(Trim(str), 5)
                                        str = Mid(str, InStr(str, ":") + 1)
                                        width = Mid(str, 1, InStr(str, ":") - 1)
                                        'str = Mid(Trim(str), 5)
                                        str = Mid(str, InStr(str, ":") + 1)
                                        Height = Mid(str, InStr(str, ":") + 1)
                                    End If
                                    If sTemp = "5" Then
                                        'str = Mid(Trim(str), 5)
                                    str = Mid(str, InStr(str, ":") + 1)
                                    Do While Mid(str, 1, 1) = ":"
                                        str = Mid(str, 2)
                                    Loop
                                    If InStr(str, ":") > 0 Then
                                        str = Mid(str, 1, InStr(str, ":") - 1)
                                    Else
                                        str = str
                                    End If
                                    ConOverFront = CType(str, Double) * 2.5
                                End If
                                    If sTemp = "6" Then
                                        'str = Mid(Trim(str), 5)
                                    str = Mid(str, InStr(str, ":") + 1)
                                    Do While Mid(str, 1, 1) = ":"
                                        str = Mid(str, 2)
                                    Loop
                                    If InStr(str, ":") > 0 Then
                                        str = Mid(str, 1, InStr(str, ":") - 1)
                                    Else
                                        str = str
                                    End If
                                    ConOverBack = CType(str, Double) * 2.5
                                End If
                                    If sTemp = "7" Then
                                        'str = Mid(Trim(str), 5)
                                    str = Mid(str, InStr(str, ":") + 1)
                                    Do While Mid(str, 1, 1) = ":"
                                        str = Mid(str, 2)
                                    Loop
                                    If InStr(str, ":") > 0 Then
                                        str = Mid(str, 1, InStr(str, ":") - 1)
                                    Else
                                        str = str
                                    End If
                                    ConOverRight = CType(str, Double) * 2.5
                                End If
                                    If sTemp = "8" Then
                                        'str = Mid(Trim(str), 5)
                                    str = Mid(str, InStr(str, ":") + 1)
                                    Do While Mid(str, 1, 1) = ":"
                                        str = Mid(str, 2)
                                    Loop
                                    If InStr(str, ":") > 0 Then
                                        str = Mid(str, 1, InStr(str, ":") - 1)
                                    Else
                                        str = str
                                    End If
                                    ConOverLeft = CType(str, Double) * 2.5
                                End If
                                    If sTemp = "9" Then
                                        'str = Mid(Trim(str), 5)
                                    str = Mid(str, InStr(str, ":") + 1)
                                    Do While Mid(str, 1, 1) = ":"
                                        str = Mid(str, 2)
                                    Loop
                                    If InStr(str, ":") > 0 Then
                                        str = Mid(str, 1, InStr(str, ":") - 1)
                                    Else
                                        str = str
                                    End If
                                    ConOverHeight = CType(str, Double) * 2.5

                                End If

                            End If
                        End If
                    Else
                        Mark = 0
                    End If
                End If
                TTTT = TTTT + 1
            Loop
            
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********TMP 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错TMP 段!,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******TMP
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "TMP" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "1" And Trim(str) <> "2" Then                 '*****冷藏箱
                        MsgBox("报文冷藏箱出错 " & str & " ,错误在" & i + 1 & "行!")
                        Exit Sub

                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then             '*****冷藏箱
                        MsgBox("报文冷藏箱出错 " & str & " ,错误在" & i + 1 & "行!")
                        Exit Sub
                    Else
                        ConTempSet = Mid(Trim(str), 1, InStr(Trim(str), ":") - 1)
                        ConTempUnit = Mid(Trim(str), InStr(Trim(str), ":") + 1, 1)
                    End If
                Else
                    Mark = 0
                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********RNG 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错RNG 段!,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******RNG
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "RNG" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "ZZZ" Then                  '*****冷藏箱温度范围
                        MsgBox("报文冷藏箱温度范围出错 " & str & " ,错误在" & i + 1 & "行!")
                        Exit Sub

                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then             '*****冷藏箱
                        MsgBox("报文冷藏箱出错 " & str & " ,错误在" & i + 1 & "行!")
                        Exit Sub
                    Else
                        ConTempUnit = Mid(Trim(str), 1, 1)
                        sTemp = Mid(Trim(str), 5)
                        ConTempMin = Mid(sTemp, 1, InStr(Trim(sTemp), ":") - 1)
                        ConTempMax = Mid(sTemp, InStr(Trim(sTemp), ":") + 1)
                    End If
                Else
                    Mark = 0
                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********装货港 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错装货港 段!,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******装货港
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "6" And Trim(str) <> "9" Then                  '*****装货港
                        MsgBox("报文出错 " & str & " ,错误在" & i + 1 & "行!")
                        Exit Sub

                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then             '*****装货港
                        LoadPortCode = ""
                    Else
                        LoadPortCode = Trim(str)
                    End If
                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********卸货港 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错卸货港 段!,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******卸货港 
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "12" And Trim(str) <> "11" Then                   '*****卸货港 
                        MsgBox("报文出错 " & str & " ,错误在" & i + 1 & "行!")
                        Exit Sub

                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then             '*****卸货港 
                        unLoadPortCode = ""
                    Else
                        unLoadPortCode = Trim(str)
                    End If
                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********可选卸货港 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错!,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******可选卸货港 段
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "97" Then                   '*****可选卸货港 段
                        Mark = 0
                    Else
                        Mark = 1
                    End If

                Else
                    Mark = 0
                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********目的港 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错目的港 段!,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******目的港
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "83" Then                   '*****目的港
                        MsgBox("报文出错目的港 " & str & " ,错误在" & i + 1 & "行!")
                        Exit Sub

                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then             '*****目的港                        
                        DeliveryPlaceCode = Trim(str)
                    End If
                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********可选目的港1 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! ,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******可选目的港
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "63" Then                   '*****可选目的港
                        Mark = 0
                    Else
                        Mark = 1
                    End If

                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********可选目的港2 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! ,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******可选目的港
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "65" Then                   '*****可选目的港
                        Mark = 0
                    Else
                        Mark = 1
                    End If

                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********可选目的港3 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! ,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******可选目的港
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "69" Then                   '*****可选目的港
                        Mark = 0
                    Else
                        Mark = 1
                    End If

                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********可选目的港4 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! ,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******可选目的港
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "71" Then                   '*****可选目的港
                        Mark = 0
                    Else
                        Mark = 1
                    End If

                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********可选目的港5 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! ,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******可选目的港
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "74" Then                   '*****可选目的港
                        Mark = 0
                    Else
                        Mark = 1
                    End If

                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********提单号 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错提单号 段! ,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******提单号 
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "RFF" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Mid(Trim(str), 1, 2) <> "BM" And Mid(Trim(str), 1, 2) <> "ET" Then                       '*****提单号 
                        'MsgBox("报文出错提单号 段 " & str & " ,错误在" & i + 1 & "行!")
                        'Exit Sub
                        'Mark = 0
                    Else
                        BLNO = Mid(Trim(str), 4)                '*****提单号 
                        Mark = 1
                    End If

                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********箱信息 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错箱信息 段!,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******箱信息
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "EQD" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "CN" And Trim(str) <> "BB" And Trim(str) <> "ZZZ" Then                         '*****箱信息
                        'MsgBox("报文出错 CN BB ZZZ" & str & " ,错误在" & i + 1 & "行!")
                        'Exit Sub
                        'Mark = 0
                    Else
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) = 0 Then
                            ConNo = ""
                        Else
                            Mark = 1
                            ConNo = str
                            Dim TTTTT As String
                            Dim TTTTTT As Int16
                            Dim Ti As Int16

                            Ti = 1
                            TTTTTT = Len(Trim(ConNo))
                            TTTTT = ""
                            Do While Ti <= TTTTTT
                                If (Trim(Mid(Trim(ConNo), Ti, 1)) <> "") Then
                                    TTTTT = TTTTT & Trim(Mid(Trim(ConNo), Ti, 1))
                                End If
                                Ti = Ti + 1
                                'If Len(Trim(ConNo)) = 12 Then
                                '    ConNo = Mid(Trim(ConNo), 1, 4) & Mid(Trim(ConNo), 6, 7)
                                'ElseIf Len(Trim(ConNo)) = 13 Then
                                '    ConNo = Mid(Trim(ConNo), 1, 4) & Mid(Trim(ConNo), 7, 7)
                                'End If

                            Loop
                            ConNo = TTTTT
                            'If Len(Trim(ConNo)) = 12 Then
                            '    ConNo = Mid(Trim(ConNo), 1, 4) & Mid(Trim(ConNo), 6, 7)
                            'End If
                        End If
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) = 0 Then
                            ConType = ""
                        Else
                            Mark = 1
                            ConType = str
                        End If
                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then
                        ConStatus = ""
                    ElseIf Trim(str) = "5" Then
                        ConStatus = "F"
                    ElseIf Trim(str) = "4" Then
                        ConStatus = "E"
                    ElseIf Trim(str) = "7" Then
                        ConStatus = "L"
                    End If
                Else
                    Mark = 0

                End If
            End If
            Do While 1 = 1
                If Mark = 1 Then
                    txtLine = Trim(sr.ReadLine())                 '********EQA 资产对属 段
                    s = txtLine
                Else
                    txtLine = s
                End If
                If txtLine = Nothing Then
                    MsgBox("报文出错EQA 资产对属 段!,错误在" & i + 1 & "行!")
                    Exit Sub
                Else
                    If Mark = 1 Then i = i + 1
                    str = FetchStr(txtLine)                      '*******EQA 资产对属 段
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) = "EQA" Then
                        i99 = 1
                        Mark = 1
                    Else
                        Mark = 0
                        Exit Do
                    End If
                End If
            Loop
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********箱经营人 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错 箱经营人 段!,错误在" & i + 1 & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******箱经营人
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "NAD" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "CA" Then                          '*****箱经营人
                        'MsgBox("报文出错箱经营人CA " & str & " ,错误在" & i + 1 & "行!")
                        'Exit Sub
                        'Mark = 0
                    Else
                        Mark = 1
                        If Len(Trim(txtLine)) > 0 Then
                            str = FetchStr(txtLine)
                            txtLine = Mid(txtLine, Len(str) + 2)
                            If Len(Trim(str)) = 0 Then
                                ConOperatorCode = ""
                                Mark = 0
                            Else
                                Mark = 1
                                ConOperatorCode = Mid(str, 1, InStr(str, ":") - 1)
                            End If
                            If Mid(str, 5, 3) <> "172" Then
                                'MsgBox("报文出错 172" & str & " ,错误在" & i + 1 & "行!")
                                'Exit Sub
                                'Mark = 0
                            End If
                        End If
                    End If
                Else

                        Mark = 0

                End If
            End If
            '*************************校验
            If i99 = 1 Then
                If Len(Trim(ConNo)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "报文  箱号空错误,错误在" & i & "行!"
                    Frm.ShowDialog()
                    ConNo = Trim(G_SelectCode)
                    If Len(Trim(ConNo)) = 12 Then
                        ConNo = Mid(Trim(ConNo), 1, 4) & Mid(Trim(ConNo), 6, 7)
                    End If
                End If
                If Len(Trim(ConType)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "箱 " & ConNo & " 箱型代码空错误"
                    Frm.ShowDialog()
                    ConType = Trim(G_SelectCode)
                End If
                If Len(Trim(ConStatus)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "箱 " & ConNo & " 箱空重空错误"
                    Frm.ShowDialog()
                    ConStatus = Trim(G_SelectCode)
                End If
                If Len(Trim(LoadPortCode)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "箱 " & ConNo & " 装货港代码空错误"
                    Frm.ShowDialog()
                    LoadPortCode = Trim(G_SelectCode)
                End If
                If Len(Trim(unLoadPortCode)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "箱 " & ConNo & " 卸货港代码空错误"
                    Frm.ShowDialog()
                    unLoadPortCode = Trim(G_SelectCode)
                End If
                If Len(Trim(ConBay)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "箱 " & ConNo & "  Bay 号 空错误"
                    Frm.ShowDialog()
                    ConBay = Trim(G_SelectCode)
                End If
                If Len(Trim(ConGrossWeight)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "箱 " & ConNo & "  箱毛重 空错误"
                    Frm.ShowDialog()
                    ConGrossWeight = Trim(G_SelectCode)
                End If
                'If Len(Trim(ConOperatorCode)) = 0 Then
                'Dim Frm As New FrmReadTemp
                'G_SelectStr = "箱 " & ConNo & " 箱经营人代码空错误"
                'Frm.ShowDialog()
                'ConOperatorCode = Trim(G_SelectCode)
                'End If
            End If
            '*************************
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********危险品 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******危险品
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "DGS" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "IMD" And Trim(str) <> "IMO" And Trim(str) <> "IMDG" Then                          '*****危险品
                        MsgBox("报文出错 危险品IMD 标识错误 " & str & " ,错误在" & i + 1 & "行!")
                        Exit Sub
                        Mark = 0
                    Else
                        Mark = 1
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If InStr(str, ":") > 0 Then
                            DangerousClass = Mid(Trim(str), 1, InStr(Trim(str), ":") - 1)
                            If Len(Trim(DangerousClass)) = 0 Then
                                Dim Frm As New FrmReadTemp
                                G_SelectStr = "箱 " & ConNo & " 危险品等级空错误"
                                Frm.ShowDialog()
                                DangerousClass = Trim(G_SelectCode)
                            End If
                            DangerousPage = Mid(Trim(str), InStr(Trim(str), ":") + 1)
                            str = FetchStr(txtLine)
                            txtLine = Mid(txtLine, Len(str) + 2)
                            If Len(Trim(str)) > 0 Then
                                DangerousUNNO = Trim(str)
                            End If
                        Else
                            DangerousClass = Trim(str)
                            str = FetchStr(txtLine)
                            'txtLine = Mid(txtLine, Len(str) + 2)
                            If Len(Trim(str)) > 0 Then
                                DangerousUNNO = Trim(str)
                            End If
                        End If
                    End If
                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********危险品FTX 段
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******危险品FTX
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "FTX" Then
                    i99 = 1
                    Mark = 1

                Else
                    Mark = 0

                End If
            End If

            '********************************************************
            If i99 = 0 Then
                Exit Do
            Else
                '*****************写入箱信息
                Dim Size As String = "0"
                Dim Type As String = "0"
                Dim sqlstr As String
                Dim SSSS As String = "0"
                '*****************取箱型
                ds.Reset()
                sqlstr = "select * from Code_Con_Type where  Code_Ship_Type='" & ConType & "'"
                dw = Getdata(sqlstr, ds)
                If dw.Count > 0 Then
                    Size = Mid(Trim(ds.Tables(0).Rows(0).Item("Code_Con_Type")), 1, 2)
                    Type = Mid(Trim(ds.Tables(0).Rows(0).Item("Code_Con_Type")), 3, 2)
                    SSSS = Size
                Else
                    If IsNumeric(Mid(ConType, 1, 2)) Then
                        Size = Mid(ConType, 1, 2)
                    Else
                        'MsgBox("报文箱型尺寸 " & ConType & " 出错,错误在" & i + 1 & "行周围的箱子上!")
                        'Dim Frm As New FrmReadTemp
                        'G_SelectStr = "箱 " & ConNo & "  箱型错误" & ConType
                        'Frm.ShowDialog()
                        'ConType = Trim(G_SelectCode)
                        Size = Mid(ConType, 1, 2)
                    End If
                    SSSS = "0"
                    Type = Mid(ConType, 3, 2)
                End If
                ds.Dispose()
                dw.Dispose()

                '箱皮重 毛重
                If (Len(Trim(ConTareWeight)) <= 1) Then
                    If ConStatus = "E" Then
                        If Trim(Size) = "20" Then
                            ConTareWeight = "2300"
                            ConGrossWeight = "2300"
                        ElseIf Trim(Size) = "40" Then
                            ConTareWeight = "4000"
                            ConGrossWeight = "4000"
                        ElseIf Trim(Size) = "45" Then
                            ConTareWeight = "4600"
                            ConGrossWeight = "4600"
                        Else
                            ConTareWeight = "1200"
                            ConGrossWeight = "1200"
                        End If
                    End If
                End If
                '*********************写入集装箱箱号与船公司箱型代码对照表

                ds.Reset()

                sqlstr = "select * from Code_Type_Ship_Relation where CONTAINER_NO='" & Trim(ConNo) & "' and CODE_SHIP_OWNER='CMA'"
                dw = Updatedata(sqlda, sqlstr, ds)
                If dw.Count = 0 Then
                    Dim row As DataRow
                    row = ds.Tables(0).NewRow()
                    row("CONTAINER_NO") = Trim(ConNo)
                    row("CODE_SHIP_OWNER") = "CMA"
                    row("CODE_CON_TYPE") = ConType
                    ds.Tables(0).Rows.Add(row)
                    sqlda.Update(ds)
                End If
                ds.Dispose()
                dw.Dispose()
                sqlda.Dispose()
                '*********************写入船图临时表信息
                ds.Reset()

                sqlstr = "select * from CON_IMAGE_RECORD where CONTAINER_NO='" & ConNo & "' and BayNo='" & Mid(Trim(ConBay), 2, 6) & "' and Ship_ID=" & Ship_ID
                dw = Updatedata(sqlda, sqlstr, ds)
                If dw.Count = 0 Then
                    Dim row As DataRow
                    row = ds.Tables(0).NewRow()
                    row("Ship_ID") = Ship_ID
                    row("CONTAINER_NO") = Trim(ConNo)
                    row("Size_Con") = CInt(SSSS)
                    '******************未转换的代码
                    row("CodeConType") = ConType
                    row("CodeLoadPort") = LoadPortCode
                    row("CodeUnLoadPort") = unLoadPortCode
                    row("CodeDelivery") = DeliveryPlaceCode
                    '******************
                    row("FULLOREMPTY") = ConStatus
                    row("SEALNO") = ""
                    row("BAYNO") = Mid(Trim(ConBay), 2, 6)
                    row("BLNO") = BLNO
                    row("Mark") = ""
                    row("CODE_CON_KIND") = Type
                    row("CODE_CON_Type") = Size & Type
                    row("CODE_GOODS") = ""
                    row("Goods_Eng") = Mid(CargoDescr, 1, 35)
                    row("Goods_CHA") = Mid(CargoDescr, 1, 35)
                    row("CODE_LOAD_PORT") = LoadPortCode
                    row("LOAD_PORT") = LoadPort
                    row("CODE_UnLOAD_PORT") = unLoadPortCode
                    row("UnLOAD_PORT") = unLoadPort
                    row("CODE_DELIVERY") = DeliveryPlaceCode
                    row("DELIVERY") = DeliveryPlace
                    row("AMOUNT") = 0
                    If Len(Trim(ConGrossWeight)) > 0 Then
                        row("GrossWEIGHT") = CType(ConGrossWeight, Double)
                    End If
                    If Len(Trim(ConTareWeight)) > 0 Then
                        row("TareWeight") = CType(ConTareWeight, Double)
                    End If
                    row("VOLUME") = 0
                    row("TEMPERATURE_UNIT") = ConTempUnit
                    If Len(Trim(ConTempSet)) > 0 Then
                        row("TEMPERATURE_SETTING") = CType(ConTempSet, Double)
                    End If
                    If Len(Trim(ConTempMax)) > 0 Then
                        row("MAX_TEMPERATURE") = CType(ConTempMax, Double)
                    End If
                    If Len(Trim(ConTempMin)) > 0 Then
                        row("MIN_TEMPERATURE") = CType(ConTempMin, Double)
                    End If
                    If Len(Trim(ConOverHeight)) > 0 Then
                        row("OVER_HEIGHT") = CType(ConOverHeight, Double)
                    End If
                    If Len(Trim(ConOverLeft)) > 0 Then
                        row("OVER_LEFT") = CType(ConOverLeft, Double)
                    End If
                    If Len(Trim(ConOverRight)) > 0 Then
                        row("OVER_RIGHT") = CType(ConOverRight, Double)
                    End If
                    If Len(Trim(ConOverFront)) > 0 Then
                        row("OVER_BEFORE") = CType(ConOverFront, Double)
                    End If
                    If Len(Trim(ConOverBack)) > 0 Then
                        row("OVER_BEHIND") = CType(ConOverBack, Double)
                    End If
                    row("DANGER_GRADE") = DangerousClass
                    row("DANGER_PAGENO") = DangerousPage
                    row("DANGER_NO") = DangerousUNNO
                    row("DANGER_MARK") = DangerousLabel
                    row("CODE_MANUFACTURER") = ShipLineCode
                    row("MANUFACTURER") = ShipLine
                    row("CODE_KEEPER") = ConOperatorCode
                    row("KEEPER") = ConOperator
                    row("Demo") = CargoDescr
                    row("ConDemo") = ConDescr
                    If Len(Length) > 0 Then
                        row("Length") = CType(Length, Int32)
                    End If
                    If Len(width) > 0 Then
                        row("width") = CType(width, Int32)
                    End If
                    If Len(Height) > 0 Then
                        row("height") = CType(Height, Int32)
                    End If
                    ds.Tables(0).Rows.Add(row)
                    sqlda.Update(ds)
                End If
                ds.Dispose()
                dw.Dispose()
                sqlda.Dispose()
            End If
            j = j + 1
        Loop
        '*************处理 UNT
        PB.Value = 2000
        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '按行方式读取一行
            s = txtLine
        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("报文出错!处理 UNT,错误在" & i + 1 & "行!")
            Exit Sub
        Else
            If Mark = 1 Then i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) = "UNT" Then
                Mark = 1
                str = FetchStr(txtLine)
                If i <> CInt(str) Then
                    MsgBox("报文行数不对,错误在" & i + 1 & "行!")
                Else

                End If
            Else
                MsgBox("报文读取出错,错误在" & i + 1 & "行!")
                Exit Sub
            End If
        End If
        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '按行方式读取一行
            s = txtLine

        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("报文出错!处理 UNZ,错误在" & i + 2 & "行!")
            Exit Sub
        Else

            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) = "UNZ" Then
                str = FetchStr(txtLine)
                If Trim(str) <> "1" Then
                    MsgBox("报文读取出错,错误在" & i + 2 & "行!")
                    Exit Sub
                Else
                    MsgBox("报文读取正确! 共读到 " & i & " 行")
                End If
            Else
                MsgBox("报文读取出错,错误在" & i + 2 & "行!")
                Exit Sub
            End If
        End If

        sr.Close()
        Me.Close()

    End Sub

    Private Sub ReadZH()
        Dim sr As New StreamReader(txtFile.Text) '打开报文文件
        Dim txtLine As String
        Dim i As Integer = 0 '记录行数
        Dim j As Integer = 0 '取箱信息循环
        Dim i99 As Integer '判断结束
        Dim str As String
        Dim s As String
        Dim Mark As Integer = 0 '**********标识某行是否处理完 1表示处理完 0表示未处理完

        Dim ShipName As String = "" '船名
        Dim ShipCode As String = "" '船名码
        Dim Voyage As String = "" '航次
        Dim ShipLineCode As String = "" '船公司代码
        Dim ShipLine As String = "" '船公司
        Dim ConNo As String = "" '箱号
        Dim ConType As String = "" '箱尺寸类型
        Dim ConStatus As String = "" '箱状态
        Dim ConBay As String = "" '箱贝位号
        Dim ConTempUnit As String = "" '温度计量单位
        Dim ConTempSet As String = "" '设置温度
        Dim ConTempMax As String = "" '冷藏最高温度
        Dim ConTempMin As String = "" '冷藏最低温度
        Dim ConOverFront As String = "" '前超
        Dim ConOverBack As String = "" '后超
        Dim ConOverLeft As String = "" '左超
        Dim ConOverRight As String = "" '右超
        Dim ConOverHeight As String = "" '超高
        Dim ConGrossWeight As String = "" '箱毛重
        Dim ConTareWeight As String = "" '箱皮重
        Dim ConOperatorCode As String = "" '箱经营人代码
        Dim ConOperator As String = "" '箱经营人
        Dim BLNO As String = "" '提单号
        Dim LoadPortCode As String = "" '装货港代码
        Dim LoadPort As String = "" '装货港
        Dim unLoadPortCode As String = "" '卸货港代码
        Dim unLoadPort As String = "" '卸货港
        Dim DeliveryPlaceCode As String = "" '交货地代码
        Dim DeliveryPlace As String = "" '交货地
        Dim DangerousClass As String = "" '危险品分类
        Dim DangerousPage As String = "" '危险品页号
        Dim DangerousUNNO As String = "" '联合国危险品编号
        Dim DangerousLabel As String = "" '危险品标签
        Dim CargoDescr As String = "" '货物描述


        txtLine = Trim(sr.ReadLine()) '按行方式读取一行
        '***********处理记录 00 头记录
        If txtLine = Nothing Then
            MsgBox("报文出错!")
            Exit Sub
        Else
            i = i + 1
            str = EditFetch(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "00" Then
                MsgBox("报文出错 " & str & " ,错误在" & i & "行!")
                Exit Sub
            Else
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) <> "BAPLIE" Then                      '船图标识
                    MsgBox("报文出错 " & str & " ,不是船图报文,错误在" & i & "行!")
                    Exit Sub
                Else
                    str = EditFetch(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "BAYPLAN" Then                '船图标识
                        MsgBox("报文出错 " & str & " ,不是船图报文,错误在" & i & "行!")
                        Exit Sub
                    Else
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Trim(str) <> "9" Then                 '船图标识
                            MsgBox("报文出错 " & str & " ,不是船图报文,错误在" & i & "行!")
                            Exit Sub
                        End If
                    End If
                End If
            End If
        End If
        '*************处理记录 01 其他接收方记录
        txtLine = Trim(sr.ReadLine()) '按行方式读取一行
        s = txtLine
        If txtLine = Nothing Then
            MsgBox("报文出错!处理记录 01 其他接收方记录,错误在" & i & "行!")
            Exit Sub
        Else
            i = i + 1
            str = EditFetch(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) = "01" Then
                Mark = 1
            Else
                Mark = 0
            End If
        End If
        '*************处理记录 10 描述船舶有关的基本数据项目

        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '按行方式读取一行
        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("报文出错!处理记录 10 描述船舶有关的基本数据项目 ,错误在" & i & "行!")
            Exit Sub
        Else
            If Mark = 1 Then i = i + 1
            str = EditFetch(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) = "10" Then
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) > 0 Then
                    ShipCode = str         '船码
                End If
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) > 0 Then
                    ShipName = str '船名
                End If
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) > 0 Then
                    Voyage = str '航次
                End If
            Else
                MsgBox("报文出错 " & str & " ,错误在" & i & "行!")
                Exit Sub
            End If
        End If
        '*************处理记录 11 描述船舶有关的补充信息
        txtLine = Trim(sr.ReadLine())
        If txtLine = Nothing Then
            MsgBox("报文出错!处理记录 11 描述船舶有关的补充信息,错误在" & i & "行!")
            Exit Sub
        Else
            i = i + 1
            str = EditFetch(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) = "11" Then
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) > 0 Then
                    ShipLineCode = str    '船公司(承运人)代码
                End If
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) > 0 Then
                    ShipLine = str       '船公司(承运人)
                End If
            Else
                MsgBox("报文出错 " & str & " ,错误在" & i & "行!")
                Exit Sub
            End If
        End If
        Mark = 1
        '*****************集装箱信息 (开始循环)
        Do While j < 9999
            If j < 2000 Then
                PB.Value = j
            End If
            ConNo = ""
            ConType = ""
            ConStatus = ""
            ConBay = ""  '箱贝位号
            ConTempUnit = ""  '温度计量单位
            ConTempSet = "" '设置温度
            ConTempMax = ""  '冷藏最高温度
            ConTempMin = ""  '冷藏最低温度
            ConOverFront = ""  '前超
            ConOverBack = ""  '后超
            ConOverLeft = ""  '左超
            ConOverRight = "" '右超
            ConOverHeight = ""  '超高
            ConGrossWeight = ""  '箱毛重
            ConTareWeight = ""  '箱皮重
            ConOperatorCode = ""  '箱经营人代码
            ConOperator = ""  '箱经营人
            BLNO = ""  '提单号
            LoadPortCode = ""  '装货港代码
            LoadPort = ""  '装货港
            unLoadPortCode = ""  '卸货港代码
            unLoadPort = ""  '卸货港
            DeliveryPlaceCode = ""  '交货地代码
            DeliveryPlace = ""  '交货地
            DangerousClass = ""  '危险品分类
            DangerousPage = ""  '危险品页号
            DangerousUNNO = ""  '联合国危险品编号
            DangerousLabel = ""  '危险品标签
            CargoDescr = ""  '货物描述

            i99 = 0
            '*************处理记录 50 描述集装箱信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 50 描述集装箱信息,错误在" & i & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "50" Then
                    i99 = 1
                    str = EditFetch(txtLine)                '*******取箱号
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConNo = str
                    Else
                        'MsgBox("报文出错 " & str & " ,错误在" & i & "行!")
                        ConNo = ""
                    End If
                    str = EditFetch(txtLine)                '*******取箱尺寸类型
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConType = str
                    Else
                        'MsgBox("报文出错 " & str & " ,错误在" & i & "行!")
                        ConType = ""
                    End If
                    str = EditFetch(txtLine)                '*******取箱空重
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConStatus = str
                    Else
                        'MsgBox("报文出错 " & str & " ,错误在" & i & "行!")
                        ConStatus = ""
                    End If
                    str = EditFetch(txtLine)                '*******取箱贝位
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConBay = Trim(str)
                        If Len(Trim(ConBay)) = 6 Then
                            ConBay = "0" & ConBay
                        End If
                    Else
                        'MsgBox("报文出错 " & str & " ,错误在" & i & "行!")
                        ConBay = ""
                    End If
                    str = EditFetch(txtLine)                '*******取温度计量单位
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConTempUnit = str
                    End If
                    str = EditFetch(txtLine)                '*******取设置温度
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConTempSet = str
                    End If
                    str = EditFetch(txtLine)                '*******取冷藏最低温度
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConTempMin = str
                    End If
                    str = EditFetch(txtLine)                '*******取冷藏最高温度
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConTempMax = str
                    End If
                    str = EditFetch(txtLine)                '*******取前超
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConOverFront = str
                    End If
                    str = EditFetch(txtLine)                '*******取后超
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConOverBack = str
                    End If
                    str = EditFetch(txtLine)                '*******取左超
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConOverLeft = str
                    End If
                    str = EditFetch(txtLine)                '*******取右超
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConOverRight = str
                    End If
                    str = EditFetch(txtLine)                '*******取超高
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConOverHeight = str
                    End If
                    str = EditFetch(txtLine)                '*******取箱毛重
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConGrossWeight = str
                    Else
                        'MsgBox("报文出错 " & str & " ,错误在" & i & "行!")
                        ConGrossWeight = ""
                    End If
                    str = EditFetch(txtLine)                '*******取箱皮重
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConTareWeight = str
                    End If
                    str = EditFetch(txtLine)                '*******取箱经营人代码
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConOperatorCode = str
                    Else
                        'MsgBox("报文出错 " & str & " ,错误在" & i & "行!")
                        ConOperatorCode = ""
                    End If
                    str = EditFetch(txtLine)                '*******取箱经营人
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConOperator = str
                    Else
                        ConOperator = ConOperatorCode
                    End If
                    Mark = 1
                Else
                    If Mark = 1 Then
                        MsgBox("报文出错 " & str & " ,错误在" & i & "行!")
                        Exit Sub
                    End If

                End If
            End If
            '*************处理记录 51 提单号信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 51 提单号信息,错误在" & i & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "51" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******取提单号
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        BLNO = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************处理记录 52 地点信息

            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine()) '按行方式读取一行
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 52 地点信息,错误在" & i & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "52" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        LoadPortCode = Trim(str) '装货港代码
                    Else
                        'MsgBox("报文出错 " & str & " ,错误在" & i & "行!")
                        LoadPortCode = ""
                    End If
                    str = EditFetch(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        LoadPort = str '装货港
                    End If
                    str = EditFetch(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        unLoadPortCode = Trim(str) '卸货港代码
                    Else
                        'MsgBox("报文出错 " & str & " ,错误在" & i & "行!")
                        unLoadPortCode = ""
                    End If
                    If Len(Trim(txtLine)) > 0 Then
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 Then
                            unLoadPort = str '卸货港
                        End If
                        If Len(Trim(txtLine)) > 0 Then
                            str = EditFetch(txtLine)
                            txtLine = Mid(txtLine, Len(str) + 2)
                            If Len(Trim(str)) > 0 Then
                                DeliveryPlaceCode = Trim(str) '交货地代码
                            End If
                            str = EditFetch(txtLine)
                            txtLine = Mid(txtLine, Len(str) + 2)
                            If Len(Trim(str)) > 0 Then
                                DeliveryPlace = str '交货地
                            End If
                        End If
                    End If
                Else
                    If Mark = 1 Then
                        MsgBox("报文出错 处理记录 52 地点信息" & str & " ,错误在" & i & "行!")
                        Exit Sub
                    End If
                    Mark = 0
                End If
            End If
            '*************处理记录 53 可选卸货港信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错!处理记录 53 可选卸货港信息 ,错误在" & i & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "53" Then
                    i99 = 1
                    Mark = 1
                Else
                    Mark = 0
                End If
            End If
            '*************************校验
            If i99 = 1 Then
                If Len(Trim(ConNo)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "报文  箱号空错误,错误在" & i & "行!"
                    Frm.ShowDialog()
                    ConNo = Trim(G_SelectCode)
                End If
                If Len(Trim(ConType)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "箱 " & ConNo & " 箱型代码空错误"
                    Frm.ShowDialog()
                    ConType = Trim(G_SelectCode)
                End If
                If Len(Trim(ConStatus)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "箱 " & ConNo & " 箱空重空错误"
                    Frm.ShowDialog()
                    ConStatus = Trim(G_SelectCode)
                End If
                If Len(Trim(LoadPortCode)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "箱 " & ConNo & " 装货港代码空错误"
                    Frm.ShowDialog()
                    LoadPortCode = Trim(G_SelectCode)
                End If
                If Len(Trim(unLoadPortCode)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "箱 " & ConNo & " 卸货港代码空错误"
                    Frm.ShowDialog()
                    unLoadPortCode = Trim(G_SelectCode)
                End If
                If Len(Trim(ConBay)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "箱 " & ConNo & "  Bay 号 空错误"
                    Frm.ShowDialog()
                    ConBay = Trim(G_SelectCode)
                End If
                If Len(Trim(ConGrossWeight)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "箱 " & ConNo & "  箱毛重 空错误"
                    Frm.ShowDialog()
                    ConGrossWeight = Trim(G_SelectCode)
                End If
                
                'If Len(Trim(ConOperatorCode)) = 0 Then
                '    Dim Frm As New FrmReadTemp()
                '    G_SelectStr = "箱 " & ConNo & " 箱经营人代码空错误"
                '    Frm.ShowDialog()
                '    ConOperatorCode = Trim(G_SelectCode)
                'End If


            End If
            '*************************
            '*************处理记录 54 危险品信息

            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine()) '按行方式读取一行
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 54 危险品信息,错误在" & i & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "54" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        DangerousClass = str '危险品分类
                    Else
                        'MsgBox("报文出错 " & str & " ,错误在" & i & "行!")
                        Dim Frm As New FrmReadTemp
                        G_SelectStr = "箱 " & ConNo & " 危险品等级代码空错误"
                        Frm.ShowDialog()
                        DangerousClass = Trim(G_SelectCode)
                    End If
                    str = EditFetch(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        DangerousPage = str '危险品页号
                    End If
                    str = EditFetch(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        DangerousUNNO = str '联合国危险品编号
                    End If
                    str = EditFetch(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        DangerousLabel = str '危险品标签
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************处理记录 55 货物描述
            Dim i55 As Integer = 0
            Do While i55 < 9
                If Mark = 1 Then
                    txtLine = Trim(sr.ReadLine()) '按行方式读取一行
                    s = txtLine
                Else
                    txtLine = s
                End If
                If txtLine = Nothing Then
                    MsgBox("报文出错!")
                    Exit Sub
                Else
                    If Mark = 1 Then i = i + 1
                    str = EditFetch(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) = "55" Then
                        i99 = 1
                        str = EditFetch(txtLine) '货类代码
                        txtLine = Mid(txtLine, Len(str) + 2)

                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 Then
                            CargoDescr = CargoDescr & str '货物描述
                        End If
                        Mark = 1
                    Else
                        Mark = 0
                    End If
                End If
                If Mark = 0 Then Exit Do
            Loop
            If i99 = 0 Then
                Exit Do
            Else
                '*****************写入箱信息
                Dim Size As String = "0"
                Dim Type As String = "0"
                Dim SSSS As String = "0"
                Dim sqlstr As String
                '*****************取箱型
                ds.Reset()
                sqlstr = "select * from Code_Con_Type where  Code_Ship_Type='" & ConType & "'"
                dw = Getdata(sqlstr, ds)
                If dw.Count > 0 Then
                    Size = Mid(Trim(ds.Tables(0).Rows(0).Item("Code_Con_Type")), 1, 2)
                    Type = Mid(Trim(ds.Tables(0).Rows(0).Item("Code_Con_Type")), 3, 2)
                    SSSS = Size
                Else
                    If IsNumeric(Mid(ConType, 1, 2)) Then
                        Size = Mid(ConType, 1, 2)
                    Else
                        'MsgBox("报文箱型尺寸 " & ConType & " 出错,错误在" & i + 1 & "行周围的箱子上!")
                        'Dim Frm As New FrmReadTemp()
                        'G_SelectStr = "箱 " & ConNo & " 箱型代码错误" & ConType
                        'Frm.ShowDialog()
                        'ConType = Trim(G_SelectCode)
                        Size = Mid(ConType, 1, 2)
                    End If
                    SSSS = "0"
                    Type = Mid(ConType, 3, 2)
                End If

                '箱皮重 毛重
                If (Len(Trim(ConTareWeight)) <= 1) Then
                    If ConStatus = "E" Then
                        If Trim(Size) = "20" Then
                            ConTareWeight = "2300"
                            ConGrossWeight = "2300"
                        ElseIf Trim(Size) = "40" Then
                            ConTareWeight = "4000"
                            ConGrossWeight = "4000"
                        ElseIf Trim(Size) = "45" Then
                            ConTareWeight = "4600"
                            ConGrossWeight = "4600"
                        Else
                            ConTareWeight = "1200"
                            ConGrossWeight = "1200"
                        End If
                    End If
                End If

                '*********************写入集装箱箱号与船公司箱型代码对照表
                If ShipLineCode = "CSC" Then
                    ds.Reset()

                    sqlstr = "select * from Code_Type_Ship_Relation where CONTAINER_NO='" & Trim(ConNo) & "' and CODE_SHIP_OWNER='" & ShipLineCode & "'"
                    dw = Updatedata(sqlda, sqlstr, ds)
                    If dw.Count = 0 Then
                        Dim row As DataRow
                        row = ds.Tables(0).NewRow()
                        row("CONTAINER_NO") = Trim(ConNo)
                        row("CODE_SHIP_OWNER") = ShipLineCode
                        row("CODE_CON_TYPE") = ConType
                        ds.Tables(0).Rows.Add(row)
                        sqlda.Update(ds)
                    End If
                End If
                '*********************写入船图临时表信息
                ds.Reset()

                sqlstr = "select * from CON_IMAGE_RECORD where CONTAINER_NO='" & ConNo & "' and BayNo='" & Mid(Trim(ConBay), 2, 6) & "' and Ship_ID=" & Ship_ID
                dw = Updatedata(sqlda, sqlstr, ds)
                If dw.Count = 0 Then
                    Dim row As DataRow
                    row = ds.Tables(0).NewRow()
                    row("Ship_ID") = Ship_ID
                    row("CONTAINER_NO") = Trim(ConNo)
                    '******************未转换的代码
                    row("CodeConType") = ConType
                    row("CodeLoadPort") = LoadPortCode
                    row("CodeUnLoadPort") = unLoadPortCode
                    row("CodeDelivery") = DeliveryPlaceCode
                    '******************
                    row("Size_Con") = CInt(SSSS)
                    row("FULLOREMPTY") = ConStatus
                    row("SEALNO") = ""
                    row("BAYNO") = Mid(Trim(ConBay), 2, 6)
                    row("BLNO") = BLNO
                    row("Mark") = ""
                    row("CODE_CON_KIND") = Type
                    row("CODE_CON_Type") = Size & Type
                    row("CODE_GOODS") = ""
                    row("Goods_Eng") = IIf(Len(CargoDescr) > 17, Mid(CargoDescr, 1, 17), CargoDescr)
                    row("Goods_CHA") = IIf(Len(CargoDescr) > 17, Mid(CargoDescr, 1, 17), CargoDescr)
                    row("CODE_LOAD_PORT") = LoadPortCode
                    row("LOAD_PORT") = LoadPort
                    row("CODE_UnLOAD_PORT") = unLoadPortCode
                    row("UnLOAD_PORT") = unLoadPort
                    row("CODE_DELIVERY") = DeliveryPlaceCode
                    row("DELIVERY") = DeliveryPlace
                    row("AMOUNT") = 0
                    If Len(Trim(ConGrossWeight)) > 0 Then
                        row("GrossWEIGHT") = CType(ConGrossWeight, Double)
                    End If
                    If Len(Trim(ConTareWeight)) > 0 Then
                        row("TareWeight") = CType(ConTareWeight, Double)
                    End If
                    row("VOLUME") = 0
                    row("TEMPERATURE_UNIT") = ConTempUnit
                    If Len(Trim(ConTempSet)) > 0 Then
                        row("TEMPERATURE_SETTING") = CType(ConTempSet, Double)
                    End If
                    If Len(Trim(ConTempMax)) > 0 Then
                        row("MAX_TEMPERATURE") = CType(ConTempMax, Double)
                    End If
                    If Len(Trim(ConTempMin)) > 0 Then
                        row("MIN_TEMPERATURE") = CType(ConTempMin, Double)
                    End If
                    If Len(Trim(ConOverHeight)) > 0 Then
                        row("OVER_HEIGHT") = CType(ConOverHeight, Double)
                    End If
                    If Len(Trim(ConOverLeft)) > 0 Then
                        row("OVER_LEFT") = CType(ConOverLeft, Double)
                    End If
                    If Len(Trim(ConOverRight)) > 0 Then
                        row("OVER_RIGHT") = CType(ConOverRight, Double)
                    End If
                    If Len(Trim(ConOverFront)) > 0 Then
                        row("OVER_BEFORE") = CType(ConOverFront, Double)
                    End If
                    If Len(Trim(ConOverBack)) > 0 Then
                        row("OVER_BEHIND") = CType(ConOverBack, Double)
                    End If
                    row("DANGER_GRADE") = DangerousClass
                    row("DANGER_PAGENO") = DangerousPage
                    row("DANGER_NO") = DangerousUNNO
                    row("DANGER_MARK") = DangerousLabel
                    row("CODE_MANUFACTURER") = ShipLineCode
                    row("MANUFACTURER") = ShipLine
                    row("CODE_KEEPER") = ConOperatorCode
                    row("KEEPER") = ConOperator
                    row("Demo") = CargoDescr

                    ds.Tables(0).Rows.Add(row)
                    sqlda.Update(ds)
                End If
            End If
            j = j + 1
        Loop
        PB.Value = 2000
        '*************处理 99
        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '按行方式读取一行
            s = txtLine
        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("报文出错 处理 99!错误在" & i & "行!")
            Exit Sub
        Else
            If Mark = 1 Then i = i + 1
            str = EditFetch(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) = "99" Then
                str = EditFetch(txtLine)
                If i <> CInt(str) Then
                    MsgBox("报文行数不对,错误在" & i & "行!")
                Else
                    MsgBox("报文读取正确! 共读到 " & i & " 行")
                End If
            Else
                MsgBox("报文读取出错,错误在" & i & "行!")
                Exit Sub
            End If
        End If
        sr.Close()
        Me.Close()
    End Sub

    Private Sub ReadZY()
        Dim sr As New StreamReader(txtFile.Text) '打开报文文件
        Dim txtLine As String
        Dim i As Integer = 0 '记录行数
        Dim j As Integer = 0 '取箱信息循环
        Dim i99 As Integer '判断结束
        Dim str As String
        Dim s As String
        Dim Mark As Integer = 0 '**********标识某行是否处理完 1表示处理完 0表示未处理完

        Dim ShipName As String = "" '船名
        Dim ShipCode As String = "" '船名码
        Dim Voyage As String = "" '航次
        Dim ShipLineCode As String = "" '船公司代码
        Dim ShipLine As String = "" '船公司
        Dim ConNo As String = "" '箱号
        Dim ConType As String = "" '箱尺寸类型
        Dim ConStatus As String = "" '箱状态
        Dim ConBay As String = "" '箱贝位号
        Dim ConTempUnit As String = "" '温度计量单位
        Dim ConTempSet As String = "" '设置温度
        Dim ConTempMax As String = "" '冷藏最高温度
        Dim ConTempMin As String = "" '冷藏最低温度
        Dim ConOverFront As String = "" '前超
        Dim ConOverBack As String = "" '后超
        Dim ConOverLeft As String = "" '左超
        Dim ConOverRight As String = "" '右超
        Dim ConOverHeight As String = "" '超高
        Dim ConGrossWeight As String = "" '箱毛重
        Dim ConTareWeight As String = "" '箱皮重
        Dim ConOperatorCode As String = "" '箱经营人代码
        Dim ConOperator As String = "" '箱经营人
        Dim BLNO As String = "" '提单号
        Dim LoadPortCode As String = "" '装货港代码
        Dim LoadPort As String = "" '装货港
        Dim unLoadPortCode As String = "" '卸货港代码
        Dim unLoadPort As String = "" '卸货港
        Dim DeliveryPlaceCode As String = "" '交货地代码
        Dim DeliveryPlace As String = "" '交货地
        Dim Danger As String = "" '危险品标识
        Dim DangerousClass As String = "" '危险品分类
        Dim DangerousPage As String = "" '危险品页号
        Dim DangerousUNNO As String = "" '联合国危险品编号
        Dim DangerousLabel As String = "" '危险品标签
        Dim CargoDescr As String = "" '货物描述


        txtLine = Trim(sr.ReadLine()) '按行方式读取一行
        '***********处理记录 00 头记录
        If txtLine = Nothing Then
            MsgBox("报文出错!")
            Exit Sub
        Else
            i = i + 1
            str = Mid(txtLine, 1, 2)
            If Trim(str) <> "00" Then
                MsgBox("报文出错 " & str & " ,错误在" & i & "行!")
                Exit Sub
            Else
                str = Mid(txtLine, 3, 3)
                If Trim(str) <> "BAY" Then                      '船图标识
                    MsgBox("报文出错 " & str & " ,不是船图报文,错误在" & i & "行!")
                    Exit Sub
                Else
                    str = Mid(txtLine, 6, 20)
                    If Trim(str) <> "BAYPLAN" And Trim(str) <> "BAY PLAN" Then                '船图标识
                        MsgBox("报文出错 " & str & " ,不是船图报文,错误在" & i & "行!")
                        Exit Sub
                    Else
                        str = Mid(txtLine, 117, 3)
                        If Trim(str) <> "1.2" Then                 '船图标识
                            MsgBox("报文出错 " & str & " ,不是船图报文,错误在" & i & "行!")
                            Exit Sub
                        End If
                    End If
                End If
            End If
        End If
        '*************处理记录 11 其他接收方记录
        txtLine = Trim(sr.ReadLine()) '按行方式读取一行
        If txtLine = Nothing Then
            MsgBox("报文出错!")
            Exit Sub
        Else
            i = i + 1
            str = Mid(txtLine, 1, 2)
            If Trim(str) <> "11" Then
                MsgBox("报文出错 " & str & " ,不是船图报文,错误在" & i & "行!")
                Exit Sub
            Else
                str = Mid(txtLine, 11, 6) '*********船码
                If Len(Trim(str)) > 0 Then
                    ShipCode = Trim(str)
                End If
                str = Mid(txtLine, 17, 20) '*********船名
                If Len(Trim(str)) > 0 Then
                    ShipName = Trim(str)
                End If
                str = Mid(txtLine, 37, 5) '***********航次
                If Len(Trim(str)) > 0 Then
                    Voyage = Trim(str)
                End If
            End If
        End If
        Mark = 1
        '*****************集装箱信息 (开始循环)
        Do While j < 19999
            If j < 2000 Then
                PB.Value = j
            End If
            ConNo = ""
            ConType = ""
            ConStatus = ""
            ConBay = ""  '箱贝位号
            ConTempUnit = ""  '温度计量单位
            ConTempSet = "" '设置温度
            ConTempMax = ""  '冷藏最高温度
            ConTempMin = ""  '冷藏最低温度
            ConOverFront = ""  '前超
            ConOverBack = ""  '后超
            ConOverLeft = ""  '左超
            ConOverRight = "" '右超
            ConOverHeight = ""  '超高
            ConGrossWeight = ""  '箱毛重
            ConTareWeight = ""  '箱皮重
            ConOperatorCode = ""  '箱经营人代码
            ConOperator = ""  '箱经营人
            BLNO = ""  '提单号
            LoadPortCode = ""  '装货港代码
            LoadPort = ""  '装货港
            unLoadPortCode = ""  '卸货港代码
            unLoadPort = ""  '卸货港
            DeliveryPlaceCode = ""  '交货地代码
            DeliveryPlace = ""  '交货地
            DangerousClass = ""  '危险品分类
            DangerousPage = ""  '危险品页号
            DangerousUNNO = ""  '联合国危险品编号
            DangerousLabel = ""  '危险品标签
            CargoDescr = ""  '货物描述

            i99 = 0
            '*************处理记录 51 描述集装箱信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错 记录 51 ,错误在" & i & "行周围!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = Mid(txtLine, 1, 2)
                If Trim(str) = "51" Then
                    i99 = 1
                    str = Mid(txtLine, 3, 11)              '*******取箱号

                    If Len(Trim(str)) > 0 Then
                        ConNo = Trim(str)
                    Else
                        ConNo = ""
                        'MsgBox("报文出错 " & str & " ,错误在" & i & "行!")
                    End If
                    str = Mid(txtLine, 14, 4)              '*******取箱尺寸类型
                    If Len(Trim(str)) > 0 Then
                        ConType = Trim(str)
                    Else
                        ConType = ""
                        'MsgBox("报文出错 " & str & " ,错误在" & i & "行!")

                    End If
                    str = Mid(txtLine, 18, 1)              '*******取箱空重
                    If Len(Trim(str)) > 0 Then
                        ConStatus = Trim(str)
                    Else
                        ConStatus = ""
                        'MsgBox("报文出错 " & str & " ,错误在" & i & "行!")

                    End If
                    str = Mid(txtLine, 19, 1)              '*******取提单标识
                    If Len(Trim(str)) > 0 Then
                        If Trim(str) = "2" Then
                            str = Mid(txtLine, 20, 16)     '*******取提单号
                            If Len(Trim(str)) > 0 Then
                                BLNO = Trim(str)
                            End If
                        End If
                    End If
                    str = Mid(txtLine, 36, 5)               '******装货港
                    If Len(Trim(str)) > 0 Then
                        LoadPortCode = Trim(str)
                    Else
                        LoadPortCode = ""
                        'MsgBox("报文出错 " & str & " ,错误在" & i & "行!")

                    End If
                    str = Mid(txtLine, 41, 5)               '******卸货港
                    If Len(Trim(str)) > 0 Then
                        unLoadPortCode = Trim(str)
                    Else
                        unLoadPortCode = ""
                        'MsgBox("报文出错 " & str & " ,错误在" & i & "行!")

                    End If
                    str = Mid(txtLine, 56, 5)               '******交货港
                    If Len(Trim(str)) > 0 Then
                        DeliveryPlaceCode = Trim(str)
                    End If
                    str = Mid(txtLine, 61, 7)               '*******取箱贝位
                    If Len(Trim(str)) > 0 Then
                        ConBay = Trim(str)
                        If Len(ConBay) = 6 Then
                            ConBay = "0" & ConBay
                        End If

                    Else
                        ConBay = ""
                        'MsgBox("报文出错 " & str & " ,错误在" & i & "行!")

                    End If
                    str = Mid(txtLine, 68, 1)              '*******取温度计量单位
                    If Len(Trim(str)) > 0 Then
                        ConTempUnit = Trim(str)
                    End If

                    str = Mid(txtLine, 69, 4)              '*******取冷藏最高温度
                    If Len(Trim(str)) > 0 Then
                        ConTempMax = Convert.ToString(Convert.ToDouble(Trim(str)) / 10).Trim()
                    End If

                    str = Mid(txtLine, 73, 4)              '*******取冷藏最低温度
                    If Len(Trim(str)) > 0 Then
                        ConTempMin = Convert.ToString(Convert.ToDouble(Trim(str)) / 10).Trim()
                    End If
                    str = Mid(txtLine, 77, 1)              '危险品标识
                    If Len(Trim(str)) > 0 Then
                        Danger = Trim(str)
                    End If

                    str = Mid(txtLine, 78, 3)              '*******取前超
                    If Len(Trim(str)) > 0 Then
                        ConOverFront = Trim(str)
                    End If
                    str = Mid(txtLine, 81, 3)                   '*******取后超
                    If Len(Trim(str)) > 0 Then
                        ConOverBack = Trim(str)
                    End If
                    str = Mid(txtLine, 84, 3)                 '*******取左超
                    If Len(Trim(str)) > 0 Then
                        ConOverLeft = Trim(str)
                    End If
                    str = Mid(txtLine, 87, 3)                '*******取右超
                    If Len(Trim(str)) > 0 Then
                        ConOverRight = Trim(str)
                    End If
                    str = Mid(txtLine, 90, 3)                 '*******取超高
                    If Len(Trim(str)) > 0 Then
                        ConOverHeight = Trim(str)
                    End If
                    str = Mid(txtLine, 105, 6)                '*******取箱毛重
                    If Len(Trim(str)) > 0 Then
                        ConGrossWeight = Trim(str)
                    Else
                        ConGrossWeight = ""
                        'MsgBox("报文出错 " & str & " ,错误在" & i & "行!")

                    End If

                    Mark = 1
                Else
                    If Mark = 1 Then
                        MsgBox("报文出错 记录 51 ,错误在" & i & "行!")
                        Exit Sub
                    End If

                End If
            End If
            '*************************校验
            If i99 = 1 Then
                If Len(Trim(ConNo)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "报文  箱号空错误,错误在" & i & "行!"
                    Frm.ShowDialog()
                    ConNo = Trim(G_SelectCode)
                End If
                If Len(Trim(ConType)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "箱 " & ConNo & " 箱型代码空错误"
                    Frm.ShowDialog()
                    ConType = Trim(G_SelectCode)
                End If
                If Len(Trim(ConStatus)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "箱 " & ConNo & " 箱空重空错误"
                    Frm.ShowDialog()
                    ConStatus = Trim(G_SelectCode)
                End If
                If Len(Trim(LoadPortCode)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "箱 " & ConNo & " 装货港代码空错误"
                    Frm.ShowDialog()
                    LoadPortCode = Trim(G_SelectCode)
                End If
                If Len(Trim(unLoadPortCode)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "箱 " & ConNo & " 卸货港代码空错误"
                    Frm.ShowDialog()
                    unLoadPortCode = Trim(G_SelectCode)
                End If
                If Len(Trim(ConBay)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "箱 " & ConNo & "  Bay 号 空错误"
                    Frm.ShowDialog()
                    ConBay = Trim(G_SelectCode)
                End If
                If Len(Trim(ConGrossWeight)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "箱 " & ConNo & "  箱毛重 空错误"
                    Frm.ShowDialog()
                    ConGrossWeight = Trim(G_SelectCode)
                End If
            End If
            '*************************
            '*************处理记录 52 危险品信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = Mid(txtLine, 1, 2)
                If Trim(str) = "52" Then
                    i99 = 1
                    Mark = 1

                    str = Mid(txtLine, 3, 11)              '*******取箱号
                    If Len(Trim(str)) > 0 Then
                        If ConNo <> str Then
                            MsgBox("报文出错 处理记录 52 危险品信息 取箱号" & str & " ,错误在" & i & "行!")
                            Exit Sub
                        End If
                    End If
                    str = Mid(txtLine, 19, 7)
                    If Len(Trim(str)) > 0 Then
                        DangerousClass = Trim(str)
                    Else
                        DangerousClass = ""
                        'MsgBox("报文出错 " & str & " ,错误在" & i & "行!")
                        Dim Frm As New FrmReadTemp
                        G_SelectStr = "箱 " & ConNo & "  危险品等级 空错误"
                        Frm.ShowDialog()
                        DangerousClass = Trim(G_SelectCode)
                    End If
                    str = Mid(txtLine, 26, 7)
                    If Len(Trim(str)) > 0 Then
                        DangerousPage = Trim(str)
                    End If
                    str = Mid(txtLine, 33, 4)
                    If Len(Trim(str)) > 0 Then
                        DangerousUNNO = Trim(str)
                    End If
                    str = Mid(txtLine, 37)
                    If Len(Trim(str)) > 0 Then
                        DangerousLabel = IIf(Len(Trim(str)) > 32, Mid(Trim(str), 1, 32), Trim(str))
                    End If

                Else
                    Mark = 0
                End If
            End If
            '*************处理记录 53 备注信息

            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine()) '按行方式读取一行
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = Mid(txtLine, 1, 2)
                If Trim(str) = "53" Then
                    i99 = 1
                    Mark = 1

                Else
                    Mark = 0
                End If
            End If

            If i99 = 0 Then
                Exit Do
            Else
                '*****************写入箱信息(箱规范)
                Dim Size As String = "0"
                Dim Type As String = "0"
                Dim SSSS As String = "0"
                Dim sqlstr As String
                '*****************取箱规范
                ds.Reset()
                sqlstr = "select * from Code_Con_Type where  Code_Ship_Type='" & ConType & "'"
                dw = Getdata(sqlstr, ds)
                If dw.Count > 0 Then
                    Size = Mid(Trim(ds.Tables(0).Rows(0).Item("Code_Con_Type")), 1, 2)
                    Type = Mid(Trim(ds.Tables(0).Rows(0).Item("Code_Con_Type")), 3, 2)
                    SSSS = Size
                Else
                    If IsNumeric(Mid(ConType, 1, 2)) Then
                        Size = Mid(ConType, 1, 2)
                    Else
                        'MsgBox("报文箱型尺寸 " & ConType & " 出错,错误在" & i + 1 & "行周围的箱子上!")
                        'Dim Frm As New FrmReadTemp
                        'G_SelectStr = "箱 " & ConNo & "  箱型错误" & ConType
                        'Frm.ShowDialog()
                        'ConType = Trim(G_SelectCode)
                        Size = Mid(ConType, 1, 2)
                    End If
                    SSSS = "0"
                    Type = Mid(ConType, 3, 2)
                End If
                '箱皮重 毛重
                If (Len(Trim(ConTareWeight)) <= 1) Then
                    If ConStatus = "E" Then
                        If Trim(Size) = "20" Then
                            ConTareWeight = "2300"
                            ConGrossWeight = "2300"
                        ElseIf Trim(Size) = "40" Then
                            ConTareWeight = "4000"
                            ConGrossWeight = "4000"
                        ElseIf Trim(Size) = "45" Then
                            ConTareWeight = "4600"
                            ConGrossWeight = "4600"
                        Else
                            ConTareWeight = "1200"
                            ConGrossWeight = "1200"
                        End If
                    End If
                End If
                '*********************写入集装箱箱号与船公司箱型代码对照表

                ds.Reset()

                sqlstr = "select * from Code_Type_Ship_Relation where CONTAINER_NO='" & Trim(ConNo) & "' and CODE_SHIP_OWNER='COSC'"
                dw = Updatedata(sqlda, sqlstr, ds)
                If dw.Count = 0 Then
                    Dim row As DataRow
                    row = ds.Tables(0).NewRow()
                    row("CONTAINER_NO") = Trim(ConNo)
                    row("CODE_SHIP_OWNER") = "COSC"
                    row("CODE_CON_TYPE") = ConType
                    ds.Tables(0).Rows.Add(row)
                    sqlda.Update(ds)
                End If

                '*********************写入船图临时表信息
                ds.Reset()

                sqlstr = "select * from CON_IMAGE_RECORD where CONTAINER_NO='" & ConNo & "' and BayNo='" & Mid(Trim(ConBay), 2, 6) & "' and Ship_ID=" & Ship_ID
                dw = Updatedata(sqlda, sqlstr, ds)
                If dw.Count = 0 Then
                    Dim row As DataRow
                    row = ds.Tables(0).NewRow()
                    row("Ship_ID") = Ship_ID
                    row("CONTAINER_NO") = Trim(ConNo)
                    row("Size_Con") = CInt(SSSS)
                    '******************未转换的代码
                    row("CodeConType") = ConType
                    row("CodeLoadPort") = LoadPortCode
                    row("CodeUnLoadPort") = unLoadPortCode
                    row("CodeDelivery") = DeliveryPlaceCode
                    '******************
                    row("FULLOREMPTY") = ConStatus
                    row("SEALNO") = ""
                    row("BAYNO") = Mid(Trim(ConBay), 2, 6)
                    row("BLNO") = BLNO
                    row("Mark") = ""
                    row("CODE_CON_KIND") = Type
                    row("CODE_CON_Type") = Size & Type
                    row("CODE_GOODS") = ""
                    row("Goods_Eng") = IIf(Len(CargoDescr) > 17, Mid(CargoDescr, 1, 17), CargoDescr)
                    row("Goods_CHA") = IIf(Len(CargoDescr) > 17, Mid(CargoDescr, 1, 17), CargoDescr)
                    row("CODE_LOAD_PORT") = LoadPortCode
                    row("LOAD_PORT") = LoadPort
                    row("CODE_UnLOAD_PORT") = unLoadPortCode
                    row("UnLOAD_PORT") = unLoadPort
                    row("CODE_DELIVERY") = DeliveryPlaceCode
                    row("DELIVERY") = DeliveryPlace
                    row("AMOUNT") = 0
                    If Len(Trim(ConGrossWeight)) > 0 Then
                        row("GrossWEIGHT") = CType(ConGrossWeight, Double)
                    End If
                    If Len(Trim(ConTareWeight)) > 0 Then
                        row("TareWeight") = CType(ConTareWeight, Double)
                    End If
                    row("VOLUME") = 0
                    row("TEMPERATURE_UNIT") = ConTempUnit
                    If Len(Trim(ConTempSet)) > 0 Then
                        row("TEMPERATURE_SETTING") = CType(ConTempSet, Double)
                    End If
                    If Len(Trim(ConTempMax)) > 0 Then
                        row("MAX_TEMPERATURE") = CType(ConTempMax, Double)
                    End If
                    If Len(Trim(ConTempMin)) > 0 Then
                        row("MIN_TEMPERATURE") = CType(ConTempMin, Double)
                    End If
                    If Len(Trim(ConOverHeight)) > 0 Then
                        row("OVER_HEIGHT") = CType(ConOverHeight, Double)
                    End If
                    If Len(Trim(ConOverLeft)) > 0 Then
                        row("OVER_LEFT") = CType(ConOverLeft, Double)
                    End If
                    If Len(Trim(ConOverRight)) > 0 Then
                        row("OVER_RIGHT") = CType(ConOverRight, Double)
                    End If
                    If Len(Trim(ConOverFront)) > 0 Then
                        row("OVER_BEFORE") = CType(ConOverFront, Double)
                    End If
                    If Len(Trim(ConOverBack)) > 0 Then
                        row("OVER_BEHIND") = CType(ConOverBack, Double)
                    End If
                    row("DANGER_GRADE") = DangerousClass
                    row("DANGER_PAGENO") = Trim(DangerousPage)
                    row("DANGER_NO") = DangerousUNNO
                    row("DANGER_MARK") = DangerousLabel
                    row("CODE_MANUFACTURER") = ShipLineCode
                    row("MANUFACTURER") = ShipLine
                    row("CODE_KEEPER") = ConOperatorCode
                    row("KEEPER") = ConOperator
                    row("Demo") = CargoDescr
                    ds.Tables(0).Rows.Add(row)
                    sqlda.Update(ds)
                End If
            End If
            j = j + 1
        Loop
        '*************处理 99
        PB.Value = 2000
        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '按行方式读取一行
            s = txtLine
        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("报文出错!")
            Exit Sub
        Else
            If Mark = 1 Then i = i + 1
            str = Mid(txtLine, 1, 2)
            If Trim(str) = "99" Then
                str = Mid(txtLine, 3, 3)
                If str <> "BAY" Then
                    MsgBox("报文读取出错,错误在" & i & "行!")
                    Exit Sub
                End If
                str = Mid(txtLine, 6, 6)
                If i <> CInt(str) Then
                    MsgBox("报文行数不对,错误在" & i & "行!")
                Else
                    MsgBox("报文读取正确! 共读到 " & i & " 行")
                End If
            Else
                MsgBox("报文读取出错,错误在" & i & "行!")
                Exit Sub
            End If
        End If
        sr.Close()
        Me.Close()
    End Sub


    Private Function FindPort(ByVal Port As String, ByVal Company As String) As String
        Dim dsPort As New DataSet
        Dim dwPort As New DataView
        Dim str As String
        str = "select * from Code_Port_Relation where Code_Port_Relation='" & Trim(Port) & "' and Code_SHIPOWNER='" & Company & "'"
        dwPort = Getdata(str, dsPort)
        If dwPort.Count > 0 Then
            FindPort = dsPort.Tables(0).Rows(0).Item("Code_Port")
        Else
            FindPort = Port
        End If
    End Function
    Private Sub FrmReadMail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim pathstr As String
        Dim filepath As String
        Dim str As String
        pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
        pathstr = substr(pathstr)
        Try
            filepath = pathstr + "EDIINI.INI"
            Dim sr As New StreamReader(filepath) '打开报文文件
            txtFile.Text = sr.ReadLine()
            txtFile.Text = sr.ReadLine()

            sr.Close()
        Catch
        End Try
    End Sub

End Class
