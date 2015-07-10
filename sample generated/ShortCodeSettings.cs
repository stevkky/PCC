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
/// Data Access Layer Class for the [dbo].[short_code_settings] Database Table
/// Business Logic to Access this Class will be in the ShortCodeSettings_Bll.cs file
/// All Business Logic should be therefore be Placed in that file
/// </summary>

namespace testingGen
{
	[DataObject]
	[Serializable]
	public partial class ShortCodeSettings
	{
	
	
		#region Constants
		private static readonly string TABLE_NAME = "[dbo].[short_code_settings]";
	
		#endregion
	
	
		#region Fields
		private System.Int32? _id;
		private System.Int32? _shortcode;
		private System.String _username;
		private System.String _password;
		private System.String _url;
		private System.String _ipaddress;
		private System.String _apiKey;
		private System.Int32? _port;
		private System.String _prefix;
		private System.String _other1;
		private System.String _other2;
		private System.Boolean? _originate;
		private System.Boolean? _isDefault;
		private System.String _senderid;
		private System.Boolean? _allowNonkeywordMsg;
		private System.String _nonKeywordReply;
		private System.String _invalidKeywordRepy;
		private System.String _ORDERBY_FIELD;
	
		#endregion
	
	
		#region Properties
		public System.Int32? Id
		{
			get
			{
				return _id;
			}
			set
			{
				_id = value;
			}
		}
		
		public System.Int32? Shortcode
		{
			get
			{
				return _shortcode;
			}
			set
			{
				_shortcode = value;
			}
		}
		
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
		
		public System.String Url
		{
			get
			{
				return _url;
			}
			set
			{
				_url = value;
			}
		}
		
		public System.String Ipaddress
		{
			get
			{
				return _ipaddress;
			}
			set
			{
				_ipaddress = value;
			}
		}
		
		public System.String ApiKey
		{
			get
			{
				return _apiKey;
			}
			set
			{
				_apiKey = value;
			}
		}
		
		public System.Int32? Port
		{
			get
			{
				return _port;
			}
			set
			{
				_port = value;
			}
		}
		
		public System.String Prefix
		{
			get
			{
				return _prefix;
			}
			set
			{
				_prefix = value;
			}
		}
		
		public System.String Other1
		{
			get
			{
				return _other1;
			}
			set
			{
				_other1 = value;
			}
		}
		
		public System.String Other2
		{
			get
			{
				return _other2;
			}
			set
			{
				_other2 = value;
			}
		}
		
		public System.Boolean? Originate
		{
			get
			{
				return _originate;
			}
			set
			{
				_originate = value;
			}
		}
		
		public System.Boolean? IsDefault
		{
			get
			{
				return _isDefault;
			}
			set
			{
				_isDefault = value;
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
		
		public System.Boolean? AllowNonkeywordMsg
		{
			get
			{
				return _allowNonkeywordMsg;
			}
			set
			{
				_allowNonkeywordMsg = value;
			}
		}
		
		public System.String NonKeywordReply
		{
			get
			{
				return _nonKeywordReply;
			}
			set
			{
				_nonKeywordReply = value;
			}
		}
		
		public System.String InvalidKeywordRepy
		{
			get
			{
				return _invalidKeywordRepy;
			}
			set
			{
				_invalidKeywordRepy = value;
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
	
			ds.Tables[TABLE_NAME].Columns.Add("ID", typeof(System.Int32) );
			ds.Tables[TABLE_NAME].Columns.Add("shortcode", typeof(System.Int32) );
			ds.Tables[TABLE_NAME].Columns.Add("username", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("password", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("url", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("ipaddress", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("api_key", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("port", typeof(System.Int32) );
			ds.Tables[TABLE_NAME].Columns.Add("prefix", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("other1", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("other2", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("originate", typeof(System.Boolean) );
			ds.Tables[TABLE_NAME].Columns.Add("isDefault", typeof(System.Boolean) );
			ds.Tables[TABLE_NAME].Columns.Add("senderid", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("allow_nonkeyword_msg", typeof(System.Boolean) );
			ds.Tables[TABLE_NAME].Columns.Add("non_keyword_reply", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("invalid_keyword_repy", typeof(System.String) );
	
			dr = ds.Tables[TABLE_NAME].NewRow();
	
			if (Id == null)
				dr["ID"] = DBNull.Value;
			else
				dr["ID"] = Id;
	
			if (Shortcode == null)
				dr["shortcode"] = DBNull.Value;
			else
				dr["shortcode"] = Shortcode;
	
			if (Username == null)
				dr["username"] = DBNull.Value;
			else
				dr["username"] = Username;
	
			if (Password == null)
				dr["password"] = DBNull.Value;
			else
				dr["password"] = Password;
	
			if (Url == null)
				dr["url"] = DBNull.Value;
			else
				dr["url"] = Url;
	
			if (Ipaddress == null)
				dr["ipaddress"] = DBNull.Value;
			else
				dr["ipaddress"] = Ipaddress;
	
			if (ApiKey == null)
				dr["api_key"] = DBNull.Value;
			else
				dr["api_key"] = ApiKey;
	
			if (Port == null)
				dr["port"] = DBNull.Value;
			else
				dr["port"] = Port;
	
			if (Prefix == null)
				dr["prefix"] = DBNull.Value;
			else
				dr["prefix"] = Prefix;
	
			if (Other1 == null)
				dr["other1"] = DBNull.Value;
			else
				dr["other1"] = Other1;
	
			if (Other2 == null)
				dr["other2"] = DBNull.Value;
			else
				dr["other2"] = Other2;
	
			if (Originate == null)
				dr["originate"] = DBNull.Value;
			else
				dr["originate"] = Originate;
	
			if (IsDefault == null)
				dr["isDefault"] = DBNull.Value;
			else
				dr["isDefault"] = IsDefault;
	
			if (Senderid == null)
				dr["senderid"] = DBNull.Value;
			else
				dr["senderid"] = Senderid;
	
			if (AllowNonkeywordMsg == null)
				dr["allow_nonkeyword_msg"] = DBNull.Value;
			else
				dr["allow_nonkeyword_msg"] = AllowNonkeywordMsg;
	
			if (NonKeywordReply == null)
				dr["non_keyword_reply"] = DBNull.Value;
			else
				dr["non_keyword_reply"] = NonKeywordReply;
	
			if (InvalidKeywordRepy == null)
				dr["invalid_keyword_repy"] = DBNull.Value;
			else
				dr["invalid_keyword_repy"] = InvalidKeywordRepy;
	
	
			ds.Tables[TABLE_NAME].Rows.Add(dr);
	
		}
	
		protected void MapFrom(DataRow dr)
		{
			Id = dr["ID"] != DBNull.Value ? Convert.ToInt32(dr["ID"]) : Id = null;
			Shortcode = dr["shortcode"] != DBNull.Value ? Convert.ToInt32(dr["shortcode"]) : Shortcode = null;
			Username = dr["username"] != DBNull.Value ? Convert.ToString(dr["username"]) : Username = null;
			Password = dr["password"] != DBNull.Value ? Convert.ToString(dr["password"]) : Password = null;
			Url = dr["url"] != DBNull.Value ? Convert.ToString(dr["url"]) : Url = null;
			Ipaddress = dr["ipaddress"] != DBNull.Value ? Convert.ToString(dr["ipaddress"]) : Ipaddress = null;
			ApiKey = dr["api_key"] != DBNull.Value ? Convert.ToString(dr["api_key"]) : ApiKey = null;
			Port = dr["port"] != DBNull.Value ? Convert.ToInt32(dr["port"]) : Port = null;
			Prefix = dr["prefix"] != DBNull.Value ? Convert.ToString(dr["prefix"]) : Prefix = null;
			Other1 = dr["other1"] != DBNull.Value ? Convert.ToString(dr["other1"]) : Other1 = null;
			Other2 = dr["other2"] != DBNull.Value ? Convert.ToString(dr["other2"]) : Other2 = null;
			Originate = dr["originate"] != DBNull.Value ? Convert.ToBoolean(dr["originate"]) : Originate = null;
			IsDefault = dr["isDefault"] != DBNull.Value ? Convert.ToBoolean(dr["isDefault"]) : IsDefault = null;
			Senderid = dr["senderid"] != DBNull.Value ? Convert.ToString(dr["senderid"]) : Senderid = null;
			AllowNonkeywordMsg = dr["allow_nonkeyword_msg"] != DBNull.Value ? Convert.ToBoolean(dr["allow_nonkeyword_msg"]) : AllowNonkeywordMsg = null;
			NonKeywordReply = dr["non_keyword_reply"] != DBNull.Value ? Convert.ToString(dr["non_keyword_reply"]) : NonKeywordReply = null;
			InvalidKeywordRepy = dr["invalid_keyword_repy"] != DBNull.Value ? Convert.ToString(dr["invalid_keyword_repy"]) : InvalidKeywordRepy = null;
		}
	
		public static ShortCodeSettings[] MapFrom(DataSet ds)
		{
			List<ShortCodeSettings> objects;
	
	
			// Initialise Collection.
			objects = new List<ShortCodeSettings>();
	
			// Validation.
			if (ds == null)
				throw new ApplicationException("Cannot map to dataset null.");
			else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
				return objects.ToArray();
	
			if (ds.Tables[TABLE_NAME] == null)
				throw new ApplicationException("Cannot find table [dbo].[short_code_settings] in DataSet.");
	
			if (ds.Tables[TABLE_NAME].Rows.Count < 1)
				throw new ApplicationException("Table [dbo].[short_code_settings] is empty.");
	
			// Map DataSet to Instance.
			foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
			{
				ShortCodeSettings instance = new ShortCodeSettings();
				instance.MapFrom(dr);
				objects.Add(instance);
			}
	
			// Return collection.
			return objects.ToArray();
		}
	
	
		#endregion
	
	
		#region CRUD Methods
	
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static ShortCodeSettings Get(System.Int32 id)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
			ShortCodeSettings instance;
	
	
			instance = new ShortCodeSettings();
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].ShortCodeSettings_SELECT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id);
	
			// Get results.
			ds = db.ExecuteDataSet(dbCommand);
			// Verification.
			if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get ShortCodeSettings ID:" + id.ToString()+ " from Database.");
			// Return results.
			ds.Tables[0].TableName = TABLE_NAME;
	
			instance.MapFrom( ds.Tables[0].Rows[0] );
			return instance;
		}
	
		#region INSERT
		public void Insert(System.Int32? shortcode, System.String username, System.String password, System.String url, System.String ipaddress, System.String apiKey, System.Int32? port, System.String prefix, System.String other1, System.String other2, System.Boolean? originate, System.Boolean? isDefault, System.String senderid, System.Boolean? allowNonkeywordMsg, System.String nonKeywordReply, System.String invalidKeywordRepy, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].ShortCodeSettings_INSERT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, shortcode, username, password, url, ipaddress, apiKey, port, prefix, other1, other2, originate, isDefault, senderid, allowNonkeywordMsg, nonKeywordReply, invalidKeywordRepy);
	
			if (transaction == null)
				this.Id = Convert.ToInt32(db.ExecuteScalar(dbCommand));
			else
				this.Id = Convert.ToInt32(db.ExecuteScalar(dbCommand, transaction));
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
		public void Insert(System.Int32? shortcode, System.String username, System.String password, System.String url, System.String ipaddress, System.String apiKey, System.Int32? port, System.String prefix, System.String other1, System.String other2, System.Boolean? originate, System.Boolean? isDefault, System.String senderid, System.Boolean? allowNonkeywordMsg, System.String nonKeywordReply, System.String invalidKeywordRepy)
		{
			Insert(shortcode, username, password, url, ipaddress, apiKey, port, prefix, other1, other2, originate, isDefault, senderid, allowNonkeywordMsg, nonKeywordReply, invalidKeywordRepy, null);
		}
	/// <summary>
	/// Insert current ShortCodeSettings to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Insert(DbTransaction transaction)
		{
			Insert(Shortcode, Username, Password, Url, Ipaddress, ApiKey, Port, Prefix, Other1, Other2, Originate, IsDefault, Senderid, AllowNonkeywordMsg, NonKeywordReply, InvalidKeywordRepy, transaction);
		}
	
	/// <summary>
	/// Insert current ShortCodeSettings to database.
	/// </summary>
		public void Insert()
		{
			this.Insert((DbTransaction)null);
		}
		#endregion
	
	
		#region UPDATE
		public static void Update(System.Int32? id, System.Int32? shortcode, System.String username, System.String password, System.String url, System.String ipaddress, System.String apiKey, System.Int32? port, System.String prefix, System.String other1, System.String other2, System.Boolean? originate, System.Boolean? isDefault, System.String senderid, System.Boolean? allowNonkeywordMsg, System.String nonKeywordReply, System.String invalidKeywordRepy, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].ShortCodeSettings_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@id"].Value = id;
			dbCommand.Parameters["@shortcode"].Value = shortcode;
			dbCommand.Parameters["@username"].Value = username;
			dbCommand.Parameters["@password"].Value = password;
			dbCommand.Parameters["@url"].Value = url;
			dbCommand.Parameters["@ipaddress"].Value = ipaddress;
			dbCommand.Parameters["@apiKey"].Value = apiKey;
			dbCommand.Parameters["@port"].Value = port;
			dbCommand.Parameters["@prefix"].Value = prefix;
			dbCommand.Parameters["@other1"].Value = other1;
			dbCommand.Parameters["@other2"].Value = other2;
			dbCommand.Parameters["@originate"].Value = originate;
			dbCommand.Parameters["@isDefault"].Value = isDefault;
			dbCommand.Parameters["@senderid"].Value = senderid;
			dbCommand.Parameters["@allowNonkeywordMsg"].Value = allowNonkeywordMsg;
			dbCommand.Parameters["@nonKeywordReply"].Value = nonKeywordReply;
			dbCommand.Parameters["@invalidKeywordRepy"].Value = invalidKeywordRepy;
	
			if (transaction == null)
				db.ExecuteNonQuery(dbCommand);
			else
				db.ExecuteNonQuery(dbCommand, transaction);
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
		public static void Update(System.Int32? id, System.Int32? shortcode, System.String username, System.String password, System.String url, System.String ipaddress, System.String apiKey, System.Int32? port, System.String prefix, System.String other1, System.String other2, System.Boolean? originate, System.Boolean? isDefault, System.String senderid, System.Boolean? allowNonkeywordMsg, System.String nonKeywordReply, System.String invalidKeywordRepy)
		{
			Update(id, shortcode, username, password, url, ipaddress, apiKey, port, prefix, other1, other2, originate, isDefault, senderid, allowNonkeywordMsg, nonKeywordReply, invalidKeywordRepy, null);
		}
	
	public static void Update(ShortCodeSettings shortCodeSettings)
	{
	shortCodeSettings.Update();
	}
	
	public static void Update(ShortCodeSettings shortCodeSettings, DbTransaction transaction)
	{
	shortCodeSettings.Update(transaction);
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
			sqlCommand = "[dbo].ShortCodeSettings_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@id"].SourceColumn = "ID";
			dbCommand.Parameters["@shortcode"].SourceColumn = "shortcode";
			dbCommand.Parameters["@username"].SourceColumn = "username";
			dbCommand.Parameters["@password"].SourceColumn = "password";
			dbCommand.Parameters["@url"].SourceColumn = "url";
			dbCommand.Parameters["@ipaddress"].SourceColumn = "ipaddress";
			dbCommand.Parameters["@apiKey"].SourceColumn = "api_key";
			dbCommand.Parameters["@port"].SourceColumn = "port";
			dbCommand.Parameters["@prefix"].SourceColumn = "prefix";
			dbCommand.Parameters["@other1"].SourceColumn = "other1";
			dbCommand.Parameters["@other2"].SourceColumn = "other2";
			dbCommand.Parameters["@originate"].SourceColumn = "originate";
			dbCommand.Parameters["@isDefault"].SourceColumn = "isDefault";
			dbCommand.Parameters["@senderid"].SourceColumn = "senderid";
			dbCommand.Parameters["@allowNonkeywordMsg"].SourceColumn = "allow_nonkeyword_msg";
			dbCommand.Parameters["@nonKeywordReply"].SourceColumn = "non_keyword_reply";
			dbCommand.Parameters["@invalidKeywordRepy"].SourceColumn = "invalid_keyword_repy";
	
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
		public static void Delete(System.Int32? id, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].ShortCodeSettings_DELETE";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id);
	
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
		public static void Delete(System.Int32? id)
	{
	Delete(
	id);
	}
	
	/// <summary>
	/// Delete current ShortCodeSettings from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Delete(DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].ShortCodeSettings_DELETE";
			dbCommand = db.GetStoredProcCommand(sqlCommand, Id);
	
			// Execute.
	if (transaction != null)
	{
		db.ExecuteNonQuery(dbCommand, transaction);
	}
	else
	{
		db.ExecuteNonQuery(dbCommand);
	}
				this.Id = null;
		}
	
	/// <summary>
	/// Delete current ShortCodeSettings from database.
	/// </summary>
		public void Delete()
	{
	this.Delete((DbTransaction)null);
	}
	
		#endregion
	
	
		#region SEARCH
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static ShortCodeSettings[] Search(System.Int32? id, System.Int32? shortcode, System.String username, System.String password, System.String url, System.String ipaddress, System.String apiKey, System.Int32? port, System.String prefix, System.String other1, System.String other2, System.Boolean? originate, System.Boolean? isDefault, System.String senderid, System.Boolean? allowNonkeywordMsg, System.String nonKeywordReply, System.String invalidKeywordRepy, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].ShortCodeSettings_SEARCH";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id, shortcode, username, password, url, ipaddress, apiKey, port, prefix, other1, other2, originate, isDefault, senderid, allowNonkeywordMsg, nonKeywordReply, invalidKeywordRepy, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return ShortCodeSettings.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static ShortCodeSettings[] Search(ShortCodeSettings searchObject)
		{
			return Search ( searchObject.Id, searchObject.Shortcode, searchObject.Username, searchObject.Password, searchObject.Url, searchObject.Ipaddress, searchObject.ApiKey, searchObject.Port, searchObject.Prefix, searchObject.Other1, searchObject.Other2, searchObject.Originate, searchObject.IsDefault, searchObject.Senderid, searchObject.AllowNonkeywordMsg, searchObject.NonKeywordReply, searchObject.InvalidKeywordRepy, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all ShortCodeSettings objects.
		/// </summary>
		/// <returns>List of all ShortCodeSettings objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static ShortCodeSettings[] Search()
		{
			return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region SEARCHEXACT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static ShortCodeSettings[] SearchExact(System.Int32? id, System.Int32? shortcode, System.String username, System.String password, System.String url, System.String ipaddress, System.String apiKey, System.Int32? port, System.String prefix, System.String other1, System.String other2, System.Boolean? originate, System.Boolean? isDefault, System.String senderid, System.Boolean? allowNonkeywordMsg, System.String nonKeywordReply, System.String invalidKeywordRepy, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].ShortCodeSettings_SEARCHEXACT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id, shortcode, username, password, url, ipaddress, apiKey, port, prefix, other1, other2, originate, isDefault, senderid, allowNonkeywordMsg, nonKeywordReply, invalidKeywordRepy, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return ShortCodeSettings.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static ShortCodeSettings[] SearchExact(ShortCodeSettings searchObject)
		{
			return SearchExact ( searchObject.Id, searchObject.Shortcode, searchObject.Username, searchObject.Password, searchObject.Url, searchObject.Ipaddress, searchObject.ApiKey, searchObject.Port, searchObject.Prefix, searchObject.Other1, searchObject.Other2, searchObject.Originate, searchObject.IsDefault, searchObject.Senderid, searchObject.AllowNonkeywordMsg, searchObject.NonKeywordReply, searchObject.InvalidKeywordRepy, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all ShortCodeSettings objects.
		/// </summary>
		/// <returns>List of all ShortCodeSettings objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static ShortCodeSettings[] SearchExact()
		{
			return SearchExact ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region CUSTOMSELECT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static ShortCodeSettings[] CustomSelect(System.String SqlQuery)
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
			return ShortCodeSettings.MapFrom(ds);
	
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
	
