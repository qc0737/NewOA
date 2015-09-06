using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace AutekInfo.Model{
	 	//Menu
		public class Menu
	{
   		     
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
		/// menu_icon
        /// </summary>		
		private string _menu_icon;
        public string menu_icon
        {
            get{ return _menu_icon; }
            set{ _menu_icon = value; }
        }        
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
		/// menu_pid
        /// </summary>		
		private int _menu_pid;
        public int menu_pid
        {
            get{ return _menu_pid; }
            set{ _menu_pid = value; }
        }        
		/// <summary>
		/// menu_link
        /// </summary>		
		private string _menu_link;
        public string menu_link
        {
            get{ return _menu_link; }
            set{ _menu_link = value; }
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
		/// <summary>
		/// menu_isshow
        /// </summary>		
		private bool _menu_isshow;
        public bool menu_isshow
        {
            get{ return _menu_isshow; }
            set{ _menu_isshow = value; }
        }        
		   
	}
}

