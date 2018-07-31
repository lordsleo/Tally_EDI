Imports TALLY.DBControl
Public Class FrmSealOut_Add
    Inherits System.Windows.Forms.Form

    Dim ds As New DataSet()
    Dim sqlda As New SqlClient.SqlDataAdapter
    Dim dvDept As New DataView

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
    Friend WithEvents btQuit As System.Windows.Forms.Button
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSealNOEnd As System.Windows.Forms.TextBox
    Friend WithEvents txtSealNOBegin As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents cbLeadDept As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpTimeOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbnSubOut As System.Windows.Forms.RadioButton
    Friend WithEvents lbOutDesc As System.Windows.Forms.Label
    Friend WithEvents rbnSubtenancy As System.Windows.Forms.RadioButton
    Friend WithEvents rbnOneOut As System.Windows.Forms.RadioButton
    Friend WithEvents ccbPerson As C1.Win.C1List.C1Combo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmSealOut_Add))
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSealNOEnd = New System.Windows.Forms.TextBox
        Me.txtSealNOBegin = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.cbLeadDept = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpTimeOut = New System.Windows.Forms.DateTimePicker
        Me.lbOutDesc = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbnOneOut = New System.Windows.Forms.RadioButton
        Me.rbnSubtenancy = New System.Windows.Forms.RadioButton
        Me.rbnSubOut = New System.Windows.Forms.RadioButton
        Me.ccbPerson = New C1.Win.C1List.C1Combo
        Me.GroupBox1.SuspendLayout()
        CType(Me.ccbPerson, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(160, 228)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 7
        Me.btQuit.Text = "取消"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(88, 228)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 6
        Me.btSave.Text = "确认"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(16, 228)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(65, 24)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "清空"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 165
        Me.Label5.Text = "领用人"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSealNOEnd
        '
        Me.txtSealNOEnd.Location = New System.Drawing.Point(96, 104)
        Me.txtSealNOEnd.MaxLength = 20
        Me.txtSealNOEnd.Name = "txtSealNOEnd"
        Me.txtSealNOEnd.Size = New System.Drawing.Size(130, 21)
        Me.txtSealNOEnd.TabIndex = 1
        Me.txtSealNOEnd.Text = ""
        '
        'txtSealNOBegin
        '
        Me.txtSealNOBegin.Location = New System.Drawing.Point(96, 76)
        Me.txtSealNOBegin.MaxLength = 20
        Me.txtSealNOBegin.Name = "txtSealNOBegin"
        Me.txtSealNOBegin.Size = New System.Drawing.Size(130, 21)
        Me.txtSealNOBegin.TabIndex = 0
        Me.txtSealNOBegin.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 161
        Me.Label4.Text = "领用部门"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 160
        Me.Label2.Text = "铅封止号"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 159
        Me.Label1.Text = "铅封起号"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(-24, -16)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(28, 21)
        Me.txtID.TabIndex = 158
        Me.txtID.Text = ""
        Me.txtID.Visible = False
        '
        'cbLeadDept
        '
        Me.cbLeadDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLeadDept.Location = New System.Drawing.Point(96, 164)
        Me.cbLeadDept.MaxDropDownItems = 20
        Me.cbLeadDept.Name = "cbLeadDept"
        Me.cbLeadDept.Size = New System.Drawing.Size(130, 20)
        Me.cbLeadDept.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 183
        Me.Label3.Text = "领用日期"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTimeOut
        '
        Me.dtpTimeOut.Checked = False
        Me.dtpTimeOut.Location = New System.Drawing.Point(96, 132)
        Me.dtpTimeOut.Name = "dtpTimeOut"
        Me.dtpTimeOut.Size = New System.Drawing.Size(130, 21)
        Me.dtpTimeOut.TabIndex = 2
        '
        'lbOutDesc
        '
        Me.lbOutDesc.AutoSize = True
        Me.lbOutDesc.BackColor = System.Drawing.Color.Khaki
        Me.lbOutDesc.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbOutDesc.Location = New System.Drawing.Point(168, 4)
        Me.lbOutDesc.Name = "lbOutDesc"
        Me.lbOutDesc.Size = New System.Drawing.Size(63, 19)
        Me.lbOutDesc.TabIndex = 184
        Me.lbOutDesc.Text = "一级出库"
        Me.lbOutDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbnOneOut)
        Me.GroupBox1.Controls.Add(Me.rbnSubtenancy)
        Me.GroupBox1.Controls.Add(Me.rbnSubOut)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(236, 40)
        Me.GroupBox1.TabIndex = 185
        Me.GroupBox1.TabStop = False
        '
        'rbnOneOut
        '
        Me.rbnOneOut.Checked = True
        Me.rbnOneOut.Location = New System.Drawing.Point(8, 16)
        Me.rbnOneOut.Name = "rbnOneOut"
        Me.rbnOneOut.Size = New System.Drawing.Size(72, 20)
        Me.rbnOneOut.TabIndex = 2
        Me.rbnOneOut.TabStop = True
        Me.rbnOneOut.Text = "一级出库"
        '
        'rbnSubtenancy
        '
        Me.rbnSubtenancy.Location = New System.Drawing.Point(160, 16)
        Me.rbnSubtenancy.Name = "rbnSubtenancy"
        Me.rbnSubtenancy.Size = New System.Drawing.Size(72, 20)
        Me.rbnSubtenancy.TabIndex = 1
        Me.rbnSubtenancy.Text = "部门转借"
        '
        'rbnSubOut
        '
        Me.rbnSubOut.Location = New System.Drawing.Point(84, 16)
        Me.rbnSubOut.Name = "rbnSubOut"
        Me.rbnSubOut.Size = New System.Drawing.Size(72, 20)
        Me.rbnSubOut.TabIndex = 0
        Me.rbnSubOut.Text = "二级发放"
        '
        'ccbPerson
        '
        Me.ccbPerson.AddItemSeparator = Microsoft.VisualBasic.ChrW(59)
        Me.ccbPerson.Caption = ""
        Me.ccbPerson.CaptionHeight = 17
        Me.ccbPerson.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ccbPerson.ColumnCaptionHeight = 18
        Me.ccbPerson.ColumnFooterHeight = 18
        Me.ccbPerson.ContentHeight = 16
        Me.ccbPerson.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.ccbPerson.EditorBackColor = System.Drawing.SystemColors.Window
        Me.ccbPerson.EditorFont = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ccbPerson.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.ccbPerson.EditorHeight = 16
        Me.ccbPerson.Images.Add(CType(resources.GetObject("resource"), System.Drawing.Image))
        Me.ccbPerson.ItemHeight = 15
        Me.ccbPerson.Location = New System.Drawing.Point(96, 192)
        Me.ccbPerson.MatchEntryTimeout = CType(2000, Long)
        Me.ccbPerson.MaxDropDownItems = CType(20, Short)
        Me.ccbPerson.MaxLength = 32767
        Me.ccbPerson.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.ccbPerson.Name = "ccbPerson"
        Me.ccbPerson.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.ccbPerson.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.ccbPerson.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.ccbPerson.Size = New System.Drawing.Size(130, 22)
        Me.ccbPerson.TabIndex = 186
        Me.ccbPerson.PropBag = "<?xml version=""1.0""?><Blob><Styles type=""C1.Win.C1List.Design.ContextWrapper""><Da" & _
        "ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" & _
        "}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" & _
        "lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" & _
        "ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{}HighlightRow{" & _
        "ForeColor:HighlightText;BackColor:Highlight;}Style9{AlignHorz:Near;}OddRow{}Reco" & _
        "rdSelector{AlignImage:Center;}Heading{Wrap:True;AlignVert:Center;Border:Raised,," & _
        "1, 1, 1, 1;ForeColor:ControlText;BackColor:Control;}Style8{}Style10{}Style11{}St" & _
        "yle1{}</Data></Styles><Splits><C1.Win.C1List.ListBoxView AllowColSelect=""False"" " & _
        "Name=""Split[0,0]"" CaptionHeight=""18"" ColumnCaptionHeight=""18"" ColumnFooterHeight" & _
        "=""18"" VerticalScrollGroup=""1"" HorizontalScrollGroup=""1""><ClientRect>0, 0, 116, 1" & _
        "56</ClientRect><Height>156</Height><VScrollBar><Width>16</Width></VScrollBar><HS" & _
        "crollBar><Height>16</Height></HScrollBar><CaptionStyle parent=""Style2"" me=""Style" & _
        "9"" /><EvenRowStyle parent=""EvenRow"" me=""Style7"" /><FooterStyle parent=""Footer"" m" & _
        "e=""Style3"" /><GroupStyle parent=""Group"" me=""Style11"" /><HeadingStyle parent=""Hea" & _
        "ding"" me=""Style2"" /><HighLightRowStyle parent=""HighlightRow"" me=""Style6"" /><Inac" & _
        "tiveStyle parent=""Inactive"" me=""Style4"" /><OddRowStyle parent=""OddRow"" me=""Style" & _
        "8"" /><RecordSelectorStyle parent=""RecordSelector"" me=""Style10"" /><SelectedStyle " & _
        "parent=""Selected"" me=""Style5"" /><Style parent=""Normal"" me=""Style1"" /></C1.Win.C1" & _
        "List.ListBoxView></Splits><NamedStyles><Style parent="""" me=""Normal"" /><Style par" & _
        "ent=""Normal"" me=""Heading"" /><Style parent=""Heading"" me=""Footer"" /><Style parent=" & _
        """Heading"" me=""Caption"" /><Style parent=""Heading"" me=""Inactive"" /><Style parent=""" & _
        "Normal"" me=""Selected"" /><Style parent=""Normal"" me=""HighlightRow"" /><Style parent" & _
        "=""Normal"" me=""EvenRow"" /><Style parent=""Normal"" me=""OddRow"" /><Style parent=""Hea" & _
        "ding"" me=""RecordSelector"" /><Style parent=""Caption"" me=""Group"" /></NamedStyles><" & _
        "vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>None</Layout><Default" & _
        "RecSelWidth>16</DefaultRecSelWidth></Blob>"
        '
        'FrmSealOut_Add
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(250, 259)
        Me.Controls.Add(Me.ccbPerson)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbOutDesc)
        Me.Controls.Add(Me.dtpTimeOut)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbLeadDept)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtSealNOEnd)
        Me.Controls.Add(Me.txtSealNOBegin)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSealOut_Add"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "铅封出库发放转借记录 增加"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ccbPerson, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim sqlPerson As String
    Dim dvPerson As DataView

    Private Sub FrmSealOut_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo Err
        Dim dw As New DataView()
        Dim sqlstr, sqlDept As String
        sqlDept = "select dept_code,dept_name from department where Dept_Code like '26.1[12].1[1-5]'"  'dept_code = '" & G_Dept_Oper & "' or
        dvDept = Filldata(sqlDept)
        cbLeadDept.DataSource = dvDept
        cbLeadDept.DisplayMember = "dept_name"
        cbLeadDept.ValueMember = "dept_code"
        sqlPerson = "select Name,Work_No,Tally_Short,DEPT_CODE from Tally_Clerk where Dept_Code like '2[69].1[12].1[1-5]' order by Name,Dept_Code"
        dvPerson = Filldata(sqlPerson)
        Me.ccbPerson.DataSource = dvPerson
        Me.ccbPerson.ValueMember = "Name"
        Me.ccbPerson.DisplayMember = "Name"
        Me.ccbPerson.ColumnHeaders = False
        Me.ccbPerson.Splits(0).DisplayColumns("Work_No").Visible = False
        Me.ccbPerson.Splits(0).DisplayColumns("DEPT_CODE").Visible = False
        Me.ccbPerson.Splits(0).DisplayColumns("Name").AutoSize()
        Me.ccbPerson.Splits(0).DisplayColumns("Tally_Short").AutoSize()
        'Me.ccbPerson.DropDownWidth = Me.ccbPerson.Splits(0).DisplayColumns("Name").Width + Me.ccbPerson.Splits(0).DisplayColumns("Tally_Short").Width + 20
        Me.ccbPerson.AutoDropDown = True
        'Me.ccbPerson.AutoSelect = True
        'Me.StartPosition = FormStartPosition.CenterScreen
        sqlstr = "select * from SEAL_OUT where SEAL_OUT_ID=" & ID & ""
        dw = Updatedata(sqlda, sqlstr, ds)

        If dw.Count > 0 Then
            txtID.Text = ID
            txtSealNOBegin.Text = ds.Tables(0).Rows(0).Item("SEALNO_BEGIN")
            txtSealNOEnd.Text = ds.Tables(0).Rows(0).Item("SEALNO_END")
            dtpTimeOut.Text = ds.Tables(0).Rows(0).Item("TIME_OUT")
            cbLeadDept.SelectedValue = ds.Tables(0).Rows(0).Item("LEAD_DEPARTMENT")
            Me.ccbPerson.Text = ds.Tables(0).Rows(0).Item("LEAD_PERSON")
        End If
        If G_DeptCode = "26" OrElse G_DeptCode = G_Dept_Oper Then
            Me.rbnOneOut.Checked = True
            Me.rbnSubOut.Enabled = False
            Me.rbnSubtenancy.Enabled = False
            Me.lbOutDesc.Text = "一级出库"
            'dvDept.RowFilter = "dept_code<>'" & G_Dept_Oper & "'"
        ElseIf G_DeptCode Like "26.1[12].1[1-5]" Then   '各部门二级发放转借
            Me.rbnSubOut.Checked = True
            Me.rbnOneOut.Enabled = False
        Else    '其他部门不可操作
            Me.btSave.Enabled = False
        End If

        txtSealNOBegin.Focus()
        Exit Sub

Err:
        Resume Next
    End Sub

    Private Function VerifySealNOInput(ByVal strSealNOBegin As String, ByVal strSealNOEnd As String) As Boolean
        '铅封号格式验证
        Dim i, j, iLength1, iLength2 As Short
        'Dim strSealNO, strNOBegin, strNOEnd As String
        Dim c1, c2 As Char
        Dim flag As Boolean = False
        iLength1 = Len(strSealNOBegin)
        iLength2 = Len(strSealNOEnd)
        
        If iLength1 = iLength2 And iLength1 > 0 Then
            For i = iLength1 To 1 Step -1
                c1 = Mid(strSealNOBegin, i, 1)
                c2 = Mid(strSealNOEnd, i, 1)
                If (c1 >= "0" And c1 <= "9") And (c2 >= "0" And c2 <= "9") Then

                Else
                    If (c1 >= "A" And c1 <= "Z") And (c2 >= "A" And c2 <= "Z") Then
                        Exit For
                    Else
                        MessageBox.Show("铅封号不合法！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        Return False
                        Exit Function
                    End If
                End If
            Next

            If i >= 0 And i < iLength1 Then
                If Mid(strSealNOBegin, i + 1) <= Mid(strSealNOEnd, i + 1) Then
                    '后部通过验证
                Else
                    MessageBox.Show("铅封起号必须位于止号之前！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Return False
                    Exit Function
                End If
                'ElseIf i < 1 Then
                '    MessageBox.Show("铅封号不能全为数字！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                '    Return False
                '    Exit Function
            ElseIf i = iLength1 Then
                MessageBox.Show("铅封号后部不能为字母！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Return False
                Exit Function
            End If

            For j = 1 To i
                c1 = Mid(strSealNOBegin, j, 1)
                c2 = Mid(strSealNOEnd, j, 1)
                If (c1 >= "A" And c1 <= "Z") And (c2 >= "A" And c2 <= "Z") Then

                Else
                    If (c1 >= "0" And c1 <= "9") And (c2 >= "0" And c2 <= "9") Then

                    Else
                        MessageBox.Show("铅封号不合法！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        Return False
                        Exit Function
                    End If
                End If
            Next

            If StrComp(Mid(strSealNOBegin, 1, i), Mid(strSealNOEnd, 1, i), CompareMethod.Text) = 0 Then
                flag = True             '全部通过验证
                Return flag
            Else
                MessageBox.Show("铅封起止号前部不一致！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Return False
                Exit Function
            End If
        Else
            If iLength1 <> iLength2 Then
                MessageBox.Show("铅封起止号长度不一致！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
            If iLength1 <= 0 Then
                MessageBox.Show("铅封起号不能为空！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
            Return False
            Exit Function
        End If

    End Function

    Private Function GetSealSum(ByVal strBegin As String, ByVal strEnd As String) As Integer
        '获得铅封段中铅封个数 确定长度相等，格式一致
        If strBegin <> strEnd Then
            Dim i As Integer
            For i = 0 To strBegin.Length - 1
                If String.Compare(strBegin.Substring(i, 1), strEnd.Substring(i, 1)) <> 0 Then
                    Exit For
                End If
            Next
            Return System.Math.Abs(Convert.ToInt32(strEnd.Substring(i)) - Convert.ToInt32(strBegin.Substring(i))) + 1
        Else
            Return 1
        End If
    End Function

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim iSealSum As Integer
        Dim iFlag As Short = 2
        Dim strSealNOBegin, strSealNOEnd, strLeadDept, strLeadPerson As String
        strLeadDept = ""
        strSealNOBegin = UCase(Trim(txtSealNOBegin.Text))
        strSealNOEnd = UCase(Trim(txtSealNOEnd.Text))
        If strSealNOEnd = "" Then
            strSealNOEnd = strSealNOBegin
        End If
        'strLeadDept = cbLeadDept.SelectedText
        'strLeadPerson = Trim(txtLeadPerson.Text)
        strLeadPerson = Me.ccbPerson.Text
        If Me.ccbPerson.SelectedIndex < 0 Then
            Me.ccbPerson.Focus()
            If MessageBox.Show("领用人不是该部门理货员，继续？", "警示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) <> DialogResult.OK Then
                Exit Sub
            End If
        End If
        Try
            'Dim OutDate As Date = CDate(Trim(txtSealTimeOut.Text))
            If VerifySealNOInput(strSealNOBegin, strSealNOEnd) Then     '铅封起止号格式通过验证

                If Len(strLeadPerson) > 0 Then

                    '变更铅封状态记录
                    'iFlag = UpdateSealRecord("spEditSealRecord", strSealNOBegin, strSealNOEnd, cbLeadDept.SelectedValue, strLeadPerson)
                    '
                    '要检查不能有缺失
                    iSealSum = GetSealSum(strSealNOBegin, strSealNOEnd)

                    Dim sqlSealCheck As String
                    Dim dvSealCheck As DataView
                    sqlSealCheck = "select SealNo,SEAL_STATE,Subtenancy_Mark from Seal_Record where SealNo>='" & strSealNOBegin & "' and SealNo<='" & strSealNOEnd & "' and Len(SealNo)=" & strSealNOBegin.Length
                    dvSealCheck = Filldata(sqlSealCheck)
                    If dvSealCheck.Count = iSealSum Then
                        '进行铅封出库记录
                        Dim strError As String = ""
                        Dim row As DataRow
                        row = ds.Tables(0).NewRow()
                        If Me.rbnOneOut.Checked Then
                            dvSealCheck.RowFilter = "SEAL_STATE='0'"
                            If dvSealCheck.Count < iSealSum Then
                                iFlag = 0
                                strError = "部分铅封已经出库，请检查"
                            End If
                            row("Out_Level") = "1"
                            row("Subtenancy_Mark") = "0"

                        ElseIf Me.rbnSubOut.Checked Then
                            dvSealCheck.RowFilter = "SEAL_STATE='1'"
                            If dvSealCheck.Count < iSealSum Then
                                iFlag = 0
                                strError = "部分铅封尚未出库或者已经发放，请检查"
                            End If
                            row("Out_Level") = "2"
                            row("Subtenancy_Mark") = "0"
                        Else
                            dvSealCheck.RowFilter = "SEAL_STATE='1' and Subtenancy_Mark='0'"
                            If dvSealCheck.Count < iSealSum Then
                                iFlag = 0
                                strError = "转借铅封必须是出库状态且不可二次转借，请确定"
                            End If
                            row("Out_Level") = "1"
                            row("Subtenancy_Mark") = "1"
                        End If
                        If iFlag <> 0 Then
                            '更新铅封记录表 用触发器

                            row("SEALNO_BEGIN") = strSealNOBegin
                            row("SEALNO_END") = strSealNOEnd
                            row("LEAD_DEPARTMENT") = cbLeadDept.SelectedValue
                            row("LEAD_PERSON") = strLeadPerson
                            row("TIME_OUT") = dtpTimeOut.Value
                            row("USER_NAME") = G_User
                            row("Out_Dept") = G_DeptCode
                            ds.Tables(0).Rows.Add(row)
                            sqlda.Update(ds)
                            Me.Close()
                        Else
                            Me.txtSealNOBegin.Focus()
                            MessageBox.Show(strError, "警示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        iFlag = 1
                        Me.txtSealNOBegin.Focus()
                        MessageBox.Show("存在断号情况或者有些铅封不存在，请检查。", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error, _
                                                    MessageBoxDefaultButton.Button1)
                    End If
                Else
                    MsgBox("领用人不能为空!", MsgBoxStyle.Critical, "提示")
                End If
            End If
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function UpdateSealRecord(ByVal storeproc As String, ByVal strSealNOBegin As String, ByVal strSealNOEnd As String, ByVal strDept As String, ByVal strPerson As String) As Short
        Dim sqlcmd As New SqlClient.SqlCommand(storeproc, sqlconn)
        Dim prmSealNOBegin, prmSealNOEnd, prmNewState, prmDeptCode, prmPerson, prmUserName, prmRowCount, prmFlag As SqlClient.SqlParameter
        Dim iFlag As Short  'iFlag标记此段铅封是否顺利出库

        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.CommandTimeout = 300

        prmSealNOBegin = sqlcmd.Parameters.Add("@strSealNOBegin", SqlDbType.VarChar, 20)
        prmSealNOEnd = sqlcmd.Parameters.Add("@strSealNOEnd", SqlDbType.VarChar, 20)
        prmNewState = sqlcmd.Parameters.Add("@NewState", SqlDbType.VarChar, 2)
        prmDeptCode = sqlcmd.Parameters.Add("@strDept", SqlDbType.VarChar, 12)
        prmPerson = sqlcmd.Parameters.Add("@strUserPerson", SqlDbType.VarChar, 10)
        prmUserName = sqlcmd.Parameters.Add("@strUserName", SqlDbType.VarChar, 10)
        prmRowCount = sqlcmd.Parameters.Add("@rowcount", SqlDbType.Int)
        prmFlag = sqlcmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int)

        prmSealNOBegin.Direction = ParameterDirection.Input
        prmSealNOEnd.Direction = ParameterDirection.Input
        prmNewState.Direction = ParameterDirection.Input
        prmDeptCode.Direction = ParameterDirection.Input
        prmPerson.Direction = ParameterDirection.Input
        prmUserName.Direction = ParameterDirection.Input
        prmRowCount.Direction = ParameterDirection.Output
        prmFlag.Direction = ParameterDirection.ReturnValue

        prmSealNOBegin.Value = strSealNOBegin
        prmSealNOEnd.Value = strSealNOEnd
        prmNewState.Value = "1"     'NewState="1"表示出库
        prmDeptCode.Value = strDept
        prmPerson.Value = strPerson
        prmUserName.Value = G_User

        sqlconn.Open()
        sqlcmd.ExecuteNonQuery()
        'iRowCount = CType(prmRowCount.Value, Short)
        iFlag = CType(prmFlag.Value, Short)
        sqlconn.Close()
        'MessageBox.Show("iRowCount=" & iRowCount & " iFlag=" & iFlag, "test")
        Return iFlag
    End Function

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtSealNOBegin.Text = ""
        txtSealNOEnd.Text = ""
        Me.ccbPerson.Text = ""
        Me.dtpTimeOut.Value = Now
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub txtSealNOBegin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSealNOBegin.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtSealNOEnd.Focus()
        End If
    End Sub

    Private Sub txtSealNOEnd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSealNOEnd.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.dtpTimeOut.Focus()
        End If
    End Sub

    Private Sub dtpTimeOut_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtpTimeOut.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cbLeadDept.Focus()
        End If
    End Sub

    Private Sub cbLeadDept_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbLeadDept.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.ccbPerson.Focus()
        End If
    End Sub

    Private Sub btSave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btSave.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Me.btSave_Click(sender, e)
        End If
    End Sub

    Private Sub rbnSubOut_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnSubOut.CheckedChanged
        If Me.rbnSubOut.Checked Then
            Me.lbOutDesc.Text = "二级发放"
            Me.cbLeadDept.Enabled = False
            dvDept.RowFilter = ""
            Me.cbLeadDept.SelectedValue = G_DeptCode
        End If
    End Sub

    Private Sub rbnOneOut_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnOneOut.CheckedChanged

    End Sub

    Private Sub rbnSubtenancy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbnSubtenancy.CheckedChanged
        If Me.rbnSubtenancy.Checked Then
            Me.lbOutDesc.Text = "部门转借"
            Me.cbLeadDept.Enabled = True
            dvDept.RowFilter = "dept_code <> '" & G_DeptCode & "'"
        End If
    End Sub

    Private Sub cbLeadDept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbLeadDept.SelectedIndexChanged
        If Me.cbLeadDept.ValueMember <> "" AndAlso Me.cbLeadDept.SelectedIndex >= 0 AndAlso Not dvPerson Is Nothing Then
            Dim strOuterDeptCode As String
            strOuterDeptCode = "29" & Convert.ToString(Me.cbLeadDept.SelectedValue).Substring(2)
            Dim strNewFilter As String
            strNewFilter = "Dept_Code ='" & Me.cbLeadDept.SelectedValue & "' or Dept_Code ='" & strOuterDeptCode & "'"
            If dvPerson.RowFilter <> strNewFilter Then
                dvPerson.RowFilter = strNewFilter
            End If
        End If
    End Sub

    Private Sub ccbPerson_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles ccbPerson.Enter
        cbLeadDept_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub ccbPerson_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ccbPerson.Leave
        If Me.ccbPerson.SelectedIndex < 0 Then
            If Me.ccbPerson.Text <> Me.ccbPerson.Text.Trim.ToUpper Then
                Me.ccbPerson.Text = Me.ccbPerson.Text.Trim.ToUpper
                If Me.ccbPerson.SelectedIndex < 0 Then  '按助记码匹配
                    Dim i As Integer
                    i = Me.ccbPerson.FindString(Me.ccbPerson.Text, 0, "Tally_Short")
                    Me.ccbPerson.SelectedIndex = i
                End If
            End If
        End If
    End Sub

    Private Sub ccbPerson_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ccbPerson.KeyDown

        If e.KeyCode = Keys.Enter Then
            If Me.ccbPerson.SelectedIndex >= 0 Then
                Me.btSave.Focus()
                Me.btSave_Click(sender, e)
            Else
                Me.ccbPerson_Leave(sender, e)
            End If
        End If
    End Sub

End Class
