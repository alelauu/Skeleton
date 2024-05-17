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
}