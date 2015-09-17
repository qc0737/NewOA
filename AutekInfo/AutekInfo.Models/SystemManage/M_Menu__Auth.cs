using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace AutekInfo.Model{
	 	//M_Menu_Auth
		public class M_Menu_Auth
	{
   		     
      	/// <summary>
		/// id
        /// </summary>		
		private int _id;
        public int id
        {
            get{ return _id; }
            set{ _id = value; }
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
		/// <summary>
		/// menu_options
        /// </summary>		
		private string _menu_options;
        public string menu_options
        {
            get{ return _menu_options; }
            set{ _menu_options = value; }
        }        
		   
	}
}

