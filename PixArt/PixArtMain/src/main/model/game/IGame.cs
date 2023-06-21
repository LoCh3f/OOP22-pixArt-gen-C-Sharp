namespace PixArtMain.main.model.game;

public interface IGame
{
    /* Decided to initialize _gameTimer and _gameType as int because
        these classes have been made by other team component*/

    int GameTimer { get; }
    int GameType { get; }
}