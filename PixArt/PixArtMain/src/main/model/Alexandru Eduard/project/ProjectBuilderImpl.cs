
namespace PixArtMain.main.model.Alexandru_Eduard.project;

public class ProjectBuilderImpl : IProjectBuilder
{
    private string _projectName = null!;
    private string _path = null!;
    private string _fileType = null!;

    public IProjectBuilder ProjectName(string projectName)
    {
        this._projectName = projectName;
        return this;
    }

    public IProjectBuilder Path(string path)
    {
        this._path = path;
        return this;
    }

    public IProjectBuilder FileType(string fileType)
    {
        this._fileType = fileType;
        return this;
    }
    
    public IProject Build()
    {
        return new ProjectImpl(this._projectName, this._path, this._fileType);
    }
}