using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Demo8_lokalisointi : System.Web.UI.Page
{
    Label mpTitle;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            mpTitle = (Label)Page.Master.FindControl("lblTitle");
            Label mpDate = (Label)Page.Master.FindControl("lblDate");
            //Label mpUsername = (Label)Page.Master.FindControl("lblUsername");
            Label mpLabel = (Label)Page.Master.FindControl("lblMessage");
            //mpUsername.Text = JAMK.IT.CommonCodes.AppSetting("Username");
            mpTitle.Text = "ADO.NET CRUD - Stuff harjoitus";
            mpDate.Text = "27.10.2016";

        }
    }

    protected void btnSayHello_Click(object sender, EventArgs e)
    {
        string msg = GetLocalResourceObject("Tervehdys").ToString();
        lblTitle.Text = msg;

    }
}