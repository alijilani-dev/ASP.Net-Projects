using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace WebApplication1
{
	/// <summary>
	/// Summary description for WebForm1.
	/// </summary>
	public class WebForm1 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox textbox1;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Label lblMessage;
		protected System.Web.UI.WebControls.Button Button1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			string unicodeString = "This string contains the unicode character Pi(\u03a0)";

			// Create two different encodings.
			Encoding ascii = Encoding.ASCII;
			Encoding unicode = Encoding.Unicode;

			// Convert the string into a byte[].
			byte[] unicodeBytes = unicode.GetBytes(unicodeString);

			// Perform the conversion from one encoding to the other.
			byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes);
            
			// Convert the new byte[] into a char[] and then into a string.
			// This is a slightly different approach to converting to illustrate
			// the use of GetCharCount/GetChars.
			char[] asciiChars = new char[ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length)];
			ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0);
			string asciiString = new string(asciiChars);

			// Display the strings created before and after the conversion.
			Label1.Text  = String.Format("Original string: {0}", unicodeString);
			Label1.Text += String.Format("Ascii converted string: {0}", asciiString);
			UploadFile();
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		private void UploadFile()
		{
			int l_iRetval = 0,l_iDataPort = 0;
			TcpListener l_FTPListener = null;
			try 
			{

				l_FTPListener = new TcpListener(0);
				l_FTPListener.Start();
				IPEndPoint pt = (IPEndPoint) l_FTPListener.LocalEndpoint;
				l_iDataPort = pt.Port;
				lblMessage.Text = "Port Number: " + pt.Port.ToString() + " Port Address: " + pt.Address.ToString();
			}
			catch(ArgumentOutOfRangeException ex)
			{
				lblMessage.Text = ex.Message;
			}
			//string l_strOutput = "",l_strCommand = "";
			string l_strPortParams = GetPortParameters(l_iDataPort);
			lblMessage.Text += "\n\rPort Parameters: " + l_strPortParams.ToString();
		}

		private string GetPortParameters(int l_iPort)
		{
			string l_strLocalMachine = Dns.GetHostName();
			IPEndPoint l_IPServer;
			IPHostEntry l_localHost = Dns.Resolve(l_strLocalMachine);
			IPAddress l_IPAddress = l_localHost.AddressList[0];
			l_IPServer = new IPEndPoint(l_IPAddress,l_iPort);

			string l_strIPAddress = l_IPAddress.ToString();
			l_strIPAddress = l_strIPAddress.Replace('.',',');
			int l_iParam1 = ( 0xff00 & l_iPort ) >> 8;
			int l_iParam2 = ( 0xff & l_iPort ) ;

			string l_strPortParam = l_strIPAddress + "," + l_iParam1 + "," + l_iParam2;
			return l_strPortParam;
		}
	}
}
