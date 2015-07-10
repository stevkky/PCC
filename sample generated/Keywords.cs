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
/// Data Access Layer Class for the [dbo].[keywords] Database Table
/// Business Logic to Access this Class will be in the Keywords_Bll.cs file
/// All Business Logic should be therefore be Placed in that file
/// </summary>

namespace testingGen
{
	[DataObject]
	[Serializable]
	public partial class Keywords
	{
	
	
		#region Constants
		private static readonly string TABLE_NAME = "[dbo].[keywords]";
	
		#endregion
	
	
		#region Fields
		private System.String _keyword;
		private System.String _name;
		private System.Int32? _connection;
		private System.String _crudType;
		private System.String _queryType;
		private System.String _query;
		private System.String _errorMessage;
		private System.String _noResultMessage;
		private System.String _resultMessage;
		private System.Int32? _preprocessModifId;
		private System.Int32? _postprocessModifId;
		private System.String _parentKeyword;
		private System.String _parentCallType;
		private System.String _comments;
		private System.Int32? _groupid;
		private System.Boolean? _status;
		private System.String _delimiter;
		private System.Boolean? _consecutiveAvailable;
		private System.String _textQualifier;
		private System.String _senderid;
		private System.Int32? _id;
		private System.Boolean? _enableQueue;
		private System.Boolean? _enableSchedule;
		private System.String _schedule;
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
		
		public System.Int32? Connection
		{
			get
			{
				return _connection;
			}
			set
			{
				_connection = value;
			}
		}
		
		public System.String CrudType
		{
			get
			{
				return _crudType;
			}
			set
			{
				_crudType = value;
			}
		}
		
		public System.String QueryType
		{
			get
			{
				return _queryType;
			}
			set
			{
				_queryType = value;
			}
		}
		
		public System.String Query
		{
			get
			{
				return _query;
			}
			set
			{
				_query = value;
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
		
		public System.String NoResultMessage
		{
			get
			{
				return _noResultMessage;
			}
			set
			{
				_noResultMessage = value;
			}
		}
		
		public System.String ResultMessage
		{
			get
			{
				return _resultMessage;
			}
			set
			{
				_resultMessage = value;
			}
		}
		
		public System.Int32? PreprocessModifId
		{
			get
			{
				return _preprocessModifId;
			}
			set
			{
				_preprocessModifId = value;
			}
		}
		
		public System.Int32? PostprocessModifId
		{
			get
			{
				return _postprocessModifId;
			}
			set
			{
				_postprocessModifId = value;
			}
		}
		
		public System.String ParentKeyword
		{
			get
			{
				return _parentKeyword;
			}
			set
			{
				_parentKeyword = value;
			}
		}
		
		public System.String ParentCallType
		{
			get
			{
				return _parentCallType;
			}
			set
			{
				_parentCallType = value;
			}
		}
		
		public System.String Comments
		{
			get
			{
				return _comments;
			}
			set
			{
				_comments = value;
			}
		}
		
		public System.Int32? Groupid
		{
			get
			{
				return _groupid;
			}
			set
			{
				_groupid = value;
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
		
		public System.String Delimiter
		{
			get
			{
				return _delimiter;
			}
			set
			{
				_delimiter = value;
			}
		}
		
		public System.Boolean? ConsecutiveAvailable
		{
			get
			{
				return _consecutiveAvailable;
			}
			set
			{
				_consecutiveAvailable = value;
			}
		}
		
		public System.String TextQualifier
		{
			get
			{
				return _textQualifier;
			}
			set
			{
				_textQualifier = value;
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
		
		public System.Boolean? EnableQueue
		{
			get
			{
				return _enableQueue;
			}
			set
			{
				_enableQueue = value;
			}
		}
		
		public System.Boolean? EnableSchedule
		{
			get
			{
				return _enableSchedule;
			}
			set
			{
				_enableSchedule = value;
			}
		}
		
		public System.String Schedule
		{
			get
			{
				return _schedule;
			}
			set
			{
				_schedule = value;
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
	
			ds.Tables[TABLE_NAME].Columns.Add("Keyword", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("name", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("connection", typeof(System.Int32) );
			ds.Tables[TABLE_NAME].Columns.Add("crud_type", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("query_type", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("query", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("error_message", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("no_result_message", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("result_message", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("preprocess_modif_id", typeof(System.Int32) );
			ds.Tables[TABLE_NAME].Columns.Add("postprocess_modif_id", typeof(System.Int32) );
			ds.Tables[TABLE_NAME].Columns.Add("parent_keyword", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("parent_call_type", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("comments", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("groupid", typeof(System.Int32) );
			ds.Tables[TABLE_NAME].Columns.Add("status", typeof(System.Boolean) );
			ds.Tables[TABLE_NAME].Columns.Add("delimiter", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("Consecutive_available", typeof(System.Boolean) );
			ds.Tables[TABLE_NAME].Columns.Add("text_qualifier", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("senderid", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("id", typeof(System.Int32) );
			ds.Tables[TABLE_NAME].Columns.Add("enableQueue", typeof(System.Boolean) );
			ds.Tables[TABLE_NAME].Columns.Add("enableSchedule", typeof(System.Boolean) );
			ds.Tables[TABLE_NAME].Columns.Add("Schedule", typeof(System.String) );
	
			dr = ds.Tables[TABLE_NAME].NewRow();
	
			if (Keyword == null)
				dr["Keyword"] = DBNull.Value;
			else
				dr["Keyword"] = Keyword;
	
			if (Name == null)
				dr["name"] = DBNull.Value;
			else
				dr["name"] = Name;
	
			if (Connection == null)
				dr["connection"] = DBNull.Value;
			else
				dr["connection"] = Connection;
	
			if (CrudType == null)
				dr["crud_type"] = DBNull.Value;
			else
				dr["crud_type"] = CrudType;
	
			if (QueryType == null)
				dr["query_type"] = DBNull.Value;
			else
				dr["query_type"] = QueryType;
	
			if (Query == null)
				dr["query"] = DBNull.Value;
			else
				dr["query"] = Query;
	
			if (ErrorMessage == null)
				dr["error_message"] = DBNull.Value;
			else
				dr["error_message"] = ErrorMessage;
	
			if (NoResultMessage == null)
				dr["no_result_message"] = DBNull.Value;
			else
				dr["no_result_message"] = NoResultMessage;
	
			if (ResultMessage == null)
				dr["result_message"] = DBNull.Value;
			else
				dr["result_message"] = ResultMessage;
	
			if (PreprocessModifId == null)
				dr["preprocess_modif_id"] = DBNull.Value;
			else
				dr["preprocess_modif_id"] = PreprocessModifId;
	
			if (PostprocessModifId == null)
				dr["postprocess_modif_id"] = DBNull.Value;
			else
				dr["postprocess_modif_id"] = PostprocessModifId;
	
			if (ParentKeyword == null)
				dr["parent_keyword"] = DBNull.Value;
			else
				dr["parent_keyword"] = ParentKeyword;
	
			if (ParentCallType == null)
				dr["parent_call_type"] = DBNull.Value;
			else
				dr["parent_call_type"] = ParentCallType;
	
			if (Comments == null)
				dr["comments"] = DBNull.Value;
			else
				dr["comments"] = Comments;
	
			if (Groupid == null)
				dr["groupid"] = DBNull.Value;
			else
				dr["groupid"] = Groupid;
	
			if (Status == null)
				dr["status"] = DBNull.Value;
			else
				dr["status"] = Status;
	
			if (Delimiter == null)
				dr["delimiter"] = DBNull.Value;
			else
				dr["delimiter"] = Delimiter;
	
			if (ConsecutiveAvailable == null)
				dr["Consecutive_available"] = DBNull.Value;
			else
				dr["Consecutive_available"] = ConsecutiveAvailable;
	
			if (TextQualifier == null)
				dr["text_qualifier"] = DBNull.Value;
			else
				dr["text_qualifier"] = TextQualifier;
	
			if (Senderid == null)
				dr["senderid"] = DBNull.Value;
			else
				dr["senderid"] = Senderid;
	
			if (Id == null)
				dr["id"] = DBNull.Value;
			else
				dr["id"] = Id;
	
			if (EnableQueue == null)
				dr["enableQueue"] = DBNull.Value;
			else
				dr["enableQueue"] = EnableQueue;
	
			if (EnableSchedule == null)
				dr["enableSchedule"] = DBNull.Value;
			else
				dr["enableSchedule"] = EnableSchedule;
	
			if (Schedule == null)
				dr["Schedule"] = DBNull.Value;
			else
				dr["Schedule"] = Schedule;
	
	
			ds.Tables[TABLE_NAME].Rows.Add(dr);
	
		}
	
		protected void MapFrom(DataRow dr)
		{
			Keyword = dr["Keyword"] != DBNull.Value ? Convert.ToString(dr["Keyword"]) : Keyword = null;
			Name = dr["name"] != DBNull.Value ? Convert.ToString(dr["name"]) : Name = null;
			Connection = dr["connection"] != DBNull.Value ? Convert.ToInt32(dr["connection"]) : Connection = null;
			CrudType = dr["crud_type"] != DBNull.Value ? Convert.ToString(dr["crud_type"]) : CrudType = null;
			QueryType = dr["query_type"] != DBNull.Value ? Convert.ToString(dr["query_type"]) : QueryType = null;
			Query = dr["query"] != DBNull.Value ? Convert.ToString(dr["query"]) : Query = null;
			ErrorMessage = dr["error_message"] != DBNull.Value ? Convert.ToString(dr["error_message"]) : ErrorMessage = null;
			NoResultMessage = dr["no_result_message"] != DBNull.Value ? Convert.ToString(dr["no_result_message"]) : NoResultMessage = null;
			ResultMessage = dr["result_message"] != DBNull.Value ? Convert.ToString(dr["result_message"]) : ResultMessage = null;
			PreprocessModifId = dr["preprocess_modif_id"] != DBNull.Value ? Convert.ToInt32(dr["preprocess_modif_id"]) : PreprocessModifId = null;
			PostprocessModifId = dr["postprocess_modif_id"] != DBNull.Value ? Convert.ToInt32(dr["postprocess_modif_id"]) : PostprocessModifId = null;
			ParentKeyword = dr["parent_keyword"] != DBNull.Value ? Convert.ToString(dr["parent_keyword"]) : ParentKeyword = null;
			ParentCallType = dr["parent_call_type"] != DBNull.Value ? Convert.ToString(dr["parent_call_type"]) : ParentCallType = null;
			Comments = dr["comments"] != DBNull.Value ? Convert.ToString(dr["comments"]) : Comments = null;
			Groupid = dr["groupid"] != DBNull.Value ? Convert.ToInt32(dr["groupid"]) : Groupid = null;
			Status = dr["status"] != DBNull.Value ? Convert.ToBoolean(dr["status"]) : Status = null;
			Delimiter = dr["delimiter"] != DBNull.Value ? Convert.ToString(dr["delimiter"]) : Delimiter = null;
			ConsecutiveAvailable = dr["Consecutive_available"] != DBNull.Value ? Convert.ToBoolean(dr["Consecutive_available"]) : ConsecutiveAvailable = null;
			TextQualifier = dr["text_qualifier"] != DBNull.Value ? Convert.ToString(dr["text_qualifier"]) : TextQualifier = null;
			Senderid = dr["senderid"] != DBNull.Value ? Convert.ToString(dr["senderid"]) : Senderid = null;
			Id = dr["id"] != DBNull.Value ? Convert.ToInt32(dr["id"]) : Id = null;
			EnableQueue = dr["enableQueue"] != DBNull.Value ? Convert.ToBoolean(dr["enableQueue"]) : EnableQueue = null;
			EnableSchedule = dr["enableSchedule"] != DBNull.Value ? Convert.ToBoolean(dr["enableSchedule"]) : EnableSchedule = null;
			Schedule = dr["Schedule"] != DBNull.Value ? Convert.ToString(dr["Schedule"]) : Schedule = null;
		}
	
		public static Keywords[] MapFrom(DataSet ds)
		{
			List<Keywords> objects;
	
	
			// Initialise Collection.
			objects = new List<Keywords>();
	
			// Validation.
			if (ds == null)
				throw new ApplicationException("Cannot map to dataset null.");
			else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
				return objects.ToArray();
	
			if (ds.Tables[TABLE_NAME] == null)
				throw new ApplicationException("Cannot find table [dbo].[keywords] in DataSet.");
	
			if (ds.Tables[TABLE_NAME].Rows.Count < 1)
				throw new ApplicationException("Table [dbo].[keywords] is empty.");
	
			// Map DataSet to Instance.
			foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
			{
				Keywords instance = new Keywords();
				instance.MapFrom(dr);
				objects.Add(instance);
			}
	
			// Return collection.
			return objects.ToArray();
		}
	
	
		#endregion
	
	
		#region CRUD Methods
	
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Keywords Get(System.Int32 id)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
			Keywords instance;
	
	
			instance = new Keywords();
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Keywords_SELECT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id);
	
			// Get results.
			ds = db.ExecuteDataSet(dbCommand);
			// Verification.
			if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get Keywords ID:" + id.ToString()+ " from Database.");
			// Return results.
			ds.Tables[0].TableName = TABLE_NAME;
	
			instance.MapFrom( ds.Tables[0].Rows[0] );
			return instance;
		}
	
		#region INSERT
		public void Insert(System.String keyword, System.String name, System.Int32? connection, System.String crudType, System.String queryType, System.String query, System.String errorMessage, System.String noResultMessage, System.String resultMessage, System.Int32? preprocessModifId, System.Int32? postprocessModifId, System.String parentKeyword, System.String parentCallType, System.String comments, System.Int32? groupid, System.Boolean? status, System.String delimiter, System.Boolean? consecutiveAvailable, System.String textQualifier, System.String senderid, System.Boolean? enableQueue, System.Boolean? enableSchedule, System.String schedule, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Keywords_INSERT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, keyword, name, connection, crudType, queryType, query, errorMessage, noResultMessage, resultMessage, preprocessModifId, postprocessModifId, parentKeyword, parentCallType, comments, groupid, status, delimiter, consecutiveAvailable, textQualifier, senderid, enableQueue, enableSchedule, schedule);
	
			if (transaction == null)
				this.Id = Convert.ToInt32(db.ExecuteScalar(dbCommand));
			else
				this.Id = Convert.ToInt32(db.ExecuteScalar(dbCommand, transaction));
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
		public void Insert(System.String keyword, System.String name, System.Int32? connection, System.String crudType, System.String queryType, System.String query, System.String errorMessage, System.String noResultMessage, System.String resultMessage, System.Int32? preprocessModifId, System.Int32? postprocessModifId, System.String parentKeyword, System.String parentCallType, System.String comments, System.Int32? groupid, System.Boolean? status, System.String delimiter, System.Boolean? consecutiveAvailable, System.String textQualifier, System.String senderid, System.Boolean? enableQueue, System.Boolean? enableSchedule, System.String schedule)
		{
			Insert(keyword, name, connection, crudType, queryType, query, errorMessage, noResultMessage, resultMessage, preprocessModifId, postprocessModifId, parentKeyword, parentCallType, comments, groupid, status, delimiter, consecutiveAvailable, textQualifier, senderid, enableQueue, enableSchedule, schedule, null);
		}
	/// <summary>
	/// Insert current Keywords to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Insert(DbTransaction transaction)
		{
			Insert(Keyword, Name, Connection, CrudType, QueryType, Query, ErrorMessage, NoResultMessage, ResultMessage, PreprocessModifId, PostprocessModifId, ParentKeyword, ParentCallType, Comments, Groupid, Status, Delimiter, ConsecutiveAvailable, TextQualifier, Senderid, EnableQueue, EnableSchedule, Schedule, transaction);
		}
	
	/// <summary>
	/// Insert current Keywords to database.
	/// </summary>
		public void Insert()
		{
			this.Insert((DbTransaction)null);
		}
		#endregion
	
	
		#region UPDATE
		public static void Update(System.String keyword, System.String name, System.Int32? connection, System.String crudType, System.String queryType, System.String query, System.String errorMessage, System.String noResultMessage, System.String resultMessage, System.Int32? preprocessModifId, System.Int32? postprocessModifId, System.String parentKeyword, System.String parentCallType, System.String comments, System.Int32? groupid, System.Boolean? status, System.String delimiter, System.Boolean? consecutiveAvailable, System.String textQualifier, System.String senderid, System.Int32? id, System.Boolean? enableQueue, System.Boolean? enableSchedule, System.String schedule, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Keywords_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@keyword"].Value = keyword;
			dbCommand.Parameters["@name"].Value = name;
			dbCommand.Parameters["@connection"].Value = connection;
			dbCommand.Parameters["@crudType"].Value = crudType;
			dbCommand.Parameters["@queryType"].Value = queryType;
			dbCommand.Parameters["@query"].Value = query;
			dbCommand.Parameters["@errorMessage"].Value = errorMessage;
			dbCommand.Parameters["@noResultMessage"].Value = noResultMessage;
			dbCommand.Parameters["@resultMessage"].Value = resultMessage;
			dbCommand.Parameters["@preprocessModifId"].Value = preprocessModifId;
			dbCommand.Parameters["@postprocessModifId"].Value = postprocessModifId;
			dbCommand.Parameters["@parentKeyword"].Value = parentKeyword;
			dbCommand.Parameters["@parentCallType"].Value = parentCallType;
			dbCommand.Parameters["@comments"].Value = comments;
			dbCommand.Parameters["@groupid"].Value = groupid;
			dbCommand.Parameters["@status"].Value = status;
			dbCommand.Parameters["@delimiter"].Value = delimiter;
			dbCommand.Parameters["@consecutiveAvailable"].Value = consecutiveAvailable;
			dbCommand.Parameters["@textQualifier"].Value = textQualifier;
			dbCommand.Parameters["@senderid"].Value = senderid;
			dbCommand.Parameters["@id"].Value = id;
			dbCommand.Parameters["@enableQueue"].Value = enableQueue;
			dbCommand.Parameters["@enableSchedule"].Value = enableSchedule;
			dbCommand.Parameters["@schedule"].Value = schedule;
	
			if (transaction == null)
				db.ExecuteNonQuery(dbCommand);
			else
				db.ExecuteNonQuery(dbCommand, transaction);
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
		public static void Update(System.String keyword, System.String name, System.Int32? connection, System.String crudType, System.String queryType, System.String query, System.String errorMessage, System.String noResultMessage, System.String resultMessage, System.Int32? preprocessModifId, System.Int32? postprocessModifId, System.String parentKeyword, System.String parentCallType, System.String comments, System.Int32? groupid, System.Boolean? status, System.String delimiter, System.Boolean? consecutiveAvailable, System.String textQualifier, System.String senderid, System.Int32? id, System.Boolean? enableQueue, System.Boolean? enableSchedule, System.String schedule)
		{
			Update(keyword, name, connection, crudType, queryType, query, errorMessage, noResultMessage, resultMessage, preprocessModifId, postprocessModifId, parentKeyword, parentCallType, comments, groupid, status, delimiter, consecutiveAvailable, textQualifier, senderid, id, enableQueue, enableSchedule, schedule, null);
		}
	
	public static void Update(Keywords keywords)
	{
	keywords.Update();
	}
	
	public static void Update(Keywords keywords, DbTransaction transaction)
	{
	keywords.Update(transaction);
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
			sqlCommand = "[dbo].Keywords_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@keyword"].SourceColumn = "Keyword";
			dbCommand.Parameters["@name"].SourceColumn = "name";
			dbCommand.Parameters["@connection"].SourceColumn = "connection";
			dbCommand.Parameters["@crudType"].SourceColumn = "crud_type";
			dbCommand.Parameters["@queryType"].SourceColumn = "query_type";
			dbCommand.Parameters["@query"].SourceColumn = "query";
			dbCommand.Parameters["@errorMessage"].SourceColumn = "error_message";
			dbCommand.Parameters["@noResultMessage"].SourceColumn = "no_result_message";
			dbCommand.Parameters["@resultMessage"].SourceColumn = "result_message";
			dbCommand.Parameters["@preprocessModifId"].SourceColumn = "preprocess_modif_id";
			dbCommand.Parameters["@postprocessModifId"].SourceColumn = "postprocess_modif_id";
			dbCommand.Parameters["@parentKeyword"].SourceColumn = "parent_keyword";
			dbCommand.Parameters["@parentCallType"].SourceColumn = "parent_call_type";
			dbCommand.Parameters["@comments"].SourceColumn = "comments";
			dbCommand.Parameters["@groupid"].SourceColumn = "groupid";
			dbCommand.Parameters["@status"].SourceColumn = "status";
			dbCommand.Parameters["@delimiter"].SourceColumn = "delimiter";
			dbCommand.Parameters["@consecutiveAvailable"].SourceColumn = "Consecutive_available";
			dbCommand.Parameters["@textQualifier"].SourceColumn = "text_qualifier";
			dbCommand.Parameters["@senderid"].SourceColumn = "senderid";
			dbCommand.Parameters["@id"].SourceColumn = "id";
			dbCommand.Parameters["@enableQueue"].SourceColumn = "enableQueue";
			dbCommand.Parameters["@enableSchedule"].SourceColumn = "enableSchedule";
			dbCommand.Parameters["@schedule"].SourceColumn = "Schedule";
	
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
			sqlCommand = "[dbo].Keywords_DELETE";
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
	/// Delete current Keywords from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Delete(DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Keywords_DELETE";
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
	/// Delete current Keywords from database.
	/// </summary>
		public void Delete()
	{
	this.Delete((DbTransaction)null);
	}
	
		#endregion
	
	
		#region SEARCH
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Keywords[] Search(System.String keyword, System.String name, System.Int32? connection, System.String crudType, System.String queryType, System.String query, System.String errorMessage, System.String noResultMessage, System.String resultMessage, System.Int32? preprocessModifId, System.Int32? postprocessModifId, System.String parentKeyword, System.String parentCallType, System.String comments, System.Int32? groupid, System.Boolean? status, System.String delimiter, System.Boolean? consecutiveAvailable, System.String textQualifier, System.String senderid, System.Int32? id, System.Boolean? enableQueue, System.Boolean? enableSchedule, System.String schedule, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Keywords_SEARCH";
			dbCommand = db.GetStoredProcCommand(sqlCommand, keyword, name, connection, crudType, queryType, query, errorMessage, noResultMessage, resultMessage, preprocessModifId, postprocessModifId, parentKeyword, parentCallType, comments, groupid, status, delimiter, consecutiveAvailable, textQualifier, senderid, id, enableQueue, enableSchedule, schedule, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return Keywords.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static Keywords[] Search(Keywords searchObject)
		{
			return Search ( searchObject.Keyword, searchObject.Name, searchObject.Connection, searchObject.CrudType, searchObject.QueryType, searchObject.Query, searchObject.ErrorMessage, searchObject.NoResultMessage, searchObject.ResultMessage, searchObject.PreprocessModifId, searchObject.PostprocessModifId, searchObject.ParentKeyword, searchObject.ParentCallType, searchObject.Comments, searchObject.Groupid, searchObject.Status, searchObject.Delimiter, searchObject.ConsecutiveAvailable, searchObject.TextQualifier, searchObject.Senderid, searchObject.Id, searchObject.EnableQueue, searchObject.EnableSchedule, searchObject.Schedule, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all Keywords objects.
		/// </summary>
		/// <returns>List of all Keywords objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static Keywords[] Search()
		{
			return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region SEARCHEXACT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Keywords[] SearchExact(System.String keyword, System.String name, System.Int32? connection, System.String crudType, System.String queryType, System.String query, System.String errorMessage, System.String noResultMessage, System.String resultMessage, System.Int32? preprocessModifId, System.Int32? postprocessModifId, System.String parentKeyword, System.String parentCallType, System.String comments, System.Int32? groupid, System.Boolean? status, System.String delimiter, System.Boolean? consecutiveAvailable, System.String textQualifier, System.String senderid, System.Int32? id, System.Boolean? enableQueue, System.Boolean? enableSchedule, System.String schedule, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Keywords_SEARCHEXACT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, keyword, name, connection, crudType, queryType, query, errorMessage, noResultMessage, resultMessage, preprocessModifId, postprocessModifId, parentKeyword, parentCallType, comments, groupid, status, delimiter, consecutiveAvailable, textQualifier, senderid, id, enableQueue, enableSchedule, schedule, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return Keywords.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static Keywords[] SearchExact(Keywords searchObject)
		{
			return SearchExact ( searchObject.Keyword, searchObject.Name, searchObject.Connection, searchObject.CrudType, searchObject.QueryType, searchObject.Query, searchObject.ErrorMessage, searchObject.NoResultMessage, searchObject.ResultMessage, searchObject.PreprocessModifId, searchObject.PostprocessModifId, searchObject.ParentKeyword, searchObject.ParentCallType, searchObject.Comments, searchObject.Groupid, searchObject.Status, searchObject.Delimiter, searchObject.ConsecutiveAvailable, searchObject.TextQualifier, searchObject.Senderid, searchObject.Id, searchObject.EnableQueue, searchObject.EnableSchedule, searchObject.Schedule, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all Keywords objects.
		/// </summary>
		/// <returns>List of all Keywords objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static Keywords[] SearchExact()
		{
			return SearchExact ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region CUSTOMSELECT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Keywords[] CustomSelect(System.String SqlQuery)
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
			return Keywords.MapFrom(ds);
	
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
	
