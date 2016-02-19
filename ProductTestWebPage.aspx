<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductTestWebPage.aspx.cs" Inherits="Client.ProductTestWebPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">


        <asp:TextBox ID="txtBoxProdID" runat="server"></asp:TextBox><asp:Label ID="Label1" runat="server" Text="Enter Product ID"></asp:Label><br />
        <br />
        <asp:Button ID="btnFindProduct" runat="server" Text="Get Product Details" OnClick="btnFindProduct_Click" />
        <br />
        <br />
      
        <asp:Label ID="lblError" runat="server" Text=""></asp:Label>


        <h2 runat="server" id="myHeader"><u>Product Information:</u></h2>
        <asp:Panel ID="panelProdInfo" runat="server">

            <table>

                <tr>
                    <td><b>Product ID: </b></td>
                    <td><asp:Label ID="lblID" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td><b>Product Title: </b></td>
                    <td><asp:Label ID="lblTitle" runat="server" Text=""></asp:Label></td>
                </tr>
                <tr>
                    <td><b>Description: </b></td>
                    <td><asp:Label ID="lblDescription" runat="server" Text=""></asp:Label></td>
                </tr>

                <tr>
                    <td><b>Product Type: </b></td>
                     <td><asp:Label ID="lblType" runat="server" Text=""></asp:Label></td>
                </tr>

                <tr>
                    <td><b>Price: </b></td>
                    <td><asp:Label ID="lblPrice" runat="server" Text=""></asp:Label> </td>
                </tr>


            </table>

        </asp:Panel>
    </form>
</body>
</html>
