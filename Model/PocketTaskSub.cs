using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// PocketTaskSub:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PocketTaskSub
	{
		public PocketTaskSub()
		{}
		#region Model
		private int _subid;
		private int? _subtaskid;
		private string _subuser;
		private string _subinfo;
		private DateTime? _subtime;
		private decimal? _submoney;
		private bool _examine;
		/// <summary>
		/// 
		/// </summary>
		public int subId
		{
			set{ _subid=value;}
			get{return _subid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? subTaskId
		{
			set{ _subtaskid=value;}
			get{return _subtaskid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string subUser
		{
			set{ _subuser=value;}
			get{return _subuser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string subInfo
		{
			set{ _subinfo=value;}
			get{return _subinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? subTime
		{
			set{ _subtime=value;}
			get{return _subtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? subMoney
		{
			set{ _submoney=value;}
			get{return _submoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool examine
		{
			set{ _examine=value;}
			get{return _examine;}
		}
		#endregion Model

	}
}

