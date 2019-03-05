using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:PocketMentor
	/// </summary>
	public partial class PocketMentor
	{
		public PocketMentor()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("mentorId", "PocketMentor"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int mentorId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PocketMentor");
			strSql.Append(" where mentorId=@mentorId");
			SqlParameter[] parameters = {
					new SqlParameter("@mentorId", SqlDbType.Int,4)
			};
			parameters[0].Value = mentorId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.PocketMentor model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PocketMentor(");
			strSql.Append("pocketMaster,disciple,masterMoney,discipleMoney)");
			strSql.Append(" values (");
			strSql.Append("@pocketMaster,@disciple,@masterMoney,@discipleMoney)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@pocketMaster", SqlDbType.VarChar,50),
					new SqlParameter("@disciple", SqlDbType.VarChar,50),
					new SqlParameter("@masterMoney", SqlDbType.Decimal,9),
					new SqlParameter("@discipleMoney", SqlDbType.Decimal,9)};
			parameters[0].Value = model.pocketMaster;
			parameters[1].Value = model.disciple;
			parameters[2].Value = model.masterMoney;
			parameters[3].Value = model.discipleMoney;

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
		public bool Update(Maticsoft.Model.PocketMentor model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PocketMentor set ");
			strSql.Append("pocketMaster=@pocketMaster,");
			strSql.Append("disciple=@disciple,");
			strSql.Append("masterMoney=@masterMoney,");
			strSql.Append("discipleMoney=@discipleMoney");
			strSql.Append(" where mentorId=@mentorId");
			SqlParameter[] parameters = {
					new SqlParameter("@pocketMaster", SqlDbType.VarChar,50),
					new SqlParameter("@disciple", SqlDbType.VarChar,50),
					new SqlParameter("@masterMoney", SqlDbType.Decimal,9),
					new SqlParameter("@discipleMoney", SqlDbType.Decimal,9),
					new SqlParameter("@mentorId", SqlDbType.Int,4)};
			parameters[0].Value = model.pocketMaster;
			parameters[1].Value = model.disciple;
			parameters[2].Value = model.masterMoney;
			parameters[3].Value = model.discipleMoney;
			parameters[4].Value = model.mentorId;

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
		public bool Delete(int mentorId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PocketMentor ");
			strSql.Append(" where mentorId=@mentorId");
			SqlParameter[] parameters = {
					new SqlParameter("@mentorId", SqlDbType.Int,4)
			};
			parameters[0].Value = mentorId;

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
		public bool DeleteList(string mentorIdlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PocketMentor ");
			strSql.Append(" where mentorId in ("+mentorIdlist + ")  ");
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
		public Maticsoft.Model.PocketMentor GetModel(int mentorId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 mentorId,pocketMaster,disciple,masterMoney,discipleMoney from PocketMentor ");
			strSql.Append(" where mentorId=@mentorId");
			SqlParameter[] parameters = {
					new SqlParameter("@mentorId", SqlDbType.Int,4)
			};
			parameters[0].Value = mentorId;

			Maticsoft.Model.PocketMentor model=new Maticsoft.Model.PocketMentor();
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
		public Maticsoft.Model.PocketMentor DataRowToModel(DataRow row)
		{
			Maticsoft.Model.PocketMentor model=new Maticsoft.Model.PocketMentor();
			if (row != null)
			{
				if(row["mentorId"]!=null && row["mentorId"].ToString()!="")
				{
					model.mentorId=int.Parse(row["mentorId"].ToString());
				}
				if(row["pocketMaster"]!=null)
				{
					model.pocketMaster=row["pocketMaster"].ToString();
				}
				if(row["disciple"]!=null)
				{
					model.disciple=row["disciple"].ToString();
				}
				if(row["masterMoney"]!=null && row["masterMoney"].ToString()!="")
				{
					model.masterMoney=decimal.Parse(row["masterMoney"].ToString());
				}
				if(row["discipleMoney"]!=null && row["discipleMoney"].ToString()!="")
				{
					model.discipleMoney=decimal.Parse(row["discipleMoney"].ToString());
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
			strSql.Append("select mentorId,pocketMaster,disciple,masterMoney,discipleMoney ");
			strSql.Append(" FROM PocketMentor ");
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
			strSql.Append(" mentorId,pocketMaster,disciple,masterMoney,discipleMoney ");
			strSql.Append(" FROM PocketMentor ");
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
			strSql.Append("select count(1) FROM PocketMentor ");
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
				strSql.Append("order by T.mentorId desc");
			}
			strSql.Append(")AS Row, T.*  from PocketMentor T ");
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
			parameters[0].Value = "PocketMentor";
			parameters[1].Value = "mentorId";
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

