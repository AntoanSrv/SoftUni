using System;

class PrintSequence
{
    static void Main()
    {
        Console.WriteLine("Displayed is the sequence of numbers between 2 and 12");

        for (int i = 2; i < 12; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + ", ");
            }

            else
            {
                Console.Write(-i + ", ");
            }
        }
    }
}
