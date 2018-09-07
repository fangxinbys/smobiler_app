using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:tMenu
	/// </summary>
	public partial class tMenu
	{
		public tMenu()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("mCode", "tMenu"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int mCode)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tMenu");
			strSql.Append(" where mCode=@mCode");
			SqlParameter[] parameters = {
					new SqlParameter("@mCode", SqlDbType.Int,4)
			};
			parameters[0].Value = mCode;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.tMenu model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tMenu(");
			strSql.Append("mName,mUrl,mSort,mFaherId,mIcon,mRemark)");
			strSql.Append(" values (");
			strSql.Append("@mName,@mUrl,@mSort,@mFaherId,@mIcon,@mRemark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@mName", SqlDbType.VarChar,50),
					new SqlParameter("@mUrl", SqlDbType.VarChar,250),
					new SqlParameter("@mSort", SqlDbType.Int,4),
					new SqlParameter("@mFaherId", SqlDbType.Int,4),
					new SqlParameter("@mIcon", SqlDbType.VarChar,50),
					new SqlParameter("@mRemark", SqlDbType.VarChar,50)};
			parameters[0].Value = model.mName;
			parameters[1].Value = model.mUrl;
			parameters[2].Value = model.mSort;
			parameters[3].Value = model.mFaherId;
			parameters[4].Value = model.mIcon;
			parameters[5].Value = model.mRemark;

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
		public bool Update(Maticsoft.Model.tMenu model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tMenu set ");
			strSql.Append("mName=@mName,");
			strSql.Append("mUrl=@mUrl,");
			strSql.Append("mSort=@mSort,");
			strSql.Append("mFaherId=@mFaherId,");
			strSql.Append("mIcon=@mIcon,");
			strSql.Append("mRemark=@mRemark");
			strSql.Append(" where mCode=@mCode");
			SqlParameter[] parameters = {
					new SqlParameter("@mName", SqlDbType.VarChar,50),
					new SqlParameter("@mUrl", SqlDbType.VarChar,250),
					new SqlParameter("@mSort", SqlDbType.Int,4),
					new SqlParameter("@mFaherId", SqlDbType.Int,4),
					new SqlParameter("@mIcon", SqlDbType.VarChar,50),
					new SqlParameter("@mRemark", SqlDbType.VarChar,50),
					new SqlParameter("@mCode", SqlDbType.Int,4)};
			parameters[0].Value = model.mName;
			parameters[1].Value = model.mUrl;
			parameters[2].Value = model.mSort;
			parameters[3].Value = model.mFaherId;
			parameters[4].Value = model.mIcon;
			parameters[5].Value = model.mRemark;
			parameters[6].Value = model.mCode;

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
		public bool Delete(int mCode)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tMenu ");
			strSql.Append(" where mCode=@mCode");
			SqlParameter[] parameters = {
					new SqlParameter("@mCode", SqlDbType.Int,4)
			};
			parameters[0].Value = mCode;

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
		public bool DeleteList(string mCodelist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tMenu ");
			strSql.Append(" where mCode in ("+mCodelist + ")  ");
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
		public Maticsoft.Model.tMenu GetModel(int mCode)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 mCode,mName,mUrl,mSort,mFaherId,mIcon,mRemark from tMenu ");
			strSql.Append(" where mCode=@mCode");
			SqlParameter[] parameters = {
					new SqlParameter("@mCode", SqlDbType.Int,4)
			};
			parameters[0].Value = mCode;

			Maticsoft.Model.tMenu model=new Maticsoft.Model.tMenu();
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
		public Maticsoft.Model.tMenu DataRowToModel(DataRow row)
		{
			Maticsoft.Model.tMenu model=new Maticsoft.Model.tMenu();
			if (row != null)
			{
				if(row["mCode"]!=null && row["mCode"].ToString()!="")
				{
					model.mCode=int.Parse(row["mCode"].ToString());
				}
				if(row["mName"]!=null)
				{
					model.mName=row["mName"].ToString();
				}
				if(row["mUrl"]!=null)
				{
					model.mUrl=row["mUrl"].ToString();
				}
				if(row["mSort"]!=null && row["mSort"].ToString()!="")
				{
					model.mSort=int.Parse(row["mSort"].ToString());
				}
				if(row["mFaherId"]!=null && row["mFaherId"].ToString()!="")
				{
					model.mFaherId=int.Parse(row["mFaherId"].ToString());
				}
				if(row["mIcon"]!=null)
				{
					model.mIcon=row["mIcon"].ToString();
				}
				if(row["mRemark"]!=null)
				{
					model.mRemark=row["mRemark"].ToString();
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
			strSql.Append("select mCode,mName,mUrl,mSort,mFaherId,mIcon,mRemark ");
			strSql.Append(" FROM tMenu ");
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
			strSql.Append(" mCode,mName,mUrl,mSort,mFaherId,mIcon,mRemark ");
			strSql.Append(" FROM tMenu ");
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
			strSql.Append("select count(1) FROM tMenu ");
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
				strSql.Append("order by T.mCode desc");
			}
			strSql.Append(")AS Row, T.*  from tMenu T ");
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
			parameters[0].Value = "tMenu";
			parameters[1].Value = "mCode";
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

