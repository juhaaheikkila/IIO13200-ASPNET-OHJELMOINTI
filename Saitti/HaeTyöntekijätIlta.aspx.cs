using System;
using System.Configuration; // webconfigia varten
using System.Data; //ADO.NET luokkia varten
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HaeTyöntekijätIlta : System.Web.UI.Page
{
    string strXmlFile;

    protected void Page_Load(object sender, EventArgs e)
    {
        //luetaan web.configista xml-tiedoston nimi
        strXmlFile = ConfigurationManager.AppSettings["tiedosto"];
        lblMessage.Text = strXmlFile;
    }

    protected void btnHae_Click(object sender, EventArgs e)
    {
        //luetaan xml-tiedostosta työntekijöiden tiedot ja esitetään ne GridViessä

        DataSet ds   = new DataSet();
        DataTable dt = new DataTable();
        DataView dv  = new DataView();

        ds.ReadXml(Server.MapPath(strXmlFile));
        dt = ds.Tables[0];
        dv = dt.DefaultView;
        // data sitominen ui-kontrolliin

        gvData.DataSource = dv;
        gvData.DataBind();

        lblMessage.Text = string.Format("Löytyi {0} työntekijää", dt.Rows.Count);
    }
}