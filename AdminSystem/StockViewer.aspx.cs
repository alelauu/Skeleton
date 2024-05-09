using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //creating a new instance of clsProduct
        clsProduct ProductOne = new clsProduct();
        //getting the data from the session object
        ProductOne = (clsProduct)Session["ProductOne"];
        //display the product name for this entry
        Response.Write(ProductOne.ProductName);
        Response.Write(ProductOne.ProductBrand);
        Response.Write(ProductOne.ProductColour);
        Response.Write(ProductOne.ProductCapacity);
        Response.Write(ProductOne.AmountInStock);
        Response.Write(ProductOne.InStock);
    }
}