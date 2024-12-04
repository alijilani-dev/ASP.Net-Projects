<%@ Page Language="C#" Inherits="System.Web.UI.MobileControls.MobilePage" Debug="true" %>
<%@ Register TagPrefix="Mobile" Namespace="System.Web.UI.MobileControls" Assembly="System.Web.Mobile" %>
<%@ Register TagPrefix="uc1" TagName="MobileWebUserControl1" Src="formtest.ascx" %>

<script runat="server" ID="Script1" NAME="Script1">
void Form_Activate(Object sender, EventArgs e)
{
    ((Form)sender).DataBind();
}

</script>
<mobile:Form runat="server" id="form1" OnActivate="Form_Activate">
    <mobile:Label runat="server" Text="<%# ActiveForm.UniqueID %>" ID="Label1" NAME="Label1"/>
    <mobile:Link NavigateUrl="#form2" runat="server" ID="Link1" NAME="Link1">Go to Form 2</mobile:Link>
    <mobile:Link NavigateUrl="#form3" runat="server" ID="Link2" NAME="Link2">Go to Form 3</mobile:Link>
    <mobile:Link NavigateUrl="#mc1:form4" runat="server" ID="Link3" NAME="Link3">Go to Form 4</mobile:Link>
</mobile:Form>

<mobile:Form runat="server" id="form2" OnActivate="Form_Activate">
    <mobile:Label runat="server" Text="<%# ActiveForm.UniqueID %>" ID="Label2" NAME="Label2"/>
    <mobile:Link NavigateUrl="#form1" runat="server" ID="Link4" NAME="Link4">Go to Form 1</mobile:Link>
    <mobile:Link NavigateUrl="#form3" runat="server" ID="Link5" NAME="Link5">Go to Form 3</mobile:Link>
    <mobile:Link NavigateUrl="#mc1:form4" runat="server" ID="Link6" NAME="Link6">Go to Form 4</mobile:Link>
</mobile:Form>

<mobile:Form runat="server" id="form3" OnActivate="Form_Activate">
    <mobile:Label runat="server" Text="<%# ActiveForm.UniqueID %>" ID="Label3" NAME="Label3"/>
    <mobile:Link NavigateUrl="#form1" runat="server" ID="Link7" NAME="Link7">Go to Form 1</mobile:Link>
    <mobile:Link NavigateUrl="#form2" runat="server" ID="Link8" NAME="Link8">Go to Form 2</mobile:Link>
    <mobile:Link NavigateUrl="#mc1:form4" runat="server" ID="Link9" NAME="Link9">Go to Form 4</mobile:Link>
</mobile:Form>

<uc1:MobileWebUserControl1 id="mc1" runat="server">
</uc1:MobileWebUserControl1>


