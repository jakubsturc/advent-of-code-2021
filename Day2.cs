namespace JakubSturc.AdventOfCode2021;

public class Day2
{
    public static Command Parse(string line) => Command.Parse(line);

    public static Position1 Part1(IEnumerable<Command> commands) 
        => commands.Aggregate
        (
            seed: new Position1(0, 0),
            func: (p, c) => p.Apply(c)
        );

    public static Position2 Part2(IEnumerable<Command> commands)
            => commands.Aggregate
            (
                seed: new Position2(0, 0, 0),
                func: (p, c) => p.Apply(c)
            );
}

public record struct Position2(int Horizontal, int Depth, int Aim)
{
    public Position2 Apply(Command c) => c.Dir switch
    {
        Direction.Forward => new Position2(Horizontal + c.Units, Depth + Aim * c.Units, Aim),
        Direction.Up => new Position2(Horizontal, Depth, Aim - c.Units),
        Direction.Down => new Position2(Horizontal, Depth, Aim + c.Units),
        _ => throw new ArgumentException()
    };
}

public record struct Position1(int Horizontal, int Depth) 
{
    public Position1 Apply(Command c) => c.Dir switch
    {
        Direction.Forward => new Position1(Horizontal + c.Units, Depth),
        Direction.Up => new Position1(Horizontal, Depth - c.Units),
        Direction.Down => new Position1(Horizontal, Depth + c.Units),
        _ => throw new ArgumentException()
    };
}

public record struct Command(Direction Dir, int Units) 
{
    public static Command Parse(string line) => line[0] switch
    {
        'f' => new Command(Direction.Forward, int.Parse(line.Substring(8))),
        'd' => new Command(Direction.Down, int.Parse(line.Substring(5))),
        'u' => new Command(Direction.Up, int.Parse(line.Substring(3))),
        _ => throw new ArgumentException()
    };
}

public enum Direction { Forward, Up, Down }