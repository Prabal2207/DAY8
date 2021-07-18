using System;
namespace LineComparisonOOP
{
    public class UC4_Compareto
    {
        Double[] result = new Double[3];

        public void Cal()
        {
            
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
        }

            public void compare()
            {
                if (result[1].CompareTo(result[2]) > 0)
                {
                    Console.WriteLine("length of line 1 is greater length of line 2");
                }
                else if (result[1].CompareTo(result[2]) < 0)
                {
                    Console.WriteLine("Length of line 1 is lesser Length of line 2");
                }
                else
                {
                    Console.WriteLine("Length of both line is equal.");
                }
            }

        
    }
}
