using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invernadero
{
    public partial class Form1 : Form
    {
        // Declaracion de Variables Usadas
        string hora = "", fecha = "", sport="";
        double adcnivel, adctemp, rt, vt, tt, nivel;
        double reftemp, refnivel, rantemp, rannivel;
        bool autonomo = false;
        int horas, minutos, h_abrir,m_abrir,h_cerrar,m_cerrar;
        public Form1()
        {
            InitializeComponent();
        }

        private void radAutonomo_CheckedChanged(object sender, EventArgs e)
        {
            autonomo = true;
            // Activa todos los RadioButton para apagar actuadores 
            grpAutonomo.Enabled = true;
            radOffAcond.Checked= true;
            radOffBAgua.Checked = true;
            radOffBAire.Checked = true;
            radOffCalef.Checked = true;
            radOffVent.Checked = true;

            grpManual.Enabled = false; // Desactiva los controles de modo manual
            txtEModo.Text= "MODO CONTROL: AUTONOMO";
            sptArduino.WriteLine("9"); // Enciende Bomba de aire 
        }

        private void radManual_CheckedChanged(object sender, EventArgs e)
        {
            autonomo = false;
            // Apaga todos los actuadores 
            if (sptArduino.IsOpen)
            {
                sptArduino.WriteLine("4");
                sptArduino.WriteLine("6");
                sptArduino.WriteLine("8");
                sptArduino.WriteLine("A");
                sptArduino.WriteLine("C");
            }
            grpAutonomo.Enabled = false;
            grpManual.Enabled = true;
            txtEModo.Text = "MODO CONTROL: MANUAL";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Apaga todos los actudores y desactiva la comunicacion serie
            if (sptArduino.IsOpen)
            {
                sptArduino.WriteLine("4");
                sptArduino.WriteLine("6");
                sptArduino.WriteLine("8");
                sptArduino.WriteLine("A");
                sptArduino.WriteLine("C");
                sptArduino.Close(); // cierra el puerto serie
            }
            Application.Exit();
        }

        private void btnValPredet_Click(object sender, EventArgs e)
        {
            // Carga los valores por defecto del modo autonomo
            numTemp.Value = 25;
            numNivAgua.Value = 100;
            numRanTemp.Value = 1;
            numRanNivAgua.Value = 20;
            numAbrirHrs.Value = 8;
            numAbrirMin.Value = 0;
            numCerrarHrs.Value = 20;
            numCerrarMin.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hora = DateTime.Now.ToString("HH:mm:ss"); // Obtiene la hora del sistema en formato de 24 horas
            txtHora.Text = hora; // Imprime la hora 
            fecha = DateTime.Now.ToLongDateString(); // Obtiene la fecha del sistema
            txtFecha.Text = fecha; // Imprime la fecha 
        }

        private void cmbPuertoSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            sport = Convert.ToString(cmbPuertoSerie.SelectedItem); // Obtiene el puerto serial seleccionado
        }

        private void btnDesSerie_Click(object sender, EventArgs e)
        {
            // Apaga todo los actuadores
            radOffAcond.Checked = true;
            radOffBAgua.Checked = true;
            radOffBAire.Checked = true;
            radOffCalef.Checked = true;
            radOffVent.Checked = true;
            if (sptArduino.IsOpen)
            {
                sptArduino.WriteLine("4");
                sptArduino.WriteLine("6");
                sptArduino.WriteLine("8");
                sptArduino.WriteLine("A");
                sptArduino.WriteLine("C");
            }

            sptArduino.Close();// Cierra el puerto serial 
            tmrArduino.Stop(); // Desactiva el Timer usado para leer valores 
            txtECom.Text = "COMUNICACION DESACTIVADA";
            txtENivAgua.Clear();
            txtETemp.Clear();
            txtNivAct.Clear();
            txtTempAct.Clear();
            radManual.Checked = false;
            grpOperacion.Enabled = false;
            grpAutonomo.Enabled = false;
            grpManual.Enabled = false;
            txtEModo.Clear();
        }

        private void tmrArduino_Tick(object sender, EventArgs e)
        {
            sptArduino.WriteLine("2");// Envia comando para que el Arduino envie Valor ADC
            adctemp = Convert.ToDouble(sptArduino.ReadLine()); // Obtiene el Valor ADC de Temperatura
            vt = (adctemp * 5.0)/1023.0; // convercion de ADC a Voltaje
            rt = (vt * 1000000) / (5 - vt); // formula para obtener resistencia del termistor
            tt = (1.0 / (((1.0 / 4750.0) * Math.Log(rt / 470000.0)) + (1.0 / 298.15))) - 273.15; // formula de linealizacion de termistor
            tt = Math.Round(tt,2); // Redondea a dos decimales el valor de temperatura
            txtETemp.Text = "TEMPERATURA: " + tt.ToString("N2") + "°C"; // Imprime temperatura 
            txtTempAct.Text = tt.ToString("N2") + "°C"; // Imprime temperatura 
            sptArduino.WriteLine("1"); // Envia comando para que el Arduino envie Valor ADC
            adcnivel = Convert.ToDouble(sptArduino.ReadLine()); // Obtiene el Valor ADC de Nivel 
            nivel = adcnivel * (-0.1605) + 164.2054; // Formula de conversion de ADC a % de Nivel
            nivel = Math.Round(nivel); // Redondea el Valor de % Nivel 
            txtENivAgua.Text = "NIVEL DE AGUA:  " + nivel.ToString() + " %";
            txtNivAct.Text = nivel.ToString() + " %";
            ////// Modo Autonomo 
            if(autonomo==true)
            {
                // Guarda los Valores del modo Autonomo en Variables
                reftemp = Convert.ToDouble(numTemp.Value);
                rantemp = Convert.ToDouble(numRanTemp.Value);
                refnivel = Convert.ToDouble(numNivAgua.Value);
                rannivel = Convert.ToDouble(numRanNivAgua.Value);
                h_abrir = Convert.ToInt32(numAbrirHrs.Value);
                m_abrir = Convert.ToInt32(numAbrirMin.Value);
                h_cerrar = Convert.ToInt32(numCerrarHrs.Value);
                m_cerrar = Convert.ToInt32(numCerrarMin.Value);

                if (tt > (reftemp + rantemp) && sptArduino.IsOpen)
                {
                    sptArduino.WriteLine("3"); // Enciende aire acondicionado
                }
                if (tt<reftemp)
                if (tt < (reftemp - rantemp) && sptArduino.IsOpen)
                {
                    sptArduino.WriteLine("B"); // Enciende calefaccion
                }
                if(tt>(reftemp-rantemp) && tt<(reftemp+rantemp))
                {
                    if(sptArduino.IsOpen)
                    {
                        sptArduino.WriteLine("4"); // Apaga aire acondicionado
                        sptArduino.WriteLine("C"); // Apaga Calefaccion
                    }
                }
                if(nivel<(refnivel-rannivel)&& sptArduino.IsOpen)
                {
                    sptArduino.WriteLine("7"); // Enciende Bomba de agua
                }
                if(nivel>=(refnivel - rannivel) && sptArduino.IsOpen)
                {
                    sptArduino.WriteLine("8"); // Apaga Bomba de agua
                }
                if(horas==h_abrir && minutos==m_abrir)
                {
                    if(sptArduino.IsOpen)
                    {
                        sptArduino.WriteLine("5"); // Abre ventana
                    }
                }
                if (horas == h_cerrar&& minutos == m_cerrar)
                {
                    if (sptArduino.IsOpen)
                    {
                        sptArduino.WriteLine("6"); // Cierra ventana
                    }
                }




            }
        }

        private void radOnBAgua_CheckedChanged(object sender, EventArgs e)
        {
            if(sptArduino.IsOpen)
            {
                sptArduino.WriteLine("7"); // envia el comando para encender bomba
            }
        }

        private void radOffBAgua_CheckedChanged(object sender, EventArgs e)
        {
            if (sptArduino.IsOpen)
            {
                sptArduino.WriteLine("8"); // envia el comando para apagar bomba
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Antes de Cerrar Form Apaga todos los Actuadores y Cierra la comunicacion serie
            if (sptArduino.IsOpen)
            {
                sptArduino.WriteLine("4");
                sptArduino.WriteLine("6");
                sptArduino.WriteLine("8");
                sptArduino.WriteLine("A");
                sptArduino.WriteLine("C");
                sptArduino.Close();
            }
        }

        private void radOnBAire_CheckedChanged(object sender, EventArgs e)
        {
            if (sptArduino.IsOpen)
            {
                sptArduino.WriteLine("9"); // envia el comando para encender bomba aire
            }
        }

        private void radOffBAire_CheckedChanged(object sender, EventArgs e)
        {
            if (sptArduino.IsOpen)
            {
                sptArduino.WriteLine("A"); // envia el comando para apagar bomba aire
            }
        }

        private void radOnVent_CheckedChanged(object sender, EventArgs e)
        {
            if (sptArduino.IsOpen)
            {
                sptArduino.WriteLine("5"); // envia el comando para abrir ventana
            }
        }

        private void radOffVent_CheckedChanged(object sender, EventArgs e)
        {
            if (sptArduino.IsOpen)
            {
                sptArduino.WriteLine("6"); // envia el comando para cerrar ventana
            }
        }

        private void radOnCalef_CheckedChanged(object sender, EventArgs e)
        {
            if (sptArduino.IsOpen)
            {
                sptArduino.WriteLine("B"); // envia el comando para encender calefaccion
            }
        }

        private void radOffCalef_CheckedChanged(object sender, EventArgs e)
        {
            if (sptArduino.IsOpen)
            {
                sptArduino.WriteLine("C"); // envia el comando para apagar calefaccion
            }
        }

        private void radOnAcond_CheckedChanged(object sender, EventArgs e)
        {
            if (sptArduino.IsOpen)
            {
                sptArduino.WriteLine("3"); // envia el comando para encender aire acondicionado
            }
        }

        private void radOffAcond_CheckedChanged(object sender, EventArgs e)
        {
            if (sptArduino.IsOpen)
            {
                sptArduino.WriteLine("4"); // envia el comando para apagar aire acondicionado
            }
        }

        private void btnActSerie_Click(object sender, EventArgs e)
        {
            if (sport == "")
                MessageBox.Show("Seleccione el Puerto", "Invernadero", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                sptArduino.PortName = sport;

            if (!sptArduino.IsOpen && sport != "")
            {
                sptArduino.Open(); // Activa la comunicacion serial
                tmrArduino.Start(); // Activa timer Arduino
                txtECom.Text = "COMUNICACION ACTIVADA";
                radManual.Checked = true;
                grpOperacion.Enabled = true;
            }
            
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            hora = DateTime.Now.ToString("HH:mm:ss");  // Obtiene la hora del sistema en formato de 24 horas
            horas = Convert.ToInt32(DateTime.Now.ToString("HH")); // Obiene el valor de horas actual
            minutos = Convert.ToInt32(DateTime.Now.ToString("mm")); // Obtiene el Valor de minutos actual
            txtHora.Text = hora; // Imprime Hora 
            fecha = DateTime.Now.ToLongDateString(); // Obtiene Fecha del sistema 
            txtFecha.Text = fecha; // Imprime Fecha
        }
    }
}
