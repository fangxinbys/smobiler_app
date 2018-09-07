using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// tUserPower:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tUserPower
	{
		public tUserPower()
		{}
		#region Model
		private int _upid;
		private int? _userid;
		private int? _powerid;
		/// <summary>
		/// 
		/// </summary>
		public int upId
		{
			set{ _upid=value;}
			get{return _upid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? userId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? powerId
		{
			set{ _powerid=value;}
			get{return _powerid;}
		}
		#endregion Model

	}
}

