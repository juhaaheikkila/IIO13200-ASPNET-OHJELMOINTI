using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JAMK.IT;
using Newtonsoft.Json;


public partial class JSONDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGetPerson_Click(object sender, EventArgs e)
    {
        //muutetaan luettu json Person-olioksi
        try
        {
            string json = GetJsonFrom("http://student.labranet.jamk.fi/~salesa/mat/JsonTestP");
            JAMK.IT.Person p = Newtonsoft.Json.JsonConvert.DeserializeObject<Person>(json);
            //p-olion tiedot näkyviin
            ltResult.Text = string.Format("Löytyi henkilö {0}, syntynyt {1}", p.Name, p.Birthday);
        }
        catch (Exception ex)
        {
            ltResult.Text = ex.Message;
        }
    }

    protected void btnGet_Click(object sender, EventArgs e)
    {
        //haetaan JSON ja näytetään se UI_ssä
        try
        {
            string json = GetJsonFrom("http://student.labranet.jamk.fi/~salesa/mat/JsonTestP");
            ltResult.Text = json;
        }
        catch (Exception ex)
        {
            ltResult.Text = ex.Message;
        }
    }

    protected string GetJsonFrom(string url)
    {
        using (WebClient wc = new WebClient())
        {
            var json = wc.DownloadString(url);
            return json;
        }
    }



    protected void btnGetPolitics_Click(object sender, EventArgs e)
    {
        //muutetaan Json Politician -oliokokoelmaksi
        //muutetaan luettu json Person-olioksi
        try
        {
            string json = GetJsonFrom("http://student.labranet.jamk.fi/~salesa/mat/JsonTest");
            List<Politician> hallitus = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Politician>>(json);
            //poliitikko-olion tiedot näkyviin
            string ret = "<h2>Suomen vankka hallitus</h2><ul>";
            foreach (var ministeri in hallitus)
            {
                ret += "<li>" + ministeri.Name + " " + ministeri.Party + "</li>";
            }
            ret += "</ul>";
            ltResult.Text = ret;
        }
        catch (Exception ex)
        {
            ltResult.Text = ex.Message;
        }
    }
}