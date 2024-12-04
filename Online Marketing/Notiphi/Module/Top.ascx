<meta name="vs_showGrid" content="True">
<%@ Control Language="vb" AutoEventWireup="false" Codebehind="Top.ascx.vb" Inherits="Notiphi.Top" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<LINK href="../Notiphi.css" type="text/css" rel="stylesheet">
<script language="JavaScript">
<!--
function FP_swapImgRestore() {//v1.0
 var doc=document,i; if(doc.$imgSwaps) { for(i=0;i<doc.$imgSwaps.length;i++) {
  var elm=doc.$imgSwaps[i]; if(elm) { elm.src=elm.$src; elm.$src=null; } } 
  doc.$imgSwaps=null; }
}

function FP_swapImg() {//v1.0
 var doc=document,args=arguments,elm,n; doc.$imgSwaps=new Array(); for(n=2; n<args.length;
 n+=2) { elm=FP_getObjectByID(args[n]); if(elm) { doc.$imgSwaps[doc.$imgSwaps.length]=elm;
 elm.$src=elm.src; elm.src=args[n+1]; } }
}

function FP_preloadImgs() {//v1.0
 var d=document,a=arguments; if(!d.FP_imgs) d.FP_imgs=new Array();
 for(var i=0; i<a.length; i++) { d.FP_imgs[i]=new Image; d.FP_imgs[i].src=a[i]; }
}

function FP_getObjectByID(id,o) {//v1.0
 var c,el,els,f,m,n; if(!o)o=document; if(o.getElementById) el=o.getElementById(id);
 else if(o.layers) c=o.layers; else if(o.all) el=o.all[id]; if(el) return el;
 if(o.id==id || o.name==id) return o; if(o.childNodes) c=o.childNodes; if(c)
 for(n=0; n<c.length; n++) { el=FP_getObjectByID(id,c[n]); if(el) return el; }
 f=o.forms; if(f) for(n=0; n<f.length; n++) { els=f[n].elements;
 for(m=0; m<els.length; m++){ el=FP_getObjectByID(id,els[n]); if(el) return el; } }
 return null;
}
// -->
</script>
<TABLE id="table2" cellSpacing="0" cellPadding="0" border="0" background="images/bg_pg.jpg">
	<TR>
		<TD><A href="http://www.Notiphi.com/"><IMG height="101" alt="" src="../images//logo.jpg" width="272" border="0"></A></TD>
		<TD>
			<IMG height="101" alt="" src="../images/top_lnk_img.jpg" width="429" border="0"></TD>
	</TR>
	<TR>
		<TD colSpan="2">
			<TABLE id="table3" cellSpacing="0" cellPadding="0" bgColor="#ffffff" border="0">
				<TR>
					<TD background="../images//bg_main_lnk.jpg" width="272">
						<TABLE class="txt" id="tbLogin" runat="server" cellSpacing="1" cellPadding="1" width="100%"
							border="0">
							<TR>
								<TD style="WIDTH: 146px"><font color="#ffffff">Welcome&nbsp;</font><asp:Label id="lblTitle" ForeColor="#ffffff" runat="server"></asp:Label></TD>
								<TD align="center">
									<asp:HyperLink id="HyperLink1" ForeColor="#FFFFFF" runat="server" NavigateUrl="../Login.aspx?mode=logout">Logout</asp:HyperLink></TD>
							</TR>
						</TABLE>
					</TD>
					<TD><A href="../about_company.aspx"><IMG id="img1" onmouseover="FP_swapImg(1,1,/*id*/'img1',/*url*/'../images/btn_abt_ovr.jpg')"
								onmouseout="FP_swapImgRestore()" height="27" src="../images/btn_abt.jpg" width="105" border="0"></A></TD>
					<TD><A href="../features.aspx"><IMG id="img2" onmouseover="FP_swapImg(1,1,/*id*/'img2',/*url*/'../images/btn_feature_ovr.jpg')"
								onmouseout="FP_swapImgRestore()" height="27" src="../images/btn_feature.jpg" width="81" border="0"></A></TD>
					<TD><A href="../login.aspx"><IMG id="img3" onmouseover="FP_swapImg(1,1,/*id*/'img3',/*url*/'../images/btn_login_ovr.jpg')"
								onmouseout="FP_swapImgRestore()" height="27" src="../images/btn_login.jpg" width="81" border="0"></A></TD>
					<TD><A href="../demo.aspx"><IMG id="img4" onmouseover="FP_swapImg(1,1,/*id*/'img4',/*url*/'../images/btn_demo_ovr.jpg')"
								onmouseout="FP_swapImgRestore()" height="27" src="../images/btn_demo.jpg" width="81" border="0"></A></TD>
					<TD><A href="../contacts.aspx"><IMG id="img5" onmouseover="FP_swapImg(1,1,/*id*/'img5',/*url*/'../images/btn_cntct_ovr.jpg')"
								onmouseout="FP_swapImgRestore()" height="27" src="../images/btn_cntct.jpg" width="81" border="0"></A></TD>
				</TR>
			</TABLE>
		</TD>
	</TR>
</TABLE>
