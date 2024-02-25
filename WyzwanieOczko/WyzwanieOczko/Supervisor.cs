namespace WyzwanieOczko
{
    public class Supervisor : IEmployee
    {
        public delegate void GradeAddedDelegate(object sennder, EventArgs args);


        private List<float> score = new List<float>();

        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.SurName = surname;
        }

       event EmployeeBase.GradeAddedDelegate IEmployee.GradeAdded
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        public string Name { get; private set; }
        public string SurName { get; private set; }
        public void AddScore(float punkt)
        {
            if (punkt >= 0 && punkt <= 100)
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
            switch (punkt)
            {
                case "6":
                    this.AddScore(100);
                    break;
                case "5":
                    this.AddScore(80);
                    break;
                case "-5":
                case "5-":
                    this.AddScore(75);
                    break;
                case "+5":
                case "5+":
                    this.AddScore(85);
                    break;
                case "4":
                    this.AddScore(60);
                    break;
                case "-4":
                case "4-":
                    this.AddScore(55);
                    break;
                case "+4":
                case "4+":
                    this.AddScore(65);
                    break;
                case "3":
                    this.AddScore(40);
                    break;
                case "-3":
                case "3-":
                    this.AddScore(35);
                    break;
                case "3+":
                case "+3":
                    this.AddScore(45);
                    break;
                case "2":
                    this.AddScore(20);
                    break;
                case "-2":
                case "2-":
                    this.AddScore(15);
                    break;
                case "2+":
                case "+2":
                    this.AddScore(25);
                    break;
                case "1":
                    this.AddScore(0);
                    break;
                case "1+":
                case "+1":
                    this.AddScore(5);
                    break;
                default:
                    throw new Exception("Wrong Letter");
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
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            foreach (var punkt in this.score);
            {
                throw new NotImplementedException();
            }
            return statistics;
        }
    }
}

