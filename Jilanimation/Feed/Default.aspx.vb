Imports System.Data.SqlClient
Imports System.Xml

Partial Class Feed_Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Clear()
        Response.ContentType = "application/rss+xml"
        Dim objX As New XmlTextWriter(Response.OutputStream, Encoding.UTF8)
        'Dim fid As String = Page.Request.QueryString("FID").ToString()
        Dim qry As String
        If IsNothing(Page.Request.QueryString("FID")) Then
            qry = "Select TOP 10 * From Articles ORDER BY ID DESC"
        Else
            qry = "Select TOP 10 * From Articles where Category = " & Page.Request.QueryString("FID").ToString() & " ORDER BY ID DESC"
        End If
        objX.WriteStartDocument()
        objX.WriteStartElement("rss")
        objX.WriteAttributeString("version", "2.0")
        objX.WriteStartElement("channel")

        Dim cmd As New SqlCommand(qry, New SqlConnection(ConfigurationManager.ConnectionStrings("jilanimation").ConnectionString))
        cmd.Connection.Open()
        Dim dr As SqlDataReader = cmd.ExecuteReader()

        objX.WriteElementString("title", "Jilanimation RSS Feed")
        objX.WriteElementString("link", "http://www.ASP.net/")
        objX.WriteElementString("description", "Stay in touch for improved information on a variety of topics, You will require an RSS reader such as Internet Explorer 7 to make better use of this information.")
        objX.WriteElementString("language", "en-us")
        objX.WriteElementString("ttl", "60")
        objX.WriteElementString("image", "http://vbasic.net/media/logo.gif")
        objX.WriteElementString("lastBuildDate", String.Format("{0:R}", DateTime.Now))

        Do While dr.Read()
            objX.WriteStartElement("item")
            objX.WriteElementString("title", dr("Title").ToString())
            objX.WriteElementString("author", "Jilanimation")
            objX.WriteElementString("link", "http://www.ASP.net/")
            objX.WriteStartElement("guid")
            objX.WriteAttributeString("isPermaLink", "true")
            objX.WriteString("http://www.ASP.net/")
            objX.WriteEndElement()
            objX.WriteElementString("pubDate", String.Format("{0:R}", dr("DateTimeAdded")))
            objX.WriteStartElement("category")
            objX.WriteString(dr("Category").ToString())
            objX.WriteEndElement()
            objX.WriteElementString("description", dr("Article").ToString() & "..")
            objX.WriteEndElement()
        Loop

        objX.WriteEndElement()
        objX.WriteEndElement()
        objX.WriteEndDocument()
        objX.Flush()
        objX.Close()
        Response.End()
    End Sub

End Class
