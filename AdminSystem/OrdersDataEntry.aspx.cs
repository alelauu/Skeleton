using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 OrderID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record 
            if (OrderID != -1)
            {
                //display the current data for the record
                DisplayOrder();
            }
        }

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
            OrderOne.OrderID = OrderID;
            OrderOne.OrderStatus = OrderStatus;
            OrderOne.OrderDate = Convert.ToDateTime(OrderDate);
            OrderOne.ProductID = Convert.ToInt32(ProductID);
            OrderOne.CustomerID = Convert.ToInt32(CustomerID);
            OrderOne.Quantity = Convert.ToInt32(Quantity);
            OrderOne.IsReturned = chkIsReturned.Checked;
            clsOrderCollection OrderList = new clsOrderCollection();

            if (OrderID == -1)
            {
                OrderList.ThisOrder = OrderOne;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderID);
                OrderList.ThisOrder = OrderOne;
                OrderList.Update();
            }
            Response.Redirect("OrdersList.aspx");


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
            txtProductID.Text = OrderOne.ProductID.ToString();
            txtQuantity.Text = OrderOne.Quantity.ToString();
            txtOrderDate.Text = OrderOne.OrderDate.ToString();
            chkIsReturned.Checked = OrderOne.IsReturned;
            txtOrderStatus.Text = OrderOne.OrderStatus;

        }

     




    }
    void DisplayOrder()
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ThisOrder.Find(OrderID);
        txtOrderID.Text = Orders.ThisOrder.OrderID.ToString();
        txtProductID.Text = Orders.ThisOrder.ProductID.ToString();
        txtCustomerID.Text = Orders.ThisOrder.CustomerID.ToString();
        txtQuantity.Text = Orders.ThisOrder.Quantity.ToString();
        txtOrderStatus.Text = Orders.ThisOrder.OrderStatus.ToString();
        txtOrderDate.Text = Orders.ThisOrder.OrderDate.ToString();
        chkIsReturned.Checked = Orders.ThisOrder.IsReturned;
    }

    protected void btnMain_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrdersList.aspx");

    }
}