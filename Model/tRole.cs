using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// tRole:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tRole
	{
		public tRole()
		{}
		#region Model
		private int _rcode;
		private string _rname;
		private string _rremark;
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
		public string rName
		{
			set{ _rname=value;}
			get{return _rname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rRemark
		{
			set{ _rremark=value;}
			get{return _rremark;}
		}
		#endregion Model

	}
}

