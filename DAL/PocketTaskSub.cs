using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:PocketTaskSub
	/// </summary>
	public partial class PocketTaskSub
	{
		public PocketTaskSub()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("subId", "PocketTaskSub"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int subId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PocketTaskSub");
			strSql.Append(" where subId=@subId");
			SqlParameter[] parameters = {
					new SqlParameter("@subId", SqlDbType.Int,4)
			};
			parameters[0].Value = subId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.PocketTaskSub model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PocketTaskSub(");
			strSql.Append("subTaskId,subUser,subInfo,examine)");
			strSql.Append(" values (");
			strSql.Append("@subTaskId,@subUser,@subInfo,@examine)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@subTaskId", SqlDbType.Int,4),
					new SqlParameter("@subUser", SqlDbType.VarChar,50),
					new SqlParameter("@subInfo", SqlDbType.Image),
					new SqlParameter("@examine", SqlDbType.VarChar,50)};
			parameters[0].Value = model.subTaskId;
			parameters[1].Value = model.subUser;
			parameters[2].Value = model.subInfo;
			parameters[3].Value = model.examine;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.PocketTaskSub model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PocketTaskSub set ");
			strSql.Append("subTaskId=@subTaskId,");
			strSql.Append("subUser=@subUser,");
			strSql.Append("subInfo=@subInfo,");
			strSql.Append("examine=@examine");
			strSql.Append(" where subId=@subId");
			SqlParameter[] parameters = {
					new SqlParameter("@subTaskId", SqlDbType.Int,4),
					new SqlParameter("@subUser", SqlDbType.VarChar,50),
					new SqlParameter("@subInfo", SqlDbType.Image),
					new SqlParameter("@examine", SqlDbType.VarChar,50),
					new SqlParameter("@subId", SqlDbType.Int,4)};
			parameters[0].Value = model.subTaskId;
			parameters[1].Value = model.subUser;
			parameters[2].Value = model.subInfo;
			parameters[3].Value = model.examine;
			parameters[4].Value = model.subId;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int subId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PocketTaskSub ");
			strSql.Append(" where subId=@subId");
			SqlParameter[] parameters = {
					new SqlParameter("@subId", SqlDbType.Int,4)
			};
			parameters[0].Value = subId;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string subIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PocketTaskSub ");
			strSql.Append(" where subId in ("+subIdlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.PocketTaskSub GetModel(int subId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 subId,subTaskId,subUser,subInfo,examine from PocketTaskSub ");
			strSql.Append(" where subId=@subId");
			SqlParameter[] parameters = {
					new SqlParameter("@subId", SqlDbType.Int,4)
			};
			parameters[0].Value = subId;

			Maticsoft.Model.PocketTaskSub model=new Maticsoft.Model.PocketTaskSub();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.PocketTaskSub DataRowToModel(DataRow row)
		{
			Maticsoft.Model.PocketTaskSub model=new Maticsoft.Model.PocketTaskSub();
			if (row != null)
			{
				if(row["subId"]!=null && row["subId"].ToString()!="")
				{
					model.subId=int.Parse(row["subId"].ToString());
				}
				if(row["subTaskId"]!=null && row["subTaskId"].ToString()!="")
				{
					model.subTaskId=int.Parse(row["subTaskId"].ToString());
				}
				if(row["subUser"]!=null)
				{
					model.subUser=row["subUser"].ToString();
				}
				if(row["subInfo"]!=null && row["subInfo"].ToString()!="")
				{
					model.subInfo=(byte[])row["subInfo"];
				}
				if(row["examine"]!=null)
				{
					model.examine=row["examine"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select subId,subTaskId,subUser,subInfo,examine ");
			strSql.Append(" FROM PocketTaskSub ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" subId,subTaskId,subUser,subInfo,examine ");
			strSql.Append(" FROM PocketTaskSub ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM PocketTaskSub ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.subId desc");
			}
			strSql.Append(")AS Row, T.*  from PocketTaskSub T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "PocketTaskSub";
			parameters[1].Value = "subId";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

