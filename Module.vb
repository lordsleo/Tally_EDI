Module TALLY_Module
    'Public conn As String = "data source=127.0.0.1;initial catalog=Tally_con;password=tally_j2mv9;user id=tally;"
    Public conn As String = "data source=168.100.1.10;initial catalog=Tally;password=tally_j2mv9;persist security info=True;user id=tally;workstation id=LXJ;packet size=4096"
    Public conn_ver As String = "data source=168.100.1.10;initial catalog=Tally_verify;password=tally_j2mv9;persist security info=True;user id=tally;workstation id=LXJ;packet size=4096"
    Public conn_rs As String = "data source=168.100.1.10;initial catalog=tally_rs;password=tally_j2mv9;persist security info=True;user id=tally;workstation id=CENTER-T433F6I4;packet size=4096"
    Public conn_rp As String = "Data Source=168.122.9.1;Initial Catalog=Tally;User ID=tally;Password=tally_j2mv9"   '外理报文
    Public sqlconn As New SqlClient.SqlConnection(conn) 'sql 连接

    Public xlApp As Excel.Application  '定义EXCEL 应用程序
    Public xlBook As Excel.Workbook    '定义EXCEL 工作薄
    Public xlSheet As Excel.Worksheet  '定义EXCEL 工作表
    Public TBar As Integer = 1         'TOOLBAR可见的标志位
    Public Mnu As Integer = 1         'FRMMAIN上的菜单可见的标志位
    Public ProcessIDs(10) As Integer


    '******************Group    
    Public G_User As String '操作员名
    Public G_User_Serial As String '操作员工号
    Public G_CurrentTime As DateTime '当前时间
    Public G_DeptCode As String '操作员所属部门代码
    Public G_DeptName As String '操作员所属部门名称
    Public G_Part_Id As Integer '角色ID
    Public G_Part As String '操作员角色
    Public G_SelectCode As String  '存放由查询返回的带回的代码
    Public G_SelectStr As String  '存放由查询返回的带回的String 
    Public G_ShipName As String '
    Public G_ShipName_Eng As String '
    Public G_Voyage As String
    Public G_Lock As String

    Public G_WorkNo As String '登录人员工号
    Public G_Date As DateTime
    Public G_BC As String
    Public G_BB As String

    Public Flag As Integer '检索Flag
    Public Sql_Find As String '检索sql
    Public Table_Name As String '检索表名
    Public ID As Integer '数据库中ID 标识字段
    Public Ship_ID As Integer '船舶航次ID 标识字段
    Public SortStr As String '排序

    '*********************ZLP
    Public Hatch_in As Integer '进口1，出口0
    Public dsdaily As New DataSet   '日报
    Public REMARKS As String '日报备注
    Public OKMARK As Integer '日报确定
    Public UNLOADPORT As String '卸货港代码
    Public DS_DO As New DataSet() '处理结果
    Public trade As String '内外贸 1为内贸 2为外贸
    Public ds_sship As New DataSet() '船舶信息
    Public mark As String '是否处理 1为处理 0为未处理
    Public LISTTIME As DateTime '报表日期
    Public LIST_DEPTNAME As String '报表部门
    Public LIST_MAN As String '报表人员

    '******************GL    
    Public GL_Time As Date
    Public GL_Str As String
    Public GL_ID As Integer
    Public GL_Clerk As Integer
    Public GL_Date As DateTime
    Public GL_Date1 As DateTime
    Public PortCode As String
    Public GL_Deptflag As String '考勤中变换的部门
    Public GL_Shift As String
    Public GL_Print As Integer
    Public GL_Teu As String   '日报标箱
    Public GL_Teudx As String '捣箱日报标箱
    Public dsdailydx As New DataSet   '捣箱日报
    Public REMARKSdx As String '捣箱日报备注
    Public OKMARKdx As Integer '捣箱日报确定
    Public GL_IOPORT As String
    '*************Pan
    Public LocalPort As String = "LYG"
    Public Const G_Dept_Oper As String = "26.11"
    Public Const SysType As String = "2"   '系统类别：1散杂货，2集装箱，0全部
End Module
