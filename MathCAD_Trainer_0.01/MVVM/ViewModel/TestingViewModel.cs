using MathCAD_Trainer_0._01.Core;
using MathCAD_Trainer_0._01.MVVM.Model;

using System.Collections.Generic;
using System.Data.Entity;

namespace MathCAD_Trainer_0._01.MVVM.ViewModel
{
    class TestingViewModel : ObservableObject
    {

        public AppContext Db;

        IEnumerable<Test> tests;

        public IEnumerable<Test> Tests
        {
            get { return tests; }
            set
            {
                tests = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand OnClickBorder_1 { get; set; }
        public RelayCommand OnClickBorder_2 { get; set; }

        public TestViewModel_1 TestVM_1 { get; set; }
        public TestViewModel_2 TestVM_2 { get; set; }

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

        public TestingViewModel()
        {
            Db = new AppContext();

            //Db.Tests.Load();
            
            Test test = new Test();

            TestVM_1 = new TestViewModel_1(test);
            TestVM_2 = new TestViewModel_2();

            _currentView = TestVM_1;

            OnClickBorder_1 = new RelayCommand(o =>
            {
                CurrentView = TestVM_1;
                
            });

            OnClickBorder_2 = new RelayCommand(o =>
            {
                CurrentView = TestVM_2;
            });
        }
    }
}
