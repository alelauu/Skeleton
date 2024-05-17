using System;
using System.Collections.Generic;
using System.Net;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        public clsStaffCollection() {

            //variable for the index
            Int32 Index = 0;

            //variable to store the record count
            Int32 RecordCount = 0;

            //Object for data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");

            //get the count of records
            RecordCount = DB.Count;

            //While there aren't any records to process:
            while(Index < RecordCount)
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

        //Private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();


  

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
     
        public clsStaff ThisStaff { get; set; }
    }
}