using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class _Default : System.Web.UI.Page
{
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {
            DisplayCustomer();
            if (CustomerId!=-1)
            {
                DisplayCustomer();
            }
        }
    }

    public void DisplayCustomer()
    {
        clsCustomerCollection AllCustomer = new clsCustomerCollection();
        lstCustomer.DataSource = AllCustomer.CustomerList;
        lstCustomer.DataValueField = "CustomerId";
        lstCustomer.DataTextField = "CustomerName";
        lstCustomer.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CustomerId"] = -1;

        Response.Redirect("AnCustomer.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        if (lstCustomer.SelectedIndex != -1)
        {
            CustomerId = Convert.ToInt32(lstCustomer.SelectedValue);

            Session["CustomerId"] = CustomerId;

            Response.Redirect("Delete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        if (lstCustomer.SelectedIndex != -1)
        {

            CustomerId = Convert.ToInt32(lstCustomer.SelectedValue);

            Session["CustomerId"] = CustomerId;

            Response.Redirect("AnCustomer.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsCustomerCollection AllCustomer = new clsCustomerCollection();
        AllCustomer.ReportByCustomerName(txtCustomerName.Text);
        lstCustomer.DataSource = AllCustomer.CustomerList;
        lstCustomer.DataValueField = "CustomerId";
        lstCustomer.DataTextField = "CustomerName";
        lstCustomer.DataBind();
    }

    protected void btnOrder_Click(object sender, EventArgs e)
    {
        Response.Redirect("DefaultOrder.aspx");
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        DisplayCustomer();
    }
}