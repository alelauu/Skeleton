using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Creates a new instance of clsStaff
        clsStaff NewStaff = new clsStaff();

        //Retrieves the data from the session
        NewStaff = (clsStaff)Session["NewStaff"];

        //Display the full name for the entry
        Response.Write(NewStaff.FullName);
        Response.Write(NewStaff.Email);
        Response.Write(NewStaff.PostCode);
        Response.Write(NewStaff.Number);
        Response.Write(NewStaff.StartDate);
        Response.Write(NewStaff.IsOnline);
    }
}