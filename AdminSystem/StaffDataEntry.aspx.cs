using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Create a new instance of clsStaff
        clsStaff NewStaff = new clsStaff();

        //Capturethe details
        NewStaff.FullName = txtFullName.Text;
        NewStaff.Email = txtEmail.Text;
        NewStaff.PostCode = txtPostCode.Text;
        NewStaff.Number = txtNumber.Text;
        NewStaff.StartDate = Convert.ToDateTime(DateTime.Now);
        NewStaff.IsOnline = chkIsOnline.Checked;
        Session["NewStaff"] = NewStaff;
        
        
        //Redirects back to the view:
        Response.Redirect("StaffViewer.aspx");
    }
}