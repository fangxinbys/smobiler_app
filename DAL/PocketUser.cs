using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:PocketUser
	/// </summary>
	public partial class PocketUser
	{
		public PocketUser()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("pocketUserId", "PocketUser"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int pocketUserId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PocketUser");
			strSql.Append(" where pocketUserId=@pocketUserId");
			SqlParameter[] parameters = {
					new SqlParameter("@pocketUserId", SqlDbType.Int,4)
			};
			parameters[0].Value = pocketUserId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.PocketUser model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PocketUser(");
			strSql.Append("pocketUserName,pocketUserPhone,pocketUserInv,pocketUserAlipay,pocketUserReName)");
			strSql.Append(" values (");
			strSql.Append("@pocketUserName,@pocketUserPhone,@pocketUserInv,@pocketUserAlipay,@pocketUserReName)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@pocketUserName", SqlDbType.VarChar,50),
					new SqlParameter("@pocketUserPhone", SqlDbType.VarChar,50),
					new SqlParameter("@pocketUserInv", SqlDbType.VarChar,50),
					new SqlParameter("@pocketUserAlipay", SqlDbType.VarChar,50),
					new SqlParameter("@pocketUserReName", SqlDbType.VarChar,50)};
			parameters[0].Value = model.pocketUserName;
			parameters[1].Value = model.pocketUserPhone;
			parameters[2].Value = model.pocketUserInv;
			parameters[3].Value = model.pocketUserAlipay;
			parameters[4].Value = model.pocketUserReName;

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
		public bool Update(Maticsoft.Model.PocketUser model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PocketUser set ");
			strSql.Append("pocketUserName=@pocketUserName,");
			strSql.Append("pocketUserPhone=@pocketUserPhone,");
			strSql.Append("pocketUserInv=@pocketUserInv,");
			strSql.Append("pocketUserAlipay=@pocketUserAlipay,");
			strSql.Append("pocketUserReName=@pocketUserReName");
			strSql.Append(" where pocketUserId=@pocketUserId");
			SqlParameter[] parameters = {
					new SqlParameter("@pocketUserName", SqlDbType.VarChar,50),
					new SqlParameter("@pocketUserPhone", SqlDbType.VarChar,50),
					new SqlParameter("@pocketUserInv", SqlDbType.VarChar,50),
					new SqlParameter("@pocketUserAlipay", SqlDbType.VarChar,50),
					new SqlParameter("@pocketUserReName", SqlDbType.VarChar,50),
					new SqlParameter("@pocketUserId", SqlDbType.Int,4)};
			parameters[0].Value = model.pocketUserName;
			parameters[1].Value = model.pocketUserPhone;
			parameters[2].Value = model.pocketUserInv;
			parameters[3].Value = model.pocketUserAlipay;
			parameters[4].Value = model.pocketUserReName;
			parameters[5].Value = model.pocketUserId;

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
		public bool Delete(int pocketUserId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PocketUser ");
			strSql.Append(" where pocketUserId=@pocketUserId");
			SqlParameter[] parameters = {
					new SqlParameter("@pocketUserId", SqlDbType.Int,4)
			};
			parameters[0].Value = pocketUserId;

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
		public bool DeleteList(string pocketUserIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PocketUser ");
			strSql.Append(" where pocketUserId in ("+pocketUserIdlist + ")  ");
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
		public Maticsoft.Model.PocketUser GetModel(int pocketUserId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 pocketUserId,pocketUserName,pocketUserPhone,pocketUserInv,pocketUserAlipay,pocketUserReName from PocketUser ");
			strSql.Append(" where pocketUserId=@pocketUserId");
			SqlParameter[] parameters = {
					new SqlParameter("@pocketUserId", SqlDbType.Int,4)
			};
			parameters[0].Value = pocketUserId;

			Maticsoft.Model.PocketUser model=new Maticsoft.Model.PocketUser();
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
		public Maticsoft.Model.PocketUser DataRowToModel(DataRow row)
		{
			Maticsoft.Model.PocketUser model=new Maticsoft.Model.PocketUser();
			if (row != null)
			{
				if(row["pocketUserId"]!=null && row["pocketUserId"].ToString()!="")
				{
					model.pocketUserId=int.Parse(row["pocketUserId"].ToString());
				}
				if(row["pocketUserName"]!=null)
				{
					model.pocketUserName=row["pocketUserName"].ToString();
				}
				if(row["pocketUserPhone"]!=null)
				{
					model.pocketUserPhone=row["pocketUserPhone"].ToString();
				}
				if(row["pocketUserInv"]!=null)
				{
					model.pocketUserInv=row["pocketUserInv"].ToString();
				}
				if(row["pocketUserAlipay"]!=null)
				{
					model.pocketUserAlipay=row["pocketUserAlipay"].ToString();
				}
				if(row["pocketUserReName"]!=null)
				{
					model.pocketUserReName=row["pocketUserReName"].ToString();
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
			strSql.Append("select pocketUserId,pocketUserName,pocketUserPhone,pocketUserInv,pocketUserAlipay,pocketUserReName ");
			strSql.Append(" FROM PocketUser ");
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
			strSql.Append(" pocketUserId,pocketUserName,pocketUserPhone,pocketUserInv,pocketUserAlipay,pocketUserReName ");
			strSql.Append(" FROM PocketUser ");
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
			strSql.Append("select count(1) FROM PocketUser ");
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
				strSql.Append("order by T.pocketUserId desc");
			}
			strSql.Append(")AS Row, T.*  from PocketUser T ");
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
			parameters[0].Value = "PocketUser";
			parameters[1].Value = "pocketUserId";
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

