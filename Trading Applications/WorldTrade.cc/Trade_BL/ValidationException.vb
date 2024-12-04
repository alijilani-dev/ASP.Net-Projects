Imports System.IO
Public Class ValidationException
  Inherits System.Exception

  '****************************************
  'Programmer				      :   Vishal
  'Date Of Creation			  :   16-08-2005
  'Description				    :   Overloaded Contructor Method for Validation
  '			
  'Accepted Parameters		: None
  'Return Values			    :   
  'Global Variables Accessed	:   
  'Global Variables Modified	:
  '
  'Called by				      :
  'Called					        :
  '
  'Tables/Fields Accessed	:
  '
  'Last Edited By			    :
  'Last Edited On			    :
  'Reason				          :
  '
  '****************************************
  Public Sub New()

  End Sub


  '****************************************
  'Programmer				    :   Vishal
  'Date Of Creation			:   16-08-2005
  'Description				  :   Overloaded Contructor Method for QMS validation
  '
  'Accepted Parameters	:   String
  'Return Values			  :   
  'Global Variables Accessed	:   
  'Global Variables Modified	:
  '
  'Called by				    :
  'Called					      :
  '
  'Tables/Fields Accessed		:
  '
  'Last Edited By			  :
  'Last Edited On			  :
  'Reason				        :
  '
  '****************************************
  Public Sub New(ByVal excMessage As String)

    MyBase.New(excMessage)

  End Sub

  '****************************************
  'Programmer				      : Vishal
  'Date Of Creation			  : 16-08-2005
  'Description				    : Overloaded Contructor Method for Exception
  '			                    Wraps & passes the inner exception with a more meaningful message
  'Accepted Parameters		: String Message, Inner Exception
  'Return Values			    :   
  'Global Variables Accessed	:   
  'Global Variables Modified	:
  '
  'Called by				      :
  'Called					        :
  '
  'Tables/Fields Accessed	:
  '
  'Last Edited By			    :
  'Last Edited On			    :
  'Reason				          :
  '
  '****************************************
  Public Sub New(ByVal excMessage As String, ByVal innerExc As Exception)
    MyBase.New(excMessage, innerExc)
  End Sub

End Class
