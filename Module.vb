Module TALLY_Module
    'Public conn As String = "data source=127.0.0.1;initial catalog=Tally_con;password=tally_j2mv9;user id=tally;"
    Public conn As String = "data source=168.100.1.10;initial catalog=Tally;password=tally_j2mv9;persist security info=True;user id=tally;workstation id=LXJ;packet size=4096"
    Public conn_ver As String = "data source=168.100.1.10;initial catalog=Tally_verify;password=tally_j2mv9;persist security info=True;user id=tally;workstation id=LXJ;packet size=4096"
    Public conn_rs As String = "data source=168.100.1.10;initial catalog=tally_rs;password=tally_j2mv9;persist security info=True;user id=tally;workstation id=CENTER-T433F6I4;packet size=4096"
    Public conn_rp As String = "Data Source=168.122.9.1;Initial Catalog=Tally;User ID=tally;Password=tally_j2mv9"   '������
    Public sqlconn As New SqlClient.SqlConnection(conn) 'sql ����

    Public xlApp As Excel.Application  '����EXCEL Ӧ�ó���
    Public xlBook As Excel.Workbook    '����EXCEL ������
    Public xlSheet As Excel.Worksheet  '����EXCEL ������
    Public TBar As Integer = 1         'TOOLBAR�ɼ��ı�־λ
    Public Mnu As Integer = 1         'FRMMAIN�ϵĲ˵��ɼ��ı�־λ
    Public ProcessIDs(10) As Integer


    '******************Group    
    Public G_User As String '����Ա��
    Public G_User_Serial As String '����Ա����
    Public G_CurrentTime As DateTime '��ǰʱ��
    Public G_DeptCode As String '����Ա�������Ŵ���
    Public G_DeptName As String '����Ա������������
    Public G_Part_Id As Integer '��ɫID
    Public G_Part As String '����Ա��ɫ
    Public G_SelectCode As String  '����ɲ�ѯ���صĴ��صĴ���
    Public G_SelectStr As String  '����ɲ�ѯ���صĴ��ص�String 
    Public G_ShipName As String '
    Public G_ShipName_Eng As String '
    Public G_Voyage As String
    Public G_Lock As String

    Public G_WorkNo As String '��¼��Ա����
    Public G_Date As DateTime
    Public G_BC As String
    Public G_BB As String

    Public Flag As Integer '����Flag
    Public Sql_Find As String '����sql
    Public Table_Name As String '��������
    Public ID As Integer '���ݿ���ID ��ʶ�ֶ�
    Public Ship_ID As Integer '��������ID ��ʶ�ֶ�
    Public SortStr As String '����

    '*********************ZLP
    Public Hatch_in As Integer '����1������0
    Public dsdaily As New DataSet   '�ձ�
    Public REMARKS As String '�ձ���ע
    Public OKMARK As Integer '�ձ�ȷ��
    Public UNLOADPORT As String 'ж���۴���
    Public DS_DO As New DataSet() '������
    Public trade As String '����ó 1Ϊ��ó 2Ϊ��ó
    Public ds_sship As New DataSet() '������Ϣ
    Public mark As String '�Ƿ��� 1Ϊ���� 0Ϊδ����
    Public LISTTIME As DateTime '��������
    Public LIST_DEPTNAME As String '������
    Public LIST_MAN As String '������Ա

    '******************GL    
    Public GL_Time As Date
    Public GL_Str As String
    Public GL_ID As Integer
    Public GL_Clerk As Integer
    Public GL_Date As DateTime
    Public GL_Date1 As DateTime
    Public PortCode As String
    Public GL_Deptflag As String '�����б任�Ĳ���
    Public GL_Shift As String
    Public GL_Print As Integer
    Public GL_Teu As String   '�ձ�����
    Public GL_Teudx As String '�����ձ�����
    Public dsdailydx As New DataSet   '�����ձ�
    Public REMARKSdx As String '�����ձ���ע
    Public OKMARKdx As Integer '�����ձ�ȷ��
    Public GL_IOPORT As String
    '*************Pan
    Public LocalPort As String = "LYG"
    Public Const G_Dept_Oper As String = "26.11"
    Public Const SysType As String = "2"   'ϵͳ���1ɢ�ӻ���2��װ�䣬0ȫ��
End Module
