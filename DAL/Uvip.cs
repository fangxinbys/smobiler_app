using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Uvip
	/// </summary>
	public partial class Uvip
	{
		public Uvip()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "Uvip"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Uvip");
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
		public int Add(Maticsoft.Model.Uvip model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Uvip(");
			strSql.Append("Uname,Utel,Ucode,Uads,Usex,UchName,UbirTime,Uwx)");
			strSql.Append(" values (");
			strSql.Append("@Uname,@Utel,@Ucode,@Uads,@Usex,@UchName,@UbirTime,@Uwx)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Uname", SqlDbType.NVarChar,50),
					new SqlParameter("@Utel", SqlDbType.NVarChar,50),
					new SqlParameter("@Ucode", SqlDbType.NVarChar,50),
					new SqlParameter("@Uads", SqlDbType.NVarChar,150),
					new SqlParameter("@Usex", SqlDbType.NVarChar,50),
					new SqlParameter("@UchName", SqlDbType.NVarChar,50),
					new SqlParameter("@UbirTime", SqlDbType.DateTime),
					new SqlParameter("@Uwx", SqlDbType.NVarChar,150)};
			parameters[0].Value = model.Uname;
			parameters[1].Value = model.Utel;
			parameters[2].Value = model.Ucode;
			parameters[3].Value = model.Uads;
			parameters[4].Value = model.Usex;
			parameters[5].Value = model.UchName;
			parameters[6].Value = model.UbirTime;
			parameters[7].Value = model.Uwx;

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
		public bool Update(Maticsoft.Model.Uvip model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Uvip set ");
			strSql.Append("Uname=@Uname,");
			strSql.Append("Utel=@Utel,");
			strSql.Append("Ucode=@Ucode,");
			strSql.Append("Uads=@Uads,");
			strSql.Append("Usex=@Usex,");
			strSql.Append("UchName=@UchName,");
			strSql.Append("UbirTime=@UbirTime,");
			strSql.Append("Uwx=@Uwx");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Uname", SqlDbType.NVarChar,50),
					new SqlParameter("@Utel", SqlDbType.NVarChar,50),
					new SqlParameter("@Ucode", SqlDbType.NVarChar,50),
					new SqlParameter("@Uads", SqlDbType.NVarChar,150),
					new SqlParameter("@Usex", SqlDbType.NVarChar,50),
					new SqlParameter("@UchName", SqlDbType.NVarChar,50),
					new SqlParameter("@UbirTime", SqlDbType.DateTime),
					new SqlParameter("@Uwx", SqlDbType.NVarChar,150),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.Uname;
			parameters[1].Value = model.Utel;
			parameters[2].Value = model.Ucode;
			parameters[3].Value = model.Uads;
			parameters[4].Value = model.Usex;
			parameters[5].Value = model.UchName;
			parameters[6].Value = model.UbirTime;
			parameters[7].Value = model.Uwx;
			parameters[8].Value = model.Id;

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
			strSql.Append("delete from Uvip ");
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
			strSql.Append("delete from Uvip ");
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
		public Maticsoft.Model.Uvip GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,Uname,Utel,Ucode,Uads,Usex,UchName,UbirTime,Uwx from Uvip ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			Maticsoft.Model.Uvip model=new Maticsoft.Model.Uvip();
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
		public Maticsoft.Model.Uvip DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Uvip model=new Maticsoft.Model.Uvip();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["Uname"]!=null)
				{
					model.Uname=row["Uname"].ToString();
				}
				if(row["Utel"]!=null)
				{
					model.Utel=row["Utel"].ToString();
				}
				if(row["Ucode"]!=null)
				{
					model.Ucode=row["Ucode"].ToString();
				}
				if(row["Uads"]!=null)
				{
					model.Uads=row["Uads"].ToString();
				}
				if(row["Usex"]!=null)
				{
					model.Usex=row["Usex"].ToString();
				}
				if(row["UchName"]!=null)
				{
					model.UchName=row["UchName"].ToString();
				}
				if(row["UbirTime"]!=null && row["UbirTime"].ToString()!="")
				{
					model.UbirTime=DateTime.Parse(row["UbirTime"].ToString());
				}
				if(row["Uwx"]!=null)
				{
					model.Uwx=row["Uwx"].ToString();
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
			strSql.Append("select Id,Uname,Utel,Ucode,Uads,Usex,UchName,UbirTime,Uwx ");
			strSql.Append(" FROM Uvip ");
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
			strSql.Append(" Id,Uname,Utel,Ucode,Uads,Usex,UchName,UbirTime,Uwx ");
			strSql.Append(" FROM Uvip ");
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
			strSql.Append("select count(1) FROM Uvip ");
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
			strSql.Append(")AS Row, T.*  from Uvip T ");
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
			parameters[0].Value = "Uvip";
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

