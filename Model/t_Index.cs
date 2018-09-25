using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// t_Index:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_Index
	{
		public t_Index()
		{}
		#region Model
		private int _id;
		private int? _fatherid;
		private string _name;
		private int? _subdptid;
		private int? _approvedptid;
		private decimal? _scale;
		private decimal? _score;
		private int? _isuse;
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
		public int? FatherId
		{
			set{ _fatherid=value;}
			get{return _fatherid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SubDptId
		{
			set{ _subdptid=value;}
			get{return _subdptid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ApproveDptId
		{
			set{ _approvedptid=value;}
			get{return _approvedptid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Scale
		{
			set{ _scale=value;}
			get{return _scale;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Score
		{
			set{ _score=value;}
			get{return _score;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsUse
		{
			set{ _isuse=value;}
			get{return _isuse;}
		}
		#endregion Model

	}
}

