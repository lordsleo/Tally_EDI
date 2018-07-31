Imports System.Web.Mail
Imports System.IO
Imports TALLY.DBControl
Public Class FrmReadMailList
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
        Me.Label2.Text = "进出口"
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
        Me.Label5.Text = "航次"
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
        Me.Label3.Text = "英文船名"
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
        Me.Label1.Text = "中文船名"
        '
        'btReadNew
        '
        Me.btReadNew.Location = New System.Drawing.Point(154, 76)
        Me.btReadNew.Name = "btReadNew"
        Me.btReadNew.Size = New System.Drawing.Size(66, 24)
        Me.btReadNew.TabIndex = 18
        Me.btReadNew.Text = "读取报文"
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
        Me.OpenFile.Text = "打开文件"
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
        Me.Text = "舱单报文读取"
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
        Dim sr As New StreamReader(txtFile.Text) '打开报文文件
        Dim txtLine As String
        txtLine = Trim(sr.ReadLine()) '读取一行
        sr.Close()
        If Mid(txtLine, 1, 3) = "00:" Then '****交通部
            Call ReadZH()
        ElseIf Mid(txtLine, 7, 1).ToUpper() = "I" Or Mid(txtLine, 7, 1).ToUpper() = "E" Then '*****中远
            Call ReadHG()
        End If

    End Sub
    Private Sub ReadHG()
        On Error GoTo Err
        Dim sr As New StreamReader(txtFile.Text) '打开报文文件
        Dim txtLine As String
        Dim i As Integer = 0 '记录行数
        Dim j As Integer = 0 '取箱信息循环

        Dim str As String
        Dim s As String
        Dim sqlstr As String

        Dim InOutMark As String '进出口标志

        Dim BLNO As String '提单号
        Dim LoadPort As String '装货
        Dim unLoadPort As String '卸货
        Dim LoadPlace As String '装货地
        Dim unLoadPlace As String '目的地
        Dim unLoad_Place As String  '卸货地点
        Dim PackType As String '包装
        Dim Volume As String '体积
        Dim GoodsName As String '货物名称
        Dim PackNum As String '件数
        Dim GrossWeight As String '重量
        Dim ConNum As String '提单箱数
        Dim OwnerName As String '货主名称


        Dim BLNO_Con As String '箱提单号
        Dim Conta_No As String '箱号
        Dim CONTA_SIZE As String '箱尺寸
        Dim SEAL_NO As String '铅封
        Dim CONTA_TYPE As String '箱型
        Dim CONTA_WT As String '总重量

        txtLine = Trim(sr.ReadLine()) '按行方式读取一行
        i = i + 1
        InOutMark = Mid(txtLine, 7, 1).ToUpper()  '进出口标志
        txtLine = Trim(sr.ReadLine()) '按行方式读取一行
        i = i + 1
        '********************提单
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
                'MsgBox("已存在此提单信息 提单号为 " & BLNO)
            End If
            ds.Dispose()
            dw.Dispose()
            sqlda.Dispose()
            '****************
            txtLine = Trim(sr.ReadLine()) '按行方式读取一行
            i = i + 1
            s = Mid(txtLine, 5, 1).ToUpper()
        End While
        '***********箱子
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

            '*****************写入箱信息(箱规范)
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

            '*********************写入舱单箱信息
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
            '*********************写入舱单拼箱信息
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
            txtLine = Trim(sr.ReadLine()) '按行方式读取一行
            If txtLine = Nothing Then
                sr.Close()
                MsgBox("报文已读完!")
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
        Dim sr As New StreamReader(txtFile.Text) '打开报文文件
        Dim txtLine As String
        Dim i As Integer = 0 '记录行数
        Dim j As Integer = 0 '取箱信息循环
        Dim j1 As Integer = 0
        Dim i99 As Integer '判断结束
        Dim str As String
        Dim s As String
        Dim sqlstr As String
        Dim Mark As Integer = 0 '**********标识某行是否处理完 1表示处理完 0表示未处理完
        Dim Nation As String = "" '国籍
        Dim ShipName As String = "" '船名
        Dim ShipCode As String = "" '船名码
        Dim Voyage As String = "" '航次
        Dim ShipLineCode As String = "" '船公司代码
        Dim ShipLine As String = "" '船公司

        Dim BLNO As String = "" '提单号
        Dim Pre_ShipCode As String = "" '前程运输船名代码
        Dim Pre_ShipName As String = "" '前程运输船名
        Dim Pre_Voyage As String = "" '前程运输航次
        Dim DeliveryPlaceCode As String = "" '交货地代码
        Dim DeliveryPlace As String = "" '交货地
        Dim LoadPortCode As String = "" '装货港代码
        Dim LoadPort As String = "" '装货港
        Dim DeliveryTerm As String = "" '交货条款
        Dim PrePaid As String = "" '付款方式
        Dim LoadDate As String = "" '装货日期
        Dim CMark As String = "" '提单整拼箱标志
        Dim unLoadPortCode As String = "" '卸货港代码
        Dim unLoadPort As String = "" '卸货港
        Dim CargoCode As String = "" '货类代码
        Dim Amount As String = "" '件数
        Dim CodePack As String = "" '包装代码
        Dim Pack As String = "" '包装描述
        Dim GrossWeight As String = "" '毛重
        Dim NetWeight As String = "" '净重
        Dim Size_Measure = "" '体积

        Dim DangerousClass As String = "" '危险品分类
        Dim DangerousPage As String = "" '危险品页号
        Dim DangerousUNNO As String = "" '联合国危险品编号
        Dim DangerousLabel As String = "" '危险品标签
        Dim ConTempUnit As String = "" '温度计量单位
        Dim ConTempSet As String = "" '设置温度
        Dim ConTempMax As String = "" '冷藏最高温度
        Dim ConTempMin As String = "" '冷藏最低温度

        Dim BMark As String = "" '标志

        Dim CargoDescr As String = "" '货物描述

        Dim ConNo As String = "" '箱号
        Dim SealNo As String = "" '铅封号
        Dim ConType As String = "" '箱尺寸类型
        Dim ConStatus As String = "" '箱状态

        Dim ConGrossWeight As String = "" '箱毛重
        Dim ConTareWeight As String = "" '箱皮重
        Dim ConAmount As String = "" '箱内件数
        Dim ConMeasure As String = "" '箱内体积
        Dim ConOverFront As String = "" '前超
        Dim ConOverBack As String = "" '后超
        Dim ConOverLeft As String = "" '左超
        Dim ConOverRight As String = "" '右超
        Dim ConOverHeight As String = "" '超高
        Dim ConBay As String = "" '箱贝位号
        Dim iii As Integer

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
                If Trim(str) <> "IFCSUM" Then                      '舱单标识
                    MsgBox("报文出错 " & str & " ,不是舱单报文,错误在" & i & "行!")
                    Exit Sub
                Else
                    str = EditFetch(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) <> "MANIFEST" Then                '舱单标识
                        'MsgBox("报文出错 " & str & " ,不是舱单报文,错误在" & i & "行!")
                        'Exit Sub
                    Else
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Trim(str) <> "9" And Trim(str) <> "2" And Trim(str) <> "3" And Trim(str) <> "4" Then                  '舱单标识
                            MsgBox("报文出错 " & str & " ,不是舱单报文,错误在" & i & "行!")
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
                    Nation = str '国籍
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
        '*****************航次信息 (开始循环)
        Do While j < 9999
            If j < 2000 Then
                PB.Value = j
            End If
            BLNO = ""  '提单号
            Pre_ShipCode = ""  '前程运输船名代码
            Pre_ShipName = ""  '前程运输船名
            Pre_Voyage = ""  '前程运输航次
            DeliveryPlaceCode = ""  '交货地代码
            DeliveryPlace = ""  '交货地
            LoadPortCode = ""  '装货港代码
            LoadPort = ""  '装货港
            DeliveryTerm = "" '交货条款
            PrePaid = "" '付款方式
            LoadDate = "" '装货日期

            unLoadPortCode = "" '卸货港代码
            unLoadPort = "" '卸货港
            CargoCode = "" '货类代码
            Amount = "" '件数
            CodePack = "" '包装代码
            Pack = ""  '包装描述
            GrossWeight = ""  '毛重
            NetWeight = ""  '净重
            Size_Measure = "" '体积

            DangerousClass = ""  '危险品分类
            DangerousPage = ""  '危险品页号
            DangerousUNNO = ""  '联合国危险品编号
            DangerousLabel = ""  '危险品标签
            ConTempUnit = ""  '温度计量单位
            ConTempSet = ""  '设置温度
            ConTempMax = ""  '冷藏最高温度
            ConTempMin = ""  '冷藏最低温度

            BMark = ""  '标志
            CMark = ""  '提单整拼箱标志
            CargoDescr = ""  '货物描述

            ConNo = ""  '箱号
            SealNo = ""  '铅封号
            ConType = ""  '箱尺寸类型
            ConStatus = ""  '箱状态

            ConGrossWeight = ""  '箱毛重
            ConTareWeight = ""  '箱皮重
            ConAmount = ""  '箱内件数
            ConMeasure = "" '箱内体积
            ConOverFront = ""  '前超
            ConOverBack = ""  '后超
            ConOverLeft = ""  '左超
            ConOverRight = "" '右超
            ConOverHeight = "" '超高
            ConBay = ""  '箱贝位号

            i99 = 0
            '*************处理记录 12 描述集装箱信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 12 描述提单信息,错误在" & i & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "12" Then
                    i99 = 1
                    str = EditFetch(txtLine)                '*******取提单号
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        BLNO = str
                    Else
                        'MsgBox("报文出错 " & str & " ,错误在" & i & "行!")
                        BLNO = ""
                    End If
                    str = EditFetch(txtLine)                '*******取前程运输船名代码
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        Pre_ShipCode = str
                    End If
                    str = EditFetch(txtLine)                '*******取前程运输船名
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        Pre_ShipName = str
                    End If
                    str = EditFetch(txtLine)                '*******取前程运输航次
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        Pre_Voyage = str
                    End If
                    str = EditFetch(txtLine)                '*******交货地代码
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
                        str = EditFetch(txtLine)                '*******交货地
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 Then
                            DeliveryPlace = str
                        End If
                    End If
                    str = EditFetch(txtLine)                '*******装货港代码
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        LoadPortCode = str
                    End If
                    str = EditFetch(txtLine)                '*******装货港
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        LoadPort = str
                    End If
                    'str = EditFetch(txtLine)                '*******交货条款
                    'txtLine = Mid(txtLine, Len(str) + 2)
                    'If Len(Trim(str)) > 0 Then
                    '    DeliveryTerm = str
                    'End If
                    'str = EditFetch(txtLine)                '*******取付款方式
                    'txtLine = Mid(txtLine, Len(str) + 2)
                    'If Len(Trim(str)) > 0 Then
                    '    If Trim(str) = "P" Or Trim(str) = "C" Or Trim(str) = "F" Then
                    '        PrePaid = str
                    '    Else
                    '        MsgBox("报文出错 取付款方式 " & str & " ,错误在" & i & "行!")
                    '        PrePaid = ""
                    '    End If
                    'Else
                    '    'MsgBox("报文出错 " & str & " ,错误在" & i & "行!")
                    '    PrePaid = ""
                    'End If
                    'str = EditFetch(txtLine)                '*******取装货日期
                    'txtLine = Mid(txtLine, Len(str) + 2)
                    'If Len(Trim(str)) > 0 And Len(Trim(str)) = 8 Then
                    '    LoadDate = str
                    'Else
                    '    MsgBox("报文出错 取装货日期 " & str & " ,错误在" & i & "行!")
                    '    LoadDate = ""
                    'End If

                    Mark = 1
                Else
                    If Mark = 1 Then
                        MsgBox("报文出错 " & str & " ,错误在" & i & "行!")
                        Exit Sub
                    End If
                End If
            End If
            '*************处理记录 13 提单地点信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 13 提单地点信息,错误在" & i & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "13" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******取卸货港代码
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        unLoadPortCode = str
                    End If
                    str = EditFetch(txtLine)                '*******取卸货港
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        unLoadPort = str
                    End If
                    str = EditFetch(txtLine)                '*******取卸交货地代码
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        DeliveryPlaceCode = str
                    End If
                    str = EditFetch(txtLine)                '*******取卸交货地
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        DeliveryPlace = str
                    End If
                Else
                    If Mark = 1 Then
                        MsgBox("报文出错 " & str & " ,错误在" & i & "行!")
                        Exit Sub
                    End If
                End If
            End If
            '*************处理记录 14 提单可选卸货港信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 14 提单信息,错误在" & i & "行!")
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
            '*************处理记录 15 提单运费信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 15 提单信息,错误在" & i & "行!")
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
            '*************处理记录 15 提单运费信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 15 提单信息,错误在" & i & "行!")
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
            '*************处理记录 15 提单运费信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 15 提单信息,错误在" & i & "行!")
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
            '*************处理记录 15 提单运费信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 15 提单信息,错误在" & i & "行!")
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
            '*************处理记录 15 提单运费信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 15 提单信息,错误在" & i & "行!")
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
            '*************处理记录 16 提单发货人信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 16 提单信息,错误在" & i & "行!")
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
            '*************处理记录 17 提单收货人信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 17 提单信息,错误在" & i & "行!")
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
            '*************处理记录 17 提单收货人信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 17 提单信息,错误在" & i & "行!")
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
            '*************处理记录 17 提单收货人信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 17 提单信息,错误在" & i & "行!")
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
            '*************处理记录 17 提单收货人信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 17 提单信息,错误在" & i & "行!")
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
            '*************处理记录 18 提单第一通知人信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 18 提单信息,错误在" & i & "行!")
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
            '*************处理记录 18 提单第一通知人信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 18 提单信息,错误在" & i & "行!")
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
            '*************处理记录 18 提单第一通知人信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 18 提单信息,错误在" & i & "行!")
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
            '*************处理记录 19 提单第二通知人信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 19 提单信息,错误在" & i & "行!")
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
            '*************处理记录 20 提单第三通知人信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 20 提单信息,错误在" & i & "行!")
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
            '*************处理记录 41 提单货物信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 41 提单信息,错误在" & i & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "41" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******取货物序号
                    txtLine = Mid(txtLine, Len(str) + 2)
                    str = EditFetch(txtLine)                '*******取货类代码
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        CargoCode = str
                    End If
                    str = EditFetch(txtLine)                '*******取件数
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        Amount = str
                    Else
                        Amount = ""
                    End If
                    str = EditFetch(txtLine)                '*******取包装代码
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        CodePack = str
                    End If
                    str = EditFetch(txtLine)                '*******取包装
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        Pack = str
                    End If
                    str = EditFetch(txtLine)                '*******取毛重
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        GrossWeight = str
                    End If
                    str = EditFetch(txtLine)                '*******取净重
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        NetWeight = str
                    End If
                    str = EditFetch(txtLine)                '*******取体积
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        Size_Measure = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************处理记录 43 提单危险品冷藏信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 43 提单信息,错误在" & i & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "43" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******取危险品分类
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        DangerousClass = str

                    End If
                    str = EditFetch(txtLine)                '*******取危险品页号
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        DangerousPage = str
                    End If
                    str = EditFetch(txtLine)                '*******取联合国危险品编号
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        DangerousUNNO = str
                    End If
                    str = EditFetch(txtLine)                '*******取危险品标签
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        DangerousLabel = str
                    End If
                    str = EditFetch(txtLine)                '*******取危险货物闪点
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******取船运危险品应急措施号
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******取医疗急救指南号
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******取应急联系
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******取温度计量单位
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        ConTempUnit = str
                        If Len(Trim(ConTempUnit)) Then
                            ConTempUnit = ""
                        End If
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
                    Else
                    Mark = 0
                End If
            End If
            '*************处理记录 44 提单Mark信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 44 提单信息,错误在" & i & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "44" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******取货物序号
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 And Len(Trim(txtLine)) = 0 Then
                        BMark = str
                    ElseIf Len(Trim(str)) > 0 Then
                    End If

                    str = EditFetch(txtLine)                '*******取唛头
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        BMark = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************处理记录 44 提单Mark信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 44 提单信息,错误在" & i & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "44" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******取货物序号
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 And Len(Trim(txtLine)) = 0 Then
                        BMark = str
                    ElseIf Len(Trim(str)) > 0 Then
                    End If

                    str = EditFetch(txtLine)                '*******取唛头
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        BMark = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************处理记录 44 提单Mark信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 44 提单信息,错误在" & i & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "44" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******取货物序号
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 And Len(Trim(txtLine)) = 0 Then
                        BMark = str
                    ElseIf Len(Trim(str)) > 0 Then
                    End If

                    str = EditFetch(txtLine)                '*******取唛头
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        BMark = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************处理记录 44 提单Mark信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 44 提单信息,错误在" & i & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "44" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******取货物序号
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 And Len(Trim(txtLine)) = 0 Then
                        BMark = str
                    ElseIf Len(Trim(str)) > 0 Then
                    End If

                    str = EditFetch(txtLine)                '*******取唛头
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        BMark = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************处理记录 44 提单Mark2信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 44 提单信息,错误在" & i & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "44" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******取货物序号
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******取唛头
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        BMark = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************处理记录 44 提单Mark3信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 44 提单信息,错误在" & i & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "44" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******取货物序号
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******取唛头
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        BMark = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************处理记录 44 提单Mark4信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 44 提单信息,错误在" & i & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "44" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******取货物序号
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******取唛头
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        BMark = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************处理记录 44 提单Mark5信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 44 提单信息,错误在" & i & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "44" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******取货物序号
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******取唛头
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        BMark = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************处理记录 47 提单货物描述信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 47 提单信息,错误在" & i & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "47" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******取货物序号
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******取货物描述
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        CargoDescr = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************处理记录 47 提单货物描述2信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 47 提单信息,错误在" & i & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "47" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******取货物序号
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******取货物描述
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        CargoDescr = str
                    End If
                Else
                    Mark = 0
                End If
            End If

            '*************处理记录 47 提单货物描述2信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 47 提单信息,错误在" & i & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "47" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******取货物序号
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******取货物描述
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        CargoDescr = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************处理记录 47 提单货物描述2信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 47 提单信息,错误在" & i & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "47" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******取货物序号
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******取货物描述
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        CargoDescr = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************处理记录 47 提单货物描述2信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 47 提单信息,错误在" & i & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "47" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******取货物序号
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******取货物描述
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        CargoDescr = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************处理记录 47 提单货物描述2信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 47 提单信息,错误在" & i & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "47" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******取货物序号
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******取货物描述
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        CargoDescr = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '*************处理记录 47 提单货物描述2信息
            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine())
                s = txtLine
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 47 提单信息,错误在" & i & "行!")
                Exit Sub
            Else
                If Mark = 1 Then i = i + 1
                str = EditFetch(txtLine)
                txtLine = Mid(txtLine, Len(str) + 2)
                If Trim(str) = "47" Then
                    i99 = 1
                    Mark = 1
                    str = EditFetch(txtLine)                '*******取货物序号
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then

                    End If
                    str = EditFetch(txtLine)                '*******取货物描述
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Len(Trim(str)) > 0 Then
                        CargoDescr = str
                    End If
                Else
                    Mark = 0
                End If
            End If
            '***************校验货信息
            If Len(Trim(BLNO)) = 0 And i99 = 1 Then
                Dim Frm As New FrmReadTemp
                G_SelectStr = "行 " & i & " 周围的提单号空错误 "
                Frm.ShowDialog()
                BLNO = Trim(G_SelectCode)


            End If

            '****************
            '*************处理记录 51 集装箱信息

            If Mark = 1 Then
                txtLine = Trim(sr.ReadLine()) '按行方式读取一行
                s = txtLine
                Mark = 0
                i = i + 1
            Else
                txtLine = s
            End If
            If txtLine = Nothing Then
                MsgBox("报文出错! 处理记录 51 集装箱信息,错误在" & i & "行!")
                Exit Sub
            Else
                j1 = 0
                Do While 1 = 1
                    ConNo = ""  '箱号
                    SealNo = ""  '铅封号
                    ConType = ""  '箱尺寸类型
                    ConStatus = ""  '箱状态

                    ConAmount = ""  '箱内件数
                    ConGrossWeight = ""  '箱内货重
                    ConTareWeight = ""  '箱皮重

                    ConMeasure = "" '箱内体积
                    ConOverFront = ""  '前超
                    ConOverBack = ""  '后超
                    ConOverLeft = ""  '左超
                    ConOverRight = "" '右超
                    ConOverHeight = "" '超高
                    ConBay = ""  '箱贝位号

                    If Mark = 1 Then
                        txtLine = Trim(sr.ReadLine()) '按行方式读取一行
                        i = i + 1
                        s = txtLine
                    End If
                    str = EditFetch(txtLine)
                    txtLine = Mid(txtLine, Len(str) + 2)
                    If Trim(str) = "51" Then
                        i99 = 1
                        Mark = 1
                        j1 = j1 + 1
                        str = EditFetch(txtLine)            '货物序号
                        txtLine = Mid(txtLine, Len(str) + 2)

                        str = EditFetch(txtLine)            '箱号
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 Then
                            ConNo = Trim(str) '箱号
                        Else
                            ConNo = ""
                        End If
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 Then
                            SealNo = str '铅封号
                        Else
                            SealNo = ""
                        End If
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 Then
                            ConType = Trim(str) '集装箱尺寸类型
                        Else
                            ConType = ""
                        End If
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 Then
                            ConStatus = str '箱状态
                            If Upper(Trim(str)) = "L" Then
                                CMark = "L"
                            End If
                        Else
                            ConStatus = ""
                        End If
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 And IsNumeric(Trim(str)) Then
                            ConAmount = str  '箱内货物件数
                        End If
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 And IsNumeric(Trim(str)) Then
                            ConGrossWeight = str '箱内货重
                        End If
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 And IsNumeric(Trim(str)) Then
                            ConTareWeight = str '箱皮重
                        End If

                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 And IsNumeric(Trim(str)) Then

                            ConMeasure = str '箱内货物尺码
                        End If
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 And IsNumeric(Trim(str)) Then
                            ConOverFront = str '前超
                        End If
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 And IsNumeric(Trim(str)) Then
                            ConOverBack = str '后超
                        End If
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 And IsNumeric(Trim(str)) Then
                            ConOverLeft = str '左超
                        End If
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 And IsNumeric(Trim(str)) Then
                            ConOverRight = str '右超
                        End If
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 And IsNumeric(Trim(str)) Then
                            ConOverHeight = str '超高
                        End If
                        str = EditFetch(txtLine)
                        txtLine = Mid(txtLine, Len(str) + 2)
                        If Len(Trim(str)) > 0 And IsNumeric(Trim(str)) Then
                            ConBay = str '贝位
                        End If
                        '*************************校验
                        If i99 = 1 Then
                            If Len(Trim(ConNo)) = 0 Then
                                Dim Frm As New FrmReadTemp
                                G_SelectStr = "报文  箱号空错误,错误在" & i & "行!"
                                Frm.ShowDialog()
                                ConNo = Trim(G_SelectCode)
                            End If
                            'If Len(Trim(ConType)) = 0 Then
                            '    Dim Frm As New FrmReadTemp
                            '    G_SelectStr = "箱 " & ConNo & " 箱型代码空错误"
                            '    Frm.ShowDialog()
                            '    ConType = Trim(G_SelectCode)
                            'End If
                            If Len(Trim(ConStatus)) = 0 Then
                                Dim Frm As New FrmReadTemp
                                G_SelectStr = "箱 " & ConNo & " 箱空重空错误"
                                Frm.ShowDialog()
                                ConStatus = Trim(G_SelectCode)
                            End If
                            'If Len(Trim(SealNo)) = 0 Then
                            '    Dim Frm As New FrmReadTemp()
                            '    G_SelectStr = "箱 " & ConNo & " 箱铅封号空错误"
                            '    Frm.ShowDialog()
                            '    SealNo = Trim(G_SelectCode)
                            'End If
                            'If Len(Trim(ConGrossWeight)) = 0 Then
                            '    Dim Frm As New FrmReadTemp
                            '    G_SelectStr = "箱 " & ConNo & "  箱箱内货重 空错误"
                            '    Frm.ShowDialog()
                            '    ConGrossWeight = Trim(G_SelectCode)
                            'End If
                            'If Len(Trim(ConAmount)) = 0 Then
                            '    Dim Frm As New FrmReadTemp
                            '    G_SelectStr = "箱 " & ConNo & " 箱内货物件数"
                            '    Frm.ShowDialog()
                            '    ConAmount = Trim(G_SelectCode)
                            'End If
                            'If Len(Trim(ConTareWeight)) = 0 Then
                            '    Dim Frm As New FrmReadTemp
                            '    G_SelectStr = "箱 " & ConNo & " 箱皮重"
                            '    Frm.ShowDialog()
                            '    ConTareWeight = Trim(G_SelectCode)
                            'End If
                            '*****************写入箱信息
                            Dim Size As String = "0"
                            Dim Type As String = "0"
                            Dim SSSS As String = "0"
                            Dim sqlstr123 As String
                            '*****************取箱型
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
                            '*****************写入箱信息(箱规范)
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

                            '*********************写入舱单箱信息
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
                            '*********************写入舱单拼箱信息
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
            '********************写入提单信息
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
                    'MsgBox("已存在此提单信息 提单号为 " & BLNO)
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
        Exit Sub
Err:
        MsgBox(Err.Description)
        Resume Next
    End Sub
    Private Sub ReadZY()
        Dim sr As New StreamReader(txtFile.Text) '打开报文文件
        Dim txtLine As String
        Dim i As Integer = 0 '记录行数
        Dim str As String

        Dim ConNo As String = "" '箱号
        Dim ConType As String = "" '箱尺寸类型
        Dim SealNo As String = "" '铅封号
        Dim Mark As String = "" '标志
        Dim ConStatus As String = "" '箱状态
        Dim ConTareWeight As String = "" '箱皮重
        Dim ConTempMax As String = "" '冷藏最高温度
        Dim ConTempMin As String = "" '冷藏最低温度
        Dim LoadPortCode As String = "LYG" '装货港代码
        Dim unLoadPortCode As String = "" '卸货港代码
        Dim DeliveryPlaceCode As String = "" '交货地代码
        Dim ConJinWeight As String = "" '净重
        Dim ConGrossWeight As String = "" '箱毛重
        Dim Amount As String = "" '件数
        Dim BLNO As String = "" '提单号
        Dim DangerousClass As String = "" '危险品分类


        '*****************集装箱信息 (开始循环)
        Do While i < 99999
            If i < 2000 Then
                PB.Value = i
            End If
            ConNo = "" '箱号
            ConType = "" '箱尺寸类型
            SealNo = "" '铅封号
            Mark = "" '标志
            ConStatus = "" '箱状态
            ConTareWeight = "0"  '箱皮重
            ConTempMax = "0"  '冷藏最高温度
            ConTempMin = "0"  '冷藏最低温度
            LoadPortCode = "LYG"  '装货港代码
            unLoadPortCode = ""  '卸货港代码
            DeliveryPlaceCode = ""  '交货地代码
            ConJinWeight = "" ' 净重
            Amount = "" '件数
            ConGrossWeight = "0"  '箱毛重
            BLNO = ""  '提单号
            DangerousClass = ""  '危险品分类


            txtLine = Trim(sr.ReadLine()) '按行方式读取一行

            If txtLine = Nothing Then
                MsgBox("读取结束，谢谢！共 " & i & " 行.")
                Exit Sub
            Else

                str = Mid(txtLine, 1, 11)              '*******取箱号

                If Len(Trim(str)) > 0 Then
                    ConNo = Trim(str)
                End If
                str = Mid(txtLine, 12, 4)              '*******取箱尺寸类型
                If Len(Trim(str)) > 0 Then
                    ConType = Trim(str)
                End If
                str = Mid(txtLine, 16, 10)              '*******取箱铅封号
                If Len(Trim(str)) > 0 Then
                    SealNo = Trim(str)
                End If
                str = Mid(txtLine, 26, 8)              '*******取提单标志
                If Len(Trim(str)) > 0 Then
                    Mark = Trim(str)
                End If
                str = Mid(txtLine, 34, 1)               '******取箱状态
                If Len(Trim(str)) > 0 Then
                    ConStatus = Trim(str)
                End If
                str = Mid(txtLine, 35, 7)               '******皮重
                If Len(Trim(str)) > 0 Then
                    ConTareWeight = Trim(str)
                End If

                str = Mid(txtLine, 42, 3)              '*******取冷藏最高温度
                If Len(Trim(str)) > 0 Then
                    If Mid(Trim(str), 3, 1) = "'" Then
                        ConTempMax = Mid(Trim(str), 1, Len(Trim(str)) - 1)
                    Else
                        ConTempMax = Trim(str)
                    End If
                End If

                str = Mid(txtLine, 51, 3)              '*******取冷藏最低温度
                If Len(Trim(str)) > 0 Then
                    If Mid(Trim(str), 3, 1) = "'" Then
                        ConTempMin = Mid(Trim(str), 1, Len(Trim(str)) - 1)
                    Else
                        ConTempMin = Trim(str)
                    End If
                End If
                str = Mid(txtLine, 58, 5)               '*******卸货港
                If Len(Trim(str)) > 0 Then
                    unLoadPortCode = FindPort(Trim(str), "COSC")

                End If

                str = Mid(txtLine, 63, 5)               '******交货港
                If Len(Trim(str)) > 0 Then
                    DeliveryPlaceCode = FindPort(Trim(str), "COSC")
                End If

                str = Mid(txtLine, 68, 6)              '*******件数
                If Len(Trim(str)) > 0 Then
                    Amount = Trim(str)
                End If


                str = Mid(txtLine, 74, 7)              '净重
                If Len(Trim(str)) > 0 Then
                    ConJinWeight = Trim(str)
                End If

                str = Mid(txtLine, 81, 16)              '*******提单号
                If Len(Trim(str)) > 0 Then
                    BLNO = Trim(str)
                End If

                str = Mid(txtLine, 97, 3)                '*******危险品分类
                If Len(Trim(str)) > 0 Then
                    DangerousClass = Trim(str)
                End If

            End If


            '*****************写入箱信息(箱规范)
            Dim Size As String = "0"
            Dim Type As String = "0"
            Dim sqlstr As String

            '*****************取箱型规范

            Size = Mid(ConType, 3, 2)
            Type = Mid(ConType, 1, 2)
            ConType = Size & Type
            '*****************写入箱信息(箱规范)
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

            '*********************写入舱单箱信息
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
            '*********************写入舱单拼箱信息
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
            '*********************写入舱单信息
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
            Dim sr As New StreamReader(filepath) '打开报文文件
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
