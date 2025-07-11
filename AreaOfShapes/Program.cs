namespace Module1Review
//created an application to find the area of different shapes
{
    public class AreaOfShapes
    {
        public static double AreaOfCircle()
        //created different methods to determine the area of different shapes
        {
            int radius = 4;
            //declared an integer for the radius
            int rSquared = radius * radius;
            //declared an integer for the radius squared
            double area = Math.PI * rSquared;
            //declared a double for the area of the circle
            Console.WriteLine("The area of circle is " + area);
            return area;
            //returned a value for the area of a circle
        }

        public static double AreaOfTriangle()
        {
            double triangleBase = 4;
            //declared the base of the triangle
            double triangleHeight = 4;
            //declared the height of a triangle
            double area = ((triangleHeight * triangleBase) / 2);
            //declared a formula for the area of a triangle
            Console.WriteLine("The area of a triangle is " + area);
            return area;
            //returned a value for the area of the triangle
        }

        public static double AreaOfRectangle()
        {
            double rectangleBase = 8;
            //declared the length of the base of the rectangle
            double rectangleHeight = 4;
            //declared the length of the height of the rectangle
            double area = (rectangleHeight * rectangleBase);
            //declared a formula for the area of a rectangle
            Console.WriteLine("The area of a rectangle is " + area);
            return area;
            //returned a value for the area of the rectangle
            //changed some values to make the areas different when called
        }

        public static double AreaOfSquare()
        {
            double sideLength = 4;
            //declared a value for the side length of the square, because this is a perfect square this is the only value you need
            double area = (sideLength * sideLength);
            //declared a formula for the area of a square
            Console.WriteLine("The area of a square is " + area);
            return area;
            //returned a value for the area of a square
        }
        static void Main(string[] args)
        //used main method to call the different shapes and their areas
        {
            AreaOfCircle();
            AreaOfTriangle();
            AreaOfRectangle();
            AreaOfSquare();
        }
    }
}