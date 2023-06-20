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

    public override bool Equals(Object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        PixelImpl pixel = (PixelImpl) obj;
        return PosX == pixel.PosX && PosY == pixel.PosY && Color == pixel.Color;
    }

    

    public override int GetHashCode()
    {
        return HashCode.Combine(PosX, PosY, Color);
    }
}