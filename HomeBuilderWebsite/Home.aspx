﻿<%--<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Home.aspx.vb" Inherits="Home" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
      <div style="text-align:center" >
    <h1>
       WELCOME!
   </h1>

    <h3>Where would you like to start?</h3>
    
   <asp:Button ID="btnBuildHome" runat="server"  Font-Names="Corbel" Text="Build My New Home" Font-Size="Larger" BackColor="#336666" Font-Bold="True" ForeColor="White" Width="351px" />
    

     <br />
  <br />
     
    <asp:Button ID="btnLoadScenario" runat="server"  Font-Names="Corbel" Text="Compare My Saved Homes" Font-Size="Larger" BackColor="#336666" Font-Bold="True" ForeColor="White" Width="351px" />
         
      
      <br />
                <br />
          <asp:Button ID="btnEditTemplate" runat="server"  Font-Names="Corbel" Text="Start From A Template" Font-Size="Larger" BackColor="#336666" Font-Bold="True" ForeColor="White" Width="351px" />
         
            <br />
       
    
    
        <br />
    </section>

    &nbsp
          </div>

    </asp:Content>--%>

<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Home.aspx.vb" Inherits="Home" %>

<!DOCTYPE html>
<form runat="server">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <%--<meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>
    <webopt:bundlereference runat="server" path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />--%>

    <title>Home</title>
<link href="css/bootstrap.css" rel="stylesheet" type="text/css" media="all">
<!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
<script type="text/javascript" src="js/jquery-1.11.0.min.js"></script>
<!-- Custom Theme files -->
<link href="css/style.css" rel="stylesheet" type="text/css" media="all"/>
<!-- Custom Theme files -->
<meta name="viewport" content="width=device-width, initial-scale=1">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<script type="application/x-javascript"> addEventListener("load", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); }>
</script>
<meta name="keywords" content="Intrinsic Responsive web template, Bootstrap Web Templates, Flat Web Templates, AndriodCompatible web template, Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyErricsson, Motorola web design" />
<!--Google Fonts-->
<link href='http://fonts.useso.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800' rel='stylesheet' type='text/css'>
<!-- start-smoth-scrolling -->
<script type="text/javascript" src="js/move-top.js"></script>
<script type="text/javascript" src="js/easing.js"></script>
	<script type="text/javascript">
			jQuery(document).ready(function($) {
				$(".scroll").click(function(event){		
					event.preventDefault();
					$('html,body').animate({scrollTop:$(this.hash).offset().top},1000);
				});
			});
	</script>
<!-- //end-smoth-scrolling -->
<!-- animated-css -->
		<link href="css/animate.css" rel="stylesheet" type="text/css" media="all">
		<script src="js/wow.min.js"></script>
		<script>
		 new WOW().init();
		</script>
<!-- animated-css -->
</head>
<body>


        <!--start-banner-->
	<div class="banner" id="home">
		<div class="container">
	<div class="banner-top">
	 <ul>
		<li><p>Why not own</p></li>
		<li><p>A home</p></li>
		<li><p>Like this?</p></li>
	</ul>
	<div class="clearfix"> </div>
	<div class="bann-head">
		<h1>Welcome !</h1>
		<h2>Your dream home is only a few clicks away .</h2>
		<div class="banner-bwn">
			<a class="bann-bwn-arr" href="#services">QUICK START</a>
		</div>
   </div>
	</div>
  </div>
</div>
	<div class="header-home">
	<div class="fixed-header">
		<div class="container">
	   <div class="h_menu4"><!-- start h_menu4 -->
	   	<div class="header-main">
	   		<div class="logo">
	   			<%--<a href="index.html"><img src="images/logo.png" alt=""/></a>--%>
	   			</div>
	   			<div class="header-left-text">
					<a class="toggleMenu" href="#"><img src="images/menu-icon.png" alt=""/></a>
					<ul class="nav">
					    <li><a href="#home" class="scroll">HOME</a></li>
						<li><a href="#about" class="scroll">ABOUT</a></li>
						<li><a href="#services" class="scroll">START</a></li>
						<li><a href="#creative" class="scroll">COMPARE</a></li>
						<li><a href="#contactus" class="scroll">CONTACT US</a></li>
					</ul>
				</div>
				<div class="clearfix"> </div>
				<script type="text/javascript" src="js/nav.js"></script>
				<script type="text/javascript">
					jQuery(document).ready(function($) {
						$(".scroll").click(function(event){		
							event.preventDefault();
							$('html,body').animate({scrollTop:$(this.hash).offset().top},1000);
						});
					});
					</script>		
				 <!--script-->
		<script>
			$(document).ready(function(){
				$(".nav li a").click(function(){
					$(this).parent().addClass("active");
					$(this).parent().siblings().removeClass("active");
				});
			});
		</script>
			<!--script-for-sticky-nav-->
		<script>
		$(document).ready(function() {
			 var navoffeset=$(".header-home").offset().top;
			 $(window).scroll(function(){
				var scrollpos=$(window).scrollTop(); 
				if(scrollpos >=navoffeset){
					$(".header-home").addClass("fixed");
				}else{
					$(".header-home").removeClass("fixed");
				}
			 });
			 
		});
		</script>
		<!--/script-for-sticky-nav-->
		</div>
		<div class="clearfix"> </div>
        </div><!-- end h_menu4 -->
       </div>
      </div>
     </div>
<!--header end here-->
<!--art start here-->
<%--<div class="art">
		<div class="art-main">
			<div class="col-md-4 art-grid art1">
				<h3>Furnishings and electronics</h3>
				<p>the greater the appeal</p>
			</div>
			<div class="col-md-4 art-grid art2">
                <h3>Temporibus autem quibusdam</h3>
				<p>perspiciatis unde omnis</p>
			</div>
			<div class="col-md-4 art-grid art3">
				<h3>Free hour when our power</h3>
				<p>Neque porro quisquam est</p>
			</div>
		  <div class="clearfix"> </div>
		</div>
</div>--%>
<!--art end here-->
<!--about start here-->
<div class="about" id="about">
			<div class="about-top">
				<h3>About</h3>
			</div>
			<div class="about-bottom">
				<div class="col-md-6 about-bottom-left wow fadeInRight" data-wow-delay="0.5s">
					
				</div>
				<div class="col-md-6 about-bottom-right">
					<h3 style="font-size: large; color: #3366FF;">At Dreamcatcher Custom Homes, we aim to provide our customers with holistic design process for their dream home.</h3>
					<h3><asp:LinkButton ID="btnHelp" runat="server">How it works for me?</asp:LinkButton></h3>
                    <p style="color: #3366FF">Since our start in 2015, we&#39;ve provided home builders with the best collection of top designer house plans, home plans, and floor plans. Constantly updated with new plans and resources to help you achieve your dreams, this site is the most comprehensive, easy-to-use source for home plans on the Web.</p>
				  <div class="about-img">
				      <img src="images/brasilia.jpg" alt="">
			      </div>
				</div>
			  <div class="clearfix"> </div>
			</div>
	<div class="clearfix"> </div>		
</div>
<!--about end here-->
<!--work start here-->
<div class="work">
	<div class="work-top" id="services">
		<h3><asp:LinkButton ID="btnBuildHome" runat="server" ForeColor="White">Build a New Home</asp:LinkButton></h3>
	</div>
	<div class="work-bottom">
	<div class="col-md-6 work-left">
		<h3>For a house to be successful</h3>
		<%--<p>the objects in it must communicate with one another, respond and balance one another.</p>--%>
		<ul>
			<li><a>Build your home with things you actually want</a></li>
			<li><a>Care about How Your space looks</a></li>
			<li><a>Trends can be overrated</a></li>
			<%--<li><a href="#">Your home and Office as comfortable and attractive</a></li>--%>
			<%--<li><a href="#">Color palette for accent Walls</a></li>--%>
		</ul>
	</div>
	<div class="col-md-6 work-right">
		
	</div>
  </div>
   <div class="clearfix"> </div>
</div>
<!--work end here-->
<!--creative start here-->
<div class="creative" id="creative">
	<div class="creative-top wow bounceIn" data-wow-delay="0.4s">
		<h3><asp:LinkButton ID="LinkButton2" runat="server" ForeColor="White">COMPARE</asp:LinkButton></h3>
		<p>SAVED HOMES<asp:DropDownList ID="DropDownList1" runat="server" BackColor="White" ForeColor="Black"></asp:DropDownList></p>
	</div>
	<div class="creative-bottom">
		<div class="col-md-6 creative-left wow fadeInRight" data-wow-delay="0.5s">
			
		</div>
		<div class="col-md-6 creative-right">
			<%--<p>Simplicity is the ultimate sophistication.</p>--%>
		</div>
	  <div class="clearfix"> </div>
	</div>
</div>
<!--creative end here-->
<!--punch start here-->
<div class="punches">
	<%--<div class="punches-top">
		<img src="images/bar.jpg" alt=""/>
	</div>--%>
	<div class="punches-bottom">
		<div class="col-md-6 punches-left">
			<h3><asp:LinkButton ID="btnLoadScenario" runat="server" BorderColor="White" Font-Bold="False" Font-Size="X-Large" ForeColor="White" BorderStyle="Solid">Load Template</asp:LinkButton><asp:DropDownList ID="DropDownList2" runat="server" Font-Size="X-Large"></asp:DropDownList></h3>
			<%--<p>This goes for paint and objects — at The High Grove, we allow resid-nts to choose from a color palette for accent walls. If you don’t have that luxury in your space, choose to decorate with objects that add  some life to the room.</p>--%>
		</div>
		<div class="col-md-6 punches-right wow fadeInRight" data-wow-delay="0.5s">
			
		</div>
	  <div class="clearfix"> </div>
	</div>
</div>
<!--punch end here-->
<!--Rule start here-->
<%--<div class="rule" id="work">
	<div class="rule-top">
	<h3>SIMPLICITY MUST RULE</h3>
	</div>
	<div class="rule-bottom">
		<div class="col-md-6 rule-bott-left">
		    <h3> </h3>
		</div>
		<div class="col-md-6 rule-bott-right">
			<p>This goes for paint and objects — at The High Grove, we allow resid-nts to choose from a color palette for accent walls. If you don’t have that luxury in your space, choose to decorate with objects that add some life to the room.</p>
		</div>
	  <div class="clearfix"> </div>
	</div>
</div>--%>
<!--Rule end here-->
<!--john deo start here-->
<%--<div class="john">
	<div class="john-top wow bounceIn" data-wow-delay="0.4s">
		<span class="open-quolan"> </span>
		<p>This goes for paint and objects  at The High Grove, we allow re-sidents to choose from a color palette for accent walls.</p>    
	    <span class="close-quolan"> </span>
		 <h3>lorem</h3>                          
	</div>
</div>--%>
<!--john deo end here-->
<!--laying out start here-->
<div class="laying">
	<div class="laying-bottom">
		<div class="col-md-6 laying-left wow fadeInLeft" data-wow-delay="0.5s">
			<h4><a>For Comparing</a></h4>
			<h3>Once you have a home that you like, you can save it for later. Do this for as many homes as you want, and then click the Compare Saved Homes button to see all of your potential homes.</h3>
			<p>On the Comparisons page, select the homes you’d like to compare. For each home, you will see information about it.</p>
		</div>
		<div class="col-md-6 laying-right wow fadeInRight" data-wow-delay="0.5s">
			<h3>For Template</h3>
			<p>choosing one of the pre-built templates as your starting point. Measuring and laying out the room in advance can save you a lot of headaches.</p>
		</div>
	  <div class="clearfix"> </div>
	</div>
</div>
<!--laying out end here-->
<!--contact start here-->
<div class="contact" id="contactus">
	<div class="contact-top wow bounceIn" data-wow-delay="0.4s">
		<p>Team Members：<br/>Matt, Diana, Nick , Katie, Ben, Michael, Jiang</p>
	   <div class="address">
	   	   <div class="address-left">
	   	   	<h3>Murphree Hall</h3>
	   	   </div>
	   	   <div class="con-poiner">
	   	   	
	   	   </div>
	   	   <div class="clearfix"> </div>
	   </div>
	   <div class="address">
	   	   <div class="address-left">
	   	   	<h3>1-800-GO-GATAS<br/>(1-800-464-2827)</h3>
	   	   </div>
	   	   <div class="iphone">
	   	   	
	   	   </div>
	   	   <div class="clearfix"> </div>
	   </div>
	   <div class="address">
	   	   <div class="address-left">
	   	   	<h3><a>info@dch.com</a></h3>
	   	   </div>
	   	   <div class="mail">
	   	   	
	   	   </div>
	   	   <div class="clearfix"> </div>
	   </div>
	   <div class="address">
	   	   <div class="address-left">
	   	   	     <h3><a href="https://github.com/WDSSprojectTeam">WDSSprojectTeam</a></h3>
	   	   </div>
	   	   <div class="moniter">
	   	   	
	   	   </div>
	   	   <div class="clearfix"> </div>
	   </div>
	   <div class="clearfix"> </div>
	</div>
	<div class="contact-bottom">
		<div class="col-md-6 contact-left">
			
		</div>
		<div class="col-md-6 contact-right">
            <iframe src="https://www.google.com/maps/embed/v1/place?q=place_id:ChIJU6ApXXij6IgRSMoUzsYuhWk&key=AIzaSyCHpnYDNSGGI40aLiw8zIdtqkJktzDHIa0" frameborder="0" style="border:0"> </iframe>
            <!--<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d387144.007583421!2d-73.97800349999999!3d40.7056308!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x89c24fa5d33f083b%3A0xc80b8f06e177fe62!2sNew+York%2C+NY%2C+USA!5e0!3m2!1sen!2sin!4v1415253431785"  frameborder="0" style="border:0"> </iframe>-->
		</div>
		 <div class="clearfix"> </div>
	</div>
</div>
<!--contact end here-->
 <!--footer start here-->
<div class="footer">
	<div class="container">
		<div class="footer-main wow bounceIn" data-wow-delay="0.4s">
			<h3><a>Thanks for Your Visit</a></h3>
			<%--<p>Copyright &copy; 2015.Company name All rights reserved.<a target="_blank" href="http://sc.chinaz.com/moban/">&#x7F51;&#x9875;&#x6A21;&#x677F;</a></p>--%>
		</div>
	</div>
</div>
<!--footer end here-->
        
      
</body>
</html>
</form>
