﻿using System.Reflection.Metadata.Ecma335;

namespace WyzwanieOczko
{
    public class Employee
    {
        private List<float> score = new List<float>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.SurName = surname;
            this.Age = age;
        }

        public string Name { get; private set; }
        public string SurName { get; private set; }
        public int Age { get; private set; }

        public float Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        public void AddScore(float punkt)
        {
            this.score.Add(punkt);
        }
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Avg = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            foreach (var score in this.score) 
            {
                statistics.Max = Math.Max(statistics.Max, score);
                statistics.Min = Math.Min(statistics.Min, score);
                statistics.Avg += score;
            }
            statistics.Avg /= this.score.Count;
            return statistics;
        }
    }
}

