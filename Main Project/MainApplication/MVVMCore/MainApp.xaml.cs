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

namespace MVVMCore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DataBindings_Click(object sender, RoutedEventArgs e)
        {
            MVVMCore.DataBindings.DataBindings dataBindings = new MVVMCore.DataBindings.DataBindings();
            dataBindings.Show();
        }

        private void Resources_Click(object sender, RoutedEventArgs e)
        {
            MVVMCore.Resources.Resources resources = new MVVMCore.Resources.Resources();
            resources.Show();
        }
    }
}
