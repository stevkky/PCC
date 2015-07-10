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
/// Data Access Layer Class for the [dbo].[help] Database Table
/// Business Logic to Access this Class will be in the Help_Bll.cs file
/// All Business Logic should be therefore be Placed in that file
/// </summary>

namespace testingGen
{
	[DataObject]
	[Serializable]
	public partial class Help
	{
	
	
		#region Constants
		private static readonly string TABLE_NAME = "[dbo].[help]";
	
		#endregion
	
	
		#region Fields
		private System.Int32? _id;
		private System.String _keyword;
		private System.String _message;
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
		
		public System.String Keyword
		{
			get
			{
				return _keyword;
			}
			set
			{
				_keyword = value;
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
	
			ds.Tables[TABLE_NAME].Columns.Add("id", typeof(System.Int32) );
			ds.Tables[TABLE_NAME].Columns.Add("keyword", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("message", typeof(System.String) );
	
			dr = ds.Tables[TABLE_NAME].NewRow();
	
			if (Id == null)
				dr["id"] = DBNull.Value;
			else
				dr["id"] = Id;
	
			if (Keyword == null)
				dr["keyword"] = DBNull.Value;
			else
				dr["keyword"] = Keyword;
	
			if (Message == null)
				dr["message"] = DBNull.Value;
			else
				dr["message"] = Message;
	
	
			ds.Tables[TABLE_NAME].Rows.Add(dr);
	
		}
	
		protected void MapFrom(DataRow dr)
		{
			Id = dr["id"] != DBNull.Value ? Convert.ToInt32(dr["id"]) : Id = null;
			Keyword = dr["keyword"] != DBNull.Value ? Convert.ToString(dr["keyword"]) : Keyword = null;
			Message = dr["message"] != DBNull.Value ? Convert.ToString(dr["message"]) : Message = null;
		}
	
		public static Help[] MapFrom(DataSet ds)
		{
			List<Help> objects;
	
	
			// Initialise Collection.
			objects = new List<Help>();
	
			// Validation.
			if (ds == null)
				throw new ApplicationException("Cannot map to dataset null.");
			else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
				return objects.ToArray();
	
			if (ds.Tables[TABLE_NAME] == null)
				throw new ApplicationException("Cannot find table [dbo].[help] in DataSet.");
	
			if (ds.Tables[TABLE_NAME].Rows.Count < 1)
				throw new ApplicationException("Table [dbo].[help] is empty.");
	
			// Map DataSet to Instance.
			foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
			{
				Help instance = new Help();
				instance.MapFrom(dr);
				objects.Add(instance);
			}
	
			// Return collection.
			return objects.ToArray();
		}
	
	
		#endregion
	
	
		#region CRUD Methods
	
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Help Get(System.Int32 id)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
			Help instance;
	
	
			instance = new Help();
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Help_SELECT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id);
	
			// Get results.
			ds = db.ExecuteDataSet(dbCommand);
			// Verification.
			if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get Help ID:" + id.ToString()+ " from Database.");
			// Return results.
			ds.Tables[0].TableName = TABLE_NAME;
	
			instance.MapFrom( ds.Tables[0].Rows[0] );
			return instance;
		}
	
		#region INSERT
		public void Insert(System.String keyword, System.String message, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Help_INSERT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, keyword, message);
	
			if (transaction == null)
				this.Id = Convert.ToInt32(db.ExecuteScalar(dbCommand));
			else
				this.Id = Convert.ToInt32(db.ExecuteScalar(dbCommand, transaction));
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
		public void Insert(System.String keyword, System.String message)
		{
			Insert(keyword, message, null);
		}
	/// <summary>
	/// Insert current Help to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Insert(DbTransaction transaction)
		{
			Insert(Keyword, Message, transaction);
		}
	
	/// <summary>
	/// Insert current Help to database.
	/// </summary>
		public void Insert()
		{
			this.Insert((DbTransaction)null);
		}
		#endregion
	
	
		#region UPDATE
		public static void Update(System.Int32? id, System.String keyword, System.String message, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Help_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@id"].Value = id;
			dbCommand.Parameters["@keyword"].Value = keyword;
			dbCommand.Parameters["@message"].Value = message;
	
			if (transaction == null)
				db.ExecuteNonQuery(dbCommand);
			else
				db.ExecuteNonQuery(dbCommand, transaction);
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
		public static void Update(System.Int32? id, System.String keyword, System.String message)
		{
			Update(id, keyword, message, null);
		}
	
	public static void Update(Help help)
	{
	help.Update();
	}
	
	public static void Update(Help help, DbTransaction transaction)
	{
	help.Update(transaction);
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
			sqlCommand = "[dbo].Help_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@id"].SourceColumn = "id";
			dbCommand.Parameters["@keyword"].SourceColumn = "keyword";
			dbCommand.Parameters["@message"].SourceColumn = "message";
	
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
			sqlCommand = "[dbo].Help_DELETE";
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
	/// Delete current Help from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Delete(DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Help_DELETE";
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
	/// Delete current Help from database.
	/// </summary>
		public void Delete()
	{
	this.Delete((DbTransaction)null);
	}
	
		#endregion
	
	
		#region SEARCH
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Help[] Search(System.Int32? id, System.String keyword, System.String message, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Help_SEARCH";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id, keyword, message, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return Help.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static Help[] Search(Help searchObject)
		{
			return Search ( searchObject.Id, searchObject.Keyword, searchObject.Message, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all Help objects.
		/// </summary>
		/// <returns>List of all Help objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static Help[] Search()
		{
			return Search ( null, null, null, null);
		}
	
		#endregion
	
	
		#region SEARCHEXACT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Help[] SearchExact(System.Int32? id, System.String keyword, System.String message, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Help_SEARCHEXACT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id, keyword, message, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return Help.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static Help[] SearchExact(Help searchObject)
		{
			return SearchExact ( searchObject.Id, searchObject.Keyword, searchObject.Message, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all Help objects.
		/// </summary>
		/// <returns>List of all Help objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static Help[] SearchExact()
		{
			return SearchExact ( null, null, null, null);
		}
	
		#endregion
	
	
		#region CUSTOMSELECT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Help[] CustomSelect(System.String SqlQuery)
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
			return Help.MapFrom(ds);
	
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
	
