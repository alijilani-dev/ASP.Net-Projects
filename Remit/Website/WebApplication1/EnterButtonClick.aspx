<%@ Page language="c#" Codebehind="EnterButtonClick.aspx.cs" AutoEventWireup="false" Inherits="WebApplication1.WebForm2" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm2</title>
		<script language="javascript">
			if (document.all)
			{     
				document.onkeydown = function ()
				{     
					var key_enter= 13; // 13 = Enter
					if (key_enter==event.keyCode)
					{
						event.returnValue = false;
						event.cancel = true;             
						document.getElementById('Button1').click();
					}
				}
			}
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<TABLE height="287" cellSpacing="0" cellPadding="0" width="90" border="0" ms_2d_layout="TRUE">
			<TR vAlign="top">
				<TD width="90" height="287">
					<form id="Form1" method="post" runat="server">
						<TABLE height="73" cellSpacing="0" cellPadding="0" width="275" border="0" ms_2d_layout="TRUE">
							<TR vAlign="top">
								<TD width="32" height="24"></TD>
								<TD width="184"></TD>
								<TD width="59"></TD>
							</TR>
							<TR vAlign="top">
								<TD height="24"></TD>
								<TD colSpan="2">
									<asp:Label id="Label1" runat="server"></asp:Label></TD>
							</TR>
							<TR vAlign="top">
								<TD height="25"></TD>
								<TD>
									<asp:TextBox id="TextBox1" runat="server"></asp:TextBox></TD>
								<TD>
									<asp:Button id="Button1" runat="server" Text="Button"></asp:Button></TD>
							</TR>
						</TABLE>
					</form>
				</TD>
			</TR>
		</TABLE>
	</body>
</HTML>
