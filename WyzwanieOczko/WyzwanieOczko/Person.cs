namespace WyzwanieOczko
{
    public abstract class Person
    {
        public Person(string name, string surname, int age, char sex)
        {
            this.Name = name;
            this.SurName = surname;
            this.Age = age;
            this.Sex = sex;
        }
        public string Name { get; private set;}
        public string SurName { get; private set; }
        public int Age { get; private set; }
        public char Sex { get; private set;}
    }
}
