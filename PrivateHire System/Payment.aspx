<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="PrivateHire_System.Payment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    	
   <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<!------ Include the above in your HEAD tag ---------->
    <link rel="stylesheet" type="text/css" href="Content/StyleFAQ.css">

<div class="container contact">
	<div class="row">
		<div class="col-md-3">
			<div class="contact-info">
				<img src="http://aux.iconspalace.com/uploads/1323817821135809128.png" alt="image"/>
				<h2>Credit Card Details </h2>				
			</div>
		</div>
		<div class="col-md-9">
			<div class="contact-form">
				<div class="form-group">
				  <label class="control-label col-sm-2" for="fname">Email:</label>
				  <div class="col-sm-10">          
					<asp:Label ID="Label1" runat="server" Text=" " class="form-control"/>
				  </div>
				</div>
				<div class="form-group">
				  <label class="control-label col-sm-2" for="lname">Date :</label>
				  <div class="col-sm-10">          
					<asp:Label ID="Label2" runat="server" Text="" class="form-control"/>
				  </div>
				</div>
				<div class="form-group">
				  <label class="control-label col-sm-2" for="email">Time :</label>
				  <div class="col-sm-10">
					<asp:Label ID="Label3" runat="server" Text="" class="form-control"/>
				  </div>
				</div>
                <div class="form-group">
				  <label class="control-label col-sm-2" for="From:">From:</label>
				  <div class="col-sm-10">
					<asp:Label ID="Label4" runat="server" Text="" class="form-control"/>
				  </div>
				</div>
				<div class="form-group">
				  <label class="control-label col-sm-2" for="comment">Destination:</label>
				  <div class="col-sm-10">
					<asp:Label ID="Label5" runat="server" Text="" class="form-control"/>
				  </div>
				</div>
                <div class="form-group">
				  <label class="control-label col-sm-2" for="Price">Price:</label>
				  <div class="col-sm-10">
					<asp:Label ID="Label6" runat="server" Text="" class="form-control"/>
				  </div>
				</div>
                 <asp:Label ID="Label19" runat="server" Text="Total Price With Discount:"></asp:Label>
                 <div class="form-group">
				  <div class="col-sm-10">
					<asp:Label ID="Label7" runat="server" Text="" class="form-control"/>
				  </div>
				</div>
                </div>
                <div class="input-group form-group">
						<div class="input-group-prepend">
							<span class="input-group-text"><i class="fab fa-cc-visa"></i></span>
						</div>
						<asp:TextBox ID="TextBox1" class="form-control" runat="server" placeholder="Credit Card No" MaxLength="16" />
						
					</div>
             <div class="input-group form-group">
						<div class="input-group-prepend">
							<span class="input-group-text"><i class="fas fa-calendar-alt"></i></span>
						</div>
						<asp:TextBox ID="TextBox2" class="form-control" runat="server" placeholder="MM/YY" MaxLength="5" />
						
					</div>
             <div class="input-group form-group">
						<div class="input-group-prepend">
							<span class="input-group-text"><i class="fas fa-credit-card"></i></span>
						</div>
						<asp:TextBox ID="TextBox3" class="form-control" runat="server" placeholder="CVC" MaxLength="3" />
						
					</div>
				<div class="form-group">        
				  <div class="col-sm-offset-2 col-sm-10">
					<asp:Button ID="Button1"  class="btn btn-warning" runat ="server" OnClick="Button1_Click" Text ="Submit" Width="181px" />
				  </div>
				</div>
			</div>
		</div>
	</div>
</div>

</asp:Content>
