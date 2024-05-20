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
            /*clsProduct TestItem = new clsProduct();
            //sets its properties
            TestItem.InStock = true;
            TestItem.ProductID = 12;
            TestItem.ProductName = "Test";
            TestItem.ProductBrand = "Xiaomi";
            TestItem.ProductColour = "Purple";
            TestItem.ProductCapacity = "1TB";
            TestItem.ProductPrice = 2149;
            TestItem.DateAdded = DateTime.Now;
            //adding the test data to the test list
            mProductList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsProduct();
            TestItem.InStock = true;
            TestItem.ProductID = 13;
            TestItem.ProductName = "Test1";
            TestItem.ProductBrand = "Samsung";
            TestItem.ProductColour = "Violet";
            TestItem.ProductCapacity = "512GB";
            TestItem.ProductPrice = 2149;
            TestItem.DateAdded = DateTime.Now; 
            mProductList.Add(TestItem);*/

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
        public clsProduct ThisProduct { get; set; }
    }
}
