using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration; // webconfigia varten

public partial class _Default : System.Web.UI.Page
{

    string strXmlFile;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label mpTitle = (Label)Page.Master.FindControl("lblTitle");
            Label mpDate = (Label)Page.Master.FindControl("lblDate");
            Label mpMessage = (Label)Page.Master.FindControl("lblMessage");
            mpTitle.Text = "Levykauppa X";
            mpDate.Text = "13.10.2016";

            //luetaan xml-tiedostosta levyjen tiedot ja esitetään ne GridViessä

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            DataView dv = new DataView();

            DataList dl = new DataList();

            strXmlFile = ConfigurationManager.AppSettings["levykauppaXFile"];
            ds.ReadXml(Server.MapPath(strXmlFile));
            dt = ds.Tables[0];
            dv = dt.DefaultView;
            
            // data sitominen ui-kontrolliin

           // gvData.DataSource = dv;
           // gvData.DataBind();



            mpMessage.Text = string.Format("Löytyi {0} työntekijää", dt.Rows.Count);
        }
    }
}