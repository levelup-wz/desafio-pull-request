using System;
class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        for (i = 0; i <= 100; i++)
        {
            if(i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine("\n Aperte enter para encerrar.");
        Console.ReadLine();

        /*int j = 0;
        while(j<100)
        {
            if (j % 2 != 0)
            {
                Console.WriteLine(j);
            }
            j=j+1;
        }*/
    }
}
