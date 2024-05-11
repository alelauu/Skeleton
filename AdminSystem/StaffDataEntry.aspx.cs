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

    }

    protected void Button1_Click2(object sender, EventArgs e)
    {

    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of the Staff class

        clsStaff NewStaff = new clsStaff();

        //Create  a variable to store the primary key
        Int32 StaffId;

        //Create a variable to store the result of the "Find" operation
        Boolean Found = false;

        //Retrieve the primary key entered by the user
        StaffId = Convert.ToInt32(txtStaffId.Text);

        //fIND THE RECORD
        Found = NewStaff.Find(StaffId);

        if (Found == true)
        {
           //Display the properties on the form

           
            txtFullName.Text = NewStaff.FullName;
            txtEmail.Text = NewStaff.Email;
            txtPostCode.Text = NewStaff.PostCode;
            txtNumber.Text = NewStaff.Number;
            txtStartDate.Text = NewStaff.StartDate.ToString();
            chkIsOnline.Checked = NewStaff.IsOnline;

        }


    }
}