Imports TALLY.DBControl
Public Class FrmConLoadCheck_Deal
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
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents labShipName As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConLoadCheck_Deal))
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btnCommit = New System.Windows.Forms.Button
        Me.btQuit = New System.Windows.Forms.Button
        Me.labShipName = New System.Windows.Forms.Label
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DBG
        '
        Me.C1DBG.AllowAddNew = True
        Me.C1DBG.AllowDelete = True
        Me.C1DBG.AllowSort = False
        Me.C1DBG.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 24)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.Size = New System.Drawing.Size(740, 426)
        Me.C1DBG.TabIndex = 285
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style9{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" & _
        "yle14{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Alig" & _
        "nVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style1{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSele" & _
        "ctorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><Height>422</Height><CaptionStyle parent=""Style2"" me=""Style10"" /><EditorSty" & _
        "le parent=""Editor"" me=""Style5"" /><EvenRowStyle parent=""EvenRow"" me=""Style8"" /><F" & _
        "ilterBarStyle parent=""FilterBar"" me=""Style13"" /><FooterStyle parent=""Footer"" me=" & _
        """Style3"" /><GroupStyle parent=""Group"" me=""Style12"" /><HeadingStyle parent=""Headi" & _
        "ng"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style7"" /><Inacti" & _
        "veStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style9""" & _
        " /><RecordSelectorStyle parent=""RecordSelector"" me=""Style11"" /><SelectedStyle pa" & _
        "rent=""Selected"" me=""Style6"" /><Style parent=""Normal"" me=""Style1"" /><ClientRect>0" & _
        ", 0, 736, 422</ClientRect><BorderSide>0</BorderSide><BorderStyle>Sunken</BorderS" & _
        "tyle></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedStyles><Style parent="""" me=""" & _
        "Normal"" /><Style parent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Foot" & _
        "er"" /><Style parent=""Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactiv" & _
        "e"" /><Style parent=""Normal"" me=""Selected"" /><Style parent=""Normal"" me=""Editor"" /" & _
        "><Style parent=""Normal"" me=""HighlightRow"" /><Style parent=""Normal"" me=""EvenRow"" " & _
        "/><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Heading"" me=""RecordSelecto" & _
        "r"" /><Style parent=""Normal"" me=""FilterBar"" /><Style parent=""Caption"" me=""Group"" " & _
        "/></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None" & _
        "</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><ClientArea>0, 0, 736, 422</" & _
        "ClientArea><PrintPageHeaderStyle parent="""" me=""Style14"" /><PrintPageFooterStyle " & _
        "parent="""" me=""Style15"" /></Blob>"
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCommit.Font = New System.Drawing.Font("����", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnCommit.Location = New System.Drawing.Point(330, 456)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(65, 24)
        Me.btnCommit.TabIndex = 289
        Me.btnCommit.Text = "����"
        '
        'btQuit
        '
        Me.btQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(420, 456)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 288
        Me.btQuit.Text = "�˳�"
        '
        'labShipName
        '
        Me.labShipName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labShipName.BackColor = System.Drawing.Color.Lavender
        Me.labShipName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.labShipName.Font = New System.Drawing.Font("����", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.labShipName.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.labShipName.Location = New System.Drawing.Point(568, 0)
        Me.labShipName.Name = "labShipName"
        Me.labShipName.Size = New System.Drawing.Size(172, 23)
        Me.labShipName.TabIndex = 290
        Me.labShipName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmConLoadCheck_Deal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(740, 485)
        Me.Controls.Add(Me.labShipName)
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.C1DBG)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConLoadCheck_Deal"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "װ�������Ų���"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim dsContainer As New DataSet()
    Dim daContainer As New SqlClient.SqlDataAdapter()
    Dim sqlContainer As String
    Dim dvContainer As New DataView()
    Dim strYard, sqlYard As String
    Dim dvYard As New DataView()
    Dim iYear, iMaxNo As Integer

    Dim i, j, iConCheck, iConBeing As Integer
    Dim sqlExist, sqlBeing As String
    Dim dvConBeing As New DataView()
    Dim dvExist As New DataView()
    Dim sqlShipCode As String
    Dim dvShipCode As New DataView
    Public blSave As Boolean

    Private Sub FrmConLoadCheck_Deal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqlContainer = "SELECT CON_LOAD_TALLY_LIST_ID,CON_LOAD_TALLY_ID,SHIP_ID,CodeYard,CONTAINER_NO,SIZE_CON, CONTAINER_TYPE,CHI_VESSEL,Voyage,BLNO,NEWSEALNO,FullOrEmpty,SecSealNO,ReasonOpenSeal,CheckTime,CheckMan,ConTime,Clerk,USER_NAME,Checked,Printed,StateC FROM CON_LOAD_TALLY_LIST where CodeYard = '-a'"
        dvContainer = Updatedata(daContainer, sqlContainer, dsContainer)
        strYard = "07"      'Ĭ�ϳ�վ�Ǽ����
        If G_DeptCode = "26.11.12" Then
            strYard = "21"
        End If
        Call InitSubTable()
        Me.btQuit.Focus()
        Me.C1DBG.Focus()
        Me.C1DBG.Col = 2
        SendKeys.Send("{RIGHT}")
    End Sub

    Private Sub InitSubTable()
        Try
            Me.C1DBG.DataSource = dvContainer
            Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
            Me.C1DBG.ColumnFooters = True
            Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
            Me.C1DBG.Columns("CONTAINER_NO").FooterText = "�ϼ�" & dvContainer.Count & "��"

            Me.C1DBG.Splits(0).DisplayColumns.Item(0).Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item(1).Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("SHIP_ID").Visible = False
            'Me.C1DBG.Splits(0).DisplayColumns.Item("SIZE_CON").Visible = False
            'Me.C1DBG.Splits(0).DisplayColumns.Item("CONTAINER_TYPE").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("USER_NAME").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("Checked").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("CheckTime").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("CheckMan").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("Printed").Visible = False
            Me.C1DBG.Splits(0).DisplayColumns.Item("StateC").Visible = False

            Me.C1DBG.Splits(0).DisplayColumns("CodeYard").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("CheckTime").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("Printed").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("StateC").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("ConTime").Locked = True
            Me.C1DBG.Splits(0).DisplayColumns("Clerk").Locked = True

            Me.C1DBG.Columns.Item("CHI_VESSEL").Caption = "����"
            Me.C1DBG.Columns.Item("VOYAGE").Caption = "����"
            Me.C1DBG.Columns.Item("BLNO").Caption = "�ᵥ��"
            Me.C1DBG.Columns.Item("CONTAINER_NO").Caption = "���"
            Me.C1DBG.Columns.Item("NEWSEALNO").Caption = "����Ǧ��"
            Me.C1DBG.Columns.Item("SecSealNO").Caption = "��עǦ��"
            Me.C1DBG.Columns.Item("ReasonOpenSeal").Caption = "����ԭ��"
            Me.C1DBG.Columns.Item("CodeYard").Caption = "װ��ص�"
            Me.C1DBG.Columns.Item("SIZE_CON").Caption = "��ߴ�"
            Me.C1DBG.Columns.Item("CONTAINER_TYPE").Caption = "����"
            Me.C1DBG.Columns.Item("FullOrEmpty").Caption = "������"
            Me.C1DBG.Columns.Item("CheckTime").Caption = "����ʱ��"
            Me.C1DBG.Columns("CheckTime").NumberFormat = "yyMMdd HHmm"
            Me.C1DBG.Columns.Item("ConTime").Caption = "װ��ʱ��"
            Me.C1DBG.Columns("ConTime").NumberFormat = "yyMMdd HHmm"
            Me.C1DBG.Columns.Item("Clerk").Caption = "���Ա"

            Me.C1DBG.Columns.Item("USER_NAME").DefaultValue = G_User
            Me.C1DBG.Columns.Item("CheckMan").DefaultValue = G_User
            Me.C1DBG.Columns.Item("Clerk").DefaultValue = G_User
            Me.C1DBG.Columns.Item("Checked").DefaultValue = "1"
            Me.C1DBG.Columns.Item("CheckTime").DefaultValue = Now
            Me.C1DBG.Columns.Item("ConTime").DefaultValue = Now
            Me.C1DBG.Columns.Item("Printed").DefaultValue = "0"
            Me.C1DBG.Columns("CodeYard").DefaultValue = strYard
            Me.C1DBG.Columns("StateC").DefaultValue = "1"
            Me.C1DBG.Columns("FullOrEmpty").DefaultValue = "F"

            Call FieldFill()
            SetColumnWidth()
        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FieldFill()
        Dim i As Integer
        Try
            Dim sqlYcode As String
            Dim dvYcode As New DataView()
            sqlYcode = "SELECT Code_Yard_ID, Code_Yard_Name FROM Code_Yard where Code_Yard_ID <> '00' ORDER BY Code_Yard_ID"
            dvYcode = Filldata(sqlYcode)
            Me.C1DBG.Columns("CodeYard").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("CodeYard").ValueItems.Translate = True
            For i = 0 To dvYcode.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
                vi.DisplayValue = dvYcode(i)("Code_Yard_Name")
                vi.Value = dvYcode(i)("Code_Yard_ID")
                Me.C1DBG.Columns.Item("CodeYard").ValueItems.Values.Add(vi)
            Next
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SetColumnWidth()
        Dim i As Integer
        Try
            Me.C1DBG.Splits(0).DisplayColumns("CodeYard").Width = 70
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Width = 80
            Me.C1DBG.Splits(0).DisplayColumns("SIZE_CON").Width = 30
            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_TYPE").Width = 30
            Me.C1DBG.Splits(0).DisplayColumns("CHI_VESSEL").Width = 60
            Me.C1DBG.Splits(0).DisplayColumns("Voyage").Width = 50
            Me.C1DBG.Splits(0).DisplayColumns("BLNO").Width = 100
            Me.C1DBG.Splits(0).DisplayColumns("NEWSEALNO").Width = 70
            Me.C1DBG.Splits(0).DisplayColumns("FullOrEmpty").Width = 30
            Me.C1DBG.Splits(0).DisplayColumns("SecSealNO").Width = 70
            Me.C1DBG.Splits(0).DisplayColumns("ReasonOpenSeal").Width = 70
            Me.C1DBG.Splits(0).DisplayColumns("ConTime").Width = 75
            Me.C1DBG.Splits(0).DisplayColumns("Clerk").Width = 60
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function CheckConNO(ByVal sm As String) As Integer 'return 0����д� 1У���д� 2У����ȷ
        Dim S() As Integer = {10, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 34, 35, 36, 37, 38}
        Dim str As String
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim l As Integer
        i = 0
        str = UCase(sm)
        If Len(Trim(str)) = 12 And Mid(Trim(str), 5, 1) = " " Then
            str = Mid(Trim(str), 1, 4) & Mid(Trim(str), 6, 7)
        ElseIf Len(Trim(str)) <> 11 Then
            Return 0
        End If
        k = 1
        For j = 1 To 4
            If Asc(Mid(Trim(str), j, 1)) >= Asc("A") And Asc(Mid(Trim(str), j, 1)) <= Asc("Z") Then
                i = i + S(Asc(Mid(Trim(str), j, 1).ToUpper) - Asc("A")) * System.Math.Pow(2, k - 1)
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

    Private Function GetConOtherMode(ByVal ConNo As String) As String   '�õ���ŵ���һ���޿ջ��п���ʽ
        ConNo = ConNo.Trim.ToUpper
        If ConNo.Length = 11 Then
            ConNo = ConNo.Insert(4, " ")
        ElseIf ConNo.Length = 12 Then
            ConNo = ConNo.Remove(4, 1)
        End If
        Return ConNo
    End Function

    Private Function IsEqualConNo(ByVal ConOne As String, ByVal ConTwo As String) As Boolean    '�ж�����Ƿ����
        Dim Flag As Boolean
        ConOne = ConOne.Trim.ToUpper
        ConTwo = ConTwo.Trim.ToUpper
        If ConOne.Length = ConTwo.Length Then
            If String.Equals(ConOne, ConTwo) Then
                Flag = True
            End If
        Else
            If String.Equals(ConOne, GetConOtherMode(ConTwo)) Then
                Flag = True
            End If
        End If
        Return Flag
    End Function

    'Private Sub C1DBG_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles C1DBG.RowColChange
    '    Dim strContainerNo, strShipCode As String

    '    If e.LastRow = Me.C1DBG.Row Then
    '        If e.LastCol = 4 Then
    '            If e.LastRow <> Me.C1DBG.Row Then
    '                Try
    '                    Me.C1DBG.Row = e.LastRow
    '                Catch ex As Exception
    '                    MessageBox.Show(ex.Message)
    '                End Try
    '            End If
    '            Me.C1DBG.Columns("CONTAINER_NO").Text = Me.C1DBG.Columns("CONTAINER_NO").Text.Trim.ToUpper
    '            strContainerNo = Me.C1DBG.Columns("CONTAINER_NO").Text

    '            sqlExist = "SELECT * FROM CON_LOAD_TALLY_LIST WHERE (CONTAINER_NO = '" & strContainerNo & "' or CONTAINER_NO = '" & GetConOtherMode(strContainerNo) & "') and Checked = '0'"
    '            dvExist = Filldata(sqlExist)
    '            If dvExist.Count > 0 Then   '����Ѵ�����δ���أ�����
    '                'If Not IsDBNull(dvExist(0)("CON_LOAD_TALLY_ID")) Then
    '                '    Me.C1DBG.Columns("CON_LOAD_TALLY_ID").Text = dvExist(0)("CON_LOAD_TALLY_ID")
    '                'End If
    '                'If Not IsDBNull(dvExist(0)("Ship_ID")) Then
    '                '    Me.C1DBG.Columns("Ship_ID").Text = dvExist(0)("Ship_ID")
    '                'End If
    '                'If Not IsDBNull(dvExist(0)("SIZE_CON")) Then
    '                '    Me.C1DBG.Columns("SIZE_CON").Text = dvExist(0)("SIZE_CON")
    '                'End If
    '                'If Not IsDBNull(dvExist(0)("CONTAINER_TYPE")) Then
    '                '    Me.C1DBG.Columns("CONTAINER_TYPE").Text = dvExist(0)("CONTAINER_TYPE")
    '                'End If
    '                Me.C1DBG.Columns("CHI_VESSEL").Value = dvExist(0)("CHI_VESSEL")
    '                Me.C1DBG.Columns("Voyage").Value = dvExist(0)("Voyage")

    '                Me.C1DBG.Columns("BLNO").Value = dvExist(0)("BLNO")
    '                Me.C1DBG.Columns("CodeYard").Value = dvExist(0)("CodeYard")
    '                If Not IsDBNull(dvExist(0)("NEWSEALNO")) Then
    '                    Me.C1DBG.Columns("NEWSEALNO").Text = dvExist(0)("NEWSEALNO")
    '                End If
    '                If Not IsDBNull(dvExist(0)("SecSealNO")) Then
    '                    Me.C1DBG.Columns("SecSealNO").Text = dvExist(0)("SecSealNO")
    '                End If
    '                If Not IsDBNull(dvExist(0)("ReasonOpenSeal")) Then
    '                    Me.C1DBG.Columns("ReasonOpenSeal").Text = dvExist(0)("ReasonOpenSeal")
    '                End If
    '                'Me.C1DBG.Columns("USER_NAME").Text = dvExist(0)("USER_NAME")
    '                If dvExist.Count > 1 Then
    '                    MessageBox.Show("������ظ����֣�������ƴ��", "�������", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                End If
    '            Else   '��Ų����ڣ�����䣬�����
    '                sqlBeing = "SELECT CONTAINER_NO, SIZE_CON, CONTAINER_TYPE FROM CON_CRITERION WHERE CONTAINER_NO = '" & strContainerNo & "' or CONTAINER_NO = '" & GetConOtherMode(strContainerNo) & "'"
    '                dvConBeing = Filldata(sqlBeing)
    '                iConBeing = dvConBeing.Count
    '                If iConBeing > 0 Then    '��淶�д���,��д����Ϣ
    '                    If Not IsDBNull(dvConBeing.Item(0)("SIZE_CON")) Then
    '                        Me.C1DBG.Columns("SIZE_CON").Text = dvConBeing.Item(0)("SIZE_CON")
    '                    End If
    '                    If Not IsDBNull(dvConBeing.Item(0)("CONTAINER_TYPE")) Then
    '                        Me.C1DBG.Columns("CONTAINER_TYPE").Text = dvConBeing.Item(0)("CONTAINER_TYPE")
    '                    End If
    '                Else
    '                    iConCheck = CheckConNO(strContainerNo)
    '                    If iConCheck = 1 Then
    '                        Me.C1DBG.SelectedRows.Clear()
    '                        Me.C1DBG.SelectedRows.Add(Me.C1DBG.Row)
    '                        If MessageBox.Show("��װ��� " & strContainerNo & " ����������淶����У�鲻��ȷ��ȷ��������", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = DialogResult.No Then
    '                            Exit Sub
    '                        End If
    '                    ElseIf iConCheck = 0 Then
    '                        Me.C1DBG.SelectedRows.Clear()
    '                        Me.C1DBG.SelectedRows.Add(Me.C1DBG.Row)
    '                        MessageBox.Show("��װ��Ų��淶��", "��ʾ")
    '                        Exit Sub
    '                    End If
    '                End If
    '            End If
    '        End If

    '        If e.LastCol = 7 Then
    '            Me.C1DBG.Columns("CHI_VESSEL").Text = Me.C1DBG.Columns("CHI_VESSEL").Text.Trim.ToUpper
    '            strShipCode = Me.C1DBG.Columns("CHI_VESSEL").Text
    '            sqlShipCode = "SELECT SPCODE, CHI_VESSEL FROM Code_SHIPNAME WHERE (SPCODE = '" & strShipCode & "' or CHI_VESSEL = '" & strShipCode & "')"
    '            dvShipCode = Filldata(sqlShipCode)
    '            If dvShipCode.Count > 0 Then
    '                Me.C1DBG.Columns("CHI_VESSEL").Text = dvShipCode(0)("SPCODE")
    '            Else
    '                MessageBox.Show("���� " & strShipCode & " �����ڣ�����������", "��ʾ")
    '                Exit Sub
    '            End If
    '        End If
    '    End If
    'End Sub

    Private blConExist As Boolean
    Private iRow As Integer

    Private Sub C1DBG_AfterColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles C1DBG.AfterColEdit
        Dim strContainerNo, strShipCode As String
        If e.ColIndex = 4 Then
            iRow = Me.C1DBG.Row
            Me.C1DBG.Columns("CONTAINER_NO").Text = Me.C1DBG.Columns("CONTAINER_NO").Text.Trim.ToUpper
            strContainerNo = Me.C1DBG.Columns("CONTAINER_NO").Text

            sqlExist = "SELECT * FROM CON_LOAD_TALLY_LIST WHERE (CONTAINER_NO = '" & strContainerNo & "' or CONTAINER_NO = '" & GetConOtherMode(strContainerNo) & "') and Checked = '0'"
            'sqlExist = "SELECT * FROM CON_LOAD_TALLY_LIST WHERE (CONTAINER_NO = '" & strContainerNo & "' or CONTAINER_NO = '" & GetConOtherMode(strContainerNo) & "') and Checked = '0' and Printed ='0' "
            dvExist = Filldata(sqlExist)
            If dvExist.Count > 0 Then   '����Ѵ�����δ��飬����
                Me.C1DBG.Columns("CHI_VESSEL").Value = dvExist(0)("CHI_VESSEL")
                Me.C1DBG.Columns("Voyage").Value = dvExist(0)("Voyage")
                Me.C1DBG.Columns("BLNO").Value = dvExist(0)("BLNO")
                Me.C1DBG.Columns("CodeYard").Value = dvExist(0)("CodeYard")
                Me.C1DBG.Columns("SIZE_CON").Value = dvExist(0)("SIZE_CON")
                Me.C1DBG.Columns("CONTAINER_TYPE").Value = dvExist(0)("CONTAINER_TYPE")
                Me.C1DBG.Columns("NEWSEALNO").Value = dvExist(0)("NEWSEALNO")
                'Me.C1DBG.Columns("FullOrEmpty").Value = dvExist(0)("FullOrEmpty")
                Me.C1DBG.Columns("SecSealNO").Value = dvExist(0)("SecSealNO")
                Me.C1DBG.Columns("ReasonOpenSeal").Value = dvExist(0)("ReasonOpenSeal")
                'Me.C1DBG.Columns("CheckTime").Value = dvExist(0)("CheckTime")
                Me.C1DBG.Columns("ConTime").Value = dvExist(0)("ConTime")
                Me.C1DBG.Columns("Clerk").Value = dvExist(0)("Clerk")
                If dvExist.Count > 1 Then
                    MessageBox.Show("������ظ����֣�������ƴ��", "�������", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                blConExist = True
                SendKeys.Send("{LEFT 2}")
                SendKeys.Send("{RIGHT 2}")
            Else   '��Ų����ڣ�����䣬�����
                blConExist = False
                sqlBeing = "SELECT CONTAINER_NO, SIZE_CON, CONTAINER_TYPE FROM CON_CRITERION WHERE CONTAINER_NO = '" & strContainerNo & "' or CONTAINER_NO = '" & GetConOtherMode(strContainerNo) & "'"
                dvConBeing = Filldata(sqlBeing)
                iConBeing = dvConBeing.Count
                If iConBeing > 0 Then    '��淶�д���,��д����Ϣ
                    Me.C1DBG.Columns("SIZE_CON").Value = dvConBeing.Item(0)("SIZE_CON")
                    Me.C1DBG.Columns("CONTAINER_TYPE").Value = dvConBeing.Item(0)("CONTAINER_TYPE")
                Else
                    iConCheck = CheckConNO(strContainerNo)
                    If iConCheck = 1 Then
                        Me.C1DBG.SelectedRows.Clear()
                        Me.C1DBG.SelectedRows.Add(Me.C1DBG.Row)
                        If MessageBox.Show("��װ��� " & strContainerNo & " ����������淶����У�鲻��ȷ��ȷ��������", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = DialogResult.No Then
                            Exit Sub
                        End If
                    ElseIf iConCheck = 0 Then
                        Me.C1DBG.SelectedRows.Clear()
                        Me.C1DBG.SelectedRows.Add(Me.C1DBG.Row)
                        'MessageBox.Show("��װ��Ų��淶��", "��ʾ")
                        'Exit Sub
                        If MessageBox.Show("��װ��� " & strContainerNo & " ����������淶����У�鲻��ȷ��ȷ��������", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = DialogResult.No Then
                            Exit Sub
                        End If
                    End If
                End If
                Dim sb As New System.Text.StringBuilder
                Dim sqlCheckExist As String
                Dim dvCheckExist As DataView
                sqlCheckExist = "select Container_No,CHI_VESSEL,ShipName,Voyage,BLNO,NO,Code_Yard_Name,InputTime from View_ConLoadTally where Container_No='" & Me.C1DBG.Columns("CONTAINER_NO").Text & "' and InputTime>DateAdd(dd,-31,GetDate())"
                dvCheckExist = Filldata(sqlCheckExist)
                If dvCheckExist.Count > 0 Then
                    sb.Append("���:" & dvCheckExist(0)("Container_No") & " ���ڳ��ֹ�" & vbLf)
                    sb.Append("����:" & dvCheckExist(0)("CHI_VESSEL") & " ")
                    sb.Append("����:" & dvCheckExist(0)("ShipName") & " ")
                    sb.Append("����:" & dvCheckExist(0)("Voyage") & vbLf)
                    sb.Append("�ᵥ:" & dvCheckExist(0)("BLNO") & " ")
                    sb.Append("���:" & dvCheckExist(0)("NO") & vbLf)
                    sb.Append("����:" & dvCheckExist(0)("Code_Yard_Name") & " ")
                    sb.Append("ʱ��:" & dvCheckExist(0)("InputTime"))
                    MessageBox.Show(sb.ToString(), "��ʾ")
                End If
            End If
        End If

        If e.ColIndex = 7 Then
            Me.C1DBG.Columns("CHI_VESSEL").Text = Me.C1DBG.Columns("CHI_VESSEL").Text.Trim.ToUpper
            strShipCode = Me.C1DBG.Columns("CHI_VESSEL").Text
            sqlShipCode = "SELECT SPCODE, CHI_VESSEL,ENG_VESSEL FROM Code_SHIPNAME WHERE (SPCODE = '" & strShipCode & "' or CHI_VESSEL = '" & strShipCode & "')"
            dvShipCode = Filldata(sqlShipCode)
            Me.labShipName.Text = ""
            If dvShipCode.Count > 0 Then
                Me.C1DBG.Columns("CHI_VESSEL").Text = dvShipCode(0)("SPCODE")
                If Not IsDBNull(dvShipCode(0)("CHI_VESSEL")) Then
                    Me.labShipName.Text = dvShipCode(0)("CHI_VESSEL")
                End If
                If Not IsDBNull(dvShipCode(0)("ENG_VESSEL")) Then
                    Me.labShipName.Text += "/" & dvShipCode(0)("ENG_VESSEL")
                End If
            Else
                Me.labShipName.Text = ""
                MessageBox.Show("���� " & strShipCode & " �����ڣ�����������", "��ʾ")
                Exit Sub
            End If
        End If
        If e.ColIndex = 9 Then
            If Me.C1DBG.Columns("VOYAGE").Text <> Me.C1DBG.Columns("VOYAGE").Text.Trim.ToUpper Then
                Me.C1DBG.Columns("VOYAGE").Text = Me.C1DBG.Columns("VOYAGE").Text.Trim.ToUpper
            End If
            If Me.C1DBG.Columns("BLNO").Text <> Me.C1DBG.Columns("BLNO").Text.Trim.ToUpper Then
                Me.C1DBG.Columns("BLNO").Text = Me.C1DBG.Columns("BLNO").Text.Trim.ToUpper
            End If
            'If iRow = Me.C1DBG.Row AndAlso blConExist = False Then
            '    'ͬһ�е���Ų�����ʱ����ᵥ�Ƿ���ڡ�
            '    Dim sqlBillExist As String
            '    Dim dvBillExist As DataView
            '    sqlBillExist = "SELECT ShipName, Voyage, BLNO, Code_Yard_Name, StateB FROM View_ConLoadTallyReceipt WHERE CHI_VESSEL = '" & Me.C1DBG.Columns("CHI_VESSEL").Text & "' AND Voyage = '" & Me.C1DBG.Columns("VOYAGE").Text & "' AND BLNO = '" & Me.C1DBG.Columns("BLNO").Text & "'"
            '    dvBillExist = Filldata(sqlBillExist)
            '    If dvBillExist.Count > 0 Then
            '        MessageBox.Show("��������¼ӣ����ᵥ�Ѵ��ڣ�����" & dvBillExist(0)("Code_Yard_Name") & "�����������ᵥ��", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    End If
            'End If
        End If
        If e.ColIndex = 11 Then
            Me.C1DBG.Columns("FullOrEmpty").Text = Me.C1DBG.Columns("FullOrEmpty").Text.Trim.ToUpper
            If Me.C1DBG.Columns("FullOrEmpty").Text = "E" Or Me.C1DBG.Columns("FullOrEmpty").Text = "F" Then
            Else
                MessageBox.Show("�������������롮E����ʾ���䣬����Ϊ��F������.", "��ʾ")
            End If
        End If
    End Sub

    Private Sub TrimGrid()
        Dim i As Integer
        Me.C1DBG.Focus()
        For i = 0 To dsContainer.Tables(0).Rows.Count - 1
            Me.C1DBG.Row = i
            Me.C1DBG.Columns("CHI_VESSEL").Text = Me.C1DBG.Columns("CHI_VESSEL").CellText(i).Trim.ToUpper
            Me.C1DBG.Columns("Voyage").Text = Me.C1DBG.Columns("Voyage").CellText(i).Trim.ToUpper
            Me.C1DBG.Columns("BLNO").Text = Me.C1DBG.Columns("BLNO").CellText(i).Trim().ToUpper
            Me.C1DBG.Columns("CONTAINER_NO").Text = Me.C1DBG.Columns("CONTAINER_NO").CellText(i).Trim().ToUpper
            Me.C1DBG.Columns("NEWSEALNO").Text = Me.C1DBG.Columns("NEWSEALNO").CellText(i).Trim().ToUpper
            Me.C1DBG.Columns("FullOrEmpty").Text = Me.C1DBG.Columns("FullOrEmpty").CellText(i).Trim.ToUpper
            Me.C1DBG.Columns("SecSealNO").Text = Me.C1DBG.Columns("SecSealNO").CellText(i).Trim.ToUpper
            Me.C1DBG.Columns("ReasonOpenSeal").Text = Me.C1DBG.Columns("ReasonOpenSeal").CellText(i).Trim()
            Me.C1DBG.Columns("CONTAINER_TYPE").Text = Me.C1DBG.Columns("CONTAINER_TYPE").CellText(i).Trim.ToUpper
            If Me.C1DBG.Columns("CHI_VESSEL").Text = "HCHE" And Me.C1DBG.Columns("Voyage").Text = "001" Then     '����ǻ���001����
                Me.C1DBG.Columns("StateC").Text = "0"       '״̬Ϊ0
            End If
        Next
        Me.btQuit.Focus()
    End Sub

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        Dim i, j As Integer
        Dim containerNo, shipCode, voyage, billNo As String
        Dim strNewNo As String

        Call TrimGrid()
        '������
        For i = 0 To dvContainer.Count - 1
            containerNo = Me.C1DBG.Columns("CONTAINER_NO").CellText(i)
            shipCode = Me.C1DBG.Columns("CHI_VESSEL").CellText(i)
            voyage = Me.C1DBG.Columns("Voyage").CellText(i)
            billNo = Me.C1DBG.Columns("BLNO").CellText(i)
            Me.C1DBG.Row = i
            If containerNo <> "" Then
                If shipCode <> "" Then
                    If voyage <> "" Then
                        If billNo <> "" Then
                            If Me.C1DBG.Columns("FullOrEmpty").CellText(i) = "E" Or Me.C1DBG.Columns("FullOrEmpty").CellText(i) = "F" Then
                            Else
                                Me.C1DBG.Row = i
                                MessageBox.Show("�������������롮E����ʾ���䣬����Ϊ��F������.", "��ʾ")
                                Exit Sub
                            End If

                            '�����淶
                            sqlExist = "SELECT * FROM CON_LOAD_TALLY_LIST WHERE (CONTAINER_NO = '" & containerNo & "' or CONTAINER_NO = '" & GetConOtherMode(containerNo) & "') and Checked = '0'"
                            dvExist = Filldata(sqlExist)
                            If dvExist.Count > 0 Then   '����Ѵ�����δ���أ�����

                            Else   '��Ų����ڣ�����䣬�����
                                sqlBeing = "SELECT CONTAINER_NO, SIZE_CON, CONTAINER_TYPE FROM CON_CRITERION WHERE CONTAINER_NO = '" & containerNo & "' or CONTAINER_NO = '" & GetConOtherMode(containerNo) & "'"
                                dvConBeing = Filldata(sqlBeing)
                                iConBeing = dvConBeing.Count
                                If iConBeing > 0 Then    '��淶�д���
                                Else
                                    iConCheck = CheckConNO(containerNo)
                                    If iConCheck = 1 Then
                                        Me.C1DBG.Row = i
                                        Me.C1DBG.SelectedRows.Clear()
                                        Me.C1DBG.SelectedRows.Add(i)
                                        If MessageBox.Show("��װ��� " & containerNo & " ����������淶����У�鲻��ȷ��ȷ��������", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                            Exit For
                                        End If
                                    ElseIf iConCheck = 0 Then
                                        Me.C1DBG.Row = i
                                        Me.C1DBG.SelectedRows.Clear()
                                        Me.C1DBG.SelectedRows.Add(i)
                                        'MessageBox.Show("��װ��Ų��淶��", "��ʾ")
                                        'Exit For
                                        If MessageBox.Show("��װ��� " & containerNo & " ����������淶����У�鲻��ȷ��ȷ��������", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                                            Exit For
                                        End If
                                    End If
                                End If
                            End If
                            '��鴬��
                            sqlShipCode = "SELECT SPCODE, CHI_VESSEL FROM Code_SHIPNAME WHERE SPCODE = '" & shipCode & "'"
                            dvShipCode = Filldata(sqlShipCode)
                            If dvShipCode.Count > 0 Then
                                'Me.C1DBG.Columns("CHI_VESSEL").Text = dvShipCode(0)("SPCODE")
                            Else
                                Me.C1DBG.Row = i
                                Me.C1DBG.SelectedRows.Clear()
                                Me.C1DBG.SelectedRows.Add(i)
                                MessageBox.Show("���� " & shipCode & " �����ڣ�����������", "��ʾ")
                                Exit For
                            End If
                            '����ظ�
                            For j = 0 To i - 1
                                If IsEqualConNo(containerNo, Me.C1DBG.Columns("CONTAINER_NO").CellText(j)) And shipCode = Me.C1DBG.Columns("CHI_VESSEL").CellText(j) And _
                                    voyage = Me.C1DBG.Columns("Voyage").CellText(j) And billNo = Me.C1DBG.Columns("BLNO").CellText(j) Then
                                    Me.C1DBG.Row = i
                                    Me.C1DBG.SelectedRows.Clear()
                                    Me.C1DBG.SelectedRows.Add(i)
                                    Me.C1DBG.SelectedRows.Add(j)
                                    MessageBox.Show("��" & j + 1 & "�к͵�" & i + 1 & "���ظ���", "��ʾ")
                                    Exit Sub
                                End If
                            Next

                        Else
                            Me.C1DBG.Row = i
                            MessageBox.Show("�ᵥ�Ų���Ϊ��", "��ʾ")
                            Exit For
                        End If
                    Else
                        Me.C1DBG.Row = i
                        MessageBox.Show("���β���Ϊ��", "��ʾ")
                        Exit For
                    End If
                Else
                    Me.C1DBG.Row = i
                    MessageBox.Show("���벻��Ϊ��", "��ʾ")
                    Exit For
                End If
            Else
                Me.C1DBG.Row = i
                MessageBox.Show("��Ų���Ϊ��", "��ʾ")
                Exit For
            End If
        Next

        '�������Ƿ������ݿ��������ظ���ͬ�ᵥ����Ų����ظ����˴����¿��ظ�������ƴ�䣩
        Dim sqlRepeat As String
        Dim dvRepeat As New DataView
        If i >= dvContainer.Count Then    '����������
            For i = 0 To dvContainer.Count - 1    '���ݿ���
                containerNo = Me.C1DBG.Columns("CONTAINER_NO").CellText(i)
                shipCode = Me.C1DBG.Columns("CHI_VESSEL").CellText(i)
                voyage = Me.C1DBG.Columns("Voyage").CellText(i)
                billNo = Me.C1DBG.Columns("BLNO").CellText(i)

                sqlExist = "SELECT * FROM CON_LOAD_TALLY_LIST WHERE (CONTAINER_NO = '" & containerNo & "' or CONTAINER_NO = '" & GetConOtherMode(containerNo) & "') and Checked = '0'"
                'sqlExist = "SELECT * FROM CON_LOAD_TALLY_LIST WHERE (CONTAINER_NO = '" & containerNo & "' or CONTAINER_NO = '" & GetConOtherMode(containerNo) & "') and Checked = '0' and Printed ='0' "
                dvExist = Filldata(sqlExist)
                If dvExist.Count > 0 Then   '����Ѵ�����δ���ţ����� �޸�ԭ����Ϣ ���ü��
                    '©����δ����Ļ��䣨״̬Ϊ0�ģ����ͺ���
                Else    '�¼��䣬
                    sqlRepeat = "SELECT CHI_VESSEL, Voyage, BLNO, CONTAINER_NO FROM CON_LOAD_TALLY_LIST WHERE CHI_VESSEL = '" & shipCode & "' AND Voyage = '" & voyage & "' AND BLNO = '" & billNo & _
                                        "' AND ( CONTAINER_NO = '" & containerNo & "'  or CONTAINER_NO = '" & GetConOtherMode(containerNo) & "')"
                    dvRepeat = Filldata(sqlRepeat)
                    If dvRepeat.Count > 0 Then  '������ظ�
                        Me.C1DBG.Row = i
                        Me.C1DBG.SelectedRows().Clear()
                        Me.C1DBG.SelectedRows.Add(i)
                        MessageBox.Show("�ô���ͬһ�ᵥ�´�������ظ������ܴ�����Ѳ��������������", "��ʾ")
                        Exit For
                    End If
                End If
            Next
        End If

        Dim Count, deleteSum As Integer
        Count = dvContainer.Count
        deleteSum = 0
        If i >= dvContainer.Count Then  '�޸���������Ϣ 
            For i = dvContainer.Count - 1 To 0 Step -1  '�������������
                containerNo = Me.C1DBG.Columns("CONTAINER_NO").CellText(i)
                shipCode = Me.C1DBG.Columns("CHI_VESSEL").CellText(i)
                voyage = Me.C1DBG.Columns("Voyage").CellText(i)
                billNo = Me.C1DBG.Columns("BLNO").CellText(i)
                sqlExist = "SELECT * FROM CON_LOAD_TALLY_LIST WHERE (CONTAINER_NO = '" & containerNo & "' or CONTAINER_NO = '" & GetConOtherMode(containerNo) & "') and Checked = '0'"
                'sqlExist = "SELECT * FROM CON_LOAD_TALLY_LIST WHERE (CONTAINER_NO = '" & containerNo & "' or CONTAINER_NO = '" & GetConOtherMode(containerNo) & "') and Checked = '0' and Printed ='0' "
                dvExist = Filldata(sqlExist)
                If dvExist.Count > 0 Then   '���� �޸�ԭ����Ϣ (ͬһ�����������ĸ��ᵥ������δ�����䣬��ͽ����ƴ������)
                    If shipCode <> "HCHE" Then  '�����Ѵ��ڵĻ��䣬�����ظ�¼�룬������
                        Dim sqlUpdateCon As String
                        'sqlUpdateCon = "update con_load_tally_list set NEWSEALNO='" & Me.C1DBG.Columns("NEWSEALNO").CellText(i) & "', SecSealNO='" & Me.C1DBG.Columns("SecSealNO").CellText(i) & "', ReasonOpenSeal='" & Me.C1DBG.Columns("ReasonOpenSeal").CellText(i) & "', Checked=1 " & _
                        '                "where CHI_VESSEL='" & shipCode & " ' and voyage='" & voyage & "' and (CONTAINER_NO = '" & containerNo & "' or CONTAINER_NO = '" & GetConOtherMode(containerNo) & "') and Checked = 0 "
                        If Me.C1DBG.Columns("CodeYard").Value = "99" Then   '�ǻ���¼�룬�޸ĳ�վ
                            sqlUpdateCon = "update con_load_tally_list set CodeYard = '" & strYard & "' , SIZE_CON='" & Me.C1DBG.Columns("SIZE_CON").CellText(i) & "', CONTAINER_TYPE='" & Me.C1DBG.Columns("CONTAINER_TYPE").CellText(i) & "' " & _
                                " ,NEWSEALNO='" & Me.C1DBG.Columns("NEWSEALNO").CellText(i) & "', SecSealNO='" & Me.C1DBG.Columns("SecSealNO").CellText(i) & "', ReasonOpenSeal='" & Me.C1DBG.Columns("ReasonOpenSeal").CellText(i) & "' " & _
                                " ,StateC='1',Checked='1',CheckTime='" & Now & "',CheckMan='" & G_User & "' " & _
                                " where CHI_VESSEL='" & shipCode & "' and voyage='" & voyage & "' and (CONTAINER_NO = '" & containerNo & "' or CONTAINER_NO = '" & GetConOtherMode(containerNo) & "') and StateC = 0 "
                            ExecSql(sqlUpdateCon)

                            Dim sqlCheckComplete As String
                            Dim dvCheckComplete As New DataView
                            sqlCheckComplete = "SELECT CodeYard FROM CON_LOAD_TALLY_LIST WHERE (CHI_VESSEL = '" & shipCode & "') AND (Voyage = '" & voyage & "') AND (BLNO = '" & billNo & "') GROUP BY CodeYard "
                            dvCheckComplete = Filldata(sqlCheckComplete)
                            If dvCheckComplete.Count = 1 Then   'ȫ������Ų�����ˣ��޸��ᵥ�ĳ�վ����Ϊ��07����״̬Ϊ1
                                If dvCheckComplete(0)("CodeYard") = strYard Then
                                    Dim sqlModiBillYard As String
                                    strNewNo = GetAutoNo(strYard)    '������������
                                    sqlModiBillYard = "UPDATE CON_LOAD_TALLY SET WORK_PLACE = '" & strYard & "', NO = '" & strNewNo & "', StateB='1', TALLY_CLERK= '" & G_User & "' WHERE (CHI_VESSEL = '" & shipCode & "') AND (Voyage = '" & voyage & "') AND (BLNO = '" & billNo & "')"
                                    ExecSql(sqlModiBillYard)
                                End If
                            End If
                        Else    '������ͨ��վ��Ĵ���
                            sqlUpdateCon = "update con_load_tally_list set SIZE_CON='" & Me.C1DBG.Columns("SIZE_CON").CellText(i) & "', CONTAINER_TYPE='" & Me.C1DBG.Columns("CONTAINER_TYPE").CellText(i) & "' " & _
                                " ,NEWSEALNO='" & Me.C1DBG.Columns("NEWSEALNO").CellText(i) & "', SecSealNO='" & Me.C1DBG.Columns("SecSealNO").CellText(i) & "', ReasonOpenSeal='" & Me.C1DBG.Columns("ReasonOpenSeal").CellText(i) & "' " & _
                                " ,Checked='1',CheckTime='" & Now & "',CheckMan='" & G_User & "' " & _
                                " where CHI_VESSEL='" & shipCode & " ' and voyage='" & voyage & "' and (CONTAINER_NO = '" & containerNo & "' or CONTAINER_NO = '" & GetConOtherMode(containerNo) & "') and Checked = 0 "
                            ExecSql(sqlUpdateCon)
                        End If
                        '�����޸����������µ��䣬�����ٴδ򿪲�����棬¼�����Ų��顣�������������
                    End If
                    Me.C1DBG.Row = i    'ɾȥ��������Ϣ,�����ظ�����
                    Me.C1DBG.Delete()
                    deleteSum += 1
                End If
            Next
        End If
        Count = Count - deleteSum

        Dim sqlBillNo As String
        Dim sqlInsertBill As String
        Dim strAutoNo As String

        Dim sqlRealYard As String
        Dim strRealYard As String
        Dim iRealYear, iRealMaxNo As Integer
        Dim dvRealYard As New DataView
        Dim dvBillNo As New DataView

        Try
            If i < 0 Then
                '������ᵥ״̬���ƣ�
                For i = 0 To Count - 1
                    shipCode = Me.C1DBG.Columns("CHI_VESSEL").CellText(i)
                    voyage = Me.C1DBG.Columns("Voyage").CellText(i)
                    billNo = Me.C1DBG.Columns("BLNO").CellText(i)

                    sqlBillNo = "SELECT BLNO,StateB FROM CON_LOAD_TALLY WHERE CHI_VESSEL = '" & shipCode & "' AND Voyage = '" & voyage & "' AND BLNO = '" & billNo & "' and WORK_PLACE='" & strYard & "'"
                    dvBillNo = Filldata(sqlBillNo)
                    If dvBillNo.Count > 0 Then   'û���ᵥ��վ��Ϣ ��
                        If dvBillNo(0)("StateB") >= 2 Then
                            MessageBox.Show("���ᵥ " & billNo & " �ѳ�֤����������", "��ʾ")
                            Exit Sub
                        End If
                    End If
                Next

                'sqlYard = "SELECT Code_Yard_ID, Code_Yard_Name, CodePrefix, CodeMax, CodeYear, DeptCode FROM Code_Yard WHERE DeptCode = '" & G_DeptCode & "'"
                sqlYard = "SELECT Code_Yard_ID, Code_Yard_Name, CodePrefix, CodeMax, CodeYear, DeptCode FROM Code_Yard WHERE Code_Yard_ID = '" & strYard & "'"
                dvYard = Filldata(sqlYard)
                If dvYard.Count > 0 Then
                    'strYard = dvYard(0)("Code_Yard_ID")
                    iYear = dvYard(0)("CodeYear")
                    iMaxNo = dvYard(0)("CodeMax")
                End If              '�õ�����ͷ����š����

                For i = 0 To Count - 1
                    shipCode = Me.C1DBG.Columns("CHI_VESSEL").CellText(i)
                    voyage = Me.C1DBG.Columns("Voyage").CellText(i)
                    billNo = Me.C1DBG.Columns("BLNO").CellText(i)

                    sqlBillNo = "SELECT BLNO FROM CON_LOAD_TALLY WHERE CHI_VESSEL = '" & shipCode & "' AND Voyage = '" & voyage & "' AND BLNO = '" & billNo & "' and WORK_PLACE='" & strYard & "'"
                    dvBillNo = Filldata(sqlBillNo)
                    If dvBillNo.Count = 0 Then   'û���ᵥ��վ��Ϣ ��
                        If Me.C1DBG.Columns("CodeYard").CellValue(i) = strYard Then
                            If iYear + 1 = Now.Year Then    '���������һ�� ��ݼ�һ �������
                                iYear = Now.Year
                                iMaxNo = 1      '�Ƿ����0��ţ���Ҫ
                            Else    '�����ż�һ
                                iMaxNo = iMaxNo + 1
                            End If
                            strNewNo = String.Concat(dvYard(0)("CodePrefix"), iYear.ToString, Microsoft.VisualBasic.Right(String.Concat("00000", iMaxNo.ToString), 6))
                        Else
                            'sqlRealYard = "SELECT Code_Yard_ID, Code_Yard_Name, CodePrefix, CodeMax, CodeYear, DeptCode FROM Code_Yard WHERE Code_Yard_ID = '" & Me.C1DBG.Columns("CodeYard").CellValue(i) & "'"
                            'dvRealYard = Filldata(sqlRealYard)
                            'strRealYard = dvRealYard(0)("Code_Yard_ID")
                            'iRealYear = dvRealYard(0)("CodeYear")
                            'iRealMaxNo = dvRealYard(0)("CodeMax")

                            'If iRealYear + 1 = Now.Year Then    '���������һ�� ��ݼ�һ �������
                            '    iRealYear = Now.Year
                            '    iRealMaxNo = 0
                            'Else    '�����ż�һ
                            '    iRealMaxNo = iRealMaxNo + 1
                            'End If
                            'strNewNo = String.Concat(dvRealYard(0)("CodePrefix"), iRealYear.ToString, Microsoft.VisualBasic.Right(String.Concat("00000", iRealMaxNo.ToString), 6))
                            strNewNo = GetAutoNo(Me.C1DBG.Columns("CodeYard").CellValue(i))    '������������
                        End If
                        If shipCode = "HCHE" Then   '�ǻ𳵴��еģ�״̬Ϊ0
                            sqlInsertBill = "INSERT INTO CON_LOAD_TALLY (CHI_VESSEL, Voyage, InOutPort, CodeLoadPort, NO, WORK_PLACE, TIME_FROM, BLNO, WORKTYPE, CODE_TALLY_TYPE, USER_NAME, TALLY_CLERK, CODE_CON_CONSIGN, StateB) " & _
                                    "VALUES ('" & shipCode & "', '" & voyage & "', '1', 'CNLYG', '" & strNewNo & "', '" & Me.C1DBG.Columns("CodeYard").CellValue(i) & "', '" & Now & "', '" & billNo & "', '2', '3', '" & G_User & "', '" & G_User & "', '00', '0')"
                        Else
                            sqlInsertBill = "INSERT INTO CON_LOAD_TALLY (CHI_VESSEL, Voyage, InOutPort, CodeLoadPort, NO, WORK_PLACE, TIME_FROM, BLNO, WORKTYPE, CODE_TALLY_TYPE, USER_NAME, TALLY_CLERK, CODE_CON_CONSIGN, StateB) " & _
                                    "VALUES ('" & shipCode & "', '" & voyage & "', '1', 'CNLYG', '" & strNewNo & "', '" & Me.C1DBG.Columns("CodeYard").CellValue(i) & "', '" & Now & "', '" & billNo & "', '2', '3', '" & G_User & "', '" & G_User & "', '00', '1')"
                        End If

                        ExecSql(sqlInsertBill)
                        'If Me.C1DBG.Columns("CodeYard").CellValue(i) <> strYard Then
                        '    Dim sqlRealUpdateYard As String     '�޸ĳ�վ�����
                        '    sqlRealUpdateYard = "update Code_Yard set CodeMax='" & iRealMaxNo & "', CodeYear='" & iRealYear & "' where Code_Yard_ID='" & Me.C1DBG.Columns("CodeYard").CellValue(i) & "'"
                        '    ExecSql(sqlRealUpdateYard)
                        'End If
                    End If
                Next

                Dim sqlUpdateYard As String     '���¡���ͷ����š����
                sqlUpdateYard = "update Code_Yard set CodeMax='" & iMaxNo & "', CodeYear='" & iYear & "' where Code_Yard_ID='" & strYard & "'"
                ExecSql(sqlUpdateYard)
            End If

            If i >= Count Then     'ȫ��ͨ�������������˸üӵ��ᵥ
                daContainer.Update(dsContainer)
                Me.Close()
                blSave = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub C1DBG_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1DBG.KeyDown
        If e.KeyCode = Keys.Return And Me.C1DBG.Col = 17 Then
            Me.C1DBG.Row += 1
            Me.C1DBG.Col = 2
            'SendKeys.Send("{LEFT 7}")
            'SendKeys.Send("{ENTER}")
        End If
    End Sub

    Private Sub C1DBG_AfterInsert(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.AfterInsert
        Me.C1DBG.Columns("CONTAINER_NO").FooterText = "�ϼ�" & dvContainer.Count & "��"
    End Sub

    Private Sub C1DBG_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.AfterDelete
        Me.C1DBG.Columns("CONTAINER_NO").FooterText = "�ϼ�" & dvContainer.Count & "��"
    End Sub

End Class