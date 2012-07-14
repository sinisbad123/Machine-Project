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
    public partial class WebForm2 : System.Web.UI.Page
    {
        string strConnString = "Server=IMAC-PC\\sa;Database=ANG_MARCUS;UID=sa;PWD=benilde";
        SqlConnection scnMarcus;
        

        void RefreshGrid1()
        {
            scnMarcus.Open();
            string strRefreshGrid = "Select * from tblBlueForm Where IDNumber = '" + Session["IDNumber"].ToString() + "'";
            SqlCommand scmRefreshGrid = new SqlCommand(strRefreshGrid, scnMarcus);
            SqlDataReader sdrRefreshGrid = scmRefreshGrid.ExecuteReader();
            GridView1.DataSource = sdrRefreshGrid;
            GridView1.DataBind();
            sdrRefreshGrid.Dispose();
            scmRefreshGrid.Dispose();
            scnMarcus.Close();
        }

        void RefreshGrid2()
        {
            scnMarcus.Open();
            string strRefreshGrid = "Select * from tblProfile Where IDNumber = '" + Session["IDNumber"].ToString() + "'";
            SqlCommand scmRefreshGrid = new SqlCommand(strRefreshGrid, scnMarcus);
            SqlDataReader sdrRefreshGrid = scmRefreshGrid.ExecuteReader();
            GridView2.DataSource = sdrRefreshGrid;
            GridView2.DataBind();
            sdrRefreshGrid.Dispose();
            scmRefreshGrid.Dispose();
            scnMarcus.Close();
 
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            scnMarcus = new SqlConnection(strConnString);

            RefreshGrid1();
            RefreshGrid2();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("BlueFormFillUp.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProfileInformationEditing.aspx");

        }
    }
}