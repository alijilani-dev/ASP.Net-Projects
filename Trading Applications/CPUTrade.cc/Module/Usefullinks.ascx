<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Usefullinks.ascx.vb" Inherits="Trade.Usefullinks" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<style type="text/css">
<!--
.style1 {color: #000080}
.style3 {
	color: #cf8e40;
	font-family: Verdana;
	font-size: 12px;
}
.style4 {
	color: #FFF9F0;
	font-size: 12px;
	font-weight: bold;
	font-family: Verdana;
}
-->
</style>
<body style="text-align: center">

<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="100%" border="0">
	<TR>
		<TD align="center"><IFRAME style="WIDTH: 470px; HEIGHT: 60px" name="IfAdv" align="middle" src="HTMLPages/Ad_UsefulLinks.htm"
				frameBorder="0" scrolling="no"></IFRAME>		</TD>
	</TR>
</TABLE>
<table border="0" width="650" id="table3" cellpadding="2">
	<tr>
		<td style="BORDER-RIGHT: #a5d1fe 1px solid; BORDER-TOP: #a5d1fe 1px solid; BORDER-LEFT: #a5d1fe 1px solid; BORDER-BOTTOM: #a5d1fe 1px solid">
		<asp:datalist id="DLUsefulLinks"  runat="server"  Width="100%" Visible="false" HorizontalAlign="center">
	<AlternatingItemStyle BackColor="#F5F5F5"></AlternatingItemStyle>
	<ItemTemplate>
		<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="100%" border="0">
			<TR>
				<TD width="18%">
					<asp:HyperLink id=HyperLink1 BorderWidth="1px" BorderColor="#FFF9F0" runat="server" NavigateUrl='<%# DataBinder.Eval(Container, "DataItem.links_url") %>' Target="_blank" ImageUrl='<%# DataBinder.Eval(Container, "DataItem.links_image_url") %>'>					</asp:HyperLink>
				<TD>
					<asp:Label id="lblDesc" CssClass="normaltext" runat="server">
					<%# DataBinder.Eval(Container, "DataItem.links_short_desc") %>					</asp:Label></TD>
			</TR>
		</TABLE>
	</ItemTemplate>
</asp:datalist></td>
	</tr>
</table>
<TABLE style="BORDER-RIGHT: #cf8e40 1px solid; BORDER-TOP: #cf8e40 1px solid; BORDER-LEFT: #cf8e40 1px solid; BORDER-BOTTOM: #cf8e40 1px solid; BACKGROUND-REPEAT: repeat-x"
				cellSpacing="0" cellPadding="0" width="468" background="../images/bg_cell.gif" border="0">
  <TR>
    <TD style="COLOR: white; BACKGROUND-REPEAT: no-repeat" width="99%" bgColor="#cf8e40"
						height="19" class="boxhdn"> &nbsp;&nbsp;<span class="style4">Browse Useful Links</span></TD>
  </TR>
  <TR>
    <TD width="168" height="3"></TD>
  </TR>
  <TR>
    <TD ><table width="100%" border="0" align="center" cellpadding="2" cellspacing="2">

      <tr>
        <td width="11"><img src="../images/bullet1.gif" width="11" height="11"></td>
        <td width="245" cssclass="linkMember"><strong>
		<a href="#3g" class="style3">Hardware Vendors</a></strong></td>
        <td width="11"><img src="../images/bullet1.gif" width="11" height="11"></td>
        <td width="218"><a href="#Charities" class="style3"><strong>Charities</strong></a></td>
      </tr>
      <tr>
        <td><img src="../images/bullet1.gif" width="11" height="11"></td>
        <td><strong><a href="#ns" class="style3">News &amp; Media </a><a href="#to"></a></strong></td>
        <td><img src="../images/bullet1.gif" width="11" height="11"></td>
        <td><strong><a href="#to" class="style3">Trade Organizations</a></strong></td>
      </tr>
      <tr>
        <td><img src="../images/bullet1.gif" width="11" height="11"></td>
        <td><strong><a href="#LS" class="style3" >Legal Services</a></strong></td>
        <td><img src="../images/bullet1.gif" width="11" height="11"></td>
        <td><strong><span class="style3"><a href="#Financial" class="style3"><strong>Financial Services </strong></a><a href="#wl"></a></span></strong></td>
      </tr>
      <tr>
        <td><img src="../images/bullet1.gif" width="11" height="11"></td>
        <td><strong><a href="#wl" class="style3">Wireless</a></strong></td>
        <td><img src="../images/bullet1.gif" width="11" height="11"></td>
        <td><strong><a href="#other" class="style3">Others</a></strong></td>
      </tr>

    </table></TD>
  </TR>
</TABLE>
<br>
<table border="0" width="700" id="table3" cellpadding="2">
  <tr>
    <td valign="top" style="BORDER-RIGHT: #cf8e40 1px solid; BORDER-TOP: #cf8e40 1px solid; BORDER-LEFT: #cf8e40 1px solid; BORDER-BOTTOM: #cf8e40 1px solid"><table width="100%" border="0" cellpadding="2" cellspacing="2" class="normaltext" >
      <tr>
        <td bgcolor="#cf8e40" colspan="2" height="25"><p align="center" class="style4"><a name="3g"></a>
		Hardware Vendors</td>
      </tr>
      <tr>
        <td width="124"><a href="http://www.intel.com" target="_blank"> <img src="images/links/intel.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td valign="middle"><div align="justify">The official 
                            Intel Site for Intel Based hardware.</div></td>
      </tr>
      <tr bgcolor="#FFF9F0">
        <td width="124"><a href="http://www.amd.com" target="_blank"> <img src="images/links/ibm-logo.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td>The official AMD Site for AMD Based 
                          hardware.</td>
      </tr>
      <tr>
        <td width="124" valign="top">
		<a href="http://www.ibm.com" target="_blank"> <img src="images/links/amd_logo.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td><div align="justify">The official 
                            IBM Site for IBM Based hardware.</div></td>
      </tr>
      <tr>
        <td valign="top">&nbsp;</td>
        <td><div align="right" class="linkMember"><a href="#top" class="style3"><strong>Top</strong></a></div></td>
      </tr>
      <tr>
        <td valign="middle" colspan="2" align="center" bgcolor="#cf8e40" height="25" class="style4"><strong><a name="Charities" id="Charities"></a>Charities</strong></td>
      </tr>
      <tr bgcolor="#FFF9F0">
        <td valign="top"><a href="http://www.redcross.org.uk" target="_blank"><img src="images/links/redcross.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td>The British Red Cross is a leading member of the largest independent   humanitarian organisation in the world &ndash; the International Red Cross and Red   Crescent Movement. Providing relief to people in crisis &ndash; both in the UK and   overseas &ndash; is at the heart of our work.</td>
      </tr>
      <tr>
        <td valign="top"><a href="http://www.charity-commission.gov.uk/" target="_blank"><img src="images/links/charity_ccommision.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td><p>The Charity Commission is established by law as the regulator and registrar   for charities in England and Wales.</p></td>
      </tr>
      <tr>
        <td valign="top">&nbsp;</td>
        <td>&nbsp;</td>
      </tr>
      <tr>
        <td valign="middle" bgcolor="#cf8e40" colspan="2" height="25" class="style4"><p align="center"><strong><a name="ns"></a>News &amp; Media</strong></td>
      </tr>
      <tr>
        <td valign="top"><a href="http://www.americasnetwork.com/" target="_blank"> <img src="images/links/americanetwork.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td><div align="justify">Like the print 
          version, America's Network Online brings you a package 
          of original, independent reporting and business analysis 
          of telecommunications technologies for today's public 
          network.</div></td>
      </tr>
      <tr bgcolor="#FFF9F0">
        <td valign="top"><a href="http://www.antennasonline.com/" target="_blank"> <img src="images/links/antennas.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td><div align="justify">Antenna Systems &amp; 
          Technology is a trade magazine for antenna 
          professionals, including commercial operators, 
          OEMs that integrate antennas and components into 
          their wireless systems and infrastructures.</div></td>
      </tr>
      <tr>
        <td valign="top"><a href="http://www.connect-world.com/" target="_blank"> <img src="images/links/connectworld.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td><div align="justify">The Connect-World 
          online series of publications, worldwide, is &quot;The 
          decision-makers' forum for ICT driven development&quot;.</div></td>
      </tr>
      <tr bgcolor="#FFF9F0">
        <td valign="top"><a href="http://www.eetimes.com/" target="_blank"> <img src="images/links/EEtimes.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td>An online news website, it provides 
          in depth analysis and breaking news.</td>
      </tr>
      <tr>
        <td valign="top"><a href="http://www.frecuenciaonline.com/" target="_blank"> <img src="images/links/frecuencia.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td>A website providing news and products 
          and promotional services.</td>
      </tr>
      <tr bgcolor="#FFF9F0">
        <td valign="top"><a href="http://www.telephonyonline.com/" target="_blank"> <img src="images/links/globaltelephoney.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td><div align="justify">Telephony is 
          a publication for all communications service providers: 
          new and incumbent, wireline and wireless. </div></td>
      </tr>
      <tr>
        <td valign="top"><a href="http://www.mformobile.com/" target="_blank"> <img src="images/links/mformobile.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td>News, analysis and events for the 
          mobile industry.</td>
      </tr>
      <tr bgcolor="#FFF9F0">
        <td valign="top"><a href="http://www.mobiletechnews.com/" target="_blank"> <img src="images/links/mobiletechnews.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td>An online news agency for mobile 
          technology news.</td>
      </tr>
      <tr>
        <td valign="top"><a href="http://www.radioresourcemag.com/" target="_blank"> <img src="images/links/radioresourcemag.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td><div align="justify">This website 
          provides business and FCC news; articles on innovative 
          applications, leading-edge technology and industry 
          trends; plus comprehensive product information. </div></td>
      </tr>
      <tr bgcolor="#FFF9F0">
        <td valign="top"><a href="http://searchmobilecomputing.techtarget.com/?Offer=L3amer" target="_blank"> <img src="images/links/searchmobile.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td><div align="justify">This website 
          is an online source of news and information for IT 
          managers regarding deployment, management and security 
          of a mobile computing workforce.</div></td>
      </tr>
      <tr>
        <td valign="top"><a href="http://www.techweb.com" target="_blank"> <img src="images/links/telecomunication.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td>This website is aimed at fulfilling 
          the information needs of service providers.</td>
      </tr>
      <tr bgcolor="#FFF9F0">
        <td valign="top"><a href="http://www.totaltele.com/" target="_blank"> <img src="images/links/totalTelecom.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td>This website provides daily news 
          for global communications.</td>
      </tr>
      <tr>
        <td valign="top"><a href="http://www.unstrung.com/" target="_blank"> <img src="images/links/UNSTRUNG.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td>This website provides in-depth daily 
          news coverage of the wireless industry, often breaking 
          stories.</td>
      </tr>
      <tr>
        <td valign="top">&nbsp;</td>
        <td><p align="right" class="linkMember"><a href="#top" class="style3"><strong>Top</strong></a></td>
      </tr>
      <tr>
        <td colspan="2" bgcolor="#cf8e40" height="25" class="style4"><p align="center"><strong><a name="to" id="to"></a></font>Trade 
          Organizations</strong></td>
      </tr>
      <tr bgcolor="#FFF9F0">
        <td width="124" valign="top"><a href="http://www.fti.org.uk/" target="_blank"> <img src="images/links/fti.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td>The Federation of Technological 
          Industries (FTI), represents traders of mobile phones 
          and computer chips.</td>
      </tr>
      <tr>
        <td width="124" valign="top"><a href="http://www.hmce.gov.uk/" target="_blank"> <img src="images/links/HMcustom.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td><div align="justify">HM Revenue 
          &amp; Customs (HMRC) is the new department responsible 
          for the business of the former Inland Revenue and 
          HM Customs and Excise.</div></td>
      </tr>
      <tr bgcolor="#FFF9F0">
        <td width="124" valign="top"><a href="http://www.ieee.org/" target="_blank"> <img src="images/links/IEE.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td>Site for international traders.</td>
      </tr>
      <tr>
        <td width="124" valign="top"><a href="http://www.wmrc.com/" target="_blank"><img src="images/links/wmrc.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td>This website helps senior executives 
          manage risk and evaluate opportunity created by change.</td>
      </tr>
      
      <tr>
        <td valign="top">&nbsp;</td>
        <td>&nbsp;</td>
      </tr>
      <tr>
        <td colspan="2" bgcolor="#cf8e40" height="25" class="style4"><p align="center"><strong><a name="LS" id="LS"></a>Legal Services</strong></td>
      </tr>
      <tr bgcolor="#FFF9F0">
        <td valign="top"><a href="http://www.hassan-khan-solicitors.com/" target="_blank"><img src="../images/links/hassankhan_solicitors.jpg" width="120" height="60" border="0"></a></td>
        <td bgcolor="#FFF9F0" ><p>Hassan Khan &amp; Co Solicitors is a dynamic and specialist practice which has rapidly   grown since its inception.</p></td>
      </tr>
      <tr>
        <td valign="top"><a href="http://www.arkassociates.net" target="_blank"><img src="../images/links/legal_ark.jpg" width="120" height="60" border="0"></a></td>
        <td>Ark Associates are a firm of Chartered Accountants and Chartered Tax Advisers   based in the City Centre of Birmingham.</td>
      </tr>
      <tr>
        <td valign="top" bgcolor="#FFF9F0"><a href="http://www.bfbssecurity.com/" target="_blank"><img src="../images/links/legal_bfbs.jpg" width="120" height="60" border="0"></a></td>
        <td bgcolor="#FFF9F0"><p align="left">BFBS is an international company with worldwide experience in   Security Consultancy, Security Management, Security Equipment Projects and   Security Training for major clients in the UK and overseas.
        </p></td>
      </tr>
      <tr>
        <td valign="top"><a href="http://www.dass-solicitors.com" target="_blank"><img src="../images/links/legal_dass.jpg" width="120" height="60" border="0"></a></td>
        <td>The focus and aims of the firm are to offer a bespoke service by highly   experienced and qualified individuals. We provide a high level of quality   specialist commercial advice from leading individuals within their field.</td>
      </tr>
      <tr>
        <td valign="top" bgcolor="#FFF9F0"><a href="http://www.henrybutcher.com" target="_blank"><img src="../images/links/legal_golndustry.jpg" width="120" height="60" border="0"></a></td>
        <td bgcolor="#FFF9F0">Henry Butcher International Ltd. is itself organised into three operational   divisions: Consulting, Disposal and Far East</td>
      </tr>
      <tr>
        <td valign="top"><a href="http://www.verifyinspections.com" target="_blank"><img src="../images/links/legal_verify.jpg" width="120" height="60" border="0"></a></td>
        <td>Given the changing nature of the industry it has become more important than ever   before to have an impartial partner, independent both from suppliers, forwarders   and other traders.</td>
      </tr>
      <tr>
        <td valign="top">&nbsp;</td>
        <td>&nbsp;</td>
      </tr>
      <tr>
        <td colspan="2" bgcolor="#cf8e40" height="25" class="style4"><p align="center"><strong><a name="Financial" id="Financial"></a>Financial Services</strong></td>
      </tr>
      <tr bgcolor="#FFF9F0">
        <td valign="top"><a href="http://www.corporatefx.co.uk/" target="_blank"><img src="../images/links/finance_fx.jpg" width="120" height="60" border="0"></a></td>
        <td bgcolor="#FFF9F0" ><p>In providing foreign currency solutions for companies and individuals, we   maintain a currency spot rate service based on value, efficiency and   dependability.</p></td>
      </tr>
      <tr>
        <td valign="top"><a href="https://www.firstcuracao.com" target="_blank"><img src="../images/links/finance_firstcuraco.jpg" width="120" height="60" border="0"></a></td>
        <td>Online Banking at a touch of a button. </td>
      </tr>
      <tr>
        <td valign="top">&nbsp;</td>
        <td><div align="right"><a href="#top" class="style3"><strong>Top</strong></a></div></td>
      </tr>
      <tr>
        <td valign="middle" colspan="2" align="center" bgcolor="#cf8e40" height="25" class="style4"><strong><a name="wl"></a>Wireless</strong></td>
      </tr>
      <tr>
        <td valign="top">&nbsp;</td>
        <td>&nbsp;</td>
      </tr>
      <tr>
        <td valign="top"><a href="http://www.ewirelessnews.com/" target="_blank"> <img src="images/links/Ewirlessnews.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td>The news website and a site for 
          getting Contracts and Tenders, a fun-place and also 
          downloads.</td>
      </tr>
      <tr bgcolor="#FFF9F0">
        <td valign="top"><a href="http://www.fiercewireless.com" target="_blank"> <img src="images/links/feircewirless.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td><div align="justify">This website 
          is the wireless industry's daily monitor - a free 
          daily email service that helps you stay on top of 
          the wireless and mobile Internet market.</div></td>
      </tr>
      <tr>
        <td valign="top"><a href="http://wireless.ittoolbox.com/" target="_blank"> <img src="images/links/ITtoolbox.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td><div align="justify">A wireless 
          knowledge base, it helps you evaluate vendors, manage 
          projects, solve problems, find jobs and stay with 
          the current news.</div></td>
      </tr>
      <tr bgcolor="#FFF9F0">
        <td valign="top"><a href="http://onewirelessplace.com/" target="_blank"> <img src="images/links/one_wireless.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td><div align="justify">A place for 
          wireless phone content : wireless games, chat, music, 
          ringtones, music, VOIP, picture message videos, free 
          text, and cell phones.</div></td>
      </tr>
      <tr>
        <td valign="top"><a href="http://www.rcrnews.com/" target="_blank"> <img src="images/links/RCR.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td>Internet wireless news agency.</td>
      </tr>
      <tr bgcolor="#FFF9F0">
        <td valign="top"><a href="http://www.wirelessdevnet.com/" target="_blank"> <img src="images/links/wirelessdevelpor.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td><div align="justify">This is an 
          on-line community for information technology professionals 
          interested in mobile computing and communications.</div></td>
      </tr>
      <tr>
        <td valign="top"><a href="http://www.wirelessreview.com/" target="_blank"> <img src="images/links/wirelessreview.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td><div align="justify">Wireless Review 
          provides an editorial perspective for an industry 
          in motion. Through profiles of top executives, marketers, 
          network technicians and technology innovators, this 
          website offers comprehensive coverage of the technology 
          and business issues shaping the wireless industry.</div></td>
      </tr>
      <tr bgcolor="#FFF9F0">
        <td valign="top"><a href="http://www.wireless-toolkit.com/" target="_blank"> <img src="images/links/wirelesstoolkit.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td><div align="justify">This is a website 
          about award-winning products and services that make 
          today's digital office manageable - providing access 
          to knowledge, information, processes and people on 
          any Procurement and Management issue.</div></td>
      </tr>
      <tr>
        <td valign="top"><a href="http://www.wirelessweek.com/" target="_blank"> <img src="images/links/wirelessweek.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td>This website offers in-depth analysis, 
          perspectives and insights on the wireless market.</td>
      </tr>
      <tr bgcolor="#FFF9F0">
        <td valign="top"><a href="http://www.wirelessnow.com/" target="_blank"> <img src="images/links/wirelessnow.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td><div align="justify">This website 
          is a provider of research, analysis and insight supporting 
          the telecommunications industry worldwide.</div></td>
      </tr>
      <tr>
        <td valign="top">&nbsp;</td>
        <td><p align="right" class="linkMember"><a href="#top" class="style3"><strong>Top</strong></a></td>
      </tr>
      <tr>
        <td colspan="2" bgcolor="#cf8e40" height="25" class="style4"><p align="center"><strong><a name="other" id="other"></a>Others</strong></td>
      </tr>
      <tr bgcolor="#FFF9F0">
        <td width="124" valign="top"><a href="http://www.numberingplans.com/" target="_blank"> <img src="images/links/inter_plan.jpg" width="120" height="60" border="0" style="border: 1px solid #FFF9F0"></a></td>
        <td>Numberingplans.com is specialised 
          in world-wide telephone numbering plans, and offers 
          a range of free services and products for a variety 
          of market segments in the global telecommunications 
          sector.</td>
      </tr>
      <tr>
        <td width="124" valign="top"><a href="http://www.business-directory-uk.co.uk" target="_blank"> <img border="0" src="images/links/link_ukbusinessdirectory.jpg" width="120" height="19" style="border: 1px solid #FFF9F0"></a></td>
        <td class="normaltext" >Online UK 
          business directory offering a business directory with 
          free listings to UK businesses and companies in exchange 
          for a link from your company website linking to the UK 
          business directory.</td>
      </tr>
      <tr>
        <td valign="top" colspan="2" align="center" class="linkMember"><div align="right"><span class="style3"><a href="#top" class="style3"><strong>Top</strong></a></div></td>
      </tr>
    </table></td>
  </tr>
</table>
<br>
