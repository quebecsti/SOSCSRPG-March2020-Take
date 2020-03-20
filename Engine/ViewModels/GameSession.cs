using Engine.Factories;
using Engine.Models;
using System.ComponentModel;

namespace Engine.ViewModels
{
    public class GameSession : BaseNotificationClass
    {

        private Location _currentLocation;

        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation
        {
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;
                OnPropertyChanged(nameof(CurrentLocation));
                OnPropertyChanged(nameof(HasLocationToNorth));
                OnPropertyChanged(nameof(HasLocationToWest));
                OnPropertyChanged(nameof(HasLocationToEast));
                OnPropertyChanged(nameof(HasLocationToSouth));
            }
        }

        World CurrentWorld { get; set; }

        public bool HasLocationToNorth
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null;
            }
        }
        public bool HasLocationToWest
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate) != null;
            }
        }
        public bool HasLocationToEast
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate) != null;
            }
        }
        public bool HasLocationToSouth
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1) != null;
            }
        }


        public GameSession()
        {
            CurrentPlayer = new Player();

            CurrentPlayer.Name = "Saumier";
            CurrentPlayer.Level = 1;
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.HitPoints = 0;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.CharacterClass = "Fighter";

            CurrentLocation = new Location();

            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(0, 0);
        }

        public void MoveNorth()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
        }

        public void MoveWest()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);
        }
        public void MoveEast()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);
        }
        public void MoveSouth()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);
        }
    }
}
