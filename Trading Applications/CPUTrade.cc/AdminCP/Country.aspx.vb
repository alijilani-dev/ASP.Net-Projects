Namespace Admin
    Public Class Countrys
        Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

        'This call is required by the Web Form Designer.
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

        End Sub
        Protected WithEvents ImageButton3 As System.Web.UI.WebControls.ImageButton
        Protected WithEvents TDView As System.Web.UI.HtmlControls.HtmlTableCell
        Protected WithEvents TDAction As System.Web.UI.HtmlControls.HtmlTableCell
        Protected WithEvents TDHeader As System.Web.UI.HtmlControls.HtmlTableCell

        Protected WithEvents imgSave As System.Web.UI.WebControls.ImageButton
        Protected WithEvents imgCancel As System.Web.UI.WebControls.ImageButton
        Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
        Protected WithEvents ImgNew As System.Web.UI.WebControls.ImageButton
        Protected WithEvents RFVLink As System.Web.UI.WebControls.RequiredFieldValidator

        Protected WithEvents TDImage As System.Web.UI.HtmlControls.HtmlTableCell

        Protected WithEvents C_Img As System.Web.UI.HtmlControls.HtmlInputFile
        Protected WithEvents tbCountryID As System.Web.UI.WebControls.TextBox
        Protected WithEvents tbCountryCode As System.Web.UI.WebControls.TextBox
        Protected WithEvents tbCountryName As System.Web.UI.WebControls.TextBox
        Protected WithEvents ImgCountry As System.Web.UI.WebControls.Image
        Protected WithEvents RFVCountryCode As System.Web.UI.WebControls.RequiredFieldValidator
        Protected WithEvents RFVCname As System.Web.UI.WebControls.RequiredFieldValidator
        Protected WithEvents DGCountry As System.Web.UI.WebControls.DataGrid

        'NOTE: The following placeholder declaration is required by the Web Form Designer.
        'Do not delete or move it.
        Private designerPlaceholderDeclaration As System.Object

        Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
            'CODEGEN: This method call is required by the Web Form Designer
            'Do not modify it using the code editor.
            InitializeComponent()
        End Sub

#End Region

#Region "Private Constants"
        Private Const pi_strCCountry_id As String = "Country_id"
        Private Const pi_strCcountry_short_code As String = "country_short_code"
        Private Const pi_strCCountry_Name As String = "Country_Name"
        Private Const pi_strCcountry_flag_Img_url As String = "country_flag_Img_url"

#End Region

#Region "Private variables"
        Private pi_Obj_Country As Trade_BL.Country
        Private dt_Country As DataTable
#End Region

        Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'Put user code to initialize the page here
            dt_Country = New DataTable

            Response.Cache.SetCacheability(HttpCacheability.NoCache)

            If Session(Session_str_Admin) = "FALSE" Then
                Response.Redirect("InvalidUser.htm")
                Response.End()
            End If
            If Page.IsPostBack = False Then
                lblMessage.Text = "Country  Listing"
                ShowCountryDetails()
            End If

        End Sub

        Private Sub DGCountry_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGCountry.SelectedIndexChanged
            Dim annid As Integer
            Try
                lblMessage.Text = "Edit Country "
                annid = DGCountry.DataKeys.Item(DGCountry.SelectedIndex)
            Catch ex As Exception
                annid = 0
            End Try

            Try
                FillCountryDetails(annid)
            Catch ex As Exception
                'TDHeader.Visible = True
                TDView.Visible = True
                TDAction.Visible = False
                Throw ex
            End Try
        End Sub

        Private Sub imgCancel_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgCancel.Click
            ShowCountryDetails()
            lblMessage.Text = "Country  Listing"
        End Sub

        Private Sub imgSave_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles imgSave.Click
            Dim strImg As String
            pi_Obj_Country = New Trade_BL.Country

            pi_Obj_Country.country_id = Convert.ToInt32("0" & tbCountryID.Text)
            pi_Obj_Country.country_short_code = tbCountryCode.Text
            pi_Obj_Country.country_name = tbCountryName.Text
            pi_Obj_Country.country_flag_Img_url = C_Img.Value

            If pi_Obj_Country.country_id > 0 Then
                ' edit
                strImg = Server.MapPath("..\Thumb") & "\" & Strings.Right(C_Img.Value, C_Img.Value.Length - Strings.InStrRev(C_Img.Value, "\"))

                Try
                    C_Img.PostedFile.SaveAs(strImg)
                    pi_Obj_Country.country_flag_Img_url = "..\Thumb\" & Strings.Right(C_Img.Value, C_Img.Value.Length - Strings.InStrRev(C_Img.Value, "\"))
                Catch Exc As Exception
                    lblMessage.Text = "Please enter proper Image file "
                    lblMessage.Visible = True
                    Exit Sub
                End Try

                If pi_Obj_Country.Update() = True Then

                    lblMessage.Text = "Updation done successfully, click Cancel to View Country  Listing"
                    FillCountryDetails(pi_Obj_Country.country_id)
                End If
            Else
                ' add new
                strImg = Server.MapPath("..\Thumb") & "\" & Strings.Right(C_Img.Value, C_Img.Value.Length - Strings.InStrRev(C_Img.Value, "\"))

                Try
                    C_Img.PostedFile.SaveAs(strImg)
                    pi_Obj_Country.country_flag_Img_url = "..\Thumb\" & Strings.Right(C_Img.Value, C_Img.Value.Length - Strings.InStrRev(C_Img.Value, "\"))
                Catch Exc As Exception
                    lblMessage.Text = "Please enter proper Image file "
                    lblMessage.Visible = True
                    Exit Sub
                End Try
                If pi_Obj_Country.Insert() = True Then
                    lblMessage.Text = "Country  Added Successfully, Add New Country "
                    FillCountryDetails(pi_Obj_Country.country_id)
                End If
            End If

        End Sub

#Region "Functions "
        Public Sub FillCountryDetails(ByVal prmann_id As Integer)
            'TDHeader.Visible = False
            TDView.Visible = False
            TDAction.Visible = True
            If prmann_id > 0 Then
                pi_Obj_Country = New Trade_BL.Country
                dt_Country = pi_Obj_Country.GetCountries(prmann_id)

                tbCountryID.Text = Convert.ToString(dt_Country.Rows(0).Item(pi_strCCountry_id))
                tbCountryCode.Text = Convert.ToString(dt_Country.Rows(0).Item(pi_strCcountry_short_code))
                tbCountryName.Text = Convert.ToString(dt_Country.Rows(0).Item(pi_strCCountry_Name))
                ImgCountry.ImageUrl = Convert.ToString(dt_Country.Rows(0).Item(pi_strCcountry_flag_Img_url))
                TDImage.Visible = True
            Else
                pi_Obj_Country = New Trade_BL.Country
                tbCountryID.Text = "0"
                tbCountryCode.Text = ""
                tbCountryName.Text = ""

                TDImage.Visible = False
            End If
        End Sub
        Public Sub ShowCountryDetails()
            Try
                pi_Obj_Country = New Trade_BL.Country
                dt_Country = pi_Obj_Country.GetCountries(0)

                Dim dtcolumn As New DataColumn
                dtcolumn.ColumnName = "Selected"
                dtcolumn.DataType = GetType(Boolean)
                dtcolumn.DefaultValue = 0

                dt_Country.Columns.Add(dtcolumn)

                DGCountry.DataKeyField = "Country_id"
                DGCountry.DataSource = dt_Country

                If dt_Country.Rows.Count = ((DGCountry.PageCount - 1) * DGCountry.PageSize) Then
                    DGCountry.CurrentPageIndex = DGCountry.CurrentPageIndex - 1
                End If

                DGCountry.DataBind()

                'TDHeader.Visible = True
                TDView.Visible = True
                TDAction.Visible = False
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region


        Private Sub ImgNew_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImgNew.Click
            lblMessage.Text = "Add New Country  ...."
            FillCountryDetails(0)
        End Sub

        Private Sub ImgDelete_Click(ByVal sender As System.Object, ByVal e As System.Web.UI.ImageClickEventArgs)
            Dim dr As DataRow()
            Dim icounter As Integer
            Try
                pi_Obj_Country = New Trade_BL.Country

                If TDAction.Visible = True Then
                    pi_Obj_Country.Delete(tbCountryID.Text)
                    lblMessage.Text = "Add New Country  ...."
                    FillCountryDetails(0)
                Else
                    Exit Sub
                    dr = CType(DGCountry.DataSource, DataTable).Select("Selected = 1")
                    If dr.Length > 0 Then
                        For icounter = 0 To dr.Length - 1
                            'pi_Obj_Country.Delete(Convert.ToInt32(dr(icounter).Item(pi_strCann_id)))
                        Next
                        FillCountryDetails(0)
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

#Region "Delete current selected Record"
        Private Sub DGCountry_DeleteCommand(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridCommandEventArgs) Handles DGCountry.DeleteCommand
            pi_Obj_Country = New Trade_BL.Country

            If TDView.Visible = True Then
                pi_Obj_Country.Delete(DGCountry.DataKeys(e.Item.ItemIndex))
                ShowCountryDetails()
            End If

        End Sub
#End Region


#Region "Page Changed"
        Private Sub DGCountry_PageIndexChanged(ByVal source As Object, ByVal e As System.Web.UI.WebControls.DataGridPageChangedEventArgs) Handles DGCountry.PageIndexChanged
            DGCountry.CurrentPageIndex = e.NewPageIndex
            ShowCountryDetails()
        End Sub
#End Region


    End Class
End Namespace
