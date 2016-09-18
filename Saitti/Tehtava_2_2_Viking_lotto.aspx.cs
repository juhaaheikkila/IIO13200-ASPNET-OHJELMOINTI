using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tehtava_2_2_Viking_lotto : System.Web.UI.Page
{
    public string gstrTitle = "Viking-lotto"; // lotto
    public int gintRuudukko = 48; // ruudukon max
    public int gintNumeroita = 6; // arvottavien numeroiden lukumäärä
    protected void Page_Load(object sender, EventArgs e)
    {
        lblTitle.Text = gstrTitle;
    }

    protected void btnArvoNumerot_Click(object sender, EventArgs e)
    {

        try
        {
            //DataTable dt = JAMK.ICT.Data.DBPlacebo.Get3TestStudents();
            int intRivienLukumaara = intRivienLukumaara = Convert.ToInt16(txtRivienLukumaara.Text);
            DataTable dtLotto = JAMK.ICT.BL.Lottoaja.ArvoLottoNumerot(gstrTitle, gintNumeroita, gintRuudukko, intRivienLukumaara);

            gvArvotutnumerot.DataSource = dtLotto;
            gvArvotutnumerot.DataBind();
            //lblMessages.Text = 
        }

        catch (Exception ex)
        {
            DataTable dtLotto = JAMK.ICT.BL.Lottoaja.ArvoLottoNumerot("Suomi-lotto", 6, 48, 0);
            gvArvotutnumerot.DataSource = dtLotto;
            gvArvotutnumerot.DataBind();
            lblMessages.Text = ex.Message;
        }
    }
}