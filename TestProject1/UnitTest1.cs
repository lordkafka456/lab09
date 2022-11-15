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
        [TestMethod]
        public void TestMethod2()
        {
            Student student = new Student();
            student.Score = 7;
            Assert.AreEqual('B', student.getLetterScore());

        }
        [TestMethod]
        public void TestMethod3()
        {
            Student student = new Student();
            student.Score = 5;
            Assert.AreEqual('C', student.getLetterScore());

        }
        [TestMethod]
        public void TestMethod4()
        {
            Student student = new Student();
            student.Score = 3;
            Assert.AreEqual('E', student.getLetterScore());

        }
        [TestMethod]
        public void TestService1()
        {
            StudentService studentService = new StudentService();
            Student student = new Student();
            student.Id = 1;
            Assert.IsTrue(studentService.addStudent(student));
            Student student2 = new Student();
            student2.Id = 1;
            Assert.IsFalse(studentService.addStudent(student2));
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestServiceException2()
        {
            StudentService studentService = new StudentService();
            Student student = null;
            studentService.addStudent(student);
        }
    }
}