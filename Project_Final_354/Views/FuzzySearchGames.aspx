<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FuzzySearchGames.aspx.cs" Inherits="Project_Final_354.Views.FuzzySearchGames" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="gameName" runat="server"></asp:TextBox>
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="metadata=res://*/Model.csdl|res://*/Model.ssdl|res://*/Model.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=.;initial catalog=ProjectDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" 
                SelectCommand="select * from Games where (GameName like '%' @gameName+'%')">
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>

<%--you need to make sure that the link to this page works properly--%>
