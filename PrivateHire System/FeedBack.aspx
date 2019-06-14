<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FeedBack.aspx.cs" Inherits="PrivateHire_System.FeedBack" %>
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
				<img src="https://image.ibb.co/kUASdV/contact-image.png" alt="image"/>
				<h2>Contact Us</h2>
				<h4>We would love to hear from you !</h4>
			</div>
		</div>
		<div class="col-md-9">
			<div class="contact-form">
				<div class="form-group">
				  <label class="control-label col-sm-2" for="fname">Email:</label>
				  <div class="col-sm-10">          
					<asp:Label ID="Label1" runat="server" Text="Label " class="form-control"/>
				  </div>
				</div>
				<div class="form-group">
				  <label class="control-label col-sm-2" for="lname">Date :</label>
				  <div class="col-sm-10">          
					<asp:Label ID="Label2" runat="server" Text="Labe2" class="form-control"/>
				  </div>
				</div>
				<div class="form-group">
				  <label class="control-label col-sm-2" for="email">Time :</label>
				  <div class="col-sm-10">
					<asp:Label ID="Label3" runat="server" Text="Labe3" class="form-control"/>
				  </div>
				</div>
				<div class="form-group">
				  <label class="control-label col-sm-2" for="comment">Comment:</label>
				  <div class="col-sm-10">
					<asp:TextBox ID ="TextBox4" runat ="server" class="form-control" rows="5" TextMode="MultiLine" />
				  </div>
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
