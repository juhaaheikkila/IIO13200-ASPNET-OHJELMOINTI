using System;
using System.Data; //ADO.NETin kaikki data perusluokat ml DataTable
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HaeOppilaatIlta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGet3_Click(object sender, EventArgs e)
    {
        //haetaan valmiilta luokan metodilta dataa ja kiinnitetään se tähän data sidonnaiseen kontrolliin
        DataTable dt = JAMK.ICT.Data.DBPlacebo.Get3TestStudents();
        gvStudents.DataSource = dt;
        gvStudents.DataBind();

    }

    protected void btnGetAll_Click(object sender, EventArgs e)
    {
        string strCs = System.Configuration.ConfigurationManager.ConnectionStrings["oppilaat"].ConnectionString;
        string messu = "";
        try
        {
            DataTable dt = JAMK.ICT.Data.DBPlacebo.GetAllStudentsFromSQLServer(strCs, "oppilaat", out messu);
            gvStudents.DataSource = dt;
            gvStudents.DataBind();
        }
        catch (Exception ex)
        {
            //mihin poikkeus messu kirjoitetaan. myös UIhin joku elementti, jonne viesti viedään!!
            lblMessages.Text = ex.Message;
            
        }
            
            }

    protected void btnGetOppilaat_Click(object sender, EventArgs e)
    {
        //haetaan valmiista businesslogiikasta oppilas olioita ja 
        //kiinnitetään ne kontrollin datasourceksi
        var oppilaat = new JAMK.ICT.BL.Oppilaat().Hae3TestiOppilasta();
        gvStudents.DataSource = oppilaat;
        gvStudents.DataBind();

    }
}