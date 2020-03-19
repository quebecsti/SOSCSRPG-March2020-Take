﻿using System;
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
using Engine.ViewModels;


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
