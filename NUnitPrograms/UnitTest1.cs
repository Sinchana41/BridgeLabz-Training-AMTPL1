using NUnit.Framework;

namespace CalculatorTests
{
    [TestFixture] //class contains multiple test cases
    class CalculatorTests
    {
        Calculator calc;

       [OneTimeSetUp]
        public void BeforeAll()
        {
            calc = new Calculator();
            Console.WriteLine("Before All");
        }

        [SetUp]
        public void BeforeEach()
        {
            Console.WriteLine("Before Each");
        }

       

        [Test]
        public void AddNumbers()
        {
            int result1 = calc.Add(2, 3);
            Assert.That( result1,Is.EqualTo(5));
        }

        [Test]
        public void SubNumbers()
        {
            int result2 = calc.Sub(5, 3);
            Assert.AreEqual(2, result2);//old method
        }

        [Test]
        public void MulNumbers()
        {
            int result3 = calc.Mul(2, 3);
            Assert.That(result3, Is.EqualTo(6));
        }

        [Test]
        public void DivNumbers()
        {
            int result4 = calc.Div(9, 3);
            Assert.That(result4, Is.EqualTo(3));
        }

        [Test]
        public void ModNumbers()
        {
            int result5 = calc.Mod(4, 3);
            Assert.That(result5, Is.EqualTo(1));
        }

        [TearDown]
        public void AfterEach()
        {
            Console.WriteLine("After Each");
        }

        [OneTimeTearDown]
        public void AfterAll()
        {
            Console.WriteLine("After All");
        }
    }
}

