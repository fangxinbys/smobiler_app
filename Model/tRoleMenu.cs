using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// tRoleMenu:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tRoleMenu
	{
		public tRoleMenu()
		{}
		#region Model
		private int _rcode;
		private int _mcode;
		/// <summary>
		/// 
		/// </summary>
		public int rCode
		{
			set{ _rcode=value;}
			get{return _rcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int mCode
		{
			set{ _mcode=value;}
			get{return _mcode;}
		}
		#endregion Model

	}
}

