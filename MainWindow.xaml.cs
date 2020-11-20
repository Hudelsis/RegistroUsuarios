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
using RegistroUsuarios.UI.Registros;
using RegistroUsuarios.UI.Consultas;

namespace RegistroUsuarios
{
    public partial class MainWindow : Window
    {
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Current.Shutdown();
        }
        public MainWindow()
        {
            InitializeComponent();
        }
        private void rUsuariosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rUsuarios ventana = new rUsuarios();
            ventana.Show();
        }
        private void cUsuariosMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cUsuarios ventana = new cUsuarios();
            ventana.Show();
        }
        private void AyudaMenu_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
