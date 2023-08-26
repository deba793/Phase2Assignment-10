using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Phase2Assignment_10
{
    public partial class ProductRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                PrdCategory.Items.Add("Sneakers");
                PrdCategory.Items.Add("Boot");
                PrdCategory.Items.Add("Sandal");
                PrdCategory.Items.Add("Loafer");
            }
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;


        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            LblInfo.Visible = true;
            LblInfo.Text = "Registration Success!!!";
            LblInfo.Text += "<br/>Product Name: " + PrdName.Text;
            LblInfo.Text += "<br/>Category: " + PrdCategory.Text;
            LblInfo.Text += "<br/>Price: " + PrdPrice.Text;
            LblInfo.Text += "<br/>Description: " + PrdDesc.Text;
            LblInfo.Text += "<br/>Release Date: " + PrdCalender.SelectedDate;

        }
    }
}