using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBHandlingWebApp
{
    public partial class FrmMemoList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

            using (var conn= new SqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand("ListMemo", conn);
                cmd.CommandType = CommandType.StoredProcedure; //ListMemo에 있는 데이터중 종류는 StoredProcedure(저장된 프로시저)꺼 불러오기

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet(); //데이터를 넣을 공간을 만든다
                adapter.Fill(ds, "Memos");

                GrvMemoList.DataSource = ds; //그리드뷰에서 바인딩 실행하면 표에 위에서 뽑은 값들이 채워진다
                GrvMemoList.DataBind();
            }

        }

        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            var connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

            using (var conn = new SqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                SqlCommand cmd = new SqlCommand("SearchMemo", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SearchField", CboSearch.SelectedValue); //Title, Name
                cmd.Parameters.AddWithValue("@SearchQuery", TxtSearch.Text.Replace("--",""));//데이터타입 지정 없이 값을 할당한 표현으로 암묵적 값 변환 수행 --는 Sql 에서 주석이라 오류발생

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet(); 
                adapter.Fill(ds, "Memos");

                GrvMemoList.DataSource = ds;// Tables[0].DefaultView; 
                GrvMemoList.DataBind();
            }

        }
    }
}