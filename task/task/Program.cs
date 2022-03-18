using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {                                                    
            int key = 0;
            do
            {
                Console.WriteLine("enter the number");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("enter the side of the square");
                        int side = Convert.ToInt32(Console.ReadLine());
                        if (side < 0)
                        {
                            side = -side;
                        }
                        Square sq = new Square(side);
                        Console.WriteLine("1ci metod");
                        Console.WriteLine(sq.CalcArea());
                        break;
                    case 2:
                        Console.WriteLine("enter the width of the rectangle");
                        int width = Convert.ToInt32(Console.ReadLine());
                        if (width < 0)
                        {
                            width = -width;
                        }
                        Console.WriteLine("enter the length of the rectangle");
                        int length = Convert.ToInt32(Console.ReadLine());
                        if (length < 0)
                        {
                            length = -length;
                        }
                        Rectangular rect = new Rectangular(width,length);
                        Console.WriteLine("2ci metod");
                        Console.WriteLine(rect.CalcArea());                        
                        break;
                    case 0:
                        Console.WriteLine("0ci metod");
                        Console.WriteLine("Sagolun");
                        break;

                    default:
                        Console.WriteLine("bele bir secim yoxdur");
                        break;
                }
            } while (key!=0);

        }
        abstract class Figure
        {
            public abstract int CalcArea();
        }
        class Square : Figure
        {
            public int Side { get; set; }
            public Square(int side)
            {
                Side = side;
            }
            public override int CalcArea()
            {
                int S = Side * Side;
                return S; 
            }
        }
        class Rectangular:Figure
        {
            public int Width { get; set; }
            public int Length { get; set; }
            public Rectangular(int width, int length)
            {
                Width = width;
                Length = length;
            }
            public override int CalcArea()
            {
                int S = Width * Length;
                return S;
            }
        }
    }
}
