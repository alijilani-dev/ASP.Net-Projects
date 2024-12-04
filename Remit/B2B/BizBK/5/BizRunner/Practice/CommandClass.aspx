<%@ Register TagPrefix="mobile"
    Namespace="System.Web.UI.MobileControls"
    Assembly="System.Web.Mobile" %>
<%@ Page Inherits="System.Web.UI.MobileControls.MobilePage"
   Language="c#" %>
<script language="c#" id="Script1" runat="server" NAME="Script1">
public void PriceHandler(Object source, EventArgs e)
{
   String selectedStereoComponent = StereoComponents.Selection.Value;
   Price.Text = StereoComponents.Selection.Text
      + " at " + selectedStereoComponent;
   ActiveForm = PricePage;
}
</script>
<mobile:form id="Form1" runat="server" NAME="Form1">
	<mobile:Label>For pricing, select a component:</mobile:Label>
	<BR>
		<BR>
			<mobile:SelectionList id="StereoComponents" runat="server">
				<item Text="Amplifier" Value="$500.00" />
				<item Text="Compact Disc" Value="$600.00" />
				<item Text="Receiver" Value="$1000.00" />
				<item Text="Speakers" Value="$800.00" />
				<br>
			</mobile:SelectionList>
			<mobile:Command id="Command1" onclick="PriceHandler" runat="server" NAME="Command1">
   Get the price!</mobile:Command>
</mobile:form><mobile:form id="PricePage" runat="server">
<mobile:Label id="PriceMessage" runat="server"></mobile:Label>Stereo 
Component Price Request<BR>
		<mobile:Label id="Price" runat="server"></mobile:Label></mobile:form>
