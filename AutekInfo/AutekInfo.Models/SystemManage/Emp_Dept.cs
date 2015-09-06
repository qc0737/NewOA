using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace AutekInfo.Model
{
	 	//Emp_Dept
		public class Emp_Dept
	{
   		     
      	/// <summary>
		/// dept_id
        /// </summary>		
		private int _dept_id;
        public int dept_id
        {
            get{ return _dept_id; }
            set{ _dept_id = value; }
        }        
		/// <summary>
		/// dept_name
        /// </summary>		
		private string _dept_name;
        public string dept_name
        {
            get{ return _dept_name; }
            set{ _dept_name = value; }
        }        
		/// <summary>
		/// dept_code
        /// </summary>		
		private string _dept_code;
        public string dept_code
        {
            get{ return _dept_code; }
            set{ _dept_code = value; }
        }        
		/// <summary>
		/// dept_pid
        /// </summary>		
		private int _dept_pid;
        public int dept_pid
        {
            get{ return _dept_pid; }
            set{ _dept_pid = value; }
        }        
		/// <summary>
		/// dept_order
        /// </summary>		
		private int _dept_order;
        public int dept_order
        {
            get{ return _dept_order; }
            set{ _dept_order = value; }
        }        
		   
	}
}

