<%@ Page language="c#" Codebehind="ObjListTest.aspx.cs" Inherits="BizRunner.ObjListTest" AutoEventWireup="false" %>
<%@ Register TagPrefix="mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>
<script language="c#" id="Script1" runat="server"></script>
<mobile:form id="Form1" runat="server" BackColor="LightBlue">
	<mobile:ObjectList id="List1" runat="server" OnItemCommand="List1_Click" LabelStyle-StyleReference="title"
		CommandStyle-StyleReference="subcommand" DefaultCommand="Reserve" Wrapping="NoWrap" MoreText="More Information."
		DetailsCommandText="Details.." BackCommandText="Go Back To User Page.">
		<Command Name="Reserve" Text="Reserve"></Command>
		<Command Name="Buy" Text="Buy"></Command>
		<Command Name="Dynamic" Text="DynaText"></Command>
		<Field Title="Id" Name="Id" DataFormatString="ObjListTest.aspx?Mode=Delete&amp;amp;Id={0}"
			DataField="Id"></Field>
		<Field Title="Refresh" Name="Refresh" DataFormatString="<b><a href='ObjListTest.aspx'>{0}</a></b>"
			DataField="Name"></Field>
		<Field Title="title" Name="Refresh1" DataFormatString="ObjListTest.aspx?Mode=Delete&amp;amp;Id={0}"
			DataField="Name"></Field>
	</mobile:ObjectList>
</mobile:form><mobile:form id="Form2" runat="server" BackColor="LightBlue">
	<mobile:Label id="ResLabel" runat="server" text="Sale item reservation system coming soon!"></mobile:Label>
	<mobile:Link id="ResLink" runat="server" text="Return" NavigateURL="#Form1"></mobile:Link>
</mobile:form><mobile:form id="Form3" runat="server" BackColor="LightBlue">
	<mobile:Label id="BuyLabel" runat="server" text="Online purchasing system coming soon!"></mobile:Label>
	<mobile:Link id="BuyLink" runat="server" text="Return" NavigateURL="#Form1"></mobile:Link>
</mobile:form><mobile:form id="Form4" runat="server" BackColor="LightBlue">
	<mobile:Label id="DefLabel" runat="server" text="Detailed descriptions of the items will be here soon!"></mobile:Label>
	<mobile:Link id="DefLink" runat="server" text="Return" NavigateURL="#Form1"></mobile:Link>
</mobile:form>
