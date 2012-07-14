using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace MachineProject
{
    public partial class ProfileInformationEditing : System.Web.UI.Page
    {
        string strConnString = "Server=IMAC-PC\\sa;Database=ANG_MARCUS;UID=sa;PWD=benilde";
        SqlConnection scnMarcus;

        

        protected void Page_Load(object sender, EventArgs e)
        {
            scnMarcus = new SqlConnection(strConnString);

            


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            scnMarcus.Open();

            int strIDNumber = int.Parse(Session["IDNumber"].ToString());

            string strUpdateProfile = "Update tblProfile SET FirstName = '" + txtFirstName.Text + "', LastName = '" + txtLastName.Text + "', YearLevel = '" + txtYearLevel.Text + "', Course = '" + txtCourse.Text + "' Where IDNumber = '" + strIDNumber + "'";
            SqlCommand scmUpdateProfile = new SqlCommand(strUpdateProfile, scnMarcus);
            scmUpdateProfile.ExecuteNonQuery();
            scmUpdateProfile.Dispose();



            scnMarcus.Close();

            Response.Redirect("WebForm2.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            

            Response.Redirect("WebForm2.aspx");
        }
    }
}