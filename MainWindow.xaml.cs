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

namespace Documentos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Ancho { get; set; } = 500;
        public int Alto { get; set; } = 500;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            Documento nuevo = new Documento();
            nuevo.Owner = this;
            nuevo.Width = Ancho;
            nuevo.Height = Alto;
            nuevo.Title = $"Documento {this.OwnedWindows.Count}";
            nuevo.Show();
        }

        private void ConfiguracionButton_Click(object sender, RoutedEventArgs e)
        {
            Configuracion configuracion = new Configuracion();
            configuracion.Owner = this;
            configuracion.Ancho = Ancho;
            configuracion.Alto = Alto;
            configuracion.ShowDialog();
            if (configuracion.DialogResult == true)
            {
                Alto = configuracion.Alto;
                Ancho = configuracion.Ancho;
            }
        }
    }
}
