using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:PocketBalance
	/// </summary>
	public partial class PocketBalance
	{
		public PocketBalance()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("balanceId", "PocketBalance"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int balanceId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PocketBalance");
			strSql.Append(" where balanceId=@balanceId");
			SqlParameter[] parameters = {
					new SqlParameter("@balanceId", SqlDbType.Int,4)
			};
			parameters[0].Value = balanceId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.PocketBalance model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PocketBalance(");
			strSql.Append("balanceUser,balanceMoney,balanceTime)");
			strSql.Append(" values (");
			strSql.Append("@balanceUser,@balanceMoney,@balanceTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@balanceUser", SqlDbType.VarChar,50),
					new SqlParameter("@balanceMoney", SqlDbType.Decimal,9),
					new SqlParameter("@balanceTime", SqlDbType.DateTime)};
			parameters[0].Value = model.balanceUser;
			parameters[1].Value = model.balanceMoney;
			parameters[2].Value = model.balanceTime;

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
		public bool Update(Maticsoft.Model.PocketBalance model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PocketBalance set ");
			strSql.Append("balanceUser=@balanceUser,");
			strSql.Append("balanceMoney=@balanceMoney,");
			strSql.Append("balanceTime=@balanceTime");
			strSql.Append(" where balanceId=@balanceId");
			SqlParameter[] parameters = {
					new SqlParameter("@balanceUser", SqlDbType.VarChar,50),
					new SqlParameter("@balanceMoney", SqlDbType.Decimal,9),
					new SqlParameter("@balanceTime", SqlDbType.DateTime),
					new SqlParameter("@balanceId", SqlDbType.Int,4)};
			parameters[0].Value = model.balanceUser;
			parameters[1].Value = model.balanceMoney;
			parameters[2].Value = model.balanceTime;
			parameters[3].Value = model.balanceId;

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
		public bool Delete(int balanceId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PocketBalance ");
			strSql.Append(" where balanceId=@balanceId");
			SqlParameter[] parameters = {
					new SqlParameter("@balanceId", SqlDbType.Int,4)
			};
			parameters[0].Value = balanceId;

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
		public bool DeleteList(string balanceIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PocketBalance ");
			strSql.Append(" where balanceId in ("+balanceIdlist + ")  ");
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
		public Maticsoft.Model.PocketBalance GetModel(int balanceId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 balanceId,balanceUser,balanceMoney,balanceTime from PocketBalance ");
			strSql.Append(" where balanceId=@balanceId");
			SqlParameter[] parameters = {
					new SqlParameter("@balanceId", SqlDbType.Int,4)
			};
			parameters[0].Value = balanceId;

			Maticsoft.Model.PocketBalance model=new Maticsoft.Model.PocketBalance();
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
		public Maticsoft.Model.PocketBalance DataRowToModel(DataRow row)
		{
			Maticsoft.Model.PocketBalance model=new Maticsoft.Model.PocketBalance();
			if (row != null)
			{
				if(row["balanceId"]!=null && row["balanceId"].ToString()!="")
				{
					model.balanceId=int.Parse(row["balanceId"].ToString());
				}
				if(row["balanceUser"]!=null)
				{
					model.balanceUser=row["balanceUser"].ToString();
				}
				if(row["balanceMoney"]!=null && row["balanceMoney"].ToString()!="")
				{
					model.balanceMoney=decimal.Parse(row["balanceMoney"].ToString());
				}
				if(row["balanceTime"]!=null && row["balanceTime"].ToString()!="")
				{
					model.balanceTime=DateTime.Parse(row["balanceTime"].ToString());
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
			strSql.Append("select balanceId,balanceUser,balanceMoney,balanceTime ");
			strSql.Append(" FROM PocketBalance ");
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
			strSql.Append(" balanceId,balanceUser,balanceMoney,balanceTime ");
			strSql.Append(" FROM PocketBalance ");
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
			strSql.Append("select count(1) FROM PocketBalance ");
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
				strSql.Append("order by T.balanceId desc");
			}
			strSql.Append(")AS Row, T.*  from PocketBalance T ");
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
			parameters[0].Value = "PocketBalance";
			parameters[1].Value = "balanceId";
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

