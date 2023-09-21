using MethodNew.Assignments;
namespace TestProject1;


public class UnitTest1
{
    //[Fact]
    //public void Test1()
    //{ 
    //  string fname = "Thomas";
    //  string lname = "Payne";
    //  string expected = "Payne,Thomas";
    //  string actual= Assignment5.GetUserInputs(fname,lname);
    //  Assert.Equal(expected, actual);

    //}

    [Fact]
    public void Test1()
    {   
        string firstName= "nathaniel";
        string lastName = "haWthorNe";
        string expected = "#_Hawthorne,Nathaniel(HAWNAT)";
        string actual =MethodNew.Test.Formatter(firstName, lastName);
        Assert.Equal(expected,actual);
    }

    [Fact]
    public void Test2()
    {
        string firstName = "ELisabeth";
        string lastName = "GEorge";
        string expected = "#_George,Elisabeth(GEOELI)";
        string actual = MethodNew.Test.Formatter(firstName, lastName);
        Assert.Equal(expected, actual);
    }




}
