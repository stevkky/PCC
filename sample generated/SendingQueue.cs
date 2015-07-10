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
/// Data Access Layer Class for the [dbo].[sending_queue] Database Table
/// Business Logic to Access this Class will be in the SendingQueue_Bll.cs file
/// All Business Logic should be therefore be Placed in that file
/// </summary>

namespace testingGen
{
	[DataObject]
	[Serializable]
	public partial class SendingQueue
	{
	
	
		#region Constants
		private static readonly string TABLE_NAME = "[dbo].[sending_queue]";
	
		#endregion
	
	
		#region Fields
		private System.Int32? _id;
		private System.String _from;
		private System.String _to;
		private System.String _message;
		private System.DateTime? _queueTime;
		private System.String _status;
		private System.Int64? _scheduleId;
		private System.Int32? _modemId;
		private System.Int32? _shortcodeId;
		private System.Int32? _priority;
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
		
		public System.DateTime? QueueTime
		{
			get
			{
				return _queueTime;
			}
			set
			{
				_queueTime = value;
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
		
		public System.Int64? ScheduleId
		{
			get
			{
				return _scheduleId;
			}
			set
			{
				_scheduleId = value;
			}
		}
		
		public System.Int32? ModemId
		{
			get
			{
				return _modemId;
			}
			set
			{
				_modemId = value;
			}
		}
		
		public System.Int32? ShortcodeId
		{
			get
			{
				return _shortcodeId;
			}
			set
			{
				_shortcodeId = value;
			}
		}
		
		public System.Int32? Priority
		{
			get
			{
				return _priority;
			}
			set
			{
				_priority = value;
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
			ds.Tables[TABLE_NAME].Columns.Add("From", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("to", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("Message", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("queue_time", typeof(System.DateTime) );
			ds.Tables[TABLE_NAME].Columns.Add("status", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("schedule_id", typeof(System.Int64) );
			ds.Tables[TABLE_NAME].Columns.Add("modem_id", typeof(System.Int32) );
			ds.Tables[TABLE_NAME].Columns.Add("shortcode_id", typeof(System.Int32) );
			ds.Tables[TABLE_NAME].Columns.Add("priority", typeof(System.Int32) );
	
			dr = ds.Tables[TABLE_NAME].NewRow();
	
			if (Id == null)
				dr["ID"] = DBNull.Value;
			else
				dr["ID"] = Id;
	
			if (From == null)
				dr["From"] = DBNull.Value;
			else
				dr["From"] = From;
	
			if (To == null)
				dr["to"] = DBNull.Value;
			else
				dr["to"] = To;
	
			if (Message == null)
				dr["Message"] = DBNull.Value;
			else
				dr["Message"] = Message;
	
			if (QueueTime == null)
				dr["queue_time"] = DBNull.Value;
			else
				dr["queue_time"] = QueueTime;
	
			if (Status == null)
				dr["status"] = DBNull.Value;
			else
				dr["status"] = Status;
	
			if (ScheduleId == null)
				dr["schedule_id"] = DBNull.Value;
			else
				dr["schedule_id"] = ScheduleId;
	
			if (ModemId == null)
				dr["modem_id"] = DBNull.Value;
			else
				dr["modem_id"] = ModemId;
	
			if (ShortcodeId == null)
				dr["shortcode_id"] = DBNull.Value;
			else
				dr["shortcode_id"] = ShortcodeId;
	
			if (Priority == null)
				dr["priority"] = DBNull.Value;
			else
				dr["priority"] = Priority;
	
	
			ds.Tables[TABLE_NAME].Rows.Add(dr);
	
		}
	
		protected void MapFrom(DataRow dr)
		{
			Id = dr["ID"] != DBNull.Value ? Convert.ToInt32(dr["ID"]) : Id = null;
			From = dr["From"] != DBNull.Value ? Convert.ToString(dr["From"]) : From = null;
			To = dr["to"] != DBNull.Value ? Convert.ToString(dr["to"]) : To = null;
			Message = dr["Message"] != DBNull.Value ? Convert.ToString(dr["Message"]) : Message = null;
			QueueTime = dr["queue_time"] != DBNull.Value ? Convert.ToDateTime(dr["queue_time"]) : QueueTime = null;
			Status = dr["status"] != DBNull.Value ? Convert.ToString(dr["status"]) : Status = null;
			ScheduleId = dr["schedule_id"] != DBNull.Value ? Convert.ToInt64(dr["schedule_id"]) : ScheduleId = null;
			ModemId = dr["modem_id"] != DBNull.Value ? Convert.ToInt32(dr["modem_id"]) : ModemId = null;
			ShortcodeId = dr["shortcode_id"] != DBNull.Value ? Convert.ToInt32(dr["shortcode_id"]) : ShortcodeId = null;
			Priority = dr["priority"] != DBNull.Value ? Convert.ToInt32(dr["priority"]) : Priority = null;
		}
	
		public static SendingQueue[] MapFrom(DataSet ds)
		{
			List<SendingQueue> objects;
	
	
			// Initialise Collection.
			objects = new List<SendingQueue>();
	
			// Validation.
			if (ds == null)
				throw new ApplicationException("Cannot map to dataset null.");
			else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
				return objects.ToArray();
	
			if (ds.Tables[TABLE_NAME] == null)
				throw new ApplicationException("Cannot find table [dbo].[sending_queue] in DataSet.");
	
			if (ds.Tables[TABLE_NAME].Rows.Count < 1)
				throw new ApplicationException("Table [dbo].[sending_queue] is empty.");
	
			// Map DataSet to Instance.
			foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
			{
				SendingQueue instance = new SendingQueue();
				instance.MapFrom(dr);
				objects.Add(instance);
			}
	
			// Return collection.
			return objects.ToArray();
		}
	
	
		#endregion
	
	
		#region CRUD Methods
	
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static SendingQueue Get(System.Int32 id)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
			SendingQueue instance;
	
	
			instance = new SendingQueue();
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SendingQueue_SELECT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id);
	
			// Get results.
			ds = db.ExecuteDataSet(dbCommand);
			// Verification.
			if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get SendingQueue ID:" + id.ToString()+ " from Database.");
			// Return results.
			ds.Tables[0].TableName = TABLE_NAME;
	
			instance.MapFrom( ds.Tables[0].Rows[0] );
			return instance;
		}
	
		#region INSERT
		public void Insert(System.String from, System.String to, System.String message, System.DateTime? queueTime, System.String status, System.Int64? scheduleId, System.Int32? modemId, System.Int32? shortcodeId, System.Int32? priority, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SendingQueue_INSERT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, from, to, message, queueTime, status, scheduleId, modemId, shortcodeId, priority);
	
			if (transaction == null)
				this.Id = Convert.ToInt32(db.ExecuteScalar(dbCommand));
			else
				this.Id = Convert.ToInt32(db.ExecuteScalar(dbCommand, transaction));
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
		public void Insert(System.String from, System.String to, System.String message, System.DateTime? queueTime, System.String status, System.Int64? scheduleId, System.Int32? modemId, System.Int32? shortcodeId, System.Int32? priority)
		{
			Insert(from, to, message, queueTime, status, scheduleId, modemId, shortcodeId, priority, null);
		}
	/// <summary>
	/// Insert current SendingQueue to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Insert(DbTransaction transaction)
		{
			Insert(From, To, Message, QueueTime, Status, ScheduleId, ModemId, ShortcodeId, Priority, transaction);
		}
	
	/// <summary>
	/// Insert current SendingQueue to database.
	/// </summary>
		public void Insert()
		{
			this.Insert((DbTransaction)null);
		}
		#endregion
	
	
		#region UPDATE
		public static void Update(System.Int32? id, System.String from, System.String to, System.String message, System.DateTime? queueTime, System.String status, System.Int64? scheduleId, System.Int32? modemId, System.Int32? shortcodeId, System.Int32? priority, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SendingQueue_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@id"].Value = id;
			dbCommand.Parameters["@from"].Value = from;
			dbCommand.Parameters["@to"].Value = to;
			dbCommand.Parameters["@message"].Value = message;
			dbCommand.Parameters["@queueTime"].Value = queueTime;
			dbCommand.Parameters["@status"].Value = status;
			dbCommand.Parameters["@scheduleId"].Value = scheduleId;
			dbCommand.Parameters["@modemId"].Value = modemId;
			dbCommand.Parameters["@shortcodeId"].Value = shortcodeId;
			dbCommand.Parameters["@priority"].Value = priority;
	
			if (transaction == null)
				db.ExecuteNonQuery(dbCommand);
			else
				db.ExecuteNonQuery(dbCommand, transaction);
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
		public static void Update(System.Int32? id, System.String from, System.String to, System.String message, System.DateTime? queueTime, System.String status, System.Int64? scheduleId, System.Int32? modemId, System.Int32? shortcodeId, System.Int32? priority)
		{
			Update(id, from, to, message, queueTime, status, scheduleId, modemId, shortcodeId, priority, null);
		}
	
	public static void Update(SendingQueue sendingQueue)
	{
	sendingQueue.Update();
	}
	
	public static void Update(SendingQueue sendingQueue, DbTransaction transaction)
	{
	sendingQueue.Update(transaction);
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
			sqlCommand = "[dbo].SendingQueue_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@id"].SourceColumn = "ID";
			dbCommand.Parameters["@from"].SourceColumn = "From";
			dbCommand.Parameters["@to"].SourceColumn = "to";
			dbCommand.Parameters["@message"].SourceColumn = "Message";
			dbCommand.Parameters["@queueTime"].SourceColumn = "queue_time";
			dbCommand.Parameters["@status"].SourceColumn = "status";
			dbCommand.Parameters["@scheduleId"].SourceColumn = "schedule_id";
			dbCommand.Parameters["@modemId"].SourceColumn = "modem_id";
			dbCommand.Parameters["@shortcodeId"].SourceColumn = "shortcode_id";
			dbCommand.Parameters["@priority"].SourceColumn = "priority";
	
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
			sqlCommand = "[dbo].SendingQueue_DELETE";
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
	/// Delete current SendingQueue from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Delete(DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SendingQueue_DELETE";
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
	/// Delete current SendingQueue from database.
	/// </summary>
		public void Delete()
	{
	this.Delete((DbTransaction)null);
	}
	
		#endregion
	
	
		#region SEARCH
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static SendingQueue[] Search(System.Int32? id, System.String from, System.String to, System.String message, System.DateTime? queueTime, System.String status, System.Int64? scheduleId, System.Int32? modemId, System.Int32? shortcodeId, System.Int32? priority, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SendingQueue_SEARCH";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id, from, to, message, queueTime, status, scheduleId, modemId, shortcodeId, priority, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return SendingQueue.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static SendingQueue[] Search(SendingQueue searchObject)
		{
			return Search ( searchObject.Id, searchObject.From, searchObject.To, searchObject.Message, searchObject.QueueTime, searchObject.Status, searchObject.ScheduleId, searchObject.ModemId, searchObject.ShortcodeId, searchObject.Priority, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all SendingQueue objects.
		/// </summary>
		/// <returns>List of all SendingQueue objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static SendingQueue[] Search()
		{
			return Search ( null, null, null, null, null, null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region SEARCHEXACT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static SendingQueue[] SearchExact(System.Int32? id, System.String from, System.String to, System.String message, System.DateTime? queueTime, System.String status, System.Int64? scheduleId, System.Int32? modemId, System.Int32? shortcodeId, System.Int32? priority, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SendingQueue_SEARCHEXACT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id, from, to, message, queueTime, status, scheduleId, modemId, shortcodeId, priority, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return SendingQueue.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static SendingQueue[] SearchExact(SendingQueue searchObject)
		{
			return SearchExact ( searchObject.Id, searchObject.From, searchObject.To, searchObject.Message, searchObject.QueueTime, searchObject.Status, searchObject.ScheduleId, searchObject.ModemId, searchObject.ShortcodeId, searchObject.Priority, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all SendingQueue objects.
		/// </summary>
		/// <returns>List of all SendingQueue objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static SendingQueue[] SearchExact()
		{
			return SearchExact ( null, null, null, null, null, null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region CUSTOMSELECT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static SendingQueue[] CustomSelect(System.String SqlQuery)
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
			return SendingQueue.MapFrom(ds);
	
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
	
