using System;
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
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the store procedure
            DB.Execute("sproc_tblProduct_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
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

        public void Delete()
        {
            //deletes the record pointed to by thisProduct
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ProductID", mThisProduct.ProductID);
            //execute the stored procedure
            DB.Execute("sproc_tblProduct_Delete");
        }
        public void ReportByProductName(string ProductName)
        {
            //filter the records based on a full or partial post code
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the product name parameter to the database
            DB.AddParameter("@ProductName", ProductName);
            //execute the stored procedure
            DB.Execute("sproc_tblProduct_FilterByProductName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the paramter DB
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            RecordCount = DB.Count;
            mProductList = new List<clsProduct>();
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
    }
}
