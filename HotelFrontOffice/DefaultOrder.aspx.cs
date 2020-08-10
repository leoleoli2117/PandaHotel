using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DefaultOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Int32 OrderId;
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if(IsPostBack==false)
        {
            DisplayOrder();

            if (OrderId!=-1)
            {
                DisplayOrder();
            }
        }
    }

    protected void btnCustomer_Click(object sender, EventArgs e)
    {
        Response.Redirect("DefaultOrder.aspx");
    }

    void DisplayOrder()
    {
        HotelClasses.clsOrderCollection AllOrder = new HotelClasses.clsOrderCollection();
        lstOrder.DataSource = AllOrder.OrderList;
        lstOrder.DataValueField = "OrderId";
        lstOrder.DataTextField = "OrderId";
        lstOrder.DataBind();
    }

    protected void btnDisplayAll_Click(object sender, EventArgs e)
    {
        DisplayOrder();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderId"] = -1;

        Response.Redirect("AnOrder.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderId;

        if (lstOrder.SelectedIndex !=-1)
        {
            OrderId = Convert.ToInt32(lstOrder.SelectedValue);

            Session["OrderId"] = OrderId;

            Response.Redirect("Delete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete";
        }
    }
}