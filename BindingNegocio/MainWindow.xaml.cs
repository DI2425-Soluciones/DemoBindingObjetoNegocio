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

namespace BindingNegocio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Persona usuario = new Persona("Juan", 20);

            /*
            // Forma-1 para definir el DataContext por propiedades.
            nombreTextBox.DataContext = usuario;
            edadTextBox.DataContext = usuario;
            */

            // Forma-2 para definir el DataContext por PANEL.
            datosStackPanel.DataContext = usuario;  
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            // MessageBox.Show("Hola " + nombreTextBox.Text + ", tienes " + edadTextBox.Text + " años.");  
            // MessageBox.Show(((Persona)nombreTextBox.DataContext).Nombre);

            ((Persona)nombreTextBox.DataContext).Nombre = "Carlos";
        }
    }
}
