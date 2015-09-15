using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace AutekInfo.Model{
	 	//View_Menu_Option
		public class View_Menu_Option
	{
   		     
      	/// <summary>
		/// menu_name
        /// </summary>		
		private string _menu_name;
        public string menu_name
        {
            get{ return _menu_name; }
            set{ _menu_name = value; }
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
		/// menu_isshow
        /// </summary>		
		private bool _menu_isshow;
        public bool menu_isshow
        {
            get{ return _menu_isshow; }
            set{ _menu_isshow = value; }
        }        
		/// <summary>
		/// menu_pid
        /// </summary>		
		private int _menu_pid;
        public int menu_pid
        {
            get{ return _menu_pid; }
            set{ _menu_pid = value; }
        }        
		/// <summary>
		/// menu_sort
        /// </summary>		
		private int _menu_sort;
        public int menu_sort
        {
            get{ return _menu_sort; }
            set{ _menu_sort = value; }
        }        
		   
	}
}

