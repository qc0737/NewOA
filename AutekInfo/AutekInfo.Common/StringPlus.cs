using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
namespace AutekInfo.Common
{
    public class StringPlus
    {
        public static List<string> GetStrArray(string str, char speater,bool toLower)
        {
            List<string> list = new List<string>();
            string[] ss =  str.Split(speater);
            foreach (string s in ss)
            {
                if (!string.IsNullOrEmpty(s) &&s !=speater.ToString())
                {
                    string strVal = s;
                    if (toLower)
                    {
                        strVal = s.ToLower();
                    }
                    list.Add(strVal);
                }
            }
            return list;
        }
        public static string[] GetStrArray(string str)
        {
            return str.Split(new char[',']);
        }
        public static string GetArrayStr(List<string> list,string speater)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                if (i == list.Count - 1)
                {
                    sb.Append(list[i]);
                }
                else
                {
                    sb.Append(list[i]);
                    sb.Append(speater);
                }
            }
            return sb.ToString();
        }
        
        
        #region 删除最后一个字符之后的字符

        /// <summary>
        /// 删除最后结尾的一个逗号
        /// </summary>
        public static string DelLastComma(string str)
        {
            return str.Substring(0, str.LastIndexOf(","));
        }

        /// <summary>
        /// 删除最后结尾的指定字符后的字符
        /// </summary>
        public static string DelLastChar(string str,string strchar)
        {
            return str.Substring(0, str.LastIndexOf(strchar));
        }

        #endregion




        /// <summary>
        /// 转全角的函数(SBC case)
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ToSBC(string input)
        {
            //半角转全角：
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 32)
                {
                    c[i] = (char)12288;
                    continue;
                }
                if (c[i] < 127)
                    c[i] = (char)(c[i] + 65248);
            }
            return new string(c);
        }        

        /// <summary>
        ///  转半角的函数(SBC case)
        /// </summary>
        /// <param name="input">输入</param>
        /// <returns></returns>
        public static string ToDBC(string input)
        {
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 12288)
                {
                    c[i] = (char)32;
                    continue;
                }
                if (c[i] > 65280 && c[i] < 65375)
                    c[i] = (char)(c[i] - 65248);
            }
            return new string(c);
        }

        public static List<string> GetSubStringList(string o_str, char sepeater)
        {
            List<string> list = new List<string>();
            string[] ss = o_str.Split(sepeater);
            foreach (string s in ss)
            {
                if (!string.IsNullOrEmpty(s) && s != sepeater.ToString())
                {
                    list.Add(s);
                }
            }
            return list;
        }


        #region 将字符串样式转换为纯字符串
        public static string GetCleanStyle(string StrList, string SplitString)
        {
            string RetrunValue = "";
            //如果为空，返回空值
            if (StrList == null)
            {
                RetrunValue = "";
            }
            else
            {
                //返回去掉分隔符
                string NewString = "";
                NewString = StrList.Replace(SplitString, "");
                RetrunValue = NewString;
            }
            return RetrunValue;
        }
        #endregion

        #region 将字符串转换为新样式
        public static string GetNewStyle(string StrList, string NewStyle, string SplitString, out string Error)
        {
            string ReturnValue = "";
            //如果输入空值，返回空，并给出错误提示
            if (StrList == null)
            {
                ReturnValue = "";
                Error = "请输入需要划分格式的字符串";
            }
            else
            {
                //检查传入的字符串长度和样式是否匹配,如果不匹配，则说明使用错误。给出错误信息并返回空值
                int strListLength = StrList.Length;
                int NewStyleLength = GetCleanStyle(NewStyle, SplitString).Length;
                if (strListLength != NewStyleLength)
                {
                    ReturnValue = "";
                    Error = "样式格式的长度与输入的字符长度不符，请重新输入";
                }
                else
                {
                    //检查新样式中分隔符的位置
                    string Lengstr = "";
                    for (int i = 0; i < NewStyle.Length; i++)
                    {
                        if (NewStyle.Substring(i, 1) == SplitString)
                        {
                            Lengstr = Lengstr + "," + i;
                        }
                    }
                    if (Lengstr != "")
                    {
                        Lengstr = Lengstr.Substring(1);
                    }
                    //将分隔符放在新样式中的位置
                    string[] str = Lengstr.Split(',');
                    foreach (string bb in str)
                    {
                        StrList = StrList.Insert(int.Parse(bb), SplitString);
                    }
                    //给出最后的结果
                    ReturnValue = StrList;
                    //因为是正常的输出，没有错误
                    Error = "";
                }
            }
            return ReturnValue;
        }
        #endregion
        #region 判断mime type
       // public static bool CheckContenttype(string contenttype,string filename)
        public static bool CheckContenttype(string filename)
        {
            bool f = false;
            string f_type = ConfigurationManager.AppSettings["uploadfiletype"].ToLower();
            string[] arr=f_type.Split(',');
            foreach (string type in arr)
            {
                if (filename.Length > 4)
                {
                    if (filename.Substring(filename.Length - 4, 4).ToLower() == type)
                    {
                        return true;
                    }
                }
                if (filename.Length > 5)
                {
                    if (filename.Substring(filename.Length - 5, 5).ToLower() == type)
                    {
                        return true;
                    }
                }
               
            }
            //switch (contenttype)
            //{
            //    case "text/xml":
            //    case "text/html":
            //    case "image/jpeg":
            //    case "image/gif":
            //    case "image/png":                    
            //    case "application/ms-powerpoint":
            //    case "application/x-ppt":
            //    case "application/x-png":
            //    case "application/msword":
            //    case "application/x-msdownload":
            //    case "application/vnd.ms-excel":
            //    case "application/vnd.ms-powerpoint":
            //    case "application/x-img":
            //    case "application/x-bmp":
            //    case "application/zip":
            //    case "application/vnd.openxmlformats-officekdocument.wordprocessingml.template":
            //    case "application/vnd.openxmlformats-officedocument.presentationml.presentation":
            //    case "application/vnd.openxmlformats-officedocument.presentationml.slideshow":
            //    case "application/vnd.openxmlformats-officedocument.presentationml.template":
            //    case "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet":
            //    case "application/vnd.openxmlformats-officedocument.spreadsheetml.template":
            //    case "application/pdf":
            //    case "application/vnd.ms-outlook":
            //    case "application/x-zip-compressed":
            //        f = true;
            //        break;
            //    default:
            //        f = false;
            //        break;
            //}
            //switch (filename.Substring(filename.Length-4,4).ToLower())
            //{
            //    case ".msg":
            //    case ".pdf":
            //    case ".xls":                
            //    case ".doc":                
            //    case ".ppt":                
            //    case ".xml":
            //    case ".txt":
            //    case ".vsd":
            //    case ".zip":                
            //    case ".jpg":               
            //    case ".bmp":
            //    case ".png":
            //    case ".gif":                
            //    case ".mp3":
            //    case ".mp4":
            //    case ".tif":                
            //        f = true;
            //        break;               
            //}
            //switch (filename.Substring(filename.Length - 5, 5).ToLower())
            //{
            //    case ".xlsx":
            //    case ".docx":
            //    case ".pptx":
            //    case ".jpeg":
            //    case ".html":
            //        f = true;
            //        break;
            //}
            return f;
        }
        #endregion
    }
}
