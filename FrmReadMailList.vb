Imports System.Web.Mail
Imports System.IO
Imports TALLY.DBControl
Public Class FrmReadMailList
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
    Friend WithEvents LJinChu As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LVoyage As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LEnglish As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LChina As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btReadNew As System.Windows.Forms.Button
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents OpenFile As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PB As System.Windows.Forms.ProgressBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.LJinChu = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LVoyage = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LEnglish = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LChina = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btReadNew = New System.Windows.Forms.Button()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.OpenFile = New System.Windows.Forms.Button()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.PB = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'LJinChu
        '
        Me.LJinChu.Location = New System.Drawing.Point(242, 24)
        Me.LJinChu.Name = "LJinChu"
        Me.LJinChu.Size = New System.Drawing.Size(128, 14)
        Me.LJinChu.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(186, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 14)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "������"
        '
        'LVoyage
        '
        Me.LVoyage.Location = New System.Drawing.Point(60, 24)
        Me.LVoyage.Name = "LVoyage"
        Me.LVoyage.Size = New System.Drawing.Size(124, 14)
        Me.LVoyage.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(4, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 14)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "����"
        '
        'LEnglish
        '
        Me.LEnglish.Location = New System.Drawing.Point(242, 4)
        Me.LEnglish.Name = "LEnglish"
        Me.LEnglish.Size = New System.Drawing.Size(128, 16)
        Me.LEnglish.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(186, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Ӣ�Ĵ���"
        '
        'LChina
        '
        Me.LChina.Location = New System.Drawing.Point(60, 4)
        Me.LChina.Name = "LChina"
        Me.LChina.Size = New System.Drawing.Size(124, 16)
        Me.LChina.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 14)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "���Ĵ���"
        '
        'btReadNew
        '
        Me.btReadNew.Location = New System.Drawing.Point(154, 76)
        Me.btReadNew.Name = "btReadNew"
        Me.btReadNew.Size = New System.Drawing.Size(66, 24)
        Me.btReadNew.TabIndex = 18
        Me.btReadNew.Text = "��ȡ����"
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(4, 40)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(304, 21)
        Me.txtFile.TabIndex = 17
        Me.txtFile.Text = ""
        '
        'OpenFile
        '
        Me.OpenFile.Location = New System.Drawing.Point(310, 40)
        Me.OpenFile.Name = "OpenFile"
        Me.OpenFile.Size = New System.Drawing.Size(62, 20)
        Me.OpenFile.TabIndex = 16
        Me.OpenFile.Text = "���ļ�"
        '
        'PB
        '
        Me.PB.Location = New System.Drawing.Point(0, 106)
        Me.PB.Maximum = 2000
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(374, 22)
        Me.PB.TabIndex = 27
        '
        'FrmReadMailList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(374, 131)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.PB, Me.LJinChu, Me.Label2, Me.LVoyage, Me.Label5, Me.LEnglish, Me.Label3, Me.LChina, Me.Label1, Me.btReadNew, Me.txtFile, Me.OpenFile})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReadMailList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "�յ����Ķ�ȡ"
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

    Private Sub btReadNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReadNew.Click
        Dim sr As New StreamReader(txtFile.Text) '�򿪱����ļ�
        Dim txtLine As String
        txtLine = Trim(sr.ReadLine()) '��ȡһ��
        sr.Close()
        If Mid(txtLine, 1, 3) = "00:" Then '****��ͨ��
            Call ReadZH()
        ElseIf Mid(txtLine, 7, 1).ToUpper() = "I" Or Mid(txtLine, 7, 1).ToUpper() = "E" Then '*****��Զ
            Call ReadHG()
        End If

    End Sub
    Private Sub ReadHG()
        On Error GoTo Err
        Dim sr As New StreamReader(txtFile.Text) '�򿪱����ļ�
        Dim txtLine As String
        Dim i As Integer = 0 '��¼����
        Dim j As Integer = 0 'ȡ����Ϣѭ��

        Dim str As String
        Dim s As String
        Dim sqlstr As String

        Dim InOutMark As String '�����ڱ�־

        Dim BLNO As String '�ᵥ��
        Dim LoadPort As String 'װ��
        Dim unLoadPort As String 'ж��
        Dim LoadPlace As String 'װ����
        Dim unLoadPlace As String 'Ŀ�ĵ�
        Dim unLoad_Place As String  'ж���ص�
        Dim PackType As String '��װ
        Dim Volume As String '���
        Dim GoodsName As String '��������
        Dim PackNum As String '����
        Dim GrossWeight As String '����
        Dim ConNum As String '�ᵥ����
        Dim OwnerName As String '��������


        Dim BLNO_Con As String '���ᵥ��
        Dim Conta_No As String '���
        Dim CONTA_SIZE As String '��ߴ�
        Dim SEAL_NO As String 'Ǧ��
        Dim CONTA_TYPE As String '����
        Dim CONTA_WT As String '������

        txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
        i = i + 1
        InOutMark = Mid(txtLine, 7, 1).ToUpper()  '�����ڱ�־
        txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
        i = i + 1
        '********************�ᵥ
        s = Mid(txtLine, 5, 1).ToUpper()
        While (Asc(s) >= Asc("A") And Asc(s) <= Asc("Z"))
            '************
            BLNO = ""
            LoadPort = ""
            unLoadPort = ""
            LoadPlace = ""
            unLoadPlace = ""
            unLoad_Place = ""
            PackType = ""
            Volume = ""
            GoodsName = ""
            PackNum = ""
            GrossWeight = ""
            ConNum = ""
            OwnerName = ""
            '************
            BLNO = Trim(Mid(txtLine, 5, 20))
            If InOutMark = "I" Then
                LoadPort = Trim(Mid(txtLine, 25, 5))
                unLoadPort = "CNLYG"

                unLoadPlace = Trim(Mid(txtLine, 30, 6))
                LoadPlace = ""
            Else
                unLoadPort = Trim(Mid(txtLine, 25, 5))
                LoadPort = "CNLYG"

                LoadPlace = Trim(Mid(txtLine, 30, 6))
                unLoadPlace = ""
            End If
            unLoad_Place = Trim(Mid(txtLine, 36, 20))
            PackType = Trim(Mid(txtLine, 56, 2))
            Volume = Trim(Mid(txtLine, 58, 9))
            GoodsName = Trim(Mid(txtLine, 67, 50))
            PackNum = Trim(Mid(txtLine, 117, 9))
            GrossWeight = Trim(Mid(txtLine, 126, 11))
            ConNum = Trim(Mid(txtLine, 137, 4))
            OwnerName = Trim(Mid(txtLine, 161))
            '****************

            ds.Reset()

            sqlstr = "select * from CON_HATCH_LIST where BLNO='" & BLNO & "' and Ship_ID=" & Ship_ID
            dw = Updatedata(sqlda, sqlstr, ds)
            If dw.Count = 0 Then
                Dim row As DataRow
                row = ds.Tables(0).NewRow()
                row("Ship_ID") = Ship_ID
                row("BLNO") = BLNO

                row("CODE_LOAD_PORT") = LoadPort
                row("LOAD_PORT") = LoadPort
                row("CODE_UnLOAD_PORT") = unLoadPort
                row("UnLOAD_PORT") = unLoadPort
                row("CODE_PLACE_RECEIVE") = unLoad_Place
                row("PLACE_RECEIVE") = unLoad_Place

                
                If Len(Trim(PackNum)) > 0 Then
                    row("EMPTY_MARK") = "1"
                Else
                    row("EMPTY_MARK") = "0"
                End If

                row("GOODS_ENG") = GoodsName
                row("GOODS_CHA") = GoodsName

                If Len(Trim(PackNum)) > 0 Then
                    row("Amount") = CType(PackNum, Int32)
                End If
                row("Code_Pack") = PackType
                row("Pack") = PackType
                If Len(Trim(GrossWeight)) > 0 Then
                    row("NetWeight") = CType(GrossWeight, Double) / 100.0
                End If
                If Len(Trim(GrossWeight)) > 0 Then
                    row("Gross_Weight") = CType(GrossWeight, Double) / 100.0
                End If
                If Len(Trim(Volume)) > 0 Then
                    row("Size_Measure") = CType(Volume, Double)
                End If
                If Len(Trim(GrossWeight)) > 0 And Len(Trim(PackNum)) > 0 And CType(PackNum, Int32) > 0 Then
                    row("PIECE_WEIGHT") = CType(GrossWeight, Double) / 100.0 / CType(PackNum, Int32)
                End If

                ds.Tables(0).Rows.Add(row)
                sqlda.Update(ds)
            Else
                'MsgBox("�Ѵ��ڴ��ᵥ��Ϣ �ᵥ��Ϊ " & BLNO)
            End If
            ds.Dispose()
            dw.Dispose()
            sqlda.Dispose()
            '****************
            txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
            i = i + 1
            s = Mid(txtLine, 5, 1).ToUpper()
        End While
        '***********����
        s = Mid(txtLine, 5, 1).ToUpper()
        While (Asc(s) >= Asc("0") And Asc(s) <= Asc("9"))
            '****************
            BLNO_Con = ""
            Conta_No = ""
            CONTA_SIZE = ""
            SEAL_NO = ""
            CONTA_TYPE = ""
            CONTA_WT = ""
            '****************
            BLNO_Con = Trim(Mid(txtLine, 6, 20))
            Conta_No = Trim(Mid(txtLine, 26, 11))
            CONTA_SIZE = Trim(Mid(txtLine, 37, 1))
            SEAL_NO = Trim(Mid(txtLine, 38, 10))
            CONTA_TYPE = Trim(Mid(txtLine, 48, 4))
            CONTA_WT = Trim(Mid(txtLine, 52, 11))

            '****************

            '*****************д������Ϣ(��淶)
            ds.Reset()
            sqlstr = "select * from Con_Criterion where CONTAINER_NO='" & Conta_No & "'"
            dw = Updatedata(sqlda, sqlstr, ds)
            If dw.Count = 0 Then
                Dim row As DataRow
                row = ds.Tables(0).NewRow()
                row("CONTAINER_NO") = Conta_No
                If CONTA_SIZE = "S" Then
                    row("Size_Con") = 20
                ElseIf CONTA_SIZE = "L" Then
                    row("Size_Con") = 40
                End If

                row("CONTAINER_TYPE") = CONTA_TYPE

                row("Code_Con_Company") = ""

                ds.Tables(0).Rows.Add(row)
                sqlda.Update(ds)
            Else
                If CONTA_SIZE = "S" Then
                    ds.Tables(0).Rows(0).Item("Size_Con") = 20
                ElseIf CONTA_SIZE = "L" Then
                    ds.Tables(0).Rows(0).Item("Size_Con") = 40
                End If
                ds.Tables(0).Rows(0).Item("CONTAINER_TYPE") = CONTA_TYPE



                sqlda.Update(ds)
            End If

            '*********************д��յ�����Ϣ
            ds.Reset()

            sqlstr = "select * from CON_HATCH_RECORD where CONTAINER_NO='" & Conta_No & "' and Ship_ID=" & Ship_ID
            dw = Updatedata(sqlda, sqlstr, ds)
            If dw.Count = 0 Then
                Dim row As DataRow
                row = ds.Tables(0).NewRow()
                row("Ship_ID") = Ship_ID
                row("CONTAINER_NO") = Trim(Conta_No)
                If CONTA_SIZE = "S" Then
                    row("Size_Con") = 20
                    If CType(CONTA_WT, Int32) <= 2300 Then
                        row("FULLOREMPTY") = "E"
                    Else
                        row("FULLOREMPTY") = "F"
                    End If
                ElseIf CONTA_SIZE = "L" Then
                    If CType(CONTA_WT, Int32) <= 4600 Then
                        row("FULLOREMPTY") = "E"
                    Else
                        row("FULLOREMPTY") = "F"
                    End If
                    row("Size_Con") = 40
                End If
                If CONTA_TYPE.Trim().Length() = 4 Then
                    row("CONTAINER_TYPE") = Mid(CONTA_TYPE.Trim(), 3, 2)
                End If

                row("SEALNO") = SEAL_NO


                row("BLNO") = BLNO_Con


                If Len(Trim(CONTA_WT)) > 0 Then
                    row("WEIGHT") = CType(CONTA_WT, Double) / 100.0
                End If


                ds.Tables(0).Rows.Add(row)
                sqlda.Update(ds)
            End If
            ds.Dispose()
            dw.Dispose()
            sqlda.Dispose()
            '*********************д��յ�ƴ����Ϣ
            ds.Reset()

            sqlstr = "select * from CON_HATCH_CARGO where CONTAINER_NO='" & Conta_No & "' and BLNO='" & BLNO_Con & "' and Ship_ID=" & Ship_ID
            dw = Updatedata(sqlda, sqlstr, ds)
            If dw.Count = 0 Then
                Dim row As DataRow
                row = ds.Tables(0).NewRow()
                row("Ship_ID") = Ship_ID
                row("CONTAINER_NO") = Trim(Conta_No)
                row("BLNO") = BLNO_Con
                If Len(Trim(CONTA_WT)) > 0 Then
                    If CType(CONTA_WT, Double) > 0 Then
                        row("TOTAL_WEIGHT") = CType(CONTA_WT, Double) / 100.0
                    Else
                        row("TOTAL_WEIGHT") = 0
                    End If
                End If
                ds.Tables(0).Rows.Add(row)
                sqlda.Update(ds)
            End If
            ds.Dispose()
            dw.Dispose()
            sqlda.Dispose()
            '****************
            txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
            If txtLine = Nothing Then
                sr.Close()
                MsgBox("�����Ѷ���!")
                GoTo Err
            End If
            i = i + 1
            s = Mid(txtLine, 5, 1).ToUpper()
        End While
        Exit Sub
Err:
        MsgBox(Err.Description)
        Resume Next
    End Sub

    Private Sub ReadZH()
        On Error GoTo Err
        Dim sr As New StreamReader(txtFile.Text) '�򿪱����ļ�
        Dim txtLine As String
        Dim i As Integer = 0 '��¼����
        Dim j As Integer = 0 'ȡ����Ϣѭ��
        Dim j1 As Integer = 0
        Dim i99 As Integer '�жϽ���
        Dim str As String
        Dim s As String
        Dim sqlstr As String
        Dim Mark As Integer = 0 '**********��ʶĳ���Ƿ����� 1��ʾ������ 0��ʾδ������
        Dim Nation As String = "" '����
        Dim ShipName As String = "" '����
        Dim ShipCode As String = "" '������
        Dim Voyage As String = "" '����
        Dim ShipLineCode As String = "" '����˾����
        Dim ShipLine As String = "" '����˾

        Dim BLNO As String = "" '�ᵥ��
        Dim Pre_ShipCode As String = "" 'ǰ�����䴬������
        Dim Pre_ShipName As String = "" 'ǰ�����䴬��
        Dim Pre_Voyage As String = "" 'ǰ�����亽��
        Dim DeliveryPlaceCode As String = "" '�����ش���
        Dim DeliveryPlace As String = "" '������
        Dim LoadPortCode As String = "" 'װ���۴���
        Dim LoadPort As String = "" 'װ����
        Dim DeliveryTerm As String = "" '��������
        Dim PrePaid As String = "" '���ʽ
        Dim LoadDate As String = "" 'װ������
        Dim CMark As String = "" '�ᵥ��ƴ���־
        Dim unLoadPortCode As String = "" 'ж���۴���
        Dim unLoadPort As String = "" 'ж����
        Dim CargoCode As String = "" '�������
        Dim Amount As String = "" '����
        Dim CodePack As String = "" '��װ����
        Dim Pack As String = "" '��װ����
        Dim GrossWeight As String = "" 'ë��
        Dim NetWeight As String = "" '����
        Dim Size_Measure = "" '���

        Dim DangerousClass As String = "" 'Σ��Ʒ����
        Dim DangerousPage As String = "" 'Σ��Ʒҳ��
        Dim DangerousUNNO As String = "" '���Ϲ�Σ��Ʒ���
        Dim DangerousLabel As String = "" 'Σ��Ʒ��ǩ
        Dim ConTempUnit As String = "" '�¶ȼ�����λ
        Dim ConTempSet As String = "" '�����¶�
        Dim ConTempMax As String = "" '�������¶�
        Dim ConTempMin As String = "" '�������¶�

        Dim BMark As String = "" '��־

        Dim CargoDescr As String = "" '��������

        Dim ConNo As String = "" '���
        Dim SealNo As String = "" 'Ǧ���
        Dim ConType As String = "" '��ߴ�����
        Dim ConStatus As String = "" '��״̬

        Dim ConGrossWeight As String = "" '��ë��
        Dim ConTareWeight As String = "" '��Ƥ��
        Dim ConAmount As String = "" '���ڼ���
        Dim ConMeasure As String = "" '�������
        Dim ConOverFront As String = "" 'ǰ��
        Dim ConOverBack As String = "" '��
        Dim ConOverLeft As String = "" '��
        Dim ConOverRight As String = "" '�ҳ�
        Dim ConOverHeight As String = "" '����
        Dim ConBay As String = "" '�䱴λ��
        Dim iii As Integer

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
                If Trim(str) <> "IFCSUM" Then                      '�յ���ʶ
                    MsgBox("���ĳ��� " & str & " ,���ǲյ�����,������" & i & "��!")
                    Exit Sub
                Else
                    str = EditFetch(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "MANIFEST" Then                '�յ���ʶ
                        'MsgBox("���ĳ��� " & str & " ,���ǲյ�����,������" & i & "��!")
                        'Exit Sub
                    Else
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Trim(str) <> "9" And Trim(str) <> "2" And Trim(str) <> "3" And Trim(str) <> "4" Then                  '�յ���ʶ
                            MsgBox("���ĳ��� " & str & " ,���ǲյ�����,������" & i & "��!")
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
                    Nation = str '����
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
        '*****************������Ϣ (��ʼѭ��)
        Do While j < 9999
            If j < 2000 Then
                PB.Value = j
            End If
            BLNO = ""  '�ᵥ��
            Pre_ShipCode = ""  'ǰ�����䴬������
            Pre_ShipName = ""  'ǰ�����䴬��
            Pre_Voyage = ""  'ǰ�����亽��
            DeliveryPlaceCode = ""  '�����ش���
            DeliveryPlace = ""  '������
            LoadPortCode = ""  'װ���۴���
            LoadPort = ""  'װ����
            DeliveryTerm = "" '��������
            PrePaid = "" '���ʽ
            LoadDate = "" 'װ������

            unLoadPortCode = "" 'ж���۴���
            unLoadPort = "" 'ж����
            CargoCode = "" '�������
            Amount = "" '����
            CodePack = "" '��װ����
            Pack = ""  '��װ����
            GrossWeight = ""  'ë��
            NetWeight = ""  '����
            Size_Measure = "" '���

            DangerousClass = ""  'Σ��Ʒ����
            DangerousPage = ""  'Σ��Ʒҳ��
            DangerousUNNO = ""  '���Ϲ�Σ��Ʒ���
            DangerousLabel = ""  'Σ��Ʒ��ǩ
            ConTempUnit = ""  '�¶ȼ�����λ
            ConTempSet = ""  '�����¶�
            ConTempMax = ""  '�������¶�
            ConTempMin = ""  '�������¶�

            BMark = ""  '��־
            CMark = ""  '�ᵥ��ƴ���־
            CargoDescr = ""  '��������

            ConNo = ""  '���
            SealNo = ""  'Ǧ���
            ConType = ""  '��ߴ�����
            ConStatus = ""  '��״̬

            ConGrossWeight = ""  '��ë��
            ConTareWeight = ""  '��Ƥ��
            ConAmount = ""  '���ڼ���
            ConMeasure = "" '�������
            ConOverFront = ""  'ǰ��
            ConOverBack = ""  '��
            ConOverLeft = ""  '��
            ConOverRight = "" '�ҳ�
            ConOverHeight = "" '����
            ConBay = ""  '�䱴λ��

            i99 = 0
            '*************�����¼ 12 ������װ����Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 12 �����ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "12" Then
                    i99 = 1
                    str = EditFetch(txtLine)                '*******ȡ�ᵥ��
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        BLNO = str
                    Else
                        'MsgBox("���ĳ��� " & str & " ,������" & i & "��!")
                        BLNO = ""
                    End If
                    str = EditFetch(txtLine)                '*******ȡǰ�����䴬������
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        Pre_ShipCode = str
                    End If
                    str = EditFetch(txtLine)                '*******ȡǰ�����䴬��
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        Pre_ShipName = str
                    End If
                    str = EditFetch(txtLine)                '*******ȡǰ�����亽��
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        Pre_Voyage = str
                    End If
                    str = EditFetch(txtLine)                '*******�����ش���
                    txtLine = Mid(txtLine, Len(str) + 2)
                    iii = 2
                    If Len(Trim(str)) >= 0 And Len(Trim(str)) <= 5 Then
                        DeliveryPlaceCode = str
                        iii = 0
                    Else
                        DeliveryPlace = str
                        iii = 1
                    End If
                    If iii = 0 Then
                        str = EditFetch(txtLine)                '*******������
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 Then
                            DeliveryPlace = str
                        End If
                    End If
                    str = EditFetch(txtLine)                '*******װ���۴���
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        LoadPortCode = str
                    End If
                    str = EditFetch(txtLine)                '*******װ����
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        LoadPort = str
                    End If
                    'str = EditFetch(txtLine)                '*******��������
                    'txtLine = Mid(txtLine, Len(str) + 2)
                    'If Len(Trim(str)) > 0 Then
                    '    DeliveryTerm = str
                    'End If
                    'str = EditFetch(txtLine)                '*******ȡ���ʽ
                    'txtLine = Mid(txtLine, Len(str) + 2)
                    'If Len(Trim(str)) > 0 Then
                    '    If Trim(str) = "P" Or Trim(str) = "C" Or Trim(str) = "F" Then
                    '        PrePaid = str
                    '    Else
                    '        MsgBox("���ĳ��� ȡ���ʽ " & str & " ,������" & i & "��!")
                    '        PrePaid = ""
                    '    End If
                    'Else
                    '    'MsgBox("���ĳ��� " & str & " ,������" & i & "��!")
                    '    PrePaid = ""
                    'End If
                    'str = EditFetch(txtLine)                '*******ȡװ������
                    'txtLine = Mid(txtLine, Len(str) + 2)
                    'If Len(Trim(str)) > 0 And Len(Trim(str)) = 8 Then
                    '    LoadDate = str
                    'Else
                    '    MsgBox("���ĳ��� ȡװ������ " & str & " ,������" & i & "��!")
                    '    LoadDate = ""
                    'End If

                    Mark = 1
                Else
                    If Mark = 1 Then
                        MsgBox("���ĳ��� " & str & " ,������" & i & "��!")
                        Exit Sub
                    End If
                End If
            End If
            '*************�����¼ 13 �ᵥ�ص���Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 13 �ᵥ�ص���Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "13" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******ȡж���۴���
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        unLoadPortCode = str
                    End If
                    str = EditFetch(txtLine)                '*******ȡж����
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        unLoadPort = str
                    End If
                    str = EditFetch(txtLine)                '*******ȡж�����ش���
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        DeliveryPlaceCode = str
                    End If
                    str = EditFetch(txtLine)                '*******ȡж������
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        DeliveryPlace = str
                    End If
                Else
                    If Mark = 1 Then
                        MsgBox("���ĳ��� " & str & " ,������" & i & "��!")
                        Exit Sub
                    End If
                End If
            End If
            '*************�����¼ 14 �ᵥ��ѡж������Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 14 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "14" Then
                    i99 = 1
                    Mark = 1

                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 15 �ᵥ�˷���Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 15 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "15" Then
                    i99 = 1
                    Mark = 1
                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 15 �ᵥ�˷���Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 15 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "15" Then
                    i99 = 1
                    Mark = 1
                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 15 �ᵥ�˷���Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 15 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "15" Then
                    i99 = 1
                    Mark = 1
                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 15 �ᵥ�˷���Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 15 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "15" Then
                    i99 = 1
                    Mark = 1
                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 15 �ᵥ�˷���Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 15 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "15" Then
                    i99 = 1
                    Mark = 1
                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 16 �ᵥ��������Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 16 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "16" Then
                    i99 = 1
                    Mark = 1

                Else
                    If Trim(str) = "15" Then
                        i99 = 1
                        Mark = 1
                    End If
                    Mark = 0
                End If
            End If
            '*************�����¼ 17 �ᵥ�ջ�����Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 17 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "17" Then
                    i99 = 1
                    Mark = 1

                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 17 �ᵥ�ջ�����Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 17 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "17" Then
                    i99 = 1
                    Mark = 1

                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 17 �ᵥ�ջ�����Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 17 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "17" Then
                    i99 = 1
                    Mark = 1

                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 17 �ᵥ�ջ�����Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 17 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "17" Then
                    i99 = 1
                    Mark = 1

                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 18 �ᵥ��һ֪ͨ����Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 18 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "18" Then
                    i99 = 1
                    Mark = 1

                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 18 �ᵥ��һ֪ͨ����Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 18 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "18" Then
                    i99 = 1
                    Mark = 1

                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 18 �ᵥ��һ֪ͨ����Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 18 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "18" Then
                    i99 = 1
                    Mark = 1

                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 19 �ᵥ�ڶ�֪ͨ����Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 19 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "19" Then
                    i99 = 1
                    Mark = 1
                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 20 �ᵥ����֪ͨ����Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 20 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "20" Then
                    i99 = 1
                    Mark = 1

                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 41 �ᵥ������Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 41 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "41" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******ȡ�������
                    txtLine = Mid(txtLine, Len(str) + 2)
                    str = EditFetch(txtLine)                '*******ȡ�������
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        CargoCode = str
                    End If
                    str = EditFetch(txtLine)                '*******ȡ����
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        Amount = str
                    Else
                        Amount = ""
                    End If
                    str = EditFetch(txtLine)                '*******ȡ��װ����
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        CodePack = str
                    End If
                    str = EditFetch(txtLine)                '*******ȡ��װ
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        Pack = str
                    End If
                    str = EditFetch(txtLine)                '*******ȡë��
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        GrossWeight = str
                    End If
                    str = EditFetch(txtLine)                '*******ȡ����
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        NetWeight = str
                    End If
                    str = EditFetch(txtLine)                '*******ȡ���
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        Size_Measure = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 43 �ᵥΣ��Ʒ�����Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 43 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "43" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******ȡΣ��Ʒ����
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        DangerousClass = str

                    End If
                    str = EditFetch(txtLine)                '*******ȡΣ��Ʒҳ��
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        DangerousPage = str
                    End If
                    str = EditFetch(txtLine)                '*******ȡ���Ϲ�Σ��Ʒ���
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        DangerousUNNO = str
                    End If
                    str = EditFetch(txtLine)                '*******ȡΣ��Ʒ��ǩ
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        DangerousLabel = str
                    End If
                    str = EditFetch(txtLine)                '*******ȡΣ�ջ�������
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******ȡ����Σ��ƷӦ����ʩ��
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******ȡҽ�Ƽ���ָ�Ϻ�
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******ȡӦ����ϵ
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******ȡ�¶ȼ�����λ
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConTempUnit = str
                        If Len(Trim(ConTempUnit)) Then
                            ConTempUnit = ""
                        End If
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
                    Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 44 �ᵥMark��Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 44 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "44" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******ȡ�������
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 And Len(Trim(txtLine)) = 0 Then
                        BMark = str
                    ElseIf Len(Trim(str)) > 0 Then
                    End If

                    str = EditFetch(txtLine)                '*******ȡ��ͷ
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        BMark = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 44 �ᵥMark��Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 44 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "44" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******ȡ�������
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 And Len(Trim(txtLine)) = 0 Then
                        BMark = str
                    ElseIf Len(Trim(str)) > 0 Then
                    End If

                    str = EditFetch(txtLine)                '*******ȡ��ͷ
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        BMark = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 44 �ᵥMark��Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 44 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "44" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******ȡ�������
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 And Len(Trim(txtLine)) = 0 Then
                        BMark = str
                    ElseIf Len(Trim(str)) > 0 Then
                    End If

                    str = EditFetch(txtLine)                '*******ȡ��ͷ
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        BMark = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 44 �ᵥMark��Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 44 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "44" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******ȡ�������
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 And Len(Trim(txtLine)) = 0 Then
                        BMark = str
                    ElseIf Len(Trim(str)) > 0 Then
                    End If

                    str = EditFetch(txtLine)                '*******ȡ��ͷ
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        BMark = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 44 �ᵥMark2��Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 44 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "44" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******ȡ�������
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******ȡ��ͷ
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        BMark = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 44 �ᵥMark3��Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 44 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "44" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******ȡ�������
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******ȡ��ͷ
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        BMark = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 44 �ᵥMark4��Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 44 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "44" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******ȡ�������
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******ȡ��ͷ
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        BMark = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 44 �ᵥMark5��Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 44 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "44" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******ȡ�������
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******ȡ��ͷ
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        BMark = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 47 �ᵥ����������Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 47 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "47" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******ȡ�������
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******ȡ��������
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        CargoDescr = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 47 �ᵥ��������2��Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 47 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "47" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******ȡ�������
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******ȡ��������
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        CargoDescr = str
                    End If
                Else
                    Mark = 0
                End If
            End If

            '*************�����¼ 47 �ᵥ��������2��Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 47 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "47" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******ȡ�������
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******ȡ��������
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        CargoDescr = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 47 �ᵥ��������2��Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 47 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "47" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******ȡ�������
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******ȡ��������
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        CargoDescr = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 47 �ᵥ��������2��Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 47 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "47" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******ȡ�������
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******ȡ��������
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        CargoDescr = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 47 �ᵥ��������2��Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 47 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "47" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******ȡ�������
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******ȡ��������
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        CargoDescr = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************�����¼ 47 �ᵥ��������2��Ϣ
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 47 �ᵥ��Ϣ,������" & i & "��!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "47" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******ȡ�������
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******ȡ��������
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        CargoDescr = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '***************У�����Ϣ
            If Len(Trim(BLNO)) = 0 And i99 = 1 Then
                Dim Frm As New FrmReadTemp
                G_SelectStr = "�� " & i & " ��Χ���ᵥ�ſմ��� "
                Frm.ShowDialog()
                BLNO = Trim(G_SelectCode)


            End If

            '****************
            '*************�����¼ 51 ��װ����Ϣ

            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
                s = txtLine
                Mark = 0
                i = i + 1
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("���ĳ���! �����¼ 51 ��װ����Ϣ,������" & i & "��!")
                Exit Sub
            Else
                j1 = 0
                Do While 1 = 1
                    ConNo = ""  '���
                    SealNo = ""  'Ǧ���
                    ConType = ""  '��ߴ�����
                    ConStatus = ""  '��״̬

                    ConAmount = ""  '���ڼ���
                    ConGrossWeight = ""  '���ڻ���
                    ConTareWeight = ""  '��Ƥ��

                    ConMeasure = "" '�������
                    ConOverFront = ""  'ǰ��
                    ConOverBack = ""  '��
                    ConOverLeft = ""  '��
                    ConOverRight = "" '�ҳ�
                    ConOverHeight = "" '����
                    ConBay = ""  '�䱴λ��

                    If Mark = 1 Then
                        txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��
                        i = i + 1
                        s = txtLine
                    End If
                    str = EditFetch(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) = "51" Then
                        i99 = 1
                        Mark = 1
                        j1 = j1 + 1
                        str = EditFetch(txtLine)            '�������
                        txtLine = Mid(txtLine, Len(str) + 2)

                        str = EditFetch(txtLine)            '���
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 Then
                            ConNo = Trim(str) '���
                        Else
                            ConNo = ""
                        End If
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 Then
                            SealNo = str 'Ǧ���
                        Else
                            SealNo = ""
                        End If
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 Then
                            ConType = Trim(str) '��װ��ߴ�����
                        Else
                            ConType = ""
                        End If
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 Then
                            ConStatus = str '��״̬
                            If Upper(Trim(str)) = "L" Then
                                CMark = "L"
                            End If
                        Else
                            ConStatus = ""
                        End If
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 And IsNumeric(Trim(str)) Then
                            ConAmount = str  '���ڻ������
                        End If
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 And IsNumeric(Trim(str)) Then
                            ConGrossWeight = str '���ڻ���
                        End If
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 And IsNumeric(Trim(str)) Then
                            ConTareWeight = str '��Ƥ��
                        End If

                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 And IsNumeric(Trim(str)) Then

                            ConMeasure = str '���ڻ������
                        End If
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 And IsNumeric(Trim(str)) Then
                            ConOverFront = str 'ǰ��
                        End If
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 And IsNumeric(Trim(str)) Then
                            ConOverBack = str '��
                        End If
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 And IsNumeric(Trim(str)) Then
                            ConOverLeft = str '��
                        End If
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 And IsNumeric(Trim(str)) Then
                            ConOverRight = str '�ҳ�
                        End If
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 And IsNumeric(Trim(str)) Then
                            ConOverHeight = str '����
                        End If
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 And IsNumeric(Trim(str)) Then
                            ConBay = str '��λ
                        End If
                        '*************************У��
                        If i99 = 1 Then
                            If Len(Trim(ConNo)) = 0 Then
                                Dim Frm As New FrmReadTemp
                                G_SelectStr = "����  ��ſմ���,������" & i & "��!"
                                Frm.ShowDialog()
                                ConNo = Trim(G_SelectCode)
                            End If
                            'If Len(Trim(ConType)) = 0 Then
                            '    Dim Frm As New FrmReadTemp
                            '    G_SelectStr = "�� " & ConNo & " ���ʹ���մ���"
                            '    Frm.ShowDialog()
                            '    ConType = Trim(G_SelectCode)
                            'End If
                            If Len(Trim(ConStatus)) = 0 Then
                                Dim Frm As New FrmReadTemp
                                G_SelectStr = "�� " & ConNo & " ����ؿմ���"
                                Frm.ShowDialog()
                                ConStatus = Trim(G_SelectCode)
                            End If
                            'If Len(Trim(SealNo)) = 0 Then
                            '    Dim Frm As New FrmReadTemp()
                            '    G_SelectStr = "�� " & ConNo & " ��Ǧ��ſմ���"
                            '    Frm.ShowDialog()
                            '    SealNo = Trim(G_SelectCode)
                            'End If
                            'If Len(Trim(ConGrossWeight)) = 0 Then
                            '    Dim Frm As New FrmReadTemp
                            '    G_SelectStr = "�� " & ConNo & "  �����ڻ��� �մ���"
                            '    Frm.ShowDialog()
                            '    ConGrossWeight = Trim(G_SelectCode)
                            'End If
                            'If Len(Trim(ConAmount)) = 0 Then
                            '    Dim Frm As New FrmReadTemp
                            '    G_SelectStr = "�� " & ConNo & " ���ڻ������"
                            '    Frm.ShowDialog()
                            '    ConAmount = Trim(G_SelectCode)
                            'End If
                            'If Len(Trim(ConTareWeight)) = 0 Then
                            '    Dim Frm As New FrmReadTemp
                            '    G_SelectStr = "�� " & ConNo & " ��Ƥ��"
                            '    Frm.ShowDialog()
                            '    ConTareWeight = Trim(G_SelectCode)
                            'End If
                            '*****************д������Ϣ
                            Dim Size As String = "0"
                            Dim Type As String = "0"
                            Dim SSSS As String = "0"
                            Dim sqlstr123 As String
                            '*****************ȡ����
                            ds.Reset()
                            sqlstr123 = "select * from Code_Con_Type where  Code_Ship_Type='" & ConType & "'"
                            dw = Getdata(sqlstr123, ds)
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
                            '*****************д������Ϣ(��淶)
                            ds.Reset()
                            sqlstr = "select * from Con_Criterion where CONTAINER_NO='" & ConNo & "'"
                            dw = Updatedata(sqlda, sqlstr, ds)
                            If dw.Count = 0 Then
                                Dim row As DataRow
                                row = ds.Tables(0).NewRow()
                                row("CONTAINER_NO") = ConNo
                                row("Size_Con") = CInt(SSSS)
                                row("CONTAINER_TYPE") = Type
                                row("CODE_SHIP_OWNER") = ShipLineCode
                                row("Code_Con_Company") = ""
                                If Len(Trim(ConTareWeight)) > 0 Then
                                    row("CON_WEIGHT") = CType(ConTareWeight, Double)
                                End If
                                If Len(Trim(ConOverHeight)) > 0 Then
                                    row("OVER_Height") = CType(ConOverHeight, Double)
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

                                ds.Tables(0).Rows.Add(row)
                                sqlda.Update(ds)
                            Else
                                ds.Tables(0).Rows(0).Item("Size_Con") = CInt(SSSS)
                                ds.Tables(0).Rows(0).Item("CONTAINER_TYPE") = Type
                                ds.Tables(0).Rows(0).Item("CODE_SHIP_OWNER") = ShipLineCode

                                If Len(Trim(ConTareWeight)) > 0 Then
                                    ds.Tables(0).Rows(0).Item("CON_WEIGHT") = CType(ConTareWeight, Double)
                                End If
                                If Len(Trim(ConOverHeight)) > 0 Then
                                    ds.Tables(0).Rows(0).Item("OVER_Height") = CType(ConOverHeight, Double)
                                End If
                                If Len(Trim(ConOverLeft)) > 0 Then
                                    ds.Tables(0).Rows(0).Item("OVER_LEFT") = CType(ConOverLeft, Double)
                                End If
                                If Len(Trim(ConOverRight)) > 0 Then
                                    ds.Tables(0).Rows(0).Item("OVER_RIGHT") = CType(ConOverRight, Double)
                                End If
                                If Len(Trim(ConOverFront)) > 0 Then
                                    ds.Tables(0).Rows(0).Item("OVER_BEFORE") = CType(ConOverFront, Double)
                                End If
                                If Len(Trim(ConOverBack)) > 0 Then
                                    ds.Tables(0).Rows(0).Item("OVER_BEHIND") = CType(ConOverBack, Double)
                                End If


                                sqlda.Update(ds)
                            End If

                            '*********************д��յ�����Ϣ
                            ds.Reset()

                            sqlstr = "select * from CON_HATCH_RECORD where CONTAINER_NO='" & ConNo & "' and Ship_ID=" & Ship_ID
                            dw = Updatedata(sqlda, sqlstr, ds)
                            If dw.Count = 0 Then
                                Dim row As DataRow
                                row = ds.Tables(0).NewRow()
                                row("Ship_ID") = Ship_ID
                                row("CONTAINER_NO") = Trim(ConNo)
                                row("Size_Con") = CInt(SSSS)
                                row("CONTAINER_TYPE") = Type
                                row("FULLOREMPTY") = ConStatus

                                row("SEALNO") = SealNo
                                If Len(Trim(ConBay)) > 0 Then
                                    row("BayNo") = ConBay
                                End If
                                row("Code_Goods") = CargoCode
                                row("BLNO") = BLNO
                                If Len(Trim(ConAmount)) > 0 Then
                                    row("Amount") = CType(ConAmount, Int32)
                                End If
                                If Len(Trim(ConGrossWeight)) > 0 And Len(Trim(ConTareWeight)) > 0 Then
                                    row("WEIGHT") = CType(ConGrossWeight, Double) + CType(ConTareWeight, Double)
                                End If
                                If Len(Trim(ConMeasure)) > 0 Then
                                    row("VOLUME") = CType(ConMeasure, Double)
                                End If

                                ds.Tables(0).Rows.Add(row)
                                sqlda.Update(ds)
                            End If
                            ds.Dispose()
                            dw.Dispose()
                            sqlda.Dispose()
                            '*********************д��յ�ƴ����Ϣ
                            ds.Reset()

                            sqlstr = "select * from CON_HATCH_CARGO where CONTAINER_NO='" & ConNo & "' and BLNO='" & BLNO & "' and Ship_ID=" & Ship_ID
                            dw = Updatedata(sqlda, sqlstr, ds)
                            If dw.Count = 0 Then
                                Dim row As DataRow
                                row = ds.Tables(0).NewRow()
                                row("Ship_ID") = Ship_ID
                                row("CONTAINER_NO") = Trim(ConNo)
                                row("Mark") = BMark
                                row("BLNO") = BLNO
                                If Len(Trim(ConAmount)) > 0 Then
                                    row("Amount") = CType(ConAmount, Int32)
                                End If
                                If Len(Trim(ConGrossWeight)) > 0 Then
                                    row("NETWEIGHT") = CType(ConGrossWeight, Double)
                                End If
                                If Len(Trim(ConGrossWeight)) > 0 And Len(Trim(ConTareWeight)) > 0 Then
                                    row("TOTAL_WEIGHT") = CType(ConGrossWeight, Double) + CType(ConTareWeight, Double)
                                End If
                                ds.Tables(0).Rows.Add(row)
                                sqlda.Update(ds)
                            End If
                            ds.Dispose()
                            dw.Dispose()
                            sqlda.Dispose()
                        End If

                        '*************************
                    Else
                        If Mark = 1 Or i99 = 0 Then
                            Mark = 0
                            Exit Do
                        End If

                    End If

                Loop
            End If
            '********************д���ᵥ��Ϣ
            If i99 = 1 Then
                ds.Reset()

                sqlstr = "select * from CON_HATCH_LIST where BLNO='" & BLNO & "' and Ship_ID=" & Ship_ID
                dw = Updatedata(sqlda, sqlstr, ds)
                If dw.Count = 0 Then
                    Dim row As DataRow
                    row = ds.Tables(0).NewRow()
                    row("Ship_ID") = Ship_ID
                    row("BLNO") = BLNO
                    row("PRE_SHIPCODE") = Pre_ShipCode
                    row("PRE_SHIPName") = Pre_ShipName
                    row("PRE_Voyage") = Pre_Voyage

                    row("CODE_LOAD_PORT") = LoadPortCode
                    row("LOAD_PORT") = LoadPort
                    row("CODE_UnLOAD_PORT") = unLoadPortCode
                    row("UnLOAD_PORT") = unLoadPort
                    row("CODE_PLACE_RECEIVE") = DeliveryPlaceCode
                    row("PLACE_RECEIVE") = DeliveryPlace
                    row("CONSIGNMENT_ITEM") = DeliveryTerm
                    If Len(Trim(LoadDate)) > 0 Then
                        row("LOAD_DATE") = CType(Mid(LoadDate, 1, 4) & "/" & Mid(LoadDate, 5, 2) & "/" & Mid(LoadDate, 7, 2), Date)
                    End If
                    If Len(Trim(NetWeight)) > 0 Then
                        row("EMPTY_MARK") = "1"
                    Else
                        row("EMPTY_MARK") = "0"
                    End If

                    row("Mark") = BMark

                    row("CODE_GOODS") = CargoCode
                    row("GOODS_ENG") = CargoDescr
                    row("GOODS_CHA") = CargoDescr
                    row("CONTAINER_MARK") = CMark
                    row("CONTAINER") = j1
                    If Len(Trim(Amount)) > 0 Then
                        row("Amount") = CType(Amount, Int32)
                    End If
                    row("Code_Pack") = CodePack
                    row("Pack") = Pack
                    If Len(Trim(NetWeight)) > 0 Then
                        row("NetWeight") = CType(NetWeight, Double)
                    End If
                    If Len(Trim(GrossWeight)) > 0 Then
                        row("Gross_Weight") = CType(GrossWeight, Double)
                    End If
                    If Len(Trim(Size_Measure)) > 0 Then
                        row("Size_Measure") = CType(Size_Measure, Double)
                    End If
                    If Len(Trim(NetWeight)) > 0 And Len(Trim(Amount)) > 0 Then
                        If (CType(Amount, Int32) > 0) Then
                            row("PIECE_WEIGHT") = CType(GrossWeight, Double) / CType(Amount, Int32)
                        Else
                            row("PIECE_WEIGHT") = CType(GrossWeight, Double) / 1

                        End If

                    End If
                    If Len(Trim(ConTempSet)) > 0 And IsNumeric(ConTempSet) Then
                        row("REFRIGERATE_TEMPERATURE") = CType(ConTempSet, Double)
                    End If
                    row("TEMPERATURE") = ConTempUnit
                    row("DANGER_GRADE") = DangerousClass
                    row("DANGER_NO") = DangerousPage
                    row("DANGER_PAGENO") = DangerousUNNO
                    row("DANGER_MARK") = DangerousLabel

                    ds.Tables(0).Rows.Add(row)
                    sqlda.Update(ds)
                Else
                    'MsgBox("�Ѵ��ڴ��ᵥ��Ϣ �ᵥ��Ϊ " & BLNO)
                End If
                ds.Dispose()
                dw.Dispose()
                sqlda.Dispose()
            End If


            If i99 = 0 Then
                Exit Do

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
        Exit Sub
Err:
        MsgBox(Err.Description)
        Resume Next
    End Sub
    Private Sub ReadZY()
        Dim sr As New StreamReader(txtFile.Text) '�򿪱����ļ�
        Dim txtLine As String
        Dim i As Integer = 0 '��¼����
        Dim str As String

        Dim ConNo As String = "" '���
        Dim ConType As String = "" '��ߴ�����
        Dim SealNo As String = "" 'Ǧ���
        Dim Mark As String = "" '��־
        Dim ConStatus As String = "" '��״̬
        Dim ConTareWeight As String = "" '��Ƥ��
        Dim ConTempMax As String = "" '�������¶�
        Dim ConTempMin As String = "" '�������¶�
        Dim LoadPortCode As String = "LYG" 'װ���۴���
        Dim unLoadPortCode As String = "" 'ж���۴���
        Dim DeliveryPlaceCode As String = "" '�����ش���
        Dim ConJinWeight As String = "" '����
        Dim ConGrossWeight As String = "" '��ë��
        Dim Amount As String = "" '����
        Dim BLNO As String = "" '�ᵥ��
        Dim DangerousClass As String = "" 'Σ��Ʒ����


        '*****************��װ����Ϣ (��ʼѭ��)
        Do While i < 99999
            If i < 2000 Then
                PB.Value = i
            End If
            ConNo = "" '���
            ConType = "" '��ߴ�����
            SealNo = "" 'Ǧ���
            Mark = "" '��־
            ConStatus = "" '��״̬
            ConTareWeight = "0"  '��Ƥ��
            ConTempMax = "0"  '�������¶�
            ConTempMin = "0"  '�������¶�
            LoadPortCode = "LYG"  'װ���۴���
            unLoadPortCode = ""  'ж���۴���
            DeliveryPlaceCode = ""  '�����ش���
            ConJinWeight = "" ' ����
            Amount = "" '����
            ConGrossWeight = "0"  '��ë��
            BLNO = ""  '�ᵥ��
            DangerousClass = ""  'Σ��Ʒ����


            txtLine = Trim(sr.ReadLine()) '���з�ʽ��ȡһ��

            If txtLine = Nothing Then
                MsgBox("��ȡ������лл���� " & i & " ��.")
                Exit Sub
            Else

                str = Mid(txtLine, 1, 11)              '*******ȡ���

                If Len(Trim(str)) > 0 Then
                    ConNo = Trim(str)
                End If
                str = Mid(txtLine, 12, 4)              '*******ȡ��ߴ�����
                If Len(Trim(str)) > 0 Then
                    ConType = Trim(str)
                End If
                str = Mid(txtLine, 16, 10)              '*******ȡ��Ǧ���
                If Len(Trim(str)) > 0 Then
                    SealNo = Trim(str)
                End If
                str = Mid(txtLine, 26, 8)              '*******ȡ�ᵥ��־
                If Len(Trim(str)) > 0 Then
                    Mark = Trim(str)
                End If
                str = Mid(txtLine, 34, 1)               '******ȡ��״̬
                If Len(Trim(str)) > 0 Then
                    ConStatus = Trim(str)
                End If
                str = Mid(txtLine, 35, 7)               '******Ƥ��
                If Len(Trim(str)) > 0 Then
                    ConTareWeight = Trim(str)
                End If

                str = Mid(txtLine, 42, 3)              '*******ȡ�������¶�
                If Len(Trim(str)) > 0 Then
                    If Mid(Trim(str), 3, 1) = "'" Then
                        ConTempMax = Mid(Trim(str), 1, Len(Trim(str)) - 1)
                    Else
                        ConTempMax = Trim(str)
                    End If
                End If

                str = Mid(txtLine, 51, 3)              '*******ȡ�������¶�
                If Len(Trim(str)) > 0 Then
                    If Mid(Trim(str), 3, 1) = "'" Then
                        ConTempMin = Mid(Trim(str), 1, Len(Trim(str)) - 1)
                    Else
                        ConTempMin = Trim(str)
                    End If
                End If
                str = Mid(txtLine, 58, 5)               '*******ж����
                If Len(Trim(str)) > 0 Then
                    unLoadPortCode = FindPort(Trim(str), "COSC")

                End If

                str = Mid(txtLine, 63, 5)               '******������
                If Len(Trim(str)) > 0 Then
                    DeliveryPlaceCode = FindPort(Trim(str), "COSC")
                End If

                str = Mid(txtLine, 68, 6)              '*******����
                If Len(Trim(str)) > 0 Then
                    Amount = Trim(str)
                End If


                str = Mid(txtLine, 74, 7)              '����
                If Len(Trim(str)) > 0 Then
                    ConJinWeight = Trim(str)
                End If

                str = Mid(txtLine, 81, 16)              '*******�ᵥ��
                If Len(Trim(str)) > 0 Then
                    BLNO = Trim(str)
                End If

                str = Mid(txtLine, 97, 3)                '*******Σ��Ʒ����
                If Len(Trim(str)) > 0 Then
                    DangerousClass = Trim(str)
                End If

            End If


            '*****************д������Ϣ(��淶)
            Dim Size As String = "0"
            Dim Type As String = "0"
            Dim sqlstr As String

            '*****************ȡ���͹淶

            Size = Mid(ConType, 3, 2)
            Type = Mid(ConType, 1, 2)
            ConType = Size & Type
            '*****************д������Ϣ(��淶)
            ds.Reset()
            sqlstr = "select * from Con_Criterion where CONTAINER_NO='" & ConNo & "'"
            dw = Updatedata(sqlda, sqlstr, ds)
            If dw.Count = 0 Then
                Dim row As DataRow
                row = ds.Tables(0).NewRow()
                row("CONTAINER_NO") = ConNo
                row("Size_Con") = Size
                row("CONTAINER_TYPE") = Type
                row("CODE_SHIP_OWNER") = "COSC"
                row("Code_Con_Company") = "COSC"
                row("CON_WEIGHT") = CType(ConTareWeight, Double)
                ds.Tables(0).Rows.Add(row)
                sqlda.Update(ds)
            End If

            '*********************д��յ�����Ϣ
            ds.Reset()

            sqlstr = "select * from CON_HATCH_RECORD where CONTAINER_NO='" & ConNo & "' and Ship_ID=" & Ship_ID
            dw = Updatedata(sqlda, sqlstr, ds)
            If dw.Count = 0 Then
                Dim row As DataRow
                row = ds.Tables(0).NewRow()
                row("Ship_ID") = Ship_ID
                row("CONTAINER_NO") = Trim(ConNo)
                row("Size_Con") = CInt(Size)
                row("CONTAINER_TYPE") = Type
                row("FULLOREMPTY") = ConStatus
                row("SEALNO") = SealNo
                row("Code_Goods") = Mark
                row("BLNO") = BLNO
                row("Amount") = CType(Amount, Int32)

                row("WEIGHT") = CType(ConJinWeight, Double) + CType(ConTareWeight, Double)
                ds.Tables(0).Rows.Add(row)
                sqlda.Update(ds)
            End If
            '*********************д��յ�ƴ����Ϣ
            ds.Reset()

            sqlstr = "select * from CON_HATCH_CARGO where CONTAINER_NO='" & ConNo & "' and Ship_ID=" & Ship_ID
            dw = Updatedata(sqlda, sqlstr, ds)
            If dw.Count = 0 Then
                Dim row As DataRow
                row = ds.Tables(0).NewRow()
                row("Ship_ID") = Ship_ID
                row("CONTAINER_NO") = Trim(ConNo)
                row("Mark") = Mark
                row("BLNO") = BLNO
                row("Amount") = CType(Amount, Int32)
                row("NETWEIGHT") = CType(ConJinWeight, Double)
                row("TOTAL_WEIGHT") = CType(ConJinWeight, Double) + CType(ConTareWeight, Double)
                ds.Tables(0).Rows.Add(row)
                sqlda.Update(ds)
            End If
            '*********************д��յ���Ϣ
            ds.Reset()

            sqlstr = "select * from CON_HATCH_LIST where BLNO='" & BLNO & "' and Ship_ID=" & Ship_ID
            dw = Updatedata(sqlda, sqlstr, ds)
            If dw.Count = 0 Then
                Dim row As DataRow
                row = ds.Tables(0).NewRow()
                row("Ship_ID") = Ship_ID
                row("BLNO") = BLNO
                row("CODE_LOAD_PORT") = LoadPortCode
                row("CODE_UnLOAD_PORT") = unLoadPortCode
                row("CODE_PLACE_RECEIVE") = DeliveryPlaceCode

                row("CONTAINER") = 1
                row("Amount") = CType(Amount, Int32)
                row("Mark") = Mark
                row("GOODS_ENG") = Mark
                row("GOODS_CHA") = Mark


                row("EMPTY_MARK") = ConStatus

                row("CONTAINER_MARK") = ConStatus
                If CType(ConTempMax, Int32) > 0 Then

                    row("TEMPERATURE") = "C"

                End If
                If ConTempMax <> "0" Then
                    row("REFRIGERATE_TEMPERATURE") = CType(ConTempMax, Int32)
                End If
                row("NETWEIGHT") = CType(ConJinWeight, Double)
                row("Gross_WEIGHT") = CType(ConJinWeight, Double) + CType(ConTareWeight, Double)
                row("PIECE_WEIGHT") = (CType(ConJinWeight, Double) + CType(ConTareWeight, Double)) / CType(Amount, Int32)
                row("DANGER_GRADE") = DangerousClass
                ds.Tables(0).Rows.Add(row)
                sqlda.Update(ds)
            Else

                ds.Tables(0).Rows(0).Item("CONTAINER") = ds.Tables(0).Rows(0).Item("CONTAINER") + 1
                ds.Tables(0).Rows(0).Item("PIECE_WEIGHT") = (ds.Tables(0).Rows(0).Item("Gross_WEIGHT") + CType(ConJinWeight, Double) + CType(ConTareWeight, Double)) / (CType(Amount, Int32) + ds.Tables(0).Rows(0).Item("Amount"))
                ds.Tables(0).Rows(0).Item("Amount") = CType(Amount, Int32) + ds.Tables(0).Rows(0).Item("Amount")

                ds.Tables(0).Rows(0).Item("EMPTY_MARK") = ConStatus

                ds.Tables(0).Rows(0).Item("CONTAINER_MARK") = ConStatus
                If CType(ConTempMax, Int32) > 0 Then
                    ds.Tables(0).Rows(0).Item("TEMPERATURE") = "C"
                End If
                If ConTempMax <> "0" Then
                    ds.Tables(0).Rows(0).Item("REFRIGERATE_TEMPERATURE") = CType(ConTempMax, Int32)
                End If
                ds.Tables(0).Rows(0).Item("NETWEIGHT") = ds.Tables(0).Rows(0).Item("NETWEIGHT") + CType(ConJinWeight, Double)
                ds.Tables(0).Rows(0).Item("Gross_WEIGHT") = ds.Tables(0).Rows(0).Item("Gross_WEIGHT") + CType(ConJinWeight, Double) + CType(ConTareWeight, Double)

                ds.Tables(0).Rows(0).Item("DANGER_GRADE") = DangerousClass

                sqlda.Update(ds)
            End If


            i = i + 1
        Loop
        PB.Value = 2000
        sr.Close()
    End Sub

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


End Class
