namespace WyzwanieOczko
{
    internal class Employee
    {
        private List<int> score = new List<int>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.SurName = surname;
            this.Age = age;
        }

        public string Name { get; private set; }
        public string SurName { get; private set; }
        public int Age { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        public void AddScore(int punkt)
        {
            this.score.Add(punkt);
        }
    }


}
