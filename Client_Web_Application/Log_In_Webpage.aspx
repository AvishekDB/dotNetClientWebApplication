<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Log_In_Webpage.aspx.cs" Inherits="Client_Web_Application.Log_In_Webpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <br />
        <br />
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 253px; top: 69px; position: absolute; height: 19px; width: 212px;"></asp:TextBox>
        <asp:TextBox ID="txtPawod" runat="server" style="z-index: 1; left: 254px; top: 117px; position: absolute; height: 19px; width: 213px; right: 810px;"></asp:TextBox>
        <br />
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 23px; top: 70px; position: absolute; width: 108px" Text="User Name"></asp:Label>
        <br />
        <asp:Label ID="lblPawod" runat="server" style="z-index: 1; left: 24px; top: 119px; position: absolute; height: 19px; width: 108px" Text="Password"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblMessage1" runat="server" style="z-index: 1; left: 553px; top: 173px; position: absolute; width: 475px" Text="Enter &quot;Teacher&quot; if you are a teacher and if you are a HR enter &quot;HR&quot; "></asp:Label>
        <br />
        <asp:Button ID="btnVerify" runat="server" OnClick="btnVerify_Click" style="z-index: 1; left: 15px; top: 251px; position: absolute; width: 88px" Text="Log In" />
        <asp:TextBox ID="txtRole" runat="server" style="z-index: 1; left: 253px; top: 172px; position: absolute; width: 212px"></asp:TextBox>
        <asp:Label ID="lblType" runat="server" style="z-index: 1; left: 25px; top: 170px; position: absolute; width: 65px" Text="Enter your Role"></asp:Label>
        <br />
        <asp:Button ID="btnCrsRgs" runat="server" style="z-index: 1; left: 210px; top: 356px; position: absolute; width: 164px; right: 911px" Text="Enter Registration Details" OnClick="btnCrsRgs_Click" />
        <br />
        <asp:Label ID="lblOutput" runat="server" style="z-index: 1; left: 16px; top: 304px; position: absolute; width: 314px; height: 27px"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btnGetStudentList" runat="server" style="z-index: 1; left: 24px; top: 355px; position: absolute; width: 116px" Text="Get Student List" OnClick="btnGetStudentList_Click" />
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
