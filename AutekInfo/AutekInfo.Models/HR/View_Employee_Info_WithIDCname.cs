using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace AutekInfo.Model{
	 	//View_Employee_Info
    public class View_Employee_Info_WithIDCname
	{
   		     
      	/// <summary>
		/// emp_id
        /// </summary>		
		private int _emp_id;
        public int emp_id
        {
            get{ return _emp_id; }
            set{ _emp_id = value; }
        }        
		/// <summary>
		/// emp_dept
        /// </summary>		
		   
		/// <summary>
		/// emp_cnname
        /// </summary>		
		private string _emp_cnname;
        public string emp_cnname
        {
            get{ return _emp_cnname; }
            set{ _emp_cnname = value; }
        }        
		
	}
}

