<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="DriverDetails.aspx.cs" Inherits="PrivateHire_System.DriverReview" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<!------ Include the above in your HEAD tag ---------->
    <link rel="stylesheet" type="text/css" href="Content/StyleSheetCustomer.css">
    
   
    <p>
<div class="container contact">
	<div class="row">
		<div class="col-md-3">
			<div class="contact-info">
				<img src="https://cdn4.iconfinder.com/data/icons/occupation-job-icons-2/512/OCCUPATION2-21-512.png " alt="image"/>
				<h2>Driver Details</h2>
				<h4>PrivateHire Cars</h4>
			</div>
		</div>
		<div class="col-md-9">
			<div class="contact-form">
				 <p>
        
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
            <Columns>
                
                <asp:CommandField ShowDeleteButton="True" />
                
                <asp:BoundField DataField="Id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Driver_Name" HeaderText="Driver Name" SortExpression="Driver_Name" />
                <asp:BoundField DataField="Driver_Contact_Number" HeaderText="Contact Number" SortExpression="Driver_Contact_Number" />
                <asp:BoundField DataField="Driver_Email" HeaderText="Email" SortExpression="Driver_Email" />
                <asp:BoundField DataField="Driver_Gender" HeaderText="Gender" SortExpression="Driver_Gender" />
                <asp:BoundField DataField="Driver_Car_Model" HeaderText="Car Model" SortExpression="Driver_Car_Model" />
                <asp:BoundField DataField="Driver_Age" HeaderText="Age" SortExpression="Driver_Age" />
                <asp:BoundField DataField="cab_Number" HeaderText="Car Plate No" SortExpression="cab_Number" />             
                <asp:BoundField DataField="SizeOfCab" HeaderText="Size Of Cab" SortExpression="SizeOfCab" />
                
            </Columns>
        </asp:GridView>
            
                     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [DriverDetail]"
                        
            UpdateCommand ="UPDATE [DriverDetail] Set [Driver_Name] =@Driver_Name ,[Driver_Contact_Number] = @Driver_Contact_Number , [Driver_Email]= @Driver_Email ,[Driver_Gender] = @Driver_Gender ,[Driver_Car_Model] = @Driver_Car_Model , [Driver_Age] =@Driver_Age ,[Driver_Address] =@Driver_Address  "
            DeleteCommand =" DELETE FROM [DriverDetail] where [id] = @id"></asp:SqlDataSource>
            
    </p>
			</div>
		</div>
	</div>
</div>

</asp:Content>
