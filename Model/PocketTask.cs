using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// PocketTask:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PocketTask
	{
		public PocketTask()
		{}
		#region Model
		private int _pockettaskid;
		private string _pockettaskinfo;
		private int? _pockettasknum;
		private decimal? _pockettaskmoney;
		private string _pockettaskrule;
		private DateTime? _pockettime;
		private string _pocketfengmian;
		/// <summary>
		/// 
		/// </summary>
		public int pocketTaskId
		{
			set{ _pockettaskid=value;}
			get{return _pockettaskid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pocketTaskInfo
		{
			set{ _pockettaskinfo=value;}
			get{return _pockettaskinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? pocketTaskNum
		{
			set{ _pockettasknum=value;}
			get{return _pockettasknum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? pocketTaskMoney
		{
			set{ _pockettaskmoney=value;}
			get{return _pockettaskmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pocketTaskRule
		{
			set{ _pockettaskrule=value;}
			get{return _pockettaskrule;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? pocketTime
		{
			set{ _pockettime=value;}
			get{return _pockettime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pocketFengMian
		{
			set{ _pocketfengmian=value;}
			get{return _pocketfengmian;}
		}
		#endregion Model

	}
}

