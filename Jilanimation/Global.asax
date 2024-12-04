<%@ Application Language="VB" %>

<script runat="server">
    'using System.Diagnostics;

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs on application startup
    End Sub
    
    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs on application shutdown
    End Sub
        
    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs when an unhandled error occurs
        Dim ctx As HttpContext = HttpContext.Current
        Dim exception As Exception = ctx.Server.GetLastError
        Dim errInfo As String = "<br>Error In : " & ctx.Request.Url.ToString() & _
        "<br>Source:" & exception.Source & _
        "<br>Message: " & exception.Message & _
        "<br>Stack Trace: " & exception.StackTrace
        ctx.Response.Write(errInfo)
        'To let the page finish running we clear the error
        ctx.Server.ClearError()
        'Session("value") = errInfo
        'GenericError is the page where i am redirecting user with message
        System.Web.HttpContext.Current.Response.Redirect("~/default.aspx")
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs when a new session is started
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs when a session ends. 
        ' Note: The Session_End event is raised only when the sessionstate mode
        ' is set to InProc in the Web.config file. If session mode is set to StateServer 
        ' or SQLServer, the event is not raised.
    End Sub
       
</script>