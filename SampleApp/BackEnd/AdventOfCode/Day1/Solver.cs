namespace AdventofCode.Day1;

class Solver
{
    private int FindFirstDigit(string input)
    {
        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                return int.Parse(c.ToString());
            }
        }
        return 0; 
    }

    private int FindLastDigit(string input)
    {
        for (int i = input.Length - 1; i >= 0; i--)
        {
            if (char.IsDigit(input[i]))
            {
                return int.Parse(input[i].ToString());
            }
        }
        return 0; 
    }
    
    public int Solve()
    {
        var lines = File.ReadAllLines("AdventOfCode/Day1/data.in");
        var res = 0;
        foreach (var line in lines)
        {
            var str = "" + FindFirstDigit(line) + FindLastDigit(line);
            res += int.Parse(str);
        }
        return res;
    }
}