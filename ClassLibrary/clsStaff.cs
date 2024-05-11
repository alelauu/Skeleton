using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //Private variables are initialised for the properties



        // Original Get and set methods
        // public int StaffId { get; set; }

        //  public bool IsOnline { get; set; }

        //   public DateTime StartDate { get; set; }

        //  public string Number { get; set; }
        //  public string PostCode { get; set; }
        //   public string Email { get; set; }
        //   public string FullName { get; set; }

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

        private string mPostCode;
        public string PostCode
        {
            get
            {
                //Sends the data out of the property

                return mPostCode;
            }

            set
            {

                //Allows data into the property
                mPostCode = value;
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
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
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
    }
}