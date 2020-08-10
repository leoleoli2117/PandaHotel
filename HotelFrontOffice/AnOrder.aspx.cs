using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class AnOrder : System.Web.UI.Page
{
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (IsPostBack == false)
        {
            
                DisplayOrder();
            
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        Add();

        Response.Redirect("DefaultOrder.aspx");
    }

    void Add()
    {
        HotelClasses.clsOrderCollection Allorder = new clsOrderCollection();
        String Error = Allorder.ThisOrder.Valid(txtOrderNo.Text, DateTime.Now.Date, chkStatus.Checked);
        if (Error == "")
        {
            Allorder.ThisOrder.OrderNo = txtOrderNo.Text;
            Allorder.ThisOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
            Allorder.ThisOrder.Status = chkStatus.Checked;
            Allorder.Add();
        }
        else
        {
            lblError.Text = "There were problem with the data" + Error;
        }
    }

    void DisplayOrder()
    {
        HotelClasses.clsOrderCollection AllOrder = new clsOrderCollection();
        AllOrder.ThisOrder.Find(OrderId);
        txtOrderNo.Text = AllOrder.ThisOrder.OrderNo.ToString();
        txtOrderDate.Text = AllOrder.ThisOrder.OrderDate.ToString();
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("DefaultOrder.aspx");
    }
}