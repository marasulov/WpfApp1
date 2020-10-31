using System.Windows;
using System.Windows.Input;
using WpfApp1.Models;
using WpfApp1.ViewModel;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new SheetViewModel();
            CommandBinding commandBinding = new CommandBinding();
            commandBinding.Command = ApplicationCommands.Copy;
            commandBinding.Executed += ShowCommand_Executed;
            transmittalCheckBox.CommandBindings.Add(commandBinding);
        }

        private void NewCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {

            TransmittalPanel.Visibility = Visibility.Visible;
            
        }

        private void ShowCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void ShowCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {

                TransmittalPanel.Visibility = Visibility.Visible;
        }

    }
    public class WindowCommands
    {
        static WindowCommands()
        {
            Show = new RoutedCommand("Show", typeof(MainWindow));
        }
        public static RoutedCommand Show { get; set; }
    }
}
