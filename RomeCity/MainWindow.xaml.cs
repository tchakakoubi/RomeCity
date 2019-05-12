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

namespace RomeCity
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            this.MinHeight = SystemParameters.MinimizedGridHeight;
        }


        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonOfOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOfOpenMenu.Visibility = Visibility.Collapsed;
            ButtonOfCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonOfCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOfOpenMenu.Visibility = Visibility.Visible;
            ButtonOfCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void GridBarratitulo_MouseDown(object sender, RoutedEventArgs e)
        {
            DragMove();
        }

        private void ButtonFechar_Click1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonMax_Click2(object sender, RoutedEventArgs e)
        {
            if(this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else if(this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
            }
           
        }

        private void ButtonMin_Click3(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Minimized;
            }
            else if (this.WindowState == WindowState.Minimized)
            {
                this.WindowState = WindowState.Normal;
            }
        }

       

        private void ListViewItem_Hotel(object sender, RoutedEventArgs e)
        {
            home.Visibility = Visibility.Hidden;
            zimmer.Visibility = Visibility.Visible;


        }

        private void ListViewItem_Home(object sender, RoutedEventArgs e)
        {
            home.Visibility = Visibility.Visible;
            zimmer.Visibility = Visibility.Hidden;

        }

        private void register_click(object sender, RoutedEventArgs e)
        {

        }

        private void logout_click(object sender, RoutedEventArgs e)
        {

        }

        private void login_click(object sender, RoutedEventArgs e)
        {

        }

        private void aboutUs_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("We are Team Franck && Lea");
        }
    }
}
