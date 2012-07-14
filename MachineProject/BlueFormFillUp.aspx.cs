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
    public partial class BlueFormFillUp : System.Web.UI.Page
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
            string strAddBlueForm = "Insert Into tblBlueForm (FirstName, LastName, Course, IDNUmber, EventName, EventOrganizer, EventVenue, AbsenceDate, AbsenceTime, ClassesAffected, ExcusedAbsences, UnexcusedAbsences, BlueFormStatus) Values ('" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtCourse.Text + "', '" + txtIDNumber.Text + "', '" + txtEventName.Text + "', '" + txtEventOrganizer.Text + "', '" + txtEventVenue.Text + "','" + txtAbsenceDate.Text + "', '" + txtAbsenceTime.Text + "', '" + txtClassesAffected.Text + "', '" + txtExcusedAbsences.Text + "', '" + txtUnexcusedAbsences.Text + "', 'Pending')";
            SqlCommand scmAddBlueForm = new SqlCommand(strAddBlueForm, scnMarcus);
            scmAddBlueForm.ExecuteNonQuery();
            scmAddBlueForm.Dispose();
            scnMarcus.Close();

            Response.Redirect("WebForm2.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }
    }
}