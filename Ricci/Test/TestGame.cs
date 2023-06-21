using RicciProject.main;

namespace Test;

public class TestGame
{
    [Fact]
    public void BuilderTest()
    {
        Game _game = new GameBuilderImpl().GameTimer(100).GameType(1).Build();

        Assert.Equal(100, _game._gameTimer);
        Assert.Equal(1, _game._gameType);
    }
}