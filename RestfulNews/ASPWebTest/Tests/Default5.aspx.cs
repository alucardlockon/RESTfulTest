using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.OracleClient;



public partial class _Default : System.Web.UI.Page
{
    //    string oo= @"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER = DEDICATED)
    //(SERVICE_NAME = orcl)));User Id=nf_study;Password=nf251";

    string oo = @"Data Source=nf251;User ID=nf_study;Password=nf251";
    protected void Page_Load(object sender, EventArgs e)
    {
        html_name.Value = "张三";
        
        
        //if(Session["Obj1"].ToString()!=null|| Session["Obj1"].ToString()!="")
        //dt.Rows.Add(Session["Obj1"].ToString());
    }

    protected void BtnSave_Click(object sender, EventArgs e)
    {
        
        DataTable dt = (DataTable)ViewState["a"];
        //DataTable dt = (DataTable)Session["a"];

        // fm_name.Text = html_name.Value;
        html_name.Value = "测试";
        

        //string 字符串 
        string strName = html_name.Value;

        ///数据类型转换  Convert
        int intA = Convert.ToInt32(fm_name.Text);

        if (intA == 0)
        {
        }
        else if (intA == 1)
        {

        }
        else
        {

        }

        //Double 双精度;
        //decimal 金额;
        //float 浮点;
        //DateTime 时间、日期 转换格式;

        DateTime dtn = DateTime.Now;

        string strDtn = dtn.ToString("yyyy/mm/dd");//2016/49/27
        //string strDtn = dtn.ToLongDateString();//2016年12月27日
        //string strDtn = dtn.ToLongTimeString();//12:54:36
        //string strDtn = Convert.ToString(dtn.ToOADate());//42731.5405587963
        //string strDtn = dtn.ToShortDateString();//2016/12/27
        //string strDtn = dtn.ToShortTimeString();//13:02
        //string strDtn = Convert.ToString(dtn.ToUniversalTime());//2016/12/27 5:04:40


        Response.Write(strDtn);

        for (int i = 0; i < intA; i++)
        {
            Response.Write(i.ToString());
        }

        string[] arr = new string[] { "A", "V", "F", "D", "S" };
        int[] arrInt = new int[] { 1, 2, 3, 590 };
        //decimal[][] arrD = new decimal[][] { }; 多維數組

        foreach (string str in arr)
        {
            Response.Write(str);
        }

        for (int i = 0; i < arr.Length; i++)
        {
            Response.Write(arr[i]);
        }


        if (dt == null || dt.Rows.Count == 0)
        {
            dt = new DataTable();

            DataColumn dc1 = new DataColumn("name", typeof(string));
            dt.Columns.Add(dc1);
            DataColumn dc2 = new DataColumn("sex", typeof(string));
            dt.Columns.Add(dc2);
            DataColumn dc3 = new DataColumn("age", typeof(string));
            dt.Columns.Add(dc3);
        }
        DataRow dr = dt.NewRow();


        if ((name.Value != "" && name.Value != null))
        {
            dr[0] = name.Value;
            dr[1] = sex.Value;
            dr[2] = age.Value;

            dt.Rows.Add(dr);//
        }

        //Session["a"]=dt;
        ViewState["a"] = dt;


        Response.Write(dt.Rows.Count + "行");

        //Session["Obj1"] = dr;




        //DataRow[] dtAyy = dt.Select("name='1'");
        ////dt.Copy();  
        ////行和列
        //DataRow row = dt.NewRow();
        //DataColumn dc = new DataColumn();

        //作业 
        //1.熟悉基本的语法、数据类型
        //2.DateTime 格式转换
        //3.datatable 数据填充   姓名、性别、年龄  输出Datatable 行数  int len = dt.Rows.Count;

    }


    protected void button1_Click(object sender, EventArgs e)
    {
        

        OracleConnection conn = new OracleConnection(oo);//Data Source后面跟你数据库的名字，User ID为用户名，Password为密码             
        conn.Open();

        string sql = "select * from stu";
        OracleCommand cmd = new OracleCommand(sql, conn);
        OracleDataAdapter oda = new OracleDataAdapter(cmd);
        DataTable dt = new DataTable();
        oda.Fill(dt);
        conn.Close();
        cmd.Dispose();
        GridView1.DataSource = dt;
        GridView1.DataBind();
        //GridView1.DataBind();
        //return dt;

    }
    protected void button2_Click(object sender, EventArgs e)
    {

        

        OracleConnection conn = new OracleConnection(oo);//Data Source后面跟你数据库的名字，User ID为用户名，Password为密码             
        conn.Open();
        string sql = "insert into stu(XINGM,NIANL,XINGB,XUEH) values(:XINGM,:NIANL,:XINGB,:XUEH)";
        OracleCommand cmd = new OracleCommand(sql, conn);
        OracleParameter parn = new OracleParameter(":XINGM", name.Value);
        cmd.Parameters.Add(parn);
        OracleParameter parp = new OracleParameter(":NIANL", sex.Value);
        cmd.Parameters.Add(parp);
        OracleParameter parn2 = new OracleParameter(":XINGB", age.Value);
        cmd.Parameters.Add(parn2);
        OracleParameter parp2 = new OracleParameter(":XUEH", XUEH.Value);
        cmd.Parameters.Add(parp2);
        //OracleParameter parn3 = new OracleParameter(":name", name);
        //cmd.Parameters.Add(parn3);
        //OracleParameter parp3 = new OracleParameter(":pwd", name);
        //cmd.Parameters.Add(parp3);
        int result = cmd.ExecuteNonQuery();//result接收受影响行数，也就是说result大于0的话表示添加成功              
        conn.Close();
        cmd.Dispose();
        //return result;
    }
    protected void button3_Click(object sender, EventArgs e)
    {
        

        OracleConnection conn = new OracleConnection(oo);//Data Source后面跟你数据库的名字，User ID为用户名，Password为密码             
        conn.Open();
        string sql = "UPDATE stu set XINGM=:XINGM,NIANL=:NIANL,XINGB=:XINGB,XUEH=:XUEH where XUEH=:XUEH";
        OracleCommand cmd = new OracleCommand(sql, conn);
        OracleParameter parn = new OracleParameter(":XINGM", name.Value);
        cmd.Parameters.Add(parn);
        OracleParameter parp = new OracleParameter(":NIANL", age.Value);
        cmd.Parameters.Add(parp);
        OracleParameter parn2 = new OracleParameter(":XINGB", sex.Value);
        cmd.Parameters.Add(parn2);
        OracleParameter parp2 = new OracleParameter(":XUEH", XUEH.Value);
        cmd.Parameters.Add(parp2);
        int result = cmd.ExecuteNonQuery();//result接收受影响行数，也就是说result大于0的话表示添加成功
        conn.Close();
        cmd.Dispose();
        //return result;
    }
    protected void button4_Click(object sender, EventArgs e)
    {
        

        OracleConnection conn = new OracleConnection(oo);//Data Source后面跟你数据库的名字，User ID为用户名，Password为密码             
        conn.Open();
        string sql = "delete from stu where XUEH=:XUEH";
        OracleCommand cmd = new OracleCommand(sql, conn);
        OracleParameter pari = new OracleParameter(":XUEH", XUEH.Value);
        cmd.Parameters.Add(pari);
        int result = cmd.ExecuteNonQuery();//result接收受影响行数，也就是说result大于0的话表示添加成功
        conn.Close();
        cmd.Dispose();

        //return result;
    }

}

//public class OracleCommand
//{
//    public string CommandText { get; internal set; }
//    public OracleConnection Connection { get; internal set; }
//}

//public class OracleConnection
//{
//    internal string ConnectionString;

//    internal void Close()
//    {
//        throw new NotImplementedException();
//    }

//    internal void Open()
//    {
//        throw new NotImplementedException();
//    }
//}