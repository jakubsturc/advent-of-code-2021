namespace JakubSturc.AdventOfCode2021;

public class Day3
{
    public static string Parse(string line) => line;

    public static (int γ, int ɛ) Part1(IEnumerable<string> report)
    {
        Diagnostic diagnostic = new();
        foreach (var reportLine in report)
        {
            diagnostic.Add(reportLine);
        }

        return diagnostic.GetEnergy();
    }
}

public class Diagnostic
{
    private int[]? bites;
    private int lines = 0;

    public void Add(string reportLine)
    {
        var len = reportLine.Length;
        bites ??= new int[len];

        for (int i = 0; i < len; i++) 
        {
            switch (reportLine[i])
            {
                case '0': break;
                case '1': bites[i]++; break;
                default: throw new ArgumentException();
            }            
        }

        lines++;
    }

    public (int γ, int ɛ) GetEnergy()
    {
        if (bites == null) throw new InvalidOperationException();
        
        int γ = 0;
        int ɛ = 0;
        
        for (int i = 0; i < bites.Length; i++)
        {
            γ <<= 1;
            ɛ <<= 1;

            if (bites[i] > lines / 2) γ += 1;
            else ɛ += 1;
        }

        return (γ, ɛ);
    }
}