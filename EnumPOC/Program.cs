namespace EnumPOC
{
    internal class Program
    {
        const int min_range = 0;
        const int max_range = 6;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day it was yesterday (in form of 0-6 according to ascending order): ");
            int day=Convert.ToInt32(Console.ReadLine());

            if (day >= min_range && day <= max_range)
            {
                int todayIndex = (day + (min_range+1)) % (max_range+1);
                Days today = (Days)todayIndex;
                Console.WriteLine("Today is: " + today);
            }
            else Console.WriteLine("Enter valid number");
        }
    }
    enum Days
    {
        Monday,
        Tuesday,
        Wednesday, 
        Thursday,
        Friday,
        Saturday, 
        Sunday
    }
}
