namespace AZH_Tankai_Shared
{
    public enum TileWallsState
    {
        Top = 1,
        Right = 2,
        Bottom = 4,
        Left = 8,
        All = Top | Right | Left | Bottom,
        Visited = 128 // Special case used for generation.
    }
}