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
using Registro_Carrera_y_Estudiante.UI.Registro;
using Registro_Carrera_y_Estudiante.UI.Consulta;

namespace Registro_Carrera_y_Estudiante
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void carrera_Click(object sender, RoutedEventArgs e)
        {
         
          cCarrera m =new cCarrera();
          m.Show();
        }

        private void estudiante_Click(object sender, RoutedEventArgs e)
        {
            cEstudiante m = new cEstudiante();
            m.Show();

        }
          private void consulta_Click(object sender, RoutedEventArgs e)
        {
            EstuyCarr m = new EstuyCarr();
            m.Show();

        }
    }
}
