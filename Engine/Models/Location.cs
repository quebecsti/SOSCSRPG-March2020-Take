using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Engine.Models
{
    public class Location : INotifyPropertyChanged
    {
        private int _xCoordinate;
        private int _yCoordinate;
        private string _name;
        private string _description;
        private string _imageName;

        public int XCoordinate
        {
            get
            {
                return _xCoordinate;
            }
            set
            {
                _xCoordinate = value;
                OnPropertyChanged("XCoordinate");
            }

        }
        public int YCoordinate
        {
            get { return _yCoordinate; }
        }
        public string Name
        {
            get
            {
                return _name;


            }
        }
        public string Description
        {
            get
            {
                return _description;

            }

        }
        public string ImageName
        {
            get { return _imageName; }
            set { }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
