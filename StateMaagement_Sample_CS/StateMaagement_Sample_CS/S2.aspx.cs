using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class S2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string User = Session["name"].ToString();
        int age = Int16.Parse(Session["age"].ToString());
        Response.Write(User + "" + age);

    }
}