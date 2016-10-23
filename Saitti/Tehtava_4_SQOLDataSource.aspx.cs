using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tehtava_4_SQOLDataSource : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label mpTitle = (Label)Page.Master.FindControl("lblTitle");
            Label mpDate = (Label)Page.Master.FindControl("lblDate");
            mpTitle.Text = "Asiakkaiden haku - SQL data source";
            mpDate.Text = "29.9.2016";
        }
    }
}