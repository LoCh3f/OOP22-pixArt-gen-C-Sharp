using PixArtMain.main.model.matrix;

namespace PixArtMain.main.model.Micolucci.tools;

public abstract class AbstractDrawingTool : AbstractTool
{
    private readonly int _toolsize;

    public AbstractDrawingTool(int toolsize)
    {
        _toolsize = toolsize;
    }

    public int GetToolSize() => _toolsize;

    public override HashSet<PixelImpl> UpdateGrid(PixelImpl pixel, HashSet<PixelImpl> frame)
    {
        HashSet<PixelImpl> newPixSet = new HashSet<PixelImpl>();
        int oppositePixX = CalculatePosition(pixel.PosX, GetToolSize(), GetFrameSize(frame));
        int oppositePixY = CalculatePosition(pixel.PosY, GetToolSize(), GetFrameSize(frame));
        
        foreach (int x in Range(pixel.PosX, oppositePixX))
        {
            foreach (int y in Range(pixel.PosY, oppositePixY))
            {
                UpdatePixel(frame, x, y, newPixSet);
            }
        }

        return newPixSet;

    }

    public abstract void UpdatePixel(HashSet<PixelImpl> frame, int x, int y, HashSet<PixelImpl> newPixSet);

    public int CalculatePosition(int i, int increment, int frameSize)
    {
        int x = i + (increment - 1) > frameSize ? frameSize : i + (increment - 1);
        return x;
    }
    
    public IEnumerable<int> Range(int x1, int x2) => Enumerable.Range(x1, x2 - x1 + 1);
}