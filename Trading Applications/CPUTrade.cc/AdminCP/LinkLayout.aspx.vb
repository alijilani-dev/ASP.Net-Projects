Public Class LinkLayout
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents ListBox12 As System.Web.UI.WebControls.ListBox
    Protected WithEvents ListBox11 As System.Web.UI.WebControls.ListBox
    Protected WithEvents ListBox10 As System.Web.UI.WebControls.ListBox
    Protected WithEvents ListBox9 As System.Web.UI.WebControls.ListBox
    Protected WithEvents ListBox8 As System.Web.UI.WebControls.ListBox
    Protected WithEvents ListBox7 As System.Web.UI.WebControls.ListBox
    Protected WithEvents ListBox6 As System.Web.UI.WebControls.ListBox
    Protected WithEvents ListBox5 As System.Web.UI.WebControls.ListBox
    Protected WithEvents ListBox4 As System.Web.UI.WebControls.ListBox
    Protected WithEvents ListBox3 As System.Web.UI.WebControls.ListBox
    Protected WithEvents ListBox2 As System.Web.UI.WebControls.ListBox
    Protected WithEvents ListBox1 As System.Web.UI.WebControls.ListBox
    Protected WithEvents ModuleList As System.Web.UI.WebControls.ListBox
    Protected WithEvents lblname As System.Web.UI.WebControls.Label
    Protected WithEvents lblID As System.Web.UI.WebControls.Label

#Region "user control definations"
    Protected WithEvents PH_Level1 As PlaceHolder
    Protected WithEvents PH_Level2 As PlaceHolder
    Protected WithEvents PH_Level3 As PlaceHolder
    Protected WithEvents PH_Level4 As PlaceHolder
    Protected WithEvents PH_Level5 As PlaceHolder
    Protected WithEvents PH_Level6 As PlaceHolder
    Protected WithEvents PH_Level7 As PlaceHolder
    Protected WithEvents PH_Level8 As PlaceHolder
    Protected WithEvents PH_Level9 As PlaceHolder
    Protected WithEvents PH_Level10 As PlaceHolder
    Protected WithEvents PH_Level11 As PlaceHolder
    Protected WithEvents PH_Level12 As PlaceHolder
    Protected WithEvents btnSave As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
    Protected WithEvents lblMessage As System.Web.UI.WebControls.Label
#End Region
    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region

#Region "Main module link constants"
    Private Const pi_str_Module_Links_ID As String = "Module_Links_ID"
    Private Const pi_str_module_id As String = "module_id"
    Private Const pi_str_main_links_id As String = "main_links_id"
    Private Const pi_str_sub_links_id As String = "sub_links_id"
    Private Const pi_str_Module_Position As String = "Module_Position"
    Private Const pi_str_Show_flag As String = "Show_flag"
#End Region

#Region "private variables"
    Private pi_int_main_Link_ID As Integer



    Private pi_obj_Mainlinks As Trade_BL.MainLinks

    Private pi_obj_modules As Trade_BL.Modules

    Private pi_dt_MainlinkModules As New DataTable


#End Region

#Region "Public Propetory"
    Public Property main_Link_ID() As Integer
        Get
            Return pi_int_main_Link_ID
        End Get
        Set(ByVal Value As Integer)
            pi_int_main_Link_ID = Value
        End Set
    End Property

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here

        Dim dt_Modules As New DataTable
        Dim dt_Mainlinks As New DataTable

        Response.Cache.SetCacheability(HttpCacheability.NoCache)
        If Session(Session_str_Admin) = "FALSE" Then
            Response.Redirect("InvalidUser.htm")
            Response.End()
        End If
        main_Link_ID = Request.Item("main_Link_ID")

        PH_Level1.PlaceHolder_Position = Trade_BL.Placeholder.Site_Links
        PH_Level2.PlaceHolder_Position = Trade_BL.Placeholder.Logo
        PH_Level3.PlaceHolder_Position = Trade_BL.Placeholder.Top_AD_Banner
        PH_Level4.PlaceHolder_Position = Trade_BL.Placeholder.World_Time
        PH_Level5.PlaceHolder_Position = Trade_BL.Placeholder.Main_Links
        'PH_Level6.PlaceHolder_Position = Trade_BL.Placeholder.Main_Links
        PH_Level7.PlaceHolder_Position = Trade_BL.Placeholder.Content_Ad_Banner
        PH_Level8.PlaceHolder_Position = Trade_BL.Placeholder.Content_Top_Header
        PH_Level9.PlaceHolder_Position = Trade_BL.Placeholder.Content_Left_Pane
        PH_Level10.PlaceHolder_Position = Trade_BL.Placeholder.Content_Main_Pane
        PH_Level11.PlaceHolder_Position = Trade_BL.Placeholder.Content_Right_Pane
        PH_Level12.PlaceHolder_Position = Trade_BL.Placeholder.Footer

        pi_obj_Mainlinks = New Trade_BL.MainLinks
        pi_obj_modules = New Trade_BL.Modules
        If Page.IsPostBack = False Then

            dt_Mainlinks = pi_obj_Mainlinks.GetMainLinks(main_Link_ID)
            If dt_Mainlinks.Rows.Count > 0 Then
                lblID.Text = main_Link_ID
                lblID.Enabled = False
                lblname.Text = dt_Mainlinks.Rows(0).Item("Link_Name")
            End If

            pi_obj_modules = New Trade_BL.Modules
            dt_Modules = pi_obj_modules.GetModule()

            ModuleList.DataTextField = "Module_Name"
            ModuleList.DataValueField = "Module_Id"
            ModuleList.DataSource = dt_Modules

            ModuleList.DataBind()

            pi_dt_MainlinkModules = New DataTable
            pi_dt_MainlinkModules = pi_obj_modules.GetMainLinksModules(main_Link_ID)
            'If pi_dt_MainlinkModules.Rows.Count > 0 Then  'editing
            ' editing
            Fill_Level1()
            Fill_Level2()
            Fill_Level3()
            Fill_Level4()
            Fill_Level5()
            'Fill_Level6()
            Fill_Level7()
            Fill_Level8()
            Fill_Level9()
            Fill_Level10()
            Fill_Level11()
            Fill_Level12()

            'Else
            '    ' adding new layout
            'End If
        End If
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Response.Redirect("MainLinks.aspx")
    End Sub

#Region "Fill Place Holder while Editing"
    Public Sub Fill_Level1()
        Dim dr As DataRow()
        Dim row As DataRow
        PH_Level1.PlaceHolder_Position = Trade_BL.Placeholder.Site_Links
        dr = pi_dt_MainlinkModules.Select("Module_Position='" & Trade_BL.Placeholder.Site_Links & "'")

        If dr.Length > 0 Then
            For Each row In dr
                PH_Level1.AddIntoList(CType(row.Item("Module_Name"), String), CType(row.Item("Module_ID"), Integer))
            Next
        End If
    End Sub
    Public Sub Fill_Level2()
        Dim dr As DataRow()
        Dim row As DataRow
        PH_Level2.PlaceHolder_Position = Trade_BL.Placeholder.Logo
        dr = pi_dt_MainlinkModules.Select("Module_Position='" & Trade_BL.Placeholder.Logo & "'")

        If dr.Length > 0 Then
            For Each row In dr
                PH_Level2.AddIntoList(CType(row.Item("Module_Name"), String), CType(row.Item("Module_ID"), Integer))
            Next
        End If
    End Sub
    Public Sub Fill_Level3()
        Dim dr As DataRow()
        Dim row As DataRow

        PH_Level3.PlaceHolder_Position = Trade_BL.Placeholder.Top_AD_Banner
        dr = pi_dt_MainlinkModules.Select("Module_Position='" & Trade_BL.Placeholder.Top_AD_Banner & "'")

        If dr.Length > 0 Then
            For Each row In dr
                PH_Level3.AddIntoList(CType(row.Item("Module_Name"), String), CType(row.Item("Module_ID"), Integer))
            Next
        End If
    End Sub
    Public Sub Fill_Level4()
        Dim dr As DataRow()
        Dim row As DataRow

        PH_Level4.PlaceHolder_Position = Trade_BL.Placeholder.World_Time
        dr = pi_dt_MainlinkModules.Select("Module_Position='" & Trade_BL.Placeholder.World_Time & "'")

        If dr.Length > 0 Then
            For Each row In dr
                PH_Level4.AddIntoList(CType(row.Item("Module_Name"), String), CType(row.Item("Module_ID"), Integer))
            Next
        End If
    End Sub
    Public Sub Fill_Level5()
        Dim dr As DataRow()
        Dim row As DataRow

        PH_Level5.PlaceHolder_Position = Trade_BL.Placeholder.Main_Links

        dr = pi_dt_MainlinkModules.Select("Module_Position='" & Trade_BL.Placeholder.Main_Links & "'")

        If dr.Length > 0 Then
            For Each row In dr
                PH_Level5.AddIntoList(CType(row.Item("Module_Name"), String), CType(row.Item("Module_ID"), Integer))
            Next
        End If
    End Sub
    'Public Sub Fill_Level6()
    '    Dim dr As DataRow()
    '    Dim row As DataRow

    '    PH_Level6.PlaceHolder_Position = Trade_BL.Placeholder.Main_Links

    '    dr = pi_dt_MainlinkModules.Select("Module_Position='" & Trade_BL.Placeholder.Main_Links & "'")

    '    If dr.Length > 0 Then
    '        For Each row In dr
    '            PH_Level6.AddIntoList(CType(row.Item("Module_Name"), String), CType(row.Item("Module_ID"), Integer))
    '        Next
    '    End If
    'End Sub
    Public Sub Fill_Level7()
        Dim dr As DataRow()
        Dim row As DataRow

        PH_Level7.PlaceHolder_Position = Trade_BL.Placeholder.Content_Ad_Banner

        dr = pi_dt_MainlinkModules.Select("Module_Position='" & Trade_BL.Placeholder.Content_Ad_Banner & "'")

        If dr.Length > 0 Then
            For Each row In dr
                PH_Level7.AddIntoList(CType(row.Item("Module_Name"), String), CType(row.Item("Module_ID"), Integer))
            Next
        End If
    End Sub
    Public Sub Fill_Level8()
        Dim dr As DataRow()
        Dim row As DataRow

        PH_Level8.PlaceHolder_Position = Trade_BL.Placeholder.Content_Top_Header

        dr = pi_dt_MainlinkModules.Select("Module_Position='" & Trade_BL.Placeholder.Content_Top_Header & "'")

        If dr.Length > 0 Then
            For Each row In dr
                PH_Level8.AddIntoList(CType(row.Item("Module_Name"), String), CType(row.Item("Module_ID"), Integer))
            Next
        End If
    End Sub
    Public Sub Fill_Level9()
        Dim dr As DataRow()
        Dim row As DataRow

        PH_Level9.PlaceHolder_Position = Trade_BL.Placeholder.Content_Left_Pane
        dr = pi_dt_MainlinkModules.Select("Module_Position='" & Trade_BL.Placeholder.Content_Left_Pane & "'")

        If dr.Length > 0 Then
            For Each row In dr
                PH_Level9.AddIntoList(CType(row.Item("Module_Name"), String), CType(row.Item("Module_ID"), Integer))
            Next
        End If
    End Sub
    Public Sub Fill_Level10()
        Dim dr As DataRow()
        Dim row As DataRow

        PH_Level10.PlaceHolder_Position = Trade_BL.Placeholder.Content_Main_Pane

        dr = pi_dt_MainlinkModules.Select("Module_Position='" & Trade_BL.Placeholder.Content_Main_Pane & "'")

        If dr.Length > 0 Then
            For Each row In dr
                PH_Level10.AddIntoList(CType(row.Item("Module_Name"), String), CType(row.Item("Module_ID"), Integer))
            Next
        End If
    End Sub
    Public Sub Fill_Level11()
        Dim dr As DataRow()
        Dim row As DataRow

        PH_Level11.PlaceHolder_Position = Trade_BL.Placeholder.Content_Right_Pane

        dr = pi_dt_MainlinkModules.Select("Module_Position='" & Trade_BL.Placeholder.Content_Right_Pane & "'")

        If dr.Length > 0 Then
            For Each row In dr
                PH_Level11.AddIntoList(CType(row.Item("Module_Name"), String), CType(row.Item("Module_ID"), Integer))
            Next
        End If
    End Sub
    Public Sub Fill_Level12()
        Dim dr As DataRow()
        Dim row As DataRow

        PH_Level12.PlaceHolder_Position = Trade_BL.Placeholder.Footer

        dr = pi_dt_MainlinkModules.Select("Module_Position='" & Trade_BL.Placeholder.Footer & "'")

        If dr.Length > 0 Then
            For Each row In dr
                PH_Level12.AddIntoList(CType(row.Item("Module_Name"), String), CType(row.Item("Module_ID"), Integer))
            Next
        End If
    End Sub

#End Region

#Region "Place holder events"
    Public Sub PH_Level1_AddNew() Handles PH_Level1.AddNew
        PH_Level1.AddIntoList(ModuleList.SelectedItem.Text, ModuleList.SelectedItem.Value)
    End Sub
    Public Sub PH_Level2_AddNew() Handles PH_Level2.AddNew
        PH_Level2.AddIntoList(ModuleList.SelectedItem.Text, ModuleList.SelectedItem.Value)
    End Sub
    Public Sub PH_Level3_AddNew() Handles PH_Level3.AddNew
        PH_Level3.AddIntoList(ModuleList.SelectedItem.Text, ModuleList.SelectedItem.Value)
    End Sub
    Public Sub PH_Level4_AddNew() Handles PH_Level4.AddNew
        PH_Level4.AddIntoList(ModuleList.SelectedItem.Text, ModuleList.SelectedItem.Value)
    End Sub
    Public Sub PH_Level5_AddNew() Handles PH_Level5.AddNew
        PH_Level5.AddIntoList(ModuleList.SelectedItem.Text, ModuleList.SelectedItem.Value)
    End Sub
    'Public Sub PH_Level6_AddNew() Handles PH_Level6.AddNew
    '    PH_Level6.AddIntoList(ModuleList.SelectedItem.Text, ModuleList.SelectedItem.Value)
    'End Sub
    Public Sub PH_Level7_AddNew() Handles PH_Level7.AddNew
        PH_Level7.AddIntoList(ModuleList.SelectedItem.Text, ModuleList.SelectedItem.Value)
    End Sub
    Public Sub PH_Level8_AddNew() Handles PH_Level8.AddNew
        PH_Level8.AddIntoList(ModuleList.SelectedItem.Text, ModuleList.SelectedItem.Value)
    End Sub
    Public Sub PH_Level9_AddNew() Handles PH_Level9.AddNew
        PH_Level9.AddIntoList(ModuleList.SelectedItem.Text, ModuleList.SelectedItem.Value)
    End Sub
    Public Sub PH_Level10_AddNew() Handles PH_Level10.AddNew
        PH_Level10.AddIntoList(ModuleList.SelectedItem.Text, ModuleList.SelectedItem.Value)
    End Sub
    Public Sub PH_Level11_AddNew() Handles PH_Level11.AddNew
        PH_Level11.AddIntoList(ModuleList.SelectedItem.Text, ModuleList.SelectedItem.Value)
    End Sub
    Public Sub PH_Level12_AddNew() Handles PH_Level12.AddNew
        PH_Level12.AddIntoList(ModuleList.SelectedItem.Text, ModuleList.SelectedItem.Value)
    End Sub
#End Region

#Region "General Functions"
    Public Sub AddNewModuleLink(ByRef prmplaceHolder As PlaceHolder)
        Dim dr_row As DataRow
        Dim iCounter As Int32

        If prmplaceHolder.lstModule.Items.Count > 0 Then
            For iCounter = 0 To prmplaceHolder.lstModule.Items.Count - 1

                dr_row = pi_dt_MainlinkModules.NewRow()

                dr_row.Item(pi_str_Module_Links_ID) = 0
                dr_row(pi_str_module_id) = prmplaceHolder.lstModule.Items(iCounter).Value
                dr_row(pi_str_main_links_id) = CType(lblID.Text, Integer)
                dr_row(pi_str_sub_links_id) = 0
                dr_row(pi_str_Module_Position) = prmplaceHolder.PlaceHolder_Position
                dr_row(pi_str_Show_flag) = 1

                pi_dt_MainlinkModules.Rows.Add(dr_row)
            Next
        End If
    End Sub
#End Region

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        pi_dt_MainlinkModules = New DataTable

        Dim dt_column As New DataColumn

        dt_column.ColumnName = pi_str_Module_Links_ID
        dt_column.DataType = GetType(Int32)
        pi_dt_MainlinkModules.Columns.Add(dt_column)

        dt_column = New DataColumn
        dt_column.ColumnName = pi_str_module_id
        dt_column.DataType = GetType(Int32)
        pi_dt_MainlinkModules.Columns.Add(dt_column)

        dt_column = New DataColumn
        dt_column.ColumnName = pi_str_main_links_id
        dt_column.DataType = GetType(Int32)
        pi_dt_MainlinkModules.Columns.Add(dt_column)

        dt_column = New DataColumn
        dt_column.ColumnName = pi_str_sub_links_id
        dt_column.DataType = GetType(Int32)
        pi_dt_MainlinkModules.Columns.Add(dt_column)

        dt_column = New DataColumn
        dt_column.ColumnName = pi_str_Module_Position
        dt_column.DataType = GetType(String)
        pi_dt_MainlinkModules.Columns.Add(dt_column)

        dt_column = New DataColumn
        dt_column.ColumnName = pi_str_Show_flag
        dt_column.DataType = GetType(Int32)
        pi_dt_MainlinkModules.Columns.Add(dt_column)

        pi_dt_MainlinkModules.Rows.Clear()

        AddNewModuleLink(PH_Level1)
        AddNewModuleLink(PH_Level2)
        AddNewModuleLink(PH_Level3)
        AddNewModuleLink(PH_Level4)
        AddNewModuleLink(PH_Level5)
        'AddNewModuleLink(PH_Level6)
        AddNewModuleLink(PH_Level7)
        AddNewModuleLink(PH_Level8)
        AddNewModuleLink(PH_Level9)
        AddNewModuleLink(PH_Level10)
        AddNewModuleLink(PH_Level11)
        AddNewModuleLink(PH_Level12)

        pi_obj_Mainlinks = New Trade_BL.MainLinks

        If pi_obj_Mainlinks.UpdateModuleLinks(main_Link_ID, pi_dt_MainlinkModules) = True Then
            lblMessage.Text = "Updation Done Successfully"
        Else
            lblMessage.Text = "Updation Failed, Contact system administrator"
        End If

    End Sub
End Class
