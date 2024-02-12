using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

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
            if (punkt >=0 && punkt<=100)
            {
                this.score.Add(punkt);           
            }
            else 
            {
                throw new Exception("Wrong data");
            }
        }
        public void AddScore(string punkt)
        {
            if(float.TryParse(punkt,out float result))
            {
                this.AddScore(result);
            }
            else
            {
                throw new Exception("Wrong string");
            }
        }
        public void AddScore(int punkt)
        {
            this.AddScore((float)punkt);
        }
        public void AddScore(double punkt)
        {
            this.AddScore((float)punkt);
        }
        public void AddScore(long punkt)
        {
            this.AddScore((float)punkt);
        }
        public void AddScore(char punkt)
        {
            switch (punkt)
            {
                case 'A':
                case 'a':
                    this.score.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.score.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.score.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.score.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.score.Add(50);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
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
            switch(statistics.Avg)
            {
                case var avg when avg > 80:
                        statistics.AvgLetter = 'A';
                    break;
                case var avg when avg > 60:
                    statistics.AvgLetter = 'B';
                    break;
                case var avg when avg > 40:
                    statistics.AvgLetter = 'C';
                    break;
                case var avg when avg > 20:
                    statistics.AvgLetter = 'D';
                    break;
                default:
                    statistics.AvgLetter = 'E';
                    break;
            }
            return statistics;
        }
        public Statistics GetStatisticsFor()
        {
            var statistics = new Statistics();
            statistics.Avg = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            for (int i = 0; i < this.score.Count; i++)
            {
                statistics.Max = Math.Max(statistics.Max, this.score[i]);
                statistics.Min = Math.Min(statistics.Min, this.score[i]);
                statistics.Avg += this.score[i];
            }
            statistics.Avg /= this.score.Count;
            return statistics;
        }
        public Statistics GetStatisticsDoWhile()
        {
            var statistics = new Statistics();
            statistics.Avg = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var index = 0;
            do
            {
                statistics.Max = Math.Max(statistics.Max, this.score[index]);
                statistics.Min = Math.Min(statistics.Min, this.score[index]);
                statistics.Avg += this.score[index];
                index++;
            } while (index < this.score.Count);
            statistics.Avg /= this.score.Count;
            return statistics;
        }    
        public Statistics GetStatisticsWhile()
        {
            var statistics = new Statistics();
            statistics.Avg = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            var index = 0;
            while (index < this.score.Count) 
            {
                statistics.Max = Math.Max(statistics.Max, this.score[index]);
                statistics.Min = Math.Min(statistics.Min, this.score[index]);
                statistics.Avg += this.score[index];
                index++;
            }
            statistics.Avg /= this.score.Count;
            return statistics;
        }
    }
}

