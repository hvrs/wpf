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
    /// Логика взаимодействия для ex2_window.xaml
    /// </summary>
    public partial class ex2_window : Window
    {
        public ex2_window()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            string numStr = tb_numb.Text;
            double numDoub;
            try
            {
                numDoub = Convert.ToDouble(numStr);
                if (Convert.ToInt32(numDoub) == numDoub)
                    lbl_info.Content = "1";
                else
                    lbl_info.Content = "2";
            }
            catch (Exception)
            {
                lbl_info.Content = "0";
            }
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }
    }
}
