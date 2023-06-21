namespace PixArtMain.main.model.matrix;

public interface IMatrix
{
    void UpdatePixel(Action<PixelImpl> updater, PixelImpl pixel);
}