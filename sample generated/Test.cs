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
/// Data Access Layer Class for the [dbo].[test] Database Table
/// Business Logic to Access this Class will be in the Test_Bll.cs file
/// All Business Logic should be therefore be Placed in that file
/// </summary>

namespace testingGen
{
	[DataObject]
	[Serializable]
	public partial class Test
	{
	
	
		#region Constants
		private static readonly string TABLE_NAME = "[dbo].[test]";
	
		#endregion
	
	
		#region Fields
		private System.String _id;
		private System.String _name;
		private System.String _subject;
		private System.String _grade;
		private System.String _ORDERBY_FIELD;
	
		#endregion
	
	
		#region Properties
		public System.String Id
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
		
		public System.String Subject
		{
			get
			{
				return _subject;
			}
			set
			{
				_subject = value;
			}
		}
		
		public System.String Grade
		{
			get
			{
				return _grade;
			}
			set
			{
				_grade = value;
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
	
			ds.Tables[TABLE_NAME].Columns.Add("ID", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("Name", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("Subject", typeof(System.String) );
			ds.Tables[TABLE_NAME].Columns.Add("Grade", typeof(System.String) );
	
			dr = ds.Tables[TABLE_NAME].NewRow();
	
			if (Id == null)
				dr["ID"] = DBNull.Value;
			else
				dr["ID"] = Id;
	
			if (Name == null)
				dr["Name"] = DBNull.Value;
			else
				dr["Name"] = Name;
	
			if (Subject == null)
				dr["Subject"] = DBNull.Value;
			else
				dr["Subject"] = Subject;
	
			if (Grade == null)
				dr["Grade"] = DBNull.Value;
			else
				dr["Grade"] = Grade;
	
	
			ds.Tables[TABLE_NAME].Rows.Add(dr);
	
		}
	
		protected void MapFrom(DataRow dr)
		{
			Id = dr["ID"] != DBNull.Value ? Convert.ToString(dr["ID"]) : Id = null;
			Name = dr["Name"] != DBNull.Value ? Convert.ToString(dr["Name"]) : Name = null;
			Subject = dr["Subject"] != DBNull.Value ? Convert.ToString(dr["Subject"]) : Subject = null;
			Grade = dr["Grade"] != DBNull.Value ? Convert.ToString(dr["Grade"]) : Grade = null;
		}
	
		public static Test[] MapFrom(DataSet ds)
		{
			List<Test> objects;
	
	
			// Initialise Collection.
			objects = new List<Test>();
	
			// Validation.
			if (ds == null)
				throw new ApplicationException("Cannot map to dataset null.");
			else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
				return objects.ToArray();
	
			if (ds.Tables[TABLE_NAME] == null)
				throw new ApplicationException("Cannot find table [dbo].[test] in DataSet.");
	
			if (ds.Tables[TABLE_NAME].Rows.Count < 1)
				throw new ApplicationException("Table [dbo].[test] is empty.");
	
			// Map DataSet to Instance.
			foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
			{
				Test instance = new Test();
				instance.MapFrom(dr);
				objects.Add(instance);
			}
	
			// Return collection.
			return objects.ToArray();
		}
	
	
		#endregion
	
	
		#region CRUD Methods
	
	
		#region INSERT
		public void Insert(System.String id, System.String name, System.String subject, System.String grade, DbTransaction transaction)
		{
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Test_INSERT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id, name, subject, grade);
	
			if (transaction == null)
				db.ExecuteScalar(dbCommand);
			else
				db.ExecuteScalar(dbCommand, transaction);
			return;
		}
	
		[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
		public void Insert(System.String id, System.String name, System.String subject, System.String grade)
		{
			Insert(id, name, subject, grade, null);
		}
	/// <summary>
	/// Insert current Test to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
		public void Insert(DbTransaction transaction)
		{
			Insert(Id, Name, Subject, Grade, transaction);
		}
	
	/// <summary>
	/// Insert current Test to database.
	/// </summary>
		public void Insert()
		{
			this.Insert((DbTransaction)null);
		}
		#endregion
	
	
	
	
		#region SEARCH
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Test[] Search(System.String id, System.String name, System.String subject, System.String grade, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Test_SEARCH";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id, name, subject, grade, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return Test.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static Test[] Search(Test searchObject)
		{
			return Search ( searchObject.Id, searchObject.Name, searchObject.Subject, searchObject.Grade, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all Test objects.
		/// </summary>
		/// <returns>List of all Test objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static Test[] Search()
		{
			return Search ( null, null, null, null, null);
		}
	
		#endregion
	
	
		#region SEARCHEXACT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Test[] SearchExact(System.String id, System.String name, System.String subject, System.String grade, System.String ORDERBY_FIELD)
		{
			DataSet ds;
			Database db;
			string sqlCommand;
			DbCommand dbCommand;
	
	
		 try
		 {
			db = MyDatabase.DB;
			sqlCommand = "[dbo].Test_SEARCHEXACT";
			dbCommand = db.GetStoredProcCommand(sqlCommand, id, name, subject, grade, ORDERBY_FIELD);
	
			ds = db.ExecuteDataSet(dbCommand);
			ds.Tables[0].TableName = TABLE_NAME;
			return Test.MapFrom(ds);
	
		 }
		 catch (Exception)
		 {
			 return null;
		 }

	}
	
	
		public static Test[] SearchExact(Test searchObject)
		{
			return SearchExact ( searchObject.Id, searchObject.Name, searchObject.Subject, searchObject.Grade, searchObject.ORDERBY_FIELD);
		}
	
		/// <summary>
		/// Returns all Test objects.
		/// </summary>
		/// <returns>List of all Test objects. </returns>
		[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
		public static Test[] SearchExact()
		{
			return SearchExact ( null, null, null, null, null);
		}
	
		#endregion
	
	
		#region CUSTOMSELECT
		[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
		public static Test[] CustomSelect(System.String SqlQuery)
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
			return Test.MapFrom(ds);
	
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
	
