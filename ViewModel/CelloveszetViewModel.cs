using System;
using System.Windows;

namespace celloveszetWPF
{
    public partial class MainWindow : Window
    {
        private readonly CelloveszetViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();
            viewModel = new CelloveszetViewModel();
            dgCellovok.ItemsSource = viewModel.Cellovok;
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
    public class CelloveszetViewModel
    {
        public ObservableCollection<Cellovo> Cellovok { get; set; }

        public CelloveszetViewModel()
        {
            Cellovok = new ObservableCollection<Cellovo>();
        }

        public void HozzaadUjCellovo(string nev, int loves1, int loves2, int loves3, int loves4)
        {
            Cellovok.Add(new Cellovo { Nev = nev, Loves1 = loves1, Loves2 = loves2, Loves3 = loves3, Loves4 = loves4 });
        }

        public void MentesFajlba()
        {
            // Implementation for saving to file
        }
    }

    public class Cellovo
    {
        public string Nev { get; set; }
        public int Loves1 { get; set; }
        public int Loves2 { get; set; }
        public int Loves3 { get; set; }
        public int Loves4 { get; set; }
    }
}
