using StudentServiceLib;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Student student = new Student();
            student.Score = 8;
            Assert.AreEqual('A', student.getLetterScore());

        }
    }
}