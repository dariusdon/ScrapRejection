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
        Session["Masina"] = TextBox1.Text;
        if((string)Session["Masina"] == "TBM01" || (string)Session["Masina"] == "TBMM02" || (string)Session["Masina"] == "TBM03" || (string)Session["Masina"] == "TBM04" || (string)Session["Masina"] == "TBM05" || (string)Session["Masina"] == "TBM06" || (string)Session["Masina"] == "TBM07" || (string)Session["Masina"] == "TBM08" || (string)Session["Masina"] == "TBM09" || (string)Session["Masina"] == "TBM10" ||
                (string)Session["Masina"] == "TBM11" || (string)Session["Masina"] == "TBM12" || (string)Session["Masina"] == "TBM13" || (string)Session["Masina"] == "TBM14" || (string)Session["Masina"] == "TBM15" || (string)Session["Masina"] == "TBM16" || (string)Session["Masina"] == "TBM17" || (string)Session["Masina"] == "TBM18" || (string)Session["Masina"] == "TBM19" || (string)Session["Masina"] == "TBM20" ||
                (string)Session["Masina"] == "TBM21" || (string)Session["Masina"] == "TBM22" || (string)Session["Masina"] == "TBM23" || (string)Session["Masina"] == "TBM24" || (string)Session["Masina"] == "TBM25" || (string)Session["Masina"] == "TBM26" || (string)Session["Masina"] == "TBM27" || (string)Session["Masina"] == "TBM28" || (string)Session["Masina"] == "TBM29" || (string)Session["Masina"] == "TBM30" ||
                (string)Session["Masina"] == "TBM31" || (string)Session["Masina"] == "TBM32" || (string)Session["Masina"] == "TBM33" || (string)Session["Masina"] == "TBM34" || (string)Session["Masina"] == "TBM35" || (string)Session["Masina"] == "TBM36" || (string)Session["Masina"] == "TBM37" || (string)Session["Masina"] == "TBM38" || (string)Session["Masina"] == "TBM39" || (string)Session["Masina"] == "TBM40" ||
                (string)Session["Masina"] == "TBM41" || (string)Session["Masina"] == "TBM42" || (string)Session["Masina"] == "TBM44")
        {
            Response.Redirect("FlowTB.aspx");
        }
        if ((string)Session["Masina"] == "BAA01" || (string)Session["Masina"] == "BAA02" || (string)Session["Masina"] == "BAA03" || (string)Session["Masina"] == "BAA04" || (string)Session["Masina"] == "BAA05" ||
            (string)Session["Masina"] == "BAA06" || (string)Session["Masina"] == "BAA07" || (string)Session["Masina"] == "BAA08" || (string)Session["Masina"] == "BAA09" || (string)Session["Masina"] == "BAA10" ||
            (string)Session["Masina"] == "BAA11" || (string)Session["Masina"] == "BAA12" || (string)Session["Masina"] == "BAA13" || (string)Session["Masina"] == "BAA14" || (string)Session["Masina"] == "BAA15")
        {
            Response.Redirect("MotiveApex.aspx");
        }
        if ((string)Session["Masina"] == "STATIERWAPEX")
        {
            Response.Redirect("MotiveApex.aspx");
        }
    }
   
    protected void OnClick3(object sender, EventArgs e)
    {
        Session["Masina"] = "SituatiaC";
        Response.Redirect("MotiveApex.aspx");
    }
}