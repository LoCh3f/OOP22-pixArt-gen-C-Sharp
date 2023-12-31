using PixArtMain.main.model.game;

namespace PixArtTest.model;

public class TestGame
{
    [Fact]
    public void BuilderTest()
    {
        IGame _game = new GameBuilderImpl().GameTimer(100).GameType(1).Build();

        Assert.Equal(100, _game.GameTimer);
        Assert.Equal(1, _game.GameType);
    }
}