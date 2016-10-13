using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Demo6_feedit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        {
            Label mpTitle = (Label)Page.Master.FindControl("lblTitle");
            Label mpDate = (Label)Page.Master.FindControl("lblDate");
            Label mpUsername = (Label)Page.Master.FindControl("lblUsername");
            Label mpLabel = (Label)Page.Master.FindControl("lblMessage");
            //mpUsername.Text = JAMK.IT.CommonCodes.AppSetting("Username");
            mpTitle.Text = "Demo RSS-feed luku harjoitus";
            mpDate.Text = "13.10.2016";
        }
    }

    protected void btnGetFeeds_Click(object sender, EventArgs e)
    {
        //asetetaan xml datasourcen data lähteeksi IS:n rss feedi
        string url = @"http://www.iltasanomat.fi/rss/tuoreimmat.xml";
        myDataSource.DataFile = url;
        GetFeeds();
    }


    protected void btnGetFeedsYLE_Click(object sender, EventArgs e)
    {
        //asetetaan xml datasourcen data lähteeksi IS:n rss feedi
        string url = @"http://feeds.yle.fi/uutiset/v1/majorHeadlines/YLE_UUTISET.rss";
        myDataSource.DataFile = url;
        GetFeeds();
    }



    private void GetFeeds()
    {
        try
        {
            //käytetään XmlDocument luokkaa ja sen metodeja, ominaisuuksia
            XmlDocument doc = new XmlDocument();
            doc = myDataSource.GetXmlDocument();
            //aluksi haetaan kanavan tietoja
            XmlNode node1 = doc.SelectSingleNode("/rss/channel");
            string title = node1["title"].InnerText;
            myDiv.InnerHtml = string.Format("<h1>{0} {1}</h1>", title, DateTime.Now.ToString());
            //haetaan kaiki item-elementit ja loopataan ne läpi
            XmlNodeList nodes = doc.SelectNodes("/rss/channel/item");
            string cat;
            string link;
            string piclink;
            foreach (XmlNode item in nodes)
            {
                //haetaan kuvan url, jos sellainen on
                if (item["enclosure"] != null)
                {
                    piclink = item["enclosure"].GetAttribute("url");
                }
                else
                {
                    piclink = "";
                }
                myDiv.InnerHtml += string.Format("<img src='{0}' alt='kuva' style='height:50px' />", piclink);

                //title, link category luetaan elementeistä
                cat = item["category"].InnerText;
                title = item["title"].InnerText;
                link = item["link"].InnerText;


                myDiv.InnerHtml += string.Format("{0} : <a href='{1}'>{2}</a>", cat, link, title);
                myDiv.InnerHtml += "<br />";
            }
        }
        catch (Exception ex)
        {
            myDiv.InnerHtml = ex.Message;
        }
    }

}