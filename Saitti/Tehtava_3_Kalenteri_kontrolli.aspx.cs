using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tehtava_3_Kalenteri_kontrolli : System.Web.UI.Page
{
    private DateTime dtToday;

    protected void Page_Load(object sender, EventArgs e)
    {
        dtToday = DateTime.Today;


        if (!IsPostBack)
        {
            lblToday.Text = dtToday.ToString("d");
            txtDate.Text = dtToday.ToString("d");
            // Calendar1.Visible = false;
            resetCalculationsAndShowMessage(null, "Alustetaan päivämäärälaskennat.");
        }

    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        txtDate.Text = Calendar1.SelectedDate.ToShortDateString();
        DateTime dtSelectedDate;
        dtSelectedDate = Calendar1.SelectedDate;
        calculateDateDifference(dtSelectedDate);
    }

    protected void txtDate_TextChanged(object sender, EventArgs e)
    {
        try
        {
            string strSelectedDate = txtDate.Text;
            DateTime dtSelectedDate = Convert.ToDateTime(strSelectedDate);
            calculateDateDifference(dtSelectedDate);
        }
        catch (Exception ex)
        {
            resetCalculationsAndShowMessage(ex, "");
        }
    }
    private void resetCalculationsAndShowMessage(Exception vex, string vstrMessage)
    {

        lblResult.Text = "...";
        lblSelectedDate.Text = "";
        if (vex != null)
        {
            lblMessages.Text = vex.Message;
        }
        else
        {
            lblMessages.Text = vstrMessage;
        }
    }
    private void calculateDateDifference(DateTime dtSelectedDate)
    {
        try
        {
            double dblDateDifferenceinSeconds = 0;
            long dblDifference = 0;
            string mstrMessage = "Päivämäärän erotus laskettuna: <br />";
            lblSelectedDate.Text = dtSelectedDate.ToString("d");
            dblDateDifferenceinSeconds = dtToday.Subtract(dtSelectedDate).TotalSeconds;
            dblDifference = (long)dblDateDifferenceinSeconds / 60 / 60 / 24;

            long lngYear = (long)(dblDifference / 365);
            long lngDays = dblDifference - lngYear * 365;

            mstrMessage += Convert.ToString(lngYear) + " vuosia ";
            mstrMessage += Convert.ToString(lngDays) + " päiviä<br />";
            lblResult.Text = mstrMessage;
            if (dtSelectedDate < dtToday)
            {
                lblMessages.Text = "Päivämäärä erotus laskettu: " + dtSelectedDate.ToShortDateString() + " - " + dtToday.ToShortDateString();
            }
            else
            {
                lblMessages.Text = "Päivämäärä erotus laskettu: " + dtToday.ToShortDateString() + " - " + dtSelectedDate.ToShortDateString();
            }
        }
        catch (Exception ex)
        {
            resetCalculationsAndShowMessage(ex, "");
        }
    }

    protected void btnOpenCalendar_Click(object sender, EventArgs e)
    {
        //Calendar1.Visible = !Calendar1.Visible;
    }
}