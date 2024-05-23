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
    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the product to be deleted from the session object
        ProductID = Convert.ToInt32(Session["ProductID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of AllProducts collection class
        clsStockCollection AllProducts = new clsStockCollection();
        //find the record to delete
        AllProducts.ThisProduct.Find(ProductID);
        //delete the record
        AllProducts.Delete();
        //redirect back to the main page
        Response.Redirect("StockList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}