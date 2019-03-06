using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:PocketBalanceRecard
	/// </summary>
	public partial class PocketBalanceRecard
	{
		public PocketBalanceRecard()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("recardId", "PocketBalanceRecard"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int recardId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PocketBalanceRecard");
			strSql.Append(" where recardId=@recardId");
			SqlParameter[] parameters = {
					new SqlParameter("@recardId", SqlDbType.Int,4)
			};
			parameters[0].Value = recardId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.PocketBalanceRecard model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PocketBalanceRecard(");
			strSql.Append("recardUser,recardMoney,recardTime,recardState)");
			strSql.Append(" values (");
			strSql.Append("@recardUser,@recardMoney,@recardTime,@recardState)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@recardUser", SqlDbType.VarChar,50),
					new SqlParameter("@recardMoney", SqlDbType.Decimal,9),
					new SqlParameter("@recardTime", SqlDbType.DateTime),
					new SqlParameter("@recardState", SqlDbType.VarChar,50)};
			parameters[0].Value = model.recardUser;
			parameters[1].Value = model.recardMoney;
			parameters[2].Value = model.recardTime;
			parameters[3].Value = model.recardState;

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
		public bool Update(Maticsoft.Model.PocketBalanceRecard model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PocketBalanceRecard set ");
			strSql.Append("recardUser=@recardUser,");
			strSql.Append("recardMoney=@recardMoney,");
			strSql.Append("recardTime=@recardTime,");
			strSql.Append("recardState=@recardState");
			strSql.Append(" where recardId=@recardId");
			SqlParameter[] parameters = {
					new SqlParameter("@recardUser", SqlDbType.VarChar,50),
					new SqlParameter("@recardMoney", SqlDbType.Decimal,9),
					new SqlParameter("@recardTime", SqlDbType.DateTime),
					new SqlParameter("@recardState", SqlDbType.VarChar,50),
					new SqlParameter("@recardId", SqlDbType.Int,4)};
			parameters[0].Value = model.recardUser;
			parameters[1].Value = model.recardMoney;
			parameters[2].Value = model.recardTime;
			parameters[3].Value = model.recardState;
			parameters[4].Value = model.recardId;

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
		public bool Delete(int recardId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PocketBalanceRecard ");
			strSql.Append(" where recardId=@recardId");
			SqlParameter[] parameters = {
					new SqlParameter("@recardId", SqlDbType.Int,4)
			};
			parameters[0].Value = recardId;

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
		public bool DeleteList(string recardIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PocketBalanceRecard ");
			strSql.Append(" where recardId in ("+recardIdlist + ")  ");
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
		public Maticsoft.Model.PocketBalanceRecard GetModel(int recardId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 recardId,recardUser,recardMoney,recardTime,recardState from PocketBalanceRecard ");
			strSql.Append(" where recardId=@recardId");
			SqlParameter[] parameters = {
					new SqlParameter("@recardId", SqlDbType.Int,4)
			};
			parameters[0].Value = recardId;

			Maticsoft.Model.PocketBalanceRecard model=new Maticsoft.Model.PocketBalanceRecard();
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
		public Maticsoft.Model.PocketBalanceRecard DataRowToModel(DataRow row)
		{
			Maticsoft.Model.PocketBalanceRecard model=new Maticsoft.Model.PocketBalanceRecard();
			if (row != null)
			{
				if(row["recardId"]!=null && row["recardId"].ToString()!="")
				{
					model.recardId=int.Parse(row["recardId"].ToString());
				}
				if(row["recardUser"]!=null)
				{
					model.recardUser=row["recardUser"].ToString();
				}
				if(row["recardMoney"]!=null && row["recardMoney"].ToString()!="")
				{
					model.recardMoney=decimal.Parse(row["recardMoney"].ToString());
				}
				if(row["recardTime"]!=null && row["recardTime"].ToString()!="")
				{
					model.recardTime=DateTime.Parse(row["recardTime"].ToString());
				}
				if(row["recardState"]!=null)
				{
					model.recardState=row["recardState"].ToString();
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
			strSql.Append("select recardId,recardUser,recardMoney,recardTime,recardState ");
			strSql.Append(" FROM PocketBalanceRecard ");
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
			strSql.Append(" recardId,recardUser,recardMoney,recardTime,recardState ");
			strSql.Append(" FROM PocketBalanceRecard ");
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
			strSql.Append("select count(1) FROM PocketBalanceRecard ");
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
				strSql.Append("order by T.recardId desc");
			}
			strSql.Append(")AS Row, T.*  from PocketBalanceRecard T ");
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
			parameters[0].Value = "PocketBalanceRecard";
			parameters[1].Value = "recardId";
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

