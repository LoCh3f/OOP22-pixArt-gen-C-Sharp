namespace RicciProject.main;

public class GameBuilderImpl : GameBuilder
{
    private int _gameType;
    private int _gameTimer;

    public GameBuilder GameType(int _gameType)
    {
        this._gameType = _gameType;
        return this;
    }

    public GameBuilder GameTimer(int _gameTimer)
    {
        this._gameTimer = _gameTimer;
        return this;
    }
    
    public Game Build()
    {
        return new GameImpl(this._gameType, this._gameTimer);
    }
}