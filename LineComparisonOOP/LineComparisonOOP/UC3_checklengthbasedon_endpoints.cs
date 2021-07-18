using System;
namespace LineComparisonOOP
{
    public class UC3_checklengthbasedon_endpoints
    {
        public static void comparelength()
        {
            Double[] result = new Double[3];

            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("Enter detail of line:" + i);

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
                result[i] = Length_of_Line;


            }

            if (result[1] == result[2])
            {

                Console.WriteLine("line1 and line2 are equal");

            }

            else if (result[1] > result[2])
            {
                Console.WriteLine("line1 is greater than line2");
            }
            else
            {
                Console.WriteLine("line2 is greater than line1");
            }

        }
    }
}
