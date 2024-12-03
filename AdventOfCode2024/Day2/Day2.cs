namespace AdventOfCode2024.Day2;

public static class Day2
{
    private const int MinDifference = 1;
    private const int MaxDifference = 3;

    public static async Task<int> Solve()
    {
        var safeCount = 0;

        var separator = new[] { ' ', '\t' };

        await foreach (var line in File.ReadLinesAsync(@".\Day2\Day2Input.txt"))
        {
            var numbers = line.Split(separator, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var orderIsSafe = IsIncreasingOrDecreasing(numbers);

            if (!numbers.Select(x => ).ToList()
                    .Any(x => x is < MinDifference or > MaxDifference))
                safeCount++;
        }
        return safeCount;
    }

    private static bool IsIncreasingOrDecreasing(List<int> numbers)
    {
        for(int i = 0; i < numbers.Count-1; i++) 
        {

        }
    }
}