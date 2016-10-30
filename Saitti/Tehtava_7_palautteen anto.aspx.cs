using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public class Palaute
{
    public string pvm { get; set; }
    public string tekija { get; set; }
    public string opittu { get; set; }
    public string haluanoppia { get; set; }
    public string hyvaa { get; set; }
    public string parannettavaa { get; set; }
    public string muuta { get; set; }




    public Palaute()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}

public partial class Tehtava_7_palautteen_anto : System.Web.UI.Page
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
            Label mpUsername = (Label)Page.Master.FindControl("lblUsername");


            //mpUsername.Text = JAMK.IT.CommonCodes.AppSetting("Username");
            mpTitle.Text = "Viikkotehtävä 7, Palautteen anto";
            mpDate.Text = "27.10.2016";
            txtDate.Text = DateTime.Today.ToShortDateString();

            // mpUsername.Text = System.Configuration.ConfigurationManager.AppSettings["Username"];
        }
        mpMessage = (Label)Page.Master.FindControl("lblMessage");
        debug = (CheckBox)Page.Master.FindControl("chkDebug");
        //debug.Checked = true;
        gblnDebug = debug.Checked;


        //XML-tiedostosta
        XmlDocument doc = new XmlDocument();
        doc.Load(Server.MapPath("~/App_Data/Palautteet.xml"));
        XmlNodeList nodes = doc.SelectNodes("/palautteet/palaute");
        lblAnnetutPalautteetXML.Text = nodes.Count + " kpl";

        //haetaan XML-data DataView-olioon, joka kytketään GridViewhen
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DataView dv = new DataView();
        String xmlfilu = ConfigurationManager.AppSettings["palautetiedosto"];
        ds.ReadXml(Server.MapPath(xmlfilu));//huom MapPath muuttaa viittauksen websaitille
        dt = ds.Tables[0];
        dv = dt.DefaultView;
        gvPalautteet.DataSource = dv;
        gvPalautteet.DataBind();

        //MySQL kannasta
        try
        {
            string cs = System.Configuration.ConfigurationManager.ConnectionStrings["MysliEsa"].ConnectionString;
            DataTable dtMySQL = JAMK.ICT.Data.DBPlacebo.GetFeedbackFromMysql(cs);
            gvMySqlPalaute.DataSource = dtMySQL;
            gvMySqlPalaute.DataBind();

            lblAnnetutPalautteetMySQL.Text = gvMySqlPalaute.Rows.Count.ToString() + " kpl";
        }
        catch (Exception ex)
        {

            mpMessage.Text += "<br />" + ex.Message;
        }
    }





    protected void txtDate_TextChanged(object sender, EventArgs e)
    {
        try
        {

            string strSelectedDate = txtDate.Text;
            DateTime dtSelectedDate = Convert.ToDateTime(strSelectedDate);

            mpMessage.Text = "valittu päivämäärä: " + dtSelectedDate.ToShortDateString();



        }
        catch (Exception ex)
        {
            txtDate.Text = "";
            mpMessage.Text = "";
            if (gblnDebug)
            {
                validateDate.Text = "Pvm - kenttään syötetty arvo: " + txtDate.Text + " < br /> " + ex.Message;
                mpMessage.Text = "Pvm-kenttään syötetty arvo: " + txtDate.Text + "<br />" + ex.Message;
            }
        }
    }

    protected void btnSendFeedBackXML_Click(object sender, EventArgs e)
    {
        // XmlDataSource xmlPalauteFile = srcPalautteet;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DataView dv = new DataView();
        String xmlfilu = ConfigurationManager.AppSettings["palautetiedosto"];
        ds.ReadXml(Server.MapPath(xmlfilu));//huom MapPath muuttaa viittauksen websaitille
        dt = ds.Tables[0];
        DataRow newFeedbackRow = dt.NewRow();

        if (!"".Equals(txtDate.Text))
        {
            newFeedbackRow["pvm"] = txtDate.Text;
            txtDate.Text = "";
        }
        else
        {
            validateDate.Text = "Puuttuu";
            return;

        }

        newFeedbackRow["tekija"] = txtName.Text;
        txtName.Text = "";

        newFeedbackRow["opittu"] = txtOlenOppinut.Text;
        txtOlenOppinut.Text = "";

        newFeedbackRow["haluanoppia"] = txtHaluanOppia.Text;
        txtHaluanOppia.Text = "";

        newFeedbackRow["hyvaa"] = txtGoodStuff.Text;
        txtGoodStuff.Text = "";

        newFeedbackRow["parannettavaa"] = txtNotSoGoodStuff.Text;
        txtNotSoGoodStuff.Text = "";

        newFeedbackRow["muuta"] = txtOther.Text;
        txtOther.Text = "";

        dt.Rows.Add(newFeedbackRow);
        dt.AcceptChanges();
        ds.AcceptChanges();
        ds.WriteXml(Server.MapPath(xmlfilu));

        //päivitetään selain
        //Response.Redirect(Request.RawUrl);
        mpMessage.Text = "palaute lisätty";

    }

    //    public DataRow palauteRivi(DataTable rdt, string pvm, string tekija, string opittu, string haluanoppia, string hyvaa, string parannettavaa, string muuta)
    //    {
    //DataRow newRow = rdt.NewRow();
    //    }

    protected void btnSendFeedBackMySQL_Click(object sender, EventArgs e)
    {
        string sqlQuery = "";

        try
        {
            //yhteys labranetin myslille ja palautetaan taulu City DataTablena

            string csMySQL = System.Configuration.ConfigurationManager.ConnectionStrings["MysliEsa"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(csMySQL))
            {
                conn.Open();

                sqlQuery = "INSERT INTO palaute ";

                sqlQuery += "(opintojakso, pvm, tekija, opittu, haluanoppia, hyvaa, parannettavaa, muuta) ";
                sqlQuery += "VALUES('IIO13200'";

                DateTime dtSelectedDate = Convert.ToDateTime(txtDate.Text);

                sqlQuery += ", STR_TO_DATE('" + dtSelectedDate.Day + "-" + dtSelectedDate.Month + "-" + dtSelectedDate.Year + "', '%d-%m-%Y')";
                txtDate.Text = "";

                sqlQuery += ", '" + txtName.Text + "'";
                txtName.Text = "";

                sqlQuery += ", '" + txtOlenOppinut.Text + "'";
                txtOlenOppinut.Text = "";

                sqlQuery += ", '" + txtHaluanOppia.Text + "'";
                txtHaluanOppia.Text = "";

                sqlQuery += ", '" + txtGoodStuff.Text + "'";
                txtGoodStuff.Text = "";

                sqlQuery += ", '" + txtNotSoGoodStuff.Text + "'";
                txtNotSoGoodStuff.Text = "";

                sqlQuery += ", '" + txtOther.Text + "'); ";
                txtOther.Text = "";

                mpMessage.Text = "query :" + sqlQuery;
                using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
               
            }

        }
        catch (Exception ex)
        {
            throw ex;
        }


    }

    protected void btnShowFeedback_Click(object sender, EventArgs e)
    {
        divTables.Visible = !divTables.Visible;
        btnShowFeedback.Text = divTables.Visible ? "Piilota annetut palautteet" : "Näytä annetut palautteet";
    }
}