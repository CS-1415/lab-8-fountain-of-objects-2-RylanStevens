using NUnit.Framework;
using Lab08;

namespace Lab08.Tests
{
    [Test]
    public void PlayerTakesDamageCorrectly()
    {
        var player = new Player(new Location(0, 0));
        player.TakeDamage(30);

        Assert.AreEqual(70, player.Health);
    }
}