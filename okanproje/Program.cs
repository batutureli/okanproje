using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" _________________");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|_____|_____|_____|");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|_____|_____|_____|");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|     |     |     |");
            Console.WriteLine("|_____|_____|_____|");

            char a11 = ' ';
            char a12 = ' ';
            char a13 = ' ';
            char a21 = ' ';
            char a22 = ' ';
            char a23 = ' ';
            char a31 = ' ';
            char a32 = ' ';
            char a33 = ' ';
            int r11 = 0;
            int r12 = 0;
            int r13 = 0;
            int r21 = 0;
            int r22 = 0;
            int r23 = 0;
            int r31 = 0;
            int r32 = 0;
            int r33 = 0;

            Random random = new Random();
            int number;
            char letter;
            number = random.Next(1, 4);
            if (number == 1) letter = 'D';
            else if (number == 2) letter = 'E';
            else letter = 'U';
            a11 = letter;

            number = random.Next(1, 4);
            if (number == 1) letter = 'D';
            else if (number == 2) letter = 'E';
            else letter = 'U';
            a12 = letter;

            number = random.Next(1, 4);
            if (number == 1) letter = 'D';
            else if (number == 2) letter = 'E';
            else letter = 'U';
            a13 = letter;

            number = random.Next(1, 4);
            if (number == 1) letter = 'D';
            else if (number == 2) letter = 'E';
            else letter = 'U';
            a21 = letter;

            number = random.Next(1, 4);
            if (number == 1) letter = 'D';
            else if (number == 2) letter = 'E';
            else letter = 'U';
            a22 = letter;

            number = random.Next(1, 4);
            if (number == 1) letter = 'D';
            else if (number == 2) letter = 'E';
            else letter = 'U';
            a23 = letter;

            number = random.Next(1, 4);
            if (number == 1) letter = 'D';
            else if (number == 2) letter = 'E';
            else letter = 'U';
            a31 = letter;

            number = random.Next(1, 4);
            if (number == 1) letter = 'D';
            else if (number == 2) letter = 'E';
            else letter = 'U';
            a32 = letter;

            number = random.Next(1, 4);
            if (number == 1) letter = 'D';
            else if (number == 2) letter = 'E';
            else letter = 'U';
            a33 = letter;



            r11 = random.Next(1, 4);
            r12 = random.Next(1, 4);
            r13 = random.Next(1, 4);
            r21 = random.Next(1, 4);
            r22 = random.Next(1, 4);
            r23 = random.Next(1, 4);
            r31 = random.Next(1, 4);
            r32 = random.Next(1, 4);
            r33 = random.Next(1, 4);

            int rr;
            rr = r11;
            if (rr == 1) Console.ForegroundColor = ConsoleColor.Red;
            if (rr == 2) Console.ForegroundColor = ConsoleColor.Green;
            if (rr == 3) Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(3, 2);
            Console.WriteLine(a11);

            rr = r12;
            if (rr == 1) Console.ForegroundColor = ConsoleColor.Red;
            if (rr == 2) Console.ForegroundColor = ConsoleColor.Green;
            if (rr == 3) Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(9, 2);
            Console.WriteLine(a12);

            rr = r13;
            if (rr == 1) Console.ForegroundColor = ConsoleColor.Red;
            if (rr == 2) Console.ForegroundColor = ConsoleColor.Green;
            if (rr == 3) Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(15, 2);
            Console.WriteLine(a13);

            rr = r21;
            if (rr == 1) Console.ForegroundColor = ConsoleColor.Red;
            if (rr == 2) Console.ForegroundColor = ConsoleColor.Green;
            if (rr == 3) Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(3, 5);
            Console.WriteLine(a21);

            rr = r22;
            if (rr == 1) Console.ForegroundColor = ConsoleColor.Red;
            if (rr == 2) Console.ForegroundColor = ConsoleColor.Green;
            if (rr == 3) Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(9, 5);
            Console.WriteLine(a22);

            rr = r23;
            if (rr == 1) Console.ForegroundColor = ConsoleColor.Red;
            if (rr == 2) Console.ForegroundColor = ConsoleColor.Green;
            if (rr == 3) Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(15, 5);
            Console.WriteLine(a23);

            rr = r31;
            if (rr == 1) Console.ForegroundColor = ConsoleColor.Red;
            if (rr == 2) Console.ForegroundColor = ConsoleColor.Green;
            if (rr == 3) Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(3, 8);
            Console.WriteLine(a31);

            rr = r32;
            if (rr == 1) Console.ForegroundColor = ConsoleColor.Red;
            if (rr == 2) Console.ForegroundColor = ConsoleColor.Green;
            if (rr == 3) Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(9, 8);
            Console.WriteLine(a32);

            rr = r33;
            if (rr == 1) Console.ForegroundColor = ConsoleColor.Red;
            if (rr == 2) Console.ForegroundColor = ConsoleColor.Green;
            if (rr == 3) Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(15, 8);
            Console.WriteLine(a33);

            Console.SetCursorPosition(0, 11);


            string row = "0";
            string column = "0";
            string colour = "0";
            string letternew = "0";

            for (int i = 0; i <= 1;)
            {
                Console.Write("Enter the row: ");
                row = Console.ReadLine();                
                if (row == "1" || row == "2" || row == "3")
                {
                    i = 2;
                }
                else
                {
                    Console.Write("Please enter 1 or 2 or 3 ");
                    Console.WriteLine();
                }
            }

            Console.WriteLine();

            for (int a = 0; a <= 1;)
            {
                Console.Write("Enter the column: ");
                column = Console.ReadLine();
                if (column == "1" || column == "2" || column == "3")
                {
                    a = 2;
                }
                else
                {
                    Console.Write("Please enter 1 or 2 or 3 ");
                    Console.WriteLine();
                }
            }

            Console.WriteLine();

            for (int i = 0; i <= 1;)
            {
                Console.WriteLine("1) Red ----- 2) Green ----- 3) Blue");
                Console.Write("Enter the colour: ");
                colour = Console.ReadLine();
                if (colour == "1" || colour == "2" || colour == "3")
                {
                    
                    i = 2;
                }
                else
                {
                    Console.Write("Please enter 1 or 2 or 3 ");
                    Console.WriteLine();
                }
            }

            Console.WriteLine();

            for (int i = 0; i <= 1;)
            {
                Console.Write("Enter the letter: ");
                letternew = Console.ReadLine();

                if (letternew == "D" || letternew == "E" || letternew == "U" || letternew == "d" || letternew == "e" || letternew == "u")
                {
                    i = 2;
                }
                else
                {
                    Console.Write("Please enter d or e or u ");
                    Console.WriteLine();
                }
            }

            if (row == "1" && column == "1" && colour == "1" && (letternew == "D" || letternew == "d"))
            {
                a11 = 'D';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(3, 2);
                Console.WriteLine(a11);
            }
            else if (row == "1" && column == "1" && colour == "2" && (letternew == "D" || letternew == "d"))
            {
                a11 = 'D';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(3, 2);
                Console.WriteLine(a11);
            }
            else if (row == "1" && column == "1" && colour == "3" && (letternew == "D" || letternew == "d"))
            {
                a11 = 'D';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(3, 2);
                Console.WriteLine(a11);
            }
            else if (row == "1" && column == "2" && colour == "1" && (letternew == "D" || letternew == "d"))
            {
                a12 = 'D';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(9, 2);
                Console.WriteLine(a12);
            }
            else if (row == "1" && column == "2" && colour == "2" && (letternew == "D" || letternew == "d"))
            {
                a12 = 'D';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(9, 2);
                Console.WriteLine(a12);
            }
            else if (row == "1" && column == "2" && colour == "3" && (letternew == "D" || letternew == "d"))
            {
                a12 = 'D';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(9, 2);
                Console.WriteLine(a12);
            }
            else if (row == "1" && column == "3" && colour == "1" && (letternew == "D" || letternew == "d"))
            {
                a13 = 'D';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(15, 2);
                Console.WriteLine(a13);
            }
            else if (row == "1" && column == "3" && colour == "2" && (letternew == "D" || letternew == "d"))
            {
                a13 = 'D';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(15, 2);
                Console.WriteLine(a13);
            }
            else if (row == "1" && column == "3" && colour == "3" && (letternew == "D" || letternew == "d"))
            {
                a13 = 'D';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(15, 2);
                Console.WriteLine(a13);
            }
            else if (row == "1" && column == "1" && colour == "1" && (letternew == "E" || letternew == "e"))
            {
                a11 = 'E';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(3, 2);
                Console.WriteLine(a11);
            }
            else if (row == "1" && column == "1" && colour == "2" && (letternew == "E" || letternew == "e"))
            {
                a11 = 'E';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(3, 2);
                Console.WriteLine(a11);
            }
            else if (row == "1" && column == "1" && colour == "3" && (letternew == "E" || letternew == "e"))
            {
                a11 = 'E';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(3, 2);
                Console.WriteLine(a11);
            }
            else if (row == "1" && column == "2" && colour == "1" && (letternew == "E" || letternew == "e"))
            {
                a12 = 'E';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(9, 2);
                Console.WriteLine(a12);
            }
            else if (row == "1" && column == "2" && colour == "2" && (letternew == "E" || letternew == "e"))
            {
                a12 = 'E';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(9, 2);
                Console.WriteLine(a12);
            }
            else if (row == "1" && column == "2" && colour == "3" && (letternew == "E" || letternew == "e"))
            {
                a12 = 'E';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(9, 2);
                Console.WriteLine(a12);
            }
            else if (row == "1" && column == "3" && colour == "1" && (letternew == "E" || letternew == "e"))
            {
                a13 = 'E';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(15, 2);
                Console.WriteLine(a13);
            }
            else if (row == "1" && column == "3" && colour == "2" && (letternew == "E" || letternew == "e"))
            {
                a13 = 'E';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(15, 2);
                Console.WriteLine(a13);
            }
            else if (row == "1" && column == "3" && colour == "3" && (letternew == "E" || letternew == "e"))
            {
                a13 = 'E';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(15, 2);
                Console.WriteLine(a13);
            }
            else if (row == "1" && column == "1" && colour == "1" && (letternew == "U" || letternew == "u"))
            {
                a11 = 'U';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(3, 2);
                Console.WriteLine(a11);
            }
            else if (row == "1" && column == "1" && colour == "2" && (letternew == "U" || letternew == "u"))
            {
                a11 = 'U';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(3, 2);
                Console.WriteLine(a11);
            }
            else if (row == "1" && column == "1" && colour == "3" && (letternew == "U" || letternew == "u"))
            {
                a11 = 'U';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(3, 2);
                Console.WriteLine(a11);
            }
            else if (row == "1" && column == "2" && colour == "1" && (letternew == "U" || letternew == "u"))
            {
                a12 = 'U';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(9, 2);
                Console.WriteLine(a12);
            }
            else if (row == "1" && column == "2" && colour == "2" && (letternew == "U" || letternew == "u"))
            {
                a12 = 'U';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(9, 2);
                Console.WriteLine(a12);
            }
            else if (row == "1" && column == "2" && colour == "3" && (letternew == "U" || letternew == "u"))
            {
                a12 = 'U';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(9, 2);
                Console.WriteLine(a12);
            }
            else if (row == "1" && column == "3" && colour == "1" && (letternew == "U" || letternew == "u"))
            {
                a13 = 'U';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(15, 2);
                Console.WriteLine(a13);
            }
            else if (row == "1" && column == "3" && colour == "2" && (letternew == "U" || letternew == "u"))
            {
                a13 = 'U';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(15, 2);
                Console.WriteLine(a13);
            }
            else if (row == "1" && column == "3" && colour == "3" && (letternew == "U" || letternew == "u"))
            {
                a13 = 'U';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(15, 2);
                Console.WriteLine(a13);
            }
            else if (row == "2" && column == "1" && colour == "1" && (letternew == "D" || letternew == "d"))
            {
                a21 = 'D';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(3, 5);
                Console.WriteLine(a21);
            }
            else if (row == "2" && column == "1" && colour == "2" && (letternew == "D" || letternew == "d"))
            {
                a21 = 'D';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(3, 5);
                Console.WriteLine(a21);
            }
            else if (row == "2" && column == "1" && colour == "3" && (letternew == "D" || letternew == "d"))
            {
                a21 = 'D';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(3, 5);
                Console.WriteLine(a21);
            }
            else if (row == "2" && column == "2" && colour == "1" && (letternew == "D" || letternew == "d"))
            {
                a22 = 'D';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(9, 5);
                Console.WriteLine(a22);
            }
            else if (row == "2" && column == "2" && colour == "2" && (letternew == "D" || letternew == "d"))
            {
                a22 = 'D';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(9, 5);
                Console.WriteLine(a22);
            }
            else if (row == "2" && column == "2" && colour == "3" && (letternew == "D" || letternew == "d"))
            {
                a22 = 'D';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(9, 5);
                Console.WriteLine(a22);
            }
            else if (row == "2" && column == "3" && colour == "1" && (letternew == "D" || letternew == "d"))
            {
                a23 = 'D';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(15, 5);
                Console.WriteLine(a23);
            }
            else if (row == "2" && column == "3" && colour == "2" && (letternew == "D" || letternew == "d"))
            {
                a23 = 'D';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(15, 5);
                Console.WriteLine(a23);
            }
            else if (row == "2" && column == "3" && colour == "3" && (letternew == "D" || letternew == "d"))
            {
                a23 = 'D';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(15, 5);
                Console.WriteLine(a23);
            }
            else if (row == "2" && column == "1" && colour == "1" && (letternew == "E" || letternew == "e"))
            {
                a21 = 'E';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(3, 5);
                Console.WriteLine(a21);
            }
            else if (row == "2" && column == "1" && colour == "2" && (letternew == "E" || letternew == "e"))
            {
                a21 = 'E';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(3, 5);
                Console.WriteLine(a21);
            }
            else if (row == "2" && column == "1" && colour == "3" && (letternew == "E" || letternew == "e"))
            {
                a21 = 'E';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(3, 5);
                Console.WriteLine(a21);
            }
            else if (row == "2" && column == "2" && colour == "1" && (letternew == "E" || letternew == "e"))
            {
                a22 = 'E';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(9, 5);
                Console.WriteLine(a22);
            }
            else if (row == "2" && column == "2" && colour == "2" && (letternew == "E" || letternew == "e"))
            {
                a22 = 'E';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(9, 5);
                Console.WriteLine(a22);
            }
            else if (row == "2" && column == "2" && colour == "3" && (letternew == "E" || letternew == "e"))
            {
                a22 = 'E';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(9, 5);
                Console.WriteLine(a22);
            }
            else if (row == "2" && column == "3" && colour == "1" && (letternew == "E" || letternew == "e"))
            {
                a23 = 'E';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(15, 5);
                Console.WriteLine(a23);
            }
            else if (row == "2" && column == "3" && colour == "2" && (letternew == "E" || letternew == "e"))
            {
                a23 = 'E';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(15, 5);
                Console.WriteLine(a23);
            }
            else if (row == "2" && column == "3" && colour == "3" && (letternew == "E" || letternew == "e"))
            {
                a23 = 'E';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(15, 5);
                Console.WriteLine(a23);
            }
            else if (row == "2" && column == "1" && colour == "1" && (letternew == "U" || letternew == "u"))
            {
                a21 = 'U';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(3, 5);
                Console.WriteLine(a21);
            }
            else if (row == "2" && column == "1" && colour == "2" && (letternew == "U" || letternew == "u"))
            {
                a21 = 'U';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(3, 5);
                Console.WriteLine(a21);
            }
            else if (row == "2" && column == "1" && colour == "3" && (letternew == "U" || letternew == "u"))
            {
                a21 = 'U';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(3, 5);
                Console.WriteLine(a21);
            }
            else if (row == "2" && column == "2" && colour == "1" && (letternew == "U" || letternew == "u"))
            {
                a22 = 'U';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(9, 5);
                Console.WriteLine(a22);
            }
            else if (row == "2" && column == "2" && colour == "2" && (letternew == "U" || letternew == "u"))
            {
                a22 = 'U';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(9, 5);
                Console.WriteLine(a22);
            }
            else if (row == "2" && column == "2" && colour == "3" && (letternew == "U" || letternew == "u"))
            {
                a22 = 'U';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(9, 5);
                Console.WriteLine(a22);
            }
            else if (row == "2" && column == "3" && colour == "1" && (letternew == "U" || letternew == "u"))
            {
                a23 = 'U';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(15, 5);
                Console.WriteLine(a23);
            }
            else if (row == "2" && column == "3" && colour == "2" && (letternew == "U" || letternew == "u"))
            {
                a23 = 'U';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(15, 5);
                Console.WriteLine(a13);
            }
            else if (row == "2" && column == "3" && colour == "3" && (letternew == "U" || letternew == "u"))
            {
                a23 = 'U';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(15, 5);
                Console.WriteLine(a23);
            }
            else if (row == "3" && column == "1" && colour == "1" && (letternew == "D" || letternew == "d"))
            {
                a31 = 'D';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(3, 8);
                Console.WriteLine(a31);
            }
            else if (row == "3" && column == "1" && colour == "2" && (letternew == "D" || letternew == "d"))
            {
                a31 = 'D';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(3, 8);
                Console.WriteLine(a31);
            }
            else if (row == "3" && column == "1" && colour == "3" && (letternew == "D" || letternew == "d"))
            {
                a31 = 'D';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(3, 8);
                Console.WriteLine(a31);
            }
            else if (row == "3" && column == "2" && colour == "1" && (letternew == "D" || letternew == "d"))
            {
                a32 = 'D';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(9, 8);
                Console.WriteLine(a32);
            }
            else if (row == "3" && column == "2" && colour == "2" && (letternew == "D" || letternew == "d"))
            {
                a32 = 'D';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(9, 8);
                Console.WriteLine(a32);
            }
            else if (row == "3" && column == "2" && colour == "3" && (letternew == "D" || letternew == "d"))
            {
                a32 = 'D';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(9, 8);
                Console.WriteLine(a32);
            }
            else if (row == "3" && column == "3" && colour == "1" && (letternew == "D" || letternew == "d"))
            {
                a33 = 'D';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(15, 8);
                Console.WriteLine(a33);
            }
            else if (row == "3" && column == "3" && colour == "2" && (letternew == "D" || letternew == "d"))
            {
                a33 = 'D';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(15, 8);
                Console.WriteLine(a33);
            }
            else if (row == "3" && column == "3" && colour == "3" && (letternew == "D" || letternew == "d"))
            {
                a33 = 'D';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(15, 8);
                Console.WriteLine(a33);
            }
            else if (row == "3" && column == "1" && colour == "1" && (letternew == "E" || letternew == "e"))
            {
                a31 = 'E';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(3, 8);
                Console.WriteLine(a31);
            }
            else if (row == "3" && column == "1" && colour == "2" && (letternew == "E" || letternew == "e"))
            {
                a31 = 'E';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(3, 8);
                Console.WriteLine(a31);
            }
            else if (row == "3" && column == "1" && colour == "3" && (letternew == "E" || letternew == "e"))
            {
                a31 = 'E';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(3, 8);
                Console.WriteLine(a31);
            }
            else if (row == "3" && column == "2" && colour == "1" && (letternew == "E" || letternew == "e"))
            {
                a32 = 'E';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(9, 8);
                Console.WriteLine(a32);
            }
            else if (row == "3" && column == "2" && colour == "2" && (letternew == "E" || letternew == "e"))
            {
                a32 = 'E';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(9, 8);
                Console.WriteLine(a32);
            }
            else if (row == "3" && column == "2" && colour == "3" && (letternew == "E" || letternew == "e"))
            {
                a32 = 'E';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(9, 8);
                Console.WriteLine(a32);
            }
            else if (row == "3" && column == "3" && colour == "1" && (letternew == "E" || letternew == "e"))
            {
                a33 = 'E';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(15, 8);
                Console.WriteLine(a33);
            }
            else if (row == "3" && column == "3" && colour == "2" && (letternew == "E" || letternew == "e"))
            {
                a33 = 'E';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(15, 8);
                Console.WriteLine(a33);
            }
            else if (row == "3" && column == "3" && colour == "3" && (letternew == "E" || letternew == "e"))
            {
                a33 = 'E';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(15, 8);
                Console.WriteLine(a33);
            }
            else if (row == "3" && column == "1" && colour == "1" && (letternew == "U" || letternew == "u"))
            {
                a31 = 'U';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(3, 8);
                Console.WriteLine(a31);
            }
            else if (row == "3" && column == "1" && colour == "2" && (letternew == "U" || letternew == "u"))
            {
                a31 = 'U';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(3, 8);
                Console.WriteLine(a31);
            }
            else if (row == "3" && column == "1" && colour == "3" && (letternew == "U" || letternew == "u"))
            {
                a31 = 'U';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(3, 8);
                Console.WriteLine(a31);
            }
            else if (row == "3" && column == "2" && colour == "1" && (letternew == "U" || letternew == "u"))
            {
                a32 = 'U';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(9, 8);
                Console.WriteLine(a32);
            }
            else if (row == "3" && column == "2" && colour == "2" && (letternew == "U" || letternew == "u"))
            {
                a32 = 'U';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(9, 8);
                Console.WriteLine(a32);
            }
            else if (row == "3" && column == "2" && colour == "3" && (letternew == "U" || letternew == "u"))
            {
                a32 = 'U';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(9, 8);
                Console.WriteLine(a32);
            }
            else if (row == "3" && column == "3" && colour == "1" && (letternew == "U" || letternew == "u"))
            {
                a33 = 'U';
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(15, 8);
                Console.WriteLine(a33);
            }
            else if (row == "3" && column == "3" && colour == "2" && (letternew == "U" || letternew == "u"))
            {
                a33 = 'U';
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(15, 8);
                Console.WriteLine(a33);
            }
            else if (row == "3" && column == "3" && colour == "3" && (letternew == "U" || letternew == "u"))
            {
                a33 = 'U';
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(15, 8);
                Console.WriteLine(a33);
            }

            else Console.WriteLine("ERROR");

            Console.Read();
        }
    }
}


