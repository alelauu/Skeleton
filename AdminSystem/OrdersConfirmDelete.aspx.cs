using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted
    Int32 OrderID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get number of the order to be deleted from the session object
        OrderID = Convert.ToInt32(Session["OrderID"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ThisOrder.Find(OrderID);
        Orders.Delete();
        Response.Redirect("OrdersList.aspx");

    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrdersList.aspx");
    }
}