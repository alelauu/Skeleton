
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;



public partial class _1_DataEntry : System.Web.UI.Page
{
    //Variable to store the primary key with page level scope
    Int32 StaffId;

    protected void Page_Load(object sender, EventArgs e)

    {
        //Get the number of the staff to be pocessed
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if(IsPostBack == false)
        {
            //If this is not a new record
            if(StaffId != -1)
            {
                //Display the current data for the record
                DisplayStaff();
            }
        }

    }
    void DisplayStaff()
    {
        //Creates an instance of the Staff Collection
        clsStaffCollection Staff = new clsStaffCollection();

        //Find the data for the record
        txtStaffId.Text = Staff.ThisStaff.StaffId.ToString();
        txtFullName.Text = Staff.ThisStaff.FullName.ToString();
        txtEmail.Text = Staff.ThisStaff.Email.ToString();
        txtAddress.Text = Staff.ThisStaff.Address.ToString();
        txtNumber.Text = Staff.ThisStaff.Number.ToString();
        txtStartDate.Text = Staff.ThisStaff.StartDate.ToString();
        chkIsOnline.Checked = Staff.ThisStaff.IsOnline;
    }


    protected void btnOK_Click(object sender, EventArgs e)
    {


        //Create a new instance of clsStaff
        clsStaff NewStaff = new clsStaff();

        //Capture the details
        string FullName = txtFullName.Text;
        string Email = txtEmail.Text;
        string Address = txtAddress.Text;
        string Number = txtNumber.Text;
        string StartDate =txtStartDate.Text;
        string IsOnline = chkIsOnline.Text;

        //variable to store any error messages
        string Error = "";

        //validate the data 
        Error = NewStaff.Valid(FullName, Email, Address, Number, StartDate);
        if(Error == "")
        {
        //Capture the details
        NewStaff.StaffId = StaffId;
        NewStaff.FullName = FullName;
        NewStaff.Email = Email;
        NewStaff.Address = Address;
        NewStaff.Number = Number;
        NewStaff.StartDate = Convert.ToDateTime(StartDate);
        NewStaff.IsOnline = chkIsOnline.Checked;

        //Create a new instance of the Staff Collection
        clsStaffCollection StaffList = new clsStaffCollection();

        //If this is a new record:
        if(StaffId == -1 ) 
            {
                //Set the ThisStaff property
                StaffList.ThisStaff = NewStaff;

                //Adds the new record
                StaffList.Add();
            }
            //Otherwise it must be an update
            else
            {
                //Find the record to update
                StaffList.ThisStaff.Find(StaffId);

                //Set the ThisStaff property
                StaffList.ThisStaff = NewStaff;

                //Update the record
                StaffList.Update();
            }

        //Redirects back to the view:
        Response.Redirect("StaffList.aspx");

        }
        else
        {
            //Display the error message
            lblError.Text = Error;
        }
        


        
    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of the Staff class

        clsStaff NewStaff = new clsStaff();

        //Create  a variable to store the primary key
        Int32 StaffId;

        //Create a variable to store the result of the "Find" operation
        Boolean Found = false;

        //Retrieve the primary key entered by the user
        StaffId = Convert.ToInt32(txtStaffId.Text);

        //fIND THE RECORD
        Found = NewStaff.Find(StaffId);

        if (Found == true)
        {
            //Display the properties on the form


            txtFullName.Text = NewStaff.FullName;
            txtEmail.Text = NewStaff.Email;
            txtAddress.Text = NewStaff.Address;
            txtNumber.Text = NewStaff.Number;
            txtStartDate.Text = NewStaff.StartDate.ToString();
            chkIsOnline.Checked = NewStaff.IsOnline;

        }
    }
}
