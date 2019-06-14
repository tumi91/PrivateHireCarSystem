<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="PrivateHire_System.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


   
    
    <!--Fontawesome CDN-->
	<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.3.1/css/all.css" integrity="sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU" crossorigin="anonymous">

    
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.6/umd/popper.min.js" integrity="sha384-wHAiFfRlMFy6i5SRaxvfOCifBUQy1xHdJ/yoi7FRNXMRBu5WHdZYu1hA6ZOblgut" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/js/bootstrap.min.js" integrity="sha384-B0UglyR+jN6CkvvICOB2joaf5I4l3gm9GU6Hc1og6Ls7i6U/mkkaduKaBhlAXv9k" crossorigin="anonymous"></script>
   
       <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/css/bootstrap.min.css" integrity="sha384-GJzZqFGwb1QTTN6wy59ffF1BuGJpLSa9DkKMp0DgiMDm4iYMj70gZWKYbI706tWS" crossorigin="anonymous">
      <link rel="stylesheet" type="text/css" href="Content/StyleSheet_Resgiter.css">
    <link rel="stylesheet" type="text/css" href="Content/StyleFAQ.css">
            
        
    <br />
    <br />
    
    
        
    
    
    
    
    <div class="container">
       
	<div class="d-flex justify-content-center h-100">
		<div class="card">
			<div class="card-header">
				<h3>PrivateHire Cars</h3>
                <h6> Register Now </h6>
			</div>
			<div class="card-body">
				
					
                    <div class="input-group form-group">
						<div class="input-group-prepend">
							<span class="input-group-text"><i class="fas fa-envelope"></i></span>
						</div>
						<asp:TextBox ID="TextBox2" class="form-control" runat="server" placeholder="Example@gmail.com" />
						
					</div>
                    <div class="input-group form-group">
						<div class="input-group-prepend">
							<span class="input-group-text"><i class="fas fa-user"></i></span>
						</div>
						<asp:TextBox ID="TextBox1" class="form-control" runat="server" placeholder="Username" />
						
					</div>
                    <div class="input-group form-group">
						<div class="input-group-prepend">
							<span class="input-group-text"><i class="fas fa-phone-square"></i></span>
						</div>
						<asp:TextBox ID="TextBox3" class="form-control" runat="server" placeholder="Phone Number" MaxLength="11" />
						
					</div>
                    <div class="input-group form-group">
						<div class="input-group-prepend">
							<span class="input-group-text"><i class="fas fa-user-friends"></i></span>
						</div>
						<%--<asp:TextBox ID="TextBox4" class="form-control" runat="server" placeholder="Gender" />--%>
						<asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>Please Select</asp:ListItem>
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
        
    </asp:DropDownList>
					</div>

                     <div class="input-group form-group">
						<div class="input-group-prepend">
							<span class="input-group-text"><i class="fas fa-calendar-alt"></i></span>
						</div>
						<asp:TextBox ID="TextBox5" class="form-control" runat="server" placeholder="DD/MM/YYYY" MaxLength="10" />
						
					</div>
					<div class="input-group form-group">
						<div class="input-group-prepend">
							<span class="input-group-text"><i class="fas fa-key"></i></span>
						</div>
						<asp:TextBox ID="TextBox6" class="form-control" runat="server" TextMode="Password" placeholder="Password" />
					</div>
                        <asp:Label ID="Label1" runat="server" Text="What is your First Pet?" style="color: #FFFFFF"></asp:Label>
                        
                        <div class="input-group form-group">
						<div class="input-group-prepend">
							<span class="input-group-text"><i class="fas fa-question-circle"></i></span>
						</div>
						<asp:TextBox ID="TextBox7" class="form-control" runat="server" placeholder="Answer" />
					</div>

                    <div class="form-group">
						<asp:Button ID="Button1" runat="server"  class="btn float-right login_btn" onclick="Button1_Click" Text="Submit" />
                     

                         
                              <div class="input-group form-group">
						<div class="input-group-prepend">
							<span class="input-group-text"><i class="fas fa-check-circle"></i></span>
						</div>
						<asp:TextBox ID="TextBox8" class="form-control" runat="server" placeholder="Enter Activation Code" />
						</div>

                         <div class="form-group">
						<asp:Button ID="Button2" runat="server"   class="btn float-right login_btn" onclick="Button2_Click" Text="Verify Email"/>
					</div>
                        

                         <asp:Label ID="Label33" runat="server" Text="" ForeColor="Red" style="font-weight: 700"></asp:Label>
                         
                         
                     
                       
                         
            
					<div class="form-group">
						&nbsp;</div>
				
			
			<div class="card-footer">
				<div class="d-flex justify-content-center links">
					Already have an account?<a runat="server" href="~/Login Page">Sign In</a>
				</div>
				
			</div>
		</div>
	</div>
</div>
     
    
    </div>
      
</div>
   
            
</asp:Content>
