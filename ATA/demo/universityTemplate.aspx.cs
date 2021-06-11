using ATA.App_Code;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            if (!Page.IsPostBack) /// means do it only once for each user session
            {
            // everything here will be executed first 
                //Response.Write("Hello, how are you doing today");
                // lblMsg.Text = "Please make your selection from the available options";

                populateUniversityCombo(); // method call
                                       // populateUniversityTemplateCombo();
            }
        }

        protected void ddlUniversity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void populateUniversityCombo()
        {
            //code to connect to db and pull universty information
            CRUD myCrud = new CRUD();
            string mySql = "select institutionId, institution from institution";
            SqlDataReader dr = myCrud.getDrPassSql(mySql);
            ddlUniversity.DataValueField = "institutionId";
            ddlUniversity.DataTextField = "institution";
            ddlUniversity.DataSource = dr;
            ddlUniversity.DataBind();


        }

        protected void populateUniversityTemplateCombo()
        {
            //code to connect to db and pull universty information
            CRUD myCrud = new CRUD();
            string mySql = "select institutionTemplateId, institutionTemplate from institutionTemplate";
            SqlDataReader dr = myCrud.getDrPassSql(mySql);
            ddlTemplate.DataValueField = "institutionTemplateId";
            ddlTemplate.DataTextField = "institutionTemplate";
            ddlTemplate.DataSource = dr;
            ddlTemplate.DataBind();


        }

        protected void ddlUniversity_SelectedIndexChanged1(object sender, EventArgs e)
        {
            //code to connect to db and pull universty information
            CRUD myCrud = new CRUD();
            string mySql = @"select * from institutionTemplate 
                            where institutionId = @institutionId";
            Dictionary<String, object> myPara = new Dictionary<string, object>();
            myPara.Add("@institutionId", ddlUniversity.SelectedValue);

            SqlDataReader dr = myCrud.getDrPassSql(mySql, myPara);
            ddlTemplate.DataValueField = "institutionTemplateId";
            ddlTemplate.DataTextField = "institutionTemplate";
            ddlTemplate.DataSource = dr;
            ddlTemplate.DataBind();
        }
    }
}