namespace RicciProject.main;

public interface GameBuilder
{
    GameBuilder GameType(int _gameType);
    GameBuilder GameTimer(int _gameTimer);
    Game Build();
}