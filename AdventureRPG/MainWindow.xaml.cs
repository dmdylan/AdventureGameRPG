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
using AdventureRPG_Classes;
using AdventureRPG_Classes.ViewModels;
using AdventureRPG;

namespace AdventureRPG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameSession _gameSession;
        //Window mainWindow = new MainWindow();

        //public MainWindow main = new MainWindow();
        
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            _gameSession = new GameSession();
            DataContext = _gameSession;
            

        }

        public void LoadTheMenu()
        {
        }

        private void SaveGame_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LoadGame_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Visibility = Visibility.Visible;
            //NewGamePopup.IsOpen = true;
            //Menu menu = new Menu();
            //menu.Visibility = Visibility.Visible;
        }


        //make new method that takes a notification of window closing and reopens the mainwindow
    }
}
