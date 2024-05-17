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
        string OrderStatus = txtOrderStatus.Text;
        string OrderDate = txtOrderDate.Text;
        string ProductID = txtProductID.Text;
        string CustomerID = txtCustomerID.Text;
        string Quantity = txtQuantity.Text;
        string IsReturned = chkIsReturned.Text;
        string Error = "";
        Error = OrderOne.Valid(OrderStatus, OrderDate);
        if (Error == "")
        {
            OrderOne.OrderStatus = OrderStatus;
            OrderOne.OrderDate = Convert.ToDateTime(OrderDate);
            Session["OrderOne"] = OrderOne;
            Response.Redirect("OrdersViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
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