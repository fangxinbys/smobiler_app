using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// PocketTaskRec:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PocketTaskRec
	{
		public PocketTaskRec()
		{}
		#region Model
		private int _pockettaskrecid;
		private string _pocketrecuser;
		private string _pocketrecid;
		/// <summary>
		/// 
		/// </summary>
		public int pocketTaskRecId
		{
			set{ _pockettaskrecid=value;}
			get{return _pockettaskrecid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pocketRecUser
		{
			set{ _pocketrecuser=value;}
			get{return _pocketrecuser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pocketRecId
		{
			set{ _pocketrecid=value;}
			get{return _pocketrecid;}
		}
		#endregion Model

	}
}

