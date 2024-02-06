namespace FileSignatures.Formats
{
    /// <summary>
    /// Mp3 with no Id3
    /// </summary>
    public class Mpeg3NoId3_3 : FileFormat
    {
        public Mpeg3NoId3_3() : base(new byte[] { 0xFF, 0xF2 }, "audio/mpeg", "mp3")
        {
        }
    }
}