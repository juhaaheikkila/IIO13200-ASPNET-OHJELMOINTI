using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Tehtava_6_LevynTiedot : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label mpMessage = (Label)Page.Master.FindControl("lblMessage"); ;
        if (!IsPostBack)
        {
            Label mpTitle = (Label)Page.Master.FindControl("lblTitle");
            Label mpDate = (Label)Page.Master.FindControl("lblDate");
            mpTitle.Text = "Levykauppa X - Levyn tiedot";
            mpDate.Text = "13.10.2016";
        }
        string mstrISBN = Request.QueryString["ISBN"];

        try
        {
            XmlDocument doc = new XmlDocument();
            doc = xmlLevykauppaX.GetXmlDocument();
            //String mstrISBN = "";
            String mstrArtist = "";
            String mstrTitle = "";
            String mstrPrice = "";


            //XmlNode node1 = doc.SelectSingleNode("/Records/genre/record");
            XmlNodeList nodes = doc.SelectNodes("/Records/genre/record");
            myDiv.InnerHtml = "<table>";
            foreach (XmlNode item in nodes)
            {
                if (mstrISBN.Equals(item.Attributes["ISBN"].Value))
                {
                    mstrArtist = item.Attributes["Artist"].Value;
                    mstrTitle = item.Attributes["Title"].Value;
                    mstrPrice = item.Attributes["Price"].Value;
                    myDiv.InnerHtml += string.Format("<tr><td><img src='/Images/{0}' alt='{0}' style='height:150px' /></td></tr>", mstrISBN + ".jpg");
                    myDiv.InnerHtml += string.Format("<tr><td>{0}  {1}</td></tr>", mstrArtist, mstrTitle);
                    myDiv.InnerHtml += string.Format("<tr><td>ISBN: {0}</td></tr>", mstrISBN);
                    myDiv.InnerHtml += string.Format("<tr><td>Hinta: {0}</td></tr>", mstrPrice);
                    myDiv.InnerHtml += "<tr><td>Levyn biisit:</td></tr>";
                    XmlNodeList piisit = item.ChildNodes;
                    foreach (XmlNode piisi in piisit)
                    {
                        if (piisi.Name.Equals("song"))
                        {
                            String mstrNo = piisi.Attributes["num"].Value;
                            String mstrName = piisi.Attributes["name"].Value;
                            String mstrValue = piisi.InnerText;
                            myDiv.InnerHtml += string.Format("<tr><td>{0} : {1} {2}</td></tr>", mstrNo, mstrName, mstrValue);
                        }
                    }
                }

                

            }
            myDiv.InnerHtml += "</table>";
        }
        catch (Exception ex)
        {
            mpMessage.Text = ex.Message;
        }

    }
}