<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="applyForAttendance.aspx.cs" Inherits="Client_Web_Application.Function" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Label ID="lblParticipantId" runat="server" style="z-index: 1; left: 10px; top: 35px; position: absolute; width: 103px" Text="Participant Id"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="txtParticipantId" runat="server" style="z-index: 1; left: 215px; top: 34px; position: absolute; width: 162px; height: 25px; bottom: 460px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="lblClassId" runat="server" style="z-index: 1; left: 10px; top: 129px; position: absolute; width: 103px" Text="Class Id"></asp:Label>
        <br />
    
    </div>
        <asp:TextBox ID="txtClassId" runat="server" style="z-index: 1; left: 220px; top: 117px; position: absolute; height: 25px; width: 164px"></asp:TextBox>
        <asp:Button ID="btnGiveAttendance" runat="server" OnClick="lblGiveAttendance_Click" style="z-index: 1; left: 59px; top: 194px; position: absolute; width: 115px; height: 25px" Text="Enter Attendance" />
        <asp:Label ID="lblTxtMessage" runat="server" style="z-index: 1; left: 302px; top: 201px; position: absolute; width: 433px; height: 28px"></asp:Label>
    </form>
</body>
</html>
