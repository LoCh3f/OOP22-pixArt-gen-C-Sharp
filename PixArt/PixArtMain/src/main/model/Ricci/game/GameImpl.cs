namespace PixArtMain.main.model.game;

public class GameImpl : IGame
{
    public int GameType { get; }
    public int GameTimer { get; }

    public GameImpl(int _gameType, int _gameTimer)
    {
        GameType = _gameType;
        GameTimer = _gameTimer;
    }
}
