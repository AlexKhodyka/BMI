using System.Reflection.Metadata.Ecma335;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight, hight, BMI;
            Console.WriteLine("Syötä paino kilogrammoina : ");
            weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Syötä korkeus m:nä : ");
            hight = double.Parse(Console.ReadLine());

            BMI = weight / (hight * hight);
            Console.WriteLine("Sinun BMI on {0:f2}", BMI);

            if (BMI < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            if (BMI >= 18.5 && BMI < 25)
            {
                Console.WriteLine("Normal Weight");
            }
            if (BMI >= 25 && BMI < 30)
            {
                Console.WriteLine("Mildly Overweight");
            }
            if (BMI >= 30 && BMI < 35)
            {
                Console.WriteLine("Significantly Overweight");
            }
            if (BMI >= 35 && BMI < 40)
            {
                Console.WriteLine("Severely Overweight");
            }
            if (BMI > 40)
            {
                Console.WriteLine("Morbidly Overweight");
            }
        }
    }
}