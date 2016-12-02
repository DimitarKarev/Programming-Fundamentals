using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = ReadRectangle();
            Rectangle rect2 = ReadRectangle();

            PrintOutput(rect1, rect2);
        }

        static Rectangle ReadRectangle()
        {
            int[] rectInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Rectangle rect = new Rectangle();
            rect.Left = rectInfo[0];
            rect.Top = rectInfo[1];
            rect.Width = rectInfo[2];
            rect.Height = rectInfo[3];
            return rect;
        }

        static void PrintOutput(Rectangle rect1, Rectangle rect2)
        {
            if (rect1.IsInside(rect2))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not Inside");
            }
        }

    }
    class Rectangle
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }

        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        public int CalcArea()
        {
            return Width * Height;
        }

        public bool IsInside(Rectangle rect)
        {
            return (rect.Left <= Left) && (rect.Right >= Right) &&
               (rect.Top <= Top) && (rect.Bottom >= Bottom);
        }

    }
}
