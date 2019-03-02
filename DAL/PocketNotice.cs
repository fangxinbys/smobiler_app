using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:PocketNotice
	/// </summary>
	public partial class PocketNotice
	{
		public PocketNotice()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("noticeId", "PocketNotice"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int noticeId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PocketNotice");
			strSql.Append(" where noticeId=@noticeId");
			SqlParameter[] parameters = {
					new SqlParameter("@noticeId", SqlDbType.Int,4)
			};
			parameters[0].Value = noticeId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.PocketNotice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PocketNotice(");
			strSql.Append("noticeTitle,noticeInfo,noticeTime)");
			strSql.Append(" values (");
			strSql.Append("@noticeTitle,@noticeInfo,@noticeTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@noticeTitle", SqlDbType.VarChar,50),
					new SqlParameter("@noticeInfo", SqlDbType.Text),
					new SqlParameter("@noticeTime", SqlDbType.DateTime)};
			parameters[0].Value = model.noticeTitle;
			parameters[1].Value = model.noticeInfo;
			parameters[2].Value = model.noticeTime;

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
		public bool Update(Maticsoft.Model.PocketNotice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PocketNotice set ");
			strSql.Append("noticeTitle=@noticeTitle,");
			strSql.Append("noticeInfo=@noticeInfo,");
			strSql.Append("noticeTime=@noticeTime");
			strSql.Append(" where noticeId=@noticeId");
			SqlParameter[] parameters = {
					new SqlParameter("@noticeTitle", SqlDbType.VarChar,50),
					new SqlParameter("@noticeInfo", SqlDbType.Text),
					new SqlParameter("@noticeTime", SqlDbType.DateTime),
					new SqlParameter("@noticeId", SqlDbType.Int,4)};
			parameters[0].Value = model.noticeTitle;
			parameters[1].Value = model.noticeInfo;
			parameters[2].Value = model.noticeTime;
			parameters[3].Value = model.noticeId;

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
		public bool Delete(int noticeId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PocketNotice ");
			strSql.Append(" where noticeId=@noticeId");
			SqlParameter[] parameters = {
					new SqlParameter("@noticeId", SqlDbType.Int,4)
			};
			parameters[0].Value = noticeId;

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
		public bool DeleteList(string noticeIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PocketNotice ");
			strSql.Append(" where noticeId in ("+noticeIdlist + ")  ");
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
		public Maticsoft.Model.PocketNotice GetModel(int noticeId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 noticeId,noticeTitle,noticeInfo,noticeTime from PocketNotice ");
			strSql.Append(" where noticeId=@noticeId");
			SqlParameter[] parameters = {
					new SqlParameter("@noticeId", SqlDbType.Int,4)
			};
			parameters[0].Value = noticeId;

			Maticsoft.Model.PocketNotice model=new Maticsoft.Model.PocketNotice();
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
		public Maticsoft.Model.PocketNotice DataRowToModel(DataRow row)
		{
			Maticsoft.Model.PocketNotice model=new Maticsoft.Model.PocketNotice();
			if (row != null)
			{
				if(row["noticeId"]!=null && row["noticeId"].ToString()!="")
				{
					model.noticeId=int.Parse(row["noticeId"].ToString());
				}
				if(row["noticeTitle"]!=null)
				{
					model.noticeTitle=row["noticeTitle"].ToString();
				}
				if(row["noticeInfo"]!=null)
				{
					model.noticeInfo=row["noticeInfo"].ToString();
				}
				if(row["noticeTime"]!=null && row["noticeTime"].ToString()!="")
				{
					model.noticeTime=DateTime.Parse(row["noticeTime"].ToString());
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
			strSql.Append("select noticeId,noticeTitle,noticeInfo,noticeTime ");
			strSql.Append(" FROM PocketNotice ");
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
			strSql.Append(" noticeId,noticeTitle,noticeInfo,noticeTime ");
			strSql.Append(" FROM PocketNotice ");
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
			strSql.Append("select count(1) FROM PocketNotice ");
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
				strSql.Append("order by T.noticeId desc");
			}
			strSql.Append(")AS Row, T.*  from PocketNotice T ");
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
			parameters[0].Value = "PocketNotice";
			parameters[1].Value = "noticeId";
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

