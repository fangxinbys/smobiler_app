using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:tBom
	/// </summary>
	public partial class tBom
	{
		public tBom()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "tBom"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from tBom");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.tBom model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into tBom(");
			strSql.Append("parent,component,qty_set,qty_set_waste,oper_dept,pf,remark,out_prod,diameter,length,width,height,sys_date,input_count)");
			strSql.Append(" values (");
			strSql.Append("@parent,@component,@qty_set,@qty_set_waste,@oper_dept,@pf,@remark,@out_prod,@diameter,@length,@width,@height,@sys_date,@input_count)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@parent", SqlDbType.VarChar,8),
					new SqlParameter("@component", SqlDbType.VarChar,8),
					new SqlParameter("@qty_set", SqlDbType.Decimal,9),
					new SqlParameter("@qty_set_waste", SqlDbType.Decimal,9),
					new SqlParameter("@oper_dept", SqlDbType.VarChar,20),
					new SqlParameter("@pf", SqlDbType.Bit,1),
					new SqlParameter("@remark", SqlDbType.VarChar,100),
					new SqlParameter("@out_prod", SqlDbType.Bit,1),
					new SqlParameter("@diameter", SqlDbType.Decimal,9),
					new SqlParameter("@length", SqlDbType.Decimal,9),
					new SqlParameter("@width", SqlDbType.Decimal,9),
					new SqlParameter("@height", SqlDbType.Decimal,9),
					new SqlParameter("@sys_date", SqlDbType.DateTime),
					new SqlParameter("@input_count", SqlDbType.Decimal,9)};
			parameters[0].Value = model.parent;
			parameters[1].Value = model.component;
			parameters[2].Value = model.qty_set;
			parameters[3].Value = model.qty_set_waste;
			parameters[4].Value = model.oper_dept;
			parameters[5].Value = model.pf;
			parameters[6].Value = model.remark;
			parameters[7].Value = model.out_prod;
			parameters[8].Value = model.diameter;
			parameters[9].Value = model.length;
			parameters[10].Value = model.width;
			parameters[11].Value = model.height;
			parameters[12].Value = model.sys_date;
			parameters[13].Value = model.input_count;

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
		public bool Update(Maticsoft.Model.tBom model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update tBom set ");
			strSql.Append("parent=@parent,");
			strSql.Append("component=@component,");
			strSql.Append("qty_set=@qty_set,");
			strSql.Append("qty_set_waste=@qty_set_waste,");
			strSql.Append("oper_dept=@oper_dept,");
			strSql.Append("pf=@pf,");
			strSql.Append("remark=@remark,");
			strSql.Append("out_prod=@out_prod,");
			strSql.Append("diameter=@diameter,");
			strSql.Append("length=@length,");
			strSql.Append("width=@width,");
			strSql.Append("height=@height,");
			strSql.Append("sys_date=@sys_date,");
			strSql.Append("input_count=@input_count");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@parent", SqlDbType.VarChar,8),
					new SqlParameter("@component", SqlDbType.VarChar,8),
					new SqlParameter("@qty_set", SqlDbType.Decimal,9),
					new SqlParameter("@qty_set_waste", SqlDbType.Decimal,9),
					new SqlParameter("@oper_dept", SqlDbType.VarChar,20),
					new SqlParameter("@pf", SqlDbType.Bit,1),
					new SqlParameter("@remark", SqlDbType.VarChar,100),
					new SqlParameter("@out_prod", SqlDbType.Bit,1),
					new SqlParameter("@diameter", SqlDbType.Decimal,9),
					new SqlParameter("@length", SqlDbType.Decimal,9),
					new SqlParameter("@width", SqlDbType.Decimal,9),
					new SqlParameter("@height", SqlDbType.Decimal,9),
					new SqlParameter("@sys_date", SqlDbType.DateTime),
					new SqlParameter("@input_count", SqlDbType.Decimal,9),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.parent;
			parameters[1].Value = model.component;
			parameters[2].Value = model.qty_set;
			parameters[3].Value = model.qty_set_waste;
			parameters[4].Value = model.oper_dept;
			parameters[5].Value = model.pf;
			parameters[6].Value = model.remark;
			parameters[7].Value = model.out_prod;
			parameters[8].Value = model.diameter;
			parameters[9].Value = model.length;
			parameters[10].Value = model.width;
			parameters[11].Value = model.height;
			parameters[12].Value = model.sys_date;
			parameters[13].Value = model.input_count;
			parameters[14].Value = model.id;

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
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tBom ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

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
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from tBom ");
			strSql.Append(" where id in ("+idlist + ")  ");
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
		public Maticsoft.Model.tBom GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,parent,component,qty_set,qty_set_waste,oper_dept,pf,remark,out_prod,diameter,length,width,height,sys_date,input_count from tBom ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			Maticsoft.Model.tBom model=new Maticsoft.Model.tBom();
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
		public Maticsoft.Model.tBom DataRowToModel(DataRow row)
		{
			Maticsoft.Model.tBom model=new Maticsoft.Model.tBom();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["parent"]!=null)
				{
					model.parent=row["parent"].ToString();
				}
				if(row["component"]!=null)
				{
					model.component=row["component"].ToString();
				}
				if(row["qty_set"]!=null && row["qty_set"].ToString()!="")
				{
					model.qty_set=decimal.Parse(row["qty_set"].ToString());
				}
				if(row["qty_set_waste"]!=null && row["qty_set_waste"].ToString()!="")
				{
					model.qty_set_waste=decimal.Parse(row["qty_set_waste"].ToString());
				}
				if(row["oper_dept"]!=null)
				{
					model.oper_dept=row["oper_dept"].ToString();
				}
				if(row["pf"]!=null && row["pf"].ToString()!="")
				{
					if((row["pf"].ToString()=="1")||(row["pf"].ToString().ToLower()=="true"))
					{
						model.pf=true;
					}
					else
					{
						model.pf=false;
					}
				}
				if(row["remark"]!=null)
				{
					model.remark=row["remark"].ToString();
				}
				if(row["out_prod"]!=null && row["out_prod"].ToString()!="")
				{
					if((row["out_prod"].ToString()=="1")||(row["out_prod"].ToString().ToLower()=="true"))
					{
						model.out_prod=true;
					}
					else
					{
						model.out_prod=false;
					}
				}
				if(row["diameter"]!=null && row["diameter"].ToString()!="")
				{
					model.diameter=decimal.Parse(row["diameter"].ToString());
				}
				if(row["length"]!=null && row["length"].ToString()!="")
				{
					model.length=decimal.Parse(row["length"].ToString());
				}
				if(row["width"]!=null && row["width"].ToString()!="")
				{
					model.width=decimal.Parse(row["width"].ToString());
				}
				if(row["height"]!=null && row["height"].ToString()!="")
				{
					model.height=decimal.Parse(row["height"].ToString());
				}
				if(row["sys_date"]!=null && row["sys_date"].ToString()!="")
				{
					model.sys_date=DateTime.Parse(row["sys_date"].ToString());
				}
				if(row["input_count"]!=null && row["input_count"].ToString()!="")
				{
					model.input_count=decimal.Parse(row["input_count"].ToString());
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
			strSql.Append("select id,parent,component,qty_set,qty_set_waste,oper_dept,pf,remark,out_prod,diameter,length,width,height,sys_date,input_count ");
			strSql.Append(" FROM tBom ");
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
			strSql.Append(" id,parent,component,qty_set,qty_set_waste,oper_dept,pf,remark,out_prod,diameter,length,width,height,sys_date,input_count ");
			strSql.Append(" FROM tBom ");
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
			strSql.Append("select count(1) FROM tBom ");
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
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from tBom T ");
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
			parameters[0].Value = "tBom";
			parameters[1].Value = "id";
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

