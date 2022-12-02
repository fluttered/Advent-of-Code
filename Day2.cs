namespace Advent_of_Code_2022;

public class Day2
{
// Rock (A) - (X) 1 > Scissors (C) (Z) 3
// Scissors (C) (Z) 3 > Paper (B) (Y) 2
// Paper (B) (Y) 2 > Rock (A) (X) 1


// Lost = 0
// Draw = 3
// Win = 6

    enum Choices : ushort
    {
        A = 1,
        X = 1,
        C = 3,
        Z = 3,
        B = 2,
        Y = 2,
    }

    public static int firstSolution()
    {
        int points = 0;
        foreach (var line in File.ReadLines(Path.GetFullPath(@"input.txt")))
        {
            Choices choiceOne, choiceTwo;
            Enum.TryParse(line[0].ToString(), out choiceOne);
            Enum.TryParse(line[2].ToString(), out choiceTwo);

            int playerOne = (int)choiceOne;
            int playerTwo = (int)choiceTwo;


            // Draw
            if (playerTwo == playerOne) points += playerTwo + 3;
            else if (playerTwo == 1 && playerOne == 3) points += playerTwo + 6;
            else if (playerTwo == 3 && playerOne == 2) points += playerTwo + 6;
            else if (playerTwo == 2 && playerOne == 1) points += playerTwo + 6;
            else
            {
                points += playerTwo;
            }
        }

        return points;
    }

    // X -> Loose
    // Y -> Draw
    // Z -> Win
    public static int secondSolution()
    {
        int points = 0;
        foreach (var line in File.ReadLines(Path.GetFullPath(@"input.txt")))
        {
            Choices choiceOne, choiceTwo;
            Enum.TryParse(line[0].ToString(), out choiceOne);
            Enum.TryParse(line[2].ToString(), out choiceTwo);

            int playerOne = (int)choiceOne;
            int playerTwo = (int)choiceTwo;

            // Draw
            if (playerTwo == 2) points += playerOne + 3;
            // Win
            else if (playerTwo == 3)
            {
                points += 6;

                if (playerOne == 3) points += 1;
                if (playerOne == 2) points += 3;
                if (playerOne == 1) points += 2;
            }
            // Loose
            else
            {
                points += 0;

                if (playerOne == 1) points += 3;
                if (playerOne == 3) points += 2;
                if (playerOne == 2) points += 1;
            }
        }

        return points;
    }
}