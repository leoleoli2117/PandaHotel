using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class Delete : System.Web.UI.Page
{
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
    }

    void DeleteCustomer()
    {

        clsCustomerCollection AllCustomer = new clsCustomerCollection();

        AllCustomer.ThisCustomer.Find(CustomerId);

        AllCustomer.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        DeleteCustomer();

        Response.Redirect("Default.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}