using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RaportOperatori : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void OnClick1(object sender,EventArgs e)
    {
        Response.Redirect("Select.aspx");
    }
    protected void OnClick2(object sender,EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}