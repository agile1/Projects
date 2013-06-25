using System;
    class Garden
    {
        static void Main()
        {
            int tomatoes = int.Parse(Console.ReadLine());
            int tomatoesArea = int.Parse(Console.ReadLine());
            int cucumbers = int.Parse(Console.ReadLine());
            int cucumbersArea = int.Parse(Console.ReadLine());
            int potatoes = int.Parse(Console.ReadLine());
            int potatoesArea = int.Parse(Console.ReadLine());
            int carrots = int.Parse(Console.ReadLine());
            int carrotsArea = int.Parse(Console.ReadLine());
            int cabbage = int.Parse(Console.ReadLine());
            int cabbageArea = int.Parse(Console.ReadLine());
            int beansSeeds = int.Parse(Console.ReadLine());

            double tomatoPrice = 0.5;
            double cucumberPrice = 0.4;
            double potatoPrice = 0.25;
            double carrotPrice = 0.6;
            double cabbagePrice = 0.3;
            double beansPrice = 0.4;

            double totalPrice = 0;
            int totalArea = 0;


            totalPrice = (tomatoes * tomatoPrice) + (cucumbers * cucumberPrice) + (beansSeeds*beansPrice) +
                (potatoes * potatoPrice) + (carrots * carrotPrice) + (cabbage * cabbagePrice);
            
            totalArea = tomatoesArea + cucumbersArea + potatoesArea + carrotsArea + cabbageArea;
                        
            Console.WriteLine("Total costs: {0:0.00}",totalPrice);
            if (totalArea > 250)
            {
                Console.WriteLine("Insufficient area");
            }
            else if ((250 - totalArea) > 0)
            {
                Console.WriteLine("Beans area: {0}", 250 - totalArea);
            }
            else
            {
                Console.WriteLine("No area for beans");
            }
            
        }
    }

