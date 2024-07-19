using System;
using MathCAD_Trainer_0._01.Core;

namespace MathCAD_Trainer_0._01.MVVM.Model
{
    internal class Test : ObservableObject
    {
        private int ID;

        private int Execute;

        private int Grade;

        public int id
        {
            get { return ID; }
            set
            {
                ID = id;
                OnPropertyChanged("id");
            }
        }

        public int execute
        {
            get { return execute; }
            set
            {
                Execute = execute;
                OnPropertyChanged("execute");
            }
        }

        public int grade
        {
            get { return Grade; }
            set
            {
                Grade = grade;
                OnPropertyChanged("grade");
            }
        }

        public bool isCompleted()
        {
            if (this.Execute == 1)
                return true;
            else return false;
        }

        public void setGrade() { }

        public Test()
        {

        }

        public Test(int Execute, int Grade)
        {
            this.Execute = Execute;

            this.Grade = Grade;
        }
    }
}
