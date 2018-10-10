using System;
using System.Collections;
using System.Windows.Forms;


namespace E02___Raso_Padilla_Jose_Manuel
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        ArrayList NombresAlumnos = new ArrayList(); //ArrayList para el nombre de los alumnos
        ArrayList Calificaciones = new ArrayList(); //ArrayList para las calificaciones
        ArrayList Largos = new ArrayList(); //ArrayList creado para almacenar los largos de donde empieza cada clase y donde termina
        int acumulador = 0; //acumulador donde se guarda los largos(utilizado en Largos)
        Funciones Objeto = new Funciones(); //Objeto de la clase donde se realizan las operaciones


        private void btnCargar_Click(object sender, EventArgs e) //Evento al dar click donde se llama al metodo de CargarClase con los valores de referencia
        {                                                        //siendo los ArrayList y el acumulador ademas se manda las ListBox de alumnos y clases como valor
            Objeto.CargarClase(ref NombresAlumnos,ref Calificaciones,ref Largos,lstAlumnos,lstClases,ref acumulador);
        }

        private void btnDesplegar_Click(object sender, EventArgs e) //Evento que al dar click se llama al metodo de desplegar pidiendo como parametros
        {                                                           //los ArrayList de nombres alumnos, calificaciones, el largo de donde empieza dicha clase        
            try                                                     //y donde acaba siendo los contador 1 y 2 respectivamente y la ListBox alumnos para desplegar los resultados.
            {
                lblNombreClase.Text = lstClases.Text; //Se pone el nombre de la clase como "titulo".
                lstAlumnos.Items.Clear(); //Se limpia la lista para que no se muestren los datos del despliegue anterior
                Objeto.DesplegarClase(NombresAlumnos, Calificaciones, Convert.ToInt32(Largos[lstClases.SelectedIndex * 2]), Convert.ToInt32(Largos[((lstClases.SelectedIndex * 2) + 1)]),lstAlumnos);
            }  //la formula para el contador fue un poco de logica debido a que el indice 0 y 1 del largo son para la clase 1, el 2 y 3 para la clase 2 . . . con la formula de SelectedIndex * 2 y (SelectedIndex * 2)+1
            catch (Exception ex)
            {
                MessageBox.Show("Error encontrado: " + ex.ToString());
            }
        }
    }
}
