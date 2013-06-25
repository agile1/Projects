using System;
using System.Numerics;
    class CardWars
    {
        static void Main()
        {
            byte numberOfGames = byte.Parse(Console.ReadLine());
            string cardDealt = "";
            int Player1Sum = 0;
            int player2Sum = 0;
            int player1CurrentHand = 0;
            int player2CurrentHand = 0;
            byte gamesWon1 = 0;
            byte gamesWon2 = 0;
            byte Zcard = 2;
            byte Ycard = 200;
            bool XcardPlayer1 = false;
            bool XcardPlayer2 = false;

            for (int i = 0; i < numberOfGames; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cardDealt = Console.ReadLine();
                    switch (cardDealt)
                    {
                        case "A": player1CurrentHand += 1; break;
                        case "K": player1CurrentHand += 13; break;
                        case "Q": player1CurrentHand += 12; break;
                        case "J": player1CurrentHand += 11; break;
                        case "2": player1CurrentHand += 10; break;
                        case "3": player1CurrentHand += 9; break;
                        case "4": player1CurrentHand += 8; break;
                        case "5": player1CurrentHand += 7; break;
                        case "6": player1CurrentHand += 6; break;
                        case "7": player1CurrentHand += 5; break;
                        case "8": player1CurrentHand += 4; break;
                        case "9": player1CurrentHand += 3; break;
                        case "10": player1CurrentHand += 2; break;
                        case "Z": Player1Sum *= Zcard; 
                            Zcard *= 2; break;
                        case "Y": Player1Sum -= Ycard;
                            Ycard += 200; break;
                        case "X": XcardPlayer1 =true; break;

                    }
                   Zcard = 2;
                   Ycard = 200;

                }


                for (int j = 0; j < 3; j++)
                {
                    cardDealt = Console.ReadLine();
                    switch (cardDealt)
                    {
                        case "A": player2CurrentHand += 1; break;
                        case "K": player2CurrentHand += 13; break;
                        case "Q": player2CurrentHand += 12; break;
                        case "J": player2CurrentHand += 11; break;
                        case "2": player2CurrentHand += 10; break;
                        case "3": player2CurrentHand += 9; break;
                        case "4": player2CurrentHand += 8; break;
                        case "5": player2CurrentHand += 7; break;
                        case "6": player2CurrentHand += 6; break;
                        case "7": player2CurrentHand += 5; break;
                        case "8": player2CurrentHand += 4; break;
                        case "9": player2CurrentHand += 3; break;
                        case "10": player2CurrentHand += 2; break;
                        case "Z": player2Sum *= Zcard;
                            Zcard *= 2; break;
                        case "Y": player2Sum -= Ycard; 
                            Ycard += 200; break;
                        case "X": XcardPlayer2 =true; break;
                    }
                    Zcard = 2;
                    Ycard = 200;
                }
                
                if (player1CurrentHand > player2CurrentHand)
                {
                    Player1Sum += player1CurrentHand;
                    gamesWon1++;
                }
                else if (player1CurrentHand < player2CurrentHand)
                {
                    player2Sum += player2CurrentHand;
                    gamesWon2++;
                }
                player1CurrentHand = 0;
                player2CurrentHand = 0;
            }
            if (XcardPlayer1 == true || XcardPlayer2 == true)
            {
                if ((XcardPlayer1 == true) && (XcardPlayer2 == false))
                {
                    Console.WriteLine("X card drawn! Player one wins the match!");
                }
                else if ((XcardPlayer1 == false) && (XcardPlayer2 == true))
                {
                    Console.WriteLine("X card drawn! Player two wins the match!");
                }
                else
                {
                    Player1Sum += 50;
                    player2Sum += 50;
                }
            }
            else if (Player1Sum > player2Sum)
            {
                Console.WriteLine("First player wins!");
                Console.WriteLine("Score: {0}", Player1Sum);
                Console.WriteLine("Games won: {0}", gamesWon1);
            }
            else if (Player1Sum < player2Sum)
            {
                Console.WriteLine("Second player wins!");
                Console.WriteLine("Score: {0}", player2Sum);
                Console.WriteLine("Games won: {0}", gamesWon2);
            }
            else 
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("Score: {0}", player2Sum);
            }
        }
    }

