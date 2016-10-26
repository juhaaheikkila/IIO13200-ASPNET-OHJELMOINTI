using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{

    string ButtonCaptionShow = "Näytä kuvaus";
    string ButtonCaptionHide = "Piilota kuvaus";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            setbuttonCaptions();
        }
        lblMessage.Text = "refreshing " + DateTime.Now.ToString("h:mm:ss tt");

    }

    protected void btnShowHideInfo_Click(object sender, EventArgs e)
    {
        //   string sendId = sender.ClientID;
        Button btnShowHide = (Button)sender;
        string strButtonIndex = "";

        strButtonIndex = btnShowHide.ID;
        strButtonIndex = strButtonIndex.Substring(strButtonIndex.IndexOf("_") + 1);

        if (strButtonIndex == "1")
            Tehtävä_Info_1.Visible = !Tehtävä_Info_1.Visible;
        else if (strButtonIndex == "2")
            Tehtävä_Info_2.Visible = !Tehtävä_Info_2.Visible;
        else if (strButtonIndex == "3")
            Tehtävä_Info_3.Visible = !Tehtävä_Info_3.Visible;
        else if (strButtonIndex == "4")
            Tehtävä_Info_4.Visible = !Tehtävä_Info_4.Visible;
        //else if (strButtonIndex == "5")
        //    Tehtävä_Info_5.Visible = !Tehtävä_Info_5.Visible;
        else if (strButtonIndex == "6")
            Tehtävä_Info_6.Visible = !Tehtävä_Info_6.Visible;
        else if (strButtonIndex == "8")
            Tehtävä_Info_8.Visible = !Tehtävä_Info_8.Visible;
        else if (strButtonIndex == "9")
            Tehtävä_Info_9.Visible = !Tehtävä_Info_9.Visible;


        setbuttonCaptions();
    }
    void setbuttonCaptions()
    {
        btnShowHide_1.Text = Tehtävä_Info_1.Visible ? ButtonCaptionHide : ButtonCaptionShow;
        btnShowHide_2.Text = Tehtävä_Info_2.Visible ? ButtonCaptionHide : ButtonCaptionShow;
        btnShowHide_3.Text = Tehtävä_Info_3.Visible ? ButtonCaptionHide : ButtonCaptionShow;
        btnShowHide_4.Text = Tehtävä_Info_4.Visible ? ButtonCaptionHide : ButtonCaptionShow;
        btnShowHide_6.Text = Tehtävä_Info_6.Visible ? ButtonCaptionHide : ButtonCaptionShow;
        btnShowHide_8.Text = Tehtävä_Info_8.Visible ? ButtonCaptionHide : ButtonCaptionShow;
    }
}