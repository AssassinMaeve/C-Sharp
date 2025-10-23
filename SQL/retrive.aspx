<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="retrive.aspx.cs" Inherits="SQL.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:ButtonField CommandName="Delete" Text="Delete" />
                <asp:HyperLinkField NavigateUrl="~/confirm.aspx" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Data" />
&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Insert" />
&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
&nbsp;
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" style="height: 26px" Text="Update" />
    </form>
</body>
</html>
