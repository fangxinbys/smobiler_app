using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// tSysLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tSysLog
	{
		public tSysLog()
		{}
		#region Model
		private int _id;
		private string _username;
		private string _ip;
		private DateTime? _systime;
		private string _dowhat;
		private string _remark;
		private int? _userid;
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
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IP
		{
			set{ _ip=value;}
			get{return _ip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SysTime
		{
			set{ _systime=value;}
			get{return _systime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DoWhat
		{
			set{ _dowhat=value;}
			get{return _dowhat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		#endregion Model

	}
}

