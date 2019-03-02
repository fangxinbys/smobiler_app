using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:PocketTask
	/// </summary>
	public partial class PocketTask
	{
		public PocketTask()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("pocketTaskId", "PocketTask"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int pocketTaskId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PocketTask");
			strSql.Append(" where pocketTaskId=@pocketTaskId");
			SqlParameter[] parameters = {
					new SqlParameter("@pocketTaskId", SqlDbType.Int,4)
			};
			parameters[0].Value = pocketTaskId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.PocketTask model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PocketTask(");
			strSql.Append("pocketTaskInfo,pocketTaskNum,pocketTaskMoney,pocketTaskRule)");
			strSql.Append(" values (");
			strSql.Append("@pocketTaskInfo,@pocketTaskNum,@pocketTaskMoney,@pocketTaskRule)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@pocketTaskInfo", SqlDbType.VarChar,50),
					new SqlParameter("@pocketTaskNum", SqlDbType.Int,4),
					new SqlParameter("@pocketTaskMoney", SqlDbType.Int,4),
					new SqlParameter("@pocketTaskRule", SqlDbType.VarChar,50)};
			parameters[0].Value = model.pocketTaskInfo;
			parameters[1].Value = model.pocketTaskNum;
			parameters[2].Value = model.pocketTaskMoney;
			parameters[3].Value = model.pocketTaskRule;

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
		public bool Update(Maticsoft.Model.PocketTask model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PocketTask set ");
			strSql.Append("pocketTaskInfo=@pocketTaskInfo,");
			strSql.Append("pocketTaskNum=@pocketTaskNum,");
			strSql.Append("pocketTaskMoney=@pocketTaskMoney,");
			strSql.Append("pocketTaskRule=@pocketTaskRule");
			strSql.Append(" where pocketTaskId=@pocketTaskId");
			SqlParameter[] parameters = {
					new SqlParameter("@pocketTaskInfo", SqlDbType.VarChar,50),
					new SqlParameter("@pocketTaskNum", SqlDbType.Int,4),
					new SqlParameter("@pocketTaskMoney", SqlDbType.Int,4),
					new SqlParameter("@pocketTaskRule", SqlDbType.VarChar,50),
					new SqlParameter("@pocketTaskId", SqlDbType.Int,4)};
			parameters[0].Value = model.pocketTaskInfo;
			parameters[1].Value = model.pocketTaskNum;
			parameters[2].Value = model.pocketTaskMoney;
			parameters[3].Value = model.pocketTaskRule;
			parameters[4].Value = model.pocketTaskId;

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
		public bool Delete(int pocketTaskId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PocketTask ");
			strSql.Append(" where pocketTaskId=@pocketTaskId");
			SqlParameter[] parameters = {
					new SqlParameter("@pocketTaskId", SqlDbType.Int,4)
			};
			parameters[0].Value = pocketTaskId;

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
		public bool DeleteList(string pocketTaskIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PocketTask ");
			strSql.Append(" where pocketTaskId in ("+pocketTaskIdlist + ")  ");
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
		public Maticsoft.Model.PocketTask GetModel(int pocketTaskId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 pocketTaskId,pocketTaskInfo,pocketTaskNum,pocketTaskMoney,pocketTaskRule from PocketTask ");
			strSql.Append(" where pocketTaskId=@pocketTaskId");
			SqlParameter[] parameters = {
					new SqlParameter("@pocketTaskId", SqlDbType.Int,4)
			};
			parameters[0].Value = pocketTaskId;

			Maticsoft.Model.PocketTask model=new Maticsoft.Model.PocketTask();
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
		public Maticsoft.Model.PocketTask DataRowToModel(DataRow row)
		{
			Maticsoft.Model.PocketTask model=new Maticsoft.Model.PocketTask();
			if (row != null)
			{
				if(row["pocketTaskId"]!=null && row["pocketTaskId"].ToString()!="")
				{
					model.pocketTaskId=int.Parse(row["pocketTaskId"].ToString());
				}
				if(row["pocketTaskInfo"]!=null)
				{
					model.pocketTaskInfo=row["pocketTaskInfo"].ToString();
				}
				if(row["pocketTaskNum"]!=null && row["pocketTaskNum"].ToString()!="")
				{
					model.pocketTaskNum=int.Parse(row["pocketTaskNum"].ToString());
				}
				if(row["pocketTaskMoney"]!=null && row["pocketTaskMoney"].ToString()!="")
				{
					model.pocketTaskMoney=int.Parse(row["pocketTaskMoney"].ToString());
				}
				if(row["pocketTaskRule"]!=null)
				{
					model.pocketTaskRule=row["pocketTaskRule"].ToString();
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
			strSql.Append("select pocketTaskId,pocketTaskInfo,pocketTaskNum,pocketTaskMoney,pocketTaskRule ");
			strSql.Append(" FROM PocketTask ");
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
			strSql.Append(" pocketTaskId,pocketTaskInfo,pocketTaskNum,pocketTaskMoney,pocketTaskRule ");
			strSql.Append(" FROM PocketTask ");
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
			strSql.Append("select count(1) FROM PocketTask ");
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
				strSql.Append("order by T.pocketTaskId desc");
			}
			strSql.Append(")AS Row, T.*  from PocketTask T ");
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
			parameters[0].Value = "PocketTask";
			parameters[1].Value = "pocketTaskId";
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

