<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="BookingDetails.aspx.cs" Inherits="PrivateHire_System.BookingDetails" %>
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
				<h2>Booking Details</h2>
				<h4>PrivateHire Cars</h4>
			</div>
		</div>
		<div class="col-md-9">
			<div class="contact-form">
				 <p>
        
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="BookingID" DataSourceID="SqlDataSource1">
            <Columns>
                
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                <asp:BoundField DataField="Driver_Name" HeaderText="Driver Name" SortExpression="Driver_Name" />
                <asp:BoundField DataField="BookingID" HeaderText="Booking ID" SortExpression="BookingID" InsertVisible="False" ReadOnly="True" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                <asp:BoundField DataField="Time" HeaderText="Time" SortExpression="Time" />
                <asp:BoundField DataField="Origin" HeaderText="Origin" SortExpression="Origin" />
                <asp:BoundField DataField="Destination" HeaderText="Destination" SortExpression="Destination" />
                
                <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
                
                <asp:BoundField DataField="DiscountPrice" HeaderText="Discount Price" SortExpression="DiscountPrice" />
                <asp:BoundField DataField="NumberOfSeat" HeaderText="Number Of Seat" SortExpression="NumberOfSeat" />
                <asp:BoundField DataField="SizeOfCab" HeaderText="Size Of Cab" SortExpression="SizeOfCab" />
                <asp:CommandField ShowDeleteButton="True" />
                
            </Columns>
        </asp:GridView>
            
                     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Booking]"
                         UpdateCommand ="UPDATE [Booking] Set [Driver_Name] = @Driver_Name, [BookingID]= @BookingID ,[Email] = @Email ,[Date] = @Date , [Time] =@Time ,[Origin] =@Origin,[Destination]= @Destination, [Price]= @Price,[DiscountPrice]= @DiscountPrice, [NumberOfSeat]= @NumberOfSeat, [SizeOfCab]= @SizeOfCab"
            DeleteCommand =" DELETE FROM [Booking] where [BookingID] = @BookingID"
                         ></asp:SqlDataSource>
            
    </p>
			</div>
		</div>
	</div>
</div>
</asp:Content>
