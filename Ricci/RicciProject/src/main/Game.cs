namespace RicciProject.main;

public interface Game
{
    /* Decided to initialize _gameTimer and _gameType as int because
        these classes have been made by other team component*/

    int _gameTimer { get; }
    int _gameType { get; }
}