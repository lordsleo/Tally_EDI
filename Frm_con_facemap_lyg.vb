Imports TALLY.DBControl
Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.Math
Imports System.Drawing.Printing
Public Class Frm_con_facemap_lyg
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_printpreview As System.Windows.Forms.Button
    Friend WithEvents btn_pagesetup As System.Windows.Forms.Button
    Friend WithEvents btn_enter As System.Windows.Forms.Button
    Friend WithEvents btn_cancle As System.Windows.Forms.Button
    Friend WithEvents pl_facemap As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_percent As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_show As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_show = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_percent = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_printpreview = New System.Windows.Forms.Button()
        Me.btn_pagesetup = New System.Windows.Forms.Button()
        Me.btn_enter = New System.Windows.Forms.Button()
        Me.btn_cancle = New System.Windows.Forms.Button()
        Me.pl_facemap = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.btn_show, Me.Label2, Me.txt_percent, Me.Label1, Me.btn_printpreview, Me.btn_pagesetup, Me.btn_enter, Me.btn_cancle})
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(738, 64)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'btn_show
        '
        Me.btn_show.Location = New System.Drawing.Point(470, 26)
        Me.btn_show.Name = "btn_show"
        Me.btn_show.Size = New System.Drawing.Size(64, 24)
        Me.btn_show.TabIndex = 16
        Me.btn_show.Text = "��ʾͼ��"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(206, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "%"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_percent
        '
        Me.txt_percent.Location = New System.Drawing.Point(166, 28)
        Me.txt_percent.Name = "txt_percent"
        Me.txt_percent.Size = New System.Drawing.Size(38, 21)
        Me.txt_percent.TabIndex = 13
        Me.txt_percent.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(128, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "����"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_printpreview
        '
        Me.btn_printpreview.Location = New System.Drawing.Point(320, 26)
        Me.btn_printpreview.Name = "btn_printpreview"
        Me.btn_printpreview.Size = New System.Drawing.Size(64, 24)
        Me.btn_printpreview.TabIndex = 8
        Me.btn_printpreview.Text = "��ӡԤ��"
        '
        'btn_pagesetup
        '
        Me.btn_pagesetup.Location = New System.Drawing.Point(244, 26)
        Me.btn_pagesetup.Name = "btn_pagesetup"
        Me.btn_pagesetup.Size = New System.Drawing.Size(64, 24)
        Me.btn_pagesetup.TabIndex = 7
        Me.btn_pagesetup.Text = "ҳ������"
        '
        'btn_enter
        '
        Me.btn_enter.Location = New System.Drawing.Point(394, 26)
        Me.btn_enter.Name = "btn_enter"
        Me.btn_enter.Size = New System.Drawing.Size(64, 24)
        Me.btn_enter.TabIndex = 1
        Me.btn_enter.Text = "��ӡ"
        '
        'btn_cancle
        '
        Me.btn_cancle.Location = New System.Drawing.Point(544, 26)
        Me.btn_cancle.Name = "btn_cancle"
        Me.btn_cancle.Size = New System.Drawing.Size(64, 24)
        Me.btn_cancle.TabIndex = 1
        Me.btn_cancle.Text = "ȡ��"
        '
        'pl_facemap
        '
        Me.pl_facemap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pl_facemap.Location = New System.Drawing.Point(0, 64)
        Me.pl_facemap.Name = "pl_facemap"
        Me.pl_facemap.Size = New System.Drawing.Size(738, 499)
        Me.pl_facemap.TabIndex = 4
        '
        'Frm_con_facemap_lyg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(738, 563)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.pl_facemap, Me.GroupBox1})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_con_facemap_lyg"
        Me.Text = "���Ƹ�_��ͼ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    '����Ϣ
    Dim v_id As Integer '��id
    Dim ENG_VESSEL As String 'Ӣ�Ĵ���
    Dim CHI_VESSEL As String '���Ĵ���
    Dim VOYAGE As String '����
    Dim ds_ship As New DataSet() '�����ݼ�
    Dim ds_count_board As New DataSet() 'ȡ�װ�������������
    Dim ds_count_cabin As New DataSet() 'ȡ����������������
    Dim ship_col_count As Integer '��������
    Dim ship_row_count As Integer '���Ĳ���
    Dim ship_bay_count As Integer '���ı���
    Dim bay_start As Integer '��ѭ������
    Dim i, j, k As Integer '�ڲ�ѭ������
    Dim hang As Integer '����ѭ������
    Dim ds_bay_num As New DataSet() 'ȡ��Ҫ�����BAY
    Dim ship_bay_num As String '��ǰ�����BAY
    Dim distoleft As Integer  '����߾��ƶ���λ��
    Dim distotop As Integer '�ඥ�߾��ƶ���λ��
    Dim col_count As Integer '�װ�Ͳ����������
    Dim hang_bay_count As Integer '����һ���ܻ�����BAY
    Dim hang_big_bay As Integer '��ǰ�е����BAY
    Dim hang_small_bay As Integer '��ǰ�е���СBAY
    Dim n As Integer '��ǰbay�װ������ڵ�����
    Dim m As Integer 'load�ڲ�ѭ������
    Dim maxcol_board As Integer = 0
    Dim maxrow_board As Integer = 0
    Dim maxcol_cabin As Integer = 0
    Dim maxrow_cabin As Integer = 0
    Dim BAYNO As String '��λ��
    Dim BAYNO_MID As String '����-
    Dim BAYNO_MID_1 As String '����-
    Dim BAYNO_ADD As String '����+
    Dim ds_container As New DataSet
    Dim ds_container1 As New DataSet
    Dim dsjoint As New DataSet
    'ͼ��Ϣ
    Dim bmp_facemap As Bitmap
    Dim bmpgraphics_facemap As Graphics
    Dim pen_line As New Pen(Color.Black, 1)
    Dim pen_cross As New Pen(Color.Black, 0.5)
    Dim ff As New FontFamily("����") 'Arial
    Dim f As New Font(ff, 6)
    Dim bay_f As New Font(ff, 8, FontStyle.Bold)
    Dim f_container As New Font(ff, 8)
    Dim shipName As New Font(ff, 11, FontStyle.Bold) 'д����
    Dim pen_seperate As New Pen(Color.Black)
    '�װ�
    Dim ds_board_char As New DataSet()
    Dim small_row As Integer   '�װ���С��
    Dim small_col As Integer   '�װ���С��
    Dim big_row As Integer   '�װ������
    Dim big_col As Integer   '�װ������
    Dim ds_board As New DataSet()   '�װ�
    Dim bay_row As String   '�װ屴��
    Dim bay_col As String   '�װ屴��
    Dim ds_unuse_col As New DataSet()   '�װ�
    '����
    Dim ds_cabin As New DataSet()
    Dim ds_cabin_char As New DataSet()
    Dim small_row_cabin As Integer  '������С��
    Dim small_col_cabin As Integer  '������С��
    Dim big_row_cabin As Integer  '���������
    Dim big_col_cabin As Integer  '���������
    Dim bay_row_cabin As String  '���ڱ���
    Dim bay_col_cabin As String  '���ڱ���
    '��ӡ
    Dim storedpagesettings As PageSettings
    Dim pageHeight As Integer 'ҳ��ĸ߶�
    Dim pageWidth As Integer 'ҳ��Ŀ��
    Dim pageTopHeight As Integer = 20 'ҳ�涥��дע�͵ĸ߶�
    Dim pageBottomHeight As Integer = 20 'ҳ��ײ�дע�͵ĸ߶�
    Dim expandPercent As Single = 1  '��������
    Dim minRectBorder As Integer = 14 '��ͼ�Ͼ��ε���С�߳�
    Dim maxRectBorder As Integer = 20 '��ͼ�Ͼ��ε����߳�
    Dim RectBorder As Integer '��ͼ�Ͼ��εı߳�
    '''�װ��ϵ�λ��������һ��
    Dim board_change_height As Integer = 10
    Dim sShifting As String = "*" '���嵹���־

    Dim faceRowCount As Integer '��ͼ�Ͽ��ԷŵĲ���
    Dim faceColCount As Integer '��ͼ��һ�п��Էű��ı���
    Dim firstFaceBayCount As Integer '��һҳ�ŵı���
    Dim secondFaceBayCount As Integer '�ڶ�ҳ�ŵı���
    Dim pagecount As Integer = 0 'ҳ�����Ʊ���
    Dim totalBay As Integer = 0 '���ϵ���bay��
    Dim dsMorePageBayNum As New DataSet '������е�bay
    Dim ds_unload_port As New DataSet
    '*****************************
    Dim dr() As System.Data.DataRow
    Dim ds_boardr() As System.Data.DataRow
    Dim ds_cabinr() As System.Data.DataRow
    Dim dsjointr() As System.Data.DataRow
    Dim ds_unuse_colr() As System.Data.DataRow
    Dim ds_container1r() As System.Data.DataRow
    '*****************************
    Private Sub Frm_con_facemap_lyg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bmp_facemap = New Bitmap(Me.pl_facemap.Width, Me.pl_facemap.Height)
        bmpgraphics_facemap = Graphics.FromImage(bmp_facemap)
        Me.pl_facemap.BackgroundImage = bmp_facemap
        pen_line.DashStyle = DashStyle.Solid
        pen_seperate.DashStyle = DashStyle.Dot
        '���
        maxcol_board = 0
        maxrow_board = 0
        maxcol_cabin = 0
        maxrow_cabin = 0
        ExecSql("update con_image set TEMPERATURE_UNIT='' where ship_id=" & Ship_ID & " and TEMPERATURE_UNIT is null ")
        ExecSql("update con_image set DANGER_GRADE='' where ship_id=" & Ship_ID & " and DANGER_GRADE is null ")
        'д����
        If Getdata("select VESSEL_ID,VESSEL.ENG_VESSEL,VESSEL.CHI_VESSEL, sship.VOYAGE from VESSEL,sship where sship.ship_id=" & Ship_ID & " and sship.v_id=VESSEL.VESSEL_id", ds_ship).Count > 0 Then
            v_id = ds_ship.Tables(0).Rows(0).Item("VESSEL_id")
            ENG_VESSEL = ds_ship.Tables(0).Rows(0).Item("ENG_VESSEL")
            CHI_VESSEL = ds_ship.Tables(0).Rows(0).Item("CHI_VESSEL")
            VOYAGE = ds_ship.Tables(0).Rows(0).Item("VOYAGE")
            'ȡ�װ�������������
            If Getdata("select max(screen_col)-min(screen_col)+1 col_count,max(screen_row)-min(screen_row)+1 row_count,(select count(*) from con_bay where v_id='" & v_id & "' ) bay_count from con_map where v_id='" & v_id & "'and location='board' group  by bay_Num", ds_count_board).Count > 0 Then
                For m = 0 To ds_count_board.Tables(0).Rows.Count - 1
                    If ds_count_board.Tables(0).Rows(m).Item("col_count") Is System.DBNull.Value Then
                    Else
                        If ds_count_board.Tables(0).Rows(m).Item("col_count") > maxcol_board Then
                            maxcol_board = ds_count_board.Tables(0).Rows(m).Item("col_count") '�װ���������
                        End If
                    End If
                    If ds_count_board.Tables(0).Rows(m).Item("row_count") Is System.DBNull.Value Then
                    Else
                        If ds_count_board.Tables(0).Rows(m).Item("row_count") > maxrow_board Then
                            maxrow_board = ds_count_board.Tables(0).Rows(m).Item("row_count") '�װ��������
                        End If
                    End If
                Next
                ship_bay_count = ds_count_board.Tables(0).Rows(0).Item("bay_count") '���ı���
            End If
            'ȡ����������������
            If Getdata("select max(screen_col)-min(screen_col)+1 col_count,max(screen_row)-min(screen_row)+1 row_count,(select count(*) from con_bay where v_id='" & v_id & "' ) bay_count from con_map where v_id='" & v_id & "'and location='cabin'  group  by bay_Num", ds_count_cabin).Count > 0 Then
                For m = 0 To ds_count_cabin.Tables(0).Rows.Count - 1
                    If ds_count_cabin.Tables(0).Rows(m).Item("col_count") Is System.DBNull.Value Then
                    Else
                        If ds_count_cabin.Tables(0).Rows(m).Item("col_count") > maxcol_cabin Then
                            maxcol_cabin = ds_count_cabin.Tables(0).Rows(m).Item("col_count") '���ڵ��������
                        End If
                    End If
                    If ds_count_cabin.Tables(0).Rows(m).Item("row_count") Is System.DBNull.Value Then
                    Else
                        If ds_count_cabin.Tables(0).Rows(m).Item("row_count") > maxrow_cabin Then
                            maxrow_cabin = ds_count_cabin.Tables(0).Rows(m).Item("row_count") '���ڵ�������
                        End If
                    End If
                Next
                ship_bay_count = ds_count_cabin.Tables(0).Rows(0).Item("bay_count") '���ı���
                totalBay = ds_count_cabin.Tables(0).Rows(0).Item("bay_count") '���ı���
            End If
            If maxcol_board > maxcol_cabin Then
                ship_col_count = maxcol_board   '�����������
            Else
                ship_col_count = maxcol_cabin '�����������
            End If
            If maxrow_board > maxrow_cabin Then   '����������
                ship_row_count = maxrow_board '����������
            Else
                ship_row_count = maxrow_cabin  '����������
            End If
            '��ӡ��ҳ 
            Getdata("select bay_num,joint from con_bay where v_id=" & v_id & " order by bay_num", dsMorePageBayNum)   '������е�bay

            '  con_ship_facemap_show(bmpgraphics_facemap)

        End If
    End Sub

    Private Sub con_ship_facemap_show(ByVal g As Graphics)
        '���
        '  g.Clear(Me.BackColor)
        distoleft = 0
        distotop = 40
        'д���Ƹ�����
        g.DrawString("COSTACO LIANYUNGANG  ���Ƹ�����", Me.Font, Brushes.Black, 0, distotop - 10)
        'д��������
        g.DrawString("VESSEL:" & ENG_VESSEL, Me.Font, Brushes.Black, 40, distotop + 0)
        g.DrawString("VOY:" & VOYAGE, Me.Font, Brushes.Black, 300, distotop + 0)
        g.DrawString("POL��LYG", Me.Font, Brushes.Black, 600, distotop + 0)
        '�������ν���

        Getdata("select bay_num,joint from con_bay where v_id=" & v_id & " order by bay_num", ds_bay_num) 'ȡ������Ҫ�����BAY

        hang_bay_count = Fix(1024 / ((ship_col_count + 2) * 10)) 'һ�����ɵ�BAY��
        If hang_bay_count > ship_bay_count Then
            hang_big_bay = ship_bay_count '��ʼ�������BAY
        Else
            hang_big_bay = hang_bay_count
        End If
        hang_small_bay = 1 '��ʼ������Сbay
        '��ѭ����ʼ
        For hang = 1 To Fix(ship_bay_count / hang_bay_count + 0.99999)
            If hang > 1 And hang_big_bay < ship_bay_count Then
                hang_big_bay = hang_big_bay + hang_bay_count
                If hang_big_bay > ship_bay_count Then
                    hang_big_bay = ship_bay_count
                End If
                hang_small_bay = hang_small_bay + hang_bay_count
            End If
            '���м������Ƶľ���
            If hang > 1 Then
                distotop = distotop + 2 * (ship_row_count + 1 + 2) * 10
            End If
            '��BAYѭ����ʼ
            For bay_start = hang_big_bay To hang_small_bay Step -1
                ship_bay_num = ds_bay_num.Tables(0).Rows(bay_start - 1).Item("bay_num") 'ȡ��Ҫ����ĵ�ǰBAY
                '��ʼ����ǰBAY
                '�������ߺͶ����λ��
                If bay_start Mod hang_bay_count = 0 Then
                    distoleft = 0
                Else
                    distoleft = (hang_bay_count - (bay_start Mod hang_bay_count)) * 10 * (ship_col_count + 2)
                End If
                '���
                small_col = 0
                big_col = 0
                small_col_cabin = 0
                big_col_cabin = 0
                ''�װ�ȡ�װ������
                If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='board' order by id", ds_board).Count > 0 Then
                    Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='board'", ds_board_char)
                    small_row = ds_board_char.Tables(0).Rows(0).Item("small_row") 'ȡ�װ���Ļ����С��
                    big_row = ds_board_char.Tables(0).Rows(0).Item("big_row") 'ȡ�װ���Ļ�������
                    small_col = ds_board_char.Tables(0).Rows(0).Item("small_col") 'ȡ�װ���Ļ����С��
                    big_col = ds_board_char.Tables(0).Rows(0).Item("big_col") 'ȡ�װ���Ļ�������
                End If
                'ȡ���ڵ�����
                If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='cabin' order by id", ds_cabin).Count > 0 Then
                    Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='cabin'", ds_cabin_char)
                    small_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_col") 'ȡ������Ļ����С��
                    big_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_col") 'ȡ������Ļ�������
                    small_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_row") 'ȡ������Ļ����С��
                    big_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_row") 'ȡ������Ļ�������
                End If
                'дbay�ţ��ж��Ƿ�ͨ�������
                If (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) >= 0 Then
                    If ds_bay_num.Tables(0).Rows(bay_start - 1).Item("joint") = 1 Then 'ȡ��Ҫ����ĵ�ǰBAY_ Then
                        If CType(ship_bay_num, Integer) + 1 < 10 Then
                            g.DrawString(ship_bay_num & "(0" & ship_bay_num + 1 & ")", bay_f, Brushes.Black, distoleft + 5 + (big_col - small_col + 1) / 2 * 10 - 10, distotop + 10 + 5)
                        Else
                            g.DrawString(ship_bay_num & "(" & ship_bay_num + 1 & ")", bay_f, Brushes.Black, distoleft + 5 + (big_col - small_col + 1) / 2 * 10 - 10, distotop + 10 + 5)
                        End If

                    Else
                        g.DrawString(ship_bay_num, bay_f, Brushes.Black, distoleft + 15 + (big_col - small_col + 1) / 2 * 10 - 10, distotop + 10 + 5)
                    End If
                Else
                    If ds_bay_num.Tables(0).Rows(bay_start - 1).Item("joint") = 1 Then 'ȡ��Ҫ����ĵ�ǰBAY_ Then
                        If CType(ship_bay_num, Integer) + 1 < 10 Then
                            g.DrawString(ship_bay_num & "(0" & ship_bay_num + 1 & ")", bay_f, Brushes.Black, distoleft + 5 + (big_col_cabin - small_col_cabin + 1) / 2 * 10 - 10, distotop + 10 + 5)
                        Else
                            g.DrawString(ship_bay_num & "(" & ship_bay_num + 1 & ")", bay_f, Brushes.Black, distoleft + 5 + (big_col_cabin - small_col_cabin + 1) / 2 * 10 - 10, distotop + 10 + 5)
                        End If

                    Else
                        g.DrawString(ship_bay_num, bay_f, Brushes.Black, distoleft + 15 + (big_col_cabin - small_col_cabin + 1) / 2 * 10 - 10, distotop + 10 + 5)
                    End If

                End If

                '�װ忪ʼ
                If ds_board.Tables(0).Rows.Count > 0 Then
                    '����װ���ͼ�Ķ���λ��
                    If (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) >= 0 Then '�Ƚϼװ�Ͳ��ڵ�����
                        col_count = (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) ''�װ��������Ͳ��ڵĲ��
                    Else
                        col_count = 0
                    End If
                    '���װ����
                    For i = small_row To big_row
                        For j = small_col To big_col
                            If ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("user_char") = 1 Then
                                g.DrawRectangle(pen_line, distoleft + 10 + col_count * 5 + 10 * (j - small_col + 1), distotop + (ship_row_count + 1 + 2) * 10 - 10 * (i - small_row + 1) + 10, 10, 10)
                                '��λ��
                                BAYNO = ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_col") & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_row")
                                '��λ��--���ż�һ
                                If ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") + 1 < 10 Then
                                    BAYNO_ADD = "0" & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") + 1
                                Else
                                    BAYNO_ADD = ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") + 1
                                End If
                                BAYNO_ADD = BAYNO_ADD & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_col") & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_row")
                                '�жϴ� Bay �Ƿ�Ϊͨ Bay
                                dsjoint.Reset()
                                If Getdata("select * from CON_BAY where v_id='" & v_id & "' and bay_num='" & Trim(Mid(BAYNO, 1, 2)) & "' and joint='1'", dsjoint).Count = 0 Then
                                    BAYNO_ADD = "000000"
                                End If
                                '�жϴ˱�λ���������
                                If Getdata("select * from  view_conimage_lxj where  (BAYNO='" & BAYNO & "' or BAYNO='" & BAYNO_ADD & "') and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%') and ship_id=" & Ship_ID, ds_container).Count > 0 Then
                                    'ж����
                                    If ds_container.Tables(0).Rows(0).Item("substitute") Is System.DBNull.Value Then
                                    Else
                                        g.DrawString(UCase(ds_container.Tables(0).Rows(0).Item("substitute")), f_container, Brushes.Black, distoleft + 10 + col_count * 5 + 10 * (j - small_col + 1), distotop + (ship_row_count + 1 + 2) * 10 - 10 * (i - small_row + 1) + 10 + 1 - 10 + board_change_height)
                                    End If
                                    '������
                                    If ds_container.Tables(0).Rows(0).Item("FULLOREMPTY") Is System.DBNull.Value Then
                                        'Σ��Ʒ '�����
                                        If ds_container.Tables(0).Rows(0).Item("CONTAINER_TYPE") Is System.DBNull.Value Then
                                        Else
                                            If ds_container.Tables(0).Rows(0).Item("CONTAINER_TYPE") = "D" Or ds_container.Tables(0).Rows(0).Item("CONTAINER_TYPE") = "T" Or ds_container.Tables(0).Rows(0).Item("CONTAINER_TYPE") = "R" Then
                                                g.DrawString(LCase(ds_container.Tables(0).Rows(0).Item("CONTAINER_TYPE")), f_container, Brushes.Black, distoleft + 10 + col_count * 5 + 10 * (j - small_col + 1) + 3, distotop + (ship_row_count + 1 + 2) * 10 - 10 * (i - small_row + 1) + 10 + 1 - 10 + board_change_height)
                                            End If
                                        End If
                                    Else
                                        If LTrim(RTrim(ds_container.Tables(0).Rows(0).Item("FULLOREMPTY"))) = "e" Then
                                            '����
                                            g.DrawString(LCase(ds_container.Tables(0).Rows(0).Item("FULLOREMPTY")), f_container, Brushes.Black, distoleft + 10 + col_count * 5 + 10 * (j - small_col + 1) + 3, distotop + (ship_row_count + 1 + 2) * 10 - 10 * (i - small_row + 1) + 10 + 1 - 10 + board_change_height)
                                        Else
                                            'Σ��Ʒ '�����
                                            If ds_container.Tables(0).Rows(0).Item("CONTAINER_TYPE") Is System.DBNull.Value Then
                                            Else
                                                If ds_container.Tables(0).Rows(0).Item("CONTAINER_TYPE") = "D" Or ds_container.Tables(0).Rows(0).Item("CONTAINER_TYPE") = "T" Or ds_container.Tables(0).Rows(0).Item("CONTAINER_TYPE") = "R" Then
                                                    g.DrawString(LCase(ds_container.Tables(0).Rows(0).Item("CONTAINER_TYPE")), f_container, Brushes.Black, distoleft + 10 + col_count * 5 + 10 * (j - small_col + 1) + 3, distotop + (ship_row_count + 1 + 2) * 10 - 10 * (i - small_row + 1) + 10 + 1 - 10 + board_change_height)
                                                End If
                                            End If
                                        End If
                                    End If

                                    '�����־
                                    If ds_container.Tables(0).Rows(0).Item("OLDBAYNO") Is System.DBNull.Value Then
                                    Else
                                        '������
                                        g.DrawString(LCase(ds_container.Tables(0).Rows(0).Item("FULLOREMPTY")), f_container, Brushes.Black, distoleft + 10 + col_count * 5 + 10 * (j - small_col + 1) + 3, distotop + (ship_row_count + 1 + 2) * 10 - 10 * (i - small_row + 1) + 10 + 1 - 10 + board_change_height)
                                    End If
                                End If
                                '��λ��--���ż�һ
                                BAYNO_MID = ""
                                If ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") - 1 < 10 Then
                                    BAYNO_MID = "0" & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") - 1
                                    BAYNO_MID = BAYNO_MID & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_col") & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_row")
                                Else
                                    BAYNO_MID = ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") - 1
                                    BAYNO_MID = BAYNO_MID & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_col") & ds_board.Tables(0).Rows((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_row")
                                End If
                                '�жϴ� Bay �Ƿ�Ϊͨ Bay
                                BAYNO_MID_1 = Mid(Trim(BAYNO_MID), 1, 2)
                                If CType(BAYNO_MID_1, Int16) Mod 2 = 0 Then
                                    BAYNO_MID_1 = CType(BAYNO_MID_1, Int16) - 1
                                End If

                                If BAYNO_MID_1.Trim().Length = 1 Then
                                    BAYNO_MID_1 = "0" & BAYNO_MID_1.Trim()
                                End If
                                dsjoint.Reset()
                                If Getdata("select * from CON_BAY where v_id='" & v_id & "' and bay_num='" & BAYNO_MID_1 & "' and joint='1'", dsjoint).Count > 0 Then

                                    '�жϴ˱�λ���������
                                    If Len(Trim(BAYNO_MID)) > 0 Then
                                        If Getdata("select substring(ltrim(CODE_UNLOAD_PORT),1,1) CODE_UNLOAD_PORT,FULLOREMPTY,CONTAINER_TYPE from view_conimage_lxj3  where  BAYNO='" & BAYNO_MID & "' and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%') and ship_id=" & Ship_ID, ds_container).Count > 0 Then
                                            g.DrawLine(pen_cross, distoleft + 10 + col_count * 5 + 10 * (j - small_col + 1) + 1, distotop + (ship_row_count + 1 + 2) * 10 - 10 * (i - small_row + 1) + 10 + 1 - 10 + board_change_height, distoleft + 10 + col_count * 5 + 10 * (j - small_col + 1) + 9, distotop + (ship_row_count + 1 + 2) * 10 - 10 * (i - small_row + 1) + 10 + 9 - 10 + board_change_height)
                                            g.DrawLine(pen_cross, distoleft + 10 + col_count * 5 + 10 * (j - small_col + 1) + 9, distotop + (ship_row_count + 1 + 2) * 10 - 10 * (i - small_row + 1) + 10 + 1 - 10 + board_change_height, distoleft + 10 + col_count * 5 + 10 * (j - small_col + 1) + 1, distotop + (ship_row_count + 1 + 2) * 10 - 10 * (i - small_row + 1) + 10 + 9 - 10 + board_change_height)
                                        End If
                                    End If
                                End If
                            End If
                        Next
                    Next
                    '������
                    For i = small_row To big_row 'սλ�������,���ж����������ȱ�
                        bay_row = 78 + i * 2
                        g.DrawString(bay_row, f, Brushes.Black, distoleft + 9, distotop + (ship_row_count + 1 + 2) * 10 - 10 * (i - small_row + 1) + 10) '����
                    Next
                    'дbay��
                    '   g.DrawString("BAY" & ship_bay_num, bay_f, Brushes.Black, distoleft + (big_col - small_col + 1) / 2 * 10 - 10, distotop + 10)
                    ''д����

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
                            If ds_unuse_col.Tables(0).Rows(0).Item("board_unuse_col") = "�ұ�" Then
                                strbigcol = strbigcol - 1
                            Else
                                If ds_unuse_col.Tables(0).Rows(0).Item("board_unuse_col") = "���" Then
                                    strsmallcol = strsmallcol + 1
                                    strcon = 2
                                End If
                            End If
                        End If
                    End If
                    For j = strsmallcol To strbigcol   'սλ�������
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
                        g.DrawString(bay_col, f, Brushes.Black, distoleft + 10 + col_count * 5 + 10 * (j - small_col + 1), distotop + 30) '����
                    Next j
                End If
                '�װ����
                '���װ�Ͳ����м�ķָ���

                g.DrawLine(pen_seperate, distoleft + 10 + col_count * 5 + 10, distotop + (ship_row_count + 1 + 2) * 10 + 10 + 5, distoleft + 10 + col_count * 5 + 10 * (j - small_col + 1), distotop + (ship_row_count + 1 + 2) * 10 + 10 + 5)

                ''���ڿ�ʼ
                If ds_cabin.Tables(0).Rows.Count > 0 Then
                    '������ڽ��ͼ�Ķ���λ��
                    If (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) >= 0 Then
                        col_count = (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) ''�װ��������Ͳ��ڵĲ��
                    Else
                        col_count = 0
                    End If
                    ''�����ھ���
                    For i = small_row_cabin To big_row_cabin
                        For j = small_col_cabin To big_col_cabin
                            If ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("user_char") = 1 Then
                                g.DrawRectangle(pen_line, distoleft + 10 + col_count * 5 + 10 * (j - small_col_cabin + 1), distotop + (ship_row_count + 1 + 2 + 1 + 2) * 10 + (big_row_cabin - small_row_cabin + 1) * 10 - 10 * (i - small_row_cabin + 1) - 10, 10, 10) '   bmpgraphics_result_cabin.DrawRectangle(pen_line, 20 * (j - small_col_cabin + 1), 200 - 20 * (i - small_row_cabin + 1), 20, 20
                                '��λ��
                                BAYNO = ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_col") & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_row")
                                '��λ��--���ż�һ
                                If ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") + 1 < 10 Then
                                    BAYNO_ADD = "0" & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") + 1
                                Else
                                    BAYNO_ADD = ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") + 1
                                End If
                                BAYNO_ADD = BAYNO_ADD & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_col") & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_row")
                                '�жϴ� Bay �Ƿ�Ϊͨ Bay
                                dsjoint.Reset()
                                If Getdata("select * from CON_BAY where v_id='" & v_id & "' and bay_num='" & Trim(Mid(BAYNO, 1, 2)) & "' and joint='1'", dsjoint).Count = 0 Then
                                    BAYNO_ADD = "000000"
                                End If
                                '�жϴ˱�λ���������
                                If Getdata("select * from view_conimage_lxj where  (BAYNO='" & BAYNO & "' or BAYNO='" & BAYNO_ADD & "') and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%') and ship_id=" & Ship_ID, ds_container).Count > 0 Then
                                    'ж����
                                    If ds_container.Tables(0).Rows(0).Item("substitute") Is System.DBNull.Value Then
                                    Else
                                        g.DrawString(UCase(ds_container.Tables(0).Rows(0).Item("substitute")), f_container, Brushes.Black, distoleft + 10 + col_count * 5 + 10 * (j - small_col_cabin + 1), distotop + (ship_row_count + 1 + 2 + 1 + 2) * 10 + (big_row_cabin - small_row_cabin + 1) * 10 - 10 * (i - small_row_cabin + 1) + 1 - 10)
                                    End If
                                    '������
                                    If ds_container.Tables(0).Rows(0).Item("FULLOREMPTY") Is System.DBNull.Value Then
                                        'Σ��Ʒ
                                        If ds_container.Tables(0).Rows(0).Item("CONTAINER_TYPE") Is System.DBNull.Value Then
                                        Else
                                            If ds_container.Tables(0).Rows(0).Item("CONTAINER_TYPE") = "D" Or ds_container.Tables(0).Rows(0).Item("CONTAINER_TYPE") = "T" Or ds_container.Tables(0).Rows(0).Item("CONTAINER_TYPE") = "R" Then
                                                g.DrawString(LCase(ds_container.Tables(0).Rows(0).Item("CONTAINER_TYPE")), f_container, Brushes.Black, distoleft + 10 + col_count * 5 + 10 * (j - small_col_cabin + 1) + 3, distotop + (ship_row_count + 1 + 2 + 1 + 2) * 10 + (big_row_cabin - small_row_cabin + 1) * 10 - 10 * (i - small_row_cabin + 1) + 1 - 10)
                                            End If
                                        End If
                                    Else
                                        If LTrim(RTrim(ds_container.Tables(0).Rows(0).Item("FULLOREMPTY"))) = "e" Then
                                            '����
                                            g.DrawString(LCase(ds_container.Tables(0).Rows(0).Item("FULLOREMPTY")), f_container, Brushes.Black, distoleft + 10 + col_count * 5 + 10 * (j - small_col_cabin + 1) + 3, distotop + (ship_row_count + 1 + 2 + 1 + 2) * 10 + (big_row_cabin - small_row_cabin + 1) * 10 - 10 * (i - small_row_cabin + 1) + 1 - 10)
                                        Else
                                            'Σ��Ʒ
                                            If ds_container.Tables(0).Rows(0).Item("CONTAINER_TYPE") Is System.DBNull.Value Then
                                            Else
                                                If ds_container.Tables(0).Rows(0).Item("CONTAINER_TYPE") = "D" Or ds_container.Tables(0).Rows(0).Item("CONTAINER_TYPE") = "T" Or ds_container.Tables(0).Rows(0).Item("CONTAINER_TYPE") = "R" Then
                                                    g.DrawString(LCase(ds_container.Tables(0).Rows(0).Item("CONTAINER_TYPE")), f_container, Brushes.Black, distoleft + 10 + col_count * 5 + 10 * (j - small_col_cabin + 1) + 3, distotop + (ship_row_count + 1 + 2 + 1 + 2) * 10 + (big_row_cabin - small_row_cabin + 1) * 10 - 10 * (i - small_row_cabin + 1) + 1 - 10)
                                                End If
                                            End If
                                        End If
                                    End If

                                    '�����
                                    '�����־
                                    If ds_container.Tables(0).Rows(0).Item("OLDBAYNO") Is System.DBNull.Value Then
                                    Else
                                        '����
                                        g.DrawString(LCase(ds_container.Tables(0).Rows(0).Item("FULLOREMPTY")), f_container, Brushes.Black, distoleft + 10 + col_count * 5 + 10 * (j - small_col_cabin + 1) + 3, distotop + (ship_row_count + 1 + 2 + 1 + 2) * 10 + (big_row_cabin - small_row_cabin + 1) * 10 - 10 * (i - small_row_cabin + 1) + 1 - 10)
                                    End If
                                End If
                                '��λ��--���ż�һ
                                If ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") - 1 < 10 Then
                                    BAYNO_MID = "0" & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") - 1
                                    BAYNO_MID = BAYNO_MID & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_col") & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_row")
                                Else
                                    BAYNO_MID = ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") - 1
                                    BAYNO_MID = BAYNO_MID & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_col") & ds_cabin.Tables(0).Rows((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_row")
                                End If
                                '�жϴ� Bay �Ƿ�Ϊͨ Bay
                                BAYNO_MID_1 = Mid(Trim(BAYNO_MID), 1, 2)
                                If CType(BAYNO_MID_1, Int16) Mod 2 = 0 Then
                                    BAYNO_MID_1 = CType(BAYNO_MID_1, Int16) - 1
                                End If

                                If BAYNO_MID_1.Trim().Length = 1 Then
                                    BAYNO_MID_1 = "0" & BAYNO_MID_1.Trim()
                                End If
                                dsjoint.Reset()
                                If Getdata("select * from CON_BAY where v_id='" & v_id & "' and bay_num='" & BAYNO_MID_1 & "' and joint='1'", dsjoint).Count > 0 Then

                                    '�жϴ˱�λ���������
                                    If Getdata("select substring(ltrim(CODE_UNLOAD_PORT),1,1) CODE_UNLOAD_PORT,FULLOREMPTY,CONTAINER_TYPE from view_conimage_lxj3 where  BAYNO='" & BAYNO_MID & "' and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%') and ship_id=" & Ship_ID, ds_container).Count > 0 Then
                                        g.DrawLine(pen_cross, distoleft + 10 + col_count * 5 + 10 * (j - small_col_cabin + 1) + 1, distotop + (ship_row_count + 1 + 2 + 1 + 2) * 10 + (big_row_cabin - small_row_cabin + 1) * 10 - 10 * (i - small_row_cabin + 1) + 1 - 10, distoleft + 10 + col_count * 5 + 10 * (j - small_col_cabin + 1) + 9, distotop + (ship_row_count + 1 + 2 + 1 + 2) * 10 + (big_row_cabin - small_row_cabin + 1) * 10 - 10 * (i - small_row_cabin + 1) + 9 - 10)
                                        g.DrawLine(pen_cross, distoleft + 10 + col_count * 5 + 10 * (j - small_col_cabin + 1) + 9, distotop + (ship_row_count + 1 + 2 + 1 + 2) * 10 + (big_row_cabin - small_row_cabin + 1) * 10 - 10 * (i - small_row_cabin + 1) + 1 - 10, distoleft + 10 + col_count * 5 + 10 * (j - small_col_cabin + 1) + 1, distotop + (ship_row_count + 1 + 2 + 1 + 2) * 10 + (big_row_cabin - small_row_cabin + 1) * 10 - 10 * (i - small_row_cabin + 1) + 9 - 10)
                                    End If
                                End If
                            End If
                        Next j
                    Next i
                    '������
                    For i = small_row_cabin To big_row_cabin 'սλ�������,���ж����������ȱ�
                        If i * 2 < 10 Then
                            bay_row_cabin = "0" & i * 2
                        Else
                            bay_row_cabin = i * 2
                        End If
                        g.DrawString(bay_row_cabin, f, Brushes.Black, distoleft + 9, distotop + (ship_row_count + 1 + 2 + 1 + 2) * 10 + (big_row_cabin - small_row_cabin + 1 + 1) * 10 - 10 * (i - small_row_cabin + 1) - 10 - 10)  '����
                    Next i
                    ''д����
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
                            If ds_unuse_col.Tables(0).Rows(0).Item("cabin_unuse_col") = "�ұ�" Then
                                strbigcol = strbigcol - 1
                            Else
                                If ds_unuse_col.Tables(0).Rows(0).Item("cabin_unuse_col") = "���" Then
                                    strsmallcol = strsmallcol + 1
                                    strcon = 2
                                End If
                            End If
                        End If
                    End If
                    For j = strsmallcol To strbigcol   'սλ�������
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
                        g.DrawString(bay_col_cabin, f, Brushes.Black, distoleft + 10 + col_count * 5 + 10 * (j - small_col_cabin + 1), distotop + (ship_row_count + 1 + 2 + 2) * 10 + +(ship_row_count) * 10)  '����
                    Next
                End If
            Next bay_start
        Next hang
        Me.pl_facemap.Refresh()
    End Sub


    Private Sub con_ship_facemap_print(ByVal g As Graphics)
        '��������䡢Σ��Ʒ��־
        Dim dMark As Integer = 0
        Dim rMark As Integer = 0
        Dim rdMark As Integer = 0
        '��������־
        Dim eMark As Integer = 0
        '���嵹���־shifting
        Dim sMark As Integer = 0
        '���
        '  g.Clear(Me.BackColor)
        distoleft = 0
        distotop = 60
        'д����
        g.DrawString("STOWAGE  PLAN", shipName, Brushes.Black, CInt(pageWidth / 2) - 50, distotop - 30)
        'д���Ƹ�����
        g.DrawString("COSTACO LIANYUNGANG  ���Ƹ�����", Me.Font, Brushes.Black, distoleft + 0, distotop - 10)
        'д��������
        g.DrawString("VESSEL:" & ENG_VESSEL, Me.Font, Brushes.Black, distoleft + 40 + 190, distotop - 10)
        g.DrawString("VOY:" & VOYAGE, Me.Font, Brushes.Black, distoleft + 40 + 450, distotop - 10)
        g.DrawString("POL��LYG", Me.Font, Brushes.Black, distoleft + 40 + 600, distotop - 10)
        g.DrawString("DATE:" & DatePart(DateInterval.Year, Today()) & "-" & IIf(DatePart(DateInterval.Month, Today()) < 10, "0" & DatePart(DateInterval.Month, Today()), DatePart(DateInterval.Month, Today())) & "-" & IIf(DatePart(DateInterval.Day, Today()) < 10, "0" & DatePart(DateInterval.Day, Today()), DatePart(DateInterval.Day, Today())), Me.Font, Brushes.Black, distoleft + 40 + 20 + 750, distotop - 10)
        '�������ν���

        Getdata("select bay_num,joint from con_bay where v_id=" & v_id & " order by bay_num", ds_bay_num) 'ȡ������Ҫ�����BAY

        hang_bay_count = Fix(pageWidth / ((ship_col_count + 1) * RectBorder)) 'һ�����ɵ�BAY��
        If hang_bay_count > ship_bay_count Then
            hang_big_bay = ship_bay_count '��ʼ�������BAY
        Else
            hang_big_bay = hang_bay_count
        End If
        hang_small_bay = 1 '��ʼ������Сbay
        '��ѭ����ʼ
        For hang = 1 To Ceiling(ship_bay_count / hang_bay_count)
            If hang > 1 And hang_big_bay < ship_bay_count Then
                hang_big_bay = hang_big_bay + hang_bay_count
                If hang_big_bay > ship_bay_count Then
                    hang_big_bay = ship_bay_count
                End If
                hang_small_bay = hang_small_bay + hang_bay_count
            End If
            '���м������Ƶľ���
            If hang > 1 Then
                distotop = distotop + (maxrow_board + maxrow_cabin + 1 + 1 + 1 + 1) * RectBorder
            End If
            '��BAYѭ����ʼ
            For bay_start = hang_big_bay To hang_small_bay Step -1
                ship_bay_num = ds_bay_num.Tables(0).Rows(bay_start - 1).Item("bay_num") 'ȡ��Ҫ����ĵ�ǰBAY
                '��ʼ����ǰBAY
                '�������ߺͶ����λ��
                If bay_start Mod hang_bay_count = 0 Then
                    distoleft = 0
                Else
                    distoleft = (hang_bay_count - (bay_start Mod hang_bay_count)) * RectBorder * (ship_col_count + 1)
                End If
                '���
                small_col = 0
                big_col = 0
                small_col_cabin = 0
                big_col_cabin = 0
                ''�װ�ȡ�װ������
                ds_boardr = ds_board.Tables(0).Select("bay_num='" & ship_bay_num & "'")
                If ds_boardr.Length() > 0 Then
                    'If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='board' order by id", ds_board).Count > 0 Then
                    Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='board'", ds_board_char)
                    small_row = ds_board_char.Tables(0).Rows(0).Item("small_row") 'ȡ�װ���Ļ����С��
                    big_row = ds_board_char.Tables(0).Rows(0).Item("big_row") 'ȡ�װ���Ļ�������
                    small_col = ds_board_char.Tables(0).Rows(0).Item("small_col") 'ȡ�װ���Ļ����С��
                    big_col = ds_board_char.Tables(0).Rows(0).Item("big_col") 'ȡ�װ���Ļ�������
                End If
                'ȡ���ڵ�����

                ds_cabinr = ds_cabin.Tables(0).Select("bay_num='" & ship_bay_num & "'")
                If ds_cabinr.Length() > 0 Then
                    'If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='cabin' order by id", ds_cabin).Count > 0 Then
                    Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='cabin'", ds_cabin_char)
                    small_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_col") 'ȡ������Ļ����С��
                    big_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_col") 'ȡ������Ļ�������
                    small_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_row") 'ȡ������Ļ����С��
                    big_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_row") 'ȡ������Ļ�������
                End If
                'дbay�ţ��ж��Ƿ�ͨ�������
                If (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) >= 0 Then
                    If ds_bay_num.Tables(0).Rows(bay_start - 1).Item("joint") = 1 Then 'ȡ��Ҫ����ĵ�ǰBAY_ Then
                        'ż��bay
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
                    If ds_bay_num.Tables(0).Rows(bay_start - 1).Item("joint") = 1 Then 'ȡ��Ҫ����ĵ�ǰBAY_ Then
                        If CType(ship_bay_num, Integer) < 10 Then
                            g.DrawString(ship_bay_num & "(0" & ship_bay_num + 1 & ")", bay_f, Brushes.Black, distoleft + (big_col_cabin - small_col_cabin + 1 + 1) / 2 * RectBorder - 13, distotop + CInt(RectBorder / 2) - 5)
                        Else
                            g.DrawString(ship_bay_num & "(" & ship_bay_num + 1 & ")", bay_f, Brushes.Black, distoleft + (big_col_cabin - small_col_cabin + 1 + 1) / 2 * RectBorder - 13, distotop + CInt(RectBorder / 2) - 5)
                        End If

                    Else
                        g.DrawString(ship_bay_num, bay_f, Brushes.Black, distoleft + (big_col_cabin - small_col_cabin + 1 + 1) / 2 * RectBorder - 1, distotop + CInt(RectBorder / 2) - 5)
                    End If

                End If

                '�װ忪ʼ
                If ds_boardr.Length() > 0 Then
                    '����װ���ͼ�Ķ���λ��
                    If (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) >= 0 Then '�Ƚϼװ�Ͳ��ڵ�����
                        col_count = (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) ''�װ��������Ͳ��ڵĲ��
                    Else
                        col_count = 0
                    End If
                    '���װ����
                    For i = small_row To big_row
                        For j = small_col To big_col
                            If ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("user_char") = 1 Then
                                g.DrawRectangle(pen_line, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col), distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1), RectBorder, RectBorder)
                                '��λ��
                                BAYNO = ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") & ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_col") & ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_row")
                                '��λ��--���ż�һ
                                If ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") + 1 < 10 Then
                                    BAYNO_ADD = "0" & ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") + 1
                                Else
                                    BAYNO_ADD = ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") + 1
                                End If
                                BAYNO_ADD = BAYNO_ADD & ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_col") & ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_row")
                                '�жϴ� Bay �Ƿ�Ϊͨ Bay
                                dsjointr = dsjoint.Tables(0).Select("bay_num='" & Trim(Mid(BAYNO, 1, 2)) & "'")
                                If dsjointr.Length() = 0 Then
                                    'If Getdata("select * from CON_BAY where v_id='" & v_id & "' and bay_num='" & Trim(Mid(BAYNO, 1, 2)) & "' and joint='1'", dsjoint).Count = 0 Then
                                    BAYNO_ADD = "000000"
                                End If
                                '�жϴ˱�λ���������----lxj�޸���ͼ
                                dr = ds_container.Tables(0).Select("BAYNO='" & BAYNO & "' or BAYNO='" & BAYNO_ADD & "'")
                                If dr.Length() > 0 Then
                                    'If Getdata("select * from view_conimage_lxj  where  (BAYNO='" & BAYNO & "' or BAYNO='" & BAYNO_ADD & "') and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%') and ship_id=" & Ship_ID, ds_container).Count > 0 Then
                                    'ж����
                                    If dr(0).Item("substitute") Is System.DBNull.Value Then
                                    Else
                                        g.DrawString(UCase(dr(0).Item("substitute")), f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) - 1, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + 1)
                                    End If
                                    '�����־
                                    If dr(0).Item("moved") = 0 Then

                                        '������
                                        If dr(0).Item("FULLOREMPTY") Is System.DBNull.Value Then
                                            If Len(dr(0).Item("TEMPERATURE_UNIT")) > 0 And Len(dr(0).Item("DANGER_GRADE")) > 0 Then
                                                rdMark = 1
                                                g.DrawString("k", f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + 6, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + 1)

                                            Else
                                                If Len(dr(0).Item("DANGER_GRADE")) > 0 Then
                                                    dMark = 1
                                                    g.DrawString("d", f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + 6, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + 1)
                                                End If


                                                '�����

                                                If Len(dr(0).Item("TEMPERATURE_UNIT")) > 0 Then
                                                    rMark = 1
                                                    g.DrawString("r", f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + 6, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + 1)
                                                End If
                                            End If
                                        Else
                                            If LCase(LTrim(RTrim(dr(0).Item("FULLOREMPTY")))) = "e" Then
                                                '����
                                                eMark = 1
                                                g.DrawString(LCase(dr(0).Item("FULLOREMPTY")), f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + 6, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + 1)
                                            Else
                                                'Σ��Ʒ 
                                                If Len(dr(0).Item("TEMPERATURE_UNIT")) > 0 And Len(dr(0).Item("DANGER_GRADE")) > 0 Then
                                                    rdMark = 1
                                                    g.DrawString("k", f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + 6, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + 1)

                                                Else
                                                    If Len(dr(0).Item("DANGER_GRADE")) > 0 Then
                                                        dMark = 1
                                                        g.DrawString("d", f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + 6, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + 1)
                                                    End If

                                                    '�����

                                                    If Len(dr(0).Item("TEMPERATURE_UNIT")) > 0 Then
                                                        rMark = 1
                                                        g.DrawString("r", f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + 6, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + 1)
                                                    End If
                                                End If
                                            End If
                                        End If

                                        ''�����־
                                        'If ds_container.Tables(0).Rows(0).Item("OLDBAYNO") Is System.DBNull.Value Then
                                    Else
                                        '�����־
                                        sMark = 1
                                        g.DrawString(sShifting, f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + 6, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + 1)
                                    End If
                                End If
                                '��λ��--���ż�һ
                                BAYNO_MID = ""
                                If ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") - 1 < 10 Then
                                    BAYNO_MID = "0" & ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") - 1
                                    BAYNO_MID = BAYNO_MID & ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_col") & ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_row")
                                Else
                                    BAYNO_MID = ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") - 1
                                    BAYNO_MID = BAYNO_MID & ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_col") & ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_row")
                                End If
                                '�жϴ� Bay �Ƿ�Ϊͨ Bay
                                BAYNO_MID_1 = Mid(Trim(BAYNO_MID), 1, 2)
                                If CType(BAYNO_MID_1, Int16) Mod 2 = 0 Then
                                    BAYNO_MID_1 = CType(BAYNO_MID_1, Int16) - 1
                                End If

                                If BAYNO_MID_1.Trim().Length = 1 Then
                                    BAYNO_MID_1 = "0" & BAYNO_MID_1.Trim()
                                End If
                                dsjointr = dsjoint.Tables(0).Select("bay_num='" & BAYNO_MID_1 & "'")
                                If dsjointr.Length() > 0 Then
                                    'If Getdata("select * from CON_BAY where v_id='" & v_id & "' and bay_num='" & BAYNO_MID_1 & "' and joint='1'", dsjoint).Count > 0 Then

                                    '�жϴ˱�λ���������
                                    If Len(Trim(BAYNO_MID)) > 0 Then
                                        ds_container1r = ds_container1.Tables(0).Select("BAYNO='" & BAYNO_MID & "'")
                                        If ds_container1r.Length() > 0 Then
                                            'If Getdata("select substring(ltrim(CODE_UNLOAD_PORT),1,1) CODE_UNLOAD_PORT,FULLOREMPTY,CONTAINER_TYPE from view_conimage_lxj3 where  BAYNO='" & BAYNO_MID & "' and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%') and ship_id=" & Ship_ID, ds_container1).Count > 0 Then
                                            g.DrawLine(pen_cross, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + 1, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + 1, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + RectBorder - 1, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + RectBorder - 1)
                                            g.DrawLine(pen_cross, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + 1, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + RectBorder - 1, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + RectBorder - 1, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) - 1)
                                        End If
                                    End If
                                End If
                            End If
                        Next
                    Next
                    '������
                    For i = small_row To big_row 'սλ�������,���ж����������ȱ�
                        bay_row = 78 + i * 2
                        g.DrawString(bay_row, f, Brushes.Black, distoleft + CInt(RectBorder / 2) - 6, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + CInt(RectBorder / 2) - 5)  '����
                    Next
                    'дbay��
                    '   g.DrawString("BAY" & ship_bay_num, bay_f, Brushes.Black, distoleft + (big_col - small_col + 1) / 2 * 10 - 10, distotop + 10)
                    ''д����

                    n = big_col - small_col + 1
                    Dim strcon As Integer
                    strcon = 1
                    Dim strsmallcol As Integer
                    strsmallcol = small_col
                    Dim strbigcol As Integer
                    strbigcol = big_col
                    ds_unuse_colr = ds_unuse_col.Tables(0).Select("bay_num='" & ship_bay_num & "'")
                    If ds_unuse_colr.Length() > 0 Then
                        'If Getdata("select * from con_bay where  v_id='" & v_id & "' and bay_num='" & ship_bay_num & "'", ds_unuse_col).Count > 0 Then
                        If ds_unuse_colr(0).Item("board_unuse_col") Is System.DBNull.Value Then

                        Else
                            If ds_unuse_colr(0).Item("board_unuse_col") = "�ұ�" Then
                                strbigcol = strbigcol - 1
                            Else
                                If ds_unuse_colr(0).Item("board_unuse_col") = "���" Then
                                    strsmallcol = strsmallcol + 1
                                    strcon = 2
                                End If
                            End If
                        End If
                    End If
                    For j = strsmallcol To strbigcol   'սλ�������
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
                        g.DrawString(bay_col, f, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + CInt(RectBorder / 2) - 6, distotop + RectBorder + RectBorder - CInt(RectBorder / 2) - 4) '����
                    Next j
                End If
                '�װ����
                '���װ�Ͳ����м�ķָ���

                g.DrawLine(pen_seperate, distoleft + RectBorder + CInt(col_count * RectBorder / 2), distotop + (maxrow_board + 1 + 1) * RectBorder + CInt(RectBorder / 2), distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (big_col - small_col + 1), distotop + (maxrow_board + 1 + 1) * RectBorder + CInt(RectBorder / 2))

                ''���ڿ�ʼ
                If ds_cabinr.Length() > 0 Then
                    '������ڽ��ͼ�Ķ���λ��
                    If (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) >= 0 Then
                        col_count = (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) ''�װ��������Ͳ��ڵĲ��
                    Else
                        col_count = 0
                    End If
                    ''�����ھ���
                    For i = small_row_cabin To big_row_cabin
                        For j = small_col_cabin To big_col_cabin
                            If ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("user_char") = 1 Then
                                g.DrawRectangle(pen_line, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin), distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1), RectBorder, RectBorder)
                                '��λ��
                                BAYNO = ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") & ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_col") & ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_row")
                                '��λ��--���ż�һ
                                If ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") + 1 < 10 Then
                                    BAYNO_ADD = "0" & ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") + 1
                                Else
                                    BAYNO_ADD = ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") + 1
                                End If
                                BAYNO_ADD = BAYNO_ADD & ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_col") & ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_row")
                                '�жϴ� Bay �Ƿ�Ϊͨ Bay
                                dsjointr = dsjoint.Tables(0).Select("bay_num='" & Trim(Mid(BAYNO, 1, 2)) & "'")
                                If dsjointr.Length() = 0 Then
                                    'If Getdata("select * from CON_BAY where v_id='" & v_id & "' and bay_num='" & Trim(Mid(BAYNO, 1, 2)) & "' and joint='1'", dsjoint).Count = 0 Then
                                    BAYNO_ADD = "000000"
                                End If
                                '�жϴ˱�λ���������----lxj�޸���ͼ
                                dr = ds_container.Tables(0).Select("BAYNO='" & BAYNO & "' or BAYNO='" & BAYNO_ADD & "'")
                                If dr.Length() > 0 Then
                                    'If Getdata("select * from view_conimage_lxj  where  (BAYNO='" & BAYNO & "' or BAYNO='" & BAYNO_ADD & "') and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%') and ship_id=" & Ship_ID, ds_container).Count > 0 Then
                                    'ж����
                                    If dr(0).Item("substitute") Is System.DBNull.Value Then
                                    Else
                                        g.DrawString(UCase(dr(0).Item("substitute")), f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) - 1, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + 1)
                                    End If
                                    '�����־
                                    If dr(0).Item("moved") = 0 Then
                                        '������
                                        If dr(0).Item("FULLOREMPTY") Is System.DBNull.Value Then
                                            '�����
                                            If Len(dr(0).Item("TEMPERATURE_UNIT")) > 0 And Len(dr(0).Item("DANGER_GRADE")) > 0 Then
                                                rdMark = 1
                                                g.DrawString("k", f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) + 6, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + 1)
                                            Else
                                                If Len(dr(0).Item("TEMPERATURE_UNIT")) > 0 Then
                                                    rMark = 1
                                                    g.DrawString("r", f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) + 6, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + 1)
                                                End If
                                                'Σ��Ʒ
                                                If Len(dr(0).Item("DANGER_GRADE")) > 0 Then
                                                    rMark = 1
                                                    g.DrawString("d", f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) + 6, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + 1)
                                                End If
                                            End If
                                        Else
                                            If LCase(LTrim(RTrim(dr(0).Item("FULLOREMPTY")))) = "e" Then
                                                '����
                                                eMark = 1
                                                g.DrawString(LCase(dr(0).Item("FULLOREMPTY")), f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) + 6, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + 1)
                                            Else
                                                '�����
                                                If Len(dr(0).Item("TEMPERATURE_UNIT")) > 0 And Len(dr(0).Item("DANGER_GRADE")) > 0 Then
                                                    rdMark = 1
                                                    g.DrawString("k", f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) + 6, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + 1)
                                                Else
                                                    If Len(dr(0).Item("TEMPERATURE_UNIT")) > 0 Then
                                                        rMark = 1
                                                        g.DrawString("r", f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) + 6, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + 1)
                                                    End If
                                                    'Σ��Ʒ
                                                    If Len(dr(0).Item("DANGER_GRADE")) > 0 Then
                                                        rMark = 1
                                                        g.DrawString("d", f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) + 6, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + 1)
                                                    End If
                                                End If
                                            End If
                                        End If
                                        '�����
                                        ''�����־
                                        'If ds_container.Tables(0).Rows(0).Item("OLDBAYNO") Is System.DBNull.Value Then
                                    Else
                                        '�����־
                                        sMark = 1
                                        g.DrawString(sShifting, f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) + 6, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + 1)
                                    End If
                                End If
                                '��λ��--���ż�һ
                                If ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") - 1 < 10 Then
                                    BAYNO_MID = "0" & ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") - 1
                                    BAYNO_MID = BAYNO_MID & ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_col") & ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_row")
                                Else
                                    BAYNO_MID = ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") - 1
                                    BAYNO_MID = BAYNO_MID & ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_col") & ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_row")
                                End If
                                '�жϴ� Bay �Ƿ�Ϊͨ Bay
                                BAYNO_MID_1 = Mid(Trim(BAYNO_MID), 1, 2)
                                If CType(BAYNO_MID_1, Int16) Mod 2 = 0 Then
                                    BAYNO_MID_1 = CType(BAYNO_MID_1, Int16) - 1
                                End If
                                If BAYNO_MID_1.Trim().Length = 1 Then
                                    BAYNO_MID_1 = "0" & BAYNO_MID_1.Trim()
                                End If
                                dsjointr = dsjoint.Tables(0).Select("bay_num='" & BAYNO_MID_1 & "'")
                                If dsjointr.Length() > 0 Then
                                    'If Getdata("select * from CON_BAY where v_id='" & v_id & "' and bay_num='" & BAYNO_MID_1 & "' and joint='1'", dsjoint).Count > 0 Then

                                    '�жϴ˱�λ���������
                                    ds_container1r = ds_container1.Tables(0).Select("BAYNO='" & BAYNO_MID & "'")
                                    If ds_container1r.Length() > 0 Then
                                        'If Getdata("select substring(ltrim(CODE_UNLOAD_PORT),1,1) CODE_UNLOAD_PORT,FULLOREMPTY,CONTAINER_TYPE from view_conimage_lxj3 where  BAYNO='" & BAYNO_MID & "' and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%') and ship_id=" & Ship_ID, ds_container1).Count > 0 Then
                                        g.DrawLine(pen_cross, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) + 1, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + 1, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) + RectBorder - 1, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + RectBorder - 1)
                                        g.DrawLine(pen_cross, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) + 1, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + RectBorder - 1, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) + RectBorder - 1, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + 1)
                                    End If
                                End If
                            End If
                        Next j
                    Next i
                    '������
                    For i = small_row_cabin To big_row_cabin 'սλ�������,���ж����������ȱ�
                        If i * 2 < 10 Then
                            bay_row_cabin = "0" & i * 2
                        Else
                            bay_row_cabin = i * 2
                        End If
                        g.DrawString(bay_row_cabin, f, Brushes.Black, distoleft + CInt(RectBorder / 2) - 6, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + CInt(RectBorder / 2) - 5) '����
                    Next i
                    ''д����
                    n = big_col_cabin - small_col_cabin + 1
                    Dim strcon As Integer
                    strcon = 1
                    Dim strsmallcol As Integer
                    strsmallcol = small_col_cabin
                    Dim strbigcol As Integer
                    strbigcol = big_col_cabin
                    ds_unuse_colr = ds_unuse_col.Tables(0).Select("bay_num='" & ship_bay_num & "'")
                    If ds_unuse_colr.Length() > 0 Then
                        'If Getdata("select * from con_bay where  v_id='" & v_id & "' and bay_num='" & ship_bay_num & "'", ds_unuse_col).Count > 0 Then
                        If ds_unuse_colr(0).Item("cabin_unuse_col") Is System.DBNull.Value Then

                        Else
                            If ds_unuse_colr(0).Item("cabin_unuse_col") = "�ұ�" Then
                                strbigcol = strbigcol - 1
                            Else
                                If ds_unuse_colr(0).Item("cabin_unuse_col") = "���" Then
                                    strsmallcol = strsmallcol + 1
                                    strcon = 2
                                End If
                            End If
                        End If
                    End If
                    For j = strsmallcol To strbigcol   'սλ�������
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
        'д������һ��ж���۵�ע��
        Dim unload_port_count As Integer
        unload_port_count = 0
        For unload_port_count = 0 To ds_unload_port.Tables(0).DefaultView.Count - 1
            g.DrawString(ds_unload_port.Tables(0).Rows(unload_port_count).Item("substitute") & " : " & ds_unload_port.Tables(0).Rows(unload_port_count).Item("code_unload_port"), f, Brushes.Black, unload_port_count * 50, pageHeight + 20)
        Next
        If eMark = 1 Then '����
            g.DrawString("e : empty", f, Brushes.Black, (unload_port_count) * 50, pageHeight + 20)
        End If
        If sMark = 1 Then '����
            g.DrawString(sShifting & " : shifting", f, Brushes.Black, (unload_port_count) * 50 + eMark * 50, pageHeight + 20)
        End If
        If rMark = 1 Then '�����
            g.DrawString("r : reefer", f, Brushes.Black, (unload_port_count) * 50 + eMark * 50 + sMark * 60, pageHeight + 20)
        End If
        If dMark = 1 Then 'Σ��Ʒ
            g.DrawString("d : dangerous", f, Brushes.Black, (unload_port_count) * 50 + eMark * 50 + sMark * 60 + rMark * 60, pageHeight + 20)
        End If
        If rdMark = 1 Then '����� Σ��Ʒ
            g.DrawString("k : reefer&dangerous", f, Brushes.Black, (unload_port_count) * 50 + eMark * 50 + sMark * 60 + rMark * 60 + dMark * 60, pageHeight + 20)
        End If
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
            '***********************
            ds_container.Reset()
            Getdata("select * from view_conimage_lxj where (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%') and ship_id=" & Ship_ID, ds_container)
            ds_board.Reset()
            Getdata("select * from con_map where v_id='" & v_id & "' and location='board' order by id", ds_board)
            ds_cabin.Reset()
            Getdata("select * from con_map where v_id='" & v_id & "' and location='cabin' order by id", ds_cabin)
            dsjoint.Reset()
            Getdata("select * from CON_BAY where v_id='" & v_id & "' and joint='1'", dsjoint)
            ds_unuse_col.Reset()
            Getdata("select * from con_bay where  v_id='" & v_id & "'", ds_unuse_col)
            ds_container1.Reset()
            Getdata("select * from view_conimage_lxj3 where (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%') and ship_id=" & Ship_ID, ds_container1)
            ds_unload_port.Reset()
            Getdata("select distinct con_unload_port_substitute.code_unload_port,substitute from con_unload_port_substitute , con_image where con_unload_port_substitute.ship_id=con_image.ship_id and (con_image.CODE_LOAD_PORT like '%lyg%' or con_image.CODE_UNLOAD_PORT like '%lyg%') and right(con_image.code_Unload_port,3)=right(con_unload_port_substitute.code_unload_port,3) and con_unload_port_substitute.ship_id=" & Ship_ID, ds_unload_port)

            '************************
            ship_bay_count = totalBay '���ı���
            Dim pd As New PrintDocument
            '   pd.DefaultPageSettings.Landscape = True
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
            '***********************
            ds_container.Reset()
            Getdata("select * from view_conimage_lxj where (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%') and ship_id=" & Ship_ID, ds_container)
            ds_board.Reset()
            Getdata("select * from con_map where v_id='" & v_id & "' and location='board' order by id", ds_board)
            ds_cabin.Reset()
            Getdata("select * from con_map where v_id='" & v_id & "' and location='cabin' order by id", ds_cabin)
            dsjoint.Reset()
            Getdata("select * from CON_BAY where v_id='" & v_id & "' and joint='1'", dsjoint)
            ds_unuse_col.Reset()
            Getdata("select * from con_bay where  v_id='" & v_id & "'", ds_unuse_col)
            ds_container1.Reset()
            Getdata("select * from view_conimage_lxj3 where (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%') and ship_id=" & Ship_ID, ds_container1)
            ds_unload_port.Reset()
            Getdata("select distinct con_unload_port_substitute.code_unload_port,substitute from con_unload_port_substitute , con_image where con_unload_port_substitute.ship_id=con_image.ship_id and (con_image.CODE_LOAD_PORT like '%lyg%' or con_image.CODE_UNLOAD_PORT like '%lyg%') and right(con_image.code_Unload_port,3)=right(con_unload_port_substitute.code_unload_port,3) and con_unload_port_substitute.ship_id=" & Ship_ID, ds_unload_port)
            '************************
            ship_bay_count = totalBay '���ı���
            Dim pd As New PrintDocument
            '  pd.DefaultPageSettings.Landscape = True
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
            Me.Close()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub printpageeventhandler(ByVal obj As System.Object, ByVal ev As PrintPageEventArgs)
        Dim x As Single = 0 '�����е�����
        Dim y As Single = 0 '�����е�����
        Dim scale1 As Single = 0 '��������1
        Dim scale2 As Single = 0 '��������2
        Dim scale3 As Single = 0 '��������3
        Dim scaleRow As Integer = 0 '��ͼ�е�����
        Dim scaleCol As Integer = 0 '��ͼ�е�����
        Dim rectborderRow As Integer = 0 '�ɱ�������ȷ�����͵ı߳�
        Dim rectborderCol As Integer = 0 '�ɱ�������ȷ�����͵ı߳�
        Dim papername As String 'ѡ��ֽ�ŵ�����
        Dim dsPaper As New DataSet()
        Dim g As Graphics
        g = ev.Graphics
        pagecount = pagecount + 1 'ҳ�����Ʊ���

        If Microsoft.VisualBasic.Left(ev.PageSettings.PaperSize.PaperName, 2) = "A4" Then
            pageHeight = 787 - 10 - 30
            pageWidth = 1130 - 10
        End If
        If Microsoft.VisualBasic.Left(ev.PageSettings.PaperSize.PaperName, 2) = "B4" Then
            pageHeight = 996 - 25 - 30
            pageWidth = 1418 - 10
        End If
        'ҳ��ĸ߶�
        ' pageHeight = ev.MarginBounds.Bottom - 10 - 30 '���Լӵ�60 ��ȥ���ײ���ע��10��ȥ��������ע��20
        'ҳ��Ŀ��
        '  pageWidth = ev.MarginBounds.Right - 10 ' + 30
        'ѡ��ֽ�ŵ�����
        papername = ev.PageSettings.PaperSize.PaperName()
        Getdata("select * from con_mapset where papername=left('" & papername & "',2) and baycount='" & totalBay & "'", dsPaper)
        '������������
        If Len(Me.txt_percent.Text) > 0 Then
            Try
                expandPercent = CType(Me.txt_percent.Text, Integer) / 100
            Catch
                MsgBox("���������֣�", MsgBoxStyle.OKOnly, "��ʾ")
                Exit Sub
            End Try
        End If
        '������εı߳�---������+4�����㱴�У�һ��ո�һ��ո��С��Ϊдbay��־����������+1(һ�б���)=��ͼ��ÿ��bay����������С    'RectBorder = Floor(Sqrt(pageHeight * pageWidth / (ship_bay_count * (maxrow_board + maxrow_cabin + 4) * (ship_col_count + 1) * expandPrecent)))
        '������ͼ�б�������������
        scaleRow = dsPaper.Tables(0).Rows(0).Item("row")
        scaleCol = dsPaper.Tables(0).Rows(0).Item("col")

        '������εı߳�
        rectborderRow = (pageHeight / scaleRow) / (maxrow_board + maxrow_cabin + 4) ' * expandpercent
        rectborderCol = (pageWidth / scaleCol) / (ship_col_count + 1) ' * expandPercent
        If rectborderRow > rectborderCol Then
            RectBorder = Floor(rectborderCol)
        Else
            RectBorder = Floor(rectborderRow)
        End If
        'RectBorder = RectBorder * expandPercent
        'RectBorder = 18
        'ȷ���߳���ż��
        If RectBorder Mod 2 = 1 Then
            RectBorder = RectBorder - 1
        End If
        If Len(Me.txt_percent.Text) > 0 Then
            '�߳�С����С�߳�
            If RectBorder < minRectBorder Then
                RectBorder = minRectBorder * expandPercent
            End If
            '�߳��������߳�
            If RectBorder > maxRectBorder Then
                RectBorder = maxRectBorder * expandPercent
            End If
            '�߳����ں��ʱ߳�
            If RectBorder >= minRectBorder And RectBorder <= maxRectBorder Then
                RectBorder = RectBorder * expandPercent
            End If
            ' RectBorder = RectBorder * expandPercent
        Else
            If RectBorder < minRectBorder Then
                RectBorder = minRectBorder
                'MsgBox("�����������������������ѡֽ���ͣ�", MsgBoxStyle.OKOnly, "��ʾ")
                'Exit Sub
            End If
            If RectBorder > maxRectBorder Then
                RectBorder = maxRectBorder
            End If
        End If
        '�߳��Ѿ�ȷ�� �ɱ߳��ж��Ƿ�����ҳ
        faceColCount = Floor(pageWidth / ((ship_col_count + 1) * RectBorder)) 'һ�зŵı���
        faceRowCount = Floor(pageHeight / ((maxrow_board + maxrow_cabin + 4) * RectBorder)) '��ͼ�Ϸű��Ĳ���
        firstFaceBayCount = faceColCount * faceRowCount
        If totalBay <= firstFaceBayCount Then
            'ֻ��Ҫһҳ
            con_ship_facemap_print(g)
            ev.HasMorePages = False
        Else
            '��Ҫ�ڶ�ҳ
            'If pagecount Mod 2 = 1 Then
            '    '��ӡ��һҳ
            '    con_ship_facemap_print_first(g, firstFaceBayCount)
            '    ev.HasMorePages = True
            'End If
            'If pagecount Mod 2 = 0 Then
            '    '��ӡ�ڶ�ҳ
            '    con_ship_facemap_print_first(g, totalBay - firstFaceBayCount)
            '    ev.HasMorePages = False
            'End If
            If pagecount Mod 5 = 1 Then
                '��ӡ��һҳ
                con_ship_facemap_print_first(g, firstFaceBayCount)
                ev.HasMorePages = True
            End If
            If pagecount Mod 5 = 2 Then
                '��ӡ�ڶ�ҳ

                If totalBay <= 2 * firstFaceBayCount Then
                    con_ship_facemap_print_first(g, totalBay - firstFaceBayCount)
                    ev.HasMorePages = False
                Else
                    con_ship_facemap_print_first(g, firstFaceBayCount)
                    ev.HasMorePages = True
                End If
            End If
            If pagecount Mod 5 = 3 Then
                '��ӡ����ҳ
                If totalBay <= 3 * firstFaceBayCount Then
                    con_ship_facemap_print_first(g, totalBay - 2 * firstFaceBayCount)
                    ev.HasMorePages = False
                Else
                    con_ship_facemap_print_first(g, firstFaceBayCount)
                    ev.HasMorePages = True
                End If
            End If
            If pagecount Mod 5 = 4 Then
                '��ӡ����ҳ
                If totalBay <= 4 * firstFaceBayCount Then
                    con_ship_facemap_print_first(g, totalBay - 3 * firstFaceBayCount)
                    ev.HasMorePages = False
                Else
                    con_ship_facemap_print_first(g, firstFaceBayCount)
                    ev.HasMorePages = True
                End If
            End If
            If pagecount Mod 5 = 0 Then
                '��ӡ����ҳ
                con_ship_facemap_print_first(g, totalBay - 4 * firstFaceBayCount)
                ev.HasMorePages = False
            End If
        End If
        'con_ship_facemap_print(g)
        'ev.HasMorePages = False
    End Sub

    Private Sub con_ship_facemap_print_first(ByVal g As Graphics, ByVal baycount As Integer)
        Dim myDataView As DataView
        ship_bay_count = baycount
        '��������䡢Σ��Ʒ��־
        Dim dMark As Integer = 0
        Dim rMark As Integer = 0
        Dim rdMark As Integer = 0
        '��������־
        Dim eMark As Integer = 0
        '���嵹���־shifting
        Dim sMark As Integer = 0
        '���
        '  g.Clear(Me.BackColor)
        distoleft = 0
        distotop = 30
        'д����
        g.DrawString("STOWAGE  PLAN", shipName, Brushes.Black, CInt(pageWidth / 2) - 50, distotop - 30)
        'д���Ƹ�����
        g.DrawString("COSTACO LIANYUNGANG  ���Ƹ�����", Me.Font, Brushes.Black, distoleft + 0, distotop - 10)
        'д��������
        g.DrawString("VESSEL:" & ENG_VESSEL, Me.Font, Brushes.Black, distoleft + 40 + 190, distotop - 10)
        g.DrawString("VOY:" & VOYAGE, Me.Font, Brushes.Black, distoleft + 40 + 450, distotop - 10)
        g.DrawString("POL��LYG", Me.Font, Brushes.Black, distoleft + 40 + 600, distotop - 10)
        g.DrawString("DATE:" & DatePart(DateInterval.Year, Today()) & "-" & IIf(DatePart(DateInterval.Month, Today()) < 10, "0" & DatePart(DateInterval.Month, Today()), DatePart(DateInterval.Month, Today())) & "-" & IIf(DatePart(DateInterval.Day, Today()) < 10, "0" & DatePart(DateInterval.Day, Today()), DatePart(DateInterval.Day, Today())), Me.Font, Brushes.Black, distoleft + 40 + 20 + 750, distotop - 10)
        '�������ν���

        'If pagecount Mod 2 = 1 Then
        '    Getdata("select top " & baycount & " bay_num,joint from con_bay where v_id=" & v_id & " order by bay_num", ds_bay_num) 'ȡ������Ҫ�����BAY
        '    myDataView = ds_bay_num.Tables(0).DefaultView
        'End If
        'If pagecount Mod 2 = 0 Then

        '    Getdata("select top " & baycount & " bay_num,joint from con_bay where v_id=" & v_id & " order by bay_num desc", ds_bay_num) 'ȡ������Ҫ�����BAY
        '    myDataView = ds_bay_num.Tables(0).DefaultView
        '    myDataView.Sort = "bay_num ASC"
        '    'MsgBox(myDataView.Item(0).Row(0))
        'End If
        If pagecount Mod 5 = 1 Then
            Getdata("select top " & baycount & " bay_num,joint from con_bay where v_id=" & v_id & " order by bay_num", ds_bay_num) 'ȡ������Ҫ�����BAY
            myDataView = ds_bay_num.Tables(0).DefaultView
        End If
        If pagecount Mod 5 = 2 Then
            '�ڶ�ҳ
            Getdata("select top " & baycount & " bay_num,joint from con_bay where v_id=" & v_id & "  and bay_num>'" & dsMorePageBayNum.Tables(0).Rows(1 * firstFaceBayCount - 1).Item("bay_num") & "' order by bay_num", ds_bay_num) 'ȡ������Ҫ�����BAY
            myDataView = ds_bay_num.Tables(0).DefaultView
        End If
        If pagecount Mod 5 = 3 Then
            '����ҳ
            Getdata("select top " & baycount & " bay_num,joint from con_bay where v_id=" & v_id & "  and bay_num>'" & dsMorePageBayNum.Tables(0).Rows(2 * firstFaceBayCount - 1).Item("bay_num") & "' order by bay_num", ds_bay_num) 'ȡ������Ҫ�����BAY
            myDataView = ds_bay_num.Tables(0).DefaultView
        End If
        If pagecount Mod 5 = 4 Then
            '����ҳ
            Getdata("select top " & baycount & " bay_num,joint from con_bay where v_id=" & v_id & "  and bay_num>'" & dsMorePageBayNum.Tables(0).Rows(3 * firstFaceBayCount - 1).Item("bay_num") & "' order by bay_num", ds_bay_num) 'ȡ������Ҫ�����BAY
            myDataView = ds_bay_num.Tables(0).DefaultView
        End If
        If pagecount Mod 5 = 0 Then
            '����ҳ
            Getdata("select top " & baycount & " bay_num,joint from con_bay where v_id=" & v_id & "  and bay_num>'" & dsMorePageBayNum.Tables(0).Rows(4 * firstFaceBayCount - 1).Item("bay_num") & "' order by bay_num", ds_bay_num) 'ȡ������Ҫ�����BAY
            myDataView = ds_bay_num.Tables(0).DefaultView
        End If

        hang_bay_count = Fix(pageWidth / ((ship_col_count + 1) * RectBorder)) 'һ�����ɵ�BAY��
        If hang_bay_count > ship_bay_count Then
            hang_big_bay = ship_bay_count '��ʼ�������BAY
        Else
            hang_big_bay = hang_bay_count
        End If
        hang_small_bay = 1 '��ʼ������Сbay
        '��ѭ����ʼ
        For hang = 1 To Ceiling(ship_bay_count / hang_bay_count)
            If hang > 1 And hang_big_bay < ship_bay_count Then
                hang_big_bay = hang_big_bay + hang_bay_count
                If hang_big_bay > ship_bay_count Then
                    hang_big_bay = ship_bay_count
                End If
                hang_small_bay = hang_small_bay + hang_bay_count
            End If
            '���м������Ƶľ���
            If hang > 1 Then
                distotop = distotop + (maxrow_board + maxrow_cabin + 1 + 1 + 1 + 1) * RectBorder
            End If
            '��BAYѭ����ʼ
            For bay_start = hang_big_bay To hang_small_bay Step -1
                ship_bay_num = myDataView(bay_start - 1)("bay_num")   'ȡ��Ҫ����ĵ�ǰBAY
                '��ʼ����ǰBAY
                '�������ߺͶ����λ��
                If bay_start Mod hang_bay_count = 0 Then
                    distoleft = 0
                Else
                    distoleft = (hang_bay_count - (bay_start Mod hang_bay_count)) * RectBorder * (ship_col_count + 1)
                End If
                '���
                small_col = 0
                big_col = 0
                small_col_cabin = 0
                big_col_cabin = 0
                ''�װ�ȡ�װ������
                ds_boardr = ds_board.Tables(0).Select("bay_num='" & ship_bay_num & "'")
                If ds_boardr.Length() > 0 Then
                    'If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='board' order by id", ds_board).Count > 0 Then
                    Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='board'", ds_board_char)
                    small_row = ds_board_char.Tables(0).Rows(0).Item("small_row") 'ȡ�װ���Ļ����С��
                    big_row = ds_board_char.Tables(0).Rows(0).Item("big_row") 'ȡ�װ���Ļ�������
                    small_col = ds_board_char.Tables(0).Rows(0).Item("small_col") 'ȡ�װ���Ļ����С��
                    big_col = ds_board_char.Tables(0).Rows(0).Item("big_col") 'ȡ�װ���Ļ�������
                End If
                'ȡ���ڵ�����
                ds_cabinr = ds_cabin.Tables(0).Select("bay_num='" & ship_bay_num & "'")
                If ds_cabinr.Length() > 0 Then
                    'If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='cabin' order by id", ds_cabin).Count > 0 Then
                    Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='cabin'", ds_cabin_char)
                    small_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_col") 'ȡ������Ļ����С��
                    big_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_col") 'ȡ������Ļ�������
                    small_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_row") 'ȡ������Ļ����С��
                    big_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_row") 'ȡ������Ļ�������
                End If
                'дbay�ţ��ж��Ƿ�ͨ�������
                If (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) >= 0 Then
                    If myDataView(bay_start - 1).Item("joint") = 1 Then 'ȡ��Ҫ����ĵ�ǰBAY_ Then
                        'ż��bay
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
                    If myDataView(bay_start - 1).Item("joint") = 1 Then 'ȡ��Ҫ����ĵ�ǰBAY_ Thends_bay_num.Tables(0).Rows(bay_start - 1)
                        If CType(ship_bay_num, Integer) < 10 Then
                            g.DrawString(ship_bay_num & "(0" & ship_bay_num + 1 & ")", bay_f, Brushes.Black, distoleft + (big_col_cabin - small_col_cabin + 1 + 1) / 2 * RectBorder - 13, distotop + CInt(RectBorder / 2) - 5)
                        Else
                            g.DrawString(ship_bay_num & "(" & ship_bay_num + 1 & ")", bay_f, Brushes.Black, distoleft + (big_col_cabin - small_col_cabin + 1 + 1) / 2 * RectBorder - 13, distotop + CInt(RectBorder / 2) - 5)
                        End If

                    Else
                        g.DrawString(ship_bay_num, bay_f, Brushes.Black, distoleft + (big_col_cabin - small_col_cabin + 1 + 1) / 2 * RectBorder - 1, distotop + CInt(RectBorder / 2) - 5)
                    End If
                End If

                '�װ忪ʼ
                If ds_boardr.Length() > 0 Then
                    '����װ���ͼ�Ķ���λ��
                    If (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) >= 0 Then '�Ƚϼװ�Ͳ��ڵ�����
                        col_count = (big_col_cabin - small_col_cabin + 1) - (big_col - small_col + 1) ''�װ��������Ͳ��ڵĲ��
                    Else
                        col_count = 0
                    End If
                    '���װ����
                    For i = small_row To big_row
                        For j = small_col To big_col
                            If ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("user_char") = 1 Then
                                g.DrawRectangle(pen_line, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col), distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1), RectBorder, RectBorder)
                                '��λ��
                                BAYNO = ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") & ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_col") & ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_row")
                                '��λ��--���ż�һ
                                If ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") + 1 < 10 Then
                                    BAYNO_ADD = "0" & ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") + 1
                                Else
                                    BAYNO_ADD = ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") + 1
                                End If
                                BAYNO_ADD = BAYNO_ADD & ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_col") & ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_row")
                                '�жϴ� Bay �Ƿ�Ϊͨ Bay
                                dsjointr = dsjoint.Tables(0).Select("bay_num='" & Trim(Mid(BAYNO, 1, 2)) & "'")
                                If dsjointr.Length() = 0 Then
                                    'If Getdata("select * from CON_BAY where v_id='" & v_id & "' and bay_num='" & Trim(Mid(BAYNO, 1, 2)) & "' and joint='1'", dsjoint).Count = 0 Then
                                    BAYNO_ADD = "000000"
                                End If
                                '�жϴ˱�λ���������----lxj�޸���ͼ
                                dr = ds_container.Tables(0).Select("BAYNO='" & BAYNO & "' or BAYNO='" & BAYNO_ADD & "'")
                                If dr.Length() > 0 Then
                                    'If Getdata("select * from view_conimage_lxj  where  (BAYNO='" & BAYNO & "' or BAYNO='" & BAYNO_ADD & "') and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%') and ship_id=" & Ship_ID, ds_container).Count > 0 Then
                                    'ж����
                                    If dr(0).Item("substitute") Is System.DBNull.Value Then
                                    Else
                                        g.DrawString(UCase(dr(0).Item("substitute")), f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) - 1, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + 1)
                                    End If
                                    '�����־
                                    If dr(0).Item("moved") = 0 Then
                                        '������
                                        If dr(0).Item("FULLOREMPTY") Is System.DBNull.Value Then
                                            If Len(dr(0).Item("TEMPERATURE_UNIT")) > 0 And Len(dr(0).Item("DANGER_GRADE")) > 0 Then
                                                rdMark = 1
                                                g.DrawString("k", f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + 6, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + 1)
                                            Else
                                                If Len(dr(0).Item("DANGER_GRADE")) > 0 Then
                                                    dMark = 1
                                                    g.DrawString("d", f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + 6, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + 1)
                                                End If

                                                If Len(dr(0).Item("TEMPERATURE_UNIT")) > 0 Then
                                                    rMark = 1
                                                    g.DrawString("r", f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + 6, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + 1)
                                                End If
                                            End If
                                        Else
                                            If LCase(LTrim(RTrim(dr(0).Item("FULLOREMPTY")))) = "e" Then
                                                '����
                                                eMark = 1
                                                g.DrawString(LCase(dr(0).Item("FULLOREMPTY")), f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + 6, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + 1)
                                            Else
                                                If Len(dr(0).Item("TEMPERATURE_UNIT")) > 0 And Len(dr(0).Item("DANGER_GRADE")) > 0 Then
                                                    rdMark = 1
                                                    g.DrawString("k", f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + 6, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + 1)

                                                Else
                                                    If Len(dr(0).Item("DANGER_GRADE")) > 0 Then
                                                        dMark = 1
                                                        g.DrawString("d", f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + 6, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + 1)
                                                    End If
                                                    If Len(dr(0).Item("TEMPERATURE_UNIT")) > 0 Then
                                                        rMark = 1
                                                        g.DrawString("r", f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + 6, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + 1)
                                                    End If
                                                End If
                                            End If
                                        End If

                                        ''�����־
                                        'If ds_container.Tables(0).Rows(0).Item("OLDBAYNO") Is System.DBNull.Value Then
                                    Else
                                        '�����־
                                        sMark = 1
                                        g.DrawString(sShifting, f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + 6, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + 1)
                                    End If
                                End If
                                '��λ��--���ż�һ
                                BAYNO_MID = ""
                                If ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") - 1 < 10 Then
                                    BAYNO_MID = "0" & ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") - 1
                                    BAYNO_MID = BAYNO_MID & ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_col") & ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_row")
                                Else
                                    BAYNO_MID = ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_num") - 1
                                    BAYNO_MID = BAYNO_MID & ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_col") & ds_boardr((big_col - small_col + 1) * (i - small_row) + j - small_col).Item("bay_row")
                                End If
                                '�жϴ� Bay �Ƿ�Ϊͨ Bay
                                BAYNO_MID_1 = Mid(Trim(BAYNO_MID), 1, 2)
                                If CType(BAYNO_MID_1, Int16) Mod 2 = 0 Then
                                    BAYNO_MID_1 = CType(BAYNO_MID_1, Int16) - 1
                                End If

                                If BAYNO_MID_1.Trim().Length = 1 Then
                                    BAYNO_MID_1 = "0" & BAYNO_MID_1.Trim()
                                End If
                                dsjointr = dsjoint.Tables(0).Select("bay_num='" & BAYNO_MID_1 & "'")
                                If dsjointr.Length() > 0 Then
                                    'If Getdata("select * from CON_BAY where v_id='" & v_id & "' and bay_num='" & BAYNO_MID_1 & "' and joint='1'", dsjoint).Count > 0 Then

                                    '�жϴ˱�λ���������
                                    If Len(Trim(BAYNO_MID)) > 0 Then
                                        ds_container1r = ds_container1.Tables(0).Select("BAYNO='" & BAYNO_MID & "'")
                                        If ds_container1r.Length() > 0 Then
                                            'If Getdata("select substring(ltrim(CODE_UNLOAD_PORT),1,1) CODE_UNLOAD_PORT,FULLOREMPTY,CONTAINER_TYPE from view_conimage_lxj3 where  BAYNO='" & BAYNO_MID & "' and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%') and ship_id=" & Ship_ID, ds_container1).Count > 0 Then
                                            g.DrawLine(pen_cross, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + 1, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + 1, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + RectBorder - 1, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + RectBorder - 1)
                                            g.DrawLine(pen_cross, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + 1, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + RectBorder - 1, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + RectBorder - 1, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) - 1)
                                        End If
                                    End If
                                End If
                            End If
                        Next
                    Next
                    '������
                    For i = small_row To big_row 'սλ�������,���ж����������ȱ�
                        bay_row = 78 + i * 2
                        g.DrawString(bay_row, f, Brushes.Black, distoleft + CInt(RectBorder / 2) - 6, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + CInt(RectBorder / 2) - 5)  '����
                    Next
                    'дbay��
                    '   g.DrawString("BAY" & ship_bay_num, bay_f, Brushes.Black, distoleft + (big_col - small_col + 1) / 2 * 10 - 10, distotop + 10)
                    ''д����
                    n = big_col - small_col + 1
                    Dim strcon As Integer
                    strcon = 1
                    Dim strsmallcol As Integer
                    strsmallcol = small_col
                    Dim strbigcol As Integer
                    strbigcol = big_col
                    ds_unuse_colr = ds_unuse_col.Tables(0).Select("bay_num='" & ship_bay_num & "'")
                    If ds_unuse_colr.Length() > 0 Then
                        'If Getdata("select * from con_bay where  v_id='" & v_id & "' and bay_num='" & ship_bay_num & "'", ds_unuse_col).Count > 0 Then
                        If ds_unuse_colr(0).Item("board_unuse_col") Is System.DBNull.Value Then

                        Else
                            If ds_unuse_colr(0).Item("board_unuse_col") = "�ұ�" Then
                                strbigcol = strbigcol - 1
                            Else
                                If ds_unuse_colr(0).Item("board_unuse_col") = "���" Then
                                    strsmallcol = strsmallcol + 1
                                    strcon = 2
                                End If
                            End If
                        End If
                    End If
                    For j = strsmallcol To strbigcol   'սλ�������
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
                        g.DrawString(bay_col, f, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + CInt(RectBorder / 2) - 6, distotop + RectBorder + RectBorder - CInt(RectBorder / 2) - 4) '����
                    Next j
                End If
                '�װ����
                '���װ�Ͳ����м�ķָ���

                g.DrawLine(pen_seperate, distoleft + RectBorder + CInt(col_count * RectBorder / 2), distotop + (maxrow_board + 1 + 1) * RectBorder + CInt(RectBorder / 2), distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (big_col - small_col + 1), distotop + (maxrow_board + 1 + 1) * RectBorder + CInt(RectBorder / 2))

                ''���ڿ�ʼ
                If ds_cabinr.Length() > 0 Then
                    '������ڽ��ͼ�Ķ���λ��
                    If (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) >= 0 Then
                        col_count = (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) ''�װ��������Ͳ��ڵĲ��
                    Else
                        col_count = 0
                    End If
                    ''�����ھ���
                    For i = small_row_cabin To big_row_cabin
                        For j = small_col_cabin To big_col_cabin
                            If ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("user_char") = 1 Then
                                g.DrawRectangle(pen_line, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin), distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1), RectBorder, RectBorder)
                                '��λ��
                                BAYNO = ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") & ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_col") & ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_row")
                                '��λ��--���ż�һ
                                If ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") + 1 < 10 Then
                                    BAYNO_ADD = "0" & ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") + 1
                                Else
                                    BAYNO_ADD = ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") + 1
                                End If
                                BAYNO_ADD = BAYNO_ADD & ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_col") & ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_row")
                                '�жϴ� Bay �Ƿ�Ϊͨ Bay
                                dsjointr = dsjoint.Tables(0).Select("bay_num='" & Trim(Mid(BAYNO, 1, 2)) & "'")
                                If dsjointr.Length() = 0 Then
                                    'If Getdata("select * from CON_BAY where v_id='" & v_id & "' and bay_num='" & Trim(Mid(BAYNO, 1, 2)) & "' and joint='1'", dsjoint).Count = 0 Then
                                    BAYNO_ADD = "000000"
                                End If
                                '�жϴ˱�λ���������----lxj�޸���ͼ
                                dr = ds_container.Tables(0).Select("BAYNO='" & BAYNO & "' or BAYNO='" & BAYNO_ADD & "'")
                                If dr.Length() > 0 Then
                                    'If Getdata("select * from view_conimage_lxj  where  (BAYNO='" & BAYNO & "' or BAYNO='" & BAYNO_ADD & "') and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%') and ship_id=" & Ship_ID, ds_container).Count > 0 Then
                                    'ж����
                                    If dr(0).Item("substitute") Is System.DBNull.Value Then
                                    Else
                                        g.DrawString(UCase(dr(0).Item("substitute")), f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) - 1, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + 1)
                                    End If
                                    '�����־
                                    If dr(0).Item("moved") = 0 Then
                                        '������
                                        If dr(0).Item("FULLOREMPTY") Is System.DBNull.Value Then
                                            '�����
                                            If Len(dr(0).Item("TEMPERATURE_UNIT")) > 0 And Len(dr(0).Item("DANGER_GRADE")) > 0 Then
                                                rdMark = 1
                                                g.DrawString("k", f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) + 6, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + 1)
                                            Else
                                                If Len(dr(0).Item("TEMPERATURE_UNIT")) > 0 Then
                                                    rMark = 1
                                                    g.DrawString("r", f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) + 6, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + 1)
                                                End If
                                                If Len(dr(0).Item("DANGER_GRADE")) > 0 Then
                                                    dMark = 1
                                                    g.DrawString("d", f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) + 6, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + 1)
                                                End If
                                            End If
                                        Else
                                            If LCase(LTrim(RTrim(dr(0).Item("FULLOREMPTY")))) = "e" Then
                                                '����
                                                eMark = 1
                                                g.DrawString(LCase(dr(0).Item("FULLOREMPTY")), f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) + 6, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + 1)
                                            Else
                                                '�����
                                                If Len(dr(0).Item("TEMPERATURE_UNIT")) > 0 And Len(ds_container.Tables(0).Rows(0).Item("DANGER_GRADE")) > 0 Then
                                                    rdMark = 1
                                                    g.DrawString("k", f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) + 6, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + 1)
                                                Else
                                                    If Len(dr(0).Item("TEMPERATURE_UNIT")) > 0 Then
                                                        rMark = 1
                                                        g.DrawString("r", f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) + 6, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + 1)
                                                    End If
                                                    If Len(dr(0).Item("DANGER_GRADE")) > 0 Then
                                                        dMark = 1
                                                        g.DrawString("d", f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) + 6, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + 1)
                                                    End If
                                                End If
                                            End If
                                        End If
                                        '�����
                                        ''�����־
                                        'If ds_container.Tables(0).Rows(0).Item("OLDBAYNO") Is System.DBNull.Value Then
                                    Else
                                        '�����־
                                        sMark = 1
                                        g.DrawString(sShifting, f_container, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) + 6, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + 1)
                                    End If
                                End If
                                '��λ��--���ż�һ
                                If ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") - 1 < 10 Then
                                    BAYNO_MID = "0" & ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") - 1
                                    BAYNO_MID = BAYNO_MID & ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_col") & ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_row")
                                Else
                                    BAYNO_MID = ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_num") - 1
                                    BAYNO_MID = BAYNO_MID & ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_col") & ds_cabinr((big_col_cabin - small_col_cabin + 1) * (i - small_row_cabin) + j - small_col_cabin).Item("bay_row")
                                End If
                                '�жϴ� Bay �Ƿ�Ϊͨ Bay
                                BAYNO_MID_1 = Mid(Trim(BAYNO_MID), 1, 2)
                                If CType(BAYNO_MID_1, Int16) Mod 2 = 0 Then
                                    BAYNO_MID_1 = CType(BAYNO_MID_1, Int16) - 1
                                End If

                                If BAYNO_MID_1.Trim().Length = 1 Then
                                    BAYNO_MID_1 = "0" & BAYNO_MID_1.Trim()
                                End If
                                dsjointr = dsjoint.Tables(0).Select("bay_num='" & BAYNO_MID_1 & "'")
                                If dsjointr.Length() > 0 Then
                                    'If Getdata("select * from CON_BAY where v_id='" & v_id & "' and bay_num='" & BAYNO_MID_1 & "' and joint='1'", dsjoint).Count > 0 Then

                                    '�жϴ˱�λ���������
                                    ds_container1r = ds_container1.Tables(0).Select("BAYNO='" & BAYNO_MID & "'")
                                    If ds_container1r.Length() > 0 Then
                                        'If Getdata("select substring(ltrim(CODE_UNLOAD_PORT),1,1) CODE_UNLOAD_PORT,FULLOREMPTY,CONTAINER_TYPE from view_conimage_lxj3  where  BAYNO='" & BAYNO_MID & "' and (CODE_LOAD_PORT like '%lyg%' or CODE_UNLOAD_PORT like '%lyg%') and ship_id=" & Ship_ID, ds_container1).Count > 0 Then
                                        g.DrawLine(pen_cross, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) + 1, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + 1, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) + RectBorder - 1, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + RectBorder - 1)
                                        g.DrawLine(pen_cross, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) + 1, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + RectBorder - 1, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin) + RectBorder - 1, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + 1)
                                    End If
                                End If
                            End If
                        Next j
                    Next i
                    '������
                    For i = small_row_cabin To big_row_cabin 'սλ�������,���ж����������ȱ�
                        If i * 2 < 10 Then
                            bay_row_cabin = "0" & i * 2
                        Else
                            bay_row_cabin = i * 2
                        End If
                        g.DrawString(bay_row_cabin, f, Brushes.Black, distoleft + CInt(RectBorder / 2) - 6, distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1) + CInt(RectBorder / 2) - 5) '����
                    Next i
                    ''д����
                    n = big_col_cabin - small_col_cabin + 1
                    Dim strcon As Integer
                    strcon = 1
                    Dim strsmallcol As Integer
                    strsmallcol = small_col_cabin
                    Dim strbigcol As Integer
                    strbigcol = big_col_cabin
                    ds_unuse_colr = ds_unuse_col.Tables(0).Select("bay_num='" & ship_bay_num & "'")
                    If ds_unuse_colr.Length() > 0 Then
                        'If Getdata("select * from con_bay where  v_id='" & v_id & "' and bay_num='" & ship_bay_num & "'", ds_unuse_col).Count > 0 Then
                        If ds_unuse_colr(0).Item("cabin_unuse_col") Is System.DBNull.Value Then

                        Else
                            If ds_unuse_colr(0).Item("cabin_unuse_col") = "�ұ�" Then
                                strbigcol = strbigcol - 1
                            Else
                                If ds_unuse_colr(0).Item("cabin_unuse_col") = "���" Then
                                    strsmallcol = strsmallcol + 1
                                    strcon = 2
                                End If
                            End If
                        End If
                    End If
                    For j = strsmallcol To strbigcol   'սλ�������
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
        'д������һ��ж���۵�ע��

        Dim unload_port_count As Integer
        unload_port_count = 0
        For unload_port_count = 0 To ds_unload_port.Tables(0).DefaultView.Count - 1
            g.DrawString(ds_unload_port.Tables(0).Rows(unload_port_count).Item("substitute") & " : " & ds_unload_port.Tables(0).Rows(unload_port_count).Item("code_unload_port"), f, Brushes.Black, unload_port_count * 50, pageHeight + 20)
        Next
        If eMark = 1 Then '����
            g.DrawString("e : empty", f, Brushes.Black, (unload_port_count) * 50, pageHeight + 20)
        End If
        If sMark = 1 Then '����
            g.DrawString(sShifting & " : shifting", f, Brushes.Black, (unload_port_count) * 50 + eMark * 50, pageHeight + 20)
        End If
        If rMark = 1 Then '�����
            g.DrawString("r : reefer", f, Brushes.Black, (unload_port_count) * 50 + eMark * 50 + sMark * 60, pageHeight + 20)
        End If
        If dMark = 1 Then 'Σ��Ʒ
            g.DrawString("d : dangerous", f, Brushes.Black, (unload_port_count) * 50 + eMark * 50 + sMark * 60 + rMark * 60, pageHeight + 20)
        End If
        If rdMark = 1 Then '����� Σ��Ʒ
            g.DrawString("k : reefer&dangerous", f, Brushes.Black, (unload_port_count) * 50 + eMark * 50 + sMark * 60 + rMark * 60 + dMark * 60, pageHeight + 20)
        End If
        Me.pl_facemap.Refresh()
    End Sub

    Private Sub btn_show_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_show.Click
        con_ship_facemap_show(bmpgraphics_facemap)
    End Sub

End Class
