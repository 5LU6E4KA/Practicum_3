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
    /// Логика взаимодействия для Substring.xaml
    /// </summary>
    public partial class Substring : Page
    {
        public Substring()
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
        private void Start_Substring_Click(object sender, RoutedEventArgs e)
        {
            int count = -1, index;
            try
            {
                try
                {
                    index = int.Parse(Second_substring_string.Text);
                    if (index < 0 || index > First_substring_string.Text.Length) { throw new Exception(); }
                }
                catch { throw new Exception("Введите индекс заново!"); }
                if (Count_string.Text != "")
                {
                    try
                    {
                        count = Convert.ToInt32(Count_string.Text);
                        if (count < 0 || index > First_substring_string.Text.Length) { throw new Exception(); }
                    }
                    catch { throw new Exception("Введите количество символов заново!"); }
                }
                Substring_Result.Text = count < 0 ? First_substring_string.Text.Substring(index) : First_substring_string.Text.Substring(index, count);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка!!!", MessageBoxButton.OK, MessageBoxImage.Error); }
        }
    }
}
