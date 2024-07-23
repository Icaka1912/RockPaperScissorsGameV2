using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
namespace RockPaperScissorsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the name with which you will compete:");
            string playerName = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"Hello,{playerName}!");
            Console.WriteLine("");
            Console.WriteLine("Are you ready to engage in a tough battle with other rock,scissors,paper opponent to win ticket for the final match of Champions league?");
            Console.WriteLine("");
            Console.WriteLine("Write yes or no!");
            int resultPlayer = 0;
            int resultOtherPlayer = 0;
            string answer = Console.ReadLine();
            string rock = "";
            string scissors = "";
            string paper = "";
            Console.WriteLine("");

            if (answer == "yes")
            {
                Console.WriteLine("The game begins,but before that,the rules:");
                Console.WriteLine("There are 11 rounds,if you win a round you get 1 point and if you lose the other player get 1 point.You win the game if you have more points than the other player!Good luck!");
                Console.WriteLine("");
                Console.WriteLine("=========");
                Console.WriteLine("|Round 1|");
                Console.WriteLine("=========");
                Console.WriteLine("");
                Console.WriteLine("What do you choose :rock,scissors or paper?");
                Console.WriteLine("");
                string secondAsnwer = Console.ReadLine();
                Console.WriteLine($"You chose {secondAsnwer}!");

                if (secondAsnwer == "rock")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }

                }
                else if (secondAsnwer == "scissors")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }
                else if (secondAsnwer == "paper")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("=========");
                Console.WriteLine("|Round 2|");
                Console.WriteLine("=========");
                Console.WriteLine("");
                Console.WriteLine("What do you choose :rock,scissors or paper?");
                Console.WriteLine("");
                string thirdAsnwer = Console.ReadLine();
                Console.WriteLine($"You chose {thirdAsnwer}!");
                if (thirdAsnwer == "rock")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }

                }
                else if (thirdAsnwer == "scissors")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }
                else if (thirdAsnwer == "paper")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("=========");
                Console.WriteLine("|Round 3|");
                Console.WriteLine("=========");
                Console.WriteLine("");
                Console.WriteLine("What do you choose :rock,scissors or paper?");
                Console.WriteLine("");
                string fourthAsnwer = Console.ReadLine();
                Console.WriteLine($"You chose {fourthAsnwer}!");
                if (fourthAsnwer == "rock")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }

                }
                else if (fourthAsnwer == "scissors")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }
                else if (fourthAsnwer == "paper")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("=========");
                Console.WriteLine("|Round 4|");
                Console.WriteLine("=========");
                Console.WriteLine("");
                Console.WriteLine("What do you choose :rock,scissors or paper?");
                Console.WriteLine("");
                string fifthAsnwer = Console.ReadLine();
                Console.WriteLine($"You chose {fifthAsnwer}!");
                if (fifthAsnwer == "rock")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }

                }
                else if (fifthAsnwer == "scissors")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }
                else if (fifthAsnwer == "paper")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("=========");
                Console.WriteLine("|Round 5|");
                Console.WriteLine("=========");
                Console.WriteLine("");
                Console.WriteLine("What do you choose :rock,scissors or paper?");
                Console.WriteLine("");
                string sixthAsnwer = Console.ReadLine();
                Console.WriteLine($"You chose {sixthAsnwer}!");
                if (sixthAsnwer == "rock")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }

                }
                else if (sixthAsnwer == "scissors")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }
                else if (sixthAsnwer == "paper")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("=========");
                Console.WriteLine("|Round 6|");
                Console.WriteLine("=========");
                Console.WriteLine("");
                Console.WriteLine("What do you choose :rock,scissors or paper?");
                Console.WriteLine("");
                string seventhAsnwer = Console.ReadLine();
                Console.WriteLine($"You chose {seventhAsnwer}!");
                if (seventhAsnwer == "rock")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }

                }
                else if (seventhAsnwer == "scissors")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }
                else if (seventhAsnwer == "paper")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }

                }
                Console.WriteLine("");
                Console.WriteLine("=========");
                Console.WriteLine("|Round 7|");
                Console.WriteLine("=========");
                Console.WriteLine("");
                Console.WriteLine("What do you choose :rock,scissors or paper?");
                Console.WriteLine("");
                string eighthAsnwer = Console.ReadLine();
                Console.WriteLine($"You chose {eighthAsnwer}!");
                if (eighthAsnwer == "rock")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }

                }
                else if (eighthAsnwer == "scissors")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {

                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }
                else if (eighthAsnwer == "paper")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("=========");
                Console.WriteLine("|Round 8|");
                Console.WriteLine("=========");
                Console.WriteLine("");
                Console.WriteLine("What do you choose :rock,scissors or paper?");
                Console.WriteLine("");
                string ninthAsnwer = Console.ReadLine();
                Console.WriteLine($"You chose {ninthAsnwer}!");
                if (ninthAsnwer == "rock")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }

                }
                else if (ninthAsnwer == "scissors")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }
                else if (ninthAsnwer == "paper")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("=========");
                Console.WriteLine("|Round 9|");
                Console.WriteLine("=========");
                Console.WriteLine("");
                Console.WriteLine("What do you choose :rock,scissors or paper?");
                Console.WriteLine("");
                string tenthAsnwer = Console.ReadLine();
                Console.WriteLine($"You chose {tenthAsnwer}!");
                if (tenthAsnwer == "rock")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }

                }
                else if (tenthAsnwer == "scissors")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }
                else if (tenthAsnwer == "paper")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("=========");
                Console.WriteLine("|Round 10|");
                Console.WriteLine("=========");
                Console.WriteLine("");
                Console.WriteLine("What do you choose :rock,scissors or paper?");
                Console.WriteLine("");
                string eleventhAsnwer = Console.ReadLine();
                Console.WriteLine($"You chose {eleventhAsnwer}!");
                if (eleventhAsnwer == "rock")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }

                }
                else if (eleventhAsnwer == "scissors")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }
                else if (eleventhAsnwer == "paper")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("=========");
                Console.WriteLine("|Round 11|");
                Console.WriteLine("=========");
                Console.WriteLine("");
                Console.WriteLine("What do you choose :rock,scissors or paper?");
                Console.WriteLine("");
                string twelfthAsnwer = Console.ReadLine();
                Console.WriteLine($"You chose {twelfthAsnwer}!");
                if (twelfthAsnwer == "rock")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }

                }
                else if (twelfthAsnwer == "scissors")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }
                else if (twelfthAsnwer == "paper")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("=========");
                Console.WriteLine("|Round 12|");
                Console.WriteLine("=========");
                Console.WriteLine("");
                Console.WriteLine("What do you choose :rock,scissors or paper?");
                Console.WriteLine("");
                string thirteenthAsnwer = Console.ReadLine();
                Console.WriteLine($"You chose {thirteenthAsnwer}!");
                if (thirteenthAsnwer == "rock")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }

                }
                else if (thirteenthAsnwer == "scissors")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }
                else if (thirteenthAsnwer == "paper")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("=========");
                Console.WriteLine("|Round 13|");
                Console.WriteLine("=========");
                Console.WriteLine("");
                Console.WriteLine("What do you choose :rock,scissors or paper?");
                Console.WriteLine("");
                string fourteenthAsnwer = Console.ReadLine();
                Console.WriteLine($"You chose {fourteenthAsnwer}!");
                if (fourteenthAsnwer == "rock")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }

                }
                else if (fourteenthAsnwer == "scissors")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }
                else if (fourteenthAsnwer == "paper")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("=========");
                Console.WriteLine("|Round 14|");
                Console.WriteLine("=========");
                Console.WriteLine("");
                Console.WriteLine("What do you choose :rock,scissors or paper?");
                Console.WriteLine("");
                string fifteenthAsnwer = Console.ReadLine();
                Console.WriteLine($"You chose {fifteenthAsnwer}!");
                if (fifteenthAsnwer == "rock")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }

                }
                else if (fifteenthAsnwer == "scissors")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }
                else if (fifteenthAsnwer == "paper")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("=========");
                Console.WriteLine("|Round 15|");
                Console.WriteLine("=========");
                Console.WriteLine("");
                Console.WriteLine("What do you choose :rock,scissors or paper?");
                Console.WriteLine("");
                string sixteenthAsnwer = Console.ReadLine();
                Console.WriteLine($"You chose {sixteenthAsnwer}!");
                if (sixteenthAsnwer == "rock")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }

                }
                else if (sixteenthAsnwer == "scissors")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:paper!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }
                }
                else if (sixteenthAsnwer == "paper")
                {
                    int type = new Random().Next(1, 3);

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:rock!You win!You gain 1 point!");
                            Console.WriteLine("");
                            resultPlayer = resultPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Your opponent chose:scissors!You lose!You lose so your opponent gain 1 point!");
                            Console.WriteLine("");
                            resultOtherPlayer = resultOtherPlayer + 1;
                            Console.WriteLine($"{playerName}'s points are {resultPlayer}!");
                            Console.WriteLine($"Your opponent points are {resultOtherPlayer}!");
                            break;
                    }

                }
                if (resultPlayer > resultOtherPlayer)
                {
                    Console.WriteLine("");
                    Console.WriteLine("=====================================================================");
                    Console.WriteLine($"|The winner is {playerName}!|");
                    Console.WriteLine($"|{playerName} wins a ticket for the final match of Champions league 2025!|");
                    Console.WriteLine("=====================================================================");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("=================================================================================");
                    Console.WriteLine("|The winner is the other player!|");
                    Console.WriteLine("|The other player wins a ticket for the final match of Champions league 2025!|");
                    Console.WriteLine("=================================================================================");

                }

            }
            else
            {
                Console.WriteLine("You are a coward :D!Boo Boo Boo!!!");

            }
        }
    }
}
