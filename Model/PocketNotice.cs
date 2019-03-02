using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// PocketNotice:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PocketNotice
	{
		public PocketNotice()
		{}
		#region Model
		private int _noticeid;
		private string _noticetitle;
		private string _noticeinfo;
		private DateTime? _noticetime;
		/// <summary>
		/// 
		/// </summary>
		public int noticeId
		{
			set{ _noticeid=value;}
			get{return _noticeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string noticeTitle
		{
			set{ _noticetitle=value;}
			get{return _noticetitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string noticeInfo
		{
			set{ _noticeinfo=value;}
			get{return _noticeinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? noticeTime
		{
			set{ _noticetime=value;}
			get{return _noticetime;}
		}
		#endregion Model

	}
}

