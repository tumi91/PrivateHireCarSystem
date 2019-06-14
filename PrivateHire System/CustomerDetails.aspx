<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="CustomerDetails.aspx.cs" Inherits="PrivateHire_System.CustomerReview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

 

      
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<!------ Include the above in your HEAD tag ---------->
    <link rel="stylesheet" type="text/css" href="Content/StyleSheetCustomer.css">
    
   <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Login]" 
       
       UpdateCommand ="UPDATE [Login] Set [Id] =@Id ,[email] = @email , [Username]= @Username ,[PhoneNO] = @PhoneNO ,[Gender] = @Gender , [DOB] =@DOB ,[Password] =@Password , [SecurityQ] = @SecurityQ , [status] = @status , [Codeactivation] = @Codeactivation"
            DeleteCommand =" DELETE FROM [Login] where [id] = @id"></asp:SqlDataSource>
    

  
    <p>
<div class="container contact">
	<div class="row">
		<div class="col-md-3">
			<div class="contact-info">
				<img src="https://isobm2016congress.com/wp-content/uploads/2016/01/rehr_affiliates_main.png " alt="image"/>
				<h2>Customer Details</h2>
				<h4>PrivateHire Cars</h4>
			</div>
		</div>
		<div class="col-md-9">
			<div class="contact-form">
				 <p>
        
        <asp:GridView ID="GridViewUser" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" AllowSorting="True" Width="726px">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Customer ID " InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" />
                <asp:BoundField DataField="Username" HeaderText="Username" SortExpression="Username" />
                <asp:BoundField DataField="PhoneNO" HeaderText="Phone Number" SortExpression="PhoneNO" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                <asp:BoundField DataField="DOB" HeaderText="Birth Date " SortExpression="DOB" />
                <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
                <asp:BoundField DataField="SecurityQ" HeaderText="Security Question" SortExpression="SecurityQ" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
            
    </p>
			</div>
		</div>
	</div>
</div>
    
</asp:Content>
