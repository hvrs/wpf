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
    /// Логика взаимодействия для ex4_window.xaml
    /// </summary>
    public partial class ex4_window : Window
    {
        public ex4_window()
        {
            InitializeComponent();               
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            /*sad*/
        }

        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            int M = int.Parse(tb_N.Text);
            int N = int.Parse(tb_M.Text);
            int[] array = new int[M + N];
            Random random = new Random();
            for (int i = 0; i <M; i++)//заполнение первой части
            {
                array[i] = random.Next(0,15);
                lbl_1st.Content += $" {array[i]}";
            }
            for (int i = M; i < N+M; i++)//вторая часть
            {
                array[i] = random.Next(0,15);
                lbl_nd.Content += $" {array[i]}";
            }
            for (int i = 0; i < N+M; i++)
            {
                lbl_fullarray.Content += $" {array[i]}";
            }

            int k = M + N - 1;
            int temp;
            for (int j  = 0; j < (M+N)/2; j++)
            {
                temp = array[0];
                for (int i = 0; i < N+M -1; i++)
                {
                    array[i] = array[i + 1];
                }
                array[k] = temp;
                
            }


            for (int i = 0; i < array.Length; i++)
            {
                lbl_goodArray.Content += $" {array[i]}";
            }
        }
    }
}
