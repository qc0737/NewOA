﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace AutekInfo.Common
{
    public class LogManager
    {

        private static string logp = ConfigurationManager.AppSettings["LogPath"];
        private static string logPath = "";        
        public static string LogPath
        {
            get
            {
                if (logPath == string.Empty)
                {
                    logPath = AppDomain.CurrentDomain.BaseDirectory;
                }
                return logPath;
            }
            set { logPath = value; }
        }


        /// <summary>
        /// 写日志
        /// </summary>
        public static void WriteLog(string msg)
        {
            WriteLog("", msg);
        }

        
        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="prev">前缀</param>
        /// <param name="msg"></param>
        public static void WriteLog(string prev, string msg)
        {
            try
            {
                System.IO.StreamWriter sw = System.IO.File.AppendText(
                    LogPath + "/"+logp+"/" + prev +
                    DateTime.Now.ToString("yyyyMMdd") + ".Log"
                    );
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                sw.WriteLine(msg);
                sw.Close();
            }
            catch
            {

            }
        }

    } 
}
