using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace E02___Raso_Padilla_Jose_Manuel
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        List<string> NombresAlumnos = new List<string>();
        List<int> Calificaciones = new List<int>();
        List<int> Largos = new List<int>();
        int Contador2 = 0;
        int Contador = 0;
        string Cadena = "";
        int ContadorClases = 0;
        int CantidadAlumnos = 0;
        string NombreClase = "";
        int ContadorSubida = 0;
        string Nombre = "";
        int Calificacion = 0;
        int Acumulador = 0;

        void DesplegarClase()
        {
            try
            {
                lblNombreClase.Text = lstClases.Text;
                lstAlumnos.Items.Clear();
                Contador = Largos.ElementAt(lstClases.SelectedIndex * 2);
                Contador2 = Largos.ElementAt((lstClases.SelectedIndex * 2) + 1);
                do
                {

                    Cadena = NombresAlumnos.ElementAt(Contador) + " - " + Convert.ToString(Calificaciones.ElementAt(Contador));
                    lstAlumnos.Items.Add(Cadena);
                    Contador++;

                } while (Contador < Contador2);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error encontrado\n\n");
            }

        }

        void CargarClase()
        {
            try
            {
                Largos.Add(Acumulador);
                NombreClase = Interaction.InputBox("Ingrese nombre de la clase", "Nombre");
                CantidadAlumnos = Convert.ToInt32(Interaction.InputBox("Ingrese cantidad de alumnos", "Cantidad"));
                Largos.Add(CantidadAlumnos + Acumulador);
                lstClases.Items.Add(NombreClase);
                lstClases.SelectedIndex = ContadorClases;
                do
                {

                    Nombre = Interaction.InputBox("Ingrese nombre del alumno " + (ContadorSubida + 1), "Nombre del alumno " + (ContadorSubida + 1));
                    Calificacion = Convert.ToInt32(Interaction.InputBox("Ingrese calificacion del alumno " + (ContadorSubida + 1), "Calificacion del alumno " + (ContadorSubida + 1)));
                    NombresAlumnos.Add(Nombre);
                    Calificaciones.Add(Calificacion);
                    ContadorSubida++;

                } while (ContadorSubida < CantidadAlumnos);
                Reset();
            }

            catch(Exception ex)
            {
                MessageBox.Show("Error encontrado\n\n");;
            }
        }

        void Reset()
        {
            Acumulador = CantidadAlumnos + Acumulador;
            ContadorSubida = 0;
            CantidadAlumnos = 0;
            NombreClase = "";
            Calificacion = 0;
            Nombre = "";
            ContadorClases++;
            
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarClase();
        }

        private void btnDesplegar_Click(object sender, EventArgs e)
        {
            DesplegarClase();
        }
    }
}
