using Engine.ViewModels;
using System.Windows;

namespace WPFUi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private GameSession _gamesSession;
        public MainWindow()
        {
            InitializeComponent();

            _gamesSession = new GameSession();

            DataContext = _gamesSession;
        }

        private void OnClick_MoveNorth(object sender, RoutedEventArgs e)
        {
            _gamesSession.MoveNorth();
        }
        private void OnClick_MoveWest(object sender, RoutedEventArgs e)
        {
            _gamesSession.MoveWest();
        }
        private void OnClick_MoveEast(object sender, RoutedEventArgs e)
        {
            _gamesSession.MoveEast();
        }
        private void OnClick_MoveSouth(object sender, RoutedEventArgs e)
        {
            _gamesSession.MoveSouth();
        }
    }
}
