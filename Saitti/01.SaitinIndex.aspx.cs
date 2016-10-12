using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAMK.IT.CommonCodes;

public partial class Default5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label mpTitle = (Label)Page.Master.FindControl("lblTitle");
        Label mpDate = (Label)Page.Master.FindControl("lblDate");
        mpTitle.Text = "Syksy 2016 kurssi";
        mpDate.Text = "8.9.2016";
    }
}