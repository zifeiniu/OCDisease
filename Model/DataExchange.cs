using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OHSUploadLibrary.Model
{
    /// <summary>
    /// 用人单位信息 
    /// </summary>
    [Serializable]
    [XmlRoot("DataExchange")]
    public  class DataExchange
    {
    
        /// <summary>
        /// 头部开始
        /// </summary>
        public OHSHeader Header = new OHSHeader();

        /// <summary>
        /// 
        /// </summary>
        public EventBody EventBody = new EventBody();

    }

}
