Imports TALLY.DBControl
Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.Math
Imports System.Drawing.Printing
Public Class Frm_con_facemap
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
    Friend WithEvents btn_enter As System.Windows.Forms.Button
    Friend WithEvents btn_cancle As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pl_facemap As System.Windows.Forms.Panel
    Friend WithEvents btn_printpreview As System.Windows.Forms.Button
    Friend WithEvents btn_pagesetup As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_percent As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_show As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btn_enter = New System.Windows.Forms.Button()
        Me.btn_cancle = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_show = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_percent = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_printpreview = New System.Windows.Forms.Button()
        Me.btn_pagesetup = New System.Windows.Forms.Button()
        Me.pl_facemap = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_enter
        '
        Me.btn_enter.Location = New System.Drawing.Point(364, 28)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(64, 24)
        Me.btn_enter.TabIndex = 1
        Me.btn_enter.Text = "打印"
        '
        'btn_cancle
        '
        Me.btn_cancle.Location = New System.Drawing.Point(510, 28)
        Me.btn_cancle.Name = "btn_cancle"
        Me.btn_cancle.Size = New System.Drawing.Size(64, 24)
        Me.btn_cancle.TabIndex = 1
        Me.btn_cancle.Text = "取消"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_show)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_percent)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_printpreview)
        Me.GroupBox1.Controls.Add(Me.btn_pagesetup)
        Me.GroupBox1.Controls.Add(Me.btn_enter)
        Me.GroupBox1.Controls.Add(Me.btn_cancle)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(641, 64)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'btn_show
        '
        Me.btn_show.Location = New System.Drawing.Point(437, 28)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Size = New System.Drawing.Size(64, 24)
        Me.btn_show.TabIndex = 12
        Me.btn_show.Text = "显示图形"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(176, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "%"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_percent
        '
        Me.txt_percent.Location = New System.Drawing.Point(138, 30)
        Me.txt_percent.Name = "txt_percent"
        Me.txt_percent.Size = New System.Drawing.Size(38, 21)
        Me.txt_percent.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(102, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "放缩"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_printpreview
        '
        Me.btn_printpreview.Location = New System.Drawing.Point(291, 28)
        Me.btn_printpreview.Name = "btn_printpreview"
        Me.btn_printpreview.Size = New System.Drawing.Size(64, 24)
        Me.btn_printpreview.TabIndex = 8
        Me.btn_printpreview.Text = "打印预揽"
        '
        'btn_pagesetup
        '
        Me.btn_pagesetup.Location = New System.Drawing.Point(218, 28)
        Me.btn_pagesetup.Name = "btn_pagesetup"
        Me.btn_pagesetup.Size = New System.Drawing.Size(64, 24)
        Me.btn_pagesetup.TabIndex = 7
        Me.btn_pagesetup.Text = "页面设置"
        '
        'pl_facemap
        '
        Me.pl_facemap.AutoScroll = True
        Me.pl_facemap.AutoScrollMinSize = New System.Drawing.Size(1024, 768)
        Me.pl_facemap.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pl_facemap.Location = New System.Drawing.Point(0, 64)
        Me.pl_facemap.Name = "pl_facemap"
        Me.pl_facemap.Size = New System.Drawing.Size(641, 1500)
        Me.pl_facemap.TabIndex = 3
        '
        'Frm_con_facemap
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(658, 563)
        Me.Controls.Add(Me.pl_facemap)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_con_facemap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "面图"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    '船信息
    Dim v_id As Integer '船id
    Dim ENG_VESSEL As String '英文船名
    Dim CHI_VESSEL As String '中文船名
    Dim VOYAGE As String '航次
    Dim ds_ship As New DataSet() '船数据级
    Dim ds_count_board As New DataSet() '取甲板列数层数贝数
    Dim ds_count_cabin As New DataSet() '取舱内列数层数贝数
    Dim ship_col_count As Integer '船的列数
    Dim ship_row_count As Integer '船的层数
    Dim ship_bay_count As Integer '船的贝数
    Dim bay_start As Integer '贝循环因子
    Dim i, j, k As Integer '内部循环因子
    Dim hang As Integer '换行循环因子
    Dim ds_bay_num As New DataSet() '取出要处理的BAY
    Dim ship_bay_num As String '当前处理的BAY
    Dim distoleft As Integer  '距左边距移动的位移
    Dim distotop As Integer '距顶边距移动的位移
    Dim col_count As Integer '甲板和舱内列数差额
    Dim hang_bay_count As Integer '控制一行能画几个BAY
    Dim hang_big_bay As Integer '当前行的最大BAY
    Dim hang_small_bay As Integer '当前行的最小BAY
    Dim n As Integer '当前bay甲板或则舱内的列数
    Dim m As Integer 'load内部循环因子
    Dim maxcol_board As Integer = 0
    Dim maxrow_board As Integer = 0
    Dim maxcol_cabin As Integer = 0
    Dim maxrow_cabin As Integer = 0
    '图信息
    Dim bmp_facemap As Bitmap
    Dim bmpgraphics_facemap As Graphics
    Dim pen_line As New Pen(Color.Black, 1)
    Dim ff As New FontFamily("Arial")
    Dim f As New Font(ff, 6)
    Dim bay_f As New Font(ff, 8, FontStyle.Bold)
    Dim shipName As New Font(ff, 11, FontStyle.Bold) '写表名
    Dim pen_seperate As New Pen(Color.Black)

    '甲板
    Dim ds_board_char As New DataSet()
    Dim small_row As Integer   '甲板最小行
    Dim small_col As Integer   '甲板最小列
    Dim big_row As Integer   '甲板最大行
    Dim big_col As Integer   '甲板最大列
    Dim ds_board As New DataSet()   '甲板
    Dim bay_row As String   '甲板贝层
    Dim bay_col As String   '甲板贝列
    Dim ds_unuse_col As New DataSet()   '甲板
    '舱内
    Dim ds_cabin As New DataSet()
    Dim ds_cabin_char As New DataSet()
    Dim small_row_cabin As Integer  '舱内最小行
    Dim small_col_cabin As Integer  '舱内最小列
    Dim big_row_cabin As Integer  '舱内最大行
    Dim big_col_cabin As Integer  '舱内最大列
    Dim bay_row_cabin As String  '舱内贝层
    Dim bay_col_cabin As String  '舱内贝列
    '打印
    Dim storedpagesettings As PageSettings
    Dim pageHeight As Integer '页面的高度
    Dim pageWidth As Integer '页面的宽度
    Dim pageTopHeight As Integer = 20 '页面顶部写注释的高度
    Dim pageBottomHeight As Integer = 20 '页面底部写注释的高度
    Dim expandPercent As Single = 1  '放缩比例
    Dim minRectBorder As Integer = 14 '面图上矩形的最小边长
    Dim maxRectBorder As Integer = 20 '面图上矩形的最大边长
    Dim RectBorder As Integer '面图上矩形的边长

    Dim faceRowCount As Integer '面图上可以放的层数
    Dim faceColCount As Integer '面图上一行可以放贝的贝数
    Dim firstFaceBayCount As Integer '第一页放的贝数
    Dim secondFaceBayCount As Integer '第二页放的贝数
    Dim pagecount As Integer = 0 '页数控制变量
    Dim totalBay As Integer = 0 '船上的总bay数
  
    Private Sub Frm_con_facemap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bmp_facemap = New Bitmap(Me.pl_facemap.Width, Me.pl_facemap.Height)
        bmpgraphics_facemap = Graphics.FromImage(bmp_facemap)
        Me.pl_facemap.BackgroundImage = bmp_facemap
        pen_line.DashStyle = DashStyle.Solid
        pen_seperate.DashStyle = DashStyle.Dot
        '清空
        maxcol_board = 0
        maxrow_board = 0
        maxcol_cabin = 0
        maxrow_cabin = 0
        '写船名
        If Getdata("select VESSEL_ID,VESSEL.ENG_VESSEL,VESSEL.CHI_VESSEL, sship.VOYAGE from VESSEL,sship where sship.ship_id=" & Ship_ID & " and sship.v_id=VESSEL.VESSEL_id", ds_ship).Count > 0 Then
            v_id = ds_ship.Tables(0).Rows(0).Item("VESSEL_id")
            ENG_VESSEL = ds_ship.Tables(0).Rows(0).Item("ENG_VESSEL")
            CHI_VESSEL = ds_ship.Tables(0).Rows(0).Item("CHI_VESSEL")
            VOYAGE = ds_ship.Tables(0).Rows(0).Item("VOYAGE")
            '取甲板列数层数贝数
            If Getdata("select max(screen_col)-min(screen_col)+1 col_count,max(screen_row)-min(screen_row)+1 row_count,(select count(*) from con_bay where v_id='" & v_id & "' ) bay_count from con_map where v_id='" & v_id & "'and location='board' group  by bay_Num", ds_count_board).Count > 0 Then
                For m = 0 To ds_count_board.Tables(0).Rows.Count - 1
                    If ds_count_board.Tables(0).Rows(m).Item("col_count") Is System.DBNull.Value Then
                    Else
                        If ds_count_board.Tables(0).Rows(m).Item("col_count") > maxcol_board Then
                            maxcol_board = ds_count_board.Tables(0).Rows(m).Item("col_count") '甲板的最大列数
                        End If
                    End If
                    If ds_count_board.Tables(0).Rows(m).Item("row_count") Is System.DBNull.Value Then
                    Else
                        If ds_count_board.Tables(0).Rows(m).Item("row_count") > maxrow_board Then
                            maxrow_board = ds_count_board.Tables(0).Rows(m).Item("row_count") '甲板的最大层数
                        End If
                    End If
                Next
            End If
            '取舱内列数层数贝数
            If Getdata("select max(screen_col)-min(screen_col)+1 col_count,max(screen_row)-min(screen_row)+1 row_count,(select count(*) from con_bay where v_id='" & v_id & "' ) bay_count from con_map where v_id='" & v_id & "'and location='cabin'  group  by bay_Num", ds_count_cabin).Count > 0 Then
                For m = 0 To ds_count_cabin.Tables(0).Rows.Count - 1
                    If ds_count_cabin.Tables(0).Rows(m).Item("col_count") Is System.DBNull.Value Then
                    Else
                        If ds_count_cabin.Tables(0).Rows(m).Item("col_count") > maxcol_cabin Then
                            maxcol_cabin = ds_count_cabin.Tables(0).Rows(m).Item("col_count") '舱内的最大列数
                        End If
                    End If
                    If ds_count_cabin.Tables(0).Rows(m).Item("row_count") Is System.DBNull.Value Then
                    Else
                        If ds_count_cabin.Tables(0).Rows(m).Item("row_count") > maxrow_cabin Then
                            maxrow_cabin = ds_count_cabin.Tables(0).Rows(m).Item("row_count") '舱内的最大层数
                        End If
                    End If
                Next
            End If
            If maxcol_board > maxcol_cabin Then
                ship_col_count = maxcol_board   '船的最大列数
            Else
                ship_col_count = maxcol_cabin '船的最大列数
            End If
            If maxrow_board > maxrow_cabin Then   '船的最大层数
                ship_row_count = maxrow_board '船的最大层数
            Else
                ship_row_count = maxrow_cabin  '船的最大层数
            End If
            '打印多页 
            Getdata("select bay_num,joint from con_bay where v_id=" & v_id & " order by bay_num", dsMorePageBayNum)   '存放所有的bay

            Try
                ship_bay_count = ds_count_cabin.Tables(0).Rows(0).Item("bay_count") '船的贝数
                totalBay = ds_count_cabin.Tables(0).Rows(0).Item("bay_count") '船的贝数
                'con_ship_facemap_show(bmpgraphics_facemap)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub con_ship_facemap_show(ByVal g As Graphics)
        '清空
        'g.Clear(Me.BackColor)
        distoleft = 0
        distotop = 10
        '写连云港外理
        g.DrawString("COSTACO LIANYUNGANG  连云港外理", Me.Font, Brushes.Black, 0, distotop - 10)
        '写船名航次
        g.DrawString("VESSEL:" & ENG_VESSEL, Me.Font, Brushes.Black, 40, distotop + 0)
        g.DrawString("VOY:" & VOYAGE, Me.Font, Brushes.Black, 300, distotop + 0)
        g.DrawString("POL：LYG", Me.Font, Brushes.Black, 600, distotop + 0)
        '船名航次结束

        Getdata("select bay_num,joint from con_bay where v_id=" & v_id & " order by bay_num", ds_bay_num) '取出所有要处理的BAY

        hang_bay_count = Fix(1024 / ((ship_col_count + 2) * 10)) '一行容纳的BAY数
        If hang_bay_count > ship_bay_count Then
            hang_big_bay = ship_bay_count '初始化行最大BAY
        Else
            hang_big_bay = hang_bay_count
        End If
        hang_small_bay = 1 '初始化行最小bay
        '行循环开始
        For hang = 1 To Fix(ship_bay_count / hang_bay_count + 0.99999)
            If hang > 1 And hang_big_bay < ship_bay_count Then
                hang_big_bay = hang_big_bay + hang_bay_count
                If hang_big_bay > ship_bay_count Then
                    hang_big_bay = ship_bay_count
                End If
                hang_small_bay = hang_small_bay + hang_bay_count
            End If
            '换行计算下移的距离
            If hang > 1 Then
                distotop = distotop + 2 * (ship_row_count + 1 + 2) * 10
            End If
            '行BAY循环开始
            For bay_start = hang_big_bay To hang_small_bay Step -1
                ship_bay_num = ds_bay_num.Tables(0).Rows(bay_start - 1).Item("bay_num") '取出要处理的当前BAY
                '开始处理当前BAY
                '计算距左边和顶点的位移
                If bay_start Mod hang_bay_count = 0 Then
                    distoleft = 0
                Else
                    distoleft = (hang_bay_count - (bay_start Mod hang_bay_count)) * 10 * (ship_col_count + 2)
                End If
                '清空
                small_col = 0
                big_col = 0
                small_col_cabin = 0
                big_col_cabin = 0
                ''甲板取甲板的列数
                If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='board'", ds_board).Count > 0 Then
                    Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='board'", ds_board_char)
                    small_row = ds_board_char.Tables(0).Rows(0).Item("small_row") '取甲板屏幕的最小行
                    big_row = ds_board_char.Tables(0).Rows(0).Item("big_row") '取甲板屏幕的最大行
                    small_col = ds_board_char.Tables(0).Rows(0).Item("small_col") '取甲板屏幕的最小列
                    big_col = ds_board_char.Tables(0).Rows(0).Item("big_col") '取甲板屏幕的最大列
                End If
                '取舱内的列数
                If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='cabin'", ds_cabin).Count > 0 Then
                    Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='cabin'", ds_cabin_char)
                    small_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_col") '取舱内屏幕的最小列
                    big_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_col") '取舱内屏幕的最大列
                    small_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_row") '取舱内屏幕的最小行
                    big_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_row") '取舱内屏幕的最大行
                End If
                '写bay号，判断是否通贝的情况
                If (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) >= 0 Then
                    If ds_bay_num.Tables(0).Rows(bay_start - 1).Item("joint") = 1 Then '取出要处理的当前BAY_ Then
                        If CType(ship_bay_num, Integer) + 1 < 10 Then
                            g.DrawString(ship_bay_num & "(0" & ship_bay_num + 1 & ")", bay_f, Brushes.Black, distoleft + 5 + (big_col - small_col + 1) / 2 * 10 - 10, distotop + 10 + 5)
                        Else
                            g.DrawString(ship_bay_num & "(" & ship_bay_num + 1 & ")", bay_f, Brushes.Black, distoleft + 5 + (big_col - small_col + 1) / 2 * 10 - 10, distotop + 10 + 5)
                        End If

                    Else
                        g.DrawString(ship_bay_num, bay_f, Brushes.Black, distoleft + 15 + (big_col - small_col + 1) / 2 * 10 - 10, distotop + 10 + 5)
                    End If
                Else
                    If ds_bay_num.Tables(0).Rows(bay_start - 1).Item("joint") = 1 Then '取出要处理的当前BAY_ Then
                        If CType(ship_bay_num, Integer) < 10 Then
                            g.DrawString(ship_bay_num & "(0" & ship_bay_num + 1 & ")", bay_f, Brushes.Black, distoleft + 5 + (big_col_cabin - small_col_cabin + 1) / 2 * 10 - 10, distotop + 10 + 5)
                        Else
                            g.DrawString(ship_bay_num & "(" & ship_bay_num + 1 & ")", bay_f, Brushes.Black, distoleft + 5 + (big_col_cabin - small_col_cabin + 1) / 2 * 10 - 10, distotop + 10 + 5)
                        End If

                    Else
                        g.DrawString(ship_bay_num, bay_f, Brushes.Black, distoleft + 15 + (big_col_cabin - small_col_cabin + 1) / 2 * 10 - 10, distotop + 10 + 5)
                    End If

                End If

                '甲板开始
                If ds_board.Tables(0).Rows.Count > 0 Then
                    '计算甲板结果图的顶点位置
                    If (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) >= 0 Then '比较甲板和舱内的列数
                        col_count = (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) ''甲板上列数和舱内的差额
                    Else
                        col_count = 0
                    End If
                    '画甲板矩形
                    For i = small_row To big_row
                        For j = small_col To big_col
                            If ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("user_char") = 1 Then
                                g.DrawRectangle(pen_line, distoleft + 10 + col_count * 5 + 10 * (j - small_col + 1), distotop + (ship_row_count + 1 + 2) * 10 - 10 * (i - small_row + 1) + 10, 10, 10)
                            End If
                        Next
                    Next
                    '画贝层
                    For i = small_row To big_row '战位最大屏列,按行读，行坐标先变
                        bay_row = 78 + i * 2
                        g.DrawString(bay_row, f, Brushes.Black, distoleft + 9, distotop + (ship_row_count + 1 + 2) * 10 - 10 * (i - small_row + 1) + 10) '贝层
                    Next

                    ''写贝列

                    n = big_col - small_col + 1
                    Dim strcon As Integer
                    strcon = 1
                    Dim strsmallcol As Integer
                    strsmallcol = small_col
                    Dim strbigcol As Integer
                    strbigcol = big_col
                    If Getdata("select * from con_bay where  v_id='" & v_id & "' and bay_num='" & ship_bay_num & "'", ds_unuse_col).Count > 0 Then
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
                        g.DrawString(bay_col, f, Brushes.Black, distoleft + 10 + col_count * 5 + 10 * (j - small_col + 1), distotop + 30) '贝列
                    Next j
                End If
                '甲板结束
                '画甲办和舱内中间的分割线

                g.DrawLine(pen_seperate, distoleft + 10 + col_count * 5 + 10, distotop + (ship_row_count + 1 + 2) * 10 + 10 + 5, distoleft + 10 + col_count * 5 + 10 * (j - small_col + 1), distotop + (ship_row_count + 1 + 2) * 10 + 10 + 5)

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
                                g.DrawRectangle(pen_line, distoleft + 10 + col_count * 5 + 10 * (j - small_col_cabin + 1), distotop + (ship_row_count + 1 + 2 + 1 + 2) * 10 + (big_row_cabin - small_row_cabin + 1) * 10 - 10 * (i - small_row_cabin + 1) - 10, 10, 10) '   bmpgraphics_result_cabin.DrawRectangle(pen_line, 20 * (j - small_col_cabin + 1), 200 - 20 * (i - small_row_cabin + 1), 20, 20
                            End If
                        Next j
                    Next i
                    '画贝层
                    For i = small_row_cabin To big_row_cabin '战位最大屏列,按行读，行坐标先变
                        If i * 2 < 10 Then
                            bay_row_cabin = "0" & i * 2
                        Else
                            bay_row_cabin = i * 2
                        End If
                        g.DrawString(bay_row_cabin, f, Brushes.Black, distoleft + 9, distotop + (ship_row_count + 1 + 2 + 1 + 2) * 10 + (big_row_cabin - small_row_cabin + 1 + 1) * 10 - 10 * (i - small_row_cabin + 1) - 10 - 10)  '贝层
                    Next i
                    ''写贝列
                    n = big_col_cabin - small_col_cabin + 1
                    Dim strcon As Integer
                    strcon = 1
                    Dim strsmallcol As Integer
                    strsmallcol = small_col_cabin
                    Dim strbigcol As Integer
                    strbigcol = big_col_cabin
                    If Getdata("select * from con_bay where  v_id='" & v_id & "' and bay_num='" & ship_bay_num & "'", ds_unuse_col).Count > 0 Then
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
                        g.DrawString(bay_col_cabin, f, Brushes.Black, distoleft + 10 + col_count * 5 + 10 * (j - small_col_cabin + 1), distotop + (ship_row_count + 1 + 2 + 2) * 10 + (ship_row_count) * 10)  '贝列
                    Next
                End If
            Next bay_start
        Next hang
        Me.pl_facemap.Refresh()
    End Sub


    Private Sub con_ship_facemap_print(ByVal g As Graphics)
        '清空
        'g.Clear(Me.BackColor)
        distoleft = 0
        distotop = 30
        '写表名
        g.DrawString("STOWAGE  PLAN", shipName, Brushes.Black, CInt(pageWidth / 2) - 50, distotop - 30)
        '写连云港外理
        g.DrawString("COSTACO LIANYUNGANG  连云港外理", Me.Font, Brushes.Black, distoleft + 0, distotop - 10)
        '写船名航次
        g.DrawString("VESSEL:" & ENG_VESSEL, Me.Font, Brushes.Black, distoleft + 40 + 190, distotop - 10)
        g.DrawString("VOY:" & VOYAGE, Me.Font, Brushes.Black, distoleft + 40 + 450, distotop - 10)
        g.DrawString("POL：LYG", Me.Font, Brushes.Black, distoleft + 40 + 600, distotop - 10)
        g.DrawString("DATE:" & DatePart(DateInterval.Year, Today()) & "-" & IIf(DatePart(DateInterval.Month, Today()) < 10, "0" & DatePart(DateInterval.Month, Today()), DatePart(DateInterval.Month, Today())) & "-" & IIf(DatePart(DateInterval.Day, Today()) < 10, "0" & DatePart(DateInterval.Day, Today()), DatePart(DateInterval.Day, Today())), Me.Font, Brushes.Black, distoleft + 40 + 20 + 750, distotop - 10)
        '船名航次结束

        Getdata("select bay_num,joint from con_bay where v_id=" & v_id & " order by bay_num", ds_bay_num) '取出所有要处理的BAY

        hang_bay_count = Fix(pageWidth / ((ship_col_count + 1) * RectBorder)) '一行容纳的BAY数
        If hang_bay_count > ship_bay_count Then
            hang_big_bay = ship_bay_count '初始化行最大BAY
        Else
            hang_big_bay = hang_bay_count
        End If
        hang_small_bay = 1 '初始化行最小bay
        '行循环开始
        For hang = 1 To Ceiling(ship_bay_count / hang_bay_count)
            If hang > 1 And hang_big_bay < ship_bay_count Then
                hang_big_bay = hang_big_bay + hang_bay_count
                If hang_big_bay > ship_bay_count Then
                    hang_big_bay = ship_bay_count
                End If
                hang_small_bay = hang_small_bay + hang_bay_count
            End If
            '换行计算下移的距离
            If hang > 1 Then
                distotop = distotop + (maxrow_board + maxrow_cabin + 1 + 1 + 1 + 1) * RectBorder
            End If
            '行BAY循环开始
            For bay_start = hang_big_bay To hang_small_bay Step -1
                ship_bay_num = ds_bay_num.Tables(0).Rows(bay_start - 1).Item("bay_num") '取出要处理的当前BAY
                '开始处理当前BAY
                '计算距左边和顶点的位移
                If bay_start Mod hang_bay_count = 0 Then
                    distoleft = 0
                Else
                    distoleft = (hang_bay_count - (bay_start Mod hang_bay_count)) * RectBorder * (ship_col_count + 1)
                End If
                '清空
                small_col = 0
                big_col = 0
                small_col_cabin = 0
                big_col_cabin = 0
                ''甲板取甲板的列数
                If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='board'", ds_board).Count > 0 Then
                    Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='board'", ds_board_char)
                    small_row = ds_board_char.Tables(0).Rows(0).Item("small_row") '取甲板屏幕的最小行
                    big_row = ds_board_char.Tables(0).Rows(0).Item("big_row") '取甲板屏幕的最大行
                    small_col = ds_board_char.Tables(0).Rows(0).Item("small_col") '取甲板屏幕的最小列
                    big_col = ds_board_char.Tables(0).Rows(0).Item("big_col") '取甲板屏幕的最大列
                End If
                '取舱内的列数
                If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='cabin'", ds_cabin).Count > 0 Then
                    Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='cabin'", ds_cabin_char)
                    small_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_col") '取舱内屏幕的最小列
                    big_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_col") '取舱内屏幕的最大列
                    small_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_row") '取舱内屏幕的最小行
                    big_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_row") '取舱内屏幕的最大行
                End If
                '写bay号，判断是否通贝的情况
                If (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) >= 0 Then
                    If ds_bay_num.Tables(0).Rows(bay_start - 1).Item("joint") = 1 Then '取出要处理的当前BAY_ Then
                        '偶数bay
                        If CType(ship_bay_num, Integer) Mod 2 = 0 Then
                            g.DrawString(ship_bay_num, bay_f, Brushes.Black, distoleft + (big_col - small_col + 1 + 1) / 2 * RectBorder - 1, distotop + CInt(RectBorder / 2) - 5)
                        Else
                            If CType(ship_bay_num, Integer) + 1 < 10 Then
                                g.DrawString(ship_bay_num & "(0" & ship_bay_num + 1 & ")", bay_f, Brushes.Black, distoleft + (big_col - small_col + 1 + 1) / 2 * RectBorder - 13, distotop + CInt(RectBorder / 2) - 5)
                            Else
                                g.DrawString(ship_bay_num & "(" & ship_bay_num + 1 & ")", bay_f, Brushes.Black, distoleft + (big_col - small_col + 1 + 1) / 2 * RectBorder - 13, distotop + CInt(RectBorder / 2) - 5)
                            End If
                        End If


                    Else
                        g.DrawString(ship_bay_num, bay_f, Brushes.Black, distoleft + (big_col - small_col + 1 + 1) / 2 * RectBorder - 1, distotop + CInt(RectBorder / 2) - 5)
                    End If
                Else
                    If ds_bay_num.Tables(0).Rows(bay_start - 1).Item("joint") = 1 Then '取出要处理的当前BAY_ Then
                        If CType(ship_bay_num, Integer) < 10 Then
                            g.DrawString(ship_bay_num & "(0" & ship_bay_num + 1 & ")", bay_f, Brushes.Black, distoleft + (big_col_cabin - small_col_cabin + 1 + 1) / 2 * RectBorder - 13, distotop + CInt(RectBorder / 2) - 5)
                        Else
                            g.DrawString(ship_bay_num & "(" & ship_bay_num + 1 & ")", bay_f, Brushes.Black, distoleft + (big_col_cabin - small_col_cabin + 1 + 1) / 2 * RectBorder - 13, distotop + CInt(RectBorder / 2) - 5)
                        End If

                    Else
                        g.DrawString(ship_bay_num, bay_f, Brushes.Black, distoleft + (big_col_cabin - small_col_cabin + 1 + 1) / 2 * RectBorder - 1, distotop + CInt(RectBorder / 2) - 5)
                    End If

                End If

                '甲板开始
                If ds_board.Tables(0).Rows.Count > 0 Then
                    '计算甲板结果图的顶点位置
                    If (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) >= 0 Then '比较甲板和舱内的列数
                        col_count = (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) ''甲板上列数和舱内的差额
                    Else
                        col_count = 0
                    End If
                    '画甲板矩形
                    For i = small_row To big_row
                        For j = small_col To big_col
                            If ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("user_char") = 1 Then
                                g.DrawRectangle(pen_line, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col), distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1), RectBorder, RectBorder)
                            End If
                        Next
                    Next
                    '画贝层
                    For i = small_row To big_row '战位最大屏列,按行读，行坐标先变
                        bay_row = 78 + i * 2
                        g.DrawString(bay_row, f, Brushes.Black, distoleft + CInt(RectBorder / 2) - 6, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + CInt(RectBorder / 2) - 5) '贝层
                    Next

                    ''写贝列

                    n = big_col - small_col + 1
                    Dim strcon As Integer
                    strcon = 1
                    Dim strsmallcol As Integer
                    strsmallcol = small_col
                    Dim strbigcol As Integer
                    strbigcol = big_col
                    If Getdata("select * from con_bay where  v_id='" & v_id & "' and bay_num='" & ship_bay_num & "'", ds_unuse_col).Count > 0 Then
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
                        g.DrawString(bay_col, f, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + CInt(RectBorder / 2) - 6, distotop + RectBorder + RectBorder - CInt(RectBorder / 2) - 4) '贝列
                    Next j
                End If
                '甲板结束
                '画甲办和舱内中间的分割线

                g.DrawLine(pen_seperate, distoleft + RectBorder + CInt(col_count * RectBorder / 2), distotop + (maxrow_board + 1 + 1) * RectBorder + CInt(RectBorder / 2), distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (big_col - small_col + 1), distotop + (maxrow_board + 1 + 1) * RectBorder + CInt(RectBorder / 2))

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
                                g.DrawRectangle(pen_line, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin), distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1), RectBorder, RectBorder)
                            End If
                        Next j
                    Next i
                    '画贝层
                    For i = small_row_cabin To big_row_cabin '战位最大屏列,按行读，行坐标先变
                        If i * 2 < 10 Then
                            bay_row_cabin = "0" & i * 2
                        Else
                            bay_row_cabin = i * 2
                        End If
                        g.DrawString(bay_row_cabin, f, Brushes.Black, distoleft + CInt(RectBorder / 2) - 6, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + CInt(RectBorder / 2) - 5) '贝层
                    Next i
                    ''写贝列
                    n = big_col_cabin - small_col_cabin + 1
                    Dim strcon As Integer
                    strcon = 1
                    Dim strsmallcol As Integer
                    strsmallcol = small_col_cabin
                    Dim strbigcol As Integer
                    strbigcol = big_col_cabin
                    If Getdata("select * from con_bay where  v_id='" & v_id & "' and bay_num='" & ship_bay_num & "'", ds_unuse_col).Count > 0 Then
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
                        g.DrawString(bay_col_cabin, f, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) + CInt(RectBorder / 2) - 6, distotop + (maxrow_cabin + maxrow_board + 1 + 1 + 1) * RectBorder + 1)
                    Next
                End If
            Next bay_start
        Next hang
        Me.pl_facemap.Refresh()

    End Sub

    Private Sub btn_cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancle.Click
        Me.Close()
    End Sub

    Private Sub btn_pagesetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pagesetup.Click
        Try
            Dim psdlg As New PageSetupDialog()
            psdlg.AllowMargins = False
            psdlg.AllowOrientation = False
            ' If Me.storedpagesettings Is System.DBNull.Value Then
            Me.storedpagesettings = New PageSettings()
            '   End If
            psdlg.PageSettings = Me.storedpagesettings
            psdlg.PageSettings.Landscape = True
            psdlg.ShowDialog()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_printpreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_printpreview.Click
        Try
            pagecount = 0
            ship_bay_count = totalBay '船的贝数
            Dim pd As New PrintDocument
            '  pd.DefaultPageSettings.Landscape = True
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

    Private Sub btn_enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enter.Click
        Try
            pagecount = 0
            ship_bay_count = totalBay '船的贝数
            Dim pd As New PrintDocument
            '     pd.DefaultPageSettings.Landscape = True
            AddHandler pd.PrintPage, AddressOf printpageeventhandler
            ' pd.printpage=pd.printpage+new PrintPageEventHandler(me.printpageeventhandler);
            If (Me.storedpagesettings Is System.DBNull.Value) = False Then
                pd.DefaultPageSettings = Me.storedpagesettings
            End If
            pd.DefaultPageSettings.Landscape = True
            Dim dlg As New PrintDialog
            dlg.Document = pd
            dlg.AllowSelection = True
            dlg.AllowSomePages = True
            Dim result As DialogResult
            result = dlg.ShowDialog
            If (result = DialogResult.OK) Then

                pd.Print()

            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub printpageeventhandler(ByVal obj As System.Object, ByVal ev As PrintPageEventArgs)
        Dim x As Single = 0 '行排列的数量
        Dim y As Single = 0 '列排列的数量
        Dim scale1 As Single = 0 '比例因子1
        Dim scale2 As Single = 0 '比例因子2
        Dim scale3 As Single = 0 '比例因子3
        Dim scaleRow As Integer = 0 '面图中的行数
        Dim scaleCol As Integer = 0 '面图中的列数
        Dim rectborderRow As Integer = 0 '由贝的行数确定巨型的边长
        Dim rectborderCol As Integer = 0 '由贝的列数确定巨型的边长
        Dim papername As String '选择纸张的类型
        Dim dsPaper As New DataSet()
        Dim g As Graphics
        g = ev.Graphics
        pagecount = pagecount + 1 '页数控制变量

        If Microsoft.VisualBasic.Left(ev.PageSettings.PaperSize.PaperName, 2) = "A4" Then
            pageHeight = 787 - 10 - 20
            pageWidth = 1130 - 10
        End If
        If Microsoft.VisualBasic.Left(ev.PageSettings.PaperSize.PaperName, 2) = "B4" Then
            pageHeight = 996 - 25 - 30
            pageWidth = 1418 - 10
        End If
        '页面的高度
        ' pageHeight = ev.MarginBounds.Bottom - 10 - 30 '可以加到60 ，去掉底部的注释10，去掉顶部的注释20
        '页面的宽度
        '  pageWidth = ev.MarginBounds.Right - 10 ' + 30
        '选择纸张的类型
        papername = ev.PageSettings.PaperSize.PaperName()
        Getdata("select * from con_mapset where papername=left('" & papername & "',2) and baycount='" & totalBay & "'", dsPaper)
        '放缩比例因子
        If Len(Me.txt_percent.Text) > 0 Then
            Try
                expandPercent = CType(Me.txt_percent.Text, Integer) / 100
            Catch
                MsgBox("请输入数字！", MsgBoxStyle.OKOnly, "提示")
                Exit Sub
            End Try
        End If
        '计算矩形的边长---贝层数+4（两层贝列，一层空格，一层空格大小作为写bay标志），贝列数+1(一列贝层)=面图上每个bay分配的面积大小    'RectBorder = Floor(Sqrt(pageHeight * pageWidth / (ship_bay_count * (maxrow_board + maxrow_cabin + 4) * (ship_col_count + 1) * expandPrecent)))
        '计算面图中贝的行数和列数
        scaleRow = dsPaper.Tables(0).Rows(0).Item("row")
        scaleCol = dsPaper.Tables(0).Rows(0).Item("col")

        '计算矩形的边长
        rectborderRow = (pageHeight / scaleRow) / (maxrow_board + maxrow_cabin + 4) ' * expandpercent
        rectborderCol = (pageWidth / scaleCol) / (ship_col_count + 1) ' * expandPercent
        If rectborderRow > rectborderCol Then
            RectBorder = Floor(rectborderCol)
        Else
            RectBorder = Floor(rectborderRow)
        End If
        'RectBorder = RectBorder * expandPercent
        'RectBorder = 20
        '确保边长是偶数
        If RectBorder Mod 2 = 1 Then
            RectBorder = RectBorder - 1
        End If
        '放缩
        If Len(Me.txt_percent.Text) > 0 Then
            '边厂小于最小边长
            If RectBorder < minRectBorder Then
                RectBorder = minRectBorder * expandPercent
            End If
            '边厂大于最大边长
            If RectBorder > maxRectBorder Then
                RectBorder = maxRectBorder * expandPercent
            End If
            '边长处于合适边长
            If RectBorder >= minRectBorder And RectBorder <= maxRectBorder Then
                RectBorder = RectBorder * expandPercent
            End If
        Else
            If RectBorder < minRectBorder Then
                RectBorder = minRectBorder
                'MsgBox("请重新输入放缩比例或者另选纸类型！", MsgBoxStyle.OKOnly, "提示")
                'Exit Sub
            End If
            If RectBorder > maxRectBorder Then
                RectBorder = maxRectBorder
            End If
        End If
        '边长已经确定 由边长判断是否有两页
        faceColCount = Floor(pageWidth / ((ship_col_count + 1) * RectBorder)) '一行放的贝数
        faceRowCount = Floor(pageHeight / ((maxrow_board + maxrow_cabin + 4) * RectBorder)) '面图上放贝的层数
        firstFaceBayCount = faceColCount * faceRowCount
        If totalBay <= firstFaceBayCount Then
            '只需要一页
            con_ship_facemap_print(g)
            ev.HasMorePages = False
        Else
            '需要多页     第二页
            'If pagecount Mod 2 = 1 Then
            '    '打印第一页
            '    con_ship_facemap_print_first(g, firstFaceBayCount)
            '    ev.HasMorePages = True
            'End If
            'If pagecount Mod 2 = 0 Then
            '    '打印第二页
            '    con_ship_facemap_print_first(g, totalBay - firstFaceBayCount)
            '    ev.HasMorePages = False
            'End If
            If pagecount Mod 5 = 1 Then
                '打印第一页
                con_ship_facemap_print_first(g, firstFaceBayCount)
                ev.HasMorePages = True
            End If
            If pagecount Mod 5 = 2 Then
                '打印第二页

                If totalBay <= 2 * firstFaceBayCount Then
                    con_ship_facemap_print_first(g, totalBay - firstFaceBayCount)
                    ev.HasMorePages = False
                Else
                    con_ship_facemap_print_first(g, firstFaceBayCount)
                    ev.HasMorePages = True
                End If
            End If
            If pagecount Mod 5 = 3 Then
                '打印第三页
                If totalBay <= 3 * firstFaceBayCount Then
                    con_ship_facemap_print_first(g, totalBay - 2 * firstFaceBayCount)
                    ev.HasMorePages = False
                Else
                    con_ship_facemap_print_first(g, firstFaceBayCount)
                    ev.HasMorePages = True
                End If
            End If
            If pagecount Mod 5 = 4 Then
                '打印第四页
                If totalBay <= 4 * firstFaceBayCount Then
                    con_ship_facemap_print_first(g, totalBay - 3 * firstFaceBayCount)
                    ev.HasMorePages = False
                Else
                    con_ship_facemap_print_first(g, firstFaceBayCount)
                    ev.HasMorePages = True
                End If
            End If
            If pagecount Mod 5 = 0 Then
                '打印第五页
                con_ship_facemap_print_first(g, totalBay - 4 * firstFaceBayCount)
                ev.HasMorePages = False
            End If
        End If
    End Sub
    Dim dsMorePageBayNum As New DataSet '存放所有的bay
    Private Sub con_ship_facemap_print_first(ByVal g As Graphics, ByVal baycount As Integer)
        Dim myDataView As DataView
        ship_bay_count = baycount
        '清空
        'g.Clear(Me.BackColor)
        distoleft = 0
        distotop = 30
        '写表名
        g.DrawString("STOWAGE  PLAN", shipName, Brushes.Black, CInt(pageWidth / 2) - 50, distotop - 30)
        '写连云港外理
        g.DrawString("COSTACO LIANYUNGANG  连云港外理", Me.Font, Brushes.Black, distoleft + 0, distotop - 10)
        '写船名航次
        g.DrawString("VESSEL:" & ENG_VESSEL, Me.Font, Brushes.Black, distoleft + 40 + 190, distotop - 10)
        g.DrawString("VOY:" & VOYAGE, Me.Font, Brushes.Black, distoleft + 40 + 450, distotop - 10)
        g.DrawString("POL：LYG", Me.Font, Brushes.Black, distoleft + 40 + 600, distotop - 10)
        g.DrawString("DATE:" & DatePart(DateInterval.Year, Today()) & "-" & IIf(DatePart(DateInterval.Month, Today()) < 10, "0" & DatePart(DateInterval.Month, Today()), DatePart(DateInterval.Month, Today())) & "-" & IIf(DatePart(DateInterval.Day, Today()) < 10, "0" & DatePart(DateInterval.Day, Today()), DatePart(DateInterval.Day, Today())), Me.Font, Brushes.Black, distoleft + 40 + 20 + 750, distotop - 10)
        '船名航次结束
        'If pagecount Mod 2 = 1 Then
        '    Getdata("select top " & baycount & " bay_num,joint from con_bay where v_id=" & v_id & " order by bay_num", ds_bay_num) '取出所有要处理的BAY
        '    myDataView = ds_bay_num.Tables(0).DefaultView
        'End If
        'If pagecount Mod 2 = 0 Then

        '    Getdata("select top " & baycount & " bay_num,joint from con_bay where v_id=" & v_id & " order by bay_num desc", ds_bay_num) '取出所有要处理的BAY
        '    myDataView = ds_bay_num.Tables(0).DefaultView
        '    myDataView.Sort = "bay_num ASC"
        '   ' MsgBox(myDataView.Item(0).Row(0))
        'End If
        If pagecount Mod 5 = 1 Then
            Getdata("select top " & baycount & " bay_num,joint from con_bay where v_id=" & v_id & " order by bay_num", ds_bay_num) '取出所有要处理的BAY
            myDataView = ds_bay_num.Tables(0).DefaultView
        End If
        If pagecount Mod 5 = 2 Then
            '第二页
            Getdata("select top " & baycount & " bay_num,joint from con_bay where v_id=" & v_id & "  and bay_num>'" & dsMorePageBayNum.Tables(0).Rows(1 * firstFaceBayCount - 1).Item("bay_num") & "' order by bay_num", ds_bay_num) '取出所有要处理的BAY
            myDataView = ds_bay_num.Tables(0).DefaultView
        End If
        If pagecount Mod 5 = 3 Then
            '第三页
            Getdata("select top " & baycount & " bay_num,joint from con_bay where v_id=" & v_id & "  and bay_num>'" & dsMorePageBayNum.Tables(0).Rows(2 * firstFaceBayCount - 1).Item("bay_num") & "' order by bay_num", ds_bay_num) '取出所有要处理的BAY
            myDataView = ds_bay_num.Tables(0).DefaultView
        End If
        If pagecount Mod 5 = 4 Then
            '第四页
            Getdata("select top " & baycount & " bay_num,joint from con_bay where v_id=" & v_id & "  and bay_num>'" & dsMorePageBayNum.Tables(0).Rows(3 * firstFaceBayCount - 1).Item("bay_num") & "' order by bay_num", ds_bay_num) '取出所有要处理的BAY
            myDataView = ds_bay_num.Tables(0).DefaultView
        End If
        If pagecount Mod 5 = 0 Then
            '第五页
            Getdata("select top " & baycount & " bay_num,joint from con_bay where v_id=" & v_id & "  and bay_num>'" & dsMorePageBayNum.Tables(0).Rows(4 * firstFaceBayCount - 1).Item("bay_num") & "' order by bay_num", ds_bay_num) '取出所有要处理的BAY
            myDataView = ds_bay_num.Tables(0).DefaultView
        End If

        hang_bay_count = Fix(pageWidth / ((ship_col_count + 1) * RectBorder)) '一行容纳的BAY数
        If hang_bay_count > ship_bay_count Then
            hang_big_bay = ship_bay_count '初始化行最大BAY
        Else
            hang_big_bay = hang_bay_count
        End If
        hang_small_bay = 1 '初始化行最小bay
        '行循环开始
        For hang = 1 To Ceiling(ship_bay_count / hang_bay_count)
            If hang > 1 And hang_big_bay < ship_bay_count Then
                hang_big_bay = hang_big_bay + hang_bay_count
                If hang_big_bay > ship_bay_count Then
                    hang_big_bay = ship_bay_count
                End If
                hang_small_bay = hang_small_bay + hang_bay_count
            End If
            '换行计算下移的距离
            If hang > 1 Then
                distotop = distotop + (maxrow_board + maxrow_cabin + 1 + 1 + 1 + 1) * RectBorder
            End If
            '行BAY循环开始
            For bay_start = hang_big_bay To hang_small_bay Step -1
                'ship_bay_num = ds_bay_num.Tables(0).Rows(bay_start - 1).Item("bay_num") '取出要处理的当前BAY
                ship_bay_num = myDataView(bay_start - 1)("bay_num")
                '开始处理当前BAY
                '计算距左边和顶点的位移
                If bay_start Mod hang_bay_count = 0 Then
                    distoleft = 0
                Else
                    distoleft = (hang_bay_count - (bay_start Mod hang_bay_count)) * RectBorder * (ship_col_count + 1)
                End If
                '清空
                small_col = 0
                big_col = 0
                small_col_cabin = 0
                big_col_cabin = 0
                ''甲板取甲板的列数
                If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='board'", ds_board).Count > 0 Then
                    Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='board'", ds_board_char)
                    small_row = ds_board_char.Tables(0).Rows(0).Item("small_row") '取甲板屏幕的最小行
                    big_row = ds_board_char.Tables(0).Rows(0).Item("big_row") '取甲板屏幕的最大行
                    small_col = ds_board_char.Tables(0).Rows(0).Item("small_col") '取甲板屏幕的最小列
                    big_col = ds_board_char.Tables(0).Rows(0).Item("big_col") '取甲板屏幕的最大列
                End If
                '取舱内的列数
                If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='cabin'", ds_cabin).Count > 0 Then
                    Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='cabin'", ds_cabin_char)
                    small_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_col") '取舱内屏幕的最小列
                    big_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_col") '取舱内屏幕的最大列
                    small_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_row") '取舱内屏幕的最小行
                    big_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_row") '取舱内屏幕的最大行
                End If
                'If ship_bay_num = 45 Then
                '    MsgBox(ds_bay_num.Tables(0).Rows(bay_start - 1).Item("joint"))
                'End If
                '写bay号，判断是否通贝的情况
                If (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) >= 0 Then
                    If myDataView(bay_start - 1).Item("joint") = 1 Then '取出要处理的当前BAY_ Then
                        If CType(ship_bay_num, Integer) Mod 2 = 0 Then
                            '偶数bay
                            g.DrawString(ship_bay_num, bay_f, Brushes.Black, distoleft + (big_col - small_col + 1 + 1) / 2 * RectBorder - 1, distotop + CInt(RectBorder / 2) - 5)
                        Else
                            If CType(ship_bay_num, Integer) + 1 < 10 Then
                                g.DrawString(ship_bay_num & "(0" & ship_bay_num + 1 & ")", bay_f, Brushes.Black, distoleft + (big_col - small_col + 1 + 1) / 2 * RectBorder - 13, distotop + CInt(RectBorder / 2) - 5)
                            Else
                                g.DrawString(ship_bay_num & "(" & ship_bay_num + 1 & ")", bay_f, Brushes.Black, distoleft + (big_col - small_col + 1 + 1) / 2 * RectBorder - 13, distotop + CInt(RectBorder / 2) - 5)
                            End If
                        End If
                    Else
                        g.DrawString(ship_bay_num, bay_f, Brushes.Black, distoleft + (big_col - small_col + 1 + 1) / 2 * RectBorder - 1, distotop + CInt(RectBorder / 2) - 5)
                    End If
                Else
                    If myDataView(bay_start - 1).Item("joint") = 1 Then '取出要处理的当前BAY_ Thends_bay_num.Tables(0).Rows(bay_start - 1)
                        If CType(ship_bay_num, Integer) < 10 Then
                            g.DrawString(ship_bay_num & "(0" & ship_bay_num + 1 & ")", bay_f, Brushes.Black, distoleft + (big_col_cabin - small_col_cabin + 1 + 1) / 2 * RectBorder - 13, distotop + CInt(RectBorder / 2) - 5)
                        Else
                            g.DrawString(ship_bay_num & "(" & ship_bay_num + 1 & ")", bay_f, Brushes.Black, distoleft + (big_col_cabin - small_col_cabin + 1 + 1) / 2 * RectBorder - 13, distotop + CInt(RectBorder / 2) - 5)
                        End If

                    Else
                        g.DrawString(ship_bay_num, bay_f, Brushes.Black, distoleft + (big_col_cabin - small_col_cabin + 1 + 1) / 2 * RectBorder - 1, distotop + CInt(RectBorder / 2) - 5)
                    End If

                End If

                '甲板开始
                If ds_board.Tables(0).Rows.Count > 0 Then
                    '计算甲板结果图的顶点位置
                    If (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) >= 0 Then '比较甲板和舱内的列数
                        col_count = (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) ''甲板上列数和舱内的差额
                    Else
                        col_count = 0
                    End If
                    '画甲板矩形
                    For i = small_row To big_row
                        For j = small_col To big_col
                            If ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("user_char") = 1 Then
                                g.DrawRectangle(pen_line, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col), distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1), RectBorder, RectBorder)
                            End If
                        Next
                    Next
                    '画贝层
                    For i = small_row To big_row '战位最大屏列,按行读，行坐标先变
                        bay_row = 78 + i * 2
                        g.DrawString(bay_row, f, Brushes.Black, distoleft + CInt(RectBorder / 2) - 6, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + CInt(RectBorder / 2) - 5) '贝层
                    Next

                    ''写贝列

                    n = big_col - small_col + 1
                    Dim strcon As Integer
                    strcon = 1
                    Dim strsmallcol As Integer
                    strsmallcol = small_col
                    Dim strbigcol As Integer
                    strbigcol = big_col
                    If Getdata("select * from con_bay where  v_id='" & v_id & "' and bay_num='" & ship_bay_num & "'", ds_unuse_col).Count > 0 Then
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
                        g.DrawString(bay_col, f, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + CInt(RectBorder / 2) - 6, distotop + RectBorder + RectBorder - CInt(RectBorder / 2) - 4) '贝列
                    Next j
                End If
                '甲板结束
                '画甲办和舱内中间的分割线

                g.DrawLine(pen_seperate, distoleft + RectBorder + CInt(col_count * RectBorder / 2), distotop + (maxrow_board + 1 + 1) * RectBorder + CInt(RectBorder / 2), distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (big_col - small_col + 1), distotop + (maxrow_board + 1 + 1) * RectBorder + CInt(RectBorder / 2))

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
                                g.DrawRectangle(pen_line, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin), distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1), RectBorder, RectBorder)
                            End If
                        Next j
                    Next i
                    '画贝层
                    For i = small_row_cabin To big_row_cabin '战位最大屏列,按行读，行坐标先变
                        If i * 2 < 10 Then
                            bay_row_cabin = "0" & i * 2
                        Else
                            bay_row_cabin = i * 2
                        End If
                        g.DrawString(bay_row_cabin, f, Brushes.Black, distoleft + CInt(RectBorder / 2) - 6, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + CInt(RectBorder / 2) - 5) '贝层
                    Next i
                    ''写贝列
                    n = big_col_cabin - small_col_cabin + 1
                    Dim strcon As Integer
                    strcon = 1
                    Dim strsmallcol As Integer
                    strsmallcol = small_col_cabin
                    Dim strbigcol As Integer
                    strbigcol = big_col_cabin
                    If Getdata("select * from con_bay where  v_id='" & v_id & "' and bay_num='" & ship_bay_num & "'", ds_unuse_col).Count > 0 Then
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
                        g.DrawString(bay_col_cabin, f, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) + CInt(RectBorder / 2) - 6, distotop + (maxrow_cabin + maxrow_board + 1 + 1 + 1) * RectBorder + 1)
                    Next
                End If
            Next bay_start
        Next hang
        Me.pl_facemap.Refresh()

    End Sub


    Private Sub btn_show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_show.Click
        con_ship_facemap_show(bmpgraphics_facemap)
    End Sub
End Class

