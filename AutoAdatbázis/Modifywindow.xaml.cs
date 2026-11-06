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
using System.Windows.Shapes;

namespace AutoAdatbázis
{
    /// <summary>
    /// Interaction logic for Modifywindow.xaml
    /// </summary>
    public partial class Modifywindow : Window
    {
        public Modifywindow()
        {
            InitializeComponent();
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            

            this.Close();
        }
    }
}
