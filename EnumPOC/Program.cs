namespace EnumPOC
{
    internal class Program
    {
        const int MIN_RANGE = 0;
        const int MAX_RANGE = 6;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day it was yesterday (in form of 0-6 according to ascending order): ");
            int day=Convert.ToInt32(Console.ReadLine());

            if (day >= MIN_RANGE && day <= MAX_RANGE)
            {
                int todayIndex = (day + (MIN_RANGE+1)) % (MAX_RANGE+1);
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
