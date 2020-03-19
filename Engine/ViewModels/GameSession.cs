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
           

        }
        public void  MoveWest()
        {

        }
        public void MoveEast()
        {

        }
        public void MoveSouth()
        {
           
        }
    }
}
