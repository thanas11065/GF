namespace Test;

public class UnitTest1
{
    [Fact]
    public void TestMoney()
    {
     double number = Program.ConvertStringToDouble("5120.25");

        Assert.Equal(number, 5120.25);
    }
    [Fact]
    public void TestNumber()
    {
     double number = Program.ConvertStringToDouble("64120501057");

        Assert.Equal(number, 64120501057);
    }

     [Fact]
    public void NumberTestConvertStringToDoubleIsInCorrect() 
    {
       Assert.Throws<Exception>(() => Program.ConvertStringToDouble("Sawadekrub"));
    }
    
    [Fact]
    public void RVTestConvertStringToDoubleIsInCorrect() 
    {
       Assert.Throws<Exception>(() => Program.ConvertStringToDoubleRV("Sawadekrub"));
    
    }
    
    [Fact]
    public void MoneyTestConvertStringToDoubleIsInCorrect() 
    {
       Assert.Throws<Exception>(() => Program.ConvertStringToDoubleM("Sawadekrub"));
    }
    
}