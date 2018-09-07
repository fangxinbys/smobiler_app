using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// tMenu:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tMenu
	{
		public tMenu()
		{}
		#region Model
		private int _mcode;
		private string _mname;
		private string _murl;
		private int? _msort;
        private int? _mfaherid;
		private string _micon;
		private string _mremark;
		/// <summary>
		/// 
		/// </summary>
		public int mCode
		{
			set{ _mcode=value;}
			get{return _mcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mName
		{
			set{ _mname=value;}
			get{return _mname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mUrl
		{
			set{ _murl=value;}
			get{return _murl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? mSort
		{
			set{ _msort=value;}
			get{return _msort;}
		}
		/// <summary>
		/// 
		/// </summary>
        public int? mFaherId
		{
			set{ _mfaherid=value;}
			get{return _mfaherid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mIcon
		{
			set{ _micon=value;}
			get{return _micon;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string mRemark
		{
			set{ _mremark=value;}
			get{return _mremark;}
		}
		#endregion Model

	}
}

