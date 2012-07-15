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
    public partial class WebForm1 : System.Web.UI.Page
    {
        string strConnString = "Server=IMAC-PC\\sa;Database=ANG_MARCUS;UID=sa;PWD=benilde";
        SqlConnection scnMarcus;

        protected void Page_Load(object sender, EventArgs e)
        {
            scnMarcus = new SqlConnection(strConnString);
        }

        //void GetPosition()
        //{
        //    scnMarcus.Open();

        //    string strValidateAccount = "Select * from tblAccount Where UserName = '" + txtUserName.Text + "' AND Password = '" + txtPassword.Text + "'"; 

        //    SqlDataAdapter sdaValidateAccount = new SqlDataAdapter(strValidateAccount, scnMarcus);
        //    DataTable dt = new DataTable();
        //    sdaValidateAccount.Fill(dt);
        //    Session.Add("Position", dt.Rows[0][2].ToString());
        //    Session.Add("IDNumber", dt.Rows[0][0].ToString());
        //    sdaValidateAccount.Dispose();

        //    scnMarcus.Close();
        //}

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strValidateAccount = "Select * from tblAccount Where UserName = '" + txtUserName.Text + "' AND Password = '" + txtPassword.Text + "'";

            
            

            //GetPosition();

            scnMarcus.Open();

            SqlCommand scmValidateACcount = new SqlCommand(strValidateAccount, scnMarcus);
            SqlDataReader sdrValidateAccount = scmValidateACcount.ExecuteReader();
            



            

            

           


            if (sdrValidateAccount.HasRows)
            {
                sdrValidateAccount.Dispose();
                SqlDataAdapter sdaValidateAccount = new SqlDataAdapter(strValidateAccount, scnMarcus);
                DataTable dt = new DataTable();
                sdaValidateAccount.Fill(dt);
                Session.Add("Position", dt.Rows[0][2].ToString());
                Session.Add("IDNumber", dt.Rows[0][0].ToString());
                sdaValidateAccount.Dispose();
                

                string strPosition = Session["Position"].ToString();

                if (strPosition == "Student")
                {
                    Response.Redirect("WebForm2.aspx");

                }

                else
                {
                    if (strPosition == "Academic Adviser")
                    {
                        Response.Redirect("WebForm3.aspx");
                    }

                    else
                    {
                        Response.Redirect("WebForm4.aspx");
                    }
                }
            }

            else
            {
                Response.Redirect("WebForm5.aspx");
 
            }

            scnMarcus.Close();
            
        }
    }
}