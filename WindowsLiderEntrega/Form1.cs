//PRUEBA OLIMPIA
//La función de la aplicación actual es calcular el saldo final de las cuentas de un "banco", para esto se consume un servicio que devuelve 
//las transacciones realizas a la cuentas.

//Paso 1: Hacer funcionar la aplicación. Debido al aumento de transacciones y al  colocar al servicio con SSL la aplicación actual esta fallando.
//Paso 2: Estructurar mejor el codigo. Uso de patrones, buenas practicas, etc.
//Paso 3: Optimizar el codigo, como se menciono en el paso 1 el aumento de transacciones ha causado que el calculo de los saldos se demore demasiado.
//Paso 4: Adicionar una barra de progreso al formulario. Actualizar la barra con el progreso del proceso, evitando bloqueos del GUI.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsLiderEntrega.client;

namespace WindowsLiderEntrega
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            pbestadocalculo.Value = 0;
                        
            System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();

            WindowsLiderEntrega.ServicioPrueba.Transaccion[] transacciones = cliente.getRespClient();
            pbestadocalculo.Maximum = transacciones.Count();
            lbltotal.Text += transacciones.Count().ToString();

            //Variable donse se almacenan los saldos finales
            List<ServicioPrueba.Saldo> saldos = new List<ServicioPrueba.Saldo>();
          
            foreach (var transaccion in transacciones)
            {
                Cuenta cuentaActual = new Cuenta();
                cuentaActual.numCuenta = transaccion.CuentaOrigen;

                ClienteInfo clienteInfo = new ClienteInfo();
                clienteInfo.claveCifrado = cliente.getClient().GetClaveCifradoCuenta("usuariop", "passwordp", cuentaActual.numCuenta);

                Transaccion mov_act_tran = new Transaccion();
                mov_act_tran.TipoTransaccion = Encriptacion.Desencripta( clienteInfo.claveCifrado, transaccion.TipoTransaccion);

                cuentaActual.Saldo = -1;

                if (saldos.Count()>0)
                {
                    //Obtenemos el saldo actual de la cuenta
                    var saldo =  saldos.Find(x => x.CuentaOrigen.ToString().Equals(cuentaActual.numCuenta.ToString()));
                    if (saldo != null)
                    {
                        cuentaActual.Saldo = saldo.SaldoCuenta;
                        mov_act_tran.comision = Calculo.CalcularComision(Convert.ToInt64(transaccion.ValorTransaccion));
                        saldo.SaldoCuenta -= Calculo.CalcularSaldoCuenta(transaccion.ValorTransaccion, saldo.SaldoCuenta, mov_act_tran.TipoTransaccion, mov_act_tran.comision);
                    }
                }

                if (cuentaActual.Saldo == -1)
                {
                    ServicioPrueba.Saldo saldonew = new ServicioPrueba.Saldo();
                    mov_act_tran.comision = Calculo.CalcularComision(Convert.ToInt64(transaccion.ValorTransaccion));
                    saldonew.CuentaOrigen = cuentaActual.numCuenta;
                    saldonew.SaldoCuenta -= Calculo.CalcularSaldoCuenta(transaccion.ValorTransaccion, saldonew.SaldoCuenta, mov_act_tran.TipoTransaccion, mov_act_tran.comision);
                    saldos.Add(saldonew);
                }
                pbestadocalculo.Increment(1);
                lblreg.Text = pbestadocalculo.Value.ToString();
                Application.DoEvents();
            }
            sw.Stop();
            lblTiempoTotal.Text = sw.ElapsedMilliseconds.ToString();

            //Enviamos los saldos finales
            cliente.getClient().SaveData("usuariop", "passwordp", saldos.ToArray());
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
