Imports TALLY.DBControl
Imports Microsoft.VisualBasic
Public Class FRMCON_TALLY_LIST_FIND
    Inherits System.Windows.Forms.Form
    Dim ds As New DataSet
    Dim dw As New DataView
    Dim dsload As New DataSet
    Dim dsunload As New DataSet
    Dim dwload As New DataView
    Dim dwunload As New DataView

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
    Friend WithEvents C1IMAGE As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Txtseachbay As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtCONTAINERNO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtCHANGE As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RBROW As System.Windows.Forms.RadioButton
    Friend WithEvents RBCOL As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRMCON_TALLY_LIST_FIND))
        Dim GridLines1 As C1.Win.C1TrueDBGrid.Util.GridLines = New C1.Win.C1TrueDBGrid.Util.GridLines
        Me.C1IMAGE = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Txtseachbay = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtCONTAINERNO = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtCHANGE = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RBROW = New System.Windows.Forms.RadioButton
        Me.RBCOL = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.C1IMAGE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1IMAGE
        '
        Me.C1IMAGE.AllowFilter = True
        Me.C1IMAGE.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.C1IMAGE.AllowSort = True
        Me.C1IMAGE.CaptionHeight = 18
        Me.C1IMAGE.CollapseColor = System.Drawing.Color.Black
        Me.C1IMAGE.DataChanged = False
        Me.C1IMAGE.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.C1IMAGE.ExpandColor = System.Drawing.Color.Black
        Me.C1IMAGE.FetchRowStyles = True
        Me.C1IMAGE.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1IMAGE.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1IMAGE.Location = New System.Drawing.Point(4, 46)
        Me.C1IMAGE.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1IMAGE.Name = "C1IMAGE"
        Me.C1IMAGE.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1IMAGE.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1IMAGE.PreviewInfo.ZoomFactor = 75
        Me.C1IMAGE.PrintInfo.ShowOptionsDialog = False
        Me.C1IMAGE.RecordSelectorWidth = 17
        GridLines1.Color = System.Drawing.Color.DarkGray
        GridLines1.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1IMAGE.RowDivider = GridLines1
        Me.C1IMAGE.RowHeight = 16
        Me.C1IMAGE.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1IMAGE.ScrollTips = False
        Me.C1IMAGE.Size = New System.Drawing.Size(388, 472)
        Me.C1IMAGE.TabIndex = 152
        Me.C1IMAGE.Text = "C1TrueDBGrid1"
        Me.C1IMAGE.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style1{}Od" & _
        "dRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control;Bord" & _
        "er:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style10{Al" & _
        "ignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styles><Splits><C1.Win" & _
        ".C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCaptionHeight=""18"" Colu" & _
        "mnFooterHeight=""18"" FetchRowStyles=""True"" MarqueeStyle=""DottedCellBorder"" Record" & _
        "SelectorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1"" HorizontalScrollG" & _
        "roup=""1""><ClientRect>0, 0, 384, 468</ClientRect><BorderSide>0</BorderSide><Capti" & _
        "onStyle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" " & _
        "/><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar" & _
        """ me=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""" & _
        "Group"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRow" & _
        "Style parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""S" & _
        "tyle4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=" & _
        """RecordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><" & _
        "Style parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><Na" & _
        "medStyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><" & _
        "Style parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Sty" & _
        "le parent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Styl" & _
        "e parent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Styl" & _
        "e parent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style par" & _
        "ent=""Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Sty" & _
        "le parent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSp" & _
        "lits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17</DefaultRecSelWid" & _
        "th><ClientArea>0, 0, 384, 468</ClientArea></Blob>"
        '
        'Txtseachbay
        '
        Me.Txtseachbay.Location = New System.Drawing.Point(38, 14)
        Me.Txtseachbay.MaxLength = 2
        Me.Txtseachbay.Name = "Txtseachbay"
        Me.Txtseachbay.Size = New System.Drawing.Size(30, 21)
        Me.Txtseachbay.TabIndex = 162
        Me.Txtseachbay.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 22)
        Me.Label10.TabIndex = 161
        Me.Label10.Text = "贝号"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtCONTAINERNO
        '
        Me.TxtCONTAINERNO.Location = New System.Drawing.Point(240, 14)
        Me.TxtCONTAINERNO.MaxLength = 20
        Me.TxtCONTAINERNO.Name = "TxtCONTAINERNO"
        Me.TxtCONTAINERNO.Size = New System.Drawing.Size(74, 21)
        Me.TxtCONTAINERNO.TabIndex = 164
        Me.TxtCONTAINERNO.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(184, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 22)
        Me.Label4.TabIndex = 163
        Me.Label4.Text = "查找箱号"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtCHANGE
        '
        Me.BtCHANGE.Location = New System.Drawing.Point(322, 12)
        Me.BtCHANGE.Name = "BtCHANGE"
        Me.BtCHANGE.Size = New System.Drawing.Size(65, 24)
        Me.BtCHANGE.TabIndex = 214
        Me.BtCHANGE.Text = "转换"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBROW)
        Me.GroupBox1.Controls.Add(Me.RBCOL)
        Me.GroupBox1.Location = New System.Drawing.Point(70, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(112, 30)
        Me.GroupBox1.TabIndex = 215
        Me.GroupBox1.TabStop = False
        '
        'RBROW
        '
        Me.RBROW.Location = New System.Drawing.Point(58, 10)
        Me.RBROW.Name = "RBROW"
        Me.RBROW.Size = New System.Drawing.Size(50, 20)
        Me.RBROW.TabIndex = 163
        Me.RBROW.Text = "按层"
        '
        'RBCOL
        '
        Me.RBCOL.Location = New System.Drawing.Point(6, 10)
        Me.RBCOL.Name = "RBCOL"
        Me.RBCOL.Size = New System.Drawing.Size(50, 20)
        Me.RBCOL.TabIndex = 162
        Me.RBCOL.Text = "按列"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(90, 522)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 216
        Me.Label1.Text = "未理："
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(140, 522)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 217
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(190, 522)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 20)
        Me.Label3.TabIndex = 218
        Me.Label3.Text = "已理："
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.PaleGreen
        Me.Label5.Location = New System.Drawing.Point(240, 522)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 219
        '
        'FRMCON_TALLY_LIST_FIND
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(396, 544)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtCHANGE)
        Me.Controls.Add(Me.TxtCONTAINERNO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txtseachbay)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.C1IMAGE)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMCON_TALLY_LIST_FIND"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "理箱单_查箱"
        CType(Me.C1IMAGE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FRMCON_TALLY_LIST_FIND_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GETIMAGE()
    End Sub
    Private Sub GETIMAGE()
        Try
            dw = Getdata("select * from VIEWCON_TALLY_CHANGE where ship_id='" & Ship_ID & "' order by bayno", ds)
            C1IMAGE.DataSource = dw
            C1IMAGE.Splits(0).DisplayColumns.Item("CON_HATCH_RECORD_ID").Visible = False
            C1IMAGE.Splits(0).DisplayColumns.Item("SHIP_ID").Visible = False
            C1IMAGE.Splits(0).DisplayColumns.Item("unload_mark").Visible = False
            C1IMAGE.Columns.Item("CONTAINER_NO").Caption = "箱号"
            C1IMAGE.Columns.Item("SEALNO").Caption = "铅封号"
            C1IMAGE.Columns.Item("BAYNO").Caption = "贝位号"
            C1IMAGE.Columns.Item("SIZE_CON").Caption = "尺寸"
            C1IMAGE.Columns.Item("FULLOREMPTY").Caption = "空/重"
            C1IMAGE.Columns.Item("baycol").Caption = "列"
            C1IMAGE.Columns.Item("bayrow").Caption = "层"
            C1IMAGE.Splits(0).DisplayColumns.Item("CONTAINER_NO").Width = 80
            C1IMAGE.Splits(0).DisplayColumns.Item("SEALNO").Width = 80
            C1IMAGE.Splits(0).DisplayColumns.Item("BAYNO").Width = 30
            C1IMAGE.Splits(0).DisplayColumns.Item("SIZE_CON").Width = 30
            C1IMAGE.Splits(0).DisplayColumns.Item("FULLOREMPTY").Width = 40
            C1IMAGE.Splits(0).DisplayColumns.Item("baycol").Width = 30
            C1IMAGE.Splits(0).DisplayColumns.Item("bayrow").Width = 30

            Me.C1IMAGE.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
            'Me.C1IMAGE.ColumnFooters = True
            'Me.C1IMAGE.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
            'Me.C1IMAGE.Columns("CONTAINER_NO").FooterText = "合计" & dw.Count & "条"

            C1IMAGE.Refresh()
            If RBCOL.Checked = True Then
                dw.Sort = "baycol asc"
            Else
                dw.Sort = "bayrow asc"
            End If
            C1IMAGE.Refresh()
            dwunload = Getdata("select * from con_hatch_record where ship_id='" & Ship_ID & "' and unload_mark='0'", dsunload)
            Label2.Text = dsunload.Tables(0).Rows.Count
            dwload = Getdata("select * from con_hatch_record where ship_id='" & Ship_ID & "' and unload_mark='1'", dsload)
            Label5.Text = dsload.Tables(0).Rows.Count
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub C1IMAGE_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1IMAGE.FetchRowStyle
        If Me.C1IMAGE.Columns("UNLOAD_MARK").CellValue(e.Row) = 0 Then
            e.CellStyle.BackColor = System.Drawing.Color.White
        Else
            e.CellStyle.BackColor = System.Drawing.Color.PaleGreen
        End If
    End Sub
    Private Sub Txtseachbay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtseachbay.TextChanged
        Dim dsquery As New DataSet
        Try
            If Len(Trim(Txtseachbay.Text)) > 0 And RBCOL.Checked = True Then
                dw.RowFilter = "bayno like '" & Txtseachbay.Text & "%'"
                dw.Sort = "baycol asc"
                C1IMAGE.Refresh()
            ElseIf Len(Trim(Txtseachbay.Text)) > 0 Then
                dw.RowFilter = "bayno like '" & Txtseachbay.Text & "%' "
                dw.Sort = "bayrow asc"
                C1IMAGE.Refresh()
            Else
                dw.RowFilter = "1=1"
                If RBCOL.Checked = True Then
                    dw.Sort = "baycol asc"
                Else
                    dw.Sort = "bayrow asc"
                End If
            End If
            C1IMAGE.Refresh()
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TxtCONTAINERNO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCONTAINERNO.TextChanged
        Dim dsquery As New DataSet
        Try
            If Len(Trim(TxtCONTAINERNO.Text)) > 0 Then
                'dw = Getdata("select CON_HATCH_RECORD_ID,CONTAINER_NO,SIZE_CON,FULLOREMPTY,weight,SEALNO,BAYNO from VIEWCON_TALLY_HATCH where ship_id='" & Ship_ID & "' and CONTAINER_NO like '%" & Trim(TxtCONTAINERNO.Text) & "%' and bayno like '" & Txtseachbay.Text & "%'", dsquery)
                ds.Reset()
                dw = Getdata("select * from VIEWCON_TALLY_CHANGE where ship_id='" & Ship_ID & "' and CONTAINER_NO like '%" & Trim(TxtCONTAINERNO.Text) & "%' and bayno like '" & Txtseachbay.Text & "%'", ds)
                C1IMAGE.DataSource = dw
                C1IMAGE.Splits(0).DisplayColumns.Item("CON_HATCH_RECORD_ID").Visible = False
                C1IMAGE.Splits(0).DisplayColumns.Item("SHIP_ID").Visible = False
                C1IMAGE.Splits(0).DisplayColumns.Item("unload_mark").Visible = False
                C1IMAGE.Columns.Item("CONTAINER_NO").Caption = "箱号"
                C1IMAGE.Columns.Item("SEALNO").Caption = "铅封号"
                C1IMAGE.Columns.Item("BAYNO").Caption = "贝位号"
                C1IMAGE.Columns.Item("SIZE_CON").Caption = "尺寸"
                C1IMAGE.Columns.Item("FULLOREMPTY").Caption = "空/重"
                C1IMAGE.Columns.Item("baycol").Caption = "列"
                C1IMAGE.Columns.Item("bayrow").Caption = "层"
                C1IMAGE.Splits(0).DisplayColumns.Item("CONTAINER_NO").Width = 80
                C1IMAGE.Splits(0).DisplayColumns.Item("SEALNO").Width = 80
                C1IMAGE.Splits(0).DisplayColumns.Item("BAYNO").Width = 30
                C1IMAGE.Splits(0).DisplayColumns.Item("SIZE_CON").Width = 30
                C1IMAGE.Splits(0).DisplayColumns.Item("FULLOREMPTY").Width = 40
                C1IMAGE.Splits(0).DisplayColumns.Item("baycol").Width = 30
                C1IMAGE.Splits(0).DisplayColumns.Item("bayrow").Width = 30

                Me.C1IMAGE.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
                C1IMAGE.Refresh()
                If RBCOL.Checked = True Then
                    dw.Sort = "baycol,bayrow"
                ElseIf RBROW.Checked = True Then
                    dw.Sort = "bayrow,baycol"
                End If
            ElseIf Len(Trim(Txtseachbay.Text)) > 0 Then
                Call Txtseachbay_TextChanged(sender, e)
            Else
                Call GETIMAGE()
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtCHANGE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtCHANGE.Click
        Dim i As Integer
        Dim j As Integer
        Dim q As Integer
        Try

            If Me.C1IMAGE.SelectedRows.Count > 0 Then
                For i = 0 To Me.C1IMAGE.SelectedRows.Count - 1
                    Me.C1IMAGE.Row = Me.C1IMAGE.SelectedRows.Item(i)
                    If Me.C1IMAGE.Columns.Item("unload_mark").Value = "0" Then
                        ExecSql("update con_hatch_record set unload_mark='1' where con_hatch_record_id='" & Me.C1IMAGE.Columns.Item("con_hatch_record_id").Value & "'")
                        ExecSql("update con_image set Unload_Mark='1' where ship_id='" & Ship_ID & "' and container_no='" & Me.C1IMAGE.Columns.Item("container_no").Value & "'")
                    Else
                        ExecSql("update con_hatch_record set unload_mark='0' where con_hatch_record_id='" & Me.C1IMAGE.Columns.Item("con_hatch_record_id").Value & "'")
                        ExecSql("update con_image set Unload_Mark='0' where ship_id='" & Ship_ID & "' and container_no='" & Me.C1IMAGE.Columns.Item("container_no").Value & "'")
                    End If
                Next
                Me.C1IMAGE.Row = Me.C1IMAGE.SelectedRows.Item(0)

            ElseIf ds.Tables(0).Rows.Count > 0 Then
                If Me.C1IMAGE.Columns.Item("unload_mark").Value = "0" Then
                    ExecSql("update con_hatch_record set unload_mark='1' where con_hatch_record_id='" & Me.C1IMAGE.Columns.Item("con_hatch_record_id").Value & "'")
                    ExecSql("update con_image set Unload_Mark='1' where ship_id='" & Ship_ID & "' and container_no='" & Me.C1IMAGE.Columns.Item("container_no").Value & "'")
                Else
                    ExecSql("update con_hatch_record set unload_mark='0' where con_hatch_record_id='" & Me.C1IMAGE.Columns.Item("con_hatch_record_id").Value & "'")
                    ExecSql("update con_image set Unload_Mark='0' where ship_id='" & Ship_ID & "' and container_no='" & Me.C1IMAGE.Columns.Item("container_no").Value & "'")
                End If
            Else
                MsgBox("请选择需要转换的箱子！")
                Exit Sub
            End If
            Call GETIMAGE()
            Call Txtseachbay_TextChanged(sender, e)
            Me.C1IMAGE.Refresh()
        Catch ex As System.Exception
            MsgBox(ex.Message)
            Call GETIMAGE()
            Call Txtseachbay_TextChanged(sender, e)
            Me.C1IMAGE.Refresh()
        End Try
    End Sub
    Private Sub TxtCONTAINERNO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCONTAINERNO.KeyPress
        If e.KeyChar = Chr(13) Then
            BtCHANGE.Focus()
        End If
    End Sub
End Class
