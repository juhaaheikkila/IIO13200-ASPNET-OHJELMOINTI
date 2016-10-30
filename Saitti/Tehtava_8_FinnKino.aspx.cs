using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Tahtava_8_FinnKino : System.Web.UI.Page
{
    Boolean gblnDebug = true;
    Label mpMessage;
    CheckBox debug;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //DropDownList lstLocations;
            Label mpTitle = (Label)Page.Master.FindControl("lblTitle");
            Label mpDate = (Label)Page.Master.FindControl("lblDate");
            //Label mpUsername = (Label)Page.Master.FindControl("lblUsername");
            mpMessage = (Label)Page.Master.FindControl("lblMessage");

            //mpUsername.Text = JAMK.IT.CommonCodes.AppSetting("Username");
            mpTitle.Text = "Viikkotehtävä 8, FinnKino viikon elokuvat";
            mpDate.Text = "13.10.2016";
           // mpUsername.Text = System.Configuration.ConfigurationManager.AppSettings["Username"];
            //luetaan elokuvateatterit valintalistaan
            try
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds.ReadXml("http://www.finnkino.fi/xml/TheatreAreas/");
                dt = ds.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    string strID = dr["ID"].ToString();
                    string strName = dr["Name"].ToString();
                    lstLocations.Items.Add(new ListItem(strName, strID));
                }
            }
            catch (Exception ex)
            {
                mpMessage.Text = ex.Message;
            }
        }
        debug = (CheckBox)Page.Master.FindControl("chkDebug");
        gblnDebug = debug.Checked;
    }



    protected void lstLocations_SelectedIndexChanged(object sender, EventArgs e)
    {
        //url
        string strSelectedLocation = lstLocations.SelectedValue;
        string mstrUrl = "http://www.finnkino.fi/xml/Schedule/?Area=" + strSelectedLocation + "&dt=" + DateTime.Today.ToShortDateString();
        //lblSelectedLocation.Text = "* Valittu paikkakunta koodi: " + strSelectedLocation + "<br />";


        //read xlm to document
        string strXmlFromUrl;
        using (var wc = new WebClient())
        {
            wc.Encoding = Encoding.UTF8;
            strXmlFromUrl = wc.DownloadString(mstrUrl);
        }
        var xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(strXmlFromUrl);

        XmlNodeList nodes = xmlDoc.SelectNodes("/Schedule/Shows/Show");

        myDiv.InnerHtml = string.Format("<b>Elokuvateatteri {0} valittu</b><br />", lstLocations.SelectedItem.ToString());

        List<String> listOfShows = new List<String>();
        int mintEventCounter = 0;

        foreach (XmlNode node in nodes)
        {
            XmlNodeList children = node.SelectNodes("Images/EventMicroImagePortrait");
            if (children != null)
            {
                String strEventID = node["EventID"].InnerText;
                if (!listOfShows.Contains(strEventID))
                {
                    mintEventCounter += 1;
                    listOfShows.Add(strEventID);
                    String strPictureURL = children.Item(0).InnerText;
                    myDiv.InnerHtml += string.Format("<img src='{0}' title='{1}' style='height:150px' />", strPictureURL, node["Title"].InnerText);
                }
            }
        }
        if (gblnDebug)
        {
            myDiv.InnerHtml += "<br /><p style='fontfamily: courier; '> *** DEBUG ***<br />";
            myDiv.InnerHtml += string.Format("Päivitetty: {0} {1}<br />", DateTime.Today.ToShortDateString(), DateTime.Now.ToLongTimeString());
            myDiv.InnerHtml += string.Format("* Valittu paikkakunta koodi: {0}<br />", strSelectedLocation);
            myDiv.InnerHtml += string.Format("* Parsittu URL: {0}<br />", mstrUrl);
            myDiv.InnerHtml += string.Format("* Elokuvien lkm: {0}<br />", nodes.Count);
            myDiv.InnerHtml += string.Format("* Eri elokuvia: {0}", mintEventCounter.ToString());

        }

    }


}