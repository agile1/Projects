using System;
using System.Numerics;
    class SecretNumbers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            BigInteger number = BigInteger.Parse(input);
            number = BigInteger.Abs(number);
            input = input.TrimStart('-');
            int specialSum = 0;

            for (int i = 1; i <= input.Length; i++)
            {

                int position = input.Length - i +1;
                int currentnumber =  int.Parse(input[position-1].ToString());
                if ((i % 2) != 0)
                {
                    specialSum += currentnumber * i * i;
                }
                else
                {
                    specialSum += currentnumber * currentnumber * i;
                }
            }
            Console.WriteLine(specialSum);

            int lastdigit = specialSum % 10;         
            if (lastdigit == 0)
            {
                Console.Write("{0} has no secret alpha-sequence", number);
            }
            else
            {
                int letterSequence = specialSum % 26;
                string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                for (int i = 0; i < lastdigit; i++)
                {
                    if (letterSequence >= 26)
                    {
                        letterSequence -= 26;
                    }
                    Console.Write(alphabet[letterSequence]);
                    letterSequence++;
                }
            }
        }
    }

