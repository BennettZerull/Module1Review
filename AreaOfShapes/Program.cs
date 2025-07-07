namespace Module1Review
//created an application to find the area of different shapes
{
    public class AreaOfShapes
    {
        public static double AreaOfCircle()
        //created different methods to determine the area of different shapes
        {
            int radius = 4;
            //declared a integer for the radius
            int rSquared = radius * radius;
            //declared a integer for the radius squared
            double area = Math.PI * rSquared;
            //declared a double for the area of the circle
            Console.WriteLine("The area of circle is " + area);
            return area;
            //returned a value for the area of a circle
        } 
        static void Main(string[] args)
        //used main method to call the different shapes and their areas
        {
            AreaOfCircle();
        }
    }
}