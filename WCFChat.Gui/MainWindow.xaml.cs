using System.Windows;
using WCFChat.Logic;

namespace WCFChat.Gui
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly Control _ctrl;

        public MainWindow()
        {
            InitializeComponent();
            _ctrl = new Control();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_ctrl.Test(5189));
        }
    }
}
