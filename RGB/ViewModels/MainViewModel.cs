using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace RGB.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        private int _R = 0;
        private int _G = 0;
        private int _B = 0;
        private SolidColorBrush _color = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
        public SolidColorBrush color
        {
            get
            {

                return _color;
            }
            set
            {
                _color = value;
                NotifyPropertyChanged();
            }
        }
        public int R
        {
            get
            {
                return _R;
            }
            set
            {
                _R = value;
                color = new SolidColorBrush(Color.FromArgb(255, (byte)_R, (byte)_G, (byte)_B));
                NotifyPropertyChanged();
            }
        }
        public int G
        {
            get
            {
                return _G;
            }
            set
            {
                _G = value;
                color = new SolidColorBrush(Color.FromArgb(255, (byte)_R, (byte)_G, (byte)_B));
                NotifyPropertyChanged();
            }
        }

        public int B
        {
            get
            {
                return _B;
            }
            set
            {
                _B = value;
                color = new SolidColorBrush(Color.FromArgb(255, (byte)_R, (byte)_G, (byte)_B));
                NotifyPropertyChanged();
            }
        }




        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
