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

namespace WPF_Practica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_ex1_Click(object sender, RoutedEventArgs e)
        {
            window_ex1 ex1 = new window_ex1();
            this.Hide();
            ex1.ShowDialog();
            this.Close();
        }

        private void btn_ex2_Click(object sender, RoutedEventArgs e)
        {
            ex2_window window2 = new ex2_window();
            window2.Show();
            this.Hide();
        }

        private void btn_ex3_Click(object sender, RoutedEventArgs e)
        {
            ex3_windows ex3 = new ex3_windows();
            ex3.Show();
            this.Hide();
        }

        private void btn_ex4_Click(object sender, RoutedEventArgs e)
        {
            ex4_window ex4 = new ex4_window();
            this.Hide();
            ex4.ShowDialog();
            this.Close();
        }
    }
}
