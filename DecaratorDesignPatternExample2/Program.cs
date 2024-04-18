using System;

namespace DecaratorDesignPatternExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle();

            IShape redCircle = new RedShapeDecorator(new Circle());
            IShape redRectangle = new RedShapeDecorator(new Rectangle());

            Console.WriteLine("Circle is normal border");
            circle.draw();

            Console.WriteLine("Circle of red border");
            redCircle.draw();

            Console.WriteLine("Rectangle of red border");
            redRectangle.draw();

            //Console.WriteLine("Hello World!");
        }
    }
}
