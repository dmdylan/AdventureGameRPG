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
using System.Windows.Shapes;
using AdventureRPG_Classes.ViewModels;
using AdventureRPG_Classes;

namespace AdventureRPG
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        public void StartGameClick(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }

        private void FighterChecked(object sender, RoutedEventArgs e)
        {

        }

        private void WizardChecked(object sender, RoutedEventArgs e)
        {

        }

        private void RangerChecked(object sender, RoutedEventArgs e)
        {

        }

        private void CharacterNamed(object sender, TextChangedEventArgs e)
        {
            BindingExpression bindingExpression = CharacterTextBox.GetBindingExpression(TextBox.TextProperty);
            bindingExpression.UpdateSource();
        }
    }
}
