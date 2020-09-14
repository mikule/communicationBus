using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Common.CommunicationBus
{
    public class XmlToSql
    {
        public XmlToSql()
        {

        }

        public string Convert(XNode xml)
        {
            return "select * from resurs;";
        }
    }
}
