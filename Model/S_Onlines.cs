using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// S_Onlines:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class S_Onlines
	{
		public S_Onlines()
		{}
		#region Model
		private int _id;
		private string _ipadddress;
		private DateTime? _logintime;
		private DateTime? _updatetime;
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
		public string IpAdddress
		{
			set{ _ipadddress=value;}
			get{return _ipadddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LoginTime
		{
			set{ _logintime=value;}
			get{return _logintime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
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

