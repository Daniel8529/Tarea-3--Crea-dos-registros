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
    /// Interaction logic for cCarrera.xaml
    /// </summary>
    public partial class cCarrera : Window
    {
        public cCarrera()
        {
           InitializeComponent();
           var lista =CarreraBLL.GetLista();
             Ventanaconsultar.ItemsSource = lista;
        }
       

        private void guardar_Click(object sender, RoutedEventArgs e)
        {


             Carrera carreras = new Carrera (int.Parse(carreraidtext.Text),nombrestext.Text);
            
            if (!CarreraBLL.Existes(int.Parse(carreraidtext.Text)))
            {
                   var paso = CarreraBLL.Insertar(carreras);
            }
            else
            {
                MessageBox.Show("El RolID que ingreso ya existe");
            }
           
                
             var lista =CarreraBLL.GetLista();
             Ventanaconsultar.ItemsSource = lista;
        }

        private void editar_Click(object sender, RoutedEventArgs e)
        {
          
           Carrera carreras = new Carrera (int.Parse(carreraidtext.Text),nombrestext.Text);


            var paso = CarreraBLL.Existe(carreras,int.Parse(carreraidtext.Text));
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


            var lista = CarreraBLL.GetLista();
            Ventanaconsultar.ItemsSource = lista;
            
            

        }

        private void eliminar_Click(object sender, RoutedEventArgs e)
        {
            
            if (CarreraBLL.Eliminar(int.Parse(carreraidtext.Text)))
            {

                MessageBox.Show("Registro Eliminado", "Exito",
                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("No fue posible Eliminar", "Fallo",
                MessageBoxButton.OK, MessageBoxImage.Error);
            }
            var lista = CarreraBLL.GetLista();
            Ventanaconsultar.ItemsSource = lista;
            

        }
       
    }
}
