namespace PixArtMain.main.model.historyframe;

public class HistoryFrameImpl : IHistoryFrame
{
    private String _imagePath { get; }
    private int _animationDuration { get; }

    public HistoryFrameImpl(String _imagePath, int _animationDuration)
    {
        this._imagePath = _imagePath;
        this._animationDuration = _animationDuration;
    }
}