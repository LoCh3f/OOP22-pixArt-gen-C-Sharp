namespace PixArtMain.main.model.game;

public class GameBuilderImpl : IGameBuilder
{
    private int _gameType;
    private int _gameTimer;

    public IGameBuilder GameType(int _gameType)
    {
        this._gameType = _gameType;
        return this;
    }

    public IGameBuilder GameTimer(int _gameTimer)
    {
        this._gameTimer = _gameTimer;
        return this;
    }
    
    public IGame Build()
    {
        return new GameImpl(this._gameType, this._gameTimer);
    }
}