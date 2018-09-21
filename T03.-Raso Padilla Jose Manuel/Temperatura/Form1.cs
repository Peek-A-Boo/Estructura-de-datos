using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura
{
    public partial class Form1 : Form
    {
        double Temperatura = 0;
        int Valor = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void vsbTemperatura_Scroll(object sender, ScrollEventArgs e)
        {
            Valor = vsbTemperatura.Value;
            ComparaTipo();
            DespliegaTemperatura();
            DespliegaValor();
        }

        private void ComparaTipo()
        {
            if (rbtFahrenheit.Checked==true)
            {
                CalculaCelsius();
                lblGrados.Text = "Fahrenheit";
                vsbTemperatura.Maximum = 459;
                vsbTemperatura.Minimum = -459;
            }
            else
            {
                CalculaFahrenheit();
                lblGrados.Text = "Celsius";
                vsbTemperatura.Maximum = 273;
                vsbTemperatura.Minimum = -273;
            }
        }

        private double CalculaFahrenheit()
        {
            Temperatura = Math.Round((Valor - 32) / 1.8,2);
            return Temperatura;
        }

        private double CalculaCelsius()
        {
            Temperatura = Math.Round((Valor * 1.8) + 32,2);
            return Temperatura;
        }

        private void DespliegaTemperatura()
        {
            if (rbtFahrenheit.Checked == true)
            {
                lblTemperatura.Text = "La temperatura es de: " + Convert.ToString(CalculaFahrenheit()) + " Grados Celsius";
            }
            else
            {
                lblTemperatura.Text = "La temperatura es de: " + Convert.ToString(CalculaCelsius()) + " Grados Fahrenheit";
            }
        }

        private void DespliegaValor()
        {
            txtTemperatura.Text = Convert.ToString(Valor);
        }

        private void ResetDatos()
        {
            vsbTemperatura.Value = 0;
        }

        private void rbtFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            ResetDatos();
            ComparaTipo();
            DespliegaTemperatura();
            DespliegaValor();
        }

        private void rbCelsius_CheckedChanged(object sender, EventArgs e)
        {
            ResetDatos();
            ComparaTipo();
            DespliegaTemperatura();
            DespliegaValor();
        }
    }
}
