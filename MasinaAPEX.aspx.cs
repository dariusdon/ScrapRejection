using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasinaAPEX : System.Web.UI.Page
{
    public double overall = 0.00;
    public double greutate = 0.00;
    public string profil = "";
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void OnClick1(object sender, EventArgs e)
    {
        int toli = Convert.ToInt32(DropDownList1.Text);
       
        double bucati = Convert.ToDouble(TextBox1.Text);
        
        if(toli == 13)
        {
            greutate = 0.124;
            overall = bucati * greutate;
        }
        if (toli == 14)
        {
            greutate = 0.151;
            overall = bucati * greutate;
        }
        if (toli == 15)
        {
            greutate = 0.195;
            overall = bucati * greutate;
        }
        if (toli == 16)
        {
            greutate = 0.231;
            overall = bucati * greutate;
        }
        if (toli == 17)
        {
            greutate = 0.276;
            overall = bucati * greutate;
        }
        if (toli == 18)
        {
            greutate = 0.438;
            overall = bucati * greutate;
        }
        if (toli == 19)
        {
            greutate = 0.279;
            overall = bucati * greutate;
        }
        if (toli == 20)
        {
            greutate = 0.323;
            overall = bucati * greutate;
        }
        Session["greutate"] = overall;
        if ((double)Session["greutate"] > 1.00)
        {
           Session["masura"] = "kg";
        }
        else
        {
            Session["greutate"] = (double)Session["greutate"] * 1000;
            Session["masura"] = "g";
        }
        DropDownList1.Text = "Numar Toli";
        profil = DropDownList2.Text + " " + toli + " INCH" + " " + DropDownList3.Text;
       
        TextBox1.Text = "";
        string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        using (SqlConnection con = new SqlConnection(constr))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                string sql = @" 
                    INSERT INTO [dbo].[ScrapRejection]
                               ([Data]
                               ,[Operator]
                               ,[Masina]
                               ,[Material]
                               ,[Motiv]
                               ,[Toli]
                               ,[Profil]
                               ,[Greutate]
                               ,[Masura(g/KG)]
                               ,[Schimb])
                    VALUES
                               (convert(varchar,getdate(),25)
                               ,'" + Session["name"] + @"'
                               ,'" + Session["Masina"] + @"'
                               ,'" + Session["TipMaterial"]  + @"'
                               ,'" + Session["motiv"] + @"' 
                               ,'" + toli + @"'
                               ,'" + profil + @"'
                               ,'" + Session["greutate"] + @"'
                               ,'" + Session["masura"] + @"'
                               ,'" + Session["Schimb"]  + @"' 
                               )";
                cmd.CommandText = sql;
                cmd.Connection = con;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                }
            }
        }
    

            Response.Redirect("RaportOperatori.aspx");

    }
}