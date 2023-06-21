namespace RicciProject.main;

public interface IGameBuilder
{
    IGameBuilder GameType(int _gameType);
    IGameBuilder GameTimer(int _gameTimer);
    IGame Build();
}