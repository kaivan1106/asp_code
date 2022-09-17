using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class P2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string User = Request["name"].ToString();
        int age = Int16.Parse(Request["age"].ToString());

        Response.Write("Name:" + User);
        Response.Write("Age:" + age);

    }
}