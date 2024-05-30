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
        //create a new instance of clsSuuplier
        clsSupplier AnSupplier = new clsSupplier();
        //get the date from the session object
        AnSupplier = (clsSupplier)Session["AnSupplier"];
        //display the Email for this entry
        Response.Write(AnSupplier.Email);

    }
}