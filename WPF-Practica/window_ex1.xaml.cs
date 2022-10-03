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
using System.Windows.Shapes;

namespace WPF_Practica
{
    /// <summary>
    /// Логика взаимодействия для window_ex1.xaml
    /// </summary>
    public partial class window_ex1 : Window
    {
        public window_ex1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            string numStr = tb_numb.Text;
            if (numStr.Length < 10000)
            {
                try
                {
                    int numb = Convert.ToInt32(numStr, 2);
                    if (numb % 15 == 0)
                    {
                       
                        lbl_info.Content = $"Число{numb} делится на 15 ";
                    }
                    else
                    {
                        lbl_info.Content = $"Число {numb} НЕ делится на 15 ";
                    }
                }
                catch (Exception)
                {
                    lbl_info.Content = "Введите двоичное число!";

                }
            }

        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
