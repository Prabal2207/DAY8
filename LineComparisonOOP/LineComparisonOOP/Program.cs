using System;

namespace LineComparisonOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // UC1_LengthofLine obj = new UC1_LengthofLine();
            //UC2_Checktwolineequal.Checkequal();
            // UC3_checklengthbasedon_endpoints.comparelength();

            UC4_Compareto obj = new UC4_Compareto();
            obj.Cal();
            obj.compare();
            Console.ReadKey();




        }
    }
}
