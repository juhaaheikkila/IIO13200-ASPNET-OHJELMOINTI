using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tehtava_5_Asiakastiedot_EntityFrameworkilla : System.Web.UI.Page
{
    protected static DemoxOyEntities ctx;
    protected static Label mpMessage;

    protected void Page_Load(object sender, EventArgs e)
    {
        Boolean gblnDebug = true;

        CheckBox debug;
        if (!IsPostBack)
        {
            //DropDownList lstLocations;
            Label mpTitle = (Label)Page.Master.FindControl("lblTitle");
            Label mpDate = (Label)Page.Master.FindControl("lblDate");
            //Label mpUsername = (Label)Page.Master.FindControl("lblUsername");
            mpMessage = (Label)Page.Master.FindControl("lblMessage");

            //mpUsername.Text = JAMK.IT.CommonCodes.AppSetting("Username");
            mpTitle.Text = "Viikkotehtävä 5, Asiakastiedot EntityFrameworkilla";
            mpDate.Text = "3.11.2016";
            ctx = new DemoxOyEntities();
            FillControls();
        }
        debug = (CheckBox)Page.Master.FindControl("chkDebug");
        gblnDebug = debug.Checked;
    }

    #region METHODS

    protected void FillControls()
    {
        //dropdownlist
        //var retval = ctx.Customers;
        //var retval = from c in ctx.Customers
        //              orderby c.lastname
        //              select c;
        // sama lambda tyylillä
        var retval = ctx.asiakas.OrderBy(x => x.maa);

        ddlCountries.DataSource = retval.ToList();
        ddlCountries.DataTextField = "maa";
        ddlCountries.DataValueField = "maa";
        ddlCountries.DataBind();
        //lisätään tyhjä alkio ddl:ään
        //ddlCountries.Items.Insert(0, string.Empty);
        ddlCountries.Items.Insert(0, "Hae asiakkaat valitusta maasta");
        ddlCountries.Items[0].Value = "";
        RemoveDuplicateItems(ddlCountries);
    }

    public static void RemoveDuplicateItems(DropDownList ddl)
    {
        for (int i = 0; i < ddl.Items.Count; i++)
        {
            ddl.SelectedIndex = i;
            string str = ddl.SelectedItem.ToString();
            for (int counter = i + 1; counter < ddl.Items.Count; counter++)
            {
                ddl.SelectedIndex = counter;
                string compareStr = ddl.SelectedItem.ToString();
                if (str == compareStr)
                {
                    ddl.Items.RemoveAt(counter);
                    counter = counter - 1;
                }
            }
        }
    }
    protected void addLiteral(Literal ltLiteral, string vstrValue)
    {
        ltLiteral.Text = vstrValue;
    }

    protected void appendToLiteral(Literal ltLiteral, string vstrToAppend)
    {
        ltLiteral.Text += vstrToAppend;
    }


    protected void ShowSelectedCustormers(string vSelectedCustomer)
    {
        var ret = from c in ctx.asiakas
                  where c.maa == vSelectedCustomer
                  select c;

        gvCustomers.DataSource = ret.ToList();
        gvCustomers.DataBind();
        int i = ret.Count();
        addLiteral(ltResult, string.Format("Haettu {0} asiakkaan tiedot, maa: {1}", i, vSelectedCustomer));

    }
    protected void ShowCustomers()
    {
        gvCustomers.DataSource = ctx.asiakas.ToList();
        gvCustomers.DataBind();
        int i = ctx.asiakas.Count();
        addLiteral(ltResult, string.Format("Haettu {0} asiakkaan tiedot", i));
    }

    protected int getCustomerCountByCountry(string strCountry)
    {
        int mintCount = 0;

        var ret = from c in ctx.asiakas
                  where c.maa == strCountry
                  select c;

        return ret.Count();
    }

    protected void showResult()
    {
        ResultList.Visible = true;
        NewCustomer.Visible = false;
        divNavigation.Visible = true;
    }

    protected void hideResult()
    {
        ResultList.Visible = false;
        NewCustomer.Visible = true;
        divNavigation.Visible = false;
    }

    #endregion

    protected void btnGetAllCustomers_Click(object sender, EventArgs e)
    {
        ShowCustomers();
        ddlCountries.SelectedValue = "";
        showResult();
    }

    protected void ddlCountries_SelectedIndexChanged(object sender, EventArgs e)
    {
        //valitun maan perusteella 
        string selectedCountry = "";
        selectedCountry = ddlCountries.SelectedValue;

        ShowSelectedCustormers(selectedCountry);
        showResult();
    }

    protected void btnGetAllCustomersByCountry_Click(object sender, EventArgs e)
    {
        var retval = ctx.asiakas.OrderBy(x => x.maa).ThenBy(x => x.asnimi);
        string mstrPrevCountry = "";
        addLiteral(ltResult, "Kaikki asiakkaat maittain");
        foreach (var c in retval.ToList())
        {
            if (!c.maa.Equals(mstrPrevCountry))
            {
                appendToLiteral(ltResult, string.Format("<h3>{0}: {1} kpl</h3>", c.maa, getCustomerCountByCountry(c.maa)));
            }

            appendToLiteral(ltResult, string.Format("{0} {1}<br />", c.asnimi, c.yhteyshlo));

            mstrPrevCountry = c.maa;
        }
        ddlCountries.SelectedValue = "";
        gvCustomers.DataSource = null;
        gvCustomers.DataBind();
        showResult();
    }

    protected void btnGetSelectedCustomers_Click(object sender, EventArgs e)
    {
        string selectedCountry = "";
        selectedCountry = ddlCountries.SelectedValue;

        ShowSelectedCustormers(selectedCountry);
        showResult();
    }



    protected void btnAddNewCustomer_Click(object sender, EventArgs e)
    {
        
        hideResult();
    }

    protected void btnCustomerSave_Click(object sender, EventArgs e)
    {
        asiakas newCustomer = new asiakas();

        newCustomer.astunnus = customerID.Text;
        newCustomer.asnimi = customerName.Text;
        newCustomer.yhteyshlo = customerContactPerson.Text;
        newCustomer.maa = customerCountry.Text;
        newCustomer.postitmp = customerZIP.Text;
        newCustomer.postinro = customerZIPCode.Text;
        newCustomer.ostot = Convert.ToDouble(customerBuys.Text);
        newCustomer.asvuosi = Convert.ToInt16(customerYear.Text);
        ctx.asiakas.Add(newCustomer);
        ctx.SaveChanges();
        Response.Redirect(Request.RawUrl);
        divNavigation.Visible = true;
    }

    protected void btnCustomerCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect(Request.RawUrl);
        divNavigation.Visible = true;
    }

}