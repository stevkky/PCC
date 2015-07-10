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
/// Data Access Layer Class for the [dbo].[modem_settings] Database Table
/// Business Logic to Access this Class will be in the ModemSettings_Bll.cs file
/// All Business Logic should be therefore be Placed in that file
/// </summary>

namespace testingGen
{
	[DataObject]
	[Serializable]
	public partial class ModemSettings
	{
	
	
		#region Constants
		private static readonly string TABLE_NAME = "[dbo].[modem_settings]";
	
		#endregion
	
	
		#region Fields
		private System.Int32? _id;
		private System.Int32? _comport;
		private System.Int32? _rate;
		private System.Int32? _timeout;
		private System.Boolean? _status;
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
		
		public System.Int32? Comport
		{
			get
			{
				return _comport;
			}
			set
			{
				_comport = value;
			}
		}
		
		public System.Int32? Rate
		{
			get
			{
				return _rate;
			}
			set
			{
				_rate = value;
			}
		}
		
		public System.Int32? Timeout
		{
			get
			{
				return _timeout;
			}
			set
			{
				_timeout = value;
			}
		}
		
		public System.Boolean? Status
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
	
			ds.Tables[TABLE_NAME].Columns.Add("ID", typeof(System.Int32) );
			ds.Tables[TABLE_NAME].Columns.Add("comport", typeof(System.Int32) );
			ds.Tables[TABLE_NAME].Columns.Add("rate", typeof(System.Int32) );
			ds.Tables[TABLE_NAME].Columns.Add("timeout", typeof(System.Int32) );
			ds.Tables[TABLE_NAME].Columns.Add("status", typeof(System.Boolean) );
	
			dr = ds.Tables[TABLE_NAME].NewRow();
	
			if (Id == null)
				dr["ID"] = DBNull.Value;
			else
				dr["ID"] = Id;
	
			if (Comport == null)
				dr["comport"] = DBNull.Value;
			else
				dr["comport"] = Comport;
	
			if (Rate == null)
				dr["rate"] = DBNull.Value;
			else
				dr["rate"] = Rate;
	
			if (Timeout == null)
				dr["timeout"] = DBNull.Value;
			else
				dr["timeout"] = Timeout;
	
			if (Status == null)
				dr["status"] = DBNull.Value;
			else
				dr["status"] = Status;
	
	
			ds.Tables[TABLE_NAME].Rows.Add(dr);
	
		}
	
		protected void MapFrom(DataRow dr)
		{
			Id = dr["ID"] != DBNull.Value ? Convert.ToInt32(dr["ID"]) : Id = null;
			Comport = dr["comport"] != DBNull.Value ? Convert.ToInt32(dr["comport"]) : Comport = null;
			Rate = dr["rate"] != DBNull.Value ? Convert.ToInt32(dr["rate"]) : Rate = null;
			Timeout = dr["timeout"] != DBNull.Value ? Convert.ToInt32(dr["timeout"]) : Timeout = null;
			Status = dr["status"] != DBNull.Value ? Convert.ToBoolean(dr["status"]) : Status = null;
		}
	
		public static ModemSettings[] MapFrom(DataSet ds)
		{
			List<ModemSettings> objects;
	
	
			// Initialise Collection.
			objects = new List<ModemSettings>();
	
			// Validation.
			if (ds == null)
				throw new ApplicationException("Cannot map to dataset null.");
			else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
				return objects.ToArray();
	
			if (ds.Tables[TABLE_NAME] == null)
				throw new ApplicationException("Cannot find table [dbo].[modem_settings] in DataSet.");
	
			if (ds.Tables[TABLE_NAME].Rows.Count < 1)
				throw new ApplicationException("Table [dbo].[modem_settings] is empty.");
	
			// Map DataSet to Instance.
			foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
			{
				ModemSettings instance = new ModemSettings();
				instance.MapFrom(dr);
				objects.Add(instance);
			}
	
			// Return collection.
			return objects.ToArray();
		}
	
	
		#endregion
	
	
		#region CRUD Methods
	
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static ModemSettings Get(System.Int32 id)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
			ModemSettings instance;
	
	
			instance = new ModemSettings();
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].ModemSettings_SELECT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id);
	
			// Get results.
			ds = db.ExecuteDataSet(dbCommand);
			// Verification.
			if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get ModemSettings ID:" + id.ToString()+ " from Database.");
			// Return results.
			ds.Tables[0].TableName = TABLE_NAME;
	
			instance.MapFrom( ds.Tables[0].Rows[0] );
			return instance;
		}
	
		#region INSERT
		public void Insert(System.Int32? comport, System.Int32? rate, System.Int32? timeout, System.Boolean? status, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].ModemSettings_INSERT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, comport, rate, timeout, status);
	
			if (transaction == null)
				this.Id = Convert.ToInt32(db.ExecuteScalar(dbCommand));
			else
				this.Id = Convert.ToInt32(db.ExecuteScalar(dbCommand, transaction));
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
		public void Insert(System.Int32? comport, System.Int32? rate, System.Int32? timeout, System.Boolean? status)
		{
			Insert(comport, rate, timeout, status, null);
		}
	/// <summary>
	/// Insert current ModemSettings to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Insert(DbTransaction transaction)
		{
			Insert(Comport, Rate, Timeout, Status, transaction);
		}
	
	/// <summary>
	/// Insert current ModemSettings to database.
	/// </summary>
		public void Insert()
		{
			this.Insert((DbTransaction)null);
		}
		#endregion
	
	
		#region UPDATE
		public static void Update(System.Int32? id, System.Int32? comport, System.Int32? rate, System.Int32? timeout, System.Boolean? status, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].ModemSettings_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@id"].Value = id;
			dbCommand.Parameters["@comport"].Value = comport;
			dbCommand.Parameters["@rate"].Value = rate;
			dbCommand.Parameters["@timeout"].Value = timeout;
			dbCommand.Parameters["@status"].Value = status;
	
			if (transaction == null)
				db.ExecuteNonQuery(dbCommand);
			else
				db.ExecuteNonQuery(dbCommand, transaction);
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
		public static void Update(System.Int32? id, System.Int32? comport, System.Int32? rate, System.Int32? timeout, System.Boolean? status)
		{
			Update(id, comport, rate, timeout, status, null);
		}
	
	public static void Update(ModemSettings modemSettings)
	{
	modemSettings.Update();
	}
	
	public static void Update(ModemSettings modemSettings, DbTransaction transaction)
	{
	modemSettings.Update(transaction);
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
			sqlCommand = "[dbo].ModemSettings_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@id"].SourceColumn = "ID";
			dbCommand.Parameters["@comport"].SourceColumn = "comport";
			dbCommand.Parameters["@rate"].SourceColumn = "rate";
			dbCommand.Parameters["@timeout"].SourceColumn = "timeout";
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
		public static void Delete(System.Int32? id, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].ModemSettings_DELETE";
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
	/// Delete current ModemSettings from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Delete(DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].ModemSettings_DELETE";
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
	/// Delete current ModemSettings from database.
	/// </summary>
		public void Delete()
	{
	this.Delete((DbTransaction)null);
	}
	
		#endregion
	
	
		#region SEARCH
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static ModemSettings[] Search(System.Int32? id, System.Int32? comport, System.Int32? rate, System.Int32? timeout, System.Boolean? status, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].ModemSettings_SEARCH";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id, comport, rate, timeout, status, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return ModemSettings.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static ModemSettings[] Search(ModemSettings searchObject)
		{
			return Search ( searchObject.Id, searchObject.Comport, searchObject.Rate, searchObject.Timeout, searchObject.Status, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all ModemSettings objects.
		/// </summary>
		/// <returns>List of all ModemSettings objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static ModemSettings[] Search()
		{
			return Search ( null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region SEARCHEXACT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static ModemSettings[] SearchExact(System.Int32? id, System.Int32? comport, System.Int32? rate, System.Int32? timeout, System.Boolean? status, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].ModemSettings_SEARCHEXACT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id, comport, rate, timeout, status, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return ModemSettings.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static ModemSettings[] SearchExact(ModemSettings searchObject)
		{
			return SearchExact ( searchObject.Id, searchObject.Comport, searchObject.Rate, searchObject.Timeout, searchObject.Status, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all ModemSettings objects.
		/// </summary>
		/// <returns>List of all ModemSettings objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static ModemSettings[] SearchExact()
		{
			return SearchExact ( null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region CUSTOMSELECT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static ModemSettings[] CustomSelect(System.String SqlQuery)
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
			return ModemSettings.MapFrom(ds);
	
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
	
