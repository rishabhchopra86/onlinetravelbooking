<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeatsArrangement.aspx.cs" Inherits="WebSite.Admin.SeatsArrangement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <div style="border:1px solid grey;height:100px;width:30%;align-items:center">
            <br />
            <asp:TextBox ID="txtRows" runat="server" placeholder="Number of rows"></asp:TextBox>
              <asp:TextBox ID="txtColumns" runat="server" placeholder="Number of columns"></asp:TextBox>

        </div>


       <asp:Button ID="btnAddTextBox" runat="server" Text="Add" OnClick="btnAddTextBox_Click" />
        <asp:Button ID="btnWriteValues" runat="server" Text="Write" OnClick="btnWriteValues_Click" />
        <asp:PlaceHolder ID="phControls" runat="server" />

        <div runat="server" id="dynamic">

        </div>
    </div>
    </form>
</body>
</html>
