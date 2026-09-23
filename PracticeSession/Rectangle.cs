public class Rectangle
{
    public double Width{get;init;}
    public double Height{get; init;}
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
    public double GetArea() => Width*Height;

    public double Perimeter => 2*(Width+Height);


}