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
/// Data Access Layer Class for the [dbo].[contacts] Database Table
/// Business Logic to Access this Class will be in the Contacts_Bll.cs file
/// All Business Logic should be therefore be Placed in that file
/// </summary>

namespace testingGen
{
	[DataObject]
	[Serializable]
	public partial class Contacts
	{
	
	
		#region Constants
		private static readonly string TABLE_NAME = "[dbo].[contacts]";
	
		#endregion
	
	
		#region Fields
		private System.Int64? _no;
		private System.String _name;
		private System.String _phone;
		private System.Int32? _groupId;
		private System.String _custom1;
		private System.String _custom2;
		private System.String _custom3;
		private System.String _custom4;
		private System.String _custom5;
		private System.String _custom6;
		private System.String _custom7;
		private System.String _ORDERBY_FIELD;
	
		#endregion
	
	
		#region Properties
		public System.Int64? No
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
		
		public System.String Phone
		{
			get
			{
				return _phone;
			}
			set
			{
				_phone = value;
			}
		}
		
		public System.Int32? GroupId
		{
			get
			{
				return _groupId;
			}
			set
			{
				_groupId = value;
			}
		}
		
		public System.String Custom1
		{
			get
			{
				return _custom1;
			}
			set
			{
				_custom1 = value;
			}
		}
		
		public System.String Custom2
		{
			get
			{
				return _custom2;
			}
			set
			{
				_custom2 = value;
			}
		}
		
		public System.String Custom3
		{
			get
			{
				return _custom3;
			}
			set
			{
				_custom3 = value;
			}
		}
		
		public System.String Custom4
		{
			get
			{
				return _custom4;
			}
			set
			{
				_custom4 = value;
			}
		}
		
		public System.String Custom5
		{
			get
			{
				return _custom5;
			}
			set
			{
				_custom5 = value;
			}
		}
		
		public System.String Custom6
		{
			get
			{
				return _custom6;
			}
			set
			{
				_custom6 = value;
			}
		}
		
		public System.String Custom7
		{
			get
			{
				return _custom7;
			}
			set
			{
				_custom7 = value;
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
	
			ds.Tables[TABLE_NAME].Columns.Add("No", typeof(System.Int64) );
			ds.Tables[TABLE_NAME].Columns.Add("Name", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("Phone", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("groupId", typeof(System.Int32) );
			ds.Tables[TABLE_NAME].Columns.Add("Custom1", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("Custom2", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("Custom3", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("Custom4", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("Custom5", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("Custom6", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("Custom7", typeof(System.String) );
	
			dr = ds.Tables[TABLE_NAME].NewRow();
	
			if (No == null)
				dr["No"] = DBNull.Value;
			else
				dr["No"] = No;
	
			if (Name == null)
				dr["Name"] = DBNull.Value;
			else
				dr["Name"] = Name;
	
			if (Phone == null)
				dr["Phone"] = DBNull.Value;
			else
				dr["Phone"] = Phone;
	
			if (GroupId == null)
				dr["groupId"] = DBNull.Value;
			else
				dr["groupId"] = GroupId;
	
			if (Custom1 == null)
				dr["Custom1"] = DBNull.Value;
			else
				dr["Custom1"] = Custom1;
	
			if (Custom2 == null)
				dr["Custom2"] = DBNull.Value;
			else
				dr["Custom2"] = Custom2;
	
			if (Custom3 == null)
				dr["Custom3"] = DBNull.Value;
			else
				dr["Custom3"] = Custom3;
	
			if (Custom4 == null)
				dr["Custom4"] = DBNull.Value;
			else
				dr["Custom4"] = Custom4;
	
			if (Custom5 == null)
				dr["Custom5"] = DBNull.Value;
			else
				dr["Custom5"] = Custom5;
	
			if (Custom6 == null)
				dr["Custom6"] = DBNull.Value;
			else
				dr["Custom6"] = Custom6;
	
			if (Custom7 == null)
				dr["Custom7"] = DBNull.Value;
			else
				dr["Custom7"] = Custom7;
	
	
			ds.Tables[TABLE_NAME].Rows.Add(dr);
	
		}
	
		protected void MapFrom(DataRow dr)
		{
			No = dr["No"] != DBNull.Value ? Convert.ToInt64(dr["No"]) : No = null;
			Name = dr["Name"] != DBNull.Value ? Convert.ToString(dr["Name"]) : Name = null;
			Phone = dr["Phone"] != DBNull.Value ? Convert.ToString(dr["Phone"]) : Phone = null;
			GroupId = dr["groupId"] != DBNull.Value ? Convert.ToInt32(dr["groupId"]) : GroupId = null;
			Custom1 = dr["Custom1"] != DBNull.Value ? Convert.ToString(dr["Custom1"]) : Custom1 = null;
			Custom2 = dr["Custom2"] != DBNull.Value ? Convert.ToString(dr["Custom2"]) : Custom2 = null;
			Custom3 = dr["Custom3"] != DBNull.Value ? Convert.ToString(dr["Custom3"]) : Custom3 = null;
			Custom4 = dr["Custom4"] != DBNull.Value ? Convert.ToString(dr["Custom4"]) : Custom4 = null;
			Custom5 = dr["Custom5"] != DBNull.Value ? Convert.ToString(dr["Custom5"]) : Custom5 = null;
			Custom6 = dr["Custom6"] != DBNull.Value ? Convert.ToString(dr["Custom6"]) : Custom6 = null;
			Custom7 = dr["Custom7"] != DBNull.Value ? Convert.ToString(dr["Custom7"]) : Custom7 = null;
		}
	
		public static Contacts[] MapFrom(DataSet ds)
		{
			List<Contacts> objects;
	
	
			// Initialise Collection.
			objects = new List<Contacts>();
	
			// Validation.
			if (ds == null)
				throw new ApplicationException("Cannot map to dataset null.");
			else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
				return objects.ToArray();
	
			if (ds.Tables[TABLE_NAME] == null)
				throw new ApplicationException("Cannot find table [dbo].[contacts] in DataSet.");
	
			if (ds.Tables[TABLE_NAME].Rows.Count < 1)
				throw new ApplicationException("Table [dbo].[contacts] is empty.");
	
			// Map DataSet to Instance.
			foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
			{
				Contacts instance = new Contacts();
				instance.MapFrom(dr);
				objects.Add(instance);
			}
	
			// Return collection.
			return objects.ToArray();
		}
	
	
		#endregion
	
	
		#region CRUD Methods
	
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Contacts Get(System.Int64 no)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
			Contacts instance;
	
	
			instance = new Contacts();
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Contacts_SELECT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, no);
	
			// Get results.
			ds = db.ExecuteDataSet(dbCommand);
			// Verification.
			if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get Contacts ID:" + no.ToString()+ " from Database.");
			// Return results.
			ds.Tables[0].TableName = TABLE_NAME;
	
			instance.MapFrom( ds.Tables[0].Rows[0] );
			return instance;
		}
	
		#region INSERT
		public void Insert(System.String name, System.String phone, System.Int32? groupId, System.String custom1, System.String custom2, System.String custom3, System.String custom4, System.String custom5, System.String custom6, System.String custom7, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Contacts_INSERT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, name, phone, groupId, custom1, custom2, custom3, custom4, custom5, custom6, custom7);
	
			if (transaction == null)
				this.No = Convert.ToInt64(db.ExecuteScalar(dbCommand));
			else
				this.No = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
		public void Insert(System.String name, System.String phone, System.Int32? groupId, System.String custom1, System.String custom2, System.String custom3, System.String custom4, System.String custom5, System.String custom6, System.String custom7)
		{
			Insert(name, phone, groupId, custom1, custom2, custom3, custom4, custom5, custom6, custom7, null);
		}
	/// <summary>
	/// Insert current Contacts to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Insert(DbTransaction transaction)
		{
			Insert(Name, Phone, GroupId, Custom1, Custom2, Custom3, Custom4, Custom5, Custom6, Custom7, transaction);
		}
	
	/// <summary>
	/// Insert current Contacts to database.
	/// </summary>
		public void Insert()
		{
			this.Insert((DbTransaction)null);
		}
		#endregion
	
	
		#region UPDATE
		public static void Update(System.Int64? no, System.String name, System.String phone, System.Int32? groupId, System.String custom1, System.String custom2, System.String custom3, System.String custom4, System.String custom5, System.String custom6, System.String custom7, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Contacts_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@no"].Value = no;
			dbCommand.Parameters["@name"].Value = name;
			dbCommand.Parameters["@phone"].Value = phone;
			dbCommand.Parameters["@groupId"].Value = groupId;
			dbCommand.Parameters["@custom1"].Value = custom1;
			dbCommand.Parameters["@custom2"].Value = custom2;
			dbCommand.Parameters["@custom3"].Value = custom3;
			dbCommand.Parameters["@custom4"].Value = custom4;
			dbCommand.Parameters["@custom5"].Value = custom5;
			dbCommand.Parameters["@custom6"].Value = custom6;
			dbCommand.Parameters["@custom7"].Value = custom7;
	
			if (transaction == null)
				db.ExecuteNonQuery(dbCommand);
			else
				db.ExecuteNonQuery(dbCommand, transaction);
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
		public static void Update(System.Int64? no, System.String name, System.String phone, System.Int32? groupId, System.String custom1, System.String custom2, System.String custom3, System.String custom4, System.String custom5, System.String custom6, System.String custom7)
		{
			Update(no, name, phone, groupId, custom1, custom2, custom3, custom4, custom5, custom6, custom7, null);
		}
	
	public static void Update(Contacts contacts)
	{
	contacts.Update();
	}
	
	public static void Update(Contacts contacts, DbTransaction transaction)
	{
	contacts.Update(transaction);
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
			sqlCommand = "[dbo].Contacts_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@no"].SourceColumn = "No";
			dbCommand.Parameters["@name"].SourceColumn = "Name";
			dbCommand.Parameters["@phone"].SourceColumn = "Phone";
			dbCommand.Parameters["@groupId"].SourceColumn = "groupId";
			dbCommand.Parameters["@custom1"].SourceColumn = "Custom1";
			dbCommand.Parameters["@custom2"].SourceColumn = "Custom2";
			dbCommand.Parameters["@custom3"].SourceColumn = "Custom3";
			dbCommand.Parameters["@custom4"].SourceColumn = "Custom4";
			dbCommand.Parameters["@custom5"].SourceColumn = "Custom5";
			dbCommand.Parameters["@custom6"].SourceColumn = "Custom6";
			dbCommand.Parameters["@custom7"].SourceColumn = "Custom7";
	
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
		public static void Delete(System.Int64? no, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Contacts_DELETE";
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
		public static void Delete(System.Int64? no)
	{
	Delete(
	no);
	}
	
	/// <summary>
	/// Delete current Contacts from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Delete(DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Contacts_DELETE";
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
	/// Delete current Contacts from database.
	/// </summary>
		public void Delete()
	{
	this.Delete((DbTransaction)null);
	}
	
		#endregion
	
	
		#region SEARCH
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Contacts[] Search(System.Int64? no, System.String name, System.String phone, System.Int32? groupId, System.String custom1, System.String custom2, System.String custom3, System.String custom4, System.String custom5, System.String custom6, System.String custom7, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Contacts_SEARCH";
			dbCommand = db.GetStoredProcCommand(sqlCommand, no, name, phone, groupId, custom1, custom2, custom3, custom4, custom5, custom6, custom7, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return Contacts.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static Contacts[] Search(Contacts searchObject)
		{
			return Search ( searchObject.No, searchObject.Name, searchObject.Phone, searchObject.GroupId, searchObject.Custom1, searchObject.Custom2, searchObject.Custom3, searchObject.Custom4, searchObject.Custom5, searchObject.Custom6, searchObject.Custom7, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all Contacts objects.
		/// </summary>
		/// <returns>List of all Contacts objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static Contacts[] Search()
		{
			return Search ( null, null, null, null, null, null, null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region SEARCHEXACT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Contacts[] SearchExact(System.Int64? no, System.String name, System.String phone, System.Int32? groupId, System.String custom1, System.String custom2, System.String custom3, System.String custom4, System.String custom5, System.String custom6, System.String custom7, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Contacts_SEARCHEXACT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, no, name, phone, groupId, custom1, custom2, custom3, custom4, custom5, custom6, custom7, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return Contacts.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static Contacts[] SearchExact(Contacts searchObject)
		{
			return SearchExact ( searchObject.No, searchObject.Name, searchObject.Phone, searchObject.GroupId, searchObject.Custom1, searchObject.Custom2, searchObject.Custom3, searchObject.Custom4, searchObject.Custom5, searchObject.Custom6, searchObject.Custom7, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all Contacts objects.
		/// </summary>
		/// <returns>List of all Contacts objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static Contacts[] SearchExact()
		{
			return SearchExact ( null, null, null, null, null, null, null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region CUSTOMSELECT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Contacts[] CustomSelect(System.String SqlQuery)
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
			return Contacts.MapFrom(ds);
	
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
	
