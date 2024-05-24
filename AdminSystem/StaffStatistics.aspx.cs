using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Creates a new instance of the Staff class
         clsStaff clsStaff = new clsStaff();

        //Retrieve data from the database
        DataTable dT = clsStaff.StatisticsGroupedByActivity();

        //Upload dT into GridView
        GridViewStGroupedByActivity.DataSource = dT;
        GridViewStGroupedByActivity.DataBind();

        //Change the header of the first column
        GridViewStGroupedByActivity.HeaderRow.Cells[0].Text = " Total ";

        //Retrieve data from the database
        dT = clsStaff.StatisticsGroupedByStartDate();


        //Upload dT into GridView
        GridViewStGroupedByStartDate.DataSource = dT;
        GridViewStGroupedByStartDate.DataBind();

        //Change the header of the first column
        GridViewStGroupedByStartDate.HeaderRow.Cells[0].Text = " Total ";

    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}