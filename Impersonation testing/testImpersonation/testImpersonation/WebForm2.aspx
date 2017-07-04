<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="testImpersonation.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="Last_NOR_Used" HeaderText="Last_NOR_Used" SortExpression="Last_NOR_Used" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:GBS_CR_EAST_AUTOMATIONSConnectionString %>" SelectCommand="SELECT * FROM [CCA_CensecNOR]"></asp:SqlDataSource>
    <div>
    
    </div>
    </form>
</body>
</html>
