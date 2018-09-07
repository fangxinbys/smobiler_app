using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:tUsers
	/// </summary>
	public partial class tUsers
	{
		public tUsers()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("userId", "tUsers"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int userId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tUsers");
			strSql.Append(" where userId=@userId");
			SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4)
			};
			parameters[0].Value = userId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.tUsers model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tUsers(");
            strSql.Append("usersName,usersPwd,roleCode,trueName,Flag,Tel,Address,usersRemark,dptId)");
			strSql.Append(" values (");
            strSql.Append("@usersName,@usersPwd,@roleCode,@trueName,@Flag,@Tel,@Address,@usersRemark,@dptId)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@usersName", SqlDbType.VarChar,50),
					new SqlParameter("@usersPwd", SqlDbType.VarChar,50),
					new SqlParameter("@roleCode", SqlDbType.Int,4),
					new SqlParameter("@trueName", SqlDbType.VarChar,50),
					new SqlParameter("@Flag", SqlDbType.Int,4),
					new SqlParameter("@Tel", SqlDbType.VarChar,50),
					new SqlParameter("@Address", SqlDbType.VarChar,200),
					new SqlParameter("@usersRemark", SqlDbType.VarChar,500),
                    new SqlParameter("@dptId", SqlDbType.Int,4) };
			parameters[0].Value = model.usersName;
			parameters[1].Value = model.usersPwd;
			parameters[2].Value = model.roleCode;
			parameters[3].Value = model.trueName;
			parameters[4].Value = model.Flag;
			parameters[5].Value = model.Tel;
			parameters[6].Value = model.Address;
			parameters[7].Value = model.usersRemark;
            parameters[8].Value = model.dptId;
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
		public bool Update(Maticsoft.Model.tUsers model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tUsers set ");
			strSql.Append("usersName=@usersName,");
			strSql.Append("usersPwd=@usersPwd,");
			strSql.Append("roleCode=@roleCode,");
			strSql.Append("trueName=@trueName,");
			strSql.Append("Flag=@Flag,");
			strSql.Append("Tel=@Tel,");
			strSql.Append("Address=@Address,");
			strSql.Append("usersRemark=@usersRemark,");
            strSql.Append("dptId=@dptId");
			strSql.Append(" where userId=@userId");
			SqlParameter[] parameters = {
         
					new SqlParameter("@usersName", SqlDbType.VarChar,50),
					new SqlParameter("@usersPwd", SqlDbType.VarChar,50),
					new SqlParameter("@roleCode", SqlDbType.Int,4),
					new SqlParameter("@trueName", SqlDbType.VarChar,50),
					new SqlParameter("@Flag", SqlDbType.Int,4),
					new SqlParameter("@Tel", SqlDbType.VarChar,50),
					new SqlParameter("@Address", SqlDbType.VarChar,200),
					new SqlParameter("@usersRemark", SqlDbType.VarChar,500),
					new SqlParameter("@userId", SqlDbType.Int,4),
                    new SqlParameter("@dptId", SqlDbType.Int,4) };
			parameters[0].Value = model.usersName;
			parameters[1].Value = model.usersPwd;
			parameters[2].Value = model.roleCode;
			parameters[3].Value = model.trueName;
			parameters[4].Value = model.Flag;
			parameters[5].Value = model.Tel;
			parameters[6].Value = model.Address;
			parameters[7].Value = model.usersRemark;
			parameters[8].Value = model.userId;
            parameters[9].Value = model.dptId;
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
		public bool Delete(int userId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tUsers ");
			strSql.Append(" where userId=@userId");
			SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4)
			};
			parameters[0].Value = userId;

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
		public bool DeleteList(string userIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tUsers ");
			strSql.Append(" where userId in ("+userIdlist + ")  ");
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
		public Maticsoft.Model.tUsers GetModel(int userId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 userId,usersName,usersPwd,roleCode,trueName,Flag,Tel,Address,usersRemark,dptId from tUsers ");
			strSql.Append(" where userId=@userId");
			SqlParameter[] parameters = {
					new SqlParameter("@userId", SqlDbType.Int,4)
			};
			parameters[0].Value = userId;

			Maticsoft.Model.tUsers model=new Maticsoft.Model.tUsers();
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
		public Maticsoft.Model.tUsers DataRowToModel(DataRow row)
		{
			Maticsoft.Model.tUsers model=new Maticsoft.Model.tUsers();
			if (row != null)
			{
				if(row["userId"]!=null && row["userId"].ToString()!="")
				{
					model.userId=int.Parse(row["userId"].ToString());
				}
				if(row["usersName"]!=null)
				{
					model.usersName=row["usersName"].ToString();
				}
				if(row["usersPwd"]!=null)
				{
					model.usersPwd=row["usersPwd"].ToString();
				}
				if(row["roleCode"]!=null && row["roleCode"].ToString()!="")
				{
					model.roleCode=int.Parse(row["roleCode"].ToString());
				}
				if(row["trueName"]!=null)
				{
					model.trueName=row["trueName"].ToString();
				}
				if(row["Flag"]!=null && row["Flag"].ToString()!="")
				{
					model.Flag=int.Parse(row["Flag"].ToString());
				}
				if(row["Tel"]!=null)
				{
					model.Tel=row["Tel"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["usersRemark"]!=null)
				{
					model.usersRemark=row["usersRemark"].ToString();
				}
                if (row["dptId"] != null && row["dptId"].ToString() != "")
                {
                    model.dptId = int.Parse(row["dptId"].ToString());
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
			strSql.Append("select userId,usersName,usersPwd,roleCode,trueName,Flag,Tel,Address,usersRemark,dptId");
			strSql.Append(" FROM tUsers ");
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
			strSql.Append(" userId,usersName,usersPwd,roleCode,trueName,Flag,Tel,Address,usersRemark,dptId ");
			strSql.Append(" FROM tUsers ");
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
			strSql.Append("select count(1) FROM tUsers ");
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
				strSql.Append("order by T.userId desc");
			}
			strSql.Append(")AS Row, T.*  from tUsers T ");
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
			parameters[0].Value = "tUsers";
			parameters[1].Value = "userId";
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

