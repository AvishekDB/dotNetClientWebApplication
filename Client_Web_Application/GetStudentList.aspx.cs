﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ServiceModel;

namespace Client_Web_Application
{
    public partial class SubmitAttendance : System.Web.UI.Page
    {
        static string classId;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridViewStudentList.Visible = false;
        }

        protected void btnGetStudentList_Click(object sender, EventArgs e)
        {
            String userName=Session["UserName"].ToString();
            String passWord = Session["PassWord"].ToString();
            String date = txtDate.Text;
            DateTime dateTime = new DateTime();
            dateTime = DateTime.ParseExact(date, "yyyy-MM-dd", null);

            SubmitAttendance.classId   = txtClassId.Text;

            try
            {
                TeamServiceReference.AttendanceServiceClient client = new TeamServiceReference.AttendanceServiceClient();

                try
                {
                    client.ClientCredentials.UserName.UserName = userName;
                    client.ClientCredentials.UserName.Password = passWord;
                    client.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = System.ServiceModel.Security.X509CertificateValidationMode.PeerOrChainTrust;
                }
                catch(Exception ex)
                {
                    lblMessage.Text = ex.Message.ToString();
                }
             
                TeamServiceReference.SvcStudent[] receivedStudentList = client.GetStudentList(dateTime, classId);

              // string[] dbdh=ToArray<string>(receivedStudentList);
                
                if (receivedStudentList != null)
                {
                    GridViewStudentList.Visible = true;
                    GridViewStudentList.DataSource = receivedStudentList;
                    GridViewStudentList.DataBind();
                    lblMessage.Text = "The list of student enrolled in class " + classId + " on " + dateTime + " are provided follow";
                }

                else
                {
                    lblMessage.Text = "You entered wrong Course Id and Date";
                }
            
            }
            catch(Exception ex)
            {
                lblMessage.Text = "An error occured " + ex.ToString();
            }

           
               
            


        }

        protected void GridViewStudentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = GridViewStudentList.SelectedRow.Cells[1].Text;

            lblMessage.Text = "You selected " + name + " ";
        }

        protected void btnPresent_Click(object sender, EventArgs e)
        {

        }

        protected void GridViewStudentList_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "studentPresent")
            {
                String userName = Session["UserName"].ToString();
                String passWord = Session["PassWord"].ToString();
                // Retrieve the row index stored in the CommandArgument property.
                int index = Convert.ToInt32(e.CommandArgument);
                TeamServiceReference.Result result = new TeamServiceReference.Result();
                // Retrieve the row that contains the button from the Rows collection.
                GridViewRow row = GridViewStudentList.Rows[index];
                int id = Convert.ToInt32(row.Cells[7].Text);
                TeamServiceReference.AttendanceServiceClient client = new TeamServiceReference.AttendanceServiceClient();
                try
                {
                    client.ClientCredentials.UserName.UserName = userName;
                    client.ClientCredentials.UserName.Password = passWord;
                    client.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = System.ServiceModel.Security.X509CertificateValidationMode.PeerOrChainTrust;
                }
                catch (Exception ex)
                {
                    lblMessage.Text = ex.Message.ToString();
                }
                string classid1 = SubmitAttendance.classId;
               result= client.SubmitAttendance(id, classId);
               lblMessage.Text = result.Message;

              
            }

        }
    }
}