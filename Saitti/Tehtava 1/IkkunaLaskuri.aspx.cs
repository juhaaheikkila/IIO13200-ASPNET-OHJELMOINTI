using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class Tehtava_1_IkkunaLaskuri : System.Web.UI.Page
{
    string LINEFEED = "<br />";

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    double getValue(string stringValue)
    {
        double valuena;
        try
        {
            valuena = Convert.ToDouble(stringValue);
            return valuena;
        }
        catch
        {
            return 0;
        }
    }


    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        double dblWidth;
        double dblLength;
        double dblHeight;
        double dblArea;
        double dblCircuit;

        lblMessage.Text = "";
        dblLength = getValue(txtLength.Text) / 1000;
        dblHeight = getValue(txtHeight.Text) / 1000;
        dblWidth  = getValue(txtWidth.Text) / 1000;

        Console.WriteLine(dblLength);
        Console.WriteLine(dblHeight);
        Console.WriteLine(dblWidth);
        double dblPriceWOVAT;

        //calculations
        dblArea       = dblLength * dblHeight;
        dblCircuit    = 2 * (dblLength + dblHeight);
        dblPriceWOVAT = getPrice(dblArea, dblCircuit);

        lblIkkunanPintaAla.Text = dblArea.ToString("0.00");
        lblKarminPiiri.Text = dblCircuit.ToString("0.00");

        lblTarjousHinta.Text = dblPriceWOVAT.ToString("0.00");

        lblMessage.Text = 
            lblMessage.Text +
            "height: " + dblHeight.ToString ("0.000") + " m" + LINEFEED +
            "lengt: " + dblLength.ToString("0.000") + " m" + LINEFEED +
            "width: " + dblWidth.ToString("0.000") + " m" + LINEFEED +
            "area: " + dblArea.ToString("0.000") + " m2" + LINEFEED +
            "circuit: " + dblCircuit.ToString("0.000") + " m" + LINEFEED
            ;

        // dblWidth = Convert.ToDouble(txtWidth.Text);
        //  dblLength = Convert.ToDouble(txtLength.Text);
    }

    double getPrice(double windowArea, double windowCircuit)
    {
        //Tarjoushinta lasketaan seuraavanlaisella kaavalla:
        //Hinta(ilman alvia) = (1 + kate %) x((IkkunanPintaAla x LasinNeliohinta) + (KarminPiiri x AlumiiniKarminJuoksumetriHinta) +(Työmenekki))
        double dblOverHead              = getValue(ConfigurationManager.AppSettings["KS_KATE"]) / 100;
        double dblPriceWindowPerSquareM = getValue(ConfigurationManager.AppSettings["KS_LASINELIÖHINTA"]);
        double dblPriceAluminiumPerM    = getValue(ConfigurationManager.AppSettings["KS_ALUMIINIKARMIMETRIHINTA"]);
        double dblLoss                  = getValue(ConfigurationManager.AppSettings["KS_HÄVIKKI"]); ;
        double dblPriceWOVAT;
        dblPriceWOVAT = (1 + dblOverHead) * ((windowArea * dblPriceWindowPerSquareM)  + (windowCircuit * dblPriceAluminiumPerM) + (dblLoss));
        return dblPriceWOVAT;
    }


    protected void txtLength_TextChanged(object sender, EventArgs e)
    {
        double valuena = getValue(txtLength.Text);
       
    }
}