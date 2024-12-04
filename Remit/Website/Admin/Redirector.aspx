<%@ Page Language="C#" ContentType="text/html" ResponseEncoding="iso-8859-1" %>
<script language="javascript">
url = "<% if(Request["ru"]!=null){Response.Write(Request["ru"]);}else{Response.Write("Home.aspx");} %>";
document.location.href=url;
</script>