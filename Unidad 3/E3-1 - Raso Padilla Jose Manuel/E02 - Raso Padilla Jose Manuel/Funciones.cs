using System;
using System.Collections;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace E02___Raso_Padilla_Jose_Manuel
{
    class Funciones
    {
        public void DesplegarClase(ArrayList NombresAlumnos, ArrayList Calificaciones,int contador, int contador2, ListBox lstAlumnos) //Se reciben los parametros
        {
            for(contador=contador;contador<contador2;contador++) //Realiza el despliegue concatenando el nombre y la calificacion en base al indice que tienen
            {  //Los indices (contador y contador2) estan en base a los largos previamente mencionados donde se ponia donde empezaba y terminaba cada clase.
                string cadena = Convert.ToString(NombresAlumnos[contador]) + " - " + Convert.ToString(Calificaciones[contador]);
                lstAlumnos.Items.Add(cadena);
            }
        }

        public void CargarClase(ref ArrayList NombresAlumnos, ref ArrayList Calificaciones, ref ArrayList Largos, ListBox lstAlumnos,ListBox lstClases,ref int acumulador)
        {   //Metodo para cargar clases en las listas
            try
            {
                Largos.Add(acumulador);//se guarda el indice donde empieza la clase.
                string nombreClase = Interaction.InputBox("Ingrese nombre de la clase", "Nombre",""); //Se ingresan el nombre y calificacion de la clase mediante un inputbox
                int cantidadAlumnos = Convert.ToInt32(Interaction.InputBox("Ingrese cantidad de alumnos", "Cantidad","0"));
                Largos.Add(cantidadAlumnos + acumulador); //Se pone el indice de donde acaba la clase dentro de la ArrayList de largos
                lstClases.Items.Add(nombreClase); //Se agrega el nombre de la clase a la ListBox para las clases
                lstClases.SelectedIndex = lstClases.SelectedIndex+1; //Se selecciona la clase creada
                for(int contadorSubida=0;contadorSubida<cantidadAlumnos;contadorSubida++) //Ingresa los alumnos
                {

                    string nombre = Interaction.InputBox("Ingrese nombre del alumno " + (contadorSubida + 1), "Nombre del alumno " + (contadorSubida + 1),"Desconocido");
                    int calificacion = Convert.ToInt32(Interaction.InputBox("Ingrese calificacion del alumno " + (contadorSubida + 1), "Calificacion del alumno " + (contadorSubida + 1),"0"));
                    NombresAlumnos.Add(nombre);
                    Calificaciones.Add(calificacion);
                }
                acumulador = acumulador + cantidadAlumnos; //El acumulador se suma con la cantidad de alumnos y como es valor de referencia es modificado en el form 1
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error encontrado\n\n");
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
