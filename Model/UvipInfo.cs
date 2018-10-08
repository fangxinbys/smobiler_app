using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// UvipInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class UvipInfo
	{
		public UvipInfo()
		{}
		#region Model
		private int _id;
		private int? _uvipid;
		private decimal? _uqyt;
		private string _urmk;
		private DateTime? _utime;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UvipId
		{
			set{ _uvipid=value;}
			get{return _uvipid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Uqyt
		{
			set{ _uqyt=value;}
			get{return _uqyt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Urmk
		{
			set{ _urmk=value;}
			get{return _urmk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Utime
		{
			set{ _utime=value;}
			get{return _utime;}
		}
		#endregion Model

	}
}

