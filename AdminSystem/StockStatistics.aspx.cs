using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsProduct clsproduct = new clsProduct();

        //retrieve data from the database
        DataTable dT = clsproduct.StatisticsGroupedByCapacity();

        //upload dT into GridView
        GridViewStGroupByCapacity.DataSource = dT;
        GridViewStGroupByCapacity.DataBind();

        //change the header of the first column
        GridViewStGroupByCapacity.HeaderRow.Cells[0].Text = " Total ";

        //retrieve data from the database
        dT = clsproduct.StatisticsGroupedAddedDate();

        //upload dT into GridView
        GridViewStGroupByAddedDate.DataSource = dT;
        GridViewStGroupByAddedDate.DataBind();

        //change the header of the first column
        GridViewStGroupByAddedDate.HeaderRow.Cells[0].Text = " Total ";
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
    }
}