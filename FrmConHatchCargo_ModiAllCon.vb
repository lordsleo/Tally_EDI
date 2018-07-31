Imports TALLY.DBControl
Public Class FrmConHatchCargo_ModiAllCon
    Inherits System.Windows.Forms.Form

    Dim adContainer As New SqlClient.SqlDataAdapter()
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Dim dsContainer As New DataSet()
    Dim dvContanier As DataView

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConHatchCargo_ModiAllCon))
        Me.btQuit = New System.Windows.Forms.Button
        Me.btSave = New System.Windows.Forms.Button
        Me.C1DBG = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnDel = New System.Windows.Forms.Button
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btQuit
        '
        Me.btQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btQuit.Location = New System.Drawing.Point(320, 426)
        Me.btQuit.Name = "btQuit"
        Me.btQuit.Size = New System.Drawing.Size(65, 24)
        Me.btQuit.TabIndex = 582
        Me.btQuit.Text = "ȡ��"
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(252, 426)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(65, 24)
        Me.btSave.TabIndex = 581
        Me.btSave.Text = "ȷ��"
        '
        'C1DBG
        '
        Me.C1DBG.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1DBG.FilterBar = True
        Me.C1DBG.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1DBG.Images.Add(CType(resources.GetObject("C1DBG.Images"), System.Drawing.Image))
        Me.C1DBG.Location = New System.Drawing.Point(0, 28)
        Me.C1DBG.Name = "C1DBG"
        Me.C1DBG.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1DBG.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1DBG.PreviewInfo.ZoomFactor = 75
        Me.C1DBG.PrintInfo.PageSettings = CType(resources.GetObject("C1DBG.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1DBG.Size = New System.Drawing.Size(632, 392)
        Me.C1DBG.TabIndex = 580
        Me.C1DBG.Text = "C1DBG"
        Me.C1DBG.PropBag = resources.GetString("C1DBG.PropBag")
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 23)
        Me.Label1.TabIndex = 579
        Me.Label1.Text = "�����Ǹô�����������Ϣ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(6, 426)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(65, 24)
        Me.btnDel.TabIndex = 583
        Me.btnDel.Text = "ɾ��"
        '
        'FrmConHatchCargo_ModiAllCon
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btQuit
        Me.ClientSize = New System.Drawing.Size(634, 455)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btQuit)
        Me.Controls.Add(Me.btSave)
        Me.Controls.Add(Me.C1DBG)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmConHatchCargo_ModiAllCon"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "��װ��յ���Ϣ �������޸�"
        CType(Me.C1DBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmConHatchCargo_ModiAllCon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sqlContainer As String
        sqlContainer = "SELECT * FROM CON_HATCH_RECORD WHERE SHIP_ID = '" & Ship_ID & "'"
        dvContanier = Updatedata(adContainer, sqlContainer, dsContainer)
        Me.C1DBG.DataSource = dvContanier


        Me.C1DBG.Splits(0).DisplayColumns.Item("CON_HATCH_RECORD_ID").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns.Item("SHIP_ID").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns.Item("BLNO").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns.Item("CODE_GOODS").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns.Item("POSITION_CONTAINER").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns.Item("PASS_MARK").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns.Item("SHORT_UNLOAD").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns.Item("USER_NAME").Visible = False

        Me.C1DBG.Splits(0).DisplayColumns.Item("MANUFACTURER").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns.Item("KEEPER").Visible = False

        'Me.C1DBG.Splits(0).DisplayColumns.Item("AMOUNT").Visible = False
        'Me.C1DBG.Splits(0).DisplayColumns.Item("WEIGHT").Visible = False
        'Me.C1DBG.Splits(0).DisplayColumns.Item("VOLUME").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns.Item("Unload_Mark").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns.Item("BAYNO").Visible = False
        Me.C1DBG.Splits(0).DisplayColumns.Item("USER_CODE").Visible = False

        Me.C1DBG.Columns.Item("CONTAINER_NO").Caption = "��װ���"
        Me.C1DBG.Columns.Item("SIZE_CON").Caption = "��ߴ�"
        Me.C1DBG.Columns.Item("CONTAINER_TYPE").Caption = "����"
        Me.C1DBG.Columns.Item("OVER_HEIGHT").Caption = "����"
        Me.C1DBG.Columns.Item("FULLOREMPTY").Caption = "��״̬"
        Me.C1DBG.Columns.Item("SEALNO").Caption = "Ǧ���"
        Me.C1DBG.Columns.Item("BAYNO").Caption = "��λ��"
        Me.C1DBG.Columns.Item("AMOUNT").Caption = "����"
        Me.C1DBG.Columns.Item("WEIGHT").Caption = "����"
        Me.C1DBG.Columns.Item("VOLUME").Caption = "���"
        Me.C1DBG.Columns.Item("Code_MANUFACTURER").Caption = "�乫˾"
        Me.C1DBG.Columns.Item("MANUFACTURER").Caption = "�乫˾����"
        Me.C1DBG.Columns.Item("CODE_KEEPER").Caption = "�侭Ӫ��"
        Me.C1DBG.Columns.Item("KEEPER").Caption = "�侭Ӫ������"
        Me.C1DBG.Columns.Item("SealCheck").Caption = "���"
        Me.C1DBG.Columns.Item("ReeferTemp").Caption = "����¶�"
        Me.C1DBG.Columns.Item("TempUnit").Caption = "�±�"
        Me.C1DBG.Columns.Item("DangerGrade").Caption = "ΣƷ�ȼ�"
        Me.C1DBG.Columns.Item("DangerMark").Caption = "ΣƷ��ǩ"

        Call FiledFill()
        SetColumnWidth()
        'dsContainer.Tables(0).Columns("USER_NAME").DefaultValue = G_User
        'dsContainer.Tables(0).Columns("SHIP_ID").DefaultValue = Ship_ID

        Me.C1DBG.SelectedStyle.BackColor = System.Drawing.Color.CornflowerBlue
        Me.C1DBG.ColumnFooters = True
        Me.C1DBG.FooterStyle.BackColor = System.Drawing.Color.CadetBlue
        Me.C1DBG.Columns.Item("CONTAINER_NO").FooterText = "�ϼ�" & dsContainer.Tables(0).Rows.Count & "��"
        Me.C1DBG.Splits(0).DisplayColumns.Item("CONTAINER_NO").Locked = True
    End Sub

    Private Sub FiledFill()
        Dim sqla As New SqlClient.SqlDataAdapter()
        Dim sqlc As New SqlClient.SqlCommand()
        Dim dsItem As New DataSet()
        Dim i As Integer
        Try
            sqlc.Connection = sqlconn
            sqlc.CommandText = "SELECT EFL_Code, EFL_Name FROM Code_ConEFLType"
            sqla.SelectCommand = sqlc
            dsItem.Reset()
            sqla.Fill(dsItem)
            Me.C1DBG.Columns("FULLOREMPTY").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("FULLOREMPTY").ValueItems.Translate = True

            For i = 0 To dsItem.Tables(0).Rows.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
                vi.DisplayValue = dsItem.Tables(0).Rows(i)("EFL_Name")
                vi.Value = dsItem.Tables(0).Rows(i)("EFL_Code")
                Me.C1DBG.Columns.Item("FULLOREMPTY").ValueItems.Values.Add(vi)
            Next

            Me.C1DBG.Columns("OVER_HEIGHT").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("OVER_HEIGHT").ValueItems.Translate = True

            Dim vi2 As New C1.Win.C1TrueDBGrid.ValueItem()
            vi2.DisplayValue = "����"
            vi2.Value = "0"
            Me.C1DBG.Columns.Item("OVER_HEIGHT").ValueItems.Values.Add(vi2)
            Dim vi1 As New C1.Win.C1TrueDBGrid.ValueItem()
            vi1.DisplayValue = "����"
            vi1.Value = "1"
            Me.C1DBG.Columns.Item("OVER_HEIGHT").ValueItems.Values.Add(vi1)

            Dim sqlConKind As String = "SELECT CODE_CON_KIND, CON_KIND_ENG FROM CODE_CON_KIND ORDER BY CODE_CON_KIND"
            Dim dvConKind As New DataView()
            dvConKind = Filldata(sqlConKind)
            Me.C1DBG.Columns("CONTAINER_TYPE").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("CONTAINER_TYPE").ValueItems.Translate = True
            For i = 0 To dvConKind.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
                vi.DisplayValue = dvConKind(i)("CON_KIND_ENG")
                vi.Value = dvConKind(i)("CODE_CON_KIND")
                Me.C1DBG.Columns.Item("CONTAINER_TYPE").ValueItems.Values.Add(vi)
            Next

            Dim sqlKeeper, sqlCompany As String
            Dim dvKeeper As New DataView()
            Dim dvCompany As New DataView()
            sqlKeeper = "SELECT Code_Con_Company, Con_Company_CHI, Con_Company_ENG FROM Code_Con_Company ORDER BY Con_Company_CHI"
            sqlCompany = "SELECT Code_Con_Company, Con_Company_CHI, Con_Company_ENG FROM Code_Con_Company ORDER BY Con_Company_CHI"
            dvKeeper = Filldata(sqlKeeper)
            dvCompany = Filldata(sqlCompany)
            Me.C1DBG.Columns("CODE_KEEPER").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("CODE_KEEPER").ValueItems.Translate = True
            Me.C1DBG.Columns("Code_MANUFACTURER").ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
            Me.C1DBG.Columns("Code_MANUFACTURER").ValueItems.Translate = True
            For i = 0 To dvKeeper.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
                vi.DisplayValue = dvKeeper(i)("Con_Company_CHI")
                vi.Value = dvKeeper(i)("Code_Con_Company")
                Me.C1DBG.Columns.Item("CODE_KEEPER").ValueItems.Values.Add(vi)
            Next
            For i = 0 To dvCompany.Count - 1
                Dim vi As New C1.Win.C1TrueDBGrid.ValueItem()
                vi.DisplayValue = dvCompany(i)("Con_Company_CHI")
                vi.Value = dvCompany(i)("Code_Con_Company")
                Me.C1DBG.Columns.Item("Code_MANUFACTURER").ValueItems.Values.Add(vi)
            Next

        Catch ex As System.Exception
            MsgBox(ex.Message)
        Finally
            sqlconn.Close()
        End Try
    End Sub

    Private Sub SetColumnWidth()
        Dim i As Integer
        Try
            i = 2
            Do While i < Me.C1DBG.Columns.Count
                Me.C1DBG.Splits(0).DisplayColumns.Item(i).Width = ((Me.C1DBG.Width - 25) / (Me.C1DBG.Columns.Count - 10))
                i = i + 1
            Loop

            Me.C1DBG.Splits(0).DisplayColumns("CONTAINER_NO").Width = 85
            Me.C1DBG.Splits(0).DisplayColumns("SEALNO").Width = 90
            Me.C1DBG.Splits(0).DisplayColumns("CODE_KEEPER").Width = 100
            Me.C1DBG.Splits(0).DisplayColumns("Code_MANUFACTURER").Width = 100

        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub C1DBG_AfterColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles C1DBG.AfterColEdit
        If e.ColIndex = 13 Then
            Me.C1DBG.Columns("MANUFACTURER").Text = Me.C1DBG.Columns("Code_MANUFACTURER").Text
        ElseIf e.ColIndex = 15 Then
            Me.C1DBG.Columns("KEEPER").Text = Me.C1DBG.Columns("CODE_KEEPER").Text
        End If
    End Sub

    Private Sub C1DBG_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1DBG.KeyDown
        If e.KeyData = Keys.Enter And Me.C1DBG.Col = 22 Then
            Me.C1DBG.Row += 1
            Me.C1DBG.Col = 2
            SendKeys.Send("{LEFT}")
        End If
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        If MessageBox.Show("ȷ������������Ϣ���޸�ô��", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Me.adContainer.Update(dsContainer)
            Me.Close()
        End If
    End Sub

    Private Sub btQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btQuit.Click
        Me.Close()
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If MessageBox.Show("ȷ��Ҫɾ����װ��[" + Me.C1DBG.Columns("CONTAINER_NO").Text + "]��", "��ʾ", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2) = DialogResult.OK Then
            C1DBG.Delete()
        End If
    End Sub

    Private Sub C1DBG_Filter(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.FilterEventArgs) Handles C1DBG.Filter
        'dvContanier.RowFilter = e.Condition
    End Sub
End Class
