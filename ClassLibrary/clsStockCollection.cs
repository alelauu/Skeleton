﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //constructor
        public clsStockCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_tblProduct_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank product
                clsProduct ProductOne = new clsProduct();
                ProductOne.ProductID = Convert.ToInt32(DB.DataTable.Rows[Index]["ProductID"]);
                ProductOne.ProductName = Convert.ToString(DB.DataTable.Rows[Index]["ProductName"]);
                ProductOne.ProductBrand = Convert.ToString(DB.DataTable.Rows[Index]["ProductBrand"]);
                ProductOne.ProductColour = Convert.ToString(DB.DataTable.Rows[Index]["ProductColour"]);
                ProductOne.ProductCapacity = Convert.ToString(DB.DataTable.Rows[Index]["ProductCapacity"]);
                ProductOne.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                ProductOne.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStock"]);
                ProductOne.ProductPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["ProductPrice"]);
                //add the record to the private data member
                mProductList.Add(ProductOne);
                //point at the next record
                Index++;
            }

        }
        //private data member for the list
        List<clsProduct> mProductList = new List<clsProduct>();
        clsProduct mThisProduct = new clsProduct();
        //public property for the product list
        public List<clsProduct> ProductList
        {
            get
            {
                return mProductList;
            }
            set
            {
                mProductList = value;
            }
        }

        //public property for count
        public int Count
        {
            get
            {
                return ProductList.Count;
            }
            set
            {
                //to be made
            }
        }
        public clsProduct ThisProduct
        {
            get
            {
                return mThisProduct;
            }
            set
            {
                mThisProduct = value;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisProduct
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the store procedure
            DB.AddParameter("@ProductName", mThisProduct.ProductName);
            DB.AddParameter("@ProductBrand", mThisProduct.ProductBrand);
            DB.AddParameter("@ProductColour", mThisProduct.ProductColour);
            DB.AddParameter("@ProductCapacity", mThisProduct.ProductCapacity);
            DB.AddParameter("@ProductPrice", mThisProduct.ProductPrice);
            DB.AddParameter("@InStock", mThisProduct.InStock);
            DB.AddParameter("@DateAdded", mThisProduct.DateAdded);

            //execute the query return the primary key value
            return DB.Execute("sproc_tblProduct_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of thisProduct
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the store procedure
            DB.AddParameter("@ProductID", mThisProduct.ProductID);
            DB.AddParameter("@ProductName", mThisProduct.ProductName);
            DB.AddParameter("@ProductBrand", mThisProduct.ProductBrand);
            DB.AddParameter("@ProductColour", mThisProduct.ProductColour);
            DB.AddParameter("@ProductCapacity", mThisProduct.ProductCapacity);
            DB.AddParameter("@ProductPrice", mThisProduct.ProductPrice);
            DB.AddParameter("@InStock", mThisProduct.InStock);
            DB.AddParameter("@DateAdded", mThisProduct.DateAdded);

            //execute the stored procedure
            DB.Execute("sproc_tblProduct_Update");
        }
    }
}
