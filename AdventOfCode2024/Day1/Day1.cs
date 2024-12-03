namespace AdventOfCode2024.Day1;

public static class Day1
{
    private static readonly List<int> LeftList = [];
    private static readonly List<int> RightList = [];

    public static async Task<long> SolvePart1()
    {
        await ReadData();
        
        LeftList.Sort();
        RightList.Sort();
        
        return FindDifference();
    }
    
    public static async Task<long> SolvePart2()
    {
        await ReadData();
        
        LeftList.Sort();
        RightList.Sort();
        
        return FindDifference2();
    }

    private static async Task ReadData()
    {
        var separator = new[] { ' ', '\t' };
        
        await foreach (var line in File.ReadLinesAsync(@".\Day1\Day1Input.txt"))
        {
            var parts = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            
            LeftList.Add(int.Parse(parts[0]));
            RightList.Add(int.Parse(parts[1]));
        }
    }

    private static long FindDifference()
    {
        long answer = 0;

        for (var i = 0; i < LeftList.Count; i++)
        {
            answer += Math.Abs(LeftList[i] - RightList[i]);
        }

        return answer;
    }
    
    private static long FindDifference2()
    {
        long answer = 0;

        foreach (var leftElement in LeftList)
        {
            var rightElement = RightList.Count(j => j == leftElement);
            
            if (rightElement != 0)
                answer += leftElement * rightElement;
        }

        return answer;
    }
}