using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //If it's the first time the page is being displayed:

        if (IsPostBack == false)
        {
            //Update the list boc
            DisplayStaff();
        }

    }

    void DisplayStaff()
    {

        //Creates an instance of the Staff Collection
        clsStaffCollection Staff = new clsStaffCollection();

        //Sets the data source to a list of staff records in the collection
        lstStaffList.DataSource = Staff.StaffList;

        //Sets the name of the primary key
        lstStaffList.DataValueField = "StaffId";

        //Sets the data field to display

        lstStaffList.DataValueField = "FullName";

        //binds the data to the list
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //Store -1 into session object to indicaate that it's a new record
        Session["StaffId"] = -1;

        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the staff collection class
        clsStaffCollection NewStaff = new clsStaffCollection();

        //Retrieves the value of the full name from the presentation layer
        NewStaff.ReportByFullName(txtEnterFullName.Text);


        //Set the data source to the list of staff in the collection 
        lstStaffList.DataSource = NewStaff.StaffList;


        //Set the name of the primary key
        lstStaffList.DataValueField = "StaffId";

        //Set the name of the field to display
        lstStaffList.DataTextField = "FullName";

        //Bind the data to the list
        lstStaffList.DataBind();



    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the staff collection class
        clsStaffCollection NewStaff = new clsStaffCollection();

        //Set an empty string
        NewStaff.ReportByFullName("");

        //Clear any existing filter to tidy up the interface
        txtEnterFullName.Text = "";

        //Set the data source to the list of addresses in the collection
        lstStaffList.DataSource = NewStaff.StaffList;

        //Set the name of the primary key
        lstStaffList.DataValueField = "StaffId";

        //Set the name of the field to display
        lstStaffList.DataTextField = "FullName";

        //Bind the data to the list
        lstStaffList.DataBind();


    }





    protected void btnEdit_Click(object sender, EventArgs e)
    {

    }






    
}