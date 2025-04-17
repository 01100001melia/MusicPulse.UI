using System;
using MusicPulse.Core;

namespace MusicPulse.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {


        public HomeViewModel HomeVm{ get; set; }

        private object _CurrentView;

        public object CurrentView
        {
            get { return _CurrentView; }
            set 
            { _CurrentView = value;
                OnPropertyChanged();
            
            
            }
        }

        public  MainViewModel()
        {
            HomeVm = new HomeViewModel();
            CurrentView = HomeVm;
        }

           
    }
}
