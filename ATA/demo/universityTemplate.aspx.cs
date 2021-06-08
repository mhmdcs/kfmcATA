using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATA.demo
{
    public partial class universityTemplate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write("Hello, how are you doing today");
            // lblMsg.Text = "Please make your selection from the available options";

            populateUniversityCombo(); // method call

        }

        protected void ddlUniversity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void populateUniversityCombo()
        {
            //code to connect to db and pull universty information

        }

    }
}