using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// PocketMentor:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PocketMentor
	{
		public PocketMentor()
		{}
		#region Model
		private int _mentorid;
		private string _pocketmaster;
		private string _disciple;
		private decimal? _mastermoney;
		private decimal? _disciplemoney;
		/// <summary>
		/// 
		/// </summary>
		public int mentorId
		{
			set{ _mentorid=value;}
			get{return _mentorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pocketMaster
		{
			set{ _pocketmaster=value;}
			get{return _pocketmaster;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string disciple
		{
			set{ _disciple=value;}
			get{return _disciple;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? masterMoney
		{
			set{ _mastermoney=value;}
			get{return _mastermoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? discipleMoney
		{
			set{ _disciplemoney=value;}
			get{return _disciplemoney;}
		}
		#endregion Model

	}
}

