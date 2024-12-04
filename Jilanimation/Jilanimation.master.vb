
Partial Class MasterPage
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim CSM As ClientScriptManager = Page.ClientScript
        'CSM.RegisterClientScriptBlock(Me.GetType(), "breadcrumps", "<script language=javascript src='breadcrumps.js'>")
        'https://www.google.com/search?gbv=2&hl=en&btnG=Search+Images&q=ballooning&tbs=isz:ex,iszw:70,iszh:70&tbm=isch'
        CSM.RegisterStartupScript(Me.GetType(), "breadcrumps", "<script language=javascript src='breadcrumps.js'>")
    End Sub
End Class

