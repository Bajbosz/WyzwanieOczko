using System.Reflection.Metadata;
using WyzwanieOczko;

namespace WyzwanieOczkoTests
{
    public class TypeTests
    {
        [Test]
        public void IntShouldBeEqual()
        {
            //arrange
            var number1 = 3;
            var number2 = 3;

            //assert

            Assert.AreEqual(number1, number2);

        }

        [Test]
        public void FloatShouldBeNotEqual()
        {
            //arrange
            var number1 = 3.33;
            var number2 = 4.12;

            //assert

            Assert.AreNotEqual(number1, number2);
        }


        [Test]
        public void SurnameShouldbyEqual()
        {
            //arrange
            var employee0 = GetEmployee("Błażej", "Nowak", 13);
            var employee1 = GetEmployee("Konrad", "Nowak", 15);

            //assert

            Assert.AreEqual(employee0.SurName, employee1.SurName);
        }

        [Test]
        public void NameShouldbyNotEqual()
        {
            //arrange
            var employee0 = GetEmployee("Błażej", "Nowak", 13);
            var employee1 = GetEmployee("Konrad", "Nowak", 15);

            //assert

            Assert.AreNotEqual(employee0.Name, employee1.Name);
        }

        [Test]
        public void ObjShouldbyNotEqual()
        {
            //arrange
            var employee0 = GetEmployee("Błażej", "Nowak", 13);
            var employee1 = GetEmployee("Konrad", "Nowak", 15);

            //assert

            Assert.AreNotEqual(employee0, employee1);
        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }

    }
}
