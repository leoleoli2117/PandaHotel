using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class DeleteOrder : System.Web.UI.Page
{
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderId = Convert.ToInt32(Session["OrderId"]);
    }

    void DeleteOrder1()
    {

        clsOrderCollection AllOrder = new clsOrderCollection();

        AllOrder.ThisOrder.Find(OrderId);

        AllOrder.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        DeleteOrder1();

        Response.Redirect("DeleteOrder.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("DeleteOrder.aspx");
    }
}