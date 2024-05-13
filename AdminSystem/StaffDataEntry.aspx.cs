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

    protected void Button1_Click1(object sender, EventArgs e)
    {
        //Creates an instance of the Staff class

        clsStaff NewStaff = new clsStaff();

        // Creates a variable to store the primary key
        Int32 StaffId;

        //Creates a variable to store the result of the find operation
        Boolean Found = false;

        //Retrieves the primary key entered by the user:
        StaffId = Convert.ToInt32(txtStaffId.Text);

        //Finds the record:
        Found = NewStaff.Find(StaffId);

        //If found:
        if(Found == true)
        {
            //Display the values
            txtFullName.Text = NewStaff.FullName;
            txtEmail.Text = NewStaff.Email;
            txtPostCode.Text = NewStaff.PostCode;
            txtNumber.Text = NewStaff.Number;
            txtStartDate.Text = NewStaff.PostCode;
            chkIsOnline.Checked = NewStaff.IsOnline;
        }
    }
}