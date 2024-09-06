<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdoWebform2.aspx.cs" Inherits="Ado2Practice.AdoWebform2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Connecting to SQL Server<br />
            <br />
            <asp:Button ID="btnConnect" runat="server" OnClick="btnConnect_Click" Text="Connect" />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="lblMessage" runat="server" Text="Loading..."></asp:Label>
        </div>
    </form>
</body>
</html>
