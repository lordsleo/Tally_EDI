Imports TALLY.DBControl
Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.Math
Imports System.Drawing.Printing
Public Class Frm_con_facemap
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
        Me.btn_enter.Text = "��ӡ"
        '
        'btn_cancle
        '
        Me.btn_cancle.Location = New System.Drawing.Point(510, 28)
        Me.btn_cancle.Name = "btn_cancle"
        Me.btn_cancle.Size = New System.Drawing.Size(64, 24)
        Me.btn_cancle.TabIndex = 1
        Me.btn_cancle.Text = "ȡ��"
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
        Me.btn_show.Text = "��ʾͼ��"
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
        Me.Label1.Text = "����"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_printpreview
        '
        Me.btn_printpreview.Location = New System.Drawing.Point(291, 28)
        Me.btn_printpreview.Name = "btn_printpreview"
        Me.btn_printpreview.Size = New System.Drawing.Size(64, 24)
        Me.btn_printpreview.TabIndex = 8
        Me.btn_printpreview.Text = "��ӡԤ��"
        '
        'btn_pagesetup
        '
        Me.btn_pagesetup.Location = New System.Drawing.Point(218, 28)
        Me.btn_pagesetup.Name = "btn_pagesetup"
        Me.btn_pagesetup.Size = New System.Drawing.Size(64, 24)
        Me.btn_pagesetup.TabIndex = 7
        Me.btn_pagesetup.Text = "ҳ������"
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
        Me.Text = "��ͼ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    'ͼ��Ϣ
    Dim bmp_facemap As Bitmap
    Dim bmpgraphics_facemap As Graphics
    Dim pen_line As New Pen(Color.Black, 1)
    Dim ff As New FontFamily("Arial")
    Dim f As New Font(ff, 6)
    Dim bay_f As New Font(ff, 8, FontStyle.Bold)
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

    Dim faceRowCount As Integer '��ͼ�Ͽ��ԷŵĲ���
    Dim faceColCount As Integer '��ͼ��һ�п��Էű��ı���
    Dim firstFaceBayCount As Integer '��һҳ�ŵı���
    Dim secondFaceBayCount As Integer '�ڶ�ҳ�ŵı���
    Dim pagecount As Integer = 0 'ҳ�����Ʊ���
    Dim totalBay As Integer = 0 '���ϵ���bay��
  
    Private Sub Frm_con_facemap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

            Try
                ship_bay_count = ds_count_cabin.Tables(0).Rows(0).Item("bay_count") '���ı���
                totalBay = ds_count_cabin.Tables(0).Rows(0).Item("bay_count") '���ı���
                'con_ship_facemap_show(bmpgraphics_facemap)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub con_ship_facemap_show(ByVal g As Graphics)
        '���
        'g.Clear(Me.BackColor)
        distoleft = 0
        distotop = 10
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
                If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='board'", ds_board).Count > 0 Then
                    Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='board'", ds_board_char)
                    small_row = ds_board_char.Tables(0).Rows(0).Item("small_row") 'ȡ�װ���Ļ����С��
                    big_row = ds_board_char.Tables(0).Rows(0).Item("big_row") 'ȡ�װ���Ļ�������
                    small_col = ds_board_char.Tables(0).Rows(0).Item("small_col") 'ȡ�װ���Ļ����С��
                    big_col = ds_board_char.Tables(0).Rows(0).Item("big_col") 'ȡ�װ���Ļ�������
                End If
                'ȡ���ڵ�����
                If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='cabin'", ds_cabin).Count > 0 Then
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
                        If CType(ship_bay_num, Integer) < 10 Then
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
                            End If
                        Next
                    Next
                    '������
                    For i = small_row To big_row 'սλ�������,���ж����������ȱ�
                        bay_row = 78 + i * 2
                        g.DrawString(bay_row, f, Brushes.Black, distoleft + 9, distotop + (ship_row_count + 1 + 2) * 10 - 10 * (i - small_row + 1) + 10) '����
                    Next

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
                        g.DrawString(bay_col_cabin, f, Brushes.Black, distoleft + 10 + col_count * 5 + 10 * (j - small_col_cabin + 1), distotop + (ship_row_count + 1 + 2 + 2) * 10 + (ship_row_count) * 10)  '����
                    Next
                End If
            Next bay_start
        Next hang
        Me.pl_facemap.Refresh()
    End Sub


    Private Sub con_ship_facemap_print(ByVal g As Graphics)
        '���
        'g.Clear(Me.BackColor)
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
                If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='board'", ds_board).Count > 0 Then
                    Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='board'", ds_board_char)
                    small_row = ds_board_char.Tables(0).Rows(0).Item("small_row") 'ȡ�װ���Ļ����С��
                    big_row = ds_board_char.Tables(0).Rows(0).Item("big_row") 'ȡ�װ���Ļ�������
                    small_col = ds_board_char.Tables(0).Rows(0).Item("small_col") 'ȡ�װ���Ļ����С��
                    big_col = ds_board_char.Tables(0).Rows(0).Item("big_col") 'ȡ�װ���Ļ�������
                End If
                'ȡ���ڵ�����
                If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='cabin'", ds_cabin).Count > 0 Then
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
                                g.DrawRectangle(pen_line, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col), distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1), RectBorder, RectBorder)
                            End If
                        Next
                    Next
                    '������
                    For i = small_row To big_row 'սλ�������,���ж����������ȱ�
                        bay_row = 78 + i * 2
                        g.DrawString(bay_row, f, Brushes.Black, distoleft + CInt(RectBorder / 2) - 6, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + CInt(RectBorder / 2) - 5) '����
                    Next

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
                        g.DrawString(bay_col, f, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + CInt(RectBorder / 2) - 6, distotop + RectBorder + RectBorder - CInt(RectBorder / 2) - 4) '����
                    Next j
                End If
                '�װ����
                '���װ�Ͳ����м�ķָ���

                g.DrawLine(pen_seperate, distoleft + RectBorder + CInt(col_count * RectBorder / 2), distotop + (maxrow_board + 1 + 1) * RectBorder + CInt(RectBorder / 2), distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (big_col - small_col + 1), distotop + (maxrow_board + 1 + 1) * RectBorder + CInt(RectBorder / 2))

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
                                g.DrawRectangle(pen_line, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin), distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1), RectBorder, RectBorder)
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
            ship_bay_count = totalBay '���ı���
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
            ship_bay_count = totalBay '���ı���
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
            pageHeight = 787 - 10 - 20
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
        'RectBorder = 20
        'ȷ���߳���ż��
        If RectBorder Mod 2 = 1 Then
            RectBorder = RectBorder - 1
        End If
        '����
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
            '��Ҫ��ҳ     �ڶ�ҳ
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
    End Sub
    Dim dsMorePageBayNum As New DataSet '������е�bay
    Private Sub con_ship_facemap_print_first(ByVal g As Graphics, ByVal baycount As Integer)
        Dim myDataView As DataView
        ship_bay_count = baycount
        '���
        'g.Clear(Me.BackColor)
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
        '   ' MsgBox(myDataView.Item(0).Row(0))
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
                'ship_bay_num = ds_bay_num.Tables(0).Rows(bay_start - 1).Item("bay_num") 'ȡ��Ҫ����ĵ�ǰBAY
                ship_bay_num = myDataView(bay_start - 1)("bay_num")
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
                If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='board'", ds_board).Count > 0 Then
                    Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='board'", ds_board_char)
                    small_row = ds_board_char.Tables(0).Rows(0).Item("small_row") 'ȡ�װ���Ļ����С��
                    big_row = ds_board_char.Tables(0).Rows(0).Item("big_row") 'ȡ�װ���Ļ�������
                    small_col = ds_board_char.Tables(0).Rows(0).Item("small_col") 'ȡ�װ���Ļ����С��
                    big_col = ds_board_char.Tables(0).Rows(0).Item("big_col") 'ȡ�װ���Ļ�������
                End If
                'ȡ���ڵ�����
                If Getdata("select * from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='cabin'", ds_cabin).Count > 0 Then
                    Getdata("select min(screen_row) small_row,max(screen_row) big_row,min(screen_col) small_col,max(screen_col) big_col from con_map where v_id='" & v_id & "' and bay_num='" & ship_bay_num & "' and location='cabin'", ds_cabin_char)
                    small_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_col") 'ȡ������Ļ����С��
                    big_col_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_col") 'ȡ������Ļ�������
                    small_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("small_row") 'ȡ������Ļ����С��
                    big_row_cabin = ds_cabin_char.Tables(0).Rows(0).Item("big_row") 'ȡ������Ļ�������
                End If
                'If ship_bay_num = 45 Then
                '    MsgBox(ds_bay_num.Tables(0).Rows(bay_start - 1).Item("joint"))
                'End If
                'дbay�ţ��ж��Ƿ�ͨ�������
                If (big_col - small_col + 1) - (big_col_cabin - small_col_cabin + 1) >= 0 Then
                    If myDataView(bay_start - 1).Item("joint") = 1 Then 'ȡ��Ҫ����ĵ�ǰBAY_ Then
                        If CType(ship_bay_num, Integer) Mod 2 = 0 Then
                            'ż��bay
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
                                g.DrawRectangle(pen_line, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col), distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1), RectBorder, RectBorder)
                            End If
                        Next
                    Next
                    '������
                    For i = small_row To big_row 'սλ�������,���ж����������ȱ�
                        bay_row = 78 + i * 2
                        g.DrawString(bay_row, f, Brushes.Black, distoleft + CInt(RectBorder / 2) - 6, distotop + (maxrow_board + 1 + 1) * RectBorder - RectBorder * (i - small_row + 1) + CInt(RectBorder / 2) - 5) '����
                    Next

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
                        g.DrawString(bay_col, f, Brushes.Black, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col) + CInt(RectBorder / 2) - 6, distotop + RectBorder + RectBorder - CInt(RectBorder / 2) - 4) '����
                    Next j
                End If
                '�װ����
                '���װ�Ͳ����м�ķָ���

                g.DrawLine(pen_seperate, distoleft + RectBorder + CInt(col_count * RectBorder / 2), distotop + (maxrow_board + 1 + 1) * RectBorder + CInt(RectBorder / 2), distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (big_col - small_col + 1), distotop + (maxrow_board + 1 + 1) * RectBorder + CInt(RectBorder / 2))

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
                                g.DrawRectangle(pen_line, distoleft + RectBorder + CInt(col_count * RectBorder / 2) + RectBorder * (j - small_col_cabin), distotop + (maxrow_board + 1 + 1 + 1) * RectBorder + (big_row_cabin - small_row_cabin + 1) * RectBorder - RectBorder * (i - small_row_cabin + 1), RectBorder, RectBorder)
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

