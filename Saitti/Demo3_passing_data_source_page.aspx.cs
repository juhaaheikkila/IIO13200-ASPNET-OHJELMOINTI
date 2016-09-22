using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Demo3_passing_data_source_page : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnQuery_Click(object sender, EventArgs e)
    {
        //we will use standard redirtion with Redirect
        Response.Redirect("Demo3_passing_data_target_page.aspx?user=Esa&Message="+txtMessage.Text);

    }

    protected void btnSession_Click(object sender, EventArgs e)
    {
        //kirjoitetaan Sessioniin ja siirrytään toiselle sivulle
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
}