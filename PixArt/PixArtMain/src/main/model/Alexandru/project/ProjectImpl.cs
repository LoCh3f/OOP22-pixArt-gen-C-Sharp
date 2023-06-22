
using PixArtMain.main.model.Alexandru_Eduard.historyframe;
using PixArtMain.main.model.matrix;

namespace PixArtMain.main.model.Alexandru_Eduard.project;

public class ProjectImpl : IProject
{
    public ProjectImpl(string projectName, string path, string fileType)
    {
        ProjectName = projectName;
        Path = path;
        FileType = fileType;
        Frames = new List<IMatrix>();
        HistoryFrames = new List<HistoryFrameImpl>();
    }

    public string ProjectName { get; }
    public string Path { get; }
    public string FileType { get; }
    public List<IMatrix> Frames { get; }
    public List<HistoryFrameImpl> HistoryFrames { get; }


    public void AddNewFrame()
    {
        this.Frames.Add(new MatrixImpl(16, 16));
    }

    public void AddNewHistoryFrame(int index)
    {
        this.HistoryFrames.Add(new HistoryFrameImpl());
    }
}