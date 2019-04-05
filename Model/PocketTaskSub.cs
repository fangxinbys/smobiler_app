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
		private string _subremake;
		private string _subinfo2;
		private string _subinfo3;
		private string _subinfo4;
		private string _subinfo5;
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
		/// <summary>
		/// 
		/// </summary>
		public string subRemake
		{
			set{ _subremake=value;}
			get{return _subremake;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string subInfo2
		{
			set{ _subinfo2=value;}
			get{return _subinfo2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string subInfo3
		{
			set{ _subinfo3=value;}
			get{return _subinfo3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string subInfo4
		{
			set{ _subinfo4=value;}
			get{return _subinfo4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string subInfo5
		{
			set{ _subinfo5=value;}
			get{return _subinfo5;}
		}
		#endregion Model

	}
}

