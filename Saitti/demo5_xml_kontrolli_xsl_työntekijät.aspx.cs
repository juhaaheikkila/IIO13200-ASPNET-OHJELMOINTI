using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class demo4_xml_työntekijät : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

            if (!IsPostBack)
            {
                Label mpTitle = (Label)Page.Master.FindControl("lblTitle");
                Label mpDate = (Label)Page.Master.FindControl("lblDate");
                Label mpUsername = (Label)Page.Master.FindControl("lblUsername");
                Label mpLabel = (Label)Page.Master.FindControl("lblMessage");
                //mpUsername.Text = JAMK.IT.CommonCodes.AppSetting("Username");
                mpTitle.Text = "DEMO xml controlli ja xsl-muotoilut + kooste vakituisista";
                mpDate.Text = "13.10.2016";
            }
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            //DataView dv = new DataView();
            ds.ReadXml(Server.MapPath("~/App_Data/Työntekijät2013.xml"));
            dt = ds.Tables[0];

            double vakituinentotalsalaries = 0;

            int vakituinencount = 0;
            foreach (DataRow dr in dt.Rows)
            {
                string tyosuhteena = dr["tyosuhde"].ToString();
                double palkkana = double.Parse(dr["palkka"].ToString());
                if (tyosuhteena.Equals("vakituinen"))
                {
                    vakituinencount += 1;
                    vakituinentotalsalaries += palkkana;
                }
            }
            lblDataInfo.Text = string.Format("Vakituisten lukumäärä: {0},<br />Vakituisten yhteenlaskettu palkka: {1}", vakituinencount.ToString(), vakituinentotalsalaries.ToString());

        }
        catch (Exception ex)
        {
            lblDataInfo.Text = ex.Message;
        }
    }
    protected void LaskePalkka()
    {
        float sum = 0;
        int count = 0;
        XmlDocument doc = new XmlDocument();
        doc.Load("/App_Data/Työntekijät2013.xml");
        XmlNodeList nodes = doc.SelectNodes("/tyontekijat/tyontekija[tyosuhde = 'vakituinen']");


    }
}