namespace JakubSturc.AdventOfCode2021;

public class Day2Tests
{
    [Fact]
    public void Part1Sample()
    {
        var commands = Parser.Read("day2.sample.txt", Day2.Parse);

        Assert.Equal(new Position1(15, 10), Day2.Part1(commands));
    }

    [Fact]
    public void Part1Input()
    {
        var commands = Parser.Read("day2.input.txt", Day2.Parse);

        Assert.Equal(new Position1(1968, 1063), Day2.Part1(commands));
    }

    [Fact]
    public void Part2Sample()
    {
        var commands = Parser.Read("day2.sample.txt", Day2.Parse);

        Assert.Equal(new Position2(15, 60, 10), Day2.Part2(commands));
    }

    [Fact]
    public void Part2Input()
    {
        var commands = Parser.Read("day2.input.txt", Day2.Parse);

        Assert.Equal(new Position2(1968, 1060092, 1063), Day2.Part2(commands));
    }
}