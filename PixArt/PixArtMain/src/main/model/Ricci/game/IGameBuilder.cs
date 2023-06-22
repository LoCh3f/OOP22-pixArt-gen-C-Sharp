namespace PixArtMain.main.model.game;
public interface IGameBuilder
{
    IGameBuilder GameType(int _gameType);
    IGameBuilder GameTimer(int _gameTimer);
    IGame Build();
}