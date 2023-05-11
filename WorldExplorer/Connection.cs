namespace WorldExplorer;

public class Connection
{
    public Direction Direction { get; set; }
    public string TargetMap { get; set; }

    public Connection(Direction direction, string mapName)
    {
        Direction = direction;
        TargetMap = mapName;
    }
}