using System;
using WindowsFormsAppTest.WebserviceYouri;

namespace WindowsFormsAppTest
{
    class SoapRequest
    {
        CrmServiceClient client;
        public SoapRequest()
        {
            client = new CrmServiceClient();
            Console.WriteLine(client.GetVersion());
        }
    }
}
