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
/// Data Access Layer Class for the [dbo].[sent] Database Table
/// Business Logic to Access this Class will be in the Sent_Bll.cs file
/// All Business Logic should be therefore be Placed in that file
/// </summary>

namespace testingGen
{
	[DataObject]
	[Serializable]
	public partial class Sent
	{
	
	
		#region Constants
		private static readonly string TABLE_NAME = "[dbo].[sent]";
	
		#endregion
	
	
		#region Fields
		private System.Int32? _id;
		private System.String _from;
		private System.String _to;
		private System.String _message;
		private System.DateTime? _queueTime;
		private System.Int32? _modemId;
		private System.Int32? _shortcodeId;
		private System.Int64? _scheduleId;
		private System.Int64? _inboxId;
		private System.DateTime? _recordedTime;
		private System.String _senderid;
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
		
		public System.Int64? InboxId
		{
			get
			{
				return _inboxId;
			}
			set
			{
				_inboxId = value;
			}
		}
		
		public System.DateTime? RecordedTime
		{
			get
			{
				return _recordedTime;
			}
			set
			{
				_recordedTime = value;
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
	
			ds.Tables[TABLE_NAME].Columns.Add("ID", typeof(System.Int32) );
			ds.Tables[TABLE_NAME].Columns.Add("From", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("to", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("Message", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("queue_time", typeof(System.DateTime) );
			ds.Tables[TABLE_NAME].Columns.Add("modem_id", typeof(System.Int32) );
			ds.Tables[TABLE_NAME].Columns.Add("shortcode_id", typeof(System.Int32) );
			ds.Tables[TABLE_NAME].Columns.Add("schedule_id", typeof(System.Int64) );
			ds.Tables[TABLE_NAME].Columns.Add("inbox_id", typeof(System.Int64) );
			ds.Tables[TABLE_NAME].Columns.Add("recorded_time", typeof(System.DateTime) );
			ds.Tables[TABLE_NAME].Columns.Add("senderid", typeof(System.String) );
	
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
	
			if (ModemId == null)
				dr["modem_id"] = DBNull.Value;
			else
				dr["modem_id"] = ModemId;
	
			if (ShortcodeId == null)
				dr["shortcode_id"] = DBNull.Value;
			else
				dr["shortcode_id"] = ShortcodeId;
	
			if (ScheduleId == null)
				dr["schedule_id"] = DBNull.Value;
			else
				dr["schedule_id"] = ScheduleId;
	
			if (InboxId == null)
				dr["inbox_id"] = DBNull.Value;
			else
				dr["inbox_id"] = InboxId;
	
			if (RecordedTime == null)
				dr["recorded_time"] = DBNull.Value;
			else
				dr["recorded_time"] = RecordedTime;
	
			if (Senderid == null)
				dr["senderid"] = DBNull.Value;
			else
				dr["senderid"] = Senderid;
	
	
			ds.Tables[TABLE_NAME].Rows.Add(dr);
	
		}
	
		protected void MapFrom(DataRow dr)
		{
			Id = dr["ID"] != DBNull.Value ? Convert.ToInt32(dr["ID"]) : Id = null;
			From = dr["From"] != DBNull.Value ? Convert.ToString(dr["From"]) : From = null;
			To = dr["to"] != DBNull.Value ? Convert.ToString(dr["to"]) : To = null;
			Message = dr["Message"] != DBNull.Value ? Convert.ToString(dr["Message"]) : Message = null;
			QueueTime = dr["queue_time"] != DBNull.Value ? Convert.ToDateTime(dr["queue_time"]) : QueueTime = null;
			ModemId = dr["modem_id"] != DBNull.Value ? Convert.ToInt32(dr["modem_id"]) : ModemId = null;
			ShortcodeId = dr["shortcode_id"] != DBNull.Value ? Convert.ToInt32(dr["shortcode_id"]) : ShortcodeId = null;
			ScheduleId = dr["schedule_id"] != DBNull.Value ? Convert.ToInt64(dr["schedule_id"]) : ScheduleId = null;
			InboxId = dr["inbox_id"] != DBNull.Value ? Convert.ToInt64(dr["inbox_id"]) : InboxId = null;
			RecordedTime = dr["recorded_time"] != DBNull.Value ? Convert.ToDateTime(dr["recorded_time"]) : RecordedTime = null;
			Senderid = dr["senderid"] != DBNull.Value ? Convert.ToString(dr["senderid"]) : Senderid = null;
		}
	
		public static Sent[] MapFrom(DataSet ds)
		{
			List<Sent> objects;
	
	
			// Initialise Collection.
			objects = new List<Sent>();
	
			// Validation.
			if (ds == null)
				throw new ApplicationException("Cannot map to dataset null.");
			else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
				return objects.ToArray();
	
			if (ds.Tables[TABLE_NAME] == null)
				throw new ApplicationException("Cannot find table [dbo].[sent] in DataSet.");
	
			if (ds.Tables[TABLE_NAME].Rows.Count < 1)
				throw new ApplicationException("Table [dbo].[sent] is empty.");
	
			// Map DataSet to Instance.
			foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
			{
				Sent instance = new Sent();
				instance.MapFrom(dr);
				objects.Add(instance);
			}
	
			// Return collection.
			return objects.ToArray();
		}
	
	
		#endregion
	
	
		#region CRUD Methods
	
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Sent Get(System.Int32 id)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
			Sent instance;
	
	
			instance = new Sent();
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Sent_SELECT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id);
	
			// Get results.
			ds = db.ExecuteDataSet(dbCommand);
			// Verification.
			if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get Sent ID:" + id.ToString()+ " from Database.");
			// Return results.
			ds.Tables[0].TableName = TABLE_NAME;
	
			instance.MapFrom( ds.Tables[0].Rows[0] );
			return instance;
		}
	
		#region INSERT
		public void Insert(System.String from, System.String to, System.String message, System.DateTime? queueTime, System.Int32? modemId, System.Int32? shortcodeId, System.Int64? scheduleId, System.Int64? inboxId, System.DateTime? recordedTime, System.String senderid, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Sent_INSERT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, from, to, message, queueTime, modemId, shortcodeId, scheduleId, inboxId, recordedTime, senderid);
	
			if (transaction == null)
				this.Id = Convert.ToInt32(db.ExecuteScalar(dbCommand));
			else
				this.Id = Convert.ToInt32(db.ExecuteScalar(dbCommand, transaction));
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
		public void Insert(System.String from, System.String to, System.String message, System.DateTime? queueTime, System.Int32? modemId, System.Int32? shortcodeId, System.Int64? scheduleId, System.Int64? inboxId, System.DateTime? recordedTime, System.String senderid)
		{
			Insert(from, to, message, queueTime, modemId, shortcodeId, scheduleId, inboxId, recordedTime, senderid, null);
		}
	/// <summary>
	/// Insert current Sent to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Insert(DbTransaction transaction)
		{
			Insert(From, To, Message, QueueTime, ModemId, ShortcodeId, ScheduleId, InboxId, RecordedTime, Senderid, transaction);
		}
	
	/// <summary>
	/// Insert current Sent to database.
	/// </summary>
		public void Insert()
		{
			this.Insert((DbTransaction)null);
		}
		#endregion
	
	
		#region UPDATE
		public static void Update(System.Int32? id, System.String from, System.String to, System.String message, System.DateTime? queueTime, System.Int32? modemId, System.Int32? shortcodeId, System.Int64? scheduleId, System.Int64? inboxId, System.DateTime? recordedTime, System.String senderid, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Sent_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@id"].Value = id;
			dbCommand.Parameters["@from"].Value = from;
			dbCommand.Parameters["@to"].Value = to;
			dbCommand.Parameters["@message"].Value = message;
			dbCommand.Parameters["@queueTime"].Value = queueTime;
			dbCommand.Parameters["@modemId"].Value = modemId;
			dbCommand.Parameters["@shortcodeId"].Value = shortcodeId;
			dbCommand.Parameters["@scheduleId"].Value = scheduleId;
			dbCommand.Parameters["@inboxId"].Value = inboxId;
			dbCommand.Parameters["@recordedTime"].Value = recordedTime;
			dbCommand.Parameters["@senderid"].Value = senderid;
	
			if (transaction == null)
				db.ExecuteNonQuery(dbCommand);
			else
				db.ExecuteNonQuery(dbCommand, transaction);
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
		public static void Update(System.Int32? id, System.String from, System.String to, System.String message, System.DateTime? queueTime, System.Int32? modemId, System.Int32? shortcodeId, System.Int64? scheduleId, System.Int64? inboxId, System.DateTime? recordedTime, System.String senderid)
		{
			Update(id, from, to, message, queueTime, modemId, shortcodeId, scheduleId, inboxId, recordedTime, senderid, null);
		}
	
	public static void Update(Sent sent)
	{
	sent.Update();
	}
	
	public static void Update(Sent sent, DbTransaction transaction)
	{
	sent.Update(transaction);
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
			sqlCommand = "[dbo].Sent_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@id"].SourceColumn = "ID";
			dbCommand.Parameters["@from"].SourceColumn = "From";
			dbCommand.Parameters["@to"].SourceColumn = "to";
			dbCommand.Parameters["@message"].SourceColumn = "Message";
			dbCommand.Parameters["@queueTime"].SourceColumn = "queue_time";
			dbCommand.Parameters["@modemId"].SourceColumn = "modem_id";
			dbCommand.Parameters["@shortcodeId"].SourceColumn = "shortcode_id";
			dbCommand.Parameters["@scheduleId"].SourceColumn = "schedule_id";
			dbCommand.Parameters["@inboxId"].SourceColumn = "inbox_id";
			dbCommand.Parameters["@recordedTime"].SourceColumn = "recorded_time";
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
		public static void Delete(System.Int32? id, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Sent_DELETE";
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
	/// Delete current Sent from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Delete(DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Sent_DELETE";
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
	/// Delete current Sent from database.
	/// </summary>
		public void Delete()
	{
	this.Delete((DbTransaction)null);
	}
	
		#endregion
	
	
		#region SEARCH
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Sent[] Search(System.Int32? id, System.String from, System.String to, System.String message, System.DateTime? queueTime, System.Int32? modemId, System.Int32? shortcodeId, System.Int64? scheduleId, System.Int64? inboxId, System.DateTime? recordedTime, System.String senderid, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Sent_SEARCH";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id, from, to, message, queueTime, modemId, shortcodeId, scheduleId, inboxId, recordedTime, senderid, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return Sent.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static Sent[] Search(Sent searchObject)
		{
			return Search ( searchObject.Id, searchObject.From, searchObject.To, searchObject.Message, searchObject.QueueTime, searchObject.ModemId, searchObject.ShortcodeId, searchObject.ScheduleId, searchObject.InboxId, searchObject.RecordedTime, searchObject.Senderid, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all Sent objects.
		/// </summary>
		/// <returns>List of all Sent objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static Sent[] Search()
		{
			return Search ( null, null, null, null, null, null, null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region SEARCHEXACT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Sent[] SearchExact(System.Int32? id, System.String from, System.String to, System.String message, System.DateTime? queueTime, System.Int32? modemId, System.Int32? shortcodeId, System.Int64? scheduleId, System.Int64? inboxId, System.DateTime? recordedTime, System.String senderid, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Sent_SEARCHEXACT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id, from, to, message, queueTime, modemId, shortcodeId, scheduleId, inboxId, recordedTime, senderid, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return Sent.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static Sent[] SearchExact(Sent searchObject)
		{
			return SearchExact ( searchObject.Id, searchObject.From, searchObject.To, searchObject.Message, searchObject.QueueTime, searchObject.ModemId, searchObject.ShortcodeId, searchObject.ScheduleId, searchObject.InboxId, searchObject.RecordedTime, searchObject.Senderid, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all Sent objects.
		/// </summary>
		/// <returns>List of all Sent objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static Sent[] SearchExact()
		{
			return SearchExact ( null, null, null, null, null, null, null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region CUSTOMSELECT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Sent[] CustomSelect(System.String SqlQuery)
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
			return Sent.MapFrom(ds);
	
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
	
