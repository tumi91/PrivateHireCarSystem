<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="AdminAddDriver.aspx.cs" Inherits="PrivateHire_System.AdminAddDriver" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<!------ Include the above in your HEAD tag ---------->
    <link rel="stylesheet" type="text/css" href="Content/StyleSheetCustomer.css">

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
				<div class="form-group">
				  <label class="control-label col-sm-2" for="fname">Driver Name:</label>
				  <div class="col-sm-10">          
					<asp:TextBox ID="DriverName" runat="server" class="form-control" />
				  </div>
				</div>
				<div class="form-group">
				  <label class="control-label col-sm-2" for="lname">Driver Number:</label>
				  <div class="col-sm-10">          
					<asp:TextBox ID="DriverNumber" runat="server" class="form-control" MaxLength="10" />
				  </div>
				</div>
				<div class="form-group">
				  <label class="control-label col-sm-2" for="email"> Driver E-mail:</label>
				  <div class="col-sm-10">
					      <asp:TextBox ID="DriverEmail" runat="server" class="form-control" />

				  </div>
				</div>
				<div class="form-group">
				  <label class="control-label col-sm-2" for="comment"> Gender:</label>
				  <div class="col-sm-10">
					<asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Please Select</asp:ListItem>
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
             </asp:DropDownList>
				  </div>
				</div>
                <div class="form-group">
				  <label class="control-label col-sm-2" for="email">  Cars Model:</label>
				  <div class="col-sm-10">
					  <asp:TextBox ID="DriverCarModel" runat="server" class="form-control" />

				  </div>
                    <div class="form-group">
				  <label class="control-label col-sm-2" for="email"> Driver Age:</label>
				  <div class="col-sm-10">
					     <asp:TextBox ID="DriverAge" runat="server" class="form-control"/>
				  </div>                        
                        <div class="form-group">
				  <label class="control-label col-sm-2" for="email"> Car Plate No:</label>
				  <div class="col-sm-10">
					     <asp:TextBox ID="DriverCarNumber" runat="server" class="form-control" MaxLength="10" />

				  </div>
                           <div class="form-group">
				  <label class="control-label col-sm-2" for="comment"> Size Of Cab:</label>
				  <div class="col-sm-10">
					<asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>Please Select</asp:ListItem>
            <asp:ListItem>Five Seater</asp:ListItem>
            <asp:ListItem>Seven Seater</asp:ListItem>
             </asp:DropDownList>
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
    </div>
    </div>
    </div>
    </div>
</asp:Content>
