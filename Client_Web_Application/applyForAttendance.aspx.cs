using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client_Web_Application
{
    public partial class Function : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lblGiveAttendance_Click(object sender, EventArgs e)
        {
            string participantId = txtParticipantId.Text;
            string classId = txtClassId.Text;
            bool successfullEntryOfAttendance = false;
            try
            {
                TeamServiceReference.AttendanceServiceClient client = new TeamServiceReference.AttendanceServiceClient();
                //successfullEntryOfAttendance = client.provideAttendance(participantId, classId);
                //if(successfullEntryOfAttendance)
                //{
                //    lblTxtMessage.Text = "The attendance was updated successfully";
                //    btnGiveAttendance.Visible = false;
                //}
                //else
                //{
                //    lblTxtMessage.Text = "The attendance was updated unsuccessfully";
                //    btnGiveAttendance.Visible = false;
                //}
            }
            catch(Exception ex)
            {
                lblTxtMessage.Text = "An Error occured " + ex.ToString() + " .";
            }
           

        }
    }
}