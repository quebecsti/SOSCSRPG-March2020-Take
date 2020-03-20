using System.ComponentModel;

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
            get => _xCoordinate;
            set
            {
                _xCoordinate = value;
                OnPropertyChanged(nameof(XCoordinate));
            }
        }
        public int YCoordinate
        {
            get => _yCoordinate;
            set
            {
                _yCoordinate = value;
                OnPropertyChanged(nameof(YCoordinate));
            }
        }
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }
        public string ImageName
        {
            get => _imageName;
            set
            {
                _imageName = value;
                OnPropertyChanged(nameof(ImageName));
            }
        }

      
    }

}
