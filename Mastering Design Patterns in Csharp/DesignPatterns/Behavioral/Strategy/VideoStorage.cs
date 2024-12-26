namespace Mastering_Design_Patterns_in_Csharp.DesignPatterns.Behavioral.Strategy;

public class VideoStorage
{
    private readonly IOverlay _overlay;
    private readonly ICompressor _compressor;

    public VideoStorage(IOverlay overlay, ICompressor compressor)
    {
        _overlay = overlay;
        _compressor = compressor;
    }

    public void Store()
    {
        _overlay.Apply();
        _compressor.Compress();
    }
}