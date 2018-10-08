using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// Uvip:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Uvip
	{
		public Uvip()
		{}
		#region Model
		private int _id;
		private string _uname;
		private string _utel;
		private string _ucode;
		private string _uads;
		private string _usex;
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
		public string Uname
		{
			set{ _uname=value;}
			get{return _uname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Utel
		{
			set{ _utel=value;}
			get{return _utel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Ucode
		{
			set{ _ucode=value;}
			get{return _ucode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Uads
		{
			set{ _uads=value;}
			get{return _uads;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Usex
		{
			set{ _usex=value;}
			get{return _usex;}
		}
		#endregion Model

	}
}

