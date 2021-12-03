using System.IO;

namespace JakubSturc.AdventOfCode2021;

public class Parser
{
    public static IEnumerable<T> Read<T>(string file, Func<string, T> parse)
        => File.ReadAllLines(file).Select(parse);
}
