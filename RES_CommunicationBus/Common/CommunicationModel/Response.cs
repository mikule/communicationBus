using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.CommunicationModel
{
    public class Response
    {
        public EStatus Status { get; set; }
        public double StatusCode { get; set; }
        public string Payload { get; set; }

        public Response(EStatus status, double statusCode, string payload)
        {
            Status = status;
            StatusCode = statusCode;
            Payload = payload;
        }
        public Response()
        {
        }
    }
}
