using System;

namespace PrintStar
{
    class Program
    {
        static void Main(string[] args)
        {
            String widthInput;
            double starWidth;

            Console.Write("Enter star width: ");
            widthInput = Console.ReadLine();
            starWidth = Convert.ToDouble(widthInput);
            Console.WriteLine("");
            Star(Convert.ToInt32(starWidth));
            Console.ReadKey();
        }

        public static void Star(int width)
        {
            //r = row
            //c = column
            int r, c;
            double totalRow;

            //check odd or even number width
            if (width % 2 == 0)
            {
                //+1 to round up if even number width
                width = width + 1;
            }

            //calculate total rows to print star
            totalRow = (((double)width) / 2) + 0.5;

            //print from maximum to minimum star
            for (r = (int)totalRow; r > 0; r--)
            {
                //print space before the star
                for (c = (width / 2) - r + 1; c > 0; c--)
                {
                    Console.Write(" ");
                }
                //odd number = 2n-1
                for (c = ((2 * r) - 1); c > 0; c--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            //start to print star from the row after the minimum star
            //r=1 to skip first row(minimum star), since it already printed
            for (r = 1; r < (int)totalRow; r++)
            {
                //print space before the star
                for (c = (width / 2) - r; c > 0; c--)
                {
                    Console.Write(" ");
                }
                //use even number formula, because r start from 1
                //even number = 2n
                for (c = 0; c <= ((2 * r)); c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}
