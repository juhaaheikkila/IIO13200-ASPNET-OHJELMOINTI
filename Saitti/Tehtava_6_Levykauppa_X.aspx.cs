using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration; // webconfigia varten
using System.Xml;

public partial class _Default : System.Web.UI.Page
{

    string strXmlFile;


    protected void Page_Load(object sender, EventArgs e)
    {
        int mintCounter = 0;
        string photosPath = MapPath("~/Images");
        Label mpMessage = (Label)Page.Master.FindControl("lblMessage"); ;
        if (!IsPostBack)
        {
            Label mpTitle = (Label)Page.Master.FindControl("lblTitle");
            Label mpDate = (Label)Page.Master.FindControl("lblDate");
            mpTitle.Text = "Levykauppa X";
            mpDate.Text = "13.10.2016";
        }
        //luetaan xml-tiedostosta levyjen tiedot ja esitetään ne GridViessä
        try
        {
            XmlDocument doc = new XmlDocument();
            doc = xmlLevykauppaX.GetXmlDocument();
            String mstrISBN = "";
            String mstrArtist = "";
            String mstrTitle = "";
            String mstrPrice = "";

            //XmlNode node1 = doc.SelectSingleNode("/Records/genre/record");
            XmlNodeList nodes = doc.SelectNodes("/Records/genre/record");
            myDiv.InnerHtml += "<table>";
            foreach (XmlNode item in nodes)
            {
                mstrISBN = item.Attributes["ISBN"].Value;
                mstrArtist = item.Attributes["Artist"].Value;
                mstrTitle = item.Attributes["Title"].Value;
                mstrPrice = item.Attributes["Price"].Value;

                myDiv.InnerHtml += string.Format("<tr><td><img src='/Images/{0}' alt='{0}' style='height:50px' /></td>", mstrISBN + ".jpg");
                myDiv.InnerHtml += string.Format("<td>{0} : {1}<br />ISBN : <a href='Tehtava_6_LevynTiedot.aspx?ISBN={2}' target='_blank'>{2}</a><br />Hinta:{3}</td></tr>", mstrArtist, mstrTitle, mstrISBN, mstrPrice);
            }

            myDiv.InnerHtml += "</table>";
            mpMessage.Text = "lkm: " + nodes.Count;

        }
        catch (Exception ex)
        {
            mpMessage.Text = ex.Message;
        }
    }
}