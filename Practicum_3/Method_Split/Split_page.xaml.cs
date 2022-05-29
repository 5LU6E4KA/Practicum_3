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
using System.Text.RegularExpressions;

namespace Practicum_3
{
    /// <summary>
    /// Логика взаимодействия для Split_page.xaml
    /// </summary>
    public partial class Split_page : Page
    {
        public Split_page()
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
        private void Start_Split_Click(object sender, RoutedEventArgs e)
        {
            Split_Result.Clear();
            string[] split_res = First_split_string.Text.Split(Second_split_string.Text);
            foreach (string elem in split_res)
            {
                Split_Result.Text += (elem + "\n");
            }
            Split_Result.Text.Trim();
        }
    }
}
