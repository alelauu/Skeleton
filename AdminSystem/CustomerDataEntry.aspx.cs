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
        string FullName = txtFullName.Text;
        string Email = txtEmail.Text;
        string PostCode = txtPostCode.Text;
        string IsOnline = chkIsOnline.Text;
        string DateOfBirth = txtDateOfBirth.Text;
        //string CustomerId = Convert.ToInt32(txtCustomerId.Text);
        string StreetAddress = txtStreetAddress.Text;
        string PhoneNumber = txtPhoneNumber.Text;
        string Error = "";
        Error = AnCustomer.Valid(DateOfBirth, FullName, StreetAddress, PostCode, Email, PhoneNumber);
        if (Error == "")
        {
            AnCustomer.FullName = FullName;
            AnCustomer.Email = Email;
            AnCustomer.PostCode = PostCode;
            AnCustomer.PhoneNumber = PhoneNumber;
            AnCustomer.StreetAddress = StreetAddress;
            AnCustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            Session["AnCustomer"] = AnCustomer;
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();
        Int32 CustomerId;
        Boolean Found = false;
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        Found = AnCustomer.Find(CustomerId);
        if (Found == true)
        {
            txtFullName.Text = AnCustomer.FullName;
            txtStreetAddress.Text = AnCustomer.StreetAddress;
            txtEmail.Text = AnCustomer.Email;
            txtPhoneNumber.Text = AnCustomer.PhoneNumber;
            txtPostCode.Text = AnCustomer.PostCode;
            txtDateOfBirth.Text = AnCustomer.DateOfBirth.ToString();
            chkIsOnline.Checked = AnCustomer.IsOnline;
        }
    }
}

 