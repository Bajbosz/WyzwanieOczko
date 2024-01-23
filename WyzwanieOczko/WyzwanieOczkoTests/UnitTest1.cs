using WyzwanieOczko;

namespace WyzwanieOczkoTests
{
    public class Tests
    {
        [Test]
        public void ThreeNumberAdd_ReturnSum()
        {
            var employee = new Employee("", "", 12);
            employee.AddScore(3);
            employee.AddScore(-8);
            employee.AddScore(7);

            var result = employee.Result;

            Assert.AreEqual(2, result);
        }

    }
}