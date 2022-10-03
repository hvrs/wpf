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
    /// Логика взаимодействия для ex3_windows.xaml
    /// </summary>
    public partial class ex3_windows : Window
    {
        public ex3_windows()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            string nums = "";
            Random random = new Random();
            int[] array = new int[100];
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(-1000,1000);
            
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) < 10)
                {
                    nums += $"{array[i]} ";
                }
                else if (Math.Abs(array[i]) <= 99)
                {
                    if (array[i]%11==0)
                    {
                        nums += $"{array[i]} ";
                    }
                }
                else if (Math.Abs(array[i]) <= 999)
                {
                    if (array[i] % 111 == 0)
                    {
                        nums += $"{array[i]} ";
                    }
                }
            }
            if (nums=="")
                lbl_info.Content = "Числа отсутсвуют";
            else
                lbl_info.Content = nums;

        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }


    }
}
