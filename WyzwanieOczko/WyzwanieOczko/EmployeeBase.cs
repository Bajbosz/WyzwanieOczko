﻿namespace WyzwanieOczko
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddedDelegate(object sennder, EventArgs args);

       public abstract event GradeAddedDelegate GradeAdded;
        public EmployeeBase(string name, string surname) 
        {
            this.Name = name;
            this.SurName = surname;
        }

        public string Name { get; private set; }
        public string SurName { get; private set; }
        public abstract void AddScore(float score);
        public abstract void AddScore(string score);
        public abstract void AddScore(int score);
        public abstract void AddScore(double score);
        public abstract void AddScore(long score);
        public abstract void AddScore(char score);
        public abstract Statistics GetStatistics();
    }
}
