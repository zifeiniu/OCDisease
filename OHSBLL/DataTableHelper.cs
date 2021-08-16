using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace OHSUploadLibrary
{
    /// <summary>
    /// DataTable 扩展方法
    /// </summary>
    public static class DataTableExt
    {

        public static void AddOrUpdateTable(this DataSet ds, DataTable table) 
        {
            if (ds.Tables.Contains(table.TableName))
            {
                ds.Tables.Remove(table.TableName);
            }

            ds.Tables.Add(table);

        }

        /// <summary>
        /// 设置Datatable 第一行到Dic字典中，列名为Key
        /// </summary>
        /// <param name="table"></param>
        /// <param name="DicData"></param>
        public static void SetFirstRowToDic(this Dictionary<string, string> DicData, DataTable table)
        {
            if (table != null && table.Rows.Count > 0)
            {
                for (int c = 0; c < table.Columns.Count; c++)
                {
                    //Dic 里添加两种Key，一种是 列名称，如CORPNAME
                    
                    string ColumnName = table.Columns[c].ColumnName;

                    string value = table.Rows[0][ColumnName].ToString();

                    DicData.TryAddData(ColumnName.ToUpper(), value);
                    //第二种，添加表名.列名T_ORDER.CORPNAME 因为会添加多张不同的表，列名会重复，导致不确定是哪张表的列
                    string keyNameWithTableName = table.TableName + "." + table.Columns[c].ColumnName;

                    DicData.TryAddData(keyNameWithTableName.ToUpper(), value);



                }
            }
        }



        /// <summary>
        /// 将一个DataTable，转两个并排列。。。
        /// </summary>
        /// <param name="table"></param>
        /// <param name="landscape">是否横向</param>
        /// <param name="colNameExt">新列默认后缀</param>
        /// <returns></returns>
        public static DataTable ConvertToCol(this DataTable table,bool landscape, string colNameExt="1") 
        {
            //先colone 结构，然后增加新列
            DataTable newDT = table.Clone();
            for (int i = 0; i < table.Columns.Count; i++)
            {
                string newColName = table.Columns[i].ColumnName + colNameExt;
                newDT.Columns.Add(newColName);
            }

            landscape = true;
            
            if (landscape)
            {
                try
                {
                    //横向，左一个，右一个，左一个右一个

                    DataRow dr = newDT.NewRow();
                    bool left = true;
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        if (left)
                        {
                            for (int c = 0; c < table.Columns.Count; c++)
                            {
                                string colName = table.Columns[c].ColumnName;
                                dr[colName] = table.Rows[i][table.Columns[c].ColumnName];
                            }
                            //左完了，该右了。
                            left = false;
                            if (i == table.Rows.Count - 1)
                            {
                                //如果时最后一个左，则直接添加到表中
                                newDT.Rows.Add(dr);
                            }
                        }
                        else
                        {
                            for (int c = 0; c < table.Columns.Count; c++)
                            {
                                string colName = table.Columns[c].ColumnName + colNameExt;
                                dr[colName] = table.Rows[i][table.Columns[c].ColumnName];
                            }
                            //右完了，添加到表中再用左。
                            left = true;
                            newDT.Rows.Add(dr);
                            dr = newDT.NewRow();
                        }
                    }
                }
                catch (Exception ex) 
                {
                   
                }
            }

            return newDT;

        }


        /// <summary>
        /// 横向合并两张表
        /// </summary>
        /// <returns></returns>
        public static DataTable MergeTwoTable(DataTable t1,DataTable t2) 
        {
            DataTable table = t1.Clone(); ;
            try
            {
                
                for (int i = 0; i < t2.Columns.Count; i++)
                {
                    table.Columns.Add(t2.Columns[i].ColumnName);
                }

                int totalRowsCount = t1.Rows.Count > t2.Rows.Count ? t1.Rows.Count : t2.Rows.Count;
                for (int i = 0; i < totalRowsCount; i++)
                {
                    DataRow dr = table.NewRow();
                    if (i < t1.Rows.Count)
                    {
                        for (int c = 0; c < t1.Columns.Count; c++)
                        {
                            dr[t1.Columns[c].ColumnName] = t1.Rows[i][t1.Columns[c].ColumnName];
                        }
                    }

                    if (i < t2.Rows.Count)
                    {
                        for (int c = 0; c < t2.Columns.Count; c++)
                        {
                            dr[t2.Columns[c].ColumnName] = t2.Rows[i][t2.Columns[c].ColumnName];
                        }
                    }
                    table.Rows.Add(dr);
                }
            }
            catch (Exception ex)
            {
                 
            }
             
            return table; 
        }


        public static DataTable ColneDT(this DataTable table) 
        {
            DataTable newDt = new DataTable();
            for (int i = 0; i < table.Columns.Count; i++)
            {
                newDt.Columns.Add(table.Columns[i].ColumnName);
            }

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow dr =  newDt.NewRow();
                for (int j = 0; j < table.Columns.Count; j++)
                {
                    dr[table.Columns[j].ColumnName] = table.Rows[i][table.Columns[j].ColumnName]?.ToString();

                }
                

                newDt.Rows.Add(dr);
            }
            return newDt;

        }

        /// <summary>
        /// 替换表格中某列中，某个值
        /// </summary>
        /// <param name="dataTable"></param>
        /// <param name="ColName"></param>
        /// <param name="input"></param>
        /// <param name="result"></param>
        public static void ReplaceValueByCol(this DataTable dataTable,string ColName,string input,string result) 
        {
            try
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    if (dataTable.Rows[i][ColName].ToString().Trim() == input.Trim())
                    {
                        dataTable.Rows[i][ColName] = result;
                    }
                }
            }
            catch (Exception ex)
            {
               
            }
        }

        /// <summary>
        /// 根据某字段排序
        /// </summary>
        /// <param name="dataTable"></param>
        /// <param name="colName"></param>
        /// <returns></returns>
        public static DataTable OrderByCol(this DataTable dataTable,string colName) 
        {
            DataTable dt0 = dataTable.Clone(); //复制原表结构 
            foreach (DataRow dr in dataTable.AsEnumerable().OrderBy(K => K[colName]?.ToString()).ToArray())
            {
                dt0.ImportRow(dr); //导入行 
            }
            return dt0;

        }


        public static string ConvertTableColsToString(DataTable table,string col1,string col2) 
        {

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string line = "";
                try
                {
                    line  = table.Rows[i][col1].ToString();
                }
                catch (Exception)
                {

                }

                try
                {
                    line += table.Rows[i][col2].ToString();
                }
                catch (Exception)
                {

                }
                if (!string.IsNullOrWhiteSpace(line))
                {
                    sb.AppendLine(line);
                }
            }
            return sb.ToString();
        }



        /// <summary>
        /// 合并DataTable 某个字段的多行为一个字符串
        /// </summary>
        /// <param name="table"></param>
        /// <param name="ColName"></param>
        /// <param name="Canrepeat">是否检测重复</param>
        /// <param name="spChar">每行的分隔符，默认为空格</param>
        /// <returns></returns>
        public static string ConvertMuiltRosColToString(this DataTable table,string ColName,bool Canrepeat, string spChar=" ") 
        {

            try
            {
                string[] allRowsValue = table.AsEnumerable().Select(K => K[ColName]?.ToString().Trim()).ToArray();
                if (!Canrepeat)
                {
                    allRowsValue = allRowsValue?.Distinct().ToArray();
                }
                return String.Join(spChar, allRowsValue);
            }
            catch (Exception ex)
            {
          
            }
            return "";
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        public static string ConvertDataTableToStringSimple(this DataTable dataTable)
        {
            return $"{dataTable.TableName }共 {dataTable.Rows.Count}行，{dataTable.Columns.Count} 列";
        }



        /// <summary>
        /// DataTable  转换字符串，用于Log调试
        /// </summary>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        public static string ConvertDataTableToString(this DataTable dataTable)
        {
            //return Newtonsoft.Json.JsonConvert.SerializeObject(dataTable);

            StringBuilder sb = new StringBuilder();

            try
            {
                sb.AppendLine($"{dataTable.TableName }共 {dataTable.Rows.Count}行，{dataTable.Columns.Count} 列");

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    StringBuilder sbRow = new StringBuilder();
                    sb.AppendLine($"第{i}行");
                    sb.AppendLine($"------------------------");

                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        try
                        {
                            var value = dataTable.Rows[i][j] ?? "";
                            if (!string.IsNullOrWhiteSpace(value?.ToString()))
                            {
                                sbRow.Append(value + " - ");
                            }
                        }
                        catch (Exception ex)
                        {

                            sb.AppendLine("error" + ex.Message);
                        }
                    }
                    sb.AppendLine(sbRow.ToString());
                }
            }
            catch (Exception ex)
            {
                sb.AppendLine( "转换异常" + ex.Message + ex.StackTrace);
               
            }
            return sb.ToString();
        }

        public static string TryConvertToDataByTableRows(this DataRow dr,string colName)
        {
            try
            {
                if (DateTime.TryParse(dr[colName]?.ToString(), out DateTime reslut))
                {
                    return reslut.ToShortDateString();
                }
                else
                {
                    return dr[colName]?.ToString();
                }
            }
            catch (Exception)
            {
                return "";
                
            }

        }

        /// <summary>
        /// Dic扩展方法,添加TK,已存在,返回false
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <param name="dic"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool AddValue<T, K>(this Dictionary<T, K> dic, T key, K value)
        {
            if (!dic.ContainsKey(key))
            {
                dic.Add(key, value);
                return true;
            }
            return false;
        }


        public static void AddDataToDic(this Dictionary<string, string> dic, DataTable dt)
        {
            if (dt!=null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    string key = dt.Columns[i].ColumnName;
                    string value = dt.Rows[0][key]?.ToString();
                    //if (!string.IsNullOrWhiteSpace(value))
                    {
                        dic.AddValue(key, value);
                    }
                }
            }
        }

        public static Dictionary<string, List<string>> ConvertDTToArrayDic(this DataTable dt, string keyColName, string valueColName) 
        {
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string key = dt.Rows[i][keyColName]?.ToString();
                string value = dt.Rows[i][valueColName]?.ToString();
                if (string.IsNullOrWhiteSpace(key) || string.IsNullOrWhiteSpace(value))
                {
                    continue;
                }
                

                if (dic.ContainsKey(key))
                {
                    dic[key].Add(value);
                }
                else
                {
                    List<string> list = new List<string>();
                    list.Add(value);
                    dic.Add(key, list);
                }
            }

            return dic;
        }
 


        /// <summary>
        /// 转换DataTable中的两列为Dic
        /// </summary>
        /// <typeparam name="T">Key 的类型</typeparam>
        /// <typeparam name="K">Value 的类型</typeparam>
        /// <param name="dt"></param>
        /// <param name="keyColName">Key 的列名</param>
        /// <param name="valueColName">Value 的列名</param>
        /// <returns></returns>
        public static Dictionary<T, K> ConvertDTToDic<T,K>(this DataTable dt,string keyColName, string valueColName)
        {
            Dictionary<T, K> dicResult = new Dictionary<T, K>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                try
                {
                    T key = (T)dt.Rows[i][keyColName];
                    K Name = (K)dt.Rows[i][valueColName];
                    dicResult.Add(key, Name);
                }
                catch (Exception ex)
                { 
                }
            }
            return dicResult;
        }


        /// <summary>
        /// 给DataTable 添加一个从1开始顺序列
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static bool AddNewColOrderNo(this DataTable dt, string ColName)
        {
            try
            {
                dt.Columns.Add(ColName, typeof(int));

                for (int i = 1; i <= dt.Rows.Count; i++)
                {
                    dt.Rows[i-1][ColName] = i;
                }

                return true;
            }
            catch (Exception)
            {
                return false;

            }

        }


         
        /// <summary>
        /// DataTable 扩展方法，根据列，过滤数据
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="colName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static DataRow[] FilterRowByCol(this DataTable dt, string colName, string value)
        {
            if (dt == null)
            {
                return null;
            }
            return dt.AsEnumerable().Where(K => !string.IsNullOrWhiteSpace(K.Field<string>(colName)) && K.Field<string>(colName).Equals(value, StringComparison.CurrentCultureIgnoreCase)).ToArray();
        }


        public static DataRow FilterRowByColFirstRow(this DataTable dt, string colName, string value)
        {
            DataRow[] drs = dt.FilterRowByCol(colName, value);
            if (drs != null && drs.Length > 0)
            {
                return drs[0];
            }
            return null;
        }

        /// <summary>
        /// Table 中的列,是否包含value
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="colName"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool ContinaValue(this DataTable dt, string colName, string value)
        {
            if (dt == null)
            {
                return false;
            }
            return dt.FilterRowByCol(colName, value).Length > 0; 
        }

        /// <summary>
        /// 根据列，获取新的Table 过滤数据
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="colName"></param>
        /// <param name="filterValue"></param>
        /// <returns></returns>
        public static DataTable FilterToNewDTByCol(this DataTable dt,string colName,string filterValue,string orderBy = "")
        {
            lock (dt)
            {
                dt.DefaultView.RowFilter = colName + " = '" + filterValue + "'";
                DataView dv = dt.DefaultView;

                if (!string.IsNullOrWhiteSpace(orderBy))
                {
                    dv.Sort = orderBy;
                }

                DataTable newDT =  dv.ToTable();
                //重置过滤器
                dt.DefaultView.RowFilter = "";
                return newDT;
            }

        }

        /// <summary>
        /// 转换日期时间为 2018-10-09 格式
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string ConvertoDTString(this DateTime dt)
        {
            return dt.Year.ToString() + "-" + dt.Month.ToString().PadLeft(2, '0') + "-" + dt.Day.ToString().PadLeft(2, '0');       
        }

        /// <summary>
        /// 删除指定行
        /// </summary>
        /// <param name="dataTable"></param>
        /// <param name="colName"></param>
        /// <param name="value"></param>
        public static void RemoveRowByValue(this DataTable dataTable, string colName, string value = "")
        {
            List<DataRow> willRemoveRows = new List<DataRow>();
            
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (dataTable.Rows[i][colName].ToString() == value)
                {
                    willRemoveRows.Add(dataTable.Rows[i]);
                }
            }

            for (int i = 0; i < willRemoveRows.Count; i++)
            {
                dataTable.Rows.Remove(willRemoveRows[i]);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataTable"></param>
        /// <param name="colName"></param>
        /// <returns></returns>
        public static DataRow GetNotNullRow(this DataTable dataTable,string colName)
        {
            return dataTable.AsEnumerable().Where(K => !string.IsNullOrWhiteSpace(K[colName]?.ToString())).FirstOrDefault();
        }
 


        public static string GetNotNullRowValue(this DataTable dataTable, string colName)
        {
            try
            {
                DataRow dr = dataTable.GetNotNullRow(colName);
                if (dr != null)
                {
                    return dr[colName].ToString();
                }
            }
            catch (Exception)
            {

            }
            return null;

        }

        public static string TryGetColValue(this DataRow dr,string colName)
        {
            try
            {
                return dr[colName].ToString();
            }
            catch (ArgumentException)
            {
                return null;
            }
        }

        public static Dictionary<string, string> ConvertToDic(this DataRow dr)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            if (dr != null)
            {
                for (int i = 0; i < dr.Table.Columns.Count; i++)
                {
                    string key = dr.Table.Columns[i].ColumnName;
                    string value = dr[key].ToString();
                    dic.Add(key, value);

                }
            }
            return dic;
        }

        public static Dictionary<string, string> ConvertFirstRowToDic(this DataTable dt)
        {
            if (dt!=null)
            {
                if (dt.Rows.Count >= 1)
                {
                   return dt.Rows[0].ConvertToDic();
                }
            }
            return new Dictionary<string, string>();

        }

        public static DataTable CreateNewDtByColValue(DataTable dt, string ColName, List<string> allValue)
        {
            DataTable dtNew = dt.Copy();

            try
            {
                for (int i = 0; i < dtNew.Rows.Count; i++)
                {
                    if (!allValue.Contains(dtNew.Rows[i][ColName].ToString()))
                    {
                        dtNew.Rows[i].Delete();
                    }
                }
                dtNew.AcceptChanges();
                
            }
            catch (Exception)
            {

                Console.WriteLine();
            }

            return dtNew;

        }

        #region Dictionary<string, string> 扩展


        /// <summary>
        /// 添加新的Key 
        /// </summary>
        /// <param name="dic"></param>
        /// <param name="oldKey"></param>
        /// <param name="newkey"></param>
        /// <returns></returns>
        public static bool AddNewKeyByName(this Dictionary<string, string> dic, string oldKey, string newkey)
        {
            string value;
            if (dic.TryGetValue(oldKey, out value))
            {
                return dic.TryAddData(newkey, value);
            }
            return false;
        }

        /// <summary>
        /// 添加或更新字段
        /// </summary>
        /// <param name="dic"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool TryAddData(this Dictionary<string, string> dic, string key, string value)
        {
            try
            {
                if (!dic.ContainsKey(key))
                {
                    dic.Add(key, value);
                    return true;
                }
                else
                {
                    dic[key] = value;
                }
            }
            catch (Exception)
            {


            }

            return false;
        }


        #endregion






    }
}
