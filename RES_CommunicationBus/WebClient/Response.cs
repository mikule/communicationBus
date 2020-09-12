using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClient
{
    public class Response
    {
        public Status Status { get; set; }
        public double StatusCode { get; set; }
        public string Payload { get; set; }

        public Response(Status status, double statusCode, string payload)
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
