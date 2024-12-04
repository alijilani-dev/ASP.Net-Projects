<%@ Page Title="Hobbies & Interests" Language="VB" MasterPageFile="~/Personal/personal.master" AutoEventWireup="false" CodeFile="hobbies_interests.aspx.vb" Inherits="Hobbies_InterestsPage" %>

<asp:Content ID="ContentHobbies_Interests" ContentPlaceHolderID="PlaceHolderPersonal" runat="server" ClientIDMode="AutoID" EnableViewState="False" ViewStateMode="Disabled" >
<!-- ###################################################Personal_Page_Content#################################################### -->

    <div class="box1">
      <h2>Hobbies & Interests </h2>
      <img class="imgl" src="../Images/demo/quotation.gif" alt="" />
      <p><i>"<script type="text/javascript" src="http://www.brainyquote.com/link/quotebr.js"></script><small><i>more <a href="http://www.brainyquote.com/quotes_of_the_day.html" target="_blank">Quotes</a></i></small>".</i></p>
      <p><i>"<script type="text/javascript" src="http://www.brainyquote.com/link/quotefu.js"></script><a href="http://www.brainyquote.com/quotes/topics/topic_funny.html" target="_blank"><small><i>more Funny Quotes</i></small></a>".</i></p>
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