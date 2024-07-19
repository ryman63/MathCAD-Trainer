using MathCAD_Trainer_0._01.Core;
using System;

namespace MathCAD_Trainer_0._01.MVVM.ViewModel
{
    class ExitViewModel : ObservableObject
    {
        public object Exit { get; set; }

        public ExitViewModel()
        {
            Exit = new RelayCommand(o =>
            {
                System.Windows.Application.Current.Shutdown();
            });
        }
    }
}
