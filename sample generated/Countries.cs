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
/// Data Access Layer Class for the [dbo].[countries] Database Table
/// Business Logic to Access this Class will be in the Countries_Bll.cs file
/// All Business Logic should be therefore be Placed in that file
/// </summary>

namespace testingGen
{
	[DataObject]
	[Serializable]
	public partial class Countries
	{
	
	
		#region Constants
		private static readonly string TABLE_NAME = "[dbo].[countries]";
	
		#endregion
	
	
		#region Fields
		private System.Int32? _no;
		private System.String _isoCode;
		private System.Int32? _phoneCode;
		private System.String _country;
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
		
		public System.String IsoCode
		{
			get
			{
				return _isoCode;
			}
			set
			{
				_isoCode = value;
			}
		}
		
		public System.Int32? PhoneCode
		{
			get
			{
				return _phoneCode;
			}
			set
			{
				_phoneCode = value;
			}
		}
		
		public System.String Country
		{
			get
			{
				return _country;
			}
			set
			{
				_country = value;
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
			ds.Tables[TABLE_NAME].Columns.Add("iso_code", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("phone_code", typeof(System.Int32) );
			ds.Tables[TABLE_NAME].Columns.Add("country", typeof(System.String) );
	
			dr = ds.Tables[TABLE_NAME].NewRow();
	
			if (No == null)
				dr["No"] = DBNull.Value;
			else
				dr["No"] = No;
	
			if (IsoCode == null)
				dr["iso_code"] = DBNull.Value;
			else
				dr["iso_code"] = IsoCode;
	
			if (PhoneCode == null)
				dr["phone_code"] = DBNull.Value;
			else
				dr["phone_code"] = PhoneCode;
	
			if (Country == null)
				dr["country"] = DBNull.Value;
			else
				dr["country"] = Country;
	
	
			ds.Tables[TABLE_NAME].Rows.Add(dr);
	
		}
	
		protected void MapFrom(DataRow dr)
		{
			No = dr["No"] != DBNull.Value ? Convert.ToInt32(dr["No"]) : No = null;
			IsoCode = dr["iso_code"] != DBNull.Value ? Convert.ToString(dr["iso_code"]) : IsoCode = null;
			PhoneCode = dr["phone_code"] != DBNull.Value ? Convert.ToInt32(dr["phone_code"]) : PhoneCode = null;
			Country = dr["country"] != DBNull.Value ? Convert.ToString(dr["country"]) : Country = null;
		}
	
		public static Countries[] MapFrom(DataSet ds)
		{
			List<Countries> objects;
	
	
			// Initialise Collection.
			objects = new List<Countries>();
	
			// Validation.
			if (ds == null)
				throw new ApplicationException("Cannot map to dataset null.");
			else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
				return objects.ToArray();
	
			if (ds.Tables[TABLE_NAME] == null)
				throw new ApplicationException("Cannot find table [dbo].[countries] in DataSet.");
	
			if (ds.Tables[TABLE_NAME].Rows.Count < 1)
				throw new ApplicationException("Table [dbo].[countries] is empty.");
	
			// Map DataSet to Instance.
			foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
			{
				Countries instance = new Countries();
				instance.MapFrom(dr);
				objects.Add(instance);
			}
	
			// Return collection.
			return objects.ToArray();
		}
	
	
		#endregion
	
	
		#region CRUD Methods
	
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Countries Get(System.Int32 no)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
			Countries instance;
	
	
			instance = new Countries();
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Countries_SELECT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, no);
	
			// Get results.
			ds = db.ExecuteDataSet(dbCommand);
			// Verification.
			if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get Countries ID:" + no.ToString()+ " from Database.");
			// Return results.
			ds.Tables[0].TableName = TABLE_NAME;
	
			instance.MapFrom( ds.Tables[0].Rows[0] );
			return instance;
		}
	
		#region INSERT
		public void Insert(System.String isoCode, System.Int32? phoneCode, System.String country, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Countries_INSERT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, isoCode, phoneCode, country);
	
			if (transaction == null)
				this.No = Convert.ToInt32(db.ExecuteScalar(dbCommand));
			else
				this.No = Convert.ToInt32(db.ExecuteScalar(dbCommand, transaction));
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
		public void Insert(System.String isoCode, System.Int32? phoneCode, System.String country)
		{
			Insert(isoCode, phoneCode, country, null);
		}
	/// <summary>
	/// Insert current Countries to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Insert(DbTransaction transaction)
		{
			Insert(IsoCode, PhoneCode, Country, transaction);
		}
	
	/// <summary>
	/// Insert current Countries to database.
	/// </summary>
		public void Insert()
		{
			this.Insert((DbTransaction)null);
		}
		#endregion
	
	
		#region UPDATE
		public static void Update(System.Int32? no, System.String isoCode, System.Int32? phoneCode, System.String country, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Countries_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@no"].Value = no;
			dbCommand.Parameters["@isoCode"].Value = isoCode;
			dbCommand.Parameters["@phoneCode"].Value = phoneCode;
			dbCommand.Parameters["@country"].Value = country;
	
			if (transaction == null)
				db.ExecuteNonQuery(dbCommand);
			else
				db.ExecuteNonQuery(dbCommand, transaction);
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
		public static void Update(System.Int32? no, System.String isoCode, System.Int32? phoneCode, System.String country)
		{
			Update(no, isoCode, phoneCode, country, null);
		}
	
	public static void Update(Countries countries)
	{
	countries.Update();
	}
	
	public static void Update(Countries countries, DbTransaction transaction)
	{
	countries.Update(transaction);
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
			sqlCommand = "[dbo].Countries_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@no"].SourceColumn = "No";
			dbCommand.Parameters["@isoCode"].SourceColumn = "iso_code";
			dbCommand.Parameters["@phoneCode"].SourceColumn = "phone_code";
			dbCommand.Parameters["@country"].SourceColumn = "country";
	
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
			sqlCommand = "[dbo].Countries_DELETE";
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
	/// Delete current Countries from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Delete(DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Countries_DELETE";
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
	/// Delete current Countries from database.
	/// </summary>
		public void Delete()
	{
	this.Delete((DbTransaction)null);
	}
	
		#endregion
	
	
		#region SEARCH
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Countries[] Search(System.Int32? no, System.String isoCode, System.Int32? phoneCode, System.String country, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Countries_SEARCH";
			dbCommand = db.GetStoredProcCommand(sqlCommand, no, isoCode, phoneCode, country, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return Countries.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static Countries[] Search(Countries searchObject)
		{
			return Search ( searchObject.No, searchObject.IsoCode, searchObject.PhoneCode, searchObject.Country, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all Countries objects.
		/// </summary>
		/// <returns>List of all Countries objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static Countries[] Search()
		{
			return Search ( null, null, null, null, null);
		}
	
		#endregion
	
	
		#region SEARCHEXACT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Countries[] SearchExact(System.Int32? no, System.String isoCode, System.Int32? phoneCode, System.String country, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Countries_SEARCHEXACT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, no, isoCode, phoneCode, country, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return Countries.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static Countries[] SearchExact(Countries searchObject)
		{
			return SearchExact ( searchObject.No, searchObject.IsoCode, searchObject.PhoneCode, searchObject.Country, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all Countries objects.
		/// </summary>
		/// <returns>List of all Countries objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static Countries[] SearchExact()
		{
			return SearchExact ( null, null, null, null, null);
		}
	
		#endregion
	
	
		#region CUSTOMSELECT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Countries[] CustomSelect(System.String SqlQuery)
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
			return Countries.MapFrom(ds);
	
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
	
