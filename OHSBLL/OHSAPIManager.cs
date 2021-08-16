using OHSModel;
using OHSUploadLibrary.OHSBLL.OHSModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHSUploadLibrary.OHSBLL
{

    /// <summary>
    /// 一个统一的职业病 团体报告接口
    /// </summary>
    public class OHSAPIManager
    {

        public static void InitManager() 
        {
        
        }

        /// <summary>
        /// 更加订单ID获取团体信息
        /// </summary>
        /// <param name="OrderID"></param>
        /// <returns></returns>
        public static OhsOrderModel GetHosGroupData(string OrderID)
        {
            OhsOrderModel model = new OhsOrderModel();
            model.OrderID = OrderID;
            InitHospitalInfo(model);
            InitOrderInfo(model);

            return model;
        }


        /// <summary>
        /// 设置医院基本信息
        /// </summary>
        private static bool InitHospitalInfo(OhsOrderModel model) 
        {
            DataTable table = HOSDBHelper.QueryTable("select * from T_OHS_HOSPITALMESSAGE where DF='1'");
            table.TableName = DEFIND_T_OHS_HOSPITALMESSAGE.T_OHS_HOSPITALMESSAGE;
            model.AddDataByFirstRow(table);
            return true;
        }


        /// <summary>
        /// 设置客户及订单基本信息
        /// </summary>
        private static bool InitOrderInfo(OhsOrderModel model)
        {
            DataTable table = HOSDBHelper.QueryTable("select * from T_ORDER where FID='"+model.OrderID+"'");
            if (table.Rows.Count== 0)
            {
                model.ErrorMsg = "未找到此订单："+ model.OrderID;
                return false;
            }

            table.TableName = DEFIND_T_ORDER.T_ORDER;
            model.AddDataByFirstRow(table);


            string CORPID = table.Rows[0]["CORPID"].ToString();

            DataTable tableCr = HOSDBHelper.QueryTable("select * from T_CORPARCHIVE where FID='" + CORPID + "'");

            tableCr.TableName = DEFIND_T_CORPARCHIVE.T_CORPARCHIVE;
            model.AddDataByFirstRow(tableCr);

              
            return true;

        }


    }
}
