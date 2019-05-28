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

namespace StatsGraph
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
        /*
                 <CommandBinding Command="ApplicationCommands.Open"
                        Executed="CommandBinding_OpenExecuted"/>
        <CommandBinding Command="ApplicationCommands.Close"
                        Executed="CommandBinding_Close"/>
        <CommandBinding Command="ApplicationCommands.Save"
                        Executed="CommandBinding_SaveExecuted"/>
        <CommandBinding Command="ApplicationCommands.New"
                        Executed="CommandBinding_NewGraph"/>*/
        private void CommandBinding_OpenExecuted(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void CommandBinding_Close(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }

        private void CommandBinding_SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void CommandBinding_NewGraph(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void HelpAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Data Set: Population Estimates, Quarterly\n\n\nAuthor: Tyler MJ Gosling", "About");
        }
    }
}
