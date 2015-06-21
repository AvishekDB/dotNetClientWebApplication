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
            btnCrsRgs.Visible = false;
        }

        protected void btnVerify_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPawod.Text;
            Session["UserName"] = txtUserName.Text;
            Session["PassWord"] = txtPawod.Text;
            if (txtRole.Text == "Teacher")
            {
                try
                {
                    //TeamServiceReference.TeamServiceClient client = new TeamServiceReference.TeamServiceClient();
                    TeamServiceReference.AttendanceServiceClient client = new TeamServiceReference.AttendanceServiceClient();
                    client.ClientCredentials.UserName.UserName = userName;
                    client.ClientCredentials.UserName.Password = passWord;
                   // client.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = System.ServiceModel.Security.X509CertificateValidationMode.PeerOrChainTrust;
                    btnGetStudentList.Visible = true;
                    btnCrsRgs.Visible = false;
                  //  lblOutput.Text = Session["PassWord"].ToString();
                }

                catch (Exception exception)
                {
                    lblOutput.Text = exception.Message.ToString();
                    btnGetStudentList.Visible = false;
                    btnCrsRgs.Visible = false;
                }
            }

            else if (txtRole.Text == "HR")
            {
                try
                {
                    TeamServiceReferenceCourseRegistration.CourseRegistrationServiceClient client1 = new TeamServiceReferenceCourseRegistration.CourseRegistrationServiceClient();
                    client1.ClientCredentials.UserName.UserName = userName;
                    client1.ClientCredentials.UserName.Password = passWord;
                   // client1.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = System.ServiceModel.Security.X509CertificateValidationMode.PeerOrChainTrust;
                    
                    btnGetStudentList.Visible = false;
                    btnCrsRgs.Visible = true;
                }

                catch (Exception exception)
                {
                    lblOutput.Text = exception.Message.ToString();
                    btnGetStudentList.Visible = false;
                    btnCrsRgs.Visible = false;
                }
            }

            else
            {
                btnGetStudentList.Visible = false;
                btnCrsRgs.Visible = false;
                lblOutput.Text = " Please enter valid UserName and Password ";
            }
          
           // bool IsValid = false;
            //TeamServiceReference.TeamServiceClient client = new TeamServiceReference.TeamServiceClient();
           // IsValid= client.userValidation(userName, passWord);
          
            //if(IsValid)
           

            
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

        protected void btnCrsRgs_Click(object sender, EventArgs e)
        {
            Response.Redirect("Course_Details.aspx");
        }
    }
}