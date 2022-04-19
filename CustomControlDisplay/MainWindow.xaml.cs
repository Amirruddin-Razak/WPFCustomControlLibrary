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

namespace CustomControlDisplay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : CustomWindowControl.CustomWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowModal_Click(object sender, RoutedEventArgs e)
        {
            //Modal.IsOpen = true;
        }

        private void CloseModal_Click(object sender, RoutedEventArgs e)
        {
            //Modal.IsOpen = false;
        }
    }
}
