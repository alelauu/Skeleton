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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsSupplier
        clsSupplier AnSupplier = new clsSupplier();
        //capture the Email
        AnSupplier.Email = txtEmail.Text;
        AnSupplier.SupplierId = Convert.ToInt32(txtSupplierID.Text);
        AnSupplier.CompanyName = txtCompanyName.Text;
        AnSupplier.Address = txtAddress.Text;
        AnSupplier.Postcode = txtPostcode.Text;
        AnSupplier.QualityAssurance = chkQualityAssurance.Checked;
        AnSupplier.ContactPhone = txtContactPhone.Text;
        AnSupplier.QuantityOrdered = Convert.ToInt32(txtQuantiyOrdered.Text);
        AnSupplier.DeliveryDate = Convert.ToDateTime(txtDeliveryDate.Text);


        //store the Supplier in the session object
        Session["AnSupplier"] = AnSupplier;




        //navigate to the view page
        Response.Redirect("SupplierViewer.aspx");

    }


    }
