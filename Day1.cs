namespace JakubSturc.AdventOfCode2021;

public class Day1
{
    public static int Parse(string line) => int.Parse(line);

    public static int Part1(IEnumerable<int> scan)
    {
        var previous = scan.Skip(1);

        return Enumerable.Zip(scan, previous)
            .Select(Diff)
            .Where(Δ => Δ > 0)
            .Count();


        static int Diff((int a, int b) item) => item.b - item.a;
    }

    public static int Part2(IEnumerable<int> scan)
    {
        return Part1(Slide3(scan));

        static IEnumerable<int> Slide3(IEnumerable<int> scan)
        {
            var s0 = scan.Skip(0);
            var s1 = scan.Skip(1);
            var s2 = scan.Skip(2);

            return Enumerable.Zip(s0, s1, s2).Select(Sum);
        }

        static int Sum((int a, int b, int c) item) => item.a + item.b + item.c;
    }
}