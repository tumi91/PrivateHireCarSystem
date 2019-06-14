<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdatePassword.aspx.cs" Inherits="PrivateHire_System.UpdatePassword" %>
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
    <br />
    
    
    <div class="container">
	<div class="d-flex justify-content-center h-100">
		<div class="card">
			<div class="card-header">
				<h3>Private Hire Cars</h3>
                <h6> Update Password </h6>
			</div>
			<div class="card-body">
				
					
                    <div class="input-group form-group">
						<div class="input-group-prepend">
							<span class="input-group-text"><i class="fas fa-envelope"></i></span>
						</div>
						<asp:TextBox ID="TextBox1" class="form-control" runat="server" placeholder="Email" />
						
					
     
					<div class="input-group form-group">
						<div class="input-group-prepend">
							<span class="input-group-text"><i class="fas fa-key"></i></span>
						</div>
						<asp:TextBox ID="TextBox2" class="form-control" runat="server" TextMode="Password" placeholder=" New Password" />
					</div>

                   
				  
                        <asp:Label ID="Label1" runat="server" Text="What is your First Pet?" style="color: #FFFFFF"></asp:Label>
                        <br />
                        <br />

                       <div class="input-group form-group">
						<div class="input-group-prepend">
							<span class="input-group-text"><i class="fas fa-question-circle"></i></span>
						</div>
						<asp:TextBox ID="TextBox3" class="form-control" runat="server" placeholder="Answer" />
					</div>

                    <div class="form-group">
						

						<asp:Button ID="Button1" runat="server"   class="btn float-right login_btn" onclick="Button1_Click" Text="Log in"/>

                    </div>

					<div class="form-group">
						&nbsp;</div>
				
			</div>
				
			</div>
		</div>
	</div>
</div>

</asp:Content>
