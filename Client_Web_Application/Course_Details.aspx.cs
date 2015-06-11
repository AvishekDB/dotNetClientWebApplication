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
              gender=txtGender.Text;
              jobTitle=txtJobTitle.Text;
              idNumber=txtIdnumber.Text;
              nationality=txtNationality.Text;
               organizationSize=txtOrganizationSite.Text;
              classId=txtClassId.Text;
              salaryRange=txtSalaryRange.Text;
              salutation = txtSalutation.Text;
            
       

            participant.ContactNumber = contactNumber;
            participant.DateOfBirth=dateOfBirth;
            participant.Department= department;
            participant.DietaryRequirement= dietryRequirement;
            participant.Email= email;
            participant.EmploymentStatus= employmentStatus;
            participant.FullName=fullName;
            TeamServiceReferenceCourseRegistration.Gender gender1 = (TeamServiceReferenceCourseRegistration.Gender)Enum.Parse(typeof(TeamServiceReferenceCourseRegistration.Gender), gender);
            participant.Gender = gender1;
            participant.JobTitle= jobTitle;
            participant.IdNumber= idNumber;
            participant.Nationality= nationality;          
            TeamServiceReferenceCourseRegistration.OrganizationSize organizationsize = (TeamServiceReferenceCourseRegistration.OrganizationSize)Enum.Parse(typeof(TeamServiceReferenceCourseRegistration.OrganizationSize), organizationSize);
            participant.OrganizationSize = organizationsize;
            TeamServiceReferenceCourseRegistration.SalaryRange salaryrange1 = (TeamServiceReferenceCourseRegistration.SalaryRange)Enum.Parse(typeof(TeamServiceReferenceCourseRegistration.SalaryRange), salaryRange);
            participant.SalaryRange=salaryrange1;
            participant.Salutation = salutation;
            courseClass.ClassId=classId;
           
            
             TeamServiceReferenceCourseRegistration.CourseRegistrationServiceClient client = new TeamServiceReferenceCourseRegistration.CourseRegistrationServiceClient();
             
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