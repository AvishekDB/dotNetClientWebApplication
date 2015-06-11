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
        <br />
        <asp:Button ID="btnVerify" runat="server" OnClick="btnVerify_Click" style="z-index: 1; left: 27px; top: 188px; position: absolute; width: 88px" Text="Log In" />
        <br />
        <br />
        <asp:Label ID="lblOutput" runat="server" style="z-index: 1; left: 26px; top: 230px; position: absolute; width: 314px; height: 27px"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="btnGetStudentList" runat="server" style="z-index: 1; left: 25px; top: 317px; position: absolute; width: 116px" Text="Get Student List" OnClick="btnGetStudentList_Click" />
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
