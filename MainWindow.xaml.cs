using celloveszetWPF.ViewModels;
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

namespace celloveszetWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CelloveszetViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();
            viewModel = new CelloveszetViewModel();
            dgCellovok.ItemsSource = viewModel.GetCellovok();
        }

        private void Hozzaad_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tbLoves1.Text, out int loves1) &&
                int.TryParse(tbLoves2.Text, out int loves2) &&
                int.TryParse(tbLoves3.Text, out int loves3) &&
                int.TryParse(tbLoves4.Text, out int loves4))
            {
                viewModel.HozzaadUjCellovo(tbNev.Text, loves1, loves2, loves3, loves4);
            }
            else
            {
                MessageBox.Show("Csak számokat írj be!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Mentes_Click(object sender, RoutedEventArgs e)
        {
            viewModel.MentesFajlba();
        }
    }
}

