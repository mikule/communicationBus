using Common.CommunicationModel;
using ModelPodataka.DataModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Common.Repository
{
    public class SqlQueryExecutor
    {
        public SqlQueryExecutor()
        {
            
        }

        ~SqlQueryExecutor()
        {
            
        }
        public XmlDocument ExecuteSqlQuery(string sql)
        {
            Response responseModel = new Response();
            using (CommunicationBus_DbContext context = new CommunicationBus_DbContext())
            {
                if (sql.Contains("Resource"))
                {
                    var response = context.Resources.SqlQuery(sql).ToList();
                    if (response != null)
                    {
                        responseModel.Status = EStatus.SUCCESS;
                        responseModel.StatusCode = (double)EStatus.SUCCESS;
                        response.ForEach(x => responseModel.Payload += x.ToString() + "\n");
                    }
                    else
                    {
                        responseModel.Status = EStatus.REJECTED;
                        responseModel.StatusCode = (double)EStatus.REJECTED;
                        response.ForEach(x => responseModel.Payload += x.ToString() + "\n");
                    }
                }
                else if(sql.Contains("Relation"))
                {
                    var response = context.Relations.SqlQuery(sql);
                    if (response != null)
                    {
                        responseModel.Status = EStatus.SUCCESS;
                        responseModel.StatusCode = (double)EStatus.SUCCESS;
                        //responseModel.Payload = response;
                    }
                    else
                    {
                        responseModel.Status = EStatus.REJECTED;
                        responseModel.StatusCode = (double)EStatus.REJECTED;
                        //responseModel.Payload = response;
                    }
                }
                else if(sql.Contains("RelationType"))
                {
                    var response = context.RelationTypes.SqlQuery(sql);
                    if (response != null)
                    {
                        responseModel.Status = EStatus.SUCCESS;
                        responseModel.StatusCode = (double)EStatus.SUCCESS;
                        //responseModel.Payload = response;
                    }
                    else
                    {
                        responseModel.Status = EStatus.REJECTED;
                        responseModel.StatusCode = (double)EStatus.REJECTED;
                       // responseModel.Payload = response;
                    }
                }
                else if(sql.Contains("ResourceType"))
                {
                    var response = context.ResourceTypes.SqlQuery(sql);
                    if (response != null)
                    {
                        responseModel.Status = EStatus.SUCCESS;
                        responseModel.StatusCode = (double)EStatus.SUCCESS;
                        //responseModel.Payload = response;
                    }
                    else
                    {
                        responseModel.Status = EStatus.REJECTED;
                        responseModel.StatusCode = (double)EStatus.REJECTED;
                        //responseModel.Payload = response;
                    }
                }
                else
                {
                    responseModel.Status = EStatus.BAD_FORMAT;
                    responseModel.StatusCode = (double)EStatus.BAD_FORMAT;
                    //responseModel.Payload = null;
                }
            }

            XmlSerializer serializer = new XmlSerializer(typeof(Response));
            TextWriter stringWriter = new StringWriter();
            serializer.Serialize(stringWriter, responseModel);
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(stringWriter.ToString());
            return xmlDocument;
        }
    }
}
