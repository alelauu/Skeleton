
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder OrderOne = new clsOrder();
        //get data from session object
        OrderOne = (clsOrder)Session["OrderOne"];
        //display the Order Status for this entry 
         Response.Write(OrderOne.OrderStatus);

    }
}