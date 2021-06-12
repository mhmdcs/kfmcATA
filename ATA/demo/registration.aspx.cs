using ATA.App_Code;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATA.demo
{
    public partial class registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // means do it only once for each user session
            {
                populateGenderCombo();
            }

        }

        protected void populateGenderCombo()
        {
            CRUD myCrud = new CRUD();
            string mySql = @"select genderId, gender from gender";
            SqlDataReader dr = myCrud.getDrPassSql(mySql);
            ddlGender.DataTextField = "gender";
            ddlGender.DataValueField = "genderId";
            ddlGender.DataSource = dr;
            ddlGender.DataBind();
        }



        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            // I put all the code that insert information into the db
            CRUD myCrud = new CRUD();
            string mySql = @"insert into student (student, active, genderId, allowance)
                            values (@student,@active,@genderId,@allowance)";
            // Dictionary object is used when the sql string query has operations like "where" or "insert"
            Dictionary<string, object> myPara = new Dictionary<string, object>();
            myPara.Add("@student", txtStudent.Text);

            if (rbtnActive1.Checked == true)
            {
            myPara.Add("@active", 1);
            }
            else if (rbtnActive2.Checked == true)
            {
            myPara.Add("@active", 0);
            }

            myPara.Add("@genderId", ddlGender.SelectedValue);
            myPara.Add("@allowance", txtAllowance.Text);

            int rtn = myCrud.InsertUpdateDelete(mySql, myPara);

            if (rtn >= 1) {
                lblOutput.Text = "Successful Operation!";
            }
            else {
                lblOutput.Text = "Failed Operation";
            }
            
        


        }
    }
}