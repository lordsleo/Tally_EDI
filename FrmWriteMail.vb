Imports System.Web.Mail
Imports System.IO
Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FrmWriteMail
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim dw As New DataView()
    Dim sqlstr As String
    Dim BackUpFile As String
    Dim ConTypeOwner As String
    Dim PortOwner As String

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
    Friend WithEvents LJinChu As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LVoyage As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LEnglish As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LChina As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents OpenFile As System.Windows.Forms.Button
    Friend WithEvents Send As System.Windows.Forms.Button
    Friend WithEvents btWriteNew As System.Windows.Forms.Button
    Friend WithEvents txtShipCode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents cbEmail As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LShipCompany As System.Windows.Forms.Label
    Friend WithEvents LShipOwner As System.Windows.Forms.Label
    Friend WithEvents cbSummary As System.Windows.Forms.CheckBox
    Friend WithEvents GB As System.Windows.Forms.GroupBox
    Friend WithEvents rbDF As System.Windows.Forms.RadioButton
    Friend WithEvents rbZY As System.Windows.Forms.RadioButton
    Friend WithEvents rbJT As System.Windows.Forms.RadioButton
    Friend WithEvents LNextPort As System.Windows.Forms.Label
    Friend WithEvents LEndTime As System.Windows.Forms.Label
    Friend WithEvents PB As System.Windows.Forms.ProgressBar
    Friend WithEvents LSign As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btRead As System.Windows.Forms.Button
    Friend WithEvents rbWYDF As System.Windows.Forms.RadioButton
    Friend WithEvents rbWYZH As System.Windows.Forms.RadioButton
    Friend WithEvents rbKDYH As System.Windows.Forms.RadioButton
    Friend WithEvents rbTWYM As System.Windows.Forms.RadioButton
    Friend WithEvents rbXZ As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCodeOperate As System.Windows.Forms.ComboBox
    Friend WithEvents rb20 As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
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
        Me.txtShipCode = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.cbEmail = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.LShipCompany = New System.Windows.Forms.Label
        Me.LShipOwner = New System.Windows.Forms.Label
        Me.cbSummary = New System.Windows.Forms.CheckBox
        Me.GB = New System.Windows.Forms.GroupBox
        Me.rb20 = New System.Windows.Forms.RadioButton
        Me.rbXZ = New System.Windows.Forms.RadioButton
        Me.rbTWYM = New System.Windows.Forms.RadioButton
        Me.rbWYDF = New System.Windows.Forms.RadioButton
        Me.rbDF = New System.Windows.Forms.RadioButton
        Me.rbKDYH = New System.Windows.Forms.RadioButton
        Me.rbZY = New System.Windows.Forms.RadioButton
        Me.rbWYZH = New System.Windows.Forms.RadioButton
        Me.rbJT = New System.Windows.Forms.RadioButton
        Me.LNextPort = New System.Windows.Forms.Label
        Me.LEndTime = New System.Windows.Forms.Label
        Me.PB = New System.Windows.Forms.ProgressBar
        Me.LSign = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.btRead = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCodeOperate = New System.Windows.Forms.ComboBox
        Me.GB.SuspendLayout()
        Me.SuspendLayout()
        '
        'LJinChu
        '
        Me.LJinChu.Location = New System.Drawing.Point(240, 22)
        Me.LJinChu.Name = "LJinChu"
        Me.LJinChu.Size = New System.Drawing.Size(128, 14)
        Me.LJinChu.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(184, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 14)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "进出口"
        '
        'LVoyage
        '
        Me.LVoyage.Location = New System.Drawing.Point(58, 22)
        Me.LVoyage.Name = "LVoyage"
        Me.LVoyage.Size = New System.Drawing.Size(124, 14)
        Me.LVoyage.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(2, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 14)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "航次"
        '
        'LEnglish
        '
        Me.LEnglish.Location = New System.Drawing.Point(240, 2)
        Me.LEnglish.Name = "LEnglish"
        Me.LEnglish.Size = New System.Drawing.Size(128, 16)
        Me.LEnglish.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(184, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "英文船名"
        '
        'LChina
        '
        Me.LChina.Location = New System.Drawing.Point(58, 2)
        Me.LChina.Name = "LChina"
        Me.LChina.Size = New System.Drawing.Size(124, 16)
        Me.LChina.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "中文船名"
        '
        'btWriteNew
        '
        Me.btWriteNew.Location = New System.Drawing.Point(4, 110)
        Me.btWriteNew.Name = "btWriteNew"
        Me.btWriteNew.Size = New System.Drawing.Size(70, 24)
        Me.btWriteNew.TabIndex = 17
        Me.btWriteNew.Text = "生成报文"
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(2, 62)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(304, 21)
        Me.txtFile.TabIndex = 16
        Me.txtFile.Text = ""
        '
        'OpenFile
        '
        Me.OpenFile.Location = New System.Drawing.Point(308, 62)
        Me.OpenFile.Name = "OpenFile"
        Me.OpenFile.Size = New System.Drawing.Size(62, 22)
        Me.OpenFile.TabIndex = 15
        Me.OpenFile.Text = "打开文件"
        '
        'Send
        '
        Me.Send.Location = New System.Drawing.Point(4, 164)
        Me.Send.Name = "Send"
        Me.Send.Size = New System.Drawing.Size(70, 24)
        Me.Send.TabIndex = 14
        Me.Send.Text = "发送报文"
        '
        'txtShipCode
        '
        Me.txtShipCode.Location = New System.Drawing.Point(32, 38)
        Me.txtShipCode.Name = "txtShipCode"
        Me.txtShipCode.Size = New System.Drawing.Size(60, 21)
        Me.txtShipCode.TabIndex = 27
        Me.txtShipCode.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(2, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 14)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "船码"
        '
        'cbEmail
        '
        Me.cbEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmail.Location = New System.Drawing.Point(240, 38)
        Me.cbEmail.Name = "cbEmail"
        Me.cbEmail.Size = New System.Drawing.Size(130, 20)
        Me.cbEmail.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(184, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 16)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "收文用户"
        '
        'LShipCompany
        '
        Me.LShipCompany.Location = New System.Drawing.Point(230, 92)
        Me.LShipCompany.Name = "LShipCompany"
        Me.LShipCompany.Size = New System.Drawing.Size(3, 8)
        Me.LShipCompany.TabIndex = 30
        Me.LShipCompany.Visible = False
        '
        'LShipOwner
        '
        Me.LShipOwner.Location = New System.Drawing.Point(216, 92)
        Me.LShipOwner.Name = "LShipOwner"
        Me.LShipOwner.Size = New System.Drawing.Size(10, 8)
        Me.LShipOwner.TabIndex = 31
        Me.LShipOwner.Visible = False
        '
        'cbSummary
        '
        Me.cbSummary.Location = New System.Drawing.Point(80, 88)
        Me.cbSummary.Name = "cbSummary"
        Me.cbSummary.Size = New System.Drawing.Size(50, 16)
        Me.cbSummary.TabIndex = 32
        Me.cbSummary.Text = "汇总"
        '
        'GB
        '
        Me.GB.Controls.Add(Me.rb20)
        Me.GB.Controls.Add(Me.rbXZ)
        Me.GB.Controls.Add(Me.rbTWYM)
        Me.GB.Controls.Add(Me.rbWYDF)
        Me.GB.Controls.Add(Me.rbDF)
        Me.GB.Controls.Add(Me.rbKDYH)
        Me.GB.Controls.Add(Me.rbZY)
        Me.GB.Controls.Add(Me.rbWYZH)
        Me.GB.Controls.Add(Me.rbJT)
        Me.GB.Location = New System.Drawing.Point(80, 110)
        Me.GB.Name = "GB"
        Me.GB.Size = New System.Drawing.Size(288, 72)
        Me.GB.TabIndex = 33
        Me.GB.TabStop = False
        Me.GB.Text = "报文类型"
        '
        'rb20
        '
        Me.rb20.Location = New System.Drawing.Point(196, 50)
        Me.rb20.Name = "rb20"
        Me.rb20.Size = New System.Drawing.Size(90, 18)
        Me.rb20.TabIndex = 8
        Me.rb20.Text = "UN(95B-2.0)"
        '
        'rbXZ
        '
        Me.rbXZ.Location = New System.Drawing.Point(100, 50)
        Me.rbXZ.Name = "rbXZ"
        Me.rbXZ.Size = New System.Drawing.Size(92, 18)
        Me.rbXZ.TabIndex = 7
        Me.rbXZ.Text = "箱主(UN911)"
        '
        'rbTWYM
        '
        Me.rbTWYM.Location = New System.Drawing.Point(6, 76)
        Me.rbTWYM.Name = "rbTWYM"
        Me.rbTWYM.Size = New System.Drawing.Size(92, 18)
        Me.rbTWYM.TabIndex = 6
        Me.rbTWYM.Text = "UN(911-阳明)"
        '
        'rbWYDF
        '
        Me.rbWYDF.Location = New System.Drawing.Point(200, 76)
        Me.rbWYDF.Name = "rbWYDF"
        Me.rbWYDF.Size = New System.Drawing.Size(90, 18)
        Me.rbWYDF.TabIndex = 5
        Me.rbWYDF.Text = "外运(UN911)"
        '
        'rbDF
        '
        Me.rbDF.Location = New System.Drawing.Point(196, 26)
        Me.rbDF.Name = "rbDF"
        Me.rbDF.Size = New System.Drawing.Size(90, 18)
        Me.rbDF.TabIndex = 4
        Me.rbDF.Text = "UN(911-1.5)"
        '
        'rbKDYH
        '
        Me.rbKDYH.Location = New System.Drawing.Point(6, 50)
        Me.rbKDYH.Name = "rbKDYH"
        Me.rbKDYH.Size = New System.Drawing.Size(90, 18)
        Me.rbKDYH.TabIndex = 3
        Me.rbKDYH.Text = "凯达(烟海)"
        '
        'rbZY
        '
        Me.rbZY.Location = New System.Drawing.Point(100, 26)
        Me.rbZY.Name = "rbZY"
        Me.rbZY.Size = New System.Drawing.Size(92, 20)
        Me.rbZY.TabIndex = 2
        Me.rbZY.Text = "中远"
        '
        'rbWYZH
        '
        Me.rbWYZH.Location = New System.Drawing.Point(102, 74)
        Me.rbWYZH.Name = "rbWYZH"
        Me.rbWYZH.Size = New System.Drawing.Size(90, 20)
        Me.rbWYZH.TabIndex = 1
        Me.rbWYZH.Text = "外运(交通)"
        '
        'rbJT
        '
        Me.rbJT.Location = New System.Drawing.Point(6, 26)
        Me.rbJT.Name = "rbJT"
        Me.rbJT.Size = New System.Drawing.Size(90, 20)
        Me.rbJT.TabIndex = 0
        Me.rbJT.Text = "交通部平台"
        '
        'LNextPort
        '
        Me.LNextPort.Location = New System.Drawing.Point(244, 94)
        Me.LNextPort.Name = "LNextPort"
        Me.LNextPort.Size = New System.Drawing.Size(10, 6)
        Me.LNextPort.TabIndex = 35
        Me.LNextPort.Visible = False
        '
        'LEndTime
        '
        Me.LEndTime.Location = New System.Drawing.Point(144, 92)
        Me.LEndTime.Name = "LEndTime"
        Me.LEndTime.Size = New System.Drawing.Size(14, 8)
        Me.LEndTime.TabIndex = 36
        Me.LEndTime.Visible = False
        '
        'PB
        '
        Me.PB.Location = New System.Drawing.Point(0, 212)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(368, 18)
        Me.PB.TabIndex = 37
        '
        'LSign
        '
        Me.LSign.Location = New System.Drawing.Point(126, 38)
        Me.LSign.Name = "LSign"
        Me.LSign.Size = New System.Drawing.Size(54, 21)
        Me.LSign.TabIndex = 38
        Me.LSign.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(94, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 14)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "呼号"
        '
        'btRead
        '
        Me.btRead.Location = New System.Drawing.Point(4, 138)
        Me.btRead.Name = "btRead"
        Me.btRead.Size = New System.Drawing.Size(70, 22)
        Me.btRead.TabIndex = 40
        Me.btRead.Text = "查看报文"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(84, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 18)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "箱主代码"
        '
        'txtCodeOperate
        '
        Me.txtCodeOperate.Location = New System.Drawing.Point(150, 184)
        Me.txtCodeOperate.Name = "txtCodeOperate"
        Me.txtCodeOperate.Size = New System.Drawing.Size(121, 20)
        Me.txtCodeOperate.TabIndex = 43
        '
        'FrmWriteMail
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(372, 231)
        Me.Controls.Add(Me.txtCodeOperate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btRead)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LSign)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.LEndTime)
        Me.Controls.Add(Me.LNextPort)
        Me.Controls.Add(Me.GB)
        Me.Controls.Add(Me.cbSummary)
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
        Me.Name = "FrmWriteMail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "船图报文生成"
        Me.GB.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Send.Click
        Dim ds1 As New DataSet()
        Dim dw1 As New DataView()
        Dim ds2 As New DataSet()
        Dim dw2 As New DataView()
        sqlstr = "select * from EMail_Cust where E_Code='" & Trim(cbEmail.SelectedValue) & "'"
        dw1 = Getdata(sqlstr, ds1)
        sqlstr = "select * from EMail_Cust where E_Code='COSTACO'"
        dw2 = Getdata(sqlstr, ds2)

        Call Sendmail(Trim(ds1.Tables(0).Rows(0).Item("E_Mail")), Trim(ds2.Tables(0).Rows(0).Item("E_Mail")))

    End Sub

    Private Sub Sendmail(ByVal Sendto As String, ByVal From As String)
        On Error GoTo Err
        Dim Mail As New MailMessage()
        Dim FileName As String
        Dim Subject As String
        Dim OldMark As String '*************捣箱标志
        Dim ds1 As New DataSet()
        Dim dw1 As New DataView()
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
            If cbSummary.Checked = False Then
                FileName = txtFile.Text & UCase(txtShipCode.Text) & LVoyage.Text & ".txt"
                Subject = "ShipImage ShipName: " & LEnglish.Text & " VON:" & LVoyage.Text
            Else
                FileName = txtFile.Text & UCase(txtShipCode.Text) & LVoyage.Text & "Sum.txt"
                Subject = "(Summary) ShipImage ShipName: " & LEnglish.Text & " VON:" & LVoyage.Text
            End If
        Else
            FileName = txtFile.Text
            If cbSummary.Checked = False Then
                Subject = "ShipImage ShipName: " & LEnglish.Text & " VON:" & LVoyage.Text
            Else
                Subject = "(Summary) ShipImage ShipName: " & LEnglish.Text & " VON:" & LVoyage.Text
            End If
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
        Dim dsTemp As New DataSet
        If Trim(cbEmail.SelectedValue).Length() > 0 Then
            If Getdata("select * from EMail_Cust where E_Code='" & Trim(cbEmail.SelectedValue) & "'", dsTemp).Count > 0 Then
                ConTypeOwner = dsTemp.Tables(0).Rows(0).Item("ConTypeOwner")
                PortOwner = dsTemp.Tables(0).Rows(0).Item("PortOwner")
            Else
                ConTypeOwner = ""
                PortOwner = ""
            End If
            If rbJT.Checked = True Then
                Call WriteJT()
            End If
            If rbZY.Checked = True Then
                Call WriteZY()
            End If
            If rbDF.Checked = True Then
                Call WriteDF()
            End If
            If rbWYZH.Checked = True Then
                Call WriteWYZH()
            End If
            If rbWYDF.Checked = True Then
                Call WriteWYDF()
            End If
            If rbKDYH.Checked = True Then
                Call WriteKDYH()
            End If
            If rbTWYM.Checked = True Then
                Call WriteTWYM()
            End If
            If rbXZ.Checked = True Then
                Call WriteXZ()
            End If
            If rb20.Checked = True Then
                Call Write20()
            End If
        Else
            MsgBox("请选择收文用户！否则不能生成报文。")
        End If
    End Sub
    Private Sub Write20() '''''''''''''UN95B格式

        Dim txtline As String
        Dim i As Integer = 0 '记录行数
        Dim j As Integer = 0 '取箱信息循环
        Dim str As String
        Dim s As String
        Dim tstr As String '***************时间
        Dim str1 As String
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
        Dim ConOperatorCode As String = "" '箱经营人代码
        Dim ConOperator As String = "" '箱经营人
        Dim length As String
        Dim width As String
        Dim heigth As String
        Dim ConNo As String
        If cbSummary.Checked = False Then
            strFile = txtFile.Text & UCase(txtShipCode.Text) & LVoyage.Text & ".txt"
        Else
            strFile = txtFile.Text & UCase(txtShipCode.Text) & LVoyage.Text & "Sum.txt"
        End If
        File.Delete(strFile)
        Dim sw As New StreamWriter(strFile, FileMode.OpenOrCreate, System.Text.Encoding.Default())  '打开报文文件
        '**************写UNB行
        txtline = "UNB+UNOA:1" & "+LYGWL+" & Trim(cbEmail.SelectedValue) & "+" & Mid(Trim(CType(Year(Now()), String)), 3, 2)
        s = Mid("0" & Trim(CType(Month(Now), String)), Len("0" & Trim(CType(Month(Now), String))) - 1, 2)
        txtline = txtline & s
        s = Mid("0" & Trim(CType(Day(Now), String)), Len("0" & Trim(CType(Day(Now), String))) - 1, 2)
        txtline = txtline & s & ":"
        s = Mid("0" & Trim(CType(Hour(Now), String)), Len("0" & Trim(CType(Hour(Now), String))) - 1, 2)
        txtline = txtline & s
        s = Mid("0" & Trim(CType(Minute(Now), String)), Len("0" & Trim(CType(Minute(Now), String))) - 1, 2)
        txtline = txtline & s & "+"

        tstr = Mid(Trim(CType(Year(Now()), String)), 3, 2) & Mid("0" & Trim(CType(Month(Now), String)), Len("0" & Trim(CType(Month(Now), String))) - 1, 2)
        tstr = tstr & Mid("0" & Trim(CType(Day(Now), String)), Len("0" & Trim(CType(Day(Now), String))) - 1, 2)
        tstr = tstr & Mid("0" & Trim(CType(Hour(Now), String)), Len("0" & Trim(CType(Hour(Now), String))) - 1, 2)
        tstr = tstr & Mid("0" & Trim(CType(Minute(Now), String)), Len("0" & Trim(CType(Minute(Now), String))) - 1, 2)
        txtline = txtline & tstr & "'"
        'txtline = txtline & LShipOwner.Text & "'"
        sw.WriteLine(txtline)
        i = 0
        '**************写UNH行
        txtline = "UNH+"
        txtline = txtline & tstr & "+BAPLIE:D:95B:UN:SMDG20'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************写BGM
        txtline = "BGM+++9'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************写时间DTM+137
        txtline = "DTM+137:" & tstr & ":201'"
        sw.WriteLine(txtline)
        i = i + 1
        '****************************/////////////////段组1
        '**************写TDT
        If LSign.Text.Trim().Substring(0, 2).ToUpper() = "UN" Then
            LSign.Text = LSign.Text.Trim().Substring(2)
        End If
        txtline = "TDT+20+" & LVoyage.Text & "++++++" & LSign.Text & ":::" & LEnglish.Text & "'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************LOC(1) 装货港
        txtline = "LOC+5+CNLYG:139:6:LIANYUNGANG'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************LOC(2) 卸货港
        If Len(Trim(LNextPort.Text)) > 0 Then
            str1 = FindPortTemp(Trim(LNextPort.Text))
            txtline = "LOC+61+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(LNextPort.Text)) & ":139:6:" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), InStr(Trim(str1), ":") + 1), Trim(LNextPort.Text)) & "'"
            sw.WriteLine(txtline)
            i = i + 1

        Else
            MsgBox("请在航次记录中选择下一港名称!")
            Exit Sub
        End If
        '******************离港时间
        If Len(Trim(LEndTime.Text)) > 0 Then
            
            txtline = "DTM+136:" & Trim(LEndTime.Text) & ":101'"
            sw.WriteLine(txtline)
            i = i + 1
            txtline = "DTM+132:" & Trim(LEndTime.Text) & ":101'"
            sw.WriteLine(txtline)
            i = i + 1
        Else
            
            txtline = "DTM+136:" & Mid(tstr, 1, 6) & ":101'"
            sw.WriteLine(txtline)
            i = i + 1
            txtline = "DTM+132:" & Mid(tstr, 1, 6) & ":101'"
            sw.WriteLine(txtline)
            i = i + 1
        End If
       
        '**************开始箱循环
        If cbSummary.Checked = False Then
            sqlstr = "select * from Con_Image where Code_Load_Port  like '%LYG%' and Ship_ID=" & Ship_ID
        Else
            sqlstr = "select * from Con_Image where Ship_ID=" & Ship_ID
        End If
        dw = Getdata(sqlstr, ds)
        PB.Maximum = dw.Count
        PB.Value = 0
        Do While j < dw.Count
            PB.Value = j
            ConType = "" '箱尺寸类型
            ConOverFront = ""  '前超
            ConOverBack = ""  '后超
            ConOverLeft = ""  '左超
            ConOverRight = ""  '右超
            ConOverHeight = ""  '超高
            ConTareWeight = ""  '箱皮重
            ConOperatorCode = ""  '箱经营人代码
            ConOperator = ""  '箱经营人

            If ds.Tables(0).Rows(j).Item("Code_Con_Company") Is System.DBNull.Value Then
                ConOperatorCode = ""
            Else
                ConOperatorCode = UCase(CType(ds.Tables(0).Rows(j).Item("Code_Con_Company"), String))
            End If
            dst.Reset()
            str = "select * from CON_CRITERION where CONTAINER_NO='" & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & "'"
            dwt = Getdata(str, dst)
            If dwt.Count > 0 Then
                ConType = Trim(dst.Tables(0).Rows(0).Item("SIZE_CON")) & Trim(dst.Tables(0).Rows(0).Item("CONTAINER_TYPE"))
                If ConOperatorCode.Trim().Length() = 0 Then
                    ConOperatorCode = Trim(dst.Tables(0).Rows(0).Item("Code_Con_Company"))
                End If
                ConOperator = ""
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("CON_WEIGHT")) Then
                    ConTareWeight = Trim(CType(CType(dst.Tables(0).Rows(0).Item("CON_WEIGHT"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_Height")) Then
                    ConOverHeight = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_Height"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_Left")) Then
                    ConOverLeft = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_Left"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_Right")) Then
                    ConOverRight = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_Right"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_BEFORE")) Then
                    ConOverFront = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_BEFORE"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_BEHIND")) Then
                    ConOverBack = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_BEHIND"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("Length")) Then
                    length = Trim(CType(dst.Tables(0).Rows(0).Item("Length"), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("Width")) Then
                    width = Trim(CType(dst.Tables(0).Rows(0).Item("Width"), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("Height")) Then
                    heigth = Trim(CType(dst.Tables(0).Rows(0).Item("Heigtht"), String))
                End If
            End If

            dst.Reset()

            str = "select * from CODE_TYPE_SHIP_RELATION where CONTAINER_NO='" & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & "' and CODE_SHIP_OWNER='" & ConTypeOwner & "'" 'and CODE_SHIP_OWNER='CMA'"
            dwt = Getdata(str, dst)
            If dwt.Count > 0 Then
                ConType = Trim(dst.Tables(0).Rows(0).Item("CODE_CON_TYPE"))
            Else
                dst.Reset()
                str = "select * from CODE_CON_TYPE where CODE_CON_TYPE='" & ConType & "' and CODE_SHIP_OWNER='" & ConTypeOwner & "'"  'and CODE_SHIP_OWNER='CMA'"
                dwt = Getdata(str, dst)
                If dwt.Count > 0 Then
                    ConType = Trim(dst.Tables(0).Rows(0).Item("CODE_SHIP_TYPE"))
                Else
                    ConType = ConType
                End If
            End If

            ''*********************非连云港箱型（2011.10.23外理陶明月要求，非本港箱原进原出，2013年11月14日要求改回）
            If InStr(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), "LYG") > 0 Then
            Else
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeConType")) Then
                    ConType = Trim(ds.Tables(0).Rows(j).Item("CodeConType"))
                End If
            End If

            '*************LOC + 147 贝位号
            txtline = "LOC+147+" & "0" & ds.Tables(0).Rows(j).Item("BAYNO") & "::5'"
            sw.WriteLine(txtline)
            i = i + 1
          
            '*************MEA 货物重量
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("GROSSWEIGHT")) Then
                txtline = "MEA+WT++KGM:" & CType(CType(ds.Tables(0).Rows(j).Item("GrossWeight"), Single), String) & "'"
            Else
                txtline = "MEA+WT++KGM:0000'"
            End If
            sw.WriteLine(txtline)
            i = i + 1
           
           
            If InStr(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), "LYG") > 0 Then
                '************************装货港
                str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), PortOwner) '"CMA")
                If InStr(Trim(str1), ":") <> 6 Then
                    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的装货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Else
                        Exit Sub
                    End If
                End If
                txtline = "LOC+9+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port"))) & ":139:6:" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), InStr(Trim(str1), ":") + 1), Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port"))) & "'"
                sw.WriteLine(txtline)
                i = i + 1

                '************************卸货港
                str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")), PortOwner) '"CMA")
                If InStr(Trim(str1), ":") <> 6 Then
                    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的卸货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Else
                        Exit Sub
                    End If
                End If
                txtline = "LOC+11+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port"))) & ":139:6:" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), InStr(Trim(str1), ":") + 1), Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port"))) & "'"
                sw.WriteLine(txtline)
                i = i + 1

                '************************目的港
                str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")), PortOwner) '"CMA")
                If InStr(Trim(str1), ":") <> 6 Then
                    str1 = FindPortTemp(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")))
                    If InStr(Trim(str1), ":") <> 6 Then
                        If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的目的港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Else
                            Exit Sub
                        End If
                    End If
                End If
                txtline = "LOC+83+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_Delivery"))) & ":139:6:" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), InStr(Trim(str1), ":") + 1), Trim(ds.Tables(0).Rows(j).Item("Code_Delivery"))) & "'"
                sw.WriteLine(txtline)
                i = i + 1
            Else
                '************************装货港
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeLoadPort")) Then
                    '*********************非连云港装港口
                    txtline = "LOC+9+" & Trim(ds.Tables(0).Rows(j).Item("CodeLoadPort")) & ":139:6:" & Trim(ds.Tables(0).Rows(j).Item("CodeLoadPort")) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                Else

                    str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), PortOwner) '"CMA")
                    'If InStr(Trim(str1), ":") <> 6 Then
                    '    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的装货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    '    Else
                    '        Exit Sub
                    '    End If
                    'End If
                    txtline = "LOC+9+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port"))) & ":139:6:" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), InStr(Trim(str1), ":") + 1), Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port"))) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
                '************************卸货港
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeUnLoadPort")) Then
                    '*********************非连云港装港口
                    txtline = "LOC+11+" & Trim(ds.Tables(0).Rows(j).Item("CodeUnLoadPort")) & ":139:6:" & Trim(ds.Tables(0).Rows(j).Item("CodeUnLoadPort")) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                Else
                    str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")), PortOwner) '"CMA")
                    'If InStr(Trim(str1), ":") <> 6 Then
                    '    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的装货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    '    Else
                    '        Exit Sub
                    '    End If
                    'End If
                    txtline = "LOC+11+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port"))) & ":139:6:" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), InStr(Trim(str1), ":") + 1), Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port"))) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
                '************************目的港
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeDelivery")) Then
                    '*********************非连云港装港口
                    txtline = "LOC+83+" & Trim(ds.Tables(0).Rows(j).Item("CodeDelivery")) & ":139:6:" & Trim(ds.Tables(0).Rows(j).Item("CodeDelivery")) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                Else
                    str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")), PortOwner) '"CMA")
                    If InStr(Trim(str1), ":") <> 6 Then
                        str1 = FindPortTemp(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")))
                        'If InStr(Trim(str1), ":") <> 6 Then
                        '    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的目的港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        '    Else
                        '        Exit Sub
                        '    End If
                        'End If
                    End If
                    txtline = "LOC+83+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_Delivery"))) & ":139:6:" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), InStr(Trim(str1), ":") + 1), Trim(ds.Tables(0).Rows(j).Item("Code_Delivery"))) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
            End If
            '***********************提单号
            txtline = "RFF+BM:" & Trim(CType(ds.Tables(0).Rows(j).Item("BLNO"), String)) & "'"
            sw.WriteLine(txtline)
            i = i + 1
            '***********************EQD+CN 箱号 箱型
            ConNo = ds.Tables(0).Rows(j).Item("Container_NO")
            If Len(Trim(ConNo)) = 11 Then
                ConNo = Mid(Trim(ConNo), 1, 4) & " " & Mid(Trim(ConNo), 5, 7)
            End If
            If Mid(UCase(ds.Tables(0).Rows(j).Item("FULLOREMPTY")), 1, 1) = "F" Then
                txtline = "EQD+CN+" & ConNo & "+" & ConType & "+++5'"
            End If
            If Mid(UCase(ds.Tables(0).Rows(j).Item("FULLOREMPTY")), 1, 1) = "E" Then
                txtline = "EQD+CN+" & ConNo & "+" & ConType & "+++4'"
            End If
            If Mid(UCase(ds.Tables(0).Rows(j).Item("FULLOREMPTY")), 1, 1) = "L" Then
                txtline = "EQD+CN+" & ConNo & "+" & ConType & "+++7'"
            End If
            sw.WriteLine(txtline)
            i = i + 1
            '*******************箱经营人
            txtline = "NAD+CA+" & Trim(ConOperatorCode) & ":172'"
            sw.WriteLine(txtline)
            i = i + 1

            '*************MEA 货物重量
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("GROSSWEIGHT")) Then
                txtline = "MEA+WT++KGM:" & CType(CType(ds.Tables(0).Rows(j).Item("GrossWeight"), Single), String) & "'"
            Else
                txtline = "MEA+WT++KGM:0000'"
            End If
            sw.WriteLine(txtline)
            i = i + 1
            '******************DIM 超高等
            If Len(Trim(ConOverHeight)) > 0 Or Len(Trim(ConOverLeft)) > 0 Or Len(Trim(ConOverRight)) > 0 Or Len(Trim(ConOverFront)) > 0 Or Len(Trim(ConOverBack)) > 0 Then
                If Len(Trim(ConOverFront)) > 0 Then
                    txtline = "DIM+5+CMT:" & Trim(ConOverFront) & "::'"
                End If
                If Len(Trim(ConOverBack)) > 0 Then
                    txtline = "DIM+6+CMT:" & Trim(ConOverBack) & "::'"
                End If
                If Len(Trim(ConOverRight)) > 0 Then
                    txtline = "DIM+7+CMT::" & Trim(ConOverRight) & ":'"
                End If
                If Len(Trim(ConOverLeft)) > 0 Then
                    txtline = "DIM+8+CMT::" & Trim(ConOverLeft) & ":'"
                End If
                If Len(Trim(ConOverHeight)) > 0 Then
                    txtline = "DIM+9+CMT:::" & Trim(ConOverHeight) & "'"
                End If
                sw.WriteLine(txtline)
                i = i + 1
            Else
                If Len(Trim(length)) > 0 And Len(Trim(width)) > 0 And Len(Trim(heigth)) > 0 Then
                    txtline = "DIM+1+INH:" & Trim(length) & ":" & Trim(width) & ":" & Trim(heigth) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If

            End If

            '*********************冷藏箱
            If (Not IsDBNull(ds.Tables(0).Rows(j).Item("TEMPERATURE_UNIT"))) And (Not IsDBNull(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"))) Then
                If Len(Trim(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"))) > 0 Then
                    txtline = "TMP+2+" & Trim(CType(CType(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"), Single), String)) & ":CEL'"
                    sw.WriteLine(txtline)
                    i = i + 1

                End If
            End If
            '*******************危险品
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("DANGER_GRADE")) Then
                If Len(Trim(ds.Tables(0).Rows(j).Item("DANGER_GRADE"))) > 0 Then
                    txtline = "DGS+IMD+" & Trim(ds.Tables(0).Rows(j).Item("DANGER_GRADE"))

                    txtline = txtline & "'"
                    sw.WriteLine(txtline)
                    i = i + 1

                End If

            End If

            j = j + 1
        Loop
        '*************UNT
        i = i + 1
        txtline = "UNT+" & Trim(CType(i, String)) & "+" & tstr & "'"
        sw.WriteLine(txtline)
        txtline = "UNZ+1+" & tstr & "'"
        sw.WriteLine(txtline)
        sw.Close()
        MsgBox("生成完成,谢谢! 共生成 " & Trim(CType(i, String)) & " 行报文 共 " & j & " 个箱子")
    End Sub
    Private Sub WriteXZ()
        Dim txtline As String
        Dim i As Integer = 0 '记录行数
        Dim j As Integer = 0 '取箱信息循环
        Dim str As String
        Dim s As String
        Dim tstr As String '***************时间
        Dim str1 As String
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
        Dim ConOperatorCode As String = "" '箱经营人代码
        Dim ConOperator As String = "" '箱经营人
        Dim length As String
        Dim width As String
        Dim heigth As String
        Dim ConNo As String
        If cbSummary.Checked = False Then
            strFile = txtFile.Text & UCase(txtShipCode.Text) & LVoyage.Text & ".txt"
        Else
            strFile = txtFile.Text & UCase(txtShipCode.Text) & LVoyage.Text & "Sum.txt"
        End If
        File.Delete(strFile)
        Dim sw As New StreamWriter(strFile, FileMode.OpenOrCreate, System.Text.Encoding.Default())  '打开报文文件
        '**************写UNB行
        txtline = "UNB+UNOA:1" & "+COSTACO+" & Trim(cbEmail.SelectedValue) & "+" & Mid(Trim(CType(Year(Now()), String)), 3, 2)
        s = Mid("0" & Trim(CType(Month(Now), String)), Len("0" & Trim(CType(Month(Now), String))) - 1, 2)
        txtline = txtline & s
        s = Mid("0" & Trim(CType(Day(Now), String)), Len("0" & Trim(CType(Day(Now), String))) - 1, 2)
        txtline = txtline & s & ":"
        s = Mid("0" & Trim(CType(Hour(Now), String)), Len("0" & Trim(CType(Hour(Now), String))) - 1, 2)
        txtline = txtline & s
        s = Mid("0" & Trim(CType(Minute(Now), String)), Len("0" & Trim(CType(Minute(Now), String))) - 1, 2)
        txtline = txtline & s & "+"

        tstr = Mid(Trim(CType(Year(Now()), String)), 3, 2) & Mid("0" & Trim(CType(Month(Now), String)), Len("0" & Trim(CType(Month(Now), String))) - 1, 2)
        tstr = tstr & Mid("0" & Trim(CType(Day(Now), String)), Len("0" & Trim(CType(Day(Now), String))) - 1, 2)
        tstr = tstr & Mid("0" & Trim(CType(Hour(Now), String)), Len("0" & Trim(CType(Hour(Now), String))) - 1, 2)
        tstr = tstr & Mid("0" & Trim(CType(Minute(Now), String)), Len("0" & Trim(CType(Minute(Now), String))) - 1, 2)
        txtline = txtline & tstr & "+++++"
        txtline = txtline & LShipOwner.Text & "'"
        sw.WriteLine(txtline)
        i = 0
        '**************写UNH行
        txtline = "UNH+"
        txtline = txtline & tstr & "+BAPLIE:1:911:UN:SMDG15'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************写BGM
        txtline = "BGM++" & tstr & "+9'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************写时间DTM+137
        txtline = "DTM+137:" & tstr & ":201'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************写TDT
        If LSign.Text.Trim().Substring(0, 2).ToUpper() = "UN" Then
            LSign.Text = LSign.Text.Trim().Substring(2)
        End If
        txtline = "TDT+20+" & LVoyage.Text & "++" & LSign.Text & ":103::" & LEnglish.Text & "++" & LShipOwner.Text & ":172:20'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************LOC(1) 装货港
        txtline = "LOC+5+CNLYG'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************LOC(2) 卸货港
        If Len(Trim(LNextPort.Text)) > 0 Then
            str1 = FindPortTemp(Trim(LNextPort.Text))
            txtline = "LOC+61+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(LNextPort.Text)) & "'"
            sw.WriteLine(txtline)
            i = i + 1
        Else
            MsgBox("请在航次记录中选择下一港名称!")
            Exit Sub
        End If
        '******************离港时间
        If Len(Trim(LEndTime.Text)) > 0 Then
            txtline = "DTM+178:" & Trim(LEndTime.Text) & "0000:201'"
            sw.WriteLine(txtline)
            i = i + 1
            txtline = "DTM+136:" & Trim(LEndTime.Text) & "0000:201'"
            sw.WriteLine(txtline)
            i = i + 1
            txtline = "DTM+132:" & Trim(LEndTime.Text) & ":101'"
            sw.WriteLine(txtline)
            i = i + 1
        Else
            txtline = "DTM+178:" & Mid(tstr, 1, 6) & "0000:201'"
            sw.WriteLine(txtline)
            i = i + 1
            txtline = "DTM+136:" & Mid(tstr, 1, 6) & "0000:201'"
            sw.WriteLine(txtline)
            i = i + 1
            txtline = "DTM+132:" & Mid(tstr, 1, 6) & ":101'"
            sw.WriteLine(txtline)
            i = i + 1
        End If
        '******************航次
        txtline = "RFF+VON:" & LVoyage.Text & "'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************开始箱循环
        If cbSummary.Checked = False Then
            sqlstr = "select * from Con_Image where Code_Load_Port  like '%LYG%' and Ship_ID=" & Ship_ID & " and Code_Con_Company like '%" + Trim(txtCodeOperate.Text) + "%'"
        Else
            sqlstr = "select * from Con_Image where Ship_ID=" & Ship_ID & " and Code_Con_Company like '%" + Trim(txtCodeOperate.Text) + "%'"
        End If
        dw = Getdata(sqlstr, ds)
        PB.Maximum = dw.Count
        PB.Value = 0
        Do While j < dw.Count
            PB.Value = j
            ConType = "" '箱尺寸类型
            ConOverFront = ""  '前超
            ConOverBack = ""  '后超
            ConOverLeft = ""  '左超
            ConOverRight = ""  '右超
            ConOverHeight = ""  '超高
            ConTareWeight = ""  '箱皮重
            ConOperatorCode = ""  '箱经营人代码
            ConOperator = ""  '箱经营人

            If ds.Tables(0).Rows(j).Item("Code_Con_Company") Is System.DBNull.Value Then
                ConOperatorCode = ""
            Else
                ConOperatorCode = UCase(CType(ds.Tables(0).Rows(j).Item("Code_Con_Company"), String))
            End If
            dst.Reset()
            str = "select * from CON_CRITERION where CONTAINER_NO='" & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & "'"
            dwt = Getdata(str, dst)
            If dwt.Count > 0 Then
                ConType = Trim(dst.Tables(0).Rows(0).Item("SIZE_CON")) & Trim(dst.Tables(0).Rows(0).Item("CONTAINER_TYPE"))
                If ConOperatorCode.Trim().Length() = 0 Then
                    ConOperatorCode = Trim(dst.Tables(0).Rows(0).Item("Code_Con_Company"))
                End If
                ConOperator = ""
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("CON_WEIGHT")) Then
                    ConTareWeight = Trim(CType(CType(dst.Tables(0).Rows(0).Item("CON_WEIGHT"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_Height")) Then
                    ConOverHeight = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_Height"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_Left")) Then
                    ConOverLeft = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_Left"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_Right")) Then
                    ConOverRight = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_Right"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_BEFORE")) Then
                    ConOverFront = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_BEFORE"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_BEHIND")) Then
                    ConOverBack = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_BEHIND"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("Length")) Then
                    length = Trim(CType(dst.Tables(0).Rows(0).Item("Length"), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("Width")) Then
                    width = Trim(CType(dst.Tables(0).Rows(0).Item("Width"), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("Height")) Then
                    heigth = Trim(CType(dst.Tables(0).Rows(0).Item("Heigtht"), String))
                End If
            End If

            dst.Reset()

            str = "select * from CODE_TYPE_SHIP_RELATION where CONTAINER_NO='" & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & "' and CODE_SHIP_OWNER='" & ConTypeOwner & "'" 'and CODE_SHIP_OWNER='CMA'"
            dwt = Getdata(str, dst)
            If dwt.Count > 0 Then
                ConType = Trim(dst.Tables(0).Rows(0).Item("CODE_CON_TYPE"))
            Else
                dst.Reset()
                str = "select * from CODE_CON_TYPE where CODE_CON_TYPE='" & ConType & "' and CODE_SHIP_OWNER='" & ConTypeOwner & "'"  'and CODE_SHIP_OWNER='CMA'"
                dwt = Getdata(str, dst)
                If dwt.Count > 0 Then
                    ConType = Trim(dst.Tables(0).Rows(0).Item("CODE_SHIP_TYPE"))
                Else
                    ConType = ConType
                End If
            End If

            ''*********************非连云港箱型（2011.10.23外理陶明月要求，非本港箱原进原出，2013年11月14日要求改回）
            'If InStr(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), "LYG") > 0 Then
            'Else
            '    If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeConType")) Then
            '        ConType = Trim(ds.Tables(0).Rows(j).Item("CodeConType"))
            '    End If
            'End If

            '*************LOC + 147 贝位号
            txtline = "LOC+147+" & "0" & ds.Tables(0).Rows(j).Item("BAYNO") & "'"
            sw.WriteLine(txtline)
            i = i + 1
            '**************FTX+AAA货物描述
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("Demo")) Then
                If Len(Trim(ds.Tables(0).Rows(j).Item("Demo"))) > 0 Then
                    txtline = "FTX+AAA+++" & ds.Tables(0).Rows(j).Item("Demo") & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
            End If
            '**************FTX+CLR箱货物描述
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("ConDemo")) Then
                If Len(Trim(ds.Tables(0).Rows(j).Item("ConDemo"))) > 0 Then
                    txtline = "FTX+CLR+++" & ds.Tables(0).Rows(j).Item("ConDemo") & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
            End If
            '*************MEA 货物重量
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("GROSSWEIGHT")) Then
                txtline = "MEA+WT++KGM:" & CType(CType(ds.Tables(0).Rows(j).Item("GrossWeight"), Single), String) & "'"
            Else
                txtline = "MEA+WT++KGM:0000'"
            End If
            sw.WriteLine(txtline)
            i = i + 1
            '******************DIM 超高等
            If Len(Trim(ConOverHeight)) > 0 Or Len(Trim(ConOverLeft)) > 0 Or Len(Trim(ConOverRight)) > 0 Or Len(Trim(ConOverFront)) > 0 Or Len(Trim(ConOverBack)) > 0 Then
                If Len(Trim(ConOverFront)) > 0 Then
                    txtline = "DIM+5+CMT:" & Trim(ConOverFront) & "::'"
                End If
                If Len(Trim(ConOverBack)) > 0 Then
                    txtline = "DIM+6+CMT:" & Trim(ConOverBack) & "::'"
                End If
                If Len(Trim(ConOverRight)) > 0 Then
                    txtline = "DIM+7+CMT::" & Trim(ConOverRight) & ":'"
                End If
                If Len(Trim(ConOverLeft)) > 0 Then
                    txtline = "DIM+8+CMT::" & Trim(ConOverLeft) & ":'"
                End If
                If Len(Trim(ConOverHeight)) > 0 Then
                    txtline = "DIM+9+CMT:::" & Trim(ConOverHeight) & "'"
                End If
                sw.WriteLine(txtline)
                i = i + 1
            Else
                If Len(Trim(length)) > 0 And Len(Trim(width)) > 0 And Len(Trim(heigth)) > 0 Then
                    txtline = "DIM+1+INH:" & Trim(length) & ":" & Trim(width) & ":" & Trim(heigth) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If

            End If
            '*********************冷藏箱
            If (Not IsDBNull(ds.Tables(0).Rows(j).Item("TEMPERATURE_UNIT"))) And (Not IsDBNull(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"))) Then
                If Len(Trim(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"))) > 0 Then
                    txtline = "TMP+2+" & Trim(CType(CType(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"), Single), String)) & ":CEL'"
                    sw.WriteLine(txtline)
                    i = i + 1
                    If Not IsDBNull(ds.Tables(0).Rows(j).Item("MAX_TEMPERATURE")) Then
                        txtline = "RNG+ZZZ+CEL:" & Trim(CType(CType(ds.Tables(0).Rows(j).Item("MIN_TEMPERATURE"), Single), String)) & ":" & Trim(CType(CType(ds.Tables(0).Rows(j).Item("MAX_TEMPERATURE"), Single), String)) & "'"
                    Else
                        txtline = "RNG+ZZZ+CEL:" & Trim(CType(CType(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"), Single), String)) & ":" & Trim(CType(CType(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"), Single), String)) & "'"
                    End If
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
            End If
            If InStr(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), "LYG") > 0 Then
                '************************装货港
                str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), PortOwner) '"CMA")
                If InStr(Trim(str1), ":") <> 6 Then
                    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的装货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Else
                        Exit Sub
                    End If
                End If
                txtline = "LOC+6+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port"))) & "'"
                sw.WriteLine(txtline)
                i = i + 1

                '************************卸货港
                str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")), PortOwner) '"CMA")
                If InStr(Trim(str1), ":") <> 6 Then
                    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的装货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Else
                        Exit Sub
                    End If
                End If
                txtline = "LOC+12+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port"))) & "'"
                sw.WriteLine(txtline)
                i = i + 1

                '************************目的港
                str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")), PortOwner) '"CMA")
                If InStr(Trim(str1), ":") <> 6 Then
                    str1 = FindPortTemp(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")))
                    If InStr(Trim(str1), ":") <> 6 Then
                        If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的目的港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Else
                            Exit Sub
                        End If
                    End If
                End If
                txtline = "LOC+83+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_Delivery"))) & "'"
                sw.WriteLine(txtline)
                i = i + 1
            Else
                '************************装货港
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeLoadPort")) Then
                    '*********************非连云港装港口
                    txtline = "LOC+6+" & Trim(ds.Tables(0).Rows(j).Item("CodeLoadPort")) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                Else

                    str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), PortOwner) '"CMA")
                    'If InStr(Trim(str1), ":") <> 6 Then
                    '    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的装货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    '    Else
                    '        Exit Sub
                    '    End If
                    'End If
                    txtline = "LOC+6+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port"))) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
                '************************卸货港
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeUnLoadPort")) Then
                    '*********************非连云港装港口
                    txtline = "LOC+12+" & Trim(ds.Tables(0).Rows(j).Item("CodeUnLoadPort")) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                Else
                    str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")), PortOwner) '"CMA")
                    'If InStr(Trim(str1), ":") <> 6 Then
                    '    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的装货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    '    Else
                    '        Exit Sub
                    '    End If
                    'End If
                    txtline = "LOC+12+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port"))) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
                '************************目的港
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeDelivery")) Then
                    '*********************非连云港装港口
                    txtline = "LOC+83+" & Trim(ds.Tables(0).Rows(j).Item("CodeDelivery")) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                Else
                    str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")), PortOwner) '"CMA")
                    If InStr(Trim(str1), ":") <> 6 Then
                        str1 = FindPortTemp(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")))
                        'If InStr(Trim(str1), ":") <> 6 Then
                        '    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的目的港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        '    Else
                        '        Exit Sub
                        '    End If
                        'End If
                    End If
                    txtline = "LOC+83+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_Delivery"))) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
            End If
            '***********************提单号
            txtline = "RFF+BM:" & Trim(CType(ds.Tables(0).Rows(j).Item("BLNO"), String)) & "'"
            sw.WriteLine(txtline)
            i = i + 1
            '***********************EQD+CN 箱号 箱型
            ConNo = ds.Tables(0).Rows(j).Item("Container_NO")
            If Len(Trim(ConNo)) = 11 Then
                ConNo = Mid(Trim(ConNo), 1, 4) & " " & Mid(Trim(ConNo), 5, 7)
            End If
            If Mid(UCase(ds.Tables(0).Rows(j).Item("FULLOREMPTY")), 1, 1) = "F" Then
                txtline = "EQD+CN+" & ConNo & "+" & ConType & "+++5'"
            End If
            If Mid(UCase(ds.Tables(0).Rows(j).Item("FULLOREMPTY")), 1, 1) = "E" Then
                txtline = "EQD+CN+" & ConNo & "+" & ConType & "+++4'"
            End If
            If Mid(UCase(ds.Tables(0).Rows(j).Item("FULLOREMPTY")), 1, 1) = "L" Then
                txtline = "EQD+CN+" & ConNo & "+" & ConType & "+++7'"
            End If
            sw.WriteLine(txtline)
            i = i + 1
            '*******************箱经营人
            txtline = "NAD+CA+" & Trim(ConOperatorCode) & ":172:ZZZ'"
            sw.WriteLine(txtline)
            i = i + 1
            '*******************危险品
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("DANGER_GRADE")) Then
                If Len(Trim(ds.Tables(0).Rows(j).Item("DANGER_GRADE"))) > 0 Then
                    txtline = "DGS+IMD+" & Trim(ds.Tables(0).Rows(j).Item("DANGER_GRADE"))
                    If Not IsDBNull(ds.Tables(0).Rows(j).Item("DANGER_PageNO")) Then
                        txtline = txtline & ":" & Trim(CType(ds.Tables(0).Rows(j).Item("DANGER_PageNO"), String))
                    End If
                    If Not IsDBNull(ds.Tables(0).Rows(j).Item("DANGER_NO")) Then
                        txtline = txtline & "+" & Trim(CType(ds.Tables(0).Rows(j).Item("DANGER_NO"), String))
                    End If
                    txtline = txtline & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                    '*********************危险品FTX
                    'txtline = "FTX+AAA+++========'"
                    'sw.WriteLine(txtline)
                    'i = i + 1
                End If

            End If

            j = j + 1
        Loop
        '*************UNT
        i = i + 1
        txtline = "UNT+" & Trim(CType(i, String)) & "+" & tstr & "'"
        sw.WriteLine(txtline)
        txtline = "UNZ+1+" & tstr & "'"
        sw.WriteLine(txtline)
        sw.Close()
        MsgBox("生成完成,谢谢! 共生成 " & Trim(CType(i, String)) & " 行报文 共 " & j & " 个箱子")
    End Sub
    Private Sub WriteTWYM()    '**********************台湾阳明达飞
        Dim txtline As String
        Dim i As Integer = 0 '记录行数
        Dim j As Integer = 0 '取箱信息循环
        Dim str As String
        Dim s As String
        Dim tstr As String '***************时间
        Dim str1 As String
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
        Dim ConOperatorCode As String = "" '箱经营人代码
        Dim ConOperator As String = "" '箱经营人
        Dim length As String
        Dim width As String
        Dim heigth As String
        Dim ConNo As String
        If cbSummary.Checked = False Then
            strFile = txtFile.Text & UCase(txtShipCode.Text) & LVoyage.Text & ".DAT"
        Else
            strFile = txtFile.Text & UCase(txtShipCode.Text) & LVoyage.Text & "Sum.DAT"
        End If
        File.Delete(strFile)
        Dim sw As New StreamWriter(strFile, FileMode.OpenOrCreate, System.Text.Encoding.Default())  '打开报文文件

        '**************写UNB行
        txtline = "UNB+UNOA:1" & "+COSTACO+" & Trim(cbEmail.SelectedValue) & "+" & Mid(Trim(CType(Year(Now()), String)), 3, 2)
        s = Mid("0" & Trim(CType(Month(Now), String)), Len("0" & Trim(CType(Month(Now), String))) - 1, 2)
        txtline = txtline & s
        s = Mid("0" & Trim(CType(Day(Now), String)), Len("0" & Trim(CType(Day(Now), String))) - 1, 2)
        txtline = txtline & s & ":"
        s = Mid("0" & Trim(CType(Hour(Now), String)), Len("0" & Trim(CType(Hour(Now), String))) - 1, 2)
        txtline = txtline & s
        s = Mid("0" & Trim(CType(Minute(Now), String)), Len("0" & Trim(CType(Minute(Now), String))) - 1, 2)
        txtline = txtline & s & "+"

        tstr = Mid(Trim(CType(Year(Now()), String)), 3, 2) & Mid("0" & Trim(CType(Month(Now), String)), Len("0" & Trim(CType(Month(Now), String))) - 1, 2)
        tstr = tstr & Mid("0" & Trim(CType(Day(Now), String)), Len("0" & Trim(CType(Day(Now), String))) - 1, 2)
        tstr = tstr & Mid("0" & Trim(CType(Hour(Now), String)), Len("0" & Trim(CType(Hour(Now), String))) - 1, 2)
        tstr = tstr & Mid("0" & Trim(CType(Minute(Now), String)), Len("0" & Trim(CType(Minute(Now), String))) - 1, 2)
        txtline = txtline & tstr & "+++++"
        txtline = txtline & LShipOwner.Text & "'"
        sw.WriteLine(txtline)
        i = 0
        '**************写UNH行
        txtline = "UNH+"
        txtline = txtline & tstr & "+BAPLIE:1:911:UN:SMDG15'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************写BGM
        txtline = "BGM++" & tstr & "+9'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************写时间DTM+137
        txtline = "DTM+137:" & tstr & ":201'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************写TDT
        If LSign.Text.Trim().Substring(0, 2).ToUpper() = "UN" Then
            LSign.Text = LSign.Text.Trim().Substring(2)
        End If
        txtline = "TDT+20+" & LVoyage.Text & "++" & LSign.Text & ":103::" & LEnglish.Text & "++" & LShipOwner.Text & ":172:20'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************LOC(1) 装货港
        txtline = "LOC+5+CNLYG'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************LOC(2) 卸货港
        If Len(Trim(LNextPort.Text)) > 0 Then
            str1 = FindPortTemp(Trim(LNextPort.Text))
            txtline = "LOC+61+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(LNextPort.Text)) & "'"
            sw.WriteLine(txtline)
            i = i + 1
        Else
            MsgBox("请在航次记录中选择下一港名称!")
            Exit Sub
        End If
        '******************离港时间
        If Len(Trim(LEndTime.Text)) > 0 Then
            txtline = "DTM+178:" & Trim(LEndTime.Text) & "0000:201'"
            sw.WriteLine(txtline)
            i = i + 1
            txtline = "DTM+136:" & Trim(LEndTime.Text) & "0000:201'"
            sw.WriteLine(txtline)
            i = i + 1
            txtline = "DTM+132:" & Trim(LEndTime.Text) & ":201'"
            sw.WriteLine(txtline)
            i = i + 1
        Else
            txtline = "DTM+178:" & Mid(tstr, 1, 6) & "0000:201'"
            sw.WriteLine(txtline)
            i = i + 1
            txtline = "DTM+136:" & Mid(tstr, 1, 6) & "0000:201'"
            sw.WriteLine(txtline)
            i = i + 1
            txtline = "DTM+132:" & Mid(tstr, 1, 6) & ":201'"
            sw.WriteLine(txtline)
            i = i + 1
        End If
        '******************航次
        txtline = "RFF+VON:" & LVoyage.Text & "'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************开始箱循环
        If cbSummary.Checked = False Then
            sqlstr = "select * from Con_Image where Code_Load_Port  like '%LYG%' and Ship_ID=" & Ship_ID
        Else
            sqlstr = "select * from Con_Image where Ship_ID=" & Ship_ID
        End If
        dw = Getdata(sqlstr, ds)
        PB.Maximum = dw.Count
        PB.Value = 0
        Do While j < dw.Count
            PB.Value = j
            ConType = "" '箱尺寸类型
            ConOverFront = ""  '前超
            ConOverBack = ""  '后超
            ConOverLeft = ""  '左超
            ConOverRight = ""  '右超
            ConOverHeight = ""  '超高
            ConTareWeight = ""  '箱皮重
            ConOperatorCode = ""  '箱经营人代码
            ConOperator = ""  '箱经营人
            If ds.Tables(0).Rows(j).Item("Code_Con_Company") Is System.DBNull.Value Then
                ConOperatorCode = ""
            Else
                ConOperatorCode = UCase(CType(ds.Tables(0).Rows(j).Item("Code_Con_Company"), String))
            End If
            dst.Reset()
            str = "select * from CON_CRITERION where CONTAINER_NO='" & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & "'"
            dwt = Getdata(str, dst)
            If dwt.Count > 0 Then
                ConType = Trim(dst.Tables(0).Rows(0).Item("SIZE_CON")) & Trim(dst.Tables(0).Rows(0).Item("CONTAINER_TYPE"))
                If ConOperatorCode.Trim().Length() = 0 Then
                    ConOperatorCode = Trim(dst.Tables(0).Rows(0).Item("Code_Con_Company"))
                End If
                ConOperator = ""
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("CON_WEIGHT")) Then
                    ConTareWeight = Trim(CType(CType(dst.Tables(0).Rows(0).Item("CON_WEIGHT"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_Height")) Then
                    ConOverHeight = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_Height"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_Left")) Then
                    ConOverLeft = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_Left"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_Right")) Then
                    ConOverRight = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_Right"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_BEFORE")) Then
                    ConOverFront = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_BEFORE"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_BEHIND")) Then
                    ConOverBack = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_BEHIND"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("Length")) Then
                    length = Trim(CType(dst.Tables(0).Rows(0).Item("Length"), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("Width")) Then
                    width = Trim(CType(dst.Tables(0).Rows(0).Item("Width"), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("Height")) Then
                    heigth = Trim(CType(dst.Tables(0).Rows(0).Item("Heigtht"), String))
                End If
            End If

            dst.Reset()

            str = "select * from CODE_TYPE_SHIP_RELATION where CONTAINER_NO='" & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & "' and CODE_SHIP_OWNER='" & ConTypeOwner & "'" 'and CODE_SHIP_OWNER='YML'"
            dwt = Getdata(str, dst)
            If dwt.Count > 0 Then
                ConType = Trim(dst.Tables(0).Rows(0).Item("CODE_CON_TYPE"))
            Else
                dst.Reset()
                str = "select * from CODE_CON_TYPE where CODE_CON_TYPE='" & ConType & "' and CODE_SHIP_OWNER='" & ConTypeOwner & "'" 'and CODE_SHIP_OWNER='YML'"
                dwt = Getdata(str, dst)
                If dwt.Count > 0 Then
                    ConType = Trim(dst.Tables(0).Rows(0).Item("CODE_SHIP_TYPE"))
                Else
                    ConType = ConType
                End If
            End If

            ''*********************非连云港箱型（2011.10.23外理陶明月要求，非本港箱原进原出，2013年11月14日要求改回）
            'If InStr(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), "LYG") > 0 Then
            'Else
            '    If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeConType")) Then
            '        ConType = Trim(ds.Tables(0).Rows(j).Item("CodeConType"))
            '    End If
            'End If
            '*************LOC + 147 贝位号
            txtline = "LOC+147+" & "0" & ds.Tables(0).Rows(j).Item("BAYNO") & "'"
            sw.WriteLine(txtline)
            i = i + 1
            '**************FTX+AAA货物描述
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("Demo")) Then
                If Len(Trim(ds.Tables(0).Rows(j).Item("Demo"))) > 0 Then
                    txtline = "FTX+AAA+++" & ds.Tables(0).Rows(j).Item("Demo") & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
            End If
            '**************FTX+CLR箱货物描述
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("ConDemo")) Then
                If Len(Trim(ds.Tables(0).Rows(j).Item("ConDemo"))) > 0 Then
                    txtline = "FTX+CLR+++" & ds.Tables(0).Rows(j).Item("ConDemo") & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
            End If
            '*************MEA 货物重量
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("GROSSWEIGHT")) Then
                txtline = "MEA+WT++KGM:" & CType(CType(ds.Tables(0).Rows(j).Item("GrossWeight"), Single), String) & "'"
            Else
                txtline = "MEA+WT++KGM:0000'"
            End If
            sw.WriteLine(txtline)
            i = i + 1
            '******************DIM 超高等
            If Len(Trim(ConOverHeight)) > 0 Or Len(Trim(ConOverLeft)) > 0 Or Len(Trim(ConOverRight)) > 0 Or Len(Trim(ConOverFront)) > 0 Or Len(Trim(ConOverBack)) > 0 Then
                If Len(Trim(ConOverFront)) > 0 Then
                    txtline = "DIM+5+CMT:" & Trim(ConOverFront) & "::'"
                End If
                If Len(Trim(ConOverBack)) > 0 Then
                    txtline = "DIM+6+CMT:" & Trim(ConOverBack) & "::'"
                End If
                If Len(Trim(ConOverRight)) > 0 Then
                    txtline = "DIM+7+CMT::" & Trim(ConOverRight) & ":'"
                End If
                If Len(Trim(ConOverLeft)) > 0 Then
                    txtline = "DIM+8+CMT::" & Trim(ConOverLeft) & ":'"
                End If
                If Len(Trim(ConOverHeight)) > 0 Then
                    txtline = "DIM+9+CMT:::" & Trim(ConOverHeight) & "'"
                End If
                sw.WriteLine(txtline)
                i = i + 1
            Else
                If Len(Trim(length)) > 0 And Len(Trim(width)) > 0 And Len(Trim(heigth)) > 0 Then
                    txtline = "DIM+1+INH:" & Trim(length) & ":" & Trim(width) & ":" & Trim(heigth) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If

            End If
            '*********************冷藏箱
            If (Not IsDBNull(ds.Tables(0).Rows(j).Item("TEMPERATURE_UNIT"))) And (Not IsDBNull(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"))) Then
                If Len(Trim(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"))) > 0 Then
                    txtline = "TMP+2+" & Trim(CType(CType(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"), Single), String)) & ":CEL'"
                    sw.WriteLine(txtline)
                    i = i + 1
                    If Not IsDBNull(ds.Tables(0).Rows(j).Item("MAX_TEMPERATURE")) Then
                        txtline = "RNG+ZZZ+CEL:" & Trim(CType(CType(ds.Tables(0).Rows(j).Item("MIN_TEMPERATURE"), Single), String)) & ":" & Trim(CType(CType(ds.Tables(0).Rows(j).Item("MAX_TEMPERATURE"), Single), String)) & "'"
                    Else
                        txtline = "RNG+ZZZ+CEL:" & Trim(CType(CType(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"), Single), String)) & ":" & Trim(CType(CType(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"), Single), String)) & "'"
                    End If
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
            End If
            If InStr(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), "LYG") > 0 Then

                '************************装货港
                str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), PortOwner) '"CMA")
                If InStr(Trim(str1), ":") <> 6 Then
                    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的装货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Else
                        Exit Sub
                    End If
                End If
                txtline = "LOC+6+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port"))) & "'"
                sw.WriteLine(txtline)
                i = i + 1

                '************************卸货港
                str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")), PortOwner) '"CMA")
                If InStr(Trim(str1), ":") <> 6 Then
                    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的装货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Else
                        Exit Sub
                    End If
                End If
                txtline = "LOC+12+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port"))) & "'"
                sw.WriteLine(txtline)
                i = i + 1

                '************************目的港
                str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")), PortOwner) '"CMA")
                If InStr(Trim(str1), ":") <> 6 Then
                    str1 = FindPortTemp(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")))
                    If InStr(Trim(str1), ":") <> 6 Then
                        If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的目的港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Else
                            Exit Sub
                        End If
                    End If
                End If
                txtline = "LOC+83+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_Delivery"))) & "'"
                sw.WriteLine(txtline)
                i = i + 1
            Else
                '************************装货港
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeLoadPort")) Then
                    '*********************非连云港装港口
                    txtline = "LOC+6+" & Trim(ds.Tables(0).Rows(j).Item("CodeLoadPort")) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                Else

                    str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), PortOwner) '"CMA")
                    'If InStr(Trim(str1), ":") <> 6 Then
                    '    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的装货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    '    Else
                    '        Exit Sub
                    '    End If
                    'End If
                    txtline = "LOC+6+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port"))) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
                '************************卸货港
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeUnLoadPort")) Then
                    '*********************非连云港装港口
                    txtline = "LOC+12+" & Trim(ds.Tables(0).Rows(j).Item("CodeUnLoadPort")) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                Else

                    str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")), PortOwner) '"CMA")
                    'If InStr(Trim(str1), ":") <> 6 Then
                    '    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的装货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    '    Else
                    '        Exit Sub
                    '    End If
                    'End If
                    txtline = "LOC+12+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port"))) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
                '************************目的港
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeDelivery")) Then
                    '*********************非连云港装港口
                    txtline = "LOC+83+" & Trim(ds.Tables(0).Rows(j).Item("CodeDelivery")) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                Else

                    str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")), PortOwner) '"CMA")
                    If InStr(Trim(str1), ":") <> 6 Then
                        str1 = FindPortTemp(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")))
                        'If InStr(Trim(str1), ":") <> 6 Then
                        '    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的目的港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        '    Else
                        '        Exit Sub
                        '    End If
                        'End If
                    End If
                    txtline = "LOC+83+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_Delivery"))) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
            End If

            '***********************提单号
            txtline = "RFF+BM:" & Trim(CType(ds.Tables(0).Rows(j).Item("BLNO"), String)) & "'"
            sw.WriteLine(txtline)
            i = i + 1
            '***********************EQD+CN 箱号 箱型
            ConNo = ds.Tables(0).Rows(j).Item("Container_NO")
            If Len(Trim(ConNo)) = 11 Then
                ConNo = Mid(Trim(ConNo), 1, 4) & " " & Mid(Trim(ConNo), 5, 7)
            End If
            If Mid(UCase(ds.Tables(0).Rows(j).Item("FULLOREMPTY")), 1, 1) = "F" Then
                txtline = "EQD+CN+" & ConNo & "+" & ConType & "+++5'"
            End If
            If Mid(UCase(ds.Tables(0).Rows(j).Item("FULLOREMPTY")), 1, 1) = "E" Then
                txtline = "EQD+CN+" & ConNo & "+" & ConType & "+++4'"
            End If
            If Mid(UCase(ds.Tables(0).Rows(j).Item("FULLOREMPTY")), 1, 1) = "L" Then
                txtline = "EQD+CN+" & ConNo & "+" & ConType & "+++7'"
            End If
            sw.WriteLine(txtline)
            i = i + 1
            '*******************箱经营人
            txtline = "NAD+CA+" & Trim(ConOperatorCode) & ":172:ZZZ'"
            sw.WriteLine(txtline)
            i = i + 1
            '*******************危险品
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("DANGER_GRADE")) Then
                If Len(Trim(ds.Tables(0).Rows(j).Item("DANGER_GRADE"))) > 0 Then
                    txtline = "DGS+IMD+" & Trim(ds.Tables(0).Rows(j).Item("DANGER_GRADE"))
                    If Not IsDBNull(ds.Tables(0).Rows(j).Item("DANGER_PageNO")) Then
                        txtline = txtline & ":" & Trim(CType(ds.Tables(0).Rows(j).Item("DANGER_PageNO"), String))
                    End If
                    If Not IsDBNull(ds.Tables(0).Rows(j).Item("DANGER_NO")) Then
                        txtline = txtline & "+" & Trim(CType(ds.Tables(0).Rows(j).Item("DANGER_NO"), String))
                    End If
                    txtline = txtline & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                    '*********************危险品FTX
                    'txtline = "FTX+AAA+++========'"
                    'sw.WriteLine(txtline)
                    'i = i + 1
                End If

            End If

            j = j + 1
        Loop
        '*************UNT
        i = i + 1
        txtline = "UNT+" & Trim(CType(i, String)) & "+" & tstr & "'"
        sw.WriteLine(txtline)
        txtline = "UNZ+1+" & tstr & "'"
        sw.WriteLine(txtline)
        sw.Close()
        FileCopy(strFile, Mid(strFile, 1, Len(strFile) - 4) + ".TXT")
        MsgBox("生成完成,谢谢! 共生成 " & Trim(CType(i, String)) & " 行报文 共 " & j & " 个箱子")
    End Sub
    Private Sub WriteDF()    '**********************达飞
        Dim txtline As String
        Dim i As Integer = 0 '记录行数
        Dim j As Integer = 0 '取箱信息循环
        Dim str As String
        Dim s As String
        Dim tstr As String '***************时间
        Dim str1 As String
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
        Dim ConOperatorCode As String = "" '箱经营人代码
        Dim ConOperator As String = "" '箱经营人
        Dim length As String
        Dim width As String
        Dim heigth As String
        Dim ConNo As String
        If cbSummary.Checked = False Then
            strFile = txtFile.Text & UCase(txtShipCode.Text) & LVoyage.Text & ".txt"
        Else
            strFile = txtFile.Text & UCase(txtShipCode.Text) & LVoyage.Text & "Sum.txt"
        End If
        File.Delete(strFile)
        Dim sw As New StreamWriter(strFile, FileMode.OpenOrCreate, System.Text.Encoding.Default())  '打开报文文件
        '**************写UNB行
        txtline = "UNB+UNOA:1" & "+COSTACO+" & Trim(cbEmail.SelectedValue) & "+" & Mid(Trim(CType(Year(Now()), String)), 3, 2)
        s = Mid("0" & Trim(CType(Month(Now), String)), Len("0" & Trim(CType(Month(Now), String))) - 1, 2)
        txtline = txtline & s
        s = Mid("0" & Trim(CType(Day(Now), String)), Len("0" & Trim(CType(Day(Now), String))) - 1, 2)
        txtline = txtline & s & ":"
        s = Mid("0" & Trim(CType(Hour(Now), String)), Len("0" & Trim(CType(Hour(Now), String))) - 1, 2)
        txtline = txtline & s
        s = Mid("0" & Trim(CType(Minute(Now), String)), Len("0" & Trim(CType(Minute(Now), String))) - 1, 2)
        txtline = txtline & s & "+"

        tstr = Mid(Trim(CType(Year(Now()), String)), 3, 2) & Mid("0" & Trim(CType(Month(Now), String)), Len("0" & Trim(CType(Month(Now), String))) - 1, 2)
        tstr = tstr & Mid("0" & Trim(CType(Day(Now), String)), Len("0" & Trim(CType(Day(Now), String))) - 1, 2)
        tstr = tstr & Mid("0" & Trim(CType(Hour(Now), String)), Len("0" & Trim(CType(Hour(Now), String))) - 1, 2)
        tstr = tstr & Mid("0" & Trim(CType(Minute(Now), String)), Len("0" & Trim(CType(Minute(Now), String))) - 1, 2)
        txtline = txtline & tstr & "+++++"
        txtline = txtline & LShipOwner.Text & "'"
        sw.WriteLine(txtline)
        i = 0
        '**************写UNH行
        txtline = "UNH+"
        txtline = txtline & tstr & "+BAPLIE:1:911:UN:SMDG15'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************写BGM
        txtline = "BGM++" & tstr & "+9'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************写时间DTM+137
        txtline = "DTM+137:" & tstr & ":201'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************写TDT
        If LSign.Text.Trim().Substring(0, 2).ToUpper() = "UN" Then
            LSign.Text = LSign.Text.Trim().Substring(2)
        End If
        txtline = "TDT+20+" & LVoyage.Text & "++" & LSign.Text & ":103::" & LEnglish.Text & "++" & LShipOwner.Text & ":172:20'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************LOC(1) 装货港
        txtline = "LOC+5+CNLYG'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************LOC(2) 卸货港
        If Len(Trim(LNextPort.Text)) > 0 Then
            str1 = FindPortTemp(Trim(LNextPort.Text))
            txtline = "LOC+61+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(LNextPort.Text)) & "'"
            sw.WriteLine(txtline)
            i = i + 1
        Else
            MsgBox("请在航次记录中选择下一港名称!")
            Exit Sub
        End If
        '******************离港时间
        If Len(Trim(LEndTime.Text)) > 0 Then
            txtline = "DTM+178:" & Trim(LEndTime.Text) & "0000:201'"
            sw.WriteLine(txtline)
            i = i + 1
            txtline = "DTM+136:" & Trim(LEndTime.Text) & "0000:201'"
            sw.WriteLine(txtline)
            i = i + 1
            txtline = "DTM+132:" & Trim(LEndTime.Text) & ":101'"
            sw.WriteLine(txtline)
            i = i + 1
        Else
            txtline = "DTM+178:" & Mid(tstr, 1, 6) & "0000:201'"
            sw.WriteLine(txtline)
            i = i + 1
            txtline = "DTM+136:" & Mid(tstr, 1, 6) & "0000:201'"
            sw.WriteLine(txtline)
            i = i + 1
            txtline = "DTM+132:" & Mid(tstr, 1, 6) & ":101'"
            sw.WriteLine(txtline)
            i = i + 1
        End If
        '******************航次
        txtline = "RFF+VON:" & LVoyage.Text & "'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************开始箱循环
        If cbSummary.Checked = False Then
            sqlstr = "select * from Con_Image where Code_Load_Port  like '%LYG%' and Ship_ID=" & Ship_ID
        Else
            sqlstr = "select * from Con_Image where Ship_ID=" & Ship_ID
        End If
        dw = Getdata(sqlstr, ds)
        PB.Maximum = dw.Count
        PB.Value = 0
        Do While j < dw.Count
            PB.Value = j
            ConType = "" '箱尺寸类型
            ConOverFront = ""  '前超
            ConOverBack = ""  '后超
            ConOverLeft = ""  '左超
            ConOverRight = ""  '右超
            ConOverHeight = ""  '超高
            ConTareWeight = ""  '箱皮重
            ConOperatorCode = ""  '箱经营人代码
            ConOperator = ""  '箱经营人

            If ds.Tables(0).Rows(j).Item("Code_Con_Company") Is System.DBNull.Value Then
                ConOperatorCode = ""
            Else
                ConOperatorCode = UCase(CType(ds.Tables(0).Rows(j).Item("Code_Con_Company"), String))
            End If
            dst.Reset()
            str = "select * from CON_CRITERION where CONTAINER_NO='" & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & "'"
            dwt = Getdata(str, dst)
            If dwt.Count > 0 Then
                ConType = Trim(dst.Tables(0).Rows(0).Item("SIZE_CON")) & Trim(dst.Tables(0).Rows(0).Item("CONTAINER_TYPE"))
                If ConOperatorCode.Trim().Length() = 0 Then
                    ConOperatorCode = Trim(dst.Tables(0).Rows(0).Item("Code_Con_Company"))
                End If
                ConOperator = ""
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("CON_WEIGHT")) Then
                    ConTareWeight = Trim(CType(CType(dst.Tables(0).Rows(0).Item("CON_WEIGHT"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_Height")) Then
                    ConOverHeight = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_Height"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_Left")) Then
                    ConOverLeft = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_Left"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_Right")) Then
                    ConOverRight = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_Right"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_BEFORE")) Then
                    ConOverFront = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_BEFORE"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_BEHIND")) Then
                    ConOverBack = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_BEHIND"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("Length")) Then
                    length = Trim(CType(dst.Tables(0).Rows(0).Item("Length"), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("Width")) Then
                    width = Trim(CType(dst.Tables(0).Rows(0).Item("Width"), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("Height")) Then
                    heigth = Trim(CType(dst.Tables(0).Rows(0).Item("Heigtht"), String))
                End If
            End If

            dst.Reset()

            str = "select * from CODE_TYPE_SHIP_RELATION where CONTAINER_NO='" & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & "' and CODE_SHIP_OWNER='" & ConTypeOwner & "'" 'and CODE_SHIP_OWNER='CMA'"
            dwt = Getdata(str, dst)
            If dwt.Count > 0 Then
                ConType = Trim(dst.Tables(0).Rows(0).Item("CODE_CON_TYPE"))
            Else
                dst.Reset()
                str = "select * from CODE_CON_TYPE where CODE_CON_TYPE='" & ConType & "' and CODE_SHIP_OWNER='" & ConTypeOwner & "'"  'and CODE_SHIP_OWNER='CMA'"
                dwt = Getdata(str, dst)
                If dwt.Count > 0 Then
                    ConType = Trim(dst.Tables(0).Rows(0).Item("CODE_SHIP_TYPE"))
                Else
                    ConType = ConType
                End If
            End If

            ''*********************非连云港箱型（2011.10.23外理陶明月要求，非本港箱原进原出，2013年11月14日要求改回）
            'If InStr(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), "LYG") > 0 Then
            'Else
            '    If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeConType")) Then
            '        ConType = Trim(ds.Tables(0).Rows(j).Item("CodeConType"))
            '    End If
            'End If

            '*************LOC + 147 贝位号
            txtline = "LOC+147+" & "0" & ds.Tables(0).Rows(j).Item("BAYNO") & "'"
            sw.WriteLine(txtline)
            i = i + 1
            '**************FTX+AAA货物描述
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("Demo")) Then
                If Len(Trim(ds.Tables(0).Rows(j).Item("Demo"))) > 0 Then
                    txtline = "FTX+AAA+++" & ds.Tables(0).Rows(j).Item("Demo") & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
            End If
            '**************FTX+CLR箱货物描述
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("ConDemo")) Then
                If Len(Trim(ds.Tables(0).Rows(j).Item("ConDemo"))) > 0 Then
                    txtline = "FTX+CLR+++" & ds.Tables(0).Rows(j).Item("ConDemo") & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
            End If
            '*************MEA 货物重量
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("GROSSWEIGHT")) Then
                txtline = "MEA+WT++KGM:" & CType(CType(ds.Tables(0).Rows(j).Item("GrossWeight"), Single), String) & "'"
            Else
                txtline = "MEA+WT++KGM:0000'"
            End If
            sw.WriteLine(txtline)
            i = i + 1
            '******************DIM 超高等
            If Len(Trim(ConOverHeight)) > 0 Or Len(Trim(ConOverLeft)) > 0 Or Len(Trim(ConOverRight)) > 0 Or Len(Trim(ConOverFront)) > 0 Or Len(Trim(ConOverBack)) > 0 Then
                If Len(Trim(ConOverFront)) > 0 Then
                    txtline = "DIM+5+CMT:" & Trim(ConOverFront) & "::'"
                End If
                If Len(Trim(ConOverBack)) > 0 Then
                    txtline = "DIM+6+CMT:" & Trim(ConOverBack) & "::'"
                End If
                If Len(Trim(ConOverRight)) > 0 Then
                    txtline = "DIM+7+CMT::" & Trim(ConOverRight) & ":'"
                End If
                If Len(Trim(ConOverLeft)) > 0 Then
                    txtline = "DIM+8+CMT::" & Trim(ConOverLeft) & ":'"
                End If
                If Len(Trim(ConOverHeight)) > 0 Then
                    txtline = "DIM+9+CMT:::" & Trim(ConOverHeight) & "'"
                End If
                sw.WriteLine(txtline)
                i = i + 1
            Else
                If Len(Trim(length)) > 0 And Len(Trim(width)) > 0 And Len(Trim(heigth)) > 0 Then
                    txtline = "DIM+1+INH:" & Trim(length) & ":" & Trim(width) & ":" & Trim(heigth) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If

            End If
            '*********************冷藏箱
            If (Not IsDBNull(ds.Tables(0).Rows(j).Item("TEMPERATURE_UNIT"))) And (Not IsDBNull(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"))) Then
                If Len(Trim(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"))) > 0 Then
                    txtline = "TMP+2+" & Trim(CType(CType(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"), Single), String)) & ":CEL'"
                    sw.WriteLine(txtline)
                    i = i + 1
                    If Not IsDBNull(ds.Tables(0).Rows(j).Item("MAX_TEMPERATURE")) Then
                        txtline = "RNG+ZZZ+CEL:" & Trim(CType(CType(ds.Tables(0).Rows(j).Item("MIN_TEMPERATURE"), Single), String)) & ":" & Trim(CType(CType(ds.Tables(0).Rows(j).Item("MAX_TEMPERATURE"), Single), String)) & "'"
                    Else
                        txtline = "RNG+ZZZ+CEL:" & Trim(CType(CType(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"), Single), String)) & ":" & Trim(CType(CType(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"), Single), String)) & "'"
                    End If
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
            End If
            If InStr(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), "LYG") > 0 Then
                '************************装货港
                str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), PortOwner) '"CMA")
                If InStr(Trim(str1), ":") <> 6 Then
                    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的装货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Else
                        Exit Sub
                    End If
                End If
                txtline = "LOC+6+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port"))) & "'"
                sw.WriteLine(txtline)
                i = i + 1

                '************************卸货港
                str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")), PortOwner) '"CMA")
                If InStr(Trim(str1), ":") <> 6 Then
                    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的装货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Else
                        Exit Sub
                    End If
                End If
                txtline = "LOC+12+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port"))) & "'"
                sw.WriteLine(txtline)
                i = i + 1

                '************************目的港
                str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")), PortOwner) '"CMA")
                If InStr(Trim(str1), ":") <> 6 Then
                    str1 = FindPortTemp(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")))
                    If InStr(Trim(str1), ":") <> 6 Then
                        If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的目的港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Else
                            Exit Sub
                        End If
                    End If
                End If
                txtline = "LOC+83+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_Delivery"))) & "'"
                sw.WriteLine(txtline)
                i = i + 1
            Else
                '************************装货港
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeLoadPort")) Then
                    '*********************非连云港装港口
                    txtline = "LOC+6+" & Trim(ds.Tables(0).Rows(j).Item("CodeLoadPort")) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                Else

                    str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), PortOwner) '"CMA")
                    'If InStr(Trim(str1), ":") <> 6 Then
                    '    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的装货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    '    Else
                    '        Exit Sub
                    '    End If
                    'End If
                    txtline = "LOC+6+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port"))) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
                '************************卸货港
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeUnLoadPort")) Then
                    '*********************非连云港装港口
                    txtline = "LOC+12+" & Trim(ds.Tables(0).Rows(j).Item("CodeUnLoadPort")) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                Else
                    str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")), PortOwner) '"CMA")
                    'If InStr(Trim(str1), ":") <> 6 Then
                    '    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的装货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    '    Else
                    '        Exit Sub
                    '    End If
                    'End If
                    txtline = "LOC+12+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port"))) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
                '************************目的港
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeDelivery")) Then
                    '*********************非连云港装港口
                    txtline = "LOC+83+" & Trim(ds.Tables(0).Rows(j).Item("CodeDelivery")) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                Else
                    str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")), PortOwner) '"CMA")
                    If InStr(Trim(str1), ":") <> 6 Then
                        str1 = FindPortTemp(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")))
                        'If InStr(Trim(str1), ":") <> 6 Then
                        '    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的目的港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        '    Else
                        '        Exit Sub
                        '    End If
                        'End If
                    End If
                    txtline = "LOC+83+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_Delivery"))) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
            End If
            '***********************提单号
            txtline = "RFF+BM:" & Trim(CType(ds.Tables(0).Rows(j).Item("BLNO"), String)) & "'"
            sw.WriteLine(txtline)
            i = i + 1
            '***********************EQD+CN 箱号 箱型
            ConNo = ds.Tables(0).Rows(j).Item("Container_NO")
            If Len(Trim(ConNo)) = 11 Then
                ConNo = Mid(Trim(ConNo), 1, 4) & " " & Mid(Trim(ConNo), 5, 7)
            End If
            If Mid(UCase(ds.Tables(0).Rows(j).Item("FULLOREMPTY")), 1, 1) = "F" Then
                txtline = "EQD+CN+" & ConNo & "+" & ConType & "+++5'"
            End If
            If Mid(UCase(ds.Tables(0).Rows(j).Item("FULLOREMPTY")), 1, 1) = "E" Then
                txtline = "EQD+CN+" & ConNo & "+" & ConType & "+++4'"
            End If
            If Mid(UCase(ds.Tables(0).Rows(j).Item("FULLOREMPTY")), 1, 1) = "L" Then
                txtline = "EQD+CN+" & ConNo & "+" & ConType & "+++7'"
            End If
            sw.WriteLine(txtline)
            i = i + 1
            '*******************箱经营人
            txtline = "NAD+CA+" & Trim(ConOperatorCode) & ":172:ZZZ'"
            sw.WriteLine(txtline)
            i = i + 1
            '*******************危险品
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("DANGER_GRADE")) Then
                If Len(Trim(ds.Tables(0).Rows(j).Item("DANGER_GRADE"))) > 0 Then
                    txtline = "DGS+IMD+" & Trim(ds.Tables(0).Rows(j).Item("DANGER_GRADE"))
                    If Not IsDBNull(ds.Tables(0).Rows(j).Item("DANGER_PageNO")) Then
                        txtline = txtline & ":" & Trim(CType(ds.Tables(0).Rows(j).Item("DANGER_PageNO"), String))
                    End If
                    If Not IsDBNull(ds.Tables(0).Rows(j).Item("DANGER_NO")) Then
                        txtline = txtline & "+" & Trim(CType(ds.Tables(0).Rows(j).Item("DANGER_NO"), String))
                    End If
                    txtline = txtline & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                    '*********************危险品FTX
                    'txtline = "FTX+AAA+++========'"
                    'sw.WriteLine(txtline)
                    'i = i + 1
                End If

            End If

            j = j + 1
        Loop
        '*************UNT
        i = i + 1
        txtline = "UNT+" & Trim(CType(i, String)) & "+" & tstr & "'"
        sw.WriteLine(txtline)
        txtline = "UNZ+1+" & tstr & "'"
        sw.WriteLine(txtline)
        sw.Close()
        MsgBox("生成完成,谢谢! 共生成 " & Trim(CType(i, String)) & " 行报文 共 " & j & " 个箱子")
    End Sub
    Private Sub WriteZY()                                '*************************中远
        Dim txtline As String
        Dim i As Integer = 0 '记录行数
        Dim j As Integer = 0 '取箱信息循环
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
        Dim ConOperatorCode As String = "" '箱经营人代码
        Dim ConOperator As String = "" '箱经营人

        If cbSummary.Checked = False Then
            strFile = txtFile.Text & UCase(txtShipCode.Text) & LVoyage.Text & ".txt"
        Else
            strFile = txtFile.Text & UCase(txtShipCode.Text) & LVoyage.Text & "Sum.txt"
        End If
        File.Delete(strFile)
        Dim sw As New StreamWriter(strFile, FileMode.OpenOrCreate, System.Text.Encoding.Default())  '打开报文文件
        '**************写00行
        txtline = "00BAYBAY PLAN            " & "  " & "COSTACO " & Mid(Trim(cbEmail.SelectedValue) & Space(8), 1, 8) & Space(24) & Mid(Trim(CType(Year(Now()), String)), 3, 2)
        s = Mid("0" & Trim(CType(Month(Now), String)), Len("0" & Trim(CType(Month(Now), String))) - 1, 2)
        txtline = txtline & s
        s = Mid("0" & Trim(CType(Day(Now), String)), Len("0" & Trim(CType(Day(Now), String))) - 1, 2)
        txtline = txtline & s
        s = Mid("0" & Trim(CType(Hour(Now), String)), Len("0" & Trim(CType(Hour(Now), String))) - 1, 2)
        txtline = txtline & s
        s = Mid("0" & Trim(CType(Minute(Now), String)), Len("0" & Trim(CType(Minute(Now), String))) - 1, 2)
        txtline = txtline & s
        txtline = txtline & "LCNLYG" & Space(20) & "COSTACO " & "CNLYG" & "1.2" & Space(9)
        sw.WriteLine(txtline)
        i = 1
        '**************写11行
        txtline = "11        " & UCase(Mid(Trim(txtShipCode.Text) & Space(6), 1, 6)) & UCase(Mid(Trim(LEnglish.Text) & Space(20), 1, 20)) & Mid(LVoyage.Text & Space(6), 1, 6)
        txtline = txtline & Space(86)
        sw.WriteLine(txtline)
        i = i + 1
        '**************开始箱循环
        If cbSummary.Checked = False Then
            sqlstr = "select * from Con_Image where Code_Load_Port  like '%LYG%' and Ship_ID=" & Ship_ID
        Else
            sqlstr = "select * from Con_Image where Ship_ID=" & Ship_ID
        End If
        dw = Getdata(sqlstr, ds)

        PB.Maximum = dw.Count
        PB.Value = 0
        Do While j < dw.Count
            PB.Value = j
            ConType = "" '箱尺寸类型
            ConOverFront = ""  '前超
            ConOverBack = ""  '后超
            ConOverLeft = ""  '左超
            ConOverRight = ""  '右超
            ConOverHeight = ""  '超高
            ConTareWeight = ""  '箱皮重
            ConOperatorCode = ""  '箱经营人代码
            ConOperator = ""  '箱经营人
            If ds.Tables(0).Rows(j).Item("Code_Con_Company") Is System.DBNull.Value Then
                ConOperatorCode = ""
            Else
                ConOperatorCode = UCase(CType(ds.Tables(0).Rows(j).Item("Code_Con_Company"), String))
            End If
            dst.Reset()
            str = "select * from CON_CRITERION where CONTAINER_NO='" & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & "'"
            dwt = Getdata(str, dst)
            If dwt.Count > 0 Then
                ConType = Trim(dst.Tables(0).Rows(0).Item("SIZE_CON")) & Trim(dst.Tables(0).Rows(0).Item("CONTAINER_TYPE"))
                If ConOperatorCode.Trim().Length() = 0 Then
                    ConOperatorCode = Trim(dst.Tables(0).Rows(0).Item("Code_Con_Company"))
                End If
                ConOperator = ""
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("CON_WEIGHT")) Then
                    ConTareWeight = Trim(CType(CType(dst.Tables(0).Rows(0).Item("CON_WEIGHT"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_Height")) Then
                    ConOverHeight = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_Height"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_Left")) Then
                    ConOverLeft = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_Left"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_Right")) Then
                    ConOverRight = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_Right"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_BEFORE")) Then
                    ConOverFront = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_BEFORE"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_BEHIND")) Then
                    ConOverBack = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_BEHIND"), Single), String))
                End If

            End If

            dst.Reset()

            str = "select * from CODE_TYPE_SHIP_RELATION where CONTAINER_NO='" & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & "' and CODE_SHIP_OWNER='" & ConTypeOwner & "'" 'and CODE_SHIP_OWNER='COSCO'"
            dwt = Getdata(str, dst)
            If dwt.Count > 0 Then
                ConType = Trim(dst.Tables(0).Rows(0).Item("CODE_CON_TYPE"))
            Else
                dst.Reset()
                str = "select * from CODE_CON_TYPE where CODE_CON_TYPE='" & ConType & "' and CODE_SHIP_OWNER='" & ConTypeOwner & "'" 'and CODE_SHIP_OWNER='COSCO'"
                dwt = Getdata(str, dst)
                dwt = Getdata(str, dst)
                If dwt.Count > 0 Then
                    ConType = Trim(dst.Tables(0).Rows(0).Item("CODE_SHIP_TYPE"))
                Else
                    ConType = Mid("    " & ConType, Len("    " & ConType) - 3, 4)
                End If
            End If

            '*********************非连云港箱型
            If InStr(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), "LYG") > 0 Then
            Else
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeConType")) Then
                    ConType = Trim(ds.Tables(0).Rows(j).Item("CodeConType"))
                End If
            End If
            '*************51
            txtline = "51" & IIf(Len(UCase(ds.Tables(0).Rows(j).Item("Container_No"))) <> 12, Mid(UCase(ds.Tables(0).Rows(j).Item("Container_No") & Space(11)), 1, 11), Mid(UCase(ds.Tables(0).Rows(j).Item("Container_No")), 1, 4) & Mid(UCase(ds.Tables(0).Rows(j).Item("Container_No")), 6, 7))
            dst.Reset()

            txtline = txtline & ConType
            txtline = txtline & UCase(ds.Tables(0).Rows(j).Item("FULLOREMPTY"))

            txtline = txtline & "2" & Mid(Trim(CType(ds.Tables(0).Rows(j).Item("BLNO"), String)) + Space(16), 1, 16)



            Dim str1 As String
            If InStr(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), "LYG") > 0 Then
                str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), ConTypeOwner) ' "COSCO")
                If InStr(Trim(str1), ":") <> 6 Then
                    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的装货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Else
                        Exit Sub
                    End If
                End If
                txtline = txtline & Mid(IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port"))) & Space(5), 1, 5)
                str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")), ConTypeOwner) ' "COSCO")
                If InStr(Trim(str1), ":") <> 6 Then
                    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的卸货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Else
                        Exit Sub
                    End If
                End If
                txtline = txtline & Mid(IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port"))) & Space(5), 1, 5)
                txtline = txtline & Space(10)
                str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")), ConTypeOwner) ' "COSCO")
                If InStr(Trim(str1), ":") <> 6 Then
                    str1 = FindPortTemp(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")))
                    If InStr(Trim(str1), ":") <> 6 Then
                        If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的目的港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Else
                            Exit Sub
                        End If
                    End If
                End If
                txtline = txtline & Mid(IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_Delivery"))) & Space(5), 1, 5)

            Else
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeLoadPort")) Then
                    '*********************非连云港装港口
                    txtline = txtline & Mid(Trim(ds.Tables(0).Rows(j).Item("CodeLoadPort")) & Space(5), 1, 5)
                Else

                    str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), ConTypeOwner) ' "COSCO")
                    'If InStr(Trim(str1), ":") <> 6 Then
                    '    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的装货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    '    Else
                    '        Exit Sub
                    '    End If
                    'End If
                    txtline = txtline & Mid(IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port"))) & Space(5), 1, 5)
                End If
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeUnLoadPort")) Then
                    '*********************非连云港装港口
                    txtline = txtline & Mid(Trim(ds.Tables(0).Rows(j).Item("CodeUnLoadPort")) & Space(5), 1, 5)
                    txtline = txtline & Space(10)
                Else
                    str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")), ConTypeOwner) ' "COSCO")
                    'If InStr(Trim(str1), ":") <> 6 Then
                    '    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的卸货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    '    Else
                    '        Exit Sub
                    '    End If
                    'End If
                    txtline = txtline & Mid(IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port"))) & Space(5), 1, 5)
                    txtline = txtline & Space(10)
                End If
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeDelivery")) Then
                    '*********************非连云港装港口
                    txtline = txtline & Mid(Trim(ds.Tables(0).Rows(j).Item("CodeDelivery")) & Space(5), 1, 5)
                Else
                    str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")), ConTypeOwner) ' "COSCO")
                    If InStr(Trim(str1), ":") <> 6 Then
                        str1 = FindPortTemp(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")))
                        'If InStr(Trim(str1), ":") <> 6 Then
                        '    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的目的港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        '    Else
                        '        Exit Sub
                        '    End If
                        'End If
                    End If
                    txtline = txtline & Mid(IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_Delivery"))) & Space(5), 1, 5)
                End If
            End If


            txtline = txtline & "0" & ds.Tables(0).Rows(j).Item("BAYNO")

            If Not IsDBNull(ds.Tables(0).Rows(j).Item("TEMPERATURE_UNIT")) Then
                txtline = txtline & Mid(UCase(ds.Tables(0).Rows(j).Item("TEMPERATURE_UNIT")) & Space(1), 1, 1)
            Else
                txtline = txtline & " "
            End If

            If Not IsDBNull(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING")) Then
                If Mid(Trim(CType(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"), String)), 1, 1) <> "+" And Mid(Trim(CType(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"), String)), 1, 1) <> "-" Then
                    txtline = txtline & "+"
                    txtline = txtline & Mid(Trim(CType(CType(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"), Single) * 10, String)) & Space(3), 1, 3)
                    txtline = txtline & "+"
                    txtline = txtline & Mid(Trim(CType(CType(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"), Single) * 10, String)) & Space(3), 1, 3)
                Else
                    txtline = txtline & Mid(Trim(CType(CType(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"), Single) * 10, String)) & Space(4), 1, 4)
                    txtline = txtline & Mid(Trim(CType(CType(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"), Single) * 10, String)) & Space(4), 1, 4)

                End If
            Else
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("MAX_TEMPERATURE")) Then
                    If Mid(Trim(CType(ds.Tables(0).Rows(j).Item("MAX_TEMPERATURE"), String)), 1, 1) <> "+" And Mid(Trim(CType(ds.Tables(0).Rows(j).Item("MAX_TEMPERATURE"), String)), 1, 1) <> "-" Then
                        txtline = txtline & "+"
                        txtline = txtline & Mid(Trim(CType(CType(ds.Tables(0).Rows(j).Item("MAX_TEMPERATURE"), Single) * 10, String)) & Space(3), 1, 3)
                    Else
                        txtline = txtline & Mid(Trim(CType(CType(ds.Tables(0).Rows(j).Item("MAX_TEMPERATURE"), Single) * 10, String)) & Space(4), 1, 4)
                    End If
                Else
                    txtline = txtline & "    "
                End If

                If Not IsDBNull(ds.Tables(0).Rows(j).Item("MIN_TEMPERATURE")) Then
                    If Mid(Trim(CType(ds.Tables(0).Rows(j).Item("MIN_TEMPERATURE"), String)), 1, 1) <> "+" And Mid(Trim(CType(ds.Tables(0).Rows(j).Item("MIN_TEMPERATURE"), String)), 1, 1) <> "-" Then
                        txtline = txtline & "+"
                        txtline = txtline & Mid(Trim(CType(CType(ds.Tables(0).Rows(j).Item("MIN_TEMPERATURE"), Single) * 10, String)) & Space(3), 1, 3)
                    Else
                        txtline = txtline & Mid(Trim(CType(CType(ds.Tables(0).Rows(j).Item("MIN_TEMPERATURE"), Single) * 10, String)) & Space(4), 1, 4)
                    End If

                Else
                    txtline = txtline & "    "
                End If
            End If
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("DANGER_GRADE")) Then
                If Len(Trim(ds.Tables(0).Rows(j).Item("DANGER_GRADE"))) > 0 Then
                    txtline = txtline & "Y"
                Else
                    txtline = txtline & "N"
                End If
            Else
                txtline = txtline & "N"
            End If


            txtline = txtline & Mid(ConOverFront & Space(3), 1, 3)
            txtline = txtline & Mid(ConOverBack & Space(3), 1, 3)
            txtline = txtline & Mid(ConOverLeft & Space(3), 1, 3)
            txtline = txtline & Mid(ConOverRight & Space(3), 1, 3)
            txtline = txtline & Mid(ConOverHeight & Space(3), 1, 3)
            txtline = txtline & Space(12)
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("GROSSWEIGHT")) Then
                txtline = txtline & Mid("000000" & Trim(CType(CType(ds.Tables(0).Rows(j).Item("GROSSWEIGHT"), Single), String)), Len("000000" & Trim(CType(CType(ds.Tables(0).Rows(j).Item("GROSSWEIGHT"), Single), String))) - 5, 6)
            Else
                txtline = txtline & "      "
            End If
            sw.WriteLine(txtline)
            i = i + 1

            '************52

            If Not IsDBNull(ds.Tables(0).Rows(j).Item("DANGER_GRADE")) Then
                If Len(Trim(ds.Tables(0).Rows(j).Item("DANGER_GRADE"))) > 0 Then
                    txtline = "52" & IIf(Len(UCase(ds.Tables(0).Rows(j).Item("Container_No"))) = 11, UCase(ds.Tables(0).Rows(j).Item("Container_No")), Mid(UCase(ds.Tables(0).Rows(j).Item("Container_No")), 1, 4) & Mid(UCase(ds.Tables(0).Rows(j).Item("Container_No")), 6, 7))
                    txtline = txtline & Space(5) & Mid(Trim(ds.Tables(0).Rows(j).Item("DANGER_GRADE")) & Space(7), 1, 7) & Mid(Trim(ds.Tables(0).Rows(j).Item("DANGER_PageNo")) & Space(7), 1, 7) & Mid(Trim(ds.Tables(0).Rows(j).Item("DANGER_No")) & Space(4), 1, 4)

                    txtline = txtline & Space(41)
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
            End If

            j = j + 1
        Loop
        '*************99
        txtline = "99BAY" & Mid("000000" & Trim(CType(i + 1, String)), Len("000000" & Trim(CType(i + 1, String))) - 5, 6) & Space(117)
        sw.WriteLine(txtline)
        sw.Close()
        MsgBox("生成完成,谢谢! 共生成 " & Trim(CType(i + 1, String)) & " 行报文 共 " & j & " 个箱子")
    End Sub


    Private Sub WriteJT()                                           '******************************************中海
        Dim txtLine As String
        Dim i As Integer = 0 '记录行数
        Dim j As Integer = 0 '取箱信息循环
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
        Dim ConOperatorCode As String = "" '箱经营人代码
        Dim ConOperator As String = "" '箱经营人

        If cbSummary.Checked = False Then
            strFile = txtFile.Text & UCase(txtShipCode.Text) & LVoyage.Text & ".txt"
        Else
            strFile = txtFile.Text & UCase(txtShipCode.Text) & LVoyage.Text & "Sum.txt"
        End If
        File.Delete(strFile)
        Dim sw As New StreamWriter(strFile, FileMode.OpenOrCreate, System.Text.Encoding.Default())  '打开报文文件

        '**************写00行
        txtLine = "00:BAPLIE:BAYPLAN:9:LYGWL:" & Trim(cbEmail.SelectedValue) & ":" & Trim(CType(Year(Now), String))
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
        txtLine = "10:" & UCase(Trim(txtShipCode.Text)) & ":" & UCase(Trim(LEnglish.Text)) & "::" & LVoyage.Text & "::::::::'"
        sw.WriteLine(txtLine)
        '************写11
        txtLine = "11:" & UCase(LShipOwner.Text) & ":" & UCase(LShipCompany.Text) & "'"
        sw.WriteLine(txtLine)
        i = 3
        If cbSummary.Checked = False Then
            sqlstr = "select * from Con_Image where Code_Load_Port  like '%LYG%' and Ship_ID=" & Ship_ID
        Else
            sqlstr = "select * from Con_Image where Ship_ID=" & Ship_ID
        End If
        dw = Getdata(sqlstr, ds)

        PB.Maximum = dw.Count
        PB.Value = 0
        ConOperatorCode = ""
        Do While j < dw.Count
            PB.Value = j
            ConType = "" '箱尺寸类型
            ConOverFront = ""  '前超
            ConOverBack = ""  '后超
            ConOverLeft = ""  '左超
            ConOverRight = ""  '右超
            ConOverHeight = ""  '超高
            ConTareWeight = ""  '箱皮重
            ConOperatorCode = ""  '箱经营人代码
            ConOperator = ""  '箱经营人
            If ds.Tables(0).Rows(j).Item("Code_Con_Company") Is System.DBNull.Value Then
                ConOperatorCode = ""
            Else
                ConOperatorCode = UCase(CType(ds.Tables(0).Rows(j).Item("Code_Con_Company"), String))
            End If
            dst.Reset()
            str = "select * from CON_CRITERION where CONTAINER_NO='" & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & "'"
            dwt = Getdata(str, dst)
            If dwt.Count > 0 Then
                ConType = Trim(dst.Tables(0).Rows(0).Item("SIZE_CON")) & Trim(dst.Tables(0).Rows(0).Item("CONTAINER_TYPE"))
                If ConOperatorCode.Trim().Length() = 0 Then
                    ConOperatorCode = Trim(dst.Tables(0).Rows(0).Item("Code_Con_Company"))
                End If
                ConOperator = ""
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("CON_WEIGHT")) Then
                    ConTareWeight = Trim(CType(CType(dst.Tables(0).Rows(0).Item("CON_WEIGHT"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_Height")) Then
                    ConOverHeight = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_Height"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_Left")) Then
                    ConOverLeft = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_Left"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_Right")) Then
                    ConOverRight = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_Right"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_BEFORE")) Then
                    ConOverFront = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_BEFORE"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_BEHIND")) Then
                    ConOverBack = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_BEHIND"), Single), String))
                End If

            End If
            dst.Reset()
            str = "select * from CODE_TYPE_SHIP_RELATION where CONTAINER_NO='" & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & "' and CODE_SHIP_OWNER='" & ConTypeOwner & "'" 'and CODE_SHIP_OWNER='CSC'"
            dwt = Getdata(str, dst)
            If dwt.Count > 0 Then
                ConType = Trim(dst.Tables(0).Rows(0).Item("CODE_CON_TYPE"))
            Else
                dst.Reset()
                str = "select * from CODE_CON_TYPE where CODE_CON_TYPE='" & ConType & "' and CODE_SHIP_OWNER='" & ConTypeOwner & "'" ' and CODE_SHIP_OWNER='CSC'"
                dwt = Getdata(str, dst)
                If dwt.Count > 0 Then
                    ConType = Trim(dst.Tables(0).Rows(0).Item("CODE_SHIP_TYPE"))
                Else
                    ConType = ConType
                End If
            End If
            '*********************非连云港箱型
            If InStr(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), "LYG") > 0 Then
            Else
                If Not (ds.Tables(0).Rows(j).Item("CodeConType") Is System.DBNull.Value) Then

                    If Trim(ds.Tables(0).Rows(j).Item("CodeConType")).Length() > 0 Then
                        ConType = Trim(ds.Tables(0).Rows(j).Item("CodeConType"))
                    End If
                Else
                    MsgBox(ds.Tables(0).Rows(j).Item("Container_No"))
                End If
            End If

            '*************50
            txtLine = "50:" & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & ":"
            dst.Reset()

            txtLine = txtLine & ConType & ":"
            txtLine = txtLine & UCase(ds.Tables(0).Rows(j).Item("FULLOREMPTY")) & ":"
            txtLine = txtLine & "0" & ds.Tables(0).Rows(j).Item("BAYNO") & ":"
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("TEMPERATURE_UNIT")) Then
                txtLine = txtLine & UCase(ds.Tables(0).Rows(j).Item("TEMPERATURE_UNIT")) & ":"
            Else
                txtLine = txtLine & ":"
            End If
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING")) Then
                txtLine = txtLine & Trim(CType(CType(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"), Single), String)) & ":"
            Else
                txtLine = txtLine & ":"
            End If

            If Not IsDBNull(ds.Tables(0).Rows(j).Item("MIN_TEMPERATURE")) Then
                txtLine = txtLine & Trim(CType(CType(ds.Tables(0).Rows(j).Item("MIN_TEMPERATURE"), Single), String)) & ":"
            Else
                txtLine = txtLine & ":"
            End If
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("MAX_TEMPERATURE")) Then
                txtLine = txtLine & Trim(CType(CType(ds.Tables(0).Rows(j).Item("MAX_TEMPERATURE"), Single), String)) & ":"
            Else
                txtLine = txtLine & ":"
            End If
            txtLine = txtLine & ConOverFront & ":"
            txtLine = txtLine & ConOverBack & ":"
            txtLine = txtLine & ConOverLeft & ":"
            txtLine = txtLine & ConOverRight & ":"
            txtLine = txtLine & ConOverHeight & ":"

            If Not IsDBNull(ds.Tables(0).Rows(j).Item("GROSSWEIGHT")) Then
                txtLine = txtLine & Trim(CType(CType(ds.Tables(0).Rows(j).Item("GROSSWEIGHT"), Single), String)) & ":"
            Else
                txtLine = txtLine & ":"
            End If
            txtLine = txtLine & ConTareWeight & ":"
            txtLine = txtLine & ConOperatorCode & ":"
            txtLine = txtLine & ConOperator & "'"
            sw.WriteLine(txtLine)
            i = i + 1
            '*************51
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("BLNO")) Then
                txtLine = "51:"
                txtLine = txtLine & Trim(CType(ds.Tables(0).Rows(j).Item("BLNO"), String)) & "'"
                sw.WriteLine(txtLine)
                i = i + 1
            End If
            '************52
            txtLine = "52:"

            Dim str1 As String
            If InStr(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), "LYG") > 0 Then
                str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), PortOwner) '"CSC")
                If InStr(Trim(str1), ":") <> 6 Then
                    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的装货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Else
                        Exit Sub
                    End If
                End If
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("Load_Port")) Then
                    txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Load_Port"))) & ":"
                Else
                    txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port"))) & ":"
                End If

                str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")), PortOwner) '"CSC")
                If InStr(Trim(str1), ":") <> 6 Then
                    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的卸货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Else
                        Exit Sub
                    End If
                End If
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("unLoad_Port")) Then
                    txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")) & ":" & Trim(ds.Tables(0).Rows(j).Item("unLoad_Port"))) & ":"
                Else
                    txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port"))) & ":"
                End If
                If (Not IsDBNull(ds.Tables(0).Rows(j).Item("Code_Delivery"))) And (Len(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery"))) > 0) Then
                    str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")), PortOwner) '"CSC")
                    If InStr(Trim(str1), ":") <> 6 Then
                        str1 = FindPortTemp(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")))
                        If InStr(Trim(str1), ":") <> 6 Then
                            If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的目的港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            Else
                                Exit Sub
                            End If
                        End If
                    End If
                    If Not IsDBNull(ds.Tables(0).Rows(j).Item("Delivery")) Then
                        txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Delivery")))
                    Else
                        txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")))

                    End If
                Else
                    txtLine = txtLine & ":"
                End If
                txtLine = txtLine & "'"
                sw.WriteLine(txtLine)
            Else
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeLoadPort")) Then
                    If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeLoadPort")) Then
                        '*********************非连云港装港口
                        If Not IsDBNull(ds.Tables(0).Rows(j).Item("Load_Port")) Then
                            txtLine = txtLine & Trim(ds.Tables(0).Rows(j).Item("CodeLoadPort")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Load_Port")) & ":"
                        Else
                            txtLine = txtLine & Trim(ds.Tables(0).Rows(j).Item("CodeLoadPort")) & ":" & Trim(ds.Tables(0).Rows(j).Item("CodeLoadPort")) & ":"
                        End If
                    Else

                        str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), PortOwner) '"CSC")
                        'If InStr(Trim(str1), ":") <> 6 Then
                        '    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的装货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        '    Else
                        '        Exit Sub
                        '    End If
                        'End If
                        If Not IsDBNull(ds.Tables(0).Rows(j).Item("Load_Port")) Then
                            txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Load_Port"))) & ":"
                        Else
                            txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port"))) & ":"
                        End If
                    End If
                Else
                    str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), PortOwner) '"CSC")
                    'If InStr(Trim(str1), ":") <> 6 Then
                    '    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的装货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    '    Else
                    '        Exit Sub
                    '    End If
                    'End If
                    If Not IsDBNull(ds.Tables(0).Rows(j).Item("Load_Port")) Then
                        txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Load_Port"))) & ":"
                    Else
                        txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port"))) & ":"
                    End If
                End If
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeUnLoadPort")) Then
                    If Trim(ds.Tables(0).Rows(j).Item("CodeUnLoadPort")).Length() > 0 Then
                        '*********************非连云港装港口
                        If Not IsDBNull(ds.Tables(0).Rows(j).Item("UnLoad_Port")) Then
                            txtLine = txtLine & Trim(ds.Tables(0).Rows(j).Item("CodeUnLoadPort")) & ":" & Trim(ds.Tables(0).Rows(j).Item("UnLoad_Port")) & ":"
                        Else
                            txtLine = txtLine & Trim(ds.Tables(0).Rows(j).Item("CodeUnLoadPort")) & ":" & Trim(ds.Tables(0).Rows(j).Item("CodeUnLoadPort")) & ":"
                        End If
                    Else
                        str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")), PortOwner) '"CSC")
                        'If InStr(Trim(str1), ":") <> 6 Then
                        '    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的卸货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        '    Else
                        '        Exit Sub
                        '    End If
                        'End If
                        If Not IsDBNull(ds.Tables(0).Rows(j).Item("unLoad_Port")) Then
                            txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")) & ":" & Trim(ds.Tables(0).Rows(j).Item("unLoad_Port"))) & ":"
                        Else
                            txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port"))) & ":"
                        End If
                    End If
                Else
                    str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")), PortOwner) '"CSC")
                    'If InStr(Trim(str1), ":") <> 6 Then
                    '    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的卸货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    '    Else
                    '        Exit Sub
                    '    End If
                    'End If
                    If Not IsDBNull(ds.Tables(0).Rows(j).Item("unLoad_Port")) Then
                        txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")) & ":" & Trim(ds.Tables(0).Rows(j).Item("unLoad_Port"))) & ":"
                    Else
                        txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port"))) & ":"
                    End If
                End If
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeDelivery")) Then
                    If Trim(ds.Tables(0).Rows(j).Item("CodeDelivery")).Length() > 0 Then
                        '*********************非连云港装港口
                        If Not IsDBNull(ds.Tables(0).Rows(j).Item("Delivery")) Then
                            txtLine = txtLine & Trim(ds.Tables(0).Rows(j).Item("CodeDelivery")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Delivery")) & ":"
                        Else
                            txtLine = txtLine & Trim(ds.Tables(0).Rows(j).Item("CodeDelivery")) & ":" & Trim(ds.Tables(0).Rows(j).Item("CodeDelivery")) & ":"
                        End If
                    Else
                        If (Not IsDBNull(ds.Tables(0).Rows(j).Item("Code_Delivery"))) And (Len(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery"))) > 0) Then
                            str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")), PortOwner) '"CSC")
                            If InStr(Trim(str1), ":") <> 6 Then
                                str1 = FindPortTemp(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")))
                                'If InStr(Trim(str1), ":") <> 6 Then
                                '    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的目的港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                '    Else
                                '        Exit Sub
                                '    End If
                                'End If
                            End If
                            If Not IsDBNull(ds.Tables(0).Rows(j).Item("Delivery")) Then
                                txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Delivery")))
                            Else
                                txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")))

                            End If
                        Else
                            txtLine = txtLine & ":"
                        End If
                    End If
                Else
                    If (Not IsDBNull(ds.Tables(0).Rows(j).Item("Code_Delivery"))) And (Len(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery"))) > 0) Then
                        str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")), PortOwner) '"CSC")
                        If InStr(Trim(str1), ":") <> 6 Then
                            str1 = FindPortTemp(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")))
                            'If InStr(Trim(str1), ":") <> 6 Then
                            '    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的目的港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            '    Else
                            '        Exit Sub
                            '    End If
                            'End If
                        End If
                        If Not IsDBNull(ds.Tables(0).Rows(j).Item("Delivery")) Then
                            txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Delivery")))
                        Else
                            txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")))

                        End If
                    Else
                        txtLine = txtLine & ":"
                    End If
                End If
                txtLine = txtLine & "'"
                sw.WriteLine(txtLine)
            End If

            i = i + 1
            '*************54  其中53省去
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("DANGER_GRADE")) Then
                If Len(Trim(ds.Tables(0).Rows(j).Item("DANGER_GRADE"))) > 0 Then
                    txtLine = "54:" & Trim(ds.Tables(0).Rows(j).Item("DANGER_GRADE")) & ":"
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

            j = j + 1
        Loop
        txtLine = "99:" & Trim(CType(i + 1, String)) & "'"
        sw.WriteLine(txtLine)
        sw.Close()
        MsgBox("生成完成,谢谢! 共生成 " & Trim(CType(i + 1, String)) & " 行报文 共 " & j & " 个箱子")
    End Sub
    Private Sub WriteWYZH()                                           '******************************************外运中海
        Dim txtLine As String
        Dim i As Integer = 0 '记录行数
        Dim j As Integer = 0 '取箱信息循环
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
        Dim ConOperatorCode As String = "" '箱经营人代码
        Dim ConOperator As String = "" '箱经营人

        If cbSummary.Checked = False Then
            strFile = txtFile.Text & UCase(txtShipCode.Text) & LVoyage.Text & ".txt"
        Else
            strFile = txtFile.Text & UCase(txtShipCode.Text) & LVoyage.Text & "Sum.txt"
        End If
        File.Delete(strFile)
        Dim sw As New StreamWriter(strFile, FileMode.OpenOrCreate, System.Text.Encoding.Default())  '打开报文文件

        '**************写00行
        txtLine = "00:BAPLIE:BAYPLAN:9:LYGWL:" & Trim(cbEmail.SelectedValue) & ":" & Trim(CType(Year(Now), String))
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
        txtLine = "10:" & UCase(Trim(txtShipCode.Text)) & ":" & UCase(Trim(LEnglish.Text)) & "::" & LVoyage.Text & "::::::::'"
        sw.WriteLine(txtLine)
        '************写11
        txtLine = "11:" & UCase(LShipOwner.Text) & ":" & UCase(LShipCompany.Text) & "'"
        sw.WriteLine(txtLine)
        i = 3
        If cbSummary.Checked = False Then
            sqlstr = "select * from Con_Image where Code_Load_Port  like '%LYG%' and Ship_ID=" & Ship_ID
        Else
            sqlstr = "select * from Con_Image where Ship_ID=" & Ship_ID
        End If
        dw = Getdata(sqlstr, ds)

        PB.Maximum = dw.Count
        PB.Value = 0
        Do While j < dw.Count
            PB.Value = j
            ConType = "" '箱尺寸类型
            ConOverFront = ""  '前超
            ConOverBack = ""  '后超
            ConOverLeft = ""  '左超
            ConOverRight = ""  '右超
            ConOverHeight = ""  '超高
            ConTareWeight = ""  '箱皮重
            ConOperatorCode = ""  '箱经营人代码
            ConOperator = ""  '箱经营人

            If ds.Tables(0).Rows(j).Item("Code_Con_Company") Is System.DBNull.Value Then
                ConOperatorCode = ""
            Else
                ConOperatorCode = UCase(CType(ds.Tables(0).Rows(j).Item("Code_Con_Company"), String))
            End If
            dst.Reset()
            str = "select * from CON_CRITERION where CONTAINER_NO='" & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & "'"
            dwt = Getdata(str, dst)
            If dwt.Count > 0 Then
                ConType = Trim(dst.Tables(0).Rows(0).Item("SIZE_CON")) & Trim(dst.Tables(0).Rows(0).Item("CONTAINER_TYPE"))
                If ConOperatorCode.Trim().Length() = 0 Then
                    ConOperatorCode = Trim(dst.Tables(0).Rows(0).Item("Code_Con_Company"))
                End If
                ConOperator = ""
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("CON_WEIGHT")) Then
                    ConTareWeight = Trim(CType(CType(dst.Tables(0).Rows(0).Item("CON_WEIGHT"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_Height")) Then
                    ConOverHeight = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_Height"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_Left")) Then
                    ConOverLeft = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_Left"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_Right")) Then
                    ConOverRight = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_Right"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_BEFORE")) Then
                    ConOverFront = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_BEFORE"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_BEHIND")) Then
                    ConOverBack = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_BEHIND"), Single), String))
                End If

            End If
            dst.Reset()
            str = "select * from CODE_TYPE_SHIP_RELATION where CONTAINER_NO='" & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & "' and CODE_SHIP_OWNER='" & ConTypeOwner & "'" 'and CODE_SHIP_OWNER='COSW'"
            dwt = Getdata(str, dst)
            If dwt.Count > 0 Then
                ConType = Trim(dst.Tables(0).Rows(0).Item("CODE_CON_TYPE"))
            Else
                dst.Reset()
                str = "select * from CODE_CON_TYPE where CODE_CON_TYPE='" & ConType & "' and CODE_SHIP_OWNER='" & ConTypeOwner & "'" 'and CODE_SHIP_OWNER='COSW'"
                dwt = Getdata(str, dst)
                If dwt.Count > 0 Then
                    ConType = Trim(dst.Tables(0).Rows(0).Item("CODE_SHIP_TYPE"))
                Else
                    ConType = ConType
                End If
            End If
            '*********************非连云港箱型
            If InStr(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), "LYG") > 0 Then
            Else
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeConType")) Then
                    ConType = Trim(ds.Tables(0).Rows(j).Item("CodeConType"))
                End If
            End If
            '*************50
            txtLine = "50:" & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & ":"
            dst.Reset()

            txtLine = txtLine & ConType & ":"
            txtLine = txtLine & UCase(ds.Tables(0).Rows(j).Item("FULLOREMPTY")) & ":"
            txtLine = txtLine & "0" & ds.Tables(0).Rows(j).Item("BAYNO") & ":"
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("TEMPERATURE_UNIT")) Then
                txtLine = txtLine & UCase(ds.Tables(0).Rows(j).Item("TEMPERATURE_UNIT")) & ":"
            Else
                txtLine = txtLine & ":"
            End If
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING")) Then
                txtLine = txtLine & Trim(CType(CType(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"), Single), String)) & ":"
            Else
                txtLine = txtLine & ":"
            End If

            If Not IsDBNull(ds.Tables(0).Rows(j).Item("MIN_TEMPERATURE")) Then
                txtLine = txtLine & Trim(CType(CType(ds.Tables(0).Rows(j).Item("MIN_TEMPERATURE"), Single), String)) & ":"
            Else
                txtLine = txtLine & ":"
            End If
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("MAX_TEMPERATURE")) Then
                txtLine = txtLine & Trim(CType(CType(ds.Tables(0).Rows(j).Item("MAX_TEMPERATURE"), Single), String)) & ":"
            Else
                txtLine = txtLine & ":"
            End If
            txtLine = txtLine & ConOverFront & ":"
            txtLine = txtLine & ConOverBack & ":"
            txtLine = txtLine & ConOverLeft & ":"
            txtLine = txtLine & ConOverRight & ":"
            txtLine = txtLine & ConOverHeight & ":"

            If Not IsDBNull(ds.Tables(0).Rows(j).Item("GROSSWEIGHT")) Then
                txtLine = txtLine & Trim(CType(CType(ds.Tables(0).Rows(j).Item("GROSSWEIGHT"), Single), String)) & ":"
            Else
                txtLine = txtLine & ":"
            End If
            txtLine = txtLine & ConTareWeight & ":"
            txtLine = txtLine & ConOperatorCode & ":"
            txtLine = txtLine & ConOperator & "'"
            sw.WriteLine(txtLine)
            i = i + 1
            '*************51
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("BLNO")) Then
                txtLine = "51:"
                txtLine = txtLine & Trim(CType(ds.Tables(0).Rows(j).Item("BLNO"), String)) & "'"
                sw.WriteLine(txtLine)
                i = i + 1
            End If
            '************52
            txtLine = "52:"

            Dim str1 As String
            If InStr(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), "LYG") > 0 Then
                str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), ConTypeOwner) ' "CSC")
                If InStr(Trim(str1), ":") <> 6 Then
                    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的装货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Else
                        Exit Sub
                    End If
                End If
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("Load_Port")) Then
                    txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Load_Port"))) & ":"
                Else
                    txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port"))) & ":"
                End If

                str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")), ConTypeOwner) ' "CSC")
                If InStr(Trim(str1), ":") <> 6 Then
                    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的卸货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Else
                        Exit Sub
                    End If
                End If
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("unLoad_Port")) Then
                    txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")) & ":" & Trim(ds.Tables(0).Rows(j).Item("unLoad_Port"))) & ":"
                Else
                    txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port"))) & ":"
                End If
                If (Not IsDBNull(ds.Tables(0).Rows(j).Item("Code_Delivery"))) And (Len(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery"))) > 0) Then
                    str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")), ConTypeOwner) ' "CSC")
                    If InStr(Trim(str1), ":") <> 6 Then
                        str1 = FindPortTemp(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")))
                        If InStr(Trim(str1), ":") <> 6 Then
                            If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的目的港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            Else
                                Exit Sub
                            End If
                        End If
                    End If
                    If Not IsDBNull(ds.Tables(0).Rows(j).Item("Delivery")) Then
                        txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Delivery")))
                    Else
                        txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")))

                    End If
                Else
                    txtLine = txtLine & ":"
                End If
                txtLine = txtLine & "'"
                sw.WriteLine(txtLine)
            Else
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeLoadPort")) Then
                    '*********************非连云港装港口
                    If Not IsDBNull(ds.Tables(0).Rows(j).Item("Load_Port")) Then
                        txtLine = txtLine & Trim(ds.Tables(0).Rows(j).Item("CodeLoadPort")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Load_Port")) & ":"
                    Else
                        txtLine = txtLine & Trim(ds.Tables(0).Rows(j).Item("CodeLoadPort")) & ":" & Trim(ds.Tables(0).Rows(j).Item("CodeLoadPort")) & ":"
                    End If
                Else
                    str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), ConTypeOwner) ' "CSC")
                    'If InStr(Trim(str1), ":") <> 6 Then
                    '    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的装货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    '    Else
                    '        Exit Sub
                    '    End If
                    'End If
                    If Not IsDBNull(ds.Tables(0).Rows(j).Item("Load_Port")) Then
                        txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Load_Port"))) & ":"
                    Else
                        txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port"))) & ":"
                    End If
                End If
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeUnLoadPort")) Then
                    '*********************非连云港装港口
                    If Not IsDBNull(ds.Tables(0).Rows(j).Item("UnLoad_Port")) Then
                        txtLine = txtLine & Trim(ds.Tables(0).Rows(j).Item("CodeUnLoadPort")) & ":" & Trim(ds.Tables(0).Rows(j).Item("UnLoad_Port")) & ":"
                    Else
                        txtLine = txtLine & Trim(ds.Tables(0).Rows(j).Item("CodeUnLoadPort")) & ":" & Trim(ds.Tables(0).Rows(j).Item("CodeUnLoadPort")) & ":"
                    End If
                Else
                    str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")), ConTypeOwner) ' "CSC")
                    'If InStr(Trim(str1), ":") <> 6 Then
                    '    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的卸货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    '    Else
                    '        Exit Sub
                    '    End If
                    'End If
                    If Not IsDBNull(ds.Tables(0).Rows(j).Item("unLoad_Port")) Then
                        txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")) & ":" & Trim(ds.Tables(0).Rows(j).Item("unLoad_Port"))) & ":"
                    Else
                        txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port"))) & ":"
                    End If
                End If
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeDelivery")) Then
                    '*********************非连云港装港口
                    If Not IsDBNull(ds.Tables(0).Rows(j).Item("Delivery")) Then
                        txtLine = txtLine & Trim(ds.Tables(0).Rows(j).Item("CodeDelivery")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Delivery")) & ":"
                    Else
                        txtLine = txtLine & Trim(ds.Tables(0).Rows(j).Item("CodeDelivery")) & ":" & Trim(ds.Tables(0).Rows(j).Item("CodeDelivery")) & ":"
                    End If
                Else
                    If (Not IsDBNull(ds.Tables(0).Rows(j).Item("Code_Delivery"))) And (Len(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery"))) > 0) Then
                        str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")), ConTypeOwner) ' "CSC")
                        If InStr(Trim(str1), ":") <> 6 Then
                            str1 = FindPortTemp(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")))
                            'If InStr(Trim(str1), ":") <> 6 Then
                            '    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的目的港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            '    Else
                            '        Exit Sub
                            '    End If
                            'End If
                        End If
                        If Not IsDBNull(ds.Tables(0).Rows(j).Item("Delivery")) Then
                            txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Delivery")))
                        Else
                            txtLine = txtLine & IIf(Len(Trim(str1)) > 1, Trim(str1), Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")) & ":" & Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")))

                        End If
                    Else
                        txtLine = txtLine & ":"
                    End If
                End If
                txtLine = txtLine & "'"
                sw.WriteLine(txtLine)

            End If
            i = i + 1
            '*************54  其中53省去
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("DANGER_GRADE")) Then
                If Len(Trim(ds.Tables(0).Rows(j).Item("DANGER_GRADE"))) > 0 Then
                    txtLine = "54:" & Trim(ds.Tables(0).Rows(j).Item("DANGER_GRADE")) & ":"
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

            j = j + 1
        Loop
        txtLine = "99:" & Trim(CType(i + 1, String)) & "'"
        sw.WriteLine(txtLine)
        sw.Close()
        MsgBox("生成完成,谢谢! 共生成 " & Trim(CType(i + 1, String)) & " 行报文 共 " & j & " 个箱子")
    End Sub

    Private Sub WriteWYDF()    '**********************外运达飞
        Dim txtline As String
        Dim i As Integer = 0 '记录行数
        Dim j As Integer = 0 '取箱信息循环
        Dim str As String
        Dim s As String
        Dim tstr As String '***************时间
        Dim str1 As String
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
        Dim ConOperatorCode As String = "" '箱经营人代码
        Dim ConOperator As String = "" '箱经营人
        Dim length As String
        Dim width As String
        Dim heigth As String
        Dim ConNo As String
        If cbSummary.Checked = False Then
            strFile = txtFile.Text & UCase(txtShipCode.Text) & LVoyage.Text & ".txt"
        Else
            strFile = txtFile.Text & UCase(txtShipCode.Text) & LVoyage.Text & "Sum.txt"
        End If
        File.Delete(strFile)
        Dim sw As New StreamWriter(strFile, FileMode.OpenOrCreate, System.Text.Encoding.Default())  '打开报文文件
        '**************写UNB行
        txtline = "UNB+UNOA:1" & "+COSTACO+" & Trim(cbEmail.SelectedValue) & "+" & Mid(Trim(CType(Year(Now()), String)), 3, 2)
        s = Mid("0" & Trim(CType(Month(Now), String)), Len("0" & Trim(CType(Month(Now), String))) - 1, 2)
        txtline = txtline & s
        s = Mid("0" & Trim(CType(Day(Now), String)), Len("0" & Trim(CType(Day(Now), String))) - 1, 2)
        txtline = txtline & s & ":"
        s = Mid("0" & Trim(CType(Hour(Now), String)), Len("0" & Trim(CType(Hour(Now), String))) - 1, 2)
        txtline = txtline & s
        s = Mid("0" & Trim(CType(Minute(Now), String)), Len("0" & Trim(CType(Minute(Now), String))) - 1, 2)
        txtline = txtline & s & "+"

        tstr = Mid(Trim(CType(Year(Now()), String)), 3, 2) & Mid("0" & Trim(CType(Month(Now), String)), Len("0" & Trim(CType(Month(Now), String))) - 1, 2)
        tstr = tstr & Mid("0" & Trim(CType(Day(Now), String)), Len("0" & Trim(CType(Day(Now), String))) - 1, 2)
        tstr = tstr & Mid("0" & Trim(CType(Hour(Now), String)), Len("0" & Trim(CType(Hour(Now), String))) - 1, 2)
        tstr = tstr & Mid("0" & Trim(CType(Minute(Now), String)), Len("0" & Trim(CType(Minute(Now), String))) - 1, 2)
        txtline = txtline & tstr & "+++++"
        txtline = txtline & LShipOwner.Text & "'"
        sw.WriteLine(txtline)
        i = 0
        '**************写UNH行
        txtline = "UNH+"
        txtline = txtline & tstr & "+BAPLIE:1:911:UN:SMDG15'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************写BGM
        txtline = "BGM++" & tstr & "+9'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************写时间DTM+137
        txtline = "DTM+137:" & tstr & ":201'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************写TDT
        If LSign.Text.Trim().Substring(0, 2).ToUpper() = "UN" Then
            LSign.Text = LSign.Text.Trim().Substring(2)
        End If
        txtline = "TDT+20+" & LVoyage.Text & "++" & LSign.Text & ":103::" & LEnglish.Text & "++" & LShipOwner.Text & ":172:20'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************LOC(1) 装货港
        txtline = "LOC+5+CNLYG'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************LOC(2) 卸货港
        If Len(Trim(LNextPort.Text)) > 0 Then
            str1 = FindPortTemp(Trim(LNextPort.Text))
            txtline = "LOC+61+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(LNextPort.Text)) & "'"
            sw.WriteLine(txtline)
            i = i + 1
        Else
            MsgBox("请在航次记录中选择下一港名称!")
            Exit Sub
        End If
        '******************离港时间
        If Len(Trim(LEndTime.Text)) > 0 Then
            txtline = "DTM+178:" & Trim(LEndTime.Text) & "0000:201'"
            sw.WriteLine(txtline)
            i = i + 1
            txtline = "DTM+136:" & Trim(LEndTime.Text) & "0000:201'"
            sw.WriteLine(txtline)
            i = i + 1
            txtline = "DTM+132:" & Trim(LEndTime.Text) & ":201'"
            sw.WriteLine(txtline)
            i = i + 1
        Else
            txtline = "DTM+178:" & Mid(tstr, 1, 6) & "0000:201'"
            sw.WriteLine(txtline)
            i = i + 1
            txtline = "DTM+136:" & Mid(tstr, 1, 6) & "0000:201'"
            sw.WriteLine(txtline)
            i = i + 1
            txtline = "DTM+132:" & Mid(tstr, 1, 6) & ":201'"
            sw.WriteLine(txtline)
            i = i + 1
        End If
        '******************航次
        txtline = "RFF+VON:" & LVoyage.Text & "'"
        sw.WriteLine(txtline)
        i = i + 1
        '**************开始箱循环
        If cbSummary.Checked = False Then
            sqlstr = "select * from Con_Image where Code_Load_Port  like '%LYG%' and Ship_ID=" & Ship_ID
        Else
            sqlstr = "select * from Con_Image where Ship_ID=" & Ship_ID
        End If
        dw = Getdata(sqlstr, ds)
        PB.Maximum = dw.Count
        PB.Value = 0
        Do While j < dw.Count
            PB.Value = j
            ConType = "" '箱尺寸类型
            ConOverFront = ""  '前超
            ConOverBack = ""  '后超
            ConOverLeft = ""  '左超
            ConOverRight = ""  '右超
            ConOverHeight = ""  '超高
            ConTareWeight = ""  '箱皮重
            ConOperatorCode = ""  '箱经营人代码
            ConOperator = ""  '箱经营人

            If ds.Tables(0).Rows(j).Item("Code_Con_Company") Is System.DBNull.Value Then
                ConOperatorCode = ""
            Else
                ConOperatorCode = UCase(CType(ds.Tables(0).Rows(j).Item("Code_Con_Company"), String))
            End If
            dst.Reset()
            str = "select * from CON_CRITERION where CONTAINER_NO='" & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & "'"
            dwt = Getdata(str, dst)
            If dwt.Count > 0 Then
                ConType = Trim(dst.Tables(0).Rows(0).Item("SIZE_CON")) & Trim(dst.Tables(0).Rows(0).Item("CONTAINER_TYPE"))
                If ConOperatorCode.Trim().Length() = 0 Then
                    ConOperatorCode = Trim(dst.Tables(0).Rows(0).Item("Code_Con_Company"))
                End If
                ConOperator = ""
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("CON_WEIGHT")) Then
                    ConTareWeight = Trim(CType(CType(dst.Tables(0).Rows(0).Item("CON_WEIGHT"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_Height")) Then
                    ConOverHeight = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_Height"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_Left")) Then
                    ConOverLeft = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_Left"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_Right")) Then
                    ConOverRight = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_Right"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_BEFORE")) Then
                    ConOverFront = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_BEFORE"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("OVER_BEHIND")) Then
                    ConOverBack = Trim(CType(CType(dst.Tables(0).Rows(0).Item("OVER_BEHIND"), Single), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("Length")) Then
                    length = Trim(CType(dst.Tables(0).Rows(0).Item("Length"), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("Width")) Then
                    width = Trim(CType(dst.Tables(0).Rows(0).Item("Width"), String))
                End If
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("Height")) Then
                    heigth = Trim(CType(dst.Tables(0).Rows(0).Item("Heigtht"), String))
                End If
            End If

            dst.Reset()

            str = "select * from CODE_TYPE_SHIP_RELATION where CONTAINER_NO='" & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & "' and CODE_SHIP_OWNER='" & ConTypeOwner & "'" 'and CODE_SHIP_OWNER='COSW'"
            dwt = Getdata(str, dst)
            If dwt.Count > 0 Then
                ConType = Trim(dst.Tables(0).Rows(0).Item("CODE_CON_TYPE"))
            Else
                dst.Reset()
                str = "select * from CODE_CON_TYPE where CODE_CON_TYPE='" & ConType & "' and CODE_SHIP_OWNER='" & ConTypeOwner & "'" 'and CODE_SHIP_OWNER='COSW'"
                dwt = Getdata(str, dst)
                If dwt.Count > 0 Then
                    ConType = Trim(dst.Tables(0).Rows(0).Item("CODE_SHIP_TYPE"))
                Else
                    ConType = ConType
                End If
            End If

            '*********************非连云港箱型
            If InStr(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), "LYG") > 0 Then
            Else
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeConType")) Then
                    ConType = Trim(ds.Tables(0).Rows(j).Item("CodeConType"))
                End If
            End If
            '*************LOC + 147 贝位号
            txtline = "LOC+147+" & "0" & ds.Tables(0).Rows(j).Item("BAYNO") & "'"
            sw.WriteLine(txtline)
            i = i + 1
            '**************FTX+AAA货物描述
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("Demo")) Then
                If Len(Trim(ds.Tables(0).Rows(j).Item("Demo"))) > 0 Then
                    txtline = "FTX+AAA+++" & ds.Tables(0).Rows(j).Item("Demo") & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
            End If
            '**************FTX+CLR箱货物描述
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("ConDemo")) Then
                If Len(Trim(ds.Tables(0).Rows(j).Item("ConDemo"))) > 0 Then
                    txtline = "FTX+CLR+++" & ds.Tables(0).Rows(j).Item("ConDemo") & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
            End If
            '*************MEA 货物重量
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("GROSSWEIGHT")) Then
                txtline = "MEA+WT++KGM:" & CType(CType(ds.Tables(0).Rows(j).Item("GrossWeight"), Single), String) & "'"
            Else
                txtline = "MEA+WT++KGM:0000'"
            End If
            sw.WriteLine(txtline)
            i = i + 1
            '******************DIM 超高等
            If Len(Trim(ConOverHeight)) > 0 Or Len(Trim(ConOverLeft)) > 0 Or Len(Trim(ConOverRight)) > 0 Or Len(Trim(ConOverFront)) > 0 Or Len(Trim(ConOverBack)) > 0 Then
                If Len(Trim(ConOverFront)) > 0 Then
                    txtline = "DIM+5+CMT:" & Trim(ConOverFront) & "::'"
                End If
                If Len(Trim(ConOverBack)) > 0 Then
                    txtline = "DIM+6+CMT:" & Trim(ConOverBack) & "::'"
                End If
                If Len(Trim(ConOverRight)) > 0 Then
                    txtline = "DIM+7+CMT::" & Trim(ConOverRight) & ":'"
                End If
                If Len(Trim(ConOverLeft)) > 0 Then
                    txtline = "DIM+8+CMT::" & Trim(ConOverLeft) & ":'"
                End If
                If Len(Trim(ConOverHeight)) > 0 Then
                    txtline = "DIM+9+CMT:::" & Trim(ConOverHeight) & "'"
                End If
                sw.WriteLine(txtline)
                i = i + 1
            Else
                If Len(Trim(length)) > 0 And Len(Trim(width)) > 0 And Len(Trim(heigth)) > 0 Then
                    txtline = "DIM+1+INH:" & Trim(length) & ":" & Trim(width) & ":" & Trim(heigth) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If

            End If
            '*********************冷藏箱
            If (Not IsDBNull(ds.Tables(0).Rows(j).Item("TEMPERATURE_UNIT"))) And (Not IsDBNull(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"))) Then
                If Len(Trim(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"))) > 0 Then
                    txtline = "TMP+2+" & Trim(CType(CType(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"), Single), String)) & ":CEL'"
                    sw.WriteLine(txtline)
                    i = i + 1
                    If Not IsDBNull(ds.Tables(0).Rows(j).Item("MAX_TEMPERATURE")) Then
                        txtline = "RNG+ZZZ+CEL:" & Trim(CType(CType(ds.Tables(0).Rows(j).Item("MIN_TEMPERATURE"), Single), String)) & ":" & Trim(CType(CType(ds.Tables(0).Rows(j).Item("MAX_TEMPERATURE"), Single), String)) & "'"
                    Else
                        txtline = "RNG+ZZZ+CEL:" & Trim(CType(CType(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"), Single), String)) & ":" & Trim(CType(CType(ds.Tables(0).Rows(j).Item("TEMPERATURE_SETTING"), Single), String)) & "'"
                    End If
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
            End If
            '************************装货港
            If InStr(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), "LYG") > 0 Then
                str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), PortOwner) '"CMA")
                If InStr(Trim(str1), ":") <> 6 Then
                    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的装货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Else
                        Exit Sub
                    End If
                End If
                txtline = "LOC+6+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port"))) & "'"
                sw.WriteLine(txtline)
                i = i + 1

                '************************卸货港
                str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")), PortOwner) '"CMA")
                If InStr(Trim(str1), ":") <> 6 Then
                    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的装货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Else
                        Exit Sub
                    End If
                End If
                txtline = "LOC+12+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port"))) & "'"
                sw.WriteLine(txtline)
                i = i + 1

                '************************目的港
                str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")), PortOwner) '"CMA")
                If InStr(Trim(str1), ":") <> 6 Then
                    str1 = FindPortTemp(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")))
                    If InStr(Trim(str1), ":") <> 6 Then
                        If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的目的港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Else
                            Exit Sub
                        End If
                    End If
                End If
                txtline = "LOC+83+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_Delivery"))) & "'"
                sw.WriteLine(txtline)
                i = i + 1
            Else
                '************************装货港
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeLoadPort")) Then
                    '*********************非连云港装港口
                    txtline = "LOC+6+" & Trim(ds.Tables(0).Rows(j).Item("CodeLoadPort")) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                Else
                    str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port")), PortOwner) '"CMA")
                    'If InStr(Trim(str1), ":") <> 6 Then
                    '    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的装货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    '    Else
                    '        Exit Sub
                    '    End If
                    'End If
                    txtline = "LOC+6+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_Load_Port"))) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
                '************************卸货港
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeUnLoadPort")) Then
                    '*********************非连云港装港口
                    txtline = "LOC+12+" & Trim(ds.Tables(0).Rows(j).Item("CodeUnLoadPort")) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                Else
                    str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")), PortOwner) '"CMA")
                    'If InStr(Trim(str1), ":") <> 6 Then
                    '    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的装货港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    '    Else
                    '        Exit Sub
                    '    End If
                    'End If
                    txtline = "LOC+12+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port"))) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
                '************************目的港
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("CodeDelivery")) Then
                    '*********************非连云港装港口
                    txtline = "LOC+83+" & Trim(ds.Tables(0).Rows(j).Item("CodeDelivery")) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                Else
                    str1 = FindPort(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")), PortOwner) '"CMA")
                    If InStr(Trim(str1), ":") <> 6 Then
                        str1 = FindPortTemp(Trim(ds.Tables(0).Rows(j).Item("Code_Delivery")))
                        'If InStr(Trim(str1), ":") <> 6 Then
                        '    If MsgBox("此箱 " & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & " 的目的港代码 " & IIf(InStr(Trim(str1), ":") > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), "") & " 位数不正确,继续吗?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        '    Else
                        '        Exit Sub
                        '    End If
                        'End If
                    End If
                    txtline = "LOC+83+" & IIf(Len(Trim(str1)) > 1, Mid(Trim(str1), 1, InStr(Trim(str1), ":") - 1), Trim(ds.Tables(0).Rows(j).Item("Code_Delivery"))) & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                End If
            End If
            '***********************提单号
            txtline = "RFF+BM:" & Trim(CType(ds.Tables(0).Rows(j).Item("BLNO"), String)) & "'"
            sw.WriteLine(txtline)
            i = i + 1
            '***********************EQD+CN 箱号 箱型
            ConNo = ds.Tables(0).Rows(j).Item("Container_NO")
            If Len(Trim(ConNo)) = 11 Then
                ConNo = Mid(Trim(ConNo), 1, 4) & " " & Mid(Trim(ConNo), 5, 7)
            End If
            If Mid(UCase(ds.Tables(0).Rows(j).Item("FULLOREMPTY")), 1, 1) = "F" Then
                txtline = "EQD+CN+" & ConNo & "+" & ConType & "+++5'"
            End If
            If Mid(UCase(ds.Tables(0).Rows(j).Item("FULLOREMPTY")), 1, 1) = "E" Then
                txtline = "EQD+CN+" & ConNo & "+" & ConType & "+++4'"
            End If
            If Mid(UCase(ds.Tables(0).Rows(j).Item("FULLOREMPTY")), 1, 1) = "L" Then
                txtline = "EQD+CN+" & ConNo & "+" & ConType & "+++7'"
            End If
            sw.WriteLine(txtline)
            i = i + 1
            '*******************箱经营人
            txtline = "NAD+CA+" & Trim(ConOperatorCode) & ":172:ZZZ'"
            sw.WriteLine(txtline)
            i = i + 1
            '*******************危险品
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("DANGER_GRADE")) Then
                If Len(Trim(ds.Tables(0).Rows(j).Item("DANGER_GRADE"))) > 0 Then
                    txtline = "DGS+IMD+" & Trim(ds.Tables(0).Rows(j).Item("DANGER_GRADE"))
                    If Not IsDBNull(ds.Tables(0).Rows(j).Item("DANGER_PageNO")) Then
                        txtline = txtline & ":" & Trim(CType(ds.Tables(0).Rows(j).Item("DANGER_PageNO"), String))
                    End If
                    If Not IsDBNull(ds.Tables(0).Rows(j).Item("DANGER_NO")) Then
                        txtline = txtline & "+" & Trim(CType(ds.Tables(0).Rows(j).Item("DANGER_NO"), String))
                    End If
                    txtline = txtline & "'"
                    sw.WriteLine(txtline)
                    i = i + 1
                    '*********************危险品FTX
                    'txtline = "FTX+AAA+++========'"
                    'sw.WriteLine(txtline)
                    'i = i + 1
                End If

            End If

            j = j + 1
        Loop
        '*************UNT
        i = i + 1
        txtline = "UNT+" & Trim(CType(i, String)) & "+" & tstr & "'"
        sw.WriteLine(txtline)
        txtline = "UNZ+1+" & tstr & "'"
        sw.WriteLine(txtline)
        sw.Close()
        MsgBox("生成完成,谢谢! 共生成 " & Trim(CType(i, String)) & " 行报文 共 " & j & " 个箱子")
    End Sub

    Private Sub WriteKDYH()                                '*************************凯达（烟海）
        Dim txtline As String
        Dim i As Integer = 0 '记录行数
        Dim j As Integer = 0 '取箱信息循环
        Dim str As String
        Dim s As String
        Dim dwt As New DataView
        Dim dst As New DataSet
        Dim strFile As String
        Dim ConType As String = "" '箱尺寸类型
        Dim Measure As String
        Dim Weight As String
        Dim ConWeight As String
        Dim BayNO As String
        Dim UnLoadPort As String
        Dim SealNO As String
        Dim Amount As String
        If cbSummary.Checked = False Then
            strFile = txtFile.Text & UCase(txtShipCode.Text) & LVoyage.Text & ".txt"
        Else
            strFile = txtFile.Text & UCase(txtShipCode.Text) & LVoyage.Text & "Sum.txt"
        End If
        File.Delete(strFile)
        Dim sw As New StreamWriter(strFile, FileMode.OpenOrCreate, System.Text.Encoding.Default())  '打开报文文件
        '**************写00行

        '**************写11行

        '**************开始箱循环
        If cbSummary.Checked = False Then
            sqlstr = "select * from Con_Image where Code_Load_Port  like '%LYG%' and Ship_ID=" & Ship_ID & " order by BLNO"
        Else
            sqlstr = "select * from Con_Image where Ship_ID=" & Ship_ID & " order by BLNO"
        End If
        dw = Getdata(sqlstr, ds)

        PB.Maximum = dw.Count
        PB.Value = 0
        Do While j < dw.Count
            PB.Value = j
            ConType = "" '箱尺寸类型


            dst.Reset()
            str = "select * from VIEW_CON_HATCH_CARGO where Ship_ID=" & Ship_ID & " and CONTAINER_NO='" & UCase(ds.Tables(0).Rows(j).Item("Container_No")) & "'"
            dwt = Getdata(str, dst)
            If dwt.Count > 0 Then
                ConType = Trim(dst.Tables(0).Rows(0).Item("SIZE_CON")) & Trim(dst.Tables(0).Rows(0).Item("CONTAINER_TYPE"))
                'Measure = Space(8) & Trim(dst.Tables(0).Rows(0).Item("VOLUME"))
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("VOLUME")) Then
                    Measure = Trim(CType(dst.Tables(0).Rows(0).Item("VOLUME"), Int64))

                    str = Trim(CType(dst.Tables(0).Rows(0).Item("VOLUME"), Double) - CType(dst.Tables(0).Rows(0).Item("VOLUME"), Int64))
                Else
                    Measure = 0
                    str = "000"
                End If
                If InStr(str, ".") > 0 Then
                    str = Mid(str, InStr(str, ".") + 1) & "000"
                    str = Mid(str, 1, 3)
                Else
                    str = "000"
                End If
                Measure = Measure & str
                Measure = Space(8) & Measure

                SealNO = Trim(dst.Tables(0).Rows(0).Item("SealNO")) & Space(10)
                SealNO = Mid(SealNO, 1, 10)
                If Not IsDBNull(dst.Tables(0).Rows(0).Item("ConAMOUNT")) Then
                    Amount = Space(6) & Trim(dst.Tables(0).Rows(0).Item("ConAMOUNT"))
                Else
                    Amount = Space(6)
                End If
                Amount = Mid(Amount, Amount.Length() - 5, 6)
                If Trim(dst.Tables(0).Rows(0).Item("SIZE_CON")) = "20" Then
                    ConWeight = "  2300"   '***************皮重
                ElseIf Trim(dst.Tables(0).Rows(0).Item("SIZE_CON")) = "40" Then
                    ConWeight = "  3800" '***************皮重
                ElseIf Trim(dst.Tables(0).Rows(0).Item("SIZE_CON")) = "45" Then
                    ConWeight = "  4700"  '***************皮重
                Else
                    ConWeight = Space(6)
                End If
            Else
                ConType = "    "
                ConWeight = Space(6)
                Measure = Space(8)
                SealNO = Space(10)
                Amount = Space(6)

            End If


            '*************31
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("FULLOREMPTY")) Then
                If Trim(ds.Tables(0).Rows(j).Item("FULLOREMPTY")).Length() > 0 Then
                    txtline = "31" & UCase(ds.Tables(0).Rows(j).Item("FULLOREMPTY")) & "  "
                Else
                    txtline = "31   "
                End If
            Else
                txtline = "31   "
            End If
            '箱号
            txtline = txtline & IIf(Len(UCase(ds.Tables(0).Rows(j).Item("Container_No"))) <> 12, Mid(UCase(ds.Tables(0).Rows(j).Item("Container_No") & Space(11)), 1, 11), Mid(UCase(ds.Tables(0).Rows(j).Item("Container_No")), 1, 4) & Mid(UCase(ds.Tables(0).Rows(j).Item("Container_No")), 6, 7))
            '签封号
            If Trim(SealNO).Length() = 0 Then
                SealNO = "          "
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("SealNo")) Then
                    If Trim(ds.Tables(0).Rows(j).Item("SealNo")).Length() > 0 Then
                        SealNO = Trim(ds.Tables(0).Rows(j).Item("SealNo")) & Space(10)
                        SealNO = Mid(SealNO, 1, 10)
                    End If
                End If
            End If
            txtline = txtline & SealNO
            dst.Reset()
            '箱型尺寸
            txtline = txtline & ConType
            '提单
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("BLNO")) Then
                If Trim(ds.Tables(0).Rows(j).Item("BLNO")).Length() > 0 Then
                    txtline = txtline & Mid(Trim(CType(ds.Tables(0).Rows(j).Item("BLNO"), String)) & Space(16), 1, 16)
                Else
                    txtline = txtline & Space(16)
                End If
            Else
                txtline = txtline & Space(16)
            End If
            '件数包装
            If Trim(Amount).Length() = 0 Then
                Amount = Space(6)
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("AMOUNT")) Then
                    If Trim(ds.Tables(0).Rows(j).Item("AMOUNT")).Length() > 0 Then
                        Amount = Space(6) & Trim(ds.Tables(0).Rows(j).Item("AMOUNT"))
                    End If
                End If
            End If
            If CType(Trim(Amount), Int64) > 0 Then
                Amount = Mid(Amount, Amount.Length() - 5, 6)
            Else
                Amount = Space(5) & "0"
            End If
            txtline = txtline & Amount & " P'KGS"

            '体积
            'VOLUME=
            If Trim(Measure).Length() = 0 Then
                Measure = Space(8)
                If Not IsDBNull(ds.Tables(0).Rows(j).Item("VOLUME")) Then
                    If Trim(ds.Tables(0).Rows(j).Item("VOLUME")).Length() > 0 Then
                        Measure = Trim(CType(ds.Tables(0).Rows(j).Item("VOLUME"), Int64))
                        str = Trim(CType(ds.Tables(0).Rows(j).Item("VOLUME"), Double) - CType(ds.Tables(0).Rows(j).Item("VOLUME"), Int64))
                        If InStr(str, ".") > 0 Then
                            str = Mid(str, InStr(str, ".") + 1) & "000"
                            str = Mid(str, 1, 3)
                        Else
                            str = "000"
                        End If
                        Measure = Measure & str
                        Measure = Space(8) & Measure
                    End If
                End If
            End If
            If CType(Trim(Measure), Int64) > 0 Then
                Measure = Mid(Measure, Measure.Length() - 7, 8)
            Else
                Measure = Space(7) & "0"
            End If
            txtline = txtline & Measure

            '重量
            'GROSSWEIGHT()

            Weight = Space(6)
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("GROSSWEIGHT")) Then
                If Trim(ds.Tables(0).Rows(j).Item("GROSSWEIGHT")).Length() > 0 Then
                    Weight = Trim(CType(ds.Tables(0).Rows(j).Item("GROSSWEIGHT"), Int64))
                    str = Trim(CType(ds.Tables(0).Rows(j).Item("GROSSWEIGHT"), Double) - CType(ds.Tables(0).Rows(j).Item("GROSSWEIGHT"), Int64))
                    If InStr(str, ".") > 0 Then
                        str = Mid(str, InStr(str, ".") + 1) & "0"
                        str = Mid(str, 1, 1)
                    Else
                        str = "0"
                    End If
                    Weight = Weight & str
                    Weight = Space(6) & Weight
                End If
            End If
            If CType(Trim(Weight), Int64) > 0 Then
                Weight = Mid(Weight, Weight.Length() - 5, 6)
            Else
                Weight = Space(5) & "0"
            End If
            txtline = txtline & Weight

            '箱重
            txtline = txtline & ConWeight
            '贝位
            'BayNO
            BayNO = Space(6)
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("BAYNO")) Then
                If Trim(ds.Tables(0).Rows(j).Item("BAYNO")).Length() > 0 Then
                    BayNO = Space(6) & Trim(ds.Tables(0).Rows(j).Item("BAYNO"))
                End If
            End If
            BayNO = Mid(BayNO, BayNO.Length() - 5, 6)
            txtline = txtline & BayNO

            '卸货港代码
            UnLoadPort = Space(5)
            If Not IsDBNull(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")) Then
                If Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port")).Length() > 0 Then
                    UnLoadPort = Space(6) & Trim(ds.Tables(0).Rows(j).Item("Code_unLoad_Port"))
                End If
            End If
            UnLoadPort = Mid(UnLoadPort, UnLoadPort.Length() - 4, 5)

            txtline = txtline & UnLoadPort
            sw.WriteLine(txtline)
            i = i + 1

            '************52


            j = j + 1
        Loop
        '*************99

        sw.Close()
        MsgBox("生成完成,谢谢! 共生成 " & Trim(CType(i, String)) & " 行报文 共 " & j & " 个箱子")
    End Sub
    Private Sub FrmWriteMail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds1 As New DataSet
        Dim dw1 As New DataView
        Dim ds2 As New DataSet
        Dim dw2 As New DataView
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

        sqlstr = "select DISTINCT Code_Con_Company from CON_IMAGE where Ship_ID=" & Ship_ID
        dw2 = Getdata(sqlstr, ds2)
        txtCodeOperate.DataSource = ds2.Tables(0).DefaultView
        txtCodeOperate.DisplayMember = "Code_Con_Company"
        txtCodeOperate.ValueMember = "Code_Con_Company"
    End Sub
    Private Function FindPort(ByVal Port As String, ByVal Company As String) As String
        Dim dsPort As New DataSet
        Dim dwPort As New DataView
        Dim str As String
        str = "select * from Code_Port_Relation where Code_Port='" & Port & "' and Code_SHIPOWNER='" & Company & "'"
        dsPort.Reset()
        dwPort = Getdata(str, dsPort)
        If dwPort.Count > 0 Then
            FindPort = dsPort.Tables(0).Rows(0).Item("Code_Port_Relation") & ":" & dsPort.Tables(0).Rows(0).Item("Port_Relation")
        Else
            FindPort = Port & ":"
        End If
    End Function
    Private Function FindPortTemp(ByVal Port As String) As String
        Dim dsPort As New DataSet
        Dim dwPort As New DataView
        Dim str As String
        str = "select * from Code_Port_Relation where Code_Port='" & Port & "'"
        dsPort.Reset()
        dwPort = Getdata(str, dsPort)
        If dwPort.Count > 0 Then
            FindPortTemp = dsPort.Tables(0).Rows(0).Item("Code_Port_Relation") & ":" & dsPort.Tables(0).Rows(0).Item("Port_Relation")
        Else
            FindPortTemp = Port & ":"
        End If
    End Function
    Private Sub btRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRead.Click
        Dim PathStr As String
        Dim FilePath As String
        Dim strFile As String
        If cbSummary.Checked = False Then
            strFile = txtFile.Text & UCase(txtShipCode.Text) & LVoyage.Text & ".txt"
        Else
            strFile = txtFile.Text & UCase(txtShipCode.Text) & LVoyage.Text & "Sum.txt"
        End If
        PathStr = System.Reflection.Assembly.GetExecutingAssembly.Location
        PathStr = substr(PathStr)
        Try
            FilePath = PathStr + "NOTEPAD.EXE"
            Shell(FilePath & " " & strFile, AppWinStyle.NormalFocus, True)
        Catch
        End Try
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub txtCodeOperate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
