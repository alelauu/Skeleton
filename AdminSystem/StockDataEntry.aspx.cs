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
        ProductOne.ProductName = txtProductName.Text;
        ProductOne.ProductBrand = txtAmountInStock.Text;
        ProductOne.ProductColour = txtProductColour.Text;
        ProductOne.ProductCapacity = txtProductCapacity.Text;
        ProductOne.AmountInStock = Convert.ToInt32(txtAmountInStock.Text); 
        ProductOne.InStock = chkInStock.Checked;



        //storing the address in the session object
        Session["ProductOne"] = ProductOne;
        //redirecting
        Response.Redirect("StockViewer.aspx");
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
            txtAmountInStock.Text = ProductOne.AmountInStock.ToString();
            chkInStock.Checked = ProductOne.InStock;

        }
        else
        {
            lblError.Text = "ProductID does not exist";
        }
    }
}