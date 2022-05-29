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
    /// Логика взаимодействия для Insert_page.xaml
    /// </summary>
    public partial class Insert_page : Page
    {
        public Insert_page()
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
        private void Start_Insert_Click(object sender, RoutedEventArgs e)
        {
            int index;
            try
            {
                index = int.Parse(Index_string.Text);
                if (index < 0 || index > First_insert_string.Text.Length) 
                {
                    throw new Exception("Введите заново индекс!"); 
                }
                Insert_Result.Text = First_insert_string.Text.Insert(index, Second_insert_string.Text); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!!!", MessageBoxButton.OK, MessageBoxImage.Error); 
            }

        }
    }
}
