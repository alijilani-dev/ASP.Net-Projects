<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Register.aspx.vb" Inherits="Notiphi.Register"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
  <HEAD>
		<title>Register</title>
		<meta http-equiv="Content-Language" content="en-us">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="Notiphi.css" type="text/css" rel="stylesheet">
  </HEAD>
	<body bottomMargin="0" leftMargin="0" background="images/bg_pg.jpg" topMargin="0" rightMargin="0"
		MS_POSITIONING="GridLayout"  onload="FP_preloadImgs(/*url*/'images/btn_abt_ovr.jpg', /*url*/'images/btn_feature_ovr.jpg', /*url*/'images/btn_login_ovr.jpg', /*url*/'images/btn_demo_ovr.jpg', /*url*/'images/btn_cntct_ovr.jpg', /*url*/'images/btn_managecontacts_ovr.jpg', /*url*/'images/btn_campaign_ovr.jpg', /*url*/'images/btn_reports_ovr.jpg', /*url*/'images/btn_myprofile_ovr.jpg')"
		>
		<form id="Form1" method="post" runat="server">
			<TABLE id="Template" cellSpacing="0" cellPadding="0" width="701" align="center" bgColor="#ffffff"
				background="images/bg_pg.jpg" border="0" runat="server">
				<TR>
					<TD style="HEIGHT: 120px"><TABLE id="table2" cellSpacing="0" cellPadding="0" width="100%" border="0" background="images/bg_pg.jpg">
							<TR>
								<TD><A href="http://www.Notiphi.com/"><IMG height="101" alt="" src="images//logo.jpg" width="272" border="0"></A></TD>
								<TD><MAP name="FPMap1"><AREA shape="RECT" coords="351,1,427,99" href="contact.aspx"><AREA shape="RECT" coords="271,2,346,99" href="demo.aspx"><AREA shape="RECT" coords="190,3,264,98" href="login.aspx"><AREA shape="RECT" coords="109,4,183,98" href="features.aspx"><AREA shape="RECT" coords="7,4,104,98" href="about_company.aspx"></MAP><IMG height="101" alt="" src="images//top_lnk_img.jpg" width="429" useMap="#FPMap1" border="0"></TD>
							</TR>
							<TR>
								<TD colSpan="2">
									<TABLE id="table3" cellSpacing="0" cellPadding="0" bgColor="#ffffff" border="0">
										<TR>
											<TD><IMG height="27" alt="" src="images//bg_main_lnk.jpg" width="272"></TD>
											<TD><A href="about_company.aspx"><IMG id="img1" onmouseover="FP_swapImg(1,1,/*id*/'img1',/*url*/'images/btn_abt_ovr.jpg')"
														onmouseout="FP_swapImgRestore()" height="27" src="images//btn_abt.jpg" width="105" border="0"></A></TD>
											<TD><A href="features.aspx"><IMG id="img2" onmouseover="FP_swapImg(1,1,/*id*/'img2',/*url*/'images/btn_feature_ovr.jpg')"
														onmouseout="FP_swapImgRestore()" height="27" src="images//btn_feature.jpg" width="81" border="0"></A></TD>
											<TD><A href="login.aspx"><IMG id="img3" onmouseover="FP_swapImg(1,1,/*id*/'img3',/*url*/'images/btn_login_ovr.jpg')"
														onmouseout="FP_swapImgRestore()" height="27" src="images//btn_login.jpg" width="81" border="0"></A></TD>
											<TD><A href="demo.aspx"><IMG id="img4" onmouseover="FP_swapImg(1,1,/*id*/'img4',/*url*/'images/btn_demo_ovr.jpg')"
														onmouseout="FP_swapImgRestore()" height="27" src="images//btn_demo.jpg" width="81" border="0"></A></TD>
											<TD><A href="contacts.aspx"><IMG id="img5" onmouseover="FP_swapImg(1,1,/*id*/'img5',/*url*/'images/btn_cntct_ovr.jpg')"
														onmouseout="FP_swapImgRestore()" height="27" src="images//btn_cntct.jpg" width="81" border="0"></A></TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
				<TR id="Middle" runat="server">
					<TD style="BORDER-RIGHT: #dedede 1px solid; BORDER-LEFT: #dedede 1px solid">
						<div align="center"><BR>
							<BR>
							
							<TABLE class="txt" id="table6" style="BORDER-RIGHT: #aaccff 1px solid; BORDER-TOP: #aaccff 1px solid; BORDER-LEFT: #aaccff 1px solid; BORDER-BOTTOM: #aaccff 1px solid" cellSpacing="3" width="500"
		border="0" runat="server">
		<TR>
			<TD class="gridhead" HEIGHT="27"><b>Register Now!</b>&nbsp;</TD>
		</TR>
		<TR>
			<TD height="5">
			<div align="center">
				<TABLE class="txt" id="tbMain" runat="server" cellSpacing="1" width="450" border="0">
								<TR>
									<TD width="593" height="5" colspan="2">&nbsp;</TD>
								</TR>
								<TR>
									<TD class="hdnnews" width="441" colspan="2">Member / Company Information
										<asp:label id="lblConfirm" runat="server" Visible="False">Label</asp:label></TD>
								</TR>
								<TR>
									<TD width="265" valign="top">Member / Company Name:<br>
										<asp:textbox id="txtMemberName" class="txtbox" Width="200px" runat="server"></asp:textbox><asp:requiredfieldvalidator id="rfvMemberName" runat="server" ControlToValidate="txtMemberName" ErrorMessage="Please provide member / company name"
											Display="Dynamic"></asp:requiredfieldvalidator></TD>
									<TD width="278" valign="top">Preferred User Name:<br>
										<asp:textbox id="txtUserName" class="txtbox" runat="server" Width="200px"></asp:textbox><asp:requiredfieldvalidator id="rfvUserName" runat="server" ControlToValidate="txtUserName" ErrorMessage="Please provide user name"
											Display="Dynamic"></asp:requiredfieldvalidator><br>
										<asp:hyperlink id="hlnkCheck" Font-Size="10px" runat="server" Visible="False">Check Availability</asp:hyperlink></TD>
								</TR>
								<TR>
									<TD width="284">Company Telephone:<br>
										<asp:textbox id="txtPhoneNo" class="txtbox" runat="server" Width="200px"></asp:textbox><asp:requiredfieldvalidator id="rfvTelephoneNo" runat="server" ControlToValidate="txtPhoneNo" ErrorMessage="Please provide company telephone"
											Display="Dynamic"></asp:requiredfieldvalidator></TD>
									<TD width="309" valign="top">Fax No:<br>
										<asp:textbox id="txtFaxNo" class="txtbox" runat="server" Width="200px"></asp:textbox></TD>
								</TR>
								<TR>
									<TD width="284">&nbsp;</TD>
									<TD width="309"></TD>
								</TR>
								<TR>
									<TD class="hdnnews" width="284">Contact Information</TD>
									<TD width="309"></TD>
								</TR>
								<TR>
									<TD width="284" valign="top">Contact Person Name:<br>
										<asp:textbox id="txtContactPerson" class="txtbox" runat="server" Width="200px"></asp:textbox><asp:requiredfieldvalidator id="rfvFirstName" runat="server" ControlToValidate="txtContactPerson" ErrorMessage="Please provide first name"
											Display="Dynamic"></asp:requiredfieldvalidator></TD>
									<TD width="309" valign="top">Contact No / Mobile No:<br>
										<asp:textbox id="txtMobileNo" class="txtbox" runat="server" Width="200px"></asp:textbox></TD>
								</TR>
								<TR>
									<TD width="284" valign="top">Email ID:<br>
										<asp:textbox id="txtEmailID" class="txtbox" runat="server" Width="200px"></asp:textbox><asp:requiredfieldvalidator id="rfvEmailId" runat="server" ControlToValidate="txtEmailID" ErrorMessage="Please provide email id"
											Display="Dynamic"></asp:requiredfieldvalidator><asp:regularexpressionvalidator id="redEmailId" runat="server" ControlToValidate="txtEmailID" ErrorMessage="Please provide a valid email id"
											Display="Dynamic" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:regularexpressionvalidator></TD>
									<TD width="309" valign="top">City:<br>
										<asp:textbox id="txtCity" class="txtbox" runat="server" Width="200px"></asp:textbox>
									</TD>
								</TR>
								<TR>
									<TD width="284" valign="top">Contact Address:<br>
										<asp:textbox id="txtAddress" class="txtbox" runat="server" Width="200px" Height="56px" TextMode="MultiLine"></asp:textbox></TD>
									<TD width="309" valign="top">Country:<br>
										<asp:dropdownlist class="txtbox" id="ddlCountry" runat="server" Width="200px" DataTextField="CountryName"
											DataValueField="CountryID"></asp:dropdownlist><asp:requiredfieldvalidator id="rfvCountry" runat="server" ControlToValidate="ddlCountry" ErrorMessage="Please provide country"
											Display="Dynamic"></asp:requiredfieldvalidator>
									</TD>
								</TR>
								<TR>
									<TD width="284">&nbsp;</TD>
									<TD width="309"></TD>
								</TR>
								<TR>
									<TD class="hdnnews" width="284">Terms and Conditions</TD>
									<TD width="309"></TD>
								</TR>
								<TR>
									<TD width="593" valign="top" colspan="2">
										<asp:textbox id="txtTerms" class="txtbox" runat="server" Width="422px" Height="100px" TextMode="MultiLine"
											ReadOnly="True">Notiphi End User Licence Agreement 
The terms and conditions in this agreement will govern your access to Notiphi Services. Notiphi grants to the User a non-exclusive right during the term of this Agreement to use the Services pursuant to the terms and conditions set out herein. At all times, the ownership rights remain with Notiphi or its third party suppliers, as the case may be. 
Notiphi Services
Notiphi provides e-mail marketing tool, storage and support to the Users. Users can create and send email campaigns using the application to distribute content provided by the User to a list of email addresses also supplied by the User. The User acknowledges that Notiphi does not create or publish any content for the User. The User further recognizes that Notiphi does not rent or sell email lists. Notiphi retains its right to cancel and delete an account if the User violates any of the policies explicitly published in 'Terms & Conditions', 'Privacy Policy', 'Prohibited Content' and 'Anti-spam' policy. Notiphi disclaims all copyright and other rights in such content and all responsibility for them.
Notiphi specifically disclaims liability for direct, consequential or incidental damages arising from such campaigns. By posting an email campaign using Notiphi, the User warrants that the content is true, and that User will indemnify Notiphi against any and all, direct, indirect or consequential claims and alleged claims that may arise from User's use of the services. 
Eligibility
Our E-mail Marketing Services are available to individuals who are eighteen (18) years of age or older as well as corporations and other organizations capable of legally binding contracts under applicable law. If you do not meet the criteria, please do not attempt to use the Services. The User acknowledges to provide true, accurate, current information about himself as requested by the sign up, registration or billing process. Notiphi may refuse to offer the Services to any person and may change the criteria for eligibility, at any time, and is subject to its sole discretion. 
Notiphi holds the right to terminate your account without refund and your rights to use the Services if there are reasonable grounds to believe that any data you provide is or becomes untrue, inaccurate, not current or is incomplete.

Description of Services
You understand and agree that the service is provided "AS-IS" and that Notiphi LLC. assumes no responsibility for the timeliness, deletion, mis-delivery or failure to store any user communications or personalization settings.

Notiphi provides its member's access to its various resources as agreed in the terms and conditions while sign-up. Unless explicitly stated otherwise, any new features that augment or enhance the current service, including the release of new Notiphi Features shall be subject to the 'Terms and Conditions'. 
You are responsible for obtaining access to Notiphi account by paying Monthly fees as specified or agreed upon and that access to the internet may involve third party (Internet Service Provider). In addition, you must provide and are responsible for all equipment necessary to access the service.
Personal and Non-commercial Use Limitation 
Unless otherwise specified, the Services are for your personal and non-commercial use. You may not modify, copy, distribute, transmit, display, perform, reproduce, publish, license, create derivative works from, transfer, or sell any information, software, products or services obtained from the Services.

Modification to the Services
Notiphi reserves the right to modify or discontinue the Services, temporarily or permanently, with or without notice to the User and is not obligated to support or update the Services. 

Change in Terms and Conditions
Notiphi may, at any time and at its sole discretion, modify the terms and conditions of this Agreement. User agrees to assume responsibility for periodically reviewing this Agreement. By continuing to use the service, following the posting date of changes by Notiphi, it will be assumed that the User agrees to be bound by the amended Agreement. 

Member Account, Password, and Security 
Notiphi requires you to open an account by providing us with current, complete and accurate information as prompted by the applicable registration form. You also will choose a username and password. You are entirely responsible for maintaining the confidentiality of your password and account. Furthermore, you are entirely responsible for any and all activities that occur during the use of services. You agree to notify Notiphi to immediately report of any unauthorized use of your account or breach of security. Notiphi will not be liable for any loss that you may incur as a result of someone else using your password or account, either with or without your knowledge. However, you could be held liable for losses incurred by Notiphi or its Partner due to misuse of your account or password. You may not use anyone else's account at any time, without the permission of the account holder.
Use and Storage
Notiphi may store User information, content, contact lists, emails, campaign activity statistics, reports and other information in its databases for the User. However, Notiphi has no responsibility or liability for the deletion or failure to store any messages, content or other information maintained or transmitted through the Services. At any time, Notiphi may decide that User information can no longer be stored by it or deem User information to be inappropriate and remove it from its databases with or without notice to the User. 

Charges for Services
Notiphi services are charged according to the monthly price plan selected and agreed upon by the User. Presently, there are four types of pricing plans(monthly), "Plan A", "Plan B", "Plan C" and "Plan D". Pricing may vary at any time based on changes to fee schedules. All prices are in US dollars. The User is responsible for reviewing the pricing from time to time and keeping himself aware of the fees charged by Notiphi.

Refund 
Cancellation of service will not constitute a refund of fees paid prior to cancellation. When signing up to use the application, end-user agrees that they are using the application "AS IS" and cannot request a refund due to any reason other than the service that has been unavailable for an extended period of time. We offer this product as a 30-day free 'test-drive' for you to determine if it suits your needs and meets your requirements. Lack of due diligence on the consumers' behalf will not be grounds for a refund. If consumer decides to subscribe without testing the applications' functionalities and uses, prior to signing up, no refund will be issued. Refunds will only be issued in the event the service is completely unavailable, or a function of the service is unavailable. We will prorate the use and issue a partial refund based upon remainder of the consumers' subscription. 
Ownership of Proprietary Information
The User acknowledges and agrees that the Notiphi logo, trade name and services are the property of Notiphi LLC. Notiphi affiliate logo's and trade names are property of the respective affiliates. User also recognizes that Notiphi owns and/or has all requisite rights in and to any software necessary to provide the Services under this Agreement. 
The User understands and acknowledges that, except as strictly necessary for personal viewing and use of the Services, the User is not granted any right or license to use, link to, reproduce, reverse engineer, modify, duplicate, distribute, display or perform any such copyrighted materials used or displayed on this Website or to permit others to do the same, and that all such uses are prohibited without the prior written consent of Notiphi.
Disclaimer of Warranties
THE SERVICES AND THE INFORMATION ARE PROVIDED BY Notiphi ON AN "AS IS" BASIS, AND Notiphi EXPRESSLY DISCLAIMS ANY AND ALL WARRANTIES, EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION WARRANTIES OF MERCHANTABILITY, AVAILABILITY, ACCURACY, OMISSIONS, COMPLETENESS, TIMELINESS OR DELAYS WITH RESPECT TO THE SERVICE, INFORMATION OR PRODUCTS. 
IN NO CIRCUMSTANCES, WILL Notiphi BE LIABLE FOR ANY DAMAGES OF ANY KIND WHATSOEVER WITH RESPECT TO THE SERVICES, INFORMATION OR PRODUCTS PROVIDED ON THE WEBSITE. IN PARTICULAR, Notiphi WILL NOT BE LIABLE FOR SPECIAL, INDIRECT, CONSEQUENTIAL OR INCIDENTAL DAMAGES, OR DAMAGES FOR LOST PROFITS, LOSS OF REVENUE, OR LOSS OF USE, ARISING OUT OF OR RELATED TO THE USE OF Notiphi'S SERVICES, ITS WEBSITE OR THE INFORMATION OR DATA CONTAINED THEREIN, WHETHER SUCH DAMAGES ARISE IN CONTRACT, NEGLIGENCE, TORT, UNDER STATUTE, IN EQUITY, AT LAW OR OTHERWISE. 
Notiphi, ITS AFFILIATES ENTIRE LIABILITY UNDER THIS AGREEMENT, IF ANY, FOR ANY CLAIM(S) FOR DAMAGES RELATING TO THE SERVICE, INDIVIDUALLY OR JOINTLY, WHETHER BASED IN CONTRACT OR TORT, WILL BE LIMITED TO THE AGGREGATE AMOUNT OF CHARGES FOR SERVICES PAID BY THE USER TO Notiphi WITH RESPECT TO ANY SERVICES DURING THE TWELVE MONTH PERIOD PRECEDING THE EVENT GIVING RISE TO ANY SUCH CLAIM(S). 

Termination
This Agreement may be terminated by Notiphi at any time; and also by the User upon prior written or email notice to Notiphi. The termination of the Agreement by either party will not affect the User obligation to pay the charges incurred for services consumed, and of Notiphi's responsibility to return the Users funds for Services not consumed in the event that the User has prepaid for Services for a period greater than one month. 

Acceptance of Terms
The services that Notiphi provides to you are subject to the Terms and Conditions. Notiphi reserves the right to update the 'Terms and Conditions' at any time without notice to you. 
</asp:textbox></TD>
								</TR>
								<TR>
									<TD width="593" height="5" colspan="2"></TD>
								</TR>
								<TR>
									<TD width="593" colspan="2"><asp:button CssClass="button" id="btnSubmit" runat="server" Text="I AGREE to Terms &amp; Condtions"></asp:button></TD>
								</TR>
								<TR>
									<TD width="284">&nbsp;</TD>
									<TD width="309">&nbsp;</TD>
								</TR>
								</TABLE></div>
						<TABLE id="tbWelcome" runat="server" cellSpacing="1" cellPadding="1" width="450" align="center"
							border="0">
              <TR>
                <TD id=tdWelcome 
        runat="server"></TD></TR>
						</TABLE>
			</TD>
		</TR>
		</TABLE>
						</div>
						<BR>
					</TD>
				</TR>
				<TR>
					<TD>
						<TABLE id="table5" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<TD><MAP name="FPMap0"><AREA shape="RECT" coords="554,5,589,22" href="http://www.Notiphi.com/"><AREA shape="RECT" coords="612,5,647,22" href="help.aspx"><AREA shape="RECT" coords="672,5,699,21" href="faq.aspx"></MAP><IMG height="27" alt="" src="images/footer.jpg" width="701" useMap="#FPMap0" border="0"></TD>
							</TR>
							<TR>
								<TD><IMG height="49" alt="" src="images/copyright.jpg" width="701"></TD>
							</TR>
						</TABLE>
					</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
