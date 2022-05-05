using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Select : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        getSchimb();
        if((string)Session["shift"] == "B")
        {
            Session["Schimb"] = "Blue";
        }
        if ((string)Session["shift"] == "Y")
        {
            Session["Schimb"] = "Yellow";
        }
        if ((string)Session["shift"] == "G")
        {
            Session["Schimb"] = "Green";
        }
        if ((string)Session["shift"] == "O")
        {
            Session["Schimb"] = "Orange";
        }
        Label1.Text = "Data:" + DateTime.Now.ToString("dd/MM/yyyy") + " " + "Ora: " + DateTime.Now.ToString("HH:mm");
        Label2.Text = "Operator:" + Session["name"];
        Label3.Text = "Schimb:" + Session["Schimb"];
    }
    protected void getSchimb()
    {

        string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd1 = new SqlCommand())
            {
                string sql1 = @"SELECT [ShiftDate]
                      ,[ShiftID]
                      ,[ShiftColor]
                      FROM[tias067a].[NewERT].[dbo].[ShiftCalendar]
                      where convert(varchar, ShiftDate,23) = convert(varchar, getdate(), 23)
                      and ShiftID = (case when convert(varchar, getdate(),24) between '07:00:00' and '15:00:00' then '1'
                      when convert(varchar, getdate(),24) between '15:00:00' and '23:00:00' then '2'
                      when convert(varchar, getdate(),24) between '23:00:00' and '23:59:59' then '3'
                      when convert(varchar, getdate(),24) between '00:00:00' and '07:00:00' then '3' end)";
                cmd1.CommandText = sql1;
                cmd1.Connection = con;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd1))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    Session["shift"] = Convert.ToString(dt.Rows[0]["ShiftColor"]);
                }
            }
        }
    }
    protected void OnClick1(object sender,EventArgs e)
    {
        Session["Masina"] = "SituatiaA";
        Response.Redirect("FlowTB.aspx");
    }
    protected void OnClick2(object sender, EventArgs e)
    {
        Session["Masina"] = "SituatiaB";
        Response.Redirect("MotiveApex.aspx");
    }
    protected void OnClick3(object sender, EventArgs e)
    {
        Session["Masina"] = "SituatiaC";
        Response.Redirect("MotiveApex.aspx");
    }
}