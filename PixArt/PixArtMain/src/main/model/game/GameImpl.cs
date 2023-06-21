namespace PixArtMain.main.model.game;

public class GameImpl : IGame
{
    public int _gameType { get; }
    public int _gameTimer { get; }

    public GameImpl(int _gameType, int _gameTimer)
    {
        this._gameType = _gameType;
        this._gameTimer = _gameTimer;
    }
}
