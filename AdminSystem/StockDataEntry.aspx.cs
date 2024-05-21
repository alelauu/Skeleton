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
    Int32 ProductID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        ProductID = Convert.ToInt32(Session["ProductID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (ProductID != -1)
            {
                //display the current data for the record
                DisplayProduct();
            }
        }
    }
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
            //capture the address id
            ProductOne.ProductID = ProductID;
            ProductOne.ProductName = ProductName;
            ProductOne.ProductBrand = ProductBrand;
            ProductOne.ProductColour = ProductColour;
            ProductOne.ProductCapacity = ProductCapacity;
            ProductOne.DateAdded = Convert.ToDateTime(DateAdded);
            ProductOne.ProductPrice = Convert.ToDecimal(ProductPrice);
            ProductOne.InStock = chkInStock.Checked;
            clsStockCollection ProductList = new clsStockCollection();

            //if this is a new record i.e. ProductID = -1 then add the data
            if (ProductID == -1)
            {
                ProductList.ThisProduct = ProductOne;
                ProductList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                ProductList.ThisProduct.Find(ProductID);
                //set the ThisProduct property
                ProductList.ThisProduct = ProductOne;
                //update the record
                ProductList.Update();
            }
            //redirect back to the list page
            Response.Redirect("StockList.aspx");
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
    void DisplayProduct()
    {
        //creating a new instance of clsStockCollection
        clsStockCollection AllProducts = new clsStockCollection();
        //find the record to update
        AllProducts.ThisProduct.Find(ProductID);
        //display the data for the record
        txtProductName.Text = AllProducts.ThisProduct.ProductName.ToString();
        txtProductBrand.Text = AllProducts.ThisProduct.ProductBrand.ToString();
        txtProductColour.Text = AllProducts.ThisProduct.ProductColour.ToString();
        txtProductCapacity.Text = AllProducts.ThisProduct.ProductCapacity.ToString();
        txtProductPrice.Text = AllProducts.ThisProduct.ProductPrice.ToString();
        txtDateAdded.Text = AllProducts.ThisProduct.DateAdded.ToString();
        chkInStock.Checked = AllProducts.ThisProduct.InStock;
    }
}