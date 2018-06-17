<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendMailOutlook.aspx.cs" Inherits="SendMailAsp.SendMailOutlook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            &nbsp;Send Email to : &nbsp;&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DropDownListEmail" runat="server" Width="309px">
            </asp:DropDownList>
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ButtonSendMail" runat="server" OnClick="ButtonSendMail_Click" style="margin-left: 84px" Text="Send Mail" Width="289px" />
        </div>
    </form>
</body>
</html>