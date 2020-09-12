using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClient
{
    public class ValidationOfRequest
    {       
        public bool ValidateRequest(string request)
        {
            string[] partsOfRequest = request.Split('/');
            while (true)
            {
                
                if (partsOfRequest[0] == "GET")
                {
                }
                else if (partsOfRequest[0] == "POST")
                {
                }
                else if (partsOfRequest[0] == "PATCH")
                {
                }
                else if (partsOfRequest[0] == "DELETE")
                {
                }
                else
                {
                    return false;
                }
                return true;

            }
        }
              
        public ValidationOfRequest()
        {
        }
    }
}
