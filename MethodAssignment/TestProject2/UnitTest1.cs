using AssignmentMethod;
namespace TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string firstname = "Thomas";

            string lastname = "Payne";
            string expected = "Payne,Thomas";
            string actual=AssignmentMethod.Assignment5.GetUserInputs(firstname, lastname);
            Assert.Equal(expected, actual);
        }
    }
}