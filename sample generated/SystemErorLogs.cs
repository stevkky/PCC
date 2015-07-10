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
/// Data Access Layer Class for the [dbo].[SystemErorLogs] Database Table
/// Business Logic to Access this Class will be in the SystemErorLogs_Bll.cs file
/// All Business Logic should be therefore be Placed in that file
/// </summary>

namespace testingGen
{
	[DataObject]
	[Serializable]
	public partial class SystemErorLogs
	{
	
	
		#region Constants
		private static readonly string TABLE_NAME = "[dbo].[SystemErorLogs]";
	
		#endregion
	
	
		#region Fields
		private System.Int32? _eventId;
		private System.DateTime? _logDateTime;
		private System.String _source;
		private System.String _message;
		private System.String _form;
		private System.String _queryString;
		private System.String _targetSite;
		private System.String _stackTrace;
		private System.String _referer;
		private System.String _ORDERBY_FIELD;
	
		#endregion
	
	
		#region Properties
		public System.Int32? EventId
		{
			get
			{
				return _eventId;
			}
			set
			{
				_eventId = value;
			}
		}
		
		public System.DateTime? LogDateTime
		{
			get
			{
				return _logDateTime;
			}
			set
			{
				_logDateTime = value;
			}
		}
		
		public System.String Source
		{
			get
			{
				return _source;
			}
			set
			{
				_source = value;
			}
		}
		
		public System.String Message
		{
			get
			{
				return _message;
			}
			set
			{
				_message = value;
			}
		}
		
		public System.String Form
		{
			get
			{
				return _form;
			}
			set
			{
				_form = value;
			}
		}
		
		public System.String QueryString
		{
			get
			{
				return _queryString;
			}
			set
			{
				_queryString = value;
			}
		}
		
		public System.String TargetSite
		{
			get
			{
				return _targetSite;
			}
			set
			{
				_targetSite = value;
			}
		}
		
		public System.String StackTrace
		{
			get
			{
				return _stackTrace;
			}
			set
			{
				_stackTrace = value;
			}
		}
		
		public System.String Referer
		{
			get
			{
				return _referer;
			}
			set
			{
				_referer = value;
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
	
			ds.Tables[TABLE_NAME].Columns.Add("EventId", typeof(System.Int32) );
			ds.Tables[TABLE_NAME].Columns.Add("LogDateTime", typeof(System.DateTime) );
			ds.Tables[TABLE_NAME].Columns.Add("Source", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("Message", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("Form", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("QueryString", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("TargetSite", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("StackTrace", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("Referer", typeof(System.String) );
	
			dr = ds.Tables[TABLE_NAME].NewRow();
	
			if (EventId == null)
				dr["EventId"] = DBNull.Value;
			else
				dr["EventId"] = EventId;
	
			if (LogDateTime == null)
				dr["LogDateTime"] = DBNull.Value;
			else
				dr["LogDateTime"] = LogDateTime;
	
			if (Source == null)
				dr["Source"] = DBNull.Value;
			else
				dr["Source"] = Source;
	
			if (Message == null)
				dr["Message"] = DBNull.Value;
			else
				dr["Message"] = Message;
	
			if (Form == null)
				dr["Form"] = DBNull.Value;
			else
				dr["Form"] = Form;
	
			if (QueryString == null)
				dr["QueryString"] = DBNull.Value;
			else
				dr["QueryString"] = QueryString;
	
			if (TargetSite == null)
				dr["TargetSite"] = DBNull.Value;
			else
				dr["TargetSite"] = TargetSite;
	
			if (StackTrace == null)
				dr["StackTrace"] = DBNull.Value;
			else
				dr["StackTrace"] = StackTrace;
	
			if (Referer == null)
				dr["Referer"] = DBNull.Value;
			else
				dr["Referer"] = Referer;
	
	
			ds.Tables[TABLE_NAME].Rows.Add(dr);
	
		}
	
		protected void MapFrom(DataRow dr)
		{
			EventId = dr["EventId"] != DBNull.Value ? Convert.ToInt32(dr["EventId"]) : EventId = null;
			LogDateTime = dr["LogDateTime"] != DBNull.Value ? Convert.ToDateTime(dr["LogDateTime"]) : LogDateTime = null;
			Source = dr["Source"] != DBNull.Value ? Convert.ToString(dr["Source"]) : Source = null;
			Message = dr["Message"] != DBNull.Value ? Convert.ToString(dr["Message"]) : Message = null;
			Form = dr["Form"] != DBNull.Value ? Convert.ToString(dr["Form"]) : Form = null;
			QueryString = dr["QueryString"] != DBNull.Value ? Convert.ToString(dr["QueryString"]) : QueryString = null;
			TargetSite = dr["TargetSite"] != DBNull.Value ? Convert.ToString(dr["TargetSite"]) : TargetSite = null;
			StackTrace = dr["StackTrace"] != DBNull.Value ? Convert.ToString(dr["StackTrace"]) : StackTrace = null;
			Referer = dr["Referer"] != DBNull.Value ? Convert.ToString(dr["Referer"]) : Referer = null;
		}
	
		public static SystemErorLogs[] MapFrom(DataSet ds)
		{
			List<SystemErorLogs> objects;
	
	
			// Initialise Collection.
			objects = new List<SystemErorLogs>();
	
			// Validation.
			if (ds == null)
				throw new ApplicationException("Cannot map to dataset null.");
			else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
				return objects.ToArray();
	
			if (ds.Tables[TABLE_NAME] == null)
				throw new ApplicationException("Cannot find table [dbo].[SystemErorLogs] in DataSet.");
	
			if (ds.Tables[TABLE_NAME].Rows.Count < 1)
				throw new ApplicationException("Table [dbo].[SystemErorLogs] is empty.");
	
			// Map DataSet to Instance.
			foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
			{
				SystemErorLogs instance = new SystemErorLogs();
				instance.MapFrom(dr);
				objects.Add(instance);
			}
	
			// Return collection.
			return objects.ToArray();
		}
	
	
		#endregion
	
	
		#region CRUD Methods
	
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static SystemErorLogs Get(System.Int32 eventId)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
			SystemErorLogs instance;
	
	
			instance = new SystemErorLogs();
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SystemErorLogs_SELECT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, eventId);
	
			// Get results.
			ds = db.ExecuteDataSet(dbCommand);
			// Verification.
			if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get SystemErorLogs ID:" + eventId.ToString()+ " from Database.");
			// Return results.
			ds.Tables[0].TableName = TABLE_NAME;
	
			instance.MapFrom( ds.Tables[0].Rows[0] );
			return instance;
		}
	
		#region INSERT
		public void Insert(System.DateTime? logDateTime, System.String source, System.String message, System.String form, System.String queryString, System.String targetSite, System.String stackTrace, System.String referer, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SystemErorLogs_INSERT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, logDateTime, source, message, form, queryString, targetSite, stackTrace, referer);
	
			if (transaction == null)
				this.EventId = Convert.ToInt32(db.ExecuteScalar(dbCommand));
			else
				this.EventId = Convert.ToInt32(db.ExecuteScalar(dbCommand, transaction));
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
		public void Insert(System.DateTime? logDateTime, System.String source, System.String message, System.String form, System.String queryString, System.String targetSite, System.String stackTrace, System.String referer)
		{
			Insert(logDateTime, source, message, form, queryString, targetSite, stackTrace, referer, null);
		}
	/// <summary>
	/// Insert current SystemErorLogs to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Insert(DbTransaction transaction)
		{
			Insert(LogDateTime, Source, Message, Form, QueryString, TargetSite, StackTrace, Referer, transaction);
		}
	
	/// <summary>
	/// Insert current SystemErorLogs to database.
	/// </summary>
		public void Insert()
		{
			this.Insert((DbTransaction)null);
		}
		#endregion
	
	
		#region UPDATE
		public static void Update(System.Int32? eventId, System.DateTime? logDateTime, System.String source, System.String message, System.String form, System.String queryString, System.String targetSite, System.String stackTrace, System.String referer, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SystemErorLogs_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@eventId"].Value = eventId;
			dbCommand.Parameters["@logDateTime"].Value = logDateTime;
			dbCommand.Parameters["@source"].Value = source;
			dbCommand.Parameters["@message"].Value = message;
			dbCommand.Parameters["@form"].Value = form;
			dbCommand.Parameters["@queryString"].Value = queryString;
			dbCommand.Parameters["@targetSite"].Value = targetSite;
			dbCommand.Parameters["@stackTrace"].Value = stackTrace;
			dbCommand.Parameters["@referer"].Value = referer;
	
			if (transaction == null)
				db.ExecuteNonQuery(dbCommand);
			else
				db.ExecuteNonQuery(dbCommand, transaction);
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
		public static void Update(System.Int32? eventId, System.DateTime? logDateTime, System.String source, System.String message, System.String form, System.String queryString, System.String targetSite, System.String stackTrace, System.String referer)
		{
			Update(eventId, logDateTime, source, message, form, queryString, targetSite, stackTrace, referer, null);
		}
	
	public static void Update(SystemErorLogs systemErorLogs)
	{
	systemErorLogs.Update();
	}
	
	public static void Update(SystemErorLogs systemErorLogs, DbTransaction transaction)
	{
	systemErorLogs.Update(transaction);
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
			sqlCommand = "[dbo].SystemErorLogs_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@eventId"].SourceColumn = "EventId";
			dbCommand.Parameters["@logDateTime"].SourceColumn = "LogDateTime";
			dbCommand.Parameters["@source"].SourceColumn = "Source";
			dbCommand.Parameters["@message"].SourceColumn = "Message";
			dbCommand.Parameters["@form"].SourceColumn = "Form";
			dbCommand.Parameters["@queryString"].SourceColumn = "QueryString";
			dbCommand.Parameters["@targetSite"].SourceColumn = "TargetSite";
			dbCommand.Parameters["@stackTrace"].SourceColumn = "StackTrace";
			dbCommand.Parameters["@referer"].SourceColumn = "Referer";
	
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
		public static void Delete(System.Int32? eventId, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SystemErorLogs_DELETE";
			dbCommand = db.GetStoredProcCommand(sqlCommand, eventId);
	
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
		public static void Delete(System.Int32? eventId)
	{
	Delete(
	eventId);
	}
	
	/// <summary>
	/// Delete current SystemErorLogs from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Delete(DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SystemErorLogs_DELETE";
			dbCommand = db.GetStoredProcCommand(sqlCommand, EventId);
	
			// Execute.
	if (transaction != null)
	{
		db.ExecuteNonQuery(dbCommand, transaction);
	}
	else
	{
		db.ExecuteNonQuery(dbCommand);
	}
				this.EventId = null;
		}
	
	/// <summary>
	/// Delete current SystemErorLogs from database.
	/// </summary>
		public void Delete()
	{
	this.Delete((DbTransaction)null);
	}
	
		#endregion
	
	
		#region SEARCH
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static SystemErorLogs[] Search(System.Int32? eventId, System.DateTime? logDateTime, System.String source, System.String message, System.String form, System.String queryString, System.String targetSite, System.String stackTrace, System.String referer, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SystemErorLogs_SEARCH";
			dbCommand = db.GetStoredProcCommand(sqlCommand, eventId, logDateTime, source, message, form, queryString, targetSite, stackTrace, referer, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return SystemErorLogs.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static SystemErorLogs[] Search(SystemErorLogs searchObject)
		{
			return Search ( searchObject.EventId, searchObject.LogDateTime, searchObject.Source, searchObject.Message, searchObject.Form, searchObject.QueryString, searchObject.TargetSite, searchObject.StackTrace, searchObject.Referer, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all SystemErorLogs objects.
		/// </summary>
		/// <returns>List of all SystemErorLogs objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static SystemErorLogs[] Search()
		{
			return Search ( null, null, null, null, null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region SEARCHEXACT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static SystemErorLogs[] SearchExact(System.Int32? eventId, System.DateTime? logDateTime, System.String source, System.String message, System.String form, System.String queryString, System.String targetSite, System.String stackTrace, System.String referer, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SystemErorLogs_SEARCHEXACT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, eventId, logDateTime, source, message, form, queryString, targetSite, stackTrace, referer, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return SystemErorLogs.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static SystemErorLogs[] SearchExact(SystemErorLogs searchObject)
		{
			return SearchExact ( searchObject.EventId, searchObject.LogDateTime, searchObject.Source, searchObject.Message, searchObject.Form, searchObject.QueryString, searchObject.TargetSite, searchObject.StackTrace, searchObject.Referer, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all SystemErorLogs objects.
		/// </summary>
		/// <returns>List of all SystemErorLogs objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static SystemErorLogs[] SearchExact()
		{
			return SearchExact ( null, null, null, null, null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region CUSTOMSELECT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static SystemErorLogs[] CustomSelect(System.String SqlQuery)
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
			return SystemErorLogs.MapFrom(ds);
	
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
	
