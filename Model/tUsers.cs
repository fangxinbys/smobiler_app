using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// tUsers:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class tUsers
	{
		public tUsers()
		{}
		#region Model
		private int _userid;
		private string _usersname;
		private string _userspwd;
		private int _rolecode;
		private string _truename;
		private int _flag;
		private string _tel;
		private string _address;
		private string _usersremark;
        private int _dptid;
		/// <summary>
		/// 
		/// </summary>
		public int userId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
        /// <summary>
        /// 
        /// </summary>
        public int dptId
        {
            set { _dptid = value; }
            get { return _dptid; }
        }
		/// <summary>
		/// 
		/// </summary>
		public string usersName
		{
			set{ _usersname=value;}
			get{return _usersname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string usersPwd
		{
			set{ _userspwd=value;}
			get{return _userspwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int roleCode
		{
			set{ _rolecode=value;}
			get{return _rolecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string trueName
		{
			set{ _truename=value;}
			get{return _truename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Flag
		{
			set{ _flag=value;}
			get{return _flag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Tel
		{
			set{ _tel=value;}
			get{return _tel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string usersRemark
		{
			set{ _usersremark=value;}
			get{return _usersremark;}
		}
		#endregion Model

	}
}

