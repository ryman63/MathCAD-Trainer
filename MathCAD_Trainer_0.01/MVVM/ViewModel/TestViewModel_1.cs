using System.Windows.Input;
using System.Data.Entity;
using MathCAD_Trainer_0._01.MVVM.Model;
using MathCAD_Trainer_0._01.Core;
using System.Collections.Generic;

namespace MathCAD_Trainer_0._01.MVVM.ViewModel
{
    class TestViewModel_1 : ObservableObject
    {

        public Test _test; 

        /*
        public void setTestResult
        {
            set { value = _test; }
        }
        */

        #region Commands

        public ICommand SaveResults { get; set; }

        public ICommand CheckAnswers { get; }


        private bool CanCheckAnswersExecute(object p)
        {
            return true;
        }

        private void OnCheckAnswersExecuted(object p)
        {
           
        }

        private bool CanSaveResultExecute(object p)
        {
            return true;
        }

        private void OnSaveResultExecuted(object p)
        {
            
        }

        #endregion



        public TestViewModel_1(Test test)
        {
            _test = test;
        }
    }
}
