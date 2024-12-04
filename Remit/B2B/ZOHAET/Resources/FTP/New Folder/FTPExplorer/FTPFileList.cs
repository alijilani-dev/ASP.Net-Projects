/*	Project		:	FTPExplorer
 *  Version		:	2.0
 *	File Name	:	FTPClientList.cs
 *	Purpose		:	Helper class for holding file list
 *	Author		:	K.Niranjan Kumar
 *	Date		:	July 08,2001
 *	Company		:	Cognizant Technology Solutions.
 *	e-Mail		:	KNiranja@chn.cognizant.com
 */

namespace FTPExplorer
{
    using System;
	using System.Collections;

    /// <summary>
    ///    Summary description for FTPFileList.
    /// </summary>
    public class FileInfo 
    {

		private int m_iFileType;
		private string m_strFileOwner;
		private string m_strFileGroup;
		private int m_iFileSize;
		private string m_strDateCreated;
		private string m_strFileName;
		private string m_strFilePath;
		private string m_strTimeCreated;

		public FileInfo()
        {
            //
            // TODO: Add Constructor Logic here
            //
			m_iFileType = 0;
			m_strFileOwner = "";
			m_strFileGroup = "";
			m_iFileSize = 0;
			m_strDateCreated = "";
			m_strFileName = "";
			m_strFilePath = "";
			m_strTimeCreated = "";
        }

		public void SetFileInfo(int l_iFileType,string l_strFileName,string l_strFilePath,string l_strDateCreated,int l_iSize,string l_strFileOwner,string l_strFileGroup,string l_strTimeCreated){
			m_iFileType = l_iFileType;
			m_strFilePath = l_strFilePath;
			m_strFileName = l_strFileName;
			m_strDateCreated = l_strDateCreated;
			m_iFileSize = l_iSize;
			m_strFileOwner = l_strFileOwner;
			m_strFileGroup = l_strFileGroup;
			m_strTimeCreated = l_strTimeCreated;
		}

		public void GetFileInfo(out int l_ioutFileType,out string l_stroutFileName,out string l_stroutFilePath,out string l_stroutDate,out int l_ioutSize,out string l_stroutFileOwner,out string l_stroutFileGroup,out string l_stroutTimeCreated){
			l_ioutFileType = m_iFileType;
			l_stroutFilePath = m_strFilePath;
			l_stroutFileName = m_strFileName;
			l_stroutDate = m_strDateCreated ;
			l_ioutSize = m_iFileSize;
			l_stroutFileOwner = m_strFileOwner;
			l_stroutFileGroup = m_strFileGroup;
			l_stroutTimeCreated = m_strTimeCreated;
		}

		public int GetFileType(){
			return m_iFileType;
		}

		public string GetFileName(){
			return m_strFileName;
		}

/*		public string FilePath {
			get {
				m_strFilePath = value;
			}
			set {
				return m_strFilePath;
			}
		}

		public string FileName {
			get {
				m_strFileName = value;
			}
			set {
				return m_strFileName;
			}
		}

		public string DateCreated {
			get {
				m_strDateCreated = value;
			}
			set {
				return m_strDateCreated;
			}
		}

		public string FileSize {
			get {
				m_iFileSize = value;
			}
			set {
				return m_iFileSize;
			}
		}
*/
    }

	public class FileList {
		private ArrayList m_List;

		private int m_iCurPos;
		private int m_iCount;
		private int m_iTotalLength;

		public FileList(){
			m_List = new ArrayList();
			m_iCurPos = -1;
			m_iCount = 0;
			m_iTotalLength = 0;
		}

		public void Add(FileInfo l_FileInfoObj){
			m_List.Add(l_FileInfoObj);
			m_iCurPos++;
			m_iCount++;
		}

		public FileInfo GetFileInfo(int l_iPos){
			if ( l_iPos > m_iCount ) {
				return null;
			}
			else {
				return (FileInfo) m_List[l_iPos];
			}
		}

		public FileInfo Get(){
			if ( m_iCurPos > 0 ) {
				m_iCurPos--;
				return (FileInfo) m_List[m_iCurPos];
			}
			else if ( m_iCurPos == 0 ) {
				return (FileInfo) m_List[m_iCurPos];
			}
			return null;
		}

		public int GetCount() {
			return m_iCount;
		}

		public void RemoveAll(){
			/*	Removes all items from the list object */
			m_List.Clear();
			m_iCurPos = -1;
			m_iCount = 0;
			m_iTotalLength = 0;
		}

		public int TotalLength {
			get {
				return m_iTotalLength;
			}
			set {
				m_iTotalLength = value;
			}
		}
	}

	public class DownloadFileData {
		private string m_strServerFileName;
		private string m_strLocalFileName;
		private int m_iFileSize;
		
		public DownloadFileData(){
			m_strServerFileName = "";
			m_strLocalFileName = "";
			m_iFileSize = 0;
		}

		public string ServerFileName {
			get {
				return m_strServerFileName;
			}
			set {
				m_strServerFileName = value;
			}
		}

		public string LocalFileName {
			get {
				return m_strLocalFileName;
			}
			set {
				m_strLocalFileName = value;
			}
		}

		public int FileSize {
			get {
				return m_iFileSize;
			}
			set {
				m_iFileSize = value;
			}
		}
	}
}
