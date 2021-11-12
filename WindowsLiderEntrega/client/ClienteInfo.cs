using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsLiderEntrega.client
{
    public class ClienteInfo
    {
        public string claveCifrado { get; set; }
        public WindowsLiderEntrega.ServicioPrueba.Transaccion[] respuestaWS { get; set; }


    }
}
