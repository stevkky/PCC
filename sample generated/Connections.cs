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
/// Data Access Layer Class for the [dbo].[connections] Database Table
/// Business Logic to Access this Class will be in the Connections_Bll.cs file
/// All Business Logic should be therefore be Placed in that file
/// </summary>

namespace testingGen
{
	[DataObject]
	[Serializable]
	public partial class Connections
	{
	
	
		#region Constants
		private static readonly string TABLE_NAME = "[dbo].[connections]";
	
		#endregion
	
	
		#region Fields
		private System.Int32? _id;
		private System.String _name;
		private System.String _dbType;
		private System.String _host;
		private System.String _username;
		private System.String _password;
		private System.String _dbase;
		private System.String _socket;
		private System.Int32? _port;
		private System.String _description;
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
		
		public System.String DbType
		{
			get
			{
				return _dbType;
			}
			set
			{
				_dbType = value;
			}
		}
		
		public System.String Host
		{
			get
			{
				return _host;
			}
			set
			{
				_host = value;
			}
		}
		
		public System.String Username
		{
			get
			{
				return _username;
			}
			set
			{
				_username = value;
			}
		}
		
		public System.String Password
		{
			get
			{
				return _password;
			}
			set
			{
				_password = value;
			}
		}
		
		public System.String Dbase
		{
			get
			{
				return _dbase;
			}
			set
			{
				_dbase = value;
			}
		}
		
		public System.String Socket
		{
			get
			{
				return _socket;
			}
			set
			{
				_socket = value;
			}
		}
		
		public System.Int32? Port
		{
			get
			{
				return _port;
			}
			set
			{
				_port = value;
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
			ds.Tables[TABLE_NAME].Columns.Add("name", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("db_type", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("host", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("username", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("password", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("dbase", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("socket", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("port", typeof(System.Int32) );
			ds.Tables[TABLE_NAME].Columns.Add("description", typeof(System.String) );
	
			dr = ds.Tables[TABLE_NAME].NewRow();
	
			if (Id == null)
				dr["ID"] = DBNull.Value;
			else
				dr["ID"] = Id;
	
			if (Name == null)
				dr["name"] = DBNull.Value;
			else
				dr["name"] = Name;
	
			if (DbType == null)
				dr["db_type"] = DBNull.Value;
			else
				dr["db_type"] = DbType;
	
			if (Host == null)
				dr["host"] = DBNull.Value;
			else
				dr["host"] = Host;
	
			if (Username == null)
				dr["username"] = DBNull.Value;
			else
				dr["username"] = Username;
	
			if (Password == null)
				dr["password"] = DBNull.Value;
			else
				dr["password"] = Password;
	
			if (Dbase == null)
				dr["dbase"] = DBNull.Value;
			else
				dr["dbase"] = Dbase;
	
			if (Socket == null)
				dr["socket"] = DBNull.Value;
			else
				dr["socket"] = Socket;
	
			if (Port == null)
				dr["port"] = DBNull.Value;
			else
				dr["port"] = Port;
	
			if (Description == null)
				dr["description"] = DBNull.Value;
			else
				dr["description"] = Description;
	
	
			ds.Tables[TABLE_NAME].Rows.Add(dr);
	
		}
	
		protected void MapFrom(DataRow dr)
		{
			Id = dr["ID"] != DBNull.Value ? Convert.ToInt32(dr["ID"]) : Id = null;
			Name = dr["name"] != DBNull.Value ? Convert.ToString(dr["name"]) : Name = null;
			DbType = dr["db_type"] != DBNull.Value ? Convert.ToString(dr["db_type"]) : DbType = null;
			Host = dr["host"] != DBNull.Value ? Convert.ToString(dr["host"]) : Host = null;
			Username = dr["username"] != DBNull.Value ? Convert.ToString(dr["username"]) : Username = null;
			Password = dr["password"] != DBNull.Value ? Convert.ToString(dr["password"]) : Password = null;
			Dbase = dr["dbase"] != DBNull.Value ? Convert.ToString(dr["dbase"]) : Dbase = null;
			Socket = dr["socket"] != DBNull.Value ? Convert.ToString(dr["socket"]) : Socket = null;
			Port = dr["port"] != DBNull.Value ? Convert.ToInt32(dr["port"]) : Port = null;
			Description = dr["description"] != DBNull.Value ? Convert.ToString(dr["description"]) : Description = null;
		}
	
		public static Connections[] MapFrom(DataSet ds)
		{
			List<Connections> objects;
	
	
			// Initialise Collection.
			objects = new List<Connections>();
	
			// Validation.
			if (ds == null)
				throw new ApplicationException("Cannot map to dataset null.");
			else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
				return objects.ToArray();
	
			if (ds.Tables[TABLE_NAME] == null)
				throw new ApplicationException("Cannot find table [dbo].[connections] in DataSet.");
	
			if (ds.Tables[TABLE_NAME].Rows.Count < 1)
				throw new ApplicationException("Table [dbo].[connections] is empty.");
	
			// Map DataSet to Instance.
			foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
			{
				Connections instance = new Connections();
				instance.MapFrom(dr);
				objects.Add(instance);
			}
	
			// Return collection.
			return objects.ToArray();
		}
	
	
		#endregion
	
	
		#region CRUD Methods
	
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Connections Get(System.Int32 id)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
			Connections instance;
	
	
			instance = new Connections();
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Connections_SELECT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id);
	
			// Get results.
			ds = db.ExecuteDataSet(dbCommand);
			// Verification.
			if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get Connections ID:" + id.ToString()+ " from Database.");
			// Return results.
			ds.Tables[0].TableName = TABLE_NAME;
	
			instance.MapFrom( ds.Tables[0].Rows[0] );
			return instance;
		}
	
		#region INSERT
		public void Insert(System.String name, System.String dbType, System.String host, System.String username, System.String password, System.String dbase, System.String socket, System.Int32? port, System.String description, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Connections_INSERT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, name, dbType, host, username, password, dbase, socket, port, description);
	
			if (transaction == null)
				this.Id = Convert.ToInt32(db.ExecuteScalar(dbCommand));
			else
				this.Id = Convert.ToInt32(db.ExecuteScalar(dbCommand, transaction));
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
		public void Insert(System.String name, System.String dbType, System.String host, System.String username, System.String password, System.String dbase, System.String socket, System.Int32? port, System.String description)
		{
			Insert(name, dbType, host, username, password, dbase, socket, port, description, null);
		}
	/// <summary>
	/// Insert current Connections to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Insert(DbTransaction transaction)
		{
			Insert(Name, DbType, Host, Username, Password, Dbase, Socket, Port, Description, transaction);
		}
	
	/// <summary>
	/// Insert current Connections to database.
	/// </summary>
		public void Insert()
		{
			this.Insert((DbTransaction)null);
		}
		#endregion
	
	
		#region UPDATE
		public static void Update(System.Int32? id, System.String name, System.String dbType, System.String host, System.String username, System.String password, System.String dbase, System.String socket, System.Int32? port, System.String description, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Connections_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@id"].Value = id;
			dbCommand.Parameters["@name"].Value = name;
			dbCommand.Parameters["@dbType"].Value = dbType;
			dbCommand.Parameters["@host"].Value = host;
			dbCommand.Parameters["@username"].Value = username;
			dbCommand.Parameters["@password"].Value = password;
			dbCommand.Parameters["@dbase"].Value = dbase;
			dbCommand.Parameters["@socket"].Value = socket;
			dbCommand.Parameters["@port"].Value = port;
			dbCommand.Parameters["@description"].Value = description;
	
			if (transaction == null)
				db.ExecuteNonQuery(dbCommand);
			else
				db.ExecuteNonQuery(dbCommand, transaction);
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
		public static void Update(System.Int32? id, System.String name, System.String dbType, System.String host, System.String username, System.String password, System.String dbase, System.String socket, System.Int32? port, System.String description)
		{
			Update(id, name, dbType, host, username, password, dbase, socket, port, description, null);
		}
	
	public static void Update(Connections connections)
	{
	connections.Update();
	}
	
	public static void Update(Connections connections, DbTransaction transaction)
	{
	connections.Update(transaction);
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
			sqlCommand = "[dbo].Connections_UPDATE";
			dbCommand = db.GetStoredProcCommand(sqlCommand);
			db.DiscoverParameters(dbCommand);
			dbCommand.Parameters["@id"].SourceColumn = "ID";
			dbCommand.Parameters["@name"].SourceColumn = "name";
			dbCommand.Parameters["@dbType"].SourceColumn = "db_type";
			dbCommand.Parameters["@host"].SourceColumn = "host";
			dbCommand.Parameters["@username"].SourceColumn = "username";
			dbCommand.Parameters["@password"].SourceColumn = "password";
			dbCommand.Parameters["@dbase"].SourceColumn = "dbase";
			dbCommand.Parameters["@socket"].SourceColumn = "socket";
			dbCommand.Parameters["@port"].SourceColumn = "port";
			dbCommand.Parameters["@description"].SourceColumn = "description";
	
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
			sqlCommand = "[dbo].Connections_DELETE";
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
	/// Delete current Connections from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Delete(DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Connections_DELETE";
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
	/// Delete current Connections from database.
	/// </summary>
		public void Delete()
	{
	this.Delete((DbTransaction)null);
	}
	
		#endregion
	
	
		#region SEARCH
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Connections[] Search(System.Int32? id, System.String name, System.String dbType, System.String host, System.String username, System.String password, System.String dbase, System.String socket, System.Int32? port, System.String description, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Connections_SEARCH";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id, name, dbType, host, username, password, dbase, socket, port, description, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return Connections.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static Connections[] Search(Connections searchObject)
		{
			return Search ( searchObject.Id, searchObject.Name, searchObject.DbType, searchObject.Host, searchObject.Username, searchObject.Password, searchObject.Dbase, searchObject.Socket, searchObject.Port, searchObject.Description, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all Connections objects.
		/// </summary>
		/// <returns>List of all Connections objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static Connections[] Search()
		{
			return Search ( null, null, null, null, null, null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region SEARCHEXACT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Connections[] SearchExact(System.Int32? id, System.String name, System.String dbType, System.String host, System.String username, System.String password, System.String dbase, System.String socket, System.Int32? port, System.String description, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Connections_SEARCHEXACT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id, name, dbType, host, username, password, dbase, socket, port, description, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return Connections.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static Connections[] SearchExact(Connections searchObject)
		{
			return SearchExact ( searchObject.Id, searchObject.Name, searchObject.DbType, searchObject.Host, searchObject.Username, searchObject.Password, searchObject.Dbase, searchObject.Socket, searchObject.Port, searchObject.Description, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all Connections objects.
		/// </summary>
		/// <returns>List of all Connections objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static Connections[] SearchExact()
		{
			return SearchExact ( null, null, null, null, null, null, null, null, null, null, null);
		}
	
		#endregion
	
	
		#region CUSTOMSELECT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Connections[] CustomSelect(System.String SqlQuery)
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
			return Connections.MapFrom(ds);
	
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
	
