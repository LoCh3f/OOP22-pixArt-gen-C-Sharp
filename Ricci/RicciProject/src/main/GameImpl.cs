namespace RicciProject.main;

public class GameImpl : Game
{
    public int _gameType { get; }
    public int _gameTimer { get; }

    public GameImpl(int _gameType, int _gameTimer)
    {
        this._gameType = _gameType;
        this._gameTimer = _gameTimer;
    }
}
