using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PracticaConsultorio
{
    /// <summary>
    /// Lógica de interacción para HistorialConsultasWindows.xaml
    /// </summary>
    public partial class HistorialConsultasWindows : Window
    {
        Paciente paciente;
        public HistorialConsultasWindows(Paciente paciente)
        {
            InitializeComponent();
            //This toma el valor de paciente de la variable global mientras que el otro es paciente var local
            this.paciente = paciente;

            lblNombrePaciente.Text = paciente.Nombre;
            // Crear una nueva variable de los tipos de elementos 
            foreach (Consulta consulta in Datos.consultas)
            {
                var nuevoElementoConsulta = new ElmentoConsultaControl(consulta);
                //Añadir al stackPanel
                //Los elementos se guardan en la propiedad children
                stckHistorialConsultas.Children.Add(nuevoElementoConsulta);
            }
        }
    }
}
