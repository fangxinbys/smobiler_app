using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// tDepartMent:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tDepartMent
	{
		public tDepartMent()
		{}
		#region Model
		private int _dptid;
		private string _dptname;
		private string _dptremark;
		private int? _dptfatherid;
		/// <summary>
		/// 
		/// </summary>
		public int dptId
		{
			set{ _dptid=value;}
			get{return _dptid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string dptName
		{
			set{ _dptname=value;}
			get{return _dptname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string dptRemark
		{
			set{ _dptremark=value;}
			get{return _dptremark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? dptFatherId
		{
			set{ _dptfatherid=value;}
			get{return _dptfatherid;}
		}
		#endregion Model

	}
}

