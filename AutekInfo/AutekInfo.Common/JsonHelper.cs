using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Web;

namespace AutekInfo.Common
{
    /// <summary>
    /// JSON帮助类
    /// </summary>
    public class JsonHelper
    {
        public StringBuilder result = new StringBuilder();
        public StringBuilder sb = new StringBuilder();
        /// <summary>
        /// 生成表单编辑赋值 JSON格式
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="displayCount"></param>
        /// <returns></returns>
        public static string CreateJsonOne(DataTable dt, bool displayCount)
        {
            StringBuilder JsonString = new StringBuilder();
            //Exception Handling        
            if (dt != null && dt.Rows.Count > 0)
            {

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    JsonString.Append("{ ");
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        if (j < dt.Columns.Count - 1)
                        {
                            JsonString.Append("ipt_" + dt.Columns[j].ColumnName.ToString().ToLower() + ":" + "\"" + dt.Rows[i][j].ToString() + "\",");
                        }
                        else if (j == dt.Columns.Count - 1)
                        {
                            JsonString.Append("ipt_" + dt.Columns[j].ColumnName.ToString().ToLower() + ":" + "\"" + dt.Rows[i][j].ToString() + "\"");
                        }
                    }

                    if (i == dt.Rows.Count - 1)
                    {
                        JsonString.Append("} ");
                    }
                    else
                    {
                        JsonString.Append("}, ");
                    }
                }

                return JsonString.ToString();
            }
            else
            {
                return null;
            }

        }

        
        /// <summary>
        /// 将DataTable中的数据转换成JSON格式
        /// </summary>
        /// <param name="dt">数据源DataTable</param>
        /// <param name="displayCount">是否输出数据总条数</param>
        /// <returns></returns>
        public static string CreateJsonParameters(DataTable dt, bool displayCount)
        {
            return CreateJsonParameters(dt, displayCount, dt.Rows.Count);
        }
        /// <summary>
        /// 将DataTable中的数据转换成JSON格式
        /// </summary>
        /// <param name="dt">数据源DataTable</param>
        /// <returns></returns>
        public static string CreateJsonParameters(DataTable dt)
        {
            return CreateJsonParameters(dt, true);
        }
        /// <summary>
        /// 将DataTable中的数据转换成JSON格式
        /// </summary>
        /// <param name="dt">数据源DataTable</param>
        /// <param name="displayCount">是否输出数据总条数</param>
        /// <param name="totalcount">JSON中显示的数据总条数</param>
        /// <returns></returns>
        public static string CreateJsonParameters(DataTable dt, bool displayCount, int totalcount)
        {
            StringBuilder JsonString = new StringBuilder();
            //Exception Handling        

            if (dt != null)
            {
                JsonString.Append("{ ");
                JsonString.Append("\"rows\":[ ");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    JsonString.Append("{ ");
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        if (j < dt.Columns.Count - 1)
                        {
                            //if (dt.Rows[i][j] == DBNull.Value) continue;
                            if (dt.Columns[j].DataType == typeof(bool))
                            {
                                string b = dt.Rows[i][j].ToString() == "" ? "null" : dt.Rows[i][j].ToString();
                                JsonString.Append("\"" + dt.Columns[j].ColumnName.ToLower() + "\":" +
                                                  b.ToLower() + ",");
                            }
                            else if (dt.Columns[j].DataType == typeof(string))
                            {
                                JsonString.Append("\"" + dt.Columns[j].ColumnName.ToLower() + "\":" + "\"" +
                                                  dt.Rows[i][j].ToString().Replace("\"", "\\\"") + "\",");
                            }
                            else if (dt.Columns[j].DataType == typeof(DateTime))
                            {
                               // JsonString.Append("\"" + dt.Columns[j].ColumnName.ToLower() + "\":" + "\"" + dt.Rows[i][j].ToString().Replace("\"", "\\\"") + "\",");
                                try {
                                    // JsonString.Append("\"" + dt.Columns[j].ColumnName.ToLower() + "\":" + "\"" + DateTime.Parse(dt.Rows[i][j].ToString().Replace("\"", "\\\"")).ToString("yyyy/MM/dd HH:mm:ss") + "\",");
                                    JsonString.Append("\"" + dt.Columns[j].ColumnName.ToLower() + "\":" + "\"" + DateTime.Parse(dt.Rows[i][j].ToString().Replace("\"", "\\\"")).ToString("yyyy-MM-dd HH:mm:ss") + "\",");
                                }
                                catch
                                {
                                    JsonString.Append("\"" + dt.Columns[j].ColumnName.ToLower() + "\":\"" + "\",");
                                }
                                
                            }
                            else
                            {
                                JsonString.Append("\"" + dt.Columns[j].ColumnName.ToLower() + "\":" + "\"" + dt.Rows[i][j] + "\",");
                            }
                        }
                        else if (j == dt.Columns.Count - 1)//倒数第一行
                        {
                            //if (dt.Rows[i][j] == DBNull.Value) continue;
                            if (dt.Columns[j].DataType == typeof(bool))
                            {
                                string b = dt.Rows[i][j].ToString() == "" ? "null" : dt.Rows[i][j].ToString();
                                JsonString.Append("\"" + dt.Columns[j].ColumnName.ToLower() + "\":" +
                                                  b.ToLower());
                            }
                            else if (dt.Columns[j].DataType == typeof(string))
                            {
                                JsonString.Append("\"" + dt.Columns[j].ColumnName.ToLower() + "\":" + "\"" +
                                                  dt.Rows[i][j].ToString().Replace("\"", "\\\"") + "\"");
                            }
                            else if (dt.Columns[j].DataType == typeof(DateTime))
                            {
                                // JsonString.Append("\"" + dt.Columns[j].ColumnName.ToLower() + "\":" + "\"" + dt.Rows[i][j].ToString().Replace("\"", "\\\"") + "\",");
                                try
                                {
                                    // JsonString.Append("\"" + dt.Columns[j].ColumnName.ToLower() + "\":" + "\"" + DateTime.Parse(dt.Rows[i][j].ToString().Replace("\"", "\\\"")).ToString("yyyy/MM/dd HH:mm:ss") + "\",");
                                    JsonString.Append("\"" + dt.Columns[j].ColumnName.ToLower() + "\":" + "\"" + DateTime.Parse(dt.Rows[i][j].ToString().Replace("\"", "\\\"")).ToString("yyyy-MM-dd HH:mm:ss") + "\" ");
                                }
                                catch
                                {
                                    JsonString.Append("\"" + dt.Columns[j].ColumnName.ToLower() + "\":\"" + "\"");
                                }

                            }
                            else
                            {
                                JsonString.Append("\"" + dt.Columns[j].ColumnName.ToLower() + "\":" + "\"" + dt.Rows[i][j] + "\"");
                            }
                        }
                    }
                    /*end Of String*/
                    if (i == dt.Rows.Count - 1)
                    {
                        JsonString.Append("} ");
                    }
                    else
                    {
                        JsonString.Append("}, ");
                    }
                }
                JsonString.Append("]");

                if (displayCount)
                {
                    JsonString.Append(",");

                    JsonString.Append("\"total\":");
                    JsonString.Append(totalcount);
                }

                JsonString.Append("}");
                return JsonString.ToString().Replace("\n", "");
            }
            else
            {
                return null;
            }
        }
        public static string CreateJsonParameters_Train(DataTable dt, bool displayCount, int totalcount)
        {
            StringBuilder JsonString = new StringBuilder();
            //Exception Handling        

            if (dt != null)
            {
                JsonString.Append("{ ");
                JsonString.Append("\"rows\":[ ");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    JsonString.Append("{ ");
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        if (j < dt.Columns.Count - 1)
                        {
                            //if (dt.Rows[i][j] == DBNull.Value) continue;
                            if (dt.Columns[j].DataType == typeof(bool))
                            {
                                string b = dt.Rows[i][j].ToString() == "" ? "null" : dt.Rows[i][j].ToString();
                                JsonString.Append("\"" + dt.Columns[j].ColumnName.ToLower() + "\":" +
                                                  b.ToLower() + ",");
                            }
                            else if (dt.Columns[j].DataType == typeof(string))
                            {
                                JsonString.Append("\"" + dt.Columns[j].ColumnName.ToLower() + "\":" + "\"" +
                                                  dt.Rows[i][j].ToString().Replace("\"", "\\\"") + "\",");
                            }
                            else if (dt.Columns[j].DataType == typeof(DateTime))
                            {
                                // JsonString.Append("\"" + dt.Columns[j].ColumnName.ToLower() + "\":" + "\"" + dt.Rows[i][j].ToString().Replace("\"", "\\\"") + "\",");
                                try
                                {
                                    // JsonString.Append("\"" + dt.Columns[j].ColumnName.ToLower() + "\":" + "\"" + DateTime.Parse(dt.Rows[i][j].ToString().Replace("\"", "\\\"")).ToString("yyyy/MM/dd HH:mm:ss") + "\",");
                                    JsonString.Append("\"" + dt.Columns[j].ColumnName.ToLower() + "\":" + "\"" + DateTime.Parse(dt.Rows[i][j].ToString().Replace("\"", "\\\"")).ToString("yyyy-MM-dd HH:mm:ss") + "\",");
                                }
                                catch { }

                            }
                            else if (dt.Columns[j].DataType == typeof(Decimal))
                            {
                                try
                                {
                                    JsonString.Append("\"" + dt.Columns[j].ColumnName.ToLower() + "\":" + "\"" + System.Decimal.Round(Decimal.Parse(dt.Rows[i][j].ToString()), 2) + "\",");
                                }
                                catch { }

                            }
                            else
                            {
                                JsonString.Append("\"" + dt.Columns[j].ColumnName.ToLower() + "\":" + "\"" + dt.Rows[i][j] + "\",");
                            }
                        }
                        else if (j == dt.Columns.Count - 1)
                        {
                            //if (dt.Rows[i][j] == DBNull.Value) continue;
                            if (dt.Columns[j].DataType == typeof(bool))
                            {
                                string b = dt.Rows[i][j].ToString() == "" ? "null" : dt.Rows[i][j].ToString();
                                JsonString.Append("\"" + dt.Columns[j].ColumnName.ToLower() + "\":" +
                                                  b.ToLower());
                            }
                            else if (dt.Columns[j].DataType == typeof(string))
                            {
                                JsonString.Append("\"" + dt.Columns[j].ColumnName.ToLower() + "\":" + "\"" +
                                                  dt.Rows[i][j].ToString().Replace("\"", "\\\"") + "\"");
                            }
                            else
                            {
                                JsonString.Append("\"" + dt.Columns[j].ColumnName.ToLower() + "\":" + "\"" + dt.Rows[i][j] + "\"");
                            }
                        }
                    }
                    /*end Of String*/
                    if (i == dt.Rows.Count - 1)
                    {
                        JsonString.Append("} ");
                    }
                    else
                    {
                        JsonString.Append("}, ");
                    }
                }
                JsonString.Append("]");

                if (displayCount)
                {
                    JsonString.Append(",");

                    JsonString.Append("\"total\":");
                    JsonString.Append(totalcount);
                }

                JsonString.Append("}");
                return JsonString.ToString().Replace("\n", "");
            }
            else
            {
                return null;
            }
        }
        #region object 2 json

        private static void WriteDataRow(StringBuilder sb, DataRow row)
        {
            sb.Append("{");
            foreach (DataColumn column in row.Table.Columns)
            {
                sb.AppendFormat("\"{0}\":", column.ColumnName);
                WriteValue(sb, row[column]);
                sb.Append(",");
            }
            // Remove the trailing comma.
            if (row.Table.Columns.Count > 0)
            {
                --sb.Length;
            }
            sb.Append("}");
        }

        private static void WriteDataSet(StringBuilder sb, DataSet ds)
        {
            sb.Append("{\"Tables\":{");
            foreach (DataTable table in ds.Tables)
            {
                sb.AppendFormat("\"{0}\":", table.TableName);
                WriteDataTable(sb, table);
                sb.Append(",");
            }
            // Remove the trailing comma.
            if (ds.Tables.Count > 0)
            {
                --sb.Length;
            }
            sb.Append("}}");
        }

        private static void WriteDataTable(StringBuilder sb, DataTable table)
        {
            sb.Append("{\"Rows\":[");
            foreach (DataRow row in table.Rows)
            {
                WriteDataRow(sb, row);
                sb.Append(",");
            }
            // Remove the trailing comma.
            if (table.Rows.Count > 0)
            {
                --sb.Length;
            }
            sb.Append("]}");
        }

        private static void WriteEnumerable(StringBuilder sb, IEnumerable e)
        {
            bool hasItems = false;
            sb.Append("[");
            foreach (object val in e)
            {
                WriteValue(sb, val);
                sb.Append(",");
                hasItems = true;
            }
            // Remove the trailing comma.
            if (hasItems)
            {
                --sb.Length;
            }
            sb.Append("]");
        }

        private static void WriteHashtable(StringBuilder sb, IDictionary e)
        {
            bool hasItems = false;
            sb.Append("{");
            foreach (string key in e.Keys)
            {
                sb.AppendFormat("\"{0}\":", key.ToLower());
                WriteValue(sb, e[key]);
                sb.Append(",");
                hasItems = true;
            }
            // Remove the trailing comma.
            if (hasItems)
            {
                --sb.Length;
            }
            sb.Append("}");
        }

        private static void WriteObject(StringBuilder sb, object o)
        {
            MemberInfo[] members = o.GetType().GetMembers(BindingFlags.Instance | BindingFlags.Public);
            sb.Append("{");
            bool hasMembers = false;
            foreach (MemberInfo member in members)
            {
                bool hasValue = false;
                object val = null;
                if ((member.MemberType & MemberTypes.Field) == MemberTypes.Field)
                {
                    FieldInfo field = (FieldInfo)member;
                    val = field.GetValue(o);
                    hasValue = true;
                }
                else if ((member.MemberType & MemberTypes.Property) == MemberTypes.Property)
                {
                    PropertyInfo property = (PropertyInfo)member;
                    if (property.CanRead && property.GetIndexParameters().Length == 0)
                    {
                        val = property.GetValue(o, null);
                        hasValue = true;
                    }
                }
                if (hasValue)
                {
                    sb.Append("\"");
                    sb.Append(member.Name);
                    sb.Append("\":");
                    WriteValue(sb, val);
                    sb.Append(",");
                    hasMembers = true;
                }
            }
            if (hasMembers)
            {
                --sb.Length;
            }
            sb.Append("}");
        }

        private static void WriteString(StringBuilder sb, IEnumerable s)
        {
            sb.Append("\"");
            foreach (char c in s)
            {
                switch (c)
                {
                    case '\"':
                        sb.Append("\\\"");
                        break;
                    case '\\':
                        sb.Append("\\\\");
                        break;
                    case '\b':
                        sb.Append("\\b");
                        break;
                    case '\f':
                        sb.Append("\\f");
                        break;
                    case '\n':
                        sb.Append("\\n");
                        break;
                    case '\r':
                        sb.Append("\\r");
                        break;
                    case '\t':
                        sb.Append("\\t");
                        break;
                    default:
                        int i = c;
                        if (i < 32 || i > 127)
                        {
                            sb.AppendFormat("\\u{0:X04}", i);
                        }
                        else
                        {
                            sb.Append(c);
                        }
                        break;
                }
            }
            sb.Append("\"");
        }

        public static void WriteValue(StringBuilder sb, object val)
        {
            if (val == null || val == DBNull.Value)
            {
                sb.Append("null");
            }
            else if (val is string || val is Guid)
            {
                WriteString(sb, val.ToString());
            }
            else if (val is bool)
            {
                sb.Append(val.ToString().ToLower());
            }
            else if (val is double ||
                     val is float ||
                     val is long ||
                     val is int ||
                     val is short ||
                     val is byte ||
                     val is decimal)
            {
                sb.AppendFormat(CultureInfo.InvariantCulture.NumberFormat, "{0}", val);
            }
            else if (val.GetType().IsEnum)
            {
                sb.Append((int)val);
            }
            else if (val is DateTime)
            {
                sb.Append("new Date(\"");
                sb.Append(((DateTime)val).ToString("MMMM, d yyyy HH:mm:ss",
                                                    new CultureInfo("en-US", false).DateTimeFormat));
                sb.Append("\")");
            }
            else if (val is DataSet)
            {
                WriteDataSet(sb, val as DataSet);
            }
            else if (val is DataTable)
            {
                WriteDataTable(sb, val as DataTable);
            }
            else if (val is DataRow)
            {
                WriteDataRow(sb, val as DataRow);
            }
            else if (val is Hashtable)
            {
                WriteHashtable(sb, val as Hashtable);
            }
            else if (val is IEnumerable)
            {
                WriteEnumerable(sb, val as IEnumerable);
            }
            else
            {
                WriteObject(sb, val);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static string Convert2Json(object o)
        {
            StringBuilder sb = new StringBuilder();
            WriteValue(sb, o);
            return sb.ToString();
        }

        #endregion

        
        #region 根据DataTable生成Json树结构 同步
        /// <summary>
        /// 根据DataTable生成Json树结构 同步
        /// </summary>
        /// <param name="table">数据源</param>
        /// <param name="idCol">ID列</param>
        /// <param name="txtCol">Text列</param>
        /// <param name="rela">主键</param>
        /// <param name="pid">父ID</param>        
        
        public string GetTreeJsonByTableSyn(DataTable table, string idCol, string txtCol, string rela, int pid)
        {
            result.Append(sb.ToString());
            sb.Remove(0, sb.Length);
            if (table.Rows.Count > 0)
            {
                sb.Append("[");
                string filter = null;
                if (pid == 0)
                {
                    filter = rela + "=0";
                }
                else
                {
                    filter = rela + "=" + pid;
                }
                DataRow[] rows = table.Select(filter);
                if (rows.Length > 0)
                {
                    foreach (DataRow row in rows)
                    {
                        sb.Append("{\"id\":" + row[idCol] + ",\"text\":\"" + row[txtCol] + "\",\"state\":\"\"");
                        if (table.Select(string.Format("{0}='{1}'", rela, row[idCol])).Length > 0)
                        {
                            sb.Append(",\"children\":");
                            GetTreeJsonByTableSyn(table, idCol, txtCol, rela, Convert.ToInt32(row[idCol]));
                            result.Append(sb.ToString());
                            sb.Remove(0, sb.Length);
                        }
                        result.Append(sb.ToString());
                        sb.Remove(0, sb.Length);
                        sb.Append("},");
                    }
                    sb = sb.Remove(sb.Length - 1, 1);
                }
                sb.Append("]");
                result.Append(sb.ToString());
                sb.Remove(0, sb.Length);
            }
            return result.ToString();
        }
        #endregion
        /// <summary>
        /// 根据DataTable生成Json树结构    异步      
        public static string GetTreeJsonByTable(DataTable table, string idCol, string txtCol, string rela, int pid,string picon,string icon)
        {
            StringBuilder sb = new StringBuilder();
            if (table.Rows.Count > 0)
            {
                sb.Append("[");
                string filter = null;
                 if (pid == 0)
                {
                    filter = rela+" =0";                     
                }
                else 
                {
                    filter = rela+"="+pid;   
                }   
                DataRow[]  rows = table.Select(filter);
                if (rows.Length > 0)
                {
                    foreach (DataRow row in rows)
                    {
                        sb.Append("{\"id\":" + row[idCol] + ",\"text\":\"" + row[txtCol] + "\",\"state\":\"");
                        if (table.Select(string.Format("{0}='{1}'", rela, row[idCol])).Length > 0)
                        {
                            sb.Append("closed\",\"iconCls\":\""+picon+"\"");
                        }
                        else 
                        {
                            sb.Append("\",\"iconCls\":\"" + icon + "\"");
                        }
                        sb.Append("},");
                    }
                    sb = sb.Remove(sb.Length - 1, 1);
                }
                sb.Append("]");
            }
            return sb.ToString();
        }
        /// <summary>
        /// 根据DataTable生成Json树结构    异步      
        public static string GetTreeJsonByTable(DataTable table, string idCol, string txtCol, string rela, int pid)
        {
            StringBuilder sb = new StringBuilder();
            if (table.Rows.Count > 0)
            {
                sb.Append("[");
                string filter = null;
                if (pid == 0)
                {
                    filter = rela +"=0";
                }
                else
                {
                    filter = rela + "=" + pid;
                }
                DataRow[] rows = table.Select(filter);
                if (rows.Length > 0)
                {
                    foreach (DataRow row in rows)
                    {
                        sb.Append("{\"id\":" + row[idCol] + ",\"text\":\"" + row[txtCol] + "\",\"state\":\"");
                        if (table.Select(string.Format("{0}='{1}'", rela, row[idCol])).Length > 0)
                        {
                            sb.Append("closed\"");
                        }
                        else
                        {
                            sb.Append("\"");
                        }
                        sb.Append("},");
                    }
                    sb = sb.Remove(sb.Length - 1, 1);
                }
                sb.Append("]");
            }
            return sb.ToString();
        }
        /// <summary>
        /// 仅获取group id，group name
        /// </summary>
        /// <param name="table"></param>
        /// <param name="idCol"></param>
        /// <param name="txtCol"></param>
        /// <param name="rela"></param>
        /// <param name="pid"></param>
        /// <param name="picon"></param>
        /// <param name="icon"></param>
        /// <returns></returns>
        public static string GetSomeColJsonByTable(DataTable table, string idCol, string txtCol,string Where)
        {
            StringBuilder sb = new StringBuilder();
            if (table.Rows.Count > 0)
            {
                sb.Append("[");
                string filter = Where;                
                DataRow[] rows = table.Select(filter);
                if (rows.Length > 0)
                {
                    foreach (DataRow row in rows)
                    {
                        sb.Append("{\""+idCol+"\":" + row[idCol] + ",\""+txtCol+"\":\"" + row[txtCol] + "\"");
                        
                        sb.Append("},");
                    }
                    sb = sb.Remove(sb.Length - 1, 1);
                }
                sb.Append("]");
            }
            return sb.ToString();
        }
        public static string GetMyTreeJsonByTable(DataTable table, string url, string idCol, string txtCol, string rela, int pid, string icon)
        {
            StringBuilder sb = new StringBuilder();
            if (table.Rows.Count > 0)
            {
                sb.Append("[");
                string filter = null;
                if (pid == 0)
                {
                    filter = rela + " =0";
                }
                else
                {
                    filter = rela + "=" + pid;
                }
                DataRow[] rows = table.Select(filter, "menu_sort");
                if (rows.Length > 0)
                {
                    foreach (DataRow row in rows)
                    {
                        sb.Append("{\"id\":" + row[idCol] + ",\"text\":\"" + row[txtCol] + "\",\"state\":\"");
                        if (table.Select(string.Format("{0}='{1}'", rela, row[idCol])).Length > 0)
                        {
                            sb.Append("closed\",\"iconCls\":\"" + row[icon] + "\"," + "\"attributes\":{" + "\"url\":" + "\"" + row[url] + "\"" + "}");
                        }
                        else
                        {
                            sb.Append("\",\"iconCls\":\"" + row[icon] + "\"," + "\"attributes\":{" + "\"url\":" + "\"" + row[url] + "\"" + "}");
                        }
                        sb.Append("},");
                    }
                    sb = sb.Remove(sb.Length - 1, 1);
                }
                sb.Append("]");
            }
            return sb.ToString();
        }
        #region list to eayui tree 同步
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="idfeild"></param>
        /// <param name="pidfield"></param>
        /// <param name="textfield"></param>
        /// <param name="pid"></param>
        /// <returns></returns>
        public string GetOcharTree<T>(List<T> list, string idfeild, string pidfield, string textfield, int pid)
        {
            
            result.Append(sb.ToString());
            sb.Remove(0, sb.Length);
            if (list.Count > 0)
            {
                sb.Append("[");
                List<T> list_filter = list.FindAll(o => (int)o.GetType().GetProperty(pidfield).GetValue(o, null) == pid);
                //List<AutekInfo.Model.Emp_Dept> list_filter = list.FindAll(dept => dept.dept_pid == pid);
                if (list_filter.Count > 0)
                {
                    // foreach (AutekInfo.Model.Emp_Dept d in list_filter)
                    foreach (T d in list_filter)
                    {
                        sb.Append("{\"id\":" + d.GetType().GetProperty(idfeild).GetValue(d, null) + ",\"text\":\"" + d.GetType().GetProperty(textfield).GetValue(d, null) + "\",\"state\":\"");
                        ///                        sb.Append("{\"id\":" + d.dept_id + ",\"text\":\"" + d.dept_name + "\",\"state\":\"");
                        // if (list.FindAll(dept => dept.dept_pid == d.dept_id).Count > 0)
                        if (list.FindAll(o => (int)o.GetType().GetProperty(pidfield).GetValue(o, null) == (int)d.GetType().GetProperty(idfeild).GetValue(d, null)).Count > 0)
                        {
                            sb.Append("closed\",\"children\":");
                            // GetOcharTree(list, d.dept_id);
                            GetOcharTree(list, idfeild, pidfield, textfield, (int)d.GetType().GetProperty(idfeild).GetValue(d, null));
                            result.Append(sb.ToString());
                            sb.Remove(0, sb.Length);
                        }
                        else
                        {
                            sb.Append("open\"");
                        }
                        result.Append(sb.ToString());
                        sb.Remove(0, sb.Length);
                        sb.Append("},");
                    }
                    sb = sb.Remove(sb.Length - 1, 1);
                }
                sb.Append("]");
                result.Append(sb.ToString());
                sb.Remove(0, sb.Length);
            }
            return result.ToString();
        }
        #endregion
        #region list to datagrid with count

        public static string GetGridJson<T>(List<T> list, int count,string datefmt)
        { 
             StringBuilder JsonString = new StringBuilder();
            if (list.Count>0)
            {
                JsonString.Append("{ ");
                JsonString.Append("\"rows\": ");
                IsoDateTimeConverter timeConverter = new IsoDateTimeConverter();
               // timeConverter.DateTimeFormat = "yyyy'-'MM'-'dd' 'HH':'mm':'ss";
                timeConverter.DateTimeFormat = datefmt;
                JsonString.Append(JsonConvert.SerializeObject(list, Formatting.Indented, timeConverter));
                JsonString.Append(",\"total\":");
                JsonString.Append(count);
                 JsonString.Append("}");
            }
            return JsonString.ToString();
        }
        /// <summary>
        /// 序列化部分属性
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="count"></param>
        /// <param name="datefmt"></param>
        /// <returns></returns>
        public static string GetPartAttr<T>(List<T> list, string[] arr_f)
        {
            StringBuilder JsonString = new StringBuilder();
            JsonString.Append("[ ");
            if (list.Count > 0)
            {
                
                foreach (T t in list)
                {
                    JsonString.Append("{");
                    foreach (string f in arr_f)
                    {
                        JsonString.Append("\"" + f + "\":");
                        if (t.GetType().GetProperty(f).GetValue(t, null).GetType() == typeof(int))
                        {
                            JsonString.Append( t.GetType().GetProperty(f).GetValue(t, null) + ",");
                        }
                        else
                        {
                            JsonString.Append("\"" + t.GetType().GetProperty(f).GetValue(t, null) + "\",");
                        }
                        
                    }
                    JsonString = JsonString.Remove(JsonString.Length - 1, 1);
                    if (list.IndexOf(t) == list.Count - 1)
                    {
                        JsonString.Append("}");
                    }
                    else
                    {
                        JsonString.Append("},");
                    }
                }
            }
            JsonString.Append("]");
            return JsonString.ToString();
        }

        #endregion

       
    }
    

}