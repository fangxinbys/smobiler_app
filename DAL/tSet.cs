using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:tSet
	/// </summary>
	public partial class tSet
	{
		public tSet()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "tSet"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tSet");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.tSet model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tSet(");
			strSql.Append("WebName,Copyright,KeyWords,Description,Tel,Email,Address,BeiAn,Remark)");
			strSql.Append(" values (");
			strSql.Append("@WebName,@Copyright,@KeyWords,@Description,@Tel,@Email,@Address,@BeiAn,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@WebName", SqlDbType.NVarChar,150),
					new SqlParameter("@Copyright", SqlDbType.NVarChar,150),
					new SqlParameter("@KeyWords", SqlDbType.NVarChar,150),
					new SqlParameter("@Description", SqlDbType.NVarChar,550),
					new SqlParameter("@Tel", SqlDbType.NVarChar,150),
					new SqlParameter("@Email", SqlDbType.NVarChar,350),
					new SqlParameter("@Address", SqlDbType.NVarChar,350),
					new SqlParameter("@BeiAn", SqlDbType.NVarChar,350),
					new SqlParameter("@Remark", SqlDbType.NVarChar,350)};
			parameters[0].Value = model.WebName;
			parameters[1].Value = model.Copyright;
			parameters[2].Value = model.KeyWords;
			parameters[3].Value = model.Description;
			parameters[4].Value = model.Tel;
			parameters[5].Value = model.Email;
			parameters[6].Value = model.Address;
			parameters[7].Value = model.BeiAn;
			parameters[8].Value = model.Remark;

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
		public bool Update(Maticsoft.Model.tSet model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tSet set ");
			strSql.Append("WebName=@WebName,");
			strSql.Append("Copyright=@Copyright,");
			strSql.Append("KeyWords=@KeyWords,");
			strSql.Append("Description=@Description,");
			strSql.Append("Tel=@Tel,");
			strSql.Append("Email=@Email,");
			strSql.Append("Address=@Address,");
			strSql.Append("BeiAn=@BeiAn,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@WebName", SqlDbType.NVarChar,150),
					new SqlParameter("@Copyright", SqlDbType.NVarChar,150),
					new SqlParameter("@KeyWords", SqlDbType.NVarChar,150),
					new SqlParameter("@Description", SqlDbType.NVarChar,550),
					new SqlParameter("@Tel", SqlDbType.NVarChar,150),
					new SqlParameter("@Email", SqlDbType.NVarChar,350),
					new SqlParameter("@Address", SqlDbType.NVarChar,350),
					new SqlParameter("@BeiAn", SqlDbType.NVarChar,350),
					new SqlParameter("@Remark", SqlDbType.NVarChar,350),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.WebName;
			parameters[1].Value = model.Copyright;
			parameters[2].Value = model.KeyWords;
			parameters[3].Value = model.Description;
			parameters[4].Value = model.Tel;
			parameters[5].Value = model.Email;
			parameters[6].Value = model.Address;
			parameters[7].Value = model.BeiAn;
			parameters[8].Value = model.Remark;
			parameters[9].Value = model.Id;

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
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tSet ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

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
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tSet ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
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
		public Maticsoft.Model.tSet GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,WebName,Copyright,KeyWords,Description,Tel,Email,Address,BeiAn,Remark from tSet ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			Maticsoft.Model.tSet model=new Maticsoft.Model.tSet();
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
		public Maticsoft.Model.tSet DataRowToModel(DataRow row)
		{
			Maticsoft.Model.tSet model=new Maticsoft.Model.tSet();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["WebName"]!=null)
				{
					model.WebName=row["WebName"].ToString();
				}
				if(row["Copyright"]!=null)
				{
					model.Copyright=row["Copyright"].ToString();
				}
				if(row["KeyWords"]!=null)
				{
					model.KeyWords=row["KeyWords"].ToString();
				}
				if(row["Description"]!=null)
				{
					model.Description=row["Description"].ToString();
				}
				if(row["Tel"]!=null)
				{
					model.Tel=row["Tel"].ToString();
				}
				if(row["Email"]!=null)
				{
					model.Email=row["Email"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["BeiAn"]!=null)
				{
					model.BeiAn=row["BeiAn"].ToString();
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
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
			strSql.Append("select Id,WebName,Copyright,KeyWords,Description,Tel,Email,Address,BeiAn,Remark ");
			strSql.Append(" FROM tSet ");
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
			strSql.Append(" Id,WebName,Copyright,KeyWords,Description,Tel,Email,Address,BeiAn,Remark ");
			strSql.Append(" FROM tSet ");
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
			strSql.Append("select count(1) FROM tSet ");
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
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from tSet T ");
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
			parameters[0].Value = "tSet";
			parameters[1].Value = "Id";
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

