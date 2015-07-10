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
/// Data Access Layer Class for the [dbo].[modifier_details] Database Table
/// Business Logic to Access this Class will be in the ModifierDetails_Bll.cs file
/// All Business Logic should be therefore be Placed in that file
/// </summary>

namespace testingGen
{
	[DataObject]
	[Serializable]
	public partial class ModifierDetails
	{
	
	
		#region Constants
		private static readonly string TABLE_NAME = "[dbo].[modifier_details]";
	
		#endregion
	
	
		#region Fields
		private System.Int32? _id;
		private System.Int32? _modifierId;
		private System.String _name;
		private System.String _action;
		private System.String _details;
		private System.String _status;
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
		
		public System.Int32? ModifierId
		{
			get
			{
				return _modifierId;
			}
			set
			{
				_modifierId = value;
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
		
		public System.String Action
		{
			get
			{
				return _action;
			}
			set
			{
				_action = value;
			}
		}
		
		public System.String Details
		{
			get
			{
				return _details;
			}
			set
			{
				_details = value;
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
			ds.Tables[TABLE_NAME].Columns.Add("Modifier_id", typeof(System.Int32) );
			ds.Tables[TABLE_NAME].Columns.Add("Name", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("Action", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("Details", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("status", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("priority", typeof(System.Int32) );
	
			dr = ds.Tables[TABLE_NAME].NewRow();
	
			if (Id == null)
				dr["ID"] = DBNull.Value;
			else
				dr["ID"] = Id;
	
			if (ModifierId == null)
				dr["Modifier_id"] = DBNull.Value;
			else
				dr["Modifier_id"] = ModifierId;
	
			if (Name == null)
				dr["Name"] = DBNull.Value;
			else
				dr["Name"] = Name;
	
			if (Action == null)
				dr["Action"] = DBNull.Value;
			else
				dr["Action"] = Action;
	
			if (Details == null)
				dr["Details"] = DBNull.Value;
			else
				dr["Details"] = Details;
	
			if (Status == null)
				dr["status"] = DBNull.Value;
			else
				dr["status"] = Status;
	
			if (Priority == null)
				dr["priority"] = DBNull.Value;
			else
				dr["priority"] = Priority;
	
	
			ds.Tables[TABLE_NAME].Rows.Add(dr);
	
		}
	
		protected void MapFrom(DataRow dr)
		{
			Id = dr["ID"] != DBNull.Value ? Convert.ToInt32(dr["ID"]) : Id = null;
			ModifierId = dr["Modifier_id"] != DBNull.Value ? Convert.ToInt32(dr["Modifier_id"]) : ModifierId = null;
			Name = dr["Name"] != DBNull.Value ? Convert.ToString(dr["Name"]) : Name = null;
			Action = dr["Action"] != DBNull.Value ? Convert.ToString(dr["Action"]) : Action = null;
			Details = dr["Details"] != DBNull.Value ? Convert.ToString(dr["Details"]) : Details = null;
			Status = dr["status"] != DBNull.Value ? Convert.ToString(dr["status"]) : Status = null;
			Priority = dr["priority"] != DBNull.Value ? Convert.ToInt32(dr["priority"]) : Priority = null;
		}
	
		public static ModifierDetails[] MapFrom(DataSet ds)
		{
			List<ModifierDetails> objects;
	
	
			// Initialise Collection.
			objects = new List<ModifierDetails>();
	
			// Validation.
			if (ds == null)
				throw new ApplicationException("Cannot map to dataset null.");
			else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
				return objects.ToArray();
	
			if (ds.Tables[TABLE_NAME] == null)
				throw new ApplicationException("Cannot find table [dbo].[modifier_details] in DataSet.");
	
			if (ds.Tables[TABLE_NAME].Rows.Count < 1)
				throw new ApplicationException("Table [dbo].[modifier_details] is empty.");
	
			// Map DataSet to Instance.
			foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
			{
				ModifierDetails instance = new ModifierDetails();
				instance.MapFrom(dr);
				objects.Add(instance);
			}
	
			// Return collection.
			return objects.ToArray();
		}
	
	
		#endregion
	
	
		#region CRUD Methods
	
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static ModifierDetails Get(System.Int32 id)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
			ModifierDetails instance;
	
	
			instance = new ModifierDetails();
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].ModifierDetails_SELECT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id);
	
			// Get results.
			ds = db.ExecuteDataSet(dbCommand);
			// Verification.
			if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get ModifierDetails ID:" + id.ToString()+ " from Database.");
			// Return results.
			ds.Tables[0].TableName = TABLE_NAME;
	
			instance.MapFrom( ds.Tables[0].Rows[0] );
			return instance;
		}
	
		#region INSERT
		public void Insert(System.Int32? modifierId, System.String name, System.String action, System.String details, System.String status, System.Int32? priority, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].ModifierDetails_INSERT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, modifierId, name, action, details, status, priority);
	
			if (transaction == null)
				this.Id = Convert.ToInt32(db.ExecuteScalar(dbCommand));
			else
				this.Id = Convert.ToInt32(db.ExecuteScalar(dbCommand, transaction));
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
		public void Insert(System.Int32? modifierId, System.String name, System.String action, System.String details, System.String status, System.Int32? priority)
		{
			Insert(modifierId, name, action, details, status, priority, null);
		}
	/// <summary>
	/// Insert current ModifierDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Insert(DbTransaction transaction)
		{
			Insert(ModifierId, Name, Action, Details, Status, Priority, transaction);
		}
	
	/// <summary>
	/// Insert current ModifierDetails to database.
	/// </summary>
		public void Insert()
		{
			this.Insert((DbTransaction)null);
		}
		#endregion
	
	
		#region UPDATE
		public static void Update(System.Int32? id, System.Int32? modifierId, System.String name, System.String action, System.String details, System.String status, System.Int32? priority, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].ModifierDetails_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@id"].Value = id;
			dbCommand.Parameters["@modifierId"].Value = modifierId;
			dbCommand.Parameters["@name"].Value = name;
			dbCommand.Parameters["@action"].Value = action;
			dbCommand.Parameters["@details"].Value = details;
			dbCommand.Parameters["@status"].Value = status;
			dbCommand.Parameters["@priority"].Value = priority;
	
			if (transaction == null)
				db.ExecuteNonQuery(dbCommand);
			else
				db.ExecuteNonQuery(dbCommand, transaction);
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
		public static void Update(System.Int32? id, System.Int32? modifierId, System.String name, System.String action, System.String details, System.String status, System.Int32? priority)
		{
			Update(id, modifierId, name, action, details, status, priority, null);
		}
	
	public static void Update(ModifierDetails modifierDetails)
	{
	modifierDetails.Update();
	}
	
	public static void Update(ModifierDetails modifierDetails, DbTransaction transaction)
	{
	modifierDetails.Update(transaction);
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
			sqlCommand = "[dbo].ModifierDetails_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@id"].SourceColumn = "ID";
			dbCommand.Parameters["@modifierId"].SourceColumn = "Modifier_id";
			dbCommand.Parameters["@name"].SourceColumn = "Name";
			dbCommand.Parameters["@action"].SourceColumn = "Action";
			dbCommand.Parameters["@details"].SourceColumn = "Details";
			dbCommand.Parameters["@status"].SourceColumn = "status";
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
			sqlCommand = "[dbo].ModifierDetails_DELETE";
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
	/// Delete current ModifierDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Delete(DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].ModifierDetails_DELETE";
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
	/// Delete current ModifierDetails from database.
	/// </summary>
		public void Delete()
	{
	this.Delete((DbTransaction)null);
	}
	
		#endregion
	
	
		#region SEARCH
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static ModifierDetails[] Search(System.Int32? id, System.Int32? modifierId, System.String name, System.String action, System.String details, System.String status, System.Int32? priority, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].ModifierDetails_SEARCH";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id, modifierId, name, action, details, status, priority, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return ModifierDetails.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static ModifierDetails[] Search(ModifierDetails searchObject)
		{
			return Search ( searchObject.Id, searchObject.ModifierId, searchObject.Name, searchObject.Action, searchObject.Details, searchObject.Status, searchObject.Priority, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all ModifierDetails objects.
		/// </summary>
		/// <returns>List of all ModifierDetails objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static ModifierDetails[] Search()
		{
			return Search ( null, null, null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region SEARCHEXACT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static ModifierDetails[] SearchExact(System.Int32? id, System.Int32? modifierId, System.String name, System.String action, System.String details, System.String status, System.Int32? priority, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].ModifierDetails_SEARCHEXACT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id, modifierId, name, action, details, status, priority, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return ModifierDetails.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static ModifierDetails[] SearchExact(ModifierDetails searchObject)
		{
			return SearchExact ( searchObject.Id, searchObject.ModifierId, searchObject.Name, searchObject.Action, searchObject.Details, searchObject.Status, searchObject.Priority, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all ModifierDetails objects.
		/// </summary>
		/// <returns>List of all ModifierDetails objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static ModifierDetails[] SearchExact()
		{
			return SearchExact ( null, null, null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region CUSTOMSELECT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static ModifierDetails[] CustomSelect(System.String SqlQuery)
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
			return ModifierDetails.MapFrom(ds);
	
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
	
