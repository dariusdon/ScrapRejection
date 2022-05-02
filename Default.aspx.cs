using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void OnClick(object sender, EventArgs e)
    {
        string name = TextBox1.Text;
        string password = TextBox2.Text;

        if (name == "davidhadzi" && password == "61039")
        {
            Session["name"] = "Davidhadzi";
            Response.Redirect("Select.aspx");
        }
        if (name == "preduta" && password == "61072")
        {
            Session["name"] = "Preduta";
            Response.Redirect("Select.aspx");
        }
        if (name == "savin" && password == "61071")
        {
            Session["name"] = "Savin";
            Response.Redirect("Select.aspx");
        }
        if (name == "anghel" && password == "60917")
        {
            Session["name"] = "Anghel";
            Response.Redirect("Select.aspx");
        }
        if (name == "diaconu" && password == "5951")
        {
            Session["name"] = "Diaconu";
            Response.Redirect("Select.aspx");
        }
        if (name == "jianu" && password == "6284")
        {
            Session["name"] = "Jianu";
            Response.Redirect("Select.aspx");
        }
        if (name == "murdeala" && password == "60825")
        {
            Session["name"] = "Murdeala";
            Response.Redirect("Select.aspx");
        }
        if (name == "brie" && password == "8189")
        {
            Session["name"] = "Brie";
            Response.Redirect("Select.aspx");
        }
        if (name == "leu" && password == "8080")
        {
            Session["name"] = "Leu";
            Response.Redirect("Select.aspx");
        }
        if (name == "boicu" && password == "8816")
        {
            Session["name"] = "Boicu";
            Response.Redirect("Select.aspx");
        }
        if (name == "chitoran" && password == "4134")
        {
            Session["name"] = "Chitoran";
            Response.Redirect("Select.aspx");
        }
        if (name == "stancu" && password == "8385")
        {
            Session["name"] = "Stancu";
            Response.Redirect("Select.aspx");
        }
        if (name == "telegan" && password == "8161")
        {
            Session["name"] = "Telegan";
            Response.Redirect("Select.aspx");
        }
        if (name == "beldean" && password == "4092")
        {
            Session["name"] = "Beldean";
            Response.Redirect("Select.aspx");
        }
        if (name == "ilis" && password == "3882")
        {
            Session["name"] = "Ilis";
            Response.Redirect("Select.aspx");
        }

        if (name == "lupia" && password == "61069")
        {
            Session["name"] = "Lupia";
            Response.Redirect("Select.aspx");
        }
        if (name == "rosculet" && password == "8222")
        {
            Session["name"] = "Rosculet";
            Response.Redirect("Select.aspx");
        }
        if (name == "suciu" && password == "8731")
        {
            Session["name"] = "Suciu";
            Response.Redirect("Select.aspx");
        }
        if (name == "tuiu" && password == "6525")
        {
            Session["name"] = "Tuiu";
            Response.Redirect("Select.aspx");
        }
        if (name == "csorto" && password == "8938")
        {
            Session["name"] = "Csorto";
            Response.Redirect("Select.aspx");
        }
        if (name == "beuca" && password == "8492")
        {
            Session["name"] = "Beuca";
            Response.Redirect("Select.aspx");
        }
        if (name == "mitiuca" && password == "8670")
        {
            Session["name"] = "Mitiuca";
            Response.Redirect("Select.aspx");
        }
        if (name == "ivan" && password == "8585")
        {
            Session["name"] = "Ivan";
            Response.Redirect("Select.aspx");
        }
        if (name == "golea" && password == "8877")
        {
            Session["name"] = "Golea";
            Response.Redirect("Select.aspx");
        }
        if(name == "user" && password == "user")
        {
            Session["name"] = "Darius";
            Response.Redirect("Select.aspx");
        }
        if(name == "admin" && password == "admin")
        {
            Session["name"] = "admin";
            Response.Redirect("RaportAdmin.aspx");
        }
    }
}