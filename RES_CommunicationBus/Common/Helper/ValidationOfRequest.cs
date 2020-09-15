using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helpers
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
                else if (partsOfRequest[1] == "")
                {
                    return false;
                }
                else if (partsOfRequest[1] == "")
                {
                    return false;
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
    
