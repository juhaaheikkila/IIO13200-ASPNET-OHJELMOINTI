using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SaitinMasteri : System.Web.UI.MasterPage
{

    protected void Page_Load(object sender, EventArgs e)
    {
        lblUsername.Text = System.Configuration.ConfigurationManager.AppSettings["Username"];
    }

    protected void chkDebug_CheckedChanged(object sender, EventArgs e)
    {

    }
}
