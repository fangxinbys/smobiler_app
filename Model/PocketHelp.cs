using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// PocketHelp:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PocketHelp
	{
		public PocketHelp()
		{}
		#region Model
		private int _helpid;
		private string _helptitle;
		private string _helpinfo;
		/// <summary>
		/// 
		/// </summary>
		public int helpId
		{
			set{ _helpid=value;}
			get{return _helpid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HelpTitle
		{
			set{ _helptitle=value;}
			get{return _helptitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HelpInfo
		{
			set{ _helpinfo=value;}
			get{return _helpinfo;}
		}
		#endregion Model

	}
}

