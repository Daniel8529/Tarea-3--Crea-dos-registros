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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Registro_Carrera_y_Estudiante.BLL;
using Registro_Carrera_y_Estudiante.Entidades;

namespace Registro_Carrera_y_Estudiante.UI.Registro
{
    /// <summary>
    /// Interaction logic for cEstudiante.xaml
    /// </summary>
    
    public partial class cEstudiante : Window
    {
        public cEstudiante()
        {
            InitializeComponent();
            
            var lista = EstudianteBLL.GetLista();
            Ventanaconsultar.ItemsSource = lista;
            
        }

        private void guardar_Click(object sender, RoutedEventArgs e)
        {


             Estudiante estudiante= new  Estudiante (int.Parse(Estudiantetxt.Text),Nombretxt.Text,Emailtxt.Text,int.Parse(Carreraidtxt.Text));
           
           
            if (!EstudianteBLL.Existes(int.Parse(Estudiantetxt.Text)))
            {
                   var paso = EstudianteBLL.Insertar(estudiante);
            }
            else
            {
                MessageBox.Show("El RolID que ingreso ya existe");
            }
           
                
             var lista =EstudianteBLL.GetLista();
             Ventanaconsultar.ItemsSource = lista;
        }

        private void editar_Click(object sender, RoutedEventArgs e)
        {
          
          Estudiante estudiante= new  Estudiante (int.Parse(Estudiantetxt.Text),Nombretxt.Text,Emailtxt.Text,int.Parse(Carreraidtxt.Text));


            var paso = EstudianteBLL.Existe(estudiante,int.Parse(Estudiantetxt.Text));
            if (paso)
            {
               
                MessageBox.Show("Registro Editado ", "Exito",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                 MessageBox.Show("No se fue posible Editado ", "Fallo",
                MessageBoxButton.OK, MessageBoxImage.Error);

               
            }


            var lista =EstudianteBLL.GetLista();
            Ventanaconsultar.ItemsSource = lista;
            
            
            

        }

        private void eliminar_Click(object sender, RoutedEventArgs e)
        {
            
            if (EstudianteBLL.Eliminar(int.Parse(Estudiantetxt.Text)))
            {

                MessageBox.Show("Registro Eliminado", "Exito",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No fue posible Eliminar", "Fallo",
                MessageBoxButton.OK, MessageBoxImage.Error);
            }
            var lista = EstudianteBLL.GetLista();
            Ventanaconsultar.ItemsSource = lista;
            
            

        }
    }
}
