namespace PixArtMain.main.model.historyframe;

public class HistoryFrameImpl : IHistoryFrame
{
    private const String DefPath = "";
    private const int DefDelay = 100;
    private String ImagePath { get; }
    private int AnimationDuration { get; }

    public HistoryFrameImpl(String imagePath, int animationDuration)
    {
        this.ImagePath = imagePath;
        this.AnimationDuration = animationDuration;
    }
    
    public HistoryFrameImpl()
    {
        this.ImagePath = DefPath;
        this.AnimationDuration = DefDelay;
    }
}