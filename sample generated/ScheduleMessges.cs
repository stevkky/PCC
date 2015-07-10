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
/// Data Access Layer Class for the [dbo].[schedule_messges] Database Table
/// Business Logic to Access this Class will be in the ScheduleMessges_Bll.cs file
/// All Business Logic should be therefore be Placed in that file
/// </summary>

namespace testingGen
{
	[DataObject]
	[Serializable]
	public partial class ScheduleMessges
	{
	
	
		#region Constants
		private static readonly string TABLE_NAME = "[dbo].[schedule_messges]";
	
		#endregion
	
	
		#region Fields
		private System.Int64? _id;
		private System.String _from;
		private System.String _to;
		private System.String _message;
		private System.DateTime? _scheduleTime;
		private System.String _status;
		private System.String _ORDERBY_FIELD;
	
		#endregion
	
	
		#region Properties
		public System.Int64? Id
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
		
		public System.String From
		{
			get
			{
				return _from;
			}
			set
			{
				_from = value;
			}
		}
		
		public System.String To
		{
			get
			{
				return _to;
			}
			set
			{
				_to = value;
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
		
		public System.DateTime? ScheduleTime
		{
			get
			{
				return _scheduleTime;
			}
			set
			{
				_scheduleTime = value;
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
	
			ds.Tables[TABLE_NAME].Columns.Add("ID", typeof(System.Int64) );
			ds.Tables[TABLE_NAME].Columns.Add("from", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("to", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("message", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("schedule_time", typeof(System.DateTime) );
			ds.Tables[TABLE_NAME].Columns.Add("status", typeof(System.String) );
	
			dr = ds.Tables[TABLE_NAME].NewRow();
	
			if (Id == null)
				dr["ID"] = DBNull.Value;
			else
				dr["ID"] = Id;
	
			if (From == null)
				dr["from"] = DBNull.Value;
			else
				dr["from"] = From;
	
			if (To == null)
				dr["to"] = DBNull.Value;
			else
				dr["to"] = To;
	
			if (Message == null)
				dr["message"] = DBNull.Value;
			else
				dr["message"] = Message;
	
			if (ScheduleTime == null)
				dr["schedule_time"] = DBNull.Value;
			else
				dr["schedule_time"] = ScheduleTime;
	
			if (Status == null)
				dr["status"] = DBNull.Value;
			else
				dr["status"] = Status;
	
	
			ds.Tables[TABLE_NAME].Rows.Add(dr);
	
		}
	
		protected void MapFrom(DataRow dr)
		{
			Id = dr["ID"] != DBNull.Value ? Convert.ToInt64(dr["ID"]) : Id = null;
			From = dr["from"] != DBNull.Value ? Convert.ToString(dr["from"]) : From = null;
			To = dr["to"] != DBNull.Value ? Convert.ToString(dr["to"]) : To = null;
			Message = dr["message"] != DBNull.Value ? Convert.ToString(dr["message"]) : Message = null;
			ScheduleTime = dr["schedule_time"] != DBNull.Value ? Convert.ToDateTime(dr["schedule_time"]) : ScheduleTime = null;
			Status = dr["status"] != DBNull.Value ? Convert.ToString(dr["status"]) : Status = null;
		}
	
		public static ScheduleMessges[] MapFrom(DataSet ds)
		{
			List<ScheduleMessges> objects;
	
	
			// Initialise Collection.
			objects = new List<ScheduleMessges>();
	
			// Validation.
			if (ds == null)
				throw new ApplicationException("Cannot map to dataset null.");
			else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
				return objects.ToArray();
	
			if (ds.Tables[TABLE_NAME] == null)
				throw new ApplicationException("Cannot find table [dbo].[schedule_messges] in DataSet.");
	
			if (ds.Tables[TABLE_NAME].Rows.Count < 1)
				throw new ApplicationException("Table [dbo].[schedule_messges] is empty.");
	
			// Map DataSet to Instance.
			foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
			{
				ScheduleMessges instance = new ScheduleMessges();
				instance.MapFrom(dr);
				objects.Add(instance);
			}
	
			// Return collection.
			return objects.ToArray();
		}
	
	
		#endregion
	
	
		#region CRUD Methods
	
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static ScheduleMessges Get(System.Int64 id)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
			ScheduleMessges instance;
	
	
			instance = new ScheduleMessges();
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].ScheduleMessges_SELECT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id);
	
			// Get results.
			ds = db.ExecuteDataSet(dbCommand);
			// Verification.
			if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get ScheduleMessges ID:" + id.ToString()+ " from Database.");
			// Return results.
			ds.Tables[0].TableName = TABLE_NAME;
	
			instance.MapFrom( ds.Tables[0].Rows[0] );
			return instance;
		}
	
		#region INSERT
		public void Insert(System.String from, System.String to, System.String message, System.DateTime? scheduleTime, System.String status, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].ScheduleMessges_INSERT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, from, to, message, scheduleTime, status);
	
			if (transaction == null)
				this.Id = Convert.ToInt64(db.ExecuteScalar(dbCommand));
			else
				this.Id = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
		public void Insert(System.String from, System.String to, System.String message, System.DateTime? scheduleTime, System.String status)
		{
			Insert(from, to, message, scheduleTime, status, null);
		}
	/// <summary>
	/// Insert current ScheduleMessges to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Insert(DbTransaction transaction)
		{
			Insert(From, To, Message, ScheduleTime, Status, transaction);
		}
	
	/// <summary>
	/// Insert current ScheduleMessges to database.
	/// </summary>
		public void Insert()
		{
			this.Insert((DbTransaction)null);
		}
		#endregion
	
	
		#region UPDATE
		public static void Update(System.Int64? id, System.String from, System.String to, System.String message, System.DateTime? scheduleTime, System.String status, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].ScheduleMessges_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@id"].Value = id;
			dbCommand.Parameters["@from"].Value = from;
			dbCommand.Parameters["@to"].Value = to;
			dbCommand.Parameters["@message"].Value = message;
			dbCommand.Parameters["@scheduleTime"].Value = scheduleTime;
			dbCommand.Parameters["@status"].Value = status;
	
			if (transaction == null)
				db.ExecuteNonQuery(dbCommand);
			else
				db.ExecuteNonQuery(dbCommand, transaction);
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
		public static void Update(System.Int64? id, System.String from, System.String to, System.String message, System.DateTime? scheduleTime, System.String status)
		{
			Update(id, from, to, message, scheduleTime, status, null);
		}
	
	public static void Update(ScheduleMessges scheduleMessges)
	{
	scheduleMessges.Update();
	}
	
	public static void Update(ScheduleMessges scheduleMessges, DbTransaction transaction)
	{
	scheduleMessges.Update(transaction);
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
			sqlCommand = "[dbo].ScheduleMessges_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@id"].SourceColumn = "ID";
			dbCommand.Parameters["@from"].SourceColumn = "from";
			dbCommand.Parameters["@to"].SourceColumn = "to";
			dbCommand.Parameters["@message"].SourceColumn = "message";
			dbCommand.Parameters["@scheduleTime"].SourceColumn = "schedule_time";
			dbCommand.Parameters["@status"].SourceColumn = "status";
	
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
		public static void Delete(System.Int64? id, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].ScheduleMessges_DELETE";
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
		public static void Delete(System.Int64? id)
	{
	Delete(
	id);
	}
	
	/// <summary>
	/// Delete current ScheduleMessges from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Delete(DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].ScheduleMessges_DELETE";
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
	/// Delete current ScheduleMessges from database.
	/// </summary>
		public void Delete()
	{
	this.Delete((DbTransaction)null);
	}
	
		#endregion
	
	
		#region SEARCH
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static ScheduleMessges[] Search(System.Int64? id, System.String from, System.String to, System.String message, System.DateTime? scheduleTime, System.String status, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].ScheduleMessges_SEARCH";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id, from, to, message, scheduleTime, status, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return ScheduleMessges.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static ScheduleMessges[] Search(ScheduleMessges searchObject)
		{
			return Search ( searchObject.Id, searchObject.From, searchObject.To, searchObject.Message, searchObject.ScheduleTime, searchObject.Status, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all ScheduleMessges objects.
		/// </summary>
		/// <returns>List of all ScheduleMessges objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static ScheduleMessges[] Search()
		{
			return Search ( null, null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region SEARCHEXACT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static ScheduleMessges[] SearchExact(System.Int64? id, System.String from, System.String to, System.String message, System.DateTime? scheduleTime, System.String status, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].ScheduleMessges_SEARCHEXACT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id, from, to, message, scheduleTime, status, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return ScheduleMessges.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static ScheduleMessges[] SearchExact(ScheduleMessges searchObject)
		{
			return SearchExact ( searchObject.Id, searchObject.From, searchObject.To, searchObject.Message, searchObject.ScheduleTime, searchObject.Status, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all ScheduleMessges objects.
		/// </summary>
		/// <returns>List of all ScheduleMessges objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static ScheduleMessges[] SearchExact()
		{
			return SearchExact ( null, null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region CUSTOMSELECT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static ScheduleMessges[] CustomSelect(System.String SqlQuery)
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
			return ScheduleMessges.MapFrom(ds);
	
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
	
