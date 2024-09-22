namespace ArithmeticArchitect;

class Program
{
    static void Main(string[] args)
    {   
        
    }

    static double CalculateRectangleArea (double length, double width) {
        double rectangleArea = length * width;
        return rectangleArea;
    }
    static double CalculateCircleArea (double radius) {
        double circleArea = Math.PI * Math.Pow(radius,2);
        return circleArea;
    }
}
