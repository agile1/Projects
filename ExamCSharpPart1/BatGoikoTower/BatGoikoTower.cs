using System;
class BatGoikoTower
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());//test
        int dotsBefore = height -1;
        int dotsInbetween = 0;
        for (int i = 0; i < height; i++)
        {
            Console.Write(new string ('.',dotsBefore));
            Console.Write(new string('/', 1));

            if (i == 1 || i == 3 || i == 6 || i == 10 || i == 15 || i == 21 || i == 28 || i == 36)
            {
                Console.Write(new string('-', dotsInbetween));
            }
            else
            {
                Console.Write(new string('.', dotsInbetween));
            }
            Console.Write(new string('\\', 1));
            Console.Write(new string('.', dotsBefore));
            Console.WriteLine();
            dotsBefore--;
            dotsInbetween += 2;
        }
    }
}


