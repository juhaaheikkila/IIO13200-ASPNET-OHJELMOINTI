using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.Net;
using JAMK.IT;
using System.Data;
using System.Text;

public partial class Default5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //DropDownList lstLocations;
            Label mpTitle = (Label)Page.Master.FindControl("lblTitle");
            Label mpDate = (Label)Page.Master.FindControl("lblDate");
            Label mpUsername = (Label)Page.Master.FindControl("lblUsername");
            Label mpLabel = (Label)Page.Master.FindControl("lblMessage");
            //mpUsername.Text = JAMK.IT.CommonCodes.AppSetting("Username");
            mpTitle.Text = "Viikkotehtävä 5, VR:n junatiedot JSON.NET";
            mpDate.Text = "29.9.2016";
            mpUsername.Text = System.Configuration.ConfigurationManager.AppSettings["Username"];
            string json = GetJsonFrom("http://rata.digitraffic.fi/api/v1/metadata/stations");
            List<Station> asemat = JsonConvert.DeserializeObject<List<Station>>(json);
            foreach (var asema in asemat)
            {
                lstLocations.Items.Add(new ListItem(asema.stationName, asema.stationShortCode));
            }
            lstLocations.Items.Add(new ListItem("Valitse asema", ""));
            lstLocations.Items.FindByValue("").Selected = true;

            /*
            lstLocations.Items.Add(new ListItem("Jyväskylä", "JKL"));
            lstLocations.Items.Add(new ListItem("Helsinki", "HKI"));
            lstLocations.Items.Add(new ListItem("Tampere", "TRE"));
            lstLocations.Items.Add(new ListItem("Valitse asema", ""));
            lstLocations.Items.FindByValue("").Selected=true;
            */
        }


    }

    protected void btnGetTrain_Click(object sender, EventArgs e)
    {
        if (lblSelectedLocation.Text != "" && lblSelectedLocation.Text != "...")
        {
            string json = GetJsonFrom("http://rata.digitraffic.fi/api/v1/live-trains?station=" + lblSelectedLocation.Text);

            //JAMK.IT.Person p = Newtonsoft.Json.JsonConvert.DeserializeObject<Person>(json);
            //p-olion tiedot näkyviin
            List<Train> junat = JsonConvert.DeserializeObject<List<Train>>(json);
            ltResult.Text = string.Format("Löytyi json: " + json.Length);
            //DataTable dtJunat = JAMK.ICT.BL.LottoArvonta.dtArvoLottoNumerot(gstrTitle, gintNumeroita, gintRuudukkoAlkaa, gintRuudukko, intRivienLukumaara);

            //gvArvotutnumerot.DataSource = dtLotto;
            //gvArvotutnumerot.DataBind();
            gvTrainInfo.DataSource = junat;
            gvTrainInfo.DataBind();
            //DataTable dtJunat = JAMK.IT.DBDemoxOy.GetDataReal();
        }
        else
        {
            ltResult.Text = "Valitse asema ensin!";
        }
    }

    protected string GetJsonFrom(string url)
    {
        using (WebClient wc = new WebClient())
        {
            wc.Encoding = Encoding.UTF8;
            var json = wc.DownloadString(url);
            return json;
        }
    }

    protected void lstLocations_SelectedIndexChanged(object sender, EventArgs e)
    {
        string valittuna = lstLocations.SelectedValue;
        lblSelectedLocation.Text = valittuna;

    }
}