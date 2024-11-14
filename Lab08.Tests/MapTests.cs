using NUnit.FrameWork;
using Lab08;

namespace Lab08.Tests
{
    public class MapTests
    {
        [Test]
        public void CanSetAndGetRoomType()
        {
            var map = new Map(5, 5);
            var location = new Location(2, 2);
            map.SetRoomAtLocation(location, RoomType.Fountain);

            Assert.AreEqual(RoomType.Fountain, map.GetRoomTypeAtLocation(location));
        }
    }
}