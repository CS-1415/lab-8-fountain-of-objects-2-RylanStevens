namespace Lab08
{
    public enum RoomType { Entrance, Fountain, Pit, Normal }

    public class Map
    {
        private RoomType[,] grid;
        public Map(int width, int height)
        {
            grid = new RoomType[width, height];
        }

        public int Width => grid.GetLength(0);
        public int Height => grid.GetLength(1);

        public RoomType GetRoomTypeAtLocation(Location location) => grid[location.X, location.Y];

        public void SetRoomAtLocation(Location location, RoomType roomType)
        {
            grid[location.X, location.Y] = roomType;
        }
    }
}