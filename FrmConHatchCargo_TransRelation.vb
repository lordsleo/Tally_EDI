Imports TALLY.DBControl
Public Class FrmConHatchCargo_TransRelation
    Inherits System.Windows.Forms.Form

    Dim sqlContainer As String
    Dim adContainer As New SqlClient.SqlDataAdapter()
    Dim dsContainer As New DataSet()
    Dim strBillNoOg As String

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
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbCon As System.Windows.Forms.ListBox
    Friend WithEvents btnTrans As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbBillNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnBackAll As System.Windows.Forms.Button
    Friend WithEvents btnTransAll As System.Windows.Forms.Button
    Friend WithEvents lbCount As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConHatchCargo_TransRelation))
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbCon = New System.Windows.Forms.ListBox
        Me.btnTrans = New System.Windows.Forms.Button
        Me.btnBack = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbBillNo = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnBackAll = New System.Windows.Forms.Button
        Me.btnTransAll = New System.Windows.Forms.Button
        Me.lbCount = New System.Windows.Forms.Label
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(368, 352)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 586
        Me.btQuit.Text = "�˳�"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(300, 352)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 585
        Me.btSave.Text = "ȷ��"
        '
        'C1DBG
        '
        Me.C1DBG.AllowFilter = False
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.AllowUpdate = False
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 30)
        Me.C1DBG.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.RecordSelectorWidth = 16
        Me.C1DBG.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1DBG.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG.RowHeight = 16
        Me.C1DBG.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG.Size = New System.Drawing.Size(196, 358)
        Me.C1DBG.TabIndex = 584
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style14{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" & _
        "tyle1{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Back" & _
        "Color:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" AllowRowSizing=""None"" CaptionH" & _
        "eight=""18"" ColumnCaptionHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""Dotted" & _
        "CellBorder"" RecordSelectorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1""" & _
        " HorizontalScrollGroup=""1""><ClientRect>0, 0, 192, 354</ClientRect><BorderSide>0<" & _
        "/BorderSide><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Ed" & _
        "itor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle" & _
        " parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><G" & _
        "roupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style" & _
        "2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><InactiveStyle paren" & _
        "t=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSel" & _
        "ectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selecte" & _
        "d"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.Merg" & _
        "eView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal" & _
        """ me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" m" & _
        "e=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=" & _
        """Selected"" /><Style parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""Hig" & _
        "hlightRow"" /><Style parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""Od" & _
        "dRow"" /><Style parent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=" & _
        """FilterBar"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</" & _
        "vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16" & _
        "</DefaultRecSelWidth><ClientArea>0, 0, 192, 354</ClientArea><PrintPageHeaderStyl" & _
        "e parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob" & _
        ">"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 23)
        Me.Label1.TabIndex = 583
        Me.Label1.Text = "���ᵥ���м�װ���"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbCon
        '
        Me.lbCon.ItemHeight = 12
        Me.lbCon.Location = New System.Drawing.Point(296, 84)
        Me.lbCon.Name = "lbCon"
        Me.lbCon.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbCon.Size = New System.Drawing.Size(142, 256)
        Me.lbCon.Sorted = True
        Me.lbCon.TabIndex = 587
        '
        'btnTrans
        '
        Me.btnTrans.Location = New System.Drawing.Point(214, 118)
        Me.btnTrans.Name = "btnTrans"
        Me.btnTrans.Size = New System.Drawing.Size(65, 24)
        Me.btnTrans.TabIndex = 589
        Me.btnTrans.Text = ">"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(214, 164)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(65, 24)
        Me.btnBack.TabIndex = 588
        Me.btnBack.Text = "<"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(296, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 23)
        Me.Label2.TabIndex = 590
        Me.Label2.Text = "Ҫ���ĵ����"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbBillNo
        '
        Me.cbBillNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBillNo.Location = New System.Drawing.Point(296, 32)
        Me.cbBillNo.Name = "cbBillNo"
        Me.cbBillNo.Size = New System.Drawing.Size(142, 20)
        Me.cbBillNo.TabIndex = 591
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(296, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 23)
        Me.Label3.TabIndex = 592
        Me.Label3.Text = "ѡ���ᵥ��"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBackAll
        '
        Me.btnBackAll.Location = New System.Drawing.Point(214, 282)
        Me.btnBackAll.Name = "btnBackAll"
        Me.btnBackAll.Size = New System.Drawing.Size(65, 24)
        Me.btnBackAll.TabIndex = 593
        Me.btnBackAll.Text = "<<"
        '
        'btnTransAll
        '
        Me.btnTransAll.Location = New System.Drawing.Point(214, 236)
        Me.btnTransAll.Name = "btnTransAll"
        Me.btnTransAll.Size = New System.Drawing.Size(65, 24)
        Me.btnTransAll.TabIndex = 594
        Me.btnTransAll.Text = ">>"
        '
        'lbCount
        '
        Me.lbCount.Location = New System.Drawing.Point(384, 60)
        Me.lbCount.Name = "lbCount"
        Me.lbCount.Size = New System.Drawing.Size(54, 23)
        Me.lbCount.TabIndex = 595
        Me.lbCount.Text = "��0��"
        Me.lbCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmConHatchCargo_TransRelation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(458, 387)
        Me.Controls.Add(Me.lbCount)
        Me.Controls.Add(Me.btnTransAll)
        Me.Controls.Add(Me.btnBackAll)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbBillNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnTrans)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lbCon)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConHatchCargo_TransRelation"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "��װ��յ���Ϣ �������ᵥ��ϵ"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmConHatchCargo_TransRelation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strBillNoOg = FrmConHatchCargo.Bill_ID.ToUpper
        sqlContainer = "SELECT CON_HATCH_CARGO_ID, CONTAINER_NO, BLNO, mark, USER_NAME FROM CON_HATCH_CARGO WHERE SHIP_ID = '" & Ship_ID & "' AND BLNO = '" & strBillNoOg & "' ORDER BY CONTAINER_NO "
        FillC1()

        Dim sqlBillNo As String
        sqlBillNo = "SELECT BLNO, MARK FROM CON_HATCH_LIST WHERE SHIP_ID = '" & Ship_ID & "' AND BLNO <> '" & strBillNoOg & "'"
        'sqlBillNo = "SELECT BLNO, MARK FROM CON_HATCH_LIST WHERE SHIP_ID = '" & Ship_ID & "'"
        Dim dvBillNo As New DataView()
        dvBillNo = Filldata(sqlBillNo)
        Me.cbBillNo.DataSource = dvBillNo
        Me.cbBillNo.DisplayMember = "BLNO"
        Me.cbBillNo.ValueMember = "MARK"
    End Sub

    Private Sub FillC1()
        Me.C1DBG.DataSource = Updatedata(adContainer, sqlContainer, dsContainer)
        Me.C1DBG.Columns("CONTAINER_NO").Caption = "��װ���"
        Me.C1DBG.Columns("BLNO").Caption = "�ᵥ��"
        Me.C1DBG.Splits(0).DisplayColumns("CON_HATCH_CARGO_ID").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns("USER_NAME").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns("mark").Visible = False
        Me.C1DBG.FetchRowStyles = True
        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        'Me.C1DBG.ColumnFooters = True
        Me.C1DBG.Columns("CONTAINER_NO").FooterText = "�ϼ�" & dsContainer.Tables(0).Rows.Count & "��"
    End Sub

    Private Sub btnTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrans.Click
        Dim i, j As Integer
        Try
            If Me.C1DBG.SelectedRows.Count > 0 Then     'ѡ��ʱ
                For i = 0 To Me.C1DBG.SelectedRows.Count - 1
                    Me.C1DBG.Row = Me.C1DBG.SelectedRows.Item(i)

                    If cbBillNo.Text <> strBillNoOg Then '����ʱ
                        If Me.C1DBG.Columns("BLNO").Text = strBillNoOg Then  'û�б�ѡ�У���δ���������
                            Me.lbCon.Items.Add(Me.C1DBG.Columns("CONTAINER_NO").Text)
                            Me.C1DBG.Columns("BLNO").Text = Me.cbBillNo.Text    '����ᵥ��
                        End If
                    Else    '�����ʱ�����ǻ�ԭ   �����ᵥ������������ȥԭ�ᵥ�ţ��Ͳ����ڴ����
                        For j = 0 To Me.lbCon.Items.Count - 1
                            If Me.C1DBG.Columns("CONTAINER_NO").Text = Me.lbCon.Items.Item(j) Then
                                Exit For
                            End If
                        Next
                        If j >= Me.lbCon.Items.Count Then   'û�б�ѡ��
                            Me.lbCon.Items.Add(Me.C1DBG.Columns("CONTAINER_NO").Text)
                        End If
                    End If
                Next
                lbCount.Text = "��" & Me.lbCon.Items.Count & "��"
                Me.C1DBG.Row += 1
                Me.C1DBG.Row -= 1
            Else        'δѡ��ʱ��ȡ��ǰ��
                Me.C1DBG_DoubleClick(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub C1DBG_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.DoubleClick
        If cbBillNo.Text <> strBillNoOg Then '����ʱ
            If Me.C1DBG.Columns("BLNO").Text = strBillNoOg Then   'û�б�ѡ��,��δ���������
                Me.lbCon.Items.Add(Me.C1DBG.Columns("CONTAINER_NO").Text)
                Me.C1DBG.Columns("BLNO").Text = Me.cbBillNo.Text    '����ᵥ��
            End If
        Else    '�����ʱ�����ǻ�ԭ   �����ᵥ������������ȥԭ�ᵥ�ţ��Ͳ����ڴ����
            Dim i As Integer
            For i = 0 To Me.lbCon.Items.Count - 1
                If Me.C1DBG.Columns("CONTAINER_NO").Text = Me.lbCon.Items.Item(i) Then
                    Exit For
                End If
            Next
            If i >= Me.lbCon.Items.Count Then   'û�б�ѡ��
                Me.lbCon.Items.Add(Me.C1DBG.Columns("CONTAINER_NO").Text)
            End If
        End If
        lbCount.Text = "��" & Me.lbCon.Items.Count & "��"
        Me.C1DBG.Row += 1
        Me.C1DBG.Row -= 1
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'If Me.lbCon.SelectedIndex >= 0 Then
        '    Me.lbCon.Items.RemoveAt(Me.lbCon.SelectedIndex)
        '    lbCount.Text = "��" & Me.lbCon.Items.Count & "��"
        'End If
        Dim i, j, Count As Integer
        Count = Me.lbCon.SelectedItems.Count
        For i = 0 To Count - 1
            For j = 0 To dsContainer.Tables(0).Rows.Count - 1
                Me.C1DBG.Row = j
                If Me.lbCon.SelectedItems.Item(0) = Me.C1DBG.Columns("CONTAINER_NO").Text Then
                    Me.C1DBG.Columns("BLNO").Text = strBillNoOg     '��ԭ�ᵥ��
                    Exit For
                End If
            Next
            Me.lbCon.Items.Remove(Me.lbCon.SelectedItems.Item(0))
        Next
        lbCount.Text = "��" & Me.lbCon.Items.Count & "��"
        Me.C1DBG.Row += 1
        Me.C1DBG.Row -= 1
    End Sub

    Private Sub lbCon_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbCon.DoubleClick
        If Me.lbCon.SelectedIndex >= 0 Then
            Dim i As Integer
            For i = 0 To dsContainer.Tables(0).Rows.Count - 1
                Me.C1DBG.Row = i
                If Me.C1DBG.Columns("CONTAINER_NO").Text = Me.lbCon.SelectedItem Then
                    Me.C1DBG.Columns("BLNO").Text = strBillNoOg     '��ԭ�ᵥ��
                    Exit For
                End If
            Next
            '˫��ʱ�Ƴ������б���д������µ�һ�������굱ǰ��ָ��
            Me.lbCon.Items.RemoveAt(Me.lbCon.SelectedIndex)
            lbCount.Text = "��" & Me.lbCon.Items.Count & "��"
            Me.C1DBG.Row += 1
            Me.C1DBG.Row -= 1
        End If
    End Sub

    Private Sub btnTransAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransAll.Click
        Dim i As Integer
        Try
            Me.lbCon.Items.Clear()
            For i = 0 To dsContainer.Tables(0).Rows.Count - 1
                Me.C1DBG.Row = i
                'If Me.C1DBG.Columns("BLNO").Text = strBillNoOg Then     '��δ���������
                Me.lbCon.Items.Add(Me.C1DBG.Columns("CONTAINER_NO").Text)
                Me.C1DBG.Columns("BLNO").Text = Me.cbBillNo.Text    '����ᵥ��
                'End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        lbCount.Text = "��" & Me.lbCon.Items.Count & "��"
        Me.C1DBG.Row += 1
        Me.C1DBG.Row -= 1
    End Sub

    Private Sub btnBackAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackAll.Click
        Me.lbCon.Items.Clear()
        Dim i As Integer
        For i = 0 To dsContainer.Tables(0).Rows.Count - 1
            Me.C1DBG.Row = i
            'If Me.C1DBG.Columns("BLNO").Text <> strBillNoOg Then
            Me.C1DBG.Columns("BLNO").Text = strBillNoOg     '��ԭ�ᵥ��
            'End If
        Next
        lbCount.Text = "��" & Me.lbCon.Items.Count & "��"
        Me.C1DBG.Row += 1
        Me.C1DBG.Row -= 1
    End Sub

    Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        If String.Compare(Me.C1DBG.Columns("BLNO").CellValue(e.Row), strBillNoOg, True) <> 0 Then
            e.CellStyle.BackColor = System.Drawing.Color.Maroon
        End If
    End Sub

    Private Sub cbBillNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBillNo.SelectedIndexChanged
        Try
            Dim i, j As Integer
            For i = 0 To Me.lbCon.Items.Count - 1
                For j = 0 To dsContainer.Tables(0).Rows.Count - 1
                    Me.C1DBG.Row = j
                    If Me.lbCon.Items.Item(i) = Me.C1DBG.Columns("CONTAINER_NO").Text Then
                        Me.C1DBG.Columns("BLNO").Text = Me.cbBillNo.Text    '�ٱ���ᵥ��
                        Exit For
                    End If
                Next
            Next
            Me.C1DBG.Row += 1
            Me.C1DBG.Row -= 1
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim i, j As Integer
        Try
            If Me.cbBillNo.Items.Count > 0 And Me.lbCon.Items.Count > 0 Then
                If MessageBox.Show("ȷ��Ҫ������ϼ�װ����ᵥ��ϵô��", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                    For i = 0 To Me.lbCon.Items.Count - 1
                        For j = 0 To dsContainer.Tables(0).Rows.Count - 1
                            Me.C1DBG.Row = j
                            If Me.lbCon.Items.Item(i) = Me.C1DBG.Columns("CONTAINER_NO").Text Then
                                Me.C1DBG.Columns("BLNO").Text = Me.cbBillNo.Text
                                'Me.C1DBG.Columns("mark").Text = Me.cbBillNo.SelectedValue
                                Me.C1DBG.Columns("USER_NAME").Text = G_User
                                Exit For
                            End If
                        Next
                    Next

                    Me.C1DBG.Row += 1
                    Me.C1DBG.Row -= 1
                    Me.cbBillNo.Focus()
                    adContainer.Update(dsContainer)
                    FillC1()
                    Me.lbCon.Items.Clear()
                    Me.lbCount.Text = "��0��"
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

End Class
