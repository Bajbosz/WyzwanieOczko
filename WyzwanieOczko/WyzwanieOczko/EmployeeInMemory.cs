namespace WyzwanieOczko
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> scorelist = new List<float>();
        public EmployeeInMemory(string name, string surname) 
            : base(name, surname)
        {
        }

        public override void AddScore(float score)
        {
            if (score >= 0 && score <= 100)
            {
                this.scorelist.Add(score);
            }
            else
            {
                throw new Exception("Wrong data");
            }
        }

        public override void AddScore(string score)
        {

            if (float.TryParse(score, out float result))
            {
                this.AddScore(result);
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
            var statistics = new Statistics();
            statistics.Avg = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            foreach (var score in this.scorelist)
            {
                statistics.Max = Math.Max(statistics.Max, score);
                statistics.Min = Math.Min(statistics.Min, score);
                statistics.Avg += score;
            }
            statistics.Avg /= this.scorelist.Count;
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
