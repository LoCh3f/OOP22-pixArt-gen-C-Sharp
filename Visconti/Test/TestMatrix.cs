using System.Drawing;

namespace Test;
using ViscontiProject.main;

public class TestMatrix
{
    private readonly MatrixImpl _matrix = new(16, 16);
    private readonly PixelImpl _pixel = new(0, 0, Color.White);
    private readonly PixelImpl _pixel2 = new(0, 1, Color.White);
    private readonly PixelImpl _pixel3 = new(0, 2, Color.White);
    
    [Fact]
    public void TestMatrixProperties()
    {
        Assert.Equal(16, _matrix.Width);
        Assert.Equal(16, _matrix.Height);
        Assert.Equal(256, _matrix.Pixels.Count);
        Assert.Equal(_pixel, _matrix.Pixels[0]);
    }

    [Fact]
    public void TestUpdate()
    {
        _pixel.Color = Color.Black;
        _matrix.UpdatePixel(p => {
            if (p.PosX == _pixel.PosX && p.PosY == _pixel.PosY)
            {
                p.Color = _pixel.Color;
            }}, _pixel);
        Assert.Equal(_pixel, _matrix.Pixels[0]);
        
        _pixel2.Color = Color.Black;
        _matrix.UpdatePixel(p => {
            if (p.PosX == _pixel2.PosX && p.PosY == _pixel2.PosY)
            {
                p.Color = _pixel2.Color;
            }}, _pixel2);
        Assert.Equal(_pixel2, _matrix.Pixels[1]);
        
        _pixel3.Color = Color.Black;
        _matrix.UpdatePixel(p => {
            if (p.PosX == _pixel3.PosX && p.PosY == _pixel3.PosY)
            {
                p.Color = _pixel3.Color;
            }}, _pixel3);
        Assert.Equal(_pixel3, _matrix.Pixels[2]);
        
    }
}