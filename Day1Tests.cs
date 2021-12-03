namespace JakubSturc.AdventOfCode2021;

public class Day1Tests
{
    [Fact]
    public void Part1Sample()
    {
        var scan = Parser.Read("day1.sample.txt", Day1.Parse);

        Assert.Equal(7, Day1.Part1(scan));
    }

    [Fact]
    public void Part1Input()
    {        
        var scan = Parser.Read("day1.input.txt", Day1.Parse);

        Assert.Equal(1154, Day1.Part1(scan));
    }

    [Fact]
    public void Part2Sample()
    {
        var scan = Parser.Read("day1.sample.txt", Day1.Parse);

        Assert.Equal(5, Day1.Part2(scan));
    }

    [Fact]
    public void Part2Input()
    {
        var scan = Parser.Read("day1.input.txt", Day1.Parse);

        Assert.Equal(1127, Day1.Part2(scan));
    }
}