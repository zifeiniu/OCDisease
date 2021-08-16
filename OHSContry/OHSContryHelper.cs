using OHSUploadLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace OHSUploadLibrary.OHSContry
{
    public static class OHSContryHelper 
    {

        /// <summary>
        /// 系统里有两个ENTERPRISE_INFO,属性基本一样，有交集。
        /// 但并不是继承关系。所以没有使用子类继承，但大多数属性名一样，在这里用Json强转
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public static ENTERPRISE_INFO_Sub ConvetToSubEnterprise(ENTERPRISE_INFO info) 
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(info);

            ENTERPRISE_INFO_Sub subInfo  = Newtonsoft.Json.JsonConvert.DeserializeObject<ENTERPRISE_INFO_Sub>(json);

            return subInfo;
        }

        /// <summary>
        /// 转换成XML 格式
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string ConvertToXMLFormatData(DataExchange data)
        {
            StringWriter sw = new StringWriter();
            var xmlTypeMapping = typeof(DataExchange);

            XmlSerializer serializer = new XmlSerializer(xmlTypeMapping);

            XmlWriterSettings setting = new XmlWriterSettings();
            setting.Encoding = Encoding.UTF8;
            setting.OmitXmlDeclaration = true;



            var xmlns = new XmlSerializerNamespaces();
            xmlns.Add(string.Empty, string.Empty);
            using (var writer = new XmlTextWriter(sw))
            {
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                

                serializer.Serialize(writer, data, xmlns);

            }

            //XmlSerializer xs = new XmlSerializer(data.GetType());
            
            //xs.Serialize(sw, data);

          
            string xmlResult = sw.ToString();
            xmlResult  = xmlResult.Replace(sub, "");

            xmlResult = xmlResult.Replace(conde, conde2);

            
            return xmlResult;


        }
        //去掉默认的命名空间
        public const string sub = "xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"";

        public const string conde = "<?xml version=\"1.0\" encoding=\"utf-16\"?>";

        public const string conde2 = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
    }
}
