using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes; 
using Microsoft.ApplicationBlocks.Data;
using Evernet.MoneyExchange.DataClasses;
using Params = Evernet.MoneyExchange.DataClasses.Parameters;
using SPs = Evernet.MoneyExchange.DataClasses.StoredProcedures;
using UserRoleFields = Evernet.MoneyExchange.DataClasses.StoredProcedures.spS_UserRoleAssignmentList.Resultset1.Fields;
using UserFields = Evernet.MoneyExchange.DataClasses.StoredProcedures.spS_UserList.Resultset1.Fields;
using Evernet.Shared;

namespace Evernet.MoneyExchange.BusinessLogic {
	public class UserManager {
		public static string GetLoginNameForUserId(Guid userId) {
			string loginName = String.Empty;

			Evernet.MoneyExchange.AbstractClasses.Abstract_UserList aoUser
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_UserList(ConfigHelper.ConStr);

			if(aoUser.Refresh(userId)) {
				loginName = aoUser.Col_LoginName.Value;
			}

			return loginName;
		}

		public static AuthenticationResult AuthenticateUser(string loginName, string Password) {
			// Check in administrators
			DataSet ds = SqlHelper.ExecuteDataset(Evernet.Shared.ConfigHelper.ConStr,
				CommandType.Text,
				"Select * From UserList Where LoginName='"+ loginName +"' And LoginPassword ='"+ Password +"'");
			DataTable dt = ds.Tables[0];

			AuthenticationResult ar = null;

			if(dt.Rows.Count<1) {

				ds = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
					CommandType.Text,
					"Select * From fnCustomerList_Full(Null,Null,Null) Where CardId_Code='"+ loginName +"' And Password='"+ Password +"'");
				dt = ds.Tables[0];

				if(dt.Rows.Count<1) {
					ar = new AuthenticationResult(false,"Invalid LoginName or Password");
				} else {
					ar = new AuthenticationResult(true,
						dt.Rows[0]["Id"].ToString(),
						"Customer");
				}
			} else {
				bool isActive = Convert.ToBoolean(dt.Rows[0]["Active"]);

				if(!isActive) {
					ar = new AuthenticationResult(false,"Account not active");
				} else {
					SqlGuid userId = new SqlGuid(dt.Rows[0]["Id"].ToString());
					Params.spS_UserRoleAssignmentList Param = new Params.spS_UserRoleAssignmentList(true); 
					Param.SetUpConnection(Evernet.Shared.ConfigHelper.ConStr);
					Param.Param_UserId = userId;
					

					DataSet dsRoles = null;
					
					SPs.spS_UserRoleAssignmentList SP = new SPs.spS_UserRoleAssignmentList(false);

					SP.Execute(ref Param, ref dsRoles);

					DataTable dtRoles = dsRoles.Tables[0];
					
					if(dtRoles.Rows.Count<1) {
						ar = new AuthenticationResult(false, "Authorisation to login not found!");
					} else {
						bool isAdmin=false;

						foreach(DataRow drRole in dtRoles.Rows) {
							if("Administrator"==drRole["Role"].ToString()) {
								isAdmin=true;
								break;
							}
						}

						if(isAdmin) {
							ar = new AuthenticationResult(true, userId.ToString());
						} else {
							// Later check for agent and countries activation
							//Params.spS_UserList UserListParam = new Params.spS_UserList(true);
							ar = new AuthenticationResult(true, userId.ToString());
						}
					}
				}
			}

			return ar;
		}

		public static string GetUserRoles(Guid userId) {
			DataSet ds = SqlHelper.ExecuteDataset(Evernet.Shared.ConfigHelper.ConStr,
				CommandType.Text,
				"Select Role From UserRoleAssignmentList Where UserId='"+userId.ToString()+"'");

			DataTable dt = ds.Tables[0];

			string roles=String.Empty;

			for(int i=0;i<dt.Rows.Count;i++) {
				roles += dt.Rows[i]["Role"].ToString();

				if(i!=dt.Rows.Count-1) {
					roles+="|";
				}
			}

			return roles;
		}
	
		public static bool IsInRole(Guid userId, string role) {
			string roleList = GetUserRoles(userId);
			string[] roleListSplit = roleList.Split(new char[]{'|'});
			bool hasRole = false;

			foreach(string str in roleListSplit) {
				if(str == role) {
					hasRole=true;
					break;
				}
			}
            
			return hasRole;
		}

		public static Guid GetAgentForUser(Guid userId) {
			Guid agentId = Guid.Empty;

			Evernet.MoneyExchange.AbstractClasses.Abstract_UserList aoUserList
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_UserList(ConfigHelper.ConStr);

			if(aoUserList.Refresh(userId)) {
				if(!aoUserList.Col_AgentId.IsNull) {
					agentId = aoUserList.Col_AgentId.Value;
				}
			} else {
				throw new UserException("No user found with provided Id");
			}
			
			return agentId;
		}

		public static Guid GetAgentAccountForUser(Guid userId) {
			Guid agentAccountId = Guid.Empty;

//			Evernet.MoneyExchange.AbstractClasses.Abstract_AgentLocationList aoAgent
//				= new Evernet.MoneyExchange.AbstractClasses.Abstract_AgentLocationList(ConfigHelper.ConStr);

			Evernet.MoneyExchange.AbstractClasses.Abstract_UserList aoUserList 
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_UserList(ConfigHelper.ConStr);

			

			if(aoUserList.Refresh(userId)) {
//				if(!aoAgent.Col_AccountId.IsNull) {
//					//agentAccountId=aoAgent.Col_AccountId.Value;
//				}

				if(!aoUserList.Col_AgentAccountId.IsNull) {
					agentAccountId = aoUserList.Col_AgentAccountId.Value;
				} else {
					throw new UserException("No Agent Account present for provided user");
				}
			} else {
				throw new UserException("No User present for the provided Id");
			}

			return agentAccountId;
		}

		public static Guid GetLocationForUser(Guid userId) {
			Guid locationId = Guid.Empty;

			Evernet.MoneyExchange.AbstractClasses.Abstract_UserList aoUserList
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_UserList(ConfigHelper.ConStr);

			if(aoUserList.Refresh(userId)) {
				if(!aoUserList.Col_AgentId.IsNull) {
					Evernet.MoneyExchange.AbstractClasses.Abstract_AgentLocationList aoAgentList
						= new Evernet.MoneyExchange.AbstractClasses.Abstract_AgentLocationList(ConfigHelper.ConStr);
					aoAgentList.Refresh(aoUserList.Col_AgentId);

					locationId = aoAgentList.Col_LocationId.Value;
				}
			} else {
				throw new UserException("No user found with provided Id");
			}
			
			return locationId;
		}

		public static Guid GetCountryForUser(Guid userId) {
			Guid countryId = Guid.Empty;

			Evernet.MoneyExchange.AbstractClasses.Abstract_UserList aoUserList
				= new Evernet.MoneyExchange.AbstractClasses.Abstract_UserList(ConfigHelper.ConStr);

			if(aoUserList.Refresh(userId)) {
				if(!aoUserList.Col_AgentId.IsNull) {
					Evernet.MoneyExchange.AbstractClasses.Abstract_AgentLocationList aoAgentList
						= new Evernet.MoneyExchange.AbstractClasses.Abstract_AgentLocationList(ConfigHelper.ConStr);
					aoAgentList.Refresh(aoUserList.Col_AgentId);

					Evernet.MoneyExchange.AbstractClasses.Abstract_LocationList aoLocationList
						= new Evernet.MoneyExchange.AbstractClasses.Abstract_LocationList(ConfigHelper.ConStr);
					
					aoLocationList.Refresh(aoAgentList.Col_LocationId);

					countryId = aoLocationList.Col_CountryId.Value;
				} else if(!aoUserList.Col_AgentAccountId.IsNull) {
					Evernet.MoneyExchange.AbstractClasses.Abstract_AgentMaster aoAgentAccount
						= new Evernet.MoneyExchange.AbstractClasses.Abstract_AgentMaster(ConfigHelper.ConStr);
					aoAgentAccount.Refresh(aoUserList.Col_AgentAccountId);

					countryId = aoAgentAccount.Col_CountryId.Value;
				}
			} else {
				throw new UserException("No user found with provided Id");
			}
			
			return countryId;
		}

		public static Guid GetIdForUserLogin(string loginName) {
			Guid userId = Guid.Empty;

			DataTable dt = SqlHelper.ExecuteDataset(ConfigHelper.ConStr,
				CommandType.Text,
				"Select [Id] From UserList Where LoginName='"+loginName+"'").Tables[0];

			if(dt.Rows.Count>0) {
				userId = new Guid(dt.Rows[0]["Id"].ToString());
			}
			return userId;
		}

	}
	public class UserException : System.Exception {
		private UserException(){}

		public UserException(string message):base(message) {}
	}
	public class AuthenticationResult {
		private AuthenticationResult() {}

		private bool _wasAuthenticated;
		private string _message;
		private string _userType;

		public bool WasAuthenticated {
			get {
				return _wasAuthenticated;
			}
		}

		public string Message {
			get {
				return _message;
			}
		}

		public string UserType {
			get {
				return _userType;
			}
		}

		internal AuthenticationResult(bool wasAuthenticated, string message) {
			this._wasAuthenticated=wasAuthenticated;
			this._message=message;
			this._userType="Admin";
		}

		internal AuthenticationResult(bool wasAuthenticated, string message, string userType) {
			this._wasAuthenticated=wasAuthenticated;
			this._message=message;
			this._userType=userType;
		}
	}

}
