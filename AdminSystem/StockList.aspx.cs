﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayProducts();
        }
    }
    void DisplayProducts()
    {
        //create an instance of the products/stock collection
        clsStockCollection Products = new clsStockCollection();
        //set the data source to list of products in the collection
        lstProductList.DataSource = Products.ProductList;
        //set the name of the primary key
        lstProductList.DataValueField = "ProductID";
        //set the data field to display
        lstProductList.DataTextField = "ProductName";
        //bind the data to the list
        lstProductList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["ProductID"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 ProductID;
        //if a record has been selected from the list
        if (lstProductList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            ProductID = Convert.ToInt32(lstProductList.SelectedValue);
            //store the data in the session object
            Session["ProductID"] = ProductID;
            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }
}