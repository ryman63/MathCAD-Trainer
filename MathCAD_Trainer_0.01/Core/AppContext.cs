using System;
using MathCAD_Trainer_0._01.MVVM.Model;
using System.Data.Entity;

namespace MathCAD_Trainer_0._01.Core
{
    class AppContext : DbContext
    {
        public DbSet<Test> Tests { get; set; }

        public AppContext() : base("DefaultConnection")
        {

        }
    }
}
