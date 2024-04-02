namespace LabTask18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 15, 250, 23, 457, 456, 321, 875, 246, 190, 234, 800, 9837, 12351 };

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= num1 && array[i] <= num2)
                {
                    int firstDig = array[i];
                    int sum = 0;
                    int lastDig = 0;
                    while (firstDig > 0)
                    {
                        lastDig = firstDig % 10;
                        firstDig = firstDig / 10;
                        sum += lastDig;
                    }
                    if (sum > 7)
                    {
                        Console.WriteLine(array[i]);
                    }
                }
            }
        }
    }
}
