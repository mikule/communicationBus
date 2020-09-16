using System;
using Common.CommunicationModel;
using Common.Helper;
using Common.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CommunicationBusTests
{
    [TestClass]
    public class RequestFactoryTests
    {
        [TestMethod]
        public void ConvertStringToRequest_MakingRequest_ReturnNotNullValue()
        {
            string stringRequest = "GET/resurs/1";

            Request request = RequestFactory.ConvertStringToRequest(stringRequest);

            Assert.IsNotNull(request);
            Assert.AreEqual(request.Verb, "GET");
        }

        [TestMethod]
        public void ValidateRequest_PassTheCheck_ReturnTrue()
        {
            string stringRequest = "POST/resurs/1";
            var validation = new ValidationOfRequest();

            var result = validation.ValidateRequest(stringRequest);

            Assert.IsTrue(result);
        }


        [TestMethod]
        public void ValidateRequest_PassTheCheck_ReturnFalse()
        {
            string stringRequest = "POSfsdghT/resurs/1";
            var validation = new ValidationOfRequest();

            var result = validation.ValidateRequest(stringRequest);

            Assert.IsFalse(result);
        }
    }
}
