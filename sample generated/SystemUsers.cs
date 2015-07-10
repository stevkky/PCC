/*----------------------------------------------------------------------------------------------------------*/
/* Telligent (GH) Systems CodeGenerator (written by Stephen Adjei-Kyei.)                                   */
/*                                                                                                         */
/* File was generated using Telligent (GH) System's Code Generator.                                        */
/*                                                                                                         */
/* Date Generated: 7/7/2015 1:22:22 PM                                                                    */
/*                                                                                                         */
/* www.telligentgh.com                                                                                     */
/*---------------------------------------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

/// <summary>
/// Data Access Layer Class for the [dbo].[system_users] Database Table
/// Business Logic to Access this Class will be in the SystemUsers_Bll.cs file
/// All Business Logic should be therefore be Placed in that file
/// </summary>

namespace testingGen
{
	[DataObject]
	[Serializable]
	public partial class SystemUsers
	{
	
	
		#region Constants
		private static readonly string TABLE_NAME = "[dbo].[system_users]";
	
		#endregion
	
	
		#region Fields
		private System.String _username;
		private System.String _password;
		private System.String _name;
		private System.DateTime? _lastLogin;
		private System.String _profile;
		private System.String _status;
		private System.String _senderid;
		private System.String _ORDERBY_FIELD;
	
		#endregion
	
	
		#region Properties
		public System.String Username
		{
			get
			{
				return _username;
			}
			set
			{
				_username = value;
			}
		}
		
		public System.String Password
		{
			get
			{
				return _password;
			}
			set
			{
				_password = value;
			}
		}
		
		public System.String Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}
		
		public System.DateTime? LastLogin
		{
			get
			{
				return _lastLogin;
			}
			set
			{
				_lastLogin = value;
			}
		}
		
		public System.String Profile
		{
			get
			{
				return _profile;
			}
			set
			{
				_profile = value;
			}
		}
		
		public System.String Status
		{
			get
			{
				return _status;
			}
			set
			{
				_status = value;
			}
		}
		
		public System.String Senderid
		{
			get
			{
				return _senderid;
			}
			set
			{
				_senderid = value;
			}
		}
		
		public System.String  ORDERBY_FIELD
		{
			get
			{
				return _ORDERBY_FIELD;
			}
			set
			{
				 _ORDERBY_FIELD = value;
			}
		}
		
		#endregion
	
	
		#region Methods
	
	
		#region Mapping Methods
	
		protected void MapTo(DataSet ds)
		{
			DataRow dr;
	
	
			if (ds == null)
				ds = new DataSet();
	
			if (ds.Tables["TABLE_NAME"] == null)
				ds.Tables.Add(TABLE_NAME);
	
			ds.Tables[TABLE_NAME].Columns.Add("username", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("password", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("name", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("last_login", typeof(System.DateTime) );
			ds.Tables[TABLE_NAME].Columns.Add("profile", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("status", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("senderid", typeof(System.String) );
	
			dr = ds.Tables[TABLE_NAME].NewRow();
	
			if (Username == null)
				dr["username"] = DBNull.Value;
			else
				dr["username"] = Username;
	
			if (Password == null)
				dr["password"] = DBNull.Value;
			else
				dr["password"] = Password;
	
			if (Name == null)
				dr["name"] = DBNull.Value;
			else
				dr["name"] = Name;
	
			if (LastLogin == null)
				dr["last_login"] = DBNull.Value;
			else
				dr["last_login"] = LastLogin;
	
			if (Profile == null)
				dr["profile"] = DBNull.Value;
			else
				dr["profile"] = Profile;
	
			if (Status == null)
				dr["status"] = DBNull.Value;
			else
				dr["status"] = Status;
	
			if (Senderid == null)
				dr["senderid"] = DBNull.Value;
			else
				dr["senderid"] = Senderid;
	
	
			ds.Tables[TABLE_NAME].Rows.Add(dr);
	
		}
	
		protected void MapFrom(DataRow dr)
		{
			Username = dr["username"] != DBNull.Value ? Convert.ToString(dr["username"]) : Username = null;
			Password = dr["password"] != DBNull.Value ? Convert.ToString(dr["password"]) : Password = null;
			Name = dr["name"] != DBNull.Value ? Convert.ToString(dr["name"]) : Name = null;
			LastLogin = dr["last_login"] != DBNull.Value ? Convert.ToDateTime(dr["last_login"]) : LastLogin = null;
			Profile = dr["profile"] != DBNull.Value ? Convert.ToString(dr["profile"]) : Profile = null;
			Status = dr["status"] != DBNull.Value ? Convert.ToString(dr["status"]) : Status = null;
			Senderid = dr["senderid"] != DBNull.Value ? Convert.ToString(dr["senderid"]) : Senderid = null;
		}
	
		public static SystemUsers[] MapFrom(DataSet ds)
		{
			List<SystemUsers> objects;
	
	
			// Initialise Collection.
			objects = new List<SystemUsers>();
	
			// Validation.
			if (ds == null)
				throw new ApplicationException("Cannot map to dataset null.");
			else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
				return objects.ToArray();
	
			if (ds.Tables[TABLE_NAME] == null)
				throw new ApplicationException("Cannot find table [dbo].[system_users] in DataSet.");
	
			if (ds.Tables[TABLE_NAME].Rows.Count < 1)
				throw new ApplicationException("Table [dbo].[system_users] is empty.");
	
			// Map DataSet to Instance.
			foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
			{
				SystemUsers instance = new SystemUsers();
				instance.MapFrom(dr);
				objects.Add(instance);
			}
	
			// Return collection.
			return objects.ToArray();
		}
	
	
		#endregion
	
	
		#region CRUD Methods
	
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static SystemUsers Get(System.String username)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
			SystemUsers instance;
	
	
			instance = new SystemUsers();
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SystemUsers_SELECT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, username);
	
			// Get results.
			ds = db.ExecuteDataSet(dbCommand);
			// Verification.
			if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get SystemUsers ID:" + username.ToString()+ " from Database.");
			// Return results.
			ds.Tables[0].TableName = TABLE_NAME;
	
			instance.MapFrom( ds.Tables[0].Rows[0] );
			return instance;
		}
	
		#region INSERT
		public void Insert(System.String username, System.String password, System.String name, System.DateTime? lastLogin, System.String profile, System.String status, System.String senderid, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SystemUsers_INSERT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, username, password, name, lastLogin, profile, status, senderid);
	
			if (transaction == null)
				db.ExecuteScalar(dbCommand);
			else
				db.ExecuteScalar(dbCommand, transaction);
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
		public void Insert(System.String username, System.String password, System.String name, System.DateTime? lastLogin, System.String profile, System.String status, System.String senderid)
		{
			Insert(username, password, name, lastLogin, profile, status, senderid, null);
		}
	/// <summary>
	/// Insert current SystemUsers to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Insert(DbTransaction transaction)
		{
			Insert(Username, Password, Name, LastLogin, Profile, Status, Senderid, transaction);
		}
	
	/// <summary>
	/// Insert current SystemUsers to database.
	/// </summary>
		public void Insert()
		{
			this.Insert((DbTransaction)null);
		}
		#endregion
	
	
		#region UPDATE
		public static void Update(System.String username, System.String password, System.String name, System.DateTime? lastLogin, System.String profile, System.String status, System.String senderid, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SystemUsers_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@username"].Value = username;
			dbCommand.Parameters["@password"].Value = password;
			dbCommand.Parameters["@name"].Value = name;
			dbCommand.Parameters["@lastLogin"].Value = lastLogin;
			dbCommand.Parameters["@profile"].Value = profile;
			dbCommand.Parameters["@status"].Value = status;
			dbCommand.Parameters["@senderid"].Value = senderid;
	
			if (transaction == null)
				db.ExecuteNonQuery(dbCommand);
			else
				db.ExecuteNonQuery(dbCommand, transaction);
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
		public static void Update(System.String username, System.String password, System.String name, System.DateTime? lastLogin, System.String profile, System.String status, System.String senderid)
		{
			Update(username, password, name, lastLogin, profile, status, senderid, null);
		}
	
	public static void Update(SystemUsers systemUsers)
	{
	systemUsers.Update();
	}
	
	public static void Update(SystemUsers systemUsers, DbTransaction transaction)
	{
	systemUsers.Update(transaction);
	}
	
	/// <summary>
	/// Updates changes to the database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Update(DbTransaction transaction)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SystemUsers_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@username"].SourceColumn = "username";
			dbCommand.Parameters["@password"].SourceColumn = "password";
			dbCommand.Parameters["@name"].SourceColumn = "name";
			dbCommand.Parameters["@lastLogin"].SourceColumn = "last_login";
			dbCommand.Parameters["@profile"].SourceColumn = "profile";
			dbCommand.Parameters["@status"].SourceColumn = "status";
			dbCommand.Parameters["@senderid"].SourceColumn = "senderid";
	
			ds = new DataSet();
			this.MapTo( ds );
			ds.AcceptChanges();
			ds.Tables[0].Rows[0].SetModified();
			if (transaction == null)
				db.UpdateDataSet(ds, TABLE_NAME, null, dbCommand, null, UpdateBehavior.Standard);
			else
				db.UpdateDataSet(ds, TABLE_NAME, null, dbCommand, null, transaction);
			return;
		}
	
	/// <summary>
	/// Updates changes to the database.
	/// </summary>
		public void Update()
		{
			this.Update((DbTransaction)null);
		}
		#endregion
	
	
		#region DELETE
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, false)]
		public static void Delete(System.String username, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SystemUsers_DELETE";
			dbCommand = db.GetStoredProcCommand(sqlCommand, username);
	
			// Execute.
	if (transaction != null)
	{
		db.ExecuteNonQuery(dbCommand, transaction);
	}
	else
	{
		db.ExecuteNonQuery(dbCommand);
	}
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
		public static void Delete(System.String username)
	{
	Delete(
	username);
	}
	
	/// <summary>
	/// Delete current SystemUsers from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Delete(DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SystemUsers_DELETE";
			dbCommand = db.GetStoredProcCommand(sqlCommand, Username);
	
			// Execute.
	if (transaction != null)
	{
		db.ExecuteNonQuery(dbCommand, transaction);
	}
	else
	{
		db.ExecuteNonQuery(dbCommand);
	}
		}
	
	/// <summary>
	/// Delete current SystemUsers from database.
	/// </summary>
		public void Delete()
	{
	this.Delete((DbTransaction)null);
	}
	
		#endregion
	
	
		#region SEARCH
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static SystemUsers[] Search(System.String username, System.String password, System.String name, System.DateTime? lastLogin, System.String profile, System.String status, System.String senderid, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SystemUsers_SEARCH";
			dbCommand = db.GetStoredProcCommand(sqlCommand, username, password, name, lastLogin, profile, status, senderid, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return SystemUsers.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static SystemUsers[] Search(SystemUsers searchObject)
		{
			return Search ( searchObject.Username, searchObject.Password, searchObject.Name, searchObject.LastLogin, searchObject.Profile, searchObject.Status, searchObject.Senderid, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all SystemUsers objects.
		/// </summary>
		/// <returns>List of all SystemUsers objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static SystemUsers[] Search()
		{
			return Search ( null, null, null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region SEARCHEXACT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static SystemUsers[] SearchExact(System.String username, System.String password, System.String name, System.DateTime? lastLogin, System.String profile, System.String status, System.String senderid, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SystemUsers_SEARCHEXACT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, username, password, name, lastLogin, profile, status, senderid, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return SystemUsers.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static SystemUsers[] SearchExact(SystemUsers searchObject)
		{
			return SearchExact ( searchObject.Username, searchObject.Password, searchObject.Name, searchObject.LastLogin, searchObject.Profile, searchObject.Status, searchObject.Senderid, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all SystemUsers objects.
		/// </summary>
		/// <returns>List of all SystemUsers objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static SystemUsers[] SearchExact()
		{
			return SearchExact ( null, null, null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region CUSTOMSELECT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static SystemUsers[] CustomSelect(System.String SqlQuery)
		{
			DataSet ds;
			Database db;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			dbCommand = db.GetSqlStringCommand(SqlQuery);
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return SystemUsers.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
		#endregion
	
	
		#region DATATABLESELECT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static DataTable CustomDataTableSelect(System.String SqlQuery)
		{
			DataSet ds;
			Database db;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			dbCommand = db.GetSqlStringCommand(SqlQuery);
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return ds.Tables[0];
		}
	
		#endregion
	
	
		#endregion
	
	
		#endregion
	
	
	}
	}
	
