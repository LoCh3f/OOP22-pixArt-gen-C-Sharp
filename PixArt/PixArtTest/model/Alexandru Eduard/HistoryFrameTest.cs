
using PixArtMain.main.model.Alexandru_Eduard.historyframe;

namespace PixArtTest.model.Alexandru_Eduard;

public class HistoryFrameTest
{
    public void ConstructorTest()
    {
        HistoryFrameImpl frame1 = new HistoryFrameImpl();
        Assert.Equal("", frame1.ImagePath);
        Assert.Equal(100, frame1.AnimationDuration);

        HistoryFrameImpl frame2 = new HistoryFrameImpl("/home", 2000);
        Assert.Equal("/home", frame2.ImagePath);
        Assert.Equal(2000, frame2.AnimationDuration);
    }
}