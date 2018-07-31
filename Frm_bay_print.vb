Imports TALLY.DBControl
Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.Math
Imports System.Drawing.Printing
Public Class Frm_bay_print
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
    Friend WithEvents cmb_defined_bay As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_enter As System.Windows.Forms.Button
    Friend WithEvents btn_cancle As System.Windows.Forms.Button
    Friend WithEvents Pl_bay_map As System.Windows.Forms.Panel
    Friend WithEvents btn_pagesetup As System.Windows.Forms.Button
    Friend WithEvents btn_printpreview As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_scale_rate As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmb_defined_bay = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_enter = New System.Windows.Forms.Button
        Me.btn_cancle = New System.Windows.Forms.Button
        Me.Pl_bay_map = New System.Windows.Forms.Panel
        Me.btn_pagesetup = New System.Windows.Forms.Button
        Me.btn_printpreview = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_scale_rate = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cmb_defined_bay
        '
        Me.cmb_defined_bay.Location = New System.Drawing.Point(277, 18)
        Me.cmb_defined_bay.Name = "cmb_defined_bay"
        Me.cmb_defined_bay.Size = New System.Drawing.Size(68, 20)
        Me.cmb_defined_bay.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(230, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BAY"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_enter
        '
        Me.btn_enter.Location = New System.Drawing.Point(506, 16)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(64, 24)
        Me.btn_enter.TabIndex = 2
        Me.btn_enter.Text = "打印"
        '
        'btn_cancle
        '
        Me.btn_cancle.Location = New System.Drawing.Point(581, 16)
        Me.btn_cancle.Name = "btn_cancle"
        Me.btn_cancle.Size = New System.Drawing.Size(64, 24)
        Me.btn_cancle.TabIndex = 2
        Me.btn_cancle.Text = "取消"
        '
        'Pl_bay_map
        '
        Me.Pl_bay_map.AutoScroll = True
        Me.Pl_bay_map.AutoScrollMinSize = New System.Drawing.Size(400, 900)
        Me.Pl_bay_map.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pl_bay_map.Location = New System.Drawing.Point(0, 40)
        Me.Pl_bay_map.Name = "Pl_bay_map"
        Me.Pl_bay_map.Size = New System.Drawing.Size(780, 1200)
        Me.Pl_bay_map.TabIndex = 4
        '
        'btn_pagesetup
        '
        Me.btn_pagesetup.Location = New System.Drawing.Point(356, 16)
        Me.btn_pagesetup.Name = "btn_pagesetup"
        Me.btn_pagesetup.Size = New System.Drawing.Size(64, 24)
        Me.btn_pagesetup.TabIndex = 5
        Me.btn_pagesetup.Text = "页面设置"
        '
        'btn_printpreview
        '
        Me.btn_printpreview.Location = New System.Drawing.Point(431, 16)
        Me.btn_printpreview.Name = "btn_printpreview"
        Me.btn_printpreview.Size = New System.Drawing.Size(64, 24)
        Me.btn_printpreview.TabIndex = 6
        Me.btn_printpreview.Text = "打印预揽"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(135, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "缩放"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_scale_rate
        '
        Me.txt_scale_rate.Location = New System.Drawing.Point(175, 18)
        Me.txt_scale_rate.Name = "txt_scale_rate"
        Me.txt_scale_rate.Size = New System.Drawing.Size(34, 21)
        Me.txt_scale_rate.TabIndex = 8
        Me.txt_scale_rate.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(209, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "%"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Frm_bay_print
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(780, 755)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_scale_rate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_printpreview)
        Me.Controls.Add(Me.btn_pagesetup)
        Me.Controls.Add(Me.Pl_bay_map)
        Me.Controls.Add(Me.btn_enter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_defined_bay)
        Me.Controls.Add(Me.btn_cancle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Frm_bay_print"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "单贝图打印"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ds_defined_bay As New DataSet()
    Dim storedpagesettings As PageSettings
    '船信息
    Dim v_id As Integer
    Dim ENG_VESSEL As String
    Dim CHI_VESSEL As String
    Dim VOYAGE As String
    Dim ds_exist_bay As New DataSet()
    Dim ds_ship As New DataSet()
    Dim i, j, n, k As Integer
    Dim col_count As Integer
    Dim bmp_bay_map As Bitmap
    Dim bmpgraphics_bay_map As Graphics
    Dim pen_line As New Pen(Color.Black, 1)
    Dim print_result As New PrintDocument()
    Dim distolefe As Integer = 0 '距左边距移动的位移
    Dim distotop As Integer = 10 '最上面一行写BAY
    Dim xChange As Integer = 40 '横坐标便宜距离
    Const yRect As Integer = 56 '举行的高度
    Dim ff As New FontFamily("Arial")
    Dim f As New Font(ff, 6)
    Dim f_container As New Font(ff, 10) ' 8.3
    Dim bay_f As New Font(ff, 10, FontStyle.Bold)
    '甲板
    Dim ds_board_char As New DataSet()
    Dim small_row As Integer
    Dim small_col As Integer
    Dim big_row As Integer
    Dim big_col As Integer
    Dim ds_board As New DataSet()
    Dim bay_row As String
    Dim bay_col As String
    Dim ds_unuse_col As New DataSet()
    Dim board_height As Integer = 0 '甲板的高度
    '舱内
    Dim ds_cabin As New DataSet()
    Dim ds_cabin_char As New DataSet()
    Dim small_row_cabin As Integer
    Dim small_col_cabin As Integer
    Dim big_row_cabin As Integer
    Dim big_col_cabin As Integer
    Dim bay_row_cabin As String
    Dim bay_col_cabin As String
    '   Dim storepagesettings As New PageSettings()
    Dim ptdlg As PrintDialog

    Private Sub Frm_bay_print_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        bmp_bay_map = New Bitmap(Me.Pl_bay_map.Width, Me.Pl_bay_map.Height)
        bmpgraphics_bay_map = Graphics.FromImage(bmp_bay_map)
        Me.Pl_bay_map.BackgroundImage = bmp_bay_map
        pen_line.DashStyle = DashStyle.Solid
        '写船名
        If Getdata("select VESSEL_ID,VESSEL.ENG_VESSEL,VESSEL.CHI_VESSEL, sship.VOYAGE from VESSEL,sship where sship.ship_id=" & Ship_ID & " and sship.v_id=VESSEL.VESSEL_id", ds_ship).Count > 0 Then
            v_id = ds_ship.Tables(0).Rows(0).Item("VESSEL_id")
            ENG_VESSEL = ds_ship.Tables(0).Rows(0).Item("ENG_VESSEL")
            CHI_VESSEL = ds_ship.Tables(0).Rows(0).Item("CHI_VESSEL")
            VOYAGE = ds_ship.Tables(0).Rows(0).Item("VOYAGE")
            '写连云港外理
            bmpgraphics_bay_map.DrawString("COSTACO LIANYUNGANG  连云港外理", Me.Font, Brushes.Black, distolefe + 0, distotop - 10)
            '写船名航次
            bmpgraphics_bay_map.DrawString("VESSEL:" & ENG_VESSEL, Me.Font, Brushes.Black, distolefe + 40 + 190, distotop - 10)
            bmpgraphics_bay_map.DrawString("VOY:" & VOYAGE, Me.Font, Brushes.Black, distolefe + 40 + 320, distotop - 10)
            bmpgraphics_bay_map.DrawString("POL：LYG", Me.Font, Brushes.Black, distolefe + 40 + 420, distotop - 10)
            '写BAY
            bmpgraphics_bay_map.DrawString("BAY： " & Me.cmb_defined_bay.Text, bay_f, Brushes.Black, distolefe + 40 + 20 + 500, distotop - 10)
            Me.Pl_bay_map.Refresh()
            '写已存在的贝列
            If Getdata("select  bay_num from con_map,sship where sship.ship_id='" & Ship_ID & "' and sship.v_id=con_map.v_id group by bay_num order by bay_num", ds_exist_bay).Count > 0 Then
                For i = 0 To ds_exist_bay.Tables(0).Rows.Count - 1
                    Me.cmb_defined_bay.Items.Add(ds_exist_bay.Tables(0).Rows(i).Item("bay_num"))
                Next
            End If

        End If
    End Sub

    Private Sub cmb_defined_bay_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_defined_bay.TextChanged
        show_bay_map(bmpgraphics_bay_map)
    End Sub

    Private Sub print_bay_map(ByVal bmpgraphics_bay_map As Graphics) '现实
        'Me.Pl_bay_map.Height = 1200
        '清空
        bmpgraphics_bay_map.Clear(Color.White)
        small_col = 0
        big_col = 0
        small_col_cabin = 0
        big_col_cabin = 0
        '''计算甲板的高度
        board_height = 0
        ''甲板取甲板的列数
        If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "' and location='board' order by id", ds_board).Count > 0 Then
            Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "' and location='board'", ds_board_char)
            small_row = ds_board_char.Tables(0).Rows(0).Item("small_row") '取甲板屏幕的最小行
            big_row = ds_board_char.Tables(0).Rows(0).Item("big_row") '取甲板屏幕的最大行
            small_col = ds_board_char.Tables(0).Rows(0).Item("small_col") '取甲板屏幕的最小列
            big_col = ds_board_char.Tables(0).Rows(0).Item("big_col") '取甲板屏幕的最大列
            '''计算甲板的高度
            board_height = (big_row - small_row + 1) * yRect
        End If
        '取舱内的列数
        If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "' and location='cabin' order by id", ds_cabin).Count > 0 Then
            Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "' and location='cabin'", ds_cabin_char)
            small_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_col") '取舱内屏幕的最小列
            big_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_col") '取舱内屏幕的最大列
            small_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_row") '取舱内屏幕的最小行
            big_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_row") '取舱内屏幕的最大行
        End If
        '写连云港外理
        bmpgraphics_bay_map.DrawString("COSTACO LIANYUNGANG  连云港外理", Me.Font, Brushes.Black, distolefe + 0, distotop - 10)
        '写船名航次
        bmpgraphics_bay_map.DrawString("VESSEL:" & ENG_VESSEL, Me.Font, Brushes.Black, distolefe + 40 + 190, distotop - 10)
        bmpgraphics_bay_map.DrawString("VOY:" & VOYAGE, Me.Font, Brushes.Black, distolefe + 40 + 450, distotop - 10)
        bmpgraphics_bay_map.DrawString("POL：LYG", Me.Font, Brushes.Black, distolefe + 40 + 600, distotop - 10)
        '写BAY
        bmpgraphics_bay_map.DrawString("BAY： " & Me.cmb_defined_bay.Text, bay_f, Brushes.Black, distolefe + 40 + 20 + 750, distotop - 10)
        '甲板开始
        If ds_board.Tables(0).Rows.Count > 0 Then
            '计算甲板结果图的顶点位置
            If (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) >= 0 Then '比较甲板和舱内的列数
                col_count = (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) ''甲板上列数和舱内的差额
            Else
                col_count = 0
            End If
            ''画甲板矩形
            For i = small_row To big_row
                For j = small_col To big_col
                    If ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("user_char") = 1 Then
                        ' bmpgraphics_bay_map.DrawRectangle(pen_line, distolefe + col_count * 20 + 40 * (j - small_col + 1), distotop + board_height + 40 - 40 * (i - small_row + 1) + 40, 40, 40)
                        '矩形
                        bmpgraphics_bay_map.DrawRectangle(pen_line, distolefe + col_count * 40 + 80 * (j - small_col + 1) - xChange, distotop + board_height - yRect * (i - small_row + 1) + CInt(yRect / 2), 80, yRect)
                        bmpgraphics_bay_map.DrawString(ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_col") & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_row"), f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col + 1), distotop + board_height - yRect * (i - small_row + 1) + CInt(yRect / 2) + yRect - 16)
                        bmpgraphics_bay_map.DrawRectangle(pen_line, distolefe - xChange + col_count * 40 + 80 * (j - small_col + 1), distotop + board_height - yRect * (i - small_row + 1) + CInt(yRect / 2) + yRect - 16, 50, 16)
                    End If
                Next
            Next
            '画贝层
            For i = small_row To big_row '战位最大屏列,按行读，行坐标先变
                bay_row = 78 + i * 2
                bmpgraphics_bay_map.DrawString(bay_row, Me.Font, Brushes.Black, distolefe + 10, distotop + board_height - yRect * (i - small_row + 1) + yRect) '贝层
            Next
            ''写贝列
            n = big_col - small_col + 1
            'bay_row = 78 + i * 2
            Dim strcon As Integer
            strcon = 1
            Dim strsmallcol As Integer
            strsmallcol = small_col
            Dim strbigcol As Integer
            strbigcol = big_col
            If Getdata("select * from con_bay where  v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "'", ds_unuse_col).Count > 0 Then
                If ds_unuse_col.Tables(0).Rows(0).Item("board_unuse_col") Is System.DBNull.Value Then

                Else
                    If ds_unuse_col.Tables(0).Rows(0).Item("board_unuse_col") = "右边" Then
                        strbigcol = strbigcol - 1
                    Else
                        If ds_unuse_col.Tables(0).Rows(0).Item("board_unuse_col") = "左边" Then
                            strsmallcol = strsmallcol + 1
                            strcon = 2
                        End If
                    End If
                End If
            End If
            For j = strsmallcol To strbigcol   '战位最大屏列
                If n Mod 2 = 0 Then
                    k = small_col + Fix(n / 2) - j
                    If k > 0 Then
                        If k < 5 Then
                            bay_col = "0" & k * 2
                        Else
                            bay_col = k * 2
                        End If
                    Else
                        If Abs(k) * 2 + 1 < 10 Then
                            bay_col = "0" & Abs(k) * 2 + 1
                        Else
                            bay_col = Abs(k) * 2 + 1
                        End If
                    End If
                Else
                    k = small_col + Fix(n / 2) - j
                    If k = 0 Then
                        bay_col = "00"
                    Else
                        If k > 0 Then
                            If k * 2 < 10 Then
                                bay_col = "0" & k * 2
                            Else
                                bay_col = k * 2
                            End If
                        Else
                            If Abs(k) * 2 - 1 < 10 Then
                                bay_col = "0" & Abs(k) * 2 - 1
                            Else
                                bay_col = Abs(k) * 2 - 1
                            End If
                        End If
                    End If
                End If
                bmpgraphics_bay_map.DrawString(bay_col, Me.Font, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - strsmallcol + strcon) + 30, distotop + board_height + 15 - (big_row - small_row + 1) * yRect)   '贝列
            Next
        End If '甲板结束
        ''舱内开始
        If ds_cabin.Tables(0).Rows.Count > 0 Then
            '计算舱内结果图的顶点位置
            If (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) >= 0 Then
                col_count = (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) ''甲板上列数和舱内的差额
            Else
                col_count = 0
            End If
            ''画舱内矩形
            For i = small_row_cabin To big_row_cabin
                For j = small_col_cabin To big_col_cabin
                    If ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("user_char") = 1 Then
                        bmpgraphics_bay_map.DrawRectangle(pen_line, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1), distotop + board_height + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2), 80, yRect)
                        bmpgraphics_bay_map.DrawString(ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_col") & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_row"), f_container, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1), distotop + board_height + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) + yRect - 16)
                        bmpgraphics_bay_map.DrawRectangle(pen_line, distolefe - xChange + col_count * 40 + 80 * (j - small_col_cabin + 1), distotop + board_height + 20 + (big_row_cabin - small_row_cabin + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) + yRect - 16, 50, 16)
                    End If
                Next
            Next
            '画贝层
            For i = small_row_cabin To big_row_cabin '战位最大屏列,按行读，行坐标先变
                If i * 2 < 10 Then
                    bay_row_cabin = "0" & i * 2
                Else
                    bay_row_cabin = i * 2
                End If
                bmpgraphics_bay_map.DrawString(bay_row_cabin, Me.Font, Brushes.Black, distolefe + 10, distotop + board_height + (big_row_cabin - small_row_cabin + 1 + 1) * yRect - yRect * (i - small_row_cabin + 1) + CInt(yRect / 2) - 10) '贝层
            Next
            ''写贝列
            n = big_col_cabin - small_col_cabin + 1
            'bay_row_cabin = 78 + i * 2
            Dim strcon As Integer
            strcon = 1
            Dim strsmallcol As Integer
            strsmallcol = small_col_cabin
            Dim strbigcol As Integer
            strbigcol = big_col_cabin
            If Getdata("select * from con_bay where  v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "'", ds_unuse_col).Count > 0 Then
                If ds_unuse_col.Tables(0).Rows(0).Item("cabin_unuse_col") Is System.DBNull.Value Then

                Else
                    If ds_unuse_col.Tables(0).Rows(0).Item("cabin_unuse_col") = "右边" Then
                        strbigcol = strbigcol - 1
                    Else
                        If ds_unuse_col.Tables(0).Rows(0).Item("cabin_unuse_col") = "左边" Then
                            strsmallcol = strsmallcol + 1
                            strcon = 2
                        End If
                    End If
                End If
            End If
            For j = strsmallcol To strbigcol   '战位最大屏列
                'For j = small_col_cabin To big_col_cabin '战位最大屏列
                If n Mod 2 = 0 Then
                    k = small_col_cabin + Fix(n / 2) - j
                    If k > 0 Then
                        If k < 5 Then
                            bay_col_cabin = "0" & k * 2
                        Else
                            bay_col_cabin = k * 2
                        End If
                    Else
                        If Abs(k) * 2 + 1 < 10 Then
                            bay_col_cabin = "0" & Abs(k) * 2 + 1
                        Else
                            bay_col_cabin = Abs(k) * 2 + 1
                        End If
                    End If
                Else
                    k = small_col_cabin + Fix(n / 2) - j
                    If k = 0 Then
                        bay_col_cabin = "00"
                    Else
                        If k > 0 Then
                            If k * 2 < 10 Then
                                bay_col_cabin = "0" & k * 2
                            Else
                                bay_col_cabin = k * 2
                            End If
                        Else
                            If Abs(k) * 2 - 1 < 10 Then
                                bay_col_cabin = "0" & Abs(k) * 2 - 1
                            Else
                                bay_col_cabin = Abs(k) * 2 - 1
                            End If
                        End If
                    End If
                End If
                bmpgraphics_bay_map.DrawString(bay_col_cabin, Me.Font, Brushes.Black, distolefe - xChange + col_count * 40 + 80 * (j - strsmallcol + strcon) + 30, distotop + board_height + yRect + (big_row_cabin - small_row_cabin + 1) * yRect - 8) '贝列
            Next
        End If
        Me.Pl_bay_map.Refresh()
    End Sub

    Private Sub show_bay_map(ByVal bmpgraphics_bay_map As Graphics) '现实
        'Me.Pl_bay_map.Height = 1200
        '清空
        bmpgraphics_bay_map.Clear(Color.White)
        small_col = 0
        big_col = 0
        small_col_cabin = 0
        big_col_cabin = 0
        '''计算甲板的高度
        board_height = 0
        ''甲板取甲板的列数
        If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "' and location='board' order by id", ds_board).Count > 0 Then
            Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "' and location='board'", ds_board_char)
            small_row = ds_board_char.Tables(0).Rows(0).Item("small_row") '取甲板屏幕的最小行
            big_row = ds_board_char.Tables(0).Rows(0).Item("big_row") '取甲板屏幕的最大行
            small_col = ds_board_char.Tables(0).Rows(0).Item("small_col") '取甲板屏幕的最小列
            big_col = ds_board_char.Tables(0).Rows(0).Item("big_col") '取甲板屏幕的最大列
            '''计算甲板的高度
            board_height = (big_row - small_row + 1) * 40
        End If
        '取舱内的列数
        If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "' and location='cabin' order by id", ds_cabin).Count > 0 Then
            Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "' and location='cabin'", ds_cabin_char)
            small_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_col") '取舱内屏幕的最小列
            big_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_col") '取舱内屏幕的最大列
            small_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_row") '取舱内屏幕的最小行
            big_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_row") '取舱内屏幕的最大行
        End If
        '写连云港外理
        bmpgraphics_bay_map.DrawString("COSTACO LIANYUNGANG  连云港外理", Me.Font, Brushes.Black, distolefe + 0, distotop - 10)
        '写船名航次
        bmpgraphics_bay_map.DrawString("VESSEL:" & ENG_VESSEL, Me.Font, Brushes.Black, distolefe + 40 + 190, distotop - 10)
        bmpgraphics_bay_map.DrawString("VOY:" & VOYAGE, Me.Font, Brushes.Black, distolefe + 40 + 320, distotop - 10)
        bmpgraphics_bay_map.DrawString("POL：LYG", Me.Font, Brushes.Black, distolefe + 40 + 420, distotop - 10)
        '写BAY
        bmpgraphics_bay_map.DrawString("BAY： " & Me.cmb_defined_bay.Text, bay_f, Brushes.Black, distolefe + 40 + 20 + 500, distotop - 10)
        '甲板开始
        If ds_board.Tables(0).Rows.Count > 0 Then
            '计算甲板结果图的顶点位置
            If (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) >= 0 Then '比较甲板和舱内的列数
                col_count = (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) ''甲板上列数和舱内的差额
            Else
                col_count = 0
            End If
            ''画甲板矩形
            For i = small_row To big_row
                For j = small_col To big_col
                    If ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("user_char") = 1 Then
                        bmpgraphics_bay_map.DrawRectangle(pen_line, distolefe + col_count * 20 + 40 * (j - small_col + 1), distotop + board_height + 40 - 40 * (i - small_row + 1) + 40, 40, 40)
                        bmpgraphics_bay_map.DrawString(ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_col") & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_row"), f, Brushes.Black, distolefe + col_count * 20 + 40 * (j - small_col + 1), distotop + board_height + 40 - 40 * (i - small_row + 1) + 32 + 40)
                        bmpgraphics_bay_map.DrawRectangle(pen_line, distolefe + col_count * 20 + 40 * (j - small_col + 1), distotop + board_height + 40 - 40 * (i - small_row + 1) + 32 + 40, 27, 8)
                    End If
                Next
            Next
            '画贝层
            For i = small_row To big_row '战位最大屏列,按行读，行坐标先变
                bay_row = 78 + i * 2
                bmpgraphics_bay_map.DrawString(bay_row, Me.Font, Brushes.Black, distolefe + 20, distotop + board_height + 40 + 40 - 40 * (i - small_row + 1) - 40 + 17 + 40) '贝层
            Next
            ''写贝列
            n = big_col - small_col + 1
            'bay_row = 78 + i * 2
            Dim strcon As Integer
            strcon = 1
            Dim strsmallcol As Integer
            strsmallcol = small_col
            Dim strbigcol As Integer
            strbigcol = big_col
            If Getdata("select * from con_bay where  v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "'", ds_unuse_col).Count > 0 Then
                If ds_unuse_col.Tables(0).Rows(0).Item("board_unuse_col") Is System.DBNull.Value Then

                Else
                    If ds_unuse_col.Tables(0).Rows(0).Item("board_unuse_col") = "右边" Then
                        strbigcol = strbigcol - 1
                    Else
                        If ds_unuse_col.Tables(0).Rows(0).Item("board_unuse_col") = "左边" Then
                            strsmallcol = strsmallcol + 1
                            strcon = 2
                        End If
                    End If
                End If
            End If
            For j = strsmallcol To strbigcol   '战位最大屏列
                If n Mod 2 = 0 Then
                    k = small_col + Fix(n / 2) - j
                    If k > 0 Then
                        If k < 5 Then
                            bay_col = "0" & k * 2
                        Else
                            bay_col = k * 2
                        End If
                    Else
                        If Abs(k) * 2 + 1 < 10 Then
                            bay_col = "0" & Abs(k) * 2 + 1
                        Else
                            bay_col = Abs(k) * 2 + 1
                        End If
                    End If
                Else
                    k = small_col + Fix(n / 2) - j
                    If k = 0 Then
                        bay_col = "00"
                    Else
                        If k > 0 Then
                            If k * 2 < 10 Then
                                bay_col = "0" & k * 2
                            Else
                                bay_col = k * 2
                            End If
                        Else
                            If Abs(k) * 2 - 1 < 10 Then
                                bay_col = "0" & Abs(k) * 2 - 1
                            Else
                                bay_col = Abs(k) * 2 - 1
                            End If
                        End If
                    End If
                End If
                bmpgraphics_bay_map.DrawString(bay_col, Me.Font, Brushes.Black, distolefe + col_count * 20 + 40 * (j - strsmallcol + strcon) + 13, distotop + board_height + 40 + 5 - (big_row - small_row + 1) * 40 + 20) '贝列
            Next
        End If '甲板结束
        ''舱内开始
        If ds_cabin.Tables(0).Rows.Count > 0 Then
            '计算舱内结果图的顶点位置
            If (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) >= 0 Then
                col_count = (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) ''甲板上列数和舱内的差额
            Else
                col_count = 0
            End If
            ''画舱内矩形
            For i = small_row_cabin To big_row_cabin
                For j = small_col_cabin To big_col_cabin
                    If ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("user_char") = 1 Then
                        bmpgraphics_bay_map.DrawRectangle(pen_line, distolefe + col_count * 20 + 40 * (j - small_col_cabin + 1), distotop + board_height + 80 + (big_row_cabin - small_row_cabin + 1) * 40 - 40 * (i - small_row_cabin + 1) + 40, 40, 40) '   bmpgraphics_result_cabin.DrawRectangle(pen_line, 20 * (j - small_col_cabin + 1), 200 - 20 * (i - small_row_cabin + 1), 20, 20
                        bmpgraphics_bay_map.DrawString(ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_col") & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_row"), f, Brushes.Black, distolefe + col_count * 20 + 40 * (j - small_col_cabin + 1), distotop + board_height + 80 + (big_row_cabin - small_row_cabin + 1) * 40 - 40 * (i - small_row_cabin + 1) + 32 + 40)
                        bmpgraphics_bay_map.DrawRectangle(pen_line, distolefe + col_count * 20 + 40 * (j - small_col_cabin + 1), distotop + board_height + 80 + (big_row_cabin - small_row_cabin + 1) * 40 - 40 * (i - small_row_cabin + 1) + 32 + 40, 27, 8)
                    End If
                Next
            Next
            '画贝层
            For i = small_row_cabin To big_row_cabin '战位最大屏列,按行读，行坐标先变
                If i * 2 < 10 Then
                    bay_row_cabin = "0" & i * 2
                Else
                    bay_row_cabin = i * 2
                End If
                bmpgraphics_bay_map.DrawString(bay_row_cabin, Me.Font, Brushes.Black, distolefe + 20, distotop + board_height + 80 + (big_row_cabin - small_row_cabin + 1 + 1) * 40 - 40 * (i - small_row_cabin + 1) - 40 + 17 + 40) '贝层
            Next
            ''写贝列
            n = big_col_cabin - small_col_cabin + 1
            'bay_row_cabin = 78 + i * 2
            Dim strcon As Integer
            strcon = 1
            Dim strsmallcol As Integer
            strsmallcol = small_col_cabin
            Dim strbigcol As Integer
            strbigcol = big_col_cabin
            If Getdata("select * from con_bay where  v_id='" & v_id & "' and bay_num='" & Trim(Me.cmb_defined_bay.Text) & "'", ds_unuse_col).Count > 0 Then
                If ds_unuse_col.Tables(0).Rows(0).Item("cabin_unuse_col") Is System.DBNull.Value Then

                Else
                    If ds_unuse_col.Tables(0).Rows(0).Item("cabin_unuse_col") = "右边" Then
                        strbigcol = strbigcol - 1
                    Else
                        If ds_unuse_col.Tables(0).Rows(0).Item("cabin_unuse_col") = "左边" Then
                            strsmallcol = strsmallcol + 1
                            strcon = 2
                        End If
                    End If
                End If
            End If
            For j = strsmallcol To strbigcol   '战位最大屏列
                'For j = small_col_cabin To big_col_cabin '战位最大屏列
                If n Mod 2 = 0 Then
                    k = small_col_cabin + Fix(n / 2) - j
                    If k > 0 Then
                        If k < 5 Then
                            bay_col_cabin = "0" & k * 2
                        Else
                            bay_col_cabin = k * 2
                        End If
                    Else
                        If Abs(k) * 2 + 1 < 10 Then
                            bay_col_cabin = "0" & Abs(k) * 2 + 1
                        Else
                            bay_col_cabin = Abs(k) * 2 + 1
                        End If
                    End If
                Else
                    k = small_col_cabin + Fix(n / 2) - j
                    If k = 0 Then
                        bay_col_cabin = "00"
                    Else
                        If k > 0 Then
                            If k * 2 < 10 Then
                                bay_col_cabin = "0" & k * 2
                            Else
                                bay_col_cabin = k * 2
                            End If
                        Else
                            If Abs(k) * 2 - 1 < 10 Then
                                bay_col_cabin = "0" & Abs(k) * 2 - 1
                            Else
                                bay_col_cabin = Abs(k) * 2 - 1
                            End If
                        End If
                    End If
                End If
                bmpgraphics_bay_map.DrawString(bay_col_cabin, Me.Font, Brushes.Black, distolefe + col_count * 20 + 40 * (j - strsmallcol + strcon) + 13, distotop + board_height + 80 + (big_row_cabin - small_row_cabin + 1) * 40 + 5 + 40) '贝列
            Next
        End If
        Me.Pl_bay_map.Refresh()
    End Sub

    Private Sub btn_enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enter.Click
        Try
            Dim pd As New PrintDocument()
            'pd.DefaultPageSettings.Landscape = True
            AddHandler pd.PrintPage, AddressOf printpageeventhandler
            ' pd.printpage=pd.printpage+new PrintPageEventHandler(me.printpageeventhandler);
            If (Me.storedpagesettings Is System.DBNull.Value) = False Then
                pd.DefaultPageSettings = Me.storedpagesettings
            End If
            pd.DefaultPageSettings.Landscape = True
            'Dim dlg As New PrintDialog()
            'dlg.Document = pd
            'dlg.AllowSelection = True
            'dlg.AllowSomePages = True
            'Dim result As DialogResult
            'result = dlg.ShowDialog
            'If (result = DialogResult.OK) Then
            '    pd.Print()

            'End If
            If (ptdlg Is Nothing) Then '第一次打印
                ptdlg = New PrintDialog()
                ptdlg.Document = pd
                ptdlg.AllowSelection = False
                ptdlg.AllowSomePages = False
                ptdlg.AllowPrintToFile = False
                ptdlg.ShowHelp = False
                '  ptdlg.PrinterSettings.

                Dim result As DialogResult
                result = ptdlg.ShowDialog
                If (result = DialogResult.OK) Then
                    pd.Print()
                End If
            Else
                '非第一次打印
                pd.Print()
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub printpageeventhandler(ByVal obj As System.Object, ByVal ev As PrintPageEventArgs)
        Dim g As Graphics
        g = ev.Graphics

        If Len(Trim(Me.txt_scale_rate.Text)) > 0 Then
            Try
                Dim expandPercent As Single = CType(Me.txt_scale_rate.Text, Integer) / 100
                g.ScaleTransform(expandPercent, expandPercent)
            Catch
                MsgBox("请在缩放比例中输入数字！", MsgBoxStyle.OKOnly, "提示")
                Exit Sub
            End Try
        End If
        ' g.ScaleTransform(0.8, 0.8)
        print_bay_map(g)
        ev.HasMorePages = False
    End Sub

    Private Sub btn_cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancle.Click
        Me.Close()
    End Sub

    Private Sub btn_pagesetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pagesetup.Click
        Try

            Dim psdlg As New PageSetupDialog

            psdlg.AllowMargins = False
            psdlg.AllowOrientation = False
            ' If Me.storedpagesettings Is System.DBNull.Value Then
            Me.storedpagesettings = New PageSettings
            '   End If

            psdlg.PageSettings = Me.storedpagesettings
            psdlg.PageSettings.Landscape = True
            psdlg.ShowDialog()

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_printpreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_printpreview.Click
        Try
            Dim pd As New PrintDocument
            'pd.DefaultPageSettings.Landscape = True
            AddHandler pd.PrintPage, AddressOf printpageeventhandler
            If (Me.storedpagesettings Is System.DBNull.Value) = False Then
                pd.DefaultPageSettings = Me.storedpagesettings
            End If
            pd.DefaultPageSettings.Landscape = True
            Dim dlg As New PrintPreviewDialog
            dlg.Document = pd
            dlg.ShowDialog()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class
