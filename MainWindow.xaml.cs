using System.Collections.Generic;
using System;
using System.IO;
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
using System.Xml.Linq;

namespace celloveszetWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Cellovo> cellovok = new List<Cellovo>;
        public MainWindow()
        {
            InitializeComponent();

            StreamReader sr = new StreamReader("lovesek1.csv");
            while (!sr.EndOfStream)
            {
                cellovok.Add(new Cellovo(sr.ReadLine()));
            }
            sr.Close();

            dataGrid1.ItemsSource = cellovok;
            dataGrid1.Items.Refresh();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            bool error = false;

            try
            {
                if (tbxName.Text == "")
                {
                    error = true;
                    MessageBox.Show("The name field cannot be empty!");
                }

                if (int.Parse(tbxShot1.Text) < 0 || int.Parse(tbxShot1.Text) > 99)
                {
                    error = true;
                    MessageBox.Show("The result must be between 0 and 99!");
                }

                if (int.Parse(tbxShot2.Text) < 0 || int.Parse(tbxShot2.Text) > 99)
                {
                    error = true;
                    MessageBox.Show("The result must be between 0 and 99!");
                }
                if (int.Parse(tbxShot3.Text) < 0 || int.Parse(tbxShot3.Text) > 99)
                {
                    error = true;
                    MessageBox.Show("The result must be between 0 and 99!");
                }
                if (int.Parse(tbxShot4.Text) < 0 || int.Parse(tbxShot4.Text) > 99)
                {
                    error = true;
                    MessageBox.Show("The result must be between 0 and 99!");
                }

            }
            catch
            {
                error = true;
                MessageBox.Show("Invalid data input!");
            }

            if (error == false)
            {
                cellovok.Add(new Cellovo(line: $"{tbxName.Text};{tbxShot1.Text};{tbxShot2.Text};{tbxShot3.Text};{tbxShot4.Text}"));
            }

            dataGrid1.Items.Refresh();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("shots2.csv"))
                {
                    foreach (var item in dataGrid1.Items)
                    {
                        if (item is Cellovo shooter)
                        {
                            sw.WriteLine(shooter.ToString());
                        }
                    }
                }

                MessageBox.Show("The save was successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
