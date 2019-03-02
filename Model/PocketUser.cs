using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// PocketUser:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PocketUser
	{
		public PocketUser()
		{}
		#region Model
		private int _pocketuserid;
		private string _pocketusername;
		private string _pocketuserphone;
		private string _pocketuserinv;
		private string _pocketuseralipay;
		private string _pocketuserrename;
		/// <summary>
		/// 
		/// </summary>
		public int pocketUserId
		{
			set{ _pocketuserid=value;}
			get{return _pocketuserid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pocketUserName
		{
			set{ _pocketusername=value;}
			get{return _pocketusername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pocketUserPhone
		{
			set{ _pocketuserphone=value;}
			get{return _pocketuserphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pocketUserInv
		{
			set{ _pocketuserinv=value;}
			get{return _pocketuserinv;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pocketUserAlipay
		{
			set{ _pocketuseralipay=value;}
			get{return _pocketuseralipay;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pocketUserReName
		{
			set{ _pocketuserrename=value;}
			get{return _pocketuserrename;}
		}
		#endregion Model

	}
}

