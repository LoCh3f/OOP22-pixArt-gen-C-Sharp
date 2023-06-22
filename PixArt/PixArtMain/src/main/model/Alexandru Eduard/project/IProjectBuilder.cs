
namespace PixArtMain.main.model.Alexandru_Eduard.project;

public interface IProjectBuilder
{
    IProjectBuilder ProjectName(string projectName);

    IProjectBuilder Path(string path);

    IProjectBuilder FileType(string fileType);
    
    IProject Build();
}