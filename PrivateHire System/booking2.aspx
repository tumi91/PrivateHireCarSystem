<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="booking2.aspx.cs" Inherits="PrivateHire_System.booking2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


      <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<!------ Include the above in your HEAD tag ---------->
    <link rel="stylesheet" type="text/css" href="Content/StyleSheetCustomer.css">
    
   <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [DriverDetail]"></asp:SqlDataSource>
    <p>
<div class="container contact">
	<div class="row">
		<div class="col-md-3">
			<div class="contact-info">
				<img src="https://isobm2016congress.com/wp-content/uploads/2016/01/rehr_affiliates_main.png " alt="image"/>
				<h2>Booking Details</h2>
				<h4>PrivateHire Cars</h4>
			</div>
		</div>
		<div class="col-md-9">
			<div class="contact-form">

                <div class="form-group">
				  <label class="control-label col-sm-2" for="fname">Email:</label>
				  <div class="col-sm-10">          
					<asp:TextBox ID="TextBox1" runat="server" class="form-control" ReadOnly="True"/>
				  </div>
				</div>
				<div class="form-group">
				  <label class="control-label col-sm-2" for="lname">Date :</label>
				  <div class="col-sm-10">          
					<asp:TextBox ID="TextBox2" runat="server" class="form-control" placeholder="DD/MM/YYYY" MaxLength="10"/>
				  </div>
				</div>
				<div class="form-group">
				  <label class="control-label col-sm-2" for="email">Time :</label>
				  <div class="col-sm-10">
					 <asp:TextBox ID="TextBox3" runat="server" class="form-control" placeholder="24 Hour Format" MaxLength="4"/>
				  </div>
				</div>
				<div class="form-group">
				  <asp:Label ID="Label4" runat="server" Text="From:" Width="80px"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>Please Select</asp:ListItem>
        <asp:ListItem>Gombak</asp:ListItem>
        <asp:ListItem>Setapak</asp:ListItem>
        <asp:ListItem>Murtabak Airport</asp:ListItem>
        <asp:ListItem>Rawang Airport</asp:ListItem>
    </asp:DropDownList>
                   </div>
                    <div class="form-group">
    <asp:Label ID="Label5" runat="server" Text="Destination:" Width="80px"></asp:Label>
    <asp:DropDownList ID="DropDownList2" runat="server">
        <asp:ListItem>Please Select</asp:ListItem>
        <asp:ListItem>Gombak</asp:ListItem>
        <asp:ListItem>Setapak</asp:ListItem>
        <asp:ListItem>Murtabak Airport</asp:ListItem>
        <asp:ListItem>Rawang Airport</asp:ListItem>
    </asp:DropDownList>
				</div>
                	<div class="form-group">
				  <asp:Label ID="Label1" runat="server" Text="Number of Seat:" Width="80px"></asp:Label>
    <asp:DropDownList ID="DropDownList3" runat="server">
        <asp:ListItem>Please Select</asp:ListItem>
        <asp:ListItem>1</asp:ListItem>
        <asp:ListItem>2</asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
          <asp:ListItem>5</asp:ListItem>
          <asp:ListItem>6</asp:ListItem>
    </asp:DropDownList>
                   </div>
                    <div class="form-group">
    <asp:Label ID="Labe20" runat="server" Text="Size of Cab:" Width="80px"></asp:Label>
    <asp:DropDownList ID="DropDownList4" runat="server">
        <asp:ListItem>Please Select</asp:ListItem>
        <asp:ListItem>Five Seater</asp:ListItem>
        <asp:ListItem>Seven Seater</asp:ListItem>
       
    </asp:DropDownList>
				</div>
                 
                <div class="form-group">
				  <label class="control-label col-sm-2" for="fname">Offer Code:</label>
				  <div class="col-sm-10">          
					<asp:TextBox ID="TextBox4" runat="server" class="form-control" MaxLength="8"/>
				  </div>
				</div>
                  
                <div class="form-group">
                 <asp:Label ID="Label7" runat="server" Text="Price:" Width="80px" ></asp:Label>
                <asp:Label ID="Label10" runat="server"></asp:Label>
                    </div>
                   

                <asp:Label ID ="lab" runat ="server" Text="Total Price after Discount:"></asp:Label>
                <div class="form-group">
                
                <asp:Label ID="Label12" runat="server"></asp:Label>
                    <br />
                    <asp:Label ID="Label13" runat="server" Font-Bold="True" ForeColor="#660033" Text="Book with Offer Code will have £5 Discount."></asp:Label>
                    </div>
                  
               
					<asp:Button ID="Button1"  class="btn btn-danger custom-button-width " runat ="server" OnClick="Button1_Click" Text ="Check Price" Width="188px" />
                     
                  
				
                <div class="form-group">        
				  <div class="col-sm-offset-2 col-sm-10">
				  </div>
				</div>
				<p>
 
  <button class="btn btn-primary" type="button" data-toggle="collapse" data-target="#collapseExample" aria-expanded="false" aria-controls="collapseExample">
    Select Your Driver</button>
</p>
<div class="collapse" id="collapseExample">
 
    <p>
        
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource2" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Driver_Name" HeaderText="Driver Name" SortExpression="Driver_Name" />
                <asp:BoundField DataField="Driver_Contact_Number" HeaderText="Contact Number" SortExpression="Driver_Contact_Number" />
                <asp:BoundField DataField="Driver_Email" HeaderText="Email" SortExpression="Driver_Email" />
                <asp:BoundField DataField="Driver_Gender" HeaderText="Gender" SortExpression="Driver_Gender" />
                <asp:BoundField DataField="Driver_Car_Model" HeaderText="Car Model" SortExpression="Driver_Car_Model" />
                <asp:BoundField DataField="Driver_Age" HeaderText="Age" SortExpression="Driver_Age" />
                <asp:BoundField DataField="cab_Number" HeaderText="Car Plate" SortExpression="cab_Number" />
                <asp:BoundField DataField="SizeOfCab" HeaderText="Size of Cab" SortExpression="SizeOfCab" />
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
            
    </p>
                    
</div>
				
<asp:Button ID="Button2"  class="btn btn-warning" runat ="server" OnClick="Button2_Click" Text ="Confirm Booking" Width="181px" />
		
	    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [DriverDetail]"></asp:SqlDataSource>
	</div>
            </div>
</div>

























      </div>
      </div>
</asp:Content>
