namespace alqoritm_suali_16;
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, -1, -2, -3, 9, 10, -31 };
        for (int i = numbers.Length-1; i > 0; i--) 
        {
            if (numbers[i] > 0) 
              

            {
                Console.WriteLine(i);
                break;

            }



        }
      


    }
}

