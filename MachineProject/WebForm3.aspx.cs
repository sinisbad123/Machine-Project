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
    public partial class WebForm3 : System.Web.UI.Page
    {
        string strConnString = "Server=IMAC-PC\\sa;Database=ANG_MARCUS;UID=sa;PWD=benilde";
        SqlConnection scnMarcus;

        void RefreshGrid()
        {
            scnMarcus.Open();
            string strRefreshGrid = "Select * from tblBlueForm";
            SqlCommand scmRefreshGrid = new SqlCommand(strRefreshGrid, scnMarcus);
            SqlDataReader sdrRefreshGrid = scmRefreshGrid.ExecuteReader();
            GridView1.DataSource = sdrRefreshGrid;
            GridView1.DataBind();
            sdrRefreshGrid.Dispose();
            scmRefreshGrid.Dispose();
            scnMarcus.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            scnMarcus = new SqlConnection(strConnString);

            RefreshGrid();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session.Add("BlueFormID", GridView1.SelectedRow.Cells[1].Text);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            scnMarcus.Open();

            string strApprove = "Update tblBlueForm SET BlueFormStatus = 'Pending Approval of the Chairperson' Where BlueFormID = '" + int.Parse(Session["BlueFormID"].ToString()) + "'";
            SqlCommand scmApprove = new SqlCommand(strApprove, scnMarcus);
            scmApprove.ExecuteNonQuery();
            scmApprove.Dispose();


            scnMarcus.Close();

            RefreshGrid();


        }

   

        protected void Button3_Click(object sender, EventArgs e)
        {
            scnMarcus.Open();

            string strDeny = "Update tblBlueForm SET BlueFormStatus = 'Denied by Academic Adviser' Where BlueFormID = '" + int.Parse(Session["BlueFormID"].ToString()) + "'";
            SqlCommand scmDeny = new SqlCommand(strDeny, scnMarcus);
            scmDeny.ExecuteNonQuery();
            scmDeny.Dispose();

            scnMarcus.Close();

            RefreshGrid();
        }
    }
}