namespace Lab3_Exponents
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Learnin Maths!\n");
            while (true)
            {
                Console.WriteLine("Enter an integer: ");
                double eValue = double.Parse(Console.ReadLine());

                if (eValue <= 0 || 1301 <= eValue)
                {
                    Console.WriteLine("Please choose a number within the range of 1-1300");
                    continue;
                }

                GetExponent(eValue);
                if (Rerun() == false)
                {
                    break;
                }
            }

             static void GetExponent(double eValue)
            {
                for (double i = 1; i < eValue + 1; i++) {
                    double exponentx2 = Math.Pow(i, 2);
                    double exponentx3 = Math.Pow(i, 3);
                    Console.WriteLine(i + " " + exponentx2 + " " + exponentx3);
                }
            }
            static bool Rerun()
            {
                Console.WriteLine("Would you like to choose another number? y/n");
                string restart = Console.ReadLine().ToLower();
                if (restart == "y")
                {
                    return true;
                }
                else if (restart == "n")
                {
                    Console.WriteLine("Good Luck!");
                    return false;
                }
                else
                {
                    Console.WriteLine("I didn't understand that, please try again");
                    return Rerun();
                }
            }
        }
    }
}