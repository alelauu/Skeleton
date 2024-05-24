using System;
using System.Data;

namespace ClassLibrary
{
    public class clsStaff
    {
        //Private variables are initialised for the properties


        //Private data variable declared for the staff id property
        private Int32 mStaffId;
        public Int32 StaffId
        {
            get
            {
                //Sends the data out of the property

                return mStaffId;
            }

            set
            {

                //Allows data into the property
                mStaffId = value;
            }
        }
        //Private data variable declared for the start date property
        private DateTime mStartDate;
        public DateTime StartDate
        {
            get
            {
                //Sends the data out of the property

                return mStartDate;
            }

            set
            {

                //Allows data into the property
                mStartDate = value;
            }
        }

        private Boolean mIsOnline;
        public Boolean IsOnline
        {
            get
            {
                //Sends the data out of the property

                return mIsOnline;
            }

            set
            {

                //Allows data into the property
                mIsOnline = value;
            }
        }
        private string mNumber;
        public string Number
        {
            get
            {
                //Sends the data out of the property

                return mNumber;
            }

            set
            {

                //Allows data into the property
                mNumber = value;
            }
        }

        private string mAddress;
        public string Address
        {
            get
            {
                //Sends the data out of the property

                return mAddress;
            }

            set
            {

                //Allows data into the property
                mAddress = value;
            }
        }

        private string mEmail;
        public string Email
        {
            get
            {
                //Sends the data out of the property

                return mEmail;
            }

            set
            {

                //Allows data into the property
                mEmail = value;
            }
        }
        private string mFullName;
        public string FullName
        {
            get
            {
                //Sends the data out of the property

                return mFullName;
            }

            set
            {

                //Allows data into the property
                mFullName = value;
            }
        }


        public bool Find(int StaffId)
        {

            // Creates an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            // Add a new parameter for the Staff Id to look for
            DB.AddParameter("@StaffId", StaffId);

            // Execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");

            //If a record is found...
            if (DB.Count == 1)
            {
                //Copy the data in the database and assign them to the private data members(varibles) above
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mFullName = Convert.ToString(DB.DataTable.Rows[0]["FullName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mNumber = Convert.ToString(DB.DataTable.Rows[0]["Number"]);
                mStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StartDate"]);
                mIsOnline = Convert.ToBoolean(DB.DataTable.Rows[0]["IsOnline"]);



                //Always return true
                return true;
            }
            //otherwise if nothing is found:
            else
            {
                //This will indicate that something is wrong
                return false;
            }



        }


        public string Valid(string fullName, string email, string address, string number, string startDate)
        {
            //Creates a string variable to store the error 
            string Error = "";
            //Creates a temporary variable to store the date values
            DateTime DateTemp;

            //if the fullName is blank
            if (fullName.Length == 0)
            {
                //Records the error
                Error = Error + "The full name should not be blank : ";

            }
            //if the fullName is greater than 50 characters
            if (fullName.Length > 50)
            {
                //Records the error
                Error = Error + "The full name should not be more than 50 characters : ";
            }

            // Creates an instance of DateTime to compare with DateTemp
            DateTime DateComp = DateTime.Now.Date;

            try
            {
                //Copies the startDate value to te DateTemp variable
                DateTemp = Convert.ToDateTime(startDate);

                //Checks to see if the start date is less than todays date
                if (DateTemp < DateTime.Now.Date)
                {
                    //Records the error
                    Error = Error + "The date can't be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    //Records the error
                    Error = Error + "The date cannot be in the future : ";
                }


            }
            catch
            {
                //Records the error
                Error = Error + "The date was not valid : ";
            }

            //if the Email is blank
            if (email.Length == 0)
            {
                //Records the error
                Error = Error + "The email should not be blank : ";

            }
            //if the Email is greater than 50 characters
            if (email.Length > 255)
            {
                //Records the error
                Error = Error + "The email should not be more than 255 characters : ";
            }
            //if the address is blank
            if (address.Length == 0)
            {
                //Records the error
                Error = Error + "The address  should not be blank : ";

            }
            //if the address is greater than 50 characters
            if (address.Length > 255)
            {
                //Records the error
                Error = Error + "The address should not be more than 255 characters : ";
            }

            //if the number is blank
            if (number.Length == 0)
            {
                //Records the error
                Error = Error + "The number should not be blank : ";

            }
            //if the numnber is greater than 11 characters
            if (number.Length > 11)
            {
                //Records the error
                Error = Error + "The number should not be more than 11 characters : ";
            }
            //Returns any error messages
            return Error;


        }

        /***********Code for statistics************/
        //The code below establishes database connectivity and data retrieval


        //Grouped by Activity method
        public DataTable StatisticsGroupedByActivity()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Count_GroupByActivity");

            //There should be either zero, one or more records
            return DB.DataTable;
        }
        public DataTable StatisticsGroupedByStartDate()
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();

            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Count_GroupByStartDate");

            //There should be either zero, one or more records
            return DB.DataTable;
        }
    }
}

