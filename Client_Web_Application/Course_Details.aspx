<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Course_Details.aspx.cs" Inherits="Client_Web_Application.Course_Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Label ID="lblMessage1" runat="server" Font-Bold="True" Font-Size="Larger" style="z-index: 1; left: 366px; top: 23px; position: absolute; width: 445px" Text="Please enter the participant details below"></asp:Label>
        <br />
        <asp:Label ID="lblContactNumber" runat="server" style="z-index: 1; left: 692px; top: 79px; position: absolute; width: 119px; height: 26px" Text="Contact Number"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblDateOfBirth" runat="server" style="z-index: 1; left: 694px; top: 136px; position: absolute; height: 20px" Text="Date Of Birth"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblDepartment" runat="server" style="z-index: 1; left: 122px; top: 355px; position: absolute" Text="Department"></asp:Label>
        <asp:TextBox ID="txtContactNumber" runat="server" style="z-index: 1; left: 861px; top: 79px; position: absolute"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblDietryRequirement" runat="server" style="z-index: 1; left: 695px; top: 330px; position: absolute" Text="Dietry Requirement"></asp:Label>
        <br />
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 697px; top: 256px; position: absolute" Text="Email"></asp:Label>
        <asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 864px; top: 137px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtFullName" runat="server" style="z-index: 1; left: 254px; top: 81px; position: absolute"></asp:TextBox>
        <br />
        <asp:Label ID="lblEmploymentStatus" runat="server" style="z-index: 1; left: 120px; top: 423px; position: absolute" Text="Employment Status"></asp:Label>
        <asp:DropDownList ID="DropDownList_OrganizationSize" runat="server" AutoPostBack="True" style="z-index: 1; left: 867px; top: 402px; position: absolute; height: 17px; width: 127px">
        </asp:DropDownList>
        <br />
        <asp:DropDownList ID="DropDownList_Gender" runat="server" style="z-index: 1; left: 865px; top: 198px; position: absolute; width: 120px">
        </asp:DropDownList>
        <br />
        <br />
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 864px; top: 256px; position: absolute; height: 22px; right: 293px; bottom: 241px"></asp:TextBox>
        <br />
        <asp:Label ID="lblGender" runat="server" style="z-index: 1; left: 694px; top: 198px; position: absolute" Text="Gender"></asp:Label>
        <asp:Label ID="lblFullName" runat="server" style="z-index: 1; left: 127px; top: 82px; position: absolute; width: 80px" Text="Full Name"></asp:Label>
        <br />
        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" style="z-index: 1; left: 459px; top: 647px; position: absolute; width: 198px" Text="Submit" />
        <br />
        <asp:Label ID="lblIdNumber" runat="server" style="z-index: 1; left: 127px; top: 223px; position: absolute; height: 17px" Text="Id Number"></asp:Label>
        <asp:TextBox ID="txtSalutation" runat="server" style="z-index: 1; left: 259px; top: 158px; position: absolute"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="lblJobTitle" runat="server" style="z-index: 1; left: 126px; top: 289px; position: absolute; height: 20px; width: 54px" Text="Job Title"></asp:Label>
        <br />
        <asp:TextBox ID="txtIdnumber" runat="server" style="z-index: 1; left: 257px; top: 224px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtJobTitle" runat="server" style="z-index: 1; left: 268px; top: 290px; position: absolute"></asp:TextBox>
        <asp:DropDownList ID="DropDownList_SalaryRange" runat="server" style="z-index: 1; left: 268px; top: 486px; position: absolute; height: 16px; width: 116px">
        </asp:DropDownList>
        <br />
        <asp:Label ID="lblNationality" runat="server" style="z-index: 1; left: 699px; top: 469px; position: absolute" Text="Nationality"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblOrganizationSite" runat="server" style="z-index: 1; left: 696px; top: 400px; position: absolute" Text="Organization size"></asp:Label>
        <asp:TextBox ID="txtDepartment" runat="server" style="z-index: 1; left: 268px; top: 356px; position: absolute"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="lblMessage2" runat="server" style="z-index: 1; left: 13px; top: 576px; position: absolute; width: 458px"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtEmploymentStatus" runat="server" style="z-index: 1; left: 267px; top: 425px; position: absolute"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:TextBox ID="txtDietryRequirements" runat="server" style="z-index: 1; left: 865px; top: 331px; position: absolute"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:TextBox ID="txtNationality" runat="server" style="z-index: 1; left: 862px; top: 470px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtClassId" runat="server" style="z-index: 1; left: 862px; top: 536px; position: absolute"></asp:TextBox>
        <br />
        <asp:Label ID="lblSalaryRange" runat="server" style="z-index: 1; left: 120px; top: 486px; position: absolute" Text="Salary Range"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblSalutation" runat="server" style="z-index: 1; left: 125px; top: 157px; position: absolute; right: 1101px" Text="Salutation"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="lblClassId" runat="server" style="z-index: 1; left: 695px; position: absolute; height: 19px; top: 537px" Text="Class Id"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
