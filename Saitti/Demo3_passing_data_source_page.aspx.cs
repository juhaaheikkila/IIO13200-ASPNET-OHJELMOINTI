using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Demo3_passing_data_source_page : System.Web.UI.Page
{
    public string SecretMessage
    {
        get { return txtMessage.Text; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        //alustetaan kontrollit jne VAIN KERRAN
        if (!IsPostBack)
        {
            ddlMessages.Items.Add("Hello.");
            ddlMessages.Items.Add("Ping?");
            ddlMessages.Items.Add("Handshake?");
            ddlMessages.Items.Add("Goodby!");
        }
    }

    protected void btnQuery_Click(object sender, EventArgs e)
    {
        //we will use standard redirtion with Redirect
        if (Page.IsValid)
        {
            Response.Redirect("Demo3_passing_data_target_page.aspx?user=Esa&Message=" + txtMessage.Text);
        }

        //testing
    }

    protected void btnSession_Click(object sender, EventArgs e)
    {
        //kirjoitetaan Sessioniin ja siirrytään toiselle sivulle
        if (!Page.IsValid)
        {

        }
        Session["Message"] = txtMessage.Text;
        Response.Redirect("Demo3_passing_data_target_page.aspx");
    }

    protected void btnCookie_Click(object sender, EventArgs e)
    {
        //luodaan keksi ja kirjoitetaan siihen viesti
        HttpCookie cookie = new HttpCookie("Message", txtMessage.Text);
        cookie.Expires = DateTime.Now.AddMinutes(15);
        Response.Cookies.Add(cookie);

    }

    protected void btnPublicProperty_Click(object sender, EventArgs e)
    {
        Server.Transfer("Demo3_passing_data_target_page.aspx");

    }

    protected void ddlMessages_SelectedIndexChanged(object sender, EventArgs e)
    {
        //kirjoitetaan valittu vakioteksti txtboxiin
        txtMessage.Text = ddlMessages.SelectedItem.ToString();

    }


    protected void txtMessage_TextChanged(object sender, EventArgs e)
    {

    }
}