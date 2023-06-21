namespace MicolucciProject.main;

public abstract class AbstractTool
{
    public abstract HashSet<PixelImpl> UpdateGrid(PixelImpl pixel, HashSet<PixelImpl> frame);

    public int GetFrameSize(HashSet<PixelImpl> frame) => (int)System.Math.Sqrt(frame.Count);
}