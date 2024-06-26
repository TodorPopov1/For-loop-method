namespace For_loop_method
{
    internal class Program
    {
        static void Main(string[] args)
        {


            static void Loop(int i, char k)
            {


                for (int n = i; n >= 0; n--)
                {

                    for (int j = 0; j <= n; j++)
                    {
                        Console.Write(k);
                    }
                    Console.WriteLine();
                }

            }


            Loop(6,'r');
        }
    }
}
/*
******
*****
****
***
**
*
*/