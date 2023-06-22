using System.Drawing;
using PixArtMain.main.model.Micolucci.tools;
using PixArtMain.main.model.Micolucci.tools.DrawingTools;

namespace PixArtTest.model.Micolucci;

public class AbstractDrawingToolTest
{
    private readonly AbstractDrawingTool _tool = new Pencil(Color.Empty, 2);
    private static readonly int Pix1X = 13;
    private static readonly int Pix1Y = 13;
    private static readonly int Pix2X = 10;
    private static readonly int Pix2Y = 15;
    private static readonly int FrameSize = 16;

    [Fact]
    public void CalculatePosition()
    {
        int increment1 = 3;
        int increment2 = 5;
        Assert.Equal(Pix1X + increment1 - 1, _tool.CalculatePosition(Pix1X, increment1, FrameSize));
        Assert.Equal(Pix1Y + increment1 - 1, _tool.CalculatePosition(Pix1Y, increment1, FrameSize));
        Assert.Equal(FrameSize, _tool.CalculatePosition(Pix1X, increment2, FrameSize));
        Assert.Equal(FrameSize, _tool.CalculatePosition(Pix1Y, increment2, FrameSize));
    }

    [Fact]
    public void CalculatePosition2()
    {
        int increment = 3;
        Assert.Equal(Pix2X + increment - 1, _tool.CalculatePosition(Pix2X, increment, FrameSize));
        Assert.Equal(FrameSize, _tool.CalculatePosition(Pix2Y, increment, FrameSize));
    }
}
