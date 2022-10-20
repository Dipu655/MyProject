namespace EMEA_GOP
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("This is chandra");
        }
 
        [Test]
        public void Test1()
        {
            Console.WriteLine("Hi");
            Assert.Pass();
        }
    }
}