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

namespace MVVMCore.DataBindings
{
    /// <summary>
    /// Interaction logic for SampleDataBinding.xaml
    /// </summary>
    public partial class DataBindings : Window
    {
        public DataBindings()
        {
            InitializeComponent();
            x_MySlider.Value = 10;
            x_MyTxtbox5.Text = x_MySlider.Value.ToString();
        }
    }
}
