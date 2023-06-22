using System.Drawing;
using PixArtMain.main.model.matrix;
using PixArtMain.main.model.Micolucci.tools.DrawingTools;

namespace PixArtTest.model.Micolucci;

public class PencilTest
{
    private static readonly int ToolSize= 4;
    private static readonly Pencil TestPencil = new Pencil(Color.Black, ToolSize);
    private static readonly HashSet<PixelImpl> TestFrame = new HashSet<PixelImpl>();
    private static readonly int FrameSize = 16;
    private static readonly int PixX = 2;
    private static readonly int PixY = 2;

    private void CreateFrame()
    {
        for (int i = 0; i < FrameSize; i++)
        {
            for (int j = 0; j < FrameSize; j++)
            {
                TestFrame.Add(new PixelImpl(i, j, Color.Empty));
            }
        }
    }

    [Fact]
    public void UpdateGrid()
    {
        CreateFrame();
        Assert.Equal(FrameSize * FrameSize, TestFrame.Count);
        var pixel = new PixelImpl(PixX, PixY, Color.Empty);
        var newSet = TestPencil.UpdateGrid(pixel, TestFrame);
        Assert.Equal(FrameSize, newSet.Count);
        foreach (var p in newSet)
        {
            Assert.Equal(Color.Black, p.Color);
            Assert.True(p.PosX >= PixX && p.PosX <= PixX + ToolSize -1);
            Assert.True(p.PosY >= PixY && p.PosY <= PixY + ToolSize - 1);
        }
    }
    
}