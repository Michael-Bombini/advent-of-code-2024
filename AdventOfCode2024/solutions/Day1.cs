namespace AdventOfCode2024;

public class Day1
{
    public static void Part1()
    {
        var lines = File.ReadAllLines("./inputs/day1.txt");
        var listA = new List<int>();
        var listB = new List<int>();

        foreach (var line in lines)
        {
            var text = line.Split("   ");
            var a = int.Parse(text[0]);
            var b = int.Parse(text[1]);

            listA.Add(a);
            listB.Add(b);
        }

        listA.Sort();
        listB.Sort();

        var total = 0;

        for (int i = 0; i < listA.Count; i++)
        {
            var a = listA[i];
            var b = listB[i];

            if (a > b)
            {
                total += (a - b);
            }

            if (b > a)
            {
                total += (b - a);
            }
        }

        Console.WriteLine("Day 1, Part 1: " + total);
    }
}