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
/// Data Access Layer Class for the [dbo].[SysEmailFrom] Database Table
/// Business Logic to Access this Class will be in the SysEmailFrom_Bll.cs file
/// All Business Logic should be therefore be Placed in that file
/// </summary>

namespace testingGen
{
	[DataObject]
	[Serializable]
	public partial class SysEmailFrom
	{
	
	
		#region Constants
		private static readonly string TABLE_NAME = "[dbo].[SysEmailFrom]";
	
		#endregion
	
	
		#region Fields
		private System.String _recID;
		private System.String _host;
		private System.String _port;
		private System.String _email;
		private System.String _password;
		private System.String _displayName;
		private System.Boolean? _enSSL;
		private System.Boolean? _defAcc;
		private System.String _ORDERBY_FIELD;
	
		#endregion
	
	
		#region Properties
		public System.String RecID
		{
			get
			{
				return _recID;
			}
			set
			{
				_recID = value;
			}
		}
		
		public System.String Host
		{
			get
			{
				return _host;
			}
			set
			{
				_host = value;
			}
		}
		
		public System.String Port
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
		
		public System.String Email
		{
			get
			{
				return _email;
			}
			set
			{
				_email = value;
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
		
		public System.String DisplayName
		{
			get
			{
				return _displayName;
			}
			set
			{
				_displayName = value;
			}
		}
		
		public System.Boolean? EnSSL
		{
			get
			{
				return _enSSL;
			}
			set
			{
				_enSSL = value;
			}
		}
		
		public System.Boolean? DefAcc
		{
			get
			{
				return _defAcc;
			}
			set
			{
				_defAcc = value;
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
	
			ds.Tables[TABLE_NAME].Columns.Add("RecID", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("Host", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("Port", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("Email", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("Password", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("DisplayName", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("enSSL", typeof(System.Boolean) );
			ds.Tables[TABLE_NAME].Columns.Add("defAcc", typeof(System.Boolean) );
	
			dr = ds.Tables[TABLE_NAME].NewRow();
	
			if (RecID == null)
				dr["RecID"] = DBNull.Value;
			else
				dr["RecID"] = RecID;
	
			if (Host == null)
				dr["Host"] = DBNull.Value;
			else
				dr["Host"] = Host;
	
			if (Port == null)
				dr["Port"] = DBNull.Value;
			else
				dr["Port"] = Port;
	
			if (Email == null)
				dr["Email"] = DBNull.Value;
			else
				dr["Email"] = Email;
	
			if (Password == null)
				dr["Password"] = DBNull.Value;
			else
				dr["Password"] = Password;
	
			if (DisplayName == null)
				dr["DisplayName"] = DBNull.Value;
			else
				dr["DisplayName"] = DisplayName;
	
			if (EnSSL == null)
				dr["enSSL"] = DBNull.Value;
			else
				dr["enSSL"] = EnSSL;
	
			if (DefAcc == null)
				dr["defAcc"] = DBNull.Value;
			else
				dr["defAcc"] = DefAcc;
	
	
			ds.Tables[TABLE_NAME].Rows.Add(dr);
	
		}
	
		protected void MapFrom(DataRow dr)
		{
			RecID = dr["RecID"] != DBNull.Value ? Convert.ToString(dr["RecID"]) : RecID = null;
			Host = dr["Host"] != DBNull.Value ? Convert.ToString(dr["Host"]) : Host = null;
			Port = dr["Port"] != DBNull.Value ? Convert.ToString(dr["Port"]) : Port = null;
			Email = dr["Email"] != DBNull.Value ? Convert.ToString(dr["Email"]) : Email = null;
			Password = dr["Password"] != DBNull.Value ? Convert.ToString(dr["Password"]) : Password = null;
			DisplayName = dr["DisplayName"] != DBNull.Value ? Convert.ToString(dr["DisplayName"]) : DisplayName = null;
			EnSSL = dr["enSSL"] != DBNull.Value ? Convert.ToBoolean(dr["enSSL"]) : EnSSL = null;
			DefAcc = dr["defAcc"] != DBNull.Value ? Convert.ToBoolean(dr["defAcc"]) : DefAcc = null;
		}
	
		public static SysEmailFrom[] MapFrom(DataSet ds)
		{
			List<SysEmailFrom> objects;
	
	
			// Initialise Collection.
			objects = new List<SysEmailFrom>();
	
			// Validation.
			if (ds == null)
				throw new ApplicationException("Cannot map to dataset null.");
			else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
				return objects.ToArray();
	
			if (ds.Tables[TABLE_NAME] == null)
				throw new ApplicationException("Cannot find table [dbo].[SysEmailFrom] in DataSet.");
	
			if (ds.Tables[TABLE_NAME].Rows.Count < 1)
				throw new ApplicationException("Table [dbo].[SysEmailFrom] is empty.");
	
			// Map DataSet to Instance.
			foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
			{
				SysEmailFrom instance = new SysEmailFrom();
				instance.MapFrom(dr);
				objects.Add(instance);
			}
	
			// Return collection.
			return objects.ToArray();
		}
	
	
		#endregion
	
	
		#region CRUD Methods
	
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static SysEmailFrom Get(System.String recID)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
			SysEmailFrom instance;
	
	
			instance = new SysEmailFrom();
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SysEmailFrom_SELECT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, recID);
	
			// Get results.
			ds = db.ExecuteDataSet(dbCommand);
			// Verification.
			if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get SysEmailFrom ID:" + recID.ToString()+ " from Database.");
			// Return results.
			ds.Tables[0].TableName = TABLE_NAME;
	
			instance.MapFrom( ds.Tables[0].Rows[0] );
			return instance;
		}
	
		#region INSERT
		public void Insert(System.String recID, System.String host, System.String port, System.String email, System.String password, System.String displayName, System.Boolean? enSSL, System.Boolean? defAcc, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SysEmailFrom_INSERT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, recID, host, port, email, password, displayName, enSSL, defAcc);
	
			if (transaction == null)
				db.ExecuteScalar(dbCommand);
			else
				db.ExecuteScalar(dbCommand, transaction);
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
		public void Insert(System.String recID, System.String host, System.String port, System.String email, System.String password, System.String displayName, System.Boolean? enSSL, System.Boolean? defAcc)
		{
			Insert(recID, host, port, email, password, displayName, enSSL, defAcc, null);
		}
	/// <summary>
	/// Insert current SysEmailFrom to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Insert(DbTransaction transaction)
		{
			Insert(RecID, Host, Port, Email, Password, DisplayName, EnSSL, DefAcc, transaction);
		}
	
	/// <summary>
	/// Insert current SysEmailFrom to database.
	/// </summary>
		public void Insert()
		{
			this.Insert((DbTransaction)null);
		}
		#endregion
	
	
		#region UPDATE
		public static void Update(System.String recID, System.String host, System.String port, System.String email, System.String password, System.String displayName, System.Boolean? enSSL, System.Boolean? defAcc, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SysEmailFrom_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@recID"].Value = recID;
			dbCommand.Parameters["@host"].Value = host;
			dbCommand.Parameters["@port"].Value = port;
			dbCommand.Parameters["@email"].Value = email;
			dbCommand.Parameters["@password"].Value = password;
			dbCommand.Parameters["@displayName"].Value = displayName;
			dbCommand.Parameters["@enSSL"].Value = enSSL;
			dbCommand.Parameters["@defAcc"].Value = defAcc;
	
			if (transaction == null)
				db.ExecuteNonQuery(dbCommand);
			else
				db.ExecuteNonQuery(dbCommand, transaction);
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
		public static void Update(System.String recID, System.String host, System.String port, System.String email, System.String password, System.String displayName, System.Boolean? enSSL, System.Boolean? defAcc)
		{
			Update(recID, host, port, email, password, displayName, enSSL, defAcc, null);
		}
	
	public static void Update(SysEmailFrom sysEmailFrom)
	{
	sysEmailFrom.Update();
	}
	
	public static void Update(SysEmailFrom sysEmailFrom, DbTransaction transaction)
	{
	sysEmailFrom.Update(transaction);
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
			sqlCommand = "[dbo].SysEmailFrom_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@recID"].SourceColumn = "RecID";
			dbCommand.Parameters["@host"].SourceColumn = "Host";
			dbCommand.Parameters["@port"].SourceColumn = "Port";
			dbCommand.Parameters["@email"].SourceColumn = "Email";
			dbCommand.Parameters["@password"].SourceColumn = "Password";
			dbCommand.Parameters["@displayName"].SourceColumn = "DisplayName";
			dbCommand.Parameters["@enSSL"].SourceColumn = "enSSL";
			dbCommand.Parameters["@defAcc"].SourceColumn = "defAcc";
	
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
		public static void Delete(System.String recID, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SysEmailFrom_DELETE";
			dbCommand = db.GetStoredProcCommand(sqlCommand, recID);
	
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
		public static void Delete(System.String recID)
	{
	Delete(
	recID);
	}
	
	/// <summary>
	/// Delete current SysEmailFrom from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Delete(DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SysEmailFrom_DELETE";
			dbCommand = db.GetStoredProcCommand(sqlCommand, RecID);
	
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
	/// Delete current SysEmailFrom from database.
	/// </summary>
		public void Delete()
	{
	this.Delete((DbTransaction)null);
	}
	
		#endregion
	
	
		#region SEARCH
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static SysEmailFrom[] Search(System.String recID, System.String host, System.String port, System.String email, System.String password, System.String displayName, System.Boolean? enSSL, System.Boolean? defAcc, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SysEmailFrom_SEARCH";
			dbCommand = db.GetStoredProcCommand(sqlCommand, recID, host, port, email, password, displayName, enSSL, defAcc, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return SysEmailFrom.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static SysEmailFrom[] Search(SysEmailFrom searchObject)
		{
			return Search ( searchObject.RecID, searchObject.Host, searchObject.Port, searchObject.Email, searchObject.Password, searchObject.DisplayName, searchObject.EnSSL, searchObject.DefAcc, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all SysEmailFrom objects.
		/// </summary>
		/// <returns>List of all SysEmailFrom objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static SysEmailFrom[] Search()
		{
			return Search ( null, null, null, null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region SEARCHEXACT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static SysEmailFrom[] SearchExact(System.String recID, System.String host, System.String port, System.String email, System.String password, System.String displayName, System.Boolean? enSSL, System.Boolean? defAcc, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SysEmailFrom_SEARCHEXACT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, recID, host, port, email, password, displayName, enSSL, defAcc, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return SysEmailFrom.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static SysEmailFrom[] SearchExact(SysEmailFrom searchObject)
		{
			return SearchExact ( searchObject.RecID, searchObject.Host, searchObject.Port, searchObject.Email, searchObject.Password, searchObject.DisplayName, searchObject.EnSSL, searchObject.DefAcc, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all SysEmailFrom objects.
		/// </summary>
		/// <returns>List of all SysEmailFrom objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static SysEmailFrom[] SearchExact()
		{
			return SearchExact ( null, null, null, null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region CUSTOMSELECT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static SysEmailFrom[] CustomSelect(System.String SqlQuery)
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
			return SysEmailFrom.MapFrom(ds);
	
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
	
