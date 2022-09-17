using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cookies : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie c = Request.Cookies["User"];
        if (c != null)
        {
            Response.Write("Hello" + c.Value);
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if(ch1.Checked==true)
        {
            HttpCookie ck = new HttpCookie("User", txt1.Text);
            ck.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Add(ck);
            Response.Redirect("C2.aspx");
        }
    }
}