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

namespace Practicum_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Concat, substring, contains, join, indexof, insert, remove, replace, toupper, tolower, split
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Content = new Page1();
        }
    }
}
