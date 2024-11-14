using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DemoBindingObjetoNegocio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Persona usuario = new Persona("Juan", 32);
        public MainWindow()
        {
            InitializeComponent();

            // nombreTextBox.DataContext = usuario;
            // edadTextBox.DataContext = usuario;

            datosStackPanel.DataContext = usuario;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Nombre: " + usuario.Nombre + " Edad: " + usuario.Edad);

            Trace.WriteLine("Nombre: " + ((Persona)nombreTextBox.DataContext).Nombre);
            Trace.WriteLine("Edad: " + ((Persona)edadTextBox.DataContext).Edad);

            usuario.Nombre = "Pepe";
            usuario.Edad = 65;
        } 
    }
}