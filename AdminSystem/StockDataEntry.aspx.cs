using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //creating a new instance of clsProduct
        clsProduct ProductOne = new clsProduct();
        //capturing the data
        string ProductName = txtProductName.Text;
        string ProductBrand = txtProductBrand.Text;
        string ProductColour = txtProductColour.Text;
        string ProductCapacity = txtProductCapacity.Text;
        string ProductPrice = txtProductPrice.Text;
        string DateAdded = txtDateAdded.Text;
        string InStock = chkInStock.Text;

        string Error = "";
        Error = ProductOne.Valid(ProductName, ProductBrand, ProductColour, ProductCapacity, DateAdded);
        if (Error == "")
        {
            ProductOne.ProductName = ProductName;
            ProductOne.ProductBrand = ProductBrand;
            ProductOne.ProductColour = ProductColour;
            ProductOne.ProductCapacity = ProductCapacity;
            ProductOne.DateAdded = Convert.ToDateTime(DateAdded);
            //storing the address in the session object
            Session["ProductOne"] = ProductOne;
            //redirecting
            Response.Redirect("StockViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsProduct ProductOne = new clsProduct();
        Int32 ProductId;
        Boolean Found = false;
        ProductId = Convert.ToInt32(txtProductID.Text);
        Found = ProductOne.Find(ProductId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtProductName.Text = ProductOne.ProductName;
            txtProductBrand.Text = ProductOne.ProductBrand;
            txtProductColour.Text = ProductOne.ProductColour;
            txtProductCapacity.Text = ProductOne.ProductCapacity;
            txtProductPrice.Text = ProductOne.ProductPrice.ToString();
            txtDateAdded.Text = ProductOne.DateAdded.ToString();
            chkInStock.Checked = ProductOne.InStock;

        }
        else
        {
            lblError.Text = "ProductID does not exist";
        }
    }
}