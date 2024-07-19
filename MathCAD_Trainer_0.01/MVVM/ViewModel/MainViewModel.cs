using System;
using MathCAD_Trainer_0._01.Core;

namespace MathCAD_Trainer_0._01.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand TestingViewCommand { get; set; }
        public RelayCommand ReferenceViewCommand { get; set; }
        public RelayCommand ExitViewCommand { get; set; }
        public RelayCommand SettingViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public TestingViewModel TestingVM { get; set; }
        public ReferenceViewModel ReferenceVM { get; set; }
        public ExitViewModel ExitVM { get; set; }
        public SettingViewModel SettingVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        

        public MainViewModel()
        {
            HomeVM = new HomeViewModel(this);
            TestingVM = new TestingViewModel();
            ReferenceVM = new ReferenceViewModel();
            SettingVM = new SettingViewModel();
            ExitVM = new ExitViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            TestingViewCommand = new RelayCommand(o =>
            {
                CurrentView = TestingVM;
            });

            ReferenceViewCommand = new RelayCommand(o =>
            {
                CurrentView = ReferenceVM;
            });

            ExitViewCommand = new RelayCommand(o =>
            {
                CurrentView = ExitVM;
            });

            SettingViewCommand = new RelayCommand(o =>
            {
                CurrentView = SettingVM;
            });
        }
    }
}
