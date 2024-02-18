using SharpLab.NullLab;

namespace LabTest.NullLab;

public class RingCounterTest
{
    [Test]
    public void CountTest()
    {
        double innerRadius = 1;
        double externalRadius = 2;

        double area = RingCounter.CountRingArea(innerRadius, externalRadius);

        Assert.That(area, Is.EqualTo(Math.PI * 3));
    }

    [Test]
    public void NegativeInnerRadiusTest()
    {
        double innerRadius = -1;
        double externalRadius = 2;

        Assert.Throws<ArgumentException>(() => RingCounter.CountRingArea(innerRadius, externalRadius));
    }

    [Test]
    public void NegativeExternalRadiusTest()
    {
        double innerRadius = 1;
        double externalRadius = -2;

        Assert.Throws<ArgumentException>(() => RingCounter.CountRingArea(innerRadius, externalRadius));
    }

    [Test]
    public void WrongInternalExternalRadiusTest()
    {
        double innerRadius = 2;
        double externalRadius = 1;

        Assert.Throws<ArgumentException>(() => RingCounter.CountRingArea(innerRadius, externalRadius));
    }
}