using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MotiveApex : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void OnClick1(object sender,EventArgs e)
    {
        Session["motiv"] = "Imbinare Neconforma";
        Response.Redirect("MasinaAPEX.aspx");
    }
    protected void OnClick2(object sender, EventArgs e)
    {
        Session["motiv"] = "Fir Sarma Iesit";
        Response.Redirect("MasinaAPEX.aspx");
    }
    protected void OnClick4(object sender, EventArgs e)
    {
        Session["motiv"] = "Pozitionare Neconforma";
        Response.Redirect("MasinaAPEX.aspx");
    }
    protected void OnClick5(object sender, EventArgs e)
    {
        Session["motiv"] = "Stationare Neconforma";
        Response.Redirect("MasinaAPEX.aspx");
    }
    protected void OnClick6(object sender, EventArgs e)
    {
        Session["motiv"] = "Aer Intre Straturi";
        Response.Redirect("MasinaAPEX.aspx");
    }
    protected void OnClick7(object sender, EventArgs e)
    {
        Session["motiv"] = "Deformare TB";
        Response.Redirect("MasinaAPEX.aspx");
    }
    protected void OnClick8(object sender, EventArgs e)
    {
        Session["motiv"] = "Deformare Apex";
        Response.Redirect("MasinaAPEX.aspx");
    }
    protected void OnClick9(object sender, EventArgs e)
    {
        Session["motiv"] = "Material Contaminat";
        Response.Redirect("MasinaAPEX.aspx");
    }
    protected void OnClick10(object sender, EventArgs e)
    {
        Session["motiv"] = "Latimea bentitei neconforma";
        Response.Redirect("MasinaAPEX.aspx");
    }
    protected void OnClick11(object sender, EventArgs e)
    {
        Session["motiv"] = "Diametru Gresit";
        Response.Redirect("MasinaAPEX.aspx");
    }
    protected void OnClick3(object sender, EventArgs e)
    {
        Session["motiv"] = "Fire neacoperite";
        Response.Redirect("MasinaAPEX.aspx");
    }
}
