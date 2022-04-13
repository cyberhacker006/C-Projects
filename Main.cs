using System;
using System.Threading;

namespace _29._11._21_minimalize
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(50, 2);
            Console.WriteLine("_______DEU GAME______");
            Console.SetCursorPosition(20, 5);
            Console.WriteLine("1 : PLAY");
            Console.SetCursorPosition(20, 6);
            Console.WriteLine("2 : EXIT");
            Console.Write(" ");
            int number = 3;
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("That choice is not in menu");
                Console.WriteLine("Please press any button to close the game");
                Console.ReadKey();
            }
            Console.ResetColor();
            Console.Clear();
            if (number == 1)
            {
                ConsoleKeyInfo cki;
                int cursorx = 6, cursory = 3;   // position of cursor               
                int ax = 13, ay = 20;    // delete X
                int adir = 1;            // direction of A:   1:rigth   -1:left
                int a = 0, b = 6;  //b: Setting the deletion cursor of 0s   //a: helping the keeping the values.
                int i1 = 0; // count numbers
                int column; //decide number where exist in each row
                int i9 = 1; // writing first screen numbers
                int i2 = 0;  // erasing the same numbers side by side in loops
                int counter = 0; //count the first screen numbers
                int score = 0;  //Player Score
                bool checking = false;
                // --- Static screen parts
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(5, 2);
                Console.WriteLine("+------------------------------+");
                for (int i = 0; i <= 2; i++)
                {
                    Console.SetCursorPosition(5, 3 + i);
                    Console.WriteLine("|                              |");
                }
                Console.SetCursorPosition(5, 6);
                Console.WriteLine("+------------------------------+");
                Console.ResetColor();
                // --- Main game loop
                int choose = 0, num = 0;
                int x = 6;
                int y = 3;
                int[] line1 = new int[30];
                int[] line2 = new int[30];
                int[] line3 = new int[30];
                while (i1 <= 29) //Desing the numbers
                {
                    Random random = new Random();
                    num = random.Next(1, 4);
                    column = random.Next(0, 30);
                    choose = random.Next(1, 4);
                    if (choose == 1)
                    {
                        if (line1[column] == 0)
                        {
                            line1[column] = num;
                            i1++;
                        }
                    }
                    if (choose == 2)
                    {
                        if (line2[column] == 0)
                        {
                            line2[column] = num;
                            i1++;
                        }
                    }
                    if (choose == 3)
                    {
                        if (line3[column] == 0)
                        {
                            line3[column] = num;
                            i1++;
                        }
                    }
                }
                Console.SetCursorPosition(6, 3); // Printing the numbers
                for (int j = 0; j < 30; j++)
                {
                    Console.Write(line1[j]);
                }
                Console.WriteLine();
                Console.SetCursorPosition(6, 4);
                for (int j = 0; j < 30; j++)
                {
                    Console.Write(line2[j]);
                }
                Console.WriteLine();
                Console.SetCursorPosition(6, 5);
                for (int j = 0; j < 30; j++)
                {
                    Console.Write(line3[j]);
                }
                for (int l = 0; l < 30; l++)   //delete zeros
                {
                    if (line1[l] == 0)
                    {
                        Console.SetCursorPosition(b, 3);
                        Console.Write(" ");
                    }
                    if (line2[l] == 0)
                    {
                        Console.SetCursorPosition(b, 4);
                        Console.Write(" ");
                    }
                    if (line3[l] == 0)
                    {
                        Console.SetCursorPosition(b, 5);
                        Console.Write(" ");
                    }
                    b = b + 1;
                }
                while (true)
                {

                    if (Console.KeyAvailable)
                    {       // true: there is a key in keyboard buffer
                        cki = Console.ReadKey(true);       // true: do not write character 

                        if (cki.Key == ConsoleKey.RightArrow && cursorx < 35)
                        {   // key and boundary control
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.WriteLine(" ");
                            cursorx += 1;
                        }
                        if (cki.Key == ConsoleKey.LeftArrow && cursorx > 6)
                        {
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.WriteLine(" ");
                            cursorx -= 1;
                        }
                        if (cki.Key == ConsoleKey.UpArrow && cursory > 3)
                        {
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.WriteLine(" ");
                            cursory--;
                        }
                        if (cki.Key == ConsoleKey.DownArrow && cursory < 5)
                        {
                            Console.SetCursorPosition(cursorx, cursory);
                            Console.WriteLine(" ");
                            cursory++;
                        }
                        if (cursorx > 6 && cursorx < 35) // W/A/S/D Movement
                        {
                            if (line1[cursorx - 5] == 0 && line1[cursorx - 7] == 0)
                            {
                                if (cki.Key == ConsoleKey.S)
                                {
                                    if (line1[(cursorx - 6)] != 0 && line2[(cursorx - 6)] == 0)
                                    {
                                        if (line1[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 3)
                                            {
                                                line1[(cursorx - 6)] = 0;
                                                line2[(cursorx - 6)] = 1;
                                            }

                                        }
                                        else if (line1[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 3)
                                            {
                                                line1[(cursorx - 6)] = 0;
                                                line2[(cursorx - 6)] = 2;
                                            }
                                        }
                                        else if (line1[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 3)
                                            {
                                                line1[(cursorx - 6)] = 0;
                                                line2[(cursorx - 6)] = 3;
                                            }
                                        }
                                    }
                                }
                                if (cki.Key == ConsoleKey.D)
                                {
                                    if (line1[(cursorx - 6)] != 0)
                                    {
                                        if (line1[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 3)
                                            {
                                                for (int i = (cursorx - 6); i <= 28; i++)
                                                {
                                                    if (line1[i + 1] == 0)
                                                    {
                                                        if (line1[i] == 1)
                                                        {
                                                            line1[i + 1] = 1;
                                                            line1[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line1[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 3)
                                            {
                                                for (int i = (cursorx - 6); i <= 28; i++)
                                                {
                                                    if (line1[i + 1] == 0)
                                                    {
                                                        if (line1[i] == 2)
                                                        {
                                                            line1[i + 1] = 2;
                                                            line1[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line1[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 3)
                                            {
                                                for (int i = (cursorx - 6); i <= 28; i++)
                                                {
                                                    if (line1[i + 1] == 0)
                                                    {
                                                        if (line1[i] == 3)
                                                        {
                                                            line1[i + 1] = 3;
                                                            line1[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                if (cki.Key == ConsoleKey.A)
                                {
                                    if (line1[(cursorx - 6)] != 0)
                                    {
                                        if (line1[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 3)
                                            {
                                                for (int i = (cursorx - 6); i > 0; i--)
                                                {
                                                    if (line1[i - 1] == 0)
                                                    {
                                                        if (line1[i] == 1)
                                                        {
                                                            line1[i - 1] = 1;
                                                            line1[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line1[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 3)
                                            {
                                                for (int i = (cursorx - 6); i > 0; i--)
                                                {
                                                    if (line1[i - 1] == 0)
                                                    {
                                                        if (line1[i] == 2)
                                                        {
                                                            line1[i - 1] = 2;
                                                            line1[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line1[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 3)
                                            {
                                                for (int i = (cursorx - 6); i > 0; i--)
                                                {
                                                    if (line1[i - 1] == 0)
                                                    {
                                                        if (line1[i] == 3)
                                                        {
                                                            line1[i - 1] = 3;
                                                            line1[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (cursorx == 6)
                        {
                            if (line1[cursorx - 5] == 0)
                            {
                                if (cki.Key == ConsoleKey.S)
                                {
                                    if (line1[(cursorx - 6)] != 0 && line2[(cursorx - 6)] == 0)
                                    {
                                        if (line1[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 3)
                                            {
                                                line1[(cursorx - 6)] = 0;
                                                line2[(cursorx - 6)] = 1;
                                            }

                                        }
                                        else if (line1[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 3)
                                            {
                                                line1[(cursorx - 6)] = 0;
                                                line2[(cursorx - 6)] = 2;
                                            }
                                        }
                                        else if (line1[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 3)
                                            {
                                                line1[(cursorx - 6)] = 0;
                                                line2[(cursorx - 6)] = 3;
                                            }
                                        }
                                    }
                                }
                                if (cki.Key == ConsoleKey.D)
                                {
                                    if (line1[(cursorx - 6)] != 0)
                                    {
                                        if (line1[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 3)
                                            {
                                                for (int i = (cursorx - 6); i <= 28; i++)
                                                {
                                                    if (line1[i + 1] == 0)
                                                    {
                                                        if (line1[i] == 1)
                                                        {
                                                            line1[i + 1] = 1;
                                                            line1[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line1[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 3)
                                            {
                                                for (int i = (cursorx - 6); i <= 28; i++)
                                                {
                                                    if (line1[i + 1] == 0)
                                                    {
                                                        if (line1[i] == 2)
                                                        {
                                                            line1[i + 1] = 2;
                                                            line1[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line1[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 3)
                                            {
                                                for (int i = (cursorx - 6); i <= 28; i++)
                                                {
                                                    if (line1[i + 1] == 0)
                                                    {
                                                        if (line1[i] == 3)
                                                        {
                                                            line1[i + 1] = 3;
                                                            line1[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                if (cki.Key == ConsoleKey.A)
                                {
                                    if (line1[(cursorx - 6)] != 0)
                                    {
                                        if (line1[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 3)
                                            {
                                                for (int i = (cursorx - 6); i > 0; i--)
                                                {
                                                    if (line1[i - 1] == 0)
                                                    {
                                                        if (line1[i] == 1)
                                                        {
                                                            line1[i - 1] = 1;
                                                            line1[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line1[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 3)
                                            {
                                                for (int i = (cursorx - 6); i > 0; i--)
                                                {
                                                    if (line1[i - 1] == 0)
                                                    {
                                                        if (line1[i] == 2)
                                                        {
                                                            line1[i - 1] = 2;
                                                            line1[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line1[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 3)
                                            {
                                                for (int i = (cursorx - 6); i > 0; i--)
                                                {
                                                    if (line1[i - 1] == 0)
                                                    {
                                                        if (line1[i] == 3)
                                                        {
                                                            line1[i - 1] = 3;
                                                            line1[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (cursorx == 35)
                        {
                            if (line1[cursorx - 7] == 0)
                            {
                                if (cki.Key == ConsoleKey.S)
                                {
                                    if (line1[(cursorx - 6)] != 0 && line2[(cursorx - 6)] == 0)
                                    {
                                        if (line1[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 3)
                                            {
                                                line1[(cursorx - 6)] = 0;
                                                line2[(cursorx - 6)] = 1;
                                            }

                                        }
                                        else if (line1[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 3)
                                            {
                                                line1[(cursorx - 6)] = 0;
                                                line2[(cursorx - 6)] = 2;
                                            }
                                        }
                                        else if (line1[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 3)
                                            {
                                                line1[(cursorx - 6)] = 0;
                                                line2[(cursorx - 6)] = 3;
                                            }
                                        }
                                    }
                                }
                                if (cki.Key == ConsoleKey.D)
                                {
                                    if (line1[(cursorx - 6)] != 0)
                                    {
                                        if (line1[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 3)
                                            {
                                                for (int i = (cursorx - 6); i <= 28; i++)
                                                {
                                                    if (line1[i + 1] == 0)
                                                    {
                                                        if (line1[i] == 1)
                                                        {
                                                            line1[i + 1] = 1;
                                                            line1[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line1[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 3)
                                            {
                                                for (int i = (cursorx - 6); i <= 28; i++)
                                                {
                                                    if (line1[i + 1] == 0)
                                                    {
                                                        if (line1[i] == 2)
                                                        {
                                                            line1[i + 1] = 2;
                                                            line1[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line1[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 3)
                                            {
                                                for (int i = (cursorx - 6); i <= 28; i++)
                                                {
                                                    if (line1[i + 1] == 0)
                                                    {
                                                        if (line1[i] == 3)
                                                        {
                                                            line1[i + 1] = 3;
                                                            line1[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                if (cki.Key == ConsoleKey.A)
                                {
                                    if (line1[(cursorx - 6)] != 0)
                                    {
                                        if (line1[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 3)
                                            {
                                                for (int i = (cursorx - 6); i > 0; i--)
                                                {
                                                    if (line1[i - 1] == 0)
                                                    {
                                                        if (line1[i] == 1)
                                                        {
                                                            line1[i - 1] = 1;
                                                            line1[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line1[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 3)
                                            {
                                                for (int i = (cursorx - 6); i > 0; i--)
                                                {
                                                    if (line1[i - 1] == 0)
                                                    {
                                                        if (line1[i] == 2)
                                                        {
                                                            line1[i - 1] = 2;
                                                            line1[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line1[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 3)
                                            {
                                                for (int i = (cursorx - 6); i > 0; i--)
                                                {
                                                    if (line1[i - 1] == 0)
                                                    {
                                                        if (line1[i] == 3)
                                                        {
                                                            line1[i - 1] = 3;
                                                            line1[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        //
                        if (cursorx < 35 && cursorx > 6)
                        {
                            if (line2[(cursorx - 7)] == 0 && line2[(cursorx - 5)] == 0)
                            {
                                if (cki.Key == ConsoleKey.W)
                                {
                                    if (line2[(cursorx - 6)] != 0 && line1[(cursorx - 6)] == 0)
                                    {
                                        if (line2[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 4)
                                            {
                                                line2[(cursorx - 6)] = 0;
                                                line1[(cursorx - 6)] = 1;
                                            }
                                        }
                                        else if (line2[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 4)
                                            {
                                                line2[(cursorx - 6)] = 0;
                                                line1[(cursorx - 6)] = 2;
                                            }
                                        }
                                        else if (line2[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 4)
                                            {
                                                line2[(cursorx - 6)] = 0;
                                                line1[(cursorx - 6)] = 3;
                                            }

                                        }
                                    }
                                }
                                if (cki.Key == ConsoleKey.S)
                                {
                                    if (line2[(cursorx - 6)] != 0 && line3[(cursorx - 6)] == 0)
                                    {
                                        if (line2[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 4)
                                            {
                                                line2[(cursorx - 6)] = 0;
                                                line3[(cursorx - 6)] = 1;
                                            }
                                        }
                                        else if (line2[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 4)
                                            {
                                                line2[(cursorx - 6)] = 0;
                                                line3[(cursorx - 6)] = 2;
                                            }
                                        }
                                        else if (line2[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 4)
                                            {
                                                line2[(cursorx - 6)] = 0;
                                                line3[(cursorx - 6)] = 3;
                                            }
                                        }
                                    }
                                }
                                if (cki.Key == ConsoleKey.D)
                                {
                                    if (line2[(cursorx - 6)] != 0)
                                    {
                                        if (line2[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 4)
                                            {
                                                for (int i = (cursorx - 6); i <= 28; i++)
                                                {
                                                    if (line2[i + 1] == 0)
                                                    {
                                                        if (line2[i] == 1)
                                                        {
                                                            line2[i + 1] = 1;
                                                            line2[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line2[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 4)
                                            {
                                                for (int i = (cursorx - 6); i <= 28; i++)
                                                {
                                                    if (line2[i + 1] == 0)
                                                    {
                                                        if (line2[i] == 2)
                                                        {
                                                            line2[i + 1] = 2;
                                                            line2[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line2[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 4)
                                            {
                                                for (int i = (cursorx - 6); i <= 28; i++)
                                                {
                                                    if (line2[i + 1] == 0)
                                                    {
                                                        if (line2[i] == 3)
                                                        {
                                                            line2[i + 1] = 3;
                                                            line2[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                if (cki.Key == ConsoleKey.A)
                                {
                                    if (line2[(cursorx - 6)] != 0)
                                    {
                                        if (line2[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 4)
                                            {
                                                for (int i = (cursorx - 6); i > 0; i--)
                                                {
                                                    if (line2[i - 1] == 0)
                                                    {
                                                        if (line2[i] == 1)
                                                        {
                                                            line2[i - 1] = 1;
                                                            line2[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line2[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 4)
                                            {
                                                for (int i = (cursorx - 6); i > 0; i--)
                                                {
                                                    if (line2[i - 1] == 0)
                                                    {
                                                        if (line2[i] == 2)
                                                        {
                                                            line2[i - 1] = 2;
                                                            line2[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line2[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 4)
                                            {
                                                for (int i = (cursorx - 6); i > 0; i--)
                                                {
                                                    if (line2[i - 1] == 0)
                                                    {
                                                        if (line2[i] == 3)
                                                        {
                                                            line2[i - 1] = 3;
                                                            line2[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }
                        else if (cursorx == 6)
                        {
                            if (line2[(cursorx - 5)] == 0)
                            {
                                if (cki.Key == ConsoleKey.W) // movement with w/s keys
                                {
                                    if (line2[(cursorx - 6)] != 0 && line1[(cursorx - 6)] == 0)
                                    {
                                        if (line2[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 4)
                                            {
                                                line2[(cursorx - 6)] = 0;
                                                line1[(cursorx - 6)] = 1;
                                            }
                                        }
                                        else if (line2[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 4)
                                            {
                                                line2[(cursorx - 6)] = 0;
                                                line1[(cursorx - 6)] = 2;
                                            }
                                        }
                                        else if (line2[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 4)
                                            {
                                                line2[(cursorx - 6)] = 0;
                                                line1[(cursorx - 6)] = 3;
                                            }

                                        }
                                    }
                                }
                                if (cki.Key == ConsoleKey.S)
                                {
                                    if (line2[(cursorx - 6)] != 0 && line3[(cursorx - 6)] == 0)
                                    {
                                        if (line2[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 4)
                                            {
                                                line2[(cursorx - 6)] = 0;
                                                line3[(cursorx - 6)] = 1;
                                            }
                                        }
                                        else if (line2[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 4)
                                            {
                                                line2[(cursorx - 6)] = 0;
                                                line3[(cursorx - 6)] = 2;
                                            }
                                        }
                                        else if (line2[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 4)
                                            {
                                                line2[(cursorx - 6)] = 0;
                                                line3[(cursorx - 6)] = 3;
                                            }
                                        }
                                    }
                                }
                                if (cki.Key == ConsoleKey.D)
                                {
                                    if (line2[(cursorx - 6)] != 0)
                                    {
                                        if (line2[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 4)
                                            {
                                                for (int i = (cursorx - 6); i <= 28; i++)
                                                {
                                                    if (line2[i + 1] == 0)
                                                    {
                                                        if (line2[i] == 1)
                                                        {
                                                            line2[i + 1] = 1;
                                                            line2[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line2[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 4)
                                            {
                                                for (int i = (cursorx - 6); i <= 28; i++)
                                                {
                                                    if (line2[i + 1] == 0)
                                                    {
                                                        if (line2[i] == 2)
                                                        {
                                                            line2[i + 1] = 2;
                                                            line2[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line2[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 4)
                                            {
                                                for (int i = (cursorx - 6); i <= 28; i++)
                                                {
                                                    if (line2[i + 1] == 0)
                                                    {
                                                        if (line2[i] == 3)
                                                        {
                                                            line2[i + 1] = 3;
                                                            line2[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                if (cki.Key == ConsoleKey.A)
                                {
                                    if (line2[(cursorx - 6)] != 0)
                                    {
                                        if (line2[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 4)
                                            {
                                                for (int i = (cursorx - 6); i > 0; i--)
                                                {
                                                    if (line2[i - 1] == 0)
                                                    {
                                                        if (line2[i] == 1)
                                                        {
                                                            line2[i - 1] = 1;
                                                            line2[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line2[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 4)
                                            {
                                                for (int i = (cursorx - 6); i > 0; i--)
                                                {
                                                    if (line2[i - 1] == 0)
                                                    {
                                                        if (line2[i] == 2)
                                                        {
                                                            line2[i - 1] = 2;
                                                            line2[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line2[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 4)
                                            {
                                                for (int i = (cursorx - 6); i > 0; i--)
                                                {
                                                    if (line2[i - 1] == 0)
                                                    {
                                                        if (line2[i] == 3)
                                                        {
                                                            line2[i - 1] = 3;
                                                            line2[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (cursorx == 35)
                        {
                            if (line2[(cursorx - 7)] == 0)
                            {
                                if (cki.Key == ConsoleKey.W) // movement with w/s keys
                                {
                                    if (line2[(cursorx - 6)] != 0 && line1[(cursorx - 6)] == 0)
                                    {
                                        if (line2[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 4)
                                            {
                                                line2[(cursorx - 6)] = 0;
                                                line1[(cursorx - 6)] = 1;
                                            }
                                        }
                                        else if (line2[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 4)
                                            {
                                                line2[(cursorx - 6)] = 0;
                                                line1[(cursorx - 6)] = 2;
                                            }
                                        }
                                        else if (line2[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 4)
                                            {
                                                line2[(cursorx - 6)] = 0;
                                                line1[(cursorx - 6)] = 3;
                                            }

                                        }
                                    }
                                }
                                if (cki.Key == ConsoleKey.S)
                                {
                                    if (line2[(cursorx - 6)] != 0 && line3[(cursorx - 6)] == 0)
                                    {
                                        if (line2[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 4)
                                            {
                                                line2[(cursorx - 6)] = 0;
                                                line3[(cursorx - 6)] = 1;
                                            }
                                        }
                                        else if (line2[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 4)
                                            {
                                                line2[(cursorx - 6)] = 0;
                                                line3[(cursorx - 6)] = 2;
                                            }
                                        }
                                        else if (line2[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 4)
                                            {
                                                line2[(cursorx - 6)] = 0;
                                                line3[(cursorx - 6)] = 3;
                                            }
                                        }
                                    }
                                }
                                if (cki.Key == ConsoleKey.D)
                                {
                                    if (line2[(cursorx - 6)] != 0)
                                    {
                                        if (line2[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 4)
                                            {
                                                for (int i = (cursorx - 6); i <= 28; i++)
                                                {
                                                    if (line2[i + 1] == 0)
                                                    {
                                                        if (line2[i] == 1)
                                                        {
                                                            line2[i + 1] = 1;
                                                            line2[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line2[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 4)
                                            {
                                                for (int i = (cursorx - 6); i <= 28; i++)
                                                {
                                                    if (line2[i + 1] == 0)
                                                    {
                                                        if (line2[i] == 2)
                                                        {
                                                            line2[i + 1] = 2;
                                                            line2[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line2[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 4)
                                            {
                                                for (int i = (cursorx - 6); i <= 28; i++)
                                                {
                                                    if (line2[i + 1] == 0)
                                                    {
                                                        if (line2[i] == 3)
                                                        {
                                                            line2[i + 1] = 3;
                                                            line2[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                if (cki.Key == ConsoleKey.A)
                                {
                                    if (line2[(cursorx - 6)] != 0)
                                    {
                                        if (line2[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 4)
                                            {
                                                for (int i = (cursorx - 6); i > 0; i--)
                                                {
                                                    if (line2[i - 1] == 0)
                                                    {
                                                        if (line2[i] == 1)
                                                        {
                                                            line2[i - 1] = 1;
                                                            line2[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line2[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 4)
                                            {
                                                for (int i = (cursorx - 6); i > 0; i--)
                                                {
                                                    if (line2[i - 1] == 0)
                                                    {
                                                        if (line2[i] == 2)
                                                        {
                                                            line2[i - 1] = 2;
                                                            line2[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line2[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 4)
                                            {
                                                for (int i = (cursorx - 6); i > 0; i--)
                                                {
                                                    if (line2[i - 1] == 0)
                                                    {
                                                        if (line2[i] == 3)
                                                        {
                                                            line2[i - 1] = 3;
                                                            line2[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (cursorx < 35 && cursorx > 6)
                        {
                            if (line3[(cursorx - 7)] == 0 && line3[(cursorx - 5)] == 0)
                            {
                                if (cki.Key == ConsoleKey.W)
                                {
                                    if (line3[(cursorx - 6)] != 0 && line2[(cursorx - 6)] == 0)
                                    {
                                        if (line3[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 5)
                                            {
                                                line3[(cursorx - 6)] = 0;
                                                line2[(cursorx - 6)] = 1;
                                            }

                                        }
                                        else if (line3[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 5)
                                            {
                                                line3[(cursorx - 6)] = 0;
                                                line2[(cursorx - 6)] = 2;
                                            }
                                        }
                                        else if (line3[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 5)
                                            {
                                                line3[(cursorx - 6)] = 0;
                                                line2[(cursorx - 6)] = 3;
                                            }
                                        }
                                    }
                                }
                                if (cki.Key == ConsoleKey.D)
                                {
                                    if (line3[(cursorx - 6)] != 0)
                                    {
                                        if (line3[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 5)
                                            {
                                                for (int i = (cursorx - 6); i <= 28; i++)
                                                {
                                                    if (line3[i + 1] == 0)
                                                    {
                                                        if (line3[i] == 1)
                                                        {
                                                            line3[i + 1] = 1;
                                                            line3[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line3[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 5)
                                            {
                                                for (int i = (cursorx - 6); i <= 28; i++)
                                                {
                                                    if (line3[i + 1] == 0)
                                                    {
                                                        if (line3[i] == 2)
                                                        {
                                                            line3[i + 1] = 2;
                                                            line3[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line3[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 5)
                                            {
                                                for (int i = (cursorx - 6); i <= 28; i++)
                                                {
                                                    if (line3[i + 1] == 0)
                                                    {
                                                        if (line3[i] == 3)
                                                        {
                                                            line3[i + 1] = 3;
                                                            line3[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                if (cki.Key == ConsoleKey.A)
                                {
                                    if (line3[(cursorx - 6)] != 0)
                                    {
                                        if (line3[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 5)
                                            {
                                                for (int i = (cursorx - 6); i > 0; i--)
                                                {
                                                    if (line3[i - 1] == 0)
                                                    {
                                                        if (line3[i] == 1)
                                                        {
                                                            line3[i - 1] = 1;
                                                            line3[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line3[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 5)
                                            {
                                                for (int i = (cursorx - 6); i > 0; i--)
                                                {
                                                    if (line3[i - 1] == 0)
                                                    {
                                                        if (line3[i] == 2)
                                                        {
                                                            line3[i - 1] = 2;
                                                            line3[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line3[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 5)
                                            {
                                                for (int i = (cursorx - 6); i > 0; i--)
                                                {
                                                    if (line3[i - 1] == 0)
                                                    {
                                                        if (line3[i] == 3)
                                                        {
                                                            line3[i - 1] = 3;
                                                            line3[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (cursorx == 35)
                        {
                            if (line3[(cursorx - 7)] == 0)
                            {
                                if (cki.Key == ConsoleKey.W)
                                {
                                    if (line3[(cursorx - 6)] != 0 && line2[(cursorx - 6)] == 0)
                                    {
                                        if (line3[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 5)
                                            {
                                                line3[(cursorx - 6)] = 0;
                                                line2[(cursorx - 6)] = 1;
                                            }

                                        }
                                        else if (line3[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 5)
                                            {
                                                line3[(cursorx - 6)] = 0;
                                                line2[(cursorx - 6)] = 2;
                                            }
                                        }
                                        else if (line3[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 5)
                                            {
                                                line3[(cursorx - 6)] = 0;
                                                line2[(cursorx - 6)] = 3;
                                            }
                                        }
                                    }
                                }
                                if (cki.Key == ConsoleKey.D)
                                {
                                    if (line3[(cursorx - 6)] != 0)
                                    {
                                        if (line3[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 5)
                                            {
                                                for (int i = (cursorx - 6); i <= 28; i++)
                                                {
                                                    if (line3[i + 1] == 0)
                                                    {
                                                        if (line3[i] == 1)
                                                        {
                                                            line3[i + 1] = 1;
                                                            line3[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line3[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 5)
                                            {
                                                for (int i = (cursorx - 6); i <= 28; i++)
                                                {
                                                    if (line3[i + 1] == 0)
                                                    {
                                                        if (line3[i] == 2)
                                                        {
                                                            line3[i + 1] = 2;
                                                            line3[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line3[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 5)
                                            {
                                                for (int i = (cursorx - 6); i <= 28; i++)
                                                {
                                                    if (line3[i + 1] == 0)
                                                    {
                                                        if (line3[i] == 3)
                                                        {
                                                            line3[i + 1] = 3;
                                                            line3[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                if (cki.Key == ConsoleKey.A)
                                {
                                    if (line3[(cursorx - 6)] != 0)
                                    {
                                        if (line3[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 5)
                                            {
                                                for (int i = (cursorx - 6); i > 0; i--)
                                                {
                                                    if (line3[i - 1] == 0)
                                                    {
                                                        if (line3[i] == 1)
                                                        {
                                                            line3[i - 1] = 1;
                                                            line3[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line3[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 5)
                                            {
                                                for (int i = (cursorx - 6); i > 0; i--)
                                                {
                                                    if (line3[i - 1] == 0)
                                                    {
                                                        if (line3[i] == 2)
                                                        {
                                                            line3[i - 1] = 2;
                                                            line3[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line3[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 5)
                                            {
                                                for (int i = (cursorx - 6); i > 0; i--)
                                                {
                                                    if (line3[i - 1] == 0)
                                                    {
                                                        if (line3[i] == 3)
                                                        {
                                                            line3[i - 1] = 3;
                                                            line3[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else if (cursorx == 6)
                        {
                            if (line3[(cursorx - 5)] == 0)
                            {
                                if (cki.Key == ConsoleKey.W)
                                {
                                    if (line3[(cursorx - 6)] != 0 && line2[(cursorx - 6)] == 0)
                                    {
                                        if (line3[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 5)
                                            {
                                                line3[(cursorx - 6)] = 0;
                                                line2[(cursorx - 6)] = 1;
                                            }

                                        }
                                        else if (line3[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 5)
                                            {
                                                line3[(cursorx - 6)] = 0;
                                                line2[(cursorx - 6)] = 2;
                                            }
                                        }
                                        else if (line3[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 5)
                                            {
                                                line3[(cursorx - 6)] = 0;
                                                line2[(cursorx - 6)] = 3;
                                            }
                                        }
                                    }
                                }
                                if (cki.Key == ConsoleKey.D) 
                                {
                                    if (line3[(cursorx - 6)] != 0)
                                    {
                                        if (line3[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 5)
                                            {
                                                for (int i = (cursorx - 6); i <= 28; i++)
                                                {
                                                    if (line3[i + 1] == 0)
                                                    {
                                                        if (line3[i] == 1)
                                                        {
                                                            line3[i + 1] = 1;
                                                            line3[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line3[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 5)
                                            {
                                                for (int i = (cursorx - 6); i <= 28; i++)
                                                {
                                                    if (line3[i + 1] == 0)
                                                    {
                                                        if (line3[i] == 2)
                                                        {
                                                            line3[i + 1] = 2;
                                                            line3[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line3[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 5)
                                            {
                                                for (int i = (cursorx - 6); i <= 28; i++)
                                                {
                                                    if (line3[i + 1] == 0)
                                                    {
                                                        if (line3[i] == 3)
                                                        {
                                                            line3[i + 1] = 3;
                                                            line3[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                if (cki.Key == ConsoleKey.A) // controling A function in line 3
                                {
                                    if (line3[(cursorx - 6)] != 0)
                                    {
                                        if (line3[(cursorx - 6)] == 1)
                                        {
                                            if (cursory == 5)
                                            {
                                                for (int i = (cursorx - 6); i > 0; i--)
                                                {
                                                    if (line3[i - 1] == 0)
                                                    {
                                                        if (line3[i] == 1)
                                                        {
                                                            line3[i - 1] = 1;
                                                            line3[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line3[(cursorx - 6)] == 2)
                                        {
                                            if (cursory == 5)
                                            {
                                                for (int i = (cursorx - 6); i > 0; i--)
                                                {
                                                    if (line3[i - 1] == 0)
                                                    {
                                                        if (line3[i] == 2)
                                                        {
                                                            line3[i - 1] = 2;
                                                            line3[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                        else if (line3[(cursorx - 6)] == 3)
                                        {
                                            if (cursory == 5)
                                            {
                                                for (int i = (cursorx - 6); i > 0; i--)
                                                {
                                                    if (line3[i - 1] == 0)
                                                    {
                                                        if (line3[i] == 3)
                                                        {
                                                            line3[i - 1] = 3;
                                                            line3[i] = 0;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (cki.Key == ConsoleKey.Escape)
                        {
                            return;
                        }
                        while (i1 <= 29) // Design the numbers
                        {
                            Random random = new Random();
                            num = random.Next(1, 4);
                            column = random.Next(0, 30);
                            choose = random.Next(1, 4);
                            if (choose == 1)
                            {
                                if (line1[column] == 0)
                                {
                                    line1[column] = num;
                                    i1++;
                                }
                            }
                            if (choose == 2)
                            {
                                if (line2[column] == 0)
                                {
                                    line2[column] = num;
                                    i1++;
                                }
                            }
                            if (choose == 3)
                            {
                                if (line3[column] == 0)
                                {
                                    line3[column] = num;
                                    i1++;
                                }
                            }
                        }
                        Console.SetCursorPosition(6, 3); // Printing the numbers
                        for (int j = 0; j < 30; j++)
                            Console.Write(line1[j]);
                        Console.WriteLine();
                        Console.SetCursorPosition(6, 4);
                        for (int j = 0; j < 30; j++)
                            Console.Write(line2[j]);
                        Console.WriteLine();
                        Console.SetCursorPosition(6, 5);
                        for (int j = 0; j < 30; j++)
                            Console.Write(line3[j]);
                    }
                    if (line1[a] == 1)    // Keeping the Values
                    {
                        if (x < 36)
                        {
                            Console.SetCursorPosition(x, y);
                            Console.WriteLine("1");
                        }
                    }
                    else if (line1[a] == 2)
                    {
                        if (x < 36)
                        {
                            Console.SetCursorPosition(x, y);
                            Console.WriteLine("2");
                        }
                    }
                    else if (line1[a] == 3)
                    {
                        if (x < 36)
                        {
                            Console.SetCursorPosition(x, y);
                            Console.WriteLine("3");
                        }
                    }
                    if (line2[a] == 1)
                    {
                        if (x < 36)
                        {
                            Console.SetCursorPosition(x, y + 1);
                            Console.WriteLine("1");
                        }
                    }
                    else if (line2[a] == 2)
                    {
                        if (x < 36)
                        {
                            Console.SetCursorPosition(x, y + 1);
                            Console.WriteLine("2");

                        }
                    }
                    else if (line2[a] == 3)
                    {
                        if (x < 36)
                        {
                            Console.SetCursorPosition(x, y + 1);
                            Console.WriteLine("3");
                        }
                    }
                    if (line3[a] == 1)
                    {
                        if (x < 36)
                        {
                            Console.SetCursorPosition(x, y + 2);
                            Console.WriteLine("1");
                        }
                    }
                    else if (line3[a] == 2)
                    {
                        if (x < 36)
                        {
                            Console.SetCursorPosition(x, y + 2);
                            Console.WriteLine("2");

                        }
                    }
                    else if (line3[a] == 3)
                    {
                        if (x < 36)
                        {
                            Console.SetCursorPosition(x, y + 2);
                            Console.WriteLine("3");
                        }
                    }
                    x += 1;
                    a++;
                    if (x > 35)
                    {
                        x = 6;
                    }
                    if (a > 29)
                    {
                        a = 0;
                    }
                    for (int i = 0; i < 29; i++)  //destroying the same numbers next to each other
                    {
                        if (line1[i] != 0 && line1[i + 1] != 0)
                        {
                            if (line1[i] == line1[i + 1])
                            {
                                line1[i] = 0;
                                line1[i + 1] = 0;
                                checking = true;
                                counter++;
                            }
                        }
                        if (line2[i] != 0 && line2[i + 1] != 0)
                        {
                            if (line2[i] == line2[i + 1])
                            {
                                line2[i] = 0;
                                line2[i + 1] = 0;
                                checking = true;
                                counter++;
                            }
                        }
                        if (line3[i] != 0 && line3[i + 1] != 0)
                        {
                            if (line3[i] == line3[i + 1])
                            {
                                line3[i] = 0;
                                line3[i + 1] = 0;
                                checking = true;
                                counter++;
                            }
                        }
                    }
                    while (2 * counter - 1 > i9)  //setting 30 number in first screen
                    {
                        Random random = new Random();
                        num = random.Next(1, 4);
                        column = random.Next(0, 30);
                        choose = random.Next(1, 4);
                        if (choose == 1)
                        {
                            if (line1[column] == 0)
                            {
                                line1[column] = num;
                                i9++;
                                Console.SetCursorPosition(column + 6, 3);
                                Console.WriteLine(num);
                                score += 10;
                            }
                        }
                        else if (choose == 2)
                        {
                            if (line2[column] == 0)
                            {
                                line2[column] = num;
                                i9++;
                                Console.SetCursorPosition(column + 6, 4);
                                Console.WriteLine(num);
                                score += 10;
                            }
                        }
                        else if (choose == 3)
                        {
                            if (line3[column] == 0)
                            {
                                line3[column] = num;
                                i9++;
                                Console.SetCursorPosition(column + 6, 5);
                                Console.WriteLine(num);
                                score += 10;
                            }
                        }
                    }
                    i9 = 999999999;
                    while (checking && i2 < 2)// if the same numbers come together they will be erased and placed two new number
                    {
                        Random random = new Random();
                        num = random.Next(1, 4);
                        column = random.Next(0, 30);
                        choose = random.Next(1, 4);
                        if (choose == 1)
                        {
                            if (line1[column] == 0)
                            {
                                line1[column] = num;
                                i2++;
                                Console.SetCursorPosition(column + 6, 3);
                                Console.WriteLine(num);
                                score += 10;
                            }
                        }
                        else if (choose == 2)
                        {
                            if (line2[column] == 0)
                            {
                                line2[column] = num;
                                i2++;
                                Console.SetCursorPosition(column + 6, 4);
                                Console.WriteLine(num);
                                score += 10;
                            }
                        }
                        else if (choose == 3)
                        {
                            if (line3[column] == 0)
                            {
                                line3[column] = num;
                                i2++;
                                Console.SetCursorPosition(column + 6, 5);
                                Console.WriteLine(num);
                                score += 10;
                            }
                        }
                    }
                    int b3 = 6;
                    for (int l = 0; l < 30; l++)   //delete zeros
                    {
                        if (line1[l] == 0)
                        {
                            Console.SetCursorPosition(b3, 3);
                            Console.Write(" ");
                        }
                        if (line2[l] == 0)
                        {
                            Console.SetCursorPosition(b3, 4);
                            Console.Write(" ");
                        }
                        if (line3[l] == 0)
                        {
                            Console.SetCursorPosition(b3, 5);
                            Console.Write(" ");
                        }
                        b3 = b3 + 1;
                    }
                    if (i2 >= 2)
                    {
                        i2 = 0;
                    }
                    checking = false;
                    Console.ForegroundColor = ConsoleColor.Blue; // this is for menu
                    Console.SetCursorPosition(53, 2);
                    Console.WriteLine("----------------------------------------");
                    Console.SetCursorPosition(53, 13);
                    Console.WriteLine("----------------------------------------");
                    for (int i = 3; i < 13; i++)
                    {
                        Console.SetCursorPosition(53, i);
                        Console.WriteLine("|                                      |");
                    }
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(65, 4);
                    Console.WriteLine("Score is : " + score);
                    Console.ResetColor();

                    if (adir == 1 && ax >= 60) adir = -1;    // change direction at boundaries
                    if (adir == -1 && ax <= 5) adir = 1;
                    Console.SetCursorPosition(ax, ay);    // delete old X
                    Console.WriteLine(" ");
                    ax = ax + adir; // updating the cursor place
                    Console.SetCursorPosition(cursorx, cursory);    // refresh X (current position)
                    Console.WriteLine("X");
                    Thread.Sleep(1);     // sleep 1 ms
                    if (score >= 1000) // Controling the score 
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.SetCursorPosition(55, 8);
                        Console.WriteLine("GAME IS OVER !!");
                        Console.SetCursorPosition(55, 9);
                        Console.WriteLine("You reached 1000 score and more.");
                        Console.SetCursorPosition(55, 10);
                        Console.WriteLine("Please press enter to close the game.");
                        Console.ResetColor();
                        Console.ReadLine();
                        break;
                    }
                }
            }
            else if (number == 2) // in the bginning of the game if the player choose 2 the game will be ended
            {
                Console.SetCursorPosition(10, 25);
                Console.WriteLine("EXIT");
            }
        }
    }
}


