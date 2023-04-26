namespace TicTacToe
{
    class Program
    {
        static char[,] playField =
        {
            { '1','2','3'},
            { '4','5','6'},
            { '7','8','9'}
        };

        static char[,] playFieldReset =
        {
            { '1','2','3'},
            { '4','5','6'},
            { '7','8','9'}
        };
        static int turns = 0;

        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool inputCorrect = true;

            do
            {
                if (player == 2)
                {
                    player = 1;
                    enterXorO(player, input);
                }
                else if (player == 1)
                {
                    player = 2;
                    enterXorO(player, input);
                }

                SetField();
                turns++;
                #region 
                // Check for winning condition
                char[] playChars = { 'X', 'O' };
                foreach (char playChar in playChars)
                {
                    if (((playField[0, 0] == playChar) && (playField[0, 1] == playChar) && (playField[0, 2] == playChar)) // First row
                        || ((playField[1, 0] == playChar) && (playField[1, 1] == playChar) && (playField[1, 2] == playChar)) // Second 
                        || ((playField[2, 0] == playChar) && (playField[2, 1] == playChar) && (playField[2, 2] == playChar)) // Third
                        || ((playField[0, 0] == playChar) && (playField[1, 1] == playChar) && (playField[2, 2] == playChar)) // TL - Middle - BR
                        || ((playField[0, 2] == playChar) && (playField[1, 1] == playChar) && (playField[2, 0] == playChar)) // TR - MD - BL
                        || ((playField[0, 0] == playChar) && (playField[1, 0] == playChar) && (playField[2, 0] == playChar)) // First Vertical
                        || ((playField[0, 1] == playChar) && (playField[1, 1] == playChar) && (playField[2, 1] == playChar)) // Middle vertical
                        || ((playField[0, 2] == playChar) && (playField[1, 2] == playChar) && (playField[2, 2] == playChar)) // Last Vertical
                         )
                    {
                        if (playChar == 'X')
                        {
                            Console.WriteLine($"Player 2 is Winner");
                        }
                        else
                        {
                            Console.WriteLine($"Player 1 is Winner");
                        }

                        Console.WriteLine($"Press Any key to reset the game!");
                        Console.ReadLine();
                        playField = playFieldReset;
                        player = 1;
                        turns = 0;
                        SetField();
                        break;
                    }
                    else if (turns == 10)
                    {
                        Console.WriteLine($"Draw!");
                        Console.WriteLine($"Press Any key to reset the game!");
                        Console.ReadLine();
                        playField = playFieldReset;
                        player = 1;
                        SetField();

                    }

                }
                #endregion


                #region 
                // Test if field is already taken
                do
                {
                    Console.Write($"\nPlayer {player}, Choose your Field: ");
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine($"Please enter a number!");
                    }

                    if ((input == 1) && (playField[0, 0] == '1'))
                        inputCorrect = true;
                    else if ((input == 2) && (playField[0, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (playField[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (playField[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (playField[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (playField[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (playField[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (playField[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (playField[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine($"Incorrect Input! Use another field!");
                        inputCorrect = false;
                    }

                } while (!inputCorrect);
                #endregion

            } while (true);
        }

        public static void enterXorO(int player, int input)
        {
            char playSign = ' ';
            if (player == 1)
                playSign = 'X';
            else if (player == 2)
                playSign = 'O';

            switch (input)
            {
                case 1: playField[0, 0] = playSign; break;
                case 2: playField[0, 1] = playSign; break;
                case 3: playField[0, 2] = playSign; break;
                case 4: playField[1, 0] = playSign; break;
                case 5: playField[1, 1] = playSign; break;
                case 6: playField[1, 2] = playSign; break;
                case 7: playField[2, 0] = playSign; break;
                case 8: playField[2, 1] = playSign; break;
                case 9: playField[2, 2] = playSign; break;
            }
        }
        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine($"    |     |    ");
            Console.WriteLine($"  {playField[0, 0]} |  {playField[0, 1]}  |  {playField[0, 2]} ");
            Console.WriteLine($"____|_____|____");
            Console.WriteLine($"    |     |    ");
            Console.WriteLine($"  {playField[1, 0]} |  {playField[1, 1]}  |  {playField[1, 2]} ");
            Console.WriteLine($"____|_____|____");
            Console.WriteLine($"    |     |    ");
            Console.WriteLine($"  {playField[2, 0]} |  {playField[2, 1]}  |  {playField[2, 2]} ");
            Console.WriteLine($"____|_____|____");
            Console.WriteLine($"    |     |    ");

        }
    }
}
