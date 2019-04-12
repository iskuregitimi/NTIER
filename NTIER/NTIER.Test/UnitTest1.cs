using NTIER.BLL;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var sonuc=EmployeeBLL.GetEmployee(1);
        }
    }
}