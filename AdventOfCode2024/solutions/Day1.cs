namespace AdventOfCode2024.Solutions;

public class Day1
{
    public static void Part1()
    {
        var (listA, listB) = GetInputsLists();

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

    private static (List<int> listA, List<int> listB) GetInputsLists()
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
        return (listA, listB);
    }

    public static void Part2()
    {
        var (listA, listB) = GetInputsLists();

        // we need a hashmap like number: number of times it appears 
        //this needs to be based on ListB

        var dict = new Dictionary<int, int>();

        foreach (var number in listB)
        {
            if (!dict.TryAdd(number, 1))
            {
                dict[number]++;
            }
        }

        var total = 0;

        for (int i = 0; i < listA.Count; i++)
        {
            var dictElement = dict.GetValueOrDefault(listA[i], 0);
            total += listA[i] * dictElement;
        }
        
        Console.WriteLine("Day 1, Part 2: " + total);
    }
}