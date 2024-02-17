using System.Runtime.CompilerServices;

namespace WyzwanieOczko
{
    internal class EmployeeInFile : EmployeeBase
    {

        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }
        private const string fileName = "grade.txt";

        public override void AddScore(float score)
        {
            if (score >= 0 && score <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(score);
                }
            }
            else
            {
                throw new ArgumentException("Wrong data", nameof(score));
            }
        }

        public override void AddScore(string score)
        {
            if (float.TryParse(score, out float result))
            {
                {
                    this.AddScore(result);
                }
            }
            else
            {
                throw new Exception("Wrong string");
            }
        }

        public override void AddScore(int score)
        {
            this.AddScore((float)score);
        }

        public override void AddScore(double score)
        {
            this.AddScore((float)score);
        }

        public override void AddScore(long score)
        {
            this.AddScore((float)score);
        }

        public override void AddScore(char score)
        {
            switch (score)
            {
                case 'A':
                case 'a':
                    this.AddScore(100);
                    break;
                case 'B':
                case 'b':
                    this.AddScore(80);
                    break;
                case 'C':
                case 'c':
                    this.AddScore(60);
                    break;
                case 'D':
                case 'd':
                    this.AddScore(40);
                    break;
                case 'E':
                case 'e':
                    this.AddScore(50);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }

        public override Statistics GetStatistics()
        {
            var DataFromFile = this.ReadDataFromFile();
            var result = this.CountDataStatistics(DataFromFile);
            return result;
        }

        private List<float> ReadDataFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }

        private Statistics CountDataStatistics(List<float> grades)
        {
            var statistics = new Statistics();
            statistics.Avg = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            foreach (var grade in grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Avg += grade;
            }
            statistics.Avg /= grades.Count;
            switch (statistics.Avg)
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
    }
}