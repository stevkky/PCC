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
/// Data Access Layer Class for the SqlDatabase
/// This class returns the SqlDatabase to be used by the Generated Classes
/// You have to modify it when necessary
/// </summary>

namespace testingGen
{
	public static class MyDatabase
	{
	
	
		#region SqlDatabase Property
		public static SqlDatabase DB 
		{
			get
			{
				return  new SqlDatabase("Data Source=STEVKKYS-BOX;Integrated Security=SSPI;Initial Catalog=bulksms_db");
			}
		}
		#endregion
	
	
	}
}

