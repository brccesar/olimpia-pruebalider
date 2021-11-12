using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WindowsLiderEntrega.ServicioPrueba;

namespace WindowsLiderEntrega
{
    public static class cliente  
    {
        public static ServiceClient getClient()
        {
            ServicioPrueba.ServiceClient client = new ServicioPrueba.ServiceClient();
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);
            //client.ClientCredentials.UserName.UserName = "usuarioop";
            //client.ClientCredentials.UserName.Password = "passwordp";
            return client;
        }

        public static WindowsLiderEntrega.ServicioPrueba.Transaccion[] getRespClient()
        {
            ServicioPrueba.ServiceClient client = new ServicioPrueba.ServiceClient();
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);
            //client.ClientCredentials.UserName.UserName = "usuarioop";
            //client.ClientCredentials.UserName.Password = "passwordp";
            return client.GetData("usuariop", "passwordp"); 
        }


        public static bool AcceptAllCertifications(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certification, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

    }
}
