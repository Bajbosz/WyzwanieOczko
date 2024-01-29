
using WyzwanieOczko;

namespace WyzwanieOczkoTests
{
    public class EmployeeTests
    {
        [Test]
        public void MaxValueShouldBeEqual()
        {
            //arrange
            var employee = new Employee("Bartosz","",14);
            employee.AddScore(6);
            employee.AddScore(8);
            employee.AddScore(9);
            employee.AddScore(1);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(9, statistics.Max);
        }
        [Test]
        public void MinValueShouldBeEqual()
        {
            //arrange
            var employee = new Employee("Bartosz", "", 14);
            employee.AddScore(6);
            employee.AddScore(8);
            employee.AddScore(9);
            employee.AddScore(1);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(1, statistics.Min);
        }
        [Test]
        public void AvgValueShouldBeEqual()
        {
            //arrange
            var employee = new Employee("Bartosz", "", 14);
            employee.AddScore(6);
            employee.AddScore(8);
            employee.AddScore(9);
            employee.AddScore(1);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(6, statistics.Avg);
        }
        [Test]
        public void AvgLetterValueShouldBeEqual()
        {
            //arrange
            var employee = new Employee("Bartosz", "", 14);
            employee.AddScore(60);
            employee.AddScore(100);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual('B', statistics.AvgLetter);
        }
    }
}
