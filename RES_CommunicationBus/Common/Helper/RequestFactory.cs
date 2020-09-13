using Common.CommunicationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Common.Helper
{
    public static class RequestFactory
    {
        public static Request ConvertStringToRequest(string stringRequest)
        {

            string[] partsOfRequest = stringRequest.Split('/');
            Request request = new Request();
            request.Verb = partsOfRequest[0];
            request.Noun = partsOfRequest[1] +"/"+ partsOfRequest[2];

            return request;

        }
    }
}
