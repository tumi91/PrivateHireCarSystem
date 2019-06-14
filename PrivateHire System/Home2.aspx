<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home2.aspx.cs" Inherits="PrivateHire_System.Home2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

    <div class="jumbotron">       
        <asp:Image ID="Image1" runat="server" ImageUrl="Taxi Company.jpg" Height="400px" Width="1050px "/>
        <br />
        <br />
        <p class="lead">Transportation isn’t the only thing we’re changing through our technology. We’re building a culture within PrivateHire that emphasizes doing the right thing, period, for our riders and drivers.</p>
        
        <br />
        <br />
   
    <div class="row">
        <div class="col-md-4">
            <asp:Image ID="Image2" runat="server" ImageUrl="Like button.png" Height="100px" Width="100px "/>
            <h2>Convenience</h2>
            <p>
                Book within seconds and get instant comfirmations. Easy online payment or cash on delivery. Booking car rental will never be a headache again.
            </p>         
        </div>
        <div class="col-md-4">
            <asp:Image ID="Image3" runat="server" ImageUrl="Verified Logo.png" Height="100px" Width="100px "/>
            <h2>Quality</h2>
            <p>
               Our cars are audited for cleanliness, safety and comfort. Our drivers are well trained and reliable. Sit back and enjoy the Ola experience!
            </p>            
        </div>
        <div class="col-md-4">
            <asp:Image ID="Image4" runat="server" ImageUrl="Money.png" Height="100px" Width="100px "/>
            <h2>Control</h2>
            <p>
                We have clear and transparent pricing listed online. Never haggle with drivers again on payments and be confident and assured of what you are beig charged for.
            </p>
        </div>
    </div>
         </div>
       

     <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.6/umd/popper.min.js" integrity="sha384-wHAiFfRlMFy6i5SRaxvfOCifBUQy1xHdJ/yoi7FRNXMRBu5WHdZYu1hA6ZOblgut" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/js/bootstrap.min.js" integrity="sha384-B0UglyR+jN6CkvvICOB2joaf5I4l3gm9GU6Hc1og6Ls7i6U/mkkaduKaBhlAXv9k" crossorigin="anonymous"></script>
</asp:Content>

