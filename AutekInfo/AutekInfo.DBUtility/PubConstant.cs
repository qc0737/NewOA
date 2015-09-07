using System;
using System.Configuration;
//using AutekInfo.Common.DEncrypt;

namespace AutekInfo.DBUtility
{
    
    public class PubConstant
    {        
        /// <summary>
        /// 获取连接字符串
        /// </summary>
        public static string AutekOAConnection
        {
            get
            {
                string _connectionString = ConfigurationManager.ConnectionStrings["AutekOAConnection"].ConnectionString;
                //string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"]; 
                //if (ConStringEncrypt == "true")
                //{ _connectionString = DESEncrypt.DecryptDES(_connectionString, "expresss"); } 
                return _connectionString;
            }
        }
      
      
        
    }
}
