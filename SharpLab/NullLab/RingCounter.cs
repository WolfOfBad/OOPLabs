namespace SharpLab.NullLab;

public class RingCounter
{
    private RingCounter()
    {
    }

    private static double CountCircleArea(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentException("Circle can't have radius less than 0");
        }
        
        return Math.PI * radius * radius;
    }

    public static double CountRingArea(double innerRadius, double externalRadius)
    {
        double area = CountCircleArea(externalRadius) - CountCircleArea(innerRadius);

        if (area < 0)
        {
            throw new ArgumentException("Inner radius is greater than external");
        }
        
        return area;
    }
}