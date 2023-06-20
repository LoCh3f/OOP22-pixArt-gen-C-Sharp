using System.Drawing;

namespace ViscontiProject.main;

public class PixelImpl 
{
    public PixelImpl(int posX, int posY, Color color)
    {
        PosX = posX;
        PosY = posY;
        Color = color;
    }

    public int PosX { get; }
    public int PosY { get; }
    public Color Color { get; set; }
}