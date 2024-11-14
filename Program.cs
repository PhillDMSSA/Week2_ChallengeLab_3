namespace Week2_ChallengeLab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int numLoop1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            int numLoop2 = Convert.ToInt32(Console.ReadLine());

            for (int i = numLoop2; i > 0; i--)
            {
                for (int j = 0; j < i; j++) 
                {
                    Console.Write(numLoop1); //ensure *Write()*
                }
                Console.WriteLine(); //moves to next line

            }
        }
    }
}
