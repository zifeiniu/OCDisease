using OHSUploadLibrary.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace OHSUploadLibrary
{
    public class OHSBLL
    {
        public static string ConvertToXMLFormatData(DataExchange data) 
        {

            XmlSerializer xs = new XmlSerializer(data.GetType());
            StringWriter sw = new StringWriter();
            xs.Serialize(sw, data);

            //去掉默认的命名空间
            string sub= "xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"";

            string xmlResult = sw.ToString();
            return xmlResult.Replace(sub, "");

        }

        public static DataExchange GetModel() 
        {
            DataExchange employ = new DataExchange();
            return employ;

        }

        //public static object Cretaedata() 
        //{
        //    dynamic data = System.Dynamic.DynamicObject();


        //}


    }
}
