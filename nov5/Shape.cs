class Shape
{
   public string type;
   public string color;

   public Shape(string shapeType, string shapeColor)// constructor has the same name as the class and doesnt have a return type keyword
    {
        type = shapeType;
        color = shapeColor;
    }

   public void printPropertied()
    {
        Console.WriteLine($"Type: {type}. color: {color}");
    }

}