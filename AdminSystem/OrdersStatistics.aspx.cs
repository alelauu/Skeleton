using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrdersStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder clsorder = new clsOrder();

        DataTable dT = clsorder.StatisticsGroupedByOrderStatus();
        GridViewStGroupByOrderStatus.DataSource = dT;
        GridViewStGroupByOrderStatus.DataBind();

        GridViewStGroupByOrderStatus.HeaderRow.Cells[0].Text = " Total ";

        dT = clsorder.StatisticsGroupedOrderDate();
        GridViewStGroupByOrderDate.DataSource = dT;
        GridViewStGroupByOrderDate.DataBind();

        GridViewStGroupByOrderDate.HeaderRow.Cells[0].Text = " Total ";


    }



    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrdersList.aspx");
    }
}