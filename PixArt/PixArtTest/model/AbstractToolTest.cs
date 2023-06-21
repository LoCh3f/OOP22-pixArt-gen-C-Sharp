namespace TestProjectMicolucci1;

public class AbstractToolTest
{

    private readonly AbstractTool _tool = new Pencil(null, 2);
    private readonly HashSet<PixelImpl> frame = new HashSet<PixelImpl>();

    [Fact]
    public void Test1()
    {
    }
}