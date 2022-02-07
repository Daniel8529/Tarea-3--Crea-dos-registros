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

namespace Registro_Carrera_y_Estudiante.UI.Consulta
{
    /// <summary>
    /// Interaction logic for EstuyCarr.xaml
    /// </summary>
    public partial class EstuyCarr : Window
    {
        public EstuyCarr()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Estudiante>();
            var listad = new List<Carrera>();
            if (FiltroComboBox.Text == "Estudiante")
            {
                if (string.IsNullOrWhiteSpace(CriterioTextBox.Text))
                { //si no hay criterio, busco todos         
                    listado = EstudianteBLL.GetList(l => true);

                }
                else
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0:
                            listado = EstudianteBLL.GetList(l => l.Nombre.Contains(CriterioTextBox.Text));

                            break;




                    }
                }
                LibrosDataGrid.ItemsSource = null;
                LibrosDataGrid.ItemsSource = listado;

            }else
            if (FiltroComboBox.Text =="Carrera")
            {
                if (string.IsNullOrWhiteSpace(CriterioTextBox.Text))
                { //si no hay criterio, busco todos         
                    listad = CarreraBLL.GetList(l => true);

                }
                else
                {
                    switch (FiltroComboBox.SelectedIndex)
                    {
                        case 0:
                            listad = CarreraBLL.GetList(l => l.Nombre.Contains(CriterioTextBox.Text));

                            break;




                    }
                }
                LibrosDataGrid.ItemsSource = null;
                LibrosDataGrid.ItemsSource = listad;

            }


            //lleno el grid con la lista






        }

    }
}
