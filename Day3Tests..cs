namespace JakubSturc.AdventOfCode2021;

public class Day3Tests
{
    [Fact]
    public void Part1Sample()
    {
        var report = Parser.Read<string>("day3.sample.txt", Day3.Parse);

        Assert.Equal((γ: 22, ɛ: 9), Day3.Part1(report));
    }

    [Fact]
    public void Part1Input()
    {
        var report = Parser.Read<string>("day3.input.txt", Day3.Parse);

        Assert.Equal((γ: 3022, ɛ: 1073), Day3.Part1(report));
    }

    //[Fact]
    //public void Part2Sample()
    //{
    //    var commands = Parser.Read("day2.sample.txt", Day2.Parse);

    //    Assert.Equal(new Position2(15, 60, 10), Day2.Part2(commands));
    //}

    //[Fact]
    //public void Part2Input()
    //{
    //    var commands = Parser.Read("day2.input.txt", Day2.Parse);

    //    Assert.Equal(new Position2(1968, 1060092, 1063), Day2.Part2(commands));
    //}
}