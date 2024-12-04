Imports System.Web.Mail
Imports System.Data.SqlClient

Public Class MailForm
    Inherits System.Web.UI.Page

#Region " Web Form Designer Generated Code "

    'This call is required by the Web Form Designer.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents ddlMonth As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlYear As System.Web.UI.WebControls.DropDownList
    Protected WithEvents rdoType1 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rdoType2 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rdoType3 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents btnMail As System.Web.UI.WebControls.Button

    'NOTE: The following placeholder declaration is required by the Web Form Designer.
    'Do not delete or move it.
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: This method call is required by the Web Form Designer
        'Do not modify it using the code editor.
        InitializeComponent()
    End Sub

#End Region
    Private myConnectionString As String
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Put user code to initialize the page here
    End Sub
    Private Function GetBodyText(ByVal MemberCompany As String)
        Dim objXMLHTTP, xml
        Dim bodytxt As String
        Try
            xml = CreateObject("Msxml2.ServerXMLHTTP")
            xml.Open("GET", "http://www.phonetrade.cc/signup_email.htm", False)
            xml.Send()

            bodytxt = xml.responseText()
            bodytxt = bodytxt.Replace("*Member*", MemberCompany)
            xml = Nothing
            Return bodytxt
        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Function
    Private Sub SendThanksMail(ByVal strCompany As String)
        Try
            Dim msgMail As New MailMessage

            msgMail.To = "aliphonetrade@hotmail.com"
            msgMail.From = "info@phonetrade.cc"
            'msgMail.Bcc = "Basheer@skyphi.com,trading_support@yahoo.com"
            msgMail.Subject = "Thank you for joining PhoneTrade.cc."

            msgMail.BodyFormat = MailFormat.Html
            msgMail.Body = GetBodyText(strCompany)
            SmtpMail.Send(msgMail)

        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
    Private Sub SendPrintForm(ByVal pi_obj_members As Trade_BL.Member)

        Dim objXMLHTTP, xml
        Dim strMailContent As String
        Dim mlMsg As New MailMessage

        Try
            xml = CreateObject("Msxml2.ServerXMLHTTP")
            xml.Open("GET", "http://www.Phonetrade.cc/Print.htm", False)
            xml.Send()
            strMailContent = xml.responseText()
            xml = Nothing
            strMailContent = strMailContent.Replace("< CompanyName >", "<font color = '#FF0000'>" & pi_obj_members.member_id & " </font>")
            strMailContent = strMailContent.Replace("< Address >", "<font color = '#FF0000'>" & pi_obj_members.mailing_address & " </font>")
            strMailContent = strMailContent.Replace("< Country >", "<font color = '#FF0000'>c </font>")
            strMailContent = strMailContent.Replace("< Phone >", "<font color = '#FF0000'>" & pi_obj_members.company_phone & " </font>")
            strMailContent = strMailContent.Replace("< Fax >", "<font color = '#FF0000'>" & pi_obj_members.company_fax & " </font>")
            strMailContent = strMailContent.Replace("< Email >", "<font color = '#FF0000'>" & pi_obj_members.company_email & " </font>")
            strMailContent = strMailContent.Replace("< Website >", "<font color = '#FF0000'>" & pi_obj_members.company_website & " </font>")
            strMailContent = strMailContent.Replace("< Name >", "<font color = '#FF0000'>" & pi_obj_members.company_contact2_name & " </font>")
            strMailContent = strMailContent.Replace("< Mobile >", "<font color = '#FF0000'>" & pi_obj_members.company_contact1_mobile & " </font>")
            strMailContent = strMailContent.Replace("< PersonalEmail >", "<font color = '#FF0000'>" & pi_obj_members.company_contact1_email & " </font>")
            strMailContent = strMailContent.Replace("< SecondContact >", "<font color = '#FF0000'>" & pi_obj_members.company_contact2_name & " </font>")
            strMailContent = strMailContent.Replace("< MobileNo2 >", "<font color = '#FF0000'>" & pi_obj_members.company_contact2_mobile & " </font>")
            strMailContent = strMailContent.Replace("< PersonalEmail2 >", "<font color = '#FF0000'>" & pi_obj_members.company_contact2_email & " </font>")
            Dim i As Integer
            Dim strCompanyType As String = New String("")

            For i = 0 To pi_obj_members.Trading_Cat.Rows.Count
                strCompanyType = strCompanyType & "<TR><TD><img src=http://www.Phonetrade.cc/Images/tick.gif border=0><font color=#990000><b>" & pi_obj_members.Trading_Cat.Rows(1)(0) & "</b></font></TD></TR>"
            Next

            strMailContent = strMailContent.Replace("< %CompanyType% >", strCompanyType)

            mlMsg.To = "aliphonetrade@hotmail.com"
            mlMsg.From = "info@phonetrade.cc"
            'mlMsg.Bcc = "malik@skyphi.com"
            mlMsg.BodyFormat = MailFormat.Html
            mlMsg.Subject = "Phone Trade Enquiry ...."
            mlMsg.Body = strMailContent
            SmtpMail.SmtpServer = ""
            SmtpMail.Send(mlMsg)

        Catch ex As Exception
            Response.Write(ex.Message)
        End Try
    End Sub
    Public Function GetMembers() As SqlDataReader
        Dim idbparameter(1) As IDataParameter
        Dim myConnection As New SqlConnection(myConnectionString)
        Dim ds As New DataSet
        Dim myDatatable As New DataTable
        Dim dr As SqlDataReader

        If myConnectionString = "" Then
            myConnectionString = "data source=213.42.18.90;initial catalog=trade;integrated security=True;User ID=trade; Password=etrade"
        End If
        Try
            myConnection.Open()

            Dim cmd As New SqlCommand("select * from Members where [timestamp] like 'Jan%2006%' and ActivateFlag=2", myConnection)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.Message)

        End Try
        ' Return the table
        Return dr
    End Function

    Private Sub btnMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMail.Click
        Dim sqlRd As SqlDataReader
        sqlRd = GetMembers()
        '        Response.Write(sqlRd.HasRows)

    End Sub
End Class
