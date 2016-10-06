using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tehtava_4_DBDemoxOy : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            DataTable dtAsiakkaat = JAMK.IT.DBDemoxOy.GetDataReal();

            gvAsiakkaat.DataSource = dtAsiakkaat;
            gvAsiakkaat.DataBind();
            lblResults.Text = "asiakkaita löytyi: " + gvAsiakkaat.Rows.Count.ToString();
            
        }
        catch (Exception ex)
        {
            lblResults.Text = "...";
            
            //lblMessage.Text = ex.Message;
        }
    }
}