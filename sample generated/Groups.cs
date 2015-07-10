/*----------------------------------------------------------------------------------------------------------*/
/* Telligent (GH) Systems CodeGenerator (written by Stephen Adjei-Kyei.)                                   */
/*                                                                                                         */
/* File was generated using Telligent (GH) System's Code Generator.                                        */
/*                                                                                                         */
/* Date Generated: 7/7/2015 1:44:15 PM                                                                    */
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
/// Data Access Layer Class for the [dbo].[groups] Database Table
/// Business Logic to Access this Class will be in the Groups_Bll.cs file
/// All Business Logic should be therefore be Placed in that file
/// </summary>

namespace testingGen
{
	[DataObject]
	[Serializable]
	public partial class Groups
	{
	
	
		#region Constants
		private static readonly string TABLE_NAME = "[dbo].[groups]";
	
		#endregion
	
	
		#region Fields
		private System.Int32? _no;
		private System.String _groupName;
		private System.Int32? _parentGroupid;
		private System.String _ORDERBY_FIELD;
	
		#endregion
	
	
		#region Properties
		public System.Int32? No
		{
			get
			{
				return _no;
			}
			set
			{
				_no = value;
			}
		}
		
		public System.String GroupName
		{
			get
			{
				return _groupName;
			}
			set
			{
				_groupName = value;
			}
		}
		
		public System.Int32? ParentGroupid
		{
			get
			{
				return _parentGroupid;
			}
			set
			{
				_parentGroupid = value;
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
	
			ds.Tables[TABLE_NAME].Columns.Add("No", typeof(System.Int32) );
			ds.Tables[TABLE_NAME].Columns.Add("group_name", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("parent_groupid", typeof(System.Int32) );
	
			dr = ds.Tables[TABLE_NAME].NewRow();
	
			if (No == null)
				dr["No"] = DBNull.Value;
			else
				dr["No"] = No;
	
			if (GroupName == null)
				dr["group_name"] = DBNull.Value;
			else
				dr["group_name"] = GroupName;
	
			if (ParentGroupid == null)
				dr["parent_groupid"] = DBNull.Value;
			else
				dr["parent_groupid"] = ParentGroupid;
	
	
			ds.Tables[TABLE_NAME].Rows.Add(dr);
	
		}
	
		protected void MapFrom(DataRow dr)
		{
			No = dr["No"] != DBNull.Value ? Convert.ToInt32(dr["No"]) : No = null;
			GroupName = dr["group_name"] != DBNull.Value ? Convert.ToString(dr["group_name"]) : GroupName = null;
			ParentGroupid = dr["parent_groupid"] != DBNull.Value ? Convert.ToInt32(dr["parent_groupid"]) : ParentGroupid = null;
		}
	
		public static Groups[] MapFrom(DataSet ds)
		{
			List<Groups> objects;
	
	
			// Initialise Collection.
			objects = new List<Groups>();
	
			// Validation.
			if (ds == null)
				throw new ApplicationException("Cannot map to dataset null.");
			else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
				return objects.ToArray();
	
			if (ds.Tables[TABLE_NAME] == null)
				throw new ApplicationException("Cannot find table [dbo].[groups] in DataSet.");
	
			if (ds.Tables[TABLE_NAME].Rows.Count < 1)
				throw new ApplicationException("Table [dbo].[groups] is empty.");
	
			// Map DataSet to Instance.
			foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
			{
				Groups instance = new Groups();
				instance.MapFrom(dr);
				objects.Add(instance);
			}
	
			// Return collection.
			return objects.ToArray();
		}
	
	
		#endregion
	
	
		#region CRUD Methods
	
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Groups Get(System.Int32 no)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
			Groups instance;
	
	
			instance = new Groups();
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Groups_SELECT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, no);
	
			// Get results.
			ds = db.ExecuteDataSet(dbCommand);
			// Verification.
			if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get Groups ID:" + no.ToString()+ " from Database.");
			// Return results.
			ds.Tables[0].TableName = TABLE_NAME;
	
			instance.MapFrom( ds.Tables[0].Rows[0] );
			return instance;
		}
	
		#region INSERT
		public void Insert(System.String groupName, System.Int32? parentGroupid, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Groups_INSERT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, groupName, parentGroupid);
	
			if (transaction == null)
				this.No = Convert.ToInt32(db.ExecuteScalar(dbCommand));
			else
				this.No = Convert.ToInt32(db.ExecuteScalar(dbCommand, transaction));
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
		public void Insert(System.String groupName, System.Int32? parentGroupid)
		{
			Insert(groupName, parentGroupid, null);
		}
	/// <summary>
	/// Insert current Groups to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Insert(DbTransaction transaction)
		{
			Insert(GroupName, ParentGroupid, transaction);
		}
	
	/// <summary>
	/// Insert current Groups to database.
	/// </summary>
		public void Insert()
		{
			this.Insert((DbTransaction)null);
		}
		#endregion
	
	
		#region UPDATE
		public static void Update(System.Int32? no, System.String groupName, System.Int32? parentGroupid, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Groups_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@no"].Value = no;
			dbCommand.Parameters["@groupName"].Value = groupName;
			dbCommand.Parameters["@parentGroupid"].Value = parentGroupid;
	
			if (transaction == null)
				db.ExecuteNonQuery(dbCommand);
			else
				db.ExecuteNonQuery(dbCommand, transaction);
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
		public static void Update(System.Int32? no, System.String groupName, System.Int32? parentGroupid)
		{
			Update(no, groupName, parentGroupid, null);
		}
	
	public static void Update(Groups groups)
	{
	groups.Update();
	}
	
	public static void Update(Groups groups, DbTransaction transaction)
	{
	groups.Update(transaction);
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
			sqlCommand = "[dbo].Groups_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@no"].SourceColumn = "No";
			dbCommand.Parameters["@groupName"].SourceColumn = "group_name";
			dbCommand.Parameters["@parentGroupid"].SourceColumn = "parent_groupid";
	
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
		public static void Delete(System.Int32? no, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Groups_DELETE";
			dbCommand = db.GetStoredProcCommand(sqlCommand, no);
	
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
		public static void Delete(System.Int32? no)
	{
	Delete(
	no);
	}
	
	/// <summary>
	/// Delete current Groups from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Delete(DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Groups_DELETE";
			dbCommand = db.GetStoredProcCommand(sqlCommand, No);
	
			// Execute.
	if (transaction != null)
	{
		db.ExecuteNonQuery(dbCommand, transaction);
	}
	else
	{
		db.ExecuteNonQuery(dbCommand);
	}
				this.No = null;
		}
	
	/// <summary>
	/// Delete current Groups from database.
	/// </summary>
		public void Delete()
	{
	this.Delete((DbTransaction)null);
	}
	
		#endregion
	
	
		#region SEARCH
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Groups[] Search(System.Int32? no, System.String groupName, System.Int32? parentGroupid, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Groups_SEARCH";
			dbCommand = db.GetStoredProcCommand(sqlCommand, no, groupName, parentGroupid, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return Groups.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static Groups[] Search(Groups searchObject)
		{
			return Search ( searchObject.No, searchObject.GroupName, searchObject.ParentGroupid, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all Groups objects.
		/// </summary>
		/// <returns>List of all Groups objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static Groups[] Search()
		{
			return Search ( null, null, null, null);
		}
	
		#endregion
	
	
		#region SEARCHEXACT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Groups[] SearchExact(System.Int32? no, System.String groupName, System.Int32? parentGroupid, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Groups_SEARCHEXACT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, no, groupName, parentGroupid, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return Groups.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static Groups[] SearchExact(Groups searchObject)
		{
			return SearchExact ( searchObject.No, searchObject.GroupName, searchObject.ParentGroupid, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all Groups objects.
		/// </summary>
		/// <returns>List of all Groups objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static Groups[] SearchExact()
		{
			return SearchExact ( null, null, null, null);
		}
	
		#endregion
	
	
		#region CUSTOMSELECT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Groups[] CustomSelect(System.String SqlQuery)
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
			return Groups.MapFrom(ds);
	
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
	
