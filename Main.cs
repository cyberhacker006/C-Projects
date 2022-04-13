using System;

namespace Word_World3
{
    class Program
    {
        static void Main(string[] args)
        {
            int word_firstletter = 0; // used to compare pattern and text first letters in every word
            int lastloop = 0; // used for forth loop to compare and finding strings words and loop restrictions
            int middleloop = 0; // used for second and third loop to compare and finding strings words and loop restrictions
            int counter = 0;  // used for determine how many letters will be printed in the third loop
            int control1 = 0; // used for controls
            int control2 = 0; // used for controls
            int counter2 = 1; // this counter  helps to restric and determining loop in the fouth loop
            int value = 0; // this value helps to getting last letter in the word for last loop
            while (true) // used for turn begginning in every warning 
            {
                bool flag = true;
                Console.Write("Please enter a text : ");
                string text = Console.ReadLine();
                Console.Write("Please enter the pattern : ");
                string pattern = Console.ReadLine();
                text = text.Replace(",", ""); // erasing punctiontonal word in the text
                text = text.Replace(".", "");
                string[] wordlist = text.Split(' '); // it is used for if the user enter only '*' in the pattern
                string upper_text = text.ToUpper(); // this is for compering pattern and text correctly
                string upper_pattern = pattern.ToUpper(); // this is for compering pattern and text correctly
                string[] your_text = new string[upper_text.Length]; // it is used for if the word correct and fit in all conditions the word will be put inside this variable and it will be printed
                upper_text = upper_text.Replace("I", "İ");// editing string characters 
                upper_pattern = upper_pattern.Replace("I", "İ");
                if (text.Length == 0) // controling part for text
                {
                    Console.WriteLine("Please enter a text.");
                    Console.ReadKey();
                    Console.Clear();
                    flag = false;
                }
                else if (pattern.Length == 0)// controling part for pattern
                {
                    Console.WriteLine("Please enter a pattern.");
                    Console.ReadKey();
                    Console.Clear();
                    flag = false;
                }
                for (int i = 0; i < text.Length; i++) // this control erase one space if comes on after another
                {
                    if (text[i] == ' ' && text[i + 1] == ' ')
                    {
                        text = text.Remove(i, 1);
                        upper_text = upper_text.Remove(i, 1);
                    }
                    if (text[i] == 'a' || text[i] == 'A' || text[i] == 'B' || text[i] == 'b' || text[i] == 'C' || text[i] == 'c' || text[i] == 'D' || text[i] == 'T' || text[i] == 't'
                        || text[i] == 'd' || text[i] == 'E' || text[i] == 'e' || text[i] == 'F' || text[i] == 'f' || text[i] == 'G' || text[i] == 'g' || text[i] == 'H'
                         || text[i] == 'h' || text[i] == 'I' || text[i] == 'i' || text[i] == 'J' || text[i] == 'j' || text[i] == 'K' || text[i] == 'k' || text[i] == 'L'
                         || text[i] == 'l' || text[i] == 'M' || text[i] == 'm' || text[i] == 'N' || text[i] == 'n' || text[i] == 'O' || text[i] == 'o' || text[i] == 'P'
                         || text[i] == 'p' || text[i] == 'Q' || text[i] == 'q' || text[i] == 'R' || text[i] == 'r' || text[i] == 'S' || text[i] == 's' || text[i] == 'U'
                          || text[i] == 'u' || text[i] == 'V' || text[i] == 'v' || text[i] == 'W' || text[i] == 'w' || text[i] == 'X' || text[i] == 'x' || text[i] == 'Y'
                          || text[i] == 'y' || text[i] == 'Z' || text[i] == 'z' || text[i] == ',' || text[i] == '.' || text[i] == ' ')
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Please enter only english characters and '.' or ','.");
                        Console.ReadKey();
                        Console.Clear();
                        flag = false;
                        break;
                    }
                }
                for (int i = 0; i < pattern.Length; i++) // controling part for using punctuational words
                {
                    if (pattern[i] == 'a' || pattern[i] == 'A' || pattern[i] == 'B' || pattern[i] == 'b' || pattern[i] == 'C' || pattern[i] == 'c' || pattern[i] == 'D' || text[i] == 'T' || text[i] == 't'
                        || pattern[i] == 'd' || pattern[i] == 'E' || pattern[i] == 'e' || pattern[i] == 'F' || pattern[i] == 'f' || pattern[i] == 'G' || pattern[i] == 'g' || pattern[i] == 'H'
                         || pattern[i] == 'h' || pattern[i] == 'I' || pattern[i] == 'i' || pattern[i] == 'J' || pattern[i] == 'j' || pattern[i] == 'K' || pattern[i] == 'k' || pattern[i] == 'L'
                         || pattern[i] == 'l' || pattern[i] == 'M' || pattern[i] == 'm' || pattern[i] == 'N' || pattern[i] == 'n' || pattern[i] == 'O' || pattern[i] == 'o' || pattern[i] == 'P'
                         || pattern[i] == 'p' || pattern[i] == 'Q' || pattern[i] == 'q' || pattern[i] == 'R' || pattern[i] == 'r' || pattern[i] == 'S' || pattern[i] == 's' || pattern[i] == 'U'
                          || pattern[i] == 'u' || pattern[i] == 'V' || pattern[i] == 'v' || pattern[i] == 'W' || pattern[i] == 'w' || pattern[i] == 'X' || pattern[i] == 'x' || pattern[i] == 'Y'
                          || pattern[i] == 'y' || pattern[i] == 'Z' || pattern[i] == 'z' || pattern[i] == '*' || pattern[i] == '-')
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Please enter only english characters and '*' or '-'.");
                        Console.ReadKey();
                        Console.Clear();
                        flag = false;
                        break;
                    }
                    if (pattern[i] == '*')
                    {
                        control1 += 1;
                    }
                    else if (pattern[i] == '-')
                    {
                        control2 += 1;
                    }
                    if (control1 != 0 && control2 != 0)
                    {
                        Console.WriteLine("Please enter only one type punctuational word '-' or '*'.");
                        Console.ReadKey();
                        Console.Clear();
                        flag = false;
                        break;
                    }
                }
                while (flag) 
                {
                    for (int i = 0; i < upper_text.Length; i++) // this loop for '-' 
                    {
                        if (upper_text[i] == ' ') // when the loop comes space it start to control word one by one
                        {
                            for (int p = 0; p < upper_pattern.Length; p++) // restriction loop with pattern lenght
                            {
                                if (upper_pattern[p] == '-') // when the loop fing a '-' it get letters in the index which we come
                                {
                                    your_text[p] = Convert.ToString(text[i + 1 + p]);
                                }
                                else if (upper_pattern[p] != '-' && upper_pattern[p] == upper_text[i + 1 + p]) // when the loop don't find '-' compares the pattern and text letters if it is same we will add the letter in a variable
                                {
                                    your_text[p] = Convert.ToString(text[i + 1 + p]);
                                }
                                else if (upper_pattern[p] != '-' && upper_pattern[p] != upper_text[i + 1 + p]) // when the loop don't find '-' compares the pattern and text letters if it is not same the loop will be ended
                                {
                                    break;
                                }
                                if (p == upper_pattern.Length - 1 && upper_text[i + 2 + p] != ' ') // when the pattern completed but if the text not complete loop will be ended and the word changes 
                                {
                                    break;
                                }
                                else if (p != upper_pattern.Length - 1 && upper_text[i + 2 + p] == ' ') // if the word changes while the pattern is not complete the loop will be ended and the word changes
                                {
                                    break;
                                }
                                if (upper_text[i + p + 2] == ' ') // if the all stuations are correct the word will be print
                                {
                                    Console.WriteLine();
                                    for (int i2 = 0; i2 < your_text.Length; i2++)
                                    {
                                        Console.Write(your_text[i2]);
                                    }
                                    break;
                                }
                            }
                        }
                    }

                    for (int i = 0; i < upper_text.Length; i++) // this loop for '*' if the '*' is only at the end or in the beginning of the pattern
                    {
                        middleloop = 0;
                        if (upper_text[i] == ' ') // when the loop comes space it start to control word one by one
                        {
                            while (middleloop < upper_pattern.Length) // restriction loop with pattern lenght
                            {
                                if (upper_pattern[middleloop] == '*' && upper_pattern.Length == 1) // when the loop fing a '*' it get letters in the index which we come if '*' is the only character of the pattern
                                {
                                    Console.WriteLine();
                                    for (int i2 = 0; i2 < wordlist.Length; i2++)
                                    {
                                        Console.WriteLine(wordlist[i2]);
                                    }
                                    return;
                                }
                                else if (upper_pattern[middleloop] != '*' && upper_pattern[middleloop] == upper_text[i + 1 + middleloop]) // when the loop don't find '*' compares the pattern and text letters if it is same we will add the letter in a variable
                                {
                                    wordlist[middleloop] = Convert.ToString(text[i + 1 + middleloop]);
                                    middleloop++;
                                }
                                else if (upper_pattern[middleloop] == '*' && upper_pattern.Length - 1 == upper_pattern.IndexOf('*')) // when the loop fing a '*' it get letters in the index which if the '*' exist at the beginning or end
                                {
                                    for (int i2 = middleloop; i2 < upper_text.Length - (i + 1 + i2); i2++) // when the loop fing a '*' it get letters in the index which after '*' or before
                                    {
                                        if (upper_text[i + 1 + i2 - middleloop] == ' ')
                                        {
                                            if (upper_pattern[middleloop] != '*')
                                            {
                                                for (int iz = 0; iz < upper_pattern.Length - 1; iz++)
                                                {
                                                    your_text[middleloop] = Convert.ToString(text[i + 1 + middleloop]);
                                                }
                                            }
                                            your_text[i2] = Convert.ToString(text[i + i2 - middleloop]);
                                            Console.WriteLine();
                                            for (int ic = 0; ic < upper_text.Length; ic++)
                                            {
                                                Console.Write(your_text[ic]);
                                            }
                                            middleloop++;
                                            break;
                                        }
                                        your_text[i2] = Convert.ToString(text[i + i2 - middleloop]);
                                    }
                                }
                                else if (upper_pattern[middleloop] != '*' && upper_pattern[middleloop] != upper_text[i + 1 + middleloop])// when the loop don't find '*' compares the pattern and text letters if it is not same the loop will be ended
                                {
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                                if (upper_text[i + middleloop + 2] == ' ') // if the all conditions correct at the end of the word the variable will be printed
                                {
                                    Console.WriteLine();
                                    for (int i2 = 0; i2 < upper_text.Length; i2++)
                                    {
                                        Console.Write(your_text[i2]);
                                    }

                                    break;
                                }
                            }
                        }
                        for (int ix = 0; ix < upper_text.Length; ix++) // when the loop ends the variable have to be empty for another word
                        {
                            your_text[ix] = " ";
                        }
                    }

                    for (int i = 0; i < upper_text.Length; i++)  // this loop for '*' if the '*' is in the middle of the pattern
                    {
                        middleloop = 0;
                        if (upper_text[i] == ' ') // when the loop comes space it start to control word one by one
                        {
                            if (upper_pattern.Length != 1 && upper_pattern[0] == '*') // when the loop fing a '*' it get letters in the index which after '*' or before
                            {
                                for (int ip = 0; ip < upper_text.Length; ip++)
                                {
                                    if ((i + 1 + ip) >= upper_text.Length)
                                    {
                                        break;
                                    }
                                    if (upper_text[i + 1 + ip] == ' ')
                                    {
                                        middleloop++;
                                        for (int o = 1; o <= pattern.Length - 1; o++) // this loop for controling each letter on the word
                                        {
                                            if (upper_pattern[upper_pattern.Length - o] == upper_text[i + ip - o + 1])
                                            {
                                                counter2++;
                                                if (o == pattern.Length - 1 && counter2 == pattern.Length) // if the all condoitions are true the wprd will be prrinted
                                                {
                                                    Console.WriteLine();
                                                    for (int ic = 0; ic < counter; ic++)
                                                    {
                                                        Console.Write(your_text[ic]);
                                                    }
                                                }
                                            }
                                            else if (upper_pattern[upper_pattern.Length - o] != upper_text[i + ip - o + 1])
                                            {
                                                counter2 = 1;
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                    counter++;
                                    your_text[ip] = Convert.ToString(text[i + ip + 1]);
                                }
                            }
                            else if (middleloop != upper_pattern.Length - 1 && upper_text[i + 2 + middleloop] == ' ') // when the pattern not finished and if the word finished the loop will be ended
                            {
                                break;
                            }
                        }
                        for (int ix = 0; ix < upper_text.Length; ix++) // when the loop ends the variable have to be empty for another word
                        {
                            your_text[ix] = " ";
                        }
                    }

                    for (int i = 0; i < upper_text.Length; i++) // this loop for '*' if the '*' is in the middle of the pattern and more than one times
                    {
                        if (upper_text[i] != ' ') // when the loop comes space it start to control word one by one
                        {
                            for (int ie = word_firstletter; ie < upper_text.Length; ie++) // the first letter will be updates here for every word
                            {
                                if (upper_text[ie] == ' ') // in each space the first letter updateds for the future loop 
                                {
                                    word_firstletter = ie + 1;
                                    break;
                                }
                            }
                        }
                        lastloop = 0;
                        while (lastloop < upper_pattern.Length) // last loop used for loop restriction
                        {
                            if (upper_pattern[lastloop] != '*' && upper_pattern[lastloop] != upper_text[word_firstletter + lastloop]) //when the loop don't find '*' compares the pattern and text letters if it is not same the loop will be ended
                            {
                                break;
                            }
                            if (upper_pattern[lastloop] == '*')
                            {
                                for (int it = lastloop; it < upper_text.Length; it++)
                                {
                                    if ((lastloop + 1) >= upper_pattern.Length || it >= upper_text.Length || word_firstletter >= upper_text.Length) // if the word outside of the bounds this part will be skiped
                                    {
                                        break;
                                    }
                                    if (upper_pattern[lastloop + 1] == upper_text[it] && upper_pattern[0] == upper_text[word_firstletter]) // controling the pattern and text letters if the letters are same the loop is going to print the word
                                    {
                                        for (int iz = word_firstletter; iz < 1000; iz++) // ı used this loop for controling letters
                                        {
                                            if (upper_text[iz] == ' ')
                                            {
                                                value = iz; // ı used value to get last letter of words 
                                                break;
                                            }
                                        }
                                        if (upper_pattern[upper_pattern.Length - 1] == upper_text[value - 1]) // controling the last letter in the word
                                        {
                                            Console.WriteLine();
                                            for (int iz = word_firstletter; iz < 1000; iz++)
                                            {
                                                Console.Write(text[iz]);
                                                if (upper_text[iz] == ' ')
                                                {
                                                    break;
                                                }
                                            }
                                            break;
                                        }
                                    }
                                }
                            }
                            lastloop++;
                        }
                    }
                    Console.ReadKey();
                }
                
            }
        }
    }
}
