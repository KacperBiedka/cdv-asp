<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginBackup.aspx.cs" Inherits="ProjektASP.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Logowanie</title>
    <link rel="stylesheet" href="StyleSheet1.css"/>
</head>
<body>  
    <form id="form1" class="loginForm" runat="server"> 
        <asp:TextBox runat="server" ID="txtUserId" placeholder="Login" />
        <br />
        <asp:TextBox runat="server" ID="txtPassword" placeholder="Hasło" TextMode="Password" />
        <br />
        <asp:Button runat="server" ID="btnLogin" Text="zaloguj" OnClick="btnLogin_Click"/>
        <br />
        <asp:Label runat="server" ID="txtInfo" />
    </form>  
</body> 
</html>
