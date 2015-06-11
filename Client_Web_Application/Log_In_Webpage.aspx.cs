using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client_Web_Application
{
    public partial class Log_In_Webpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnGetStudentList.Visible = false;
         //  btnEnterAttendance.Visible = false;
          // btnEnterParticipantDetails.Visible = false;
        }

        protected void btnVerify_Click(object sender, EventArgs e)
        {
           string userName1 = "AVISHEK";
           string passWord1 = "AVISHEK";
            string userName = txtUserName.Text;
            string passWord = txtPawod.Text;
           // bool IsValid = false;
            //TeamServiceReference.TeamServiceClient client = new TeamServiceReference.TeamServiceClient();
           // IsValid= client.userValidation(userName, passWord);
          
            //if(IsValid)
            if (userName1 == userName && passWord1 == passWord)
            { 
                //lblOutput.Text = "Welcome " + userName + ". Password " + passWord + ". You are verified. ";
                btnGetStudentList.Visible = true;
              //  btnEnterAttendance.Visible = true;
               // btnEnterParticipantDetails.Visible = true;
                lblOutput.Text = "You are a valid user";
            }
            else 
            {
                lblOutput.Text = " Username and Password does not match. ";
                btnGetStudentList.Visible = false;
              
            }

            
        }

        protected void btnGetStudentList_Click(object sender, EventArgs e)
        {
            Response.Redirect("GetStudentList.aspx");
        }

        protected void btnEnterAttendance_Click(object sender, EventArgs e)
        {
            Response.Redirect("applyForAttendance.aspx");
        }

        protected void btnEnterParticipantDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("Course_Details.aspx");
        }
    }
}