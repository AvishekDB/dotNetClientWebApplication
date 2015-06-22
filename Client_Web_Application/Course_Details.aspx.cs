using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client_Web_Application
{
    public partial class Course_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                //DropDown populating the Salary Range


                string[] enumSalaryRange = Enum.GetNames(typeof(TeamServiceReferenceCourseRegistration.SalaryRange));
                foreach (string item in enumSalaryRange)
                {

                    int value = (int)Enum.Parse(typeof(TeamServiceReferenceCourseRegistration.SalaryRange), item);
                    ListItem listItem = new ListItem(item, value.ToString());
                    DropDownList_SalaryRange.Items.Add(listItem);
                }
                //DropDown populating the Gender


                string[] enumGender = Enum.GetNames(typeof(TeamServiceReferenceCourseRegistration.Gender));
                foreach (string item in enumGender)
                {

                    int value = (int)Enum.Parse(typeof(TeamServiceReferenceCourseRegistration.Gender), item);
                    ListItem listItem = new ListItem(item, value.ToString());
                    DropDownList_Gender.Items.Add(listItem);
                }
                //DropDown populating the Organization Size


                string[] enumOrganizationSize = Enum.GetNames(typeof(TeamServiceReferenceCourseRegistration.OrganizationSize));
                foreach (string item in enumOrganizationSize)
                {

                    int value = (int)Enum.Parse(typeof(TeamServiceReferenceCourseRegistration.OrganizationSize), item);
                    ListItem listItem = new ListItem(item, value.ToString());
                    DropDownList_OrganizationSize.Items.Add(listItem);
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string contactNumber;
            DateTime dateOfBirth= new DateTime();
            string department;
            string dietryRequirement;
            string email;
            string employmentStatus;
            string fullName;
            string jobTitle;
            string idNumber;
            string nationality;
            string classId;
            string salutation;
            string gender;
            string organizationSize;
            string salaryRange;
            bool isCompleted;

            //TeamServiceReferenceCourseRegistration.CourseRegistrationServiceClient client = new TeamServiceReferenceCourseRegistration.CourseRegistrationServiceClient();
           
            TeamServiceReferenceCourseRegistration.Result result=new TeamServiceReferenceCourseRegistration.Result();
            TeamServiceReferenceCourseRegistration.SvcParticipant participant=new TeamServiceReferenceCourseRegistration.SvcParticipant();
            TeamServiceReferenceCourseRegistration.SvcCourseClass courseClass=new TeamServiceReferenceCourseRegistration.SvcCourseClass();
             
              contactNumber=txtContactNumber.Text;
              dateOfBirth = DateTime.ParseExact(txtDateOfBirth.Text, "yyyy-MM-dd", null);
              department=txtDepartment.Text;
              dietryRequirement=txtDietryRequirements.Text;
              email=txtEmail.Text;
              employmentStatus=txtEmploymentStatus.Text;
              fullName=txtFullName.Text;
              //gender=txtGender.Text;
              jobTitle=txtJobTitle.Text;
              idNumber=txtIdnumber.Text;
              nationality=txtNationality.Text;
              // organizationSize=txtOrganizationSite.Text;
              classId=txtClassId.Text;
             // salaryRange=txtSalaryRange.Text;
              salutation = txtSalutation.Text;

            

            participant.ContactNumber = contactNumber;
            participant.DateOfBirth=dateOfBirth;
            participant.Department= department;
            participant.DietaryRequirement= dietryRequirement;
            participant.Email= email;
            participant.EmploymentStatus= employmentStatus;
            participant.FullName=fullName;

            TeamServiceReferenceCourseRegistration.Gender gender1 = (TeamServiceReferenceCourseRegistration.Gender)Enum.Parse(typeof(TeamServiceReferenceCourseRegistration.Gender), DropDownList_Gender.SelectedItem.Value);
            participant.Gender = gender1;
            participant.JobTitle= jobTitle;
            participant.IdNumber= idNumber;
            participant.Nationality= nationality;
           //Catching the Organization Size and entering them
            TeamServiceReferenceCourseRegistration.OrganizationSize organizationsize = (TeamServiceReferenceCourseRegistration.OrganizationSize)Enum.Parse(typeof(TeamServiceReferenceCourseRegistration.OrganizationSize), DropDownList_OrganizationSize.SelectedItem.Value);
            participant.OrganizationSize = organizationsize;
            TeamServiceReferenceCourseRegistration.SalaryRange salaryrange1 = (TeamServiceReferenceCourseRegistration.SalaryRange)Enum.Parse(typeof(TeamServiceReferenceCourseRegistration.SalaryRange), DropDownList_SalaryRange.SelectedItem.Value);
            participant.SalaryRange=salaryrange1;
            participant.Salutation = salutation;
            courseClass.ClassId=classId;
           
            
             TeamServiceReferenceCourseRegistration.CourseRegistrationServiceClient client = new TeamServiceReferenceCourseRegistration.CourseRegistrationServiceClient();
             try
             {
                 String userName = Session["UserName"].ToString();
                 String passWord = Session["PassWord"].ToString();
                 client.ClientCredentials.UserName.UserName = userName;
                 client.ClientCredentials.UserName.Password = passWord;
                 client.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = System.ServiceModel.Security.X509CertificateValidationMode.PeerOrChainTrust;
             }
             catch (Exception ex)
             {
                 lblMessage2.Text = ex.Message.ToString();
             }
             
             result= client.RegisterCourseForEmployee(participant,courseClass);
             if (result!=null)
            {
                isCompleted=result.bResult;
                lblMessage2.Text = result.Message;
              
            }
            else
            {
                isCompleted = result.bResult;
                lblMessage2.Text = result.Message;
            }
               
                









        }
    }
}