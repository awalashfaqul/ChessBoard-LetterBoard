/* NAME: ABU LABIB MOHAMMED ASHFAQUL AWAL */
/* CLASS: NET-23 */
/* SCHOOL: CHAS ACADEMY, STOCKHOLM */

using System;
using System.Drawing;

namespace ChessBoard
{
    
    class Program
    {
        static void Main (string[] arg)
        {
            //unicode to show the squares, and setting a unicode standard output
            //Console.OutputEncoding = System.Text.Encoding.Unicode;

            Begin:
            //As the number of row and column are same in the chess board,
            //user will be asked to input a number for both rows and columns.

            Console.Write("Please enter number of Rows & Columns (prefer not more than 8, please): ");

            int number = int.Parse(Console.ReadLine()); // here int.parse() is used to
                                                        //convert a text to a number.
            if(number<=8)
            { 

                for (int i = 0; i < number; i++) // here 'i' will iterate for creating rows
                                                 // according to the number given by the users.
                {
                    for (int j = 0; j < number; j++) // here 'j' will iterate for creating columns
                                                     // according to the number given by the users.
                    {
                        if ((i + j) % 2 == 0) // here 'if-else' statement is to check the condition
                                              // where the sum of rows and columns are odd or even
                        {
                            Console.Write("\u25FC"); // '\u25FC' For '◼︎'
                        }
                        else
                        {
                            Console.Write("\u25FB"); // '\u25FC' For '◻︎'
                        }
                    }
                    Console.WriteLine(); // writing a new line after every row is generated.
                }
            }
            else
            {
                Console.WriteLine("Invalid number of rows and columns. Enater a valid number, Thanks.");
                goto Begin;
            }


            //Code section for replacing Black & White blocks of chessboard with user's desired letters. 
            Console.WriteLine("Do you wish to replace Chess Board blocks with letters? (y/n)");
            char ansWer = Convert.ToChar(Console.ReadLine());

            if(ansWer== 'y')
            {
                Console.WriteLine("Do you wish to keep the previous number of Rows & Columns? (y/n)");
                char ansWer1 = Convert.ToChar(Console.ReadLine());

                if(ansWer1=='y')
                {
                    Console.WriteLine("How will the black blocks look like?");
                    char blackBlock = Convert.ToChar(Console.ReadLine());

                    Console.WriteLine("How will the white blocks look like?");
                    char whiteBlock = Convert.ToChar(Console.ReadLine());

                    

                        for (int i = 0; i < number; i++) // here 'i' will iterate for creating rows
                                                         // according to the number given by the users.
                        {
                            for (int j = 0; j < number; j++) // here 'j' will iterate for creating columns
                                                             // according to the number given by the users.
                            {


                                if ((i + j) % 2 == 0) // here 'if-else' statement is to check the condition
                                                      // where the sum of rows and columns are odd or even
                                {
                                    Console.Write(blackBlock);
                                }
                                else
                                {
                                    Console.Write(whiteBlock);

                                }

                            }
                            Console.WriteLine(); // writing a new line after every row is generated.
                        }
                    
                    Console.WriteLine("Press ENTER to exit...");
                    Console.ReadLine();

                }

                else
                {
                    Console.Write("Enter number of Rows & Columns: ");
                    int numberRC = int.Parse(Console.ReadLine()); // here int.parse() is used to
                                                                //convert a text to a number.

                    Console.WriteLine("How will the black blocks look like?");
                    char blackBlock = Convert.ToChar(Console.ReadLine());

                    Console.WriteLine("How will the white blocks look like?");
                    char whiteBlock = Convert.ToChar(Console.ReadLine());

                    
                    for (int i = 0; i < numberRC; i++) // here 'i' will iterate for creating rows
                                                     // according to the number given by the users.
                    {
                        for (int j = 0; j < numberRC; j++) // here 'j' will iterate for creating columns
                                                         // according to the number given by the users.
                        {
                            if ((i + j) % 2 == 0) // here 'if-else' statement is to check the condition
                                                  // where the sum of rows and columns are odd or even
                            {
                                Console.Write(blackBlock);
                            }
                            else
                            {
                                Console.Write(whiteBlock);
                            }
                        }
                        Console.WriteLine(); // writing a new line after every column is generated.
                    }
                    Console.WriteLine("Press ENTER to exit...");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Press ENTER to exit...");
                Console.ReadLine();
            }

            
            
        }

    }
       

}
