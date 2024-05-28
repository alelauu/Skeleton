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
            DisplayAllStaff();
        }

    }

    void DisplayAllStaff()
    {

        //Creates an instance of the Staff Collection
        clsStaffCollection Staff = new clsStaffCollection();

        //Sets the data source to a list of staff records in the collection
        lstStaffList.DataSource = Staff.StaffList;

        //Sets the name of the primary key
        lstStaffList.DataValueField = "StaffId";

        //Sets the data field to display

        lstStaffList.DataTextField = "FullName";

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
        //Variable to store the primary key value of he record to be edited
        Int32 StaffId;

        //If a record has been selected from the list:
        if (lstStaffList.SelectedIndex != -1)
        {

            //Retrieve the primary key value of the record to edit
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);

            //Store the data in the session object
            Session["StaffId"] = StaffId;

            //Redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit!";
        }
    }








    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //Variable to store the primary key value of he record to be edited
        Int32 StaffId;

        //If a record has been selected from the list:
        if (lstStaffList.SelectedIndex != -1)
        {

            //Retrieve the primary key value of the record to edit
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);

            //Store the data in the session object
            Session["StaffId"] = StaffId;

            //Redirect to the deltee page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else
        {
            //Displays an error message
            lblError.Text = "Please select a record from the list to delete!";
        }
    }

    protected void btnStatistics_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffStatistics.aspx");
    }

    protected void btnMainPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}