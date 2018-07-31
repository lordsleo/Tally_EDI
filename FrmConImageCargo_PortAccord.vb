Imports TALLY.DBControl
Public Class FrmConImageCargo_PortAccord
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents lbAll As System.Windows.Forms.ListBox
    Friend WithEvents lbSelect As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConImageCargo_PortAccord))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnDel = New System.Windows.Forms.Button
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btnQuit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.lbAll = New System.Windows.Forms.ListBox
        Me.lbSelect = New System.Windows.Forms.ListBox
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "可选箱主"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(276, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "将作同步处理箱主"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(200, 44)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(68, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "-->"
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(200, 112)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(68, 23)
        Me.btnDel.TabIndex = 5
        Me.btnDel.Text = "<--"
        '
        'C1DBG
        '
        Me.C1DBG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 164)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.Size = New System.Drawing.Size(468, 324)
        Me.C1DBG.TabIndex = 6
        Me.C1DBG.Text = "C1TrueDBGrid1"
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle12{}OddRow{}RecordSelector{AlignImage:Center;}Style13{}Heading{Wrap:True;Back" & _
        "Color:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style14{}Style15{}Style9{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSele" & _
        "ctorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><Height>320</Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorSty" & _
        "le parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><F" & _
        "ilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=" & _
        """Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Headi" & _
        "ng"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><Inacti" & _
        "veStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9""" & _
        " /><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle pa" & _
        "rent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0" & _
        ", 0, 464, 320</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderS" & _
        "tyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""" & _
        "Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Foot" & _
        "er"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactiv" & _
        "e"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /" & _
        "><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" " & _
        "/><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelecto" & _
        "r"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" " & _
        "/></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None" & _
        "</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 464, 320</" & _
        "ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle " & _
        "parent="""" me=""Style15"" /></Blob>"
        '
        'btnQuit
        '
        Me.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQuit.Location = New System.Drawing.Point(288, 496)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(68, 23)
        Me.btnQuit.TabIndex = 8
        Me.btnQuit.Text = "退出"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(188, 496)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(68, 23)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "确定"
        '
        'lbAll
        '
        Me.lbAll.ItemHeight = 12
        Me.lbAll.Location = New System.Drawing.Point(0, 24)
        Me.lbAll.MultiColumn = True
        Me.lbAll.Name = "lbAll"
        Me.lbAll.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbAll.Size = New System.Drawing.Size(192, 136)
        Me.lbAll.TabIndex = 9
        '
        'lbSelect
        '
        Me.lbSelect.ItemHeight = 12
        Me.lbSelect.Location = New System.Drawing.Point(276, 24)
        Me.lbSelect.Name = "lbSelect"
        Me.lbSelect.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbSelect.Size = New System.Drawing.Size(192, 136)
        Me.lbSelect.TabIndex = 10
        '
        'FrmConImageCargo_PortAccord
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btnQuit
        Me.ClientSize = New System.Drawing.Size(468, 521)
        Me.Controls.Add(Me.lbSelect)
        Me.Controls.Add(Me.lbAll)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmConImageCargo_PortAccord"
        Me.Text = "集装箱船图信息 同步卸港目的地"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public blSave As Boolean
    Dim sqlAllCompany As String
    Dim dvAllCompany As DataView
    Dim dvSelect As DataView
    Dim sqlCon As String
    Dim dvCon As DataView
    Dim ListComp As String = "''"

    Private Sub FrmConImageCargo_PortAccord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        sqlAllCompany = "select A.Code_Con_Company,A.Code_Con_Company +' '+ IsNull(Con_Company_CHI,'') Con_Company_CHI from (select Code_Con_Company from Con_Image where ship_ID=" & Ship_ID & " group by Code_Con_Company) A " & _
            " left join Code_Con_Company B on A.Code_Con_Company=B.Code_Con_Company order by A.Code_Con_Company"
        dvAllCompany = Filldata(sqlAllCompany)

        Me.lbAll.DataSource = dvAllCompany
        Me.lbAll.DisplayMember = "Con_Company_CHI"
        Me.lbAll.ValueMember = "Code_Con_Company"
        'Dim r As Single
        'If Me.clbAll.Splits(0).DisplayColumns("Code_Con_Company").Width = 0 OrElse Me.clbAll.Splits(0).DisplayColumns("Con_Company_CHI").Width Then
        '    r = 0.5
        'Else
        '    r = Me.clbAll.Splits(0).DisplayColumns("Code_Con_Company").Width / (Me.clbAll.Splits(0).DisplayColumns("Code_Con_Company").Width + Me.clbAll.Splits(0).DisplayColumns("Con_Company_CHI").Width)
        'End If
        'Me.clbAll.Splits(0).DisplayColumns("Code_Con_Company").Width = (Me.clbAll.Width - 20) * r
        'Me.clbAll.Splits(0).DisplayColumns("Con_Company_CHI").Width = (Me.clbAll.Width - 20) * (1 - r)
        dvSelect = dvAllCompany.Table.Clone.DefaultView
        Me.lbSelect.DataSource = dvSelect
        Me.lbSelect.DisplayMember = "Con_Company_CHI"
        Me.lbSelect.ValueMember = "Code_Con_Company"
        'Me.clbSelect.ColumnHeaders = False
        'Me.clbSelect.Splits(0).DisplayColumns("Code_Con_Company").Width = Me.clbAll.Splits(0).DisplayColumns("Code_Con_Company").Width
        'Me.clbSelect.Splits(0).DisplayColumns("Con_Company_CHI").Width = Me.clbAll.Splits(0).DisplayColumns("Con_Company_CHI").Width

        sqlCon = "SELECT Code_Con_Company,A.CONTAINER_NO,A.CODE_UNLOAD_PORT,A.CODE_DELIVERY,B.CODE_UNLOAD_PORT CODE_UNLOAD_PORT2,B.CODE_PLACE_RECEIVE " & _
            " FROM CON_IMAGE A LEFT JOIN View_HatchCargoAccord B ON A.SHIP_ID = B.SHIP_ID AND A.CONTAINER_NO = B.CONTAINER_NO WHERE A.SHIP_ID =" & Ship_ID & " order by A.CONTAINER_NO"
        dvCon = Filldata(sqlCon)
        Me.C1DBG.DataSource = dvCon
        Me.C1DBG.Columns("Code_Con_Company").Caption = "箱主"
        Me.C1DBG.Columns("CONTAINER_NO").Caption = "箱号"
        Me.C1DBG.Columns("CODE_UNLOAD_PORT").Caption = "船图卸港"
        Me.C1DBG.Columns("CODE_DELIVERY").Caption = "船图交货地"
        Me.C1DBG.Columns("CODE_UNLOAD_PORT2").Caption = "舱单卸港"
        Me.C1DBG.Columns("CODE_PLACE_RECEIVE").Caption = "舱单交货地"
        SetDGWidth2(Me.C1DBG)
        dvCon.RowFilter = "Code_Con_Company=''"
        Me.C1DBG.Columns("CONTAINER_NO").FooterText = "计" & dvCon.Count & "项"

        Dim cellStyle As New C1.Win.C1TrueDBGrid.Style      'C1Grid风格
        cellStyle.BackColor = System.Drawing.Color.MistyRose    '雾色玫瑰
        Me.C1DBG.Splits(0).AddCellStyle(C1.Win.C1TrueDBGrid.CellStyleFlag.CurrentCell, cellStyle)
        Me.C1DBG.Splits(0).DisplayColumns("CODE_UNLOAD_PORT").FetchStyle = True
        Me.C1DBG.Splits(0).DisplayColumns("CODE_DELIVERY").FetchStyle = True
        Me.C1DBG.Splits(0).DisplayColumns("CODE_UNLOAD_PORT2").FetchStyle = True
        Me.C1DBG.Splits(0).DisplayColumns("CODE_PLACE_RECEIVE").FetchStyle = True
        Me.C1DBG.ColumnFooters = True

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            '使用C1List的问题。先是其SelectedIndices中索引值是按先后选取顺序排列，所以是无序的，不好作删除
            '而且当删除一个选择项后，其值也不会更新，导致无法继续正确删除。所以基本不能做删除
            'Dim i, iSelect As Integer
            'iSelect = Me.clbAll.SelectedIndices.Count
            'For i = 0 To iSelect - 1
            '    Dim oldRow, newRow As Data.DataRow
            '    oldRow = dvAllCompany.Table.Rows(Me.clbAll.SelectedIndices.Item(0))
            '    'dvAllCompany.Delete(Me.clbAll.SelectedIndices.Item(0))
            '    newRow = dvSelect.Table.NewRow
            '    newRow(0) = oldRow(0)
            '    newRow(1) = oldRow(1)
            '    dvSelect.Table.Rows.Add(newRow)
            '    'dvAllCompany.Table.Rows.Remove(oldRow)
            '    'dvAllCompany.Delete(Me.clbAll.SelectedIndices.Item(0)) '也有问题，导致再次删除时出错
            '    Me.clbAll.RemoveItem(Me.clbAll.SelectedIndices.Item(0)) '无效
            '    Me.clbAll.SelectedIndices.RemoveAt(0)   '清除索引记录，而不是删除该行
            'Next
            'Me.clbAll.SelectedIndices.Clear() '否则不会自行清空

            '这里使用ListBox，也是有问题。ListBox的好处是，有SelectedItems。而且和SelectedIndices都是按在ListBox中位置排序的。
            '问题是当绑定数据源时，不能使用Add和Remove方法。只好在DataView中操作，而且只能从尾部开始删除，
            '因为这时每次删除后，SelectedIndices就重置了，所以只能另建数组保存选择项索引，
            '当然就不能自行更新了, 只好从尾部开始删除。这样也好，可以在右边的ListBox中保存字面和代码值了
            'Dim i As Integer
            'For i = 0 To Me.lbSelect.SelectedIndices.Count
            '    Me.lbSelect.Items.Add(Me.lbAll.SelectedItems.Item(i))
            '    Me.lbAll.Items.Remove(Me.lbAll.SelectedItems.Item(i))
            'Next

            Dim i As Integer
            Dim iCount As Integer = Me.lbAll.SelectedItems.Count
            Dim SelectList(iCount) As Integer
            Me.lbAll.SelectedIndices.CopyTo(SelectList, 0)
            For i = iCount - 1 To 0 Step -1
                Dim oldRow, newRow As Data.DataRow
                oldRow = dvAllCompany.Table.Rows(SelectList(i))
                newRow = dvSelect.Table.NewRow
                newRow(0) = oldRow(0)
                newRow(1) = oldRow(1)
                dvSelect.Table.Rows.Add(newRow)
                dvAllCompany.Table.Rows.Remove(oldRow)
            Next
            UpdateGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Try
            'Dim i, iSelect As Integer
            'iSelect = Me.clbSelect.SelectedIndices.Count
            'For i = 0 To iSelect - 1
            '    Dim oldRow, newRow As Data.DataRow
            '    oldRow = dvSelect.Table.Rows(Me.clbSelect.SelectedIndices.Item(0))
            '    newRow = dvAllCompany.Table.NewRow
            '    newRow(0) = oldRow(0)
            '    newRow(1) = oldRow(1)
            '    dvAllCompany.Table.Rows.Add(newRow)
            '    'dvSelect.Table.Rows.Remove(oldRow)
            '    Me.clbSelect.RemoveItem(Me.clbSelect.SelectedIndices.Item(0))
            '    Me.clbSelect.SelectedIndices.RemoveAt(0)
            'Next
            'Me.clbSelect.SelectedIndices.Clear() '否则不会自行清空

            'Dim i As Integer
            'For i = 0 To Me.lbSelect.SelectedIndices.Count
            '    Me.lbAll.Items.Add(Me.lbSelect.SelectedItems.Item(i))
            '    Me.lbSelect.Items.Remove(Me.lbSelect.SelectedItems.Item(i))
            'Next
            'Me.lbSelect.SelectedIndex()
            'Me.lbSelect.SelectedItem()
            'Me.lbSelect.SelectedValue()

            Dim i As Integer
            Dim iCount As Integer = Me.lbSelect.SelectedItems.Count
            Dim SelectList(iCount) As Integer
            Me.lbSelect.SelectedIndices.CopyTo(SelectList, 0)
            For i = iCount - 1 To 0 Step -1
                Dim oldRow, newRow As Data.DataRow
                oldRow = dvSelect.Table.Rows(SelectList(i))
                newRow = dvAllCompany.Table.NewRow
                newRow(0) = oldRow(0)
                newRow(1) = oldRow(1)
                dvAllCompany.Table.Rows.Add(newRow)
                dvSelect.Delete(SelectList(i))
            Next
            UpdateGrid()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub UpdateGrid()
        ListComp = "''"
        If Me.lbSelect.SelectedItems.Count > 0 Then
            Dim i As Integer
            For i = 0 To Me.lbSelect.Items.Count - 1
                ListComp += ",'" & Me.lbSelect.Items.Item(i)("Code_Con_Company") & "'"
            Next
        End If
        dvCon.RowFilter = "Code_Con_Company in (" & ListComp & ")"
        Me.C1DBG.Columns("CONTAINER_NO").FooterText = "计" & dvCon.Count & "项"
    End Sub

    Private Sub C1DBG_FetchCellStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs) Handles C1DBG.FetchCellStyle
        If e.Column.DataColumn.DataField = "CODE_UNLOAD_PORT" OrElse e.Column.DataColumn.DataField = "CODE_UNLOAD_PORT2" Then
            If Me.C1DBG.Columns("CODE_UNLOAD_PORT").CellText(e.Row) <> Me.C1DBG.Columns("CODE_UNLOAD_PORT2").CellText(e.Row) Then
                e.CellStyle.BackColor = Color.Tomato
            End If
        ElseIf e.Column.DataColumn.DataField = "CODE_DELIVERY" OrElse e.Column.DataColumn.DataField = "CODE_PLACE_RECEIVE" Then
            If Me.C1DBG.Columns("CODE_DELIVERY").CellText(e.Row) <> Me.C1DBG.Columns("CODE_PLACE_RECEIVE").CellText(e.Row) Then
                e.CellStyle.BackColor = Color.Tomato
            End If
        End If
    End Sub

    Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Me.lbSelect.Items.Count > 0 Then
            If MessageBox.Show("确定这些箱中卸货港目的地与舱单一致吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                Dim sqlAccord As String
                sqlAccord = "update A set CODE_UNLOAD_PORT=B.CODE_UNLOAD_PORT,CODE_DELIVERY=B.CODE_PLACE_RECEIVE,Unload_Port=B.UNLOAD_PORT,DELIVERY=B.PLACE_RECEIVE from CON_IMAGE A " & _
                    " LEFT JOIN View_HatchCargoAccord B ON A.SHIP_ID = B.SHIP_ID AND A.CONTAINER_NO = B.CONTAINER_NO " & _
                    " WHERE A.SHIP_ID =" & Ship_ID & " and A.Code_Con_Company in (" & ListComp & ")"
                ExecSql(sqlAccord)
                dvCon.Table.Clear()
                RunUpdata(sqlCon, dvCon.Table.DataSet)
                blSave = True
                'Me.Close()
            End If
        End If
    End Sub
End Class
