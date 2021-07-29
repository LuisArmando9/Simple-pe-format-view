using PeExplorer.ViewModels;
using PeExplorer.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
namespace PeExplorer
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
          
            InitializeComponent();
          
        }
        
        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }
       
        private void MoveWindow(object sender, MouseButtonEventArgs e) => this.DragMove();
       

        private void CloseWindow(object sender, RoutedEventArgs e) => this.Close();

       
    }
}
