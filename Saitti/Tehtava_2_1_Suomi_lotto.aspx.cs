using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tehtava_2_1_Suomi_lotto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnArvoNumerot_Click(object sender, EventArgs e)
    {
       
        try
        {
            //DataTable dt = JAMK.ICT.Data.DBPlacebo.Get3TestStudents();
            int intRivienLukumaara = intRivienLukumaara = Convert.ToInt16(txtRivienLukumaara.Text);
            DataTable dtLotto = JAMK.ICT.BL.Lottoaja.ArvoLottoNumerot("Suomi-lotto", 7, 39, intRivienLukumaara);

            gvArvotutnumerot.DataSource = dtLotto;
            gvArvotutnumerot.DataBind();
        }

        catch (Exception ex)
        {
            DataTable dtLotto = JAMK.ICT.BL.Lottoaja.ArvoLottoNumerot("Suomi-lotto", 7, 39, 0);
            gvArvotutnumerot.DataSource = dtLotto;
            gvArvotutnumerot.DataBind();
            lblMessages.Text = ex.Message;
        }
    }
}