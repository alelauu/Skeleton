using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox7_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();
        AnCustomer.FullName = txtFullName.Text;
        AnCustomer.Email = txtEmail.Text;
        AnCustomer.PostCode = txtPostCode.Text;
        AnCustomer.IsOnline = chkIsOnline.Checked;
        AnCustomer.DateOfBirth = Convert.ToDateTime(DateTime.Now);
        AnCustomer.CustomerId = Convert.ToInt32(txtCustomerId.Text);
        AnCustomer.StreetAddress = txtStreetAddress.Text;
        AnCustomer.PhoneNumber = txtPhoneNumber.Text;
        //navigate to the view page 
        Response.Redirect("CustomerViewer.aspx");
    }
}