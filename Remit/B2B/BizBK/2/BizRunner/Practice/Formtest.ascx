<%@ Control Language="c#" Inherits="System.Web.UI.MobileControls.MobileUserControl" %>
<script runat="server">
    void Form_Activate(Object sender, EventArgs e)
    {
        ((Form)sender).DataBind();
    }
</script>
<mobile:Form runat="server" id="form4" OnActivate="Form_Activate">
    <mobile:Label runat="server" Text="<%# ((MobilePage)Page).ActiveForm.UniqueID %>" ID="Label1" NAME="Label1"/>
    <mobile:Link NavigateUrl="#form1" runat="server" ID="Link1" NAME="Link1">
        Go to Form 1</mobile:Link>
    <mobile:Link NavigateUrl="#form2" runat="server" ID="Link2" NAME="Link2">
        Go to Form 2</mobile:Link>
    <mobile:Link NavigateUrl="#form3" runat="server" ID="Link3" NAME="Link3">
        Go to Form 3</mobile:Link>
    <mobile:Link NavigateUrl="#form4a" runat="server" ID="Link4" NAME="Link4">
        Go to Form 4a</mobile:Link>
</mobile:Form>

<mobile:Form runat="server" id="form4a" OnActivate="Form_Activate">
    <mobile:Label runat="server" Text="<%# ((MobilePage)Page).ActiveForm.UniqueID %>" ID="Label2" NAME="Label2"/>
    <mobile:Link NavigateUrl="#form1" runat="server" ID="Link5" NAME="Link5">
        Go to Form 1</mobile:Link>
    <mobile:Link NavigateUrl="#form2" runat="server" ID="Link6" NAME="Link6">
        Go to Form 2</mobile:Link>
    <mobile:Link NavigateUrl="#form3" runat="server" ID="Link7" NAME="Link7">
        Go to Form 3</mobile:Link>
    <mobile:Link NavigateUrl="#form4" runat="server" ID="Link8" NAME="Link8">
        Go to Form 4</mobile:Link>
</mobile:Form>
