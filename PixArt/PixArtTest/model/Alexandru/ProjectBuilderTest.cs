using PixArtMain.main.model.Alexandru_Eduard.project;

namespace PixArtTest.model.Alexandru_Eduard;

public class ProjectBuilderTest
{
    [Fact]
    public void BuilderTest()
    {
        IProject p = new ProjectBuilderImpl().ProjectName("primo").Path("/home").FileType(".png").Build();
        
        Assert.Equal("primo", p.ProjectName);
        Assert.Equal("/home", p.Path);
        Assert.Equal(".png", p.FileType);
    }
}