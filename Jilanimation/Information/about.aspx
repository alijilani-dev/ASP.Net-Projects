<%@ Page Title="About Us" Language="VB" MasterPageFile="~/Information/Information.Master" AutoEventWireup="false" CodeFile="about.aspx.vb" Inherits="AboutPage" %>

<asp:Content ID="ContentAboutUs" ContentPlaceHolderID="PlaceHolderInformation" runat="server" ClientIDMode="AutoID" EnableViewState="False" ViewStateMode="Disabled" >
<!-- ###################################################About_Page_Content#################################################### -->
    <div class="box1">
      <h2>About Us&nbsp; </h2>
        <img class="imgl" src="../Images/demo/quotation.gif" alt="" />
      <p>Put content here.</p>
    </div>

    <div class="box flickrbox">
      <h2>Image gallery</h2>
      <div class="wrap">
        <div class="fix"></div>
        <div class="flickr_badge_image" id="flickr_badge_image1"><a href="../slideshow.aspx?id=hotairbaloon"><img src="../Images/demo/hotairbaloon_small.jpg" alt="" /></a></div>
        <div class="flickr_badge_image" id="flickr_badge_image2"><a href="../slideshow.aspx?id=hotairbaloon"><img src="../Images/demo/diving.jpg" alt="" /></a></div>
        <div class="flickr_badge_image" id="flickr_badge_image3"><a href="../slideshow.aspx?id=hotairbaloon"><img src="../Images/demo/airplane.jpg" alt="" /></a></div>
        <div class="flickr_badge_image" id="flickr_badge_image4"><a href="../slideshow.aspx?id=hotairbaloon"><img src="../Images/demo/facebook.jpg" alt="" /></a></div>
        <div class="flickr_badge_image" id="flickr_badge_image5"><a href="../slideshow.aspx?id=hotairbaloon"><img src="../Images/demo/table_tennis.jpg" alt="" /></a></div>
        <div class="flickr_badge_image" id="flickr_badge_image6"><a href="../slideshow.aspx?id=hotairbaloon"><img src="../Images/demo/youtube.jpg" alt="" /></a></div>
        <div class="fix"></div>
      </div>
    </div>
    <br class="clear" />
<!-- ####################################################################################################### -->
</asp:Content>