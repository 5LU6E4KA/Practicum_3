using System;
using System.Collections.Generic;
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

namespace Practicum_3
{
    /// <summary>
    /// Логика взаимодействия для Trim_page.xaml
    /// </summary>
    public partial class Trim_page : Page
    {
        public Trim_page()
        {
            InitializeComponent();
        }
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Start_Trim_Click(object sender, RoutedEventArgs e)
        {
            if (Second_trim_string.Text == "")
            {
                Trim_Result.Text = First_trim_string.Text.Trim();
            }
            else
            {
                char[] ch = Second_trim_string.Text.ToCharArray();
                Trim_Result.Text = First_trim_string.Text.Trim(ch);
            }
        }
    }
}
