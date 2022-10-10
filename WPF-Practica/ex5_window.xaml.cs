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
    /// Логика взаимодействия для ex5_window.xaml
    /// </summary>
    public partial class ex5_window : Window
    {
        public ex5_window()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Hide();
            mainWindow.ShowDialog();
            this.Close();
        }

        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            int M = 0;
            int N = 0;
            Random random = new Random();
            try
            {
                M = int.Parse(tb_M.Text);
                N = int.Parse(tb_N.Text);
                if (M < 0 || N < 0)
                {
                    MessageBox.Show("Введено отрицательное число");
                    return;
                }               
                
            }
            catch (Exception)
            {
                MessageBox.Show("Введено неверное значение");
            }

            int[,] array = new int[M, N];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-11, 11);
                }
            }          
            array = sortArray(array, N, M);
            int min = array[0, 0];
            int max = array[M - 1, N - 1];

        }
       private int [,] sortArray(int[,] arr, int N, int M)
        {
            for (int i = N * M - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j / M, j % M] > arr[i / M, i % M])
                    {
                        int x = arr[j / M, j % M];
                        arr[j / M, j % M] = arr[i / M, i % M];
                        arr[i / M, i % M] = x;
                    }
                }
            }
            return arr;
        }
    }
}
