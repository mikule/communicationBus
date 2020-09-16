using Common.CommunicationModel;
using Common.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Common.CommunicationBus
{
    public class CommunicationBusModule
    {
        public XNode XmlRequest;
        public CommunicationBusModule()
        {
            XmlRequest = null;
        }

        public string SendRequest(string jsonRequest)
        {
            XmlRequest = JsonConvert.DeserializeXNode(jsonRequest, "Request");
            XmlToSql xmlToSql = new XmlToSql();
            string sqlQuery = xmlToSql.Convert(XmlRequest);
            SqlQueryExecutor sqlQueryExecutor = new SqlQueryExecutor();
            var xmlResponse = sqlQueryExecutor.ExecuteSqlQuery(sqlQuery);

            xmlResponse.RemoveChild(xmlResponse.ChildNodes[0]);
            //xmlResponse.RemoveChild(xmlResponse.ChildNodes[1]);

            return JsonConvert.SerializeXmlNode(xmlResponse, Formatting.Indented);
        }
    }
}
