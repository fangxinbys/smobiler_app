using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// tRegisterSend:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tRegisterSend
	{
		public tRegisterSend()
		{}
		#region Model
		private int _id;
		private string _lphone;
		private DateTime? _time;
		private string _appcilentid;
		private string _yzm;
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
		public string lPhone
		{
			set{ _lphone=value;}
			get{return _lphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Time
		{
			set{ _time=value;}
			get{return _time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AppCilentId
		{
			set{ _appcilentid=value;}
			get{return _appcilentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Yzm
		{
			set{ _yzm=value;}
			get{return _yzm;}
		}
		#endregion Model

	}
}

