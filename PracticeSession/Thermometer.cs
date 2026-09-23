public class Thermometer
{
    private double _celsius;
    public double Celsius
    {
        get=> _celsius;
        set
        {
            if (value < -273.15)
            {
                throw new ArgumentOutOfRangeException(nameof(value),"Invalid temp value");

            }
            _celsius = value;
        }

        
    }

    public double Fahrenheit{
        get
        {
            return (Celsius * 9/5)+32;
        }
    } 

    

    public Thermometer(double celsius)
    {
        Celsius = celsius;
    
    }
}