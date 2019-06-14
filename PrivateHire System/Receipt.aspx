<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Receipt.aspx.cs" Inherits="PrivateHire_System.Receipt" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">       
        
         <p>
        <asp:Label ID="Label14" runat="server" Font-Size="XX-Large" Text="PrivateHire Car"></asp:Label>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Receipt" Font-Bold="True" Font-Underline="True"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Email:"></asp:Label>
        <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label15" runat="server" Text="Credit Card No:"></asp:Label>
        <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label8" runat="server" Text="Date:"></asp:Label>
        <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label7" runat="server" Text="Total Price With Discount:"></asp:Label>
        <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label12" runat="server" Text="Amount Paid:"></asp:Label>
        <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <div class="form-group">
	<asp:Button ID="Button1" runat="server"   class="btn float-lifet login_btn" onclick="Button1_Click" Text="Print"/>
			</div>
    </p>

        <br />
        <br />

        </div>




</asp:Content>
