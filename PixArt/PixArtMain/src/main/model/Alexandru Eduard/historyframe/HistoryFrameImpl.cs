
public class HistoryFrameImpl
{
    private const String DefPath = "";
    private const int DefDelay = 100;
    public String ImagePath { get; }
    public int AnimationDuration { get; }

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