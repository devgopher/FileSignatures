namespace FileSignatures.Formats
{
    /// <summary>
    ///     Specifies the format of a MPEG-1 Audio Layer 3 (MP3) audio file
    /// </summary>
    public class Mpeg3Id3v2 : FileFormat
    {
        public Mpeg3Id3v2() : base(new byte[] { 0x49, 0x44, 0x33 }, "audio/mpeg", "mp3")
        {
        }
    }
}