using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:tDepartMent
	/// </summary>
	public partial class tDepartMent
	{
		public tDepartMent()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("dptId", "tDepartMent"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int dptId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tDepartMent");
			strSql.Append(" where dptId=@dptId");
			SqlParameter[] parameters = {
					new SqlParameter("@dptId", SqlDbType.Int,4)
			};
			parameters[0].Value = dptId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.tDepartMent model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tDepartMent(");
			strSql.Append("dptName,dptRemark,dptFatherId)");
			strSql.Append(" values (");
			strSql.Append("@dptName,@dptRemark,@dptFatherId)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@dptName", SqlDbType.NVarChar,50),
					new SqlParameter("@dptRemark", SqlDbType.NVarChar,-1),
					new SqlParameter("@dptFatherId", SqlDbType.Int,4)};
			parameters[0].Value = model.dptName;
			parameters[1].Value = model.dptRemark;
			parameters[2].Value = model.dptFatherId;

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
		public bool Update(Maticsoft.Model.tDepartMent model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tDepartMent set ");
			strSql.Append("dptName=@dptName,");
			strSql.Append("dptRemark=@dptRemark,");
			strSql.Append("dptFatherId=@dptFatherId");
			strSql.Append(" where dptId=@dptId");
			SqlParameter[] parameters = {
					new SqlParameter("@dptName", SqlDbType.NVarChar,50),
					new SqlParameter("@dptRemark", SqlDbType.NVarChar,-1),
					new SqlParameter("@dptFatherId", SqlDbType.Int,4),
					new SqlParameter("@dptId", SqlDbType.Int,4)};
			parameters[0].Value = model.dptName;
			parameters[1].Value = model.dptRemark;
			parameters[2].Value = model.dptFatherId;
			parameters[3].Value = model.dptId;

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
		public bool Delete(int dptId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tDepartMent ");
			strSql.Append(" where dptId=@dptId");
			SqlParameter[] parameters = {
					new SqlParameter("@dptId", SqlDbType.Int,4)
			};
			parameters[0].Value = dptId;

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
		public bool DeleteList(string dptIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tDepartMent ");
			strSql.Append(" where dptId in ("+dptIdlist + ")  ");
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
		public Maticsoft.Model.tDepartMent GetModel(int dptId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 dptId,dptName,dptRemark,dptFatherId from tDepartMent ");
			strSql.Append(" where dptId=@dptId");
			SqlParameter[] parameters = {
					new SqlParameter("@dptId", SqlDbType.Int,4)
			};
			parameters[0].Value = dptId;

			Maticsoft.Model.tDepartMent model=new Maticsoft.Model.tDepartMent();
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
		public Maticsoft.Model.tDepartMent DataRowToModel(DataRow row)
		{
			Maticsoft.Model.tDepartMent model=new Maticsoft.Model.tDepartMent();
			if (row != null)
			{
				if(row["dptId"]!=null && row["dptId"].ToString()!="")
				{
					model.dptId=int.Parse(row["dptId"].ToString());
				}
				if(row["dptName"]!=null)
				{
					model.dptName=row["dptName"].ToString();
				}
				if(row["dptRemark"]!=null)
				{
					model.dptRemark=row["dptRemark"].ToString();
				}
				if(row["dptFatherId"]!=null && row["dptFatherId"].ToString()!="")
				{
					model.dptFatherId=int.Parse(row["dptFatherId"].ToString());
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
			strSql.Append("select dptId,dptName,dptRemark,dptFatherId ");
			strSql.Append(" FROM tDepartMent ");
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
			strSql.Append(" dptId,dptName,dptRemark,dptFatherId ");
			strSql.Append(" FROM tDepartMent ");
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
			strSql.Append("select count(1) FROM tDepartMent ");
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
				strSql.Append("order by T.dptId desc");
			}
			strSql.Append(")AS Row, T.*  from tDepartMent T ");
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
			parameters[0].Value = "tDepartMent";
			parameters[1].Value = "dptId";
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

