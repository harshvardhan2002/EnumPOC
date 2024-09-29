namespace EnumPOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day it was yesterday (in form of 0-6 according to ascending order): ");
            int day=Convert.ToInt32(Console.ReadLine());

            if (day >= 0 && day <= 6)
            {
                int todayIndex = (day + 1) % 7;
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
