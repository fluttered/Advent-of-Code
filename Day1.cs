namespace Advent_of_Code_2022;

public class Day1

{
    public static int firstSolution()
    {
        int currentSum = 0;
        int highestSum = 0;

        foreach (string line in System.IO.File.ReadLines(System.IO.Path.GetFullPath(@"input.txt")))
        {
            if (line != string.Empty)
            {
                currentSum += int.Parse(line);
            }
            else
            {
                if (currentSum > highestSum) highestSum = currentSum;
                currentSum = 0;
            }
        }

        return highestSum;
    }

    public static int secondSolution()
    {
        int currentSum = 0;
        List<int> sums = new List<int>();

        foreach (string line in System.IO.File.ReadLines(System.IO.Path.GetFullPath(@"input.txt")))
        {
            if (line != string.Empty)
            {
                currentSum += int.Parse(line);
            }
            else
            {
                sums.Add(currentSum);
                currentSum = 0;
            }
        }

        sums.Sort();
        return sums.GetRange(sums.Count - 3, 3).Sum();
    }
}