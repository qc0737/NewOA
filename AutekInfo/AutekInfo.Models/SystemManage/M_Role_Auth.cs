using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace AutekInfo.Model{
	 	//M_Role_Auth
		public class M_Role_Auth
	{
   		     
      	/// <summary>
		/// m_role_auth_id
        /// </summary>		
		private int _m_role_auth_id;
        public int m_role_auth_id
        {
            get{ return _m_role_auth_id; }
            set{ _m_role_auth_id = value; }
        }        
		/// <summary>
		/// role_id
        /// </summary>		
		private int _role_id;
        public int role_id
        {
            get{ return _role_id; }
            set{ _role_id = value; }
        }        
		/// <summary>
		/// auth_id
        /// </summary>		
		private int _auth_id;
        public int auth_id
        {
            get{ return _auth_id; }
            set{ _auth_id = value; }
        }        
		   
	}
}

