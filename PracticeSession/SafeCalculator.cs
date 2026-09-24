using System.Runtime.CompilerServices;

public static class SafeCalculator
{
    public static bool TrySquareRoot(double input, out double result)
    {
        if (input < 0)
        {
            result =0;
            return false;
        }
        else
        {
            result = Math.Sqrt(input);
            return true;

        }
    }
    public static bool TryParseAndMultiply(string s1, string s2, out int product)
    {
        
        if(int.TryParse(s1,out int num1) && int.TryParse(s2,out int num2))
        {
            product = num1*num2;
            return true;
        }
        else
        {
            product = 0;
            return false;
        }

    }
}