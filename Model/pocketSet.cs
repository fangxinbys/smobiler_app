using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// pocketSet:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class pocketSet
	{
		public pocketSet()
		{}
		#region Model
		private int _setid;
		private string _setname;
		private decimal? _setmoney;
		/// <summary>
		/// 
		/// </summary>
		public int setId
		{
			set{ _setid=value;}
			get{return _setid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string setName
		{
			set{ _setname=value;}
			get{return _setname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? setMoney
		{
			set{ _setmoney=value;}
			get{return _setmoney;}
		}
		#endregion Model

	}
}

