namespace Max_Min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Task = { 5, 2, 7, 3, 9, 1, 8, 6, 4 };
            int min = Task[0];
            int max = Task[0];
            double sum = 0;

           
            foreach (int num in Task)
            {
                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
                sum += num;
            }

            double avg = sum / Task.Length;

           
            Console.WriteLine("Мінімум: " + min);
            Console.WriteLine("Максимум: " + max);
            Console.WriteLine("Середнє арифметичне: " + avg);
            Console.WriteLine("Сума: " + sum);
        }
    }
}