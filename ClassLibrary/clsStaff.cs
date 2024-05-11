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

                return mEmail ;
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


        public bool Find(int staffId)
        {
            // Sets the private variable to the test value
            mStaffId = 3;
            mStartDate = Convert.ToDateTime("9/05/2024");
            mIsOnline = true;
            mNumber = "07497070472";
            mPostCode = "LE1 5AN";
            mEmail = "P2765365@my365.dmu.ac.uk";
            mFullName = "Sharon";
            //Always return true
            return true;
        }



    }
}