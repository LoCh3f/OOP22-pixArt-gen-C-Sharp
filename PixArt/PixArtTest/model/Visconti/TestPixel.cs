using System.Drawing;
using PixArtMain.main.model.matrix;

namespace PixArtTest.model;

public class TestPixel
{
    private readonly PixelImpl _pixel = new(0, 0, Color.White);
    private readonly PixelImpl _pixel2 = new(0, 1, Color.White);
    private readonly PixelImpl _pixel3 = new(1, 0, Color.White);
    private readonly PixelImpl _pixel4 = new(1, 1, Color.White);
         
    [Fact]
    public void TestEquals()
    {
        Assert.True(_pixel.Equals(new PixelImpl(0, 0, Color.White)));
        Assert.False(_pixel.Equals(_pixel2));
        Assert.False(_pixel.Equals(_pixel3));
        Assert.False(_pixel.Equals(_pixel4));
    }

    [Fact]
    public void TestProperties()
    {
        _pixel.Color = Color.Black;
        Assert.Equal(Color.Black, _pixel.Color);
        Assert.Equal(0, _pixel.PosX);
        Assert.Equal(0, _pixel.PosY);
        Assert.NotEqual(Color.White, _pixel.Color);
    }
    
    
}