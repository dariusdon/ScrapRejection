using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RaportOperatori : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Details();
    }
    protected void OnClick1(object sender,EventArgs e)
    {
        Response.Redirect("Select.aspx");
    }
    protected void OnClick2(object sender,EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    public void Details()
    {
        string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                string sql = @"SELECT * FROM[dbo].[ScrapRejection]
                                Order By[Data] DESC; ";

                cmd.CommandText = sql;
                cmd.Connection = con;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    GridView1.AllowPaging = true;
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            }
        }
    }
    protected void GrdEmp_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataBind();
    }
}