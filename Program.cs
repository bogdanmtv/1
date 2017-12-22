using System;

class Demo
{
    static void Main()
    {


        int[,] a = new int[5, 3];

        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                a[i, j] = random.Next(-100, 100);
                Console.WriteLine(a[i,j]);

            }
        }
        Console.WriteLine();
        foreach (int x in a)
        {
            


            if (x < 0)
            {
                Console.Write(x + " ");
            }
            
           
        }
        Console.Read();
    }
}
       
        
    



