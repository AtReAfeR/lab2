namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            double sum = 0, highest = -1, lowest = 9999;

            Console.WriteLine("Enter grades (-1 to stop):");
            double grade = Convert.ToDouble(Console.ReadLine());

            while (grade != -1)
            {
                count++;
                sum += grade;
                if (grade > highest) highest = grade;
                if (grade < lowest) lowest = grade;

                grade = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine($"Count: {count}, Sum: {sum}, Avg: {sum / count}, High: {highest}, Low: {lowest}");

            Console.Write("\nEnter n (1-10): ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }
}