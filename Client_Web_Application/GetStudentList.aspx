<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetStudentList.aspx.cs" Inherits="Client_Web_Application.SubmitAttendance" %>

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
        <asp:TextBox ID="txtDate" runat="server"  style="z-index: 1; left: 272px; top: 51px; position: absolute; height: 22px;"></asp:TextBox>
        <asp:Label ID="lblCourseId" runat="server" style="z-index: 1; left: 23px; top: 92px; position: absolute; width: 127px" Text="Enter Class Id"></asp:Label>
        <br />
        <asp:Label ID="lblEnterDate" runat="server" style="z-index: 1; left: 23px; top: 48px; position: absolute; height: 21px; width: 162px" Text="Enter Date"></asp:Label>
        <asp:TextBox ID="txtClassId" runat="server" style="z-index: 1; left: 272px; top: 99px; position: absolute"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblMessage" runat="server" style="z-index: 1; left: 26px; top: 202px; position: absolute; width: 304px; bottom: 304px"></asp:Label>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 448px; top: 55px; position: absolute; width: 348px" Text="Date format must be in yyyy-MM-dd"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnGetStudentList" runat="server" OnClick="btnGetStudentList_Click" style="z-index: 1; left: 25px; top: 141px; position: absolute; width: 111px" Text="Get List" />
        <br />
        <br />
        <br />
        <br />
        <br />
        .<asp:GridView ID="GridViewStudentList" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" OnSelectedIndexChanged="GridViewStudentList_SelectedIndexChanged" OnRowCommand="GridViewStudentList_RowCommand" OnRowCreated="GridViewStudentList_RowCreated">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />



            <Columns>
<asp:TemplateField>
  <ItemTemplate>
     <asp:Button ID="btnPresent" runat="server" CommandName="studentPresent" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" Text="Present" />
  </ItemTemplate>
</asp:TemplateField>
 
</Columns>
        </asp:GridView>
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
        .<br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
