using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder OrderOne = new clsOrder();
        //capture the order status
        OrderOne.OrderStatus = txtOrderStatus.Text;
        OrderOne.OrderID = Convert.ToInt32(txtOrderID.Text);
        OrderOne.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        OrderOne.ProductID = Convert.ToInt32(txtProductID.Text);
        OrderOne.Quantity = Convert.ToInt32(txtQuantity.Text);
        OrderOne.OrderDate = Convert.ToDateTime(DateTime.Now);
        OrderOne.IsReturned = chkIsReturned.Checked;
        
        //store the order in the session object
        Session["OrderOne"] = OrderOne;
        //navigate to the view page
        Response.Redirect("OrdersViewer.aspx");
    }
}