using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// tPower:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tPower
	{
		public tPower()
		{}
		#region Model
		private int _powerid;
		private string _powername;
		private string _powerremark;
		/// <summary>
		/// 
		/// </summary>
		public int powerId
		{
			set{ _powerid=value;}
			get{return _powerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string powerName
		{
			set{ _powername=value;}
			get{return _powername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string powerRemark
		{
			set{ _powerremark=value;}
			get{return _powerremark;}
		}
		#endregion Model

	}
}

