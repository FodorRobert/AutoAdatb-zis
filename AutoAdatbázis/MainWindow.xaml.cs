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

namespace AutoAdatbázis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    class Auto
    {
        public string Márka { get; set; }
        public string Típus { get; set; }
        public int Évjárat { get; set; }
        public Auto(string márka, string típus, int évjárat)
        {
            this.Márka = márka;
            this.Típus = típus;
            this.Évjárat = évjárat;
        }
    }

    public partial class MainWindow : Window
    {
        List<Auto> autok = new List<Auto>();
        public MainWindow()
        {

            InitializeComponent();

            autok.Add(new Auto("Audi", "A4", 2015));
            autok.Add(new Auto("BMW", "330d", 2011));
            autok.Add(new Auto("Mercedes", "C220d", 2023));
            autok.Add(new Auto("Volkswagen", "Golf", 1982));
            dataGrid.ItemsSource = autok;
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem != null && dataGrid.SelectedItem is Auto)
            {
                autok.Remove((Auto)dataGrid.SelectedItem);
                dataGrid.Items.Refresh();
            }
        }

        private void Search(object sender, RoutedEventArgs e)
        {
            string Brand  = BrandComboBox.SelectedItem.ToString();
            string Type = typeComboBox.SelectedItem.ToString();
            int Year = int.Parse(YearTextBox.Text);

            foreach (Auto auto in autok)
            {
                if (!(auto.Márka == Brand && auto.Típus == Type && auto.Évjárat == Year))
                {
                    dataGrid.Items.Remove(auto);
                }

            }
            dataGrid.Items.Refresh();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void Modify(object sender, RoutedEventArgs e)
        {
            if (dataGrid.SelectedItem != null && dataGrid.SelectedItem is Auto)
            {
                Auto selectedAuto = (Auto)dataGrid.SelectedItem;
                Window modifyWindow = new Modifywindow();
                modifyWindow.Owner = this;
                modifyWindow.ShowDialog();
            }
        }
    }
}