using Common.CommunicationModel;
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
        public CommunicationBusModule()
        {
        }

        public Response SendRequest(string jsonRequest)
        {
            Response retVal = new Response(EStatus.SUCCESS, (int)EStatus.SUCCESS, "database object");

            //jsonToXML
            XNode node = JsonConvert.DeserializeXNode(jsonRequest);
            //XMLtoDBA
            //CRUD execution
            //DBAtoXML
            //xmlToJSON

            return retVal;
        }
    }
}
