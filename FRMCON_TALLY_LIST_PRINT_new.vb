Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FRMCON_TALLY_LIST_PRINT_new
    Inherits System.Windows.Forms.Form

    Dim dw As New DataView
    Dim dsship As New DataSet
    Dim ds As New DataSet
    Dim ds_sub As New DataSet
    Dim totalcount As Integer
    Dim ds_clerk As New DataSet
    Dim dstmp As New DataSet
    Dim dwtmp As New DataView
    Dim t, p As Integer
    Dim str_tmp, str_print, str_dx, str_yb As String
    Dim io, bay, timefrom, timeto, jjr, yb, dx As String '进出口，贝位，开始，结束时间,jjr,yb,出舱,重装
    'Dim E20, F20, E40, F40, E45, F45, E58, F58 As String
    Dim begintime, endtime As DateTime

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
    Friend WithEvents BTPRINT As System.Windows.Forms.Button
    Friend WithEvents Combno As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Combgb As System.Windows.Forms.ComboBox
    Friend WithEvents Combtallyname As System.Windows.Forms.ComboBox
    Friend WithEvents chkyb As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkdx As System.Windows.Forms.CheckBox
    Friend WithEvents dtptime As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtend As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtbegin As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.BTPRINT = New System.Windows.Forms.Button
        Me.Combno = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Combgb = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Combtallyname = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtptime = New System.Windows.Forms.DateTimePicker
        Me.chkyb = New System.Windows.Forms.CheckBox
        Me.chkdx = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtbegin = New System.Windows.Forms.TextBox
        Me.txtend = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'BTPRINT
        '
        Me.BTPRINT.Location = New System.Drawing.Point(122, 232)
        Me.BTPRINT.Name = "BTPRINT"
        Me.BTPRINT.Size = New System.Drawing.Size(65, 24)
        Me.BTPRINT.TabIndex = 0
        Me.BTPRINT.Text = "打印"
        '
        'Combno
        '
        Me.Combno.Location = New System.Drawing.Point(186, 190)
        Me.Combno.Name = "Combno"
        Me.Combno.Size = New System.Drawing.Size(116, 20)
        Me.Combno.TabIndex = 89
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(92, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 18)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "理箱单编号："
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(206, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "取消"
        '
        'Combgb
        '
        Me.Combgb.Location = New System.Drawing.Point(182, 70)
        Me.Combgb.Name = "Combgb"
        Me.Combgb.Size = New System.Drawing.Size(116, 20)
        Me.Combgb.TabIndex = 89
        Me.Combgb.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(88, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "工班："
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Visible = False
        '
        'Combtallyname
        '
        Me.Combtallyname.Location = New System.Drawing.Point(186, 162)
        Me.Combtallyname.Name = "Combtallyname"
        Me.Combtallyname.Size = New System.Drawing.Size(116, 20)
        Me.Combtallyname.TabIndex = 89
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(92, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 18)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "理货员："
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtptime
        '
        Me.dtptime.Location = New System.Drawing.Point(108, 0)
        Me.dtptime.Name = "dtptime"
        Me.dtptime.Size = New System.Drawing.Size(116, 21)
        Me.dtptime.TabIndex = 93
        '
        'chkyb
        '
        Me.chkyb.Location = New System.Drawing.Point(184, 100)
        Me.chkyb.Name = "chkyb"
        Me.chkyb.Size = New System.Drawing.Size(56, 20)
        Me.chkyb.TabIndex = 94
        Me.chkyb.Text = "夜班"
        '
        'chkdx
        '
        Me.chkdx.Location = New System.Drawing.Point(116, 100)
        Me.chkdx.Name = "chkdx"
        Me.chkdx.Size = New System.Drawing.Size(56, 20)
        Me.chkdx.TabIndex = 94
        Me.chkdx.Text = "倒箱"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(14, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 18)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "日期："
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtbegin
        '
        Me.txtbegin.Location = New System.Drawing.Point(332, -2)
        Me.txtbegin.Name = "txtbegin"
        Me.txtbegin.Size = New System.Drawing.Size(58, 21)
        Me.txtbegin.TabIndex = 95
        Me.txtbegin.Text = "0700"
        '
        'txtend
        '
        Me.txtend.Location = New System.Drawing.Point(332, 26)
        Me.txtend.Name = "txtend"
        Me.txtend.Size = New System.Drawing.Size(58, 21)
        Me.txtend.TabIndex = 95
        Me.txtend.Text = "1800"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(238, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 18)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "开始时间："
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(238, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 18)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "结束时间："
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FRMCON_TALLY_LIST_PRINT_new
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(412, 283)
        Me.Controls.Add(Me.txtbegin)
        Me.Controls.Add(Me.chkyb)
        Me.Controls.Add(Me.dtptime)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTPRINT)
        Me.Controls.Add(Me.Combno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Combgb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Combtallyname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkdx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtend)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMCON_TALLY_LIST_PRINT_new"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "理箱单单张打印"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FRMCON_TALLY_LIST_PRINT_new_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '初始化打印标志
        ExecSql("update CON_TALLY_LIST set printout='0' WHERE SHIP_ID='" & Ship_ID & "'")

        jjr = "0"
        yb = "0"

        dx = "0"
        str_dx = " inout_mark='" & dx & "' and reload='" & dx & "' "

        '设置第一个箱作业的时间
        str_tmp = "select top 1 date from con_tally_list where ship_id='" & Ship_ID & "' order by con_tally_list "
        DBControl.Getdata(str_tmp, dstmp)
        dtptime.Value = dstmp.Tables(0).Rows(0)(0)

        p = 0
        str_yb = " and datediff(dd,date,'" & dtptime.Value & "')=0 and NIGHT_MARK='" & yb & "' "
        FillWORK_NAME()
        FillNO()
        p = 1

        dsship.Reset()
        dw = Getdata("select * from view_outhatch_sship where ship_id='" & Ship_ID & "'", dsship)
    End Sub

    Private Sub FillWORK_NAME()
        Dim sqldc As String
        Dim dvc As New DataView
        Dim dsc As New DataSet
        sqldc = "SELECT NAME, WORK_NO FROM TALLY_CLERK WHERE DEPT_CODE='" & G_DeptCode & "' and work_no in (select tally_clerk1 from con_tally_list where ship_id='" & Ship_ID & "' and team_no='" & Combgb.Text & "') order by NAME "
        Me.Combtallyname.DataSource = DBControl.Getdata(sqldc, dsc)
        Me.Combtallyname.DisplayMember = "NAME"
        Me.Combtallyname.ValueMember = "WORK_NO"
    End Sub

    Private Sub FillNO()
        Dim sqldc As String
        Dim dvc As New DataView
        Dim dsc As New DataSet
        str_print = str_dx + str_yb + " and ship_id='" & Ship_ID & "' and team_no='" & Combgb.Text & "' and tally_clerk1='" & Combtallyname.SelectedValue & "' and printout='0' order by CON_TALLY_LIST_ID "
        sqldc = "select top 30 no from con_tally_list where " + str_print
        Combno.DataSource = DBControl.Getdata(sqldc, dsc)
        Combno.DisplayMember = "no"
        Combno.ValueMember = "no"
        If dsc.Tables(0).Rows.Count > 0 Then
            BTPRINT.Enabled = True
            '
            dwtmp = Getdata("select date FROM CON_TALLY_LIST WHERE CON_TALLY_LIST_ID in (select top 1 CON_TALLY_LIST_ID from CON_TALLY_LIST where " + str_print + ")", dstmp)
            Me.dtptime.Value = System.Convert.ToDateTime(dwtmp(0)(0))
        Else
            BTPRINT.Enabled = False
        End If
    End Sub

    Private Sub BTPRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTPRINT.Click
        If Len(Trim(Combno.Text)) > 0 Then
            BTPRINT.Enabled = False
            dw = Getdata("select sum(con_total),sum(F20),sum(E20),sum(F40),sum(E40),sum(F45),sum(E45),sum(F58),sum(E58) FROM CON_TALLY_LIST WHERE CON_TALLY_LIST_ID in (select top 30 CON_TALLY_LIST_ID from CON_TALLY_LIST where " + str_print + ")", ds)
            totalcount = dw(0)(0)
            If totalcount > 0 Then
                ''进出口标志
                'dwtmp = Getdata("select inoutport from sship where ship_id='" & Ship_ID & "'", dstmp)
                'io = dwtmp(0)(0)
                print()
            End If

            FillNO()
            BTPRINT.Enabled = True
        End If
    End Sub

    Private Sub print()
        '统计该理货员本工班 作业 理箱单箱数 
        If ds.Tables(0).Rows.Count > 0 Then
            '作业起讫时间
            dwtmp = Getdata("select min(time_from) FROM CON_TALLY_LIST WHERE CON_TALLY_LIST_ID in (select top 30 CON_TALLY_LIST_ID from CON_TALLY_LIST where " + str_print + ")", dstmp)
            timefrom = dwtmp(0)(0)
            dwtmp = Getdata("select max(time_to) FROM CON_TALLY_LIST WHERE CON_TALLY_LIST_ID in (select top 30 CON_TALLY_LIST_ID from CON_TALLY_LIST where " + str_print + ")", dstmp)
            timeto = dwtmp(0)(0)
            dwtmp = Getdata("select min(date) FROM CON_TALLY_LIST WHERE CON_TALLY_LIST_ID in (select top 30 CON_TALLY_LIST_ID from CON_TALLY_LIST where " + str_print + ")", dstmp)
            begintime = System.Convert.ToDateTime(dwtmp(0)(0))
            dwtmp = Getdata("select max(date) FROM CON_TALLY_LIST WHERE CON_TALLY_LIST_ID in (select top 30 CON_TALLY_LIST_ID from CON_TALLY_LIST where " + str_print + ")", dstmp)
            endtime = System.Convert.ToDateTime(dwtmp(0)(0))
            dwtmp = Getdata("select top 1 HOLIDAY FROM CON_TALLY_LIST WHERE CON_TALLY_LIST_ID in (select top 30 CON_TALLY_LIST_ID from CON_TALLY_LIST where " + str_print + ")", dstmp)
            jjr = dwtmp(0)(0)
            dwtmp = Getdata("select distinct substring(bayno,1,2) bay from CON_TALLY_DETAIL WHERE CON_TALLY_LIST_ID in (select top 30 CON_TALLY_LIST_ID from CON_TALLY_LIST where " + str_print + ") ", dstmp)
            bay = ""
            For t = 0 To dwtmp.Count - 1
                bay = bay + "/" + dwtmp(t)(0)
            Next t

            dwtmp = Getdata("select CONTAINER_NO,SIZE_CON,FULLOREMPTY,SEALNO from CON_TALLY_DETAIL WHERE CON_TALLY_LIST_ID in (select top 30 CON_TALLY_LIST_ID from CON_TALLY_LIST where " + str_print + ")", ds_sub)

            Call eng()
            ExecSql("update CON_TALLY_LIST set printout='1' where CON_TALLY_LIST_ID in (select top 30 CON_TALLY_LIST_ID from CON_TALLY_LIST where " + str_print + ")")
        End If
    End Sub

    Private Sub eng()
        Dim xlapp As Excel.Application
        Dim xlbook As Excel.Workbook
        Dim xlsheet As Excel.Worksheet
        Dim pathstr As String
        Dim Filepath As String
        Dim col, row As Integer
        Try
            RecordExcelProcess()
            pathstr = System.Reflection.Assembly.GetExecutingAssembly.Location
            pathstr = substr(pathstr)
            'FileCopy(pathstr + "Report_gonglei.xls", pathstr + "Report.xls")
            'Filepath = pathstr + "report.xls"
            FileCopy(pathstr + "Report_gonglei.xls", pathstr + "理箱单.xls")
            Filepath = pathstr + "理箱单.xls"
            xlapp = CType(CreateObject("excel.application"), Excel.Application)
            xlbook = CType(xlapp.Workbooks.Open("" & Filepath & ""), Excel.Workbook)
            xlsheet = CType(xlbook.Worksheets("理箱单"), Excel.Worksheet)
            xlapp.DisplayAlerts = False
            If GL_Print = 1 Then
                xlsheet.Application.Visible = False
            Else
                xlsheet.Application.Visible = True
            End If
            xlsheet.Select()

            'xlsheet.Cells(9, 15) = Trim(Combno.Text)
            'xlsheet.Cells(11, 14) = ds.Tables(0).Rows(0).Item("bay")
            'xlsheet.Cells(12, 3) = ds.Tables(0).Rows(0).Item("YARD_NO")
            'xlsheet.Cells(12, 7) = Mid(IIf(Len(Trim(ds.Tables(0).Rows(0).Item("time_from"))) = 4, Trim(ds.Tables(0).Rows(0).Item("time_from")), "    "), 1, 2) + "：" + Mid(IIf(Len(Trim(ds.Tables(0).Rows(0).Item("time_from"))) = 4, Trim(ds.Tables(0).Rows(0).Item("time_from")), "    "), 3, 2)
            'xlsheet.Cells(12, 11) = Mid(IIf(Len(Trim(ds.Tables(0).Rows(0).Item("time_to"))) = 4, Trim(ds.Tables(0).Rows(0).Item("time_to")), "    "), 1, 2) + "：" + Mid(IIf(Len(Trim(ds.Tables(0).Rows(0).Item("time_to"))) = 4, Trim(ds.Tables(0).Rows(0).Item("time_to")), "    "), 3, 2)
            'xlsheet.Cells(12, 13) = CType(Month(ds.Tables(0).Rows(0).Item("date")), String) + "-" + CType(Day(ds.Tables(0).Rows(0).Item("date")), String)
            'xlsheet.Cells(12, 16) = Mid(IIf(Len(Year(ds.Tables(0).Rows(0).Item("DATE"))) = 4, Year(ds.Tables(0).Rows(0).Item("DATE")), "    "), 3, 2)

            'If io = 0 Then
            '    xlsheet.Cells(9, 3) = "Inward"
            'Else
            '    xlsheet.Cells(9, 3) = "Outward"
            'End If

            xlsheet.Cells(11, 2) = "'" & IIf(IsDBNull(Trim(dsship.Tables(0).Rows(0).Item("ENG_VESSEL"))), "", Trim(dsship.Tables(0).Rows(0).Item("ENG_VESSEL")))
            xlsheet.Cells(11, 5) = "'" & IIf(IsDBNull(Trim(dsship.Tables(0).Rows(0).Item("Voyage"))), "", Trim(dsship.Tables(0).Rows(0).Item("Voyage")))
            xlsheet.Cells(11, 9) = "No." & IIf(IsDBNull(Trim(dsship.Tables(0).Rows(0).Item("berthno"))), "", Trim(dsship.Tables(0).Rows(0).Item("berthno")))
            xlsheet.Cells(11, 13) = "'" & bay.Substring(1)
            xlsheet.Cells(12, 7) = "'" & Mid(timefrom, 1, 2) & ":" & Mid(timefrom, 3, 2)
            xlsheet.Cells(12, 11) = "'" & Mid(timeto, 1, 2) & ":" & Mid(timeto, 3, 2)
            If Month(begintime) = Month(endtime) Then
                If Day(begintime) = Day(endtime) Then
                    xlsheet.Cells(12, 13) = "'" & System.Convert.ToString(Day(begintime)).PadLeft(2, "0") & "-" & System.Convert.ToString(Month(begintime)).PadLeft(2, "0")
                Else
                    xlsheet.Cells(12, 13) = "'" & System.Convert.ToString(Day(begintime)).PadLeft(2, "0") & "/" & System.Convert.ToString(Day(endtime)).PadLeft(2, "0") & "-" & System.Convert.ToString(Month(begintime)).PadLeft(2, "0")
                End If
            Else
                If Day(begintime) = Day(endtime) Then
                    xlsheet.Cells(12, 13) = "'" & System.Convert.ToString(Day(begintime)).PadLeft(2, "0") & "-" & System.Convert.ToString(Month(begintime)).PadLeft(2, "0") & "/" & System.Convert.ToString(Month(endtime)).PadLeft(2, "0")
                Else
                    xlsheet.Cells(12, 13) = "'" & System.Convert.ToString(Day(begintime)).PadLeft(2, "0") & "/" & System.Convert.ToString(Day(endtime)).PadLeft(2, "0") & "-" & System.Convert.ToString(Month(begintime)).PadLeft(2, "0") & "/" & System.Convert.ToString(Month(endtime)).PadLeft(2, "0")
                End If
            End If
            If Year(begintime) = Year(endtime) Then
                xlsheet.Cells(12, 15) = "-" & Year(begintime)
            Else
                xlsheet.Cells(12, 15) = "-" & Year(begintime) & "/" & Year(endtime)
            End If

            If totalcount <= 15 Then
                For row = 0 To totalcount - 1
                    xlsheet.Cells(16 + row, 1) = ds_sub.Tables(0).Rows(row)("CONTAINER_NO")
                    xlsheet.Cells(16 + row, 3) = ds_sub.Tables(0).Rows(row)("SEALNO")
                    xlsheet.Cells(16 + row, 4) = ds_sub.Tables(0).Rows(row)("SIZE_CON")
                    xlsheet.Cells(16 + row, 5) = ds_sub.Tables(0).Rows(row)("FULLOREMPTY")
                    If ds_sub.Tables(0).Rows(row)("FULLOREMPTY") = "E" Then
                        xlsheet.Cells(16 + row, 3) = "────"
                    Else
                        xlsheet.Cells(16 + row, 3) = "OK"
                    End If
                Next row
            ElseIf totalcount > 15 And totalcount <= 30 Then
                For row = 0 To 14
                    xlsheet.Cells(16 + row, 1) = ds_sub.Tables(0).Rows(row)("CONTAINER_NO")
                    xlsheet.Cells(16 + row, 3) = ds_sub.Tables(0).Rows(row)("SEALNO")
                    xlsheet.Cells(16 + row, 4) = ds_sub.Tables(0).Rows(row)("SIZE_CON")
                    xlsheet.Cells(16 + row, 5) = ds_sub.Tables(0).Rows(row)("FULLOREMPTY")
                    If ds_sub.Tables(0).Rows(row)("FULLOREMPTY") = "E" Then
                        xlsheet.Cells(16 + row, 3) = "────"
                    Else
                        xlsheet.Cells(16 + row, 3) = "OK"
                    End If
                Next row
                For row = 15 To totalcount - 1
                    xlsheet.Cells(1 + row, 7) = ds_sub.Tables(0).Rows(row)("CONTAINER_NO")
                    xlsheet.Cells(1 + row, 11) = ds_sub.Tables(0).Rows(row)("SEALNO")
                    xlsheet.Cells(1 + row, 13) = ds_sub.Tables(0).Rows(row)("SIZE_CON")
                    xlsheet.Cells(1 + row, 15) = ds_sub.Tables(0).Rows(row)("FULLOREMPTY")
                    If ds_sub.Tables(0).Rows(row)("FULLOREMPTY") = "E" Then
                        xlsheet.Cells(1 + row, 11) = "────"
                    Else
                        xlsheet.Cells(1 + row, 11) = "OK"
                    End If
                Next row
            End If
            If jjr = "1" Then
                xlsheet.Cells(32, 4) = "√"
            End If
            If yb = "1" Then
                xlsheet.Cells(33, 4) = "√"
            End If
            If dx = "1" Then
                xlsheet.Cells(34, 6) = "√"
            End If
            xlsheet.Cells(32, 12) = dw(0)(1) 'ds.Tables(0).Rows(0).Item("F20")
            xlsheet.Cells(33, 12) = dw(0)(3) 'ds.Tables(0).Rows(0).Item("F40")
            xlsheet.Cells(34, 12) = dw(0)(5) 'ds.Tables(0).Rows(0).Item("F45")

            xlsheet.Cells(32, 15) = dw(0)(2) 'ds.Tables(0).Rows(0).Item("E20")
            xlsheet.Cells(33, 15) = dw(0)(4) 'ds.Tables(0).Rows(0).Item("E40")
            xlsheet.Cells(34, 15) = dw(0)(6) 'ds.Tables(0).Rows(0).Item("E45")
            xlsheet.Cells(35, 12) = dw(0)(7) + dw(0)(8) 'ds.Tables(0).Rows(0).Item("E58") + ds.Tables(0).Rows(0).Item("F58")
            xlsheet.Cells(31, 12) = dw(0)(0)
            'xlsheet.Cells(35, 15) = dw(0)(0) ' totalcount
            'xlsheet.Cells(38, 3) = Combtallyname.Text
            'xlsheet.Cells(38, 3) = ds_clerk.Tables(0).Rows(0).Item("clerk1") + ds_clerk.Tables(0).Rows(0).Item("clerk1") + ds_clerk.Tables(0).Rows(0).Item("clerk1")
            'xlsheet.Cells(38, 12) = ds.Tables(0).Rows(0).Item("CROSS_PERSON")
            'xlsheet.PrintPreview()
            If GL_Print = 1 Then
                xlsheet.PrintOut()
                KillExcelProcess()
                'GL_Print = 0
            End If
        Catch
            xlapp.Quit()
            SendKeys.Send("n")
            KillExcelProcess()
        End Try
    End Sub

    Private Sub BTPRINT_Click1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Len(Trim(Combno.Text)) > 0 Then
        '    dw = Getdata("select CON_TALLY_LIST_ID,date,time_from,time_to,BerthNO,YARD_NO,BAY,NIGHT_MARK,HOLIDAY,INOUT_MARK,RELOAD,ANCHORAGE_REMARK,E20,F20,E40,F40,E45,F45,E58,F58,CON_TOTAL,TEU,Tally_Clerk1,Tally_Clerk2,Tally_Clerk3,CROSS_PERSON FROM CON_TALLY_LIST WHERE SHIP_ID='" & Ship_ID & "' AND NO='" & Combno.Text & "'", ds)
        '    If ds.Tables(0).Rows.Count > 0 Then
        '        totalcount = ds.Tables(0).Rows(0).Item("con_total")
        '        If totalcount > 0 Then
        '            If totalcount > 30 Then
        '                MsgBox("该理箱单箱数超过30，请检查！")
        '                Exit Sub
        '            Else
        '                dw = Getdata("SELECT dbo.CON_TALLY_LIST.CON_TALLY_LIST_ID, ISNULL(TALLY_CLERK_1.NAME, '') AS CLERK1,ISNULL(TALLY_CLERK_2.NAME, '') AS CLERK2,ISNULL(TALLY_CLERK_3.NAME, '') AS CLERK3 FROM dbo.TALLY_CLERK TALLY_CLERK_3 RIGHT OUTER JOIN dbo.CON_TALLY_LIST ON TALLY_CLERK_3.WORK_NO = dbo.CON_TALLY_LIST.Tally_Clerk3 LEFT OUTER JOIN dbo.TALLY_CLERK TALLY_CLERK_2 ON dbo.CON_TALLY_LIST.Tally_Clerk2 = TALLY_CLERK_2.WORK_NO LEFT OUTER JOIN dbo.TALLY_CLERK TALLY_CLERK_1 ON dbo.CON_TALLY_LIST.Tally_Clerk1 = TALLY_CLERK_1.WORK_NO WHERE dbo.CON_TALLY_LIST.CON_TALLY_LIST_ID='" & ds.Tables(0).Rows(0).Item("CON_TALLY_LIST_ID") & "'", ds_clerk)
        '                dw = Getdata("select CONTAINER_NO,SIZE_CON,FULLOREMPTY,SEALNO from CON_TALLY_DETAIL WHERE CON_TALLY_LIST_ID='" & ds.Tables(0).Rows(0).Item("CON_TALLY_LIST_ID") & "' ", ds_sub)
        '                If RBchina.Checked = True Then
        '                    Call china()
        '                Else
        '                    Call eng()
        '                End If
        '            End If
        '        Else
        '            MsgBox("该理箱单箱数为0，请检查！")
        '            Exit Sub
        '        End If

        '    Else
        '        MsgBox("无该理箱单信息！")
        '        Exit Sub
        '    End If
        'Else
        '    MsgBox("请选择理箱单！")
        '    Exit Sub
        'End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Combtallyname_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combtallyname.SelectedIndexChanged
        If p = 1 Then
            FillNO()
        End If
    End Sub

    Private Sub Combgb_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combgb.SelectedIndexChanged
        If p = 1 Then
            FillWORK_NAME()
        End If
    End Sub

    Private Sub chkyb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkyb.CheckedChanged
        If chkyb.Checked = True Then
            txtbegin.Text = "1800"
            txtend.Text = "0700"

        Else
            txtbegin.Text = "0700"
            txtend.Text = "1800"

        End If
    End Sub

    Private Sub chkdx_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkdx.CheckedChanged
        If chkdx.Checked = True Then
            dx = "1"
            str_dx = " (inout_mark='" & dx & "' or reload='" & dx & "') "
        Else
            dx = "0"
            str_dx = " inout_mark='" & dx & "' and reload='" & dx & "' "
        End If
        FillNO()
    End Sub

    Private Sub rb_check()
        str_yb = " and datediff(dd,date,'" & dtptime.Value & "')>=0 and NIGHT_MARK='" & yb & "'"

        str_yb = " and datediff(dd,date,'" & dtptime.Value & "')=1 and NIGHT_MARK='" & yb & "'"

        FillNO()
    End Sub

    Private Sub txtbegin_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbegin.Leave
        If Len(Trim(txtbegin.Text)) = 4 Then
            If CType(Mid(Trim(txtbegin.Text), 1, 2), Integer) < 24 And CType(Mid(Trim(txtbegin.Text), 3, 2), Integer) < 60 Then

            Else
                MsgBox("开始时间输入有误！")
                txtbegin.Focus()
            End If
        Else
            MsgBox("开始时间长度有误！")
            txtbegin.Focus()
        End If
    End Sub

    Private Sub txtend_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtend.Leave
        If Len(Trim(txtend.Text)) = 4 Then
            If CType(Mid(Trim(txtend.Text), 1, 2), Integer) < 24 And CType(Mid(Trim(txtend.Text), 3, 2), Integer) < 60 Then

            Else
                MsgBox("结束时间输入有误！")
                txtend.Focus()
            End If
        Else
            MsgBox("结束时间长度有误！")
            txtend.Focus()
        End If
    End Sub
End Class
