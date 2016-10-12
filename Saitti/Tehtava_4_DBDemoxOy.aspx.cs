using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tehtava_4_DBDemoxOy : System.Web.UI.Page
{
    public string ClientSecret
    {
        get { return System.Configuration.ConfigurationManager.AppSettings["ClientSecret"]; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Label mpLabel;
        try
        {
            Label mpTitle = (Label)Page.Master.FindControl("lblTitle");
            Label mpDate = (Label)Page.Master.FindControl("lblDate");
            //Label mpUsername = (Label)Page.Master.FindControl("lblUsername");
            mpLabel = (Label)Page.Master.FindControl("lblMessage");
            //mpUsername.Text = JAMK.IT.CommonCodes.AppSetting("Username");
            mpDate.Text = "29.9.2016";
            DataTable dtAsiakkaat = JAMK.IT.DBDemoxOy.GetDataReal();
            mpTitle.Text = "Asiakkaiden haku DBDemoxOy-luokalla";
            gvAsiakkaat.DataSource = dtAsiakkaat;
            gvAsiakkaat.DataBind();
            lblResults.Text = "asiakkaita löytyi: " + gvAsiakkaat.Rows.Count.ToString();

            mpLabel.Text = "haku tehty";

        }
        catch (Exception ex)
        {
            lblResults.Text = "...";
            mpLabel = (Label)Page.Master.FindControl("lblMessage");
            mpLabel.Text = ex.Message;
            //lblMasterMessage.Text = ex.Message;
        }
    }
}