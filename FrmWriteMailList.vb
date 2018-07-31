Imports System.Web.Mail
Imports System.IO
Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FrmWriteMailList
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet
    Dim dw As New DataView
    Dim sqlstr As String
    Dim BackUpFile As String
#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写 dispose 以清理组件列表。
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

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
    Friend WithEvents btRead As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LSign As System.Windows.Forms.TextBox
    Friend WithEvents PB As System.Windows.Forms.ProgressBar
    Friend WithEvents LEndTime As System.Windows.Forms.Label
    Friend WithEvents LNextPort As System.Windows.Forms.Label
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents rbHF As System.Windows.Forms.RadioButton
    Friend WithEvents rbDF As System.Windows.Forms.RadioButton
    Friend WithEvents rbUN As System.Windows.Forms.RadioButton
    Friend WithEvents rbZY As System.Windows.Forms.RadioButton
    Friend WithEvents rbZH As System.Windows.Forms.RadioButton
    Friend WithEvents rbJT As System.Windows.Forms.RadioButton
    Friend WithEvents LShipOwner As System.Windows.Forms.Label
    Friend WithEvents LShipCompany As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbEmail As System.Windows.Forms.ComboBox
    Friend WithEvents txtShipCode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LJinChu As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LVoyage As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LEnglish As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LChina As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btWriteNew As System.Windows.Forms.Button
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents OpenFile As System.Windows.Forms.Button
    Friend WithEvents Send As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btRead = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.LSign = New System.Windows.Forms.TextBox
        Me.PB = New System.Windows.Forms.ProgressBar
        Me.LEndTime = New System.Windows.Forms.Label
        Me.LNextPort = New System.Windows.Forms.Label
        Me.GB = New System.Windows.Forms.GroupBox
        Me.rbHF = New System.Windows.Forms.RadioButton
        Me.rbDF = New System.Windows.Forms.RadioButton
        Me.rbUN = New System.Windows.Forms.RadioButton
        Me.rbZY = New System.Windows.Forms.RadioButton
        Me.rbZH = New System.Windows.Forms.RadioButton
        Me.rbJT = New System.Windows.Forms.RadioButton
        Me.LShipOwner = New System.Windows.Forms.Label
        Me.LShipCompany = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbEmail = New System.Windows.Forms.ComboBox
        Me.txtShipCode = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.LJinChu = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LVoyage = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.LEnglish = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.LChina = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btWriteNew = New System.Windows.Forms.Button
        Me.txtFile = New System.Windows.Forms.TextBox
        Me.OpenFile = New System.Windows.Forms.Button
        Me.Send = New System.Windows.Forms.Button
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.GB.SuspendLayout()
        Me.SuspendLayout()
        '
        'btRead
        '
        Me.btRead.Location = New System.Drawing.Point(6, 126)
        Me.btRead.Name = "btRead"
        Me.btRead.Size = New System.Drawing.Size(70, 22)
        Me.btRead.TabIndex = 66
        Me.btRead.Text = "查看报文"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(96, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 14)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "呼号"
        '
        'LSign
        '
        Me.LSign.Location = New System.Drawing.Point(128, 40)
        Me.LSign.Name = "LSign"
        Me.LSign.Size = New System.Drawing.Size(54, 21)
        Me.LSign.TabIndex = 64
        '
        'PB
        '
        Me.PB.Location = New System.Drawing.Point(4, 182)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(366, 18)
        Me.PB.TabIndex = 63
        '
        'LEndTime
        '
        Me.LEndTime.Location = New System.Drawing.Point(316, 88)
        Me.LEndTime.Name = "LEndTime"
        Me.LEndTime.Size = New System.Drawing.Size(8, 8)
        Me.LEndTime.TabIndex = 62
        Me.LEndTime.Visible = False
        '
        'LNextPort
        '
        Me.LNextPort.Location = New System.Drawing.Point(358, 88)
        Me.LNextPort.Name = "LNextPort"
        Me.LNextPort.Size = New System.Drawing.Size(8, 8)
        Me.LNextPort.TabIndex = 61
        Me.LNextPort.Visible = False
        '
        'GB
        '
        Me.GB.Controls.Add(Me.rbHF)
        Me.GB.Controls.Add(Me.rbDF)
        Me.GB.Controls.Add(Me.rbUN)
        Me.GB.Controls.Add(Me.rbZY)
        Me.GB.Controls.Add(Me.rbZH)
        Me.GB.Controls.Add(Me.rbJT)
        Me.GB.Location = New System.Drawing.Point(82, 100)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(288, 74)
        Me.GB.TabIndex = 60
        Me.GB.TabStop = False
        Me.GB.Text = "报文类型"
        '
        'rbHF
        '
        Me.rbHF.Location = New System.Drawing.Point(212, 52)
        Me.rbHF.Name = "rbHF"
        Me.rbHF.Size = New System.Drawing.Size(72, 18)
        Me.rbHF.TabIndex = 5
        Me.rbHF.Text = "海丰"
        '
        'rbDF
        '
        Me.rbDF.Location = New System.Drawing.Point(104, 52)
        Me.rbDF.Name = "rbDF"
        Me.rbDF.Size = New System.Drawing.Size(106, 18)
        Me.rbDF.TabIndex = 4
        Me.rbDF.Text = "达飞(911-1.5)"
        '
        'rbUN
        '
        Me.rbUN.Location = New System.Drawing.Point(8, 52)
        Me.rbUN.Name = "rbUN"
        Me.rbUN.Size = New System.Drawing.Size(94, 18)
        Me.rbUN.TabIndex = 3
        Me.rbUN.Text = "UN(95B)"
        '
        'rbZY
        '
        Me.rbZY.Location = New System.Drawing.Point(212, 26)
        Me.rbZY.Name = "rbZY"
        Me.rbZY.Size = New System.Drawing.Size(72, 20)
        Me.rbZY.TabIndex = 2
        Me.rbZY.Text = "中远"
        '
        'rbZH
        '
        Me.rbZH.Location = New System.Drawing.Point(104, 26)
        Me.rbZH.Name = "rbZH"
        Me.rbZH.Size = New System.Drawing.Size(106, 20)
        Me.rbZH.TabIndex = 1
        Me.rbZH.Text = "中海"
        '
        'rbJT
        '
        Me.rbJT.Checked = True
        Me.rbJT.Location = New System.Drawing.Point(8, 26)
        Me.rbJT.Name = "rbJT"
        Me.rbJT.Size = New System.Drawing.Size(94, 20)
        Me.rbJT.TabIndex = 0
        Me.rbJT.TabStop = True
        Me.rbJT.Text = "交通部平台"
        '
        'LShipOwner
        '
        Me.LShipOwner.Location = New System.Drawing.Point(332, 88)
        Me.LShipOwner.Name = "LShipOwner"
        Me.LShipOwner.Size = New System.Drawing.Size(8, 8)
        Me.LShipOwner.TabIndex = 58
        Me.LShipOwner.Visible = False
        '
        'LShipCompany
        '
        Me.LShipCompany.Location = New System.Drawing.Point(346, 88)
        Me.LShipCompany.Name = "LShipCompany"
        Me.LShipCompany.Size = New System.Drawing.Size(6, 8)
        Me.LShipCompany.TabIndex = 57
        Me.LShipCompany.Visible = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(186, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "收文用户"
        '
        'cbEmail
        '
        Me.cbEmail.Location = New System.Drawing.Point(242, 40)
        Me.cbEmail.Name = "cbEmail"
        Me.cbEmail.Size = New System.Drawing.Size(130, 20)
        Me.cbEmail.TabIndex = 55
        '
        'txtShipCode
        '
        Me.txtShipCode.Location = New System.Drawing.Point(34, 40)
        Me.txtShipCode.Name = "txtShipCode"
        Me.txtShipCode.Size = New System.Drawing.Size(60, 21)
        Me.txtShipCode.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(4, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 14)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "船码"
        '
        'LJinChu
        '
        Me.LJinChu.Location = New System.Drawing.Point(242, 24)
        Me.LJinChu.Name = "LJinChu"
        Me.LJinChu.Size = New System.Drawing.Size(128, 14)
        Me.LJinChu.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(186, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 14)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "进出口"
        '
        'LVoyage
        '
        Me.LVoyage.Location = New System.Drawing.Point(60, 24)
        Me.LVoyage.Name = "LVoyage"
        Me.LVoyage.Size = New System.Drawing.Size(124, 14)
        Me.LVoyage.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(4, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 14)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "航次"
        '
        'LEnglish
        '
        Me.LEnglish.Location = New System.Drawing.Point(242, 4)
        Me.LEnglish.Name = "LEnglish"
        Me.LEnglish.Size = New System.Drawing.Size(128, 16)
        Me.LEnglish.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(186, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "英文船名"
        '
        'LChina
        '
        Me.LChina.Location = New System.Drawing.Point(60, 4)
        Me.LChina.Name = "LChina"
        Me.LChina.Size = New System.Drawing.Size(124, 16)
        Me.LChina.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "中文船名"
        '
        'btWriteNew
        '
        Me.btWriteNew.Location = New System.Drawing.Point(6, 98)
        Me.btWriteNew.Name = "btWriteNew"
        Me.btWriteNew.Size = New System.Drawing.Size(70, 24)
        Me.btWriteNew.TabIndex = 44
        Me.btWriteNew.Text = "生成报文"
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(4, 64)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(304, 21)
        Me.txtFile.TabIndex = 43
        '
        'OpenFile
        '
        Me.OpenFile.Location = New System.Drawing.Point(310, 66)
        Me.OpenFile.Name = "OpenFile"
        Me.OpenFile.Size = New System.Drawing.Size(62, 20)
        Me.OpenFile.TabIndex = 42
        Me.OpenFile.Text = "打开文件"
        '
        'Send
        '
        Me.Send.Location = New System.Drawing.Point(6, 152)
        Me.Send.Name = "Send"
        Me.Send.Size = New System.Drawing.Size(70, 24)
        Me.Send.TabIndex = 41
        Me.Send.Text = "发送报文"
        '
        'FrmWriteMailList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(374, 203)
        Me.Controls.Add(Me.btRead)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LSign)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.LEndTime)
        Me.Controls.Add(Me.LNextPort)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.LShipOwner)
        Me.Controls.Add(Me.LShipCompany)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbEmail)
        Me.Controls.Add(Me.txtShipCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LJinChu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LVoyage)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LEnglish)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LChina)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btWriteNew)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.OpenFile)
        Me.Controls.Add(Me.Send)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmWriteMailList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "舱单报文生成"
        Me.GB.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub FrmWriteMailList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds1 As New DataSet
        Dim dw1 As New DataView
        Dim PathStr As String
        Dim FilePath As String

        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        Try
            FilePath = PathStr + "EDIINI.INI"
            Dim sr As New StreamReader(FilePath) '打开报文文件
            txtFile.Text = sr.ReadLine()
            BackUpFile = sr.ReadLine()
            BackUpFile = sr.ReadLine()
            sr.Close()
        Catch
        End Try

        sqlstr = "select * from EMail_Cust order by ID"
        dw1 = Getdata(sqlstr, ds1)
        cbEmail.DataSource = ds1.Tables(0).DefaultView
        cbEmail.DisplayMember = "E_Name"
        cbEmail.ValueMember = "E_Code"
    End Sub

    Private Sub Send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Send.Click
        Dim ds1 As New DataSet
        Dim dw1 As New DataView
        Dim ds2 As New DataSet
        Dim dw2 As New DataView
        sqlstr = "select * from EMail_Cust where E_Code='" & Trim(cbEmail.SelectedValue) & "'"
        dw1 = Getdata(sqlstr, ds1)
        sqlstr = "select * from EMail_Cust where E_Code='COSTACO'"
        dw2 = Getdata(sqlstr, ds2)

        Call Sendmail(Trim(ds1.Tables(0).Rows(0).Item("E_Mail")), Trim(ds2.Tables(0).Rows(0).Item("E_Mail")))

    End Sub
    Private Sub Sendmail(ByVal Sendto As String, ByVal From As String)
        On Error GoTo Err
        Dim Mail As New MailMessage
        Dim FileName As String
        Dim Subject As String
        Dim OldMark As String '*************捣箱标志
        Dim ds1 As New DataSet
        Dim dw1 As New DataView
        Dim str As String
        Dim i As Integer = 0
        Dim j As Integer = 0
        sqlstr = "select Ship_ID,Container_No,BayNo,OldBayNo,Code_Load_Port,Code_UnLoad_Port from Con_Image where Ship_ID=" & Ship_ID & " and code_load_Port NOT LIKE '%LYG%'and code_unload_Port NOT LIKE '%LYG%'and OLDBAYNO IS NOT NULL and len(OLDBAYNO)>0"
        dw1 = Getdata(sqlstr, ds1)
        If dw1.Count > 0 Then
            OldMark = "捣箱标志:" & Chr(13) & Chr(10) & "箱号         现贝位号 原贝位号" & Chr(13) & Chr(10)
            Do While i < dw1.Count
                OldMark = OldMark & dw1(i)(1) & " " & dw1(i)(2) & "    " & dw1(i)(3) & " " & Chr(13) & Chr(10)
                i = i + 1
            Loop
        End If
        If UCase(Mid(Trim(txtFile.Text), Len(Trim(txtFile.Text)) - 2, 3)) <> "TXT" Then
            
            FileName = txtFile.Text & "C" & UCase(txtShipCode.Text) & LVoyage.Text & "Sum.txt"
            Subject = "IFCSUM ShipName: " & LEnglish.Text & " VON:" & LVoyage.Text

        Else
            FileName = txtFile.Text
            
            Subject = "IFCSUM ShipName: " & LEnglish.Text & " VON:" & LVoyage.Text

        End If
        'Add a File Attachment if specified
        If FileName <> "" Then
            Mail.Attachments.Add(New MailAttachment(FileName))
        End If
        'setup some e-mail information
        sqlstr = "select * from EMail_Cust where E_Code='" & Trim(cbEmail.SelectedValue) & "'"
        dw1 = Getdata(sqlstr, ds1)
        If dw1.Count > 0 Then i = ds1.Tables(0).Rows(0).Item("ID")
        With Mail
            .From = From
            .To = Sendto
            ds1.Reset()
            sqlstr = "select * from EMail_Cust_detail where EMail_ID=" & i
            dw1 = Getdata(sqlstr, ds1)

            If dw1.Count > 0 Then
                .Cc = dw1(j)(3)
                j = j + 1
                Do While j < dw1.Count
                    .Cc = ";" & dw1(j)(3)
                    j = j + 1
                Loop
            End If

            .Subject = Subject
            .Body = cbEmail.Text & " 你好！" & Chr(13) & Chr(10) & Subject & Chr(13) & Chr(10) & OldMark & Chr(13) & Chr(10) & " COSTACO(LYGWL)" & Chr(13) & Chr(10) & CType(Now, String)
            .Priority = MailPriority.High
        End With
        'send then e-mail message

        'SmtpMail.SmtpServer = MailServer

        SmtpMail.Send(Mail)
        MsgBox("报文已发送，谢谢使用!")
        File.Copy(FileName, BackUpFile & Mid(FileName, Len(substr(FileName)) + 1), True)
        File.Delete(FileName)
        Exit Sub
Err:
        MsgBox(Err.Description)
    End Sub

    Private Sub OpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFile.Click
        OpenFileDialog.AddExtension = True
        OpenFileDialog.DefaultExt = "*.*"
        OpenFileDialog.InitialDirectory = txtFile.Text
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
                se = Mid(str, j, 1)
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

    Private Sub btWriteNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btWriteNew.Click
        If txtShipCode.Text.Trim().Length() > 0 Then
            If rbZH.Checked = True Or rbJT.Checked = True Then
                Call WriteZH()
            End If
        Else
            MsgBox("船码不能为空!!!")
        End If

    End Sub

    Private Sub WriteZH()
        On Error GoTo Err
        '******************************************中海
        Dim txtLine As String
        Dim i As Integer = 0 '记录行数
        Dim j As Integer = 0 '取箱信息循环
        Dim k As Integer = 0
        Dim str As String
        Dim s As String
        Dim dwt As New DataView
        Dim dst As New DataSet
        Dim strFile As String
        Dim ConType As String = "" '箱尺寸类型
        Dim ConOverFront As String = "" '前超
        Dim ConOverBack As String = "" '后超
        Dim ConOverLeft As String = "" '左超
        Dim ConOverRight As String = "" '右超
        Dim ConOverHeight As String = "" '超高
        Dim ConTareWeight As String = "" '箱皮重

        strFile = txtFile.Text & "C" & UCase(txtShipCode.Text) & LVoyage.Text & ".txt"
        
        File.Delete(strFile)
        Dim sw As New StreamWriter(strFile, FileMode.OpenOrCreate, System.Text.Encoding.Default())  '打开报文文件
        '**************写00行
        txtLine = "00:IFCSUM:MANIFEST:9:LYGWL:" & Trim(cbEmail.SelectedValue) & ":" & Trim(CType(Year(Now), String))
        s = Mid("0" & Trim(CType(Month(Now), String)), Len("0" & Trim(CType(Month(Now), String))) - 1, 2)
        txtLine = txtLine & s
        s = Mid("0" & Trim(CType(Day(Now), String)), Len("0" & Trim(CType(Day(Now), String))) - 1, 2)
        txtLine = txtLine & s
        s = Mid("0" & Trim(CType(Hour(Now), String)), Len("0" & Trim(CType(Hour(Now), String))) - 1, 2)
        txtLine = txtLine & s
        s = Mid("0" & Trim(CType(Minute(Now), String)), Len("0" & Trim(CType(Minute(Now), String))) - 1, 2)
        txtLine = txtLine & s & "'"
        sw.WriteLine(txtLine)
        '************写10
        If LEndTime.Text.ToString().Length() > 0 Then
            s = Trim(CType(Year(CType(LEndTime.Text.ToString(), Date)), String))
            s = s & Mid("0" & Trim(CType(Month(CType(LEndTime.Text.ToString(), Date)), String)), Len("0" & Trim(CType(Month(CType(LEndTime.Text.ToString(), Date)), String))) - 1, 2)

            s = s & Mid("0" & Trim(CType(Day(CType(LEndTime.Text.ToString(), Date)), String)), Len("0" & Trim(CType(Day(CType(LEndTime.Text.ToString(), Date)), String))) - 1, 2)
        Else
            s = ""
        End If
        txtLine = "10:" & UCase(Trim(txtShipCode.Text)) & ":" & UCase(Trim(LEnglish.Text)) & "::" & LVoyage.Text & "::::" & s & ":CNLYG:CHINA LYG PORT::'"
        sw.WriteLine(txtLine)
        '************写11
        txtLine = "11:" & UCase(LShipOwner.Text) & ":" & UCase(LShipOwner.Text) & "'"
        sw.WriteLine(txtLine)
        i = 3

        sqlstr = "select DISTINCT BLNO,LOAD_DATE,AMOUNT,PACK,GROSS_WEIGHT,NETWEIGHT,SIZE_MEASURE,GOODS_ENG,EMPTY_MARK,TEMPERATURE,MARK,DANGER_GRADE,DANGER_NO,DANGER_PAGENO,DANGER_MARK,CODE_LOAD_PORT,CODE_UNLOAD_PORT,CODE_PLACE_RECEIVE,REFRIGERATE_TEMPERATURE  from VIEW_CON_HATCH_CARGO where Ship_ID=" & Ship_ID

        dw = Getdata(sqlstr, ds)

        PB.Maximum = dw.Count
        PB.Value = 0

        Do While j < dw.Count
            PB.Value = j
            '********************************12
            txtLine = "12:" & UCase(ds.Tables(0).Rows(j).Item("BLNO")) & "::::::" & UCase(ds.Tables(0).Rows(j).Item("CODE_LOAD_PORT")) & ":::"
            If UCase(ds.Tables(0).Rows(j).Item("EMPTY_MARK")) = "E" Then
                If LEndTime.Text.ToString().Length() > 0 Then
                    txtLine = txtLine & Trim(CType(Year(ds.Tables(0).Rows(j - 1).Item("LOAD_DATE")), String))
                    s = Mid("0" & Trim(CType(Month(ds.Tables(0).Rows(j - 1).Item("LOAD_DATE")), String)), Len("0" & Trim(CType(Month(ds.Tables(0).Rows(j - 1).Item("LOAD_DATE")), String))) - 1, 2)
                    txtLine = txtLine & s
                    s = Mid("0" & Trim(CType(Day(ds.Tables(0).Rows(j - 1).Item("LOAD_DATE")), String)), Len("0" & Trim(CType(Day(ds.Tables(0).Rows(j - 1).Item("LOAD_DATE")), String))) - 1, 2)
                    txtLine = txtLine & s
                    txtLine = txtLine & ":Y'"
                Else
                    txtLine = txtLine & ":Y'"
                End If

            Else
                If LEndTime.Text.ToString().Length() > 0 Then
                    txtLine = txtLine & Trim(CType(Year(ds.Tables(0).Rows(j - 1).Item("LOAD_DATE")), String))
                    s = Mid("0" & Trim(CType(Month(ds.Tables(0).Rows(j - 1).Item("LOAD_DATE")), String)), Len("0" & Trim(CType(Month(ds.Tables(0).Rows(j - 1).Item("LOAD_DATE")), String))) - 1, 2)
                    txtLine = txtLine & s
                    s = Mid("0" & Trim(CType(Day(ds.Tables(0).Rows(j - 1).Item("LOAD_DATE")), String)), Len("0" & Trim(CType(Day(ds.Tables(0).Rows(j - 1).Item("LOAD_DATE")), String))) - 1, 2)
                    txtLine = txtLine & s
                    txtLine = txtLine & ":N'"
                Else
                    txtLine = txtLine & ":N'"
                End If
            End If
            sw.WriteLine(txtLine)
            i = i + 1
            '********************************13
            txtLine = "13:" & UCase(ds.Tables(0).Rows(j).Item("CODE_UnLOAD_PORT")) & "::" & UCase(ds.Tables(0).Rows(j).Item("CODE_PLACE_RECEIVE")) & "'"
            sw.WriteLine(txtLine)
            i = i + 1
            '********************************41
            If UCase(ds.Tables(0).Rows(j).Item("EMPTY_MARK")) = "E" Then
                txtLine = "41:0::0:0'"
            Else
                txtLine = "41:1::" & Trim(ds.Tables(0).Rows(j).Item("AMOUNT")) & "::" & Trim(ds.Tables(0).Rows(j).Item("PACK")) & ":"
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("GROSS_WEIGHT")) Then
                    txtLine = txtLine & Trim(CType(ds.Tables(0).Rows(j).Item("GROSS_WEIGHT"), Single))
                End If
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("NETWEIGHT")) Then
                    txtLine = txtLine & ":" & Trim(CType(ds.Tables(0).Rows(j).Item("NETWEIGHT"), Single)) & ":"
                Else
                    txtLine = txtLine & "::"
                End If
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("SIZE_MEASURE")) Then
                    txtLine = txtLine & Trim(CType(ds.Tables(0).Rows(j).Item("SIZE_MEASURE"), Single)) & "'"
                Else
                    txtLine = txtLine & "'"
                End If
            End If
            sw.WriteLine(txtLine)
            i = i + 1
            '********************************43
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("DANGER_GRADE")) Then
                If Len(Trim(ds.Tables(0).Rows(j).Item("DANGER_GRADE"))) > 0 Then
                    txtLine = "43:" & Trim(ds.Tables(0).Rows(j).Item("DANGER_GRADE")) & ":"
                    If Not IsDBNull(ds.Tables(0).Rows(j).Item("DANGER_PAGENO")) Then
                        txtLine = txtLine & Trim(CType(ds.Tables(0).Rows(j).Item("DANGER_PAGENO"), String)) & ":"
                    Else
                        txtLine = txtLine & ":"
                    End If
                    If Not IsDBNull(ds.Tables(0).Rows(j).Item("DANGER_NO")) Then
                        txtLine = txtLine & Trim(ds.Tables(0).Rows(j).Item("DANGER_NO")) & ":"
                    Else
                        txtLine = txtLine & ":"
                    End If
                    If Not IsDBNull(ds.Tables(0).Rows(j).Item("DANGER_MARK")) Then
                        txtLine = txtLine & Trim(ds.Tables(0).Rows(j).Item("DANGER_MARK"))
                    Else
                        txtLine = txtLine & ""
                    End If
                    txtLine = txtLine & "'"
                    sw.WriteLine(txtLine)
                    i = i + 1
                End If
            End If
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("TEMPERATURE")) Then
                If Len(Trim(ds.Tables(0).Rows(j).Item("TEMPERATURE"))) > 0 Then
                    txtLine = "43:" & Trim(ds.Tables(0).Rows(j).Item("TEMPERATURE")) & ":"
                    If Not IsDBNull(ds.Tables(0).Rows(j).Item("REFRIGERATE_TEMPERATURE")) Then
                        If Len(Trim(ds.Tables(0).Rows(j).Item("REFRIGERATE_TEMPERATURE"))) > 0 Then
                            txtLine = txtLine & Trim(ds.Tables(0).Rows(j).Item("REFRIGERATE_TEMPERATURE"))
                        End If
                    End If
                    txtLine = txtLine & "'"
                    sw.WriteLine(txtLine)
                    i = i + 1
                End If
            End If
            '********************************44
            If UCase(ds.Tables(0).Rows(j).Item("EMPTY_MARK")) = "E" Then
            Else
                txtLine = "44:" & Trim(ds.Tables(0).Rows(j).Item("MARK")) & "'"
                sw.WriteLine(txtLine)
                i = i + 1
                txtLine = "47:" & Trim(ds.Tables(0).Rows(j).Item("GOODS_ENG")) & "'"
                sw.WriteLine(txtLine)
                i = i + 1
            End If
            '********************************51
            dst.Reset()

            str = "select CONTAINER_NO,SEALNO,FULLOREMPTY,SIZE_CON,CONTAINER_TYPE,ConAMOUNT,WEIGHT,VOLUME,BAYNO,CON_WEIGHT,OVER_Height,OVER_LEFT,OVER_RIGHT,OVER_BEFORE,OVER_BEHIND from VIEW_CON_HATCH_CARGO where Ship_ID=" & Ship_ID & " and BLNO='" & Trim(ds.Tables(0).Rows(j).Item("BLNO")) & "'"
            dwt = Getdata(str, dst)

            If dwt.Count > 0 Then
                k = 0
                Do While k < dwt.Count
                    ConType = "" '箱尺寸类型
                    ConOverFront = ""  '前超
                    ConOverBack = ""  '后超
                    ConOverLeft = ""  '左超
                    ConOverRight = ""  '右超
                    ConOverHeight = ""  '超高
                    ConTareWeight = ""  '箱皮重
                    If Not IsDBNull(dst.Tables(0).Rows(k).Item("SIZE_CON")) Then
                        ConType = Trim(dst.Tables(0).Rows(k).Item("SIZE_CON")) & Trim(dst.Tables(0).Rows(k).Item("CONTAINER_TYPE"))
                    End If
                    If Not IsDBNull(dst.Tables(0).Rows(0).Item("CON_WEIGHT")) Then
                        ConTareWeight = Trim(CType(dst.Tables(0).Rows(k).Item("CON_WEIGHT"), String))
                    End If
                    If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_Height")) Then
                        ConOverHeight = Trim(CType(dst.Tables(0).Rows(k).Item("OVER_Height"), String))
                    End If
                    If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_Left")) Then
                        ConOverLeft = Trim(CType(dst.Tables(0).Rows(k).Item("OVER_Left"), String))
                    End If
                    If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_Right")) Then
                        ConOverRight = Trim(CType(dst.Tables(0).Rows(k).Item("OVER_Right"), String))
                    End If
                    If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_BEFORE")) Then
                        ConOverFront = Trim(CType(dst.Tables(0).Rows(k).Item("OVER_BEFORE"), String))
                    End If
                    If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_BEHIND")) Then
                        ConOverBack = Trim(CType(dst.Tables(0).Rows(k).Item("OVER_BEHIND"), String))
                    End If
                    txtLine = "51:1:" & Trim(dst.Tables(0).Rows(k).Item("CONTAINER_NO")) & ":" & Trim(dst.Tables(0).Rows(k).Item("SEALNO")) & ":" & ConType & ":"
                    txtLine = txtLine & Trim(dst.Tables(0).Rows(k).Item("FULLOREMPTY")) & ":"
                    If Not IsDBNull(dst.Tables(0).Rows(k).Item("ConAMOUNT")) Then
                        If Len(Trim(dst.Tables(0).Rows(k).Item("ConAMOUNT"))) > 0 Then
                            txtLine = txtLine & Trim(dst.Tables(0).Rows(k).Item("ConAMOUNT")) & ":"
                        Else
                            txtLine = txtLine & ":"
                        End If
                    Else
                        txtLine = txtLine & ":"
                    End If
                    If Not IsDBNull(dst.Tables(0).Rows(k).Item("WEIGHT")) Then
                        If Len(Trim(dst.Tables(0).Rows(k).Item("WEIGHT"))) > 0 Then
                            txtLine = txtLine & Trim(CType(dst.Tables(0).Rows(k).Item("WEIGHT"), Single)) & ":"
                        Else
                            txtLine = txtLine & ":"
                        End If
                    Else
                        txtLine = txtLine & ":"
                    End If
                    If Not IsDBNull(dst.Tables(0).Rows(k).Item("CON_WEIGHT")) Then
                        If Len(Trim(dst.Tables(0).Rows(k).Item("CON_WEIGHT"))) > 0 Then
                            txtLine = txtLine & Trim(CType(dst.Tables(0).Rows(k).Item("CON_WEIGHT"), Single)) & ":"
                        Else
                            txtLine = txtLine & ":"
                        End If
                    Else
                        txtLine = txtLine & ":"
                    End If
                    If Not IsDBNull(dst.Tables(0).Rows(k).Item("VOLUME")) Then
                        If Len(Trim(dst.Tables(0).Rows(k).Item("VOLUME"))) > 0 Then
                            txtLine = txtLine & Trim(CType(dst.Tables(0).Rows(k).Item("VOLUME"), Single)) & ":"
                        Else
                            txtLine = txtLine & ":"
                        End If
                    Else
                        txtLine = txtLine & ":"
                    End If
                    txtLine = txtLine & ConOverFront & ":" & ConOverBack & ":" & ConOverLeft & ":" & ConOverRight & ":" & ConOverHeight & ":"
                    If Not IsDBNull(dst.Tables(0).Rows(k).Item("BAYNO")) Then
                        txtLine = txtLine & "0" & Trim(dst.Tables(0).Rows(k).Item("BAYNO")) & "'"
                    Else
                        txtLine = txtLine & "'"
                    End If
                    sw.WriteLine(txtLine)
                    i = i + 1
                    k = k + 1
                Loop
            End If


            j = j + 1
        Loop
        txtLine = "99:" & Trim(CType(i + 1, String)) & "'"
        sw.WriteLine(txtLine)
        sw.Close()
        MsgBox("生成完成,谢谢! 报文共 " & Trim(CType(i + 1, String)) & " 行 共 " & j & " 个提单!")
        Exit Sub
Err:
        MsgBox("提单 " & UCase(ds.Tables(0).Rows(j).Item("BLNO")) & " " & Err.Description)
    End Sub
    Private Function FindPort(ByVal Port As String, ByVal Company As String) As String
        Dim dsPort As New DataSet
        Dim dwPort As New DataView
        Dim str As String
        str = "select * from Code_Port_Relation where Code_Port='" & Port & "' and Code_SHIPOWNER='" & Company & "'"
        dwPort = Getdata(str, dsPort)
        If dwPort.Count > 0 Then
            FindPort = dsPort.Tables(0).Rows(0).Item("Code_Port_Relation") & ":" & dsPort.Tables(0).Rows(0).Item("Port_Relation")
        Else
            FindPort = Port & ":"
        End If
    End Function

    Private Sub btRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRead.Click
        Dim PathStr As String
        Dim FilePath As String
        Dim strFile As String

        strFile = txtFile.Text & "C" & UCase(txtShipCode.Text) & LVoyage.Text & ".txt"

        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        Try
            FilePath = PathStr + "NOTEPAD.EXE"
            Shell(FilePath & " " & strFile, AppWinStyle.NormalFocus, True)
        Catch
        End Try
    End Sub
End Class
