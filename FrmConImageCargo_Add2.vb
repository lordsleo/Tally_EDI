Imports TALLY.DBControl
Public Class FrmConImageCargo_Add2
    Inherits System.Windows.Forms.Form

    Dim dsContainer As New DataSet
    Dim daContainer As New SqlClient.SqlDataAdapter
    Dim dvContainer As New DataView

    Dim sqlState As String
    Dim dvState As New DataView
    Dim sqlPort As String
    Dim dvPort As New DataView

    Dim strConNo, strConBay As String
    Dim iConCheck As Integer
    'Dim sqlBeing As String
    'Dim dvBeing As New DataView
    Dim strConState, strLoadCode, strUnLoadCode, strDeliveryCode As String

    Dim sqlConBeing As String
    Dim dvConBeing As New DataView

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
    Friend WithEvents C1DBG As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents lbState As System.Windows.Forms.Label
    Friend WithEvents lbDelivery As System.Windows.Forms.Label
    Friend WithEvents lbUnload As System.Windows.Forms.Label
    Friend WithEvents lbLoad As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmConImageCargo_Add2))
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.lbState = New System.Windows.Forms.Label
        Me.lbDelivery = New System.Windows.Forms.Label
        Me.lbUnload = New System.Windows.Forms.Label
        Me.lbLoad = New System.Windows.Forms.Label
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DBG
        '
        Me.C1DBG.AllowAddNew = True
        Me.C1DBG.AllowDelete = True
        Me.C1DBG.CaptionHeight = 18
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(2, 44)
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
        Me.C1DBG.Size = New System.Drawing.Size(590, 346)
        Me.C1DBG.TabIndex = 37
        Me.C1DBG.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1TrueDBGrid.Design.ContextWrappe" & _
        "r""><Data>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}E" & _
        "ditor{}Style2{}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:Inactive" & _
        "CaptionText;BackColor:InactiveCaption;}FilterBar{}Footer{}Caption{AlignHorz:Cent" & _
        "er;}Style14{}Normal{}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" & _
        "tyle1{}OddRow{}RecordSelector{AlignImage:Center;}Style15{}Heading{Wrap:True;Back" & _
        "Color:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}" & _
        "Style8{}Style10{AlignHorz:Near;}Style11{}Style12{}Style13{}Style9{}</Data></Styl" & _
        "es><Splits><C1.Win.C1TrueDBGrid.MergeView Name="""" CaptionHeight=""18"" ColumnCapti" & _
        "onHeight=""18"" ColumnFooterHeight=""18"" MarqueeStyle=""DottedCellBorder"" RecordSele" & _
        "ctorWidth=""16"" DefRecSelWidth=""16"" VerticalScrollGroup=""1"" HorizontalScrollGroup" & _
        "=""1""><ClientRect>0, 0, 586, 342</ClientRect><BorderSide>0</BorderSide><CaptionSt" & _
        "yle parent=""Style2"" me=""Style10"" /><EditorStyle parent=""Editor"" me=""Style5"" /><E" & _
        "venRowStyle parent=""EvenRow"" me=""Style8"" /><FilterBarStyle parent=""FilterBar"" me" & _
        "=""Style13"" /><FooterStyle parent=""Footer"" me=""Style3"" /><GroupStyle parent=""Grou" & _
        "p"" me=""Style12"" /><HeadingStyle parent=""Heading"" me=""Style2"" /><HighLightRowStyl" & _
        "e parent=""HighlightRow"" me=""Style7"" /><InactiveStyle parent=""Inactive"" me=""Style" & _
        "4"" /><OddRowStyle parent=""OddRow"" me=""Style9"" /><RecordSelectorStyle parent=""Rec" & _
        "ordSelector"" me=""Style11"" /><SelectedStyle parent=""Selected"" me=""Style6"" /><Styl" & _
        "e parent=""Normal"" me=""Style1"" /></C1.Win.C1TrueDBGrid.MergeView></Splits><NamedS" & _
        "tyles><Style parent="""" me=""Normal"" /><Style parent=""Normal"" me=""Heading"" /><Styl" & _
        "e parent=""Heading"" me=""Footer"" /><Style parent=""Heading"" me=""Caption"" /><Style p" & _
        "arent=""Heading"" me=""Inactive"" /><Style parent=""Normal"" me=""Selected"" /><Style pa" & _
        "rent=""Normal"" me=""Editor"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style pa" & _
        "rent=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=" & _
        """Heading"" me=""RecordSelector"" /><Style parent=""Normal"" me=""FilterBar"" /><Style p" & _
        "arent=""Caption"" me=""Group"" /></NamedStyles><vertSplits>1</vertSplits><horzSplits" & _
        ">1</horzSplits><Layout>None</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth><" & _
        "ClientArea>0, 0, 586, 342</ClientArea><PrintPageHeaderStyle parent="""" me=""Style1" & _
        "4"" /><PrintPageFooterStyle parent="""" me=""Style15"" /></Blob>"
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(298, 398)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 463
        Me.btQuit.Text = "�˳�"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(230, 398)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 462
        Me.btSave.Text = "ȷ��"
        '
        'lbState
        '
        Me.lbState.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lbState.Location = New System.Drawing.Point(6, 6)
        Me.lbState.Name = "lbState"
        Me.lbState.Size = New System.Drawing.Size(94, 30)
        Me.lbState.TabIndex = 501
        Me.lbState.Text = "��״̬��"
        Me.lbState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbDelivery
        '
        Me.lbDelivery.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lbDelivery.Location = New System.Drawing.Point(428, 6)
        Me.lbDelivery.Name = "lbDelivery"
        Me.lbDelivery.Size = New System.Drawing.Size(160, 30)
        Me.lbDelivery.TabIndex = 503
        Me.lbDelivery.Text = "�����أ�"
        Me.lbDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbUnload
        '
        Me.lbUnload.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lbUnload.Location = New System.Drawing.Point(266, 6)
        Me.lbUnload.Name = "lbUnload"
        Me.lbUnload.Size = New System.Drawing.Size(160, 30)
        Me.lbUnload.TabIndex = 504
        Me.lbUnload.Text = "ж���ۣ�"
        Me.lbUnload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbLoad
        '
        Me.lbLoad.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lbLoad.Location = New System.Drawing.Point(104, 6)
        Me.lbLoad.Name = "lbLoad"
        Me.lbLoad.Size = New System.Drawing.Size(160, 30)
        Me.lbLoad.TabIndex = 502
        Me.lbLoad.Text = "װ���ۣ�"
        Me.lbLoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmConImageCargo_Add2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(594, 429)
        Me.Controls.Add(Me.lbDelivery)
        Me.Controls.Add(Me.lbUnload)
        Me.Controls.Add(Me.lbLoad)
        Me.Controls.Add(Me.lbState)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.C1DBG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConImageCargo_Add2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "��װ�䴬ͼ��Ϣ �б�����"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmConImageCargo_Add2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
   
        sqlState = "SELECT EFL_Code, EFL_Name FROM Code_ConEFLType WHERE EFL_Code <> '0'"
        dvState = Filldata(sqlState)
        sqlPort = "SELECT CODE_PORT, PORT_CHA FROM CODE_PORT ORDER BY CODE_PORT"
        dvPort = Filldata(sqlPort)

        Dim sqlContainer As String
        sqlContainer = "SELECT CON_IMAGE_ID, SHIP_ID, MOVED, USER_NAME, Load_Port, Unload_Port, DELIVERY, CONTAINER_NO, BAYNO, BLNO, FULLOREMPTY, CODE_LOAD_PORT, CODE_UNLOAD_PORT, CODE_DELIVERY,GROSSWEIGHT FROM CON_IMAGE WHERE SHIP_ID = -1"
        dvContainer = Updatedata(daContainer, sqlContainer, dsContainer)

        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Call GetConTable()
    End Sub

    Private Sub GetConTable()
        dsContainer.Tables(0).Columns.Add("ConSize", GetType(Integer))
        dsContainer.Tables(0).Columns.Add("ConType", GetType(String))
        dsContainer.Tables(0).Columns.Add("ConWeight", GetType(Decimal))
        dsContainer.Tables(0).Columns.Add("AddFlag", GetType(Integer))
        dsContainer.Tables(0).Columns("ConSize").AllowDBNull = False
        dsContainer.Tables(0).Columns("ConType").AllowDBNull = False
        dsContainer.Tables(0).Columns("AddFlag").DefaultValue = 0

        'dsContainer.Tables(0).Columns("ConType").Site = 3

        Me.C1DBG.DataSource = dvContainer
        Me.C1DBG.Columns.Item("CONTAINER_NO").FooterText = "�¼�" & dvContainer.Count & "��"

        Me.C1DBG.Columns("CONTAINER_NO").Caption = "��װ���"
        Me.C1DBG.Columns("FULLOREMPTY").Caption = "��״̬"
        Me.C1DBG.Columns("BAYNO").Caption = "��λ��"
        Me.C1DBG.Columns("BLNO").Caption = "�ᵥ��"
        Me.C1DBG.Columns("CODE_LOAD_PORT").Caption = "װ�۴���"
        Me.C1DBG.Columns("CODE_UNLOAD_PORT").Caption = "ж�۴���"
        Me.C1DBG.Columns("CODE_DELIVERY").Caption = "�����ش���"
        Me.C1DBG.Columns("ConSize").Caption = "��ߴ�"
        Me.C1DBG.Columns("ConType").Caption = "����"
        Me.C1DBG.Columns("ConWeight").Caption = "��Ƥ��"
        Me.C1DBG.Columns("GROSSWEIGHT").Caption = "��ë��"

        Dim i As Integer
        For i = 0 To 6
            Me.C1DBG.Splits(0).DisplayColumns(i).Visible = False
        Next
        Me.C1DBG.Splits(0).DisplayColumns("AddFlag").Visible = False

        For i = 7 To Me.C1DBG.Columns.Count - 1
            Me.C1DBG.Splits(0).DisplayColumns(i).Width = 70
        Next
        Me.C1DBG.Splits(0).DisplayColumns("FULLOREMPTY").Width = 40
        Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Width = 90
        Me.C1DBG.Splits(0).DisplayColumns("BLNO").Width = 100
        Me.C1DBG.Splits(0).DisplayColumns("ConSize").Width = 30
        Me.C1DBG.Splits(0).DisplayColumns("ConType").Width = 30
        Me.C1DBG.Splits(0).DisplayColumns("ConWeight").Width = 60
        Me.C1DBG.Splits(0).DisplayColumns("GROSSWEIGHT").Width = 60

        dsContainer.Tables(0).Columns("BLNO").DefaultValue = ""

        Me.C1DBG.Columns("SHIP_ID").DefaultValue = Ship_ID
        Me.C1DBG.Columns("MOVED").DefaultValue = 0
        Me.C1DBG.Columns("USER_NAME").DefaultValue = G_User
        'Me.C1DBG.Columns("FULLOREMPTY").DefaultValue = "E"
        If FrmConImageCargo.InOutCode = "0" Then    'in
            Me.C1DBG.Columns("CODE_UNLOAD_PORT").DefaultValue = "CNLYG"
            Me.C1DBG.Columns("Unload_Port").DefaultValue = "���Ƹ�"
        ElseIf FrmConImageCargo.InOutCode = "1" Then    'out
            Me.C1DBG.Columns("CODE_LOAD_PORT").DefaultValue = "CNLYG"
            Me.C1DBG.Columns("Load_Port").DefaultValue = "���Ƹ�"
        End If
    End Sub

    Private Function CheckConNO(ByVal sm As String) As Integer 'return 0 ����д� 1 У���д� 2 У����ȷ
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

    Function IsCode(ByVal str As String) As Boolean    ' ��ͷ����
        Dim i As Integer
        Dim ch As Char
        str = str.ToUpper
        If str.Length <= 5 Then
            For i = 1 To str.Length
                ch = Mid(str, i, 1)
                If Not (ch Like "[A-Z]" Or ch = " ") Then
                    Exit For
                End If
                'If Not Char.IsLetter(Mid(str, i, 1)) Then
                '    Exit For
                'End If
            Next
        End If
        If i > str.Length Then
            Return True     '���λ���м�ɿ�
        Else
            Return False
        End If
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

    Private Function GetConOtherMode(ByVal ConNo As String) As String   '�õ���ŵ���һ���޿ջ��п���ʽ
        ConNo = ConNo.Trim.ToUpper
        If ConNo.Length = 11 Then
            ConNo = ConNo.Insert(4, " ")
        ElseIf ConNo.Length = 12 Then
            ConNo = ConNo.Remove(4, 1)
        End If
        Return ConNo
    End Function

    Private Function IsEqualBayNo(ByVal strBayNo1 As String, ByVal strBayNo2 As String) As Boolean
        Dim Sign As Boolean                                 '�Ƚϱ�λ���Ƿ��ظ�
        strBayNo1 = strBayNo1.Trim
        strBayNo2 = strBayNo2.Trim
        If String.Equals(strBayNo1, strBayNo2) Or String.Equals(strBayNo1, TongBayNoFont(strBayNo2)) Or String.Equals(strBayNo1, TongBayNoLater(strBayNo2)) Then
            Sign = True
        End If
        Return Sign
    End Function

    Private Function TongBayNoFont(ByVal strBayNo As String) As String  '�õ���ǰͨ���š�
        Dim strBayNoFont As String
        strBayNoFont = strBayNo.Trim
        strBayNoFont = String.Concat(CStr(CInt(String.Concat("2", strBayNoFont.Substring(0, 2))) - 1), strBayNoFont.Substring(2, 4)).Substring(1, 6)
        Return strBayNoFont
    End Function

    Private Function TongBayNoLater(ByVal strBayNo As String) As String  '�õ�����ͨ���š�
        Dim strBayNoLater As String
        strBayNoLater = strBayNo.Trim
        strBayNoLater = String.Concat(CStr(CInt(String.Concat("2", strBayNoLater.Substring(0, 2))) + 1), strBayNoLater.Substring(2, 4)).Substring(1, 6)
        Return strBayNoLater
    End Function

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Try
            Dim i, j, k As Integer

            For i = 0 To dvContainer.Count - 1
                If Me.C1DBG.Columns("ConSize").CellText(i) Like "##" Then
                    If Me.C1DBG.Columns("ConType").CellText(i) Like "[A-Z][A-Z]" Then
                        '���ͨ������
                    Else
                        Me.C1DBG.Row = i
                        Me.C1DBG.SelectedRows.Clear()
                        Me.C1DBG.SelectedRows.Add(i)
                        MessageBox.Show("���Ͳ��Ϲ淶��", "��ʾ")
                        Exit Sub
                    End If
                Else
                    Me.C1DBG.Row = i
                    Me.C1DBG.SelectedRows.Clear()
                    Me.C1DBG.SelectedRows.Add(i)
                    MessageBox.Show("��ߴ粻�Ϲ淶��", "��ʾ")
                    Exit Sub
                End If
            Next

            For i = 0 To dvContainer.Count - 1  '������
                If Not IsDBNull(Me.C1DBG.Columns("CODE_LOAD_PORT").CellValue(i)) Then
                    strLoadCode = Me.C1DBG.Columns("CODE_LOAD_PORT").CellText(i)
                    For k = 0 To (dvPort.Count - 1) / 2
                        If strLoadCode.Equals(dvPort(k)("CODE_PORT")) = True Or strLoadCode.Equals(dvPort(dvPort.Count - 1 - k)("CODE_PORT")) = True Then
                            Exit For
                        End If
                    Next
                    If k > (dvPort.Count - 1) / 2 Then
                        Me.C1DBG.Row = i
                        Me.C1DBG.SelectedRows.Clear()
                        Me.C1DBG.SelectedRows.Add(i)
                        If IsCode(strLoadCode) Then     '�ж��Ǵ������ʽ
                            If MessageBox.Show("װ�۴���" & strLoadCode & "�����ڣ�ȷ����ȷô��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                                Exit Sub
                            End If
                        Else
                            MessageBox.Show("װ�۴���" & strLoadCode & "��ʽ����ȷ�����ܱ��档", "����", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If
                End If
                If Not IsDBNull(Me.C1DBG.Columns("CODE_UNLOAD_PORT").CellValue(i)) Then
                    strUnLoadCode = Me.C1DBG.Columns("CODE_UNLOAD_PORT").CellText(i)
                    For k = 0 To (dvPort.Count - 1) / 2
                        If strUnLoadCode.Equals(dvPort(k)("CODE_PORT")) = True Or strUnLoadCode.Equals(dvPort(dvPort.Count - 1 - k)("CODE_PORT")) = True Then
                            Exit For
                        End If
                    Next
                    If k > (dvPort.Count - 1) / 2 Then
                        Me.C1DBG.Row = i
                        Me.C1DBG.SelectedRows.Clear()
                        Me.C1DBG.SelectedRows.Add(i)
                        If IsCode(strUnLoadCode) Then     '�ж��Ǵ������ʽ
                            If MessageBox.Show("ж�۴���" & strUnLoadCode & "�����ڣ�ȷ����ȷô��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                                Exit Sub
                            End If
                        Else
                            MessageBox.Show("ж�۴���" & strUnLoadCode & "��ʽ����ȷ�����ܱ��档", "����", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If
                End If
                If Not IsDBNull(Me.C1DBG.Columns("CODE_DELIVERY").CellValue(i)) Then
                    strDeliveryCode = Me.C1DBG.Columns("CODE_DELIVERY").CellText(i)
                    For k = 0 To (dvPort.Count - 1) / 2
                        If strDeliveryCode.Equals(dvPort(k)("CODE_PORT")) = True Or strDeliveryCode.Equals(dvPort(dvPort.Count - 1 - k)("CODE_PORT")) = True Then
                            Exit For
                        End If
                    Next
                    If k > (dvPort.Count - 1) / 2 Then
                        Me.C1DBG.Row = i
                        Me.C1DBG.SelectedRows.Clear()
                        Me.C1DBG.SelectedRows.Add(i)
                        If IsCode(strDeliveryCode) Then     '�ж��Ǵ������ʽ
                            If MessageBox.Show("�����ش���" & strDeliveryCode & "�����ڣ�ȷ����ȷô��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                                Exit Sub
                            End If
                        Else
                            MessageBox.Show("�����ش���" & strDeliveryCode & "��ʽ����ȷ�����ܱ��档", "����", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If
                End If

                strConState = Me.C1DBG.Columns("FULLOREMPTY").CellText(i)
                For k = 0 To dvState.Count - 1
                    If strConState.Equals(dvState(k)("EFL_Code")) = True Then
                        Exit For
                    End If
                Next
                If k >= dvState.Count Then
                    Me.C1DBG.Row = i
                    Me.C1DBG.SelectedRows.Clear()
                    Me.C1DBG.SelectedRows.Add(i)
                    MessageBox.Show("��������ȷ����״̬��", "��ʾ")
                    Exit Sub
                End If

                strConBay = Me.C1DBG.Columns("BAYNO").CellText(i)
                If strConBay Like "######" Then
                Else
                    Me.C1DBG.Row = i
                    Me.C1DBG.SelectedRows.Clear()
                    Me.C1DBG.SelectedRows.Add(i)
                    MessageBox.Show("��λ��" & strConBay & "���淶�����ɱ��档", "��ʾ")
                    Exit Sub
                End If

                strConNo = Me.C1DBG.Columns("CONTAINER_NO").CellText(i)
                iConCheck = CheckConNO(strConNo)    '��ż���
                If iConCheck = 2 Then   '��ȷ
                Else
                    Me.C1DBG.Row = i
                    Me.C1DBG.SelectedRows.Clear()
                    Me.C1DBG.SelectedRows.Add(i)
                    If iConCheck = 1 Then
                        sqlConBeing = "SELECT CONTAINER_NO, SIZE_CON, CONTAINER_TYPE FROM CON_CRITERION WHERE CONTAINER_NO = '" & strConNo & "' or CONTAINER_NO = '" & GetConOtherMode(strConNo) & "'"
                        dvConBeing = Filldata(sqlConBeing)
                        If dvConBeing.Count = 0 Then
                            If MessageBox.Show("��װ��� " & strConNo & " ��淶�в�������У�鲻��ȷ��ȷ����Ҫ����ô��", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                                Exit Sub
                            End If
                        End If
                    ElseIf iConCheck = 0 Then
                        MessageBox.Show("��װ���" & strConNo & "���淶�����ܱ��档", "��ʾ")
                        Exit Sub
                    End If
                End If

                For j = 0 To i - 1   '��ű�λ�ŵ��ظ����
                    If IsEqualConNo(strConNo, Me.C1DBG.Columns("CONTAINER_NO").CellText(j)) Then
                        Me.C1DBG.Row = i
                        Me.C1DBG.SelectedRows.Clear()
                        Me.C1DBG.SelectedRows.Add(i)
                        Me.C1DBG.SelectedRows.Add(j)
                        MessageBox.Show("��" & j + 1 & "�к͵�" & i + 1 & "�� ��װ����ظ���", "��ʾ")
                        Exit Sub
                    End If
                    If IsEqualBayNo(strConBay, Me.C1DBG.Columns("BAYNO").CellText(j)) Then
                        Me.C1DBG.Row = i
                        Me.C1DBG.SelectedRows.Clear()
                        Me.C1DBG.SelectedRows.Add(i)
                        Me.C1DBG.SelectedRows.Add(j)
                        MessageBox.Show("��" & j + 1 & "�к͵�" & i + 1 & "�� ��λ���ظ�(����ͨ��)��", "��ʾ")
                        Exit Sub
                    End If
                Next
            Next

            Dim sqlConExist, sqlBayExist As String
            If i >= dvContainer.Count Then  '������ ��λ���Ƿ������ݿ����ظ�
                For i = 0 To dvContainer.Count - 1
                    strConNo = Me.C1DBG.Columns("CONTAINER_NO").CellText(i)
                    sqlConExist = "SELECT CONTAINER_NO FROM CON_IMAGE WHERE ship_id = '" & Ship_ID & "' AND ( CONTAINER_NO = '" & strConNo & "' or CONTAINER_NO = '" & GetConOtherMode(strConNo) & "')"
                    If Filldata(sqlConExist).Count > 0 Then
                        Me.C1DBG.Row = i
                        Me.C1DBG.SelectedRows.Clear()
                        Me.C1DBG.SelectedRows.Add(i)
                        MessageBox.Show("��ǰ���θü�װ����Ѵ��ڣ������ظ���", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit For
                    End If
                    '��鱴λ��
                    strConBay = Me.C1DBG.Columns("BAYNO").CellText(i)
                    sqlBayExist = "SELECT CONTAINER_NO, BAYNO FROM CON_IMAGE WHERE ship_id = '" & Ship_ID & "' and TPMark='0' AND ( BAYNO = '" & strConBay & "' or BAYNO = '" & TongBayNoFont(strConBay) & "' or BAYNO = '" & TongBayNoLater(strConBay) & "')"
                    If Filldata(sqlBayExist).Count > 0 Then
                        Me.C1DBG.Row = i
                        Me.C1DBG.SelectedRows.Clear()
                        Me.C1DBG.SelectedRows.Add(i)
                        MessageBox.Show("��ǰ���θñ�λ��(����ͨ��)�ѱ�ʹ�ã������ظ���", "��ʾ")
                        Exit For
                    End If
                Next
            End If

            If i >= dvContainer.Count Then  '�������ȫ���ɹ����������ݿ��
                Dim sqlAddCon As String
                For i = 0 To dvContainer.Count - 1
                    If Me.C1DBG.Columns("AddFlag").CellText(i) = 1 Then     '����淶��û�е���
                        sqlAddCon = "INSERT INTO CON_CRITERION(CONTAINER_NO, SIZE_CON, CONTAINER_TYPE, CON_WEIGHT, USER_NAME) VALUES ('" & Me.C1DBG.Columns("CONTAINER_NO").CellText(i) & "', '" & Me.C1DBG.Columns("ConSize").CellText(i) & "', '" & Me.C1DBG.Columns("ConType").CellText(i) & "', '" & Me.C1DBG.Columns("ConWeight").CellText(i) & "', '" & G_User & "')"
                        ExecSql(sqlAddCon)
                    End If
                Next
                daContainer.Update(dsContainer)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub C1DBG_AfterColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles C1DBG.AfterColEdit
        Try
            Dim i As Integer
            If e.ColIndex = 7 Then
                Me.C1DBG.Columns("CONTAINER_NO").Text = Me.C1DBG.Columns("CONTAINER_NO").Text.Trim.ToUpper
                strConNo = Me.C1DBG.Columns("CONTAINER_NO").Text
                iConCheck = CheckConNO(strConNo)    '��ż���
                'If iConCheck = 1 Or iConCheck = 2 Then
                '    sqlBeing = "SELECT * FROM CON_CRITERION WHERE CONTAINER_NO = '" & strConNo & "' or CONTAINER_NO = '" & GetConOtherMode(strConNo) & "'"
                '    dvBeing = Filldata(sqlBeing)
                '    If dvBeing.Count >= 1 Then   '��淶�д���
                '        Me.C1DBG.Columns("SIZE_CON").Value = dvBeing.Item(0)("SIZE_CON")
                '        Me.C1DBG.Columns("CONTAINER_TYPE").Value = dvBeing.Item(0)("CONTAINER_TYPE")
                '        Me.C1DBG.Columns("CODE_KEEPER").Value = dvBeing.Item(0)("CODE_SHIP_OWNER")

                '        Me.C1DBG.Columns("KEEPER").Value = Me.C1DBG.Columns("CODE_KEEPER").Text
                '    Else
                '        If iConCheck = 2 Then   '��ż����޴����淶��û�С�
                '            Me.C1DBG.Columns("SIZE_CON").Value = Me.C1DBG.Columns("SIZE_CON").CellValue(Me.C1DBG.Row - 1)
                '            Me.C1DBG.Columns("CONTAINER_TYPE").Value = Me.C1DBG.Columns("CONTAINER_TYPE").CellValue(Me.C1DBG.Row - 1)
                '        Else
                '            Me.C1DBG.SelectedRows.Clear()
                '            Me.C1DBG.SelectedRows.Add(Me.C1DBG.Row)
                '            If MessageBox.Show("��װ��� " & strConNo & " У�鲻��ȷ�Ҳ���������淶�У�ȷ��������", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                '                Me.C1DBG.Columns("SIZE_CON").Value = Me.C1DBG.Columns("SIZE_CON").CellValue(Me.C1DBG.Row - 1)
                '                Me.C1DBG.Columns("CONTAINER_TYPE").Value = Me.C1DBG.Columns("CONTAINER_TYPE").CellValue(Me.C1DBG.Row - 1)
                '            End If
                '        End If
                '    End If
                'ElseIf iConCheck = 0 Then
                '    Me.C1DBG.SelectedRows.Clear()
                '    Me.C1DBG.SelectedRows.Add(Me.C1DBG.Row)
                '    MessageBox.Show("��װ��Ų��淶��", "��ʾ")
                'End If
                sqlConBeing = "SELECT CONTAINER_NO, SIZE_CON, CONTAINER_TYPE, CON_WEIGHT FROM CON_CRITERION WHERE CONTAINER_NO = '" & strConNo & "' or CONTAINER_NO = '" & GetConOtherMode(strConNo) & "'"

                If iConCheck = 2 Then
                    '��ȷ
                    dvConBeing = Filldata(sqlConBeing)
                    If dvConBeing.Count > 0 Then
                        Me.C1DBG.Columns("ConSize").Value = dvConBeing(0)("SIZE_CON")
                        Me.C1DBG.Columns("ConType").Value = dvConBeing(0)("CONTAINER_TYPE")
                        Me.C1DBG.Columns("ConWeight").Value = dvConBeing(0)("CON_WEIGHT")
                        Me.C1DBG.Columns("AddFlag").Text = 0    '����
                    Else
                        MessageBox.Show("�ü�װ��Ų����ڣ��������", "��ʾ")
                        Me.C1DBG.Columns("ConSize").Value = Me.C1DBG.Columns("ConSize").CellValue(Me.C1DBG.Row - 1)
                        Me.C1DBG.Columns("ConType").Value = Me.C1DBG.Columns("ConSize").CellValue(Me.C1DBG.Row - 1)
                        Me.C1DBG.Columns("ConWeight").Value = Me.C1DBG.Columns("ConWeight").CellValue(Me.C1DBG.Row - 1)
                        Me.C1DBG.Columns("AddFlag").Text = 1    '��Ǹü�¼Ҫ��ӵ���淶��
                    End If
                ElseIf iConCheck = 1 Then
                    dvConBeing = Filldata(sqlConBeing)
                    If dvConBeing.Count > 0 Then
                        Me.C1DBG.Columns("ConSize").Value = dvConBeing(0)("SIZE_CON")
                        Me.C1DBG.Columns("ConType").Value = dvConBeing(0)("CONTAINER_TYPE")
                        Me.C1DBG.Columns("ConWeight").Value = dvConBeing(0)("CON_WEIGHT")
                        Me.C1DBG.Columns("AddFlag").Text = 0    '����
                    Else
                        MessageBox.Show("��װ��� " & strConNo & " У�鲻��ȷ����淶�в����ڣ��������", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Me.C1DBG.Columns("ConSize").Value = Me.C1DBG.Columns("ConSize").CellValue(Me.C1DBG.Row - 1)
                        Me.C1DBG.Columns("ConType").Value = Me.C1DBG.Columns("ConType").CellValue(Me.C1DBG.Row - 1)
                        Me.C1DBG.Columns("ConWeight").Value = Me.C1DBG.Columns("ConWeight").CellValue(Me.C1DBG.Row - 1)
                        Me.C1DBG.Columns("AddFlag").Text = 1   '��Ǹü�¼Ҫ��ӵ���淶��
                    End If
                ElseIf iConCheck = 0 Then
                    MessageBox.Show("��װ��Ų��淶��", "��ʾ")
                End If

            ElseIf e.ColIndex = 8 Then
                Me.C1DBG.Columns("BAYNO").Text = Me.C1DBG.Columns("BAYNO").Text.Trim
                strConBay = Me.C1DBG.Columns("BAYNO").Text
                If strConBay Like "######" Then
                Else
                    MessageBox.Show("��λ�Ų��淶��", "��ʾ")
                End If
            ElseIf e.ColIndex = 9 Then
                Me.C1DBG.Columns("BLNO").Text = Me.C1DBG.Columns("BLNO").Text.Trim.ToUpper
            ElseIf e.ColIndex = 10 Then
                Me.C1DBG.Columns("FULLOREMPTY").Text = Me.C1DBG.Columns("FULLOREMPTY").Text.Trim.ToUpper
                strConState = Me.C1DBG.Columns("FULLOREMPTY").Text
                For i = 0 To dvState.Count - 1
                    If strConState.Equals(dvState(i)("EFL_Code")) = True Then
                        Exit For
                    End If
                Next
                If i < dvState.Count Then
                    lbState.Text = "��״̬��" & dvState(i)("EFL_Name")
                Else
                    lbState.Text = "��״̬��"
                    MessageBox.Show("��״̬����ȷ��", "��ʾ")
                End If
            ElseIf e.ColIndex = 11 Then
                Me.C1DBG.Columns("CODE_LOAD_PORT").Text = Me.C1DBG.Columns("CODE_LOAD_PORT").Text.Trim.ToUpper
                strLoadCode = Me.C1DBG.Columns("CODE_LOAD_PORT").Text
                For i = 0 To dvPort.Count - 1
                    If strLoadCode.Equals(dvPort(i)("CODE_PORT")) = True Then
                        Exit For
                    End If
                Next
                If i < dvPort.Count Then
                    Me.C1DBG.Columns("Load_Port").Value = dvPort(i)("PORT_CHA")
                    lbLoad.Text = "װ���ۣ�" & Me.C1DBG.Columns("Load_Port").Text
                Else
                    lbLoad.Text = "װ���ۣ�"
                    MessageBox.Show("װ���۴��벻���ڣ�", "��ʾ")
                End If
            ElseIf e.ColIndex = 12 Then
                Me.C1DBG.Columns("CODE_UNLOAD_PORT").Text = Me.C1DBG.Columns("CODE_UNLOAD_PORT").Text.Trim.ToUpper
                strUnLoadCode = Me.C1DBG.Columns("CODE_UNLOAD_PORT").Text
                For i = 0 To dvPort.Count - 1
                    If strUnLoadCode.Equals(dvPort(i)("CODE_PORT")) = True Then
                        Exit For
                    End If
                Next
                If i < dvPort.Count Then
                    Me.C1DBG.Columns("Unload_Port").Value = dvPort(i)("PORT_CHA")
                    lbUnload.Text = "ж���ۣ�" & Me.C1DBG.Columns("Unload_Port").Text
                Else
                    lbUnload.Text = "ж���ۣ�"
                    MessageBox.Show("ж���۴��벻���ڣ�", "��ʾ")
                End If
            ElseIf e.ColIndex = 13 Then
                Me.C1DBG.Columns("CODE_DELIVERY").Text = Me.C1DBG.Columns("CODE_DELIVERY").Text.Trim.ToUpper
                strDeliveryCode = Me.C1DBG.Columns("CODE_DELIVERY").Text
                For i = 0 To dvPort.Count - 1
                    If strDeliveryCode.Equals(dvPort(i)("CODE_PORT")) = True Then
                        Exit For
                    End If
                Next
                If i < dvPort.Count Then
                    Me.C1DBG.Columns("DELIVERY").Value = dvPort(i)("PORT_CHA")
                    lbDelivery.Text = "�����أ�" & Me.C1DBG.Columns("DELIVERY").Text
                Else
                    lbDelivery.Text = "�����أ�"
                    MessageBox.Show("�����ش��벻���ڣ�", "��ʾ")
                End If
            ElseIf e.ColIndex = 15 Then
                Me.C1DBG.Columns("ConType").Text = Me.C1DBG.Columns("ConType").Text.Trim.ToUpper
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub C1DBG_AfterDelete(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.AfterDelete
        Me.C1DBG.Columns.Item("CONTAINER_NO").FooterText = "�¼�" & dsContainer.Tables(0).Rows.Count & "��"
    End Sub

    Private Sub C1DBG_AfterInsert(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1DBG.AfterInsert
        Me.C1DBG.Columns.Item("CONTAINER_NO").FooterText = "�¼�" & dsContainer.Tables(0).Rows.Count & "��"
    End Sub

    Private Sub C1DBG_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1DBG.KeyDown
        If e.KeyCode = Keys.Enter And Me.C1DBG.Col = 17 Then
            Me.C1DBG.Row += 1
            Me.C1DBG.Col = 8
            'SendKeys.Send("{LEFT}")

            Dim ConTemp As String
            ConTemp = Me.C1DBG.Columns("CONTAINER_NO").CellText(Me.C1DBG.Row - 1)
            If ConTemp.Length = 11 Or ConTemp.Length = 12 Then
                Me.C1DBG.Columns("CONTAINER_NO").Text = ConTemp.Trim.Substring(0, 4).ToUpper
                Me.C1DBG.EditActive = True
                SendKeys.Send("{RIGHT}")   'Load_Port, Unload_Port, DELIVERY
                Me.C1DBG.Columns("BLNO").Text = Me.C1DBG.Columns("BLNO").CellText(Me.C1DBG.Row - 1)
                Me.C1DBG.Columns("FULLOREMPTY").Text = Me.C1DBG.Columns("FULLOREMPTY").CellText(Me.C1DBG.Row - 1)
                Me.C1DBG.Columns("CODE_LOAD_PORT").Text = Me.C1DBG.Columns("CODE_LOAD_PORT").CellText(Me.C1DBG.Row - 1)
                Me.C1DBG.Columns("CODE_UNLOAD_PORT").Text = Me.C1DBG.Columns("CODE_UNLOAD_PORT").CellText(Me.C1DBG.Row - 1)
                Me.C1DBG.Columns("CODE_DELIVERY").Text = Me.C1DBG.Columns("CODE_DELIVERY").CellText(Me.C1DBG.Row - 1)
                Me.C1DBG.Columns("Load_Port").Text = Me.C1DBG.Columns("Load_Port").CellText(Me.C1DBG.Row - 1)
                Me.C1DBG.Columns("Unload_Port").Text = Me.C1DBG.Columns("Unload_Port").CellText(Me.C1DBG.Row - 1)
                Me.C1DBG.Columns("DELIVERY").Text = Me.C1DBG.Columns("DELIVERY").CellText(Me.C1DBG.Row - 1)
            End If
        End If
    End Sub
End Class
