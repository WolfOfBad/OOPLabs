namespace SharpLab.NullLab;

public class DigitComparator
{
    private DigitComparator()
    {
    }

    public static bool Check(int number)
    {
        if (number < 100 || number > 999)
        {
            throw new ArgumentException("Number must contain only 3 digits");
        }

        int first = number % 10;
        int second = number / 10 % 10;
        int third = number / 100;

        return first == second && second == third;
    }
    
}