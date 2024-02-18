using SharpLab.NullLab;

namespace LabTest.NullLab;

public class DigitComparatorTest
{
    [Test]
    public void CorrectNumberTest()
    {
        int number = 111;

        bool result = DigitComparator.Check(number);
        
        Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void IncorrectNumberTest()
    {
        int number = 123;
        
        bool result = DigitComparator.Check(number);
        
        Assert.That(result, Is.EqualTo(false));
    }
    
    [Test]
    public void SmallNumberTest()
    {
        int number = 11;

        Assert.Throws<ArgumentException>(() => DigitComparator.Check(number));
    }
    
    [Test]
    public void BigNumberTest()
    {
        int number = 1111;

        Assert.Throws<ArgumentException>(() => DigitComparator.Check(number));
    }
    
}