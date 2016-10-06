using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnGetCities_Click(object sender, EventArgs e)
    {
        try
        {
            //string cs = "server=mysql.labranet.jamk.fi;database=salesa;user=salesa;password=fyEfchdior3MZlrcjz6U27L0aiNolowl";
            string cs = System.Configuration.ConfigurationManager.ConnectionStrings["Mysli"].ConnectionString;
            DataTable dt = JAMK.ICT.Data.DBPlacebo.GetCitysFromMysql(cs);
            gvCities.DataSource = dt;
            gvCities.DataBind();
            
            lblMessage.Text= "cities count: " + gvCities.Rows.Count.ToString();
        }
        catch (Exception ex)
        {
            
            //lblMessage.Text = ex.Message;
        }
    }
}