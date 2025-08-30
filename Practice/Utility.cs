namespace practice;

public class Utility
{
    public static void doAreaOfTriangle(float tBase, float tHeight)
    {
        double area = (tBase * tHeight) / 2;
        Console.WriteLine("Area of Triangle is: " + area);
    }

    public static void doAreaOfCircle(float radius)
    {
        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine("Area of Circle is: " + area);
    }

    public static void doPerimeterOfCircle(float radius)
    {
        double perimeter = 2 * Math.PI * radius;
        Console.WriteLine("Perimeter of Circle is: " + perimeter);
    }

}