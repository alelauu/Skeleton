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

    protected void btnFind_Click(object sender, EventArgs e)
    {


    }

    protected void btnFind_Click1(object sender, EventArgs e)
    {
        //create an instance of the address class 
        clsOrder OrderOne = new clsOrder();
        //create a variable to store the primary key 
        Int32 OrderID;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user 
        OrderID = Convert.ToInt32(txtOrderID.Text);
        //find the record
        Found = OrderOne.Find(OrderID);
        //if found 
        if (Found == true)
        {
            //display the values of the properties in the form
            txtCustomerID.Text = OrderOne.CustomerID.ToString();
            txtProductID.Text = OrderOne.ProductID.ToString()   ;
            txtQuantity.Text = OrderOne.Quantity.ToString();
            txtOrderDate.Text = OrderOne.OrderDate.ToString();
            chkIsReturned.Checked = OrderOne.IsReturned;
            txtOrderStatus.Text = OrderOne.OrderStatus;

        }
    }
}