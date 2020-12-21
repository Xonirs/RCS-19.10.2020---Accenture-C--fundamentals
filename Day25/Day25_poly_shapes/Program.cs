using System;
using System.Collections.Generic;

namespace Day25_poly_shapes
{
    class DrawingShape
    {
        public virtual void Draw() { Console.WriteLine("I'm just a generic drawing object"); }
    }
    class Line : DrawingShape
    {
        public override void Draw() { Console.WriteLine("I'm just a line"); }
    }
    class Circle : DrawingShape
    {
        public override void Draw() { Console.WriteLine("I'm just a circle"); }
    }
    class Square : DrawingShape
    {
        public override void Draw() { Console.WriteLine("I'm just a square"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<DrawingShape> shapes = new List<DrawingShape>();
            DrawingShape myShape = new Square();
            DoDraw(myShape);
            Console.WriteLine();
            shapes.Add(myShape);
            shapes.Add(new Line());
            shapes.Add(new Circle());
            shapes.Add(new Square());
            shapes.Add(new DrawingShape());

            foreach (DrawingShape shape in shapes)
            {
                shape.Draw();
            }
        }

        static void DoDraw(DrawingShape shape)
        {
            shape.Draw();
        }
    }
}
