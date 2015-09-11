using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Web;
using NPOI;
//using NPOI.Util;
//using NPOI.XSSF;
//using NPOI.SS.UserModel;
//using NPOI.XSSF.UserModel;
//using NPOI.XSSF.Util;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using System.Text.RegularExpressions;

namespace AutekInfo.Common
{
    public class ExcelHelper
    {
        static string path_temp = System.Web.HttpContext.Current.Server.MapPath(@"~/UserFiles/TempFiles/");
        static string path_modle = System.Web.HttpContext.Current.Server.MapPath(@"~/UserFiles/Modle/");
        public static string OutputList<T>(List<ExcTitvsFeilds> list_title, List<T> list_m)
        {
            int rowIndex = 0;
            int colIndex = 0;
            //FileStream file = new FileStream(path_modle + "\\Roles.xlsx", FileMode.Open, FileAccess.Read);
            //IWorkbook workbook = new XSSFWorkbook(file);
            //ISheet sheet = workbook.GetSheet("Roles");
            //- 创建 Excel
           IWorkbook workbook = new XSSFWorkbook(); 
            //- 创建 Sheet
           ISheet sheet = workbook.CreateSheet("Roles");
            //写表头
           // IRow row = sheet.GetRow(0);
            IRow row = sheet.CreateRow(rowIndex);
            
         // ICell cell1 = row.CreateCell(colIndex);
            ICellStyle cellStyle = workbook.CreateCellStyle();
            cellStyle.FillForegroundColor = NPOI.HSSF.Util.HSSFColor.LIGHT_CORNFLOWER_BLUE.index;
            cellStyle.FillPattern = NPOI.SS.UserModel.FillPatternType.SOLID_FOREGROUND;
            cellStyle.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.CENTER;
            cellStyle.Alignment = NPOI.SS.UserModel.HorizontalAlignment.CENTER;

            //写表头
            foreach (var t in list_title)
            {
                sheet.SetColumnWidth(colIndex, 20 * 256);
                ICell cell = row.CreateCell(colIndex);
                cell.CellStyle = cellStyle;
                cell.SetCellValue(t.Title);                
                colIndex++;                
            }
            //写表身内容
            colIndex=0;
            foreach (var m in list_m)
            {
                IRow _row = sheet.CreateRow(++rowIndex);
                colIndex=0;
                //var t = list_title[colIndex];
                //cell.CellStyle = cellStyle;
                foreach (var t in list_title)
                {
                    ICell cell = _row.CreateCell(colIndex);
                    cell.SetCellValue(m.GetType().GetProperty(t.feild).GetValue(m, null).ToString());
                    colIndex++;
                }
            }
            //默认设置筛选功能
            sheet.SetAutoFilter(CellRangeAddress.ValueOf("A1:"+ToName(colIndex-1)+"1"));
            string filename = path_temp + DateTime.Now.ToString("yyyyMMddHHmmssff") + ".xlsx";
            FileStream file = new FileStream(filename, FileMode.Create);
            //MemoryStream ms = new MemoryStream();
            //workbook.Write(ms);
            workbook.Write(file);
            file.Close();
            return filename;
        }
        #region - 由数字转换为Excel中的列字母 -

        public static int ToIndex(string columnName)
        {
            if (!Regex.IsMatch(columnName.ToUpper(), @"[A-Z]+")) { throw new Exception("invalid parameter"); }
            int index = 0;
            char[] chars = columnName.ToUpper().ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                index += ((int)chars[i] - (int)'A' + 1) * (int)Math.Pow(26, chars.Length - i - 1);
            }
            return index - 1;
        }

        public static string ToName(int index)
        {
            if (index < 0) { throw new Exception("invalid parameter"); }
            List<string> chars = new List<string>();
            do
            {
                if (chars.Count > 0) index--;
                chars.Insert(0, ((char)(index % 26 + (int)'A')).ToString());
                index = (int)((index - index % 26) / 26);
            } while (index > 0);
            return String.Join(string.Empty, chars.ToArray());
        }
        #endregion
       
    }
}
