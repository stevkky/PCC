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
/// Data Access Layer Class for the [dbo].[SysEmailTo] Database Table
/// Business Logic to Access this Class will be in the SysEmailTo_Bll.cs file
/// All Business Logic should be therefore be Placed in that file
/// </summary>

namespace testingGen
{
	[DataObject]
	[Serializable]
	public partial class SysEmailTo
	{
	
	
		#region Constants
		private static readonly string TABLE_NAME = "[dbo].[SysEmailTo]";
	
		#endregion
	
	
		#region Fields
		private System.String _recID;
		private System.String _email;
		private System.String _instEmail;
		private System.String _description;
		private System.Boolean? _defAccount;
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
		
		public System.String InstEmail
		{
			get
			{
				return _instEmail;
			}
			set
			{
				_instEmail = value;
			}
		}
		
		public System.String Description
		{
			get
			{
				return _description;
			}
			set
			{
				_description = value;
			}
		}
		
		public System.Boolean? DefAccount
		{
			get
			{
				return _defAccount;
			}
			set
			{
				_defAccount = value;
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
			ds.Tables[TABLE_NAME].Columns.Add("Email", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("InstEmail", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("Description", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("DefAccount", typeof(System.Boolean) );
	
			dr = ds.Tables[TABLE_NAME].NewRow();
	
			if (RecID == null)
				dr["RecID"] = DBNull.Value;
			else
				dr["RecID"] = RecID;
	
			if (Email == null)
				dr["Email"] = DBNull.Value;
			else
				dr["Email"] = Email;
	
			if (InstEmail == null)
				dr["InstEmail"] = DBNull.Value;
			else
				dr["InstEmail"] = InstEmail;
	
			if (Description == null)
				dr["Description"] = DBNull.Value;
			else
				dr["Description"] = Description;
	
			if (DefAccount == null)
				dr["DefAccount"] = DBNull.Value;
			else
				dr["DefAccount"] = DefAccount;
	
	
			ds.Tables[TABLE_NAME].Rows.Add(dr);
	
		}
	
		protected void MapFrom(DataRow dr)
		{
			RecID = dr["RecID"] != DBNull.Value ? Convert.ToString(dr["RecID"]) : RecID = null;
			Email = dr["Email"] != DBNull.Value ? Convert.ToString(dr["Email"]) : Email = null;
			InstEmail = dr["InstEmail"] != DBNull.Value ? Convert.ToString(dr["InstEmail"]) : InstEmail = null;
			Description = dr["Description"] != DBNull.Value ? Convert.ToString(dr["Description"]) : Description = null;
			DefAccount = dr["DefAccount"] != DBNull.Value ? Convert.ToBoolean(dr["DefAccount"]) : DefAccount = null;
		}
	
		public static SysEmailTo[] MapFrom(DataSet ds)
		{
			List<SysEmailTo> objects;
	
	
			// Initialise Collection.
			objects = new List<SysEmailTo>();
	
			// Validation.
			if (ds == null)
				throw new ApplicationException("Cannot map to dataset null.");
			else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
				return objects.ToArray();
	
			if (ds.Tables[TABLE_NAME] == null)
				throw new ApplicationException("Cannot find table [dbo].[SysEmailTo] in DataSet.");
	
			if (ds.Tables[TABLE_NAME].Rows.Count < 1)
				throw new ApplicationException("Table [dbo].[SysEmailTo] is empty.");
	
			// Map DataSet to Instance.
			foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
			{
				SysEmailTo instance = new SysEmailTo();
				instance.MapFrom(dr);
				objects.Add(instance);
			}
	
			// Return collection.
			return objects.ToArray();
		}
	
	
		#endregion
	
	
		#region CRUD Methods
	
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static SysEmailTo Get(System.String recID)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
			SysEmailTo instance;
	
	
			instance = new SysEmailTo();
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SysEmailTo_SELECT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, recID);
	
			// Get results.
			ds = db.ExecuteDataSet(dbCommand);
			// Verification.
			if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get SysEmailTo ID:" + recID.ToString()+ " from Database.");
			// Return results.
			ds.Tables[0].TableName = TABLE_NAME;
	
			instance.MapFrom( ds.Tables[0].Rows[0] );
			return instance;
		}
	
		#region INSERT
		public void Insert(System.String recID, System.String email, System.String instEmail, System.String description, System.Boolean? defAccount, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SysEmailTo_INSERT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, recID, email, instEmail, description, defAccount);
	
			if (transaction == null)
				db.ExecuteScalar(dbCommand);
			else
				db.ExecuteScalar(dbCommand, transaction);
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
		public void Insert(System.String recID, System.String email, System.String instEmail, System.String description, System.Boolean? defAccount)
		{
			Insert(recID, email, instEmail, description, defAccount, null);
		}
	/// <summary>
	/// Insert current SysEmailTo to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Insert(DbTransaction transaction)
		{
			Insert(RecID, Email, InstEmail, Description, DefAccount, transaction);
		}
	
	/// <summary>
	/// Insert current SysEmailTo to database.
	/// </summary>
		public void Insert()
		{
			this.Insert((DbTransaction)null);
		}
		#endregion
	
	
		#region UPDATE
		public static void Update(System.String recID, System.String email, System.String instEmail, System.String description, System.Boolean? defAccount, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SysEmailTo_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@recID"].Value = recID;
			dbCommand.Parameters["@email"].Value = email;
			dbCommand.Parameters["@instEmail"].Value = instEmail;
			dbCommand.Parameters["@description"].Value = description;
			dbCommand.Parameters["@defAccount"].Value = defAccount;
	
			if (transaction == null)
				db.ExecuteNonQuery(dbCommand);
			else
				db.ExecuteNonQuery(dbCommand, transaction);
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
		public static void Update(System.String recID, System.String email, System.String instEmail, System.String description, System.Boolean? defAccount)
		{
			Update(recID, email, instEmail, description, defAccount, null);
		}
	
	public static void Update(SysEmailTo sysEmailTo)
	{
	sysEmailTo.Update();
	}
	
	public static void Update(SysEmailTo sysEmailTo, DbTransaction transaction)
	{
	sysEmailTo.Update(transaction);
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
			sqlCommand = "[dbo].SysEmailTo_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@recID"].SourceColumn = "RecID";
			dbCommand.Parameters["@email"].SourceColumn = "Email";
			dbCommand.Parameters["@instEmail"].SourceColumn = "InstEmail";
			dbCommand.Parameters["@description"].SourceColumn = "Description";
			dbCommand.Parameters["@defAccount"].SourceColumn = "DefAccount";
	
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
			sqlCommand = "[dbo].SysEmailTo_DELETE";
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
	/// Delete current SysEmailTo from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Delete(DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SysEmailTo_DELETE";
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
	/// Delete current SysEmailTo from database.
	/// </summary>
		public void Delete()
	{
	this.Delete((DbTransaction)null);
	}
	
		#endregion
	
	
		#region SEARCH
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static SysEmailTo[] Search(System.String recID, System.String email, System.String instEmail, System.String description, System.Boolean? defAccount, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SysEmailTo_SEARCH";
			dbCommand = db.GetStoredProcCommand(sqlCommand, recID, email, instEmail, description, defAccount, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return SysEmailTo.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static SysEmailTo[] Search(SysEmailTo searchObject)
		{
			return Search ( searchObject.RecID, searchObject.Email, searchObject.InstEmail, searchObject.Description, searchObject.DefAccount, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all SysEmailTo objects.
		/// </summary>
		/// <returns>List of all SysEmailTo objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static SysEmailTo[] Search()
		{
			return Search ( null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region SEARCHEXACT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static SysEmailTo[] SearchExact(System.String recID, System.String email, System.String instEmail, System.String description, System.Boolean? defAccount, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].SysEmailTo_SEARCHEXACT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, recID, email, instEmail, description, defAccount, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return SysEmailTo.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static SysEmailTo[] SearchExact(SysEmailTo searchObject)
		{
			return SearchExact ( searchObject.RecID, searchObject.Email, searchObject.InstEmail, searchObject.Description, searchObject.DefAccount, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all SysEmailTo objects.
		/// </summary>
		/// <returns>List of all SysEmailTo objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static SysEmailTo[] SearchExact()
		{
			return SearchExact ( null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region CUSTOMSELECT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static SysEmailTo[] CustomSelect(System.String SqlQuery)
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
			return SysEmailTo.MapFrom(ds);
	
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
	
