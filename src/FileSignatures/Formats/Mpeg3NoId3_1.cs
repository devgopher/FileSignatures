namespace FileSignatures.Formats;

/// <summary>
/// Mp3 with no Id3
/// </summary>
public class Mpeg3NoId3_1 : FileFormat
{
    public Mpeg3NoId3_1() : base(new byte[] { 0xFF, 0xFB }, "audio/mpeg", "mp3") { }
}