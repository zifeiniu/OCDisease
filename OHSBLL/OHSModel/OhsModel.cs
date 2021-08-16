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
    /// 职业病团体报告
    /// </summary>
    public class OhsOrderModel
    {

        public string ErrorMsg;

        /// <summary>
        /// 团体订单ID
        /// </summary>
        public string OrderID;

        /// <summary>
        /// 储存所有的的Key-Value基本信息
        /// </summary>
        public Dictionary<string, string> DicData = new Dictionary<string, string>();

        /// <summary>
        /// 储存相关数据表
        /// </summary>
        public DataSet ds =new DataSet ();

        public void InitBaseKey() 
        {
            DicData.Add("截止日期", DateTime.Now.ToString("yyyy年MM月dd日"));
            DicData.Add("当前日期", DateTime.Now.ToString("yyyy年MM月dd日"));

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="table"></param>
        public bool AddDataByFirstRow(DataTable table)
        {
            //必须定义TableName 作为前缀
            if (string.IsNullOrWhiteSpace(table.TableName))
            {
                return false;
            }
            DicData.SetFirstRowToDic(table);
            ds.AddOrUpdateTable(table);
            return true;
        }

        public void MapingData() 
        {
            MappingHospitalData();
            MappingT_ORDER();
        }

        public void MappingT_ORDER() 
        {
            DicData.AddNewKeyByName(DEFIND_T_ORDER.T_ORDER + "." + DEFIND_T_ORDER.FNAME, OHSModelDefind.订单名称);
            DicData.AddNewKeyByName(DEFIND_T_ORDER.T_ORDER+ "." + DEFIND_T_ORDER.LINKMANPHONE, OHSModelDefind.客户联系人电话);
            DicData.AddNewKeyByName(DEFIND_T_ORDER.T_ORDER + "." + DEFIND_T_ORDER.ADDRESS, OHSModelDefind.客户地址);
            DicData.AddNewKeyByName(DEFIND_T_ORDER.T_ORDER + "." + DEFIND_T_ORDER.ZIPCODE, OHSModelDefind.客户名称邮政编码);
            DicData.AddNewKeyByName(DEFIND_T_ORDER.T_ORDER + "." + DEFIND_T_ORDER.MNEMONICSYMBOL, OHSModelDefind.客户名称缩写);
     
        }
        public void MappingT_CORPARCHIVE() 
        {
            
                //DicData.AddNewKeyByName(DEFIND_T_CORPARCHIVE.T_ORDER + "." + DEFIND_T_CORPARCHIVE.MNEMONICSYMBOL, OHSModelDefind.客户名称缩写);

        }


        /// <summary>
        /// 映射 T_OHS_HOSPITALMESSAGE 数据
        /// </summary>
        public void MappingHospitalData() 
        {
             
            DicData.AddNewKeyByName(DEFIND_T_OHS_HOSPITALMESSAGE.T_OHS_HOSPITALMESSAGE + "."+DEFIND_T_OHS_HOSPITALMESSAGE.HOSPITALNAME, OHSModelDefind.医院名称);

            DicData.AddNewKeyByName(DEFIND_T_OHS_HOSPITALMESSAGE.T_OHS_HOSPITALMESSAGE + "." +  DEFIND_T_OHS_HOSPITALMESSAGE.DEPARTNAME, OHSModelDefind.医院分院名称);
                                                                                                
            DicData.AddNewKeyByName(DEFIND_T_OHS_HOSPITALMESSAGE.T_OHS_HOSPITALMESSAGE + "." +  DEFIND_T_OHS_HOSPITALMESSAGE.ADDRESS, OHSModelDefind.医院地址);
                                                                                                
            DicData.AddNewKeyByName(DEFIND_T_OHS_HOSPITALMESSAGE.T_OHS_HOSPITALMESSAGE + "." +  DEFIND_T_OHS_HOSPITALMESSAGE.ZIPCODE, OHSModelDefind.医院邮政编码);
                                                                                                
            DicData.AddNewKeyByName(DEFIND_T_OHS_HOSPITALMESSAGE.T_OHS_HOSPITALMESSAGE + "." +  DEFIND_T_OHS_HOSPITALMESSAGE.ZUZHIJIGOUDAIMA, OHSModelDefind.组织机构代码);
                                                                                                
            DicData.AddNewKeyByName(DEFIND_T_OHS_HOSPITALMESSAGE.T_OHS_HOSPITALMESSAGE + "." +  DEFIND_T_OHS_HOSPITALMESSAGE.LIANXIDIANHUA, OHSModelDefind.医院联系电话);
                                                                                                
            DicData.AddNewKeyByName(DEFIND_T_OHS_HOSPITALMESSAGE.T_OHS_HOSPITALMESSAGE + "." +  DEFIND_T_OHS_HOSPITALMESSAGE.YIYUANFENJI, OHSModelDefind.医院分机号码);
                                                                                                
            DicData.AddNewKeyByName(DEFIND_T_OHS_HOSPITALMESSAGE.T_OHS_HOSPITALMESSAGE + "." +  DEFIND_T_OHS_HOSPITALMESSAGE.CHUANZHENDIANHUA, OHSModelDefind.医院传真电话);
                                                                                                
            DicData.AddNewKeyByName(DEFIND_T_OHS_HOSPITALMESSAGE.T_OHS_HOSPITALMESSAGE + "." +  DEFIND_T_OHS_HOSPITALMESSAGE.EMAIL, OHSModelDefind.医院邮箱);
                                                                                                
            DicData.AddNewKeyByName(DEFIND_T_OHS_HOSPITALMESSAGE.T_OHS_HOSPITALMESSAGE + "." +  DEFIND_T_OHS_HOSPITALMESSAGE.PIZHUNWENHAO, OHSModelDefind.医院批准文号);
                                                                                                
            DicData.AddNewKeyByName(DEFIND_T_OHS_HOSPITALMESSAGE.T_OHS_HOSPITALMESSAGE + "." +  DEFIND_T_OHS_HOSPITALMESSAGE.FAZHENGJIGUAN, OHSModelDefind.医院发证机关);
                                                                                                
            DicData.AddNewKeyByName(DEFIND_T_OHS_HOSPITALMESSAGE.T_OHS_HOSPITALMESSAGE + "." +  DEFIND_T_OHS_HOSPITALMESSAGE.YOUXIAOQIXIAN_START, OHSModelDefind.医院有效期开始日期);
            DicData.AddNewKeyByName(DEFIND_T_OHS_HOSPITALMESSAGE.T_OHS_HOSPITALMESSAGE + "." +  DEFIND_T_OHS_HOSPITALMESSAGE.YOUXIAOQIXIAN_END, OHSModelDefind.医院有效期结束日期);
                                                                                                
                                                                                                
            DicData.AddNewKeyByName(DEFIND_T_OHS_HOSPITALMESSAGE.T_OHS_HOSPITALMESSAGE + "." +  DEFIND_T_OHS_HOSPITALMESSAGE.CDC_SUOZAIDIQUBIANMA, OHSModelDefind.医院所在地区编码);
            DicData.AddNewKeyByName(DEFIND_T_OHS_HOSPITALMESSAGE.T_OHS_HOSPITALMESSAGE + "." +  DEFIND_T_OHS_HOSPITALMESSAGE.CDC_SUOZAIDIQUMINGCHENG, OHSModelDefind.医院所在地区名称);
                                                                                                
            DicData.AddNewKeyByName(DEFIND_T_OHS_HOSPITALMESSAGE.T_OHS_HOSPITALMESSAGE + "." +  DEFIND_T_OHS_HOSPITALMESSAGE.JIANDUDIANHUA, OHSModelDefind.医院监督电话);
            DicData.AddNewKeyByName(DEFIND_T_OHS_HOSPITALMESSAGE.T_OHS_HOSPITALMESSAGE + "." +  DEFIND_T_OHS_HOSPITALMESSAGE.CDC_JIGOUBIANMA, OHSModelDefind.医院机构编码);
                                                                                                
            DicData.AddNewKeyByName(DEFIND_T_OHS_HOSPITALMESSAGE.T_OHS_HOSPITALMESSAGE + "." +  DEFIND_T_OHS_HOSPITALMESSAGE.LIANXIREN, OHSModelDefind.医院联系人姓名);
            DicData.AddNewKeyByName(DEFIND_T_OHS_HOSPITALMESSAGE.T_OHS_HOSPITALMESSAGE + "." +  DEFIND_T_OHS_HOSPITALMESSAGE.LIANXIRENDIANHUA, OHSModelDefind.医院联系人电话);
                                                                                                
                                                                                                
            DicData.AddNewKeyByName(DEFIND_T_OHS_HOSPITALMESSAGE.T_OHS_HOSPITALMESSAGE + "." +  DEFIND_T_OHS_HOSPITALMESSAGE.CDC_JIGOUBIANMA, OHSModelDefind.医院机构编码);
                                                                                                
            DicData.AddNewKeyByName(DEFIND_T_OHS_HOSPITALMESSAGE.T_OHS_HOSPITALMESSAGE + "." + DEFIND_T_OHS_HOSPITALMESSAGE.KAIHUZHANGHAO, OHSModelDefind.医院开户账号);

        } 
     
    }

    

}
