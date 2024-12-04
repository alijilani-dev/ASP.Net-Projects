<%@ Page language="c#" Codebehind="logins.aspx.cs" Inherits="BizRunner.logins" AutoEventWireup="false" %>
<%@ Register TagPrefix="mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>
<%@ Import Namespace="System.Web.Security" %>
<%@ Import Namespace="System.Web.Mobile" %>
<script language="c#" runat="server" ID="Script1">
void Login_Click(Object sender, EventArgs e)
{
   if(IsAuthenticated(txtUsername.Text, txtPassword.Text))
   {
      FormsAuthentication.SetAuthCookie(txtPassword.Text, false);
      MobileFormsAuthentication.RedirectFromLoginPage(txtPassword.Text,true);
   }
   else
   {
      lblError.Text = "Please check your credentials";
   }
}
bool IsAuthenticated(String user, String password)
{//Check the values against forms authentication store

   if(FormsAuthentication.Authenticate(user, password))
   {
      return true;
   }
   else
   {
      return false;
    }
}
</script>
<Mobile:Form id="formA" runat="server" Paginate="True">
	<Mobile:Label id="Label1" runat="server" NAME="Label1">Enter username</Mobile:Label>
	<Mobile:TextBox id="txtUsername" runat="Server" Text="username"></Mobile:TextBox>
	<Mobile:Label id="Label2" runat="server" NAME="Label2">Enter password</Mobile:Label>
	<Mobile:TextBox id="txtPassword" runat="Server" Text="password"></Mobile:TextBox>
	<Mobile:Command id="Command1" onclick="Login_Click" runat="Server" NAME="Command1" SoftkeyLabel="Login">Go</Mobile:Command>
	<Mobile:Label id="lblError" runat="server"></Mobile:Label>
</Mobile:Form>
