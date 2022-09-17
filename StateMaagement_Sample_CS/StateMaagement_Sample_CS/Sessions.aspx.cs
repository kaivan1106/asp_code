using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Sessions : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write(Session.SessionID);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        Session["name"] = txt1.Text;
        Session["age"] = txt2.Text;
        Response.Redirect("S2.aspx");
    }
}