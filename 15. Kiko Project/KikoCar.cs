using System;

class KikoCar
{
    static void Main()
    {
       
        int n = 19;
        char[,] car = new char[n, n*2];

        for (int i = 0, j = 0; i < n*2; i++, j += 2)
        {
            // roof
            if (i < 7)
            {
                car[0, n - n / 2 + i] = '=';
            }

            //// fundament
            //car[n - 9, i] = '=';
            // front window
            if (i < 4)
            {
                car[i, n - n / 2 + 7 + i] = '=';                
            }
            // front hood - kapak
            if (i < 11)
            {
                car[3, n - n / 2 + 11 + i] = '=';
            }
            // front bumper - bronia up
            if (i < 4)
            {
                car[3 + i, n - n / 2 + 21 + j] = '=';
            }
            if (i < 3)
            {
                car[3 + i, n - n / 2 + 22 + j] = '=';
            }
            if (i < 4)
            {
                car[6 + i, 2 * n - 1] = '=';                
            }
            // far
            if (i < 2)
            {
              
                 car[6, 2 * n - 3 + i] = '@';

                
            }
            

            // back kapak
            if (i < 5)
            {
                car[i, n - n / 2 - 1 - j] = '_';                
            }
            if (i < 9)
            {
                car[2 + i, 0] = '=';                
            }
            if (i < 2)
            {
                car[2, i] = '=';
                car[3, i] = '=';            
            }

            //if (i < 6)
            //{
            //    for (int c = 0; c < n * 2 - 1; c++)
            //    {
            //        car[4 + i, c] = 'p';

            //    }
            //}
            // back window
            if (i < 4)
            {
                for (int c = 0; c < 2 * i; c++)
                {
                    car[i, 9 - c] = '*';
                }
            }

            if (i < 3)
            {
                for (int c = 0; c < 3; c++)
                {
                    car[1 + i, n - n / 2 + c] = '|';
                }
            }

            if (i < 3)
            {
                for (int c = 0; c < 5; c++)
                {
                    car[1 + i, 13 + c] = 'b';
                }

                for (int c = 0; c < 1 + i; c++)
                {
                    car[1 + i, 18 + c] = 'b';
                    
                }
            }

            if (i < 6)
            {
                for (int c = 0; c < 10; c++)
                {
                    car[4 + i, 11 + c] = 'd';

                }
            }

            if (i < 3)
            {
                car[5, 11 + i] = 't';
            }

            if (i < 6)
            {
                car[4 + i, 10] = '|';
                car[4 + i, 21] = '|';
                
            }

           
            // gumi
            // right
            car[10, 5] = '#';
            car[10, 30] = '@';
            car[9, 30] = '@';
            car[11, 30] = '@';
            car[10, 33] = '@';
            car[9, 33] = '@';
            car[11, 33] = '@'; 
            car[8, 31] = '@';
            car[8, 32] = '@';
            car[12, 32] = '@';
            car[12, 31] = '@';


            // left
            car[9, 2] = '@';
            car[10, 2] = '@';
            car[11, 2] = '@';
            car[9, 5] = '@';
            car[10, 5] = '@';
            car[11, 5] = '@';
            car[8, 3] = '@';
            car[8, 4] = '@';
            car[12, 3] = '@';
            car[12, 4] = '@';

            // fundament
            car[10, 1] = '=';
            if (i < 24)
            {
                car[10, 6 + i] = '=';        
            }
            if (i < 4)
            {
                car[10, 34 + i] = '=';                
            }
            
        }





        // Print
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n*2; col++)
            {
                char ch = car[row, col];
                if (ch != 0)
                {
                    if (ch == '*')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write('=' + " ");
                    }
                    else if (ch == '|')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write(ch + " ");
                    }
                    else if (ch == 't')
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.Write('=' + " ");
                    }
                    else if (ch == 'b')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write('=' + " ");
                    }
                    else if (ch == '@')
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(ch + " ");
                    }
                    else if (ch == 'p')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write('=' + " ");
                    }
                    else if (ch == 'd')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write('-' + " ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(ch + " ");
                    }              
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(' ' + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

