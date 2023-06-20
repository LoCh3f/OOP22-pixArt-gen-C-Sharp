using System.Drawing;

namespace ViscontiProject.main;

public class MatrixImpl : IMatrix
{
    public int Width { get; }
    public int Height { get; }
    private List<PixelImpl> Pixels { get;}
    protected MatrixImpl(int width, int height)
    {
        Width = width;
        Height = height;
        Pixels = new List<PixelImpl>();
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                
                Pixels.Add(new PixelImpl(i,j,Color.White));
            }
        }
    }

  
    public void UpdatePixel(Action<PixelImpl> updater, PixelImpl pixel)
    {
        this.Pixels.ForEach(updater);
    }


}