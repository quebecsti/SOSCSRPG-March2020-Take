using System;
using System.Collections.Generic;
using System.Text;
using Engine.Models;
using Engine.Factories;

	

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation { get; set; }
        public World CurrentWorld { get; set; }

        public bool HasLocationToNoth
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null;
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

            CurrentLocation = CurrentWorld.LocationAt(-1,0);
        }

        public void MoveNorth()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
        }
        public void  MoveWest()
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
