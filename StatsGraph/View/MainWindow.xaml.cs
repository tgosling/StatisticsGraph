
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Win32;
using StatsGraph.ViewModel;
using StatsGraph.Helper;


namespace StatsGraph
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModelMain mainView { get; set; }
        private string _currentFile;
        public MainWindow()
        {
            InitializeComponent();
            mainView = new ViewModelMain();
            DataContext = mainView;
          
        }
        /*  Method Name: CommandBinding_OpenExecuted 
         *      Purpose: Handles the FileMenu->Open New File event
         *      Accepts: object sender, ExecutedRoutedEventArgs e
         *      Returns: void
         */
        private void CommandBinding_OpenExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == true)
            {
                mainView.OCData.Clear();
                foreach(var sm in FileParser.ReadCSVFile(ofd.FileName))
                    mainView.OCData.Add(sm);
            }
        }
        /*  Method Name: CommandBinding_Close 
         *      Purpose: Handles the FileMenu->Close/Exit event
         *      Accepts: object sender, ExecutedRoutedEventArgs e
         *      Returns: void
         */
        private void CommandBinding_Close(object sender, ExecutedRoutedEventArgs e)
        {
            Close();
        }
        /*  Method Name: CommandBinding_SaveExecuted 
         *      Purpose: Handles the FileMenu->Save to File event
         *      Accepts: object sender, ExecutedRoutedEventArgs e
         *      Returns: void
         */
        private void CommandBinding_SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if(sfd.ShowDialog() == true)
            {
                _currentFile = sfd.FileName;
                FileParser.WriteCSVFile(mainView.OCData, _currentFile);
            }
        }

        private void CommandBinding_NewGraph(object sender, ExecutedRoutedEventArgs e)
        {

        }
        /*  Method Name: HelpAbout_Click 
         *      Purpose: Handles the HelpMenu->About event
         *      Accepts: object sender, ExecutedRoutedEventArgs e
         *      Returns: void
         */
        private void HelpAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Data Set: Population Estimates, Quarterly\n\n\nAuthor: Tyler MJ Gosling", "About");
        }
    }
}
