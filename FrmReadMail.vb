Imports System.Web.Mail
Imports System.IO
Imports TALLY.DBControl
Public Class FrmReadMail
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet()
    Dim dw As New DataView()
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
        Me.OpenFile.Text = "���ļ�"
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
        Me.btReadNew.Text = "��ȡ����"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "���Ĵ���"
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
        Me.Label3.Text = "Ӣ�Ĵ���"
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
        Me.Label5.Text = "����"
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
        Me.Label2.Text = "������"
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
        Me.Text = "��ͼ���Ķ�ȡ"
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


    Private Function CheckConNO(ByVal CNO As String) As Integer 'return 0 ����д� 1 У���д� 2 У����ȷ
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
        Dim sr As New StreamReader(txtFile.Text) '�򿪱����ļ�
        Dim txtLine(3) As Char
        Dim sqlstr As String
        Dim ds1 As New DataSet()
        Dim dw1 As New DataView()
        Dim sqlda1 As New SqlClient.SqlDataAdapter()

        sr.Read(txtLine, 0, 3) '��ȡһ��
        sr.Close()
        If txtLine(0) = "0" And txtLine(1) = "0" And txtLine(2) = ":" Then '****��ͨ��
            Call ReadZH()
        ElseIf txtLine(0) = "0" And txtLine(1) = "0" And txtLine(2) = "B" Then '*****��Զ
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
        row("OperateType") = "����ͼ����"
        row("OperateDemo") = txtFile.Text
        row("OperateTable") = Ship_ID
        ds1.Tables(0).Rows.Add(row)



        sqlda1.Update(ds1)
    End Sub
    Private Sub ReadUN()
        Dim sr As New StreamReader(txtFile.Text) '�򿪶������ļ�
        Dim i As Long
        Dim s As String
        Dim txtline As String
        Dim strFile As String
        strFile = Mid(txtFile.Text, 1, FindLOC(txtFile.Text) - 1) & "\UnTemp.txt"
        File.Delete(strFile)
        Dim sw As New StreamWriter(strFile, FileMode.OpenOrCreate) '��д�����ļ�
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
        Dim sr As New StreamReader(Mid(txtFile.Text, 1, FindLOC(txtFile.Text) - 1) & "\UnTemp.txt") '�򿪱����ļ�
        Dim txtLine As String
        Dim sTemp As String
        Dim Str As String
        Dim ShipLineCode As String = "" '����˾����
        Dim i As Integer = 0 '��¼����
        '**************������ͷ
        txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��

        '***********�����¼ �ļ� ͷ��¼
        If txtLine = Nothing Then
            MsgBox("���ĳ���!")
            Exit Sub
        Else
            Str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(Str) + 2)
            If Trim(Str) <> "UNB" Then
                MsgBox("���ĳ��� " & Str & " ,������" & i + 1 & "��!")
                Exit Sub
            Else
                Str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(Str) + 2)
                If Trim(Str) <> "UNOA:1" And Trim(Str) <> "UNOA:2" And Trim(Str) <> "UNOA:3" Then                       '��ͼ��ʶ
                    MsgBox("���ĳ��� " & Str & " ,�﷨��ʶ����汾�Ŵ���,������" & i + 1 & "��!")
                    Exit Sub
                Else
                    'Str = FetchStr(txtLine)
                    'txtLine = Mid(txtLine, Len(Str) + 2)
                    'If Len(Trim(Str)) = 0 Then              '���ͷ���ʶ
                    '    'MsgBox("���ĳ��� " & Str & " ,���Ǵ�ͼ����,������" & i + 1 & "��!")
                    '    'Exit Sub
                    'End If
                    'Str = FetchStr(txtLine)
                    'txtLine = Mid(txtLine, Len(Str) + 2)
                    'If Len(Trim(Str)) = 0 Then              '���ܷ���ʶ
                    '    'MsgBox("���ĳ��� " & Str & " ,���Ǵ�ͼ����,������" & i + 1 & "��!")
                    '    'Exit Sub
                    'End If
                    'Str = FetchStr(txtLine)
                    'txtLine = Mid(txtLine, Len(Str) + 2)
                    'If Len(Trim(Str)) = 0 Then              '����ʱ���ʶ
                    '    MsgBox("���ĳ��� " & Str & " ,���Ǵ�ͼ����,������" & i + 1 & "��!")
                    '    Exit Sub
                    'End If
                    'Str = FetchStr(txtLine)
                    'txtLine = Mid(txtLine, Len(Str) + 2)
                    'If Len(Trim(Str)) = 0 Then              '����ʱ���ʶ
                    '    MsgBox("���ĳ��� " & Str & " ,���Ǵ�ͼ����,������" & i + 1 & "��!")
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
                    'If Len(Trim(Str)) = 0 Then              '����˾��ʶ
                    '    'MsgBox("���ĳ��� "& str &" ,���Ǵ�ͼ����!")
                    '    'Exit Sub
                    'Else
                    '    ShipLineCode = Trim(Str)
                    'End If
                End If
            End If
        End If
        '*************�����¼ ����ͷ��¼
        txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
        If txtLine = Nothing Then
            MsgBox("���ĳ���!")
            Exit Sub
        Else
            i = i + 1
            Str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(Str) + 2)
            If Trim(Str) <> "UNH" Then                        '����ͷ��¼
                MsgBox("���ĳ��� " & Str & " ,������" & i + 1 & "��!")
                Exit Sub
            Else
                Str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(Str) + 2)
                If Len(Trim(Str)) = 0 Then                    'ʱ���ʶ
                    MsgBox("���ĳ��� " & Str & " ,������" & i + 1 & "��!")
                    Exit Sub
                End If
                Str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(Str) + 2)
                If Len(Trim(Str)) <> 0 Then
                    If InStr(UCase(Trim(Str)), "911") > 0 And InStr(UCase(Trim(Str)), "BAPLIE") > 0 Then           '��ͼ��ʶ 
                        Call ReadUNFile911(strFile)
                        Exit Sub
                    ElseIf InStr(UCase(Trim(Str)), "95B") > 0 And InStr(UCase(Trim(Str)), "BAPLIE") > 0 Then        '��ͼ��ʶ 
                        Call ReadUNFile95B(strFile)
                        Exit Sub
                    Else
                        MsgBox("���İ汾����" & Str & " ,������" & i + 1 & "��!")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ReadUNFile911(ByVal strFile As String)
        Dim sr As New StreamReader(Mid(txtFile.Text, 1, FindLOC(txtFile.Text) - 1) & "\UnTemp.txt") '�򿪱����ļ�
        Dim txtLine As String
        Dim sTemp As String
        Dim i As Integer = 0 '��¼����
        Dim j As Integer = 0 'ȡ����Ϣѭ��
        Dim i99 As Integer '�жϽ���
        Dim str As String
        Dim s As String
        Dim Mark As Integer = 0 '**********��ʶĳ���Ƿ����� 1��ʾ������ 0��ʾδ������

        Dim ShipName As String = "" '����
        Dim ShipCode As String = "" '������
        Dim Voyage As String = "" '����
        Dim ShipLineCode As String = "" '����˾����
        Dim ShipLine As String = "" '����˾
        Dim ConNo As String = "" '���
        Dim ConType As String = "" '��ߴ�����
        Dim ConStatus As String = "" '��״̬
        Dim ConBay As String = "" '�䱴λ��
        Dim ConTempUnit As String = "" '�¶ȼ�����λ
        Dim ConTempSet As String = "" '�����¶�
        Dim ConTempMax As String = "" '�������¶�
        Dim ConTempMin As String = "" '�������¶�
        Dim ConOverFront As String = "" 'ǰ��
        Dim ConOverBack As String = "" '��
        Dim ConOverLeft As String = "" '��
        Dim ConOverRight As String = "" '�ҳ�
        Dim ConOverHeight As String = "" '����
        Dim ConGrossWeight As String = "" '��ë��
        Dim ConTareWeight As String = "" '��Ƥ��
        Dim ConOperatorCode As String = "" '�侭Ӫ�˴���
        Dim ConOperator As String = "" '�侭Ӫ��
        Dim BLNO As String = "" '�ᵥ��
        Dim LoadPortCode As String = "" 'װ���۴���
        Dim LoadPort As String = "" 'װ����
        Dim unLoadPortCode As String = "" 'ж���۴���
        Dim unLoadPort As String = "" 'ж����
        Dim DeliveryPlaceCode As String = "" '�����ش���
        Dim DeliveryPlace As String = "" '������
        Dim DangerousClass As String = "" 'Σ��Ʒ����
        Dim DangerousPage As String = "" 'Σ��Ʒҳ��
        Dim DangerousUNNO As String = "" '���Ϲ�Σ��Ʒ���
        Dim DangerousLabel As String = "" 'Σ��Ʒ��ǩ
        Dim CargoDescr As String = "" '��������
        Dim ConDescr As String = ""
        Dim sign As String = ""
        Dim Length As String = ""
        Dim width As String = ""
        Dim Height As String = ""
        '**************������ͷ
        txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��

        '***********�����¼ �ļ� ͷ��¼
        If txtLine = Nothing Then
            MsgBox("���ĳ���!")
            Exit Sub
        Else
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "UNB" Then
                MsgBox("���ĳ��� " & str & " ,������" & i + 1 & "��!")
                Exit Sub
            Else
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) <> "UNOA:1" And Trim(str) <> "UNOA:2" And Trim(str) <> "UNOA:3" Then                      '��ͼ��ʶ
                    'MsgBox("���ĳ��� " & str & " ,�﷨��ʶ����汾�Ŵ���,������" & i + 1 & "��!")
                    'Exit Sub
                Else
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then              '���ͷ���ʶ
                        'MsgBox("���ĳ��� " & str & " ,���Ǵ�ͼ����,������" & i + 1 & "��!")
                        'Exit Sub
                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then              '���ܷ���ʶ
                        'MsgBox("���ĳ��� " & str & " ,���Ǵ�ͼ����,������" & i + 1 & "��!")
                        'Exit Sub
                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then              '����ʱ���ʶ
                        'MsgBox("���ĳ��� " & str & " ,���Ǵ�ͼ����,������" & i + 1 & "��!")
                        'Exit Sub
                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then              '����ʱ���ʶ
                        'MsgBox("���ĳ��� " & str & " ,���Ǵ�ͼ����,������" & i + 1 & "��!")
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
                    If Len(Trim(str)) = 0 Then              '����˾��ʶ
                        'MsgBox("���ĳ��� "& str &" ,���Ǵ�ͼ����!")
                        'Exit Sub
                    Else
                        ShipLineCode = Trim(str)
                    End If
                End If
            End If
        End If
        '*************�����¼ ����ͷ��¼
        txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
        If txtLine = Nothing Then
            MsgBox("���ĳ���!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "UNH" Then                        '����ͷ��¼
                MsgBox("���ĳ��� " & str & " ,������" & i + 1 & "��!")
                Exit Sub
            Else
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) = 0 Then                    'ʱ���ʶ
                    'MsgBox("���ĳ��� " & str & " ,������" & i + 1 & "��!")
                    'Exit Sub
                End If
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) <> 0 Then
                    If InStr(UCase(Trim(str)), "911") = 0 And InStr(UCase(Trim(str)), "BAPLIE") = 0 Then      '��ͼ��ʶ 
                        MsgBox("���ĳ��� " & str & " ,��ͼ��ʶ ���İ汾�ų���,������" & i + 1 & "��!")
                        Exit Sub
                    End If
                End If
            End If
        End If
        '*************�����¼ ���Ŀ�ʼ��¼
        txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
        If txtLine = Nothing Then
            MsgBox("���ĳ���!���Ŀ�ʼ��¼ ,������" & i + 1 & "��!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "BGM" Then                        '����ͷ��¼
                MsgBox("���ı��Ŀ�ʼ��¼BGM���� " & str & " ,������" & i + 1 & "��!")
                Exit Sub
            Else
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) = 0 Then                    'ʱ���ʶ 
                    'MsgBox("����ʱ���ʶ���� " & str & " ,������" & i + 1 & "��!")
                    'Exit Sub
                End If

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) <> "2" And Trim(str) <> "4" And Trim(str) <> "5" And Trim(str) <> "9" And Trim(str) <> "22" Then                     '���Ĺ��ܱ�ʶ 
                    'MsgBox("���ı��Ĺ��ܱ�ʶ���� " & str & " ,������" & i + 1 & "��!")
                    'Exit Sub
                Else

                End If
            End If
        End If
        '*************�����¼ ���Ŀ�ʼʱ���¼
        txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
        If txtLine = Nothing Then
            MsgBox("���Ŀ�ʼʱ���¼����,������" & i + 1 & "��!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "DTM" Then                        '����ͷ��¼
                MsgBox("����DTM���� " & str & " ,������" & i + 1 & "��!")
                Exit Sub
            Else

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) = 0 Then                    'ʱ���ʶ 
                    'MsgBox("����ʱ���ʶ ���� " & str & " ,������" & i + 1 & "��!")
                    'Exit Sub
                Else
                    If Mid(Trim(str), 1, 3) <> "137" Then
                        'MsgBox("����137���� " & str & " ,������" & i + 1 & "��!")
                        'Exit Sub
                    End If
                End If


            End If
        End If

        '*************�����¼ �����йصĻ���������Ŀ
        txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
        If txtLine = Nothing Then
            MsgBox("���ĳ���,������" & i + 1 & "��!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "TDT" Then                        '����ͷ��¼
                MsgBox("����ͷ��¼TDT���� " & str & " ,������" & i + 1 & "��!")
                Exit Sub
            Else

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) <> "20" Then                    '�޶��� 
                    'MsgBox("�����޶���20���� " & str & " ,������" & i + 1 & "��!")
                    'Exit Sub
                End If

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) = 0 Then                  '���� 
                    'MsgBox("���ĺ��γ��� " & str & " ,������" & i + 1 & "��!")
                    'Exit Sub
                Else
                    Voyage = str
                End If
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) = 0 Then                  '���� ����
                    'MsgBox("���ĺ��� �������� " & str & " ,������" & i + 1 & "��!")
                    'Exit Sub
                Else
                    If Mid(Trim(str), 1, 1) <> ":" Then
                        sign = Mid(Trim(str), 1, InStr(Trim(str), ":") - 1)
                    End If
                    If Mid(Trim(str), InStr(Trim(str), ":") + 1, 3) <> "103" Then
                        'MsgBox("����103���� " & str & " ,������" & i + 1 & "��!")
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
                If Len(Trim(str)) = 0 Then                  '������
                    'MsgBox("���ĳ����˳��� " & str & " ,������" & i + 1 & "��!")
                    'Exit Sub
                Else
                    If Mid(Trim(str), Len(Trim(str)) - 5, 6) <> "172:20" Then
                        'MsgBox("����172:20���� " & str & " ,������" & i + 1 & "��!")
                        'Exit Sub
                    End If
                End If


            End If
        End If
        '*************�����¼ װ����
        txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
        If txtLine = Nothing Then
            MsgBox("����װ���۳���,������" & i + 1 & "��!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "LOC" Then                        '����ͷ��¼
                MsgBox("����ͷ��¼LOC���� " & str & " ,������" & i + 1 & "��!")
                Exit Sub
            Else

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) <> "5" Then                      'װ���۱�ʶ 
                    MsgBox("װ���۱�ʶ5���� " & str & " ,������" & i + 1 & "��!")
                    Exit Sub
                End If

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) = 0 Then                     'װ����
                    'MsgBox("���ĳ��� "& str &" ,������" & i + 1 & "��!")
                    'Dim Frm As New FrmReadTemp
                    'G_SelectStr = "�˱��� " & "  װ���ۿմ���"
                    'Frm.ShowDialog()
                    'LoadPortCode = Trim(G_SelectCode)
                Else
                    LoadPortCode = Trim(str)
                End If
            End If
        End If
        '*************�����¼ ж����
        txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
        s = txtLine
        If txtLine = Nothing Then
            MsgBox("����ж���۳���,������" & i + 1 & "��!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "LOC" Then                        '����ͷ��¼
                'MsgBox("����ͷ��¼LOC���� " & str & " ,������" & i + 1 & "��!")
                Mark = 0
                'Exit Sub
            Else
                Mark = 1
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) <> "61" Then                      'ж���۱�ʶ 
                    MsgBox("����ж���۱�ʶ61���� " & str & " ,������" & i + 1 & "��!")
                    Exit Sub
                End If

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) = 0 Then                     'ж����
                    'MsgBox("���ĳ��� "& str &" ,������" & i + 1 & "��!")
                    'Dim Frm As New FrmReadTemp
                    'G_SelectStr = "�˱��� " & "  ж���ۿմ���"
                    'Frm.ShowDialog()
                    'unLoadPortCode = Trim(G_SelectCode)
                Else
                    unLoadPortCode = Trim(str)
                End If
            End If
        End If

        '*************�����¼ ����178ʱ���¼
        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
            s = txtLine
        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("����178or 132 ʱ���¼����,������" & i + 1 & "��!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "DTM" Then                        '����ͷ��¼
                MsgBox("����ͷ��¼DTM���� " & str & " ,������" & i + 1 & "��!")
                Exit Sub
            Else

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Mid(Trim(str), 1, 3) = "178" Or Mid(Trim(str), 1, 3) = "132" Then                  'ʱ���ʶ 
                    Mark = 1
                Else
                    Mark = 0
                End If
            End If
        End If
        '*************�����¼ ����136ʱ���¼
        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
            s = txtLine
        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("����136 or 133ʱ���¼����,������" & i + 1 & "��!")
            Exit Sub
        Else
            If Mark = 1 Then i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "DTM" Then                        '����ͷ��¼
                Mark = 0
                'MsgBox("����ͷ��¼DTM���� " & str & " ,������" & i + 1 & "��!")
                'Exit Sub
            Else
                Mark = 1
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Mid(Trim(str), 1, 3) = "136" Or Mid(Trim(str), 1, 3) = "133" Then                   'ʱ���ʶ 
                    Mark = 1
                Else
                    Mark = 0
                    'MsgBox("����ʱ���ʶ 136 �� 133���� " & str & " ,������" & i + 1 & "��!")
                    'Exit Sub
                End If
            End If
        End If
        '*************�����¼ ����132ʱ���¼

        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
            s = txtLine
        Else
            txtLine = s
        End If

        If txtLine = Nothing Then
            MsgBox("����132ʱ���¼����,������" & i + 1 & "��!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "DTM" Then                '����ͷ��¼
                Mark = 0
                'MsgBox("����ͷ��¼DTM���� " & str & " ,������" & i + 1 & "��!")
                'Exit Sub
            Else
                Mark = 1
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Mid(Trim(str), 1, 3) = "132" Then                  'ʱ���ʶ 
                    Mark = 1
                Else
                    Mark = 0
                    'MsgBox("����ʱ���ʶ132���� " & str & " ,������" & i + 1 & "��!")
                    'Exit Sub
                End If
            End If
        End If
        '*************�����¼ ����RFFʱ���¼

        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
            s = txtLine
        Else
            txtLine = s
        End If

        If txtLine = Nothing Then
            MsgBox("����RFFʱ���¼����,������" & i + 1 & "��!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "RFF" Then                        '����ͷ��¼
                Mark = 0
                'MsgBox("����ͷ��¼RFF���� " & str & " ,������" & i + 1 & "��!")
                'Exit Sub
            Else
                Mark = 1
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Mid(Trim(str), 1, 3) = "VON" Then                 'װ������
                    Mark = 1
                Else
                    Mark = 1
                    'MsgBox("����װ������VON���� " & str & " ,������" & i + 1 & "��!")
                    'Exit Sub
                End If


            End If
        End If
        '*************�����¼ ����FTXʱ���¼

        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
            s = txtLine
        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("����FTXʱ���¼����,������" & i + 1 & "��!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If UCase(Trim(str)) = "FTX" Then                        '����ͷ��¼
                Mark = 1
            Else
                Mark = 0
            End If
        End If

        '*****************��װ����Ϣ (��ʼѭ��)
        Do While j < 9999
            If j < 2000 Then
                PB.Value = j
            End If
            ConNo = ""
            ConType = ""
            ConStatus = ""
            ConBay = ""  '�䱴λ��
            ConTempUnit = ""  '�¶ȼ�����λ
            ConTempSet = "" '�����¶�
            ConTempMax = ""  '�������¶�
            ConTempMin = ""  '�������¶�
            ConOverFront = ""  'ǰ��
            ConOverBack = ""  '��
            ConOverLeft = ""  '��
            ConOverRight = "" '�ҳ�
            ConOverHeight = ""  '����
            ConGrossWeight = ""  '��ë��
            ConTareWeight = ""  '��Ƥ��
            ConOperatorCode = ""  '�侭Ӫ�˴���
            ConOperator = ""  '�侭Ӫ��
            BLNO = ""  '�ᵥ��
            LoadPortCode = ""  'װ���۴���
            LoadPort = ""  'װ����
            unLoadPortCode = ""  'ж���۴���
            unLoadPort = ""  'ж����
            DeliveryPlaceCode = ""  '�����ش���
            DeliveryPlace = ""  '������
            DangerousClass = ""  'Σ��Ʒ����
            DangerousPage = ""  'Σ��Ʒҳ��
            DangerousUNNO = ""  '���Ϲ�Σ��Ʒ���
            DangerousLabel = ""  'Σ��Ʒ��ǩ
            CargoDescr = ""  '��������
            ConDescr = ""
            Length = ""
            width = ""
            Height = ""
            i99 = 0
            '*************�����¼  ������װ����Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())             '********��λ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ������¼  ������װ����Ϣ!,������" & i + 1 & "��!")
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
                    If Trim(str) <> "147" Then           '******��λ�޶�������
                        MsgBox("���ı�λ�޶���LOC147���� " & str & " ,������" & i + 1 & "��!")
                        Exit Sub
                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then
                        'MsgBox("���ĳ��� " & str & " ,������" & i + 1 & "��!")
                        ConBay = ""
                    Else
                        ConBay = Mid(Trim(str), 1, 7)   '******��λ��
                        If Len(Trim(ConBay)) = 6 Then
                            ConBay = "0" & ConBay
                        End If
                    End If
                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())             '********GID ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���GID ��!,������" & i + 1 & "��!")
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
                txtLine = Trim(sr.ReadLine())             '********GDS �������ʶ�
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���GDS �������ʶ�!,������" & i + 1 & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                '*******GDS ��������
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "GDS" Then
                    i99 = 1
                    Mark = 1
                Else
                    Mark = 0
                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())             '********FTX ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���FTX ��!,������" & i + 1 & "��!")
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
                txtLine = Trim(sr.ReadLine())             '********FTX ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���FTX ��!,������" & i + 1 & "��!")
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
                txtLine = Trim(sr.ReadLine())             '********MEA ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���MEA ��!,������" & i + 1 & "��!")
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
                    If Trim(str) <> "WT" Then               '*****�����޶���
                        MsgBox("���������޶���WT���� " & str & " ,������" & i + 1 & "��!")
                        Exit Sub
                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then             '*****�����޶���
                        'MsgBox("���������޶���KGM LBR���� " & str & " ,������" & i + 1 & "��!")
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
                    txtLine = Trim(sr.ReadLine())                 '********DIM ��
                    s = txtLine
                Else
                    txtLine = s
                End If
                If txtLine = Nothing Then
                    MsgBox("���ĳ���DIM ��!,������" & i + 1 & "��!")
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
                        If Trim(str) <> "1" And Trim(str) <> "5" And Trim(str) <> "6" And Trim(str) <> "7" And Trim(str) <> "8" And Trim(str) <> "9" Then                 '*****�����޶���
                            'MsgBox("���������޶���1 5 6 7 8 9���� " & str & " ,������" & i + 1 & "��!")
                            'Exit Sub
                        Else
                            sTemp = Trim(str)
                        End If
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) = 0 Then             '*****�����䶨��
                            'MsgBox("���ĳ����䶨��CMT ���� " & str & " ,������" & i + 1 & "��!")
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
                txtLine = Trim(sr.ReadLine())                 '********TMP ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���TMP ��!,������" & i + 1 & "��!")
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
                    If Trim(str) <> "1" And Trim(str) <> "2" Then                 '*****�����
                        'MsgBox("������������ " & str & " ,������" & i + 1 & "��!")
                        'Exit Sub

                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then             '*****�����
                        'MsgBox("������������ " & str & " ,������" & i + 1 & "��!")
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
                txtLine = Trim(sr.ReadLine())                 '********RNG ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���RNG ��!,������" & i + 1 & "��!")
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
                    If Trim(str) <> "ZZZ" Then                  '*****������¶ȷ�Χ
                        'MsgBox("����������¶ȷ�Χ���� " & str & " ,������" & i + 1 & "��!")
                        'Exit Sub

                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then             '*****�����
                        'MsgBox("������������ " & str & " ,������" & i + 1 & "��!")
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
                txtLine = Trim(sr.ReadLine())                 '********װ���� ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���װ���� ��!,������" & i + 1 & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******װ����
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "6" Then                  '*****װ����
                        MsgBox("���ĳ��� " & str & " ,������" & i + 1 & "��!")
                        Exit Sub

                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then             '*****װ����
                        LoadPortCode = ""
                    Else
                        LoadPortCode = Trim(str)
                    End If
                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********ж���� ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���ж���� ��!,������" & i + 1 & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******ж���� 
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "12" Then                   '*****ж���� 
                        MsgBox("���ĳ��� " & str & " ,������" & i + 1 & "��!")
                        Exit Sub

                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then             '*****ж���� 
                        unLoadPortCode = ""
                    Else
                        unLoadPortCode = Trim(str)
                    End If
                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********��ѡж���� ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���!,������" & i + 1 & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******��ѡж���� ��
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "97" Then                   '*****��ѡж���� ��
                        Mark = 0
                    Else
                        Mark = 1
                    End If

                Else
                    Mark = 0
                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********Ŀ�ĸ� ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���Ŀ�ĸ� ��!,������" & i + 1 & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******Ŀ�ĸ�
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "83" Then                   '*****Ŀ�ĸ�
                        MsgBox("���ĳ���Ŀ�ĸ� " & str & " ,������" & i + 1 & "��!")
                        Exit Sub

                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then             '*****Ŀ�ĸ�                        
                        DeliveryPlaceCode = Trim(str)
                    End If
                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********��ѡĿ�ĸ�1 ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! ,������" & i + 1 & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******��ѡĿ�ĸ�
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "63" Then                   '*****��ѡĿ�ĸ�
                        Mark = 0
                    Else
                        Mark = 1
                    End If

                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********��ѡĿ�ĸ�2 ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! ,������" & i + 1 & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******��ѡĿ�ĸ�
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "65" Then                   '*****��ѡĿ�ĸ�
                        Mark = 0
                    Else
                        Mark = 1
                    End If

                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********��ѡĿ�ĸ�3 ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! ,������" & i + 1 & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******��ѡĿ�ĸ�
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "69" Then                   '*****��ѡĿ�ĸ�
                        Mark = 0
                    Else
                        Mark = 1
                    End If

                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********��ѡĿ�ĸ�4 ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! ,������" & i + 1 & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******��ѡĿ�ĸ�
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "71" Then                   '*****��ѡĿ�ĸ�
                        Mark = 0
                    Else
                        Mark = 1
                    End If

                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********��ѡĿ�ĸ�5 ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! ,������" & i + 1 & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******��ѡĿ�ĸ�
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "74" Then                   '*****��ѡĿ�ĸ�
                        Mark = 0
                    Else
                        Mark = 1
                    End If

                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********�ᵥ�� ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ����ᵥ�� ��! ,������" & i + 1 & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******�ᵥ�� 
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "RFF" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Mid(Trim(str), 1, 2) <> "BM" Then                      '*****�ᵥ�� 
                        'MsgBox("���ĳ����ᵥ�� �� " & str & " ,������" & i + 1 & "��!")
                        'Exit Sub
                        'Mark = 0
                    Else
                        BLNO = Mid(Trim(str), 4)                '*****�ᵥ�� 
                        Mark = 1
                    End If

                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********����Ϣ ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ�������Ϣ ��!,������" & i + 1 & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******����Ϣ
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "EQD" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "CN" And Trim(str) <> "BB" And Trim(str) <> "ZZZ" Then                         '*****����Ϣ
                        'MsgBox("���ĳ��� CN BB ZZZ" & str & " ,������" & i + 1 & "��!")
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
                    txtLine = Trim(sr.ReadLine())                 '********EQA �ʲ����� ��
                    s = txtLine
                Else
                    txtLine = s
                End If
                If txtLine = Nothing Then
                    MsgBox("���ĳ���EQA �ʲ����� ��!,������" & i + 1 & "��!")
                    Exit Sub
                Else
                    If Mark = 1 Then i = i + 1
                    str = FetchStr(txtLine)                      '*******EQA �ʲ����� ��
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
                txtLine = Trim(sr.ReadLine())                 '********�侭Ӫ�� ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ��� �侭Ӫ�� ��!,������" & i + 1 & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******�侭Ӫ��
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "NAD" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "CA" Then                          '*****�侭Ӫ��
                        'MsgBox("���ĳ����侭Ӫ��CA " & str & " ,������" & i + 1 & "��!")
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
                            '    'MsgBox("���ĳ��� 172:20 172:ZZZ" & str & " ,������" & i + 1 & "��!")
                            '    'Exit Sub
                            '    Mark = 0
                            'End If
                        End If
                    End If
                Else

                        Mark = 0

                End If
            End If
            '*************************У��
            If i99 = 1 Then
                If Len(Trim(ConNo)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "����  ��ſմ���,������" & i & "��!"
                    Frm.ShowDialog()
                    ConNo = Trim(G_SelectCode)
                    If Len(Trim(ConNo)) = 12 Then
                        ConNo = Mid(Trim(ConNo), 1, 4) & Mid(Trim(ConNo), 6, 7)
                    End If
                End If
                If Len(Trim(ConType)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "�� " & ConNo & " ���ʹ���մ���"
                    Frm.ShowDialog()
                    ConType = Trim(G_SelectCode)
                End If
                If Len(Trim(ConStatus)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "�� " & ConNo & " ����ؿմ���"
                    Frm.ShowDialog()
                    ConStatus = Trim(G_SelectCode)
                End If
                If Len(Trim(LoadPortCode)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "�� " & ConNo & " װ���۴���մ���"
                    Frm.ShowDialog()
                    LoadPortCode = Trim(G_SelectCode)
                End If
                If Len(Trim(unLoadPortCode)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "�� " & ConNo & " ж���۴���մ���"
                    Frm.ShowDialog()
                    unLoadPortCode = Trim(G_SelectCode)
                End If
                If Len(Trim(ConBay)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "�� " & ConNo & "  Bay �� �մ���"
                    Frm.ShowDialog()
                    ConBay = Trim(G_SelectCode)
                End If
                If Len(Trim(ConGrossWeight)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "�� " & ConNo & "  ��ë�� �մ���"
                    Frm.ShowDialog()
                    ConGrossWeight = Trim(G_SelectCode)
                End If
                'If Len(Trim(ConOperatorCode)) = 0 Then
                'Dim Frm As New FrmReadTemp
                'G_SelectStr = "�� " & ConNo & " �侭Ӫ�˴���մ���"
                'Frm.ShowDialog()
                'ConOperatorCode = Trim(G_SelectCode)
                'End If
            End If
            '*************************
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********Σ��Ʒ ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******Σ��Ʒ
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "DGS" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "IMD" And Trim(str) <> "IMO" And Trim(str) <> "IMDG" Then                          '*****Σ��Ʒ
                        'MsgBox("���ĳ��� Σ��ƷIMD ��ʶ���� " & str & " ,������" & i + 1 & "��!")
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
                                G_SelectStr = "�� " & ConNo & " Σ��Ʒ�ȼ��մ���"
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
                txtLine = Trim(sr.ReadLine())                 '********Σ��ƷFTX ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******Σ��ƷFTX
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
                '*****************д������Ϣ
                Dim Size As String = "0"
                Dim Type As String = "0"
                Dim sqlstr As String
                Dim SSSS As String = "0"
                '*****************ȡ����
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
                        'MsgBox("�������ͳߴ� " & ConType & " ����,������" & i + 1 & "����Χ��������!")
                        'Dim Frm As New FrmReadTemp
                        'G_SelectStr = "�� " & ConNo & "  ���ʹ���" & ConType
                        'Frm.ShowDialog()
                        'ConType = Trim(G_SelectCode)
                        Size = Mid(ConType, 1, 2)
                    End If
                    SSSS = "0"
                    Type = Mid(ConType, 3, 2)
                End If
                ds.Dispose()
                dw.Dispose()

                '��Ƥ�� ë��
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
                '*********************д�뼯װ������봬��˾���ʹ�����ձ�

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
                '*********************д�봬ͼ��ʱ����Ϣ
                ds.Reset()

                sqlstr = "select * from CON_IMAGE_RECORD where CONTAINER_NO='" & ConNo & "' and BayNo='" & Mid(Trim(ConBay), 2, 6) & "' and Ship_ID=" & Ship_ID
                dw = Updatedata(sqlda, sqlstr, ds)
                If dw.Count = 0 Then
                    Dim row As DataRow
                    row = ds.Tables(0).NewRow()
                    row("Ship_ID") = Ship_ID
                    row("CONTAINER_NO") = Trim(ConNo)
                    row("Size_Con") = CInt(SSSS)
                    '******************δת���Ĵ���
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
        '*************���� UNT
        PB.Value = 2000
        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
            s = txtLine
        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("���ĳ���!���� UNT,������" & i + 1 & "��!")
            Exit Sub
        Else
            If Mark = 1 Then i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) = "UNT" Then
                Mark = 1
                str = FetchStr(txtLine)
                If i <> CInt(str) Then
                    MsgBox("������������,������" & i + 1 & "��!")
                Else

                End If
            Else
                MsgBox("���Ķ�ȡ����,������" & i + 1 & "��!")
                Exit Sub
            End If
        End If
        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
            s = txtLine

        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("���ĳ���!���� UNZ,������" & i + 2 & "��!")
            Exit Sub
        Else

            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) = "UNZ" Then
                str = FetchStr(txtLine)
                If Trim(str) <> "1" Then
                    MsgBox("���Ķ�ȡ����,������" & i + 2 & "��!")
                    Exit Sub
                Else
                    MsgBox("���Ķ�ȡ��ȷ! ������ " & i & " ��")
                End If
            Else
                MsgBox("���Ķ�ȡ����,������" & i + 2 & "��!")
                Exit Sub
            End If
        End If

        sr.Close()
        Me.Close()

    End Sub
    Private Sub ReadUNFile95B(ByVal strFile As String)
        Dim sr As New StreamReader(Mid(txtFile.Text, 1, FindLOC(txtFile.Text) - 1) & "\UnTemp.txt") '�򿪱����ļ�
        Dim txtLine As String
        Dim sTemp As String
        Dim i As Integer = 0 '��¼����
        Dim j As Integer = 0 'ȡ����Ϣѭ��
        Dim i99 As Integer '�жϽ���
        Dim str As String
        Dim s As String
        Dim Mark As Integer = 0 '**********��ʶĳ���Ƿ����� 1��ʾ������ 0��ʾδ������

        Dim ShipName As String = "" '����
        Dim ShipCode As String = "" '������
        Dim Voyage As String = "" '����
        Dim ShipLineCode As String = "" '����˾����
        Dim ShipLine As String = "" '����˾
        Dim ConNo As String = "" '���
        Dim ConType As String = "" '��ߴ�����
        Dim ConStatus As String = "" '��״̬
        Dim ConBay As String = "" '�䱴λ��
        Dim ConTempUnit As String = "" '�¶ȼ�����λ
        Dim ConTempSet As String = "" '�����¶�
        Dim ConTempMax As String = "" '�������¶�
        Dim ConTempMin As String = "" '�������¶�
        Dim ConOverFront As String = "" 'ǰ��
        Dim ConOverBack As String = "" '��
        Dim ConOverLeft As String = "" '��
        Dim ConOverRight As String = "" '�ҳ�
        Dim ConOverHeight As String = "" '����
        Dim ConGrossWeight As String = "" '��ë��
        Dim ConTareWeight As String = "" '��Ƥ��
        Dim ConOperatorCode As String = "" '�侭Ӫ�˴���
        Dim ConOperator As String = "" '�侭Ӫ��
        Dim BLNO As String = "" '�ᵥ��
        Dim LoadPortCode As String = "" 'װ���۴���
        Dim LoadPort As String = "" 'װ����
        Dim unLoadPortCode As String = "" 'ж���۴���
        Dim unLoadPort As String = "" 'ж����
        Dim DeliveryPlaceCode As String = "" '�����ش���
        Dim DeliveryPlace As String = "" '������
        Dim DangerousClass As String = "" 'Σ��Ʒ����
        Dim DangerousPage As String = "" 'Σ��Ʒҳ��
        Dim DangerousUNNO As String = "" '���Ϲ�Σ��Ʒ���
        Dim DangerousLabel As String = "" 'Σ��Ʒ��ǩ
        Dim CargoDescr As String = "" '��������
        Dim ConDescr As String = ""
        Dim sign As String = ""
        Dim Length As String = ""
        Dim width As String = ""
        Dim Height As String = ""

        '**************������ͷ
        txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��

        '***********�����¼ �ļ� ͷ��¼
        If txtLine = Nothing Then
            MsgBox("���ĳ���!")
            Exit Sub
        Else
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "UNB" Then
                MsgBox("���ĳ��� " & str & " ,������" & i + 1 & "��!")
                Exit Sub
            Else
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) <> "UNOA:1" And Trim(str) <> "UNOA:2" And Trim(str) <> "UNOA:3" Then                       '��ͼ��ʶ
                    'MsgBox("���ĳ��� " & str & " ,�﷨��ʶ����汾�Ŵ���,������" & i + 1 & "��!")
                    'Exit Sub
                Else
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then              '���ͷ���ʶ
                        'MsgBox("���ĳ��� " & str & " ,���Ǵ�ͼ����,������" & i + 1 & "��!")
                        'Exit Sub
                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then              '���ܷ���ʶ
                        'MsgBox("���ĳ��� " & str & " ,���Ǵ�ͼ����,������" & i + 1 & "��!")
                        'Exit Sub
                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then              '����ʱ���ʶ
                        'MsgBox("���ĳ��� " & str & " ,���Ǵ�ͼ����,������" & i + 1 & "��!")
                        'Exit Sub
                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then              '����ʱ���ʶ
                        'MsgBox("���ĳ��� " & str & " ,���Ǵ�ͼ����,������" & i + 1 & "��!")
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
                    'If Len(Trim(str)) = 0 Then              '����˾��ʶ
                    '    'MsgBox("���ĳ��� "& str &" ,���Ǵ�ͼ����!")
                    '    'Exit Sub
                    'Else
                    '    ShipLineCode = Trim(str)
                    'End If
                End If
            End If
        End If
        '*************�����¼ ����ͷ��¼
        txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
        If txtLine = Nothing Then
            MsgBox("���ĳ���!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "UNH" Then                        '����ͷ��¼
                MsgBox("���ĳ��� " & str & " ,������" & i + 1 & "��!")
                Exit Sub
            Else
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) = 0 Then                    'ʱ���ʶ
                    'MsgBox("���ĳ��� " & str & " ,������" & i + 1 & "��!")
                    'Exit Sub
                End If
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) <> 0 Then
                    If InStr(UCase(Trim(str)), "BAPLIE") = 0 And InStr(UCase(Trim(str)), "95B") = 0 Then   '��ͼ��ʶ 
                        MsgBox("���ĳ��� " & str & " ,��ͼ��ʶ ���İ汾�ų���,������" & i + 1 & "��!")
                        Exit Sub
                    End If
                End If
            End If
        End If
        '*************�����¼ ���Ŀ�ʼ��¼
        txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
        If txtLine = Nothing Then
            MsgBox("���ĳ���!���Ŀ�ʼ��¼ ,������" & i + 1 & "��!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "BGM" Then                        '����ͷ��¼
                MsgBox("���ı��Ŀ�ʼ��¼BGM���� " & str & " ,������" & i + 1 & "��!")
                Exit Sub
            Else
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) <> "2" And Trim(str) <> "4" And Trim(str) <> "5" And Trim(str) <> "9" And Trim(str) <> "22" Then                     '���Ĺ��ܱ�ʶ 
                    'MsgBox("���ı��Ĺ��ܱ�ʶ���� " & str & " ,������" & i + 1 & "��!")
                    'Exit Sub
                Else

                End If
            End If
        End If
        '*************�����¼ ���Ŀ�ʼʱ���¼
        txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
        If txtLine = Nothing Then
            MsgBox("���Ŀ�ʼʱ���¼����,������" & i + 1 & "��!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "DTM" Then                        '����ͷ��¼
                MsgBox("����DTM���� " & str & " ,������" & i + 1 & "��!")
                Exit Sub
            Else

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) = 0 Then                    'ʱ���ʶ 
                    'MsgBox("����ʱ���ʶ ���� " & str & " ,������" & i + 1 & "��!")
                    'Exit Sub
                Else
                    If Mid(Trim(str), 1, 3) <> "137" Then
                        'MsgBox("����137���� " & str & " ,������" & i + 1 & "��!")
                        'Exit Sub
                    End If
                End If


            End If
        End If
        Mark = 1
        '*************�����¼ �����йصĻ���������Ŀ
TT:     If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("���ĳ���,������" & i + 1 & "��!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "TDT" Then                        '����ͷ��¼
                MsgBox("����ͷ��¼TDT���� " & str & " ,������" & i + 1 & "��!")
                Exit Sub
            Else

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) <> "20" Then                    '�޶��� 
                    MsgBox("�����޶���20���� " & str & " ,������" & i + 1 & "��!")
                    Exit Sub
                End If

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) = 0 Then                  '���� 
                    'MsgBox("���ĺ��γ��� " & str & " ,������" & i + 1 & "��!")
                    'Exit Sub
                Else
                    Voyage = str
                End If
            End If
        End If
        '*************�����¼ װ����
        txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
        If txtLine = Nothing Then
            MsgBox("����װ���۳���,������" & i + 1 & "��!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "LOC" Then                        '����ͷ��¼
                MsgBox("����ͷ��¼LOC���� " & str & " ,������" & i + 1 & "��!")
                Exit Sub
            Else

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) <> "5" Then                      'װ���۱�ʶ 
                    MsgBox("װ���۱�ʶ5���� " & str & " ,������" & i + 1 & "��!")
                    Exit Sub
                End If

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) = 0 Then                     'װ����
                    'MsgBox("���ĳ��� "& str &" ,������" & i + 1 & "��!")
                    'Dim Frm As New FrmReadTemp
                    'G_SelectStr = "�˱��� " & "  װ���ۿմ���"
                    'Frm.ShowDialog()
                    'LoadPortCode = Trim(G_SelectCode)
                Else
                    LoadPortCode = Trim(str)
                End If
            End If
        End If
        '*************�����¼ ж����
        txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
        s = txtLine
        If txtLine = Nothing Then
            MsgBox("����ж���۳���,������" & i + 1 & "��!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "LOC" Then                        '����ͷ��¼
                'MsgBox("����ͷ��¼LOC���� " & str & " ,������" & i + 1 & "��!")
                Mark = 0
                'Exit Sub
            Else
                Mark = 1
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) <> "61" Then                      'ж���۱�ʶ 
                    MsgBox("����ж���۱�ʶ61���� " & str & " ,������" & i + 1 & "��!")
                    Exit Sub
                End If

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) = 0 Then                     'ж����
                    'MsgBox("���ĳ��� "& str &" ,������" & i + 1 & "��!")
                    'Dim Frm As New FrmReadTemp
                    'G_SelectStr = "�˱��� " & "  ж���ۿմ���"
                    'Frm.ShowDialog()
                    'unLoadPortCode = Trim(G_SelectCode)
                Else
                    unLoadPortCode = Trim(str)
                End If
            End If
        End If

        '*************�����¼ ����178ʱ���¼
        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '���з�ʽ ��ȡһ��()
            s = txtLine
        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("����178 Or 132 ʱ���¼����,������" & i + 1 & "��!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "DTM" Then                        '����ͷ��¼
                MsgBox("����ͷ��¼DTM���� " & str & " ,������" & i + 1 & "��!")
                Exit Sub
            Else

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Mid(Trim(str), 1, 3) = "178" Or Mid(Trim(str), 1, 3) = "132" Then                  'ʱ���ʶ 
                    Mark = 1
                Else
                    Mark = 0
                End If
            End If
        End If
        '*************�����¼ ����136ʱ���¼
        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
            s = txtLine
        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("����136 OR 133 ʱ���¼����,������" & i + 1 & "��!")
            Exit Sub
        Else
            If Mark = 1 Then i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "DTM" Then                        '����ͷ��¼
                'MsgBox("����ͷ��¼DTM���� " & str & " ,������" & i + 1 & "��!")
                'Exit Sub
                Mark = 0
            Else
                Mark = 1
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Mid(Trim(str), 1, 3) = "136" Or Mid(Trim(str), 1, 3) = "133" Then                   'ʱ���ʶ 
                    Mark = 1
                Else
                    Mark = 0
                    'MsgBox("����ʱ���ʶ 136 �� 133���� " & str & " ,������" & i + 1 & "��!")
                    'Exit Sub
                End If
            End If
        End If
        '*************�����¼ ����132ʱ���¼

        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
            s = txtLine
        Else
            txtLine = s
        End If

        If txtLine = Nothing Then
            MsgBox("����132ʱ���¼����,������" & i + 1 & "��!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "DTM" Then                        '����ͷ��¼
                'MsgBox("����ͷ��¼DTM���� " & str & " ,������" & i + 1 & "��!")
                'Exit Sub
                Mark = 0
            Else

                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Mid(Trim(str), 1, 3) = "132" Then                  'ʱ���ʶ 
                    Mark = 1
                Else
                    Mark = 0
                    'MsgBox("����ʱ���ʶ132���� " & str & " ,������" & i + 1 & "��!")
                    'Exit Sub
                End If
            End If
        End If
        '*************�����¼ ����RFFʱ���¼

        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
            s = txtLine
        Else
            txtLine = s
        End If

        If txtLine = Nothing Then
            MsgBox("����RFFʱ���¼����,������" & i + 1 & "��!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "RFF" Then                        '����ͷ��¼
                'MsgBox("����ͷ��¼RFF���� " & str & " ,������" & i + 1 & "��!")
                'Exit Sub
                Mark = 0
            Else
                Mark = 1
                str = FetchStr(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Mid(Trim(str), 1, 3) = "VON" Or Mid(Trim(str), 1, 3) = "ZZZ" Then                 'װ������
                    Mark = 1
                Else
                    Mark = 1
                    'MsgBox("����װ������VON���� " & str & " ,������" & i + 1 & "��!")
                    'Exit Sub
                End If


            End If
        End If
        '*************�����¼ ����FTXʱ���¼

        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
            s = txtLine
        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("����FTXʱ���¼����,������" & i + 1 & "��!")
            Exit Sub
        Else
            i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If UCase(Trim(str)) = "FTX" Then                        '����ͷ��¼
                Mark = 1
            Else
                Mark = 0
            End If
        End If

        '*****************��װ����Ϣ (��ʼѭ��)
        Do While j < 9999
            If j < 2000 Then
                PB.Value = j
            End If
            ConNo = ""
            ConType = ""
            ConStatus = ""
            ConBay = ""  '�䱴λ��
            ConTempUnit = ""  '�¶ȼ�����λ
            ConTempSet = "" '�����¶�
            ConTempMax = ""  '�������¶�
            ConTempMin = ""  '�������¶�
            ConOverFront = ""  'ǰ��
            ConOverBack = ""  '��
            ConOverLeft = ""  '��
            ConOverRight = "" '�ҳ�
            ConOverHeight = ""  '����
            ConGrossWeight = ""  '��ë��
            ConTareWeight = ""  '��Ƥ��
            ConOperatorCode = ""  '�侭Ӫ�˴���
            ConOperator = ""  '�侭Ӫ��
            BLNO = ""  '�ᵥ��
            LoadPortCode = ""  'װ���۴���
            LoadPort = ""  'װ����
            unLoadPortCode = ""  'ж���۴���
            unLoadPort = ""  'ж����
            DeliveryPlaceCode = ""  '�����ش���
            DeliveryPlace = ""  '������
            DangerousClass = ""  'Σ��Ʒ����
            DangerousPage = ""  'Σ��Ʒҳ��
            DangerousUNNO = ""  '���Ϲ�Σ��Ʒ���
            DangerousLabel = ""  'Σ��Ʒ��ǩ
            CargoDescr = ""  '��������
            ConDescr = ""
            Length = ""
            width = ""
            Height = ""

            i99 = 0
            '*************�����¼  ������װ����Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())             '********��λ��
                s = txtLine
            Else
                txtLine = s
            End If
            If Mid(txtLine, 1, 3) = "TDT" Then   '*********��תѭ��
                Mark = 0
                GoTo TT
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ������¼  ������װ����Ϣ!,������" & i + 1 & "��!")
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
                    If Trim(str) <> "147" Then           '******��λ�޶�������
                        MsgBox("���ı�λ�޶���LOC147���� " & str & " ,������" & i + 1 & "��!")
                        Exit Sub
                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then
                        'MsgBox("���ĳ��� " & str & " ,������" & i + 1 & "��!")
                        ConBay = ""
                    Else
                        ConBay = Mid(Trim(str), 1, 7)   '******��λ��
                        If Len(Trim(ConBay)) = 6 Then
                            ConBay = "0" & ConBay
                        End If
                    End If
                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())             '********GID ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���GID ��!,������" & i + 1 & "��!")
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
                txtLine = Trim(sr.ReadLine())             '********GDS �������ʶ�
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���GDS �������ʶ�!,������" & i + 1 & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                '*******GDS ��������
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
                    txtLine = Trim(sr.ReadLine())             '********FTX ��
                    s = txtLine
                Else
                    txtLine = s
                End If

                If txtLine = Nothing Then
                    MsgBox("���ĳ���FTX ��!,������" & i + 1 & "��!")
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
                    txtLine = Trim(sr.ReadLine())             '********MEA ��
                    s = txtLine
                Else
                    txtLine = s
                End If
                If txtLine = Nothing Then
                    MsgBox("���ĳ���MEA ��!,������" & i + 1 & "��!")
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
                        If Trim(str) <> "WT" Then               '*****�����޶���
                            MsgBox("���������޶���WT���� " & str & " ,������" & i + 1 & "��!")
                            Exit Sub
                        End If
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) = 0 Then             '*****�����޶���
                            MsgBox("���������޶���KGM LBR���� " & str & " ,������" & i + 1 & "��!")
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
                    txtLine = Trim(sr.ReadLine())                 '********DIM ��
                    s = txtLine
                Else
                    txtLine = s
                End If
                If txtLine = Nothing Then
                    MsgBox("���ĳ���DIM ��!,������" & i + 1 & "��!")
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
                        If Trim(str) <> "1" And Trim(str) <> "5" And Trim(str) <> "6" And Trim(str) <> "7" And Trim(str) <> "8" And Trim(str) <> "9" Then                 '*****�����޶���
                            MsgBox("���������޶���1 5 6 7 8 9���� " & str & " ,������" & i + 1 & "��!")
                            Exit Sub
                        Else
                            sTemp = Trim(str)
                        End If
                        str = FetchStr(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        
                        If Len(Trim(str)) = 0 Then             '*****�����䶨��
                            MsgBox("���ĳ����䶨��CMT ���� " & str & " ,������" & i + 1 & "��!")
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
                txtLine = Trim(sr.ReadLine())                 '********TMP ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���TMP ��!,������" & i + 1 & "��!")
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
                    If Trim(str) <> "1" And Trim(str) <> "2" Then                 '*****�����
                        MsgBox("������������ " & str & " ,������" & i + 1 & "��!")
                        Exit Sub

                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then             '*****�����
                        MsgBox("������������ " & str & " ,������" & i + 1 & "��!")
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
                txtLine = Trim(sr.ReadLine())                 '********RNG ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���RNG ��!,������" & i + 1 & "��!")
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
                    If Trim(str) <> "ZZZ" Then                  '*****������¶ȷ�Χ
                        MsgBox("����������¶ȷ�Χ���� " & str & " ,������" & i + 1 & "��!")
                        Exit Sub

                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then             '*****�����
                        MsgBox("������������ " & str & " ,������" & i + 1 & "��!")
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
                txtLine = Trim(sr.ReadLine())                 '********װ���� ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���װ���� ��!,������" & i + 1 & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******װ����
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "6" And Trim(str) <> "9" Then                  '*****װ����
                        MsgBox("���ĳ��� " & str & " ,������" & i + 1 & "��!")
                        Exit Sub

                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then             '*****װ����
                        LoadPortCode = ""
                    Else
                        LoadPortCode = Trim(str)
                    End If
                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********ж���� ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���ж���� ��!,������" & i + 1 & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******ж���� 
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "12" And Trim(str) <> "11" Then                   '*****ж���� 
                        MsgBox("���ĳ��� " & str & " ,������" & i + 1 & "��!")
                        Exit Sub

                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) = 0 Then             '*****ж���� 
                        unLoadPortCode = ""
                    Else
                        unLoadPortCode = Trim(str)
                    End If
                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********��ѡж���� ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���!,������" & i + 1 & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******��ѡж���� ��
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "97" Then                   '*****��ѡж���� ��
                        Mark = 0
                    Else
                        Mark = 1
                    End If

                Else
                    Mark = 0
                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********Ŀ�ĸ� ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���Ŀ�ĸ� ��!,������" & i + 1 & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******Ŀ�ĸ�
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "83" Then                   '*****Ŀ�ĸ�
                        MsgBox("���ĳ���Ŀ�ĸ� " & str & " ,������" & i + 1 & "��!")
                        Exit Sub

                    End If
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then             '*****Ŀ�ĸ�                        
                        DeliveryPlaceCode = Trim(str)
                    End If
                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********��ѡĿ�ĸ�1 ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! ,������" & i + 1 & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******��ѡĿ�ĸ�
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "63" Then                   '*****��ѡĿ�ĸ�
                        Mark = 0
                    Else
                        Mark = 1
                    End If

                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********��ѡĿ�ĸ�2 ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! ,������" & i + 1 & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******��ѡĿ�ĸ�
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "65" Then                   '*****��ѡĿ�ĸ�
                        Mark = 0
                    Else
                        Mark = 1
                    End If

                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********��ѡĿ�ĸ�3 ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! ,������" & i + 1 & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******��ѡĿ�ĸ�
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "69" Then                   '*****��ѡĿ�ĸ�
                        Mark = 0
                    Else
                        Mark = 1
                    End If

                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********��ѡĿ�ĸ�4 ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! ,������" & i + 1 & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******��ѡĿ�ĸ�
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "71" Then                   '*****��ѡĿ�ĸ�
                        Mark = 0
                    Else
                        Mark = 1
                    End If

                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********��ѡĿ�ĸ�5 ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! ,������" & i + 1 & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******��ѡĿ�ĸ�
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "LOC" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "74" Then                   '*****��ѡĿ�ĸ�
                        Mark = 0
                    Else
                        Mark = 1
                    End If

                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********�ᵥ�� ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ����ᵥ�� ��! ,������" & i + 1 & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******�ᵥ�� 
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "RFF" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Mid(Trim(str), 1, 2) <> "BM" And Mid(Trim(str), 1, 2) <> "ET" Then                       '*****�ᵥ�� 
                        'MsgBox("���ĳ����ᵥ�� �� " & str & " ,������" & i + 1 & "��!")
                        'Exit Sub
                        'Mark = 0
                    Else
                        BLNO = Mid(Trim(str), 4)                '*****�ᵥ�� 
                        Mark = 1
                    End If

                Else
                    Mark = 0

                End If
            End If
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********����Ϣ ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ�������Ϣ ��!,������" & i + 1 & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******����Ϣ
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "EQD" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "CN" And Trim(str) <> "BB" And Trim(str) <> "ZZZ" Then                         '*****����Ϣ
                        'MsgBox("���ĳ��� CN BB ZZZ" & str & " ,������" & i + 1 & "��!")
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
                    txtLine = Trim(sr.ReadLine())                 '********EQA �ʲ����� ��
                    s = txtLine
                Else
                    txtLine = s
                End If
                If txtLine = Nothing Then
                    MsgBox("���ĳ���EQA �ʲ����� ��!,������" & i + 1 & "��!")
                    Exit Sub
                Else
                    If Mark = 1 Then i = i + 1
                    str = FetchStr(txtLine)                      '*******EQA �ʲ����� ��
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
                txtLine = Trim(sr.ReadLine())                 '********�侭Ӫ�� ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ��� �侭Ӫ�� ��!,������" & i + 1 & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******�侭Ӫ��
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "NAD" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "CA" Then                          '*****�侭Ӫ��
                        'MsgBox("���ĳ����侭Ӫ��CA " & str & " ,������" & i + 1 & "��!")
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
                                'MsgBox("���ĳ��� 172" & str & " ,������" & i + 1 & "��!")
                                'Exit Sub
                                'Mark = 0
                            End If
                        End If
                    End If
                Else

                        Mark = 0

                End If
            End If
            '*************************У��
            If i99 = 1 Then
                If Len(Trim(ConNo)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "����  ��ſմ���,������" & i & "��!"
                    Frm.ShowDialog()
                    ConNo = Trim(G_SelectCode)
                    If Len(Trim(ConNo)) = 12 Then
                        ConNo = Mid(Trim(ConNo), 1, 4) & Mid(Trim(ConNo), 6, 7)
                    End If
                End If
                If Len(Trim(ConType)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "�� " & ConNo & " ���ʹ���մ���"
                    Frm.ShowDialog()
                    ConType = Trim(G_SelectCode)
                End If
                If Len(Trim(ConStatus)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "�� " & ConNo & " ����ؿմ���"
                    Frm.ShowDialog()
                    ConStatus = Trim(G_SelectCode)
                End If
                If Len(Trim(LoadPortCode)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "�� " & ConNo & " װ���۴���մ���"
                    Frm.ShowDialog()
                    LoadPortCode = Trim(G_SelectCode)
                End If
                If Len(Trim(unLoadPortCode)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "�� " & ConNo & " ж���۴���մ���"
                    Frm.ShowDialog()
                    unLoadPortCode = Trim(G_SelectCode)
                End If
                If Len(Trim(ConBay)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "�� " & ConNo & "  Bay �� �մ���"
                    Frm.ShowDialog()
                    ConBay = Trim(G_SelectCode)
                End If
                If Len(Trim(ConGrossWeight)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "�� " & ConNo & "  ��ë�� �մ���"
                    Frm.ShowDialog()
                    ConGrossWeight = Trim(G_SelectCode)
                End If
                'If Len(Trim(ConOperatorCode)) = 0 Then
                'Dim Frm As New FrmReadTemp
                'G_SelectStr = "�� " & ConNo & " �侭Ӫ�˴���մ���"
                'Frm.ShowDialog()
                'ConOperatorCode = Trim(G_SelectCode)
                'End If
            End If
            '*************************
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())                 '********Σ��Ʒ ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******Σ��Ʒ
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "DGS" Then
                    i99 = 1
                    Mark = 1
                    str = FetchStr(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "IMD" And Trim(str) <> "IMO" And Trim(str) <> "IMDG" Then                          '*****Σ��Ʒ
                        MsgBox("���ĳ��� Σ��ƷIMD ��ʶ���� " & str & " ,������" & i + 1 & "��!")
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
                                G_SelectStr = "�� " & ConNo & " Σ��Ʒ�ȼ��մ���"
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
                txtLine = Trim(sr.ReadLine())                 '********Σ��ƷFTX ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = FetchStr(txtLine)                      '*******Σ��ƷFTX
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
                '*****************д������Ϣ
                Dim Size As String = "0"
                Dim Type As String = "0"
                Dim sqlstr As String
                Dim SSSS As String = "0"
                '*****************ȡ����
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
                        'MsgBox("�������ͳߴ� " & ConType & " ����,������" & i + 1 & "����Χ��������!")
                        'Dim Frm As New FrmReadTemp
                        'G_SelectStr = "�� " & ConNo & "  ���ʹ���" & ConType
                        'Frm.ShowDialog()
                        'ConType = Trim(G_SelectCode)
                        Size = Mid(ConType, 1, 2)
                    End If
                    SSSS = "0"
                    Type = Mid(ConType, 3, 2)
                End If
                ds.Dispose()
                dw.Dispose()

                '��Ƥ�� ë��
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
                '*********************д�뼯װ������봬��˾���ʹ�����ձ�

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
                '*********************д�봬ͼ��ʱ����Ϣ
                ds.Reset()

                sqlstr = "select * from CON_IMAGE_RECORD where CONTAINER_NO='" & ConNo & "' and BayNo='" & Mid(Trim(ConBay), 2, 6) & "' and Ship_ID=" & Ship_ID
                dw = Updatedata(sqlda, sqlstr, ds)
                If dw.Count = 0 Then
                    Dim row As DataRow
                    row = ds.Tables(0).NewRow()
                    row("Ship_ID") = Ship_ID
                    row("CONTAINER_NO") = Trim(ConNo)
                    row("Size_Con") = CInt(SSSS)
                    '******************δת���Ĵ���
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
        '*************���� UNT
        PB.Value = 2000
        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
            s = txtLine
        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("���ĳ���!���� UNT,������" & i + 1 & "��!")
            Exit Sub
        Else
            If Mark = 1 Then i = i + 1
            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) = "UNT" Then
                Mark = 1
                str = FetchStr(txtLine)
                If i <> CInt(str) Then
                    MsgBox("������������,������" & i + 1 & "��!")
                Else

                End If
            Else
                MsgBox("���Ķ�ȡ����,������" & i + 1 & "��!")
                Exit Sub
            End If
        End If
        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
            s = txtLine

        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("���ĳ���!���� UNZ,������" & i + 2 & "��!")
            Exit Sub
        Else

            str = FetchStr(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) = "UNZ" Then
                str = FetchStr(txtLine)
                If Trim(str) <> "1" Then
                    MsgBox("���Ķ�ȡ����,������" & i + 2 & "��!")
                    Exit Sub
                Else
                    MsgBox("���Ķ�ȡ��ȷ! ������ " & i & " ��")
                End If
            Else
                MsgBox("���Ķ�ȡ����,������" & i + 2 & "��!")
                Exit Sub
            End If
        End If

        sr.Close()
        Me.Close()

    End Sub

    Private Sub ReadZH()
        Dim sr As New StreamReader(txtFile.Text) '�򿪱����ļ�
        Dim txtLine As String
        Dim i As Integer = 0 '��¼����
        Dim j As Integer = 0 'ȡ����Ϣѭ��
        Dim i99 As Integer '�жϽ���
        Dim str As String
        Dim s As String
        Dim Mark As Integer = 0 '**********��ʶĳ���Ƿ����� 1��ʾ������ 0��ʾδ������

        Dim ShipName As String = "" '����
        Dim ShipCode As String = "" '������
        Dim Voyage As String = "" '����
        Dim ShipLineCode As String = "" '����˾����
        Dim ShipLine As String = "" '����˾
        Dim ConNo As String = "" '���
        Dim ConType As String = "" '��ߴ�����
        Dim ConStatus As String = "" '��״̬
        Dim ConBay As String = "" '�䱴λ��
        Dim ConTempUnit As String = "" '�¶ȼ�����λ
        Dim ConTempSet As String = "" '�����¶�
        Dim ConTempMax As String = "" '�������¶�
        Dim ConTempMin As String = "" '�������¶�
        Dim ConOverFront As String = "" 'ǰ��
        Dim ConOverBack As String = "" '��
        Dim ConOverLeft As String = "" '��
        Dim ConOverRight As String = "" '�ҳ�
        Dim ConOverHeight As String = "" '����
        Dim ConGrossWeight As String = "" '��ë��
        Dim ConTareWeight As String = "" '��Ƥ��
        Dim ConOperatorCode As String = "" '�侭Ӫ�˴���
        Dim ConOperator As String = "" '�侭Ӫ��
        Dim BLNO As String = "" '�ᵥ��
        Dim LoadPortCode As String = "" 'װ���۴���
        Dim LoadPort As String = "" 'װ����
        Dim unLoadPortCode As String = "" 'ж���۴���
        Dim unLoadPort As String = "" 'ж����
        Dim DeliveryPlaceCode As String = "" '�����ش���
        Dim DeliveryPlace As String = "" '������
        Dim DangerousClass As String = "" 'Σ��Ʒ����
        Dim DangerousPage As String = "" 'Σ��Ʒҳ��
        Dim DangerousUNNO As String = "" '���Ϲ�Σ��Ʒ���
        Dim DangerousLabel As String = "" 'Σ��Ʒ��ǩ
        Dim CargoDescr As String = "" '��������


        txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
        '***********�����¼ 00 ͷ��¼
        If txtLine = Nothing Then
            MsgBox("���ĳ���!")
            Exit Sub
        Else
            i = i + 1
            str = EditFetch(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) <> "00" Then
                MsgBox("���ĳ��� " & str & " ,������" & i & "��!")
                Exit Sub
            Else
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) <> "BAPLIE" Then                      '��ͼ��ʶ
                    MsgBox("���ĳ��� " & str & " ,���Ǵ�ͼ����,������" & i & "��!")
                    Exit Sub
                Else
                    str = EditFetch(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "BAYPLAN" Then                '��ͼ��ʶ
                        MsgBox("���ĳ��� " & str & " ,���Ǵ�ͼ����,������" & i & "��!")
                        Exit Sub
                    Else
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Trim(str) <> "9" Then                 '��ͼ��ʶ
                            MsgBox("���ĳ��� " & str & " ,���Ǵ�ͼ����,������" & i & "��!")
                            Exit Sub
                        End If
                    End If
                End If
            End If
        End If
        '*************�����¼ 01 �������շ���¼
        txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
        s = txtLine
        If txtLine = Nothing Then
            MsgBox("���ĳ���!�����¼ 01 �������շ���¼,������" & i & "��!")
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
        '*************�����¼ 10 ���������йصĻ���������Ŀ

        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("���ĳ���!�����¼ 10 ���������йصĻ���������Ŀ ,������" & i & "��!")
            Exit Sub
        Else
            If Mark = 1 Then i = i + 1
            str = EditFetch(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) = "10" Then
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) > 0 Then
                    ShipCode = str         '����
                End If
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) > 0 Then
                    ShipName = str '����
                End If
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) > 0 Then
                    Voyage = str '����
                End If
            Else
                MsgBox("���ĳ��� " & str & " ,������" & i & "��!")
                Exit Sub
            End If
        End If
        '*************�����¼ 11 ���������йصĲ�����Ϣ
        txtLine = Trim(sr.ReadLine())
        If txtLine = Nothing Then
            MsgBox("���ĳ���!�����¼ 11 ���������йصĲ�����Ϣ,������" & i & "��!")
            Exit Sub
        Else
            i = i + 1
            str = EditFetch(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) = "11" Then
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) > 0 Then
                    ShipLineCode = str    '����˾(������)����
                End If
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Len(Trim(str)) > 0 Then
                    ShipLine = str       '����˾(������)
                End If
            Else
                MsgBox("���ĳ��� " & str & " ,������" & i & "��!")
                Exit Sub
            End If
        End If
        Mark = 1
        '*****************��װ����Ϣ (��ʼѭ��)
        Do While j < 9999
            If j < 2000 Then
                PB.Value = j
            End If
            ConNo = ""
            ConType = ""
            ConStatus = ""
            ConBay = ""  '�䱴λ��
            ConTempUnit = ""  '�¶ȼ�����λ
            ConTempSet = "" '�����¶�
            ConTempMax = ""  '�������¶�
            ConTempMin = ""  '�������¶�
            ConOverFront = ""  'ǰ��
            ConOverBack = ""  '��
            ConOverLeft = ""  '��
            ConOverRight = "" '�ҳ�
            ConOverHeight = ""  '����
            ConGrossWeight = ""  '��ë��
            ConTareWeight = ""  '��Ƥ��
            ConOperatorCode = ""  '�侭Ӫ�˴���
            ConOperator = ""  '�侭Ӫ��
            BLNO = ""  '�ᵥ��
            LoadPortCode = ""  'װ���۴���
            LoadPort = ""  'װ����
            unLoadPortCode = ""  'ж���۴���
            unLoadPort = ""  'ж����
            DeliveryPlaceCode = ""  '�����ش���
            DeliveryPlace = ""  '������
            DangerousClass = ""  'Σ��Ʒ����
            DangerousPage = ""  'Σ��Ʒҳ��
            DangerousUNNO = ""  '���Ϲ�Σ��Ʒ���
            DangerousLabel = ""  'Σ��Ʒ��ǩ
            CargoDescr = ""  '��������

            i99 = 0
            '*************�����¼ 50 ������װ����Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 50 ������װ����Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "50" Then
                    i99 = 1
                    str = EditFetch(txtLine)                '*******ȡ���
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConNo = str
                    Else
                        'MsgBox("���ĳ��� " & str & " ,������" & i & "��!")
                        ConNo = ""
                    End If
                    str = EditFetch(txtLine)                '*******ȡ��ߴ�����
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConType = str
                    Else
                        'MsgBox("���ĳ��� " & str & " ,������" & i & "��!")
                        ConType = ""
                    End If
                    str = EditFetch(txtLine)                '*******ȡ�����
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConStatus = str
                    Else
                        'MsgBox("���ĳ��� " & str & " ,������" & i & "��!")
                        ConStatus = ""
                    End If
                    str = EditFetch(txtLine)                '*******ȡ�䱴λ
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConBay = Trim(str)
                        If Len(Trim(ConBay)) = 6 Then
                            ConBay = "0" & ConBay
                        End If
                    Else
                        'MsgBox("���ĳ��� " & str & " ,������" & i & "��!")
                        ConBay = ""
                    End If
                    str = EditFetch(txtLine)                '*******ȡ�¶ȼ�����λ
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConTempUnit = str
                    End If
                    str = EditFetch(txtLine)                '*******ȡ�����¶�
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConTempSet = str
                    End If
                    str = EditFetch(txtLine)                '*******ȡ�������¶�
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConTempMin = str
                    End If
                    str = EditFetch(txtLine)                '*******ȡ�������¶�
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConTempMax = str
                    End If
                    str = EditFetch(txtLine)                '*******ȡǰ��
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConOverFront = str
                    End If
                    str = EditFetch(txtLine)                '*******ȡ��
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConOverBack = str
                    End If
                    str = EditFetch(txtLine)                '*******ȡ��
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConOverLeft = str
                    End If
                    str = EditFetch(txtLine)                '*******ȡ�ҳ�
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConOverRight = str
                    End If
                    str = EditFetch(txtLine)                '*******ȡ����
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConOverHeight = str
                    End If
                    str = EditFetch(txtLine)                '*******ȡ��ë��
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConGrossWeight = str
                    Else
                        'MsgBox("���ĳ��� " & str & " ,������" & i & "��!")
                        ConGrossWeight = ""
                    End If
                    str = EditFetch(txtLine)                '*******ȡ��Ƥ��
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConTareWeight = str
                    End If
                    str = EditFetch(txtLine)                '*******ȡ�侭Ӫ�˴���
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConOperatorCode = str
                    Else
                        'MsgBox("���ĳ��� " & str & " ,������" & i & "��!")
                        ConOperatorCode = ""
                    End If
                    str = EditFetch(txtLine)                '*******ȡ�侭Ӫ��
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConOperator = str
                    Else
                        ConOperator = ConOperatorCode
                    End If
                    Mark = 1
                Else
                    If Mark = 1 Then
                        MsgBox("���ĳ��� " & str & " ,������" & i & "��!")
                        Exit Sub
                    End If

                End If
            End If
            '*************�����¼ 51 �ᵥ����Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 51 �ᵥ����Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "51" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******ȡ�ᵥ��
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        BLNO = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 52 �ص���Ϣ

            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 52 �ص���Ϣ,������" & i & "��!")
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
                        LoadPortCode = Trim(str) 'װ���۴���
                    Else
                        'MsgBox("���ĳ��� " & str & " ,������" & i & "��!")
                        LoadPortCode = ""
                    End If
                    str = EditFetch(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        LoadPort = str 'װ����
                    End If
                    str = EditFetch(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        unLoadPortCode = Trim(str) 'ж���۴���
                    Else
                        'MsgBox("���ĳ��� " & str & " ,������" & i & "��!")
                        unLoadPortCode = ""
                    End If
                    If Len(Trim(txtLine)) > 0 Then
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 Then
                            unLoadPort = str 'ж����
                        End If
                        If Len(Trim(txtLine)) > 0 Then
                            str = EditFetch(txtLine)
                            txtLine = Mid(txtLine, Len(str) + 2)
                            If Len(Trim(str)) > 0 Then
                                DeliveryPlaceCode = Trim(str) '�����ش���
                            End If
                            str = EditFetch(txtLine)
                            txtLine = Mid(txtLine, Len(str) + 2)
                            If Len(Trim(str)) > 0 Then
                                DeliveryPlace = str '������
                            End If
                        End If
                    End If
                Else
                    If Mark = 1 Then
                        MsgBox("���ĳ��� �����¼ 52 �ص���Ϣ" & str & " ,������" & i & "��!")
                        Exit Sub
                    End If
                    Mark = 0
                End If
            End If
            '*************�����¼ 53 ��ѡж������Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���!�����¼ 53 ��ѡж������Ϣ ,������" & i & "��!")
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
            '*************************У��
            If i99 = 1 Then
                If Len(Trim(ConNo)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "����  ��ſմ���,������" & i & "��!"
                    Frm.ShowDialog()
                    ConNo = Trim(G_SelectCode)
                End If
                If Len(Trim(ConType)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "�� " & ConNo & " ���ʹ���մ���"
                    Frm.ShowDialog()
                    ConType = Trim(G_SelectCode)
                End If
                If Len(Trim(ConStatus)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "�� " & ConNo & " ����ؿմ���"
                    Frm.ShowDialog()
                    ConStatus = Trim(G_SelectCode)
                End If
                If Len(Trim(LoadPortCode)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "�� " & ConNo & " װ���۴���մ���"
                    Frm.ShowDialog()
                    LoadPortCode = Trim(G_SelectCode)
                End If
                If Len(Trim(unLoadPortCode)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "�� " & ConNo & " ж���۴���մ���"
                    Frm.ShowDialog()
                    unLoadPortCode = Trim(G_SelectCode)
                End If
                If Len(Trim(ConBay)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "�� " & ConNo & "  Bay �� �մ���"
                    Frm.ShowDialog()
                    ConBay = Trim(G_SelectCode)
                End If
                If Len(Trim(ConGrossWeight)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "�� " & ConNo & "  ��ë�� �մ���"
                    Frm.ShowDialog()
                    ConGrossWeight = Trim(G_SelectCode)
                End If
                
                'If Len(Trim(ConOperatorCode)) = 0 Then
                '    Dim Frm As New FrmReadTemp()
                '    G_SelectStr = "�� " & ConNo & " �侭Ӫ�˴���մ���"
                '    Frm.ShowDialog()
                '    ConOperatorCode = Trim(G_SelectCode)
                'End If


            End If
            '*************************
            '*************�����¼ 54 Σ��Ʒ��Ϣ

            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 54 Σ��Ʒ��Ϣ,������" & i & "��!")
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
                        DangerousClass = str 'Σ��Ʒ����
                    Else
                        'MsgBox("���ĳ��� " & str & " ,������" & i & "��!")
                        Dim Frm As New FrmReadTemp
                        G_SelectStr = "�� " & ConNo & " Σ��Ʒ�ȼ�����մ���"
                        Frm.ShowDialog()
                        DangerousClass = Trim(G_SelectCode)
                    End If
                    str = EditFetch(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        DangerousPage = str 'Σ��Ʒҳ��
                    End If
                    str = EditFetch(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        DangerousUNNO = str '���Ϲ�Σ��Ʒ���
                    End If
                    str = EditFetch(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        DangerousLabel = str 'Σ��Ʒ��ǩ
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 55 ��������
            Dim i55 As Integer = 0
            Do While i55 < 9
                If Mark = 1 Then
                    txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
                    s = txtLine
                Else
                    txtLine = s
                End If
                If txtLine = Nothing Then
                    MsgBox("���ĳ���!")
                    Exit Sub
                Else
                    If Mark = 1 Then i = i + 1
                    str = EditFetch(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) = "55" Then
                        i99 = 1
                        str = EditFetch(txtLine) '�������
                        txtLine = Mid(txtLine, Len(str) + 2)

                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 Then
                            CargoDescr = CargoDescr & str '��������
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
                '*****************д������Ϣ
                Dim Size As String = "0"
                Dim Type As String = "0"
                Dim SSSS As String = "0"
                Dim sqlstr As String
                '*****************ȡ����
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
                        'MsgBox("�������ͳߴ� " & ConType & " ����,������" & i + 1 & "����Χ��������!")
                        'Dim Frm As New FrmReadTemp()
                        'G_SelectStr = "�� " & ConNo & " ���ʹ������" & ConType
                        'Frm.ShowDialog()
                        'ConType = Trim(G_SelectCode)
                        Size = Mid(ConType, 1, 2)
                    End If
                    SSSS = "0"
                    Type = Mid(ConType, 3, 2)
                End If

                '��Ƥ�� ë��
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

                '*********************д�뼯װ������봬��˾���ʹ�����ձ�
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
                '*********************д�봬ͼ��ʱ����Ϣ
                ds.Reset()

                sqlstr = "select * from CON_IMAGE_RECORD where CONTAINER_NO='" & ConNo & "' and BayNo='" & Mid(Trim(ConBay), 2, 6) & "' and Ship_ID=" & Ship_ID
                dw = Updatedata(sqlda, sqlstr, ds)
                If dw.Count = 0 Then
                    Dim row As DataRow
                    row = ds.Tables(0).NewRow()
                    row("Ship_ID") = Ship_ID
                    row("CONTAINER_NO") = Trim(ConNo)
                    '******************δת���Ĵ���
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
        '*************���� 99
        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
            s = txtLine
        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("���ĳ��� ���� 99!������" & i & "��!")
            Exit Sub
        Else
            If Mark = 1 Then i = i + 1
            str = EditFetch(txtLine)
            txtLine = Mid(txtLine, Len(str) + 2)
            If Trim(str) = "99" Then
                str = EditFetch(txtLine)
                If i <> CInt(str) Then
                    MsgBox("������������,������" & i & "��!")
                Else
                    MsgBox("���Ķ�ȡ��ȷ! ������ " & i & " ��")
                End If
            Else
                MsgBox("���Ķ�ȡ����,������" & i & "��!")
                Exit Sub
            End If
        End If
        sr.Close()
        Me.Close()
    End Sub

    Private Sub ReadZY()
        Dim sr As New StreamReader(txtFile.Text) '�򿪱����ļ�
        Dim txtLine As String
        Dim i As Integer = 0 '��¼����
        Dim j As Integer = 0 'ȡ����Ϣѭ��
        Dim i99 As Integer '�жϽ���
        Dim str As String
        Dim s As String
        Dim Mark As Integer = 0 '**********��ʶĳ���Ƿ����� 1��ʾ������ 0��ʾδ������

        Dim ShipName As String = "" '����
        Dim ShipCode As String = "" '������
        Dim Voyage As String = "" '����
        Dim ShipLineCode As String = "" '����˾����
        Dim ShipLine As String = "" '����˾
        Dim ConNo As String = "" '���
        Dim ConType As String = "" '��ߴ�����
        Dim ConStatus As String = "" '��״̬
        Dim ConBay As String = "" '�䱴λ��
        Dim ConTempUnit As String = "" '�¶ȼ�����λ
        Dim ConTempSet As String = "" '�����¶�
        Dim ConTempMax As String = "" '�������¶�
        Dim ConTempMin As String = "" '�������¶�
        Dim ConOverFront As String = "" 'ǰ��
        Dim ConOverBack As String = "" '��
        Dim ConOverLeft As String = "" '��
        Dim ConOverRight As String = "" '�ҳ�
        Dim ConOverHeight As String = "" '����
        Dim ConGrossWeight As String = "" '��ë��
        Dim ConTareWeight As String = "" '��Ƥ��
        Dim ConOperatorCode As String = "" '�侭Ӫ�˴���
        Dim ConOperator As String = "" '�侭Ӫ��
        Dim BLNO As String = "" '�ᵥ��
        Dim LoadPortCode As String = "" 'װ���۴���
        Dim LoadPort As String = "" 'װ����
        Dim unLoadPortCode As String = "" 'ж���۴���
        Dim unLoadPort As String = "" 'ж����
        Dim DeliveryPlaceCode As String = "" '�����ش���
        Dim DeliveryPlace As String = "" '������
        Dim Danger As String = "" 'Σ��Ʒ��ʶ
        Dim DangerousClass As String = "" 'Σ��Ʒ����
        Dim DangerousPage As String = "" 'Σ��Ʒҳ��
        Dim DangerousUNNO As String = "" '���Ϲ�Σ��Ʒ���
        Dim DangerousLabel As String = "" 'Σ��Ʒ��ǩ
        Dim CargoDescr As String = "" '��������


        txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
        '***********�����¼ 00 ͷ��¼
        If txtLine = Nothing Then
            MsgBox("���ĳ���!")
            Exit Sub
        Else
            i = i + 1
            str = Mid(txtLine, 1, 2)
            If Trim(str) <> "00" Then
                MsgBox("���ĳ��� " & str & " ,������" & i & "��!")
                Exit Sub
            Else
                str = Mid(txtLine, 3, 3)
                If Trim(str) <> "BAY" Then                      '��ͼ��ʶ
                    MsgBox("���ĳ��� " & str & " ,���Ǵ�ͼ����,������" & i & "��!")
                    Exit Sub
                Else
                    str = Mid(txtLine, 6, 20)
                    If Trim(str) <> "BAYPLAN" And Trim(str) <> "BAY PLAN" Then                '��ͼ��ʶ
                        MsgBox("���ĳ��� " & str & " ,���Ǵ�ͼ����,������" & i & "��!")
                        Exit Sub
                    Else
                        str = Mid(txtLine, 117, 3)
                        If Trim(str) <> "1.2" Then                 '��ͼ��ʶ
                            MsgBox("���ĳ��� " & str & " ,���Ǵ�ͼ����,������" & i & "��!")
                            Exit Sub
                        End If
                    End If
                End If
            End If
        End If
        '*************�����¼ 11 �������շ���¼
        txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
        If txtLine = Nothing Then
            MsgBox("���ĳ���!")
            Exit Sub
        Else
            i = i + 1
            str = Mid(txtLine, 1, 2)
            If Trim(str) <> "11" Then
                MsgBox("���ĳ��� " & str & " ,���Ǵ�ͼ����,������" & i & "��!")
                Exit Sub
            Else
                str = Mid(txtLine, 11, 6) '*********����
                If Len(Trim(str)) > 0 Then
                    ShipCode = Trim(str)
                End If
                str = Mid(txtLine, 17, 20) '*********����
                If Len(Trim(str)) > 0 Then
                    ShipName = Trim(str)
                End If
                str = Mid(txtLine, 37, 5) '***********����
                If Len(Trim(str)) > 0 Then
                    Voyage = Trim(str)
                End If
            End If
        End If
        Mark = 1
        '*****************��װ����Ϣ (��ʼѭ��)
        Do While j < 19999
            If j < 2000 Then
                PB.Value = j
            End If
            ConNo = ""
            ConType = ""
            ConStatus = ""
            ConBay = ""  '�䱴λ��
            ConTempUnit = ""  '�¶ȼ�����λ
            ConTempSet = "" '�����¶�
            ConTempMax = ""  '�������¶�
            ConTempMin = ""  '�������¶�
            ConOverFront = ""  'ǰ��
            ConOverBack = ""  '��
            ConOverLeft = ""  '��
            ConOverRight = "" '�ҳ�
            ConOverHeight = ""  '����
            ConGrossWeight = ""  '��ë��
            ConTareWeight = ""  '��Ƥ��
            ConOperatorCode = ""  '�侭Ӫ�˴���
            ConOperator = ""  '�侭Ӫ��
            BLNO = ""  '�ᵥ��
            LoadPortCode = ""  'װ���۴���
            LoadPort = ""  'װ����
            unLoadPortCode = ""  'ж���۴���
            unLoadPort = ""  'ж����
            DeliveryPlaceCode = ""  '�����ش���
            DeliveryPlace = ""  '������
            DangerousClass = ""  'Σ��Ʒ����
            DangerousPage = ""  'Σ��Ʒҳ��
            DangerousUNNO = ""  '���Ϲ�Σ��Ʒ���
            DangerousLabel = ""  'Σ��Ʒ��ǩ
            CargoDescr = ""  '��������

            i99 = 0
            '*************�����¼ 51 ������װ����Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ��� ��¼ 51 ,������" & i & "����Χ!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = Mid(txtLine, 1, 2)
                If Trim(str) = "51" Then
                    i99 = 1
                    str = Mid(txtLine, 3, 11)              '*******ȡ���

                    If Len(Trim(str)) > 0 Then
                        ConNo = Trim(str)
                    Else
                        ConNo = ""
                        'MsgBox("���ĳ��� " & str & " ,������" & i & "��!")
                    End If
                    str = Mid(txtLine, 14, 4)              '*******ȡ��ߴ�����
                    If Len(Trim(str)) > 0 Then
                        ConType = Trim(str)
                    Else
                        ConType = ""
                        'MsgBox("���ĳ��� " & str & " ,������" & i & "��!")

                    End If
                    str = Mid(txtLine, 18, 1)              '*******ȡ�����
                    If Len(Trim(str)) > 0 Then
                        ConStatus = Trim(str)
                    Else
                        ConStatus = ""
                        'MsgBox("���ĳ��� " & str & " ,������" & i & "��!")

                    End If
                    str = Mid(txtLine, 19, 1)              '*******ȡ�ᵥ��ʶ
                    If Len(Trim(str)) > 0 Then
                        If Trim(str) = "2" Then
                            str = Mid(txtLine, 20, 16)     '*******ȡ�ᵥ��
                            If Len(Trim(str)) > 0 Then
                                BLNO = Trim(str)
                            End If
                        End If
                    End If
                    str = Mid(txtLine, 36, 5)               '******װ����
                    If Len(Trim(str)) > 0 Then
                        LoadPortCode = Trim(str)
                    Else
                        LoadPortCode = ""
                        'MsgBox("���ĳ��� " & str & " ,������" & i & "��!")

                    End If
                    str = Mid(txtLine, 41, 5)               '******ж����
                    If Len(Trim(str)) > 0 Then
                        unLoadPortCode = Trim(str)
                    Else
                        unLoadPortCode = ""
                        'MsgBox("���ĳ��� " & str & " ,������" & i & "��!")

                    End If
                    str = Mid(txtLine, 56, 5)               '******������
                    If Len(Trim(str)) > 0 Then
                        DeliveryPlaceCode = Trim(str)
                    End If
                    str = Mid(txtLine, 61, 7)               '*******ȡ�䱴λ
                    If Len(Trim(str)) > 0 Then
                        ConBay = Trim(str)
                        If Len(ConBay) = 6 Then
                            ConBay = "0" & ConBay
                        End If

                    Else
                        ConBay = ""
                        'MsgBox("���ĳ��� " & str & " ,������" & i & "��!")

                    End If
                    str = Mid(txtLine, 68, 1)              '*******ȡ�¶ȼ�����λ
                    If Len(Trim(str)) > 0 Then
                        ConTempUnit = Trim(str)
                    End If

                    str = Mid(txtLine, 69, 4)              '*******ȡ�������¶�
                    If Len(Trim(str)) > 0 Then
                        ConTempMax = Convert.ToString(Convert.ToDouble(Trim(str)) / 10).Trim()
                    End If

                    str = Mid(txtLine, 73, 4)              '*******ȡ�������¶�
                    If Len(Trim(str)) > 0 Then
                        ConTempMin = Convert.ToString(Convert.ToDouble(Trim(str)) / 10).Trim()
                    End If
                    str = Mid(txtLine, 77, 1)              'Σ��Ʒ��ʶ
                    If Len(Trim(str)) > 0 Then
                        Danger = Trim(str)
                    End If

                    str = Mid(txtLine, 78, 3)              '*******ȡǰ��
                    If Len(Trim(str)) > 0 Then
                        ConOverFront = Trim(str)
                    End If
                    str = Mid(txtLine, 81, 3)                   '*******ȡ��
                    If Len(Trim(str)) > 0 Then
                        ConOverBack = Trim(str)
                    End If
                    str = Mid(txtLine, 84, 3)                 '*******ȡ��
                    If Len(Trim(str)) > 0 Then
                        ConOverLeft = Trim(str)
                    End If
                    str = Mid(txtLine, 87, 3)                '*******ȡ�ҳ�
                    If Len(Trim(str)) > 0 Then
                        ConOverRight = Trim(str)
                    End If
                    str = Mid(txtLine, 90, 3)                 '*******ȡ����
                    If Len(Trim(str)) > 0 Then
                        ConOverHeight = Trim(str)
                    End If
                    str = Mid(txtLine, 105, 6)                '*******ȡ��ë��
                    If Len(Trim(str)) > 0 Then
                        ConGrossWeight = Trim(str)
                    Else
                        ConGrossWeight = ""
                        'MsgBox("���ĳ��� " & str & " ,������" & i & "��!")

                    End If

                    Mark = 1
                Else
                    If Mark = 1 Then
                        MsgBox("���ĳ��� ��¼ 51 ,������" & i & "��!")
                        Exit Sub
                    End If

                End If
            End If
            '*************************У��
            If i99 = 1 Then
                If Len(Trim(ConNo)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "����  ��ſմ���,������" & i & "��!"
                    Frm.ShowDialog()
                    ConNo = Trim(G_SelectCode)
                End If
                If Len(Trim(ConType)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "�� " & ConNo & " ���ʹ���մ���"
                    Frm.ShowDialog()
                    ConType = Trim(G_SelectCode)
                End If
                If Len(Trim(ConStatus)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "�� " & ConNo & " ����ؿմ���"
                    Frm.ShowDialog()
                    ConStatus = Trim(G_SelectCode)
                End If
                If Len(Trim(LoadPortCode)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "�� " & ConNo & " װ���۴���մ���"
                    Frm.ShowDialog()
                    LoadPortCode = Trim(G_SelectCode)
                End If
                If Len(Trim(unLoadPortCode)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "�� " & ConNo & " ж���۴���մ���"
                    Frm.ShowDialog()
                    unLoadPortCode = Trim(G_SelectCode)
                End If
                If Len(Trim(ConBay)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "�� " & ConNo & "  Bay �� �մ���"
                    Frm.ShowDialog()
                    ConBay = Trim(G_SelectCode)
                End If
                If Len(Trim(ConGrossWeight)) = 0 Then
                    Dim Frm As New FrmReadTemp
                    G_SelectStr = "�� " & ConNo & "  ��ë�� �մ���"
                    Frm.ShowDialog()
                    ConGrossWeight = Trim(G_SelectCode)
                End If
            End If
            '*************************
            '*************�����¼ 52 Σ��Ʒ��Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = Mid(txtLine, 1, 2)
                If Trim(str) = "52" Then
                    i99 = 1
                    Mark = 1

                    str = Mid(txtLine, 3, 11)              '*******ȡ���
                    If Len(Trim(str)) > 0 Then
                        If ConNo <> str Then
                            MsgBox("���ĳ��� �����¼ 52 Σ��Ʒ��Ϣ ȡ���" & str & " ,������" & i & "��!")
                            Exit Sub
                        End If
                    End If
                    str = Mid(txtLine, 19, 7)
                    If Len(Trim(str)) > 0 Then
                        DangerousClass = Trim(str)
                    Else
                        DangerousClass = ""
                        'MsgBox("���ĳ��� " & str & " ,������" & i & "��!")
                        Dim Frm As New FrmReadTemp
                        G_SelectStr = "�� " & ConNo & "  Σ��Ʒ�ȼ� �մ���"
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
            '*************�����¼ 53 ��ע��Ϣ

            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���!")
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
                '*****************д������Ϣ(��淶)
                Dim Size As String = "0"
                Dim Type As String = "0"
                Dim SSSS As String = "0"
                Dim sqlstr As String
                '*****************ȡ��淶
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
                        'MsgBox("�������ͳߴ� " & ConType & " ����,������" & i + 1 & "����Χ��������!")
                        'Dim Frm As New FrmReadTemp
                        'G_SelectStr = "�� " & ConNo & "  ���ʹ���" & ConType
                        'Frm.ShowDialog()
                        'ConType = Trim(G_SelectCode)
                        Size = Mid(ConType, 1, 2)
                    End If
                    SSSS = "0"
                    Type = Mid(ConType, 3, 2)
                End If
                '��Ƥ�� ë��
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
                '*********************д�뼯װ������봬��˾���ʹ�����ձ�

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

                '*********************д�봬ͼ��ʱ����Ϣ
                ds.Reset()

                sqlstr = "select * from CON_IMAGE_RECORD where CONTAINER_NO='" & ConNo & "' and BayNo='" & Mid(Trim(ConBay), 2, 6) & "' and Ship_ID=" & Ship_ID
                dw = Updatedata(sqlda, sqlstr, ds)
                If dw.Count = 0 Then
                    Dim row As DataRow
                    row = ds.Tables(0).NewRow()
                    row("Ship_ID") = Ship_ID
                    row("CONTAINER_NO") = Trim(ConNo)
                    row("Size_Con") = CInt(SSSS)
                    '******************δת���Ĵ���
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
        '*************���� 99
        PB.Value = 2000
        If Mark = 1 Then
            txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
            s = txtLine
        Else
            txtLine = s
        End If
        If txtLine = Nothing Then
            MsgBox("���ĳ���!")
            Exit Sub
        Else
            If Mark = 1 Then i = i + 1
            str = Mid(txtLine, 1, 2)
            If Trim(str) = "99" Then
                str = Mid(txtLine, 3, 3)
                If str <> "BAY" Then
                    MsgBox("���Ķ�ȡ����,������" & i & "��!")
                    Exit Sub
                End If
                str = Mid(txtLine, 6, 6)
                If i <> CInt(str) Then
                    MsgBox("������������,������" & i & "��!")
                Else
                    MsgBox("���Ķ�ȡ��ȷ! ������ " & i & " ��")
                End If
            Else
                MsgBox("���Ķ�ȡ����,������" & i & "��!")
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
            Dim sr As New StreamReader(filepath) '�򿪱����ļ�
            txtFile.Text = sr.ReadLine()
            txtFile.Text = sr.ReadLine()

            sr.Close()
        Catch
        End Try
    End Sub

End Class
