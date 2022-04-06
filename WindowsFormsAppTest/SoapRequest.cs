using System;
using WindowsFormsAppTest.YouriWebserviceCrm;

namespace WindowsFormsAppTest
{
    class SoapRequest
    {
        CrmServiceClient client;

        public SoapRequest()
        {
            RequestSearch requestSearch = new RequestSearch();
            requestSearch.ZoekString = "https://ws.kraan.com:444/Kraan2Webservices/CrmService.svc";
            //DownloadRequest downloadRequest = new DownloadRequest();
            client = new CrmServiceClient();
            Console.WriteLine(client.GetFilterdListProject(requestSearch));
        }
    }
}
