using System;

namespace Chapter20_zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Define an abstract class Shape with abstract method CalculateSurface() and fields width and height.
            //Define two additional classes for a triangle and a rectangle, which implement CalculateSurface().
            //This method has to return the areas of the rectangle (height*width) and the triangle (height*width/2).
            //Define a class for a circle with an appropriate constructor, which initializes the two fields (height and width) with the same value (the radius) and implement
            //the abstract method for calculating the area.
            //Create an array of different shapes and calculate the area of each shape in another array.
            
            Console.WriteLine("Hello World!");

            Rectangle rect = new Rectangle(2,4);

            Console.WriteLine(rect.CalculateSurface());

            Triangle triang = new Triangle(4, 6);

            Console.WriteLine(triang.CalculateSurface());



            Console.ReadKey();
        }
    }
}
