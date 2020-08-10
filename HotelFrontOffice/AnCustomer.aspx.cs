using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class AnCustomer : System.Web.UI.Page
{
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (IsPostBack == false)
        {
            
            
           
                DisplayCustomer();
            
        }
    }

    void DisplayCustomer()
    {
        HotelClasses.clsCustomerCollection AllCustomer = new clsCustomerCollection();

        AllCustomer.ThisCustomer.Find(CustomerId);

        txtCustomerName.Text = AllCustomer.ThisCustomer.CustomerName;
        txtCustomerEmail.Text = AllCustomer.ThisCustomer.CustomerEmail;
        txtCustomerMobile.Text = AllCustomer.ThisCustomer.CustomerMobile;
        CheckBoxActive.Checked = AllCustomer.ThisCustomer.Active;
    }

    void Add()
    {

        HotelClasses.clsCustomerCollection AllCustomer = new clsCustomerCollection();

        String Error = AllCustomer.ThisCustomer.Valid(txtCustomerName.Text, txtCustomerEmail.Text, txtCustomerMobile.Text, CheckBoxActive.Checked);

        if (Error == "")
        {

            AllCustomer.ThisCustomer.CustomerName = txtCustomerName.Text;
            AllCustomer.ThisCustomer.CustomerEmail = txtCustomerEmail.Text;
            AllCustomer.ThisCustomer.CustomerMobile = txtCustomerMobile.Text;
            AllCustomer.ThisCustomer.Active = CheckBoxActive.Checked;

            AllCustomer.Add();


        }
        else
        {

            lblError.Text = "There were problems with the data entered" + Error;
        }
    }

    void Update()
    {
        HotelClasses.clsCustomerCollection AllCustomer = new clsCustomerCollection();

        String Error = AllCustomer.ThisCustomer.Valid(txtCustomerName.Text, txtCustomerEmail.Text, txtCustomerMobile.Text, CheckBoxActive.Checked);

        if (Error == "")
        {

            AllCustomer.ThisCustomer.Find(CustomerId);
            AllCustomer.ThisCustomer.CustomerName = txtCustomerName.Text;
            AllCustomer.ThisCustomer.CustomerEmail = txtCustomerEmail.Text;
            AllCustomer.ThisCustomer.CustomerMobile = txtCustomerMobile.Text;
            AllCustomer.ThisCustomer.Active = CheckBoxActive.Checked;

            AllCustomer.Update();

            Response.Redirect("Default.aspx");
        }
        else
        {
            lblError.Text = "There were problems with the data entered" + Error;
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (CustomerId == -1)
        {
            Add();
            Response.Redirect("Default.aspx");
        }
        else
        {
            Update();
            Response.Redirect("Default.aspx");
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}