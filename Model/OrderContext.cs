using OHSUploadLibrary.OHSContry;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSUploadLibrary.Model
{
    public  class OrderContext
    {
        public OrderContext() 
        {

        }


        public OrderContext(string orderID, OHSResultEnum ohstype)
        {
            this.OrderID = orderID;
            this.OHSResultType = ohstype;
        }


        /// <summary>
        /// 验证必填信息
        /// </summary>
        /// <returns></returns>
        public bool VaildRequired(out string msg) 
        {
            msg = "";

            return false;
        }




        /// <summary>
        /// 获取XML结果
        /// </summary>
        /// <returns></returns>
        public string GetXmlReuslt() 
        {
            if (ResltData!= null)
            {
                return OHSContryHelper.ConvertToXMLFormatData(ResltData);
            }
            return "";
        }

        #region 传入参数

        /// <summary>
        /// 生成
        /// </summary>
        public OHSResultEnum OHSResultType;

        /// <summary>
        /// 订单的 上下文
        /// </summary>
        public string OrderID;

        /// <summary>
        /// 支持多个订单
        /// </summary>
        public string[] OrderIdArray;



        #endregion

        #region 生成结果

        /// <summary>
        /// 是否生成成功
        /// </summary>
        public bool IsSuccess;

        /// <summary>
        /// 生成错误信息
        /// </summary>
        public string ErrorMsg;

        /// <summary>
        /// 生成的最终结果
        /// </summary>
        public DataExchange ResltData;


        #endregion





        /// <summary>
        /// T_CORPARCHIVE 公司，客户企业ID
        /// </summary> 
        public string CORPID;

        /// <summary>
        /// 缓存已经查询的相关表
        /// </summary>
        public Dictionary<string, DataTable> DicTable = new Dictionary<string, DataTable>();



        public void AddTableToCatche(DataTable table ) 
        {
            if (string.IsNullOrWhiteSpace(table.TableName))
            {
                if (DicTable.ContainsKey(table.TableName))
                {
                    DicTable[table.TableName] = table;
                }
                else
                {
                    DicTable.Add(table.TableName, table) ;
                }
            }
        
        }
        

        public DateTime QueryStartDate;

        public DateTime QueryEndDate;

    }

    /// <summary>
    /// 获取类型
    /// </summary>
    public enum OHSResultEnum
    {
        用人单位信息,
        职业健康档案,
        疑似职业病,
        职业病病例,
        职业病鉴定,
        职业病随访,
        农药中毒,
        职业病有害因素监测
    }

}
