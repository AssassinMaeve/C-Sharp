<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASMX.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Number-1:&nbsp;
        <asp:TextBox ID="NumBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Number-2:&nbsp;
        <asp:TextBox ID="NumBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="AddButton_Click" Width="100px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Sub" OnClick="SubButton_Click" Width="101px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Mul" OnClick="MulButton_Click" Width="101px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="Div" OnClick="DivButton_Click" Width="101px" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="The Result will be displayed here"></asp:Label>
    </form>
</body>
</html>
