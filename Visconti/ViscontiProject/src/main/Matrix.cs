namespace ViscontiProject.main;

public interface IMatrix
{
    void UpdatePixel(Action<PixelImpl> updater, PixelImpl pixel);
}