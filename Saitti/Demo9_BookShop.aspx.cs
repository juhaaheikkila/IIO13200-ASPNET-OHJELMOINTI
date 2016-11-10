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

        //.Items.Add(new ListItem(strName, strID));
        //ddlCustomers
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
        } else
        {
            ltResult.Text = "...";
        }
    }
}