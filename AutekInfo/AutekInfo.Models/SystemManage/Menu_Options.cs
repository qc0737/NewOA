using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace AutekInfo.Model{
	 	//Menu_Options
		public class Menu_Options
	{
   		     
      	/// <summary>
		/// option_id
        /// </summary>		
		private int _option_id;
        public int option_id
        {
            get{ return _option_id; }
            set{ _option_id = value; }
        }        
		/// <summary>
		/// menu_id
        /// </summary>		
		private int _menu_id;
        public int menu_id
        {
            get{ return _menu_id; }
            set{ _menu_id = value; }
        }        
		/// <summary>
		/// option_code
        /// </summary>		
		private string _option_code;
        public string option_code
        {
            get{ return _option_code; }
            set{ _option_code = value; }
        }        
		/// <summary>
		/// option_name
        /// </summary>		
		private string _option_name;
        public string option_name
        {
            get{ return _option_name; }
            set{ _option_name = value; }
        }        
		/// <summary>
		/// option_desc
        /// </summary>		
		private string _option_desc;
        public string option_desc
        {
            get{ return _option_desc; }
            set{ _option_desc = value; }
        }        
		   
	}
}

