using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Demo9_BookShop : System.Web.UI.Page
{
    Label mpTitle;


    protected static BookShopEntities ctx;
    protected static bool KustiValittu;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {


            mpTitle = (Label)Page.Master.FindControl("lblTitle");
            Label mpDate = (Label)Page.Master.FindControl("lblDate");
            //Label mpUsername = (Label)Page.Master.FindControl("lblUsername");
            Label mpLabel = (Label)Page.Master.FindControl("lblMessage");
            //mpUsername.Text = JAMK.IT.CommonCodes.AppSetting("Username");
            mpTitle.Text = "ENTITY FRAMEWORK - Bookstore";
            mpDate.Text = "3.11.2016";

            //ctx:ään tiedot vain kerran ja kontrollien populointi
            ctx = new BookShopEntities();
            FillControls();

        }

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
        var retval = ctx.Customers.OrderBy(x => x.lastname);

        ddlCustomers.DataSource = retval.ToList();
        ddlCustomers.DataTextField = "lastname";
        ddlCustomers.DataValueField = "id";
        ddlCustomers.DataBind();
        //lisätään tyhjä alkio ddl:ään
        ddlCustomers.Items.Insert(0, string.Empty);
        //CRUDia varten
        txtFirstName.Text = string.Empty;
        txtLastName.Text = string.Empty;
        SetButtons();

    }

    protected void SetButtons()
    {
        //buttosten käytettävyyden hallinta
        btnNewCustomer.Enabled = !KustiValittu;
        btnSaveCustomer.Enabled = KustiValittu;
        btnDeleteCustomer.Enabled = KustiValittu;
    }

    protected void ShowCustomers()
    {
        gvCustomers.DataSource = ctx.Customers.ToList();
        gvCustomers.DataBind();
        int i = ctx.Customers.Count();
        lblMessages.Text = string.Format("Haettu {0} asiakkaan tiedot", i);
    }
    protected void ShowBooks()
    {
        gvBooks.DataSource = ctx.Books.ToList();
        gvBooks.DataBind();
        int i = ctx.Books.Count();
        lblMessages.Text = string.Format("Haettu {0} kirjan tiedot", i);
    }
    protected void ShowCustomersOrders(Customers kusti)
    {
        ltResult.Text = string.Format("Asiakkaalla {0} {1} on {2} tilausta", kusti.firstname, kusti.lastname, kusti.Orders.Count());
        //loopataan asiakkana tilaukset läpi
        foreach (var o in kusti.Orders)
        {
            ltResult.Text += string.Format("<br />- tilaus {0} sisältää {1} kirjaa:", o.odate, o.Orderitems.Count());
            //loopataan tilauksen tilausrivit
            foreach (var oi in o.Orderitems)
            {
                ltResult.Text += string.Format("<br />-- kirjaa {0}, {1} kpl {2}", oi.Books.name, oi.Books.author, oi.count);
            }
        }
    }

    #endregion
    protected void btnGetCustomers_Click(object sender, EventArgs e)
    {
        ShowCustomers();
    }

    protected void btnGetBooks_Click(object sender, EventArgs e)
    {
        ShowBooks();
    }

    protected void ddlCustomers_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlCustomers.SelectedIndex > 0)
        {
            //valitun asiakkaan indeksin perusteella 
            int id = int.Parse(ddlCustomers.SelectedValue);
            var ret = from c in ctx.Customers
                      where c.id == id
                      select c;
            Customers kusti = ret.FirstOrDefault();
            ShowCustomersOrders(kusti);
            KustiValittu = true;
            txtFirstName.Text = kusti.firstname;
            txtLastName.Text = kusti.lastname;
            SetButtons();
        }
        else
        {
            KustiValittu = false;
            ltResult.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            SetButtons();
        }
    }

    protected void btnNewCustomer_Click(object sender, EventArgs e)
    {
        // luodaan uusi asiakas kontekstiin jollei samannimistä ole
        //tsekkaus LINQ_lla
        bool isThere = ctx.Customers.Any(c => (c.firstname.Contains(txtFirstName.Text) & c.lastname.Contains(txtLastName.Text)));
        if (isThere)
        {
            lblMessages.Text = string.Format("Asiakas {0} on jo olemassa.", txtLastName.Text);

        }
        else
        {
            //luodaan uusi customer entiteetti
            Customers kusti = new Customers();
            kusti.firstname = txtFirstName.Text;
            kusti.lastname = txtLastName.Text;
            ctx.Customers.Add(kusti);
            //kontekstin tallennus kantaan
            ctx.SaveChanges();
            //ilmoitukset ui:hin
            lblMessages.Text = string.Format("Uusi asiakas {0} {1} {2} luotu onnistuneesti.", kusti.firstname, kusti.firstname, kusti.id);
            FillControls();
        }
    }

    protected void btnSaveCustomer_Click(object sender, EventArgs e)
    {
        //haetaan valitun asiakkaan id
        int i = int.Parse(ddlCustomers.SelectedValue);
        if (i>0)
        {
            var ret = ctx.Customers.Where(c => c.id == i);
            Customers kusti = ret.FirstOrDefault();
            if (kusti != null)
            {
                if (kusti.firstname != txtFirstName.Text)
                {
                    kusti.firstname = txtFirstName.Text;
                }
                if (kusti.lastname != txtFirstName.Text)
                {
                    kusti.lastname = txtLastName.Text;
                }
                ctx.SaveChanges();

                FillControls(); // UI ajantasalle

                
            }

        }
    }

    protected void btnDeleteCustomer_Click(object sender, EventArgs e)
    {
        //haetaan valitun asiakkaan id
        int i = int.Parse(ddlCustomers.SelectedValue);
        if (i > 0)
        {
            var ret = ctx.Customers.Where(c => c.id == i);
            Customers kusti = ret.FirstOrDefault();
            if (kusti != null)
            {
                //poistetaan
                //????
                ctx.Customers.Remove(kusti);
                ctx.SaveChanges();

                FillControls(); // UI ajantasalle


            }

        }
    }
}