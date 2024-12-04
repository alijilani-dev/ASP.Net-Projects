Public Class MobileArena
    Inherits TradeControl

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents DLSecrets As System.Web.UI.WebControls.DataList
    Protected WithEvents TDCatalogue As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TDReview As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents TDSecrets As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents DLCatalogue As System.Web.UI.WebControls.DataList
    Protected WithEvents TDMobileDetails As System.Web.UI.HtmlControls.HtmlTableCell
    Protected WithEvents DLCatalogueBrand As System.Web.UI.WebControls.DataList
    Protected WithEvents TDCatalogueBrand As System.Web.UI.HtmlControls.HtmlTableCell

    Protected WithEvents mMobileDetail As Trade.MobileDetail
    Protected WithEvents ImgReview As System.Web.UI.WebControls.ImageButton
    Protected WithEvents ImgCatalogue As System.Web.UI.WebControls.ImageButton
    Protected WithEvents ImgSecrets As System.Web.UI.WebControls.ImageButton
    Protected WithEvents iimgRight As System.Web.UI.WebControls.ImageButton
    Protected WithEvents DLReview As System.Web.UI.WebControls.DataList
    Protected WithEvents lblSelectedBrandName As System.Web.UI.WebControls.Label
    Protected WithEvents lblSelected As System.Web.UI.WebControls.Label
    Protected WithEvents ddlLeftMobileMenu As System.Web.UI.WebControls.DataList
    Protected WithEvents hprLink2 As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hprLink1 As System.Web.UI.WebControls.HyperLink
    Protected WithEvents hprLink3 As System.Web.UI.WebControls.HyperLink
    Protected WithEvents Hyperlink1 As System.Web.UI.WebControls.HyperLink
    Protected WithEvents Hyperlink2 As System.Web.UI.WebControls.HyperLink
    Protected WithEvents Hyperlink3 As System.Web.UI.WebControls.HyperLink
    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

#Region "Private Variables"
    Dim pi_Obj_Review As Trade_BL.Review
    Dim pi_Obj_Secrets As Trade_BL.Secret
    Dim pi_Obj_Brand As Trade_BL.Manufacturer
    Dim pi_Obj_MobileModel As Trade_BL.MobileModel
#End Region

#Region "Private Constants"
    Private pi_VS_MobileReview = "MobileReview"
    Private pi_VS_MobileCatalogue = "MobileCatalogue"
    Private pi_VS_MobileSecrets = "MobileSecrets"
    Private pi_VS_MobileSrNo = "MobileSrNo"
#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt_Mdetails As New DataTable

        'Put user code to initialize the page here
        'hi
        TDMobileDetails.Visible = False
        If Page.IsPostBack = False Then
            ''Code inserted by Basheer on Feb 2nd to have left mobile menu
            pi_Obj_Brand = New Trade_BL.Manufacturer
            dt_Mdetails = pi_Obj_Brand.GetManufacturer()
            ddlLeftMobileMenu.DataSource = dt_Mdetails
            ddlLeftMobileMenu.DataBind()

            If Not (Request("Details") Is Nothing) Then
                Response.Redirect(String.Format("Module/MobilePopup.aspx?Main_Links_ID=5&MobileSrNo={0}", Request("MobileSrNo").ToString()))
                Exit Sub
            End If

            '''End of the abv code
            'if Requerst of mobileSrNo is 
            ' non blank then directly transfer to
            ' mobile details i.e. ShowCatalogue
            If Not (Request("MobileSrNo") Is Nothing) Then
                ShowCatalogue(Request("MobileSrNo"))
                Exit Sub
            End If

            'then call the imgReview Click Code
            ViewState(pi_VS_MobileReview) = 0
            ViewState(pi_VS_MobileCatalogue) = 1
            ViewState(pi_VS_MobileSecrets) = 0
            ViewState(pi_VS_MobileSrNo) = 0

            ViewState("BrandName") = ""
            'ImgReviewClick()
            ImgCatalogue.ImageUrl = "../Images/indeximage1_Ovr.jpg"
            ShowCatalogue()
        End If
    End Sub

    Private Sub ImgReview_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgReview.Click
        ImgReviewClick()
        ImgReview.ImageUrl = "../Images/indeximage_Ovr.jpg"
        ImgCatalogue.ImageUrl = "../Images/indeximage1.jpg"
        ImgSecrets.ImageUrl = "../Images/indeximage2.jpg"
    End Sub

    Private Sub ImgCatalogue_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgCatalogue.Click
        ViewState(pi_VS_MobileReview) = 0
        ViewState(pi_VS_MobileCatalogue) = 1
        ViewState(pi_VS_MobileSecrets) = 0
        ViewState(pi_VS_MobileSrNo) = 0

        ShowCatalogue(0)
        ImgCatalogue.ImageUrl = "../Images/indeximage1_Ovr.jpg"
        ImgReview.ImageUrl = "../Images/indeximage.jpg"
        ImgSecrets.ImageUrl = "../Images/indeximage2.jpg"

    End Sub

    Private Sub ImgSecrets_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgSecrets.Click
        ViewState(pi_VS_MobileReview) = 0
        ViewState(pi_VS_MobileCatalogue) = 0
        ViewState(pi_VS_MobileSecrets) = 1
        ViewState(pi_VS_MobileSrNo) = 0

        ShowSecrets()
        ImgSecrets.ImageUrl = "../Images/indeximage2_Ovr.jpg"
        ImgReview.ImageUrl = "../Images/indeximage.jpg"
        ImgCatalogue.ImageUrl = "../Images/indeximage1.jpg"


    End Sub

    Private Sub DLReview_ItemCommand(ByVal source As System.Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs)
        'Response.Write(e.Item.FindControl("lblMobileSrNo"))
        ShowCatalogue(CType(e.Item.FindControl("lblRVMobileSrNo"), Label).Text)
    End Sub

    Private Sub DLCatalogue_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles DLCatalogue.ItemCommand
        'Response.Write(e.Item.FindControl("lblMobileSrNo"))
        ShowCatalogue(CType(e.Item.FindControl("lblCTMobileSrNo"), Label).Text)
    End Sub

    Private Sub ddlLeftMobileMenu_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles ddlLeftMobileMenu.ItemCommand
        'Response.Write(e.Item.FindControl("lblMobileSrNo"))
        ShowCatalogue(0, CType(e.Item.FindControl("lblLeftMenuBrand"), Label).Text)
        ViewState("BrandName") = CType(e.Item.FindControl("lblLeftManufName"), Label).Text
        lblSelectedBrandName.Text = ViewState("BrandName")
        lblSelected.Text = "Selected :" & lblSelectedBrandName.Text
    End Sub

    Private Sub DLSecrets_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles DLSecrets.ItemCommand
        'Response.Write(e.Item.FindControl("lblMobileSrNo"))
        ShowCatalogue(CType(e.Item.FindControl("lblSRMobileSrNo"), Label).Text)
    End Sub

    Private Sub DLCatalogueBrand_ItemCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataListCommandEventArgs) Handles DLCatalogueBrand.ItemCommand
        'Response.Write(e.Item.FindControl("lblBrand"))
        ViewState("BrandName") = CType(e.Item.FindControl("lblBrandName"), Label).Text
        lblSelectedBrandName.Text = ViewState("BrandName")
        ShowCatalogue(0, CType(e.Item.FindControl("lblBrand"), Label).Text)
    End Sub

#Region "General Functions"

    Private Sub ShowCatalogue(Optional ByVal MobileSrNo As Integer = 0, Optional ByVal BrandManfCode As Integer = 0)
        Dim dt_Mdetails As New DataTable
        DLReview.Visible = False
        TDReview.Visible = False
        DLSecrets.Visible = False
        TDSecrets.Visible = False
        lblSelected.Visible = False
        pi_Obj_MobileModel = New Trade_BL.MobileModel
        If MobileSrNo <= 0 Then

            If BrandManfCode = 0 Then ' show brand
                pi_Obj_Brand = New Trade_BL.Manufacturer
                dt_Mdetails = pi_Obj_Brand.GetManufacturer()
                DLCatalogueBrand.Visible = True
                TDCatalogueBrand.Visible = True
                TDCatalogue.Visible = False
                DLCatalogue.Visible = False
                DLCatalogueBrand.DataSource = dt_Mdetails
                DLCatalogueBrand.DataBind()
            ElseIf BrandManfCode > 0 Then ' show model
                If ViewState(pi_VS_MobileSecrets) = 1 Then
                    pi_Obj_Secrets = New Trade_BL.Secret
                    dt_Mdetails = pi_Obj_Secrets.GetSecret
                    dt_Mdetails.DefaultView.RowFilter = "ManufCode =" & BrandManfCode

                    DLSecrets.Visible = True
                    TDSecrets.Visible = True

                    DLCatalogueBrand.Visible = False
                    'DLCatalogueBrand.Visible = False
                    TDCatalogueBrand.Visible = False


                    DLSecrets.DataSource = dt_Mdetails.DefaultView
                    DLSecrets.DataBind()
                Else
                    dt_Mdetails = pi_Obj_MobileModel.GetMobileModel(0)
                    dt_Mdetails.DefaultView.RowFilter = "ManufCode =" & BrandManfCode
                    TDCatalogue.Visible = True
                    DLCatalogue.Visible = True
                    'lblSelectedBrandName.Text = ViewState("BrandName")
                    lblSelectedBrandName.Visible = False
                    lblSelected.Text = "Selected :" & lblSelectedBrandName.Text
                    lblSelected.Visible = True
                    DLCatalogueBrand.Visible = False
                    TDCatalogueBrand.Visible = False
                    DLCatalogue.DataSource = dt_Mdetails.DefaultView
                    DLCatalogue.DataBind()
                End If

            End If
        Else
            TDCatalogue.Visible = False
            DLCatalogue.Visible = False
            TDMobileDetails.Visible = True
            mMobileDetail.FillMobileDetails(MobileSrNo)
        End If
    End Sub
    Private Sub ShowSecrets()
        Dim dt_Mdetails As New DataTable

        DLReview.Visible = False
        TDReview.Visible = False
        DLCatalogue.Visible = False
        TDCatalogue.Visible = False
        DLCatalogueBrand.Visible = False
        TDCatalogueBrand.Visible = False

        DLSecrets.Visible = False
        TDSecrets.Visible = False
        pi_Obj_Secrets = New Trade_BL.Secret
        dt_Mdetails = pi_Obj_Secrets.GetSecret_Manufacturer

        'pi_Obj_Brand = New Trade_BL.Manufacturer
        'dt_Mdetails = pi_Obj_Brand.GetManufacturer()
        DLCatalogueBrand.Visible = True
        TDCatalogueBrand.Visible = True
        TDCatalogue.Visible = False
        DLCatalogue.Visible = False
        DLCatalogueBrand.DataSource = dt_Mdetails
        DLCatalogueBrand.DataBind()

    End Sub
    Private Sub ImgReviewClick()
        DLSecrets.Visible = False
        TDSecrets.Visible = False

        DLCatalogue.Visible = False
        TDCatalogue.Visible = False
        DLCatalogueBrand.Visible = False
        TDCatalogueBrand.Visible = False

        DLReview.Visible = True
        TDReview.Visible = True

        '        pi_Obj_Review = New Trade_BL.Review
        '        DLReview.DataSource = pi_Obj_Review.GetReview()
        '        DLReview.DataBind()

        '''Code modified to get the mobiles latest models
        pi_Obj_Review = New Trade_BL.Review
        DLReview.DataSource = pi_Obj_Review.GetLatestMobiles
        DLReview.DataBind()

    End Sub
#End Region

End Class
