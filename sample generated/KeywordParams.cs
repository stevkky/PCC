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
/// Data Access Layer Class for the [dbo].[keyword_params] Database Table
/// Business Logic to Access this Class will be in the KeywordParams_Bll.cs file
/// All Business Logic should be therefore be Placed in that file
/// </summary>

namespace testingGen
{
	[DataObject]
	[Serializable]
	public partial class KeywordParams
	{
	
	
		#region Constants
		private static readonly string TABLE_NAME = "[dbo].[keyword_params]";
	
		#endregion
	
	
		#region Fields
		private System.String _keyword;
		private System.String _name;
		private System.String _datatype;
		private System.String _mappedField;
		private System.Int32? _position;
		private System.String _errorMessage;
		private System.String _validateType;
		private System.String _validationData;
		private System.String _validateType2;
		private System.String _validationData2;
		private System.Int32? _id;
		private System.Int32? _keywordId;
		private System.String _ORDERBY_FIELD;
	
		#endregion
	
	
		#region Properties
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
		
		public System.String Datatype
		{
			get
			{
				return _datatype;
			}
			set
			{
				_datatype = value;
			}
		}
		
		public System.String MappedField
		{
			get
			{
				return _mappedField;
			}
			set
			{
				_mappedField = value;
			}
		}
		
		public System.Int32? Position
		{
			get
			{
				return _position;
			}
			set
			{
				_position = value;
			}
		}
		
		public System.String ErrorMessage
		{
			get
			{
				return _errorMessage;
			}
			set
			{
				_errorMessage = value;
			}
		}
		
		public System.String ValidateType
		{
			get
			{
				return _validateType;
			}
			set
			{
				_validateType = value;
			}
		}
		
		public System.String ValidationData
		{
			get
			{
				return _validationData;
			}
			set
			{
				_validationData = value;
			}
		}
		
		public System.String ValidateType2
		{
			get
			{
				return _validateType2;
			}
			set
			{
				_validateType2 = value;
			}
		}
		
		public System.String ValidationData2
		{
			get
			{
				return _validationData2;
			}
			set
			{
				_validationData2 = value;
			}
		}
		
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
		
		public System.Int32? KeywordId
		{
			get
			{
				return _keywordId;
			}
			set
			{
				_keywordId = value;
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
	
			ds.Tables[TABLE_NAME].Columns.Add("keyword", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("name", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("datatype", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("mapped_field", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("Position", typeof(System.Int32) );
			ds.Tables[TABLE_NAME].Columns.Add("error_message", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("Validate_type", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("validation_data", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("Validate_type2", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("validation_data2", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("id", typeof(System.Int32) );
			ds.Tables[TABLE_NAME].Columns.Add("keyword_id", typeof(System.Int32) );
	
			dr = ds.Tables[TABLE_NAME].NewRow();
	
			if (Keyword == null)
				dr["keyword"] = DBNull.Value;
			else
				dr["keyword"] = Keyword;
	
			if (Name == null)
				dr["name"] = DBNull.Value;
			else
				dr["name"] = Name;
	
			if (Datatype == null)
				dr["datatype"] = DBNull.Value;
			else
				dr["datatype"] = Datatype;
	
			if (MappedField == null)
				dr["mapped_field"] = DBNull.Value;
			else
				dr["mapped_field"] = MappedField;
	
			if (Position == null)
				dr["Position"] = DBNull.Value;
			else
				dr["Position"] = Position;
	
			if (ErrorMessage == null)
				dr["error_message"] = DBNull.Value;
			else
				dr["error_message"] = ErrorMessage;
	
			if (ValidateType == null)
				dr["Validate_type"] = DBNull.Value;
			else
				dr["Validate_type"] = ValidateType;
	
			if (ValidationData == null)
				dr["validation_data"] = DBNull.Value;
			else
				dr["validation_data"] = ValidationData;
	
			if (ValidateType2 == null)
				dr["Validate_type2"] = DBNull.Value;
			else
				dr["Validate_type2"] = ValidateType2;
	
			if (ValidationData2 == null)
				dr["validation_data2"] = DBNull.Value;
			else
				dr["validation_data2"] = ValidationData2;
	
			if (Id == null)
				dr["id"] = DBNull.Value;
			else
				dr["id"] = Id;
	
			if (KeywordId == null)
				dr["keyword_id"] = DBNull.Value;
			else
				dr["keyword_id"] = KeywordId;
	
	
			ds.Tables[TABLE_NAME].Rows.Add(dr);
	
		}
	
		protected void MapFrom(DataRow dr)
		{
			Keyword = dr["keyword"] != DBNull.Value ? Convert.ToString(dr["keyword"]) : Keyword = null;
			Name = dr["name"] != DBNull.Value ? Convert.ToString(dr["name"]) : Name = null;
			Datatype = dr["datatype"] != DBNull.Value ? Convert.ToString(dr["datatype"]) : Datatype = null;
			MappedField = dr["mapped_field"] != DBNull.Value ? Convert.ToString(dr["mapped_field"]) : MappedField = null;
			Position = dr["Position"] != DBNull.Value ? Convert.ToInt32(dr["Position"]) : Position = null;
			ErrorMessage = dr["error_message"] != DBNull.Value ? Convert.ToString(dr["error_message"]) : ErrorMessage = null;
			ValidateType = dr["Validate_type"] != DBNull.Value ? Convert.ToString(dr["Validate_type"]) : ValidateType = null;
			ValidationData = dr["validation_data"] != DBNull.Value ? Convert.ToString(dr["validation_data"]) : ValidationData = null;
			ValidateType2 = dr["Validate_type2"] != DBNull.Value ? Convert.ToString(dr["Validate_type2"]) : ValidateType2 = null;
			ValidationData2 = dr["validation_data2"] != DBNull.Value ? Convert.ToString(dr["validation_data2"]) : ValidationData2 = null;
			Id = dr["id"] != DBNull.Value ? Convert.ToInt32(dr["id"]) : Id = null;
			KeywordId = dr["keyword_id"] != DBNull.Value ? Convert.ToInt32(dr["keyword_id"]) : KeywordId = null;
		}
	
		public static KeywordParams[] MapFrom(DataSet ds)
		{
			List<KeywordParams> objects;
	
	
			// Initialise Collection.
			objects = new List<KeywordParams>();
	
			// Validation.
			if (ds == null)
				throw new ApplicationException("Cannot map to dataset null.");
			else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
				return objects.ToArray();
	
			if (ds.Tables[TABLE_NAME] == null)
				throw new ApplicationException("Cannot find table [dbo].[keyword_params] in DataSet.");
	
			if (ds.Tables[TABLE_NAME].Rows.Count < 1)
				throw new ApplicationException("Table [dbo].[keyword_params] is empty.");
	
			// Map DataSet to Instance.
			foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
			{
				KeywordParams instance = new KeywordParams();
				instance.MapFrom(dr);
				objects.Add(instance);
			}
	
			// Return collection.
			return objects.ToArray();
		}
	
	
		#endregion
	
	
		#region CRUD Methods
	
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static KeywordParams Get(System.Int32 id)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
			KeywordParams instance;
	
	
			instance = new KeywordParams();
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].KeywordParams_SELECT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id);
	
			// Get results.
			ds = db.ExecuteDataSet(dbCommand);
			// Verification.
			if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get KeywordParams ID:" + id.ToString()+ " from Database.");
			// Return results.
			ds.Tables[0].TableName = TABLE_NAME;
	
			instance.MapFrom( ds.Tables[0].Rows[0] );
			return instance;
		}
	
		#region INSERT
		public void Insert(System.String keyword, System.String name, System.String datatype, System.String mappedField, System.Int32? position, System.String errorMessage, System.String validateType, System.String validationData, System.String validateType2, System.String validationData2, System.Int32? keywordId, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].KeywordParams_INSERT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, keyword, name, datatype, mappedField, position, errorMessage, validateType, validationData, validateType2, validationData2, keywordId);
	
			if (transaction == null)
				this.Id = Convert.ToInt32(db.ExecuteScalar(dbCommand));
			else
				this.Id = Convert.ToInt32(db.ExecuteScalar(dbCommand, transaction));
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
		public void Insert(System.String keyword, System.String name, System.String datatype, System.String mappedField, System.Int32? position, System.String errorMessage, System.String validateType, System.String validationData, System.String validateType2, System.String validationData2, System.Int32? keywordId)
		{
			Insert(keyword, name, datatype, mappedField, position, errorMessage, validateType, validationData, validateType2, validationData2, keywordId, null);
		}
	/// <summary>
	/// Insert current KeywordParams to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Insert(DbTransaction transaction)
		{
			Insert(Keyword, Name, Datatype, MappedField, Position, ErrorMessage, ValidateType, ValidationData, ValidateType2, ValidationData2, KeywordId, transaction);
		}
	
	/// <summary>
	/// Insert current KeywordParams to database.
	/// </summary>
		public void Insert()
		{
			this.Insert((DbTransaction)null);
		}
		#endregion
	
	
		#region UPDATE
		public static void Update(System.String keyword, System.String name, System.String datatype, System.String mappedField, System.Int32? position, System.String errorMessage, System.String validateType, System.String validationData, System.String validateType2, System.String validationData2, System.Int32? id, System.Int32? keywordId, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].KeywordParams_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@keyword"].Value = keyword;
			dbCommand.Parameters["@name"].Value = name;
			dbCommand.Parameters["@datatype"].Value = datatype;
			dbCommand.Parameters["@mappedField"].Value = mappedField;
			dbCommand.Parameters["@position"].Value = position;
			dbCommand.Parameters["@errorMessage"].Value = errorMessage;
			dbCommand.Parameters["@validateType"].Value = validateType;
			dbCommand.Parameters["@validationData"].Value = validationData;
			dbCommand.Parameters["@validateType2"].Value = validateType2;
			dbCommand.Parameters["@validationData2"].Value = validationData2;
			dbCommand.Parameters["@id"].Value = id;
			dbCommand.Parameters["@keywordId"].Value = keywordId;
	
			if (transaction == null)
				db.ExecuteNonQuery(dbCommand);
			else
				db.ExecuteNonQuery(dbCommand, transaction);
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
		public static void Update(System.String keyword, System.String name, System.String datatype, System.String mappedField, System.Int32? position, System.String errorMessage, System.String validateType, System.String validationData, System.String validateType2, System.String validationData2, System.Int32? id, System.Int32? keywordId)
		{
			Update(keyword, name, datatype, mappedField, position, errorMessage, validateType, validationData, validateType2, validationData2, id, keywordId, null);
		}
	
	public static void Update(KeywordParams keywordParams)
	{
	keywordParams.Update();
	}
	
	public static void Update(KeywordParams keywordParams, DbTransaction transaction)
	{
	keywordParams.Update(transaction);
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
			sqlCommand = "[dbo].KeywordParams_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@keyword"].SourceColumn = "keyword";
			dbCommand.Parameters["@name"].SourceColumn = "name";
			dbCommand.Parameters["@datatype"].SourceColumn = "datatype";
			dbCommand.Parameters["@mappedField"].SourceColumn = "mapped_field";
			dbCommand.Parameters["@position"].SourceColumn = "Position";
			dbCommand.Parameters["@errorMessage"].SourceColumn = "error_message";
			dbCommand.Parameters["@validateType"].SourceColumn = "Validate_type";
			dbCommand.Parameters["@validationData"].SourceColumn = "validation_data";
			dbCommand.Parameters["@validateType2"].SourceColumn = "Validate_type2";
			dbCommand.Parameters["@validationData2"].SourceColumn = "validation_data2";
			dbCommand.Parameters["@id"].SourceColumn = "id";
			dbCommand.Parameters["@keywordId"].SourceColumn = "keyword_id";
	
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
			sqlCommand = "[dbo].KeywordParams_DELETE";
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
	/// Delete current KeywordParams from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Delete(DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].KeywordParams_DELETE";
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
	/// Delete current KeywordParams from database.
	/// </summary>
		public void Delete()
	{
	this.Delete((DbTransaction)null);
	}
	
		#endregion
	
	
		#region SEARCH
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static KeywordParams[] Search(System.String keyword, System.String name, System.String datatype, System.String mappedField, System.Int32? position, System.String errorMessage, System.String validateType, System.String validationData, System.String validateType2, System.String validationData2, System.Int32? id, System.Int32? keywordId, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].KeywordParams_SEARCH";
			dbCommand = db.GetStoredProcCommand(sqlCommand, keyword, name, datatype, mappedField, position, errorMessage, validateType, validationData, validateType2, validationData2, id, keywordId, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return KeywordParams.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static KeywordParams[] Search(KeywordParams searchObject)
		{
			return Search ( searchObject.Keyword, searchObject.Name, searchObject.Datatype, searchObject.MappedField, searchObject.Position, searchObject.ErrorMessage, searchObject.ValidateType, searchObject.ValidationData, searchObject.ValidateType2, searchObject.ValidationData2, searchObject.Id, searchObject.KeywordId, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all KeywordParams objects.
		/// </summary>
		/// <returns>List of all KeywordParams objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static KeywordParams[] Search()
		{
			return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region SEARCHEXACT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static KeywordParams[] SearchExact(System.String keyword, System.String name, System.String datatype, System.String mappedField, System.Int32? position, System.String errorMessage, System.String validateType, System.String validationData, System.String validateType2, System.String validationData2, System.Int32? id, System.Int32? keywordId, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].KeywordParams_SEARCHEXACT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, keyword, name, datatype, mappedField, position, errorMessage, validateType, validationData, validateType2, validationData2, id, keywordId, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return KeywordParams.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static KeywordParams[] SearchExact(KeywordParams searchObject)
		{
			return SearchExact ( searchObject.Keyword, searchObject.Name, searchObject.Datatype, searchObject.MappedField, searchObject.Position, searchObject.ErrorMessage, searchObject.ValidateType, searchObject.ValidationData, searchObject.ValidateType2, searchObject.ValidationData2, searchObject.Id, searchObject.KeywordId, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all KeywordParams objects.
		/// </summary>
		/// <returns>List of all KeywordParams objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static KeywordParams[] SearchExact()
		{
			return SearchExact ( null, null, null, null, null, null, null, null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region CUSTOMSELECT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static KeywordParams[] CustomSelect(System.String SqlQuery)
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
			return KeywordParams.MapFrom(ds);
	
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
	
