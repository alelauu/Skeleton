using System;
using System.Collections.Generic;
using System.Net;

namespace ClassLibrary
{
    public class clsStaffCollection
    {


        //Private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();

        //Private data member for ThisStaff
        clsStaff mThisStaff = new clsStaff();


         //Constroctor for StaffCollection Class
        public clsStaffCollection() {

            //Object for data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");

           //Populate the array list with the data in the table
           PopulateArray(DB);


        }

        /*********Get and Set Methods***********/
        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }

            set
            {
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                return mStaffList.Count;
            }

            set
            {
                //worry about this later
            }
        }

        public clsStaff ThisStaff
        {
            get
            {
                //Return the private data
                return mThisStaff;
            }
            set
            {
                //Set the private data
                mThisStaff = value;
            }
        }


        /***********Functions***************/
        public int Add()
        {
            //Adds a record to the database based on the values of mThisStaff
            //Connects to the database
            clsDataConnection DB = new clsDataConnection();

            //Sets the parameters
            DB.AddParameter("@FullName", mThisStaff.FullName);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@Address", mThisStaff.Address);
            DB.AddParameter("@Number", mThisStaff.Number);
            DB.AddParameter("@StartDate", mThisStaff.StartDate);
            DB.AddParameter("@IsOnline", mThisStaff.IsOnline);

            //return the primary key by executing the query
            return DB.Execute("sproc_tblStaff_Insert");

        }


        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data stored in the parameter 'DB'


            //variable for the index
            Int32 Index = 0;

            //variable to store the record count
            Int32 RecordCount;

            //get the count of records
            RecordCount = DB.Count;

            //Clear the private array list
            mStaffList = new List<clsStaff>();

            while (Index < RecordCount)
            {
                //Creates a blank staff record
                clsStaff NewStaff = new clsStaff();

                //read in the frields of the current record
                // Copy the data in the database and assign them to the private data members(varibles) above
                NewStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                NewStaff.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                NewStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                NewStaff.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                NewStaff.Number = Convert.ToString(DB.DataTable.Rows[Index]["Number"]);
                NewStaff.StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartDate"]);
                NewStaff.IsOnline = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsOnline"]);

                //Adds the record to the private member
                mStaffList.Add(NewStaff);

                //Points at the next record
                Index++;

            }
        }

        public void ReportByFullName(string FullName)
        {
            //Filters the records based on a full or partial post code
            //Connect to the database
            clsDataConnection DB = new clsDataConnection();

            //send the FullName parameter to the database
            DB.AddParameter("@FullName", FullName);

            //Execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByFullName");

            //Populate the array list with the data in the table
            PopulateArray(DB);
        }

        public void Update()
        {
            //Update an existing record based on the values of thisStaff
            //Connect to the databsse
            clsDataConnection DB = new clsDataConnection();

            //Set the parameters for the new stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.AddParameter("@FullName", mThisStaff.FullName);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@Address", mThisStaff.Address);
            DB.AddParameter("@Number", mThisStaff.Number);
            DB.AddParameter("@StartDate", mThisStaff.StartDate);
            DB.AddParameter("@IsOnline", mThisStaff.IsOnline);

            //Execute the store procedure
            DB.Execute("sproc_tblStaff_Update");
        }

        public void Delete()
        {
            //Deletes the record pointed to by thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //Set the parameters for the stored procedure
            DB.AddParameter("@StaffId", mThisStaff.StaffId);

            //Execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");
        }
    }
}