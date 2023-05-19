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
using System.IO;
using System.Data.SqlTypes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Szeleromu> eromu = new List<Szeleromu>(); 
        public MainWindow()
        {
            InitializeComponent();

            StreamReader sr = new StreamReader("szeleromu.txt");
            string sor = sr.ReadLine();
            while (sor != null)
            {
                eromu.Add(sor);
            }
            sr.Close();
        }

        private void btnOsszes_Click(object sender, RoutedEventArgs e)
        {
            var osszes = eromu.Count(x => x)
            lbnOsszes.Content = osszes;
        }

        private void btnAtlag_Click(object sender, RoutedEventArgs e)
        {
            var atlag = eromu.Where(x => x.)
        }
    }
}
