using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// tBom:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tBom
	{
		public tBom()
		{}
		#region Model
		private int _id;
		private string _parent;
		private string _component;
		private decimal? _qty_set;
		private decimal? _qty_set_waste;
		private string _oper_dept;
		private bool _pf;
		private string _remark;
		private bool _out_prod= false;
		private decimal? _diameter;
		private decimal? _length;
		private decimal? _width;
		private decimal? _height;
		private DateTime? _sys_date= DateTime.Now;
		private decimal? _input_count;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string parent
		{
			set{ _parent=value;}
			get{return _parent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string component
		{
			set{ _component=value;}
			get{return _component;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? qty_set
		{
			set{ _qty_set=value;}
			get{return _qty_set;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? qty_set_waste
		{
			set{ _qty_set_waste=value;}
			get{return _qty_set_waste;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string oper_dept
		{
			set{ _oper_dept=value;}
			get{return _oper_dept;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool pf
		{
			set{ _pf=value;}
			get{return _pf;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool out_prod
		{
			set{ _out_prod=value;}
			get{return _out_prod;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? diameter
		{
			set{ _diameter=value;}
			get{return _diameter;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? length
		{
			set{ _length=value;}
			get{return _length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? width
		{
			set{ _width=value;}
			get{return _width;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? height
		{
			set{ _height=value;}
			get{return _height;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? sys_date
		{
			set{ _sys_date=value;}
			get{return _sys_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? input_count
		{
			set{ _input_count=value;}
			get{return _input_count;}
		}
		#endregion Model

	}
}

