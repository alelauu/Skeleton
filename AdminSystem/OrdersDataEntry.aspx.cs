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
        //store the order in the session object
        Session["OrderOne"] = OrderOne;
        //navigate to the view page
        Response.Redirect("OrdersViewer.aspx");
    }
}