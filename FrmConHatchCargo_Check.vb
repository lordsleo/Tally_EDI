Imports TALLY.DBControl
Public Class FrmConHatchCargo_Check
    Inherits System.Windows.Forms.Form

#Region " Windows ������������ɵĴ��� "

    Public Sub New()
        MyBase.New()

        '�õ����� Windows ���������������ġ�
        InitializeComponent()

        '�� InitializeComponent() ����֮������κγ�ʼ��

    End Sub

    '������д dispose ����������б�
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

    'ע��: ���¹����� Windows ����������������
    '����ʹ�� Windows ����������޸Ĵ˹��̡�
    '��Ҫʹ�ô���༭���޸�����
    Friend WithEvents C1Hatch As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1Chart As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConHatchCargo_Check))
        Me.C1Hatch = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1Chart = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.C1Hatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1Hatch
        '
        Me.C1Hatch.CaptionHeight = 18
        Me.C1Hatch.FetchRowStyles = True
        Me.C1Hatch.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1Hatch.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1Hatch.Location = New System.Drawing.Point(-330, 466)
        Me.C1Hatch.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1Hatch.Name = "C1Hatch"
        Me.C1Hatch.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1Hatch.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1Hatch.PreviewInfo.ZoomFactor = 75
        Me.C1Hatch.RecordSelectorWidth = 17
        Me.C1Hatch.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1Hatch.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1Hatch.RowHeight = 16
        Me.C1Hatch.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Hatch.Size = New System.Drawing.Size(402, 368)
        Me.C1Hatch.TabIndex = 37
        Me.C1Hatch.Visible = False
        Me.C1Hatch.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Back" & _
        "Color:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" FetchRowStyles=""True"" MarqueeStyle=""Dotted" & _
        "CellBorder"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1""" & _
        " HorizontalScrollGroup=""1""><ClientRect>0, 0, 398, 364</ClientRect><BorderSide>0<" & _
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
        "vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17" & _
        "</DefaultRecSelWidth><ClientArea>0, 0, 398, 364</ClientArea><PrintPageHeaderStyl" & _
        "e parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob" & _
        ">"
        '
        'C1Chart
        '
        Me.C1Chart.CaptionHeight = 18
        Me.C1Chart.FetchRowStyles = True
        Me.C1Chart.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1Chart.Images.Add(CType(resources.GetObject("resource1"), System.Drawing.Image))
        Me.C1Chart.Location = New System.Drawing.Point(62, 466)
        Me.C1Chart.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1Chart.Name = "C1Chart"
        Me.C1Chart.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1Chart.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1Chart.PreviewInfo.ZoomFactor = 75
        Me.C1Chart.RecordSelectorWidth = 17
        Me.C1Chart.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1Chart.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1Chart.RowHeight = 16
        Me.C1Chart.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1Chart.Size = New System.Drawing.Size(402, 368)
        Me.C1Chart.TabIndex = 0
        Me.C1Chart.Visible = False
        Me.C1Chart.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Alig" & _
        "nVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" FetchRowStyles=""True"" MarqueeStyle=""Dotted" & _
        "CellBorder"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1""" & _
        " HorizontalScrollGroup=""1""><ClientRect>0, 0, 398, 364</ClientRect><BorderSide>0<" & _
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
        "vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17" & _
        "</DefaultRecSelWidth><ClientArea>0, 0, 398, 364</ClientArea><PrintPageHeaderStyl" & _
        "e parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob" & _
        ">"
        '
        'C1DBG
        '
        Me.C1DBG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.FetchRowStyles = True
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource2"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.RecordSelectorWidth = 17
        Me.C1DBG.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1DBG.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single
        Me.C1DBG.RowHeight = 16
        Me.C1DBG.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1DBG.Size = New System.Drawing.Size(814, 477)
        Me.C1DBG.TabIndex = 40
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style1{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Back" & _
        "Color:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" FetchRowStyles=""True"" MarqueeStyle=""Dotted" & _
        "CellBorder"" RecordSelectorWidth=""17"" DefRecSelWidth=""17"" VerticalScrollGroup=""1""" & _
        " HorizontalScrollGroup=""1""><ClientRect>0, 0, 810, 473</ClientRect><BorderSide>0<" & _
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
        "vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>17" & _
        "</DefaultRecSelWidth><ClientArea>0, 0, 810, 473</ClientArea><PrintPageHeaderStyl" & _
        "e parent="""" me=""Style14"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob" & _
        ">"
        '
        'btQuit
        '
        Me.btQuit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(427, 483)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 42
        Me.btQuit.Text = "ȡ��"
        '
        'btSave
        '
        Me.btSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btSave.Location = New System.Drawing.Point(355, 483)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 41
        Me.btSave.Text = "����"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(2, 483)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 20)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "�Ƚ� ��ߴ� ����� ж�� ����¶� �±� ΣƷ�ȼ� ����"
        '
        'FrmConHatchCargo_Check
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(814, 512)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.C1Chart)
        Me.Controls.Add(Me.C1Hatch)
        Me.Name = "FrmConHatchCargo_Check"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "�յ���ͼ�˶�"
        CType(Me.C1Hatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Chart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim dvHatch As New DataView
    Dim dvChart As New DataView
    Dim sqlHatch As String
    Dim sqlChart As String
    Dim dvHatchImage As New DataView
    Dim sqlHatchImage As String
    Dim i As Integer
    Dim strDataField As String  '����
    Dim strDataRow As String    '�б�

    Dim dsHatchList As New DataSet
    Dim dsHatchCon As New DataSet
    Dim dsImage As New DataSet
    Dim dsCriterion As New DataSet
    Dim daHatchList As New SqlClient.SqlDataAdapter
    Dim daHatchCon As New SqlClient.SqlDataAdapter
    Dim daImage As New SqlClient.SqlDataAdapter
    Dim daCriterion As New SqlClient.SqlDataAdapter
    Dim dvHatchList As New DataView
    Dim dvHatchCon As New DataView
    Dim dvImage As New DataView
    Dim dvCriterion As New DataView
    Dim sqlHatchList, sqlHatchCon As String
    Dim sqlImage, sqlCriterion As String
    Public strInOut As String   '������
    Dim iC(5) As Integer    'Ҫ�Ƚϵ���

    Dim cellStyle As New C1.Win.C1TrueDBGrid.Style      'C1Grid���

    Private Sub FrmConHatchCargo_Check_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Size = New Size(1000, 600)
        Me.Left -= 100
        Me.Top -= 50
        Me.WindowState = FormWindowState.Maximized
        Try
            sqlHatchList = "SELECT CON_HATCH_LIST_ID,SHIP_ID,BLNO,CODE_LOAD_PORT,LOAD_PORT,CODE_UNLOAD_PORT,UNLOAD_PORT,REFRIGERATE_TEMPERATURE,TEMPERATURE,DANGER_GRADE " & _
                " FROM CON_HATCH_LIST WHERE SHIP_ID = '" & Ship_ID & "' order by CON_HATCH_LIST_ID "
            sqlHatchCon = "SELECT CON_HATCH_RECORD_ID,SHIP_ID,CONTAINER_NO,SIZE_CON,CONTAINER_TYPE,FULLOREMPTY,SEALNO,BAYNO,AMOUNT,WEIGHT,VOLUME,ReeferTemp,TempUnit,DangerGrade " & _
                " FROM CON_HATCH_RECORD WHERE SHIP_ID = '" & Ship_ID & "' order by CON_HATCH_RECORD_ID "
            sqlImage = "SELECT CON_IMAGE_ID,SHIP_ID,CONTAINER_NO,FULLOREMPTY,SEALNO,BAYNO,BLNO,CODE_LOAD_PORT,Load_Port, " & _
                " CODE_UNLOAD_PORT,Unload_Port,TEMPERATURE_SETTING,TEMPERATURE_UNIT,DANGER_GRADE,AMOUNT,GROSSWEIGHT,VOLUME " & _
                " FROM CON_IMAGE WHERE SHIP_ID = '" & Ship_ID & "' order by CON_IMAGE_ID "

            'sqlCriterion = "SELECT CON_CRITERION_ID,CONTAINER_NO,SIZE_CON,CONTAINER_TYPE FROM CON_CRITERION " & _
            '    " WHERE CONTAINER_NO IN (SELECT CONTAINER_NO FROM con_image WHERE SHIP_ID = '" & Ship_ID & "') " & _
            '    " UNION SELECT CON_CRITERION_ID,CONTAINER_NO,SIZE_CON,CONTAINER_TYPE FROM CON_CRITERION " & _
            '    " WHERE CONTAINER_NO IN (SELECT dbo.ConOtherMode(CONTAINER_NO) FROM con_image WHERE SHIP_ID = '" & Ship_ID & "') order by CONTAINER_NO "
            'sqlCriterion = "SELECT CON_CRITERION_ID,CONTAINER_NO,SIZE_CON,CONTAINER_TYPE FROM CON_CRITERION " & _
            '             " WHERE CONTAINER_NO IN (SELECT CONTAINER_NO FROM con_image WHERE SHIP_ID = '" & Ship_ID & "') "
            'sqlCriterion = "SELECT CON_CRITERION_ID,CONTAINER_NO,SIZE_CON,CONTAINER_TYPE FROM CON_CRITERION " & _
            '    " WHERE CONTAINER_NO IN (SELECT CONTAINER_NO FROM con_image WHERE SHIP_ID = '" & Ship_ID & "') OR " & _
            '    " CONTAINER_NO IN (SELECT dbo.ConOtherMode(CONTAINER_NO) FROM con_image WHERE SHIP_ID = '" & Ship_ID & "') ORDER BY CONTAINER_NO "
            sqlCriterion = "SELECT CON_CRITERION_ID,CONTAINER_NO,SIZE_CON,CONTAINER_TYPE FROM CON_CRITERION " & _
                " WHERE CONTAINER_NO IN (SELECT CONTAINER_NO FROM con_image WHERE SHIP_ID = '" & Ship_ID & "' Union SELECT dbo.ConOtherMode(CONTAINER_NO) FROM con_image WHERE SHIP_ID = '" & Ship_ID & "') " & _
                " ORDER BY CONTAINER_NO "

            dvHatchList = Updatedata(daHatchList, sqlHatchList, dsHatchList)
            dvHatchCon = Updatedata(daHatchCon, sqlHatchCon, dsHatchCon)
            dvImage = Updatedata(daImage, sqlImage, dsImage)
            dvCriterion = Updatedata(daCriterion, sqlCriterion, dsCriterion)

            sqlHatchImage = "SELECT SHIP_ID,CON_HATCH_RECORD_ID,CON_HATCH_LIST_ID,CON_IMAGE_ID,CONTAINER_NO, " & _
                " SIZE_CON,CONTAINER_TYPE,FULLOREMPTY,SEALNO,BAYNO,BLNO,CODE_LOAD_PORT,CODE_UNLOAD_PORT, " & _
                " ReeferTemp,TempUnit,DangerGrade,AMOUNT,WEIGHT,VOLUME, " & _
                " SIZE_CON2,CONTAINER_TYPE2,FULLOREMPTY2,SEALNO2,BAYNO2,BLNO2,CODE_LOAD_PORT2,CODE_UNLOAD_PORT2, " & _
                " TEMPERATURE_SETTING2,TEMPERATURE_UNIT2,DANGER_GRADE2,AMOUNT2,GROSSWEIGHT2,VOLUME2 " & _
                " FROM View_HatchImageCheck WHERE SHIP_ID = '" & Ship_ID & "' order by CONTAINER_NO "
            dvHatchImage = Filldata(sqlHatchImage)
            Call SetC1DBG()

            'sqlHatch = "SELECT SHIP_ID,CON_HATCH_RECORD_ID,CON_HATCH_LIST_ID,CHI_VESSEL,VOYAGE,CONTAINER_NO,SIZE_CON,CONTAINER_TYPE,FULLOREMPTY,SEALNO, " & _
            '    " BAYNO,BLNO,CODE_LOAD_PORT,CODE_UNLOAD_PORT,REFRIGERATE_TEMPERATURE,TEMPERATURE,DANGER_GRADE,AMOUNT,WEIGHT,VOLUME " & _
            '    " FROM View_HatchCheck WHERE SHIP_ID = '" & Ship_ID & "'"
            'sqlChart = "SELECT CON_IMAGE_ID,SHIP_ID,CHI_VESSEL,VOYAGE,CONTAINER_NO,SIZE_CON,CONTAINER_TYPE,FULLOREMPTY,SEALNO," & _
            '    " BAYNO,BLNO,CODE_LOAD_PORT,CODE_UNLOAD_PORT,TEMPERATURE_SETTING,TEMPERATURE_UNIT,DANGER_GRADE,AMOUNT,GROSSWEIGHT,VOLUME " & _
            '    " FROM View_ImageCheck WHERE SHIP_ID = '" & Ship_ID & "'"
            'dvHatch = Filldata(sqlHatch)
            'dvChart = Filldata(sqlChart)
            'Call SetC1Hatch()
            'Call SetC1Chart()

            'ȡ������
            'Label1.Text = Me.C1Chart.Splits(0).DisplayColumns(7).DataColumn.DataField
            'Label2.Text = dvHatch.Table.Columns(2).ColumnName
            
            cellStyle.BackColor = System.Drawing.Color.MistyRose    '��ɫõ��
            'Me.C1DBG.Splits(0).DisplayColumns("BLNO").AddCellStyle(C1.Win.C1TrueDBGrid.CellStyleFlag.UpdatedCell, cellStyle)
            'Me.C1DBG.Splits(0).DisplayColumns("BLNO").AddRegexCellStyle(C1.Win.C1TrueDBGrid.CellStyleFlag.NormalCell, cellStyle, "aaa")
            Me.C1DBG.Splits(0).AddCellStyle(C1.Win.C1TrueDBGrid.CellStyleFlag.CurrentCell, cellStyle)
            'Me.C1DBG.Splits(0).AddRegexCellStyle(C1.Win.C1TrueDBGrid.CellStyleFlag.NormalCell, cellStyle, "asdf")
            'Me.C1DBG.Splits(0).
            Me.C1DBG.Splits(0).DisplayColumns(5).FetchStyle = True
            Me.C1DBG.Splits(0).DisplayColumns(7).FetchStyle = True
            Me.C1DBG.Splits(0).DisplayColumns(13).FetchStyle = True
            Me.C1DBG.Splits(0).DisplayColumns(14).FetchStyle = True
            Me.C1DBG.Splits(0).DisplayColumns(15).FetchStyle = True
            Me.C1DBG.Splits(1).AddCellStyle(C1.Win.C1TrueDBGrid.CellStyleFlag.CurrentCell, cellStyle)
            Me.C1DBG.Splits(1).DisplayColumns(14 + 5).FetchStyle = True
            Me.C1DBG.Splits(1).DisplayColumns(14 + 7).FetchStyle = True
            Me.C1DBG.Splits(1).DisplayColumns(14 + 13).FetchStyle = True
            Me.C1DBG.Splits(1).DisplayColumns(14 + 14).FetchStyle = True
            Me.C1DBG.Splits(1).DisplayColumns(14 + 15).FetchStyle = True
            'iC = New Integer() {5, 7, 13, 14, 15}
            'If strInOut = "1" Then  '����
            '    iC = New Integer() {5, 7, 12, 13, 14, 15}
            '    Me.C1DBG.Splits(0).DisplayColumns(12).FetchStyle = True
            '    Me.C1DBG.Splits(1).DisplayColumns(14 + 12).FetchStyle = True
            'Else
            '    '�����һ�����Ƚ�ж�ۣ����Ƚ�װ��
            '    iC = New Integer() {5, 7, 11, 13, 14, 15}
            '    Me.C1DBG.Splits(0).DisplayColumns(11).FetchStyle = True
            '    Me.C1DBG.Splits(1).DisplayColumns(14 + 11).FetchStyle = True
            'End If
            iC = New Integer() {5, 7, 12, 13, 14, 15}
            Me.C1DBG.Splits(0).DisplayColumns(12).FetchStyle = True
            Me.C1DBG.Splits(1).DisplayColumns(14 + 12).FetchStyle = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SetC1DBG()
        Me.C1DBG.DataSource = dvHatchImage

        Me.C1DBG.InsertHorizontalSplit(0)

        Me.C1DBG.Columns("CONTAINER_NO").Caption = "��װ���"
        Me.C1DBG.Columns("SIZE_CON").Caption = "�ߴ�"
        Me.C1DBG.Columns("CONTAINER_TYPE").Caption = "����"
        Me.C1DBG.Columns("FULLOREMPTY").Caption = "��״̬"
        Me.C1DBG.Columns("SEALNO").Caption = "Ǧ���"
        Me.C1DBG.Columns("BAYNO").Caption = "��λ��"
        Me.C1DBG.Columns("BLNO").Caption = "�ᵥ��"
        Me.C1DBG.Columns("CODE_LOAD_PORT").Caption = "װ����"
        Me.C1DBG.Columns("CODE_UNLOAD_PORT").Caption = "ж����"
        'Me.C1DBG.Columns("REFRIGERATE_TEMPERATURE").Caption = "�¶�"
        'Me.C1DBG.Columns("TEMPERATURE").Caption = "�±�"
        'Me.C1DBG.Columns("DANGER_GRADE").Caption = "ΣƷ�ȼ�"
        Me.C1DBG.Columns("ReeferTemp").Caption = "�¶�"
        Me.C1DBG.Columns("TempUnit").Caption = "�±�"
        Me.C1DBG.Columns("DangerGrade").Caption = "ΣƷ�ȼ�"
        Me.C1DBG.Columns("AMOUNT").Caption = "����"
        Me.C1DBG.Columns("WEIGHT").Caption = "����"
        Me.C1DBG.Columns("VOLUME").Caption = "����"

        Me.C1DBG.Columns("SIZE_CON2").Caption = "�ߴ�"
        Me.C1DBG.Columns("CONTAINER_TYPE2").Caption = "����"
        Me.C1DBG.Columns("FULLOREMPTY2").Caption = "��״̬"
        Me.C1DBG.Columns("SEALNO2").Caption = "Ǧ���"
        Me.C1DBG.Columns("BAYNO2").Caption = "��λ��"
        Me.C1DBG.Columns("BLNO2").Caption = "�ᵥ��"
        Me.C1DBG.Columns("CODE_LOAD_PORT2").Caption = "װ����"
        Me.C1DBG.Columns("CODE_UNLOAD_PORT2").Caption = "ж����"
        Me.C1DBG.Columns("TEMPERATURE_SETTING2").Caption = "�¶�"
        Me.C1DBG.Columns("TEMPERATURE_UNIT2").Caption = "�±�"
        Me.C1DBG.Columns("DANGER_GRADE2").Caption = "ΣƷ�ȼ�"
        Me.C1DBG.Columns("AMOUNT2").Caption = "����"
        Me.C1DBG.Columns("GROSSWEIGHT2").Caption = "����"
        Me.C1DBG.Columns("VOLUME2").Caption = "����"


        Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Width = 90
        Me.C1DBG.Splits(0).DisplayColumns("SIZE_CON").Width = 30
        Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_TYPE").Width = 30
        Me.C1DBG.Splits(0).DisplayColumns("FULLOREMPTY").Width = 25
        Me.C1DBG.Splits(0).DisplayColumns("SEALNO").Width = 50
        Me.C1DBG.Splits(0).DisplayColumns("BAYNO").Width = 45
        Me.C1DBG.Splits(0).DisplayColumns("BLNO").Width = 90
        Me.C1DBG.Splits(0).DisplayColumns("CODE_LOAD_PORT").Width = 45
        Me.C1DBG.Splits(0).DisplayColumns("CODE_UNLOAD_PORT").Width = 45
        'Me.C1DBG.Splits(0).DisplayColumns("REFRIGERATE_TEMPERATURE").Width = 40
        'Me.C1DBG.Splits(0).DisplayColumns("TEMPERATURE").Width = 20
        'Me.C1DBG.Splits(0).DisplayColumns("DANGER_GRADE").Width = 40
        Me.C1DBG.Splits(0).DisplayColumns("ReeferTemp").Width = 40
        Me.C1DBG.Splits(0).DisplayColumns("TempUnit").Width = 20
        Me.C1DBG.Splits(0).DisplayColumns("DangerGrade").Width = 40
        Me.C1DBG.Splits(0).DisplayColumns("AMOUNT").Width = 50
        Me.C1DBG.Splits(0).DisplayColumns("WEIGHT").Width = 50
        Me.C1DBG.Splits(0).DisplayColumns("VOLUME").Width = 40

        Me.C1DBG.Splits(1).DisplayColumns("CONTAINER_NO").Width = 90
        Me.C1DBG.Splits(1).DisplayColumns("SIZE_CON2").Width = 30
        Me.C1DBG.Splits(1).DisplayColumns("CONTAINER_TYPE2").Width = 30
        Me.C1DBG.Splits(1).DisplayColumns("FULLOREMPTY2").Width = 25
        Me.C1DBG.Splits(1).DisplayColumns("SEALNO2").Width = 50
        Me.C1DBG.Splits(1).DisplayColumns("BAYNO2").Width = 45
        Me.C1DBG.Splits(1).DisplayColumns("BLNO2").Width = 90
        Me.C1DBG.Splits(1).DisplayColumns("CODE_LOAD_PORT2").Width = 45
        Me.C1DBG.Splits(1).DisplayColumns("CODE_UNLOAD_PORT2").Width = 45
        Me.C1DBG.Splits(1).DisplayColumns("TEMPERATURE_SETTING2").Width = 40
        Me.C1DBG.Splits(1).DisplayColumns("TEMPERATURE_UNIT2").Width = 20
        Me.C1DBG.Splits(1).DisplayColumns("DANGER_GRADE2").Width = 40
        Me.C1DBG.Splits(1).DisplayColumns("AMOUNT2").Width = 50
        Me.C1DBG.Splits(1).DisplayColumns("GROSSWEIGHT2").Width = 50
        Me.C1DBG.Splits(1).DisplayColumns("VOLUME2").Width = 40

        Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Locked = True
        Me.C1DBG.Splits(1).DisplayColumns("CONTAINER_NO").Locked = True

        Dim i As Integer
        For i = 0 To 3
            Me.C1DBG.Splits(0).DisplayColumns(i).Visible = False
            Me.C1DBG.Splits(1).DisplayColumns(i).Visible = False
        Next
        For i = 19 To Me.C1DBG.Columns.Count - 1
            Me.C1DBG.Splits(0).DisplayColumns(i).Visible = False
        Next
        For i = 5 To 18
            Me.C1DBG.Splits(1).DisplayColumns(i).Visible = False
        Next
        Me.C1DBG.Splits(0).Caption = "�յ�"
        Me.C1DBG.Splits(1).Caption = "��ͼ"

        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBG.Columns.Item("CONTAINER_NO").FooterText = "��" & dvHatchImage.Count & "��"
        Me.C1DBG.FetchRowStyles = True
    End Sub

    'Private Sub SetC1Hatch()
    '    Me.C1Hatch.DataSource = dvHatch

    '    Me.C1Hatch.Columns("CONTAINER_NO").Caption = "��װ���"
    '    Me.C1Hatch.Columns("SIZE_CON").Caption = "�ߴ�"
    '    Me.C1Hatch.Columns("CONTAINER_TYPE").Caption = "����"
    '    Me.C1Hatch.Columns("FULLOREMPTY").Caption = "��״̬"
    '    Me.C1Hatch.Columns("SEALNO").Caption = "Ǧ���"
    '    Me.C1Hatch.Columns("BAYNO").Caption = "��λ��"
    '    Me.C1Hatch.Columns("BLNO").Caption = "�ᵥ��"
    '    Me.C1Hatch.Columns("CODE_LOAD_PORT").Caption = "װ����"
    '    Me.C1Hatch.Columns("CODE_UNLOAD_PORT").Caption = "ж����"
    '    Me.C1Hatch.Columns("REFRIGERATE_TEMPERATURE").Caption = "�¶�"
    '    Me.C1Hatch.Columns("TEMPERATURE").Caption = "�±�"
    '    Me.C1Hatch.Columns("DANGER_GRADE").Caption = "ΣƷ�ȼ�"
    '    Me.C1Hatch.Columns("AMOUNT").Caption = "����"
    '    Me.C1Hatch.Columns("WEIGHT").Caption = "����"
    '    Me.C1Hatch.Columns("VOLUME").Caption = "����"

    '    Me.C1Hatch.Splits(0).DisplayColumns("CONTAINER_NO").Width = 90
    '    Me.C1Hatch.Splits(0).DisplayColumns("SIZE_CON").Width = 30
    '    Me.C1Hatch.Splits(0).DisplayColumns("CONTAINER_TYPE").Width = 30
    '    Me.C1Hatch.Splits(0).DisplayColumns("FULLOREMPTY").Width = 25
    '    Me.C1Hatch.Splits(0).DisplayColumns("SEALNO").Width = 50
    '    Me.C1Hatch.Splits(0).DisplayColumns("BAYNO").Width = 45
    '    Me.C1Hatch.Splits(0).DisplayColumns("BLNO").Width = 90
    '    Me.C1Hatch.Splits(0).DisplayColumns("CODE_LOAD_PORT").Width = 45
    '    Me.C1Hatch.Splits(0).DisplayColumns("CODE_UNLOAD_PORT").Width = 45
    '    Me.C1Hatch.Splits(0).DisplayColumns("REFRIGERATE_TEMPERATURE").Width = 40
    '    Me.C1Hatch.Splits(0).DisplayColumns("TEMPERATURE").Width = 20
    '    Me.C1Hatch.Splits(0).DisplayColumns("DANGER_GRADE").Width = 40
    '    Me.C1Hatch.Splits(0).DisplayColumns("AMOUNT").Width = 50
    '    Me.C1Hatch.Splits(0).DisplayColumns("WEIGHT").Width = 50
    '    Me.C1Hatch.Splits(0).DisplayColumns("VOLUME").Width = 40

    '    Me.C1Hatch.Splits(0).DisplayColumns("SHIP_ID").Visible = False
    '    Me.C1Hatch.Splits(0).DisplayColumns("CON_HATCH_RECORD_ID").Visible = False
    '    Me.C1Hatch.Splits(0).DisplayColumns("CON_HATCH_LIST_ID").Visible = False
    '    Me.C1Hatch.Splits(0).DisplayColumns("CHI_VESSEL").Visible = False
    '    Me.C1Hatch.Splits(0).DisplayColumns("VOYAGE").Visible = False
    '    Me.C1Hatch.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
    '    Me.C1Hatch.ColumnFooters = True
    '    Me.C1Hatch.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
    '    Me.C1Hatch.Columns.Item("CONTAINER_NO").FooterText = "��" & dvHatch.Count & "��"
    '    Me.C1Hatch.FetchRowStyles = True
    'End Sub

    'Private Sub SetC1Chart()
    '    Me.C1Chart.DataSource = dvChart

    '    Me.C1Chart.Columns("CONTAINER_NO").Caption = "��װ���"
    '    Me.C1Chart.Columns("SIZE_CON").Caption = "�ߴ�"
    '    Me.C1Chart.Columns("CONTAINER_TYPE").Caption = "����"
    '    Me.C1Chart.Columns("FULLOREMPTY").Caption = "��״̬"
    '    Me.C1Chart.Columns("SEALNO").Caption = "Ǧ���"
    '    Me.C1Chart.Columns("BAYNO").Caption = "��λ��"
    '    Me.C1Chart.Columns("BLNO").Caption = "�ᵥ��"
    '    Me.C1Chart.Columns("CODE_LOAD_PORT").Caption = "װ����"
    '    Me.C1Chart.Columns("CODE_UNLOAD_PORT").Caption = "ж����"
    '    Me.C1Chart.Columns("TEMPERATURE_SETTING").Caption = "�¶�"
    '    Me.C1Chart.Columns("TEMPERATURE_UNIT").Caption = "�±�"
    '    Me.C1Chart.Columns("DANGER_GRADE").Caption = "ΣƷ�ȼ�"
    '    Me.C1Chart.Columns("AMOUNT").Caption = "����"
    '    Me.C1Chart.Columns("GROSSWEIGHT").Caption = "����"
    '    Me.C1Chart.Columns("VOLUME").Caption = "����"

    '    Me.C1Chart.Splits(0).DisplayColumns("CONTAINER_NO").Width = 90
    '    Me.C1Chart.Splits(0).DisplayColumns("SIZE_CON").Width = 30
    '    Me.C1Chart.Splits(0).DisplayColumns("CONTAINER_TYPE").Width = 30
    '    Me.C1Chart.Splits(0).DisplayColumns("FULLOREMPTY").Width = 25
    '    Me.C1Chart.Splits(0).DisplayColumns("SEALNO").Width = 50
    '    Me.C1Chart.Splits(0).DisplayColumns("BAYNO").Width = 45
    '    Me.C1Chart.Splits(0).DisplayColumns("BLNO").Width = 90
    '    Me.C1Chart.Splits(0).DisplayColumns("CODE_LOAD_PORT").Width = 45
    '    Me.C1Chart.Splits(0).DisplayColumns("CODE_UNLOAD_PORT").Width = 45
    '    Me.C1Chart.Splits(0).DisplayColumns("TEMPERATURE_SETTING").Width = 40
    '    Me.C1Chart.Splits(0).DisplayColumns("TEMPERATURE_UNIT").Width = 20
    '    Me.C1Chart.Splits(0).DisplayColumns("DANGER_GRADE").Width = 40
    '    Me.C1Chart.Splits(0).DisplayColumns("AMOUNT").Width = 50
    '    Me.C1Chart.Splits(0).DisplayColumns("GROSSWEIGHT").Width = 50
    '    Me.C1Chart.Splits(0).DisplayColumns("VOLUME").Width = 40

    '    Me.C1Chart.Splits(0).DisplayColumns("SHIP_ID").Visible = False
    '    Me.C1Chart.Splits(0).DisplayColumns("CON_IMAGE_ID").Visible = False
    '    Me.C1Chart.Splits(0).DisplayColumns("CHI_VESSEL").Visible = False
    '    Me.C1Chart.Splits(0).DisplayColumns("VOYAGE").Visible = False
    '    Me.C1Chart.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
    '    Me.C1Chart.ColumnFooters = True
    '    Me.C1Chart.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
    '    Me.C1Chart.Columns.Item("CONTAINER_NO").FooterText = "��" & dvChart.Count & "��"
    '    Me.C1Chart.FetchRowStyles = True
    'End Sub

    Private Sub C1DBG_FetchRowStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchRowStyleEventArgs) Handles C1DBG.FetchRowStyle
        Try
            'For Each i In iC
            '    If Me.C1DBG.Columns(i).CellText(e.Row) <> Me.C1DBG.Columns(i + 14).CellText(e.Row) Then
            '        e.CellStyle.BackColor = System.Drawing.Color.LightPink
            '        Exit For
            '    End If
            'Next
            'For i = 5 To 18
            '    If Me.C1DBG.Columns(i).CellText(e.Row) <> Me.C1DBG.Columns(i + 14).CellText(e.Row) Then
            '        e.CellStyle.BackColor = System.Drawing.Color.LightPink
            '        Exit For
            '    End If
            'Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub C1DBG_FetchCellStyle(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.FetchCellStyleEventArgs) Handles C1DBG.FetchCellStyle
        For Each i In iC
            If e.Col = i Then
                If Me.C1DBG.Columns(e.Col).CellText(e.Row) <> Me.C1DBG.Columns(e.Col + 14).CellText(e.Row) Then
                    e.CellStyle.BackColor = Color.Tomato
                End If
                Exit For
            ElseIf e.Col = i + 14 Then
                If Me.C1DBG.Columns(e.Col).CellText(e.Row) <> Me.C1DBG.Columns(e.Col - 14).CellText(e.Row) Then
                    e.CellStyle.BackColor = Color.Tomato
                End If
                Exit For
            End If
        Next
    End Sub
    Private Sub C1DBG_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles C1DBG.RowColChange

    End Sub

    Private Function GetConOtherMode(ByVal ConNo As String) As String   '�õ���ŵ���һ���޿ջ��п���ʽ
        ConNo = ConNo.Trim.ToUpper
        If ConNo.Length = 11 Then
            ConNo = ConNo.Insert(4, " ")
        ElseIf ConNo.Length = 12 Then
            ConNo = ConNo.Remove(4, 1)
        End If
        Return ConNo
    End Function

    Private Sub C1DBG_AfterColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles C1DBG.AfterColEdit
        Try
            strDataField = Me.C1DBG.Columns(e.ColIndex).DataField
            If strDataField Like "*2" Then  '�Ĵ�ͼ
                strDataField = strDataField.Substring(0, strDataField.Length - 1)
            Else    '�Ĳյ�
            End If

            Select Case e.ColIndex
                Case 5 To 9, 13 To 18
                    '�Ĳյ����
                    strDataRow = Me.C1DBG.Columns("CON_HATCH_RECORD_ID").Text
                    For i = 0 To dvHatchCon.Count - 1
                        If dvHatchCon(i)("CON_HATCH_RECORD_ID") = strDataRow Then
                            dvHatchCon(i)(strDataField) = Me.C1DBG.Columns(e.ColIndex).Text
                            Exit For
                        End If
                    Next
                Case 10 To 12
                    '�Ĳյ��ᵥ��
                    strDataRow = Me.C1DBG.Columns("CON_HATCH_LIST_ID").Text
                    For i = 0 To dvHatchList.Count - 1
                        If dvHatchList(i)("CON_HATCH_LIST_ID") = strDataRow Then    '�ҵ���Ӧ��¼���޸�
                            dvHatchList(i)(strDataField) = Me.C1DBG.Columns(e.ColIndex).Text
                            Exit For
                        End If
                    Next
                Case 21 To 32
                    '�Ĵ�ͼ��
                    strDataRow = Me.C1DBG.Columns("CON_IMAGE_ID").Text
                    For i = 0 To dvImage.Count - 1
                        If dvImage(i)("CON_IMAGE_ID") = strDataRow Then    '�ҵ���Ӧ��¼���޸�
                            dvImage(i)(strDataField) = Me.C1DBG.Columns(e.ColIndex).Text
                            Exit For
                        End If
                    Next
                Case 19, 20
                    '����淶��
                    strDataRow = Me.C1DBG.Columns("CONTAINER_NO").Text
                    For i = 0 To dvCriterion.Count - 1
                        If dvCriterion(i)("CONTAINER_NO") = strDataRow Or dvCriterion(i)("CONTAINER_NO") = GetConOtherMode(strDataRow) Then
                            dvCriterion(i)(strDataField) = Me.C1DBG.Columns(e.ColIndex).Text
                            Exit For
                        End If
                    Next
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            daHatchList.Update(dsHatchList)
            daHatchCon.Update(dsHatchCon)
            daImage.Update(dsImage)
            daCriterion.Update(dsCriterion)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

End Class
