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
    public partial class WebForm4 : System.Web.UI.Page
    {
        string strConnString = "Server=IMAC-PC\\sa;Database=ANG_MARCUS;UID=sa;PWD=benilde";
        SqlConnection scnMarcus;

        void RefreshGrid()
        {
            scnMarcus.Open();
            string strGetApproved = "Select * from tblBlueForm Where BlueFormStatus = 'Pending Approval of the Chairperson' Or BlueFormStatus = 'Approved'";
            SqlCommand scmGetApproved = new SqlCommand(strGetApproved, scnMarcus);
            SqlDataReader sdrGetApproved = scmGetApproved.ExecuteReader();
            GridView1.DataSource = sdrGetApproved;
            GridView1.DataBind();
            sdrGetApproved.Dispose();
            scmGetApproved.Dispose();
            scnMarcus.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            scnMarcus = new SqlConnection(strConnString);

            RefreshGrid();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session.Add("ApproveBlueFormID", GridView1.SelectedRow.Cells[1].Text);
        
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            scnMarcus.Open();
            string strApprove = "Update tblBlueForm SET BlueFormStatus = 'Approved' Where BlueFormID = '" + int.Parse(Session["ApproveBlueFormID"].ToString()) + "'";
            SqlCommand scmApprove = new SqlCommand(strApprove, scnMarcus);
            scmApprove.ExecuteNonQuery();
            scmApprove.Dispose();
            scnMarcus.Close();

            RefreshGrid();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            scnMarcus.Open();
            string strDeny = "Update tblBlueForm SET BlueFormStatus = 'Denied' Where BlueFormID = '" + int.Parse(Session["ApproveBlueFormID"].ToString()) + "'";
            SqlCommand scmDeny = new SqlCommand(strDeny, scnMarcus);
            scmDeny.ExecuteNonQuery();
            scmDeny.Dispose();
            scnMarcus.Close();

            RefreshGrid();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }

        
    }
}