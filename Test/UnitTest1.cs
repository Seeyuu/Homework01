namespace Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        double number = Program.ConvertStringToDouble("5120");
            
            Assert.Equal(number, 5120);
    }
}