Imports TALLY.DBControl
Public Class FrmDelLoadPort
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtloadport As System.Windows.Forms.TextBox
    Friend WithEvents btnResure As System.Windows.Forms.Button
    Friend WithEvents btnCloas As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtloadport = New System.Windows.Forms.TextBox
        Me.btnResure = New System.Windows.Forms.Button
        Me.btnCloas = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "װ���۴���"
        '
        'txtloadport
        '
        Me.txtloadport.Location = New System.Drawing.Point(82, 30)
        Me.txtloadport.MaxLength = 5
        Me.txtloadport.Name = "txtloadport"
        Me.txtloadport.Size = New System.Drawing.Size(84, 21)
        Me.txtloadport.TabIndex = 1
        Me.txtloadport.Text = ""
        '
        'btnResure
        '
        Me.btnResure.Location = New System.Drawing.Point(18, 74)
        Me.btnResure.Name = "btnResure"
        Me.btnResure.TabIndex = 2
        Me.btnResure.Text = "ȷ��"
        '
        'btnCloas
        '
        Me.btnCloas.Location = New System.Drawing.Point(96, 74)
        Me.btnCloas.Name = "btnCloas"
        Me.btnCloas.TabIndex = 3
        Me.btnCloas.Text = "����"
        '
        'FrmDelLoadPort
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(198, 111)
        Me.Controls.Add(Me.btnCloas)
        Me.Controls.Add(Me.btnResure)
        Me.Controls.Add(Me.txtloadport)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDelLoadPort"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ɾ��װ������"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmDelLoadPort_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCloas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloas.Click
        Me.Close()
    End Sub

    Private Sub btnResure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResure.Click
        If MsgBox("��Ҫɾ��װ������" & txtloadport.Text & "��������", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim dss As New DataSet
            Dim dws As New DataView

            Dim sqlda As New SqlClient.SqlDataAdapter
            Dim sqls As String



            sqls = "select * from Con_Image_Record where Ship_ID=" & Ship_ID
            dws = Updatedata(sqlda, sqls, dss)
            If dws.Count > 0 Then
                Dim i As Integer
                i = 0
                Do While i < dws.Count
                    If dss.Tables(0).Rows(i)(14) = txtloadport.Text.Trim() Then
                        dss.Tables(0).Rows(i).Delete()
                        sqlda.Update(dss)
                    Else
                        i = i + 1
                    End If
                Loop


            End If
            MsgBox("������ɾ��!")
        End If
    End Sub
End Class
