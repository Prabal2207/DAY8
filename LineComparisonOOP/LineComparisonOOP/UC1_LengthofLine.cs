using System;
namespace LineComparisonOOP
{
    public class UC1_LengthofLine
    {
        public  void Cal_length()
        {

            Console.WriteLine("Enter x1:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());

            Double formula = (x2 - x1) ^ 2 + (y2 - y1) ^ 2;
            Double Length_of_Line = Math.Sqrt(formula);

            Console.WriteLine("Length of line is:" + Length_of_Line);


        }
    }
}
