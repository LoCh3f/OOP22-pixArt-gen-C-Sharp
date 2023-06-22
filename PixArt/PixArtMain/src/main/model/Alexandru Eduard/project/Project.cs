using PixArtMain.main.model.Alexandru_Eduard.historyframe;
using PixArtMain.main.model.matrix;

namespace PixArtMain.main.model.Alexandru_Eduard.project;

public interface IProject
{
    string ProjectName { get; }
    string Path { get; }
    string FileType { get; }
    List<IMatrix> Frames { get; }
    List<HistoryFrameImpl> HistoryFrames { get; }
    void AddNewFrame();

    void AddNewHistoryFrame(int index);
}