namespace DefaultNamespace;

public class MatrixImpl implements Matrix
{
    public int _width { get; }
    public int _height { get; }
    public Pixel[,] _pixels { get; set; }
    public MatrixImpl(int width, int height)
    {
        _width = width;
        _height = height;
        _pixels = new Pixel[width, height];
    }
}