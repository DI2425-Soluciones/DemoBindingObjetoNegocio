using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingNegocio
{
    // Definir interfaz INotifyPropertyChanged
    public class Persona:INotifyPropertyChanged
    {
        // public string Nombre { get; set; }
        // public int Edad { get; set; }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { 
                _nombre = value; 

                // this.NotifyPropertyChanged("Nombre");
                NotifyPropertyChanged("Nombre");
            }
        }

        private int _edad;

        public int Edad
        {
            get { return _edad; }
            set {
                _edad = value; 
                NotifyPropertyChanged("Edad");
            }
        }

        public Persona()
        {
            Nombre = "";
            Edad = 0;   
        }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        // Declarar el evento.
        public event PropertyChangedEventHandler? PropertyChanged;

        // Declarar método para invocar el evento.
        public void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }   
    }
}
