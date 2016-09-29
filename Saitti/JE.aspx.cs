using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JE : System.Web.UI.Page
{
    private string cstrLineFeed = "<br />";
    private string cstrUsername = "Teija Testaaja";
    private string cstrDBTitle = "JE Demo";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string mstrMessage = "";
            mstrMessage += "Tietokanta: " + cstrDBTitle + cstrLineFeed; ;
            mstrMessage += "Käyttäjä: " + cstrUsername + cstrLineFeed;
            mstrMessage += "Pvm: " + DateTime.Today.ToShortDateString() + cstrLineFeed;

            lblInfo.Text = mstrMessage;
        }
    }
}